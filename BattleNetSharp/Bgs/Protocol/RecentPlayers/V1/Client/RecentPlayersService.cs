using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.RecentPlayers.V1.Client
{
	// Token: 0x0200063A RID: 1594
	public static class RecentPlayersService
	{
		// Token: 0x06009477 RID: 38007 RVA: 0x0023EAD4 File Offset: 0x0023CCD4
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

		// Token: 0x06009478 RID: 38008 RVA: 0x0023EB20 File Offset: 0x0023CD20
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = RecentPlayersService.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17002E4E RID: 11854
		// (get) Token: 0x06009479 RID: 38009 RVA: 0x0023EB58 File Offset: 0x0023CD58
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return RecentPlayersServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x0600947A RID: 38010 RVA: 0x0023EB7C File Offset: 0x0023CD7C
		public static ServerServiceDefinition BindService(RecentPlayersService.RecentPlayersServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<SubscribeRequest, SubscribeResponse>(RecentPlayersService.__Method_Subscribe, new UnaryServerMethod<SubscribeRequest, SubscribeResponse>(serviceImpl.Subscribe)).AddMethod<UnsubscribeRequest, NoData>(RecentPlayersService.__Method_Unsubscribe, new UnaryServerMethod<UnsubscribeRequest, NoData>(serviceImpl.Unsubscribe))
				.AddMethod<GetStateRequest, GetStateResponse>(RecentPlayersService.__Method_GetState, new UnaryServerMethod<GetStateRequest, GetStateResponse>(serviceImpl.GetState))
				.AddMethod<AddRecentPlayersRequest, NoData>(RecentPlayersService.__Method_AddRecentPlayers, new UnaryServerMethod<AddRecentPlayersRequest, NoData>(serviceImpl.AddRecentPlayers))
				.AddMethod<ClearRecentPlayersRequest, NoData>(RecentPlayersService.__Method_ClearRecentPlayers, new UnaryServerMethod<ClearRecentPlayersRequest, NoData>(serviceImpl.ClearRecentPlayers))
				.Build();
		}

		// Token: 0x0600947B RID: 38011 RVA: 0x0023EC0C File Offset: 0x0023CE0C
		public static void BindService(ServiceBinderBase serviceBinder, RecentPlayersService.RecentPlayersServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<SubscribeRequest, SubscribeResponse>(RecentPlayersService.__Method_Subscribe, (serviceImpl == null) ? null : new UnaryServerMethod<SubscribeRequest, SubscribeResponse>(serviceImpl.Subscribe));
			serviceBinder.AddMethod<UnsubscribeRequest, NoData>(RecentPlayersService.__Method_Unsubscribe, (serviceImpl == null) ? null : new UnaryServerMethod<UnsubscribeRequest, NoData>(serviceImpl.Unsubscribe));
			serviceBinder.AddMethod<GetStateRequest, GetStateResponse>(RecentPlayersService.__Method_GetState, (serviceImpl == null) ? null : new UnaryServerMethod<GetStateRequest, GetStateResponse>(serviceImpl.GetState));
			serviceBinder.AddMethod<AddRecentPlayersRequest, NoData>(RecentPlayersService.__Method_AddRecentPlayers, (serviceImpl == null) ? null : new UnaryServerMethod<AddRecentPlayersRequest, NoData>(serviceImpl.AddRecentPlayers));
			serviceBinder.AddMethod<ClearRecentPlayersRequest, NoData>(RecentPlayersService.__Method_ClearRecentPlayers, (serviceImpl == null) ? null : new UnaryServerMethod<ClearRecentPlayersRequest, NoData>(serviceImpl.ClearRecentPlayers));
		}

		// Token: 0x040042DC RID: 17116
		private static readonly string __ServiceName = "bgs.protocol.recent_players.v1.client.RecentPlayersService";

		// Token: 0x040042DD RID: 17117
		private static readonly Marshaller<SubscribeRequest> __Marshaller_bgs_protocol_recent_players_v1_client_SubscribeRequest = Marshallers.Create<SubscribeRequest>(new Action<SubscribeRequest, SerializationContext>(RecentPlayersService.__Helper_SerializeMessage), (DeserializationContext context) => RecentPlayersService.__Helper_DeserializeMessage<SubscribeRequest>(context, SubscribeRequest.Parser));

		// Token: 0x040042DE RID: 17118
		private static readonly Marshaller<SubscribeResponse> __Marshaller_bgs_protocol_recent_players_v1_client_SubscribeResponse = Marshallers.Create<SubscribeResponse>(new Action<SubscribeResponse, SerializationContext>(RecentPlayersService.__Helper_SerializeMessage), (DeserializationContext context) => RecentPlayersService.__Helper_DeserializeMessage<SubscribeResponse>(context, SubscribeResponse.Parser));

		// Token: 0x040042DF RID: 17119
		private static readonly Marshaller<UnsubscribeRequest> __Marshaller_bgs_protocol_recent_players_v1_client_UnsubscribeRequest = Marshallers.Create<UnsubscribeRequest>(new Action<UnsubscribeRequest, SerializationContext>(RecentPlayersService.__Helper_SerializeMessage), (DeserializationContext context) => RecentPlayersService.__Helper_DeserializeMessage<UnsubscribeRequest>(context, UnsubscribeRequest.Parser));

		// Token: 0x040042E0 RID: 17120
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(RecentPlayersService.__Helper_SerializeMessage), (DeserializationContext context) => RecentPlayersService.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x040042E1 RID: 17121
		private static readonly Marshaller<GetStateRequest> __Marshaller_bgs_protocol_recent_players_v1_client_GetStateRequest = Marshallers.Create<GetStateRequest>(new Action<GetStateRequest, SerializationContext>(RecentPlayersService.__Helper_SerializeMessage), (DeserializationContext context) => RecentPlayersService.__Helper_DeserializeMessage<GetStateRequest>(context, GetStateRequest.Parser));

		// Token: 0x040042E2 RID: 17122
		private static readonly Marshaller<GetStateResponse> __Marshaller_bgs_protocol_recent_players_v1_client_GetStateResponse = Marshallers.Create<GetStateResponse>(new Action<GetStateResponse, SerializationContext>(RecentPlayersService.__Helper_SerializeMessage), (DeserializationContext context) => RecentPlayersService.__Helper_DeserializeMessage<GetStateResponse>(context, GetStateResponse.Parser));

		// Token: 0x040042E3 RID: 17123
		private static readonly Marshaller<AddRecentPlayersRequest> __Marshaller_bgs_protocol_recent_players_v1_client_AddRecentPlayersRequest = Marshallers.Create<AddRecentPlayersRequest>(new Action<AddRecentPlayersRequest, SerializationContext>(RecentPlayersService.__Helper_SerializeMessage), (DeserializationContext context) => RecentPlayersService.__Helper_DeserializeMessage<AddRecentPlayersRequest>(context, AddRecentPlayersRequest.Parser));

		// Token: 0x040042E4 RID: 17124
		private static readonly Marshaller<ClearRecentPlayersRequest> __Marshaller_bgs_protocol_recent_players_v1_client_ClearRecentPlayersRequest = Marshallers.Create<ClearRecentPlayersRequest>(new Action<ClearRecentPlayersRequest, SerializationContext>(RecentPlayersService.__Helper_SerializeMessage), (DeserializationContext context) => RecentPlayersService.__Helper_DeserializeMessage<ClearRecentPlayersRequest>(context, ClearRecentPlayersRequest.Parser));

		// Token: 0x040042E5 RID: 17125
		private static readonly Method<SubscribeRequest, SubscribeResponse> __Method_Subscribe = new Method<SubscribeRequest, SubscribeResponse>(0, RecentPlayersService.__ServiceName, "Subscribe", RecentPlayersService.__Marshaller_bgs_protocol_recent_players_v1_client_SubscribeRequest, RecentPlayersService.__Marshaller_bgs_protocol_recent_players_v1_client_SubscribeResponse);

		// Token: 0x040042E6 RID: 17126
		private static readonly Method<UnsubscribeRequest, NoData> __Method_Unsubscribe = new Method<UnsubscribeRequest, NoData>(0, RecentPlayersService.__ServiceName, "Unsubscribe", RecentPlayersService.__Marshaller_bgs_protocol_recent_players_v1_client_UnsubscribeRequest, RecentPlayersService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x040042E7 RID: 17127
		private static readonly Method<GetStateRequest, GetStateResponse> __Method_GetState = new Method<GetStateRequest, GetStateResponse>(0, RecentPlayersService.__ServiceName, "GetState", RecentPlayersService.__Marshaller_bgs_protocol_recent_players_v1_client_GetStateRequest, RecentPlayersService.__Marshaller_bgs_protocol_recent_players_v1_client_GetStateResponse);

		// Token: 0x040042E8 RID: 17128
		private static readonly Method<AddRecentPlayersRequest, NoData> __Method_AddRecentPlayers = new Method<AddRecentPlayersRequest, NoData>(0, RecentPlayersService.__ServiceName, "AddRecentPlayers", RecentPlayersService.__Marshaller_bgs_protocol_recent_players_v1_client_AddRecentPlayersRequest, RecentPlayersService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x040042E9 RID: 17129
		private static readonly Method<ClearRecentPlayersRequest, NoData> __Method_ClearRecentPlayers = new Method<ClearRecentPlayersRequest, NoData>(0, RecentPlayersService.__ServiceName, "ClearRecentPlayers", RecentPlayersService.__Marshaller_bgs_protocol_recent_players_v1_client_ClearRecentPlayersRequest, RecentPlayersService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x02001131 RID: 4401
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x0400986F RID: 39023
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02001132 RID: 4402
		[BindServiceMethod(typeof(RecentPlayersService), "BindService")]
		public abstract class RecentPlayersServiceBase
		{
			// Token: 0x0600D5E2 RID: 54754 RVA: 0x004B63F1 File Offset: 0x004B45F1
			public virtual Task<SubscribeResponse> Subscribe(SubscribeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D5E3 RID: 54755 RVA: 0x004B6405 File Offset: 0x004B4605
			public virtual Task<NoData> Unsubscribe(UnsubscribeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D5E4 RID: 54756 RVA: 0x004B6419 File Offset: 0x004B4619
			public virtual Task<GetStateResponse> GetState(GetStateRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D5E5 RID: 54757 RVA: 0x004B642D File Offset: 0x004B462D
			public virtual Task<NoData> AddRecentPlayers(AddRecentPlayersRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D5E6 RID: 54758 RVA: 0x004B6441 File Offset: 0x004B4641
			public virtual Task<NoData> ClearRecentPlayers(ClearRecentPlayersRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x02001133 RID: 4403
		public class RecentPlayersServiceClient : ClientBase<RecentPlayersService.RecentPlayersServiceClient>
		{
			// Token: 0x0600D5E8 RID: 54760 RVA: 0x004B645E File Offset: 0x004B465E
			public RecentPlayersServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D5E9 RID: 54761 RVA: 0x004B6469 File Offset: 0x004B4669
			public RecentPlayersServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D5EA RID: 54762 RVA: 0x004B6474 File Offset: 0x004B4674
			protected RecentPlayersServiceClient()
			{
			}

			// Token: 0x0600D5EB RID: 54763 RVA: 0x004B647E File Offset: 0x004B467E
			protected RecentPlayersServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D5EC RID: 54764 RVA: 0x004B648C File Offset: 0x004B468C
			public virtual SubscribeResponse Subscribe(SubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Subscribe(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D5ED RID: 54765 RVA: 0x004B64B4 File Offset: 0x004B46B4
			public virtual SubscribeResponse Subscribe(SubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SubscribeRequest, SubscribeResponse>(RecentPlayersService.__Method_Subscribe, null, options, request);
			}

			// Token: 0x0600D5EE RID: 54766 RVA: 0x004B64DC File Offset: 0x004B46DC
			public virtual AsyncUnaryCall<SubscribeResponse> SubscribeAsync(SubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SubscribeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D5EF RID: 54767 RVA: 0x004B6504 File Offset: 0x004B4704
			public virtual AsyncUnaryCall<SubscribeResponse> SubscribeAsync(SubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SubscribeRequest, SubscribeResponse>(RecentPlayersService.__Method_Subscribe, null, options, request);
			}

			// Token: 0x0600D5F0 RID: 54768 RVA: 0x004B652C File Offset: 0x004B472C
			public virtual NoData Unsubscribe(UnsubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Unsubscribe(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D5F1 RID: 54769 RVA: 0x004B6554 File Offset: 0x004B4754
			public virtual NoData Unsubscribe(UnsubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<UnsubscribeRequest, NoData>(RecentPlayersService.__Method_Unsubscribe, null, options, request);
			}

			// Token: 0x0600D5F2 RID: 54770 RVA: 0x004B657C File Offset: 0x004B477C
			public virtual AsyncUnaryCall<NoData> UnsubscribeAsync(UnsubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UnsubscribeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D5F3 RID: 54771 RVA: 0x004B65A4 File Offset: 0x004B47A4
			public virtual AsyncUnaryCall<NoData> UnsubscribeAsync(UnsubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<UnsubscribeRequest, NoData>(RecentPlayersService.__Method_Unsubscribe, null, options, request);
			}

			// Token: 0x0600D5F4 RID: 54772 RVA: 0x004B65CC File Offset: 0x004B47CC
			public virtual GetStateResponse GetState(GetStateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetState(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D5F5 RID: 54773 RVA: 0x004B65F4 File Offset: 0x004B47F4
			public virtual GetStateResponse GetState(GetStateRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetStateRequest, GetStateResponse>(RecentPlayersService.__Method_GetState, null, options, request);
			}

			// Token: 0x0600D5F6 RID: 54774 RVA: 0x004B661C File Offset: 0x004B481C
			public virtual AsyncUnaryCall<GetStateResponse> GetStateAsync(GetStateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetStateAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D5F7 RID: 54775 RVA: 0x004B6644 File Offset: 0x004B4844
			public virtual AsyncUnaryCall<GetStateResponse> GetStateAsync(GetStateRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetStateRequest, GetStateResponse>(RecentPlayersService.__Method_GetState, null, options, request);
			}

			// Token: 0x0600D5F8 RID: 54776 RVA: 0x004B666C File Offset: 0x004B486C
			public virtual NoData AddRecentPlayers(AddRecentPlayersRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.AddRecentPlayers(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D5F9 RID: 54777 RVA: 0x004B6694 File Offset: 0x004B4894
			public virtual NoData AddRecentPlayers(AddRecentPlayersRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<AddRecentPlayersRequest, NoData>(RecentPlayersService.__Method_AddRecentPlayers, null, options, request);
			}

			// Token: 0x0600D5FA RID: 54778 RVA: 0x004B66BC File Offset: 0x004B48BC
			public virtual AsyncUnaryCall<NoData> AddRecentPlayersAsync(AddRecentPlayersRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.AddRecentPlayersAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D5FB RID: 54779 RVA: 0x004B66E4 File Offset: 0x004B48E4
			public virtual AsyncUnaryCall<NoData> AddRecentPlayersAsync(AddRecentPlayersRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<AddRecentPlayersRequest, NoData>(RecentPlayersService.__Method_AddRecentPlayers, null, options, request);
			}

			// Token: 0x0600D5FC RID: 54780 RVA: 0x004B670C File Offset: 0x004B490C
			public virtual NoData ClearRecentPlayers(ClearRecentPlayersRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ClearRecentPlayers(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D5FD RID: 54781 RVA: 0x004B6734 File Offset: 0x004B4934
			public virtual NoData ClearRecentPlayers(ClearRecentPlayersRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ClearRecentPlayersRequest, NoData>(RecentPlayersService.__Method_ClearRecentPlayers, null, options, request);
			}

			// Token: 0x0600D5FE RID: 54782 RVA: 0x004B675C File Offset: 0x004B495C
			public virtual AsyncUnaryCall<NoData> ClearRecentPlayersAsync(ClearRecentPlayersRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ClearRecentPlayersAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D5FF RID: 54783 RVA: 0x004B6784 File Offset: 0x004B4984
			public virtual AsyncUnaryCall<NoData> ClearRecentPlayersAsync(ClearRecentPlayersRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ClearRecentPlayersRequest, NoData>(RecentPlayersService.__Method_ClearRecentPlayers, null, options, request);
			}

			// Token: 0x0600D600 RID: 54784 RVA: 0x004B67AC File Offset: 0x004B49AC
			protected override RecentPlayersService.RecentPlayersServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new RecentPlayersService.RecentPlayersServiceClient(configuration);
			}
		}
	}
}
