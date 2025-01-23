using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Sns.V1
{
	// Token: 0x020003D3 RID: 979
	public static class SocialNetworkListener
	{
		// Token: 0x060061DB RID: 25051 RVA: 0x0017AA94 File Offset: 0x00178C94
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

		// Token: 0x060061DC RID: 25052 RVA: 0x0017AAE0 File Offset: 0x00178CE0
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = SocialNetworkListener.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17001F87 RID: 8071
		// (get) Token: 0x060061DD RID: 25053 RVA: 0x0017AB18 File Offset: 0x00178D18
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return SocialNetworkServiceReflection.Descriptor.Services[1];
			}
		}

		// Token: 0x060061DE RID: 25054 RVA: 0x0017AB3C File Offset: 0x00178D3C
		public static ServerServiceDefinition BindService(SocialNetworkListener.SocialNetworkListenerBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<FacebookBnetFriendListNotification, FacebookBnetFriendListNotificationResponse>(SocialNetworkListener.__Method_OnFacebookBnetFriendListReceived, new UnaryServerMethod<FacebookBnetFriendListNotification, FacebookBnetFriendListNotificationResponse>(serviceImpl.OnFacebookBnetFriendListReceived)).Build();
		}

		// Token: 0x060061DF RID: 25055 RVA: 0x0017AB6F File Offset: 0x00178D6F
		public static void BindService(ServiceBinderBase serviceBinder, SocialNetworkListener.SocialNetworkListenerBase serviceImpl)
		{
			serviceBinder.AddMethod<FacebookBnetFriendListNotification, FacebookBnetFriendListNotificationResponse>(SocialNetworkListener.__Method_OnFacebookBnetFriendListReceived, (serviceImpl == null) ? null : new UnaryServerMethod<FacebookBnetFriendListNotification, FacebookBnetFriendListNotificationResponse>(serviceImpl.OnFacebookBnetFriendListReceived));
		}

		// Token: 0x04002CAC RID: 11436
		private static readonly string __ServiceName = "bgs.protocol.sns.v1.SocialNetworkListener";

		// Token: 0x04002CAD RID: 11437
		private static readonly Marshaller<FacebookBnetFriendListNotification> __Marshaller_bgs_protocol_sns_v1_FacebookBnetFriendListNotification = Marshallers.Create<FacebookBnetFriendListNotification>(new Action<FacebookBnetFriendListNotification, SerializationContext>(SocialNetworkListener.__Helper_SerializeMessage), (DeserializationContext context) => SocialNetworkListener.__Helper_DeserializeMessage<FacebookBnetFriendListNotification>(context, FacebookBnetFriendListNotification.Parser));

		// Token: 0x04002CAE RID: 11438
		private static readonly Marshaller<FacebookBnetFriendListNotificationResponse> __Marshaller_bgs_protocol_sns_v1_FacebookBnetFriendListNotificationResponse = Marshallers.Create<FacebookBnetFriendListNotificationResponse>(new Action<FacebookBnetFriendListNotificationResponse, SerializationContext>(SocialNetworkListener.__Helper_SerializeMessage), (DeserializationContext context) => SocialNetworkListener.__Helper_DeserializeMessage<FacebookBnetFriendListNotificationResponse>(context, FacebookBnetFriendListNotificationResponse.Parser));

		// Token: 0x04002CAF RID: 11439
		private static readonly Method<FacebookBnetFriendListNotification, FacebookBnetFriendListNotificationResponse> __Method_OnFacebookBnetFriendListReceived = new Method<FacebookBnetFriendListNotification, FacebookBnetFriendListNotificationResponse>(0, SocialNetworkListener.__ServiceName, "OnFacebookBnetFriendListReceived", SocialNetworkListener.__Marshaller_bgs_protocol_sns_v1_FacebookBnetFriendListNotification, SocialNetworkListener.__Marshaller_bgs_protocol_sns_v1_FacebookBnetFriendListNotificationResponse);

		// Token: 0x02000EA7 RID: 3751
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x0400960E RID: 38414
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02000EA8 RID: 3752
		[BindServiceMethod(typeof(SocialNetworkListener), "BindService")]
		public abstract class SocialNetworkListenerBase
		{
			// Token: 0x0600CAEB RID: 51947 RVA: 0x004AA2CE File Offset: 0x004A84CE
			public virtual Task<FacebookBnetFriendListNotificationResponse> OnFacebookBnetFriendListReceived(FacebookBnetFriendListNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x02000EA9 RID: 3753
		public class SocialNetworkListenerClient : ClientBase<SocialNetworkListener.SocialNetworkListenerClient>
		{
			// Token: 0x0600CAED RID: 51949 RVA: 0x004AA2EB File Offset: 0x004A84EB
			public SocialNetworkListenerClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600CAEE RID: 51950 RVA: 0x004AA2F6 File Offset: 0x004A84F6
			public SocialNetworkListenerClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600CAEF RID: 51951 RVA: 0x004AA301 File Offset: 0x004A8501
			protected SocialNetworkListenerClient()
			{
			}

			// Token: 0x0600CAF0 RID: 51952 RVA: 0x004AA30B File Offset: 0x004A850B
			protected SocialNetworkListenerClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600CAF1 RID: 51953 RVA: 0x004AA318 File Offset: 0x004A8518
			public virtual FacebookBnetFriendListNotificationResponse OnFacebookBnetFriendListReceived(FacebookBnetFriendListNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnFacebookBnetFriendListReceived(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CAF2 RID: 51954 RVA: 0x004AA340 File Offset: 0x004A8540
			public virtual FacebookBnetFriendListNotificationResponse OnFacebookBnetFriendListReceived(FacebookBnetFriendListNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<FacebookBnetFriendListNotification, FacebookBnetFriendListNotificationResponse>(SocialNetworkListener.__Method_OnFacebookBnetFriendListReceived, null, options, request);
			}

			// Token: 0x0600CAF3 RID: 51955 RVA: 0x004AA368 File Offset: 0x004A8568
			public virtual AsyncUnaryCall<FacebookBnetFriendListNotificationResponse> OnFacebookBnetFriendListReceivedAsync(FacebookBnetFriendListNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnFacebookBnetFriendListReceivedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CAF4 RID: 51956 RVA: 0x004AA390 File Offset: 0x004A8590
			public virtual AsyncUnaryCall<FacebookBnetFriendListNotificationResponse> OnFacebookBnetFriendListReceivedAsync(FacebookBnetFriendListNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<FacebookBnetFriendListNotification, FacebookBnetFriendListNotificationResponse>(SocialNetworkListener.__Method_OnFacebookBnetFriendListReceived, null, options, request);
			}

			// Token: 0x0600CAF5 RID: 51957 RVA: 0x004AA3B8 File Offset: 0x004A85B8
			protected override SocialNetworkListener.SocialNetworkListenerClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new SocialNetworkListener.SocialNetworkListenerClient(configuration);
			}
		}
	}
}
