using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x02000567 RID: 1383
	public enum SessionDestructionStatusDetails
	{
		// Token: 0x04003C51 RID: 15441
		[OriginalName("ACCOUNT_MUTED")]
		AccountMuted = 1,
		// Token: 0x04003C52 RID: 15442
		[OriginalName("BATTLE_TAG_CHANGED")]
		BattleTagChanged,
		// Token: 0x04003C53 RID: 15443
		[OriginalName("BNET_ACCOUNT_BANNED")]
		BnetAccountBanned,
		// Token: 0x04003C54 RID: 15444
		[OriginalName("BNET_ACCOUNT_FLAG_CHANGED")]
		BnetAccountFlagChanged,
		// Token: 0x04003C55 RID: 15445
		[OriginalName("COUNTRY_CHANGED")]
		CountryChanged,
		// Token: 0x04003C56 RID: 15446
		[OriginalName("CURRENCY_CHANGED")]
		CurrencyChanged,
		// Token: 0x04003C57 RID: 15447
		[OriginalName("GAME_ACCOUNT_UNLINKED")]
		GameAccountUnlinked,
		// Token: 0x04003C58 RID: 15448
		[OriginalName("LEGAL_REGION_CHANGED")]
		LegalRegionChanged,
		// Token: 0x04003C59 RID: 15449
		[OriginalName("LEGAL_LOCALE_CHANGED")]
		LegalLocaleChanged,
		// Token: 0x04003C5A RID: 15450
		[OriginalName("LICENSE_CHANGED")]
		LicenseChanged,
		// Token: 0x04003C5B RID: 15451
		[OriginalName("NAME_CHANGED")]
		NameChanged,
		// Token: 0x04003C5C RID: 15452
		[OriginalName("OPT_IN_CHANGED")]
		OptInChanged,
		// Token: 0x04003C5D RID: 15453
		[OriginalName("REGION_CHANGED")]
		RegionChanged
	}
}
