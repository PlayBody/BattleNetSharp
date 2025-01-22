using System;
using System.Collections.Generic;
using System.Linq;
using D2Data;
using D2Packets.Game.Server;

namespace D2GameState
{
	// Token: 0x0200090C RID: 2316
	public class Player
	{
		// Token: 0x04006A97 RID: 27287
		public uint Id;

		// Token: 0x04006A98 RID: 27288
		public string Name = "";

		// Token: 0x04006A99 RID: 27289
		public CharacterClass Class = CharacterClass.Invalid;

		// Token: 0x04006A9A RID: 27290
		public ushort Life = ushort.MaxValue;

		// Token: 0x04006A9B RID: 27291
		public ushort Mana = ushort.MaxValue;

		// Token: 0x04006A9C RID: 27292
		public ushort X = ushort.MaxValue;

		// Token: 0x04006A9D RID: 27293
		public ushort Y = ushort.MaxValue;

		// Token: 0x04006A9E RID: 27294
		public ushort Stamina = ushort.MaxValue;

		// Token: 0x04006A9F RID: 27295
		public Dictionary<EquipmentLocation, ItemAction> Equipment = new List<EquipmentLocation>((EquipmentLocation[])Enum.GetValues(typeof(EquipmentLocation))).Select((EquipmentLocation e) => new
		{
			Key = e,
			Value = new ItemAction
			{
				Id = uint.MaxValue
			}
		}).ToDictionary(o => o.Key, o => o.Value);

		// Token: 0x04006AA0 RID: 27296
		public List<ItemAction> Inventory = new List<ItemAction>();

		// Token: 0x04006AA1 RID: 27297
		public ushort Party = ushort.MaxValue;

		// Token: 0x04006AA2 RID: 27298
		public AreaLevel Area = AreaLevel.Invalid;

		// Token: 0x04006AA3 RID: 27299
		public WaypointsAvailable WaypointsUnlocked = WaypointsAvailable.None;

		// Token: 0x04006AA4 RID: 27300
		public UpdateQuestStatus QuestStatus = new UpdateQuestStatus();

		// Token: 0x04006AA5 RID: 27301
		public SkillType RightHandSkill;

		// Token: 0x04006AA6 RID: 27302
		public SkillType LeftHandSkill;

		// Token: 0x04006AA7 RID: 27303
		public SkillType RightHandSkillSwap;

		// Token: 0x04006AA8 RID: 27304
		public SkillType LeftHandSkillSwap;

		// Token: 0x04006AA9 RID: 27305
		public bool WeaponSwitched = false;

		// Token: 0x04006AAA RID: 27306
		public Dictionary<StatType, uint> Attributes = new Dictionary<StatType, uint>();

		// Token: 0x04006AAB RID: 27307
		public List<StatBase> Stats = new List<StatBase>();

		// Token: 0x04006AAC RID: 27308
		public float ClientX = float.MaxValue;

		// Token: 0x04006AAD RID: 27309
		public float ClientY = float.MaxValue;

		// Token: 0x04006AAE RID: 27310
		public float TargetX = float.MaxValue;

		// Token: 0x04006AAF RID: 27311
		public float TargetY = float.MaxValue;

		// Token: 0x04006AB0 RID: 27312
		public Player.Mode State = Player.Mode.TownNeutral;

		// Token: 0x04006AB1 RID: 27313
		public Player.StateManager States = new Player.StateManager();

		// Token: 0x02001318 RID: 4888
		public enum Mode
		{
			// Token: 0x04009D49 RID: 40265
			Death,
			// Token: 0x04009D4A RID: 40266
			Neutral,
			// Token: 0x04009D4B RID: 40267
			Walk,
			// Token: 0x04009D4C RID: 40268
			Run,
			// Token: 0x04009D4D RID: 40269
			GetHit,
			// Token: 0x04009D4E RID: 40270
			TownNeutral,
			// Token: 0x04009D4F RID: 40271
			TownWalk,
			// Token: 0x04009D50 RID: 40272
			Attack1,
			// Token: 0x04009D51 RID: 40273
			Attack2,
			// Token: 0x04009D52 RID: 40274
			Block,
			// Token: 0x04009D53 RID: 40275
			Cast,
			// Token: 0x04009D54 RID: 40276
			Throw,
			// Token: 0x04009D55 RID: 40277
			Kick,
			// Token: 0x04009D56 RID: 40278
			Skill1,
			// Token: 0x04009D57 RID: 40279
			Skill2,
			// Token: 0x04009D58 RID: 40280
			Skill3,
			// Token: 0x04009D59 RID: 40281
			Skill4,
			// Token: 0x04009D5A RID: 40282
			Dead
		}

		// Token: 0x02001319 RID: 4889
		public class StateManager
		{
			// Token: 0x17003970 RID: 14704
			public bool this[StateType Skill]
			{
				get
				{
					return this.States.Count((StateType s) => s == Skill) > 0;
				}
				set
				{
					bool flag = this.States.Count((StateType s) => s == Skill) == 0;
					if (flag)
					{
						this.States.Add(Skill);
					}
				}
			}

			// Token: 0x04009D5B RID: 40283
			public List<StateType> States = new List<StateType>();
		}
	}
}
