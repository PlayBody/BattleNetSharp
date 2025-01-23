using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.Account.V1;
using Bgs.Protocol.Channel.V2;
using Bgs.Protocol.Channel.V2.Membership;
using Grpc.Core;

namespace BattleNetSharp
{
	// Token: 0x02000AE9 RID: 2793
	public class ChannelService : Bgs.Protocol.Channel.V2.ChannelService.ChannelServiceBase
	{
		// Token: 0x0600BD11 RID: 48401 RVA: 0x004849B8 File Offset: 0x00482BB8
		public override Task<NoData> AcceptInvitation(AcceptInvitationRequest request, ServerCallContext context)
		{
			return base.AcceptInvitation(request, context);
		}

		// Token: 0x0600BD12 RID: 48402 RVA: 0x004849D4 File Offset: 0x00482BD4
		public override Task<NoData> AssignRole(AssignRoleRequest request, ServerCallContext context)
		{
			return base.AssignRole(request, context);
		}

		// Token: 0x0600BD13 RID: 48403 RVA: 0x004849F0 File Offset: 0x00482BF0
		public override Task<NoData> CreateChannel(CreateChannelRequest request, ServerCallContext context)
		{
			return base.CreateChannel(request, context);
		}

		// Token: 0x0600BD14 RID: 48404 RVA: 0x00484A0C File Offset: 0x00482C0C
		public override Task<NoData> DeclineInvitation(DeclineInvitationRequest request, ServerCallContext context)
		{
			return base.DeclineInvitation(request, context);
		}

		// Token: 0x0600BD15 RID: 48405 RVA: 0x00484A28 File Offset: 0x00482C28
		public override Task<NoData> DissolveChannel(DissolveChannelRequest request, ServerCallContext context)
		{
			return base.DissolveChannel(request, context);
		}

		// Token: 0x0600BD16 RID: 48406 RVA: 0x00484A44 File Offset: 0x00482C44
		public override Task<NoData> FindChannel(FindChannelRequest request, ServerCallContext context)
		{
			GameAccountHandle gameAccountHandle = new GameAccountHandle
			{
				Id = D2RBGS.BGSConnections[((ConnectionContext)context).Caller].GameAccountLow,
				Program = 4613486U,
				Region = 100U
			};
			ChannelAddedNotification channelAddedNotification = new ChannelAddedNotification
			{
				AgentId = gameAccountHandle,
				SubscriberId = gameAccountHandle,
				Membership = new ChannelDescription
				{
					Id = new ChannelId
					{
						Host = new ProcessId
						{
							Label = 878945316U,
							Epoch = 1632412888U
						},
						Id = 9981U
					},
					Type = new UniqueChannelType
					{
						Program = 4613486U,
						ChannelType = "public_default"
					},
					Name = "Blizzless General Channel",
					PrivacyLevel = PrivacyLevel.Open,
					MemberCount = 1U,
					PublicChannelState = new PublicChannelState
					{
						Identity = "FEN-GENERAL",
						Locale = 1829281413U
					}
				}
			};
			D2RBGS.BGSConnections[((ConnectionContext)context).Caller].SendBgsServer(channelAddedNotification, "OnChannelAdded", typeof(ChannelMembershipListener));
			return Task.FromResult<NoData>(new NoData());
		}

		// Token: 0x0600BD17 RID: 48407 RVA: 0x00484B8C File Offset: 0x00482D8C
		public override Task<GetChannelResponse> GetChannel(GetChannelRequest request, ServerCallContext context)
		{
			return base.GetChannel(request, context);
		}

		// Token: 0x0600BD18 RID: 48408 RVA: 0x00484BA8 File Offset: 0x00482DA8
		public override Task<GetJoinVoiceTokenResponse> GetJoinVoiceToken(GetJoinVoiceTokenRequest request, ServerCallContext context)
		{
			return base.GetJoinVoiceToken(request, context);
		}

		// Token: 0x0600BD19 RID: 48409 RVA: 0x00484BC4 File Offset: 0x00482DC4
		public override Task<GetPublicChannelTypesResponse> GetPublicChannelTypes(GetPublicChannelTypesRequest request, ServerCallContext context)
		{
			GetPublicChannelTypesResponse getPublicChannelTypesResponse = new GetPublicChannelTypesResponse();
			getPublicChannelTypesResponse.Channel.Add(new PublicChannelType
			{
				Type = new UniqueChannelType
				{
					ChannelType = "public_default",
					Program = 4613486U
				},
				Name = "General",
				Identity = "FEN-GENERAL"
			});
			getPublicChannelTypesResponse.Channel.Add(new PublicChannelType
			{
				Type = new UniqueChannelType
				{
					ChannelType = "public_default",
					Program = 4613486U
				},
				Name = "Trade",
				Identity = "FEN-TRADE"
			});
			getPublicChannelTypesResponse.Channel.Add(new PublicChannelType
			{
				Type = new UniqueChannelType
				{
					ChannelType = "public_default",
					Program = 4613486U
				},
				Name = "Looking for Group",
				Identity = "FEN-GROUP"
			});
			return Task.FromResult<GetPublicChannelTypesResponse>(getPublicChannelTypesResponse);
		}

