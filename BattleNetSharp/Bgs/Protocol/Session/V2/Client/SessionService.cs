using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x02000564 RID: 1380
	public static class SessionService
	{
		// Token: 0x06008503 RID: 34051 RVA: 0x00204E94 File Offset: 0x00203094
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

		// Token: 0x06008504 RID: 34052 RVA: 0x00204EE0 File Offset: 0x002030E0
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

		// Token: 0x170029F2 RID: 10738
		// (get) Token: 0x06008505 RID: 34053 RVA: 0x00204F18 File Offset: 0x00203118
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x06008506 RID: 34054 RVA: 0x00204F3C File Offset: 0x0020313C
		public static ServerServiceDefinition BindService(SessionService.SessionServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<CreateSessionRequest, CreateSessionResponse>(SessionService.__Method_CreateSession, new UnaryServerMethod<CreateSessionRequest, CreateSessionResponse>(serviceImpl.CreateSession)).AddMethod<RestoreSessionRequest, RestoreSessionResponse>(SessionService.__Method_RestoreSession, new UnaryServerMethod<RestoreSessionRequest, RestoreSessionResponse>(serviceImpl.RestoreSession))
				.AddMethod<DestroySessionRequest, NoData>(SessionService.__Method_DestroySession, new UnaryServerMethod<DestroySessionRequest, NoData>(serviceImpl.DestroySession))
				.AddMethod<GetSignedSessionStateRequest, GetSignedSessionStateResponse>(SessionService.__Method_GetSignedSessionState, new UnaryServerMethod<GetSignedSessionStateRequest, GetSignedSessionStateResponse>(serviceImpl.GetSignedSessionState))
				.AddMethod<GetSessionStateRequest, GetSessionStateResponse>(SessionService.__Method_GetSessionState, new UnaryServerMethod<GetSessionStateRequest, GetSessionStateResponse>(serviceImpl.GetSessionState))
				.AddMethod<MarkSessionAliveRequest, NoData>(SessionService.__Method_MarkSessionAlive, new UnaryServerMethod<MarkSessionAliveRequest, NoData>(serviceImpl.MarkSessionAlive))
				.Build();
		}

		// Token: 0x06008507 RID: 34055 RVA: 0x00204FE4 File Offset: 0x002031E4
		public static void BindService(ServiceBinderBase serviceBinder, SessionService.SessionServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<CreateSessionRequest, CreateSessionResponse>(SessionService.__Method_CreateSession, (serviceImpl == null) ? null : new UnaryServerMethod<CreateSessionRequest, CreateSessionResponse>(serviceImpl.CreateSession));
			serviceBinder.AddMethod<RestoreSessionRequest, RestoreSessionResponse>(SessionService.__Method_RestoreSession, (serviceImpl == null) ? null : new UnaryServerMethod<RestoreSessionRequest, RestoreSessionResponse>(serviceImpl.RestoreSession));
			serviceBinder.AddMethod<DestroySessionRequest, NoData>(SessionService.__Method_DestroySession, (serviceImpl == null) ? null : new UnaryServerMethod<DestroySessionRequest, NoData>(serviceImpl.DestroySession));
			serviceBinder.AddMethod<GetSignedSessionStateRequest, GetSignedSessionStateResponse>(SessionService.__Method_GetSignedSessionState, (serviceImpl == null) ? null : new UnaryServerMethod<GetSignedSessionStateRequest, GetSignedSessionStateResponse>(serviceImpl.GetSignedSessionState));
			serviceBinder.AddMethod<GetSessionStateRequest, GetSessionStateResponse>(SessionService.__Method_GetSessionState, (serviceImpl == null) ? null : new UnaryServerMethod<GetSessionStateRequest, GetSessionStateResponse>(serviceImpl.GetSessionState));
			serviceBinder.AddMethod<MarkSessionAliveRequest, NoData>(SessionService.__Method_MarkSessionAlive, (serviceImpl == null) ? null : new UnaryServerMethod<MarkSessionAliveRequest, NoData>(serviceImpl.MarkSessionAlive));
		}

		// Token: 0x04003C38 RID: 15416
		private static readonly string __ServiceName = "bgs.protocol.session.v2.client.SessionService";

		// Token: 0x04003C39 RID: 15417
		private static readonly Marshaller<CreateSessionRequest> __Marshaller_bgs_protocol_session_v2_client_CreateSessionRequest = Marshallers.Create<CreateSessionRequest>(new Action<CreateSessionRequest, SerializationContext>(SessionService.__Helper_SerializeMessage), (DeserializationContext context) => SessionService.__Helper_DeserializeMessage<CreateSessionRequest>(context, CreateSessionRequest.Parser));

		// Token: 0x04003C3A RID: 15418
		private static readonly Marshaller<CreateSessionResponse> __Marshaller_bgs_protocol_session_v2_client_CreateSessionResponse = Marshallers.Create<CreateSessionResponse>(new Action<CreateSessionResponse, SerializationContext>(SessionService.__Helper_SerializeMessage), (DeserializationContext context) => SessionService.__Helper_DeserializeMessage<CreateSessionResponse>(context, CreateSessionResponse.Parser));

		// Token: 0x04003C3B RID: 15419
		private static readonly Marshaller<RestoreSessionRequest> __Marshaller_bgs_protocol_session_v2_client_RestoreSessionRequest = Marshallers.Create<RestoreSessionRequest>(new Action<RestoreSessionRequest, SerializationContext>(SessionService.__Helper_SerializeMessage), (DeserializationContext context) => SessionService.__Helper_DeserializeMessage<RestoreSessionRequest>(context, RestoreSessionRequest.Parser));

		// Token: 0x04003C3C RID: 15420
		private static readonly Marshaller<RestoreSessionResponse> __Marshaller_bgs_protocol_session_v2_client_RestoreSessionResponse = Marshallers.Create<RestoreSessionResponse>(new Action<RestoreSessionResponse, SerializationContext>(SessionService.__Helper_SerializeMessage), (DeserializationContext context) => SessionService.__Helper_DeserializeMessage<RestoreSessionResponse>(context, RestoreSessionResponse.Parser));

		// Token: 0x04003C3D RID: 15421
		private static readonly Marshaller<DestroySessionRequest> __Marshaller_bgs_protocol_session_v2_client_DestroySessionRequest = Marshallers.Create<DestroySessionRequest>(new Action<DestroySessionRequest, SerializationContext>(SessionService.__Helper_SerializeMessage), (DeserializationContext context) => SessionService.__Helper_DeserializeMessage<DestroySessionRequest>(context, DestroySessionRequest.Parser));

		// Token: 0x04003C3E RID: 15422
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(SessionService.__Helper_SerializeMessage), (DeserializationContext context) => SessionService.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x04003C3F RID: 15423
		private static readonly Marshaller<GetSignedSessionStateRequest> __Marshaller_bgs_protocol_session_v2_client_GetSignedSessionStateRequest = Marshallers.Create<GetSignedSessionStateRequest>(new Action<GetSignedSessionStateRequest, SerializationContext>(SessionService.__Helper_SerializeMessage), (DeserializationContext context) => SessionService.__Helper_DeserializeMessage<GetSignedSessionStateRequest>(context, GetSignedSessionStateRequest.Parser));

		// Token: 0x04003C40 RID: 15424
		private static readonly Marshaller<GetSignedSessionStateResponse> __Marshaller_bgs_protocol_session_v2_client_GetSignedSessionStateResponse = Marshallers.Create<GetSignedSessionStateResponse>(new Action<GetSignedSessionStateResponse, SerializationContext>(SessionService.__Helper_SerializeMessage), (DeserializationContext context) => SessionService.__Helper_DeserializeMessage<GetSignedSessionStateResponse>(context, GetSignedSessionStateResponse.Parser));

		// Token: 0x04003C41 RID: 15425
		private static readonly Marshaller<GetSessionStateRequest> __Marshaller_bgs_protocol_session_v2_client_GetSessionStateRequest = Marshallers.Create<GetSessionStateRequest>(new Action<GetSessionStateRequest, SerializationContext>(SessionService.__Helper_SerializeMessage), (DeserializationContext context) => SessionService.__Helper_DeserializeMessage<GetSessionStateRequest>(context, GetSessionStateRequest.Parser));

		// Token: 0x04003C42 RID: 15426
		private static readonly Marshaller<GetSessionStateResponse> __Marshaller_bgs_protocol_session_v2_client_GetSessionStateResponse = Marshallers.Create<GetSessionStateResponse>(new Action<GetSessionStateResponse, SerializationContext>(SessionService.__Helper_SerializeMessage), (DeserializationContext context) => SessionService.__Helper_DeserializeMessage<GetSessionStateResponse>(context, GetSessionStateResponse.Parser));

		// Token: 0x04003C43 RID: 15427
		private static readonly Marshaller<MarkSessionAliveRequest> __Marshaller_bgs_protocol_session_v2_client_MarkSessionAliveRequest = Marshallers.Create<MarkSessionAliveRequest>(new Action<MarkSessionAliveRequest, SerializationContext>(SessionService.__Helper_SerializeMessage), (DeserializationContext context) => SessionService.__Helper_DeserializeMessage<MarkSessionAliveRequest>(context, MarkSessionAliveRequest.Parser));

		// Token: 0x04003C44 RID: 15428
		private static readonly Method<CreateSessionRequest, CreateSessionResponse> __Method_CreateSession = new Method<CreateSessionRequest, CreateSessionResponse>(0, SessionService.__ServiceName, "CreateSession", SessionService.__Marshaller_bgs_protocol_session_v2_client_CreateSessionRequest, SessionService.__Marshaller_bgs_protocol_session_v2_client_CreateSessionResponse);

		// Token: 0x04003C45 RID: 15429
		private static readonly Method<RestoreSessionRequest, RestoreSessionResponse> __Method_RestoreSession = new Method<RestoreSessionRequest, RestoreSessionResponse>(0, SessionService.__ServiceName, "RestoreSession", SessionService.__Marshaller_bgs_protocol_session_v2_client_RestoreSessionRequest, SessionService.__Marshaller_bgs_protocol_session_v2_client_RestoreSessionResponse);

		// Token: 0x04003C46 RID: 15430
		private static readonly Method<DestroySessionRequest, NoData> __Method_DestroySession = new Method<DestroySessionRequest, NoData>(0, SessionService.__ServiceName, "DestroySession", SessionService.__Marshaller_bgs_protocol_session_v2_client_DestroySessionRequest, SessionService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04003C47 RID: 15431
		private static readonly Method<GetSignedSessionStateRequest, GetSignedSessionStateResponse> __Method_GetSignedSessionState = new Method<GetSignedSessionStateRequest, GetSignedSessionStateResponse>(0, SessionService.__ServiceName, "GetSignedSessionState", SessionService.__Marshaller_bgs_protocol_session_v2_client_GetSignedSessionStateRequest, SessionService.__Marshaller_bgs_protocol_session_v2_client_GetSignedSessionStateResponse);

		// Token: 0x04003C48 RID: 15432
		private static readonly Method<GetSessionStateRequest, GetSessionStateResponse> __Method_GetSessionState = new Method<GetSessionStateRequest, GetSessionStateResponse>(0, SessionService.__ServiceName, "GetSessionState", SessionService.__Marshaller_bgs_protocol_session_v2_client_GetSessionStateRequest, SessionService.__Marshaller_bgs_protocol_session_v2_client_GetSessionStateResponse);

		// Token: 0x04003C49 RID: 15433
		private static readonly Method<MarkSessionAliveRequest, NoData> __Method_MarkSessionAlive = new Method<MarkSessionAliveRequest, NoData>(0, SessionService.__ServiceName, "MarkSessionAlive", SessionService.__Marshaller_bgs_protocol_session_v2_client_MarkSessionAliveRequest, SessionService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x02001037 RID: 4151
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x04009784 RID: 38788
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02001038 RID: 4152
		[BindServiceMethod(typeof(SessionService), "BindService")]
		public abstract class SessionServiceBase
		{
			// Token: 0x0600D162 RID: 53602 RVA: 0x004B0C64 File Offset: 0x004AEE64
			public virtual Task<CreateSessionResponse> CreateSession(CreateSessionRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D163 RID: 53603 RVA: 0x004B0C78 File Offset: 0x004AEE78
			public virtual Task<RestoreSessionResponse> RestoreSession(RestoreSessionRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D164 RID: 53604 RVA: 0x004B0C8C File Offset: 0x004AEE8C
			public virtual Task<NoData> DestroySession(DestroySessionRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D165 RID: 53605 RVA: 0x004B0CA0 File Offset: 0x004AEEA0
			public virtual Task<GetSignedSessionStateResponse> GetSignedSessionState(GetSignedSessionStateRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D166 RID: 53606 RVA: 0x004B0CB4 File Offset: 0x004AEEB4
			public virtual Task<GetSessionStateResponse> GetSessionState(GetSessionStateRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D167 RID: 53607 RVA: 0x004B0CC8 File Offset: 0x004AEEC8
			public virtual Task<NoData> MarkSessionAlive(MarkSessionAliveRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x02001039 RID: 4153
		public class SessionServiceClient : ClientBase<SessionService.SessionServiceClient>
		{
			// Token: 0x0600D169 RID: 53609 RVA: 0x004B0CE5 File Offset: 0x004AEEE5
			public SessionServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D16A RID: 53610 RVA: 0x004B0CF0 File Offset: 0x004AEEF0
			public SessionServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D16B RID: 53611 RVA: 0x004B0CFB File Offset: 0x004AEEFB
			protected SessionServiceClient()
			{
			}

			// Token: 0x0600D16C RID: 53612 RVA: 0x004B0D05 File Offset: 0x004AEF05
			protected SessionServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D16D RID: 53613 RVA: 0x004B0D10 File Offset: 0x004AEF10
			public virtual CreateSessionResponse CreateSession(CreateSessionRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.CreateSession(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D16E RID: 53614 RVA: 0x004B0D38 File Offset: 0x004AEF38
			public virtual CreateSessionResponse CreateSession(CreateSessionRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<CreateSessionRequest, CreateSessionResponse>(SessionService.__Method_CreateSession, null, options, request);
			}

			// Token: 0x0600D16F RID: 53615 RVA: 0x004B0D60 File Offset: 0x004AEF60
			public virtual AsyncUnaryCall<CreateSessionResponse> CreateSessionAsync(CreateSessionRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.CreateSessionAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D170 RID: 53616 RVA: 0x004B0D88 File Offset: 0x004AEF88
			public virtual AsyncUnaryCall<CreateSessionResponse> CreateSessionAsync(CreateSessionRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<CreateSessionRequest, CreateSessionResponse>(SessionService.__Method_CreateSession, null, options, request);
			}

			// Token: 0x0600D171 RID: 53617 RVA: 0x004B0DB0 File Offset: 0x004AEFB0
			public virtual RestoreSessionResponse RestoreSession(RestoreSessionRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.RestoreSession(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D172 RID: 53618 RVA: 0x004B0DD8 File Offset: 0x004AEFD8
			public virtual RestoreSessionResponse RestoreSession(RestoreSessionRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<RestoreSessionRequest, RestoreSessionResponse>(SessionService.__Method_RestoreSession, null, options, request);
			}

			// Token: 0x0600D173 RID: 53619 RVA: 0x004B0E00 File Offset: 0x004AF000
			public virtual AsyncUnaryCall<RestoreSessionResponse> RestoreSessionAsync(RestoreSessionRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.RestoreSessionAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D174 RID: 53620 RVA: 0x004B0E28 File Offset: 0x004AF028
			public virtual AsyncUnaryCall<RestoreSessionResponse> RestoreSessionAsync(RestoreSessionRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<RestoreSessionRequest, RestoreSessionResponse>(SessionService.__Method_RestoreSession, null, options, request);
			}

			// Token: 0x0600D175 RID: 53621 RVA: 0x004B0E50 File Offset: 0x004AF050
			public virtual NoData DestroySession(DestroySessionRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.DestroySession(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D176 RID: 53622 RVA: 0x004B0E78 File Offset: 0x004AF078
			public virtual NoData DestroySession(DestroySessionRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<DestroySessionRequest, NoData>(SessionService.__Method_DestroySession, null, options, request);
			}

			// Token: 0x0600D177 RID: 53623 RVA: 0x004B0EA0 File Offset: 0x004AF0A0
			public virtual AsyncUnaryCall<NoData> DestroySessionAsync(DestroySessionRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.DestroySessionAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D178 RID: 53624 RVA: 0x004B0EC8 File Offset: 0x004AF0C8
			public virtual AsyncUnaryCall<NoData> DestroySessionAsync(DestroySessionRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<DestroySessionRequest, NoData>(SessionService.__Method_DestroySession, null, options, request);
			}

			// Token: 0x0600D179 RID: 53625 RVA: 0x004B0EF0 File Offset: 0x004AF0F0
			public virtual GetSignedSessionStateResponse GetSignedSessionState(GetSignedSessionStateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetSignedSessionState(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D17A RID: 53626 RVA: 0x004B0F18 File Offset: 0x004AF118
			public virtual GetSignedSessionStateResponse GetSignedSessionState(GetSignedSessionStateRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetSignedSessionStateRequest, GetSignedSessionStateResponse>(SessionService.__Method_GetSignedSessionState, null, options, request);
			}

			// Token: 0x0600D17B RID: 53627 RVA: 0x004B0F40 File Offset: 0x004AF140
			public virtual AsyncUnaryCall<GetSignedSessionStateResponse> GetSignedSessionStateAsync(GetSignedSessionStateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetSignedSessionStateAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D17C RID: 53628 RVA: 0x004B0F68 File Offset: 0x004AF168
			public virtual AsyncUnaryCall<GetSignedSessionStateResponse> GetSignedSessionStateAsync(GetSignedSessionStateRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetSignedSessionStateRequest, GetSignedSessionStateResponse>(SessionService.__Method_GetSignedSessionState, null, options, request);
			}

			// Token: 0x0600D17D RID: 53629 RVA: 0x004B0F90 File Offset: 0x004AF190
			public virtual GetSessionStateResponse GetSessionState(GetSessionStateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetSessionState(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D17E RID: 53630 RVA: 0x004B0FB8 File Offset: 0x004AF1B8
			public virtual GetSessionStateResponse GetSessionState(GetSessionStateRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetSessionStateRequest, GetSessionStateResponse>(SessionService.__Method_GetSessionState, null, options, request);
			}

			// Token: 0x0600D17F RID: 53631 RVA: 0x004B0FE0 File Offset: 0x004AF1E0
			public virtual AsyncUnaryCall<GetSessionStateResponse> GetSessionStateAsync(GetSessionStateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetSessionStateAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D180 RID: 53632 RVA: 0x004B1008 File Offset: 0x004AF208
			public virtual AsyncUnaryCall<GetSessionStateResponse> GetSessionStateAsync(GetSessionStateRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetSessionStateRequest, GetSessionStateResponse>(SessionService.__Method_GetSessionState, null, options, request);
			}

			// Token: 0x0600D181 RID: 53633 RVA: 0x004B1030 File Offset: 0x004AF230
			public virtual NoData MarkSessionAlive(MarkSessionAliveRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.MarkSessionAlive(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D182 RID: 53634 RVA: 0x004B1058 File Offset: 0x004AF258
			public virtual NoData MarkSessionAlive(MarkSessionAliveRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<MarkSessionAliveRequest, NoData>(SessionService.__Method_MarkSessionAlive, null, options, request);
			}

			// Token: 0x0600D183 RID: 53635 RVA: 0x004B1080 File Offset: 0x004AF280
			public virtual AsyncUnaryCall<NoData> MarkSessionAliveAsync(MarkSessionAliveRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.MarkSessionAliveAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D184 RID: 53636 RVA: 0x004B10A8 File Offset: 0x004AF2A8
			public virtual AsyncUnaryCall<NoData> MarkSessionAliveAsync(MarkSessionAliveRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<MarkSessionAliveRequest, NoData>(SessionService.__Method_MarkSessionAlive, null, options, request);
			}

			// Token: 0x0600D185 RID: 53637 RVA: 0x004B10D0 File Offset: 0x004AF2D0
			protected override SessionService.SessionServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new SessionService.SessionServiceClient(configuration);
			}
		}
	}
}
