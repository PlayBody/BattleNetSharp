using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Bgs.Protocol;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Classic.Protocol.V1.Network
{
	// Token: 0x0200075B RID: 1883
	public static class Network
	{
		// Token: 0x0600AD5A RID: 44378 RVA: 0x002A32BC File Offset: 0x002A14BC
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

		// Token: 0x0600AD5B RID: 44379 RVA: 0x002A3308 File Offset: 0x002A1508
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = Network.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17003597 RID: 13719
		// (get) Token: 0x0600AD5C RID: 44380 RVA: 0x002A3340 File Offset: 0x002A1540
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return NetworkReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x0600AD5D RID: 44381 RVA: 0x002A3364 File Offset: 0x002A1564
		public static ServerServiceDefinition BindService(Network.NetworkBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<NoData, NoData>(Network.__Method_GetEchoServerList, new UnaryServerMethod<NoData, NoData>(serviceImpl.GetEchoServerList)).AddMethod<NetworkRequest, NetworkResponse>(Network.__Method_SendUDPTest, new UnaryServerMethod<NetworkRequest, NetworkResponse>(serviceImpl.SendUDPTest))
				.Build();
		}

		// Token: 0x0600AD5E RID: 44382 RVA: 0x002A33B0 File Offset: 0x002A15B0
		public static void BindService(ServiceBinderBase serviceBinder, Network.NetworkBase serviceImpl)
		{
			serviceBinder.AddMethod<NoData, NoData>(Network.__Method_GetEchoServerList, (serviceImpl == null) ? null : new UnaryServerMethod<NoData, NoData>(serviceImpl.GetEchoServerList));
			serviceBinder.AddMethod<NetworkRequest, NetworkResponse>(Network.__Method_SendUDPTest, (serviceImpl == null) ? null : new UnaryServerMethod<NetworkRequest, NetworkResponse>(serviceImpl.SendUDPTest));
		}

		// Token: 0x04004E12 RID: 19986
		private static readonly string __ServiceName = "classic.protocol.v1.network.Network";

		// Token: 0x04004E13 RID: 19987
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(Network.__Helper_SerializeMessage), (DeserializationContext context) => Network.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x04004E14 RID: 19988
		private static readonly Marshaller<NetworkRequest> __Marshaller_classic_protocol_v1_network_NetworkRequest = Marshallers.Create<NetworkRequest>(new Action<NetworkRequest, SerializationContext>(Network.__Helper_SerializeMessage), (DeserializationContext context) => Network.__Helper_DeserializeMessage<NetworkRequest>(context, NetworkRequest.Parser));

		// Token: 0x04004E15 RID: 19989
		private static readonly Marshaller<NetworkResponse> __Marshaller_classic_protocol_v1_network_NetworkResponse = Marshallers.Create<NetworkResponse>(new Action<NetworkResponse, SerializationContext>(Network.__Helper_SerializeMessage), (DeserializationContext context) => Network.__Helper_DeserializeMessage<NetworkResponse>(context, NetworkResponse.Parser));

		// Token: 0x04004E16 RID: 19990
		private static readonly Method<NoData, NoData> __Method_GetEchoServerList = new Method<NoData, NoData>(0, Network.__ServiceName, "GetEchoServerList", Network.__Marshaller_bgs_protocol_NoData, Network.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04004E17 RID: 19991
		private static readonly Method<NetworkRequest, NetworkResponse> __Method_SendUDPTest = new Method<NetworkRequest, NetworkResponse>(0, Network.__ServiceName, "SendUDPTest", Network.__Marshaller_classic_protocol_v1_network_NetworkRequest, Network.__Marshaller_classic_protocol_v1_network_NetworkResponse);

		// Token: 0x02001271 RID: 4721
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x04009991 RID: 39313
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02001272 RID: 4722
		[BindServiceMethod(typeof(Network), "BindService")]
		public abstract class NetworkBase
		{
			// Token: 0x0600DC2B RID: 56363 RVA: 0x004BDF90 File Offset: 0x004BC190
			public virtual Task<NoData> GetEchoServerList(NoData request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DC2C RID: 56364 RVA: 0x004BDFA4 File Offset: 0x004BC1A4
			public virtual Task<NetworkResponse> SendUDPTest(NetworkRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x02001273 RID: 4723
		public class NetworkClient : ClientBase<Network.NetworkClient>
		{
			// Token: 0x0600DC2E RID: 56366 RVA: 0x004BDFC1 File Offset: 0x004BC1C1
			public NetworkClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600DC2F RID: 56367 RVA: 0x004BDFCC File Offset: 0x004BC1CC
			public NetworkClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600DC30 RID: 56368 RVA: 0x004BDFD7 File Offset: 0x004BC1D7
			protected NetworkClient()
			{
			}

			// Token: 0x0600DC31 RID: 56369 RVA: 0x004BDFE1 File Offset: 0x004BC1E1
			protected NetworkClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600DC32 RID: 56370 RVA: 0x004BDFEC File Offset: 0x004BC1EC
			public virtual NoData GetEchoServerList(NoData request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetEchoServerList(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC33 RID: 56371 RVA: 0x004BE014 File Offset: 0x004BC214
			public virtual NoData GetEchoServerList(NoData request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<NoData, NoData>(Network.__Method_GetEchoServerList, null, options, request);
			}

			// Token: 0x0600DC34 RID: 56372 RVA: 0x004BE03C File Offset: 0x004BC23C
			public virtual AsyncUnaryCall<NoData> GetEchoServerListAsync(NoData request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetEchoServerListAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC35 RID: 56373 RVA: 0x004BE064 File Offset: 0x004BC264
			public virtual AsyncUnaryCall<NoData> GetEchoServerListAsync(NoData request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<NoData, NoData>(Network.__Method_GetEchoServerList, null, options, request);
			}

			// Token: 0x0600DC36 RID: 56374 RVA: 0x004BE08C File Offset: 0x004BC28C
			public virtual NetworkResponse SendUDPTest(NetworkRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SendUDPTest(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC37 RID: 56375 RVA: 0x004BE0B4 File Offset: 0x004BC2B4
			public virtual NetworkResponse SendUDPTest(NetworkRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<NetworkRequest, NetworkResponse>(Network.__Method_SendUDPTest, null, options, request);
			}

			// Token: 0x0600DC38 RID: 56376 RVA: 0x004BE0DC File Offset: 0x004BC2DC
			public virtual AsyncUnaryCall<NetworkResponse> SendUDPTestAsync(NetworkRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SendUDPTestAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DC39 RID: 56377 RVA: 0x004BE104 File Offset: 0x004BC304
			public virtual AsyncUnaryCall<NetworkResponse> SendUDPTestAsync(NetworkRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<NetworkRequest, NetworkResponse>(Network.__Method_SendUDPTest, null, options, request);
			}

			// Token: 0x0600DC3A RID: 56378 RVA: 0x004BE12C File Offset: 0x004BC32C
			protected override Network.NetworkClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new Network.NetworkClient(configuration);
			}
		}
	}
}
