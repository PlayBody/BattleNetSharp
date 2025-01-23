using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BattleNetSharp;
using BattleNetSharp.D2.Resurrected;
using Classic.Protocol.External.V1.Character;
using Classic.Protocol.External.V1.GameManagement;
using D2Data;
using D2Packets;
using D2Packets.Realm;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;
using Utilities;

namespace DiabloBridge
{
	// Token: 0x0200098F RID: 2447
	public class RealmServer : IDisposable
	{
		// Token: 0x1700390E RID: 14606
		// (get) Token: 0x0600BA58 RID: 47704 RVA: 0x0046869C File Offset: 0x0046689C
		public BNetServer Bnet
		{
			get
			{
				return BNetServer.BNetServers.ContainsKey(this.Account.BNetEmail) ? BNetServer.BNetServers[this.Account.BNetEmail] : null;
			}
		}

		// Token: 0x1700390F RID: 14607
		// (get) Token: 0x0600BA59 RID: 47705 RVA: 0x004686E0 File Offset: 0x004668E0
		public D2RBGS Bgs
		{
			get
			{
				BNetServer bnet = this.Bnet;
				return (bnet != null) ? bnet.BgsClient : null;
			}
		}

		// Token: 0x0600BA5A RID: 47706 RVA: 0x00468704 File Offset: 0x00466904
		public RealmServer()
		{
		}

		// Token: 0x0600BA5B RID: 47707 RVA: 0x00468778 File Offset: 0x00466978
		public RealmServer(TcpClient client)
		{
			this.Client = client;
			this.Endpoint = this.Client.Client.RemoteEndPoint as IPEndPoint;
			bool flag = this.Endpoint.Address.Equals(IPAddress.Loopback);
			if (flag)
			{
				this.ip = BitConverter.ToUInt32(IPAddress.Loopback.GetAddressBytes());
			}
			else
			{
				bool flag2 = Environment.MachineName == "DESKTOP-54INSRD";
				if (flag2)
				{
					this.ip = BitConverter.ToUInt32(Dns.GetHostEntry(Dns.GetHostName()).AddressList.First((IPAddress a) => a.AddressFamily == AddressFamily.InterNetwork).GetAddressBytes());
				}
				else
				{
					this.ip = BitConverter.ToUInt32(IPAddress.Parse("137.66.34.9").GetAddressBytes());
				}
			}
			Task.Run(delegate
			{
				this.Listen();
			});
		}

		// Token: 0x0600BA5C RID: 47708 RVA: 0x004688D0 File Offset: 0x00466AD0
		public void Listen()
		{
			this.Stream = this.Client.GetStream();
			this.Stream.ReadTimeout = -1;
			NetworkStream stream = this.Stream;
			if (stream == null)
			{
				int? num = null;
			}
			else
			{
				new int?(stream.ReadByte());
			}
			while (this.Client.Connected)
			{
				try
				{
					this.HandlePacket();
				}
				catch
				{
					Console.WriteLine("realm server listen fail");
					TcpClient client = this.Client;
					if (client != null)
					{
						client.Close();
					}
					break;
				}
			}
			this.Dispose();
		}

		// Token: 0x0600BA5D RID: 47709 RVA: 0x00468974 File Offset: 0x00466B74
		public List<byte> ReadPacket()
		{
			List<byte> list = new List<byte>();
			byte[] array = new byte[this.Client.ReceiveBufferSize];
			try
			{
				int num = this.Stream.Read(array, 0, array.Length);
				list.AddRange(array.Take(num));
				bool flag = num == 0;
				if (flag)
				{
					this.Client.Close();
				}
			}
			catch
			{
				Console.WriteLine("RealmServer read packet crash");
			}
			return list;
		}

