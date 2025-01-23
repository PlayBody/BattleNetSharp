using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.BlockList.V1.Client
{
	// Token: 0x020006FB RID: 1787
	public static class BlockListListener
	{
		// Token: 0x0600A47D RID: 42109 RVA: 0x00281408 File Offset: 0x0027F608
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

		// Token: 0x0600A47E RID: 42110 RVA: 0x00281454 File Offset: 0x0027F654
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = BlockListListener.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x170032E5 RID: 13029
		// (get) Token: 0x0600A47F RID: 42111 RVA: 0x0028148C File Offset: 0x0027F68C
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return BlockListListenerReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x0600A480 RID: 42112 RVA: 0x002814B0 File Offset: 0x0027F6B0
		public static ServerServiceDefinition BindService(BlockListListener.BlockListListenerBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<BlockedPlayerAddedNotification, NO_RESPONSE>(BlockListListener.__Method_OnBlockedPlayerAdded, new UnaryServerMethod<BlockedPlayerAddedNotification, NO_RESPONSE>(serviceImpl.OnBlockedPlayerAdded)).AddMethod<BlockedPlayerRemovedNotification, NO_RESPONSE>(BlockListListener.__Method_OnBlockedPlayerRemoved, new UnaryServerMethod<BlockedPlayerRemovedNotification, NO_RESPONSE>(serviceImpl.OnBlockedPlayerRemoved))
				.Build();
		}

		// Token: 0x0600A481 RID: 42113 RVA: 0x002814FC File Offset: 0x0027F6FC
		public static void BindService(ServiceBinderBase serviceBinder, BlockListListener.BlockListListenerBase serviceImpl)
		{
			serviceBinder.AddMethod<BlockedPlayerAddedNotification, NO_RESPONSE>(BlockListListener.__Method_OnBlockedPlayerAdded, (serviceImpl == null) ? null : new UnaryServerMethod<BlockedPlayerAddedNotification, NO_RESPONSE>(serviceImpl.OnBlockedPlayerAdded));
			serviceBinder.AddMethod<BlockedPlayerRemovedNotification, NO_RESPONSE>(BlockListListener.__Method_OnBlockedPlayerRemoved, (serviceImpl == null) ? null : new UnaryServerMethod<BlockedPlayerRemovedNotification, NO_RESPONSE>(serviceImpl.OnBlockedPlayerRemoved));
		}

		// Token: 0x04004A1E RID: 18974
		private static readonly string __ServiceName = "bgs.protocol.block_list.v1.client.BlockListListener";

		// Token: 0x04004A1F RID: 18975
		private static readonly Marshaller<BlockedPlayerAddedNotification> __Marshaller_bgs_protocol_block_list_v1_client_BlockedPlayerAddedNotification = Marshallers.Create<BlockedPlayerAddedNotification>(new Action<BlockedPlayerAddedNotification, SerializationContext>(BlockListListener.__Helper_SerializeMessage), (DeserializationContext context) => BlockListListener.__Helper_DeserializeMessage<BlockedPlayerAddedNotification>(context, BlockedPlayerAddedNotification.Parser));

		// Token: 0x04004A20 RID: 18976
		private static readonly Marshaller<NO_RESPONSE> __Marshaller_bgs_protocol_NO_RESPONSE = Marshallers.Create<NO_RESPONSE>(new Action<NO_RESPONSE, SerializationContext>(BlockListListener.__Helper_SerializeMessage), (DeserializationContext context) => BlockListListener.__Helper_DeserializeMessage<NO_RESPONSE>(context, NO_RESPONSE.Parser));

		// Token: 0x04004A21 RID: 18977
		private static readonly Marshaller<BlockedPlayerRemovedNotification> __Marshaller_bgs_protocol_block_list_v1_client_BlockedPlayerRemovedNotification = Marshallers.Create<BlockedPlayerRemovedNotification>(new Action<BlockedPlayerRemovedNotification, SerializationContext>(BlockListListener.__Helper_SerializeMessage), (DeserializationContext context) => BlockListListener.__Helper_DeserializeMessage<BlockedPlayerRemovedNotification>(context, BlockedPlayerRemovedNotification.Parser));

		// Token: 0x04004A22 RID: 18978
		private static readonly Method<BlockedPlayerAddedNotification, NO_RESPONSE> __Method_OnBlockedPlayerAdded = new Method<BlockedPlayerAddedNotification, NO_RESPONSE>(0, BlockListListener.__ServiceName, "OnBlockedPlayerAdded", BlockListListener.__Marshaller_bgs_protocol_block_list_v1_client_BlockedPlayerAddedNotification, BlockListListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04004A23 RID: 18979
		private static readonly Method<BlockedPlayerRemovedNotification, NO_RESPONSE> __Method_OnBlockedPlayerRemoved = new Method<BlockedPlayerRemovedNotification, NO_RESPONSE>(0, BlockListListener.__ServiceName, "OnBlockedPlayerRemoved", BlockListListener.__Marshaller_bgs_protocol_block_list_v1_client_BlockedPlayerRemovedNotification, BlockListListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x0200120A RID: 4618
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x04009931 RID: 39217
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x0200120B RID: 4619
		[BindServiceMethod(typeof(BlockListListener), "BindService")]
		public abstract class BlockListListenerBase
		{
			// Token: 0x0600DA5C RID: 55900 RVA: 0x004BBF0B File Offset: 0x004BA10B
			public virtual Task<NO_RESPONSE> OnBlockedPlayerAdded(BlockedPlayerAddedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DA5D RID: 55901 RVA: 0x004BBF1F File Offset: 0x004BA11F
			public virtual Task<NO_RESPONSE> OnBlockedPlayerRemoved(BlockedPlayerRemovedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x0200120C RID: 4620
		public class BlockListListenerClient : ClientBase<BlockListListener.BlockListListenerClient>
		{
			// Token: 0x0600DA5F RID: 55903 RVA: 0x004BBF3C File Offset: 0x004BA13C
			public BlockListListenerClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600DA60 RID: 55904 RVA: 0x004BBF47 File Offset: 0x004BA147
			public BlockListListenerClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600DA61 RID: 55905 RVA: 0x004BBF52 File Offset: 0x004BA152
			protected BlockListListenerClient()
			{
			}

			// Token: 0x0600DA62 RID: 55906 RVA: 0x004BBF5C File Offset: 0x004BA15C
			protected BlockListListenerClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600DA63 RID: 55907 RVA: 0x004BBF68 File Offset: 0x004BA168
			public virtual NO_RESPONSE OnBlockedPlayerAdded(BlockedPlayerAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnBlockedPlayerAdded(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DA64 RID: 55908 RVA: 0x004BBF90 File Offset: 0x004BA190
			public virtual NO_RESPONSE OnBlockedPlayerAdded(BlockedPlayerAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<BlockedPlayerAddedNotification, NO_RESPONSE>(BlockListListener.__Method_OnBlockedPlayerAdded, null, options, request);
			}

			// Token: 0x0600DA65 RID: 55909 RVA: 0x004BBFB8 File Offset: 0x004BA1B8
			public virtual AsyncUnaryCall<NO_RESPONSE> OnBlockedPlayerAddedAsync(BlockedPlayerAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnBlockedPlayerAddedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DA66 RID: 55910 RVA: 0x004BBFE0 File Offset: 0x004BA1E0
			public virtual AsyncUnaryCall<NO_RESPONSE> OnBlockedPlayerAddedAsync(BlockedPlayerAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<BlockedPlayerAddedNotification, NO_RESPONSE>(BlockListListener.__Method_OnBlockedPlayerAdded, null, options, request);
			}

			// Token: 0x0600DA67 RID: 55911 RVA: 0x004BC008 File Offset: 0x004BA208
			public virtual NO_RESPONSE OnBlockedPlayerRemoved(BlockedPlayerRemovedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnBlockedPlayerRemoved(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DA68 RID: 55912 RVA: 0x004BC030 File Offset: 0x004BA230
			public virtual NO_RESPONSE OnBlockedPlayerRemoved(BlockedPlayerRemovedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<BlockedPlayerRemovedNotification, NO_RESPONSE>(BlockListListener.__Method_OnBlockedPlayerRemoved, null, options, request);
			}

			// Token: 0x0600DA69 RID: 55913 RVA: 0x004BC058 File Offset: 0x004BA258
			public virtual AsyncUnaryCall<NO_RESPONSE> OnBlockedPlayerRemovedAsync(BlockedPlayerRemovedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnBlockedPlayerRemovedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DA6A RID: 55914 RVA: 0x004BC080 File Offset: 0x004BA280
			public virtual AsyncUnaryCall<NO_RESPONSE> OnBlockedPlayerRemovedAsync(BlockedPlayerRemovedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<BlockedPlayerRemovedNotification, NO_RESPONSE>(BlockListListener.__Method_OnBlockedPlayerRemoved, null, options, request);
			}

			// Token: 0x0600DA6B RID: 55915 RVA: 0x004BC0A8 File Offset: 0x004BA2A8
			protected override BlockListListener.BlockListListenerClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new BlockListListener.BlockListListenerClient(configuration);
			}
		}
	}
}
