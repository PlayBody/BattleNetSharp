using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Authentication.V2.Client
{
	// Token: 0x0200061F RID: 1567
	public static class AuthenticationListener
	{
		// Token: 0x0600928C RID: 37516 RVA: 0x0023805C File Offset: 0x0023625C
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

		// Token: 0x0600928D RID: 37517 RVA: 0x002380A8 File Offset: 0x002362A8
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = AuthenticationListener.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17002DC5 RID: 11717
		// (get) Token: 0x0600928E RID: 37518 RVA: 0x002380E0 File Offset: 0x002362E0
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return AuthenticationListenerReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x0600928F RID: 37519 RVA: 0x00238104 File Offset: 0x00236304
		public static ServerServiceDefinition BindService(AuthenticationListener.AuthenticationListenerBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<LogonCompleteNotification, NO_RESPONSE>(AuthenticationListener.__Method_OnLogonComplete, new UnaryServerMethod<LogonCompleteNotification, NO_RESPONSE>(serviceImpl.OnLogonComplete)).AddMethod<LogonQueueUpdateNotification, NO_RESPONSE>(AuthenticationListener.__Method_OnLogonQueueUpdate, new UnaryServerMethod<LogonQueueUpdateNotification, NO_RESPONSE>(serviceImpl.OnLogonQueueUpdate))
				.AddMethod<NoData, NO_RESPONSE>(AuthenticationListener.__Method_OnLogonQueueEnd, new UnaryServerMethod<NoData, NO_RESPONSE>(serviceImpl.OnLogonQueueEnd))
				.AddMethod<ExternalChallengeNotification, NO_RESPONSE>(AuthenticationListener.__Method_OnExternalChallenge, new UnaryServerMethod<ExternalChallengeNotification, NO_RESPONSE>(serviceImpl.OnExternalChallenge))
				.Build();
		}

		// Token: 0x06009290 RID: 37520 RVA: 0x0023817C File Offset: 0x0023637C
		public static void BindService(ServiceBinderBase serviceBinder, AuthenticationListener.AuthenticationListenerBase serviceImpl)
		{
			serviceBinder.AddMethod<LogonCompleteNotification, NO_RESPONSE>(AuthenticationListener.__Method_OnLogonComplete, (serviceImpl == null) ? null : new UnaryServerMethod<LogonCompleteNotification, NO_RESPONSE>(serviceImpl.OnLogonComplete));
			serviceBinder.AddMethod<LogonQueueUpdateNotification, NO_RESPONSE>(AuthenticationListener.__Method_OnLogonQueueUpdate, (serviceImpl == null) ? null : new UnaryServerMethod<LogonQueueUpdateNotification, NO_RESPONSE>(serviceImpl.OnLogonQueueUpdate));
			serviceBinder.AddMethod<NoData, NO_RESPONSE>(AuthenticationListener.__Method_OnLogonQueueEnd, (serviceImpl == null) ? null : new UnaryServerMethod<NoData, NO_RESPONSE>(serviceImpl.OnLogonQueueEnd));
			serviceBinder.AddMethod<ExternalChallengeNotification, NO_RESPONSE>(AuthenticationListener.__Method_OnExternalChallenge, (serviceImpl == null) ? null : new UnaryServerMethod<ExternalChallengeNotification, NO_RESPONSE>(serviceImpl.OnExternalChallenge));
		}

		// Token: 0x0400422B RID: 16939
		private static readonly string __ServiceName = "bgs.protocol.authentication.v2.client.AuthenticationListener";

		// Token: 0x0400422C RID: 16940
		private static readonly Marshaller<LogonCompleteNotification> __Marshaller_bgs_protocol_authentication_v2_client_LogonCompleteNotification = Marshallers.Create<LogonCompleteNotification>(new Action<LogonCompleteNotification, SerializationContext>(AuthenticationListener.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationListener.__Helper_DeserializeMessage<LogonCompleteNotification>(context, LogonCompleteNotification.Parser));

		// Token: 0x0400422D RID: 16941
		private static readonly Marshaller<NO_RESPONSE> __Marshaller_bgs_protocol_NO_RESPONSE = Marshallers.Create<NO_RESPONSE>(new Action<NO_RESPONSE, SerializationContext>(AuthenticationListener.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationListener.__Helper_DeserializeMessage<NO_RESPONSE>(context, NO_RESPONSE.Parser));

		// Token: 0x0400422E RID: 16942
		private static readonly Marshaller<LogonQueueUpdateNotification> __Marshaller_bgs_protocol_authentication_v2_client_LogonQueueUpdateNotification = Marshallers.Create<LogonQueueUpdateNotification>(new Action<LogonQueueUpdateNotification, SerializationContext>(AuthenticationListener.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationListener.__Helper_DeserializeMessage<LogonQueueUpdateNotification>(context, LogonQueueUpdateNotification.Parser));

		// Token: 0x0400422F RID: 16943
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(AuthenticationListener.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationListener.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x04004230 RID: 16944
		private static readonly Marshaller<ExternalChallengeNotification> __Marshaller_bgs_protocol_authentication_v2_client_ExternalChallengeNotification = Marshallers.Create<ExternalChallengeNotification>(new Action<ExternalChallengeNotification, SerializationContext>(AuthenticationListener.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationListener.__Helper_DeserializeMessage<ExternalChallengeNotification>(context, ExternalChallengeNotification.Parser));

		// Token: 0x04004231 RID: 16945
		private static readonly Method<LogonCompleteNotification, NO_RESPONSE> __Method_OnLogonComplete = new Method<LogonCompleteNotification, NO_RESPONSE>(0, AuthenticationListener.__ServiceName, "OnLogonComplete", AuthenticationListener.__Marshaller_bgs_protocol_authentication_v2_client_LogonCompleteNotification, AuthenticationListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04004232 RID: 16946
		private static readonly Method<LogonQueueUpdateNotification, NO_RESPONSE> __Method_OnLogonQueueUpdate = new Method<LogonQueueUpdateNotification, NO_RESPONSE>(0, AuthenticationListener.__ServiceName, "OnLogonQueueUpdate", AuthenticationListener.__Marshaller_bgs_protocol_authentication_v2_client_LogonQueueUpdateNotification, AuthenticationListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04004233 RID: 16947
		private static readonly Method<NoData, NO_RESPONSE> __Method_OnLogonQueueEnd = new Method<NoData, NO_RESPONSE>(0, AuthenticationListener.__ServiceName, "OnLogonQueueEnd", AuthenticationListener.__Marshaller_bgs_protocol_NoData, AuthenticationListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04004234 RID: 16948
		private static readonly Method<ExternalChallengeNotification, NO_RESPONSE> __Method_OnExternalChallenge = new Method<ExternalChallengeNotification, NO_RESPONSE>(0, AuthenticationListener.__ServiceName, "OnExternalChallenge", AuthenticationListener.__Marshaller_bgs_protocol_authentication_v2_client_ExternalChallengeNotification, AuthenticationListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x0200110F RID: 4367
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x0400984A RID: 38986
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02001110 RID: 4368
		[BindServiceMethod(typeof(AuthenticationListener), "BindService")]
		public abstract class AuthenticationListenerBase
		{
			// Token: 0x0600D554 RID: 54612 RVA: 0x004B5949 File Offset: 0x004B3B49
			public virtual Task<NO_RESPONSE> OnLogonComplete(LogonCompleteNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D555 RID: 54613 RVA: 0x004B595D File Offset: 0x004B3B5D
			public virtual Task<NO_RESPONSE> OnLogonQueueUpdate(LogonQueueUpdateNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D556 RID: 54614 RVA: 0x004B5971 File Offset: 0x004B3B71
			public virtual Task<NO_RESPONSE> OnLogonQueueEnd(NoData request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D557 RID: 54615 RVA: 0x004B5985 File Offset: 0x004B3B85
			public virtual Task<NO_RESPONSE> OnExternalChallenge(ExternalChallengeNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x02001111 RID: 4369
		public class AuthenticationListenerClient : ClientBase<AuthenticationListener.AuthenticationListenerClient>
		{
			// Token: 0x0600D559 RID: 54617 RVA: 0x004B59A2 File Offset: 0x004B3BA2
			public AuthenticationListenerClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D55A RID: 54618 RVA: 0x004B59AD File Offset: 0x004B3BAD
			public AuthenticationListenerClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D55B RID: 54619 RVA: 0x004B59B8 File Offset: 0x004B3BB8
			protected AuthenticationListenerClient()
			{
			}

			// Token: 0x0600D55C RID: 54620 RVA: 0x004B59C2 File Offset: 0x004B3BC2
			protected AuthenticationListenerClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D55D RID: 54621 RVA: 0x004B59D0 File Offset: 0x004B3BD0
			public virtual NO_RESPONSE OnLogonComplete(LogonCompleteNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnLogonComplete(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D55E RID: 54622 RVA: 0x004B59F8 File Offset: 0x004B3BF8
			public virtual NO_RESPONSE OnLogonComplete(LogonCompleteNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<LogonCompleteNotification, NO_RESPONSE>(AuthenticationListener.__Method_OnLogonComplete, null, options, request);
			}

			// Token: 0x0600D55F RID: 54623 RVA: 0x004B5A20 File Offset: 0x004B3C20
			public virtual AsyncUnaryCall<NO_RESPONSE> OnLogonCompleteAsync(LogonCompleteNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnLogonCompleteAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D560 RID: 54624 RVA: 0x004B5A48 File Offset: 0x004B3C48
			public virtual AsyncUnaryCall<NO_RESPONSE> OnLogonCompleteAsync(LogonCompleteNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<LogonCompleteNotification, NO_RESPONSE>(AuthenticationListener.__Method_OnLogonComplete, null, options, request);
			}

			// Token: 0x0600D561 RID: 54625 RVA: 0x004B5A70 File Offset: 0x004B3C70
			public virtual NO_RESPONSE OnLogonQueueUpdate(LogonQueueUpdateNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnLogonQueueUpdate(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D562 RID: 54626 RVA: 0x004B5A98 File Offset: 0x004B3C98
			public virtual NO_RESPONSE OnLogonQueueUpdate(LogonQueueUpdateNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<LogonQueueUpdateNotification, NO_RESPONSE>(AuthenticationListener.__Method_OnLogonQueueUpdate, null, options, request);
			}

			// Token: 0x0600D563 RID: 54627 RVA: 0x004B5AC0 File Offset: 0x004B3CC0
			public virtual AsyncUnaryCall<NO_RESPONSE> OnLogonQueueUpdateAsync(LogonQueueUpdateNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnLogonQueueUpdateAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D564 RID: 54628 RVA: 0x004B5AE8 File Offset: 0x004B3CE8
			public virtual AsyncUnaryCall<NO_RESPONSE> OnLogonQueueUpdateAsync(LogonQueueUpdateNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<LogonQueueUpdateNotification, NO_RESPONSE>(AuthenticationListener.__Method_OnLogonQueueUpdate, null, options, request);
			}

			// Token: 0x0600D565 RID: 54629 RVA: 0x004B5B10 File Offset: 0x004B3D10
			public virtual NO_RESPONSE OnLogonQueueEnd(NoData request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnLogonQueueEnd(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D566 RID: 54630 RVA: 0x004B5B38 File Offset: 0x004B3D38
			public virtual NO_RESPONSE OnLogonQueueEnd(NoData request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<NoData, NO_RESPONSE>(AuthenticationListener.__Method_OnLogonQueueEnd, null, options, request);
			}

			// Token: 0x0600D567 RID: 54631 RVA: 0x004B5B60 File Offset: 0x004B3D60
			public virtual AsyncUnaryCall<NO_RESPONSE> OnLogonQueueEndAsync(NoData request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnLogonQueueEndAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D568 RID: 54632 RVA: 0x004B5B88 File Offset: 0x004B3D88
			public virtual AsyncUnaryCall<NO_RESPONSE> OnLogonQueueEndAsync(NoData request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<NoData, NO_RESPONSE>(AuthenticationListener.__Method_OnLogonQueueEnd, null, options, request);
			}

			// Token: 0x0600D569 RID: 54633 RVA: 0x004B5BB0 File Offset: 0x004B3DB0
			public virtual NO_RESPONSE OnExternalChallenge(ExternalChallengeNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnExternalChallenge(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D56A RID: 54634 RVA: 0x004B5BD8 File Offset: 0x004B3DD8
			public virtual NO_RESPONSE OnExternalChallenge(ExternalChallengeNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ExternalChallengeNotification, NO_RESPONSE>(AuthenticationListener.__Method_OnExternalChallenge, null, options, request);
			}

			// Token: 0x0600D56B RID: 54635 RVA: 0x004B5C00 File Offset: 0x004B3E00
			public virtual AsyncUnaryCall<NO_RESPONSE> OnExternalChallengeAsync(ExternalChallengeNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnExternalChallengeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D56C RID: 54636 RVA: 0x004B5C28 File Offset: 0x004B3E28
			public virtual AsyncUnaryCall<NO_RESPONSE> OnExternalChallengeAsync(ExternalChallengeNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ExternalChallengeNotification, NO_RESPONSE>(AuthenticationListener.__Method_OnExternalChallenge, null, options, request);
			}

			// Token: 0x0600D56D RID: 54637 RVA: 0x004B5C50 File Offset: 0x004B3E50
			protected override AuthenticationListener.AuthenticationListenerClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new AuthenticationListener.AuthenticationListenerClient(configuration);
			}
		}
	}
}
