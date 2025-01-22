using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006DF RID: 1759
	public sealed class LeaveNotification : IMessage<LeaveNotification>, IMessage, IEquatable<LeaveNotification>, IDeepCloneable<LeaveNotification>, IBufferMessage
	{
		// Token: 0x17003237 RID: 12855
		// (get) Token: 0x0600A22B RID: 41515 RVA: 0x002779F0 File Offset: 0x00275BF0
		[DebuggerNonUserCode]
		public static MessageParser<LeaveNotification> Parser
		{
			get
			{
				return LeaveNotification._parser;
			}
		}

		// Token: 0x17003238 RID: 12856
		// (get) Token: 0x0600A22C RID: 41516 RVA: 0x00277A08 File Offset: 0x00275C08
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x17003239 RID: 12857
		// (get) Token: 0x0600A22D RID: 41517 RVA: 0x00277A2C File Offset: 0x00275C2C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveNotification.Descriptor;
			}
		}

		// Token: 0x0600A22E RID: 41518 RVA: 0x00277A43 File Offset: 0x00275C43
		[DebuggerNonUserCode]
		public LeaveNotification()
		{
		}

		// Token: 0x0600A22F RID: 41519 RVA: 0x00277A50 File Offset: 0x00275C50
		[DebuggerNonUserCode]
		public LeaveNotification(LeaveNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.memberId_ = ((other.memberId_ != null) ? other.memberId_.Clone() : null);
			this.reason_ = other.reason_;
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.subscriber_ = ((other.subscriber_ != null) ? other.subscriber_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A230 RID: 41520 RVA: 0x00277B00 File Offset: 0x00275D00
		[DebuggerNonUserCode]
		public LeaveNotification Clone()
		{
			return new LeaveNotification(this);
		}

		// Token: 0x1700323A RID: 12858
		// (get) Token: 0x0600A231 RID: 41521 RVA: 0x00277B18 File Offset: 0x00275D18
		// (set) Token: 0x0600A232 RID: 41522 RVA: 0x00277B30 File Offset: 0x00275D30
		[DebuggerNonUserCode]
		public EntityId AgentId
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

		// Token: 0x1700323B RID: 12859
		// (get) Token: 0x0600A233 RID: 41523 RVA: 0x00277B3C File Offset: 0x00275D3C
		// (set) Token: 0x0600A234 RID: 41524 RVA: 0x00277B54 File Offset: 0x00275D54
		[Obsolete]
		[DebuggerNonUserCode]
		public EntityId MemberId
		{
			get
			{
				return this.memberId_;
			}
			set
			{
				this.memberId_ = value;
			}
		}

		// Token: 0x1700323C RID: 12860
		// (get) Token: 0x0600A235 RID: 41525 RVA: 0x00277B60 File Offset: 0x00275D60
		// (set) Token: 0x0600A236 RID: 41526 RVA: 0x00277B91 File Offset: 0x00275D91
		[DebuggerNonUserCode]
		public uint Reason
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint reasonDefaultValue;
				if (flag)
				{
					reasonDefaultValue = this.reason_;
				}
				else
				{
					reasonDefaultValue = LeaveNotification.ReasonDefaultValue;
				}
				return reasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.reason_ = value;
			}
		}

		// Token: 0x1700323D RID: 12861
		// (get) Token: 0x0600A237 RID: 41527 RVA: 0x00277BAC File Offset: 0x00275DAC
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A238 RID: 41528 RVA: 0x00277BC9 File Offset: 0x00275DC9
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700323E RID: 12862
		// (get) Token: 0x0600A239 RID: 41529 RVA: 0x00277BDC File Offset: 0x00275DDC
		// (set) Token: 0x0600A23A RID: 41530 RVA: 0x00277BF4 File Offset: 0x00275DF4
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

		// Token: 0x1700323F RID: 12863
		// (get) Token: 0x0600A23B RID: 41531 RVA: 0x00277C00 File Offset: 0x00275E00
		// (set) Token: 0x0600A23C RID: 41532 RVA: 0x00277C18 File Offset: 0x00275E18
		[DebuggerNonUserCode]
		public Identity Subscriber
		{
			get
			{
				return this.subscriber_;
			}
			set
			{
				this.subscriber_ = value;
			}
		}

		// Token: 0x0600A23D RID: 41533 RVA: 0x00277C24 File Offset: 0x00275E24
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveNotification);
		}

		// Token: 0x0600A23E RID: 41534 RVA: 0x00277C44 File Offset: 0x00275E44
		[DebuggerNonUserCode]
		public bool Equals(LeaveNotification other)
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
						bool flag5 = !object.Equals(this.MemberId, other.MemberId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Reason != other.Reason;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.ChannelId, other.ChannelId);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.Subscriber, other.Subscriber);
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A23F RID: 41535 RVA: 0x00277D1C File Offset: 0x00275F1C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.memberId_ != null;
			if (flag2)
			{
				num ^= this.MemberId.GetHashCode();
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num ^= this.Reason.GetHashCode();
			}
			bool flag3 = this.channelId_ != null;
			if (flag3)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			bool flag4 = this.subscriber_ != null;
			if (flag4)
			{
				num ^= this.Subscriber.GetHashCode();
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A240 RID: 41536 RVA: 0x00277DE0 File Offset: 0x00275FE0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A241 RID: 41537 RVA: 0x00277DF8 File Offset: 0x00275FF8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A242 RID: 41538 RVA: 0x00277E04 File Offset: 0x00276004
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.memberId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.MemberId);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Reason);
			}
			bool flag3 = this.channelId_ != null;
			if (flag3)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.ChannelId);
			}
			bool flag4 = this.subscriber_ != null;
			if (flag4)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Subscriber);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A243 RID: 41539 RVA: 0x00277EE8 File Offset: 0x002760E8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.memberId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MemberId);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Reason);
			}
			bool flag3 = this.channelId_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
			}
			bool flag4 = this.subscriber_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Subscriber);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A244 RID: 41540 RVA: 0x00277FBC File Offset: 0x002761BC
		[DebuggerNonUserCode]
		public void MergeFrom(LeaveNotification other)
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
						this.AgentId = new EntityId();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool flag4 = other.memberId_ != null;
				if (flag4)
				{
					bool flag5 = this.memberId_ == null;
					if (flag5)
					{
						this.MemberId = new EntityId();
					}
					this.MemberId.MergeFrom(other.MemberId);
				}
				bool hasReason = other.HasReason;
				if (hasReason)
				{
					this.Reason = other.Reason;
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
				bool flag8 = other.subscriber_ != null;
				if (flag8)
				{
					bool flag9 = this.subscriber_ == null;
					if (flag9)
					{
						this.Subscriber = new Identity();
					}
					this.Subscriber.MergeFrom(other.Subscriber);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A245 RID: 41541 RVA: 0x00278104 File Offset: 0x00276304
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A246 RID: 41542 RVA: 0x00278110 File Offset: 0x00276310
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
							goto IL_003C;
						}
						bool flag = this.memberId_ == null;
						if (flag)
						{
							this.MemberId = new EntityId();
						}
						input.ReadMessage(this.MemberId);
					}
					else
					{
						bool flag2 = this.agentId_ == null;
						if (flag2)
						{
							this.AgentId = new EntityId();
						}
						input.ReadMessage(this.AgentId);
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 34U)
					{
						if (num3 != 42U)
						{
							goto IL_003C;
						}
						bool flag3 = this.subscriber_ == null;
						if (flag3)
						{
							this.Subscriber = new Identity();
						}
						input.ReadMessage(this.Subscriber);
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
				}
				else
				{
					this.Reason = input.ReadUInt32();
				}
				continue;
				IL_003C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004909 RID: 18697
		private static readonly MessageParser<LeaveNotification> _parser = new MessageParser<LeaveNotification>(() => new LeaveNotification());

		// Token: 0x0400490A RID: 18698
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400490B RID: 18699
		private int _hasBits0;

		// Token: 0x0400490C RID: 18700
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400490D RID: 18701
		private EntityId agentId_;

		// Token: 0x0400490E RID: 18702
		public const int MemberIdFieldNumber = 2;

		// Token: 0x0400490F RID: 18703
		private EntityId memberId_;

		// Token: 0x04004910 RID: 18704
		public const int ReasonFieldNumber = 3;

		// Token: 0x04004911 RID: 18705
		private static readonly uint ReasonDefaultValue = 0U;

		// Token: 0x04004912 RID: 18706
		private uint reason_;

		// Token: 0x04004913 RID: 18707
		public const int ChannelIdFieldNumber = 4;

		// Token: 0x04004914 RID: 18708
		private ChannelId channelId_;

		// Token: 0x04004915 RID: 18709
		public const int SubscriberFieldNumber = 5;

		// Token: 0x04004916 RID: 18710
		private Identity subscriber_;
	}
}
