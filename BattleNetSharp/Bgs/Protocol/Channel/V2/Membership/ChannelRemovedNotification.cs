using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2.Membership
{
	// Token: 0x020006B0 RID: 1712
	public sealed class ChannelRemovedNotification : IMessage<ChannelRemovedNotification>, IMessage, IEquatable<ChannelRemovedNotification>, IDeepCloneable<ChannelRemovedNotification>, IBufferMessage
	{
		// Token: 0x17003138 RID: 12600
		// (get) Token: 0x06009E87 RID: 40583 RVA: 0x00268AC0 File Offset: 0x00266CC0
		[DebuggerNonUserCode]
		public static MessageParser<ChannelRemovedNotification> Parser
		{
			get
			{
				return ChannelRemovedNotification._parser;
			}
		}

		// Token: 0x17003139 RID: 12601
		// (get) Token: 0x06009E88 RID: 40584 RVA: 0x00268AD8 File Offset: 0x00266CD8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelMembershipServiceReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x1700313A RID: 12602
		// (get) Token: 0x06009E89 RID: 40585 RVA: 0x00268AFC File Offset: 0x00266CFC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelRemovedNotification.Descriptor;
			}
		}

		// Token: 0x06009E8A RID: 40586 RVA: 0x00268B13 File Offset: 0x00266D13
		[DebuggerNonUserCode]
		public ChannelRemovedNotification()
		{
		}

		// Token: 0x06009E8B RID: 40587 RVA: 0x00268B20 File Offset: 0x00266D20
		[DebuggerNonUserCode]
		public ChannelRemovedNotification(ChannelRemovedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.subscriberId_ = ((other.subscriberId_ != null) ? other.subscriberId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009E8C RID: 40588 RVA: 0x00268BB4 File Offset: 0x00266DB4
		[DebuggerNonUserCode]
		public ChannelRemovedNotification Clone()
		{
			return new ChannelRemovedNotification(this);
		}

		// Token: 0x1700313B RID: 12603
		// (get) Token: 0x06009E8D RID: 40589 RVA: 0x00268BCC File Offset: 0x00266DCC
		// (set) Token: 0x06009E8E RID: 40590 RVA: 0x00268BE4 File Offset: 0x00266DE4
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

		// Token: 0x1700313C RID: 12604
		// (get) Token: 0x06009E8F RID: 40591 RVA: 0x00268BF0 File Offset: 0x00266DF0
		// (set) Token: 0x06009E90 RID: 40592 RVA: 0x00268C08 File Offset: 0x00266E08
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

		// Token: 0x1700313D RID: 12605
		// (get) Token: 0x06009E91 RID: 40593 RVA: 0x00268C14 File Offset: 0x00266E14
		// (set) Token: 0x06009E92 RID: 40594 RVA: 0x00268C2C File Offset: 0x00266E2C
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

		// Token: 0x1700313E RID: 12606
		// (get) Token: 0x06009E93 RID: 40595 RVA: 0x00268C38 File Offset: 0x00266E38
		// (set) Token: 0x06009E94 RID: 40596 RVA: 0x00268C69 File Offset: 0x00266E69
		[DebuggerNonUserCode]
		public ChannelRemovedReason Reason
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ChannelRemovedReason reasonDefaultValue;
				if (flag)
				{
					reasonDefaultValue = this.reason_;
				}
				else
				{
					reasonDefaultValue = ChannelRemovedNotification.ReasonDefaultValue;
				}
				return reasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.reason_ = value;
			}
		}

		// Token: 0x1700313F RID: 12607
		// (get) Token: 0x06009E95 RID: 40597 RVA: 0x00268C84 File Offset: 0x00266E84
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009E96 RID: 40598 RVA: 0x00268CA1 File Offset: 0x00266EA1
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06009E97 RID: 40599 RVA: 0x00268CB4 File Offset: 0x00266EB4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelRemovedNotification);
		}

		// Token: 0x06009E98 RID: 40600 RVA: 0x00268CD4 File Offset: 0x00266ED4
		[DebuggerNonUserCode]
		public bool Equals(ChannelRemovedNotification other)
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
								bool flag7 = this.Reason != other.Reason;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009E99 RID: 40601 RVA: 0x00268D8C File Offset: 0x00266F8C
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
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num ^= this.Reason.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009E9A RID: 40602 RVA: 0x00268E38 File Offset: 0x00267038
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009E9B RID: 40603 RVA: 0x00268E50 File Offset: 0x00267050
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009E9C RID: 40604 RVA: 0x00268E5C File Offset: 0x0026705C
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
				output.WriteRawTag(34);
				output.WriteMessage(this.ChannelId);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Reason);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009E9D RID: 40605 RVA: 0x00268F1C File Offset: 0x0026711C
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
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009E9E RID: 40606 RVA: 0x00268FD0 File Offset: 0x002671D0
		[DebuggerNonUserCode]
		public void MergeFrom(ChannelRemovedNotification other)
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
				bool hasReason = other.HasReason;
				if (hasReason)
				{
					this.Reason = other.Reason;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009E9F RID: 40607 RVA: 0x002690D8 File Offset: 0x002672D8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009EA0 RID: 40608 RVA: 0x002690E4 File Offset: 0x002672E4
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
				else if (num3 != 34U)
				{
					if (num3 != 40U)
					{
						goto IL_002F;
					}
					this.Reason = (ChannelRemovedReason)input.ReadEnum();
				}
				else
				{
					bool flag3 = this.channelId_ == null;
					if (flag3)
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

		// Token: 0x04004778 RID: 18296
		private static readonly MessageParser<ChannelRemovedNotification> _parser = new MessageParser<ChannelRemovedNotification>(() => new ChannelRemovedNotification());

		// Token: 0x04004779 RID: 18297
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400477A RID: 18298
		private int _hasBits0;

		// Token: 0x0400477B RID: 18299
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400477C RID: 18300
		private GameAccountHandle agentId_;

		// Token: 0x0400477D RID: 18301
		public const int SubscriberIdFieldNumber = 2;

		// Token: 0x0400477E RID: 18302
		private GameAccountHandle subscriberId_;

		// Token: 0x0400477F RID: 18303
		public const int ChannelIdFieldNumber = 4;

		// Token: 0x04004780 RID: 18304
		private ChannelId channelId_;

		// Token: 0x04004781 RID: 18305
		public const int ReasonFieldNumber = 5;

		// Token: 0x04004782 RID: 18306
		private static readonly ChannelRemovedReason ReasonDefaultValue = ChannelRemovedReason.MemberLeft;

		// Token: 0x04004783 RID: 18307
		private ChannelRemovedReason reason_;
	}
}
