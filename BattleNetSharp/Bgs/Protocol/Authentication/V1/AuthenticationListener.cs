using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Authentication.V1
{
	// Token: 0x02000619 RID: 1561
	public static class AuthenticationListener
	{
		// Token: 0x06009237 RID: 37431 RVA: 0x002365BC File Offset: 0x002347BC
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

		// Token: 0x06009238 RID: 37432 RVA: 0x00236608 File Offset: 0x00234808
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

		// Token: 0x17002DAF RID: 11695
		// (get) Token: 0x06009239 RID: 37433 RVA: 0x00236640 File Offset: 0x00234840
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x0600923A RID: 37434 RVA: 0x00236664 File Offset: 0x00234864
		public static ServerServiceDefinition BindService(AuthenticationListener.AuthenticationListenerBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<ModuleLoadRequest, NO_RESPONSE>(AuthenticationListener.__Method_OnModuleLoad, new UnaryServerMethod<ModuleLoadRequest, NO_RESPONSE>(serviceImpl.OnModuleLoad)).AddMethod<ModuleMessageRequest, NoData>(AuthenticationListener.__Method_OnModuleMessage, new UnaryServerMethod<ModuleMessageRequest, NoData>(serviceImpl.OnModuleMessage))
				.AddMethod<ServerStateChangeRequest, NO_RESPONSE>(AuthenticationListener.__Method_OnServerStateChange, new UnaryServerMethod<ServerStateChangeRequest, NO_RESPONSE>(serviceImpl.OnServerStateChange))
				.AddMethod<LogonResult, NO_RESPONSE>(AuthenticationListener.__Method_OnLogonComplete, new UnaryServerMethod<LogonResult, NO_RESPONSE>(serviceImpl.OnLogonComplete))
				.AddMethod<MemModuleLoadRequest, MemModuleLoadResponse>(AuthenticationListener.__Method_OnMemModuleLoad, new UnaryServerMethod<MemModuleLoadRequest, MemModuleLoadResponse>(serviceImpl.OnMemModuleLoad))
				.AddMethod<LogonUpdateRequest, NO_RESPONSE>(AuthenticationListener.__Method_OnLogonUpdate, new UnaryServerMethod<LogonUpdateRequest, NO_RESPONSE>(serviceImpl.OnLogonUpdate))
				.AddMethod<VersionInfoNotification, NO_RESPONSE>(AuthenticationListener.__Method_OnVersionInfoUpdated, new UnaryServerMethod<VersionInfoNotification, NO_RESPONSE>(serviceImpl.OnVersionInfoUpdated))
				.AddMethod<LogonQueueUpdateRequest, NO_RESPONSE>(AuthenticationListener.__Method_OnLogonQueueUpdate, new UnaryServerMethod<LogonQueueUpdateRequest, NO_RESPONSE>(serviceImpl.OnLogonQueueUpdate))
				.AddMethod<NoData, NO_RESPONSE>(AuthenticationListener.__Method_OnLogonQueueEnd, new UnaryServerMethod<NoData, NO_RESPONSE>(serviceImpl.OnLogonQueueEnd))
				.AddMethod<GameAccountSelectedRequest, NO_RESPONSE>(AuthenticationListener.__Method_OnGameAccountSelected, new UnaryServerMethod<GameAccountSelectedRequest, NO_RESPONSE>(serviceImpl.OnGameAccountSelected))
				.Build();
		}

		// Token: 0x0600923B RID: 37435 RVA: 0x00236768 File Offset: 0x00234968
		public static void BindService(ServiceBinderBase serviceBinder, AuthenticationListener.AuthenticationListenerBase serviceImpl)
		{
			serviceBinder.AddMethod<ModuleLoadRequest, NO_RESPONSE>(AuthenticationListener.__Method_OnModuleLoad, (serviceImpl == null) ? null : new UnaryServerMethod<ModuleLoadRequest, NO_RESPONSE>(serviceImpl.OnModuleLoad));
			serviceBinder.AddMethod<ModuleMessageRequest, NoData>(AuthenticationListener.__Method_OnModuleMessage, (serviceImpl == null) ? null : new UnaryServerMethod<ModuleMessageRequest, NoData>(serviceImpl.OnModuleMessage));
			serviceBinder.AddMethod<ServerStateChangeRequest, NO_RESPONSE>(AuthenticationListener.__Method_OnServerStateChange, (serviceImpl == null) ? null : new UnaryServerMethod<ServerStateChangeRequest, NO_RESPONSE>(serviceImpl.OnServerStateChange));
			serviceBinder.AddMethod<LogonResult, NO_RESPONSE>(AuthenticationListener.__Method_OnLogonComplete, (serviceImpl == null) ? null : new UnaryServerMethod<LogonResult, NO_RESPONSE>(serviceImpl.OnLogonComplete));
			serviceBinder.AddMethod<MemModuleLoadRequest, MemModuleLoadResponse>(AuthenticationListener.__Method_OnMemModuleLoad, (serviceImpl == null) ? null : new UnaryServerMethod<MemModuleLoadRequest, MemModuleLoadResponse>(serviceImpl.OnMemModuleLoad));
			serviceBinder.AddMethod<LogonUpdateRequest, NO_RESPONSE>(AuthenticationListener.__Method_OnLogonUpdate, (serviceImpl == null) ? null : new UnaryServerMethod<LogonUpdateRequest, NO_RESPONSE>(serviceImpl.OnLogonUpdate));
			serviceBinder.AddMethod<VersionInfoNotification, NO_RESPONSE>(AuthenticationListener.__Method_OnVersionInfoUpdated, (serviceImpl == null) ? null : new UnaryServerMethod<VersionInfoNotification, NO_RESPONSE>(serviceImpl.OnVersionInfoUpdated));
			serviceBinder.AddMethod<LogonQueueUpdateRequest, NO_RESPONSE>(AuthenticationListener.__Method_OnLogonQueueUpdate, (serviceImpl == null) ? null : new UnaryServerMethod<LogonQueueUpdateRequest, NO_RESPONSE>(serviceImpl.OnLogonQueueUpdate));
			serviceBinder.AddMethod<NoData, NO_RESPONSE>(AuthenticationListener.__Method_OnLogonQueueEnd, (serviceImpl == null) ? null : new UnaryServerMethod<NoData, NO_RESPONSE>(serviceImpl.OnLogonQueueEnd));
			serviceBinder.AddMethod<GameAccountSelectedRequest, NO_RESPONSE>(AuthenticationListener.__Method_OnGameAccountSelected, (serviceImpl == null) ? null : new UnaryServerMethod<GameAccountSelectedRequest, NO_RESPONSE>(serviceImpl.OnGameAccountSelected));
		}

		// Token: 0x040041E8 RID: 16872
		private static readonly string __ServiceName = "bgs.protocol.authentication.v1.AuthenticationListener";

		// Token: 0x040041E9 RID: 16873
		private static readonly Marshaller<ModuleLoadRequest> __Marshaller_bgs_protocol_authentication_v1_ModuleLoadRequest = Marshallers.Create<ModuleLoadRequest>(new Action<ModuleLoadRequest, SerializationContext>(AuthenticationListener.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationListener.__Helper_DeserializeMessage<ModuleLoadRequest>(context, ModuleLoadRequest.Parser));

		// Token: 0x040041EA RID: 16874
		private static readonly Marshaller<NO_RESPONSE> __Marshaller_bgs_protocol_NO_RESPONSE = Marshallers.Create<NO_RESPONSE>(new Action<NO_RESPONSE, SerializationContext>(AuthenticationListener.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationListener.__Helper_DeserializeMessage<NO_RESPONSE>(context, NO_RESPONSE.Parser));

		// Token: 0x040041EB RID: 16875
		private static readonly Marshaller<ModuleMessageRequest> __Marshaller_bgs_protocol_authentication_v1_ModuleMessageRequest = Marshallers.Create<ModuleMessageRequest>(new Action<ModuleMessageRequest, SerializationContext>(AuthenticationListener.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationListener.__Helper_DeserializeMessage<ModuleMessageRequest>(context, ModuleMessageRequest.Parser));

		// Token: 0x040041EC RID: 16876
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(AuthenticationListener.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationListener.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x040041ED RID: 16877
		private static readonly Marshaller<ServerStateChangeRequest> __Marshaller_bgs_protocol_authentication_v1_ServerStateChangeRequest = Marshallers.Create<ServerStateChangeRequest>(new Action<ServerStateChangeRequest, SerializationContext>(AuthenticationListener.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationListener.__Helper_DeserializeMessage<ServerStateChangeRequest>(context, ServerStateChangeRequest.Parser));

		// Token: 0x040041EE RID: 16878
		private static readonly Marshaller<LogonResult> __Marshaller_bgs_protocol_authentication_v1_LogonResult = Marshallers.Create<LogonResult>(new Action<LogonResult, SerializationContext>(AuthenticationListener.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationListener.__Helper_DeserializeMessage<LogonResult>(context, LogonResult.Parser));

		// Token: 0x040041EF RID: 16879
		private static readonly Marshaller<MemModuleLoadRequest> __Marshaller_bgs_protocol_authentication_v1_MemModuleLoadRequest = Marshallers.Create<MemModuleLoadRequest>(new Action<MemModuleLoadRequest, SerializationContext>(AuthenticationListener.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationListener.__Helper_DeserializeMessage<MemModuleLoadRequest>(context, MemModuleLoadRequest.Parser));

		// Token: 0x040041F0 RID: 16880
		private static readonly Marshaller<MemModuleLoadResponse> __Marshaller_bgs_protocol_authentication_v1_MemModuleLoadResponse = Marshallers.Create<MemModuleLoadResponse>(new Action<MemModuleLoadResponse, SerializationContext>(AuthenticationListener.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationListener.__Helper_DeserializeMessage<MemModuleLoadResponse>(context, MemModuleLoadResponse.Parser));

		// Token: 0x040041F1 RID: 16881
		private static readonly Marshaller<LogonUpdateRequest> __Marshaller_bgs_protocol_authentication_v1_LogonUpdateRequest = Marshallers.Create<LogonUpdateRequest>(new Action<LogonUpdateRequest, SerializationContext>(AuthenticationListener.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationListener.__Helper_DeserializeMessage<LogonUpdateRequest>(context, LogonUpdateRequest.Parser));

		// Token: 0x040041F2 RID: 16882
		private static readonly Marshaller<VersionInfoNotification> __Marshaller_bgs_protocol_authentication_v1_VersionInfoNotification = Marshallers.Create<VersionInfoNotification>(new Action<VersionInfoNotification, SerializationContext>(AuthenticationListener.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationListener.__Helper_DeserializeMessage<VersionInfoNotification>(context, VersionInfoNotification.Parser));

		// Token: 0x040041F3 RID: 16883
		private static readonly Marshaller<LogonQueueUpdateRequest> __Marshaller_bgs_protocol_authentication_v1_LogonQueueUpdateRequest = Marshallers.Create<LogonQueueUpdateRequest>(new Action<LogonQueueUpdateRequest, SerializationContext>(AuthenticationListener.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationListener.__Helper_DeserializeMessage<LogonQueueUpdateRequest>(context, LogonQueueUpdateRequest.Parser));

		// Token: 0x040041F4 RID: 16884
		private static readonly Marshaller<GameAccountSelectedRequest> __Marshaller_bgs_protocol_authentication_v1_GameAccountSelectedRequest = Marshallers.Create<GameAccountSelectedRequest>(new Action<GameAccountSelectedRequest, SerializationContext>(AuthenticationListener.__Helper_SerializeMessage), (DeserializationContext context) => AuthenticationListener.__Helper_DeserializeMessage<GameAccountSelectedRequest>(context, GameAccountSelectedRequest.Parser));

		// Token: 0x040041F5 RID: 16885
		private static readonly Method<ModuleLoadRequest, NO_RESPONSE> __Method_OnModuleLoad = new Method<ModuleLoadRequest, NO_RESPONSE>(0, AuthenticationListener.__ServiceName, "OnModuleLoad", AuthenticationListener.__Marshaller_bgs_protocol_authentication_v1_ModuleLoadRequest, AuthenticationListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x040041F6 RID: 16886
		private static readonly Method<ModuleMessageRequest, NoData> __Method_OnModuleMessage = new Method<ModuleMessageRequest, NoData>(0, AuthenticationListener.__ServiceName, "OnModuleMessage", AuthenticationListener.__Marshaller_bgs_protocol_authentication_v1_ModuleMessageRequest, AuthenticationListener.__Marshaller_bgs_protocol_NoData);

		// Token: 0x040041F7 RID: 16887
		private static readonly Method<ServerStateChangeRequest, NO_RESPONSE> __Method_OnServerStateChange = new Method<ServerStateChangeRequest, NO_RESPONSE>(0, AuthenticationListener.__ServiceName, "OnServerStateChange", AuthenticationListener.__Marshaller_bgs_protocol_authentication_v1_ServerStateChangeRequest, AuthenticationListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x040041F8 RID: 16888
		private static readonly Method<LogonResult, NO_RESPONSE> __Method_OnLogonComplete = new Method<LogonResult, NO_RESPONSE>(0, AuthenticationListener.__ServiceName, "OnLogonComplete", AuthenticationListener.__Marshaller_bgs_protocol_authentication_v1_LogonResult, AuthenticationListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x040041F9 RID: 16889
		private static readonly Method<MemModuleLoadRequest, MemModuleLoadResponse> __Method_OnMemModuleLoad = new Method<MemModuleLoadRequest, MemModuleLoadResponse>(0, AuthenticationListener.__ServiceName, "OnMemModuleLoad", AuthenticationListener.__Marshaller_bgs_protocol_authentication_v1_MemModuleLoadRequest, AuthenticationListener.__Marshaller_bgs_protocol_authentication_v1_MemModuleLoadResponse);

		// Token: 0x040041FA RID: 16890
		private static readonly Method<LogonUpdateRequest, NO_RESPONSE> __Method_OnLogonUpdate = new Method<LogonUpdateRequest, NO_RESPONSE>(0, AuthenticationListener.__ServiceName, "OnLogonUpdate", AuthenticationListener.__Marshaller_bgs_protocol_authentication_v1_LogonUpdateRequest, AuthenticationListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x040041FB RID: 16891
		private static readonly Method<VersionInfoNotification, NO_RESPONSE> __Method_OnVersionInfoUpdated = new Method<VersionInfoNotification, NO_RESPONSE>(0, AuthenticationListener.__ServiceName, "OnVersionInfoUpdated", AuthenticationListener.__Marshaller_bgs_protocol_authentication_v1_VersionInfoNotification, AuthenticationListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x040041FC RID: 16892
		private static readonly Method<LogonQueueUpdateRequest, NO_RESPONSE> __Method_OnLogonQueueUpdate = new Method<LogonQueueUpdateRequest, NO_RESPONSE>(0, AuthenticationListener.__ServiceName, "OnLogonQueueUpdate", AuthenticationListener.__Marshaller_bgs_protocol_authentication_v1_LogonQueueUpdateRequest, AuthenticationListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x040041FD RID: 16893
		private static readonly Method<NoData, NO_RESPONSE> __Method_OnLogonQueueEnd = new Method<NoData, NO_RESPONSE>(0, AuthenticationListener.__ServiceName, "OnLogonQueueEnd", AuthenticationListener.__Marshaller_bgs_protocol_NoData, AuthenticationListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x040041FE RID: 16894
		private static readonly Method<GameAccountSelectedRequest, NO_RESPONSE> __Method_OnGameAccountSelected = new Method<GameAccountSelectedRequest, NO_RESPONSE>(0, AuthenticationListener.__ServiceName, "OnGameAccountSelected", AuthenticationListener.__Marshaller_bgs_protocol_authentication_v1_GameAccountSelectedRequest, AuthenticationListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x02001104 RID: 4356
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x04009843 RID: 38979
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02001105 RID: 4357
		[BindServiceMethod(typeof(AuthenticationListener), "BindService")]
		public abstract class AuthenticationListenerBase
		{
			// Token: 0x0600D4C8 RID: 54472 RVA: 0x004B4A12 File Offset: 0x004B2C12
			public virtual Task<NO_RESPONSE> OnModuleLoad(ModuleLoadRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D4C9 RID: 54473 RVA: 0x004B4A26 File Offset: 0x004B2C26
			public virtual Task<NoData> OnModuleMessage(ModuleMessageRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D4CA RID: 54474 RVA: 0x004B4A3A File Offset: 0x004B2C3A
			public virtual Task<NO_RESPONSE> OnServerStateChange(ServerStateChangeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D4CB RID: 54475 RVA: 0x004B4A4E File Offset: 0x004B2C4E
			public virtual Task<NO_RESPONSE> OnLogonComplete(LogonResult request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D4CC RID: 54476 RVA: 0x004B4A62 File Offset: 0x004B2C62
			public virtual Task<MemModuleLoadResponse> OnMemModuleLoad(MemModuleLoadRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D4CD RID: 54477 RVA: 0x004B4A76 File Offset: 0x004B2C76
			public virtual Task<NO_RESPONSE> OnLogonUpdate(LogonUpdateRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D4CE RID: 54478 RVA: 0x004B4A8A File Offset: 0x004B2C8A
			public virtual Task<NO_RESPONSE> OnVersionInfoUpdated(VersionInfoNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D4CF RID: 54479 RVA: 0x004B4A9E File Offset: 0x004B2C9E
			public virtual Task<NO_RESPONSE> OnLogonQueueUpdate(LogonQueueUpdateRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D4D0 RID: 54480 RVA: 0x004B4AB2 File Offset: 0x004B2CB2
			public virtual Task<NO_RESPONSE> OnLogonQueueEnd(NoData request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D4D1 RID: 54481 RVA: 0x004B4AC6 File Offset: 0x004B2CC6
			public virtual Task<NO_RESPONSE> OnGameAccountSelected(GameAccountSelectedRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x02001106 RID: 4358
		public class AuthenticationListenerClient : ClientBase<AuthenticationListener.AuthenticationListenerClient>
		{
			// Token: 0x0600D4D3 RID: 54483 RVA: 0x004B4AE3 File Offset: 0x004B2CE3
			public AuthenticationListenerClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D4D4 RID: 54484 RVA: 0x004B4AEE File Offset: 0x004B2CEE
			public AuthenticationListenerClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D4D5 RID: 54485 RVA: 0x004B4AF9 File Offset: 0x004B2CF9
			protected AuthenticationListenerClient()
			{
			}

			// Token: 0x0600D4D6 RID: 54486 RVA: 0x004B4B03 File Offset: 0x004B2D03
			protected AuthenticationListenerClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D4D7 RID: 54487 RVA: 0x004B4B10 File Offset: 0x004B2D10
			public virtual NO_RESPONSE OnModuleLoad(ModuleLoadRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnModuleLoad(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D4D8 RID: 54488 RVA: 0x004B4B38 File Offset: 0x004B2D38
			public virtual NO_RESPONSE OnModuleLoad(ModuleLoadRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ModuleLoadRequest, NO_RESPONSE>(AuthenticationListener.__Method_OnModuleLoad, null, options, request);
			}

			// Token: 0x0600D4D9 RID: 54489 RVA: 0x004B4B60 File Offset: 0x004B2D60
			public virtual AsyncUnaryCall<NO_RESPONSE> OnModuleLoadAsync(ModuleLoadRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnModuleLoadAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D4DA RID: 54490 RVA: 0x004B4B88 File Offset: 0x004B2D88
			public virtual AsyncUnaryCall<NO_RESPONSE> OnModuleLoadAsync(ModuleLoadRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ModuleLoadRequest, NO_RESPONSE>(AuthenticationListener.__Method_OnModuleLoad, null, options, request);
			}

			// Token: 0x0600D4DB RID: 54491 RVA: 0x004B4BB0 File Offset: 0x004B2DB0
			public virtual NoData OnModuleMessage(ModuleMessageRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnModuleMessage(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D4DC RID: 54492 RVA: 0x004B4BD8 File Offset: 0x004B2DD8
			public virtual NoData OnModuleMessage(ModuleMessageRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ModuleMessageRequest, NoData>(AuthenticationListener.__Method_OnModuleMessage, null, options, request);
			}

			// Token: 0x0600D4DD RID: 54493 RVA: 0x004B4C00 File Offset: 0x004B2E00
			public virtual AsyncUnaryCall<NoData> OnModuleMessageAsync(ModuleMessageRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnModuleMessageAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D4DE RID: 54494 RVA: 0x004B4C28 File Offset: 0x004B2E28
			public virtual AsyncUnaryCall<NoData> OnModuleMessageAsync(ModuleMessageRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ModuleMessageRequest, NoData>(AuthenticationListener.__Method_OnModuleMessage, null, options, request);
			}

			// Token: 0x0600D4DF RID: 54495 RVA: 0x004B4C50 File Offset: 0x004B2E50
			public virtual NO_RESPONSE OnServerStateChange(ServerStateChangeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnServerStateChange(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D4E0 RID: 54496 RVA: 0x004B4C78 File Offset: 0x004B2E78
			public virtual NO_RESPONSE OnServerStateChange(ServerStateChangeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ServerStateChangeRequest, NO_RESPONSE>(AuthenticationListener.__Method_OnServerStateChange, null, options, request);
			}

			// Token: 0x0600D4E1 RID: 54497 RVA: 0x004B4CA0 File Offset: 0x004B2EA0
			public virtual AsyncUnaryCall<NO_RESPONSE> OnServerStateChangeAsync(ServerStateChangeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnServerStateChangeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D4E2 RID: 54498 RVA: 0x004B4CC8 File Offset: 0x004B2EC8
			public virtual AsyncUnaryCall<NO_RESPONSE> OnServerStateChangeAsync(ServerStateChangeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ServerStateChangeRequest, NO_RESPONSE>(AuthenticationListener.__Method_OnServerStateChange, null, options, request);
			}

			// Token: 0x0600D4E3 RID: 54499 RVA: 0x004B4CF0 File Offset: 0x004B2EF0
			public virtual NO_RESPONSE OnLogonComplete(LogonResult request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnLogonComplete(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D4E4 RID: 54500 RVA: 0x004B4D18 File Offset: 0x004B2F18
			public virtual NO_RESPONSE OnLogonComplete(LogonResult request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<LogonResult, NO_RESPONSE>(AuthenticationListener.__Method_OnLogonComplete, null, options, request);
			}

			// Token: 0x0600D4E5 RID: 54501 RVA: 0x004B4D40 File Offset: 0x004B2F40
			public virtual AsyncUnaryCall<NO_RESPONSE> OnLogonCompleteAsync(LogonResult request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnLogonCompleteAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D4E6 RID: 54502 RVA: 0x004B4D68 File Offset: 0x004B2F68
			public virtual AsyncUnaryCall<NO_RESPONSE> OnLogonCompleteAsync(LogonResult request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<LogonResult, NO_RESPONSE>(AuthenticationListener.__Method_OnLogonComplete, null, options, request);
			}

			// Token: 0x0600D4E7 RID: 54503 RVA: 0x004B4D90 File Offset: 0x004B2F90
			public virtual MemModuleLoadResponse OnMemModuleLoad(MemModuleLoadRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnMemModuleLoad(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D4E8 RID: 54504 RVA: 0x004B4DB8 File Offset: 0x004B2FB8
			public virtual MemModuleLoadResponse OnMemModuleLoad(MemModuleLoadRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<MemModuleLoadRequest, MemModuleLoadResponse>(AuthenticationListener.__Method_OnMemModuleLoad, null, options, request);
			}

			// Token: 0x0600D4E9 RID: 54505 RVA: 0x004B4DE0 File Offset: 0x004B2FE0
			public virtual AsyncUnaryCall<MemModuleLoadResponse> OnMemModuleLoadAsync(MemModuleLoadRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnMemModuleLoadAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D4EA RID: 54506 RVA: 0x004B4E08 File Offset: 0x004B3008
			public virtual AsyncUnaryCall<MemModuleLoadResponse> OnMemModuleLoadAsync(MemModuleLoadRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<MemModuleLoadRequest, MemModuleLoadResponse>(AuthenticationListener.__Method_OnMemModuleLoad, null, options, request);
			}

			// Token: 0x0600D4EB RID: 54507 RVA: 0x004B4E30 File Offset: 0x004B3030
			public virtual NO_RESPONSE OnLogonUpdate(LogonUpdateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnLogonUpdate(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D4EC RID: 54508 RVA: 0x004B4E58 File Offset: 0x004B3058
			public virtual NO_RESPONSE OnLogonUpdate(LogonUpdateRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<LogonUpdateRequest, NO_RESPONSE>(AuthenticationListener.__Method_OnLogonUpdate, null, options, request);
			}

			// Token: 0x0600D4ED RID: 54509 RVA: 0x004B4E80 File Offset: 0x004B3080
			public virtual AsyncUnaryCall<NO_RESPONSE> OnLogonUpdateAsync(LogonUpdateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnLogonUpdateAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D4EE RID: 54510 RVA: 0x004B4EA8 File Offset: 0x004B30A8
			public virtual AsyncUnaryCall<NO_RESPONSE> OnLogonUpdateAsync(LogonUpdateRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<LogonUpdateRequest, NO_RESPONSE>(AuthenticationListener.__Method_OnLogonUpdate, null, options, request);
			}

			// Token: 0x0600D4EF RID: 54511 RVA: 0x004B4ED0 File Offset: 0x004B30D0
			public virtual NO_RESPONSE OnVersionInfoUpdated(VersionInfoNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnVersionInfoUpdated(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D4F0 RID: 54512 RVA: 0x004B4EF8 File Offset: 0x004B30F8
			public virtual NO_RESPONSE OnVersionInfoUpdated(VersionInfoNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<VersionInfoNotification, NO_RESPONSE>(AuthenticationListener.__Method_OnVersionInfoUpdated, null, options, request);
			}

			// Token: 0x0600D4F1 RID: 54513 RVA: 0x004B4F20 File Offset: 0x004B3120
			public virtual AsyncUnaryCall<NO_RESPONSE> OnVersionInfoUpdatedAsync(VersionInfoNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnVersionInfoUpdatedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D4F2 RID: 54514 RVA: 0x004B4F48 File Offset: 0x004B3148
			public virtual AsyncUnaryCall<NO_RESPONSE> OnVersionInfoUpdatedAsync(VersionInfoNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<VersionInfoNotification, NO_RESPONSE>(AuthenticationListener.__Method_OnVersionInfoUpdated, null, options, request);
			}

			// Token: 0x0600D4F3 RID: 54515 RVA: 0x004B4F70 File Offset: 0x004B3170
			public virtual NO_RESPONSE OnLogonQueueUpdate(LogonQueueUpdateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnLogonQueueUpdate(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D4F4 RID: 54516 RVA: 0x004B4F98 File Offset: 0x004B3198
			public virtual NO_RESPONSE OnLogonQueueUpdate(LogonQueueUpdateRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<LogonQueueUpdateRequest, NO_RESPONSE>(AuthenticationListener.__Method_OnLogonQueueUpdate, null, options, request);
			}

			// Token: 0x0600D4F5 RID: 54517 RVA: 0x004B4FC0 File Offset: 0x004B31C0
			public virtual AsyncUnaryCall<NO_RESPONSE> OnLogonQueueUpdateAsync(LogonQueueUpdateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnLogonQueueUpdateAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D4F6 RID: 54518 RVA: 0x004B4FE8 File Offset: 0x004B31E8
			public virtual AsyncUnaryCall<NO_RESPONSE> OnLogonQueueUpdateAsync(LogonQueueUpdateRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<LogonQueueUpdateRequest, NO_RESPONSE>(AuthenticationListener.__Method_OnLogonQueueUpdate, null, options, request);
			}

			// Token: 0x0600D4F7 RID: 54519 RVA: 0x004B5010 File Offset: 0x004B3210
			public virtual NO_RESPONSE OnLogonQueueEnd(NoData request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnLogonQueueEnd(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D4F8 RID: 54520 RVA: 0x004B5038 File Offset: 0x004B3238
			public virtual NO_RESPONSE OnLogonQueueEnd(NoData request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<NoData, NO_RESPONSE>(AuthenticationListener.__Method_OnLogonQueueEnd, null, options, request);
			}

			// Token: 0x0600D4F9 RID: 54521 RVA: 0x004B5060 File Offset: 0x004B3260
			public virtual AsyncUnaryCall<NO_RESPONSE> OnLogonQueueEndAsync(NoData request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnLogonQueueEndAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D4FA RID: 54522 RVA: 0x004B5088 File Offset: 0x004B3288
			public virtual AsyncUnaryCall<NO_RESPONSE> OnLogonQueueEndAsync(NoData request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<NoData, NO_RESPONSE>(AuthenticationListener.__Method_OnLogonQueueEnd, null, options, request);
			}

			// Token: 0x0600D4FB RID: 54523 RVA: 0x004B50B0 File Offset: 0x004B32B0
			public virtual NO_RESPONSE OnGameAccountSelected(GameAccountSelectedRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnGameAccountSelected(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D4FC RID: 54524 RVA: 0x004B50D8 File Offset: 0x004B32D8
			public virtual NO_RESPONSE OnGameAccountSelected(GameAccountSelectedRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GameAccountSelectedRequest, NO_RESPONSE>(AuthenticationListener.__Method_OnGameAccountSelected, null, options, request);
			}

			// Token: 0x0600D4FD RID: 54525 RVA: 0x004B5100 File Offset: 0x004B3300
			public virtual AsyncUnaryCall<NO_RESPONSE> OnGameAccountSelectedAsync(GameAccountSelectedRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnGameAccountSelectedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D4FE RID: 54526 RVA: 0x004B5128 File Offset: 0x004B3328
			public virtual AsyncUnaryCall<NO_RESPONSE> OnGameAccountSelectedAsync(GameAccountSelectedRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GameAccountSelectedRequest, NO_RESPONSE>(AuthenticationListener.__Method_OnGameAccountSelected, null, options, request);
			}

			// Token: 0x0600D4FF RID: 54527 RVA: 0x004B5150 File Offset: 0x004B3350
			protected override AuthenticationListener.AuthenticationListenerClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new AuthenticationListener.AuthenticationListenerClient(configuration);
			}
		}
	}
}
