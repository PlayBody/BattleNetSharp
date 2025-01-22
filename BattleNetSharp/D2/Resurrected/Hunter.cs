using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Classic.Protocol.External.V1.Character;
using Classic.Protocol.External.V1.GameManagement;
using D2GameState;
using DiabloBridge;
using Newtonsoft.Json;
using Utilities;

namespace BattleNetSharp.D2.Resurrected
{
	// Token: 0x02000B1F RID: 2847
	public class Hunter : IDisposable
	{
		// Token: 0x17003958 RID: 14680
		// (get) Token: 0x0600BFF9 RID: 49145 RVA: 0x004A1840 File Offset: 0x0049FA40
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
					this.Account.D2Account,
					", ",
					this.GameCount.ToString()
				});
			}
		}

		// Token: 0x0600BFFA RID: 49146 RVA: 0x004A18B0 File Offset: 0x0049FAB0
		public Hunter(string acc)
		{
			this.Region = WebManager.Region;
			this.SubRegion = WebManager.SubRegion;
			this.Ip = WebManager.Ip;
			string text = File.ReadAllText("hunters\\" + acc);
			this.Account = JsonConvert.DeserializeObject<AccountLink>(text);
		}

		// Token: 0x0600BFFB RID: 49147 RVA: 0x004A194C File Offset: 0x0049FB4C
		public static void Start(string acc, Action walkCallback = null, int sleep = 0)
		{
			Hunter hunter = new Hunter(acc);
			Task.Run(delegate
			{
				try
				{
					hunter.Hunt(walkCallback, sleep);
				}
				catch
				{
					hunter.Dispose();
				}
			});
		}

		// Token: 0x0600BFFC RID: 49148 RVA: 0x004A198C File Offset: 0x0049FB8C
		public static void KillUnfoundHunters()
		{
			try
			{
				Hunter.Hunters.Values.Where((Hunter s) => s.State != Hunter.HuntState.spawned).ToList<Hunter>().ForEach(delegate(Hunter h)
				{
					h.Dispose();
				});
			}
			catch
			{
			}
		}

        // Token: 0x0600BFFD RID: 49149 RVA: 0x004A1A0C File Offset: 0x0049FC0C
        public void Hunt(Action walkCallback, int sleep = 0)
        {
            this.State = Hunter.HuntState.queued;
            Hunter.Hunters.TryAdd(this.Account.D2Account, this);
            Thread.Sleep(sleep);
            this.State = Hunter.HuntState.loggingin;

            if (this.State == Hunter.HuntState.dead || !this.d2.BGSLoginLocked(this.Region, this.Account.BNetToken, this.Account.D2Account, D2RBGS.App.D2R))
                return;

            while (this.holdingGames)
            {
                try
                {
                    this.State = Hunter.HuntState.hunting;
                    this.d2.RealmLoginLocked(true);

                    if (this.CharId == 0U)
                    {
                        foreach (var charData in this.d2.ReadCharacters())
                        {
                            var d2RCharData = JsonConvert.DeserializeObject<D2RCharData>(charData.D2S.ToStringUtf8());
                            var bitReader = new BitReader(d2RCharData.questRecords.Select(b => (byte)b).ToArray(), 0);
                            var num = bitReader.ReadBits(80);
                            var num2 = bitReader.ReadBits(8);

                            Console.WriteLine($"char data  : {BitConverter.ToString(d2RCharData.questRecords.Select(b => (byte)b).ToArray())} : {charData.Name}");

                            if (num2 > 1UL)
                            {
                                this.CharId = charData.Id;
                                this.CharLevel = (uint)d2RCharData.level;
                                Console.WriteLine($"loading : {charData.Name}");
                                break;
                            }
                        }

                        if (this.CharId == 0U) break;
                    }

                    if (this.CharId == 0U)
                    {
                        Console.WriteLine(this.Account.D2Account);
                        return;
                    }

                    this.GameName = Guid.NewGuid().ToString().Substring(0, 8);
                    this.d2.CreateGame(this.GameName, this.GameName, this.CharId, 2U, this.CharLevel, true, this.SubRegion);
                    var gameJoinResponse = this.d2.JoinGame(this.GameName, this.GameName, this.CharId, this.CharLevel, "");
                    this.GameCount++;

                    if (this.d2.LoginResponse.Url.Contains("1a")) this.RealmServer = "1a";
                    if (this.d2.LoginResponse.Url.Contains("1b")) this.RealmServer = "1b";

                    if (gameJoinResponse == null) continue;

                    this.holdingGames = false;
                    this.State = Hunter.HuntState.found;
                    this.c = new Client();
                    this.c.Init(gameJoinResponse.Hash.ToByteArray().ToList());
                    this.c.Connect(IPAddress.Parse(gameJoinResponse.IpAddress), 443);

                    this.c.Behavior = () =>
                    {
                        bool flag11 = true;
                        while (true)
                        {
                            if (!this.c.GameInstance.Players.All(p => p.Value.Name == this.c.GameInstance.Players.First().Value.Name)) break;

                            if (this.c.clone && flag11)
                            {
                                this.State = Hunter.HuntState.spawned;
                                flag11 = false;
                                try { walkCallback?.Invoke(); }
                                catch { }
                            }

                            Thread.Sleep(500);
                        }
                        this.c.Terminate();
                    };

                    this.d2.Close();

                    while (this.c != null && this.c.HandlePackets)
                    {
                        Thread.Sleep(1000);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"some error: {ex.Message}");
                    this.d2.Close();
                    return;
                }
            }

            this.Dispose();
        }

        // Token: 0x0600BFFE RID: 49150 RVA: 0x004A1E8C File Offset: 0x004A008C
        public void Dispose()
		{
			this.State = Hunter.HuntState.dead;
			Hunter hunter;
			Hunter.Hunters.Remove(this.Account.D2Account, out hunter);
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

		// Token: 0x04009242 RID: 37442
		public static ConcurrentDictionary<string, Hunter> Hunters = new ConcurrentDictionary<string, Hunter>();

		// Token: 0x04009243 RID: 37443
		public AccountLink Account = new AccountLink();

		// Token: 0x04009244 RID: 37444
		public Hunter.HuntState State;

		// Token: 0x04009245 RID: 37445
		public string Region;

		// Token: 0x04009246 RID: 37446
		public string SubRegion;

		// Token: 0x04009247 RID: 37447
		public string Ip;

		// Token: 0x04009248 RID: 37448
		public string GameName = "0";

		// Token: 0x04009249 RID: 37449
		public uint CharId = 0U;

		// Token: 0x0400924A RID: 37450
		public uint CharLevel = 0U;

		// Token: 0x0400924B RID: 37451
		public uint GameCount = 0U;

		// Token: 0x0400924C RID: 37452
		public string RealmServer = "1a";

		// Token: 0x0400924D RID: 37453
		public D2RBGS d2 = new D2RBGS();

		// Token: 0x0400924E RID: 37454
		public bool holdingGames = true;

		// Token: 0x0400924F RID: 37455
		public Client c;

		// Token: 0x0200143B RID: 5179
		public enum HuntState
		{
			// Token: 0x0400A208 RID: 41480
			queued,
			// Token: 0x0400A209 RID: 41481
			loggingin,
			// Token: 0x0400A20A RID: 41482
			hunting,
			// Token: 0x0400A20B RID: 41483
			found,
			// Token: 0x0400A20C RID: 41484
			spawned,
			// Token: 0x0400A20D RID: 41485
			killed,
			// Token: 0x0400A20E RID: 41486
			dead
		}
	}
}
