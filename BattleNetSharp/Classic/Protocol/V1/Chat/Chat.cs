using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Classic.Protocol.V1.Chat
{
	// Token: 0x0200077C RID: 1916
	public static class Chat
	{
		// Token: 0x0600B02F RID: 45103 RVA: 0x002AE114 File Offset: 0x002AC314
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

		// Token: 0x0600B030 RID: 45104 RVA: 0x002AE160 File Offset: 0x002AC360
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = Chat.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x1700367B RID: 13947
		// (get) Token: 0x0600B031 RID: 45105 RVA: 0x002AE198 File Offset: 0x002AC398
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return ChatReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x0600B032 RID: 45106 RVA: 0x002AE1BC File Offset: 0x002AC3BC
		public static ServerServiceDefinition BindService(Chat.ChatBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<ChatRequest, ChatResponse>(Chat.__Method_ChannelMessage, new UnaryServerMethod<ChatRequest, ChatResponse>(serviceImpl.ChannelMessage)).AddMethod<ChatRequest, ChatResponse>(Chat.__Method_WhisperMessage, new UnaryServerMethod<ChatRequest, ChatResponse>(serviceImpl.WhisperMessage))
				.Build();
		}

		// Token: 0x0600B033 RID: 45107 RVA: 0x002AE208 File Offset: 0x002AC408
		public static void BindService(ServiceBinderBase serviceBinder, Chat.ChatBase serviceImpl)
		{
			serviceBinder.AddMethod<ChatRequest, ChatResponse>(Chat.__Method_ChannelMessage, (serviceImpl == null) ? null : new UnaryServerMethod<ChatRequest, ChatResponse>(serviceImpl.ChannelMessage));
			serviceBinder.AddMethod<ChatRequest, ChatResponse>(Chat.__Method_WhisperMessage, (serviceImpl == null) ? null : new UnaryServerMethod<ChatRequest, ChatResponse>(serviceImpl.WhisperMessage));
		}

		// Token: 0x04004F72 RID: 20338
		private static readonly string __ServiceName = "classic.protocol.v1.chat.Chat";

		// Token: 0x04004F73 RID: 20339
		private static readonly Marshaller<ChatRequest> __Marshaller_classic_protocol_v1_chat_ChatRequest = Marshallers.Create<ChatRequest>(new Action<ChatRequest, SerializationContext>(Chat.__Helper_SerializeMessage), (DeserializationContext context) => Chat.__Helper_DeserializeMessage<ChatRequest>(context, ChatRequest.Parser));

		// Token: 0x04004F74 RID: 20340
		private static readonly Marshaller<ChatResponse> __Marshaller_classic_protocol_v1_chat_ChatResponse = Marshallers.Create<ChatResponse>(new Action<ChatResponse, SerializationContext>(Chat.__Helper_SerializeMessage), (DeserializationContext context) => Chat.__Helper_DeserializeMessage<ChatResponse>(context, ChatResponse.Parser));

		// Token: 0x04004F75 RID: 20341
		private static readonly Method<ChatRequest, ChatResponse> __Method_ChannelMessage = new Method<ChatRequest, ChatResponse>(0, Chat.__ServiceName, "ChannelMessage", Chat.__Marshaller_classic_protocol_v1_chat_ChatRequest, Chat.__Marshaller_classic_protocol_v1_chat_ChatResponse);

		// Token: 0x04004F76 RID: 20342
		private static readonly Method<ChatRequest, ChatResponse> __Method_WhisperMessage = new Method<ChatRequest, ChatResponse>(0, Chat.__ServiceName, "WhisperMessage", Chat.__Marshaller_classic_protocol_v1_chat_ChatRequest, Chat.__Marshaller_classic_protocol_v1_chat_ChatResponse);

		// Token: 0x0200129C RID: 4764
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x040099B2 RID: 39346
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x0200129D RID: 4765
		[BindServiceMethod(typeof(Chat), "BindService")]
		public abstract class ChatBase
		{
			// Token: 0x0600DD4B RID: 56651 RVA: 0x004BFB7D File Offset: 0x004BDD7D
			public virtual Task<ChatResponse> ChannelMessage(ChatRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600DD4C RID: 56652 RVA: 0x004BFB91 File Offset: 0x004BDD91
			public virtual Task<ChatResponse> WhisperMessage(ChatRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x0200129E RID: 4766
		public class ChatClient : ClientBase<Chat.ChatClient>
		{
			// Token: 0x0600DD4E RID: 56654 RVA: 0x004BFBAE File Offset: 0x004BDDAE
			public ChatClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600DD4F RID: 56655 RVA: 0x004BFBB9 File Offset: 0x004BDDB9
			public ChatClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600DD50 RID: 56656 RVA: 0x004BFBC4 File Offset: 0x004BDDC4
			protected ChatClient()
			{
			}

			// Token: 0x0600DD51 RID: 56657 RVA: 0x004BFBCE File Offset: 0x004BDDCE
			protected ChatClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600DD52 RID: 56658 RVA: 0x004BFBDC File Offset: 0x004BDDDC
			public virtual ChatResponse ChannelMessage(ChatRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ChannelMessage(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DD53 RID: 56659 RVA: 0x004BFC04 File Offset: 0x004BDE04
			public virtual ChatResponse ChannelMessage(ChatRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ChatRequest, ChatResponse>(Chat.__Method_ChannelMessage, null, options, request);
			}

			// Token: 0x0600DD54 RID: 56660 RVA: 0x004BFC2C File Offset: 0x004BDE2C
			public virtual AsyncUnaryCall<ChatResponse> ChannelMessageAsync(ChatRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ChannelMessageAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DD55 RID: 56661 RVA: 0x004BFC54 File Offset: 0x004BDE54
			public virtual AsyncUnaryCall<ChatResponse> ChannelMessageAsync(ChatRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ChatRequest, ChatResponse>(Chat.__Method_ChannelMessage, null, options, request);
			}

			// Token: 0x0600DD56 RID: 56662 RVA: 0x004BFC7C File Offset: 0x004BDE7C
			public virtual ChatResponse WhisperMessage(ChatRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.WhisperMessage(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DD57 RID: 56663 RVA: 0x004BFCA4 File Offset: 0x004BDEA4
			public virtual ChatResponse WhisperMessage(ChatRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ChatRequest, ChatResponse>(Chat.__Method_WhisperMessage, null, options, request);
			}

			// Token: 0x0600DD58 RID: 56664 RVA: 0x004BFCCC File Offset: 0x004BDECC
			public virtual AsyncUnaryCall<ChatResponse> WhisperMessageAsync(ChatRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.WhisperMessageAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DD59 RID: 56665 RVA: 0x004BFCF4 File Offset: 0x004BDEF4
			public virtual AsyncUnaryCall<ChatResponse> WhisperMessageAsync(ChatRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ChatRequest, ChatResponse>(Chat.__Method_WhisperMessage, null, options, request);
			}

			// Token: 0x0600DD5A RID: 56666 RVA: 0x004BFD1C File Offset: 0x004BDF1C
			protected override Chat.ChatClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new Chat.ChatClient(configuration);
			}
		}
	}
}
