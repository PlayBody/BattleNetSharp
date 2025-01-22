using System;

namespace D2Data
{
	// Token: 0x02000931 RID: 2353
	public enum DamageTypes : byte
	{
		// Token: 0x04006F25 RID: 28453
		None,
		// Token: 0x04006F26 RID: 28454
		Fire,
		// Token: 0x04006F27 RID: 28455
		Lightning,
		// Token: 0x04006F28 RID: 28456
		Cold = 4,
		// Token: 0x04006F29 RID: 28457
		Physical = 8,
		// Token: 0x04006F2A RID: 28458
		Magic = 16,
		// Token: 0x04006F2B RID: 28459
		Poison = 32,
		// Token: 0x04006F2C RID: 28460
		Undead = 64
	}
}
