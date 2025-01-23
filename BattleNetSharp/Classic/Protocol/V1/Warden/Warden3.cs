using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Classic.Protocol.V1.Warden
{
	// Token: 0x02000757 RID: 1879
	public static class Warden3
	{
		// Token: 0x0600AD10 RID: 44304 RVA: 0x002A2144 File Offset: 0x002A0344
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

		// Token: 0x0600AD11 RID: 44305 RVA: 0x002A2190 File Offset: 0x002A0390
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = Warden3.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x1700357F RID: 13695
		// (get) Token: 0x0600AD12 RID: 44306 RVA: 0x002A21C8 File Offset: 0x002A03C8
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return WardenReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x0600AD13 RID: 44307 RVA: 0x002A21EC File Offset: 0x002A03EC
		public static ServerServiceDefinition BindService(Warden3.Warden3Base serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<WardenRequest, WardenResponse>(Warden3.__Method_Init, new UnaryServerMethod<WardenRequest, WardenResponse>(serviceImpl.Init)).AddMethod<WardenRequest, WardenResponse>(Warden3.__Method_SendPacketToServer, new UnaryServerMethod<WardenRequest, WardenResponse>(serviceImpl.SendPacketToServer))
				.AddMethod<WardenRequest, WardenResponse>(Warden3.__Method_SendPacketToClient, new UnaryServerMethod<WardenRequest, WardenResponse>(serviceImpl.SendPacketToClient))
				.Build();
		}

		// Token: 0x0600AD14 RID: 44308 RVA: 0x002A2250 File Offset: 0x002A0450
		public static void BindService(ServiceBinderBase serviceBinder, Warden3.Warden3Base serviceImpl)
		{
			serviceBinder.AddMethod<WardenRequest, WardenResponse>(Warden3.__Method_Init, (serviceImpl == null) ? null : new UnaryServerMethod<WardenRequest, WardenResponse>(serviceImpl.Init));
			serviceBinder.AddMethod<WardenRequest, WardenResponse>(Warden3.__Method_SendPacketToServer, (serviceImpl == null) ? null : new UnaryServerMethod<WardenRequest, WardenResponse>(serviceImpl.SendPacketToServer));
			serviceBinder.AddMethod<WardenRequest, WardenResponse>(Warden3.__Method_SendPacketToClient, (serviceImpl == null) ? null : new UnaryServerMethod<WardenRequest, WardenResponse>(serviceImpl.SendPacketToClient));
		}

		// Token: 0x04004DEE RID: 19950
		private static readonly string __ServiceName = "classic.protocol.v1.warden.Warden3";

		// Token: 0x04004DEF RID: 19951
		private static readonly Marshaller<WardenRequest> __Marshaller_classic_protocol_v1_warden_WardenRequest = Marshallers.Create<WardenRequest>(new Action<WardenRequest, SerializationContext>(Warden3.__Helper_SerializeMessage), (DeserializationContext context) => Warden3.__Helper_DeserializeMessage<WardenRequest>(context, WardenRequest.Parser));

		// Token: 0x04004DF0 RID: 19952
		private static readonly Marshaller<WardenResponse> __Marshaller_classic_protocol_v1_warden_WardenResponse = Marshallers.Create<WardenResponse>(new Action<WardenResponse, SerializationContext>(Warden3.__Helper_SerializeMessage), (DeserializationContext context) => Warden3.__Helper_DeserializeMessage<WardenResponse>(context, WardenResponse.Parser));

		// Token: 0x04004DF1 RID: 19953
		private static readonly Method<WardenRequest, WardenResponse> __Method_Init = new Method<WardenRequest, WardenResponse>(0, Warden3.__ServiceName, "Init", Warden3.__Marshaller_classic_protocol_v1_warden_WardenRequest, Warden3.__Marshaller_classic_protocol_v1_warden_WardenResponse);

		// Token: 0x04004DF2 RID: 19954
		private static readonly Method<WardenRequest, WardenResponse> __Method_SendPacketToServer = new Method<WardenRequest, WardenResponse>(0, Warden3.__ServiceName, "SendPacketToServer", Warden3.__Marshaller_classic_protocol_v1_warden_WardenRequest, Warden3.__Marshaller_classic_protocol_v1_warden_WardenResponse);

		// Token: 0x04004DF3 RID: 19955
		private static readonly Method<WardenRequest, WardenResponse> __Method_SendPacketToClient = new Method<WardenRequest, WardenResponse>(0, Warden3.__ServiceName, "SendPacketToClient", Warden3.__Marshaller_classic_protocol_v1_warden_WardenRequest, Warden3.__Marshaller_classic_protocol_v1_warden_WardenResponse);

		// Token: 0x0200126B RID: 4715
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x0400998D RID: 39309
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x0200126C RID: 4716
		[BindServiceMethod(typeof(Warden3), "BindService")]
		public abstract class Warden3Base
		{
			// Token: 0x0600DC0B RID: 56331 RVA: 0x004BDC9B File Offset: 0x004BBE9B
			public virtual Task<WardenResponse> Init(WardenRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600DC0C RID: 56332 RVA: 0x004BDCAF File Offset: 0x004BBEAF
			public virtual Task<WardenResponse> SendPacketToServer(WardenRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600DC0D RID: 56333 RVA: 0x004BDCC3 File Offset: 0x004BBEC3
			public virtual Task<WardenResponse> SendPacketToClient(WardenRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x0200126D RID: 4717
		public class Warden3Client : ClientBase<Warden3.Warden3Client>
		{
			// Token: 0x0600DC0F RID: 56335 RVA: 0x004BDCE0 File Offset: 0x004BBEE0
			public Warden3Client(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600DC10 RID: 56336 RVA: 0x004BDCEB File Offset: 0x004BBEEB
			public Warden3Client(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600DC11 RID: 56337 RVA: 0x004BDCF6 File Offset: 0x004BBEF6
			protected Warden3Client()
			{
			}

			// Token: 0x0600DC12 RID: 56338 RVA: 0x004BDD00 File Offset: 0x004BBF00
			protected Warden3Client(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600DC13 RID: 56339 RVA: 0x004BDD0C File Offset: 0x004BBF0C
			public virtual WardenResponse Init(WardenRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Init(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC14 RID: 56340 RVA: 0x004BDD34 File Offset: 0x004BBF34
			public virtual WardenResponse Init(WardenRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<WardenRequest, WardenResponse>(Warden3.__Method_Init, null, options, request);
			}

			// Token: 0x0600DC15 RID: 56341 RVA: 0x004BDD5C File Offset: 0x004BBF5C
			public virtual AsyncUnaryCall<WardenResponse> InitAsync(WardenRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.InitAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC16 RID: 56342 RVA: 0x004BDD84 File Offset: 0x004BBF84
			public virtual AsyncUnaryCall<WardenResponse> InitAsync(WardenRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<WardenRequest, WardenResponse>(Warden3.__Method_Init, null, options, request);
			}

			// Token: 0x0600DC17 RID: 56343 RVA: 0x004BDDAC File Offset: 0x004BBFAC
			public virtual WardenResponse SendPacketToServer(WardenRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SendPacketToServer(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC18 RID: 56344 RVA: 0x004BDDD4 File Offset: 0x004BBFD4
			public virtual WardenResponse SendPacketToServer(WardenRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<WardenRequest, WardenResponse>(Warden3.__Method_SendPacketToServer, null, options, request);
			}

			// Token: 0x0600DC19 RID: 56345 RVA: 0x004BDDFC File Offset: 0x004BBFFC
			public virtual AsyncUnaryCall<WardenResponse> SendPacketToServerAsync(WardenRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SendPacketToServerAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC1A RID: 56346 RVA: 0x004BDE24 File Offset: 0x004BC024
			public virtual AsyncUnaryCall<WardenResponse> SendPacketToServerAsync(WardenRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<WardenRequest, WardenResponse>(Warden3.__Method_SendPacketToServer, null, options, request);
			}

			// Token: 0x0600DC1B RID: 56347 RVA: 0x004BDE4C File Offset: 0x004BC04C
			public virtual WardenResponse SendPacketToClient(WardenRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SendPacketToClient(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC1C RID: 56348 RVA: 0x004BDE74 File Offset: 0x004BC074
			public virtual WardenResponse SendPacketToClient(WardenRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<WardenRequest, WardenResponse>(Warden3.__Method_SendPacketToClient, null, options, request);
			}

			// Token: 0x0600DC1D RID: 56349 RVA: 0x004BDE9C File Offset: 0x004BC09C
			public virtual AsyncUnaryCall<WardenResponse> SendPacketToClientAsync(WardenRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SendPacketToClientAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC1E RID: 56350 RVA: 0x004BDEC4 File Offset: 0x004BC0C4
			public virtual AsyncUnaryCall<WardenResponse> SendPacketToClientAsync(WardenRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<WardenRequest, WardenResponse>(Warden3.__Method_SendPacketToClient, null, options, request);
			}

			// Token: 0x0600DC1F RID: 56351 RVA: 0x004BDEEC File Offset: 0x004BC0EC
			protected override Warden3.Warden3Client NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new Warden3.Warden3Client(configuration);
			}
		}
	}
}
