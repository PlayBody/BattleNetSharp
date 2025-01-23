using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Classic.Protocol.External.V1.GameManagement;
using D2Data;
using D2GameState;
using D2Packets.Game.Client;
using D2Packets.Game.Server;
using DiabloBridge;
using Newtonsoft.Json;

namespace BattleNetSharp.D2.Resurrected
{
	// Token: 0x02000B26 RID: 2854
	public class LazProxy : IDisposable
	{
		// Token: 0x17003964 RID: 14692
		// (get) Token: 0x0600C026 RID: 49190 RVA: 0x004A2364 File Offset: 0x004A0564
		public string Status
		{
			get
			{
				return string.Concat(new string[]
				{
					this.State.ToString(),
					", ",
					this.GameName,
					", ",
					this.Account.D2Account
				});
			}
		}

		// Token: 0x0600C027 RID: 49191 RVA: 0x004A23BC File Offset: 0x004A05BC
		public LazProxy(string acc)
		{
			string text = File.ReadAllText("accounts\\" + acc);
			this.Account = JsonConvert.DeserializeObject<AccountLink>(text);
		}

		// Token: 0x0600C028 RID: 49192 RVA: 0x004A2428 File Offset: 0x004A0628
		public static void Start(string acc, string gameName)
		{
			LazProxy proxy = new LazProxy(acc);
			proxy.GameName = gameName;
			Task.Run(delegate
			{
				try
				{
					proxy.Wait();
				}
				catch
				{
					proxy.Dispose();
				}
			});
		}

		// Token: 0x0600C029 RID: 49193 RVA: 0x004A2468 File Offset: 0x004A0668
		public bool AreIntersected(int x1, int y1, int w1, int h1, int x2, int y2, int w2, int h2)
		{
			return x2 < x1 + w1 && x1 < x2 + w2 && y2 < y1 + h1 && y1 < y2 + h2;
		}

        // Token: 0x0600C02A RID: 49194 RVA: 0x004A249C File Offset: 0x004A069C
        private bool FitBottomRightToTopLeft(ItemAction item, IEnumerable<ItemAction> otherItems, int width, int height, bool weighted, out ushort vendorX, out ushort vendorY)
        {
            vendorX = 0;
            vendorY = 0;
            int highestWeight = 0;

            for (int x = width - item.baseItem.InvWidth; x >= 0; x--)
            {
                for (int y = height - item.baseItem.InvHeight; y >= 0; y--)
                {
                    bool isPositionValid = otherItems.All(i => !AreIntersected(x, y, item.baseItem.InvWidth, item.baseItem.InvHeight, i.x, i.y, i.baseItem.InvWidth, i.baseItem.InvHeight));

                    if (isPositionValid)
                    {
                        int weight = 10; // Example static weight for this logic
                        if (weight > highestWeight)
                        {
                            highestWeight = weight;
                            vendorX = (ushort)x;
                            vendorY = (ushort)y;
                        }

                        if (weight == 255 || !weighted)
                        {
                            return true;
                        }
                    }
                }
            }

            return highestWeight > 0;
        }

