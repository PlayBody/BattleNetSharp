using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.Channel.V2.Membership;
using Grpc.Core;

namespace BattleNetSharp
{
	// Token: 0x02000AE8 RID: 2792
	public class ChannelMembershipService : Bgs.Protocol.Channel.V2.Membership.ChannelMembershipService.ChannelMembershipServiceBase, IServiceListener
	{
		// Token: 0x0600BD0D RID: 48397 RVA: 0x0048495C File Offset: 0x00482B5C
		public override Task<GetStateResponse> GetState(GetStateRequest request, ServerCallContext context)
		{
			return base.GetState(request, context);
		}

		// Token: 0x0600BD0E RID: 48398 RVA: 0x00484978 File Offset: 0x00482B78
		public override Task<SubscribeResponse> Subscribe(SubscribeRequest request, ServerCallContext context)
		{
			return Task.FromResult<SubscribeResponse>(new SubscribeResponse());
		}

		// Token: 0x0600BD0F RID: 48399 RVA: 0x00484994 File Offset: 0x00482B94
		public override Task<NoData> Unsubscribe(UnsubscribeRequest request, ServerCallContext context)
		{
			return base.Unsubscribe(request, context);
		}
	}
}
