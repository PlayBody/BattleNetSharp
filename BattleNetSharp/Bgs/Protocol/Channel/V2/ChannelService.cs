using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000682 RID: 1666
	public static class ChannelService
	{
		// Token: 0x06009AB9 RID: 39609 RVA: 0x00258300 File Offset: 0x00256500
		private static void __Helper_SerializeMessage(IMessage message, SerializationContext context)
		{
			bool flag = message is IBufferMessage;
			if (flag)
			{
				context.SetPayloadLength(message.CalculateSize());
				MessageExtensions.WriteTo(message, context.GetBufferWriter());
				context.Complete();
			}
			else
			{
				context.Complete(MessageExtensions.ToByteArray(message));
			}
		}

		// Token: 0x06009ABA RID: 39610 RVA: 0x0025834C File Offset: 0x0025654C
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = ChannelService.__Helper_MessageCache<T>.IsBufferMessage;
			T t;
			if (isBufferMessage)
			{
				t = parser.ParseFrom(context.PayloadAsReadOnlySequence());
			}
			else
			{
				t = parser.ParseFrom(context.PayloadAsNewBuffer());
			}
			return t;
		}

		// Token: 0x1700301F RID: 12319
		// (get) Token: 0x06009ABB RID: 39611 RVA: 0x00258384 File Offset: 0x00256584
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x06009ABC RID: 39612 RVA: 0x002583A8 File Offset: 0x002565A8
		public static ServerServiceDefinition BindService(ChannelService.ChannelServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<CreateChannelRequest, NoData>(ChannelService.__Method_CreateChannel, new UnaryServerMethod<CreateChannelRequest, NoData>(serviceImpl.CreateChannel)).AddMethod<DissolveChannelRequest, NoData>(ChannelService.__Method_DissolveChannel, new UnaryServerMethod<DissolveChannelRequest, NoData>(serviceImpl.DissolveChannel))
				.AddMethod<GetChannelRequest, GetChannelResponse>(ChannelService.__Method_GetChannel, new UnaryServerMethod<GetChannelRequest, GetChannelResponse>(serviceImpl.GetChannel))
				.AddMethod<GetPublicChannelTypesRequest, GetPublicChannelTypesResponse>(ChannelService.__Method_GetPublicChannelTypes, new UnaryServerMethod<GetPublicChannelTypesRequest, GetPublicChannelTypesResponse>(serviceImpl.GetPublicChannelTypes))
				.AddMethod<FindChannelRequest, NoData>(ChannelService.__Method_FindChannel, new UnaryServerMethod<FindChannelRequest, NoData>(serviceImpl.FindChannel))
				.AddMethod<SubscribeRequest, SubscribeResponse>(ChannelService.__Method_Subscribe, new UnaryServerMethod<SubscribeRequest, SubscribeResponse>(serviceImpl.Subscribe))
				.AddMethod<UnsubscribeRequest, NoData>(ChannelService.__Method_Unsubscribe, new UnaryServerMethod<UnsubscribeRequest, NoData>(serviceImpl.Unsubscribe))
				.AddMethod<SetAttributeRequest, NoData>(ChannelService.__Method_SetAttribute, new UnaryServerMethod<SetAttributeRequest, NoData>(serviceImpl.SetAttribute))
				.AddMethod<SetPrivacyLevelRequest, NoData>(ChannelService.__Method_SetPrivacyLevel, new UnaryServerMethod<SetPrivacyLevelRequest, NoData>(serviceImpl.SetPrivacyLevel))
				.AddMethod<SendMessageRequest, NoData>(ChannelService.__Method_SendMessage, new UnaryServerMethod<SendMessageRequest, NoData>(serviceImpl.SendMessage))
				.AddMethod<SetTypingIndicatorRequest, NoData>(ChannelService.__Method_SetTypingIndicator, new UnaryServerMethod<SetTypingIndicatorRequest, NoData>(serviceImpl.SetTypingIndicator))
				.AddMethod<JoinRequest, NoData>(ChannelService.__Method_Join, new UnaryServerMethod<JoinRequest, NoData>(serviceImpl.Join))
				.AddMethod<LeaveRequest, NoData>(ChannelService.__Method_Leave, new UnaryServerMethod<LeaveRequest, NoData>(serviceImpl.Leave))
				.AddMethod<KickRequest, NoData>(ChannelService.__Method_Kick, new UnaryServerMethod<KickRequest, NoData>(serviceImpl.Kick))
				.AddMethod<SetMemberAttributeRequest, NoData>(ChannelService.__Method_SetMemberAttribute, new UnaryServerMethod<SetMemberAttributeRequest, NoData>(serviceImpl.SetMemberAttribute))
				.AddMethod<AssignRoleRequest, NoData>(ChannelService.__Method_AssignRole, new UnaryServerMethod<AssignRoleRequest, NoData>(serviceImpl.AssignRole))
				.AddMethod<UnassignRoleRequest, NoData>(ChannelService.__Method_UnassignRole, new UnaryServerMethod<UnassignRoleRequest, NoData>(serviceImpl.UnassignRole))
				.AddMethod<SendInvitationRequest, NoData>(ChannelService.__Method_SendInvitation, new UnaryServerMethod<SendInvitationRequest, NoData>(serviceImpl.SendInvitation))
				.AddMethod<AcceptInvitationRequest, NoData>(ChannelService.__Method_AcceptInvitation, new UnaryServerMethod<AcceptInvitationRequest, NoData>(serviceImpl.AcceptInvitation))
				.AddMethod<DeclineInvitationRequest, NoData>(ChannelService.__Method_DeclineInvitation, new UnaryServerMethod<DeclineInvitationRequest, NoData>(serviceImpl.DeclineInvitation))
				.AddMethod<RevokeInvitationRequest, NoData>(ChannelService.__Method_RevokeInvitation, new UnaryServerMethod<RevokeInvitationRequest, NoData>(serviceImpl.RevokeInvitation))
				.AddMethod<SendSuggestionRequest, NoData>(ChannelService.__Method_SendSuggestion, new UnaryServerMethod<SendSuggestionRequest, NoData>(serviceImpl.SendSuggestion))
				.AddMethod<GetJoinVoiceTokenRequest, GetJoinVoiceTokenResponse>(ChannelService.__Method_GetJoinVoiceToken, new UnaryServerMethod<GetJoinVoiceTokenRequest, GetJoinVoiceTokenResponse>(serviceImpl.GetJoinVoiceToken))
				.Build();
		}

		// Token: 0x06009ABD RID: 39613 RVA: 0x002585D8 File Offset: 0x002567D8
		public static void BindService(ServiceBinderBase serviceBinder, ChannelService.ChannelServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<CreateChannelRequest, NoData>(ChannelService.__Method_CreateChannel, (serviceImpl == null) ? null : new UnaryServerMethod<CreateChannelRequest, NoData>(serviceImpl.CreateChannel));
			serviceBinder.AddMethod<DissolveChannelRequest, NoData>(ChannelService.__Method_DissolveChannel, (serviceImpl == null) ? null : new UnaryServerMethod<DissolveChannelRequest, NoData>(serviceImpl.DissolveChannel));
			serviceBinder.AddMethod<GetChannelRequest, GetChannelResponse>(ChannelService.__Method_GetChannel, (serviceImpl == null) ? null : new UnaryServerMethod<GetChannelRequest, GetChannelResponse>(serviceImpl.GetChannel));
			serviceBinder.AddMethod<GetPublicChannelTypesRequest, GetPublicChannelTypesResponse>(ChannelService.__Method_GetPublicChannelTypes, (serviceImpl == null) ? null : new UnaryServerMethod<GetPublicChannelTypesRequest, GetPublicChannelTypesResponse>(serviceImpl.GetPublicChannelTypes));
			serviceBinder.AddMethod<FindChannelRequest, NoData>(ChannelService.__Method_FindChannel, (serviceImpl == null) ? null : new UnaryServerMethod<FindChannelRequest, NoData>(serviceImpl.FindChannel));
			serviceBinder.AddMethod<SubscribeRequest, SubscribeResponse>(ChannelService.__Method_Subscribe, (serviceImpl == null) ? null : new UnaryServerMethod<SubscribeRequest, SubscribeResponse>(serviceImpl.Subscribe));
			serviceBinder.AddMethod<UnsubscribeRequest, NoData>(ChannelService.__Method_Unsubscribe, (serviceImpl == null) ? null : new UnaryServerMethod<UnsubscribeRequest, NoData>(serviceImpl.Unsubscribe));
			serviceBinder.AddMethod<SetAttributeRequest, NoData>(ChannelService.__Method_SetAttribute, (serviceImpl == null) ? null : new UnaryServerMethod<SetAttributeRequest, NoData>(serviceImpl.SetAttribute));
			serviceBinder.AddMethod<SetPrivacyLevelRequest, NoData>(ChannelService.__Method_SetPrivacyLevel, (serviceImpl == null) ? null : new UnaryServerMethod<SetPrivacyLevelRequest, NoData>(serviceImpl.SetPrivacyLevel));
			serviceBinder.AddMethod<SendMessageRequest, NoData>(ChannelService.__Method_SendMessage, (serviceImpl == null) ? null : new UnaryServerMethod<SendMessageRequest, NoData>(serviceImpl.SendMessage));
			serviceBinder.AddMethod<SetTypingIndicatorRequest, NoData>(ChannelService.__Method_SetTypingIndicator, (serviceImpl == null) ? null : new UnaryServerMethod<SetTypingIndicatorRequest, NoData>(serviceImpl.SetTypingIndicator));
			serviceBinder.AddMethod<JoinRequest, NoData>(ChannelService.__Method_Join, (serviceImpl == null) ? null : new UnaryServerMethod<JoinRequest, NoData>(serviceImpl.Join));
			serviceBinder.AddMethod<LeaveRequest, NoData>(ChannelService.__Method_Leave, (serviceImpl == null) ? null : new UnaryServerMethod<LeaveRequest, NoData>(serviceImpl.Leave));
			serviceBinder.AddMethod<KickRequest, NoData>(ChannelService.__Method_Kick, (serviceImpl == null) ? null : new UnaryServerMethod<KickRequest, NoData>(serviceImpl.Kick));
			serviceBinder.AddMethod<SetMemberAttributeRequest, NoData>(ChannelService.__Method_SetMemberAttribute, (serviceImpl == null) ? null : new UnaryServerMethod<SetMemberAttributeRequest, NoData>(serviceImpl.SetMemberAttribute));
			serviceBinder.AddMethod<AssignRoleRequest, NoData>(ChannelService.__Method_AssignRole, (serviceImpl == null) ? null : new UnaryServerMethod<AssignRoleRequest, NoData>(serviceImpl.AssignRole));
			serviceBinder.AddMethod<UnassignRoleRequest, NoData>(ChannelService.__Method_UnassignRole, (serviceImpl == null) ? null : new UnaryServerMethod<UnassignRoleRequest, NoData>(serviceImpl.UnassignRole));
			serviceBinder.AddMethod<SendInvitationRequest, NoData>(ChannelService.__Method_SendInvitation, (serviceImpl == null) ? null : new UnaryServerMethod<SendInvitationRequest, NoData>(serviceImpl.SendInvitation));
			serviceBinder.AddMethod<AcceptInvitationRequest, NoData>(ChannelService.__Method_AcceptInvitation, (serviceImpl == null) ? null : new UnaryServerMethod<AcceptInvitationRequest, NoData>(serviceImpl.AcceptInvitation));
			serviceBinder.AddMethod<DeclineInvitationRequest, NoData>(ChannelService.__Method_DeclineInvitation, (serviceImpl == null) ? null : new UnaryServerMethod<DeclineInvitationRequest, NoData>(serviceImpl.DeclineInvitation));
			serviceBinder.AddMethod<RevokeInvitationRequest, NoData>(ChannelService.__Method_RevokeInvitation, (serviceImpl == null) ? null : new UnaryServerMethod<RevokeInvitationRequest, NoData>(serviceImpl.RevokeInvitation));
			serviceBinder.AddMethod<SendSuggestionRequest, NoData>(ChannelService.__Method_SendSuggestion, (serviceImpl == null) ? null : new UnaryServerMethod<SendSuggestionRequest, NoData>(serviceImpl.SendSuggestion));
			serviceBinder.AddMethod<GetJoinVoiceTokenRequest, GetJoinVoiceTokenResponse>(ChannelService.__Method_GetJoinVoiceToken, (serviceImpl == null) ? null : new UnaryServerMethod<GetJoinVoiceTokenRequest, GetJoinVoiceTokenResponse>(serviceImpl.GetJoinVoiceToken));
		}

		// Token: 0x0400458D RID: 17805
		private static readonly string __ServiceName = "bgs.protocol.channel.v2.ChannelService";

		// Token: 0x0400458E RID: 17806
		private static readonly Marshaller<CreateChannelRequest> __Marshaller_bgs_protocol_channel_v2_CreateChannelRequest = Marshallers.Create<CreateChannelRequest>(new Action<CreateChannelRequest, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<CreateChannelRequest>(context, CreateChannelRequest.Parser));

		// Token: 0x0400458F RID: 17807
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x04004590 RID: 17808
		private static readonly Marshaller<DissolveChannelRequest> __Marshaller_bgs_protocol_channel_v2_DissolveChannelRequest = Marshallers.Create<DissolveChannelRequest>(new Action<DissolveChannelRequest, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<DissolveChannelRequest>(context, DissolveChannelRequest.Parser));

		// Token: 0x04004591 RID: 17809
		private static readonly Marshaller<GetChannelRequest> __Marshaller_bgs_protocol_channel_v2_GetChannelRequest = Marshallers.Create<GetChannelRequest>(new Action<GetChannelRequest, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<GetChannelRequest>(context, GetChannelRequest.Parser));

		// Token: 0x04004592 RID: 17810
		private static readonly Marshaller<GetChannelResponse> __Marshaller_bgs_protocol_channel_v2_GetChannelResponse = Marshallers.Create<GetChannelResponse>(new Action<GetChannelResponse, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<GetChannelResponse>(context, GetChannelResponse.Parser));

		// Token: 0x04004593 RID: 17811
		private static readonly Marshaller<GetPublicChannelTypesRequest> __Marshaller_bgs_protocol_channel_v2_GetPublicChannelTypesRequest = Marshallers.Create<GetPublicChannelTypesRequest>(new Action<GetPublicChannelTypesRequest, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<GetPublicChannelTypesRequest>(context, GetPublicChannelTypesRequest.Parser));

		// Token: 0x04004594 RID: 17812
		private static readonly Marshaller<GetPublicChannelTypesResponse> __Marshaller_bgs_protocol_channel_v2_GetPublicChannelTypesResponse = Marshallers.Create<GetPublicChannelTypesResponse>(new Action<GetPublicChannelTypesResponse, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<GetPublicChannelTypesResponse>(context, GetPublicChannelTypesResponse.Parser));

		// Token: 0x04004595 RID: 17813
		private static readonly Marshaller<FindChannelRequest> __Marshaller_bgs_protocol_channel_v2_FindChannelRequest = Marshallers.Create<FindChannelRequest>(new Action<FindChannelRequest, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<FindChannelRequest>(context, FindChannelRequest.Parser));

		// Token: 0x04004596 RID: 17814
		private static readonly Marshaller<SubscribeRequest> __Marshaller_bgs_protocol_channel_v2_SubscribeRequest = Marshallers.Create<SubscribeRequest>(new Action<SubscribeRequest, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<SubscribeRequest>(context, SubscribeRequest.Parser));

		// Token: 0x04004597 RID: 17815
		private static readonly Marshaller<SubscribeResponse> __Marshaller_bgs_protocol_channel_v2_SubscribeResponse = Marshallers.Create<SubscribeResponse>(new Action<SubscribeResponse, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<SubscribeResponse>(context, SubscribeResponse.Parser));

		// Token: 0x04004598 RID: 17816
		private static readonly Marshaller<UnsubscribeRequest> __Marshaller_bgs_protocol_channel_v2_UnsubscribeRequest = Marshallers.Create<UnsubscribeRequest>(new Action<UnsubscribeRequest, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<UnsubscribeRequest>(context, UnsubscribeRequest.Parser));

		// Token: 0x04004599 RID: 17817
		private static readonly Marshaller<SetAttributeRequest> __Marshaller_bgs_protocol_channel_v2_SetAttributeRequest = Marshallers.Create<SetAttributeRequest>(new Action<SetAttributeRequest, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<SetAttributeRequest>(context, SetAttributeRequest.Parser));

		// Token: 0x0400459A RID: 17818
		private static readonly Marshaller<SetPrivacyLevelRequest> __Marshaller_bgs_protocol_channel_v2_SetPrivacyLevelRequest = Marshallers.Create<SetPrivacyLevelRequest>(new Action<SetPrivacyLevelRequest, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<SetPrivacyLevelRequest>(context, SetPrivacyLevelRequest.Parser));

		// Token: 0x0400459B RID: 17819
		private static readonly Marshaller<SendMessageRequest> __Marshaller_bgs_protocol_channel_v2_SendMessageRequest = Marshallers.Create<SendMessageRequest>(new Action<SendMessageRequest, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<SendMessageRequest>(context, SendMessageRequest.Parser));

		// Token: 0x0400459C RID: 17820
		private static readonly Marshaller<SetTypingIndicatorRequest> __Marshaller_bgs_protocol_channel_v2_SetTypingIndicatorRequest = Marshallers.Create<SetTypingIndicatorRequest>(new Action<SetTypingIndicatorRequest, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<SetTypingIndicatorRequest>(context, SetTypingIndicatorRequest.Parser));

		// Token: 0x0400459D RID: 17821
		private static readonly Marshaller<JoinRequest> __Marshaller_bgs_protocol_channel_v2_JoinRequest = Marshallers.Create<JoinRequest>(new Action<JoinRequest, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<JoinRequest>(context, JoinRequest.Parser));

		// Token: 0x0400459E RID: 17822
		private static readonly Marshaller<LeaveRequest> __Marshaller_bgs_protocol_channel_v2_LeaveRequest = Marshallers.Create<LeaveRequest>(new Action<LeaveRequest, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<LeaveRequest>(context, LeaveRequest.Parser));

		// Token: 0x0400459F RID: 17823
		private static readonly Marshaller<KickRequest> __Marshaller_bgs_protocol_channel_v2_KickRequest = Marshallers.Create<KickRequest>(new Action<KickRequest, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<KickRequest>(context, KickRequest.Parser));

		// Token: 0x040045A0 RID: 17824
		private static readonly Marshaller<SetMemberAttributeRequest> __Marshaller_bgs_protocol_channel_v2_SetMemberAttributeRequest = Marshallers.Create<SetMemberAttributeRequest>(new Action<SetMemberAttributeRequest, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<SetMemberAttributeRequest>(context, SetMemberAttributeRequest.Parser));

		// Token: 0x040045A1 RID: 17825
		private static readonly Marshaller<AssignRoleRequest> __Marshaller_bgs_protocol_channel_v2_AssignRoleRequest = Marshallers.Create<AssignRoleRequest>(new Action<AssignRoleRequest, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<AssignRoleRequest>(context, AssignRoleRequest.Parser));

		// Token: 0x040045A2 RID: 17826
		private static readonly Marshaller<UnassignRoleRequest> __Marshaller_bgs_protocol_channel_v2_UnassignRoleRequest = Marshallers.Create<UnassignRoleRequest>(new Action<UnassignRoleRequest, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<UnassignRoleRequest>(context, UnassignRoleRequest.Parser));

		// Token: 0x040045A3 RID: 17827
		private static readonly Marshaller<SendInvitationRequest> __Marshaller_bgs_protocol_channel_v2_SendInvitationRequest = Marshallers.Create<SendInvitationRequest>(new Action<SendInvitationRequest, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<SendInvitationRequest>(context, SendInvitationRequest.Parser));

		// Token: 0x040045A4 RID: 17828
		private static readonly Marshaller<AcceptInvitationRequest> __Marshaller_bgs_protocol_channel_v2_AcceptInvitationRequest = Marshallers.Create<AcceptInvitationRequest>(new Action<AcceptInvitationRequest, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<AcceptInvitationRequest>(context, AcceptInvitationRequest.Parser));

		// Token: 0x040045A5 RID: 17829
		private static readonly Marshaller<DeclineInvitationRequest> __Marshaller_bgs_protocol_channel_v2_DeclineInvitationRequest = Marshallers.Create<DeclineInvitationRequest>(new Action<DeclineInvitationRequest, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<DeclineInvitationRequest>(context, DeclineInvitationRequest.Parser));

		// Token: 0x040045A6 RID: 17830
		private static readonly Marshaller<RevokeInvitationRequest> __Marshaller_bgs_protocol_channel_v2_RevokeInvitationRequest = Marshallers.Create<RevokeInvitationRequest>(new Action<RevokeInvitationRequest, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<RevokeInvitationRequest>(context, RevokeInvitationRequest.Parser));

		// Token: 0x040045A7 RID: 17831
		private static readonly Marshaller<SendSuggestionRequest> __Marshaller_bgs_protocol_channel_v2_SendSuggestionRequest = Marshallers.Create<SendSuggestionRequest>(new Action<SendSuggestionRequest, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<SendSuggestionRequest>(context, SendSuggestionRequest.Parser));

		// Token: 0x040045A8 RID: 17832
		private static readonly Marshaller<GetJoinVoiceTokenRequest> __Marshaller_bgs_protocol_channel_v2_GetJoinVoiceTokenRequest = Marshallers.Create<GetJoinVoiceTokenRequest>(new Action<GetJoinVoiceTokenRequest, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<GetJoinVoiceTokenRequest>(context, GetJoinVoiceTokenRequest.Parser));

		// Token: 0x040045A9 RID: 17833
		private static readonly Marshaller<GetJoinVoiceTokenResponse> __Marshaller_bgs_protocol_channel_v2_GetJoinVoiceTokenResponse = Marshallers.Create<GetJoinVoiceTokenResponse>(new Action<GetJoinVoiceTokenResponse, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<GetJoinVoiceTokenResponse>(context, GetJoinVoiceTokenResponse.Parser));

		// Token: 0x040045AA RID: 17834
		private static readonly Method<CreateChannelRequest, NoData> __Method_CreateChannel = new Method<CreateChannelRequest, NoData>(0, ChannelService.__ServiceName, "CreateChannel", ChannelService.__Marshaller_bgs_protocol_channel_v2_CreateChannelRequest, ChannelService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x040045AB RID: 17835
		private static readonly Method<DissolveChannelRequest, NoData> __Method_DissolveChannel = new Method<DissolveChannelRequest, NoData>(0, ChannelService.__ServiceName, "DissolveChannel", ChannelService.__Marshaller_bgs_protocol_channel_v2_DissolveChannelRequest, ChannelService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x040045AC RID: 17836
		private static readonly Method<GetChannelRequest, GetChannelResponse> __Method_GetChannel = new Method<GetChannelRequest, GetChannelResponse>(0, ChannelService.__ServiceName, "GetChannel", ChannelService.__Marshaller_bgs_protocol_channel_v2_GetChannelRequest, ChannelService.__Marshaller_bgs_protocol_channel_v2_GetChannelResponse);

		// Token: 0x040045AD RID: 17837
		private static readonly Method<GetPublicChannelTypesRequest, GetPublicChannelTypesResponse> __Method_GetPublicChannelTypes = new Method<GetPublicChannelTypesRequest, GetPublicChannelTypesResponse>(0, ChannelService.__ServiceName, "GetPublicChannelTypes", ChannelService.__Marshaller_bgs_protocol_channel_v2_GetPublicChannelTypesRequest, ChannelService.__Marshaller_bgs_protocol_channel_v2_GetPublicChannelTypesResponse);

		// Token: 0x040045AE RID: 17838
		private static readonly Method<FindChannelRequest, NoData> __Method_FindChannel = new Method<FindChannelRequest, NoData>(0, ChannelService.__ServiceName, "FindChannel", ChannelService.__Marshaller_bgs_protocol_channel_v2_FindChannelRequest, ChannelService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x040045AF RID: 17839
		private static readonly Method<SubscribeRequest, SubscribeResponse> __Method_Subscribe = new Method<SubscribeRequest, SubscribeResponse>(0, ChannelService.__ServiceName, "Subscribe", ChannelService.__Marshaller_bgs_protocol_channel_v2_SubscribeRequest, ChannelService.__Marshaller_bgs_protocol_channel_v2_SubscribeResponse);

		// Token: 0x040045B0 RID: 17840
		private static readonly Method<UnsubscribeRequest, NoData> __Method_Unsubscribe = new Method<UnsubscribeRequest, NoData>(0, ChannelService.__ServiceName, "Unsubscribe", ChannelService.__Marshaller_bgs_protocol_channel_v2_UnsubscribeRequest, ChannelService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x040045B1 RID: 17841
		private static readonly Method<SetAttributeRequest, NoData> __Method_SetAttribute = new Method<SetAttributeRequest, NoData>(0, ChannelService.__ServiceName, "SetAttribute", ChannelService.__Marshaller_bgs_protocol_channel_v2_SetAttributeRequest, ChannelService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x040045B2 RID: 17842
		private static readonly Method<SetPrivacyLevelRequest, NoData> __Method_SetPrivacyLevel = new Method<SetPrivacyLevelRequest, NoData>(0, ChannelService.__ServiceName, "SetPrivacyLevel", ChannelService.__Marshaller_bgs_protocol_channel_v2_SetPrivacyLevelRequest, ChannelService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x040045B3 RID: 17843
		private static readonly Method<SendMessageRequest, NoData> __Method_SendMessage = new Method<SendMessageRequest, NoData>(0, ChannelService.__ServiceName, "SendMessage", ChannelService.__Marshaller_bgs_protocol_channel_v2_SendMessageRequest, ChannelService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x040045B4 RID: 17844
		private static readonly Method<SetTypingIndicatorRequest, NoData> __Method_SetTypingIndicator = new Method<SetTypingIndicatorRequest, NoData>(0, ChannelService.__ServiceName, "SetTypingIndicator", ChannelService.__Marshaller_bgs_protocol_channel_v2_SetTypingIndicatorRequest, ChannelService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x040045B5 RID: 17845
		private static readonly Method<JoinRequest, NoData> __Method_Join = new Method<JoinRequest, NoData>(0, ChannelService.__ServiceName, "Join", ChannelService.__Marshaller_bgs_protocol_channel_v2_JoinRequest, ChannelService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x040045B6 RID: 17846
		private static readonly Method<LeaveRequest, NoData> __Method_Leave = new Method<LeaveRequest, NoData>(0, ChannelService.__ServiceName, "Leave", ChannelService.__Marshaller_bgs_protocol_channel_v2_LeaveRequest, ChannelService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x040045B7 RID: 17847
		private static readonly Method<KickRequest, NoData> __Method_Kick = new Method<KickRequest, NoData>(0, ChannelService.__ServiceName, "Kick", ChannelService.__Marshaller_bgs_protocol_channel_v2_KickRequest, ChannelService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x040045B8 RID: 17848
		private static readonly Method<SetMemberAttributeRequest, NoData> __Method_SetMemberAttribute = new Method<SetMemberAttributeRequest, NoData>(0, ChannelService.__ServiceName, "SetMemberAttribute", ChannelService.__Marshaller_bgs_protocol_channel_v2_SetMemberAttributeRequest, ChannelService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x040045B9 RID: 17849
		private static readonly Method<AssignRoleRequest, NoData> __Method_AssignRole = new Method<AssignRoleRequest, NoData>(0, ChannelService.__ServiceName, "AssignRole", ChannelService.__Marshaller_bgs_protocol_channel_v2_AssignRoleRequest, ChannelService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x040045BA RID: 17850
		private static readonly Method<UnassignRoleRequest, NoData> __Method_UnassignRole = new Method<UnassignRoleRequest, NoData>(0, ChannelService.__ServiceName, "UnassignRole", ChannelService.__Marshaller_bgs_protocol_channel_v2_UnassignRoleRequest, ChannelService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x040045BB RID: 17851
		private static readonly Method<SendInvitationRequest, NoData> __Method_SendInvitation = new Method<SendInvitationRequest, NoData>(0, ChannelService.__ServiceName, "SendInvitation", ChannelService.__Marshaller_bgs_protocol_channel_v2_SendInvitationRequest, ChannelService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x040045BC RID: 17852
		private static readonly Method<AcceptInvitationRequest, NoData> __Method_AcceptInvitation = new Method<AcceptInvitationRequest, NoData>(0, ChannelService.__ServiceName, "AcceptInvitation", ChannelService.__Marshaller_bgs_protocol_channel_v2_AcceptInvitationRequest, ChannelService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x040045BD RID: 17853
		private static readonly Method<DeclineInvitationRequest, NoData> __Method_DeclineInvitation = new Method<DeclineInvitationRequest, NoData>(0, ChannelService.__ServiceName, "DeclineInvitation", ChannelService.__Marshaller_bgs_protocol_channel_v2_DeclineInvitationRequest, ChannelService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x040045BE RID: 17854
		private static readonly Method<RevokeInvitationRequest, NoData> __Method_RevokeInvitation = new Method<RevokeInvitationRequest, NoData>(0, ChannelService.__ServiceName, "RevokeInvitation", ChannelService.__Marshaller_bgs_protocol_channel_v2_RevokeInvitationRequest, ChannelService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x040045BF RID: 17855
		private static readonly Method<SendSuggestionRequest, NoData> __Method_SendSuggestion = new Method<SendSuggestionRequest, NoData>(0, ChannelService.__ServiceName, "SendSuggestion", ChannelService.__Marshaller_bgs_protocol_channel_v2_SendSuggestionRequest, ChannelService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x040045C0 RID: 17856
		private static readonly Method<GetJoinVoiceTokenRequest, GetJoinVoiceTokenResponse> __Method_GetJoinVoiceToken = new Method<GetJoinVoiceTokenRequest, GetJoinVoiceTokenResponse>(0, ChannelService.__ServiceName, "GetJoinVoiceToken", ChannelService.__Marshaller_bgs_protocol_channel_v2_GetJoinVoiceTokenRequest, ChannelService.__Marshaller_bgs_protocol_channel_v2_GetJoinVoiceTokenResponse);

		// Token: 0x02001177 RID: 4471
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x040098B1 RID: 39089
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02001178 RID: 4472
		[BindServiceMethod(typeof(ChannelService), "BindService")]
		public abstract class ChannelServiceBase
		{
			// Token: 0x0600D6F9 RID: 55033 RVA: 0x004B748A File Offset: 0x004B568A
			public virtual Task<NoData> CreateChannel(CreateChannelRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D6FA RID: 55034 RVA: 0x004B749E File Offset: 0x004B569E
			public virtual Task<NoData> DissolveChannel(DissolveChannelRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D6FB RID: 55035 RVA: 0x004B74B2 File Offset: 0x004B56B2
			public virtual Task<GetChannelResponse> GetChannel(GetChannelRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D6FC RID: 55036 RVA: 0x004B74C6 File Offset: 0x004B56C6
			public virtual Task<GetPublicChannelTypesResponse> GetPublicChannelTypes(GetPublicChannelTypesRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D6FD RID: 55037 RVA: 0x004B74DA File Offset: 0x004B56DA
			public virtual Task<NoData> FindChannel(FindChannelRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D6FE RID: 55038 RVA: 0x004B74EE File Offset: 0x004B56EE
			public virtual Task<SubscribeResponse> Subscribe(SubscribeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D6FF RID: 55039 RVA: 0x004B7502 File Offset: 0x004B5702
			public virtual Task<NoData> Unsubscribe(UnsubscribeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D700 RID: 55040 RVA: 0x004B7516 File Offset: 0x004B5716
			public virtual Task<NoData> SetAttribute(SetAttributeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D701 RID: 55041 RVA: 0x004B752A File Offset: 0x004B572A
			public virtual Task<NoData> SetPrivacyLevel(SetPrivacyLevelRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D702 RID: 55042 RVA: 0x004B753E File Offset: 0x004B573E
			public virtual Task<NoData> SendMessage(SendMessageRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D703 RID: 55043 RVA: 0x004B7552 File Offset: 0x004B5752
			public virtual Task<NoData> SetTypingIndicator(SetTypingIndicatorRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D704 RID: 55044 RVA: 0x004B7566 File Offset: 0x004B5766
			public virtual Task<NoData> Join(JoinRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D705 RID: 55045 RVA: 0x004B757A File Offset: 0x004B577A
			public virtual Task<NoData> Leave(LeaveRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D706 RID: 55046 RVA: 0x004B758E File Offset: 0x004B578E
			public virtual Task<NoData> Kick(KickRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D707 RID: 55047 RVA: 0x004B75A2 File Offset: 0x004B57A2
			public virtual Task<NoData> SetMemberAttribute(SetMemberAttributeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D708 RID: 55048 RVA: 0x004B75B6 File Offset: 0x004B57B6
			public virtual Task<NoData> AssignRole(AssignRoleRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D709 RID: 55049 RVA: 0x004B75CA File Offset: 0x004B57CA
			public virtual Task<NoData> UnassignRole(UnassignRoleRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D70A RID: 55050 RVA: 0x004B75DE File Offset: 0x004B57DE
			public virtual Task<NoData> SendInvitation(SendInvitationRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D70B RID: 55051 RVA: 0x004B75F2 File Offset: 0x004B57F2
			public virtual Task<NoData> AcceptInvitation(AcceptInvitationRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D70C RID: 55052 RVA: 0x004B7606 File Offset: 0x004B5806
			public virtual Task<NoData> DeclineInvitation(DeclineInvitationRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D70D RID: 55053 RVA: 0x004B761A File Offset: 0x004B581A
			public virtual Task<NoData> RevokeInvitation(RevokeInvitationRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D70E RID: 55054 RVA: 0x004B762E File Offset: 0x004B582E
			public virtual Task<NoData> SendSuggestion(SendSuggestionRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D70F RID: 55055 RVA: 0x004B7642 File Offset: 0x004B5842
			public virtual Task<GetJoinVoiceTokenResponse> GetJoinVoiceToken(GetJoinVoiceTokenRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x02001179 RID: 4473
		public class ChannelServiceClient : ClientBase<ChannelService.ChannelServiceClient>
		{
			// Token: 0x0600D711 RID: 55057 RVA: 0x004B765F File Offset: 0x004B585F
			public ChannelServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D712 RID: 55058 RVA: 0x004B766A File Offset: 0x004B586A
			public ChannelServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D713 RID: 55059 RVA: 0x004B7675 File Offset: 0x004B5875
			protected ChannelServiceClient()
			{
			}

			// Token: 0x0600D714 RID: 55060 RVA: 0x004B767F File Offset: 0x004B587F
			protected ChannelServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D715 RID: 55061 RVA: 0x004B768C File Offset: 0x004B588C
			public virtual NoData CreateChannel(CreateChannelRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.CreateChannel(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D716 RID: 55062 RVA: 0x004B76B4 File Offset: 0x004B58B4
			public virtual NoData CreateChannel(CreateChannelRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<CreateChannelRequest, NoData>(ChannelService.__Method_CreateChannel, null, options, request);
			}

			// Token: 0x0600D717 RID: 55063 RVA: 0x004B76DC File Offset: 0x004B58DC
			public virtual AsyncUnaryCall<NoData> CreateChannelAsync(CreateChannelRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.CreateChannelAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D718 RID: 55064 RVA: 0x004B7704 File Offset: 0x004B5904
			public virtual AsyncUnaryCall<NoData> CreateChannelAsync(CreateChannelRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<CreateChannelRequest, NoData>(ChannelService.__Method_CreateChannel, null, options, request);
			}

			// Token: 0x0600D719 RID: 55065 RVA: 0x004B772C File Offset: 0x004B592C
			public virtual NoData DissolveChannel(DissolveChannelRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.DissolveChannel(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D71A RID: 55066 RVA: 0x004B7754 File Offset: 0x004B5954
			public virtual NoData DissolveChannel(DissolveChannelRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<DissolveChannelRequest, NoData>(ChannelService.__Method_DissolveChannel, null, options, request);
			}

			// Token: 0x0600D71B RID: 55067 RVA: 0x004B777C File Offset: 0x004B597C
			public virtual AsyncUnaryCall<NoData> DissolveChannelAsync(DissolveChannelRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.DissolveChannelAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D71C RID: 55068 RVA: 0x004B77A4 File Offset: 0x004B59A4
			public virtual AsyncUnaryCall<NoData> DissolveChannelAsync(DissolveChannelRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<DissolveChannelRequest, NoData>(ChannelService.__Method_DissolveChannel, null, options, request);
			}

			// Token: 0x0600D71D RID: 55069 RVA: 0x004B77CC File Offset: 0x004B59CC
			public virtual GetChannelResponse GetChannel(GetChannelRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetChannel(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D71E RID: 55070 RVA: 0x004B77F4 File Offset: 0x004B59F4
			public virtual GetChannelResponse GetChannel(GetChannelRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetChannelRequest, GetChannelResponse>(ChannelService.__Method_GetChannel, null, options, request);
			}

			// Token: 0x0600D71F RID: 55071 RVA: 0x004B781C File Offset: 0x004B5A1C
			public virtual AsyncUnaryCall<GetChannelResponse> GetChannelAsync(GetChannelRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetChannelAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D720 RID: 55072 RVA: 0x004B7844 File Offset: 0x004B5A44
			public virtual AsyncUnaryCall<GetChannelResponse> GetChannelAsync(GetChannelRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetChannelRequest, GetChannelResponse>(ChannelService.__Method_GetChannel, null, options, request);
			}

			// Token: 0x0600D721 RID: 55073 RVA: 0x004B786C File Offset: 0x004B5A6C
			public virtual GetPublicChannelTypesResponse GetPublicChannelTypes(GetPublicChannelTypesRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetPublicChannelTypes(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D722 RID: 55074 RVA: 0x004B7894 File Offset: 0x004B5A94
			public virtual GetPublicChannelTypesResponse GetPublicChannelTypes(GetPublicChannelTypesRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetPublicChannelTypesRequest, GetPublicChannelTypesResponse>(ChannelService.__Method_GetPublicChannelTypes, null, options, request);
			}

			// Token: 0x0600D723 RID: 55075 RVA: 0x004B78BC File Offset: 0x004B5ABC
			public virtual AsyncUnaryCall<GetPublicChannelTypesResponse> GetPublicChannelTypesAsync(GetPublicChannelTypesRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetPublicChannelTypesAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D724 RID: 55076 RVA: 0x004B78E4 File Offset: 0x004B5AE4
			public virtual AsyncUnaryCall<GetPublicChannelTypesResponse> GetPublicChannelTypesAsync(GetPublicChannelTypesRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetPublicChannelTypesRequest, GetPublicChannelTypesResponse>(ChannelService.__Method_GetPublicChannelTypes, null, options, request);
			}

			// Token: 0x0600D725 RID: 55077 RVA: 0x004B790C File Offset: 0x004B5B0C
			public virtual NoData FindChannel(FindChannelRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.FindChannel(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D726 RID: 55078 RVA: 0x004B7934 File Offset: 0x004B5B34
			public virtual NoData FindChannel(FindChannelRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<FindChannelRequest, NoData>(ChannelService.__Method_FindChannel, null, options, request);
			}

			// Token: 0x0600D727 RID: 55079 RVA: 0x004B795C File Offset: 0x004B5B5C
			public virtual AsyncUnaryCall<NoData> FindChannelAsync(FindChannelRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.FindChannelAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D728 RID: 55080 RVA: 0x004B7984 File Offset: 0x004B5B84
			public virtual AsyncUnaryCall<NoData> FindChannelAsync(FindChannelRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<FindChannelRequest, NoData>(ChannelService.__Method_FindChannel, null, options, request);
			}

			// Token: 0x0600D729 RID: 55081 RVA: 0x004B79AC File Offset: 0x004B5BAC
			public virtual SubscribeResponse Subscribe(SubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Subscribe(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D72A RID: 55082 RVA: 0x004B79D4 File Offset: 0x004B5BD4
			public virtual SubscribeResponse Subscribe(SubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SubscribeRequest, SubscribeResponse>(ChannelService.__Method_Subscribe, null, options, request);
			}

			// Token: 0x0600D72B RID: 55083 RVA: 0x004B79FC File Offset: 0x004B5BFC
			public virtual AsyncUnaryCall<SubscribeResponse> SubscribeAsync(SubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SubscribeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D72C RID: 55084 RVA: 0x004B7A24 File Offset: 0x004B5C24
			public virtual AsyncUnaryCall<SubscribeResponse> SubscribeAsync(SubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SubscribeRequest, SubscribeResponse>(ChannelService.__Method_Subscribe, null, options, request);
			}

			// Token: 0x0600D72D RID: 55085 RVA: 0x004B7A4C File Offset: 0x004B5C4C
			public virtual NoData Unsubscribe(UnsubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Unsubscribe(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D72E RID: 55086 RVA: 0x004B7A74 File Offset: 0x004B5C74
			public virtual NoData Unsubscribe(UnsubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<UnsubscribeRequest, NoData>(ChannelService.__Method_Unsubscribe, null, options, request);
			}

			// Token: 0x0600D72F RID: 55087 RVA: 0x004B7A9C File Offset: 0x004B5C9C
			public virtual AsyncUnaryCall<NoData> UnsubscribeAsync(UnsubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UnsubscribeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D730 RID: 55088 RVA: 0x004B7AC4 File Offset: 0x004B5CC4
			public virtual AsyncUnaryCall<NoData> UnsubscribeAsync(UnsubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<UnsubscribeRequest, NoData>(ChannelService.__Method_Unsubscribe, null, options, request);
			}

			// Token: 0x0600D731 RID: 55089 RVA: 0x004B7AEC File Offset: 0x004B5CEC
			public virtual NoData SetAttribute(SetAttributeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SetAttribute(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D732 RID: 55090 RVA: 0x004B7B14 File Offset: 0x004B5D14
			public virtual NoData SetAttribute(SetAttributeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SetAttributeRequest, NoData>(ChannelService.__Method_SetAttribute, null, options, request);
			}

			// Token: 0x0600D733 RID: 55091 RVA: 0x004B7B3C File Offset: 0x004B5D3C
			public virtual AsyncUnaryCall<NoData> SetAttributeAsync(SetAttributeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SetAttributeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D734 RID: 55092 RVA: 0x004B7B64 File Offset: 0x004B5D64
			public virtual AsyncUnaryCall<NoData> SetAttributeAsync(SetAttributeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SetAttributeRequest, NoData>(ChannelService.__Method_SetAttribute, null, options, request);
			}

			// Token: 0x0600D735 RID: 55093 RVA: 0x004B7B8C File Offset: 0x004B5D8C
			public virtual NoData SetPrivacyLevel(SetPrivacyLevelRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SetPrivacyLevel(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D736 RID: 55094 RVA: 0x004B7BB4 File Offset: 0x004B5DB4
			public virtual NoData SetPrivacyLevel(SetPrivacyLevelRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SetPrivacyLevelRequest, NoData>(ChannelService.__Method_SetPrivacyLevel, null, options, request);
			}

			// Token: 0x0600D737 RID: 55095 RVA: 0x004B7BDC File Offset: 0x004B5DDC
			public virtual AsyncUnaryCall<NoData> SetPrivacyLevelAsync(SetPrivacyLevelRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SetPrivacyLevelAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D738 RID: 55096 RVA: 0x004B7C04 File Offset: 0x004B5E04
			public virtual AsyncUnaryCall<NoData> SetPrivacyLevelAsync(SetPrivacyLevelRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SetPrivacyLevelRequest, NoData>(ChannelService.__Method_SetPrivacyLevel, null, options, request);
			}

			// Token: 0x0600D739 RID: 55097 RVA: 0x004B7C2C File Offset: 0x004B5E2C
			public virtual NoData SendMessage(SendMessageRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SendMessage(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D73A RID: 55098 RVA: 0x004B7C54 File Offset: 0x004B5E54
			public virtual NoData SendMessage(SendMessageRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SendMessageRequest, NoData>(ChannelService.__Method_SendMessage, null, options, request);
			}

			// Token: 0x0600D73B RID: 55099 RVA: 0x004B7C7C File Offset: 0x004B5E7C
			public virtual AsyncUnaryCall<NoData> SendMessageAsync(SendMessageRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SendMessageAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D73C RID: 55100 RVA: 0x004B7CA4 File Offset: 0x004B5EA4
			public virtual AsyncUnaryCall<NoData> SendMessageAsync(SendMessageRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SendMessageRequest, NoData>(ChannelService.__Method_SendMessage, null, options, request);
			}

			// Token: 0x0600D73D RID: 55101 RVA: 0x004B7CCC File Offset: 0x004B5ECC
			public virtual NoData SetTypingIndicator(SetTypingIndicatorRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SetTypingIndicator(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D73E RID: 55102 RVA: 0x004B7CF4 File Offset: 0x004B5EF4
			public virtual NoData SetTypingIndicator(SetTypingIndicatorRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SetTypingIndicatorRequest, NoData>(ChannelService.__Method_SetTypingIndicator, null, options, request);
			}

			// Token: 0x0600D73F RID: 55103 RVA: 0x004B7D1C File Offset: 0x004B5F1C
			public virtual AsyncUnaryCall<NoData> SetTypingIndicatorAsync(SetTypingIndicatorRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SetTypingIndicatorAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D740 RID: 55104 RVA: 0x004B7D44 File Offset: 0x004B5F44
			public virtual AsyncUnaryCall<NoData> SetTypingIndicatorAsync(SetTypingIndicatorRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SetTypingIndicatorRequest, NoData>(ChannelService.__Method_SetTypingIndicator, null, options, request);
			}

			// Token: 0x0600D741 RID: 55105 RVA: 0x004B7D6C File Offset: 0x004B5F6C
			public virtual NoData Join(JoinRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Join(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D742 RID: 55106 RVA: 0x004B7D94 File Offset: 0x004B5F94
			public virtual NoData Join(JoinRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<JoinRequest, NoData>(ChannelService.__Method_Join, null, options, request);
			}

			// Token: 0x0600D743 RID: 55107 RVA: 0x004B7DBC File Offset: 0x004B5FBC
			public virtual AsyncUnaryCall<NoData> JoinAsync(JoinRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.JoinAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D744 RID: 55108 RVA: 0x004B7DE4 File Offset: 0x004B5FE4
			public virtual AsyncUnaryCall<NoData> JoinAsync(JoinRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<JoinRequest, NoData>(ChannelService.__Method_Join, null, options, request);
			}

			// Token: 0x0600D745 RID: 55109 RVA: 0x004B7E0C File Offset: 0x004B600C
			public virtual NoData Leave(LeaveRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Leave(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D746 RID: 55110 RVA: 0x004B7E34 File Offset: 0x004B6034
			public virtual NoData Leave(LeaveRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<LeaveRequest, NoData>(ChannelService.__Method_Leave, null, options, request);
			}

			// Token: 0x0600D747 RID: 55111 RVA: 0x004B7E5C File Offset: 0x004B605C
			public virtual AsyncUnaryCall<NoData> LeaveAsync(LeaveRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.LeaveAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D748 RID: 55112 RVA: 0x004B7E84 File Offset: 0x004B6084
			public virtual AsyncUnaryCall<NoData> LeaveAsync(LeaveRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<LeaveRequest, NoData>(ChannelService.__Method_Leave, null, options, request);
			}

			// Token: 0x0600D749 RID: 55113 RVA: 0x004B7EAC File Offset: 0x004B60AC
			public virtual NoData Kick(KickRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Kick(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D74A RID: 55114 RVA: 0x004B7ED4 File Offset: 0x004B60D4
			public virtual NoData Kick(KickRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<KickRequest, NoData>(ChannelService.__Method_Kick, null, options, request);
			}

			// Token: 0x0600D74B RID: 55115 RVA: 0x004B7EFC File Offset: 0x004B60FC
			public virtual AsyncUnaryCall<NoData> KickAsync(KickRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.KickAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D74C RID: 55116 RVA: 0x004B7F24 File Offset: 0x004B6124
			public virtual AsyncUnaryCall<NoData> KickAsync(KickRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<KickRequest, NoData>(ChannelService.__Method_Kick, null, options, request);
			}

			// Token: 0x0600D74D RID: 55117 RVA: 0x004B7F4C File Offset: 0x004B614C
			public virtual NoData SetMemberAttribute(SetMemberAttributeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SetMemberAttribute(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D74E RID: 55118 RVA: 0x004B7F74 File Offset: 0x004B6174
			public virtual NoData SetMemberAttribute(SetMemberAttributeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SetMemberAttributeRequest, NoData>(ChannelService.__Method_SetMemberAttribute, null, options, request);
			}

			// Token: 0x0600D74F RID: 55119 RVA: 0x004B7F9C File Offset: 0x004B619C
			public virtual AsyncUnaryCall<NoData> SetMemberAttributeAsync(SetMemberAttributeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SetMemberAttributeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D750 RID: 55120 RVA: 0x004B7FC4 File Offset: 0x004B61C4
			public virtual AsyncUnaryCall<NoData> SetMemberAttributeAsync(SetMemberAttributeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SetMemberAttributeRequest, NoData>(ChannelService.__Method_SetMemberAttribute, null, options, request);
			}

			// Token: 0x0600D751 RID: 55121 RVA: 0x004B7FEC File Offset: 0x004B61EC
			public virtual NoData AssignRole(AssignRoleRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.AssignRole(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D752 RID: 55122 RVA: 0x004B8014 File Offset: 0x004B6214
			public virtual NoData AssignRole(AssignRoleRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<AssignRoleRequest, NoData>(ChannelService.__Method_AssignRole, null, options, request);
			}

			// Token: 0x0600D753 RID: 55123 RVA: 0x004B803C File Offset: 0x004B623C
			public virtual AsyncUnaryCall<NoData> AssignRoleAsync(AssignRoleRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.AssignRoleAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D754 RID: 55124 RVA: 0x004B8064 File Offset: 0x004B6264
			public virtual AsyncUnaryCall<NoData> AssignRoleAsync(AssignRoleRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<AssignRoleRequest, NoData>(ChannelService.__Method_AssignRole, null, options, request);
			}

			// Token: 0x0600D755 RID: 55125 RVA: 0x004B808C File Offset: 0x004B628C
			public virtual NoData UnassignRole(UnassignRoleRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UnassignRole(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D756 RID: 55126 RVA: 0x004B80B4 File Offset: 0x004B62B4
			public virtual NoData UnassignRole(UnassignRoleRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<UnassignRoleRequest, NoData>(ChannelService.__Method_UnassignRole, null, options, request);
			}

			// Token: 0x0600D757 RID: 55127 RVA: 0x004B80DC File Offset: 0x004B62DC
			public virtual AsyncUnaryCall<NoData> UnassignRoleAsync(UnassignRoleRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UnassignRoleAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D758 RID: 55128 RVA: 0x004B8104 File Offset: 0x004B6304
			public virtual AsyncUnaryCall<NoData> UnassignRoleAsync(UnassignRoleRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<UnassignRoleRequest, NoData>(ChannelService.__Method_UnassignRole, null, options, request);
			}

			// Token: 0x0600D759 RID: 55129 RVA: 0x004B812C File Offset: 0x004B632C
			public virtual NoData SendInvitation(SendInvitationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SendInvitation(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D75A RID: 55130 RVA: 0x004B8154 File Offset: 0x004B6354
			public virtual NoData SendInvitation(SendInvitationRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SendInvitationRequest, NoData>(ChannelService.__Method_SendInvitation, null, options, request);
			}

			// Token: 0x0600D75B RID: 55131 RVA: 0x004B817C File Offset: 0x004B637C
			public virtual AsyncUnaryCall<NoData> SendInvitationAsync(SendInvitationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SendInvitationAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D75C RID: 55132 RVA: 0x004B81A4 File Offset: 0x004B63A4
			public virtual AsyncUnaryCall<NoData> SendInvitationAsync(SendInvitationRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SendInvitationRequest, NoData>(ChannelService.__Method_SendInvitation, null, options, request);
			}

			// Token: 0x0600D75D RID: 55133 RVA: 0x004B81CC File Offset: 0x004B63CC
			public virtual NoData AcceptInvitation(AcceptInvitationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.AcceptInvitation(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D75E RID: 55134 RVA: 0x004B81F4 File Offset: 0x004B63F4
			public virtual NoData AcceptInvitation(AcceptInvitationRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<AcceptInvitationRequest, NoData>(ChannelService.__Method_AcceptInvitation, null, options, request);
			}

			// Token: 0x0600D75F RID: 55135 RVA: 0x004B821C File Offset: 0x004B641C
			public virtual AsyncUnaryCall<NoData> AcceptInvitationAsync(AcceptInvitationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.AcceptInvitationAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D760 RID: 55136 RVA: 0x004B8244 File Offset: 0x004B6444
			public virtual AsyncUnaryCall<NoData> AcceptInvitationAsync(AcceptInvitationRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<AcceptInvitationRequest, NoData>(ChannelService.__Method_AcceptInvitation, null, options, request);
			}

			// Token: 0x0600D761 RID: 55137 RVA: 0x004B826C File Offset: 0x004B646C
			public virtual NoData DeclineInvitation(DeclineInvitationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.DeclineInvitation(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D762 RID: 55138 RVA: 0x004B8294 File Offset: 0x004B6494
			public virtual NoData DeclineInvitation(DeclineInvitationRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<DeclineInvitationRequest, NoData>(ChannelService.__Method_DeclineInvitation, null, options, request);
			}

			// Token: 0x0600D763 RID: 55139 RVA: 0x004B82BC File Offset: 0x004B64BC
			public virtual AsyncUnaryCall<NoData> DeclineInvitationAsync(DeclineInvitationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.DeclineInvitationAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D764 RID: 55140 RVA: 0x004B82E4 File Offset: 0x004B64E4
			public virtual AsyncUnaryCall<NoData> DeclineInvitationAsync(DeclineInvitationRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<DeclineInvitationRequest, NoData>(ChannelService.__Method_DeclineInvitation, null, options, request);
			}

			// Token: 0x0600D765 RID: 55141 RVA: 0x004B830C File Offset: 0x004B650C
			public virtual NoData RevokeInvitation(RevokeInvitationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.RevokeInvitation(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D766 RID: 55142 RVA: 0x004B8334 File Offset: 0x004B6534
			public virtual NoData RevokeInvitation(RevokeInvitationRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<RevokeInvitationRequest, NoData>(ChannelService.__Method_RevokeInvitation, null, options, request);
			}

			// Token: 0x0600D767 RID: 55143 RVA: 0x004B835C File Offset: 0x004B655C
			public virtual AsyncUnaryCall<NoData> RevokeInvitationAsync(RevokeInvitationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.RevokeInvitationAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D768 RID: 55144 RVA: 0x004B8384 File Offset: 0x004B6584
			public virtual AsyncUnaryCall<NoData> RevokeInvitationAsync(RevokeInvitationRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<RevokeInvitationRequest, NoData>(ChannelService.__Method_RevokeInvitation, null, options, request);
			}

			// Token: 0x0600D769 RID: 55145 RVA: 0x004B83AC File Offset: 0x004B65AC
			public virtual NoData SendSuggestion(SendSuggestionRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SendSuggestion(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D76A RID: 55146 RVA: 0x004B83D4 File Offset: 0x004B65D4
			public virtual NoData SendSuggestion(SendSuggestionRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SendSuggestionRequest, NoData>(ChannelService.__Method_SendSuggestion, null, options, request);
			}

			// Token: 0x0600D76B RID: 55147 RVA: 0x004B83FC File Offset: 0x004B65FC
			public virtual AsyncUnaryCall<NoData> SendSuggestionAsync(SendSuggestionRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SendSuggestionAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D76C RID: 55148 RVA: 0x004B8424 File Offset: 0x004B6624
			public virtual AsyncUnaryCall<NoData> SendSuggestionAsync(SendSuggestionRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SendSuggestionRequest, NoData>(ChannelService.__Method_SendSuggestion, null, options, request);
			}

			// Token: 0x0600D76D RID: 55149 RVA: 0x004B844C File Offset: 0x004B664C
			public virtual GetJoinVoiceTokenResponse GetJoinVoiceToken(GetJoinVoiceTokenRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetJoinVoiceToken(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D76E RID: 55150 RVA: 0x004B8474 File Offset: 0x004B6674
			public virtual GetJoinVoiceTokenResponse GetJoinVoiceToken(GetJoinVoiceTokenRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetJoinVoiceTokenRequest, GetJoinVoiceTokenResponse>(ChannelService.__Method_GetJoinVoiceToken, null, options, request);
			}

			// Token: 0x0600D76F RID: 55151 RVA: 0x004B849C File Offset: 0x004B669C
			public virtual AsyncUnaryCall<GetJoinVoiceTokenResponse> GetJoinVoiceTokenAsync(GetJoinVoiceTokenRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetJoinVoiceTokenAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D770 RID: 55152 RVA: 0x004B84C4 File Offset: 0x004B66C4
			public virtual AsyncUnaryCall<GetJoinVoiceTokenResponse> GetJoinVoiceTokenAsync(GetJoinVoiceTokenRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetJoinVoiceTokenRequest, GetJoinVoiceTokenResponse>(ChannelService.__Method_GetJoinVoiceToken, null, options, request);
			}

			// Token: 0x0600D771 RID: 55153 RVA: 0x004B84EC File Offset: 0x004B66EC
			protected override ChannelService.ChannelServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new ChannelService.ChannelServiceClient(configuration);
			}
		}
	}
}
