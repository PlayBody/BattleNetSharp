using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Resources.V1
{
	// Token: 0x020003DD RID: 989
	public static class ResourcesService
	{
		// Token: 0x060062C8 RID: 25288 RVA: 0x0017E328 File Offset: 0x0017C528
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

		// Token: 0x060062C9 RID: 25289 RVA: 0x0017E374 File Offset: 0x0017C574
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = ResourcesService.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17001FD7 RID: 8151
		// (get) Token: 0x060062CA RID: 25290 RVA: 0x0017E3AC File Offset: 0x0017C5AC
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return ResourceServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x060062CB RID: 25291 RVA: 0x0017E3D0 File Offset: 0x0017C5D0
		public static ServerServiceDefinition BindService(ResourcesService.ResourcesServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<ContentHandleRequest, ContentHandle>(ResourcesService.__Method_GetContentHandle, new UnaryServerMethod<ContentHandleRequest, ContentHandle>(serviceImpl.GetContentHandle)).AddMethod<GetTitleIconsRequest, GetTitleIconsResponse>(ResourcesService.__Method_GetTitleIcons, new UnaryServerMethod<GetTitleIconsRequest, GetTitleIconsResponse>(serviceImpl.GetTitleIcons))
				.Build();
		}

		// Token: 0x060062CC RID: 25292 RVA: 0x0017E41C File Offset: 0x0017C61C
		public static void BindService(ServiceBinderBase serviceBinder, ResourcesService.ResourcesServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<ContentHandleRequest, ContentHandle>(ResourcesService.__Method_GetContentHandle, (serviceImpl == null) ? null : new UnaryServerMethod<ContentHandleRequest, ContentHandle>(serviceImpl.GetContentHandle));
			serviceBinder.AddMethod<GetTitleIconsRequest, GetTitleIconsResponse>(ResourcesService.__Method_GetTitleIcons, (serviceImpl == null) ? null : new UnaryServerMethod<GetTitleIconsRequest, GetTitleIconsResponse>(serviceImpl.GetTitleIcons));
		}

		// Token: 0x04002D1E RID: 11550
		private static readonly string __ServiceName = "bgs.protocol.resources.v1.ResourcesService";

		// Token: 0x04002D1F RID: 11551
		private static readonly Marshaller<ContentHandleRequest> __Marshaller_bgs_protocol_resources_v1_ContentHandleRequest = Marshallers.Create<ContentHandleRequest>(new Action<ContentHandleRequest, SerializationContext>(ResourcesService.__Helper_SerializeMessage), (DeserializationContext context) => ResourcesService.__Helper_DeserializeMessage<ContentHandleRequest>(context, ContentHandleRequest.Parser));

		// Token: 0x04002D20 RID: 11552
		private static readonly Marshaller<ContentHandle> __Marshaller_bgs_protocol_ContentHandle = Marshallers.Create<ContentHandle>(new Action<ContentHandle, SerializationContext>(ResourcesService.__Helper_SerializeMessage), (DeserializationContext context) => ResourcesService.__Helper_DeserializeMessage<ContentHandle>(context, ContentHandle.Parser));

		// Token: 0x04002D21 RID: 11553
		private static readonly Marshaller<GetTitleIconsRequest> __Marshaller_bgs_protocol_resources_v1_GetTitleIconsRequest = Marshallers.Create<GetTitleIconsRequest>(new Action<GetTitleIconsRequest, SerializationContext>(ResourcesService.__Helper_SerializeMessage), (DeserializationContext context) => ResourcesService.__Helper_DeserializeMessage<GetTitleIconsRequest>(context, GetTitleIconsRequest.Parser));

		// Token: 0x04002D22 RID: 11554
		private static readonly Marshaller<GetTitleIconsResponse> __Marshaller_bgs_protocol_resources_v1_GetTitleIconsResponse = Marshallers.Create<GetTitleIconsResponse>(new Action<GetTitleIconsResponse, SerializationContext>(ResourcesService.__Helper_SerializeMessage), (DeserializationContext context) => ResourcesService.__Helper_DeserializeMessage<GetTitleIconsResponse>(context, GetTitleIconsResponse.Parser));

		// Token: 0x04002D23 RID: 11555
		private static readonly Method<ContentHandleRequest, ContentHandle> __Method_GetContentHandle = new Method<ContentHandleRequest, ContentHandle>(0, ResourcesService.__ServiceName, "GetContentHandle", ResourcesService.__Marshaller_bgs_protocol_resources_v1_ContentHandleRequest, ResourcesService.__Marshaller_bgs_protocol_ContentHandle);

		// Token: 0x04002D24 RID: 11556
		private static readonly Method<GetTitleIconsRequest, GetTitleIconsResponse> __Method_GetTitleIcons = new Method<GetTitleIconsRequest, GetTitleIconsResponse>(0, ResourcesService.__ServiceName, "GetTitleIcons", ResourcesService.__Marshaller_bgs_protocol_resources_v1_GetTitleIconsRequest, ResourcesService.__Marshaller_bgs_protocol_resources_v1_GetTitleIconsResponse);

		// Token: 0x02000EB2 RID: 3762
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x04009617 RID: 38423
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02000EB3 RID: 3763
		[BindServiceMethod(typeof(ResourcesService), "BindService")]
		public abstract class ResourcesServiceBase
		{
			// Token: 0x0600CB10 RID: 51984 RVA: 0x004AA4E8 File Offset: 0x004A86E8
			public virtual Task<ContentHandle> GetContentHandle(ContentHandleRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CB11 RID: 51985 RVA: 0x004AA4FC File Offset: 0x004A86FC
			public virtual Task<GetTitleIconsResponse> GetTitleIcons(GetTitleIconsRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x02000EB4 RID: 3764
		public class ResourcesServiceClient : ClientBase<ResourcesService.ResourcesServiceClient>
		{
			// Token: 0x0600CB13 RID: 51987 RVA: 0x004AA519 File Offset: 0x004A8719
			public ResourcesServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600CB14 RID: 51988 RVA: 0x004AA524 File Offset: 0x004A8724
			public ResourcesServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600CB15 RID: 51989 RVA: 0x004AA52F File Offset: 0x004A872F
			protected ResourcesServiceClient()
			{
			}

			// Token: 0x0600CB16 RID: 51990 RVA: 0x004AA539 File Offset: 0x004A8739
			protected ResourcesServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600CB17 RID: 51991 RVA: 0x004AA544 File Offset: 0x004A8744
			public virtual ContentHandle GetContentHandle(ContentHandleRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetContentHandle(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CB18 RID: 51992 RVA: 0x004AA56C File Offset: 0x004A876C
			public virtual ContentHandle GetContentHandle(ContentHandleRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ContentHandleRequest, ContentHandle>(ResourcesService.__Method_GetContentHandle, null, options, request);
			}

			// Token: 0x0600CB19 RID: 51993 RVA: 0x004AA594 File Offset: 0x004A8794
			public virtual AsyncUnaryCall<ContentHandle> GetContentHandleAsync(ContentHandleRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetContentHandleAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CB1A RID: 51994 RVA: 0x004AA5BC File Offset: 0x004A87BC
			public virtual AsyncUnaryCall<ContentHandle> GetContentHandleAsync(ContentHandleRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ContentHandleRequest, ContentHandle>(ResourcesService.__Method_GetContentHandle, null, options, request);
			}

			// Token: 0x0600CB1B RID: 51995 RVA: 0x004AA5E4 File Offset: 0x004A87E4
			public virtual GetTitleIconsResponse GetTitleIcons(GetTitleIconsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetTitleIcons(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CB1C RID: 51996 RVA: 0x004AA60C File Offset: 0x004A880C
			public virtual GetTitleIconsResponse GetTitleIcons(GetTitleIconsRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetTitleIconsRequest, GetTitleIconsResponse>(ResourcesService.__Method_GetTitleIcons, null, options, request);
			}

			// Token: 0x0600CB1D RID: 51997 RVA: 0x004AA634 File Offset: 0x004A8834
			public virtual AsyncUnaryCall<GetTitleIconsResponse> GetTitleIconsAsync(GetTitleIconsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetTitleIconsAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CB1E RID: 51998 RVA: 0x004AA65C File Offset: 0x004A885C
			public virtual AsyncUnaryCall<GetTitleIconsResponse> GetTitleIconsAsync(GetTitleIconsRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetTitleIconsRequest, GetTitleIconsResponse>(ResourcesService.__Method_GetTitleIcons, null, options, request);
			}

			// Token: 0x0600CB1F RID: 51999 RVA: 0x004AA684 File Offset: 0x004A8884
			protected override ResourcesService.ResourcesServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new ResourcesService.ResourcesServiceClient(configuration);
			}
		}
	}
}
