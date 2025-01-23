using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using D2Data;
using D2GameState;
using D2Map;
using D2Map.Pathfinding;
using D2Packets;
using D2Packets.Game.Client;
using D2Packets.Game.Server;
using Microsoft.CSharp.RuntimeBinder;
using RLib.Tsp;
using RLib.Tsp.Enums;
using Utilities;

namespace BattleNetSharp.D2.Resurrected
{
	// Token: 0x02000B19 RID: 2841
	public class Game : Client
	{
		// Token: 0x0600BE84 RID: 48772 RVA: 0x0048C728 File Offset: 0x0048A928
		public void Andariel()
		{
			this.TakeWaypoint(WaypointsAvailable.CatacombsLevel2, true, true);
			this.GoToNextLevel(WarpType.NotApplicable);
			this.GoToNextLevel(WarpType.NotApplicable);
			this.TravelTo(NPCCode.Andariel, false);
			this.KillUnit(NPCCode.Andariel);
		}

		// Token: 0x0600BE85 RID: 48773 RVA: 0x0048C768 File Offset: 0x0048A968
		public void LeechAndariel()
		{
			this.GoToTpArea(ActLocation.Act1);
			this.TakeTpTo(AreaLevel.CatacombsLevel4, "any_available_portal");
			base.WaitForPacket((Packet p) => p is PlaySound && ((PlaySound)p).Sound == GameSound.AndarielDeath);
			this.TakeTpTo(AreaLevel.RogueEncampment, "any_available_portal");
			this.TravelTo(NPCCode.Warriv, false);
			this.TownFolkQuests(NPCCode.Warriv, new ushort[] { 0, 183 });
			this.TownFolkTravel(NPCCode.Warriv, AreaLevel.LutGholein);
			base.SendPacket(new EndCinematic());
			this.TownFolkQuests(NPCCode.Warriv2, new ushort[] { 215 });
		}

		// Token: 0x0600BE86 RID: 48774 RVA: 0x0048C81C File Offset: 0x0048AA1C
		public void BloodRaven()
		{
			bool flag = this.difficulty > GameDifficulty.Normal;
			if (!flag)
			{
				bool flag2 = this.updateQuestInfo.Quests_42[6].Standing == QuestStanding.Complete;
				if (!flag2)
				{
					this.TakeWaypoint(WaypointsAvailable.ColdPlains, true, true);
					this.TravelTo(NPCCode.Bloodraven, true);
					this.GoToTown(ActLocation.None);
					this.TravelTo(NPCCode.Kashya, false);
				}
			}
		}

		// Token: 0x0600BE87 RID: 48775 RVA: 0x0048C888 File Offset: 0x0048AA88
		public void ScrollOfInifuss()
		{
			bool flag = this.updateQuestInfo.Quests_42[4].Standing == QuestStanding.Started;
			if (!flag)
			{
				bool flag2 = this.GameInstance.Items.Values.Count((ItemAction i) => i.baseItem.Type == ItemType.DecipheredBarkScroll) > 0;
				if (!flag2)
				{
					bool flag3 = this.GameInstance.Items.Values.Count((ItemAction i) => i.baseItem.Type == ItemType.BarkScroll) == 0;
					if (flag3)
					{
						this.TakeWaypoint(WaypointsAvailable.DarkWood, true, true);
						this.TravelTo(GameObjectID.InifussTree, false);
						AssignGameObject assignGameObject = this.GameInstance.GameObjects.Values.First((AssignGameObject go) => go.ObjectId == GameObjectID.InifussTree);
						base.SendPacket(new UnitInteract
						{
							Type = UnitType.GameObject,
							Id = assignGameObject.Id
						});
						this.PickItems();
						this.GoToTown(ActLocation.None);
					}
					this.TravelTo(NPCCode.Akara, false);
				}
			}
		}

		// Token: 0x0600BE88 RID: 48776 RVA: 0x0048C9BC File Offset: 0x0048ABBC
		public void Rakanishu()
		{
			this.TakeWaypoint(WaypointsAvailable.StonyField, true, true);
			this.TravelTo(GameObjectID.CairnStoneAlpha, true);
			for (int i = 0; i < 5; i++)
			{
				int k;
				int j;
				for (j = 0; j < 5; j = k + 1)
				{
					AssignGameObject assignGameObject = this.GameInstance.GameObjects.Values.First((AssignGameObject go) => go.ObjectId == GameObjectID.CairnStoneAlpha + (ushort)j);
					base.SendPacket(new UnitInteract
					{
						Type = UnitType.GameObject,
						Id = assignGameObject.Id
					});
					k = j;
				}
			}
		}

		// Token: 0x0600BE89 RID: 48777 RVA: 0x0048CA6C File Offset: 0x0048AC6C
		public void Cain()
		{
			bool flag = this.updateQuestInfo.Quests_42[4].Standing == QuestStanding.Complete;
			if (!flag)
			{
				this.ScrollOfInifuss();
				this.Tristram();
			}
		}

		// Token: 0x0600BE8A RID: 48778 RVA: 0x0048CAA8 File Offset: 0x0048ACA8
		public void Tristram()
		{
			bool flag = this.updateQuestInfo.Quests_42[4].Standing == QuestStanding.Complete;
			if (!flag)
			{
				this.ScrollOfInifuss();
				this.Rakanishu();
				this.TakeTpTo(AreaLevel.Tristram, "any_available_portal");
				this.TravelTo(GameObjectID.CainGibbet, false);
				AssignGameObject assignGameObject = this.GameInstance.GameObjects.Values.First((AssignGameObject go) => go.ObjectId == GameObjectID.CainGibbet);
				base.SendPacket(new UnitInteract
				{
					Type = UnitType.GameObject,
					Id = assignGameObject.Id
				});
				ushort[] array = new ushort[0];
				bool flag2 = base.me.Attributes[StatType.Level] < 8U;
				if (flag2)
				{
					array = new ushort[]
					{
						25166, 5087, 25159, 5089, 25154, 5093, 25145, 5091, 25140, 5084,
						25134, 5074, 25127, 5065, 25117, 5069, 25107, 5066, 25096, 5057,
						25080, 5059, 25058, 5061, 25053, 5086, 25058, 5097, 25064, 5107,
						25071, 5117, 25078, 5127, 25086, 5135, 25096, 5139, 25104, 5139,
						25111, 5137, 25118, 5132, 25127, 5131, 25135, 5135, 25133, 5143,
						25129, 5149, 25125, 5157, 25127, 5165, 25129, 5173, 25136, 5181,
						25144, 5186, 25159, 5182, 25166, 5175, 25170, 5164, 25174, 5159,
						25121, 5188, 25109, 5190, 25096, 5191, 25080, 5190, 25055, 5195
					};
				}
				else
				{
					array = new ushort[]
					{
						25166, 5093, 25166, 5105, 25166, 5115, 25166, 5125, 25171, 5137,
						25171, 5147, 25171, 5157, 25168, 5166, 25168, 5176, 25168, 5184,
						25158, 5189, 25147, 5188, 25136, 5188, 25125, 5177, 25127, 5166,
						25127, 5155, 25131, 5147, 25126, 5135, 25114, 5141, 25098, 5138,
						25083, 5138, 25083, 5153, 25081, 5164, 25092, 5179, 25090, 5188,
						25076, 5191, 25063, 5196, 25049, 5194, 25049, 5174, 25049, 5140,
						25049, 5120, 25056, 5104, 25056, 5083, 25056, 5062, 25069, 5056,
						25087, 5066, 25102, 5074, 25112, 5085, 25118, 5075, 25124, 5064
					};
				}
				for (int i = 0; i < 80; i += 2)
				{
					this.PatherMoveTo((long)((ulong)array[i]), (long)((ulong)array[i + 1]), true, 2f);
					this.AttackClear(25, 0, 0, true);
					this.AttackClear(25, 0, 0, true);
					this.PickItems();
				}
			}
		}

		// Token: 0x0600BE8B RID: 48779 RVA: 0x0048CBF0 File Offset: 0x0048ADF0
		public void Countess()
		{
			this.TakeWaypoint(WaypointsAvailable.BlackMarsh, true, true);
			this.GoToNextLevel(WarpType.NotApplicable);
			this.GoToNextLevel(WarpType.NotApplicable);
			this.GoToNextLevel(WarpType.NotApplicable);
			this.GoToNextLevel(WarpType.NotApplicable);
			this.GoToNextLevel(WarpType.NotApplicable);
			this.GoToNextLevel(WarpType.NotApplicable);
			this.TravelTo((NPCCode)740, false);
			this.KillUnit(this.GameInstance.NPCs.First((KeyValuePair<uint, AssignNPC> e) => e.Value.Name == "The Countess").Value);
			this.GoToTown(ActLocation.None);
		}

		// Token: 0x0600BE8C RID: 48780 RVA: 0x0048CC94 File Offset: 0x0048AE94
		public void DenOfEvil()
		{
			bool flag = this.updateQuestInfo.Quests_42[1].Standing == QuestStanding.Complete;
			if (!flag)
			{
				PresetUnit presetUnit = this.GameInstance.LevelData[AreaLevel.RogueEncampment].Units.First((PresetUnit w) => w.CastedWarpType.ToString().Contains(WarpType.Act1WildernessToCaveFloorL.ToString().Replace("FloorL", "")));
				this.PatherMoveTo((long)((ulong)presetUnit.X), (long)((ulong)presetUnit.Y), this.difficulty == GameDifficulty.Normal, 2f);
				this.Interact(presetUnit);
				this.ClearArea(AreaLevel.DenOfEvil);
			}
		}

		// Token: 0x0600BE8D RID: 48781 RVA: 0x0048CD30 File Offset: 0x0048AF30
		public void PreDen()
		{
			bool flag = this.difficulty > GameDifficulty.Normal;
			if (!flag)
			{
				bool flag2 = base.me.Attributes[StatType.Level] >= 3U;
				if (!flag2)
				{
					bool flag3 = this.GetGold() > 500U;
					if (!flag3)
					{
						this.TownDoChores();
						this.ClearArea(AreaLevel.BloodMoor);
					}
				}
			}
		}

		// Token: 0x0600BE8E RID: 48782 RVA: 0x0048CD8D File Offset: 0x0048AF8D
		public void Amulet()
		{
			this.TakeWaypoint(WaypointsAvailable.LostCity, true, true);
			this.GoToNextLevel(WarpType.NotApplicable);
			this.TravelTo(GameObjectID.TaintedSunAltar, false);
			this.KillSurrounding(10);
			this.GoToTown(ActLocation.None);
		}

		// Token: 0x0600BE8F RID: 48783 RVA: 0x0048CDC8 File Offset: 0x0048AFC8
		public void LeechAmmy()
		{
			this.GoToTpArea(ActLocation.Act2);
			this.TakeTpTo(AreaLevel.ClawViperTempleLevel2, "any_available_portal");
			this.Interact(GameObjectID.TaintedSunAltar);
			for (;;)
			{
				if (this.GameInstance.Items.Count((KeyValuePair<uint, ItemAction> i) => i.Value.action == ItemActionType.AddToGround && i.Value.baseItem.Name == "Viper Amulet") != 0)
				{
					break;
				}
				Thread.Sleep(100);
			}
			ItemAction value = this.GameInstance.Items.First((KeyValuePair<uint, ItemAction> i) => i.Value.action == ItemActionType.AddToGround && i.Value.baseItem.Name == "Viper Amulet").Value;
			base.SendPacket(new PickItem
			{
				UnitType = UnitType.Item,
				Id = value.Id,
				ToLocation = PickItem.PickLocation.Inventory
			}, 200, 500);
			this.TakeTpTo(AreaLevel.LutGholein, "any_available_portal");
			this.TravelTo(NPCCode.Drognan, false);
			this.TownFolkQuests(NPCCode.Drognan, new ushort[] { 286, 371, 373 });
		}

		// Token: 0x0600BE90 RID: 48784 RVA: 0x0048CED8 File Offset: 0x0048B0D8
		public void Cube()
		{
			this.TakeWaypoint(WaypointsAvailable.HallsOfTheDeadLevel2, true, true);
			this.GoToNextLevel(WarpType.NotApplicable);
			this.TravelTo(GameObjectID.HoradricCubeChest, false);
			this.Interact(GameObjectID.HoradricCubeChest);
			this.KillSurrounding(25);
			this.GoToTown(ActLocation.None);
		}

		// Token: 0x0600BE91 RID: 48785 RVA: 0x0048CF28 File Offset: 0x0048B128
		public void LeechCube()
		{
			this.GoToTpArea(ActLocation.Act2);
			this.TakeTpTo(AreaLevel.HallsOfTheDeadLevel3, "any_available_portal");
			Thread.Sleep(this.Random.Next(100, 500));
			ItemAction value = this.GameInstance.Items.First((KeyValuePair<uint, ItemAction> i) => i.Value.action == ItemActionType.OnGround && i.Value.baseItem.Name == "Horadric Cube").Value;
			base.SendPacket(new PickItem
			{
				UnitType = UnitType.Item,
				Id = value.Id,
				ToLocation = PickItem.PickLocation.Inventory
			}, 200, 500);
			this.TakeTpTo(AreaLevel.LutGholein, "any_available_portal");
		}

		// Token: 0x0600BE92 RID: 48786 RVA: 0x0048CFDC File Offset: 0x0048B1DC
		public void Duriel()
		{
			this.TakeWaypoint(WaypointsAvailable.CanyonOfTheMagi, true, true);
			string text = this.GameInstance.LevelData.First((KeyValuePair<AreaLevel, Level> l) => l.Value.Units.Count((PresetUnit u) => u.CastedGameObject == GameObjectID.HoradricOrifice) > 0).Key.ToString();
			int num = int.Parse(text.Substring(text.Length - 1));
			this.TravelTo(GameObjectID.HoradricOrifice, false);
			this.TpAndWaitForParty(20, AreaLevel.None);
			for (;;)
			{
				if (this.GameInstance.GameObjects.Count((KeyValuePair<uint, AssignGameObject> g) => g.Value.ObjectId == GameObjectID.DurielsLairPortal) != 0)
				{
					break;
				}
				this.KillSurrounding(25);
				Thread.Sleep(100);
			}
			while (base.GetCurrentLevel() != AreaLevel.DurielsLair)
			{
				this.TravelTo(GameObjectID.HoradricOrifice, false);
				this.TravelTo(GameObjectID.DurielsLairPortal, false);
				this.Interact(GameObjectID.DurielsLairPortal);
				Thread.Sleep(this.Random.Next(1500, 2500));
			}
			this.TravelTo(NPCCode.Duriel, false);
			this.TpAndWaitForParty(0, AreaLevel.None);
			Thread.Sleep(2500);
			this.KillUnit(NPCCode.Duriel);
			this.UseMyTp();
		}

		// Token: 0x0600BE93 RID: 48787 RVA: 0x0048D140 File Offset: 0x0048B340
		public void LeechDuriel()
		{
			this.GoToTpArea(ActLocation.Act2);
			string text = this.GameInstance.LevelData.First((KeyValuePair<AreaLevel, Level> l) => l.Value.Units.Count((PresetUnit u) => u.CastedGameObject == GameObjectID.HoradricOrifice) > 0).Key.ToString();
			int num = int.Parse(text.Substring(text.Length - 1));
			this.TakeTpTo((AreaLevel)(65 + num), "any_available_portal");
			AssignGameObject value = this.GameInstance.GameObjects.First((KeyValuePair<uint, AssignGameObject> g) => g.Value.ObjectId == GameObjectID.HoradricOrifice).Value;
			this.TravelTo(GameObjectID.HoradricOrifice, false);
			this.Interact(value);
			ItemAction value2 = this.GameInstance.Items.Last((KeyValuePair<uint, ItemAction> i) => i.Value.baseItem.Name == "Horadric Staff").Value;
			base.SendPacket(new PickItemFromContainer
			{
				Id = value2.Id
			}, 500, 1500);
			for (;;)
			{
				if (this.GameInstance.GameObjects.Count((KeyValuePair<uint, AssignGameObject> g) => g.Value.ObjectId == GameObjectID.DurielsLairPortal) != 0)
				{
					break;
				}
				Thread.Sleep(100);
			}
			for (;;)
			{
				if (this.GameInstance.Players.Count((KeyValuePair<uint, Player> p) => p.Value.Area == AreaLevel.DurielsLair) != 0)
				{
					break;
				}
				Thread.Sleep(100);
			}
			while (base.GetCurrentLevel() != AreaLevel.DurielsLair)
			{
				this.TravelTo(GameObjectID.HoradricOrifice, false);
				this.TravelTo(GameObjectID.DurielsLairPortal, false);
				this.Interact(GameObjectID.DurielsLairPortal);
				Thread.Sleep(this.Random.Next(1500, 2500));
			}
			this.TravelTo(NPCCode.Tyrael, false);
			this.TownFolkQuests(NPCCode.Tyrael, new ushort[] { 302 });
			this.TakeTpTo(AreaLevel.LutGholein, null);
			this.TravelTo(NPCCode.Drognan, false);
			this.TravelTo(GameObjectID.JerhynPlaceHolder2, false);
			Thread.Sleep(this.Random.Next(1000, 2000));
			this.TravelTo(NPCCode.Jerhyn, false);
			this.TownFolkQuests(NPCCode.Jerhyn, new ushort[] { 253, 442 });
			this.TravelTo(NPCCode.Meshif, false);
			this.TownFolkQuests(NPCCode.Meshif, new ushort[] { 241, 450 });
			this.TownFolkTravel(NPCCode.Meshif, AreaLevel.KurastDocks);
			base.SendPacket(new EndCinematic());
			this.TownFolkQuests(NPCCode.Meshif2, new ushort[] { 478 });
		}

		// Token: 0x0600BE94 RID: 48788 RVA: 0x0048D43A File Offset: 0x0048B63A
		public void Radament()
		{
		}

		// Token: 0x0600BE95 RID: 48789 RVA: 0x0048D43D File Offset: 0x0048B63D
		public void ShopLargeShield()
		{
		}

		// Token: 0x0600BE96 RID: 48790 RVA: 0x0048D440 File Offset: 0x0048B640
		public void Staff()
		{
			this.TakeWaypoint(WaypointsAvailable.FarOasis, true, true);
			this.GoToNextLevel(WarpType.NotApplicable);
			this.GoToNextLevel(WarpType.NotApplicable);
			this.TravelTo(GameObjectID.StaffOfKingsChest, false);
			AssignGameObject assignGameObject = this.GameInstance.GameObjects.Values.FirstOrDefault((AssignGameObject g) => g.ObjectId == GameObjectID.StaffOfKingsChest);
			this.Interact(assignGameObject);
			this.KillSurrounding(25);
			this.TravelTo(GameObjectID.StaffOfKingsChest, false);
			this.GoToTown(ActLocation.None);
		}

		// Token: 0x0600BE97 RID: 48791 RVA: 0x0048D4D8 File Offset: 0x0048B6D8
		public void LeechStaff()
		{
			this.GoToTpArea(ActLocation.Act2);
			this.TakeTpTo(AreaLevel.MaggotLairLevel3, "any_available_portal");
			Thread.Sleep(this.Random.Next(100, 500));
			ItemAction value = this.GameInstance.Items.First((KeyValuePair<uint, ItemAction> i) => i.Value.action == ItemActionType.OnGround && i.Value.baseItem.Name == "Staff of Kings").Value;
			base.SendPacket(new PickItem
			{
				UnitType = UnitType.Item,
				Id = value.Id,
				ToLocation = PickItem.PickLocation.Inventory
			}, 200, 500);
			this.TakeTpTo(AreaLevel.LutGholein, "any_available_portal");
		}

		// Token: 0x0600BE98 RID: 48792 RVA: 0x0048D58C File Offset: 0x0048B78C
		public void Summoner()
		{
			this.TakeWaypoint(WaypointsAvailable.ArcaneSanctuary, true, true);
			Level level = this.GameInstance.LevelData[AreaLevel.ArcaneSanctuary];
			PresetUnit presetUnit = level.Units.First((PresetUnit u) => u.CastedGameObject == GameObjectID.YetAnotherTome);
			this.TakeTpTo(AreaLevel.CanyonOfTheMagi, "any_available_portal");
		}

		// Token: 0x0600BE99 RID: 48793 RVA: 0x0048D5F8 File Offset: 0x0048B7F8
		public void LeechSummoner()
		{
			this.GoToTpArea(ActLocation.Act2);
			this.TakeTpTo(AreaLevel.ArcaneSanctuary, "any_available_portal");
			Thread.Sleep(10000);
			this.TravelTo(GameObjectID.YetAnotherTome, false);
			this.Interact(GameObjectID.YetAnotherTome);
			this.TakeTpTo(AreaLevel.CanyonOfTheMagi, "any_available_portal");
			this.TakeWaypoint(WaypointsAvailable.LutGholein, true, true);
			this.TravelTo(NPCCode.DeckardCain2, false);
			this.TownFolkQuests(NPCCode.DeckardCain2, new ushort[] { 338, 407, 336, 429, 337 });
		}

		// Token: 0x0600BE9A RID: 48794 RVA: 0x0048D687 File Offset: 0x0048B887
		public void Tombs()
		{
		}

		// Token: 0x0600BE9B RID: 48795 RVA: 0x0048D68C File Offset: 0x0048B88C
		public void LowerKurastChests(WaypointsAvailable endAt)
		{
			this.TakeWaypoint(WaypointsAvailable.LowerKurast, true, true);
			List<PresetUnit> list = this.GameInstance.LevelData[AreaLevel.LowerKurast].Units.FindAll((PresetUnit u) => (byte)u.Type == 2 && u.TxtFileNo == 580U);
			foreach (PresetUnit presetUnit in list)
			{
				this.PatherMoveTo((long)((ulong)presetUnit.X), (long)((ulong)presetUnit.Y), false, 2f);
				IEnumerable<GameObjectID> enumerable = from g in this.GameInstance.GameObjects.Values.ToList<AssignGameObject>()
					select g.ObjectId;
				AssignGameObject assignGameObject = this.GameInstance.GameObjects.Values.FirstOrDefault((AssignGameObject g) => (g.ObjectId == (GameObjectID)580 || g.ObjectId == (GameObjectID)581 || g.ObjectId.ToString().ToLower().Contains("chest")) && Math.Abs((int)(base.me.X - g.X)) < 3 && Math.Abs((int)(base.me.Y - g.Y)) < 3);
				bool flag = assignGameObject == null;
				if (flag)
				{
					Console.WriteLine(string.Concat(new string[]
					{
						"failed to find ",
						((GameObjectID)presetUnit.TxtFileNo).ToString(),
						" : ",
						presetUnit.X.ToString(),
						", ",
						presetUnit.Y.ToString()
					}));
				}
				else
				{
					uint mode = (uint)this.GameInstance.GameObjects[assignGameObject.Id].Mode;
					Interact interact = new Interact();
					interact.TargetId = assignGameObject.Id;
					interact.Mode = mode;
					base.SendPacket(interact, (Packet p) => p is PlaySound);
					Console.WriteLine(string.Concat(new string[]
					{
						"opened : ",
						assignGameObject.Id.ToString(),
						"(",
						assignGameObject.ObjectId.ToString(),
						") : ",
						mode.ToString()
					}));
					this.PickItems();
				}
			}
			this.TakeWaypoint(endAt, true, true);
		}

		// Token: 0x0600BE9C RID: 48796 RVA: 0x0048D8EC File Offset: 0x0048BAEC
		public void Mephisto(bool rushing = false)
		{
			this.TakeWaypoint(WaypointsAvailable.DuranceOfHateLevel2, true, true);
			this.GoToNextLevel(WarpType.NotApplicable);
			PresetUnit presetUnit = this.GameInstance.LevelData[AreaLevel.DuranceOfHateLevel3].Units.First((PresetUnit u) => u.CastedGameObject == GameObjectID.HellGate);
			this.PatherMoveTo((long)((ulong)(presetUnit.X - 10U)), (long)((ulong)presetUnit.Y), false, 2f);
			if (rushing)
			{
				this.TpAndWaitForParty(0, AreaLevel.None);
			}
			this.TravelTo(NPCCode.Mephisto, false);
			this.KillUnit(this.GameInstance.NPCs.First((KeyValuePair<uint, AssignNPC> e) => e.Value.NpcType == NPCCode.Mephisto).Value);
			this.PatherMoveTo((long)((ulong)(presetUnit.X - 10U)), (long)((ulong)presetUnit.Y), false, 2f);
			while (base.GetCurrentLevel() != AreaLevel.ThePandemoniumFortress)
			{
				this.PatherMoveTo((long)((ulong)presetUnit.X), (long)((ulong)presetUnit.Y), false, 2f);
				AssignGameObject value = this.GameInstance.GameObjects.First((KeyValuePair<uint, AssignGameObject> g) => g.Value.ObjectId == GameObjectID.HellGate).Value;
				this.Interact(value);
			}
		}

		// Token: 0x0600BE9D RID: 48797 RVA: 0x0048DA58 File Offset: 0x0048BC58
		public void Mephisto2()
		{
			this.TakeWaypoint(WaypointsAvailable.DuranceOfHateLevel2, true, true);
			this.GoToNextLevel(WarpType.NotApplicable);
			PresetUnit presetUnit = this.GameInstance.LevelData[AreaLevel.DuranceOfHateLevel3].Units.First((PresetUnit u) => u.CastedGameObject == GameObjectID.HellGate);
			this.PatherMoveTo((long)((ulong)(presetUnit.X - 10U)), (long)((ulong)presetUnit.Y), false, 2f);
			this.TpAndWaitForParty(0, AreaLevel.None);
			this.TravelTo(NPCCode.Mephisto, false);
			this.KillUnit(this.GameInstance.NPCs.First((KeyValuePair<uint, AssignNPC> e) => e.Value.NpcType == NPCCode.Mephisto).Value);
			this.PatherMoveTo((long)((ulong)(presetUnit.X - 10U)), (long)((ulong)presetUnit.Y), false, 2f);
			while (base.GetCurrentLevel() != AreaLevel.ThePandemoniumFortress)
			{
				this.PatherMoveTo((long)((ulong)presetUnit.X), (long)((ulong)presetUnit.Y), false, 2f);
				AssignGameObject value = this.GameInstance.GameObjects.First((KeyValuePair<uint, AssignGameObject> g) => g.Value.ObjectId == GameObjectID.HellGate).Value;
				this.Interact(value);
				Thread.Sleep(this.Random.Next(1000, 2000));
			}
		}

