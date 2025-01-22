using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006E0 RID: 1760
	public sealed class MemberRemovedNotification : IMessage<MemberRemovedNotification>, IMessage, IEquatable<MemberRemovedNotification>, IDeepCloneable<MemberRemovedNotification>, IBufferMessage
	{
		// Token: 0x17003240 RID: 12864
		// (get) Token: 0x0600A248 RID: 41544 RVA: 0x0027826C File Offset: 0x0027646C
		[DebuggerNonUserCode]
		public static MessageParser<MemberRemovedNotification> Parser
		{
			get
			{
				return MemberRemovedNotification._parser;
			}
		}

		// Token: 0x17003241 RID: 12865
		// (get) Token: 0x0600A249 RID: 41545 RVA: 0x00278284 File Offset: 0x00276484
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x17003242 RID: 12866
		// (get) Token: 0x0600A24A RID: 41546 RVA: 0x002782A8 File Offset: 0x002764A8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemberRemovedNotification.Descriptor;
			}
		}

		// Token: 0x0600A24B RID: 41547 RVA: 0x002782BF File Offset: 0x002764BF
		[DebuggerNonUserCode]
		public MemberRemovedNotification()
		{
		}

		// Token: 0x0600A24C RID: 41548 RVA: 0x002782CC File Offset: 0x002764CC
		[DebuggerNonUserCode]
		public MemberRemovedNotification(MemberRemovedNotification other)
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

		// Token: 0x0600A24D RID: 41549 RVA: 0x0027837C File Offset: 0x0027657C
		[DebuggerNonUserCode]
		public MemberRemovedNotification Clone()
		{
			return new MemberRemovedNotification(this);
		}

		// Token: 0x17003243 RID: 12867
		// (get) Token: 0x0600A24E RID: 41550 RVA: 0x00278394 File Offset: 0x00276594
		// (set) Token: 0x0600A24F RID: 41551 RVA: 0x002783AC File Offset: 0x002765AC
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

		// Token: 0x17003244 RID: 12868
		// (get) Token: 0x0600A250 RID: 41552 RVA: 0x002783B8 File Offset: 0x002765B8
		// (set) Token: 0x0600A251 RID: 41553 RVA: 0x002783D0 File Offset: 0x002765D0
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

		// Token: 0x17003245 RID: 12869
		// (get) Token: 0x0600A252 RID: 41554 RVA: 0x002783DC File Offset: 0x002765DC
		// (set) Token: 0x0600A253 RID: 41555 RVA: 0x0027840D File Offset: 0x0027660D
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
					reasonDefaultValue = MemberRemovedNotification.ReasonDefaultValue;
				}
				return reasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.reason_ = value;
			}
		}

		// Token: 0x17003246 RID: 12870
		// (get) Token: 0x0600A254 RID: 41556 RVA: 0x00278428 File Offset: 0x00276628
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A255 RID: 41557 RVA: 0x00278445 File Offset: 0x00276645
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003247 RID: 12871
		// (get) Token: 0x0600A256 RID: 41558 RVA: 0x00278458 File Offset: 0x00276658
		// (set) Token: 0x0600A257 RID: 41559 RVA: 0x00278470 File Offset: 0x00276670
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

		// Token: 0x17003248 RID: 12872
		// (get) Token: 0x0600A258 RID: 41560 RVA: 0x0027847C File Offset: 0x0027667C
		// (set) Token: 0x0600A259 RID: 41561 RVA: 0x00278494 File Offset: 0x00276694
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

		// Token: 0x0600A25A RID: 41562 RVA: 0x002784A0 File Offset: 0x002766A0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MemberRemovedNotification);
		}

		// Token: 0x0600A25B RID: 41563 RVA: 0x002784C0 File Offset: 0x002766C0
		[DebuggerNonUserCode]
		public bool Equals(MemberRemovedNotification other)
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

		// Token: 0x0600A25C RID: 41564 RVA: 0x00278598 File Offset: 0x00276798
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

		// Token: 0x0600A25D RID: 41565 RVA: 0x0027865C File Offset: 0x0027685C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A25E RID: 41566 RVA: 0x00278674 File Offset: 0x00276874
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A25F RID: 41567 RVA: 0x00278680 File Offset: 0x00276880
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

		// Token: 0x0600A260 RID: 41568 RVA: 0x00278764 File Offset: 0x00276964
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

		// Token: 0x0600A261 RID: 41569 RVA: 0x00278838 File Offset: 0x00276A38
		[DebuggerNonUserCode]
		public void MergeFrom(MemberRemovedNotification other)
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

		// Token: 0x0600A262 RID: 41570 RVA: 0x00278980 File Offset: 0x00276B80
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A263 RID: 41571 RVA: 0x0027898C File Offset: 0x00276B8C
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

		// Token: 0x04004917 RID: 18711
		private static readonly MessageParser<MemberRemovedNotification> _parser = new MessageParser<MemberRemovedNotification>(() => new MemberRemovedNotification());

		// Token: 0x04004918 RID: 18712
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004919 RID: 18713
		private int _hasBits0;

		// Token: 0x0400491A RID: 18714
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400491B RID: 18715
		private EntityId agentId_;

		// Token: 0x0400491C RID: 18716
		public const int MemberIdFieldNumber = 2;

		// Token: 0x0400491D RID: 18717
		private EntityId memberId_;

		// Token: 0x0400491E RID: 18718
		public const int ReasonFieldNumber = 3;

		// Token: 0x0400491F RID: 18719
		private static readonly uint ReasonDefaultValue = 0U;

		// Token: 0x04004920 RID: 18720
		private uint reason_;

		// Token: 0x04004921 RID: 18721
		public const int ChannelIdFieldNumber = 4;

		// Token: 0x04004922 RID: 18722
		private ChannelId channelId_;

		// Token: 0x04004923 RID: 18723
		public const int SubscriberFieldNumber = 5;

		// Token: 0x04004924 RID: 18724
		private Identity subscriber_;
	}
}
