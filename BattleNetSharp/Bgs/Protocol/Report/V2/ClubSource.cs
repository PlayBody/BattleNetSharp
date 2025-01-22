using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Report.V2
{
	// Token: 0x02000587 RID: 1415
	public enum ClubSource
	{
		// Token: 0x04003D6D RID: 15725
		[OriginalName("CLUB_SOURCE_NONE")]
		None,
		// Token: 0x04003D6E RID: 15726
		[OriginalName("CLUB_SOURCE_MESSAGE")]
		Message,
		// Token: 0x04003D6F RID: 15727
		[OriginalName("CLUB_SOURCE_CLUB_NAME")]
		ClubName,
		// Token: 0x04003D70 RID: 15728
		[OriginalName("CLUB_SOURCE_STREAM_NAME")]
		StreamName,
		// Token: 0x04003D71 RID: 15729
		[OriginalName("CLUB_SOURCE_BROADCAST")]
		Broadcast,
		// Token: 0x04003D72 RID: 15730
		[OriginalName("CLUB_SOURCE_CLUB_SHORT_NAME")]
		ClubShortName,
		// Token: 0x04003D73 RID: 15731
		[OriginalName("CLUB_SOURCE_CLUB_DESCRIPTION")]
		ClubDescription,
		// Token: 0x04003D74 RID: 15732
		[OriginalName("CLUB_SOURCE_STREAM_SUBJECT")]
		StreamSubject
	}
}
