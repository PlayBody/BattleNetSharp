using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using D2Data;
using D2GameState;
using D2Map;
using D2Packets;
using D2Packets.Game.Client;
using D2Packets.Game.Server;
using Microsoft.CSharp.RuntimeBinder;

namespace BattleNetSharp.D2.Resurrected
{
	// Token: 0x02000B1B RID: 2843
	public class Client
	{
		// Token: 0x17003954 RID: 14676
		// (get) Token: 0x0600BF37 RID: 48951 RVA: 0x0049A9C6 File Offset: 0x00498BC6
		// (set) Token: 0x0600BF38 RID: 48952 RVA: 0x0049A9CE File Offset: 0x00498BCE
		public virtual int Port { get; set; }

		// Token: 0x0600BF39 RID: 48953 RVA: 0x0049A9D7 File Offset: 0x00498BD7
		public void Init(List<byte> secret)
		{
			this.Secret = secret;
		}

		// Token: 0x0600BF3A RID: 48954 RVA: 0x0049A9E4 File Offset: 0x00498BE4
		public void Connect(IPAddress server, int port)
		{
			this.TcpClient = new TcpClient();
			this.TcpClient.Connect(server, 443);
			this.BaseStream = this.TcpClient.GetStream();
			this.Stream = new SslStream(this.BaseStream, false, new RemoteCertificateValidationCallback(Client.ValidateServerCertificate), null);
			this.Stream.AuthenticateAsClient("*.classic.blizzard.com");
			int num = this.Stream.ReadByte();
			int num2 = this.Stream.ReadByte();
			this.Compression = num2 == 1;
			this.SendPacket(new GameLogonRequest(this.Secret));
			this.PingHandler = Task.Run(delegate
			{
				while (this.TcpClient.Connected && this.KeepPinging)
				{
					this.PingCalc = Environment.TickCount;
					this.SendPacket(new Ping
					{
						TickCount = (uint)Environment.TickCount,
						PreviousPing = (ulong)((long)this.Random.Next(80, 90))
					});
					Thread.Sleep(5000);
				}
			});
			this.PacketHandler = Task.Run(delegate
			{
				while (this.HandlePackets)
				{
					this.HandlePacket();
					bool flag = !this.TcpClient.Connected;
					if (flag)
					{
						break;
					}
				}
			});
		}

		// Token: 0x0600BF3B RID: 48955 RVA: 0x0049AAB8 File Offset: 0x00498CB8
		public void ConnectStart(IPAddress server, int port)
		{
			this.TcpClient = new TcpClient();
			this.TcpClient.Connect(server, 443);
			this.BaseStream = this.TcpClient.GetStream();
			this.Stream = new SslStream(this.BaseStream, false, new RemoteCertificateValidationCallback(Client.ValidateServerCertificate), null);
			this.Stream.AuthenticateAsClient("*.classic.blizzard.com");
			int num = this.Stream.ReadByte();
			int num2 = this.Stream.ReadByte();
			this.Compression = num2 == 1;
		}

		// Token: 0x0600BF3C RID: 48956 RVA: 0x0049AB4C File Offset: 0x00498D4C
		public void ConnectEnd(IPAddress server, int port)
		{
			this.SendPacket(new GameLogonRequest(this.Secret));
			this.PingHandler = Task.Run(delegate
			{
				while (this.TcpClient.Connected && this.KeepPinging)
				{
					this.PingCalc = Environment.TickCount;
					this.SendPacket(new Ping
					{
						TickCount = (uint)Environment.TickCount,
						PreviousPing = (ulong)((long)this.Random.Next(80, 90))
					});
					Thread.Sleep(5000);
				}
			});
			this.PacketHandler = Task.Run(delegate
			{
				while (this.HandlePackets)
				{
					this.HandlePacket();
					bool flag = !this.TcpClient.Connected;
					if (flag)
					{
						break;
					}
				}
			});
		}

		// Token: 0x0600BF3D RID: 48957 RVA: 0x0049AB9C File Offset: 0x00498D9C
		public void WriteLine(string s)
		{
			bool flag = this.logging;
			if (flag)
			{
				StackTrace stackTrace = new StackTrace(new StackFrame(1));
				Console.WriteLine(stackTrace.GetFrame(0).GetMethod().Name + " : " + s);
			}
		}

