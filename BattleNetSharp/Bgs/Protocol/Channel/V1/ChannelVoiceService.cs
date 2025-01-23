using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006F5 RID: 1781
	public static class ChannelVoiceService
	{
		// Token: 0x0600A426 RID: 42022 RVA: 0x0027FFFC File Offset: 0x0027E1FC
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

		// Token: 0x0600A427 RID: 42023 RVA: 0x00280048 File Offset: 0x0027E248
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = ChannelVoiceService.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x170032CB RID: 13003
		// (get) Token: 0x0600A428 RID: 42024 RVA: 0x00280080 File Offset: 0x0027E280
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return ChannelVoiceServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x0600A429 RID: 42025 RVA: 0x002800A4 File Offset: 0x0027E2A4
		public static ServerServiceDefinition BindService(ChannelVoiceService.ChannelVoiceServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<GetLoginTokenRequest, GetLoginTokenResponse>(ChannelVoiceService.__Method_GetLoginToken, new UnaryServerMethod<GetLoginTokenRequest, GetLoginTokenResponse>(serviceImpl.GetLoginToken)).AddMethod<GetJoinTokenRequest, GetJoinTokenResponse>(ChannelVoiceService.__Method_GetJoinToken, new UnaryServerMethod<GetJoinTokenRequest, GetJoinTokenResponse>(serviceImpl.GetJoinToken))
				.Build();
		}

		// Token: 0x0600A42A RID: 42026 RVA: 0x002800F0 File Offset: 0x0027E2F0
		public static void BindService(ServiceBinderBase serviceBinder, ChannelVoiceService.ChannelVoiceServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<GetLoginTokenRequest, GetLoginTokenResponse>(ChannelVoiceService.__Method_GetLoginToken, (serviceImpl == null) ? null : new UnaryServerMethod<GetLoginTokenRequest, GetLoginTokenResponse>(serviceImpl.GetLoginToken));
			serviceBinder.AddMethod<GetJoinTokenRequest, GetJoinTokenResponse>(ChannelVoiceService.__Method_GetJoinToken, (serviceImpl == null) ? null : new UnaryServerMethod<GetJoinTokenRequest, GetJoinTokenResponse>(serviceImpl.GetJoinToken));
		}

		// Token: 0x040049F4 RID: 18932
		private static readonly string __ServiceName = "bgs.protocol.channel.v1.ChannelVoiceService";

		// Token: 0x040049F5 RID: 18933
		private static readonly Marshaller<GetLoginTokenRequest> __Marshaller_bgs_protocol_channel_v1_GetLoginTokenRequest = Marshallers.Create<GetLoginTokenRequest>(new Action<GetLoginTokenRequest, SerializationContext>(ChannelVoiceService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelVoiceService.__Helper_DeserializeMessage<GetLoginTokenRequest>(context, GetLoginTokenRequest.Parser));

		// Token: 0x040049F6 RID: 18934
		private static readonly Marshaller<GetLoginTokenResponse> __Marshaller_bgs_protocol_channel_v1_GetLoginTokenResponse = Marshallers.Create<GetLoginTokenResponse>(new Action<GetLoginTokenResponse, SerializationContext>(ChannelVoiceService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelVoiceService.__Helper_DeserializeMessage<GetLoginTokenResponse>(context, GetLoginTokenResponse.Parser));

		// Token: 0x040049F7 RID: 18935
		private static readonly Marshaller<GetJoinTokenRequest> __Marshaller_bgs_protocol_channel_v1_GetJoinTokenRequest = Marshallers.Create<GetJoinTokenRequest>(new Action<GetJoinTokenRequest, SerializationContext>(ChannelVoiceService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelVoiceService.__Helper_DeserializeMessage<GetJoinTokenRequest>(context, GetJoinTokenRequest.Parser));

		// Token: 0x040049F8 RID: 18936
		private static readonly Marshaller<GetJoinTokenResponse> __Marshaller_bgs_protocol_channel_v1_GetJoinTokenResponse = Marshallers.Create<GetJoinTokenResponse>(new Action<GetJoinTokenResponse, SerializationContext>(ChannelVoiceService.__Helper_SerializeMessage), (DeserializationContext context) => ChannelVoiceService.__Helper_DeserializeMessage<GetJoinTokenResponse>(context, GetJoinTokenResponse.Parser));

		// Token: 0x040049F9 RID: 18937
		private static readonly Method<GetLoginTokenRequest, GetLoginTokenResponse> __Method_GetLoginToken = new Method<GetLoginTokenRequest, GetLoginTokenResponse>(0, ChannelVoiceService.__ServiceName, "GetLoginToken", ChannelVoiceService.__Marshaller_bgs_protocol_channel_v1_GetLoginTokenRequest, ChannelVoiceService.__Marshaller_bgs_protocol_channel_v1_GetLoginTokenResponse);

		// Token: 0x040049FA RID: 18938
		private static readonly Method<GetJoinTokenRequest, GetJoinTokenResponse> __Method_GetJoinToken = new Method<GetJoinTokenRequest, GetJoinTokenResponse>(0, ChannelVoiceService.__ServiceName, "GetJoinToken", ChannelVoiceService.__Marshaller_bgs_protocol_channel_v1_GetJoinTokenRequest, ChannelVoiceService.__Marshaller_bgs_protocol_channel_v1_GetJoinTokenResponse);

		// Token: 0x02001202 RID: 4610
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x0400992B RID: 39211
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02001203 RID: 4611
		[BindServiceMethod(typeof(ChannelVoiceService), "BindService")]
		public abstract class ChannelVoiceServiceBase
		{
			// Token: 0x0600DA3B RID: 55867 RVA: 0x004BBC76 File Offset: 0x004B9E76
			public virtual Task<GetLoginTokenResponse> GetLoginToken(GetLoginTokenRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600DA3C RID: 55868 RVA: 0x004BBC8A File Offset: 0x004B9E8A
			public virtual Task<GetJoinTokenResponse> GetJoinToken(GetJoinTokenRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x02001204 RID: 4612
		public class ChannelVoiceServiceClient : ClientBase<ChannelVoiceService.ChannelVoiceServiceClient>
		{
			// Token: 0x0600DA3E RID: 55870 RVA: 0x004BBCA7 File Offset: 0x004B9EA7
			public ChannelVoiceServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600DA3F RID: 55871 RVA: 0x004BBCB2 File Offset: 0x004B9EB2
			public ChannelVoiceServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600DA40 RID: 55872 RVA: 0x004BBCBD File Offset: 0x004B9EBD
			protected ChannelVoiceServiceClient()
			{
			}

			// Token: 0x0600DA41 RID: 55873 RVA: 0x004BBCC7 File Offset: 0x004B9EC7
			protected ChannelVoiceServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600DA42 RID: 55874 RVA: 0x004BBCD4 File Offset: 0x004B9ED4
			public virtual GetLoginTokenResponse GetLoginToken(GetLoginTokenRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetLoginToken(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DA43 RID: 55875 RVA: 0x004BBCFC File Offset: 0x004B9EFC
			public virtual GetLoginTokenResponse GetLoginToken(GetLoginTokenRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetLoginTokenRequest, GetLoginTokenResponse>(ChannelVoiceService.__Method_GetLoginToken, null, options, request);
			}

			// Token: 0x0600DA44 RID: 55876 RVA: 0x004BBD24 File Offset: 0x004B9F24
			public virtual AsyncUnaryCall<GetLoginTokenResponse> GetLoginTokenAsync(GetLoginTokenRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetLoginTokenAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DA45 RID: 55877 RVA: 0x004BBD4C File Offset: 0x004B9F4C
			public virtual AsyncUnaryCall<GetLoginTokenResponse> GetLoginTokenAsync(GetLoginTokenRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetLoginTokenRequest, GetLoginTokenResponse>(ChannelVoiceService.__Method_GetLoginToken, null, options, request);
			}

			// Token: 0x0600DA46 RID: 55878 RVA: 0x004BBD74 File Offset: 0x004B9F74
			public virtual GetJoinTokenResponse GetJoinToken(GetJoinTokenRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetJoinToken(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DA47 RID: 55879 RVA: 0x004BBD9C File Offset: 0x004B9F9C
			public virtual GetJoinTokenResponse GetJoinToken(GetJoinTokenRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetJoinTokenRequest, GetJoinTokenResponse>(ChannelVoiceService.__Method_GetJoinToken, null, options, request);
			}

			// Token: 0x0600DA48 RID: 55880 RVA: 0x004BBDC4 File Offset: 0x004B9FC4
			public virtual AsyncUnaryCall<GetJoinTokenResponse> GetJoinTokenAsync(GetJoinTokenRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetJoinTokenAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DA49 RID: 55881 RVA: 0x004BBDEC File Offset: 0x004B9FEC
			public virtual AsyncUnaryCall<GetJoinTokenResponse> GetJoinTokenAsync(GetJoinTokenRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetJoinTokenRequest, GetJoinTokenResponse>(ChannelVoiceService.__Method_GetJoinToken, null, options, request);
			}

			// Token: 0x0600DA4A RID: 55882 RVA: 0x004BBE14 File Offset: 0x004BA014
			protected override ChannelVoiceService.ChannelVoiceServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new ChannelVoiceService.ChannelVoiceServiceClient(configuration);
			}
		}
	}
}
