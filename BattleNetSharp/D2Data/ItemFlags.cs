using System;

namespace D2Data
{
	// Token: 0x02000948 RID: 2376
	[Flags]
	public enum ItemFlags : uint
	{
		// Token: 0x0400723B RID: 29243
		None = 0U,
		// Token: 0x0400723C RID: 29244
		Equipped = 1U,
		// Token: 0x0400723D RID: 29245
		Bought = 2U,
		// Token: 0x0400723E RID: 29246
		Cursor = 4U,
		// Token: 0x0400723F RID: 29247
		InSocket = 8U,
		// Token: 0x04007240 RID: 29248
		Identified = 16U,
		// Token: 0x04007241 RID: 29249
		Destroyed = 32U,
		// Token: 0x04007242 RID: 29250
		SwitchedIn = 64U,
		// Token: 0x04007243 RID: 29251
		SwitchedOut = 128U,
		// Token: 0x04007244 RID: 29252
		Broken = 256U,
		// Token: 0x04007245 RID: 29253
		Restored = 512U,
		// Token: 0x04007246 RID: 29254
		Duplicate = 1024U,
		// Token: 0x04007247 RID: 29255
		Socketed = 2048U,
		// Token: 0x04007248 RID: 29256
		OnPet = 4096U,
		// Token: 0x04007249 RID: 29257
		EquippedD2R = 8192U,
		// Token: 0x0400724A RID: 29258
		InStore = 8192U,
		// Token: 0x0400724B RID: 29259
		Disabled = 16384U,
		// Token: 0x0400724C RID: 29260
		Hardcore = 32768U,
		// Token: 0x0400724D RID: 29261
		Ear = 65536U,
		// Token: 0x0400724E RID: 29262
		StartItem = 131072U,
		// Token: 0x0400724F RID: 29263
		Restrict = 262144U,
		// Token: 0x04007250 RID: 29264
		Server = 524288U,
		// Token: 0x04007251 RID: 29265
		Compact = 2097152U,
		// Token: 0x04007252 RID: 29266
		Ethereal = 4194304U,
		// Token: 0x04007253 RID: 29267
		Any = 8388608U,
		// Token: 0x04007254 RID: 29268
		Personalized = 16777216U,
		// Token: 0x04007255 RID: 29269
		Gamble = 33554432U,
		// Token: 0x04007256 RID: 29270
		Runeword = 67108864U,
		// Token: 0x04007257 RID: 29271
		Magical = 134217728U
	}
}
