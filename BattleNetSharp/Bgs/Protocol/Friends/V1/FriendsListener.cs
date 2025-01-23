using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Friends.V1
{
	// Token: 0x02000417 RID: 1047
	public static class FriendsListener
	{
		// Token: 0x06006740 RID: 26432 RVA: 0x0018F694 File Offset: 0x0018D894
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

		// Token: 0x06006741 RID: 26433 RVA: 0x0018F6E0 File Offset: 0x0018D8E0
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = FriendsListener.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17002102 RID: 8450
		// (get) Token: 0x06006742 RID: 26434 RVA: 0x0018F718 File Offset: 0x0018D918
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.Descriptor.Services[1];
			}
		}

		// Token: 0x06006743 RID: 26435 RVA: 0x0018F73C File Offset: 0x0018D93C
		public static ServerServiceDefinition BindService(FriendsListener.FriendsListenerBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<FriendNotification, NO_RESPONSE>(FriendsListener.__Method_OnFriendAdded, new UnaryServerMethod<FriendNotification, NO_RESPONSE>(serviceImpl.OnFriendAdded)).AddMethod<FriendNotification, NO_RESPONSE>(FriendsListener.__Method_OnFriendRemoved, new UnaryServerMethod<FriendNotification, NO_RESPONSE>(serviceImpl.OnFriendRemoved))
				.AddMethod<InvitationNotification, NO_RESPONSE>(FriendsListener.__Method_OnReceivedInvitationAdded, new UnaryServerMethod<InvitationNotification, NO_RESPONSE>(serviceImpl.OnReceivedInvitationAdded))
				.AddMethod<InvitationNotification, NO_RESPONSE>(FriendsListener.__Method_OnReceivedInvitationRemoved, new UnaryServerMethod<InvitationNotification, NO_RESPONSE>(serviceImpl.OnReceivedInvitationRemoved))
				.AddMethod<SentInvitationAddedNotification, NO_RESPONSE>(FriendsListener.__Method_OnSentInvitationAdded, new UnaryServerMethod<SentInvitationAddedNotification, NO_RESPONSE>(serviceImpl.OnSentInvitationAdded))
				.AddMethod<SentInvitationRemovedNotification, NO_RESPONSE>(FriendsListener.__Method_OnSentInvitationRemoved, new UnaryServerMethod<SentInvitationRemovedNotification, NO_RESPONSE>(serviceImpl.OnSentInvitationRemoved))
				.AddMethod<UpdateFriendStateNotification, NO_RESPONSE>(FriendsListener.__Method_OnUpdateFriendState, new UnaryServerMethod<UpdateFriendStateNotification, NO_RESPONSE>(serviceImpl.OnUpdateFriendState))
				.Build();
		}

		// Token: 0x06006744 RID: 26436 RVA: 0x0018F7FC File Offset: 0x0018D9FC
		public static void BindService(ServiceBinderBase serviceBinder, FriendsListener.FriendsListenerBase serviceImpl)
		{
			serviceBinder.AddMethod<FriendNotification, NO_RESPONSE>(FriendsListener.__Method_OnFriendAdded, (serviceImpl == null) ? null : new UnaryServerMethod<FriendNotification, NO_RESPONSE>(serviceImpl.OnFriendAdded));
			serviceBinder.AddMethod<FriendNotification, NO_RESPONSE>(FriendsListener.__Method_OnFriendRemoved, (serviceImpl == null) ? null : new UnaryServerMethod<FriendNotification, NO_RESPONSE>(serviceImpl.OnFriendRemoved));
			serviceBinder.AddMethod<InvitationNotification, NO_RESPONSE>(FriendsListener.__Method_OnReceivedInvitationAdded, (serviceImpl == null) ? null : new UnaryServerMethod<InvitationNotification, NO_RESPONSE>(serviceImpl.OnReceivedInvitationAdded));
			serviceBinder.AddMethod<InvitationNotification, NO_RESPONSE>(FriendsListener.__Method_OnReceivedInvitationRemoved, (serviceImpl == null) ? null : new UnaryServerMethod<InvitationNotification, NO_RESPONSE>(serviceImpl.OnReceivedInvitationRemoved));
			serviceBinder.AddMethod<SentInvitationAddedNotification, NO_RESPONSE>(FriendsListener.__Method_OnSentInvitationAdded, (serviceImpl == null) ? null : new UnaryServerMethod<SentInvitationAddedNotification, NO_RESPONSE>(serviceImpl.OnSentInvitationAdded));
			serviceBinder.AddMethod<SentInvitationRemovedNotification, NO_RESPONSE>(FriendsListener.__Method_OnSentInvitationRemoved, (serviceImpl == null) ? null : new UnaryServerMethod<SentInvitationRemovedNotification, NO_RESPONSE>(serviceImpl.OnSentInvitationRemoved));
			serviceBinder.AddMethod<UpdateFriendStateNotification, NO_RESPONSE>(FriendsListener.__Method_OnUpdateFriendState, (serviceImpl == null) ? null : new UnaryServerMethod<UpdateFriendStateNotification, NO_RESPONSE>(serviceImpl.OnUpdateFriendState));
		}

		// Token: 0x04002EE6 RID: 12006
		private static readonly string __ServiceName = "bgs.protocol.friends.v1.FriendsListener";

		// Token: 0x04002EE7 RID: 12007
		private static readonly Marshaller<FriendNotification> __Marshaller_bgs_protocol_friends_v1_FriendNotification = Marshallers.Create<FriendNotification>(new Action<FriendNotification, SerializationContext>(FriendsListener.__Helper_SerializeMessage), (DeserializationContext context) => FriendsListener.__Helper_DeserializeMessage<FriendNotification>(context, FriendNotification.Parser));

		// Token: 0x04002EE8 RID: 12008
		private static readonly Marshaller<NO_RESPONSE> __Marshaller_bgs_protocol_NO_RESPONSE = Marshallers.Create<NO_RESPONSE>(new Action<NO_RESPONSE, SerializationContext>(FriendsListener.__Helper_SerializeMessage), (DeserializationContext context) => FriendsListener.__Helper_DeserializeMessage<NO_RESPONSE>(context, NO_RESPONSE.Parser));

		// Token: 0x04002EE9 RID: 12009
		private static readonly Marshaller<InvitationNotification> __Marshaller_bgs_protocol_friends_v1_InvitationNotification = Marshallers.Create<InvitationNotification>(new Action<InvitationNotification, SerializationContext>(FriendsListener.__Helper_SerializeMessage), (DeserializationContext context) => FriendsListener.__Helper_DeserializeMessage<InvitationNotification>(context, InvitationNotification.Parser));

		// Token: 0x04002EEA RID: 12010
		private static readonly Marshaller<SentInvitationAddedNotification> __Marshaller_bgs_protocol_friends_v1_SentInvitationAddedNotification = Marshallers.Create<SentInvitationAddedNotification>(new Action<SentInvitationAddedNotification, SerializationContext>(FriendsListener.__Helper_SerializeMessage), (DeserializationContext context) => FriendsListener.__Helper_DeserializeMessage<SentInvitationAddedNotification>(context, SentInvitationAddedNotification.Parser));

		// Token: 0x04002EEB RID: 12011
		private static readonly Marshaller<SentInvitationRemovedNotification> __Marshaller_bgs_protocol_friends_v1_SentInvitationRemovedNotification = Marshallers.Create<SentInvitationRemovedNotification>(new Action<SentInvitationRemovedNotification, SerializationContext>(FriendsListener.__Helper_SerializeMessage), (DeserializationContext context) => FriendsListener.__Helper_DeserializeMessage<SentInvitationRemovedNotification>(context, SentInvitationRemovedNotification.Parser));

		// Token: 0x04002EEC RID: 12012
		private static readonly Marshaller<UpdateFriendStateNotification> __Marshaller_bgs_protocol_friends_v1_UpdateFriendStateNotification = Marshallers.Create<UpdateFriendStateNotification>(new Action<UpdateFriendStateNotification, SerializationContext>(FriendsListener.__Helper_SerializeMessage), (DeserializationContext context) => FriendsListener.__Helper_DeserializeMessage<UpdateFriendStateNotification>(context, UpdateFriendStateNotification.Parser));

		// Token: 0x04002EED RID: 12013
		private static readonly Method<FriendNotification, NO_RESPONSE> __Method_OnFriendAdded = new Method<FriendNotification, NO_RESPONSE>(0, FriendsListener.__ServiceName, "OnFriendAdded", FriendsListener.__Marshaller_bgs_protocol_friends_v1_FriendNotification, FriendsListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04002EEE RID: 12014
		private static readonly Method<FriendNotification, NO_RESPONSE> __Method_OnFriendRemoved = new Method<FriendNotification, NO_RESPONSE>(0, FriendsListener.__ServiceName, "OnFriendRemoved", FriendsListener.__Marshaller_bgs_protocol_friends_v1_FriendNotification, FriendsListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04002EEF RID: 12015
		private static readonly Method<InvitationNotification, NO_RESPONSE> __Method_OnReceivedInvitationAdded = new Method<InvitationNotification, NO_RESPONSE>(0, FriendsListener.__ServiceName, "OnReceivedInvitationAdded", FriendsListener.__Marshaller_bgs_protocol_friends_v1_InvitationNotification, FriendsListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04002EF0 RID: 12016
		private static readonly Method<InvitationNotification, NO_RESPONSE> __Method_OnReceivedInvitationRemoved = new Method<InvitationNotification, NO_RESPONSE>(0, FriendsListener.__ServiceName, "OnReceivedInvitationRemoved", FriendsListener.__Marshaller_bgs_protocol_friends_v1_InvitationNotification, FriendsListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04002EF1 RID: 12017
		private static readonly Method<SentInvitationAddedNotification, NO_RESPONSE> __Method_OnSentInvitationAdded = new Method<SentInvitationAddedNotification, NO_RESPONSE>(0, FriendsListener.__ServiceName, "OnSentInvitationAdded", FriendsListener.__Marshaller_bgs_protocol_friends_v1_SentInvitationAddedNotification, FriendsListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04002EF2 RID: 12018
		private static readonly Method<SentInvitationRemovedNotification, NO_RESPONSE> __Method_OnSentInvitationRemoved = new Method<SentInvitationRemovedNotification, NO_RESPONSE>(0, FriendsListener.__ServiceName, "OnSentInvitationRemoved", FriendsListener.__Marshaller_bgs_protocol_friends_v1_SentInvitationRemovedNotification, FriendsListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04002EF3 RID: 12019
		private static readonly Method<UpdateFriendStateNotification, NO_RESPONSE> __Method_OnUpdateFriendState = new Method<UpdateFriendStateNotification, NO_RESPONSE>(0, FriendsListener.__ServiceName, "OnUpdateFriendState", FriendsListener.__Marshaller_bgs_protocol_friends_v1_UpdateFriendStateNotification, FriendsListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x02000EF4 RID: 3828
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x04009651 RID: 38481
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02000EF5 RID: 3829
		[BindServiceMethod(typeof(FriendsListener), "BindService")]
		public abstract class FriendsListenerBase
		{
			// Token: 0x0600CC5E RID: 52318 RVA: 0x004ABE53 File Offset: 0x004AA053
			public virtual Task<NO_RESPONSE> OnFriendAdded(FriendNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CC5F RID: 52319 RVA: 0x004ABE67 File Offset: 0x004AA067
			public virtual Task<NO_RESPONSE> OnFriendRemoved(FriendNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CC60 RID: 52320 RVA: 0x004ABE7B File Offset: 0x004AA07B
			public virtual Task<NO_RESPONSE> OnReceivedInvitationAdded(InvitationNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CC61 RID: 52321 RVA: 0x004ABE8F File Offset: 0x004AA08F
			public virtual Task<NO_RESPONSE> OnReceivedInvitationRemoved(InvitationNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CC62 RID: 52322 RVA: 0x004ABEA3 File Offset: 0x004AA0A3
			public virtual Task<NO_RESPONSE> OnSentInvitationAdded(SentInvitationAddedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CC63 RID: 52323 RVA: 0x004ABEB7 File Offset: 0x004AA0B7
			public virtual Task<NO_RESPONSE> OnSentInvitationRemoved(SentInvitationRemovedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600CC64 RID: 52324 RVA: 0x004ABECB File Offset: 0x004AA0CB
			public virtual Task<NO_RESPONSE> OnUpdateFriendState(UpdateFriendStateNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x02000EF6 RID: 3830
		public class FriendsListenerClient : ClientBase<FriendsListener.FriendsListenerClient>
		{
			// Token: 0x0600CC66 RID: 52326 RVA: 0x004ABEE8 File Offset: 0x004AA0E8
			public FriendsListenerClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600CC67 RID: 52327 RVA: 0x004ABEF3 File Offset: 0x004AA0F3
			public FriendsListenerClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600CC68 RID: 52328 RVA: 0x004ABEFE File Offset: 0x004AA0FE
			protected FriendsListenerClient()
			{
			}

			// Token: 0x0600CC69 RID: 52329 RVA: 0x004ABF08 File Offset: 0x004AA108
			protected FriendsListenerClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600CC6A RID: 52330 RVA: 0x004ABF14 File Offset: 0x004AA114
			public virtual NO_RESPONSE OnFriendAdded(FriendNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnFriendAdded(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC6B RID: 52331 RVA: 0x004ABF3C File Offset: 0x004AA13C
			public virtual NO_RESPONSE OnFriendAdded(FriendNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<FriendNotification, NO_RESPONSE>(FriendsListener.__Method_OnFriendAdded, null, options, request);
			}

			// Token: 0x0600CC6C RID: 52332 RVA: 0x004ABF64 File Offset: 0x004AA164
			public virtual AsyncUnaryCall<NO_RESPONSE> OnFriendAddedAsync(FriendNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnFriendAddedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC6D RID: 52333 RVA: 0x004ABF8C File Offset: 0x004AA18C
			public virtual AsyncUnaryCall<NO_RESPONSE> OnFriendAddedAsync(FriendNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<FriendNotification, NO_RESPONSE>(FriendsListener.__Method_OnFriendAdded, null, options, request);
			}

			// Token: 0x0600CC6E RID: 52334 RVA: 0x004ABFB4 File Offset: 0x004AA1B4
			public virtual NO_RESPONSE OnFriendRemoved(FriendNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnFriendRemoved(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC6F RID: 52335 RVA: 0x004ABFDC File Offset: 0x004AA1DC
			public virtual NO_RESPONSE OnFriendRemoved(FriendNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<FriendNotification, NO_RESPONSE>(FriendsListener.__Method_OnFriendRemoved, null, options, request);
			}

			// Token: 0x0600CC70 RID: 52336 RVA: 0x004AC004 File Offset: 0x004AA204
			public virtual AsyncUnaryCall<NO_RESPONSE> OnFriendRemovedAsync(FriendNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnFriendRemovedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC71 RID: 52337 RVA: 0x004AC02C File Offset: 0x004AA22C
			public virtual AsyncUnaryCall<NO_RESPONSE> OnFriendRemovedAsync(FriendNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<FriendNotification, NO_RESPONSE>(FriendsListener.__Method_OnFriendRemoved, null, options, request);
			}

			// Token: 0x0600CC72 RID: 52338 RVA: 0x004AC054 File Offset: 0x004AA254
			public virtual NO_RESPONSE OnReceivedInvitationAdded(InvitationNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnReceivedInvitationAdded(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC73 RID: 52339 RVA: 0x004AC07C File Offset: 0x004AA27C
			public virtual NO_RESPONSE OnReceivedInvitationAdded(InvitationNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<InvitationNotification, NO_RESPONSE>(FriendsListener.__Method_OnReceivedInvitationAdded, null, options, request);
			}

			// Token: 0x0600CC74 RID: 52340 RVA: 0x004AC0A4 File Offset: 0x004AA2A4
			public virtual AsyncUnaryCall<NO_RESPONSE> OnReceivedInvitationAddedAsync(InvitationNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnReceivedInvitationAddedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC75 RID: 52341 RVA: 0x004AC0CC File Offset: 0x004AA2CC
			public virtual AsyncUnaryCall<NO_RESPONSE> OnReceivedInvitationAddedAsync(InvitationNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<InvitationNotification, NO_RESPONSE>(FriendsListener.__Method_OnReceivedInvitationAdded, null, options, request);
			}

			// Token: 0x0600CC76 RID: 52342 RVA: 0x004AC0F4 File Offset: 0x004AA2F4
			public virtual NO_RESPONSE OnReceivedInvitationRemoved(InvitationNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnReceivedInvitationRemoved(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC77 RID: 52343 RVA: 0x004AC11C File Offset: 0x004AA31C
			public virtual NO_RESPONSE OnReceivedInvitationRemoved(InvitationNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<InvitationNotification, NO_RESPONSE>(FriendsListener.__Method_OnReceivedInvitationRemoved, null, options, request);
			}

			// Token: 0x0600CC78 RID: 52344 RVA: 0x004AC144 File Offset: 0x004AA344
			public virtual AsyncUnaryCall<NO_RESPONSE> OnReceivedInvitationRemovedAsync(InvitationNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnReceivedInvitationRemovedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC79 RID: 52345 RVA: 0x004AC16C File Offset: 0x004AA36C
			public virtual AsyncUnaryCall<NO_RESPONSE> OnReceivedInvitationRemovedAsync(InvitationNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<InvitationNotification, NO_RESPONSE>(FriendsListener.__Method_OnReceivedInvitationRemoved, null, options, request);
			}

			// Token: 0x0600CC7A RID: 52346 RVA: 0x004AC194 File Offset: 0x004AA394
			public virtual NO_RESPONSE OnSentInvitationAdded(SentInvitationAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSentInvitationAdded(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC7B RID: 52347 RVA: 0x004AC1BC File Offset: 0x004AA3BC
			public virtual NO_RESPONSE OnSentInvitationAdded(SentInvitationAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SentInvitationAddedNotification, NO_RESPONSE>(FriendsListener.__Method_OnSentInvitationAdded, null, options, request);
			}

			// Token: 0x0600CC7C RID: 52348 RVA: 0x004AC1E4 File Offset: 0x004AA3E4
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSentInvitationAddedAsync(SentInvitationAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSentInvitationAddedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC7D RID: 52349 RVA: 0x004AC20C File Offset: 0x004AA40C
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSentInvitationAddedAsync(SentInvitationAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SentInvitationAddedNotification, NO_RESPONSE>(FriendsListener.__Method_OnSentInvitationAdded, null, options, request);
			}

			// Token: 0x0600CC7E RID: 52350 RVA: 0x004AC234 File Offset: 0x004AA434
			public virtual NO_RESPONSE OnSentInvitationRemoved(SentInvitationRemovedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSentInvitationRemoved(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC7F RID: 52351 RVA: 0x004AC25C File Offset: 0x004AA45C
			public virtual NO_RESPONSE OnSentInvitationRemoved(SentInvitationRemovedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SentInvitationRemovedNotification, NO_RESPONSE>(FriendsListener.__Method_OnSentInvitationRemoved, null, options, request);
			}

			// Token: 0x0600CC80 RID: 52352 RVA: 0x004AC284 File Offset: 0x004AA484
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSentInvitationRemovedAsync(SentInvitationRemovedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSentInvitationRemovedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC81 RID: 52353 RVA: 0x004AC2AC File Offset: 0x004AA4AC
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSentInvitationRemovedAsync(SentInvitationRemovedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SentInvitationRemovedNotification, NO_RESPONSE>(FriendsListener.__Method_OnSentInvitationRemoved, null, options, request);
			}

			// Token: 0x0600CC82 RID: 52354 RVA: 0x004AC2D4 File Offset: 0x004AA4D4
			public virtual NO_RESPONSE OnUpdateFriendState(UpdateFriendStateNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnUpdateFriendState(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC83 RID: 52355 RVA: 0x004AC2FC File Offset: 0x004AA4FC
			public virtual NO_RESPONSE OnUpdateFriendState(UpdateFriendStateNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<UpdateFriendStateNotification, NO_RESPONSE>(FriendsListener.__Method_OnUpdateFriendState, null, options, request);
			}

			// Token: 0x0600CC84 RID: 52356 RVA: 0x004AC324 File Offset: 0x004AA524
			public virtual AsyncUnaryCall<NO_RESPONSE> OnUpdateFriendStateAsync(UpdateFriendStateNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnUpdateFriendStateAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CC85 RID: 52357 RVA: 0x004AC34C File Offset: 0x004AA54C
			public virtual AsyncUnaryCall<NO_RESPONSE> OnUpdateFriendStateAsync(UpdateFriendStateNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<UpdateFriendStateNotification, NO_RESPONSE>(FriendsListener.__Method_OnUpdateFriendState, null, options, request);
			}

			// Token: 0x0600CC86 RID: 52358 RVA: 0x004AC374 File Offset: 0x004AA574
			protected override FriendsListener.FriendsListenerClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new FriendsListener.FriendsListenerClient(configuration);
			}
		}
	}
}
