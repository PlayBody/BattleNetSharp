using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Bgs.Protocol;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Classic.Protocol.External.V1.TerrorZones
{
	// Token: 0x0200077F RID: 1919
	public static class TerrorZones
	{
		// Token: 0x0600B05E RID: 45150 RVA: 0x002AEE1C File Offset: 0x002AD01C
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

		// Token: 0x0600B05F RID: 45151 RVA: 0x002AEE68 File Offset: 0x002AD068
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = TerrorZones.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x1700368C RID: 13964
		// (get) Token: 0x0600B060 RID: 45152 RVA: 0x002AEEA0 File Offset: 0x002AD0A0
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return TerrorZonesReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x0600B061 RID: 45153 RVA: 0x002AEEC4 File Offset: 0x002AD0C4
		public static ServerServiceDefinition BindService(TerrorZones.TerrorZonesBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<TerrorZonesMessageRequest, NoData>(TerrorZones.__Method_TerrorZonesMessage, new UnaryServerMethod<TerrorZonesMessageRequest, NoData>(serviceImpl.TerrorZonesMessage)).Build();
		}

		// Token: 0x0600B062 RID: 45154 RVA: 0x002AEEF7 File Offset: 0x002AD0F7
		public static void BindService(ServiceBinderBase serviceBinder, TerrorZones.TerrorZonesBase serviceImpl)
		{
			serviceBinder.AddMethod<TerrorZonesMessageRequest, NoData>(TerrorZones.__Method_TerrorZonesMessage, (serviceImpl == null) ? null : new UnaryServerMethod<TerrorZonesMessageRequest, NoData>(serviceImpl.TerrorZonesMessage));
		}

		// Token: 0x04004F90 RID: 20368
		private static readonly string __ServiceName = "classic.protocol.external.v1.terror_zones.TerrorZones";

		// Token: 0x04004F91 RID: 20369
		private static readonly Marshaller<TerrorZonesMessageRequest> __Marshaller_classic_protocol_external_v1_terror_zones_TerrorZonesMessageRequest = Marshallers.Create<TerrorZonesMessageRequest>(new Action<TerrorZonesMessageRequest, SerializationContext>(TerrorZones.__Helper_SerializeMessage), (DeserializationContext context) => TerrorZones.__Helper_DeserializeMessage<TerrorZonesMessageRequest>(context, TerrorZonesMessageRequest.Parser));

		// Token: 0x04004F92 RID: 20370
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(TerrorZones.__Helper_SerializeMessage), (DeserializationContext context) => TerrorZones.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x04004F93 RID: 20371
		private static readonly Method<TerrorZonesMessageRequest, NoData> __Method_TerrorZonesMessage = new Method<TerrorZonesMessageRequest, NoData>(0, TerrorZones.__ServiceName, "TerrorZonesMessage", TerrorZones.__Marshaller_classic_protocol_external_v1_terror_zones_TerrorZonesMessageRequest, TerrorZones.__Marshaller_bgs_protocol_NoData);

		// Token: 0x020012A1 RID: 4769
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x040099B5 RID: 39349
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x020012A2 RID: 4770
		[BindServiceMethod(typeof(TerrorZones), "BindService")]
		public abstract class TerrorZonesBase
		{
			// Token: 0x0600DD63 RID: 56675 RVA: 0x004BFDA4 File Offset: 0x004BDFA4
			public virtual Task<NoData> TerrorZonesMessage(TerrorZonesMessageRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x020012A3 RID: 4771
		public class TerrorZonesClient : ClientBase<TerrorZones.TerrorZonesClient>
		{
			// Token: 0x0600DD65 RID: 56677 RVA: 0x004BFDC1 File Offset: 0x004BDFC1
			public TerrorZonesClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600DD66 RID: 56678 RVA: 0x004BFDCC File Offset: 0x004BDFCC
			public TerrorZonesClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600DD67 RID: 56679 RVA: 0x004BFDD7 File Offset: 0x004BDFD7
			protected TerrorZonesClient()
			{
			}

			// Token: 0x0600DD68 RID: 56680 RVA: 0x004BFDE1 File Offset: 0x004BDFE1
			protected TerrorZonesClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600DD69 RID: 56681 RVA: 0x004BFDEC File Offset: 0x004BDFEC
			public virtual NoData TerrorZonesMessage(TerrorZonesMessageRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.TerrorZonesMessage(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DD6A RID: 56682 RVA: 0x004BFE14 File Offset: 0x004BE014
			public virtual NoData TerrorZonesMessage(TerrorZonesMessageRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<TerrorZonesMessageRequest, NoData>(TerrorZones.__Method_TerrorZonesMessage, null, options, request);
			}

			// Token: 0x0600DD6B RID: 56683 RVA: 0x004BFE3C File Offset: 0x004BE03C
			public virtual AsyncUnaryCall<NoData> TerrorZonesMessageAsync(TerrorZonesMessageRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.TerrorZonesMessageAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DD6C RID: 56684 RVA: 0x004BFE64 File Offset: 0x004BE064
			public virtual AsyncUnaryCall<NoData> TerrorZonesMessageAsync(TerrorZonesMessageRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<TerrorZonesMessageRequest, NoData>(TerrorZones.__Method_TerrorZonesMessage, null, options, request);
			}

			// Token: 0x0600DD6D RID: 56685 RVA: 0x004BFE8C File Offset: 0x004BE08C
			protected override TerrorZones.TerrorZonesClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new TerrorZones.TerrorZonesClient(configuration);
			}
		}
	}
}
