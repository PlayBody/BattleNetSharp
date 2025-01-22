using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200044C RID: 1100
	public enum ClubRemovedReason
	{
		// Token: 0x04003198 RID: 12696
		[OriginalName("CLUB_REMOVED_REASON_NONE")]
		None,
		// Token: 0x04003199 RID: 12697
		[OriginalName("CLUB_REMOVED_REASON_MEMBER_LEFT")]
		MemberLeft,
		// Token: 0x0400319A RID: 12698
		[OriginalName("CLUB_REMOVED_REASON_MEMBER_KICKED")]
		MemberKicked,
		// Token: 0x0400319B RID: 12699
		[OriginalName("CLUB_REMOVED_REASON_MEMBER_BANNED")]
		MemberBanned,
		// Token: 0x0400319C RID: 12700
		[OriginalName("CLUB_REMOVED_REASON_MEMBER_REMOVED_BY_SERVICE")]
		MemberRemovedByService,
		// Token: 0x0400319D RID: 12701
		[OriginalName("CLUB_REMOVED_REASON_DESTROYED_BY_MEMBER")]
		DestroyedByMember,
		// Token: 0x0400319E RID: 12702
		[OriginalName("CLUB_REMOVED_REASON_DESTROYED_BY_SERVICE")]
		DestroyedByService
	}
}
