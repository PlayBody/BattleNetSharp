using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Channel.V2.Membership
{
	// Token: 0x020006B4 RID: 1716
	public static class ChannelMembershipListener
	{
		// Token: 0x06009EDC RID: 40668 RVA: 0x0026A1F0 File Offset: 0x002683F0
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

		// Token: 0x06009EDD RID: 40669 RVA: 0x0026A23C File Offset: 0x0026843C
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = ChannelMembershipListener.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17003150 RID: 12624
		// (get) Token: 0x06009EDE RID: 40670 RVA: 0x0026A274 File Offset: 0x00268474
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return ChannelMembershipServiceReflection.Descriptor.Services[1];
			}
		}

		// Token: 0x06009EDF RID: 40671 RVA: 0x0026A298 File Offset: 0x00268498
		public static ServerServiceDefinition BindService(ChannelMembershipListener.ChannelMembershipListenerBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<ChannelAddedNotification, NO_RESPONSE>(ChannelMembershipListener.__Method_OnChannelAdded, new UnaryServerMethod<ChannelAddedNotification, NO_RESPONSE>(serviceImpl.OnChannelAdded)).AddMethod<ChannelRemovedNotification, NO_RESPONSE>(ChannelMembershipListener.__Method_OnChannelRemoved, new UnaryServerMethod<ChannelRemovedNotification, NO_RESPONSE>(serviceImpl.OnChannelRemoved))
				.AddMethod<ReceivedInvitationAddedNotification, NO_RESPONSE>(ChannelMembershipListener.__Method_OnReceivedInvitationAdded, new UnaryServerMethod<ReceivedInvitationAddedNotification, NO_RESPONSE>(serviceImpl.OnReceivedInvitationAdded))
				.AddMethod<ReceivedInvitationRemovedNotification, NO_RESPONSE>(ChannelMembershipListener.__Method_OnReceivedInvitationRemoved, new UnaryServerMethod<ReceivedInvitationRemovedNotification, NO_RESPONSE>(serviceImpl.OnReceivedInvitationRemoved))
				.Build();
		}

		// Token: 0x06009EE0 RID: 40672 RVA: 0x0026A310 File Offset: 0x00268510
		public static void BindService(ServiceBinderBase serviceBinder, ChannelMembershipListener.ChannelMembershipListenerBase serviceImpl)
		{
			serviceBinder.AddMethod<ChannelAddedNotification, NO_RESPONSE>(ChannelMembershipListener.__Method_OnChannelAdded, (serviceImpl == null) ? null : new UnaryServerMethod<ChannelAddedNotification, NO_RESPONSE>(serviceImpl.OnChannelAdded));
			serviceBinder.AddMethod<ChannelRemovedNotification, NO_RESPONSE>(ChannelMembershipListener.__Method_OnChannelRemoved, (serviceImpl == null) ? null : new UnaryServerMethod<ChannelRemovedNotification, NO_RESPONSE>(serviceImpl.OnChannelRemoved));
			serviceBinder.AddMethod<ReceivedInvitationAddedNotification, NO_RESPONSE>(ChannelMembershipListener.__Method_OnReceivedInvitationAdded, (serviceImpl == null) ? null : new UnaryServerMethod<ReceivedInvitationAddedNotification, NO_RESPONSE>(serviceImpl.OnReceivedInvitationAdded));
			serviceBinder.AddMethod<ReceivedInvitationRemovedNotification, NO_RESPONSE>(ChannelMembershipListener.__Method_OnReceivedInvitationRemoved, (serviceImpl == null) ? null : new UnaryServerMethod<ReceivedInvitationRemovedNotification, NO_RESPONSE>(serviceImpl.OnReceivedInvitationRemoved));
		}

		// Token: 0x040047A3 RID: 18339
		private static readonly string __ServiceName = "bgs.protocol.channel.v2.membership.ChannelMembershipListener";

		// Token: 0x040047A4 RID: 18340
		private static readonly Marshaller<ChannelAddedNotification> __Marshaller_bgs_protocol_channel_v2_membership_ChannelAddedNotification = Marshallers.Create<ChannelAddedNotification>(new Action<ChannelAddedNotification, SerializationContext>(ChannelMembershipListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelMembershipListener.__Helper_DeserializeMessage<ChannelAddedNotification>(context, ChannelAddedNotification.Parser));

		// Token: 0x040047A5 RID: 18341
		private static readonly Marshaller<NO_RESPONSE> __Marshaller_bgs_protocol_NO_RESPONSE = Marshallers.Create<NO_RESPONSE>(new Action<NO_RESPONSE, SerializationContext>(ChannelMembershipListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelMembershipListener.__Helper_DeserializeMessage<NO_RESPONSE>(context, NO_RESPONSE.Parser));

		// Token: 0x040047A6 RID: 18342
		private static readonly Marshaller<ChannelRemovedNotification> __Marshaller_bgs_protocol_channel_v2_membership_ChannelRemovedNotification = Marshallers.Create<ChannelRemovedNotification>(new Action<ChannelRemovedNotification, SerializationContext>(ChannelMembershipListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelMembershipListener.__Helper_DeserializeMessage<ChannelRemovedNotification>(context, ChannelRemovedNotification.Parser));

		// Token: 0x040047A7 RID: 18343
		private static readonly Marshaller<ReceivedInvitationAddedNotification> __Marshaller_bgs_protocol_channel_v2_membership_ReceivedInvitationAddedNotification = Marshallers.Create<ReceivedInvitationAddedNotification>(new Action<ReceivedInvitationAddedNotification, SerializationContext>(ChannelMembershipListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelMembershipListener.__Helper_DeserializeMessage<ReceivedInvitationAddedNotification>(context, ReceivedInvitationAddedNotification.Parser));

		// Token: 0x040047A8 RID: 18344
		private static readonly Marshaller<ReceivedInvitationRemovedNotification> __Marshaller_bgs_protocol_channel_v2_membership_ReceivedInvitationRemovedNotification = Marshallers.Create<ReceivedInvitationRemovedNotification>(new Action<ReceivedInvitationRemovedNotification, SerializationContext>(ChannelMembershipListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelMembershipListener.__Helper_DeserializeMessage<ReceivedInvitationRemovedNotification>(context, ReceivedInvitationRemovedNotification.Parser));

		// Token: 0x040047A9 RID: 18345
		private static readonly Method<ChannelAddedNotification, NO_RESPONSE> __Method_OnChannelAdded = new Method<ChannelAddedNotification, NO_RESPONSE>(0, ChannelMembershipListener.__ServiceName, "OnChannelAdded", ChannelMembershipListener.__Marshaller_bgs_protocol_channel_v2_membership_ChannelAddedNotification, ChannelMembershipListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x040047AA RID: 18346
		private static readonly Method<ChannelRemovedNotification, NO_RESPONSE> __Method_OnChannelRemoved = new Method<ChannelRemovedNotification, NO_RESPONSE>(0, ChannelMembershipListener.__ServiceName, "OnChannelRemoved", ChannelMembershipListener.__Marshaller_bgs_protocol_channel_v2_membership_ChannelRemovedNotification, ChannelMembershipListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x040047AB RID: 18347
		private static readonly Method<ReceivedInvitationAddedNotification, NO_RESPONSE> __Method_OnReceivedInvitationAdded = new Method<ReceivedInvitationAddedNotification, NO_RESPONSE>(0, ChannelMembershipListener.__ServiceName, "OnReceivedInvitationAdded", ChannelMembershipListener.__Marshaller_bgs_protocol_channel_v2_membership_ReceivedInvitationAddedNotification, ChannelMembershipListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x040047AC RID: 18348
		private static readonly Method<ReceivedInvitationRemovedNotification, NO_RESPONSE> __Method_OnReceivedInvitationRemoved = new Method<ReceivedInvitationRemovedNotification, NO_RESPONSE>(0, ChannelMembershipListener.__ServiceName, "OnReceivedInvitationRemoved", ChannelMembershipListener.__Marshaller_bgs_protocol_channel_v2_membership_ReceivedInvitationRemovedNotification, ChannelMembershipListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x020011B3 RID: 4531
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x040098E9 RID: 39145
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x020011B4 RID: 4532
		[BindServiceMethod(typeof(ChannelMembershipListener), "BindService")]
		public abstract class ChannelMembershipListenerBase
		{
			// Token: 0x0600D8A1 RID: 55457 RVA: 0x004B9B6C File Offset: 0x004B7D6C
			public virtual Task<NO_RESPONSE> OnChannelAdded(ChannelAddedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D8A2 RID: 55458 RVA: 0x004B9B80 File Offset: 0x004B7D80
			public virtual Task<NO_RESPONSE> OnChannelRemoved(ChannelRemovedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D8A3 RID: 55459 RVA: 0x004B9B94 File Offset: 0x004B7D94
			public virtual Task<NO_RESPONSE> OnReceivedInvitationAdded(ReceivedInvitationAddedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D8A4 RID: 55460 RVA: 0x004B9BA8 File Offset: 0x004B7DA8
			public virtual Task<NO_RESPONSE> OnReceivedInvitationRemoved(ReceivedInvitationRemovedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x020011B5 RID: 4533
		public class ChannelMembershipListenerClient : ClientBase<ChannelMembershipListener.ChannelMembershipListenerClient>
		{
			// Token: 0x0600D8A6 RID: 55462 RVA: 0x004B9BC5 File Offset: 0x004B7DC5
			public ChannelMembershipListenerClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D8A7 RID: 55463 RVA: 0x004B9BD0 File Offset: 0x004B7DD0
			public ChannelMembershipListenerClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D8A8 RID: 55464 RVA: 0x004B9BDB File Offset: 0x004B7DDB
			protected ChannelMembershipListenerClient()
			{
			}

			// Token: 0x0600D8A9 RID: 55465 RVA: 0x004B9BE5 File Offset: 0x004B7DE5
			protected ChannelMembershipListenerClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D8AA RID: 55466 RVA: 0x004B9BF0 File Offset: 0x004B7DF0
			public virtual NO_RESPONSE OnChannelAdded(ChannelAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnChannelAdded(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D8AB RID: 55467 RVA: 0x004B9C18 File Offset: 0x004B7E18
			public virtual NO_RESPONSE OnChannelAdded(ChannelAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ChannelAddedNotification, NO_RESPONSE>(ChannelMembershipListener.__Method_OnChannelAdded, null, options, request);
			}

			// Token: 0x0600D8AC RID: 55468 RVA: 0x004B9C40 File Offset: 0x004B7E40
			public virtual AsyncUnaryCall<NO_RESPONSE> OnChannelAddedAsync(ChannelAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnChannelAddedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D8AD RID: 55469 RVA: 0x004B9C68 File Offset: 0x004B7E68
			public virtual AsyncUnaryCall<NO_RESPONSE> OnChannelAddedAsync(ChannelAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ChannelAddedNotification, NO_RESPONSE>(ChannelMembershipListener.__Method_OnChannelAdded, null, options, request);
			}

			// Token: 0x0600D8AE RID: 55470 RVA: 0x004B9C90 File Offset: 0x004B7E90
			public virtual NO_RESPONSE OnChannelRemoved(ChannelRemovedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnChannelRemoved(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D8AF RID: 55471 RVA: 0x004B9CB8 File Offset: 0x004B7EB8
			public virtual NO_RESPONSE OnChannelRemoved(ChannelRemovedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ChannelRemovedNotification, NO_RESPONSE>(ChannelMembershipListener.__Method_OnChannelRemoved, null, options, request);
			}

			// Token: 0x0600D8B0 RID: 55472 RVA: 0x004B9CE0 File Offset: 0x004B7EE0
			public virtual AsyncUnaryCall<NO_RESPONSE> OnChannelRemovedAsync(ChannelRemovedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnChannelRemovedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D8B1 RID: 55473 RVA: 0x004B9D08 File Offset: 0x004B7F08
			public virtual AsyncUnaryCall<NO_RESPONSE> OnChannelRemovedAsync(ChannelRemovedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ChannelRemovedNotification, NO_RESPONSE>(ChannelMembershipListener.__Method_OnChannelRemoved, null, options, request);
			}

			// Token: 0x0600D8B2 RID: 55474 RVA: 0x004B9D30 File Offset: 0x004B7F30
			public virtual NO_RESPONSE OnReceivedInvitationAdded(ReceivedInvitationAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnReceivedInvitationAdded(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D8B3 RID: 55475 RVA: 0x004B9D58 File Offset: 0x004B7F58
			public virtual NO_RESPONSE OnReceivedInvitationAdded(ReceivedInvitationAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ReceivedInvitationAddedNotification, NO_RESPONSE>(ChannelMembershipListener.__Method_OnReceivedInvitationAdded, null, options, request);
			}

			// Token: 0x0600D8B4 RID: 55476 RVA: 0x004B9D80 File Offset: 0x004B7F80
			public virtual AsyncUnaryCall<NO_RESPONSE> OnReceivedInvitationAddedAsync(ReceivedInvitationAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnReceivedInvitationAddedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D8B5 RID: 55477 RVA: 0x004B9DA8 File Offset: 0x004B7FA8
			public virtual AsyncUnaryCall<NO_RESPONSE> OnReceivedInvitationAddedAsync(ReceivedInvitationAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ReceivedInvitationAddedNotification, NO_RESPONSE>(ChannelMembershipListener.__Method_OnReceivedInvitationAdded, null, options, request);
			}

			// Token: 0x0600D8B6 RID: 55478 RVA: 0x004B9DD0 File Offset: 0x004B7FD0
			public virtual NO_RESPONSE OnReceivedInvitationRemoved(ReceivedInvitationRemovedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnReceivedInvitationRemoved(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D8B7 RID: 55479 RVA: 0x004B9DF8 File Offset: 0x004B7FF8
			public virtual NO_RESPONSE OnReceivedInvitationRemoved(ReceivedInvitationRemovedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ReceivedInvitationRemovedNotification, NO_RESPONSE>(ChannelMembershipListener.__Method_OnReceivedInvitationRemoved, null, options, request);
			}

			// Token: 0x0600D8B8 RID: 55480 RVA: 0x004B9E20 File Offset: 0x004B8020
			public virtual AsyncUnaryCall<NO_RESPONSE> OnReceivedInvitationRemovedAsync(ReceivedInvitationRemovedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnReceivedInvitationRemovedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D8B9 RID: 55481 RVA: 0x004B9E48 File Offset: 0x004B8048
			public virtual AsyncUnaryCall<NO_RESPONSE> OnReceivedInvitationRemovedAsync(ReceivedInvitationRemovedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ReceivedInvitationRemovedNotification, NO_RESPONSE>(ChannelMembershipListener.__Method_OnReceivedInvitationRemoved, null, options, request);
			}

			// Token: 0x0600D8BA RID: 55482 RVA: 0x004B9E70 File Offset: 0x004B8070
			protected override ChannelMembershipListener.ChannelMembershipListenerClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new ChannelMembershipListener.ChannelMembershipListenerClient(configuration);
			}
		}
	}
}
