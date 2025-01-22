using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x0200037E RID: 894
	public enum InvitationRemovedReason
	{
		// Token: 0x0400298B RID: 10635
		[OriginalName("INVITATION_REMOVED_REASON_ACCEPTED")]
		Accepted,
		// Token: 0x0400298C RID: 10636
		[OriginalName("INVITATION_REMOVED_REASON_DECLINED")]
		Declined,
		// Token: 0x0400298D RID: 10637
		[OriginalName("INVITATION_REMOVED_REASON_REVOKED")]
		Revoked,
		// Token: 0x0400298E RID: 10638
		[OriginalName("INVITATION_REMOVED_REASON_IGNORED")]
		Ignored,
		// Token: 0x0400298F RID: 10639
		[OriginalName("INVITATION_REMOVED_REASON_EXPIRED")]
		Expired,
		// Token: 0x04002990 RID: 10640
		[OriginalName("INVITATION_REMOVED_REASON_CANCELED")]
		Canceled
	}
}
