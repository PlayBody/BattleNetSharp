using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200044A RID: 1098
	public enum PrivacyLevel
	{
		// Token: 0x04003190 RID: 12688
		[OriginalName("PRIVACY_LEVEL_CLOSED")]
		Closed,
		// Token: 0x04003191 RID: 12689
		[OriginalName("PRIVACY_LEVEL_OPEN_INVITATION")]
		OpenInvitation,
		// Token: 0x04003192 RID: 12690
		[OriginalName("PRIVACY_LEVEL_OPEN_TICKET")]
		OpenTicket,
		// Token: 0x04003193 RID: 12691
		[OriginalName("PRIVACY_LEVEL_OPEN")]
		Open
	}
}
