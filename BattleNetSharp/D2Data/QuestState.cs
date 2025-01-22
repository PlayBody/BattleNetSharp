using System;

namespace D2Data
{
	// Token: 0x02000962 RID: 2402
	[Flags]
	public enum QuestState : byte
	{
		// Token: 0x04007EF0 RID: 32496
		Event1 = 1,
		// Token: 0x04007EF1 RID: 32497
		Event2 = 2,
		// Token: 0x04007EF2 RID: 32498
		Event4 = 4,
		// Token: 0x04007EF3 RID: 32499
		Event8 = 8,
		// Token: 0x04007EF4 RID: 32500
		Active = 16,
		// Token: 0x04007EF5 RID: 32501
		Enabled = 32,
		// Token: 0x04007EF6 RID: 32502
		Unknown0x40 = 64,
		// Token: 0x04007EF7 RID: 32503
		FromNPC = 128
	}
}
