using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Connection.V1
{
	// Token: 0x02000437 RID: 1079
	public static class ConnectionService
	{
		// Token: 0x06006A0C RID: 27148 RVA: 0x0019A2F4 File Offset: 0x001984F4
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

		// Token: 0x06006A0D RID: 27149 RVA: 0x0019A340 File Offset: 0x00198540
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = ConnectionService.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x170021DD RID: 8669
		// (get) Token: 0x06006A0E RID: 27150 RVA: 0x0019A378 File Offset: 0x00198578
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return ConnectionServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x06006A0F RID: 27151 RVA: 0x0019A39C File Offset: 0x0019859C
		public static ServerServiceDefinition BindService(ConnectionService.ConnectionServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<ConnectRequest, ConnectResponse>(ConnectionService.__Method_Connect, new UnaryServerMethod<ConnectRequest, ConnectResponse>(serviceImpl.Connect)).AddMethod<BindRequest, BindResponse>(ConnectionService.__Method_Bind, new UnaryServerMethod<BindRequest, BindResponse>(serviceImpl.Bind))
				.AddMethod<EchoRequest, EchoResponse>(ConnectionService.__Method_Echo, new UnaryServerMethod<EchoRequest, EchoResponse>(serviceImpl.Echo))
				.AddMethod<DisconnectNotification, NO_RESPONSE>(ConnectionService.__Method_ForceDisconnect, new UnaryServerMethod<DisconnectNotification, NO_RESPONSE>(serviceImpl.ForceDisconnect))
				.AddMethod<NoData, NO_RESPONSE>(ConnectionService.__Method_KeepAlive, new UnaryServerMethod<NoData, NO_RESPONSE>(serviceImpl.KeepAlive))
				.AddMethod<EncryptRequest, NoData>(ConnectionService.__Method_Encrypt, new UnaryServerMethod<EncryptRequest, NoData>(serviceImpl.Encrypt))
				.AddMethod<DisconnectRequest, NO_RESPONSE>(ConnectionService.__Method_RequestDisconnect, new UnaryServerMethod<DisconnectRequest, NO_RESPONSE>(serviceImpl.RequestDisconnect))
				.Build();
		}

		// Token: 0x06006A10 RID: 27152 RVA: 0x0019A45C File Offset: 0x0019865C
		public static void BindService(ServiceBinderBase serviceBinder, ConnectionService.ConnectionServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<ConnectRequest, ConnectResponse>(ConnectionService.__Method_Connect, (serviceImpl == null) ? null : new UnaryServerMethod<ConnectRequest, ConnectResponse>(serviceImpl.Connect));
			serviceBinder.AddMethod<BindRequest, BindResponse>(ConnectionService.__Method_Bind, (serviceImpl == null) ? null : new UnaryServerMethod<BindRequest, BindResponse>(serviceImpl.Bind));
			serviceBinder.AddMethod<EchoRequest, EchoResponse>(ConnectionService.__Method_Echo, (serviceImpl == null) ? null : new UnaryServerMethod<EchoRequest, EchoResponse>(serviceImpl.Echo));
			serviceBinder.AddMethod<DisconnectNotification, NO_RESPONSE>(ConnectionService.__Method_ForceDisconnect, (serviceImpl == null) ? null : new UnaryServerMethod<DisconnectNotification, NO_RESPONSE>(serviceImpl.ForceDisconnect));
			serviceBinder.AddMethod<NoData, NO_RESPONSE>(ConnectionService.__Method_KeepAlive, (serviceImpl == null) ? null : new UnaryServerMethod<NoData, NO_RESPONSE>(serviceImpl.KeepAlive));
			serviceBinder.AddMethod<EncryptRequest, NoData>(ConnectionService.__Method_Encrypt, (serviceImpl == null) ? null : new UnaryServerMethod<EncryptRequest, NoData>(serviceImpl.Encrypt));
			serviceBinder.AddMethod<DisconnectRequest, NO_RESPONSE>(ConnectionService.__Method_RequestDisconnect, (serviceImpl == null) ? null : new UnaryServerMethod<DisconnectRequest, NO_RESPONSE>(serviceImpl.RequestDisconnect));
		}

		// Token: 0x0400303A RID: 12346
		private static readonly string __ServiceName = "bgs.protocol.connection.v1.ConnectionService";

		// Token: 0x0400303B RID: 12347
		private static readonly Marshaller<ConnectRequest> __Marshaller_bgs_protocol_connection_v1_ConnectRequest = Marshallers.Create<ConnectRequest>(new Action<ConnectRequest, SerializationContext>(ConnectionService.__Helper_SerializeMessage), (DeserializationContext context) => ConnectionService.__Helper_DeserializeMessage<ConnectRequest>(context, ConnectRequest.Parser));

		// Token: 0x0400303C RID: 12348
		private static readonly Marshaller<ConnectResponse> __Marshaller_bgs_protocol_connection_v1_ConnectResponse = Marshallers.Create<ConnectResponse>(new Action<ConnectResponse, SerializationContext>(ConnectionService.__Helper_SerializeMessage), (DeserializationContext context) => ConnectionService.__Helper_DeserializeMessage<ConnectResponse>(context, ConnectResponse.Parser));

		// Token: 0x0400303D RID: 12349
		private static readonly Marshaller<BindRequest> __Marshaller_bgs_protocol_connection_v1_BindRequest = Marshallers.Create<BindRequest>(new Action<BindRequest, SerializationContext>(ConnectionService.__Helper_SerializeMessage), (DeserializationContext context) => ConnectionService.__Helper_DeserializeMessage<BindRequest>(context, BindRequest.Parser));

		// Token: 0x0400303E RID: 12350
		private static readonly Marshaller<BindResponse> __Marshaller_bgs_protocol_connection_v1_BindResponse = Marshallers.Create<BindResponse>(new Action<BindResponse, SerializationContext>(ConnectionService.__Helper_SerializeMessage), (DeserializationContext context) => ConnectionService.__Helper_DeserializeMessage<BindResponse>(context, BindResponse.Parser));

		// Token: 0x0400303F RID: 12351
		private static readonly Marshaller<EchoRequest> __Marshaller_bgs_protocol_connection_v1_EchoRequest = Marshallers.Create<EchoRequest>(new Action<EchoRequest, SerializationContext>(ConnectionService.__Helper_SerializeMessage), (DeserializationContext context) => ConnectionService.__Helper_DeserializeMessage<EchoRequest>(context, EchoRequest.Parser));

		// Token: 0x04003040 RID: 12352
		private static readonly Marshaller<EchoResponse> __Marshaller_bgs_protocol_connection_v1_EchoResponse = Marshallers.Create<EchoResponse>(new Action<EchoResponse, SerializationContext>(ConnectionService.__Helper_SerializeMessage), (DeserializationContext context) => ConnectionService.__Helper_DeserializeMessage<EchoResponse>(context, EchoResponse.Parser));

		// Token: 0x04003041 RID: 12353
		private static readonly Marshaller<DisconnectNotification> __Marshaller_bgs_protocol_connection_v1_DisconnectNotification = Marshallers.Create<DisconnectNotification>(new Action<DisconnectNotification, SerializationContext>(ConnectionService.__Helper_SerializeMessage), (DeserializationContext context) => ConnectionService.__Helper_DeserializeMessage<DisconnectNotification>(context, DisconnectNotification.Parser));

		// Token: 0x04003042 RID: 12354
		private static readonly Marshaller<NO_RESPONSE> __Marshaller_bgs_protocol_NO_RESPONSE = Marshallers.Create<NO_RESPONSE>(new Action<NO_RESPONSE, SerializationContext>(ConnectionService.__Helper_SerializeMessage), (DeserializationContext context) => ConnectionService.__Helper_DeserializeMessage<NO_RESPONSE>(context, NO_RESPONSE.Parser));

		// Token: 0x04003043 RID: 12355
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(ConnectionService.__Helper_SerializeMessage), (DeserializationContext context) => ConnectionService.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x04003044 RID: 12356
		private static readonly Marshaller<EncryptRequest> __Marshaller_bgs_protocol_connection_v1_EncryptRequest = Marshallers.Create<EncryptRequest>(new Action<EncryptRequest, SerializationContext>(ConnectionService.__Helper_SerializeMessage), (DeserializationContext context) => ConnectionService.__Helper_DeserializeMessage<EncryptRequest>(context, EncryptRequest.Parser));

		// Token: 0x04003045 RID: 12357
		private static readonly Marshaller<DisconnectRequest> __Marshaller_bgs_protocol_connection_v1_DisconnectRequest = Marshallers.Create<DisconnectRequest>(new Action<DisconnectRequest, SerializationContext>(ConnectionService.__Helper_SerializeMessage), (DeserializationContext context) => ConnectionService.__Helper_DeserializeMessage<DisconnectRequest>(context, DisconnectRequest.Parser));

		// Token: 0x04003046 RID: 12358
		private static readonly Method<ConnectRequest, ConnectResponse> __Method_Connect = new Method<ConnectRequest, ConnectResponse>(0, ConnectionService.__ServiceName, "Connect", ConnectionService.__Marshaller_bgs_protocol_connection_v1_ConnectRequest, ConnectionService.__Marshaller_bgs_protocol_connection_v1_ConnectResponse);

		// Token: 0x04003047 RID: 12359
		private static readonly Method<BindRequest, BindResponse> __Method_Bind = new Method<BindRequest, BindResponse>(0, ConnectionService.__ServiceName, "Bind", ConnectionService.__Marshaller_bgs_protocol_connection_v1_BindRequest, ConnectionService.__Marshaller_bgs_protocol_connection_v1_BindResponse);

		// Token: 0x04003048 RID: 12360
		private static readonly Method<EchoRequest, EchoResponse> __Method_Echo = new Method<EchoRequest, EchoResponse>(0, ConnectionService.__ServiceName, "Echo", ConnectionService.__Marshaller_bgs_protocol_connection_v1_EchoRequest, ConnectionService.__Marshaller_bgs_protocol_connection_v1_EchoResponse);

		// Token: 0x04003049 RID: 12361
		private static readonly Method<DisconnectNotification, NO_RESPONSE> __Method_ForceDisconnect = new Method<DisconnectNotification, NO_RESPONSE>(0, ConnectionService.__ServiceName, "ForceDisconnect", ConnectionService.__Marshaller_bgs_protocol_connection_v1_DisconnectNotification, ConnectionService.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x0400304A RID: 12362
		private static readonly Method<NoData, NO_RESPONSE> __Method_KeepAlive = new Method<NoData, NO_RESPONSE>(0, ConnectionService.__ServiceName, "KeepAlive", ConnectionService.__Marshaller_bgs_protocol_NoData, ConnectionService.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x0400304B RID: 12363
		private static readonly Method<EncryptRequest, NoData> __Method_Encrypt = new Method<EncryptRequest, NoData>(0, ConnectionService.__ServiceName, "Encrypt", ConnectionService.__Marshaller_bgs_protocol_connection_v1_EncryptRequest, ConnectionService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x0400304C RID: 12364
		private static readonly Method<DisconnectRequest, NO_RESPONSE> __Method_RequestDisconnect = new Method<DisconnectRequest, NO_RESPONSE>(0, ConnectionService.__ServiceName, "RequestDisconnect", ConnectionService.__Marshaller_bgs_protocol_connection_v1_DisconnectRequest, ConnectionService.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x02000F16 RID: 3862
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x0400966F RID: 38511
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02000F17 RID: 3863
		[BindServiceMethod(typeof(ConnectionService), "BindService")]
		public abstract class ConnectionServiceBase
		{
			// Token: 0x0600CCFC RID: 52476 RVA: 0x004AC9DC File Offset: 0x004AABDC
			public virtual Task<ConnectResponse> Connect(ConnectRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CCFD RID: 52477 RVA: 0x004AC9F0 File Offset: 0x004AABF0
			public virtual Task<BindResponse> Bind(BindRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CCFE RID: 52478 RVA: 0x004ACA04 File Offset: 0x004AAC04
			public virtual Task<EchoResponse> Echo(EchoRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CCFF RID: 52479 RVA: 0x004ACA18 File Offset: 0x004AAC18
			public virtual Task<NO_RESPONSE> ForceDisconnect(DisconnectNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CD00 RID: 52480 RVA: 0x004ACA2C File Offset: 0x004AAC2C
			public virtual Task<NO_RESPONSE> KeepAlive(NoData request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CD01 RID: 52481 RVA: 0x004ACA40 File Offset: 0x004AAC40
			public virtual Task<NoData> Encrypt(EncryptRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CD02 RID: 52482 RVA: 0x004ACA54 File Offset: 0x004AAC54
			public virtual Task<NO_RESPONSE> RequestDisconnect(DisconnectRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x02000F18 RID: 3864
		public class ConnectionServiceClient : ClientBase<ConnectionService.ConnectionServiceClient>
		{
			// Token: 0x0600CD04 RID: 52484 RVA: 0x004ACA71 File Offset: 0x004AAC71
			public ConnectionServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600CD05 RID: 52485 RVA: 0x004ACA7C File Offset: 0x004AAC7C
			public ConnectionServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600CD06 RID: 52486 RVA: 0x004ACA87 File Offset: 0x004AAC87
			protected ConnectionServiceClient()
			{
			}

			// Token: 0x0600CD07 RID: 52487 RVA: 0x004ACA91 File Offset: 0x004AAC91
			protected ConnectionServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600CD08 RID: 52488 RVA: 0x004ACA9C File Offset: 0x004AAC9C
			public virtual ConnectResponse Connect(ConnectRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Connect(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CD09 RID: 52489 RVA: 0x004ACAC4 File Offset: 0x004AACC4
			public virtual ConnectResponse Connect(ConnectRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ConnectRequest, ConnectResponse>(ConnectionService.__Method_Connect, null, options, request);
			}

			// Token: 0x0600CD0A RID: 52490 RVA: 0x004ACAEC File Offset: 0x004AACEC
			public virtual AsyncUnaryCall<ConnectResponse> ConnectAsync(ConnectRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ConnectAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CD0B RID: 52491 RVA: 0x004ACB14 File Offset: 0x004AAD14
			public virtual AsyncUnaryCall<ConnectResponse> ConnectAsync(ConnectRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ConnectRequest, ConnectResponse>(ConnectionService.__Method_Connect, null, options, request);
			}

			// Token: 0x0600CD0C RID: 52492 RVA: 0x004ACB3C File Offset: 0x004AAD3C
			public virtual BindResponse Bind(BindRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Bind(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CD0D RID: 52493 RVA: 0x004ACB64 File Offset: 0x004AAD64
			public virtual BindResponse Bind(BindRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<BindRequest, BindResponse>(ConnectionService.__Method_Bind, null, options, request);
			}

			// Token: 0x0600CD0E RID: 52494 RVA: 0x004ACB8C File Offset: 0x004AAD8C
			public virtual AsyncUnaryCall<BindResponse> BindAsync(BindRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.BindAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CD0F RID: 52495 RVA: 0x004ACBB4 File Offset: 0x004AADB4
			public virtual AsyncUnaryCall<BindResponse> BindAsync(BindRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<BindRequest, BindResponse>(ConnectionService.__Method_Bind, null, options, request);
			}

			// Token: 0x0600CD10 RID: 52496 RVA: 0x004ACBDC File Offset: 0x004AADDC
			public virtual EchoResponse Echo(EchoRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Echo(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CD11 RID: 52497 RVA: 0x004ACC04 File Offset: 0x004AAE04
			public virtual EchoResponse Echo(EchoRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<EchoRequest, EchoResponse>(ConnectionService.__Method_Echo, null, options, request);
			}

			// Token: 0x0600CD12 RID: 52498 RVA: 0x004ACC2C File Offset: 0x004AAE2C
			public virtual AsyncUnaryCall<EchoResponse> EchoAsync(EchoRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.EchoAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CD13 RID: 52499 RVA: 0x004ACC54 File Offset: 0x004AAE54
			public virtual AsyncUnaryCall<EchoResponse> EchoAsync(EchoRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<EchoRequest, EchoResponse>(ConnectionService.__Method_Echo, null, options, request);
			}

			// Token: 0x0600CD14 RID: 52500 RVA: 0x004ACC7C File Offset: 0x004AAE7C
			public virtual NO_RESPONSE ForceDisconnect(DisconnectNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ForceDisconnect(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CD15 RID: 52501 RVA: 0x004ACCA4 File Offset: 0x004AAEA4
			public virtual NO_RESPONSE ForceDisconnect(DisconnectNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<DisconnectNotification, NO_RESPONSE>(ConnectionService.__Method_ForceDisconnect, null, options, request);
			}

			// Token: 0x0600CD16 RID: 52502 RVA: 0x004ACCCC File Offset: 0x004AAECC
			public virtual AsyncUnaryCall<NO_RESPONSE> ForceDisconnectAsync(DisconnectNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ForceDisconnectAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CD17 RID: 52503 RVA: 0x004ACCF4 File Offset: 0x004AAEF4
			public virtual AsyncUnaryCall<NO_RESPONSE> ForceDisconnectAsync(DisconnectNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<DisconnectNotification, NO_RESPONSE>(ConnectionService.__Method_ForceDisconnect, null, options, request);
			}

			// Token: 0x0600CD18 RID: 52504 RVA: 0x004ACD1C File Offset: 0x004AAF1C
			public virtual NO_RESPONSE KeepAlive(NoData request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.KeepAlive(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CD19 RID: 52505 RVA: 0x004ACD44 File Offset: 0x004AAF44
			public virtual NO_RESPONSE KeepAlive(NoData request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<NoData, NO_RESPONSE>(ConnectionService.__Method_KeepAlive, null, options, request);
			}

			// Token: 0x0600CD1A RID: 52506 RVA: 0x004ACD6C File Offset: 0x004AAF6C
			public virtual AsyncUnaryCall<NO_RESPONSE> KeepAliveAsync(NoData request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.KeepAliveAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CD1B RID: 52507 RVA: 0x004ACD94 File Offset: 0x004AAF94
			public virtual AsyncUnaryCall<NO_RESPONSE> KeepAliveAsync(NoData request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<NoData, NO_RESPONSE>(ConnectionService.__Method_KeepAlive, null, options, request);
			}

			// Token: 0x0600CD1C RID: 52508 RVA: 0x004ACDBC File Offset: 0x004AAFBC
			public virtual NoData Encrypt(EncryptRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Encrypt(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CD1D RID: 52509 RVA: 0x004ACDE4 File Offset: 0x004AAFE4
			public virtual NoData Encrypt(EncryptRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<EncryptRequest, NoData>(ConnectionService.__Method_Encrypt, null, options, request);
			}

			// Token: 0x0600CD1E RID: 52510 RVA: 0x004ACE0C File Offset: 0x004AB00C
			public virtual AsyncUnaryCall<NoData> EncryptAsync(EncryptRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.EncryptAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CD1F RID: 52511 RVA: 0x004ACE34 File Offset: 0x004AB034
			public virtual AsyncUnaryCall<NoData> EncryptAsync(EncryptRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<EncryptRequest, NoData>(ConnectionService.__Method_Encrypt, null, options, request);
			}

			// Token: 0x0600CD20 RID: 52512 RVA: 0x004ACE5C File Offset: 0x004AB05C
			public virtual NO_RESPONSE RequestDisconnect(DisconnectRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.RequestDisconnect(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CD21 RID: 52513 RVA: 0x004ACE84 File Offset: 0x004AB084
			public virtual NO_RESPONSE RequestDisconnect(DisconnectRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<DisconnectRequest, NO_RESPONSE>(ConnectionService.__Method_RequestDisconnect, null, options, request);
			}

			// Token: 0x0600CD22 RID: 52514 RVA: 0x004ACEAC File Offset: 0x004AB0AC
			public virtual AsyncUnaryCall<NO_RESPONSE> RequestDisconnectAsync(DisconnectRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.RequestDisconnectAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CD23 RID: 52515 RVA: 0x004ACED4 File Offset: 0x004AB0D4
			public virtual AsyncUnaryCall<NO_RESPONSE> RequestDisconnectAsync(DisconnectRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<DisconnectRequest, NO_RESPONSE>(ConnectionService.__Method_RequestDisconnect, null, options, request);
			}

			// Token: 0x0600CD24 RID: 52516 RVA: 0x004ACEFC File Offset: 0x004AB0FC
			protected override ConnectionService.ConnectionServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new ConnectionService.ConnectionServiceClient(configuration);
			}
		}
	}
}
