using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x0200072E RID: 1838
	public enum IdentityVerificationStatus
	{
		// Token: 0x04004B93 RID: 19347
		[OriginalName("IDENT_NO_DATA")]
		IdentNoData,
		// Token: 0x04004B94 RID: 19348
		[OriginalName("IDENT_PENDING")]
		IdentPending,
		// Token: 0x04004B95 RID: 19349
		[OriginalName("IDENT_OVER_18")]
		IdentOver18,
		// Token: 0x04004B96 RID: 19350
		[OriginalName("IDENT_UNDER_18")]
		IdentUnder18,
		// Token: 0x04004B97 RID: 19351
		[OriginalName("IDENT_FAILED")]
		IdentFailed,
		// Token: 0x04004B98 RID: 19352
		[OriginalName("IDENT_SUCCESS")]
		IdentSuccess,
		// Token: 0x04004B99 RID: 19353
		[OriginalName("IDENT_SUCC_MNL")]
		IdentSuccMnl,
		// Token: 0x04004B9A RID: 19354
		[OriginalName("IDENT_UNKNOWN")]
		IdentUnknown
	}
}
