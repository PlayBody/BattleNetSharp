using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.RecentPlayers.V1.Client
{
	// Token: 0x02000631 RID: 1585
	public static class RecentPlayersListener
	{
		// Token: 0x060093F0 RID: 37872 RVA: 0x0023D20C File Offset: 0x0023B40C
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

		// Token: 0x060093F1 RID: 37873 RVA: 0x0023D258 File Offset: 0x0023B458
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = RecentPlayersListener.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17002E33 RID: 11827
		// (get) Token: 0x060093F2 RID: 37874 RVA: 0x0023D290 File Offset: 0x0023B490
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return RecentPlayersListenerReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x060093F3 RID: 37875 RVA: 0x0023D2B4 File Offset: 0x0023B4B4
		public static ServerServiceDefinition BindService(RecentPlayersListener.RecentPlayersListenerBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<RecentPlayersAddedNotification, NO_RESPONSE>(RecentPlayersListener.__Method_OnRecentPlayersAdded, new UnaryServerMethod<RecentPlayersAddedNotification, NO_RESPONSE>(serviceImpl.OnRecentPlayersAdded)).AddMethod<RecentPlayersRemovedNotification, NO_RESPONSE>(RecentPlayersListener.__Method_OnRecentPlayersRemoved, new UnaryServerMethod<RecentPlayersRemovedNotification, NO_RESPONSE>(serviceImpl.OnRecentPlayersRemoved))
				.Build();
		}

		// Token: 0x060093F4 RID: 37876 RVA: 0x0023D300 File Offset: 0x0023B500
		public static void BindService(ServiceBinderBase serviceBinder, RecentPlayersListener.RecentPlayersListenerBase serviceImpl)
		{
			serviceBinder.AddMethod<RecentPlayersAddedNotification, NO_RESPONSE>(RecentPlayersListener.__Method_OnRecentPlayersAdded, (serviceImpl == null) ? null : new UnaryServerMethod<RecentPlayersAddedNotification, NO_RESPONSE>(serviceImpl.OnRecentPlayersAdded));
			serviceBinder.AddMethod<RecentPlayersRemovedNotification, NO_RESPONSE>(RecentPlayersListener.__Method_OnRecentPlayersRemoved, (serviceImpl == null) ? null : new UnaryServerMethod<RecentPlayersRemovedNotification, NO_RESPONSE>(serviceImpl.OnRecentPlayersRemoved));
		}

		// Token: 0x040042BF RID: 17087
		private static readonly string __ServiceName = "bgs.protocol.recent_players.v1.client.RecentPlayersListener";

		// Token: 0x040042C0 RID: 17088
		private static readonly Marshaller<RecentPlayersAddedNotification> __Marshaller_bgs_protocol_recent_players_v1_client_RecentPlayersAddedNotification = Marshallers.Create<RecentPlayersAddedNotification>(new Action<RecentPlayersAddedNotification, SerializationContext>(RecentPlayersListener.__Helper_SerializeMessage), (DeserializationContext context) => RecentPlayersListener.__Helper_DeserializeMessage<RecentPlayersAddedNotification>(context, RecentPlayersAddedNotification.Parser));

		// Token: 0x040042C1 RID: 17089
		private static readonly Marshaller<NO_RESPONSE> __Marshaller_bgs_protocol_NO_RESPONSE = Marshallers.Create<NO_RESPONSE>(new Action<NO_RESPONSE, SerializationContext>(RecentPlayersListener.__Helper_SerializeMessage), (DeserializationContext context) => RecentPlayersListener.__Helper_DeserializeMessage<NO_RESPONSE>(context, NO_RESPONSE.Parser));

		// Token: 0x040042C2 RID: 17090
		private static readonly Marshaller<RecentPlayersRemovedNotification> __Marshaller_bgs_protocol_recent_players_v1_client_RecentPlayersRemovedNotification = Marshallers.Create<RecentPlayersRemovedNotification>(new Action<RecentPlayersRemovedNotification, SerializationContext>(RecentPlayersListener.__Helper_SerializeMessage), (DeserializationContext context) => RecentPlayersListener.__Helper_DeserializeMessage<RecentPlayersRemovedNotification>(context, RecentPlayersRemovedNotification.Parser));

		// Token: 0x040042C3 RID: 17091
		private static readonly Method<RecentPlayersAddedNotification, NO_RESPONSE> __Method_OnRecentPlayersAdded = new Method<RecentPlayersAddedNotification, NO_RESPONSE>(0, RecentPlayersListener.__ServiceName, "OnRecentPlayersAdded", RecentPlayersListener.__Marshaller_bgs_protocol_recent_players_v1_client_RecentPlayersAddedNotification, RecentPlayersListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x040042C4 RID: 17092
		private static readonly Method<RecentPlayersRemovedNotification, NO_RESPONSE> __Method_OnRecentPlayersRemoved = new Method<RecentPlayersRemovedNotification, NO_RESPONSE>(0, RecentPlayersListener.__ServiceName, "OnRecentPlayersRemoved", RecentPlayersListener.__Marshaller_bgs_protocol_recent_players_v1_client_RecentPlayersRemovedNotification, RecentPlayersListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x02001126 RID: 4390
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x04009866 RID: 39014
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02001127 RID: 4391
		[BindServiceMethod(typeof(RecentPlayersListener), "BindService")]
		public abstract class RecentPlayersListenerBase
		{
			// Token: 0x0600D5B7 RID: 54711 RVA: 0x004B6117 File Offset: 0x004B4317
			public virtual Task<NO_RESPONSE> OnRecentPlayersAdded(RecentPlayersAddedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D5B8 RID: 54712 RVA: 0x004B612B File Offset: 0x004B432B
			public virtual Task<NO_RESPONSE> OnRecentPlayersRemoved(RecentPlayersRemovedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x02001128 RID: 4392
		public class RecentPlayersListenerClient : ClientBase<RecentPlayersListener.RecentPlayersListenerClient>
		{
			// Token: 0x0600D5BA RID: 54714 RVA: 0x004B6148 File Offset: 0x004B4348
			public RecentPlayersListenerClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D5BB RID: 54715 RVA: 0x004B6153 File Offset: 0x004B4353
			public RecentPlayersListenerClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D5BC RID: 54716 RVA: 0x004B615E File Offset: 0x004B435E
			protected RecentPlayersListenerClient()
			{
			}

			// Token: 0x0600D5BD RID: 54717 RVA: 0x004B6168 File Offset: 0x004B4368
			protected RecentPlayersListenerClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D5BE RID: 54718 RVA: 0x004B6174 File Offset: 0x004B4374
			public virtual NO_RESPONSE OnRecentPlayersAdded(RecentPlayersAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnRecentPlayersAdded(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D5BF RID: 54719 RVA: 0x004B619C File Offset: 0x004B439C
			public virtual NO_RESPONSE OnRecentPlayersAdded(RecentPlayersAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<RecentPlayersAddedNotification, NO_RESPONSE>(RecentPlayersListener.__Method_OnRecentPlayersAdded, null, options, request);
			}

			// Token: 0x0600D5C0 RID: 54720 RVA: 0x004B61C4 File Offset: 0x004B43C4
			public virtual AsyncUnaryCall<NO_RESPONSE> OnRecentPlayersAddedAsync(RecentPlayersAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnRecentPlayersAddedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D5C1 RID: 54721 RVA: 0x004B61EC File Offset: 0x004B43EC
			public virtual AsyncUnaryCall<NO_RESPONSE> OnRecentPlayersAddedAsync(RecentPlayersAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<RecentPlayersAddedNotification, NO_RESPONSE>(RecentPlayersListener.__Method_OnRecentPlayersAdded, null, options, request);
			}

			// Token: 0x0600D5C2 RID: 54722 RVA: 0x004B6214 File Offset: 0x004B4414
			public virtual NO_RESPONSE OnRecentPlayersRemoved(RecentPlayersRemovedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnRecentPlayersRemoved(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D5C3 RID: 54723 RVA: 0x004B623C File Offset: 0x004B443C
			public virtual NO_RESPONSE OnRecentPlayersRemoved(RecentPlayersRemovedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<RecentPlayersRemovedNotification, NO_RESPONSE>(RecentPlayersListener.__Method_OnRecentPlayersRemoved, null, options, request);
			}

			// Token: 0x0600D5C4 RID: 54724 RVA: 0x004B6264 File Offset: 0x004B4464
			public virtual AsyncUnaryCall<NO_RESPONSE> OnRecentPlayersRemovedAsync(RecentPlayersRemovedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnRecentPlayersRemovedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D5C5 RID: 54725 RVA: 0x004B628C File Offset: 0x004B448C
			public virtual AsyncUnaryCall<NO_RESPONSE> OnRecentPlayersRemovedAsync(RecentPlayersRemovedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<RecentPlayersRemovedNotification, NO_RESPONSE>(RecentPlayersListener.__Method_OnRecentPlayersRemoved, null, options, request);
			}

			// Token: 0x0600D5C6 RID: 54726 RVA: 0x004B62B4 File Offset: 0x004B44B4
			protected override RecentPlayersListener.RecentPlayersListenerClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new RecentPlayersListener.RecentPlayersListenerClient(configuration);
			}
		}
	}
}
