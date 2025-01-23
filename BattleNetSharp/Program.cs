using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using BattleNetSharp.D2.Resurrected;
using BattleNetSharp.D4;
using BattleNetSharp.Services;
using Bgs.Protocol;
using Bgs.Protocol.Friends.V1;
using Bgs.Protocol.Leaderboard.V1.Client;
using Classic.Protocol.External.V1.Character;
using Classic.Protocol.External.V1.DiabloClone;
using Classic.Protocol.External.V1.GameManagement;
using Classic.Protocol.External.V1.TerrorZones;
using D2Data;
using D2GameState;
using D2Packets;
using D2Packets.Game.Client;
using D2Packets.Game.Server;
using D4Packets;
using D4Packets.Files;
using D4Packets.Game.Client;
using DiabloBridge;
using Google.Protobuf;
using Newtonsoft.Json;
using Utilities;
using WoW.Packets;

namespace BattleNetSharp
{
	// Token: 0x02000AD4 RID: 2772
	public class Program
	{
		// Token: 0x0600BC7B RID: 48251 RVA: 0x0047CC78 File Offset: 0x0047AE78
		public static void test3(string name, string region, string t, bool wait)
		{
			D2RBGS d2RBGS = new D2RBGS();
			d2RBGS.BGSLoginLocked(region, t, region, D2RBGS.App.D2R);
			d2RBGS.RealmLoginLocked(true);
			List<CharData> list = d2RBGS.ReadCharacters();
			uint id = list.First((CharData i) => i.Name != "itemcacher").Id;
			string text = (wait ? "adfjadnfb" : "asdfjksbf");
			bool flag = d2RBGS.CreateGame(text, text, id, 0U, 1U, true, (region == "us") ? "USW1" : "ASZ1");
			GameJoinResponse gameJoinResponse = d2RBGS.JoinGame(text, text, id, 1U, "");
			Console.WriteLine("joining : " + gameJoinResponse.IpAddress);
			BattleNetSharp.D2.Resurrected.Client c = new BattleNetSharp.D2.Resurrected.Client();
			c.Behavior = delegate
			{
				Console.WriteLine("behavior entered for " + region);
				c.Terminate();
			};
			c.Init(gameJoinResponse.Hash.ToByteArray().ToList<byte>());
			Program.done++;
			while (Program.done != 2)
			{
				Thread.Sleep(15);
			}
			if (wait)
			{
				while (Program.done == 2)
				{
					Thread.Sleep(50);
				}
			}
			c.Connect(IPAddress.Parse(gameJoinResponse.IpAddress), 443);
			for (;;)
			{
				Thread.Sleep(100);
			}
		}

		// Token: 0x0600BC7C RID: 48252 RVA: 0x0047CE08 File Offset: 0x0047B008
		public static void test(string name, string region, string t, bool wait)
		{
			D2RBGS d2RBGS = new D2RBGS();
			bool wait2 = wait;
			if (wait2)
			{
				while (Program.done == 0)
				{
					Thread.Sleep(50);
				}
			}
			d2RBGS.BGSLoginLocked(region, t, region, D2RBGS.App.D2R);
			d2RBGS.RealmLoginLocked(true);
			List<CharData> list = d2RBGS.ReadCharacters();
			uint id = list.First((CharData i) => wait ? (i.Name == "itemcache") : (i.Name == "itemcacher")).Id;
			string text = (wait ? "adfjadnfb" : "asdfjksbf");
			bool flag = d2RBGS.CreateGame(text, text, id, 0U, 1U, true, (region == "us") ? "USW1" : "ASZ1");
			GameJoinResponse gameJoinResponse = d2RBGS.JoinGame(text, text, id, 1U, "");
			bool flag2 = gameJoinResponse.IpAddress == "";
			if (flag2)
			{
				Console.WriteLine("");
			}
			Console.WriteLine("joiing : " + gameJoinResponse.IpAddress);
			Program.done++;
			BattleNetSharp.D2.Resurrected.Client c = new BattleNetSharp.D2.Resurrected.Client();
			c.Behavior = delegate
			{
				Console.WriteLine("behavior entered for " + region);
				Thread.Sleep(3000);
				c.Terminate();
				Program.done++;
				bool flag3 = Program.done > 0;
				if (!flag3)
				{
					KeyValuePair<uint, global::D2GameState.Player> keyValuePair = c.GameInstance.Players.First((KeyValuePair<uint, global::D2GameState.Player> p) => p.Value.Name == "shalzy");
					while (Helpers.DistanceSquared(c.me.X, c.me.Y, keyValuePair.Value.X, keyValuePair.Value.Y) > 10f)
					{
						Thread.Sleep(2000);
					}
					for (;;)
					{
						if (c.GameInstance.Items.Values.Count((ItemAction i) => i.baseItem.Type == ItemType.SmallCharm && i.action.ToString().Contains("Ground")) != 0)
						{
							break;
						}
						Thread.Sleep(2000);
					}
					ItemAction itemAction = c.GameInstance.Items.Values.First((ItemAction i) => i.baseItem.Type == ItemType.SmallCharm && i.action.ToString().Contains("Ground"));
					Console.WriteLine("trade");
					uint num = (uint)new Random().Next();
					c.SendPacket(new Trade
					{
						Guid = num,
						TargetId = keyValuePair.Value.Id
					});
					Console.WriteLine("helper wait enter trade");
					c.WaitForPacket((Packet p) => p is TradeRequest);
					Thread.Sleep(2000);
					Console.WriteLine("picking charm");
					c.SendPacket(new PickItemFromContainer
					{
						Id = itemAction.Id,
						X = (uint)itemAction.x,
						Y = (uint)itemAction.y,
						Container = PickItemFromContainer.ContainerType.Inventory
					});
					Thread.Sleep(1000);
					Console.WriteLine("put in trade");
					c.SendPacket(new Trade
					{
						Guid = num,
						TargetId = keyValuePair.Value.Id,
						ItemId = itemAction.Id
					});
					Thread.Sleep(1000);
					Console.WriteLine("pick from ground");
					KeyValuePair<uint, ItemAction> keyValuePair2 = c.GameInstance.Items.First((KeyValuePair<uint, ItemAction> i) => i.Value.action.ToString().Contains("Ground"));
					c.SendPacket(new PickItem
					{
						Id = keyValuePair2.Key,
						ToLocation = PickItem.PickLocation.Inventory,
						X = (uint)keyValuePair2.Value.x,
						Y = (uint)keyValuePair2.Value.y
					});
					Thread.Sleep(1000);
				}
			};
			c.Init(gameJoinResponse.Hash.ToByteArray().ToList<byte>());
			while (Program.done != 2)
			{
				Thread.Sleep(15);
			}
			bool wait3 = wait;
			if (wait3)
			{
				while (Program.done == 2)
				{
					Thread.Sleep(50);
				}
			}
			c.Connect(IPAddress.Parse(gameJoinResponse.IpAddress), 443);
			for (;;)
			{
				Thread.Sleep(100);
			}
		}

		// Token: 0x0600BC7D RID: 48253 RVA: 0x0047CFE0 File Offset: 0x0047B1E0
		public static void Gambler(string name, string region, string t)
		{
			D2RBGS d2RBGS = new D2RBGS();
			d2RBGS.BGSLoginLocked(region, t, region, D2RBGS.App.D2R);
			d2RBGS.RealmLoginLocked(true);
			List<CharData> list = d2RBGS.ReadCharacters();
			CharData charData = list.First((CharData i) => i.Name == "Strummorin");
			GameJoinResponse gameJoinResponse = d2RBGS.JoinGame("gambler", "gambler", charData.Id, 90U, "");
			Game game = new Game();
			game.Init(gameJoinResponse.Hash.ToByteArray().ToList<byte>());
			game.Connect(IPAddress.Parse(gameJoinResponse.IpAddress), 443);
			Thread.Sleep(5000);
			while (game.HandlePackets)
			{
				Thread.Sleep(200);
			}
		}

