using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Matchmaking.V1
{
	// Token: 0x02000400 RID: 1024
	public static class GameRequestListener
	{
		// Token: 0x0600657C RID: 25980 RVA: 0x001884FC File Offset: 0x001866FC
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

		// Token: 0x0600657D RID: 25981 RVA: 0x00188548 File Offset: 0x00186748
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = GameRequestListener.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17002090 RID: 8336
		// (get) Token: 0x0600657E RID: 25982 RVA: 0x00188580 File Offset: 0x00186780
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return GameRequestServiceReflection.Descriptor.Services[1];
			}
		}

		// Token: 0x0600657F RID: 25983 RVA: 0x001885A4 File Offset: 0x001867A4
		public static ServerServiceDefinition BindService(GameRequestListener.GameRequestListenerBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<QueueEntryNotification, NO_RESPONSE>(GameRequestListener.__Method_OnQueueEntry, new UnaryServerMethod<QueueEntryNotification, NO_RESPONSE>(serviceImpl.OnQueueEntry)).AddMethod<QueueExitNotification, NO_RESPONSE>(GameRequestListener.__Method_OnQueueExit, new UnaryServerMethod<QueueExitNotification, NO_RESPONSE>(serviceImpl.OnQueueExit))
				.AddMethod<QueueLeftNotification, NO_RESPONSE>(GameRequestListener.__Method_OnQueueLeft, new UnaryServerMethod<QueueLeftNotification, NO_RESPONSE>(serviceImpl.OnQueueLeft))
				.AddMethod<QueueUpdateNotification, NO_RESPONSE>(GameRequestListener.__Method_OnQueueUpdate, new UnaryServerMethod<QueueUpdateNotification, NO_RESPONSE>(serviceImpl.OnQueueUpdate))
				.AddMethod<MatchmakingResultNotification, NO_RESPONSE>(GameRequestListener.__Method_OnMatchmakingResult, new UnaryServerMethod<MatchmakingResultNotification, NO_RESPONSE>(serviceImpl.OnMatchmakingResult))
				.Build();
		}

		// Token: 0x06006580 RID: 25984 RVA: 0x00188634 File Offset: 0x00186834
		public static void BindService(ServiceBinderBase serviceBinder, GameRequestListener.GameRequestListenerBase serviceImpl)
		{
			serviceBinder.AddMethod<QueueEntryNotification, NO_RESPONSE>(GameRequestListener.__Method_OnQueueEntry, (serviceImpl == null) ? null : new UnaryServerMethod<QueueEntryNotification, NO_RESPONSE>(serviceImpl.OnQueueEntry));
			serviceBinder.AddMethod<QueueExitNotification, NO_RESPONSE>(GameRequestListener.__Method_OnQueueExit, (serviceImpl == null) ? null : new UnaryServerMethod<QueueExitNotification, NO_RESPONSE>(serviceImpl.OnQueueExit));
			serviceBinder.AddMethod<QueueLeftNotification, NO_RESPONSE>(GameRequestListener.__Method_OnQueueLeft, (serviceImpl == null) ? null : new UnaryServerMethod<QueueLeftNotification, NO_RESPONSE>(serviceImpl.OnQueueLeft));
			serviceBinder.AddMethod<QueueUpdateNotification, NO_RESPONSE>(GameRequestListener.__Method_OnQueueUpdate, (serviceImpl == null) ? null : new UnaryServerMethod<QueueUpdateNotification, NO_RESPONSE>(serviceImpl.OnQueueUpdate));
			serviceBinder.AddMethod<MatchmakingResultNotification, NO_RESPONSE>(GameRequestListener.__Method_OnMatchmakingResult, (serviceImpl == null) ? null : new UnaryServerMethod<MatchmakingResultNotification, NO_RESPONSE>(serviceImpl.OnMatchmakingResult));
		}

		// Token: 0x04002E29 RID: 11817
		private static readonly string __ServiceName = "bgs.protocol.matchmaking.v1.GameRequestListener";

		// Token: 0x04002E2A RID: 11818
		private static readonly Marshaller<QueueEntryNotification> __Marshaller_bgs_protocol_matchmaking_v1_QueueEntryNotification = Marshallers.Create<QueueEntryNotification>(new Action<QueueEntryNotification, SerializationContext>(GameRequestListener.__Helper_SerializeMessage), (DeserializationContext context) => GameRequestListener.__Helper_DeserializeMessage<QueueEntryNotification>(context, QueueEntryNotification.Parser));

		// Token: 0x04002E2B RID: 11819
		private static readonly Marshaller<NO_RESPONSE> __Marshaller_bgs_protocol_NO_RESPONSE = Marshallers.Create<NO_RESPONSE>(new Action<NO_RESPONSE, SerializationContext>(GameRequestListener.__Helper_SerializeMessage), (DeserializationContext context) => GameRequestListener.__Helper_DeserializeMessage<NO_RESPONSE>(context, NO_RESPONSE.Parser));

		// Token: 0x04002E2C RID: 11820
		private static readonly Marshaller<QueueExitNotification> __Marshaller_bgs_protocol_matchmaking_v1_QueueExitNotification = Marshallers.Create<QueueExitNotification>(new Action<QueueExitNotification, SerializationContext>(GameRequestListener.__Helper_SerializeMessage), (DeserializationContext context) => GameRequestListener.__Helper_DeserializeMessage<QueueExitNotification>(context, QueueExitNotification.Parser));

		// Token: 0x04002E2D RID: 11821
		private static readonly Marshaller<QueueLeftNotification> __Marshaller_bgs_protocol_matchmaking_v1_QueueLeftNotification = Marshallers.Create<QueueLeftNotification>(new Action<QueueLeftNotification, SerializationContext>(GameRequestListener.__Helper_SerializeMessage), (DeserializationContext context) => GameRequestListener.__Helper_DeserializeMessage<QueueLeftNotification>(context, QueueLeftNotification.Parser));

		// Token: 0x04002E2E RID: 11822
		private static readonly Marshaller<QueueUpdateNotification> __Marshaller_bgs_protocol_matchmaking_v1_QueueUpdateNotification = Marshallers.Create<QueueUpdateNotification>(new Action<QueueUpdateNotification, SerializationContext>(GameRequestListener.__Helper_SerializeMessage), (DeserializationContext context) => GameRequestListener.__Helper_DeserializeMessage<QueueUpdateNotification>(context, QueueUpdateNotification.Parser));

		// Token: 0x04002E2F RID: 11823
		private static readonly Marshaller<MatchmakingResultNotification> __Marshaller_bgs_protocol_matchmaking_v1_MatchmakingResultNotification = Marshallers.Create<MatchmakingResultNotification>(new Action<MatchmakingResultNotification, SerializationContext>(GameRequestListener.__Helper_SerializeMessage), (DeserializationContext context) => GameRequestListener.__Helper_DeserializeMessage<MatchmakingResultNotification>(context, MatchmakingResultNotification.Parser));

		// Token: 0x04002E30 RID: 11824
		private static readonly Method<QueueEntryNotification, NO_RESPONSE> __Method_OnQueueEntry = new Method<QueueEntryNotification, NO_RESPONSE>(0, GameRequestListener.__ServiceName, "OnQueueEntry", GameRequestListener.__Marshaller_bgs_protocol_matchmaking_v1_QueueEntryNotification, GameRequestListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04002E31 RID: 11825
		private static readonly Method<QueueExitNotification, NO_RESPONSE> __Method_OnQueueExit = new Method<QueueExitNotification, NO_RESPONSE>(0, GameRequestListener.__ServiceName, "OnQueueExit", GameRequestListener.__Marshaller_bgs_protocol_matchmaking_v1_QueueExitNotification, GameRequestListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04002E32 RID: 11826
		private static readonly Method<QueueLeftNotification, NO_RESPONSE> __Method_OnQueueLeft = new Method<QueueLeftNotification, NO_RESPONSE>(0, GameRequestListener.__ServiceName, "OnQueueLeft", GameRequestListener.__Marshaller_bgs_protocol_matchmaking_v1_QueueLeftNotification, GameRequestListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04002E33 RID: 11827
		private static readonly Method<QueueUpdateNotification, NO_RESPONSE> __Method_OnQueueUpdate = new Method<QueueUpdateNotification, NO_RESPONSE>(0, GameRequestListener.__ServiceName, "OnQueueUpdate", GameRequestListener.__Marshaller_bgs_protocol_matchmaking_v1_QueueUpdateNotification, GameRequestListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04002E34 RID: 11828
		private static readonly Method<MatchmakingResultNotification, NO_RESPONSE> __Method_OnMatchmakingResult = new Method<MatchmakingResultNotification, NO_RESPONSE>(0, GameRequestListener.__ServiceName, "OnMatchmakingResult", GameRequestListener.__Marshaller_bgs_protocol_matchmaking_v1_MatchmakingResultNotification, GameRequestListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x02000ED8 RID: 3800
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x04009639 RID: 38457
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02000ED9 RID: 3801
		[BindServiceMethod(typeof(GameRequestListener), "BindService")]
		public abstract class GameRequestListenerBase
		{
			// Token: 0x0600CB9F RID: 52127 RVA: 0x004AAD44 File Offset: 0x004A8F44
			public virtual Task<NO_RESPONSE> OnQueueEntry(QueueEntryNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CBA0 RID: 52128 RVA: 0x004AAD58 File Offset: 0x004A8F58
			public virtual Task<NO_RESPONSE> OnQueueExit(QueueExitNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CBA1 RID: 52129 RVA: 0x004AAD6C File Offset: 0x004A8F6C
			public virtual Task<NO_RESPONSE> OnQueueLeft(QueueLeftNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CBA2 RID: 52130 RVA: 0x004AAD80 File Offset: 0x004A8F80
			public virtual Task<NO_RESPONSE> OnQueueUpdate(QueueUpdateNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CBA3 RID: 52131 RVA: 0x004AAD94 File Offset: 0x004A8F94
			public virtual Task<NO_RESPONSE> OnMatchmakingResult(MatchmakingResultNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x02000EDA RID: 3802
		public class GameRequestListenerClient : ClientBase<GameRequestListener.GameRequestListenerClient>
		{
			// Token: 0x0600CBA5 RID: 52133 RVA: 0x004AADB1 File Offset: 0x004A8FB1
			public GameRequestListenerClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600CBA6 RID: 52134 RVA: 0x004AADBC File Offset: 0x004A8FBC
			public GameRequestListenerClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600CBA7 RID: 52135 RVA: 0x004AADC7 File Offset: 0x004A8FC7
			protected GameRequestListenerClient()
			{
			}

			// Token: 0x0600CBA8 RID: 52136 RVA: 0x004AADD1 File Offset: 0x004A8FD1
			protected GameRequestListenerClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600CBA9 RID: 52137 RVA: 0x004AADDC File Offset: 0x004A8FDC
			public virtual NO_RESPONSE OnQueueEntry(QueueEntryNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnQueueEntry(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CBAA RID: 52138 RVA: 0x004AAE04 File Offset: 0x004A9004
			public virtual NO_RESPONSE OnQueueEntry(QueueEntryNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<QueueEntryNotification, NO_RESPONSE>(GameRequestListener.__Method_OnQueueEntry, null, options, request);
			}

			// Token: 0x0600CBAB RID: 52139 RVA: 0x004AAE2C File Offset: 0x004A902C
			public virtual AsyncUnaryCall<NO_RESPONSE> OnQueueEntryAsync(QueueEntryNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnQueueEntryAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CBAC RID: 52140 RVA: 0x004AAE54 File Offset: 0x004A9054
			public virtual AsyncUnaryCall<NO_RESPONSE> OnQueueEntryAsync(QueueEntryNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<QueueEntryNotification, NO_RESPONSE>(GameRequestListener.__Method_OnQueueEntry, null, options, request);
			}

			// Token: 0x0600CBAD RID: 52141 RVA: 0x004AAE7C File Offset: 0x004A907C
			public virtual NO_RESPONSE OnQueueExit(QueueExitNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnQueueExit(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CBAE RID: 52142 RVA: 0x004AAEA4 File Offset: 0x004A90A4
			public virtual NO_RESPONSE OnQueueExit(QueueExitNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<QueueExitNotification, NO_RESPONSE>(GameRequestListener.__Method_OnQueueExit, null, options, request);
			}

			// Token: 0x0600CBAF RID: 52143 RVA: 0x004AAECC File Offset: 0x004A90CC
			public virtual AsyncUnaryCall<NO_RESPONSE> OnQueueExitAsync(QueueExitNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnQueueExitAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CBB0 RID: 52144 RVA: 0x004AAEF4 File Offset: 0x004A90F4
			public virtual AsyncUnaryCall<NO_RESPONSE> OnQueueExitAsync(QueueExitNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<QueueExitNotification, NO_RESPONSE>(GameRequestListener.__Method_OnQueueExit, null, options, request);
			}

			// Token: 0x0600CBB1 RID: 52145 RVA: 0x004AAF1C File Offset: 0x004A911C
			public virtual NO_RESPONSE OnQueueLeft(QueueLeftNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnQueueLeft(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CBB2 RID: 52146 RVA: 0x004AAF44 File Offset: 0x004A9144
			public virtual NO_RESPONSE OnQueueLeft(QueueLeftNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<QueueLeftNotification, NO_RESPONSE>(GameRequestListener.__Method_OnQueueLeft, null, options, request);
			}

			// Token: 0x0600CBB3 RID: 52147 RVA: 0x004AAF6C File Offset: 0x004A916C
			public virtual AsyncUnaryCall<NO_RESPONSE> OnQueueLeftAsync(QueueLeftNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnQueueLeftAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CBB4 RID: 52148 RVA: 0x004AAF94 File Offset: 0x004A9194
			public virtual AsyncUnaryCall<NO_RESPONSE> OnQueueLeftAsync(QueueLeftNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<QueueLeftNotification, NO_RESPONSE>(GameRequestListener.__Method_OnQueueLeft, null, options, request);
			}

			// Token: 0x0600CBB5 RID: 52149 RVA: 0x004AAFBC File Offset: 0x004A91BC
			public virtual NO_RESPONSE OnQueueUpdate(QueueUpdateNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnQueueUpdate(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CBB6 RID: 52150 RVA: 0x004AAFE4 File Offset: 0x004A91E4
			public virtual NO_RESPONSE OnQueueUpdate(QueueUpdateNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<QueueUpdateNotification, NO_RESPONSE>(GameRequestListener.__Method_OnQueueUpdate, null, options, request);
			}

			// Token: 0x0600CBB7 RID: 52151 RVA: 0x004AB00C File Offset: 0x004A920C
			public virtual AsyncUnaryCall<NO_RESPONSE> OnQueueUpdateAsync(QueueUpdateNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnQueueUpdateAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CBB8 RID: 52152 RVA: 0x004AB034 File Offset: 0x004A9234
			public virtual AsyncUnaryCall<NO_RESPONSE> OnQueueUpdateAsync(QueueUpdateNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<QueueUpdateNotification, NO_RESPONSE>(GameRequestListener.__Method_OnQueueUpdate, null, options, request);
			}

			// Token: 0x0600CBB9 RID: 52153 RVA: 0x004AB05C File Offset: 0x004A925C
			public virtual NO_RESPONSE OnMatchmakingResult(MatchmakingResultNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnMatchmakingResult(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CBBA RID: 52154 RVA: 0x004AB084 File Offset: 0x004A9284
			public virtual NO_RESPONSE OnMatchmakingResult(MatchmakingResultNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<MatchmakingResultNotification, NO_RESPONSE>(GameRequestListener.__Method_OnMatchmakingResult, null, options, request);
			}

			// Token: 0x0600CBBB RID: 52155 RVA: 0x004AB0AC File Offset: 0x004A92AC
			public virtual AsyncUnaryCall<NO_RESPONSE> OnMatchmakingResultAsync(MatchmakingResultNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnMatchmakingResultAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CBBC RID: 52156 RVA: 0x004AB0D4 File Offset: 0x004A92D4
			public virtual AsyncUnaryCall<NO_RESPONSE> OnMatchmakingResultAsync(MatchmakingResultNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<MatchmakingResultNotification, NO_RESPONSE>(GameRequestListener.__Method_OnMatchmakingResult, null, options, request);
			}

			// Token: 0x0600CBBD RID: 52157 RVA: 0x004AB0FC File Offset: 0x004A92FC
			protected override GameRequestListener.GameRequestListenerClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new GameRequestListener.GameRequestListenerClient(configuration);
			}
		}
	}
}
