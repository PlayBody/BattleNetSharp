using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Notification.V2.Client
{
	// Token: 0x020005D9 RID: 1497
	public static class NotificationService
	{
		// Token: 0x06008D09 RID: 36105 RVA: 0x00223900 File Offset: 0x00221B00
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

		// Token: 0x06008D0A RID: 36106 RVA: 0x0022394C File Offset: 0x00221B4C
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = NotificationService.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17002C36 RID: 11318
		// (get) Token: 0x06008D0B RID: 36107 RVA: 0x00223984 File Offset: 0x00221B84
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return NotificationServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x06008D0C RID: 36108 RVA: 0x002239A8 File Offset: 0x00221BA8
		public static ServerServiceDefinition BindService(NotificationService.NotificationServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<SendNotificationRequest, NoData>(NotificationService.__Method_SendNotification, new UnaryServerMethod<SendNotificationRequest, NoData>(serviceImpl.SendNotification)).Build();
		}

		// Token: 0x06008D0D RID: 36109 RVA: 0x002239DB File Offset: 0x00221BDB
		public static void BindService(ServiceBinderBase serviceBinder, NotificationService.NotificationServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<SendNotificationRequest, NoData>(NotificationService.__Method_SendNotification, (serviceImpl == null) ? null : new UnaryServerMethod<SendNotificationRequest, NoData>(serviceImpl.SendNotification));
		}

		// Token: 0x04003FC6 RID: 16326
		private static readonly string __ServiceName = "bgs.protocol.notification.v2.client.NotificationService";

		// Token: 0x04003FC7 RID: 16327
		private static readonly Marshaller<SendNotificationRequest> __Marshaller_bgs_protocol_notification_v2_client_SendNotificationRequest = Marshallers.Create<SendNotificationRequest>(new Action<SendNotificationRequest, SerializationContext>(NotificationService.__Helper_SerializeMessage), (DeserializationContext context) => NotificationService.__Helper_DeserializeMessage<SendNotificationRequest>(context, SendNotificationRequest.Parser));

		// Token: 0x04003FC8 RID: 16328
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(NotificationService.__Helper_SerializeMessage), (DeserializationContext context) => NotificationService.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x04003FC9 RID: 16329
		private static readonly Method<SendNotificationRequest, NoData> __Method_SendNotification = new Method<SendNotificationRequest, NoData>(0, NotificationService.__ServiceName, "SendNotification", NotificationService.__Marshaller_bgs_protocol_notification_v2_client_SendNotificationRequest, NotificationService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x020010BE RID: 4286
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x04009802 RID: 38914
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x020010BF RID: 4287
		[BindServiceMethod(typeof(NotificationService), "BindService")]
		public abstract class NotificationServiceBase
		{
			// Token: 0x0600D3A4 RID: 54180 RVA: 0x004B36F4 File Offset: 0x004B18F4
			public virtual Task<NoData> SendNotification(SendNotificationRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x020010C0 RID: 4288
		public class NotificationServiceClient : ClientBase<NotificationService.NotificationServiceClient>
		{
			// Token: 0x0600D3A6 RID: 54182 RVA: 0x004B3711 File Offset: 0x004B1911
			public NotificationServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D3A7 RID: 54183 RVA: 0x004B371C File Offset: 0x004B191C
			public NotificationServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D3A8 RID: 54184 RVA: 0x004B3727 File Offset: 0x004B1927
			protected NotificationServiceClient()
			{
			}

			// Token: 0x0600D3A9 RID: 54185 RVA: 0x004B3731 File Offset: 0x004B1931
			protected NotificationServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D3AA RID: 54186 RVA: 0x004B373C File Offset: 0x004B193C
			public virtual NoData SendNotification(SendNotificationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SendNotification(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D3AB RID: 54187 RVA: 0x004B3764 File Offset: 0x004B1964
			public virtual NoData SendNotification(SendNotificationRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SendNotificationRequest, NoData>(NotificationService.__Method_SendNotification, null, options, request);
			}

			// Token: 0x0600D3AC RID: 54188 RVA: 0x004B378C File Offset: 0x004B198C
			public virtual AsyncUnaryCall<NoData> SendNotificationAsync(SendNotificationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SendNotificationAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D3AD RID: 54189 RVA: 0x004B37B4 File Offset: 0x004B19B4
			public virtual AsyncUnaryCall<NoData> SendNotificationAsync(SendNotificationRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SendNotificationRequest, NoData>(NotificationService.__Method_SendNotification, null, options, request);
			}

			// Token: 0x0600D3AE RID: 54190 RVA: 0x004B37DC File Offset: 0x004B19DC
			protected override NotificationService.NotificationServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new NotificationService.NotificationServiceClient(configuration);
			}
		}
	}
}
