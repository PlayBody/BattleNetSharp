using System;

namespace D4Packets.Game.Client
{
	// Token: 0x02000897 RID: 2199
	public class HeroStateData : D4Packet
	{
		// Token: 0x04006479 RID: 25721
		public uint PlayerFlags;

		// Token: 0x0400647A RID: 25722
		public HeroStateCustomization CustomizeData;

		// Token: 0x0400647B RID: 25723
		public PlayerSavedData SavedData;

		// Token: 0x0400647C RID: 25724
		public TownPortalReturnDest TownPortalReturn;

		// Token: 0x0400647D RID: 25725
		[DynamicLen(10)]
		public int[] CompletedQuests;

		// Token: 0x0400647E RID: 25726
		[DynamicLen(10)]
		public int[] RevealedFogs;

		// Token: 0x0400647F RID: 25727
		[DynamicLen(7)]
		public Type93828AE3[] Field6;

		// Token: 0x04006480 RID: 25728
		[DynamicLen(8)]
		public Type93828AE3[] Field7;

		// Token: 0x04006481 RID: 25729
		public RequiredMessageHeader TSSTOCHeader;

		// Token: 0x04006482 RID: 25730
		public TutorialSendSeenToClient Tutorials;

		// Token: 0x04006483 RID: 25731
		public VariableInfo DesignerVariables;

		// Token: 0x04006484 RID: 25732
		[DynamicLen(10)]
		public int[] snoPhysics;

		// Token: 0x04006485 RID: 25733
		[DynamicLen(3)]
		public ZoneProgress[] ZoneProgressData;
	}
}
