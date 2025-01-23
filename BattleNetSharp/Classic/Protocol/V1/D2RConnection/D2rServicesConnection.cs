using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Bgs.Protocol;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Classic.Protocol.V1.D2RConnection
{
	// Token: 0x02000778 RID: 1912
	public static class D2rServicesConnection
	{
		// Token: 0x0600AFE5 RID: 45029 RVA: 0x002ACDE0 File Offset: 0x002AAFE0
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

		// Token: 0x0600AFE6 RID: 45030 RVA: 0x002ACE2C File Offset: 0x002AB02C
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = D2rServicesConnection.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17003663 RID: 13923
		// (get) Token: 0x0600AFE7 RID: 45031 RVA: 0x002ACE64 File Offset: 0x002AB064
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return D2RConnectionReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x0600AFE8 RID: 45032 RVA: 0x002ACE88 File Offset: 0x002AB088
		public static ServerServiceDefinition BindService(D2rServicesConnection.D2rServicesConnectionBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<AuthSessionRequest, AuthSessionResponse>(D2rServicesConnection.__Method_AuthSession, new UnaryServerMethod<AuthSessionRequest, AuthSessionResponse>(serviceImpl.AuthSession)).AddMethod<NoData, SessionUpdateResponse>(D2rServicesConnection.__Method_SessionUpdate, new UnaryServerMethod<NoData, SessionUpdateResponse>(serviceImpl.SessionUpdate))
				.AddMethod<AuthRequest, AuthResponse>(D2rServicesConnection.__Method_SessionDestroyed, new UnaryServerMethod<AuthRequest, AuthResponse>(serviceImpl.SessionDestroyed))
				.AddMethod<NoData, CookieUpdateResponse>(D2rServicesConnection.__Method_CookieUpdate, new UnaryServerMethod<NoData, CookieUpdateResponse>(serviceImpl.CookieUpdate))
				.AddMethod<NoData, NoData>(D2rServicesConnection.__Method_Ping, new UnaryServerMethod<NoData, NoData>(serviceImpl.Ping))
				.AddMethod<NoData, NoData>(D2rServicesConnection.__Method_ServerPing, new UnaryServerMethod<NoData, NoData>(serviceImpl.ServerPing))
				.Build();
		}

		// Token: 0x0600AFE9 RID: 45033 RVA: 0x002ACF30 File Offset: 0x002AB130
		public static void BindService(ServiceBinderBase serviceBinder, D2rServicesConnection.D2rServicesConnectionBase serviceImpl)
		{
			serviceBinder.AddMethod<AuthSessionRequest, AuthSessionResponse>(D2rServicesConnection.__Method_AuthSession, (serviceImpl == null) ? null : new UnaryServerMethod<AuthSessionRequest, AuthSessionResponse>(serviceImpl.AuthSession));
			serviceBinder.AddMethod<NoData, SessionUpdateResponse>(D2rServicesConnection.__Method_SessionUpdate, (serviceImpl == null) ? null : new UnaryServerMethod<NoData, SessionUpdateResponse>(serviceImpl.SessionUpdate));
			serviceBinder.AddMethod<AuthRequest, AuthResponse>(D2rServicesConnection.__Method_SessionDestroyed, (serviceImpl == null) ? null : new UnaryServerMethod<AuthRequest, AuthResponse>(serviceImpl.SessionDestroyed));
			serviceBinder.AddMethod<NoData, CookieUpdateResponse>(D2rServicesConnection.__Method_CookieUpdate, (serviceImpl == null) ? null : new UnaryServerMethod<NoData, CookieUpdateResponse>(serviceImpl.CookieUpdate));
			serviceBinder.AddMethod<NoData, NoData>(D2rServicesConnection.__Method_Ping, (serviceImpl == null) ? null : new UnaryServerMethod<NoData, NoData>(serviceImpl.Ping));
			serviceBinder.AddMethod<NoData, NoData>(D2rServicesConnection.__Method_ServerPing, (serviceImpl == null) ? null : new UnaryServerMethod<NoData, NoData>(serviceImpl.ServerPing));
		}

		// Token: 0x04004F46 RID: 20294
		private static readonly string __ServiceName = "classic.protocol.v1.d2r_connection.D2rServicesConnection";

		// Token: 0x04004F47 RID: 20295
		private static readonly Marshaller<AuthSessionRequest> __Marshaller_classic_protocol_v1_d2r_connection_AuthSessionRequest = Marshallers.Create<AuthSessionRequest>(new Action<AuthSessionRequest, SerializationContext>(D2rServicesConnection.__Helper_SerializeMessage), (DeserializationContext context) => D2rServicesConnection.__Helper_DeserializeMessage<AuthSessionRequest>(context, AuthSessionRequest.Parser));

		// Token: 0x04004F48 RID: 20296
		private static readonly Marshaller<AuthSessionResponse> __Marshaller_classic_protocol_v1_d2r_connection_AuthSessionResponse = Marshallers.Create<AuthSessionResponse>(new Action<AuthSessionResponse, SerializationContext>(D2rServicesConnection.__Helper_SerializeMessage), (DeserializationContext context) => D2rServicesConnection.__Helper_DeserializeMessage<AuthSessionResponse>(context, AuthSessionResponse.Parser));

		// Token: 0x04004F49 RID: 20297
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(D2rServicesConnection.__Helper_SerializeMessage), (DeserializationContext context) => D2rServicesConnection.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x04004F4A RID: 20298
		private static readonly Marshaller<SessionUpdateResponse> __Marshaller_classic_protocol_v1_d2r_connection_SessionUpdateResponse = Marshallers.Create<SessionUpdateResponse>(new Action<SessionUpdateResponse, SerializationContext>(D2rServicesConnection.__Helper_SerializeMessage), (DeserializationContext context) => D2rServicesConnection.__Helper_DeserializeMessage<SessionUpdateResponse>(context, SessionUpdateResponse.Parser));

		// Token: 0x04004F4B RID: 20299
		private static readonly Marshaller<AuthRequest> __Marshaller_classic_protocol_v1_d2r_connection_AuthRequest = Marshallers.Create<AuthRequest>(new Action<AuthRequest, SerializationContext>(D2rServicesConnection.__Helper_SerializeMessage), (DeserializationContext context) => D2rServicesConnection.__Helper_DeserializeMessage<AuthRequest>(context, AuthRequest.Parser));

		// Token: 0x04004F4C RID: 20300
		private static readonly Marshaller<AuthResponse> __Marshaller_classic_protocol_v1_d2r_connection_AuthResponse = Marshallers.Create<AuthResponse>(new Action<AuthResponse, SerializationContext>(D2rServicesConnection.__Helper_SerializeMessage), (DeserializationContext context) => D2rServicesConnection.__Helper_DeserializeMessage<AuthResponse>(context, AuthResponse.Parser));

		// Token: 0x04004F4D RID: 20301
		private static readonly Marshaller<CookieUpdateResponse> __Marshaller_classic_protocol_v1_d2r_connection_CookieUpdateResponse = Marshallers.Create<CookieUpdateResponse>(new Action<CookieUpdateResponse, SerializationContext>(D2rServicesConnection.__Helper_SerializeMessage), (DeserializationContext context) => D2rServicesConnection.__Helper_DeserializeMessage<CookieUpdateResponse>(context, CookieUpdateResponse.Parser));

		// Token: 0x04004F4E RID: 20302
		private static readonly Method<AuthSessionRequest, AuthSessionResponse> __Method_AuthSession = new Method<AuthSessionRequest, AuthSessionResponse>(0, D2rServicesConnection.__ServiceName, "AuthSession", D2rServicesConnection.__Marshaller_classic_protocol_v1_d2r_connection_AuthSessionRequest, D2rServicesConnection.__Marshaller_classic_protocol_v1_d2r_connection_AuthSessionResponse);

		// Token: 0x04004F4F RID: 20303
		private static readonly Method<NoData, SessionUpdateResponse> __Method_SessionUpdate = new Method<NoData, SessionUpdateResponse>(0, D2rServicesConnection.__ServiceName, "SessionUpdate", D2rServicesConnection.__Marshaller_bgs_protocol_NoData, D2rServicesConnection.__Marshaller_classic_protocol_v1_d2r_connection_SessionUpdateResponse);

		// Token: 0x04004F50 RID: 20304
		private static readonly Method<AuthRequest, AuthResponse> __Method_SessionDestroyed = new Method<AuthRequest, AuthResponse>(0, D2rServicesConnection.__ServiceName, "SessionDestroyed", D2rServicesConnection.__Marshaller_classic_protocol_v1_d2r_connection_AuthRequest, D2rServicesConnection.__Marshaller_classic_protocol_v1_d2r_connection_AuthResponse);

		// Token: 0x04004F51 RID: 20305
		private static readonly Method<NoData, CookieUpdateResponse> __Method_CookieUpdate = new Method<NoData, CookieUpdateResponse>(0, D2rServicesConnection.__ServiceName, "CookieUpdate", D2rServicesConnection.__Marshaller_bgs_protocol_NoData, D2rServicesConnection.__Marshaller_classic_protocol_v1_d2r_connection_CookieUpdateResponse);

		// Token: 0x04004F52 RID: 20306
		private static readonly Method<NoData, NoData> __Method_Ping = new Method<NoData, NoData>(0, D2rServicesConnection.__ServiceName, "Ping", D2rServicesConnection.__Marshaller_bgs_protocol_NoData, D2rServicesConnection.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04004F53 RID: 20307
		private static readonly Method<NoData, NoData> __Method_ServerPing = new Method<NoData, NoData>(0, D2rServicesConnection.__ServiceName, "ServerPing", D2rServicesConnection.__Marshaller_bgs_protocol_NoData, D2rServicesConnection.__Marshaller_bgs_protocol_NoData);

		// Token: 0x02001296 RID: 4758
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x040099AE RID: 39342
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02001297 RID: 4759
		[BindServiceMethod(typeof(D2rServicesConnection), "BindService")]
		public abstract class D2rServicesConnectionBase
		{
			// Token: 0x0600DD17 RID: 56599 RVA: 0x004BF629 File Offset: 0x004BD829
			public virtual Task<AuthSessionResponse> AuthSession(AuthSessionRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DD18 RID: 56600 RVA: 0x004BF63D File Offset: 0x004BD83D
			public virtual Task<SessionUpdateResponse> SessionUpdate(NoData request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DD19 RID: 56601 RVA: 0x004BF651 File Offset: 0x004BD851
			public virtual Task<AuthResponse> SessionDestroyed(AuthRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DD1A RID: 56602 RVA: 0x004BF665 File Offset: 0x004BD865
			public virtual Task<CookieUpdateResponse> CookieUpdate(NoData request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DD1B RID: 56603 RVA: 0x004BF679 File Offset: 0x004BD879
			public virtual Task<NoData> Ping(NoData request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600DD1C RID: 56604 RVA: 0x004BF68D File Offset: 0x004BD88D
			public virtual Task<NoData> ServerPing(NoData request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x02001298 RID: 4760
		public class D2rServicesConnectionClient : ClientBase<D2rServicesConnection.D2rServicesConnectionClient>
		{
			// Token: 0x0600DD1E RID: 56606 RVA: 0x004BF6AA File Offset: 0x004BD8AA
			public D2rServicesConnectionClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600DD1F RID: 56607 RVA: 0x004BF6B5 File Offset: 0x004BD8B5
			public D2rServicesConnectionClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600DD20 RID: 56608 RVA: 0x004BF6C0 File Offset: 0x004BD8C0
			protected D2rServicesConnectionClient()
			{
			}

			// Token: 0x0600DD21 RID: 56609 RVA: 0x004BF6CA File Offset: 0x004BD8CA
			protected D2rServicesConnectionClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600DD22 RID: 56610 RVA: 0x004BF6D8 File Offset: 0x004BD8D8
			public virtual AuthSessionResponse AuthSession(AuthSessionRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.AuthSession(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DD23 RID: 56611 RVA: 0x004BF700 File Offset: 0x004BD900
			public virtual AuthSessionResponse AuthSession(AuthSessionRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<AuthSessionRequest, AuthSessionResponse>(D2rServicesConnection.__Method_AuthSession, null, options, request);
			}

			// Token: 0x0600DD24 RID: 56612 RVA: 0x004BF728 File Offset: 0x004BD928
			public virtual AsyncUnaryCall<AuthSessionResponse> AuthSessionAsync(AuthSessionRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.AuthSessionAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DD25 RID: 56613 RVA: 0x004BF750 File Offset: 0x004BD950
			public virtual AsyncUnaryCall<AuthSessionResponse> AuthSessionAsync(AuthSessionRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<AuthSessionRequest, AuthSessionResponse>(D2rServicesConnection.__Method_AuthSession, null, options, request);
			}

			// Token: 0x0600DD26 RID: 56614 RVA: 0x004BF778 File Offset: 0x004BD978
			public virtual SessionUpdateResponse SessionUpdate(NoData request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SessionUpdate(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DD27 RID: 56615 RVA: 0x004BF7A0 File Offset: 0x004BD9A0
			public virtual SessionUpdateResponse SessionUpdate(NoData request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<NoData, SessionUpdateResponse>(D2rServicesConnection.__Method_SessionUpdate, null, options, request);
			}

			// Token: 0x0600DD28 RID: 56616 RVA: 0x004BF7C8 File Offset: 0x004BD9C8
			public virtual AsyncUnaryCall<SessionUpdateResponse> SessionUpdateAsync(NoData request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SessionUpdateAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DD29 RID: 56617 RVA: 0x004BF7F0 File Offset: 0x004BD9F0
			public virtual AsyncUnaryCall<SessionUpdateResponse> SessionUpdateAsync(NoData request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<NoData, SessionUpdateResponse>(D2rServicesConnection.__Method_SessionUpdate, null, options, request);
			}

			// Token: 0x0600DD2A RID: 56618 RVA: 0x004BF818 File Offset: 0x004BDA18
			public virtual AuthResponse SessionDestroyed(AuthRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SessionDestroyed(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DD2B RID: 56619 RVA: 0x004BF840 File Offset: 0x004BDA40
			public virtual AuthResponse SessionDestroyed(AuthRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<AuthRequest, AuthResponse>(D2rServicesConnection.__Method_SessionDestroyed, null, options, request);
			}

			// Token: 0x0600DD2C RID: 56620 RVA: 0x004BF868 File Offset: 0x004BDA68
			public virtual AsyncUnaryCall<AuthResponse> SessionDestroyedAsync(AuthRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SessionDestroyedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DD2D RID: 56621 RVA: 0x004BF890 File Offset: 0x004BDA90
			public virtual AsyncUnaryCall<AuthResponse> SessionDestroyedAsync(AuthRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<AuthRequest, AuthResponse>(D2rServicesConnection.__Method_SessionDestroyed, null, options, request);
			}

			// Token: 0x0600DD2E RID: 56622 RVA: 0x004BF8B8 File Offset: 0x004BDAB8
			public virtual CookieUpdateResponse CookieUpdate(NoData request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.CookieUpdate(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DD2F RID: 56623 RVA: 0x004BF8E0 File Offset: 0x004BDAE0
			public virtual CookieUpdateResponse CookieUpdate(NoData request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<NoData, CookieUpdateResponse>(D2rServicesConnection.__Method_CookieUpdate, null, options, request);
			}

			// Token: 0x0600DD30 RID: 56624 RVA: 0x004BF908 File Offset: 0x004BDB08
			public virtual AsyncUnaryCall<CookieUpdateResponse> CookieUpdateAsync(NoData request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.CookieUpdateAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DD31 RID: 56625 RVA: 0x004BF930 File Offset: 0x004BDB30
			public virtual AsyncUnaryCall<CookieUpdateResponse> CookieUpdateAsync(NoData request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<NoData, CookieUpdateResponse>(D2rServicesConnection.__Method_CookieUpdate, null, options, request);
			}

			// Token: 0x0600DD32 RID: 56626 RVA: 0x004BF958 File Offset: 0x004BDB58
			public virtual NoData Ping(NoData request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Ping(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DD33 RID: 56627 RVA: 0x004BF980 File Offset: 0x004BDB80
			public virtual NoData Ping(NoData request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<NoData, NoData>(D2rServicesConnection.__Method_Ping, null, options, request);
			}

			// Token: 0x0600DD34 RID: 56628 RVA: 0x004BF9A8 File Offset: 0x004BDBA8
			public virtual AsyncUnaryCall<NoData> PingAsync(NoData request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.PingAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DD35 RID: 56629 RVA: 0x004BF9D0 File Offset: 0x004BDBD0
			public virtual AsyncUnaryCall<NoData> PingAsync(NoData request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<NoData, NoData>(D2rServicesConnection.__Method_Ping, null, options, request);
			}

			// Token: 0x0600DD36 RID: 56630 RVA: 0x004BF9F8 File Offset: 0x004BDBF8
			public virtual NoData ServerPing(NoData request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ServerPing(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DD37 RID: 56631 RVA: 0x004BFA20 File Offset: 0x004BDC20
			public virtual NoData ServerPing(NoData request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<NoData, NoData>(D2rServicesConnection.__Method_ServerPing, null, options, request);
			}

			// Token: 0x0600DD38 RID: 56632 RVA: 0x004BFA48 File Offset: 0x004BDC48
			public virtual AsyncUnaryCall<NoData> ServerPingAsync(NoData request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ServerPingAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DD39 RID: 56633 RVA: 0x004BFA70 File Offset: 0x004BDC70
			public virtual AsyncUnaryCall<NoData> ServerPingAsync(NoData request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<NoData, NoData>(D2rServicesConnection.__Method_ServerPing, null, options, request);
			}

			// Token: 0x0600DD3A RID: 56634 RVA: 0x004BFA98 File Offset: 0x004BDC98
			protected override D2rServicesConnection.D2rServicesConnectionClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new D2rServicesConnection.D2rServicesConnectionClient(configuration);
			}
		}
	}
}
