using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Bgs.Protocol;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Classic.Protocol.External.V1.GameManagement
{
	// Token: 0x0200079C RID: 1948
	public static class GameManagement
	{
		// Token: 0x0600B327 RID: 45863 RVA: 0x002B94A4 File Offset: 0x002B76A4
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

		// Token: 0x0600B328 RID: 45864 RVA: 0x002B94F0 File Offset: 0x002B76F0
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = GameManagement.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x1700377A RID: 14202
		// (get) Token: 0x0600B329 RID: 45865 RVA: 0x002B9528 File Offset: 0x002B7728
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return GameManagementReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x0600B32A RID: 45866 RVA: 0x002B954C File Offset: 0x002B774C
		public static ServerServiceDefinition BindService(GameManagement.GameManagementBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<GameCreateRequest, GameCreateResponse>(GameManagement.__Method_GameCreate, new UnaryServerMethod<GameCreateRequest, GameCreateResponse>(serviceImpl.GameCreate)).AddMethod<GameJoinRequest, GameJoinResponse>(GameManagement.__Method_GameJoin, new UnaryServerMethod<GameJoinRequest, GameJoinResponse>(serviceImpl.GameJoin))
				.AddMethod<GameListRequest, GameListResponse>(GameManagement.__Method_GameList, new UnaryServerMethod<GameListRequest, GameListResponse>(serviceImpl.GameList))
				.AddMethod<GameDetailRequest, GameDetailResponse>(GameManagement.__Method_GameDetail, new UnaryServerMethod<GameDetailRequest, GameDetailResponse>(serviceImpl.GameDetail))
				.AddMethod<GameMgmtRequest, GameMgmtResponse>(GameManagement.__Method_GameCreateCancel, new UnaryServerMethod<GameMgmtRequest, GameMgmtResponse>(serviceImpl.GameCreateCancel))
				.AddMethod<GameMgmtRequest, GameMgmtResponse>(GameManagement.__Method_GameCreateQueueTime, new UnaryServerMethod<GameMgmtRequest, GameMgmtResponse>(serviceImpl.GameCreateQueueTime))
				.AddMethod<GameMgmtRequest, GameMgmtResponse>(GameManagement.__Method_GameMatchmake, new UnaryServerMethod<GameMgmtRequest, GameMgmtResponse>(serviceImpl.GameMatchmake))
				.AddMethod<NoData, GameGetSitePingListResponse>(GameManagement.__Method_GameGetSitePingList, new UnaryServerMethod<NoData, GameGetSitePingListResponse>(serviceImpl.GameGetSitePingList))
				.Build();
		}

		// Token: 0x0600B32B RID: 45867 RVA: 0x002B9620 File Offset: 0x002B7820
		public static void BindService(ServiceBinderBase serviceBinder, GameManagement.GameManagementBase serviceImpl)
		{
			serviceBinder.AddMethod<GameCreateRequest, GameCreateResponse>(GameManagement.__Method_GameCreate, (serviceImpl == null) ? null : new UnaryServerMethod<GameCreateRequest, GameCreateResponse>(serviceImpl.GameCreate));
			serviceBinder.AddMethod<GameJoinRequest, GameJoinResponse>(GameManagement.__Method_GameJoin, (serviceImpl == null) ? null : new UnaryServerMethod<GameJoinRequest, GameJoinResponse>(serviceImpl.GameJoin));
			serviceBinder.AddMethod<GameListRequest, GameListResponse>(GameManagement.__Method_GameList, (serviceImpl == null) ? null : new UnaryServerMethod<GameListRequest, GameListResponse>(serviceImpl.GameList));
			serviceBinder.AddMethod<GameDetailRequest, GameDetailResponse>(GameManagement.__Method_GameDetail, (serviceImpl == null) ? null : new UnaryServerMethod<GameDetailRequest, GameDetailResponse>(serviceImpl.GameDetail));
			serviceBinder.AddMethod<GameMgmtRequest, GameMgmtResponse>(GameManagement.__Method_GameCreateCancel, (serviceImpl == null) ? null : new UnaryServerMethod<GameMgmtRequest, GameMgmtResponse>(serviceImpl.GameCreateCancel));
			serviceBinder.AddMethod<GameMgmtRequest, GameMgmtResponse>(GameManagement.__Method_GameCreateQueueTime, (serviceImpl == null) ? null : new UnaryServerMethod<GameMgmtRequest, GameMgmtResponse>(serviceImpl.GameCreateQueueTime));
			serviceBinder.AddMethod<GameMgmtRequest, GameMgmtResponse>(GameManagement.__Method_GameMatchmake, (serviceImpl == null) ? null : new UnaryServerMethod<GameMgmtRequest, GameMgmtResponse>(serviceImpl.GameMatchmake));
			serviceBinder.AddMethod<NoData, GameGetSitePingListResponse>(GameManagement.__Method_GameGetSitePingList, (serviceImpl == null) ? null : new UnaryServerMethod<NoData, GameGetSitePingListResponse>(serviceImpl.GameGetSitePingList));
		}

		// Token: 0x040050E2 RID: 20706
		private static readonly string __ServiceName = "classic.protocol.external.v1.game_management.GameManagement";

		// Token: 0x040050E3 RID: 20707
		private static readonly Marshaller<GameCreateRequest> __Marshaller_classic_protocol_external_v1_game_management_GameCreateRequest = Marshallers.Create<GameCreateRequest>(new Action<GameCreateRequest, SerializationContext>(GameManagement.__Helper_SerializeMessage), (DeserializationContext context) => GameManagement.__Helper_DeserializeMessage<GameCreateRequest>(context, GameCreateRequest.Parser));

		// Token: 0x040050E4 RID: 20708
		private static readonly Marshaller<GameCreateResponse> __Marshaller_classic_protocol_external_v1_game_management_GameCreateResponse = Marshallers.Create<GameCreateResponse>(new Action<GameCreateResponse, SerializationContext>(GameManagement.__Helper_SerializeMessage), (DeserializationContext context) => GameManagement.__Helper_DeserializeMessage<GameCreateResponse>(context, GameCreateResponse.Parser));

		// Token: 0x040050E5 RID: 20709
		private static readonly Marshaller<GameJoinRequest> __Marshaller_classic_protocol_external_v1_game_management_GameJoinRequest = Marshallers.Create<GameJoinRequest>(new Action<GameJoinRequest, SerializationContext>(GameManagement.__Helper_SerializeMessage), (DeserializationContext context) => GameManagement.__Helper_DeserializeMessage<GameJoinRequest>(context, GameJoinRequest.Parser));

		// Token: 0x040050E6 RID: 20710
		private static readonly Marshaller<GameJoinResponse> __Marshaller_classic_protocol_external_v1_game_management_GameJoinResponse = Marshallers.Create<GameJoinResponse>(new Action<GameJoinResponse, SerializationContext>(GameManagement.__Helper_SerializeMessage), (DeserializationContext context) => GameManagement.__Helper_DeserializeMessage<GameJoinResponse>(context, GameJoinResponse.Parser));

		// Token: 0x040050E7 RID: 20711
		private static readonly Marshaller<GameListRequest> __Marshaller_classic_protocol_external_v1_game_management_GameListRequest = Marshallers.Create<GameListRequest>(new Action<GameListRequest, SerializationContext>(GameManagement.__Helper_SerializeMessage), (DeserializationContext context) => GameManagement.__Helper_DeserializeMessage<GameListRequest>(context, GameListRequest.Parser));

		// Token: 0x040050E8 RID: 20712
		private static readonly Marshaller<GameListResponse> __Marshaller_classic_protocol_external_v1_game_management_GameListResponse = Marshallers.Create<GameListResponse>(new Action<GameListResponse, SerializationContext>(GameManagement.__Helper_SerializeMessage), (DeserializationContext context) => GameManagement.__Helper_DeserializeMessage<GameListResponse>(context, GameListResponse.Parser));

		// Token: 0x040050E9 RID: 20713
		private static readonly Marshaller<GameDetailRequest> __Marshaller_classic_protocol_external_v1_game_management_GameDetailRequest = Marshallers.Create<GameDetailRequest>(new Action<GameDetailRequest, SerializationContext>(GameManagement.__Helper_SerializeMessage), (DeserializationContext context) => GameManagement.__Helper_DeserializeMessage<GameDetailRequest>(context, GameDetailRequest.Parser));

		// Token: 0x040050EA RID: 20714
		private static readonly Marshaller<GameDetailResponse> __Marshaller_classic_protocol_external_v1_game_management_GameDetailResponse = Marshallers.Create<GameDetailResponse>(new Action<GameDetailResponse, SerializationContext>(GameManagement.__Helper_SerializeMessage), (DeserializationContext context) => GameManagement.__Helper_DeserializeMessage<GameDetailResponse>(context, GameDetailResponse.Parser));

		// Token: 0x040050EB RID: 20715
		private static readonly Marshaller<GameMgmtRequest> __Marshaller_classic_protocol_external_v1_game_management_GameMgmtRequest = Marshallers.Create<GameMgmtRequest>(new Action<GameMgmtRequest, SerializationContext>(GameManagement.__Helper_SerializeMessage), (DeserializationContext context) => GameManagement.__Helper_DeserializeMessage<GameMgmtRequest>(context, GameMgmtRequest.Parser));

		// Token: 0x040050EC RID: 20716
		private static readonly Marshaller<GameMgmtResponse> __Marshaller_classic_protocol_external_v1_game_management_GameMgmtResponse = Marshallers.Create<GameMgmtResponse>(new Action<GameMgmtResponse, SerializationContext>(GameManagement.__Helper_SerializeMessage), (DeserializationContext context) => GameManagement.__Helper_DeserializeMessage<GameMgmtResponse>(context, GameMgmtResponse.Parser));

		// Token: 0x040050ED RID: 20717
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(GameManagement.__Helper_SerializeMessage), (DeserializationContext context) => GameManagement.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x040050EE RID: 20718
		private static readonly Marshaller<GameGetSitePingListResponse> __Marshaller_classic_protocol_external_v1_game_management_GameGetSitePingListResponse = Marshallers.Create<GameGetSitePingListResponse>(new Action<GameGetSitePingListResponse, SerializationContext>(GameManagement.__Helper_SerializeMessage), (DeserializationContext context) => GameManagement.__Helper_DeserializeMessage<GameGetSitePingListResponse>(context, GameGetSitePingListResponse.Parser));

		// Token: 0x040050EF RID: 20719
		private static readonly Method<GameCreateRequest, GameCreateResponse> __Method_GameCreate = new Method<GameCreateRequest, GameCreateResponse>(0, GameManagement.__ServiceName, "GameCreate", GameManagement.__Marshaller_classic_protocol_external_v1_game_management_GameCreateRequest, GameManagement.__Marshaller_classic_protocol_external_v1_game_management_GameCreateResponse);

		// Token: 0x040050F0 RID: 20720
		private static readonly Method<GameJoinRequest, GameJoinResponse> __Method_GameJoin = new Method<GameJoinRequest, GameJoinResponse>(0, GameManagement.__ServiceName, "GameJoin", GameManagement.__Marshaller_classic_protocol_external_v1_game_management_GameJoinRequest, GameManagement.__Marshaller_classic_protocol_external_v1_game_management_GameJoinResponse);

		// Token: 0x040050F1 RID: 20721
		private static readonly Method<GameListRequest, GameListResponse> __Method_GameList = new Method<GameListRequest, GameListResponse>(0, GameManagement.__ServiceName, "GameList", GameManagement.__Marshaller_classic_protocol_external_v1_game_management_GameListRequest, GameManagement.__Marshaller_classic_protocol_external_v1_game_management_GameListResponse);

		// Token: 0x040050F2 RID: 20722
		private static readonly Method<GameDetailRequest, GameDetailResponse> __Method_GameDetail = new Method<GameDetailRequest, GameDetailResponse>(0, GameManagement.__ServiceName, "GameDetail", GameManagement.__Marshaller_classic_protocol_external_v1_game_management_GameDetailRequest, GameManagement.__Marshaller_classic_protocol_external_v1_game_management_GameDetailResponse);

		// Token: 0x040050F3 RID: 20723
		private static readonly Method<GameMgmtRequest, GameMgmtResponse> __Method_GameCreateCancel = new Method<GameMgmtRequest, GameMgmtResponse>(0, GameManagement.__ServiceName, "GameCreateCancel", GameManagement.__Marshaller_classic_protocol_external_v1_game_management_GameMgmtRequest, GameManagement.__Marshaller_classic_protocol_external_v1_game_management_GameMgmtResponse);

		// Token: 0x040050F4 RID: 20724
		private static readonly Method<GameMgmtRequest, GameMgmtResponse> __Method_GameCreateQueueTime = new Method<GameMgmtRequest, GameMgmtResponse>(0, GameManagement.__ServiceName, "GameCreateQueueTime", GameManagement.__Marshaller_classic_protocol_external_v1_game_management_GameMgmtRequest, GameManagement.__Marshaller_classic_protocol_external_v1_game_management_GameMgmtResponse);

		// Token: 0x040050F5 RID: 20725
		private static readonly Method<GameMgmtRequest, GameMgmtResponse> __Method_GameMatchmake = new Method<GameMgmtRequest, GameMgmtResponse>(0, GameManagement.__ServiceName, "GameMatchmake", GameManagement.__Marshaller_classic_protocol_external_v1_game_management_GameMgmtRequest, GameManagement.__Marshaller_classic_protocol_external_v1_game_management_GameMgmtResponse);

		// Token: 0x040050F6 RID: 20726
		private static readonly Method<NoData, GameGetSitePingListResponse> __Method_GameGetSitePingList = new Method<NoData, GameGetSitePingListResponse>(0, GameManagement.__ServiceName, "GameGetSitePingList", GameManagement.__Marshaller_bgs_protocol_NoData, GameManagement.__Marshaller_classic_protocol_external_v1_game_management_GameGetSitePingListResponse);

		// Token: 0x020012C6 RID: 4806
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x040099D2 RID: 39378
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x020012C7 RID: 4807
		[BindServiceMethod(typeof(GameManagement), "BindService")]
		public abstract class GameManagementBase
		{
			// Token: 0x0600DDE6 RID: 56806 RVA: 0x004C05E8 File Offset: 0x004BE7E8
			public virtual Task<GameCreateResponse> GameCreate(GameCreateRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DDE7 RID: 56807 RVA: 0x004C05FC File Offset: 0x004BE7FC
			public virtual Task<GameJoinResponse> GameJoin(GameJoinRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DDE8 RID: 56808 RVA: 0x004C0610 File Offset: 0x004BE810
			public virtual Task<GameListResponse> GameList(GameListRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DDE9 RID: 56809 RVA: 0x004C0624 File Offset: 0x004BE824
			public virtual Task<GameDetailResponse> GameDetail(GameDetailRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DDEA RID: 56810 RVA: 0x004C0638 File Offset: 0x004BE838
			public virtual Task<GameMgmtResponse> GameCreateCancel(GameMgmtRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DDEB RID: 56811 RVA: 0x004C064C File Offset: 0x004BE84C
			public virtual Task<GameMgmtResponse> GameCreateQueueTime(GameMgmtRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DDEC RID: 56812 RVA: 0x004C0660 File Offset: 0x004BE860
			public virtual Task<GameMgmtResponse> GameMatchmake(GameMgmtRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DDED RID: 56813 RVA: 0x004C0674 File Offset: 0x004BE874
			public virtual Task<GameGetSitePingListResponse> GameGetSitePingList(NoData request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x020012C8 RID: 4808
		public class GameManagementClient : ClientBase<GameManagement.GameManagementClient>
		{
			// Token: 0x0600DDEF RID: 56815 RVA: 0x004C0691 File Offset: 0x004BE891
			public GameManagementClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600DDF0 RID: 56816 RVA: 0x004C069C File Offset: 0x004BE89C
			public GameManagementClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600DDF1 RID: 56817 RVA: 0x004C06A7 File Offset: 0x004BE8A7
			protected GameManagementClient()
			{
			}

			// Token: 0x0600DDF2 RID: 56818 RVA: 0x004C06B1 File Offset: 0x004BE8B1
			protected GameManagementClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600DDF3 RID: 56819 RVA: 0x004C06BC File Offset: 0x004BE8BC
			public virtual GameCreateResponse GameCreate(GameCreateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GameCreate(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DDF4 RID: 56820 RVA: 0x004C06E4 File Offset: 0x004BE8E4
			public virtual GameCreateResponse GameCreate(GameCreateRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GameCreateRequest, GameCreateResponse>(GameManagement.__Method_GameCreate, null, options, request);
			}

			// Token: 0x0600DDF5 RID: 56821 RVA: 0x004C070C File Offset: 0x004BE90C
			public virtual AsyncUnaryCall<GameCreateResponse> GameCreateAsync(GameCreateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GameCreateAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DDF6 RID: 56822 RVA: 0x004C0734 File Offset: 0x004BE934
			public virtual AsyncUnaryCall<GameCreateResponse> GameCreateAsync(GameCreateRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GameCreateRequest, GameCreateResponse>(GameManagement.__Method_GameCreate, null, options, request);
			}

			// Token: 0x0600DDF7 RID: 56823 RVA: 0x004C075C File Offset: 0x004BE95C
			public virtual GameJoinResponse GameJoin(GameJoinRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GameJoin(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DDF8 RID: 56824 RVA: 0x004C0784 File Offset: 0x004BE984
			public virtual GameJoinResponse GameJoin(GameJoinRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GameJoinRequest, GameJoinResponse>(GameManagement.__Method_GameJoin, null, options, request);
			}

			// Token: 0x0600DDF9 RID: 56825 RVA: 0x004C07AC File Offset: 0x004BE9AC
			public virtual AsyncUnaryCall<GameJoinResponse> GameJoinAsync(GameJoinRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GameJoinAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DDFA RID: 56826 RVA: 0x004C07D4 File Offset: 0x004BE9D4
			public virtual AsyncUnaryCall<GameJoinResponse> GameJoinAsync(GameJoinRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GameJoinRequest, GameJoinResponse>(GameManagement.__Method_GameJoin, null, options, request);
			}

			// Token: 0x0600DDFB RID: 56827 RVA: 0x004C07FC File Offset: 0x004BE9FC
			public virtual GameListResponse GameList(GameListRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GameList(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DDFC RID: 56828 RVA: 0x004C0824 File Offset: 0x004BEA24
			public virtual GameListResponse GameList(GameListRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GameListRequest, GameListResponse>(GameManagement.__Method_GameList, null, options, request);
			}

			// Token: 0x0600DDFD RID: 56829 RVA: 0x004C084C File Offset: 0x004BEA4C
			public virtual AsyncUnaryCall<GameListResponse> GameListAsync(GameListRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GameListAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DDFE RID: 56830 RVA: 0x004C0874 File Offset: 0x004BEA74
			public virtual AsyncUnaryCall<GameListResponse> GameListAsync(GameListRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GameListRequest, GameListResponse>(GameManagement.__Method_GameList, null, options, request);
			}

			// Token: 0x0600DDFF RID: 56831 RVA: 0x004C089C File Offset: 0x004BEA9C
			public virtual GameDetailResponse GameDetail(GameDetailRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GameDetail(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DE00 RID: 56832 RVA: 0x004C08C4 File Offset: 0x004BEAC4
			public virtual GameDetailResponse GameDetail(GameDetailRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GameDetailRequest, GameDetailResponse>(GameManagement.__Method_GameDetail, null, options, request);
			}

			// Token: 0x0600DE01 RID: 56833 RVA: 0x004C08EC File Offset: 0x004BEAEC
			public virtual AsyncUnaryCall<GameDetailResponse> GameDetailAsync(GameDetailRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GameDetailAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DE02 RID: 56834 RVA: 0x004C0914 File Offset: 0x004BEB14
			public virtual AsyncUnaryCall<GameDetailResponse> GameDetailAsync(GameDetailRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GameDetailRequest, GameDetailResponse>(GameManagement.__Method_GameDetail, null, options, request);
			}

			// Token: 0x0600DE03 RID: 56835 RVA: 0x004C093C File Offset: 0x004BEB3C
			public virtual GameMgmtResponse GameCreateCancel(GameMgmtRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GameCreateCancel(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DE04 RID: 56836 RVA: 0x004C0964 File Offset: 0x004BEB64
			public virtual GameMgmtResponse GameCreateCancel(GameMgmtRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GameMgmtRequest, GameMgmtResponse>(GameManagement.__Method_GameCreateCancel, null, options, request);
			}

			// Token: 0x0600DE05 RID: 56837 RVA: 0x004C098C File Offset: 0x004BEB8C
			public virtual AsyncUnaryCall<GameMgmtResponse> GameCreateCancelAsync(GameMgmtRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GameCreateCancelAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DE06 RID: 56838 RVA: 0x004C09B4 File Offset: 0x004BEBB4
			public virtual AsyncUnaryCall<GameMgmtResponse> GameCreateCancelAsync(GameMgmtRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GameMgmtRequest, GameMgmtResponse>(GameManagement.__Method_GameCreateCancel, null, options, request);
			}

			// Token: 0x0600DE07 RID: 56839 RVA: 0x004C09DC File Offset: 0x004BEBDC
			public virtual GameMgmtResponse GameCreateQueueTime(GameMgmtRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GameCreateQueueTime(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DE08 RID: 56840 RVA: 0x004C0A04 File Offset: 0x004BEC04
			public virtual GameMgmtResponse GameCreateQueueTime(GameMgmtRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GameMgmtRequest, GameMgmtResponse>(GameManagement.__Method_GameCreateQueueTime, null, options, request);
			}

			// Token: 0x0600DE09 RID: 56841 RVA: 0x004C0A2C File Offset: 0x004BEC2C
			public virtual AsyncUnaryCall<GameMgmtResponse> GameCreateQueueTimeAsync(GameMgmtRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GameCreateQueueTimeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DE0A RID: 56842 RVA: 0x004C0A54 File Offset: 0x004BEC54
			public virtual AsyncUnaryCall<GameMgmtResponse> GameCreateQueueTimeAsync(GameMgmtRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GameMgmtRequest, GameMgmtResponse>(GameManagement.__Method_GameCreateQueueTime, null, options, request);
			}

			// Token: 0x0600DE0B RID: 56843 RVA: 0x004C0A7C File Offset: 0x004BEC7C
			public virtual GameMgmtResponse GameMatchmake(GameMgmtRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GameMatchmake(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DE0C RID: 56844 RVA: 0x004C0AA4 File Offset: 0x004BECA4
			public virtual GameMgmtResponse GameMatchmake(GameMgmtRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GameMgmtRequest, GameMgmtResponse>(GameManagement.__Method_GameMatchmake, null, options, request);
			}

			// Token: 0x0600DE0D RID: 56845 RVA: 0x004C0ACC File Offset: 0x004BECCC
			public virtual AsyncUnaryCall<GameMgmtResponse> GameMatchmakeAsync(GameMgmtRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GameMatchmakeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DE0E RID: 56846 RVA: 0x004C0AF4 File Offset: 0x004BECF4
			public virtual AsyncUnaryCall<GameMgmtResponse> GameMatchmakeAsync(GameMgmtRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GameMgmtRequest, GameMgmtResponse>(GameManagement.__Method_GameMatchmake, null, options, request);
			}

			// Token: 0x0600DE0F RID: 56847 RVA: 0x004C0B1C File Offset: 0x004BED1C
			public virtual GameGetSitePingListResponse GameGetSitePingList(NoData request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GameGetSitePingList(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DE10 RID: 56848 RVA: 0x004C0B44 File Offset: 0x004BED44
			public virtual GameGetSitePingListResponse GameGetSitePingList(NoData request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<NoData, GameGetSitePingListResponse>(GameManagement.__Method_GameGetSitePingList, null, options, request);
			}

			// Token: 0x0600DE11 RID: 56849 RVA: 0x004C0B6C File Offset: 0x004BED6C
			public virtual AsyncUnaryCall<GameGetSitePingListResponse> GameGetSitePingListAsync(NoData request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GameGetSitePingListAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DE12 RID: 56850 RVA: 0x004C0B94 File Offset: 0x004BED94
			public virtual AsyncUnaryCall<GameGetSitePingListResponse> GameGetSitePingListAsync(NoData request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<NoData, GameGetSitePingListResponse>(GameManagement.__Method_GameGetSitePingList, null, options, request);
			}

			// Token: 0x0600DE13 RID: 56851 RVA: 0x004C0BBC File Offset: 0x004BEDBC
			protected override GameManagement.GameManagementClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new GameManagement.GameManagementClient(configuration);
			}
		}
	}
}
