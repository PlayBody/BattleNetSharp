using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Whisper.V1
{
	// Token: 0x020003AD RID: 941
	public static class WhisperService
	{
		// Token: 0x06005EDB RID: 24283 RVA: 0x0016F268 File Offset: 0x0016D468
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

		// Token: 0x06005EDC RID: 24284 RVA: 0x0016F2B4 File Offset: 0x0016D4B4
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = WhisperService.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17001EAF RID: 7855
		// (get) Token: 0x06005EDD RID: 24285 RVA: 0x0016F2EC File Offset: 0x0016D4EC
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return WhisperServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x06005EDE RID: 24286 RVA: 0x0016F310 File Offset: 0x0016D510
		public static ServerServiceDefinition BindService(WhisperService.WhisperServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<SubscribeRequest, SubscribeResponse>(WhisperService.__Method_Subscribe, new UnaryServerMethod<SubscribeRequest, SubscribeResponse>(serviceImpl.Subscribe)).AddMethod<UnsubscribeRequest, NoData>(WhisperService.__Method_Unsubscribe, new UnaryServerMethod<UnsubscribeRequest, NoData>(serviceImpl.Unsubscribe))
				.AddMethod<SendWhisperRequest, SendWhisperResponse>(WhisperService.__Method_SendWhisper, new UnaryServerMethod<SendWhisperRequest, SendWhisperResponse>(serviceImpl.SendWhisper))
				.AddMethod<SetTypingIndicatorRequest, NoData>(WhisperService.__Method_SetTypingIndicator, new UnaryServerMethod<SetTypingIndicatorRequest, NoData>(serviceImpl.SetTypingIndicator))
				.AddMethod<AdvanceViewTimeRequest, NoData>(WhisperService.__Method_AdvanceViewTime, new UnaryServerMethod<AdvanceViewTimeRequest, NoData>(serviceImpl.AdvanceViewTime))
				.AddMethod<GetWhisperMessagesRequest, GetWhisperMessagesResponse>(WhisperService.__Method_GetWhisperMessages, new UnaryServerMethod<GetWhisperMessagesRequest, GetWhisperMessagesResponse>(serviceImpl.GetWhisperMessages))
				.AddMethod<AdvanceClearTimeRequest, NoData>(WhisperService.__Method_AdvanceClearTime, new UnaryServerMethod<AdvanceClearTimeRequest, NoData>(serviceImpl.AdvanceClearTime))
				.Build();
		}

		// Token: 0x06005EDF RID: 24287 RVA: 0x0016F3D0 File Offset: 0x0016D5D0
		public static void BindService(ServiceBinderBase serviceBinder, WhisperService.WhisperServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<SubscribeRequest, SubscribeResponse>(WhisperService.__Method_Subscribe, (serviceImpl == null) ? null : new UnaryServerMethod<SubscribeRequest, SubscribeResponse>(serviceImpl.Subscribe));
			serviceBinder.AddMethod<UnsubscribeRequest, NoData>(WhisperService.__Method_Unsubscribe, (serviceImpl == null) ? null : new UnaryServerMethod<UnsubscribeRequest, NoData>(serviceImpl.Unsubscribe));
			serviceBinder.AddMethod<SendWhisperRequest, SendWhisperResponse>(WhisperService.__Method_SendWhisper, (serviceImpl == null) ? null : new UnaryServerMethod<SendWhisperRequest, SendWhisperResponse>(serviceImpl.SendWhisper));
			serviceBinder.AddMethod<SetTypingIndicatorRequest, NoData>(WhisperService.__Method_SetTypingIndicator, (serviceImpl == null) ? null : new UnaryServerMethod<SetTypingIndicatorRequest, NoData>(serviceImpl.SetTypingIndicator));
			serviceBinder.AddMethod<AdvanceViewTimeRequest, NoData>(WhisperService.__Method_AdvanceViewTime, (serviceImpl == null) ? null : new UnaryServerMethod<AdvanceViewTimeRequest, NoData>(serviceImpl.AdvanceViewTime));
			serviceBinder.AddMethod<GetWhisperMessagesRequest, GetWhisperMessagesResponse>(WhisperService.__Method_GetWhisperMessages, (serviceImpl == null) ? null : new UnaryServerMethod<GetWhisperMessagesRequest, GetWhisperMessagesResponse>(serviceImpl.GetWhisperMessages));
			serviceBinder.AddMethod<AdvanceClearTimeRequest, NoData>(WhisperService.__Method_AdvanceClearTime, (serviceImpl == null) ? null : new UnaryServerMethod<AdvanceClearTimeRequest, NoData>(serviceImpl.AdvanceClearTime));
		}

		// Token: 0x04002B52 RID: 11090
		private static readonly string __ServiceName = "bgs.protocol.whisper.v1.WhisperService";

		// Token: 0x04002B53 RID: 11091
		private static readonly Marshaller<SubscribeRequest> __Marshaller_bgs_protocol_whisper_v1_SubscribeRequest = Marshallers.Create<SubscribeRequest>(new Action<SubscribeRequest, SerializationContext>(WhisperService.__Helper_SerializeMessage), (DeserializationContext context) => WhisperService.__Helper_DeserializeMessage<SubscribeRequest>(context, SubscribeRequest.Parser));

		// Token: 0x04002B54 RID: 11092
		private static readonly Marshaller<SubscribeResponse> __Marshaller_bgs_protocol_whisper_v1_SubscribeResponse = Marshallers.Create<SubscribeResponse>(new Action<SubscribeResponse, SerializationContext>(WhisperService.__Helper_SerializeMessage), (DeserializationContext context) => WhisperService.__Helper_DeserializeMessage<SubscribeResponse>(context, SubscribeResponse.Parser));

		// Token: 0x04002B55 RID: 11093
		private static readonly Marshaller<UnsubscribeRequest> __Marshaller_bgs_protocol_whisper_v1_UnsubscribeRequest = Marshallers.Create<UnsubscribeRequest>(new Action<UnsubscribeRequest, SerializationContext>(WhisperService.__Helper_SerializeMessage), (DeserializationContext context) => WhisperService.__Helper_DeserializeMessage<UnsubscribeRequest>(context, UnsubscribeRequest.Parser));

		// Token: 0x04002B56 RID: 11094
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(WhisperService.__Helper_SerializeMessage), (DeserializationContext context) => WhisperService.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x04002B57 RID: 11095
		private static readonly Marshaller<SendWhisperRequest> __Marshaller_bgs_protocol_whisper_v1_SendWhisperRequest = Marshallers.Create<SendWhisperRequest>(new Action<SendWhisperRequest, SerializationContext>(WhisperService.__Helper_SerializeMessage), (DeserializationContext context) => WhisperService.__Helper_DeserializeMessage<SendWhisperRequest>(context, SendWhisperRequest.Parser));

		// Token: 0x04002B58 RID: 11096
		private static readonly Marshaller<SendWhisperResponse> __Marshaller_bgs_protocol_whisper_v1_SendWhisperResponse = Marshallers.Create<SendWhisperResponse>(new Action<SendWhisperResponse, SerializationContext>(WhisperService.__Helper_SerializeMessage), (DeserializationContext context) => WhisperService.__Helper_DeserializeMessage<SendWhisperResponse>(context, SendWhisperResponse.Parser));

		// Token: 0x04002B59 RID: 11097
		private static readonly Marshaller<SetTypingIndicatorRequest> __Marshaller_bgs_protocol_whisper_v1_SetTypingIndicatorRequest = Marshallers.Create<SetTypingIndicatorRequest>(new Action<SetTypingIndicatorRequest, SerializationContext>(WhisperService.__Helper_SerializeMessage), (DeserializationContext context) => WhisperService.__Helper_DeserializeMessage<SetTypingIndicatorRequest>(context, SetTypingIndicatorRequest.Parser));

		// Token: 0x04002B5A RID: 11098
		private static readonly Marshaller<AdvanceViewTimeRequest> __Marshaller_bgs_protocol_whisper_v1_AdvanceViewTimeRequest = Marshallers.Create<AdvanceViewTimeRequest>(new Action<AdvanceViewTimeRequest, SerializationContext>(WhisperService.__Helper_SerializeMessage), (DeserializationContext context) => WhisperService.__Helper_DeserializeMessage<AdvanceViewTimeRequest>(context, AdvanceViewTimeRequest.Parser));

		// Token: 0x04002B5B RID: 11099
		private static readonly Marshaller<GetWhisperMessagesRequest> __Marshaller_bgs_protocol_whisper_v1_GetWhisperMessagesRequest = Marshallers.Create<GetWhisperMessagesRequest>(new Action<GetWhisperMessagesRequest, SerializationContext>(WhisperService.__Helper_SerializeMessage), (DeserializationContext context) => WhisperService.__Helper_DeserializeMessage<GetWhisperMessagesRequest>(context, GetWhisperMessagesRequest.Parser));

		// Token: 0x04002B5C RID: 11100
		private static readonly Marshaller<GetWhisperMessagesResponse> __Marshaller_bgs_protocol_whisper_v1_GetWhisperMessagesResponse = Marshallers.Create<GetWhisperMessagesResponse>(new Action<GetWhisperMessagesResponse, SerializationContext>(WhisperService.__Helper_SerializeMessage), (DeserializationContext context) => WhisperService.__Helper_DeserializeMessage<GetWhisperMessagesResponse>(context, GetWhisperMessagesResponse.Parser));

		// Token: 0x04002B5D RID: 11101
		private static readonly Marshaller<AdvanceClearTimeRequest> __Marshaller_bgs_protocol_whisper_v1_AdvanceClearTimeRequest = Marshallers.Create<AdvanceClearTimeRequest>(new Action<AdvanceClearTimeRequest, SerializationContext>(WhisperService.__Helper_SerializeMessage), (DeserializationContext context) => WhisperService.__Helper_DeserializeMessage<AdvanceClearTimeRequest>(context, AdvanceClearTimeRequest.Parser));

		// Token: 0x04002B5E RID: 11102
		private static readonly Method<SubscribeRequest, SubscribeResponse> __Method_Subscribe = new Method<SubscribeRequest, SubscribeResponse>(0, WhisperService.__ServiceName, "Subscribe", WhisperService.__Marshaller_bgs_protocol_whisper_v1_SubscribeRequest, WhisperService.__Marshaller_bgs_protocol_whisper_v1_SubscribeResponse);

		// Token: 0x04002B5F RID: 11103
		private static readonly Method<UnsubscribeRequest, NoData> __Method_Unsubscribe = new Method<UnsubscribeRequest, NoData>(0, WhisperService.__ServiceName, "Unsubscribe", WhisperService.__Marshaller_bgs_protocol_whisper_v1_UnsubscribeRequest, WhisperService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04002B60 RID: 11104
		private static readonly Method<SendWhisperRequest, SendWhisperResponse> __Method_SendWhisper = new Method<SendWhisperRequest, SendWhisperResponse>(0, WhisperService.__ServiceName, "SendWhisper", WhisperService.__Marshaller_bgs_protocol_whisper_v1_SendWhisperRequest, WhisperService.__Marshaller_bgs_protocol_whisper_v1_SendWhisperResponse);

		// Token: 0x04002B61 RID: 11105
		private static readonly Method<SetTypingIndicatorRequest, NoData> __Method_SetTypingIndicator = new Method<SetTypingIndicatorRequest, NoData>(0, WhisperService.__ServiceName, "SetTypingIndicator", WhisperService.__Marshaller_bgs_protocol_whisper_v1_SetTypingIndicatorRequest, WhisperService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04002B62 RID: 11106
		private static readonly Method<AdvanceViewTimeRequest, NoData> __Method_AdvanceViewTime = new Method<AdvanceViewTimeRequest, NoData>(0, WhisperService.__ServiceName, "AdvanceViewTime", WhisperService.__Marshaller_bgs_protocol_whisper_v1_AdvanceViewTimeRequest, WhisperService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04002B63 RID: 11107
		private static readonly Method<GetWhisperMessagesRequest, GetWhisperMessagesResponse> __Method_GetWhisperMessages = new Method<GetWhisperMessagesRequest, GetWhisperMessagesResponse>(0, WhisperService.__ServiceName, "GetWhisperMessages", WhisperService.__Marshaller_bgs_protocol_whisper_v1_GetWhisperMessagesRequest, WhisperService.__Marshaller_bgs_protocol_whisper_v1_GetWhisperMessagesResponse);

		// Token: 0x04002B64 RID: 11108
		private static readonly Method<AdvanceClearTimeRequest, NoData> __Method_AdvanceClearTime = new Method<AdvanceClearTimeRequest, NoData>(0, WhisperService.__ServiceName, "AdvanceClearTime", WhisperService.__Marshaller_bgs_protocol_whisper_v1_AdvanceClearTimeRequest, WhisperService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x02000E78 RID: 3704
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x040095E8 RID: 38376
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02000E79 RID: 3705
		[BindServiceMethod(typeof(WhisperService), "BindService")]
		public abstract class WhisperServiceBase
		{
			// Token: 0x0600C9CC RID: 51660 RVA: 0x004A89FD File Offset: 0x004A6BFD
			public virtual Task<SubscribeResponse> Subscribe(SubscribeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600C9CD RID: 51661 RVA: 0x004A8A11 File Offset: 0x004A6C11
			public virtual Task<NoData> Unsubscribe(UnsubscribeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600C9CE RID: 51662 RVA: 0x004A8A25 File Offset: 0x004A6C25
			public virtual Task<SendWhisperResponse> SendWhisper(SendWhisperRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600C9CF RID: 51663 RVA: 0x004A8A39 File Offset: 0x004A6C39
			public virtual Task<NoData> SetTypingIndicator(SetTypingIndicatorRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600C9D0 RID: 51664 RVA: 0x004A8A4D File Offset: 0x004A6C4D
			public virtual Task<NoData> AdvanceViewTime(AdvanceViewTimeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600C9D1 RID: 51665 RVA: 0x004A8A61 File Offset: 0x004A6C61
			public virtual Task<GetWhisperMessagesResponse> GetWhisperMessages(GetWhisperMessagesRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600C9D2 RID: 51666 RVA: 0x004A8A75 File Offset: 0x004A6C75
			public virtual Task<NoData> AdvanceClearTime(AdvanceClearTimeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x02000E7A RID: 3706
		public class WhisperServiceClient : ClientBase<WhisperService.WhisperServiceClient>
		{
			// Token: 0x0600C9D4 RID: 51668 RVA: 0x004A8A92 File Offset: 0x004A6C92
			public WhisperServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600C9D5 RID: 51669 RVA: 0x004A8A9D File Offset: 0x004A6C9D
			public WhisperServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600C9D6 RID: 51670 RVA: 0x004A8AA8 File Offset: 0x004A6CA8
			protected WhisperServiceClient()
			{
			}

			// Token: 0x0600C9D7 RID: 51671 RVA: 0x004A8AB2 File Offset: 0x004A6CB2
			protected WhisperServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600C9D8 RID: 51672 RVA: 0x004A8AC0 File Offset: 0x004A6CC0
			public virtual SubscribeResponse Subscribe(SubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Subscribe(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600C9D9 RID: 51673 RVA: 0x004A8AE8 File Offset: 0x004A6CE8
			public virtual SubscribeResponse Subscribe(SubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SubscribeRequest, SubscribeResponse>(WhisperService.__Method_Subscribe, null, options, request);
			}

			// Token: 0x0600C9DA RID: 51674 RVA: 0x004A8B10 File Offset: 0x004A6D10
			public virtual AsyncUnaryCall<SubscribeResponse> SubscribeAsync(SubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SubscribeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600C9DB RID: 51675 RVA: 0x004A8B38 File Offset: 0x004A6D38
			public virtual AsyncUnaryCall<SubscribeResponse> SubscribeAsync(SubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SubscribeRequest, SubscribeResponse>(WhisperService.__Method_Subscribe, null, options, request);
			}

			// Token: 0x0600C9DC RID: 51676 RVA: 0x004A8B60 File Offset: 0x004A6D60
			public virtual NoData Unsubscribe(UnsubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Unsubscribe(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600C9DD RID: 51677 RVA: 0x004A8B88 File Offset: 0x004A6D88
			public virtual NoData Unsubscribe(UnsubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<UnsubscribeRequest, NoData>(WhisperService.__Method_Unsubscribe, null, options, request);
			}

			// Token: 0x0600C9DE RID: 51678 RVA: 0x004A8BB0 File Offset: 0x004A6DB0
			public virtual AsyncUnaryCall<NoData> UnsubscribeAsync(UnsubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UnsubscribeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600C9DF RID: 51679 RVA: 0x004A8BD8 File Offset: 0x004A6DD8
			public virtual AsyncUnaryCall<NoData> UnsubscribeAsync(UnsubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<UnsubscribeRequest, NoData>(WhisperService.__Method_Unsubscribe, null, options, request);
			}

			// Token: 0x0600C9E0 RID: 51680 RVA: 0x004A8C00 File Offset: 0x004A6E00
			public virtual SendWhisperResponse SendWhisper(SendWhisperRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SendWhisper(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600C9E1 RID: 51681 RVA: 0x004A8C28 File Offset: 0x004A6E28
			public virtual SendWhisperResponse SendWhisper(SendWhisperRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SendWhisperRequest, SendWhisperResponse>(WhisperService.__Method_SendWhisper, null, options, request);
			}

			// Token: 0x0600C9E2 RID: 51682 RVA: 0x004A8C50 File Offset: 0x004A6E50
			public virtual AsyncUnaryCall<SendWhisperResponse> SendWhisperAsync(SendWhisperRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SendWhisperAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600C9E3 RID: 51683 RVA: 0x004A8C78 File Offset: 0x004A6E78
			public virtual AsyncUnaryCall<SendWhisperResponse> SendWhisperAsync(SendWhisperRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SendWhisperRequest, SendWhisperResponse>(WhisperService.__Method_SendWhisper, null, options, request);
			}

			// Token: 0x0600C9E4 RID: 51684 RVA: 0x004A8CA0 File Offset: 0x004A6EA0
			public virtual NoData SetTypingIndicator(SetTypingIndicatorRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SetTypingIndicator(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600C9E5 RID: 51685 RVA: 0x004A8CC8 File Offset: 0x004A6EC8
			public virtual NoData SetTypingIndicator(SetTypingIndicatorRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SetTypingIndicatorRequest, NoData>(WhisperService.__Method_SetTypingIndicator, null, options, request);
			}

			// Token: 0x0600C9E6 RID: 51686 RVA: 0x004A8CF0 File Offset: 0x004A6EF0
			public virtual AsyncUnaryCall<NoData> SetTypingIndicatorAsync(SetTypingIndicatorRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SetTypingIndicatorAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600C9E7 RID: 51687 RVA: 0x004A8D18 File Offset: 0x004A6F18
			public virtual AsyncUnaryCall<NoData> SetTypingIndicatorAsync(SetTypingIndicatorRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SetTypingIndicatorRequest, NoData>(WhisperService.__Method_SetTypingIndicator, null, options, request);
			}

			// Token: 0x0600C9E8 RID: 51688 RVA: 0x004A8D40 File Offset: 0x004A6F40
			public virtual NoData AdvanceViewTime(AdvanceViewTimeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.AdvanceViewTime(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600C9E9 RID: 51689 RVA: 0x004A8D68 File Offset: 0x004A6F68
			public virtual NoData AdvanceViewTime(AdvanceViewTimeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<AdvanceViewTimeRequest, NoData>(WhisperService.__Method_AdvanceViewTime, null, options, request);
			}

			// Token: 0x0600C9EA RID: 51690 RVA: 0x004A8D90 File Offset: 0x004A6F90
			public virtual AsyncUnaryCall<NoData> AdvanceViewTimeAsync(AdvanceViewTimeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.AdvanceViewTimeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600C9EB RID: 51691 RVA: 0x004A8DB8 File Offset: 0x004A6FB8
			public virtual AsyncUnaryCall<NoData> AdvanceViewTimeAsync(AdvanceViewTimeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<AdvanceViewTimeRequest, NoData>(WhisperService.__Method_AdvanceViewTime, null, options, request);
			}

			// Token: 0x0600C9EC RID: 51692 RVA: 0x004A8DE0 File Offset: 0x004A6FE0
			public virtual GetWhisperMessagesResponse GetWhisperMessages(GetWhisperMessagesRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetWhisperMessages(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600C9ED RID: 51693 RVA: 0x004A8E08 File Offset: 0x004A7008
			public virtual GetWhisperMessagesResponse GetWhisperMessages(GetWhisperMessagesRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetWhisperMessagesRequest, GetWhisperMessagesResponse>(WhisperService.__Method_GetWhisperMessages, null, options, request);
			}

			// Token: 0x0600C9EE RID: 51694 RVA: 0x004A8E30 File Offset: 0x004A7030
			public virtual AsyncUnaryCall<GetWhisperMessagesResponse> GetWhisperMessagesAsync(GetWhisperMessagesRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetWhisperMessagesAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600C9EF RID: 51695 RVA: 0x004A8E58 File Offset: 0x004A7058
			public virtual AsyncUnaryCall<GetWhisperMessagesResponse> GetWhisperMessagesAsync(GetWhisperMessagesRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetWhisperMessagesRequest, GetWhisperMessagesResponse>(WhisperService.__Method_GetWhisperMessages, null, options, request);
			}

			// Token: 0x0600C9F0 RID: 51696 RVA: 0x004A8E80 File Offset: 0x004A7080
			public virtual NoData AdvanceClearTime(AdvanceClearTimeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.AdvanceClearTime(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600C9F1 RID: 51697 RVA: 0x004A8EA8 File Offset: 0x004A70A8
			public virtual NoData AdvanceClearTime(AdvanceClearTimeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<AdvanceClearTimeRequest, NoData>(WhisperService.__Method_AdvanceClearTime, null, options, request);
			}

			// Token: 0x0600C9F2 RID: 51698 RVA: 0x004A8ED0 File Offset: 0x004A70D0
			public virtual AsyncUnaryCall<NoData> AdvanceClearTimeAsync(AdvanceClearTimeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.AdvanceClearTimeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600C9F3 RID: 51699 RVA: 0x004A8EF8 File Offset: 0x004A70F8
			public virtual AsyncUnaryCall<NoData> AdvanceClearTimeAsync(AdvanceClearTimeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<AdvanceClearTimeRequest, NoData>(WhisperService.__Method_AdvanceClearTime, null, options, request);
			}

			// Token: 0x0600C9F4 RID: 51700 RVA: 0x004A8F20 File Offset: 0x004A7120
			protected override WhisperService.WhisperServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new WhisperService.WhisperServiceClient(configuration);
			}
		}
	}
}