		// Token: 0x0600BD1A RID: 48410 RVA: 0x00484CCC File Offset: 0x00482ECC
		public override Task<NoData> Join(JoinRequest request, ServerCallContext context)
		{
			return base.Join(request, context);
		}

		// Token: 0x0600BD1B RID: 48411 RVA: 0x00484CE8 File Offset: 0x00482EE8
		public override Task<NoData> Kick(KickRequest request, ServerCallContext context)
		{
			return base.Kick(request, context);
		}

		// Token: 0x0600BD1C RID: 48412 RVA: 0x00484D04 File Offset: 0x00482F04
		public override Task<NoData> Leave(LeaveRequest request, ServerCallContext context)
		{
			return base.Leave(request, context);
		}

		// Token: 0x0600BD1D RID: 48413 RVA: 0x00484D20 File Offset: 0x00482F20
		public override Task<NoData> RevokeInvitation(RevokeInvitationRequest request, ServerCallContext context)
		{
			return base.RevokeInvitation(request, context);
		}

		// Token: 0x0600BD1E RID: 48414 RVA: 0x00484D3C File Offset: 0x00482F3C
		public override Task<NoData> SendInvitation(SendInvitationRequest request, ServerCallContext context)
		{
			return base.SendInvitation(request, context);
		}

		// Token: 0x0600BD1F RID: 48415 RVA: 0x00484D58 File Offset: 0x00482F58
		public override Task<NoData> SendMessage(SendMessageRequest request, ServerCallContext context)
		{
			return base.SendMessage(request, context);
		}

		// Token: 0x0600BD20 RID: 48416 RVA: 0x00484D74 File Offset: 0x00482F74
		public override Task<NoData> SendSuggestion(SendSuggestionRequest request, ServerCallContext context)
		{
			return base.SendSuggestion(request, context);
		}

		// Token: 0x0600BD21 RID: 48417 RVA: 0x00484D90 File Offset: 0x00482F90
		public override Task<NoData> SetAttribute(SetAttributeRequest request, ServerCallContext context)
		{
			return base.SetAttribute(request, context);
		}

		// Token: 0x0600BD22 RID: 48418 RVA: 0x00484DAC File Offset: 0x00482FAC
		public override Task<NoData> SetMemberAttribute(SetMemberAttributeRequest request, ServerCallContext context)
		{
			return base.SetMemberAttribute(request, context);
		}

		// Token: 0x0600BD23 RID: 48419 RVA: 0x00484DC8 File Offset: 0x00482FC8
		public override Task<NoData> SetPrivacyLevel(SetPrivacyLevelRequest request, ServerCallContext context)
		{
			return base.SetPrivacyLevel(request, context);
		}

		// Token: 0x0600BD24 RID: 48420 RVA: 0x00484DE4 File Offset: 0x00482FE4
		public override Task<NoData> SetTypingIndicator(SetTypingIndicatorRequest request, ServerCallContext context)
		{
			return base.SetTypingIndicator(request, context);
		}

		// Token: 0x0600BD25 RID: 48421 RVA: 0x00484E00 File Offset: 0x00483000
		public override Task<NoData> UnassignRole(UnassignRoleRequest request, ServerCallContext context)
		{
			return base.UnassignRole(request, context);
		}

		// Token: 0x0600BD26 RID: 48422 RVA: 0x00484E1C File Offset: 0x0048301C
		public override Task<NoData> Unsubscribe(Bgs.Protocol.Channel.V2.UnsubscribeRequest request, ServerCallContext context)
		{
			return base.Unsubscribe(request, context);
		}

		// Token: 0x0600BD27 RID: 48423 RVA: 0x00484E38 File Offset: 0x00483038
		public override Task<Bgs.Protocol.Channel.V2.SubscribeResponse> Subscribe(Bgs.Protocol.Channel.V2.SubscribeRequest request, ServerCallContext context)
		{
			Bgs.Protocol.Channel.V2.SubscribeResponse subscribeResponse = new Bgs.Protocol.Channel.V2.SubscribeResponse();
			return Task.FromResult<Bgs.Protocol.Channel.V2.SubscribeResponse>(null);
		}

		// Token: 0x0400915B RID: 37211
		public static bool sentChannel;
	}
}
