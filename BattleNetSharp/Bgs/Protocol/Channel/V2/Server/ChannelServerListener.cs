using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Channel.V2.Server
{
	// Token: 0x020006A8 RID: 1704
	public static class ChannelServerListener
	{
		// Token: 0x06009E09 RID: 40457 RVA: 0x00266BFC File Offset: 0x00264DFC
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

		// Token: 0x06009E0A RID: 40458 RVA: 0x00266C48 File Offset: 0x00264E48
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = ChannelServerListener.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x1700311C RID: 12572
		// (get) Token: 0x06009E0B RID: 40459 RVA: 0x00266C80 File Offset: 0x00264E80
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return ChannelListenerReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x06009E0C RID: 40460 RVA: 0x00266CA4 File Offset: 0x00264EA4
		public static ServerServiceDefinition BindService(ChannelServerListener.ChannelServerListenerBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<ChannelStateChangedNotification, NO_RESPONSE>(ChannelServerListener.__Method_OnChannelStateChanged, new UnaryServerMethod<ChannelStateChangedNotification, NO_RESPONSE>(serviceImpl.OnChannelStateChanged)).AddMethod<MemberAddedNotification, NO_RESPONSE>(ChannelServerListener.__Method_OnMemberAdded, new UnaryServerMethod<MemberAddedNotification, NO_RESPONSE>(serviceImpl.OnMemberAdded))
				.AddMethod<MemberRemovedNotification, NO_RESPONSE>(ChannelServerListener.__Method_OnMemberRemoved, new UnaryServerMethod<MemberRemovedNotification, NO_RESPONSE>(serviceImpl.OnMemberRemoved))
				.AddMethod<MemberStateChangedNotification, NO_RESPONSE>(ChannelServerListener.__Method_OnMemberStateChanged, new UnaryServerMethod<MemberStateChangedNotification, NO_RESPONSE>(serviceImpl.OnMemberStateChanged))
				.AddMethod<MemberRoleChangedNotification, NO_RESPONSE>(ChannelServerListener.__Method_OnMemberRoleChanged, new UnaryServerMethod<MemberRoleChangedNotification, NO_RESPONSE>(serviceImpl.OnMemberRoleChanged))
				.Build();
		}

		// Token: 0x06009E0D RID: 40461 RVA: 0x00266D34 File Offset: 0x00264F34
		public static void BindService(ServiceBinderBase serviceBinder, ChannelServerListener.ChannelServerListenerBase serviceImpl)
		{
			serviceBinder.AddMethod<ChannelStateChangedNotification, NO_RESPONSE>(ChannelServerListener.__Method_OnChannelStateChanged, (serviceImpl == null) ? null : new UnaryServerMethod<ChannelStateChangedNotification, NO_RESPONSE>(serviceImpl.OnChannelStateChanged));
			serviceBinder.AddMethod<MemberAddedNotification, NO_RESPONSE>(ChannelServerListener.__Method_OnMemberAdded, (serviceImpl == null) ? null : new UnaryServerMethod<MemberAddedNotification, NO_RESPONSE>(serviceImpl.OnMemberAdded));
			serviceBinder.AddMethod<MemberRemovedNotification, NO_RESPONSE>(ChannelServerListener.__Method_OnMemberRemoved, (serviceImpl == null) ? null : new UnaryServerMethod<MemberRemovedNotification, NO_RESPONSE>(serviceImpl.OnMemberRemoved));
			serviceBinder.AddMethod<MemberStateChangedNotification, NO_RESPONSE>(ChannelServerListener.__Method_OnMemberStateChanged, (serviceImpl == null) ? null : new UnaryServerMethod<MemberStateChangedNotification, NO_RESPONSE>(serviceImpl.OnMemberStateChanged));
			serviceBinder.AddMethod<MemberRoleChangedNotification, NO_RESPONSE>(ChannelServerListener.__Method_OnMemberRoleChanged, (serviceImpl == null) ? null : new UnaryServerMethod<MemberRoleChangedNotification, NO_RESPONSE>(serviceImpl.OnMemberRoleChanged));
		}

		// Token: 0x0400474F RID: 18255
		private static readonly string __ServiceName = "bgs.protocol.channel.v2.server.ChannelServerListener";

		// Token: 0x04004750 RID: 18256
		private static readonly Marshaller<ChannelStateChangedNotification> __Marshaller_bgs_protocol_channel_v2_server_ChannelStateChangedNotification = Marshallers.Create<ChannelStateChangedNotification>(new Action<ChannelStateChangedNotification, SerializationContext>(ChannelServerListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelServerListener.__Helper_DeserializeMessage<ChannelStateChangedNotification>(context, ChannelStateChangedNotification.Parser));

		// Token: 0x04004751 RID: 18257
		private static readonly Marshaller<NO_RESPONSE> __Marshaller_bgs_protocol_NO_RESPONSE = Marshallers.Create<NO_RESPONSE>(new Action<NO_RESPONSE, SerializationContext>(ChannelServerListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelServerListener.__Helper_DeserializeMessage<NO_RESPONSE>(context, NO_RESPONSE.Parser));

		// Token: 0x04004752 RID: 18258
		private static readonly Marshaller<MemberAddedNotification> __Marshaller_bgs_protocol_channel_v2_server_MemberAddedNotification = Marshallers.Create<MemberAddedNotification>(new Action<MemberAddedNotification, SerializationContext>(ChannelServerListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelServerListener.__Helper_DeserializeMessage<MemberAddedNotification>(context, MemberAddedNotification.Parser));

		// Token: 0x04004753 RID: 18259
		private static readonly Marshaller<MemberRemovedNotification> __Marshaller_bgs_protocol_channel_v2_server_MemberRemovedNotification = Marshallers.Create<MemberRemovedNotification>(new Action<MemberRemovedNotification, SerializationContext>(ChannelServerListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelServerListener.__Helper_DeserializeMessage<MemberRemovedNotification>(context, MemberRemovedNotification.Parser));

		// Token: 0x04004754 RID: 18260
		private static readonly Marshaller<MemberStateChangedNotification> __Marshaller_bgs_protocol_channel_v2_server_MemberStateChangedNotification = Marshallers.Create<MemberStateChangedNotification>(new Action<MemberStateChangedNotification, SerializationContext>(ChannelServerListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelServerListener.__Helper_DeserializeMessage<MemberStateChangedNotification>(context, MemberStateChangedNotification.Parser));

		// Token: 0x04004755 RID: 18261
		private static readonly Marshaller<MemberRoleChangedNotification> __Marshaller_bgs_protocol_channel_v2_server_MemberRoleChangedNotification = Marshallers.Create<MemberRoleChangedNotification>(new Action<MemberRoleChangedNotification, SerializationContext>(ChannelServerListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelServerListener.__Helper_DeserializeMessage<MemberRoleChangedNotification>(context, MemberRoleChangedNotification.Parser));

		// Token: 0x04004756 RID: 18262
		private static readonly Method<ChannelStateChangedNotification, NO_RESPONSE> __Method_OnChannelStateChanged = new Method<ChannelStateChangedNotification, NO_RESPONSE>(0, ChannelServerListener.__ServiceName, "OnChannelStateChanged", ChannelServerListener.__Marshaller_bgs_protocol_channel_v2_server_ChannelStateChangedNotification, ChannelServerListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04004757 RID: 18263
		private static readonly Method<MemberAddedNotification, NO_RESPONSE> __Method_OnMemberAdded = new Method<MemberAddedNotification, NO_RESPONSE>(0, ChannelServerListener.__ServiceName, "OnMemberAdded", ChannelServerListener.__Marshaller_bgs_protocol_channel_v2_server_MemberAddedNotification, ChannelServerListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04004758 RID: 18264
		private static readonly Method<MemberRemovedNotification, NO_RESPONSE> __Method_OnMemberRemoved = new Method<MemberRemovedNotification, NO_RESPONSE>(0, ChannelServerListener.__ServiceName, "OnMemberRemoved", ChannelServerListener.__Marshaller_bgs_protocol_channel_v2_server_MemberRemovedNotification, ChannelServerListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04004759 RID: 18265
		private static readonly Method<MemberStateChangedNotification, NO_RESPONSE> __Method_OnMemberStateChanged = new Method<MemberStateChangedNotification, NO_RESPONSE>(0, ChannelServerListener.__ServiceName, "OnMemberStateChanged", ChannelServerListener.__Marshaller_bgs_protocol_channel_v2_server_MemberStateChangedNotification, ChannelServerListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x0400475A RID: 18266
		private static readonly Method<MemberRoleChangedNotification, NO_RESPONSE> __Method_OnMemberRoleChanged = new Method<MemberRoleChangedNotification, NO_RESPONSE>(0, ChannelServerListener.__ServiceName, "OnMemberRoleChanged", ChannelServerListener.__Marshaller_bgs_protocol_channel_v2_server_MemberRoleChangedNotification, ChannelServerListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x020011A2 RID: 4514
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x040098DC RID: 39132
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x020011A3 RID: 4515
		[BindServiceMethod(typeof(ChannelServerListener), "BindService")]
		public abstract class ChannelServerListenerBase
		{
			// Token: 0x0600D840 RID: 55360 RVA: 0x004B9326 File Offset: 0x004B7526
			public virtual Task<NO_RESPONSE> OnChannelStateChanged(ChannelStateChangedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D841 RID: 55361 RVA: 0x004B933A File Offset: 0x004B753A
			public virtual Task<NO_RESPONSE> OnMemberAdded(MemberAddedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D842 RID: 55362 RVA: 0x004B934E File Offset: 0x004B754E
			public virtual Task<NO_RESPONSE> OnMemberRemoved(MemberRemovedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D843 RID: 55363 RVA: 0x004B9362 File Offset: 0x004B7562
			public virtual Task<NO_RESPONSE> OnMemberStateChanged(MemberStateChangedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D844 RID: 55364 RVA: 0x004B9376 File Offset: 0x004B7576
			public virtual Task<NO_RESPONSE> OnMemberRoleChanged(MemberRoleChangedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x020011A4 RID: 4516
		public class ChannelServerListenerClient : ClientBase<ChannelServerListener.ChannelServerListenerClient>
		{
			// Token: 0x0600D846 RID: 55366 RVA: 0x004B9393 File Offset: 0x004B7593
			public ChannelServerListenerClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D847 RID: 55367 RVA: 0x004B939E File Offset: 0x004B759E
			public ChannelServerListenerClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D848 RID: 55368 RVA: 0x004B93A9 File Offset: 0x004B75A9
			protected ChannelServerListenerClient()
			{
			}

			// Token: 0x0600D849 RID: 55369 RVA: 0x004B93B3 File Offset: 0x004B75B3
			protected ChannelServerListenerClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D84A RID: 55370 RVA: 0x004B93C0 File Offset: 0x004B75C0
			public virtual NO_RESPONSE OnChannelStateChanged(ChannelStateChangedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnChannelStateChanged(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D84B RID: 55371 RVA: 0x004B93E8 File Offset: 0x004B75E8
			public virtual NO_RESPONSE OnChannelStateChanged(ChannelStateChangedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ChannelStateChangedNotification, NO_RESPONSE>(ChannelServerListener.__Method_OnChannelStateChanged, null, options, request);
			}

			// Token: 0x0600D84C RID: 55372 RVA: 0x004B9410 File Offset: 0x004B7610
			public virtual AsyncUnaryCall<NO_RESPONSE> OnChannelStateChangedAsync(ChannelStateChangedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnChannelStateChangedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D84D RID: 55373 RVA: 0x004B9438 File Offset: 0x004B7638
			public virtual AsyncUnaryCall<NO_RESPONSE> OnChannelStateChangedAsync(ChannelStateChangedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ChannelStateChangedNotification, NO_RESPONSE>(ChannelServerListener.__Method_OnChannelStateChanged, null, options, request);
			}

			// Token: 0x0600D84E RID: 55374 RVA: 0x004B9460 File Offset: 0x004B7660
			public virtual NO_RESPONSE OnMemberAdded(MemberAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnMemberAdded(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D84F RID: 55375 RVA: 0x004B9488 File Offset: 0x004B7688
			public virtual NO_RESPONSE OnMemberAdded(MemberAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<MemberAddedNotification, NO_RESPONSE>(ChannelServerListener.__Method_OnMemberAdded, null, options, request);
			}

			// Token: 0x0600D850 RID: 55376 RVA: 0x004B94B0 File Offset: 0x004B76B0
			public virtual AsyncUnaryCall<NO_RESPONSE> OnMemberAddedAsync(MemberAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnMemberAddedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D851 RID: 55377 RVA: 0x004B94D8 File Offset: 0x004B76D8
			public virtual AsyncUnaryCall<NO_RESPONSE> OnMemberAddedAsync(MemberAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<MemberAddedNotification, NO_RESPONSE>(ChannelServerListener.__Method_OnMemberAdded, null, options, request);
			}

			// Token: 0x0600D852 RID: 55378 RVA: 0x004B9500 File Offset: 0x004B7700
			public virtual NO_RESPONSE OnMemberRemoved(MemberRemovedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnMemberRemoved(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D853 RID: 55379 RVA: 0x004B9528 File Offset: 0x004B7728
			public virtual NO_RESPONSE OnMemberRemoved(MemberRemovedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<MemberRemovedNotification, NO_RESPONSE>(ChannelServerListener.__Method_OnMemberRemoved, null, options, request);
			}

			// Token: 0x0600D854 RID: 55380 RVA: 0x004B9550 File Offset: 0x004B7750
			public virtual AsyncUnaryCall<NO_RESPONSE> OnMemberRemovedAsync(MemberRemovedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnMemberRemovedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D855 RID: 55381 RVA: 0x004B9578 File Offset: 0x004B7778
			public virtual AsyncUnaryCall<NO_RESPONSE> OnMemberRemovedAsync(MemberRemovedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<MemberRemovedNotification, NO_RESPONSE>(ChannelServerListener.__Method_OnMemberRemoved, null, options, request);
			}

			// Token: 0x0600D856 RID: 55382 RVA: 0x004B95A0 File Offset: 0x004B77A0
			public virtual NO_RESPONSE OnMemberStateChanged(MemberStateChangedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnMemberStateChanged(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D857 RID: 55383 RVA: 0x004B95C8 File Offset: 0x004B77C8
			public virtual NO_RESPONSE OnMemberStateChanged(MemberStateChangedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<MemberStateChangedNotification, NO_RESPONSE>(ChannelServerListener.__Method_OnMemberStateChanged, null, options, request);
			}

			// Token: 0x0600D858 RID: 55384 RVA: 0x004B95F0 File Offset: 0x004B77F0
			public virtual AsyncUnaryCall<NO_RESPONSE> OnMemberStateChangedAsync(MemberStateChangedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnMemberStateChangedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D859 RID: 55385 RVA: 0x004B9618 File Offset: 0x004B7818
			public virtual AsyncUnaryCall<NO_RESPONSE> OnMemberStateChangedAsync(MemberStateChangedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<MemberStateChangedNotification, NO_RESPONSE>(ChannelServerListener.__Method_OnMemberStateChanged, null, options, request);
			}

			// Token: 0x0600D85A RID: 55386 RVA: 0x004B9640 File Offset: 0x004B7840
			public virtual NO_RESPONSE OnMemberRoleChanged(MemberRoleChangedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnMemberRoleChanged(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D85B RID: 55387 RVA: 0x004B9668 File Offset: 0x004B7868
			public virtual NO_RESPONSE OnMemberRoleChanged(MemberRoleChangedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<MemberRoleChangedNotification, NO_RESPONSE>(ChannelServerListener.__Method_OnMemberRoleChanged, null, options, request);
			}

			// Token: 0x0600D85C RID: 55388 RVA: 0x004B9690 File Offset: 0x004B7890
			public virtual AsyncUnaryCall<NO_RESPONSE> OnMemberRoleChangedAsync(MemberRoleChangedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnMemberRoleChangedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D85D RID: 55389 RVA: 0x004B96B8 File Offset: 0x004B78B8
			public virtual AsyncUnaryCall<NO_RESPONSE> OnMemberRoleChangedAsync(MemberRoleChangedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<MemberRoleChangedNotification, NO_RESPONSE>(ChannelServerListener.__Method_OnMemberRoleChanged, null, options, request);
			}

			// Token: 0x0600D85E RID: 55390 RVA: 0x004B96E0 File Offset: 0x004B78E0
			protected override ChannelServerListener.ChannelServerListenerClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new ChannelServerListener.ChannelServerListenerClient(configuration);
			}
		}
	}
}
