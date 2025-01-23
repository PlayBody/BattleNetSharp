using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Voice.V2.Client
{
	// Token: 0x0200052D RID: 1325
	public static class VoiceService
	{
		// Token: 0x06008065 RID: 32869 RVA: 0x001F3B34 File Offset: 0x001F1D34
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

		// Token: 0x06008066 RID: 32870 RVA: 0x001F3B80 File Offset: 0x001F1D80
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = VoiceService.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x170028A1 RID: 10401
		// (get) Token: 0x06008067 RID: 32871 RVA: 0x001F3BB8 File Offset: 0x001F1DB8
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return VoiceServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x06008068 RID: 32872 RVA: 0x001F3BDC File Offset: 0x001F1DDC
		public static ServerServiceDefinition BindService(VoiceService.VoiceServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<CreateLoginCredentialsRequest, CreateLoginCredentialsResponse>(VoiceService.__Method_CreateLoginCredentials, new UnaryServerMethod<CreateLoginCredentialsRequest, CreateLoginCredentialsResponse>(serviceImpl.CreateLoginCredentials)).AddMethod<CreateChannelSttTokenRequest, CreateChannelSttTokenResponse>(VoiceService.__Method_CreateChannelSttToken, new UnaryServerMethod<CreateChannelSttTokenRequest, CreateChannelSttTokenResponse>(serviceImpl.CreateChannelSttToken))
				.Build();
		}

		// Token: 0x06008069 RID: 32873 RVA: 0x001F3C28 File Offset: 0x001F1E28
		public static void BindService(ServiceBinderBase serviceBinder, VoiceService.VoiceServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<CreateLoginCredentialsRequest, CreateLoginCredentialsResponse>(VoiceService.__Method_CreateLoginCredentials, (serviceImpl == null) ? null : new UnaryServerMethod<CreateLoginCredentialsRequest, CreateLoginCredentialsResponse>(serviceImpl.CreateLoginCredentials));
			serviceBinder.AddMethod<CreateChannelSttTokenRequest, CreateChannelSttTokenResponse>(VoiceService.__Method_CreateChannelSttToken, (serviceImpl == null) ? null : new UnaryServerMethod<CreateChannelSttTokenRequest, CreateChannelSttTokenResponse>(serviceImpl.CreateChannelSttToken));
		}

		// Token: 0x04003A43 RID: 14915
		private static readonly string __ServiceName = "bgs.protocol.voice.v2.client.VoiceService";

		// Token: 0x04003A44 RID: 14916
		private static readonly Marshaller<CreateLoginCredentialsRequest> __Marshaller_bgs_protocol_voice_v2_client_CreateLoginCredentialsRequest = Marshallers.Create<CreateLoginCredentialsRequest>(new Action<CreateLoginCredentialsRequest, SerializationContext>(VoiceService.__Helper_SerializeMessage), (DeserializationContext context) => VoiceService.__Helper_DeserializeMessage<CreateLoginCredentialsRequest>(context, CreateLoginCredentialsRequest.Parser));

		// Token: 0x04003A45 RID: 14917
		private static readonly Marshaller<CreateLoginCredentialsResponse> __Marshaller_bgs_protocol_voice_v2_client_CreateLoginCredentialsResponse = Marshallers.Create<CreateLoginCredentialsResponse>(new Action<CreateLoginCredentialsResponse, SerializationContext>(VoiceService.__Helper_SerializeMessage), (DeserializationContext context) => VoiceService.__Helper_DeserializeMessage<CreateLoginCredentialsResponse>(context, CreateLoginCredentialsResponse.Parser));

		// Token: 0x04003A46 RID: 14918
		private static readonly Marshaller<CreateChannelSttTokenRequest> __Marshaller_bgs_protocol_voice_v2_client_CreateChannelSttTokenRequest = Marshallers.Create<CreateChannelSttTokenRequest>(new Action<CreateChannelSttTokenRequest, SerializationContext>(VoiceService.__Helper_SerializeMessage), (DeserializationContext context) => VoiceService.__Helper_DeserializeMessage<CreateChannelSttTokenRequest>(context, CreateChannelSttTokenRequest.Parser));

		// Token: 0x04003A47 RID: 14919
		private static readonly Marshaller<CreateChannelSttTokenResponse> __Marshaller_bgs_protocol_voice_v2_client_CreateChannelSttTokenResponse = Marshallers.Create<CreateChannelSttTokenResponse>(new Action<CreateChannelSttTokenResponse, SerializationContext>(VoiceService.__Helper_SerializeMessage), (DeserializationContext context) => VoiceService.__Helper_DeserializeMessage<CreateChannelSttTokenResponse>(context, CreateChannelSttTokenResponse.Parser));

		// Token: 0x04003A48 RID: 14920
		private static readonly Method<CreateLoginCredentialsRequest, CreateLoginCredentialsResponse> __Method_CreateLoginCredentials = new Method<CreateLoginCredentialsRequest, CreateLoginCredentialsResponse>(0, VoiceService.__ServiceName, "CreateLoginCredentials", VoiceService.__Marshaller_bgs_protocol_voice_v2_client_CreateLoginCredentialsRequest, VoiceService.__Marshaller_bgs_protocol_voice_v2_client_CreateLoginCredentialsResponse);

		// Token: 0x04003A49 RID: 14921
		private static readonly Method<CreateChannelSttTokenRequest, CreateChannelSttTokenResponse> __Method_CreateChannelSttToken = new Method<CreateChannelSttTokenRequest, CreateChannelSttTokenResponse>(0, VoiceService.__ServiceName, "CreateChannelSttToken", VoiceService.__Marshaller_bgs_protocol_voice_v2_client_CreateChannelSttTokenRequest, VoiceService.__Marshaller_bgs_protocol_voice_v2_client_CreateChannelSttTokenResponse);

		// Token: 0x02000FF9 RID: 4089
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x0400974A RID: 38730
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02000FFA RID: 4090
		[BindServiceMethod(typeof(VoiceService), "BindService")]
		public abstract class VoiceServiceBase
		{
			// Token: 0x0600D033 RID: 53299 RVA: 0x004AF5A9 File Offset: 0x004AD7A9
			public virtual Task<CreateLoginCredentialsResponse> CreateLoginCredentials(CreateLoginCredentialsRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D034 RID: 53300 RVA: 0x004AF5BD File Offset: 0x004AD7BD
			public virtual Task<CreateChannelSttTokenResponse> CreateChannelSttToken(CreateChannelSttTokenRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x02000FFB RID: 4091
		public class VoiceServiceClient : ClientBase<VoiceService.VoiceServiceClient>
		{
			// Token: 0x0600D036 RID: 53302 RVA: 0x004AF5DA File Offset: 0x004AD7DA
			public VoiceServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D037 RID: 53303 RVA: 0x004AF5E5 File Offset: 0x004AD7E5
			public VoiceServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D038 RID: 53304 RVA: 0x004AF5F0 File Offset: 0x004AD7F0
			protected VoiceServiceClient()
			{
			}

			// Token: 0x0600D039 RID: 53305 RVA: 0x004AF5FA File Offset: 0x004AD7FA
			protected VoiceServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D03A RID: 53306 RVA: 0x004AF608 File Offset: 0x004AD808
			public virtual CreateLoginCredentialsResponse CreateLoginCredentials(CreateLoginCredentialsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.CreateLoginCredentials(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D03B RID: 53307 RVA: 0x004AF630 File Offset: 0x004AD830
			public virtual CreateLoginCredentialsResponse CreateLoginCredentials(CreateLoginCredentialsRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<CreateLoginCredentialsRequest, CreateLoginCredentialsResponse>(VoiceService.__Method_CreateLoginCredentials, null, options, request);
			}

			// Token: 0x0600D03C RID: 53308 RVA: 0x004AF658 File Offset: 0x004AD858
			public virtual AsyncUnaryCall<CreateLoginCredentialsResponse> CreateLoginCredentialsAsync(CreateLoginCredentialsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.CreateLoginCredentialsAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D03D RID: 53309 RVA: 0x004AF680 File Offset: 0x004AD880
			public virtual AsyncUnaryCall<CreateLoginCredentialsResponse> CreateLoginCredentialsAsync(CreateLoginCredentialsRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<CreateLoginCredentialsRequest, CreateLoginCredentialsResponse>(VoiceService.__Method_CreateLoginCredentials, null, options, request);
			}

			// Token: 0x0600D03E RID: 53310 RVA: 0x004AF6A8 File Offset: 0x004AD8A8
			public virtual CreateChannelSttTokenResponse CreateChannelSttToken(CreateChannelSttTokenRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.CreateChannelSttToken(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D03F RID: 53311 RVA: 0x004AF6D0 File Offset: 0x004AD8D0
			public virtual CreateChannelSttTokenResponse CreateChannelSttToken(CreateChannelSttTokenRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<CreateChannelSttTokenRequest, CreateChannelSttTokenResponse>(VoiceService.__Method_CreateChannelSttToken, null, options, request);
			}

			// Token: 0x0600D040 RID: 53312 RVA: 0x004AF6F8 File Offset: 0x004AD8F8
			public virtual AsyncUnaryCall<CreateChannelSttTokenResponse> CreateChannelSttTokenAsync(CreateChannelSttTokenRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.CreateChannelSttTokenAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D041 RID: 53313 RVA: 0x004AF720 File Offset: 0x004AD920
			public virtual AsyncUnaryCall<CreateChannelSttTokenResponse> CreateChannelSttTokenAsync(CreateChannelSttTokenRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<CreateChannelSttTokenRequest, CreateChannelSttTokenResponse>(VoiceService.__Method_CreateChannelSttToken, null, options, request);
			}

			// Token: 0x0600D042 RID: 53314 RVA: 0x004AF748 File Offset: 0x004AD948
			protected override VoiceService.VoiceServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new VoiceService.VoiceServiceClient(configuration);
			}
		}
	}
}