        // Token: 0x0600BA5E RID: 47710 RVA: 0x004689F8 File Offset: 0x00466BF8
        public void HandlePacket()
        {
            List<byte> list = this.ReadPacket();
            Type typeFromHandle = typeof(RealmPacket);

            while (list.Count > 0)
            {
                int num = 0;

                if (list.Count < 3)
                {
                    Console.WriteLine("Packet too short to process.");
                    break;
                }

                string text2 = typeFromHandle.AssemblyQualifiedName.Replace(typeFromHandle.Name, ((RealmPacket)list[2]).ToString() + "C2S");
                Type type = Type.GetType(text2);

                if (type == null)
                {
                    Console.WriteLine($"No realm packet info for: {list[2]:X} : {BitConverter.ToString(list.ToArray())}");
                    break;
                }

                if (this.logging)
                {
                    IPAddress address = (this.Client.Client.RemoteEndPoint as IPEndPoint)?.Address;
                    Console.WriteLine($"{address} RC ({DateTime.UtcNow:HH:mm:ss.fff}): {type.Name} : {BitConverter.ToString(list.ToArray())}");
                }

                object obj = Activator.CreateInstance(type);

                try
                {
                    obj.GetType().GetProperty("Bytes")?.SetValue(obj, list);
                }
                catch
                {
                    Console.WriteLine("Realm server packet parse failed.");
                    break;
                }

                if (num == 0)
                {
                    FieldInfo field = type.GetField("Length");

                    if (field != null)
                    {
                        try
                        {
                            num = (int)field.GetValue(obj);
                        }
                        catch
                        {
                            Console.WriteLine($"Failed to retrieve length from type: {type.Name}");
                        }
                    }
                    else
                    {
                        try
                        {
                            num = (int)obj.GetType().GetProperty("Length")?.GetValue(obj);
                        }
                        catch
                        {
                            Console.WriteLine($"Failed to determine length for type: {type.Name}");
                        }
                    }
                }

                MethodInfo method = base.GetType().GetMethod(type.Name, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);

                if (method != null)
                {
                    method.Invoke(this, new object[] { obj });
                }
                else
                {
                    Console.WriteLine($"No method found for realm type: {type.Name}");
                }

                list = list.Skip(num).ToList();
            }
        }

        // Token: 0x0600BA5F RID: 47711 RVA: 0x00468E90 File Offset: 0x00467090
        private void StartupC2S(StartupC2S info)
		{
			string text = Encoding.UTF8.GetString(info.HashString.ToArray()).Replace("\0", "");
			bool flag = !File.Exists("accounts/" + text);
			if (!flag)
			{
				string text2 = File.ReadAllText("accounts/" + text);
				this.Account = JsonConvert.DeserializeObject<AccountLink>(text2);
				bool flag2 = RealmServer.RealmServers.ContainsKey(this.Account.BNetEmail);
				if (flag2)
				{
					this.SendPacket(new StartupS2C
					{
						Result = StartupS2C.LoginResult.RealmUnavailableA
					});
				}
				else
				{
					RealmServer.RealmServers.TryAdd(this.Account.BNetEmail, this);
					this.SendPacket(new StartupS2C
					{
						Result = StartupS2C.LoginResult.Success
					});
				}
			}
		}

		// Token: 0x0600BA60 RID: 47712 RVA: 0x00468F58 File Offset: 0x00467158
		private bool UpdateCharacterList()
		{
			bool flag = false;
			bool flag2 = this.Characters.Count<CharData>() == 0;
			if (flag2)
			{
				int num = 0;
				while (num < 5 && !flag)
				{
					bool flag3 = this.Bgs.RealmLoginLocked(true);
					if (flag3)
					{
						this.Characters = this.Bgs.ReadCharacters();
						bool flag4 = this.Characters.Count > 1;
						if (flag4)
						{
						}
						bool flag5 = this.Characters.Count<CharData>() > 0;
						if (flag5)
						{
							flag = true;
						}
					}
					D2RBGS bgs = this.Bgs;
					if (bgs != null)
					{
						RealmWebSocket realmConnection = bgs.RealmConnection;
						if (realmConnection != null)
						{
							ClientWebSocket clientWebSocket = realmConnection.clientWebSocket;
							if (clientWebSocket != null)
							{
								clientWebSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, null, default(CancellationToken));
							}
						}
					}
					num++;
				}
			}
			return flag;
		}

