using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.UserManager.V1
{
	// Token: 0x020003BF RID: 959
	public static class UserManagerListener
	{
		// Token: 0x06006030 RID: 24624 RVA: 0x00174BF0 File Offset: 0x00172DF0
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

		// Token: 0x06006031 RID: 24625 RVA: 0x00174C3C File Offset: 0x00172E3C
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = UserManagerListener.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17001F0C RID: 7948
		// (get) Token: 0x06006032 RID: 24626 RVA: 0x00174C74 File Offset: 0x00172E74
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return UserManagerServiceReflection.Descriptor.Services[1];
			}
		}

		// Token: 0x06006033 RID: 24627 RVA: 0x00174C98 File Offset: 0x00172E98
		public static ServerServiceDefinition BindService(UserManagerListener.UserManagerListenerBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<BlockedPlayerAddedNotification, NO_RESPONSE>(UserManagerListener.__Method_OnBlockedPlayerAdded, new UnaryServerMethod<BlockedPlayerAddedNotification, NO_RESPONSE>(serviceImpl.OnBlockedPlayerAdded)).AddMethod<BlockedPlayerRemovedNotification, NO_RESPONSE>(UserManagerListener.__Method_OnBlockedPlayerRemoved, new UnaryServerMethod<BlockedPlayerRemovedNotification, NO_RESPONSE>(serviceImpl.OnBlockedPlayerRemoved))
				.AddMethod<RecentPlayersAddedNotification, NO_RESPONSE>(UserManagerListener.__Method_OnRecentPlayersAdded, new UnaryServerMethod<RecentPlayersAddedNotification, NO_RESPONSE>(serviceImpl.OnRecentPlayersAdded))
				.AddMethod<RecentPlayersRemovedNotification, NO_RESPONSE>(UserManagerListener.__Method_OnRecentPlayersRemoved, new UnaryServerMethod<RecentPlayersRemovedNotification, NO_RESPONSE>(serviceImpl.OnRecentPlayersRemoved))
				.Build();
		}

		// Token: 0x06006034 RID: 24628 RVA: 0x00174D10 File Offset: 0x00172F10
		public static void BindService(ServiceBinderBase serviceBinder, UserManagerListener.UserManagerListenerBase serviceImpl)
		{
			serviceBinder.AddMethod<BlockedPlayerAddedNotification, NO_RESPONSE>(UserManagerListener.__Method_OnBlockedPlayerAdded, (serviceImpl == null) ? null : new UnaryServerMethod<BlockedPlayerAddedNotification, NO_RESPONSE>(serviceImpl.OnBlockedPlayerAdded));
			serviceBinder.AddMethod<BlockedPlayerRemovedNotification, NO_RESPONSE>(UserManagerListener.__Method_OnBlockedPlayerRemoved, (serviceImpl == null) ? null : new UnaryServerMethod<BlockedPlayerRemovedNotification, NO_RESPONSE>(serviceImpl.OnBlockedPlayerRemoved));
			serviceBinder.AddMethod<RecentPlayersAddedNotification, NO_RESPONSE>(UserManagerListener.__Method_OnRecentPlayersAdded, (serviceImpl == null) ? null : new UnaryServerMethod<RecentPlayersAddedNotification, NO_RESPONSE>(serviceImpl.OnRecentPlayersAdded));
			serviceBinder.AddMethod<RecentPlayersRemovedNotification, NO_RESPONSE>(UserManagerListener.__Method_OnRecentPlayersRemoved, (serviceImpl == null) ? null : new UnaryServerMethod<RecentPlayersRemovedNotification, NO_RESPONSE>(serviceImpl.OnRecentPlayersRemoved));
		}

		// Token: 0x04002BF4 RID: 11252
		private static readonly string __ServiceName = "bgs.protocol.user_manager.v1.UserManagerListener";

		// Token: 0x04002BF5 RID: 11253
		private static readonly Marshaller<BlockedPlayerAddedNotification> __Marshaller_bgs_protocol_user_manager_v1_BlockedPlayerAddedNotification = Marshallers.Create<BlockedPlayerAddedNotification>(new Action<BlockedPlayerAddedNotification, SerializationContext>(UserManagerListener.__Helper_SerializeMessage), (DeserializationContext context) => UserManagerListener.__Helper_DeserializeMessage<BlockedPlayerAddedNotification>(context, BlockedPlayerAddedNotification.Parser));

		// Token: 0x04002BF6 RID: 11254
		private static readonly Marshaller<NO_RESPONSE> __Marshaller_bgs_protocol_NO_RESPONSE = Marshallers.Create<NO_RESPONSE>(new Action<NO_RESPONSE, SerializationContext>(UserManagerListener.__Helper_SerializeMessage), (DeserializationContext context) => UserManagerListener.__Helper_DeserializeMessage<NO_RESPONSE>(context, NO_RESPONSE.Parser));

		// Token: 0x04002BF7 RID: 11255
		private static readonly Marshaller<BlockedPlayerRemovedNotification> __Marshaller_bgs_protocol_user_manager_v1_BlockedPlayerRemovedNotification = Marshallers.Create<BlockedPlayerRemovedNotification>(new Action<BlockedPlayerRemovedNotification, SerializationContext>(UserManagerListener.__Helper_SerializeMessage), (DeserializationContext context) => UserManagerListener.__Helper_DeserializeMessage<BlockedPlayerRemovedNotification>(context, BlockedPlayerRemovedNotification.Parser));

		// Token: 0x04002BF8 RID: 11256
		private static readonly Marshaller<RecentPlayersAddedNotification> __Marshaller_bgs_protocol_user_manager_v1_RecentPlayersAddedNotification = Marshallers.Create<RecentPlayersAddedNotification>(new Action<RecentPlayersAddedNotification, SerializationContext>(UserManagerListener.__Helper_SerializeMessage), (DeserializationContext context) => UserManagerListener.__Helper_DeserializeMessage<RecentPlayersAddedNotification>(context, RecentPlayersAddedNotification.Parser));

		// Token: 0x04002BF9 RID: 11257
		private static readonly Marshaller<RecentPlayersRemovedNotification> __Marshaller_bgs_protocol_user_manager_v1_RecentPlayersRemovedNotification = Marshallers.Create<RecentPlayersRemovedNotification>(new Action<RecentPlayersRemovedNotification, SerializationContext>(UserManagerListener.__Helper_SerializeMessage), (DeserializationContext context) => UserManagerListener.__Helper_DeserializeMessage<RecentPlayersRemovedNotification>(context, RecentPlayersRemovedNotification.Parser));

		// Token: 0x04002BFA RID: 11258
		private static readonly Method<BlockedPlayerAddedNotification, NO_RESPONSE> __Method_OnBlockedPlayerAdded = new Method<BlockedPlayerAddedNotification, NO_RESPONSE>(0, UserManagerListener.__ServiceName, "OnBlockedPlayerAdded", UserManagerListener.__Marshaller_bgs_protocol_user_manager_v1_BlockedPlayerAddedNotification, UserManagerListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04002BFB RID: 11259
		private static readonly Method<BlockedPlayerRemovedNotification, NO_RESPONSE> __Method_OnBlockedPlayerRemoved = new Method<BlockedPlayerRemovedNotification, NO_RESPONSE>(0, UserManagerListener.__ServiceName, "OnBlockedPlayerRemoved", UserManagerListener.__Marshaller_bgs_protocol_user_manager_v1_BlockedPlayerRemovedNotification, UserManagerListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04002BFC RID: 11260
		private static readonly Method<RecentPlayersAddedNotification, NO_RESPONSE> __Method_OnRecentPlayersAdded = new Method<RecentPlayersAddedNotification, NO_RESPONSE>(0, UserManagerListener.__ServiceName, "OnRecentPlayersAdded", UserManagerListener.__Marshaller_bgs_protocol_user_manager_v1_RecentPlayersAddedNotification, UserManagerListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04002BFD RID: 11261
		private static readonly Method<RecentPlayersRemovedNotification, NO_RESPONSE> __Method_OnRecentPlayersRemoved = new Method<RecentPlayersRemovedNotification, NO_RESPONSE>(0, UserManagerListener.__ServiceName, "OnRecentPlayersRemoved", UserManagerListener.__Marshaller_bgs_protocol_user_manager_v1_RecentPlayersRemovedNotification, UserManagerListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x02000E8E RID: 3726
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x040095FA RID: 38394
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02000E8F RID: 3727
		[BindServiceMethod(typeof(UserManagerListener), "BindService")]
		public abstract class UserManagerListenerBase
		{
			// Token: 0x0600CA61 RID: 51809 RVA: 0x004A9766 File Offset: 0x004A7966
			public virtual Task<NO_RESPONSE> OnBlockedPlayerAdded(BlockedPlayerAddedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CA62 RID: 51810 RVA: 0x004A977A File Offset: 0x004A797A
			public virtual Task<NO_RESPONSE> OnBlockedPlayerRemoved(BlockedPlayerRemovedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CA63 RID: 51811 RVA: 0x004A978E File Offset: 0x004A798E
			public virtual Task<NO_RESPONSE> OnRecentPlayersAdded(RecentPlayersAddedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CA64 RID: 51812 RVA: 0x004A97A2 File Offset: 0x004A79A2
			public virtual Task<NO_RESPONSE> OnRecentPlayersRemoved(RecentPlayersRemovedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x02000E90 RID: 3728
		public class UserManagerListenerClient : ClientBase<UserManagerListener.UserManagerListenerClient>
		{
			// Token: 0x0600CA66 RID: 51814 RVA: 0x004A97BF File Offset: 0x004A79BF
			public UserManagerListenerClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600CA67 RID: 51815 RVA: 0x004A97CA File Offset: 0x004A79CA
			public UserManagerListenerClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600CA68 RID: 51816 RVA: 0x004A97D5 File Offset: 0x004A79D5
			protected UserManagerListenerClient()
			{
			}

			// Token: 0x0600CA69 RID: 51817 RVA: 0x004A97DF File Offset: 0x004A79DF
			protected UserManagerListenerClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600CA6A RID: 51818 RVA: 0x004A97EC File Offset: 0x004A79EC
			public virtual NO_RESPONSE OnBlockedPlayerAdded(BlockedPlayerAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnBlockedPlayerAdded(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CA6B RID: 51819 RVA: 0x004A9814 File Offset: 0x004A7A14
			public virtual NO_RESPONSE OnBlockedPlayerAdded(BlockedPlayerAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<BlockedPlayerAddedNotification, NO_RESPONSE>(UserManagerListener.__Method_OnBlockedPlayerAdded, null, options, request);
			}

			// Token: 0x0600CA6C RID: 51820 RVA: 0x004A983C File Offset: 0x004A7A3C
			public virtual AsyncUnaryCall<NO_RESPONSE> OnBlockedPlayerAddedAsync(BlockedPlayerAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnBlockedPlayerAddedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CA6D RID: 51821 RVA: 0x004A9864 File Offset: 0x004A7A64
			public virtual AsyncUnaryCall<NO_RESPONSE> OnBlockedPlayerAddedAsync(BlockedPlayerAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<BlockedPlayerAddedNotification, NO_RESPONSE>(UserManagerListener.__Method_OnBlockedPlayerAdded, null, options, request);
			}

			// Token: 0x0600CA6E RID: 51822 RVA: 0x004A988C File Offset: 0x004A7A8C
			public virtual NO_RESPONSE OnBlockedPlayerRemoved(BlockedPlayerRemovedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnBlockedPlayerRemoved(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CA6F RID: 51823 RVA: 0x004A98B4 File Offset: 0x004A7AB4
			public virtual NO_RESPONSE OnBlockedPlayerRemoved(BlockedPlayerRemovedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<BlockedPlayerRemovedNotification, NO_RESPONSE>(UserManagerListener.__Method_OnBlockedPlayerRemoved, null, options, request);
			}

			// Token: 0x0600CA70 RID: 51824 RVA: 0x004A98DC File Offset: 0x004A7ADC
			public virtual AsyncUnaryCall<NO_RESPONSE> OnBlockedPlayerRemovedAsync(BlockedPlayerRemovedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnBlockedPlayerRemovedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CA71 RID: 51825 RVA: 0x004A9904 File Offset: 0x004A7B04
			public virtual AsyncUnaryCall<NO_RESPONSE> OnBlockedPlayerRemovedAsync(BlockedPlayerRemovedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<BlockedPlayerRemovedNotification, NO_RESPONSE>(UserManagerListener.__Method_OnBlockedPlayerRemoved, null, options, request);
			}

			// Token: 0x0600CA72 RID: 51826 RVA: 0x004A992C File Offset: 0x004A7B2C
			public virtual NO_RESPONSE OnRecentPlayersAdded(RecentPlayersAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnRecentPlayersAdded(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CA73 RID: 51827 RVA: 0x004A9954 File Offset: 0x004A7B54
			public virtual NO_RESPONSE OnRecentPlayersAdded(RecentPlayersAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<RecentPlayersAddedNotification, NO_RESPONSE>(UserManagerListener.__Method_OnRecentPlayersAdded, null, options, request);
			}

			// Token: 0x0600CA74 RID: 51828 RVA: 0x004A997C File Offset: 0x004A7B7C
			public virtual AsyncUnaryCall<NO_RESPONSE> OnRecentPlayersAddedAsync(RecentPlayersAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnRecentPlayersAddedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CA75 RID: 51829 RVA: 0x004A99A4 File Offset: 0x004A7BA4
			public virtual AsyncUnaryCall<NO_RESPONSE> OnRecentPlayersAddedAsync(RecentPlayersAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<RecentPlayersAddedNotification, NO_RESPONSE>(UserManagerListener.__Method_OnRecentPlayersAdded, null, options, request);
			}

			// Token: 0x0600CA76 RID: 51830 RVA: 0x004A99CC File Offset: 0x004A7BCC
			public virtual NO_RESPONSE OnRecentPlayersRemoved(RecentPlayersRemovedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnRecentPlayersRemoved(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CA77 RID: 51831 RVA: 0x004A99F4 File Offset: 0x004A7BF4
			public virtual NO_RESPONSE OnRecentPlayersRemoved(RecentPlayersRemovedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<RecentPlayersRemovedNotification, NO_RESPONSE>(UserManagerListener.__Method_OnRecentPlayersRemoved, null, options, request);
			}

			// Token: 0x0600CA78 RID: 51832 RVA: 0x004A9A1C File Offset: 0x004A7C1C
			public virtual AsyncUnaryCall<NO_RESPONSE> OnRecentPlayersRemovedAsync(RecentPlayersRemovedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnRecentPlayersRemovedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CA79 RID: 51833 RVA: 0x004A9A44 File Offset: 0x004A7C44
			public virtual AsyncUnaryCall<NO_RESPONSE> OnRecentPlayersRemovedAsync(RecentPlayersRemovedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<RecentPlayersRemovedNotification, NO_RESPONSE>(UserManagerListener.__Method_OnRecentPlayersRemoved, null, options, request);
			}

			// Token: 0x0600CA7A RID: 51834 RVA: 0x004A9A6C File Offset: 0x004A7C6C
			protected override UserManagerListener.UserManagerListenerClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new UserManagerListener.UserManagerListenerClient(configuration);
			}
		}
	}
}
