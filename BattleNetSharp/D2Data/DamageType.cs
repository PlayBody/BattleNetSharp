using System;

namespace D2Data
{
	// Token: 0x02000930 RID: 2352
	[Flags]
	public enum DamageType : byte
	{
		// Token: 0x04006F1C RID: 28444
		None = 0,
		// Token: 0x04006F1D RID: 28445
		Fire = 1,
		// Token: 0x04006F1E RID: 28446
		Lightning = 2,
		// Token: 0x04006F1F RID: 28447
		Cold = 3,
		// Token: 0x04006F20 RID: 28448
		Physical = 4,
		// Token: 0x04006F21 RID: 28449
		Magic = 5,
		// Token: 0x04006F22 RID: 28450
		Poison = 6,
		// Token: 0x04006F23 RID: 28451
		Undead = 7
	}
}