        // Token: 0x0600C02B RID: 49195 RVA: 0x004A25E8 File Offset: 0x004A07E8
        public void Wait()
		{
			this.State = LazProxy.BotState.loggingin;
			LazProxy.LazProxys.Add(this);
			bool flag = this.State == LazProxy.BotState.dead;
			if (!flag)
			{
				this.d2.BGSLoginLocked("us", this.Account.BNetToken, this.Account.D2Account, D2RBGS.App.D2R);
				try
				{
					this.d2.RealmLoginLocked(true);
					this.CharId = this.d2.ReadCharacters()[0].Id;
					this.d2.CreateGame(this.GameName, this.GameName, this.CharId, 0U, 1U, true, "USW2");
					GameJoinResponse gameJoinResponse = this.d2.JoinGame(this.GameName, this.GameName, this.CharId, 1U, "");
					bool flag2 = gameJoinResponse == null;
					if (flag2)
					{
						throw new Exception("game join fail");
					}
					this.State = LazProxy.BotState.waiting;
					this.c = new Client();
					this.c.Init(gameJoinResponse.Hash.ToByteArray().ToList<byte>());
					this.c.Connect(IPAddress.Parse(gameJoinResponse.IpAddress), 443);
					this.c.Behavior = delegate
					{
						ushort x = this.c.me.X;
						ushort y = this.c.me.Y;
						for (;;)
						{
							ItemAction itemAction = this.c.GameInstance.Items.Values.FirstOrDefault((ItemAction i) => i.action == ItemActionType.AutoUnequip || i.action == ItemActionType.GroundToCursor);
							bool flag3 = itemAction != null;
							if (flag3)
							{
								this.c.SendPacket(new DropItem
								{
									Id = itemAction.Id
								});
							}
							Thread.Sleep(100);
							bool flag4 = this.c.GameInstance.Players.Any((KeyValuePair<uint, Player> p) => p.Value.Name.ToLower() == "shalzuth");
							bool flag5 = flag4;
							if (flag5)
							{
								ItemAction itemAction2 = this.c.GameInstance.Items.Values.FirstOrDefault((ItemAction i) => i.container == ItemContainer.Stash && i.OwnerId == this.c.myId);
								bool flag6 = itemAction2 == null;
								if (!flag6)
								{
									this.c.SendPacket(new PickItemFromContainer
									{
										Id = itemAction2.Id,
										X = (uint)itemAction2.x,
										Y = (uint)itemAction2.y,
										Container = PickItemFromContainer.ContainerType.Stash
									});
									int num = 20;
									for (;;)
									{
										if (this.c.GameInstance.Items.Count((KeyValuePair<uint, ItemAction> i) => i.Value.action == ItemActionType.AutoUnequip) != 0 || num-- <= 0)
										{
											break;
										}
										Thread.Sleep(50);
									}
									bool flag7 = num > 2;
									if (flag7)
									{
										this.c.SendPacket(new DropItem
										{
											Id = itemAction2.Id
										});
									}
								}
							}
							else
							{
								ItemAction itemAction3 = this.c.GameInstance.Items.Values.FirstOrDefault((ItemAction i) => i.container == ItemContainer.Ground && Math.Abs(i.x - (int)this.c.me.X) < 8 && Math.Abs(i.y - (int)this.c.me.Y) < 8);
								bool flag8 = itemAction3 == null;
								if (!flag8)
								{
									bool flag9 = false;
									bool flag10 = Math.Abs(itemAction3.x - (int)this.c.me.X) > 3 || Math.Abs(itemAction3.y - (int)this.c.me.Y) > 3;
									if (flag10)
									{
										this.c.SendPacket(new RunToLocation
										{
											X = (ushort)itemAction3.x,
											Y = (ushort)itemAction3.y,
											CurrentY = this.c.me.Y,
											CurrentX = this.c.me.X
										});
										flag9 = true;
										Thread.Sleep(500);
									}
									this.c.SendPacket(new PickItem
									{
										Id = itemAction3.Id,
										X = (uint)itemAction3.x,
										Y = (uint)itemAction3.y,
										ToLocation = PickItem.PickLocation.Cursor
									});
									bool flag11 = flag9;
									if (flag11)
									{
										this.c.SendPacket(new RunToLocation
										{
											X = x,
											Y = y,
											CurrentY = this.c.me.Y,
											CurrentX = this.c.me.X
										});
									}
									int num2 = 20;
									for (;;)
									{
										if (this.c.GameInstance.Items.Count((KeyValuePair<uint, ItemAction> i) => i.Value.action == ItemActionType.GroundToCursor) != 0 || num2-- <= 0)
										{
											break;
										}
										Thread.Sleep(50);
									}
									IEnumerable<ItemAction> enumerable = this.c.GameInstance.Items.Values.Where((ItemAction i) => (i.action == ItemActionType.PutInContainer || i.action == ItemActionType.UpdateStats) && i.container == ItemContainer.Stash);
									ushort num3 = 0;
									ushort num4 = 0;
									bool flag12 = num2 > 2 && this.FitBottomRightToTopLeft(itemAction3, enumerable, 10, 10, false, out num3, out num4);
									if (flag12)
									{
										this.c.SendPacket(new DropItemToContainer
										{
											Id = itemAction3.Id,
											Container = DropItemToContainer.ContainerType.Stash,
											X = (uint)num3,
											Y = (uint)num4
										});
									}
								}
							}
						}
					};
					D2RBGS d2RBGS = this.d2;
					if (d2RBGS != null)
					{
						d2RBGS.Close();
					}
					while (this.c.HandlePackets)
					{
						Thread.Sleep(1000);
					}
				}
				catch (Exception ex)
				{
					Console.Write("some error : " + ex.Message);
					this.d2.Close();
					return;
				}
				this.Dispose();
			}
		}

		// Token: 0x0600C02C RID: 49196 RVA: 0x004A27AC File Offset: 0x004A09AC
		public void Dispose()
		{
			this.State = LazProxy.BotState.dead;
			LazProxy.LazProxys.Remove(this);
			this.holdingGames = false;
			Client client = this.c;
			if (client != null)
			{
				client.Terminate();
			}
			D2RBGS d2RBGS = this.d2;
			if (d2RBGS != null)
			{
				d2RBGS.Close();
			}
		}

		// Token: 0x0400925F RID: 37471
		public static List<LazProxy> LazProxys = new List<LazProxy>();

		// Token: 0x04009260 RID: 37472
		public AccountLink Account = new AccountLink();

		// Token: 0x04009261 RID: 37473
		public LazProxy.BotState State;

		// Token: 0x04009262 RID: 37474
		public uint CharId = 0U;

		// Token: 0x04009263 RID: 37475
		public string GameName = "0";

		// Token: 0x04009264 RID: 37476
		public string RealmServer = "1a";

		// Token: 0x04009265 RID: 37477
		public D2RBGS d2 = new D2RBGS();

		// Token: 0x04009266 RID: 37478
		public bool holdingGames = true;

		// Token: 0x04009267 RID: 37479
		public Client c;

		// Token: 0x02001443 RID: 5187
		public enum BotState
		{
			// Token: 0x0400A229 RID: 41513
			loggingin,
			// Token: 0x0400A22A RID: 41514
			waiting,
			// Token: 0x0400A22B RID: 41515
			dead
		}
	}
}
