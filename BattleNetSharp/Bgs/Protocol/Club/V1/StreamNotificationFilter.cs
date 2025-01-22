using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000451 RID: 1105
	public enum StreamNotificationFilter
	{
		// Token: 0x040031AF RID: 12719
		[OriginalName("STREAM_NOTIFICATION_FILTER_NONE")]
		None,
		// Token: 0x040031B0 RID: 12720
		[OriginalName("STREAM_NOTIFICATION_FILTER_MENTION")]
		Mention,
		// Token: 0x040031B1 RID: 12721
		[OriginalName("STREAM_NOTIFICATION_FILTER_ALL")]
		All
	}
}