        // Token: 0x0600BF3E RID: 48958 RVA: 0x0049ABE4 File Offset: 0x00498DE4
		// [Ares] from GPT, should review
        public void HandlePacket()
        {
            List<byte> buffer = new List<byte>();
            buffer.AddRange(this.combinePacket);
            byte[] receiveBuffer = new byte[this.TcpClient.ReceiveBufferSize];

            try
            {
                int bytesRead = this.Stream.Read(receiveBuffer, 0, receiveBuffer.Length);
                buffer.AddRange(receiveBuffer.Take(bytesRead));
                if (bytesRead == 0)
                {
                    this.Stream.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading from server: " + ex.Message);
                this.KeepPinging = this.HandlePackets = false;
                return;
            }

            Type packetTypeBase = typeof(GameServerPacket);

            while (buffer.Count > 0)
            {
                this.combinePacket = Array.Empty<byte>();
                int packetLength = 0;

                string packetTypeName = packetTypeBase.AssemblyQualifiedName.Replace(packetTypeBase.Name, ((GameServerPacket)buffer[0]).ToString());
                Type packetType = Type.GetType(packetTypeName);

                if (packetType == null)
                {
                    Console.WriteLine("No server packet info for: " + buffer[0].ToString("X"));
                    Console.WriteLine(BitConverter.ToString(buffer.ToArray()));
                    break;
                }

                if (buffer[0] == 2)
                {
                    if (this.LogonSuccess)
                    {
                        buffer = buffer.Skip(1).ToList();
                        continue;
                    }
                    this.LogonSuccess = true;
                }

                if (this.logging && !this.clientOnly)
                {
                    Console.WriteLine($"s2c: {BitConverter.ToString(this.Secret.ToArray())} ({DateTime.UtcNow:HH:mm:ss.fff}): {packetType.Name}");
                }

                int numBytes;
                bool validPacketSize = GameServerPacketSizes.GetPacketSize(buffer, out numBytes, true);

                if (this.logging && !this.clientOnly)
                {
                    Console.WriteLine("    : " + BitConverter.ToString(buffer.Take(numBytes).ToArray()));
                }

                if (!validPacketSize || buffer.Count < numBytes)
                {
                    Console.WriteLine("Combining packet: " + BitConverter.ToString(buffer.ToArray()));
                    this.combinePacket = buffer.ToArray();
                    break;
                }

                object packetInstance = Activator.CreateInstance(packetType);
                try
                {
                    dynamic dynamicPacket = packetInstance;
                    dynamicPacket.PacketVersion = GameVersion.D2R;
                    dynamicPacket.Bytes = buffer;
                }
                catch
                {
                    Console.WriteLine("Parse fail 1: " + BitConverter.ToString(buffer.ToArray()));
                    this.combinePacket = buffer.ToArray();
                    break;
                }

                if (packetLength == 0)
                {
                    FieldInfo lengthField = packetType.GetField("Length");
                    if (lengthField != null)
                    {
                        try
                        {
                            packetLength = (int)lengthField.GetValue(packetInstance);
                        }
                        catch
                        {
                            Console.WriteLine("Parse fail 2: " + BitConverter.ToString(buffer.ToArray()));
                        }
                    }
                    else
                    {
                        try
                        {
                            packetLength = ((dynamic)packetInstance).Bytes.ToArray().Length;
                        }
                        catch
                        {
                            Console.WriteLine("Parse fail 3: " + BitConverter.ToString(buffer.ToArray()));
                        }
                    }
                }

                if (this.waitingForPacket?.Invoke((dynamic)packetInstance) == true)
                {
                    this.waitingForPacket = null;
                }

                MethodInfo packetHandler = this.GetType().GetMethod(packetType.Name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy)
                    ?? this.GetType().BaseType.GetMethod(packetType.Name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);

                packetHandler?.Invoke(this, new object[] { packetInstance });

                buffer = buffer.Skip(numBytes).ToList();
            }
        }

        // Token: 0x0600BF3F RID: 48959 RVA: 0x0049B308 File Offset: 0x00499508
        public void WaitForPacket(Client.WaitingForPacketDelegate waitUntilReceivedPacket)
		{
			this.waitingForPacket = waitUntilReceivedPacket;
			while (this.waitingForPacket != null)
			{
				Thread.Sleep(50);
			}
		}

		// Token: 0x0600BF40 RID: 48960 RVA: 0x0049B334 File Offset: 0x00499534
		public void SendPacket(Packet packet, ushort minSleep, ushort maxSleep)
		{
			this.SendPacket(packet);
			Thread.Sleep(this.Random.Next((int)minSleep, (int)maxSleep));
		}

		// Token: 0x0600BF41 RID: 48961 RVA: 0x0049B354 File Offset: 0x00499554
		public bool SendPacket(Packet packet, Client.WaitingForPacketDelegate waitUntilReceivedPacket)
		{
			this.waitingForPacket = waitUntilReceivedPacket;
			this.SendPacket(packet);
			int num = 0;
			while (this.waitingForPacket != null)
			{
				Thread.Sleep(16);
				bool flag = num++ > 100;
				if (flag)
				{
					Console.WriteLine("packet never received : " + Environment.StackTrace);
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600BF42 RID: 48962 RVA: 0x0049B3B8 File Offset: 0x004995B8
		public void SendPacket(Packet packet)
		{
			packet.PacketVersion = GameVersion.D2R;
			byte[] array = packet.ToArray();
			this.SendPacket(array);
		}

		// Token: 0x0600BF43 RID: 48963 RVA: 0x0049B3E0 File Offset: 0x004995E0
		public bool SendPacket(byte[] packetBytes, Client.WaitingForPacketDelegate waitUntilReceivedPacket)
		{
			this.waitingForPacket = waitUntilReceivedPacket;
			this.SendPacket(packetBytes);
			int num = 0;
			while (this.waitingForPacket != null)
			{
				Thread.Sleep(16);
				bool flag = num++ > 100;
				if (flag)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600BF44 RID: 48964 RVA: 0x0049B430 File Offset: 0x00499630
		public void SendPacket(byte[] packetBytes)
		{
			int? currentId = Task.CurrentId;
			int? behaviorTaskId = this.BehaviorTaskId;
			bool flag = (currentId.GetValueOrDefault() == behaviorTaskId.GetValueOrDefault()) & (currentId != null == (behaviorTaskId != null));
			while (flag && this.Chickening)
			{
				Thread.Sleep(100);
			}
			bool flag2 = this.logging;
			if (flag2)
			{
				string text = Enum.GetNames(typeof(GameClientPacketD2R))[Enum.GetValues(typeof(GameClientPacketD2R)).Cast<byte>().ToList<byte>()
					.IndexOf(packetBytes[0])];
				Console.WriteLine(string.Concat(new string[]
				{
					"c2s : ",
					BitConverter.ToString(this.Secret.ToArray()),
					" : ",
					text,
					" :",
					DateTime.Now.ToString("hh:mm:ss.fff"),
					" : (",
					BitConverter.ToString(packetBytes.Take(32).ToArray<byte>())
				}));
			}
			bool flag3 = !this.TcpClient.Connected;
			if (!flag3)
			{
				object net = this.Net;
				lock (net)
				{
					this.Stream.Write(packetBytes, 0, packetBytes.Length);
				}
			}
		}

		// Token: 0x0600BF45 RID: 48965 RVA: 0x0049B59C File Offset: 0x0049979C
		public void Terminate()
		{
			Console.WriteLine("terminating : \n" + new StackTrace(true).ToString());
			this.KeepPinging = false;
			this.HandlePackets = false;
			this.behaviorCancel.Cancel();
			try
			{
				SslStream stream = this.Stream;
				Task task = ((stream != null) ? stream.ShutdownAsync() : null);
				if (task != null)
				{
					task.Wait();
				}
				SslStream stream2 = this.Stream;
				if (stream2 != null)
				{
					stream2.Dispose();
				}
				TcpClient tcpClient = this.TcpClient;
				if (tcpClient != null)
				{
					tcpClient.Dispose();
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600BF46 RID: 48966 RVA: 0x0049B63C File Offset: 0x0049983C
		public static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return true;
		}

		// Token: 0x17003955 RID: 14677
		// (get) Token: 0x0600BF47 RID: 48967 RVA: 0x0049B650 File Offset: 0x00499850
		public Player me
		{
			get
			{
				return this.GameInstance.Players.ContainsKey(this.myId) ? this.GameInstance.Players[this.myId] : this.dummy;
			}
		}

		// Token: 0x0600BF48 RID: 48968 RVA: 0x0049B698 File Offset: 0x00499898
		private void GameLogonSuccess(GameLogonSuccess data)
		{
			bool flag = !this.logonSuccess;
			if (flag)
			{
				this.SendPacket(new EnterGame());
			}
			this.logonSuccess = true;
		}

		// Token: 0x0600BF49 RID: 48969 RVA: 0x0049B6C8 File Offset: 0x004998C8
		private void GameOver(GameOver data)
		{
			Console.WriteLine("s2c gameover : " + BitConverter.ToString(this.Secret.ToArray()));
			this.Stream.Close();
			this.BaseStream.Close();
			this.TcpClient.Close();
		}

		// Token: 0x0600BF4A RID: 48970 RVA: 0x0049B71A File Offset: 0x0049991A
		private void GameLogonReceipt(GameLogonReceipt data)
		{
			this.difficulty = data.Difficulty;
		}

		// Token: 0x0600BF4B RID: 48971 RVA: 0x0049B72C File Offset: 0x0049992C
		public AreaLevel GetCurrentLevel()
		{
			bool flag = this.me.X == ushort.MaxValue && this.me.Y == ushort.MaxValue;
			AreaLevel areaLevel;
			if (flag)
			{
				areaLevel = AreaLevel.None;
			}
			else
			{
				bool flag2 = this.me.X == 0 && this.me.Y == 0;
				if (flag2)
				{
					areaLevel = AreaLevel.None;
				}
				else
				{
					bool flag3 = !this.LoadedMap;
					if (flag3)
					{
						areaLevel = AreaLevel.None;
					}
					else
					{
						for (AreaLevel areaLevel2 = AreaLevelHelper.GetLastLevel(this.currentAct); areaLevel2 >= AreaLevelHelper.GetTownLevel(this.currentAct); areaLevel2 = (AreaLevel)(areaLevel2 - AreaLevel.RogueEncampment))
						{
							bool flag4 = (uint)this.me.X > this.GameInstance.LevelData[areaLevel2].X && (uint)this.me.X < this.GameInstance.LevelData[areaLevel2].X + this.GameInstance.LevelData[areaLevel2].Width && (uint)this.me.Y > this.GameInstance.LevelData[areaLevel2].Y && (uint)this.me.Y < this.GameInstance.LevelData[areaLevel2].Y + this.GameInstance.LevelData[areaLevel2].Height;
							if (flag4)
							{
								this.me.Area = areaLevel2;
								return areaLevel2;
							}
						}
						areaLevel = AreaLevel.None;
					}
				}
			}
			return areaLevel;
		}

		// Token: 0x0600BF4C RID: 48972 RVA: 0x0049B8C4 File Offset: 0x00499AC4
		public bool InTown()
		{
			AreaLevel currentLevel = this.GetCurrentLevel();
			return currentLevel == AreaLevel.RogueEncampment || currentLevel == AreaLevel.LutGholein || currentLevel == AreaLevel.KurastDocks || currentLevel == AreaLevel.ThePandemoniumFortress || currentLevel == AreaLevel.Harrogath || currentLevel == AreaLevel.None;
		}

		// Token: 0x0600BF4D RID: 48973 RVA: 0x0049B908 File Offset: 0x00499B08
		private void AssignPlayer(AssignPlayer player)
		{
			bool flag = !this.Loaded;
			if (flag)
			{
				this.Loaded = true;
				this.myId = player.Id;
			}
			this.AddPlayerToList(new Player
			{
				Id = player.Id,
				Name = player.Name,
				Class = player.Class,
				X = player.X,
				Y = player.Y
			});
		}

		// Token: 0x0600BF4E RID: 48974 RVA: 0x0049B980 File Offset: 0x00499B80
		private void PlayerLifeManaChange(PlayerLifeManaChange lifeManaChange)
		{
			this.me.X = lifeManaChange.X;
			this.me.Y = lifeManaChange.Y;
			this.me.Life = lifeManaChange.Life;
			this.me.Mana = lifeManaChange.Mana;
			this.me.Stamina = lifeManaChange.Stamina;
			Action onPlayerLifeManaChange = this.OnPlayerLifeManaChange;
			if (onPlayerLifeManaChange != null)
			{
				onPlayerLifeManaChange();
			}
		}

		// Token: 0x0600BF4F RID: 48975 RVA: 0x0049B9F8 File Offset: 0x00499BF8
		private void PlayerLifeManaChangeRegen(PlayerLifeManaChangeRegen lifeManaChange)
		{
			this.me.X = lifeManaChange.X;
			this.me.Y = lifeManaChange.Y;
			this.me.Life = lifeManaChange.Life;
			this.me.Mana = lifeManaChange.Mana;
			this.me.Stamina = lifeManaChange.Stamina;
			Action onPlayerLifeManaChange = this.OnPlayerLifeManaChange;
			if (onPlayerLifeManaChange != null)
			{
				onPlayerLifeManaChange();
			}
		}

		// Token: 0x0600BF50 RID: 48976 RVA: 0x0049BA70 File Offset: 0x00499C70
		private void PlayerReassign(PlayerReassign player)
		{
			this.teleportReturned = true;
			bool flag = this.me.X == 0 && this.behaviorTask == null;
			if (flag)
			{
				this.behaviorTask = Task.Run(delegate
				{
					this.BehaviorTaskId = Task.CurrentId;
					while (!this.LoadedMap)
					{
						Thread.Sleep(100);
					}
					Action behavior = this.Behavior;
					if (behavior != null)
					{
						behavior();
					}
				}, this.behaviorCancel.Token);
			}
			bool flag2 = player.Type == UnitType.Player;
			if (flag2)
			{
				this.AddPlayerToList(new Player
				{
					Id = player.Id,
					X = player.X,
					Y = player.Y
				});
			}
		}

		// Token: 0x0600BF51 RID: 48977 RVA: 0x0049BB04 File Offset: 0x00499D04
		private void AddPlayerToList(Player player)
		{
			bool flag = this.GameInstance.Players.ContainsKey(player.Id);
			if (flag)
			{
				bool flag2 = player.Name != "";
				if (flag2)
				{
					this.GameInstance.Players[player.Id].Name = player.Name;
				}
				bool flag3 = player.Class != CharacterClass.Invalid;
				if (flag3)
				{
					this.GameInstance.Players[player.Id].Class = player.Class;
				}
				bool flag4 = player.X != ushort.MaxValue && player.X > 0;
				if (flag4)
				{
					this.GameInstance.Players[player.Id].X = player.X;
				}
				bool flag5 = player.Y != ushort.MaxValue && player.Y > 0;
				if (flag5)
				{
					this.GameInstance.Players[player.Id].Y = player.Y;
				}
				bool flag6 = player.Area != AreaLevel.Invalid;
				if (flag6)
				{
					this.GameInstance.Players[player.Id].Area = player.Area;
				}
				bool flag7 = player.Party != ushort.MaxValue;
				if (flag7)
				{
					this.GameInstance.Players[player.Id].Party = player.Party;
				}
			}
			else
			{
				this.GameInstance.Players[player.Id] = player;
			}
		}

		// Token: 0x0600BF52 RID: 48978 RVA: 0x0049BC9D File Offset: 0x00499E9D
		private void AssignNPC(AssignNPC npc)
		{
			this.AddOrUpdateNPC(npc);
		}

		// Token: 0x0600BF53 RID: 48979 RVA: 0x0049BCA8 File Offset: 0x00499EA8
		private void NPCMove(NPCMove npc)
		{
			this.AddOrUpdateNPC(new AssignNPC
			{
				Id = npc.Id,
				X = npc.X,
				Y = npc.Y
			});
		}

		// Token: 0x0600BF54 RID: 48980 RVA: 0x0049BCDB File Offset: 0x00499EDB
		private void NPCMoveToTarget(NPCMoveToTarget npc)
		{
			this.AddOrUpdateNPC(new AssignNPC
			{
				Id = npc.Id,
				X = npc.X,
				Y = npc.Y
			});
		}

		// Token: 0x0600BF55 RID: 48981 RVA: 0x0049BD0E File Offset: 0x00499F0E
		private void NPCStop(NPCStop npc)
		{
			this.AddOrUpdateNPC(new AssignNPC
			{
				Id = npc.Id,
				X = npc.X,
				Y = npc.Y,
				Life = npc.Life
			});
		}

		// Token: 0x0600BF56 RID: 48982 RVA: 0x0049BD4D File Offset: 0x00499F4D
		private void NPCGetHit(NPCGetHit npc)
		{
			this.AddOrUpdateNPC(new AssignNPC
			{
				Id = npc.Id,
				Life = npc.Life
			});
		}

		// Token: 0x0600BF57 RID: 48983 RVA: 0x0049BD74 File Offset: 0x00499F74
		private void SetNPCMode(SetNPCMode npc)
		{
			this.AddOrUpdateNPC(new AssignNPC
			{
				Id = npc.Id,
				X = npc.X,
				Y = npc.Y,
				Life = 0,
				AnimationMode = (byte)((npc.Mode == NPCMode.Dead || npc.Mode == NPCMode.Dying) ? 12 : 0)
			});
		}

		// Token: 0x0600BF58 RID: 48984 RVA: 0x0049BDD8 File Offset: 0x00499FD8
		private void AddOrUpdateNPC(AssignNPC npc)
		{
			bool flag = this.GameInstance.NPCs.ContainsKey(npc.Id);
			if (flag)
			{
				bool flag2 = npc.NpcType != NPCCode.NotApplicable;
				if (flag2)
				{
					this.GameInstance.NPCs[npc.Id].NpcType = npc.NpcType;
				}
				bool flag3 = npc.X != ushort.MaxValue;
				if (flag3)
				{
					this.GameInstance.NPCs[npc.Id].X = npc.X;
				}
				bool flag4 = npc.Y != ushort.MaxValue;
				if (flag4)
				{
					this.GameInstance.NPCs[npc.Id].Y = npc.Y;
				}
				bool flag5 = npc.Life != byte.MaxValue;
				if (flag5)
				{
					this.GameInstance.NPCs[npc.Id].Life = npc.Life;
				}
				bool flag6 = npc.Name != "";
				if (flag6)
				{
					this.GameInstance.NPCs[npc.Id].Name = npc.Name;
				}
			}
			else
			{
				this.GameInstance.NPCs[npc.Id] = npc;
			}
		}

		// Token: 0x0600BF59 RID: 48985 RVA: 0x0049BF30 File Offset: 0x0049A130
		private void RemoveGroundUnit(RemoveGroundUnit unit)
		{
			bool flag = unit.Type == UnitType.GameObject;
			if (flag)
			{
				AssignGameObject assignGameObject;
				this.GameInstance.GameObjects.TryRemove(unit.Id, out assignGameObject);
				PortalInfo portalInfo;
				this.GameInstance.PortalsInfo.TryRemove(unit.Id, out portalInfo);
				PortalOwnership portalOwnership;
				this.GameInstance.PortalsOwnership.TryRemove(unit.Id, out portalOwnership);
			}
			else
			{
				bool flag2 = unit.Type == UnitType.Warp;
				if (flag2)
				{
					AssignWarp assignWarp;
					this.GameInstance.Warps.TryRemove(unit.Id, out assignWarp);
				}
				else
				{
					bool flag3 = unit.Type == UnitType.Item;
					if (flag3)
					{
						ItemAction itemAction;
						this.GameInstance.Items.TryRemove(unit.Id, out itemAction);
					}
				}
			}
		}

		// Token: 0x0600BF5A RID: 48986 RVA: 0x0049BFEC File Offset: 0x0049A1EC
		private void WalkVerify(WalkVerify walkVerify)
		{
			this.me.X = walkVerify.X;
			this.me.Y = walkVerify.Y;
			this.me.Stamina = walkVerify.Stamina;
			this.walkVerified = true;
		}

		// Token: 0x0600BF5B RID: 48987 RVA: 0x0049C02C File Offset: 0x0049A22C
		private void LoadAct(LoadAct loadAct)
		{
			this.currentAct = loadAct.Act;
			bool flag = this.GameInstance.LevelData == null;
			if (flag)
			{
				this.GameInstance.LevelData = new ConcurrentDictionary<AreaLevel, Level>();
			}
			this.mapSeed = loadAct.MapId;
			bool flag2 = File.Exists("C:\\Users\\shalzuth\\Documents\\GitHub\\BattleNetSharp\\d2mapper\\bin\\Debug\\net6.0\\d2mapper.exe");
			if (flag2)
			{
				ConcurrentDictionary<AreaLevel, Level> actLevels = MapApi.GetActLevels(loadAct.MapId, this.difficulty, this.currentAct, false, true);
				foreach (KeyValuePair<AreaLevel, Level> keyValuePair in actLevels)
				{
					this.GameInstance.LevelData.TryAdd(keyValuePair.Key, keyValuePair.Value);
				}
				foreach (KeyValuePair<AreaLevel, Level> keyValuePair2 in this.GameInstance.LevelData)
				{
					keyValuePair2.Value.ThickenWalls();
				}
				Level.StitchAct(this.GameInstance.LevelData, loadAct.Act);
			}
			this.LoadedMap = true;
		}

		// Token: 0x0600BF5C RID: 48988 RVA: 0x0049C164 File Offset: 0x0049A364
		private void GameLoading(GameLoading data)
		{
		}

		// Token: 0x0600BF5D RID: 48989 RVA: 0x0049C167 File Offset: 0x0049A367
		private void PartyRefresh(PartyRefresh data)
		{
		}

		// Token: 0x0600BF5E RID: 48990 RVA: 0x0049C16A File Offset: 0x0049A36A
		private void Pong(Pong data)
		{
			this.Latency = Environment.TickCount - this.PingCalc;
		}

		// Token: 0x0600BF5F RID: 48991 RVA: 0x0049C17F File Offset: 0x0049A37F
		private void PlayerInSight(PlayerInSight data)
		{
		}

		// Token: 0x0600BF60 RID: 48992 RVA: 0x0049C182 File Offset: 0x0049A382
		private void SkillsLog(SkillsLog data)
		{
			this.SkillLog = data;
		}

		// Token: 0x0600BF61 RID: 48993 RVA: 0x0049C18C File Offset: 0x0049A38C
		private void UpdateSkill(UpdateSkill updateSkill)
		{
			this.SkillLog[updateSkill.Skill] = (byte)(updateSkill.Level + updateSkill.Bonus);
		}

		// Token: 0x0600BF62 RID: 48994 RVA: 0x0049C1AF File Offset: 0x0049A3AF
		private void UpdateQuestInfo(UpdateQuestInfo data)
		{
			this.updateQuestInfo = data;
		}

		// Token: 0x0600BF63 RID: 48995 RVA: 0x0049C1B9 File Offset: 0x0049A3B9
		private void UpdateGameQuestLog(UpdateGameQuestLog data)
		{
			this.gameQuestLog = data;
		}

		// Token: 0x0600BF64 RID: 48996 RVA: 0x0049C1C3 File Offset: 0x0049A3C3
		private void QuestItemState(QuestItemState data)
		{
			this.questItemStates.Add(data);
		}

		// Token: 0x0600BF65 RID: 48997 RVA: 0x0049C1D3 File Offset: 0x0049A3D3
		private void GameHandshake(GameHandshake data)
		{
		}

		// Token: 0x0600BF66 RID: 48998 RVA: 0x0049C1D6 File Offset: 0x0049A3D6
		private void LoadDone(LoadDone data)
		{
		}

		// Token: 0x0600BF67 RID: 48999 RVA: 0x0049C1D9 File Offset: 0x0049A3D9
		private void UnloadDone(UnloadDone data)
		{
		}

		// Token: 0x0600BF68 RID: 49000 RVA: 0x0049C1DC File Offset: 0x0049A3DC
		private void NPCIntro(NPCIntro data)
		{
		}

		// Token: 0x0600BF69 RID: 49001 RVA: 0x0049C1DF File Offset: 0x0049A3DF
		private void NPCWantsInteract(NPCWantsInteract data)
		{
		}

		// Token: 0x0600BF6A RID: 49002 RVA: 0x0049C1E2 File Offset: 0x0049A3E2
		private void PlaySound(PlaySound data)
		{
		}

		// Token: 0x0600BF6B RID: 49003 RVA: 0x0049C1E5 File Offset: 0x0049A3E5
		private void AddUnit(MultipleStates unit)
		{
		}

		// Token: 0x0600BF6C RID: 49004 RVA: 0x0049C1E8 File Offset: 0x0049A3E8
		private void AttributeByte(AttributeByte data)
		{
			Action<D2Packets.Game.Server.Attribute> onAttributeChange = this.OnAttributeChange;
			if (onAttributeChange != null)
			{
				onAttributeChange(data);
			}
			this.me.Attributes[data.Stat.Type] = (uint)data.Value;
		}

		// Token: 0x0600BF6D RID: 49005 RVA: 0x0049C220 File Offset: 0x0049A420
		private void AttributeWord(AttributeWord data)
		{
			Action<D2Packets.Game.Server.Attribute> onAttributeChange = this.OnAttributeChange;
			if (onAttributeChange != null)
			{
				onAttributeChange(data);
			}
			this.me.Attributes[data.Stat.Type] = (uint)data.Value;
		}

		// Token: 0x0600BF6E RID: 49006 RVA: 0x0049C258 File Offset: 0x0049A458
		private void AttributeDWord(AttributeDWord data)
		{
			Action<D2Packets.Game.Server.Attribute> onAttributeChange = this.OnAttributeChange;
			if (onAttributeChange != null)
			{
				onAttributeChange(data);
			}
			this.me.Attributes[data.Stat.Type] = data.Value;
		}

		// Token: 0x0600BF6F RID: 49007 RVA: 0x0049C290 File Offset: 0x0049A490
		private void ExperienceByte(ExperienceByte data)
		{
			this.me.Attributes[StatType.Experience] = (uint)data.Experience;
		}

		// Token: 0x0600BF70 RID: 49008 RVA: 0x0049C2AC File Offset: 0x0049A4AC
		private void ExperienceUInt16(ExperienceUInt16 data)
		{
			this.me.Attributes[StatType.Experience] = (uint)data.Experience;
		}

		// Token: 0x0600BF71 RID: 49009 RVA: 0x0049C2C8 File Offset: 0x0049A4C8
		private void ExperienceUInt32(ExperienceUInt32 data)
		{
			this.me.Attributes[StatType.Experience] = data.Experience;
		}

		// Token: 0x0600BF72 RID: 49010 RVA: 0x0049C2E4 File Offset: 0x0049A4E4
		private void ActChange(ActChange data)
		{
		}

		// Token: 0x0600BF73 RID: 49011 RVA: 0x0049C2E7 File Offset: 0x0049A4E7
		private void PlayerAttributeNotification(PlayerAttributeNotification data)
		{
		}

		// Token: 0x0600BF74 RID: 49012 RVA: 0x0049C2EA File Offset: 0x0049A4EA
		private void MapAdd(MapAdd data)
		{
		}

		// Token: 0x0600BF75 RID: 49013 RVA: 0x0049C2ED File Offset: 0x0049A4ED
		private void MapRemove(MapRemove data)
		{
		}

		// Token: 0x0600BF76 RID: 49014 RVA: 0x0049C2F0 File Offset: 0x0049A4F0
		private void Unk5e(Unk5e data)
		{
		}

		// Token: 0x0600BF77 RID: 49015 RVA: 0x0049C2F3 File Offset: 0x0049A4F3
		private void Unk5f(Unk5f data)
		{
		}

		// Token: 0x0600BF78 RID: 49016 RVA: 0x0049C2F6 File Offset: 0x0049A4F6
		private void Unk7e(Unk7e data)
		{
		}

		// Token: 0x0600BF79 RID: 49017 RVA: 0x0049C2F9 File Offset: 0x0049A4F9
		private void SetState(SetState data)
		{
		}

		// Token: 0x0600BF7A RID: 49018 RVA: 0x0049C2FC File Offset: 0x0049A4FC
		private void DelayedState(DelayedState data)
		{
		}

		// Token: 0x0600BF7B RID: 49019 RVA: 0x0049C2FF File Offset: 0x0049A4FF
		private void EndState(EndState data)
		{
		}

		// Token: 0x0600BF7C RID: 49020 RVA: 0x0049C302 File Offset: 0x0049A502
		private void Relator1(Relator1 data)
		{
		}

		// Token: 0x0600BF7D RID: 49021 RVA: 0x0049C305 File Offset: 0x0049A505
		private void Relator2(Relator2 data)
		{
		}

		// Token: 0x0600BF7E RID: 49022 RVA: 0x0049C308 File Offset: 0x0049A508
		private void Relator3(Relator3 data)
		{
		}

		// Token: 0x0600BF7F RID: 49023 RVA: 0x0049C30B File Offset: 0x0049A50B
		private void Relator4(Relator4 data)
		{
		}

		// Token: 0x0600BF80 RID: 49024 RVA: 0x0049C310 File Offset: 0x0049A510
		private void PlayerInGame(PlayerInGame data)
		{
			Player player = new Player
			{
				Id = data.Id,
				Name = data.Name,
				Party = data.PartyId,
				Class = data.Class
			};
			this.AddPlayerToList(player);
		}

		// Token: 0x0600BF81 RID: 49025 RVA: 0x0049C35C File Offset: 0x0049A55C
		private void PlayerLeaveGame(PlayerLeaveGame data)
		{
			Player player;
			this.GameInstance.Players.TryRemove(data.Id, out player);
		}

		// Token: 0x0600BF82 RID: 49026 RVA: 0x0049C383 File Offset: 0x0049A583
		private void PlayerKillCount(PlayerKillCount data)
		{
		}

		// Token: 0x0600BF83 RID: 49027 RVA: 0x0049C388 File Offset: 0x0049A588
		private void AssignPlayerToParty(AssignPlayerToParty data)
		{
			Player player = new Player
			{
				Id = data.Id,
				Party = data.PartyNumber
			};
			this.AddPlayerToList(player);
		}

		// Token: 0x0600BF84 RID: 49028 RVA: 0x0049C3BC File Offset: 0x0049A5BC
		private void PartyMemberUpdate(PartyMemberUpdate data)
		{
			Player player = new Player
			{
				Id = data.Id,
				Area = data.Area
			};
			bool flag = data.IsPlayer > 0;
			if (flag)
			{
				this.AddPlayerToList(player);
			}
		}

		// Token: 0x0600BF85 RID: 49029 RVA: 0x0049C400 File Offset: 0x0049A600
		private void PartyMemberPulse(PartyMemberPulse data)
		{
			Player player = new Player
			{
				Id = data.Id,
				X = (ushort)data.X,
				Y = (ushort)data.Y
			};
			this.AddPlayerToList(player);
		}

		// Token: 0x0600BF86 RID: 49030 RVA: 0x0049C442 File Offset: 0x0049A642
		private void PlayerRelationship(PlayerRelationship data)
		{
		}

		// Token: 0x0600BF87 RID: 49031 RVA: 0x0049C448 File Offset: 0x0049A648
		private void InformationMessage(InformationMessage data)
		{
			bool flag = data.orig[1] == 18;
			if (flag)
			{
				this.clone = true;
			}
			bool flag2 = data.orig[1] == 18;
			if (flag2)
			{
				Console.WriteLine("found!!");
			}
			bool flag3 = data.orig[1] == 17;
			if (flag3)
			{
				Console.WriteLine("selling!!");
			}
		}

		// Token: 0x0600BF88 RID: 49032 RVA: 0x0049C4A3 File Offset: 0x0049A6A3
		private void GameMessage(GameMessage data)
		{
		}

		// Token: 0x0600BF89 RID: 49033 RVA: 0x0049C4A6 File Offset: 0x0049A6A6
		private void AboutPlayer(AboutPlayer data)
		{
		}

		// Token: 0x0600BF8A RID: 49034 RVA: 0x0049C4A9 File Offset: 0x0049A6A9
		private void OpenWaypoint(OpenWaypoint data)
		{
			this.me.WaypointsUnlocked = data.WaypointsUnlocked;
		}

		// Token: 0x0600BF8B RID: 49035 RVA: 0x0049C4BD File Offset: 0x0049A6BD
		private void UnitUseSkill(UnitUseSkill data)
		{
		}

		// Token: 0x0600BF8C RID: 49036 RVA: 0x0049C4C0 File Offset: 0x0049A6C0
		private void UnitUseSkillOnTarget(UnitUseSkillOnTarget data)
		{
		}

		// Token: 0x0600BF8D RID: 49037 RVA: 0x0049C4C3 File Offset: 0x0049A6C3
		private void NPCAction(NPCAction data)
		{
		}

		// Token: 0x0600BF8E RID: 49038 RVA: 0x0049C4C6 File Offset: 0x0049A6C6
		private void NPCInfo(NPCInfo data)
		{
		}

		// Token: 0x0600BF8F RID: 49039 RVA: 0x0049C4C9 File Offset: 0x0049A6C9
		private void NPCUpdate(NPCUpdate data)
		{
		}

		// Token: 0x0600BF90 RID: 49040 RVA: 0x0049C4CC File Offset: 0x0049A6CC
		private void MonsterAttack(MonsterAttack data)
		{
		}

		// Token: 0x0600BF91 RID: 49041 RVA: 0x0049C4CF File Offset: 0x0049A6CF
		private void UniqueEvents(UniqueEvents data)
		{
		}

		// Token: 0x0600BF92 RID: 49042 RVA: 0x0049C4D2 File Offset: 0x0049A6D2
		private void ReportKill(ReportKill data)
		{
		}

		// Token: 0x0600BF93 RID: 49043 RVA: 0x0049C4D5 File Offset: 0x0049A6D5
		private void UpdateItemStats(UpdateItemStats data)
		{
		}

		// Token: 0x0600BF94 RID: 49044 RVA: 0x0049C4D8 File Offset: 0x0049A6D8
		private void TransactionComplete(TransactionComplete data)
		{
		}

		// Token: 0x0600BF95 RID: 49045 RVA: 0x0049C4DB File Offset: 0x0049A6DB
		private void UseSpecialItem(UseSpecialItem data)
		{
		}

		// Token: 0x0600BF96 RID: 49046 RVA: 0x0049C4DE File Offset: 0x0049A6DE
		private void SmallGoldAdd(SmallGoldAdd data)
		{
		}

		// Token: 0x0600BF97 RID: 49047 RVA: 0x0049C4E1 File Offset: 0x0049A6E1
		private void AssignPlayerCorpse(AssignPlayerCorpse data)
		{
		}

		// Token: 0x0600BF98 RID: 49048 RVA: 0x0049C4E4 File Offset: 0x0049A6E4
		private void NPCHeal(NPCHeal data)
		{
		}

		// Token: 0x0600BF99 RID: 49049 RVA: 0x0049C4E7 File Offset: 0x0049A6E7
		private void UpdateUI(UpdateUI data)
		{
		}

		// Token: 0x0600BF9A RID: 49050 RVA: 0x0049C4EA File Offset: 0x0049A6EA
		private void CreateMissile(CreateMissile data)
		{
		}

		// Token: 0x0600BF9B RID: 49051 RVA: 0x0049C4ED File Offset: 0x0049A6ED
		private void AssignMerc(AssignMerc merc)
		{
			this.Mercs[merc.Id] = merc;
		}

		// Token: 0x0600BF9C RID: 49052 RVA: 0x0049C503 File Offset: 0x0049A703
		private void MercAttributeByte(MercAttributeByte data)
		{
		}

		// Token: 0x0600BF9D RID: 49053 RVA: 0x0049C506 File Offset: 0x0049A706
		private void MercAttributeWord(MercAttributeUInt16 data)
		{
		}

		// Token: 0x0600BF9E RID: 49054 RVA: 0x0049C509 File Offset: 0x0049A709
		private void MercAttributeUInt32(MercAttributeUInt32 data)
		{
		}

		// Token: 0x0600BF9F RID: 49055 RVA: 0x0049C50C File Offset: 0x0049A70C
		private void MercCost(MercCost data)
		{
			this.MercReviveCost = data.ReviveCost;
			this.MercNameId = data.NameId;
		}

		// Token: 0x0600BFA0 RID: 49056 RVA: 0x0049C528 File Offset: 0x0049A728
		private void PlayerMove(PlayerMove data)
		{
			Player player = new Player
			{
				Id = data.Id,
				X = data.CurrentX,
				Y = data.CurrentY
			};
			this.AddPlayerToList(player);
		}

		// Token: 0x0600BFA1 RID: 49057 RVA: 0x0049C56C File Offset: 0x0049A76C
		private void PlayerMoveToTarget(PlayerMoveToTarget data)
		{
			Player player = new Player
			{
				Id = data.Id,
				X = data.X,
				Y = data.Y
			};
			this.AddPlayerToList(player);
		}

		// Token: 0x0600BFA2 RID: 49058 RVA: 0x0049C5B0 File Offset: 0x0049A7B0
		private void PlayerStop(PlayerStop data)
		{
			Player player = new Player
			{
				Id = data.Id,
				X = data.X,
				Y = data.Y
			};
			this.AddPlayerToList(player);
		}

		// Token: 0x0600BFA3 RID: 49059 RVA: 0x0049C5F4 File Offset: 0x0049A7F4
		private void AssignGameObject(AssignGameObject assignGameObject)
		{
			this.GameInstance.GameObjects[assignGameObject.Id] = assignGameObject;
		}

		// Token: 0x0600BFA4 RID: 49060 RVA: 0x0049C610 File Offset: 0x0049A810
		private void SetGameObjectMode(SetGameObjectMode data)
		{
			bool flag = this.GameInstance.GameObjects.ContainsKey(data.Id);
			if (flag)
			{
				this.GameInstance.GameObjects[data.Id].Mode = data.Mode;
			}
			else
			{
				this.GameInstance.GameObjects[data.Id] = new AssignGameObject
				{
					Type = data.Type,
					Id = data.Id,
					Mode = data.Mode
				};
			}
		}

		// Token: 0x0600BFA5 RID: 49061 RVA: 0x0049C69C File Offset: 0x0049A89C
		private void OwnedItemAction(OwnedItemAction p)
		{
			bool flag = this.GameInstance.Players.ContainsKey(p.OwnerId);
			if (flag)
			{
				this.GameInstance.Players[p.OwnerId].Equipment.Values.Where((ItemAction e) => e.Id == p.Id).ToList<ItemAction>().ForEach(delegate(ItemAction e)
				{
					this.GameInstance.Players[p.OwnerId].Equipment[e.location] = new ItemAction
					{
						Id = uint.MaxValue
					};
				});
			}
			bool flag2 = !p.flags.HasFlag(ItemFlags.InSocket) && this.GameInstance.Players.ContainsKey(p.OwnerId) && p.OwnerType == UnitType.Player && p.action != ItemActionType.Unequip;
			if (flag2)
			{
				this.GameInstance.Players[p.OwnerId].Equipment[p.location] = p;
			}
			this.GameInstance.Items[p.Id] = p;
		}

		// Token: 0x0600BFA6 RID: 49062 RVA: 0x0049C7E4 File Offset: 0x0049A9E4
		private void WorldItemAction(WorldItemAction itemAction)
		{
			this.GameInstance.Items[itemAction.Id] = itemAction;
			Action<ItemAction> onItemAction = this.OnItemAction;
			if (onItemAction != null)
			{
				onItemAction(itemAction);
			}
			bool flag = itemAction.action == ItemActionType.AddToGround || itemAction.action == ItemActionType.OnGround;
			if (flag)
			{
			}
			bool flag2 = itemAction.action == ItemActionType.PutInBelt;
			if (flag2)
			{
				this.iteminbelt = itemAction.Id;
			}
			bool flag3 = itemAction.baseItem == BaseItem.GetMiscItem(ItemType.ScrollOfTownPortal) && itemAction.action == ItemActionType.AddToShop;
			if (flag3)
			{
				this.vendorTp = itemAction;
			}
			bool flag4 = itemAction.baseItem == BaseItem.GetMiscItem(ItemType.ScrollOfTownPortal) && itemAction.action == ItemActionType.PutInContainer;
			if (flag4)
			{
				this.inventoryTome = itemAction;
			}
			bool flag5 = itemAction.baseItem == BaseItem.GetMiscItem(ItemType.TomeOfTownPortal) && itemAction.action == ItemActionType.PutInContainer && ((SignedStat)itemAction[StatType.Quantity]).Value > 0;
			if (flag5)
			{
				this.inventoryTome = itemAction;
			}
		}

		// Token: 0x0600BFA7 RID: 49063 RVA: 0x0049C8E1 File Offset: 0x0049AAE1
		private void UseStackableItem(UseStackableItem item)
		{
		}

		// Token: 0x0600BFA8 RID: 49064 RVA: 0x0049C8E4 File Offset: 0x0049AAE4
		private void AssignWarp(AssignWarp warp)
		{
			this.GameInstance.Warps[warp.Id] = warp;
		}

		// Token: 0x0600BFA9 RID: 49065 RVA: 0x0049C900 File Offset: 0x0049AB00
		private void AssignSkill(AssignSkill assignSkill)
		{
			bool flag = assignSkill.Hand == SkillHand.Left;
			if (flag)
			{
				this.me.LeftHandSkill = assignSkill.Skill;
			}
			bool flag2 = assignSkill.Hand == SkillHand.Right;
			if (flag2)
			{
				this.me.RightHandSkill = assignSkill.Skill;
			}
		}

		// Token: 0x0600BFAA RID: 49066 RVA: 0x0049C94A File Offset: 0x0049AB4A
		private void UpdatePlayerItemSkill(UpdatePlayerItemSkill data)
		{
			this.GameInstance.PlayerItemSkill.TryAdd(data.Id, data);
		}

		// Token: 0x0600BFAB RID: 49067 RVA: 0x0049C968 File Offset: 0x0049AB68
		public uint GetMyTpId()
		{
			return this.GameInstance.PortalsOwnership.FirstOrDefault((KeyValuePair<uint, PortalOwnership> p) => p.Value.OwnerId == this.myId).Value.LocalId;
		}

		// Token: 0x0600BFAC RID: 49068 RVA: 0x0049C9A3 File Offset: 0x0049ABA3
		private void PortalOwnership(PortalOwnership portal)
		{
			this.GameInstance.PortalsOwnership.TryAdd(portal.LocalId, portal);
		}

		// Token: 0x0600BFAD RID: 49069 RVA: 0x0049C9BE File Offset: 0x0049ABBE
		private void PortalInfo(PortalInfo portal)
		{
			this.GameInstance.PortalsInfo.TryAdd(portal.Id, portal);
		}

		// Token: 0x0600BFAE RID: 49070 RVA: 0x0049C9D9 File Offset: 0x0049ABD9
		private void SwitchWeaponSet(SwitchWeaponSet swap)
		{
		}

		// Token: 0x0600BFAF RID: 49071 RVA: 0x0049C9DC File Offset: 0x0049ABDC
		private void UpdateQuestStatus(UpdateQuestStatus status)
		{
		}

		// Token: 0x0600BFB0 RID: 49072 RVA: 0x0049C9DF File Offset: 0x0049ABDF
		private void PlayerPartyRelationship(PlayerPartyRelationship status)
		{
		}

		// Token: 0x0600BFB1 RID: 49073 RVA: 0x0049C9E2 File Offset: 0x0049ABE2
		private void TradeRequest(TradeRequest request)
		{
			this.Trade = request;
		}

		// Token: 0x0600BFB2 RID: 49074 RVA: 0x0049C9EC File Offset: 0x0049ABEC
		private void PlayerClearCursor(PlayerClearCursor request)
		{
		}

		// Token: 0x0600BFB3 RID: 49075 RVA: 0x0049C9EF File Offset: 0x0049ABEF
		private void Undefined(List<byte> data)
		{
		}

		// Token: 0x040091DE RID: 37342
		private bool logging = true;

		// Token: 0x040091DF RID: 37343
		private bool clientOnly = false;

		// Token: 0x040091E0 RID: 37344
		public TcpClient TcpClient;

		// Token: 0x040091E1 RID: 37345
		public NetworkStream BaseStream;

		// Token: 0x040091E2 RID: 37346
		public SslStream Stream;

		// Token: 0x040091E3 RID: 37347
		public Config Config = new Config();

		// Token: 0x040091E4 RID: 37348
		public Manager GameInstance = new Manager();

		// Token: 0x040091E5 RID: 37349
		public List<byte> Secret;

		// Token: 0x040091E6 RID: 37350
		public bool Compression = false;

		// Token: 0x040091E7 RID: 37351
		public bool Loaded = false;

		// Token: 0x040091E8 RID: 37352
		public Task PingHandler;

		// Token: 0x040091E9 RID: 37353
		public Task PacketHandler;

		// Token: 0x040091EB RID: 37355
		public bool HandlePackets = true;

		// Token: 0x040091EC RID: 37356
		public GameDifficulty difficulty = GameDifficulty.Normal;

		// Token: 0x040091ED RID: 37357
		public bool KeepPinging = true;

		// Token: 0x040091EE RID: 37358
		public int PingCalc = Environment.TickCount;

		// Token: 0x040091EF RID: 37359
		public byte[] combinePacket = new byte[0];

		// Token: 0x040091F0 RID: 37360
		public bool LogonSuccess = false;

		// Token: 0x040091F1 RID: 37361
		public Random Random = new Random();

		// Token: 0x040091F2 RID: 37362
		public Client.WaitingForPacketDelegate waitingForPacket;

		// Token: 0x040091F3 RID: 37363
		public object Net = new object();

		// Token: 0x040091F4 RID: 37364
		public bool Chickening = false;

		// Token: 0x040091F5 RID: 37365
		public int? BehaviorTaskId = new int?(-1);

		// Token: 0x040091F6 RID: 37366
		public uint myId = 0U;

		// Token: 0x040091F7 RID: 37367
		public Player dummy = new Player
		{
			X = ushort.MaxValue,
			Y = ushort.MaxValue
		};

		// Token: 0x040091F8 RID: 37368
		public bool teleportReturned = false;

		// Token: 0x040091F9 RID: 37369
		public SkillType LeftSkill = SkillType.None;

		// Token: 0x040091FA RID: 37370
		public SkillType RightSkill = SkillType.None;

		// Token: 0x040091FB RID: 37371
		public bool LoadedMap = false;

		// Token: 0x040091FC RID: 37372
		private bool logonSuccess = false;

		// Token: 0x040091FD RID: 37373
		public Task behaviorTask;

		// Token: 0x040091FE RID: 37374
		public CancellationTokenSource behaviorCancel = new CancellationTokenSource();

		// Token: 0x040091FF RID: 37375
		public Action Behavior;

		// Token: 0x04009200 RID: 37376
		protected Action OnPlayerLifeManaChange;

		// Token: 0x04009201 RID: 37377
		public bool walkVerified = false;

		// Token: 0x04009202 RID: 37378
		public ActLocation currentAct = ActLocation.None;

		// Token: 0x04009203 RID: 37379
		public uint mapSeed = 0U;

		// Token: 0x04009204 RID: 37380
		private int Latency = 0;

		// Token: 0x04009205 RID: 37381
		public SkillsLog SkillLog = new SkillsLog();

		// Token: 0x04009206 RID: 37382
		public UpdateQuestInfo updateQuestInfo = new UpdateQuestInfo();

		// Token: 0x04009207 RID: 37383
		public UpdateGameQuestLog gameQuestLog = new UpdateGameQuestLog();

		// Token: 0x04009208 RID: 37384
		public List<QuestItemState> questItemStates = new List<QuestItemState>();

		// Token: 0x04009209 RID: 37385
		protected Action<D2Packets.Game.Server.Attribute> OnAttributeChange;

		// Token: 0x0400920A RID: 37386
		public bool clone = false;

		// Token: 0x0400920B RID: 37387
		public Dictionary<uint, AssignMerc> Mercs = new Dictionary<uint, AssignMerc>();

		// Token: 0x0400920C RID: 37388
		public ushort MercNameId = 0;

		// Token: 0x0400920D RID: 37389
		public uint MercReviveCost = 0U;

		// Token: 0x0400920E RID: 37390
		public WorldItemAction vendorTp;

		// Token: 0x0400920F RID: 37391
		public WorldItemAction inventoryTome;

		// Token: 0x04009210 RID: 37392
		public uint iteminbelt = 0U;

		// Token: 0x04009211 RID: 37393
		public Action<ItemAction> OnItemAction;

		// Token: 0x04009212 RID: 37394
		public TradeRequest Trade;

		// Token: 0x02001429 RID: 5161
		// (Invoke) Token: 0x0600E2D7 RID: 58071
		public delegate bool WaitingForPacketDelegate(Packet data);
	}
}
