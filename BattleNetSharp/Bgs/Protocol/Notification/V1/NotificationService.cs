using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Notification.V1
{
	// Token: 0x020005CD RID: 1485
	public static class NotificationService
	{
		// Token: 0x06008C5E RID: 35934 RVA: 0x00220BB4 File Offset: 0x0021EDB4
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

		// Token: 0x06008C5F RID: 35935 RVA: 0x00220C00 File Offset: 0x0021EE00
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

		// Token: 0x17002C06 RID: 11270
		// (get) Token: 0x06008C60 RID: 35936 RVA: 0x00220C38 File Offset: 0x0021EE38
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return NotificationServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x06008C61 RID: 35937 RVA: 0x00220C5C File Offset: 0x0021EE5C
		public static ServerServiceDefinition BindService(NotificationService.NotificationServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<Notification, NoData>(NotificationService.__Method_SendNotification, new UnaryServerMethod<Notification, NoData>(serviceImpl.SendNotification)).AddMethod<SubscribeRequest, NoData>(NotificationService.__Method_Subscribe, new UnaryServerMethod<SubscribeRequest, NoData>(serviceImpl.Subscribe))
				.AddMethod<UnsubscribeRequest, NoData>(NotificationService.__Method_Unsubscribe, new UnaryServerMethod<UnsubscribeRequest, NoData>(serviceImpl.Unsubscribe))
				.AddMethod<PublishRequest, NoData>(NotificationService.__Method_Publish, new UnaryServerMethod<PublishRequest, NoData>(serviceImpl.Publish))
				.Build();
		}

		// Token: 0x06008C62 RID: 35938 RVA: 0x00220CD4 File Offset: 0x0021EED4
		public static void BindService(ServiceBinderBase serviceBinder, NotificationService.NotificationServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<Notification, NoData>(NotificationService.__Method_SendNotification, (serviceImpl == null) ? null : new UnaryServerMethod<Notification, NoData>(serviceImpl.SendNotification));
			serviceBinder.AddMethod<SubscribeRequest, NoData>(NotificationService.__Method_Subscribe, (serviceImpl == null) ? null : new UnaryServerMethod<SubscribeRequest, NoData>(serviceImpl.Subscribe));
			serviceBinder.AddMethod<UnsubscribeRequest, NoData>(NotificationService.__Method_Unsubscribe, (serviceImpl == null) ? null : new UnaryServerMethod<UnsubscribeRequest, NoData>(serviceImpl.Unsubscribe));
			serviceBinder.AddMethod<PublishRequest, NoData>(NotificationService.__Method_Publish, (serviceImpl == null) ? null : new UnaryServerMethod<PublishRequest, NoData>(serviceImpl.Publish));
		}

		// Token: 0x04003F76 RID: 16246
		private static readonly string __ServiceName = "bgs.protocol.notification.v1.NotificationService";

		// Token: 0x04003F77 RID: 16247
		private static readonly Marshaller<Notification> __Marshaller_bgs_protocol_notification_v1_Notification = Marshallers.Create<Notification>(new Action<Notification, SerializationContext>(NotificationService.__Helper_SerializeMessage), (DeserializationContext context) => NotificationService.__Helper_DeserializeMessage<Notification>(context, Notification.Parser));

		// Token: 0x04003F78 RID: 16248
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(NotificationService.__Helper_SerializeMessage), (DeserializationContext context) => NotificationService.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x04003F79 RID: 16249
		private static readonly Marshaller<SubscribeRequest> __Marshaller_bgs_protocol_notification_v1_SubscribeRequest = Marshallers.Create<SubscribeRequest>(new Action<SubscribeRequest, SerializationContext>(NotificationService.__Helper_SerializeMessage), (DeserializationContext context) => NotificationService.__Helper_DeserializeMessage<SubscribeRequest>(context, SubscribeRequest.Parser));

		// Token: 0x04003F7A RID: 16250
		private static readonly Marshaller<UnsubscribeRequest> __Marshaller_bgs_protocol_notification_v1_UnsubscribeRequest = Marshallers.Create<UnsubscribeRequest>(new Action<UnsubscribeRequest, SerializationContext>(NotificationService.__Helper_SerializeMessage), (DeserializationContext context) => NotificationService.__Helper_DeserializeMessage<UnsubscribeRequest>(context, UnsubscribeRequest.Parser));

		// Token: 0x04003F7B RID: 16251
		private static readonly Marshaller<PublishRequest> __Marshaller_bgs_protocol_notification_v1_PublishRequest = Marshallers.Create<PublishRequest>(new Action<PublishRequest, SerializationContext>(NotificationService.__Helper_SerializeMessage), (DeserializationContext context) => NotificationService.__Helper_DeserializeMessage<PublishRequest>(context, PublishRequest.Parser));

		// Token: 0x04003F7C RID: 16252
		private static readonly Method<Notification, NoData> __Method_SendNotification = new Method<Notification, NoData>(0, NotificationService.__ServiceName, "SendNotification", NotificationService.__Marshaller_bgs_protocol_notification_v1_Notification, NotificationService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04003F7D RID: 16253
		private static readonly Method<SubscribeRequest, NoData> __Method_Subscribe = new Method<SubscribeRequest, NoData>(0, NotificationService.__ServiceName, "Subscribe", NotificationService.__Marshaller_bgs_protocol_notification_v1_SubscribeRequest, NotificationService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04003F7E RID: 16254
		private static readonly Method<UnsubscribeRequest, NoData> __Method_Unsubscribe = new Method<UnsubscribeRequest, NoData>(0, NotificationService.__ServiceName, "Unsubscribe", NotificationService.__Marshaller_bgs_protocol_notification_v1_UnsubscribeRequest, NotificationService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04003F7F RID: 16255
		private static readonly Method<PublishRequest, NoData> __Method_Publish = new Method<PublishRequest, NoData>(0, NotificationService.__ServiceName, "Publish", NotificationService.__Marshaller_bgs_protocol_notification_v1_PublishRequest, NotificationService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x020010AC RID: 4268
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x040097F6 RID: 38902
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x020010AD RID: 4269
		[BindServiceMethod(typeof(NotificationService), "BindService")]
		public abstract class NotificationServiceBase
		{
			// Token: 0x0600D350 RID: 54096 RVA: 0x004B300C File Offset: 0x004B120C
			public virtual Task<NoData> SendNotification(Notification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D351 RID: 54097 RVA: 0x004B3020 File Offset: 0x004B1220
			public virtual Task<NoData> Subscribe(SubscribeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D352 RID: 54098 RVA: 0x004B3034 File Offset: 0x004B1234
			public virtual Task<NoData> Unsubscribe(UnsubscribeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D353 RID: 54099 RVA: 0x004B3048 File Offset: 0x004B1248
			public virtual Task<NoData> Publish(PublishRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x020010AE RID: 4270
		public class NotificationServiceClient : ClientBase<NotificationService.NotificationServiceClient>
		{
			// Token: 0x0600D355 RID: 54101 RVA: 0x004B3065 File Offset: 0x004B1265
			public NotificationServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D356 RID: 54102 RVA: 0x004B3070 File Offset: 0x004B1270
			public NotificationServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D357 RID: 54103 RVA: 0x004B307B File Offset: 0x004B127B
			protected NotificationServiceClient()
			{
			}

			// Token: 0x0600D358 RID: 54104 RVA: 0x004B3085 File Offset: 0x004B1285
			protected NotificationServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D359 RID: 54105 RVA: 0x004B3090 File Offset: 0x004B1290
			public virtual NoData SendNotification(Notification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SendNotification(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D35A RID: 54106 RVA: 0x004B30B8 File Offset: 0x004B12B8
			public virtual NoData SendNotification(Notification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<Notification, NoData>(NotificationService.__Method_SendNotification, null, options, request);
			}

			// Token: 0x0600D35B RID: 54107 RVA: 0x004B30E0 File Offset: 0x004B12E0
			public virtual AsyncUnaryCall<NoData> SendNotificationAsync(Notification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SendNotificationAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D35C RID: 54108 RVA: 0x004B3108 File Offset: 0x004B1308
			public virtual AsyncUnaryCall<NoData> SendNotificationAsync(Notification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<Notification, NoData>(NotificationService.__Method_SendNotification, null, options, request);
			}

			// Token: 0x0600D35D RID: 54109 RVA: 0x004B3130 File Offset: 0x004B1330
			public virtual NoData Subscribe(SubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Subscribe(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D35E RID: 54110 RVA: 0x004B3158 File Offset: 0x004B1358
			public virtual NoData Subscribe(SubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SubscribeRequest, NoData>(NotificationService.__Method_Subscribe, null, options, request);
			}

			// Token: 0x0600D35F RID: 54111 RVA: 0x004B3180 File Offset: 0x004B1380
			public virtual AsyncUnaryCall<NoData> SubscribeAsync(SubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SubscribeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D360 RID: 54112 RVA: 0x004B31A8 File Offset: 0x004B13A8
			public virtual AsyncUnaryCall<NoData> SubscribeAsync(SubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SubscribeRequest, NoData>(NotificationService.__Method_Subscribe, null, options, request);
			}

			// Token: 0x0600D361 RID: 54113 RVA: 0x004B31D0 File Offset: 0x004B13D0
			public virtual NoData Unsubscribe(UnsubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Unsubscribe(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D362 RID: 54114 RVA: 0x004B31F8 File Offset: 0x004B13F8
			public virtual NoData Unsubscribe(UnsubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<UnsubscribeRequest, NoData>(NotificationService.__Method_Unsubscribe, null, options, request);
			}

			// Token: 0x0600D363 RID: 54115 RVA: 0x004B3220 File Offset: 0x004B1420
			public virtual AsyncUnaryCall<NoData> UnsubscribeAsync(UnsubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UnsubscribeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D364 RID: 54116 RVA: 0x004B3248 File Offset: 0x004B1448
			public virtual AsyncUnaryCall<NoData> UnsubscribeAsync(UnsubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<UnsubscribeRequest, NoData>(NotificationService.__Method_Unsubscribe, null, options, request);
			}

			// Token: 0x0600D365 RID: 54117 RVA: 0x004B3270 File Offset: 0x004B1470
			public virtual NoData Publish(PublishRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Publish(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D366 RID: 54118 RVA: 0x004B3298 File Offset: 0x004B1498
			public virtual NoData Publish(PublishRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<PublishRequest, NoData>(NotificationService.__Method_Publish, null, options, request);
			}

			// Token: 0x0600D367 RID: 54119 RVA: 0x004B32C0 File Offset: 0x004B14C0
			public virtual AsyncUnaryCall<NoData> PublishAsync(PublishRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.PublishAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D368 RID: 54120 RVA: 0x004B32E8 File Offset: 0x004B14E8
			public virtual AsyncUnaryCall<NoData> PublishAsync(PublishRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<PublishRequest, NoData>(NotificationService.__Method_Publish, null, options, request);
			}

			// Token: 0x0600D369 RID: 54121 RVA: 0x004B3310 File Offset: 0x004B1510
			protected override NotificationService.NotificationServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new NotificationService.NotificationServiceClient(configuration);
			}
		}
	}
}
