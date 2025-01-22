using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Classic.Protocol.External.V1.Character;
using Classic.Protocol.External.V1.GameManagement;
using D2Data;
using D2Packets.Game.Client;
using D2Packets.Game.Server;
using DiabloBridge;
using Newtonsoft.Json;
using Utilities;

namespace BattleNetSharp.D2.Resurrected
{
	// Token: 0x02000B1C RID: 2844
	public class Dropper : IDisposable
	{
		// Token: 0x17003956 RID: 14678
		// (get) Token: 0x0600BFBB RID: 49083 RVA: 0x0049CD10 File Offset: 0x0049AF10
		public string Status
		{
			get
			{
				return this.GameName + ", " + this.Account.D2Account;
			}
		}

		// Token: 0x0600BFBC RID: 49084 RVA: 0x0049CD40 File Offset: 0x0049AF40
		public Dropper(string acc)
		{
			string text = File.ReadAllText("accounts\\" + acc);
			this.Account = JsonConvert.DeserializeObject<AccountLink>(text);
		}

		// Token: 0x0600BFBD RID: 49085 RVA: 0x0049CDA8 File Offset: 0x0049AFA8
		public static void Start(string acc, string gameName, int location, uint x, uint y, Action droppedCallback = null, int sleep = 0)
		{
			Dropper hunter = new Dropper(acc);
			hunter.GameName = gameName;
			hunter.Location = location;
			hunter.X = x;
			hunter.Y = y;
			hunter.Callback = droppedCallback;
			Task.Run(delegate
			{
				try
				{
					hunter.Drop(sleep);
				}
				catch
				{
					hunter.Dispose();
				}
			});
		}

