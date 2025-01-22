using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001EA RID: 490
	public sealed class DebugCombatLogHealEvent : IMessage<DebugCombatLogHealEvent>, IMessage, IEquatable<DebugCombatLogHealEvent>, IDeepCloneable<DebugCombatLogHealEvent>, IBufferMessage
	{
		// Token: 0x1700114B RID: 4427
		// (get) Token: 0x06003540 RID: 13632 RVA: 0x000D25C8 File Offset: 0x000D07C8
		[DebuggerNonUserCode]
		public static MessageParser<DebugCombatLogHealEvent> Parser
		{
			get
			{
				return DebugCombatLogHealEvent._parser;
			}
		}

		// Token: 0x1700114C RID: 4428
		// (get) Token: 0x06003541 RID: 13633 RVA: 0x000D25E0 File Offset: 0x000D07E0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[47];
			}
		}

		// Token: 0x1700114D RID: 4429
		// (get) Token: 0x06003542 RID: 13634 RVA: 0x000D2604 File Offset: 0x000D0804
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugCombatLogHealEvent.Descriptor;
			}
		}

		// Token: 0x06003543 RID: 13635 RVA: 0x000D261B File Offset: 0x000D081B
		[DebuggerNonUserCode]
		public DebugCombatLogHealEvent()
		{
		}

		// Token: 0x06003544 RID: 13636 RVA: 0x000D2625 File Offset: 0x000D0825
		[DebuggerNonUserCode]
		public DebugCombatLogHealEvent(DebugCombatLogHealEvent other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.healAmount_ = other.healAmount_;
			this.healthPostHeal_ = other.healthPostHeal_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003545 RID: 13637 RVA: 0x000D2664 File Offset: 0x000D0864
		[DebuggerNonUserCode]
		public DebugCombatLogHealEvent Clone()
		{
			return new DebugCombatLogHealEvent(this);
		}

		// Token: 0x1700114E RID: 4430
		// (get) Token: 0x06003546 RID: 13638 RVA: 0x000D267C File Offset: 0x000D087C
		// (set) Token: 0x06003547 RID: 13639 RVA: 0x000D26AD File Offset: 0x000D08AD
		[DebuggerNonUserCode]
		public float HealAmount
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				float healAmountDefaultValue;
				if (flag)
				{
					healAmountDefaultValue = this.healAmount_;
				}
				else
				{
					healAmountDefaultValue = DebugCombatLogHealEvent.HealAmountDefaultValue;
				}
				return healAmountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.healAmount_ = value;
			}
		}

		// Token: 0x1700114F RID: 4431
		// (get) Token: 0x06003548 RID: 13640 RVA: 0x000D26C8 File Offset: 0x000D08C8
		[DebuggerNonUserCode]
		public bool HasHealAmount
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003549 RID: 13641 RVA: 0x000D26E5 File Offset: 0x000D08E5
		[DebuggerNonUserCode]
		public void ClearHealAmount()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001150 RID: 4432
		// (get) Token: 0x0600354A RID: 13642 RVA: 0x000D26F8 File Offset: 0x000D08F8
		// (set) Token: 0x0600354B RID: 13643 RVA: 0x000D2729 File Offset: 0x000D0929
		[DebuggerNonUserCode]
		public float HealthPostHeal
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float healthPostHealDefaultValue;
				if (flag)
				{
					healthPostHealDefaultValue = this.healthPostHeal_;
				}
				else
				{
					healthPostHealDefaultValue = DebugCombatLogHealEvent.HealthPostHealDefaultValue;
				}
				return healthPostHealDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.healthPostHeal_ = value;
			}
		}

		// Token: 0x17001151 RID: 4433
		// (get) Token: 0x0600354C RID: 13644 RVA: 0x000D2744 File Offset: 0x000D0944
		[DebuggerNonUserCode]
		public bool HasHealthPostHeal
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600354D RID: 13645 RVA: 0x000D2761 File Offset: 0x000D0961
		[DebuggerNonUserCode]
		public void ClearHealthPostHeal()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600354E RID: 13646 RVA: 0x000D2774 File Offset: 0x000D0974
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugCombatLogHealEvent);
		}

		// Token: 0x0600354F RID: 13647 RVA: 0x000D2794 File Offset: 0x000D0994
		[DebuggerNonUserCode]
		public bool Equals(DebugCombatLogHealEvent other)
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
					bool flag4 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.HealAmount, other.HealAmount);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.HealthPostHeal, other.HealthPostHeal);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003550 RID: 13648 RVA: 0x000D2818 File Offset: 0x000D0A18
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasHealAmount = this.HasHealAmount;
			if (hasHealAmount)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.HealAmount);
			}
			bool hasHealthPostHeal = this.HasHealthPostHeal;
			if (hasHealthPostHeal)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.HealthPostHeal);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003551 RID: 13649 RVA: 0x000D2888 File Offset: 0x000D0A88
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003552 RID: 13650 RVA: 0x000D28A0 File Offset: 0x000D0AA0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003553 RID: 13651 RVA: 0x000D28AC File Offset: 0x000D0AAC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasHealAmount = this.HasHealAmount;
			if (hasHealAmount)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.HealAmount);
			}
			bool hasHealthPostHeal = this.HasHealthPostHeal;
			if (hasHealthPostHeal)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.HealthPostHeal);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003554 RID: 13652 RVA: 0x000D291C File Offset: 0x000D0B1C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasHealAmount = this.HasHealAmount;
			if (hasHealAmount)
			{
				num += 5;
			}
			bool hasHealthPostHeal = this.HasHealthPostHeal;
			if (hasHealthPostHeal)
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

		// Token: 0x06003555 RID: 13653 RVA: 0x000D2970 File Offset: 0x000D0B70
		[DebuggerNonUserCode]
		public void MergeFrom(DebugCombatLogHealEvent other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasHealAmount = other.HasHealAmount;
				if (hasHealAmount)
				{
					this.HealAmount = other.HealAmount;
				}
				bool hasHealthPostHeal = other.HasHealthPostHeal;
				if (hasHealthPostHeal)
				{
					this.HealthPostHeal = other.HealthPostHeal;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003556 RID: 13654 RVA: 0x000D29D2 File Offset: 0x000D0BD2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003557 RID: 13655 RVA: 0x000D29E0 File Offset: 0x000D0BE0
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.HealthPostHeal = input.ReadFloat();
					}
				}
				else
				{
					this.HealAmount = input.ReadFloat();
				}
			}
		}

		// Token: 0x040018A2 RID: 6306
		private static readonly MessageParser<DebugCombatLogHealEvent> _parser = new MessageParser<DebugCombatLogHealEvent>(() => new DebugCombatLogHealEvent());

		// Token: 0x040018A3 RID: 6307
		private UnknownFieldSet _unknownFields;

		// Token: 0x040018A4 RID: 6308
		private int _hasBits0;

		// Token: 0x040018A5 RID: 6309
		public const int HealAmountFieldNumber = 1;

		// Token: 0x040018A6 RID: 6310
		private static readonly float HealAmountDefaultValue = 0f;

		// Token: 0x040018A7 RID: 6311
		private float healAmount_;

		// Token: 0x040018A8 RID: 6312
		public const int HealthPostHealFieldNumber = 2;

		// Token: 0x040018A9 RID: 6313
		private static readonly float HealthPostHealDefaultValue = 0f;

		// Token: 0x040018AA RID: 6314
		private float healthPostHeal_;
	}
}