		// Token: 0x0600BE9E RID: 48798 RVA: 0x0048DBDC File Offset: 0x0048BDDC
		public void LeechMephisto()
		{
			this.GoToTpArea(ActLocation.Act3);
			this.TakeTpTo(AreaLevel.DuranceOfHateLevel3, "any_available_portal");
			for (;;)
			{
				if (this.GameInstance.GameObjects.Count((KeyValuePair<uint, AssignGameObject> g) => g.Value.ObjectId == GameObjectID.MephistoBridge && g.Value.Mode == GameObjectMode.Opened) != 0)
				{
					break;
				}
				Thread.Sleep(100);
			}
			while (base.GetCurrentLevel() != AreaLevel.ThePandemoniumFortress)
			{
				this.TravelTo(GameObjectID.HellGate, false);
				this.Interact(GameObjectID.HellGate);
				Thread.Sleep(100);
			}
			base.SendPacket(new EndCinematic());
		}

		// Token: 0x0600BE9F RID: 48799 RVA: 0x0048DC84 File Offset: 0x0048BE84
		public void Travincal()
		{
			this.TakeWaypoint(WaypointsAvailable.Travincal, true, true);
			ushort x = base.me.X;
			ushort y = base.me.Y;
			this.PatherMoveTo((long)(x + 71), (long)(y - 94), false, 2f);
			this.KillSurroundingUniques();
			this.GoToTown(ActLocation.None);
		}

		// Token: 0x0600BEA0 RID: 48800 RVA: 0x0048DCE0 File Offset: 0x0048BEE0
		public void Travincal2()
		{
			this.TakeWaypoint(WaypointsAvailable.Travincal, true, true);
			ushort x = base.me.X;
			ushort y = base.me.Y;
			this.PatherMoveTo((long)(x + 23), (long)(y - 102), false, 2f);
			this.TpAndWaitForParty(30, AreaLevel.None);
			this.PatherMoveTo((long)(x + 30), (long)(y - 134), false, 2f);
			this.KillSurroundingUniques();
			this.PatherMoveTo((long)(x + 23), (long)(y - 102), false, 2f);
			this.KillSurrounding(30);
			this.PatherMoveTo((long)(x + 86), (long)(y - 130), false, 2f);
			this.KillSurroundingUniques();
			this.PatherMoveTo((long)(x + 23), (long)(y - 102), false, 2f);
			this.KillSurrounding(30);
			this.PatherMoveTo((long)(x + 71), (long)(y - 94), false, 2f);
			this.KillSurroundingUniques();
			this.PatherMoveTo((long)(x + 23), (long)(y - 102), false, 2f);
			this.KillSurrounding(30);
			this.UseMyTp();
		}

		// Token: 0x0600BEA1 RID: 48801 RVA: 0x0048DE00 File Offset: 0x0048C000
		public void LeechTravincal()
		{
			this.GoToTpArea(ActLocation.Act3);
			this.TakeTpTo(AreaLevel.Travincal, "any_available_portal");
			Thread.Sleep(25000);
			this.TakeTpTo(AreaLevel.KurastDocks, "any_available_portal");
			this.TravelTo(NPCCode.DeckardCain3, false);
			this.TownFolkQuests(NPCCode.DeckardCain3, new ushort[] { 458, 626 });
		}

		// Token: 0x0600BEA2 RID: 48802 RVA: 0x0048DE6C File Offset: 0x0048C06C
		public void Diablo()
		{
			this.TakeWaypoint(WaypointsAvailable.RiverOfFlame, true, true);
			PresetUnit presetUnit = this.GameInstance.LevelData[AreaLevel.ChaosSanctuary].Units.First((PresetUnit u) => u.CastedGameObject == GameObjectID.DiabloSeal1);
			this.PatherMoveTo((long)((ulong)presetUnit.X), (long)((ulong)presetUnit.Y), false, 2f);
			this.Interact(this.GameInstance.GameObjects.First((KeyValuePair<uint, AssignGameObject> g) => g.Value.ObjectId == GameObjectID.DiabloSeal1).Value);
			PresetUnit presetUnit2 = this.GameInstance.LevelData[AreaLevel.ChaosSanctuary].Units.First((PresetUnit u) => u.CastedGameObject == GameObjectID.DiabloSeal2);
			this.PatherMoveTo((long)((ulong)presetUnit2.X), (long)((ulong)presetUnit2.Y), false, 2f);
			this.Interact(this.GameInstance.GameObjects.First((KeyValuePair<uint, AssignGameObject> g) => g.Value.ObjectId == GameObjectID.DiabloSeal2).Value);
			Thread.Sleep(this.Random.Next(300, 500));
			this.KillUnit(this.GameInstance.NPCs.First((KeyValuePair<uint, AssignNPC> g) => g.Value.Name == "Infector of Souls").Value);
			PresetUnit presetUnit3 = this.GameInstance.LevelData[AreaLevel.ChaosSanctuary].Units.First((PresetUnit u) => u.CastedGameObject == GameObjectID.DiabloSeal3);
			this.PatherMoveTo((long)((ulong)presetUnit3.X), (long)((ulong)presetUnit3.Y), false, 2f);
			this.Interact(this.GameInstance.GameObjects.First((KeyValuePair<uint, AssignGameObject> g) => g.Value.ObjectId == GameObjectID.DiabloSeal3).Value);
			Thread.Sleep(this.Random.Next(300, 500));
			bool flag = presetUnit3.X == 7773U;
			if (flag)
			{
				this.PatherMoveTo(7771L, 5196L, false, 2f);
			}
			else
			{
				this.PatherMoveTo(7798L, 5186L, false, 2f);
			}
			this.KillUnit(this.GameInstance.NPCs.First((KeyValuePair<uint, AssignNPC> g) => g.Value.Name == "Lord De Seis").Value);
			PresetUnit presetUnit4 = this.GameInstance.LevelData[AreaLevel.ChaosSanctuary].Units.First((PresetUnit u) => u.CastedGameObject == GameObjectID.DiabloSeal4);
			this.PatherMoveTo((long)((ulong)presetUnit4.X), (long)((ulong)presetUnit4.Y), false, 2f);
			this.Interact(this.GameInstance.GameObjects.First((KeyValuePair<uint, AssignGameObject> g) => g.Value.ObjectId == GameObjectID.DiabloSeal4).Value);
			PresetUnit presetUnit5 = this.GameInstance.LevelData[AreaLevel.ChaosSanctuary].Units.First((PresetUnit u) => u.CastedGameObject == GameObjectID.DiabloSeal5);
			this.PatherMoveTo((long)((ulong)presetUnit5.X), (long)((ulong)presetUnit5.Y), false, 2f);
			this.Interact(this.GameInstance.GameObjects.First((KeyValuePair<uint, AssignGameObject> g) => g.Value.ObjectId == GameObjectID.DiabloSeal5).Value);
			Thread.Sleep(this.Random.Next(300, 500));
			bool flag2 = presetUnit5.Y == 5275U;
			if (flag2)
			{
				this.PatherMoveTo(7691L, 5292L, false, 2f);
			}
			else
			{
				this.PatherMoveTo(7695L, 5316L, false, 2f);
			}
			this.KillUnit(this.GameInstance.NPCs.First((KeyValuePair<uint, AssignNPC> g) => g.Value.Name == "Grand Vizier of Chaos").Value);
			this.PatherMoveTo(7763L, 5267L, false, 2f);
			this.TpAndWaitForParty(0, AreaLevel.None);
			PresetUnit presetUnit6 = this.GameInstance.LevelData[AreaLevel.ChaosSanctuary].Units.First((PresetUnit u) => u.CastedGameObject == GameObjectID.DiabloStartPoint);
			this.PatherMoveTo((long)((ulong)presetUnit6.X), (long)((ulong)presetUnit6.Y), false, 2f);
			for (;;)
			{
				if (this.GameInstance.NPCs.Count((KeyValuePair<uint, AssignNPC> e) => e.Value.NpcType == NPCCode.Diablo) != 0)
				{
					break;
				}
				Thread.Sleep(100);
			}
			this.KillUnit(NPCCode.Diablo);
			this.UseMyTp();
		}

		// Token: 0x0600BEA3 RID: 48803 RVA: 0x0048E3E8 File Offset: 0x0048C5E8
		public void Diablo2()
		{
			this.TakeWaypoint(WaypointsAvailable.RiverOfFlame, true, true);
			PresetUnit presetUnit = this.GameInstance.LevelData[AreaLevel.ChaosSanctuary].Units.First((PresetUnit u) => u.CastedGameObject == GameObjectID.DiabloSeal1);
			this.PatherMoveTo((long)((ulong)presetUnit.X), (long)((ulong)presetUnit.Y), false, 2f);
			this.Interact(this.GameInstance.GameObjects.First((KeyValuePair<uint, AssignGameObject> g) => g.Value.ObjectId == GameObjectID.DiabloSeal1).Value);
			PresetUnit presetUnit2 = this.GameInstance.LevelData[AreaLevel.ChaosSanctuary].Units.First((PresetUnit u) => u.CastedGameObject == GameObjectID.DiabloSeal2);
			this.PatherMoveTo((long)((ulong)presetUnit2.X), (long)((ulong)presetUnit2.Y), false, 2f);
			this.Interact(this.GameInstance.GameObjects.First((KeyValuePair<uint, AssignGameObject> g) => g.Value.ObjectId == GameObjectID.DiabloSeal2).Value);
			Thread.Sleep(this.Random.Next(300, 500));
			this.KillUnit(this.GameInstance.NPCs.First((KeyValuePair<uint, AssignNPC> g) => g.Value.Name == "Infector of Souls").Value);
			PresetUnit presetUnit3 = this.GameInstance.LevelData[AreaLevel.ChaosSanctuary].Units.First((PresetUnit u) => u.CastedGameObject == GameObjectID.DiabloSeal3);
			this.PatherMoveTo((long)((ulong)presetUnit3.X), (long)((ulong)presetUnit3.Y), false, 2f);
			this.Interact(this.GameInstance.GameObjects.First((KeyValuePair<uint, AssignGameObject> g) => g.Value.ObjectId == GameObjectID.DiabloSeal3).Value);
			Thread.Sleep(this.Random.Next(300, 500));
			bool flag = presetUnit3.X == 7773U;
			if (flag)
			{
				this.PatherMoveTo(7771L, 5196L, false, 2f);
			}
			else
			{
				this.PatherMoveTo(7798L, 5186L, false, 2f);
			}
			this.KillUnit(this.GameInstance.NPCs.First((KeyValuePair<uint, AssignNPC> g) => g.Value.Name == "Lord De Seis").Value);
			PresetUnit presetUnit4 = this.GameInstance.LevelData[AreaLevel.ChaosSanctuary].Units.First((PresetUnit u) => u.CastedGameObject == GameObjectID.DiabloSeal4);
			this.PatherMoveTo((long)((ulong)presetUnit4.X), (long)((ulong)presetUnit4.Y), false, 2f);
			this.Interact(this.GameInstance.GameObjects.First((KeyValuePair<uint, AssignGameObject> g) => g.Value.ObjectId == GameObjectID.DiabloSeal4).Value);
			PresetUnit presetUnit5 = this.GameInstance.LevelData[AreaLevel.ChaosSanctuary].Units.First((PresetUnit u) => u.CastedGameObject == GameObjectID.DiabloSeal5);
			this.PatherMoveTo((long)((ulong)presetUnit5.X), (long)((ulong)presetUnit5.Y), false, 2f);
			this.Interact(this.GameInstance.GameObjects.First((KeyValuePair<uint, AssignGameObject> g) => g.Value.ObjectId == GameObjectID.DiabloSeal5).Value);
			Thread.Sleep(this.Random.Next(300, 500));
			bool flag2 = presetUnit5.Y == 5275U;
			if (flag2)
			{
				this.PatherMoveTo(7691L, 5292L, false, 2f);
			}
			else
			{
				this.PatherMoveTo(7695L, 5316L, false, 2f);
			}
			this.KillUnit(this.GameInstance.NPCs.First((KeyValuePair<uint, AssignNPC> g) => g.Value.Name == "Grand Vizier of Chaos").Value);
			this.PatherMoveTo(7763L, 5267L, false, 2f);
			this.TpAndWaitForParty(0, AreaLevel.None);
			PresetUnit presetUnit6 = this.GameInstance.LevelData[AreaLevel.ChaosSanctuary].Units.First((PresetUnit u) => u.CastedGameObject == GameObjectID.DiabloStartPoint);
			this.PatherMoveTo((long)((ulong)presetUnit6.X), (long)((ulong)presetUnit6.Y), false, 2f);
			for (;;)
			{
				if (this.GameInstance.NPCs.Count((KeyValuePair<uint, AssignNPC> e) => e.Value.NpcType == NPCCode.Diablo) != 0)
				{
					break;
				}
				Thread.Sleep(100);
			}
			this.KillUnit(NPCCode.Diablo);
			this.UseMyTp();
		}

		// Token: 0x0600BEA4 RID: 48804 RVA: 0x0048E964 File Offset: 0x0048CB64
		public void LeechDiablo()
		{
			this.GoToTpArea(ActLocation.Act4);
			this.TakeTpTo(AreaLevel.ChaosSanctuary, "any_available_portal");
			for (;;)
			{
				if (this.questItemStates.Count((QuestItemState q) => q.QuestId == 23 && q.AlertFlags == 2) != 0)
				{
					break;
				}
				Thread.Sleep(100);
			}
			this.TakeTpTo(AreaLevel.ThePandemoniumFortress, "any_available_portal");
			this.TravelTo(NPCCode.Tyrael2, false);
			this.TownFolkQuests(NPCCode.Tyrael2, new ushort[] { 664, 670, 20000 });
			for (;;)
			{
				if (this.GameInstance.GameObjects.Count((KeyValuePair<uint, AssignGameObject> g) => g.Value.ObjectId == GameObjectID.LastLastPortal) != 0)
				{
					break;
				}
				Thread.Sleep(100);
			}
			AssignGameObject value = this.GameInstance.GameObjects.First((KeyValuePair<uint, AssignGameObject> g) => g.Value.ObjectId == GameObjectID.LastLastPortal).Value;
			while (base.GetCurrentLevel() != AreaLevel.Harrogath)
			{
				this.Interact(value);
				Thread.Sleep(this.Random.Next(250, 750));
			}
			base.SendPacket(new EndCinematic());
		}

		// Token: 0x0600BEA5 RID: 48805 RVA: 0x0048EAB9 File Offset: 0x0048CCB9
		public void AutoPlay()
		{
			this.AutoPlayTown();
			this.Act1();
			this.Act2();
			this.Act3();
			this.Act4();
			this.Act5();
		}

		// Token: 0x0600BEA6 RID: 48806 RVA: 0x0048EAE6 File Offset: 0x0048CCE6
		public void Act1()
		{
			this.DenOfEvil();
			this.Cain();
			this.ShopQuiltedArmor();
			this.Countess();
			this.ExploitAct1();
		}

		// Token: 0x0600BEA7 RID: 48807 RVA: 0x0048EB0C File Offset: 0x0048CD0C
		public void ExploitAct1()
		{
			bool flag = !base.me.WaypointsUnlocked.HasFlag(WaypointsAvailable.LutGholein);
			if (flag)
			{
				this.TravelTo(NPCCode.Warriv, false);
				IdentifyGambleItemOrTravel identifyGambleItemOrTravel = new IdentifyGambleItemOrTravel();
				identifyGambleItemOrTravel.Id = this.GameInstance.NPCs.Values.First((AssignNPC n) => n.NpcType == NPCCode.Warriv).Id;
				identifyGambleItemOrTravel.AreaLevel = AreaLevel.LutGholein;
				base.SendPacket(identifyGambleItemOrTravel.ToArray());
			}
		}

		// Token: 0x0600BEA8 RID: 48808 RVA: 0x0048EBA8 File Offset: 0x0048CDA8
		public void ExploitAct2()
		{
			bool flag = !base.me.WaypointsUnlocked.HasFlag(WaypointsAvailable.KurastDocks);
			if (flag)
			{
				this.TravelTo(NPCCode.Meshif, false);
				IdentifyGambleItemOrTravel identifyGambleItemOrTravel = new IdentifyGambleItemOrTravel();
				identifyGambleItemOrTravel.Id = this.GameInstance.NPCs.Values.First((AssignNPC n) => n.NpcType == NPCCode.Meshif).Id;
				identifyGambleItemOrTravel.AreaLevel = AreaLevel.KurastDocks;
				base.SendPacket(identifyGambleItemOrTravel.ToArray());
			}
		}

		// Token: 0x0600BEA9 RID: 48809 RVA: 0x0048EC44 File Offset: 0x0048CE44
		public void Act2()
		{
			this.Radament();
			this.ExploitAct2();
			this.Cube();
			this.Amulet();
			this.Staff();
			this.Tombs();
			this.ShopLargeShield();
			this.Duriel();
		}

		// Token: 0x0600BEAA RID: 48810 RVA: 0x0048EC7F File Offset: 0x0048CE7F
		public void Act3()
		{
		}

		// Token: 0x0600BEAB RID: 48811 RVA: 0x0048EC82 File Offset: 0x0048CE82
		public void Act4()
		{
		}

		// Token: 0x0600BEAC RID: 48812 RVA: 0x0048EC85 File Offset: 0x0048CE85
		public void Act5()
		{
		}

		// Token: 0x0600BEAD RID: 48813 RVA: 0x0048EC88 File Offset: 0x0048CE88
		public void AutoPlayTown()
		{
			bool flag = this.updateQuestInfo.Quests_42[6].Standing == QuestStanding.RewardPending;
			if (flag)
			{
				this.TravelTo(NPCCode.Akara, false);
				this.TownFolkQuests(NPCCode.Akara, new ushort[] { 12, 76 });
			}
		}

		// Token: 0x0600BEAE RID: 48814 RVA: 0x0048ECDE File Offset: 0x0048CEDE
		public void ShopQuiltedArmor()
		{
		}

		// Token: 0x0600BEAF RID: 48815 RVA: 0x0048ECE4 File Offset: 0x0048CEE4
		public void WeaponSwitch(bool slot)
		{
			bool flag = base.me.WeaponSwitched != slot;
			if (flag)
			{
				base.SendPacket(new SwitchWeapons
				{
					LeftId1 = base.me.Equipment[base.me.WeaponSwitched ? EquipmentLocation.LeftHand : EquipmentLocation.LeftHandSwitch].Id,
					RightId1 = base.me.Equipment[base.me.WeaponSwitched ? EquipmentLocation.RightHand : EquipmentLocation.RightHandSwitch].Id,
					LeftId2 = base.me.Equipment[base.me.WeaponSwitched ? EquipmentLocation.LeftHandSwitch : EquipmentLocation.LeftHand].Id,
					RightId2 = base.me.Equipment[base.me.WeaponSwitched ? EquipmentLocation.RightHandSwitch : EquipmentLocation.RightHand].Id,
					RightSkill = (base.me.WeaponSwitched ? base.me.RightHandSkill : base.me.RightHandSkillSwap),
					LeftSkill = (base.me.WeaponSwitched ? base.me.LeftHandSkill : base.me.LeftHandSkillSwap),

// [Ares] removed because it seems like duplicated
// 					LeftId2 = base.me.Equipment[EquipmentLocation.LeftHandSwitch].Id,
// 					RightId2 = base.me.Equipment[EquipmentLocation.RightHandSwitch].Id,
// 					LeftId1 = base.me.Equipment[EquipmentLocation.LeftHand].Id,
// 					RightId1 = base.me.Equipment[EquipmentLocation.RightHand].Id,
// 					RightSkill = (base.me.WeaponSwitched ? base.me.RightHandSkillSwap : base.me.RightHandSkill),
// 					RightSkill = base.me.RightHandSkill,
// 					LeftSkill = (base.me.WeaponSwitched ? base.me.LeftHandSkillSwap : base.me.LeftHandSkill),
// 					LeftSkill = base.me.LeftHandSkill,
					SwapId = (byte)(base.me.WeaponSwitched ? 1 : 0)
				}, (Packet p) => p is SwitchWeaponSet);
			}
		}

		// Token: 0x0600BEB0 RID: 48816 RVA: 0x0048EF48 File Offset: 0x0048D148
		// [Ares] from GPT
        public void KillSurrounding(ushort distance = 25)
        {
            ushort origLocX = base.me.X;
            ushort origLocY = base.me.Y;

            while (true)
            {
                // Filter NPCs based on conditions
                var nearbyNPCs = this.GameInstance.NPCs
                    .Where(e => e.Value.Life != 0 &&
                                e.Value.AnimationMode != 0 &&
                                e.Value.AnimationMode != 12 &&
                                Vector2.Distance(new Vector2(origLocX, origLocY), new Vector2(e.Value.X, e.Value.Y)) < distance &&
                                e.Value.X > 0 && e.Value.Y > 0 &&
                                e.Value.MonStats.Align != 1)
                    .Select(e => e.Value)
                    .ToList();

                // Exit loop if no NPCs meet the conditions
                if (!nearbyNPCs.Any())
                    break;

                // Prioritize NPCs named "Fallen", then by proximity to the player
                var prioritizedNPCs = nearbyNPCs
                    .OrderBy(npc => npc.Name != "Fallen")
                    .ThenBy(npc => Vector2.Distance(new Vector2(base.me.X, base.me.Y), new Vector2(npc.X, npc.Y)))
                    .ToList();

                // Kill the first prioritized NPC
                var targetNPC = prioritizedNPCs.First();
                this.KillUnit(targetNPC);
            }
        }

        // Token: 0x0600BEB1 RID: 48817 RVA: 0x0048F0B0 File Offset: 0x0048D2B0
		// [Ares] from GPT
        public void KillSurroundingUniques()
        {
            ushort origLocX = base.me.X;
            ushort origLocY = base.me.Y;

            while (true)
            {
                // Find unique or super-unique NPCs within the specified distance
                var nearbyUniques = this.GameInstance.NPCs
                    .Where(e => e.Value.Life > 0 &&
                                Vector2.Distance(new Vector2(origLocX, origLocY), new Vector2(e.Value.X, e.Value.Y)) < 35f &&
                                e.Value.X > 0 && e.Value.Y > 0 &&
                                (e.Value.IsUnique || e.Value.IsSuperUnique) &&
                                e.Value.NpcType != NPCCode.CompellingOrb)
                    .Select(e => e.Value)
                    .ToList();

                // Exit the loop if no NPCs meet the criteria
                if (!nearbyUniques.Any())
                    break;

                // Randomly select one NPC from the list
                AssignNPC targetNPC = nearbyUniques[this.Random.Next(nearbyUniques.Count)];

                // Kill the selected NPC
                this.KillUnit(targetNPC);

                // Move back to the original position
                this.PatherMoveTo(origLocX, origLocY, false, 2f);
            }
        }


        // Token: 0x0600BEB2 RID: 48818 RVA: 0x0048F1A2 File Offset: 0x0048D3A2
        public void KillUnit(NPCCode namedUnit)
		{
		}

		// Token: 0x0600BEB3 RID: 48819 RVA: 0x0048F1A8 File Offset: 0x0048D3A8
		public bool AttackSkipCheck(AssignNPC unit)
		{
			return base.GetCurrentLevel() == AreaLevel.ThroneOfDestruction;
		}

		// Token: 0x0600BEB4 RID: 48820 RVA: 0x0048F1D0 File Offset: 0x0048D3D0
		public int AttackGetMonsterCount(ushort x, ushort y, int range, List<AssignNPC> monList)
		{
			return monList.Count((AssignNPC m) => Helpers.GetDistance(x, y, m.X, m.Y) < (float)range);
		}

		// Token: 0x0600BEB5 RID: 48821 RVA: 0x0048F210 File Offset: 0x0048D410
		public bool AttackDeploy(AssignNPC unit, ushort distance, int spread, int range)
		{
			Vector2 idealPos = new Vector2((float)Math.Cos(Math.Atan2((double)(base.me.Y - unit.Y), (double)(base.me.X - unit.X)) * (double)this.Config.DodgeRange + (double)unit.Y), (float)Math.Sin(Math.Atan2((double)(base.me.Y - unit.Y), (double)(base.me.X - unit.X)) * (double)this.Config.DodgeRange + (double)unit.Y));
			int num = 999;
			bool flag = this.AttackGetMonsterCount(base.me.X, base.me.Y, 15, this.GameInstance.NPCs.Values.ToList<AssignNPC>()) == 0;
			bool flag2;
			if (flag)
			{
				flag2 = true;
			}
			else
			{
				List<Vector2> list = new List<Vector2>();
				int num2 = (int)(unit.X - distance);
				int num3 = (int)(unit.X + distance);
				int num4 = (int)(unit.Y - distance);
				int num5 = (int)(unit.Y + distance);
				for (int i = num2; i <= num3; i += spread)
				{
					for (int j = num4; j <= num5; j += spread)
					{
						bool flag3 = !this.GameInstance.LevelData[base.GetCurrentLevel()].IsWall((uint)i, (uint)j);
						if (flag3)
						{
							list.Add(new Vector2((float)i, (float)j));
						}
					}
				}
				list = list.OrderBy((Vector2 p) => Helpers.GetDistance((ushort)idealPos.X, (ushort)idealPos.Y, (ushort)p.X, (ushort)p.Y)).ToList<Vector2>();
				Vector2 idealPos2 = idealPos;
				foreach (Vector2 vector in list)
				{
					int num6 = this.AttackGetMonsterCount(base.me.X, base.me.Y, 15, this.GameInstance.NPCs.Values.ToList<AssignNPC>());
					bool flag4 = num6 < num;
					if (flag4)
					{
						idealPos = vector;
						num = num6;
					}
					bool flag5 = num == 0;
					if (flag5)
					{
						break;
					}
				}
				flag2 = this.PatherMoveTo((long)idealPos.X, (long)idealPos.Y, false, 2f);
			}
			return flag2;
		}

        // Token: 0x0600BEB6 RID: 48822 RVA: 0x0048F484 File Offset: 0x0048D684
		// [Ares] from GPT
        public bool AttackClear(ushort range = 25, ushort spectype = 0, ushort bossId = 0, bool pickit = true)
        {
            var targets = this.GameInstance.NPCs.Values
                .Where(target => Helpers.GetDistance(this.me.X, this.me.Y, target.X, target.Y) <= range &&
                                 this.AttackCheckMonster(target));

            int attempts = 0;

            while (targets.Any() && attempts < 300)
            {
                // Find the nearest NPC to attack
                var closestTarget = targets
                    .OrderBy(target => Helpers.GetDistance(this.me.X, this.me.Y, target.X, target.Y))
                    .First();

                // If the player's life is zero, stop the process
                if (base.me.Life == 0)
                    return false;

                // Check distance and if the target is valid for attack
                if (Helpers.GetDistance(base.me.X, base.me.Y, closestTarget.X, closestTarget.Y) <= range &&
                    this.AttackCheckMonster(closestTarget))
                {
                    // Perform the attack
                    if (!this.AttackDoAttack(closestTarget))
                    {
                        // Handle failure to attack (add logic here if needed)
                    }
                }

                attempts++;
            }

            // Pick items if enabled
            if (pickit)
            {
                this.PickItems();
            }

            return true;
        }


