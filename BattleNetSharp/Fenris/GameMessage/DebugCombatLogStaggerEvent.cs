using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001EB RID: 491
	public sealed class DebugCombatLogStaggerEvent : IMessage<DebugCombatLogStaggerEvent>, IMessage, IEquatable<DebugCombatLogStaggerEvent>, IDeepCloneable<DebugCombatLogStaggerEvent>, IBufferMessage
	{
		// Token: 0x17001152 RID: 4434
		// (get) Token: 0x06003559 RID: 13657 RVA: 0x000D2A78 File Offset: 0x000D0C78
		[DebuggerNonUserCode]
		public static MessageParser<DebugCombatLogStaggerEvent> Parser
		{
			get
			{
				return DebugCombatLogStaggerEvent._parser;
			}
		}

		// Token: 0x17001153 RID: 4435
		// (get) Token: 0x0600355A RID: 13658 RVA: 0x000D2A90 File Offset: 0x000D0C90
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[48];
			}
		}

		// Token: 0x17001154 RID: 4436
		// (get) Token: 0x0600355B RID: 13659 RVA: 0x000D2AB4 File Offset: 0x000D0CB4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugCombatLogStaggerEvent.Descriptor;
			}
		}

		// Token: 0x0600355C RID: 13660 RVA: 0x000D2ACB File Offset: 0x000D0CCB
		[DebuggerNonUserCode]
		public DebugCombatLogStaggerEvent()
		{
		}

		// Token: 0x0600355D RID: 13661 RVA: 0x000D2AD8 File Offset: 0x000D0CD8
		[DebuggerNonUserCode]
		public DebugCombatLogStaggerEvent(DebugCombatLogStaggerEvent other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.newStaggerAmount_ = other.newStaggerAmount_;
			this.totalStaggerAmount_ = other.totalStaggerAmount_;
			this.staggerThreshold_ = other.staggerThreshold_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600355E RID: 13662 RVA: 0x000D2B30 File Offset: 0x000D0D30
		[DebuggerNonUserCode]
		public DebugCombatLogStaggerEvent Clone()
		{
			return new DebugCombatLogStaggerEvent(this);
		}

		// Token: 0x17001155 RID: 4437
		// (get) Token: 0x0600355F RID: 13663 RVA: 0x000D2B48 File Offset: 0x000D0D48
		// (set) Token: 0x06003560 RID: 13664 RVA: 0x000D2B79 File Offset: 0x000D0D79
		[DebuggerNonUserCode]
		public float NewStaggerAmount
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				float newStaggerAmountDefaultValue;
				if (flag)
				{
					newStaggerAmountDefaultValue = this.newStaggerAmount_;
				}
				else
				{
					newStaggerAmountDefaultValue = DebugCombatLogStaggerEvent.NewStaggerAmountDefaultValue;
				}
				return newStaggerAmountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.newStaggerAmount_ = value;
			}
		}

		// Token: 0x17001156 RID: 4438
		// (get) Token: 0x06003561 RID: 13665 RVA: 0x000D2B94 File Offset: 0x000D0D94
		[DebuggerNonUserCode]
		public bool HasNewStaggerAmount
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003562 RID: 13666 RVA: 0x000D2BB1 File Offset: 0x000D0DB1
		[DebuggerNonUserCode]
		public void ClearNewStaggerAmount()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001157 RID: 4439
		// (get) Token: 0x06003563 RID: 13667 RVA: 0x000D2BC4 File Offset: 0x000D0DC4
		// (set) Token: 0x06003564 RID: 13668 RVA: 0x000D2BF5 File Offset: 0x000D0DF5
		[DebuggerNonUserCode]
		public float TotalStaggerAmount
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float totalStaggerAmountDefaultValue;
				if (flag)
				{
					totalStaggerAmountDefaultValue = this.totalStaggerAmount_;
				}
				else
				{
					totalStaggerAmountDefaultValue = DebugCombatLogStaggerEvent.TotalStaggerAmountDefaultValue;
				}
				return totalStaggerAmountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.totalStaggerAmount_ = value;
			}
		}

		// Token: 0x17001158 RID: 4440
		// (get) Token: 0x06003565 RID: 13669 RVA: 0x000D2C10 File Offset: 0x000D0E10
		[DebuggerNonUserCode]
		public bool HasTotalStaggerAmount
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003566 RID: 13670 RVA: 0x000D2C2D File Offset: 0x000D0E2D
		[DebuggerNonUserCode]
		public void ClearTotalStaggerAmount()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001159 RID: 4441
		// (get) Token: 0x06003567 RID: 13671 RVA: 0x000D2C40 File Offset: 0x000D0E40
		// (set) Token: 0x06003568 RID: 13672 RVA: 0x000D2C71 File Offset: 0x000D0E71
		[DebuggerNonUserCode]
		public float StaggerThreshold
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				float staggerThresholdDefaultValue;
				if (flag)
				{
					staggerThresholdDefaultValue = this.staggerThreshold_;
				}
				else
				{
					staggerThresholdDefaultValue = DebugCombatLogStaggerEvent.StaggerThresholdDefaultValue;
				}
				return staggerThresholdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.staggerThreshold_ = value;
			}
		}

		// Token: 0x1700115A RID: 4442
		// (get) Token: 0x06003569 RID: 13673 RVA: 0x000D2C8C File Offset: 0x000D0E8C
		[DebuggerNonUserCode]
		public bool HasStaggerThreshold
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600356A RID: 13674 RVA: 0x000D2CA9 File Offset: 0x000D0EA9
		[DebuggerNonUserCode]
		public void ClearStaggerThreshold()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x0600356B RID: 13675 RVA: 0x000D2CBC File Offset: 0x000D0EBC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugCombatLogStaggerEvent);
		}

		// Token: 0x0600356C RID: 13676 RVA: 0x000D2CDC File Offset: 0x000D0EDC
		[DebuggerNonUserCode]
		public bool Equals(DebugCombatLogStaggerEvent other)
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
					bool flag4 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.NewStaggerAmount, other.NewStaggerAmount);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.TotalStaggerAmount, other.TotalStaggerAmount);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.StaggerThreshold, other.StaggerThreshold);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600356D RID: 13677 RVA: 0x000D2D84 File Offset: 0x000D0F84
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasNewStaggerAmount = this.HasNewStaggerAmount;
			if (hasNewStaggerAmount)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.NewStaggerAmount);
			}
			bool hasTotalStaggerAmount = this.HasTotalStaggerAmount;
			if (hasTotalStaggerAmount)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.TotalStaggerAmount);
			}
			bool hasStaggerThreshold = this.HasStaggerThreshold;
			if (hasStaggerThreshold)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.StaggerThreshold);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600356E RID: 13678 RVA: 0x000D2E14 File Offset: 0x000D1014
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600356F RID: 13679 RVA: 0x000D2E2C File Offset: 0x000D102C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003570 RID: 13680 RVA: 0x000D2E38 File Offset: 0x000D1038
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasNewStaggerAmount = this.HasNewStaggerAmount;
			if (hasNewStaggerAmount)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.NewStaggerAmount);
			}
			bool hasTotalStaggerAmount = this.HasTotalStaggerAmount;
			if (hasTotalStaggerAmount)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.TotalStaggerAmount);
			}
			bool hasStaggerThreshold = this.HasStaggerThreshold;
			if (hasStaggerThreshold)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.StaggerThreshold);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003571 RID: 13681 RVA: 0x000D2EC8 File Offset: 0x000D10C8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasNewStaggerAmount = this.HasNewStaggerAmount;
			if (hasNewStaggerAmount)
			{
				num += 5;
			}
			bool hasTotalStaggerAmount = this.HasTotalStaggerAmount;
			if (hasTotalStaggerAmount)
			{
				num += 5;
			}
			bool hasStaggerThreshold = this.HasStaggerThreshold;
			if (hasStaggerThreshold)
			{
				num += 5;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003572 RID: 13682 RVA: 0x000D2F30 File Offset: 0x000D1130
		[DebuggerNonUserCode]
		public void MergeFrom(DebugCombatLogStaggerEvent other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasNewStaggerAmount = other.HasNewStaggerAmount;
				if (hasNewStaggerAmount)
				{
					this.NewStaggerAmount = other.NewStaggerAmount;
				}
				bool hasTotalStaggerAmount = other.HasTotalStaggerAmount;
				if (hasTotalStaggerAmount)
				{
					this.TotalStaggerAmount = other.TotalStaggerAmount;
				}
				bool hasStaggerThreshold = other.HasStaggerThreshold;
				if (hasStaggerThreshold)
				{
					this.StaggerThreshold = other.StaggerThreshold;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003573 RID: 13683 RVA: 0x000D2FAB File Offset: 0x000D11AB
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003574 RID: 13684 RVA: 0x000D2FB8 File Offset: 0x000D11B8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 13U)
				{
					if (num3 != 21U)
					{
						if (num3 != 29U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.StaggerThreshold = input.ReadFloat();
						}
					}
					else
					{
						this.TotalStaggerAmount = input.ReadFloat();
					}
				}
				else
				{
					this.NewStaggerAmount = input.ReadFloat();
				}
			}
		}

		// Token: 0x040018AB RID: 6315
		private static readonly MessageParser<DebugCombatLogStaggerEvent> _parser = new MessageParser<DebugCombatLogStaggerEvent>(() => new DebugCombatLogStaggerEvent());

		// Token: 0x040018AC RID: 6316
		private UnknownFieldSet _unknownFields;

		// Token: 0x040018AD RID: 6317
		private int _hasBits0;

		// Token: 0x040018AE RID: 6318
		public const int NewStaggerAmountFieldNumber = 1;

		// Token: 0x040018AF RID: 6319
		private static readonly float NewStaggerAmountDefaultValue = 0f;

		// Token: 0x040018B0 RID: 6320
		private float newStaggerAmount_;

		// Token: 0x040018B1 RID: 6321
		public const int TotalStaggerAmountFieldNumber = 2;

		// Token: 0x040018B2 RID: 6322
		private static readonly float TotalStaggerAmountDefaultValue = 0f;

		// Token: 0x040018B3 RID: 6323
		private float totalStaggerAmount_;

		// Token: 0x040018B4 RID: 6324
		public const int StaggerThresholdFieldNumber = 3;

		// Token: 0x040018B5 RID: 6325
		private static readonly float StaggerThresholdDefaultValue = 0f;

		// Token: 0x040018B6 RID: 6326
		private float staggerThreshold_;
	}
}
