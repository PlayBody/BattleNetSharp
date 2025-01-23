using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Matchmaking.V1
{
	// Token: 0x020003FF RID: 1023
	public static class GameRequestService
	{
		// Token: 0x06006576 RID: 25974 RVA: 0x0018822C File Offset: 0x0018642C
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

		// Token: 0x06006577 RID: 25975 RVA: 0x00188278 File Offset: 0x00186478
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = GameRequestService.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x1700208F RID: 8335
		// (get) Token: 0x06006578 RID: 25976 RVA: 0x001882B0 File Offset: 0x001864B0
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return GameRequestServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x06006579 RID: 25977 RVA: 0x001882D4 File Offset: 0x001864D4
		public static ServerServiceDefinition BindService(GameRequestService.GameRequestServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<QueueMatchmakingRequest, QueueMatchmakingResponse>(GameRequestService.__Method_QueueMatchmaking, new UnaryServerMethod<QueueMatchmakingRequest, QueueMatchmakingResponse>(serviceImpl.QueueMatchmaking)).AddMethod<JoinGameRequest, JoinGameResponse>(GameRequestService.__Method_JoinGame, new UnaryServerMethod<JoinGameRequest, JoinGameResponse>(serviceImpl.JoinGame))
				.AddMethod<CancelMatchmakingRequest, NoData>(GameRequestService.__Method_CancelMatchmaking, new UnaryServerMethod<CancelMatchmakingRequest, NoData>(serviceImpl.CancelMatchmaking))
				.Build();
		}

		// Token: 0x0600657A RID: 25978 RVA: 0x00188338 File Offset: 0x00186538
		public static void BindService(ServiceBinderBase serviceBinder, GameRequestService.GameRequestServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<QueueMatchmakingRequest, QueueMatchmakingResponse>(GameRequestService.__Method_QueueMatchmaking, (serviceImpl == null) ? null : new UnaryServerMethod<QueueMatchmakingRequest, QueueMatchmakingResponse>(serviceImpl.QueueMatchmaking));
			serviceBinder.AddMethod<JoinGameRequest, JoinGameResponse>(GameRequestService.__Method_JoinGame, (serviceImpl == null) ? null : new UnaryServerMethod<JoinGameRequest, JoinGameResponse>(serviceImpl.JoinGame));
			serviceBinder.AddMethod<CancelMatchmakingRequest, NoData>(GameRequestService.__Method_CancelMatchmaking, (serviceImpl == null) ? null : new UnaryServerMethod<CancelMatchmakingRequest, NoData>(serviceImpl.CancelMatchmaking));
		}

		// Token: 0x04002E1F RID: 11807
		private static readonly string __ServiceName = "bgs.protocol.matchmaking.v1.GameRequestService";

		// Token: 0x04002E20 RID: 11808
		private static readonly Marshaller<QueueMatchmakingRequest> __Marshaller_bgs_protocol_matchmaking_v1_QueueMatchmakingRequest = Marshallers.Create<QueueMatchmakingRequest>(new Action<QueueMatchmakingRequest, SerializationContext>(GameRequestService.__Helper_SerializeMessage), (DeserializationContext context) => GameRequestService.__Helper_DeserializeMessage<QueueMatchmakingRequest>(context, QueueMatchmakingRequest.Parser));

		// Token: 0x04002E21 RID: 11809
		private static readonly Marshaller<QueueMatchmakingResponse> __Marshaller_bgs_protocol_matchmaking_v1_QueueMatchmakingResponse = Marshallers.Create<QueueMatchmakingResponse>(new Action<QueueMatchmakingResponse, SerializationContext>(GameRequestService.__Helper_SerializeMessage), (DeserializationContext context) => GameRequestService.__Helper_DeserializeMessage<QueueMatchmakingResponse>(context, QueueMatchmakingResponse.Parser));

		// Token: 0x04002E22 RID: 11810
		private static readonly Marshaller<JoinGameRequest> __Marshaller_bgs_protocol_matchmaking_v1_JoinGameRequest = Marshallers.Create<JoinGameRequest>(new Action<JoinGameRequest, SerializationContext>(GameRequestService.__Helper_SerializeMessage), (DeserializationContext context) => GameRequestService.__Helper_DeserializeMessage<JoinGameRequest>(context, JoinGameRequest.Parser));

		// Token: 0x04002E23 RID: 11811
		private static readonly Marshaller<JoinGameResponse> __Marshaller_bgs_protocol_matchmaking_v1_JoinGameResponse = Marshallers.Create<JoinGameResponse>(new Action<JoinGameResponse, SerializationContext>(GameRequestService.__Helper_SerializeMessage), (DeserializationContext context) => GameRequestService.__Helper_DeserializeMessage<JoinGameResponse>(context, JoinGameResponse.Parser));

		// Token: 0x04002E24 RID: 11812
		private static readonly Marshaller<CancelMatchmakingRequest> __Marshaller_bgs_protocol_matchmaking_v1_CancelMatchmakingRequest = Marshallers.Create<CancelMatchmakingRequest>(new Action<CancelMatchmakingRequest, SerializationContext>(GameRequestService.__Helper_SerializeMessage), (DeserializationContext context) => GameRequestService.__Helper_DeserializeMessage<CancelMatchmakingRequest>(context, CancelMatchmakingRequest.Parser));

		// Token: 0x04002E25 RID: 11813
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(GameRequestService.__Helper_SerializeMessage), (DeserializationContext context) => GameRequestService.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x04002E26 RID: 11814
		private static readonly Method<QueueMatchmakingRequest, QueueMatchmakingResponse> __Method_QueueMatchmaking = new Method<QueueMatchmakingRequest, QueueMatchmakingResponse>(0, GameRequestService.__ServiceName, "QueueMatchmaking", GameRequestService.__Marshaller_bgs_protocol_matchmaking_v1_QueueMatchmakingRequest, GameRequestService.__Marshaller_bgs_protocol_matchmaking_v1_QueueMatchmakingResponse);

		// Token: 0x04002E27 RID: 11815
		private static readonly Method<JoinGameRequest, JoinGameResponse> __Method_JoinGame = new Method<JoinGameRequest, JoinGameResponse>(0, GameRequestService.__ServiceName, "JoinGame", GameRequestService.__Marshaller_bgs_protocol_matchmaking_v1_JoinGameRequest, GameRequestService.__Marshaller_bgs_protocol_matchmaking_v1_JoinGameResponse);

		// Token: 0x04002E28 RID: 11816
		private static readonly Method<CancelMatchmakingRequest, NoData> __Method_CancelMatchmaking = new Method<CancelMatchmakingRequest, NoData>(0, GameRequestService.__ServiceName, "CancelMatchmaking", GameRequestService.__Marshaller_bgs_protocol_matchmaking_v1_CancelMatchmakingRequest, GameRequestService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x02000ED4 RID: 3796
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x04009637 RID: 38455
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02000ED5 RID: 3797
		[BindServiceMethod(typeof(GameRequestService), "BindService")]
		public abstract class GameRequestServiceBase
		{
			// Token: 0x0600CB81 RID: 52097 RVA: 0x004AAA52 File Offset: 0x004A8C52
			public virtual Task<QueueMatchmakingResponse> QueueMatchmaking(QueueMatchmakingRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CB82 RID: 52098 RVA: 0x004AAA66 File Offset: 0x004A8C66
			public virtual Task<JoinGameResponse> JoinGame(JoinGameRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CB83 RID: 52099 RVA: 0x004AAA7A File Offset: 0x004A8C7A
			public virtual Task<NoData> CancelMatchmaking(CancelMatchmakingRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x02000ED6 RID: 3798
		public class GameRequestServiceClient : ClientBase<GameRequestService.GameRequestServiceClient>
		{
			// Token: 0x0600CB85 RID: 52101 RVA: 0x004AAA97 File Offset: 0x004A8C97
			public GameRequestServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600CB86 RID: 52102 RVA: 0x004AAAA2 File Offset: 0x004A8CA2
			public GameRequestServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600CB87 RID: 52103 RVA: 0x004AAAAD File Offset: 0x004A8CAD
			protected GameRequestServiceClient()
			{
			}

			// Token: 0x0600CB88 RID: 52104 RVA: 0x004AAAB7 File Offset: 0x004A8CB7
			protected GameRequestServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600CB89 RID: 52105 RVA: 0x004AAAC4 File Offset: 0x004A8CC4
			public virtual QueueMatchmakingResponse QueueMatchmaking(QueueMatchmakingRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.QueueMatchmaking(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CB8A RID: 52106 RVA: 0x004AAAEC File Offset: 0x004A8CEC
			public virtual QueueMatchmakingResponse QueueMatchmaking(QueueMatchmakingRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<QueueMatchmakingRequest, QueueMatchmakingResponse>(GameRequestService.__Method_QueueMatchmaking, null, options, request);
			}

			// Token: 0x0600CB8B RID: 52107 RVA: 0x004AAB14 File Offset: 0x004A8D14
			public virtual AsyncUnaryCall<QueueMatchmakingResponse> QueueMatchmakingAsync(QueueMatchmakingRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.QueueMatchmakingAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CB8C RID: 52108 RVA: 0x004AAB3C File Offset: 0x004A8D3C
			public virtual AsyncUnaryCall<QueueMatchmakingResponse> QueueMatchmakingAsync(QueueMatchmakingRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<QueueMatchmakingRequest, QueueMatchmakingResponse>(GameRequestService.__Method_QueueMatchmaking, null, options, request);
			}

			// Token: 0x0600CB8D RID: 52109 RVA: 0x004AAB64 File Offset: 0x004A8D64
			public virtual JoinGameResponse JoinGame(JoinGameRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.JoinGame(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CB8E RID: 52110 RVA: 0x004AAB8C File Offset: 0x004A8D8C
			public virtual JoinGameResponse JoinGame(JoinGameRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<JoinGameRequest, JoinGameResponse>(GameRequestService.__Method_JoinGame, null, options, request);
			}

			// Token: 0x0600CB8F RID: 52111 RVA: 0x004AABB4 File Offset: 0x004A8DB4
			public virtual AsyncUnaryCall<JoinGameResponse> JoinGameAsync(JoinGameRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.JoinGameAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CB90 RID: 52112 RVA: 0x004AABDC File Offset: 0x004A8DDC
			public virtual AsyncUnaryCall<JoinGameResponse> JoinGameAsync(JoinGameRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<JoinGameRequest, JoinGameResponse>(GameRequestService.__Method_JoinGame, null, options, request);
			}

			// Token: 0x0600CB91 RID: 52113 RVA: 0x004AAC04 File Offset: 0x004A8E04
			public virtual NoData CancelMatchmaking(CancelMatchmakingRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.CancelMatchmaking(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CB92 RID: 52114 RVA: 0x004AAC2C File Offset: 0x004A8E2C
			public virtual NoData CancelMatchmaking(CancelMatchmakingRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<CancelMatchmakingRequest, NoData>(GameRequestService.__Method_CancelMatchmaking, null, options, request);
			}

			// Token: 0x0600CB93 RID: 52115 RVA: 0x004AAC54 File Offset: 0x004A8E54
			public virtual AsyncUnaryCall<NoData> CancelMatchmakingAsync(CancelMatchmakingRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.CancelMatchmakingAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CB94 RID: 52116 RVA: 0x004AAC7C File Offset: 0x004A8E7C
			public virtual AsyncUnaryCall<NoData> CancelMatchmakingAsync(CancelMatchmakingRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<CancelMatchmakingRequest, NoData>(GameRequestService.__Method_CancelMatchmaking, null, options, request);
			}

			// Token: 0x0600CB95 RID: 52117 RVA: 0x004AACA4 File Offset: 0x004A8EA4
			protected override GameRequestService.GameRequestServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new GameRequestService.GameRequestServiceClient(configuration);
			}
		}
	}
}
