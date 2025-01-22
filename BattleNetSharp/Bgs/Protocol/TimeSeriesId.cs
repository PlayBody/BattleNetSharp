using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x0200035A RID: 858
	public sealed class TimeSeriesId : IMessage<TimeSeriesId>, IMessage, IEquatable<TimeSeriesId>, IDeepCloneable<TimeSeriesId>, IBufferMessage
	{
		// Token: 0x17001CCE RID: 7374
		// (get) Token: 0x060058DC RID: 22748 RVA: 0x001579E8 File Offset: 0x00155BE8
		[DebuggerNonUserCode]
		public static MessageParser<TimeSeriesId> Parser
		{
			get
			{
				return TimeSeriesId._parser;
			}
		}

		// Token: 0x17001CCF RID: 7375
		// (get) Token: 0x060058DD RID: 22749 RVA: 0x00157A00 File Offset: 0x00155C00
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EtsTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001CD0 RID: 7376
		// (get) Token: 0x060058DE RID: 22750 RVA: 0x00157A24 File Offset: 0x00155C24
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimeSeriesId.Descriptor;
			}
		}

		// Token: 0x060058DF RID: 22751 RVA: 0x00157A3B File Offset: 0x00155C3B
		[DebuggerNonUserCode]
		public TimeSeriesId()
		{
		}

		// Token: 0x060058E0 RID: 22752 RVA: 0x00157A45 File Offset: 0x00155C45
		[DebuggerNonUserCode]
		public TimeSeriesId(TimeSeriesId other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.epoch_ = other.epoch_;
			this.position_ = other.position_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060058E1 RID: 22753 RVA: 0x00157A84 File Offset: 0x00155C84
		[DebuggerNonUserCode]
		public TimeSeriesId Clone()
		{
			return new TimeSeriesId(this);
		}

		// Token: 0x17001CD1 RID: 7377
		// (get) Token: 0x060058E2 RID: 22754 RVA: 0x00157A9C File Offset: 0x00155C9C
		// (set) Token: 0x060058E3 RID: 22755 RVA: 0x00157ACD File Offset: 0x00155CCD
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
					epochDefaultValue = TimeSeriesId.EpochDefaultValue;
				}
				return epochDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.epoch_ = value;
			}
		}

		// Token: 0x17001CD2 RID: 7378
		// (get) Token: 0x060058E4 RID: 22756 RVA: 0x00157AE8 File Offset: 0x00155CE8
		[DebuggerNonUserCode]
		public bool HasEpoch
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060058E5 RID: 22757 RVA: 0x00157B05 File Offset: 0x00155D05
		[DebuggerNonUserCode]
		public void ClearEpoch()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001CD3 RID: 7379
		// (get) Token: 0x060058E6 RID: 22758 RVA: 0x00157B18 File Offset: 0x00155D18
		// (set) Token: 0x060058E7 RID: 22759 RVA: 0x00157B49 File Offset: 0x00155D49
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
					positionDefaultValue = TimeSeriesId.PositionDefaultValue;
				}
				return positionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.position_ = value;
			}
		}

		// Token: 0x17001CD4 RID: 7380
		// (get) Token: 0x060058E8 RID: 22760 RVA: 0x00157B64 File Offset: 0x00155D64
		[DebuggerNonUserCode]
		public bool HasPosition
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060058E9 RID: 22761 RVA: 0x00157B81 File Offset: 0x00155D81
		[DebuggerNonUserCode]
		public void ClearPosition()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060058EA RID: 22762 RVA: 0x00157B94 File Offset: 0x00155D94
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimeSeriesId);
		}

		// Token: 0x060058EB RID: 22763 RVA: 0x00157BB4 File Offset: 0x00155DB4
		[DebuggerNonUserCode]
		public bool Equals(TimeSeriesId other)
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

		// Token: 0x060058EC RID: 22764 RVA: 0x00157C28 File Offset: 0x00155E28
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

		// Token: 0x060058ED RID: 22765 RVA: 0x00157C94 File Offset: 0x00155E94
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060058EE RID: 22766 RVA: 0x00157CAC File Offset: 0x00155EAC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060058EF RID: 22767 RVA: 0x00157CB8 File Offset: 0x00155EB8
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

		// Token: 0x060058F0 RID: 22768 RVA: 0x00157D28 File Offset: 0x00155F28
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

		// Token: 0x060058F1 RID: 22769 RVA: 0x00157D94 File Offset: 0x00155F94
		[DebuggerNonUserCode]
		public void MergeFrom(TimeSeriesId other)
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

		// Token: 0x060058F2 RID: 22770 RVA: 0x00157DF6 File Offset: 0x00155FF6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060058F3 RID: 22771 RVA: 0x00157E04 File Offset: 0x00156004
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

		// Token: 0x04002885 RID: 10373
		private static readonly MessageParser<TimeSeriesId> _parser = new MessageParser<TimeSeriesId>(() => new TimeSeriesId());

		// Token: 0x04002886 RID: 10374
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002887 RID: 10375
		private int _hasBits0;

		// Token: 0x04002888 RID: 10376
		public const int EpochFieldNumber = 1;

		// Token: 0x04002889 RID: 10377
		private static readonly ulong EpochDefaultValue = 0UL;

		// Token: 0x0400288A RID: 10378
		private ulong epoch_;

		// Token: 0x0400288B RID: 10379
		public const int PositionFieldNumber = 2;

		// Token: 0x0400288C RID: 10380
		private static readonly ulong PositionDefaultValue = 0UL;

		// Token: 0x0400288D RID: 10381
		private ulong position_;
	}
}
