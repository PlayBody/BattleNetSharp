using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Presence.V2
{
	// Token: 0x020005B6 RID: 1462
	public static class PresenceListener
	{
		// Token: 0x06008AD9 RID: 35545 RVA: 0x0021B3A4 File Offset: 0x002195A4
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

		// Token: 0x06008ADA RID: 35546 RVA: 0x0021B3F0 File Offset: 0x002195F0
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = PresenceListener.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17002B9C RID: 11164
		// (get) Token: 0x06008ADB RID: 35547 RVA: 0x0021B428 File Offset: 0x00219628
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return PresenceListenerReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x06008ADC RID: 35548 RVA: 0x0021B44C File Offset: 0x0021964C
		public static ServerServiceDefinition BindService(PresenceListener.PresenceListenerBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<PresenceStateUpdatedNotification, NO_RESPONSE>(PresenceListener.__Method_OnPresenceStateUpdated, new UnaryServerMethod<PresenceStateUpdatedNotification, NO_RESPONSE>(serviceImpl.OnPresenceStateUpdated)).AddMethod<SubscribeFailureNotification, NO_RESPONSE>(PresenceListener.__Method_OnSubscribeFailure, new UnaryServerMethod<SubscribeFailureNotification, NO_RESPONSE>(serviceImpl.OnSubscribeFailure))
				.Build();
		}

		// Token: 0x06008ADD RID: 35549 RVA: 0x0021B498 File Offset: 0x00219698
		public static void BindService(ServiceBinderBase serviceBinder, PresenceListener.PresenceListenerBase serviceImpl)
		{
			serviceBinder.AddMethod<PresenceStateUpdatedNotification, NO_RESPONSE>(PresenceListener.__Method_OnPresenceStateUpdated, (serviceImpl == null) ? null : new UnaryServerMethod<PresenceStateUpdatedNotification, NO_RESPONSE>(serviceImpl.OnPresenceStateUpdated));
			serviceBinder.AddMethod<SubscribeFailureNotification, NO_RESPONSE>(PresenceListener.__Method_OnSubscribeFailure, (serviceImpl == null) ? null : new UnaryServerMethod<SubscribeFailureNotification, NO_RESPONSE>(serviceImpl.OnSubscribeFailure));
		}

		// Token: 0x04003ED2 RID: 16082
		private static readonly string __ServiceName = "bgs.protocol.presence.v2.PresenceListener";

		// Token: 0x04003ED3 RID: 16083
		private static readonly Marshaller<PresenceStateUpdatedNotification> __Marshaller_bgs_protocol_presence_v2_PresenceStateUpdatedNotification = Marshallers.Create<PresenceStateUpdatedNotification>(new Action<PresenceStateUpdatedNotification, SerializationContext>(PresenceListener.__Helper_SerializeMessage), (DeserializationContext context) => PresenceListener.__Helper_DeserializeMessage<PresenceStateUpdatedNotification>(context, PresenceStateUpdatedNotification.Parser));

		// Token: 0x04003ED4 RID: 16084
		private static readonly Marshaller<NO_RESPONSE> __Marshaller_bgs_protocol_NO_RESPONSE = Marshallers.Create<NO_RESPONSE>(new Action<NO_RESPONSE, SerializationContext>(PresenceListener.__Helper_SerializeMessage), (DeserializationContext context) => PresenceListener.__Helper_DeserializeMessage<NO_RESPONSE>(context, NO_RESPONSE.Parser));

		// Token: 0x04003ED5 RID: 16085
		private static readonly Marshaller<SubscribeFailureNotification> __Marshaller_bgs_protocol_presence_v2_SubscribeFailureNotification = Marshallers.Create<SubscribeFailureNotification>(new Action<SubscribeFailureNotification, SerializationContext>(PresenceListener.__Helper_SerializeMessage), (DeserializationContext context) => PresenceListener.__Helper_DeserializeMessage<SubscribeFailureNotification>(context, SubscribeFailureNotification.Parser));

		// Token: 0x04003ED6 RID: 16086
		private static readonly Method<PresenceStateUpdatedNotification, NO_RESPONSE> __Method_OnPresenceStateUpdated = new Method<PresenceStateUpdatedNotification, NO_RESPONSE>(0, PresenceListener.__ServiceName, "OnPresenceStateUpdated", PresenceListener.__Marshaller_bgs_protocol_presence_v2_PresenceStateUpdatedNotification, PresenceListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04003ED7 RID: 16087
		private static readonly Method<SubscribeFailureNotification, NO_RESPONSE> __Method_OnSubscribeFailure = new Method<SubscribeFailureNotification, NO_RESPONSE>(0, PresenceListener.__ServiceName, "OnSubscribeFailure", PresenceListener.__Marshaller_bgs_protocol_presence_v2_SubscribeFailureNotification, PresenceListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x02001094 RID: 4244
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x040097E2 RID: 38882
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02001095 RID: 4245
		[BindServiceMethod(typeof(PresenceListener), "BindService")]
		public abstract class PresenceListenerBase
		{
			// Token: 0x0600D2E2 RID: 53986 RVA: 0x004B27DA File Offset: 0x004B09DA
			public virtual Task<NO_RESPONSE> OnPresenceStateUpdated(PresenceStateUpdatedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D2E3 RID: 53987 RVA: 0x004B27EE File Offset: 0x004B09EE
			public virtual Task<NO_RESPONSE> OnSubscribeFailure(SubscribeFailureNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x02001096 RID: 4246
		public class PresenceListenerClient : ClientBase<PresenceListener.PresenceListenerClient>
		{
			// Token: 0x0600D2E5 RID: 53989 RVA: 0x004B280B File Offset: 0x004B0A0B
			public PresenceListenerClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D2E6 RID: 53990 RVA: 0x004B2816 File Offset: 0x004B0A16
			public PresenceListenerClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D2E7 RID: 53991 RVA: 0x004B2821 File Offset: 0x004B0A21
			protected PresenceListenerClient()
			{
			}

			// Token: 0x0600D2E8 RID: 53992 RVA: 0x004B282B File Offset: 0x004B0A2B
			protected PresenceListenerClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D2E9 RID: 53993 RVA: 0x004B2838 File Offset: 0x004B0A38
			public virtual NO_RESPONSE OnPresenceStateUpdated(PresenceStateUpdatedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnPresenceStateUpdated(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D2EA RID: 53994 RVA: 0x004B2860 File Offset: 0x004B0A60
			public virtual NO_RESPONSE OnPresenceStateUpdated(PresenceStateUpdatedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<PresenceStateUpdatedNotification, NO_RESPONSE>(PresenceListener.__Method_OnPresenceStateUpdated, null, options, request);
			}

			// Token: 0x0600D2EB RID: 53995 RVA: 0x004B2888 File Offset: 0x004B0A88
			public virtual AsyncUnaryCall<NO_RESPONSE> OnPresenceStateUpdatedAsync(PresenceStateUpdatedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnPresenceStateUpdatedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D2EC RID: 53996 RVA: 0x004B28B0 File Offset: 0x004B0AB0
			public virtual AsyncUnaryCall<NO_RESPONSE> OnPresenceStateUpdatedAsync(PresenceStateUpdatedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<PresenceStateUpdatedNotification, NO_RESPONSE>(PresenceListener.__Method_OnPresenceStateUpdated, null, options, request);
			}

			// Token: 0x0600D2ED RID: 53997 RVA: 0x004B28D8 File Offset: 0x004B0AD8
			public virtual NO_RESPONSE OnSubscribeFailure(SubscribeFailureNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSubscribeFailure(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D2EE RID: 53998 RVA: 0x004B2900 File Offset: 0x004B0B00
			public virtual NO_RESPONSE OnSubscribeFailure(SubscribeFailureNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SubscribeFailureNotification, NO_RESPONSE>(PresenceListener.__Method_OnSubscribeFailure, null, options, request);
			}

			// Token: 0x0600D2EF RID: 53999 RVA: 0x004B2928 File Offset: 0x004B0B28
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSubscribeFailureAsync(SubscribeFailureNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSubscribeFailureAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D2F0 RID: 54000 RVA: 0x004B2950 File Offset: 0x004B0B50
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSubscribeFailureAsync(SubscribeFailureNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SubscribeFailureNotification, NO_RESPONSE>(PresenceListener.__Method_OnSubscribeFailure, null, options, request);
			}

			// Token: 0x0600D2F1 RID: 54001 RVA: 0x004B2978 File Offset: 0x004B0B78
			protected override PresenceListener.PresenceListenerClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new PresenceListener.PresenceListenerClient(configuration);
			}
		}
	}
}
