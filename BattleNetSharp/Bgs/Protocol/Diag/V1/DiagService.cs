using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Diag.V1
{
	// Token: 0x02000428 RID: 1064
	public static class DiagService
	{
		// Token: 0x060068D8 RID: 26840 RVA: 0x0019594C File Offset: 0x00193B4C
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

		// Token: 0x060068D9 RID: 26841 RVA: 0x00195998 File Offset: 0x00193B98
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = DiagService.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17002184 RID: 8580
		// (get) Token: 0x060068DA RID: 26842 RVA: 0x001959D0 File Offset: 0x00193BD0
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return DiagServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x060068DB RID: 26843 RVA: 0x001959F4 File Offset: 0x00193BF4
		public static ServerServiceDefinition BindService(DiagService.DiagServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<GetVarRequest, GetVarResponse>(DiagService.__Method_GetVar, new UnaryServerMethod<GetVarRequest, GetVarResponse>(serviceImpl.GetVar)).AddMethod<SetVarRequest, NoData>(DiagService.__Method_SetVar, new UnaryServerMethod<SetVarRequest, NoData>(serviceImpl.SetVar))
				.AddMethod<QueryRequest, QueryResponse>(DiagService.__Method_Query, new UnaryServerMethod<QueryRequest, QueryResponse>(serviceImpl.Query))
				.Build();
		}

		// Token: 0x060068DC RID: 26844 RVA: 0x00195A58 File Offset: 0x00193C58
		public static void BindService(ServiceBinderBase serviceBinder, DiagService.DiagServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<GetVarRequest, GetVarResponse>(DiagService.__Method_GetVar, (serviceImpl == null) ? null : new UnaryServerMethod<GetVarRequest, GetVarResponse>(serviceImpl.GetVar));
			serviceBinder.AddMethod<SetVarRequest, NoData>(DiagService.__Method_SetVar, (serviceImpl == null) ? null : new UnaryServerMethod<SetVarRequest, NoData>(serviceImpl.SetVar));
			serviceBinder.AddMethod<QueryRequest, QueryResponse>(DiagService.__Method_Query, (serviceImpl == null) ? null : new UnaryServerMethod<QueryRequest, QueryResponse>(serviceImpl.Query));
		}

		// Token: 0x04002FB2 RID: 12210
		private static readonly string __ServiceName = "bgs.protocol.diag.v1.DiagService";

		// Token: 0x04002FB3 RID: 12211
		private static readonly Marshaller<GetVarRequest> __Marshaller_bgs_protocol_diag_v1_GetVarRequest = Marshallers.Create<GetVarRequest>(new Action<GetVarRequest, SerializationContext>(DiagService.__Helper_SerializeMessage), (DeserializationContext context) => DiagService.__Helper_DeserializeMessage<GetVarRequest>(context, GetVarRequest.Parser));

		// Token: 0x04002FB4 RID: 12212
		private static readonly Marshaller<GetVarResponse> __Marshaller_bgs_protocol_diag_v1_GetVarResponse = Marshallers.Create<GetVarResponse>(new Action<GetVarResponse, SerializationContext>(DiagService.__Helper_SerializeMessage), (DeserializationContext context) => DiagService.__Helper_DeserializeMessage<GetVarResponse>(context, GetVarResponse.Parser));

		// Token: 0x04002FB5 RID: 12213
		private static readonly Marshaller<SetVarRequest> __Marshaller_bgs_protocol_diag_v1_SetVarRequest = Marshallers.Create<SetVarRequest>(new Action<SetVarRequest, SerializationContext>(DiagService.__Helper_SerializeMessage), (DeserializationContext context) => DiagService.__Helper_DeserializeMessage<SetVarRequest>(context, SetVarRequest.Parser));

		// Token: 0x04002FB6 RID: 12214
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(DiagService.__Helper_SerializeMessage), (DeserializationContext context) => DiagService.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x04002FB7 RID: 12215
		private static readonly Marshaller<QueryRequest> __Marshaller_bgs_protocol_diag_v1_QueryRequest = Marshallers.Create<QueryRequest>(new Action<QueryRequest, SerializationContext>(DiagService.__Helper_SerializeMessage), (DeserializationContext context) => DiagService.__Helper_DeserializeMessage<QueryRequest>(context, QueryRequest.Parser));

		// Token: 0x04002FB8 RID: 12216
		private static readonly Marshaller<QueryResponse> __Marshaller_bgs_protocol_diag_v1_QueryResponse = Marshallers.Create<QueryResponse>(new Action<QueryResponse, SerializationContext>(DiagService.__Helper_SerializeMessage), (DeserializationContext context) => DiagService.__Helper_DeserializeMessage<QueryResponse>(context, QueryResponse.Parser));

		// Token: 0x04002FB9 RID: 12217
		private static readonly Method<GetVarRequest, GetVarResponse> __Method_GetVar = new Method<GetVarRequest, GetVarResponse>(0, DiagService.__ServiceName, "GetVar", DiagService.__Marshaller_bgs_protocol_diag_v1_GetVarRequest, DiagService.__Marshaller_bgs_protocol_diag_v1_GetVarResponse);

		// Token: 0x04002FBA RID: 12218
		private static readonly Method<SetVarRequest, NoData> __Method_SetVar = new Method<SetVarRequest, NoData>(0, DiagService.__ServiceName, "SetVar", DiagService.__Marshaller_bgs_protocol_diag_v1_SetVarRequest, DiagService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04002FBB RID: 12219
		private static readonly Method<QueryRequest, QueryResponse> __Method_Query = new Method<QueryRequest, QueryResponse>(0, DiagService.__ServiceName, "Query", DiagService.__Marshaller_bgs_protocol_diag_v1_QueryRequest, DiagService.__Marshaller_bgs_protocol_diag_v1_QueryResponse);

		// Token: 0x02000F06 RID: 3846
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x04009661 RID: 38497
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02000F07 RID: 3847
		[BindServiceMethod(typeof(DiagService), "BindService")]
		public abstract class DiagServiceBase
		{
			// Token: 0x0600CCBA RID: 52410 RVA: 0x004AC59C File Offset: 0x004AA79C
			public virtual Task<GetVarResponse> GetVar(GetVarRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CCBB RID: 52411 RVA: 0x004AC5B0 File Offset: 0x004AA7B0
			public virtual Task<NoData> SetVar(SetVarRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CCBC RID: 52412 RVA: 0x004AC5C4 File Offset: 0x004AA7C4
			public virtual Task<QueryResponse> Query(QueryRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x02000F08 RID: 3848
		public class DiagServiceClient : ClientBase<DiagService.DiagServiceClient>
		{
			// Token: 0x0600CCBE RID: 52414 RVA: 0x004AC5E1 File Offset: 0x004AA7E1
			public DiagServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600CCBF RID: 52415 RVA: 0x004AC5EC File Offset: 0x004AA7EC
			public DiagServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600CCC0 RID: 52416 RVA: 0x004AC5F7 File Offset: 0x004AA7F7
			protected DiagServiceClient()
			{
			}

			// Token: 0x0600CCC1 RID: 52417 RVA: 0x004AC601 File Offset: 0x004AA801
			protected DiagServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600CCC2 RID: 52418 RVA: 0x004AC60C File Offset: 0x004AA80C
			public virtual GetVarResponse GetVar(GetVarRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetVar(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CCC3 RID: 52419 RVA: 0x004AC634 File Offset: 0x004AA834
			public virtual GetVarResponse GetVar(GetVarRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetVarRequest, GetVarResponse>(DiagService.__Method_GetVar, null, options, request);
			}

			// Token: 0x0600CCC4 RID: 52420 RVA: 0x004AC65C File Offset: 0x004AA85C
			public virtual AsyncUnaryCall<GetVarResponse> GetVarAsync(GetVarRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetVarAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CCC5 RID: 52421 RVA: 0x004AC684 File Offset: 0x004AA884
			public virtual AsyncUnaryCall<GetVarResponse> GetVarAsync(GetVarRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetVarRequest, GetVarResponse>(DiagService.__Method_GetVar, null, options, request);
			}

			// Token: 0x0600CCC6 RID: 52422 RVA: 0x004AC6AC File Offset: 0x004AA8AC
			public virtual NoData SetVar(SetVarRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SetVar(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CCC7 RID: 52423 RVA: 0x004AC6D4 File Offset: 0x004AA8D4
			public virtual NoData SetVar(SetVarRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SetVarRequest, NoData>(DiagService.__Method_SetVar, null, options, request);
			}

			// Token: 0x0600CCC8 RID: 52424 RVA: 0x004AC6FC File Offset: 0x004AA8FC
			public virtual AsyncUnaryCall<NoData> SetVarAsync(SetVarRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SetVarAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CCC9 RID: 52425 RVA: 0x004AC724 File Offset: 0x004AA924
			public virtual AsyncUnaryCall<NoData> SetVarAsync(SetVarRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SetVarRequest, NoData>(DiagService.__Method_SetVar, null, options, request);
			}

			// Token: 0x0600CCCA RID: 52426 RVA: 0x004AC74C File Offset: 0x004AA94C
			public virtual QueryResponse Query(QueryRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Query(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CCCB RID: 52427 RVA: 0x004AC774 File Offset: 0x004AA974
			public virtual QueryResponse Query(QueryRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<QueryRequest, QueryResponse>(DiagService.__Method_Query, null, options, request);
			}

			// Token: 0x0600CCCC RID: 52428 RVA: 0x004AC79C File Offset: 0x004AA99C
			public virtual AsyncUnaryCall<QueryResponse> QueryAsync(QueryRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.QueryAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CCCD RID: 52429 RVA: 0x004AC7C4 File Offset: 0x004AA9C4
			public virtual AsyncUnaryCall<QueryResponse> QueryAsync(QueryRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<QueryRequest, QueryResponse>(DiagService.__Method_Query, null, options, request);
			}

			// Token: 0x0600CCCE RID: 52430 RVA: 0x004AC7EC File Offset: 0x004AA9EC
			protected override DiagService.DiagServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new DiagService.DiagServiceClient(configuration);
			}
		}
	}
}
