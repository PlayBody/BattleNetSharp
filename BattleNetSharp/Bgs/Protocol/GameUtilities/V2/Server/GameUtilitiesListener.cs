using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.GameUtilities.V2.Server
{
	// Token: 0x020005F8 RID: 1528
	public static class GameUtilitiesListener
	{
		// Token: 0x06008F45 RID: 36677 RVA: 0x0022C074 File Offset: 0x0022A274
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

		// Token: 0x06008F46 RID: 36678 RVA: 0x0022C0C0 File Offset: 0x0022A2C0
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = GameUtilitiesListener.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17002CD0 RID: 11472
		// (get) Token: 0x06008F47 RID: 36679 RVA: 0x0022C0F8 File Offset: 0x0022A2F8
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesListenerReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x06008F48 RID: 36680 RVA: 0x0022C11C File Offset: 0x0022A31C
		public static ServerServiceDefinition BindService(GameUtilitiesListener.GameUtilitiesListenerBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<ProcessClientTaskRequest, ProcessClientTaskResponse>(GameUtilitiesListener.__Method_ProcessClientTask, new UnaryServerMethod<ProcessClientTaskRequest, ProcessClientTaskResponse>(serviceImpl.ProcessClientTask)).AddMethod<ProcessServerTaskRequest, ProcessServerTaskResponse>(GameUtilitiesListener.__Method_ProcessServerTask, new UnaryServerMethod<ProcessServerTaskRequest, ProcessServerTaskResponse>(serviceImpl.ProcessServerTask))
				.AddMethod<ProcessAdminTaskRequest, ProcessAdminTaskResponse>(GameUtilitiesListener.__Method_ProcessAdminTask, new UnaryServerMethod<ProcessAdminTaskRequest, ProcessAdminTaskResponse>(serviceImpl.ProcessAdminTask))
				.Build();
		}

		// Token: 0x06008F49 RID: 36681 RVA: 0x0022C180 File Offset: 0x0022A380
		public static void BindService(ServiceBinderBase serviceBinder, GameUtilitiesListener.GameUtilitiesListenerBase serviceImpl)
		{
			serviceBinder.AddMethod<ProcessClientTaskRequest, ProcessClientTaskResponse>(GameUtilitiesListener.__Method_ProcessClientTask, (serviceImpl == null) ? null : new UnaryServerMethod<ProcessClientTaskRequest, ProcessClientTaskResponse>(serviceImpl.ProcessClientTask));
			serviceBinder.AddMethod<ProcessServerTaskRequest, ProcessServerTaskResponse>(GameUtilitiesListener.__Method_ProcessServerTask, (serviceImpl == null) ? null : new UnaryServerMethod<ProcessServerTaskRequest, ProcessServerTaskResponse>(serviceImpl.ProcessServerTask));
			serviceBinder.AddMethod<ProcessAdminTaskRequest, ProcessAdminTaskResponse>(GameUtilitiesListener.__Method_ProcessAdminTask, (serviceImpl == null) ? null : new UnaryServerMethod<ProcessAdminTaskRequest, ProcessAdminTaskResponse>(serviceImpl.ProcessAdminTask));
		}

		// Token: 0x040040B3 RID: 16563
		private static readonly string __ServiceName = "bgs.protocol.game_utilities.v2.server.GameUtilitiesListener";

		// Token: 0x040040B4 RID: 16564
		private static readonly Marshaller<ProcessClientTaskRequest> __Marshaller_bgs_protocol_game_utilities_v2_server_ProcessClientTaskRequest = Marshallers.Create<ProcessClientTaskRequest>(new Action<ProcessClientTaskRequest, SerializationContext>(GameUtilitiesListener.__Helper_SerializeMessage), (DeserializationContext context) => GameUtilitiesListener.__Helper_DeserializeMessage<ProcessClientTaskRequest>(context, ProcessClientTaskRequest.Parser));

		// Token: 0x040040B5 RID: 16565
		private static readonly Marshaller<ProcessClientTaskResponse> __Marshaller_bgs_protocol_game_utilities_v2_server_ProcessClientTaskResponse = Marshallers.Create<ProcessClientTaskResponse>(new Action<ProcessClientTaskResponse, SerializationContext>(GameUtilitiesListener.__Helper_SerializeMessage), (DeserializationContext context) => GameUtilitiesListener.__Helper_DeserializeMessage<ProcessClientTaskResponse>(context, ProcessClientTaskResponse.Parser));

		// Token: 0x040040B6 RID: 16566
		private static readonly Marshaller<ProcessServerTaskRequest> __Marshaller_bgs_protocol_game_utilities_v2_server_ProcessServerTaskRequest = Marshallers.Create<ProcessServerTaskRequest>(new Action<ProcessServerTaskRequest, SerializationContext>(GameUtilitiesListener.__Helper_SerializeMessage), (DeserializationContext context) => GameUtilitiesListener.__Helper_DeserializeMessage<ProcessServerTaskRequest>(context, ProcessServerTaskRequest.Parser));

		// Token: 0x040040B7 RID: 16567
		private static readonly Marshaller<ProcessServerTaskResponse> __Marshaller_bgs_protocol_game_utilities_v2_server_ProcessServerTaskResponse = Marshallers.Create<ProcessServerTaskResponse>(new Action<ProcessServerTaskResponse, SerializationContext>(GameUtilitiesListener.__Helper_SerializeMessage), (DeserializationContext context) => GameUtilitiesListener.__Helper_DeserializeMessage<ProcessServerTaskResponse>(context, ProcessServerTaskResponse.Parser));

		// Token: 0x040040B8 RID: 16568
		private static readonly Marshaller<ProcessAdminTaskRequest> __Marshaller_bgs_protocol_game_utilities_v2_server_ProcessAdminTaskRequest = Marshallers.Create<ProcessAdminTaskRequest>(new Action<ProcessAdminTaskRequest, SerializationContext>(GameUtilitiesListener.__Helper_SerializeMessage), (DeserializationContext context) => GameUtilitiesListener.__Helper_DeserializeMessage<ProcessAdminTaskRequest>(context, ProcessAdminTaskRequest.Parser));

		// Token: 0x040040B9 RID: 16569
		private static readonly Marshaller<ProcessAdminTaskResponse> __Marshaller_bgs_protocol_game_utilities_v2_server_ProcessAdminTaskResponse = Marshallers.Create<ProcessAdminTaskResponse>(new Action<ProcessAdminTaskResponse, SerializationContext>(GameUtilitiesListener.__Helper_SerializeMessage), (DeserializationContext context) => GameUtilitiesListener.__Helper_DeserializeMessage<ProcessAdminTaskResponse>(context, ProcessAdminTaskResponse.Parser));

		// Token: 0x040040BA RID: 16570
		private static readonly Method<ProcessClientTaskRequest, ProcessClientTaskResponse> __Method_ProcessClientTask = new Method<ProcessClientTaskRequest, ProcessClientTaskResponse>(0, GameUtilitiesListener.__ServiceName, "ProcessClientTask", GameUtilitiesListener.__Marshaller_bgs_protocol_game_utilities_v2_server_ProcessClientTaskRequest, GameUtilitiesListener.__Marshaller_bgs_protocol_game_utilities_v2_server_ProcessClientTaskResponse);

		// Token: 0x040040BB RID: 16571
		private static readonly Method<ProcessServerTaskRequest, ProcessServerTaskResponse> __Method_ProcessServerTask = new Method<ProcessServerTaskRequest, ProcessServerTaskResponse>(0, GameUtilitiesListener.__ServiceName, "ProcessServerTask", GameUtilitiesListener.__Marshaller_bgs_protocol_game_utilities_v2_server_ProcessServerTaskRequest, GameUtilitiesListener.__Marshaller_bgs_protocol_game_utilities_v2_server_ProcessServerTaskResponse);

		// Token: 0x040040BC RID: 16572
		private static readonly Method<ProcessAdminTaskRequest, ProcessAdminTaskResponse> __Method_ProcessAdminTask = new Method<ProcessAdminTaskRequest, ProcessAdminTaskResponse>(0, GameUtilitiesListener.__ServiceName, "ProcessAdminTask", GameUtilitiesListener.__Marshaller_bgs_protocol_game_utilities_v2_server_ProcessAdminTaskRequest, GameUtilitiesListener.__Marshaller_bgs_protocol_game_utilities_v2_server_ProcessAdminTaskResponse);

		// Token: 0x020010E0 RID: 4320
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x04009823 RID: 38947
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x020010E1 RID: 4321
		[BindServiceMethod(typeof(GameUtilitiesListener), "BindService")]
		public abstract class GameUtilitiesListenerBase
		{
			// Token: 0x0600D43F RID: 54335 RVA: 0x004B41ED File Offset: 0x004B23ED
			public virtual Task<ProcessClientTaskResponse> ProcessClientTask(ProcessClientTaskRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D440 RID: 54336 RVA: 0x004B4201 File Offset: 0x004B2401
			public virtual Task<ProcessServerTaskResponse> ProcessServerTask(ProcessServerTaskRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D441 RID: 54337 RVA: 0x004B4215 File Offset: 0x004B2415
			public virtual Task<ProcessAdminTaskResponse> ProcessAdminTask(ProcessAdminTaskRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x020010E2 RID: 4322
		public class GameUtilitiesListenerClient : ClientBase<GameUtilitiesListener.GameUtilitiesListenerClient>
		{
			// Token: 0x0600D443 RID: 54339 RVA: 0x004B4232 File Offset: 0x004B2432
			public GameUtilitiesListenerClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D444 RID: 54340 RVA: 0x004B423D File Offset: 0x004B243D
			public GameUtilitiesListenerClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D445 RID: 54341 RVA: 0x004B4248 File Offset: 0x004B2448
			protected GameUtilitiesListenerClient()
			{
			}

			// Token: 0x0600D446 RID: 54342 RVA: 0x004B4252 File Offset: 0x004B2452
			protected GameUtilitiesListenerClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D447 RID: 54343 RVA: 0x004B4260 File Offset: 0x004B2460
			public virtual ProcessClientTaskResponse ProcessClientTask(ProcessClientTaskRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ProcessClientTask(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D448 RID: 54344 RVA: 0x004B4288 File Offset: 0x004B2488
			public virtual ProcessClientTaskResponse ProcessClientTask(ProcessClientTaskRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ProcessClientTaskRequest, ProcessClientTaskResponse>(GameUtilitiesListener.__Method_ProcessClientTask, null, options, request);
			}

			// Token: 0x0600D449 RID: 54345 RVA: 0x004B42B0 File Offset: 0x004B24B0
			public virtual AsyncUnaryCall<ProcessClientTaskResponse> ProcessClientTaskAsync(ProcessClientTaskRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ProcessClientTaskAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D44A RID: 54346 RVA: 0x004B42D8 File Offset: 0x004B24D8
			public virtual AsyncUnaryCall<ProcessClientTaskResponse> ProcessClientTaskAsync(ProcessClientTaskRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ProcessClientTaskRequest, ProcessClientTaskResponse>(GameUtilitiesListener.__Method_ProcessClientTask, null, options, request);
			}

			// Token: 0x0600D44B RID: 54347 RVA: 0x004B4300 File Offset: 0x004B2500
			public virtual ProcessServerTaskResponse ProcessServerTask(ProcessServerTaskRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ProcessServerTask(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D44C RID: 54348 RVA: 0x004B4328 File Offset: 0x004B2528
			public virtual ProcessServerTaskResponse ProcessServerTask(ProcessServerTaskRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ProcessServerTaskRequest, ProcessServerTaskResponse>(GameUtilitiesListener.__Method_ProcessServerTask, null, options, request);
			}

			// Token: 0x0600D44D RID: 54349 RVA: 0x004B4350 File Offset: 0x004B2550
			public virtual AsyncUnaryCall<ProcessServerTaskResponse> ProcessServerTaskAsync(ProcessServerTaskRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ProcessServerTaskAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D44E RID: 54350 RVA: 0x004B4378 File Offset: 0x004B2578
			public virtual AsyncUnaryCall<ProcessServerTaskResponse> ProcessServerTaskAsync(ProcessServerTaskRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ProcessServerTaskRequest, ProcessServerTaskResponse>(GameUtilitiesListener.__Method_ProcessServerTask, null, options, request);
			}

			// Token: 0x0600D44F RID: 54351 RVA: 0x004B43A0 File Offset: 0x004B25A0
			public virtual ProcessAdminTaskResponse ProcessAdminTask(ProcessAdminTaskRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ProcessAdminTask(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D450 RID: 54352 RVA: 0x004B43C8 File Offset: 0x004B25C8
			public virtual ProcessAdminTaskResponse ProcessAdminTask(ProcessAdminTaskRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ProcessAdminTaskRequest, ProcessAdminTaskResponse>(GameUtilitiesListener.__Method_ProcessAdminTask, null, options, request);
			}

			// Token: 0x0600D451 RID: 54353 RVA: 0x004B43F0 File Offset: 0x004B25F0
			public virtual AsyncUnaryCall<ProcessAdminTaskResponse> ProcessAdminTaskAsync(ProcessAdminTaskRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ProcessAdminTaskAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D452 RID: 54354 RVA: 0x004B4418 File Offset: 0x004B2618
			public virtual AsyncUnaryCall<ProcessAdminTaskResponse> ProcessAdminTaskAsync(ProcessAdminTaskRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ProcessAdminTaskRequest, ProcessAdminTaskResponse>(GameUtilitiesListener.__Method_ProcessAdminTask, null, options, request);
			}

			// Token: 0x0600D453 RID: 54355 RVA: 0x004B4440 File Offset: 0x004B2640
			protected override GameUtilitiesListener.GameUtilitiesListenerClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new GameUtilitiesListener.GameUtilitiesListenerClient(configuration);
			}
		}
	}
}