		// Token: 0x0600BA61 RID: 47713 RVA: 0x00469030 File Offset: 0x00467230
		private void CharacterListC2S(CharacterListC2S info)
		{
			this.UpdateCharacterList();
			List<CharacterListS2C.CharacterInfo> list = new List<CharacterListS2C.CharacterInfo>();
			foreach (CharData charData in this.Characters)
			{
				string text = charData.D2S.ToStringUtf8();
				D2RCharData d2RCharData = JsonConvert.DeserializeObject<D2RCharData>(charData.D2S.ToStringUtf8());
				string text2 = BitConverter.ToString(d2RCharData.questRecords.Select((int b) => (byte)b).ToArray<byte>());
				BitReader bitReader = new BitReader(d2RCharData.questRecords.Select((int b) => (byte)b).ToArray<byte>(), 0);
				for (int k = 0; k < 3; k++)
				{
					for (int j = 0; j < 42; j++)
					{
						ulong num = bitReader.ReadBits(1);
					}
				}
				bitReader.Position = 0;
				ulong num2 = bitReader.ReadBits(40);
				ulong num3 = bitReader.ReadBits(1);
				num2 = bitReader.ReadBits(1);
				num2 = bitReader.ReadBits(40);
				ulong num4 = bitReader.ReadBits(1);
				int num5 = 0;
				int num6 = (int)((int)d2RCharData.charflags >> 8);
				bool flag = num6 >= 5;
				if (flag)
				{
					num5++;
				}
				bool flag2 = num6 >= 10;
				if (flag2)
				{
					num5++;
				}
				bool flag3 = num6 >= 15;
				if (flag3)
				{
					num5++;
				}
				byte b2 = (byte)(128 + num5 * 2 * 5);
				List<byte> list2 = new List<byte> { 132, 128 };
				list2.AddRange(d2RCharData.appearance.Select((int i) => (byte)((i == 0) ? 255 : i)).ToArray<byte>());
				list2.Add((byte)(d2RCharData.@class + 1));
				list2.AddRange(d2RCharData.colors.Select((int i) => (byte)i).ToArray<byte>());
				list2.Add((byte)d2RCharData.level);
				list2.Add(225);
				list2.Add(b2);
				list2.AddRange(new List<byte> { 128, 128, 1, byte.MaxValue, byte.MaxValue, 0 });
				list.Add(new CharacterListS2C.CharacterInfo
				{
					ExpirationDate = 2147483647U,
					Name = charData.Name + "\0",
					StatArray = list2
				});
			}
			bool flag4 = list.Count == 0;
			if (flag4)
			{
				list.Add(new CharacterListS2C.CharacterInfo
				{
					ExpirationDate = 2147483647U,
					Name = "nochars\0",
					StatArray = Convert.FromBase64String("hIA5AQEBART/UAIC/wJC/////////////1HhlICAAf//AA==").ToList<byte>()
				});
			}
			this.SendPacket(new CharacterListS2C
			{
				NumCharsExist = (uint)((ushort)list.Count),
				NumCharsReturned = (ushort)list.Count,
				NumCharsRequested = 18,
				Characters = list
			});
		}

		// Token: 0x0600BA62 RID: 47714 RVA: 0x004693C8 File Offset: 0x004675C8
		private void CharacterLogonC2S(CharacterLogonC2S info)
		{
			this.UpdateCharacterList();
			bool flag = false;
			bool flag2 = flag;
			if (flag2)
			{
				CharData charData = this.Characters.MaxBy((CharData i) => JsonConvert.DeserializeObject<D2RCharData>(i.D2S.ToStringUtf8()).level);
				this.CharacterName = charData.Name;
				this.CharId = charData.Id;
				this.CharLevel = (uint)JsonConvert.DeserializeObject<D2RCharData>(charData.D2S.ToStringUtf8()).level;
			}
			else
			{
				this.CharacterName = info.CharacterName;
				CharData charData2 = this.Characters.FirstOrDefault((CharData i) => i.Name == info.CharacterName);
				bool flag3 = charData2 != null;
				if (flag3)
				{
					this.CharId = charData2.Id;
					this.CharLevel = (uint)JsonConvert.DeserializeObject<D2RCharData>(this.Characters.First((CharData i) => i.Name == info.CharacterName).D2S.ToStringUtf8()).level;
					this.SendPacket(new CharacterLogonS2C
					{
						Result = CharacterLogonS2C.CharStatus.Success
					});
				}
				else
				{
					this.SendPacket(new CharacterLogonS2C
					{
						Result = CharacterLogonS2C.CharStatus.Failed
					});
				}
			}
		}