		// Token: 0x0600BC7E RID: 48254 RVA: 0x0047D0B0 File Offset: 0x0047B2B0
		public static void joingamememe(string name, string region, string t)
		{
			D2RBGS d2RBGS = new D2RBGS();
			d2RBGS.BGSLoginLocked(region, t, region, D2RBGS.App.D2R);
			d2RBGS.RealmLoginLocked(true);
		}

<<<<<<< HEAD
        // Token: 0x0600BC7F RID: 48255 RVA: 0x0047D0D8 File Offset: 0x0047B2D8
        public static void DupetestTrade(string name, string region, string token, bool isPrimary, uint guid)
        {
            var d2RBGS = new D2RBGS();

            d2RBGS.BGSLoginLocked(region, token, region, D2RBGS.App.D2R);
            d2RBGS.RealmLoginLocked(true);

            // Delete existing characters
            foreach (var charData in d2RBGS.ReadCharacters())
=======
		// Token: 0x0600BC7F RID: 48255 RVA: 0x0047D0D8 File Offset: 0x0047B2D8
		public static void dupetesttrade(string name, string region, string t, bool isPrimary, uint guid)
        {
            var d2RBGS = new D2RBGS();

            // Step 1: Login and setup
            d2RBGS.BGSLoginLocked(region, t, region, D2RBGS.App.D2R);
            d2RBGS.RealmLoginLocked(true);

            // Step 2: Cleanup old characters
            var characters = d2RBGS.ReadCharacters();
            foreach (var charData in characters)
>>>>>>> af1e099f8bc7c618aaccfe1feb2a846143c0312a
            {
                d2RBGS.DeleteCharacter(charData.Id);
            }

<<<<<<< HEAD
            // Create a new character
            var characterResponse = d2RBGS.CreateCharacter($"testing{(isPrimary ? "a" : "b")}", CharacterClass.Sorceress);
            string gameName = "testergo";

            if (!d2RBGS.CreateGame(gameName, gameName, characterResponse.Id, 0U, 1U, true, region == "us" ? "USW1" : "ASZ1"))
            {
                Console.WriteLine("Game creation failed.");
=======
            // Step 3: Create a new character
            var characterName = "testing" + (isPrimary ? "a" : "b");
            var characterResponse = d2RBGS.CreateCharacter(characterName, CharacterClass.Sorceress);

            // Step 4: Create and join a game
            var gameName = "testergo";
            var gameRegion = (region == "us") ? "USW1" : "ASZ1";
            bool gameCreated = d2RBGS.CreateGame(gameName, gameName, characterResponse.Id, 0U, 1U, true, gameRegion);

            if (!gameCreated)
            {
                Console.WriteLine("Failed to create game.");
>>>>>>> af1e099f8bc7c618aaccfe1feb2a846143c0312a
                return;
            }

            var gameJoinResponse = d2RBGS.JoinGame(gameName, gameName, characterResponse.Id, 1U, "");
            if (string.IsNullOrEmpty(gameJoinResponse.IpAddress))
            {
<<<<<<< HEAD
                Console.WriteLine("Game join failed.");
                return;
            }

            Console.WriteLine("Joining game at: " + gameJoinResponse.IpAddress);

			var client = new BattleNetSharp.D2.Resurrected.Client();
            client.Behavior = () =>
            {
                var playerKey = client.GameInstance.Players.First(p => p.Value.Name != $"testing{(isPrimary ? "a" : "b")}").Key;
                var otherPlayers = client.GameInstance.Players.Where(p => p.Value.Name != $"testing{(isPrimary ? "a" : "b")}");

                if (isPrimary)
                {
                    var item = client.GameInstance.Items.Values.First(i => i.baseItem.Type == ItemType.ShortStaff && i.OwnerId == client.me.Id);

                    foreach (var player in otherPlayers)
                    {
                        Console.WriteLine("Initiating trade...");
                        client.SendPacket(new Trade { Guid = guid, TargetId = playerKey });
                        client.WaitForPacket(p => p is TradeRequest);

                        Thread.Sleep(1000);

                        Console.WriteLine("Adding item to trade...");
                        client.SendPacket(new Trade { Guid = guid, TargetId = playerKey, ItemId = item.Id });

                        Thread.Sleep(1000);

                        Console.WriteLine("Confirming trade...");
                        client.SendPacket(new TradeConfirm { Guid = guid, ActionCount = 3U, Action = 1, Lenth = 10 });

                        Thread.Sleep(1000);
                        Program.done++;
                    }
=======
                Console.WriteLine("Failed to join game.");
                return;
            }

            Console.WriteLine($"Joining game at IP: {gameJoinResponse.IpAddress}");

            // Step 5: Initialize game client
            var client = new BattleNetSharp.D2.Resurrected.Client();
            client.Init(gameJoinResponse.Hash.ToByteArray().ToList());
            client.Connect(IPAddress.Parse(gameJoinResponse.IpAddress), 443);

            client.Behavior = () =>
            {
                // Identify the trade target
                var targetPlayer = client.GameInstance.Players
                    .FirstOrDefault(p => p.Value.Name != characterName);

                if (targetPlayer.Equals(default(KeyValuePair<uint, D2GameState.Player>)))
                {
                    Console.WriteLine("No trade target found.");
                    return;
                }

                var itemsOwned = client.GameInstance.Items.Values
                    .Where(i => i.OwnerId == client.myId);

                foreach (var item in itemsOwned)
                {
                    Console.WriteLine($"Item found: {item.baseItem.Type}");
                }

                if (isPrimary)
                {
                    // Find an item to trade
                    var tradeItem = client.GameInstance.Items.Values
                        .FirstOrDefault(i => i.baseItem.Type == ItemType.ShortStaff && i.OwnerId == client.myId);

                    if (tradeItem == null)
                    {
                        Console.WriteLine("No suitable trade item found.");
                        return;
                    }

                    Console.WriteLine("Initiating trade...");
                    client.SendPacket(new Trade
                    {
                        Guid = guid,
                        TargetId = targetPlayer.Value.Id
                    });

                    Console.WriteLine("Waiting for trade confirmation...");
                    client.WaitForPacket(p => p is TradeRequest);

                    Console.WriteLine("Adding item to trade...");
                    client.SendPacket(new Trade
                    {
                        Guid = guid,
                        TargetId = targetPlayer.Value.Id,
                        ItemId = tradeItem.Id
                    });

                    Console.WriteLine("Confirming trade...");
                    client.SendPacket(new TradeConfirm
                    {
                        Guid = guid,
                        ActionCount = 3U,
                        Action = 1,
                        Lenth = 10
                    });
>>>>>>> af1e099f8bc7c618aaccfe1feb2a846143c0312a
                }
                else
                {
                    Console.WriteLine("Waiting for trade request...");
                    TradeRequest tradeRequest = null;
<<<<<<< HEAD

                    client.WaitForPacket(p =>
                    {
                        if (p is TradeRequest tr)
                        {
                            tradeRequest = tr;
                            return true;
                        }
                        return false;
                    });

                    Console.WriteLine("Accepting trade...");
                    client.SendPacket(new Trade { Guid = tradeRequest.Guid, TargetId = playerKey });

                    Thread.Sleep(2000);

                    Console.WriteLine("Confirming trade...");
                    client.SendPacket(new TradeConfirm { Guid = tradeRequest.Guid, ActionCount = 2U, Action = 1, Lenth = 10 });
                }
            };

            client.Init(gameJoinResponse.Hash.ToByteArray().ToList());
            client.Connect(IPAddress.Parse(gameJoinResponse.IpAddress), 443);
=======
                    client.WaitForPacket(p =>
                    {
                        tradeRequest = p as TradeRequest;
                        return tradeRequest != null;
                    });

                    if (tradeRequest == null)
                    {
                        Console.WriteLine("Trade request not received.");
                        return;
                    }

                    Console.WriteLine("Confirming received trade...");
                    client.SendPacket(new Trade
                    {
                        Guid = tradeRequest.Guid,
                        TargetId = targetPlayer.Value.Id
                    });

                    Console.WriteLine("Finalizing trade...");
                    client.SendPacket(new TradeConfirm
                    {
                        Guid = tradeRequest.Guid,
                        ActionCount = 2U,
                        Action = 1,
                        Lenth = 10
                    });
                }
            };
>>>>>>> af1e099f8bc7c618aaccfe1feb2a846143c0312a
        }

        // Token: 0x0600BC80 RID: 48256 RVA: 0x0047D280 File Offset: 0x0047B480
        public static void DeleteChars(string name, string region, string t)
		{
			D2RBGS d2RBGS = new D2RBGS();
			bool flag = d2RBGS.BGSLoginLocked(region, t, name, D2RBGS.App.D2R);
			bool flag2 = !flag;
			if (flag2)
			{
				Console.WriteLine("bgs fail " + name);
			}
			else
			{
				d2RBGS.RealmLoginLocked(true);
				List<CharData> list = d2RBGS.ReadCharacters();
				Console.WriteLine(name + " has " + list.Count.ToString() + " chars to delete");
				foreach (CharData charData in list)
				{
					Console.WriteLine("deleting " + charData.Name + " from " + name);
					d2RBGS.DeleteCharacter(charData.Id);
				}
			}
		}

		// Token: 0x0600BC81 RID: 48257 RVA: 0x0047D360 File Offset: 0x0047B560
		public static void test2(string name, string region, string t)
		{
			D2RBGS d2RBGS = new D2RBGS();
			bool flag = d2RBGS.BGSLoginLocked(region, t, name, D2RBGS.App.D2R);
			bool flag2 = !flag;
			if (flag2)
			{
				Console.WriteLine("bgs fail " + name);
				return;
			}
			d2RBGS.RealmLoginLocked(true);
			List<CharData> list = d2RBGS.ReadCharacters();
			foreach (CharData charData in list)
			{
			}
			uint id = list.First((CharData i) => i.Name == "itemcache").Id;
			string text = "fohzuth2";
			bool flag3 = d2RBGS.CreateGame(text, text, id, 0U, 1U, true, (region == "us") ? "USW1" : "ASZ1");
			GameJoinResponse g = d2RBGS.JoinGame(text, text, id, 1U, "");
			string text2 = "fohzuth";
			uint id2 = list.First((CharData i) => i.Name == "itemcachest").Id;
			BattleNetSharp.D2.Resurrected.Client c = new BattleNetSharp.D2.Resurrected.Client();
			c.Behavior = delegate
			{
				Console.WriteLine("behavior 1 entered for " + region);
				Thread.Sleep(3000);
				c.Terminate();
				Program.done++;
			};
			c.Init(g.Hash.ToByteArray().ToList<byte>());
			Task.Run(delegate
			{
				Thread.Sleep(1750);
				c.Connect(IPAddress.Parse(g.IpAddress), 443);
			});
			GameJoinResponse gameJoinResponse = d2RBGS.JoinGame(text2, text2, id2, 1U, "ICN");
			bool flag4 = g.IpAddress == "";
			if (flag4)
			{
				Console.WriteLine("fail g");
			}
			bool flag5 = gameJoinResponse.IpAddress == "";
			if (flag5)
			{
				Console.WriteLine("fail g4");
			}
			string[] array = new string[9];
			array[0] = "joining : ";
			array[1] = g.IpAddress;
			array[2] = "(";
			int num = 3;
			ByteString hash = g.Hash;
			array[num] = ((hash != null) ? hash.ToString() : null);
			array[4] = ") : ";
			array[5] = gameJoinResponse.IpAddress;
			array[6] = "(";
			int num2 = 7;
			ByteString hash2 = gameJoinResponse.Hash;
			array[num2] = ((hash2 != null) ? hash2.ToString() : null);
			array[8] = ")";
			Console.WriteLine(string.Concat(array));
			BattleNetSharp.D2.Resurrected.Client c2 = new BattleNetSharp.D2.Resurrected.Client();
			c2.Behavior = delegate
			{
				Console.WriteLine("behavior 2 entered for " + region);
				Thread.Sleep(3000);
				c2.Terminate();
				Program.done++;
			};
			c2.Init(gameJoinResponse.Hash.ToByteArray().ToList<byte>());
			for (;;)
			{
				Thread.Sleep(100);
			}
		}

		// Token: 0x0600BC82 RID: 48258 RVA: 0x0047D634 File Offset: 0x0047B834
		public static void dupetest()
		{
			string text = "test";
			string text2 = "us";
			string text3 = "US-69f37872ab1c4664f66d6cbb5ee4717e-854368774";
			D2RBGS d2r = new D2RBGS();
			bool flag = d2r.BGSLoginLocked(text2, text3, text, D2RBGS.App.D2R);
			bool flag2 = !flag;
			if (flag2)
			{
				Console.WriteLine("bgs fail " + text);
				return;
			}
			d2r.RealmLoginLocked(true);
			List<CharData> list = d2r.ReadCharacters();
			uint res = list.First((CharData c) => c.Name == "charone").Id;
			uint id = list.First((CharData i) => i.Name == "chartwo").Id;
			string gm = "sha3";
			int num = 0;
			Program.done = 1;
			List<GameJoinResponse> list2 = (from b in Enumerable.Range(0, 7)
				select d2r.JoinGame(gm, gm, res, 1U, "")).ToList<GameJoinResponse>();
			for (;;)
			{
				while (Program.done % 2 == 0)
				{
					Thread.Sleep(20);
				}
				Program.done++;
				GameJoinResponse gameJoinResponse = list2[num++];
				string[] array = new string[5];
				array[0] = "joining : ";
				array[1] = gameJoinResponse.IpAddress;
				array[2] = "(";
				int num2 = 3;
				ByteString hash = gameJoinResponse.Hash;
				array[num2] = ((hash != null) ? hash.ToString() : null);
				array[4] = ") : ";
				Console.WriteLine(string.Concat(array));
				BattleNetSharp.D2.Resurrected.Client c = new BattleNetSharp.D2.Resurrected.Client();
				c.Behavior = delegate
				{
					Console.WriteLine("found : " + c.GameInstance.Items.Values.Count((ItemAction i) => i.baseItem.Type == ItemType.ShortStaff).ToString());
					ItemAction itemAction = c.GameInstance.Items.Values.FirstOrDefault((ItemAction i) => i.baseItem.Type == ItemType.ShortStaff);
					bool flag3 = itemAction == null;
					if (flag3)
					{
						Console.WriteLine("no ss in game");
					}
					else
					{
						bool flag4 = itemAction.OwnerId > 0U;
						if (flag4)
						{
							Console.WriteLine("drop ss");
							uint id2 = c.me.Id;
							BattleNetSharp.D2.Resurrected.Client c3 = c;
							PickItemFromSharedStash pickItemFromSharedStash = new PickItemFromSharedStash();
							pickItemFromSharedStash.ItemId = itemAction.Id;
							pickItemFromSharedStash.SharedStashId = itemAction.OwnerId;
							pickItemFromSharedStash.X = (ushort)itemAction.x;
							pickItemFromSharedStash.Y = (ushort)itemAction.y;
							c3.SendPacket(pickItemFromSharedStash, (Packet p) => p is OwnedItemAction);
							c.SendPacket(new DropItem
							{
								Id = itemAction.Id
							});
						}
						else
						{
							Console.WriteLine("stash ss");
							uint ownerId = c.GameInstance.Items.Values.FirstOrDefault((ItemAction i) => i.x == 1 && i.y == 1).OwnerId;
							BattleNetSharp.D2.Resurrected.Client c2 = c;
							PickItem pickItem = new PickItem();
							pickItem.Id = itemAction.Id;
							pickItem.ToLocation = PickItem.PickLocation.Cursor;
							pickItem.X = (uint)((ushort)itemAction.x);
							pickItem.Y = (uint)((ushort)itemAction.y);
							c2.SendPacket(pickItem, (Packet p) => p is WorldItemAction);
							c.SendPacket(new WaypointTravelPutSharedStash
							{
								ItemId = itemAction.Id,
								SharedStashId = ownerId,
								X = 5,
								Y = 3
							});
						}
					}
					c.Terminate();
					Program.done++;
				};
				c.Init(gameJoinResponse.Hash.ToByteArray().ToList<byte>());
				c.Connect(IPAddress.Parse(gameJoinResponse.IpAddress), 443);
			}
		}

		// Token: 0x0600BC83 RID: 48259 RVA: 0x0047D83C File Offset: 0x0047BA3C
		public static void CreateProfiles()
		{
			string text = File.ReadAllText("d2bs.ini.template");
			string text2 = "C:\\\\Program Files (x86)\\\\Diablo II\\\\Game.exe";
			while (!File.Exists(text2.Replace("\\\\", "\\")))
			{
				Console.WriteLine("can't find Game.exe path @ " + text2.Replace("\\\\", "\\") + " ..., please drag n drop on this window");
				text2 = Console.ReadLine().Replace("\\", "\\\\").Replace("\"", "");
			}
			string text3 = "{\"Account\":\"replaceaccount\",\"Password\":\"a\",\"Character\":\"replacename\",\"GameName\":\"replacegamename-\",\"GamePass\":\"b84\",\"D2Path\":\"" + text2 + "\",\"Realm\":\"East\",\"Mode\":\"Battle.net\",\"Difficulty\":\"Highest\",\"Parameters\":\"-w -sleepy -ftj -ns -direct\",\"Entry\":\"D2BotLead.dbj\",\"Location\":\"x, y\",\"KeyList\":\"\",\"Schedule\":\"\",\"GameCount\":0,\"Runs\":0,\"Chickens\":0,\"Deaths\":0,\"Crashes\":0,\"Restarts\":0,\"RunsPerKey\":0,\"KeyRuns\":0,\"InfoTag\":\"a,1,0,1\",\"Visible\":false,\"SwitchKeys\":false,\"ScheduleEnable\":false,\"Type\":0,\"Name\":\"replaceprofilename\",\"Group\":\"default\"}";
			string text4 = "\r\n[replaceprofilename]\r\nMode=Battle.net\r\nUsername=replaceaccount\r\nPassword=a\r\ngateway=East\r\ncharacter=replacename\r\nScriptPath=kolbot\r\nDefaultGameScript=default.dbj\r\nDefaultStarterScript=D2BotLead.dbj\r\nspdifficulty=3\r\n";
			List<string> list = new List<string>();
			string[] files = Directory.GetFiles("accounts");
			foreach (string text5 in files)
			{
				string text6 = Program.Part1.OrderBy((string s) => Guid.NewGuid()).First<string>() + Program.Part2.OrderBy((string s) => Guid.NewGuid()).First<string>() + Program.Part3.OrderBy((string s) => Guid.NewGuid()).First<string>();
				bool flag = text6.Length > 14;
				if (flag)
				{
					text6 = text6.Substring(0, 14);
				}
				string text7 = text4.Replace("replaceprofilename", Path.GetFileName(text5).Replace(".", "_")).Replace("replaceaccount", Path.GetFileName(text5)).Replace("replacename", text6);
				text += text7;
				string text8 = text3.Replace("replaceprofilename", Path.GetFileName(text5).Replace(".", "_")).Replace("replaceaccount", Path.GetFileName(text5)).Replace("replacename", text6)
					.Replace("replacegamename", Guid.NewGuid().ToString().Substring(0, 8));
				list.Add(text8);
			}
			File.WriteAllText("d2bs.ini", text);
			File.WriteAllText("profile.json", string.Join(",\n", list));
		}

		// Token: 0x0600BC84 RID: 48260 RVA: 0x0047DAA0 File Offset: 0x0047BCA0
		private static string ObjToQueryString(object obj)
		{
			string text = JsonConvert.SerializeObject(obj);
			IDictionary<string, string> dictionary = JsonConvert.DeserializeObject<IDictionary<string, string>>(text);
			IEnumerable<string> enumerable = dictionary.Select((KeyValuePair<string, string> x) => HttpUtility.UrlEncode(x.Key) + "=" + HttpUtility.UrlEncode(x.Value));
			return string.Join("&", enumerable);
		}

		// Token: 0x0600BC85 RID: 48261 RVA: 0x0047DAF4 File Offset: 0x0047BCF4
		public static string MissingProfiles()
		{
			List<string> list = new List<string> { "fenixgopewpew" };
			foreach (string text in list)
			{
				for (int i = 0; i <= text.Length; i++)
				{
					for (int j = 0; j <= text.Length + 1; j++)
					{
						string text2 = text.Insert(i, ".");
						text2 = text2.Insert(j, ".");
						text2 = text2.Replace("..", ".");
						text2 = text2.Trim('.');
						bool flag = !File.Exists("allaccs\\" + text2);
						if (flag)
						{
							return text2;
						}
					}
				}
			}
			throw new Exception("");
		}

		// Token: 0x0600BC86 RID: 48262 RVA: 0x0047DC08 File Offset: 0x0047BE08
		public static void deleteall()
		{
			string[] files = Directory.GetFiles("allaccs");
			foreach (string text in files)
			{
				try
				{
					D2RBGS d2RBGS = new D2RBGS();
					string text2 = File.ReadAllText(text);
					AccountLink accountLink = JsonConvert.DeserializeObject<AccountLink>(text2);
					Console.WriteLine("login : " + accountLink.BNetEmail);
					d2RBGS.BGSLoginLocked("us", accountLink.BNetToken, accountLink.D2Account, D2RBGS.App.D2R);
					d2RBGS.RealmLoginLocked(true);
					List<CharData> list = d2RBGS.ReadCharacters();
					foreach (CharData charData in list)
					{
						Console.WriteLine("deleting : " + charData.Name + " : " + accountLink.BNetEmail);
						d2RBGS.DeleteCharacter(charData.Id);
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600BC87 RID: 48263 RVA: 0x0047DD24 File Offset: 0x0047BF24
		public static byte[] StringToByteArray(string hex)
		{
			return (from x in Enumerable.Range(0, hex.Length)
				where x % 2 == 0
				select Convert.ToByte(hex.Substring(x, 2), 16)).ToArray<byte>();
		}

		// Token: 0x0600BC88 RID: 48264 RVA: 0x0047DD90 File Offset: 0x0047BF90
		public static void RSATest()
		{
			using (RSA rsa = RSA.Create(2048))
			{
				int num;
				rsa.ImportRSAPrivateKey(new ReadOnlySpan<byte>(Convert.FromBase64String("MIIEpQIBAAKCAQEA4U6z7nkkv4p+EERuTHdmPOWW7ivAmgjGiJTdRac/g8tKMl6gTrBuDhCOk5f/nfqxrD/Wfk5Uxq4cJziOS2x2JUHmCjdLWY+y756n42gnYIBXLODktEyWw7DkHbA7XlTaKJAanX5YYh6CcvjNvHXJ1+lXiWdsNtcwpejjU0sPehisV3NuUE7I9Hl4JhqqQOlRX1cCIW0ZL2ailC+HSVBlPmzAIklF158YYW8PFICnKOyJiT9cc6l8UlRdZ7Z6xmAYJy+LnZnHOXm7I22jZTsFu8JHGJaKhabTfmpq28jqbTT/d+uNUThjnE9Oo4PEdoan/XbNqJyeLvArZhvMkmNsPQIDAQABAoIBAFhP2QcoRNcvGaqWqAUg59oGw9onHB9EQU1XzEN5AtRN4o9Lt9ogHYM1yizf7zmlAe9aNmDboy8dH7vf1yaJJOYFpn1qnwZD5Qc3UOc58/VHWOQmYn6pZo7dzwwz/5FCASDVGxmQZGRRQSB/lWTBZpRSyhT5jNkSD+d4GWKUkURxmtmSx18FdfF7Szx1PKc7RThb7t2L7zSCvPINM2nc3pDv2u9HLOl74gWDPV2+/6J5yVbxVLNqt/tHrYL1Pjg3Aq86UhoyM79G3k+z7YHPkO7z8Cx7BxFxKaUruAWjrPgWx1IYhRqTuLYMGJgrpb13exd5QaZOvYtprudE4dpmJaECgYEA/HwYe39zUbXrV0BC0UG4QmpDHsP5VXoYprwfc2pWlaalDzP9VY7hkVKj+ZqdGFE4O/cE0sEpQ/kANIcZIEzYseZkjg7qIuVU/i6KWZ0y/oM4VdI+6FlZA0CCUTPmWJ0tK//FzwLU5C67JToWV+hO4FsgXlH/J3igCNL7a2S0b9sCgYEA5HG99W3KHaSXkaH93af44xJnxH8RkxIqfb/ia3/HvR5LHuGtzOEWtLoSaPB6RB/r/lD8eYuZstPzXU+Q0yAan9UxWGZhsMBOODolukwWMSvkwk/gpaLvEXlokRJcrwjWe0ih4niOMrbMiqKMdVB1PjJwVavCLdI5jK4yEUzbO8cCgYEArT7VacA9N78VOexNLNrkfSX+4lhkeKNr0NTa284GlW8gaTsqRI/i9V14SGgwDSSF6peHxrlmAE8WNfTRZ9lzAzbsnpFbVRB5bmQu6Gi2Oe9+M10tby8HpfSYtvFeyEUpXryFVZNC00PBhDzEYhN0M/wzTKUE6GeboBJtE/ao3OsCgYEAmRmpp5ynAmrWseGRFEaIxRYGuWg3zQs1swUwp78BjDuLOO0i39ZSs1ipEe9o4dNLBCweqQ7oOTNXPMggVX6EmW32HjqvahfX1FMUCeEIVngGXjvOYPPrqRhm/iMCPsR7ijBJXlBRbKeaOadq3wzHJqIDK0drYe4sZ54vK+0IWO0CgYEAp9XOmjTugUkE7uqaI+Y30qGCgtfVsTu0maKmJbvS7kJQycj/94XBG7Eu7hF4OAVemb+RRL6CM9KMVf15hs7ZFdKZAO6FvVRVo2jGdEu72hn0oqrunbYkBDEQzI5Xza6Bz0hHJcHYN10t7EqWxcWsHb4Dvdyv8r31sRljX9oI058=")), out num);
				rsa.ImportRSAPrivateKey(new ReadOnlySpan<byte>(Convert.FromBase64String("MIIEowIBAAKCAQEAltKXpyL6/usfaSI82mIGu/Pq5gBXMc0PQSR9VCYV3XuFpcuMslt2QhFc92spUOYndWi+76vML0n/H5RnKw5Or9hGGUNw+efXhbwG9qPEywEFlKoWp9Me8JGlJaiowpYTiGdY6UIMXD27A/JqgmOdqTiB7NKapG+eGQK7LPMSb10KRHVQnc+3Re5hySI1fqaATx0F4z6DRmIE4bEds6sDJN/i6z07sWsWolUluufNQ64wlVoIF+qriX8F6TUvmsM66n6owiB8jkPT/khbeNuW3Gz4cHEhPaJMDqyPGQ3MFGT+SLZoVmpXpZMmIzGYQejCdgV6MuDwmXmsTKfY2ykQmQIDAQABAoIBADQjAnetePSsVMRkKIMZhdhtPlNZ5Mp7Z32OXqC7Na3FqHKixbVWNrAqDmgdLEAh/5vvpKl3SvNB8iZ5h5xzqrHQ4pKTJLfO9Ervr7yM6ld+t+4nSgOj0Ls6rcsx3Xy+omvxxeOEiH9Oe5qmrzj5tKOtvAQg3YJgb1eYARpNwJ6sFCeNervgoyoKXb9nv+iCy3gnIOEJ5LkOsDZD+Nn1iMQuOBemg4WkYe7qcAdSbN0H7Y6beFERL0NcsYWepULtJEGP/YvP8sd92OTjRFOvhog26KIk5OabkX04YyxOkmY+S5FAaEiqXkfVFJigRLtl1UrghjlvOiJOXdMbcFwJpZ0CgYEAwoUOT8kQsLhsJJgg6fpTb10o2vpLHR7a/grzyCVOD2SuZ7aKUcoZMm0RWb36lYG/Z+KMx//UFSNE4Pipj212TtAmm2I1woah00LS/xeRMp66vybcr2l1EF1Tl6SzMthMLCLzW9cKRwmOpwn/Kz22jfWPoeDpatOWtDz+alzLQHMCgYEAxn3sYmnJwpN1M4hWLTI72znQid9qjFlGws1tJgeEQaT4zxv9iVgJrajwJOBA6hC6w4Rb1XNXQNdimXA7lvA+DKwzYfrBGjLWMWGn8r+xIMttIFvylXl0nR+I2e5lZLEwuO5hl5ZuWT4/I2ccjnIDh0+c37MSy06H8lDB/g3L48MCgYBICRpJtb42k7WIv8XAoHFxlmBg57wVZq3W0puBDT+hN7nWsqT6sQsvv3BjeZVo9Im7oQxdrIIP6eXCIpQ4h2L+wNrrRC2Agnc/U0nsKgAdbObfjza+xyERFF62k8nBFJTw62iQJEysDgAEIBGdI9eNLtkoK7CFXSI8UTIulXq3vQKBgArAe3OBQ3qUvj6CXhiopfFkGlW9kmnz1A9tTUJIGfPsWcXuQDeWWz/a7NcyhpGnQlag7tCLJOjQQfkJyVCNxu6szUO7b4ZZxpx6K7zMgW3DVy/vix5pq9VvBdy4OynPJ1J9JzAs5+FRq93hEfztVB+aQmcjrhrxMBACK9/1I1w9AoGBAI5bpEpZJKCzoepsaZiOH2TxwJ/JxBDxc63DVwlxZE1i+vm092cytV0zgCNpg25l22JTtax8Lbmt8K8ekFjUxffwyTMiW9uszosj8T3I4YCZL9G7FFHUK4IfXPTou4VRAzGEnvIwW2InVYDWCt+m3mxeMECTltPtJjo+KtJz0vFh")), out num);
				RSAParameters rsaparameters = rsa.ExportParameters(true);
				string text = Convert.ToBase64String(rsaparameters.Modulus);
				string text2 = Convert.ToBase64String(rsaparameters.Exponent);
				Console.WriteLine("");
			}
		}

		// Token: 0x0600BC89 RID: 48265 RVA: 0x0047DE24 File Offset: 0x0047C024
		private static List<List<uint>> GenerateCombinations(uint[] arr)
		{
			List<List<uint>> list = new List<List<uint>>();
			int num = arr.Length;
			for (int i = 1; i <= num; i++)
			{
				uint[] array = new uint[i];
				Program.GenerateCombinationUtil(arr, list, array, 0, num - 1, 0, i);
			}
			return list;
		}

		// Token: 0x0600BC8A RID: 48266 RVA: 0x0047DE70 File Offset: 0x0047C070
		private static void GenerateCombinationUtil(uint[] arr, List<List<uint>> result, uint[] data, int start, int end, int index, int r)
		{
			bool flag = index == r;
			if (flag)
			{
				List<uint> list = new List<uint>(data);
				result.Add(list);
			}
			else
			{
				int num = start;
				while (num <= end && end - num + 1 >= r - index)
				{
					data[index] = arr[num];
					Program.GenerateCombinationUtil(arr, result, data, num + 1, end, index + 1, r);
					num++;
				}
			}
		}

		// Token: 0x0600BC8B RID: 48267 RVA: 0x0047DEDC File Offset: 0x0047C0DC
		public static int LevelFromXp(ulong xp)
		{
			ulong[] array = new ulong[]
			{
				0UL, 500UL, 1500UL, 3750UL, 7875UL, 14175UL, 22680UL, 32886UL, 44396UL, 57715UL,
				72144UL, 90180UL, 112725UL, 140906UL, 176132UL, 220165UL, 275207UL, 344008UL, 430010UL, 537513UL,
				671891UL, 839864UL, 1049830UL, 1312287UL, 1640359UL, 2050449UL, 2563061UL, 3203826UL, 3902260UL, 4663553UL,
				5493363UL, 6397855UL, 7383752UL, 8458379UL, 9629723UL, 10906488UL, 12298162UL, 13815086UL, 15468534UL, 17270791UL,
				19235252UL, 21376515UL, 23710491UL, 26254525UL, 29027522UL, 32050088UL, 35344686UL, 38935798UL, 42850109UL, 47116709UL,
				51767302UL, 56836449UL, 62361819UL, 68384473UL, 74949165UL, 82104680UL, 89904191UL, 98405658UL, 107672256UL, 117772849UL,
				128782495UL, 140783010UL, 153863570UL, 168121381UL, 183662396UL, 200602101UL, 219066380UL, 239192444UL, 261129853UL, 285041630UL,
				311105466UL, 339515048UL, 370481492UL, 404234916UL, 441026148UL, 481128591UL, 524840254UL, 572485967UL, 624419793UL, 681027665UL,
				742730244UL, 809986056UL, 883294891UL, 963201521UL, 1050299747UL, 1145236814UL, 1248718217UL, 1361512946UL, 1484459201UL, 1618470619UL,
				1764543065UL, 1923762030UL, 2097310703UL, 2286478756UL, 2492671933UL, 2717422497UL, 2962400612UL, 3229426756UL, 3520485254UL, 3837739017UL
			};
			int num = 0;
			foreach (ulong num2 in array)
			{
				bool flag = xp >= num2;
				if (!flag)
				{
					break;
				}
				num++;
			}
			return num;
		}

		// Token: 0x0600BC8C RID: 48268 RVA: 0x0047DF34 File Offset: 0x0047C134
		public static void DumpBtags()
		{
			List<int> list = new List<int>
			{
				1403673885, 103436446, 95276619, 466854502, 123538114, 28012176, 131147849, 404329002, 2257194, 107707903,
				80342705, 12794958, 1148902429, 126888073, 78796186, 1128052181, 440310611, 118807417, 84729937, 784822365,
				131022565, 125647367, 50247184, 404836725, 1147316646, 51845405, 12937592, 140739293, 20793980, 772643862,
				87269240, 130056229, 103177319, 130079298, 254755866, 463757893, 403252683, 100545963, 423712267, 80169352,
				806889, 75923478, 267106, 50297068, 448826239, 11717666, 50351101, 86200647, 102427866, 130797689,
				134482086, 2037409, 55176939, 64916390, 121214396, 376753794, 100425192, 391604594, 126047939, 103915618,
				1737167, 250284066, 795711522, 50528123, 55533036, 92160034, 100247216, 100225387, 50548847, 28639936,
				13042685, 477756, 101712912, 78584116, 10278855, 100734074, 1698966, 137841753, 10093293, 53673298,
				107256112, 52133028, 52504219, 15314461, 373627764, 313173564, 78991452, 101166988, 135546894, 54386436,
				72089641, 99606, 1997482, 400645848, 460925, 13710630, 402125531, 13023618, 56779014
			};
			List<Task> list2 = new List<Task>();
			foreach (int num in list)
			{
				list2.Add(Task.Run(delegate
				{
					string text6 = new WebClient().DownloadString("https://localhost:7217/api/" + 1403673885.ToString());
				}));
			}
			Task.WaitAll(list2.ToArray());
			Thread.Sleep(100000);
			string[] array = File.ReadAllLines("C:\\Users\\shalzuth\\Downloads\\BnetAccounts.csv");
			for (int i = 48372; i < array.Length; i++)
			{
				string text = array[i];
				string[] array2 = text.Split(',', StringSplitOptions.TrimEntries);
				bool flag = array2[1].Length == 0;
				if (!flag)
				{
					Console.WriteLine(i);
					string text2 = new WebClient().DownloadString("https://d4armory.io/api/" + array2[0]);
				}
			}
			string[] array3 = File.ReadAllLines("C:\\Users\\shalzuth\\Documents\\GitHub\\BattleNetSharp\\BattleNetSharp\\bin\\Debug\\net6.0\\d2rls13hc.txt");
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			foreach (string text3 in array3)
			{
				string text4 = text3.Split(' ', StringSplitOptions.TrimEntries)[1];
				string text5 = new WebClient().DownloadString("https://d4armory.io/api/" + text4);
				bool flag2 = text5.Contains("invalid game account");
				if (flag2)
				{
					num3++;
				}
				else
				{
					bool flag3 = text5.Contains("no heroes");
					if (flag3)
					{
						num4++;
					}
					else
					{
						int num5 = num4 + 5;
					}
				}
				bool flag4 = num2++ % 100 == 0;
				if (flag4)
				{
					Console.WriteLine(string.Concat(new string[]
					{
						"total parsed ",
						num2.ToString(),
						" | invalid ",
						num3.ToString(),
						" | preorderedNotPlayed ",
						num4.ToString(),
						" | active % ",
						(100f * (float)(num2 - num3 - num4) / (float)num2).ToString()
					}));
				}
			}
			D2RBGS d2RBGS = new D2RBGS();
			d2RBGS.BGSLoginLocked("us", "US-1ad731d36c6705f67170c2c1e67b2794-363984617", "us", D2RBGS.App.D2R);
			StringBuilder stringBuilder = new StringBuilder();
			for (int k = 1; k < 4; k++)
			{
				int num6 = 0;
				uint num7 = 0U;
				bool flag5 = true;
				while (flag5)
				{
					GetRanksByPositionRangeResponse getRanksByPositionRangeResponse = d2RBGS.DumpLeaderboard2(k, num7 * 200U, num7 * 200U + 199U);
					foreach (Rank rank in getRanksByPositionRangeResponse.Ranks)
					{
						bool flag6 = !string.IsNullOrEmpty(rank.BattleTag);
						if (flag6)
						{
							AccountInfo accountInfo = new AccountInfo();
							byte[] array4 = Convert.FromBase64String(rank.Payloade0Pad.Substring(2));
							MessageExtensions.MergeFrom(accountInfo, array4);
							num6++;
							bool flag7 = num6 > 6000;
							if (flag7)
							{
								flag5 = false;
								break;
							}
							stringBuilder.AppendLine(string.Concat(new string[]
							{
								rank.BattleTag,
								" ",
								rank.User.AccountId.ToString(),
								" ",
								rank.User.GameAccountId.ToString(),
								" ",
								accountInfo.CharacterName
							}));
							bool flag8 = accountInfo.Level < 4663553U;
							if (flag8)
							{
								flag5 = false;
								break;
							}
						}
					}
					num7 += 1U;
				}
			}
			File.WriteAllText("d2rls13hc.txt", stringBuilder.ToString());
		}

		// Token: 0x0600BC8D RID: 48269 RVA: 0x0047E80C File Offset: 0x0047CA0C
		public static string GetLeaderboard()
		{
			object leaderboardLock = Program.LeaderboardLock;
			lock (leaderboardLock)
			{
				Program.LeaderboardTime = (DateTime.Now - DateTime.MinValue).Minutes;
				D2RBGS d2RBGS = new D2RBGS();
				d2RBGS.BGSLoginLocked("us", "US-1ad731d36c6705f67170c2c1e67b2794-363984617", "us", D2RBGS.App.D2R);
				d2RBGS.RealmD2RLogin();
				GetRanksByPositionRangeResponse getRanksByPositionRangeResponse = d2RBGS.DumpLeaderboard2(3, 0U, 199U);
				IEnumerable<AccountInfo> enumerable = getRanksByPositionRangeResponse.Ranks.Select(delegate(Rank r)
				{
					AccountInfo accountInfo = new AccountInfo();
					byte[] array = Convert.FromBase64String(r.Payloade0Pad.Substring(2));
					MessageExtensions.MergeFrom(accountInfo, array);
					return accountInfo;
				});
				Program.LeaderboardCache = string.Join("\n", enumerable.Select((AccountInfo c) => c.CharacterName.PadRight(24) + c.Class.PadRight(24) + Program.LevelFromXp((ulong)c.Level).ToString().PadRight(5) + c.Level.ToString()));
			}
			return Program.LeaderboardCache;
		}

		// Token: 0x0600BC8E RID: 48270 RVA: 0x0047E908 File Offset: 0x0047CB08
		public static string GetTZs(out bool isDiff)
		{
			isDiff = false;
			bool flag = (int)(DateTime.Now - DateTime.MinValue).TotalHours == Program.TzTime;
			string text;
			if (flag)
			{
				text = Program.TzCache;
			}
			else
			{
				object tzLock = Program.TzLock;
				lock (tzLock)
				{
					Program.TzCache = "updating";
					Program.TzTime = (int)(DateTime.Now - DateTime.MinValue).TotalHours;
					D2RBGS d2RBGS = new D2RBGS();
					d2RBGS.BGSLoginLocked("us", "US-8fd20836ae9bcf36d24134ed5e287bbf-851225600", "us", D2RBGS.App.D2R);
					d2RBGS.RealmLoginLocked(true);
					TerrorZoneService terrorZoneService = (TerrorZoneService)d2RBGS.RealmConnection.Listeners.Values.First((IServiceListener a) => a is TerrorZoneService);
					while (terrorZoneService.TZs == null)
					{
						Thread.Sleep(100);
					}
					Program.TzCache = string.Join<AreaLevel>(", ", terrorZoneService.TZs.CurrArea.Select((uint a) => (AreaLevel)a));
				}
				isDiff = true;
				text = Program.TzCache;
			}
			return text;
		}

		// Token: 0x0600BC8F RID: 48271 RVA: 0x0047EA6C File Offset: 0x0047CC6C
		public static void StartCloneThread()
		{
			D2RBGS d2r2 = new D2RBGS();
			string text = "US-f729d1a4fdb593e21e376fdfe3f8ae02-1143408201";
			d2r2.BGSLoginLocked("us", text, "us", D2RBGS.App.D2R);
			d2r2.RealmLoginLocked(true);
			DiabloCloneService diabloCloneService = (DiabloCloneService)d2r2.RealmConnection.Listeners.Values.First((IServiceListener a) => a is DiabloCloneService);
			diabloCloneService.WebHook = delegate(DiabloCloneMessage clone)
			{
				Console.WriteLine("success");
			};
			Task.Run(delegate
			{
				for (;;)
				{
					Thread.Sleep(1000);
					Console.WriteLine("us chars : " + d2r2.ReadCharacters().Count.ToString());
				}
			});
			D2RBGS d2r = new D2RBGS();
			string text2 = "US-f729d1a4fdb593e21e376fdfe3f8ae02-1143408201";
			d2r.BGSLoginLocked("eu", text2, "eu", D2RBGS.App.D2R);
			d2r.RealmLoginLocked(true);
			Task.Run(delegate
			{
				for (;;)
				{
					Thread.Sleep(1000);
					Console.WriteLine("eu chars : " + d2r.ReadCharacters().Count.ToString());
				}
			});
			for (;;)
			{
				Thread.Sleep(100);
			}
		}

		// Token: 0x0600BC90 RID: 48272 RVA: 0x0047EB90 File Offset: 0x0047CD90
		public static void testtasdf()
		{
			byte[] array = Convert.FromBase64String("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");
		}

		// Token: 0x0600BC91 RID: 48273 RVA: 0x0047EBAC File Offset: 0x0047CDAC
		public static byte[] WoWDecompress(byte[] input)
		{
			MemoryStream memoryStream = new MemoryStream();
			using (MemoryStream memoryStream2 = new MemoryStream(input))
			{
				using (DeflateStream deflateStream = new DeflateStream(memoryStream2, CompressionMode.Decompress))
				{
					deflateStream.CopyTo(memoryStream);
				}
			}
			return memoryStream.ToArray();
		}

		// Token: 0x0600BC92 RID: 48274 RVA: 0x0047EC18 File Offset: 0x0047CE18
		public static void nexttz()
		{
			D2RBGS d2RBGS = new D2RBGS();
			bool flag = d2RBGS.BGSLoginLocked("us", "US-5a5844f3fc68abfc0e7e9b4a3706e61a-363984617", "us", D2RBGS.App.D2R);
			bool flag2 = !flag;
			if (!flag2)
			{
				bool flag3 = d2RBGS.RealmLoginLocked(true);
				bool flag4 = !flag3;
				if (!flag4)
				{
					TerrorZoneService terrorZoneService = (TerrorZoneService)d2RBGS.RealmConnection.Listeners.Values.First((IServiceListener a) => a is TerrorZoneService);
					terrorZoneService.WebHook = delegate(TerrorZonesMessageRequest tz)
					{
						Console.WriteLine("received tz : " + ((tz != null) ? tz.ToString() : null));
					};
					bool flag5 = terrorZoneService.TZs != null;
					if (flag5)
					{
						terrorZoneService.WebHook(terrorZoneService.TZs);
					}
				}
			}
		}

		// Token: 0x0600BC93 RID: 48275 RVA: 0x0047ECF0 File Offset: 0x0047CEF0
		private static void ParseBytes(byte[] b)
		{
			List<byte> list = b.ToList<byte>();
			while (list.Count > 0)
			{
				int num;
				D4Packet packet = D4Packet.GetPacket(list.ToArray(), null, out num);
				bool flag = packet != null;
				if (flag)
				{
					num = packet.ToArray().Length;
				}
				list = list.Skip(num).ToList<byte>();
			}
		}

		// Token: 0x0600BC94 RID: 48276 RVA: 0x0047ED48 File Offset: 0x0047CF48
		public unsafe static void Main(string[] args)
		{
			bool flag = args.Length != 0 && args[0] == "add";
			if (flag)
			{
				bool flag2 = true;
				string[] files = Directory.GetFiles("add");
				foreach (string text in files)
				{
					string text2 = File.ReadAllText(text);
					AccountLink accountLink = JsonConvert.DeserializeObject<AccountLink>(text2);
					bool flag3 = string.IsNullOrEmpty(accountLink.Password) || accountLink.Password.Contains("k");
					if (flag3)
					{
						accountLink.Password = "Incainca1@IO";
					}
					bool flag4 = accountLink.BNetEmail == "s.leep.ybearpig@protonmail.com";
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = flag2;
						if (!flag5)
						{
							Console.WriteLine(accountLink.BNetEmail);
							string text3 = RestLogin.Login(accountLink.BNetEmail, accountLink.Password, "");
							Console.WriteLine(string.Concat(new string[] { accountLink.BNetEmail, " : ", accountLink.Password, " : ", accountLink.BNetToken }));
							string text4 = accountLink.BNetEmail;
							text4 = text4.Substring(0, text4.IndexOf("@"));
							accountLink.D2Account = text4;
							bool flag6 = string.IsNullOrEmpty(accountLink.Password) || accountLink.Password.Contains("1@IO");
							if (flag6)
							{
								accountLink.Password = "";
							}
							accountLink.BNetToken = text3;
							D2RBGS d2RBGS = new D2RBGS();
							bool flag7 = d2RBGS.BGSLoginLocked("us", text3, "", D2RBGS.App.D2R);
							bool flag8 = !flag7;
							if (flag8)
							{
								Console.WriteLine("bgs fail maybe ban " + text4);
							}
							else
							{
								File.WriteAllText("add2\\" + accountLink.D2Account, JsonConvert.SerializeObject(accountLink));
							}
						}
					}
				}
			}
			else
			{
				bool flag9 = args.Length != 0 && args[0] == "createprofiles";
				if (flag9)
				{
					Program.CreateProfiles();
				}
				else
				{
					bool flag10 = args.Length != 0 && args[0] == "del";
					if (flag10)
					{
						string[] files2 = Directory.GetFiles("del");
						foreach (string text5 in files2)
						{
							string text6 = File.ReadAllText(text5);
							AccountLink accountLink2 = JsonConvert.DeserializeObject<AccountLink>(text6);
							Program.DeleteChars(accountLink2.D2Account, "us", accountLink2.BNetToken);
						}
					}
					else
					{
						bool flag11 = args.Length != 0 && args[0] == "autoplaytest";
						if (flag11)
						{
							D2RBGS d2RBGS2 = new D2RBGS();
							d2RBGS2.BGSLogin("us", "US-c2abfcfae3f67d35846cf3e45f4495e8-821400054", "us", D2RBGS.App.D2R);
							d2RBGS2.RealmD2RLogin();
							for (;;)
							{
								Console.Read();
							}
						}
						else
						{
							Process[] processesByName = Process.GetProcessesByName("Game");
							IEnumerable<Process> enumerable = from p in Process.GetProcessesByName("BattleNetSharp")
								where p.Id != System.Environment.ProcessId
								select p;
							enumerable.ToList<Process>().ForEach(delegate(Process p)
							{
								Thread.Sleep(1000);
								p.Kill();
								Thread.Sleep(1000);
							});
							Program.StartLODClientProxy();
							WebManager.Start();
							bool flag12 = args.Length != 0 && args[0] == "d2rproxy";
							if (flag12)
							{
								D2RBGS.BgsProxyServer();
								TcpListener tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 3724);
								tcpListener.Start();
								for (;;)
								{
									Console.WriteLine("waiting con");
									GameServer gameServer = new GameServer(tcpListener.AcceptTcpClient());
									gameServer.Listen();
								}
							}
							else
							{
								bool flag13 = args.Length != 0 && args[0] == "d4server";
								if (flag13)
								{
									LimboWarpPrefetchBegin limboWarpPrefetchBegin = new LimboWarpPrefetchBegin();
									limboWarpPrefetchBegin.WorldSNO = 69068;
									limboWarpPrefetchBegin.Position = new global::D4Packets.Vector3D
									{
										X = -923.156f,
										Y = 71.1721f,
										Z = 81.3271f
									};
									limboWarpPrefetchBegin.dwPortalType = -1;
									limboWarpPrefetchBegin.som = true;
									LimboWarpPrefetchBegin limboWarpPrefetchBegin2 = new LimboWarpPrefetchBegin();
									Program.StartD4Server();
									for (;;)
									{
										Thread.Sleep(100);
									}
								}
								else
								{
									bool flag14 = args.Length != 0 && args[0] == "d4client";
									if (flag14)
									{
										byte[] array3 = Convert.FromHexString("00 0b 08 00 10 02 18 2c 5d bd b1 dd a3 12 12 09 00 00 00 00 00 00 00 01 11 00 00 00 00 00 00 00 00 1a 15 ba 06 12 12 0d 53 68 61 6c 7a 75 74 68 23 31 36 32 36 32 01 01".Replace(" ", ""));
										ushort num = BitConverter.ToUInt16(array3.Take(2).Reverse<byte>().ToArray<byte>(), 0);
										Bgs.Protocol.Header header = new Bgs.Protocol.Header();
										MessageExtensions.MergeFrom(header, array3.Skip(2).Take((int)num).ToArray<byte>());
										SendInvitationRequest sendInvitationRequest = new SendInvitationRequest();
										MessageExtensions.MergeFrom(sendInvitationRequest, array3.Skip(2).Skip((int)num).ToArray<byte>());
										string text7 = Convert.ToHexString(MessageExtensions.ToByteArray(sendInvitationRequest));
										SendInvitationRequest sendInvitationRequest2 = new SendInvitationRequest();
										sendInvitationRequest2.TargetId = new EntityId
										{
											High = 72057594037927936UL,
											Low = 0UL
										};
										InvitationParams invitationParams = new InvitationParams();
										test test = new test();
										test.TargetBattleTag = "Shalzuth#1626";
										test.Role.Add(new List<uint> { 1U });
										invitationParams.FriendParams = test;
										sendInvitationRequest2.Params = invitationParams;
										string text8 = Convert.ToHexString(MessageExtensions.ToByteArray(sendInvitationRequest2));
										EnterWorld enterWorld = new EnterWorld();
										enterWorld.FromBitReader(new BitReaderD4(Convert.FromHexString("060B000000000004370C0004374CC466CA3D428E570A42A4A3D70000000000")));
										BitReaderD4 bitReaderD = new BitReaderD4(Convert.FromHexString("BF0200000002"));
										int num2 = bitReaderD.ReadInt(11);
										string text9 = "US-c2de95c6b4cd2bdc2e072fd1faf2a500-363984617";
										D2RBGS d2RBGS3 = new D2RBGS();
										d2RBGS3.BGSLogin("us", text9, "us", D2RBGS.App.D4);
										d2RBGS3.RealmD4Login();
										for (;;)
										{
											Thread.Sleep(100);
										}
									}
									else
									{
										bool flag15 = args.Length != 0 && args[0] == "d4maptest";
										if (flag15)
										{
											Dictionary<uint, Scene> dictionary = new Dictionary<uint, Scene>();
											Dictionary<uint, string> dictionary2 = new Dictionary<uint, string>();
											Dictionary<uint, Appearance> dictionary3 = new Dictionary<uint, Appearance>();
											foreach (string text10 in Directory.GetFiles("C:\\Users\\shalzuth\\Downloads\\d4\\staticdata\\Base\\meta\\Appearance\\"))
											{
												bool flag16 = !text10.Contains("Sanctuary_Eastern_Continent_N10_E01");
												if (!flag16)
												{
													Appearance appearance = new Appearance();
													byte[] array4 = File.ReadAllBytes(text10);
													byte[] array5 = File.ReadAllBytes(text10.Replace("meta", "payload"));
													appearance.payloadOffset = array4.Length;
													appearance.FromBitReader(new BitReader(array4.Concat(array5).ToArray<byte>(), 0));
													dictionary3[appearance.Header.SnoId] = appearance;
													Bitmap bitmap = new Bitmap((int)appearance.Data.ptSceneData[0].ptSurfaceGrid[0].dwColumns, (int)appearance.Data.ptSceneData[0].ptSurfaceGrid[0].dwRows);
													for (int l = 0; l < appearance.Data.ptCollisionMeshes.Count; l++)
													{
														List<global::D4Packets.Files.Vector3D> list = new List<global::D4Packets.Files.Vector3D>();
														IEnumerable<Vertice> enumerable2 = appearance.Data.ptCollisionMeshes[l].ptDominoVertices.Take(80);
														IEnumerable<Triangle> enumerable3 = appearance.Data.ptCollisionMeshes[l].ptDominoTriangles.Take(80);
														IEnumerable<Node> enumerable4 = appearance.Data.ptCollisionMeshes[l].ptDominoNodes.Take(80);
														StringBuilder stringBuilder = new StringBuilder();
														for (int m = 0; m < appearance.Data.ptCollisionMeshes[l].ptDominoVertices.Count; m++)
														{
															stringBuilder.AppendLine(string.Concat(new string[]
															{
																"v ",
																appearance.Data.ptCollisionMeshes[l].ptDominoVertices[m].Location.XYZ.X.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoVertices[m].Location.XYZ.Y.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoVertices[m].Location.XYZ.Z.ToString()
															}));
														}
														stringBuilder.AppendLine("vn 0.0 0.0 1.0");
														for (int n = 0; n < appearance.Data.ptCollisionMeshes[l].ptDominoTriangles.Count; n++)
														{
															global::D4Packets.Files.Vector3D xyz = appearance.Data.ptCollisionMeshes[l].ptDominoVertices[appearance.Data.ptCollisionMeshes[l].ptDominoTriangles[n].i1].Location.XYZ;
															global::D4Packets.Files.Vector3D xyz2 = appearance.Data.ptCollisionMeshes[l].ptDominoVertices[appearance.Data.ptCollisionMeshes[l].ptDominoTriangles[n].i2].Location.XYZ;
															global::D4Packets.Files.Vector3D xyz3 = appearance.Data.ptCollisionMeshes[l].ptDominoVertices[appearance.Data.ptCollisionMeshes[l].ptDominoTriangles[n].i3].Location.XYZ;
															float num3 = (xyz2.Y - xyz.Y) * (xyz3.Z - xyz.Z) - (xyz2.Z - xyz.Z) * (xyz3.Y - xyz.Y);
															float num4 = (xyz2.Z - xyz.Z) * (xyz3.X - xyz.X) - (xyz2.X - xyz.X) * (xyz3.Z - xyz.Z);
															float num5 = (xyz2.X - xyz.X) * (xyz3.Y - xyz.Y) - (xyz2.Y - xyz.Y) * (xyz3.X - xyz.X);
															stringBuilder.AppendLine(string.Concat(new string[]
															{
																"vn ",
																num3.ToString(),
																" ",
																num4.ToString(),
																" ",
																num5.ToString()
															}));
														}
														for (int num6 = 0; num6 < appearance.Data.ptCollisionMeshes[l].ptDominoTriangles.Count; num6++)
														{
															stringBuilder.AppendLine(string.Concat(new string[]
															{
																"f ",
																(appearance.Data.ptCollisionMeshes[l].ptDominoTriangles[num6].w1 + 1).ToString(),
																"//1 ",
																(appearance.Data.ptCollisionMeshes[l].ptDominoTriangles[num6].w2 + 1).ToString(),
																"//1 ",
																(appearance.Data.ptCollisionMeshes[l].ptDominoTriangles[num6].w3 + 1).ToString(),
																"//1"
															}));
														}
														File.WriteAllText("testa" + l.ToString() + ".obj", stringBuilder.ToString());
														stringBuilder = new StringBuilder();
														for (int num7 = 0; num7 < appearance.Data.ptCollisionMeshes[l].ptDominoNodes.Count; num7++)
														{
															stringBuilder.AppendLine(string.Concat(new string[]
															{
																"v ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num7].nLowerX.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num7].nLowerY.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num7].nLowerZ.ToString()
															}));
															stringBuilder.AppendLine(string.Concat(new string[]
															{
																"v ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num7].nLowerX.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num7].nUpperY.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num7].nLowerZ.ToString()
															}));
															stringBuilder.AppendLine(string.Concat(new string[]
															{
																"v ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num7].nUpperX.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num7].nLowerY.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num7].nLowerZ.ToString()
															}));
															stringBuilder.AppendLine(string.Concat(new string[]
															{
																"v ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num7].nUpperX.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num7].nUpperY.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num7].nLowerZ.ToString()
															}));
															stringBuilder.AppendLine(string.Concat(new string[]
															{
																"v ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num7].nLowerX.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num7].nLowerY.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num7].nUpperZ.ToString()
															}));
															stringBuilder.AppendLine(string.Concat(new string[]
															{
																"v ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num7].nLowerX.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num7].nUpperY.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num7].nUpperZ.ToString()
															}));
															stringBuilder.AppendLine(string.Concat(new string[]
															{
																"v ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num7].nUpperX.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num7].nLowerY.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num7].nUpperZ.ToString()
															}));
															stringBuilder.AppendLine(string.Concat(new string[]
															{
																"v ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num7].nUpperX.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num7].nUpperY.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num7].nUpperZ.ToString()
															}));
														}
														stringBuilder.AppendLine("vn 0.0 0.0 1.0");
														for (int num8 = 5; num8 < appearance.Data.ptCollisionMeshes[l].ptDominoNodes.Count; num8++)
														{
															stringBuilder.AppendLine(string.Concat(new string[]
															{
																"f ",
																(num8 * 8 + 1).ToString(),
																"//1 ",
																(num8 * 8 + 2).ToString(),
																"//1 ",
																(num8 * 8 + 3).ToString(),
																"//1"
															}));
															stringBuilder.AppendLine(string.Concat(new string[]
															{
																"f ",
																(num8 * 8 + 4).ToString(),
																"//1 ",
																(num8 * 8 + 3).ToString(),
																"//1 ",
																(num8 * 8 + 2).ToString(),
																"//1"
															}));
															stringBuilder.AppendLine(string.Concat(new string[]
															{
																"f ",
																(num8 * 8 + 1).ToString(),
																"//1 ",
																(num8 * 8 + 5).ToString(),
																"//1 ",
																(num8 * 8 + 2).ToString(),
																"//1"
															}));
															stringBuilder.AppendLine(string.Concat(new string[]
															{
																"f ",
																(num8 * 8 + 6).ToString(),
																"//1 ",
																(num8 * 8 + 2).ToString(),
																"//1 ",
																(num8 * 8 + 5).ToString(),
																"//1"
															}));
															stringBuilder.AppendLine(string.Concat(new string[]
															{
																"f ",
																(num8 * 8 + 1).ToString(),
																"//1 ",
																(num8 * 8 + 5).ToString(),
																"//1 ",
																(num8 * 8 + 3).ToString(),
																"//1"
															}));
															stringBuilder.AppendLine(string.Concat(new string[]
															{
																"f ",
																(num8 * 8 + 7).ToString(),
																"//1 ",
																(num8 * 8 + 3).ToString(),
																"//1 ",
																(num8 * 8 + 5).ToString(),
																"//1"
															}));
															stringBuilder.AppendLine(string.Concat(new string[]
															{
																"f ",
																(num8 * 8 + 3).ToString(),
																"//1 ",
																(num8 * 8 + 4).ToString(),
																"//1 ",
																(num8 * 8 + 7).ToString(),
																"//1"
															}));
															stringBuilder.AppendLine(string.Concat(new string[]
															{
																"f ",
																(num8 * 8 + 8).ToString(),
																"//1 ",
																(num8 * 8 + 7).ToString(),
																"//1 ",
																(num8 * 8 + 4).ToString(),
																"//1"
															}));
															stringBuilder.AppendLine(string.Concat(new string[]
															{
																"f ",
																(num8 * 8 + 2).ToString(),
																"//1 ",
																(num8 * 8 + 6).ToString(),
																"//1 ",
																(num8 * 8 + 4).ToString(),
																"//1"
															}));
															stringBuilder.AppendLine(string.Concat(new string[]
															{
																"f ",
																(num8 * 8 + 8).ToString(),
																"//1 ",
																(num8 * 8 + 4).ToString(),
																"//1 ",
																(num8 * 8 + 6).ToString(),
																"//1"
															}));
															stringBuilder.AppendLine(string.Concat(new string[]
															{
																"f ",
																(num8 * 8 + 5).ToString(),
																"//1 ",
																(num8 * 8 + 7).ToString(),
																"//1 ",
																(num8 * 8 + 6).ToString(),
																"//1"
															}));
															stringBuilder.AppendLine(string.Concat(new string[]
															{
																"f ",
																(num8 * 8 + 8).ToString(),
																"//1 ",
																(num8 * 8 + 6).ToString(),
																"//1 ",
																(num8 * 8 + 7).ToString(),
																"//1"
															}));
														}
														File.WriteAllText("testa" + l.ToString() + ".obj", stringBuilder.ToString());
														stringBuilder = new StringBuilder();
														for (int num9 = 0; num9 < appearance.Data.ptCollisionMeshes[l].ptDominoNodes.Count; num9++)
														{
															stringBuilder.AppendLine(string.Concat(new string[]
															{
																"v ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num9].nLowerX.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num9].nLowerY.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num9].nLowerZ.ToString()
															}));
															stringBuilder.AppendLine(string.Concat(new string[]
															{
																"v ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num9].nLowerX.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num9].nUpperY.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num9].nLowerZ.ToString()
															}));
															stringBuilder.AppendLine(string.Concat(new string[]
															{
																"v ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num9].nUpperX.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num9].nLowerY.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num9].nLowerZ.ToString()
															}));
															stringBuilder.AppendLine(string.Concat(new string[]
															{
																"v ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num9].nUpperX.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num9].nUpperY.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num9].nLowerZ.ToString()
															}));
															stringBuilder.AppendLine(string.Concat(new string[]
															{
																"v ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num9].nLowerX.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num9].nLowerY.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num9].nUpperZ.ToString()
															}));
															stringBuilder.AppendLine(string.Concat(new string[]
															{
																"v ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num9].nLowerX.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num9].nUpperY.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num9].nUpperZ.ToString()
															}));
															stringBuilder.AppendLine(string.Concat(new string[]
															{
																"v ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num9].nUpperX.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num9].nLowerY.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num9].nUpperZ.ToString()
															}));
															stringBuilder.AppendLine(string.Concat(new string[]
															{
																"v ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num9].nUpperX.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num9].nUpperY.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num9].nUpperZ.ToString()
															}));
														}
														stringBuilder.AppendLine("vn 0.0 0.0 1.0");
														for (int num10 = 0; num10 < appearance.Data.ptCollisionMeshes[l].ptDominoNodes.Count; num10++)
														{
															stringBuilder.AppendLine("n " + string.Concat(new string[]
															{
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num10].nLowerX.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num10].nLowerY.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num10].nLowerZ.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num10].nUpperX.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num10].nUpperY.ToString(),
																" ",
																appearance.Data.ptCollisionMeshes[l].ptDominoNodes[num10].nUpperZ.ToString()
															}).Replace(".", ","));
														}
														File.WriteAllText("testc" + l.ToString() + ".obj", stringBuilder.ToString());
														float num11 = 0.65f;
														stringBuilder = new StringBuilder();
														ushort num12 = appearance.Data.ptSceneData[0].ptSurfaceGrid[0].grid.FindAll((ushort a) => a != ushort.MaxValue).Max<ushort>();
														ushort num13 = appearance.Data.ptSceneData[0].ptSurfaceGrid[0].grid.Min<ushort>();
														int num14 = 0;
														while ((long)num14 < (long)((ulong)appearance.Data.ptSceneData[0].ptSurfaceGrid[0].dwRows))
														{
															int num15 = 0;
															while ((long)num15 < (long)((ulong)appearance.Data.ptSceneData[0].ptSurfaceGrid[0].dwColumns))
															{
																float num16 = (float)num15 * num11;
																float num17 = (float)num14 * num11;
																ushort num18 = appearance.Data.ptSceneData[0].ptSurfaceGrid[0].grid[num15 + num14 * (int)appearance.Data.ptSceneData[0].ptSurfaceGrid[0].dwColumns];
																bool flag17 = num18 == ushort.MaxValue;
																if (flag17)
																{
																	num18 = 0;
																}
																float num19 = appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].fields[(int)num18].height / 100f;
																stringBuilder.AppendLine(string.Concat(new string[]
																{
																	"v ",
																	num16.ToString(),
																	" ",
																	num17.ToString(),
																	" ",
																	num19.ToString()
																}));
																stringBuilder.AppendLine(string.Concat(new string[]
																{
																	"v ",
																	num16.ToString(),
																	" ",
																	(num17 + num11).ToString(),
																	" ",
																	num19.ToString()
																}));
																stringBuilder.AppendLine(string.Concat(new string[]
																{
																	"v ",
																	(num16 + num11).ToString(),
																	" ",
																	num17.ToString(),
																	" ",
																	num19.ToString()
																}));
																stringBuilder.AppendLine(string.Concat(new string[]
																{
																	"v ",
																	(num16 + num11).ToString(),
																	" ",
																	(num17 + num11).ToString(),
																	" ",
																	num19.ToString()
																}));
																num15++;
															}
															num14++;
														}
														int num20 = 0;
														while ((long)num20 < (long)((ulong)appearance.Data.ptSceneData[0].ptSurfaceGrid[0].dwRows))
														{
															int num21 = 0;
															while ((long)num21 < (long)((ulong)appearance.Data.ptSceneData[0].ptSurfaceGrid[0].dwColumns))
															{
																stringBuilder.AppendLine(string.Concat(new string[]
																{
																	"f ",
																	(((long)num20 * (long)((ulong)appearance.Data.ptSceneData[0].ptSurfaceGrid[0].dwColumns) + (long)num21) * 4L + 1L).ToString(),
																	"//1 ",
																	(((long)num20 * (long)((ulong)appearance.Data.ptSceneData[0].ptSurfaceGrid[0].dwColumns) + (long)num21) * 4L + 2L).ToString(),
																	"//1 ",
																	(((long)num20 * (long)((ulong)appearance.Data.ptSceneData[0].ptSurfaceGrid[0].dwColumns) + (long)num21) * 4L + 3L).ToString(),
																	"//1"
																}));
																stringBuilder.AppendLine(string.Concat(new string[]
																{
																	"f ",
																	(((long)num20 * (long)((ulong)appearance.Data.ptSceneData[0].ptSurfaceGrid[0].dwColumns) + (long)num21) * 4L + 4L).ToString(),
																	"//1 ",
																	(((long)num20 * (long)((ulong)appearance.Data.ptSceneData[0].ptSurfaceGrid[0].dwColumns) + (long)num21) * 4L + 3L).ToString(),
																	"//1 ",
																	(((long)num20 * (long)((ulong)appearance.Data.ptSceneData[0].ptSurfaceGrid[0].dwColumns) + (long)num21) * 4L + 2L).ToString(),
																	"//1"
																}));
																num21++;
															}
															num20++;
														}
														File.WriteAllText("testd" + l.ToString() + ".obj", stringBuilder.ToString());
														IEnumerable<CollisionHeightField> enumerable5 = appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].fields.DistinctBy((CollisionHeightField f) => f.gameFlags);
														num11 = appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.cellWidth;
														stringBuilder = new StringBuilder();
														int num22 = 0;
														while ((long)num22 < (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countY))
														{
															int num23 = 0;
															while ((long)num23 < (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX))
															{
																float num24 = (float)num22 * num11;
																float num25 = (float)num23 * num11;
																CollisionHeightField collisionHeightField = appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].fields[num23 + num22 * (int)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX];
																float num26 = appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].fields[num23 + num22 * (int)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX].height / 100f;
																stringBuilder.AppendLine(string.Concat(new string[]
																{
																	"v ",
																	num24.ToString(),
																	" ",
																	num25.ToString(),
																	" ",
																	num26.ToString()
																}));
																stringBuilder.AppendLine(string.Concat(new string[]
																{
																	"v ",
																	num24.ToString(),
																	" ",
																	(num25 + num11).ToString(),
																	" ",
																	num26.ToString()
																}));
																stringBuilder.AppendLine(string.Concat(new string[]
																{
																	"v ",
																	(num24 + num11).ToString(),
																	" ",
																	num25.ToString(),
																	" ",
																	num26.ToString()
																}));
																stringBuilder.AppendLine(string.Concat(new string[]
																{
																	"v ",
																	(num24 + num11).ToString(),
																	" ",
																	(num25 + num11).ToString(),
																	" ",
																	num26.ToString()
																}));
																num23++;
															}
															num22++;
														}
														int num27 = 0;
														while ((long)num27 < (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countY))
														{
															int num28 = 0;
															while ((long)num28 < (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX))
															{
																CollisionHeightField collisionHeightField2 = appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].fields[num28 + num27 * (int)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX];
																bool flag18 = collisionHeightField2.gameFlags != 1024;
																if (!flag18)
																{
																	stringBuilder.AppendLine(string.Concat(new string[]
																	{
																		"f ",
																		(((long)num27 * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)num28) * 4L + 1L).ToString(),
																		"//1 ",
																		(((long)num27 * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)num28) * 4L + 2L).ToString(),
																		"//1 ",
																		(((long)num27 * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)num28) * 4L + 3L).ToString(),
																		"//1"
																	}));
																	stringBuilder.AppendLine(string.Concat(new string[]
																	{
																		"f ",
																		(((long)num27 * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)num28) * 4L + 4L).ToString(),
																		"//1 ",
																		(((long)num27 * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)num28) * 4L + 3L).ToString(),
																		"//1 ",
																		(((long)num27 * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)num28) * 4L + 2L).ToString(),
																		"//1"
																	}));
																}
																num28++;
															}
															num27++;
														}
														File.WriteAllText("teste" + l.ToString() + ".obj", stringBuilder.ToString());
														num11 = appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.cellWidth;
														stringBuilder = new StringBuilder();
														Dictionary<int, Vector3> dictionary4 = new Dictionary<int, Vector3>();
														int num29 = 0;
														while ((long)num29 < (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countY))
														{
															int num30 = 0;
															while ((long)num30 < (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX))
															{
																float num31 = (float)num29 * num11 + num11 / 2f;
																float num32 = (float)num30 * num11 + num11 / 2f;
																CollisionHeightField collisionHeightField3 = appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].fields[num30 + num29 * (int)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX];
																float num33 = appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].fields[num30 + num29 * (int)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX].height / 100f;
																stringBuilder.AppendLine(string.Concat(new string[]
																{
																	"v ",
																	num31.ToString(),
																	" ",
																	num32.ToString(),
																	" ",
																	num33.ToString()
																}));
																dictionary4.Add(num30 + num29 * (int)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX, new Vector3
																{
																	X = num31,
																	Y = num32,
																	Z = num33
																});
																num30++;
															}
															num29++;
														}
														int num34 = 1;
														while ((long)num34 < (long)((ulong)(appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countY - 1U)))
														{
															int num35 = 1;
															while ((long)num35 < (long)((ulong)(appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX - 1U)))
															{
																CollisionHeightField collisionHeightField4 = appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].fields[num35 + num34 * (int)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX];
																bool flag19 = collisionHeightField4.gameFlags != 1024;
																if (!flag19)
																{
																	stringBuilder.AppendLine(string.Concat(new string[]
																	{
																		"f ",
																		((long)num34 * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)num35 + 1L).ToString(),
																		"//1 ",
																		((long)(num34 + 1) * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)num35 + 1L).ToString(),
																		"//1 ",
																		((long)(num34 + 1) * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)(num35 + 1) + 1L).ToString(),
																		"//1"
																	}));
																	stringBuilder.AppendLine(string.Concat(new string[]
																	{
																		"f ",
																		((long)num34 * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)num35 + 1L).ToString(),
																		"//1 ",
																		((long)(num34 + 1) * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)(num35 + 1) + 1L).ToString(),
																		"//1 ",
																		((long)num34 * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)(num35 + 1) + 1L).ToString(),
																		"//1"
																	}));
																	stringBuilder.AppendLine(string.Concat(new string[]
																	{
																		"f ",
																		((long)num34 * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)num35 + 1L).ToString(),
																		"//1 ",
																		((long)num34 * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)(num35 + 1) + 1L).ToString(),
																		"//1 ",
																		((long)(num34 - 1) * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)(num35 + 1) + 1L).ToString(),
																		"//1"
																	}));
																	stringBuilder.AppendLine(string.Concat(new string[]
																	{
																		"f ",
																		((long)num34 * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)num35 + 1L).ToString(),
																		"//1 ",
																		((long)(num34 - 1) * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)(num35 + 1) + 1L).ToString(),
																		"//1 ",
																		((long)(num34 - 1) * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)num35 + 1L).ToString(),
																		"//1"
																	}));
																	stringBuilder.AppendLine(string.Concat(new string[]
																	{
																		"f ",
																		((long)num34 * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)num35 + 1L).ToString(),
																		"//1 ",
																		((long)(num34 - 1) * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)num35 + 1L).ToString(),
																		"//1 ",
																		((long)(num34 - 1) * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)(num35 - 1) + 1L).ToString(),
																		"//1"
																	}));
																	stringBuilder.AppendLine(string.Concat(new string[]
																	{
																		"f ",
																		((long)num34 * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)num35 + 1L).ToString(),
																		"//1 ",
																		((long)(num34 - 1) * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)(num35 - 1) + 1L).ToString(),
																		"//1 ",
																		((long)num34 * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)(num35 - 1) + 1L).ToString(),
																		"//1"
																	}));
																	stringBuilder.AppendLine(string.Concat(new string[]
																	{
																		"f ",
																		((long)num34 * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)num35 + 1L).ToString(),
																		"//1 ",
																		((long)num34 * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)(num35 - 1) + 1L).ToString(),
																		"//1 ",
																		((long)(num34 + 1) * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)(num35 - 1) + 1L).ToString(),
																		"//1"
																	}));
																	stringBuilder.AppendLine(string.Concat(new string[]
																	{
																		"f ",
																		((long)num34 * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)num35 + 1L).ToString(),
																		"//1 ",
																		((long)(num34 + 1) * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)(num35 - 1) + 1L).ToString(),
																		"//1 ",
																		((long)(num34 + 1) * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)num35 + 1L).ToString(),
																		"//1"
																	}));
																}
																num35++;
															}
															num34++;
														}
														File.WriteAllText("testf" + l.ToString() + ".obj", stringBuilder.ToString());
													}
													IEnumerable<ushort> enumerable6 = appearance.Data.ptSceneData[0].ptSurfaceGrid[0].grid.Distinct<ushort>();
													float num36 = appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].fields.Max((CollisionHeightField a) => a.height);
													float num37 = appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].fields.Min((CollisionHeightField a) => a.height);
													float num38 = num36 - num37;
													int num39 = 0;
													while ((long)num39 < (long)((ulong)appearance.Data.ptSceneData[0].ptSurfaceGrid[0].dwRows))
													{
														int num40 = 0;
														while ((long)num40 < (long)((ulong)appearance.Data.ptSceneData[0].ptSurfaceGrid[0].dwColumns))
														{
															ushort num41 = appearance.Data.ptSceneData[0].ptSurfaceGrid[0].grid[num40 + num39 * (int)appearance.Data.ptSceneData[0].ptSurfaceGrid[0].dwColumns];
															bool flag20 = num41 == ushort.MaxValue;
															if (flag20)
															{
																num41 = (ushort)(appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].fields.Count - 1);
															}
															num41 = (ushort)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].fields[(int)num41].height;
															num41 = (ushort)(255f * ((float)num41 - num37) / num38);
															int num42 = (int)(num41 & 255);
															int num43 = (128 * (num41 >> 8)) & 255;
															int num44 = (num41 >> 16) & 255;
															bool flag21 = num41 == ushort.MaxValue;
															if (flag21)
															{
																num43 = (num42 = (num44 = 255));
															}
															byte b = (byte)(255f * ((float)appearance.Data.ptSceneData[0].ptSurfaceGrid[0].grid[num40 + num39 * (int)appearance.Data.ptSceneData[0].ptSurfaceGrid[0].dwColumns] / 65535f));
															bitmap.SetPixel(bitmap.Width - num40 - 1, num39, Color.FromArgb(num42, num43, num44));
															num40++;
														}
														Console.WriteLine("");
														num39++;
													}
													bitmap.Save("test2.bmp");
													foreach (Node node in appearance.Data.ptCollisionMeshes[0].ptDominoNodes)
													{
														bool flag22 = node.dwAxis == 4;
														if (flag22)
														{
															Console.WriteLine("n " + string.Concat(new string[]
															{
																node.nLowerX.ToString(),
																" ",
																node.nLowerY.ToString(),
																" ",
																node.nLowerZ.ToString(),
																" ",
																node.nUpperX.ToString(),
																" ",
																node.nUpperY.ToString(),
																" ",
																node.nUpperZ.ToString()
															}).Replace(".", ","));
														}
													}
													Console.WriteLine(appearance.Header.SnoId.ToString("X") + " : " + text10);
												}
											}
											foreach (string text11 in Directory.GetFiles("C:\\Users\\shalzuth\\Downloads\\Base\\meta\\Scene\\"))
											{
												bool flag23 = !text11.Contains("Sanctuary_Eastern_Continent_N10_E01");
												if (!flag23)
												{
													bool flag24 = !text11.Contains("Sanctuary_Eastern_Continent");
													if (!flag24)
													{
														Scene scene = new Scene();
														byte[] array6 = File.ReadAllBytes(text11);
														scene.FromBitReader(new BitReader(array6, 0));
														dictionary[scene.Header.SnoId] = scene;
														dictionary2[scene.Header.SnoId] = Path.GetFileNameWithoutExtension(text11);
														foreach (AICellData aicellData in scene.ptAIPathData[0].m_cellData)
														{
															Console.WriteLine(string.Concat(new string[]
															{
																aicellData.u3.ToString("X"),
																" : ",
																aicellData.aabb1.wp.X.ToString(),
																" ",
																aicellData.aabb1.wp.Y.ToString(),
																", ",
																aicellData.aabb1.wvExt.X.ToString(),
																" ",
																aicellData.aabb1.wvExt.Y.ToString(),
																", ",
																aicellData.aabb2.wp.X.ToString(),
																" ",
																aicellData.aabb2.wp.Y.ToString(),
																", ",
																aicellData.aabb2.wvExt.X.ToString(),
																" ",
																aicellData.aabb2.wvExt.Y.ToString(),
																" : ",
																aicellData.m_cellId.ToString("X"),
																" : ",
																aicellData.m_cellIdx.ToString("X")
															}));
														}
														Console.WriteLine(string.Concat(new string[]
														{
															scene.Header.SnoId.ToString("X"),
															" : ",
															text11,
															" : ",
															scene.snoAppearance.ToString("X")
														}));
													}
												}
											}
											byte[] array7 = File.ReadAllBytes("C:\\Users\\shalzuth\\Downloads\\Base\\meta\\World\\Sanctuary_Eastern_Continent.wrl");
											World world = new World();
											world.FromBitReader(new BitReader(array7, 0));
											foreach (SceneChunk sceneChunk in world.ptServerData[0].ptSceneChunks)
											{
												Console.WriteLine(string.Concat(new string[]
												{
													sceneChunk.snoname.ToString("X"),
													" : ",
													sceneChunk.transform.wp.X.ToString(),
													", ",
													sceneChunk.transform.wp.Y.ToString(),
													", ",
													sceneChunk.transform.wp.Z.ToString(),
													" : ",
													sceneChunk.transform.q.XYZ.X.ToString(),
													", ",
													sceneChunk.transform.q.XYZ.Y.ToString(),
													", ",
													sceneChunk.transform.q.XYZ.Z.ToString(),
													" : ",
													dictionary2[sceneChunk.snoname]
												}));
											}
											D3Scene d3Scene = new D3Scene();
											d3Scene.FromBitReader(new BitReader(File.ReadAllBytes("C:\\Users\\shalzuth\\Downloads\\a1dun_Leor_NSW_02.scn"), 0));
											foreach (NavCell navCell in d3Scene.aaaa)
											{
												bool flag25 = (navCell.flags & 1) == 1;
												if (flag25)
												{
													Console.WriteLine("n " + string.Concat(new string[]
													{
														navCell.grid.wp.X.ToString(),
														" ",
														navCell.grid.wp.Y.ToString(),
														" ",
														1.ToString(),
														" ",
														navCell.grid.wvExt.X.ToString(),
														" ",
														navCell.grid.wvExt.Y.ToString(),
														" ",
														1.ToString()
													}).Replace(".", ","));
												}
											}
										}
										bool flag26 = args.Length != 0 && args[0] == "wowclient";
										if (flag26)
										{
											byte[] array8 = Convert.FromHexString("00-00-00-00-80-00-00-00-00-07-00-00-00-00-00-00-00-08-08-00-00-00-00-1B-00-00-00-00-00-00-00-01-00-00-00-A4-2D-ED-63-00-00-00-00-01-09-00-00-00-01-00-00-00-02-00-00-00-04-00-00-00-05-00-00-00-08-00-00-00-09-00-00-00-06-02-00-02-03-00-00-00-0A-04-00-04-08-0A-00-00-00-01-00-00-00-04-00-00-00-03-00-00-00-05-00-00-00-07-00-00-00-08-00-00-00-06-02-00-02-0B-00-00-00-09-00-00-00-0A-04-00-04-0B-09-00-00-00-01-00-00-00-02-00-00-00-03-00-00-00-05-00-00-00-08-00-00-00-07-00-00-00-06-02-00-02-0A-04-00-04-04-00-00-00-0A-0A-00-00-00-03-00-00-00-04-00-00-00-05-00-00-00-08-00-00-00-09-00-00-00-02-00-00-00-06-02-00-02-01-00-00-00-0A-04-00-04-0C-00-00-00-04-09-00-00-00-01-00-00-00-03-00-00-00-04-00-00-00-05-00-00-00-0B-00-00-00-06-02-00-02-08-00-00-00-0A-04-00-04-0C-00-00-00-03-0A-00-00-00-01-00-00-00-02-00-00-00-03-00-00-00-05-00-00-00-04-00-00-00-06-02-00-02-08-00-00-00-07-00-00-00-09-00-00-00-0A-04-00-04-19-08-00-00-00-01-00-00-00-07-00-00-00-04-00-00-00-05-00-00-00-0A-04-00-04-08-00-00-00-03-00-00-00-06-02-08-02-06-0A-00-00-00-01-00-00-00-03-00-00-00-07-00-00-00-0B-00-00-00-06-02-00-02-05-00-00-00-02-00-00-00-0A-04-00-04-08-00-00-00-04-00-00-00-05-08-00-00-00-01-00-00-00-04-00-00-00-05-00-00-00-08-00-00-00-09-00-00-00-06-02-00-02-03-00-00-00-0A-04-00-04-02-09-00-00-00-01-00-00-00-03-00-00-00-04-00-00-00-07-00-00-00-09-00-00-00-06-02-00-02-08-00-00-00-0A-04-00-04-05-00-00-00-07-08-00-00-00-01-00-00-00-04-00-00-00-08-00-00-00-09-00-00-00-06-02-00-02-05-00-00-00-0A-04-00-04-03-00-00-00-1F-0A-00-00-00-07-07-07-00-0B-07-07-00-03-07-07-00-08-07-07-00-05-07-07-00-04-07-07-00-01-07-07-00-0A-07-07-04-02-07-07-00-06-07-08-02-09-08-00-00-00-06-02-00-02-03-00-00-00-08-00-00-00-05-00-00-00-04-00-00-00-07-00-00-00-09-00-00-00-01-00-00-00-20-09-00-00-00-01-07-07-00-03-07-07-00-04-07-07-00-05-07-07-00-08-07-07-00-07-07-07-00-0B-07-07-00-0A-07-07-04-06-07-08-02-1E-07-00-00-00-02-06-07-00-03-06-07-00-08-06-07-00-05-06-07-00-01-06-07-00-06-06-08-02-04-06-07-00-1C-09-00-00-00-03-06-07-00-0B-06-07-00-07-06-07-00-01-06-07-00-0A-06-07-04-06-06-08-02-08-06-07-00-04-06-07-00-05-06-07-00-1B-08-00-00-00-08-06-07-00-03-06-07-00-0A-06-07-04-05-06-07-00-04-06-07-00-09-06-07-00-01-06-07-00-06-06-08-02-16-08-00-00-00-06-02-00-02-0B-00-00-00-03-00-00-00-08-00-00-00-04-00-00-00-05-00-00-00-09-00-00-00-01-00-00-00-22-0A-00-00-00-01-07-07-00-03-07-07-00-08-07-07-00-0A-07-07-04-02-07-07-00-05-07-07-00-04-07-07-00-07-07-07-00-09-07-07-00-06-07-08-02-23-09-00-00-00-01-07-07-00-04-07-07-00-0A-07-07-04-03-07-07-00-05-07-07-00-08-07-07-00-09-07-07-00-07-07-07-00-06-07-08-02-24-08-00-00-00-01-07-07-00-03-07-07-00-08-07-07-00-0A-07-07-04-05-07-07-00-04-07-07-00-07-07-07-00-06-07-08-02-18-08-00-00-00-03-00-00-00-08-00-00-00-0A-04-00-04-05-00-00-00-04-00-00-00-07-00-00-00-01-00-00-00-06-02-08-02-1A-08-00-00-00-01-00-00-00-03-00-00-00-04-00-00-00-05-00-00-00-07-00-00-00-08-00-00-00-0A-04-00-04-06-02-08-02-1D-08-00-00-00-08-06-07-00-09-06-07-00-03-06-07-00-0A-06-07-04-05-06-07-00-04-06-07-00-01-06-07-00-06-06-08-02-46-01-00-00-00-0D-08-09-08-34-01-00-00-00-0D-08-09-08-25-08-00-00-00-01-07-07-00-04-07-07-00-0A-07-07-04-03-07-07-00-05-07-07-00-08-07-07-00-09-07-07-00-06-07-08-02-00-05-00-00-00-00-00-00-00-05-00-00-00-00-19-00-03-01-81-C1-C0-41-65-67-77-79-6E-6E-41-65-67-77-79-6E-6E-07-00-01-01-02-42-40-47-75-72-75-62-61-73-68-69-47-75-72-75-62-61-73-68-69-15-00-01-01-02-82-80-42-6F-6E-65-63-68-65-77-65-72-42-6F-6E-65-63-68-65-77-65-72-1F-00-03-01-01-81-80-48-61-6B-6B-61-72-48-61-6B-6B-61-72-28-00-06-01-01-C1-C0-47-61-72-72-6F-73-68-47-61-72-72-6F-73-68-1F-00-01-01-02-C2-C0-44-61-67-67-65-72-73-70-69-6E-65-44-61-67-67-65-72-73-70-69-6E-65-2D-00-03-01-45-04-80-49-6E-74-65-72-6E-61-6C-20-52-65-63-6F-72-64-20-33-36-37-37-49-6E-74-65-72-6E-61-6C-52-65-63-6F-72-64-33-36-37-37".Replace("-", ""));
											new AuthResponse().Bytes = array8;
											byte[] array9 = new PlayerLogin
											{
												Guid = Guid.Parse("07f95510-0000-0000-0000-000000c01108"),
												FarClip = 1806f
											}.ToArray();
<<<<<<< HEAD
// [Ares] strange, should recover
//											float num46 = BitConverter.ToSingle(new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.BDE5E36B42FB3B788FAF44D3F692450F961FFF2D2A1A261C0DC02866EFFAFBFC), 4));
=======

                                            // float num46 = BitConverter.ToSingle(new ReadOnlySpan<byte>((void*)(&< PrivateImplementationDetails >.BDE5E36B42FB3B788FAF44D3F692450F961FFF2D2A1A261C0DC02866EFFAFBFC), 4));
>>>>>>> af1e099f8bc7c618aaccfe1feb2a846143c0312a
											string text12 = "US-9aa39c5d77f8b8321383eaf00050fd9a-363984617";
											D2RBGS d2RBGS4 = new D2RBGS();
											d2RBGS4.BGSLogin("us", text12, "us", D2RBGS.App.WoW);
											d2RBGS4.RealmWowLogin();
											for (;;)
											{
												Thread.Sleep(100);
											}
										}
										else
										{
											bool flag27 = args.Length != 0 && args[0] == "wowproxy";
											if (flag27)
											{
												TcpListener tcpListener2 = new TcpListener(IPAddress.Parse("127.0.0.1"), 1119);
												tcpListener2.Start();
												for (;;)
												{
													Console.WriteLine("waiting con");
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

		// Token: 0x0600BC95 RID: 48277 RVA: 0x00482D98 File Offset: 0x00480F98
		public static void StartLODClientProxy()
		{
			Task.Run(delegate
			{
				global::DiabloBridge.Server server = new global::DiabloBridge.Server();
				server.Listen(IPAddress.Any);
			});
		}

		// Token: 0x0600BC96 RID: 48278 RVA: 0x00482DC0 File Offset: 0x00480FC0
		public static void StartD4Server()
		{
			byte[] array = Convert.FromBase64String("AAsIABABGAFdFoIvwAjuypkCEgRXbjY0GgRlblVTIJezAlItCitVUy1jNGMxMWUxNGQ1YTMyMDEyYTE2MWFhMDc3ZGQwZTU3Zi0xMDc2NTYw");
			ushort num = BitConverter.ToUInt16(array.Take(2).Reverse<byte>().ToArray<byte>(), 0);
			byte[] array2 = array.Skip(2).Skip((int)num).ToArray<byte>();
			string text = Convert.ToBase64String(array2);
			D2RBGS.BgsServer();
			TcpListener GameServer = new TcpListener(IPAddress.Parse("127.0.0.2"), 3724);
			GameServer.Start();
			Task.Run(delegate
			{
				for (;;)
				{
					Console.WriteLine("waiting con");
					BattleNetSharp.D4.Server server = new BattleNetSharp.D4.Server(GameServer.AcceptTcpClient());
					server.Listen();
				}
			});
		}

		// Token: 0x04009146 RID: 37190
		private static int done = 0;

		// Token: 0x04009147 RID: 37191
		public static string[] Part1 = new string[]
		{
			"Strum", "Halo", "Car", "Heva", "Men", "Gre", "Deca", "Evi", "Hideo", "Sli",
			"Quici", "Sly", "Miser", "Ard", "Alf", "Fiz", "Risa", "Warran", "Kel", "Wren",
			"Kan", "Can", "Gy", "Dero", "Ak", "Dall", "Dell", "Mil", "Ward", "Bra",
			"Bro", "Gi", "Demo", "Cla", "Clai", "Hat", "Crio", "Die", "Deno", "Con",
			"Wolf", "Zar", "Zer", "War", "Nar", "Thay"
		};

		// Token: 0x04009148 RID: 37192
		public static string[] Part2 = new string[]
		{
			"bright", "gold", "burnd", "del", "gor", "terous", "nton", "slip", "pask", "ck",
			"plone", "plast", "nturous", "bald", "ban", "buck", "tor", "van", "gax", "trandor",
			"thuri", "ben", "baldar", "may", "lam", "mor", "dard", "burg", "whit", "lax",
			"ndor", "ton", "seus", "zzt", "borne", "nan", "run"
		};

		// Token: 0x04009149 RID: 37193
		public static string[] Part3 = new string[]
		{
			"", "", "", "", "", "", "", "", "", "llyn",
			"a", "in", "lene", "endra", "rin", "iana", "andra", "ia"
		};

		// Token: 0x0400914A RID: 37194
		private static object TzLock = new object();

		// Token: 0x0400914B RID: 37195
		private static string TzCache = "null";

		// Token: 0x0400914C RID: 37196
		private static int TzTime = 0;

		// Token: 0x0400914D RID: 37197
		private static object LeaderboardLock = new object();

		// Token: 0x0400914E RID: 37198
		private static string LeaderboardCache = "null";

		// Token: 0x0400914F RID: 37199
		private static int LeaderboardTime = 0;
	}
}
