using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006E4 RID: 1764
	public static class ChannelService
	{
		// Token: 0x0600A2B9 RID: 41657 RVA: 0x0027A3B8 File Offset: 0x002785B8
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

		// Token: 0x0600A2BA RID: 41658 RVA: 0x0027A404 File Offset: 0x00278604
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = ChannelService.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17003263 RID: 12899
		// (get) Token: 0x0600A2BB RID: 41659 RVA: 0x0027A43C File Offset: 0x0027863C
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x0600A2BC RID: 41660 RVA: 0x0027A460 File Offset: 0x00278660
		public static ServerServiceDefinition BindService(ChannelService.ChannelServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<RemoveMemberRequest, NoData>(ChannelService.__Method_RemoveMember, new UnaryServerMethod<RemoveMemberRequest, NoData>(serviceImpl.RemoveMember)).AddMethod<SendMessageRequest, NoData>(ChannelService.__Method_SendMessage, new UnaryServerMethod<SendMessageRequest, NoData>(serviceImpl.SendMessage))
				.AddMethod<UpdateChannelStateRequest, NoData>(ChannelService.__Method_UpdateChannelState, new UnaryServerMethod<UpdateChannelStateRequest, NoData>(serviceImpl.UpdateChannelState))
				.AddMethod<UpdateMemberStateRequest, NoData>(ChannelService.__Method_UpdateMemberState, new UnaryServerMethod<UpdateMemberStateRequest, NoData>(serviceImpl.UpdateMemberState))
				.AddMethod<DissolveRequest, NoData>(ChannelService.__Method_Dissolve, new UnaryServerMethod<DissolveRequest, NoData>(serviceImpl.Dissolve))
				.Build();
		}

		// Token: 0x0600A2BD RID: 41661 RVA: 0x0027A4F0 File Offset: 0x002786F0
		public static void BindService(ServiceBinderBase serviceBinder, ChannelService.ChannelServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<RemoveMemberRequest, NoData>(ChannelService.__Method_RemoveMember, (serviceImpl == null) ? null : new UnaryServerMethod<RemoveMemberRequest, NoData>(serviceImpl.RemoveMember));
			serviceBinder.AddMethod<SendMessageRequest, NoData>(ChannelService.__Method_SendMessage, (serviceImpl == null) ? null : new UnaryServerMethod<SendMessageRequest, NoData>(serviceImpl.SendMessage));
			serviceBinder.AddMethod<UpdateChannelStateRequest, NoData>(ChannelService.__Method_UpdateChannelState, (serviceImpl == null) ? null : new UnaryServerMethod<UpdateChannelStateRequest, NoData>(serviceImpl.UpdateChannelState));
			serviceBinder.AddMethod<UpdateMemberStateRequest, NoData>(ChannelService.__Method_UpdateMemberState, (serviceImpl == null) ? null : new UnaryServerMethod<UpdateMemberStateRequest, NoData>(serviceImpl.UpdateMemberState));
			serviceBinder.AddMethod<DissolveRequest, NoData>(ChannelService.__Method_Dissolve, (serviceImpl == null) ? null : new UnaryServerMethod<DissolveRequest, NoData>(serviceImpl.Dissolve));
		}

		// Token: 0x0400494D RID: 18765
		private static readonly string __ServiceName = "bgs.protocol.channel.v1.ChannelService";

		// Token: 0x0400494E RID: 18766
		private static readonly Marshaller<RemoveMemberRequest> __Marshaller_bgs_protocol_channel_v1_RemoveMemberRequest = Marshallers.Create<RemoveMemberRequest>(new Action<RemoveMemberRequest, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<RemoveMemberRequest>(context, RemoveMemberRequest.Parser));

		// Token: 0x0400494F RID: 18767
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x04004950 RID: 18768
		private static readonly Marshaller<SendMessageRequest> __Marshaller_bgs_protocol_channel_v1_SendMessageRequest = Marshallers.Create<SendMessageRequest>(new Action<SendMessageRequest, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<SendMessageRequest>(context, SendMessageRequest.Parser));

		// Token: 0x04004951 RID: 18769
		private static readonly Marshaller<UpdateChannelStateRequest> __Marshaller_bgs_protocol_channel_v1_UpdateChannelStateRequest = Marshallers.Create<UpdateChannelStateRequest>(new Action<UpdateChannelStateRequest, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<UpdateChannelStateRequest>(context, UpdateChannelStateRequest.Parser));

		// Token: 0x04004952 RID: 18770
		private static readonly Marshaller<UpdateMemberStateRequest> __Marshaller_bgs_protocol_channel_v1_UpdateMemberStateRequest = Marshallers.Create<UpdateMemberStateRequest>(new Action<UpdateMemberStateRequest, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<UpdateMemberStateRequest>(context, UpdateMemberStateRequest.Parser));

		// Token: 0x04004953 RID: 18771
		private static readonly Marshaller<DissolveRequest> __Marshaller_bgs_protocol_channel_v1_DissolveRequest = Marshallers.Create<DissolveRequest>(new Action<DissolveRequest, SerializationContext>(ChannelService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelService.__Helper_DeserializeMessage<DissolveRequest>(context, DissolveRequest.Parser));

		// Token: 0x04004954 RID: 18772
		private static readonly Method<RemoveMemberRequest, NoData> __Method_RemoveMember = new Method<RemoveMemberRequest, NoData>(0, ChannelService.__ServiceName, "RemoveMember", ChannelService.__Marshaller_bgs_protocol_channel_v1_RemoveMemberRequest, ChannelService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04004955 RID: 18773
		private static readonly Method<SendMessageRequest, NoData> __Method_SendMessage = new Method<SendMessageRequest, NoData>(0, ChannelService.__ServiceName, "SendMessage", ChannelService.__Marshaller_bgs_protocol_channel_v1_SendMessageRequest, ChannelService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04004956 RID: 18774
		private static readonly Method<UpdateChannelStateRequest, NoData> __Method_UpdateChannelState = new Method<UpdateChannelStateRequest, NoData>(0, ChannelService.__ServiceName, "UpdateChannelState", ChannelService.__Marshaller_bgs_protocol_channel_v1_UpdateChannelStateRequest, ChannelService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04004957 RID: 18775
		private static readonly Method<UpdateMemberStateRequest, NoData> __Method_UpdateMemberState = new Method<UpdateMemberStateRequest, NoData>(0, ChannelService.__ServiceName, "UpdateMemberState", ChannelService.__Marshaller_bgs_protocol_channel_v1_UpdateMemberStateRequest, ChannelService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04004958 RID: 18776
		private static readonly Method<DissolveRequest, NoData> __Method_Dissolve = new Method<DissolveRequest, NoData>(0, ChannelService.__ServiceName, "Dissolve", ChannelService.__Marshaller_bgs_protocol_channel_v1_DissolveRequest, ChannelService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x020011EC RID: 4588
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x0400991A RID: 39194
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x020011ED RID: 4589
		[BindServiceMethod(typeof(ChannelService), "BindService")]
		public abstract class ChannelServiceBase
		{
			// Token: 0x0600D9B8 RID: 55736 RVA: 0x004BB0D8 File Offset: 0x004B92D8
			public virtual Task<NoData> RemoveMember(RemoveMemberRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D9B9 RID: 55737 RVA: 0x004BB0EC File Offset: 0x004B92EC
			public virtual Task<NoData> SendMessage(SendMessageRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D9BA RID: 55738 RVA: 0x004BB100 File Offset: 0x004B9300
			public virtual Task<NoData> UpdateChannelState(UpdateChannelStateRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D9BB RID: 55739 RVA: 0x004BB114 File Offset: 0x004B9314
			public virtual Task<NoData> UpdateMemberState(UpdateMemberStateRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D9BC RID: 55740 RVA: 0x004BB128 File Offset: 0x004B9328
			public virtual Task<NoData> Dissolve(DissolveRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x020011EE RID: 4590
		public class ChannelServiceClient : ClientBase<ChannelService.ChannelServiceClient>
		{
			// Token: 0x0600D9BE RID: 55742 RVA: 0x004BB145 File Offset: 0x004B9345
			public ChannelServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D9BF RID: 55743 RVA: 0x004BB150 File Offset: 0x004B9350
			public ChannelServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D9C0 RID: 55744 RVA: 0x004BB15B File Offset: 0x004B935B
			protected ChannelServiceClient()
			{
			}

			// Token: 0x0600D9C1 RID: 55745 RVA: 0x004BB165 File Offset: 0x004B9365
			protected ChannelServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D9C2 RID: 55746 RVA: 0x004BB170 File Offset: 0x004B9370
			public virtual NoData RemoveMember(RemoveMemberRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.RemoveMember(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D9C3 RID: 55747 RVA: 0x004BB198 File Offset: 0x004B9398
			public virtual NoData RemoveMember(RemoveMemberRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<RemoveMemberRequest, NoData>(ChannelService.__Method_RemoveMember, null, options, request);
			}

			// Token: 0x0600D9C4 RID: 55748 RVA: 0x004BB1C0 File Offset: 0x004B93C0
			public virtual AsyncUnaryCall<NoData> RemoveMemberAsync(RemoveMemberRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.RemoveMemberAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D9C5 RID: 55749 RVA: 0x004BB1E8 File Offset: 0x004B93E8
			public virtual AsyncUnaryCall<NoData> RemoveMemberAsync(RemoveMemberRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<RemoveMemberRequest, NoData>(ChannelService.__Method_RemoveMember, null, options, request);
			}

			// Token: 0x0600D9C6 RID: 55750 RVA: 0x004BB210 File Offset: 0x004B9410
			public virtual NoData SendMessage(SendMessageRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SendMessage(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D9C7 RID: 55751 RVA: 0x004BB238 File Offset: 0x004B9438
			public virtual NoData SendMessage(SendMessageRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SendMessageRequest, NoData>(ChannelService.__Method_SendMessage, null, options, request);
			}

			// Token: 0x0600D9C8 RID: 55752 RVA: 0x004BB260 File Offset: 0x004B9460
			public virtual AsyncUnaryCall<NoData> SendMessageAsync(SendMessageRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SendMessageAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D9C9 RID: 55753 RVA: 0x004BB288 File Offset: 0x004B9488
			public virtual AsyncUnaryCall<NoData> SendMessageAsync(SendMessageRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SendMessageRequest, NoData>(ChannelService.__Method_SendMessage, null, options, request);
			}

			// Token: 0x0600D9CA RID: 55754 RVA: 0x004BB2B0 File Offset: 0x004B94B0
			public virtual NoData UpdateChannelState(UpdateChannelStateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UpdateChannelState(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D9CB RID: 55755 RVA: 0x004BB2D8 File Offset: 0x004B94D8
			public virtual NoData UpdateChannelState(UpdateChannelStateRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<UpdateChannelStateRequest, NoData>(ChannelService.__Method_UpdateChannelState, null, options, request);
			}

			// Token: 0x0600D9CC RID: 55756 RVA: 0x004BB300 File Offset: 0x004B9500
			public virtual AsyncUnaryCall<NoData> UpdateChannelStateAsync(UpdateChannelStateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UpdateChannelStateAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D9CD RID: 55757 RVA: 0x004BB328 File Offset: 0x004B9528
			public virtual AsyncUnaryCall<NoData> UpdateChannelStateAsync(UpdateChannelStateRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<UpdateChannelStateRequest, NoData>(ChannelService.__Method_UpdateChannelState, null, options, request);
			}

			// Token: 0x0600D9CE RID: 55758 RVA: 0x004BB350 File Offset: 0x004B9550
			public virtual NoData UpdateMemberState(UpdateMemberStateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UpdateMemberState(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D9CF RID: 55759 RVA: 0x004BB378 File Offset: 0x004B9578
			public virtual NoData UpdateMemberState(UpdateMemberStateRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<UpdateMemberStateRequest, NoData>(ChannelService.__Method_UpdateMemberState, null, options, request);
			}

			// Token: 0x0600D9D0 RID: 55760 RVA: 0x004BB3A0 File Offset: 0x004B95A0
			public virtual AsyncUnaryCall<NoData> UpdateMemberStateAsync(UpdateMemberStateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UpdateMemberStateAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D9D1 RID: 55761 RVA: 0x004BB3C8 File Offset: 0x004B95C8
			public virtual AsyncUnaryCall<NoData> UpdateMemberStateAsync(UpdateMemberStateRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<UpdateMemberStateRequest, NoData>(ChannelService.__Method_UpdateMemberState, null, options, request);
			}

			// Token: 0x0600D9D2 RID: 55762 RVA: 0x004BB3F0 File Offset: 0x004B95F0
			public virtual NoData Dissolve(DissolveRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Dissolve(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D9D3 RID: 55763 RVA: 0x004BB418 File Offset: 0x004B9618
			public virtual NoData Dissolve(DissolveRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<DissolveRequest, NoData>(ChannelService.__Method_Dissolve, null, options, request);
			}

			// Token: 0x0600D9D4 RID: 55764 RVA: 0x004BB440 File Offset: 0x004B9640
			public virtual AsyncUnaryCall<NoData> DissolveAsync(DissolveRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.DissolveAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D9D5 RID: 55765 RVA: 0x004BB468 File Offset: 0x004B9668
			public virtual AsyncUnaryCall<NoData> DissolveAsync(DissolveRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<DissolveRequest, NoData>(ChannelService.__Method_Dissolve, null, options, request);
			}

			// Token: 0x0600D9D6 RID: 55766 RVA: 0x004BB490 File Offset: 0x004B9690
			protected override ChannelService.ChannelServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new ChannelService.ChannelServiceClient(configuration);
			}
		}
	}
}
