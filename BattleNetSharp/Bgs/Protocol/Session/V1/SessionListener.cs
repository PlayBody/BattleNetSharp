using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x02000547 RID: 1351
	public static class SessionListener
	{
		// Token: 0x060082CA RID: 33482 RVA: 0x001FC404 File Offset: 0x001FA604
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

		// Token: 0x060082CB RID: 33483 RVA: 0x001FC450 File Offset: 0x001FA650
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

		// Token: 0x1700294F RID: 10575
		// (get) Token: 0x060082CC RID: 33484 RVA: 0x001FC488 File Offset: 0x001FA688
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x060082CD RID: 33485 RVA: 0x001FC4AC File Offset: 0x001FA6AC
		public static ServerServiceDefinition BindService(SessionListener.SessionListenerBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<SessionCreatedNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionCreated, new UnaryServerMethod<SessionCreatedNotification, NO_RESPONSE>(serviceImpl.OnSessionCreated)).AddMethod<SessionDestroyedNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionDestroyed, new UnaryServerMethod<SessionDestroyedNotification, NO_RESPONSE>(serviceImpl.OnSessionDestroyed))
				.AddMethod<SessionUpdatedNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionUpdated, new UnaryServerMethod<SessionUpdatedNotification, NO_RESPONSE>(serviceImpl.OnSessionUpdated))
				.AddMethod<SessionGameTimeWarningNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionGameTimeWarning, new UnaryServerMethod<SessionGameTimeWarningNotification, NO_RESPONSE>(serviceImpl.OnSessionGameTimeWarning))
				.Build();
		}

		// Token: 0x060082CE RID: 33486 RVA: 0x001FC524 File Offset: 0x001FA724
		public static void BindService(ServiceBinderBase serviceBinder, SessionListener.SessionListenerBase serviceImpl)
		{
			serviceBinder.AddMethod<SessionCreatedNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionCreated, (serviceImpl == null) ? null : new UnaryServerMethod<SessionCreatedNotification, NO_RESPONSE>(serviceImpl.OnSessionCreated));
			serviceBinder.AddMethod<SessionDestroyedNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionDestroyed, (serviceImpl == null) ? null : new UnaryServerMethod<SessionDestroyedNotification, NO_RESPONSE>(serviceImpl.OnSessionDestroyed));
			serviceBinder.AddMethod<SessionUpdatedNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionUpdated, (serviceImpl == null) ? null : new UnaryServerMethod<SessionUpdatedNotification, NO_RESPONSE>(serviceImpl.OnSessionUpdated));
			serviceBinder.AddMethod<SessionGameTimeWarningNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionGameTimeWarning, (serviceImpl == null) ? null : new UnaryServerMethod<SessionGameTimeWarningNotification, NO_RESPONSE>(serviceImpl.OnSessionGameTimeWarning));
		}

		// Token: 0x04003B2B RID: 15147
		private static readonly string __ServiceName = "bgs.protocol.session.v1.SessionListener";

		// Token: 0x04003B2C RID: 15148
		private static readonly Marshaller<SessionCreatedNotification> __Marshaller_bgs_protocol_session_v1_SessionCreatedNotification = Marshallers.Create<SessionCreatedNotification>(new Action<SessionCreatedNotification, SerializationContext>(SessionListener.__Helper_SerializeMessage), (DeserializationContext context) => SessionListener.__Helper_DeserializeMessage<SessionCreatedNotification>(context, SessionCreatedNotification.Parser));

		// Token: 0x04003B2D RID: 15149
		private static readonly Marshaller<NO_RESPONSE> __Marshaller_bgs_protocol_NO_RESPONSE = Marshallers.Create<NO_RESPONSE>(new Action<NO_RESPONSE, SerializationContext>(SessionListener.__Helper_SerializeMessage), (DeserializationContext context) => SessionListener.__Helper_DeserializeMessage<NO_RESPONSE>(context, NO_RESPONSE.Parser));

		// Token: 0x04003B2E RID: 15150
		private static readonly Marshaller<SessionDestroyedNotification> __Marshaller_bgs_protocol_session_v1_SessionDestroyedNotification = Marshallers.Create<SessionDestroyedNotification>(new Action<SessionDestroyedNotification, SerializationContext>(SessionListener.__Helper_SerializeMessage), (DeserializationContext context) => SessionListener.__Helper_DeserializeMessage<SessionDestroyedNotification>(context, SessionDestroyedNotification.Parser));

		// Token: 0x04003B2F RID: 15151
		private static readonly Marshaller<SessionUpdatedNotification> __Marshaller_bgs_protocol_session_v1_SessionUpdatedNotification = Marshallers.Create<SessionUpdatedNotification>(new Action<SessionUpdatedNotification, SerializationContext>(SessionListener.__Helper_SerializeMessage), (DeserializationContext context) => SessionListener.__Helper_DeserializeMessage<SessionUpdatedNotification>(context, SessionUpdatedNotification.Parser));

		// Token: 0x04003B30 RID: 15152
		private static readonly Marshaller<SessionGameTimeWarningNotification> __Marshaller_bgs_protocol_session_v1_SessionGameTimeWarningNotification = Marshallers.Create<SessionGameTimeWarningNotification>(new Action<SessionGameTimeWarningNotification, SerializationContext>(SessionListener.__Helper_SerializeMessage), (DeserializationContext context) => SessionListener.__Helper_DeserializeMessage<SessionGameTimeWarningNotification>(context, SessionGameTimeWarningNotification.Parser));

		// Token: 0x04003B31 RID: 15153
		private static readonly Method<SessionCreatedNotification, NO_RESPONSE> __Method_OnSessionCreated = new Method<SessionCreatedNotification, NO_RESPONSE>(0, SessionListener.__ServiceName, "OnSessionCreated", SessionListener.__Marshaller_bgs_protocol_session_v1_SessionCreatedNotification, SessionListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04003B32 RID: 15154
		private static readonly Method<SessionDestroyedNotification, NO_RESPONSE> __Method_OnSessionDestroyed = new Method<SessionDestroyedNotification, NO_RESPONSE>(0, SessionListener.__ServiceName, "OnSessionDestroyed", SessionListener.__Marshaller_bgs_protocol_session_v1_SessionDestroyedNotification, SessionListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04003B33 RID: 15155
		private static readonly Method<SessionUpdatedNotification, NO_RESPONSE> __Method_OnSessionUpdated = new Method<SessionUpdatedNotification, NO_RESPONSE>(0, SessionListener.__ServiceName, "OnSessionUpdated", SessionListener.__Marshaller_bgs_protocol_session_v1_SessionUpdatedNotification, SessionListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04003B34 RID: 15156
		private static readonly Method<SessionGameTimeWarningNotification, NO_RESPONSE> __Method_OnSessionGameTimeWarning = new Method<SessionGameTimeWarningNotification, NO_RESPONSE>(0, SessionListener.__ServiceName, "OnSessionGameTimeWarning", SessionListener.__Marshaller_bgs_protocol_session_v1_SessionGameTimeWarningNotification, SessionListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x02001015 RID: 4117
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x04009764 RID: 38756
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02001016 RID: 4118
		[BindServiceMethod(typeof(SessionListener), "BindService")]
		public abstract class SessionListenerBase
		{
			// Token: 0x0600D092 RID: 53394 RVA: 0x004AFA6E File Offset: 0x004ADC6E
			public virtual Task<NO_RESPONSE> OnSessionCreated(SessionCreatedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D093 RID: 53395 RVA: 0x004AFA82 File Offset: 0x004ADC82
			public virtual Task<NO_RESPONSE> OnSessionDestroyed(SessionDestroyedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D094 RID: 53396 RVA: 0x004AFA96 File Offset: 0x004ADC96
			public virtual Task<NO_RESPONSE> OnSessionUpdated(SessionUpdatedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D095 RID: 53397 RVA: 0x004AFAAA File Offset: 0x004ADCAA
			public virtual Task<NO_RESPONSE> OnSessionGameTimeWarning(SessionGameTimeWarningNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x02001017 RID: 4119
		public class SessionListenerClient : ClientBase<SessionListener.SessionListenerClient>
		{
			// Token: 0x0600D097 RID: 53399 RVA: 0x004AFAC7 File Offset: 0x004ADCC7
			public SessionListenerClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D098 RID: 53400 RVA: 0x004AFAD2 File Offset: 0x004ADCD2
			public SessionListenerClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D099 RID: 53401 RVA: 0x004AFADD File Offset: 0x004ADCDD
			protected SessionListenerClient()
			{
			}

			// Token: 0x0600D09A RID: 53402 RVA: 0x004AFAE7 File Offset: 0x004ADCE7
			protected SessionListenerClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D09B RID: 53403 RVA: 0x004AFAF4 File Offset: 0x004ADCF4
			public virtual NO_RESPONSE OnSessionCreated(SessionCreatedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSessionCreated(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D09C RID: 53404 RVA: 0x004AFB1C File Offset: 0x004ADD1C
			public virtual NO_RESPONSE OnSessionCreated(SessionCreatedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SessionCreatedNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionCreated, null, options, request);
			}

			// Token: 0x0600D09D RID: 53405 RVA: 0x004AFB44 File Offset: 0x004ADD44
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSessionCreatedAsync(SessionCreatedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSessionCreatedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D09E RID: 53406 RVA: 0x004AFB6C File Offset: 0x004ADD6C
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSessionCreatedAsync(SessionCreatedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SessionCreatedNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionCreated, null, options, request);
			}

			// Token: 0x0600D09F RID: 53407 RVA: 0x004AFB94 File Offset: 0x004ADD94
			public virtual NO_RESPONSE OnSessionDestroyed(SessionDestroyedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSessionDestroyed(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D0A0 RID: 53408 RVA: 0x004AFBBC File Offset: 0x004ADDBC
			public virtual NO_RESPONSE OnSessionDestroyed(SessionDestroyedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SessionDestroyedNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionDestroyed, null, options, request);
			}

			// Token: 0x0600D0A1 RID: 53409 RVA: 0x004AFBE4 File Offset: 0x004ADDE4
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSessionDestroyedAsync(SessionDestroyedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSessionDestroyedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D0A2 RID: 53410 RVA: 0x004AFC0C File Offset: 0x004ADE0C
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSessionDestroyedAsync(SessionDestroyedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SessionDestroyedNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionDestroyed, null, options, request);
			}

			// Token: 0x0600D0A3 RID: 53411 RVA: 0x004AFC34 File Offset: 0x004ADE34
			public virtual NO_RESPONSE OnSessionUpdated(SessionUpdatedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSessionUpdated(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D0A4 RID: 53412 RVA: 0x004AFC5C File Offset: 0x004ADE5C
			public virtual NO_RESPONSE OnSessionUpdated(SessionUpdatedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SessionUpdatedNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionUpdated, null, options, request);
			}

			// Token: 0x0600D0A5 RID: 53413 RVA: 0x004AFC84 File Offset: 0x004ADE84
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSessionUpdatedAsync(SessionUpdatedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSessionUpdatedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D0A6 RID: 53414 RVA: 0x004AFCAC File Offset: 0x004ADEAC
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSessionUpdatedAsync(SessionUpdatedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SessionUpdatedNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionUpdated, null, options, request);
			}

			// Token: 0x0600D0A7 RID: 53415 RVA: 0x004AFCD4 File Offset: 0x004ADED4
			public virtual NO_RESPONSE OnSessionGameTimeWarning(SessionGameTimeWarningNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSessionGameTimeWarning(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D0A8 RID: 53416 RVA: 0x004AFCFC File Offset: 0x004ADEFC
			public virtual NO_RESPONSE OnSessionGameTimeWarning(SessionGameTimeWarningNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SessionGameTimeWarningNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionGameTimeWarning, null, options, request);
			}

			// Token: 0x0600D0A9 RID: 53417 RVA: 0x004AFD24 File Offset: 0x004ADF24
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSessionGameTimeWarningAsync(SessionGameTimeWarningNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSessionGameTimeWarningAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D0AA RID: 53418 RVA: 0x004AFD4C File Offset: 0x004ADF4C
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSessionGameTimeWarningAsync(SessionGameTimeWarningNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SessionGameTimeWarningNotification, NO_RESPONSE>(SessionListener.__Method_OnSessionGameTimeWarning, null, options, request);
			}

			// Token: 0x0600D0AB RID: 53419 RVA: 0x004AFD74 File Offset: 0x004ADF74
			protected override SessionListener.SessionListenerClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new SessionListener.SessionListenerClient(configuration);
			}
		}
	}
}
