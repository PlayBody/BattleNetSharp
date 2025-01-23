using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Bgs.Protocol;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Classic.Protocol.V1.Leaderboard
{
	// Token: 0x02000766 RID: 1894
	public static class Leaderboard
	{
		// Token: 0x0600AE23 RID: 44579 RVA: 0x002A6480 File Offset: 0x002A4680
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

		// Token: 0x0600AE24 RID: 44580 RVA: 0x002A64CC File Offset: 0x002A46CC
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = Leaderboard.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x170035D2 RID: 13778
		// (get) Token: 0x0600AE25 RID: 44581 RVA: 0x002A6504 File Offset: 0x002A4704
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return LeaderboardReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x0600AE26 RID: 44582 RVA: 0x002A6528 File Offset: 0x002A4728
		public static ServerServiceDefinition BindService(Leaderboard.LeaderboardBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<NoData, Leaderboards>(Leaderboard.__Method_GetLeaderboardIds, new UnaryServerMethod<NoData, Leaderboards>(serviceImpl.GetLeaderboardIds)).AddMethod<NoData, ServerTime>(Leaderboard.__Method_GetServerTime, new UnaryServerMethod<NoData, ServerTime>(serviceImpl.GetServerTime))
				.AddMethod<SeasonInfo, NoData>(Leaderboard.__Method_SetSeasonInfo, new UnaryServerMethod<SeasonInfo, NoData>(serviceImpl.SetSeasonInfo))
				.Build();
		}

		// Token: 0x0600AE27 RID: 44583 RVA: 0x002A658C File Offset: 0x002A478C
		public static void BindService(ServiceBinderBase serviceBinder, Leaderboard.LeaderboardBase serviceImpl)
		{
			serviceBinder.AddMethod<NoData, Leaderboards>(Leaderboard.__Method_GetLeaderboardIds, (serviceImpl == null) ? null : new UnaryServerMethod<NoData, Leaderboards>(serviceImpl.GetLeaderboardIds));
			serviceBinder.AddMethod<NoData, ServerTime>(Leaderboard.__Method_GetServerTime, (serviceImpl == null) ? null : new UnaryServerMethod<NoData, ServerTime>(serviceImpl.GetServerTime));
			serviceBinder.AddMethod<SeasonInfo, NoData>(Leaderboard.__Method_SetSeasonInfo, (serviceImpl == null) ? null : new UnaryServerMethod<SeasonInfo, NoData>(serviceImpl.SetSeasonInfo));
		}

		// Token: 0x04004E77 RID: 20087
		private static readonly string __ServiceName = "classic.protocol.v1.leaderboard.Leaderboard";

		// Token: 0x04004E78 RID: 20088
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(Leaderboard.__Helper_SerializeMessage), (DeserializationContext context) => Leaderboard.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x04004E79 RID: 20089
		private static readonly Marshaller<Leaderboards> __Marshaller_classic_protocol_v1_leaderboard_Leaderboards = Marshallers.Create<Leaderboards>(new Action<Leaderboards, SerializationContext>(Leaderboard.__Helper_SerializeMessage), (DeserializationContext context) => Leaderboard.__Helper_DeserializeMessage<Leaderboards>(context, Leaderboards.Parser));

		// Token: 0x04004E7A RID: 20090
		private static readonly Marshaller<ServerTime> __Marshaller_classic_protocol_v1_leaderboard_ServerTime = Marshallers.Create<ServerTime>(new Action<ServerTime, SerializationContext>(Leaderboard.__Helper_SerializeMessage), (DeserializationContext context) => Leaderboard.__Helper_DeserializeMessage<ServerTime>(context, ServerTime.Parser));

		// Token: 0x04004E7B RID: 20091
		private static readonly Marshaller<SeasonInfo> __Marshaller_classic_protocol_v1_leaderboard_SeasonInfo = Marshallers.Create<SeasonInfo>(new Action<SeasonInfo, SerializationContext>(Leaderboard.__Helper_SerializeMessage), (DeserializationContext context) => Leaderboard.__Helper_DeserializeMessage<SeasonInfo>(context, SeasonInfo.Parser));

		// Token: 0x04004E7C RID: 20092
		private static readonly Method<NoData, Leaderboards> __Method_GetLeaderboardIds = new Method<NoData, Leaderboards>(0, Leaderboard.__ServiceName, "GetLeaderboardIds", Leaderboard.__Marshaller_bgs_protocol_NoData, Leaderboard.__Marshaller_classic_protocol_v1_leaderboard_Leaderboards);

		// Token: 0x04004E7D RID: 20093
		private static readonly Method<NoData, ServerTime> __Method_GetServerTime = new Method<NoData, ServerTime>(0, Leaderboard.__ServiceName, "GetServerTime", Leaderboard.__Marshaller_bgs_protocol_NoData, Leaderboard.__Marshaller_classic_protocol_v1_leaderboard_ServerTime);

		// Token: 0x04004E7E RID: 20094
		private static readonly Method<SeasonInfo, NoData> __Method_SetSeasonInfo = new Method<SeasonInfo, NoData>(0, Leaderboard.__ServiceName, "SetSeasonInfo", Leaderboard.__Marshaller_classic_protocol_v1_leaderboard_SeasonInfo, Leaderboard.__Marshaller_bgs_protocol_NoData);

		// Token: 0x02001280 RID: 4736
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x0400999C RID: 39324
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02001281 RID: 4737
		[BindServiceMethod(typeof(Leaderboard), "BindService")]
		public abstract class LeaderboardBase
		{
			// Token: 0x0600DCB6 RID: 56502 RVA: 0x004BEF00 File Offset: 0x004BD100
			public virtual Task<Leaderboards> GetLeaderboardIds(NoData request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600DCB7 RID: 56503 RVA: 0x004BEF14 File Offset: 0x004BD114
			public virtual Task<ServerTime> GetServerTime(NoData request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600DCB8 RID: 56504 RVA: 0x004BEF28 File Offset: 0x004BD128
			public virtual Task<NoData> SetSeasonInfo(SeasonInfo request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x02001282 RID: 4738
		public class LeaderboardClient : ClientBase<Leaderboard.LeaderboardClient>
		{
			// Token: 0x0600DCBA RID: 56506 RVA: 0x004BEF45 File Offset: 0x004BD145
			public LeaderboardClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600DCBB RID: 56507 RVA: 0x004BEF50 File Offset: 0x004BD150
			public LeaderboardClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600DCBC RID: 56508 RVA: 0x004BEF5B File Offset: 0x004BD15B
			protected LeaderboardClient()
			{
			}

			// Token: 0x0600DCBD RID: 56509 RVA: 0x004BEF65 File Offset: 0x004BD165
			protected LeaderboardClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600DCBE RID: 56510 RVA: 0x004BEF70 File Offset: 0x004BD170
			public virtual Leaderboards GetLeaderboardIds(NoData request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetLeaderboardIds(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DCBF RID: 56511 RVA: 0x004BEF98 File Offset: 0x004BD198
			public virtual Leaderboards GetLeaderboardIds(NoData request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<NoData, Leaderboards>(Leaderboard.__Method_GetLeaderboardIds, null, options, request);
			}

			// Token: 0x0600DCC0 RID: 56512 RVA: 0x004BEFC0 File Offset: 0x004BD1C0
			public virtual AsyncUnaryCall<Leaderboards> GetLeaderboardIdsAsync(NoData request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetLeaderboardIdsAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DCC1 RID: 56513 RVA: 0x004BEFE8 File Offset: 0x004BD1E8
			public virtual AsyncUnaryCall<Leaderboards> GetLeaderboardIdsAsync(NoData request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<NoData, Leaderboards>(Leaderboard.__Method_GetLeaderboardIds, null, options, request);
			}

			// Token: 0x0600DCC2 RID: 56514 RVA: 0x004BF010 File Offset: 0x004BD210
			public virtual ServerTime GetServerTime(NoData request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetServerTime(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DCC3 RID: 56515 RVA: 0x004BF038 File Offset: 0x004BD238
			public virtual ServerTime GetServerTime(NoData request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<NoData, ServerTime>(Leaderboard.__Method_GetServerTime, null, options, request);
			}

			// Token: 0x0600DCC4 RID: 56516 RVA: 0x004BF060 File Offset: 0x004BD260
			public virtual AsyncUnaryCall<ServerTime> GetServerTimeAsync(NoData request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetServerTimeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DCC5 RID: 56517 RVA: 0x004BF088 File Offset: 0x004BD288
			public virtual AsyncUnaryCall<ServerTime> GetServerTimeAsync(NoData request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<NoData, ServerTime>(Leaderboard.__Method_GetServerTime, null, options, request);
			}

			// Token: 0x0600DCC6 RID: 56518 RVA: 0x004BF0B0 File Offset: 0x004BD2B0
			public virtual NoData SetSeasonInfo(SeasonInfo request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SetSeasonInfo(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DCC7 RID: 56519 RVA: 0x004BF0D8 File Offset: 0x004BD2D8
			public virtual NoData SetSeasonInfo(SeasonInfo request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SeasonInfo, NoData>(Leaderboard.__Method_SetSeasonInfo, null, options, request);
			}

			// Token: 0x0600DCC8 RID: 56520 RVA: 0x004BF100 File Offset: 0x004BD300
			public virtual AsyncUnaryCall<NoData> SetSeasonInfoAsync(SeasonInfo request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SetSeasonInfoAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DCC9 RID: 56521 RVA: 0x004BF128 File Offset: 0x004BD328
			public virtual AsyncUnaryCall<NoData> SetSeasonInfoAsync(SeasonInfo request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SeasonInfo, NoData>(Leaderboard.__Method_SetSeasonInfo, null, options, request);
			}

			// Token: 0x0600DCCA RID: 56522 RVA: 0x004BF150 File Offset: 0x004BD350
			protected override Leaderboard.LeaderboardClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new Leaderboard.LeaderboardClient(configuration);
			}
		}
	}
}
