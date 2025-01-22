using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.Club.V1.Membership;
using Grpc.Core;

namespace BattleNetSharp.Services
{
	// Token: 0x02000AF6 RID: 2806
	public class ClubMembershipService : ClubMembershipService.ClubMembershipServiceBase, IServiceListener
	{
		// Token: 0x0600BD91 RID: 48529 RVA: 0x00486AD0 File Offset: 0x00484CD0
		public override Task<NoData> AdvanceStreamMentionViewTime(AdvanceStreamMentionViewTimeRequest request, ServerCallContext context)
		{
			return base.AdvanceStreamMentionViewTime(request, context);
		}

		// Token: 0x0600BD92 RID: 48530 RVA: 0x00486AEC File Offset: 0x00484CEC
		public override Task<GetStateResponse> GetState(GetStateRequest request, ServerCallContext context)
		{
			return base.GetState(request, context);
		}

		// Token: 0x0600BD93 RID: 48531 RVA: 0x00486B08 File Offset: 0x00484D08
		public override Task<GetStreamMentionsResponse> GetStreamMentions(GetStreamMentionsRequest request, ServerCallContext context)
		{
			return base.GetStreamMentions(request, context);
		}

		// Token: 0x0600BD94 RID: 48532 RVA: 0x00486B24 File Offset: 0x00484D24
		public override Task<NoData> RemoveStreamMentions(RemoveStreamMentionsRequest request, ServerCallContext context)
		{
			return base.RemoveStreamMentions(request, context);
		}

		// Token: 0x0600BD95 RID: 48533 RVA: 0x00486B40 File Offset: 0x00484D40
		public override Task<SubscribeResponse> Subscribe(SubscribeRequest request, ServerCallContext context)
		{
			return Task.FromResult<SubscribeResponse>(new SubscribeResponse());
		}

		// Token: 0x0600BD96 RID: 48534 RVA: 0x00486B5C File Offset: 0x00484D5C
		public override Task<NoData> Unsubscribe(UnsubscribeRequest request, ServerCallContext context)
		{
			return base.Unsubscribe(request, context);
		}

		// Token: 0x0600BD97 RID: 48535 RVA: 0x00486B78 File Offset: 0x00484D78
		public override Task<NoData> UpdateClubSharedSettings(UpdateClubSharedSettingsRequest request, ServerCallContext context)
		{
			return base.UpdateClubSharedSettings(request, context);
		}
	}
}
