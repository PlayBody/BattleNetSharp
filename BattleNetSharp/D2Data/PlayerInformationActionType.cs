using System;

namespace D2Data
{
	// Token: 0x0200095D RID: 2397
	[Flags]
	public enum PlayerInformationActionType : byte
	{
		// Token: 0x04007ECD RID: 32461
		Neutral = 0,
		// Token: 0x04007ECE RID: 32462
		Party = 2,
		// Token: 0x04007ECF RID: 32463
		Friendly = 4,
		// Token: 0x04007ED0 RID: 32464
		UnFriendly = 8,
		// Token: 0x04007ED1 RID: 32465
		Remove = 1,
		// Token: 0x04007ED2 RID: 32466
		None = 128
	}
}
