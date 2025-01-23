using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Authentication.V2.Client
{
	// Token: 0x02000625 RID: 1573
	public static class AuthenticationService
	{
		// Token: 0x060092F6 RID: 37622 RVA: 0x00239794 File Offset: 0x00237994
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

		// Token: 0x060092F7 RID: 37623 RVA: 0x002397E0 File Offset: 0x002379E0
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = AuthenticationService.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17002DE2 RID: 11746
		// (get) Token: 0x060092F8 RID: 37624 RVA: 0x00239818 File Offset: 0x00237A18
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x060092F9 RID: 37625 RVA: 0x0023983C File Offset: 0x00237A3C
		public static ServerServiceDefinition BindService(AuthenticationService.AuthenticationServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<LogonRequest, NoData>(AuthenticationService.__Method_Logon, new UnaryServerMethod<LogonRequest, NoData>(serviceImpl.Logon)).AddMethod<VerifyAuthTokenRequest, NoData>(AuthenticationService.__Method_VerifyAuthToken, new UnaryServerMethod<VerifyAuthTokenRequest, NoData>(serviceImpl.VerifyAuthToken))
				.AddMethod<GenerateAuthTokenRequest, GenerateAuthTokenResponse>(AuthenticationService.__Method_GenerateAuthToken, new UnaryServerMethod<GenerateAuthTokenRequest, GenerateAuthTokenResponse>(serviceImpl.GenerateAuthToken))
				.Build();
		}

		// Token: 0x060092FA RID: 37626 RVA: 0x002398A0 File Offset: 0x00237AA0
		public static void BindService(ServiceBinderBase serviceBinder, AuthenticationService.AuthenticationServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<LogonRequest, NoData>(AuthenticationService.__Method_Logon, (serviceImpl == null) ? null : new UnaryServerMethod<LogonRequest, NoData>(serviceImpl.Logon));
			serviceBinder.AddMethod<VerifyAuthTokenRequest, NoData>(AuthenticationService.__Method_VerifyAuthToken, (serviceImpl == null) ? null : new UnaryServerMethod<VerifyAuthTokenRequest, NoData>(serviceImpl.VerifyAuthToken));
			serviceBinder.AddMethod<GenerateAuthTokenRequest, GenerateAuthTokenResponse>(AuthenticationService.__Method_GenerateAuthToken, (serviceImpl == null) ? null : new UnaryServerMethod<GenerateAuthTokenRequest, GenerateAuthTokenResponse>(serviceImpl.GenerateAuthToken));
		}

		// Token: 0x04004257 RID: 16983
		private static readonly string __ServiceName = "bgs.protocol.authentication.v2.client.AuthenticationService";

		// Token: 0x04004258 RID: 16984
		private static readonly Marshaller<LogonRequest> __Marshaller_bgs_protocol_authentication_v2_client_LogonRequest = Marshallers.Create<LogonRequest>(new Action<LogonRequest, SerializationContext>(AuthenticationService.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationService.__Helper_DeserializeMessage<LogonRequest>(context, LogonRequest.Parser));

		// Token: 0x04004259 RID: 16985
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(AuthenticationService.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationService.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x0400425A RID: 16986
		private static readonly Marshaller<VerifyAuthTokenRequest> __Marshaller_bgs_protocol_authentication_v2_client_VerifyAuthTokenRequest = Marshallers.Create<VerifyAuthTokenRequest>(new Action<VerifyAuthTokenRequest, SerializationContext>(AuthenticationService.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationService.__Helper_DeserializeMessage<VerifyAuthTokenRequest>(context, VerifyAuthTokenRequest.Parser));

		// Token: 0x0400425B RID: 16987
		private static readonly Marshaller<GenerateAuthTokenRequest> __Marshaller_bgs_protocol_authentication_v2_client_GenerateAuthTokenRequest = Marshallers.Create<GenerateAuthTokenRequest>(new Action<GenerateAuthTokenRequest, SerializationContext>(AuthenticationService.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationService.__Helper_DeserializeMessage<GenerateAuthTokenRequest>(context, GenerateAuthTokenRequest.Parser));

		// Token: 0x0400425C RID: 16988
		private static readonly Marshaller<GenerateAuthTokenResponse> __Marshaller_bgs_protocol_authentication_v2_client_GenerateAuthTokenResponse = Marshallers.Create<GenerateAuthTokenResponse>(new Action<GenerateAuthTokenResponse, SerializationContext>(AuthenticationService.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationService.__Helper_DeserializeMessage<GenerateAuthTokenResponse>(context, GenerateAuthTokenResponse.Parser));

		// Token: 0x0400425D RID: 16989
		private static readonly Method<LogonRequest, NoData> __Method_Logon = new Method<LogonRequest, NoData>(0, AuthenticationService.__ServiceName, "Logon", AuthenticationService.__Marshaller_bgs_protocol_authentication_v2_client_LogonRequest, AuthenticationService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x0400425E RID: 16990
		private static readonly Method<VerifyAuthTokenRequest, NoData> __Method_VerifyAuthToken = new Method<VerifyAuthTokenRequest, NoData>(0, AuthenticationService.__ServiceName, "VerifyAuthToken", AuthenticationService.__Marshaller_bgs_protocol_authentication_v2_client_VerifyAuthTokenRequest, AuthenticationService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x0400425F RID: 16991
		private static readonly Method<GenerateAuthTokenRequest, GenerateAuthTokenResponse> __Method_GenerateAuthToken = new Method<GenerateAuthTokenRequest, GenerateAuthTokenResponse>(0, AuthenticationService.__ServiceName, "GenerateAuthToken", AuthenticationService.__Marshaller_bgs_protocol_authentication_v2_client_GenerateAuthTokenRequest, AuthenticationService.__Marshaller_bgs_protocol_authentication_v2_client_GenerateAuthTokenResponse);

		// Token: 0x02001117 RID: 4375
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x04009850 RID: 38992
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02001118 RID: 4376
		[BindServiceMethod(typeof(AuthenticationService), "BindService")]
		public abstract class AuthenticationServiceBase
		{
			// Token: 0x0600D582 RID: 54658 RVA: 0x004B5D53 File Offset: 0x004B3F53
			public virtual Task<NoData> Logon(LogonRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D583 RID: 54659 RVA: 0x004B5D67 File Offset: 0x004B3F67
			public virtual Task<NoData> VerifyAuthToken(VerifyAuthTokenRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D584 RID: 54660 RVA: 0x004B5D7B File Offset: 0x004B3F7B
			public virtual Task<GenerateAuthTokenResponse> GenerateAuthToken(GenerateAuthTokenRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x02001119 RID: 4377
		public class AuthenticationServiceClient : ClientBase<AuthenticationService.AuthenticationServiceClient>
		{
			// Token: 0x0600D586 RID: 54662 RVA: 0x004B5D98 File Offset: 0x004B3F98
			public AuthenticationServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D587 RID: 54663 RVA: 0x004B5DA3 File Offset: 0x004B3FA3
			public AuthenticationServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D588 RID: 54664 RVA: 0x004B5DAE File Offset: 0x004B3FAE
			protected AuthenticationServiceClient()
			{
			}

			// Token: 0x0600D589 RID: 54665 RVA: 0x004B5DB8 File Offset: 0x004B3FB8
			protected AuthenticationServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D58A RID: 54666 RVA: 0x004B5DC4 File Offset: 0x004B3FC4
			public virtual NoData Logon(LogonRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Logon(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D58B RID: 54667 RVA: 0x004B5DEC File Offset: 0x004B3FEC
			public virtual NoData Logon(LogonRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<LogonRequest, NoData>(AuthenticationService.__Method_Logon, null, options, request);
			}

			// Token: 0x0600D58C RID: 54668 RVA: 0x004B5E14 File Offset: 0x004B4014
			public virtual AsyncUnaryCall<NoData> LogonAsync(LogonRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.LogonAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D58D RID: 54669 RVA: 0x004B5E3C File Offset: 0x004B403C
			public virtual AsyncUnaryCall<NoData> LogonAsync(LogonRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<LogonRequest, NoData>(AuthenticationService.__Method_Logon, null, options, request);
			}

			// Token: 0x0600D58E RID: 54670 RVA: 0x004B5E64 File Offset: 0x004B4064
			public virtual NoData VerifyAuthToken(VerifyAuthTokenRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.VerifyAuthToken(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D58F RID: 54671 RVA: 0x004B5E8C File Offset: 0x004B408C
			public virtual NoData VerifyAuthToken(VerifyAuthTokenRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<VerifyAuthTokenRequest, NoData>(AuthenticationService.__Method_VerifyAuthToken, null, options, request);
			}

			// Token: 0x0600D590 RID: 54672 RVA: 0x004B5EB4 File Offset: 0x004B40B4
			public virtual AsyncUnaryCall<NoData> VerifyAuthTokenAsync(VerifyAuthTokenRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.VerifyAuthTokenAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D591 RID: 54673 RVA: 0x004B5EDC File Offset: 0x004B40DC
			public virtual AsyncUnaryCall<NoData> VerifyAuthTokenAsync(VerifyAuthTokenRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<VerifyAuthTokenRequest, NoData>(AuthenticationService.__Method_VerifyAuthToken, null, options, request);
			}

			// Token: 0x0600D592 RID: 54674 RVA: 0x004B5F04 File Offset: 0x004B4104
			public virtual GenerateAuthTokenResponse GenerateAuthToken(GenerateAuthTokenRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GenerateAuthToken(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D593 RID: 54675 RVA: 0x004B5F2C File Offset: 0x004B412C
			public virtual GenerateAuthTokenResponse GenerateAuthToken(GenerateAuthTokenRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GenerateAuthTokenRequest, GenerateAuthTokenResponse>(AuthenticationService.__Method_GenerateAuthToken, null, options, request);
			}

			// Token: 0x0600D594 RID: 54676 RVA: 0x004B5F54 File Offset: 0x004B4154
			public virtual AsyncUnaryCall<GenerateAuthTokenResponse> GenerateAuthTokenAsync(GenerateAuthTokenRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GenerateAuthTokenAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D595 RID: 54677 RVA: 0x004B5F7C File Offset: 0x004B417C
			public virtual AsyncUnaryCall<GenerateAuthTokenResponse> GenerateAuthTokenAsync(GenerateAuthTokenRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GenerateAuthTokenRequest, GenerateAuthTokenResponse>(AuthenticationService.__Method_GenerateAuthToken, null, options, request);
			}

			// Token: 0x0600D596 RID: 54678 RVA: 0x004B5FA4 File Offset: 0x004B41A4
			protected override AuthenticationService.AuthenticationServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new AuthenticationService.AuthenticationServiceClient(configuration);
			}
		}
	}
}
