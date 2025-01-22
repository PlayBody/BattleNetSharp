using System;

namespace D2Data
{
	// Token: 0x02000961 RID: 2401
	[Flags]
	public enum QuestStanding : byte
	{
		// Token: 0x04007EE7 RID: 32487
		Complete = 1,
		// Token: 0x04007EE8 RID: 32488
		RewardPending = 2,
		// Token: 0x04007EE9 RID: 32489
		Started = 4,
		// Token: 0x04007EEA RID: 32490
		LeftTownWhileStarted = 8,
		// Token: 0x04007EEB RID: 32491
		EnteredFirstArea = 16,
		// Token: 0x04007EEC RID: 32492
		Event0x20 = 32,
		// Token: 0x04007EED RID: 32493
		Event0x40 = 64,
		// Token: 0x04007EEE RID: 32494
		Event0x80 = 128
	}
}
