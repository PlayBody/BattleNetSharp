using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000683 RID: 1667
	public static class ChannelListener
	{
		// Token: 0x06009ABF RID: 39615 RVA: 0x00258FB8 File Offset: 0x002571B8
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

		// Token: 0x06009AC0 RID: 39616 RVA: 0x00259004 File Offset: 0x00257204
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = ChannelListener.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17003020 RID: 12320
		// (get) Token: 0x06009AC1 RID: 39617 RVA: 0x0025903C File Offset: 0x0025723C
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.Services[1];
			}
		}

		// Token: 0x06009AC2 RID: 39618 RVA: 0x00259060 File Offset: 0x00257260
		public static ServerServiceDefinition BindService(ChannelListener.ChannelListenerBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<MemberAddedNotification, NO_RESPONSE>(ChannelListener.__Method_OnMemberAdded, new UnaryServerMethod<MemberAddedNotification, NO_RESPONSE>(serviceImpl.OnMemberAdded)).AddMethod<MemberRemovedNotification, NO_RESPONSE>(ChannelListener.__Method_OnMemberRemoved, new UnaryServerMethod<MemberRemovedNotification, NO_RESPONSE>(serviceImpl.OnMemberRemoved))
				.AddMethod<MemberAttributeChangedNotification, NO_RESPONSE>(ChannelListener.__Method_OnMemberAttributeChanged, new UnaryServerMethod<MemberAttributeChangedNotification, NO_RESPONSE>(serviceImpl.OnMemberAttributeChanged))
				.AddMethod<MemberRoleChangedNotification, NO_RESPONSE>(ChannelListener.__Method_OnMemberRoleChanged, new UnaryServerMethod<MemberRoleChangedNotification, NO_RESPONSE>(serviceImpl.OnMemberRoleChanged))
				.AddMethod<SendMessageNotification, NO_RESPONSE>(ChannelListener.__Method_OnSendMessage, new UnaryServerMethod<SendMessageNotification, NO_RESPONSE>(serviceImpl.OnSendMessage))
				.AddMethod<TypingIndicatorNotification, NO_RESPONSE>(ChannelListener.__Method_OnTypingIndicator, new UnaryServerMethod<TypingIndicatorNotification, NO_RESPONSE>(serviceImpl.OnTypingIndicator))
				.AddMethod<AttributeChangedNotification, NO_RESPONSE>(ChannelListener.__Method_OnAttributeChanged, new UnaryServerMethod<AttributeChangedNotification, NO_RESPONSE>(serviceImpl.OnAttributeChanged))
				.AddMethod<PrivacyLevelChangedNotification, NO_RESPONSE>(ChannelListener.__Method_OnPrivacyLevelChanged, new UnaryServerMethod<PrivacyLevelChangedNotification, NO_RESPONSE>(serviceImpl.OnPrivacyLevelChanged))
				.AddMethod<InvitationAddedNotification, NO_RESPONSE>(ChannelListener.__Method_OnInvitationAdded, new UnaryServerMethod<InvitationAddedNotification, NO_RESPONSE>(serviceImpl.OnInvitationAdded))
				.AddMethod<InvitationRemovedNotification, NO_RESPONSE>(ChannelListener.__Method_OnInvitationRemoved, new UnaryServerMethod<InvitationRemovedNotification, NO_RESPONSE>(serviceImpl.OnInvitationRemoved))
				.AddMethod<SuggestionAddedNotification, NO_RESPONSE>(ChannelListener.__Method_OnSuggestionAdded, new UnaryServerMethod<SuggestionAddedNotification, NO_RESPONSE>(serviceImpl.OnSuggestionAdded))
				.Build();
		}

		// Token: 0x06009AC3 RID: 39619 RVA: 0x0025917C File Offset: 0x0025737C
		public static void BindService(ServiceBinderBase serviceBinder, ChannelListener.ChannelListenerBase serviceImpl)
		{
			serviceBinder.AddMethod<MemberAddedNotification, NO_RESPONSE>(ChannelListener.__Method_OnMemberAdded, (serviceImpl == null) ? null : new UnaryServerMethod<MemberAddedNotification, NO_RESPONSE>(serviceImpl.OnMemberAdded));
			serviceBinder.AddMethod<MemberRemovedNotification, NO_RESPONSE>(ChannelListener.__Method_OnMemberRemoved, (serviceImpl == null) ? null : new UnaryServerMethod<MemberRemovedNotification, NO_RESPONSE>(serviceImpl.OnMemberRemoved));
			serviceBinder.AddMethod<MemberAttributeChangedNotification, NO_RESPONSE>(ChannelListener.__Method_OnMemberAttributeChanged, (serviceImpl == null) ? null : new UnaryServerMethod<MemberAttributeChangedNotification, NO_RESPONSE>(serviceImpl.OnMemberAttributeChanged));
			serviceBinder.AddMethod<MemberRoleChangedNotification, NO_RESPONSE>(ChannelListener.__Method_OnMemberRoleChanged, (serviceImpl == null) ? null : new UnaryServerMethod<MemberRoleChangedNotification, NO_RESPONSE>(serviceImpl.OnMemberRoleChanged));
			serviceBinder.AddMethod<SendMessageNotification, NO_RESPONSE>(ChannelListener.__Method_OnSendMessage, (serviceImpl == null) ? null : new UnaryServerMethod<SendMessageNotification, NO_RESPONSE>(serviceImpl.OnSendMessage));
			serviceBinder.AddMethod<TypingIndicatorNotification, NO_RESPONSE>(ChannelListener.__Method_OnTypingIndicator, (serviceImpl == null) ? null : new UnaryServerMethod<TypingIndicatorNotification, NO_RESPONSE>(serviceImpl.OnTypingIndicator));
			serviceBinder.AddMethod<AttributeChangedNotification, NO_RESPONSE>(ChannelListener.__Method_OnAttributeChanged, (serviceImpl == null) ? null : new UnaryServerMethod<AttributeChangedNotification, NO_RESPONSE>(serviceImpl.OnAttributeChanged));
			serviceBinder.AddMethod<PrivacyLevelChangedNotification, NO_RESPONSE>(ChannelListener.__Method_OnPrivacyLevelChanged, (serviceImpl == null) ? null : new UnaryServerMethod<PrivacyLevelChangedNotification, NO_RESPONSE>(serviceImpl.OnPrivacyLevelChanged));
			serviceBinder.AddMethod<InvitationAddedNotification, NO_RESPONSE>(ChannelListener.__Method_OnInvitationAdded, (serviceImpl == null) ? null : new UnaryServerMethod<InvitationAddedNotification, NO_RESPONSE>(serviceImpl.OnInvitationAdded));
			serviceBinder.AddMethod<InvitationRemovedNotification, NO_RESPONSE>(ChannelListener.__Method_OnInvitationRemoved, (serviceImpl == null) ? null : new UnaryServerMethod<InvitationRemovedNotification, NO_RESPONSE>(serviceImpl.OnInvitationRemoved));
			serviceBinder.AddMethod<SuggestionAddedNotification, NO_RESPONSE>(ChannelListener.__Method_OnSuggestionAdded, (serviceImpl == null) ? null : new UnaryServerMethod<SuggestionAddedNotification, NO_RESPONSE>(serviceImpl.OnSuggestionAdded));
		}

		// Token: 0x040045C1 RID: 17857
		private static readonly string __ServiceName = "bgs.protocol.channel.v2.ChannelListener";

		// Token: 0x040045C2 RID: 17858
		private static readonly Marshaller<MemberAddedNotification> __Marshaller_bgs_protocol_channel_v2_MemberAddedNotification = Marshallers.Create<MemberAddedNotification>(new Action<MemberAddedNotification, SerializationContext>(ChannelListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelListener.__Helper_DeserializeMessage<MemberAddedNotification>(context, MemberAddedNotification.Parser));

		// Token: 0x040045C3 RID: 17859
		private static readonly Marshaller<NO_RESPONSE> __Marshaller_bgs_protocol_NO_RESPONSE = Marshallers.Create<NO_RESPONSE>(new Action<NO_RESPONSE, SerializationContext>(ChannelListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelListener.__Helper_DeserializeMessage<NO_RESPONSE>(context, NO_RESPONSE.Parser));

		// Token: 0x040045C4 RID: 17860
		private static readonly Marshaller<MemberRemovedNotification> __Marshaller_bgs_protocol_channel_v2_MemberRemovedNotification = Marshallers.Create<MemberRemovedNotification>(new Action<MemberRemovedNotification, SerializationContext>(ChannelListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelListener.__Helper_DeserializeMessage<MemberRemovedNotification>(context, MemberRemovedNotification.Parser));

		// Token: 0x040045C5 RID: 17861
		private static readonly Marshaller<MemberAttributeChangedNotification> __Marshaller_bgs_protocol_channel_v2_MemberAttributeChangedNotification = Marshallers.Create<MemberAttributeChangedNotification>(new Action<MemberAttributeChangedNotification, SerializationContext>(ChannelListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelListener.__Helper_DeserializeMessage<MemberAttributeChangedNotification>(context, MemberAttributeChangedNotification.Parser));

		// Token: 0x040045C6 RID: 17862
		private static readonly Marshaller<MemberRoleChangedNotification> __Marshaller_bgs_protocol_channel_v2_MemberRoleChangedNotification = Marshallers.Create<MemberRoleChangedNotification>(new Action<MemberRoleChangedNotification, SerializationContext>(ChannelListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelListener.__Helper_DeserializeMessage<MemberRoleChangedNotification>(context, MemberRoleChangedNotification.Parser));

		// Token: 0x040045C7 RID: 17863
		private static readonly Marshaller<SendMessageNotification> __Marshaller_bgs_protocol_channel_v2_SendMessageNotification = Marshallers.Create<SendMessageNotification>(new Action<SendMessageNotification, SerializationContext>(ChannelListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelListener.__Helper_DeserializeMessage<SendMessageNotification>(context, SendMessageNotification.Parser));

		// Token: 0x040045C8 RID: 17864
		private static readonly Marshaller<TypingIndicatorNotification> __Marshaller_bgs_protocol_channel_v2_TypingIndicatorNotification = Marshallers.Create<TypingIndicatorNotification>(new Action<TypingIndicatorNotification, SerializationContext>(ChannelListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelListener.__Helper_DeserializeMessage<TypingIndicatorNotification>(context, TypingIndicatorNotification.Parser));

		// Token: 0x040045C9 RID: 17865
		private static readonly Marshaller<AttributeChangedNotification> __Marshaller_bgs_protocol_channel_v2_AttributeChangedNotification = Marshallers.Create<AttributeChangedNotification>(new Action<AttributeChangedNotification, SerializationContext>(ChannelListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelListener.__Helper_DeserializeMessage<AttributeChangedNotification>(context, AttributeChangedNotification.Parser));

		// Token: 0x040045CA RID: 17866
		private static readonly Marshaller<PrivacyLevelChangedNotification> __Marshaller_bgs_protocol_channel_v2_PrivacyLevelChangedNotification = Marshallers.Create<PrivacyLevelChangedNotification>(new Action<PrivacyLevelChangedNotification, SerializationContext>(ChannelListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelListener.__Helper_DeserializeMessage<PrivacyLevelChangedNotification>(context, PrivacyLevelChangedNotification.Parser));

		// Token: 0x040045CB RID: 17867
		private static readonly Marshaller<InvitationAddedNotification> __Marshaller_bgs_protocol_channel_v2_InvitationAddedNotification = Marshallers.Create<InvitationAddedNotification>(new Action<InvitationAddedNotification, SerializationContext>(ChannelListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelListener.__Helper_DeserializeMessage<InvitationAddedNotification>(context, InvitationAddedNotification.Parser));

		// Token: 0x040045CC RID: 17868
		private static readonly Marshaller<InvitationRemovedNotification> __Marshaller_bgs_protocol_channel_v2_InvitationRemovedNotification = Marshallers.Create<InvitationRemovedNotification>(new Action<InvitationRemovedNotification, SerializationContext>(ChannelListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelListener.__Helper_DeserializeMessage<InvitationRemovedNotification>(context, InvitationRemovedNotification.Parser));

		// Token: 0x040045CD RID: 17869
		private static readonly Marshaller<SuggestionAddedNotification> __Marshaller_bgs_protocol_channel_v2_SuggestionAddedNotification = Marshallers.Create<SuggestionAddedNotification>(new Action<SuggestionAddedNotification, SerializationContext>(ChannelListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelListener.__Helper_DeserializeMessage<SuggestionAddedNotification>(context, SuggestionAddedNotification.Parser));

		// Token: 0x040045CE RID: 17870
		private static readonly Method<MemberAddedNotification, NO_RESPONSE> __Method_OnMemberAdded = new Method<MemberAddedNotification, NO_RESPONSE>(0, ChannelListener.__ServiceName, "OnMemberAdded", ChannelListener.__Marshaller_bgs_protocol_channel_v2_MemberAddedNotification, ChannelListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x040045CF RID: 17871
		private static readonly Method<MemberRemovedNotification, NO_RESPONSE> __Method_OnMemberRemoved = new Method<MemberRemovedNotification, NO_RESPONSE>(0, ChannelListener.__ServiceName, "OnMemberRemoved", ChannelListener.__Marshaller_bgs_protocol_channel_v2_MemberRemovedNotification, ChannelListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x040045D0 RID: 17872
		private static readonly Method<MemberAttributeChangedNotification, NO_RESPONSE> __Method_OnMemberAttributeChanged = new Method<MemberAttributeChangedNotification, NO_RESPONSE>(0, ChannelListener.__ServiceName, "OnMemberAttributeChanged", ChannelListener.__Marshaller_bgs_protocol_channel_v2_MemberAttributeChangedNotification, ChannelListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x040045D1 RID: 17873
		private static readonly Method<MemberRoleChangedNotification, NO_RESPONSE> __Method_OnMemberRoleChanged = new Method<MemberRoleChangedNotification, NO_RESPONSE>(0, ChannelListener.__ServiceName, "OnMemberRoleChanged", ChannelListener.__Marshaller_bgs_protocol_channel_v2_MemberRoleChangedNotification, ChannelListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x040045D2 RID: 17874
		private static readonly Method<SendMessageNotification, NO_RESPONSE> __Method_OnSendMessage = new Method<SendMessageNotification, NO_RESPONSE>(0, ChannelListener.__ServiceName, "OnSendMessage", ChannelListener.__Marshaller_bgs_protocol_channel_v2_SendMessageNotification, ChannelListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x040045D3 RID: 17875
		private static readonly Method<TypingIndicatorNotification, NO_RESPONSE> __Method_OnTypingIndicator = new Method<TypingIndicatorNotification, NO_RESPONSE>(0, ChannelListener.__ServiceName, "OnTypingIndicator", ChannelListener.__Marshaller_bgs_protocol_channel_v2_TypingIndicatorNotification, ChannelListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x040045D4 RID: 17876
		private static readonly Method<AttributeChangedNotification, NO_RESPONSE> __Method_OnAttributeChanged = new Method<AttributeChangedNotification, NO_RESPONSE>(0, ChannelListener.__ServiceName, "OnAttributeChanged", ChannelListener.__Marshaller_bgs_protocol_channel_v2_AttributeChangedNotification, ChannelListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x040045D5 RID: 17877
		private static readonly Method<PrivacyLevelChangedNotification, NO_RESPONSE> __Method_OnPrivacyLevelChanged = new Method<PrivacyLevelChangedNotification, NO_RESPONSE>(0, ChannelListener.__ServiceName, "OnPrivacyLevelChanged", ChannelListener.__Marshaller_bgs_protocol_channel_v2_PrivacyLevelChangedNotification, ChannelListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x040045D6 RID: 17878
		private static readonly Method<InvitationAddedNotification, NO_RESPONSE> __Method_OnInvitationAdded = new Method<InvitationAddedNotification, NO_RESPONSE>(0, ChannelListener.__ServiceName, "OnInvitationAdded", ChannelListener.__Marshaller_bgs_protocol_channel_v2_InvitationAddedNotification, ChannelListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x040045D7 RID: 17879
		private static readonly Method<InvitationRemovedNotification, NO_RESPONSE> __Method_OnInvitationRemoved = new Method<InvitationRemovedNotification, NO_RESPONSE>(0, ChannelListener.__ServiceName, "OnInvitationRemoved", ChannelListener.__Marshaller_bgs_protocol_channel_v2_InvitationRemovedNotification, ChannelListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x040045D8 RID: 17880
		private static readonly Method<SuggestionAddedNotification, NO_RESPONSE> __Method_OnSuggestionAdded = new Method<SuggestionAddedNotification, NO_RESPONSE>(0, ChannelListener.__ServiceName, "OnSuggestionAdded", ChannelListener.__Marshaller_bgs_protocol_channel_v2_SuggestionAddedNotification, ChannelListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x0200117B RID: 4475
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x040098B3 RID: 39091
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x0200117C RID: 4476
		[BindServiceMethod(typeof(ChannelListener), "BindService")]
		public abstract class ChannelListenerBase
		{
			// Token: 0x0600D791 RID: 55185 RVA: 0x004B86AA File Offset: 0x004B68AA
			public virtual Task<NO_RESPONSE> OnMemberAdded(MemberAddedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D792 RID: 55186 RVA: 0x004B86BE File Offset: 0x004B68BE
			public virtual Task<NO_RESPONSE> OnMemberRemoved(MemberRemovedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D793 RID: 55187 RVA: 0x004B86D2 File Offset: 0x004B68D2
			public virtual Task<NO_RESPONSE> OnMemberAttributeChanged(MemberAttributeChangedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D794 RID: 55188 RVA: 0x004B86E6 File Offset: 0x004B68E6
			public virtual Task<NO_RESPONSE> OnMemberRoleChanged(MemberRoleChangedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D795 RID: 55189 RVA: 0x004B86FA File Offset: 0x004B68FA
			public virtual Task<NO_RESPONSE> OnSendMessage(SendMessageNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D796 RID: 55190 RVA: 0x004B870E File Offset: 0x004B690E
			public virtual Task<NO_RESPONSE> OnTypingIndicator(TypingIndicatorNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D797 RID: 55191 RVA: 0x004B8722 File Offset: 0x004B6922
			public virtual Task<NO_RESPONSE> OnAttributeChanged(AttributeChangedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D798 RID: 55192 RVA: 0x004B8736 File Offset: 0x004B6936
			public virtual Task<NO_RESPONSE> OnPrivacyLevelChanged(PrivacyLevelChangedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D799 RID: 55193 RVA: 0x004B874A File Offset: 0x004B694A
			public virtual Task<NO_RESPONSE> OnInvitationAdded(InvitationAddedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D79A RID: 55194 RVA: 0x004B875E File Offset: 0x004B695E
			public virtual Task<NO_RESPONSE> OnInvitationRemoved(InvitationRemovedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D79B RID: 55195 RVA: 0x004B8772 File Offset: 0x004B6972
			public virtual Task<NO_RESPONSE> OnSuggestionAdded(SuggestionAddedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x0200117D RID: 4477
		public class ChannelListenerClient : ClientBase<ChannelListener.ChannelListenerClient>
		{
			// Token: 0x0600D79D RID: 55197 RVA: 0x004B878F File Offset: 0x004B698F
			public ChannelListenerClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D79E RID: 55198 RVA: 0x004B879A File Offset: 0x004B699A
			public ChannelListenerClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D79F RID: 55199 RVA: 0x004B87A5 File Offset: 0x004B69A5
			protected ChannelListenerClient()
			{
			}

			// Token: 0x0600D7A0 RID: 55200 RVA: 0x004B87AF File Offset: 0x004B69AF
			protected ChannelListenerClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D7A1 RID: 55201 RVA: 0x004B87BC File Offset: 0x004B69BC
			public virtual NO_RESPONSE OnMemberAdded(MemberAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnMemberAdded(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D7A2 RID: 55202 RVA: 0x004B87E4 File Offset: 0x004B69E4
			public virtual NO_RESPONSE OnMemberAdded(MemberAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<MemberAddedNotification, NO_RESPONSE>(ChannelListener.__Method_OnMemberAdded, null, options, request);
			}

			// Token: 0x0600D7A3 RID: 55203 RVA: 0x004B880C File Offset: 0x004B6A0C
			public virtual AsyncUnaryCall<NO_RESPONSE> OnMemberAddedAsync(MemberAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnMemberAddedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D7A4 RID: 55204 RVA: 0x004B8834 File Offset: 0x004B6A34
			public virtual AsyncUnaryCall<NO_RESPONSE> OnMemberAddedAsync(MemberAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<MemberAddedNotification, NO_RESPONSE>(ChannelListener.__Method_OnMemberAdded, null, options, request);
			}

			// Token: 0x0600D7A5 RID: 55205 RVA: 0x004B885C File Offset: 0x004B6A5C
			public virtual NO_RESPONSE OnMemberRemoved(MemberRemovedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnMemberRemoved(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D7A6 RID: 55206 RVA: 0x004B8884 File Offset: 0x004B6A84
			public virtual NO_RESPONSE OnMemberRemoved(MemberRemovedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<MemberRemovedNotification, NO_RESPONSE>(ChannelListener.__Method_OnMemberRemoved, null, options, request);
			}

			// Token: 0x0600D7A7 RID: 55207 RVA: 0x004B88AC File Offset: 0x004B6AAC
			public virtual AsyncUnaryCall<NO_RESPONSE> OnMemberRemovedAsync(MemberRemovedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnMemberRemovedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D7A8 RID: 55208 RVA: 0x004B88D4 File Offset: 0x004B6AD4
			public virtual AsyncUnaryCall<NO_RESPONSE> OnMemberRemovedAsync(MemberRemovedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<MemberRemovedNotification, NO_RESPONSE>(ChannelListener.__Method_OnMemberRemoved, null, options, request);
			}

			// Token: 0x0600D7A9 RID: 55209 RVA: 0x004B88FC File Offset: 0x004B6AFC
			public virtual NO_RESPONSE OnMemberAttributeChanged(MemberAttributeChangedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnMemberAttributeChanged(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D7AA RID: 55210 RVA: 0x004B8924 File Offset: 0x004B6B24
			public virtual NO_RESPONSE OnMemberAttributeChanged(MemberAttributeChangedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<MemberAttributeChangedNotification, NO_RESPONSE>(ChannelListener.__Method_OnMemberAttributeChanged, null, options, request);
			}

			// Token: 0x0600D7AB RID: 55211 RVA: 0x004B894C File Offset: 0x004B6B4C
			public virtual AsyncUnaryCall<NO_RESPONSE> OnMemberAttributeChangedAsync(MemberAttributeChangedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnMemberAttributeChangedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D7AC RID: 55212 RVA: 0x004B8974 File Offset: 0x004B6B74
			public virtual AsyncUnaryCall<NO_RESPONSE> OnMemberAttributeChangedAsync(MemberAttributeChangedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<MemberAttributeChangedNotification, NO_RESPONSE>(ChannelListener.__Method_OnMemberAttributeChanged, null, options, request);
			}

			// Token: 0x0600D7AD RID: 55213 RVA: 0x004B899C File Offset: 0x004B6B9C
			public virtual NO_RESPONSE OnMemberRoleChanged(MemberRoleChangedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnMemberRoleChanged(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D7AE RID: 55214 RVA: 0x004B89C4 File Offset: 0x004B6BC4
			public virtual NO_RESPONSE OnMemberRoleChanged(MemberRoleChangedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<MemberRoleChangedNotification, NO_RESPONSE>(ChannelListener.__Method_OnMemberRoleChanged, null, options, request);
			}

			// Token: 0x0600D7AF RID: 55215 RVA: 0x004B89EC File Offset: 0x004B6BEC
			public virtual AsyncUnaryCall<NO_RESPONSE> OnMemberRoleChangedAsync(MemberRoleChangedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnMemberRoleChangedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D7B0 RID: 55216 RVA: 0x004B8A14 File Offset: 0x004B6C14
			public virtual AsyncUnaryCall<NO_RESPONSE> OnMemberRoleChangedAsync(MemberRoleChangedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<MemberRoleChangedNotification, NO_RESPONSE>(ChannelListener.__Method_OnMemberRoleChanged, null, options, request);
			}

			// Token: 0x0600D7B1 RID: 55217 RVA: 0x004B8A3C File Offset: 0x004B6C3C
			public virtual NO_RESPONSE OnSendMessage(SendMessageNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSendMessage(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D7B2 RID: 55218 RVA: 0x004B8A64 File Offset: 0x004B6C64
			public virtual NO_RESPONSE OnSendMessage(SendMessageNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SendMessageNotification, NO_RESPONSE>(ChannelListener.__Method_OnSendMessage, null, options, request);
			}

			// Token: 0x0600D7B3 RID: 55219 RVA: 0x004B8A8C File Offset: 0x004B6C8C
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSendMessageAsync(SendMessageNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSendMessageAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D7B4 RID: 55220 RVA: 0x004B8AB4 File Offset: 0x004B6CB4
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSendMessageAsync(SendMessageNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SendMessageNotification, NO_RESPONSE>(ChannelListener.__Method_OnSendMessage, null, options, request);
			}

			// Token: 0x0600D7B5 RID: 55221 RVA: 0x004B8ADC File Offset: 0x004B6CDC
			public virtual NO_RESPONSE OnTypingIndicator(TypingIndicatorNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnTypingIndicator(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D7B6 RID: 55222 RVA: 0x004B8B04 File Offset: 0x004B6D04
			public virtual NO_RESPONSE OnTypingIndicator(TypingIndicatorNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<TypingIndicatorNotification, NO_RESPONSE>(ChannelListener.__Method_OnTypingIndicator, null, options, request);
			}

			// Token: 0x0600D7B7 RID: 55223 RVA: 0x004B8B2C File Offset: 0x004B6D2C
			public virtual AsyncUnaryCall<NO_RESPONSE> OnTypingIndicatorAsync(TypingIndicatorNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnTypingIndicatorAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D7B8 RID: 55224 RVA: 0x004B8B54 File Offset: 0x004B6D54
			public virtual AsyncUnaryCall<NO_RESPONSE> OnTypingIndicatorAsync(TypingIndicatorNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<TypingIndicatorNotification, NO_RESPONSE>(ChannelListener.__Method_OnTypingIndicator, null, options, request);
			}

			// Token: 0x0600D7B9 RID: 55225 RVA: 0x004B8B7C File Offset: 0x004B6D7C
			public virtual NO_RESPONSE OnAttributeChanged(AttributeChangedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnAttributeChanged(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D7BA RID: 55226 RVA: 0x004B8BA4 File Offset: 0x004B6DA4
			public virtual NO_RESPONSE OnAttributeChanged(AttributeChangedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<AttributeChangedNotification, NO_RESPONSE>(ChannelListener.__Method_OnAttributeChanged, null, options, request);
			}

			// Token: 0x0600D7BB RID: 55227 RVA: 0x004B8BCC File Offset: 0x004B6DCC
			public virtual AsyncUnaryCall<NO_RESPONSE> OnAttributeChangedAsync(AttributeChangedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnAttributeChangedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D7BC RID: 55228 RVA: 0x004B8BF4 File Offset: 0x004B6DF4
			public virtual AsyncUnaryCall<NO_RESPONSE> OnAttributeChangedAsync(AttributeChangedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<AttributeChangedNotification, NO_RESPONSE>(ChannelListener.__Method_OnAttributeChanged, null, options, request);
			}

			// Token: 0x0600D7BD RID: 55229 RVA: 0x004B8C1C File Offset: 0x004B6E1C
			public virtual NO_RESPONSE OnPrivacyLevelChanged(PrivacyLevelChangedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnPrivacyLevelChanged(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D7BE RID: 55230 RVA: 0x004B8C44 File Offset: 0x004B6E44
			public virtual NO_RESPONSE OnPrivacyLevelChanged(PrivacyLevelChangedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<PrivacyLevelChangedNotification, NO_RESPONSE>(ChannelListener.__Method_OnPrivacyLevelChanged, null, options, request);
			}

			// Token: 0x0600D7BF RID: 55231 RVA: 0x004B8C6C File Offset: 0x004B6E6C
			public virtual AsyncUnaryCall<NO_RESPONSE> OnPrivacyLevelChangedAsync(PrivacyLevelChangedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnPrivacyLevelChangedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D7C0 RID: 55232 RVA: 0x004B8C94 File Offset: 0x004B6E94
			public virtual AsyncUnaryCall<NO_RESPONSE> OnPrivacyLevelChangedAsync(PrivacyLevelChangedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<PrivacyLevelChangedNotification, NO_RESPONSE>(ChannelListener.__Method_OnPrivacyLevelChanged, null, options, request);
			}

			// Token: 0x0600D7C1 RID: 55233 RVA: 0x004B8CBC File Offset: 0x004B6EBC
			public virtual NO_RESPONSE OnInvitationAdded(InvitationAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnInvitationAdded(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D7C2 RID: 55234 RVA: 0x004B8CE4 File Offset: 0x004B6EE4
			public virtual NO_RESPONSE OnInvitationAdded(InvitationAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<InvitationAddedNotification, NO_RESPONSE>(ChannelListener.__Method_OnInvitationAdded, null, options, request);
			}

			// Token: 0x0600D7C3 RID: 55235 RVA: 0x004B8D0C File Offset: 0x004B6F0C
			public virtual AsyncUnaryCall<NO_RESPONSE> OnInvitationAddedAsync(InvitationAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnInvitationAddedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D7C4 RID: 55236 RVA: 0x004B8D34 File Offset: 0x004B6F34
			public virtual AsyncUnaryCall<NO_RESPONSE> OnInvitationAddedAsync(InvitationAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<InvitationAddedNotification, NO_RESPONSE>(ChannelListener.__Method_OnInvitationAdded, null, options, request);
			}

			// Token: 0x0600D7C5 RID: 55237 RVA: 0x004B8D5C File Offset: 0x004B6F5C
			public virtual NO_RESPONSE OnInvitationRemoved(InvitationRemovedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnInvitationRemoved(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D7C6 RID: 55238 RVA: 0x004B8D84 File Offset: 0x004B6F84
			public virtual NO_RESPONSE OnInvitationRemoved(InvitationRemovedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<InvitationRemovedNotification, NO_RESPONSE>(ChannelListener.__Method_OnInvitationRemoved, null, options, request);
			}

			// Token: 0x0600D7C7 RID: 55239 RVA: 0x004B8DAC File Offset: 0x004B6FAC
			public virtual AsyncUnaryCall<NO_RESPONSE> OnInvitationRemovedAsync(InvitationRemovedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnInvitationRemovedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D7C8 RID: 55240 RVA: 0x004B8DD4 File Offset: 0x004B6FD4
			public virtual AsyncUnaryCall<NO_RESPONSE> OnInvitationRemovedAsync(InvitationRemovedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<InvitationRemovedNotification, NO_RESPONSE>(ChannelListener.__Method_OnInvitationRemoved, null, options, request);
			}

			// Token: 0x0600D7C9 RID: 55241 RVA: 0x004B8DFC File Offset: 0x004B6FFC
			public virtual NO_RESPONSE OnSuggestionAdded(SuggestionAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSuggestionAdded(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D7CA RID: 55242 RVA: 0x004B8E24 File Offset: 0x004B7024
			public virtual NO_RESPONSE OnSuggestionAdded(SuggestionAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SuggestionAddedNotification, NO_RESPONSE>(ChannelListener.__Method_OnSuggestionAdded, null, options, request);
			}

			// Token: 0x0600D7CB RID: 55243 RVA: 0x004B8E4C File Offset: 0x004B704C
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSuggestionAddedAsync(SuggestionAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSuggestionAddedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D7CC RID: 55244 RVA: 0x004B8E74 File Offset: 0x004B7074
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSuggestionAddedAsync(SuggestionAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SuggestionAddedNotification, NO_RESPONSE>(ChannelListener.__Method_OnSuggestionAdded, null, options, request);
			}

			// Token: 0x0600D7CD RID: 55245 RVA: 0x004B8E9C File Offset: 0x004B709C
			protected override ChannelListener.ChannelListenerClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new ChannelListener.ChannelListenerClient(configuration);
			}
		}
	}
}
