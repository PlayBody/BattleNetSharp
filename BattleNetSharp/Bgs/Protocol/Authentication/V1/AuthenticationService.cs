using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Authentication.V1
{
	// Token: 0x0200061A RID: 1562
	public static class AuthenticationService
	{
		// Token: 0x0600923D RID: 37437 RVA: 0x00236BC4 File Offset: 0x00234DC4
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

		// Token: 0x0600923E RID: 37438 RVA: 0x00236C10 File Offset: 0x00234E10
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

		// Token: 0x17002DB0 RID: 11696
		// (get) Token: 0x0600923F RID: 37439 RVA: 0x00236C48 File Offset: 0x00234E48
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.Services[1];
			}
		}

		// Token: 0x06009240 RID: 37440 RVA: 0x00236C6C File Offset: 0x00234E6C
		public static ServerServiceDefinition BindService(AuthenticationService.AuthenticationServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<LogonRequest, NoData>(AuthenticationService.__Method_Logon, new UnaryServerMethod<LogonRequest, NoData>(serviceImpl.Logon)).AddMethod<ModuleNotification, NoData>(AuthenticationService.__Method_ModuleNotify, new UnaryServerMethod<ModuleNotification, NoData>(serviceImpl.ModuleNotify))
				.AddMethod<ModuleMessageRequest, NoData>(AuthenticationService.__Method_ModuleMessage, new UnaryServerMethod<ModuleMessageRequest, NoData>(serviceImpl.ModuleMessage))
				.AddMethod<EntityId, NoData>(AuthenticationService.__Method_SelectGameAccount_DEPRECATED, new UnaryServerMethod<EntityId, NoData>(serviceImpl.SelectGameAccount_DEPRECATED))
				.AddMethod<GenerateSSOTokenRequest, GenerateSSOTokenResponse>(AuthenticationService.__Method_GenerateSSOToken, new UnaryServerMethod<GenerateSSOTokenRequest, GenerateSSOTokenResponse>(serviceImpl.GenerateSSOToken))
				.AddMethod<SelectGameAccountRequest, NoData>(AuthenticationService.__Method_SelectGameAccount, new UnaryServerMethod<SelectGameAccountRequest, NoData>(serviceImpl.SelectGameAccount))
				.AddMethod<VerifyWebCredentialsRequest, NoData>(AuthenticationService.__Method_VerifyWebCredentials, new UnaryServerMethod<VerifyWebCredentialsRequest, NoData>(serviceImpl.VerifyWebCredentials))
				.AddMethod<GenerateWebCredentialsRequest, GenerateWebCredentialsResponse>(AuthenticationService.__Method_GenerateWebCredentials, new UnaryServerMethod<GenerateWebCredentialsRequest, GenerateWebCredentialsResponse>(serviceImpl.GenerateWebCredentials))
				.Build();
		}

		// Token: 0x06009241 RID: 37441 RVA: 0x00236D40 File Offset: 0x00234F40
		public static void BindService(ServiceBinderBase serviceBinder, AuthenticationService.AuthenticationServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<LogonRequest, NoData>(AuthenticationService.__Method_Logon, (serviceImpl == null) ? null : new UnaryServerMethod<LogonRequest, NoData>(serviceImpl.Logon));
			serviceBinder.AddMethod<ModuleNotification, NoData>(AuthenticationService.__Method_ModuleNotify, (serviceImpl == null) ? null : new UnaryServerMethod<ModuleNotification, NoData>(serviceImpl.ModuleNotify));
			serviceBinder.AddMethod<ModuleMessageRequest, NoData>(AuthenticationService.__Method_ModuleMessage, (serviceImpl == null) ? null : new UnaryServerMethod<ModuleMessageRequest, NoData>(serviceImpl.ModuleMessage));
			serviceBinder.AddMethod<EntityId, NoData>(AuthenticationService.__Method_SelectGameAccount_DEPRECATED, (serviceImpl == null) ? null : new UnaryServerMethod<EntityId, NoData>(serviceImpl.SelectGameAccount_DEPRECATED));
			serviceBinder.AddMethod<GenerateSSOTokenRequest, GenerateSSOTokenResponse>(AuthenticationService.__Method_GenerateSSOToken, (serviceImpl == null) ? null : new UnaryServerMethod<GenerateSSOTokenRequest, GenerateSSOTokenResponse>(serviceImpl.GenerateSSOToken));
			serviceBinder.AddMethod<SelectGameAccountRequest, NoData>(AuthenticationService.__Method_SelectGameAccount, (serviceImpl == null) ? null : new UnaryServerMethod<SelectGameAccountRequest, NoData>(serviceImpl.SelectGameAccount));
			serviceBinder.AddMethod<VerifyWebCredentialsRequest, NoData>(AuthenticationService.__Method_VerifyWebCredentials, (serviceImpl == null) ? null : new UnaryServerMethod<VerifyWebCredentialsRequest, NoData>(serviceImpl.VerifyWebCredentials));
			serviceBinder.AddMethod<GenerateWebCredentialsRequest, GenerateWebCredentialsResponse>(AuthenticationService.__Method_GenerateWebCredentials, (serviceImpl == null) ? null : new UnaryServerMethod<GenerateWebCredentialsRequest, GenerateWebCredentialsResponse>(serviceImpl.GenerateWebCredentials));
		}

		// Token: 0x040041FF RID: 16895
		private static readonly string __ServiceName = "bgs.protocol.authentication.v1.AuthenticationService";

		// Token: 0x04004200 RID: 16896
		private static readonly Marshaller<LogonRequest> __Marshaller_bgs_protocol_authentication_v1_LogonRequest = Marshallers.Create<LogonRequest>(new Action<LogonRequest, SerializationContext>(AuthenticationService.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationService.__Helper_DeserializeMessage<LogonRequest>(context, LogonRequest.Parser));

		// Token: 0x04004201 RID: 16897
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(AuthenticationService.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationService.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x04004202 RID: 16898
		private static readonly Marshaller<ModuleNotification> __Marshaller_bgs_protocol_authentication_v1_ModuleNotification = Marshallers.Create<ModuleNotification>(new Action<ModuleNotification, SerializationContext>(AuthenticationService.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationService.__Helper_DeserializeMessage<ModuleNotification>(context, ModuleNotification.Parser));

		// Token: 0x04004203 RID: 16899
		private static readonly Marshaller<ModuleMessageRequest> __Marshaller_bgs_protocol_authentication_v1_ModuleMessageRequest = Marshallers.Create<ModuleMessageRequest>(new Action<ModuleMessageRequest, SerializationContext>(AuthenticationService.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationService.__Helper_DeserializeMessage<ModuleMessageRequest>(context, ModuleMessageRequest.Parser));

		// Token: 0x04004204 RID: 16900
		private static readonly Marshaller<EntityId> __Marshaller_bgs_protocol_EntityId = Marshallers.Create<EntityId>(new Action<EntityId, SerializationContext>(AuthenticationService.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationService.__Helper_DeserializeMessage<EntityId>(context, EntityId.Parser));

		// Token: 0x04004205 RID: 16901
		private static readonly Marshaller<GenerateSSOTokenRequest> __Marshaller_bgs_protocol_authentication_v1_GenerateSSOTokenRequest = Marshallers.Create<GenerateSSOTokenRequest>(new Action<GenerateSSOTokenRequest, SerializationContext>(AuthenticationService.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationService.__Helper_DeserializeMessage<GenerateSSOTokenRequest>(context, GenerateSSOTokenRequest.Parser));

		// Token: 0x04004206 RID: 16902
		private static readonly Marshaller<GenerateSSOTokenResponse> __Marshaller_bgs_protocol_authentication_v1_GenerateSSOTokenResponse = Marshallers.Create<GenerateSSOTokenResponse>(new Action<GenerateSSOTokenResponse, SerializationContext>(AuthenticationService.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationService.__Helper_DeserializeMessage<GenerateSSOTokenResponse>(context, GenerateSSOTokenResponse.Parser));

		// Token: 0x04004207 RID: 16903
		private static readonly Marshaller<SelectGameAccountRequest> __Marshaller_bgs_protocol_authentication_v1_SelectGameAccountRequest = Marshallers.Create<SelectGameAccountRequest>(new Action<SelectGameAccountRequest, SerializationContext>(AuthenticationService.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationService.__Helper_DeserializeMessage<SelectGameAccountRequest>(context, SelectGameAccountRequest.Parser));

		// Token: 0x04004208 RID: 16904
		private static readonly Marshaller<VerifyWebCredentialsRequest> __Marshaller_bgs_protocol_authentication_v1_VerifyWebCredentialsRequest = Marshallers.Create<VerifyWebCredentialsRequest>(new Action<VerifyWebCredentialsRequest, SerializationContext>(AuthenticationService.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationService.__Helper_DeserializeMessage<VerifyWebCredentialsRequest>(context, VerifyWebCredentialsRequest.Parser));

		// Token: 0x04004209 RID: 16905
		private static readonly Marshaller<GenerateWebCredentialsRequest> __Marshaller_bgs_protocol_authentication_v1_GenerateWebCredentialsRequest = Marshallers.Create<GenerateWebCredentialsRequest>(new Action<GenerateWebCredentialsRequest, SerializationContext>(AuthenticationService.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationService.__Helper_DeserializeMessage<GenerateWebCredentialsRequest>(context, GenerateWebCredentialsRequest.Parser));

		// Token: 0x0400420A RID: 16906
		private static readonly Marshaller<GenerateWebCredentialsResponse> __Marshaller_bgs_protocol_authentication_v1_GenerateWebCredentialsResponse = Marshallers.Create<GenerateWebCredentialsResponse>(new Action<GenerateWebCredentialsResponse, SerializationContext>(AuthenticationService.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationService.__Helper_DeserializeMessage<GenerateWebCredentialsResponse>(context, GenerateWebCredentialsResponse.Parser));

		// Token: 0x0400420B RID: 16907
		private static readonly Method<LogonRequest, NoData> __Method_Logon = new Method<LogonRequest, NoData>(0, AuthenticationService.__ServiceName, "Logon", AuthenticationService.__Marshaller_bgs_protocol_authentication_v1_LogonRequest, AuthenticationService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x0400420C RID: 16908
		private static readonly Method<ModuleNotification, NoData> __Method_ModuleNotify = new Method<ModuleNotification, NoData>(0, AuthenticationService.__ServiceName, "ModuleNotify", AuthenticationService.__Marshaller_bgs_protocol_authentication_v1_ModuleNotification, AuthenticationService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x0400420D RID: 16909
		private static readonly Method<ModuleMessageRequest, NoData> __Method_ModuleMessage = new Method<ModuleMessageRequest, NoData>(0, AuthenticationService.__ServiceName, "ModuleMessage", AuthenticationService.__Marshaller_bgs_protocol_authentication_v1_ModuleMessageRequest, AuthenticationService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x0400420E RID: 16910
		private static readonly Method<EntityId, NoData> __Method_SelectGameAccount_DEPRECATED = new Method<EntityId, NoData>(0, AuthenticationService.__ServiceName, "SelectGameAccount_DEPRECATED", AuthenticationService.__Marshaller_bgs_protocol_EntityId, AuthenticationService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x0400420F RID: 16911
		private static readonly Method<GenerateSSOTokenRequest, GenerateSSOTokenResponse> __Method_GenerateSSOToken = new Method<GenerateSSOTokenRequest, GenerateSSOTokenResponse>(0, AuthenticationService.__ServiceName, "GenerateSSOToken", AuthenticationService.__Marshaller_bgs_protocol_authentication_v1_GenerateSSOTokenRequest, AuthenticationService.__Marshaller_bgs_protocol_authentication_v1_GenerateSSOTokenResponse);

		// Token: 0x04004210 RID: 16912
		private static readonly Method<SelectGameAccountRequest, NoData> __Method_SelectGameAccount = new Method<SelectGameAccountRequest, NoData>(0, AuthenticationService.__ServiceName, "SelectGameAccount", AuthenticationService.__Marshaller_bgs_protocol_authentication_v1_SelectGameAccountRequest, AuthenticationService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04004211 RID: 16913
		private static readonly Method<VerifyWebCredentialsRequest, NoData> __Method_VerifyWebCredentials = new Method<VerifyWebCredentialsRequest, NoData>(0, AuthenticationService.__ServiceName, "VerifyWebCredentials", AuthenticationService.__Marshaller_bgs_protocol_authentication_v1_VerifyWebCredentialsRequest, AuthenticationService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04004212 RID: 16914
		private static readonly Method<GenerateWebCredentialsRequest, GenerateWebCredentialsResponse> __Method_GenerateWebCredentials = new Method<GenerateWebCredentialsRequest, GenerateWebCredentialsResponse>(0, AuthenticationService.__ServiceName, "GenerateWebCredentials", AuthenticationService.__Marshaller_bgs_protocol_authentication_v1_GenerateWebCredentialsRequest, AuthenticationService.__Marshaller_bgs_protocol_authentication_v1_GenerateWebCredentialsResponse);

		// Token: 0x02001108 RID: 4360
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x04009845 RID: 38981
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02001109 RID: 4361
		[BindServiceMethod(typeof(AuthenticationService), "BindService")]
		public abstract class AuthenticationServiceBase
		{
			// Token: 0x0600D50F RID: 54543 RVA: 0x004B523E File Offset: 0x004B343E
			public virtual Task<NoData> Logon(LogonRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D510 RID: 54544 RVA: 0x004B5252 File Offset: 0x004B3452
			public virtual Task<NoData> ModuleNotify(ModuleNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D511 RID: 54545 RVA: 0x004B5266 File Offset: 0x004B3466
			public virtual Task<NoData> ModuleMessage(ModuleMessageRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D512 RID: 54546 RVA: 0x004B527A File Offset: 0x004B347A
			public virtual Task<NoData> SelectGameAccount_DEPRECATED(EntityId request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D513 RID: 54547 RVA: 0x004B528E File Offset: 0x004B348E
			public virtual Task<GenerateSSOTokenResponse> GenerateSSOToken(GenerateSSOTokenRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D514 RID: 54548 RVA: 0x004B52A2 File Offset: 0x004B34A2
			public virtual Task<NoData> SelectGameAccount(SelectGameAccountRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D515 RID: 54549 RVA: 0x004B52B6 File Offset: 0x004B34B6
			public virtual Task<NoData> VerifyWebCredentials(VerifyWebCredentialsRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D516 RID: 54550 RVA: 0x004B52CA File Offset: 0x004B34CA
			public virtual Task<GenerateWebCredentialsResponse> GenerateWebCredentials(GenerateWebCredentialsRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x0200110A RID: 4362
		public class AuthenticationServiceClient : ClientBase<AuthenticationService.AuthenticationServiceClient>
		{
			// Token: 0x0600D518 RID: 54552 RVA: 0x004B52E7 File Offset: 0x004B34E7
			public AuthenticationServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D519 RID: 54553 RVA: 0x004B52F2 File Offset: 0x004B34F2
			public AuthenticationServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D51A RID: 54554 RVA: 0x004B52FD File Offset: 0x004B34FD
			protected AuthenticationServiceClient()
			{
			}

			// Token: 0x0600D51B RID: 54555 RVA: 0x004B5307 File Offset: 0x004B3507
			protected AuthenticationServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D51C RID: 54556 RVA: 0x004B5314 File Offset: 0x004B3514
			public virtual NoData Logon(LogonRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Logon(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D51D RID: 54557 RVA: 0x004B533C File Offset: 0x004B353C
			public virtual NoData Logon(LogonRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<LogonRequest, NoData>(AuthenticationService.__Method_Logon, null, options, request);
			}

			// Token: 0x0600D51E RID: 54558 RVA: 0x004B5364 File Offset: 0x004B3564
			public virtual AsyncUnaryCall<NoData> LogonAsync(LogonRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.LogonAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D51F RID: 54559 RVA: 0x004B538C File Offset: 0x004B358C
			public virtual AsyncUnaryCall<NoData> LogonAsync(LogonRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<LogonRequest, NoData>(AuthenticationService.__Method_Logon, null, options, request);
			}

			// Token: 0x0600D520 RID: 54560 RVA: 0x004B53B4 File Offset: 0x004B35B4
			public virtual NoData ModuleNotify(ModuleNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ModuleNotify(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D521 RID: 54561 RVA: 0x004B53DC File Offset: 0x004B35DC
			public virtual NoData ModuleNotify(ModuleNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ModuleNotification, NoData>(AuthenticationService.__Method_ModuleNotify, null, options, request);
			}

			// Token: 0x0600D522 RID: 54562 RVA: 0x004B5404 File Offset: 0x004B3604
			public virtual AsyncUnaryCall<NoData> ModuleNotifyAsync(ModuleNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ModuleNotifyAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D523 RID: 54563 RVA: 0x004B542C File Offset: 0x004B362C
			public virtual AsyncUnaryCall<NoData> ModuleNotifyAsync(ModuleNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ModuleNotification, NoData>(AuthenticationService.__Method_ModuleNotify, null, options, request);
			}

			// Token: 0x0600D524 RID: 54564 RVA: 0x004B5454 File Offset: 0x004B3654
			public virtual NoData ModuleMessage(ModuleMessageRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ModuleMessage(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D525 RID: 54565 RVA: 0x004B547C File Offset: 0x004B367C
			public virtual NoData ModuleMessage(ModuleMessageRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ModuleMessageRequest, NoData>(AuthenticationService.__Method_ModuleMessage, null, options, request);
			}

			// Token: 0x0600D526 RID: 54566 RVA: 0x004B54A4 File Offset: 0x004B36A4
			public virtual AsyncUnaryCall<NoData> ModuleMessageAsync(ModuleMessageRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ModuleMessageAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D527 RID: 54567 RVA: 0x004B54CC File Offset: 0x004B36CC
			public virtual AsyncUnaryCall<NoData> ModuleMessageAsync(ModuleMessageRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ModuleMessageRequest, NoData>(AuthenticationService.__Method_ModuleMessage, null, options, request);
			}

			// Token: 0x0600D528 RID: 54568 RVA: 0x004B54F4 File Offset: 0x004B36F4
			public virtual NoData SelectGameAccount_DEPRECATED(EntityId request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SelectGameAccount_DEPRECATED(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D529 RID: 54569 RVA: 0x004B551C File Offset: 0x004B371C
			public virtual NoData SelectGameAccount_DEPRECATED(EntityId request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<EntityId, NoData>(AuthenticationService.__Method_SelectGameAccount_DEPRECATED, null, options, request);
			}

			// Token: 0x0600D52A RID: 54570 RVA: 0x004B5544 File Offset: 0x004B3744
			public virtual AsyncUnaryCall<NoData> SelectGameAccount_DEPRECATEDAsync(EntityId request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SelectGameAccount_DEPRECATEDAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D52B RID: 54571 RVA: 0x004B556C File Offset: 0x004B376C
			public virtual AsyncUnaryCall<NoData> SelectGameAccount_DEPRECATEDAsync(EntityId request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<EntityId, NoData>(AuthenticationService.__Method_SelectGameAccount_DEPRECATED, null, options, request);
			}

			// Token: 0x0600D52C RID: 54572 RVA: 0x004B5594 File Offset: 0x004B3794
			public virtual GenerateSSOTokenResponse GenerateSSOToken(GenerateSSOTokenRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GenerateSSOToken(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D52D RID: 54573 RVA: 0x004B55BC File Offset: 0x004B37BC
			public virtual GenerateSSOTokenResponse GenerateSSOToken(GenerateSSOTokenRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GenerateSSOTokenRequest, GenerateSSOTokenResponse>(AuthenticationService.__Method_GenerateSSOToken, null, options, request);
			}

			// Token: 0x0600D52E RID: 54574 RVA: 0x004B55E4 File Offset: 0x004B37E4
			public virtual AsyncUnaryCall<GenerateSSOTokenResponse> GenerateSSOTokenAsync(GenerateSSOTokenRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GenerateSSOTokenAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D52F RID: 54575 RVA: 0x004B560C File Offset: 0x004B380C
			public virtual AsyncUnaryCall<GenerateSSOTokenResponse> GenerateSSOTokenAsync(GenerateSSOTokenRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GenerateSSOTokenRequest, GenerateSSOTokenResponse>(AuthenticationService.__Method_GenerateSSOToken, null, options, request);
			}

			// Token: 0x0600D530 RID: 54576 RVA: 0x004B5634 File Offset: 0x004B3834
			public virtual NoData SelectGameAccount(SelectGameAccountRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SelectGameAccount(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D531 RID: 54577 RVA: 0x004B565C File Offset: 0x004B385C
			public virtual NoData SelectGameAccount(SelectGameAccountRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SelectGameAccountRequest, NoData>(AuthenticationService.__Method_SelectGameAccount, null, options, request);
			}

			// Token: 0x0600D532 RID: 54578 RVA: 0x004B5684 File Offset: 0x004B3884
			public virtual AsyncUnaryCall<NoData> SelectGameAccountAsync(SelectGameAccountRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SelectGameAccountAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D533 RID: 54579 RVA: 0x004B56AC File Offset: 0x004B38AC
			public virtual AsyncUnaryCall<NoData> SelectGameAccountAsync(SelectGameAccountRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SelectGameAccountRequest, NoData>(AuthenticationService.__Method_SelectGameAccount, null, options, request);
			}

			// Token: 0x0600D534 RID: 54580 RVA: 0x004B56D4 File Offset: 0x004B38D4
			public virtual NoData VerifyWebCredentials(VerifyWebCredentialsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.VerifyWebCredentials(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D535 RID: 54581 RVA: 0x004B56FC File Offset: 0x004B38FC
			public virtual NoData VerifyWebCredentials(VerifyWebCredentialsRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<VerifyWebCredentialsRequest, NoData>(AuthenticationService.__Method_VerifyWebCredentials, null, options, request);
			}

			// Token: 0x0600D536 RID: 54582 RVA: 0x004B5724 File Offset: 0x004B3924
			public virtual AsyncUnaryCall<NoData> VerifyWebCredentialsAsync(VerifyWebCredentialsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.VerifyWebCredentialsAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D537 RID: 54583 RVA: 0x004B574C File Offset: 0x004B394C
			public virtual AsyncUnaryCall<NoData> VerifyWebCredentialsAsync(VerifyWebCredentialsRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<VerifyWebCredentialsRequest, NoData>(AuthenticationService.__Method_VerifyWebCredentials, null, options, request);
			}

			// Token: 0x0600D538 RID: 54584 RVA: 0x004B5774 File Offset: 0x004B3974
			public virtual GenerateWebCredentialsResponse GenerateWebCredentials(GenerateWebCredentialsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GenerateWebCredentials(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D539 RID: 54585 RVA: 0x004B579C File Offset: 0x004B399C
			public virtual GenerateWebCredentialsResponse GenerateWebCredentials(GenerateWebCredentialsRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GenerateWebCredentialsRequest, GenerateWebCredentialsResponse>(AuthenticationService.__Method_GenerateWebCredentials, null, options, request);
			}

			// Token: 0x0600D53A RID: 54586 RVA: 0x004B57C4 File Offset: 0x004B39C4
			public virtual AsyncUnaryCall<GenerateWebCredentialsResponse> GenerateWebCredentialsAsync(GenerateWebCredentialsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GenerateWebCredentialsAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D53B RID: 54587 RVA: 0x004B57EC File Offset: 0x004B39EC
			public virtual AsyncUnaryCall<GenerateWebCredentialsResponse> GenerateWebCredentialsAsync(GenerateWebCredentialsRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GenerateWebCredentialsRequest, GenerateWebCredentialsResponse>(AuthenticationService.__Method_GenerateWebCredentials, null, options, request);
			}

			// Token: 0x0600D53C RID: 54588 RVA: 0x004B5814 File Offset: 0x004B3A14
			protected override AuthenticationService.AuthenticationServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new AuthenticationService.AuthenticationServiceClient(configuration);
			}
		}
	}
}
