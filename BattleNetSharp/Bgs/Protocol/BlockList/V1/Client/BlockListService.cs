using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.BlockList.V1.Client
{
	// Token: 0x02000704 RID: 1796
	public static class BlockListService
	{
		// Token: 0x0600A504 RID: 42244 RVA: 0x00282CD0 File Offset: 0x00280ED0
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

		// Token: 0x0600A505 RID: 42245 RVA: 0x00282D1C File Offset: 0x00280F1C
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = BlockListService.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17003300 RID: 13056
		// (get) Token: 0x0600A506 RID: 42246 RVA: 0x00282D54 File Offset: 0x00280F54
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return BlockListServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x0600A507 RID: 42247 RVA: 0x00282D78 File Offset: 0x00280F78
		public static ServerServiceDefinition BindService(BlockListService.BlockListServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<SubscribeRequest, SubscribeResponse>(BlockListService.__Method_Subscribe, new UnaryServerMethod<SubscribeRequest, SubscribeResponse>(serviceImpl.Subscribe)).AddMethod<UnsubscribeRequest, NoData>(BlockListService.__Method_Unsubscribe, new UnaryServerMethod<UnsubscribeRequest, NoData>(serviceImpl.Unsubscribe))
				.AddMethod<GetStateRequest, GetStateResponse>(BlockListService.__Method_GetState, new UnaryServerMethod<GetStateRequest, GetStateResponse>(serviceImpl.GetState))
				.AddMethod<BlockPlayerRequest, NoData>(BlockListService.__Method_BlockPlayer, new UnaryServerMethod<BlockPlayerRequest, NoData>(serviceImpl.BlockPlayer))
				.AddMethod<UnblockPlayerRequest, NoData>(BlockListService.__Method_UnblockPlayer, new UnaryServerMethod<UnblockPlayerRequest, NoData>(serviceImpl.UnblockPlayer))
				.AddMethod<BlockPlayerRequest, NoData>(BlockListService.__Method_BlockPlayerForSession, new UnaryServerMethod<BlockPlayerRequest, NoData>(serviceImpl.BlockPlayerForSession))
				.Build();
		}

		// Token: 0x0600A508 RID: 42248 RVA: 0x00282E20 File Offset: 0x00281020
		public static void BindService(ServiceBinderBase serviceBinder, BlockListService.BlockListServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<SubscribeRequest, SubscribeResponse>(BlockListService.__Method_Subscribe, (serviceImpl == null) ? null : new UnaryServerMethod<SubscribeRequest, SubscribeResponse>(serviceImpl.Subscribe));
			serviceBinder.AddMethod<UnsubscribeRequest, NoData>(BlockListService.__Method_Unsubscribe, (serviceImpl == null) ? null : new UnaryServerMethod<UnsubscribeRequest, NoData>(serviceImpl.Unsubscribe));
			serviceBinder.AddMethod<GetStateRequest, GetStateResponse>(BlockListService.__Method_GetState, (serviceImpl == null) ? null : new UnaryServerMethod<GetStateRequest, GetStateResponse>(serviceImpl.GetState));
			serviceBinder.AddMethod<BlockPlayerRequest, NoData>(BlockListService.__Method_BlockPlayer, (serviceImpl == null) ? null : new UnaryServerMethod<BlockPlayerRequest, NoData>(serviceImpl.BlockPlayer));
			serviceBinder.AddMethod<UnblockPlayerRequest, NoData>(BlockListService.__Method_UnblockPlayer, (serviceImpl == null) ? null : new UnaryServerMethod<UnblockPlayerRequest, NoData>(serviceImpl.UnblockPlayer));
			serviceBinder.AddMethod<BlockPlayerRequest, NoData>(BlockListService.__Method_BlockPlayerForSession, (serviceImpl == null) ? null : new UnaryServerMethod<BlockPlayerRequest, NoData>(serviceImpl.BlockPlayerForSession));
		}

		// Token: 0x04004A3B RID: 19003
		private static readonly string __ServiceName = "bgs.protocol.block_list.v1.client.BlockListService";

		// Token: 0x04004A3C RID: 19004
		private static readonly Marshaller<SubscribeRequest> __Marshaller_bgs_protocol_block_list_v1_client_SubscribeRequest = Marshallers.Create<SubscribeRequest>(new Action<SubscribeRequest, SerializationContext>(BlockListService.__Helper_SerializeMessage), (DeserializationContext context) => BlockListService.__Helper_DeserializeMessage<SubscribeRequest>(context, SubscribeRequest.Parser));

		// Token: 0x04004A3D RID: 19005
		private static readonly Marshaller<SubscribeResponse> __Marshaller_bgs_protocol_block_list_v1_client_SubscribeResponse = Marshallers.Create<SubscribeResponse>(new Action<SubscribeResponse, SerializationContext>(BlockListService.__Helper_SerializeMessage), (DeserializationContext context) => BlockListService.__Helper_DeserializeMessage<SubscribeResponse>(context, SubscribeResponse.Parser));

		// Token: 0x04004A3E RID: 19006
		private static readonly Marshaller<UnsubscribeRequest> __Marshaller_bgs_protocol_block_list_v1_client_UnsubscribeRequest = Marshallers.Create<UnsubscribeRequest>(new Action<UnsubscribeRequest, SerializationContext>(BlockListService.__Helper_SerializeMessage), (DeserializationContext context) => BlockListService.__Helper_DeserializeMessage<UnsubscribeRequest>(context, UnsubscribeRequest.Parser));

		// Token: 0x04004A3F RID: 19007
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(BlockListService.__Helper_SerializeMessage), (DeserializationContext context) => BlockListService.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x04004A40 RID: 19008
		private static readonly Marshaller<GetStateRequest> __Marshaller_bgs_protocol_block_list_v1_client_GetStateRequest = Marshallers.Create<GetStateRequest>(new Action<GetStateRequest, SerializationContext>(BlockListService.__Helper_SerializeMessage), (DeserializationContext context) => BlockListService.__Helper_DeserializeMessage<GetStateRequest>(context, GetStateRequest.Parser));

		// Token: 0x04004A41 RID: 19009
		private static readonly Marshaller<GetStateResponse> __Marshaller_bgs_protocol_block_list_v1_client_GetStateResponse = Marshallers.Create<GetStateResponse>(new Action<GetStateResponse, SerializationContext>(BlockListService.__Helper_SerializeMessage), (DeserializationContext context) => BlockListService.__Helper_DeserializeMessage<GetStateResponse>(context, GetStateResponse.Parser));

		// Token: 0x04004A42 RID: 19010
		private static readonly Marshaller<BlockPlayerRequest> __Marshaller_bgs_protocol_block_list_v1_client_BlockPlayerRequest = Marshallers.Create<BlockPlayerRequest>(new Action<BlockPlayerRequest, SerializationContext>(BlockListService.__Helper_SerializeMessage), (DeserializationContext context) => BlockListService.__Helper_DeserializeMessage<BlockPlayerRequest>(context, BlockPlayerRequest.Parser));

		// Token: 0x04004A43 RID: 19011
		private static readonly Marshaller<UnblockPlayerRequest> __Marshaller_bgs_protocol_block_list_v1_client_UnblockPlayerRequest = Marshallers.Create<UnblockPlayerRequest>(new Action<UnblockPlayerRequest, SerializationContext>(BlockListService.__Helper_SerializeMessage), (DeserializationContext context) => BlockListService.__Helper_DeserializeMessage<UnblockPlayerRequest>(context, UnblockPlayerRequest.Parser));

		// Token: 0x04004A44 RID: 19012
		private static readonly Method<SubscribeRequest, SubscribeResponse> __Method_Subscribe = new Method<SubscribeRequest, SubscribeResponse>(0, BlockListService.__ServiceName, "Subscribe", BlockListService.__Marshaller_bgs_protocol_block_list_v1_client_SubscribeRequest, BlockListService.__Marshaller_bgs_protocol_block_list_v1_client_SubscribeResponse);

		// Token: 0x04004A45 RID: 19013
		private static readonly Method<UnsubscribeRequest, NoData> __Method_Unsubscribe = new Method<UnsubscribeRequest, NoData>(0, BlockListService.__ServiceName, "Unsubscribe", BlockListService.__Marshaller_bgs_protocol_block_list_v1_client_UnsubscribeRequest, BlockListService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04004A46 RID: 19014
		private static readonly Method<GetStateRequest, GetStateResponse> __Method_GetState = new Method<GetStateRequest, GetStateResponse>(0, BlockListService.__ServiceName, "GetState", BlockListService.__Marshaller_bgs_protocol_block_list_v1_client_GetStateRequest, BlockListService.__Marshaller_bgs_protocol_block_list_v1_client_GetStateResponse);

		// Token: 0x04004A47 RID: 19015
		private static readonly Method<BlockPlayerRequest, NoData> __Method_BlockPlayer = new Method<BlockPlayerRequest, NoData>(0, BlockListService.__ServiceName, "BlockPlayer", BlockListService.__Marshaller_bgs_protocol_block_list_v1_client_BlockPlayerRequest, BlockListService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04004A48 RID: 19016
		private static readonly Method<UnblockPlayerRequest, NoData> __Method_UnblockPlayer = new Method<UnblockPlayerRequest, NoData>(0, BlockListService.__ServiceName, "UnblockPlayer", BlockListService.__Marshaller_bgs_protocol_block_list_v1_client_UnblockPlayerRequest, BlockListService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04004A49 RID: 19017
		private static readonly Method<BlockPlayerRequest, NoData> __Method_BlockPlayerForSession = new Method<BlockPlayerRequest, NoData>(0, BlockListService.__ServiceName, "BlockPlayerForSession", BlockListService.__Marshaller_bgs_protocol_block_list_v1_client_BlockPlayerRequest, BlockListService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x02001215 RID: 4629
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x0400993A RID: 39226
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02001216 RID: 4630
		[BindServiceMethod(typeof(BlockListService), "BindService")]
		public abstract class BlockListServiceBase
		{
			// Token: 0x0600DA87 RID: 55943 RVA: 0x004BC1E5 File Offset: 0x004BA3E5
			public virtual Task<SubscribeResponse> Subscribe(SubscribeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600DA88 RID: 55944 RVA: 0x004BC1F9 File Offset: 0x004BA3F9
			public virtual Task<NoData> Unsubscribe(UnsubscribeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600DA89 RID: 55945 RVA: 0x004BC20D File Offset: 0x004BA40D
			public virtual Task<GetStateResponse> GetState(GetStateRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600DA8A RID: 55946 RVA: 0x004BC221 File Offset: 0x004BA421
			public virtual Task<NoData> BlockPlayer(BlockPlayerRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600DA8B RID: 55947 RVA: 0x004BC235 File Offset: 0x004BA435
			public virtual Task<NoData> UnblockPlayer(UnblockPlayerRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600DA8C RID: 55948 RVA: 0x004BC249 File Offset: 0x004BA449
			public virtual Task<NoData> BlockPlayerForSession(BlockPlayerRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x02001217 RID: 4631
		public class BlockListServiceClient : ClientBase<BlockListService.BlockListServiceClient>
		{
			// Token: 0x0600DA8E RID: 55950 RVA: 0x004BC266 File Offset: 0x004BA466
			public BlockListServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600DA8F RID: 55951 RVA: 0x004BC271 File Offset: 0x004BA471
			public BlockListServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600DA90 RID: 55952 RVA: 0x004BC27C File Offset: 0x004BA47C
			protected BlockListServiceClient()
			{
			}

			// Token: 0x0600DA91 RID: 55953 RVA: 0x004BC286 File Offset: 0x004BA486
			protected BlockListServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600DA92 RID: 55954 RVA: 0x004BC294 File Offset: 0x004BA494
			public virtual SubscribeResponse Subscribe(SubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Subscribe(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DA93 RID: 55955 RVA: 0x004BC2BC File Offset: 0x004BA4BC
			public virtual SubscribeResponse Subscribe(SubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SubscribeRequest, SubscribeResponse>(BlockListService.__Method_Subscribe, null, options, request);
			}

			// Token: 0x0600DA94 RID: 55956 RVA: 0x004BC2E4 File Offset: 0x004BA4E4
			public virtual AsyncUnaryCall<SubscribeResponse> SubscribeAsync(SubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SubscribeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DA95 RID: 55957 RVA: 0x004BC30C File Offset: 0x004BA50C
			public virtual AsyncUnaryCall<SubscribeResponse> SubscribeAsync(SubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SubscribeRequest, SubscribeResponse>(BlockListService.__Method_Subscribe, null, options, request);
			}

			// Token: 0x0600DA96 RID: 55958 RVA: 0x004BC334 File Offset: 0x004BA534
			public virtual NoData Unsubscribe(UnsubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Unsubscribe(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DA97 RID: 55959 RVA: 0x004BC35C File Offset: 0x004BA55C
			public virtual NoData Unsubscribe(UnsubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<UnsubscribeRequest, NoData>(BlockListService.__Method_Unsubscribe, null, options, request);
			}

			// Token: 0x0600DA98 RID: 55960 RVA: 0x004BC384 File Offset: 0x004BA584
			public virtual AsyncUnaryCall<NoData> UnsubscribeAsync(UnsubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UnsubscribeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DA99 RID: 55961 RVA: 0x004BC3AC File Offset: 0x004BA5AC
			public virtual AsyncUnaryCall<NoData> UnsubscribeAsync(UnsubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<UnsubscribeRequest, NoData>(BlockListService.__Method_Unsubscribe, null, options, request);
			}

			// Token: 0x0600DA9A RID: 55962 RVA: 0x004BC3D4 File Offset: 0x004BA5D4
			public virtual GetStateResponse GetState(GetStateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetState(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DA9B RID: 55963 RVA: 0x004BC3FC File Offset: 0x004BA5FC
			public virtual GetStateResponse GetState(GetStateRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetStateRequest, GetStateResponse>(BlockListService.__Method_GetState, null, options, request);
			}

			// Token: 0x0600DA9C RID: 55964 RVA: 0x004BC424 File Offset: 0x004BA624
			public virtual AsyncUnaryCall<GetStateResponse> GetStateAsync(GetStateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetStateAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DA9D RID: 55965 RVA: 0x004BC44C File Offset: 0x004BA64C
			public virtual AsyncUnaryCall<GetStateResponse> GetStateAsync(GetStateRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetStateRequest, GetStateResponse>(BlockListService.__Method_GetState, null, options, request);
			}

			// Token: 0x0600DA9E RID: 55966 RVA: 0x004BC474 File Offset: 0x004BA674
			public virtual NoData BlockPlayer(BlockPlayerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.BlockPlayer(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DA9F RID: 55967 RVA: 0x004BC49C File Offset: 0x004BA69C
			public virtual NoData BlockPlayer(BlockPlayerRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<BlockPlayerRequest, NoData>(BlockListService.__Method_BlockPlayer, null, options, request);
			}

			// Token: 0x0600DAA0 RID: 55968 RVA: 0x004BC4C4 File Offset: 0x004BA6C4
			public virtual AsyncUnaryCall<NoData> BlockPlayerAsync(BlockPlayerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.BlockPlayerAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DAA1 RID: 55969 RVA: 0x004BC4EC File Offset: 0x004BA6EC
			public virtual AsyncUnaryCall<NoData> BlockPlayerAsync(BlockPlayerRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<BlockPlayerRequest, NoData>(BlockListService.__Method_BlockPlayer, null, options, request);
			}

			// Token: 0x0600DAA2 RID: 55970 RVA: 0x004BC514 File Offset: 0x004BA714
			public virtual NoData UnblockPlayer(UnblockPlayerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UnblockPlayer(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DAA3 RID: 55971 RVA: 0x004BC53C File Offset: 0x004BA73C
			public virtual NoData UnblockPlayer(UnblockPlayerRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<UnblockPlayerRequest, NoData>(BlockListService.__Method_UnblockPlayer, null, options, request);
			}

			// Token: 0x0600DAA4 RID: 55972 RVA: 0x004BC564 File Offset: 0x004BA764
			public virtual AsyncUnaryCall<NoData> UnblockPlayerAsync(UnblockPlayerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UnblockPlayerAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DAA5 RID: 55973 RVA: 0x004BC58C File Offset: 0x004BA78C
			public virtual AsyncUnaryCall<NoData> UnblockPlayerAsync(UnblockPlayerRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<UnblockPlayerRequest, NoData>(BlockListService.__Method_UnblockPlayer, null, options, request);
			}

			// Token: 0x0600DAA6 RID: 55974 RVA: 0x004BC5B4 File Offset: 0x004BA7B4
			public virtual NoData BlockPlayerForSession(BlockPlayerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.BlockPlayerForSession(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DAA7 RID: 55975 RVA: 0x004BC5DC File Offset: 0x004BA7DC
			public virtual NoData BlockPlayerForSession(BlockPlayerRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<BlockPlayerRequest, NoData>(BlockListService.__Method_BlockPlayerForSession, null, options, request);
			}

			// Token: 0x0600DAA8 RID: 55976 RVA: 0x004BC604 File Offset: 0x004BA804
			public virtual AsyncUnaryCall<NoData> BlockPlayerForSessionAsync(BlockPlayerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.BlockPlayerForSessionAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DAA9 RID: 55977 RVA: 0x004BC62C File Offset: 0x004BA82C
			public virtual AsyncUnaryCall<NoData> BlockPlayerForSessionAsync(BlockPlayerRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<BlockPlayerRequest, NoData>(BlockListService.__Method_BlockPlayerForSession, null, options, request);
			}

			// Token: 0x0600DAAA RID: 55978 RVA: 0x004BC654 File Offset: 0x004BA854
			protected override BlockListService.BlockListServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new BlockListService.BlockListServiceClient(configuration);
			}
		}
	}
}
