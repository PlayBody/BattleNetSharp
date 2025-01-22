using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000452 RID: 1106
	public enum JoinClubSource
	{
		// Token: 0x040031B3 RID: 12723
		[OriginalName("JOIN_CLUB_SOURCE_NONE")]
		None,
		// Token: 0x040031B4 RID: 12724
		[OriginalName("JOIN_CLUB_SOURCE_CLUB_FINDER")]
		ClubFinder,
		// Token: 0x040031B5 RID: 12725
		[OriginalName("JOIN_CLUB_SOURCE_CLUB_RECOMMENDATION")]
		ClubRecommendation
	}
}
