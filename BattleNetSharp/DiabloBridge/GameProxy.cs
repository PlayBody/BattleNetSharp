using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using BattleNetSharp;
using BattleNetSharp.D2.Resurrected;
using D2Data;
using D2GameState;
using D2Packets;
using D2Packets.Game.Client;
using D2Packets.Game.Server;

namespace DiabloBridge
{
	// Token: 0x0200098E RID: 2446
	public class GameProxy
	{
		// Token: 0x1700390D RID: 14605
		// (get) Token: 0x0600B9D8 RID: 47576 RVA: 0x004612DC File Offset: 0x0045F4DC
		public Player me
		{
			get
			{
				return this.GameInstance.Players.ContainsKey(this.myId) ? this.GameInstance.Players[this.myId] : this.dummy;
			}
		}

		// Token: 0x0600B9D9 RID: 47577 RVA: 0x00461324 File Offset: 0x0045F524
		public static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return true;
		}

		// Token: 0x0600B9DA RID: 47578 RVA: 0x00461338 File Offset: 0x0045F538
		public void WriteLine(string s)
		{
			bool flag = this.logging;
			if (flag)
			{
				bool flag2 = !string.IsNullOrEmpty(this.name);
				if (flag2)
				{
					Console.WriteLine(s);
				}
			}
		}

		// Token: 0x0600B9DB RID: 47579 RVA: 0x0046136C File Offset: 0x0045F56C
		public GameProxy()
		{
		}

		// Token: 0x0600B9DC RID: 47580 RVA: 0x00461484 File Offset: 0x0045F684
		public GameProxy(TcpClient client)
		{
			this.ClientProxy = client;
			this.Endpoint = this.ClientProxy.Client.RemoteEndPoint as IPEndPoint;
			this.ClientStream = this.ClientProxy.GetStream();
			this.ClientStream.ReadTimeout = -1;
			this.ClientStream.Write(new byte[]
			{
				175,
				Convert.ToByte(this.Compression)
			}, 0, 2);
			Task.Run(delegate
			{
				while (this.ClientProxy.Connected && this.ClientStream.CanRead && !this.Kill)
				{
					try
					{
						this.HandleClientPacket();
					}
					catch (Exception ex)
					{
						this.Terminate();
						this.WriteLine("error in gameclient : " + ex.Message);
						this.WriteLine(ex.StackTrace);
						return;
					}
				}
				this.Terminate();
			});
		}

		// Token: 0x0600B9DD RID: 47581 RVA: 0x00461618 File Offset: 0x0045F818
		public void Terminate()
		{
			this.Kill = true;
			try
			{
				bool flag = this.ClientStream.CanRead && this.ClientStream.CanWrite;
				if (flag)
				{
					NetworkStream clientStream = this.ClientStream;
					if (clientStream != null)
					{
						clientStream.Write(new GameOver().ToArray());
					}
					NetworkStream clientStream2 = this.ClientStream;
					if (clientStream2 != null)
					{
						clientStream2.Close();
					}
				}
			}
			catch
			{
				Console.WriteLine("game proxy terminate1");
			}
			try
			{
				bool flag2 = this.ServerStream != null && this.ServerStream.CanRead && this.ServerStream.CanWrite;
				if (flag2)
				{
					Task task = this.ServerStream.ShutdownAsync();
					task.Wait();
				}
			}
			catch
			{
				try
				{
					this.ServerBaseStream.Close();
				}
				catch
				{
				}
				Console.WriteLine("game proxy terminate2");
			}
			GameProxy gameProxy;
			GameProxy.GameProxies.TryRemove(this.Email, out gameProxy);
			GameProxy.GameInfo gameInfo;
			GameProxy.GameAccountLink.TryRemove(this.hash, out gameInfo);
		}

		// Token: 0x0600B9DE RID: 47582 RVA: 0x0046174C File Offset: 0x0045F94C
		private GameLogonRequest GameLogonRequest(GameLogonRequest request)
		{
			this.name = request.Name;
			this.hash = request.Hash;
			GameProxy.GameInfo gameInfo = GameProxy.GameAccountLink[request.Hash];
			this.CharacterName = gameInfo.character;
			this.Email = gameInfo.account;
			GameProxy gameProxy;
			bool flag = GameProxy.GameProxies.TryGetValue(this.Email, out gameProxy);
			GameLogonRequest gameLogonRequest;
			if (flag)
			{
				gameLogonRequest = null;
			}
			else
			{
				GameProxy.GameProxies.TryAdd(this.Email, this);
				this.ServerProxy = new TcpClient();
				this.ServerProxy.Connect(IPAddress.Parse(gameInfo.ipAddr), 443);
				this.ServerBaseStream = this.ServerProxy.GetStream();
				this.ServerStream = new SslStream(this.ServerBaseStream, false, new RemoteCertificateValidationCallback(GameProxy.ValidateServerCertificate), null);
				this.ServerStream.ReadTimeout = -1;
				this.ServerStream.AuthenticateAsClient("*.classic.blizzard.com");
				Task.Run(delegate
				{
					int num = this.ServerStream.ReadByte();
					int num2 = this.ServerStream.ReadByte();
					while (this.ServerBaseStream.Socket.Connected && !this.Kill)
					{
						try
						{
							this.HandleServerPacket();
						}
						catch (IOException ex)
						{
							this.Terminate();
							this.WriteLine("error in gameserver ioexception : " + ex.Message);
							this.WriteLine(ex.StackTrace);
							break;
						}
						catch (Exception ex2)
						{
							this.Terminate();
							this.WriteLine("error in gameserver : " + ex2.Message);
							this.WriteLine(ex2.StackTrace);
							break;
						}
					}
				});
				request.Secret = gameInfo.secret;
				gameLogonRequest = request;
			}
			return gameLogonRequest;
		}

