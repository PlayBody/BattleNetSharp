using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.GameUtilities.V1
{
	// Token: 0x020005ED RID: 1517
	public static class GameUtilitiesService
	{
		// Token: 0x06008E99 RID: 36505 RVA: 0x00229770 File Offset: 0x00227970
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

		// Token: 0x06008E9A RID: 36506 RVA: 0x002297BC File Offset: 0x002279BC
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = GameUtilitiesService.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17002CA3 RID: 11427
		// (get) Token: 0x06008E9B RID: 36507 RVA: 0x002297F4 File Offset: 0x002279F4
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x06008E9C RID: 36508 RVA: 0x00229818 File Offset: 0x00227A18
		public static ServerServiceDefinition BindService(GameUtilitiesService.GameUtilitiesServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<ClientRequest, ClientResponse>(GameUtilitiesService.__Method_ProcessClientRequest, new UnaryServerMethod<ClientRequest, ClientResponse>(serviceImpl.ProcessClientRequest)).AddMethod<PresenceChannelCreatedRequest, NoData>(GameUtilitiesService.__Method_PresenceChannelCreated, new UnaryServerMethod<PresenceChannelCreatedRequest, NoData>(serviceImpl.PresenceChannelCreated))
				.AddMethod<GetPlayerVariablesRequest, GetPlayerVariablesResponse>(GameUtilitiesService.__Method_GetPlayerVariables, new UnaryServerMethod<GetPlayerVariablesRequest, GetPlayerVariablesResponse>(serviceImpl.GetPlayerVariables))
				.AddMethod<ServerRequest, ServerResponse>(GameUtilitiesService.__Method_ProcessServerRequest, new UnaryServerMethod<ServerRequest, ServerResponse>(serviceImpl.ProcessServerRequest))
				.AddMethod<GameAccountOnlineNotification, NO_RESPONSE>(GameUtilitiesService.__Method_OnGameAccountOnline, new UnaryServerMethod<GameAccountOnlineNotification, NO_RESPONSE>(serviceImpl.OnGameAccountOnline))
				.AddMethod<GameAccountOfflineNotification, NO_RESPONSE>(GameUtilitiesService.__Method_OnGameAccountOffline, new UnaryServerMethod<GameAccountOfflineNotification, NO_RESPONSE>(serviceImpl.OnGameAccountOffline))
				.AddMethod<GetAchievementsFileRequest, GetAchievementsFileResponse>(GameUtilitiesService.__Method_GetAchievementsFile, new UnaryServerMethod<GetAchievementsFileRequest, GetAchievementsFileResponse>(serviceImpl.GetAchievementsFile))
				.AddMethod<GetAllValuesForAttributeRequest, GetAllValuesForAttributeResponse>(GameUtilitiesService.__Method_GetAllValuesForAttribute, new UnaryServerMethod<GetAllValuesForAttributeRequest, GetAllValuesForAttributeResponse>(serviceImpl.GetAllValuesForAttribute))
				.Build();
		}

		// Token: 0x06008E9D RID: 36509 RVA: 0x002298EC File Offset: 0x00227AEC
		public static void BindService(ServiceBinderBase serviceBinder, GameUtilitiesService.GameUtilitiesServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<ClientRequest, ClientResponse>(GameUtilitiesService.__Method_ProcessClientRequest, (serviceImpl == null) ? null : new UnaryServerMethod<ClientRequest, ClientResponse>(serviceImpl.ProcessClientRequest));
			serviceBinder.AddMethod<PresenceChannelCreatedRequest, NoData>(GameUtilitiesService.__Method_PresenceChannelCreated, (serviceImpl == null) ? null : new UnaryServerMethod<PresenceChannelCreatedRequest, NoData>(serviceImpl.PresenceChannelCreated));
			serviceBinder.AddMethod<GetPlayerVariablesRequest, GetPlayerVariablesResponse>(GameUtilitiesService.__Method_GetPlayerVariables, (serviceImpl == null) ? null : new UnaryServerMethod<GetPlayerVariablesRequest, GetPlayerVariablesResponse>(serviceImpl.GetPlayerVariables));
			serviceBinder.AddMethod<ServerRequest, ServerResponse>(GameUtilitiesService.__Method_ProcessServerRequest, (serviceImpl == null) ? null : new UnaryServerMethod<ServerRequest, ServerResponse>(serviceImpl.ProcessServerRequest));
			serviceBinder.AddMethod<GameAccountOnlineNotification, NO_RESPONSE>(GameUtilitiesService.__Method_OnGameAccountOnline, (serviceImpl == null) ? null : new UnaryServerMethod<GameAccountOnlineNotification, NO_RESPONSE>(serviceImpl.OnGameAccountOnline));
			serviceBinder.AddMethod<GameAccountOfflineNotification, NO_RESPONSE>(GameUtilitiesService.__Method_OnGameAccountOffline, (serviceImpl == null) ? null : new UnaryServerMethod<GameAccountOfflineNotification, NO_RESPONSE>(serviceImpl.OnGameAccountOffline));
			serviceBinder.AddMethod<GetAchievementsFileRequest, GetAchievementsFileResponse>(GameUtilitiesService.__Method_GetAchievementsFile, (serviceImpl == null) ? null : new UnaryServerMethod<GetAchievementsFileRequest, GetAchievementsFileResponse>(serviceImpl.GetAchievementsFile));
			serviceBinder.AddMethod<GetAllValuesForAttributeRequest, GetAllValuesForAttributeResponse>(GameUtilitiesService.__Method_GetAllValuesForAttribute, (serviceImpl == null) ? null : new UnaryServerMethod<GetAllValuesForAttributeRequest, GetAllValuesForAttributeResponse>(serviceImpl.GetAllValuesForAttribute));
		}

		// Token: 0x0400405C RID: 16476
		private static readonly string __ServiceName = "bgs.protocol.game_utilities.v1.GameUtilitiesService";

		// Token: 0x0400405D RID: 16477
		private static readonly Marshaller<ClientRequest> __Marshaller_bgs_protocol_game_utilities_v1_ClientRequest = Marshallers.Create<ClientRequest>(new Action<ClientRequest, SerializationContext>(GameUtilitiesService.__Helper_SerializeMessage), (DeserializationContext context) => GameUtilitiesService.__Helper_DeserializeMessage<ClientRequest>(context, ClientRequest.Parser));

		// Token: 0x0400405E RID: 16478
		private static readonly Marshaller<ClientResponse> __Marshaller_bgs_protocol_game_utilities_v1_ClientResponse = Marshallers.Create<ClientResponse>(new Action<ClientResponse, SerializationContext>(GameUtilitiesService.__Helper_SerializeMessage), (DeserializationContext context) => GameUtilitiesService.__Helper_DeserializeMessage<ClientResponse>(context, ClientResponse.Parser));

		// Token: 0x0400405F RID: 16479
		private static readonly Marshaller<PresenceChannelCreatedRequest> __Marshaller_bgs_protocol_game_utilities_v1_PresenceChannelCreatedRequest = Marshallers.Create<PresenceChannelCreatedRequest>(new Action<PresenceChannelCreatedRequest, SerializationContext>(GameUtilitiesService.__Helper_SerializeMessage), (DeserializationContext context) => GameUtilitiesService.__Helper_DeserializeMessage<PresenceChannelCreatedRequest>(context, PresenceChannelCreatedRequest.Parser));

		// Token: 0x04004060 RID: 16480
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(GameUtilitiesService.__Helper_SerializeMessage), (DeserializationContext context) => GameUtilitiesService.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x04004061 RID: 16481
		private static readonly Marshaller<GetPlayerVariablesRequest> __Marshaller_bgs_protocol_game_utilities_v1_GetPlayerVariablesRequest = Marshallers.Create<GetPlayerVariablesRequest>(new Action<GetPlayerVariablesRequest, SerializationContext>(GameUtilitiesService.__Helper_SerializeMessage), (DeserializationContext context) => GameUtilitiesService.__Helper_DeserializeMessage<GetPlayerVariablesRequest>(context, GetPlayerVariablesRequest.Parser));

		// Token: 0x04004062 RID: 16482
		private static readonly Marshaller<GetPlayerVariablesResponse> __Marshaller_bgs_protocol_game_utilities_v1_GetPlayerVariablesResponse = Marshallers.Create<GetPlayerVariablesResponse>(new Action<GetPlayerVariablesResponse, SerializationContext>(GameUtilitiesService.__Helper_SerializeMessage), (DeserializationContext context) => GameUtilitiesService.__Helper_DeserializeMessage<GetPlayerVariablesResponse>(context, GetPlayerVariablesResponse.Parser));

		// Token: 0x04004063 RID: 16483
		private static readonly Marshaller<ServerRequest> __Marshaller_bgs_protocol_game_utilities_v1_ServerRequest = Marshallers.Create<ServerRequest>(new Action<ServerRequest, SerializationContext>(GameUtilitiesService.__Helper_SerializeMessage), (DeserializationContext context) => GameUtilitiesService.__Helper_DeserializeMessage<ServerRequest>(context, ServerRequest.Parser));

		// Token: 0x04004064 RID: 16484
		private static readonly Marshaller<ServerResponse> __Marshaller_bgs_protocol_game_utilities_v1_ServerResponse = Marshallers.Create<ServerResponse>(new Action<ServerResponse, SerializationContext>(GameUtilitiesService.__Helper_SerializeMessage), (DeserializationContext context) => GameUtilitiesService.__Helper_DeserializeMessage<ServerResponse>(context, ServerResponse.Parser));

		// Token: 0x04004065 RID: 16485
		private static readonly Marshaller<GameAccountOnlineNotification> __Marshaller_bgs_protocol_game_utilities_v1_GameAccountOnlineNotification = Marshallers.Create<GameAccountOnlineNotification>(new Action<GameAccountOnlineNotification, SerializationContext>(GameUtilitiesService.__Helper_SerializeMessage), (DeserializationContext context) => GameUtilitiesService.__Helper_DeserializeMessage<GameAccountOnlineNotification>(context, GameAccountOnlineNotification.Parser));

		// Token: 0x04004066 RID: 16486
		private static readonly Marshaller<NO_RESPONSE> __Marshaller_bgs_protocol_NO_RESPONSE = Marshallers.Create<NO_RESPONSE>(new Action<NO_RESPONSE, SerializationContext>(GameUtilitiesService.__Helper_SerializeMessage), (DeserializationContext context) => GameUtilitiesService.__Helper_DeserializeMessage<NO_RESPONSE>(context, NO_RESPONSE.Parser));

		// Token: 0x04004067 RID: 16487
		private static readonly Marshaller<GameAccountOfflineNotification> __Marshaller_bgs_protocol_game_utilities_v1_GameAccountOfflineNotification = Marshallers.Create<GameAccountOfflineNotification>(new Action<GameAccountOfflineNotification, SerializationContext>(GameUtilitiesService.__Helper_SerializeMessage), (DeserializationContext context) => GameUtilitiesService.__Helper_DeserializeMessage<GameAccountOfflineNotification>(context, GameAccountOfflineNotification.Parser));

		// Token: 0x04004068 RID: 16488
		private static readonly Marshaller<GetAchievementsFileRequest> __Marshaller_bgs_protocol_game_utilities_v1_GetAchievementsFileRequest = Marshallers.Create<GetAchievementsFileRequest>(new Action<GetAchievementsFileRequest, SerializationContext>(GameUtilitiesService.__Helper_SerializeMessage), (DeserializationContext context) => GameUtilitiesService.__Helper_DeserializeMessage<GetAchievementsFileRequest>(context, GetAchievementsFileRequest.Parser));

		// Token: 0x04004069 RID: 16489
		private static readonly Marshaller<GetAchievementsFileResponse> __Marshaller_bgs_protocol_game_utilities_v1_GetAchievementsFileResponse = Marshallers.Create<GetAchievementsFileResponse>(new Action<GetAchievementsFileResponse, SerializationContext>(GameUtilitiesService.__Helper_SerializeMessage), (DeserializationContext context) => GameUtilitiesService.__Helper_DeserializeMessage<GetAchievementsFileResponse>(context, GetAchievementsFileResponse.Parser));

		// Token: 0x0400406A RID: 16490
		private static readonly Marshaller<GetAllValuesForAttributeRequest> __Marshaller_bgs_protocol_game_utilities_v1_GetAllValuesForAttributeRequest = Marshallers.Create<GetAllValuesForAttributeRequest>(new Action<GetAllValuesForAttributeRequest, SerializationContext>(GameUtilitiesService.__Helper_SerializeMessage), (DeserializationContext context) => GameUtilitiesService.__Helper_DeserializeMessage<GetAllValuesForAttributeRequest>(context, GetAllValuesForAttributeRequest.Parser));

		// Token: 0x0400406B RID: 16491
		private static readonly Marshaller<GetAllValuesForAttributeResponse> __Marshaller_bgs_protocol_game_utilities_v1_GetAllValuesForAttributeResponse = Marshallers.Create<GetAllValuesForAttributeResponse>(new Action<GetAllValuesForAttributeResponse, SerializationContext>(GameUtilitiesService.__Helper_SerializeMessage), (DeserializationContext context) => GameUtilitiesService.__Helper_DeserializeMessage<GetAllValuesForAttributeResponse>(context, GetAllValuesForAttributeResponse.Parser));

		// Token: 0x0400406C RID: 16492
		private static readonly Method<ClientRequest, ClientResponse> __Method_ProcessClientRequest = new Method<ClientRequest, ClientResponse>(0, GameUtilitiesService.__ServiceName, "ProcessClientRequest", GameUtilitiesService.__Marshaller_bgs_protocol_game_utilities_v1_ClientRequest, GameUtilitiesService.__Marshaller_bgs_protocol_game_utilities_v1_ClientResponse);

		// Token: 0x0400406D RID: 16493
		private static readonly Method<PresenceChannelCreatedRequest, NoData> __Method_PresenceChannelCreated = new Method<PresenceChannelCreatedRequest, NoData>(0, GameUtilitiesService.__ServiceName, "PresenceChannelCreated", GameUtilitiesService.__Marshaller_bgs_protocol_game_utilities_v1_PresenceChannelCreatedRequest, GameUtilitiesService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x0400406E RID: 16494
		private static readonly Method<GetPlayerVariablesRequest, GetPlayerVariablesResponse> __Method_GetPlayerVariables = new Method<GetPlayerVariablesRequest, GetPlayerVariablesResponse>(0, GameUtilitiesService.__ServiceName, "GetPlayerVariables", GameUtilitiesService.__Marshaller_bgs_protocol_game_utilities_v1_GetPlayerVariablesRequest, GameUtilitiesService.__Marshaller_bgs_protocol_game_utilities_v1_GetPlayerVariablesResponse);

		// Token: 0x0400406F RID: 16495
		private static readonly Method<ServerRequest, ServerResponse> __Method_ProcessServerRequest = new Method<ServerRequest, ServerResponse>(0, GameUtilitiesService.__ServiceName, "ProcessServerRequest", GameUtilitiesService.__Marshaller_bgs_protocol_game_utilities_v1_ServerRequest, GameUtilitiesService.__Marshaller_bgs_protocol_game_utilities_v1_ServerResponse);

		// Token: 0x04004070 RID: 16496
		private static readonly Method<GameAccountOnlineNotification, NO_RESPONSE> __Method_OnGameAccountOnline = new Method<GameAccountOnlineNotification, NO_RESPONSE>(0, GameUtilitiesService.__ServiceName, "OnGameAccountOnline", GameUtilitiesService.__Marshaller_bgs_protocol_game_utilities_v1_GameAccountOnlineNotification, GameUtilitiesService.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04004071 RID: 16497
		private static readonly Method<GameAccountOfflineNotification, NO_RESPONSE> __Method_OnGameAccountOffline = new Method<GameAccountOfflineNotification, NO_RESPONSE>(0, GameUtilitiesService.__ServiceName, "OnGameAccountOffline", GameUtilitiesService.__Marshaller_bgs_protocol_game_utilities_v1_GameAccountOfflineNotification, GameUtilitiesService.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04004072 RID: 16498
		private static readonly Method<GetAchievementsFileRequest, GetAchievementsFileResponse> __Method_GetAchievementsFile = new Method<GetAchievementsFileRequest, GetAchievementsFileResponse>(0, GameUtilitiesService.__ServiceName, "GetAchievementsFile", GameUtilitiesService.__Marshaller_bgs_protocol_game_utilities_v1_GetAchievementsFileRequest, GameUtilitiesService.__Marshaller_bgs_protocol_game_utilities_v1_GetAchievementsFileResponse);

		// Token: 0x04004073 RID: 16499
		private static readonly Method<GetAllValuesForAttributeRequest, GetAllValuesForAttributeResponse> __Method_GetAllValuesForAttribute = new Method<GetAllValuesForAttributeRequest, GetAllValuesForAttributeResponse>(0, GameUtilitiesService.__ServiceName, "GetAllValuesForAttribute", GameUtilitiesService.__Marshaller_bgs_protocol_game_utilities_v1_GetAllValuesForAttributeRequest, GameUtilitiesService.__Marshaller_bgs_protocol_game_utilities_v1_GetAllValuesForAttributeResponse);

		// Token: 0x020010D4 RID: 4308
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x04009819 RID: 38937
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x020010D5 RID: 4309
		[BindServiceMethod(typeof(GameUtilitiesService), "BindService")]
		public abstract class GameUtilitiesServiceBase
		{
			// Token: 0x0600D3E7 RID: 54247 RVA: 0x004B3A24 File Offset: 0x004B1C24
			public virtual Task<ClientResponse> ProcessClientRequest(ClientRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D3E8 RID: 54248 RVA: 0x004B3A38 File Offset: 0x004B1C38
			public virtual Task<NoData> PresenceChannelCreated(PresenceChannelCreatedRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D3E9 RID: 54249 RVA: 0x004B3A4C File Offset: 0x004B1C4C
			public virtual Task<GetPlayerVariablesResponse> GetPlayerVariables(GetPlayerVariablesRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D3EA RID: 54250 RVA: 0x004B3A60 File Offset: 0x004B1C60
			public virtual Task<ServerResponse> ProcessServerRequest(ServerRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D3EB RID: 54251 RVA: 0x004B3A74 File Offset: 0x004B1C74
			public virtual Task<NO_RESPONSE> OnGameAccountOnline(GameAccountOnlineNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D3EC RID: 54252 RVA: 0x004B3A88 File Offset: 0x004B1C88
			public virtual Task<NO_RESPONSE> OnGameAccountOffline(GameAccountOfflineNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D3ED RID: 54253 RVA: 0x004B3A9C File Offset: 0x004B1C9C
			public virtual Task<GetAchievementsFileResponse> GetAchievementsFile(GetAchievementsFileRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D3EE RID: 54254 RVA: 0x004B3AB0 File Offset: 0x004B1CB0
			public virtual Task<GetAllValuesForAttributeResponse> GetAllValuesForAttribute(GetAllValuesForAttributeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x020010D6 RID: 4310
		public class GameUtilitiesServiceClient : ClientBase<GameUtilitiesService.GameUtilitiesServiceClient>
		{
			// Token: 0x0600D3F0 RID: 54256 RVA: 0x004B3ACD File Offset: 0x004B1CCD
			public GameUtilitiesServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D3F1 RID: 54257 RVA: 0x004B3AD8 File Offset: 0x004B1CD8
			public GameUtilitiesServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D3F2 RID: 54258 RVA: 0x004B3AE3 File Offset: 0x004B1CE3
			protected GameUtilitiesServiceClient()
			{
			}

			// Token: 0x0600D3F3 RID: 54259 RVA: 0x004B3AED File Offset: 0x004B1CED
			protected GameUtilitiesServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D3F4 RID: 54260 RVA: 0x004B3AF8 File Offset: 0x004B1CF8
			public virtual ClientResponse ProcessClientRequest(ClientRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ProcessClientRequest(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D3F5 RID: 54261 RVA: 0x004B3B20 File Offset: 0x004B1D20
			public virtual ClientResponse ProcessClientRequest(ClientRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ClientRequest, ClientResponse>(GameUtilitiesService.__Method_ProcessClientRequest, null, options, request);
			}

			// Token: 0x0600D3F6 RID: 54262 RVA: 0x004B3B48 File Offset: 0x004B1D48
			public virtual AsyncUnaryCall<ClientResponse> ProcessClientRequestAsync(ClientRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ProcessClientRequestAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D3F7 RID: 54263 RVA: 0x004B3B70 File Offset: 0x004B1D70
			public virtual AsyncUnaryCall<ClientResponse> ProcessClientRequestAsync(ClientRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ClientRequest, ClientResponse>(GameUtilitiesService.__Method_ProcessClientRequest, null, options, request);
			}

			// Token: 0x0600D3F8 RID: 54264 RVA: 0x004B3B98 File Offset: 0x004B1D98
			public virtual NoData PresenceChannelCreated(PresenceChannelCreatedRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.PresenceChannelCreated(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D3F9 RID: 54265 RVA: 0x004B3BC0 File Offset: 0x004B1DC0
			public virtual NoData PresenceChannelCreated(PresenceChannelCreatedRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<PresenceChannelCreatedRequest, NoData>(GameUtilitiesService.__Method_PresenceChannelCreated, null, options, request);
			}

			// Token: 0x0600D3FA RID: 54266 RVA: 0x004B3BE8 File Offset: 0x004B1DE8
			public virtual AsyncUnaryCall<NoData> PresenceChannelCreatedAsync(PresenceChannelCreatedRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.PresenceChannelCreatedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D3FB RID: 54267 RVA: 0x004B3C10 File Offset: 0x004B1E10
			public virtual AsyncUnaryCall<NoData> PresenceChannelCreatedAsync(PresenceChannelCreatedRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<PresenceChannelCreatedRequest, NoData>(GameUtilitiesService.__Method_PresenceChannelCreated, null, options, request);
			}

			// Token: 0x0600D3FC RID: 54268 RVA: 0x004B3C38 File Offset: 0x004B1E38
			public virtual GetPlayerVariablesResponse GetPlayerVariables(GetPlayerVariablesRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetPlayerVariables(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D3FD RID: 54269 RVA: 0x004B3C60 File Offset: 0x004B1E60
			public virtual GetPlayerVariablesResponse GetPlayerVariables(GetPlayerVariablesRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetPlayerVariablesRequest, GetPlayerVariablesResponse>(GameUtilitiesService.__Method_GetPlayerVariables, null, options, request);
			}

			// Token: 0x0600D3FE RID: 54270 RVA: 0x004B3C88 File Offset: 0x004B1E88
			public virtual AsyncUnaryCall<GetPlayerVariablesResponse> GetPlayerVariablesAsync(GetPlayerVariablesRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetPlayerVariablesAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D3FF RID: 54271 RVA: 0x004B3CB0 File Offset: 0x004B1EB0
			public virtual AsyncUnaryCall<GetPlayerVariablesResponse> GetPlayerVariablesAsync(GetPlayerVariablesRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetPlayerVariablesRequest, GetPlayerVariablesResponse>(GameUtilitiesService.__Method_GetPlayerVariables, null, options, request);
			}

			// Token: 0x0600D400 RID: 54272 RVA: 0x004B3CD8 File Offset: 0x004B1ED8
			public virtual ServerResponse ProcessServerRequest(ServerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ProcessServerRequest(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D401 RID: 54273 RVA: 0x004B3D00 File Offset: 0x004B1F00
			public virtual ServerResponse ProcessServerRequest(ServerRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ServerRequest, ServerResponse>(GameUtilitiesService.__Method_ProcessServerRequest, null, options, request);
			}

			// Token: 0x0600D402 RID: 54274 RVA: 0x004B3D28 File Offset: 0x004B1F28
			public virtual AsyncUnaryCall<ServerResponse> ProcessServerRequestAsync(ServerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ProcessServerRequestAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D403 RID: 54275 RVA: 0x004B3D50 File Offset: 0x004B1F50
			public virtual AsyncUnaryCall<ServerResponse> ProcessServerRequestAsync(ServerRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ServerRequest, ServerResponse>(GameUtilitiesService.__Method_ProcessServerRequest, null, options, request);
			}

			// Token: 0x0600D404 RID: 54276 RVA: 0x004B3D78 File Offset: 0x004B1F78
			public virtual NO_RESPONSE OnGameAccountOnline(GameAccountOnlineNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnGameAccountOnline(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D405 RID: 54277 RVA: 0x004B3DA0 File Offset: 0x004B1FA0
			public virtual NO_RESPONSE OnGameAccountOnline(GameAccountOnlineNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GameAccountOnlineNotification, NO_RESPONSE>(GameUtilitiesService.__Method_OnGameAccountOnline, null, options, request);
			}

			// Token: 0x0600D406 RID: 54278 RVA: 0x004B3DC8 File Offset: 0x004B1FC8
			public virtual AsyncUnaryCall<NO_RESPONSE> OnGameAccountOnlineAsync(GameAccountOnlineNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnGameAccountOnlineAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D407 RID: 54279 RVA: 0x004B3DF0 File Offset: 0x004B1FF0
			public virtual AsyncUnaryCall<NO_RESPONSE> OnGameAccountOnlineAsync(GameAccountOnlineNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GameAccountOnlineNotification, NO_RESPONSE>(GameUtilitiesService.__Method_OnGameAccountOnline, null, options, request);
			}

			// Token: 0x0600D408 RID: 54280 RVA: 0x004B3E18 File Offset: 0x004B2018
			public virtual NO_RESPONSE OnGameAccountOffline(GameAccountOfflineNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnGameAccountOffline(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D409 RID: 54281 RVA: 0x004B3E40 File Offset: 0x004B2040
			public virtual NO_RESPONSE OnGameAccountOffline(GameAccountOfflineNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GameAccountOfflineNotification, NO_RESPONSE>(GameUtilitiesService.__Method_OnGameAccountOffline, null, options, request);
			}

			// Token: 0x0600D40A RID: 54282 RVA: 0x004B3E68 File Offset: 0x004B2068
			public virtual AsyncUnaryCall<NO_RESPONSE> OnGameAccountOfflineAsync(GameAccountOfflineNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnGameAccountOfflineAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D40B RID: 54283 RVA: 0x004B3E90 File Offset: 0x004B2090
			public virtual AsyncUnaryCall<NO_RESPONSE> OnGameAccountOfflineAsync(GameAccountOfflineNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GameAccountOfflineNotification, NO_RESPONSE>(GameUtilitiesService.__Method_OnGameAccountOffline, null, options, request);
			}

			// Token: 0x0600D40C RID: 54284 RVA: 0x004B3EB8 File Offset: 0x004B20B8
			public virtual GetAchievementsFileResponse GetAchievementsFile(GetAchievementsFileRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetAchievementsFile(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D40D RID: 54285 RVA: 0x004B3EE0 File Offset: 0x004B20E0
			public virtual GetAchievementsFileResponse GetAchievementsFile(GetAchievementsFileRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetAchievementsFileRequest, GetAchievementsFileResponse>(GameUtilitiesService.__Method_GetAchievementsFile, null, options, request);
			}

			// Token: 0x0600D40E RID: 54286 RVA: 0x004B3F08 File Offset: 0x004B2108
			public virtual AsyncUnaryCall<GetAchievementsFileResponse> GetAchievementsFileAsync(GetAchievementsFileRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetAchievementsFileAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D40F RID: 54287 RVA: 0x004B3F30 File Offset: 0x004B2130
			public virtual AsyncUnaryCall<GetAchievementsFileResponse> GetAchievementsFileAsync(GetAchievementsFileRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetAchievementsFileRequest, GetAchievementsFileResponse>(GameUtilitiesService.__Method_GetAchievementsFile, null, options, request);
			}

			// Token: 0x0600D410 RID: 54288 RVA: 0x004B3F58 File Offset: 0x004B2158
			public virtual GetAllValuesForAttributeResponse GetAllValuesForAttribute(GetAllValuesForAttributeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetAllValuesForAttribute(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D411 RID: 54289 RVA: 0x004B3F80 File Offset: 0x004B2180
			public virtual GetAllValuesForAttributeResponse GetAllValuesForAttribute(GetAllValuesForAttributeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GetAllValuesForAttributeRequest, GetAllValuesForAttributeResponse>(GameUtilitiesService.__Method_GetAllValuesForAttribute, null, options, request);
			}

			// Token: 0x0600D412 RID: 54290 RVA: 0x004B3FA8 File Offset: 0x004B21A8
			public virtual AsyncUnaryCall<GetAllValuesForAttributeResponse> GetAllValuesForAttributeAsync(GetAllValuesForAttributeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GetAllValuesForAttributeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D413 RID: 54291 RVA: 0x004B3FD0 File Offset: 0x004B21D0
			public virtual AsyncUnaryCall<GetAllValuesForAttributeResponse> GetAllValuesForAttributeAsync(GetAllValuesForAttributeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GetAllValuesForAttributeRequest, GetAllValuesForAttributeResponse>(GameUtilitiesService.__Method_GetAllValuesForAttribute, null, options, request);
			}

			// Token: 0x0600D414 RID: 54292 RVA: 0x004B3FF8 File Offset: 0x004B21F8
			protected override GameUtilitiesService.GameUtilitiesServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new GameUtilitiesService.GameUtilitiesServiceClient(configuration);
			}
		}
	}
}