        // Token: 0x0600BEB7 RID: 48823 RVA: 0x0048F598 File Offset: 0x0048D798
        public bool AttackGetIntoPosition(AssignNPC unit, double distance, int coll, bool walk = false)
		{
			bool flag = base.GetCurrentLevel() == AreaLevel.ThroneOfDestruction && unit.NpcType == NPCCode.HellWitch && this.PatherMoveTo((long)((ulong)unit.X), (long)((ulong)unit.Y), false, 2f);
			bool flag2;
			if (flag)
			{
				flag2 = true;
			}
			else
			{
				bool flag3 = distance < 4.0 && unit.AnimationMode != 0 && unit.AnimationMode != 12;
				if (flag3)
				{
					if (walk)
					{
						bool flag4 = Helpers.GetDistance(base.me.X, base.me.Y, unit.X, unit.Y) > 8f || this.CheckCollision(unit, coll);
						if (flag4)
						{
							this.PatherWalkTo(unit.X, unit.Y, 2L);
						}
					}
					else
					{
						this.PatherMoveTo((long)((ulong)unit.X), (long)((ulong)unit.Y), false, 2f);
					}
					flag2 = true;
				}
				else
				{
					float[] array = new float[]
					{
						0f, 15f, -15f, 30f, -30f, 45f, -45f, 60f, -60f, 75f,
						-75f, 90f, -90f, 135f, -135f, 150f, -150f, 165f, -165f, 180f
					};
					double num = distance;
					for (int i = 0; i < 7; i++)
					{
						bool flag5 = i > 0;
						if (flag5)
						{
							distance = num - (double)(i * 2);
							bool flag6 = distance < 0.0;
							if (flag6)
							{
								return false;
							}
						}
						List<Vector2> list = new List<Vector2>();
						for (int j = 0; j < array.Length; j++)
						{
							float num2 = (float)Math.Round(Math.Cos((double)array[j] * 3.141592653589793 / 180.0) * distance + (double)unit.X);
							float num3 = (float)Math.Round(Math.Sin((double)array[j] * 3.141592653589793 / 180.0) * distance + (double)unit.Y);
							bool flag7 = this.PatherCheckSpot((long)num2, (long)num3, 1, false, 1);
							if (flag7)
							{
								list.Add(new Vector2(num2, num3));
							}
						}
						bool flag8 = list.Count == 0;
						if (!flag8)
						{
							list = list.OrderBy((Vector2 c) => Helpers.GetDistance(base.me.X, base.me.Y, (ushort)c.X, (ushort)c.Y)).ToList<Vector2>();
							bool flag9 = this.InLineOfSight(unit, (ushort)list.First<Vector2>().X, (ushort)list.First<Vector2>().Y, coll, 1U);
							if (flag9)
							{
								return this.PatherMoveTo((long)list.First<Vector2>().X, (long)list.First<Vector2>().Y, false, 2f);
							}
						}
					}
					List<int> list2;
					if (!this.PatherUseTeleport())
					{
						(list2 = new List<int>()).Add(1);
					}
					else
					{
						List<int> list3 = new List<int>();
						list3.Add(1);
						list3.Add(4);
						list3.Add(10);
						list3.Add(20);
						list2 = list3;
						list3.Add(35);
					}
					List<int> list4 = list2;
					AreaLevel currentLevel = base.GetCurrentLevel();
					Level level = this.GameInstance.LevelData[currentLevel];
					List<Node> path = level.GetPath(new Vector2((float)base.me.X, (float)base.me.Y), new Vector2((float)unit.X, (float)unit.Y), list4);
					foreach (Node node in path)
					{
						bool flag10 = this.InLineOfSight(unit, (ushort)((ulong)level.X + (ulong)((long)node.X)), (ushort)((ulong)level.Y + (ulong)((long)node.Y)), coll, 1U);
						if (flag10)
						{
							return this.PatherMoveTo((long)((ulong)level.X + (ulong)((long)node.X)), (long)((ulong)level.Y + (ulong)((long)node.Y)), false, 2f);
						}
					}
					Console.WriteLine("No valid positions for");
					flag2 = false;
				}
			}
			return flag2;
		}

		// Token: 0x0600BEB8 RID: 48824 RVA: 0x0048F98C File Offset: 0x0048DB8C
		public bool AttackValidSpot(ushort x, ushort y)
		{
			return true;
		}

		// Token: 0x0600BEB9 RID: 48825 RVA: 0x0048F9A0 File Offset: 0x0048DBA0
		public bool AttackCheckMonster(AssignNPC unit)
		{
			bool flag = unit.Life == 0 || unit.AnimationMode == 0 || unit.AnimationMode == 12;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				bool flag3 = unit.MonStats.Align == 1;
				if (flag3)
				{
					flag2 = false;
				}
				else
				{
					NPCCode npcType = unit.NpcType;
					NPCCode npccode = npcType;
					if (npccode <= NPCCode.Cow)
					{
						if (npccode - NPCCode.SandMaggot <= 4)
						{
							goto IL_00C0;
						}
						if (npccode - NPCCode.CarrionBird > 4)
						{
							if (npccode != NPCCode.Cow)
							{
								goto IL_00D6;
							}
							return false;
						}
					}
					else if (npccode <= NPCCode.BaalThrone)
					{
						if (npccode - NPCCode.WaterWatcherLimb <= 5)
						{
							goto IL_00C0;
						}
						if (npccode != NPCCode.BaalThrone)
						{
							goto IL_00D6;
						}
						return false;
					}
					else if (npccode != NPCCode.CarrionBird2)
					{
						if (npccode != NPCCode.WorldKiller2)
						{
							goto IL_00D6;
						}
						goto IL_00C0;
					}
					bool flag4 = unit.AnimationMode == 8;
					if (flag4)
					{
						return false;
					}
					goto IL_00D6;
					IL_00C0:
					bool flag5 = unit.AnimationMode == 14;
					if (flag5)
					{
						return false;
					}
					IL_00D6:
					flag2 = true;
				}
			}
			return flag2;
		}

		// Token: 0x0600BEBA RID: 48826 RVA: 0x0048FA88 File Offset: 0x0048DC88
		public void SetupAttacks()
		{
			bool flag = base.me.Attributes[StatType.Level] == 1U;
			if (flag)
			{
				this.Config.PrimarySkill = SkillType.FireBolt;
			}
			bool flag2 = base.me.Attributes[StatType.Level] > 1U && base.me.Attributes[StatType.Level] < 12U;
			if (flag2)
			{
				this.Config.PrimarySkill = SkillType.ChargedBolt;
			}
			bool flag3 = base.me.Attributes[StatType.Level] >= 12U && base.me.Attributes[StatType.Level] < 30U;
			if (flag3)
			{
				this.Config.PrimarySkill = SkillType.Nova;
			}
			bool flag4 = base.me.Attributes[StatType.Level] > 6U && base.me.Attributes[StatType.Level] <= 12U;
			if (flag4)
			{
				this.Config.PreAttackSkill = SkillType.FrostNova;
			}
			bool flag5 = this.SkillLog[SkillType.FireBall] > 0;
			if (flag5)
			{
				this.Config.PrimaryUntimedSkill = SkillType.FireBall;
			}
			bool flag6 = this.SkillLog[SkillType.Blizzard] > 0;
			if (flag6)
			{
				this.Config.PrimarySkill = SkillType.Blizzard;
			}
			this.Config.CastStatic = (int)((base.me.Attributes[StatType.Level] < 12U) ? ((GameDifficulty)30) : (GameDifficulty)(12 + (int)this.difficulty * 20));
			bool flag7 = base.me.Attributes[StatType.Level] < 6U;
			if (flag7)
			{
				this.Config.LowManaSkill = SkillType.Attack;
			}
		}

		// Token: 0x0600BEBB RID: 48827 RVA: 0x0048FC1C File Offset: 0x0048DE1C
		public bool AttackDoAttack(AssignNPC unit)
		{
			bool flag = this.Config.CastStatic < 100 && this.SkillLog[SkillType.StaticField] > 0 && this.Config.StaticList.Any((NPCCode u) => u == unit.NpcType) && Math.Round((double)((float)((int)(unit.Life * 100) / unit.MonStats.maxHP))) > (double)this.Config.CastStatic;
			if (flag)
			{
				double num = Math.Floor((double)((float)(this.SkillLog[SkillType.StaticField] + 4) * 2f / 3f));
				int num2 = 0;
				while (Math.Round((double)((float)unit.Life * 100f / (float)unit.MonStats.maxHP)) > (double)this.Config.CastStatic && this.AttackCheckMonster(unit))
				{
					bool flag2 = (double)Helpers.GetDistance(base.me.X, base.me.Y, unit.X, unit.Y) > num;
					if (flag2)
					{
						bool flag3 = !this.AttackGetIntoPosition(unit, num - 1.0, 4, false);
						if (flag3)
						{
							return false;
						}
					}
					bool flag4 = base.GetCurrentLevel() == AreaLevel.Tristram;
					if (flag4)
					{
						this.TownCheck();
					}
					bool flag5 = unit.NpcType == NPCCode.BaalCrab && (float)(base.me.Life * 100) / 300f < 45f;
					if (flag5)
					{
						break;
					}
					bool flag6 = num2 == 3 && (int)(unit.Life * 100) / unit.MonStats.maxHP > 95;
					if (flag6)
					{
						this.AttackGetIntoPosition(unit, num - 1.0, 4, false);
					}
					num2++;
				}
			}
			this.SetupAttacks();
			SkillType skillType = ((unit.IsChampion || unit.IsUnique || unit.IsSuperUnique) ? this.Config.PrimaryBossSkill : this.Config.PrimarySkill);
			bool flag7 = this.difficulty >= GameDifficulty.Nightmare && this.SkillLog[SkillType.FireBall] > 0 && base.GetCurrentLevel() == AreaLevel.ThroneOfDestruction && (unit.NpcType == NPCCode.HellWitch || (unit.NpcType == NPCCode.BaalSubjectMummy && unit.MonStats.ResCo > 100));
			if (flag7)
			{
				skillType = SkillType.FireBall;
			}
			bool flag8 = skillType != SkillType.Invalid;
			if (flag8)
			{
				bool flag9 = this.Config.ImmuneSkill != SkillType.Invalid && !this.AttackCheckResist(unit, skillType, 100);
				if (flag9)
				{
					skillType = this.Config.ImmuneSkill;
				}
				bool flag10 = this.Config.LowManaSkill != SkillType.Invalid && this.SkillGetManaCost(skillType) > (float)base.me.Mana && this.AttackCheckMonster(unit);
				if (flag10)
				{
					skillType = this.Config.LowManaSkill;
				}
				bool flag11 = !this.AttackCheckResist(unit, skillType, 100);
				if (flag11)
				{
					skillType = SkillType.Invalid;
				}
			}
			SkillType skillType2 = ((unit.IsChampion || unit.IsUnique || unit.IsSuperUnique) ? this.Config.PrimaryUntimedBossSkill : this.Config.PrimaryUntimedSkill);
			bool flag12 = skillType2 != SkillType.Invalid;
			if (flag12)
			{
				bool flag13 = !this.AttackCheckResist(unit, skillType2, 100);
				if (flag13)
				{
					skillType2 = this.Config.ImmuneUntimedSkill;
				}
				bool flag14 = this.Config.LowManaSkill != SkillType.Invalid && this.SkillGetManaCost(skillType2) > (float)base.me.Mana && this.AttackCheckMonster(unit);
				if (flag14)
				{
					skillType2 = this.Config.LowManaSkill;
				}
				bool flag15 = !this.AttackCheckResist(unit, skillType2, 100);
				if (flag15)
				{
					skillType2 = SkillType.Invalid;
				}
			}
			return this.AttackDoCast(unit, skillType, skillType2);
		}

		// Token: 0x0600BEBC RID: 48828 RVA: 0x0049009C File Offset: 0x0048E29C
		public int AttackGetResist(AssignNPC unit, string etype)
		{
			if (etype != null)
			{
				switch (etype.Length)
				{
				case 0:
					return 0;
				case 4:
				{
					char c = etype[0];
					if (c <= 'f')
					{
						if (c != 'c')
						{
							if (c == 'f')
							{
								if (etype == "fire")
								{
									return (this.difficulty == GameDifficulty.Normal) ? unit.MonStats.ResFi : ((this.difficulty == GameDifficulty.Nightmare) ? unit.MonStats.ResFiN : unit.MonStats.ResFiH);
								}
							}
						}
						else if (etype == "cold")
						{
							return (this.difficulty == GameDifficulty.Normal) ? unit.MonStats.ResCo : ((this.difficulty == GameDifficulty.Nightmare) ? unit.MonStats.ResCoN : unit.MonStats.ResCoH);
						}
					}
					else if (c != 'l')
					{
						if (c == 'n')
						{
							if (etype == "none")
							{
								return 0;
							}
						}
					}
					else if (etype == "ltng")
					{
						return (this.difficulty == GameDifficulty.Normal) ? unit.MonStats.ResLi : ((this.difficulty == GameDifficulty.Nightmare) ? unit.MonStats.ResLiN : unit.MonStats.ResLiH);
					}
					break;
				}
				case 5:
					if (etype == "magic")
					{
						return (this.difficulty == GameDifficulty.Normal) ? unit.MonStats.ResMa : ((this.difficulty == GameDifficulty.Nightmare) ? unit.MonStats.ResMaN : unit.MonStats.ResMaH);
					}
					break;
				case 6:
					if (etype == "poison")
					{
						return (this.difficulty == GameDifficulty.Normal) ? unit.MonStats.ResPo : ((this.difficulty == GameDifficulty.Nightmare) ? unit.MonStats.ResPoN : unit.MonStats.ResPoH);
					}
					break;
				case 8:
				{
					char c = etype[0];
					if (c != 'h')
					{
						if (c == 'p')
						{
							if (etype == "physical")
							{
								return (this.difficulty == GameDifficulty.Normal) ? unit.MonStats.ResDm : ((this.difficulty == GameDifficulty.Nightmare) ? unit.MonStats.ResDmN : unit.MonStats.ResDmH);
							}
						}
					}
					else if (etype == "holybolt")
					{
						return unit.NpcType.ToString().ToLower().Contains("undead") ? 0 : 100;
					}
					break;
				}
				case 9:
					if (etype == "lightning")
					{
						return (this.difficulty == GameDifficulty.Normal) ? unit.MonStats.ResLi : ((this.difficulty == GameDifficulty.Nightmare) ? unit.MonStats.ResLiN : unit.MonStats.ResLiH);
					}
					break;
				}
			}
			return 100;
		}

		// Token: 0x0600BEBD RID: 48829 RVA: 0x004903D8 File Offset: 0x0048E5D8
		public bool AttackCheckResist(AssignNPC unit, SkillType skill, int maxres = 100)
		{
			string skillType = SkillHelper.GetSkillType(skill);
			bool flag = skillType.Contains("fire") || skillType.Contains("lightning") || skillType.Contains("cold");
			bool flag2 = false;
			bool flag3 = skill == SkillType.StaticField && this.AttackGetResist(unit, skillType) < 100;
			bool flag4;
			if (flag3)
			{
				flag4 = (int)(unit.Life * 100 / 128) > this.Config.CastStatic;
			}
			else
			{
				bool flag5 = flag2 && flag;
				if (flag5)
				{
					flag4 = this.AttackGetResist(unit, skillType) < 117;
				}
				else
				{
					flag4 = this.AttackGetResist(unit, skillType) < maxres;
				}
			}
			return flag4;
		}

		// Token: 0x0600BEBE RID: 48830 RVA: 0x00490480 File Offset: 0x0048E680
		public bool AttackDoCast(AssignNPC unit, SkillType timedSkill, SkillType untimedSkill)
		{
			bool flag = this.Config.MercWatch && this.TownNeedMerc();
			if (flag)
			{
				this.TownDoChores();
			}
			bool flag2 = timedSkill != SkillType.Invalid && (!base.me.States[StateType.SkillDelay] || !SkillHelper.IsTimed(timedSkill));
			if (flag2)
			{
				bool flag3 = SkillHelper.GetRange(timedSkill, 1) < 4 && !this.AttackValidSpot(unit.X, unit.Y);
				if (flag3)
				{
					return false;
				}
				float num = Vector2.Distance(new Vector2((float)base.me.X, (float)base.me.Y), new Vector2((float)unit.X, (float)unit.Y));
				bool flag4 = Vector2.Distance(new Vector2((float)base.me.X, (float)base.me.Y), new Vector2((float)unit.X, (float)unit.Y)) > (float)SkillHelper.GetRange(timedSkill, 1);
				if (flag4)
				{
					bool flag5 = false;
					bool flag6 = base.GetCurrentLevel() == AreaLevel.MooMooFarm && timedSkill == SkillType.Blizzard;
					if (flag6)
					{
						this.AttackGetIntoPosition(unit, 30.0, 4, flag5);
					}
					else
					{
						bool flag7 = !this.AttackGetIntoPosition(unit, (double)SkillHelper.GetRange(timedSkill, 1), 4, flag5);
						if (flag7)
						{
							Console.WriteLine("failed to get into pos");
							Vector2 randomNearbyPos = this.GetRandomNearbyPos();
							this.PatherMoveTo((long)((ulong)((ushort)randomNearbyPos.X)), (long)((ulong)((ushort)randomNearbyPos.Y)), false, 2f);
							return this.AttackDoCast(unit, timedSkill, untimedSkill);
						}
					}
				}
				bool flag8 = unit.Life > 0;
				if (flag8)
				{
					this.SkillCastSkill(timedSkill, unit);
				}
			}
			else
			{
				bool flag9 = untimedSkill != SkillType.Invalid;
				if (flag9)
				{
					bool flag10 = SkillHelper.GetRange(untimedSkill, 1) < 4 && !this.AttackValidSpot(unit.X, unit.Y);
					if (flag10)
					{
						return false;
					}
					bool flag11 = Math.Round((double)Helpers.GetDistance(base.me.X, base.me.Y, unit.X, unit.Y)) > (double)SkillHelper.GetRange(untimedSkill, 1);
					if (flag11)
					{
						bool flag12 = SkillHelper.GetRange(untimedSkill, 1) < 4 && Helpers.GetDistance(base.me.X, base.me.Y, unit.X, unit.Y) < 10f;
						bool flag13 = !this.AttackGetIntoPosition(unit, (double)SkillHelper.GetRange(untimedSkill, 1), 4, flag12);
						if (flag13)
						{
							return false;
						}
					}
					bool flag14 = unit.Life > 0;
					if (flag14)
					{
						this.SkillCastSkill(untimedSkill, unit);
					}
					return true;
				}
			}
			for (int i = 0; i < 25; i++)
			{
			}
			return true;
		}

        // Token: 0x0600BEBF RID: 48831 RVA: 0x00490760 File Offset: 0x0048E960\
        // [Ares] from GPT, Should review one more

        public void KillUnit(AssignNPC unit)
        {
            if (unit == null) return;

            int actionCount = 1;

            while (unit.Life > 0)
            {
                // Refresh unit data
                unit = this.GameInstance.NPCs.Values.FirstOrDefault(npc => npc.Id == unit.Id);

                // Exit if unit is null or coordinates are invalid
                if (unit == null || unit.X == 0 || unit.Y == 0)
                    break;

                int distance = 0;
                ushort range = SkillHelper.GetRange(this.LeftSkill, 1);

                if (distance <= range)
                {
                    // Perform attack
                    if (base.me.Class == CharacterClass.Sorceress && base.me.Mana > 1 && unit.MonStats.isMelee == 0)
                    {
                        base.SendPacket(new CastLeftSkillOnTarget
                        {
                            Type = UnitType.NPC,
                            Id = unit.Id
                        });
                        Thread.Sleep(this.CastRateDelay());
                    }
                    else
                    {
                        base.SendPacket(new CastLeftSkillOnTarget
                        {
                            Type = UnitType.NPC,
                            Id = unit.Id
                        });
                        Thread.Sleep(this.AttackRateDelay());
                    }
                }
                else if (distance < 6)
                {
                    // Move closer to the unit and attack
                    this.MoveToUnit(unit.Id);
                    Thread.Sleep(distance * 1000 / 17);

                    if (base.me.Class == CharacterClass.Sorceress && base.me.Mana > 1)
                    {
                        base.SendPacket(new CastLeftSkillOnTarget
                        {
                            Type = UnitType.NPC,
                            Id = unit.Id
                        });
                        Thread.Sleep(this.CastRateDelay());
                    }
                    else
                    {
                        base.SendPacket(new CastLeftSkillOnTarget
                        {
                            Type = UnitType.NPC,
                            Id = unit.Id
                        });
                        Thread.Sleep(this.AttackRateDelay());
                    }

                    // Periodically update position
                    if (actionCount++ % 12 == 0)
                    {
                        base.SendPacket(new UpdatePosition
                        {
                            X = unit.X,
                            Y = unit.Y
                        });
                    }
                }
            }
        }


        // Token: 0x0600BEC0 RID: 48832 RVA: 0x004909D4 File Offset: 0x0048EBD4
        public void ClearTp(ushort distance = 20, AreaLevel level = AreaLevel.None)
		{
			bool flag = distance > 0;
			if (flag)
			{
				this.KillSurrounding(distance);
			}
			base.SendPacket(new UseInventoryItem
			{
				Id = this.inventoryTome.Id,
				X = (uint)base.me.X,
				Y = (uint)base.me.Y
			});
		}

		// Token: 0x0600BEC1 RID: 48833 RVA: 0x00490A34 File Offset: 0x0048EC34
		public void ClearArea(AreaLevel level = AreaLevel.None)
		{
			if (!this.PatherUseTeleport())
			{
				List<int> list;
				(list = new List<int>()).Add(1);
			}
			else
			{
				List<int> list2 = new List<int>();
				list2.Add(1);
				list2.Add(4);
				list2.Add(10);
				list2.Add(20);
				list2.Add(35);
			}
			bool flag = level == AreaLevel.None;
			if (flag)
			{
				level = base.GetCurrentLevel();
			}
			Level level2 = this.GameInstance.LevelData[base.GetCurrentLevel()];
			Level level3 = this.GameInstance.LevelData[level];
			List<Room> list3 = level3.Rooms.ToList<Room>();
			list3 = list3.FindAll((Room r) => r.GetMiddleOfRoomWalkable() != Vector2.Zero);
			int num = 0;
			float[,] costMatrix = new float[list3.Count, list3.Count];
			for (int i = 0; i < list3.Count; i++)
			{
				for (int j = 0; j < list3.Count; j++)
				{
					costMatrix[i, j] = 10000f;
					bool flag2 = list3[i].X <= (uint)base.me.X && list3[i].X + list3[i].Width >= (uint)base.me.X && list3[i].Y <= (uint)base.me.Y && list3[i].Y + list3[i].Height >= (uint)base.me.Y;
					if (flag2)
					{
						num = i;
					}
				}
			}
			for (int k = 0; k < list3.Count; k++)
			{
				for (int l = 0; l < list3.Count; l++)
				{
					bool flag3 = list3[k].IsAdjacent(list3[l]);
					if (flag3)
					{
						costMatrix[k, l] = (float)(10000 - level3.GetPathRoy(list3[k].GetMiddleOfRoomWalkable(), list3[l].GetMiddleOfRoomWalkable()).Count);
					}
				}
			}
			Solver solver = new Solver((int startIndex, int endIndex) => costMatrix[startIndex, endIndex], list3.Count, new Solver.SolverConfiguration
			{
				EnableSolutionMutation = true,
				FirstSolutionStrategy = eFirstSolutionStrategy.ConnectCheapestArcs
			});
			solver.SetStartNode(num);
			int[] array = solver.FindSolution();
			for (int m = 0; m < list3.Count; m++)
			{
				this.AttackClear(25, 0, 0, true);
				Vector2 middleOfRoomWalkable = list3[array[m]].GetMiddleOfRoomWalkable();
				this.PatherMoveTo((long)middleOfRoomWalkable.X, (long)middleOfRoomWalkable.Y, true, 2f);
				this.AttackClear(25, 0, 0, true);
				this.PickItems();
			}
		}

		// Token: 0x0600BEC2 RID: 48834 RVA: 0x00490D5D File Offset: 0x0048EF5D
		public void EnableBuildManagement()
		{
			this.OnAttributeChange = (Action<D2Packets.Game.Server.Attribute>)Delegate.Combine(this.OnAttributeChange, new Action<D2Packets.Game.Server.Attribute>(this.ManageStatsAndSkills));
			this.AllocateStatsAndSkills();
		}

		// Token: 0x0600BEC3 RID: 48835 RVA: 0x00490D8C File Offset: 0x0048EF8C
		private void ManageStatsAndSkills(D2Packets.Game.Server.Attribute attribute)
		{
			bool flag = attribute.Stat.Type == StatType.SkillPoints && ((AttributeByte)attribute).Value > 0;
			if (flag)
			{
				this.AllocateSkillPoint();
			}
			bool flag2 = attribute.Stat.Type == StatType.StatPoints && ((AttributeByte)attribute).Value > 0;
			if (flag2)
			{
				this.AllocateStatPoint();
			}
		}

		// Token: 0x0600BEC4 RID: 48836 RVA: 0x00490DF4 File Offset: 0x0048EFF4
		private void AllocateSkillPoint()
		{
			int totalAlloc = -8;
			this.SkillLog.Skills.ForEach(delegate(SkillsLog.SkillLevel s)
			{
				totalAlloc += (int)s.Level;
			});
			SkillType skillPoint = this.GetSkillPointAlloc(totalAlloc);
			SkillsLog.SkillLevel skillLevel = this.SkillLog.Skills.FirstOrDefault((SkillsLog.SkillLevel s) => s.Type == skillPoint);
			int num = (int)((skillLevel != null) ? skillLevel.Level : 0);
			bool flag = this.CanLevelUp(skillPoint, num);
			if (flag)
			{
				base.SendPacket(new IncrementSkill
				{
					Attribute = skillPoint
				}, delegate(Packet p)
				{
					AttributeByte attributeByte = p as AttributeByte;
					return attributeByte != null && (uint)attributeByte.Value < this.me.Attributes[StatType.SkillPoints];
				});
			}
		}

