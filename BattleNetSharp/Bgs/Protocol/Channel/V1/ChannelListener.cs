using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006E5 RID: 1765
	public static class ChannelListener
	{
		// Token: 0x0600A2BF RID: 41663 RVA: 0x0027A734 File Offset: 0x00278934
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

		// Token: 0x0600A2C0 RID: 41664 RVA: 0x0027A780 File Offset: 0x00278980
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

		// Token: 0x17003264 RID: 12900
		// (get) Token: 0x0600A2C1 RID: 41665 RVA: 0x0027A7B8 File Offset: 0x002789B8
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.Services[1];
			}
		}

		// Token: 0x0600A2C2 RID: 41666 RVA: 0x0027A7DC File Offset: 0x002789DC
		public static ServerServiceDefinition BindService(ChannelListener.ChannelListenerBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<JoinNotification, NO_RESPONSE>(ChannelListener.__Method_OnJoin, new UnaryServerMethod<JoinNotification, NO_RESPONSE>(serviceImpl.OnJoin)).AddMethod<MemberAddedNotification, NO_RESPONSE>(ChannelListener.__Method_OnMemberAdded, new UnaryServerMethod<MemberAddedNotification, NO_RESPONSE>(serviceImpl.OnMemberAdded))
				.AddMethod<LeaveNotification, NO_RESPONSE>(ChannelListener.__Method_OnLeave, new UnaryServerMethod<LeaveNotification, NO_RESPONSE>(serviceImpl.OnLeave))
				.AddMethod<MemberRemovedNotification, NO_RESPONSE>(ChannelListener.__Method_OnMemberRemoved, new UnaryServerMethod<MemberRemovedNotification, NO_RESPONSE>(serviceImpl.OnMemberRemoved))
				.AddMethod<SendMessageNotification, NO_RESPONSE>(ChannelListener.__Method_OnSendMessage, new UnaryServerMethod<SendMessageNotification, NO_RESPONSE>(serviceImpl.OnSendMessage))
				.AddMethod<UpdateChannelStateNotification, NO_RESPONSE>(ChannelListener.__Method_OnUpdateChannelState, new UnaryServerMethod<UpdateChannelStateNotification, NO_RESPONSE>(serviceImpl.OnUpdateChannelState))
				.AddMethod<UpdateMemberStateNotification, NO_RESPONSE>(ChannelListener.__Method_OnUpdateMemberState, new UnaryServerMethod<UpdateMemberStateNotification, NO_RESPONSE>(serviceImpl.OnUpdateMemberState))
				.Build();
		}

		// Token: 0x0600A2C3 RID: 41667 RVA: 0x0027A89C File Offset: 0x00278A9C
		public static void BindService(ServiceBinderBase serviceBinder, ChannelListener.ChannelListenerBase serviceImpl)
		{
			serviceBinder.AddMethod<JoinNotification, NO_RESPONSE>(ChannelListener.__Method_OnJoin, (serviceImpl == null) ? null : new UnaryServerMethod<JoinNotification, NO_RESPONSE>(serviceImpl.OnJoin));
			serviceBinder.AddMethod<MemberAddedNotification, NO_RESPONSE>(ChannelListener.__Method_OnMemberAdded, (serviceImpl == null) ? null : new UnaryServerMethod<MemberAddedNotification, NO_RESPONSE>(serviceImpl.OnMemberAdded));
			serviceBinder.AddMethod<LeaveNotification, NO_RESPONSE>(ChannelListener.__Method_OnLeave, (serviceImpl == null) ? null : new UnaryServerMethod<LeaveNotification, NO_RESPONSE>(serviceImpl.OnLeave));
			serviceBinder.AddMethod<MemberRemovedNotification, NO_RESPONSE>(ChannelListener.__Method_OnMemberRemoved, (serviceImpl == null) ? null : new UnaryServerMethod<MemberRemovedNotification, NO_RESPONSE>(serviceImpl.OnMemberRemoved));
			serviceBinder.AddMethod<SendMessageNotification, NO_RESPONSE>(ChannelListener.__Method_OnSendMessage, (serviceImpl == null) ? null : new UnaryServerMethod<SendMessageNotification, NO_RESPONSE>(serviceImpl.OnSendMessage));
			serviceBinder.AddMethod<UpdateChannelStateNotification, NO_RESPONSE>(ChannelListener.__Method_OnUpdateChannelState, (serviceImpl == null) ? null : new UnaryServerMethod<UpdateChannelStateNotification, NO_RESPONSE>(serviceImpl.OnUpdateChannelState));
			serviceBinder.AddMethod<UpdateMemberStateNotification, NO_RESPONSE>(ChannelListener.__Method_OnUpdateMemberState, (serviceImpl == null) ? null : new UnaryServerMethod<UpdateMemberStateNotification, NO_RESPONSE>(serviceImpl.OnUpdateMemberState));
		}

		// Token: 0x04004959 RID: 18777
		private static readonly string __ServiceName = "bgs.protocol.channel.v1.ChannelListener";

		// Token: 0x0400495A RID: 18778
		private static readonly Marshaller<JoinNotification> __Marshaller_bgs_protocol_channel_v1_JoinNotification = Marshallers.Create<JoinNotification>(new Action<JoinNotification, SerializationContext>(ChannelListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelListener.__Helper_DeserializeMessage<JoinNotification>(context, JoinNotification.Parser));

		// Token: 0x0400495B RID: 18779
		private static readonly Marshaller<NO_RESPONSE> __Marshaller_bgs_protocol_NO_RESPONSE = Marshallers.Create<NO_RESPONSE>(new Action<NO_RESPONSE, SerializationContext>(ChannelListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelListener.__Helper_DeserializeMessage<NO_RESPONSE>(context, NO_RESPONSE.Parser));

		// Token: 0x0400495C RID: 18780
		private static readonly Marshaller<MemberAddedNotification> __Marshaller_bgs_protocol_channel_v1_MemberAddedNotification = Marshallers.Create<MemberAddedNotification>(new Action<MemberAddedNotification, SerializationContext>(ChannelListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelListener.__Helper_DeserializeMessage<MemberAddedNotification>(context, MemberAddedNotification.Parser));

		// Token: 0x0400495D RID: 18781
		private static readonly Marshaller<LeaveNotification> __Marshaller_bgs_protocol_channel_v1_LeaveNotification = Marshallers.Create<LeaveNotification>(new Action<LeaveNotification, SerializationContext>(ChannelListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelListener.__Helper_DeserializeMessage<LeaveNotification>(context, LeaveNotification.Parser));

		// Token: 0x0400495E RID: 18782
		private static readonly Marshaller<MemberRemovedNotification> __Marshaller_bgs_protocol_channel_v1_MemberRemovedNotification = Marshallers.Create<MemberRemovedNotification>(new Action<MemberRemovedNotification, SerializationContext>(ChannelListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelListener.__Helper_DeserializeMessage<MemberRemovedNotification>(context, MemberRemovedNotification.Parser));

		// Token: 0x0400495F RID: 18783
		private static readonly Marshaller<SendMessageNotification> __Marshaller_bgs_protocol_channel_v1_SendMessageNotification = Marshallers.Create<SendMessageNotification>(new Action<SendMessageNotification, SerializationContext>(ChannelListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelListener.__Helper_DeserializeMessage<SendMessageNotification>(context, SendMessageNotification.Parser));

		// Token: 0x04004960 RID: 18784
		private static readonly Marshaller<UpdateChannelStateNotification> __Marshaller_bgs_protocol_channel_v1_UpdateChannelStateNotification = Marshallers.Create<UpdateChannelStateNotification>(new Action<UpdateChannelStateNotification, SerializationContext>(ChannelListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelListener.__Helper_DeserializeMessage<UpdateChannelStateNotification>(context, UpdateChannelStateNotification.Parser));

		// Token: 0x04004961 RID: 18785
		private static readonly Marshaller<UpdateMemberStateNotification> __Marshaller_bgs_protocol_channel_v1_UpdateMemberStateNotification = Marshallers.Create<UpdateMemberStateNotification>(new Action<UpdateMemberStateNotification, SerializationContext>(ChannelListener.__Helper_SerializeMessage), (DeserializationContext context) => ChannelListener.__Helper_DeserializeMessage<UpdateMemberStateNotification>(context, UpdateMemberStateNotification.Parser));

		// Token: 0x04004962 RID: 18786
		private static readonly Method<JoinNotification, NO_RESPONSE> __Method_OnJoin = new Method<JoinNotification, NO_RESPONSE>(0, ChannelListener.__ServiceName, "OnJoin", ChannelListener.__Marshaller_bgs_protocol_channel_v1_JoinNotification, ChannelListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04004963 RID: 18787
		private static readonly Method<MemberAddedNotification, NO_RESPONSE> __Method_OnMemberAdded = new Method<MemberAddedNotification, NO_RESPONSE>(0, ChannelListener.__ServiceName, "OnMemberAdded", ChannelListener.__Marshaller_bgs_protocol_channel_v1_MemberAddedNotification, ChannelListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04004964 RID: 18788
		private static readonly Method<LeaveNotification, NO_RESPONSE> __Method_OnLeave = new Method<LeaveNotification, NO_RESPONSE>(0, ChannelListener.__ServiceName, "OnLeave", ChannelListener.__Marshaller_bgs_protocol_channel_v1_LeaveNotification, ChannelListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04004965 RID: 18789
		private static readonly Method<MemberRemovedNotification, NO_RESPONSE> __Method_OnMemberRemoved = new Method<MemberRemovedNotification, NO_RESPONSE>(0, ChannelListener.__ServiceName, "OnMemberRemoved", ChannelListener.__Marshaller_bgs_protocol_channel_v1_MemberRemovedNotification, ChannelListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04004966 RID: 18790
		private static readonly Method<SendMessageNotification, NO_RESPONSE> __Method_OnSendMessage = new Method<SendMessageNotification, NO_RESPONSE>(0, ChannelListener.__ServiceName, "OnSendMessage", ChannelListener.__Marshaller_bgs_protocol_channel_v1_SendMessageNotification, ChannelListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04004967 RID: 18791
		private static readonly Method<UpdateChannelStateNotification, NO_RESPONSE> __Method_OnUpdateChannelState = new Method<UpdateChannelStateNotification, NO_RESPONSE>(0, ChannelListener.__ServiceName, "OnUpdateChannelState", ChannelListener.__Marshaller_bgs_protocol_channel_v1_UpdateChannelStateNotification, ChannelListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04004968 RID: 18792
		private static readonly Method<UpdateMemberStateNotification, NO_RESPONSE> __Method_OnUpdateMemberState = new Method<UpdateMemberStateNotification, NO_RESPONSE>(0, ChannelListener.__ServiceName, "OnUpdateMemberState", ChannelListener.__Marshaller_bgs_protocol_channel_v1_UpdateMemberStateNotification, ChannelListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x020011F0 RID: 4592
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x0400991C RID: 39196
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x020011F1 RID: 4593
		[BindServiceMethod(typeof(ChannelListener), "BindService")]
		public abstract class ChannelListenerBase
		{
			// Token: 0x0600D9E0 RID: 55776 RVA: 0x004BB530 File Offset: 0x004B9730
			public virtual Task<NO_RESPONSE> OnJoin(JoinNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D9E1 RID: 55777 RVA: 0x004BB544 File Offset: 0x004B9744
			public virtual Task<NO_RESPONSE> OnMemberAdded(MemberAddedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D9E2 RID: 55778 RVA: 0x004BB558 File Offset: 0x004B9758
			public virtual Task<NO_RESPONSE> OnLeave(LeaveNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D9E3 RID: 55779 RVA: 0x004BB56C File Offset: 0x004B976C
			public virtual Task<NO_RESPONSE> OnMemberRemoved(MemberRemovedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D9E4 RID: 55780 RVA: 0x004BB580 File Offset: 0x004B9780
			public virtual Task<NO_RESPONSE> OnSendMessage(SendMessageNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D9E5 RID: 55781 RVA: 0x004BB594 File Offset: 0x004B9794
			public virtual Task<NO_RESPONSE> OnUpdateChannelState(UpdateChannelStateNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D9E6 RID: 55782 RVA: 0x004BB5A8 File Offset: 0x004B97A8
			public virtual Task<NO_RESPONSE> OnUpdateMemberState(UpdateMemberStateNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x020011F2 RID: 4594
		public class ChannelListenerClient : ClientBase<ChannelListener.ChannelListenerClient>
		{
			// Token: 0x0600D9E8 RID: 55784 RVA: 0x004BB5C5 File Offset: 0x004B97C5
			public ChannelListenerClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D9E9 RID: 55785 RVA: 0x004BB5D0 File Offset: 0x004B97D0
			public ChannelListenerClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D9EA RID: 55786 RVA: 0x004BB5DB File Offset: 0x004B97DB
			protected ChannelListenerClient()
			{
			}

			// Token: 0x0600D9EB RID: 55787 RVA: 0x004BB5E5 File Offset: 0x004B97E5
			protected ChannelListenerClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D9EC RID: 55788 RVA: 0x004BB5F0 File Offset: 0x004B97F0
			public virtual NO_RESPONSE OnJoin(JoinNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnJoin(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D9ED RID: 55789 RVA: 0x004BB618 File Offset: 0x004B9818
			public virtual NO_RESPONSE OnJoin(JoinNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<JoinNotification, NO_RESPONSE>(ChannelListener.__Method_OnJoin, null, options, request);
			}

			// Token: 0x0600D9EE RID: 55790 RVA: 0x004BB640 File Offset: 0x004B9840
			public virtual AsyncUnaryCall<NO_RESPONSE> OnJoinAsync(JoinNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnJoinAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D9EF RID: 55791 RVA: 0x004BB668 File Offset: 0x004B9868
			public virtual AsyncUnaryCall<NO_RESPONSE> OnJoinAsync(JoinNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<JoinNotification, NO_RESPONSE>(ChannelListener.__Method_OnJoin, null, options, request);
			}

			// Token: 0x0600D9F0 RID: 55792 RVA: 0x004BB690 File Offset: 0x004B9890
			public virtual NO_RESPONSE OnMemberAdded(MemberAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnMemberAdded(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D9F1 RID: 55793 RVA: 0x004BB6B8 File Offset: 0x004B98B8
			public virtual NO_RESPONSE OnMemberAdded(MemberAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<MemberAddedNotification, NO_RESPONSE>(ChannelListener.__Method_OnMemberAdded, null, options, request);
			}

			// Token: 0x0600D9F2 RID: 55794 RVA: 0x004BB6E0 File Offset: 0x004B98E0
			public virtual AsyncUnaryCall<NO_RESPONSE> OnMemberAddedAsync(MemberAddedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnMemberAddedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D9F3 RID: 55795 RVA: 0x004BB708 File Offset: 0x004B9908
			public virtual AsyncUnaryCall<NO_RESPONSE> OnMemberAddedAsync(MemberAddedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<MemberAddedNotification, NO_RESPONSE>(ChannelListener.__Method_OnMemberAdded, null, options, request);
			}

			// Token: 0x0600D9F4 RID: 55796 RVA: 0x004BB730 File Offset: 0x004B9930
			public virtual NO_RESPONSE OnLeave(LeaveNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnLeave(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D9F5 RID: 55797 RVA: 0x004BB758 File Offset: 0x004B9958
			public virtual NO_RESPONSE OnLeave(LeaveNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<LeaveNotification, NO_RESPONSE>(ChannelListener.__Method_OnLeave, null, options, request);
			}

			// Token: 0x0600D9F6 RID: 55798 RVA: 0x004BB780 File Offset: 0x004B9980
			public virtual AsyncUnaryCall<NO_RESPONSE> OnLeaveAsync(LeaveNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnLeaveAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D9F7 RID: 55799 RVA: 0x004BB7A8 File Offset: 0x004B99A8
			public virtual AsyncUnaryCall<NO_RESPONSE> OnLeaveAsync(LeaveNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<LeaveNotification, NO_RESPONSE>(ChannelListener.__Method_OnLeave, null, options, request);
			}

			// Token: 0x0600D9F8 RID: 55800 RVA: 0x004BB7D0 File Offset: 0x004B99D0
			public virtual NO_RESPONSE OnMemberRemoved(MemberRemovedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnMemberRemoved(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D9F9 RID: 55801 RVA: 0x004BB7F8 File Offset: 0x004B99F8
			public virtual NO_RESPONSE OnMemberRemoved(MemberRemovedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<MemberRemovedNotification, NO_RESPONSE>(ChannelListener.__Method_OnMemberRemoved, null, options, request);
			}

			// Token: 0x0600D9FA RID: 55802 RVA: 0x004BB820 File Offset: 0x004B9A20
			public virtual AsyncUnaryCall<NO_RESPONSE> OnMemberRemovedAsync(MemberRemovedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnMemberRemovedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D9FB RID: 55803 RVA: 0x004BB848 File Offset: 0x004B9A48
			public virtual AsyncUnaryCall<NO_RESPONSE> OnMemberRemovedAsync(MemberRemovedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<MemberRemovedNotification, NO_RESPONSE>(ChannelListener.__Method_OnMemberRemoved, null, options, request);
			}

			// Token: 0x0600D9FC RID: 55804 RVA: 0x004BB870 File Offset: 0x004B9A70
			public virtual NO_RESPONSE OnSendMessage(SendMessageNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSendMessage(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D9FD RID: 55805 RVA: 0x004BB898 File Offset: 0x004B9A98
			public virtual NO_RESPONSE OnSendMessage(SendMessageNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SendMessageNotification, NO_RESPONSE>(ChannelListener.__Method_OnSendMessage, null, options, request);
			}

			// Token: 0x0600D9FE RID: 55806 RVA: 0x004BB8C0 File Offset: 0x004B9AC0
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSendMessageAsync(SendMessageNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSendMessageAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D9FF RID: 55807 RVA: 0x004BB8E8 File Offset: 0x004B9AE8
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSendMessageAsync(SendMessageNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SendMessageNotification, NO_RESPONSE>(ChannelListener.__Method_OnSendMessage, null, options, request);
			}

			// Token: 0x0600DA00 RID: 55808 RVA: 0x004BB910 File Offset: 0x004B9B10
			public virtual NO_RESPONSE OnUpdateChannelState(UpdateChannelStateNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnUpdateChannelState(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DA01 RID: 55809 RVA: 0x004BB938 File Offset: 0x004B9B38
			public virtual NO_RESPONSE OnUpdateChannelState(UpdateChannelStateNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<UpdateChannelStateNotification, NO_RESPONSE>(ChannelListener.__Method_OnUpdateChannelState, null, options, request);
			}

			// Token: 0x0600DA02 RID: 55810 RVA: 0x004BB960 File Offset: 0x004B9B60
			public virtual AsyncUnaryCall<NO_RESPONSE> OnUpdateChannelStateAsync(UpdateChannelStateNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnUpdateChannelStateAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DA03 RID: 55811 RVA: 0x004BB988 File Offset: 0x004B9B88
			public virtual AsyncUnaryCall<NO_RESPONSE> OnUpdateChannelStateAsync(UpdateChannelStateNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<UpdateChannelStateNotification, NO_RESPONSE>(ChannelListener.__Method_OnUpdateChannelState, null, options, request);
			}

			// Token: 0x0600DA04 RID: 55812 RVA: 0x004BB9B0 File Offset: 0x004B9BB0
			public virtual NO_RESPONSE OnUpdateMemberState(UpdateMemberStateNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnUpdateMemberState(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DA05 RID: 55813 RVA: 0x004BB9D8 File Offset: 0x004B9BD8
			public virtual NO_RESPONSE OnUpdateMemberState(UpdateMemberStateNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<UpdateMemberStateNotification, NO_RESPONSE>(ChannelListener.__Method_OnUpdateMemberState, null, options, request);
			}

			// Token: 0x0600DA06 RID: 55814 RVA: 0x004BBA00 File Offset: 0x004B9C00
			public virtual AsyncUnaryCall<NO_RESPONSE> OnUpdateMemberStateAsync(UpdateMemberStateNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnUpdateMemberStateAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DA07 RID: 55815 RVA: 0x004BBA28 File Offset: 0x004B9C28
			public virtual AsyncUnaryCall<NO_RESPONSE> OnUpdateMemberStateAsync(UpdateMemberStateNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<UpdateMemberStateNotification, NO_RESPONSE>(ChannelListener.__Method_OnUpdateMemberState, null, options, request);
			}

			// Token: 0x0600DA08 RID: 55816 RVA: 0x004BBA50 File Offset: 0x004B9C50
			protected override ChannelListener.ChannelListenerClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new ChannelListener.ChannelListenerClient(configuration);
			}
		}
	}
}
