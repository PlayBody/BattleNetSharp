using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000659 RID: 1625
	public enum PrivacyLevel
	{
		// Token: 0x04004426 RID: 17446
		[OriginalName("PRIVACY_LEVEL_OPEN")]
		Open = 1,
		// Token: 0x04004427 RID: 17447
		[OriginalName("PRIVACY_LEVEL_OPEN_INVITATION")]
		OpenInvitation = 3,
		// Token: 0x04004428 RID: 17448
		[OriginalName("PRIVACY_LEVEL_CLOSED")]
		Closed
	}
}
