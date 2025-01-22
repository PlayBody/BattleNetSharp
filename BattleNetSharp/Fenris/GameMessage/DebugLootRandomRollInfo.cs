using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001F6 RID: 502
	public sealed class DebugLootRandomRollInfo : IMessage<DebugLootRandomRollInfo>, IMessage, IEquatable<DebugLootRandomRollInfo>, IDeepCloneable<DebugLootRandomRollInfo>, IBufferMessage
	{
		// Token: 0x170011ED RID: 4589
		// (get) Token: 0x060036FF RID: 14079 RVA: 0x000D9664 File Offset: 0x000D7864
		[DebuggerNonUserCode]
		public static MessageParser<DebugLootRandomRollInfo> Parser
		{
			get
			{
				return DebugLootRandomRollInfo._parser;
			}
		}

		// Token: 0x170011EE RID: 4590
		// (get) Token: 0x06003700 RID: 14080 RVA: 0x000D967C File Offset: 0x000D787C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[59];
			}
		}

		// Token: 0x170011EF RID: 4591
		// (get) Token: 0x06003701 RID: 14081 RVA: 0x000D96A0 File Offset: 0x000D78A0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugLootRandomRollInfo.Descriptor;
			}
		}

		// Token: 0x06003702 RID: 14082 RVA: 0x000D96B7 File Offset: 0x000D78B7
		[DebuggerNonUserCode]
		public DebugLootRandomRollInfo()
		{
		}

		// Token: 0x06003703 RID: 14083 RVA: 0x000D96CC File Offset: 0x000D78CC
		[DebuggerNonUserCode]
		public DebugLootRandomRollInfo(DebugLootRandomRollInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.chance_ = other.chance_;
			this.roll_ = other.roll_;
			this.chanceHistory_ = other.chanceHistory_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003704 RID: 14084 RVA: 0x000D9728 File Offset: 0x000D7928
		[DebuggerNonUserCode]
		public DebugLootRandomRollInfo Clone()
		{
			return new DebugLootRandomRollInfo(this);
		}

		// Token: 0x170011F0 RID: 4592
		// (get) Token: 0x06003705 RID: 14085 RVA: 0x000D9740 File Offset: 0x000D7940
		// (set) Token: 0x06003706 RID: 14086 RVA: 0x000D9771 File Offset: 0x000D7971
		[DebuggerNonUserCode]
		public float Chance
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				float chanceDefaultValue;
				if (flag)
				{
					chanceDefaultValue = this.chance_;
				}
				else
				{
					chanceDefaultValue = DebugLootRandomRollInfo.ChanceDefaultValue;
				}
				return chanceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.chance_ = value;
			}
		}

		// Token: 0x170011F1 RID: 4593
		// (get) Token: 0x06003707 RID: 14087 RVA: 0x000D978C File Offset: 0x000D798C
		[DebuggerNonUserCode]
		public bool HasChance
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003708 RID: 14088 RVA: 0x000D97A9 File Offset: 0x000D79A9
		[DebuggerNonUserCode]
		public void ClearChance()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170011F2 RID: 4594
		// (get) Token: 0x06003709 RID: 14089 RVA: 0x000D97BC File Offset: 0x000D79BC
		// (set) Token: 0x0600370A RID: 14090 RVA: 0x000D97ED File Offset: 0x000D79ED
		[DebuggerNonUserCode]
		public float Roll
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float rollDefaultValue;
				if (flag)
				{
					rollDefaultValue = this.roll_;
				}
				else
				{
					rollDefaultValue = DebugLootRandomRollInfo.RollDefaultValue;
				}
				return rollDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.roll_ = value;
			}
		}

		// Token: 0x170011F3 RID: 4595
		// (get) Token: 0x0600370B RID: 14091 RVA: 0x000D9808 File Offset: 0x000D7A08
		[DebuggerNonUserCode]
		public bool HasRoll
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600370C RID: 14092 RVA: 0x000D9825 File Offset: 0x000D7A25
		[DebuggerNonUserCode]
		public void ClearRoll()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170011F4 RID: 4596
		// (get) Token: 0x0600370D RID: 14093 RVA: 0x000D9838 File Offset: 0x000D7A38
		[DebuggerNonUserCode]
		public RepeatedField<DebugLootValueRecord> ChanceHistory
		{
			get
			{
				return this.chanceHistory_;
			}
		}

		// Token: 0x0600370E RID: 14094 RVA: 0x000D9850 File Offset: 0x000D7A50
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugLootRandomRollInfo);
		}

		// Token: 0x0600370F RID: 14095 RVA: 0x000D9870 File Offset: 0x000D7A70
		[DebuggerNonUserCode]
		public bool Equals(DebugLootRandomRollInfo other)
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
					bool flag4 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Chance, other.Chance);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Roll, other.Roll);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.chanceHistory_.Equals(other.chanceHistory_);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003710 RID: 14096 RVA: 0x000D9914 File Offset: 0x000D7B14
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasChance = this.HasChance;
			if (hasChance)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Chance);
			}
			bool hasRoll = this.HasRoll;
			if (hasRoll)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Roll);
			}
			num ^= this.chanceHistory_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003711 RID: 14097 RVA: 0x000D9990 File Offset: 0x000D7B90
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003712 RID: 14098 RVA: 0x000D99A8 File Offset: 0x000D7BA8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003713 RID: 14099 RVA: 0x000D99B4 File Offset: 0x000D7BB4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasChance = this.HasChance;
			if (hasChance)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.Chance);
			}
			bool hasRoll = this.HasRoll;
			if (hasRoll)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.Roll);
			}
			this.chanceHistory_.WriteTo(ref output, DebugLootRandomRollInfo._repeated_chanceHistory_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003714 RID: 14100 RVA: 0x000D9A34 File Offset: 0x000D7C34
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasChance = this.HasChance;
			if (hasChance)
			{
				num += 5;
			}
			bool hasRoll = this.HasRoll;
			if (hasRoll)
			{
				num += 5;
			}
			num += this.chanceHistory_.CalculateSize(DebugLootRandomRollInfo._repeated_chanceHistory_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003715 RID: 14101 RVA: 0x000D9A9C File Offset: 0x000D7C9C
		[DebuggerNonUserCode]
		public void MergeFrom(DebugLootRandomRollInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasChance = other.HasChance;
				if (hasChance)
				{
					this.Chance = other.Chance;
				}
				bool hasRoll = other.HasRoll;
				if (hasRoll)
				{
					this.Roll = other.Roll;
				}
				this.chanceHistory_.Add(other.chanceHistory_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003716 RID: 14102 RVA: 0x000D9B10 File Offset: 0x000D7D10
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003717 RID: 14103 RVA: 0x000D9B1C File Offset: 0x000D7D1C
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.chanceHistory_.AddEntriesFrom(ref input, DebugLootRandomRollInfo._repeated_chanceHistory_codec);
						}
					}
					else
					{
						this.Roll = input.ReadFloat();
					}
				}
				else
				{
					this.Chance = input.ReadFloat();
				}
			}
		}

		// Token: 0x04001994 RID: 6548
		private static readonly MessageParser<DebugLootRandomRollInfo> _parser = new MessageParser<DebugLootRandomRollInfo>(() => new DebugLootRandomRollInfo());

		// Token: 0x04001995 RID: 6549
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001996 RID: 6550
		private int _hasBits0;

		// Token: 0x04001997 RID: 6551
		public const int ChanceFieldNumber = 1;

		// Token: 0x04001998 RID: 6552
		private static readonly float ChanceDefaultValue = 0f;

		// Token: 0x04001999 RID: 6553
		private float chance_;

		// Token: 0x0400199A RID: 6554
		public const int RollFieldNumber = 2;

		// Token: 0x0400199B RID: 6555
		private static readonly float RollDefaultValue = 0f;

		// Token: 0x0400199C RID: 6556
		private float roll_;

		// Token: 0x0400199D RID: 6557
		public const int ChanceHistoryFieldNumber = 3;

		// Token: 0x0400199E RID: 6558
		private static readonly FieldCodec<DebugLootValueRecord> _repeated_chanceHistory_codec = FieldCodec.ForMessage<DebugLootValueRecord>(26U, DebugLootValueRecord.Parser);

		// Token: 0x0400199F RID: 6559
		private readonly RepeatedField<DebugLootValueRecord> chanceHistory_ = new RepeatedField<DebugLootValueRecord>();
	}
}
