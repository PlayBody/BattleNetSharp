using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000376 RID: 886
	public enum ClientRegisterMethodType
	{
		// Token: 0x04002952 RID: 10578
		[OriginalName("REGISTER_CLIENT_NONE")]
		RegisterClientNone,
		// Token: 0x04002953 RID: 10579
		[OriginalName("REGISTER_CLIENT_REGISTERED")]
		RegisterClientRegistered,
		// Token: 0x04002954 RID: 10580
		[OriginalName("REGISTER_CLIENT_UNREGISTERED")]
		RegisterClientUnregistered,
		// Token: 0x04002955 RID: 10581
		[OriginalName("REGISTER_CLIENT_UNREGISTERED_NOTIFICATION")]
		RegisterClientUnregisteredNotification
	}
}
