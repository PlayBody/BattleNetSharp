using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Bgs.Protocol;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Classic.Protocol.V1.GameVersion
{
	// Token: 0x0200076A RID: 1898
	public static class GameVersion
	{
		// Token: 0x0600AE55 RID: 44629 RVA: 0x002A6EC4 File Offset: 0x002A50C4
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

		// Token: 0x0600AE56 RID: 44630 RVA: 0x002A6F10 File Offset: 0x002A5110
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = GameVersion.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x170035DE RID: 13790
		// (get) Token: 0x0600AE57 RID: 44631 RVA: 0x002A6F48 File Offset: 0x002A5148
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return GameVersionReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x0600AE58 RID: 44632 RVA: 0x002A6F6C File Offset: 0x002A516C
		public static ServerServiceDefinition BindService(GameVersion.GameVersionBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<GameVersionRequest, NoData>(GameVersion.__Method_SetGameVersion, new UnaryServerMethod<GameVersionRequest, NoData>(serviceImpl.SetGameVersion)).AddMethod<GameVersionRequest, GameVersionResponse>(GameVersion.__Method_GameUpdateRequired, new UnaryServerMethod<GameVersionRequest, GameVersionResponse>(serviceImpl.GameUpdateRequired))
				.AddMethod<GameVersionRequest, GameVersionResponse>(GameVersion.__Method_GameUpdateCanceled, new UnaryServerMethod<GameVersionRequest, GameVersionResponse>(serviceImpl.GameUpdateCanceled))
				.Build();
		}

		// Token: 0x0600AE59 RID: 44633 RVA: 0x002A6FD0 File Offset: 0x002A51D0
		public static void BindService(ServiceBinderBase serviceBinder, GameVersion.GameVersionBase serviceImpl)
		{
			serviceBinder.AddMethod<GameVersionRequest, NoData>(GameVersion.__Method_SetGameVersion, (serviceImpl == null) ? null : new UnaryServerMethod<GameVersionRequest, NoData>(serviceImpl.SetGameVersion));
			serviceBinder.AddMethod<GameVersionRequest, GameVersionResponse>(GameVersion.__Method_GameUpdateRequired, (serviceImpl == null) ? null : new UnaryServerMethod<GameVersionRequest, GameVersionResponse>(serviceImpl.GameUpdateRequired));
			serviceBinder.AddMethod<GameVersionRequest, GameVersionResponse>(GameVersion.__Method_GameUpdateCanceled, (serviceImpl == null) ? null : new UnaryServerMethod<GameVersionRequest, GameVersionResponse>(serviceImpl.GameUpdateCanceled));
		}

		// Token: 0x04004E8A RID: 20106
		private static readonly string __ServiceName = "classic.protocol.v1.game_version.GameVersion";

		// Token: 0x04004E8B RID: 20107
		private static readonly Marshaller<GameVersionRequest> __Marshaller_classic_protocol_v1_game_version_GameVersionRequest = Marshallers.Create<GameVersionRequest>(new Action<GameVersionRequest, SerializationContext>(GameVersion.__Helper_SerializeMessage), (DeserializationContext context) => GameVersion.__Helper_DeserializeMessage<GameVersionRequest>(context, GameVersionRequest.Parser));

		// Token: 0x04004E8C RID: 20108
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(GameVersion.__Helper_SerializeMessage), (DeserializationContext context) => GameVersion.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x04004E8D RID: 20109
		private static readonly Marshaller<GameVersionResponse> __Marshaller_classic_protocol_v1_game_version_GameVersionResponse = Marshallers.Create<GameVersionResponse>(new Action<GameVersionResponse, SerializationContext>(GameVersion.__Helper_SerializeMessage), (DeserializationContext context) => GameVersion.__Helper_DeserializeMessage<GameVersionResponse>(context, GameVersionResponse.Parser));

		// Token: 0x04004E8E RID: 20110
		private static readonly Method<GameVersionRequest, NoData> __Method_SetGameVersion = new Method<GameVersionRequest, NoData>(0, GameVersion.__ServiceName, "SetGameVersion", GameVersion.__Marshaller_classic_protocol_v1_game_version_GameVersionRequest, GameVersion.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04004E8F RID: 20111
		private static readonly Method<GameVersionRequest, GameVersionResponse> __Method_GameUpdateRequired = new Method<GameVersionRequest, GameVersionResponse>(0, GameVersion.__ServiceName, "GameUpdateRequired", GameVersion.__Marshaller_classic_protocol_v1_game_version_GameVersionRequest, GameVersion.__Marshaller_classic_protocol_v1_game_version_GameVersionResponse);

		// Token: 0x04004E90 RID: 20112
		private static readonly Method<GameVersionRequest, GameVersionResponse> __Method_GameUpdateCanceled = new Method<GameVersionRequest, GameVersionResponse>(0, GameVersion.__ServiceName, "GameUpdateCanceled", GameVersion.__Marshaller_classic_protocol_v1_game_version_GameVersionRequest, GameVersion.__Marshaller_classic_protocol_v1_game_version_GameVersionResponse);

		// Token: 0x02001286 RID: 4742
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x040099A0 RID: 39328
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02001287 RID: 4743
		[BindServiceMethod(typeof(GameVersion), "BindService")]
		public abstract class GameVersionBase
		{
			// Token: 0x0600DCD8 RID: 56536 RVA: 0x004BF20E File Offset: 0x004BD40E
			public virtual Task<NoData> SetGameVersion(GameVersionRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600DCD9 RID: 56537 RVA: 0x004BF222 File Offset: 0x004BD422
			public virtual Task<GameVersionResponse> GameUpdateRequired(GameVersionRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600DCDA RID: 56538 RVA: 0x004BF236 File Offset: 0x004BD436
			public virtual Task<GameVersionResponse> GameUpdateCanceled(GameVersionRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x02001288 RID: 4744
		public class GameVersionClient : ClientBase<GameVersion.GameVersionClient>
		{
			// Token: 0x0600DCDC RID: 56540 RVA: 0x004BF253 File Offset: 0x004BD453
			public GameVersionClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600DCDD RID: 56541 RVA: 0x004BF25E File Offset: 0x004BD45E
			public GameVersionClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600DCDE RID: 56542 RVA: 0x004BF269 File Offset: 0x004BD469
			protected GameVersionClient()
			{
			}

			// Token: 0x0600DCDF RID: 56543 RVA: 0x004BF273 File Offset: 0x004BD473
			protected GameVersionClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600DCE0 RID: 56544 RVA: 0x004BF280 File Offset: 0x004BD480
			public virtual NoData SetGameVersion(GameVersionRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SetGameVersion(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DCE1 RID: 56545 RVA: 0x004BF2A8 File Offset: 0x004BD4A8
			public virtual NoData SetGameVersion(GameVersionRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GameVersionRequest, NoData>(GameVersion.__Method_SetGameVersion, null, options, request);
			}

			// Token: 0x0600DCE2 RID: 56546 RVA: 0x004BF2D0 File Offset: 0x004BD4D0
			public virtual AsyncUnaryCall<NoData> SetGameVersionAsync(GameVersionRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SetGameVersionAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DCE3 RID: 56547 RVA: 0x004BF2F8 File Offset: 0x004BD4F8
			public virtual AsyncUnaryCall<NoData> SetGameVersionAsync(GameVersionRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GameVersionRequest, NoData>(GameVersion.__Method_SetGameVersion, null, options, request);
			}

			// Token: 0x0600DCE4 RID: 56548 RVA: 0x004BF320 File Offset: 0x004BD520
			public virtual GameVersionResponse GameUpdateRequired(GameVersionRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GameUpdateRequired(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DCE5 RID: 56549 RVA: 0x004BF348 File Offset: 0x004BD548
			public virtual GameVersionResponse GameUpdateRequired(GameVersionRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GameVersionRequest, GameVersionResponse>(GameVersion.__Method_GameUpdateRequired, null, options, request);
			}

			// Token: 0x0600DCE6 RID: 56550 RVA: 0x004BF370 File Offset: 0x004BD570
			public virtual AsyncUnaryCall<GameVersionResponse> GameUpdateRequiredAsync(GameVersionRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GameUpdateRequiredAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DCE7 RID: 56551 RVA: 0x004BF398 File Offset: 0x004BD598
			public virtual AsyncUnaryCall<GameVersionResponse> GameUpdateRequiredAsync(GameVersionRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GameVersionRequest, GameVersionResponse>(GameVersion.__Method_GameUpdateRequired, null, options, request);
			}

			// Token: 0x0600DCE8 RID: 56552 RVA: 0x004BF3C0 File Offset: 0x004BD5C0
			public virtual GameVersionResponse GameUpdateCanceled(GameVersionRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GameUpdateCanceled(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DCE9 RID: 56553 RVA: 0x004BF3E8 File Offset: 0x004BD5E8
			public virtual GameVersionResponse GameUpdateCanceled(GameVersionRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GameVersionRequest, GameVersionResponse>(GameVersion.__Method_GameUpdateCanceled, null, options, request);
			}

			// Token: 0x0600DCEA RID: 56554 RVA: 0x004BF410 File Offset: 0x004BD610
			public virtual AsyncUnaryCall<GameVersionResponse> GameUpdateCanceledAsync(GameVersionRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.GameUpdateCanceledAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DCEB RID: 56555 RVA: 0x004BF438 File Offset: 0x004BD638
			public virtual AsyncUnaryCall<GameVersionResponse> GameUpdateCanceledAsync(GameVersionRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GameVersionRequest, GameVersionResponse>(GameVersion.__Method_GameUpdateCanceled, null, options, request);
			}

			// Token: 0x0600DCEC RID: 56556 RVA: 0x004BF460 File Offset: 0x004BD660
			protected override GameVersion.GameVersionClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new GameVersion.GameVersionClient(configuration);
			}
		}
	}
}
