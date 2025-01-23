using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x02000548 RID: 1352
	public static class SessionService
	{
		// Token: 0x060082D0 RID: 33488 RVA: 0x001FC704 File Offset: 0x001FA904
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

		// Token: 0x060082D1 RID: 33489 RVA: 0x001FC750 File Offset: 0x001FA950
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = SessionService.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17002950 RID: 10576
		// (get) Token: 0x060082D2 RID: 33490 RVA: 0x001FC788 File Offset: 0x001FA988
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.Services[1];
			}
		}

		// Token: 0x060082D3 RID: 33491 RVA: 0x001FC7AC File Offset: 0x001FA9AC
		public static ServerServiceDefinition BindService(SessionService.SessionServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<CreateSessionRequest, CreateSessionResponse>(SessionService.__Method_CreateSession, new UnaryServerMethod<CreateSessionRequest, CreateSessionResponse>(serviceImpl.CreateSession)).AddMethod<DestroySessionRequest, NoData>(SessionService.__Method_DestroySession, new UnaryServerMethod<DestroySessionRequest, NoData>(serviceImpl.DestroySession))
				.AddMethod<UpdateSessionRequest, NoData>(SessionService.__Method_UpdateSession, new UnaryServerMethod<UpdateSessionRequest, NoData>(serviceImpl.UpdateSession))
				.AddMethod<GetSessionCapacityRequest, GetSessionCapacityResponse>(SessionService.__Method_GetSessionCapacity, new UnaryServerMethod<GetSessionCapacityRequest, GetSessionCapacityResponse>(serviceImpl.GetSessionCapacity))
				.AddMethod<GetSessionStateByBenefactorRequest, GetSessionStateByBenefactorResponse>(SessionService.__Method_GetSessionStateByBenefactor, new UnaryServerMethod<GetSessionStateByBenefactorRequest, GetSessionStateByBenefactorResponse>(serviceImpl.GetSessionStateByBenefactor))
				.AddMethod<MarkSessionsAliveRequest, MarkSessionsAliveResponse>(SessionService.__Method_MarkSessionsAlive, new UnaryServerMethod<MarkSessionsAliveRequest, MarkSessionsAliveResponse>(serviceImpl.MarkSessionsAlive))
				.AddMethod<GetSessionStateRequest, GetSessionStateResponse>(SessionService.__Method_GetSessionState, new UnaryServerMethod<GetSessionStateRequest, GetSessionStateResponse>(serviceImpl.GetSessionState))
				.AddMethod<GetSignedSessionStateRequest, GetSignedSessionStateResponse>(SessionService.__Method_GetSignedSessionState, new UnaryServerMethod<GetSignedSessionStateRequest, GetSignedSessionStateResponse>(serviceImpl.GetSignedSessionState))
				.AddMethod<RefreshSessionKeyRequest, RefreshSessionKeyResponse>(SessionService.__Method_RefreshSessionKey, new UnaryServerMethod<RefreshSessionKeyRequest, RefreshSessionKeyResponse>(serviceImpl.RefreshSessionKey))
				.Build();
		}

		// Token: 0x060082D4 RID: 33492 RVA: 0x001FC898 File Offset: 0x001FAA98
		public static void BindService(ServiceBinderBase serviceBinder, SessionService.SessionServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<CreateSessionRequest, CreateSessionResponse>(SessionService.__Method_CreateSession, (serviceImpl == null) ? null : new UnaryServerMethod<CreateSessionRequest, CreateSessionResponse>(serviceImpl.CreateSession));
			serviceBinder.AddMethod<DestroySessionRequest, NoData>(SessionService.__Method_DestroySession, (serviceImpl == null) ? null : new UnaryServerMethod<DestroySessionRequest, NoData>(serviceImpl.DestroySession));
			serviceBinder.AddMethod<UpdateSessionRequest, NoData>(SessionService.__Method_UpdateSession, (serviceImpl == null) ? null : new UnaryServerMethod<UpdateSessionRequest, NoData>(serviceImpl.UpdateSession));
			serviceBinder.AddMethod<GetSessionCapacityRequest, GetSessionCapacityResponse>(SessionService.__Method_GetSessionCapacity, (serviceImpl == null) ? null : new UnaryServerMethod<GetSessionCapacityRequest, GetSessionCapacityResponse>(serviceImpl.GetSessionCapacity));
			serviceBinder.AddMethod<GetSessionStateByBenefactorRequest, GetSessionStateByBenefactorResponse>(SessionService.__Method_GetSessionStateByBenefactor, (serviceImpl == null) ? null : new UnaryServerMethod<GetSessionStateByBenefactorRequest, GetSessionStateByBenefactorResponse>(serviceImpl.GetSessionStateByBenefactor));
			serviceBinder.AddMethod<MarkSessionsAliveRequest, MarkSessionsAliveResponse>(SessionService.__Method_MarkSessionsAlive, (serviceImpl == null) ? null : new UnaryServerMethod<MarkSessionsAliveRequest, MarkSessionsAliveResponse>(serviceImpl.MarkSessionsAlive));
			serviceBinder.AddMethod<GetSessionStateRequest, GetSessionStateResponse>(SessionService.__Method_GetSessionState, (serviceImpl == null) ? null : new UnaryServerMethod<GetSessionStateRequest, GetSessionStateResponse>(serviceImpl.GetSessionState));
			serviceBinder.AddMethod<GetSignedSessionStateRequest, GetSignedSessionStateResponse>(SessionService.__Method_GetSignedSessionState, (serviceImpl == null) ? null : new UnaryServerMethod<GetSignedSessionStateRequest, GetSignedSessionStateResponse>(serviceImpl.GetSignedSessionState));
			serviceBinder.AddMethod<RefreshSessionKeyRequest, RefreshSessionKeyResponse>(SessionService.__Method_RefreshSessionKey, (serviceImpl == null) ? null : new UnaryServerMethod<RefreshSessionKeyRequest, RefreshSessionKeyResponse>(serviceImpl.RefreshSessionKey));
		}

		// Token: 0x04003B35 RID: 15157
		private static readonly string __ServiceName = "bgs.protocol.session.v1.SessionService";

		// Token: 0x04003B36 RID: 15158
		private static readonly Marshaller<CreateSessionRequest> __Marshaller_bgs_protocol_session_v1_CreateSessionRequest = Marshallers.Create<CreateSessionRequest>(new Action<CreateSessionRequest, SerializationContext>(SessionService.__Helper_SerializeMessage), (DeserializationContext context) => SessionService.__Helper_DeserializeMessage<CreateSessionRequest>(context, CreateSessionRequest.Parser));

		// Token: 0x04003B37 RID: 15159
		private static readonly Marshaller<CreateSessionResponse> __Marshaller_bgs_protocol_session_v1_CreateSessionResponse = Marshallers.Create<CreateSessionResponse>(new Action<CreateSessionResponse, SerializationContext>(SessionService.__Helper_SerializeMessage), (DeserializationContext context) => SessionService.__Helper_DeserializeMessage<CreateSessionResponse>(context, CreateSessionResponse.Parser));

		// Token: 0x04003B38 RID: 15160
		private static readonly Marshaller<DestroySessionRequest> __Marshaller_bgs_protocol_session_v1_DestroySessionRequest = Marshallers.Create<DestroySessionRequest>(new Action<DestroySessionRequest, SerializationContext>(SessionService.__Helper_SerializeMessage), (DeserializationContext context) => SessionService.__Helper_DeserializeMessage<DestroySessionRequest>(context, DestroySessionRequest.Parser));

		// Token: 0x04003B39 RID: 15161
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(SessionService.__Helper_SerializeMessage), (DeserializationContext context) => SessionService.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x04003B3A RID: 15162
		private static readonly Marshaller<UpdateSessionRequest> __Marshaller_bgs_protocol_session_v1_UpdateSessionRequest = Marshallers.Create<UpdateSessionRequest>(new Action<UpdateSessionRequest, SerializationContext>(SessionService.__Helper_SerializeMessage), (DeserializationContext context) => SessionService.__Helper_DeserializeMessage<UpdateSessionRequest>(context, UpdateSessionRequest.Parser));

		// Token: 0x04003B3B RID: 15163
		private static readonly Marshaller<GetSessionCapacityRequest> __Marshaller_bgs_protocol_session_v1_GetSessionCapacityRequest = Marshallers.Create<GetSessionCapacityRequest>(new Action<GetSessionCapacityRequest, SerializationContext>(SessionService.__Helper_SerializeMessage), (DeserializationContext context) => SessionService.__Helper_DeserializeMessage<GetSessionCapacityRequest>(context, GetSessionCapacityRequest.Parser));

		// Token: 0x04003B3C RID: 15164
		private static readonly Marshaller<GetSessionCapacityResponse> __Marshaller_bgs_protocol_session_v1_GetSessionCapacityResponse = Marshallers.Create<GetSessionCapacityResponse>(new Action<GetSessionCapacityResponse, SerializationContext>(SessionService.__Helper_SerializeMessage), (DeserializationContext context) => SessionService.__Helper_DeserializeMessage<GetSessionCapacityResponse>(context, GetSessionCapacityResponse.Parser));

		// Token: 0x04003B3D RID: 15165
		private static readonly Marshaller<GetSessionStateByBenefactorRequest> __Marshaller_bgs_protocol_session_v1_GetSessionStateByBenefactorRequest = Marshallers.Create<GetSessionStateByBenefactorRequest>(new Action<GetSessionStateByBenefactorRequest, SerializationContext>(SessionService.__Helper_SerializeMessage), (DeserializationContext context) => SessionService.__Helper_DeserializeMessage<GetSessionStateByBenefactorRequest>(context, GetSessionStateByBenefactorRequest.Parser));

		// Token: 0x04003B3E RID: 15166
		private static readonly Marshaller<GetSessionStateByBenefactorResponse> __Marshaller_bgs_protocol_session_v1_GetSessionStateByBenefactorResponse = Marshallers.Create<GetSessionStateByBenefactorResponse>(new Action<GetSessionStateByBenefactorResponse, SerializationContext>(SessionService.__Helper_SerializeMessage), (DeserializationContext context) => SessionService.__Helper_DeserializeMessage<GetSessionStateByBenefactorResponse>(context, GetSessionStateByBenefactorResponse.Parser));

		// Token: 0x04003B3F RID: 15167
		private static readonly Marshaller<MarkSessionsAliveRequest> __Marshaller_bgs_protocol_session_v1_MarkSessionsAliveRequest = Marshallers.Create<MarkSessionsAliveRequest>(new Action<MarkSessionsAliveRequest, SerializationContext>(SessionService.__Helper_SerializeMessage), (DeserializationContext context) => SessionService.__Helper_DeserializeMessage<MarkSessionsAliveRequest>(context, MarkSessionsAliveRequest.Parser));

		// Token: 0x04003B40 RID: 15168
		private static readonly Marshaller<MarkSessionsAliveResponse> __Marshaller_bgs_protocol_session_v1_MarkSessionsAliveResponse = Marshallers.Create<MarkSessionsAliveResponse>(new Action<MarkSessionsAliveResponse, SerializationContext>(SessionService.__Helper_SerializeMessage), (DeserializationContext context) => SessionService.__Helper_DeserializeMessage<MarkSessionsAliveResponse>(context, MarkSessionsAliveResponse.Parser));

		// Token: 0x04003B41 RID: 15169
		private static readonly Marshaller<GetSessionStateRequest> __Marshaller_bgs_protocol_session_v1_GetSessionStateRequest = Marshallers.Create<GetSessionStateRequest>(new Action<GetSessionStateRequest, SerializationContext>(SessionService.__Helper_SerializeMessage), (DeserializationContext context) => SessionService.__Helper_DeserializeMessage<GetSessionStateRequest>(context, GetSessionStateRequest.Parser));

		// Token: 0x04003B42 RID: 15170
		private static readonly Marshaller<GetSessionStateResponse> __Marshaller_bgs_protocol_session_v1_GetSessionStateResponse = Marshallers.Create<GetSessionStateResponse>(new Action<GetSessionStateResponse, SerializationContext>(SessionService.__Helper_SerializeMessage), (DeserializationContext context) => SessionService.__Helper_DeserializeMessage<GetSessionStateResponse>(context, GetSessionStateResponse.Parser));

		// Token: 0x04003B43 RID: 15171
		private static readonly Marshaller<GetSignedSessionStateRequest> __Marshaller_bgs_protocol_session_v1_GetSignedSessionStateRequest = Marshallers.Create<GetSignedSessionStateRequest>(new Action<GetSignedSessionStateRequest, SerializationContext>(SessionService.__Helper_SerializeMessage), (DeserializationContext context) => SessionService.__Helper_DeserializeMessage<GetSignedSessionStateRequest>(context, GetSignedSessionStateRequest.Parser));

		// Token: 0x04003B44 RID: 15172
		private static readonly Marshaller<GetSignedSessionStateResponse> __Marshaller_bgs_protocol_session_v1_GetSignedSessionStateResponse = Marshallers.Create<GetSignedSessionStateResponse>(new Action<GetSignedSessionStateResponse, SerializationContext>(SessionService.__Helper_SerializeMessage), (DeserializationContext context) => SessionService.__Helper_DeserializeMessage<GetSignedSessionStateResponse>(context, GetSignedSessionStateResponse.Parser));

		// Token: 0x04003B45 RID: 15173
		private static readonly Marshaller<RefreshSessionKeyRequest> __Marshaller_bgs_protocol_session_v1_RefreshSessionKeyRequest = Marshallers.Create<RefreshSessionKeyRequest>(new Action<RefreshSessionKeyRequest, SerializationContext>(SessionService.__Helper_SerializeMessage), (DeserializationContext context) => SessionService.__Helper_DeserializeMessage<RefreshSessionKeyRequest>(context, RefreshSessionKeyRequest.Parser));

		// Token: 0x04003B46 RID: 15174
		private static readonly Marshaller<RefreshSessionKeyResponse> __Marshaller_bgs_protocol_session_v1_RefreshSessionKeyResponse = Marshallers.Create<RefreshSessionKeyResponse>(new Action<RefreshSessionKeyResponse, SerializationContext>(SessionService.__Helper_SerializeMessage), (DeserializationContext context) => SessionService.__Helper_DeserializeMessage<RefreshSessionKeyResponse>(context, RefreshSessionKeyResponse.Parser));

		// Token: 0x04003B47 RID: 15175
		private static readonly Method<CreateSessionRequest, CreateSessionResponse> __Method_CreateSession = new Method<CreateSessionRequest, CreateSessionResponse>(0, SessionService.__ServiceName, "CreateSession", SessionService.__Marshaller_bgs_protocol_session_v1_CreateSessionRequest, SessionService.__Marshaller_bgs_protocol_session_v1_CreateSessionResponse);

		// Token: 0x04003B48 RID: 15176
		private static readonly Method<DestroySessionRequest, NoData> __Method_DestroySession = new Method<DestroySessionRequest, NoData>(0, SessionService.__ServiceName, "DestroySession", SessionService.__Marshaller_bgs_protocol_session_v1_DestroySessionRequest, SessionService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04003B49 RID: 15177
		private static readonly Method<UpdateSessionRequest, NoData> __Method_UpdateSession = new Method<UpdateSessionRequest, NoData>(0, SessionService.__ServiceName, "UpdateSession", SessionService.__Marshaller_bgs_protocol_session_v1_UpdateSessionRequest, SessionService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04003B4A RID: 15178
		private static readonly Method<GetSessionCapacityRequest, GetSessionCapacityResponse> __Method_GetSessionCapacity = new Method<GetSessionCapacityRequest, GetSessionCapacityResponse>(0, SessionService.__ServiceName, "GetSessionCapacity", SessionService.__Marshaller_bgs_protocol_session_v1_GetSessionCapacityRequest, SessionService.__Marshaller_bgs_protocol_session_v1_GetSessionCapacityResponse);

		// Token: 0x04003B4B RID: 15179
		private static readonly Method<GetSessionStateByBenefactorRequest, GetSessionStateByBenefactorResponse> __Method_GetSessionStateByBenefactor = new Method<GetSessionStateByBenefactorRequest, GetSessionStateByBenefactorResponse>(0, SessionService.__ServiceName, "GetSessionStateByBenefactor", SessionService.__Marshaller_bgs_protocol_session_v1_GetSessionStateByBenefactorRequest, SessionService.__Marshaller_bgs_protocol_session_v1_GetSessionStateByBenefactorResponse);

		// Token: 0x04003B4C RID: 15180
		private static readonly Method<MarkSessionsAliveRequest, MarkSessionsAliveResponse> __Method_MarkSessionsAlive = new Method<MarkSessionsAliveRequest, MarkSessionsAliveResponse>(0, SessionService.__ServiceName, "MarkSessionsAlive", SessionService.__Marshaller_bgs_protocol_session_v1_MarkSessionsAliveRequest, SessionService.__Marshaller_bgs_protocol_session_v1_MarkSessionsAliveResponse);

		// Token: 0x04003B4D RID: 15181
		private static readonly Method<GetSessionStateRequest, GetSessionStateResponse> __Method_GetSessionState = new Method<GetSessionStateRequest, GetSessionStateResponse>(0, SessionService.__ServiceName, "GetSessionState", SessionService.__Marshaller_bgs_protocol_session_v1_GetSessionStateRequest, SessionService.__Marshaller_bgs_protocol_session_v1_GetSessionStateResponse);

		// Token: 0x04003B4E RID: 15182
		private static readonly Method<GetSignedSessionStateRequest, GetSignedSessionStateResponse> __Method_GetSignedSessionState = new Method<GetSignedSessionStateRequest, GetSignedSessionStateResponse>(0, SessionService.__ServiceName, "GetSignedSessionState", SessionService.__Marshaller_bgs_protocol_session_v1_GetSignedSessionStateRequest, SessionService.__Marshaller_bgs_protocol_session_v1_GetSignedSessionStateResponse);

		// Token: 0x04003B4F RID: 15183
		private static readonly Method<RefreshSessionKeyRequest, RefreshSessionKeyResponse> __Method_RefreshSessionKey = new Method<RefreshSessionKeyRequest, RefreshSessionKeyResponse>(0, SessionService.__ServiceName, "RefreshSessionKey", SessionService.__Marshaller_bgs_protocol_session_v1_RefreshSessionKeyRequest, SessionService.__Marshaller_bgs_protocol_session_v1_RefreshSessionKeyResponse);

		// Token: 0x02001019 RID: 4121
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x04009766 RID: 38758
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x0200101A RID: 4122
		[BindServiceMethod(typeof(SessionService), "BindService")]
		public abstract class SessionServiceBase
		{
			// Token: 0x0600D0B4 RID: 53428 RVA: 0x004AFE07 File Offset: 0x004AE007
			public virtual Task<CreateSessionResponse> CreateSession(CreateSessionRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D0B5 RID: 53429 RVA: 0x004AFE1B File Offset: 0x004AE01B
			public virtual Task<NoData> DestroySession(DestroySessionRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D0B6 RID: 53430 RVA: 0x004AFE2F File Offset: 0x004AE02F
			public virtual Task<NoData> UpdateSession(UpdateSessionRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D0B7 RID: 53431 RVA: 0x004AFE43 File Offset: 0x004AE043
			public virtual Task<GetSessionCapacityResponse> GetSessionCapacity(GetSessionCapacityRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D0B8 RID: 53432 RVA: 0x004AFE57 File Offset: 0x004AE057
			public virtual Task<GetSessionStateByBenefactorResponse> GetSessionStateByBenefactor(GetSessionStateByBenefactorRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D0B9 RID: 53433 RVA: 0x004AFE6B File Offset: 0x004AE06B
			public virtual Task<MarkSessionsAliveResponse> MarkSessionsAlive(MarkSessionsAliveRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D0BA RID: 53434 RVA: 0x004AFE7F File Offset: 0x004AE07F
			public virtual Task<GetSessionStateResponse> GetSessionState(GetSessionStateRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D0BB RID: 53435 RVA: 0x004AFE93 File Offset: 0x004AE093
			public virtual Task<GetSignedSessionStateResponse> GetSignedSessionState(GetSignedSessionStateRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D0BC RID: 53436 RVA: 0x004AFEA7 File Offset: 0x004AE0A7
			public virtual Task<RefreshSessionKeyResponse> RefreshSessionKey(RefreshSessionKeyRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x0200101B RID: 4123
		public class SessionServiceClient : ClientBase<SessionService.SessionServiceClient>
		{
			// Token: 0x0600D0BE RID: 53438 RVA: 0x004AFEC4 File Offset: 0x004AE0C4
			public SessionServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D0BF RID: 53439 RVA: 0x004AFECF File Offset: 0x004AE0CF
			public SessionServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D0C0 RID: 53440 RVA: 0x004AFEDA File Offset: 0x004AE0DA
			protected SessionServiceClient()
			{
			}

			// Token: 0x0600D0C1 RID: 53441 RVA: 0x004AFEE4 File Offset: 0x004AE0E4
			protected SessionServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D0C2 RID: 53442 RVA: 0x004AFEF0 File Offset: 0x004AE0F0
			public virtual CreateSessionResponse CreateSession(CreateSessionRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.CreateSession(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D0C3 RID: 53443 RVA: 0x004AFF18 File Offset: 0x004AE118
			public virtual CreateSessionResponse CreateSession(CreateSessionRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<CreateSessionRequest, CreateSessionResponse>(SessionService.__Method_CreateSession, null, options, request);
			}

			// Token: 0x0600D0C4 RID: 53444 RVA: 0x004AFF40 File Offset: 0x004AE140
			public virtual AsyncUnaryCall<CreateSessionResponse> CreateSessionAsync(CreateSessionRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.CreateSessionAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D0C5 RID: 53445 RVA: 0x004AFF68 File Offset: 0x004AE168
			public virtual AsyncUnaryCall<CreateSessionResponse> CreateSessionAsync(CreateSessionRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<CreateSessionRequest, CreateSessionResponse>(SessionService.__Method_CreateSession, null, options, request);
			}

			// Token: 0x0600D0C6 RID: 53446 RVA: 0x004AFF90 File Offset: 0x004AE190
			public virtual NoData DestroySession(DestroySessionRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.DestroySession(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D0C7 RID: 53447 RVA: 0x004AFFB8 File Offset: 0x004AE1B8
			public virtual NoData DestroySession(DestroySessionRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<DestroySessionRequest, NoData>(SessionService.__Method_DestroySession, null, options, request);
			}

			// Token: 0x0600D0C8 RID: 53448 RVA: 0x004AFFE0 File Offset: 0x004AE1E0
			public virtual AsyncUnaryCall<NoData> DestroySessionAsync(DestroySessionRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.DestroySessionAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D0C9 RID: 53449 RVA: 0x004B0008 File Offset: 0x004AE208
			public virtual AsyncUnaryCall<NoData> DestroySessionAsync(DestroySessionRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<DestroySessionRequest, NoData>(SessionService.__Method_DestroySession, null, options, request);
			}

			// Token: 0x0600D0CA RID: 53450 RVA: 0x004B0030 File Offset: 0x004AE230
			public virtual NoData UpdateSession(UpdateSessionRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UpdateSession(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D0CB RID: 53451 RVA: 0x004B0058 File Offset: 0x004AE258
			public virtual NoData UpdateSession(UpdateSessionRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<UpdateSessionRequest, NoData>(SessionService.__Method_UpdateSession, null, options, request);
			}

			// Token: 0x0600D0CC RID: 53452 RVA: 0x004B0080 File Offset: 0x004AE280
			public virtual AsyncUnaryCall<NoData> UpdateSessionAsync(UpdateSessionRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UpdateSessionAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D0CD RID: 53453 RVA: 0x004B00A8 File Offset: 0x004AE2A8
			public virtual AsyncUnaryCall<NoData> UpdateSessionAsync(UpdateSessionRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<UpdateSessionRequest, NoData>(SessionService.__Method_UpdateSession, null, options, request);
			}

			// Token: 0x0600D0CE RID: 53454 RVA: 0x004B00D0 File Offset: 0x004AE2D0
			public virtual GetSessionCapacityResponse GetSessionCapacity(GetSessionCapacityRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetSessionCapacity(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D0CF RID: 53455 RVA: 0x004B00F8 File Offset: 0x004AE2F8
			public virtual GetSessionCapacityResponse GetSessionCapacity(GetSessionCapacityRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetSessionCapacityRequest, GetSessionCapacityResponse>(SessionService.__Method_GetSessionCapacity, null, options, request);
			}

			// Token: 0x0600D0D0 RID: 53456 RVA: 0x004B0120 File Offset: 0x004AE320
			public virtual AsyncUnaryCall<GetSessionCapacityResponse> GetSessionCapacityAsync(GetSessionCapacityRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetSessionCapacityAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D0D1 RID: 53457 RVA: 0x004B0148 File Offset: 0x004AE348
			public virtual AsyncUnaryCall<GetSessionCapacityResponse> GetSessionCapacityAsync(GetSessionCapacityRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetSessionCapacityRequest, GetSessionCapacityResponse>(SessionService.__Method_GetSessionCapacity, null, options, request);
			}

			// Token: 0x0600D0D2 RID: 53458 RVA: 0x004B0170 File Offset: 0x004AE370
			public virtual GetSessionStateByBenefactorResponse GetSessionStateByBenefactor(GetSessionStateByBenefactorRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetSessionStateByBenefactor(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D0D3 RID: 53459 RVA: 0x004B0198 File Offset: 0x004AE398
			public virtual GetSessionStateByBenefactorResponse GetSessionStateByBenefactor(GetSessionStateByBenefactorRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetSessionStateByBenefactorRequest, GetSessionStateByBenefactorResponse>(SessionService.__Method_GetSessionStateByBenefactor, null, options, request);
			}

			// Token: 0x0600D0D4 RID: 53460 RVA: 0x004B01C0 File Offset: 0x004AE3C0
			public virtual AsyncUnaryCall<GetSessionStateByBenefactorResponse> GetSessionStateByBenefactorAsync(GetSessionStateByBenefactorRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetSessionStateByBenefactorAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D0D5 RID: 53461 RVA: 0x004B01E8 File Offset: 0x004AE3E8
			public virtual AsyncUnaryCall<GetSessionStateByBenefactorResponse> GetSessionStateByBenefactorAsync(GetSessionStateByBenefactorRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetSessionStateByBenefactorRequest, GetSessionStateByBenefactorResponse>(SessionService.__Method_GetSessionStateByBenefactor, null, options, request);
			}

			// Token: 0x0600D0D6 RID: 53462 RVA: 0x004B0210 File Offset: 0x004AE410
			public virtual MarkSessionsAliveResponse MarkSessionsAlive(MarkSessionsAliveRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.MarkSessionsAlive(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D0D7 RID: 53463 RVA: 0x004B0238 File Offset: 0x004AE438
			public virtual MarkSessionsAliveResponse MarkSessionsAlive(MarkSessionsAliveRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<MarkSessionsAliveRequest, MarkSessionsAliveResponse>(SessionService.__Method_MarkSessionsAlive, null, options, request);
			}

			// Token: 0x0600D0D8 RID: 53464 RVA: 0x004B0260 File Offset: 0x004AE460
			public virtual AsyncUnaryCall<MarkSessionsAliveResponse> MarkSessionsAliveAsync(MarkSessionsAliveRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.MarkSessionsAliveAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D0D9 RID: 53465 RVA: 0x004B0288 File Offset: 0x004AE488
			public virtual AsyncUnaryCall<MarkSessionsAliveResponse> MarkSessionsAliveAsync(MarkSessionsAliveRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<MarkSessionsAliveRequest, MarkSessionsAliveResponse>(SessionService.__Method_MarkSessionsAlive, null, options, request);
			}

			// Token: 0x0600D0DA RID: 53466 RVA: 0x004B02B0 File Offset: 0x004AE4B0
			public virtual GetSessionStateResponse GetSessionState(GetSessionStateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetSessionState(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D0DB RID: 53467 RVA: 0x004B02D8 File Offset: 0x004AE4D8
			public virtual GetSessionStateResponse GetSessionState(GetSessionStateRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetSessionStateRequest, GetSessionStateResponse>(SessionService.__Method_GetSessionState, null, options, request);
			}

			// Token: 0x0600D0DC RID: 53468 RVA: 0x004B0300 File Offset: 0x004AE500
			public virtual AsyncUnaryCall<GetSessionStateResponse> GetSessionStateAsync(GetSessionStateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetSessionStateAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D0DD RID: 53469 RVA: 0x004B0328 File Offset: 0x004AE528
			public virtual AsyncUnaryCall<GetSessionStateResponse> GetSessionStateAsync(GetSessionStateRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetSessionStateRequest, GetSessionStateResponse>(SessionService.__Method_GetSessionState, null, options, request);
			}

			// Token: 0x0600D0DE RID: 53470 RVA: 0x004B0350 File Offset: 0x004AE550
			public virtual GetSignedSessionStateResponse GetSignedSessionState(GetSignedSessionStateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetSignedSessionState(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D0DF RID: 53471 RVA: 0x004B0378 File Offset: 0x004AE578
			public virtual GetSignedSessionStateResponse GetSignedSessionState(GetSignedSessionStateRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetSignedSessionStateRequest, GetSignedSessionStateResponse>(SessionService.__Method_GetSignedSessionState, null, options, request);
			}

			// Token: 0x0600D0E0 RID: 53472 RVA: 0x004B03A0 File Offset: 0x004AE5A0
			public virtual AsyncUnaryCall<GetSignedSessionStateResponse> GetSignedSessionStateAsync(GetSignedSessionStateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetSignedSessionStateAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D0E1 RID: 53473 RVA: 0x004B03C8 File Offset: 0x004AE5C8
			public virtual AsyncUnaryCall<GetSignedSessionStateResponse> GetSignedSessionStateAsync(GetSignedSessionStateRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetSignedSessionStateRequest, GetSignedSessionStateResponse>(SessionService.__Method_GetSignedSessionState, null, options, request);
			}

			// Token: 0x0600D0E2 RID: 53474 RVA: 0x004B03F0 File Offset: 0x004AE5F0
			public virtual RefreshSessionKeyResponse RefreshSessionKey(RefreshSessionKeyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.RefreshSessionKey(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D0E3 RID: 53475 RVA: 0x004B0418 File Offset: 0x004AE618
			public virtual RefreshSessionKeyResponse RefreshSessionKey(RefreshSessionKeyRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<RefreshSessionKeyRequest, RefreshSessionKeyResponse>(SessionService.__Method_RefreshSessionKey, null, options, request);
			}

			// Token: 0x0600D0E4 RID: 53476 RVA: 0x004B0440 File Offset: 0x004AE640
			public virtual AsyncUnaryCall<RefreshSessionKeyResponse> RefreshSessionKeyAsync(RefreshSessionKeyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.RefreshSessionKeyAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D0E5 RID: 53477 RVA: 0x004B0468 File Offset: 0x004AE668
			public virtual AsyncUnaryCall<RefreshSessionKeyResponse> RefreshSessionKeyAsync(RefreshSessionKeyRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<RefreshSessionKeyRequest, RefreshSessionKeyResponse>(SessionService.__Method_RefreshSessionKey, null, options, request);
			}

			// Token: 0x0600D0E6 RID: 53478 RVA: 0x004B0490 File Offset: 0x004AE690
			protected override SessionService.SessionServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new SessionService.SessionServiceClient(configuration);
			}
		}
	}
}
