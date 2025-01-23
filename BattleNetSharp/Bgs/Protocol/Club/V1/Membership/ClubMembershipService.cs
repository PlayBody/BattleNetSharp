using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Club.V1.Membership
{
	// Token: 0x02000523 RID: 1315
	public static class ClubMembershipService
	{
		// Token: 0x06007FC5 RID: 32709 RVA: 0x001F15F0 File Offset: 0x001EF7F0
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

		// Token: 0x06007FC6 RID: 32710 RVA: 0x001F163C File Offset: 0x001EF83C
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = ClubMembershipService.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17002876 RID: 10358
		// (get) Token: 0x06007FC7 RID: 32711 RVA: 0x001F1674 File Offset: 0x001EF874
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return ClubMembershipServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x06007FC8 RID: 32712 RVA: 0x001F1698 File Offset: 0x001EF898
		public static ServerServiceDefinition BindService(ClubMembershipService.ClubMembershipServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<SubscribeRequest, SubscribeResponse>(ClubMembershipService.__Method_Subscribe, new UnaryServerMethod<SubscribeRequest, SubscribeResponse>(serviceImpl.Subscribe)).AddMethod<UnsubscribeRequest, NoData>(ClubMembershipService.__Method_Unsubscribe, new UnaryServerMethod<UnsubscribeRequest, NoData>(serviceImpl.Unsubscribe))
				.AddMethod<GetStateRequest, GetStateResponse>(ClubMembershipService.__Method_GetState, new UnaryServerMethod<GetStateRequest, GetStateResponse>(serviceImpl.GetState))
				.AddMethod<UpdateClubSharedSettingsRequest, NoData>(ClubMembershipService.__Method_UpdateClubSharedSettings, new UnaryServerMethod<UpdateClubSharedSettingsRequest, NoData>(serviceImpl.UpdateClubSharedSettings))
				.AddMethod<GetStreamMentionsRequest, GetStreamMentionsResponse>(ClubMembershipService.__Method_GetStreamMentions, new UnaryServerMethod<GetStreamMentionsRequest, GetStreamMentionsResponse>(serviceImpl.GetStreamMentions))
				.AddMethod<RemoveStreamMentionsRequest, NoData>(ClubMembershipService.__Method_RemoveStreamMentions, new UnaryServerMethod<RemoveStreamMentionsRequest, NoData>(serviceImpl.RemoveStreamMentions))
				.AddMethod<AdvanceStreamMentionViewTimeRequest, NoData>(ClubMembershipService.__Method_AdvanceStreamMentionViewTime, new UnaryServerMethod<AdvanceStreamMentionViewTimeRequest, NoData>(serviceImpl.AdvanceStreamMentionViewTime))
				.Build();
		}

		// Token: 0x06007FC9 RID: 32713 RVA: 0x001F1758 File Offset: 0x001EF958
		public static void BindService(ServiceBinderBase serviceBinder, ClubMembershipService.ClubMembershipServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<SubscribeRequest, SubscribeResponse>(ClubMembershipService.__Method_Subscribe, (serviceImpl == null) ? null : new UnaryServerMethod<SubscribeRequest, SubscribeResponse>(serviceImpl.Subscribe));
			serviceBinder.AddMethod<UnsubscribeRequest, NoData>(ClubMembershipService.__Method_Unsubscribe, (serviceImpl == null) ? null : new UnaryServerMethod<UnsubscribeRequest, NoData>(serviceImpl.Unsubscribe));
			serviceBinder.AddMethod<GetStateRequest, GetStateResponse>(ClubMembershipService.__Method_GetState, (serviceImpl == null) ? null : new UnaryServerMethod<GetStateRequest, GetStateResponse>(serviceImpl.GetState));
			serviceBinder.AddMethod<UpdateClubSharedSettingsRequest, NoData>(ClubMembershipService.__Method_UpdateClubSharedSettings, (serviceImpl == null) ? null : new UnaryServerMethod<UpdateClubSharedSettingsRequest, NoData>(serviceImpl.UpdateClubSharedSettings));
			serviceBinder.AddMethod<GetStreamMentionsRequest, GetStreamMentionsResponse>(ClubMembershipService.__Method_GetStreamMentions, (serviceImpl == null) ? null : new UnaryServerMethod<GetStreamMentionsRequest, GetStreamMentionsResponse>(serviceImpl.GetStreamMentions));
			serviceBinder.AddMethod<RemoveStreamMentionsRequest, NoData>(ClubMembershipService.__Method_RemoveStreamMentions, (serviceImpl == null) ? null : new UnaryServerMethod<RemoveStreamMentionsRequest, NoData>(serviceImpl.RemoveStreamMentions));
			serviceBinder.AddMethod<AdvanceStreamMentionViewTimeRequest, NoData>(ClubMembershipService.__Method_AdvanceStreamMentionViewTime, (serviceImpl == null) ? null : new UnaryServerMethod<AdvanceStreamMentionViewTimeRequest, NoData>(serviceImpl.AdvanceStreamMentionViewTime));
		}

		// Token: 0x040039F8 RID: 14840
		private static readonly string __ServiceName = "bgs.protocol.club.v1.membership.ClubMembershipService";

		// Token: 0x040039F9 RID: 14841
		private static readonly Marshaller<SubscribeRequest> __Marshaller_bgs_protocol_club_v1_membership_SubscribeRequest = Marshallers.Create<SubscribeRequest>(new Action<SubscribeRequest, SerializationContext>(ClubMembershipService.__Helper_SerializeMessage), (DeserializationContext context) => ClubMembershipService.__Helper_DeserializeMessage<SubscribeRequest>(context, SubscribeRequest.Parser));

		// Token: 0x040039FA RID: 14842
		private static readonly Marshaller<SubscribeResponse> __Marshaller_bgs_protocol_club_v1_membership_SubscribeResponse = Marshallers.Create<SubscribeResponse>(new Action<SubscribeResponse, SerializationContext>(ClubMembershipService.__Helper_SerializeMessage), (DeserializationContext context) => ClubMembershipService.__Helper_DeserializeMessage<SubscribeResponse>(context, SubscribeResponse.Parser));

		// Token: 0x040039FB RID: 14843
		private static readonly Marshaller<UnsubscribeRequest> __Marshaller_bgs_protocol_club_v1_membership_UnsubscribeRequest = Marshallers.Create<UnsubscribeRequest>(new Action<UnsubscribeRequest, SerializationContext>(ClubMembershipService.__Helper_SerializeMessage), (DeserializationContext context) => ClubMembershipService.__Helper_DeserializeMessage<UnsubscribeRequest>(context, UnsubscribeRequest.Parser));

		// Token: 0x040039FC RID: 14844
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(ClubMembershipService.__Helper_SerializeMessage), (DeserializationContext context) => ClubMembershipService.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x040039FD RID: 14845
		private static readonly Marshaller<GetStateRequest> __Marshaller_bgs_protocol_club_v1_membership_GetStateRequest = Marshallers.Create<GetStateRequest>(new Action<GetStateRequest, SerializationContext>(ClubMembershipService.__Helper_SerializeMessage), (DeserializationContext context) => ClubMembershipService.__Helper_DeserializeMessage<GetStateRequest>(context, GetStateRequest.Parser));

		// Token: 0x040039FE RID: 14846
		private static readonly Marshaller<GetStateResponse> __Marshaller_bgs_protocol_club_v1_membership_GetStateResponse = Marshallers.Create<GetStateResponse>(new Action<GetStateResponse, SerializationContext>(ClubMembershipService.__Helper_SerializeMessage), (DeserializationContext context) => ClubMembershipService.__Helper_DeserializeMessage<GetStateResponse>(context, GetStateResponse.Parser));

		// Token: 0x040039FF RID: 14847
		private static readonly Marshaller<UpdateClubSharedSettingsRequest> __Marshaller_bgs_protocol_club_v1_membership_UpdateClubSharedSettingsRequest = Marshallers.Create<UpdateClubSharedSettingsRequest>(new Action<UpdateClubSharedSettingsRequest, SerializationContext>(ClubMembershipService.__Helper_SerializeMessage), (DeserializationContext context) => ClubMembershipService.__Helper_DeserializeMessage<UpdateClubSharedSettingsRequest>(context, UpdateClubSharedSettingsRequest.Parser));

		// Token: 0x04003A00 RID: 14848
		private static readonly Marshaller<GetStreamMentionsRequest> __Marshaller_bgs_protocol_club_v1_membership_GetStreamMentionsRequest = Marshallers.Create<GetStreamMentionsRequest>(new Action<GetStreamMentionsRequest, SerializationContext>(ClubMembershipService.__Helper_SerializeMessage), (DeserializationContext context) => ClubMembershipService.__Helper_DeserializeMessage<GetStreamMentionsRequest>(context, GetStreamMentionsRequest.Parser));

		// Token: 0x04003A01 RID: 14849
		private static readonly Marshaller<GetStreamMentionsResponse> __Marshaller_bgs_protocol_club_v1_membership_GetStreamMentionsResponse = Marshallers.Create<GetStreamMentionsResponse>(new Action<GetStreamMentionsResponse, SerializationContext>(ClubMembershipService.__Helper_SerializeMessage), (DeserializationContext context) => ClubMembershipService.__Helper_DeserializeMessage<GetStreamMentionsResponse>(context, GetStreamMentionsResponse.Parser));

		// Token: 0x04003A02 RID: 14850
		private static readonly Marshaller<RemoveStreamMentionsRequest> __Marshaller_bgs_protocol_club_v1_membership_RemoveStreamMentionsRequest = Marshallers.Create<RemoveStreamMentionsRequest>(new Action<RemoveStreamMentionsRequest, SerializationContext>(ClubMembershipService.__Helper_SerializeMessage), (DeserializationContext context) => ClubMembershipService.__Helper_DeserializeMessage<RemoveStreamMentionsRequest>(context, RemoveStreamMentionsRequest.Parser));

		// Token: 0x04003A03 RID: 14851
		private static readonly Marshaller<AdvanceStreamMentionViewTimeRequest> __Marshaller_bgs_protocol_club_v1_membership_AdvanceStreamMentionViewTimeRequest = Marshallers.Create<AdvanceStreamMentionViewTimeRequest>(new Action<AdvanceStreamMentionViewTimeRequest, SerializationContext>(ClubMembershipService.__Helper_SerializeMessage), (DeserializationContext context) => ClubMembershipService.__Helper_DeserializeMessage<AdvanceStreamMentionViewTimeRequest>(context, AdvanceStreamMentionViewTimeRequest.Parser));

		// Token: 0x04003A04 RID: 14852
		private static readonly Method<SubscribeRequest, SubscribeResponse> __Method_Subscribe = new Method<SubscribeRequest, SubscribeResponse>(0, ClubMembershipService.__ServiceName, "Subscribe", ClubMembershipService.__Marshaller_bgs_protocol_club_v1_membership_SubscribeRequest, ClubMembershipService.__Marshaller_bgs_protocol_club_v1_membership_SubscribeResponse);

		// Token: 0x04003A05 RID: 14853
		private static readonly Method<UnsubscribeRequest, NoData> __Method_Unsubscribe = new Method<UnsubscribeRequest, NoData>(0, ClubMembershipService.__ServiceName, "Unsubscribe", ClubMembershipService.__Marshaller_bgs_protocol_club_v1_membership_UnsubscribeRequest, ClubMembershipService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04003A06 RID: 14854
		private static readonly Method<GetStateRequest, GetStateResponse> __Method_GetState = new Method<GetStateRequest, GetStateResponse>(0, ClubMembershipService.__ServiceName, "GetState", ClubMembershipService.__Marshaller_bgs_protocol_club_v1_membership_GetStateRequest, ClubMembershipService.__Marshaller_bgs_protocol_club_v1_membership_GetStateResponse);

		// Token: 0x04003A07 RID: 14855
		private static readonly Method<UpdateClubSharedSettingsRequest, NoData> __Method_UpdateClubSharedSettings = new Method<UpdateClubSharedSettingsRequest, NoData>(0, ClubMembershipService.__ServiceName, "UpdateClubSharedSettings", ClubMembershipService.__Marshaller_bgs_protocol_club_v1_membership_UpdateClubSharedSettingsRequest, ClubMembershipService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04003A08 RID: 14856
		private static readonly Method<GetStreamMentionsRequest, GetStreamMentionsResponse> __Method_GetStreamMentions = new Method<GetStreamMentionsRequest, GetStreamMentionsResponse>(0, ClubMembershipService.__ServiceName, "GetStreamMentions", ClubMembershipService.__Marshaller_bgs_protocol_club_v1_membership_GetStreamMentionsRequest, ClubMembershipService.__Marshaller_bgs_protocol_club_v1_membership_GetStreamMentionsResponse);

		// Token: 0x04003A09 RID: 14857
		private static readonly Method<RemoveStreamMentionsRequest, NoData> __Method_RemoveStreamMentions = new Method<RemoveStreamMentionsRequest, NoData>(0, ClubMembershipService.__ServiceName, "RemoveStreamMentions", ClubMembershipService.__Marshaller_bgs_protocol_club_v1_membership_RemoveStreamMentionsRequest, ClubMembershipService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04003A0A RID: 14858
		private static readonly Method<AdvanceStreamMentionViewTimeRequest, NoData> __Method_AdvanceStreamMentionViewTime = new Method<AdvanceStreamMentionViewTimeRequest, NoData>(0, ClubMembershipService.__ServiceName, "AdvanceStreamMentionViewTime", ClubMembershipService.__Marshaller_bgs_protocol_club_v1_membership_AdvanceStreamMentionViewTimeRequest, ClubMembershipService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x02000FEB RID: 4075
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x04009740 RID: 38720
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02000FEC RID: 4076
		[BindServiceMethod(typeof(ClubMembershipService), "BindService")]
		public abstract class ClubMembershipServiceBase
		{
			// Token: 0x0600CFD4 RID: 53204 RVA: 0x004AECE7 File Offset: 0x004ACEE7
			public virtual Task<SubscribeResponse> Subscribe(SubscribeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CFD5 RID: 53205 RVA: 0x004AECFB File Offset: 0x004ACEFB
			public virtual Task<NoData> Unsubscribe(UnsubscribeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CFD6 RID: 53206 RVA: 0x004AED0F File Offset: 0x004ACF0F
			public virtual Task<GetStateResponse> GetState(GetStateRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CFD7 RID: 53207 RVA: 0x004AED23 File Offset: 0x004ACF23
			public virtual Task<NoData> UpdateClubSharedSettings(UpdateClubSharedSettingsRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CFD8 RID: 53208 RVA: 0x004AED37 File Offset: 0x004ACF37
			public virtual Task<GetStreamMentionsResponse> GetStreamMentions(GetStreamMentionsRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CFD9 RID: 53209 RVA: 0x004AED4B File Offset: 0x004ACF4B
			public virtual Task<NoData> RemoveStreamMentions(RemoveStreamMentionsRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CFDA RID: 53210 RVA: 0x004AED5F File Offset: 0x004ACF5F
			public virtual Task<NoData> AdvanceStreamMentionViewTime(AdvanceStreamMentionViewTimeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x02000FED RID: 4077
		public class ClubMembershipServiceClient : ClientBase<ClubMembershipService.ClubMembershipServiceClient>
		{
			// Token: 0x0600CFDC RID: 53212 RVA: 0x004AED7C File Offset: 0x004ACF7C
			public ClubMembershipServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600CFDD RID: 53213 RVA: 0x004AED87 File Offset: 0x004ACF87
			public ClubMembershipServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600CFDE RID: 53214 RVA: 0x004AED92 File Offset: 0x004ACF92
			protected ClubMembershipServiceClient()
			{
			}

			// Token: 0x0600CFDF RID: 53215 RVA: 0x004AED9C File Offset: 0x004ACF9C
			protected ClubMembershipServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600CFE0 RID: 53216 RVA: 0x004AEDA8 File Offset: 0x004ACFA8
			public virtual SubscribeResponse Subscribe(SubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Subscribe(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CFE1 RID: 53217 RVA: 0x004AEDD0 File Offset: 0x004ACFD0
			public virtual SubscribeResponse Subscribe(SubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SubscribeRequest, SubscribeResponse>(ClubMembershipService.__Method_Subscribe, null, options, request);
			}

			// Token: 0x0600CFE2 RID: 53218 RVA: 0x004AEDF8 File Offset: 0x004ACFF8
			public virtual AsyncUnaryCall<SubscribeResponse> SubscribeAsync(SubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SubscribeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CFE3 RID: 53219 RVA: 0x004AEE20 File Offset: 0x004AD020
			public virtual AsyncUnaryCall<SubscribeResponse> SubscribeAsync(SubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SubscribeRequest, SubscribeResponse>(ClubMembershipService.__Method_Subscribe, null, options, request);
			}

			// Token: 0x0600CFE4 RID: 53220 RVA: 0x004AEE48 File Offset: 0x004AD048
			public virtual NoData Unsubscribe(UnsubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Unsubscribe(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CFE5 RID: 53221 RVA: 0x004AEE70 File Offset: 0x004AD070
			public virtual NoData Unsubscribe(UnsubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<UnsubscribeRequest, NoData>(ClubMembershipService.__Method_Unsubscribe, null, options, request);
			}

			// Token: 0x0600CFE6 RID: 53222 RVA: 0x004AEE98 File Offset: 0x004AD098
			public virtual AsyncUnaryCall<NoData> UnsubscribeAsync(UnsubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UnsubscribeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CFE7 RID: 53223 RVA: 0x004AEEC0 File Offset: 0x004AD0C0
			public virtual AsyncUnaryCall<NoData> UnsubscribeAsync(UnsubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<UnsubscribeRequest, NoData>(ClubMembershipService.__Method_Unsubscribe, null, options, request);
			}

			// Token: 0x0600CFE8 RID: 53224 RVA: 0x004AEEE8 File Offset: 0x004AD0E8
			public virtual GetStateResponse GetState(GetStateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetState(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CFE9 RID: 53225 RVA: 0x004AEF10 File Offset: 0x004AD110
			public virtual GetStateResponse GetState(GetStateRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetStateRequest, GetStateResponse>(ClubMembershipService.__Method_GetState, null, options, request);
			}

			// Token: 0x0600CFEA RID: 53226 RVA: 0x004AEF38 File Offset: 0x004AD138
			public virtual AsyncUnaryCall<GetStateResponse> GetStateAsync(GetStateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetStateAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CFEB RID: 53227 RVA: 0x004AEF60 File Offset: 0x004AD160
			public virtual AsyncUnaryCall<GetStateResponse> GetStateAsync(GetStateRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetStateRequest, GetStateResponse>(ClubMembershipService.__Method_GetState, null, options, request);
			}

			// Token: 0x0600CFEC RID: 53228 RVA: 0x004AEF88 File Offset: 0x004AD188
			public virtual NoData UpdateClubSharedSettings(UpdateClubSharedSettingsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UpdateClubSharedSettings(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CFED RID: 53229 RVA: 0x004AEFB0 File Offset: 0x004AD1B0
			public virtual NoData UpdateClubSharedSettings(UpdateClubSharedSettingsRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<UpdateClubSharedSettingsRequest, NoData>(ClubMembershipService.__Method_UpdateClubSharedSettings, null, options, request);
			}

			// Token: 0x0600CFEE RID: 53230 RVA: 0x004AEFD8 File Offset: 0x004AD1D8
			public virtual AsyncUnaryCall<NoData> UpdateClubSharedSettingsAsync(UpdateClubSharedSettingsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UpdateClubSharedSettingsAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CFEF RID: 53231 RVA: 0x004AF000 File Offset: 0x004AD200
			public virtual AsyncUnaryCall<NoData> UpdateClubSharedSettingsAsync(UpdateClubSharedSettingsRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<UpdateClubSharedSettingsRequest, NoData>(ClubMembershipService.__Method_UpdateClubSharedSettings, null, options, request);
			}

			// Token: 0x0600CFF0 RID: 53232 RVA: 0x004AF028 File Offset: 0x004AD228
			public virtual GetStreamMentionsResponse GetStreamMentions(GetStreamMentionsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetStreamMentions(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CFF1 RID: 53233 RVA: 0x004AF050 File Offset: 0x004AD250
			public virtual GetStreamMentionsResponse GetStreamMentions(GetStreamMentionsRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetStreamMentionsRequest, GetStreamMentionsResponse>(ClubMembershipService.__Method_GetStreamMentions, null, options, request);
			}

			// Token: 0x0600CFF2 RID: 53234 RVA: 0x004AF078 File Offset: 0x004AD278
			public virtual AsyncUnaryCall<GetStreamMentionsResponse> GetStreamMentionsAsync(GetStreamMentionsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetStreamMentionsAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CFF3 RID: 53235 RVA: 0x004AF0A0 File Offset: 0x004AD2A0
			public virtual AsyncUnaryCall<GetStreamMentionsResponse> GetStreamMentionsAsync(GetStreamMentionsRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetStreamMentionsRequest, GetStreamMentionsResponse>(ClubMembershipService.__Method_GetStreamMentions, null, options, request);
			}

			// Token: 0x0600CFF4 RID: 53236 RVA: 0x004AF0C8 File Offset: 0x004AD2C8
			public virtual NoData RemoveStreamMentions(RemoveStreamMentionsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.RemoveStreamMentions(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CFF5 RID: 53237 RVA: 0x004AF0F0 File Offset: 0x004AD2F0
			public virtual NoData RemoveStreamMentions(RemoveStreamMentionsRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<RemoveStreamMentionsRequest, NoData>(ClubMembershipService.__Method_RemoveStreamMentions, null, options, request);
			}

			// Token: 0x0600CFF6 RID: 53238 RVA: 0x004AF118 File Offset: 0x004AD318
			public virtual AsyncUnaryCall<NoData> RemoveStreamMentionsAsync(RemoveStreamMentionsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.RemoveStreamMentionsAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CFF7 RID: 53239 RVA: 0x004AF140 File Offset: 0x004AD340
			public virtual AsyncUnaryCall<NoData> RemoveStreamMentionsAsync(RemoveStreamMentionsRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<RemoveStreamMentionsRequest, NoData>(ClubMembershipService.__Method_RemoveStreamMentions, null, options, request);
			}

			// Token: 0x0600CFF8 RID: 53240 RVA: 0x004AF168 File Offset: 0x004AD368
			public virtual NoData AdvanceStreamMentionViewTime(AdvanceStreamMentionViewTimeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.AdvanceStreamMentionViewTime(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CFF9 RID: 53241 RVA: 0x004AF190 File Offset: 0x004AD390
			public virtual NoData AdvanceStreamMentionViewTime(AdvanceStreamMentionViewTimeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<AdvanceStreamMentionViewTimeRequest, NoData>(ClubMembershipService.__Method_AdvanceStreamMentionViewTime, null, options, request);
			}

			// Token: 0x0600CFFA RID: 53242 RVA: 0x004AF1B8 File Offset: 0x004AD3B8
			public virtual AsyncUnaryCall<NoData> AdvanceStreamMentionViewTimeAsync(AdvanceStreamMentionViewTimeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.AdvanceStreamMentionViewTimeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CFFB RID: 53243 RVA: 0x004AF1E0 File Offset: 0x004AD3E0
			public virtual AsyncUnaryCall<NoData> AdvanceStreamMentionViewTimeAsync(AdvanceStreamMentionViewTimeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<AdvanceStreamMentionViewTimeRequest, NoData>(ClubMembershipService.__Method_AdvanceStreamMentionViewTime, null, options, request);
			}

			// Token: 0x0600CFFC RID: 53244 RVA: 0x004AF208 File Offset: 0x004AD408
			protected override ClubMembershipService.ClubMembershipServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new ClubMembershipService.ClubMembershipServiceClient(configuration);
			}
		}
	}
}
