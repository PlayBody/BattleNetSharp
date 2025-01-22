using System;

namespace D2Data
{
	// Token: 0x02000947 RID: 2375
	[Flags]
	public enum ItemEventType : uint
	{
		// Token: 0x04007230 RID: 29232
		None = 0U,
		// Token: 0x04007231 RID: 29233
		DoMeleeAttack = 1U,
		// Token: 0x04007232 RID: 29234
		DoMissileAttack = 2U,
		// Token: 0x04007233 RID: 29235
		DoMeleeDamage = 4U,
		// Token: 0x04007234 RID: 29236
		DoMissileDamage = 8U,
		// Token: 0x04007235 RID: 29237
		Kill = 16U,
		// Token: 0x04007236 RID: 29238
		DamagedInMelee = 32U,
		// Token: 0x04007237 RID: 29239
		DamagedByMissile = 64U,
		// Token: 0x04007238 RID: 29240
		Death = 128U,
		// Token: 0x04007239 RID: 29241
		LevelUp = 256U
	}
}
