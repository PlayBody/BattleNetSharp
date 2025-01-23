using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Notification.V2.Client
{
	// Token: 0x020005D6 RID: 1494
	public static class NotificationListener
	{
		// Token: 0x06008CEE RID: 36078 RVA: 0x00223320 File Offset: 0x00221520
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

		// Token: 0x06008CEF RID: 36079 RVA: 0x0022336C File Offset: 0x0022156C
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

		// Token: 0x17002C30 RID: 11312
		// (get) Token: 0x06008CF0 RID: 36080 RVA: 0x002233A4 File Offset: 0x002215A4
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return NotificationListenerReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x06008CF1 RID: 36081 RVA: 0x002233C8 File Offset: 0x002215C8
		public static ServerServiceDefinition BindService(NotificationListener.NotificationListenerBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<NotificationReceivedNotification, NO_RESPONSE>(NotificationListener.__Method_OnNotificationReceived, new UnaryServerMethod<NotificationReceivedNotification, NO_RESPONSE>(serviceImpl.OnNotificationReceived)).Build();
		}

		// Token: 0x06008CF2 RID: 36082 RVA: 0x002233FB File Offset: 0x002215FB
		public static void BindService(ServiceBinderBase serviceBinder, NotificationListener.NotificationListenerBase serviceImpl)
		{
			serviceBinder.AddMethod<NotificationReceivedNotification, NO_RESPONSE>(NotificationListener.__Method_OnNotificationReceived, (serviceImpl == null) ? null : new UnaryServerMethod<NotificationReceivedNotification, NO_RESPONSE>(serviceImpl.OnNotificationReceived));
		}

		// Token: 0x04003FBD RID: 16317
		private static readonly string __ServiceName = "bgs.protocol.notification.v2.client.NotificationListener";

		// Token: 0x04003FBE RID: 16318
		private static readonly Marshaller<NotificationReceivedNotification> __Marshaller_bgs_protocol_notification_v2_client_NotificationReceivedNotification = Marshallers.Create<NotificationReceivedNotification>(new Action<NotificationReceivedNotification, SerializationContext>(NotificationListener.__Helper_SerializeMessage), (DeserializationContext context) => NotificationListener.__Helper_DeserializeMessage<NotificationReceivedNotification>(context, NotificationReceivedNotification.Parser));

		// Token: 0x04003FBF RID: 16319
		private static readonly Marshaller<NO_RESPONSE> __Marshaller_bgs_protocol_NO_RESPONSE = Marshallers.Create<NO_RESPONSE>(new Action<NO_RESPONSE, SerializationContext>(NotificationListener.__Helper_SerializeMessage), (DeserializationContext context) => NotificationListener.__Helper_DeserializeMessage<NO_RESPONSE>(context, NO_RESPONSE.Parser));

		// Token: 0x04003FC0 RID: 16320
		private static readonly Method<NotificationReceivedNotification, NO_RESPONSE> __Method_OnNotificationReceived = new Method<NotificationReceivedNotification, NO_RESPONSE>(0, NotificationListener.__ServiceName, "OnNotificationReceived", NotificationListener.__Marshaller_bgs_protocol_notification_v2_client_NotificationReceivedNotification, NotificationListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x020010B9 RID: 4281
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x040097FF RID: 38911
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x020010BA RID: 4282
		[BindServiceMethod(typeof(NotificationListener), "BindService")]
		public abstract class NotificationListenerBase
		{
			// Token: 0x0600D391 RID: 54161 RVA: 0x004B3584 File Offset: 0x004B1784
			public virtual Task<NO_RESPONSE> OnNotificationReceived(NotificationReceivedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x020010BB RID: 4283
		public class NotificationListenerClient : ClientBase<NotificationListener.NotificationListenerClient>
		{
			// Token: 0x0600D393 RID: 54163 RVA: 0x004B35A1 File Offset: 0x004B17A1
			public NotificationListenerClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D394 RID: 54164 RVA: 0x004B35AC File Offset: 0x004B17AC
			public NotificationListenerClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D395 RID: 54165 RVA: 0x004B35B7 File Offset: 0x004B17B7
			protected NotificationListenerClient()
			{
			}

			// Token: 0x0600D396 RID: 54166 RVA: 0x004B35C1 File Offset: 0x004B17C1
			protected NotificationListenerClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D397 RID: 54167 RVA: 0x004B35CC File Offset: 0x004B17CC
			public virtual NO_RESPONSE OnNotificationReceived(NotificationReceivedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnNotificationReceived(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D398 RID: 54168 RVA: 0x004B35F4 File Offset: 0x004B17F4
			public virtual NO_RESPONSE OnNotificationReceived(NotificationReceivedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<NotificationReceivedNotification, NO_RESPONSE>(NotificationListener.__Method_OnNotificationReceived, null, options, request);
			}

			// Token: 0x0600D399 RID: 54169 RVA: 0x004B361C File Offset: 0x004B181C
			public virtual AsyncUnaryCall<NO_RESPONSE> OnNotificationReceivedAsync(NotificationReceivedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnNotificationReceivedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D39A RID: 54170 RVA: 0x004B3644 File Offset: 0x004B1844
			public virtual AsyncUnaryCall<NO_RESPONSE> OnNotificationReceivedAsync(NotificationReceivedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<NotificationReceivedNotification, NO_RESPONSE>(NotificationListener.__Method_OnNotificationReceived, null, options, request);
			}

			// Token: 0x0600D39B RID: 54171 RVA: 0x004B366C File Offset: 0x004B186C
			protected override NotificationListener.NotificationListenerClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new NotificationListener.NotificationListenerClient(configuration);
			}
		}
	}
}
