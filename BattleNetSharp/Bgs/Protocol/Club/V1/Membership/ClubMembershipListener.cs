using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Club.V1.Membership
{
	// Token: 0x02000517 RID: 1303
	public static class ClubMembershipListener
	{
		// Token: 0x06007EEF RID: 32495 RVA: 0x001EE304 File Offset: 0x001EC504
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

		// Token: 0x06007EF0 RID: 32496 RVA: 0x001EE350 File Offset: 0x001EC550
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = ClubMembershipListener.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17002843 RID: 10307
		// (get) Token: 0x06007EF1 RID: 32497 RVA: 0x001EE388 File Offset: 0x001EC588
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return ClubMembershipListenerReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x06007EF2 RID: 32498 RVA: 0x001EE3AC File Offset: 0x001EC5AC
		public static ServerServiceDefinition BindService(ClubMembershipListener.ClubMembershipListenerBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<ClubAddedNotification, NO_RESPONSE>(ClubMembershipListener.__Method_OnClubAdded, new UnaryServerMethod<ClubAddedNotification, NO_RESPONSE>(serviceImpl.OnClubAdded)).AddMethod<ClubRemovedNotification, NO_RESPONSE>(ClubMembershipListener.__Method_OnClubRemoved, new UnaryServerMethod<ClubRemovedNotification, NO_RESPONSE>(serviceImpl.OnClubRemoved))
				.AddMethod<ReceivedInvitationAddedNotification, NO_RESPONSE>(ClubMembershipListener.__Method_OnReceivedInvitationAdded, new UnaryServerMethod<ReceivedInvitationAddedNotification, NO_RESPONSE>(serviceImpl.OnReceivedInvitationAdded))
				.AddMethod<ReceivedInvitationRemovedNotification, NO_RESPONSE>(ClubMembershipListener.__Method_OnReceivedInvitationRemoved, new UnaryServerMethod<ReceivedInvitationRemovedNotification, NO_RESPONSE>(serviceImpl.OnReceivedInvitationRemoved))
				.AddMethod<SharedSettingsChangedNotification, NO_RESPONSE>(ClubMembershipListener.__Method_OnSharedSettingsChanged, new UnaryServerMethod<SharedSettingsChangedNotification, NO_RESPONSE>(serviceImpl.OnSharedSettingsChanged))
				.AddMethod<StreamMentionAddedNotification, NO_RESPONSE>(ClubMembershipListener.__Method_OnStreamMentionAdded, new UnaryServerMethod<StreamMentionAddedNotification, NO_RESPONSE>(serviceImpl.OnStreamMentionAdded))
				.AddMethod<StreamMentionRemovedNotification, NO_RESPONSE>(ClubMembershipListener.__Method_OnStreamMentionRemoved, new UnaryServerMethod<StreamMentionRemovedNotification, NO_RESPONSE>(serviceImpl.OnStreamMentionRemoved))
				.AddMethod<StreamMentionAdvanceViewTimeNotification, NO_RESPONSE>(ClubMembershipListener.__Method_OnStreamMentionAdvanceViewTime, new UnaryServerMethod<StreamMentionAdvanceViewTimeNotification, NO_RESPONSE>(serviceImpl.OnStreamMentionAdvanceViewTime))
				.Build();
		}

		// Token: 0x06007EF3 RID: 32499 RVA: 0x001EE480 File Offset: 0x001EC680
		public static void BindService(ServiceBinderBase serviceBinder, ClubMembershipListener.ClubMembershipListenerBase serviceImpl)
		{
			serviceBinder.AddMethod<ClubAddedNotification, NO_RESPONSE>(ClubMembershipListener.__Method_OnClubAdded, (serviceImpl == null) ? null : new UnaryServerMethod<ClubAddedNotification, NO_RESPONSE>(serviceImpl.OnClubAdded));
			serviceBinder.AddMethod<ClubRemovedNotification, NO_RESPONSE>(ClubMembershipListener.__Method_OnClubRemoved, (serviceImpl == null) ? null : new UnaryServerMethod<ClubRemovedNotification, NO_RESPONSE>(serviceImpl.OnClubRemoved));
			serviceBinder.AddMethod<ReceivedInvitationAddedNotification, NO_RESPONSE>(ClubMembershipListener.__Method_OnReceivedInvitationAdded, (serviceImpl == null) ? null : new UnaryServerMethod<ReceivedInvitationAddedNotification, NO_RESPONSE>(serviceImpl.OnReceivedInvitationAdded));
			serviceBinder.AddMethod<ReceivedInvitationRemovedNotification, NO_RESPONSE>(ClubMembershipListener.__Method_OnReceivedInvitationRemoved, (serviceImpl == null) ? null : new UnaryServerMethod<ReceivedInvitationRemovedNotification, NO_RESPONSE>(serviceImpl.OnReceivedInvitationRemoved));
			serviceBinder.AddMethod<SharedSettingsChangedNotification, NO_RESPONSE>(ClubMembershipListener.__Method_OnSharedSettingsChanged, (serviceImpl == null) ? null : new UnaryServerMethod<SharedSettingsChangedNotification, NO_RESPONSE>(serviceImpl.OnSharedSettingsChanged));
			serviceBinder.AddMethod<StreamMentionAddedNotification, NO_RESPONSE>(ClubMembershipListener.__Method_OnStreamMentionAdded, (serviceImpl == null) ? null : new UnaryServerMethod<StreamMentionAddedNotification, NO_RESPONSE>(serviceImpl.OnStreamMentionAdded));
			serviceBinder.AddMethod<StreamMentionRemovedNotification, NO_RESPONSE>(ClubMembershipListener.__Method_OnStreamMentionRemoved, (serviceImpl == null) ? null : new UnaryServerMethod<StreamMentionRemovedNotification, NO_RESPONSE>(serviceImpl.OnStreamMentionRemoved));
			serviceBinder.AddMethod<StreamMentionAdvanceViewTimeNotification, NO_RESPONSE>(ClubMembershipListener.__Method_OnStreamMentionAdvanceViewTime, (serviceImpl == null) ? null : new UnaryServerMethod<StreamMentionAdvanceViewTimeNotification, NO_RESPONSE>(serviceImpl.OnStreamMentionAdvanceViewTime));
		}

		// Token: 0x040039A9 RID: 14761
		private static readonly string __ServiceName = "bgs.protocol.club.v1.membership.ClubMembershipListener";

		// Token: 0x040039AA RID: 14762
		private static readonly Marshaller<ClubAddedNotification> __Marshaller_bgs_protocol_club_v1_membership_ClubAddedNotification = Marshallers.Create<ClubAddedNotification>(new Action<ClubAddedNotification, SerializationContext>(ClubMembershipListener.__Helper_SerializeMessage), (DeserializationContext context) => ClubMembershipListener.__Helper_DeserializeMessage<ClubAddedNotification>(context, ClubAddedNotification.Parser));

		// Token: 0x040039AB RID: 14763
		private static readonly Marshaller<NO_RESPONSE> __Marshaller_bgs_protocol_NO_RESPONSE = Marshallers.Create<NO_RESPONSE>(new Action<NO_RESPONSE, SerializationContext>(ClubMembershipListener.__Helper_SerializeMessage), (DeserializationContext context) => ClubMembershipListener.__Helper_DeserializeMessage<NO_RESPONSE>(context, NO_RESPONSE.Parser));

		// Token: 0x040039AC RID: 14764
		private static readonly Marshaller<ClubRemovedNotification> __Marshaller_bgs_protocol_club_v1_membership_ClubRemovedNotification = Marshallers.Create<ClubRemovedNotification>(new Action<ClubRemovedNotification, SerializationContext>(ClubMembershipListener.__Helper_SerializeMessage), (DeserializationContext context) => ClubMembershipListener.__Helper_DeserializeMessage<ClubRemovedNotification>(context, ClubRemovedNotification.Parser));

		// Token: 0x040039AD RID: 14765
		private static readonly Marshaller<ReceivedInvitationAddedNotification> __Marshaller_bgs_protocol_club_v1_membership_ReceivedInvitationAddedNotification = Marshallers.Create<ReceivedInvitationAddedNotification>(new Action<ReceivedInvitationAddedNotification, SerializationContext>(ClubMembershipListener.__Helper_SerializeMessage), (DeserializationContext context) => ClubMembershipListener.__Helper_DeserializeMessage<ReceivedInvitationAddedNotification>(context, ReceivedInvitationAddedNotification.Parser));

		// Token: 0x040039AE RID: 14766
		private static readonly Marshaller<ReceivedInvitationRemovedNotification> __Marshaller_bgs_protocol_club_v1_membership_ReceivedInvitationRemovedNotification = Marshallers.Create<ReceivedInvitationRemovedNotification>(new Action<ReceivedInvitationRemovedNotification, SerializationContext>(ClubMembershipListener.__Helper_SerializeMessage), (DeserializationContext context) => ClubMembershipListener.__Helper_DeserializeMessage<ReceivedInvitationRemovedNotification>(context, ReceivedInvitationRemovedNotification.Parser));

		// Token: 0x040039AF RID: 14767
		private static readonly Marshaller<SharedSettingsChangedNotification> __Marshaller_bgs_protocol_club_v1_membership_SharedSettingsChangedNotification = Marshallers.Create<SharedSettingsChangedNotification>(new Action<SharedSettingsChangedNotification, SerializationContext>(ClubMembershipListener.__Helper_SerializeMessage), (DeserializationContext context) => ClubMembershipListener.__Helper_DeserializeMessage<SharedSettingsChangedNotification>(context, SharedSettingsChangedNotification.Parser));

		// Token: 0x040039B0 RID: 14768
		private static readonly Marshaller<StreamMentionAddedNotification> __Marshaller_bgs_protocol_club_v1_membership_StreamMentionAddedNotification = Marshallers.Create<StreamMentionAddedNotification>(new Action<StreamMentionAddedNotification, SerializationContext>(ClubMembershipListener.__Helper_SerializeMessage), (DeserializationContext context) => ClubMembershipListener.__Helper_DeserializeMessage<StreamMentionAddedNotification>(context, StreamMentionAddedNotification.Parser));

		// Token: 0x040039B1 RID: 14769
		private static readonly Marshaller<StreamMentionRemovedNotification> __Marshaller_bgs_protocol_club_v1_membership_StreamMentionRemovedNotification = Marshallers.Create<StreamMentionRemovedNotification>(new Action<StreamMentionRemovedNotification, SerializationContext>(ClubMembershipListener.__Helper_SerializeMessage), (DeserializationContext context) => ClubMembershipListener.__Helper_DeserializeMessage<StreamMentionRemovedNotification>(context, StreamMentionRemovedNotification.Parser));

		// Token: 0x040039B2 RID: 14770
		private static readonly Marshaller<StreamMentionAdvanceViewTimeNotification> __Marshaller_bgs_protocol_club_v1_membership_StreamMentionAdvanceViewTimeNotification = Marshallers.Create<StreamMentionAdvanceViewTimeNotification>(new Action<StreamMentionAdvanceViewTimeNotification, SerializationContext>(ClubMembershipListener.__Helper_SerializeMessage), (DeserializationContext context) => ClubMembershipListener.__Helper_DeserializeMessage<StreamMentionAdvanceViewTimeNotification>(context, StreamMentionAdvanceViewTimeNotification.Parser));

		// Token: 0x040039B3 RID: 14771
		private static readonly Method<ClubAddedNotification, NO_RESPONSE> __Method_OnClubAdded = new Method<ClubAddedNotification, NO_RESPONSE>(0, ClubMembershipListener.__ServiceName, "OnClubAdded", ClubMembershipListener.__Marshaller_bgs_protocol_club_v1_membership_ClubAddedNotification, ClubMembershipListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x040039B4 RID: 14772
		private static readonly Method<ClubRemovedNotification, NO_RESPONSE> __Method_OnClubRemoved = new Method<ClubRemovedNotification, NO_RESPONSE>(0, ClubMembershipListener.__ServiceName, "OnClubRemoved", ClubMembershipListener.__Marshaller_bgs_protocol_club_v1_membership_ClubRemovedNotification, ClubMembershipListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x040039B5 RID: 14773
		private static readonly Method<ReceivedInvitationAddedNotification, NO_RESPONSE> __Method_OnReceivedInvitationAdded = new Method<ReceivedInvitationAddedNotification, NO_RESPONSE>(0, ClubMembershipListener.__ServiceName, "OnReceivedInvitationAdded", ClubMembershipListener.__Marshaller_bgs_protocol_club_v1_membership_ReceivedInvitationAddedNotification, ClubMembershipListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x040039B6 RID: 14774
		private static readonly Method<ReceivedInvitationRemovedNotification, NO_RESPONSE> __Method_OnReceivedInvitationRemoved = new Method<ReceivedInvitationRemovedNotification, NO_RESPONSE>(0, ClubMembershipListener.__ServiceName, "OnReceivedInvitationRemoved", ClubMembershipListener.__Marshaller_bgs_protocol_club_v1_membership_ReceivedInvitationRemovedNotification, ClubMembershipListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x040039B7 RID: 14775
		private static readonly Method<SharedSettingsChangedNotification, NO_RESPONSE> __Method_OnSharedSettingsChanged = new Method<SharedSettingsChangedNotification, NO_RESPONSE>(0, ClubMembershipListener.__ServiceName, "OnSharedSettingsChanged", ClubMembershipListener.__Marshaller_bgs_protocol_club_v1_membership_SharedSettingsChangedNotification, ClubMembershipListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x040039B8 RID: 14776
		private static readonly Method<StreamMentionAddedNotification, NO_RESPONSE> __Method_OnStreamMentionAdded = new Method<StreamMentionAddedNotification, NO_RESPONSE>(0, ClubMembershipListener.__ServiceName, "OnStreamMentionAdded", ClubMembershipListener.__Marshaller_bgs_protocol_club_v1_membership_StreamMentionAddedNotification, ClubMembershipListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x040039B9 RID: 14777
		private static readonly Method<StreamMentionRemovedNotification, NO_RESPONSE> __Method_OnStreamMentionRemoved = new Method<StreamMentionRemovedNotification, NO_RESPONSE>(0, ClubMembershipListener.__ServiceName, "OnStreamMentionRemoved", ClubMembershipListener.__Marshaller_bgs_protocol_club_v1_membership_StreamMentionRemovedNotification, ClubMembershipListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x040039BA RID: 14778
		private static readonly Method<StreamMentionAdvanceViewTimeNotification, NO_RESPONSE> __Method_OnStreamMentionAdvanceViewTime = new Method<StreamMentionAdvanceViewTimeNotification, NO_RESPONSE>(0, ClubMembershipListener.__ServiceName, "OnStreamMentionAdvanceViewTime", ClubMembershipListener.__Marshaller_bgs_protocol_club_v1_membership_StreamMentionAdvanceViewTimeNotification, ClubMembershipListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x02000FDD RID: 4061
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x04009734 RID: 38708
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02000FDE RID: 4062
		[BindServiceMethod(typeof(ClubMembershipListener), "BindService")]
		public abstract class ClubMembershipListenerBase
		{
			// Token: 0x0600CF7C RID: 53116 RVA: 0x004AE531 File Offset: 0x004AC731
			public virtual Task<NO_RESPONSE> OnClubAdded(ClubAddedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600CF7D RID: 53117 RVA: 0x004AE545 File Offset: 0x004AC745
			public virtual Task<NO_RESPONSE> OnClubRemoved(ClubRemovedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600CF7E RID: 53118 RVA: 0x004AE559 File Offset: 0x004AC759
			public virtual Task<NO_RESPONSE> OnReceivedInvitationAdded(ReceivedInvitationAddedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600CF7F RID: 53119 RVA: 0x004AE56D File Offset: 0x004AC76D
			public virtual Task<NO_RESPONSE> OnReceivedInvitationRemoved(ReceivedInvitationRemovedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600CF80 RID: 53120 RVA: 0x004AE581 File Offset: 0x004AC781
			public virtual Task<NO_RESPONSE> OnSharedSettingsChanged(SharedSettingsChangedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600CF81 RID: 53121 RVA: 0x004AE595 File Offset: 0x004AC795
			public virtual Task<NO_RESPONSE> OnStreamMentionAdded(StreamMentionAddedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600CF82 RID: 53122 RVA: 0x004AE5A9 File Offset: 0x004AC7A9
			public virtual Task<NO_RESPONSE> OnStreamMentionRemoved(StreamMentionRemovedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600CF83 RID: 53123 RVA: 0x004AE5BD File Offset: 0x004AC7BD
			public virtual Task<NO_RESPONSE> OnStreamMentionAdvanceViewTime(StreamMentionAdvanceViewTimeNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x02000FDF RID: 4063
		public class ClubMembershipListenerClient : ClientBase<ClubMembershipListener.ClubMembershipListenerClient>
		{
			// Token: 0x0600CF85 RID: 53125 RVA: 0x004AE5DA File Offset: 0x004AC7DA
			public ClubMembershipListenerClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600CF86 RID: 53126 RVA: 0x004AE5E5 File Offset: 0x004AC7E5
			public ClubMembershipListenerClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600CF87 RID: 53127 RVA: 0x004AE5F0 File Offset: 0x004AC7F0
			protected ClubMembershipListenerClient()
			{
			}

			// Token: 0x0600CF88 RID: 53128 RVA: 0x004AE5FA File Offset: 0x004AC7FA
			protected ClubMembershipListenerClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600CF89 RID: 53129 RVA: 0x004AE608 File Offset: 0x004AC808
			public virtual NO_RESPONSE OnClubAdded(ClubAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnClubAdded(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CF8A RID: 53130 RVA: 0x004AE630 File Offset: 0x004AC830
			public virtual NO_RESPONSE OnClubAdded(ClubAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ClubAddedNotification, NO_RESPONSE>(ClubMembershipListener.__Method_OnClubAdded, null, options, request);
			}

			// Token: 0x0600CF8B RID: 53131 RVA: 0x004AE658 File Offset: 0x004AC858
			public virtual AsyncUnaryCall<NO_RESPONSE> OnClubAddedAsync(ClubAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnClubAddedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CF8C RID: 53132 RVA: 0x004AE680 File Offset: 0x004AC880
			public virtual AsyncUnaryCall<NO_RESPONSE> OnClubAddedAsync(ClubAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ClubAddedNotification, NO_RESPONSE>(ClubMembershipListener.__Method_OnClubAdded, null, options, request);
			}

			// Token: 0x0600CF8D RID: 53133 RVA: 0x004AE6A8 File Offset: 0x004AC8A8
			public virtual NO_RESPONSE OnClubRemoved(ClubRemovedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnClubRemoved(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CF8E RID: 53134 RVA: 0x004AE6D0 File Offset: 0x004AC8D0
			public virtual NO_RESPONSE OnClubRemoved(ClubRemovedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ClubRemovedNotification, NO_RESPONSE>(ClubMembershipListener.__Method_OnClubRemoved, null, options, request);
			}

			// Token: 0x0600CF8F RID: 53135 RVA: 0x004AE6F8 File Offset: 0x004AC8F8
			public virtual AsyncUnaryCall<NO_RESPONSE> OnClubRemovedAsync(ClubRemovedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnClubRemovedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CF90 RID: 53136 RVA: 0x004AE720 File Offset: 0x004AC920
			public virtual AsyncUnaryCall<NO_RESPONSE> OnClubRemovedAsync(ClubRemovedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ClubRemovedNotification, NO_RESPONSE>(ClubMembershipListener.__Method_OnClubRemoved, null, options, request);
			}

			// Token: 0x0600CF91 RID: 53137 RVA: 0x004AE748 File Offset: 0x004AC948
			public virtual NO_RESPONSE OnReceivedInvitationAdded(ReceivedInvitationAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnReceivedInvitationAdded(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CF92 RID: 53138 RVA: 0x004AE770 File Offset: 0x004AC970
			public virtual NO_RESPONSE OnReceivedInvitationAdded(ReceivedInvitationAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ReceivedInvitationAddedNotification, NO_RESPONSE>(ClubMembershipListener.__Method_OnReceivedInvitationAdded, null, options, request);
			}

			// Token: 0x0600CF93 RID: 53139 RVA: 0x004AE798 File Offset: 0x004AC998
			public virtual AsyncUnaryCall<NO_RESPONSE> OnReceivedInvitationAddedAsync(ReceivedInvitationAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnReceivedInvitationAddedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CF94 RID: 53140 RVA: 0x004AE7C0 File Offset: 0x004AC9C0
			public virtual AsyncUnaryCall<NO_RESPONSE> OnReceivedInvitationAddedAsync(ReceivedInvitationAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ReceivedInvitationAddedNotification, NO_RESPONSE>(ClubMembershipListener.__Method_OnReceivedInvitationAdded, null, options, request);
			}

			// Token: 0x0600CF95 RID: 53141 RVA: 0x004AE7E8 File Offset: 0x004AC9E8
			public virtual NO_RESPONSE OnReceivedInvitationRemoved(ReceivedInvitationRemovedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnReceivedInvitationRemoved(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CF96 RID: 53142 RVA: 0x004AE810 File Offset: 0x004ACA10
			public virtual NO_RESPONSE OnReceivedInvitationRemoved(ReceivedInvitationRemovedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ReceivedInvitationRemovedNotification, NO_RESPONSE>(ClubMembershipListener.__Method_OnReceivedInvitationRemoved, null, options, request);
			}

			// Token: 0x0600CF97 RID: 53143 RVA: 0x004AE838 File Offset: 0x004ACA38
			public virtual AsyncUnaryCall<NO_RESPONSE> OnReceivedInvitationRemovedAsync(ReceivedInvitationRemovedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnReceivedInvitationRemovedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CF98 RID: 53144 RVA: 0x004AE860 File Offset: 0x004ACA60
			public virtual AsyncUnaryCall<NO_RESPONSE> OnReceivedInvitationRemovedAsync(ReceivedInvitationRemovedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ReceivedInvitationRemovedNotification, NO_RESPONSE>(ClubMembershipListener.__Method_OnReceivedInvitationRemoved, null, options, request);
			}

			// Token: 0x0600CF99 RID: 53145 RVA: 0x004AE888 File Offset: 0x004ACA88
			public virtual NO_RESPONSE OnSharedSettingsChanged(SharedSettingsChangedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSharedSettingsChanged(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CF9A RID: 53146 RVA: 0x004AE8B0 File Offset: 0x004ACAB0
			public virtual NO_RESPONSE OnSharedSettingsChanged(SharedSettingsChangedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SharedSettingsChangedNotification, NO_RESPONSE>(ClubMembershipListener.__Method_OnSharedSettingsChanged, null, options, request);
			}

			// Token: 0x0600CF9B RID: 53147 RVA: 0x004AE8D8 File Offset: 0x004ACAD8
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSharedSettingsChangedAsync(SharedSettingsChangedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSharedSettingsChangedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CF9C RID: 53148 RVA: 0x004AE900 File Offset: 0x004ACB00
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSharedSettingsChangedAsync(SharedSettingsChangedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SharedSettingsChangedNotification, NO_RESPONSE>(ClubMembershipListener.__Method_OnSharedSettingsChanged, null, options, request);
			}

			// Token: 0x0600CF9D RID: 53149 RVA: 0x004AE928 File Offset: 0x004ACB28
			public virtual NO_RESPONSE OnStreamMentionAdded(StreamMentionAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnStreamMentionAdded(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CF9E RID: 53150 RVA: 0x004AE950 File Offset: 0x004ACB50
			public virtual NO_RESPONSE OnStreamMentionAdded(StreamMentionAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<StreamMentionAddedNotification, NO_RESPONSE>(ClubMembershipListener.__Method_OnStreamMentionAdded, null, options, request);
			}

			// Token: 0x0600CF9F RID: 53151 RVA: 0x004AE978 File Offset: 0x004ACB78
			public virtual AsyncUnaryCall<NO_RESPONSE> OnStreamMentionAddedAsync(StreamMentionAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnStreamMentionAddedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CFA0 RID: 53152 RVA: 0x004AE9A0 File Offset: 0x004ACBA0
			public virtual AsyncUnaryCall<NO_RESPONSE> OnStreamMentionAddedAsync(StreamMentionAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<StreamMentionAddedNotification, NO_RESPONSE>(ClubMembershipListener.__Method_OnStreamMentionAdded, null, options, request);
			}

			// Token: 0x0600CFA1 RID: 53153 RVA: 0x004AE9C8 File Offset: 0x004ACBC8
			public virtual NO_RESPONSE OnStreamMentionRemoved(StreamMentionRemovedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnStreamMentionRemoved(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CFA2 RID: 53154 RVA: 0x004AE9F0 File Offset: 0x004ACBF0
			public virtual NO_RESPONSE OnStreamMentionRemoved(StreamMentionRemovedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<StreamMentionRemovedNotification, NO_RESPONSE>(ClubMembershipListener.__Method_OnStreamMentionRemoved, null, options, request);
			}

			// Token: 0x0600CFA3 RID: 53155 RVA: 0x004AEA18 File Offset: 0x004ACC18
			public virtual AsyncUnaryCall<NO_RESPONSE> OnStreamMentionRemovedAsync(StreamMentionRemovedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnStreamMentionRemovedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CFA4 RID: 53156 RVA: 0x004AEA40 File Offset: 0x004ACC40
			public virtual AsyncUnaryCall<NO_RESPONSE> OnStreamMentionRemovedAsync(StreamMentionRemovedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<StreamMentionRemovedNotification, NO_RESPONSE>(ClubMembershipListener.__Method_OnStreamMentionRemoved, null, options, request);
			}

			// Token: 0x0600CFA5 RID: 53157 RVA: 0x004AEA68 File Offset: 0x004ACC68
			public virtual NO_RESPONSE OnStreamMentionAdvanceViewTime(StreamMentionAdvanceViewTimeNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnStreamMentionAdvanceViewTime(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CFA6 RID: 53158 RVA: 0x004AEA90 File Offset: 0x004ACC90
			public virtual NO_RESPONSE OnStreamMentionAdvanceViewTime(StreamMentionAdvanceViewTimeNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<StreamMentionAdvanceViewTimeNotification, NO_RESPONSE>(ClubMembershipListener.__Method_OnStreamMentionAdvanceViewTime, null, options, request);
			}

			// Token: 0x0600CFA7 RID: 53159 RVA: 0x004AEAB8 File Offset: 0x004ACCB8
			public virtual AsyncUnaryCall<NO_RESPONSE> OnStreamMentionAdvanceViewTimeAsync(StreamMentionAdvanceViewTimeNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnStreamMentionAdvanceViewTimeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600CFA8 RID: 53160 RVA: 0x004AEAE0 File Offset: 0x004ACCE0
			public virtual AsyncUnaryCall<NO_RESPONSE> OnStreamMentionAdvanceViewTimeAsync(StreamMentionAdvanceViewTimeNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<StreamMentionAdvanceViewTimeNotification, NO_RESPONSE>(ClubMembershipListener.__Method_OnStreamMentionAdvanceViewTime, null, options, request);
			}

			// Token: 0x0600CFA9 RID: 53161 RVA: 0x004AEB08 File Offset: 0x004ACD08
			protected override ClubMembershipListener.ClubMembershipListenerClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new ClubMembershipListener.ClubMembershipListenerClient(configuration);
			}
		}
	}
}
