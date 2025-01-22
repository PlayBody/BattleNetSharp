using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1.Membership
{
	// Token: 0x02000516 RID: 1302
	public sealed class StreamMentionAdvanceViewTimeNotification : IMessage<StreamMentionAdvanceViewTimeNotification>, IMessage, IEquatable<StreamMentionAdvanceViewTimeNotification>, IDeepCloneable<StreamMentionAdvanceViewTimeNotification>, IBufferMessage
	{
		// Token: 0x1700283D RID: 10301
		// (get) Token: 0x06007ED8 RID: 32472 RVA: 0x001EDE50 File Offset: 0x001EC050
		[DebuggerNonUserCode]
		public static MessageParser<StreamMentionAdvanceViewTimeNotification> Parser
		{
			get
			{
				return StreamMentionAdvanceViewTimeNotification._parser;
			}
		}

		// Token: 0x1700283E RID: 10302
		// (get) Token: 0x06007ED9 RID: 32473 RVA: 0x001EDE68 File Offset: 0x001EC068
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMembershipListenerReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x1700283F RID: 10303
		// (get) Token: 0x06007EDA RID: 32474 RVA: 0x001EDE8C File Offset: 0x001EC08C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StreamMentionAdvanceViewTimeNotification.Descriptor;
			}
		}

		// Token: 0x06007EDB RID: 32475 RVA: 0x001EDEA3 File Offset: 0x001EC0A3
		[DebuggerNonUserCode]
		public StreamMentionAdvanceViewTimeNotification()
		{
		}

		// Token: 0x06007EDC RID: 32476 RVA: 0x001EDEB0 File Offset: 0x001EC0B0
		[DebuggerNonUserCode]
		public StreamMentionAdvanceViewTimeNotification(StreamMentionAdvanceViewTimeNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.viewTime_ = other.viewTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007EDD RID: 32477 RVA: 0x001EDF0C File Offset: 0x001EC10C
		[DebuggerNonUserCode]
		public StreamMentionAdvanceViewTimeNotification Clone()
		{
			return new StreamMentionAdvanceViewTimeNotification(this);
		}

		// Token: 0x17002840 RID: 10304
		// (get) Token: 0x06007EDE RID: 32478 RVA: 0x001EDF24 File Offset: 0x001EC124
		// (set) Token: 0x06007EDF RID: 32479 RVA: 0x001EDF3C File Offset: 0x001EC13C
		[DebuggerNonUserCode]
		public AccountId AgentId
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

		// Token: 0x17002841 RID: 10305
		// (get) Token: 0x06007EE0 RID: 32480 RVA: 0x001EDF48 File Offset: 0x001EC148
		// (set) Token: 0x06007EE1 RID: 32481 RVA: 0x001EDF79 File Offset: 0x001EC179
		[DebuggerNonUserCode]
		public ulong ViewTime
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong viewTimeDefaultValue;
				if (flag)
				{
					viewTimeDefaultValue = this.viewTime_;
				}
				else
				{
					viewTimeDefaultValue = StreamMentionAdvanceViewTimeNotification.ViewTimeDefaultValue;
				}
				return viewTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.viewTime_ = value;
			}
		}

		// Token: 0x17002842 RID: 10306
		// (get) Token: 0x06007EE2 RID: 32482 RVA: 0x001EDF94 File Offset: 0x001EC194
		[DebuggerNonUserCode]
		public bool HasViewTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007EE3 RID: 32483 RVA: 0x001EDFB1 File Offset: 0x001EC1B1
		[DebuggerNonUserCode]
		public void ClearViewTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06007EE4 RID: 32484 RVA: 0x001EDFC4 File Offset: 0x001EC1C4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StreamMentionAdvanceViewTimeNotification);
		}

		// Token: 0x06007EE5 RID: 32485 RVA: 0x001EDFE4 File Offset: 0x001EC1E4
		[DebuggerNonUserCode]
		public bool Equals(StreamMentionAdvanceViewTimeNotification other)
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
						bool flag5 = this.ViewTime != other.ViewTime;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007EE6 RID: 32486 RVA: 0x001EE058 File Offset: 0x001EC258
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool hasViewTime = this.HasViewTime;
			if (hasViewTime)
			{
				num ^= this.ViewTime.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007EE7 RID: 32487 RVA: 0x001EE0C4 File Offset: 0x001EC2C4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007EE8 RID: 32488 RVA: 0x001EE0DC File Offset: 0x001EC2DC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007EE9 RID: 32489 RVA: 0x001EE0E8 File Offset: 0x001EC2E8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool hasViewTime = this.HasViewTime;
			if (hasViewTime)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.ViewTime);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007EEA RID: 32490 RVA: 0x001EE15C File Offset: 0x001EC35C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool hasViewTime = this.HasViewTime;
			if (hasViewTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ViewTime);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007EEB RID: 32491 RVA: 0x001EE1CC File Offset: 0x001EC3CC
		[DebuggerNonUserCode]
		public void MergeFrom(StreamMentionAdvanceViewTimeNotification other)
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
						this.AgentId = new AccountId();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool hasViewTime = other.HasViewTime;
				if (hasViewTime)
				{
					this.ViewTime = other.ViewTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007EEC RID: 32492 RVA: 0x001EE251 File Offset: 0x001EC451
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007EED RID: 32493 RVA: 0x001EE25C File Offset: 0x001EC45C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 10U)
				{
					if (num3 != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ViewTime = input.ReadUInt64();
					}
				}
				else
				{
					bool flag = this.agentId_ == null;
					if (flag)
					{
						this.AgentId = new AccountId();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x040039A1 RID: 14753
		private static readonly MessageParser<StreamMentionAdvanceViewTimeNotification> _parser = new MessageParser<StreamMentionAdvanceViewTimeNotification>(() => new StreamMentionAdvanceViewTimeNotification());

		// Token: 0x040039A2 RID: 14754
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039A3 RID: 14755
		private int _hasBits0;

		// Token: 0x040039A4 RID: 14756
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040039A5 RID: 14757
		private AccountId agentId_;

		// Token: 0x040039A6 RID: 14758
		public const int ViewTimeFieldNumber = 3;

		// Token: 0x040039A7 RID: 14759
		private static readonly ulong ViewTimeDefaultValue = 0UL;

		// Token: 0x040039A8 RID: 14760
		private ulong viewTime_;
	}
}