		// Token: 0x0600B9DF RID: 47583 RVA: 0x00461868 File Offset: 0x0045FA68
		public void HandleClientPacket()
		{
			Packet.VersionForNewPackets = GameVersion.LOD;
			List<byte> list = new List<byte>();
			byte[] array = new byte[this.ClientProxy.ReceiveBufferSize];
			try
			{
				int num = this.ClientStream.Read(array, 0, array.Length);
				list.AddRange(array.Take(num));
				bool flag = num == 0;
				if (flag)
				{
					this.ClientProxy.Close();
				}
			}
			catch
			{
				Console.WriteLine("game proxy handle client packet");
			}
			Type typeFromHandle = typeof(GameClientPacket);
			while (list.Count > 0)
			{
				int num2 = 0;
				string text = typeFromHandle.AssemblyQualifiedName.Replace(typeFromHandle.Name, ((GameClientPacket)list[0]).ToString());
				Type type = Type.GetType(text);
				bool flag2 = type == null;
				if (flag2)
				{
					bool flag3 = this.logging;
					if (flag3)
					{
						this.WriteLine("no client packet info for : " + list[0].ToString("X") + " : " + BitConverter.ToString(list.ToArray()));
					}
					break;
				}
				string[] array2 = new string[7];
				int num3 = 0;
				IPAddress address = (this.ClientProxy.Client.RemoteEndPoint as IPEndPoint).Address;
				array2[num3] = ((address != null) ? address.ToString() : null);
				array2[1] = " GC (";
				array2[2] = DateTime.UtcNow.ToString("HH:mm:ss.fff");
				array2[3] = "): ";
				array2[4] = type.Name;
				array2[5] = " : ";
				array2[6] = BitConverter.ToString(list.Take(32).ToArray<byte>());
				this.WriteLine(string.Concat(array2));
				Packet packet = (Packet)Activator.CreateInstance(type);
				packet.PacketVersion = GameVersion.LOD;
				try
				{
					packet.Bytes = list;
				}
				catch
				{
					Console.WriteLine("client packet parse fail");
					break;
				}
				bool flag4 = num2 == 0;
				if (flag4)
				{
					FieldInfo field = type.GetField("Length");
					try
					{
						num2 = packet.ToArray().Length;
					}
					catch
					{
						Console.WriteLine("Failed byte array2 : " + type.Name);
					}
				}
				packet.PacketVersion = GameVersion.D2R;
				list = list.Skip(num2).ToList<byte>();
				Packet packet2 = packet;
				bool flag5 = packet2 is UnitInteract;
				if (flag5)
				{
					bool flag6 = ((UnitInteract)packet2).Type == UnitType.NPC;
					if (flag6)
					{
						this.ServerStream.Write(new TownFolkInteract
						{
							Id = ((UnitInteract)packet2).Id,
							PacketVersion = GameVersion.D2R
						}.ToArray());
						this.ClientStream.Write(new NPCInfo
						{
							Type = UnitType.NPC,
							Id = ((UnitInteract)packet2).Id
						}.ToArray());
						continue;
					}
					bool flag7 = ((UnitInteract)packet2).Type == UnitType.Warp;
					if (flag7)
					{
						this.ServerStream.Write(new WarpInteract
						{
							Id = ((UnitInteract)packet2).Id,
							PacketVersion = GameVersion.D2R
						}.ToArray());
						continue;
					}
					bool flag8 = ((UnitInteract)packet2).Type == UnitType.GameObject;
					if (flag8)
					{
						uint num4 = (uint)this.GOs[((UnitInteract)packet2).Id].Mode;
						bool flag9 = num4 == 1U;
						if (flag9)
						{
							num4 = 2U;
						}
						AssignGameObject assignGameObject = this.GOs[((UnitInteract)packet2).Id];
						bool flag10 = this.GOs[((UnitInteract)packet2).Id].ObjectId.ToString().Contains("Waypoint");
						if (flag10)
						{
							this.waypointId = ((UnitInteract)packet2).Id;
						}
						else
						{
							bool flag11 = this.GOs[((UnitInteract)packet2).Id].ObjectId.ToString().Contains("DiabloSeal");
							if (flag11)
							{
								num4 = 0U;
							}
						}
						this.ServerStream.Write(new Interact
						{
							TargetId = ((UnitInteract)packet2).Id,
							Mode = num4,
							PacketVersion = GameVersion.D2R
						}.ToArray());
						continue;
					}
					bool flag12 = ((UnitInteract)packet2).Type == UnitType.Player;
					if (flag12)
					{
						((UnitInteract)packet2).myId = this.me.Id;
					}
				}
				bool flag13 = packet2 is TownFolkMenuSelect && ((TownFolkMenuSelect)packet2).Type == TownFolkMenuItem.Travel;
				if (flag13)
				{
					bool flag14 = ((TownFolkMenuSelect)packet2).Data == 0U;
					if (flag14)
					{
						bool flag15 = this.GameInstance.NPCs[((TownFolkMenuSelect)packet2).Id].NpcType == NPCCode.Akara;
						if (flag15)
						{
							this.ServerStream.Write(new ResetCharacter
							{
								AkaraId = ((TownFolkMenuSelect)packet2).Id,
								PacketVersion = GameVersion.D2R
							}.ToArray());
						}
					}
					else
					{
						uint data = ((TownFolkMenuSelect)packet2).Data;
						bool flag16 = !this.GameInstance.Items.ContainsKey(data);
						if (flag16)
						{
							this.ServerStream.Write(new IdentifyGambleItemOrTravel
							{
								Id = ((TownFolkMenuSelect)packet2).Id,
								AreaLevel = (AreaLevel)data,
								PacketVersion = GameVersion.D2R
							}.ToArray());
						}
						else
						{
							ItemAction itemAction = this.GameInstance.Items[data];
							ushort num5 = (ushort)itemAction.x;
							ushort num6 = (ushort)itemAction.y;
							this.FitTopLeftToBottomRight(itemAction, this.GameInstance.Items.Values.Where((ItemAction i) => i.container == ItemContainer.Inventory), 10, 4, true, ref num5, ref num6);
							bool flag17 = this.GameInstance.NPCs[((TownFolkMenuSelect)packet2).Id].NpcType == NPCCode.Larzuk;
							if (flag17)
							{
								this.ServerStream.Write(new SocketQuest
								{
									VendorId = ((TownFolkMenuSelect)packet2).Id,
									ItemId = ((TownFolkMenuSelect)packet2).Data,
									x = num5,
									y = num6,
									PacketVersion = GameVersion.D2R
								}.ToArray());
							}
						}
					}
				}
				else
				{
					bool flag18 = packet2 is TownFolkMenuSelect && ((TownFolkMenuSelect)packet2).Type == TownFolkMenuItem.Trade;
					if (flag18)
					{
						uint data2 = ((TownFolkMenuSelect)packet2).Data;
						bool flag19 = this.GameInstance.Items.ContainsKey(data2);
						if (flag19)
						{
							this.ServerStream.Write(new SocketQuest
							{
								VendorId = ((TownFolkMenuSelect)packet2).Id,
								ItemId = ((TownFolkMenuSelect)packet2).Data,
								x = (ushort)this.GameInstance.Items[data2].x,
								y = (ushort)this.GameInstance.Items[data2].y,
								PacketVersion = GameVersion.D2R
							}.ToArray());
							continue;
						}
					}
					bool flag20 = packet2 is ExitGame;
					if (flag20)
					{
						this.ClientStream.Write(new ConnectionRefused().ToArray());
						this.Terminate();
						break;
					}
					bool flag21 = packet2 is IdentifyItemGoldXfer;
					if (flag21)
					{
						IdentifyItemGoldXfer identifyItemGoldXfer = (IdentifyItemGoldXfer)packet2;
						ItemAction itemAction2 = this.GameInstance.Items[identifyItemGoldXfer.ItemId];
						ItemAction itemAction3 = this.GameInstance.Items[identifyItemGoldXfer.ScrollId];
						UseItem useItem = new UseItem
						{
							Consume = 1,
							isMerc = 4,
							xff = 0,
							ItemId = identifyItemGoldXfer.ScrollId,
							PlayerId = identifyItemGoldXfer.ItemId,
							TargetX = (byte)itemAction2.x,
							TargetY = (byte)itemAction2.y,
							X = (byte)itemAction3.x,
							Y = (byte)itemAction3.y,
							PacketVersion = GameVersion.D2R
						};
						this.ServerStream.Write(useItem.ToArray());
					}
					else
					{
						bool flag22 = packet2 is UseInventoryItem;
						if (flag22)
						{
							bool flag23 = ((UseInventoryItem)packet2).Id == 0U;
							if (!flag23)
							{
								ItemAction itemAction4 = this.GameInstance.Items[((UseInventoryItem)packet2).Id];
								byte b = 0;
								bool flag24 = itemAction4.baseItem.Type.ToString().Contains("Potion") || itemAction4.baseItem.Type.ToString().Contains("Scroll") || itemAction4.baseItem.Type == ItemType.BookOfSkill;
								if (flag24)
								{
									b = 1;
								}
								bool flag25 = itemAction4.baseItem.Type.ToString().Contains("Identify");
								if (flag25)
								{
									this.ClientStream.Write(new UseStackableItem
									{
										Id = itemAction4.Id,
										Type2 = UseStackableItem.StackableItemClickType2.NormalClick,
										PacketVersion = GameVersion.LOD
									}.ToArray());
								}
								int num7 = 0;
								bool flag26 = itemAction4.container == ItemContainer.Stash;
								if (flag26)
								{
									num7 = 1024;
								}
								UseItem useItem2 = new UseItem
								{
									Consume = b,
									ItemId = itemAction4.Id,
									PlayerId = this.me.Id,
									X = (byte)itemAction4.x,
									Y = (byte)itemAction4.y,
									xff02ifbelt = (ushort)num7,
									PacketVersion = GameVersion.D2R
								};
								this.ServerStream.Write(useItem2.ToArray());
							}
						}
						else
						{
							bool flag27 = packet2 is UseItem;
							if (flag27)
							{
								ItemAction item = this.GameInstance.Items[((UseItem)packet2).Id];
								uint num8 = ((((UseItem)packet2).Character == UseItem.Location.Player) ? this.me.Id : this.Mercs.Values.Last((AssignMerc m) => m.OwnerId == this.me.Id).Id);
								UseItem useItem3 = new UseItem
								{
									ItemId = item.Id,
									Consume = 1,
									PlayerId = num8,
									isMerc = ((num8 == this.me.Id) ? 0 : 1),
									X = (byte)item.x,
									Y = (byte)item.y,
									xff02ifbelt = 65282,
									PacketVersion = GameVersion.D2R
								};
								bool flag28 = item.baseItem.Type.ToString().Contains("Identify");
								if (flag28)
								{
									this.ClientStream.Write(new UseStackableItem
									{
										Id = item.Id,
										Type1 = UseStackableItem.StackableItemClickType1.ActionClick,
										Type2 = UseStackableItem.StackableItemClickType2.ActionClick,
										PacketVersion = GameVersion.LOD
									}.ToArray());
								}
								bool flag29 = item.baseItem.Type.ToString().Contains("Potion");
								if (flag29)
								{
									useItem3.X %= 4;
									IEnumerable<ItemAction> enumerable = from i in this.GameInstance.Items.Values
										where i.container == ItemContainer.Belt || i.action == ItemActionType.PutInBelt || i.destination == ItemDestination.Belt
										where i.action != ItemActionType.RemoveFromBelt
										select i;
									List<ItemAction> list2 = (from p in enumerable
										where p.x % 4 == item.x % 4
										orderby p.x
										select p).ToList<ItemAction>();
									bool flag30 = list2.Count > 1;
									if (flag30)
									{
										useItem3.ItemId = list2[0].Id;
									}
									for (int k = 0; k < list2.Count - 1; k++)
									{
										useItem3.Pots[k].Id = list2[k + 1].Id;
										useItem3.Pots[k].PrevPos = (byte)list2[k + 1].x;
										useItem3.Pots[k].NewPos = (byte)list2[k].x;
									}
								}
								this.ServerStream.Write(useItem3.ToArray());
							}
							else
							{
								bool flag31 = packet2 is WaypointTravelPutSharedStash;
								if (flag31)
								{
									WaypointInteract waypointInteract = new WaypointInteract
									{
										Destination = ((WaypointTravelPutSharedStash)packet2).Destination,
										PacketVersion = GameVersion.D2R
									};
									this.ServerStream.Write(waypointInteract.ToArray());
								}
								else
								{
									bool flag32 = packet2 is ClickButton;
									if (flag32)
									{
										bool flag33 = ((ClickButton)packet2).Button == GameButton.Transmute;
										if (flag33)
										{
											ItemAction itemAction5 = this.GameInstance.Items.Values.First((ItemAction i) => i.baseItem.Type == ItemType.HoradricCube);
											List<ItemAction> list3 = (from i in this.GameInstance.Items.Values.ToList<ItemAction>().FindAll((ItemAction i) => i.container == ItemContainer.Cube)
												orderby i.x + i.y * 16
												select i).ToList<ItemAction>();
											bool flag34 = list3.Count > 0;
											if (flag34)
											{
												int num9 = 0;
												bool flag35 = itemAction5.container == ItemContainer.Stash;
												if (flag35)
												{
													num9 = 4;
												}
												UseInventoryItem useInventoryItem = new UseInventoryItem
												{
													Id = itemAction5.Id,
													CubeLocation = (byte)num9,
													XY = (byte)(itemAction5.x + itemAction5.y * 16),
													PacketVersion = GameVersion.D2R
												};
												useInventoryItem.NumItems = (byte)(list3.Count - 1);
												useInventoryItem.FirstItem = new UseInventoryItem.HoradricItem
												{
													ItemId = list3[0].Id,
													HoradricCubeLocation = (byte)(list3[0].x + list3[0].y * 16)
												};
												for (int j = 1; j < list3.Count; j++)
												{
													useInventoryItem.OtherItems.Add(new UseInventoryItem.HoradricItem
													{
														ItemId = list3[j].Id,
														HoradricCubeLocation = (byte)(list3[j].x + list3[j].y * 16)
													});
												}
												bool flag36 = this.logging;
												if (flag36)
												{
													Console.WriteLine(BitConverter.ToString(useInventoryItem.ToArray()));
												}
												this.ServerStream.Write(useInventoryItem.ToArray());
											}
										}
										else
										{
											bool flag37 = ((ClickButton)packet2).Button == GameButton.WithdrawGold;
											if (!flag37)
											{
												bool flag38 = ((ClickButton)packet2).Button == GameButton.StashGold;
												if (flag38)
												{
													this.ServerStream.Write(new IdentifyItemGoldXfer
													{
														Id = this.me.Id,
														InventoryGold = this.me.Attributes[StatType.Gold],
														InventoryChangeGold = (int)(0U - this.me.Attributes[StatType.Gold]),
														BankGold = (this.me.Attributes.ContainsKey(StatType.GoldBank) ? this.me.Attributes[StatType.GoldBank] : 0U),
														PacketVersion = GameVersion.D2R
													}.ToArray());
												}
											}
										}
									}
									else
									{
										bool flag39 = packet2 is Interact;
										if (flag39)
										{
											packet2.PacketVersion = GameVersion.D2R;
											((Interact)packet2).SourceItemId = ((Interact)packet2).ItemId;
											this.ServerStream.Write(packet2.ToArray());
										}
										else
										{
											bool flag40 = packet2 is TownFolkInteract || packet2 is WaypointInteract || packet2 is UpdatePosition || packet2 is HoverUnit || packet2 is EndCinematic || packet2 is DelayedState || packet2 is EnterGame;
											if (!flag40)
											{
												MethodInfo method = base.GetType().GetMethod(type.Name, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
												try
												{
													bool flag41 = method != null;
													if (flag41)
													{
														packet2 = (Packet)method.Invoke(this, new object[] { packet });
													}
												}
												catch
												{
													Console.WriteLine("method failed to translate : " + type.Name);
													packet2 = null;
												}
												Dictionary<SkillType, int> castDelay = new Dictionary<SkillType, int>
												{
													{
														SkillType.Blizzard,
														1800
													},
													{
														SkillType.FrozenOrb,
														1000
													},
													{
														SkillType.Meteor,
														1200
													}
												};
												bool flag42 = packet2 is CastRightSkill || packet2 is CastLeftSkill || packet2 is CastRightSkillOnTarget || packet2 is CastLeftSkillOnTarget;
												if (flag42)
												{
													SkillType castedSkill = ((packet2 is CastRightSkill || packet2 is CastRightSkillOnTarget) ? this.me.RightHandSkill : this.me.LeftHandSkill);
													bool flag43 = castDelay.ContainsKey(castedSkill);
													if (flag43)
													{
														DelayedState delayedState = new DelayedState
														{
															Id = this.me.Id,
															StateLOD = 121
														};
														delayedState.PacketVersion = GameVersion.LOD;
														this.ClientStream.Write(delayedState.ToArray());
														Task.Run(delegate
														{
															Thread.Sleep(castDelay[castedSkill]);
															this.ClientStream.Write(new EndState
															{
																Id = this.me.Id,
																StateLOD = 121,
																PacketVersion = GameVersion.LOD
															}.ToArray());
														});
													}
												}
												bool flag44 = packet2 != null;
												if (flag44)
												{
													packet2.PacketVersion = GameVersion.D2R;
													byte[] array3 = packet2.ToArray();
													bool flag45 = this.logging;
													if (flag45)
													{
														this.WriteLine(BitConverter.ToString(array3.ToArray<byte>()));
													}
													bool flag46 = !(packet2 is UpdatePosition);
													if (flag46)
													{
														this.ServerStream.Write(array3);
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B9E0 RID: 47584 RVA: 0x00462B78 File Offset: 0x00460D78
		public void HandleServerPacket()
		{
			Packet.VersionForNewPackets = GameVersion.D2R;
			List<byte> list = new List<byte>();
			list.AddRange(this.combinePacket);
			byte[] array = new byte[this.ServerProxy.ReceiveBufferSize];
			try
			{
				int num = this.ServerStream.Read(array, 0, array.Length);
				list.AddRange(array.Take(num));
				bool flag = num == 0;
				if (flag)
				{
					this.ServerProxy.Close();
				}
			}
			catch
			{
				Console.WriteLine("read from server error");
				this.Terminate();
				return;
			}
			Type typeFromHandle = typeof(GameServerPacket);
			while (list.Count > 0)
			{
				this.combinePacket = new byte[0];
				int num2 = 0;
				string text = typeFromHandle.AssemblyQualifiedName.Replace(typeFromHandle.Name, ((GameServerPacket)list[0]).ToString());
				Type type = Type.GetType(text);
				bool flag2 = type == null;
				if (flag2)
				{
					this.WriteLine("no server packet info for : " + list[0].ToString("X"));
					this.WriteLine(BitConverter.ToString(list.ToArray()));
					break;
				}
				bool flag3 = list[0] == 2;
				if (flag3)
				{
					bool logonSuccess = this.LogonSuccess;
					if (logonSuccess)
					{
						list = list.Skip(1).ToList<byte>();
						continue;
					}
					this.LogonSuccess = true;
				}
				int num3;
				bool packetSize = GameServerPacketSizes.GetPacketSize(list, out num3, true);
				bool flag4 = this.logging && !this.clientOnly;
				if (flag4)
				{
					string[] array2 = new string[7];
					int num4 = 0;
					TcpClient clientProxy = this.ClientProxy;
					object obj;
					if (clientProxy == null)
					{
						obj = null;
					}
					else
					{
						Socket client = clientProxy.Client;
						obj = ((client != null) ? client.RemoteEndPoint : null);
					}
					IPAddress address = (obj as IPEndPoint).Address;
					array2[num4] = ((address != null) ? address.ToString() : null);
					array2[1] = " GS (";
					array2[2] = DateTime.UtcNow.ToString("HH:mm:ss.fff");
					array2[3] = "): ";
					array2[4] = type.Name;
					array2[5] = " : ";
					array2[6] = BitConverter.ToString(list.Take(num3).ToArray<byte>());
					this.WriteLine(string.Concat(array2));
				}
				bool flag5 = !packetSize || list.Count < num3;
				if (flag5)
				{
					bool flag6 = this.logging;
					if (flag6)
					{
						this.WriteLine("packet not big enough");
					}
					this.combinePacket = list.ToArray();
					break;
				}
				Packet packet = (Packet)Activator.CreateInstance(type);
				packet.PacketVersion = GameVersion.D2R;
				try
				{
					packet.Bytes = list;
				}
				catch
				{
					Console.WriteLine("server packet parse fail, try next");
					this.combinePacket = list.ToArray();
					break;
				}
				bool flag7 = num2 == 0;
				if (flag7)
				{
					try
					{
						num2 = packet.ToArray().Length;
					}
					catch
					{
						Console.WriteLine("Failed byte arraygns : " + type.Name);
					}
				}
				Packet packet2 = packet;
				packet2.PacketVersion = GameVersion.LOD;
				MethodInfo method = base.GetType().GetMethod(type.Name, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
				bool flag8 = method != null;
				if (flag8)
				{
					packet2 = (Packet)method.Invoke(this, new object[] { packet2 });
				}
				bool flag9 = packet2 != null && !packet2.ToArray().SequenceEqual(list.Take(num3));
				if (flag9)
				{
					bool flag10 = this.logging && !this.clientOnly;
					if (flag10)
					{
						this.WriteLine("                             " + packet2.GetType().Name + " : " + BitConverter.ToString(packet2.ToArray()));
					}
				}
				bool flag11 = packet2 != null && (!(packet2 is CreateMissile) && !(packet2 is Relator3) && !(packet2 is Relator4) && !(packet2 is Relator5) && !(packet2 is Relator6) && !(packet2 is NPCUpdate) && !(packet2 is CurrentWaypoint) && !(packet2 is SummBook) && !(packet2 is Unk4a) && !(packet2 is RemoveItemsDisplay)) && !(packet2 is InformationMessage);
				if (flag11)
				{
					try
					{
						NetworkStream clientStream = this.ClientStream;
						if (clientStream != null)
						{
							clientStream.Write(packet2.ToArray());
						}
					}
					catch (ObjectDisposedException ex)
					{
						string[] array3 = new string[7];
						array3[0] = DateTime.Now.ToString();
						array3[1] = " : ";
						array3[2] = this.Email;
						array3[3] = " : ";
						int num5 = 4;
						Type type2 = this.lastP.GetType();
						array3[num5] = ((type2 != null) ? type2.ToString() : null);
						array3[5] = " : ";
						array3[6] = ex.Message;
						Console.WriteLine(string.Concat(array3));
						this.Terminate();
						break;
					}
				}
				this.lastP = packet2;
				list = list.Skip(num3).ToList<byte>();
			}
		}

		// Token: 0x0600B9E1 RID: 47585 RVA: 0x00463078 File Offset: 0x00461278
		private RunToLocation RunToLocation(RunToLocation run)
		{
			run.CurrentX = run.X;
			run.CurrentY = run.Y;
			run.ExtraPaths = 0;
			return run;
		}

		// Token: 0x0600B9E2 RID: 47586 RVA: 0x004630AC File Offset: 0x004612AC
		private RunToTarget RunToTarget(RunToTarget run)
		{
			run.CurrentX = this.me.X;
			run.CurrentY = this.me.Y;
			bool flag = this.GOs.ContainsKey(run.Id);
			if (flag)
			{
				run.ExtraPaths = 0;
			}
			this.rtt = run;
			return run;
		}

		// Token: 0x0600B9E3 RID: 47587 RVA: 0x00463108 File Offset: 0x00461308
		private WalkToLocation WalkToLocation(WalkToLocation run)
		{
			run.CurrentX = run.X;
			run.CurrentY = run.Y;
			run.ExtraPaths = 0;
			return run;
		}

		// Token: 0x0600B9E4 RID: 47588 RVA: 0x0046313C File Offset: 0x0046133C
		private WalkToTarget WalkToTarget(WalkToTarget run)
		{
			run.X = this.me.X;
			run.Y = this.me.Y;
			bool flag = this.GOs.ContainsKey(run.Id);
			if (flag)
			{
				run.ExtraPaths = 0;
			}
			return run;
		}

		// Token: 0x0600B9E5 RID: 47589 RVA: 0x00463190 File Offset: 0x00461390
		private CastLeftSkill RecastLeftSkill(RecastLeftSkill cast)
		{
			return new CastLeftSkill
			{
				X = cast.X,
				Y = cast.Y
			};
		}

		// Token: 0x0600B9E6 RID: 47590 RVA: 0x004631C4 File Offset: 0x004613C4
		private CastLeftSkillOnTarget RecastLeftSkillOnTarget(RecastLeftSkillOnTarget cast)
		{
			return new CastLeftSkillOnTarget
			{
				Type = cast.Type,
				Id = cast.Id
			};
		}

		// Token: 0x0600B9E7 RID: 47591 RVA: 0x004631F8 File Offset: 0x004613F8
		private CastLeftSkillOnTarget RecastLeftSkillOnTargetStopped(RecastLeftSkillOnTargetStopped cast)
		{
			return new CastLeftSkillOnTarget
			{
				Type = cast.Type,
				Id = cast.Id
			};
		}

		// Token: 0x0600B9E8 RID: 47592 RVA: 0x0046322C File Offset: 0x0046142C
		private CastLeftSkillOnTarget CastLeftSkillOnTargetStopped(CastLeftSkillOnTargetStopped cast)
		{
			return new CastLeftSkillOnTarget
			{
				Type = cast.Type,
				Id = cast.Id
			};
		}

		// Token: 0x0600B9E9 RID: 47593 RVA: 0x00463260 File Offset: 0x00461460
		private CastRightSkill RecastRightSkill(RecastRightSkill cast)
		{
			return new CastRightSkill
			{
				X = cast.X,
				Y = cast.Y
			};
		}

		// Token: 0x0600B9EA RID: 47594 RVA: 0x00463294 File Offset: 0x00461494
		private CastRightSkillOnTarget RecastRightSkillOnTarget(RecastRightSkillOnTarget cast)
		{
			return new CastRightSkillOnTarget
			{
				Type = cast.Type,
				Id = cast.Id
			};
		}

		// Token: 0x0600B9EB RID: 47595 RVA: 0x004632C8 File Offset: 0x004614C8
		private CastRightSkillOnTarget RecastRightSkillOnTargetStopped(RecastRightSkillOnTargetStopped cast)
		{
			return new CastRightSkillOnTarget
			{
				Type = cast.Type,
				Id = cast.Id
			};
		}

		// Token: 0x0600B9EC RID: 47596 RVA: 0x004632FC File Offset: 0x004614FC
		private CastRightSkill CastRightSkill(CastRightSkill cast)
		{
			return cast;
		}

		// Token: 0x0600B9ED RID: 47597 RVA: 0x00463310 File Offset: 0x00461510
		private CastRightSkillOnTarget CastRightSkillOnTargetStopped(CastRightSkillOnTargetStopped cast)
		{
			return new CastRightSkillOnTarget
			{
				Type = cast.Type,
				Id = cast.Id
			};
		}

		// Token: 0x0600B9EE RID: 47598 RVA: 0x00463344 File Offset: 0x00461544
		private UnitUseSkill UnitUseSkill(UnitUseSkill useSkill)
		{
			useSkill.X2 = useSkill.X;
			useSkill.Y2 = useSkill.Y;
			return useSkill;
		}

		// Token: 0x0600B9EF RID: 47599 RVA: 0x00463370 File Offset: 0x00461570
		private UnitUseSkillOnTarget UnitUseSkillOnTarget(UnitUseSkillOnTarget useSkill)
		{
			return useSkill;
		}

		// Token: 0x0600B9F0 RID: 47600 RVA: 0x00463384 File Offset: 0x00461584
		private GoToTownFolk GoToTownFolk(GoToTownFolk go)
		{
			return go;
		}

		// Token: 0x0600B9F1 RID: 47601 RVA: 0x00463398 File Offset: 0x00461598
		private DisplayQuestMessage DisplayQuestMessage(DisplayQuestMessage disp)
		{
			disp.MessageD2R = (ushort)disp.MessageLod;
			disp.UnitType = UnitType.NPC;
			bool flag = disp.Id == uint.MaxValue;
			if (flag)
			{
				disp.UnitType = UnitType.GameObject;
				disp.Id = this.GOs.Last((KeyValuePair<uint, AssignGameObject> o) => o.Value.ObjectId == GameObjectID.YetAnotherTome || o.Value.ObjectId == GameObjectID.FrozenAnya || o.Value.ObjectId == GameObjectID.AncientsAltar).Value.Id;
			}
			return disp;
		}

		// Token: 0x0600B9F2 RID: 47602 RVA: 0x00463414 File Offset: 0x00461614
		private TownFolkCancelInteraction TownFolkCancelInteraction(TownFolkCancelInteraction c)
		{
			List<KeyValuePair<uint, ItemAction>> list = this.GameInstance.Items.ToList<KeyValuePair<uint, ItemAction>>().FindAll((KeyValuePair<uint, ItemAction> i) => i.Value.action == ItemActionType.AddToShop);
			list.ForEach(delegate(KeyValuePair<uint, ItemAction> i)
			{
				ItemAction itemAction;
				this.GameInstance.Items.TryRemove(i.Key, out itemAction);
			});
			return c;
		}

		// Token: 0x0600B9F3 RID: 47603 RVA: 0x00463470 File Offset: 0x00461670
		private TownFolkMenuSelect TownFolkMenuSelect(TownFolkMenuSelect t)
		{
			this.Menu = t.Type;
			return t;
		}

		// Token: 0x0600B9F4 RID: 47604 RVA: 0x00463490 File Offset: 0x00461690
		private PickItem PickItem(PickItem p)
		{
			bool flag = p.Id == 0U;
			PickItem pickItem;
			if (flag)
			{
				pickItem = null;
			}
			else
			{
				p.X = (uint)this.GameInstance.Items[p.Id].x;
				p.Y = (uint)this.GameInstance.Items[p.Id].y;
				bool flag2 = p.ToLocation == global::D2Packets.Game.Client.PickItem.PickLocation.Cursor;
				if (flag2)
				{
					p.ToLocation = global::D2Packets.Game.Client.PickItem.PickLocation.Inventory;
				}
				else
				{
					bool flag3 = p.ToLocation == global::D2Packets.Game.Client.PickItem.PickLocation.Inventory;
					if (flag3)
					{
						p.ToLocation = global::D2Packets.Game.Client.PickItem.PickLocation.Cursor;
					}
				}
				pickItem = p;
			}
			return pickItem;
		}

		// Token: 0x0600B9F5 RID: 47605 RVA: 0x00463520 File Offset: 0x00461720
		private Packet PickItemFromContainer(PickItemFromContainer p)
		{
			bool flag = p.Container == global::D2Packets.Game.Client.PickItemFromContainer.ContainerType.Stash;
			if (flag)
			{
				ItemDb.DeleteItem(this.Email, this.CharacterName, this.GameInstance.Items[p.Id]);
			}
			p.X = (uint)this.GameInstance.Items[p.Id].x;
			p.Y = (uint)this.GameInstance.Items[p.Id].y;
			bool flag2 = this.GameInstance.Items[p.Id].container == ItemContainer.Stash;
			if (flag2)
			{
				p.Container = global::D2Packets.Game.Client.PickItemFromContainer.ContainerType.Stash;
			}
			else
			{
				bool flag3 = this.GameInstance.Items[p.Id].container == ItemContainer.Cube;
				if (flag3)
				{
					p.Container = global::D2Packets.Game.Client.PickItemFromContainer.ContainerType.Cube;
				}
				else
				{
					bool flag4 = this.GameInstance.Items[p.Id].container == ItemContainer.Inventory;
					if (flag4)
					{
						p.Container = global::D2Packets.Game.Client.PickItemFromContainer.ContainerType.Inventory;
					}
				}
			}
			bool flag5 = this.sharedStash == this.me.Id || p.Container != global::D2Packets.Game.Client.PickItemFromContainer.ContainerType.Stash;
			Packet packet;
			if (flag5)
			{
				packet = p;
			}
			else
			{
				packet = new PickItemFromSharedStash
				{
					ItemId = p.Id,
					SharedStashId = this.sharedStash,
					X = (ushort)p.X,
					Y = (ushort)p.Y
				};
			}
			return packet;
		}

		// Token: 0x0600B9F6 RID: 47606 RVA: 0x00463690 File Offset: 0x00461890
		private Packet DropItemToContainer(DropItemToContainer p)
		{
			bool flag = this.sharedStash == this.me.Id || p.Container != global::D2Packets.Game.Client.DropItemToContainer.ContainerType.Stash;
			Packet packet;
			if (flag)
			{
				packet = p;
			}
			else
			{
				packet = new WaypointTravelPutSharedStash
				{
					ItemId = p.Id,
					SharedStashId = this.sharedStash,
					X = (ushort)p.X,
					Y = (ushort)p.Y
				};
			}
			return packet;
		}

		// Token: 0x0600B9F7 RID: 47607 RVA: 0x00463704 File Offset: 0x00461904
		private UnequipItem UnequipItem(UnequipItem i)
		{
			i.Id = this.me.Equipment[i.Location].Id;
			return i;
		}

		// Token: 0x0600B9F8 RID: 47608 RVA: 0x00463738 File Offset: 0x00461938
		private void UsePot(int col)
		{
			UseItem useItem = new UseItem
			{
				ItemId = 0U,
				Consume = 1,
				PlayerId = this.me.Id,
				isMerc = 0,
				X = (byte)col,
				Y = 0,
				xff02ifbelt = 65282,
				PacketVersion = GameVersion.D2R
			};
			IEnumerable<ItemAction> enumerable = from i in this.GameInstance.Items.Values
				where i.container == ItemContainer.Belt || i.action == ItemActionType.PutInBelt || i.destination == ItemDestination.Belt
				where i.action != ItemActionType.RemoveFromBelt
				select i;
			List<ItemAction> list = (from p in enumerable
				where p.x % 4 == col
				orderby p.x
				select p).ToList<ItemAction>();
			bool flag = list.Count > 1;
			if (flag)
			{
				useItem.ItemId = list[0].Id;
			}
			for (int j = 0; j < list.Count - 1; j++)
			{
				useItem.Pots[j].Id = list[j + 1].Id;
				useItem.Pots[j].PrevPos = (byte)list[j + 1].x;
				useItem.Pots[j].NewPos = (byte)list[j].x;
			}
			this.ServerStream.Write(useItem.ToArray());
		}

		// Token: 0x0600B9F9 RID: 47609 RVA: 0x004638F0 File Offset: 0x00461AF0
		//private Packet SwapEquippedItem(SwapEquippedItem i)
		//{
		//	bool flag = this.GameInstance.Items[i.Id].baseItem.BaseType.Code == "belt";
		//	if (flag)
		//	{
		//		bool flag2 = false;
		//		for (int j = 0; j < 3; j++)
		//		{
		//			bool flag3 = flag2;
		//			if (flag3)
		//			{
		//				Thread.Sleep(150);
		//				flag2 = false;
		//			}
		//			int c2;
		//			int c;
		//			for (c = 0; c < 4; c = c2 + 1)
		//			{
		//				IEnumerable<ItemAction> enumerable = from i in this.GameInstance.Items.Values
		//					where i.container == ItemContainer.Belt || i.action == ItemActionType.PutInBelt || i.destination == ItemDestination.Belt
		//					where i.action != ItemActionType.RemoveFromBelt
		//					select i;
		//				List<ItemAction> list = (from p in enumerable
		//					where p.x % 4 == c
		//					orderby p.x
		//					select p).ToList<ItemAction>();
		//				bool flag4 = list.Count > 1;
		//				if (flag4)
		//				{
		//					this.UsePot(c);
		//					flag2 = true;
		//				}
		//				c2 = c;
		//			}
		//		}
		//	}
		//	i.EquippedId = this.me.Equipment[i.Location].Id;
		//	return i;
		//}

		// Token: 0x0600B9FA RID: 47610 RVA: 0x00463A88 File Offset: 0x00461C88
		private SwapTwoEquippedItems SwapTwoEquippedItems(SwapTwoEquippedItems i)
		{
			i.EquippedId = this.me.Equipment[i.Location].Id;
			EquipmentLocation equipmentLocation = ((i.Location == EquipmentLocation.RightHand) ? EquipmentLocation.LeftHand : EquipmentLocation.RightHand);
			i.PlaceToInventoryId = this.me.Equipment[equipmentLocation].Id;
			IEnumerable<ItemAction> enumerable = this.GameInstance.Items.Values.Where((ItemAction i) => i.action == ItemActionType.PutInContainer && i.container == ItemContainer.Inventory);
			this.FitTopLeftToBottomRight(this.me.Equipment[equipmentLocation], enumerable, 10, 4, true, ref i.X, ref i.Y);
			return i;
		}

		// Token: 0x0600B9FB RID: 47611 RVA: 0x00463B44 File Offset: 0x00461D44
		private SwitchWeapons SwitchWeapons(SwitchWeapons i)
		{
			i.LeftId1 = this.me.Equipment[this.me.WeaponSwitched ? EquipmentLocation.LeftHand : EquipmentLocation.LeftHandSwitch].Id;
			i.RightId1 = this.me.Equipment[this.me.WeaponSwitched ? EquipmentLocation.RightHand : EquipmentLocation.RightHandSwitch].Id;
			i.LeftId2 = this.me.Equipment[this.me.WeaponSwitched ? EquipmentLocation.LeftHandSwitch : EquipmentLocation.LeftHand].Id;
			i.RightId2 = this.me.Equipment[this.me.WeaponSwitched ? EquipmentLocation.RightHandSwitch : EquipmentLocation.RightHand].Id;
			i.LeftId2 = this.me.Equipment[EquipmentLocation.LeftHandSwitch].Id;
			i.RightId2 = this.me.Equipment[EquipmentLocation.RightHandSwitch].Id;
			i.LeftId1 = this.me.Equipment[EquipmentLocation.LeftHand].Id;
			i.RightId1 = this.me.Equipment[EquipmentLocation.RightHand].Id;
			i.RightSkill = (this.me.WeaponSwitched ? this.me.RightHandSkill : this.me.RightHandSkillSwap);
			i.RightSkill = (this.me.WeaponSwitched ? this.me.RightHandSkillSwap : this.me.RightHandSkill);
			i.RightSkill = this.me.RightHandSkill;
			i.LeftSkill = (this.me.WeaponSwitched ? this.me.LeftHandSkill : this.me.LeftHandSkillSwap);
			i.LeftSkill = (this.me.WeaponSwitched ? this.me.LeftHandSkillSwap : this.me.LeftHandSkill);
			i.LeftSkill = this.me.LeftHandSkill;
			i.SwapId = (this.me.WeaponSwitched ? 1 : 0);
			return i;
		}

		// Token: 0x0600B9FC RID: 47612 RVA: 0x00463D64 File Offset: 0x00461F64
		private SocketItem SocketItem(SocketItem s)
		{
			ItemAction itemAction = this.GameInstance.Items[s.ObjectId];
			s.X = (ushort)itemAction.x;
			s.Y = (ushort)itemAction.y;
			bool flag = itemAction.container == ItemContainer.Stash;
			if (flag)
			{
				s.ItemLocation = 4U;
			}
			bool flag2 = itemAction.location > EquipmentLocation.NotApplicable;
			if (flag2)
			{
				s.ItemLocation = 255U;
				s.EquipmentLocation = (uint)itemAction.location;
			}
			return s;
		}

		// Token: 0x0600B9FD RID: 47613 RVA: 0x00463DE4 File Offset: 0x00461FE4
		private StackItems StackItems(StackItems s)
		{
			ItemAction itemAction = this.GameInstance.Items[s.ObjectId];
			ItemAction itemAction2 = this.GameInstance.Items[s.SubjectId];
			s.X = (ushort)itemAction.x;
			s.Y = (ushort)itemAction.y;
			bool flag = ((SignedStat)itemAction[StatType.Quantity]).Value + ((SignedStat)itemAction2[StatType.Quantity]).Value <= 12;
			if (flag)
			{
				s.Consumed = 1U;
			}
			bool flag2 = itemAction.container == ItemContainer.Stash;
			if (flag2)
			{
				s.ItemLocation = 4U;
			}
			return s;
		}

		// Token: 0x0600B9FE RID: 47614 RVA: 0x00463E8C File Offset: 0x0046208C
		private TownFolkRepair TownFolkRepair(TownFolkRepair r)
		{
			bool flag = r.DealerId == 0U;
			TownFolkRepair townFolkRepair;
			if (flag)
			{
				this.repairCost = r.ItemId;
				townFolkRepair = null;
			}
			else
			{
				bool flag2 = this.me.Equipment[EquipmentLocation.Helm].Id != uint.MaxValue;
				if (flag2)
				{
				}
				r.Location = 4;
				r.ItemId = uint.MaxValue;
				r.Cost = this.repairCost;
				townFolkRepair = r;
			}
			return townFolkRepair;
		}

		// Token: 0x0600B9FF RID: 47615 RVA: 0x00463EFC File Offset: 0x004620FC
		private bool IsRepairable(ItemAction item)
		{
			bool flag = item[StatType.ChargedSkill] != null && ((ChargedSkillStat)item[StatType.ChargedSkill]).Charges < ((ChargedSkillStat)item[StatType.ChargedSkill]).MaxCharges;
			bool flag2;
			if (flag)
			{
				flag2 = true;
			}
			else
			{
				bool flag3 = item.flags.HasFlag(ItemFlags.Ethereal);
				if (flag3)
				{
					flag2 = false;
				}
				else
				{
					bool flag4 = item[StatType.Indesctructible] != null;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = item[StatType.MaxDurability] != null;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool noDurability = item.baseItem.NoDurability;
							if (noDurability)
							{
								flag2 = false;
							}
							else
							{
								bool flag6 = item[StatType.MaxDurability] == item[StatType.Durability];
								flag2 = !flag6;
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600BA00 RID: 47616 RVA: 0x00463FD4 File Offset: 0x004621D4
		private void CalculateAdditionalCostsForItemSkill(ItemAction item, ref int nSellCost, ref int nBuyCost, ref int nRepCost, int nDivisor)
		{
		}

		// Token: 0x0600BA01 RID: 47617 RVA: 0x00463FD8 File Offset: 0x004621D8
		private void CalculateAdditionalCostsForBonusStats(ItemAction item, ref int nSellCost, ref int nBuyCost, ref int nRepCost, int nDivisor)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			foreach (StatBase statBase in item.mods)
			{
				bool flag = statBase is SignedStat || statBase is UnsignedStat;
				if (flag)
				{
					int num4 = ((statBase is SignedStat) ? ((SignedStat)statBase).Value : ((int)((UnsignedStat)statBase).Value));
					BaseStat baseStat = statBase.BaseStat;
					bool flag2 = baseStat.Name == "Max Durability Percent";
					if (flag2)
					{
						baseStat = BaseStat.GetByName("Max Durability");
					}
					bool flag3 = baseStat.Name == "Defense Percent";
					if (flag3)
					{
						baseStat = BaseStat.GetByName("Armor Class");
					}
					bool flag4 = baseStat.Encode == 1;
					if (!flag4)
					{
						bool flag5 = num4 * nSellCost > 65535 && statBase.BaseStat.Multiply > 0;
						if (flag5)
						{
							num += baseStat.Add + baseStat.Multiply * num4 * nSellCost / 1024;
							num2 += baseStat.Add + baseStat.Multiply * num4 * nBuyCost / 1024;
							num3 += baseStat.Add + baseStat.Multiply * num4 * nRepCost / 1024;
						}
						else
						{
							num += baseStat.Add + num4 * baseStat.Multiply * nSellCost / 1024;
							num2 += baseStat.Add + num4 * baseStat.Multiply * nBuyCost / 1024;
							num3 += baseStat.Add + num4 * baseStat.Multiply * nRepCost / 1024;
						}
					}
				}
				string text = statBase.BaseStat.Name;
				string text2 = " : ";
				Type type = statBase.GetType();
				Console.WriteLine(text + text2 + ((type != null) ? type.ToString() : null));
			}
			nSellCost += num / nDivisor;
			nBuyCost += num2 / nDivisor;
			nRepCost += num3 / nDivisor;
		}

		// Token: 0x0600BA02 RID: 47618 RVA: 0x0046421C File Offset: 0x0046241C
		private int CalculateAdditionalCostsForChargedSkills(ItemAction item, int max)
		{
			return 0;
		}

		// Token: 0x0600BA03 RID: 47619 RVA: 0x00464230 File Offset: 0x00462430
		private BuyItem BuyItem(BuyItem i)
		{
			i.DealerIdD2R = i.DealerId;
			i.CostD2R = i.Cost;
			ItemAction itemAction = this.GameInstance.Items[i.ItemId];
			this.WriteLine(string.Concat(new string[]
			{
				"buying : ",
				itemAction.baseItem.Name,
				" : ",
				itemAction.x.ToString(),
				",",
				itemAction.y.ToString(),
				",",
				itemAction.container.ToString()
			}));
			i.VendorX = (ushort)itemAction.x;
			i.VendorY = (ushort)itemAction.y;
			i.VendorPage = (byte)(itemAction.container - ItemContainer.Inventory);
			IEnumerable<ItemAction> enumerable = this.GameInstance.Items.Values.Where((ItemAction i2) => i2.flags.HasFlag(ItemFlags.Gamble));
			IEnumerable<ItemAction> enumerable2 = from i2 in this.GameInstance.Items.Values
				where i2.container == ItemContainer.Belt || i2.action == ItemActionType.PutInBelt || i2.destination == ItemDestination.Belt
				where i2.action != ItemActionType.RemoveFromBelt
				select i2;
			ItemAction itemAction2 = this.me.Equipment[EquipmentLocation.Belt];
			int num = 1;
			bool flag = itemAction2.baseItem != null;
			if (flag)
			{
				num = 4;
				bool flag2 = itemAction2.baseItem.Type == ItemType.Sash || itemAction2.baseItem.Type == ItemType.LightBelt;
				if (flag2)
				{
					num = 2;
				}
				bool flag3 = itemAction2.baseItem.Type == ItemType.Belt || itemAction2.baseItem.Type == ItemType.HeavyBelt;
				if (flag3)
				{
					num = 3;
				}
			}
			List<string> list = new List<string> { "Heal", "Mana" };
			using (List<string>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					string potType = enumerator.Current;
					bool flag4 = itemAction.baseItem.Type.ToString().Contains(potType);
					if (flag4)
					{
						int num2;
						int x2;
						for (x2 = 0; x2 < 4; x2 = num2 + 1)
						{
							bool flag5 = enumerable2.Count((ItemAction p) => p.x == x2 && p.baseItem.ToString().Contains(potType)) > 0;
							if (flag5)
							{
								bool flag6 = enumerable2.Count((ItemAction p) => p.x % 4 == x2 % 4) < num;
								if (flag6)
								{
									i.X = (ushort)(enumerable2.Count((ItemAction p) => p.x % 4 == x2 % 4) * 4 + x2);
									i.Container = ItemDestination.Belt;
									bool flag7 = i.Flags == global::D2Packets.Game.Client.BuyItem.BuyFlags.FillStack;
									if (flag7)
									{
										i.Container = (ItemDestination)514;
									}
									return i;
								}
							}
							num2 = x2;
						}
						int x;
						for (x = 0; x < 4; x = num2 + 1)
						{
							bool flag8 = enumerable2.Count((ItemAction p) => p.x == x) == 0;
							if (flag8)
							{
								i.X = (ushort)x;
								i.Container = ItemDestination.Belt;
								bool flag9 = i.Flags == global::D2Packets.Game.Client.BuyItem.BuyFlags.FillStack;
								if (flag9)
								{
									i.Container = (ItemDestination)514;
								}
								return i;
							}
							num2 = x;
						}
					}
				}
			}
			IEnumerable<ItemAction> enumerable3 = this.GameInstance.Items.Values.Where((ItemAction i2) => (i2.action == ItemActionType.PutInContainer || i2.action == ItemActionType.UpdateStats) && i2.container == ItemContainer.Inventory);
			List<string> list2 = new List<string> { "Identify", "Portal" };
			using (List<string>.Enumerator enumerator2 = list2.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					string tomeType = enumerator2.Current;
					bool flag10 = itemAction.baseItem.Type.ToString().Contains(tomeType) && itemAction.baseItem.Type.ToString().Contains("Scroll");
					if (flag10)
					{
						IEnumerable<ItemAction> enumerable4 = enumerable3.Where((ItemAction t) => t.baseItem.Type.ToString().Contains(tomeType) && t.baseItem.Type.ToString().Contains("Tome"));
						bool flag11 = enumerable4.Count<ItemAction>() > 0;
						if (flag11)
						{
							i.Container = ItemDestination.Cursor;
							bool flag12 = i.Flags == global::D2Packets.Game.Client.BuyItem.BuyFlags.FillStack;
							if (flag12)
							{
								i.Container = (ItemDestination)516;
							}
							return i;
						}
					}
				}
			}
			bool flag13 = itemAction.baseItem is BaseArmor && (long)((BaseArmor)itemAction.baseItem).ReqStr <= (long)((ulong)this.me.Attributes[StatType.Strength]);
			if (flag13)
			{
				ItemAction itemAction3 = this.me.Equipment[EquipmentLocationHelper.GetEquipmentLocation(itemAction.baseItem.BaseType.BodyLoc1)];
				bool flag14 = itemAction3.baseItem == null;
				if (flag14)
				{
					i.X = (ushort)EquipmentLocationHelper.GetEquipmentLocation(itemAction.baseItem.BaseType.BodyLoc1);
					i.Container = ItemDestination.Equipment;
					return i;
				}
				itemAction3 = this.me.Equipment[EquipmentLocationHelper.GetEquipmentLocation(itemAction.baseItem.BaseType.BodyLoc2)];
				bool flag15 = itemAction3.baseItem == null;
				if (flag15)
				{
					i.X = (ushort)EquipmentLocationHelper.GetEquipmentLocation(itemAction.baseItem.BaseType.BodyLoc2);
					i.Container = ItemDestination.Equipment;
					return i;
				}
			}
			bool flag16 = i.Type == TradeType.GambleItem;
			if (flag16)
			{
				i.Type = TradeType.BuyItem;
				i.Container = (ItemDestination)256;
				bool flag17 = itemAction.baseItem.Type == ItemType.Amulet;
				int num3;
				if (flag17)
				{
					num3 = 63000;
				}
				else
				{
					bool flag18 = itemAction.baseItem.Type == ItemType.Ring;
					if (flag18)
					{
						num3 = 50000;
					}
					else
					{
						int num4 = Math.Max(1, 1);
						BaseItem byID = BaseItem.GetByID(((BaseArmor)itemAction.baseItem).ExceptionalID);
						BaseItem byID2 = BaseItem.GetByID(((BaseArmor)itemAction.baseItem).EliteID);
						uint num5 = this.me.Attributes[StatType.Level];
						long num6 = Math.Max((long)((100UL * ((ulong)num5 - (ulong)((long)byID.Level)) >> 1) + 1UL), 0L);
						long num7 = Math.Max((long)((100UL * ((ulong)num5 - (ulong)((long)byID2.Level)) >> 2) + 1UL), 0L);
						long num8 = num6 * (long)byID.Cost + num7 * (long)byID2.Cost + (long)(num4 * itemAction.baseItem.Cost) * (10000L - num6 - num7);
						num3 = (int)((float)((ulong)((2U * num5 + 1U) / 3U + 20U) * (ulong)(num8 / 10000L + (long)(250UL * ((ulong)num5 + (ulong)((long)((itemAction.baseItem.Level - 45 > 0) ? (itemAction.baseItem.Level - 45) : 0)) - (ulong)((long)(itemAction.baseItem.Level / 2))) / 3UL))) / 15f);
					}
				}
				bool flag19 = this.me.Attributes.ContainsKey(StatType.ReducedPrices);
				if (flag19)
				{
					i.Cost = (uint)((long)num3 * (long)((ulong)this.me.Attributes[StatType.ReducedPrices]) / 100L);
				}
				else
				{
					i.Cost = (uint)num3;
				}
			}
			bool flag20 = itemAction.baseItem.InvHeight == 1;
			if (flag20)
			{
				bool flag21 = this.FitBottomRightToTopLeft(itemAction, enumerable3, 10, 4, true, ref i.X, ref i.Y);
				if (flag21)
				{
					return i;
				}
			}
			bool flag22 = this.FitTopLeftToBottomRight(itemAction, enumerable3, 10, 4, true, ref i.X, ref i.Y);
			BuyItem buyItem;
			if (flag22)
			{
				buyItem = i;
			}
			else
			{
				buyItem = i;
			}
			return buyItem;
		}

		// Token: 0x0600BA04 RID: 47620 RVA: 0x00464AC8 File Offset: 0x00462CC8
		public bool AreIntersected(int x1, int y1, int w1, int h1, int x2, int y2, int w2, int h2)
		{
			return x2 < x1 + w1 && x1 < x2 + w2 && y2 < y1 + h1 && y1 < y2 + h2;
		}

		// Token: 0x0600BA05 RID: 47621 RVA: 0x00464AFC File Offset: 0x00462CFC
		private int GetPlacementWeight(IEnumerable<ItemAction> otherItems, ItemAction item, int proposedX, int proposedY, int gridWidth, int gridHeight)
		{
			int num = 0;
			bool flag = proposedX > 0;
			if (flag)
			{
				int num2;
				int y2;
				for (y2 = 0; y2 < item.baseItem.InvHeight; y2 = num2)
				{
					bool flag2 = otherItems.Any((ItemAction i) => this.AreIntersected(proposedX - 1, proposedY + y2, 1, 1, i.x, i.y, i.baseItem.InvWidth, i.baseItem.InvHeight));
					if (flag2)
					{
						num++;
					}
					num2 = y2 + 1;
				}
			}
			else
			{
				num += item.baseItem.InvHeight;
			}
			bool flag3 = proposedX + item.baseItem.InvWidth < gridWidth;
			if (flag3)
			{
				int num2;
				int y;
				for (y = 0; y < item.baseItem.InvHeight; y = num2)
				{
					bool flag4 = otherItems.Any((ItemAction i) => this.AreIntersected(proposedX + item.baseItem.InvWidth, proposedY + y, 1, 1, i.x, i.y, i.baseItem.InvWidth, i.baseItem.InvHeight));
					if (flag4)
					{
						num++;
					}
					num2 = y + 1;
				}
			}
			else
			{
				num += item.baseItem.InvHeight;
			}
			bool flag5 = proposedY > 0;
			if (flag5)
			{
				int num2;
				int x2;
				for (x2 = 0; x2 < item.baseItem.InvWidth; x2 = num2)
				{
					bool flag6 = otherItems.Any((ItemAction i) => this.AreIntersected(proposedX + x2, proposedY - 1, 1, 1, i.x, i.y, i.baseItem.InvWidth, i.baseItem.InvHeight));
					if (flag6)
					{
						num++;
					}
					num2 = x2 + 1;
				}
			}
			else
			{
				num += item.baseItem.InvWidth;
			}
			bool flag7 = proposedY + item.baseItem.InvHeight < gridHeight;
			if (flag7)
			{
				int num2;
				int x;
				for (x = 0; x < item.baseItem.InvWidth; x = num2)
				{
					bool flag8 = otherItems.Any((ItemAction i) => this.AreIntersected(proposedX + x, proposedY + item.baseItem.InvHeight, 1, 1, i.x, i.y, i.baseItem.InvWidth, i.baseItem.InvHeight));
					if (flag8)
					{
						num++;
					}
					num2 = x + 1;
				}
			}
			else
			{
				num += item.baseItem.InvWidth;
			}
			bool flag9 = num >= 2 * (item.baseItem.InvHeight + item.baseItem.InvWidth);
			if (flag9)
			{
				num = 255;
			}
			return num;
		}

        // Token: 0x0600BA06 RID: 47622 RVA: 0x00464DDC File Offset: 0x00462FDC
        private bool FitBottomRightToTopLeft(ItemAction item, IEnumerable<ItemAction> otherItems, int width, int height, bool weighted, ref ushort vendorX, ref ushort vendorY)
        {
            vendorX = 0;
            vendorY = 0;
            int maxWeight = 0;

            for (int x = width - item.baseItem.InvWidth; x >= 0; x--)
            {
                for (int y = height - item.baseItem.InvHeight; y >= 0; y--)
                {
                    if (otherItems.All(i => !AreIntersected(x, y, item.baseItem.InvWidth, item.baseItem.InvHeight, i.x, i.y, i.baseItem.InvWidth, i.baseItem.InvHeight)))
                    {
                        int placementWeight = GetPlacementWeight(otherItems, item, x, y, width, height);
                        if (placementWeight > maxWeight)
                        {
                            maxWeight = placementWeight;
                            vendorX = (ushort)x;
                            vendorY = (ushort)y;
                        }

                        if (placementWeight == 255 || !weighted)
                        {
                            return true;
                        }
                    }
                }
            }

            return maxWeight > 0;
        }

        // Token: 0x0600BA07 RID: 47623 RVA: 0x00464F4C File Offset: 0x0046314C
        private bool FitTopLeftToBottomRight(ItemAction item, IEnumerable<ItemAction> otherItems, int width, int height, bool weighted, ref ushort vendorX, ref ushort vendorY)
        {
            vendorX = 0;
            vendorY = 0;
            int maxWeight = 0;

            for (int x = 0; x <= width - item.baseItem.InvWidth; x++)
            {
                for (int y = 0; y <= height - item.baseItem.InvHeight; y++)
                {
                    if (otherItems.All(i => !AreIntersected(x, y, item.baseItem.InvWidth, item.baseItem.InvHeight, i.x, i.y, i.baseItem.InvWidth, i.baseItem.InvHeight)))
                    {
                        int placementWeight = GetPlacementWeight(otherItems, item, x, y, width, height);
                        if (placementWeight > maxWeight)
                        {
                            maxWeight = placementWeight;
                            vendorX = (ushort)x;
                            vendorY = (ushort)y;
                        }

                        if (placementWeight == 255 || !weighted)
                        {
                            return true;
                        }
                    }
                }
            }

            return maxWeight > 0;
        }

        // Token: 0x0600BA08 RID: 47624 RVA: 0x004650C0 File Offset: 0x004632C0
        private bool FitTopRightToBottomLeft(ItemAction item, IEnumerable<ItemAction> otherItems, int width, int height, bool weighted, ref ushort vendorX, ref ushort vendorY)
        {
            vendorX = 0;
            vendorY = 0;
            int maxWeight = 0;

            for (int x = width - item.baseItem.InvWidth; x >= 0; x--)
            {
                for (int y = 0; y <= height - item.baseItem.InvHeight; y++)
                {
                    if (otherItems.All(i => !AreIntersected(x, y, item.baseItem.InvWidth, item.baseItem.InvHeight, i.x, i.y, i.baseItem.InvWidth, i.baseItem.InvHeight)))
                    {
                        int placementWeight = GetPlacementWeight(otherItems, item, x, y, width, height);
                        if (placementWeight > maxWeight)
                        {
                            maxWeight = placementWeight;
                            vendorX = (ushort)x;
                            vendorY = (ushort)y;
                        }

                        if (placementWeight == 255 || !weighted)
                        {
                            return true;
                        }
                    }
                }
            }

            return maxWeight > 0;
        }

        // Token: 0x0600BA09 RID: 47625 RVA: 0x00465230 File Offset: 0x00463430
        private SellItem SellItem(SellItem i)
		{
			i.DealerIdD2R = i.DealerId;
			i.CostD2R = i.Cost;
			ItemAction itemAction = this.GameInstance.Items[i.ItemId];
			i.X = (ushort)itemAction.x;
			i.Y = (ushort)itemAction.y;
			IEnumerable<ItemAction> enumerable = this.GameInstance.Items.Values.Where((ItemAction i2) => i2.action == ItemActionType.AddToShop && i2.flags.HasFlag(ItemFlags.EquippedD2R));
			bool flag = this.GameInstance.Items.Values.Where((ItemAction i2) => i2.OwnerId == i.ItemId).Count<ItemAction>() > 0;
			bool flag2 = itemAction.baseItem.Type == ItemType.GrandCharm && itemAction.quality == ItemQuality.Unique;
			bool flag3 = this.GameInstance.Items.Values.Where((ItemAction i2) => i2.flags.HasFlag(ItemFlags.Gamble)).Count<ItemAction>() > 2;
			bool flag4 = this.Menu == TownFolkMenuItem.Gamble || itemAction.baseItem.Type.ToString().Contains("Healing") || itemAction.baseItem.Type.ToString().Contains("Mana") || itemAction.baseItem.Type.ToString().Contains("Stamina") || itemAction.baseItem.Type.ToString().Contains("Thawing") || itemAction.baseItem.Type.ToString().Contains("Antidote") || itemAction.baseItem.Type.ToString().Contains("TomeOf") || itemAction.baseItem.Type.ToString().Contains(" of ") || itemAction.baseItem.Type == ItemType.Key || flag || flag2 || flag3;
			bool flag5 = flag3;
			if (flag5)
			{
				i.Type = (ItemDestination)256;
			}
			bool flag6 = flag4 || itemAction.flags.HasFlag(ItemFlags.Ethereal) || (itemAction.quality == ItemQuality.Inferior && itemAction.prefix.Index != 1);
			if (!flag6)
			{
				bool flag7 = itemAction.baseItem is BaseMiscItem || itemAction.baseItem.Stackable;
				if (flag7)
				{
					IEnumerable<ItemAction> enumerable2 = this.GameInstance.Items.Values.Where((ItemAction i2) => i2.action == ItemActionType.AddToShop && (i2.baseItem is BaseMiscItem || i2.baseItem.Stackable));
					i.VendorPage = 3;
					bool flag8 = itemAction.baseItem.InvHeight == 1;
					if (flag8)
					{
						bool flag9 = this.FitTopRightToBottomLeft(itemAction, enumerable2, 10, 10, false, ref i.VendorX, ref i.VendorY);
						if (flag9)
						{
							return i;
						}
					}
					else
					{
						bool flag10 = this.FitTopLeftToBottomRight(itemAction, enumerable2, 10, 10, false, ref i.VendorX, ref i.VendorY);
						if (flag10)
						{
							return i;
						}
					}
				}
				else
				{
					bool flag11 = itemAction.baseItem is BaseWeapon;
					if (flag11)
					{
						IEnumerable<ItemAction> enumerable3 = this.GameInstance.Items.Values.Where((ItemAction i) => i.action == ItemActionType.AddToShop && i.baseItem is BaseWeapon);
						i.VendorPage = 1;
						IEnumerable<ItemAction> enumerable4 = enumerable3.Where((ItemAction w) => w.container == (int)i.VendorPage + ItemContainer.Inventory);
						bool flag12 = this.FitTopLeftToBottomRight(itemAction, enumerable4, 10, 10, false, ref i.VendorX, ref i.VendorY);
						if (flag12)
						{
							return i;
						}
						i.VendorPage = 2;
						IEnumerable<ItemAction> enumerable5 = enumerable3.Where((ItemAction w) => w.container == (int)i.VendorPage + ItemContainer.Inventory);
						bool flag13 = this.FitTopLeftToBottomRight(itemAction, enumerable4, 10, 10, false, ref i.VendorX, ref i.VendorY);
						if (flag13)
						{
							return i;
						}
					}
					else
					{
						bool flag14 = itemAction.baseItem is BaseArmor;
						if (flag14)
						{
							i.VendorPage = 0;
							IEnumerable<ItemAction> enumerable6 = this.GameInstance.Items.Values.Where((ItemAction i) => i.action == ItemActionType.AddToShop && i.baseItem is BaseArmor);
							bool flag15 = itemAction.baseItem.InvHeight == 1 && this.FitTopRightToBottomLeft(itemAction, enumerable6, 10, 10, false, ref i.VendorX, ref i.VendorY);
							if (flag15)
							{
								return i;
							}
							bool flag16 = this.FitTopLeftToBottomRight(itemAction, enumerable6, 10, 10, false, ref i.VendorX, ref i.VendorY);
							if (flag16)
							{
								return i;
							}
						}
					}
				}
			}
			i.VendorPage = byte.MaxValue;
			return i;
		}

		// Token: 0x0600BA0A RID: 47626 RVA: 0x004657FC File Offset: 0x004639FC
		private ChangeMercEquipment ChangeMercEquipment(ChangeMercEquipment i)
		{
			AssignMerc merc = this.Mercs.Values.Last((AssignMerc m) => m.OwnerId == this.me.Id);
			i.MercId = merc.Id;
			bool flag = i.Location == EquipmentLocation.NotApplicable;
			if (flag)
			{
				i.ItemId = this.GameInstance.MouseItem.Id;
				i.MouseId = uint.MaxValue;
				i.Location = EquipmentLocationHelper.GetEquipmentLocation(this.GameInstance.MouseItem.baseItem.BaseType.BodyLoc1);
			}
			else
			{
				bool flag2 = this.GameInstance.MouseItem != null;
				if (flag2)
				{
					i.ItemId = this.GameInstance.MouseItem.Id;
					KeyValuePair<uint, ItemAction> keyValuePair = this.GameInstance.Items.FirstOrDefault((KeyValuePair<uint, ItemAction> it) => it.Value.OwnerId == merc.Id && it.Value.OwnerType == UnitType.NPC && it.Value.location == i.Location);
					bool flag3 = keyValuePair.Value != null;
					if (flag3)
					{
						i.MouseId = keyValuePair.Key;
					}
					else
					{
						i.MouseId = uint.MaxValue;
					}
				}
				else
				{
					KeyValuePair<uint, ItemAction> keyValuePair2 = this.GameInstance.Items.FirstOrDefault((KeyValuePair<uint, ItemAction> it) => it.Value.OwnerId == merc.Id && it.Value.OwnerType == UnitType.NPC && it.Value.location == i.Location);
					bool flag4 = keyValuePair2.Value == null && i.Location == EquipmentLocation.RightHand;
					if (flag4)
					{
						keyValuePair2 = this.GameInstance.Items.FirstOrDefault((KeyValuePair<uint, ItemAction> it) => it.Value.OwnerId == merc.Id && it.Value.OwnerType == UnitType.NPC && it.Value.location == EquipmentLocation.LeftHand);
					}
					i.MouseId = keyValuePair2.Key;
					i.ItemId = uint.MaxValue;
				}
			}
			return i;
		}

		// Token: 0x0600BA0B RID: 47627 RVA: 0x004659C8 File Offset: 0x00463BC8
		private ItemToCube ItemToCube(ItemToCube i)
		{
			ItemAction itemAction = this.GameInstance.Items[i.CubeId];
			ItemAction itemAction2 = this.GameInstance.Items[i.ItemId];
			i.CubeX = (ushort)itemAction.x;
			i.CubeY = (ushort)itemAction.y;
			i.CubeLocation = 0U;
			bool flag = itemAction.container == ItemContainer.Stash;
			if (flag)
			{
				i.CubeLocation = 4U;
			}
			IEnumerable<ItemAction> enumerable = this.GameInstance.Items.Values.Where((ItemAction i) => i.action == ItemActionType.PutInContainer && i.container == ItemContainer.Cube);
			bool flag2 = itemAction2.baseItem.InvHeight == 1;
			if (flag2)
			{
				bool flag3 = this.FitBottomRightToTopLeft(itemAction2, enumerable, 3, 4, true, ref i.X, ref i.Y);
				if (flag3)
				{
					return i;
				}
			}
			bool flag4 = this.FitTopLeftToBottomRight(itemAction2, enumerable, 3, 4, true, ref i.X, ref i.Y);
			ItemToCube itemToCube;
			if (flag4)
			{
				itemToCube = i;
			}
			else
			{
				itemToCube = i;
			}
			return itemToCube;
		}

		// Token: 0x0600BA0C RID: 47628 RVA: 0x00465AD0 File Offset: 0x00463CD0
		private SwapBeltItem SwapBeltItem(SwapBeltItem i)
		{
			i.BeltPos = (uint)this.GameInstance.Items[i.NewId].x;
			return i;
		}

		// Token: 0x0600BA0D RID: 47629 RVA: 0x00465B04 File Offset: 0x00463D04
		private RemoveBeltItem RemoveBeltItem(RemoveBeltItem i)
		{
			i.BeltPos = (byte)this.GameInstance.Items[i.Id].x;
			return i;
		}

		// Token: 0x0600BA0E RID: 47630 RVA: 0x00465B3C File Offset: 0x00463D3C
		private Packet SwapContainerItem(SwapContainerItem i)
		{
			ItemAction itemAction = this.GameInstance.Items[i.ObjectId];
			bool flag = itemAction.container == ItemContainer.Stash;
			if (flag)
			{
				i.Container = global::D2Packets.Game.Client.SwapContainerItem.ContainerType.Stash;
			}
			bool flag2 = itemAction.container == ItemContainer.Cube;
			if (flag2)
			{
				i.Container = global::D2Packets.Game.Client.SwapContainerItem.ContainerType.Cube;
			}
			i.X1 = (ushort)itemAction.x;
			i.X1 = (i.X2 = (ushort)i.X);
			i.Y1 = (ushort)itemAction.y;
			i.Y1 = (i.Y2 = (ushort)i.Y);
			new SwapSharedStashItem().Bytes = i.ToArray();
			return i;
		}

		// Token: 0x0600BA0F RID: 47631 RVA: 0x00465BF0 File Offset: 0x00463DF0
		private PartyRequest PartyRequest(PartyRequest i)
		{
			bool flag = i.Action == global::D2Packets.Game.Client.PartyRequest.PartyAction.Invite;
			if (flag)
			{
				i.Action = global::D2Packets.Game.Client.PartyRequest.PartyAction.InviteD2R;
			}
			bool flag2 = i.Action == global::D2Packets.Game.Client.PartyRequest.PartyAction.AcceptInvite;
			if (flag2)
			{
				i.Action = global::D2Packets.Game.Client.PartyRequest.PartyAction.Invite;
			}
			bool flag3 = i.Action == global::D2Packets.Game.Client.PartyRequest.PartyAction.LeaveParty;
			if (flag3)
			{
				i.Action = global::D2Packets.Game.Client.PartyRequest.PartyAction.CancelInvite;
			}
			return i;
		}

		// Token: 0x0600BA10 RID: 47632 RVA: 0x00465C40 File Offset: 0x00463E40
		private HireMercenary HireMercenary(HireMercenary a)
		{
			MercForHire mercForHire = this.MercsForHire.First((MercForHire m) => m.Id == a.MercenaryId);
			Mercenary mercenary = new Mercenary(mercForHire.Seed, (uint)a.MercenaryId, (uint)this.Difficulty, (int)this.me.Attributes[StatType.Level]);
			a.Cost = (uint)mercenary.Cost;
			AssignMerc assignMerc = this.Mercs.Values.Last((AssignMerc m) => m.OwnerId == this.me.Id);
			a.ExistingMercId = assignMerc.Id;
			return a;
		}

		// Token: 0x0600BA11 RID: 47633 RVA: 0x00465CF4 File Offset: 0x00463EF4
		private ResurrectMerc ResurrectMerc(ResurrectMerc a)
		{
			a.Cost = this.MercReviveCost;
			a.NameId = this.MercNameId;
			return a;
		}

		// Token: 0x0600BA12 RID: 47634 RVA: 0x00465D20 File Offset: 0x00463F20
		private IncrementAttribute IncrementAttribute(IncrementAttribute a)
		{
			a.AmountD2R = (ushort)a.Amount;
			a.StatD2R = (StatType)a.Stat;
			return a;
		}

		// Token: 0x0600BA13 RID: 47635 RVA: 0x00465D4C File Offset: 0x00463F4C
		private InventoryItemToBelt InventoryItemToBelt(InventoryItemToBelt a)
		{
			ItemAction itemAction = this.GameInstance.Items[a.Id];
			a.InventoryX = (ushort)itemAction.x;
			a.InventoryY = (ushort)itemAction.y;
			IEnumerable<ItemAction> enumerable = from i in this.GameInstance.Items.Values
				where i.container == ItemContainer.Belt || i.action == ItemActionType.PutInBelt || i.destination == ItemDestination.Belt
				where i.action != ItemActionType.RemoveFromBelt
				select i;
			ItemAction itemAction2 = this.me.Equipment[EquipmentLocation.Belt];
			int num = 1;
			bool flag = itemAction2.baseItem != null && itemAction2.baseItem.BaseType.Code == "belt";
			if (flag)
			{
				num = 4;
				bool flag2 = itemAction2.baseItem.Type == ItemType.Sash || itemAction2.baseItem.Type == ItemType.LightBelt;
				if (flag2)
				{
					num = 2;
				}
				bool flag3 = itemAction2.baseItem.Type == ItemType.Belt || itemAction2.baseItem.Type == ItemType.HeavyBelt;
				if (flag3)
				{
					num = 3;
				}
			}
			List<string> list = new List<string> { "Heal", "Mana", "Rejuv" };
			using (List<string>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					string potType = enumerator.Current;
					bool flag4 = itemAction.baseItem.Type.ToString().Contains(potType);
					if (flag4)
					{
						int num2;
						int x2;
						for (x2 = 0; x2 < 4; x2 = num2 + 1)
						{
							bool flag5 = enumerable.Count((ItemAction p) => p.x == x2 && p.baseItem.ToString().Contains(potType)) > 0;
							if (flag5)
							{
								bool flag6 = enumerable.Count((ItemAction p) => p.x % 4 == x2 % 4) < num;
								if (flag6)
								{
									a.BeltPos = (uint)(enumerable.Count((ItemAction p) => p.x % 4 == x2 % 4) * 4 + x2);
									return a;
								}
							}
							num2 = x2;
						}
						int x;
						for (x = 0; x < 4; x = num2 + 1)
						{
							bool flag7 = enumerable.Count((ItemAction p) => p.x == x) == 0;
							if (flag7)
							{
								a.BeltPos = (uint)x;
								return a;
							}
							num2 = x;
						}
					}
				}
			}
			return a;
		}

		// Token: 0x0600BA14 RID: 47636 RVA: 0x00466058 File Offset: 0x00464258
		private UnitInteract UnitInteractBad(UnitInteract i)
		{
			return i;
		}

		// Token: 0x0600BA15 RID: 47637 RVA: 0x0046606C File Offset: 0x0046426C
		private void RemoveItem(ItemAction i)
		{
			ItemAction itemAction = new ItemAction
			{
				D2R_2_5 = i.D2R_2_5,
				Bytes = i.ToArray()
			};
			itemAction.OwnerId = this.me.Id;
			itemAction.action = ItemActionType.RemoveFromContainer;
			itemAction.flags |= ItemFlags.Destroyed;
			this.ClientStream.Write(itemAction.ToArray());
		}

		// Token: 0x0600BA16 RID: 47638 RVA: 0x004660D8 File Offset: 0x004642D8
		private void AddItem(ItemAction i)
		{
			ItemAction itemAction = new ItemAction
			{
				D2R_2_5 = i.D2R_2_5,
				Bytes = i.ToArray()
			};
			itemAction.OwnerId = this.me.Id;
			byte[] array = itemAction.ToArray();
			List<byte> list = array.Take(8).ToList<byte>();
			list.AddRange(array.Skip(13));
			list[0] = 156;
			List<byte> list2 = list;
			list2[2] = list2[2] - 5;
			WorldItemAction worldItemAction = new WorldItemAction
			{
				D2R_2_5 = itemAction.D2R_2_5,
				Bytes = list.ToArray()
			};
			this.ClientStream.Write(worldItemAction.ToArray());
		}

		// Token: 0x0600BA17 RID: 47639 RVA: 0x00466194 File Offset: 0x00464394
		private void SetStash(int stashIndex)
		{
			IEnumerable<ItemAction> enumerable = this.GameInstance.Items.Values.Where((ItemAction p) => p.container == ItemContainer.Stash && p.OwnerId == this.sharedStash);
			foreach (ItemAction itemAction in enumerable)
			{
				this.RemoveItem(itemAction);
			}
			List<Player> list = this.GameInstance.Players.Values.Where((Player p) => p.Name == this.me.Name && p.Id != this.me.Id).ToList<Player>();
			bool flag = stashIndex > list.Count<Player>();
			if (!flag)
			{
				bool flag2 = stashIndex == 0;
				if (flag2)
				{
					this.sharedStash = this.me.Id;
				}
				else
				{
					this.sharedStash = list[stashIndex - 1].Id;
				}
				bool flag3 = stashIndex == 1234;
				if (flag3)
				{
					IEnumerable<ItemAction> enumerable2 = this.GameInstance.Items.Values.Where((ItemAction p) => p.container == ItemContainer.Stash && p.OwnerId == this.sharedStash);
					Console.WriteLine(enumerable2.Count<ItemAction>());
					foreach (ItemAction itemAction2 in enumerable2)
					{
						this.AddItem(itemAction2);
					}
				}
				else
				{
					using (List<Player>.Enumerator enumerator3 = list.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							Player stash = enumerator3.Current;
							IEnumerable<ItemAction> enumerable3 = this.GameInstance.Items.Values.Where((ItemAction p) => p.container == ItemContainer.Stash && p.OwnerId == stash.Id);
							Console.WriteLine(enumerable3.Count<ItemAction>());
							bool flag4 = enumerable3.Count<ItemAction>() == 0;
							if (!flag4)
							{
								bool flag5 = enumerable3.Count<ItemAction>() == 100;
								if (!flag5)
								{
									this.sharedStash = stash.Id;
									foreach (ItemAction itemAction3 in enumerable3)
									{
										this.AddItem(itemAction3);
									}
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BA18 RID: 47640 RVA: 0x004663F0 File Offset: 0x004645F0
		private SendMessage SendMessage(SendMessage s)
		{
			bool flag = s.Message == "a1";
			if (flag)
			{
				SslStream serverStream = this.ServerStream;
				IdentifyGambleItemOrTravel identifyGambleItemOrTravel = new IdentifyGambleItemOrTravel();
				identifyGambleItemOrTravel.Id = this.GameInstance.NPCs.First((KeyValuePair<uint, AssignNPC> n) => n.Value.NpcType == NPCCode.Warriv).Key;
				identifyGambleItemOrTravel.AreaLevel = AreaLevel.LutGholein;
				identifyGambleItemOrTravel.PacketVersion = GameVersion.D2R;
				serverStream.Write(identifyGambleItemOrTravel.ToArray());
			}
			else
			{
				bool flag2 = s.Message == "a2";
				if (flag2)
				{
					SslStream serverStream2 = this.ServerStream;
					IdentifyGambleItemOrTravel identifyGambleItemOrTravel2 = new IdentifyGambleItemOrTravel();
					identifyGambleItemOrTravel2.Id = this.GameInstance.NPCs.First((KeyValuePair<uint, AssignNPC> n) => n.Value.NpcType == NPCCode.Meshif).Key;
					identifyGambleItemOrTravel2.AreaLevel = AreaLevel.KurastDocks;
					identifyGambleItemOrTravel2.PacketVersion = GameVersion.D2R;
					serverStream2.Write(identifyGambleItemOrTravel2.ToArray());
				}
				else
				{
					bool flag3 = s.Message == "a3a";
					if (flag3)
					{
						SslStream serverStream3 = this.ServerStream;
						IdentifyGambleItemOrTravel identifyGambleItemOrTravel3 = new IdentifyGambleItemOrTravel();
						identifyGambleItemOrTravel3.Id = this.GameInstance.NPCs.First((KeyValuePair<uint, AssignNPC> n) => n.Value.NpcType == NPCCode.Warriv).Key;
						identifyGambleItemOrTravel3.AreaLevel = AreaLevel.ThePandemoniumFortress;
						identifyGambleItemOrTravel3.PacketVersion = GameVersion.D2R;
						serverStream3.Write(identifyGambleItemOrTravel3.ToArray());
					}
					else
					{
						bool flag4 = s.Message == "a3b";
						if (flag4)
						{
							SslStream serverStream4 = this.ServerStream;
							WarpInteract warpInteract = new WarpInteract();
							warpInteract.Id = this.Warps.First((KeyValuePair<uint, AssignWarp> w) => w.Value.Warp == WarpType.Act3TravincalToMephisto).Key;
							warpInteract.PacketVersion = GameVersion.D2R;
							serverStream4.Write(warpInteract.ToArray());
						}
						else
						{
							bool flag5 = s.Message == "a4";
							if (flag5)
							{
								SslStream serverStream5 = this.ServerStream;
								IdentifyGambleItemOrTravel identifyGambleItemOrTravel4 = new IdentifyGambleItemOrTravel();
								identifyGambleItemOrTravel4.Id = this.GameInstance.NPCs.First((KeyValuePair<uint, AssignNPC> n) => n.Value.NpcType == NPCCode.Tyrael2).Key;
								identifyGambleItemOrTravel4.AreaLevel = AreaLevel.Harrogath;
								identifyGambleItemOrTravel4.PacketVersion = GameVersion.D2R;
								serverStream5.Write(identifyGambleItemOrTravel4.ToArray());
							}
							else
							{
								bool flag6 = s.Message == "tele";
								if (flag6)
								{
									this.ServerStream.Write(new WaypointInteract
									{
										Destination = AreaLevel.ColdPlains
									}.ToArray());
								}
								else
								{
									bool flag7 = s.Message == "t1a";
									if (flag7)
									{
										this.tguid1 = (uint)new Random().Next();
										KeyValuePair<uint, Player> keyValuePair = this.GameInstance.Players.First((KeyValuePair<uint, Player> i) => i.Value.Name.Contains("belt"));
										Trade trade = new Trade
										{
											Guid = this.tguid1,
											TargetId = keyValuePair.Value.Id
										};
										this.ServerStream.Write(trade.ToArray());
									}
									else
									{
										bool flag8 = s.Message == "t1b";
										if (flag8)
										{
											this.tguid2 = this.tguid1;
											KeyValuePair<uint, Player> keyValuePair2 = this.GameInstance.Players.First((KeyValuePair<uint, Player> i) => i.Value.Name.Contains("staff"));
											Trade trade2 = new Trade
											{
												Guid = this.tguid1,
												TargetId = keyValuePair2.Value.Id
											};
											this.ServerStream.Write(trade2.ToArray());
										}
										else
										{
											bool flag9 = s.Message == "t2a";
											if (flag9)
											{
												ItemAction itemAction = this.GameInstance.Items.Values.First((ItemAction i) => i.baseItem.Type == ItemType.ShortStaff && i.OwnerId == this.me.Id);
												KeyValuePair<uint, Player> keyValuePair3 = this.GameInstance.Players.First((KeyValuePair<uint, Player> i) => i.Value.Name.Contains("belt"));
												Trade trade3 = new Trade
												{
													Guid = this.tguid1,
													TargetId = keyValuePair3.Value.Id,
													ItemId = itemAction.Id
												};
												this.ServerStream.Write(trade3.ToArray());
											}
											else
											{
												bool flag10 = s.Message == "t2b";
												if (flag10)
												{
													ItemAction itemAction2 = this.GameInstance.Items.Values.First((ItemAction i) => i.baseItem.Type == ItemType.ShortStaff && i.OwnerId == this.me.Id);
													KeyValuePair<uint, Player> keyValuePair4 = this.GameInstance.Players.First((KeyValuePair<uint, Player> i) => i.Value.Name.Contains("staff"));
													Trade trade4 = new Trade
													{
														Guid = this.tguid2,
														TargetId = keyValuePair4.Value.Id,
														ItemId = itemAction2.Id
													};
													this.ServerStream.Write(trade4.ToArray());
												}
												else
												{
													bool flag11 = s.Message == "t2c";
													if (flag11)
													{
														ItemAction itemAction3 = this.GameInstance.Items.Values.First((ItemAction i) => i.baseItem.Type == ItemType.ShortStaff && i.OwnerId == this.me.Id);
														KeyValuePair<uint, Player> keyValuePair5 = this.GameInstance.Players.First((KeyValuePair<uint, Player> i) => i.Value.Name.Contains("belt"));
														KeyValuePair<uint, Player> keyValuePair6 = this.GameInstance.Players.First((KeyValuePair<uint, Player> i) => i.Value.Name.Contains("staff"));
														Trade trade5 = new Trade
														{
															Guid = this.tguid1,
															TargetId = keyValuePair5.Value.Id,
															ItemId = itemAction3.Id
														};
														Trade trade6 = new Trade
														{
															Guid = this.tguid2,
															TargetId = keyValuePair6.Value.Id,
															ItemId = itemAction3.Id
														};
														this.ServerStream.Write(trade5.ToArray().Concat(trade6.ToArray()).ToArray<byte>());
													}
													else
													{
														bool flag12 = s.Message == "t3a";
														if (flag12)
														{
															TradeConfirm tradeConfirm = new TradeConfirm
															{
																Guid = this.tguid1,
																ActionCount = 3U,
																Action = 1,
																Lenth = 10
															};
															this.ServerStream.Write(tradeConfirm.ToArray());
														}
														else
														{
															bool flag13 = s.Message == "t3aa";
															if (flag13)
															{
																TradeConfirm tradeConfirm2 = new TradeConfirm
																{
																	Guid = this.tguid1,
																	ActionCount = 4U,
																	Action = 1,
																	Lenth = 16,
																	ItemId = 2595394606U
																};
																this.ServerStream.Write(tradeConfirm2.ToArray());
															}
															else
															{
																bool flag14 = s.Message == "t3b";
																if (flag14)
																{
																	TradeConfirm tradeConfirm3 = new TradeConfirm
																	{
																		Guid = this.tguid2,
																		ActionCount = 3U,
																		Action = 1,
																		Lenth = 10
																	};
																	this.ServerStream.Write(tradeConfirm3.ToArray());
																}
																else
																{
																	bool flag15 = s.Message == "t4";
																	if (flag15)
																	{
																		ItemAction itemAction4 = this.GameInstance.Items.Values.First((ItemAction i) => i.baseItem.Type == ItemType.ShortStaff && i.OwnerId == this.me.Id);
																		KeyValuePair<uint, Player> keyValuePair7 = this.GameInstance.Players.First((KeyValuePair<uint, Player> i) => i.Value.Name.Contains("belt"));
																		Trade trade7 = new Trade
																		{
																			Guid = this.tguid1,
																			TargetId = keyValuePair7.Value.Id,
																			ItemId = itemAction4.Id
																		};
																		this.ServerStream.Write(trade7.ToArray());
																		TradeConfirm tradeConfirm4 = new TradeConfirm
																		{
																			Guid = this.tguid1,
																			ActionCount = 3U,
																			Action = 1,
																			Lenth = 10
																		};
																		this.ServerStream.Write(tradeConfirm4.ToArray());
																	}
																	else
																	{
																		bool flag16 = s.Message == "putstash";
																		if (flag16)
																		{
																			ItemAction itemAction5 = this.GameInstance.Items.Values.First((ItemAction i) => i.baseItem.Type == ItemType.ShortStaff && i.OwnerId == this.me.Id);
																			SwitchItemStashInventory switchItemStashInventory = new SwitchItemStashInventory
																			{
																				ItemId = itemAction5.Id,
																				DestContainer = 4U
																			};
																			this.ServerStream.Write(switchItemStashInventory.ToArray());
																		}
																		else
																		{
																			bool flag17 = s.Message == "drop";
																			if (flag17)
																			{
																				ItemAction itemAction6 = this.GameInstance.Items.Values.First((ItemAction i) => i.baseItem.Type == ItemType.ShortStaff && i.OwnerId == this.me.Id);
																				DropItemFromContainer dropItemFromContainer = new DropItemFromContainer
																				{
																					ItemId = itemAction6.Id,
																					Container = DropItemFromContainer.ContainerType.Inventory,
																					X = (ushort)itemAction6.x,
																					Y = (ushort)itemAction6.y
																				};
																				this.ServerStream.Write(dropItemFromContainer.ToArray());
																			}
																			else
																			{
																				bool flag18 = s.Message == "t4";
																				if (flag18)
																				{
																					uint num = (uint)new Random().Next();
																					ItemAction itemAction7 = this.GameInstance.Items.Values.First((ItemAction i) => i.baseItem.Type == ItemType.ShortStaff && i.OwnerId == this.me.Id);
																					KeyValuePair<uint, Player> keyValuePair8 = this.GameInstance.Players.First((KeyValuePair<uint, Player> i) => i.Value.Name.Contains("belt"));
																					TradeConfirm tc = new TradeConfirm
																					{
																						Guid = num,
																						ActionCount = 3U,
																						Action = 1,
																						Lenth = 10
																					};
																					Trade trade8 = new Trade
																					{
																						Guid = num,
																						TargetId = keyValuePair8.Value.Id,
																						ItemId = itemAction7.Id
																					};
																					WaypointInteract waypointInteract = new WaypointInteract();
																					waypointInteract.Destination = AreaLevel.ColdPlains;
																					waypointInteract.PacketVersion = GameVersion.D2R;
																					RunToLocation runToLocation = new RunToLocation();
																					runToLocation.CurrentX = this.me.X;
																					runToLocation.CurrentY = this.me.Y;
																					runToLocation.X = this.me.X + 5;
																					runToLocation.Y = this.me.Y + 5;
																					runToLocation.ExtraPaths = 254;
																					RunToTarget runToTarget = new RunToTarget();
																					runToTarget.CurrentX = this.me.X;
																					runToTarget.CurrentY = this.me.Y;
																					runToTarget.Id = this.me.Id;
																					runToTarget.ExtraPaths = 254;
																					SortContainer sortContainer = new SortContainer();
																					sortContainer.Container = SortContainer.ContainerType.Inventory;
																					sortContainer.ContainerId = 0U;
																					sortContainer.NumExtra = 254;
																					sortContainer.Items = new List<SortContainer.ItemSort>();
																					EquipSmallBelt equipSmallBelt = new EquipSmallBelt();
																					equipSmallBelt.NumPots = 0;
																					equipSmallBelt.Pots = new List<EquipSmallBelt.PotLocation>();
																					equipSmallBelt.LastPot = new EquipSmallBelt.PotLocation();
																					this.ServerStream.Write(trade8.ToArray());
																					Task.Run(delegate
																					{
																						Thread.Sleep(5000);
																						this.ServerStream.Write(tc.ToArray());
																					});
																				}
																				else
																				{
																					bool flag19 = s.Message == "crash";
																					if (flag19)
																					{
																						byte[] array = new SendOverheadMessage
																						{
																							PacketVersion = GameVersion.LOD,
																							Message = "test message"
																						}.ToArray();
																						array[0] = 21;
																						uint num2 = (uint)new Random().Next();
																						ItemAction itemAction8 = this.GameInstance.Items.Values.First((ItemAction i) => i.baseItem.Type == ItemType.ShortStaff && i.OwnerId == this.me.Id);
																						KeyValuePair<uint, Player> keyValuePair9 = this.GameInstance.Players.First((KeyValuePair<uint, Player> i) => i.Value.Name.Contains("belt"));
																						TradeConfirm tradeConfirm5 = new TradeConfirm();
																						tradeConfirm5.Guid = num2;
																						tradeConfirm5.ActionCount = 3U;
																						tradeConfirm5.Action = 1;
																						tradeConfirm5.Lenth = 10;
																						Trade trade9 = new Trade();
																						trade9.Guid = num2;
																						trade9.TargetId = keyValuePair9.Value.Id;
																						trade9.ItemId = itemAction8.Id;
																						WaypointInteract waypointInteract2 = new WaypointInteract();
																						waypointInteract2.Destination = AreaLevel.ColdPlains;
																						waypointInteract2.PacketVersion = GameVersion.D2R;
																						RunToLocation runToLocation2 = new RunToLocation();
																						runToLocation2.CurrentX = this.me.X;
																						runToLocation2.CurrentY = this.me.Y;
																						runToLocation2.X = this.me.X + 5;
																						runToLocation2.Y = this.me.Y + 5;
																						runToLocation2.ExtraPaths = 254;
																						RunToTarget runToTarget2 = new RunToTarget();
																						runToTarget2.CurrentX = this.me.X;
																						runToTarget2.CurrentY = this.me.Y;
																						runToTarget2.Id = this.me.Id;
																						runToTarget2.ExtraPaths = 254;
																						new TradeConfirm().Lenth = 254;
																						SortContainer sortContainer2 = new SortContainer();
																						sortContainer2.Container = SortContainer.ContainerType.Inventory;
																						sortContainer2.ContainerId = 0U;
																						sortContainer2.NumExtra = 254;
																						sortContainer2.Items = new List<SortContainer.ItemSort>();
																						EquipSmallBelt equipSmallBelt2 = new EquipSmallBelt();
																						equipSmallBelt2.NumPots = 0;
																						equipSmallBelt2.Pots = new List<EquipSmallBelt.PotLocation>();
																						equipSmallBelt2.LastPot = new EquipSmallBelt.PotLocation();
																						this.ServerStream.Write(array);
																					}
																					else
																					{
																						try
																						{
																							int num3 = int.Parse(s.Message);
																							this.SetStash(num3);
																						}
																						catch
																						{
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return null;
		}

		// Token: 0x0600BA19 RID: 47641 RVA: 0x004671DC File Offset: 0x004653DC
		private RemoveItemsDisplay RemoveItemsDisplay(RemoveItemsDisplay f)
		{
			return null;
		}

		// Token: 0x0600BA1A RID: 47642 RVA: 0x004671F0 File Offset: 0x004653F0
		private GameLogonReceipt GameLogonReceipt(GameLogonReceipt g)
		{
			this.Difficulty = g.Difficulty;
			g.Ladder = 1;
			g.Ladder = byte.MaxValue;
			return g;
		}

		// Token: 0x0600BA1B RID: 47643 RVA: 0x00467224 File Offset: 0x00465424
		private SwitchWeaponSet SwitchWeaponSet(SwitchWeaponSet s)
		{
			this.me.WeaponSwitched = !this.me.WeaponSwitched;
			return s;
		}

		// Token: 0x0600BA1C RID: 47644 RVA: 0x00467250 File Offset: 0x00465450
		private AssignSkill AssignSkill(AssignSkill s)
		{
			bool flag = s.Hand == SkillHand.Left;
			if (flag)
			{
				this.me.LeftHandSkill = s.Skill;
			}
			bool flag2 = s.Hand == SkillHand.Right;
			if (flag2)
			{
				this.me.RightHandSkill = s.Skill;
			}
			return s;
		}

		// Token: 0x0600BA1D RID: 47645 RVA: 0x004672A0 File Offset: 0x004654A0
		private ReportKill ReportKill(ReportKill r)
		{
			bool flag = this.GameInstance.NPCs.ContainsKey(r.Id) && this.GameInstance.NPCs[r.Id].NpcType != NPCCode.Invalid;
			if (flag)
			{
				this.lastNPCDead = this.GameInstance.NPCs[r.Id].NpcType;
			}
			return r;
		}

		// Token: 0x0600BA1E RID: 47646 RVA: 0x00467318 File Offset: 0x00465518
		private NPCGetHit NPCGetHit(NPCGetHit n)
		{
			bool flag = this.GameInstance.NPCs.ContainsKey(n.Id) && this.GameInstance.NPCs[n.Id].NpcType != NPCCode.Invalid;
			if (flag)
			{
				this.lastNPCDead = this.GameInstance.NPCs[n.Id].NpcType;
			}
			bool flag2 = this.GameInstance.NPCs.ContainsKey(n.Id);
			NPCGetHit npcgetHit;
			if (flag2)
			{
				bool flag3 = this.GameInstance.NPCs[n.Id].NpcType.ToString().Contains("Tentacle");
				if (flag3)
				{
					npcgetHit = null;
				}
				else
				{
					npcgetHit = n;
				}
			}
			else
			{
				npcgetHit = null;
			}
			return npcgetHit;
		}

		// Token: 0x0600BA1F RID: 47647 RVA: 0x004673E8 File Offset: 0x004655E8
		private NPCAction NPCAction(NPCAction n)
		{
			bool flag = this.GameInstance.NPCs.ContainsKey(n.Id);
			NPCAction npcaction;
			if (flag)
			{
				bool flag2 = this.GameInstance.NPCs[n.Id].NpcType.ToString().Contains("Tentacle");
				if (flag2)
				{
					npcaction = null;
				}
				else
				{
					npcaction = n;
				}
			}
			else
			{
				npcaction = null;
			}
			return npcaction;
		}

		// Token: 0x0600BA20 RID: 47648 RVA: 0x00467454 File Offset: 0x00465654
		private Packet SetState(SetState n)
		{
			bool flag = this.GameInstance.NPCs.ContainsKey(n.Id) && this.GameInstance.NPCs[n.Id].NpcType != NPCCode.Invalid;
			if (flag)
			{
				this.lastNPCDead = this.GameInstance.NPCs[n.Id].NpcType;
			}
			bool flag2 = this.GameInstance.NPCs.ContainsKey(n.Id);
			Packet packet;
			if (flag2)
			{
				bool flag3 = this.GameInstance.NPCs[n.Id].NpcType.ToString().Contains("Tentacle");
				if (flag3)
				{
					packet = null;
				}
				else
				{
					packet = n;
				}
			}
			else
			{
				packet = n;
			}
			return packet;
		}

		// Token: 0x0600BA21 RID: 47649 RVA: 0x00467528 File Offset: 0x00465728
		private Packet DelayedState(DelayedState n)
		{
			n.StateLOD = (byte)n.StateD2R;
			return n;
		}

		// Token: 0x0600BA22 RID: 47650 RVA: 0x00467548 File Offset: 0x00465748
		private Packet EndState(EndState n)
		{
			n.StateLOD = (byte)n.StateD2R;
			bool flag = n.StateLOD == 185;
			Packet packet;
			if (flag)
			{
				packet = null;
			}
			else
			{
				packet = n;
			}
			return packet;
		}

		// Token: 0x0600BA23 RID: 47651 RVA: 0x00467580 File Offset: 0x00465780
		private NPCMove NPCMove(NPCMove item)
		{
			return item;
		}

		// Token: 0x0600BA24 RID: 47652 RVA: 0x00467594 File Offset: 0x00465794
		private NPCStop NPCStop(NPCStop n)
		{
			bool flag = this.GameInstance.NPCs.ContainsKey(n.Id);
			NPCStop npcstop;
			if (flag)
			{
				bool flag2 = this.GameInstance.NPCs[n.Id].NpcType.ToString().Contains("Tentacle");
				if (flag2)
				{
					npcstop = null;
				}
				else
				{
					npcstop = n;
				}
			}
			else
			{
				npcstop = n;
			}
			return npcstop;
		}

		// Token: 0x0600BA25 RID: 47653 RVA: 0x00467600 File Offset: 0x00465800
		private NPCMoveToTarget NPCMoveToTarget(NPCMoveToTarget item)
		{
			return item;
		}

		// Token: 0x0600BA26 RID: 47654 RVA: 0x00467614 File Offset: 0x00465814
		private AssignMerc AssignMerc(AssignMerc merc)
		{
			this.Mercs[merc.Id] = merc;
			return merc;
		}

		// Token: 0x0600BA27 RID: 47655 RVA: 0x0046763C File Offset: 0x0046583C
		private AssignGameObject AssignGameObject(AssignGameObject go)
		{
			this.GOs[go.Id] = go;
			return go;
		}

		// Token: 0x0600BA28 RID: 47656 RVA: 0x00467664 File Offset: 0x00465864
		private AssignWarp AssignWarp(AssignWarp warp)
		{
			this.Warps[warp.Id] = warp;
			return warp;
		}

		// Token: 0x0600BA29 RID: 47657 RVA: 0x0046768C File Offset: 0x0046588C
		private SetGameObjectMode SetGameObjectMode(SetGameObjectMode s)
		{
			bool flag = this.GOs.ContainsKey(s.Id);
			if (flag)
			{
				this.GOs[s.Id].Mode = s.Mode;
			}
			return s;
		}

		// Token: 0x0600BA2A RID: 47658 RVA: 0x004676D0 File Offset: 0x004658D0
		private RemoveGroundUnit RemoveGroundUnit(RemoveGroundUnit go)
		{
			return go;
		}

		// Token: 0x0600BA2B RID: 47659 RVA: 0x004676E4 File Offset: 0x004658E4
		private OpenWaypoint OpenWaypoint(OpenWaypoint go)
		{
			go.WaypointsUnlocked |= WaypointsAvailable.ThePandemoniumFortress;
			go.WaypointId = this.waypointId;
			return go;
		}

		// Token: 0x0600BA2C RID: 47660 RVA: 0x00467718 File Offset: 0x00465918
		private SkillsLog SkillsLog(SkillsLog go)
		{
			return go;
		}

		// Token: 0x0600BA2D RID: 47661 RVA: 0x0046772C File Offset: 0x0046592C
		private PlayerReassign PlayerReassign(PlayerReassign p)
		{
			this.me.X = p.X;
			this.me.Y = p.Y;
			return p;
		}

		// Token: 0x0600BA2E RID: 47662 RVA: 0x00467764 File Offset: 0x00465964
		private PlayerLifeManaChangeRegen PlayerLifeManaChangeRegen(PlayerLifeManaChangeRegen p)
		{
			this.me.X = p.X;
			this.me.Y = p.Y;
			return p;
		}

		// Token: 0x0600BA2F RID: 47663 RVA: 0x0046779C File Offset: 0x0046599C
		private PlayerLifeManaChange PlayerLifeManaChange(PlayerLifeManaChange p)
		{
			this.me.X = p.X;
			this.me.Y = p.Y;
			return p;
		}

		// Token: 0x0600BA30 RID: 47664 RVA: 0x004677D4 File Offset: 0x004659D4
		private PlayerAttributeNotification PlayerAttributeNotification(PlayerAttributeNotification p)
		{
			p.AttribLOD = (byte)p.AttribD2R;
			return p;
		}

		// Token: 0x0600BA31 RID: 47665 RVA: 0x004677F4 File Offset: 0x004659F4
		private PlayerInGame PlayerInGame(PlayerInGame go)
		{
			go.Len -= 61;
			return go;
		}

		// Token: 0x0600BA32 RID: 47666 RVA: 0x00467818 File Offset: 0x00465A18
		private ItemAction OwnedItemAction(OwnedItemAction p)
		{
			bool flag = p.action == ItemActionType.PutInContainer || p.action == ItemActionType.Equip;
			if (flag)
			{
				ItemDb.AddItem(this.Email, this.CharacterName, p);
			}
			bool flag2 = p.action == ItemActionType.RemoveFromContainer;
			if (flag2)
			{
				ItemDb.DeleteItem(this.Email, this.CharacterName, this.GameInstance.Items[p.Id]);
			}
			List<ItemAction> list = this.GameInstance.Items.Values.Where((ItemAction i) => i.Id == p.Id).ToList<ItemAction>();
			bool flag3 = this.me.Attributes.ContainsKey(StatType.Level);
			if (flag3)
			{
				p.level = (ushort)this.me.Attributes[StatType.Level];
			}
			bool flag4 = p.action == ItemActionType.ToCursor;
			if (flag4)
			{
				p.action = ItemActionType.ItemInSocket;
			}
			else
			{
				bool flag5 = p.action == ItemActionType.UNKNOWNx14;
				if (flag5)
				{
					p.action = ItemActionType.UpdateStats;
				}
				else
				{
					bool flag6 = p.action == ItemActionType.UNKNOWNx16;
					if (flag6)
					{
						p.action = ItemActionType.WeaponSwitch;
					}
					else
					{
						bool flag7 = p.action == ItemActionType.SwapInBelt;
						if (flag7)
						{
							p.action = ItemActionType.AutoUnequip;
						}
					}
				}
			}
			bool flag8 = (p.flags & ItemFlags.EquippedD2R) == ItemFlags.EquippedD2R;
			if (flag8)
			{
				p.flags |= ItemFlags.Equipped;
				p.flags &= ~ItemFlags.EquippedD2R;
			}
			this.GameInstance.Items[p.Id] = p;
			bool flag9 = this.GameInstance.Players.ContainsKey(p.OwnerId);
			if (flag9)
			{
				this.GameInstance.Players[p.OwnerId].Equipment.Values.Where((ItemAction e) => e.Id == p.Id).ToList<ItemAction>().ForEach(delegate(ItemAction e)
				{
					this.GameInstance.Players[p.OwnerId].Equipment[e.location] = new ItemAction
					{
						Id = uint.MaxValue
					};
				});
			}
			bool flag10 = !p.flags.HasFlag(ItemFlags.InSocket) && this.GameInstance.Players.ContainsKey(p.OwnerId) && p.OwnerType == UnitType.Player && p.action != ItemActionType.Unequip;
			if (flag10)
			{
				this.GameInstance.Players[p.OwnerId].Equipment[p.location] = p;
			}
			ItemAction itemAction = this.GameInstance.Items[p.Id];
			bool flag11 = p.action == ItemActionType.PutInContainer;
			ItemAction itemAction2;
			if (flag11)
			{
				bool flag12 = p.OwnerId != this.me.Id;
				if (flag12)
				{
					bool flag13 = p.OwnerId == this.sharedStash;
					if (flag13)
					{
						this.AddItem(p);
					}
					itemAction2 = null;
				}
				else
				{
					byte[] array = p.ToArray();
					OwnedItemAction ownedItemAction = new OwnedItemAction();
					ownedItemAction.D2R_2_5 = true;
					ownedItemAction.Bytes = array;
					List<byte> list2 = array.Take(8).ToList<byte>();
					list2.AddRange(array.Skip(13));
					list2[0] = 156;
					List<byte> list3 = list2;
					list3[2] = list3[2] - 5;
					WorldItemAction worldItemAction = new WorldItemAction
					{
						D2R_2_5 = true,
						Bytes = list2.ToArray()
					};
					worldItemAction.D2R_2_5 = false;
					itemAction2 = worldItemAction;
				}
			}
			else
			{
				p.D2R_2_5 = false;
				itemAction2 = p;
			}
			return itemAction2;
		}

		// Token: 0x0600BA33 RID: 47667 RVA: 0x00467C44 File Offset: 0x00465E44
		private ItemAction WorldItemAction(WorldItemAction p)
		{
			p.D2R_2_5 = false;
			bool flag = p.action == ItemActionType.AddToGround || p.action == ItemActionType.DropToGround;
			if (flag)
			{
				bool flag2 = p.baseItem.Type >= ItemType.VexRune && p.baseItem.Type <= ItemType.ZodRune;
				if (flag2)
				{
					WebManager.PostDiscord(string.Concat(new string[]
					{
						this.Email,
						" : ",
						p.ToString(),
						" dropped from ",
						this.lastNPCDead.ToString().Replace("Guard", "Cow"),
						" : ip ",
						GameProxy.GameAccountLink[this.hash].ipAddr
					}));
				}
			}
			p.level = (ushort)this.me.Attributes[StatType.Level];
			bool flag3 = p.action == ItemActionType.AutoUnequip;
			if (flag3)
			{
				p.action = ItemActionType.ToCursor;
				bool flag4 = !this.GameInstance.Items.ContainsKey(p.Id);
				if (flag4)
				{
					this.ServerStream.Write(new DropItem
					{
						Id = p.Id
					}.ToArray());
				}
			}
			bool flag5 = p.action == ItemActionType.PutInBelt;
			if (flag5)
			{
				p.action = ItemActionType.RemoveFromBelt;
			}
			bool flag6 = p.action == ItemActionType.SwapInContainer;
			if (flag6)
			{
				p.action = ItemActionType.PutInBelt;
			}
			bool flag7 = this.GameInstance.Items.ContainsKey(p.Id);
			if (flag7)
			{
				this.GameInstance.Items[p.Id] = p;
			}
			else
			{
				this.GameInstance.Items[p.Id] = p;
			}
			return p;
		}

		// Token: 0x0600BA34 RID: 47668 RVA: 0x00467E10 File Offset: 0x00466010
		private AssignPlayer AssignPlayer(AssignPlayer player)
		{
			bool flag = this.myId == 0U;
			if (flag)
			{
				this.sharedStash = (this.myId = player.Id);
			}
			this.AddPlayerToList(new Player
			{
				Id = player.Id,
				Name = player.Name,
				Class = player.Class,
				X = player.X,
				Y = player.Y
			});
			return player;
		}

		// Token: 0x0600BA35 RID: 47669 RVA: 0x00467E90 File Offset: 0x00466090
		private AssignNPC AssignNPC(AssignNPC npc)
		{
			bool flag = npc.orig[12] == 19;
			if (flag)
			{
				npc.orig = npc.orig.Take(14).ToArray<byte>();
				npc.orig[12] = 14;
				npc.orig[13] = 9;
				npc.orig[13] = 1;
			}
			this.GameInstance.NPCs[npc.Id] = npc;
			return npc;
		}

		// Token: 0x0600BA36 RID: 47670 RVA: 0x00467F08 File Offset: 0x00466108
		private WalkVerify WalkVerify(WalkVerify w)
		{
			this.me.X = w.X;
			this.me.Y = w.Y;
			return w;
		}

		// Token: 0x0600BA37 RID: 47671 RVA: 0x00467F40 File Offset: 0x00466140
		private PortalInfo PortalInfo(PortalInfo p)
		{
			p.State = global::D2Packets.Game.Server.PortalInfo.TownPortalState.Town;
			return p;
		}

		// Token: 0x0600BA38 RID: 47672 RVA: 0x00467F5C File Offset: 0x0046615C
		private PortalOwnership PortalOwnership(PortalOwnership p)
		{
			return p;
		}

		// Token: 0x0600BA39 RID: 47673 RVA: 0x00467F70 File Offset: 0x00466170
		private ItemTriggerSkill ItemTriggerSkill(ItemTriggerSkill p)
		{
			return p;
		}

		// Token: 0x0600BA3A RID: 47674 RVA: 0x00467F84 File Offset: 0x00466184
		private UpdateUI UpdateUI(UpdateUI p)
		{
			bool flag = p.Action == UIAction.OpenCubeD2R;
			if (flag)
			{
				this.ClientStream.Write(new UpdateUI
				{
					Action = UIAction.HideStash,
					PacketVersion = GameVersion.LOD
				}.ToArray());
				p.Action = UIAction.OpenCube;
			}
			return p;
		}

		// Token: 0x0600BA3B RID: 47675 RVA: 0x00467FDC File Offset: 0x004661DC
		private OpenUI OpenUI(OpenUI p)
		{
			return p;
		}

		// Token: 0x0600BA3C RID: 47676 RVA: 0x00467FF0 File Offset: 0x004661F0
		private PlayerPartyRelationship PlayerPartyRelationship2(PlayerPartyRelationship p)
		{
			return p;
		}

		// Token: 0x0600BA3D RID: 47677 RVA: 0x00468004 File Offset: 0x00466204
		private MercCost MercCost(MercCost m)
		{
			this.MercNameId = m.NameId;
			this.MercReviveCost = m.ReviveCost;
			return m;
		}

		// Token: 0x0600BA3E RID: 47678 RVA: 0x00468030 File Offset: 0x00466230
		private MercAttributeByte MercAttributeByte(MercAttributeByte m)
		{
			m.AmountLOD = m.AmountD2R;
			return m;
		}

		// Token: 0x0600BA3F RID: 47679 RVA: 0x00468050 File Offset: 0x00466250
		private MercByteToExperience MercByteToExperience(MercByteToExperience m)
		{
			m.ExperienceLOD = m.ExperienceD2R;
			return m;
		}

		// Token: 0x0600BA40 RID: 47680 RVA: 0x00468070 File Offset: 0x00466270
		private MercWordToExperience MercWordToExperience(MercWordToExperience m)
		{
			m.ExperienceLOD = m.ExperienceD2R;
			return m;
		}

		// Token: 0x0600BA41 RID: 47681 RVA: 0x00468090 File Offset: 0x00466290
		private MercForHire MercForHire(MercForHire m)
		{
			this.MercsForHire.Add(m);
			return m;
		}

		// Token: 0x0600BA42 RID: 47682 RVA: 0x004680B0 File Offset: 0x004662B0
		private MercForHireListStart MercForHireListStart(MercForHireListStart m)
		{
			return m;
		}

		// Token: 0x0600BA43 RID: 47683 RVA: 0x004680C4 File Offset: 0x004662C4
		private AttributeByte AttributeByte(AttributeByte data)
		{
			this.me.Attributes[data.Stat.Type] = (uint)data.Value;
			return data;
		}

		// Token: 0x0600BA44 RID: 47684 RVA: 0x004680FC File Offset: 0x004662FC
		private AttributeWord AttributeWord(AttributeWord data)
		{
			this.me.Attributes[data.Stat.Type] = (uint)data.Value;
			return data;
		}

		// Token: 0x0600BA45 RID: 47685 RVA: 0x00468134 File Offset: 0x00466334
		private AttributeDWord AttributeDWord(AttributeDWord data)
		{
			this.me.Attributes[data.Stat.Type] = data.Value;
			return data;
		}

		// Token: 0x0600BA46 RID: 47686 RVA: 0x0046816C File Offset: 0x0046636C
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

		// Token: 0x0600BA47 RID: 47687 RVA: 0x00468308 File Offset: 0x00466508
		private UpdateQuestInfo UpdateQuestInfo(UpdateQuestInfo data)
		{
			this.updateQuestInfo = data;
			return data;
		}

		// Token: 0x040088A2 RID: 34978
		public TcpClient ClientProxy;

		// Token: 0x040088A3 RID: 34979
		public NetworkStream ClientStream;

		// Token: 0x040088A4 RID: 34980
		public TcpClient ServerProxy;

		// Token: 0x040088A5 RID: 34981
		public NetworkStream ServerBaseStream;

		// Token: 0x040088A6 RID: 34982
		public SslStream ServerStream;

		// Token: 0x040088A7 RID: 34983
		public bool Compression = false;

		// Token: 0x040088A8 RID: 34984
		public Task ClientHandler;

		// Token: 0x040088A9 RID: 34985
		public bool logging = false;

		// Token: 0x040088AA RID: 34986
		public bool clientOnly = false;

		// Token: 0x040088AB RID: 34987
		public IPEndPoint Endpoint;

		// Token: 0x040088AC RID: 34988
		public Manager GameInstance = new Manager();

		// Token: 0x040088AD RID: 34989
		private uint myId = 0U;

		// Token: 0x040088AE RID: 34990
		public Player dummy = new Player
		{
			X = ushort.MaxValue,
			Y = ushort.MaxValue
		};

		// Token: 0x040088AF RID: 34991
		public bool Kill = false;

		// Token: 0x040088B0 RID: 34992
		public static ConcurrentDictionary<uint, GameProxy.GameInfo> GameAccountLink = new ConcurrentDictionary<uint, GameProxy.GameInfo>();

		// Token: 0x040088B1 RID: 34993
		public static ConcurrentDictionary<string, GameProxy> GameProxies = new ConcurrentDictionary<string, GameProxy>();

		// Token: 0x040088B2 RID: 34994
		private string name;

		// Token: 0x040088B3 RID: 34995
		public string Email = "";

		// Token: 0x040088B4 RID: 34996
		private string CharacterName;

		// Token: 0x040088B5 RID: 34997
		private uint hash = 0U;

		// Token: 0x040088B6 RID: 34998
		private uint waypointId = 0U;

		// Token: 0x040088B7 RID: 34999
		private uint startTick = (uint)Environment.TickCount;

		// Token: 0x040088B8 RID: 35000
		public byte[] combinePacket = new byte[0];

		// Token: 0x040088B9 RID: 35001
		public bool LogonSuccess = false;

		// Token: 0x040088BA RID: 35002
		private Packet lastP = new Packet();

		// Token: 0x040088BB RID: 35003
		private RunToTarget rtt;

		// Token: 0x040088BC RID: 35004
		private TownFolkMenuItem Menu;

		// Token: 0x040088BD RID: 35005
		private uint sharedStash = 0U;

		// Token: 0x040088BE RID: 35006
		private uint repairCost = 0U;

		// Token: 0x040088BF RID: 35007
		private uint tguid1 = (uint)new Random().Next();

		// Token: 0x040088C0 RID: 35008
		private uint tguid2 = (uint)new Random().Next();

		// Token: 0x040088C1 RID: 35009
		private GameDifficulty Difficulty;

		// Token: 0x040088C2 RID: 35010
		private NPCCode lastNPCDead = NPCCode.Invalid;

		// Token: 0x040088C3 RID: 35011
		private Dictionary<uint, AssignMerc> Mercs = new Dictionary<uint, AssignMerc>();

		// Token: 0x040088C4 RID: 35012
		private Dictionary<uint, AssignGameObject> GOs = new Dictionary<uint, AssignGameObject>();

		// Token: 0x040088C5 RID: 35013
		private Dictionary<uint, AssignWarp> Warps = new Dictionary<uint, AssignWarp>();

		// Token: 0x040088C6 RID: 35014
		private ushort MercNameId;

		// Token: 0x040088C7 RID: 35015
		private uint MercReviveCost;

		// Token: 0x040088C8 RID: 35016
		private List<MercForHire> MercsForHire = new List<MercForHire>();

		// Token: 0x040088C9 RID: 35017
		public UpdateQuestInfo updateQuestInfo = new UpdateQuestInfo();

		// Token: 0x02001321 RID: 4897
		public class GameInfo
		{
			// Token: 0x04009D70 RID: 40304
			public string ipAddr;

			// Token: 0x04009D71 RID: 40305
			public int port;

			// Token: 0x04009D72 RID: 40306
			public List<byte> secret;

			// Token: 0x04009D73 RID: 40307
			public string account;

			// Token: 0x04009D74 RID: 40308
			public string character;
		}
	}
}
