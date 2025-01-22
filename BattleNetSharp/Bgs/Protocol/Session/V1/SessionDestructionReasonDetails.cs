using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x0200054B RID: 1355
	public enum SessionDestructionReasonDetails
	{
		// Token: 0x04003B57 RID: 15191
		[OriginalName("ACCOUNT_MUTED")]
		AccountMuted = 1,
		// Token: 0x04003B58 RID: 15192
		[OriginalName("BATTLE_TAG_CHANGED")]
		BattleTagChanged,
		// Token: 0x04003B59 RID: 15193
		[OriginalName("BNET_ACCOUNT_BANNED")]
		BnetAccountBanned,
		// Token: 0x04003B5A RID: 15194
		[OriginalName("BNET_ACCOUNT_FLAG_CHANGED")]
		BnetAccountFlagChanged,
		// Token: 0x04003B5B RID: 15195
		[OriginalName("COUNTRY_CHANGED")]
		CountryChanged,
		// Token: 0x04003B5C RID: 15196
		[OriginalName("CURRENCY_CHANGED")]
		CurrencyChanged,
		// Token: 0x04003B5D RID: 15197
		[OriginalName("GAME_ACCOUNT_UNLINKED")]
		GameAccountUnlinked,
		// Token: 0x04003B5E RID: 15198
		[OriginalName("LEGAL_REGION_CHANGED")]
		LegalRegionChanged,
		// Token: 0x04003B5F RID: 15199
		[OriginalName("LEGAL_LOCALE_CHANGED")]
		LegalLocaleChanged,
		// Token: 0x04003B60 RID: 15200
		[OriginalName("LICENSE_CHANGED")]
		LicenseChanged,
		// Token: 0x04003B61 RID: 15201
		[OriginalName("NAME_CHANGED")]
		NameChanged,
		// Token: 0x04003B62 RID: 15202
		[OriginalName("OPT_IN_CHANGED")]
		OptInChanged,
		// Token: 0x04003B63 RID: 15203
		[OriginalName("REGION_CHANGED")]
		RegionChanged
	}
}
