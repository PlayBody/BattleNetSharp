using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000378 RID: 888
	public enum ClientIdentityRoutingType
	{
		// Token: 0x04002958 RID: 10584
		[OriginalName("CLIENT_IDENTITY_ROUTING_DISABLED")]
		ClientIdentityRoutingDisabled,
		// Token: 0x04002959 RID: 10585
		[OriginalName("CLIENT_IDENTITY_ROUTING_BATTLE_NET_ACCOUNT")]
		ClientIdentityRoutingBattleNetAccount,
		// Token: 0x0400295A RID: 10586
		[OriginalName("CLIENT_IDENTITY_ROUTING_GAME_ACCOUNT")]
		ClientIdentityRoutingGameAccount,
		// Token: 0x0400295B RID: 10587
		[OriginalName("CLIENT_IDENTITY_ROUTING_INSTANCE_ID")]
		ClientIdentityRoutingInstanceId
	}
}
