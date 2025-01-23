using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Friends.V1
{
	// Token: 0x02000416 RID: 1046
	public static class FriendsService
	{
		// Token: 0x0600673A RID: 26426 RVA: 0x0018EED0 File Offset: 0x0018D0D0
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

		// Token: 0x0600673B RID: 26427 RVA: 0x0018EF1C File Offset: 0x0018D11C
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = FriendsService.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17002101 RID: 8449
		// (get) Token: 0x0600673C RID: 26428 RVA: 0x0018EF54 File Offset: 0x0018D154
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x0600673D RID: 26429 RVA: 0x0018EF78 File Offset: 0x0018D178
		public static ServerServiceDefinition BindService(FriendsService.FriendsServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<SubscribeRequest, SubscribeResponse>(FriendsService.__Method_Subscribe, new UnaryServerMethod<SubscribeRequest, SubscribeResponse>(serviceImpl.Subscribe)).AddMethod<SendInvitationRequest, NoData>(FriendsService.__Method_SendInvitation, new UnaryServerMethod<SendInvitationRequest, NoData>(serviceImpl.SendInvitation))
				.AddMethod<AcceptInvitationRequest, NoData>(FriendsService.__Method_AcceptInvitation, new UnaryServerMethod<AcceptInvitationRequest, NoData>(serviceImpl.AcceptInvitation))
				.AddMethod<RevokeInvitationRequest, NoData>(FriendsService.__Method_RevokeInvitation, new UnaryServerMethod<RevokeInvitationRequest, NoData>(serviceImpl.RevokeInvitation))
				.AddMethod<DeclineInvitationRequest, NoData>(FriendsService.__Method_DeclineInvitation, new UnaryServerMethod<DeclineInvitationRequest, NoData>(serviceImpl.DeclineInvitation))
				.AddMethod<IgnoreInvitationRequest, NoData>(FriendsService.__Method_IgnoreInvitation, new UnaryServerMethod<IgnoreInvitationRequest, NoData>(serviceImpl.IgnoreInvitation))
				.AddMethod<RemoveFriendRequest, NoData>(FriendsService.__Method_RemoveFriend, new UnaryServerMethod<RemoveFriendRequest, NoData>(serviceImpl.RemoveFriend))
				.AddMethod<ViewFriendsRequest, ViewFriendsResponse>(FriendsService.__Method_ViewFriends, new UnaryServerMethod<ViewFriendsRequest, ViewFriendsResponse>(serviceImpl.ViewFriends))
				.AddMethod<UpdateFriendStateRequest, NoData>(FriendsService.__Method_UpdateFriendState, new UnaryServerMethod<UpdateFriendStateRequest, NoData>(serviceImpl.UpdateFriendState))
				.AddMethod<UnsubscribeRequest, NoData>(FriendsService.__Method_Unsubscribe, new UnaryServerMethod<UnsubscribeRequest, NoData>(serviceImpl.Unsubscribe))
				.AddMethod<RevokeAllInvitationsRequest, NoData>(FriendsService.__Method_RevokeAllInvitations, new UnaryServerMethod<RevokeAllInvitationsRequest, NoData>(serviceImpl.RevokeAllInvitations))
				.AddMethod<GetFriendListRequest, GetFriendListResponse>(FriendsService.__Method_GetFriendList, new UnaryServerMethod<GetFriendListRequest, GetFriendListResponse>(serviceImpl.GetFriendList))
				.AddMethod<CreateFriendshipRequest, NoData>(FriendsService.__Method_CreateFriendship, new UnaryServerMethod<CreateFriendshipRequest, NoData>(serviceImpl.CreateFriendship))
				.Build();
		}

		// Token: 0x0600673E RID: 26430 RVA: 0x0018F0C0 File Offset: 0x0018D2C0
		public static void BindService(ServiceBinderBase serviceBinder, FriendsService.FriendsServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<SubscribeRequest, SubscribeResponse>(FriendsService.__Method_Subscribe, (serviceImpl == null) ? null : new UnaryServerMethod<SubscribeRequest, SubscribeResponse>(serviceImpl.Subscribe));
			serviceBinder.AddMethod<SendInvitationRequest, NoData>(FriendsService.__Method_SendInvitation, (serviceImpl == null) ? null : new UnaryServerMethod<SendInvitationRequest, NoData>(serviceImpl.SendInvitation));
			serviceBinder.AddMethod<AcceptInvitationRequest, NoData>(FriendsService.__Method_AcceptInvitation, (serviceImpl == null) ? null : new UnaryServerMethod<AcceptInvitationRequest, NoData>(serviceImpl.AcceptInvitation));
			serviceBinder.AddMethod<RevokeInvitationRequest, NoData>(FriendsService.__Method_RevokeInvitation, (serviceImpl == null) ? null : new UnaryServerMethod<RevokeInvitationRequest, NoData>(serviceImpl.RevokeInvitation));
			serviceBinder.AddMethod<DeclineInvitationRequest, NoData>(FriendsService.__Method_DeclineInvitation, (serviceImpl == null) ? null : new UnaryServerMethod<DeclineInvitationRequest, NoData>(serviceImpl.DeclineInvitation));
			serviceBinder.AddMethod<IgnoreInvitationRequest, NoData>(FriendsService.__Method_IgnoreInvitation, (serviceImpl == null) ? null : new UnaryServerMethod<IgnoreInvitationRequest, NoData>(serviceImpl.IgnoreInvitation));
			serviceBinder.AddMethod<RemoveFriendRequest, NoData>(FriendsService.__Method_RemoveFriend, (serviceImpl == null) ? null : new UnaryServerMethod<RemoveFriendRequest, NoData>(serviceImpl.RemoveFriend));
			serviceBinder.AddMethod<ViewFriendsRequest, ViewFriendsResponse>(FriendsService.__Method_ViewFriends, (serviceImpl == null) ? null : new UnaryServerMethod<ViewFriendsRequest, ViewFriendsResponse>(serviceImpl.ViewFriends));
			serviceBinder.AddMethod<UpdateFriendStateRequest, NoData>(FriendsService.__Method_UpdateFriendState, (serviceImpl == null) ? null : new UnaryServerMethod<UpdateFriendStateRequest, NoData>(serviceImpl.UpdateFriendState));
			serviceBinder.AddMethod<UnsubscribeRequest, NoData>(FriendsService.__Method_Unsubscribe, (serviceImpl == null) ? null : new UnaryServerMethod<UnsubscribeRequest, NoData>(serviceImpl.Unsubscribe));
			serviceBinder.AddMethod<RevokeAllInvitationsRequest, NoData>(FriendsService.__Method_RevokeAllInvitations, (serviceImpl == null) ? null : new UnaryServerMethod<RevokeAllInvitationsRequest, NoData>(serviceImpl.RevokeAllInvitations));
			serviceBinder.AddMethod<GetFriendListRequest, GetFriendListResponse>(FriendsService.__Method_GetFriendList, (serviceImpl == null) ? null : new UnaryServerMethod<GetFriendListRequest, GetFriendListResponse>(serviceImpl.GetFriendList));
			serviceBinder.AddMethod<CreateFriendshipRequest, NoData>(FriendsService.__Method_CreateFriendship, (serviceImpl == null) ? null : new UnaryServerMethod<CreateFriendshipRequest, NoData>(serviceImpl.CreateFriendship));
		}

		// Token: 0x04002EC7 RID: 11975
		private static readonly string __ServiceName = "bgs.protocol.friends.v1.FriendsService";

		// Token: 0x04002EC8 RID: 11976
		private static readonly Marshaller<SubscribeRequest> __Marshaller_bgs_protocol_friends_v1_SubscribeRequest = Marshallers.Create<SubscribeRequest>(new Action<SubscribeRequest, SerializationContext>(FriendsService.__Helper_SerializeMessage), (DeserializationContext context) => FriendsService.__Helper_DeserializeMessage<SubscribeRequest>(context, SubscribeRequest.Parser));

		// Token: 0x04002EC9 RID: 11977
		private static readonly Marshaller<SubscribeResponse> __Marshaller_bgs_protocol_friends_v1_SubscribeResponse = Marshallers.Create<SubscribeResponse>(new Action<SubscribeResponse, SerializationContext>(FriendsService.__Helper_SerializeMessage), (DeserializationContext context) => FriendsService.__Helper_DeserializeMessage<SubscribeResponse>(context, SubscribeResponse.Parser));

		// Token: 0x04002ECA RID: 11978
		private static readonly Marshaller<SendInvitationRequest> __Marshaller_bgs_protocol_friends_v1_SendInvitationRequest = Marshallers.Create<SendInvitationRequest>(new Action<SendInvitationRequest, SerializationContext>(FriendsService.__Helper_SerializeMessage), (DeserializationContext context) => FriendsService.__Helper_DeserializeMessage<SendInvitationRequest>(context, SendInvitationRequest.Parser));

		// Token: 0x04002ECB RID: 11979
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(FriendsService.__Helper_SerializeMessage), (DeserializationContext context) => FriendsService.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x04002ECC RID: 11980
		private static readonly Marshaller<AcceptInvitationRequest> __Marshaller_bgs_protocol_friends_v1_AcceptInvitationRequest = Marshallers.Create<AcceptInvitationRequest>(new Action<AcceptInvitationRequest, SerializationContext>(FriendsService.__Helper_SerializeMessage), (DeserializationContext context) => FriendsService.__Helper_DeserializeMessage<AcceptInvitationRequest>(context, AcceptInvitationRequest.Parser));

		// Token: 0x04002ECD RID: 11981
		private static readonly Marshaller<RevokeInvitationRequest> __Marshaller_bgs_protocol_friends_v1_RevokeInvitationRequest = Marshallers.Create<RevokeInvitationRequest>(new Action<RevokeInvitationRequest, SerializationContext>(FriendsService.__Helper_SerializeMessage), (DeserializationContext context) => FriendsService.__Helper_DeserializeMessage<RevokeInvitationRequest>(context, RevokeInvitationRequest.Parser));

		// Token: 0x04002ECE RID: 11982
		private static readonly Marshaller<DeclineInvitationRequest> __Marshaller_bgs_protocol_friends_v1_DeclineInvitationRequest = Marshallers.Create<DeclineInvitationRequest>(new Action<DeclineInvitationRequest, SerializationContext>(FriendsService.__Helper_SerializeMessage), (DeserializationContext context) => FriendsService.__Helper_DeserializeMessage<DeclineInvitationRequest>(context, DeclineInvitationRequest.Parser));

		// Token: 0x04002ECF RID: 11983
		private static readonly Marshaller<IgnoreInvitationRequest> __Marshaller_bgs_protocol_friends_v1_IgnoreInvitationRequest = Marshallers.Create<IgnoreInvitationRequest>(new Action<IgnoreInvitationRequest, SerializationContext>(FriendsService.__Helper_SerializeMessage), (DeserializationContext context) => FriendsService.__Helper_DeserializeMessage<IgnoreInvitationRequest>(context, IgnoreInvitationRequest.Parser));

		// Token: 0x04002ED0 RID: 11984
		private static readonly Marshaller<RemoveFriendRequest> __Marshaller_bgs_protocol_friends_v1_RemoveFriendRequest = Marshallers.Create<RemoveFriendRequest>(new Action<RemoveFriendRequest, SerializationContext>(FriendsService.__Helper_SerializeMessage), (DeserializationContext context) => FriendsService.__Helper_DeserializeMessage<RemoveFriendRequest>(context, RemoveFriendRequest.Parser));

		// Token: 0x04002ED1 RID: 11985
		private static readonly Marshaller<ViewFriendsRequest> __Marshaller_bgs_protocol_friends_v1_ViewFriendsRequest = Marshallers.Create<ViewFriendsRequest>(new Action<ViewFriendsRequest, SerializationContext>(FriendsService.__Helper_SerializeMessage), (DeserializationContext context) => FriendsService.__Helper_DeserializeMessage<ViewFriendsRequest>(context, ViewFriendsRequest.Parser));

		// Token: 0x04002ED2 RID: 11986
		private static readonly Marshaller<ViewFriendsResponse> __Marshaller_bgs_protocol_friends_v1_ViewFriendsResponse = Marshallers.Create<ViewFriendsResponse>(new Action<ViewFriendsResponse, SerializationContext>(FriendsService.__Helper_SerializeMessage), (DeserializationContext context) => FriendsService.__Helper_DeserializeMessage<ViewFriendsResponse>(context, ViewFriendsResponse.Parser));

		// Token: 0x04002ED3 RID: 11987
		private static readonly Marshaller<UpdateFriendStateRequest> __Marshaller_bgs_protocol_friends_v1_UpdateFriendStateRequest = Marshallers.Create<UpdateFriendStateRequest>(new Action<UpdateFriendStateRequest, SerializationContext>(FriendsService.__Helper_SerializeMessage), (DeserializationContext context) => FriendsService.__Helper_DeserializeMessage<UpdateFriendStateRequest>(context, UpdateFriendStateRequest.Parser));

		// Token: 0x04002ED4 RID: 11988
		private static readonly Marshaller<UnsubscribeRequest> __Marshaller_bgs_protocol_friends_v1_UnsubscribeRequest = Marshallers.Create<UnsubscribeRequest>(new Action<UnsubscribeRequest, SerializationContext>(FriendsService.__Helper_SerializeMessage), (DeserializationContext context) => FriendsService.__Helper_DeserializeMessage<UnsubscribeRequest>(context, UnsubscribeRequest.Parser));

		// Token: 0x04002ED5 RID: 11989
		private static readonly Marshaller<RevokeAllInvitationsRequest> __Marshaller_bgs_protocol_friends_v1_RevokeAllInvitationsRequest = Marshallers.Create<RevokeAllInvitationsRequest>(new Action<RevokeAllInvitationsRequest, SerializationContext>(FriendsService.__Helper_SerializeMessage), (DeserializationContext context) => FriendsService.__Helper_DeserializeMessage<RevokeAllInvitationsRequest>(context, RevokeAllInvitationsRequest.Parser));

		// Token: 0x04002ED6 RID: 11990
		private static readonly Marshaller<GetFriendListRequest> __Marshaller_bgs_protocol_friends_v1_GetFriendListRequest = Marshallers.Create<GetFriendListRequest>(new Action<GetFriendListRequest, SerializationContext>(FriendsService.__Helper_SerializeMessage), (DeserializationContext context) => FriendsService.__Helper_DeserializeMessage<GetFriendListRequest>(context, GetFriendListRequest.Parser));

		// Token: 0x04002ED7 RID: 11991
		private static readonly Marshaller<GetFriendListResponse> __Marshaller_bgs_protocol_friends_v1_GetFriendListResponse = Marshallers.Create<GetFriendListResponse>(new Action<GetFriendListResponse, SerializationContext>(FriendsService.__Helper_SerializeMessage), (DeserializationContext context) => FriendsService.__Helper_DeserializeMessage<GetFriendListResponse>(context, GetFriendListResponse.Parser));

		// Token: 0x04002ED8 RID: 11992
		private static readonly Marshaller<CreateFriendshipRequest> __Marshaller_bgs_protocol_friends_v1_CreateFriendshipRequest = Marshallers.Create<CreateFriendshipRequest>(new Action<CreateFriendshipRequest, SerializationContext>(FriendsService.__Helper_SerializeMessage), (DeserializationContext context) => FriendsService.__Helper_DeserializeMessage<CreateFriendshipRequest>(context, CreateFriendshipRequest.Parser));

		// Token: 0x04002ED9 RID: 11993
		private static readonly Method<SubscribeRequest, SubscribeResponse> __Method_Subscribe = new Method<SubscribeRequest, SubscribeResponse>(0, FriendsService.__ServiceName, "Subscribe", FriendsService.__Marshaller_bgs_protocol_friends_v1_SubscribeRequest, FriendsService.__Marshaller_bgs_protocol_friends_v1_SubscribeResponse);

		// Token: 0x04002EDA RID: 11994
		private static readonly Method<SendInvitationRequest, NoData> __Method_SendInvitation = new Method<SendInvitationRequest, NoData>(0, FriendsService.__ServiceName, "SendInvitation", FriendsService.__Marshaller_bgs_protocol_friends_v1_SendInvitationRequest, FriendsService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04002EDB RID: 11995
		private static readonly Method<AcceptInvitationRequest, NoData> __Method_AcceptInvitation = new Method<AcceptInvitationRequest, NoData>(0, FriendsService.__ServiceName, "AcceptInvitation", FriendsService.__Marshaller_bgs_protocol_friends_v1_AcceptInvitationRequest, FriendsService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04002EDC RID: 11996
		private static readonly Method<RevokeInvitationRequest, NoData> __Method_RevokeInvitation = new Method<RevokeInvitationRequest, NoData>(0, FriendsService.__ServiceName, "RevokeInvitation", FriendsService.__Marshaller_bgs_protocol_friends_v1_RevokeInvitationRequest, FriendsService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04002EDD RID: 11997
		private static readonly Method<DeclineInvitationRequest, NoData> __Method_DeclineInvitation = new Method<DeclineInvitationRequest, NoData>(0, FriendsService.__ServiceName, "DeclineInvitation", FriendsService.__Marshaller_bgs_protocol_friends_v1_DeclineInvitationRequest, FriendsService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04002EDE RID: 11998
		private static readonly Method<IgnoreInvitationRequest, NoData> __Method_IgnoreInvitation = new Method<IgnoreInvitationRequest, NoData>(0, FriendsService.__ServiceName, "IgnoreInvitation", FriendsService.__Marshaller_bgs_protocol_friends_v1_IgnoreInvitationRequest, FriendsService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04002EDF RID: 11999
		private static readonly Method<RemoveFriendRequest, NoData> __Method_RemoveFriend = new Method<RemoveFriendRequest, NoData>(0, FriendsService.__ServiceName, "RemoveFriend", FriendsService.__Marshaller_bgs_protocol_friends_v1_RemoveFriendRequest, FriendsService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04002EE0 RID: 12000
		private static readonly Method<ViewFriendsRequest, ViewFriendsResponse> __Method_ViewFriends = new Method<ViewFriendsRequest, ViewFriendsResponse>(0, FriendsService.__ServiceName, "ViewFriends", FriendsService.__Marshaller_bgs_protocol_friends_v1_ViewFriendsRequest, FriendsService.__Marshaller_bgs_protocol_friends_v1_ViewFriendsResponse);

		// Token: 0x04002EE1 RID: 12001
		private static readonly Method<UpdateFriendStateRequest, NoData> __Method_UpdateFriendState = new Method<UpdateFriendStateRequest, NoData>(0, FriendsService.__ServiceName, "UpdateFriendState", FriendsService.__Marshaller_bgs_protocol_friends_v1_UpdateFriendStateRequest, FriendsService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04002EE2 RID: 12002
		private static readonly Method<UnsubscribeRequest, NoData> __Method_Unsubscribe = new Method<UnsubscribeRequest, NoData>(0, FriendsService.__ServiceName, "Unsubscribe", FriendsService.__Marshaller_bgs_protocol_friends_v1_UnsubscribeRequest, FriendsService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04002EE3 RID: 12003
		private static readonly Method<RevokeAllInvitationsRequest, NoData> __Method_RevokeAllInvitations = new Method<RevokeAllInvitationsRequest, NoData>(0, FriendsService.__ServiceName, "RevokeAllInvitations", FriendsService.__Marshaller_bgs_protocol_friends_v1_RevokeAllInvitationsRequest, FriendsService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04002EE4 RID: 12004
		private static readonly Method<GetFriendListRequest, GetFriendListResponse> __Method_GetFriendList = new Method<GetFriendListRequest, GetFriendListResponse>(0, FriendsService.__ServiceName, "GetFriendList", FriendsService.__Marshaller_bgs_protocol_friends_v1_GetFriendListRequest, FriendsService.__Marshaller_bgs_protocol_friends_v1_GetFriendListResponse);

		// Token: 0x04002EE5 RID: 12005
		private static readonly Method<CreateFriendshipRequest, NoData> __Method_CreateFriendship = new Method<CreateFriendshipRequest, NoData>(0, FriendsService.__ServiceName, "CreateFriendship", FriendsService.__Marshaller_bgs_protocol_friends_v1_CreateFriendshipRequest, FriendsService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x02000EF0 RID: 3824
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x0400964F RID: 38479
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02000EF1 RID: 3825
		[BindServiceMethod(typeof(FriendsService), "BindService")]
		public abstract class FriendsServiceBase
		{
			// Token: 0x0600CC03 RID: 52227 RVA: 0x004AB3CC File Offset: 0x004A95CC
			public virtual Task<SubscribeResponse> Subscribe(SubscribeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600CC04 RID: 52228 RVA: 0x004AB3E0 File Offset: 0x004A95E0
			public virtual Task<NoData> SendInvitation(SendInvitationRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600CC05 RID: 52229 RVA: 0x004AB3F4 File Offset: 0x004A95F4
			public virtual Task<NoData> AcceptInvitation(AcceptInvitationRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600CC06 RID: 52230 RVA: 0x004AB408 File Offset: 0x004A9608
			public virtual Task<NoData> RevokeInvitation(RevokeInvitationRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600CC07 RID: 52231 RVA: 0x004AB41C File Offset: 0x004A961C
			public virtual Task<NoData> DeclineInvitation(DeclineInvitationRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600CC08 RID: 52232 RVA: 0x004AB430 File Offset: 0x004A9630
			public virtual Task<NoData> IgnoreInvitation(IgnoreInvitationRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600CC09 RID: 52233 RVA: 0x004AB444 File Offset: 0x004A9644
			public virtual Task<NoData> RemoveFriend(RemoveFriendRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600CC0A RID: 52234 RVA: 0x004AB458 File Offset: 0x004A9658
			public virtual Task<ViewFriendsResponse> ViewFriends(ViewFriendsRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600CC0B RID: 52235 RVA: 0x004AB46C File Offset: 0x004A966C
			public virtual Task<NoData> UpdateFriendState(UpdateFriendStateRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600CC0C RID: 52236 RVA: 0x004AB480 File Offset: 0x004A9680
			public virtual Task<NoData> Unsubscribe(UnsubscribeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600CC0D RID: 52237 RVA: 0x004AB494 File Offset: 0x004A9694
			public virtual Task<NoData> RevokeAllInvitations(RevokeAllInvitationsRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600CC0E RID: 52238 RVA: 0x004AB4A8 File Offset: 0x004A96A8
			public virtual Task<GetFriendListResponse> GetFriendList(GetFriendListRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600CC0F RID: 52239 RVA: 0x004AB4BC File Offset: 0x004A96BC
			public virtual Task<NoData> CreateFriendship(CreateFriendshipRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x02000EF2 RID: 3826
		public class FriendsServiceClient : ClientBase<FriendsService.FriendsServiceClient>
		{
			// Token: 0x0600CC11 RID: 52241 RVA: 0x004AB4D9 File Offset: 0x004A96D9
			public FriendsServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600CC12 RID: 52242 RVA: 0x004AB4E4 File Offset: 0x004A96E4
			public FriendsServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600CC13 RID: 52243 RVA: 0x004AB4EF File Offset: 0x004A96EF
			protected FriendsServiceClient()
			{
			}

			// Token: 0x0600CC14 RID: 52244 RVA: 0x004AB4F9 File Offset: 0x004A96F9
			protected FriendsServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600CC15 RID: 52245 RVA: 0x004AB504 File Offset: 0x004A9704
			public virtual SubscribeResponse Subscribe(SubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Subscribe(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC16 RID: 52246 RVA: 0x004AB52C File Offset: 0x004A972C
			public virtual SubscribeResponse Subscribe(SubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SubscribeRequest, SubscribeResponse>(FriendsService.__Method_Subscribe, null, options, request);
			}

			// Token: 0x0600CC17 RID: 52247 RVA: 0x004AB554 File Offset: 0x004A9754
			public virtual AsyncUnaryCall<SubscribeResponse> SubscribeAsync(SubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SubscribeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC18 RID: 52248 RVA: 0x004AB57C File Offset: 0x004A977C
			public virtual AsyncUnaryCall<SubscribeResponse> SubscribeAsync(SubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SubscribeRequest, SubscribeResponse>(FriendsService.__Method_Subscribe, null, options, request);
			}

			// Token: 0x0600CC19 RID: 52249 RVA: 0x004AB5A4 File Offset: 0x004A97A4
			public virtual NoData SendInvitation(SendInvitationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SendInvitation(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC1A RID: 52250 RVA: 0x004AB5CC File Offset: 0x004A97CC
			public virtual NoData SendInvitation(SendInvitationRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SendInvitationRequest, NoData>(FriendsService.__Method_SendInvitation, null, options, request);
			}

			// Token: 0x0600CC1B RID: 52251 RVA: 0x004AB5F4 File Offset: 0x004A97F4
			public virtual AsyncUnaryCall<NoData> SendInvitationAsync(SendInvitationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SendInvitationAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC1C RID: 52252 RVA: 0x004AB61C File Offset: 0x004A981C
			public virtual AsyncUnaryCall<NoData> SendInvitationAsync(SendInvitationRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SendInvitationRequest, NoData>(FriendsService.__Method_SendInvitation, null, options, request);
			}

			// Token: 0x0600CC1D RID: 52253 RVA: 0x004AB644 File Offset: 0x004A9844
			public virtual NoData AcceptInvitation(AcceptInvitationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.AcceptInvitation(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC1E RID: 52254 RVA: 0x004AB66C File Offset: 0x004A986C
			public virtual NoData AcceptInvitation(AcceptInvitationRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<AcceptInvitationRequest, NoData>(FriendsService.__Method_AcceptInvitation, null, options, request);
			}

			// Token: 0x0600CC1F RID: 52255 RVA: 0x004AB694 File Offset: 0x004A9894
			public virtual AsyncUnaryCall<NoData> AcceptInvitationAsync(AcceptInvitationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.AcceptInvitationAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC20 RID: 52256 RVA: 0x004AB6BC File Offset: 0x004A98BC
			public virtual AsyncUnaryCall<NoData> AcceptInvitationAsync(AcceptInvitationRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<AcceptInvitationRequest, NoData>(FriendsService.__Method_AcceptInvitation, null, options, request);
			}

			// Token: 0x0600CC21 RID: 52257 RVA: 0x004AB6E4 File Offset: 0x004A98E4
			public virtual NoData RevokeInvitation(RevokeInvitationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.RevokeInvitation(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC22 RID: 52258 RVA: 0x004AB70C File Offset: 0x004A990C
			public virtual NoData RevokeInvitation(RevokeInvitationRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<RevokeInvitationRequest, NoData>(FriendsService.__Method_RevokeInvitation, null, options, request);
			}

			// Token: 0x0600CC23 RID: 52259 RVA: 0x004AB734 File Offset: 0x004A9934
			public virtual AsyncUnaryCall<NoData> RevokeInvitationAsync(RevokeInvitationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.RevokeInvitationAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC24 RID: 52260 RVA: 0x004AB75C File Offset: 0x004A995C
			public virtual AsyncUnaryCall<NoData> RevokeInvitationAsync(RevokeInvitationRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<RevokeInvitationRequest, NoData>(FriendsService.__Method_RevokeInvitation, null, options, request);
			}

			// Token: 0x0600CC25 RID: 52261 RVA: 0x004AB784 File Offset: 0x004A9984
			public virtual NoData DeclineInvitation(DeclineInvitationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.DeclineInvitation(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC26 RID: 52262 RVA: 0x004AB7AC File Offset: 0x004A99AC
			public virtual NoData DeclineInvitation(DeclineInvitationRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<DeclineInvitationRequest, NoData>(FriendsService.__Method_DeclineInvitation, null, options, request);
			}

			// Token: 0x0600CC27 RID: 52263 RVA: 0x004AB7D4 File Offset: 0x004A99D4
			public virtual AsyncUnaryCall<NoData> DeclineInvitationAsync(DeclineInvitationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.DeclineInvitationAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC28 RID: 52264 RVA: 0x004AB7FC File Offset: 0x004A99FC
			public virtual AsyncUnaryCall<NoData> DeclineInvitationAsync(DeclineInvitationRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<DeclineInvitationRequest, NoData>(FriendsService.__Method_DeclineInvitation, null, options, request);
			}

			// Token: 0x0600CC29 RID: 52265 RVA: 0x004AB824 File Offset: 0x004A9A24
			public virtual NoData IgnoreInvitation(IgnoreInvitationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.IgnoreInvitation(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC2A RID: 52266 RVA: 0x004AB84C File Offset: 0x004A9A4C
			public virtual NoData IgnoreInvitation(IgnoreInvitationRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<IgnoreInvitationRequest, NoData>(FriendsService.__Method_IgnoreInvitation, null, options, request);
			}

			// Token: 0x0600CC2B RID: 52267 RVA: 0x004AB874 File Offset: 0x004A9A74
			public virtual AsyncUnaryCall<NoData> IgnoreInvitationAsync(IgnoreInvitationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.IgnoreInvitationAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC2C RID: 52268 RVA: 0x004AB89C File Offset: 0x004A9A9C
			public virtual AsyncUnaryCall<NoData> IgnoreInvitationAsync(IgnoreInvitationRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<IgnoreInvitationRequest, NoData>(FriendsService.__Method_IgnoreInvitation, null, options, request);
			}

			// Token: 0x0600CC2D RID: 52269 RVA: 0x004AB8C4 File Offset: 0x004A9AC4
			public virtual NoData RemoveFriend(RemoveFriendRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.RemoveFriend(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC2E RID: 52270 RVA: 0x004AB8EC File Offset: 0x004A9AEC
			public virtual NoData RemoveFriend(RemoveFriendRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<RemoveFriendRequest, NoData>(FriendsService.__Method_RemoveFriend, null, options, request);
			}

			// Token: 0x0600CC2F RID: 52271 RVA: 0x004AB914 File Offset: 0x004A9B14
			public virtual AsyncUnaryCall<NoData> RemoveFriendAsync(RemoveFriendRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.RemoveFriendAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC30 RID: 52272 RVA: 0x004AB93C File Offset: 0x004A9B3C
			public virtual AsyncUnaryCall<NoData> RemoveFriendAsync(RemoveFriendRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<RemoveFriendRequest, NoData>(FriendsService.__Method_RemoveFriend, null, options, request);
			}

			// Token: 0x0600CC31 RID: 52273 RVA: 0x004AB964 File Offset: 0x004A9B64
			public virtual ViewFriendsResponse ViewFriends(ViewFriendsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ViewFriends(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC32 RID: 52274 RVA: 0x004AB98C File Offset: 0x004A9B8C
			public virtual ViewFriendsResponse ViewFriends(ViewFriendsRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ViewFriendsRequest, ViewFriendsResponse>(FriendsService.__Method_ViewFriends, null, options, request);
			}

			// Token: 0x0600CC33 RID: 52275 RVA: 0x004AB9B4 File Offset: 0x004A9BB4
			public virtual AsyncUnaryCall<ViewFriendsResponse> ViewFriendsAsync(ViewFriendsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ViewFriendsAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC34 RID: 52276 RVA: 0x004AB9DC File Offset: 0x004A9BDC
			public virtual AsyncUnaryCall<ViewFriendsResponse> ViewFriendsAsync(ViewFriendsRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ViewFriendsRequest, ViewFriendsResponse>(FriendsService.__Method_ViewFriends, null, options, request);
			}

			// Token: 0x0600CC35 RID: 52277 RVA: 0x004ABA04 File Offset: 0x004A9C04
			public virtual NoData UpdateFriendState(UpdateFriendStateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UpdateFriendState(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC36 RID: 52278 RVA: 0x004ABA2C File Offset: 0x004A9C2C
			public virtual NoData UpdateFriendState(UpdateFriendStateRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<UpdateFriendStateRequest, NoData>(FriendsService.__Method_UpdateFriendState, null, options, request);
			}

			// Token: 0x0600CC37 RID: 52279 RVA: 0x004ABA54 File Offset: 0x004A9C54
			public virtual AsyncUnaryCall<NoData> UpdateFriendStateAsync(UpdateFriendStateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UpdateFriendStateAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC38 RID: 52280 RVA: 0x004ABA7C File Offset: 0x004A9C7C
			public virtual AsyncUnaryCall<NoData> UpdateFriendStateAsync(UpdateFriendStateRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<UpdateFriendStateRequest, NoData>(FriendsService.__Method_UpdateFriendState, null, options, request);
			}

			// Token: 0x0600CC39 RID: 52281 RVA: 0x004ABAA4 File Offset: 0x004A9CA4
			public virtual NoData Unsubscribe(UnsubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Unsubscribe(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC3A RID: 52282 RVA: 0x004ABACC File Offset: 0x004A9CCC
			public virtual NoData Unsubscribe(UnsubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<UnsubscribeRequest, NoData>(FriendsService.__Method_Unsubscribe, null, options, request);
			}

			// Token: 0x0600CC3B RID: 52283 RVA: 0x004ABAF4 File Offset: 0x004A9CF4
			public virtual AsyncUnaryCall<NoData> UnsubscribeAsync(UnsubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UnsubscribeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC3C RID: 52284 RVA: 0x004ABB1C File Offset: 0x004A9D1C
			public virtual AsyncUnaryCall<NoData> UnsubscribeAsync(UnsubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<UnsubscribeRequest, NoData>(FriendsService.__Method_Unsubscribe, null, options, request);
			}

			// Token: 0x0600CC3D RID: 52285 RVA: 0x004ABB44 File Offset: 0x004A9D44
			public virtual NoData RevokeAllInvitations(RevokeAllInvitationsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.RevokeAllInvitations(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC3E RID: 52286 RVA: 0x004ABB6C File Offset: 0x004A9D6C
			public virtual NoData RevokeAllInvitations(RevokeAllInvitationsRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<RevokeAllInvitationsRequest, NoData>(FriendsService.__Method_RevokeAllInvitations, null, options, request);
			}

			// Token: 0x0600CC3F RID: 52287 RVA: 0x004ABB94 File Offset: 0x004A9D94
			public virtual AsyncUnaryCall<NoData> RevokeAllInvitationsAsync(RevokeAllInvitationsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.RevokeAllInvitationsAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC40 RID: 52288 RVA: 0x004ABBBC File Offset: 0x004A9DBC
			public virtual AsyncUnaryCall<NoData> RevokeAllInvitationsAsync(RevokeAllInvitationsRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<RevokeAllInvitationsRequest, NoData>(FriendsService.__Method_RevokeAllInvitations, null, options, request);
			}

			// Token: 0x0600CC41 RID: 52289 RVA: 0x004ABBE4 File Offset: 0x004A9DE4
			public virtual GetFriendListResponse GetFriendList(GetFriendListRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetFriendList(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC42 RID: 52290 RVA: 0x004ABC0C File Offset: 0x004A9E0C
			public virtual GetFriendListResponse GetFriendList(GetFriendListRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetFriendListRequest, GetFriendListResponse>(FriendsService.__Method_GetFriendList, null, options, request);
			}

			// Token: 0x0600CC43 RID: 52291 RVA: 0x004ABC34 File Offset: 0x004A9E34
			public virtual AsyncUnaryCall<GetFriendListResponse> GetFriendListAsync(GetFriendListRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetFriendListAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC44 RID: 52292 RVA: 0x004ABC5C File Offset: 0x004A9E5C
			public virtual AsyncUnaryCall<GetFriendListResponse> GetFriendListAsync(GetFriendListRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetFriendListRequest, GetFriendListResponse>(FriendsService.__Method_GetFriendList, null, options, request);
			}

			// Token: 0x0600CC45 RID: 52293 RVA: 0x004ABC84 File Offset: 0x004A9E84
			public virtual NoData CreateFriendship(CreateFriendshipRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.CreateFriendship(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC46 RID: 52294 RVA: 0x004ABCAC File Offset: 0x004A9EAC
			public virtual NoData CreateFriendship(CreateFriendshipRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<CreateFriendshipRequest, NoData>(FriendsService.__Method_CreateFriendship, null, options, request);
			}

			// Token: 0x0600CC47 RID: 52295 RVA: 0x004ABCD4 File Offset: 0x004A9ED4
			public virtual AsyncUnaryCall<NoData> CreateFriendshipAsync(CreateFriendshipRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.CreateFriendshipAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC48 RID: 52296 RVA: 0x004ABCFC File Offset: 0x004A9EFC
			public virtual AsyncUnaryCall<NoData> CreateFriendshipAsync(CreateFriendshipRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<CreateFriendshipRequest, NoData>(FriendsService.__Method_CreateFriendship, null, options, request);
			}

			// Token: 0x0600CC49 RID: 52297 RVA: 0x004ABD24 File Offset: 0x004A9F24
			protected override FriendsService.FriendsServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new FriendsService.FriendsServiceClient(configuration);
			}
		}
	}
}
