using System;
using System.Collections.Generic;
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
using D2Packets;
using D2Packets.Game.Client;
using D2Packets.Game.Server;
using Microsoft.CSharp.RuntimeBinder;
using Utilities.Security;

namespace BattleNetSharp.D2.Resurrected
{
	// Token: 0x02000B1E RID: 2846
	public class GameServer
	{
		// Token: 0x0600BFCE RID: 49102 RVA: 0x0049DFBC File Offset: 0x0049C1BC
		public GameServer(TcpClient client)
		{
			this.logging = Environment.MachineName == "DESKTOP-D9VF075";
			this.Client = client;
			this.Endpoint = this.Client.Client.RemoteEndPoint as IPEndPoint;
			IPAddress address = (this.Client.Client.RemoteEndPoint as IPEndPoint).Address;
			Console.WriteLine(((address != null) ? address.ToString() : null) + " : connecting");
		}

		// Token: 0x0600BFCF RID: 49103 RVA: 0x0049E0B8 File Offset: 0x0049C2B8
		public static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return true;
		}

		// Token: 0x0600BFD0 RID: 49104 RVA: 0x0049E0CC File Offset: 0x0049C2CC
		public void Listen()
		{
			this.BaseStream = this.Client.GetStream();
			this.Stream = new SslStream(this.BaseStream, false, new RemoteCertificateValidationCallback(GameServer.ValidateServerCertificate), null);
			X509Certificate2 x509Certificate = new X509Certificate2("C:\\Users\\andy\\Documents\\GitHub\\BattleNetSharp\\BattleNetSharp\\bin\\Debug\\net5.0\\bnet.pfx", "123");
			try
			{
				this.Stream.AuthenticateAsServer(x509Certificate, false, false);
			}
			catch (Exception ex)
			{
				Console.WriteLine("fin : " + ex.Message);
				return;
			}
			this.Stream.Write(new byte[]
			{
				175,
				Convert.ToByte(this.Compression)
			}, 0, 2);
			while (this.Client.Connected && (!this.Client.Client.Poll(1, SelectMode.SelectRead) || this.Client.Client.Available != 0))
			{
				try
				{
					this.HandlePacket();
				}
				catch (Exception ex2)
				{
					Console.WriteLine("error in gameserver : " + ex2.Message);
					Console.WriteLine(ex2.StackTrace);
				}
			}
			Console.WriteLine("connection end : ");
			this.ConnectionEnded = true;
		}

		// Token: 0x0600BFD1 RID: 49105 RVA: 0x0049E218 File Offset: 0x0049C418
		public void ProcessUpdates()
		{
			foreach (KeyValuePair<uint, Player> keyValuePair in GameServer.GameInstance.Players)
			{
				bool flag = keyValuePair.Key == this.playerId;
				if (!flag)
				{
					bool flag2 = keyValuePair.Value == null;
					if (!flag2)
					{
						bool flag3 = !this.ClientInstance.Players.ContainsKey(keyValuePair.Key);
						if (flag3)
						{
							this.ClientInstance.Players.TryAdd(keyValuePair.Key, keyValuePair.Value);
							this.SendPacket(new PlayerPartyRelationship
							{
								Id = keyValuePair.Key,
								Relationship = PartyRelationshipType.None
							});
							this.SendPacket(new AssignPlayer
							{
								Id = keyValuePair.Value.Id,
								Class = keyValuePair.Value.Class,
								Name = keyValuePair.Value.Name,
								X = keyValuePair.Value.X,
								Y = keyValuePair.Value.Y
							});
							this.SendPacket(new PlayerAttributeNotification
							{
								Id = keyValuePair.Key,
								AttribLOD = 67,
								Value = 100U
							});
							this.SendPacket(new PlayerAttributeNotification
							{
								Id = keyValuePair.Key,
								AttribLOD = 68,
								Value = 100U
							});
							this.SendPacket(new PlayerAttributeNotification
							{
								Id = keyValuePair.Key,
								AttribLOD = 12,
								Value = 99U
							});
							this.SendPacket(new PlayerAttributeNotification
							{
								Id = keyValuePair.Key,
								AttribLOD = 0,
								Value = 255U
							});
							this.SendPacket(new PlayerAttributeNotification
							{
								Id = keyValuePair.Key,
								AttribLOD = 2,
								Value = 255U
							});
							foreach (KeyValuePair<EquipmentLocation, ItemAction> keyValuePair2 in keyValuePair.Value.Equipment)
							{
								bool flag4 = keyValuePair2.Value.baseItem == null;
								if (!flag4)
								{
									this.SendPacket(keyValuePair2.Value);
								}
							}
							this.SendPacket(new PlayerInSight
							{
								Id = keyValuePair.Value.Id,
								Type = UnitType.Player
							});
							this.SendPacket(new SetState
							{
								Id = keyValuePair.Key,
								Type = UnitType.Player,
								unk = 268217449U
							});
						}
					}
				}
			}
			foreach (KeyValuePair<uint, AssignNPC> keyValuePair3 in GameServer.GameInstance.NPCs)
			{
			}
		}

		// Token: 0x0600BFD2 RID: 49106 RVA: 0x0049E560 File Offset: 0x0049C760
		public List<byte> ReadPacket()
		{
			List<byte> list = new List<byte>();
			bool flag = this.firstByte != 85;
			if (flag)
			{
				list.Add(this.firstByte);
				this.firstByte = 85;
			}
			while (this.Client.Connected && !this.BaseStream.DataAvailable)
			{
				Thread.Sleep(20);
			}
			bool flag2 = this.Client.Connected && this.BaseStream.DataAvailable && this.Stream.CanRead;
			if (flag2)
			{
				byte[] array = new byte[1024];
				do
				{
					int num = this.Stream.Read(array, 0, array.Length);
					list.AddRange(array.Take(num));
				}
				while (this.BaseStream.DataAvailable);
			}
			else
			{
				Thread.Sleep(50);
			}
			return list;
		}

        // Token: 0x0600BFD3 RID: 49107 RVA: 0x0049E64C File Offset: 0x0049C84C
        public void HandlePacket()
        {
            List<byte> list = this.ReadPacket();
            Type typeFromHandle = typeof(GameClientPacket);

            while (list.Count > 0)
            {
                while (list.Count > 0 && list[0] == 0)
                {
                    list = list.Skip(1).ToList();
                }

                if (list.Count == 0) break;

                int num = 0;
                string packetTypeName = typeFromHandle.AssemblyQualifiedName.Replace(typeFromHandle.Name, ((GameClientPacket)list[0]).ToString());
                Type packetType = Type.GetType(packetTypeName);

                if (packetType == null)
                {
                    Console.WriteLine($"No packet info for: {list[0]:X}");
                    break;
                }

                if (this.logging)
                {
                    string address = (this.Client.Client.RemoteEndPoint as IPEndPoint)?.Address.ToString();
                    Console.WriteLine($"{address} GC ({DateTime.UtcNow:HH:mm:ss.fff}): {packetType.Name}");
                }

                object packet = Activator.CreateInstance(packetType);

                try
                {
                    ((dynamic)packet).Bytes = list;
                }
                catch
                {
                    break;
                }

                if (this.waitingForPacket != null && this.waitingForPacket(packet))
                {
                    this.waitingForPacket = null;
                }

                if (num == 0)
                {
                    FieldInfo lengthField = packetType.GetField("Length");
                    if (lengthField != null)
                    {
                        try
                        {
                            num = (int)lengthField.GetValue(packet);
                        }
                        catch { }
                    }
                    else
                    {
                        try
                        {
                            num = ((dynamic)packet).Length;
                        }
                        catch { }
                    }
                }

                MethodInfo method = this.GetType().GetMethod(packetType.Name, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);

                if (method != null)
                {
                    method.Invoke(this, new object[] { packet });
                }
                else
                {
                    this.Undefined(list);
                }

                list = list.Skip(num).ToList();
            }
        }

        // Token: 0x0600BFD4 RID: 49108 RVA: 0x0049EB4C File Offset: 0x0049CD4C
        public void WaitForPacket(GameServer.WaitingForPacketDelegate waitUntilReceivedPacket)
		{
			this.waitingForPacket = waitUntilReceivedPacket;
			while (this.waitingForPacket != null)
			{
				Thread.Sleep(50);
			}
		}

