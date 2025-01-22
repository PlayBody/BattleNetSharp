using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Sns.V1
{
	// Token: 0x020003D2 RID: 978
	public static class SocialNetworkService
	{
		// Token: 0x060061D5 RID: 25045 RVA: 0x0017A58C File Offset: 0x0017878C
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

		// Token: 0x060061D6 RID: 25046 RVA: 0x0017A5D8 File Offset: 0x001787D8
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = SocialNetworkService.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17001F86 RID: 8070
		// (get) Token: 0x060061D7 RID: 25047 RVA: 0x0017A610 File Offset: 0x00178810
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return SocialNetworkServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x060061D8 RID: 25048 RVA: 0x0017A634 File Offset: 0x00178834
		public static ServerServiceDefinition BindService(SocialNetworkService.SocialNetworkServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<GetFacebookAuthCodeRequest, GetFacebookAuthCodeResponse>(SocialNetworkService.__Method_GetFacebookAuthCode, new UnaryServerMethod<GetFacebookAuthCodeRequest, GetFacebookAuthCodeResponse>(serviceImpl.GetFacebookAuthCode)).AddMethod<GetFacebookBnetFriendsRequest, NoData>(SocialNetworkService.__Method_GetFacebookBnetFriends, new UnaryServerMethod<GetFacebookBnetFriendsRequest, NoData>(serviceImpl.GetFacebookBnetFriends))
				.AddMethod<NoData, GetFacebookSettingsResponse>(SocialNetworkService.__Method_GetFacebookSettings, new UnaryServerMethod<NoData, GetFacebookSettingsResponse>(serviceImpl.GetFacebookSettings))
				.AddMethod<GetFacebookAccountLinkStatusRequest, GetFacebookAccountLinkStatusResponse>(SocialNetworkService.__Method_GetFacebookAccountLinkStatus, new UnaryServerMethod<GetFacebookAccountLinkStatusRequest, GetFacebookAccountLinkStatusResponse>(serviceImpl.GetFacebookAccountLinkStatus))
				.AddMethod<GetGoogleAuthTokenRequest, GetGoogleAuthTokenResponse>(SocialNetworkService.__Method_GetGoogleAuthToken, new UnaryServerMethod<GetGoogleAuthTokenRequest, GetGoogleAuthTokenResponse>(serviceImpl.GetGoogleAuthToken))
				.AddMethod<NoData, GetGoogleSettingsResponse>(SocialNetworkService.__Method_GetGoogleSettings, new UnaryServerMethod<NoData, GetGoogleSettingsResponse>(serviceImpl.GetGoogleSettings))
				.AddMethod<GetGoogleAccountLinkStatusRequest, GetGoogleAccountLinkStatusResponse>(SocialNetworkService.__Method_GetGoogleAccountLinkStatus, new UnaryServerMethod<GetGoogleAccountLinkStatusRequest, GetGoogleAccountLinkStatusResponse>(serviceImpl.GetGoogleAccountLinkStatus))
				.Build();
		}

		// Token: 0x060061D9 RID: 25049 RVA: 0x0017A6F4 File Offset: 0x001788F4
		public static void BindService(ServiceBinderBase serviceBinder, SocialNetworkService.SocialNetworkServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<GetFacebookAuthCodeRequest, GetFacebookAuthCodeResponse>(SocialNetworkService.__Method_GetFacebookAuthCode, (serviceImpl == null) ? null : new UnaryServerMethod<GetFacebookAuthCodeRequest, GetFacebookAuthCodeResponse>(serviceImpl.GetFacebookAuthCode));
			serviceBinder.AddMethod<GetFacebookBnetFriendsRequest, NoData>(SocialNetworkService.__Method_GetFacebookBnetFriends, (serviceImpl == null) ? null : new UnaryServerMethod<GetFacebookBnetFriendsRequest, NoData>(serviceImpl.GetFacebookBnetFriends));
			serviceBinder.AddMethod<NoData, GetFacebookSettingsResponse>(SocialNetworkService.__Method_GetFacebookSettings, (serviceImpl == null) ? null : new UnaryServerMethod<NoData, GetFacebookSettingsResponse>(serviceImpl.GetFacebookSettings));
			serviceBinder.AddMethod<GetFacebookAccountLinkStatusRequest, GetFacebookAccountLinkStatusResponse>(SocialNetworkService.__Method_GetFacebookAccountLinkStatus, (serviceImpl == null) ? null : new UnaryServerMethod<GetFacebookAccountLinkStatusRequest, GetFacebookAccountLinkStatusResponse>(serviceImpl.GetFacebookAccountLinkStatus));
			serviceBinder.AddMethod<GetGoogleAuthTokenRequest, GetGoogleAuthTokenResponse>(SocialNetworkService.__Method_GetGoogleAuthToken, (serviceImpl == null) ? null : new UnaryServerMethod<GetGoogleAuthTokenRequest, GetGoogleAuthTokenResponse>(serviceImpl.GetGoogleAuthToken));
			serviceBinder.AddMethod<NoData, GetGoogleSettingsResponse>(SocialNetworkService.__Method_GetGoogleSettings, (serviceImpl == null) ? null : new UnaryServerMethod<NoData, GetGoogleSettingsResponse>(serviceImpl.GetGoogleSettings));
			serviceBinder.AddMethod<GetGoogleAccountLinkStatusRequest, GetGoogleAccountLinkStatusResponse>(SocialNetworkService.__Method_GetGoogleAccountLinkStatus, (serviceImpl == null) ? null : new UnaryServerMethod<GetGoogleAccountLinkStatusRequest, GetGoogleAccountLinkStatusResponse>(serviceImpl.GetGoogleAccountLinkStatus));
		}

		// Token: 0x04002C98 RID: 11416
		private static readonly string __ServiceName = "bgs.protocol.sns.v1.SocialNetworkService";

		// Token: 0x04002C99 RID: 11417
		private static readonly Marshaller<GetFacebookAuthCodeRequest> __Marshaller_bgs_protocol_sns_v1_GetFacebookAuthCodeRequest = Marshallers.Create<GetFacebookAuthCodeRequest>(new Action<GetFacebookAuthCodeRequest, SerializationContext>(SocialNetworkService.__Helper_SerializeMessage), (DeserializationContext context) => SocialNetworkService.__Helper_DeserializeMessage<GetFacebookAuthCodeRequest>(context, GetFacebookAuthCodeRequest.Parser));

		// Token: 0x04002C9A RID: 11418
		private static readonly Marshaller<GetFacebookAuthCodeResponse> __Marshaller_bgs_protocol_sns_v1_GetFacebookAuthCodeResponse = Marshallers.Create<GetFacebookAuthCodeResponse>(new Action<GetFacebookAuthCodeResponse, SerializationContext>(SocialNetworkService.__Helper_SerializeMessage), (DeserializationContext context) => SocialNetworkService.__Helper_DeserializeMessage<GetFacebookAuthCodeResponse>(context, GetFacebookAuthCodeResponse.Parser));

		// Token: 0x04002C9B RID: 11419
		private static readonly Marshaller<GetFacebookBnetFriendsRequest> __Marshaller_bgs_protocol_sns_v1_GetFacebookBnetFriendsRequest = Marshallers.Create<GetFacebookBnetFriendsRequest>(new Action<GetFacebookBnetFriendsRequest, SerializationContext>(SocialNetworkService.__Helper_SerializeMessage), (DeserializationContext context) => SocialNetworkService.__Helper_DeserializeMessage<GetFacebookBnetFriendsRequest>(context, GetFacebookBnetFriendsRequest.Parser));

		// Token: 0x04002C9C RID: 11420
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(SocialNetworkService.__Helper_SerializeMessage), (DeserializationContext context) => SocialNetworkService.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x04002C9D RID: 11421
		private static readonly Marshaller<GetFacebookSettingsResponse> __Marshaller_bgs_protocol_sns_v1_GetFacebookSettingsResponse = Marshallers.Create<GetFacebookSettingsResponse>(new Action<GetFacebookSettingsResponse, SerializationContext>(SocialNetworkService.__Helper_SerializeMessage), (DeserializationContext context) => SocialNetworkService.__Helper_DeserializeMessage<GetFacebookSettingsResponse>(context, GetFacebookSettingsResponse.Parser));

		// Token: 0x04002C9E RID: 11422
		private static readonly Marshaller<GetFacebookAccountLinkStatusRequest> __Marshaller_bgs_protocol_sns_v1_GetFacebookAccountLinkStatusRequest = Marshallers.Create<GetFacebookAccountLinkStatusRequest>(new Action<GetFacebookAccountLinkStatusRequest, SerializationContext>(SocialNetworkService.__Helper_SerializeMessage), (DeserializationContext context) => SocialNetworkService.__Helper_DeserializeMessage<GetFacebookAccountLinkStatusRequest>(context, GetFacebookAccountLinkStatusRequest.Parser));

		// Token: 0x04002C9F RID: 11423
		private static readonly Marshaller<GetFacebookAccountLinkStatusResponse> __Marshaller_bgs_protocol_sns_v1_GetFacebookAccountLinkStatusResponse = Marshallers.Create<GetFacebookAccountLinkStatusResponse>(new Action<GetFacebookAccountLinkStatusResponse, SerializationContext>(SocialNetworkService.__Helper_SerializeMessage), (DeserializationContext context) => SocialNetworkService.__Helper_DeserializeMessage<GetFacebookAccountLinkStatusResponse>(context, GetFacebookAccountLinkStatusResponse.Parser));

		// Token: 0x04002CA0 RID: 11424
		private static readonly Marshaller<GetGoogleAuthTokenRequest> __Marshaller_bgs_protocol_sns_v1_GetGoogleAuthTokenRequest = Marshallers.Create<GetGoogleAuthTokenRequest>(new Action<GetGoogleAuthTokenRequest, SerializationContext>(SocialNetworkService.__Helper_SerializeMessage), (DeserializationContext context) => SocialNetworkService.__Helper_DeserializeMessage<GetGoogleAuthTokenRequest>(context, GetGoogleAuthTokenRequest.Parser));

		// Token: 0x04002CA1 RID: 11425
		private static readonly Marshaller<GetGoogleAuthTokenResponse> __Marshaller_bgs_protocol_sns_v1_GetGoogleAuthTokenResponse = Marshallers.Create<GetGoogleAuthTokenResponse>(new Action<GetGoogleAuthTokenResponse, SerializationContext>(SocialNetworkService.__Helper_SerializeMessage), (DeserializationContext context) => SocialNetworkService.__Helper_DeserializeMessage<GetGoogleAuthTokenResponse>(context, GetGoogleAuthTokenResponse.Parser));

		// Token: 0x04002CA2 RID: 11426
		private static readonly Marshaller<GetGoogleSettingsResponse> __Marshaller_bgs_protocol_sns_v1_GetGoogleSettingsResponse = Marshallers.Create<GetGoogleSettingsResponse>(new Action<GetGoogleSettingsResponse, SerializationContext>(SocialNetworkService.__Helper_SerializeMessage), (DeserializationContext context) => SocialNetworkService.__Helper_DeserializeMessage<GetGoogleSettingsResponse>(context, GetGoogleSettingsResponse.Parser));

		// Token: 0x04002CA3 RID: 11427
		private static readonly Marshaller<GetGoogleAccountLinkStatusRequest> __Marshaller_bgs_protocol_sns_v1_GetGoogleAccountLinkStatusRequest = Marshallers.Create<GetGoogleAccountLinkStatusRequest>(new Action<GetGoogleAccountLinkStatusRequest, SerializationContext>(SocialNetworkService.__Helper_SerializeMessage), (DeserializationContext context) => SocialNetworkService.__Helper_DeserializeMessage<GetGoogleAccountLinkStatusRequest>(context, GetGoogleAccountLinkStatusRequest.Parser));

		// Token: 0x04002CA4 RID: 11428
		private static readonly Marshaller<GetGoogleAccountLinkStatusResponse> __Marshaller_bgs_protocol_sns_v1_GetGoogleAccountLinkStatusResponse = Marshallers.Create<GetGoogleAccountLinkStatusResponse>(new Action<GetGoogleAccountLinkStatusResponse, SerializationContext>(SocialNetworkService.__Helper_SerializeMessage), (DeserializationContext context) => SocialNetworkService.__Helper_DeserializeMessage<GetGoogleAccountLinkStatusResponse>(context, GetGoogleAccountLinkStatusResponse.Parser));

		// Token: 0x04002CA5 RID: 11429
		private static readonly Method<GetFacebookAuthCodeRequest, GetFacebookAuthCodeResponse> __Method_GetFacebookAuthCode = new Method<GetFacebookAuthCodeRequest, GetFacebookAuthCodeResponse>(0, SocialNetworkService.__ServiceName, "GetFacebookAuthCode", SocialNetworkService.__Marshaller_bgs_protocol_sns_v1_GetFacebookAuthCodeRequest, SocialNetworkService.__Marshaller_bgs_protocol_sns_v1_GetFacebookAuthCodeResponse);

		// Token: 0x04002CA6 RID: 11430
		private static readonly Method<GetFacebookBnetFriendsRequest, NoData> __Method_GetFacebookBnetFriends = new Method<GetFacebookBnetFriendsRequest, NoData>(0, SocialNetworkService.__ServiceName, "GetFacebookBnetFriends", SocialNetworkService.__Marshaller_bgs_protocol_sns_v1_GetFacebookBnetFriendsRequest, SocialNetworkService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04002CA7 RID: 11431
		private static readonly Method<NoData, GetFacebookSettingsResponse> __Method_GetFacebookSettings = new Method<NoData, GetFacebookSettingsResponse>(0, SocialNetworkService.__ServiceName, "GetFacebookSettings", SocialNetworkService.__Marshaller_bgs_protocol_NoData, SocialNetworkService.__Marshaller_bgs_protocol_sns_v1_GetFacebookSettingsResponse);

		// Token: 0x04002CA8 RID: 11432
		private static readonly Method<GetFacebookAccountLinkStatusRequest, GetFacebookAccountLinkStatusResponse> __Method_GetFacebookAccountLinkStatus = new Method<GetFacebookAccountLinkStatusRequest, GetFacebookAccountLinkStatusResponse>(0, SocialNetworkService.__ServiceName, "GetFacebookAccountLinkStatus", SocialNetworkService.__Marshaller_bgs_protocol_sns_v1_GetFacebookAccountLinkStatusRequest, SocialNetworkService.__Marshaller_bgs_protocol_sns_v1_GetFacebookAccountLinkStatusResponse);

		// Token: 0x04002CA9 RID: 11433
		private static readonly Method<GetGoogleAuthTokenRequest, GetGoogleAuthTokenResponse> __Method_GetGoogleAuthToken = new Method<GetGoogleAuthTokenRequest, GetGoogleAuthTokenResponse>(0, SocialNetworkService.__ServiceName, "GetGoogleAuthToken", SocialNetworkService.__Marshaller_bgs_protocol_sns_v1_GetGoogleAuthTokenRequest, SocialNetworkService.__Marshaller_bgs_protocol_sns_v1_GetGoogleAuthTokenResponse);

		// Token: 0x04002CAA RID: 11434
		private static readonly Method<NoData, GetGoogleSettingsResponse> __Method_GetGoogleSettings = new Method<NoData, GetGoogleSettingsResponse>(0, SocialNetworkService.__ServiceName, "GetGoogleSettings", SocialNetworkService.__Marshaller_bgs_protocol_NoData, SocialNetworkService.__Marshaller_bgs_protocol_sns_v1_GetGoogleSettingsResponse);

		// Token: 0x04002CAB RID: 11435
		private static readonly Method<GetGoogleAccountLinkStatusRequest, GetGoogleAccountLinkStatusResponse> __Method_GetGoogleAccountLinkStatus = new Method<GetGoogleAccountLinkStatusRequest, GetGoogleAccountLinkStatusResponse>(0, SocialNetworkService.__ServiceName, "GetGoogleAccountLinkStatus", SocialNetworkService.__Marshaller_bgs_protocol_sns_v1_GetGoogleAccountLinkStatusRequest, SocialNetworkService.__Marshaller_bgs_protocol_sns_v1_GetGoogleAccountLinkStatusResponse);

		// Token: 0x02000EA3 RID: 3747
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x0400960C RID: 38412
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02000EA4 RID: 3748
		[BindServiceMethod(typeof(SocialNetworkService), "BindService")]
		public abstract class SocialNetworkServiceBase
		{
			// Token: 0x0600CAB3 RID: 51891 RVA: 0x004A9CBF File Offset: 0x004A7EBF
			public virtual Task<GetFacebookAuthCodeResponse> GetFacebookAuthCode(GetFacebookAuthCodeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600CAB4 RID: 51892 RVA: 0x004A9CD3 File Offset: 0x004A7ED3
			public virtual Task<NoData> GetFacebookBnetFriends(GetFacebookBnetFriendsRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600CAB5 RID: 51893 RVA: 0x004A9CE7 File Offset: 0x004A7EE7
			public virtual Task<GetFacebookSettingsResponse> GetFacebookSettings(NoData request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600CAB6 RID: 51894 RVA: 0x004A9CFB File Offset: 0x004A7EFB
			public virtual Task<GetFacebookAccountLinkStatusResponse> GetFacebookAccountLinkStatus(GetFacebookAccountLinkStatusRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600CAB7 RID: 51895 RVA: 0x004A9D0F File Offset: 0x004A7F0F
			public virtual Task<GetGoogleAuthTokenResponse> GetGoogleAuthToken(GetGoogleAuthTokenRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600CAB8 RID: 51896 RVA: 0x004A9D23 File Offset: 0x004A7F23
			public virtual Task<GetGoogleSettingsResponse> GetGoogleSettings(NoData request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600CAB9 RID: 51897 RVA: 0x004A9D37 File Offset: 0x004A7F37
			public virtual Task<GetGoogleAccountLinkStatusResponse> GetGoogleAccountLinkStatus(GetGoogleAccountLinkStatusRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x02000EA5 RID: 3749
		public class SocialNetworkServiceClient : ClientBase<SocialNetworkService.SocialNetworkServiceClient>
		{
			// Token: 0x0600CABB RID: 51899 RVA: 0x004A9D54 File Offset: 0x004A7F54
			public SocialNetworkServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600CABC RID: 51900 RVA: 0x004A9D5F File Offset: 0x004A7F5F
			public SocialNetworkServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600CABD RID: 51901 RVA: 0x004A9D6A File Offset: 0x004A7F6A
			protected SocialNetworkServiceClient()
			{
			}

			// Token: 0x0600CABE RID: 51902 RVA: 0x004A9D74 File Offset: 0x004A7F74
			protected SocialNetworkServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600CABF RID: 51903 RVA: 0x004A9D80 File Offset: 0x004A7F80
			public virtual GetFacebookAuthCodeResponse GetFacebookAuthCode(GetFacebookAuthCodeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetFacebookAuthCode(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CAC0 RID: 51904 RVA: 0x004A9DA8 File Offset: 0x004A7FA8
			public virtual GetFacebookAuthCodeResponse GetFacebookAuthCode(GetFacebookAuthCodeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetFacebookAuthCodeRequest, GetFacebookAuthCodeResponse>(SocialNetworkService.__Method_GetFacebookAuthCode, null, options, request);
			}

			// Token: 0x0600CAC1 RID: 51905 RVA: 0x004A9DD0 File Offset: 0x004A7FD0
			public virtual AsyncUnaryCall<GetFacebookAuthCodeResponse> GetFacebookAuthCodeAsync(GetFacebookAuthCodeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetFacebookAuthCodeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CAC2 RID: 51906 RVA: 0x004A9DF8 File Offset: 0x004A7FF8
			public virtual AsyncUnaryCall<GetFacebookAuthCodeResponse> GetFacebookAuthCodeAsync(GetFacebookAuthCodeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetFacebookAuthCodeRequest, GetFacebookAuthCodeResponse>(SocialNetworkService.__Method_GetFacebookAuthCode, null, options, request);
			}

			// Token: 0x0600CAC3 RID: 51907 RVA: 0x004A9E20 File Offset: 0x004A8020
			public virtual NoData GetFacebookBnetFriends(GetFacebookBnetFriendsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetFacebookBnetFriends(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CAC4 RID: 51908 RVA: 0x004A9E48 File Offset: 0x004A8048
			public virtual NoData GetFacebookBnetFriends(GetFacebookBnetFriendsRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetFacebookBnetFriendsRequest, NoData>(SocialNetworkService.__Method_GetFacebookBnetFriends, null, options, request);
			}

			// Token: 0x0600CAC5 RID: 51909 RVA: 0x004A9E70 File Offset: 0x004A8070
			public virtual AsyncUnaryCall<NoData> GetFacebookBnetFriendsAsync(GetFacebookBnetFriendsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetFacebookBnetFriendsAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CAC6 RID: 51910 RVA: 0x004A9E98 File Offset: 0x004A8098
			public virtual AsyncUnaryCall<NoData> GetFacebookBnetFriendsAsync(GetFacebookBnetFriendsRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetFacebookBnetFriendsRequest, NoData>(SocialNetworkService.__Method_GetFacebookBnetFriends, null, options, request);
			}

			// Token: 0x0600CAC7 RID: 51911 RVA: 0x004A9EC0 File Offset: 0x004A80C0
			public virtual GetFacebookSettingsResponse GetFacebookSettings(NoData request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetFacebookSettings(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CAC8 RID: 51912 RVA: 0x004A9EE8 File Offset: 0x004A80E8
			public virtual GetFacebookSettingsResponse GetFacebookSettings(NoData request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<NoData, GetFacebookSettingsResponse>(SocialNetworkService.__Method_GetFacebookSettings, null, options, request);
			}

			// Token: 0x0600CAC9 RID: 51913 RVA: 0x004A9F10 File Offset: 0x004A8110
			public virtual AsyncUnaryCall<GetFacebookSettingsResponse> GetFacebookSettingsAsync(NoData request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetFacebookSettingsAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CACA RID: 51914 RVA: 0x004A9F38 File Offset: 0x004A8138
			public virtual AsyncUnaryCall<GetFacebookSettingsResponse> GetFacebookSettingsAsync(NoData request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<NoData, GetFacebookSettingsResponse>(SocialNetworkService.__Method_GetFacebookSettings, null, options, request);
			}

			// Token: 0x0600CACB RID: 51915 RVA: 0x004A9F60 File Offset: 0x004A8160
			public virtual GetFacebookAccountLinkStatusResponse GetFacebookAccountLinkStatus(GetFacebookAccountLinkStatusRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetFacebookAccountLinkStatus(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CACC RID: 51916 RVA: 0x004A9F88 File Offset: 0x004A8188
			public virtual GetFacebookAccountLinkStatusResponse GetFacebookAccountLinkStatus(GetFacebookAccountLinkStatusRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetFacebookAccountLinkStatusRequest, GetFacebookAccountLinkStatusResponse>(SocialNetworkService.__Method_GetFacebookAccountLinkStatus, null, options, request);
			}

			// Token: 0x0600CACD RID: 51917 RVA: 0x004A9FB0 File Offset: 0x004A81B0
			public virtual AsyncUnaryCall<GetFacebookAccountLinkStatusResponse> GetFacebookAccountLinkStatusAsync(GetFacebookAccountLinkStatusRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetFacebookAccountLinkStatusAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CACE RID: 51918 RVA: 0x004A9FD8 File Offset: 0x004A81D8
			public virtual AsyncUnaryCall<GetFacebookAccountLinkStatusResponse> GetFacebookAccountLinkStatusAsync(GetFacebookAccountLinkStatusRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetFacebookAccountLinkStatusRequest, GetFacebookAccountLinkStatusResponse>(SocialNetworkService.__Method_GetFacebookAccountLinkStatus, null, options, request);
			}

			// Token: 0x0600CACF RID: 51919 RVA: 0x004AA000 File Offset: 0x004A8200
			public virtual GetGoogleAuthTokenResponse GetGoogleAuthToken(GetGoogleAuthTokenRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetGoogleAuthToken(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CAD0 RID: 51920 RVA: 0x004AA028 File Offset: 0x004A8228
			public virtual GetGoogleAuthTokenResponse GetGoogleAuthToken(GetGoogleAuthTokenRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetGoogleAuthTokenRequest, GetGoogleAuthTokenResponse>(SocialNetworkService.__Method_GetGoogleAuthToken, null, options, request);
			}

			// Token: 0x0600CAD1 RID: 51921 RVA: 0x004AA050 File Offset: 0x004A8250
			public virtual AsyncUnaryCall<GetGoogleAuthTokenResponse> GetGoogleAuthTokenAsync(GetGoogleAuthTokenRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetGoogleAuthTokenAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CAD2 RID: 51922 RVA: 0x004AA078 File Offset: 0x004A8278
			public virtual AsyncUnaryCall<GetGoogleAuthTokenResponse> GetGoogleAuthTokenAsync(GetGoogleAuthTokenRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetGoogleAuthTokenRequest, GetGoogleAuthTokenResponse>(SocialNetworkService.__Method_GetGoogleAuthToken, null, options, request);
			}

			// Token: 0x0600CAD3 RID: 51923 RVA: 0x004AA0A0 File Offset: 0x004A82A0
			public virtual GetGoogleSettingsResponse GetGoogleSettings(NoData request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetGoogleSettings(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CAD4 RID: 51924 RVA: 0x004AA0C8 File Offset: 0x004A82C8
			public virtual GetGoogleSettingsResponse GetGoogleSettings(NoData request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<NoData, GetGoogleSettingsResponse>(SocialNetworkService.__Method_GetGoogleSettings, null, options, request);
			}

			// Token: 0x0600CAD5 RID: 51925 RVA: 0x004AA0F0 File Offset: 0x004A82F0
			public virtual AsyncUnaryCall<GetGoogleSettingsResponse> GetGoogleSettingsAsync(NoData request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetGoogleSettingsAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CAD6 RID: 51926 RVA: 0x004AA118 File Offset: 0x004A8318
			public virtual AsyncUnaryCall<GetGoogleSettingsResponse> GetGoogleSettingsAsync(NoData request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<NoData, GetGoogleSettingsResponse>(SocialNetworkService.__Method_GetGoogleSettings, null, options, request);
			}

			// Token: 0x0600CAD7 RID: 51927 RVA: 0x004AA140 File Offset: 0x004A8340
			public virtual GetGoogleAccountLinkStatusResponse GetGoogleAccountLinkStatus(GetGoogleAccountLinkStatusRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetGoogleAccountLinkStatus(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CAD8 RID: 51928 RVA: 0x004AA168 File Offset: 0x004A8368
			public virtual GetGoogleAccountLinkStatusResponse GetGoogleAccountLinkStatus(GetGoogleAccountLinkStatusRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetGoogleAccountLinkStatusRequest, GetGoogleAccountLinkStatusResponse>(SocialNetworkService.__Method_GetGoogleAccountLinkStatus, null, options, request);
			}

			// Token: 0x0600CAD9 RID: 51929 RVA: 0x004AA190 File Offset: 0x004A8390
			public virtual AsyncUnaryCall<GetGoogleAccountLinkStatusResponse> GetGoogleAccountLinkStatusAsync(GetGoogleAccountLinkStatusRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetGoogleAccountLinkStatusAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CADA RID: 51930 RVA: 0x004AA1B8 File Offset: 0x004A83B8
			public virtual AsyncUnaryCall<GetGoogleAccountLinkStatusResponse> GetGoogleAccountLinkStatusAsync(GetGoogleAccountLinkStatusRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetGoogleAccountLinkStatusRequest, GetGoogleAccountLinkStatusResponse>(SocialNetworkService.__Method_GetGoogleAccountLinkStatus, null, options, request);
			}

			// Token: 0x0600CADB RID: 51931 RVA: 0x004AA1E0 File Offset: 0x004A83E0
			protected override SocialNetworkService.SocialNetworkServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new SocialNetworkService.SocialNetworkServiceClient(configuration);
			}
		}
	}
}