		// Token: 0x0600BA63 RID: 47715 RVA: 0x004694F6 File Offset: 0x004676F6
		private void HeartbeatC2S(HeartbeatC2S info)
		{
			this.SendPacket(new HeartbeatS2C());
		}

		// Token: 0x0600BA64 RID: 47716 RVA: 0x00469508 File Offset: 0x00467708
		private void CharacterCreateC2S(CharacterCreateC2S info)
		{
			bool flag = this.Bgs.RealmLoginLocked(true);
			if (flag)
			{
				this.Bgs.CreateCharacter(info.CharacterName, (CharacterClass)info.Class);
				this.Bgs.RealmConnection.clientWebSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, null, default(CancellationToken));
				this.Characters.Clear();
				bool flag2 = this.UpdateCharacterList();
				if (flag2)
				{
					this.SendPacket(new CharacterCreateS2C());
					bool flag3 = this.Characters.Count == 0;
					if (flag3)
					{
						this.Dispose();
					}
					else
					{
						this.CharId = this.Characters.First((CharData i) => i.Name == info.CharacterName).Id;
						this.CharLevel = (uint)JsonConvert.DeserializeObject<D2RCharData>(this.Characters.First((CharData i) => i.Name == info.CharacterName).D2S.ToStringUtf8()).level;
					}
					return;
				}
			}
			this.Dispose();
		}

		// Token: 0x0600BA65 RID: 47717 RVA: 0x00469624 File Offset: 0x00467824
		private void CharacterDeleteC2S(CharacterDeleteC2S del)
		{
			bool flag = this.Bgs.RealmLoginLocked(true);
			if (flag)
			{
				List<CharData> list = this.Bgs.ReadCharacters();
				this.Bgs.DeleteCharacter(list.First((CharData c) => c.Name == del.CharacterName).Id);
				this.Bgs.RealmConnection.clientWebSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, null, default(CancellationToken));
				this.Characters.Clear();
				this.SendPacket(new CharacterDeleteS2C());
			}
			else
			{
				this.Dispose();
			}
		}

		// Token: 0x0600BA66 RID: 47718 RVA: 0x004696C8 File Offset: 0x004678C8
		private void Afk(CreateGameC2S info)
		{
			RealmServer.clients.Clear();
			string text = File.ReadAllText("accounts\\s.halzuth");
			AccountLink accountLink = JsonConvert.DeserializeObject<AccountLink>(text);
			D2RBGS d2RBGS = new D2RBGS();
			Client client = new Client();
			RealmServer.clients.Add(client);
			List<string> list = new List<string> { "sh.alzuth", "shal.zuth" };
			foreach (string text2 in list)
			{
				string text3 = File.ReadAllText("accounts\\" + text2);
				AccountLink accountLink2 = JsonConvert.DeserializeObject<AccountLink>(text3);
				D2RBGS d2RBGS2 = new D2RBGS();
				d2RBGS2.BGSLoginLocked("us", accountLink2.BNetToken, accountLink2.D2Account, D2RBGS.App.D2R);
				d2RBGS2.RealmLoginLocked(true);
				Client client2 = new Client();
				RealmServer.clients.Add(client2);
			}
		}

		// Token: 0x0600BA67 RID: 47719 RVA: 0x004697CC File Offset: 0x004679CC
		private void CreateGameC2S(CreateGameC2S info)
		{
			this.SendPacket(new CreateGameQueueS2C
			{
				Position = 5U
			});
			bool flag = info.Name.ToLower().Contains("anni");
			if (!flag)
			{
				bool flag2 = info.Password.Length == 0;
				if (flag2)
				{
					info.Password = "1";
				}
				D2RBGS bgs = this.Bgs;
				bool flag3 = bgs != null && bgs.RealmLoginLocked(true);
				if (flag3)
				{
					D2RBGS bgs2 = this.Bgs;
					if (bgs2 != null)
					{
						bgs2.CreateGame(info.Name.ToLower(), info.Password.ToLower(), this.CharId, (info.Mode == 8192U) ? 2U : ((info.Mode == 4096U) ? 1U : 0U), this.CharLevel, true, WebManager.SubRegion);
					}
				}
				else
				{
					this.Dispose();
				}
			}
			this.SendPacket(new CreateGameS2C
			{
				Result = CreateGameS2C.CreateGameStatus.Success,
				Id = info.Count,
				GameToken = 1011
			});
		}

		// Token: 0x0600BA68 RID: 47720 RVA: 0x004698D4 File Offset: 0x00467AD4
		private void JoinGameC2S(JoinGameC2S info)
		{
			bool flag = this.creating;
			if (flag)
			{
				this.SendPacket(new JoinGameS2C
				{
					Hash = this.hash,
					Token = this.gameId,
					Id = info.Id,
					IpAddr = this.ip,
					Result = JoinGameS2C.JoinGameStatus.Success
				});
				this.creating = false;
			}
			else
			{
				GameJoinResponse gameJoinResponse = new GameJoinResponse
				{
					IpAddress = ""
				};
				bool flag2 = info.Name.ToLower().Contains("anni");
				if (flag2)
				{
					string text = WebManager.HttpClient.GetStringAsync("http://127.0.0.1:5123/d2clone").Result.Replace("</BODY></HTML>", "");
					string text2 = (from l in text.Split(new string[] { "<br>" }, StringSplitOptions.RemoveEmptyEntries)
						where l.Contains("found")
						select l into qu
						orderby Guid.NewGuid()
						select qu).FirstOrDefault<string>();
					bool flag3 = text2 != null && text2.Contains("found");
					if (flag3)
					{
						text2 = text2.Substring(7, 8);
						Console.WriteLine("joining : " + text2);
						gameJoinResponse = this.Bgs.JoinGame(text2, text2, this.CharId, this.CharLevel, "");
					}
				}
				else
				{
					gameJoinResponse = this.Bgs.JoinGame(info.Name, info.Password, this.CharId, this.CharLevel, "");
				}
				bool flag4 = gameJoinResponse == null || gameJoinResponse.IpAddress == "";
				if (flag4)
				{
					Console.WriteLine("join game fail :(");
					this.SendPacket(new JoinGameS2C
					{
						Result = JoinGameS2C.JoinGameStatus.Invalid
					});
				}
				else
				{
					this.hash = (uint)new Random().Next();
					this.gameId = (ushort)gameJoinResponse.Id;
					GameProxy.GameAccountLink.TryAdd(this.hash, new GameProxy.GameInfo
					{
						ipAddr = gameJoinResponse.IpAddress,
						port = (int)gameJoinResponse.Port,
						secret = gameJoinResponse.Hash.ToByteArray().ToList<byte>(),
						account = this.Account.BNetEmail,
						character = this.CharacterName
					});
					this.SendPacket(new JoinGameS2C
					{
						Hash = this.hash,
						Token = this.gameId,
						Id = info.Id,
						IpAddr = this.ip,
						Result = JoinGameS2C.JoinGameStatus.Success
					});
				}
			}
		}

		// Token: 0x0600BA69 RID: 47721 RVA: 0x00469B7A File Offset: 0x00467D7A
		private void MessageOfTheDayC2S(MessageOfTheDayC2S info)
		{
			this.SendPacket(new MessageOfTheDayS2C
			{
				Message = "hPassword is required. If no password is specified, password is assumed to be 1."
			});
		}

		// Token: 0x0600BA6A RID: 47722 RVA: 0x00469B94 File Offset: 0x00467D94
		private void CreateGameCancelC2S(CreateGameCancelC2S c)
		{
		}

		// Token: 0x0600BA6B RID: 47723 RVA: 0x00469B98 File Offset: 0x00467D98
		public void SendPacket(Packet packet)
		{
			byte[] array = packet.ToArray();
			this.SendPacket(array);
		}

		// Token: 0x0600BA6C RID: 47724 RVA: 0x00469BB8 File Offset: 0x00467DB8
		public void SendPacket(byte[] packetBytes)
		{
			bool flag = !this.Client.Connected;
			if (!flag)
			{
				bool flag2 = this.logging;
				if (flag2)
				{
					string[] array = new string[8];
					array[0] = "(";
					int num = 1;
					IPAddress address = (this.Client.Client.RemoteEndPoint as IPEndPoint).Address;
					array[num] = ((address != null) ? address.ToString() : null);
					array[2] = ") RS (";
					array[3] = DateTime.UtcNow.ToString("HH:mm:ss.fff");
					array[4] = "): ";
					int num2 = 5;
					RealmPacket realmPacket = (RealmPacket)packetBytes[2];
					array[num2] = realmPacket.ToString();
					array[6] = " : ";
					array[7] = BitConverter.ToString(packetBytes);
					Console.WriteLine(string.Concat(array));
				}
				NetworkStream stream = this.Stream;
				if (stream != null)
				{
					stream.Write(packetBytes, 0, packetBytes.Length);
				}
			}
		}

		// Token: 0x0600BA6D RID: 47725 RVA: 0x00469C90 File Offset: 0x00467E90
		public void Dispose()
		{
			bool flag = this.Account != null;
			if (flag)
			{
				RealmServer realmServer;
				RealmServer.RealmServers.TryRemove(this.Account.BNetEmail, out realmServer);
			}
			BNetServer bnet = this.Bnet;
			if (bnet != null)
			{
				bnet.Dispose();
			}
			TcpClient client = this.Client;
			if (client != null)
			{
				client.Close();
			}
			NetworkStream stream = this.Stream;
			if (stream != null)
			{
				stream.Close();
			}
		}

		// Token: 0x040088CA RID: 35018
		public TcpClient Client;

		// Token: 0x040088CB RID: 35019
		public NetworkStream Stream;

		// Token: 0x040088CC RID: 35020
		public uint Hash;

		// Token: 0x040088CD RID: 35021
		public ushort Token;

		// Token: 0x040088CE RID: 35022
		public bool Compression = false;

		// Token: 0x040088CF RID: 35023
		public bool Resurrected = false;

		// Token: 0x040088D0 RID: 35024
		public uint playerId = 0U;

		// Token: 0x040088D1 RID: 35025
		public bool logging = false;

		// Token: 0x040088D2 RID: 35026
		public IPEndPoint Endpoint;

		// Token: 0x040088D3 RID: 35027
		private AccountLink Account;

		// Token: 0x040088D4 RID: 35028
		private string CharacterName = "";

		// Token: 0x040088D5 RID: 35029
		private uint CharId = 0U;

		// Token: 0x040088D6 RID: 35030
		private uint CharLevel = 0U;

		// Token: 0x040088D7 RID: 35031
		private uint hash = 0U;

		// Token: 0x040088D8 RID: 35032
		private ushort gameId = 0;

		// Token: 0x040088D9 RID: 35033
		private uint ip = 0U;

		// Token: 0x040088DA RID: 35034
		private bool creating = false;

		// Token: 0x040088DB RID: 35035
		private static List<Client> clients = new List<Client>();

		// Token: 0x040088DC RID: 35036
		public static ConcurrentDictionary<string, RealmServer> RealmServers = new ConcurrentDictionary<string, RealmServer>();

		// Token: 0x040088DD RID: 35037
		private List<CharData> Characters = new List<CharData>();
	}
}
