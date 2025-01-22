using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001F4 RID: 500
	public sealed class DebugLootEntryInfo : IMessage<DebugLootEntryInfo>, IMessage, IEquatable<DebugLootEntryInfo>, IDeepCloneable<DebugLootEntryInfo>, IBufferMessage
	{
		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x060036B2 RID: 14002 RVA: 0x000D8310 File Offset: 0x000D6510
		[DebuggerNonUserCode]
		public static MessageParser<DebugLootEntryInfo> Parser
		{
			get
			{
				return DebugLootEntryInfo._parser;
			}
		}

		// Token: 0x170011D1 RID: 4561
		// (get) Token: 0x060036B3 RID: 14003 RVA: 0x000D8328 File Offset: 0x000D6528
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[57];
			}
		}

		// Token: 0x170011D2 RID: 4562
		// (get) Token: 0x060036B4 RID: 14004 RVA: 0x000D834C File Offset: 0x000D654C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugLootEntryInfo.Descriptor;
			}
		}

		// Token: 0x060036B5 RID: 14005 RVA: 0x000D8363 File Offset: 0x000D6563
		[DebuggerNonUserCode]
		public DebugLootEntryInfo()
		{
		}

		// Token: 0x060036B6 RID: 14006 RVA: 0x000D8384 File Offset: 0x000D6584
		[DebuggerNonUserCode]
		public DebugLootEntryInfo(DebugLootEntryInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.flags_ = other.flags_;
			this.quantity_ = other.quantity_;
			this.roll_ = other.roll_;
			this.finalChance_ = other.finalChance_;
			this.chanceHistory_ = other.chanceHistory_.Clone();
			this.results_ = other.results_.Clone();
			this.failedConditionSno_ = other.failedConditionSno_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060036B7 RID: 14007 RVA: 0x000D8414 File Offset: 0x000D6614
		[DebuggerNonUserCode]
		public DebugLootEntryInfo Clone()
		{
			return new DebugLootEntryInfo(this);
		}

		// Token: 0x170011D3 RID: 4563
		// (get) Token: 0x060036B8 RID: 14008 RVA: 0x000D842C File Offset: 0x000D662C
		// (set) Token: 0x060036B9 RID: 14009 RVA: 0x000D845D File Offset: 0x000D665D
		[DebuggerNonUserCode]
		public int Flags
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int flagsDefaultValue;
				if (flag)
				{
					flagsDefaultValue = this.flags_;
				}
				else
				{
					flagsDefaultValue = DebugLootEntryInfo.FlagsDefaultValue;
				}
				return flagsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.flags_ = value;
			}
		}

		// Token: 0x170011D4 RID: 4564
		// (get) Token: 0x060036BA RID: 14010 RVA: 0x000D8478 File Offset: 0x000D6678
		[DebuggerNonUserCode]
		public bool HasFlags
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060036BB RID: 14011 RVA: 0x000D8495 File Offset: 0x000D6695
		[DebuggerNonUserCode]
		public void ClearFlags()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x060036BC RID: 14012 RVA: 0x000D84A8 File Offset: 0x000D66A8
		// (set) Token: 0x060036BD RID: 14013 RVA: 0x000D84D9 File Offset: 0x000D66D9
		[DebuggerNonUserCode]
		public int Quantity
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int quantityDefaultValue;
				if (flag)
				{
					quantityDefaultValue = this.quantity_;
				}
				else
				{
					quantityDefaultValue = DebugLootEntryInfo.QuantityDefaultValue;
				}
				return quantityDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.quantity_ = value;
			}
		}

		// Token: 0x170011D6 RID: 4566
		// (get) Token: 0x060036BE RID: 14014 RVA: 0x000D84F4 File Offset: 0x000D66F4
		[DebuggerNonUserCode]
		public bool HasQuantity
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060036BF RID: 14015 RVA: 0x000D8511 File Offset: 0x000D6711
		[DebuggerNonUserCode]
		public void ClearQuantity()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170011D7 RID: 4567
		// (get) Token: 0x060036C0 RID: 14016 RVA: 0x000D8524 File Offset: 0x000D6724
		// (set) Token: 0x060036C1 RID: 14017 RVA: 0x000D8555 File Offset: 0x000D6755
		[DebuggerNonUserCode]
		public float Roll
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				float rollDefaultValue;
				if (flag)
				{
					rollDefaultValue = this.roll_;
				}
				else
				{
					rollDefaultValue = DebugLootEntryInfo.RollDefaultValue;
				}
				return rollDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.roll_ = value;
			}
		}

		// Token: 0x170011D8 RID: 4568
		// (get) Token: 0x060036C2 RID: 14018 RVA: 0x000D8570 File Offset: 0x000D6770
		[DebuggerNonUserCode]
		public bool HasRoll
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060036C3 RID: 14019 RVA: 0x000D858D File Offset: 0x000D678D
		[DebuggerNonUserCode]
		public void ClearRoll()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170011D9 RID: 4569
		// (get) Token: 0x060036C4 RID: 14020 RVA: 0x000D85A0 File Offset: 0x000D67A0
		// (set) Token: 0x060036C5 RID: 14021 RVA: 0x000D85D1 File Offset: 0x000D67D1
		[DebuggerNonUserCode]
		public float FinalChance
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				float finalChanceDefaultValue;
				if (flag)
				{
					finalChanceDefaultValue = this.finalChance_;
				}
				else
				{
					finalChanceDefaultValue = DebugLootEntryInfo.FinalChanceDefaultValue;
				}
				return finalChanceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.finalChance_ = value;
			}
		}

		// Token: 0x170011DA RID: 4570
		// (get) Token: 0x060036C6 RID: 14022 RVA: 0x000D85EC File Offset: 0x000D67EC
		[DebuggerNonUserCode]
		public bool HasFinalChance
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060036C7 RID: 14023 RVA: 0x000D8609 File Offset: 0x000D6809
		[DebuggerNonUserCode]
		public void ClearFinalChance()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x170011DB RID: 4571
		// (get) Token: 0x060036C8 RID: 14024 RVA: 0x000D861C File Offset: 0x000D681C
		[DebuggerNonUserCode]
		public RepeatedField<DebugLootValueRecord> ChanceHistory
		{
			get
			{
				return this.chanceHistory_;
			}
		}

		// Token: 0x170011DC RID: 4572
		// (get) Token: 0x060036C9 RID: 14025 RVA: 0x000D8634 File Offset: 0x000D6834
		[DebuggerNonUserCode]
		public RepeatedField<DebugLootEntryResult> Results
		{
			get
			{
				return this.results_;
			}
		}

		// Token: 0x170011DD RID: 4573
		// (get) Token: 0x060036CA RID: 14026 RVA: 0x000D864C File Offset: 0x000D684C
		// (set) Token: 0x060036CB RID: 14027 RVA: 0x000D867E File Offset: 0x000D687E
		[DebuggerNonUserCode]
		public int FailedConditionSno
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				int failedConditionSnoDefaultValue;
				if (flag)
				{
					failedConditionSnoDefaultValue = this.failedConditionSno_;
				}
				else
				{
					failedConditionSnoDefaultValue = DebugLootEntryInfo.FailedConditionSnoDefaultValue;
				}
				return failedConditionSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.failedConditionSno_ = value;
			}
		}

		// Token: 0x170011DE RID: 4574
		// (get) Token: 0x060036CC RID: 14028 RVA: 0x000D8698 File Offset: 0x000D6898
		[DebuggerNonUserCode]
		public bool HasFailedConditionSno
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x060036CD RID: 14029 RVA: 0x000D86B6 File Offset: 0x000D68B6
		[DebuggerNonUserCode]
		public void ClearFailedConditionSno()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x060036CE RID: 14030 RVA: 0x000D86C8 File Offset: 0x000D68C8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugLootEntryInfo);
		}

		// Token: 0x060036CF RID: 14031 RVA: 0x000D86E8 File Offset: 0x000D68E8
		[DebuggerNonUserCode]
		public bool Equals(DebugLootEntryInfo other)
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
					bool flag4 = this.Flags != other.Flags;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Quantity != other.Quantity;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Roll, other.Roll);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.FinalChance, other.FinalChance);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.chanceHistory_.Equals(other.chanceHistory_);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !this.results_.Equals(other.results_);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.FailedConditionSno != other.FailedConditionSno;
											flag2 = !flag10 && object.Equals(this._unknownFields, other._unknownFields);
										}
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060036D0 RID: 14032 RVA: 0x000D8808 File Offset: 0x000D6A08
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				num ^= this.Flags.GetHashCode();
			}
			bool hasQuantity = this.HasQuantity;
			if (hasQuantity)
			{
				num ^= this.Quantity.GetHashCode();
			}
			bool hasRoll = this.HasRoll;
			if (hasRoll)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Roll);
			}
			bool hasFinalChance = this.HasFinalChance;
			if (hasFinalChance)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.FinalChance);
			}
			num ^= this.chanceHistory_.GetHashCode();
			num ^= this.results_.GetHashCode();
			bool hasFailedConditionSno = this.HasFailedConditionSno;
			if (hasFailedConditionSno)
			{
				num ^= this.FailedConditionSno.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060036D1 RID: 14033 RVA: 0x000D88EC File Offset: 0x000D6AEC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060036D2 RID: 14034 RVA: 0x000D8904 File Offset: 0x000D6B04
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060036D3 RID: 14035 RVA: 0x000D8910 File Offset: 0x000D6B10
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Flags);
			}
			bool hasQuantity = this.HasQuantity;
			if (hasQuantity)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Quantity);
			}
			bool hasRoll = this.HasRoll;
			if (hasRoll)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.Roll);
			}
			bool hasFinalChance = this.HasFinalChance;
			if (hasFinalChance)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.FinalChance);
			}
			this.chanceHistory_.WriteTo(ref output, DebugLootEntryInfo._repeated_chanceHistory_codec);
			this.results_.WriteTo(ref output, DebugLootEntryInfo._repeated_results_codec);
			bool hasFailedConditionSno = this.HasFailedConditionSno;
			if (hasFailedConditionSno)
			{
				output.WriteRawTag(61);
				output.WriteSFixed32(this.FailedConditionSno);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060036D4 RID: 14036 RVA: 0x000D8A0C File Offset: 0x000D6C0C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Flags);
			}
			bool hasQuantity = this.HasQuantity;
			if (hasQuantity)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Quantity);
			}
			bool hasRoll = this.HasRoll;
			if (hasRoll)
			{
				num += 5;
			}
			bool hasFinalChance = this.HasFinalChance;
			if (hasFinalChance)
			{
				num += 5;
			}
			num += this.chanceHistory_.CalculateSize(DebugLootEntryInfo._repeated_chanceHistory_codec);
			num += this.results_.CalculateSize(DebugLootEntryInfo._repeated_results_codec);
			bool hasFailedConditionSno = this.HasFailedConditionSno;
			if (hasFailedConditionSno)
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

		// Token: 0x060036D5 RID: 14037 RVA: 0x000D8AD4 File Offset: 0x000D6CD4
		[DebuggerNonUserCode]
		public void MergeFrom(DebugLootEntryInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasFlags = other.HasFlags;
				if (hasFlags)
				{
					this.Flags = other.Flags;
				}
				bool hasQuantity = other.HasQuantity;
				if (hasQuantity)
				{
					this.Quantity = other.Quantity;
				}
				bool hasRoll = other.HasRoll;
				if (hasRoll)
				{
					this.Roll = other.Roll;
				}
				bool hasFinalChance = other.HasFinalChance;
				if (hasFinalChance)
				{
					this.FinalChance = other.FinalChance;
				}
				this.chanceHistory_.Add(other.chanceHistory_);
				this.results_.Add(other.results_);
				bool hasFailedConditionSno = other.HasFailedConditionSno;
				if (hasFailedConditionSno)
				{
					this.FailedConditionSno = other.FailedConditionSno;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060036D6 RID: 14038 RVA: 0x000D8BAC File Offset: 0x000D6DAC
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060036D7 RID: 14039 RVA: 0x000D8BB8 File Offset: 0x000D6DB8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 29U)
				{
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							if (num3 != 29U)
							{
								goto IL_0048;
							}
							this.Roll = input.ReadFloat();
						}
						else
						{
							this.Quantity = input.ReadInt32();
						}
					}
					else
					{
						this.Flags = input.ReadInt32();
					}
				}
				else if (num3 <= 42U)
				{
					if (num3 != 37U)
					{
						if (num3 != 42U)
						{
							goto IL_0048;
						}
						this.chanceHistory_.AddEntriesFrom(ref input, DebugLootEntryInfo._repeated_chanceHistory_codec);
					}
					else
					{
						this.FinalChance = input.ReadFloat();
					}
				}
				else if (num3 != 50U)
				{
					if (num3 != 61U)
					{
						goto IL_0048;
					}
					this.FailedConditionSno = input.ReadSFixed32();
				}
				else
				{
					this.results_.AddEntriesFrom(ref input, DebugLootEntryInfo._repeated_results_codec);
				}
				continue;
				IL_0048:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001967 RID: 6503
		private static readonly MessageParser<DebugLootEntryInfo> _parser = new MessageParser<DebugLootEntryInfo>(() => new DebugLootEntryInfo());

		// Token: 0x04001968 RID: 6504
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001969 RID: 6505
		private int _hasBits0;

		// Token: 0x0400196A RID: 6506
		public const int FlagsFieldNumber = 1;

		// Token: 0x0400196B RID: 6507
		private static readonly int FlagsDefaultValue = 0;

		// Token: 0x0400196C RID: 6508
		private int flags_;

		// Token: 0x0400196D RID: 6509
		public const int QuantityFieldNumber = 2;

		// Token: 0x0400196E RID: 6510
		private static readonly int QuantityDefaultValue = 0;

		// Token: 0x0400196F RID: 6511
		private int quantity_;

		// Token: 0x04001970 RID: 6512
		public const int RollFieldNumber = 3;

		// Token: 0x04001971 RID: 6513
		private static readonly float RollDefaultValue = 0f;

		// Token: 0x04001972 RID: 6514
		private float roll_;

		// Token: 0x04001973 RID: 6515
		public const int FinalChanceFieldNumber = 4;

		// Token: 0x04001974 RID: 6516
		private static readonly float FinalChanceDefaultValue = 0f;

		// Token: 0x04001975 RID: 6517
		private float finalChance_;

		// Token: 0x04001976 RID: 6518
		public const int ChanceHistoryFieldNumber = 5;

		// Token: 0x04001977 RID: 6519
		private static readonly FieldCodec<DebugLootValueRecord> _repeated_chanceHistory_codec = FieldCodec.ForMessage<DebugLootValueRecord>(42U, DebugLootValueRecord.Parser);

		// Token: 0x04001978 RID: 6520
		private readonly RepeatedField<DebugLootValueRecord> chanceHistory_ = new RepeatedField<DebugLootValueRecord>();

		// Token: 0x04001979 RID: 6521
		public const int ResultsFieldNumber = 6;

		// Token: 0x0400197A RID: 6522
		private static readonly FieldCodec<DebugLootEntryResult> _repeated_results_codec = FieldCodec.ForMessage<DebugLootEntryResult>(50U, DebugLootEntryResult.Parser);

		// Token: 0x0400197B RID: 6523
		private readonly RepeatedField<DebugLootEntryResult> results_ = new RepeatedField<DebugLootEntryResult>();

		// Token: 0x0400197C RID: 6524
		public const int FailedConditionSnoFieldNumber = 7;

		// Token: 0x0400197D RID: 6525
		private static readonly int FailedConditionSnoDefaultValue = 0;

		// Token: 0x0400197E RID: 6526
		private int failedConditionSno_;
	}
}
