using System;

namespace D2Data
{
	// Token: 0x0200095F RID: 2399
	[Flags]
	public enum PlayerRelationshipType : ushort
	{
		// Token: 0x04007EDF RID: 32479
		None = 0,
		// Token: 0x04007EE0 RID: 32480
		Loot = 1,
		// Token: 0x04007EE1 RID: 32481
		Mute = 2,
		// Token: 0x04007EE2 RID: 32482
		Squelch = 4,
		// Token: 0x04007EE3 RID: 32483
		Hostile = 8
	}
}
