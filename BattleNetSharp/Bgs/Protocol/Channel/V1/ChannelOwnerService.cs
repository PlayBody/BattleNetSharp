using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006D6 RID: 1750
	public static class ChannelOwnerService
	{
		// Token: 0x0600A17D RID: 41341 RVA: 0x002745D4 File Offset: 0x002727D4
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

		// Token: 0x0600A17E RID: 41342 RVA: 0x00274620 File Offset: 0x00272820
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = ChannelOwnerService.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17003207 RID: 12807
		// (get) Token: 0x0600A17F RID: 41343 RVA: 0x00274658 File Offset: 0x00272858
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return ChannelOwnerServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x0600A180 RID: 41344 RVA: 0x0027467C File Offset: 0x0027287C
		public static ServerServiceDefinition BindService(ChannelOwnerService.ChannelOwnerServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<CreateChannelRequest, CreateChannelResponse>(ChannelOwnerService.__Method_CreateChannel, new UnaryServerMethod<CreateChannelRequest, CreateChannelResponse>(serviceImpl.CreateChannel)).AddMethod<JoinChannelRequest, JoinChannelResponse>(ChannelOwnerService.__Method_JoinChannel, new UnaryServerMethod<JoinChannelRequest, JoinChannelResponse>(serviceImpl.JoinChannel))
				.AddMethod<ListChannelsRequest, ListChannelsResponse>(ChannelOwnerService.__Method_ListChannels, new UnaryServerMethod<ListChannelsRequest, ListChannelsResponse>(serviceImpl.ListChannels))
				.AddMethod<GetChannelInfoRequest, GetChannelInfoResponse>(ChannelOwnerService.__Method_GetChannelInfo, new UnaryServerMethod<GetChannelInfoRequest, GetChannelInfoResponse>(serviceImpl.GetChannelInfo))
				.AddMethod<SubscribeChannelRequest, SubscribeChannelResponse>(ChannelOwnerService.__Method_SubscribeChannel, new UnaryServerMethod<SubscribeChannelRequest, SubscribeChannelResponse>(serviceImpl.SubscribeChannel))
				.Build();
		}

		// Token: 0x0600A181 RID: 41345 RVA: 0x0027470C File Offset: 0x0027290C
		public static void BindService(ServiceBinderBase serviceBinder, ChannelOwnerService.ChannelOwnerServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<CreateChannelRequest, CreateChannelResponse>(ChannelOwnerService.__Method_CreateChannel, (serviceImpl == null) ? null : new UnaryServerMethod<CreateChannelRequest, CreateChannelResponse>(serviceImpl.CreateChannel));
			serviceBinder.AddMethod<JoinChannelRequest, JoinChannelResponse>(ChannelOwnerService.__Method_JoinChannel, (serviceImpl == null) ? null : new UnaryServerMethod<JoinChannelRequest, JoinChannelResponse>(serviceImpl.JoinChannel));
			serviceBinder.AddMethod<ListChannelsRequest, ListChannelsResponse>(ChannelOwnerService.__Method_ListChannels, (serviceImpl == null) ? null : new UnaryServerMethod<ListChannelsRequest, ListChannelsResponse>(serviceImpl.ListChannels));
			serviceBinder.AddMethod<GetChannelInfoRequest, GetChannelInfoResponse>(ChannelOwnerService.__Method_GetChannelInfo, (serviceImpl == null) ? null : new UnaryServerMethod<GetChannelInfoRequest, GetChannelInfoResponse>(serviceImpl.GetChannelInfo));
			serviceBinder.AddMethod<SubscribeChannelRequest, SubscribeChannelResponse>(ChannelOwnerService.__Method_SubscribeChannel, (serviceImpl == null) ? null : new UnaryServerMethod<SubscribeChannelRequest, SubscribeChannelResponse>(serviceImpl.SubscribeChannel));
		}

		// Token: 0x040048B5 RID: 18613
		private static readonly string __ServiceName = "bgs.protocol.channel.v1.ChannelOwnerService";

		// Token: 0x040048B6 RID: 18614
		private static readonly Marshaller<CreateChannelRequest> __Marshaller_bgs_protocol_channel_v1_CreateChannelRequest = Marshallers.Create<CreateChannelRequest>(new Action<CreateChannelRequest, SerializationContext>(ChannelOwnerService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelOwnerService.__Helper_DeserializeMessage<CreateChannelRequest>(context, CreateChannelRequest.Parser));

		// Token: 0x040048B7 RID: 18615
		private static readonly Marshaller<CreateChannelResponse> __Marshaller_bgs_protocol_channel_v1_CreateChannelResponse = Marshallers.Create<CreateChannelResponse>(new Action<CreateChannelResponse, SerializationContext>(ChannelOwnerService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelOwnerService.__Helper_DeserializeMessage<CreateChannelResponse>(context, CreateChannelResponse.Parser));

		// Token: 0x040048B8 RID: 18616
		private static readonly Marshaller<JoinChannelRequest> __Marshaller_bgs_protocol_channel_v1_JoinChannelRequest = Marshallers.Create<JoinChannelRequest>(new Action<JoinChannelRequest, SerializationContext>(ChannelOwnerService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelOwnerService.__Helper_DeserializeMessage<JoinChannelRequest>(context, JoinChannelRequest.Parser));

		// Token: 0x040048B9 RID: 18617
		private static readonly Marshaller<JoinChannelResponse> __Marshaller_bgs_protocol_channel_v1_JoinChannelResponse = Marshallers.Create<JoinChannelResponse>(new Action<JoinChannelResponse, SerializationContext>(ChannelOwnerService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelOwnerService.__Helper_DeserializeMessage<JoinChannelResponse>(context, JoinChannelResponse.Parser));

		// Token: 0x040048BA RID: 18618
		private static readonly Marshaller<ListChannelsRequest> __Marshaller_bgs_protocol_channel_v1_ListChannelsRequest = Marshallers.Create<ListChannelsRequest>(new Action<ListChannelsRequest, SerializationContext>(ChannelOwnerService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelOwnerService.__Helper_DeserializeMessage<ListChannelsRequest>(context, ListChannelsRequest.Parser));

		// Token: 0x040048BB RID: 18619
		private static readonly Marshaller<ListChannelsResponse> __Marshaller_bgs_protocol_channel_v1_ListChannelsResponse = Marshallers.Create<ListChannelsResponse>(new Action<ListChannelsResponse, SerializationContext>(ChannelOwnerService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelOwnerService.__Helper_DeserializeMessage<ListChannelsResponse>(context, ListChannelsResponse.Parser));

		// Token: 0x040048BC RID: 18620
		private static readonly Marshaller<GetChannelInfoRequest> __Marshaller_bgs_protocol_channel_v1_GetChannelInfoRequest = Marshallers.Create<GetChannelInfoRequest>(new Action<GetChannelInfoRequest, SerializationContext>(ChannelOwnerService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelOwnerService.__Helper_DeserializeMessage<GetChannelInfoRequest>(context, GetChannelInfoRequest.Parser));

		// Token: 0x040048BD RID: 18621
		private static readonly Marshaller<GetChannelInfoResponse> __Marshaller_bgs_protocol_channel_v1_GetChannelInfoResponse = Marshallers.Create<GetChannelInfoResponse>(new Action<GetChannelInfoResponse, SerializationContext>(ChannelOwnerService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelOwnerService.__Helper_DeserializeMessage<GetChannelInfoResponse>(context, GetChannelInfoResponse.Parser));

		// Token: 0x040048BE RID: 18622
		private static readonly Marshaller<SubscribeChannelRequest> __Marshaller_bgs_protocol_channel_v1_SubscribeChannelRequest = Marshallers.Create<SubscribeChannelRequest>(new Action<SubscribeChannelRequest, SerializationContext>(ChannelOwnerService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelOwnerService.__Helper_DeserializeMessage<SubscribeChannelRequest>(context, SubscribeChannelRequest.Parser));

		// Token: 0x040048BF RID: 18623
		private static readonly Marshaller<SubscribeChannelResponse> __Marshaller_bgs_protocol_channel_v1_SubscribeChannelResponse = Marshallers.Create<SubscribeChannelResponse>(new Action<SubscribeChannelResponse, SerializationContext>(ChannelOwnerService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelOwnerService.__Helper_DeserializeMessage<SubscribeChannelResponse>(context, SubscribeChannelResponse.Parser));

		// Token: 0x040048C0 RID: 18624
		private static readonly Method<CreateChannelRequest, CreateChannelResponse> __Method_CreateChannel = new Method<CreateChannelRequest, CreateChannelResponse>(0, ChannelOwnerService.__ServiceName, "CreateChannel", ChannelOwnerService.__Marshaller_bgs_protocol_channel_v1_CreateChannelRequest, ChannelOwnerService.__Marshaller_bgs_protocol_channel_v1_CreateChannelResponse);

		// Token: 0x040048C1 RID: 18625
		private static readonly Method<JoinChannelRequest, JoinChannelResponse> __Method_JoinChannel = new Method<JoinChannelRequest, JoinChannelResponse>(0, ChannelOwnerService.__ServiceName, "JoinChannel", ChannelOwnerService.__Marshaller_bgs_protocol_channel_v1_JoinChannelRequest, ChannelOwnerService.__Marshaller_bgs_protocol_channel_v1_JoinChannelResponse);

		// Token: 0x040048C2 RID: 18626
		private static readonly Method<ListChannelsRequest, ListChannelsResponse> __Method_ListChannels = new Method<ListChannelsRequest, ListChannelsResponse>(0, ChannelOwnerService.__ServiceName, "ListChannels", ChannelOwnerService.__Marshaller_bgs_protocol_channel_v1_ListChannelsRequest, ChannelOwnerService.__Marshaller_bgs_protocol_channel_v1_ListChannelsResponse);

		// Token: 0x040048C3 RID: 18627
		private static readonly Method<GetChannelInfoRequest, GetChannelInfoResponse> __Method_GetChannelInfo = new Method<GetChannelInfoRequest, GetChannelInfoResponse>(0, ChannelOwnerService.__ServiceName, "GetChannelInfo", ChannelOwnerService.__Marshaller_bgs_protocol_channel_v1_GetChannelInfoRequest, ChannelOwnerService.__Marshaller_bgs_protocol_channel_v1_GetChannelInfoResponse);

		// Token: 0x040048C4 RID: 18628
		private static readonly Method<SubscribeChannelRequest, SubscribeChannelResponse> __Method_SubscribeChannel = new Method<SubscribeChannelRequest, SubscribeChannelResponse>(0, ChannelOwnerService.__ServiceName, "SubscribeChannel", ChannelOwnerService.__Marshaller_bgs_protocol_channel_v1_SubscribeChannelRequest, ChannelOwnerService.__Marshaller_bgs_protocol_channel_v1_SubscribeChannelResponse);

		// Token: 0x020011DC RID: 4572
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x0400990C RID: 39180
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x020011DD RID: 4573
		[BindServiceMethod(typeof(ChannelOwnerService), "BindService")]
		public abstract class ChannelOwnerServiceBase
		{
			// Token: 0x0600D968 RID: 55656 RVA: 0x004BAAFC File Offset: 0x004B8CFC
			public virtual Task<CreateChannelResponse> CreateChannel(CreateChannelRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D969 RID: 55657 RVA: 0x004BAB10 File Offset: 0x004B8D10
			public virtual Task<JoinChannelResponse> JoinChannel(JoinChannelRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D96A RID: 55658 RVA: 0x004BAB24 File Offset: 0x004B8D24
			public virtual Task<ListChannelsResponse> ListChannels(ListChannelsRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D96B RID: 55659 RVA: 0x004BAB38 File Offset: 0x004B8D38
			public virtual Task<GetChannelInfoResponse> GetChannelInfo(GetChannelInfoRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D96C RID: 55660 RVA: 0x004BAB4C File Offset: 0x004B8D4C
			public virtual Task<SubscribeChannelResponse> SubscribeChannel(SubscribeChannelRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x020011DE RID: 4574
		public class ChannelOwnerServiceClient : ClientBase<ChannelOwnerService.ChannelOwnerServiceClient>
		{
			// Token: 0x0600D96E RID: 55662 RVA: 0x004BAB69 File Offset: 0x004B8D69
			public ChannelOwnerServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D96F RID: 55663 RVA: 0x004BAB74 File Offset: 0x004B8D74
			public ChannelOwnerServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D970 RID: 55664 RVA: 0x004BAB7F File Offset: 0x004B8D7F
			protected ChannelOwnerServiceClient()
			{
			}

			// Token: 0x0600D971 RID: 55665 RVA: 0x004BAB89 File Offset: 0x004B8D89
			protected ChannelOwnerServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D972 RID: 55666 RVA: 0x004BAB94 File Offset: 0x004B8D94
			public virtual CreateChannelResponse CreateChannel(CreateChannelRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.CreateChannel(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D973 RID: 55667 RVA: 0x004BABBC File Offset: 0x004B8DBC
			public virtual CreateChannelResponse CreateChannel(CreateChannelRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<CreateChannelRequest, CreateChannelResponse>(ChannelOwnerService.__Method_CreateChannel, null, options, request);
			}

			// Token: 0x0600D974 RID: 55668 RVA: 0x004BABE4 File Offset: 0x004B8DE4
			public virtual AsyncUnaryCall<CreateChannelResponse> CreateChannelAsync(CreateChannelRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.CreateChannelAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D975 RID: 55669 RVA: 0x004BAC0C File Offset: 0x004B8E0C
			public virtual AsyncUnaryCall<CreateChannelResponse> CreateChannelAsync(CreateChannelRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<CreateChannelRequest, CreateChannelResponse>(ChannelOwnerService.__Method_CreateChannel, null, options, request);
			}

			// Token: 0x0600D976 RID: 55670 RVA: 0x004BAC34 File Offset: 0x004B8E34
			public virtual JoinChannelResponse JoinChannel(JoinChannelRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.JoinChannel(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D977 RID: 55671 RVA: 0x004BAC5C File Offset: 0x004B8E5C
			public virtual JoinChannelResponse JoinChannel(JoinChannelRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<JoinChannelRequest, JoinChannelResponse>(ChannelOwnerService.__Method_JoinChannel, null, options, request);
			}

			// Token: 0x0600D978 RID: 55672 RVA: 0x004BAC84 File Offset: 0x004B8E84
			public virtual AsyncUnaryCall<JoinChannelResponse> JoinChannelAsync(JoinChannelRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.JoinChannelAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D979 RID: 55673 RVA: 0x004BACAC File Offset: 0x004B8EAC
			public virtual AsyncUnaryCall<JoinChannelResponse> JoinChannelAsync(JoinChannelRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<JoinChannelRequest, JoinChannelResponse>(ChannelOwnerService.__Method_JoinChannel, null, options, request);
			}

			// Token: 0x0600D97A RID: 55674 RVA: 0x004BACD4 File Offset: 0x004B8ED4
			public virtual ListChannelsResponse ListChannels(ListChannelsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ListChannels(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D97B RID: 55675 RVA: 0x004BACFC File Offset: 0x004B8EFC
			public virtual ListChannelsResponse ListChannels(ListChannelsRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ListChannelsRequest, ListChannelsResponse>(ChannelOwnerService.__Method_ListChannels, null, options, request);
			}

			// Token: 0x0600D97C RID: 55676 RVA: 0x004BAD24 File Offset: 0x004B8F24
			public virtual AsyncUnaryCall<ListChannelsResponse> ListChannelsAsync(ListChannelsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ListChannelsAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D97D RID: 55677 RVA: 0x004BAD4C File Offset: 0x004B8F4C
			public virtual AsyncUnaryCall<ListChannelsResponse> ListChannelsAsync(ListChannelsRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ListChannelsRequest, ListChannelsResponse>(ChannelOwnerService.__Method_ListChannels, null, options, request);
			}

			// Token: 0x0600D97E RID: 55678 RVA: 0x004BAD74 File Offset: 0x004B8F74
			public virtual GetChannelInfoResponse GetChannelInfo(GetChannelInfoRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetChannelInfo(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D97F RID: 55679 RVA: 0x004BAD9C File Offset: 0x004B8F9C
			public virtual GetChannelInfoResponse GetChannelInfo(GetChannelInfoRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetChannelInfoRequest, GetChannelInfoResponse>(ChannelOwnerService.__Method_GetChannelInfo, null, options, request);
			}

			// Token: 0x0600D980 RID: 55680 RVA: 0x004BADC4 File Offset: 0x004B8FC4
			public virtual AsyncUnaryCall<GetChannelInfoResponse> GetChannelInfoAsync(GetChannelInfoRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetChannelInfoAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D981 RID: 55681 RVA: 0x004BADEC File Offset: 0x004B8FEC
			public virtual AsyncUnaryCall<GetChannelInfoResponse> GetChannelInfoAsync(GetChannelInfoRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetChannelInfoRequest, GetChannelInfoResponse>(ChannelOwnerService.__Method_GetChannelInfo, null, options, request);
			}

			// Token: 0x0600D982 RID: 55682 RVA: 0x004BAE14 File Offset: 0x004B9014
			public virtual SubscribeChannelResponse SubscribeChannel(SubscribeChannelRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SubscribeChannel(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D983 RID: 55683 RVA: 0x004BAE3C File Offset: 0x004B903C
			public virtual SubscribeChannelResponse SubscribeChannel(SubscribeChannelRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SubscribeChannelRequest, SubscribeChannelResponse>(ChannelOwnerService.__Method_SubscribeChannel, null, options, request);
			}

			// Token: 0x0600D984 RID: 55684 RVA: 0x004BAE64 File Offset: 0x004B9064
			public virtual AsyncUnaryCall<SubscribeChannelResponse> SubscribeChannelAsync(SubscribeChannelRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SubscribeChannelAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D985 RID: 55685 RVA: 0x004BAE8C File Offset: 0x004B908C
			public virtual AsyncUnaryCall<SubscribeChannelResponse> SubscribeChannelAsync(SubscribeChannelRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SubscribeChannelRequest, SubscribeChannelResponse>(ChannelOwnerService.__Method_SubscribeChannel, null, options, request);
			}

			// Token: 0x0600D986 RID: 55686 RVA: 0x004BAEB4 File Offset: 0x004B90B4
			protected override ChannelOwnerService.ChannelOwnerServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new ChannelOwnerService.ChannelOwnerServiceClient(configuration);
			}
		}
	}
}
