using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006C4 RID: 1732
	public static class ChannelInvitationService
	{
		// Token: 0x0600A010 RID: 40976 RVA: 0x0026E9A4 File Offset: 0x0026CBA4
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

		// Token: 0x0600A011 RID: 40977 RVA: 0x0026E9F0 File Offset: 0x0026CBF0
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = ChannelInvitationService.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x170031A1 RID: 12705
		// (get) Token: 0x0600A012 RID: 40978 RVA: 0x0026EA28 File Offset: 0x0026CC28
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return ChannelInvitationServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x0600A013 RID: 40979 RVA: 0x0026EA4C File Offset: 0x0026CC4C
		public static ServerServiceDefinition BindService(ChannelInvitationService.ChannelInvitationServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<SubscribeRequest, NoData>(ChannelInvitationService.__Method_Subscribe, new UnaryServerMethod<SubscribeRequest, NoData>(serviceImpl.Subscribe)).AddMethod<SendInvitationRequest, NoData>(ChannelInvitationService.__Method_SendInvitation, new UnaryServerMethod<SendInvitationRequest, NoData>(serviceImpl.SendInvitation))
				.AddMethod<AcceptInvitationRequest, AcceptInvitationResponse>(ChannelInvitationService.__Method_AcceptInvitation, new UnaryServerMethod<AcceptInvitationRequest, AcceptInvitationResponse>(serviceImpl.AcceptInvitation))
				.AddMethod<DeclineInvitationRequest, NoData>(ChannelInvitationService.__Method_DeclineInvitation, new UnaryServerMethod<DeclineInvitationRequest, NoData>(serviceImpl.DeclineInvitation))
				.AddMethod<RevokeInvitationRequest, NoData>(ChannelInvitationService.__Method_RevokeInvitation, new UnaryServerMethod<RevokeInvitationRequest, NoData>(serviceImpl.RevokeInvitation))
				.AddMethod<SuggestInvitationRequest, NoData>(ChannelInvitationService.__Method_SuggestInvitation, new UnaryServerMethod<SuggestInvitationRequest, NoData>(serviceImpl.SuggestInvitation))
				.AddMethod<ListChannelCountRequest, ListChannelCountResponse>(ChannelInvitationService.__Method_ListChannelCount, new UnaryServerMethod<ListChannelCountRequest, ListChannelCountResponse>(serviceImpl.ListChannelCount))
				.Build();
		}

		// Token: 0x0600A014 RID: 40980 RVA: 0x0026EB0C File Offset: 0x0026CD0C
		public static void BindService(ServiceBinderBase serviceBinder, ChannelInvitationService.ChannelInvitationServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<SubscribeRequest, NoData>(ChannelInvitationService.__Method_Subscribe, (serviceImpl == null) ? null : new UnaryServerMethod<SubscribeRequest, NoData>(serviceImpl.Subscribe));
			serviceBinder.AddMethod<SendInvitationRequest, NoData>(ChannelInvitationService.__Method_SendInvitation, (serviceImpl == null) ? null : new UnaryServerMethod<SendInvitationRequest, NoData>(serviceImpl.SendInvitation));
			serviceBinder.AddMethod<AcceptInvitationRequest, AcceptInvitationResponse>(ChannelInvitationService.__Method_AcceptInvitation, (serviceImpl == null) ? null : new UnaryServerMethod<AcceptInvitationRequest, AcceptInvitationResponse>(serviceImpl.AcceptInvitation));
			serviceBinder.AddMethod<DeclineInvitationRequest, NoData>(ChannelInvitationService.__Method_DeclineInvitation, (serviceImpl == null) ? null : new UnaryServerMethod<DeclineInvitationRequest, NoData>(serviceImpl.DeclineInvitation));
			serviceBinder.AddMethod<RevokeInvitationRequest, NoData>(ChannelInvitationService.__Method_RevokeInvitation, (serviceImpl == null) ? null : new UnaryServerMethod<RevokeInvitationRequest, NoData>(serviceImpl.RevokeInvitation));
			serviceBinder.AddMethod<SuggestInvitationRequest, NoData>(ChannelInvitationService.__Method_SuggestInvitation, (serviceImpl == null) ? null : new UnaryServerMethod<SuggestInvitationRequest, NoData>(serviceImpl.SuggestInvitation));
			serviceBinder.AddMethod<ListChannelCountRequest, ListChannelCountResponse>(ChannelInvitationService.__Method_ListChannelCount, (serviceImpl == null) ? null : new UnaryServerMethod<ListChannelCountRequest, ListChannelCountResponse>(serviceImpl.ListChannelCount));
		}

		// Token: 0x04004815 RID: 18453
		private static readonly string __ServiceName = "bgs.protocol.channel.v1.ChannelInvitationService";

		// Token: 0x04004816 RID: 18454
		private static readonly Marshaller<SubscribeRequest> __Marshaller_bgs_protocol_channel_v1_SubscribeRequest = Marshallers.Create<SubscribeRequest>(new Action<SubscribeRequest, SerializationContext>(ChannelInvitationService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelInvitationService.__Helper_DeserializeMessage<SubscribeRequest>(context, SubscribeRequest.Parser));

		// Token: 0x04004817 RID: 18455
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(ChannelInvitationService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelInvitationService.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x04004818 RID: 18456
		private static readonly Marshaller<SendInvitationRequest> __Marshaller_bgs_protocol_channel_v1_SendInvitationRequest = Marshallers.Create<SendInvitationRequest>(new Action<SendInvitationRequest, SerializationContext>(ChannelInvitationService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelInvitationService.__Helper_DeserializeMessage<SendInvitationRequest>(context, SendInvitationRequest.Parser));

		// Token: 0x04004819 RID: 18457
		private static readonly Marshaller<AcceptInvitationRequest> __Marshaller_bgs_protocol_channel_v1_AcceptInvitationRequest = Marshallers.Create<AcceptInvitationRequest>(new Action<AcceptInvitationRequest, SerializationContext>(ChannelInvitationService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelInvitationService.__Helper_DeserializeMessage<AcceptInvitationRequest>(context, AcceptInvitationRequest.Parser));

		// Token: 0x0400481A RID: 18458
		private static readonly Marshaller<AcceptInvitationResponse> __Marshaller_bgs_protocol_channel_v1_AcceptInvitationResponse = Marshallers.Create<AcceptInvitationResponse>(new Action<AcceptInvitationResponse, SerializationContext>(ChannelInvitationService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelInvitationService.__Helper_DeserializeMessage<AcceptInvitationResponse>(context, AcceptInvitationResponse.Parser));

		// Token: 0x0400481B RID: 18459
		private static readonly Marshaller<DeclineInvitationRequest> __Marshaller_bgs_protocol_channel_v1_DeclineInvitationRequest = Marshallers.Create<DeclineInvitationRequest>(new Action<DeclineInvitationRequest, SerializationContext>(ChannelInvitationService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelInvitationService.__Helper_DeserializeMessage<DeclineInvitationRequest>(context, DeclineInvitationRequest.Parser));

		// Token: 0x0400481C RID: 18460
		private static readonly Marshaller<RevokeInvitationRequest> __Marshaller_bgs_protocol_channel_v1_RevokeInvitationRequest = Marshallers.Create<RevokeInvitationRequest>(new Action<RevokeInvitationRequest, SerializationContext>(ChannelInvitationService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelInvitationService.__Helper_DeserializeMessage<RevokeInvitationRequest>(context, RevokeInvitationRequest.Parser));

		// Token: 0x0400481D RID: 18461
		private static readonly Marshaller<SuggestInvitationRequest> __Marshaller_bgs_protocol_channel_v1_SuggestInvitationRequest = Marshallers.Create<SuggestInvitationRequest>(new Action<SuggestInvitationRequest, SerializationContext>(ChannelInvitationService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelInvitationService.__Helper_DeserializeMessage<SuggestInvitationRequest>(context, SuggestInvitationRequest.Parser));

		// Token: 0x0400481E RID: 18462
		private static readonly Marshaller<ListChannelCountRequest> __Marshaller_bgs_protocol_channel_v1_ListChannelCountRequest = Marshallers.Create<ListChannelCountRequest>(new Action<ListChannelCountRequest, SerializationContext>(ChannelInvitationService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelInvitationService.__Helper_DeserializeMessage<ListChannelCountRequest>(context, ListChannelCountRequest.Parser));

		// Token: 0x0400481F RID: 18463
		private static readonly Marshaller<ListChannelCountResponse> __Marshaller_bgs_protocol_channel_v1_ListChannelCountResponse = Marshallers.Create<ListChannelCountResponse>(new Action<ListChannelCountResponse, SerializationContext>(ChannelInvitationService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelInvitationService.__Helper_DeserializeMessage<ListChannelCountResponse>(context, ListChannelCountResponse.Parser));

		// Token: 0x04004820 RID: 18464
		private static readonly Method<SubscribeRequest, NoData> __Method_Subscribe = new Method<SubscribeRequest, NoData>(0, ChannelInvitationService.__ServiceName, "Subscribe", ChannelInvitationService.__Marshaller_bgs_protocol_channel_v1_SubscribeRequest, ChannelInvitationService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04004821 RID: 18465
		private static readonly Method<SendInvitationRequest, NoData> __Method_SendInvitation = new Method<SendInvitationRequest, NoData>(0, ChannelInvitationService.__ServiceName, "SendInvitation", ChannelInvitationService.__Marshaller_bgs_protocol_channel_v1_SendInvitationRequest, ChannelInvitationService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04004822 RID: 18466
		private static readonly Method<AcceptInvitationRequest, AcceptInvitationResponse> __Method_AcceptInvitation = new Method<AcceptInvitationRequest, AcceptInvitationResponse>(0, ChannelInvitationService.__ServiceName, "AcceptInvitation", ChannelInvitationService.__Marshaller_bgs_protocol_channel_v1_AcceptInvitationRequest, ChannelInvitationService.__Marshaller_bgs_protocol_channel_v1_AcceptInvitationResponse);

		// Token: 0x04004823 RID: 18467
		private static readonly Method<DeclineInvitationRequest, NoData> __Method_DeclineInvitation = new Method<DeclineInvitationRequest, NoData>(0, ChannelInvitationService.__ServiceName, "DeclineInvitation", ChannelInvitationService.__Marshaller_bgs_protocol_channel_v1_DeclineInvitationRequest, ChannelInvitationService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04004824 RID: 18468
		private static readonly Method<RevokeInvitationRequest, NoData> __Method_RevokeInvitation = new Method<RevokeInvitationRequest, NoData>(0, ChannelInvitationService.__ServiceName, "RevokeInvitation", ChannelInvitationService.__Marshaller_bgs_protocol_channel_v1_RevokeInvitationRequest, ChannelInvitationService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04004825 RID: 18469
		private static readonly Method<SuggestInvitationRequest, NoData> __Method_SuggestInvitation = new Method<SuggestInvitationRequest, NoData>(0, ChannelInvitationService.__ServiceName, "SuggestInvitation", ChannelInvitationService.__Marshaller_bgs_protocol_channel_v1_SuggestInvitationRequest, ChannelInvitationService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04004826 RID: 18470
		private static readonly Method<ListChannelCountRequest, ListChannelCountResponse> __Method_ListChannelCount = new Method<ListChannelCountRequest, ListChannelCountResponse>(0, ChannelInvitationService.__ServiceName, "ListChannelCount", ChannelInvitationService.__Marshaller_bgs_protocol_channel_v1_ListChannelCountRequest, ChannelInvitationService.__Marshaller_bgs_protocol_channel_v1_ListChannelCountResponse);

		// Token: 0x020011C4 RID: 4548
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x040098F8 RID: 39160
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x020011C5 RID: 4549
		[BindServiceMethod(typeof(ChannelInvitationService), "BindService")]
		public abstract class ChannelInvitationServiceBase
		{
			// Token: 0x0600D8EA RID: 55530 RVA: 0x004BA06F File Offset: 0x004B826F
			public virtual Task<NoData> Subscribe(SubscribeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D8EB RID: 55531 RVA: 0x004BA083 File Offset: 0x004B8283
			public virtual Task<NoData> SendInvitation(SendInvitationRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D8EC RID: 55532 RVA: 0x004BA097 File Offset: 0x004B8297
			public virtual Task<AcceptInvitationResponse> AcceptInvitation(AcceptInvitationRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D8ED RID: 55533 RVA: 0x004BA0AB File Offset: 0x004B82AB
			public virtual Task<NoData> DeclineInvitation(DeclineInvitationRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D8EE RID: 55534 RVA: 0x004BA0BF File Offset: 0x004B82BF
			public virtual Task<NoData> RevokeInvitation(RevokeInvitationRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D8EF RID: 55535 RVA: 0x004BA0D3 File Offset: 0x004B82D3
			public virtual Task<NoData> SuggestInvitation(SuggestInvitationRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D8F0 RID: 55536 RVA: 0x004BA0E7 File Offset: 0x004B82E7
			public virtual Task<ListChannelCountResponse> ListChannelCount(ListChannelCountRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x020011C6 RID: 4550
		public class ChannelInvitationServiceClient : ClientBase<ChannelInvitationService.ChannelInvitationServiceClient>
		{
			// Token: 0x0600D8F2 RID: 55538 RVA: 0x004BA104 File Offset: 0x004B8304
			public ChannelInvitationServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D8F3 RID: 55539 RVA: 0x004BA10F File Offset: 0x004B830F
			public ChannelInvitationServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D8F4 RID: 55540 RVA: 0x004BA11A File Offset: 0x004B831A
			protected ChannelInvitationServiceClient()
			{
			}

			// Token: 0x0600D8F5 RID: 55541 RVA: 0x004BA124 File Offset: 0x004B8324
			protected ChannelInvitationServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D8F6 RID: 55542 RVA: 0x004BA130 File Offset: 0x004B8330
			public virtual NoData Subscribe(SubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Subscribe(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D8F7 RID: 55543 RVA: 0x004BA158 File Offset: 0x004B8358
			public virtual NoData Subscribe(SubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SubscribeRequest, NoData>(ChannelInvitationService.__Method_Subscribe, null, options, request);
			}

			// Token: 0x0600D8F8 RID: 55544 RVA: 0x004BA180 File Offset: 0x004B8380
			public virtual AsyncUnaryCall<NoData> SubscribeAsync(SubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SubscribeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D8F9 RID: 55545 RVA: 0x004BA1A8 File Offset: 0x004B83A8
			public virtual AsyncUnaryCall<NoData> SubscribeAsync(SubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SubscribeRequest, NoData>(ChannelInvitationService.__Method_Subscribe, null, options, request);
			}

			// Token: 0x0600D8FA RID: 55546 RVA: 0x004BA1D0 File Offset: 0x004B83D0
			public virtual NoData SendInvitation(SendInvitationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SendInvitation(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D8FB RID: 55547 RVA: 0x004BA1F8 File Offset: 0x004B83F8
			public virtual NoData SendInvitation(SendInvitationRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SendInvitationRequest, NoData>(ChannelInvitationService.__Method_SendInvitation, null, options, request);
			}

			// Token: 0x0600D8FC RID: 55548 RVA: 0x004BA220 File Offset: 0x004B8420
			public virtual AsyncUnaryCall<NoData> SendInvitationAsync(SendInvitationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SendInvitationAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D8FD RID: 55549 RVA: 0x004BA248 File Offset: 0x004B8448
			public virtual AsyncUnaryCall<NoData> SendInvitationAsync(SendInvitationRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SendInvitationRequest, NoData>(ChannelInvitationService.__Method_SendInvitation, null, options, request);
			}

			// Token: 0x0600D8FE RID: 55550 RVA: 0x004BA270 File Offset: 0x004B8470
			public virtual AcceptInvitationResponse AcceptInvitation(AcceptInvitationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.AcceptInvitation(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D8FF RID: 55551 RVA: 0x004BA298 File Offset: 0x004B8498
			public virtual AcceptInvitationResponse AcceptInvitation(AcceptInvitationRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<AcceptInvitationRequest, AcceptInvitationResponse>(ChannelInvitationService.__Method_AcceptInvitation, null, options, request);
			}

			// Token: 0x0600D900 RID: 55552 RVA: 0x004BA2C0 File Offset: 0x004B84C0
			public virtual AsyncUnaryCall<AcceptInvitationResponse> AcceptInvitationAsync(AcceptInvitationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.AcceptInvitationAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D901 RID: 55553 RVA: 0x004BA2E8 File Offset: 0x004B84E8
			public virtual AsyncUnaryCall<AcceptInvitationResponse> AcceptInvitationAsync(AcceptInvitationRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<AcceptInvitationRequest, AcceptInvitationResponse>(ChannelInvitationService.__Method_AcceptInvitation, null, options, request);
			}

			// Token: 0x0600D902 RID: 55554 RVA: 0x004BA310 File Offset: 0x004B8510
			public virtual NoData DeclineInvitation(DeclineInvitationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.DeclineInvitation(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D903 RID: 55555 RVA: 0x004BA338 File Offset: 0x004B8538
			public virtual NoData DeclineInvitation(DeclineInvitationRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<DeclineInvitationRequest, NoData>(ChannelInvitationService.__Method_DeclineInvitation, null, options, request);
			}

			// Token: 0x0600D904 RID: 55556 RVA: 0x004BA360 File Offset: 0x004B8560
			public virtual AsyncUnaryCall<NoData> DeclineInvitationAsync(DeclineInvitationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.DeclineInvitationAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D905 RID: 55557 RVA: 0x004BA388 File Offset: 0x004B8588
			public virtual AsyncUnaryCall<NoData> DeclineInvitationAsync(DeclineInvitationRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<DeclineInvitationRequest, NoData>(ChannelInvitationService.__Method_DeclineInvitation, null, options, request);
			}

			// Token: 0x0600D906 RID: 55558 RVA: 0x004BA3B0 File Offset: 0x004B85B0
			public virtual NoData RevokeInvitation(RevokeInvitationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.RevokeInvitation(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D907 RID: 55559 RVA: 0x004BA3D8 File Offset: 0x004B85D8
			public virtual NoData RevokeInvitation(RevokeInvitationRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<RevokeInvitationRequest, NoData>(ChannelInvitationService.__Method_RevokeInvitation, null, options, request);
			}

			// Token: 0x0600D908 RID: 55560 RVA: 0x004BA400 File Offset: 0x004B8600
			public virtual AsyncUnaryCall<NoData> RevokeInvitationAsync(RevokeInvitationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.RevokeInvitationAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D909 RID: 55561 RVA: 0x004BA428 File Offset: 0x004B8628
			public virtual AsyncUnaryCall<NoData> RevokeInvitationAsync(RevokeInvitationRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<RevokeInvitationRequest, NoData>(ChannelInvitationService.__Method_RevokeInvitation, null, options, request);
			}

			// Token: 0x0600D90A RID: 55562 RVA: 0x004BA450 File Offset: 0x004B8650
			public virtual NoData SuggestInvitation(SuggestInvitationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SuggestInvitation(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D90B RID: 55563 RVA: 0x004BA478 File Offset: 0x004B8678
			public virtual NoData SuggestInvitation(SuggestInvitationRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SuggestInvitationRequest, NoData>(ChannelInvitationService.__Method_SuggestInvitation, null, options, request);
			}

			// Token: 0x0600D90C RID: 55564 RVA: 0x004BA4A0 File Offset: 0x004B86A0
			public virtual AsyncUnaryCall<NoData> SuggestInvitationAsync(SuggestInvitationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SuggestInvitationAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D90D RID: 55565 RVA: 0x004BA4C8 File Offset: 0x004B86C8
			public virtual AsyncUnaryCall<NoData> SuggestInvitationAsync(SuggestInvitationRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SuggestInvitationRequest, NoData>(ChannelInvitationService.__Method_SuggestInvitation, null, options, request);
			}

			// Token: 0x0600D90E RID: 55566 RVA: 0x004BA4F0 File Offset: 0x004B86F0
			public virtual ListChannelCountResponse ListChannelCount(ListChannelCountRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ListChannelCount(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D90F RID: 55567 RVA: 0x004BA518 File Offset: 0x004B8718
			public virtual ListChannelCountResponse ListChannelCount(ListChannelCountRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ListChannelCountRequest, ListChannelCountResponse>(ChannelInvitationService.__Method_ListChannelCount, null, options, request);
			}

			// Token: 0x0600D910 RID: 55568 RVA: 0x004BA540 File Offset: 0x004B8740
			public virtual AsyncUnaryCall<ListChannelCountResponse> ListChannelCountAsync(ListChannelCountRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ListChannelCountAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D911 RID: 55569 RVA: 0x004BA568 File Offset: 0x004B8768
			public virtual AsyncUnaryCall<ListChannelCountResponse> ListChannelCountAsync(ListChannelCountRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ListChannelCountRequest, ListChannelCountResponse>(ChannelInvitationService.__Method_ListChannelCount, null, options, request);
			}

			// Token: 0x0600D912 RID: 55570 RVA: 0x004BA590 File Offset: 0x004B8790
			protected override ChannelInvitationService.ChannelInvitationServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new ChannelInvitationService.ChannelInvitationServiceClient(configuration);
			}
		}
	}
}
