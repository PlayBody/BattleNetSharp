using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x02000558 RID: 1368
	public static class SessionListener
	{
		// Token: 0x06008435 RID: 33845 RVA: 0x002022AC File Offset: 0x002004AC
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

		// Token: 0x06008436 RID: 33846 RVA: 0x002022F8 File Offset: 0x002004F8
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = SessionListener.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x170029C4 RID: 10692
		// (get) Token: 0x06008437 RID: 33847 RVA: 0x00202330 File Offset: 0x00200530
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return SessionListenerReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x06008438 RID: 33848 RVA: 0x00202354 File Offset: 0x00200554
		public static ServerServiceDefinition BindService(SessionListener.SessionListenerBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<SessionCreatedNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionCreated, new UnaryServerMethod<SessionCreatedNotification, NO_RESPONSE>(serviceImpl.OnSessionCreated)).AddMethod<SessionDestroyedNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionDestroyed, new UnaryServerMethod<SessionDestroyedNotification, NO_RESPONSE>(serviceImpl.OnSessionDestroyed))
				.AddMethod<SessionGameTimeWarningNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionGameTimeWarning, new UnaryServerMethod<SessionGameTimeWarningNotification, NO_RESPONSE>(serviceImpl.OnSessionGameTimeWarning))
				.AddMethod<SessionQueueUpdatedNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionQueueUpdated, new UnaryServerMethod<SessionQueueUpdatedNotification, NO_RESPONSE>(serviceImpl.OnSessionQueueUpdated))
				.AddMethod<SessionQueueEndNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionQueueEnd, new UnaryServerMethod<SessionQueueEndNotification, NO_RESPONSE>(serviceImpl.OnSessionQueueEnd))
				.Build();
		}

		// Token: 0x06008439 RID: 33849 RVA: 0x002023E4 File Offset: 0x002005E4
		public static void BindService(ServiceBinderBase serviceBinder, SessionListener.SessionListenerBase serviceImpl)
		{
			serviceBinder.AddMethod<SessionCreatedNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionCreated, (serviceImpl == null) ? null : new UnaryServerMethod<SessionCreatedNotification, NO_RESPONSE>(serviceImpl.OnSessionCreated));
			serviceBinder.AddMethod<SessionDestroyedNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionDestroyed, (serviceImpl == null) ? null : new UnaryServerMethod<SessionDestroyedNotification, NO_RESPONSE>(serviceImpl.OnSessionDestroyed));
			serviceBinder.AddMethod<SessionGameTimeWarningNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionGameTimeWarning, (serviceImpl == null) ? null : new UnaryServerMethod<SessionGameTimeWarningNotification, NO_RESPONSE>(serviceImpl.OnSessionGameTimeWarning));
			serviceBinder.AddMethod<SessionQueueUpdatedNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionQueueUpdated, (serviceImpl == null) ? null : new UnaryServerMethod<SessionQueueUpdatedNotification, NO_RESPONSE>(serviceImpl.OnSessionQueueUpdated));
			serviceBinder.AddMethod<SessionQueueEndNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionQueueEnd, (serviceImpl == null) ? null : new UnaryServerMethod<SessionQueueEndNotification, NO_RESPONSE>(serviceImpl.OnSessionQueueEnd));
		}

		// Token: 0x04003BFD RID: 15357
		private static readonly string __ServiceName = "bgs.protocol.session.v2.client.SessionListener";

		// Token: 0x04003BFE RID: 15358
		private static readonly Marshaller<SessionCreatedNotification> __Marshaller_bgs_protocol_session_v2_client_SessionCreatedNotification = Marshallers.Create<SessionCreatedNotification>(new Action<SessionCreatedNotification, SerializationContext>(SessionListener.__Helper_SerializeMessage), (DeserializationContext context) => SessionListener.__Helper_DeserializeMessage<SessionCreatedNotification>(context, SessionCreatedNotification.Parser));

		// Token: 0x04003BFF RID: 15359
		private static readonly Marshaller<NO_RESPONSE> __Marshaller_bgs_protocol_NO_RESPONSE = Marshallers.Create<NO_RESPONSE>(new Action<NO_RESPONSE, SerializationContext>(SessionListener.__Helper_SerializeMessage), (DeserializationContext context) => SessionListener.__Helper_DeserializeMessage<NO_RESPONSE>(context, NO_RESPONSE.Parser));

		// Token: 0x04003C00 RID: 15360
		private static readonly Marshaller<SessionDestroyedNotification> __Marshaller_bgs_protocol_session_v2_client_SessionDestroyedNotification = Marshallers.Create<SessionDestroyedNotification>(new Action<SessionDestroyedNotification, SerializationContext>(SessionListener.__Helper_SerializeMessage), (DeserializationContext context) => SessionListener.__Helper_DeserializeMessage<SessionDestroyedNotification>(context, SessionDestroyedNotification.Parser));

		// Token: 0x04003C01 RID: 15361
		private static readonly Marshaller<SessionGameTimeWarningNotification> __Marshaller_bgs_protocol_session_v2_client_SessionGameTimeWarningNotification = Marshallers.Create<SessionGameTimeWarningNotification>(new Action<SessionGameTimeWarningNotification, SerializationContext>(SessionListener.__Helper_SerializeMessage), (DeserializationContext context) => SessionListener.__Helper_DeserializeMessage<SessionGameTimeWarningNotification>(context, SessionGameTimeWarningNotification.Parser));

		// Token: 0x04003C02 RID: 15362
		private static readonly Marshaller<SessionQueueUpdatedNotification> __Marshaller_bgs_protocol_session_v2_client_SessionQueueUpdatedNotification = Marshallers.Create<SessionQueueUpdatedNotification>(new Action<SessionQueueUpdatedNotification, SerializationContext>(SessionListener.__Helper_SerializeMessage), (DeserializationContext context) => SessionListener.__Helper_DeserializeMessage<SessionQueueUpdatedNotification>(context, SessionQueueUpdatedNotification.Parser));

		// Token: 0x04003C03 RID: 15363
		private static readonly Marshaller<SessionQueueEndNotification> __Marshaller_bgs_protocol_session_v2_client_SessionQueueEndNotification = Marshallers.Create<SessionQueueEndNotification>(new Action<SessionQueueEndNotification, SerializationContext>(SessionListener.__Helper_SerializeMessage), (DeserializationContext context) => SessionListener.__Helper_DeserializeMessage<SessionQueueEndNotification>(context, SessionQueueEndNotification.Parser));

		// Token: 0x04003C04 RID: 15364
		private static readonly Method<SessionCreatedNotification, NO_RESPONSE> __Method_OnSessionCreated = new Method<SessionCreatedNotification, NO_RESPONSE>(0, SessionListener.__ServiceName, "OnSessionCreated", SessionListener.__Marshaller_bgs_protocol_session_v2_client_SessionCreatedNotification, SessionListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04003C05 RID: 15365
		private static readonly Method<SessionDestroyedNotification, NO_RESPONSE> __Method_OnSessionDestroyed = new Method<SessionDestroyedNotification, NO_RESPONSE>(0, SessionListener.__ServiceName, "OnSessionDestroyed", SessionListener.__Marshaller_bgs_protocol_session_v2_client_SessionDestroyedNotification, SessionListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04003C06 RID: 15366
		private static readonly Method<SessionGameTimeWarningNotification, NO_RESPONSE> __Method_OnSessionGameTimeWarning = new Method<SessionGameTimeWarningNotification, NO_RESPONSE>(0, SessionListener.__ServiceName, "OnSessionGameTimeWarning", SessionListener.__Marshaller_bgs_protocol_session_v2_client_SessionGameTimeWarningNotification, SessionListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04003C07 RID: 15367
		private static readonly Method<SessionQueueUpdatedNotification, NO_RESPONSE> __Method_OnSessionQueueUpdated = new Method<SessionQueueUpdatedNotification, NO_RESPONSE>(0, SessionListener.__ServiceName, "OnSessionQueueUpdated", SessionListener.__Marshaller_bgs_protocol_session_v2_client_SessionQueueUpdatedNotification, SessionListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04003C08 RID: 15368
		private static readonly Method<SessionQueueEndNotification, NO_RESPONSE> __Method_OnSessionQueueEnd = new Method<SessionQueueEndNotification, NO_RESPONSE>(0, SessionListener.__ServiceName, "OnSessionQueueEnd", SessionListener.__Marshaller_bgs_protocol_session_v2_client_SessionQueueEndNotification, SessionListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x02001029 RID: 4137
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x04009778 RID: 38776
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x0200102A RID: 4138
		[BindServiceMethod(typeof(SessionListener), "BindService")]
		public abstract class SessionListenerBase
		{
			// Token: 0x0600D11C RID: 53532 RVA: 0x004B06F3 File Offset: 0x004AE8F3
			public virtual Task<NO_RESPONSE> OnSessionCreated(SessionCreatedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D11D RID: 53533 RVA: 0x004B0707 File Offset: 0x004AE907
			public virtual Task<NO_RESPONSE> OnSessionDestroyed(SessionDestroyedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D11E RID: 53534 RVA: 0x004B071B File Offset: 0x004AE91B
			public virtual Task<NO_RESPONSE> OnSessionGameTimeWarning(SessionGameTimeWarningNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D11F RID: 53535 RVA: 0x004B072F File Offset: 0x004AE92F
			public virtual Task<NO_RESPONSE> OnSessionQueueUpdated(SessionQueueUpdatedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D120 RID: 53536 RVA: 0x004B0743 File Offset: 0x004AE943
			public virtual Task<NO_RESPONSE> OnSessionQueueEnd(SessionQueueEndNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x0200102B RID: 4139
		public class SessionListenerClient : ClientBase<SessionListener.SessionListenerClient>
		{
			// Token: 0x0600D122 RID: 53538 RVA: 0x004B0760 File Offset: 0x004AE960
			public SessionListenerClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D123 RID: 53539 RVA: 0x004B076B File Offset: 0x004AE96B
			public SessionListenerClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D124 RID: 53540 RVA: 0x004B0776 File Offset: 0x004AE976
			protected SessionListenerClient()
			{
			}

			// Token: 0x0600D125 RID: 53541 RVA: 0x004B0780 File Offset: 0x004AE980
			protected SessionListenerClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D126 RID: 53542 RVA: 0x004B078C File Offset: 0x004AE98C
			public virtual NO_RESPONSE OnSessionCreated(SessionCreatedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSessionCreated(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D127 RID: 53543 RVA: 0x004B07B4 File Offset: 0x004AE9B4
			public virtual NO_RESPONSE OnSessionCreated(SessionCreatedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SessionCreatedNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionCreated, null, options, request);
			}

			// Token: 0x0600D128 RID: 53544 RVA: 0x004B07DC File Offset: 0x004AE9DC
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSessionCreatedAsync(SessionCreatedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSessionCreatedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D129 RID: 53545 RVA: 0x004B0804 File Offset: 0x004AEA04
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSessionCreatedAsync(SessionCreatedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SessionCreatedNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionCreated, null, options, request);
			}

			// Token: 0x0600D12A RID: 53546 RVA: 0x004B082C File Offset: 0x004AEA2C
			public virtual NO_RESPONSE OnSessionDestroyed(SessionDestroyedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSessionDestroyed(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D12B RID: 53547 RVA: 0x004B0854 File Offset: 0x004AEA54
			public virtual NO_RESPONSE OnSessionDestroyed(SessionDestroyedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SessionDestroyedNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionDestroyed, null, options, request);
			}

			// Token: 0x0600D12C RID: 53548 RVA: 0x004B087C File Offset: 0x004AEA7C
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSessionDestroyedAsync(SessionDestroyedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSessionDestroyedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D12D RID: 53549 RVA: 0x004B08A4 File Offset: 0x004AEAA4
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSessionDestroyedAsync(SessionDestroyedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SessionDestroyedNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionDestroyed, null, options, request);
			}

			// Token: 0x0600D12E RID: 53550 RVA: 0x004B08CC File Offset: 0x004AEACC
			public virtual NO_RESPONSE OnSessionGameTimeWarning(SessionGameTimeWarningNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSessionGameTimeWarning(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D12F RID: 53551 RVA: 0x004B08F4 File Offset: 0x004AEAF4
			public virtual NO_RESPONSE OnSessionGameTimeWarning(SessionGameTimeWarningNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SessionGameTimeWarningNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionGameTimeWarning, null, options, request);
			}

			// Token: 0x0600D130 RID: 53552 RVA: 0x004B091C File Offset: 0x004AEB1C
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSessionGameTimeWarningAsync(SessionGameTimeWarningNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSessionGameTimeWarningAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D131 RID: 53553 RVA: 0x004B0944 File Offset: 0x004AEB44
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSessionGameTimeWarningAsync(SessionGameTimeWarningNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SessionGameTimeWarningNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionGameTimeWarning, null, options, request);
			}

			// Token: 0x0600D132 RID: 53554 RVA: 0x004B096C File Offset: 0x004AEB6C
			public virtual NO_RESPONSE OnSessionQueueUpdated(SessionQueueUpdatedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSessionQueueUpdated(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D133 RID: 53555 RVA: 0x004B0994 File Offset: 0x004AEB94
			public virtual NO_RESPONSE OnSessionQueueUpdated(SessionQueueUpdatedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SessionQueueUpdatedNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionQueueUpdated, null, options, request);
			}

			// Token: 0x0600D134 RID: 53556 RVA: 0x004B09BC File Offset: 0x004AEBBC
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSessionQueueUpdatedAsync(SessionQueueUpdatedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSessionQueueUpdatedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D135 RID: 53557 RVA: 0x004B09E4 File Offset: 0x004AEBE4
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSessionQueueUpdatedAsync(SessionQueueUpdatedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SessionQueueUpdatedNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionQueueUpdated, null, options, request);
			}

			// Token: 0x0600D136 RID: 53558 RVA: 0x004B0A0C File Offset: 0x004AEC0C
			public virtual NO_RESPONSE OnSessionQueueEnd(SessionQueueEndNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSessionQueueEnd(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D137 RID: 53559 RVA: 0x004B0A34 File Offset: 0x004AEC34
			public virtual NO_RESPONSE OnSessionQueueEnd(SessionQueueEndNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SessionQueueEndNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionQueueEnd, null, options, request);
			}

			// Token: 0x0600D138 RID: 53560 RVA: 0x004B0A5C File Offset: 0x004AEC5C
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSessionQueueEndAsync(SessionQueueEndNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSessionQueueEndAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D139 RID: 53561 RVA: 0x004B0A84 File Offset: 0x004AEC84
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSessionQueueEndAsync(SessionQueueEndNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SessionQueueEndNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionQueueEnd, null, options, request);
			}

			// Token: 0x0600D13A RID: 53562 RVA: 0x004B0AAC File Offset: 0x004AECAC
			protected override SessionListener.SessionListenerClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new SessionListener.SessionListenerClient(configuration);
			}
		}
	}
}
