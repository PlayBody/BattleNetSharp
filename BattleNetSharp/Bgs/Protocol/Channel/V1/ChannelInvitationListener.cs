using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006C5 RID: 1733
	public static class ChannelInvitationListener
	{
		// Token: 0x0600A016 RID: 40982 RVA: 0x0026EE60 File Offset: 0x0026D060
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

		// Token: 0x0600A017 RID: 40983 RVA: 0x0026EEAC File Offset: 0x0026D0AC
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = ChannelInvitationListener.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x170031A2 RID: 12706
		// (get) Token: 0x0600A018 RID: 40984 RVA: 0x0026EEE4 File Offset: 0x0026D0E4
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return ChannelInvitationServiceReflection.Descriptor.Services[1];
			}
		}

		// Token: 0x0600A019 RID: 40985 RVA: 0x0026EF08 File Offset: 0x0026D108
		public static ServerServiceDefinition BindService(ChannelInvitationListener.ChannelInvitationListenerBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<InvitationAddedNotification, NO_RESPONSE>(ChannelInvitationListener.__Method_OnReceivedInvitationAdded, new UnaryServerMethod<InvitationAddedNotification, NO_RESPONSE>(serviceImpl.OnReceivedInvitationAdded)).AddMethod<InvitationRemovedNotification, NO_RESPONSE>(ChannelInvitationListener.__Method_OnReceivedInvitationRemoved, new UnaryServerMethod<InvitationRemovedNotification, NO_RESPONSE>(serviceImpl.OnReceivedInvitationRemoved))
				.AddMethod<SuggestionAddedNotification, NO_RESPONSE>(ChannelInvitationListener.__Method_OnReceivedSuggestionAdded, new UnaryServerMethod<SuggestionAddedNotification, NO_RESPONSE>(serviceImpl.OnReceivedSuggestionAdded))
				.Build();
		}

		// Token: 0x0600A01A RID: 40986 RVA: 0x0026EF6C File Offset: 0x0026D16C
		public static void BindService(ServiceBinderBase serviceBinder, ChannelInvitationListener.ChannelInvitationListenerBase serviceImpl)
		{
			serviceBinder.AddMethod<InvitationAddedNotification, NO_RESPONSE>(ChannelInvitationListener.__Method_OnReceivedInvitationAdded, (serviceImpl == null) ? null : new UnaryServerMethod<InvitationAddedNotification, NO_RESPONSE>(serviceImpl.OnReceivedInvitationAdded));
			serviceBinder.AddMethod<InvitationRemovedNotification, NO_RESPONSE>(ChannelInvitationListener.__Method_OnReceivedInvitationRemoved, (serviceImpl == null) ? null : new UnaryServerMethod<InvitationRemovedNotification, NO_RESPONSE>(serviceImpl.OnReceivedInvitationRemoved));
			serviceBinder.AddMethod<SuggestionAddedNotification, NO_RESPONSE>(ChannelInvitationListener.__Method_OnReceivedSuggestionAdded, (serviceImpl == null) ? null : new UnaryServerMethod<SuggestionAddedNotification, NO_RESPONSE>(serviceImpl.OnReceivedSuggestionAdded));
		}

		// Token: 0x04004827 RID: 18471
		private static readonly string __ServiceName = "bgs.protocol.channel.v1.ChannelInvitationListener";

		// Token: 0x04004828 RID: 18472
		private static readonly Marshaller<InvitationAddedNotification> __Marshaller_bgs_protocol_channel_v1_InvitationAddedNotification = Marshallers.Create<InvitationAddedNotification>(new Action<InvitationAddedNotification, SerializationContext>(ChannelInvitationListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelInvitationListener.__Helper_DeserializeMessage<InvitationAddedNotification>(context, InvitationAddedNotification.Parser));

		// Token: 0x04004829 RID: 18473
		private static readonly Marshaller<NO_RESPONSE> __Marshaller_bgs_protocol_NO_RESPONSE = Marshallers.Create<NO_RESPONSE>(new Action<NO_RESPONSE, SerializationContext>(ChannelInvitationListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelInvitationListener.__Helper_DeserializeMessage<NO_RESPONSE>(context, NO_RESPONSE.Parser));

		// Token: 0x0400482A RID: 18474
		private static readonly Marshaller<InvitationRemovedNotification> __Marshaller_bgs_protocol_channel_v1_InvitationRemovedNotification = Marshallers.Create<InvitationRemovedNotification>(new Action<InvitationRemovedNotification, SerializationContext>(ChannelInvitationListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelInvitationListener.__Helper_DeserializeMessage<InvitationRemovedNotification>(context, InvitationRemovedNotification.Parser));

		// Token: 0x0400482B RID: 18475
		private static readonly Marshaller<SuggestionAddedNotification> __Marshaller_bgs_protocol_channel_v1_SuggestionAddedNotification = Marshallers.Create<SuggestionAddedNotification>(new Action<SuggestionAddedNotification, SerializationContext>(ChannelInvitationListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelInvitationListener.__Helper_DeserializeMessage<SuggestionAddedNotification>(context, SuggestionAddedNotification.Parser));

		// Token: 0x0400482C RID: 18476
		private static readonly Method<InvitationAddedNotification, NO_RESPONSE> __Method_OnReceivedInvitationAdded = new Method<InvitationAddedNotification, NO_RESPONSE>(0, ChannelInvitationListener.__ServiceName, "OnReceivedInvitationAdded", ChannelInvitationListener.__Marshaller_bgs_protocol_channel_v1_InvitationAddedNotification, ChannelInvitationListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x0400482D RID: 18477
		private static readonly Method<InvitationRemovedNotification, NO_RESPONSE> __Method_OnReceivedInvitationRemoved = new Method<InvitationRemovedNotification, NO_RESPONSE>(0, ChannelInvitationListener.__ServiceName, "OnReceivedInvitationRemoved", ChannelInvitationListener.__Marshaller_bgs_protocol_channel_v1_InvitationRemovedNotification, ChannelInvitationListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x0400482E RID: 18478
		private static readonly Method<SuggestionAddedNotification, NO_RESPONSE> __Method_OnReceivedSuggestionAdded = new Method<SuggestionAddedNotification, NO_RESPONSE>(0, ChannelInvitationListener.__ServiceName, "OnReceivedSuggestionAdded", ChannelInvitationListener.__Marshaller_bgs_protocol_channel_v1_SuggestionAddedNotification, ChannelInvitationListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x020011C8 RID: 4552
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x040098FA RID: 39162
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x020011C9 RID: 4553
		[BindServiceMethod(typeof(ChannelInvitationListener), "BindService")]
		public abstract class ChannelInvitationListenerBase
		{
			// Token: 0x0600D920 RID: 55584 RVA: 0x004BA664 File Offset: 0x004B8864
			public virtual Task<NO_RESPONSE> OnReceivedInvitationAdded(InvitationAddedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D921 RID: 55585 RVA: 0x004BA678 File Offset: 0x004B8878
			public virtual Task<NO_RESPONSE> OnReceivedInvitationRemoved(InvitationRemovedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D922 RID: 55586 RVA: 0x004BA68C File Offset: 0x004B888C
			public virtual Task<NO_RESPONSE> OnReceivedSuggestionAdded(SuggestionAddedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x020011CA RID: 4554
		public class ChannelInvitationListenerClient : ClientBase<ChannelInvitationListener.ChannelInvitationListenerClient>
		{
			// Token: 0x0600D924 RID: 55588 RVA: 0x004BA6A9 File Offset: 0x004B88A9
			public ChannelInvitationListenerClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D925 RID: 55589 RVA: 0x004BA6B4 File Offset: 0x004B88B4
			public ChannelInvitationListenerClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D926 RID: 55590 RVA: 0x004BA6BF File Offset: 0x004B88BF
			protected ChannelInvitationListenerClient()
			{
			}

			// Token: 0x0600D927 RID: 55591 RVA: 0x004BA6C9 File Offset: 0x004B88C9
			protected ChannelInvitationListenerClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D928 RID: 55592 RVA: 0x004BA6D4 File Offset: 0x004B88D4
			public virtual NO_RESPONSE OnReceivedInvitationAdded(InvitationAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnReceivedInvitationAdded(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D929 RID: 55593 RVA: 0x004BA6FC File Offset: 0x004B88FC
			public virtual NO_RESPONSE OnReceivedInvitationAdded(InvitationAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<InvitationAddedNotification, NO_RESPONSE>(ChannelInvitationListener.__Method_OnReceivedInvitationAdded, null, options, request);
			}

			// Token: 0x0600D92A RID: 55594 RVA: 0x004BA724 File Offset: 0x004B8924
			public virtual AsyncUnaryCall<NO_RESPONSE> OnReceivedInvitationAddedAsync(InvitationAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnReceivedInvitationAddedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D92B RID: 55595 RVA: 0x004BA74C File Offset: 0x004B894C
			public virtual AsyncUnaryCall<NO_RESPONSE> OnReceivedInvitationAddedAsync(InvitationAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<InvitationAddedNotification, NO_RESPONSE>(ChannelInvitationListener.__Method_OnReceivedInvitationAdded, null, options, request);
			}

			// Token: 0x0600D92C RID: 55596 RVA: 0x004BA774 File Offset: 0x004B8974
			public virtual NO_RESPONSE OnReceivedInvitationRemoved(InvitationRemovedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnReceivedInvitationRemoved(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D92D RID: 55597 RVA: 0x004BA79C File Offset: 0x004B899C
			public virtual NO_RESPONSE OnReceivedInvitationRemoved(InvitationRemovedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<InvitationRemovedNotification, NO_RESPONSE>(ChannelInvitationListener.__Method_OnReceivedInvitationRemoved, null, options, request);
			}

			// Token: 0x0600D92E RID: 55598 RVA: 0x004BA7C4 File Offset: 0x004B89C4
			public virtual AsyncUnaryCall<NO_RESPONSE> OnReceivedInvitationRemovedAsync(InvitationRemovedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnReceivedInvitationRemovedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D92F RID: 55599 RVA: 0x004BA7EC File Offset: 0x004B89EC
			public virtual AsyncUnaryCall<NO_RESPONSE> OnReceivedInvitationRemovedAsync(InvitationRemovedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<InvitationRemovedNotification, NO_RESPONSE>(ChannelInvitationListener.__Method_OnReceivedInvitationRemoved, null, options, request);
			}

			// Token: 0x0600D930 RID: 55600 RVA: 0x004BA814 File Offset: 0x004B8A14
			public virtual NO_RESPONSE OnReceivedSuggestionAdded(SuggestionAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnReceivedSuggestionAdded(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D931 RID: 55601 RVA: 0x004BA83C File Offset: 0x004B8A3C
			public virtual NO_RESPONSE OnReceivedSuggestionAdded(SuggestionAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SuggestionAddedNotification, NO_RESPONSE>(ChannelInvitationListener.__Method_OnReceivedSuggestionAdded, null, options, request);
			}

			// Token: 0x0600D932 RID: 55602 RVA: 0x004BA864 File Offset: 0x004B8A64
			public virtual AsyncUnaryCall<NO_RESPONSE> OnReceivedSuggestionAddedAsync(SuggestionAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnReceivedSuggestionAddedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D933 RID: 55603 RVA: 0x004BA88C File Offset: 0x004B8A8C
			public virtual AsyncUnaryCall<NO_RESPONSE> OnReceivedSuggestionAddedAsync(SuggestionAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SuggestionAddedNotification, NO_RESPONSE>(ChannelInvitationListener.__Method_OnReceivedSuggestionAdded, null, options, request);
			}

			// Token: 0x0600D934 RID: 55604 RVA: 0x004BA8B4 File Offset: 0x004B8AB4
			protected override ChannelInvitationListener.ChannelInvitationListenerClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new ChannelInvitationListener.ChannelInvitationListenerClient(configuration);
			}
		}
	}
}