		// Token: 0x0600BFBE RID: 49086 RVA: 0x0049CE20 File Offset: 0x0049B020
		public void Drop(int sleep = 0)
		{
			Dropper.Droppers.Add(this);
			this.d2.BGSLoginLocked("us", this.Account.BNetToken, this.Account.D2Account, D2RBGS.App.D2R);
			try
			{
				this.d2.RealmLoginLocked(true);
				string charName = "";
				bool flag = this.CharId == 0U;
				if (flag)
				{
					List<CharData> list = this.d2.ReadCharacters();
					using (List<CharData>.Enumerator enumerator = list.GetEnumerator())
					{
						if (enumerator.MoveNext())
						{
							CharData charData = enumerator.Current;
							D2RCharData d2RCharData = JsonConvert.DeserializeObject<D2RCharData>(charData.D2S.ToStringUtf8());
							string text = BitConverter.ToString(d2RCharData.questRecords.Select((int b) => (byte)b).ToArray<byte>());
							BitReader bitReader = new BitReader(d2RCharData.questRecords.Select((int b) => (byte)b).ToArray<byte>(), 0);
							ulong num = bitReader.ReadBits(80);
							ulong num2 = bitReader.ReadBits(8);
							this.CharId = charData.Id;
							charName = charData.Name;
							this.CharLevel = (uint)JsonConvert.DeserializeObject<D2RCharData>(charData.D2S.ToStringUtf8()).level;
						}
					}
				}
				GameJoinResponse gameJoinResponse = this.d2.JoinGame(this.GameName, this.GameName, this.CharId, this.CharLevel, "");
				bool flag2 = gameJoinResponse == null;
				if (flag2)
				{
					throw new Exception("game join fail");
				}
				this.c = new Client();
				bool needRejoin = false;
				this.c.Init(gameJoinResponse.Hash.ToByteArray().ToList<byte>());
				this.c.Connect(IPAddress.Parse(gameJoinResponse.IpAddress), 443);
				this.c.Behavior = delegate
				{
					bool flag4 = this.c.currentAct > ActLocation.Act1;
					if (flag4)
					{
						needRejoin = true;
					}
					else
					{
						try
						{
							ItemAction itemAction = this.c.GameInstance.Items.Values.FirstOrDefault((ItemAction i) => i.container == ItemContainer.Stash && (long)i.x == (long)((ulong)this.X) && (long)i.y == (long)((ulong)this.Y));
							bool flag5 = itemAction != null;
							if (flag5)
							{
								this.c.SendPacket(new PickItemFromContainer
								{
									Id = itemAction.Id,
									X = this.X,
									Y = this.Y,
									Container = PickItemFromContainer.ContainerType.Stash
								});
								int num3 = 100;
								for (;;)
								{
									if (this.c.GameInstance.Items.Count((KeyValuePair<uint, ItemAction> i) => i.Value.action == ItemActionType.AutoUnequip) != 0 || num3-- <= 1)
									{
										break;
									}
									Thread.Sleep(50);
								}
								bool flag6 = num3 > 1;
								if (flag6)
								{
									this.c.SendPacket(new DropItem
									{
										Id = itemAction.Id
									});
									Console.WriteLine("dropping item : " + itemAction.GetTitle() + " : " + itemAction.GetDescription());
								}
								else
								{
									Console.WriteLine("timeout trying to pick item");
								}
								ItemDb.DeleteItem(this.Account.BNetEmail, charName, itemAction);
							}
							else
							{
								Console.WriteLine("no item found");
								ItemDb.DeleteStashItem(this.Account.BNetEmail, charName, this.X, this.Y);
							}
						}
						catch
						{
						}
					}
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
				bool needRejoin2 = needRejoin;
				if (needRejoin2)
				{
					this.d2.BGSLoginLocked("us", this.Account.BNetToken, this.Account.D2Account, D2RBGS.App.D2R);
					this.d2.RealmLoginLocked(true);
					string text2 = Guid.NewGuid().ToString().Substring(0, 8) + "as";
					bool flag3 = this.d2.CreateGame(text2, text2, this.CharId, 1U, this.CharLevel, true, WebManager.SubRegion);
					gameJoinResponse = this.d2.JoinGame(text2, text2, this.CharId, this.CharLevel, "");
					this.c = new Client();
					this.c.Init(gameJoinResponse.Hash.ToByteArray().ToList<byte>());
					this.c.Connect(IPAddress.Parse(gameJoinResponse.IpAddress), 443);
					this.c.Behavior = delegate
					{
						this.c.Terminate();
					};
					D2RBGS d2RBGS2 = this.d2;
					if (d2RBGS2 != null)
					{
						d2RBGS2.Close();
					}
					while (this.c.HandlePackets)
					{
						Thread.Sleep(1000);
					}
					this.Drop(0);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("some dropper error : " + ex.Message);
				D2RBGS d2RBGS3 = this.d2;
				if (d2RBGS3 != null)
				{
					d2RBGS3.Close();
				}
			}
			this.Dispose();
		}

		// Token: 0x0600BFBF RID: 49087 RVA: 0x0049D230 File Offset: 0x0049B430
		public void Dispose()
		{
			Action callback = this.Callback;
			if (callback != null)
			{
				callback();
			}
			Dropper.Droppers.Remove(this);
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

		// Token: 0x04009213 RID: 37395
		public static List<Dropper> Droppers = new List<Dropper>();

		// Token: 0x04009214 RID: 37396
		public AccountLink Account = new AccountLink();

		// Token: 0x04009215 RID: 37397
		public uint CharId = 0U;

		// Token: 0x04009216 RID: 37398
		public uint CharLevel = 0U;

		// Token: 0x04009217 RID: 37399
		public string GameName = "0";

		// Token: 0x04009218 RID: 37400
		public int Location;

		// Token: 0x04009219 RID: 37401
		public uint X;

		// Token: 0x0400921A RID: 37402
		public uint Y;

		// Token: 0x0400921B RID: 37403
		public D2RBGS d2 = new D2RBGS();

		// Token: 0x0400921C RID: 37404
		public bool holdingGames = true;

		// Token: 0x0400921D RID: 37405
		public Client c;

		// Token: 0x0400921E RID: 37406
		public Action Callback;
	}
}
