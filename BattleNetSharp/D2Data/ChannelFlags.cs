using System;

namespace D2Data
{
	// Token: 0x02000927 RID: 2343
	[Flags]
	public enum ChannelFlags
	{
		// Token: 0x04006ED4 RID: 28372
		PublicChannel = 1,
		// Token: 0x04006ED5 RID: 28373
		Moderated = 2,
		// Token: 0x04006ED6 RID: 28374
		Restricted = 4,
		// Token: 0x04006ED7 RID: 28375
		Silent = 8,
		// Token: 0x04006ED8 RID: 28376
		System = 16,
		// Token: 0x04006ED9 RID: 28377
		ProductSpecific = 32,
		// Token: 0x04006EDA RID: 28378
		GloballyAccessible = 4096
	}
}
