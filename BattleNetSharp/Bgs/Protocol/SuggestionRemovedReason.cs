using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x0200037F RID: 895
	public enum SuggestionRemovedReason
	{
		// Token: 0x04002992 RID: 10642
		[OriginalName("SUGGESTION_REMOVED_REASON_APPROVED")]
		Approved,
		// Token: 0x04002993 RID: 10643
		[OriginalName("SUGGESTION_REMOVED_REASON_DECLINED")]
		Declined,
		// Token: 0x04002994 RID: 10644
		[OriginalName("SUGGESTION_REMOVED_REASON_EXPIRED")]
		Expired,
		// Token: 0x04002995 RID: 10645
		[OriginalName("SUGGESTION_REMOVED_REASON_CANCELED")]
		Canceled
	}
}