		// Token: 0x0600BFD5 RID: 49109 RVA: 0x0049EB78 File Offset: 0x0049CD78
		public void SendPacket(Packet packet, ushort minSleep, ushort maxSleep)
		{
			this.SendPacket(packet);
			Thread.Sleep(this.rand.Next((int)minSleep, (int)maxSleep));
		}

		// Token: 0x0600BFD6 RID: 49110 RVA: 0x0049EB98 File Offset: 0x0049CD98
		public bool SendPacket(Packet packet, GameServer.WaitingForPacketDelegate waitUntilReceivedPacket)
		{
			this.waitingForPacket = waitUntilReceivedPacket;
			this.SendPacket(packet);
			int num = 0;
			while (this.waitingForPacket != null)
			{
				Thread.Sleep(50);
				bool flag = num++ > this.rand.Next(20, 100);
				if (flag)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600BFD7 RID: 49111 RVA: 0x0049EBF8 File Offset: 0x0049CDF8
		public void LoadPacket(Packet packet)
		{
			byte[] array = packet.ToArray();
			this.LoadedBytes.AddRange(array);
			this.LoadedPackets.Add(packet);
		}

		// Token: 0x0600BFD8 RID: 49112 RVA: 0x0049EC28 File Offset: 0x0049CE28
		public void FlushPackets()
		{
			this.LoadedBytes.Clear();
			foreach (Packet packet in this.LoadedPackets)
			{
				this.SendPacket(packet);
			}
			this.LoadedPackets.Clear();
		}

		// Token: 0x0600BFD9 RID: 49113 RVA: 0x0049EC98 File Offset: 0x0049CE98
		public void SendPacket(Packet packet)
		{
			byte[] array = packet.ToArray();
			this.SendPacket(array);
		}

		// Token: 0x0600BFDA RID: 49114 RVA: 0x0049ECB8 File Offset: 0x0049CEB8
		public static byte[] StringToByteArray(string hex)
		{
			hex = hex.Replace(",", "").Replace("-", "");
			string[] array = hex.Split(new char[] { ' ' });
			List<byte> list = new List<byte>();
			foreach (string text in array)
			{
				list.Add(Convert.ToByte(text, 16));
			}
			return list.ToArray();
		}

		// Token: 0x0600BFDB RID: 49115 RVA: 0x0049ED31 File Offset: 0x0049CF31
		public void SendPacket(string byteString)
		{
			this.SendPacket(GameServer.StringToByteArray(byteString));
		}

		// Token: 0x0600BFDC RID: 49116 RVA: 0x0049ED44 File Offset: 0x0049CF44
		public virtual void SendPacket(byte[] packetBytes)
		{
			bool flag = !this.Client.Connected;
			if (!flag)
			{
				bool flag2 = this.logging;
				if (flag2)
				{
					string[] array = new string[9];
					array[0] = this.playerId.ToString();
					array[1] = "(";
					int num = 2;
					IPAddress address = (this.Client.Client.RemoteEndPoint as IPEndPoint).Address;
					array[num] = ((address != null) ? address.ToString() : null);
					array[3] = ") GS (";
					array[4] = DateTime.UtcNow.ToString("HH:mm:ss.fff");
					array[5] = "): ";
					int num2 = 6;
					GameServerPacket gameServerPacket = (GameServerPacket)packetBytes[0];
					array[num2] = gameServerPacket.ToString();
					array[7] = " : ";
					array[8] = BitConverter.ToString(packetBytes);
					Console.WriteLine(string.Concat(array));
				}
				try
				{
					bool compression = this.Compression;
					if (compression)
					{
						byte[] array2 = new byte[1024];
						uint num3 = Huffman.Compress(packetBytes.ToArray<byte>(), out array2);
						List<byte> list = new List<byte>();
						bool flag3 = num3 >= 240U;
						if (flag3)
						{
							list.Add((byte)((num3 >> 8) | 15U));
						}
						list.Add((byte)((num3 + 1U) & 255U));
						list.AddRange(array2.Take((int)num3));
						this.Stream.Write(list.ToArray(), 0, list.Count);
					}
					else
					{
						List<byte> list2 = new List<byte>();
						list2.AddRange(packetBytes);
						this.Stream.Write(list2.ToArray(), 0, list2.Count);
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600BFDD RID: 49117 RVA: 0x0049EEF4 File Offset: 0x0049D0F4
		private void GameLogonRequest(GameLogonRequest request)
		{
			this.LoadPacket(new GameLogonReceipt
			{
				Difficulty = GameDifficulty.Normal,
				Expansion = 1,
				Ladder = 0,
				unk = 4,
				unk2 = 16
			});
			this.LoadPacket(new GameLoading());
			this.LoadPacket(new GameLogonSuccess());
			this.FlushPackets();
			this.logonPlayerName = request.Name;
		}

		// Token: 0x0600BFDE RID: 49118 RVA: 0x0049EF5D File Offset: 0x0049D15D
		private void Ping(Ping ping)
		{
			this.SendPacket(new Pong());
		}

		// Token: 0x0600BFDF RID: 49119 RVA: 0x0049EF6C File Offset: 0x0049D16C
		private void UploadSave(UploadSave save)
		{
			this.FileSaveBytes.AddRange(save.Data.Take(save.Data.Count - 1));
			bool flag = (long)this.FileSaveBytes.Count == (long)((ulong)save.FileLength);
			if (flag)
			{
				this.playerId = GameServer.PlayerIdCounter++;
				Player player = new Player();
				player.Id = this.playerId;
				File.WriteAllBytes(this.logonPlayerName + (this.Resurrected ? "_resurrected.d2s" : "_classic.d2s"), this.FileSaveBytes.ToArray());
				this.FileSave.Bytes = this.FileSaveBytes;
				player.Name = this.FileSave.Header.Name;
				player.Class = this.FileSave.Header.CharacterClass;
				player.Stats = this.FileSave.Attributes.Attributes;
				player.WaypointsUnlocked = this.FileSave.Header.Waypoints.NormalWaypoints.Waypoints;
				player.RightHandSkill = this.FileSave.Header.RightMouse;
				player.LeftHandSkill = this.FileSave.Header.LeftMouse;
				player.X = (ushort)(5872U + this.playerId * 5U);
				player.X = 25175;
				player.Y = 4701;
				player.Y = (ushort)(5125U + this.playerId * 3U);
				foreach (ItemAction itemAction in this.FileSave.Items.Items)
				{
					itemAction.Id = GameServer.ItemIdCounter++;
					itemAction.OwnerId = this.playerId;
					itemAction.SaveFormat = false;
					itemAction.D2RTA = false;
					itemAction.PacketId = GameServerPacket.WorldItemAction;
					itemAction.version = ItemVersion.LoD110;
					bool flag2 = itemAction.location == EquipmentLocation.NotApplicable;
					if (flag2)
					{
						itemAction.action = ItemActionType.PutInContainer;
						player.Inventory.Add(itemAction);
					}
					else
					{
						ItemCategory itemCategory = ItemCategory.Armor;
						bool flag3 = itemAction.location == EquipmentLocation.Helm;
						if (flag3)
						{
							itemCategory = ItemCategory.Helm;
						}
						else
						{
							bool flag4 = itemAction.location == EquipmentLocation.LeftHand;
							if (flag4)
							{
								itemCategory = ItemCategory.Weapon2;
							}
							else
							{
								bool flag5 = itemAction.location == EquipmentLocation.RightHand;
								if (flag5)
								{
									itemCategory = ItemCategory.Weapon;
								}
								else
								{
									bool flag6 = itemAction.location == EquipmentLocation.RightHandRing;
									if (flag6)
									{
										itemCategory = ItemCategory.Misc;
									}
									else
									{
										bool flag7 = itemAction.location == EquipmentLocation.LeftHandRing;
										if (flag7)
										{
											itemCategory = ItemCategory.Misc;
										}
										else
										{
											bool flag8 = itemAction.location == EquipmentLocation.Amulet;
											if (flag8)
											{
												itemCategory = ItemCategory.Misc;
											}
											else
											{
												bool flag9 = itemAction.location == EquipmentLocation.LeftHandSwitch;
												if (flag9)
												{
													itemCategory = ItemCategory.Weapon;
												}
												else
												{
													bool flag10 = itemAction.location == EquipmentLocation.RightHandSwitch;
													if (flag10)
													{
														itemCategory = ItemCategory.Weapon;
													}
												}
											}
										}
									}
								}
							}
						}
						itemAction.category = itemCategory;
						itemAction.flags |= ItemFlags.Equipped;
						itemAction.action = ItemActionType.Equip;
						itemAction.PacketId = GameServerPacket.OwnedItemAction;
						player.Equipment[itemAction.location] = itemAction;
					}
				}
				GameServer.GameInstance.Players.TryAdd(this.playerId, player);
			}
		}

		// Token: 0x0600BFE0 RID: 49120 RVA: 0x0049F2BC File Offset: 0x0049D4BC
		private void EnterGame(EnterGame enter)
		{
			byte[] array = Convert.FromHexString("5928afdb8c0370616c6c7900000000000000000000000000000001aa0028afdb8c0c6959f9ff1f760028afdb8c940828afdb8c000001020001010001d90001da0001db0001dc00010300015994b76d460370616c6c79000000000000000000000000000000002094b76d4643000000002094b76d4644000000002094b76d460c000000002094b76d4600000000002094b76d460200000000aa0094b76d460d6959f95fd73f8328afdb8c94b76d4600000000000000000001000000000d0094b76d4608000000000000760094b76d462094b76d460f0000000059cabb36230370616c6c790000000000000000000000000000000020cabb3623430000000020cabb3623440000000020cabb36230c0000000020cabb3623000000000020cabb36230200000000aa00cabb36230d6959f95fd73f8328afdb8ccabb362300000000000000000001000000000d00cabb3623080000000000007600cabb362320cabb36230f0000000059e53d9b110370616c6c790000000000000000000000000000000020e53d9b11430000000020e53d9b11440000000020e53d9b110c0000000020e53d9b11000000000020e53d9b110200000000aa00e53d9b110d6959f95fd73f8328afdb8ce53d9b1100000000000000000001000000000d00e53d9b11080000000000007600e53d9b1120e53d9b110f0000000022000028afdb8cdb0001000022000028afdb8cd9000100005e0101010101010101010101010101010101010101010101010101010101010101010101010128060000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000290000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000b0028afdb8c5f010000001d00191d010f1d02141d03191e0700371e09000f1e0b00591d0c019c0d141028afdb8c1000a20065080080061703029c0d141094b76d461000a20065080280061703029c0d1410cabb36231000a20065080480061703029c0d1410e53d9b111000a20065080680061703029d041910f29ecd980028afdb8c1100a20065007242373706029d04191079af664c0028afdb8c1100a20065005292363706029d061e05bc3733b60028afdb8c110082006584083037470682808081e13f9d062007de9b195b0028afdb8c1100820065a40a205637068280e0000606ff01230028afdb8c010000ffffffff230028afdb8c000000ffffffff1d00191d010f1d02141d03191e0700371e09000f1e0b00591d0c01953780074016000000000000000300a33d6428010011091b1f071803100401071003080401071003100401071803080401072003080401071003180401071803100401072003100401071803180401072003180401150028afdb8c990f6c14017e0000000053020000000000000000ac79af66689a00720f6114800e01aa0179af66680c6959f9ff1f6d79af6668720f6114805102dea690ec25006c0f681402000e02dea690ec030002000000acf29ecdd09800730f79148010114000aa01f29ecdd00c6959f9ff1f6df29ecdd0730f791480ace53d9b819300740f9e14800e01aa01e53d9b810c6959f9ff1f6de53d9b81740f9e14805102bd8d21f92500770f951402000e02bd8d21f903000200000051027b1b43d225006f0f7b1402000e027b1b43d2030002000000acbc3733a49b00920f7314800e01aa01bc3733a40c6959f9ff1f6dbc3733a4920f73148051026d06c9f20b01920f6d1400005102db0c92c525007a0f5b1402000e02db0c92c50300020000005102b71924ab2500880f721402000e02b71924ab03000200000051026f3348762400980f60140000a80028afdb8c0b69acfc0f1d0c011d00191d0214accbbb36239600ab0f6a14800e01aa01cbbb36230c6959f9ff1f6dcbbb3623ab0f6a1480");
			bool flag = Convert.FromHexString("ac96b76d469800c40f6a148010114000aa0196b76d460c6959f9ff1f6d96b76d46c40f6a14805102f73686847700b30f591402000e02f73686840301020000005102efad0c292500ab0f511402000e02efad0c290300020000005102de9b19522500a60f651402000e02de9b19520300020000005102bc3733a42500bf0f5a1402000e02bc3733a4030002000000ac2cafdb8c9800930f9c148010114000aa012cafdb8c0c6959f9ff1f6d2cafdb8c930f9c1480510279af66684e008b0f7b1400005102f29ecdd02500990f9b1402000e02f29ecdd00300020000005102e53d9b8123008c0f981400005102cbbb362327009d0f7a140000510296b76d468101a40f7914000051022cafdb8c2500b40f7d1402000e022cafdb8c0300020000001d00191d010f1d02141d03191e0700371e09000f1e0b00591d0c0148000028afdb8c000000000448000028afdb8c000000005b340038be5d220000000028afdb8c0370616c6c7900000000000000000000000100ffff000000000000000000000000000000008d28afdb8cffff5a0204000000000038be5d2200000000000000000000000083db5400000000000000") != null || true;
			if (flag)
			{
				this.SendPacket(new AssignPlayer
				{
					Id = 2363207464U,
					Class = CharacterClass.Paladin,
					Name = "pally",
					X = 0,
					Y = 0
				});
				this.SendPacket(new PlayerInSight
				{
					Type = UnitType.Player,
					Id = 2363207464U
				});
				this.SendPacket(Convert.FromHexString("940828AFDB8C000001020001010001D90001DA0001DB0001DC0001030001"));
				this.SendPacket(new AssignPlayer
				{
					Id = 1181595540U,
					Class = CharacterClass.Paladin,
					Name = "pally",
					X = 0,
					Y = 0
				});
				this.SendPacket(new PlayerAttributeNotification
				{
					Id = 1181595540U,
					AttribLOD = 67,
					Value = 0U
				});
				this.SendPacket(new PlayerAttributeNotification
				{
					Id = 1181595540U,
					AttribLOD = 68,
					Value = 0U
				});
				this.SendPacket(new PlayerAttributeNotification
				{
					Id = 1181595540U,
					AttribLOD = 12,
					Value = 0U
				});
				this.SendPacket(new PlayerAttributeNotification
				{
					Id = 1181595540U,
					AttribLOD = 0,
					Value = 0U
				});
				this.SendPacket(new PlayerAttributeNotification
				{
					Id = 1181595540U,
					AttribLOD = 2,
					Value = 0U
				});
				this.SendPacket(Convert.FromHexString("AA0094B76D460D6959F95FD73F"));
				this.SendPacket(new Relator3
				{
					OwnerId = 2363207464U,
					ChildId = 1181595540U,
					zerr = 0UL,
					hundred = 256,
					zer = 0U
				});
				this.SendPacket(new PlayerStop
				{
					Type = UnitType.Player,
					Id = 1181595540U,
					Unk = 8,
					X = 0,
					Y = 0,
					Un2 = 0,
					Life = 0
				});
				this.SendPacket(new PlayerInSight
				{
					Type = UnitType.Player,
					Id = 1181595540U
				});
				this.SendPacket(new PlayerAttributeNotification
				{
					Id = 1181595540U,
					AttribLOD = 15,
					Value = 0U
				});
				this.SendPacket(new AssignPlayer
				{
					Id = 590789578U,
					Class = CharacterClass.Paladin,
					Name = "pally",
					X = 0,
					Y = 0
				});
				this.SendPacket(new PlayerAttributeNotification
				{
					Id = 590789578U,
					AttribLOD = 67,
					Value = 0U
				});
				this.SendPacket(new PlayerAttributeNotification
				{
					Id = 590789578U,
					AttribLOD = 68,
					Value = 0U
				});
				this.SendPacket(new PlayerAttributeNotification
				{
					Id = 590789578U,
					AttribLOD = 12,
					Value = 0U
				});
				this.SendPacket(new PlayerAttributeNotification
				{
					Id = 590789578U,
					AttribLOD = 0,
					Value = 0U
				});
				this.SendPacket(new PlayerAttributeNotification
				{
					Id = 590789578U,
					AttribLOD = 2,
					Value = 0U
				});
				this.SendPacket(Convert.FromHexString("AA00CABB36230D6959F95FD73F"));
				this.SendPacket(new Relator3
				{
					OwnerId = 2363207464U,
					ChildId = 590789578U,
					zerr = 0UL,
					hundred = 256,
					zer = 0U
				});
				this.SendPacket(new PlayerStop
				{
					Type = UnitType.Player,
					Id = 590789578U,
					Unk = 8,
					X = 0,
					Y = 0,
					Un2 = 0,
					Life = 0
				});
				this.SendPacket(new PlayerInSight
				{
					Type = UnitType.Player,
					Id = 590789578U
				});
				this.SendPacket(new PlayerAttributeNotification
				{
					Id = 590789578U,
					AttribLOD = 15,
					Value = 0U
				});
				this.SendPacket(new AssignPlayer
				{
					Id = 295386597U,
					Class = CharacterClass.Paladin,
					Name = "pally",
					Y = 0
				});
				this.SendPacket(new PlayerAttributeNotification
				{
					Id = 295386597U,
					AttribLOD = 67,
					Value = 0U
				});
				this.SendPacket(new PlayerAttributeNotification
				{
					Id = 295386597U,
					AttribLOD = 68,
					Value = 0U
				});
				this.SendPacket(new PlayerAttributeNotification
				{
					Id = 295386597U,
					AttribLOD = 12,
					Value = 0U
				});
				this.SendPacket(new PlayerAttributeNotification
				{
					Id = 295386597U,
					AttribLOD = 0,
					Value = 0U
				});
				this.SendPacket(new PlayerAttributeNotification
				{
					Id = 295386597U,
					AttribLOD = 2,
					Value = 0U
				});
				this.SendPacket(Convert.FromHexString("AA00E53D9B110D6959F95FD73F"));
				this.SendPacket(new Relator3
				{
					OwnerId = 2363207464U,
					ChildId = 295386597U,
					zerr = 0UL,
					hundred = 256,
					zer = 0U
				});
				this.SendPacket(new PlayerStop
				{
					Type = UnitType.Player,
					Id = 295386597U,
					Unk = 8,
					X = 0,
					Y = 0,
					Un2 = 0,
					Life = 0
				});
				this.SendPacket(new PlayerInSight
				{
					Type = UnitType.Player,
					Id = 295386597U
				});
				this.SendPacket(new PlayerAttributeNotification
				{
					Id = 295386597U,
					AttribLOD = 15,
					Value = 0U
				});
				this.SendPacket(new UpdatePlayerItemSkill
				{
					Unkd800 = 0,
					Id = 2363207464U,
					Skill = SkillType.ScrollOfTownportal,
					Quantity = 1,
					Unk5f = 0
				});
				this.SendPacket(new UpdatePlayerItemSkill
				{
					Unkd800 = 0,
					Id = 2363207464U,
					Skill = SkillType.ScrollOfIdentify,
					Quantity = 1,
					Unk5f = 0
				});
				this.SendPacket(Convert.FromHexString("5E01010101010101010101010101010101010101010101010101010101010101010101010101"));
				this.SendPacket(Convert.FromHexString("28060000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000"));
				this.SendPacket(Convert.FromHexString("29000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000"));
				this.SendPacket(new GameHandshake
				{
					Type = UnitType.Player,
					Id = 2363207464U
				});
				this.SendPacket(new Unk5f
				{
					unk1 = 1U
				});
				this.SendPacket(new AttributeByte
				{
					Attrib = 0U,
					Value = 25
				});
				this.SendPacket(new AttributeByte
				{
					Attrib = 0U,
					Value = 15
				});
				this.SendPacket(new AttributeByte
				{
					Attrib = 0U,
					Value = 20
				});
				this.SendPacket(new AttributeByte
				{
					Attrib = 0U,
					Value = 25
				});
				this.SendPacket(new AttributeWord
				{
					Attrib = 0,
					Value = 55
				});
				this.SendPacket(new AttributeWord
				{
					Attrib = 0,
					Value = 15
				});
				this.SendPacket(new AttributeWord
				{
					Attrib = 0,
					Value = 89
				});
				this.SendPacket(new AttributeByte
				{
					Attrib = 0U,
					Value = 1
				});
				this.SendPacket(new AssignSkill
				{
					Type = UnitType.Player,
					Id = 2363207464U,
					Hand = SkillHand.Left,
					Skill = SkillType.Attack,
					ChargedItemId = uint.MaxValue
				});
				this.SendPacket(new AssignSkill
				{
					Type = UnitType.Player,
					Id = 2363207464U,
					Hand = SkillHand.Right,
					Skill = SkillType.Attack,
					ChargedItemId = uint.MaxValue
				});
				this.SendPacket(new AttributeByte
				{
					Attrib = 0U,
					Value = 25
				});
				this.SendPacket(new AttributeByte
				{
					Attrib = 0U,
					Value = 15
				});
				this.SendPacket(new AttributeByte
				{
					Attrib = 0U,
					Value = 20
				});
				this.SendPacket(new AttributeByte
				{
					Attrib = 0U,
					Value = 25
				});
				this.SendPacket(new AttributeWord
				{
					Attrib = 0,
					Value = 55
				});
				this.SendPacket(new AttributeWord
				{
					Attrib = 0,
					Value = 15
				});
				this.SendPacket(new AttributeWord
				{
					Attrib = 0,
					Value = 89
				});
				this.SendPacket(new AttributeByte
				{
					Attrib = 0U,
					Value = 1
				});
				this.SendPacket(Convert.FromHexString("9537800740160000000000"));
				this.SendPacket(new LoadAct
				{
					Act = ActLocation.Act1,
					MapId = 677658019U,
					Area = AreaLevel.RogueEncampment,
					Unk1 = 0,
					Unk2 = 521865489U
				});
				this.SendPacket(new MapAdd
				{
					X = 792,
					Y = 1040,
					Area = AreaLevel.RogueEncampment
				});
				this.SendPacket(new MapAdd
				{
					X = 784,
					Y = 1032,
					Area = AreaLevel.RogueEncampment
				});
				this.SendPacket(new MapAdd
				{
					X = 784,
					Y = 1040,
					Area = AreaLevel.RogueEncampment
				});
				this.SendPacket(new MapAdd
				{
					X = 792,
					Y = 1032,
					Area = AreaLevel.RogueEncampment
				});
				this.SendPacket(new MapAdd
				{
					X = 800,
					Y = 1032,
					Area = AreaLevel.RogueEncampment
				});
				this.SendPacket(new MapAdd
				{
					X = 784,
					Y = 1048,
					Area = AreaLevel.RogueEncampment
				});
				this.SendPacket(new MapAdd
				{
					X = 792,
					Y = 1040,
					Area = AreaLevel.RogueEncampment
				});
				this.SendPacket(new MapAdd
				{
					X = 800,
					Y = 1040,
					Area = AreaLevel.RogueEncampment
				});
				this.SendPacket(new MapAdd
				{
					X = 792,
					Y = 1048,
					Area = AreaLevel.RogueEncampment
				});
				this.SendPacket(new MapAdd
				{
					X = 800,
					Y = 1048,
					Area = AreaLevel.RogueEncampment
				});
				this.SendPacket(new PlayerReassign
				{
					Type = UnitType.Player,
					Id = 2363207464U,
					X = 3993,
					Y = 5228,
					Reassign = 1
				});
				this.SendPacket(new Unk7e
				{
					unk1 = 0U
				});
				this.SendPacket(new PartyRefresh
				{
					Slot = 2U,
					Alternator = 0,
					Count = 0U
				});
			}
			this.SendPacket(new Relator2
			{
				Param1 = 0,
				Id = 2363207464U,
				Param2 = 0U
			});
			this.SendPacket(new LoadDone());
			this.SendPacket(new Relator2
			{
				Param1 = 0,
				Id = 2363207464U,
				Param2 = 0U
			});
			this.SendPacket(Convert.FromHexString("5B340038BE5D220000000028AFDB8C0370616C6C7900000000000000000000000100FFFF00000000000000000000000000000000"));
			this.SendPacket(new AssignPlayerToParty
			{
				Id = 2363207464U,
				PartyNumber = ushort.MaxValue
			});
			this.SendPacket(new AssignPlayer
			{
				Id = 2363207464U,
				Class = CharacterClass.Paladin,
				Name = "pally",
				X = 0,
				Y = 0
			});
			this.SendPacket(new PlayerInSight
			{
				Type = UnitType.Player,
				Id = 2363207464U
			});
			this.SendPacket(Convert.FromHexString("940828AFDB8C000001020001010001D90001DA0001DB0001DC0001030001"));
			this.SendPacket(new AssignPlayer
			{
				Id = 1181595540U,
				Class = CharacterClass.Paladin,
				Name = "pally",
				X = 0,
				Y = 0
			});
			this.SendPacket(new PlayerAttributeNotification
			{
				Id = 1181595540U,
				AttribLOD = 67,
				Value = 0U
			});
			this.SendPacket(new PlayerAttributeNotification
			{
				Id = 1181595540U,
				AttribLOD = 68,
				Value = 0U
			});
			this.SendPacket(new PlayerAttributeNotification
			{
				Id = 1181595540U,
				AttribLOD = 12,
				Value = 0U
			});
			this.SendPacket(new PlayerAttributeNotification
			{
				Id = 1181595540U,
				AttribLOD = 0,
				Value = 0U
			});
			this.SendPacket(new PlayerAttributeNotification
			{
				Id = 1181595540U,
				AttribLOD = 2,
				Value = 0U
			});
			this.SendPacket(Convert.FromHexString("AA0094B76D460D6959F95FD73F"));
			this.SendPacket(new Relator3
			{
				OwnerId = 2363207464U,
				ChildId = 1181595540U,
				zerr = 0UL,
				hundred = 256,
				zer = 0U
			});
			this.SendPacket(new PlayerStop
			{
				Type = UnitType.Player,
				Id = 1181595540U,
				Unk = 8,
				X = 0,
				Y = 0,
				Un2 = 0,
				Life = 0
			});
			this.SendPacket(new PlayerInSight
			{
				Type = UnitType.Player,
				Id = 1181595540U
			});
			this.SendPacket(new PlayerAttributeNotification
			{
				Id = 1181595540U,
				AttribLOD = 15,
				Value = 0U
			});
			this.SendPacket(new AssignPlayer
			{
				Id = 590789578U,
				Class = CharacterClass.Paladin,
				Name = "pally",
				X = 0,
				Y = 0
			});
			this.SendPacket(new PlayerAttributeNotification
			{
				Id = 590789578U,
				AttribLOD = 67,
				Value = 0U
			});
			this.SendPacket(new PlayerAttributeNotification
			{
				Id = 590789578U,
				AttribLOD = 68,
				Value = 0U
			});
			this.SendPacket(new PlayerAttributeNotification
			{
				Id = 590789578U,
				AttribLOD = 12,
				Value = 0U
			});
			this.SendPacket(new PlayerAttributeNotification
			{
				Id = 590789578U,
				AttribLOD = 0,
				Value = 0U
			});
			this.SendPacket(new PlayerAttributeNotification
			{
				Id = 590789578U,
				AttribLOD = 2,
				Value = 0U
			});
			this.SendPacket(Convert.FromHexString("AA00CABB36230D6959F95FD73F"));
			this.SendPacket(new Relator3
			{
				OwnerId = 2363207464U,
				ChildId = 590789578U,
				zerr = 0UL,
				hundred = 256,
				zer = 0U
			});
			this.SendPacket(new PlayerStop
			{
				Type = UnitType.Player,
				Id = 590789578U,
				Unk = 8,
				X = 0,
				Y = 0,
				Un2 = 0,
				Life = 0
			});
			this.SendPacket(new PlayerInSight
			{
				Type = UnitType.Player,
				Id = 590789578U
			});
			this.SendPacket(new PlayerAttributeNotification
			{
				Id = 590789578U,
				AttribLOD = 15,
				Value = 0U
			});
			this.SendPacket(new AssignPlayer
			{
				Id = 295386597U,
				Class = CharacterClass.Paladin,
				Name = "pally",
				Y = 0
			});
			this.SendPacket(new PlayerAttributeNotification
			{
				Id = 295386597U,
				AttribLOD = 67,
				Value = 0U
			});
			this.SendPacket(new PlayerAttributeNotification
			{
				Id = 295386597U,
				AttribLOD = 68,
				Value = 0U
			});
			this.SendPacket(new PlayerAttributeNotification
			{
				Id = 295386597U,
				AttribLOD = 12,
				Value = 0U
			});
			this.SendPacket(new PlayerAttributeNotification
			{
				Id = 295386597U,
				AttribLOD = 0,
				Value = 0U
			});
			this.SendPacket(new PlayerAttributeNotification
			{
				Id = 295386597U,
				AttribLOD = 2,
				Value = 0U
			});
			this.SendPacket(Convert.FromHexString("AA00E53D9B110D6959F95FD73F"));
			this.SendPacket(new Relator3
			{
				OwnerId = 2363207464U,
				ChildId = 295386597U,
				zerr = 0UL,
				hundred = 256,
				zer = 0U
			});
			this.SendPacket(new PlayerStop
			{
				Type = UnitType.Player,
				Id = 295386597U,
				Unk = 8,
				X = 0,
				Y = 0,
				Un2 = 0,
				Life = 0
			});
			this.SendPacket(new PlayerInSight
			{
				Type = UnitType.Player,
				Id = 295386597U
			});
			this.SendPacket(new PlayerAttributeNotification
			{
				Id = 295386597U,
				AttribLOD = 15,
				Value = 0U
			});
			this.SendPacket(new UpdatePlayerItemSkill
			{
				Unkd800 = 0,
				Id = 2363207464U,
				Skill = SkillType.ScrollOfTownportal,
				Quantity = 1,
				Unk5f = 0
			});
			this.SendPacket(new UpdatePlayerItemSkill
			{
				Unkd800 = 0,
				Id = 2363207464U,
				Skill = SkillType.ScrollOfIdentify,
				Quantity = 1,
				Unk5f = 0
			});
			this.SendPacket(Convert.FromHexString("5E01010101010101010101010101010101010101010101010101010101010101010101010101"));
			this.SendPacket(Convert.FromHexString("28060000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000"));
			this.SendPacket(Convert.FromHexString("29000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000"));
			this.SendPacket(new GameHandshake
			{
				Type = UnitType.Player,
				Id = 2363207464U
			});
			this.SendPacket(new Unk5f
			{
				unk1 = 1U
			});
			this.SendPacket(new AttributeByte
			{
				Attrib = 0U,
				Value = 25
			});
			this.SendPacket(new AttributeByte
			{
				Attrib = 0U,
				Value = 15
			});
			this.SendPacket(new AttributeByte
			{
				Attrib = 0U,
				Value = 20
			});
			this.SendPacket(new AttributeByte
			{
				Attrib = 0U,
				Value = 25
			});
			this.SendPacket(new AttributeWord
			{
				Attrib = 0,
				Value = 55
			});
			this.SendPacket(new AttributeWord
			{
				Attrib = 0,
				Value = 15
			});
			this.SendPacket(new AttributeWord
			{
				Attrib = 0,
				Value = 89
			});
			this.SendPacket(new AttributeByte
			{
				Attrib = 0U,
				Value = 1
			});
			this.SendPacket(new AssignSkill
			{
				Type = UnitType.Player,
				Id = 2363207464U,
				Hand = SkillHand.Left,
				Skill = SkillType.Attack,
				ChargedItemId = uint.MaxValue
			});
			this.SendPacket(new AssignSkill
			{
				Type = UnitType.Player,
				Id = 2363207464U,
				Hand = SkillHand.Right,
				Skill = SkillType.Attack,
				ChargedItemId = uint.MaxValue
			});
			this.SendPacket(new AttributeByte
			{
				Attrib = 0U,
				Value = 25
			});
			this.SendPacket(new AttributeByte
			{
				Attrib = 0U,
				Value = 15
			});
			this.SendPacket(new AttributeByte
			{
				Attrib = 0U,
				Value = 20
			});
			this.SendPacket(new AttributeByte
			{
				Attrib = 0U,
				Value = 25
			});
			this.SendPacket(new AttributeWord
			{
				Attrib = 0,
				Value = 55
			});
			this.SendPacket(new AttributeWord
			{
				Attrib = 0,
				Value = 15
			});
			this.SendPacket(new AttributeWord
			{
				Attrib = 0,
				Value = 89
			});
			this.SendPacket(new AttributeByte
			{
				Attrib = 0U,
				Value = 1
			});
			this.SendPacket(Convert.FromHexString("95378007401600000000000000"));
			this.SendPacket(new LoadAct
			{
				Act = ActLocation.Act1,
				MapId = 677658019U,
				Area = AreaLevel.RogueEncampment,
				Unk2 = 521865489U
			});
			this.playerId = 2363207464U;
			this.TeleportPlayerTo(AreaLevel.RogueEncampment, 3993, 5228);
			this.SendPacket(Convert.FromHexString("7E00000000"));
			this.SendPacket(Convert.FromHexString("53020000000000000000"));
			this.SendPacket(Convert.FromHexString("1D0C01"));
			this.SendPacket(Convert.FromHexString("1D0019"));
			this.SendPacket(Convert.FromHexString("1D0214"));
			this.SendPacket(new AttributeByte
			{
				Attrib = 0U,
				Value = 25
			});
			this.SendPacket(new AttributeByte
			{
				Attrib = 0U,
				Value = 15
			});
			this.SendPacket(new AttributeByte
			{
				Attrib = 0U,
				Value = 20
			});
			this.SendPacket(new AttributeByte
			{
				Attrib = 0U,
				Value = 25
			});
			this.SendPacket(new AttributeWord
			{
				Attrib = 0,
				Value = 55
			});
			this.SendPacket(new AttributeWord
			{
				Attrib = 0,
				Value = 15
			});
			this.SendPacket(new AttributeWord
			{
				Attrib = 0,
				Value = 89
			});
			this.SendPacket(new AttributeByte
			{
				Attrib = 0U,
				Value = 1
			});
			this.SendPacket(new Relator2
			{
				Param1 = 0,
				Id = 2363207464U,
				Param2 = 0U
			});
			this.SendPacket(new LoadDone());
			this.SendPacket(new Relator2
			{
				Param1 = 0,
				Id = 2363207464U,
				Param2 = 0U
			});
			this.SendPacket(Convert.FromHexString("5B340038BE5D220000000028AFDB8C0370616C6C7900000000000000000000000100FFFF00000000000000000000000000000000"));
			this.SendPacket(new AssignPlayerToParty
			{
				Id = 2363207464U,
				PartyNumber = ushort.MaxValue
			});
			Console.Read();
			this.SendPacket(new UnloadDone());
			this.SendPacket(new LoadAct
			{
				Act = ActLocation.Act2,
				MapId = 677658019U,
				Area = AreaLevel.LutGholein,
				Unk2 = 521865489U
			});
			this.TeleportPlayerTo(AreaLevel.LutGholein, 5121, 5076);
			this.SendPacket(new LoadDone());
			bool flag2 = !GameServer.GameInstance.Players.ContainsKey(this.playerId);
			if (flag2)
			{
				this.playerId = GameServer.PlayerIdCounter++;
				Player player = new Player();
				player.Id = this.playerId;
				this.FileSaveBytes = File.ReadAllBytes("C:\\Users\\andy\\Saved Games\\Diablo II\\shalzadin.d2s").ToList<byte>();
				this.FileSave.Bytes = this.FileSaveBytes;
				player.Name = this.FileSave.Header.Name;
				player.Class = this.FileSave.Header.CharacterClass;
				player.Stats = this.FileSave.Attributes.Attributes;
				player.WaypointsUnlocked = this.FileSave.Header.Waypoints.NormalWaypoints.Waypoints;
				player.RightHandSkill = this.FileSave.Header.RightMouse;
				player.LeftHandSkill = this.FileSave.Header.LeftMouse;
				player.X = (ushort)(5872U + this.playerId * 5U);
				player.X = 25175;
				player.Y = 4701;
				player.Y = (ushort)(5125U + this.playerId * 3U);
				foreach (ItemAction itemAction in this.FileSave.Items.Items)
				{
					itemAction.Id = GameServer.ItemIdCounter++;
					itemAction.OwnerId = this.playerId;
					itemAction.SaveFormat = false;
					itemAction.D2RTA = false;
					itemAction.PacketId = GameServerPacket.WorldItemAction;
					itemAction.version = ItemVersion.LoD110;
					bool flag3 = itemAction.location == EquipmentLocation.NotApplicable;
					if (flag3)
					{
						itemAction.action = ItemActionType.PutInContainer;
						player.Inventory.Add(itemAction);
					}
					else
					{
						ItemCategory itemCategory = ItemCategory.Armor;
						bool flag4 = itemAction.location == EquipmentLocation.Helm;
						if (flag4)
						{
							itemCategory = ItemCategory.Helm;
						}
						else
						{
							bool flag5 = itemAction.location == EquipmentLocation.LeftHand;
							if (flag5)
							{
								itemCategory = ItemCategory.Weapon2;
							}
							else
							{
								bool flag6 = itemAction.location == EquipmentLocation.RightHand;
								if (flag6)
								{
									itemCategory = ItemCategory.Weapon;
								}
								else
								{
									bool flag7 = itemAction.location == EquipmentLocation.RightHandRing;
									if (flag7)
									{
										itemCategory = ItemCategory.Misc;
									}
									else
									{
										bool flag8 = itemAction.location == EquipmentLocation.LeftHandRing;
										if (flag8)
										{
											itemCategory = ItemCategory.Misc;
										}
										else
										{
											bool flag9 = itemAction.location == EquipmentLocation.Amulet;
											if (flag9)
											{
												itemCategory = ItemCategory.Misc;
											}
											else
											{
												bool flag10 = itemAction.location == EquipmentLocation.LeftHandSwitch;
												if (flag10)
												{
													itemCategory = ItemCategory.Weapon;
												}
												else
												{
													bool flag11 = itemAction.location == EquipmentLocation.RightHandSwitch;
													if (flag11)
													{
														itemCategory = ItemCategory.Weapon;
													}
												}
											}
										}
									}
								}
							}
						}
						itemAction.category = itemCategory;
						itemAction.flags |= ItemFlags.Equipped;
						itemAction.action = ItemActionType.Equip;
						itemAction.PacketId = GameServerPacket.OwnedItemAction;
						player.Equipment[itemAction.location] = itemAction;
					}
				}
				GameServer.GameInstance.Players.TryAdd(this.playerId, player);
			}
			Player player2 = GameServer.GameInstance.Players[this.playerId];
			this.SendPacket(new AssignPlayer
			{
				Id = this.playerId,
				Class = CharacterClass.Barbarian,
				Name = "shalzuth"
			});
			this.SendPacket(new PlayerInSight
			{
				Id = this.playerId,
				Type = UnitType.Player
			});
			List<SkillsLog.SkillLevel> list = new List<SkillsLog.SkillLevel>();
			List<SkillType> list2 = new List<SkillType>((SkillType[])Enum.GetValues(typeof(SkillType)));
			list.Add(new SkillsLog.SkillLevel
			{
				Type = SkillType.Attack,
				Level = 1
			});
			this.SendPacket(new SkillsLog
			{
				Id = this.playerId,
				NumSkills = (byte)list.Count,
				Skills = list
			});
			UpdateQuestStatus updateQuestStatus = new UpdateQuestStatus();
			updateQuestStatus.Quests_37 = (from s in Enumerable.Range(0, 37).ToList<int>()
				select 0).ToList<byte>();
			this.SendPacket(updateQuestStatus);
			List<UpdateQuestInfo.QuestInfo> list3 = new List<UpdateQuestInfo.QuestInfo>();
			for (int i = 0; i < 41; i++)
			{
				list3.Add(new UpdateQuestInfo.QuestInfo());
			}
			this.SendPacket(new UpdateQuestInfo
			{
				Id = this.playerId,
				Type = UpdateQuestInfo.QuestInfoUpdateType.QuestLog,
				Quests_42 = list3
			});
			List<UpdateGameQuestLog.QuestState> list4 = new List<UpdateGameQuestLog.QuestState>();
			for (int j = 0; j < 41; j++)
			{
				list4.Add(new UpdateGameQuestLog.QuestState());
			}
			this.SendPacket(new UpdateGameQuestLog
			{
				Quests_41 = list4
			});
			this.SendPacket(new GameHandshake
			{
				Id = this.playerId,
				Type = UnitType.Player
			});
			this.SendPacket(new Unk5f
			{
				unk1 = 1U
			});
			this.SendPacket(new AssignSkill
			{
				Id = this.playerId,
				Type = UnitType.Player,
				Hand = SkillHand.Left,
				Skill = SkillType.Attack,
				ChargedItemId = uint.MaxValue
			});
			this.SendPacket(new AssignSkill
			{
				Id = this.playerId,
				Type = UnitType.Player,
				Hand = SkillHand.Right,
				Skill = SkillType.Attack,
				ChargedItemId = uint.MaxValue
			});
			foreach (StatBase statBase in player2.Stats)
			{
				uint num = (uint)((statBase is SignedStat) ? ((SignedStat)statBase).Value : ((int)((UnsignedStat)statBase).Value));
				this.SendPacket(new AttributeDWord
				{
					Attrib = (byte)statBase.BaseStat.Type,
					Value = num
				});
			}
			foreach (KeyValuePair<EquipmentLocation, ItemAction> keyValuePair in player2.Equipment)
			{
				bool flag12 = keyValuePair.Value.baseItem == null;
				if (flag12)
				{
				}
			}
			this.SendPacket(new LoadAct
			{
				Act = ActLocation.Act1,
				MapId = 677658019U,
				Area = AreaLevel.RogueEncampment,
				Unk2 = 521865489U
			});
			this.TeleportPlayerTo(AreaLevel.RogueEncampment, 3993, 5228);
			this.SendPacket(new Unk7e());
			this.SendPacket(new PartyRefresh
			{
				Slot = 2U
			});
			this.SendPacket(new SetState
			{
				Id = this.playerId,
				Type = UnitType.Player,
				unk = 268217449U
			});
			this.SendPacket(new Relator2
			{
				Id = this.playerId
			});
			this.SendPacket(new LoadDone());
			this.SendPacket(new Relator2
			{
				Id = this.playerId
			});
			this.SendPacket(new AssignPlayerToParty
			{
				Id = this.playerId,
				PartyNumber = ushort.MaxValue
			});
			this.SendPacket(new ExperienceUInt32
			{
				Experience = 0U
			});
			this.EnteredGame = true;
		}

		// Token: 0x0600BFE1 RID: 49121 RVA: 0x004A1104 File Offset: 0x0049F304
		private void TeleportPlayerTo(AreaLevel level, ushort x, ushort y)
		{
			int num = (int)(x / 5);
			int num2 = num % 8;
			num2 = num - num2;
			int num3 = (int)(y / 5);
			int num4 = num3 % 8;
			num4 = num3 - num4;
			for (int i = -1; i < 1; i++)
			{
				for (int j = -1; j < 1; j++)
				{
					this.SendPacket(new MapAdd
					{
						X = (ushort)(num2 + i * 8),
						Y = (ushort)(num4 + j * 8),
						Area = level
					});
				}
			}
			this.SendPacket(new PlayerReassign
			{
				Id = this.playerId,
				Type = UnitType.Player,
				X = x,
				Y = y,
				Reassign = 1
			});
		}

		// Token: 0x0600BFE2 RID: 49122 RVA: 0x004A11B8 File Offset: 0x0049F3B8
		private void SelectSkill(SelectSkill data)
		{
			bool flag = data.Hand == global::D2Packets.Game.Client.SelectSkill.SelectSkillHand.Left;
			if (flag)
			{
				GameServer.GameInstance.Players[this.playerId].LeftHandSkill = data.Type;
			}
			bool flag2 = data.Hand == global::D2Packets.Game.Client.SelectSkill.SelectSkillHand.Right;
			if (flag2)
			{
				GameServer.GameInstance.Players[this.playerId].RightHandSkill = data.Type;
			}
			this.SendPacket(new AssignSkill
			{
				Id = this.playerId,
				Type = UnitType.Player,
				Hand = ((data.Hand == global::D2Packets.Game.Client.SelectSkill.SelectSkillHand.Left) ? SkillHand.Left : SkillHand.Right),
				Skill = data.Type,
				ChargedItemId = uint.MaxValue
			});
		}

		// Token: 0x0600BFE3 RID: 49123 RVA: 0x004A126D File Offset: 0x0049F46D
		private void WalkToLocation(WalkToLocation data)
		{
		}

		// Token: 0x0600BFE4 RID: 49124 RVA: 0x004A1270 File Offset: 0x0049F470
		private void RunToLocation(RunToLocation data)
		{
		}

		// Token: 0x0600BFE5 RID: 49125 RVA: 0x004A1273 File Offset: 0x0049F473
		private void CastLeftSkill(CastLeftSkill data)
		{
		}

		// Token: 0x0600BFE6 RID: 49126 RVA: 0x004A1276 File Offset: 0x0049F476
		private void RecastLeftSkill(RecastLeftSkill data)
		{
		}

		// Token: 0x0600BFE7 RID: 49127 RVA: 0x004A1279 File Offset: 0x0049F479
		private void CastRightSkill(CastRightSkill data)
		{
		}

		// Token: 0x0600BFE8 RID: 49128 RVA: 0x004A127C File Offset: 0x0049F47C
		private void RecastRightSkill(RecastRightSkill data)
		{
		}

		// Token: 0x0600BFE9 RID: 49129 RVA: 0x004A127F File Offset: 0x0049F47F
		private void CastLeftSkillOnTarget(CastLeftSkillOnTarget data)
		{
		}

		// Token: 0x0600BFEA RID: 49130 RVA: 0x004A1282 File Offset: 0x0049F482
		private void RecastLeftSkillOnTarget(RecastLeftSkillOnTarget data)
		{
		}

		// Token: 0x0600BFEB RID: 49131 RVA: 0x004A1285 File Offset: 0x0049F485
		private void CastLeftSkillOnTarget(CastRightSkillOnTarget data)
		{
		}

		// Token: 0x0600BFEC RID: 49132 RVA: 0x004A1288 File Offset: 0x0049F488
		private void RecastRightSkillOnTarget(RecastRightSkillOnTarget data)
		{
		}

		// Token: 0x0600BFED RID: 49133 RVA: 0x004A128C File Offset: 0x0049F48C
		public void SaveAndKick()
		{
			this.SendPacket(new UnloadDone());
			byte[] array = this.FileSaveBytes.ToArray();
			int num = array.Length;
			bool flag = true;
			for (;;)
			{
				IEnumerable<byte> enumerable = array.Take(255);
				this.SendPacket(new DownloadSave
				{
					ChunkLen = (byte)enumerable.Count<byte>(),
					IsFirst = flag,
					SaveSize = num,
					Chunk = enumerable.ToList<byte>()
				});
				bool flag2 = enumerable.Count<byte>() != 255;
				if (flag2)
				{
					break;
				}
				flag = false;
				array = array.Skip(255).ToArray<byte>();
			}
			this.SendPacket(new GameLogoutSuccess());
			this.Client.Close();
		}

		// Token: 0x0600BFEE RID: 49134 RVA: 0x004A1343 File Offset: 0x0049F543
		private void ExitGame(ExitGame data)
		{
			this.SendPacket(new GameOver());
			this.SendPacket(new ConnectionRefused());
			GameServer.GameInstance.Players[this.playerId] = null;
		}

		// Token: 0x0600BFEF RID: 49135 RVA: 0x004A137C File Offset: 0x0049F57C
		private void UnequipItem(UnequipItem data)
		{
			int tickCount = Environment.TickCount;
			ItemAction itemAction = GameServer.GameInstance.Players[this.playerId].Equipment[data.Location];
			GameServer.GameInstance.Players[this.playerId].Equipment[data.Location] = new ItemAction();
			itemAction.flags &= ~ItemFlags.Equipped;
			itemAction.action = ItemActionType.Unequip;
			itemAction.destination = ItemDestination.Cursor;
			GameServer.GameInstance.Players[this.playerId].Inventory.Add(itemAction);
		}

		// Token: 0x0600BFF0 RID: 49136 RVA: 0x004A1420 File Offset: 0x0049F620
		private void EquipItem(EquipItem data)
		{
			int tickCount = Environment.TickCount;
			ItemAction itemAction = GameServer.GameInstance.Players[this.playerId].Inventory.First((ItemAction i) => i.Id == data.Id);
			itemAction.PacketId = GameServerPacket.OwnedItemAction;
			itemAction.flags |= ItemFlags.Equipped;
			itemAction.action = ItemActionType.Equip;
			itemAction.destination = ItemDestination.Equipment;
			itemAction.location = data.Location;
			GameServer.GameInstance.Players[this.playerId].Equipment[data.Location] = itemAction;
		}

		// Token: 0x0600BFF1 RID: 49137 RVA: 0x004A14D4 File Offset: 0x0049F6D4
		private void DropItem(DropItem data)
		{
			ItemAction itemAction = GameServer.GameInstance.Players[this.playerId].Inventory.First((ItemAction i) => i.destination == ItemDestination.Cursor);
			itemAction.destination = ItemDestination.Ground;
			itemAction.action = ItemActionType.DropToGround;
			itemAction.location = EquipmentLocation.NotApplicable;
			itemAction.x = (int)GameServer.GameInstance.Players[this.playerId].X;
			itemAction.y = (int)GameServer.GameInstance.Players[this.playerId].Y;
			itemAction.PacketId = GameServerPacket.WorldItemAction;
			GameServer.GameInstance.Players[this.playerId].Inventory.Remove(itemAction);
			GameServer.GameInstance.Items.TryAdd(itemAction.Id, itemAction);
		}

		// Token: 0x0600BFF2 RID: 49138 RVA: 0x004A15BC File Offset: 0x0049F7BC
		private void DropItemToContainer(DropItemToContainer data)
		{
			ItemAction itemAction = GameServer.GameInstance.Players[this.playerId].Inventory.First((ItemAction i) => i.destination == ItemDestination.Cursor);
			itemAction.destination = ItemDestination.Item;
			itemAction.action = ItemActionType.PutInContainer;
			itemAction.location = EquipmentLocation.NotApplicable;
			itemAction.x = (int)data.X;
			itemAction.y = (int)data.Y;
			itemAction.container = ItemContainer.Inventory;
			itemAction.PacketId = GameServerPacket.WorldItemAction;
			this.SendPacket(itemAction);
		}

		// Token: 0x0600BFF3 RID: 49139 RVA: 0x004A1650 File Offset: 0x0049F850
		private void PickItem(PickItem data)
		{
			ItemAction itemAction = GameServer.GameInstance.Items[data.Id];
			itemAction.destination = ((data.ToLocation == global::D2Packets.Game.Client.PickItem.PickLocation.Cursor) ? ItemDestination.Cursor : ItemDestination.Item);
			itemAction.action = ((data.ToLocation == global::D2Packets.Game.Client.PickItem.PickLocation.Cursor) ? ItemActionType.GroundToCursor : ItemActionType.PutInContainer);
			itemAction.PacketId = GameServerPacket.WorldItemAction;
			itemAction.OwnerId = this.playerId;
			itemAction.x = 4;
			itemAction.y = 0;
			itemAction.container = ItemContainer.Inventory;
			this.SendPacket(itemAction);
			GameServer.GameInstance.Players[this.playerId].Inventory.Add(itemAction);
		}

		// Token: 0x0600BFF4 RID: 49140 RVA: 0x004A16F0 File Offset: 0x0049F8F0
		private void PickItemFromContainer(PickItemFromContainer data)
		{
			ItemAction itemAction = GameServer.GameInstance.Players[this.playerId].Inventory.First((ItemAction i) => i.Id == data.Id);
			itemAction.action = ItemActionType.ToCursor;
			itemAction.destination = ItemDestination.Cursor;
			this.SendPacket(itemAction);
		}

		// Token: 0x0600BFF5 RID: 49141 RVA: 0x004A174E File Offset: 0x0049F94E
		private void SendOverheadMessage(SendOverheadMessage data)
		{
		}

		// Token: 0x0600BFF6 RID: 49142 RVA: 0x004A1754 File Offset: 0x0049F954
		private void SendMessage(SendMessage data)
		{
			Task task = Task.Run(delegate
			{
				bool flag = data.Message.Contains("bosses");
				if (flag)
				{
					Thread.Sleep(5000);
					Thread.Sleep(5000);
				}
				bool flag2 = data.Message.Contains("waypoint");
				if (flag2)
				{
					Thread.Sleep(2000);
					Thread.Sleep(2000);
					Thread.Sleep(2000);
					Thread.Sleep(2000);
				}
				bool flag3 = data.Message.Contains("spawnnpc");
				if (flag3)
				{
					uint num = uint.Parse(data.Message.Split(new char[] { ' ' }).Last<string>());
					List<byte> list = new List<byte>();
					list.Add(172);
					list.AddRange(BitConverter.GetBytes((ushort)num));
					list.Add(128);
					list.Add(14);
					list.Add(1);
					this.SendPacket(list.ToArray());
				}
			});
		}

		// Token: 0x0600BFF7 RID: 49143 RVA: 0x004A1788 File Offset: 0x0049F988
		private void Undefined(List<byte> data)
		{
			string[] array = new string[5];
			int num = 0;
			IPAddress address = (this.Client.Client.RemoteEndPoint as IPEndPoint).Address;
			array[num] = ((address != null) ? address.ToString() : null);
			array[1] = " : UNKNOWN GAME PACKET : ";
			int num2 = 2;
			object obj = Enum.Parse(typeof(GameClientPacket), data[0].ToString());
			array[num2] = ((obj != null) ? obj.ToString() : null);
			array[3] = " | ";
			array[4] = BitConverter.ToString(data.ToArray());
			Console.WriteLine(string.Concat(array));
		}

		// Token: 0x04009227 RID: 37415
		public TcpClient Client;

		// Token: 0x04009228 RID: 37416
		public NetworkStream BaseStream;

		// Token: 0x04009229 RID: 37417
		public SslStream Stream;

		// Token: 0x0400922A RID: 37418
		public static Manager GameInstance = new Manager();

		// Token: 0x0400922B RID: 37419
		public Manager ClientInstance = new Manager();

		// Token: 0x0400922C RID: 37420
		public uint Hash;

		// Token: 0x0400922D RID: 37421
		public ushort Token;

		// Token: 0x0400922E RID: 37422
		public bool Compression = false;

		// Token: 0x0400922F RID: 37423
		public bool Resurrected = false;

		// Token: 0x04009230 RID: 37424
		public Thread PacketHandlerThread;

		// Token: 0x04009231 RID: 37425
		public uint playerId = 0U;

		// Token: 0x04009232 RID: 37426
		public bool logging = true;

		// Token: 0x04009233 RID: 37427
		public IPEndPoint Endpoint;

		// Token: 0x04009234 RID: 37428
		public bool ConnectionEnded = false;

		// Token: 0x04009235 RID: 37429
		public static bool firstCheck = false;

		// Token: 0x04009236 RID: 37430
		private byte firstByte = 0;

		// Token: 0x04009237 RID: 37431
		public bool FirstPacketCheck = true;

		// Token: 0x04009238 RID: 37432
		public static uint PlayerIdCounter = 2363207464U;

		// Token: 0x04009239 RID: 37433
		public static uint ItemIdCounter = 1U;

		// Token: 0x0400923A RID: 37434
		public Random rand = new Random();

		// Token: 0x0400923B RID: 37435
		public GameServer.WaitingForPacketDelegate waitingForPacket;

		// Token: 0x0400923C RID: 37436
		private List<byte> LoadedBytes = new List<byte>();

		// Token: 0x0400923D RID: 37437
		private List<Packet> LoadedPackets = new List<Packet>();

		// Token: 0x0400923E RID: 37438
		public string logonPlayerName;

		// Token: 0x0400923F RID: 37439
		public List<byte> FileSaveBytes = new List<byte>();

		// Token: 0x04009240 RID: 37440
		private UploadSave.D2S FileSave = new UploadSave.D2S();

		// Token: 0x04009241 RID: 37441
		public bool EnteredGame = false;

		// Token: 0x02001435 RID: 5173
		// (Invoke) Token: 0x0600E2FE RID: 58110
		public delegate bool WaitingForPacketDelegate(Packet data);
	}
}
