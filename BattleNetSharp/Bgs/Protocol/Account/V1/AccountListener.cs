using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x0200072C RID: 1836
	public static class AccountListener
	{
		// Token: 0x0600A831 RID: 43057 RVA: 0x0028EC10 File Offset: 0x0028CE10
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

		// Token: 0x0600A832 RID: 43058 RVA: 0x0028EC5C File Offset: 0x0028CE5C
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = AccountListener.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x170033DB RID: 13275
		// (get) Token: 0x0600A833 RID: 43059 RVA: 0x0028EC94 File Offset: 0x0028CE94
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.Services[1];
			}
		}

		// Token: 0x0600A834 RID: 43060 RVA: 0x0028ECB8 File Offset: 0x0028CEB8
		public static ServerServiceDefinition BindService(AccountListener.AccountListenerBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<AccountStateNotification, NO_RESPONSE>(AccountListener.__Method_OnAccountStateUpdated, new UnaryServerMethod<AccountStateNotification, NO_RESPONSE>(serviceImpl.OnAccountStateUpdated)).AddMethod<GameAccountStateNotification, NO_RESPONSE>(AccountListener.__Method_OnGameAccountStateUpdated, new UnaryServerMethod<GameAccountStateNotification, NO_RESPONSE>(serviceImpl.OnGameAccountStateUpdated))
				.AddMethod<GameAccountNotification, NO_RESPONSE>(AccountListener.__Method_OnGameAccountsUpdated, new UnaryServerMethod<GameAccountNotification, NO_RESPONSE>(serviceImpl.OnGameAccountsUpdated))
				.AddMethod<GameAccountSessionNotification, NO_RESPONSE>(AccountListener.__Method_OnGameSessionUpdated, new UnaryServerMethod<GameAccountSessionNotification, NO_RESPONSE>(serviceImpl.OnGameSessionUpdated))
				.Build();
		}

		// Token: 0x0600A835 RID: 43061 RVA: 0x0028ED30 File Offset: 0x0028CF30
		public static void BindService(ServiceBinderBase serviceBinder, AccountListener.AccountListenerBase serviceImpl)
		{
			serviceBinder.AddMethod<AccountStateNotification, NO_RESPONSE>(AccountListener.__Method_OnAccountStateUpdated, (serviceImpl == null) ? null : new UnaryServerMethod<AccountStateNotification, NO_RESPONSE>(serviceImpl.OnAccountStateUpdated));
			serviceBinder.AddMethod<GameAccountStateNotification, NO_RESPONSE>(AccountListener.__Method_OnGameAccountStateUpdated, (serviceImpl == null) ? null : new UnaryServerMethod<GameAccountStateNotification, NO_RESPONSE>(serviceImpl.OnGameAccountStateUpdated));
			serviceBinder.AddMethod<GameAccountNotification, NO_RESPONSE>(AccountListener.__Method_OnGameAccountsUpdated, (serviceImpl == null) ? null : new UnaryServerMethod<GameAccountNotification, NO_RESPONSE>(serviceImpl.OnGameAccountsUpdated));
			serviceBinder.AddMethod<GameAccountSessionNotification, NO_RESPONSE>(AccountListener.__Method_OnGameSessionUpdated, (serviceImpl == null) ? null : new UnaryServerMethod<GameAccountSessionNotification, NO_RESPONSE>(serviceImpl.OnGameSessionUpdated));
		}

		// Token: 0x04004B87 RID: 19335
		private static readonly string __ServiceName = "bgs.protocol.account.v1.AccountListener";

		// Token: 0x04004B88 RID: 19336
		private static readonly Marshaller<AccountStateNotification> __Marshaller_bgs_protocol_account_v1_AccountStateNotification = Marshallers.Create<AccountStateNotification>(new Action<AccountStateNotification, SerializationContext>(AccountListener.__Helper_SerializeMessage), (DeserializationContext context) => AccountListener.__Helper_DeserializeMessage<AccountStateNotification>(context, AccountStateNotification.Parser));

		// Token: 0x04004B89 RID: 19337
		private static readonly Marshaller<NO_RESPONSE> __Marshaller_bgs_protocol_NO_RESPONSE = Marshallers.Create<NO_RESPONSE>(new Action<NO_RESPONSE, SerializationContext>(AccountListener.__Helper_SerializeMessage), (DeserializationContext context) => AccountListener.__Helper_DeserializeMessage<NO_RESPONSE>(context, NO_RESPONSE.Parser));

		// Token: 0x04004B8A RID: 19338
		private static readonly Marshaller<GameAccountStateNotification> __Marshaller_bgs_protocol_account_v1_GameAccountStateNotification = Marshallers.Create<GameAccountStateNotification>(new Action<GameAccountStateNotification, SerializationContext>(AccountListener.__Helper_SerializeMessage), (DeserializationContext context) => AccountListener.__Helper_DeserializeMessage<GameAccountStateNotification>(context, GameAccountStateNotification.Parser));

		// Token: 0x04004B8B RID: 19339
		private static readonly Marshaller<GameAccountNotification> __Marshaller_bgs_protocol_account_v1_GameAccountNotification = Marshallers.Create<GameAccountNotification>(new Action<GameAccountNotification, SerializationContext>(AccountListener.__Helper_SerializeMessage), (DeserializationContext context) => AccountListener.__Helper_DeserializeMessage<GameAccountNotification>(context, GameAccountNotification.Parser));

		// Token: 0x04004B8C RID: 19340
		private static readonly Marshaller<GameAccountSessionNotification> __Marshaller_bgs_protocol_account_v1_GameAccountSessionNotification = Marshallers.Create<GameAccountSessionNotification>(new Action<GameAccountSessionNotification, SerializationContext>(AccountListener.__Helper_SerializeMessage), (DeserializationContext context) => AccountListener.__Helper_DeserializeMessage<GameAccountSessionNotification>(context, GameAccountSessionNotification.Parser));

		// Token: 0x04004B8D RID: 19341
		private static readonly Method<AccountStateNotification, NO_RESPONSE> __Method_OnAccountStateUpdated = new Method<AccountStateNotification, NO_RESPONSE>(0, AccountListener.__ServiceName, "OnAccountStateUpdated", AccountListener.__Marshaller_bgs_protocol_account_v1_AccountStateNotification, AccountListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04004B8E RID: 19342
		private static readonly Method<GameAccountStateNotification, NO_RESPONSE> __Method_OnGameAccountStateUpdated = new Method<GameAccountStateNotification, NO_RESPONSE>(0, AccountListener.__ServiceName, "OnGameAccountStateUpdated", AccountListener.__Marshaller_bgs_protocol_account_v1_GameAccountStateNotification, AccountListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04004B8F RID: 19343
		private static readonly Method<GameAccountNotification, NO_RESPONSE> __Method_OnGameAccountsUpdated = new Method<GameAccountNotification, NO_RESPONSE>(0, AccountListener.__ServiceName, "OnGameAccountsUpdated", AccountListener.__Marshaller_bgs_protocol_account_v1_GameAccountNotification, AccountListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04004B90 RID: 19344
		private static readonly Method<GameAccountSessionNotification, NO_RESPONSE> __Method_OnGameSessionUpdated = new Method<GameAccountSessionNotification, NO_RESPONSE>(0, AccountListener.__ServiceName, "OnGameSessionUpdated", AccountListener.__Marshaller_bgs_protocol_account_v1_GameAccountSessionNotification, AccountListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x0200123F RID: 4671
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x04009960 RID: 39264
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02001240 RID: 4672
		[BindServiceMethod(typeof(AccountListener), "BindService")]
		public abstract class AccountListenerBase
		{
			// Token: 0x0600DB77 RID: 56183 RVA: 0x004BD4DC File Offset: 0x004BB6DC
			public virtual Task<NO_RESPONSE> OnAccountStateUpdated(AccountStateNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600DB78 RID: 56184 RVA: 0x004BD4F0 File Offset: 0x004BB6F0
			public virtual Task<NO_RESPONSE> OnGameAccountStateUpdated(GameAccountStateNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600DB79 RID: 56185 RVA: 0x004BD504 File Offset: 0x004BB704
			public virtual Task<NO_RESPONSE> OnGameAccountsUpdated(GameAccountNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600DB7A RID: 56186 RVA: 0x004BD518 File Offset: 0x004BB718
			public virtual Task<NO_RESPONSE> OnGameSessionUpdated(GameAccountSessionNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x02001241 RID: 4673
		public class AccountListenerClient : ClientBase<AccountListener.AccountListenerClient>
		{
			// Token: 0x0600DB7C RID: 56188 RVA: 0x004BD535 File Offset: 0x004BB735
			public AccountListenerClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600DB7D RID: 56189 RVA: 0x004BD540 File Offset: 0x004BB740
			public AccountListenerClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600DB7E RID: 56190 RVA: 0x004BD54B File Offset: 0x004BB74B
			protected AccountListenerClient()
			{
			}

			// Token: 0x0600DB7F RID: 56191 RVA: 0x004BD555 File Offset: 0x004BB755
			protected AccountListenerClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600DB80 RID: 56192 RVA: 0x004BD560 File Offset: 0x004BB760
			public virtual NO_RESPONSE OnAccountStateUpdated(AccountStateNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnAccountStateUpdated(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DB81 RID: 56193 RVA: 0x004BD588 File Offset: 0x004BB788
			public virtual NO_RESPONSE OnAccountStateUpdated(AccountStateNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<AccountStateNotification, NO_RESPONSE>(AccountListener.__Method_OnAccountStateUpdated, null, options, request);
			}

			// Token: 0x0600DB82 RID: 56194 RVA: 0x004BD5B0 File Offset: 0x004BB7B0
			public virtual AsyncUnaryCall<NO_RESPONSE> OnAccountStateUpdatedAsync(AccountStateNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnAccountStateUpdatedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DB83 RID: 56195 RVA: 0x004BD5D8 File Offset: 0x004BB7D8
			public virtual AsyncUnaryCall<NO_RESPONSE> OnAccountStateUpdatedAsync(AccountStateNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<AccountStateNotification, NO_RESPONSE>(AccountListener.__Method_OnAccountStateUpdated, null, options, request);
			}

			// Token: 0x0600DB84 RID: 56196 RVA: 0x004BD600 File Offset: 0x004BB800
			public virtual NO_RESPONSE OnGameAccountStateUpdated(GameAccountStateNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnGameAccountStateUpdated(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DB85 RID: 56197 RVA: 0x004BD628 File Offset: 0x004BB828
			public virtual NO_RESPONSE OnGameAccountStateUpdated(GameAccountStateNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GameAccountStateNotification, NO_RESPONSE>(AccountListener.__Method_OnGameAccountStateUpdated, null, options, request);
			}

			// Token: 0x0600DB86 RID: 56198 RVA: 0x004BD650 File Offset: 0x004BB850
			public virtual AsyncUnaryCall<NO_RESPONSE> OnGameAccountStateUpdatedAsync(GameAccountStateNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnGameAccountStateUpdatedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DB87 RID: 56199 RVA: 0x004BD678 File Offset: 0x004BB878
			public virtual AsyncUnaryCall<NO_RESPONSE> OnGameAccountStateUpdatedAsync(GameAccountStateNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GameAccountStateNotification, NO_RESPONSE>(AccountListener.__Method_OnGameAccountStateUpdated, null, options, request);
			}

			// Token: 0x0600DB88 RID: 56200 RVA: 0x004BD6A0 File Offset: 0x004BB8A0
			public virtual NO_RESPONSE OnGameAccountsUpdated(GameAccountNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnGameAccountsUpdated(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DB89 RID: 56201 RVA: 0x004BD6C8 File Offset: 0x004BB8C8
			public virtual NO_RESPONSE OnGameAccountsUpdated(GameAccountNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GameAccountNotification, NO_RESPONSE>(AccountListener.__Method_OnGameAccountsUpdated, null, options, request);
			}

			// Token: 0x0600DB8A RID: 56202 RVA: 0x004BD6F0 File Offset: 0x004BB8F0
			public virtual AsyncUnaryCall<NO_RESPONSE> OnGameAccountsUpdatedAsync(GameAccountNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnGameAccountsUpdatedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DB8B RID: 56203 RVA: 0x004BD718 File Offset: 0x004BB918
			public virtual AsyncUnaryCall<NO_RESPONSE> OnGameAccountsUpdatedAsync(GameAccountNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GameAccountNotification, NO_RESPONSE>(AccountListener.__Method_OnGameAccountsUpdated, null, options, request);
			}

			// Token: 0x0600DB8C RID: 56204 RVA: 0x004BD740 File Offset: 0x004BB940
			public virtual NO_RESPONSE OnGameSessionUpdated(GameAccountSessionNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnGameSessionUpdated(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DB8D RID: 56205 RVA: 0x004BD768 File Offset: 0x004BB968
			public virtual NO_RESPONSE OnGameSessionUpdated(GameAccountSessionNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GameAccountSessionNotification, NO_RESPONSE>(AccountListener.__Method_OnGameSessionUpdated, null, options, request);
			}

			// Token: 0x0600DB8E RID: 56206 RVA: 0x004BD790 File Offset: 0x004BB990
			public virtual AsyncUnaryCall<NO_RESPONSE> OnGameSessionUpdatedAsync(GameAccountSessionNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnGameSessionUpdatedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DB8F RID: 56207 RVA: 0x004BD7B8 File Offset: 0x004BB9B8
			public virtual AsyncUnaryCall<NO_RESPONSE> OnGameSessionUpdatedAsync(GameAccountSessionNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GameAccountSessionNotification, NO_RESPONSE>(AccountListener.__Method_OnGameSessionUpdated, null, options, request);
			}

			// Token: 0x0600DB90 RID: 56208 RVA: 0x004BD7E0 File Offset: 0x004BB9E0
			protected override AccountListener.AccountListenerClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new AccountListener.AccountListenerClient(configuration);
			}
		}
	}
}
