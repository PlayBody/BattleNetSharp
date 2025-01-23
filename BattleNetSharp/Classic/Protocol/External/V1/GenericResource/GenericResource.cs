using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Bgs.Protocol;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Classic.Protocol.External.V1.GenericResource
{
	// Token: 0x02000786 RID: 1926
	public static class GenericResource
	{
		// Token: 0x0600B0B4 RID: 45236 RVA: 0x002B0004 File Offset: 0x002AE204
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

		// Token: 0x0600B0B5 RID: 45237 RVA: 0x002B0050 File Offset: 0x002AE250
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = GenericResource.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x170036A3 RID: 13987
		// (get) Token: 0x0600B0B6 RID: 45238 RVA: 0x002B0088 File Offset: 0x002AE288
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return GenericResourceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x0600B0B7 RID: 45239 RVA: 0x002B00AC File Offset: 0x002AE2AC
		public static ServerServiceDefinition BindService(GenericResource.GenericResourceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<AvailableResources, AvailableResources>(GenericResource.__Method_ReqGenericResource, new UnaryServerMethod<AvailableResources, AvailableResources>(serviceImpl.ReqGenericResource)).AddMethod<AvailableResources, NoData>(GenericResource.__Method_SetAvailableResources, new UnaryServerMethod<AvailableResources, NoData>(serviceImpl.SetAvailableResources))
				.Build();
		}

		// Token: 0x0600B0B8 RID: 45240 RVA: 0x002B00F8 File Offset: 0x002AE2F8
		public static void BindService(ServiceBinderBase serviceBinder, GenericResource.GenericResourceBase serviceImpl)
		{
			serviceBinder.AddMethod<AvailableResources, AvailableResources>(GenericResource.__Method_ReqGenericResource, (serviceImpl == null) ? null : new UnaryServerMethod<AvailableResources, AvailableResources>(serviceImpl.ReqGenericResource));
			serviceBinder.AddMethod<AvailableResources, NoData>(GenericResource.__Method_SetAvailableResources, (serviceImpl == null) ? null : new UnaryServerMethod<AvailableResources, NoData>(serviceImpl.SetAvailableResources));
		}

		// Token: 0x04004FB0 RID: 20400
		private static readonly string __ServiceName = "classic.protocol.external.v1.generic_resource.GenericResource";

		// Token: 0x04004FB1 RID: 20401
		private static readonly Marshaller<AvailableResources> __Marshaller_classic_protocol_external_v1_generic_resource_AvailableResources = Marshallers.Create<AvailableResources>(new Action<AvailableResources, SerializationContext>(GenericResource.__Helper_SerializeMessage), (DeserializationContext context) => GenericResource.__Helper_DeserializeMessage<AvailableResources>(context, AvailableResources.Parser));

		// Token: 0x04004FB2 RID: 20402
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(GenericResource.__Helper_SerializeMessage), (DeserializationContext context) => GenericResource.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x04004FB3 RID: 20403
		private static readonly Method<AvailableResources, AvailableResources> __Method_ReqGenericResource = new Method<AvailableResources, AvailableResources>(0, GenericResource.__ServiceName, "ReqGenericResource", GenericResource.__Marshaller_classic_protocol_external_v1_generic_resource_AvailableResources, GenericResource.__Marshaller_classic_protocol_external_v1_generic_resource_AvailableResources);

		// Token: 0x04004FB4 RID: 20404
		private static readonly Method<AvailableResources, NoData> __Method_SetAvailableResources = new Method<AvailableResources, NoData>(0, GenericResource.__ServiceName, "SetAvailableResources", GenericResource.__Marshaller_classic_protocol_external_v1_generic_resource_AvailableResources, GenericResource.__Marshaller_bgs_protocol_NoData);

		// Token: 0x020012AC RID: 4780
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x040099BC RID: 39356
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x020012AD RID: 4781
		[BindServiceMethod(typeof(GenericResource), "BindService")]
		public abstract class GenericResourceBase
		{
			// Token: 0x0600DD8B RID: 56715 RVA: 0x004C0093 File Offset: 0x004BE293
			public virtual Task<AvailableResources> ReqGenericResource(AvailableResources request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600DD8C RID: 56716 RVA: 0x004C00A7 File Offset: 0x004BE2A7
			public virtual Task<NoData> SetAvailableResources(AvailableResources request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x020012AE RID: 4782
		public class GenericResourceClient : ClientBase<GenericResource.GenericResourceClient>
		{
			// Token: 0x0600DD8E RID: 56718 RVA: 0x004C00C4 File Offset: 0x004BE2C4
			public GenericResourceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600DD8F RID: 56719 RVA: 0x004C00CF File Offset: 0x004BE2CF
			public GenericResourceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600DD90 RID: 56720 RVA: 0x004C00DA File Offset: 0x004BE2DA
			protected GenericResourceClient()
			{
			}

			// Token: 0x0600DD91 RID: 56721 RVA: 0x004C00E4 File Offset: 0x004BE2E4
			protected GenericResourceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600DD92 RID: 56722 RVA: 0x004C00F0 File Offset: 0x004BE2F0
			public virtual AvailableResources ReqGenericResource(AvailableResources request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ReqGenericResource(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DD93 RID: 56723 RVA: 0x004C0118 File Offset: 0x004BE318
			public virtual AvailableResources ReqGenericResource(AvailableResources request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<AvailableResources, AvailableResources>(GenericResource.__Method_ReqGenericResource, null, options, request);
			}

			// Token: 0x0600DD94 RID: 56724 RVA: 0x004C0140 File Offset: 0x004BE340
			public virtual AsyncUnaryCall<AvailableResources> ReqGenericResourceAsync(AvailableResources request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ReqGenericResourceAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DD95 RID: 56725 RVA: 0x004C0168 File Offset: 0x004BE368
			public virtual AsyncUnaryCall<AvailableResources> ReqGenericResourceAsync(AvailableResources request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<AvailableResources, AvailableResources>(GenericResource.__Method_ReqGenericResource, null, options, request);
			}

			// Token: 0x0600DD96 RID: 56726 RVA: 0x004C0190 File Offset: 0x004BE390
			public virtual NoData SetAvailableResources(AvailableResources request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SetAvailableResources(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DD97 RID: 56727 RVA: 0x004C01B8 File Offset: 0x004BE3B8
			public virtual NoData SetAvailableResources(AvailableResources request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<AvailableResources, NoData>(GenericResource.__Method_SetAvailableResources, null, options, request);
			}

			// Token: 0x0600DD98 RID: 56728 RVA: 0x004C01E0 File Offset: 0x004BE3E0
			public virtual AsyncUnaryCall<NoData> SetAvailableResourcesAsync(AvailableResources request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SetAvailableResourcesAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DD99 RID: 56729 RVA: 0x004C0208 File Offset: 0x004BE408
			public virtual AsyncUnaryCall<NoData> SetAvailableResourcesAsync(AvailableResources request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<AvailableResources, NoData>(GenericResource.__Method_SetAvailableResources, null, options, request);
			}

			// Token: 0x0600DD9A RID: 56730 RVA: 0x004C0230 File Offset: 0x004BE430
			protected override GenericResource.GenericResourceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new GenericResource.GenericResourceClient(configuration);
			}
		}
	}
}
