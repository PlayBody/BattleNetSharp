using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Classic.Protocol.External.V1.GameManagement;
using D2Data;
using D2Packets;
using D2Packets.Game.Client;
using D2Packets.Game.Server;
using DiabloBridge;
using Newtonsoft.Json;

namespace BattleNetSharp.D2.Resurrected
{
	// Token: 0x02000B1D RID: 2845
	public class Gambler : IDisposable
	{
		// Token: 0x17003957 RID: 14679
		// (get) Token: 0x0600BFC3 RID: 49091 RVA: 0x0049D2D0 File Offset: 0x0049B4D0
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

		// Token: 0x0600BFC4 RID: 49092 RVA: 0x0049D328 File Offset: 0x0049B528
		public Gambler(string acc)
		{
			string text = File.ReadAllText("accounts\\" + acc);
			this.Account = JsonConvert.DeserializeObject<AccountLink>(text);
		}

		// Token: 0x0600BFC5 RID: 49093 RVA: 0x0049D394 File Offset: 0x0049B594
		public static void Start(string acc, string gameName)
		{
			Gambler proxy = new Gambler(acc);
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

		// Token: 0x0600BFC6 RID: 49094 RVA: 0x0049D3D4 File Offset: 0x0049B5D4
		public bool AreIntersected(int x1, int y1, int w1, int h1, int x2, int y2, int w2, int h2)
		{
			return x2 < x1 + w1 && x1 < x2 + w2 && y2 < y1 + h1 && y1 < y2 + h2;
		}

        // Token: 0x0600BFC7 RID: 49095 RVA: 0x0049D408 File Offset: 0x0049B608
        private bool FitBottomRightToTopLeft(ItemAction item, IEnumerable<ItemAction> otherItems, int width, int height, bool weighted, out ushort vendorX, out ushort vendorY)
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
                        int currentWeight = 10; // Static weight assigned (matches original logic).
                        if (currentWeight > maxWeight)
                        {
                            maxWeight = currentWeight;
                            vendorX = (ushort)x;
                            vendorY = (ushort)y;
                        }
                        if (currentWeight == 255 || !weighted)
                        {
                            return true;
                        }
                    }
                }
            }
            return maxWeight > 0;
        }

        // Token: 0x0600BFC8 RID: 49096 RVA: 0x0049D554 File Offset: 0x0049B754
        public void Wait()
		{
			this.State = Gambler.BotState.loggingin;
			bool flag = this.State == Gambler.BotState.dead;
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
					this.State = Gambler.BotState.waiting;
					this.c = new Game();
					this.c.Init(gameJoinResponse.Hash.ToByteArray().ToList<byte>());
					this.c.Connect(IPAddress.Parse(gameJoinResponse.IpAddress), 443);
					this.c.Behavior = delegate
					{
						ItemAction value = this.c.GameInstance.Items.FirstOrDefault((KeyValuePair<uint, ItemAction> i) => i.Value.OwnerId == this.c.me.Id && i.Value.container == ItemContainer.Inventory && i.Value.baseItem.Type == ItemType.IstRune).Value;
						ItemAction value2 = this.c.GameInstance.Items.FirstOrDefault((KeyValuePair<uint, ItemAction> i) => i.Value.OwnerId == this.c.me.Id && (i.Value.baseItem.Type == ItemType.Coronet || i.Value.baseItem.Type == ItemType.Tiara || i.Value.baseItem.Type == ItemType.Diadem)).Value;
						bool flag3 = value2 != null;
						if (flag3)
						{
							this.c.SendPacket(new PickItemFromContainer
							{
								Id = value2.Id,
								X = (uint)value2.x,
								Y = (uint)value2.y,
								Container = PickItemFromContainer.ContainerType.Inventory
							});
							int num = 20;
							for (;;)
							{
								if (this.c.GameInstance.Items.Count((KeyValuePair<uint, ItemAction> i) => i.Value.action == ItemActionType.AutoUnequip) != 0 || num-- <= 0)
								{
									break;
								}
								Thread.Sleep(16);
							}
							bool flag4 = num > 2;
							if (!flag4)
							{
								throw new Exception("couldn't drop");
							}
							this.c.SendPacket(new DropItem
							{
								Id = value2.Id
							});
						}
						this.c.TravelTo(NPCCode.Gheed, false);
						AssignNPC value3 = this.c.GameInstance.NPCs.First((KeyValuePair<uint, AssignNPC> e) => e.Value.NpcType == NPCCode.Gheed).Value;
						this.c.TownFolkInteract(value3);
						for (;;)
						{
							bool flag5 = this.c.GetGold() < 50000U;
							if (flag5)
							{
								Console.WriteLine("regenerate gold " + this.c.GetGold().ToString());
								List<byte> list = new List<byte>();
								byte[] array = new SellItem
								{
									ItemId = value.Id,
									DealerIdD2R = value3.Id,
									CostD2R = 33792U,
									X = 9,
									Y = 3,
									VendorX = 9,
									VendorY = 1,
									VendorPage = 3
								}.ToArray();
								byte[] array2 = new BuyItem
								{
									DealerIdD2R = value3.Id,
									CostD2R = 12908U,
									ItemId = value.Id,
									VendorX = 9,
									VendorY = 1,
									VendorPage = 3,
									X = 9,
									Y = 3
								}.ToArray();
								IEnumerable<byte> enumerable = array.Concat(array2);
								for (int j = 0; j < 30; j++)
								{
									list.AddRange(enumerable);
								}
								this.c.SendPacket(list.ToArray(), (Packet p) => p is Relator1);
								Thread.Sleep(200);
								Console.WriteLine("generated gold " + this.c.GetGold().ToString());
							}
							for (;;)
							{
								if (this.c.GameInstance.Items.Count((KeyValuePair<uint, ItemAction> i) => i.Value.action == ItemActionType.AddToShop && i.Value.baseItem.Type == ItemType.Coronet) != 0)
								{
									break;
								}
								this.c.GameInstance.Items.Clear();
								Client client = this.c;
								TownFolkMenuSelect townFolkMenuSelect = new TownFolkMenuSelect();
								townFolkMenuSelect.Type = TownFolkMenuItem.Gamble;
								townFolkMenuSelect.Id = value3.Id;
								client.SendPacket(townFolkMenuSelect, (Packet p) => p is Relator1);
							}
							ItemAction value4 = this.c.GameInstance.Items.First((KeyValuePair<uint, ItemAction> i) => i.Value.action == ItemActionType.AddToShop && i.Value.baseItem.Type == ItemType.Coronet).Value;
							this.c.GameInstance.Items.Clear();
							Client client2 = this.c;
							BuyItem buyItem = new BuyItem();
							buyItem.DealerIdD2R = value3.Id;
							buyItem.CostD2R = 32596U;
							buyItem.ItemId = value4.Id;
							buyItem.VendorX = (ushort)value4.x;
							buyItem.VendorY = (ushort)value4.y;
							buyItem.VendorPage = (byte)(value4.container - ItemContainer.Inventory);
							buyItem.Container = (ItemDestination)256;
							buyItem.X = 0;
							buyItem.Y = 0;
							bool flag6 = client2.SendPacket(buyItem, (Packet p) => p is Relator1);
							bool flag7 = !flag6;
							if (flag7)
							{
								Console.WriteLine("buy failed");
							}
							else
							{
								ItemAction value5 = this.c.GameInstance.Items.FirstOrDefault((KeyValuePair<uint, ItemAction> i) => i.Value.OwnerId == this.c.me.Id && (i.Value.baseItem.Type == ItemType.Coronet || i.Value.baseItem.Type == ItemType.Tiara || i.Value.baseItem.Type == ItemType.Diadem)).Value;
								bool flag8 = value5 == null;
								if (flag8)
								{
									break;
								}
								Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff tt") + " bought : " + string.Join<StatBase>(",", value5.mods));
								if (value5.mods.Count((StatBase m) => m.BaseStat.Type == StatType.ClassSkillsBonus) > 0)
								{
									goto IL_059B;
								}
								if (value5.mods.Count((StatBase m) => m.BaseStat.Type == StatType.SkillTabBonus) > 0)
								{
									goto IL_059B;
								}
								goto IL_05F9;
								IL_05FA:
								bool flag10;
								bool flag9 = flag10;
								if (flag9)
								{
									ClassSkillsBonusStat classSkillsBonusStat = value5.mods.FirstOrDefault((StatBase m) => m.BaseStat.Type == StatType.ClassSkillsBonus) as ClassSkillsBonusStat;
									bool flag11 = classSkillsBonusStat != null && classSkillsBonusStat.Value >= 2;
									if (flag11)
									{
										Console.WriteLine("");
									}
									ClassSkillsBonusStat classSkillsBonusStat2 = value5.mods.FirstOrDefault((StatBase m) => m.BaseStat.Type == StatType.SkillTabBonus) as ClassSkillsBonusStat;
									bool flag12 = classSkillsBonusStat2 != null && classSkillsBonusStat2.Value >= 3;
									if (flag12)
									{
										Console.WriteLine("");
									}
								}
								Client client3 = this.c;
								DropItemFromContainer dropItemFromContainer = new DropItemFromContainer();
								dropItemFromContainer.ItemId = value5.Id;
								dropItemFromContainer.X = (ushort)value5.x;
								dropItemFromContainer.Y = (ushort)value5.y;
								client3.SendPacket(dropItemFromContainer, (Packet p) => p is WorldItemAction);
								continue;
								IL_05F9:
								flag10 = false;
								goto IL_05FA;
								IL_059B:
								if (value5.mods.Count((StatBase m) => m.BaseStat.Type == StatType.FasterCastRate) > 0)
								{
									flag10 = value5.mods.Count((StatBase m) => m.BaseStat.Type == StatType.FireResist) > 0;
									goto IL_05FA;
								}
								goto IL_05F9;
							}
						}
						Console.WriteLine("buy returned bad data");
						this.c.Terminate();
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

		// Token: 0x0600BFC9 RID: 49097 RVA: 0x0049D70C File Offset: 0x0049B90C
		public void Dispose()
		{
			this.State = Gambler.BotState.dead;
			this.holdingGames = false;
			Game game = this.c;
			if (game != null)
			{
				game.Terminate();
			}
			D2RBGS d2RBGS = this.d2;
			if (d2RBGS != null)
			{
				d2RBGS.Close();
			}
		}

		// Token: 0x0400921F RID: 37407
		public AccountLink Account = new AccountLink();

		// Token: 0x04009220 RID: 37408
		public Gambler.BotState State;

		// Token: 0x04009221 RID: 37409
		public uint CharId = 0U;

		// Token: 0x04009222 RID: 37410
		public string GameName = "0";

		// Token: 0x04009223 RID: 37411
		public string RealmServer = "1a";

		// Token: 0x04009224 RID: 37412
		public D2RBGS d2 = new D2RBGS();

		// Token: 0x04009225 RID: 37413
		public bool holdingGames = true;

		// Token: 0x04009226 RID: 37414
		public Game c;

		// Token: 0x0200142F RID: 5167
		public enum BotState
		{
			// Token: 0x0400A1DC RID: 41436
			loggingin,
			// Token: 0x0400A1DD RID: 41437
			waiting,
			// Token: 0x0400A1DE RID: 41438
			dead
		}
	}
}
