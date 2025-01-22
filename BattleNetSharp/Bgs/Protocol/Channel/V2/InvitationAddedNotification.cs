using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x0200067F RID: 1663
	public sealed class InvitationAddedNotification : IMessage<InvitationAddedNotification>, IMessage, IEquatable<InvitationAddedNotification>, IDeepCloneable<InvitationAddedNotification>, IBufferMessage
	{
		// Token: 0x17003008 RID: 12296
		// (get) Token: 0x06009A6A RID: 39530 RVA: 0x00256D70 File Offset: 0x00254F70
		[DebuggerNonUserCode]
		public static MessageParser<InvitationAddedNotification> Parser
		{
			get
			{
				return InvitationAddedNotification._parser;
			}
		}

		// Token: 0x17003009 RID: 12297
		// (get) Token: 0x06009A6B RID: 39531 RVA: 0x00256D88 File Offset: 0x00254F88
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[35];
			}
		}

		// Token: 0x1700300A RID: 12298
		// (get) Token: 0x06009A6C RID: 39532 RVA: 0x00256DAC File Offset: 0x00254FAC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InvitationAddedNotification.Descriptor;
			}
		}

		// Token: 0x06009A6D RID: 39533 RVA: 0x00256DC3 File Offset: 0x00254FC3
		[DebuggerNonUserCode]
		public InvitationAddedNotification()
		{
		}

		// Token: 0x06009A6E RID: 39534 RVA: 0x00256DD0 File Offset: 0x00254FD0
		[DebuggerNonUserCode]
		public InvitationAddedNotification(InvitationAddedNotification other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.subscriberId_ = ((other.subscriberId_ != null) ? other.subscriberId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.invitation_ = ((other.invitation_ != null) ? other.invitation_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009A6F RID: 39535 RVA: 0x00256E68 File Offset: 0x00255068
		[DebuggerNonUserCode]
		public InvitationAddedNotification Clone()
		{
			return new InvitationAddedNotification(this);
		}

		// Token: 0x1700300B RID: 12299
		// (get) Token: 0x06009A70 RID: 39536 RVA: 0x00256E80 File Offset: 0x00255080
		// (set) Token: 0x06009A71 RID: 39537 RVA: 0x00256E98 File Offset: 0x00255098
		[DebuggerNonUserCode]
		public GameAccountHandle AgentId
		{
			get
			{
				return this.agentId_;
			}
			set
			{
				this.agentId_ = value;
			}
		}

		// Token: 0x1700300C RID: 12300
		// (get) Token: 0x06009A72 RID: 39538 RVA: 0x00256EA4 File Offset: 0x002550A4
		// (set) Token: 0x06009A73 RID: 39539 RVA: 0x00256EBC File Offset: 0x002550BC
		[DebuggerNonUserCode]
		public GameAccountHandle SubscriberId
		{
			get
			{
				return this.subscriberId_;
			}
			set
			{
				this.subscriberId_ = value;
			}
		}

		// Token: 0x1700300D RID: 12301
		// (get) Token: 0x06009A74 RID: 39540 RVA: 0x00256EC8 File Offset: 0x002550C8
		// (set) Token: 0x06009A75 RID: 39541 RVA: 0x00256EE0 File Offset: 0x002550E0
		[DebuggerNonUserCode]
		public ChannelId ChannelId
		{
			get
			{
				return this.channelId_;
			}
			set
			{
				this.channelId_ = value;
			}
		}

		// Token: 0x1700300E RID: 12302
		// (get) Token: 0x06009A76 RID: 39542 RVA: 0x00256EEC File Offset: 0x002550EC
		// (set) Token: 0x06009A77 RID: 39543 RVA: 0x00256F04 File Offset: 0x00255104
		[DebuggerNonUserCode]
		public ChannelInvitation Invitation
		{
			get
			{
				return this.invitation_;
			}
			set
			{
				this.invitation_ = value;
			}
		}

		// Token: 0x06009A78 RID: 39544 RVA: 0x00256F10 File Offset: 0x00255110
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as InvitationAddedNotification);
		}

		// Token: 0x06009A79 RID: 39545 RVA: 0x00256F30 File Offset: 0x00255130
		[DebuggerNonUserCode]
		public bool Equals(InvitationAddedNotification other)
		{
			bool flag = other == null;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				bool flag3 = other == this;
				if (flag3)
				{
					flag2 = true;
				}
				else
				{
					bool flag4 = !object.Equals(this.AgentId, other.AgentId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.SubscriberId, other.SubscriberId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.ChannelId, other.ChannelId);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.Invitation, other.Invitation);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009A7A RID: 39546 RVA: 0x00256FEC File Offset: 0x002551EC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.subscriberId_ != null;
			if (flag2)
			{
				num ^= this.SubscriberId.GetHashCode();
			}
			bool flag3 = this.channelId_ != null;
			if (flag3)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			bool flag4 = this.invitation_ != null;
			if (flag4)
			{
				num ^= this.Invitation.GetHashCode();
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009A7B RID: 39547 RVA: 0x00257090 File Offset: 0x00255290
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009A7C RID: 39548 RVA: 0x002570A8 File Offset: 0x002552A8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009A7D RID: 39549 RVA: 0x002570B4 File Offset: 0x002552B4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.subscriberId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.SubscriberId);
			}
			bool flag3 = this.channelId_ != null;
			if (flag3)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.ChannelId);
			}
			bool flag4 = this.invitation_ != null;
			if (flag4)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Invitation);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009A7E RID: 39550 RVA: 0x00257174 File Offset: 0x00255374
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.subscriberId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SubscriberId);
			}
			bool flag3 = this.channelId_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
			}
			bool flag4 = this.invitation_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Invitation);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009A7F RID: 39551 RVA: 0x00257228 File Offset: 0x00255428
		[DebuggerNonUserCode]
		public void MergeFrom(InvitationAddedNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.agentId_ != null;
				if (flag2)
				{
					bool flag3 = this.agentId_ == null;
					if (flag3)
					{
						this.AgentId = new GameAccountHandle();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool flag4 = other.subscriberId_ != null;
				if (flag4)
				{
					bool flag5 = this.subscriberId_ == null;
					if (flag5)
					{
						this.SubscriberId = new GameAccountHandle();
					}
					this.SubscriberId.MergeFrom(other.SubscriberId);
				}
				bool flag6 = other.channelId_ != null;
				if (flag6)
				{
					bool flag7 = this.channelId_ == null;
					if (flag7)
					{
						this.ChannelId = new ChannelId();
					}
					this.ChannelId.MergeFrom(other.ChannelId);
				}
				bool flag8 = other.invitation_ != null;
				if (flag8)
				{
					bool flag9 = this.invitation_ == null;
					if (flag9)
					{
						this.Invitation = new ChannelInvitation();
					}
					this.Invitation.MergeFrom(other.Invitation);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009A80 RID: 39552 RVA: 0x00257355 File Offset: 0x00255555
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009A81 RID: 39553 RVA: 0x00257360 File Offset: 0x00255560
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							goto IL_002F;
						}
						bool flag = this.subscriberId_ == null;
						if (flag)
						{
							this.SubscriberId = new GameAccountHandle();
						}
						input.ReadMessage(this.SubscriberId);
					}
					else
					{
						bool flag2 = this.agentId_ == null;
						if (flag2)
						{
							this.AgentId = new GameAccountHandle();
						}
						input.ReadMessage(this.AgentId);
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 34U)
					{
						goto IL_002F;
					}
					bool flag3 = this.invitation_ == null;
					if (flag3)
					{
						this.Invitation = new ChannelInvitation();
					}
					input.ReadMessage(this.Invitation);
				}
				else
				{
					bool flag4 = this.channelId_ == null;
					if (flag4)
					{
						this.ChannelId = new ChannelId();
					}
					input.ReadMessage(this.ChannelId);
				}
				continue;
				IL_002F:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400456C RID: 17772
		private static readonly MessageParser<InvitationAddedNotification> _parser = new MessageParser<InvitationAddedNotification>(() => new InvitationAddedNotification());

		// Token: 0x0400456D RID: 17773
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400456E RID: 17774
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400456F RID: 17775
		private GameAccountHandle agentId_;

		// Token: 0x04004570 RID: 17776
		public const int SubscriberIdFieldNumber = 2;

		// Token: 0x04004571 RID: 17777
		private GameAccountHandle subscriberId_;

		// Token: 0x04004572 RID: 17778
		public const int ChannelIdFieldNumber = 3;

		// Token: 0x04004573 RID: 17779
		private ChannelId channelId_;

		// Token: 0x04004574 RID: 17780
		public const int InvitationFieldNumber = 4;

		// Token: 0x04004575 RID: 17781
		private ChannelInvitation invitation_;
	}
}
