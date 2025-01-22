using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Classic.Protocol.V1.Lobby
{
	// Token: 0x0200075F RID: 1887
	public static class Lobby
	{
		// Token: 0x0600ADA4 RID: 44452 RVA: 0x002A4558 File Offset: 0x002A2758
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

		// Token: 0x0600ADA5 RID: 44453 RVA: 0x002A45A4 File Offset: 0x002A27A4
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = Lobby.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x170035AF RID: 13743
		// (get) Token: 0x0600ADA6 RID: 44454 RVA: 0x002A45DC File Offset: 0x002A27DC
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return LobbyReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x0600ADA7 RID: 44455 RVA: 0x002A4600 File Offset: 0x002A2800
		public static ServerServiceDefinition BindService(Lobby.LobbyBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_CreateLobby, new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.CreateLobby)).AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_AcceptLobbyInvite, new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.AcceptLobbyInvite))
				.AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_RejectLobbyInvite, new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.RejectLobbyInvite))
				.AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_DisbandLobby, new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.DisbandLobby))
				.AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_LeavyLobby, new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.LeavyLobby))
				.AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_KickFromLobby, new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.KickFromLobby))
				.AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_PromoteToLeader, new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.PromoteToLeader))
				.AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_InviteToLobby, new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.InviteToLobby))
				.AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_NewInvite, new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.NewInvite))
				.AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_LobbyUpdate, new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.LobbyUpdate))
				.AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_LobbyDisbanded, new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.LobbyDisbanded))
				.AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_LobbyKicked, new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.LobbyKicked))
				.AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_PromotedToLeader, new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.PromotedToLeader))
				.AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_SetLobbyMeta, new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.SetLobbyMeta))
				.AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_SetSelfMeta, new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.SetSelfMeta))
				.AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_SendChatMessage, new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.SendChatMessage))
				.AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_ChatMessageRecv, new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.ChatMessageRecv))
				.Build();
		}

		// Token: 0x0600ADA8 RID: 44456 RVA: 0x002A47A4 File Offset: 0x002A29A4
		public static void BindService(ServiceBinderBase serviceBinder, Lobby.LobbyBase serviceImpl)
		{
			serviceBinder.AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_CreateLobby, (serviceImpl == null) ? null : new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.CreateLobby));
			serviceBinder.AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_AcceptLobbyInvite, (serviceImpl == null) ? null : new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.AcceptLobbyInvite));
			serviceBinder.AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_RejectLobbyInvite, (serviceImpl == null) ? null : new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.RejectLobbyInvite));
			serviceBinder.AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_DisbandLobby, (serviceImpl == null) ? null : new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.DisbandLobby));
			serviceBinder.AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_LeavyLobby, (serviceImpl == null) ? null : new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.LeavyLobby));
			serviceBinder.AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_KickFromLobby, (serviceImpl == null) ? null : new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.KickFromLobby));
			serviceBinder.AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_PromoteToLeader, (serviceImpl == null) ? null : new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.PromoteToLeader));
			serviceBinder.AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_InviteToLobby, (serviceImpl == null) ? null : new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.InviteToLobby));
			serviceBinder.AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_NewInvite, (serviceImpl == null) ? null : new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.NewInvite));
			serviceBinder.AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_LobbyUpdate, (serviceImpl == null) ? null : new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.LobbyUpdate));
			serviceBinder.AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_LobbyDisbanded, (serviceImpl == null) ? null : new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.LobbyDisbanded));
			serviceBinder.AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_LobbyKicked, (serviceImpl == null) ? null : new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.LobbyKicked));
			serviceBinder.AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_PromotedToLeader, (serviceImpl == null) ? null : new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.PromotedToLeader));
			serviceBinder.AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_SetLobbyMeta, (serviceImpl == null) ? null : new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.SetLobbyMeta));
			serviceBinder.AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_SetSelfMeta, (serviceImpl == null) ? null : new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.SetSelfMeta));
			serviceBinder.AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_SendChatMessage, (serviceImpl == null) ? null : new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.SendChatMessage));
			serviceBinder.AddMethod<LobbyRequest, LobbyResponse>(Lobby.__Method_ChatMessageRecv, (serviceImpl == null) ? null : new UnaryServerMethod<LobbyRequest, LobbyResponse>(serviceImpl.ChatMessageRecv));
		}

		// Token: 0x04004E36 RID: 20022
		private static readonly string __ServiceName = "classic.protocol.v1.lobby.Lobby";

		// Token: 0x04004E37 RID: 20023
		private static readonly Marshaller<LobbyRequest> __Marshaller_classic_protocol_v1_lobby_LobbyRequest = Marshallers.Create<LobbyRequest>(new Action<LobbyRequest, SerializationContext>(Lobby.__Helper_SerializeMessage), (DeserializationContext context) => Lobby.__Helper_DeserializeMessage<LobbyRequest>(context, LobbyRequest.Parser));

		// Token: 0x04004E38 RID: 20024
		private static readonly Marshaller<LobbyResponse> __Marshaller_classic_protocol_v1_lobby_LobbyResponse = Marshallers.Create<LobbyResponse>(new Action<LobbyResponse, SerializationContext>(Lobby.__Helper_SerializeMessage), (DeserializationContext context) => Lobby.__Helper_DeserializeMessage<LobbyResponse>(context, LobbyResponse.Parser));

		// Token: 0x04004E39 RID: 20025
		private static readonly Method<LobbyRequest, LobbyResponse> __Method_CreateLobby = new Method<LobbyRequest, LobbyResponse>(0, Lobby.__ServiceName, "CreateLobby", Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyRequest, Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyResponse);

		// Token: 0x04004E3A RID: 20026
		private static readonly Method<LobbyRequest, LobbyResponse> __Method_AcceptLobbyInvite = new Method<LobbyRequest, LobbyResponse>(0, Lobby.__ServiceName, "AcceptLobbyInvite", Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyRequest, Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyResponse);

		// Token: 0x04004E3B RID: 20027
		private static readonly Method<LobbyRequest, LobbyResponse> __Method_RejectLobbyInvite = new Method<LobbyRequest, LobbyResponse>(0, Lobby.__ServiceName, "RejectLobbyInvite", Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyRequest, Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyResponse);

		// Token: 0x04004E3C RID: 20028
		private static readonly Method<LobbyRequest, LobbyResponse> __Method_DisbandLobby = new Method<LobbyRequest, LobbyResponse>(0, Lobby.__ServiceName, "DisbandLobby", Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyRequest, Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyResponse);

		// Token: 0x04004E3D RID: 20029
		private static readonly Method<LobbyRequest, LobbyResponse> __Method_LeavyLobby = new Method<LobbyRequest, LobbyResponse>(0, Lobby.__ServiceName, "LeavyLobby", Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyRequest, Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyResponse);

		// Token: 0x04004E3E RID: 20030
		private static readonly Method<LobbyRequest, LobbyResponse> __Method_KickFromLobby = new Method<LobbyRequest, LobbyResponse>(0, Lobby.__ServiceName, "KickFromLobby", Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyRequest, Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyResponse);

		// Token: 0x04004E3F RID: 20031
		private static readonly Method<LobbyRequest, LobbyResponse> __Method_PromoteToLeader = new Method<LobbyRequest, LobbyResponse>(0, Lobby.__ServiceName, "PromoteToLeader", Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyRequest, Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyResponse);

		// Token: 0x04004E40 RID: 20032
		private static readonly Method<LobbyRequest, LobbyResponse> __Method_InviteToLobby = new Method<LobbyRequest, LobbyResponse>(0, Lobby.__ServiceName, "InviteToLobby", Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyRequest, Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyResponse);

		// Token: 0x04004E41 RID: 20033
		private static readonly Method<LobbyRequest, LobbyResponse> __Method_NewInvite = new Method<LobbyRequest, LobbyResponse>(0, Lobby.__ServiceName, "NewInvite", Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyRequest, Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyResponse);

		// Token: 0x04004E42 RID: 20034
		private static readonly Method<LobbyRequest, LobbyResponse> __Method_LobbyUpdate = new Method<LobbyRequest, LobbyResponse>(0, Lobby.__ServiceName, "LobbyUpdate", Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyRequest, Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyResponse);

		// Token: 0x04004E43 RID: 20035
		private static readonly Method<LobbyRequest, LobbyResponse> __Method_LobbyDisbanded = new Method<LobbyRequest, LobbyResponse>(0, Lobby.__ServiceName, "LobbyDisbanded", Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyRequest, Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyResponse);

		// Token: 0x04004E44 RID: 20036
		private static readonly Method<LobbyRequest, LobbyResponse> __Method_LobbyKicked = new Method<LobbyRequest, LobbyResponse>(0, Lobby.__ServiceName, "LobbyKicked", Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyRequest, Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyResponse);

		// Token: 0x04004E45 RID: 20037
		private static readonly Method<LobbyRequest, LobbyResponse> __Method_PromotedToLeader = new Method<LobbyRequest, LobbyResponse>(0, Lobby.__ServiceName, "PromotedToLeader", Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyRequest, Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyResponse);

		// Token: 0x04004E46 RID: 20038
		private static readonly Method<LobbyRequest, LobbyResponse> __Method_SetLobbyMeta = new Method<LobbyRequest, LobbyResponse>(0, Lobby.__ServiceName, "SetLobbyMeta", Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyRequest, Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyResponse);

		// Token: 0x04004E47 RID: 20039
		private static readonly Method<LobbyRequest, LobbyResponse> __Method_SetSelfMeta = new Method<LobbyRequest, LobbyResponse>(0, Lobby.__ServiceName, "SetSelfMeta", Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyRequest, Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyResponse);

		// Token: 0x04004E48 RID: 20040
		private static readonly Method<LobbyRequest, LobbyResponse> __Method_SendChatMessage = new Method<LobbyRequest, LobbyResponse>(0, Lobby.__ServiceName, "SendChatMessage", Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyRequest, Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyResponse);

		// Token: 0x04004E49 RID: 20041
		private static readonly Method<LobbyRequest, LobbyResponse> __Method_ChatMessageRecv = new Method<LobbyRequest, LobbyResponse>(0, Lobby.__ServiceName, "ChatMessageRecv", Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyRequest, Lobby.__Marshaller_classic_protocol_v1_lobby_LobbyResponse);

		// Token: 0x02001277 RID: 4727
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x04009995 RID: 39317
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02001278 RID: 4728
		[BindServiceMethod(typeof(Lobby), "BindService")]
		public abstract class LobbyBase
		{
			// Token: 0x0600DC47 RID: 56391 RVA: 0x004BE1DD File Offset: 0x004BC3DD
			public virtual Task<LobbyResponse> CreateLobby(LobbyRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DC48 RID: 56392 RVA: 0x004BE1F1 File Offset: 0x004BC3F1
			public virtual Task<LobbyResponse> AcceptLobbyInvite(LobbyRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DC49 RID: 56393 RVA: 0x004BE205 File Offset: 0x004BC405
			public virtual Task<LobbyResponse> RejectLobbyInvite(LobbyRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DC4A RID: 56394 RVA: 0x004BE219 File Offset: 0x004BC419
			public virtual Task<LobbyResponse> DisbandLobby(LobbyRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DC4B RID: 56395 RVA: 0x004BE22D File Offset: 0x004BC42D
			public virtual Task<LobbyResponse> LeavyLobby(LobbyRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DC4C RID: 56396 RVA: 0x004BE241 File Offset: 0x004BC441
			public virtual Task<LobbyResponse> KickFromLobby(LobbyRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DC4D RID: 56397 RVA: 0x004BE255 File Offset: 0x004BC455
			public virtual Task<LobbyResponse> PromoteToLeader(LobbyRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DC4E RID: 56398 RVA: 0x004BE269 File Offset: 0x004BC469
			public virtual Task<LobbyResponse> InviteToLobby(LobbyRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DC4F RID: 56399 RVA: 0x004BE27D File Offset: 0x004BC47D
			public virtual Task<LobbyResponse> NewInvite(LobbyRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DC50 RID: 56400 RVA: 0x004BE291 File Offset: 0x004BC491
			public virtual Task<LobbyResponse> LobbyUpdate(LobbyRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DC51 RID: 56401 RVA: 0x004BE2A5 File Offset: 0x004BC4A5
			public virtual Task<LobbyResponse> LobbyDisbanded(LobbyRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DC52 RID: 56402 RVA: 0x004BE2B9 File Offset: 0x004BC4B9
			public virtual Task<LobbyResponse> LobbyKicked(LobbyRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DC53 RID: 56403 RVA: 0x004BE2CD File Offset: 0x004BC4CD
			public virtual Task<LobbyResponse> PromotedToLeader(LobbyRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DC54 RID: 56404 RVA: 0x004BE2E1 File Offset: 0x004BC4E1
			public virtual Task<LobbyResponse> SetLobbyMeta(LobbyRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DC55 RID: 56405 RVA: 0x004BE2F5 File Offset: 0x004BC4F5
			public virtual Task<LobbyResponse> SetSelfMeta(LobbyRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DC56 RID: 56406 RVA: 0x004BE309 File Offset: 0x004BC509
			public virtual Task<LobbyResponse> SendChatMessage(LobbyRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DC57 RID: 56407 RVA: 0x004BE31D File Offset: 0x004BC51D
			public virtual Task<LobbyResponse> ChatMessageRecv(LobbyRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x02001279 RID: 4729
		public class LobbyClient : ClientBase<Lobby.LobbyClient>
		{
			// Token: 0x0600DC59 RID: 56409 RVA: 0x004BE33A File Offset: 0x004BC53A
			public LobbyClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600DC5A RID: 56410 RVA: 0x004BE345 File Offset: 0x004BC545
			public LobbyClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600DC5B RID: 56411 RVA: 0x004BE350 File Offset: 0x004BC550
			protected LobbyClient()
			{
			}

			// Token: 0x0600DC5C RID: 56412 RVA: 0x004BE35A File Offset: 0x004BC55A
			protected LobbyClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600DC5D RID: 56413 RVA: 0x004BE368 File Offset: 0x004BC568
			public virtual LobbyResponse CreateLobby(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.CreateLobby(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC5E RID: 56414 RVA: 0x004BE390 File Offset: 0x004BC590
			public virtual LobbyResponse CreateLobby(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_CreateLobby, null, options, request);
			}

			// Token: 0x0600DC5F RID: 56415 RVA: 0x004BE3B8 File Offset: 0x004BC5B8
			public virtual AsyncUnaryCall<LobbyResponse> CreateLobbyAsync(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.CreateLobbyAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC60 RID: 56416 RVA: 0x004BE3E0 File Offset: 0x004BC5E0
			public virtual AsyncUnaryCall<LobbyResponse> CreateLobbyAsync(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_CreateLobby, null, options, request);
			}

			// Token: 0x0600DC61 RID: 56417 RVA: 0x004BE408 File Offset: 0x004BC608
			public virtual LobbyResponse AcceptLobbyInvite(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.AcceptLobbyInvite(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC62 RID: 56418 RVA: 0x004BE430 File Offset: 0x004BC630
			public virtual LobbyResponse AcceptLobbyInvite(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_AcceptLobbyInvite, null, options, request);
			}

			// Token: 0x0600DC63 RID: 56419 RVA: 0x004BE458 File Offset: 0x004BC658
			public virtual AsyncUnaryCall<LobbyResponse> AcceptLobbyInviteAsync(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.AcceptLobbyInviteAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC64 RID: 56420 RVA: 0x004BE480 File Offset: 0x004BC680
			public virtual AsyncUnaryCall<LobbyResponse> AcceptLobbyInviteAsync(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_AcceptLobbyInvite, null, options, request);
			}

			// Token: 0x0600DC65 RID: 56421 RVA: 0x004BE4A8 File Offset: 0x004BC6A8
			public virtual LobbyResponse RejectLobbyInvite(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.RejectLobbyInvite(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC66 RID: 56422 RVA: 0x004BE4D0 File Offset: 0x004BC6D0
			public virtual LobbyResponse RejectLobbyInvite(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_RejectLobbyInvite, null, options, request);
			}

			// Token: 0x0600DC67 RID: 56423 RVA: 0x004BE4F8 File Offset: 0x004BC6F8
			public virtual AsyncUnaryCall<LobbyResponse> RejectLobbyInviteAsync(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.RejectLobbyInviteAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC68 RID: 56424 RVA: 0x004BE520 File Offset: 0x004BC720
			public virtual AsyncUnaryCall<LobbyResponse> RejectLobbyInviteAsync(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_RejectLobbyInvite, null, options, request);
			}

			// Token: 0x0600DC69 RID: 56425 RVA: 0x004BE548 File Offset: 0x004BC748
			public virtual LobbyResponse DisbandLobby(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.DisbandLobby(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC6A RID: 56426 RVA: 0x004BE570 File Offset: 0x004BC770
			public virtual LobbyResponse DisbandLobby(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_DisbandLobby, null, options, request);
			}

			// Token: 0x0600DC6B RID: 56427 RVA: 0x004BE598 File Offset: 0x004BC798
			public virtual AsyncUnaryCall<LobbyResponse> DisbandLobbyAsync(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.DisbandLobbyAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC6C RID: 56428 RVA: 0x004BE5C0 File Offset: 0x004BC7C0
			public virtual AsyncUnaryCall<LobbyResponse> DisbandLobbyAsync(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_DisbandLobby, null, options, request);
			}

			// Token: 0x0600DC6D RID: 56429 RVA: 0x004BE5E8 File Offset: 0x004BC7E8
			public virtual LobbyResponse LeavyLobby(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.LeavyLobby(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC6E RID: 56430 RVA: 0x004BE610 File Offset: 0x004BC810
			public virtual LobbyResponse LeavyLobby(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_LeavyLobby, null, options, request);
			}

			// Token: 0x0600DC6F RID: 56431 RVA: 0x004BE638 File Offset: 0x004BC838
			public virtual AsyncUnaryCall<LobbyResponse> LeavyLobbyAsync(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.LeavyLobbyAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC70 RID: 56432 RVA: 0x004BE660 File Offset: 0x004BC860
			public virtual AsyncUnaryCall<LobbyResponse> LeavyLobbyAsync(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_LeavyLobby, null, options, request);
			}

			// Token: 0x0600DC71 RID: 56433 RVA: 0x004BE688 File Offset: 0x004BC888
			public virtual LobbyResponse KickFromLobby(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.KickFromLobby(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC72 RID: 56434 RVA: 0x004BE6B0 File Offset: 0x004BC8B0
			public virtual LobbyResponse KickFromLobby(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_KickFromLobby, null, options, request);
			}

			// Token: 0x0600DC73 RID: 56435 RVA: 0x004BE6D8 File Offset: 0x004BC8D8
			public virtual AsyncUnaryCall<LobbyResponse> KickFromLobbyAsync(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.KickFromLobbyAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC74 RID: 56436 RVA: 0x004BE700 File Offset: 0x004BC900
			public virtual AsyncUnaryCall<LobbyResponse> KickFromLobbyAsync(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_KickFromLobby, null, options, request);
			}

			// Token: 0x0600DC75 RID: 56437 RVA: 0x004BE728 File Offset: 0x004BC928
			public virtual LobbyResponse PromoteToLeader(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.PromoteToLeader(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC76 RID: 56438 RVA: 0x004BE750 File Offset: 0x004BC950
			public virtual LobbyResponse PromoteToLeader(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_PromoteToLeader, null, options, request);
			}

			// Token: 0x0600DC77 RID: 56439 RVA: 0x004BE778 File Offset: 0x004BC978
			public virtual AsyncUnaryCall<LobbyResponse> PromoteToLeaderAsync(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.PromoteToLeaderAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC78 RID: 56440 RVA: 0x004BE7A0 File Offset: 0x004BC9A0
			public virtual AsyncUnaryCall<LobbyResponse> PromoteToLeaderAsync(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_PromoteToLeader, null, options, request);
			}

			// Token: 0x0600DC79 RID: 56441 RVA: 0x004BE7C8 File Offset: 0x004BC9C8
			public virtual LobbyResponse InviteToLobby(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.InviteToLobby(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC7A RID: 56442 RVA: 0x004BE7F0 File Offset: 0x004BC9F0
			public virtual LobbyResponse InviteToLobby(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_InviteToLobby, null, options, request);
			}

			// Token: 0x0600DC7B RID: 56443 RVA: 0x004BE818 File Offset: 0x004BCA18
			public virtual AsyncUnaryCall<LobbyResponse> InviteToLobbyAsync(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.InviteToLobbyAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC7C RID: 56444 RVA: 0x004BE840 File Offset: 0x004BCA40
			public virtual AsyncUnaryCall<LobbyResponse> InviteToLobbyAsync(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_InviteToLobby, null, options, request);
			}

			// Token: 0x0600DC7D RID: 56445 RVA: 0x004BE868 File Offset: 0x004BCA68
			public virtual LobbyResponse NewInvite(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.NewInvite(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC7E RID: 56446 RVA: 0x004BE890 File Offset: 0x004BCA90
			public virtual LobbyResponse NewInvite(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_NewInvite, null, options, request);
			}

			// Token: 0x0600DC7F RID: 56447 RVA: 0x004BE8B8 File Offset: 0x004BCAB8
			public virtual AsyncUnaryCall<LobbyResponse> NewInviteAsync(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.NewInviteAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC80 RID: 56448 RVA: 0x004BE8E0 File Offset: 0x004BCAE0
			public virtual AsyncUnaryCall<LobbyResponse> NewInviteAsync(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_NewInvite, null, options, request);
			}

			// Token: 0x0600DC81 RID: 56449 RVA: 0x004BE908 File Offset: 0x004BCB08
			public virtual LobbyResponse LobbyUpdate(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.LobbyUpdate(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC82 RID: 56450 RVA: 0x004BE930 File Offset: 0x004BCB30
			public virtual LobbyResponse LobbyUpdate(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_LobbyUpdate, null, options, request);
			}

			// Token: 0x0600DC83 RID: 56451 RVA: 0x004BE958 File Offset: 0x004BCB58
			public virtual AsyncUnaryCall<LobbyResponse> LobbyUpdateAsync(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.LobbyUpdateAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC84 RID: 56452 RVA: 0x004BE980 File Offset: 0x004BCB80
			public virtual AsyncUnaryCall<LobbyResponse> LobbyUpdateAsync(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_LobbyUpdate, null, options, request);
			}

			// Token: 0x0600DC85 RID: 56453 RVA: 0x004BE9A8 File Offset: 0x004BCBA8
			public virtual LobbyResponse LobbyDisbanded(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.LobbyDisbanded(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC86 RID: 56454 RVA: 0x004BE9D0 File Offset: 0x004BCBD0
			public virtual LobbyResponse LobbyDisbanded(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_LobbyDisbanded, null, options, request);
			}

			// Token: 0x0600DC87 RID: 56455 RVA: 0x004BE9F8 File Offset: 0x004BCBF8
			public virtual AsyncUnaryCall<LobbyResponse> LobbyDisbandedAsync(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.LobbyDisbandedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC88 RID: 56456 RVA: 0x004BEA20 File Offset: 0x004BCC20
			public virtual AsyncUnaryCall<LobbyResponse> LobbyDisbandedAsync(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_LobbyDisbanded, null, options, request);
			}

			// Token: 0x0600DC89 RID: 56457 RVA: 0x004BEA48 File Offset: 0x004BCC48
			public virtual LobbyResponse LobbyKicked(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.LobbyKicked(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC8A RID: 56458 RVA: 0x004BEA70 File Offset: 0x004BCC70
			public virtual LobbyResponse LobbyKicked(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_LobbyKicked, null, options, request);
			}

			// Token: 0x0600DC8B RID: 56459 RVA: 0x004BEA98 File Offset: 0x004BCC98
			public virtual AsyncUnaryCall<LobbyResponse> LobbyKickedAsync(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.LobbyKickedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC8C RID: 56460 RVA: 0x004BEAC0 File Offset: 0x004BCCC0
			public virtual AsyncUnaryCall<LobbyResponse> LobbyKickedAsync(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_LobbyKicked, null, options, request);
			}

			// Token: 0x0600DC8D RID: 56461 RVA: 0x004BEAE8 File Offset: 0x004BCCE8
			public virtual LobbyResponse PromotedToLeader(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.PromotedToLeader(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC8E RID: 56462 RVA: 0x004BEB10 File Offset: 0x004BCD10
			public virtual LobbyResponse PromotedToLeader(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_PromotedToLeader, null, options, request);
			}

			// Token: 0x0600DC8F RID: 56463 RVA: 0x004BEB38 File Offset: 0x004BCD38
			public virtual AsyncUnaryCall<LobbyResponse> PromotedToLeaderAsync(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.PromotedToLeaderAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC90 RID: 56464 RVA: 0x004BEB60 File Offset: 0x004BCD60
			public virtual AsyncUnaryCall<LobbyResponse> PromotedToLeaderAsync(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_PromotedToLeader, null, options, request);
			}

			// Token: 0x0600DC91 RID: 56465 RVA: 0x004BEB88 File Offset: 0x004BCD88
			public virtual LobbyResponse SetLobbyMeta(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SetLobbyMeta(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC92 RID: 56466 RVA: 0x004BEBB0 File Offset: 0x004BCDB0
			public virtual LobbyResponse SetLobbyMeta(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_SetLobbyMeta, null, options, request);
			}

			// Token: 0x0600DC93 RID: 56467 RVA: 0x004BEBD8 File Offset: 0x004BCDD8
			public virtual AsyncUnaryCall<LobbyResponse> SetLobbyMetaAsync(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SetLobbyMetaAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC94 RID: 56468 RVA: 0x004BEC00 File Offset: 0x004BCE00
			public virtual AsyncUnaryCall<LobbyResponse> SetLobbyMetaAsync(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_SetLobbyMeta, null, options, request);
			}

			// Token: 0x0600DC95 RID: 56469 RVA: 0x004BEC28 File Offset: 0x004BCE28
			public virtual LobbyResponse SetSelfMeta(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SetSelfMeta(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC96 RID: 56470 RVA: 0x004BEC50 File Offset: 0x004BCE50
			public virtual LobbyResponse SetSelfMeta(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_SetSelfMeta, null, options, request);
			}

			// Token: 0x0600DC97 RID: 56471 RVA: 0x004BEC78 File Offset: 0x004BCE78
			public virtual AsyncUnaryCall<LobbyResponse> SetSelfMetaAsync(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SetSelfMetaAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC98 RID: 56472 RVA: 0x004BECA0 File Offset: 0x004BCEA0
			public virtual AsyncUnaryCall<LobbyResponse> SetSelfMetaAsync(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_SetSelfMeta, null, options, request);
			}

			// Token: 0x0600DC99 RID: 56473 RVA: 0x004BECC8 File Offset: 0x004BCEC8
			public virtual LobbyResponse SendChatMessage(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SendChatMessage(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC9A RID: 56474 RVA: 0x004BECF0 File Offset: 0x004BCEF0
			public virtual LobbyResponse SendChatMessage(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_SendChatMessage, null, options, request);
			}

			// Token: 0x0600DC9B RID: 56475 RVA: 0x004BED18 File Offset: 0x004BCF18
			public virtual AsyncUnaryCall<LobbyResponse> SendChatMessageAsync(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SendChatMessageAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC9C RID: 56476 RVA: 0x004BED40 File Offset: 0x004BCF40
			public virtual AsyncUnaryCall<LobbyResponse> SendChatMessageAsync(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_SendChatMessage, null, options, request);
			}

			// Token: 0x0600DC9D RID: 56477 RVA: 0x004BED68 File Offset: 0x004BCF68
			public virtual LobbyResponse ChatMessageRecv(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ChatMessageRecv(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC9E RID: 56478 RVA: 0x004BED90 File Offset: 0x004BCF90
			public virtual LobbyResponse ChatMessageRecv(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_ChatMessageRecv, null, options, request);
			}

			// Token: 0x0600DC9F RID: 56479 RVA: 0x004BEDB8 File Offset: 0x004BCFB8
			public virtual AsyncUnaryCall<LobbyResponse> ChatMessageRecvAsync(LobbyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ChatMessageRecvAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DCA0 RID: 56480 RVA: 0x004BEDE0 File Offset: 0x004BCFE0
			public virtual AsyncUnaryCall<LobbyResponse> ChatMessageRecvAsync(LobbyRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<LobbyRequest, LobbyResponse>(Lobby.__Method_ChatMessageRecv, null, options, request);
			}

			// Token: 0x0600DCA1 RID: 56481 RVA: 0x004BEE08 File Offset: 0x004BD008
			protected override Lobby.LobbyClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new Lobby.LobbyClient(configuration);
			}
		}
	}
}
