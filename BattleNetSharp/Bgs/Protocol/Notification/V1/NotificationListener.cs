using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Notification.V1
{
	// Token: 0x020005CE RID: 1486
	public static class NotificationListener
	{
		// Token: 0x06008C64 RID: 35940 RVA: 0x00220EB4 File Offset: 0x0021F0B4
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

		// Token: 0x06008C65 RID: 35941 RVA: 0x00220F00 File Offset: 0x0021F100
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = NotificationListener.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17002C07 RID: 11271
		// (get) Token: 0x06008C66 RID: 35942 RVA: 0x00220F38 File Offset: 0x0021F138
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return NotificationServiceReflection.Descriptor.Services[1];
			}
		}

		// Token: 0x06008C67 RID: 35943 RVA: 0x00220F5C File Offset: 0x0021F15C
		public static ServerServiceDefinition BindService(NotificationListener.NotificationListenerBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<Notification, NO_RESPONSE>(NotificationListener.__Method_OnNotificationReceived, new UnaryServerMethod<Notification, NO_RESPONSE>(serviceImpl.OnNotificationReceived)).Build();
		}

		// Token: 0x06008C68 RID: 35944 RVA: 0x00220F8F File Offset: 0x0021F18F
		public static void BindService(ServiceBinderBase serviceBinder, NotificationListener.NotificationListenerBase serviceImpl)
		{
			serviceBinder.AddMethod<Notification, NO_RESPONSE>(NotificationListener.__Method_OnNotificationReceived, (serviceImpl == null) ? null : new UnaryServerMethod<Notification, NO_RESPONSE>(serviceImpl.OnNotificationReceived));
		}

		// Token: 0x04003F80 RID: 16256
		private static readonly string __ServiceName = "bgs.protocol.notification.v1.NotificationListener";

		// Token: 0x04003F81 RID: 16257
		private static readonly Marshaller<Notification> __Marshaller_bgs_protocol_notification_v1_Notification = Marshallers.Create<Notification>(new Action<Notification, SerializationContext>(NotificationListener.__Helper_SerializeMessage), (DeserializationContext context) => NotificationListener.__Helper_DeserializeMessage<Notification>(context, Notification.Parser));

		// Token: 0x04003F82 RID: 16258
		private static readonly Marshaller<NO_RESPONSE> __Marshaller_bgs_protocol_NO_RESPONSE = Marshallers.Create<NO_RESPONSE>(new Action<NO_RESPONSE, SerializationContext>(NotificationListener.__Helper_SerializeMessage), (DeserializationContext context) => NotificationListener.__Helper_DeserializeMessage<NO_RESPONSE>(context, NO_RESPONSE.Parser));

		// Token: 0x04003F83 RID: 16259
		private static readonly Method<Notification, NO_RESPONSE> __Method_OnNotificationReceived = new Method<Notification, NO_RESPONSE>(0, NotificationListener.__ServiceName, "OnNotificationReceived", NotificationListener.__Marshaller_bgs_protocol_notification_v1_Notification, NotificationListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x020010B0 RID: 4272
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x040097F8 RID: 38904
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x020010B1 RID: 4273
		[BindServiceMethod(typeof(NotificationListener), "BindService")]
		public abstract class NotificationListenerBase
		{
			// Token: 0x0600D372 RID: 54130 RVA: 0x004B33A3 File Offset: 0x004B15A3
			public virtual Task<NO_RESPONSE> OnNotificationReceived(Notification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x020010B2 RID: 4274
		public class NotificationListenerClient : ClientBase<NotificationListener.NotificationListenerClient>
		{
			// Token: 0x0600D374 RID: 54132 RVA: 0x004B33C0 File Offset: 0x004B15C0
			public NotificationListenerClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D375 RID: 54133 RVA: 0x004B33CB File Offset: 0x004B15CB
			public NotificationListenerClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D376 RID: 54134 RVA: 0x004B33D6 File Offset: 0x004B15D6
			protected NotificationListenerClient()
			{
			}

			// Token: 0x0600D377 RID: 54135 RVA: 0x004B33E0 File Offset: 0x004B15E0
			protected NotificationListenerClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D378 RID: 54136 RVA: 0x004B33EC File Offset: 0x004B15EC
			public virtual NO_RESPONSE OnNotificationReceived(Notification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnNotificationReceived(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D379 RID: 54137 RVA: 0x004B3414 File Offset: 0x004B1614
			public virtual NO_RESPONSE OnNotificationReceived(Notification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<Notification, NO_RESPONSE>(NotificationListener.__Method_OnNotificationReceived, null, options, request);
			}

			// Token: 0x0600D37A RID: 54138 RVA: 0x004B343C File Offset: 0x004B163C
			public virtual AsyncUnaryCall<NO_RESPONSE> OnNotificationReceivedAsync(Notification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnNotificationReceivedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D37B RID: 54139 RVA: 0x004B3464 File Offset: 0x004B1664
			public virtual AsyncUnaryCall<NO_RESPONSE> OnNotificationReceivedAsync(Notification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<Notification, NO_RESPONSE>(NotificationListener.__Method_OnNotificationReceived, null, options, request);
			}

			// Token: 0x0600D37C RID: 54140 RVA: 0x004B348C File Offset: 0x004B168C
			protected override NotificationListener.NotificationListenerClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new NotificationListener.NotificationListenerClient(configuration);
			}
		}
	}
}
