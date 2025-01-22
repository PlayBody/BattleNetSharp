using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Channel.V2.Membership
{
	// Token: 0x020006B3 RID: 1715
	public static class ChannelMembershipService
	{
		// Token: 0x06009ED6 RID: 40662 RVA: 0x00269F20 File Offset: 0x00268120
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

		// Token: 0x06009ED7 RID: 40663 RVA: 0x00269F6C File Offset: 0x0026816C
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = ChannelMembershipService.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x1700314F RID: 12623
		// (get) Token: 0x06009ED8 RID: 40664 RVA: 0x00269FA4 File Offset: 0x002681A4
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return ChannelMembershipServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x06009ED9 RID: 40665 RVA: 0x00269FC8 File Offset: 0x002681C8
		public static ServerServiceDefinition BindService(ChannelMembershipService.ChannelMembershipServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<SubscribeRequest, SubscribeResponse>(ChannelMembershipService.__Method_Subscribe, new UnaryServerMethod<SubscribeRequest, SubscribeResponse>(serviceImpl.Subscribe)).AddMethod<UnsubscribeRequest, NoData>(ChannelMembershipService.__Method_Unsubscribe, new UnaryServerMethod<UnsubscribeRequest, NoData>(serviceImpl.Unsubscribe))
				.AddMethod<GetStateRequest, GetStateResponse>(ChannelMembershipService.__Method_GetState, new UnaryServerMethod<GetStateRequest, GetStateResponse>(serviceImpl.GetState))
				.Build();
		}

		// Token: 0x06009EDA RID: 40666 RVA: 0x0026A02C File Offset: 0x0026822C
		public static void BindService(ServiceBinderBase serviceBinder, ChannelMembershipService.ChannelMembershipServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<SubscribeRequest, SubscribeResponse>(ChannelMembershipService.__Method_Subscribe, (serviceImpl == null) ? null : new UnaryServerMethod<SubscribeRequest, SubscribeResponse>(serviceImpl.Subscribe));
			serviceBinder.AddMethod<UnsubscribeRequest, NoData>(ChannelMembershipService.__Method_Unsubscribe, (serviceImpl == null) ? null : new UnaryServerMethod<UnsubscribeRequest, NoData>(serviceImpl.Unsubscribe));
			serviceBinder.AddMethod<GetStateRequest, GetStateResponse>(ChannelMembershipService.__Method_GetState, (serviceImpl == null) ? null : new UnaryServerMethod<GetStateRequest, GetStateResponse>(serviceImpl.GetState));
		}

		// Token: 0x04004799 RID: 18329
		private static readonly string __ServiceName = "bgs.protocol.channel.v2.membership.ChannelMembershipService";

		// Token: 0x0400479A RID: 18330
		private static readonly Marshaller<SubscribeRequest> __Marshaller_bgs_protocol_channel_v2_membership_SubscribeRequest = Marshallers.Create<SubscribeRequest>(new Action<SubscribeRequest, SerializationContext>(ChannelMembershipService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelMembershipService.__Helper_DeserializeMessage<SubscribeRequest>(context, SubscribeRequest.Parser));

		// Token: 0x0400479B RID: 18331
		private static readonly Marshaller<SubscribeResponse> __Marshaller_bgs_protocol_channel_v2_membership_SubscribeResponse = Marshallers.Create<SubscribeResponse>(new Action<SubscribeResponse, SerializationContext>(ChannelMembershipService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelMembershipService.__Helper_DeserializeMessage<SubscribeResponse>(context, SubscribeResponse.Parser));

		// Token: 0x0400479C RID: 18332
		private static readonly Marshaller<UnsubscribeRequest> __Marshaller_bgs_protocol_channel_v2_membership_UnsubscribeRequest = Marshallers.Create<UnsubscribeRequest>(new Action<UnsubscribeRequest, SerializationContext>(ChannelMembershipService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelMembershipService.__Helper_DeserializeMessage<UnsubscribeRequest>(context, UnsubscribeRequest.Parser));

		// Token: 0x0400479D RID: 18333
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(ChannelMembershipService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelMembershipService.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x0400479E RID: 18334
		private static readonly Marshaller<GetStateRequest> __Marshaller_bgs_protocol_channel_v2_membership_GetStateRequest = Marshallers.Create<GetStateRequest>(new Action<GetStateRequest, SerializationContext>(ChannelMembershipService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelMembershipService.__Helper_DeserializeMessage<GetStateRequest>(context, GetStateRequest.Parser));

		// Token: 0x0400479F RID: 18335
		private static readonly Marshaller<GetStateResponse> __Marshaller_bgs_protocol_channel_v2_membership_GetStateResponse = Marshallers.Create<GetStateResponse>(new Action<GetStateResponse, SerializationContext>(ChannelMembershipService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelMembershipService.__Helper_DeserializeMessage<GetStateResponse>(context, GetStateResponse.Parser));

		// Token: 0x040047A0 RID: 18336
		private static readonly Method<SubscribeRequest, SubscribeResponse> __Method_Subscribe = new Method<SubscribeRequest, SubscribeResponse>(0, ChannelMembershipService.__ServiceName, "Subscribe", ChannelMembershipService.__Marshaller_bgs_protocol_channel_v2_membership_SubscribeRequest, ChannelMembershipService.__Marshaller_bgs_protocol_channel_v2_membership_SubscribeResponse);

		// Token: 0x040047A1 RID: 18337
		private static readonly Method<UnsubscribeRequest, NoData> __Method_Unsubscribe = new Method<UnsubscribeRequest, NoData>(0, ChannelMembershipService.__ServiceName, "Unsubscribe", ChannelMembershipService.__Marshaller_bgs_protocol_channel_v2_membership_UnsubscribeRequest, ChannelMembershipService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x040047A2 RID: 18338
		private static readonly Method<GetStateRequest, GetStateResponse> __Method_GetState = new Method<GetStateRequest, GetStateResponse>(0, ChannelMembershipService.__ServiceName, "GetState", ChannelMembershipService.__Marshaller_bgs_protocol_channel_v2_membership_GetStateRequest, ChannelMembershipService.__Marshaller_bgs_protocol_channel_v2_membership_GetStateResponse);

		// Token: 0x020011AF RID: 4527
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x040098E7 RID: 39143
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x020011B0 RID: 4528
		[BindServiceMethod(typeof(ChannelMembershipService), "BindService")]
		public abstract class ChannelMembershipServiceBase
		{
			// Token: 0x0600D883 RID: 55427 RVA: 0x004B987C File Offset: 0x004B7A7C
			public virtual Task<SubscribeResponse> Subscribe(SubscribeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D884 RID: 55428 RVA: 0x004B9890 File Offset: 0x004B7A90
			public virtual Task<NoData> Unsubscribe(UnsubscribeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D885 RID: 55429 RVA: 0x004B98A4 File Offset: 0x004B7AA4
			public virtual Task<GetStateResponse> GetState(GetStateRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x020011B1 RID: 4529
		public class ChannelMembershipServiceClient : ClientBase<ChannelMembershipService.ChannelMembershipServiceClient>
		{
			// Token: 0x0600D887 RID: 55431 RVA: 0x004B98C1 File Offset: 0x004B7AC1
			public ChannelMembershipServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D888 RID: 55432 RVA: 0x004B98CC File Offset: 0x004B7ACC
			public ChannelMembershipServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D889 RID: 55433 RVA: 0x004B98D7 File Offset: 0x004B7AD7
			protected ChannelMembershipServiceClient()
			{
			}

			// Token: 0x0600D88A RID: 55434 RVA: 0x004B98E1 File Offset: 0x004B7AE1
			protected ChannelMembershipServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D88B RID: 55435 RVA: 0x004B98EC File Offset: 0x004B7AEC
			public virtual SubscribeResponse Subscribe(SubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Subscribe(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D88C RID: 55436 RVA: 0x004B9914 File Offset: 0x004B7B14
			public virtual SubscribeResponse Subscribe(SubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SubscribeRequest, SubscribeResponse>(ChannelMembershipService.__Method_Subscribe, null, options, request);
			}

			// Token: 0x0600D88D RID: 55437 RVA: 0x004B993C File Offset: 0x004B7B3C
			public virtual AsyncUnaryCall<SubscribeResponse> SubscribeAsync(SubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SubscribeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D88E RID: 55438 RVA: 0x004B9964 File Offset: 0x004B7B64
			public virtual AsyncUnaryCall<SubscribeResponse> SubscribeAsync(SubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SubscribeRequest, SubscribeResponse>(ChannelMembershipService.__Method_Subscribe, null, options, request);
			}

			// Token: 0x0600D88F RID: 55439 RVA: 0x004B998C File Offset: 0x004B7B8C
			public virtual NoData Unsubscribe(UnsubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Unsubscribe(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D890 RID: 55440 RVA: 0x004B99B4 File Offset: 0x004B7BB4
			public virtual NoData Unsubscribe(UnsubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<UnsubscribeRequest, NoData>(ChannelMembershipService.__Method_Unsubscribe, null, options, request);
			}

			// Token: 0x0600D891 RID: 55441 RVA: 0x004B99DC File Offset: 0x004B7BDC
			public virtual AsyncUnaryCall<NoData> UnsubscribeAsync(UnsubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UnsubscribeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D892 RID: 55442 RVA: 0x004B9A04 File Offset: 0x004B7C04
			public virtual AsyncUnaryCall<NoData> UnsubscribeAsync(UnsubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<UnsubscribeRequest, NoData>(ChannelMembershipService.__Method_Unsubscribe, null, options, request);
			}

			// Token: 0x0600D893 RID: 55443 RVA: 0x004B9A2C File Offset: 0x004B7C2C
			public virtual GetStateResponse GetState(GetStateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetState(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D894 RID: 55444 RVA: 0x004B9A54 File Offset: 0x004B7C54
			public virtual GetStateResponse GetState(GetStateRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetStateRequest, GetStateResponse>(ChannelMembershipService.__Method_GetState, null, options, request);
			}

			// Token: 0x0600D895 RID: 55445 RVA: 0x004B9A7C File Offset: 0x004B7C7C
			public virtual AsyncUnaryCall<GetStateResponse> GetStateAsync(GetStateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetStateAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D896 RID: 55446 RVA: 0x004B9AA4 File Offset: 0x004B7CA4
			public virtual AsyncUnaryCall<GetStateResponse> GetStateAsync(GetStateRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetStateRequest, GetStateResponse>(ChannelMembershipService.__Method_GetState, null, options, request);
			}

			// Token: 0x0600D897 RID: 55447 RVA: 0x004B9ACC File Offset: 0x004B7CCC
			protected override ChannelMembershipService.ChannelMembershipServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new ChannelMembershipService.ChannelMembershipServiceClient(configuration);
			}
		}
	}
}
