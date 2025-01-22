using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000385 RID: 901
	public sealed class MessageId : IMessage<MessageId>, IMessage, IEquatable<MessageId>, IDeepCloneable<MessageId>, IBufferMessage
	{
		// Token: 0x17001DA7 RID: 7591
		// (get) Token: 0x06005B8B RID: 23435 RVA: 0x00162190 File Offset: 0x00160390
		[DebuggerNonUserCode]
		public static MessageParser<MessageId> Parser
		{
			get
			{
				return MessageId._parser;
			}
		}

		// Token: 0x17001DA8 RID: 7592
		// (get) Token: 0x06005B8C RID: 23436 RVA: 0x001621A8 File Offset: 0x001603A8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MessageTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001DA9 RID: 7593
		// (get) Token: 0x06005B8D RID: 23437 RVA: 0x001621CC File Offset: 0x001603CC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MessageId.Descriptor;
			}
		}

		// Token: 0x06005B8E RID: 23438 RVA: 0x001621E3 File Offset: 0x001603E3
		[DebuggerNonUserCode]
		public MessageId()
		{
		}

		// Token: 0x06005B8F RID: 23439 RVA: 0x001621ED File Offset: 0x001603ED
		[DebuggerNonUserCode]
		public MessageId(MessageId other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.epoch_ = other.epoch_;
			this.position_ = other.position_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005B90 RID: 23440 RVA: 0x0016222C File Offset: 0x0016042C
		[DebuggerNonUserCode]
		public MessageId Clone()
		{
			return new MessageId(this);
		}

		// Token: 0x17001DAA RID: 7594
		// (get) Token: 0x06005B91 RID: 23441 RVA: 0x00162244 File Offset: 0x00160444
		// (set) Token: 0x06005B92 RID: 23442 RVA: 0x00162275 File Offset: 0x00160475
		[DebuggerNonUserCode]
		public ulong Epoch
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong epochDefaultValue;
				if (flag)
				{
					epochDefaultValue = this.epoch_;
				}
				else
				{
					epochDefaultValue = MessageId.EpochDefaultValue;
				}
				return epochDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.epoch_ = value;
			}
		}

		// Token: 0x17001DAB RID: 7595
		// (get) Token: 0x06005B93 RID: 23443 RVA: 0x00162290 File Offset: 0x00160490
		[DebuggerNonUserCode]
		public bool HasEpoch
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005B94 RID: 23444 RVA: 0x001622AD File Offset: 0x001604AD
		[DebuggerNonUserCode]
		public void ClearEpoch()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001DAC RID: 7596
		// (get) Token: 0x06005B95 RID: 23445 RVA: 0x001622C0 File Offset: 0x001604C0
		// (set) Token: 0x06005B96 RID: 23446 RVA: 0x001622F1 File Offset: 0x001604F1
		[DebuggerNonUserCode]
		public ulong Position
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong positionDefaultValue;
				if (flag)
				{
					positionDefaultValue = this.position_;
				}
				else
				{
					positionDefaultValue = MessageId.PositionDefaultValue;
				}
				return positionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.position_ = value;
			}
		}

		// Token: 0x17001DAD RID: 7597
		// (get) Token: 0x06005B97 RID: 23447 RVA: 0x0016230C File Offset: 0x0016050C
		[DebuggerNonUserCode]
		public bool HasPosition
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005B98 RID: 23448 RVA: 0x00162329 File Offset: 0x00160529
		[DebuggerNonUserCode]
		public void ClearPosition()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06005B99 RID: 23449 RVA: 0x0016233C File Offset: 0x0016053C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MessageId);
		}

		// Token: 0x06005B9A RID: 23450 RVA: 0x0016235C File Offset: 0x0016055C
		[DebuggerNonUserCode]
		public bool Equals(MessageId other)
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
					bool flag4 = this.Epoch != other.Epoch;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Position != other.Position;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005B9B RID: 23451 RVA: 0x001623D0 File Offset: 0x001605D0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasEpoch = this.HasEpoch;
			if (hasEpoch)
			{
				num ^= this.Epoch.GetHashCode();
			}
			bool hasPosition = this.HasPosition;
			if (hasPosition)
			{
				num ^= this.Position.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005B9C RID: 23452 RVA: 0x0016243C File Offset: 0x0016063C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005B9D RID: 23453 RVA: 0x00162454 File Offset: 0x00160654
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005B9E RID: 23454 RVA: 0x00162460 File Offset: 0x00160660
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasEpoch = this.HasEpoch;
			if (hasEpoch)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.Epoch);
			}
			bool hasPosition = this.HasPosition;
			if (hasPosition)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.Position);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005B9F RID: 23455 RVA: 0x001624D0 File Offset: 0x001606D0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasEpoch = this.HasEpoch;
			if (hasEpoch)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Epoch);
			}
			bool hasPosition = this.HasPosition;
			if (hasPosition)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Position);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005BA0 RID: 23456 RVA: 0x0016253C File Offset: 0x0016073C
		[DebuggerNonUserCode]
		public void MergeFrom(MessageId other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasEpoch = other.HasEpoch;
				if (hasEpoch)
				{
					this.Epoch = other.Epoch;
				}
				bool hasPosition = other.HasPosition;
				if (hasPosition)
				{
					this.Position = other.Position;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005BA1 RID: 23457 RVA: 0x0016259E File Offset: 0x0016079E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005BA2 RID: 23458 RVA: 0x001625AC File Offset: 0x001607AC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Position = input.ReadUInt64();
					}
				}
				else
				{
					this.Epoch = input.ReadUInt64();
				}
			}
		}

		// Token: 0x040029C8 RID: 10696
		private static readonly MessageParser<MessageId> _parser = new MessageParser<MessageId>(() => new MessageId());

		// Token: 0x040029C9 RID: 10697
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029CA RID: 10698
		private int _hasBits0;

		// Token: 0x040029CB RID: 10699
		public const int EpochFieldNumber = 1;

		// Token: 0x040029CC RID: 10700
		private static readonly ulong EpochDefaultValue = 0UL;

		// Token: 0x040029CD RID: 10701
		private ulong epoch_;

		// Token: 0x040029CE RID: 10702
		public const int PositionFieldNumber = 2;

		// Token: 0x040029CF RID: 10703
		private static readonly ulong PositionDefaultValue = 0UL;

		// Token: 0x040029D0 RID: 10704
		private ulong position_;
	}
}
