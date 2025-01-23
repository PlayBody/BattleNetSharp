using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.GameUtilities.V2.Client
{
	// Token: 0x02000603 RID: 1539
	public static class GameUtilitiesService
	{
		// Token: 0x06009004 RID: 36868 RVA: 0x0022E9A8 File Offset: 0x0022CBA8
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

		// Token: 0x06009005 RID: 36869 RVA: 0x0022E9F4 File Offset: 0x0022CBF4
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = GameUtilitiesService.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17002D04 RID: 11524
		// (get) Token: 0x06009006 RID: 36870 RVA: 0x0022EA2C File Offset: 0x0022CC2C
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x06009007 RID: 36871 RVA: 0x0022EA50 File Offset: 0x0022CC50
		public static ServerServiceDefinition BindService(GameUtilitiesService.GameUtilitiesServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<ProcessTaskRequest, ProcessTaskResponse>(GameUtilitiesService.__Method_ProcessTask, new UnaryServerMethod<ProcessTaskRequest, ProcessTaskResponse>(serviceImpl.ProcessTask)).AddMethod<GetAllValuesForAttributeRequest, GetAllValuesForAttributeResponse>(GameUtilitiesService.__Method_GetAllValuesForAttribute, new UnaryServerMethod<GetAllValuesForAttributeRequest, GetAllValuesForAttributeResponse>(serviceImpl.GetAllValuesForAttribute))
				.Build();
		}

		// Token: 0x06009008 RID: 36872 RVA: 0x0022EA9C File Offset: 0x0022CC9C
		public static void BindService(ServiceBinderBase serviceBinder, GameUtilitiesService.GameUtilitiesServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<ProcessTaskRequest, ProcessTaskResponse>(GameUtilitiesService.__Method_ProcessTask, (serviceImpl == null) ? null : new UnaryServerMethod<ProcessTaskRequest, ProcessTaskResponse>(serviceImpl.ProcessTask));
			serviceBinder.AddMethod<GetAllValuesForAttributeRequest, GetAllValuesForAttributeResponse>(GameUtilitiesService.__Method_GetAllValuesForAttribute, (serviceImpl == null) ? null : new UnaryServerMethod<GetAllValuesForAttributeRequest, GetAllValuesForAttributeResponse>(serviceImpl.GetAllValuesForAttribute));
		}

		// Token: 0x04004101 RID: 16641
		private static readonly string __ServiceName = "bgs.protocol.game_utilities.v2.client.GameUtilitiesService";

		// Token: 0x04004102 RID: 16642
		private static readonly Marshaller<ProcessTaskRequest> __Marshaller_bgs_protocol_game_utilities_v2_client_ProcessTaskRequest = Marshallers.Create<ProcessTaskRequest>(new Action<ProcessTaskRequest, SerializationContext>(GameUtilitiesService.__Helper_SerializeMessage), (DeserializationContext context) => GameUtilitiesService.__Helper_DeserializeMessage<ProcessTaskRequest>(context, ProcessTaskRequest.Parser));

		// Token: 0x04004103 RID: 16643
		private static readonly Marshaller<ProcessTaskResponse> __Marshaller_bgs_protocol_game_utilities_v2_client_ProcessTaskResponse = Marshallers.Create<ProcessTaskResponse>(new Action<ProcessTaskResponse, SerializationContext>(GameUtilitiesService.__Helper_SerializeMessage), (DeserializationContext context) => GameUtilitiesService.__Helper_DeserializeMessage<ProcessTaskResponse>(context, ProcessTaskResponse.Parser));

		// Token: 0x04004104 RID: 16644
		private static readonly Marshaller<GetAllValuesForAttributeRequest> __Marshaller_bgs_protocol_game_utilities_v2_client_GetAllValuesForAttributeRequest = Marshallers.Create<GetAllValuesForAttributeRequest>(new Action<GetAllValuesForAttributeRequest, SerializationContext>(GameUtilitiesService.__Helper_SerializeMessage), (DeserializationContext context) => GameUtilitiesService.__Helper_DeserializeMessage<GetAllValuesForAttributeRequest>(context, GetAllValuesForAttributeRequest.Parser));

		// Token: 0x04004105 RID: 16645
		private static readonly Marshaller<GetAllValuesForAttributeResponse> __Marshaller_bgs_protocol_game_utilities_v2_client_GetAllValuesForAttributeResponse = Marshallers.Create<GetAllValuesForAttributeResponse>(new Action<GetAllValuesForAttributeResponse, SerializationContext>(GameUtilitiesService.__Helper_SerializeMessage), (DeserializationContext context) => GameUtilitiesService.__Helper_DeserializeMessage<GetAllValuesForAttributeResponse>(context, GetAllValuesForAttributeResponse.Parser));

		// Token: 0x04004106 RID: 16646
		private static readonly Method<ProcessTaskRequest, ProcessTaskResponse> __Method_ProcessTask = new Method<ProcessTaskRequest, ProcessTaskResponse>(0, GameUtilitiesService.__ServiceName, "ProcessTask", GameUtilitiesService.__Marshaller_bgs_protocol_game_utilities_v2_client_ProcessTaskRequest, GameUtilitiesService.__Marshaller_bgs_protocol_game_utilities_v2_client_ProcessTaskResponse);

		// Token: 0x04004107 RID: 16647
		private static readonly Method<GetAllValuesForAttributeRequest, GetAllValuesForAttributeResponse> __Method_GetAllValuesForAttribute = new Method<GetAllValuesForAttributeRequest, GetAllValuesForAttributeResponse>(0, GameUtilitiesService.__ServiceName, "GetAllValuesForAttribute", GameUtilitiesService.__Marshaller_bgs_protocol_game_utilities_v2_client_GetAllValuesForAttributeRequest, GameUtilitiesService.__Marshaller_bgs_protocol_game_utilities_v2_client_GetAllValuesForAttributeResponse);

		// Token: 0x020010EC RID: 4332
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x0400982D RID: 38957
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x020010ED RID: 4333
		[BindServiceMethod(typeof(GameUtilitiesService), "BindService")]
		public abstract class GameUtilitiesServiceBase
		{
			// Token: 0x0600D475 RID: 54389 RVA: 0x004B45C0 File Offset: 0x004B27C0
			public virtual Task<ProcessTaskResponse> ProcessTask(ProcessTaskRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D476 RID: 54390 RVA: 0x004B45D4 File Offset: 0x004B27D4
			public virtual Task<GetAllValuesForAttributeResponse> GetAllValuesForAttribute(GetAllValuesForAttributeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x020010EE RID: 4334
		public class GameUtilitiesServiceClient : ClientBase<GameUtilitiesService.GameUtilitiesServiceClient>
		{
			// Token: 0x0600D478 RID: 54392 RVA: 0x004B45F1 File Offset: 0x004B27F1
			public GameUtilitiesServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D479 RID: 54393 RVA: 0x004B45FC File Offset: 0x004B27FC
			public GameUtilitiesServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D47A RID: 54394 RVA: 0x004B4607 File Offset: 0x004B2807
			protected GameUtilitiesServiceClient()
			{
			}

			// Token: 0x0600D47B RID: 54395 RVA: 0x004B4611 File Offset: 0x004B2811
			protected GameUtilitiesServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D47C RID: 54396 RVA: 0x004B461C File Offset: 0x004B281C
			public virtual ProcessTaskResponse ProcessTask(ProcessTaskRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ProcessTask(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D47D RID: 54397 RVA: 0x004B4644 File Offset: 0x004B2844
			public virtual ProcessTaskResponse ProcessTask(ProcessTaskRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ProcessTaskRequest, ProcessTaskResponse>(GameUtilitiesService.__Method_ProcessTask, null, options, request);
			}

			// Token: 0x0600D47E RID: 54398 RVA: 0x004B466C File Offset: 0x004B286C
			public virtual AsyncUnaryCall<ProcessTaskResponse> ProcessTaskAsync(ProcessTaskRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ProcessTaskAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D47F RID: 54399 RVA: 0x004B4694 File Offset: 0x004B2894
			public virtual AsyncUnaryCall<ProcessTaskResponse> ProcessTaskAsync(ProcessTaskRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ProcessTaskRequest, ProcessTaskResponse>(GameUtilitiesService.__Method_ProcessTask, null, options, request);
			}

			// Token: 0x0600D480 RID: 54400 RVA: 0x004B46BC File Offset: 0x004B28BC
			public virtual GetAllValuesForAttributeResponse GetAllValuesForAttribute(GetAllValuesForAttributeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetAllValuesForAttribute(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D481 RID: 54401 RVA: 0x004B46E4 File Offset: 0x004B28E4
			public virtual GetAllValuesForAttributeResponse GetAllValuesForAttribute(GetAllValuesForAttributeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetAllValuesForAttributeRequest, GetAllValuesForAttributeResponse>(GameUtilitiesService.__Method_GetAllValuesForAttribute, null, options, request);
			}

			// Token: 0x0600D482 RID: 54402 RVA: 0x004B470C File Offset: 0x004B290C
			public virtual AsyncUnaryCall<GetAllValuesForAttributeResponse> GetAllValuesForAttributeAsync(GetAllValuesForAttributeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetAllValuesForAttributeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D483 RID: 54403 RVA: 0x004B4734 File Offset: 0x004B2934
			public virtual AsyncUnaryCall<GetAllValuesForAttributeResponse> GetAllValuesForAttributeAsync(GetAllValuesForAttributeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetAllValuesForAttributeRequest, GetAllValuesForAttributeResponse>(GameUtilitiesService.__Method_GetAllValuesForAttribute, null, options, request);
			}

			// Token: 0x0600D484 RID: 54404 RVA: 0x004B475C File Offset: 0x004B295C
			protected override GameUtilitiesService.GameUtilitiesServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new GameUtilitiesService.GameUtilitiesServiceClient(configuration);
			}
		}
	}
}