		// Token: 0x0600BEC5 RID: 48837 RVA: 0x00490EA8 File Offset: 0x0048F0A8
		private void AllocateStatPoint()
		{
			IncrementAttribute incrementAttribute = null;
			bool flag = base.me.Attributes[StatType.Energy] < 40U;
			if (flag)
			{
				incrementAttribute = new IncrementAttribute
				{
					StatD2R = StatType.Energy,
					AmountD2R = 5
				};
			}
			else
			{
				bool flag2 = base.me.Attributes[StatType.Vitality] < 15U;
				if (flag2)
				{
					incrementAttribute = new IncrementAttribute
					{
						StatD2R = StatType.Vitality,
						AmountD2R = 5
					};
				}
				else
				{
					bool flag3 = base.me.Attributes[StatType.Energy] < 45U;
					if (flag3)
					{
						incrementAttribute = new IncrementAttribute
						{
							StatD2R = StatType.Energy,
							AmountD2R = 5
						};
					}
					else
					{
						bool flag4 = base.me.Attributes[StatType.Vitality] < 20U;
						if (flag4)
						{
							incrementAttribute = new IncrementAttribute
							{
								StatD2R = StatType.Vitality,
								AmountD2R = 5
							};
						}
						else
						{
							bool flag5 = base.me.Attributes[StatType.Energy] < 50U;
							if (flag5)
							{
								incrementAttribute = new IncrementAttribute
								{
									StatD2R = StatType.Energy,
									AmountD2R = 5
								};
							}
							else
							{
								bool flag6 = base.me.Attributes[StatType.Vitality] < 25U;
								if (flag6)
								{
									incrementAttribute = new IncrementAttribute
									{
										StatD2R = StatType.Vitality,
										AmountD2R = 5
									};
								}
								else
								{
									bool flag7 = base.me.Attributes[StatType.Energy] < 60U;
									if (flag7)
									{
										incrementAttribute = new IncrementAttribute
										{
											StatD2R = StatType.Energy,
											AmountD2R = 5
										};
									}
									else
									{
										bool flag8 = base.me.Attributes[StatType.Vitality] < 40U;
										if (flag8)
										{
											incrementAttribute = new IncrementAttribute
											{
												StatD2R = StatType.Vitality,
												AmountD2R = 5
											};
										}
										else
										{
											bool flag9 = base.me.Attributes[StatType.Strength] < 15U;
											if (flag9)
											{
												incrementAttribute = new IncrementAttribute
												{
													StatD2R = StatType.Strength,
													AmountD2R = 5
												};
											}
											else
											{
												bool flag10 = base.me.Attributes[StatType.Vitality] < 900U;
												if (flag10)
												{
													incrementAttribute = new IncrementAttribute
													{
														StatD2R = StatType.Vitality,
														AmountD2R = 5
													};
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
			bool flag11 = incrementAttribute != null;
			if (flag11)
			{
				base.SendPacket(incrementAttribute, delegate(Packet p)
				{
					AttributeByte attributeByte = p as AttributeByte;
					return attributeByte != null && (uint)attributeByte.Value <= base.me.Attributes[StatType.StatPoints];
				});
			}
		}

		// Token: 0x0600BEC6 RID: 48838 RVA: 0x004910D4 File Offset: 0x0048F2D4
		private void AllocateStatsAndSkills()
		{
			while (base.me.Attributes.ContainsKey(StatType.SkillPoints) && base.me.Attributes[StatType.SkillPoints] > 0U)
			{
				this.AllocateSkillPoint();
			}
			while (base.me.Attributes.ContainsKey(StatType.StatPoints) && base.me.Attributes[StatType.StatPoints] > 0U)
			{
				this.AllocateStatPoint();
			}
		}

		// Token: 0x0600BEC7 RID: 48839 RVA: 0x00491154 File Offset: 0x0048F354
		private bool CanLevelUp(SkillType skill, int level)
		{
			int num = 1;
			bool flag = base.me.Class == CharacterClass.Sorceress;
			if (flag)
			{
				bool flag2 = skill < SkillType.Inferno;
				if (flag2)
				{
					num = 1;
				}
				else
				{
					bool flag3 = skill < SkillType.Blaze;
					if (flag3)
					{
						num = 6;
					}
					else
					{
						bool flag4 = skill < SkillType.FireWall;
						if (flag4)
						{
							num = 12;
						}
						else
						{
							bool flag5 = skill < SkillType.Meteor;
							if (flag5)
							{
								num = 18;
							}
							else
							{
								bool flag6 = skill < SkillType.FireMastery;
								if (flag6)
								{
									num = 24;
								}
								else
								{
									num = 30;
								}
							}
						}
					}
				}
			}
			return (ulong)base.me.Attributes[StatType.Level] > (ulong)((long)(num + level));
		}

		// Token: 0x0600BEC8 RID: 48840 RVA: 0x004911E4 File Offset: 0x0048F3E4
		private List<SkillType> GetSkillOrder()
		{
			List<SkillType> levelUpOrder = new List<SkillType>();
			bool flag = base.me.Class == CharacterClass.Sorceress;
			if (flag)
			{
				bool flag2 = base.me.Attributes[StatType.Level] < (uint)this.Config.FirstRespecLevel;
				if (flag2)
				{
					Enumerable.Range(0, 3).ToList<int>().ForEach(delegate(int s)
					{
						levelUpOrder.Add(SkillType.ChargedBolt);
					});
					Enumerable.Range(0, 1).ToList<int>().ForEach(delegate(int s)
					{
						levelUpOrder.Add(SkillType.IceBolt);
					});
					Enumerable.Range(0, 1).ToList<int>().ForEach(delegate(int s)
					{
						levelUpOrder.Add(SkillType.FrozenArmor);
					});
					Enumerable.Range(0, 1).ToList<int>().ForEach(delegate(int s)
					{
						levelUpOrder.Add(SkillType.Telekinesis);
					});
					Enumerable.Range(0, 1).ToList<int>().ForEach(delegate(int s)
					{
						levelUpOrder.Add(SkillType.FrostNova);
					});
					Enumerable.Range(0, 4).ToList<int>().ForEach(delegate(int s)
					{
						levelUpOrder.Add(SkillType.StaticField);
					});
					Enumerable.Range(0, 1).ToList<int>().ForEach(delegate(int s)
					{
						levelUpOrder.Add(SkillType.IceBlast);
					});
					Enumerable.Range(0, 7).ToList<int>().ForEach(delegate(int s)
					{
						levelUpOrder.Add(SkillType.Nova);
					});
					Enumerable.Range(0, 1).ToList<int>().ForEach(delegate(int s)
					{
						levelUpOrder.Add(SkillType.GlacialSpike);
					});
					Enumerable.Range(0, 1).ToList<int>().ForEach(delegate(int s)
					{
						levelUpOrder.Add(SkillType.Teleport);
					});
					Enumerable.Range(0, 1).ToList<int>().ForEach(delegate(int s)
					{
						levelUpOrder.Add(SkillType.StaticField);
					});
					Enumerable.Range(0, 3).ToList<int>().ForEach(delegate(int s)
					{
						levelUpOrder.Add(SkillType.IceBlast);
					});
					Enumerable.Range(0, 6).ToList<int>().ForEach(delegate(int s)
					{
						levelUpOrder.Add(SkillType.Blizzard);
					});
					Enumerable.Range(0, 1).ToList<int>().ForEach(delegate(int s)
					{
						levelUpOrder.Add(SkillType.ColdMastery);
					});
				}
				else
				{
					bool flag3 = base.me.Attributes[StatType.Level] < (uint)this.Config.SecondRespecLevel;
					if (flag3)
					{
						Enumerable.Range(0, 1).ToList<int>().ForEach(delegate(int s)
						{
							levelUpOrder.Add(SkillType.Warmth);
						});
						Enumerable.Range(0, 1).ToList<int>().ForEach(delegate(int s)
						{
							levelUpOrder.Add(SkillType.StaticField);
						});
						Enumerable.Range(0, 1).ToList<int>().ForEach(delegate(int s)
						{
							levelUpOrder.Add(SkillType.Telekinesis);
						});
						Enumerable.Range(0, 1).ToList<int>().ForEach(delegate(int s)
						{
							levelUpOrder.Add(SkillType.FrozenArmor);
						});
						Enumerable.Range(0, 1).ToList<int>().ForEach(delegate(int s)
						{
							levelUpOrder.Add(SkillType.IceBolt);
						});
						Enumerable.Range(0, 1).ToList<int>().ForEach(delegate(int s)
						{
							levelUpOrder.Add(SkillType.FrostNova);
						});
						Enumerable.Range(0, 12).ToList<int>().ForEach(delegate(int s)
						{
							levelUpOrder.Add(SkillType.IceBlast);
						});
						Enumerable.Range(0, 1).ToList<int>().ForEach(delegate(int s)
						{
							levelUpOrder.Add(SkillType.GlacialSpike);
						});
						Enumerable.Range(0, 5).ToList<int>().ForEach(delegate(int s)
						{
							levelUpOrder.Add(SkillType.Teleport);
						});
						Enumerable.Range(0, 6).ToList<int>().ForEach(delegate(int s)
						{
							levelUpOrder.Add(SkillType.Blizzard);
						});
						Enumerable.Range(0, 1).ToList<int>().ForEach(delegate(int s)
						{
							levelUpOrder.Add(SkillType.ColdMastery);
						});
						Enumerable.Range(0, 1).ToList<int>().ForEach(delegate(int s)
						{
							levelUpOrder.Add(SkillType.Teleport);
						});
						Enumerable.Range(0, 11).ToList<int>().ForEach(delegate(int s)
						{
							levelUpOrder.Add(SkillType.Blizzard);
						});
						Enumerable.Range(0, 1).ToList<int>().ForEach(delegate(int s)
						{
							levelUpOrder.Add(SkillType.ColdMastery);
						});
						Enumerable.Range(0, 1).ToList<int>().ForEach(delegate(int s)
						{
							levelUpOrder.Add(SkillType.ColdMastery);
						});
						Enumerable.Range(0, 3).ToList<int>().ForEach(delegate(int s)
						{
							levelUpOrder.Add(SkillType.Blizzard);
						});
						Enumerable.Range(0, 10).ToList<int>().ForEach(delegate(int s)
						{
							levelUpOrder.Add(SkillType.ColdMastery);
						});
						Enumerable.Range(0, 8).ToList<int>().ForEach(delegate(int s)
						{
							levelUpOrder.Add(SkillType.IceBlast);
						});
						Enumerable.Range(0, 8).ToList<int>().ForEach(delegate(int s)
						{
							levelUpOrder.Add(SkillType.IceBolt);
						});
					}
					else
					{
						bool flag4 = base.me.Attributes[StatType.Level] < (uint)this.Config.ThirdRespecLevel;
						if (flag4)
						{
						}
					}
				}
			}
			else
			{
				bool flag5 = base.me.Class == CharacterClass.Barbarian;
				if (flag5)
				{
					levelUpOrder = new List<SkillType>
					{
						SkillType.AxeMastery,
						SkillType.AxeMastery,
						SkillType.AxeMastery,
						SkillType.AxeMastery
					};
				}
				else
				{
					bool flag6 = base.me.Class == CharacterClass.Paladin;
					if (flag6)
					{
						levelUpOrder = new List<SkillType>
						{
							SkillType.Might,
							SkillType.Might,
							SkillType.Might,
							SkillType.Might
						};
					}
					else
					{
						bool flag7 = base.me.Class == CharacterClass.Druid;
						if (flag7)
						{
							levelUpOrder = new List<SkillType>
							{
								SkillType.Raven,
								SkillType.PoisonCreeper,
								SkillType.Werewolf,
								SkillType.ShapeShifting
							};
						}
					}
				}
			}
			return levelUpOrder;
		}

		// Token: 0x0600BEC9 RID: 48841 RVA: 0x00491778 File Offset: 0x0048F978
		private SkillType GetSkillPointAlloc(int index)
		{
			return this.GetSkillOrder()[index];
		}

		// Token: 0x0600BECA RID: 48842 RVA: 0x00491798 File Offset: 0x0048F998
		public int AttackRateDelay()
		{
			bool flag = base.me.Class == CharacterClass.Sorceress;
			int num;
			if (flag)
			{
				num = (int)AttackSpeedBreakpoints.GetTimeDelay(base.me.Class, 6, false);
			}
			else
			{
				num = (int)AttackSpeedBreakpoints.GetTimeDelay(base.me.Class, 2, false);
			}
			return num;
		}

		// Token: 0x0600BECB RID: 48843 RVA: 0x004917E4 File Offset: 0x0048F9E4
		public int CastRateDelay()
		{
			int num = 0;
			foreach (KeyValuePair<EquipmentLocation, ItemAction> keyValuePair in base.me.Equipment)
			{
				SignedStat signedStat = (SignedStat)keyValuePair.Value[StatType.FasterCastRate];
				bool flag = signedStat != null;
				if (flag)
				{
					num += signedStat.Value;
				}
			}
			return (int)CastRateBreakpoints.GetTimeDelay(base.me.Class, (ushort)num);
		}

		// Token: 0x0600BECC RID: 48844 RVA: 0x0049187C File Offset: 0x0048FA7C
		public int FhrDelay()
		{
			int num = 0;
			foreach (KeyValuePair<EquipmentLocation, ItemAction> keyValuePair in base.me.Equipment)
			{
				SignedStat signedStat = (SignedStat)keyValuePair.Value[StatType.FasterHitRecovery];
				bool flag = signedStat != null;
				if (flag)
				{
					num += signedStat.Value;
				}
			}
			return (int)HitRecoveryBreakpoints.GetTimeDelay(base.me.Class, 280);
		}

		// Token: 0x0600BECD RID: 48845 RVA: 0x00491918 File Offset: 0x0048FB18
		public float Velocity()
		{
			int num = 0;
			foreach (KeyValuePair<EquipmentLocation, ItemAction> keyValuePair in base.me.Equipment)
			{
				SignedStat signedStat = (SignedStat)keyValuePair.Value[StatType.FasterMoveVelocity];
				bool flag = signedStat != null;
				if (flag)
				{
					num += signedStat.Value;
				}
			}
			float num2 = 8f;
			float num3 = 0f;
			float num4 = 0f;
			float num5 = num2 * (1f + (num3 + (float)num * 150f / ((float)num + 150f) + num4) / 100f);
			bool flag2 = num2 / 4f > num5;
			if (flag2)
			{
				num5 = num2;
			}
			return num5 + 6f;
		}

		// Token: 0x0600BECE RID: 48846 RVA: 0x004919FC File Offset: 0x0048FBFC
		public void Interact(GameObjectID gameObjectID)
		{
			AssignGameObject assignGameObject = this.GameInstance.GameObjects.Values.FirstOrDefault((AssignGameObject g) => g.ObjectId == gameObjectID);
			this.Interact(assignGameObject);
		}

		// Token: 0x0600BECF RID: 48847 RVA: 0x00491A44 File Offset: 0x0048FC44
		public void Interact(AssignGameObject obj)
		{
			bool flag = obj == null;
			if (!flag)
			{
				bool flag2 = Vector2.Distance(new Vector2((float)base.me.X, (float)base.me.Y), new Vector2((float)obj.X, (float)obj.Y)) > 5f;
				if (flag2)
				{
					this.PatherMoveTo((long)((ulong)obj.X), (long)((ulong)obj.Y), false, 2f);
				}
				bool flag3 = obj.ObjectId.ToString().Contains("Waypoint");
				if (flag3)
				{
					UnitInteract unitInteract = new UnitInteract();
					unitInteract.Type = UnitType.GameObject;
					unitInteract.Id = obj.Id;
					bool flag4 = !base.SendPacket(unitInteract, (Packet p) => p is OpenWaypoint);
					if (flag4)
					{
						Thread.Sleep(100);
						UnitInteract unitInteract2 = new UnitInteract();
						unitInteract2.Type = UnitType.GameObject;
						unitInteract2.Id = obj.Id;
						bool flag5 = !base.SendPacket(unitInteract2, (Packet p) => p is OpenWaypoint);
						if (flag5)
						{
							return;
						}
						return;
					}
				}
				else
				{
					bool flag6 = obj.ObjectId == GameObjectID.Bank;
					if (!flag6)
					{
						bool flag7 = obj.ObjectId == GameObjectID.TownPortal;
						if (flag7)
						{
							bool flag8 = base.InTown();
							base.SendPacket(new UnitInteract
							{
								Type = UnitType.GameObject,
								Id = obj.Id
							});
							Thread.Sleep(500);
							while (flag8 == base.InTown())
							{
								this.PatherMoveTo((long)(base.me.X - 5), (long)((ulong)base.me.Y), false, 2f);
								this.PatherMoveTo((long)((ulong)base.me.X), (long)((ulong)base.me.Y), false, 2f);
								base.SendPacket(new UnitInteract
								{
									Type = UnitType.GameObject,
									Id = obj.Id
								});
								Thread.Sleep(500);
							}
						}
						else
						{
							base.SendPacket(new UnitInteract
							{
								Type = UnitType.GameObject,
								Id = obj.Id
							});
						}
					}
				}
				Thread.Sleep(this.Random.Next(250, 750));
			}
		}

		// Token: 0x0600BED0 RID: 48848 RVA: 0x00491CAC File Offset: 0x0048FEAC
		public void WarpInteract(AssignWarp warp)
		{
			AreaLevel currentLevel = base.GetCurrentLevel();
			while (base.GetCurrentLevel() == currentLevel)
			{
				base.SendPacket(new WarpInteract
				{
					Id = warp.Id
				});
				Thread.Sleep(this.Random.Next(500, 1000));
			}
		}

		// Token: 0x0600BED1 RID: 48849 RVA: 0x00491D08 File Offset: 0x0048FF08
		public void Interact(PresetUnit unit)
		{
			bool flag = (byte)unit.Type == 5;
			if (flag)
			{
				AssignWarp value = this.GameInstance.Warps.FirstOrDefault((KeyValuePair<uint, AssignWarp> w) => w.Value.Warp == unit.CastedWarpType).Value;
				bool flag2 = value != null;
				if (flag2)
				{
					this.WarpInteract(value);
				}
			}
		}

		// Token: 0x0600BED2 RID: 48850 RVA: 0x00491D6F File Offset: 0x0048FF6F
		public void EnableLifeManagement()
		{
			this.OnPlayerLifeManaChange = (Action)Delegate.Combine(this.OnPlayerLifeManaChange, new Action(this.ManageLife));
		}

		// Token: 0x0600BED3 RID: 48851 RVA: 0x00491D94 File Offset: 0x0048FF94
		private void DrinkPotion(Game.PotType pot)
		{
			int tickCount = Environment.TickCount;
			bool flag = tickCount - this.timerLastDrink[pot] < this.potDelay[pot];
			if (!flag)
			{
				this.timerLastDrink[pot] = tickCount;
				ItemAction itemAction = this.GameInstance.Items.Values.FirstOrDefault((ItemAction i) => i.container == ItemContainer.Inventory && i.baseItem.BaseType.Type == this.potType[pot] && i.action != ItemActionType.RemoveFromContainer);
				ItemAction potInBelt = this.GameInstance.Items.Values.FirstOrDefault((ItemAction i) => (i.container == ItemContainer.Belt || i.action == ItemActionType.SwapInContainer || i.destination == ItemDestination.Belt) && i.action != ItemActionType.PutInBelt && i.baseItem.BaseType.Type == this.potType[pot]);
				bool flag2 = itemAction != null;
				if (flag2)
				{
					Console.WriteLine(string.Concat(new string[]
					{
						"using pot from inventory ",
						itemAction.baseItem.Type.ToString(),
						" : ",
						itemAction.x.ToString(),
						", ",
						itemAction.y.ToString()
					}));
					base.SendPacket(new UseItem
					{
						Consume = 1,
						ItemId = itemAction.Id,
						PlayerId = base.me.Id,
						X = (byte)itemAction.x,
						Y = (byte)itemAction.y
					});
				}
				else
				{
					bool flag3 = potInBelt != null;
					if (flag3)
					{
						uint num = ((pot <= Game.PotType.Rejuv) ? base.me.Id : this.Mercs.Values.Last((AssignMerc m) => m.OwnerId == this.me.Id).Id);
						IEnumerable<ItemAction> enumerable = from i in this.GameInstance.Items.Values
							where i.container == ItemContainer.Belt || i.action == ItemActionType.SwapInContainer || i.destination == ItemDestination.Belt
							where i.action != ItemActionType.PutInBelt
							select i;
						UseItem useItem = new UseItem
						{
							ItemId = potInBelt.Id,
							Consume = 1,
							PlayerId = num,
							isMerc = (byte)((num == base.me.Id) ? 0 : 1),
							X = (byte)potInBelt.x,
							Y = (byte)potInBelt.y,
							xff02ifbelt = 65282
						};
						useItem.X %= 4;
						List<ItemAction> list = (from p in enumerable
							where p.x % 4 == potInBelt.x % 4
							orderby p.x
							select p).ToList<ItemAction>();
						bool flag4 = list.Count > 1;
						if (flag4)
						{
							useItem.ItemId = list[0].Id;
						}
						for (int j = 0; j < list.Count - 1; j++)
						{
							useItem.Pots[j].Id = list[j + 1].Id;
							useItem.Pots[j].PrevPos = (byte)list[j + 1].x;
							useItem.Pots[j].NewPos = (byte)list[j].x;
						}
						Console.WriteLine(string.Concat(new string[]
						{
							"using pot from belt ",
							this.GameInstance.Items[useItem.ItemId].baseItem.Type.ToString(),
							" : ",
							this.GameInstance.Items[useItem.ItemId].x.ToString(),
							", ",
							this.GameInstance.Items[useItem.ItemId].y.ToString()
						}));
						base.SendPacket(useItem);
					}
				}
			}
		}

		// Token: 0x0600BED4 RID: 48852 RVA: 0x004921CC File Offset: 0x004903CC
		private void ManageLife()
		{
			uint num = base.me.Attributes[StatType.MaxLife] >> 8;
			uint num2 = base.me.Attributes[StatType.MaxMana] >> 8;
			bool flag = base.InTown();
			if (!flag)
			{
				bool chickening = this.Chickening;
				if (!chickening)
				{
					bool flag2 = this.Config.LifeChicken > 0 && (double)base.me.Life <= Math.Floor((double)(num * (uint)this.Config.LifeChicken / 100f));
					if (flag2)
					{
						base.Terminate();
					}
					else
					{
						bool flag3 = this.Config.ManaChicken > 0 && (double)base.me.Mana <= Math.Floor((double)(num2 * (uint)this.Config.ManaChicken / 100f));
						if (flag3)
						{
							base.Terminate();
						}
						else
						{
							bool flag4 = this.Config.UseHP > 0 && (double)base.me.Life < Math.Floor((double)(num * (uint)this.Config.UseHP / 100f)) && !base.me.States[StateType.HealthPot];
							if (flag4)
							{
								this.DrinkPotion(Game.PotType.Health);
							}
							else
							{
								bool flag5 = this.Config.UseRejuvHP > 0 && (double)base.me.Life < Math.Floor((double)(num * (uint)this.Config.UseRejuvHP / 100f));
								if (flag5)
								{
									this.DrinkPotion(Game.PotType.Rejuv);
								}
								else
								{
									bool flag6 = this.Config.UseMP > 0 && (double)base.me.Mana < Math.Floor((double)(num2 * (uint)this.Config.UseMP / 100f)) && !base.me.States[StateType.ManaPot];
									if (flag6)
									{
										this.DrinkPotion(Game.PotType.Mana);
									}
									else
									{
										bool flag7 = this.Config.UseRejuvMP > 0 && (double)base.me.Mana < Math.Floor((double)(num2 * (uint)this.Config.UseRejuvMP / 100f));
										if (flag7)
										{
											this.DrinkPotion(Game.PotType.Rejuv);
										}
										else
										{
											bool flag8 = this.Config.TownHP > 0 && (double)base.me.Life < Math.Floor((double)(num * (uint)this.Config.TownHP / 100f));
											if (flag8)
											{
												this.TownChicken();
											}
											else
											{
												bool flag9 = this.Config.TownMP > 0 && (double)base.me.Mana < Math.Floor((double)(num2 * (uint)this.Config.TownMP / 100f));
												if (flag9)
												{
													this.TownChicken();
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

		// Token: 0x0600BED5 RID: 48853 RVA: 0x004924B0 File Offset: 0x004906B0
		private void TownChicken()
		{
			bool flag = this.inventoryTome == null;
			if (flag)
			{
				base.Terminate();
			}
			Task.Run(delegate
			{
				this.Chickening = true;
				bool flag2 = base.InTown();
				if (!flag2)
				{
					AreaLevel currentLevel = base.GetCurrentLevel();
					this.GoToTown(ActLocation.None);
					this.TownHeal();
					this.TownBuyPotions();
					this.GoToTpArea(ActLocation.None);
					this.TakeTpTo(currentLevel, "any_available_portal");
					this.Chickening = false;
				}
			});
		}

		// Token: 0x0600BED6 RID: 48854 RVA: 0x004924E4 File Offset: 0x004906E4
		public bool CheckCollision(AssignNPC unit, int collType)
		{
			return false;
		}

		// Token: 0x0600BED7 RID: 48855 RVA: 0x004924F8 File Offset: 0x004906F8
		public bool InLineOfSight(AssignNPC npc, ushort X, ushort Y, int coll, uint thickness = 1U)
		{
			Level level = this.GameInstance.LevelData[base.GetCurrentLevel()];
			double num = Math.Atan2((double)(npc.Y - Y), (double)(npc.X - X));
			double num2 = Math.Round((double)Helpers.GetDistance(npc.X, npc.Y, X, Y));
			int num3 = 1;
			while ((double)num3 < num2)
			{
				uint num4 = (uint)Math.Round(Math.Cos(num) * (double)num3 + (double)X);
				uint num5 = (uint)Math.Round(Math.Sin(num) * (double)num3 + (double)Y);
				for (uint num6 = num4 - thickness; num6 <= num4 + thickness; num6 += 1U)
				{
					for (uint num7 = num5 - thickness; num7 <= num5 + thickness; num7 += 1U)
					{
						bool flag = level.IsWall(num6, num7);
						if (flag)
						{
							return false;
						}
					}
				}
				num3++;
			}
			return true;
		}

		// Token: 0x0600BED8 RID: 48856 RVA: 0x004925F4 File Offset: 0x004907F4
		public void TravelTo(AreaLevel level)
		{
		}

		// Token: 0x0600BED9 RID: 48857 RVA: 0x004925F8 File Offset: 0x004907F8
		private uint PatherGetPortal(AreaLevel targetArea = AreaLevel.None, string name = "")
		{
			PortalInfo portalInfo = this.GameInstance.PortalsInfo.Values.FirstOrDefault((PortalInfo i) => i.Destination == targetArea);
			bool flag = portalInfo != null;
			uint num;
			if (flag)
			{
				num = portalInfo.Id;
			}
			else
			{
				num = 0U;
			}
			return num;
		}

		// Token: 0x0600BEDA RID: 48858 RVA: 0x0049264C File Offset: 0x0049084C
		public bool PatherUsePortal(AreaLevel targetArea = AreaLevel.None, string name = "", uint obj = 0U)
		{
			bool flag = targetArea == base.GetCurrentLevel();
			bool flag2;
			if (flag)
			{
				flag2 = true;
			}
			else
			{
				bool flag3 = targetArea == AreaLevel.None;
				if (flag3)
				{
					targetArea = base.GetCurrentLevel();
				}
				uint num = this.PatherGetPortal(targetArea, "");
				AssignGameObject assignGameObject = this.GameInstance.GameObjects[num];
				float distance = Helpers.GetDistance(base.me.X, base.me.Y, assignGameObject.X, assignGameObject.Y);
				bool flag4 = distance > 4f;
				if (flag4)
				{
					bool flag5 = this.SkillLog[SkillType.Telekinesis] > 0;
					if (flag5)
					{
						bool flag6 = distance > 16f;
						if (flag6)
						{
							this.AttackGetIntoPosition(new AssignNPC
							{
								X = assignGameObject.X,
								Y = assignGameObject.Y
							}, 14.0, 4, false);
						}
						this.SkillCastSkill(SkillType.Telekinesis, assignGameObject);
					}
					else
					{
						this.PatherMoveTo((long)((ulong)assignGameObject.X), (long)((ulong)assignGameObject.Y), false, 2f);
						this.Interact(assignGameObject);
					}
				}
				flag2 = base.GetCurrentLevel() == targetArea;
			}
			return flag2;
		}

		// Token: 0x0600BEDB RID: 48859 RVA: 0x00492770 File Offset: 0x00490970
		public bool PatherUseTeleport()
		{
			return !base.InTown() && this.SkillLog[SkillType.Teleport] > 0;
		}

		// Token: 0x0600BEDC RID: 48860 RVA: 0x004927A0 File Offset: 0x004909A0
		public bool PatherTeleportTo(long x, long y, long maxRange = 5L)
		{
			bool flag = !this.PatherUseTeleport();
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				for (int i = 0; i < 3; i++)
				{
					this.SkillCastSkill(SkillType.Teleport, (ushort)x, (ushort)y);
					int tickCount = Environment.TickCount;
					while (Environment.TickCount - tickCount < 500)
					{
						bool flag3 = Helpers.GetDistance(base.me.X, base.me.Y, (ushort)x, (ushort)y) <= (float)maxRange;
						if (flag3)
						{
							bool flag4 = base.GetCurrentLevel() == AreaLevel.DenOfEvil || (base.GetCurrentLevel() == AreaLevel.ArcaneSanctuary && this.difficulty == GameDifficulty.Normal);
							if (flag4)
							{
							}
							return true;
						}
						Thread.Sleep(20);
					}
				}
				flag2 = false;
			}
			return flag2;
		}

		// Token: 0x0600BEDD RID: 48861 RVA: 0x00492870 File Offset: 0x00490A70
		public bool PatherWalkTo(ushort x, ushort y, long minDist = 2L)
		{
			int num = 0;
			int num2 = 0;
			bool flag = false;
			bool flag2 = base.InTown() || (base.GetCurrentLevel() != AreaLevel.SpiderCavern && base.me.Stamina >= 10);
			if (flag2)
			{
				flag = true;
			}
			while (Helpers.GetDistance(base.me.X, base.me.Y, x, y) > (float)minDist && !base.me.State.HasFlag(Player.Mode.Dead))
			{
				bool flag3 = this.SkillLog[SkillType.Vigor] > 0;
				if (flag3)
				{
					this.SkillSetSkill(SkillType.Vigor, SkillHand.Right);
				}
				num++;
				int tickCount = Environment.TickCount;
				while (base.me.State != Player.Mode.Walk && base.me.State != Player.Mode.Run && base.me.State != Player.Mode.TownWalk)
				{
					bool flag4 = base.me.State.HasFlag(Player.Mode.Dead);
					if (flag4)
					{
						return false;
					}
					bool flag5 = Environment.TickCount - tickCount > 70;
					if (flag5)
					{
						num2++;
						bool flag6 = (num2 == 1 || num2 == 2) && !base.InTown();
						if (flag6)
						{
							bool flag7 = base.GetCurrentLevel().ToString().Contains("Maggot");
							if (flag7)
							{
								num2 = 0;
							}
							else
							{
								this.SkillCastSkill(SkillType.FrostNova, base.me.X, base.me.Y);
								AreaLevel currentLevel = base.GetCurrentLevel();
							}
						}
						bool flag8 = num2 >= 5;
						if (flag8)
						{
							break;
						}
						bool flag9 = flag;
						if (flag9)
						{
							base.SendPacket(new RunToLocation
							{
								X = x,
								Y = y,
								CurrentX = base.me.X,
								CurrentY = base.me.Y
							});
						}
						else
						{
							base.SendPacket(new WalkToLocation
							{
								X = x,
								Y = y,
								CurrentX = base.me.X,
								CurrentY = base.me.Y
							});
						}
						while (Helpers.GetDistance(base.me.X, base.me.Y, x, y) > (float)minDist && base.me.State != Player.Mode.Neutral && base.me.State != Player.Mode.TownNeutral && base.me.State > Player.Mode.Death)
						{
							Thread.Sleep(10);
						}
						break;
					}
					else
					{
						Thread.Sleep(10);
					}
				}
				bool flag10 = num >= 8;
				if (!flag10)
				{
					continue;
				}
				return false;
			}
			return base.me.State != Player.Mode.Death && Helpers.GetDistance(base.me.X, base.me.Y, x, y) <= (float)minDist;
		}

		// Token: 0x0600BEDE RID: 48862 RVA: 0x00492B74 File Offset: 0x00490D74
		public bool PatherCheckSpot(long x, long y, ushort collFlag = 1, bool cacheOnly = false, int size = 1)
		{
			Level level = this.GameInstance.LevelData[base.GetCurrentLevel()];
			for (int i = -size; i <= size; i++)
			{
				for (int j = -size; j <= size; j++)
				{
					bool flag = Math.Abs(i) != Math.Abs(j);
					if (flag)
					{
						bool flag2 = (long)level.CollisionMap.GetLength(0) < x + (long)i - (long)((ulong)level.X) && (long)level.CollisionMap.GetLength(1) < y + (long)j - (long)((ulong)level.Y);
						if (flag2)
						{
							return false;
						}
						bool flag3 = level.IsWall((uint)((int)x + i), (uint)((int)y + j));
						bool flag4 = flag3;
						if (flag4)
						{
							return false;
						}
					}
				}
			}
			return true;
		}

		// Token: 0x0600BEDF RID: 48863 RVA: 0x00492C58 File Offset: 0x00490E58
		public bool PatherMoveTo(long x, long y, bool clearPath = false, float desiredDist = 2f)
		{
			bool flag = base.me.Life == 0;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				AreaLevel baseLevel = AreaLevelHelper.GetBaseLevel(base.GetCurrentLevel());
				Vector2 closestWalkablePos = this.GameInstance.LevelData[baseLevel].GetClosestWalkablePos((ushort)x, (ushort)y);
				x = (long)closestWalkablePos.X;
				y = (long)closestWalkablePos.Y;
				bool flag3 = Helpers.GetDistance(base.me.X, base.me.Y, (ushort)x, (ushort)y) < 2f;
				if (flag3)
				{
					flag2 = true;
				}
				else
				{
					bool flag4 = this.PatherUseTeleport();
					List<int> list;
					if (!flag4)
					{
						(list = new List<int>()).Add(1);
					}
					else
					{
						List<int> list2 = new List<int>();
						list2.Add(1);
						list2.Add(4);
						list2.Add(10);
						list2.Add(20);
						list = list2;
						list2.Add(35);
					}
					List<int> list3 = list;
					int num = (flag4 ? 25 : 10);
					List<Node> list4 = new List<Node>();
					float distance = Helpers.GetDistance(base.me.X, base.me.Y, (ushort)x, (ushort)y);
					bool flag5 = distance > (float)num;
					if (flag5)
					{
						list4 = this.GameInstance.LevelData[baseLevel].GetPath(new Vector2((float)base.me.X, (float)base.me.Y), new Vector2((float)((int)x), (float)((int)y)), list3).Skip(1).ToList<Node>();
					}
					else
					{
						list4.Add(new Node((int)x - (int)this.GameInstance.LevelData[baseLevel].X, (int)y - (int)this.GameInstance.LevelData[baseLevel].Y, false, false, null, true));
					}
					int num2 = 0;
					if (clearPath)
					{
						this.AttackClear(25, 0, 0, true);
					}
					for (int i = 0; i < list4.Count; i++)
					{
						bool flag6 = flag4;
						if (flag6)
						{
							for (int j = i; j < list4.Count; j++)
							{
								Node node = list4[j];
								bool flag7 = Vector2.Distance(new Vector2((float)base.me.X, (float)base.me.Y), new Vector2((float)((ushort)((ulong)this.GameInstance.LevelData[baseLevel].X + (ulong)((long)node.X))), (float)((ushort)((ulong)this.GameInstance.LevelData[baseLevel].Y + (ulong)((long)node.Y))))) < 30f;
								if (!flag7)
								{
									break;
								}
								i = j;
							}
							Node node2 = list4[i];
							ushort num3 = (ushort)((ulong)this.GameInstance.LevelData[baseLevel].X + (ulong)((long)list4[i].X));
							ushort num4 = (ushort)((ulong)this.GameInstance.LevelData[baseLevel].Y + (ulong)((long)list4[i].Y));
							this.teleportReturned = false;
							this.PatherTeleportTo((long)((ulong)num3), (long)((ulong)num4), 5L);
							int num5 = 0;
							while (!this.teleportReturned)
							{
								Console.Write("-");
								Thread.Sleep(50);
								bool flag8 = num5++ > 5;
								if (flag8)
								{
									this.PatherMoveTo(x, y, false, 2f);
									num5 = 0;
								}
							}
						}
						else
						{
							int num6 = this.Random.Next(5, 15);
							bool flag9 = list4[i].IsCritical || num2++ > num6;
							if (flag9)
							{
								ushort num7 = (ushort)((ulong)this.GameInstance.LevelData[baseLevel].X + (ulong)((long)list4[i].X));
								ushort num8 = (ushort)((ulong)this.GameInstance.LevelData[baseLevel].Y + (ulong)((long)list4[i].Y));
								float distance2 = Helpers.GetDistance(base.me.X, base.me.Y, num7, num8);
								bool flag10 = distance2 > 30f;
								if (flag10)
								{
									Console.WriteLine("stuck");
									Vector2 randomNearbyPos = this.GetRandomNearbyPos();
									this.PatherMoveTo((long)((ulong)((uint)randomNearbyPos.X)), (long)((ulong)((uint)randomNearbyPos.Y)), clearPath, 2f);
									bool flag11 = this.PatherMoveTo(x, y, clearPath, 2f);
									if (flag11)
									{
										return true;
									}
								}
								this.walkVerified = false;
								float num9 = distance2 * 1000f / 14f;
								int tickCount = Environment.TickCount;
								while ((float)(Environment.TickCount - tickCount) < num9 - 150f)
								{
									float distance3 = Helpers.GetDistance(base.me.X, base.me.Y, (ushort)x, (ushort)y);
									bool flag12 = distance3 < desiredDist;
									if (flag12)
									{
										return true;
									}
									this.MoveToPoint((int)num7, (int)num8);
									Thread.Sleep(this.Random.Next(100, 300));
								}
								float distance4 = Helpers.GetDistance(base.me.X, base.me.Y, num7, num8);
								if (clearPath)
								{
									this.AttackClear(25, 0, 0, true);
								}
								bool flag13 = distance4 > 15f;
								if (flag13)
								{
									Console.WriteLine("resync loc");
									base.SendPacket(new RequestReassign
									{
										Type = UnitType.Player,
										Id = base.me.Id
									});
								}
								num2 = 0;
							}
						}
					}
					flag2 = true;
				}
			}
			return flag2;
		}

		// Token: 0x0600BEE0 RID: 48864 RVA: 0x004931E8 File Offset: 0x004913E8
		public Vector2 GetRandomNearbyPos()
		{
			AreaLevel baseLevel = AreaLevelHelper.GetBaseLevel(base.GetCurrentLevel());
			Level level = this.GameInstance.LevelData[baseLevel];
			int num = (int)base.me.X + this.Random.Next(-5, 5);
			int num2 = (int)base.me.Y + this.Random.Next(-5, 5);
			bool flag = Helpers.GetDistance(base.me.X, base.me.Y, (ushort)num, (ushort)num2) < 2f;
			Vector2 vector;
			if (flag)
			{
				vector = this.GetRandomNearbyPos();
			}
			else
			{
				bool flag2 = !level.IsWall((uint)((ushort)num), (uint)((ushort)num2));
				if (flag2)
				{
					vector = new Vector2((float)num, (float)num2);
				}
				else
				{
					vector = this.GetRandomNearbyPos();
				}
			}
			return vector;
		}

		// Token: 0x0600BEE1 RID: 48865 RVA: 0x004932AC File Offset: 0x004914AC
		public void GrabWaypoint(WaypointsAvailable wpTarget)
		{
			bool flag = base.me.WaypointsUnlocked.HasFlag(wpTarget);
			if (!flag)
			{
				Console.WriteLine("Grabbing WP : " + wpTarget.ToString());
				bool flag2 = wpTarget == WaypointsAvailable.ColdPlains;
				if (flag2)
				{
					PresetUnit presetUnit = this.GameInstance.LevelData[AreaLevel.RogueEncampment].Units.FindAll((PresetUnit p) => p.CastedGameObject == GameObjectID.WaypointPortal)[1];
					this.PatherMoveTo((long)((ulong)presetUnit.X), (long)((ulong)presetUnit.Y), false, 2f);
					AssignGameObject value = this.GameInstance.GameObjects.First((KeyValuePair<uint, AssignGameObject> g) => g.Value.ObjectId == GameObjectID.WaypointPortal).Value;
					this.Interact(value);
					base.SendPacket(new WaypointInteract
					{
						Destination = AreaLevel.RogueEncampment
					});
				}
				else
				{
					bool flag3 = wpTarget == WaypointsAvailable.StonyField;
					if (flag3)
					{
						this.TakeWaypoint(WaypointsAvailable.ColdPlains, true, true);
						PresetUnit presetUnit2 = this.GameInstance.LevelData[AreaLevel.RogueEncampment].Units.FindAll((PresetUnit p) => p.CastedGameObject == GameObjectID.WaypointPortal)[2];
						this.PatherMoveTo((long)((ulong)presetUnit2.X), (long)((ulong)presetUnit2.Y), false, 2f);
						AssignGameObject value2 = this.GameInstance.GameObjects.First((KeyValuePair<uint, AssignGameObject> g) => g.Value.ObjectId == GameObjectID.WaypointPortal).Value;
						this.Interact(value2);
						base.SendPacket(new WaypointInteract
						{
							Destination = AreaLevel.RogueEncampment
						});
					}
					else
					{
						bool flag4 = wpTarget == WaypointsAvailable.DarkWood;
						if (flag4)
						{
							this.TakeWaypoint(WaypointsAvailable.StonyField, true, true);
							PresetUnit presetUnit3 = this.GameInstance.LevelData[AreaLevel.StonyField].Units.Last((PresetUnit w) => w.CastedWarpType.ToString().Contains(WarpType.Act1WildernessToCaveFloorL.ToString().Replace("FloorL", "")));
							this.PatherMoveTo((long)((ulong)presetUnit3.X), (long)((ulong)presetUnit3.Y), this.difficulty == GameDifficulty.Normal, 2f);
							this.Interact(presetUnit3);
							List<PresetUnit> list = this.GameInstance.LevelData[AreaLevel.UndergroundPassageLevel1].Units.FindAll((PresetUnit w) => w.CastedWarpType == WarpType.Act1CaveUp);
							PresetUnit presetUnit4 = list.MinBy((PresetUnit w) => Vector2.DistanceSquared(new Vector2((float)base.me.X, (float)base.me.Y), new Vector2(w.X, w.Y)));
							this.PatherMoveTo((long)((ulong)presetUnit4.X), (long)((ulong)presetUnit4.Y), this.difficulty == GameDifficulty.Normal, 2f);
							this.Interact(presetUnit4);
							PresetUnit presetUnit5 = this.GameInstance.LevelData[AreaLevel.DarkWood].Units.FindAll((PresetUnit p) => p.CastedGameObject == GameObjectID.WaypointPortal)[0];
							this.PatherMoveTo((long)((ulong)presetUnit5.X), (long)((ulong)presetUnit5.Y), false, 2f);
							AssignGameObject value3 = this.GameInstance.GameObjects.First((KeyValuePair<uint, AssignGameObject> g) => g.Value.ObjectId == GameObjectID.WaypointPortal).Value;
							this.Interact(value3);
							base.SendPacket(new WaypointInteract
							{
								Destination = AreaLevel.RogueEncampment
							});
						}
						else
						{
							bool flag5 = wpTarget == WaypointsAvailable.BlackMarsh;
							if (flag5)
							{
								this.TakeWaypoint(WaypointsAvailable.DarkWood, true, true);
								PresetUnit presetUnit6 = this.GameInstance.LevelData[AreaLevel.DarkWood].Units.FindAll((PresetUnit p) => p.CastedGameObject == GameObjectID.WaypointPortal)[1];
								this.PatherMoveTo((long)((ulong)presetUnit6.X), (long)((ulong)presetUnit6.Y), false, 2f);
								AssignGameObject value4 = this.GameInstance.GameObjects.First((KeyValuePair<uint, AssignGameObject> g) => g.Value.ObjectId == GameObjectID.WaypointPortal).Value;
								this.Interact(value4);
								base.SendPacket(new WaypointInteract
								{
									Destination = AreaLevel.RogueEncampment
								});
							}
							else
							{
								bool flag6 = wpTarget == WaypointsAvailable.OuterCloister;
								if (flag6)
								{
									this.TakeWaypoint(WaypointsAvailable.BlackMarsh, true, true);
									PresetUnit presetUnit7 = this.GameInstance.LevelData[AreaLevel.DarkWood].Units.FindAll((PresetUnit p) => p.CastedGameObject == GameObjectID.WaypointPortal)[1];
									this.PatherMoveTo((long)((ulong)presetUnit7.X), (long)((ulong)presetUnit7.Y), false, 2f);
									AssignGameObject value5 = this.GameInstance.GameObjects.First((KeyValuePair<uint, AssignGameObject> g) => g.Value.ObjectId == GameObjectID.WaypointPortal).Value;
									this.Interact(value5);
									base.SendPacket(new WaypointInteract
									{
										Destination = AreaLevel.RogueEncampment
									});
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BEE2 RID: 48866 RVA: 0x004937FC File Offset: 0x004919FC
		public void TakeWaypoint(WaypointsAvailable wp, bool townRoutine = true, bool exploit = true)
		{
			AreaLevel areaLevel = base.GetCurrentLevel();
			bool flag = areaLevel.ToString() == wp.ToString();
			if (!flag)
			{
				bool flag2 = areaLevel == AreaLevel.LutGholein;
				if (flag2)
				{
					AssignNPC value = this.GameInstance.NPCs.FirstOrDefault((KeyValuePair<uint, AssignNPC> g) => g.Value.NpcType == NPCCode.Warriv2).Value;
					bool flag3 = value != null && Helpers.GetDistance(base.me.X, base.me.Y, value.X, value.Y) < 20f;
					if (flag3)
					{
						this.PatherMoveTo((long)((ulong)value.X), (long)((ulong)value.Y), false, 2f);
						this.TownFolkTravel(NPCCode.Warriv2, AreaLevel.RogueEncampment);
						areaLevel = base.GetCurrentLevel();
					}
				}
				PresetUnit presetUnit = this.GameInstance.LevelData[areaLevel].Units.First((PresetUnit u) => u.CastedGameObject.ToString().Contains("Waypoint"));
				this.PatherMoveTo((long)((ulong)presetUnit.X), (long)((ulong)presetUnit.Y), false, 6f);
				AssignGameObject value2 = this.GameInstance.GameObjects.First((KeyValuePair<uint, AssignGameObject> g) => g.Value.ObjectId.ToString().Contains("Waypoint")).Value;
				bool flag4 = !exploit;
				if (flag4)
				{
					Thread.Sleep(this.Random.Next(500, 1000));
					base.SendPacket(new WaypointOpen(), (Packet p) => p is WaypointOpen);
				}
				bool flag5 = base.me.WaypointsUnlocked != WaypointsAvailable.None && !base.me.WaypointsUnlocked.HasFlag(wp);
				if (flag5)
				{
					this.GrabWaypoint(wp);
				}
				else
				{
					WaypointInteract waypointInteract = new WaypointInteract();
					waypointInteract.Destination = AreaLevelHelper.GetAreaFromWp(wp);
					base.SendPacket(waypointInteract, (Packet p) => p is PlayerReassign);
					string text = base.GetCurrentLevel().ToString();
					bool flag6 = wp.ToString() != base.GetCurrentLevel().ToString();
					if (flag6)
					{
						this.PatherMoveTo((long)(value2.X - 10), (long)(value2.Y - 10), false, 2f);
						this.TakeWaypoint(wp, townRoutine, true);
					}
				}
			}
		}

		// Token: 0x0600BEE3 RID: 48867 RVA: 0x00493ACC File Offset: 0x00491CCC
		public void TakeTpTo(AreaLevel target, string owner = "any_available_portal")
		{
			AreaLevel tempTarget = target;
			bool flag = target == AreaLevel.None;
			if (flag)
			{
				Player value = this.GameInstance.Players.First((KeyValuePair<uint, Player> p) => p.Value.Name == owner).Value;
				tempTarget = value.Area;
			}
			List<PortalInfo> list = this.GameInstance.PortalsInfo.Values.ToList<PortalInfo>().FindAll((PortalInfo p) => p.Destination == tempTarget);
			PortalInfo tp = list.LastOrDefault<PortalInfo>();
			bool flag2 = owner == null;
			if (flag2)
			{
				tp = list.FirstOrDefault((PortalInfo p) => this.GameInstance.PortalsOwnership.Values.Count((PortalOwnership po) => p.Id == po.LocalId || p.Id == po.RemoteId) == 0);
			}
			else
			{
				bool flag3 = owner != "any_available_portal";
				if (flag3)
				{
					List<PortalOwnership> list2 = this.GameInstance.PortalsOwnership.Values.ToList<PortalOwnership>().FindAll((PortalOwnership p) => p.Name == owner);
					tp = list.FirstOrDefault((PortalInfo p) => this.GameInstance.PortalsOwnership.Values.Count((PortalOwnership p2) => p.Id == p2.LocalId || p.Id == p2.RemoteId) > 0);
				}
			}
			AssignGameObject value2 = this.GameInstance.GameObjects.LastOrDefault(delegate(KeyValuePair<uint, AssignGameObject> o)
			{
				uint key = o.Key;
				PortalInfo tp2 = tp;
				uint? num = ((tp2 != null) ? new uint?(tp2.Id) : null);
				return (key == num.GetValueOrDefault()) & (num != null);
			}).Value;
			bool flag4 = value2 == null;
			if (flag4)
			{
				Thread.Sleep(200);
				this.TakeTpTo(target, owner);
			}
			else
			{
				this.PatherMoveTo((long)((ulong)value2.X), (long)((ulong)value2.Y), false, 2f);
				this.Interact(value2);
				while (base.GetCurrentLevel() != tempTarget)
				{
					Thread.Sleep(100);
				}
			}
		}

        // Token: 0x0600BEE4 RID: 48868 RVA: 0x00493C7C File Offset: 0x00491E7C
        // [Ares] from GPT
        public void GoToNextLevel(WarpType warp = WarpType.NotApplicable)
        {
            // Get the current level
            AreaLevel currentLevel = base.GetCurrentLevel();

            // Determine the target warp
            PresetUnit targetWarp = warp == WarpType.NotApplicable
                ? this.GameInstance.LevelData[currentLevel].Units
                    .Where(u => (byte)u.Type == 5)
                    .OrderByDescending(u => u.TxtFileNo)
                    .FirstOrDefault()
                : this.GameInstance.LevelData[currentLevel].Units
                    .FirstOrDefault(u => u.CastedWarpType == warp);

            // Exit if no valid warp is found
            if (targetWarp == null) return;

            // Move to the warp location
            this.PatherMoveTo((long)targetWarp.X, (long)targetWarp.Y, true, 2f);
            Thread.Sleep(this.Random.Next(300, 700));

            // Find the nearest warp that matches the target warp type
            var nearestWarp = this.GameInstance.Warps
                .Where(w => w.Value.Warp == targetWarp.CastedWarpType)
                .OrderBy(w => Vector2.DistanceSquared(
                    new Vector2(this.me.X, this.me.Y),
                    new Vector2(w.Value.X, w.Value.Y)))
                .FirstOrDefault();

            // Interact with the warp if found
            if (nearestWarp.Value != null)
            {
                this.WarpInteract(nearestWarp.Value);
            }
        }

        // Token: 0x0600BEE5 RID: 48869 RVA: 0x00493DCC File Offset: 0x00491FCC
        public bool PatherAccesToAct(ActLocation act)
		{
			bool flag = act == ActLocation.Act1;
			bool flag2;
			if (flag)
			{
				flag2 = true;
			}
			else
			{
				bool flag3 = act == ActLocation.Act2 && base.me.WaypointsUnlocked.HasFlag(WaypointsAvailable.LutGholein);
				if (flag3)
				{
					flag2 = true;
				}
				else
				{
					bool flag4 = act == ActLocation.Act3 && base.me.WaypointsUnlocked.HasFlag(WaypointsAvailable.KurastDocks);
					if (flag4)
					{
						flag2 = true;
					}
					else
					{
						bool flag5 = act == ActLocation.Act4 && this.updateQuestInfo.Quests_42[23].Standing == QuestStanding.Complete;
						if (flag5)
						{
							flag2 = true;
						}
						else
						{
							bool flag6 = act == ActLocation.Act5 && base.me.WaypointsUnlocked.HasFlag(WaypointsAvailable.Harrogath);
							flag2 = flag6;
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600BEE6 RID: 48870 RVA: 0x00493EAC File Offset: 0x004920AC
		public void GoToTown(ActLocation act = ActLocation.None)
		{
			bool flag = !base.InTown();
			if (flag)
			{
				UseInventoryItem useInventoryItem = new UseInventoryItem();
				useInventoryItem.Id = this.inventoryTome.Id;
				useInventoryItem.X = (uint)base.me.X;
				useInventoryItem.Y = (uint)base.me.Y;
				base.SendPacket(useInventoryItem, (Packet p) => p is PortalOwnership);
				this.UseMyTp();
			}
			bool flag2 = act == ActLocation.None;
			if (!flag2)
			{
				bool flag3 = this.currentAct != act;
				if (flag3)
				{
					this.TakeWaypoint((WaypointsAvailable)Enum.Parse(typeof(WaypointsAvailable), AreaLevelHelper.GetTownLevel(act).ToString()), true, true);
				}
			}
		}

		// Token: 0x0600BEE7 RID: 48871 RVA: 0x00493F7C File Offset: 0x0049217C
		public void UseMyTp()
		{
			uint myTpId = base.GetMyTpId();
			AssignGameObject value = this.GameInstance.GameObjects.First((KeyValuePair<uint, AssignGameObject> g) => g.Value.Id == myTpId).Value;
			bool flag = Vector2.Distance(new Vector2((float)base.me.X, (float)base.me.Y), new Vector2((float)value.X, (float)value.Y)) > 5f;
			if (flag)
			{
				this.PatherMoveTo((long)((ulong)value.X), (long)((ulong)value.Y), false, 2f);
			}
			this.Interact(value);
		}

		// Token: 0x0600BEE8 RID: 48872 RVA: 0x00494024 File Offset: 0x00492224
		public void TravelTo(NPCCode npcCode, bool clearPath = false)
		{
			this.TravelTo((int)npcCode, UnitType.NPC, clearPath);
		}

		// Token: 0x0600BEE9 RID: 48873 RVA: 0x00494034 File Offset: 0x00492234
		public void TravelTo(GameObjectID gameObjectID, bool clearPath = false)
		{
			AssignGameObject value = this.GameInstance.GameObjects.FirstOrDefault((KeyValuePair<uint, AssignGameObject> u) => u.Value.ObjectId == gameObjectID).Value;
			bool flag = value != null;
			if (flag)
			{
				this.PatherMoveTo((long)((ulong)value.X), (long)((ulong)value.Y), clearPath, 2f);
			}
			else
			{
				this.TravelTo((int)gameObjectID, UnitType.GameObject, clearPath);
			}
		}

		// Token: 0x0600BEEA RID: 48874 RVA: 0x004940A8 File Offset: 0x004922A8
		public void TravelTo(int unitId, UnitType unitType, bool clearPath = false)
		{
			AreaLevel baseLevel = AreaLevelHelper.GetBaseLevel(base.GetCurrentLevel());
			PresetUnit presetUnit = this.GameInstance.LevelData[baseLevel].Units.FirstOrDefault((PresetUnit u) => (ulong)u.Type == (ulong)((long)unitType) && (ulong)u.TxtFileNo == (ulong)((long)unitId));
			bool flag = presetUnit == null;
			if (flag)
			{
				bool flag2 = unitType == UnitType.GameObject;
				if (flag2)
				{
					AssignGameObject value = this.GameInstance.GameObjects.First((KeyValuePair<uint, AssignGameObject> u) => u.Value.ObjectId == (GameObjectID)unitId).Value;
					presetUnit = new PresetUnit
					{
						X = (uint)value.X,
						Y = (uint)value.Y
					};
				}
				bool flag3 = unitType == UnitType.NPC;
				if (flag3)
				{
					AssignNPC value2 = this.GameInstance.NPCs.First((KeyValuePair<uint, AssignNPC> u) => u.Value.NpcType == (NPCCode)unitId).Value;
					presetUnit = new PresetUnit
					{
						X = (uint)value2.X,
						Y = (uint)value2.Y
					};
				}
			}
			this.PatherMoveTo((long)((ulong)presetUnit.X), (long)((ulong)presetUnit.Y), clearPath, 2f);
		}

		// Token: 0x0600BEEB RID: 48875 RVA: 0x004941DC File Offset: 0x004923DC
		private void MoveToUnit(uint id)
		{
			bool flag = base.me.Stamina > 30;
			if (flag)
			{
				base.SendPacket(new RunToTarget
				{
					Type = UnitType.NPC,
					Id = id
				});
			}
			else
			{
				base.SendPacket(new WalkToTarget
				{
					Type = UnitType.NPC,
					Id = id
				});
			}
		}

		// Token: 0x0600BEEC RID: 48876 RVA: 0x00494234 File Offset: 0x00492434
		public void MoveToPoint(int X, int Y)
		{
			this.TargetX = X;
			this.TargetY = Y;
			bool flag = base.me.Stamina > 30;
			if (flag)
			{
				base.SendPacket(new RunToLocation
				{
					X = (ushort)X,
					Y = (ushort)Y,
					CurrentX = base.me.X,
					CurrentY = base.me.Y
				});
			}
			else
			{
				base.SendPacket(new WalkToLocation
				{
					X = (ushort)X,
					Y = (ushort)Y,
					CurrentX = base.me.X,
					CurrentY = base.me.Y
				});
			}
		}

		// Token: 0x0600BEED RID: 48877 RVA: 0x004942E4 File Offset: 0x004924E4
		public void LocationEstimater()
		{
			Console.WriteLine("location esimtator!");
			Vector2 vector = new Vector2((float)this.TargetX, (float)this.TargetY);
			Vector2 vector2 = new Vector2((float)base.me.X, (float)base.me.Y);
			Vector2 vector3 = Vector2.Normalize(vector - vector2);
			float num = Vector2.Distance(new Vector2((float)base.me.X, (float)base.me.Y), new Vector2((float)this.TargetX, (float)this.TargetY));
			float num2 = num / this.Velocity();
			int tickCount = Environment.TickCount;
			float num3 = (float)tickCount + num2;
			int num4 = 1;
			do
			{
				Console.WriteLine("location esimtator : " + num4.ToString());
				Vector2 vector4 = vector3 * this.Velocity() * 0.05f * (float)num4++;
				Thread.Sleep(50);
				bool flag = !this.cts.IsCancellationRequested;
				if (flag)
				{
					break;
				}
				base.me.X = (ushort)vector4.X;
				base.me.Y = (ushort)vector4.Y;
			}
			while ((float)Environment.TickCount < num3 && !this.cts.IsCancellationRequested);
		}

		// Token: 0x0600BEEE RID: 48878 RVA: 0x00494436 File Offset: 0x00492636
		public void EnableFastPickIt()
		{
			this.OnItemAction = (Action<ItemAction>)Delegate.Combine(this.OnItemAction, new Action<ItemAction>(this.ManageItems));
		}

		// Token: 0x0600BEEF RID: 48879 RVA: 0x0049445C File Offset: 0x0049265C
		private void ManageItems(ItemAction item)
		{
			float num;
			bool flag = !this.PickItCheckItem(item, out num);
			if (flag)
			{
				Console.WriteLine(string.Concat(new string[]
				{
					"Ignoring ",
					item.baseItem.Type.ToString(),
					"(",
					item.baseItem.BaseType.Type.ToString(),
					"), ",
					item.x.ToString(),
					" : ",
					item.y.ToString()
				}));
			}
			else
			{
				Console.WriteLine(string.Concat(new string[]
				{
					"Queieng ",
					item.baseItem.Type.ToString(),
					"(",
					item.baseItem.BaseType.Type.ToString(),
					"), ",
					item.x.ToString(),
					" : ",
					item.y.ToString()
				}));
			}
			bool chickening = this.Chickening;
			if (!chickening)
			{
				bool flag2 = !base.InTown();
				if (flag2)
				{
					ushort num2;
					ushort num3;
					bool flag3 = !this.FitBottomRightToTopLeft(item, this.GameInstance.Items.Values.Where((ItemAction item) => item.OwnerId == base.me.Id && item.container == ItemContainer.Inventory), 10, 4, false, out num2, out num3);
					if (flag3)
					{
						this.TownChicken();
					}
				}
				else
				{
					bool fastPick = this.Config.FastPick;
					if (fastPick)
					{
						this.PickItems();
					}
				}
			}
		}

		// Token: 0x0600BEF0 RID: 48880 RVA: 0x00494614 File Offset: 0x00492814
		private bool PickItCheckProperties(ItemAction item, string properties)
		{
			properties = properties.Replace("[\"type\"]", ((int)item.baseItem.BaseType.Type).ToString());
			bool flag = properties.Contains("[\"class\"]");
			int num;
			if (flag)
			{
				ItemClass itemClass = ItemClass.NotApplicable;
				bool flag2 = item.baseItem is BaseArmor || item.baseItem is BaseWeapon;
				if (flag2)
				{
					bool flag3 = item.baseItem.ID == ((item.baseItem is BaseArmor) ? ((BaseArmor)item.baseItem).NormalID : ((BaseWeapon)item.baseItem).NormalID);
					if (flag3)
					{
						itemClass = ItemClass.Normal;
					}
					bool flag4 = item.baseItem.ID == ((item.baseItem is BaseArmor) ? ((BaseArmor)item.baseItem).ExceptionalID : ((BaseWeapon)item.baseItem).ExceptionalID);
					if (flag4)
					{
						itemClass = ItemClass.Exceptional;
					}
					bool flag5 = item.baseItem.ID == ((item.baseItem is BaseArmor) ? ((BaseArmor)item.baseItem).EliteID : ((BaseWeapon)item.baseItem).EliteID);
					if (flag5)
					{
						itemClass = ItemClass.Elite;
					}
				}
				string text = properties;
				string text2 = "[\"class\"]";
				num = (int)itemClass;
				properties = text.Replace(text2, num.ToString());
			}
			string text3 = properties;
			string text4 = "[\"quality\"]";
			num = (int)item.quality;
			properties = text3.Replace(text4, num.ToString());
			properties = properties.Replace("[\"flag\"]", (item.flags.HasFlag(ItemFlags.Ethereal) ? 5 : 0).ToString());
			properties = properties.Replace("[\"name\"]", ((int)item.baseItem.Type).ToString());
			bool flag6 = item.baseItem.BaseType.Type == ItemKind.Gold;
			if (flag6)
			{
				properties = properties.Replace("[\"gold\"]", ((SignedStat)item.stats.FirstOrDefault((StatBase s) => ((SignedStat)s).BaseStat.Type == StatType.Quantity)).Value.ToString());
			}
			properties = properties.Replace("&&", " and ");
			properties = properties.Replace("||", " or ");
			properties = properties.Replace("==", " = ");
			properties = properties.Replace("!=", " <> ");
			properties = properties.Replace("\"me\".\"level\"", " " + base.me.Attributes[StatType.Level].ToString() + " ");
			string text5 = properties;
			string text6 = "\"me\".\"diff\"";
			string text7 = " ";
			num = (int)this.difficulty;
			properties = text5.Replace(text6, text7 + num.ToString() + " ");
			properties = properties.Replace("\"me\".\"gold\"", " " + this.GetGold().ToString() + " ");
			properties = properties.Replace("\"me\".\"act\"", " " + ((int)ActLocationHelper.GetAct(base.GetCurrentLevel())).ToString() + " ");
			properties = properties.ToLower();
			return (bool)this.dt.Compute(properties, "");
		}

		// Token: 0x0600BEF1 RID: 48881 RVA: 0x0049495C File Offset: 0x00492B5C
		private bool PickItCheckQuantity(ItemAction item, Game.PickIt pickit)
		{
			bool flag = !pickit.MaxQuantity.ToLower().Contains("maxquantity");
			bool flag2;
			if (flag)
			{
				flag2 = true;
			}
			else
			{
				int num = this.GameInstance.Items.Values.Where((ItemAction i) => i.OwnerId == this.me.Id).Count((ItemAction i) => this.PickItCheckProperties(i, pickit.Properties) && this.PickItCheckStats(i, pickit.Stats));
				bool flag3 = item.OwnerId == base.me.Id;
				if (flag3)
				{
					num--;
				}
				flag2 = int.Parse(pickit.MaxQuantity.Substring(pickit.MaxQuantity.IndexOf("=") + 2).Trim()) > num;
			}
			return flag2;
		}

        // Token: 0x0600BEF2 RID: 48882 RVA: 0x00494A30 File Offset: 0x00492C30
        // [Ares] from GPT
        private bool PickItCheckStats(ItemAction item, string stats)
        {
            if (string.IsNullOrWhiteSpace(stats))
                return true;

            // Replace NTIPAliasStat values in stats
            foreach (var kvp in KolbotTranslator.NTIPAliasStat)
            {
                StatBase statBase = item.mods?.FirstOrDefault(s => (int)s.BaseStat.Type == kvp.Value)
                                 ?? item.stats?.FirstOrDefault(s => (int)s.BaseStat.Type == kvp.Value);

                string value = statBase != null
                    ? (statBase is SignedStat signed ? signed.Value.ToString()
                                                     : ((UnsignedStat)statBase).Value.ToString())
                    : "0";

                stats = stats.Replace($"[\"{kvp.Key}\"]", value);
            }

            // Replace class skill bonuses in stats
            while (stats.Contains("skills\"]"))
            {
                int startIndex = stats.LastIndexOf("[\"", stats.IndexOf("skills\"]")) + 2;
                int endIndex = stats.IndexOf("skills\"]");
                string skillKey = stats.Substring(startIndex, endIndex - startIndex).Replace("itemadd", "");

                string classSkillValue = item.stats
                    .FirstOrDefault(s => s is ClassSkillsBonusStat bonus && bonus.Class.ToString().Contains(skillKey)) is StatBase skillStat
                    ? (skillStat is SignedStat signed ? signed.Value.ToString()
                                                      : ((UnsignedStat)skillStat).Value.ToString())
                    : "0";

                stats = stats.Replace($"[\"{skillKey}skills\"]", classSkillValue);
            }

            // Replace skill tab bonuses in stats
            while (stats.Contains("tab\"]"))
            {
                int startIndex = stats.LastIndexOf("[\"", stats.IndexOf("tab\"]")) + 2;
                int endIndex = stats.IndexOf("tab\"]");
                string tabKey = stats.Substring(startIndex, endIndex - startIndex).Replace("itemadd", "");

                string tabSkillValue = item.stats
                    .FirstOrDefault(s => s is SkillTabBonusStat tab && tab.Tab.ToString().ToLower().Contains(tabKey)) is StatBase tabStat
                    ? (tabStat is SignedStat signed ? signed.Value.ToString()
                                                      : ((UnsignedStat)tabStat).Value.ToString())
                    : "0";

                stats = stats.Replace($"[\"{tabKey}tab\"]", tabSkillValue);
            }

            // Replace specific skill bonuses in stats
            while (stats.Contains("[\"skill"))
            {
                int startIndex = stats.IndexOf("[\"skill") + 7;
                int endIndex = stats.IndexOf("\"]", startIndex);
                string skillName = stats.Substring(startIndex, endIndex - startIndex);

                string skillValue = item.stats
                    .FirstOrDefault(s => s is SkillBonusStat bonus && bonus.Skill.ToString().ToLower() == skillName) is StatBase skillStat
                    ? (skillStat is SignedStat signed ? signed.Value.ToString()
                                                      : ((UnsignedStat)skillStat).Value.ToString())
                    : "0";

                stats = stats.Replace($"[\"skill{skillName}\"]", skillValue);
            }

            // Replace logical and variable placeholders
            stats = stats.Replace("&&", "and")
                         .Replace("||", " or ")
                         .Replace("==", " = ")
                         .Replace("!=", " <> ")
                         .Replace("\"me\".\"level\"", $" {base.me.Attributes[StatType.Level]} ")
                         .Replace("\"me\".\"diff\"", $" {((int)this.difficulty)} ")
                         .Replace("\"me\".\"gold\"", $" {this.GetGold()} ")
                         .Replace("\"me\".\"act\"", $" {(int)ActLocationHelper.GetAct(base.GetCurrentLevel())} ");

            // Evaluate the stats expression
            return (bool)this.dt.Compute(stats, "");
        }

        // Token: 0x0600BEF3 RID: 48883 RVA: 0x0049519C File Offset: 0x0049339C
        // [Ares] from GPT
        private float PickItCheckTier(ItemAction item, string tier)
        {
            string text = tier.Substring(tier.IndexOf("=") + 2);
            if (string.IsNullOrEmpty(text))
                return 0f;

            foreach (var kvp in KolbotTranslator.NTIPAliasStat)
            {
                StatBase statBase = item.mods?.FirstOrDefault(s => (int)s.BaseStat.Type == kvp.Value)
                                 ?? item.stats?.FirstOrDefault(s => (int)s.BaseStat.Type == kvp.Value);

                string value = statBase != null
                    ? (statBase is SignedStat signed ? signed.Value.ToString() : ((UnsignedStat)statBase).Value.ToString())
                    : "0";

                text = text.Replace($"[\"{kvp.Key}\"]", value);
            }

            while (text.Contains("getstatex"))
            {
                string stateText = text.Substring(text.IndexOf("statex") + 8);
                stateText = stateText.Substring(0, stateText.IndexOf(")"));

                if (stateText.Contains("83,"))
                {
                    int classId = int.Parse(stateText.Split(',').Last());
                    StatBase statBase = item.mods?.FirstOrDefault(s => s.BaseStat.Type == StatType.ClassSkillsBonus)
                                     ?? item.stats?.FirstOrDefault(s => s.BaseStat.Type == StatType.ClassSkillsBonus);

                    string value = statBase != null && classId == (int)((ClassSkillsBonusStat)statBase).Class
                        ? ((ClassSkillsBonusStat)statBase).Value.ToString()
                        : "0";

                    text = text.Replace($"\"item\".\"getstatex\"({stateText})", value);
                }
                else if (stateText.Contains("188,"))
                {
                    int tabNumber = int.Parse(stateText.Split(',').Last());
                    StatBase statBase = item.mods?.FirstOrDefault(s => s.BaseStat.Type == StatType.ClassSkillsBonus)
                                     ?? item.stats?.FirstOrDefault(s => s.BaseStat.Type == StatType.ClassSkillsBonus);

                    string value = statBase != null && tabNumber == ((SkillTabBonusStat)statBase).TabNumber
                        ? ((SkillTabBonusStat)statBase).Value.ToString()
                        : "0";

                    text = text.Replace($"\"item\".\"getstatex\"({stateText})", value);
                }
                else if (stateText.Contains("107,"))
                {
                    int skillId = int.Parse(stateText.Split(',').Last());
                    StatBase statBase = item.mods?.FirstOrDefault(s => s.BaseStat.Type == StatType.ClassSkillsBonus)
                                     ?? item.stats?.FirstOrDefault(s => s.BaseStat.Type == StatType.ClassSkillsBonus);

                    string value = statBase != null && skillId == (int)((SkillStat)statBase).Skill
                        ? ((SkillStat)statBase).Value.ToString()
                        : "0";

                    text = text.Replace($"\"item\".\"getstatex\"({stateText})", value);
                }
                else
                {
                    int statId = int.Parse(stateText);
                    StatBase statBase = item.mods?.FirstOrDefault(s => (int)s.BaseStat.Type == statId)
                                     ?? item.stats?.FirstOrDefault(s => (int)s.BaseStat.Type == statId);

                    string value = statBase != null
                        ? (statBase is SignedStat signed ? signed.Value.ToString() : ((UnsignedStat)statBase).Value.ToString())
                        : "0";

                    text = text.Replace($"\"item\".\"getstatex\"({statId})", value);
                }
            }

            text = text.Replace("&&", "and")
                       .Replace("||", " or ")
                       .Replace("==", " = ")
                       .Replace("!=", " <> ")
                       .Replace("\"me\".\"level\"", $" {base.me.Attributes[StatType.Level]} ")
                       .Replace("\"me\".\"diff\"", $" {((int)this.difficulty)} ")
                       .Replace("\"me\".\"gold\"", $" {this.GetGold()} ")
                       .Replace("\"me\".\"act\"", $" {(int)ActLocationHelper.GetAct(base.GetCurrentLevel())} ");

            return float.Parse(this.dt.Compute(text, "").ToString());
        }

        // Token: 0x0600BEF4 RID: 48884 RVA: 0x004959CC File Offset: 0x00493BCC
        public bool PickItCheckItem(ItemAction item, out float newTier)
		{
			newTier = 0f;
			foreach (Game.PickIt pickIt in this.pickItFilter)
			{
				bool flag = this.PickItCheckProperties(item, pickIt.Properties);
				bool flag2 = flag;
				if (flag2)
				{
					bool flag3 = !item.flags.HasFlag(ItemFlags.Identified);
					if (flag3)
					{
						Console.WriteLine("picking unidentified for : " + pickIt.OriginalLine);
						return true;
					}
					bool flag4 = this.PickItCheckStats(item, pickIt.Stats);
					bool flag5 = flag4;
					if (flag5)
					{
						flag4 = this.PickItCheckQuantity(item, pickIt);
						bool flag6 = flag4;
						if (flag6)
						{
							bool flag7 = !string.IsNullOrEmpty(pickIt.Tier);
							if (flag7)
							{
								EquipmentLocation equipmentLocation = EquipmentLocationHelper.GetEquipmentLocation(item.baseItem.BaseType.BodyLoc1);
								float num = this.PickItGetTier(base.me.Equipment[equipmentLocation], false);
								newTier = this.PickItCheckTier(item, pickIt.Tier);
								bool flag8 = newTier > num;
								bool flag9 = flag8;
								if (flag9)
								{
									Console.WriteLine("picking for tier upgrade : " + pickIt.OriginalLine);
								}
								return flag8;
							}
							bool flag10 = !string.IsNullOrEmpty(pickIt.MercTier);
							if (flag10)
							{
								Console.WriteLine("ignoremerc");
								return false;
							}
							Console.WriteLine("picking for stash : " + pickIt.OriginalLine);
							return true;
						}
					}
				}
			}
			return false;
		}

        // Token: 0x0600BEF5 RID: 48885 RVA: 0x00495B88 File Offset: 0x00493D88
        public float PickItGetTier(ItemAction item, bool isMerc = false)
        {
            float highestTier = 0f;

            foreach (var pickIt in this.pickItFilter.Where(p => (isMerc ? p.MercTier : p.Tier) != ""))
            {
                if (this.PickItCheckProperties(item, pickIt.Properties) && this.PickItCheckStats(item, pickIt.Stats))
                {
                    float tierValue = this.PickItCheckTier(item, isMerc ? pickIt.MercTier : pickIt.Tier);
                    if (highestTier < tierValue)
                    {
                        highestTier = tierValue;
                    }
                }
            }

            return highestTier;
        }


        // Token: 0x0600BEF6 RID: 48886 RVA: 0x00495C78 File Offset: 0x00493E78
        public void AddPickit(string file)
		{
			string[] array = File.ReadAllLines(file);
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i];
				string text2 = Regex.Replace(text, "([a-zA-Z]+)", "\"$1\"").ToLower();
				bool flag = text2.Trim().Length == 0;
				if (!flag)
				{
					bool flag2 = text2.Contains("//") && text2.Substring(0, text2.IndexOf("//")).Trim().Length == 0;
					if (!flag2)
					{
						string[] array2 = text2.Split('#', StringSplitOptions.None);
						string text3 = array2[0];
						bool flag3 = text3.Contains("//");
						if (flag3)
						{
							text3 = text3.Substring(0, text3.IndexOf("//"));
						}
						List<Type> list = new List<Type>
						{
							typeof(ItemKind),
							typeof(ItemQuality),
							typeof(ItemType)
						};
						foreach (Type type in list)
						{
							foreach (object obj in Enum.GetValues(type))
							{
								text3 = text3.Replace(" \"" + obj.ToString().ToLower() + "\"", " " + ((int)obj).ToString());
							}
						}
						bool flag4 = text3.Contains("[\"class\"]");
						if (flag4)
						{
							foreach (object obj2 in Enum.GetValues(typeof(ItemClass)))
							{
								text3 = text3.Replace("\"" + obj2.ToString().ToLower() + "\"", ((int)obj2).ToString());
							}
						}
						foreach (object obj3 in Enum.GetValues(typeof(ItemFlags)))
						{
							text3 = text3.Replace("\"" + obj3.ToString().ToLower() + "\"", 5.ToString());
						}
						string text4 = ((array2.Length > 1) ? array2[1] : "");
						bool flag5 = text4.Contains("//");
						if (flag5)
						{
							text4 = text4.Substring(0, text4.IndexOf("//"));
						}
						string text5 = ((array2.Length > 2) ? array2[2] : "");
						bool flag6 = text5.Contains("//");
						if (flag6)
						{
							text5 = text5.Substring(0, text5.IndexOf("//"));
						}
						bool flag7 = text5.ToLower().Contains("maxquantity");
						if (flag7)
						{
							this.pickItFilter.Add(new Game.PickIt
							{
								File = file,
								LineNumber = i,
								OriginalLine = text,
								Properties = text3.Trim(),
								Stats = text4,
								MaxQuantity = text5,
								Tier = "",
								MercTier = ""
							});
						}
						else
						{
							bool flag8 = text5.ToLower().Contains("merc");
							if (flag8)
							{
								this.pickItFilter.Add(new Game.PickIt
								{
									File = file,
									LineNumber = i,
									OriginalLine = text,
									Properties = text3.Trim(),
									Stats = text4,
									MaxQuantity = "",
									Tier = "",
									MercTier = text5
								});
							}
							else
							{
								this.pickItFilter.Add(new Game.PickIt
								{
									File = file,
									LineNumber = i,
									OriginalLine = text,
									Properties = text3.Trim(),
									Stats = text4,
									MaxQuantity = "",
									Tier = text5,
									MercTier = ""
								});
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BEF7 RID: 48887 RVA: 0x00496124 File Offset: 0x00494324
		public void PickItems()
		{
			List<ItemAction> list = this.GameInstance.Items.Values.Where((ItemAction item) => item.action == ItemActionType.AddToGround || item.action == ItemActionType.OnGround).ToList<ItemAction>();
			List<ItemAction> list2 = this.GameInstance.Items.Values.Where(delegate(ItemAction item)
			{
				float num3;
				return (item.action == ItemActionType.AddToGround || item.action == ItemActionType.OnGround) && this.PickItCheckItem(item, out num3);
			}).ToList<ItemAction>();
			List<ItemAction> list3 = list2.OrderBy((ItemAction i) => Helpers.GetDistance(base.me.X, base.me.Y, (ushort)i.x, (ushort)i.y)).ToList<ItemAction>();
			while (list3.Count > 0)
			{
				ItemAction itemAction = list3[0];
				Console.WriteLine(string.Concat(new string[]
				{
					"Grabbing ",
					itemAction.baseItem.Type.ToString(),
					"(",
					itemAction.baseItem.BaseType.Type.ToString(),
					"), ",
					itemAction.x.ToString(),
					" : ",
					itemAction.y.ToString()
				}));
				ushort num;
				ushort num2;
				bool flag = !this.FitBottomRightToTopLeft(itemAction, this.GameInstance.Items.Values.Where((ItemAction item) => item.OwnerId == base.me.Id && item.container == ItemContainer.Inventory), 10, 4, false, out num, out num2);
				if (flag)
				{
					this.TownVisitTown();
					this.PickItems();
					break;
				}
				bool flag2 = Helpers.GetDistance(base.me.X, base.me.Y, (ushort)itemAction.x, (ushort)itemAction.y) > 4f;
				if (flag2)
				{
					this.PatherMoveTo((long)itemAction.x, (long)itemAction.y, false, 2f);
				}
				PickItem pickItem = new PickItem();
				pickItem.X = (uint)((ushort)itemAction.x);
				pickItem.Y = (uint)((ushort)itemAction.y);
				pickItem.Id = itemAction.Id;
				pickItem.ToLocation = PickItem.PickLocation.Inventory;
				base.SendPacket(pickItem, (Packet p) => p is OwnedItemAction || p is SmallGoldAdd);
				list2 = this.GameInstance.Items.Values.Where((ItemAction item) => item.action == ItemActionType.AddToGround || item.action == ItemActionType.OnGround).ToList<ItemAction>();
				list3 = list2.OrderBy((ItemAction i) => Helpers.GetDistance(base.me.X, base.me.Y, (ushort)i.x, (ushort)i.y)).ToList<ItemAction>();
			}
		}

		// Token: 0x0600BEF8 RID: 48888 RVA: 0x004963A0 File Offset: 0x004945A0
		private void PlayerCorpseVisible(PlayerCorpseVisible data)
		{
			bool flag = data.PlayerId == base.me.Id;
			if (flag)
			{
				base.SendPacket(new UnitInteract
				{
					Id = data.CorpseId,
					myId = data.PlayerId
				});
			}
		}

		// Token: 0x0600BEF9 RID: 48889 RVA: 0x004963EC File Offset: 0x004945EC
		public bool SkillSetSkill(SkillType skill, SkillHand hand)
		{
			SkillType skillType = ((hand == SkillHand.Left) ? base.me.LeftHandSkill : base.me.RightHandSkill);
			bool flag = skillType == skill;
			bool flag2;
			if (flag)
			{
				flag2 = true;
			}
			else
			{
				bool flag3 = this.SkillLog[skill] == 0;
				if (flag3)
				{
					throw new Exception("using skill when shouldn't");
				}
				SelectSkill selectSkill = new SelectSkill();
				selectSkill.Type = skill;
				selectSkill.Hand = SelectSkill.SelectSkillHand.Right;
				base.SendPacket(selectSkill, (Packet p) => p is AssignSkill);
				skillType = ((hand == SkillHand.Left) ? base.me.LeftHandSkill : base.me.RightHandSkill);
				flag2 = skillType == skill;
			}
			return flag2;
		}

		// Token: 0x0600BEFA RID: 48890 RVA: 0x004964A0 File Offset: 0x004946A0
		public bool SkillCastSkill(SkillType skill, ushort x, ushort y)
		{
			bool flag = !this.SkillSetup(skill);
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				base.SendPacket(new CastRightSkill
				{
					X = x,
					Y = y
				});
				Thread.Sleep(this.CastRateDelay());
				flag2 = true;
			}
			return flag2;
		}

		// Token: 0x0600BEFB RID: 48891 RVA: 0x004964EC File Offset: 0x004946EC
		public bool SkillCastSkill(SkillType skill, AssignNPC npc)
		{
			bool flag = !this.SkillSetup(skill);
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				base.SendPacket(new CastRightSkillOnTarget
				{
					Type = UnitType.NPC,
					Id = npc.Id
				});
				Thread.Sleep(this.CastRateDelay());
				flag2 = true;
			}
			return flag2;
		}

		// Token: 0x0600BEFC RID: 48892 RVA: 0x0049653C File Offset: 0x0049473C
		public bool SkillCastSkill(SkillType skill, AssignGameObject npc)
		{
			bool flag = !this.SkillSetup(skill);
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				base.SendPacket(new CastRightSkillOnTarget
				{
					Type = UnitType.GameObject,
					Id = npc.Id
				});
				Thread.Sleep(this.CastRateDelay());
				flag2 = true;
			}
			return flag2;
		}

		// Token: 0x0600BEFD RID: 48893 RVA: 0x0049658C File Offset: 0x0049478C
		public bool SkillSetup(SkillType skill)
		{
			bool flag = base.InTown() && this.SkillTown(skill);
			if (flag)
			{
				throw new Exception("using skill when shouldn't");
			}
			bool flag2 = this.SkillLog[skill] == 0;
			if (flag2)
			{
				throw new Exception("using skill when shouldn't");
			}
			bool flag3 = (float)base.me.Mana < this.SkillGetManaCost(skill);
			if (flag3)
			{
				throw new Exception("using skill when shouldn't");
			}
			return this.SkillSetSkill(skill, SkillHelper.GetSkillHand(skill));
		}

		// Token: 0x0600BEFE RID: 48894 RVA: 0x00496610 File Offset: 0x00494810
		public bool SkillTown(SkillType skill)
		{
			return skill == SkillType.Telekinesis;
		}

		// Token: 0x0600BEFF RID: 48895 RVA: 0x00496628 File Offset: 0x00494828
		public float SkillGetManaCost(SkillType skill)
		{
			return SkillHelper.GetSkillMana(skill, (ushort)this.SkillLog[skill]);
		}

		// Token: 0x0600BF00 RID: 48896 RVA: 0x0049664C File Offset: 0x0049484C
		public void PartyUp()
		{
			this.party = 0;
			foreach (KeyValuePair<uint, Player> keyValuePair in this.GameInstance.Players)
			{
				bool flag = keyValuePair.Value == base.me;
				if (!flag)
				{
					this.party++;
					base.SendPacket(new PartyRequest
					{
						Action = PartyRequest.PartyAction.Invite,
						PlayerId = keyValuePair.Key
					});
				}
			}
			while (this.party > 0)
			{
			}
		}

		// Token: 0x0600BF01 RID: 48897 RVA: 0x004966F8 File Offset: 0x004948F8
		public void TpAndWaitForParty(ushort distance = 20, AreaLevel level = AreaLevel.None)
		{
			bool flag = level == AreaLevel.None;
			if (flag)
			{
				level = base.GetCurrentLevel();
			}
			this.ClearTp(20, AreaLevel.None);
			for (;;)
			{
				base.SendPacket(new UseInventoryItem
				{
					Id = this.inventoryTome.Id,
					X = (uint)base.me.X,
					Y = (uint)base.me.Y
				});
				bool flag2 = distance > 0;
				if (flag2)
				{
					this.KillSurrounding(distance);
				}
				bool flag3 = true;
				foreach (KeyValuePair<uint, Player> keyValuePair in this.GameInstance.Players)
				{
					bool flag4 = keyValuePair.Value == base.me;
					if (!flag4)
					{
						bool flag5 = keyValuePair.Value.Party != base.me.Party;
						if (!flag5)
						{
							bool flag6 = keyValuePair.Value.Area != level;
							if (flag6)
							{
								flag3 = false;
							}
						}
					}
				}
				bool flag7 = flag3;
				if (flag7)
				{
					break;
				}
				Thread.Sleep(100);
			}
		}

		// Token: 0x0600BF02 RID: 48898 RVA: 0x0049682C File Offset: 0x00494A2C
		public void AssistLeader()
		{
			this.GoToTpArea(this.currentAct);
			AreaLevel currentLevel = base.GetCurrentLevel();
			this.KillSurrounding(40);
			Thread.Sleep(this.Random.Next(50, 100));
			this.GoToTown(ActLocation.None);
		}

		// Token: 0x0600BF03 RID: 48899 RVA: 0x00496878 File Offset: 0x00494A78
		public bool TownCheck()
		{
			bool flag = base.me.State == Player.Mode.Dead;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				bool flag3 = base.InTown();
				if (flag3)
				{
					flag2 = false;
				}
				else
				{
					bool flag4 = this.GetGold() > 250U;
					if (flag4)
					{
						bool flag5 = this.GameInstance.Items.Count((KeyValuePair<uint, ItemAction> i) => i.Value.baseItem.Type.ToString().Contains("Healing")) == 0;
						if (flag5)
						{
							return true;
						}
						bool flag6 = this.GameInstance.Items.Count((KeyValuePair<uint, ItemAction> i) => i.Value.baseItem.Type.ToString().Contains("Mana")) == 0;
						if (flag6)
						{
							return true;
						}
					}
					flag2 = false;
				}
			}
			return flag2;
		}

		// Token: 0x0600BF04 RID: 48900 RVA: 0x00496944 File Offset: 0x00494B44
		public void TownFolkInteract(AssignNPC npc)
		{
			bool flag = Vector2.Distance(new Vector2((float)base.me.X, (float)base.me.Y), new Vector2((float)npc.X, (float)npc.Y)) > 6f;
			if (flag)
			{
				this.PatherMoveTo((long)((ulong)npc.X), (long)((ulong)npc.Y), false, 2f);
			}
			base.SendPacket(new TownFolkInteract
			{
				Id = npc.Id
			});
		}

		// Token: 0x0600BF05 RID: 48901 RVA: 0x004969C8 File Offset: 0x00494BC8
		public void TownFolkQuests(NPCCode code, params ushort[] ids)
		{
			AssignNPC value = this.GameInstance.NPCs.First((KeyValuePair<uint, AssignNPC> g) => g.Value.NpcType == code).Value;
			this.TownFolkInteract(value);
			foreach (ushort num in ids)
			{
				base.SendPacket(new DisplayQuestMessage
				{
					Id = value.Id,
					MessageD2R = num,
					UnitType = UnitType.NPC
				}, 200, 500);
			}
			base.SendPacket(new TownFolkCancelInteraction
			{
				Type = UnitType.NPC,
				Id = value.Id
			}, 200, 500);
		}

		// Token: 0x0600BF06 RID: 48902 RVA: 0x00496A88 File Offset: 0x00494C88
		public void TownFolkTravel(NPCCode code, AreaLevel destination)
		{
			AssignNPC value = this.GameInstance.NPCs.First((KeyValuePair<uint, AssignNPC> g) => g.Value.NpcType == code).Value;
			this.TownFolkInteract(value);
			base.SendPacket(new TownFolkCancelInteraction
			{
				Type = UnitType.NPC,
				Id = value.Id
			});
			while (destination != base.GetCurrentLevel())
			{
				base.SendPacket(new TownFolkMenuSelect
				{
					Type = TownFolkMenuItem.Travel,
					Id = value.Id
				});
				Thread.Sleep(this.Random.Next(250, 750));
			}
		}

		// Token: 0x0600BF07 RID: 48903 RVA: 0x00496B40 File Offset: 0x00494D40
		public bool TownNeedHealing()
		{
			bool flag = (float)base.me.Life * 100f / (base.me.Attributes[StatType.MaxLife] >> 8) <= (float)this.Config.HealHP || (long)(base.me.Mana * 100) / (long)((ulong)(base.me.Attributes[StatType.MaxMana] >> 8)) <= (long)((ulong)this.Config.HealMP);
			bool flag2;
			if (flag)
			{
				flag2 = true;
			}
			else
			{
				bool flag3 = this.Config.HealStatus && (base.me.States[StateType.Freeze] || base.me.States[StateType.Poison] || base.me.States[StateType.AmplifyDamage] || base.me.States[StateType.LowerResist]);
				flag2 = flag3;
			}
			return flag2;
		}

		// Token: 0x0600BF08 RID: 48904 RVA: 0x00496C34 File Offset: 0x00494E34
		public void TownHeal()
		{
			bool flag = !this.TownNeedHealing();
			if (!flag)
			{
				AreaLevel currentLevel = base.GetCurrentLevel();
				NPCCode healer = NPCCode.Akara;
				bool flag2 = currentLevel == AreaLevel.RogueEncampment;
				if (flag2)
				{
					healer = NPCCode.Akara;
				}
				else
				{
					bool flag3 = currentLevel == AreaLevel.LutGholein;
					if (flag3)
					{
						healer = NPCCode.Fara;
					}
					else
					{
						bool flag4 = currentLevel == AreaLevel.KurastDocks;
						if (flag4)
						{
							healer = NPCCode.Ormus;
						}
						else
						{
							bool flag5 = currentLevel == AreaLevel.ThePandemoniumFortress;
							if (flag5)
							{
								healer = NPCCode.Jamella;
							}
							else
							{
								bool flag6 = currentLevel == AreaLevel.Harrogath;
								if (flag6)
								{
									healer = NPCCode.Malah;
								}
							}
						}
					}
				}
				PresetUnit presetUnit = this.GameInstance.LevelData[currentLevel].Units.First((PresetUnit u) => u.CastedNPCCode == healer);
				this.PatherMoveTo((long)((ulong)presetUnit.X), (long)((ulong)presetUnit.Y), false, 2f);
				AssignNPC value = this.GameInstance.NPCs.First((KeyValuePair<uint, AssignNPC> g) => g.Value.NpcType == healer).Value;
				this.TownFolkInteract(value);
				base.SendPacket(new TownFolkCancelInteraction
				{
					Type = UnitType.NPC,
					Id = value.Id
				});
			}
		}

		// Token: 0x0600BF09 RID: 48905 RVA: 0x00496D74 File Offset: 0x00494F74
		private bool AreIntersected(int x1, int y1, int w1, int h1, int x2, int y2, int w2, int h2)
		{
			return x2 < x1 + w1 && x1 < x2 + w2 && y2 < y1 + h1 && y1 < y2 + h2;
		}

		// Token: 0x0600BF0A RID: 48906 RVA: 0x00496DA8 File Offset: 0x00494FA8
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

        // Token: 0x0600BF0B RID: 48907 RVA: 0x00497088 File Offset: 0x00495288
        // [Ares] from GPT
        private bool FitBottomRightToTopLeft(ItemAction item, IEnumerable<ItemAction> otherItems, int width, int height, bool weighted, out ushort outX, out ushort outY)
        {
            outX = ushort.MaxValue;
            outY = ushort.MaxValue;
            int maxWeight = 0;

            for (int x = width - item.baseItem.InvWidth; x >= 0; x--)
            {
                for (int y = height - item.baseItem.InvHeight; y >= 0; y--)
                {
                    // Check if the item can be placed at (x, y) without overlapping with other items
                    if (otherItems.All(i => !AreIntersected(
                        x, y, item.baseItem.InvWidth, item.baseItem.InvHeight,
                        i.x, i.y, i.baseItem.InvWidth, i.baseItem.InvHeight)))
                    {
                        // Calculate the placement weight
                        int placementWeight = GetPlacementWeight(otherItems, item, x, y, width, height);

                        // Update position and weight if this placement is better
                        if (placementWeight > maxWeight)
                        {
                            maxWeight = placementWeight;
                            outX = (ushort)x;
                            outY = (ushort)y;
                        }

                        // If the maximum weight is achieved or weighting is not required, return immediately
                        if (placementWeight == 255 || !weighted)
                        {
                            return true;
                        }
                    }
                }
            }

            // Return true if a valid position was found, false otherwise
            return maxWeight > 0;
        }

        // Token: 0x0600BF0C RID: 48908 RVA: 0x00497208 File Offset: 0x00495408
        private bool FitTopLeftToBottomRight(ItemAction item, IEnumerable<ItemAction> otherItems, int width, int height, bool weighted, ref ushort vendorX, ref ushort vendorY)
        {
            int maxWeight = 0;

            for (int x = 0; x <= width - item.baseItem.InvWidth; x++)
            {
                for (int y = 0; y <= height - item.baseItem.InvHeight; y++)
                {
                    // Check if the item can be placed at (x, y) without overlapping with other items
                    if (otherItems.All(i => !AreIntersected(
                        x, y, item.baseItem.InvWidth, item.baseItem.InvHeight,
                        i.x, i.y, i.baseItem.InvWidth, i.baseItem.InvHeight)))
                    {
                        // Calculate the placement weight
                        int placementWeight = GetPlacementWeight(otherItems, item, x, y, width, height);

                        // Update the position and weight if this placement is better
                        if (placementWeight > maxWeight)
                        {
                            maxWeight = placementWeight;
                            vendorX = (ushort)x;
                            vendorY = (ushort)y;
                        }

                        // If the maximum weight is achieved or weighting is not required, return immediately
                        if (placementWeight == 255 || !weighted)
                        {
                            return true;
                        }
                    }
                }
            }

            // Return true if a valid position was found, false otherwise
            return maxWeight > 0;
        }

        // Token: 0x0600BF0D RID: 48909 RVA: 0x0049737C File Offset: 0x0049557C
        private bool FitTopRightToBottomLeft(ItemAction item, IEnumerable<ItemAction> otherItems, int width, int height, bool weighted, ref ushort vendorX, ref ushort vendorY)
        {
            int maxWeight = 0;

            for (int x = width - item.baseItem.InvWidth; x >= 0; x--)
            {
                for (int y = 0; y <= height - item.baseItem.InvHeight; y++)
                {
                    // Check if the item can be placed at (x, y) without overlapping with other items
                    if (otherItems.All(i => !AreIntersected(
                        x, y, item.baseItem.InvWidth, item.baseItem.InvHeight,
                        i.x, i.y, i.baseItem.InvWidth, i.baseItem.InvHeight)))
                    {
                        // Calculate the placement weight
                        int placementWeight = GetPlacementWeight(otherItems, item, x, y, width, height);

                        // Update the position and weight if this placement is better
                        if (placementWeight > maxWeight)
                        {
                            maxWeight = placementWeight;
                            vendorX = (ushort)x;
                            vendorY = (ushort)y;
                        }

                        // If the maximum weight is achieved or weighting is not required, return immediately
                        if (placementWeight == 255 || !weighted)
                        {
                            return true;
                        }
                    }
                }
            }

            // Return true if a valid position was found, false otherwise
            return maxWeight > 0;
        }

        // Token: 0x0600BF0E RID: 48910 RVA: 0x004974EC File Offset: 0x004956EC
        public SellItem TownGetSellItemPacket(ItemAction item, AssignNPC npc)
		{
			SellItem i;
			List<ItemAction> list = this.GameInstance.Items.Values.Where((ItemAction i) => i.OwnerId == item.Id).ToList<ItemAction>();
			i = new SellItem
			{
				ItemId = item.Id,
				DealerIdD2R = npc.Id,
				CostD2R = (uint)item.GetItemCost(1, 0, 0, this.updateQuestInfo, list),
				X = (ushort)item.x,
				Y = (ushort)item.y
			};
			IEnumerable<ItemAction> enumerable = this.GameInstance.Items.Values.Where((ItemAction i2) => i2.action == ItemActionType.AddToShop && i2.flags.HasFlag(ItemFlags.EquippedD2R));
			bool flag = this.GameInstance.Items.Values.Where((ItemAction i2) => i2.OwnerId == item.Id).Count<ItemAction>() > 0;
			bool flag2 = this.GameInstance.Items.Values.Where((ItemAction i2) => i2.flags.HasFlag(ItemFlags.Gamble)).Count<ItemAction>() > 2;
			bool flag3 = flag2;
			if (flag3)
			{
				i.Type = (ItemDestination)256;
			}
			bool flag4 = item.baseItem.Type.ToString().Contains("Healing") || item.baseItem.Type.ToString().Contains("Mana") || item.baseItem.Type.ToString().Contains("Stamina") || item.baseItem.Type.ToString().Contains("Thawing") || item.baseItem.Type.ToString().Contains("Antidote") || item.baseItem.Type.ToString().Contains("TomeOf") || item.baseItem.Type.ToString().Contains("ScrollOf") || item.baseItem.Type == ItemType.Key || flag || flag2 || item.flags.HasFlag(ItemFlags.Ethereal) || (item.quality == ItemQuality.Inferior && item.prefix.Index != 1);
			if (!flag4)
			{
				bool flag5 = item.baseItem is BaseMiscItem || item.baseItem.Stackable;
				if (flag5)
				{
					IEnumerable<ItemAction> enumerable2 = this.GameInstance.Items.Values.Where((ItemAction i2) => i2.action == ItemActionType.AddToShop && (i2.baseItem is BaseMiscItem || i2.baseItem.Stackable));
					i.VendorPage = 3;
					bool flag6 = item.baseItem.InvHeight == 1;
					if (flag6)
					{
						bool flag7 = this.FitTopRightToBottomLeft(item, enumerable2, 10, 10, false, ref i.VendorX, ref i.VendorY);
						if (flag7)
						{
							return i;
						}
					}
					else
					{
						bool flag8 = this.FitTopLeftToBottomRight(item, enumerable2, 10, 10, false, ref i.VendorX, ref i.VendorY);
						if (flag8)
						{
							return i;
						}
					}
				}
				else
				{
					bool flag9 = item.baseItem is BaseWeapon;
					if (flag9)
					{
						IEnumerable<ItemAction> enumerable3 = this.GameInstance.Items.Values.Where((ItemAction i) => i.action == ItemActionType.AddToShop && i.baseItem is BaseWeapon);
						i.VendorPage = 1;
						IEnumerable<ItemAction> enumerable4 = enumerable3.Where((ItemAction w) => w.container == (int)i.VendorPage + ItemContainer.Inventory);
						bool flag10 = this.FitTopLeftToBottomRight(item, enumerable4, 10, 10, false, ref i.VendorX, ref i.VendorY);
						if (flag10)
						{
							return i;
						}
						i.VendorPage = 2;
						IEnumerable<ItemAction> enumerable5 = enumerable3.Where((ItemAction w) => w.container == (int)i.VendorPage + ItemContainer.Inventory);
						bool flag11 = this.FitTopLeftToBottomRight(item, enumerable4, 10, 10, false, ref i.VendorX, ref i.VendorY);
						if (flag11)
						{
							return i;
						}
					}
					else
					{
						bool flag12 = item.baseItem is BaseArmor;
						if (flag12)
						{
							i.VendorPage = 0;
							IEnumerable<ItemAction> enumerable6 = this.GameInstance.Items.Values.Where((ItemAction i) => i.action == ItemActionType.AddToShop && i.baseItem is BaseArmor);
							bool flag13 = item.baseItem.InvHeight == 1 && this.FitTopRightToBottomLeft(item, enumerable6, 10, 10, false, ref i.VendorX, ref i.VendorY);
							if (flag13)
							{
								return i;
							}
							bool flag14 = this.FitTopLeftToBottomRight(item, enumerable6, 10, 10, false, ref i.VendorX, ref i.VendorY);
							if (flag14)
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

		// Token: 0x0600BF0F RID: 48911 RVA: 0x00497B20 File Offset: 0x00495D20
		public void TownUpdateEquipment()
		{
			IEnumerable<ItemAction> enumerable = ItemContainer.Inventory.GetItems(this.GameInstance.Items.Values.ToList<ItemAction>()).Where(delegate(ItemAction i)
			{
				float num4;
				return i.baseItem.Type != ItemType.ScrollOfIdentify && i.baseItem.Type != ItemType.ScrollOfIdentify && i.baseItem.Type != ItemType.ScrollOfTownPortal && i.baseItem.Type != ItemType.TomeOfTownPortal && this.PickItCheckItem(i, out num4);
			});
			using (IEnumerator<ItemAction> enumerator = enumerable.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ItemAction item = enumerator.Current;
					EquipmentLocation equipmentLocation = EquipmentLocationHelper.GetEquipmentLocation(item.baseItem.BaseType.BodyLoc1);
					float num = this.PickItGetTier(base.me.Equipment[equipmentLocation], false);
					float num2 = this.PickItGetTier(item, false);
					bool flag = num2 > num;
					if (!flag)
					{
						throw new Exception("better item according to pickit, but no where to put it?");
					}
					PickItemFromContainer pickItemFromContainer = new PickItemFromContainer();
					pickItemFromContainer.Id = item.Id;
					base.SendPacket(pickItemFromContainer, (Packet p) => p is OwnedItemAction);
					ItemAction itemAction = base.me.Equipment[equipmentLocation];
					bool flag2 = itemAction != null;
					if (flag2)
					{
						SwapEquippedItem swapEquippedItem = new SwapEquippedItem();
						swapEquippedItem.Id = item.Id;
						swapEquippedItem.EquippedId = itemAction.Id;
						swapEquippedItem.Location = equipmentLocation;
						base.SendPacket(swapEquippedItem, (Packet p) => p is OwnedItemAction);
						float num3;
						bool flag3 = !this.PickItCheckItem(itemAction, out num3);
						if (flag3)
						{
							DropItem dropItem = new DropItem();
							dropItem.Id = itemAction.Id;
							base.SendPacket(dropItem, (Packet p) => p is WorldItemAction);
						}
						else
						{
							bool[,] array;
							bool flag4 = ItemContainer.Inventory.GetFreeSpace(this.GameInstance.Items.Values.ToArray<ItemAction>().ToList<ItemAction>(), out array) < 32;
							if (!flag4)
							{
								throw new Exception("no space to drop old item on pickit?");
							}
							DropItem dropItem2 = new DropItem();
							dropItem2.Id = itemAction.Id;
							base.SendPacket(dropItem2, (Packet p) => p is WorldItemAction);
						}
					}
					else
					{
						base.SendPacket(new EquipItem
						{
							Id = item.Id,
							Location = equipmentLocation
						}, delegate(Packet p)
						{
							OwnedItemAction ownedItemAction = p as OwnedItemAction;
							return ownedItemAction != null && ownedItemAction.Id == item.Id;
						});
					}
				}
			}
		}

		// Token: 0x0600BF10 RID: 48912 RVA: 0x00497DB8 File Offset: 0x00495FB8
		public void TownStashItems()
		{
			IEnumerable<ItemAction> enumerable = ItemContainer.Inventory.GetItems(this.GameInstance.Items.Values.ToList<ItemAction>()).Where(delegate(ItemAction i)
			{
				float num;
				return i.baseItem.Type != ItemType.ScrollOfIdentify && i.baseItem.Type != ItemType.ScrollOfIdentify && i.baseItem.Type != ItemType.ScrollOfTownPortal && i.baseItem.Type != ItemType.TomeOfTownPortal && !i.baseItem.Type.ToString().Contains("Potion") && i.baseItem.Quest == -1 && this.PickItCheckItem(i, out num) && num == 0f;
			});
			bool flag = enumerable.Count<ItemAction>() > 0;
			if (flag)
			{
				PresetUnit presetUnit = this.GameInstance.LevelData[base.GetCurrentLevel()].Units.First((PresetUnit i) => i.CastedGameObject == GameObjectID.Bank);
				foreach (ItemAction itemAction in enumerable)
				{
					ValueTuple<ushort, ushort> availableLocation = ItemContainer.Stash.GetAvailableLocation(ItemContainer.Stash.GetItems(this.GameInstance.Items.Values.ToList<ItemAction>()), itemAction);
					bool flag2 = availableLocation.Item1 == ushort.MaxValue;
					if (flag2)
					{
						Console.WriteLine("put in shared stash todo");
						throw new Exception("");
					}
					string text = "stashing ";
					ItemAction itemAction2 = itemAction;
					Console.WriteLine(text + ((itemAction2 != null) ? itemAction2.ToString() : null));
					PickItemFromContainer pickItemFromContainer = new PickItemFromContainer();
					pickItemFromContainer.Id = itemAction.Id;
					base.SendPacket(pickItemFromContainer, (Packet p) => p is OwnedItemAction && ((OwnedItemAction)p).action == ItemActionType.RemoveFromContainer);
					DropItemToContainer dropItemToContainer = new DropItemToContainer();
					dropItemToContainer.Id = itemAction.Id;
					dropItemToContainer.Container = DropItemToContainer.ContainerType.Stash;
					dropItemToContainer.X = (uint)availableLocation.Item1;
					dropItemToContainer.Y = (uint)availableLocation.Item2;
					base.SendPacket(dropItemToContainer, (Packet p) => p is WorldItemAction && ((WorldItemAction)p).action == ItemActionType.PutInContainer);
				}
			}
		}

		// Token: 0x0600BF11 RID: 48913 RVA: 0x00497F94 File Offset: 0x00496194
		public void TownIdentify()
		{
			AreaLevel areaLevel = base.GetCurrentLevel();
			List<ItemAction> list = this.GameInstance.Items.Values.Where((ItemAction i) => i.OwnerId == base.me.Id && i.quality >= ItemQuality.Magic && !i.flags.HasFlag(ItemFlags.Identified) && i.container == ItemContainer.Inventory).ToArray<ItemAction>().ToList<ItemAction>();
			IEnumerable<ItemAction> enumerable = this.GameInstance.Items.Values.Where((ItemAction i) => i.OwnerId == base.me.Id && i.container == ItemContainer.Inventory);
			bool flag = list.Count<ItemAction>() > 0;
			if (flag)
			{
				bool flag2 = this.updateQuestInfo.Quests_42[4].Standing == QuestStanding.Complete;
				if (flag2)
				{
					NPCCode cain = NPCCode.DeckardCain;
					bool flag3 = areaLevel == AreaLevel.RogueEncampment;
					if (flag3)
					{
						cain = NPCCode.DeckardCain;
					}
					else
					{
						bool flag4 = areaLevel == AreaLevel.LutGholein;
						if (flag4)
						{
							cain = NPCCode.DeckardCain2;
						}
						else
						{
							bool flag5 = areaLevel == AreaLevel.KurastDocks;
							if (flag5)
							{
								cain = NPCCode.DeckardCain3;
							}
							else
							{
								bool flag6 = areaLevel == AreaLevel.ThePandemoniumFortress;
								if (flag6)
								{
									cain = NPCCode.DeckardCain4;
								}
								else
								{
									bool flag7 = areaLevel == AreaLevel.Harrogath;
									if (flag7)
									{
										cain = NPCCode.DeckardCain5;
									}
								}
							}
						}
					}
					PresetUnit presetUnit = this.GameInstance.LevelData[areaLevel].Units.First((PresetUnit u) => u.CastedNPCCode == cain);
					this.PatherMoveTo((long)((ulong)presetUnit.X), (long)((ulong)presetUnit.Y), false, 2f);
					AssignNPC value = this.GameInstance.NPCs.First((KeyValuePair<uint, AssignNPC> g) => g.Value.NpcType == cain).Value;
					this.TownFolkInteract(value);
					CainIdentifyItems cainIdentifyItems = new CainIdentifyItems();
					cainIdentifyItems.Id = value.Id;
					base.SendPacket(cainIdentifyItems, (Packet p) => p is TransactionComplete);
					base.SendPacket(new TownFolkCancelInteraction
					{
						Type = UnitType.NPC,
						Id = value.Id
					});
				}
				else
				{
					bool flag8 = this.updateQuestInfo.Quests_42[4].Standing != QuestStanding.Complete && this.updateQuestInfo.Quests_42[4].Standing != QuestStanding.RewardPending;
					if (!flag8)
					{
						throw new Exception("shouldn't get here");
					}
					bool flag9 = areaLevel != AreaLevel.RogueEncampment;
					if (flag9)
					{
						this.GoToTown(ActLocation.Act1);
						areaLevel = base.GetCurrentLevel();
					}
					NPCCode healer = NPCCode.Akara;
					bool flag10 = areaLevel == AreaLevel.RogueEncampment;
					if (flag10)
					{
						healer = NPCCode.Akara;
					}
					PresetUnit presetUnit2 = this.GameInstance.LevelData[areaLevel].Units.First((PresetUnit u) => u.CastedNPCCode == healer);
					this.PatherMoveTo((long)((ulong)presetUnit2.X), (long)((ulong)presetUnit2.Y), false, 2f);
					AssignNPC value2 = this.GameInstance.NPCs.First((KeyValuePair<uint, AssignNPC> g) => g.Value.NpcType == healer).Value;
					this.TownFolkInteract(value2);
					base.SendPacket(new TownFolkMenuSelect
					{
						Type = TownFolkMenuItem.Trade,
						Id = value2.Id
					});
					Thread.Sleep(400);
					uint num = 80U;
					bool flag11 = areaLevel == AreaLevel.RogueEncampment && (this.updateQuestInfo.Quests_42[4].Standing == QuestStanding.Complete || this.updateQuestInfo.Quests_42[4].Standing == QuestStanding.RewardPending);
					if (flag11)
					{
						num = 72U;
					}
					foreach (ItemAction itemAction in list)
					{
						ItemAction scrollObj = this.GameInstance.Items.Values.FirstOrDefault((ItemAction i) => i.OwnerId == base.me.Id && i.baseItem.Type == ItemType.ScrollOfIdentify);
						bool flag12 = scrollObj == null;
						if (flag12)
						{
							scrollObj = this.GameInstance.Items.Values.First((ItemAction i) => i.action == ItemActionType.AddToShop && i.baseItem.Type == ItemType.ScrollOfIdentify);
							ushort num2 = 0;
							ushort num3 = 0;
							bool flag13 = this.GetGold() > num && this.FitBottomRightToTopLeft(scrollObj, enumerable, 10, 4, true, out num2, out num3);
							if (!flag13)
							{
								Console.WriteLine("no money to buy id scroll, sell anyway");
								SellItem sellItem = this.TownGetSellItemPacket(itemAction, value2);
								base.SendPacket(sellItem, (Packet p) => p is TransactionComplete);
								continue;
							}
							base.SendPacket(new BuyItem
							{
								ItemId = scrollObj.Id,
								CostD2R = num,
								DealerIdD2R = value2.Id,
								VendorX = (ushort)scrollObj.x,
								VendorY = (ushort)scrollObj.y,
								VendorPage = (byte)(scrollObj.container - ItemContainer.Inventory),
								X = num2,
								Y = num3
							}, (Packet p) => p is OwnedItemAction && (scrollObj = p as OwnedItemAction) != null);
						}
						bool flag14 = scrollObj != null;
						if (!flag14)
						{
							throw new Exception("no id scroll for some reason");
						}
						OwnedItemAction owi = new OwnedItemAction();
						base.SendPacket(new UseItem
						{
							ItemId = scrollObj.Id,
							Consume = 1,
							PlayerId = base.me.Id,
							X = (byte)scrollObj.x,
							Y = (byte)scrollObj.y
						});
						base.SendPacket(new UseItem
						{
							ItemId = scrollObj.Id,
							isMerc = 4,
							xff = 0,
							Consume = 1,
							PlayerId = itemAction.Id,
							X = (byte)scrollObj.x,
							Y = (byte)scrollObj.y,
							TargetX = (byte)itemAction.x,
							TargetY = (byte)itemAction.y
						}, (Packet p) => p is OwnedItemAction && (owi = p as OwnedItemAction) != null);
						float num4;
						bool flag15 = this.PickItCheckItem(owi, out num4);
						SellItem sellItem2 = this.TownGetSellItemPacket(owi, value2);
						bool flag16 = !flag15;
						if (flag16)
						{
							base.SendPacket(this.TownGetSellItemPacket(owi, value2));
						}
					}
				}
			}
			IEnumerable<ItemAction> enumerable2 = this.GameInstance.Items.Values.Where(delegate(ItemAction i)
			{
				float num5;
				return i.OwnerId == base.me.Id && i.container == ItemContainer.Inventory && !this.PickItCheckItem(i, out num5);
			});
			bool flag17 = enumerable2.Count<ItemAction>() > 0;
			if (flag17)
			{
				IEnumerable<ItemAction> enumerable3 = this.GameInstance.Items.Values.Where((ItemAction i) => i.OwnerId == base.me.Id && i.container == ItemContainer.Inventory && i.baseItem.Type == ItemType.TomeOfTownPortal);
				bool flag18 = areaLevel != AreaLevel.RogueEncampment;
				if (flag18)
				{
					this.GoToTown(ActLocation.Act1);
					areaLevel = base.GetCurrentLevel();
				}
				NPCCode seller = NPCCode.Akara;
				bool flag19 = areaLevel == AreaLevel.RogueEncampment;
				if (flag19)
				{
					seller = NPCCode.Akara;
				}
				PresetUnit presetUnit3 = this.GameInstance.LevelData[areaLevel].Units.First((PresetUnit u) => u.CastedNPCCode == seller);
				this.PatherMoveTo((long)((ulong)presetUnit3.X), (long)((ulong)presetUnit3.Y), false, 2f);
				AssignNPC value3 = this.GameInstance.NPCs.First((KeyValuePair<uint, AssignNPC> g) => g.Value.NpcType == seller).Value;
				this.TownFolkInteract(value3);
				TownFolkMenuSelect townFolkMenuSelect = new TownFolkMenuSelect();
				townFolkMenuSelect.Type = TownFolkMenuItem.Trade;
				townFolkMenuSelect.Id = value3.Id;
				base.SendPacket(townFolkMenuSelect, (Packet p) => p is Relator1);
				foreach (ItemAction itemAction2 in enumerable2)
				{
					SellItem sellItem3 = this.TownGetSellItemPacket(itemAction2, value3);
					base.SendPacket(sellItem3, (Packet p) => p is TransactionComplete);
				}
			}
		}

		// Token: 0x0600BF12 RID: 48914 RVA: 0x00498820 File Offset: 0x00496A20
		public bool TownReviveMerc()
		{
			bool flag = !this.TownNeedMerc();
			bool flag2;
			if (flag)
			{
				flag2 = true;
			}
			else
			{
				bool flag3 = !base.InTown();
				if (flag3)
				{
					this.GoToTown(ActLocation.None);
				}
				ActLocation act = ActLocationHelper.GetAct(base.GetCurrentLevel());
				bool flag4 = act == ActLocation.Act3;
				if (flag4)
				{
					bool flag5 = this.PatherAccesToAct(ActLocation.Act4);
					if (flag5)
					{
						this.GoToTown(ActLocation.Act4);
					}
					else
					{
						this.GoToTown(ActLocation.Act1);
					}
				}
				AreaLevel currentLevel = base.GetCurrentLevel();
				NPCCode mercCaptain = NPCCode.Akara;
				bool flag6 = currentLevel == AreaLevel.RogueEncampment;
				if (flag6)
				{
					mercCaptain = NPCCode.Kashya;
				}
				else
				{
					bool flag7 = currentLevel == AreaLevel.LutGholein;
					if (flag7)
					{
						mercCaptain = NPCCode.Greiz;
					}
					else
					{
						bool flag8 = currentLevel == AreaLevel.ThePandemoniumFortress;
						if (flag8)
						{
							mercCaptain = NPCCode.Tyrael2;
						}
						else
						{
							bool flag9 = currentLevel == AreaLevel.Harrogath;
							if (flag9)
							{
								mercCaptain = NPCCode.QualKehk;
							}
						}
					}
				}
				PresetUnit presetUnit = this.GameInstance.LevelData[currentLevel].Units.First((PresetUnit u) => u.CastedNPCCode == mercCaptain);
				this.PatherMoveTo((long)((ulong)presetUnit.X), (long)((ulong)presetUnit.Y), false, 2f);
				AssignNPC value = this.GameInstance.NPCs.First((KeyValuePair<uint, AssignNPC> g) => g.Value.NpcType == mercCaptain).Value;
				this.TownFolkInteract(value);
				base.SendPacket(new ResurrectMerc
				{
					DealerId = value.Id,
					NameId = this.MercNameId,
					Unk = 0,
					Cost = this.MercReviveCost
				});
				this.MercReviveCost = 0U;
				this.MercNameId = 0;
				bool flag10 = ActLocationHelper.GetAct(base.me.Area) != act;
				if (flag10)
				{
					this.GoToTown(act);
				}
				flag2 = true;
			}
			return flag2;
		}

		// Token: 0x0600BF13 RID: 48915 RVA: 0x004989EC File Offset: 0x00496BEC
		public bool TownNeedMerc()
		{
			bool flag = this.MercReviveCost == 0U;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				bool flag3 = this.GetGold() < 100U;
				if (flag3)
				{
					flag2 = false;
				}
				else
				{
					bool flag4 = this.GetGold() < this.MercReviveCost || !this.Config.UseMerc;
					flag2 = !flag4;
				}
			}
			return flag2;
		}

		// Token: 0x0600BF14 RID: 48916 RVA: 0x00498A4C File Offset: 0x00496C4C
		public void TownDoChores()
		{
			ICollection<ItemAction> values = this.GameInstance.Items.Values;
			foreach (ItemAction itemAction in values)
			{
				SellItem sellItem = this.TownGetSellItemPacket(itemAction, new AssignNPC());
			}
			bool flag = !base.InTown();
			if (flag)
			{
				this.GoToTown(ActLocation.None);
			}
			this.TownReviveMerc();
			this.TownIdentify();
			this.TownHeal();
			this.TownBuyPotions();
			this.TownStashItems();
		}

		// Token: 0x0600BF15 RID: 48917 RVA: 0x00498AEC File Offset: 0x00496CEC
		public void TownClearBelt()
		{
			int c;
			int c2;
			for (c = 0; c < 4; c = c2 + 1)
			{
				ItemKind beltColumn = this.Config.BeltColumn[c];
				IOrderedEnumerable<ItemAction> orderedEnumerable = from i in this.GameInstance.Items.Values
					where (i.container == ItemContainer.Belt || i.action == ItemActionType.PutInBelt || i.destination == ItemDestination.Belt) && i.action != ItemActionType.RemoveFromBelt && i.x % 4 == c && i.baseItem.BaseType.Type != beltColumn
					orderby i.x descending
					select i;
				foreach (ItemAction itemAction in orderedEnumerable)
				{
					string[] array = new string[6];
					array[0] = "need to clearing belt col : ";
					array[1] = c.ToString();
					array[2] = " : ";
					int num = 3;
					ItemAction itemAction2 = itemAction;
					array[num] = ((itemAction2 != null) ? itemAction2.ToString() : null);
					array[4] = " : ";
					array[5] = itemAction.x.ToString();
					Console.WriteLine(string.Concat(array));
					base.SendPacket(new UseItem
					{
						Consume = 1,
						ItemId = itemAction.Id,
						PlayerId = base.me.Id,
						X = (byte)itemAction.x,
						Y = (byte)itemAction.y,
						xff02ifbelt = 65282
					});
				}
				c2 = c;
			}
		}

		// Token: 0x0600BF16 RID: 48918 RVA: 0x00498C9C File Offset: 0x00496E9C
		public uint GetGold()
		{
			uint num = 0U;
			bool flag = base.me.Attributes.ContainsKey(StatType.Gold);
			if (flag)
			{
				num += base.me.Attributes[StatType.Gold];
			}
			bool flag2 = base.me.Attributes.ContainsKey(StatType.GoldBank);
			if (flag2)
			{
				num += base.me.Attributes[StatType.GoldBank];
			}
			return num;
		}

		// Token: 0x0600BF17 RID: 48919 RVA: 0x00498D08 File Offset: 0x00496F08
		public void TownVisitTown()
		{
			bool flag = base.InTown();
			if (flag)
			{
				this.TownDoChores();
			}
			else
			{
				this.GoToTown(ActLocation.None);
				this.TownDoChores();
			}
		}

        // Token: 0x0600BF18 RID: 48920 RVA: 0x00498D3C File Offset: 0x00496F3C
        // [Ares] from GPT
        public void TownBuyPotions()
        {
            if (this.GetGold() < 300U)
                return;

            if (this.difficulty == GameDifficulty.Normal && base.GetCurrentLevel() <= AreaLevel.DurielsLair && this.PatherAccesToAct(ActLocation.Act4))
            {
                this.GoToTown(ActLocation.Act4);
            }

            this.TownClearBelt();
            bool requiresPotionPurchase = false;
            int hpPotionsNeeded = 0;
            int mpPotionsNeeded = 0;

            IEnumerable<ItemAction> inventoryItems = this.GameInstance.Items.Values.Where(i => i.container == ItemContainer.Inventory || i.destination == ItemDestination.Belt);

            if (this.Config.HPBuffer > 0)
            {
                hpPotionsNeeded = (int)this.Config.HPBuffer - inventoryItems.Count(i => i.baseItem.BaseType.Type == ItemKind.HealingPotion);
            }

            if (this.Config.MPBuffer > 0)
            {
                mpPotionsNeeded = (int)this.Config.MPBuffer - inventoryItems.Count(i => i.baseItem.BaseType.Type == ItemKind.ManaPotion);
            }

            ItemAction equippedBelt = this.GameInstance.Items.Values.FirstOrDefault(i => i.location == EquipmentLocation.Belt && i.action == ItemActionType.Equip && i.OwnerId == this.me.Id);
            int beltColumns = equippedBelt != null && (equippedBelt.baseItem.Type == ItemType.Belt || equippedBelt.baseItem.Type == ItemType.HeavyBelt) ? 3 : (equippedBelt != null && (equippedBelt.baseItem.Type == ItemType.Sash || equippedBelt.baseItem.Type == ItemType.LightBelt) ? 2 : 4);

            int expectedPotionCount = this.Config.BeltColumn.Count(i => i != ItemKind.RejuvenationPotion) * beltColumns;
            int currentPotionCount = this.GameInstance.Items.Values.Count(i => (i.container == ItemContainer.Belt || i.action == ItemActionType.PutInBelt || i.destination == ItemDestination.Belt) && i.action != ItemActionType.RemoveFromBelt && i.baseItem.BaseType.Type != ItemKind.RejuvenationPotion);

            if (currentPotionCount != expectedPotionCount)
            {
                requiresPotionPurchase = true;
            }

            if (hpPotionsNeeded + mpPotionsNeeded > 0 || requiresPotionPurchase)
            {
                NPCCode potionVendor = this.currentAct switch
                {
                    ActLocation.Act1 => NPCCode.Akara,
                    ActLocation.Act2 => NPCCode.Lysander,
                    ActLocation.Act3 => NPCCode.Ormus,
                    ActLocation.Act4 => NPCCode.Jamella,
                    _ => NPCCode.Malah
                };

                this.TravelTo(potionVendor, false);
                AssignNPC vendorNPC = this.GameInstance.NPCs.Values.First(n => n.NpcType == potionVendor);
                base.SendPacket(new TownFolkMenuSelect
                {
                    Type = TownFolkMenuItem.Trade,
                    Id = vendorNPC.Id
                }, 250, 600);

                for (int column = 0; column < 4; column++)
                {
                    ItemKind beltColumn = this.Config.BeltColumn[column];
                    int itemsInColumn;

                    do
                    {
                        itemsInColumn = this.GameInstance.Items.Values.Count(i => (i.container == ItemContainer.Belt || i.action == ItemActionType.PutInBelt || i.destination == ItemDestination.Belt) && i.action != ItemActionType.RemoveFromBelt && i.x % 4 == column);

                        if (itemsInColumn == beltColumns)
                            break;

                        ItemAction shopItem = this.GameInstance.Items.Values
                            .Where(i => i.action == ItemActionType.AddToShop && i.baseItem.BaseType.Type == beltColumn)
                            .OrderByDescending(i => i.baseItem.Type)
                            .FirstOrDefault();

                        if (shopItem == null)
                            break;

                        uint itemCost = (uint)shopItem.GetItemCost(0, 2, 0, this.updateQuestInfo, new List<ItemAction>());
                        base.SendPacket(new BuyItem
                        {
                            DealerIdD2R = vendorNPC.Id,
                            CostD2R = itemCost,
                            ItemId = shopItem.Id,
                            VendorX = (ushort)shopItem.x,
                            VendorY = (ushort)shopItem.y,
                            VendorPage = (byte)(shopItem.container - ItemContainer.Inventory),
                            Container = ItemDestination.Belt,
                            X = (ushort)(itemsInColumn * 4 + column)
                        }, p => p is WorldItemAction);
                    } while (itemsInColumn < beltColumns);
                }
            }
        }

        // Token: 0x0600BF19 RID: 48921 RVA: 0x00499308 File Offset: 0x00497508
        public void GoToTpArea(ActLocation act = ActLocation.None)
		{
			bool flag = act == ActLocation.None;
			if (flag)
			{
				act = ActLocationHelper.GetAct(base.GetCurrentLevel());
			}
			this.TakeWaypoint(AreaLevelHelper.GetWpFromArea(AreaLevelHelper.GetTownLevel(act)), true, true);
			Point point = default(Point);
			bool flag2 = act == ActLocation.Act1;
			if (flag2)
			{
				point = new Point(this.Random.Next(14, 33), this.Random.Next(25, 39));
			}
			else
			{
				bool flag3 = act == ActLocation.Act2;
				if (flag3)
				{
					point = new Point(this.Random.Next(57, 70), this.Random.Next(-24, -10));
				}
				else
				{
					bool flag4 = act == ActLocation.Act3;
					if (flag4)
					{
						point = new Point(this.Random.Next(57, 70), this.Random.Next(-24, -10));
					}
					else
					{
						bool flag5 = act == ActLocation.Act4;
						if (flag5)
						{
							point = new Point(this.Random.Next(57, 70), this.Random.Next(-24, -10));
						}
						else
						{
							bool flag6 = act == ActLocation.Act5;
							if (flag6)
							{
								point = new Point(this.Random.Next(57, 70), this.Random.Next(-24, -10));
							}
						}
					}
				}
			}
			PresetUnit presetUnit = this.GameInstance.LevelData[base.GetCurrentLevel()].Units.First((PresetUnit u) => u.CastedGameObject == GameObjectID.Bank);
			this.PatherMoveTo((long)((ulong)presetUnit.X + (ulong)((long)point.X)), (long)((ulong)presetUnit.Y + (ulong)((long)point.Y)), false, 2f);
		}

		// Token: 0x040091C9 RID: 37321
		private Dictionary<Game.PotType, ItemKind> potType = new Dictionary<Game.PotType, ItemKind>
		{
			{
				Game.PotType.Health,
				ItemKind.HealingPotion
			},
			{
				Game.PotType.Mana,
				ItemKind.ManaPotion
			},
			{
				Game.PotType.Rejuv,
				ItemKind.RejuvenationPotion
			},
			{
				Game.PotType.MercHealth,
				ItemKind.HealingPotion
			},
			{
				Game.PotType.MercRejuv,
				ItemKind.RejuvenationPotion
			}
		};

		// Token: 0x040091CA RID: 37322
		private Dictionary<Game.PotType, int> potDelay = new Dictionary<Game.PotType, int>
		{
			{
				Game.PotType.Health,
				1000
			},
			{
				Game.PotType.Mana,
				1000
			},
			{
				Game.PotType.Rejuv,
				500
			},
			{
				Game.PotType.MercHealth,
				5000
			},
			{
				Game.PotType.MercRejuv,
				2000
			}
		};

		// Token: 0x040091CB RID: 37323
		private Dictionary<Game.PotType, int> timerLastDrink = new Dictionary<Game.PotType, int>
		{
			{
				Game.PotType.Health,
				0
			},
			{
				Game.PotType.Mana,
				0
			},
			{
				Game.PotType.Rejuv,
				0
			},
			{
				Game.PotType.MercHealth,
				0
			},
			{
				Game.PotType.MercRejuv,
				0
			}
		};

		// Token: 0x040091CC RID: 37324
		private CancellationTokenSource cts = new CancellationTokenSource();

		// Token: 0x040091CD RID: 37325
		private int TargetX = 0;

		// Token: 0x040091CE RID: 37326
		private int TargetY = 0;

		// Token: 0x040091CF RID: 37327
		private DataTable dt = new DataTable();

		// Token: 0x040091D0 RID: 37328
		private List<Game.PickIt> pickItFilter = new List<Game.PickIt>();

		// Token: 0x040091D1 RID: 37329
		public int party = 0;

		// Token: 0x020013E5 RID: 5093
		private enum PotType
		{
			// Token: 0x0400A0A2 RID: 41122
			Health,
			// Token: 0x0400A0A3 RID: 41123
			Mana,
			// Token: 0x0400A0A4 RID: 41124
			Rejuv,
			// Token: 0x0400A0A5 RID: 41125
			MercHealth,
			// Token: 0x0400A0A6 RID: 41126
			MercRejuv
		}

		// Token: 0x020013E6 RID: 5094
		private class PickIt
		{
			// Token: 0x0400A0A7 RID: 41127
			public string File;

			// Token: 0x0400A0A8 RID: 41128
			public int LineNumber;

			// Token: 0x0400A0A9 RID: 41129
			public string OriginalLine;

			// Token: 0x0400A0AA RID: 41130
			public string Properties;

			// Token: 0x0400A0AB RID: 41131
			public string Stats;

			// Token: 0x0400A0AC RID: 41132
			public string MaxQuantity;

			// Token: 0x0400A0AD RID: 41133
			public string Tier;

			// Token: 0x0400A0AE RID: 41134
			public string MercTier;
		}
	}
}
