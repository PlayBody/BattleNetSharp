using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.UserManager.V1
{
	// Token: 0x020003BE RID: 958
	public static class UserManagerService
	{
		// Token: 0x0600602A RID: 24618 RVA: 0x00174780 File Offset: 0x00172980
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

		// Token: 0x0600602B RID: 24619 RVA: 0x001747CC File Offset: 0x001729CC
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = UserManagerService.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17001F0B RID: 7947
		// (get) Token: 0x0600602C RID: 24620 RVA: 0x00174804 File Offset: 0x00172A04
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return UserManagerServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x0600602D RID: 24621 RVA: 0x00174828 File Offset: 0x00172A28
		public static ServerServiceDefinition BindService(UserManagerService.UserManagerServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<SubscribeRequest, SubscribeResponse>(UserManagerService.__Method_Subscribe, new UnaryServerMethod<SubscribeRequest, SubscribeResponse>(serviceImpl.Subscribe)).AddMethod<AddRecentPlayersRequest, NoData>(UserManagerService.__Method_AddRecentPlayers, new UnaryServerMethod<AddRecentPlayersRequest, NoData>(serviceImpl.AddRecentPlayers))
				.AddMethod<ClearRecentPlayersRequest, NoData>(UserManagerService.__Method_ClearRecentPlayers, new UnaryServerMethod<ClearRecentPlayersRequest, NoData>(serviceImpl.ClearRecentPlayers))
				.AddMethod<BlockPlayerRequest, NoData>(UserManagerService.__Method_BlockPlayer, new UnaryServerMethod<BlockPlayerRequest, NoData>(serviceImpl.BlockPlayer))
				.AddMethod<UnblockPlayerRequest, NoData>(UserManagerService.__Method_UnblockPlayer, new UnaryServerMethod<UnblockPlayerRequest, NoData>(serviceImpl.UnblockPlayer))
				.AddMethod<BlockPlayerRequest, NoData>(UserManagerService.__Method_BlockPlayerForSession, new UnaryServerMethod<BlockPlayerRequest, NoData>(serviceImpl.BlockPlayerForSession))
				.AddMethod<UnsubscribeRequest, NoData>(UserManagerService.__Method_Unsubscribe, new UnaryServerMethod<UnsubscribeRequest, NoData>(serviceImpl.Unsubscribe))
				.Build();
		}

		// Token: 0x0600602E RID: 24622 RVA: 0x001748E8 File Offset: 0x00172AE8
		public static void BindService(ServiceBinderBase serviceBinder, UserManagerService.UserManagerServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<SubscribeRequest, SubscribeResponse>(UserManagerService.__Method_Subscribe, (serviceImpl == null) ? null : new UnaryServerMethod<SubscribeRequest, SubscribeResponse>(serviceImpl.Subscribe));
			serviceBinder.AddMethod<AddRecentPlayersRequest, NoData>(UserManagerService.__Method_AddRecentPlayers, (serviceImpl == null) ? null : new UnaryServerMethod<AddRecentPlayersRequest, NoData>(serviceImpl.AddRecentPlayers));
			serviceBinder.AddMethod<ClearRecentPlayersRequest, NoData>(UserManagerService.__Method_ClearRecentPlayers, (serviceImpl == null) ? null : new UnaryServerMethod<ClearRecentPlayersRequest, NoData>(serviceImpl.ClearRecentPlayers));
			serviceBinder.AddMethod<BlockPlayerRequest, NoData>(UserManagerService.__Method_BlockPlayer, (serviceImpl == null) ? null : new UnaryServerMethod<BlockPlayerRequest, NoData>(serviceImpl.BlockPlayer));
			serviceBinder.AddMethod<UnblockPlayerRequest, NoData>(UserManagerService.__Method_UnblockPlayer, (serviceImpl == null) ? null : new UnaryServerMethod<UnblockPlayerRequest, NoData>(serviceImpl.UnblockPlayer));
			serviceBinder.AddMethod<BlockPlayerRequest, NoData>(UserManagerService.__Method_BlockPlayerForSession, (serviceImpl == null) ? null : new UnaryServerMethod<BlockPlayerRequest, NoData>(serviceImpl.BlockPlayerForSession));
			serviceBinder.AddMethod<UnsubscribeRequest, NoData>(UserManagerService.__Method_Unsubscribe, (serviceImpl == null) ? null : new UnaryServerMethod<UnsubscribeRequest, NoData>(serviceImpl.Unsubscribe));
		}

		// Token: 0x04002BE4 RID: 11236
		private static readonly string __ServiceName = "bgs.protocol.user_manager.v1.UserManagerService";

		// Token: 0x04002BE5 RID: 11237
		private static readonly Marshaller<SubscribeRequest> __Marshaller_bgs_protocol_user_manager_v1_SubscribeRequest = Marshallers.Create<SubscribeRequest>(new Action<SubscribeRequest, SerializationContext>(UserManagerService.__Helper_SerializeMessage), (DeserializationContext context) => UserManagerService.__Helper_DeserializeMessage<SubscribeRequest>(context, SubscribeRequest.Parser));

		// Token: 0x04002BE6 RID: 11238
		private static readonly Marshaller<SubscribeResponse> __Marshaller_bgs_protocol_user_manager_v1_SubscribeResponse = Marshallers.Create<SubscribeResponse>(new Action<SubscribeResponse, SerializationContext>(UserManagerService.__Helper_SerializeMessage), (DeserializationContext context) => UserManagerService.__Helper_DeserializeMessage<SubscribeResponse>(context, SubscribeResponse.Parser));

		// Token: 0x04002BE7 RID: 11239
		private static readonly Marshaller<AddRecentPlayersRequest> __Marshaller_bgs_protocol_user_manager_v1_AddRecentPlayersRequest = Marshallers.Create<AddRecentPlayersRequest>(new Action<AddRecentPlayersRequest, SerializationContext>(UserManagerService.__Helper_SerializeMessage), (DeserializationContext context) => UserManagerService.__Helper_DeserializeMessage<AddRecentPlayersRequest>(context, AddRecentPlayersRequest.Parser));

		// Token: 0x04002BE8 RID: 11240
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(UserManagerService.__Helper_SerializeMessage), (DeserializationContext context) => UserManagerService.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x04002BE9 RID: 11241
		private static readonly Marshaller<ClearRecentPlayersRequest> __Marshaller_bgs_protocol_user_manager_v1_ClearRecentPlayersRequest = Marshallers.Create<ClearRecentPlayersRequest>(new Action<ClearRecentPlayersRequest, SerializationContext>(UserManagerService.__Helper_SerializeMessage), (DeserializationContext context) => UserManagerService.__Helper_DeserializeMessage<ClearRecentPlayersRequest>(context, ClearRecentPlayersRequest.Parser));

		// Token: 0x04002BEA RID: 11242
		private static readonly Marshaller<BlockPlayerRequest> __Marshaller_bgs_protocol_user_manager_v1_BlockPlayerRequest = Marshallers.Create<BlockPlayerRequest>(new Action<BlockPlayerRequest, SerializationContext>(UserManagerService.__Helper_SerializeMessage), (DeserializationContext context) => UserManagerService.__Helper_DeserializeMessage<BlockPlayerRequest>(context, BlockPlayerRequest.Parser));

		// Token: 0x04002BEB RID: 11243
		private static readonly Marshaller<UnblockPlayerRequest> __Marshaller_bgs_protocol_user_manager_v1_UnblockPlayerRequest = Marshallers.Create<UnblockPlayerRequest>(new Action<UnblockPlayerRequest, SerializationContext>(UserManagerService.__Helper_SerializeMessage), (DeserializationContext context) => UserManagerService.__Helper_DeserializeMessage<UnblockPlayerRequest>(context, UnblockPlayerRequest.Parser));

		// Token: 0x04002BEC RID: 11244
		private static readonly Marshaller<UnsubscribeRequest> __Marshaller_bgs_protocol_user_manager_v1_UnsubscribeRequest = Marshallers.Create<UnsubscribeRequest>(new Action<UnsubscribeRequest, SerializationContext>(UserManagerService.__Helper_SerializeMessage), (DeserializationContext context) => UserManagerService.__Helper_DeserializeMessage<UnsubscribeRequest>(context, UnsubscribeRequest.Parser));

		// Token: 0x04002BED RID: 11245
		private static readonly Method<SubscribeRequest, SubscribeResponse> __Method_Subscribe = new Method<SubscribeRequest, SubscribeResponse>(0, UserManagerService.__ServiceName, "Subscribe", UserManagerService.__Marshaller_bgs_protocol_user_manager_v1_SubscribeRequest, UserManagerService.__Marshaller_bgs_protocol_user_manager_v1_SubscribeResponse);

		// Token: 0x04002BEE RID: 11246
		private static readonly Method<AddRecentPlayersRequest, NoData> __Method_AddRecentPlayers = new Method<AddRecentPlayersRequest, NoData>(0, UserManagerService.__ServiceName, "AddRecentPlayers", UserManagerService.__Marshaller_bgs_protocol_user_manager_v1_AddRecentPlayersRequest, UserManagerService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04002BEF RID: 11247
		private static readonly Method<ClearRecentPlayersRequest, NoData> __Method_ClearRecentPlayers = new Method<ClearRecentPlayersRequest, NoData>(0, UserManagerService.__ServiceName, "ClearRecentPlayers", UserManagerService.__Marshaller_bgs_protocol_user_manager_v1_ClearRecentPlayersRequest, UserManagerService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04002BF0 RID: 11248
		private static readonly Method<BlockPlayerRequest, NoData> __Method_BlockPlayer = new Method<BlockPlayerRequest, NoData>(0, UserManagerService.__ServiceName, "BlockPlayer", UserManagerService.__Marshaller_bgs_protocol_user_manager_v1_BlockPlayerRequest, UserManagerService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04002BF1 RID: 11249
		private static readonly Method<UnblockPlayerRequest, NoData> __Method_UnblockPlayer = new Method<UnblockPlayerRequest, NoData>(0, UserManagerService.__ServiceName, "UnblockPlayer", UserManagerService.__Marshaller_bgs_protocol_user_manager_v1_UnblockPlayerRequest, UserManagerService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04002BF2 RID: 11250
		private static readonly Method<BlockPlayerRequest, NoData> __Method_BlockPlayerForSession = new Method<BlockPlayerRequest, NoData>(0, UserManagerService.__ServiceName, "BlockPlayerForSession", UserManagerService.__Marshaller_bgs_protocol_user_manager_v1_BlockPlayerRequest, UserManagerService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04002BF3 RID: 11251
		private static readonly Method<UnsubscribeRequest, NoData> __Method_Unsubscribe = new Method<UnsubscribeRequest, NoData>(0, UserManagerService.__ServiceName, "Unsubscribe", UserManagerService.__Marshaller_bgs_protocol_user_manager_v1_UnsubscribeRequest, UserManagerService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x02000E8A RID: 3722
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x040095F8 RID: 38392
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02000E8B RID: 3723
		[BindServiceMethod(typeof(UserManagerService), "BindService")]
		public abstract class UserManagerServiceBase
		{
			// Token: 0x0600CA2D RID: 51757 RVA: 0x004A9189 File Offset: 0x004A7389
			public virtual Task<SubscribeResponse> Subscribe(SubscribeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CA2E RID: 51758 RVA: 0x004A919D File Offset: 0x004A739D
			public virtual Task<NoData> AddRecentPlayers(AddRecentPlayersRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CA2F RID: 51759 RVA: 0x004A91B1 File Offset: 0x004A73B1
			public virtual Task<NoData> ClearRecentPlayers(ClearRecentPlayersRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CA30 RID: 51760 RVA: 0x004A91C5 File Offset: 0x004A73C5
			public virtual Task<NoData> BlockPlayer(BlockPlayerRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CA31 RID: 51761 RVA: 0x004A91D9 File Offset: 0x004A73D9
			public virtual Task<NoData> UnblockPlayer(UnblockPlayerRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CA32 RID: 51762 RVA: 0x004A91ED File Offset: 0x004A73ED
			public virtual Task<NoData> BlockPlayerForSession(BlockPlayerRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CA33 RID: 51763 RVA: 0x004A9201 File Offset: 0x004A7401
			public virtual Task<NoData> Unsubscribe(UnsubscribeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x02000E8C RID: 3724
		public class UserManagerServiceClient : ClientBase<UserManagerService.UserManagerServiceClient>
		{
			// Token: 0x0600CA35 RID: 51765 RVA: 0x004A921E File Offset: 0x004A741E
			public UserManagerServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600CA36 RID: 51766 RVA: 0x004A9229 File Offset: 0x004A7429
			public UserManagerServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600CA37 RID: 51767 RVA: 0x004A9234 File Offset: 0x004A7434
			protected UserManagerServiceClient()
			{
			}

			// Token: 0x0600CA38 RID: 51768 RVA: 0x004A923E File Offset: 0x004A743E
			protected UserManagerServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600CA39 RID: 51769 RVA: 0x004A924C File Offset: 0x004A744C
			public virtual SubscribeResponse Subscribe(SubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Subscribe(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CA3A RID: 51770 RVA: 0x004A9274 File Offset: 0x004A7474
			public virtual SubscribeResponse Subscribe(SubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SubscribeRequest, SubscribeResponse>(UserManagerService.__Method_Subscribe, null, options, request);
			}

			// Token: 0x0600CA3B RID: 51771 RVA: 0x004A929C File Offset: 0x004A749C
			public virtual AsyncUnaryCall<SubscribeResponse> SubscribeAsync(SubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SubscribeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CA3C RID: 51772 RVA: 0x004A92C4 File Offset: 0x004A74C4
			public virtual AsyncUnaryCall<SubscribeResponse> SubscribeAsync(SubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SubscribeRequest, SubscribeResponse>(UserManagerService.__Method_Subscribe, null, options, request);
			}

			// Token: 0x0600CA3D RID: 51773 RVA: 0x004A92EC File Offset: 0x004A74EC
			public virtual NoData AddRecentPlayers(AddRecentPlayersRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.AddRecentPlayers(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CA3E RID: 51774 RVA: 0x004A9314 File Offset: 0x004A7514
			public virtual NoData AddRecentPlayers(AddRecentPlayersRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<AddRecentPlayersRequest, NoData>(UserManagerService.__Method_AddRecentPlayers, null, options, request);
			}

			// Token: 0x0600CA3F RID: 51775 RVA: 0x004A933C File Offset: 0x004A753C
			public virtual AsyncUnaryCall<NoData> AddRecentPlayersAsync(AddRecentPlayersRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.AddRecentPlayersAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CA40 RID: 51776 RVA: 0x004A9364 File Offset: 0x004A7564
			public virtual AsyncUnaryCall<NoData> AddRecentPlayersAsync(AddRecentPlayersRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<AddRecentPlayersRequest, NoData>(UserManagerService.__Method_AddRecentPlayers, null, options, request);
			}

			// Token: 0x0600CA41 RID: 51777 RVA: 0x004A938C File Offset: 0x004A758C
			public virtual NoData ClearRecentPlayers(ClearRecentPlayersRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ClearRecentPlayers(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CA42 RID: 51778 RVA: 0x004A93B4 File Offset: 0x004A75B4
			public virtual NoData ClearRecentPlayers(ClearRecentPlayersRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ClearRecentPlayersRequest, NoData>(UserManagerService.__Method_ClearRecentPlayers, null, options, request);
			}

			// Token: 0x0600CA43 RID: 51779 RVA: 0x004A93DC File Offset: 0x004A75DC
			public virtual AsyncUnaryCall<NoData> ClearRecentPlayersAsync(ClearRecentPlayersRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ClearRecentPlayersAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CA44 RID: 51780 RVA: 0x004A9404 File Offset: 0x004A7604
			public virtual AsyncUnaryCall<NoData> ClearRecentPlayersAsync(ClearRecentPlayersRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ClearRecentPlayersRequest, NoData>(UserManagerService.__Method_ClearRecentPlayers, null, options, request);
			}

			// Token: 0x0600CA45 RID: 51781 RVA: 0x004A942C File Offset: 0x004A762C
			public virtual NoData BlockPlayer(BlockPlayerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.BlockPlayer(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CA46 RID: 51782 RVA: 0x004A9454 File Offset: 0x004A7654
			public virtual NoData BlockPlayer(BlockPlayerRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<BlockPlayerRequest, NoData>(UserManagerService.__Method_BlockPlayer, null, options, request);
			}

			// Token: 0x0600CA47 RID: 51783 RVA: 0x004A947C File Offset: 0x004A767C
			public virtual AsyncUnaryCall<NoData> BlockPlayerAsync(BlockPlayerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.BlockPlayerAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CA48 RID: 51784 RVA: 0x004A94A4 File Offset: 0x004A76A4
			public virtual AsyncUnaryCall<NoData> BlockPlayerAsync(BlockPlayerRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<BlockPlayerRequest, NoData>(UserManagerService.__Method_BlockPlayer, null, options, request);
			}

			// Token: 0x0600CA49 RID: 51785 RVA: 0x004A94CC File Offset: 0x004A76CC
			public virtual NoData UnblockPlayer(UnblockPlayerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UnblockPlayer(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CA4A RID: 51786 RVA: 0x004A94F4 File Offset: 0x004A76F4
			public virtual NoData UnblockPlayer(UnblockPlayerRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<UnblockPlayerRequest, NoData>(UserManagerService.__Method_UnblockPlayer, null, options, request);
			}

			// Token: 0x0600CA4B RID: 51787 RVA: 0x004A951C File Offset: 0x004A771C
			public virtual AsyncUnaryCall<NoData> UnblockPlayerAsync(UnblockPlayerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UnblockPlayerAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CA4C RID: 51788 RVA: 0x004A9544 File Offset: 0x004A7744
			public virtual AsyncUnaryCall<NoData> UnblockPlayerAsync(UnblockPlayerRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<UnblockPlayerRequest, NoData>(UserManagerService.__Method_UnblockPlayer, null, options, request);
			}

			// Token: 0x0600CA4D RID: 51789 RVA: 0x004A956C File Offset: 0x004A776C
			public virtual NoData BlockPlayerForSession(BlockPlayerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.BlockPlayerForSession(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CA4E RID: 51790 RVA: 0x004A9594 File Offset: 0x004A7794
			public virtual NoData BlockPlayerForSession(BlockPlayerRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<BlockPlayerRequest, NoData>(UserManagerService.__Method_BlockPlayerForSession, null, options, request);
			}

			// Token: 0x0600CA4F RID: 51791 RVA: 0x004A95BC File Offset: 0x004A77BC
			public virtual AsyncUnaryCall<NoData> BlockPlayerForSessionAsync(BlockPlayerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.BlockPlayerForSessionAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CA50 RID: 51792 RVA: 0x004A95E4 File Offset: 0x004A77E4
			public virtual AsyncUnaryCall<NoData> BlockPlayerForSessionAsync(BlockPlayerRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<BlockPlayerRequest, NoData>(UserManagerService.__Method_BlockPlayerForSession, null, options, request);
			}

			// Token: 0x0600CA51 RID: 51793 RVA: 0x004A960C File Offset: 0x004A780C
			public virtual NoData Unsubscribe(UnsubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Unsubscribe(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CA52 RID: 51794 RVA: 0x004A9634 File Offset: 0x004A7834
			public virtual NoData Unsubscribe(UnsubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<UnsubscribeRequest, NoData>(UserManagerService.__Method_Unsubscribe, null, options, request);
			}

			// Token: 0x0600CA53 RID: 51795 RVA: 0x004A965C File Offset: 0x004A785C
			public virtual AsyncUnaryCall<NoData> UnsubscribeAsync(UnsubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UnsubscribeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CA54 RID: 51796 RVA: 0x004A9684 File Offset: 0x004A7884
			public virtual AsyncUnaryCall<NoData> UnsubscribeAsync(UnsubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<UnsubscribeRequest, NoData>(UserManagerService.__Method_Unsubscribe, null, options, request);
			}

			// Token: 0x0600CA55 RID: 51797 RVA: 0x004A96AC File Offset: 0x004A78AC
			protected override UserManagerService.UserManagerServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new UserManagerService.UserManagerServiceClient(configuration);
			}
		}
	}
}
