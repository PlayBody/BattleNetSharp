using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Presence.V2.Client
{
	// Token: 0x020005C8 RID: 1480
	public static class PresenceService
	{
		// Token: 0x06008C1B RID: 35867 RVA: 0x0021FAF8 File Offset: 0x0021DCF8
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

		// Token: 0x06008C1C RID: 35868 RVA: 0x0021FB44 File Offset: 0x0021DD44
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = PresenceService.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17002BF7 RID: 11255
		// (get) Token: 0x06008C1D RID: 35869 RVA: 0x0021FB7C File Offset: 0x0021DD7C
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return PresenceServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x06008C1E RID: 35870 RVA: 0x0021FBA0 File Offset: 0x0021DDA0
		public static ServerServiceDefinition BindService(PresenceService.PresenceServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<BatchSubscribeRequest, NoData>(PresenceService.__Method_BatchSubscribe, new UnaryServerMethod<BatchSubscribeRequest, NoData>(serviceImpl.BatchSubscribe)).AddMethod<BatchUnsubscribeRequest, NoData>(PresenceService.__Method_BatchUnsubscribe, new UnaryServerMethod<BatchUnsubscribeRequest, NoData>(serviceImpl.BatchUnsubscribe))
				.AddMethod<QueryRequest, QueryResponse>(PresenceService.__Method_Query, new UnaryServerMethod<QueryRequest, QueryResponse>(serviceImpl.Query))
				.AddMethod<UpdateRequest, NoData>(PresenceService.__Method_Update, new UnaryServerMethod<UpdateRequest, NoData>(serviceImpl.Update))
				.AddMethod<UpdateRequest, NoData>(PresenceService.__Method_Unk, new UnaryServerMethod<UpdateRequest, NoData>(serviceImpl.Unk))
				.Build();
		}

		// Token: 0x06008C1F RID: 35871 RVA: 0x0021FC30 File Offset: 0x0021DE30
		public static void BindService(ServiceBinderBase serviceBinder, PresenceService.PresenceServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<BatchSubscribeRequest, NoData>(PresenceService.__Method_BatchSubscribe, (serviceImpl == null) ? null : new UnaryServerMethod<BatchSubscribeRequest, NoData>(serviceImpl.BatchSubscribe));
			serviceBinder.AddMethod<BatchUnsubscribeRequest, NoData>(PresenceService.__Method_BatchUnsubscribe, (serviceImpl == null) ? null : new UnaryServerMethod<BatchUnsubscribeRequest, NoData>(serviceImpl.BatchUnsubscribe));
			serviceBinder.AddMethod<QueryRequest, QueryResponse>(PresenceService.__Method_Query, (serviceImpl == null) ? null : new UnaryServerMethod<QueryRequest, QueryResponse>(serviceImpl.Query));
			serviceBinder.AddMethod<UpdateRequest, NoData>(PresenceService.__Method_Update, (serviceImpl == null) ? null : new UnaryServerMethod<UpdateRequest, NoData>(serviceImpl.Update));
			serviceBinder.AddMethod<UpdateRequest, NoData>(PresenceService.__Method_Unk, (serviceImpl == null) ? null : new UnaryServerMethod<UpdateRequest, NoData>(serviceImpl.Unk));
		}

		// Token: 0x04003F5B RID: 16219
		private static readonly string __ServiceName = "bgs.protocol.presence.v2.client.PresenceService";

		// Token: 0x04003F5C RID: 16220
		private static readonly Marshaller<BatchSubscribeRequest> __Marshaller_bgs_protocol_presence_v2_client_BatchSubscribeRequest = Marshallers.Create<BatchSubscribeRequest>(new Action<BatchSubscribeRequest, SerializationContext>(PresenceService.__Helper_SerializeMessage), (DeserializationContext context) => PresenceService.__Helper_DeserializeMessage<BatchSubscribeRequest>(context, BatchSubscribeRequest.Parser));

		// Token: 0x04003F5D RID: 16221
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(PresenceService.__Helper_SerializeMessage), (DeserializationContext context) => PresenceService.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x04003F5E RID: 16222
		private static readonly Marshaller<BatchUnsubscribeRequest> __Marshaller_bgs_protocol_presence_v2_client_BatchUnsubscribeRequest = Marshallers.Create<BatchUnsubscribeRequest>(new Action<BatchUnsubscribeRequest, SerializationContext>(PresenceService.__Helper_SerializeMessage), (DeserializationContext context) => PresenceService.__Helper_DeserializeMessage<BatchUnsubscribeRequest>(context, BatchUnsubscribeRequest.Parser));

		// Token: 0x04003F5F RID: 16223
		private static readonly Marshaller<QueryRequest> __Marshaller_bgs_protocol_presence_v2_client_QueryRequest = Marshallers.Create<QueryRequest>(new Action<QueryRequest, SerializationContext>(PresenceService.__Helper_SerializeMessage), (DeserializationContext context) => PresenceService.__Helper_DeserializeMessage<QueryRequest>(context, QueryRequest.Parser));

		// Token: 0x04003F60 RID: 16224
		private static readonly Marshaller<QueryResponse> __Marshaller_bgs_protocol_presence_v2_client_QueryResponse = Marshallers.Create<QueryResponse>(new Action<QueryResponse, SerializationContext>(PresenceService.__Helper_SerializeMessage), (DeserializationContext context) => PresenceService.__Helper_DeserializeMessage<QueryResponse>(context, QueryResponse.Parser));

		// Token: 0x04003F61 RID: 16225
		private static readonly Marshaller<UpdateRequest> __Marshaller_bgs_protocol_presence_v2_client_UpdateRequest = Marshallers.Create<UpdateRequest>(new Action<UpdateRequest, SerializationContext>(PresenceService.__Helper_SerializeMessage), (DeserializationContext context) => PresenceService.__Helper_DeserializeMessage<UpdateRequest>(context, UpdateRequest.Parser));

		// Token: 0x04003F62 RID: 16226
		private static readonly Method<BatchSubscribeRequest, NoData> __Method_BatchSubscribe = new Method<BatchSubscribeRequest, NoData>(0, PresenceService.__ServiceName, "BatchSubscribe", PresenceService.__Marshaller_bgs_protocol_presence_v2_client_BatchSubscribeRequest, PresenceService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04003F63 RID: 16227
		private static readonly Method<BatchUnsubscribeRequest, NoData> __Method_BatchUnsubscribe = new Method<BatchUnsubscribeRequest, NoData>(0, PresenceService.__ServiceName, "BatchUnsubscribe", PresenceService.__Marshaller_bgs_protocol_presence_v2_client_BatchUnsubscribeRequest, PresenceService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04003F64 RID: 16228
		private static readonly Method<QueryRequest, QueryResponse> __Method_Query = new Method<QueryRequest, QueryResponse>(0, PresenceService.__ServiceName, "Query", PresenceService.__Marshaller_bgs_protocol_presence_v2_client_QueryRequest, PresenceService.__Marshaller_bgs_protocol_presence_v2_client_QueryResponse);

		// Token: 0x04003F65 RID: 16229
		private static readonly Method<UpdateRequest, NoData> __Method_Update = new Method<UpdateRequest, NoData>(0, PresenceService.__ServiceName, "Update", PresenceService.__Marshaller_bgs_protocol_presence_v2_client_UpdateRequest, PresenceService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04003F66 RID: 16230
		private static readonly Method<UpdateRequest, NoData> __Method_Unk = new Method<UpdateRequest, NoData>(0, PresenceService.__ServiceName, "Unk", PresenceService.__Marshaller_bgs_protocol_presence_v2_client_UpdateRequest, PresenceService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x020010A5 RID: 4261
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x040097F1 RID: 38897
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x020010A6 RID: 4262
		[BindServiceMethod(typeof(PresenceService), "BindService")]
		public abstract class PresenceServiceBase
		{
			// Token: 0x0600D31F RID: 54047 RVA: 0x004B2B5D File Offset: 0x004B0D5D
			public virtual Task<NoData> BatchSubscribe(BatchSubscribeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D320 RID: 54048 RVA: 0x004B2B71 File Offset: 0x004B0D71
			public virtual Task<NoData> BatchUnsubscribe(BatchUnsubscribeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D321 RID: 54049 RVA: 0x004B2B85 File Offset: 0x004B0D85
			public virtual Task<QueryResponse> Query(QueryRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D322 RID: 54050 RVA: 0x004B2B99 File Offset: 0x004B0D99
			public virtual Task<NoData> Update(UpdateRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D323 RID: 54051 RVA: 0x004B2BAD File Offset: 0x004B0DAD
			public virtual Task<NoData> Unk(UpdateRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x020010A7 RID: 4263
		public class PresenceServiceClient : ClientBase<PresenceService.PresenceServiceClient>
		{
			// Token: 0x0600D325 RID: 54053 RVA: 0x004B2BCA File Offset: 0x004B0DCA
			public PresenceServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D326 RID: 54054 RVA: 0x004B2BD5 File Offset: 0x004B0DD5
			public PresenceServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D327 RID: 54055 RVA: 0x004B2BE0 File Offset: 0x004B0DE0
			protected PresenceServiceClient()
			{
			}

			// Token: 0x0600D328 RID: 54056 RVA: 0x004B2BEA File Offset: 0x004B0DEA
			protected PresenceServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D329 RID: 54057 RVA: 0x004B2BF8 File Offset: 0x004B0DF8
			public virtual NoData BatchSubscribe(BatchSubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.BatchSubscribe(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D32A RID: 54058 RVA: 0x004B2C20 File Offset: 0x004B0E20
			public virtual NoData BatchSubscribe(BatchSubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<BatchSubscribeRequest, NoData>(PresenceService.__Method_BatchSubscribe, null, options, request);
			}

			// Token: 0x0600D32B RID: 54059 RVA: 0x004B2C48 File Offset: 0x004B0E48
			public virtual AsyncUnaryCall<NoData> BatchSubscribeAsync(BatchSubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.BatchSubscribeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D32C RID: 54060 RVA: 0x004B2C70 File Offset: 0x004B0E70
			public virtual AsyncUnaryCall<NoData> BatchSubscribeAsync(BatchSubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<BatchSubscribeRequest, NoData>(PresenceService.__Method_BatchSubscribe, null, options, request);
			}

			// Token: 0x0600D32D RID: 54061 RVA: 0x004B2C98 File Offset: 0x004B0E98
			public virtual NoData BatchUnsubscribe(BatchUnsubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.BatchUnsubscribe(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D32E RID: 54062 RVA: 0x004B2CC0 File Offset: 0x004B0EC0
			public virtual NoData BatchUnsubscribe(BatchUnsubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<BatchUnsubscribeRequest, NoData>(PresenceService.__Method_BatchUnsubscribe, null, options, request);
			}

			// Token: 0x0600D32F RID: 54063 RVA: 0x004B2CE8 File Offset: 0x004B0EE8
			public virtual AsyncUnaryCall<NoData> BatchUnsubscribeAsync(BatchUnsubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.BatchUnsubscribeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D330 RID: 54064 RVA: 0x004B2D10 File Offset: 0x004B0F10
			public virtual AsyncUnaryCall<NoData> BatchUnsubscribeAsync(BatchUnsubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<BatchUnsubscribeRequest, NoData>(PresenceService.__Method_BatchUnsubscribe, null, options, request);
			}

			// Token: 0x0600D331 RID: 54065 RVA: 0x004B2D38 File Offset: 0x004B0F38
			public virtual QueryResponse Query(QueryRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Query(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D332 RID: 54066 RVA: 0x004B2D60 File Offset: 0x004B0F60
			public virtual QueryResponse Query(QueryRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<QueryRequest, QueryResponse>(PresenceService.__Method_Query, null, options, request);
			}

			// Token: 0x0600D333 RID: 54067 RVA: 0x004B2D88 File Offset: 0x004B0F88
			public virtual AsyncUnaryCall<QueryResponse> QueryAsync(QueryRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.QueryAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D334 RID: 54068 RVA: 0x004B2DB0 File Offset: 0x004B0FB0
			public virtual AsyncUnaryCall<QueryResponse> QueryAsync(QueryRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<QueryRequest, QueryResponse>(PresenceService.__Method_Query, null, options, request);
			}

			// Token: 0x0600D335 RID: 54069 RVA: 0x004B2DD8 File Offset: 0x004B0FD8
			public virtual NoData Update(UpdateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Update(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D336 RID: 54070 RVA: 0x004B2E00 File Offset: 0x004B1000
			public virtual NoData Update(UpdateRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<UpdateRequest, NoData>(PresenceService.__Method_Update, null, options, request);
			}

			// Token: 0x0600D337 RID: 54071 RVA: 0x004B2E28 File Offset: 0x004B1028
			public virtual AsyncUnaryCall<NoData> UpdateAsync(UpdateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UpdateAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D338 RID: 54072 RVA: 0x004B2E50 File Offset: 0x004B1050
			public virtual AsyncUnaryCall<NoData> UpdateAsync(UpdateRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<UpdateRequest, NoData>(PresenceService.__Method_Update, null, options, request);
			}

			// Token: 0x0600D339 RID: 54073 RVA: 0x004B2E78 File Offset: 0x004B1078
			public virtual NoData Unk(UpdateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Unk(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D33A RID: 54074 RVA: 0x004B2EA0 File Offset: 0x004B10A0
			public virtual NoData Unk(UpdateRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<UpdateRequest, NoData>(PresenceService.__Method_Unk, null, options, request);
			}

			// Token: 0x0600D33B RID: 54075 RVA: 0x004B2EC8 File Offset: 0x004B10C8
			public virtual AsyncUnaryCall<NoData> UnkAsync(UpdateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UnkAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D33C RID: 54076 RVA: 0x004B2EF0 File Offset: 0x004B10F0
			public virtual AsyncUnaryCall<NoData> UnkAsync(UpdateRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<UpdateRequest, NoData>(PresenceService.__Method_Unk, null, options, request);
			}

			// Token: 0x0600D33D RID: 54077 RVA: 0x004B2F18 File Offset: 0x004B1118
			protected override PresenceService.PresenceServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new PresenceService.PresenceServiceClient(configuration);
			}
		}
	}
}
