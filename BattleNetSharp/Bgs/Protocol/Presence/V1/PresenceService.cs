using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Presence.V1
{
	// Token: 0x020005AA RID: 1450
	public static class PresenceService
	{
		// Token: 0x060089F8 RID: 35320 RVA: 0x00217E34 File Offset: 0x00216034
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

		// Token: 0x060089F9 RID: 35321 RVA: 0x00217E80 File Offset: 0x00216080
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

		// Token: 0x17002B5D RID: 11101
		// (get) Token: 0x060089FA RID: 35322 RVA: 0x00217EB8 File Offset: 0x002160B8
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return PresenceServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x060089FB RID: 35323 RVA: 0x00217EDC File Offset: 0x002160DC
		public static ServerServiceDefinition BindService(PresenceService.PresenceServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<SubscribeRequest, NoData>(PresenceService.__Method_Subscribe, new UnaryServerMethod<SubscribeRequest, NoData>(serviceImpl.Subscribe)).AddMethod<UnsubscribeRequest, NoData>(PresenceService.__Method_Unsubscribe, new UnaryServerMethod<UnsubscribeRequest, NoData>(serviceImpl.Unsubscribe))
				.AddMethod<UpdateRequest, NoData>(PresenceService.__Method_Update, new UnaryServerMethod<UpdateRequest, NoData>(serviceImpl.Update))
				.AddMethod<QueryRequest, QueryResponse>(PresenceService.__Method_Query, new UnaryServerMethod<QueryRequest, QueryResponse>(serviceImpl.Query))
				.AddMethod<OwnershipRequest, NoData>(PresenceService.__Method_Ownership, new UnaryServerMethod<OwnershipRequest, NoData>(serviceImpl.Ownership))
				.AddMethod<SubscribeNotificationRequest, NoData>(PresenceService.__Method_SubscribeNotification, new UnaryServerMethod<SubscribeNotificationRequest, NoData>(serviceImpl.SubscribeNotification))
				.AddMethod<BatchSubscribeRequest, BatchSubscribeResponse>(PresenceService.__Method_BatchSubscribe, new UnaryServerMethod<BatchSubscribeRequest, BatchSubscribeResponse>(serviceImpl.BatchSubscribe))
				.AddMethod<BatchUnsubscribeRequest, NoData>(PresenceService.__Method_BatchUnsubscribe, new UnaryServerMethod<BatchUnsubscribeRequest, NoData>(serviceImpl.BatchUnsubscribe))
				.Build();
		}

		// Token: 0x060089FC RID: 35324 RVA: 0x00217FB0 File Offset: 0x002161B0
		public static void BindService(ServiceBinderBase serviceBinder, PresenceService.PresenceServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<SubscribeRequest, NoData>(PresenceService.__Method_Subscribe, (serviceImpl == null) ? null : new UnaryServerMethod<SubscribeRequest, NoData>(serviceImpl.Subscribe));
			serviceBinder.AddMethod<UnsubscribeRequest, NoData>(PresenceService.__Method_Unsubscribe, (serviceImpl == null) ? null : new UnaryServerMethod<UnsubscribeRequest, NoData>(serviceImpl.Unsubscribe));
			serviceBinder.AddMethod<UpdateRequest, NoData>(PresenceService.__Method_Update, (serviceImpl == null) ? null : new UnaryServerMethod<UpdateRequest, NoData>(serviceImpl.Update));
			serviceBinder.AddMethod<QueryRequest, QueryResponse>(PresenceService.__Method_Query, (serviceImpl == null) ? null : new UnaryServerMethod<QueryRequest, QueryResponse>(serviceImpl.Query));
			serviceBinder.AddMethod<OwnershipRequest, NoData>(PresenceService.__Method_Ownership, (serviceImpl == null) ? null : new UnaryServerMethod<OwnershipRequest, NoData>(serviceImpl.Ownership));
			serviceBinder.AddMethod<SubscribeNotificationRequest, NoData>(PresenceService.__Method_SubscribeNotification, (serviceImpl == null) ? null : new UnaryServerMethod<SubscribeNotificationRequest, NoData>(serviceImpl.SubscribeNotification));
			serviceBinder.AddMethod<BatchSubscribeRequest, BatchSubscribeResponse>(PresenceService.__Method_BatchSubscribe, (serviceImpl == null) ? null : new UnaryServerMethod<BatchSubscribeRequest, BatchSubscribeResponse>(serviceImpl.BatchSubscribe));
			serviceBinder.AddMethod<BatchUnsubscribeRequest, NoData>(PresenceService.__Method_BatchUnsubscribe, (serviceImpl == null) ? null : new UnaryServerMethod<BatchUnsubscribeRequest, NoData>(serviceImpl.BatchUnsubscribe));
		}

		// Token: 0x04003E6A RID: 15978
		private static readonly string __ServiceName = "bgs.protocol.presence.v1.PresenceService";

		// Token: 0x04003E6B RID: 15979
		private static readonly Marshaller<SubscribeRequest> __Marshaller_bgs_protocol_presence_v1_SubscribeRequest = Marshallers.Create<SubscribeRequest>(new Action<SubscribeRequest, SerializationContext>(PresenceService.__Helper_SerializeMessage), (DeserializationContext context) => PresenceService.__Helper_DeserializeMessage<SubscribeRequest>(context, SubscribeRequest.Parser));

		// Token: 0x04003E6C RID: 15980
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(PresenceService.__Helper_SerializeMessage), (DeserializationContext context) => PresenceService.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x04003E6D RID: 15981
		private static readonly Marshaller<UnsubscribeRequest> __Marshaller_bgs_protocol_presence_v1_UnsubscribeRequest = Marshallers.Create<UnsubscribeRequest>(new Action<UnsubscribeRequest, SerializationContext>(PresenceService.__Helper_SerializeMessage), (DeserializationContext context) => PresenceService.__Helper_DeserializeMessage<UnsubscribeRequest>(context, UnsubscribeRequest.Parser));

		// Token: 0x04003E6E RID: 15982
		private static readonly Marshaller<UpdateRequest> __Marshaller_bgs_protocol_presence_v1_UpdateRequest = Marshallers.Create<UpdateRequest>(new Action<UpdateRequest, SerializationContext>(PresenceService.__Helper_SerializeMessage), (DeserializationContext context) => PresenceService.__Helper_DeserializeMessage<UpdateRequest>(context, UpdateRequest.Parser));

		// Token: 0x04003E6F RID: 15983
		private static readonly Marshaller<QueryRequest> __Marshaller_bgs_protocol_presence_v1_QueryRequest = Marshallers.Create<QueryRequest>(new Action<QueryRequest, SerializationContext>(PresenceService.__Helper_SerializeMessage), (DeserializationContext context) => PresenceService.__Helper_DeserializeMessage<QueryRequest>(context, QueryRequest.Parser));

		// Token: 0x04003E70 RID: 15984
		private static readonly Marshaller<QueryResponse> __Marshaller_bgs_protocol_presence_v1_QueryResponse = Marshallers.Create<QueryResponse>(new Action<QueryResponse, SerializationContext>(PresenceService.__Helper_SerializeMessage), (DeserializationContext context) => PresenceService.__Helper_DeserializeMessage<QueryResponse>(context, QueryResponse.Parser));

		// Token: 0x04003E71 RID: 15985
		private static readonly Marshaller<OwnershipRequest> __Marshaller_bgs_protocol_presence_v1_OwnershipRequest = Marshallers.Create<OwnershipRequest>(new Action<OwnershipRequest, SerializationContext>(PresenceService.__Helper_SerializeMessage), (DeserializationContext context) => PresenceService.__Helper_DeserializeMessage<OwnershipRequest>(context, OwnershipRequest.Parser));

		// Token: 0x04003E72 RID: 15986
		private static readonly Marshaller<SubscribeNotificationRequest> __Marshaller_bgs_protocol_presence_v1_SubscribeNotificationRequest = Marshallers.Create<SubscribeNotificationRequest>(new Action<SubscribeNotificationRequest, SerializationContext>(PresenceService.__Helper_SerializeMessage), (DeserializationContext context) => PresenceService.__Helper_DeserializeMessage<SubscribeNotificationRequest>(context, SubscribeNotificationRequest.Parser));

		// Token: 0x04003E73 RID: 15987
		private static readonly Marshaller<BatchSubscribeRequest> __Marshaller_bgs_protocol_presence_v1_BatchSubscribeRequest = Marshallers.Create<BatchSubscribeRequest>(new Action<BatchSubscribeRequest, SerializationContext>(PresenceService.__Helper_SerializeMessage), (DeserializationContext context) => PresenceService.__Helper_DeserializeMessage<BatchSubscribeRequest>(context, BatchSubscribeRequest.Parser));

		// Token: 0x04003E74 RID: 15988
		private static readonly Marshaller<BatchSubscribeResponse> __Marshaller_bgs_protocol_presence_v1_BatchSubscribeResponse = Marshallers.Create<BatchSubscribeResponse>(new Action<BatchSubscribeResponse, SerializationContext>(PresenceService.__Helper_SerializeMessage), (DeserializationContext context) => PresenceService.__Helper_DeserializeMessage<BatchSubscribeResponse>(context, BatchSubscribeResponse.Parser));

		// Token: 0x04003E75 RID: 15989
		private static readonly Marshaller<BatchUnsubscribeRequest> __Marshaller_bgs_protocol_presence_v1_BatchUnsubscribeRequest = Marshallers.Create<BatchUnsubscribeRequest>(new Action<BatchUnsubscribeRequest, SerializationContext>(PresenceService.__Helper_SerializeMessage), (DeserializationContext context) => PresenceService.__Helper_DeserializeMessage<BatchUnsubscribeRequest>(context, BatchUnsubscribeRequest.Parser));

		// Token: 0x04003E76 RID: 15990
		private static readonly Method<SubscribeRequest, NoData> __Method_Subscribe = new Method<SubscribeRequest, NoData>(0, PresenceService.__ServiceName, "Subscribe", PresenceService.__Marshaller_bgs_protocol_presence_v1_SubscribeRequest, PresenceService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04003E77 RID: 15991
		private static readonly Method<UnsubscribeRequest, NoData> __Method_Unsubscribe = new Method<UnsubscribeRequest, NoData>(0, PresenceService.__ServiceName, "Unsubscribe", PresenceService.__Marshaller_bgs_protocol_presence_v1_UnsubscribeRequest, PresenceService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04003E78 RID: 15992
		private static readonly Method<UpdateRequest, NoData> __Method_Update = new Method<UpdateRequest, NoData>(0, PresenceService.__ServiceName, "Update", PresenceService.__Marshaller_bgs_protocol_presence_v1_UpdateRequest, PresenceService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04003E79 RID: 15993
		private static readonly Method<QueryRequest, QueryResponse> __Method_Query = new Method<QueryRequest, QueryResponse>(0, PresenceService.__ServiceName, "Query", PresenceService.__Marshaller_bgs_protocol_presence_v1_QueryRequest, PresenceService.__Marshaller_bgs_protocol_presence_v1_QueryResponse);

		// Token: 0x04003E7A RID: 15994
		private static readonly Method<OwnershipRequest, NoData> __Method_Ownership = new Method<OwnershipRequest, NoData>(0, PresenceService.__ServiceName, "Ownership", PresenceService.__Marshaller_bgs_protocol_presence_v1_OwnershipRequest, PresenceService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04003E7B RID: 15995
		private static readonly Method<SubscribeNotificationRequest, NoData> __Method_SubscribeNotification = new Method<SubscribeNotificationRequest, NoData>(0, PresenceService.__ServiceName, "SubscribeNotification", PresenceService.__Marshaller_bgs_protocol_presence_v1_SubscribeNotificationRequest, PresenceService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04003E7C RID: 15996
		private static readonly Method<BatchSubscribeRequest, BatchSubscribeResponse> __Method_BatchSubscribe = new Method<BatchSubscribeRequest, BatchSubscribeResponse>(0, PresenceService.__ServiceName, "BatchSubscribe", PresenceService.__Marshaller_bgs_protocol_presence_v1_BatchSubscribeRequest, PresenceService.__Marshaller_bgs_protocol_presence_v1_BatchSubscribeResponse);

		// Token: 0x04003E7D RID: 15997
		private static readonly Method<BatchUnsubscribeRequest, NoData> __Method_BatchUnsubscribe = new Method<BatchUnsubscribeRequest, NoData>(0, PresenceService.__ServiceName, "BatchUnsubscribe", PresenceService.__Marshaller_bgs_protocol_presence_v1_BatchUnsubscribeRequest, PresenceService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x02001085 RID: 4229
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x040097D6 RID: 38870
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02001086 RID: 4230
		[BindServiceMethod(typeof(PresenceService), "BindService")]
		public abstract class PresenceServiceBase
		{
			// Token: 0x0600D28A RID: 53898 RVA: 0x004B2009 File Offset: 0x004B0209
			public virtual Task<NoData> Subscribe(SubscribeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D28B RID: 53899 RVA: 0x004B201D File Offset: 0x004B021D
			public virtual Task<NoData> Unsubscribe(UnsubscribeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D28C RID: 53900 RVA: 0x004B2031 File Offset: 0x004B0231
			public virtual Task<NoData> Update(UpdateRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D28D RID: 53901 RVA: 0x004B2045 File Offset: 0x004B0245
			public virtual Task<QueryResponse> Query(QueryRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D28E RID: 53902 RVA: 0x004B2059 File Offset: 0x004B0259
			public virtual Task<NoData> Ownership(OwnershipRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D28F RID: 53903 RVA: 0x004B206D File Offset: 0x004B026D
			public virtual Task<NoData> SubscribeNotification(SubscribeNotificationRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D290 RID: 53904 RVA: 0x004B2081 File Offset: 0x004B0281
			public virtual Task<BatchSubscribeResponse> BatchSubscribe(BatchSubscribeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D291 RID: 53905 RVA: 0x004B2095 File Offset: 0x004B0295
			public virtual Task<NoData> BatchUnsubscribe(BatchUnsubscribeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x02001087 RID: 4231
		public class PresenceServiceClient : ClientBase<PresenceService.PresenceServiceClient>
		{
			// Token: 0x0600D293 RID: 53907 RVA: 0x004B20B2 File Offset: 0x004B02B2
			public PresenceServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D294 RID: 53908 RVA: 0x004B20BD File Offset: 0x004B02BD
			public PresenceServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D295 RID: 53909 RVA: 0x004B20C8 File Offset: 0x004B02C8
			protected PresenceServiceClient()
			{
			}

			// Token: 0x0600D296 RID: 53910 RVA: 0x004B20D2 File Offset: 0x004B02D2
			protected PresenceServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D297 RID: 53911 RVA: 0x004B20E0 File Offset: 0x004B02E0
			public virtual NoData Subscribe(SubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Subscribe(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D298 RID: 53912 RVA: 0x004B2108 File Offset: 0x004B0308
			public virtual NoData Subscribe(SubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SubscribeRequest, NoData>(PresenceService.__Method_Subscribe, null, options, request);
			}

			// Token: 0x0600D299 RID: 53913 RVA: 0x004B2130 File Offset: 0x004B0330
			public virtual AsyncUnaryCall<NoData> SubscribeAsync(SubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SubscribeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D29A RID: 53914 RVA: 0x004B2158 File Offset: 0x004B0358
			public virtual AsyncUnaryCall<NoData> SubscribeAsync(SubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SubscribeRequest, NoData>(PresenceService.__Method_Subscribe, null, options, request);
			}

			// Token: 0x0600D29B RID: 53915 RVA: 0x004B2180 File Offset: 0x004B0380
			public virtual NoData Unsubscribe(UnsubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Unsubscribe(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D29C RID: 53916 RVA: 0x004B21A8 File Offset: 0x004B03A8
			public virtual NoData Unsubscribe(UnsubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<UnsubscribeRequest, NoData>(PresenceService.__Method_Unsubscribe, null, options, request);
			}

			// Token: 0x0600D29D RID: 53917 RVA: 0x004B21D0 File Offset: 0x004B03D0
			public virtual AsyncUnaryCall<NoData> UnsubscribeAsync(UnsubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UnsubscribeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D29E RID: 53918 RVA: 0x004B21F8 File Offset: 0x004B03F8
			public virtual AsyncUnaryCall<NoData> UnsubscribeAsync(UnsubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<UnsubscribeRequest, NoData>(PresenceService.__Method_Unsubscribe, null, options, request);
			}

			// Token: 0x0600D29F RID: 53919 RVA: 0x004B2220 File Offset: 0x004B0420
			public virtual NoData Update(UpdateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Update(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D2A0 RID: 53920 RVA: 0x004B2248 File Offset: 0x004B0448
			public virtual NoData Update(UpdateRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<UpdateRequest, NoData>(PresenceService.__Method_Update, null, options, request);
			}

			// Token: 0x0600D2A1 RID: 53921 RVA: 0x004B2270 File Offset: 0x004B0470
			public virtual AsyncUnaryCall<NoData> UpdateAsync(UpdateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UpdateAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D2A2 RID: 53922 RVA: 0x004B2298 File Offset: 0x004B0498
			public virtual AsyncUnaryCall<NoData> UpdateAsync(UpdateRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<UpdateRequest, NoData>(PresenceService.__Method_Update, null, options, request);
			}

			// Token: 0x0600D2A3 RID: 53923 RVA: 0x004B22C0 File Offset: 0x004B04C0
			public virtual QueryResponse Query(QueryRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Query(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D2A4 RID: 53924 RVA: 0x004B22E8 File Offset: 0x004B04E8
			public virtual QueryResponse Query(QueryRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<QueryRequest, QueryResponse>(PresenceService.__Method_Query, null, options, request);
			}

			// Token: 0x0600D2A5 RID: 53925 RVA: 0x004B2310 File Offset: 0x004B0510
			public virtual AsyncUnaryCall<QueryResponse> QueryAsync(QueryRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.QueryAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D2A6 RID: 53926 RVA: 0x004B2338 File Offset: 0x004B0538
			public virtual AsyncUnaryCall<QueryResponse> QueryAsync(QueryRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<QueryRequest, QueryResponse>(PresenceService.__Method_Query, null, options, request);
			}

			// Token: 0x0600D2A7 RID: 53927 RVA: 0x004B2360 File Offset: 0x004B0560
			public virtual NoData Ownership(OwnershipRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Ownership(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D2A8 RID: 53928 RVA: 0x004B2388 File Offset: 0x004B0588
			public virtual NoData Ownership(OwnershipRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<OwnershipRequest, NoData>(PresenceService.__Method_Ownership, null, options, request);
			}

			// Token: 0x0600D2A9 RID: 53929 RVA: 0x004B23B0 File Offset: 0x004B05B0
			public virtual AsyncUnaryCall<NoData> OwnershipAsync(OwnershipRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OwnershipAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D2AA RID: 53930 RVA: 0x004B23D8 File Offset: 0x004B05D8
			public virtual AsyncUnaryCall<NoData> OwnershipAsync(OwnershipRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<OwnershipRequest, NoData>(PresenceService.__Method_Ownership, null, options, request);
			}

			// Token: 0x0600D2AB RID: 53931 RVA: 0x004B2400 File Offset: 0x004B0600
			public virtual NoData SubscribeNotification(SubscribeNotificationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SubscribeNotification(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D2AC RID: 53932 RVA: 0x004B2428 File Offset: 0x004B0628
			public virtual NoData SubscribeNotification(SubscribeNotificationRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SubscribeNotificationRequest, NoData>(PresenceService.__Method_SubscribeNotification, null, options, request);
			}

			// Token: 0x0600D2AD RID: 53933 RVA: 0x004B2450 File Offset: 0x004B0650
			public virtual AsyncUnaryCall<NoData> SubscribeNotificationAsync(SubscribeNotificationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SubscribeNotificationAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D2AE RID: 53934 RVA: 0x004B2478 File Offset: 0x004B0678
			public virtual AsyncUnaryCall<NoData> SubscribeNotificationAsync(SubscribeNotificationRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SubscribeNotificationRequest, NoData>(PresenceService.__Method_SubscribeNotification, null, options, request);
			}

			// Token: 0x0600D2AF RID: 53935 RVA: 0x004B24A0 File Offset: 0x004B06A0
			public virtual BatchSubscribeResponse BatchSubscribe(BatchSubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.BatchSubscribe(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D2B0 RID: 53936 RVA: 0x004B24C8 File Offset: 0x004B06C8
			public virtual BatchSubscribeResponse BatchSubscribe(BatchSubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<BatchSubscribeRequest, BatchSubscribeResponse>(PresenceService.__Method_BatchSubscribe, null, options, request);
			}

			// Token: 0x0600D2B1 RID: 53937 RVA: 0x004B24F0 File Offset: 0x004B06F0
			public virtual AsyncUnaryCall<BatchSubscribeResponse> BatchSubscribeAsync(BatchSubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.BatchSubscribeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D2B2 RID: 53938 RVA: 0x004B2518 File Offset: 0x004B0718
			public virtual AsyncUnaryCall<BatchSubscribeResponse> BatchSubscribeAsync(BatchSubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<BatchSubscribeRequest, BatchSubscribeResponse>(PresenceService.__Method_BatchSubscribe, null, options, request);
			}

			// Token: 0x0600D2B3 RID: 53939 RVA: 0x004B2540 File Offset: 0x004B0740
			public virtual NoData BatchUnsubscribe(BatchUnsubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.BatchUnsubscribe(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D2B4 RID: 53940 RVA: 0x004B2568 File Offset: 0x004B0768
			public virtual NoData BatchUnsubscribe(BatchUnsubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<BatchUnsubscribeRequest, NoData>(PresenceService.__Method_BatchUnsubscribe, null, options, request);
			}

			// Token: 0x0600D2B5 RID: 53941 RVA: 0x004B2590 File Offset: 0x004B0790
			public virtual AsyncUnaryCall<NoData> BatchUnsubscribeAsync(BatchUnsubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.BatchUnsubscribeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D2B6 RID: 53942 RVA: 0x004B25B8 File Offset: 0x004B07B8
			public virtual AsyncUnaryCall<NoData> BatchUnsubscribeAsync(BatchUnsubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<BatchUnsubscribeRequest, NoData>(PresenceService.__Method_BatchUnsubscribe, null, options, request);
			}

			// Token: 0x0600D2B7 RID: 53943 RVA: 0x004B25E0 File Offset: 0x004B07E0
			protected override PresenceService.PresenceServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new PresenceService.PresenceServiceClient(configuration);
			}
		}
	}
}
