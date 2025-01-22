using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x0200072B RID: 1835
	public static class AccountService
	{
		// Token: 0x0600A82B RID: 43051 RVA: 0x0028E3E4 File Offset: 0x0028C5E4
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

		// Token: 0x0600A82C RID: 43052 RVA: 0x0028E430 File Offset: 0x0028C630
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = AccountService.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x170033DA RID: 13274
		// (get) Token: 0x0600A82D RID: 43053 RVA: 0x0028E468 File Offset: 0x0028C668
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x0600A82E RID: 43054 RVA: 0x0028E48C File Offset: 0x0028C68C
		public static ServerServiceDefinition BindService(AccountService.AccountServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<ResolveAccountRequest, ResolveAccountResponse>(AccountService.__Method_ResolveAccount, new UnaryServerMethod<ResolveAccountRequest, ResolveAccountResponse>(serviceImpl.ResolveAccount)).AddMethod<IsIgrAddressRequest, NoData>(AccountService.__Method_IsIgrAddress, new UnaryServerMethod<IsIgrAddressRequest, NoData>(serviceImpl.IsIgrAddress))
				.AddMethod<SubscriptionUpdateRequest, SubscriptionUpdateResponse>(AccountService.__Method_Subscribe, new UnaryServerMethod<SubscriptionUpdateRequest, SubscriptionUpdateResponse>(serviceImpl.Subscribe))
				.AddMethod<SubscriptionUpdateRequest, NoData>(AccountService.__Method_Unsubscribe, new UnaryServerMethod<SubscriptionUpdateRequest, NoData>(serviceImpl.Unsubscribe))
				.AddMethod<GetAccountStateRequest, GetAccountStateResponse>(AccountService.__Method_GetAccountState, new UnaryServerMethod<GetAccountStateRequest, GetAccountStateResponse>(serviceImpl.GetAccountState))
				.AddMethod<GetGameAccountStateRequest, GetGameAccountStateResponse>(AccountService.__Method_GetGameAccountState, new UnaryServerMethod<GetGameAccountStateRequest, GetGameAccountStateResponse>(serviceImpl.GetGameAccountState))
				.AddMethod<GetLicensesRequest, GetLicensesResponse>(AccountService.__Method_GetLicenses, new UnaryServerMethod<GetLicensesRequest, GetLicensesResponse>(serviceImpl.GetLicenses))
				.AddMethod<GetGameTimeRemainingInfoRequest, GetGameTimeRemainingInfoResponse>(AccountService.__Method_GetGameTimeRemainingInfo, new UnaryServerMethod<GetGameTimeRemainingInfoRequest, GetGameTimeRemainingInfoResponse>(serviceImpl.GetGameTimeRemainingInfo))
				.AddMethod<GetGameSessionInfoRequest, GetGameSessionInfoResponse>(AccountService.__Method_GetGameSessionInfo, new UnaryServerMethod<GetGameSessionInfoRequest, GetGameSessionInfoResponse>(serviceImpl.GetGameSessionInfo))
				.AddMethod<GetCAISInfoRequest, GetCAISInfoResponse>(AccountService.__Method_GetCAISInfo, new UnaryServerMethod<GetCAISInfoRequest, GetCAISInfoResponse>(serviceImpl.GetCAISInfo))
				.AddMethod<GetAuthorizedDataRequest, GetAuthorizedDataResponse>(AccountService.__Method_GetAuthorizedData, new UnaryServerMethod<GetAuthorizedDataRequest, GetAuthorizedDataResponse>(serviceImpl.GetAuthorizedData))
				.AddMethod<GetSignedAccountStateRequest, GetSignedAccountStateResponse>(AccountService.__Method_GetSignedAccountState, new UnaryServerMethod<GetSignedAccountStateRequest, GetSignedAccountStateResponse>(serviceImpl.GetSignedAccountState))
				.Build();
		}

		// Token: 0x0600A82F RID: 43055 RVA: 0x0028E5BC File Offset: 0x0028C7BC
		public static void BindService(ServiceBinderBase serviceBinder, AccountService.AccountServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<ResolveAccountRequest, ResolveAccountResponse>(AccountService.__Method_ResolveAccount, (serviceImpl == null) ? null : new UnaryServerMethod<ResolveAccountRequest, ResolveAccountResponse>(serviceImpl.ResolveAccount));
			serviceBinder.AddMethod<IsIgrAddressRequest, NoData>(AccountService.__Method_IsIgrAddress, (serviceImpl == null) ? null : new UnaryServerMethod<IsIgrAddressRequest, NoData>(serviceImpl.IsIgrAddress));
			serviceBinder.AddMethod<SubscriptionUpdateRequest, SubscriptionUpdateResponse>(AccountService.__Method_Subscribe, (serviceImpl == null) ? null : new UnaryServerMethod<SubscriptionUpdateRequest, SubscriptionUpdateResponse>(serviceImpl.Subscribe));
			serviceBinder.AddMethod<SubscriptionUpdateRequest, NoData>(AccountService.__Method_Unsubscribe, (serviceImpl == null) ? null : new UnaryServerMethod<SubscriptionUpdateRequest, NoData>(serviceImpl.Unsubscribe));
			serviceBinder.AddMethod<GetAccountStateRequest, GetAccountStateResponse>(AccountService.__Method_GetAccountState, (serviceImpl == null) ? null : new UnaryServerMethod<GetAccountStateRequest, GetAccountStateResponse>(serviceImpl.GetAccountState));
			serviceBinder.AddMethod<GetGameAccountStateRequest, GetGameAccountStateResponse>(AccountService.__Method_GetGameAccountState, (serviceImpl == null) ? null : new UnaryServerMethod<GetGameAccountStateRequest, GetGameAccountStateResponse>(serviceImpl.GetGameAccountState));
			serviceBinder.AddMethod<GetLicensesRequest, GetLicensesResponse>(AccountService.__Method_GetLicenses, (serviceImpl == null) ? null : new UnaryServerMethod<GetLicensesRequest, GetLicensesResponse>(serviceImpl.GetLicenses));
			serviceBinder.AddMethod<GetGameTimeRemainingInfoRequest, GetGameTimeRemainingInfoResponse>(AccountService.__Method_GetGameTimeRemainingInfo, (serviceImpl == null) ? null : new UnaryServerMethod<GetGameTimeRemainingInfoRequest, GetGameTimeRemainingInfoResponse>(serviceImpl.GetGameTimeRemainingInfo));
			serviceBinder.AddMethod<GetGameSessionInfoRequest, GetGameSessionInfoResponse>(AccountService.__Method_GetGameSessionInfo, (serviceImpl == null) ? null : new UnaryServerMethod<GetGameSessionInfoRequest, GetGameSessionInfoResponse>(serviceImpl.GetGameSessionInfo));
			serviceBinder.AddMethod<GetCAISInfoRequest, GetCAISInfoResponse>(AccountService.__Method_GetCAISInfo, (serviceImpl == null) ? null : new UnaryServerMethod<GetCAISInfoRequest, GetCAISInfoResponse>(serviceImpl.GetCAISInfo));
			serviceBinder.AddMethod<GetAuthorizedDataRequest, GetAuthorizedDataResponse>(AccountService.__Method_GetAuthorizedData, (serviceImpl == null) ? null : new UnaryServerMethod<GetAuthorizedDataRequest, GetAuthorizedDataResponse>(serviceImpl.GetAuthorizedData));
			serviceBinder.AddMethod<GetSignedAccountStateRequest, GetSignedAccountStateResponse>(AccountService.__Method_GetSignedAccountState, (serviceImpl == null) ? null : new UnaryServerMethod<GetSignedAccountStateRequest, GetSignedAccountStateResponse>(serviceImpl.GetSignedAccountState));
		}

		// Token: 0x04004B64 RID: 19300
		private static readonly string __ServiceName = "bgs.protocol.account.v1.AccountService";

		// Token: 0x04004B65 RID: 19301
		private static readonly Marshaller<ResolveAccountRequest> __Marshaller_bgs_protocol_account_v1_ResolveAccountRequest = Marshallers.Create<ResolveAccountRequest>(new Action<ResolveAccountRequest, SerializationContext>(AccountService.__Helper_SerializeMessage), (DeserializationContext context) => AccountService.__Helper_DeserializeMessage<ResolveAccountRequest>(context, ResolveAccountRequest.Parser));

		// Token: 0x04004B66 RID: 19302
		private static readonly Marshaller<ResolveAccountResponse> __Marshaller_bgs_protocol_account_v1_ResolveAccountResponse = Marshallers.Create<ResolveAccountResponse>(new Action<ResolveAccountResponse, SerializationContext>(AccountService.__Helper_SerializeMessage), (DeserializationContext context) => AccountService.__Helper_DeserializeMessage<ResolveAccountResponse>(context, ResolveAccountResponse.Parser));

		// Token: 0x04004B67 RID: 19303
		private static readonly Marshaller<IsIgrAddressRequest> __Marshaller_bgs_protocol_account_v1_IsIgrAddressRequest = Marshallers.Create<IsIgrAddressRequest>(new Action<IsIgrAddressRequest, SerializationContext>(AccountService.__Helper_SerializeMessage), (DeserializationContext context) => AccountService.__Helper_DeserializeMessage<IsIgrAddressRequest>(context, IsIgrAddressRequest.Parser));

		// Token: 0x04004B68 RID: 19304
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(AccountService.__Helper_SerializeMessage), (DeserializationContext context) => AccountService.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x04004B69 RID: 19305
		private static readonly Marshaller<SubscriptionUpdateRequest> __Marshaller_bgs_protocol_account_v1_SubscriptionUpdateRequest = Marshallers.Create<SubscriptionUpdateRequest>(new Action<SubscriptionUpdateRequest, SerializationContext>(AccountService.__Helper_SerializeMessage), (DeserializationContext context) => AccountService.__Helper_DeserializeMessage<SubscriptionUpdateRequest>(context, SubscriptionUpdateRequest.Parser));

		// Token: 0x04004B6A RID: 19306
		private static readonly Marshaller<SubscriptionUpdateResponse> __Marshaller_bgs_protocol_account_v1_SubscriptionUpdateResponse = Marshallers.Create<SubscriptionUpdateResponse>(new Action<SubscriptionUpdateResponse, SerializationContext>(AccountService.__Helper_SerializeMessage), (DeserializationContext context) => AccountService.__Helper_DeserializeMessage<SubscriptionUpdateResponse>(context, SubscriptionUpdateResponse.Parser));

		// Token: 0x04004B6B RID: 19307
		private static readonly Marshaller<GetAccountStateRequest> __Marshaller_bgs_protocol_account_v1_GetAccountStateRequest = Marshallers.Create<GetAccountStateRequest>(new Action<GetAccountStateRequest, SerializationContext>(AccountService.__Helper_SerializeMessage), (DeserializationContext context) => AccountService.__Helper_DeserializeMessage<GetAccountStateRequest>(context, GetAccountStateRequest.Parser));

		// Token: 0x04004B6C RID: 19308
		private static readonly Marshaller<GetAccountStateResponse> __Marshaller_bgs_protocol_account_v1_GetAccountStateResponse = Marshallers.Create<GetAccountStateResponse>(new Action<GetAccountStateResponse, SerializationContext>(AccountService.__Helper_SerializeMessage), (DeserializationContext context) => AccountService.__Helper_DeserializeMessage<GetAccountStateResponse>(context, GetAccountStateResponse.Parser));

		// Token: 0x04004B6D RID: 19309
		private static readonly Marshaller<GetGameAccountStateRequest> __Marshaller_bgs_protocol_account_v1_GetGameAccountStateRequest = Marshallers.Create<GetGameAccountStateRequest>(new Action<GetGameAccountStateRequest, SerializationContext>(AccountService.__Helper_SerializeMessage), (DeserializationContext context) => AccountService.__Helper_DeserializeMessage<GetGameAccountStateRequest>(context, GetGameAccountStateRequest.Parser));

		// Token: 0x04004B6E RID: 19310
		private static readonly Marshaller<GetGameAccountStateResponse> __Marshaller_bgs_protocol_account_v1_GetGameAccountStateResponse = Marshallers.Create<GetGameAccountStateResponse>(new Action<GetGameAccountStateResponse, SerializationContext>(AccountService.__Helper_SerializeMessage), (DeserializationContext context) => AccountService.__Helper_DeserializeMessage<GetGameAccountStateResponse>(context, GetGameAccountStateResponse.Parser));

		// Token: 0x04004B6F RID: 19311
		private static readonly Marshaller<GetLicensesRequest> __Marshaller_bgs_protocol_account_v1_GetLicensesRequest = Marshallers.Create<GetLicensesRequest>(new Action<GetLicensesRequest, SerializationContext>(AccountService.__Helper_SerializeMessage), (DeserializationContext context) => AccountService.__Helper_DeserializeMessage<GetLicensesRequest>(context, GetLicensesRequest.Parser));

		// Token: 0x04004B70 RID: 19312
		private static readonly Marshaller<GetLicensesResponse> __Marshaller_bgs_protocol_account_v1_GetLicensesResponse = Marshallers.Create<GetLicensesResponse>(new Action<GetLicensesResponse, SerializationContext>(AccountService.__Helper_SerializeMessage), (DeserializationContext context) => AccountService.__Helper_DeserializeMessage<GetLicensesResponse>(context, GetLicensesResponse.Parser));

		// Token: 0x04004B71 RID: 19313
		private static readonly Marshaller<GetGameTimeRemainingInfoRequest> __Marshaller_bgs_protocol_account_v1_GetGameTimeRemainingInfoRequest = Marshallers.Create<GetGameTimeRemainingInfoRequest>(new Action<GetGameTimeRemainingInfoRequest, SerializationContext>(AccountService.__Helper_SerializeMessage), (DeserializationContext context) => AccountService.__Helper_DeserializeMessage<GetGameTimeRemainingInfoRequest>(context, GetGameTimeRemainingInfoRequest.Parser));

		// Token: 0x04004B72 RID: 19314
		private static readonly Marshaller<GetGameTimeRemainingInfoResponse> __Marshaller_bgs_protocol_account_v1_GetGameTimeRemainingInfoResponse = Marshallers.Create<GetGameTimeRemainingInfoResponse>(new Action<GetGameTimeRemainingInfoResponse, SerializationContext>(AccountService.__Helper_SerializeMessage), (DeserializationContext context) => AccountService.__Helper_DeserializeMessage<GetGameTimeRemainingInfoResponse>(context, GetGameTimeRemainingInfoResponse.Parser));

		// Token: 0x04004B73 RID: 19315
		private static readonly Marshaller<GetGameSessionInfoRequest> __Marshaller_bgs_protocol_account_v1_GetGameSessionInfoRequest = Marshallers.Create<GetGameSessionInfoRequest>(new Action<GetGameSessionInfoRequest, SerializationContext>(AccountService.__Helper_SerializeMessage), (DeserializationContext context) => AccountService.__Helper_DeserializeMessage<GetGameSessionInfoRequest>(context, GetGameSessionInfoRequest.Parser));

		// Token: 0x04004B74 RID: 19316
		private static readonly Marshaller<GetGameSessionInfoResponse> __Marshaller_bgs_protocol_account_v1_GetGameSessionInfoResponse = Marshallers.Create<GetGameSessionInfoResponse>(new Action<GetGameSessionInfoResponse, SerializationContext>(AccountService.__Helper_SerializeMessage), (DeserializationContext context) => AccountService.__Helper_DeserializeMessage<GetGameSessionInfoResponse>(context, GetGameSessionInfoResponse.Parser));

		// Token: 0x04004B75 RID: 19317
		private static readonly Marshaller<GetCAISInfoRequest> __Marshaller_bgs_protocol_account_v1_GetCAISInfoRequest = Marshallers.Create<GetCAISInfoRequest>(new Action<GetCAISInfoRequest, SerializationContext>(AccountService.__Helper_SerializeMessage), (DeserializationContext context) => AccountService.__Helper_DeserializeMessage<GetCAISInfoRequest>(context, GetCAISInfoRequest.Parser));

		// Token: 0x04004B76 RID: 19318
		private static readonly Marshaller<GetCAISInfoResponse> __Marshaller_bgs_protocol_account_v1_GetCAISInfoResponse = Marshallers.Create<GetCAISInfoResponse>(new Action<GetCAISInfoResponse, SerializationContext>(AccountService.__Helper_SerializeMessage), (DeserializationContext context) => AccountService.__Helper_DeserializeMessage<GetCAISInfoResponse>(context, GetCAISInfoResponse.Parser));

		// Token: 0x04004B77 RID: 19319
		private static readonly Marshaller<GetAuthorizedDataRequest> __Marshaller_bgs_protocol_account_v1_GetAuthorizedDataRequest = Marshallers.Create<GetAuthorizedDataRequest>(new Action<GetAuthorizedDataRequest, SerializationContext>(AccountService.__Helper_SerializeMessage), (DeserializationContext context) => AccountService.__Helper_DeserializeMessage<GetAuthorizedDataRequest>(context, GetAuthorizedDataRequest.Parser));

		// Token: 0x04004B78 RID: 19320
		private static readonly Marshaller<GetAuthorizedDataResponse> __Marshaller_bgs_protocol_account_v1_GetAuthorizedDataResponse = Marshallers.Create<GetAuthorizedDataResponse>(new Action<GetAuthorizedDataResponse, SerializationContext>(AccountService.__Helper_SerializeMessage), (DeserializationContext context) => AccountService.__Helper_DeserializeMessage<GetAuthorizedDataResponse>(context, GetAuthorizedDataResponse.Parser));

		// Token: 0x04004B79 RID: 19321
		private static readonly Marshaller<GetSignedAccountStateRequest> __Marshaller_bgs_protocol_account_v1_GetSignedAccountStateRequest = Marshallers.Create<GetSignedAccountStateRequest>(new Action<GetSignedAccountStateRequest, SerializationContext>(AccountService.__Helper_SerializeMessage), (DeserializationContext context) => AccountService.__Helper_DeserializeMessage<GetSignedAccountStateRequest>(context, GetSignedAccountStateRequest.Parser));

		// Token: 0x04004B7A RID: 19322
		private static readonly Marshaller<GetSignedAccountStateResponse> __Marshaller_bgs_protocol_account_v1_GetSignedAccountStateResponse = Marshallers.Create<GetSignedAccountStateResponse>(new Action<GetSignedAccountStateResponse, SerializationContext>(AccountService.__Helper_SerializeMessage), (DeserializationContext context) => AccountService.__Helper_DeserializeMessage<GetSignedAccountStateResponse>(context, GetSignedAccountStateResponse.Parser));

		// Token: 0x04004B7B RID: 19323
		private static readonly Method<ResolveAccountRequest, ResolveAccountResponse> __Method_ResolveAccount = new Method<ResolveAccountRequest, ResolveAccountResponse>(0, AccountService.__ServiceName, "ResolveAccount", AccountService.__Marshaller_bgs_protocol_account_v1_ResolveAccountRequest, AccountService.__Marshaller_bgs_protocol_account_v1_ResolveAccountResponse);

		// Token: 0x04004B7C RID: 19324
		private static readonly Method<IsIgrAddressRequest, NoData> __Method_IsIgrAddress = new Method<IsIgrAddressRequest, NoData>(0, AccountService.__ServiceName, "IsIgrAddress", AccountService.__Marshaller_bgs_protocol_account_v1_IsIgrAddressRequest, AccountService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04004B7D RID: 19325
		private static readonly Method<SubscriptionUpdateRequest, SubscriptionUpdateResponse> __Method_Subscribe = new Method<SubscriptionUpdateRequest, SubscriptionUpdateResponse>(0, AccountService.__ServiceName, "Subscribe", AccountService.__Marshaller_bgs_protocol_account_v1_SubscriptionUpdateRequest, AccountService.__Marshaller_bgs_protocol_account_v1_SubscriptionUpdateResponse);

		// Token: 0x04004B7E RID: 19326
		private static readonly Method<SubscriptionUpdateRequest, NoData> __Method_Unsubscribe = new Method<SubscriptionUpdateRequest, NoData>(0, AccountService.__ServiceName, "Unsubscribe", AccountService.__Marshaller_bgs_protocol_account_v1_SubscriptionUpdateRequest, AccountService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04004B7F RID: 19327
		private static readonly Method<GetAccountStateRequest, GetAccountStateResponse> __Method_GetAccountState = new Method<GetAccountStateRequest, GetAccountStateResponse>(0, AccountService.__ServiceName, "GetAccountState", AccountService.__Marshaller_bgs_protocol_account_v1_GetAccountStateRequest, AccountService.__Marshaller_bgs_protocol_account_v1_GetAccountStateResponse);

		// Token: 0x04004B80 RID: 19328
		private static readonly Method<GetGameAccountStateRequest, GetGameAccountStateResponse> __Method_GetGameAccountState = new Method<GetGameAccountStateRequest, GetGameAccountStateResponse>(0, AccountService.__ServiceName, "GetGameAccountState", AccountService.__Marshaller_bgs_protocol_account_v1_GetGameAccountStateRequest, AccountService.__Marshaller_bgs_protocol_account_v1_GetGameAccountStateResponse);

		// Token: 0x04004B81 RID: 19329
		private static readonly Method<GetLicensesRequest, GetLicensesResponse> __Method_GetLicenses = new Method<GetLicensesRequest, GetLicensesResponse>(0, AccountService.__ServiceName, "GetLicenses", AccountService.__Marshaller_bgs_protocol_account_v1_GetLicensesRequest, AccountService.__Marshaller_bgs_protocol_account_v1_GetLicensesResponse);

		// Token: 0x04004B82 RID: 19330
		private static readonly Method<GetGameTimeRemainingInfoRequest, GetGameTimeRemainingInfoResponse> __Method_GetGameTimeRemainingInfo = new Method<GetGameTimeRemainingInfoRequest, GetGameTimeRemainingInfoResponse>(0, AccountService.__ServiceName, "GetGameTimeRemainingInfo", AccountService.__Marshaller_bgs_protocol_account_v1_GetGameTimeRemainingInfoRequest, AccountService.__Marshaller_bgs_protocol_account_v1_GetGameTimeRemainingInfoResponse);

		// Token: 0x04004B83 RID: 19331
		private static readonly Method<GetGameSessionInfoRequest, GetGameSessionInfoResponse> __Method_GetGameSessionInfo = new Method<GetGameSessionInfoRequest, GetGameSessionInfoResponse>(0, AccountService.__ServiceName, "GetGameSessionInfo", AccountService.__Marshaller_bgs_protocol_account_v1_GetGameSessionInfoRequest, AccountService.__Marshaller_bgs_protocol_account_v1_GetGameSessionInfoResponse);

		// Token: 0x04004B84 RID: 19332
		private static readonly Method<GetCAISInfoRequest, GetCAISInfoResponse> __Method_GetCAISInfo = new Method<GetCAISInfoRequest, GetCAISInfoResponse>(0, AccountService.__ServiceName, "GetCAISInfo", AccountService.__Marshaller_bgs_protocol_account_v1_GetCAISInfoRequest, AccountService.__Marshaller_bgs_protocol_account_v1_GetCAISInfoResponse);

		// Token: 0x04004B85 RID: 19333
		private static readonly Method<GetAuthorizedDataRequest, GetAuthorizedDataResponse> __Method_GetAuthorizedData = new Method<GetAuthorizedDataRequest, GetAuthorizedDataResponse>(0, AccountService.__ServiceName, "GetAuthorizedData", AccountService.__Marshaller_bgs_protocol_account_v1_GetAuthorizedDataRequest, AccountService.__Marshaller_bgs_protocol_account_v1_GetAuthorizedDataResponse);

		// Token: 0x04004B86 RID: 19334
		private static readonly Method<GetSignedAccountStateRequest, GetSignedAccountStateResponse> __Method_GetSignedAccountState = new Method<GetSignedAccountStateRequest, GetSignedAccountStateResponse>(0, AccountService.__ServiceName, "GetSignedAccountState", AccountService.__Marshaller_bgs_protocol_account_v1_GetSignedAccountStateRequest, AccountService.__Marshaller_bgs_protocol_account_v1_GetSignedAccountStateResponse);

		// Token: 0x0200123B RID: 4667
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x0400995E RID: 39262
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x0200123C RID: 4668
		[BindServiceMethod(typeof(AccountService), "BindService")]
		public abstract class AccountServiceBase
		{
			// Token: 0x0600DB1C RID: 56092 RVA: 0x004BCAC6 File Offset: 0x004BACC6
			public virtual Task<ResolveAccountResponse> ResolveAccount(ResolveAccountRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DB1D RID: 56093 RVA: 0x004BCADA File Offset: 0x004BACDA
			public virtual Task<NoData> IsIgrAddress(IsIgrAddressRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DB1E RID: 56094 RVA: 0x004BCAEE File Offset: 0x004BACEE
			public virtual Task<SubscriptionUpdateResponse> Subscribe(SubscriptionUpdateRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DB1F RID: 56095 RVA: 0x004BCB02 File Offset: 0x004BAD02
			public virtual Task<NoData> Unsubscribe(SubscriptionUpdateRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DB20 RID: 56096 RVA: 0x004BCB16 File Offset: 0x004BAD16
			public virtual Task<GetAccountStateResponse> GetAccountState(GetAccountStateRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DB21 RID: 56097 RVA: 0x004BCB2A File Offset: 0x004BAD2A
			public virtual Task<GetGameAccountStateResponse> GetGameAccountState(GetGameAccountStateRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DB22 RID: 56098 RVA: 0x004BCB3E File Offset: 0x004BAD3E
			public virtual Task<GetLicensesResponse> GetLicenses(GetLicensesRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DB23 RID: 56099 RVA: 0x004BCB52 File Offset: 0x004BAD52
			public virtual Task<GetGameTimeRemainingInfoResponse> GetGameTimeRemainingInfo(GetGameTimeRemainingInfoRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DB24 RID: 56100 RVA: 0x004BCB66 File Offset: 0x004BAD66
			public virtual Task<GetGameSessionInfoResponse> GetGameSessionInfo(GetGameSessionInfoRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DB25 RID: 56101 RVA: 0x004BCB7A File Offset: 0x004BAD7A
			public virtual Task<GetCAISInfoResponse> GetCAISInfo(GetCAISInfoRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DB26 RID: 56102 RVA: 0x004BCB8E File Offset: 0x004BAD8E
			public virtual Task<GetAuthorizedDataResponse> GetAuthorizedData(GetAuthorizedDataRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DB27 RID: 56103 RVA: 0x004BCBA2 File Offset: 0x004BADA2
			public virtual Task<GetSignedAccountStateResponse> GetSignedAccountState(GetSignedAccountStateRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x0200123D RID: 4669
		public class AccountServiceClient : ClientBase<AccountService.AccountServiceClient>
		{
			// Token: 0x0600DB29 RID: 56105 RVA: 0x004BCBBF File Offset: 0x004BADBF
			public AccountServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600DB2A RID: 56106 RVA: 0x004BCBCA File Offset: 0x004BADCA
			public AccountServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600DB2B RID: 56107 RVA: 0x004BCBD5 File Offset: 0x004BADD5
			protected AccountServiceClient()
			{
			}

			// Token: 0x0600DB2C RID: 56108 RVA: 0x004BCBDF File Offset: 0x004BADDF
			protected AccountServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600DB2D RID: 56109 RVA: 0x004BCBEC File Offset: 0x004BADEC
			public virtual ResolveAccountResponse ResolveAccount(ResolveAccountRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ResolveAccount(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DB2E RID: 56110 RVA: 0x004BCC14 File Offset: 0x004BAE14
			public virtual ResolveAccountResponse ResolveAccount(ResolveAccountRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ResolveAccountRequest, ResolveAccountResponse>(AccountService.__Method_ResolveAccount, null, options, request);
			}

			// Token: 0x0600DB2F RID: 56111 RVA: 0x004BCC3C File Offset: 0x004BAE3C
			public virtual AsyncUnaryCall<ResolveAccountResponse> ResolveAccountAsync(ResolveAccountRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ResolveAccountAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DB30 RID: 56112 RVA: 0x004BCC64 File Offset: 0x004BAE64
			public virtual AsyncUnaryCall<ResolveAccountResponse> ResolveAccountAsync(ResolveAccountRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ResolveAccountRequest, ResolveAccountResponse>(AccountService.__Method_ResolveAccount, null, options, request);
			}

			// Token: 0x0600DB31 RID: 56113 RVA: 0x004BCC8C File Offset: 0x004BAE8C
			public virtual NoData IsIgrAddress(IsIgrAddressRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.IsIgrAddress(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DB32 RID: 56114 RVA: 0x004BCCB4 File Offset: 0x004BAEB4
			public virtual NoData IsIgrAddress(IsIgrAddressRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<IsIgrAddressRequest, NoData>(AccountService.__Method_IsIgrAddress, null, options, request);
			}

			// Token: 0x0600DB33 RID: 56115 RVA: 0x004BCCDC File Offset: 0x004BAEDC
			public virtual AsyncUnaryCall<NoData> IsIgrAddressAsync(IsIgrAddressRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.IsIgrAddressAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DB34 RID: 56116 RVA: 0x004BCD04 File Offset: 0x004BAF04
			public virtual AsyncUnaryCall<NoData> IsIgrAddressAsync(IsIgrAddressRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<IsIgrAddressRequest, NoData>(AccountService.__Method_IsIgrAddress, null, options, request);
			}

			// Token: 0x0600DB35 RID: 56117 RVA: 0x004BCD2C File Offset: 0x004BAF2C
			public virtual SubscriptionUpdateResponse Subscribe(SubscriptionUpdateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Subscribe(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DB36 RID: 56118 RVA: 0x004BCD54 File Offset: 0x004BAF54
			public virtual SubscriptionUpdateResponse Subscribe(SubscriptionUpdateRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SubscriptionUpdateRequest, SubscriptionUpdateResponse>(AccountService.__Method_Subscribe, null, options, request);
			}

			// Token: 0x0600DB37 RID: 56119 RVA: 0x004BCD7C File Offset: 0x004BAF7C
			public virtual AsyncUnaryCall<SubscriptionUpdateResponse> SubscribeAsync(SubscriptionUpdateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SubscribeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DB38 RID: 56120 RVA: 0x004BCDA4 File Offset: 0x004BAFA4
			public virtual AsyncUnaryCall<SubscriptionUpdateResponse> SubscribeAsync(SubscriptionUpdateRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SubscriptionUpdateRequest, SubscriptionUpdateResponse>(AccountService.__Method_Subscribe, null, options, request);
			}

			// Token: 0x0600DB39 RID: 56121 RVA: 0x004BCDCC File Offset: 0x004BAFCC
			public virtual NoData Unsubscribe(SubscriptionUpdateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Unsubscribe(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DB3A RID: 56122 RVA: 0x004BCDF4 File Offset: 0x004BAFF4
			public virtual NoData Unsubscribe(SubscriptionUpdateRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SubscriptionUpdateRequest, NoData>(AccountService.__Method_Unsubscribe, null, options, request);
			}

			// Token: 0x0600DB3B RID: 56123 RVA: 0x004BCE1C File Offset: 0x004BB01C
			public virtual AsyncUnaryCall<NoData> UnsubscribeAsync(SubscriptionUpdateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UnsubscribeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DB3C RID: 56124 RVA: 0x004BCE44 File Offset: 0x004BB044
			public virtual AsyncUnaryCall<NoData> UnsubscribeAsync(SubscriptionUpdateRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SubscriptionUpdateRequest, NoData>(AccountService.__Method_Unsubscribe, null, options, request);
			}

			// Token: 0x0600DB3D RID: 56125 RVA: 0x004BCE6C File Offset: 0x004BB06C
			public virtual GetAccountStateResponse GetAccountState(GetAccountStateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetAccountState(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DB3E RID: 56126 RVA: 0x004BCE94 File Offset: 0x004BB094
			public virtual GetAccountStateResponse GetAccountState(GetAccountStateRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetAccountStateRequest, GetAccountStateResponse>(AccountService.__Method_GetAccountState, null, options, request);
			}

			// Token: 0x0600DB3F RID: 56127 RVA: 0x004BCEBC File Offset: 0x004BB0BC
			public virtual AsyncUnaryCall<GetAccountStateResponse> GetAccountStateAsync(GetAccountStateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetAccountStateAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DB40 RID: 56128 RVA: 0x004BCEE4 File Offset: 0x004BB0E4
			public virtual AsyncUnaryCall<GetAccountStateResponse> GetAccountStateAsync(GetAccountStateRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetAccountStateRequest, GetAccountStateResponse>(AccountService.__Method_GetAccountState, null, options, request);
			}

			// Token: 0x0600DB41 RID: 56129 RVA: 0x004BCF0C File Offset: 0x004BB10C
			public virtual GetGameAccountStateResponse GetGameAccountState(GetGameAccountStateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetGameAccountState(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DB42 RID: 56130 RVA: 0x004BCF34 File Offset: 0x004BB134
			public virtual GetGameAccountStateResponse GetGameAccountState(GetGameAccountStateRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetGameAccountStateRequest, GetGameAccountStateResponse>(AccountService.__Method_GetGameAccountState, null, options, request);
			}

			// Token: 0x0600DB43 RID: 56131 RVA: 0x004BCF5C File Offset: 0x004BB15C
			public virtual AsyncUnaryCall<GetGameAccountStateResponse> GetGameAccountStateAsync(GetGameAccountStateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetGameAccountStateAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DB44 RID: 56132 RVA: 0x004BCF84 File Offset: 0x004BB184
			public virtual AsyncUnaryCall<GetGameAccountStateResponse> GetGameAccountStateAsync(GetGameAccountStateRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetGameAccountStateRequest, GetGameAccountStateResponse>(AccountService.__Method_GetGameAccountState, null, options, request);
			}

			// Token: 0x0600DB45 RID: 56133 RVA: 0x004BCFAC File Offset: 0x004BB1AC
			public virtual GetLicensesResponse GetLicenses(GetLicensesRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetLicenses(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DB46 RID: 56134 RVA: 0x004BCFD4 File Offset: 0x004BB1D4
			public virtual GetLicensesResponse GetLicenses(GetLicensesRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetLicensesRequest, GetLicensesResponse>(AccountService.__Method_GetLicenses, null, options, request);
			}

			// Token: 0x0600DB47 RID: 56135 RVA: 0x004BCFFC File Offset: 0x004BB1FC
			public virtual AsyncUnaryCall<GetLicensesResponse> GetLicensesAsync(GetLicensesRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetLicensesAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DB48 RID: 56136 RVA: 0x004BD024 File Offset: 0x004BB224
			public virtual AsyncUnaryCall<GetLicensesResponse> GetLicensesAsync(GetLicensesRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetLicensesRequest, GetLicensesResponse>(AccountService.__Method_GetLicenses, null, options, request);
			}

			// Token: 0x0600DB49 RID: 56137 RVA: 0x004BD04C File Offset: 0x004BB24C
			public virtual GetGameTimeRemainingInfoResponse GetGameTimeRemainingInfo(GetGameTimeRemainingInfoRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetGameTimeRemainingInfo(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DB4A RID: 56138 RVA: 0x004BD074 File Offset: 0x004BB274
			public virtual GetGameTimeRemainingInfoResponse GetGameTimeRemainingInfo(GetGameTimeRemainingInfoRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetGameTimeRemainingInfoRequest, GetGameTimeRemainingInfoResponse>(AccountService.__Method_GetGameTimeRemainingInfo, null, options, request);
			}

			// Token: 0x0600DB4B RID: 56139 RVA: 0x004BD09C File Offset: 0x004BB29C
			public virtual AsyncUnaryCall<GetGameTimeRemainingInfoResponse> GetGameTimeRemainingInfoAsync(GetGameTimeRemainingInfoRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetGameTimeRemainingInfoAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DB4C RID: 56140 RVA: 0x004BD0C4 File Offset: 0x004BB2C4
			public virtual AsyncUnaryCall<GetGameTimeRemainingInfoResponse> GetGameTimeRemainingInfoAsync(GetGameTimeRemainingInfoRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetGameTimeRemainingInfoRequest, GetGameTimeRemainingInfoResponse>(AccountService.__Method_GetGameTimeRemainingInfo, null, options, request);
			}

			// Token: 0x0600DB4D RID: 56141 RVA: 0x004BD0EC File Offset: 0x004BB2EC
			public virtual GetGameSessionInfoResponse GetGameSessionInfo(GetGameSessionInfoRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetGameSessionInfo(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DB4E RID: 56142 RVA: 0x004BD114 File Offset: 0x004BB314
			public virtual GetGameSessionInfoResponse GetGameSessionInfo(GetGameSessionInfoRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetGameSessionInfoRequest, GetGameSessionInfoResponse>(AccountService.__Method_GetGameSessionInfo, null, options, request);
			}

			// Token: 0x0600DB4F RID: 56143 RVA: 0x004BD13C File Offset: 0x004BB33C
			public virtual AsyncUnaryCall<GetGameSessionInfoResponse> GetGameSessionInfoAsync(GetGameSessionInfoRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetGameSessionInfoAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DB50 RID: 56144 RVA: 0x004BD164 File Offset: 0x004BB364
			public virtual AsyncUnaryCall<GetGameSessionInfoResponse> GetGameSessionInfoAsync(GetGameSessionInfoRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetGameSessionInfoRequest, GetGameSessionInfoResponse>(AccountService.__Method_GetGameSessionInfo, null, options, request);
			}

			// Token: 0x0600DB51 RID: 56145 RVA: 0x004BD18C File Offset: 0x004BB38C
			public virtual GetCAISInfoResponse GetCAISInfo(GetCAISInfoRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetCAISInfo(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DB52 RID: 56146 RVA: 0x004BD1B4 File Offset: 0x004BB3B4
			public virtual GetCAISInfoResponse GetCAISInfo(GetCAISInfoRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetCAISInfoRequest, GetCAISInfoResponse>(AccountService.__Method_GetCAISInfo, null, options, request);
			}

			// Token: 0x0600DB53 RID: 56147 RVA: 0x004BD1DC File Offset: 0x004BB3DC
			public virtual AsyncUnaryCall<GetCAISInfoResponse> GetCAISInfoAsync(GetCAISInfoRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetCAISInfoAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DB54 RID: 56148 RVA: 0x004BD204 File Offset: 0x004BB404
			public virtual AsyncUnaryCall<GetCAISInfoResponse> GetCAISInfoAsync(GetCAISInfoRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetCAISInfoRequest, GetCAISInfoResponse>(AccountService.__Method_GetCAISInfo, null, options, request);
			}

			// Token: 0x0600DB55 RID: 56149 RVA: 0x004BD22C File Offset: 0x004BB42C
			public virtual GetAuthorizedDataResponse GetAuthorizedData(GetAuthorizedDataRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetAuthorizedData(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DB56 RID: 56150 RVA: 0x004BD254 File Offset: 0x004BB454
			public virtual GetAuthorizedDataResponse GetAuthorizedData(GetAuthorizedDataRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetAuthorizedDataRequest, GetAuthorizedDataResponse>(AccountService.__Method_GetAuthorizedData, null, options, request);
			}

			// Token: 0x0600DB57 RID: 56151 RVA: 0x004BD27C File Offset: 0x004BB47C
			public virtual AsyncUnaryCall<GetAuthorizedDataResponse> GetAuthorizedDataAsync(GetAuthorizedDataRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetAuthorizedDataAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DB58 RID: 56152 RVA: 0x004BD2A4 File Offset: 0x004BB4A4
			public virtual AsyncUnaryCall<GetAuthorizedDataResponse> GetAuthorizedDataAsync(GetAuthorizedDataRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetAuthorizedDataRequest, GetAuthorizedDataResponse>(AccountService.__Method_GetAuthorizedData, null, options, request);
			}

			// Token: 0x0600DB59 RID: 56153 RVA: 0x004BD2CC File Offset: 0x004BB4CC
			public virtual GetSignedAccountStateResponse GetSignedAccountState(GetSignedAccountStateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetSignedAccountState(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DB5A RID: 56154 RVA: 0x004BD2F4 File Offset: 0x004BB4F4
			public virtual GetSignedAccountStateResponse GetSignedAccountState(GetSignedAccountStateRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetSignedAccountStateRequest, GetSignedAccountStateResponse>(AccountService.__Method_GetSignedAccountState, null, options, request);
			}

			// Token: 0x0600DB5B RID: 56155 RVA: 0x004BD31C File Offset: 0x004BB51C
			public virtual AsyncUnaryCall<GetSignedAccountStateResponse> GetSignedAccountStateAsync(GetSignedAccountStateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetSignedAccountStateAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DB5C RID: 56156 RVA: 0x004BD344 File Offset: 0x004BB544
			public virtual AsyncUnaryCall<GetSignedAccountStateResponse> GetSignedAccountStateAsync(GetSignedAccountStateRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetSignedAccountStateRequest, GetSignedAccountStateResponse>(AccountService.__Method_GetSignedAccountState, null, options, request);
			}

			// Token: 0x0600DB5D RID: 56157 RVA: 0x004BD36C File Offset: 0x004BB56C
			protected override AccountService.AccountServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new AccountService.AccountServiceClient(configuration);
			}
		}
	}
}
