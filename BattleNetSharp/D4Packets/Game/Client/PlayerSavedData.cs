using System;

namespace D4Packets.Game.Client
{
	// Token: 0x0200089E RID: 2206
	public class PlayerSavedData : D4Packet
	{
		// Token: 0x0400649B RID: 25755
		[FixedLen(6U)]
		public HotbarButtonData[] HotBarButtons;

		// Token: 0x0400649C RID: 25756
		public HotbarButtonData PotionButton;

		// Token: 0x0400649D RID: 25757
		public uint SecondsPlayed;

		// Token: 0x0400649E RID: 25758
		public HirelingSavedData HirelingData;

		// Token: 0x0400649F RID: 25759
		[DynamicLen(7)]
		public uint[] WaypointsLevelAreas;

		// Token: 0x040064A0 RID: 25760
		public uint TimeLastLevel;

		// Token: 0x040064A1 RID: 25761
		public LearnedLore LoreData;

		// Token: 0x040064A2 RID: 25762
		[FixedLen(6U)]
		public ActiveSkillSavedData[] ActiveSkills;

		// Token: 0x040064A3 RID: 25763
		[FixedLen(6U)]
		public AnotherSkillSavedData[] AnotherSkills;

		// Token: 0x040064A4 RID: 25764
		public NewSkillSavedData NewSkillsData;

		// Token: 0x040064A5 RID: 25765
		[FixedLen(50U)]
		public SkillRank[] SkillRanks;

		// Token: 0x040064A6 RID: 25766
		[DynamicLen(8)]
		public SkillTreeNodeEntry[] SkillTreeNodeEntrys;

		// Token: 0x040064A7 RID: 25767
		public uint field2;

		// Token: 0x040064A8 RID: 25768
		public bool field3;

		// Token: 0x040064A9 RID: 25769
		[DynamicLen(4)]
		public PSD_FB1F3D4D[] Massive1;

		// Token: 0x040064AA RID: 25770
		[FixedLen(5U)]
		public PSD_90DE2B1E[] Massive2;

		// Token: 0x040064AB RID: 25771
		public PlayerTitleStruct Titles;
	}
}
