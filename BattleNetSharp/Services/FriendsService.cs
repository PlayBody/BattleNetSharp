using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.Friends.V1;
using Grpc.Core;

namespace BattleNetSharp.Services
{
	// Token: 0x02000AF7 RID: 2807
	public class FriendsService : Bgs.Protocol.Friends.V1.FriendsService.FriendsServiceBase, IServiceListener
	{
		// Token: 0x0600BD99 RID: 48537 RVA: 0x00486B9C File Offset: 0x00484D9C
		public override Task<NoData> AcceptInvitation(AcceptInvitationRequest request, ServerCallContext context)
		{
			return base.AcceptInvitation(request, context);
		}

		// Token: 0x0600BD9A RID: 48538 RVA: 0x00486BB8 File Offset: 0x00484DB8
		public override Task<NoData> CreateFriendship(CreateFriendshipRequest request, ServerCallContext context)
		{
			return base.CreateFriendship(request, context);
		}

		// Token: 0x0600BD9B RID: 48539 RVA: 0x00486BD4 File Offset: 0x00484DD4
		public override Task<NoData> DeclineInvitation(DeclineInvitationRequest request, ServerCallContext context)
		{
			return base.DeclineInvitation(request, context);
		}

		// Token: 0x0600BD9C RID: 48540 RVA: 0x00486BF0 File Offset: 0x00484DF0
		public override Task<GetFriendListResponse> GetFriendList(GetFriendListRequest request, ServerCallContext context)
		{
			return base.GetFriendList(request, context);
		}

		// Token: 0x0600BD9D RID: 48541 RVA: 0x00486C0C File Offset: 0x00484E0C
		public override Task<NoData> IgnoreInvitation(IgnoreInvitationRequest request, ServerCallContext context)
		{
			return base.IgnoreInvitation(request, context);
		}

		// Token: 0x0600BD9E RID: 48542 RVA: 0x00486C28 File Offset: 0x00484E28
		public override Task<NoData> RemoveFriend(RemoveFriendRequest request, ServerCallContext context)
		{
			return base.RemoveFriend(request, context);
		}

		// Token: 0x0600BD9F RID: 48543 RVA: 0x00486C44 File Offset: 0x00484E44
		public override Task<NoData> RevokeAllInvitations(RevokeAllInvitationsRequest request, ServerCallContext context)
		{
			return base.RevokeAllInvitations(request, context);
		}

		// Token: 0x0600BDA0 RID: 48544 RVA: 0x00486C60 File Offset: 0x00484E60
		public override Task<NoData> RevokeInvitation(RevokeInvitationRequest request, ServerCallContext context)
		{
			return base.RevokeInvitation(request, context);
		}

		// Token: 0x0600BDA1 RID: 48545 RVA: 0x00486C7C File Offset: 0x00484E7C
		public override Task<NoData> SendInvitation(SendInvitationRequest request, ServerCallContext context)
		{
			return base.SendInvitation(request, context);
		}

		// Token: 0x0600BDA2 RID: 48546 RVA: 0x00486C98 File Offset: 0x00484E98
		public override Task<SubscribeResponse> Subscribe(SubscribeRequest request, ServerCallContext context)
		{
			SubscribeResponse subscribeResponse = new SubscribeResponse
			{
				MaxFriends = 200U,
				MaxReceivedInvitations = 200U,
				MaxSentInvitations = 200U
			};
			subscribeResponse.Role.Add(new Role
			{
				Id = 1U,
				Name = "battle_tag_friend"
			});
			subscribeResponse.Role.Add(new Role
			{
				Id = 2U,
				Name = "real_id_friend"
			});
			return Task.FromResult<SubscribeResponse>(subscribeResponse);
		}

		// Token: 0x0600BDA3 RID: 48547 RVA: 0x00486D24 File Offset: 0x00484F24
		public override Task<NoData> Unsubscribe(UnsubscribeRequest request, ServerCallContext context)
		{
			return base.Unsubscribe(request, context);
		}

		// Token: 0x0600BDA4 RID: 48548 RVA: 0x00486D40 File Offset: 0x00484F40
		public override Task<NoData> UpdateFriendState(UpdateFriendStateRequest request, ServerCallContext context)
		{
			return base.UpdateFriendState(request, context);
		}

		// Token: 0x0600BDA5 RID: 48549 RVA: 0x00486D5C File Offset: 0x00484F5C
		public override Task<ViewFriendsResponse> ViewFriends(ViewFriendsRequest request, ServerCallContext context)
		{
			return base.ViewFriends(request, context);
		}
	}
}
