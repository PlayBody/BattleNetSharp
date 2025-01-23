using System;
using System.Threading.Tasks;
using Bgs.Protocol.Sns.V1;
using Grpc.Core;

namespace BattleNetSharp
{
	// Token: 0x02000AE4 RID: 2788
	public class SocialNetworkListener : Bgs.Protocol.Sns.V1.SocialNetworkListener.SocialNetworkListenerBase, IServiceListener
	{
		// Token: 0x0600BCF7 RID: 48375 RVA: 0x00484274 File Offset: 0x00482474
		public override Task<FacebookBnetFriendListNotificationResponse> OnFacebookBnetFriendListReceived(FacebookBnetFriendListNotification request, ServerCallContext context)
		{
			return base.OnFacebookBnetFriendListReceived(request, context);
		}
	}
}
