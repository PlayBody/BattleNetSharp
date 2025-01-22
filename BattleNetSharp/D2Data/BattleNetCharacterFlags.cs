using System;

namespace D2Data
{
	// Token: 0x02000923 RID: 2339
	[Flags]
	public enum BattleNetCharacterFlags : uint
	{
		// Token: 0x04006EAC RID: 28332
		BlizzardRepresentative = 1U,
		// Token: 0x04006EAD RID: 28333
		ChannelOperator = 2U,
		// Token: 0x04006EAE RID: 28334
		Speaker = 4U,
		// Token: 0x04006EAF RID: 28335
		BattleNetAdministrator = 8U,
		// Token: 0x04006EB0 RID: 28336
		NoUDPSupport = 16U,
		// Token: 0x04006EB1 RID: 28337
		Squelched = 32U,
		// Token: 0x04006EB2 RID: 28338
		SpecialGuest = 64U,
		// Token: 0x04006EB3 RID: 28339
		PGLOfficial = 1024U,
		// Token: 0x04006EB4 RID: 28340
		WCGOfficial = 4096U,
		// Token: 0x04006EB5 RID: 28341
		KBKSingles = 8192U,
		// Token: 0x04006EB6 RID: 28342
		KBKPlayer = 32768U,
		// Token: 0x04006EB7 RID: 28343
		KBKBeginner = 65536U,
		// Token: 0x04006EB8 RID: 28344
		WhiteKBK = 131072U,
		// Token: 0x04006EB9 RID: 28345
		GameRoom = 262144U,
		// Token: 0x04006EBA RID: 28346
		GFOfficial = 1048576U,
		// Token: 0x04006EBB RID: 28347
		GFPlayer = 2097152U,
		// Token: 0x04006EBC RID: 28348
		PGLPlayer = 33554432U
	}
}
