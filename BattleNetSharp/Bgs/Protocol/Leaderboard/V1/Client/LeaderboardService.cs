using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Leaderboard.V1.Client
{
	// Token: 0x0200064F RID: 1615
	public static class LeaderboardService
	{
		// Token: 0x0600962F RID: 38447 RVA: 0x002448BC File Offset: 0x00242ABC
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

		// Token: 0x06009630 RID: 38448 RVA: 0x00244908 File Offset: 0x00242B08
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = LeaderboardService.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17002ECB RID: 11979
		// (get) Token: 0x06009631 RID: 38449 RVA: 0x00244940 File Offset: 0x00242B40
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return LeaderboardServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x06009632 RID: 38450 RVA: 0x00244964 File Offset: 0x00242B64
		public static ServerServiceDefinition BindService(LeaderboardService.LeaderboardServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<GetRanksRequest, GetRanksResponse>(LeaderboardService.__Method_GetRanks, new UnaryServerMethod<GetRanksRequest, GetRanksResponse>(serviceImpl.GetRanks)).AddMethod<GetRanksByPositionRequest, GetRanksByPositionResponse>(LeaderboardService.__Method_GetRanksByPosition, new UnaryServerMethod<GetRanksByPositionRequest, GetRanksByPositionResponse>(serviceImpl.GetRanksByPosition))
				.AddMethod<GetRanksByPositionRangeRequest, GetRanksByPositionRangeResponse>(LeaderboardService.__Method_GetRanksByPositionRange, new UnaryServerMethod<GetRanksByPositionRangeRequest, GetRanksByPositionRangeResponse>(serviceImpl.GetRanksByPositionRange))
				.AddMethod<GetRanksByEntityRangeRequest, GetRanksByEntityRangeResponse>(LeaderboardService.__Method_GetRanksByEntityRange, new UnaryServerMethod<GetRanksByEntityRangeRequest, GetRanksByEntityRangeResponse>(serviceImpl.GetRanksByEntityRange))
				.AddMethod<GetRanksByEntityIdsRequest, GetRanksByEntityIdsResponse>(LeaderboardService.__Method_GetRanksByEntityIds, new UnaryServerMethod<GetRanksByEntityIdsRequest, GetRanksByEntityIdsResponse>(serviceImpl.GetRanksByEntityIds))
				.AddMethod<GetRanksByClubIdRequest, GetRanksByClubIdResponse>(LeaderboardService.__Method_GetRanksByClubId, new UnaryServerMethod<GetRanksByClubIdRequest, GetRanksByClubIdResponse>(serviceImpl.GetRanksByClubId))
				.Build();
		}

		// Token: 0x06009633 RID: 38451 RVA: 0x00244A0C File Offset: 0x00242C0C
		public static void BindService(ServiceBinderBase serviceBinder, LeaderboardService.LeaderboardServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<GetRanksRequest, GetRanksResponse>(LeaderboardService.__Method_GetRanks, (serviceImpl == null) ? null : new UnaryServerMethod<GetRanksRequest, GetRanksResponse>(serviceImpl.GetRanks));
			serviceBinder.AddMethod<GetRanksByPositionRequest, GetRanksByPositionResponse>(LeaderboardService.__Method_GetRanksByPosition, (serviceImpl == null) ? null : new UnaryServerMethod<GetRanksByPositionRequest, GetRanksByPositionResponse>(serviceImpl.GetRanksByPosition));
			serviceBinder.AddMethod<GetRanksByPositionRangeRequest, GetRanksByPositionRangeResponse>(LeaderboardService.__Method_GetRanksByPositionRange, (serviceImpl == null) ? null : new UnaryServerMethod<GetRanksByPositionRangeRequest, GetRanksByPositionRangeResponse>(serviceImpl.GetRanksByPositionRange));
			serviceBinder.AddMethod<GetRanksByEntityRangeRequest, GetRanksByEntityRangeResponse>(LeaderboardService.__Method_GetRanksByEntityRange, (serviceImpl == null) ? null : new UnaryServerMethod<GetRanksByEntityRangeRequest, GetRanksByEntityRangeResponse>(serviceImpl.GetRanksByEntityRange));
			serviceBinder.AddMethod<GetRanksByEntityIdsRequest, GetRanksByEntityIdsResponse>(LeaderboardService.__Method_GetRanksByEntityIds, (serviceImpl == null) ? null : new UnaryServerMethod<GetRanksByEntityIdsRequest, GetRanksByEntityIdsResponse>(serviceImpl.GetRanksByEntityIds));
			serviceBinder.AddMethod<GetRanksByClubIdRequest, GetRanksByClubIdResponse>(LeaderboardService.__Method_GetRanksByClubId, (serviceImpl == null) ? null : new UnaryServerMethod<GetRanksByClubIdRequest, GetRanksByClubIdResponse>(serviceImpl.GetRanksByClubId));
		}

		// Token: 0x04004394 RID: 17300
		private static readonly string __ServiceName = "bgs.protocol.leaderboard.v1.client.LeaderboardService";

		// Token: 0x04004395 RID: 17301
		private static readonly Marshaller<GetRanksRequest> __Marshaller_bgs_protocol_leaderboard_v1_client_GetRanksRequest = Marshallers.Create<GetRanksRequest>(new Action<GetRanksRequest, SerializationContext>(LeaderboardService.__Helper_SerializeMessage), (DeserializationContext context) => LeaderboardService.__Helper_DeserializeMessage<GetRanksRequest>(context, GetRanksRequest.Parser));

		// Token: 0x04004396 RID: 17302
		private static readonly Marshaller<GetRanksResponse> __Marshaller_bgs_protocol_leaderboard_v1_client_GetRanksResponse = Marshallers.Create<GetRanksResponse>(new Action<GetRanksResponse, SerializationContext>(LeaderboardService.__Helper_SerializeMessage), (DeserializationContext context) => LeaderboardService.__Helper_DeserializeMessage<GetRanksResponse>(context, GetRanksResponse.Parser));

		// Token: 0x04004397 RID: 17303
		private static readonly Marshaller<GetRanksByPositionRequest> __Marshaller_bgs_protocol_leaderboard_v1_client_GetRanksByPositionRequest = Marshallers.Create<GetRanksByPositionRequest>(new Action<GetRanksByPositionRequest, SerializationContext>(LeaderboardService.__Helper_SerializeMessage), (DeserializationContext context) => LeaderboardService.__Helper_DeserializeMessage<GetRanksByPositionRequest>(context, GetRanksByPositionRequest.Parser));

		// Token: 0x04004398 RID: 17304
		private static readonly Marshaller<GetRanksByPositionResponse> __Marshaller_bgs_protocol_leaderboard_v1_client_GetRanksByPositionResponse = Marshallers.Create<GetRanksByPositionResponse>(new Action<GetRanksByPositionResponse, SerializationContext>(LeaderboardService.__Helper_SerializeMessage), (DeserializationContext context) => LeaderboardService.__Helper_DeserializeMessage<GetRanksByPositionResponse>(context, GetRanksByPositionResponse.Parser));

		// Token: 0x04004399 RID: 17305
		private static readonly Marshaller<GetRanksByPositionRangeRequest> __Marshaller_bgs_protocol_leaderboard_v1_client_GetRanksByPositionRangeRequest = Marshallers.Create<GetRanksByPositionRangeRequest>(new Action<GetRanksByPositionRangeRequest, SerializationContext>(LeaderboardService.__Helper_SerializeMessage), (DeserializationContext context) => LeaderboardService.__Helper_DeserializeMessage<GetRanksByPositionRangeRequest>(context, GetRanksByPositionRangeRequest.Parser));

		// Token: 0x0400439A RID: 17306
		private static readonly Marshaller<GetRanksByPositionRangeResponse> __Marshaller_bgs_protocol_leaderboard_v1_client_GetRanksByPositionRangeResponse = Marshallers.Create<GetRanksByPositionRangeResponse>(new Action<GetRanksByPositionRangeResponse, SerializationContext>(LeaderboardService.__Helper_SerializeMessage), (DeserializationContext context) => LeaderboardService.__Helper_DeserializeMessage<GetRanksByPositionRangeResponse>(context, GetRanksByPositionRangeResponse.Parser));

		// Token: 0x0400439B RID: 17307
		private static readonly Marshaller<GetRanksByEntityRangeRequest> __Marshaller_bgs_protocol_leaderboard_v1_client_GetRanksByEntityRangeRequest = Marshallers.Create<GetRanksByEntityRangeRequest>(new Action<GetRanksByEntityRangeRequest, SerializationContext>(LeaderboardService.__Helper_SerializeMessage), (DeserializationContext context) => LeaderboardService.__Helper_DeserializeMessage<GetRanksByEntityRangeRequest>(context, GetRanksByEntityRangeRequest.Parser));

		// Token: 0x0400439C RID: 17308
		private static readonly Marshaller<GetRanksByEntityRangeResponse> __Marshaller_bgs_protocol_leaderboard_v1_client_GetRanksByEntityRangeResponse = Marshallers.Create<GetRanksByEntityRangeResponse>(new Action<GetRanksByEntityRangeResponse, SerializationContext>(LeaderboardService.__Helper_SerializeMessage), (DeserializationContext context) => LeaderboardService.__Helper_DeserializeMessage<GetRanksByEntityRangeResponse>(context, GetRanksByEntityRangeResponse.Parser));

		// Token: 0x0400439D RID: 17309
		private static readonly Marshaller<GetRanksByEntityIdsRequest> __Marshaller_bgs_protocol_leaderboard_v1_client_GetRanksByEntityIdsRequest = Marshallers.Create<GetRanksByEntityIdsRequest>(new Action<GetRanksByEntityIdsRequest, SerializationContext>(LeaderboardService.__Helper_SerializeMessage), (DeserializationContext context) => LeaderboardService.__Helper_DeserializeMessage<GetRanksByEntityIdsRequest>(context, GetRanksByEntityIdsRequest.Parser));

		// Token: 0x0400439E RID: 17310
		private static readonly Marshaller<GetRanksByEntityIdsResponse> __Marshaller_bgs_protocol_leaderboard_v1_client_GetRanksByEntityIdsResponse = Marshallers.Create<GetRanksByEntityIdsResponse>(new Action<GetRanksByEntityIdsResponse, SerializationContext>(LeaderboardService.__Helper_SerializeMessage), (DeserializationContext context) => LeaderboardService.__Helper_DeserializeMessage<GetRanksByEntityIdsResponse>(context, GetRanksByEntityIdsResponse.Parser));

		// Token: 0x0400439F RID: 17311
		private static readonly Marshaller<GetRanksByClubIdRequest> __Marshaller_bgs_protocol_leaderboard_v1_client_GetRanksByClubIdRequest = Marshallers.Create<GetRanksByClubIdRequest>(new Action<GetRanksByClubIdRequest, SerializationContext>(LeaderboardService.__Helper_SerializeMessage), (DeserializationContext context) => LeaderboardService.__Helper_DeserializeMessage<GetRanksByClubIdRequest>(context, GetRanksByClubIdRequest.Parser));

		// Token: 0x040043A0 RID: 17312
		private static readonly Marshaller<GetRanksByClubIdResponse> __Marshaller_bgs_protocol_leaderboard_v1_client_GetRanksByClubIdResponse = Marshallers.Create<GetRanksByClubIdResponse>(new Action<GetRanksByClubIdResponse, SerializationContext>(LeaderboardService.__Helper_SerializeMessage), (DeserializationContext context) => LeaderboardService.__Helper_DeserializeMessage<GetRanksByClubIdResponse>(context, GetRanksByClubIdResponse.Parser));

		// Token: 0x040043A1 RID: 17313
		private static readonly Method<GetRanksRequest, GetRanksResponse> __Method_GetRanks = new Method<GetRanksRequest, GetRanksResponse>(0, LeaderboardService.__ServiceName, "GetRanks", LeaderboardService.__Marshaller_bgs_protocol_leaderboard_v1_client_GetRanksRequest, LeaderboardService.__Marshaller_bgs_protocol_leaderboard_v1_client_GetRanksResponse);

		// Token: 0x040043A2 RID: 17314
		private static readonly Method<GetRanksByPositionRequest, GetRanksByPositionResponse> __Method_GetRanksByPosition = new Method<GetRanksByPositionRequest, GetRanksByPositionResponse>(0, LeaderboardService.__ServiceName, "GetRanksByPosition", LeaderboardService.__Marshaller_bgs_protocol_leaderboard_v1_client_GetRanksByPositionRequest, LeaderboardService.__Marshaller_bgs_protocol_leaderboard_v1_client_GetRanksByPositionResponse);

		// Token: 0x040043A3 RID: 17315
		private static readonly Method<GetRanksByPositionRangeRequest, GetRanksByPositionRangeResponse> __Method_GetRanksByPositionRange = new Method<GetRanksByPositionRangeRequest, GetRanksByPositionRangeResponse>(0, LeaderboardService.__ServiceName, "GetRanksByPositionRange", LeaderboardService.__Marshaller_bgs_protocol_leaderboard_v1_client_GetRanksByPositionRangeRequest, LeaderboardService.__Marshaller_bgs_protocol_leaderboard_v1_client_GetRanksByPositionRangeResponse);

		// Token: 0x040043A4 RID: 17316
		private static readonly Method<GetRanksByEntityRangeRequest, GetRanksByEntityRangeResponse> __Method_GetRanksByEntityRange = new Method<GetRanksByEntityRangeRequest, GetRanksByEntityRangeResponse>(0, LeaderboardService.__ServiceName, "GetRanksByEntityRange", LeaderboardService.__Marshaller_bgs_protocol_leaderboard_v1_client_GetRanksByEntityRangeRequest, LeaderboardService.__Marshaller_bgs_protocol_leaderboard_v1_client_GetRanksByEntityRangeResponse);

		// Token: 0x040043A5 RID: 17317
		private static readonly Method<GetRanksByEntityIdsRequest, GetRanksByEntityIdsResponse> __Method_GetRanksByEntityIds = new Method<GetRanksByEntityIdsRequest, GetRanksByEntityIdsResponse>(0, LeaderboardService.__ServiceName, "GetRanksByEntityIds", LeaderboardService.__Marshaller_bgs_protocol_leaderboard_v1_client_GetRanksByEntityIdsRequest, LeaderboardService.__Marshaller_bgs_protocol_leaderboard_v1_client_GetRanksByEntityIdsResponse);

		// Token: 0x040043A6 RID: 17318
		private static readonly Method<GetRanksByClubIdRequest, GetRanksByClubIdResponse> __Method_GetRanksByClubId = new Method<GetRanksByClubIdRequest, GetRanksByClubIdResponse>(0, LeaderboardService.__ServiceName, "GetRanksByClubId", LeaderboardService.__Marshaller_bgs_protocol_leaderboard_v1_client_GetRanksByClubIdRequest, LeaderboardService.__Marshaller_bgs_protocol_leaderboard_v1_client_GetRanksByClubIdResponse);

		// Token: 0x02001147 RID: 4423
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x04009883 RID: 39043
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02001148 RID: 4424
		[BindServiceMethod(typeof(LeaderboardService), "BindService")]
		public abstract class LeaderboardServiceBase
		{
			// Token: 0x0600D642 RID: 54850 RVA: 0x004B6A5E File Offset: 0x004B4C5E
			public virtual Task<GetRanksResponse> GetRanks(GetRanksRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D643 RID: 54851 RVA: 0x004B6A72 File Offset: 0x004B4C72
			public virtual Task<GetRanksByPositionResponse> GetRanksByPosition(GetRanksByPositionRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D644 RID: 54852 RVA: 0x004B6A86 File Offset: 0x004B4C86
			public virtual Task<GetRanksByPositionRangeResponse> GetRanksByPositionRange(GetRanksByPositionRangeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D645 RID: 54853 RVA: 0x004B6A9A File Offset: 0x004B4C9A
			public virtual Task<GetRanksByEntityRangeResponse> GetRanksByEntityRange(GetRanksByEntityRangeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D646 RID: 54854 RVA: 0x004B6AAE File Offset: 0x004B4CAE
			public virtual Task<GetRanksByEntityIdsResponse> GetRanksByEntityIds(GetRanksByEntityIdsRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D647 RID: 54855 RVA: 0x004B6AC2 File Offset: 0x004B4CC2
			public virtual Task<GetRanksByClubIdResponse> GetRanksByClubId(GetRanksByClubIdRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x02001149 RID: 4425
		public class LeaderboardServiceClient : ClientBase<LeaderboardService.LeaderboardServiceClient>
		{
			// Token: 0x0600D649 RID: 54857 RVA: 0x004B6ADF File Offset: 0x004B4CDF
			public LeaderboardServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D64A RID: 54858 RVA: 0x004B6AEA File Offset: 0x004B4CEA
			public LeaderboardServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D64B RID: 54859 RVA: 0x004B6AF5 File Offset: 0x004B4CF5
			protected LeaderboardServiceClient()
			{
			}

			// Token: 0x0600D64C RID: 54860 RVA: 0x004B6AFF File Offset: 0x004B4CFF
			protected LeaderboardServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D64D RID: 54861 RVA: 0x004B6B0C File Offset: 0x004B4D0C
			public virtual GetRanksResponse GetRanks(GetRanksRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetRanks(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D64E RID: 54862 RVA: 0x004B6B34 File Offset: 0x004B4D34
			public virtual GetRanksResponse GetRanks(GetRanksRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetRanksRequest, GetRanksResponse>(LeaderboardService.__Method_GetRanks, null, options, request);
			}

			// Token: 0x0600D64F RID: 54863 RVA: 0x004B6B5C File Offset: 0x004B4D5C
			public virtual AsyncUnaryCall<GetRanksResponse> GetRanksAsync(GetRanksRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetRanksAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D650 RID: 54864 RVA: 0x004B6B84 File Offset: 0x004B4D84
			public virtual AsyncUnaryCall<GetRanksResponse> GetRanksAsync(GetRanksRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetRanksRequest, GetRanksResponse>(LeaderboardService.__Method_GetRanks, null, options, request);
			}

			// Token: 0x0600D651 RID: 54865 RVA: 0x004B6BAC File Offset: 0x004B4DAC
			public virtual GetRanksByPositionResponse GetRanksByPosition(GetRanksByPositionRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetRanksByPosition(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D652 RID: 54866 RVA: 0x004B6BD4 File Offset: 0x004B4DD4
			public virtual GetRanksByPositionResponse GetRanksByPosition(GetRanksByPositionRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetRanksByPositionRequest, GetRanksByPositionResponse>(LeaderboardService.__Method_GetRanksByPosition, null, options, request);
			}

			// Token: 0x0600D653 RID: 54867 RVA: 0x004B6BFC File Offset: 0x004B4DFC
			public virtual AsyncUnaryCall<GetRanksByPositionResponse> GetRanksByPositionAsync(GetRanksByPositionRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetRanksByPositionAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D654 RID: 54868 RVA: 0x004B6C24 File Offset: 0x004B4E24
			public virtual AsyncUnaryCall<GetRanksByPositionResponse> GetRanksByPositionAsync(GetRanksByPositionRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetRanksByPositionRequest, GetRanksByPositionResponse>(LeaderboardService.__Method_GetRanksByPosition, null, options, request);
			}

			// Token: 0x0600D655 RID: 54869 RVA: 0x004B6C4C File Offset: 0x004B4E4C
			public virtual GetRanksByPositionRangeResponse GetRanksByPositionRange(GetRanksByPositionRangeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetRanksByPositionRange(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D656 RID: 54870 RVA: 0x004B6C74 File Offset: 0x004B4E74
			public virtual GetRanksByPositionRangeResponse GetRanksByPositionRange(GetRanksByPositionRangeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetRanksByPositionRangeRequest, GetRanksByPositionRangeResponse>(LeaderboardService.__Method_GetRanksByPositionRange, null, options, request);
			}

			// Token: 0x0600D657 RID: 54871 RVA: 0x004B6C9C File Offset: 0x004B4E9C
			public virtual AsyncUnaryCall<GetRanksByPositionRangeResponse> GetRanksByPositionRangeAsync(GetRanksByPositionRangeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetRanksByPositionRangeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D658 RID: 54872 RVA: 0x004B6CC4 File Offset: 0x004B4EC4
			public virtual AsyncUnaryCall<GetRanksByPositionRangeResponse> GetRanksByPositionRangeAsync(GetRanksByPositionRangeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetRanksByPositionRangeRequest, GetRanksByPositionRangeResponse>(LeaderboardService.__Method_GetRanksByPositionRange, null, options, request);
			}

			// Token: 0x0600D659 RID: 54873 RVA: 0x004B6CEC File Offset: 0x004B4EEC
			public virtual GetRanksByEntityRangeResponse GetRanksByEntityRange(GetRanksByEntityRangeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetRanksByEntityRange(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D65A RID: 54874 RVA: 0x004B6D14 File Offset: 0x004B4F14
			public virtual GetRanksByEntityRangeResponse GetRanksByEntityRange(GetRanksByEntityRangeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetRanksByEntityRangeRequest, GetRanksByEntityRangeResponse>(LeaderboardService.__Method_GetRanksByEntityRange, null, options, request);
			}

			// Token: 0x0600D65B RID: 54875 RVA: 0x004B6D3C File Offset: 0x004B4F3C
			public virtual AsyncUnaryCall<GetRanksByEntityRangeResponse> GetRanksByEntityRangeAsync(GetRanksByEntityRangeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetRanksByEntityRangeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D65C RID: 54876 RVA: 0x004B6D64 File Offset: 0x004B4F64
			public virtual AsyncUnaryCall<GetRanksByEntityRangeResponse> GetRanksByEntityRangeAsync(GetRanksByEntityRangeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetRanksByEntityRangeRequest, GetRanksByEntityRangeResponse>(LeaderboardService.__Method_GetRanksByEntityRange, null, options, request);
			}

			// Token: 0x0600D65D RID: 54877 RVA: 0x004B6D8C File Offset: 0x004B4F8C
			public virtual GetRanksByEntityIdsResponse GetRanksByEntityIds(GetRanksByEntityIdsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetRanksByEntityIds(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D65E RID: 54878 RVA: 0x004B6DB4 File Offset: 0x004B4FB4
			public virtual GetRanksByEntityIdsResponse GetRanksByEntityIds(GetRanksByEntityIdsRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetRanksByEntityIdsRequest, GetRanksByEntityIdsResponse>(LeaderboardService.__Method_GetRanksByEntityIds, null, options, request);
			}

			// Token: 0x0600D65F RID: 54879 RVA: 0x004B6DDC File Offset: 0x004B4FDC
			public virtual AsyncUnaryCall<GetRanksByEntityIdsResponse> GetRanksByEntityIdsAsync(GetRanksByEntityIdsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetRanksByEntityIdsAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D660 RID: 54880 RVA: 0x004B6E04 File Offset: 0x004B5004
			public virtual AsyncUnaryCall<GetRanksByEntityIdsResponse> GetRanksByEntityIdsAsync(GetRanksByEntityIdsRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetRanksByEntityIdsRequest, GetRanksByEntityIdsResponse>(LeaderboardService.__Method_GetRanksByEntityIds, null, options, request);
			}

			// Token: 0x0600D661 RID: 54881 RVA: 0x004B6E2C File Offset: 0x004B502C
			public virtual GetRanksByClubIdResponse GetRanksByClubId(GetRanksByClubIdRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetRanksByClubId(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D662 RID: 54882 RVA: 0x004B6E54 File Offset: 0x004B5054
			public virtual GetRanksByClubIdResponse GetRanksByClubId(GetRanksByClubIdRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetRanksByClubIdRequest, GetRanksByClubIdResponse>(LeaderboardService.__Method_GetRanksByClubId, null, options, request);
			}

			// Token: 0x0600D663 RID: 54883 RVA: 0x004B6E7C File Offset: 0x004B507C
			public virtual AsyncUnaryCall<GetRanksByClubIdResponse> GetRanksByClubIdAsync(GetRanksByClubIdRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetRanksByClubIdAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D664 RID: 54884 RVA: 0x004B6EA4 File Offset: 0x004B50A4
			public virtual AsyncUnaryCall<GetRanksByClubIdResponse> GetRanksByClubIdAsync(GetRanksByClubIdRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetRanksByClubIdRequest, GetRanksByClubIdResponse>(LeaderboardService.__Method_GetRanksByClubId, null, options, request);
			}

			// Token: 0x0600D665 RID: 54885 RVA: 0x004B6ECC File Offset: 0x004B50CC
			protected override LeaderboardService.LeaderboardServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new LeaderboardService.LeaderboardServiceClient(configuration);
			}
		}
	}
}
