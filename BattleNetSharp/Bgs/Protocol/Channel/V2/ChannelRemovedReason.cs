using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x0200065A RID: 1626
	public enum ChannelRemovedReason
	{
		// Token: 0x0400442A RID: 17450
		[OriginalName("CHANNEL_REMOVED_REASON_MEMBER_LEFT")]
		MemberLeft,
		// Token: 0x0400442B RID: 17451
		[OriginalName("CHANNEL_REMOVED_REASON_MEMBER_KICKED")]
		MemberKicked,
		// Token: 0x0400442C RID: 17452
		[OriginalName("CHANNEL_REMOVED_REASON_DISSOLVED_BY_MEMBER")]
		DissolvedByMember,
		// Token: 0x0400442D RID: 17453
		[OriginalName("CHANNEL_REMOVED_REASON_MEMBER_DISCONNECTED")]
		MemberDisconnected,
		// Token: 0x0400442E RID: 17454
		[OriginalName("CHANNEL_REMOVED_REASON_MEMBER_REMOVED_BY_SERVICE")]
		MemberRemovedByService,
		// Token: 0x0400442F RID: 17455
		[OriginalName("CHANNEL_REMOVED_REASON_DISSOLVED_BY_SERVICE")]
		DissolvedByService,
		// Token: 0x04004430 RID: 17456
		[OriginalName("CHANNEL_REMOVED_REASON_DISCONNECTED")]
		Disconnected,
		// Token: 0x04004431 RID: 17457
		[OriginalName("CHANNEL_REMOVED_REASON_FOUNDER_LEFT")]
		FounderLeft = 14
	}
}
