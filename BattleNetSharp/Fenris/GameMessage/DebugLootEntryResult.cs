using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001F3 RID: 499
	public sealed class DebugLootEntryResult : IMessage<DebugLootEntryResult>, IMessage, IEquatable<DebugLootEntryResult>, IDeepCloneable<DebugLootEntryResult>, IBufferMessage
	{
		// Token: 0x170011BC RID: 4540
		// (get) Token: 0x06003680 RID: 13952 RVA: 0x000D75EC File Offset: 0x000D57EC
		[DebuggerNonUserCode]
		public static MessageParser<DebugLootEntryResult> Parser
		{
			get
			{
				return DebugLootEntryResult._parser;
			}
		}

		// Token: 0x170011BD RID: 4541
		// (get) Token: 0x06003681 RID: 13953 RVA: 0x000D7604 File Offset: 0x000D5804
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[56];
			}
		}

		// Token: 0x170011BE RID: 4542
		// (get) Token: 0x06003682 RID: 13954 RVA: 0x000D7628 File Offset: 0x000D5828
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugLootEntryResult.Descriptor;
			}
		}

		// Token: 0x06003683 RID: 13955 RVA: 0x000D763F File Offset: 0x000D583F
		[DebuggerNonUserCode]
		public DebugLootEntryResult()
		{
		}

		// Token: 0x06003684 RID: 13956 RVA: 0x000D7654 File Offset: 0x000D5854
		[DebuggerNonUserCode]
		public DebugLootEntryResult(DebugLootEntryResult other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.outputId_ = other.outputId_;
			this.flags_ = other.flags_;
			this.roll_ = other.roll_;
			this.finalChance_ = other.finalChance_;
			this.chanceHistory_ = other.chanceHistory_.Clone();
			this.nextNodeId_ = other.nextNodeId_;
			this.itemSno_ = other.itemSno_;
			this.currencyAmount_ = other.currencyAmount_;
			this.failedConditionSno_ = other.failedConditionSno_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003685 RID: 13957 RVA: 0x000D76F8 File Offset: 0x000D58F8
		[DebuggerNonUserCode]
		public DebugLootEntryResult Clone()
		{
			return new DebugLootEntryResult(this);
		}

		// Token: 0x170011BF RID: 4543
		// (get) Token: 0x06003686 RID: 13958 RVA: 0x000D7710 File Offset: 0x000D5910
		// (set) Token: 0x06003687 RID: 13959 RVA: 0x000D7741 File Offset: 0x000D5941
		[DebuggerNonUserCode]
		public uint OutputId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint outputIdDefaultValue;
				if (flag)
				{
					outputIdDefaultValue = this.outputId_;
				}
				else
				{
					outputIdDefaultValue = DebugLootEntryResult.OutputIdDefaultValue;
				}
				return outputIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.outputId_ = value;
			}
		}

		// Token: 0x170011C0 RID: 4544
		// (get) Token: 0x06003688 RID: 13960 RVA: 0x000D775C File Offset: 0x000D595C
		[DebuggerNonUserCode]
		public bool HasOutputId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003689 RID: 13961 RVA: 0x000D7779 File Offset: 0x000D5979
		[DebuggerNonUserCode]
		public void ClearOutputId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170011C1 RID: 4545
		// (get) Token: 0x0600368A RID: 13962 RVA: 0x000D778C File Offset: 0x000D598C
		// (set) Token: 0x0600368B RID: 13963 RVA: 0x000D77BD File Offset: 0x000D59BD
		[DebuggerNonUserCode]
		public int Flags
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int flagsDefaultValue;
				if (flag)
				{
					flagsDefaultValue = this.flags_;
				}
				else
				{
					flagsDefaultValue = DebugLootEntryResult.FlagsDefaultValue;
				}
				return flagsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.flags_ = value;
			}
		}

		// Token: 0x170011C2 RID: 4546
		// (get) Token: 0x0600368C RID: 13964 RVA: 0x000D77D8 File Offset: 0x000D59D8
		[DebuggerNonUserCode]
		public bool HasFlags
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600368D RID: 13965 RVA: 0x000D77F5 File Offset: 0x000D59F5
		[DebuggerNonUserCode]
		public void ClearFlags()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170011C3 RID: 4547
		// (get) Token: 0x0600368E RID: 13966 RVA: 0x000D7808 File Offset: 0x000D5A08
		// (set) Token: 0x0600368F RID: 13967 RVA: 0x000D7839 File Offset: 0x000D5A39
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
					rollDefaultValue = DebugLootEntryResult.RollDefaultValue;
				}
				return rollDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.roll_ = value;
			}
		}

		// Token: 0x170011C4 RID: 4548
		// (get) Token: 0x06003690 RID: 13968 RVA: 0x000D7854 File Offset: 0x000D5A54
		[DebuggerNonUserCode]
		public bool HasRoll
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06003691 RID: 13969 RVA: 0x000D7871 File Offset: 0x000D5A71
		[DebuggerNonUserCode]
		public void ClearRoll()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170011C5 RID: 4549
		// (get) Token: 0x06003692 RID: 13970 RVA: 0x000D7884 File Offset: 0x000D5A84
		// (set) Token: 0x06003693 RID: 13971 RVA: 0x000D78B5 File Offset: 0x000D5AB5
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
					finalChanceDefaultValue = DebugLootEntryResult.FinalChanceDefaultValue;
				}
				return finalChanceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.finalChance_ = value;
			}
		}

		// Token: 0x170011C6 RID: 4550
		// (get) Token: 0x06003694 RID: 13972 RVA: 0x000D78D0 File Offset: 0x000D5AD0
		[DebuggerNonUserCode]
		public bool HasFinalChance
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06003695 RID: 13973 RVA: 0x000D78ED File Offset: 0x000D5AED
		[DebuggerNonUserCode]
		public void ClearFinalChance()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x170011C7 RID: 4551
		// (get) Token: 0x06003696 RID: 13974 RVA: 0x000D7900 File Offset: 0x000D5B00
		[DebuggerNonUserCode]
		public RepeatedField<DebugLootValueRecord> ChanceHistory
		{
			get
			{
				return this.chanceHistory_;
			}
		}

		// Token: 0x170011C8 RID: 4552
		// (get) Token: 0x06003697 RID: 13975 RVA: 0x000D7918 File Offset: 0x000D5B18
		// (set) Token: 0x06003698 RID: 13976 RVA: 0x000D794A File Offset: 0x000D5B4A
		[DebuggerNonUserCode]
		public uint NextNodeId
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint nextNodeIdDefaultValue;
				if (flag)
				{
					nextNodeIdDefaultValue = this.nextNodeId_;
				}
				else
				{
					nextNodeIdDefaultValue = DebugLootEntryResult.NextNodeIdDefaultValue;
				}
				return nextNodeIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.nextNodeId_ = value;
			}
		}

		// Token: 0x170011C9 RID: 4553
		// (get) Token: 0x06003699 RID: 13977 RVA: 0x000D7964 File Offset: 0x000D5B64
		[DebuggerNonUserCode]
		public bool HasNextNodeId
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600369A RID: 13978 RVA: 0x000D7982 File Offset: 0x000D5B82
		[DebuggerNonUserCode]
		public void ClearNextNodeId()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x170011CA RID: 4554
		// (get) Token: 0x0600369B RID: 13979 RVA: 0x000D7994 File Offset: 0x000D5B94
		// (set) Token: 0x0600369C RID: 13980 RVA: 0x000D79C6 File Offset: 0x000D5BC6
		[DebuggerNonUserCode]
		public int ItemSno
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				int itemSnoDefaultValue;
				if (flag)
				{
					itemSnoDefaultValue = this.itemSno_;
				}
				else
				{
					itemSnoDefaultValue = DebugLootEntryResult.ItemSnoDefaultValue;
				}
				return itemSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.itemSno_ = value;
			}
		}

		// Token: 0x170011CB RID: 4555
		// (get) Token: 0x0600369D RID: 13981 RVA: 0x000D79E0 File Offset: 0x000D5BE0
		[DebuggerNonUserCode]
		public bool HasItemSno
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x0600369E RID: 13982 RVA: 0x000D79FE File Offset: 0x000D5BFE
		[DebuggerNonUserCode]
		public void ClearItemSno()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x170011CC RID: 4556
		// (get) Token: 0x0600369F RID: 13983 RVA: 0x000D7A10 File Offset: 0x000D5C10
		// (set) Token: 0x060036A0 RID: 13984 RVA: 0x000D7A42 File Offset: 0x000D5C42
		[DebuggerNonUserCode]
		public int CurrencyAmount
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				int currencyAmountDefaultValue;
				if (flag)
				{
					currencyAmountDefaultValue = this.currencyAmount_;
				}
				else
				{
					currencyAmountDefaultValue = DebugLootEntryResult.CurrencyAmountDefaultValue;
				}
				return currencyAmountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.currencyAmount_ = value;
			}
		}

		// Token: 0x170011CD RID: 4557
		// (get) Token: 0x060036A1 RID: 13985 RVA: 0x000D7A5C File Offset: 0x000D5C5C
		[DebuggerNonUserCode]
		public bool HasCurrencyAmount
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x060036A2 RID: 13986 RVA: 0x000D7A7A File Offset: 0x000D5C7A
		[DebuggerNonUserCode]
		public void ClearCurrencyAmount()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x170011CE RID: 4558
		// (get) Token: 0x060036A3 RID: 13987 RVA: 0x000D7A8C File Offset: 0x000D5C8C
		// (set) Token: 0x060036A4 RID: 13988 RVA: 0x000D7AC1 File Offset: 0x000D5CC1
		[DebuggerNonUserCode]
		public int FailedConditionSno
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				int failedConditionSnoDefaultValue;
				if (flag)
				{
					failedConditionSnoDefaultValue = this.failedConditionSno_;
				}
				else
				{
					failedConditionSnoDefaultValue = DebugLootEntryResult.FailedConditionSnoDefaultValue;
				}
				return failedConditionSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.failedConditionSno_ = value;
			}
		}

		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x060036A5 RID: 13989 RVA: 0x000D7AE0 File Offset: 0x000D5CE0
		[DebuggerNonUserCode]
		public bool HasFailedConditionSno
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x060036A6 RID: 13990 RVA: 0x000D7B01 File Offset: 0x000D5D01
		[DebuggerNonUserCode]
		public void ClearFailedConditionSno()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x060036A7 RID: 13991 RVA: 0x000D7B18 File Offset: 0x000D5D18
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugLootEntryResult);
		}

		// Token: 0x060036A8 RID: 13992 RVA: 0x000D7B38 File Offset: 0x000D5D38
		[DebuggerNonUserCode]
		public bool Equals(DebugLootEntryResult other)
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
					bool flag4 = this.OutputId != other.OutputId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Flags != other.Flags;
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
										bool flag9 = this.NextNodeId != other.NextNodeId;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.ItemSno != other.ItemSno;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.CurrencyAmount != other.CurrencyAmount;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.FailedConditionSno != other.FailedConditionSno;
													flag2 = !flag12 && object.Equals(this._unknownFields, other._unknownFields);
												}
											}
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

		// Token: 0x060036A9 RID: 13993 RVA: 0x000D7C90 File Offset: 0x000D5E90
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasOutputId = this.HasOutputId;
			if (hasOutputId)
			{
				num ^= this.OutputId.GetHashCode();
			}
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				num ^= this.Flags.GetHashCode();
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
			bool hasNextNodeId = this.HasNextNodeId;
			if (hasNextNodeId)
			{
				num ^= this.NextNodeId.GetHashCode();
			}
			bool hasItemSno = this.HasItemSno;
			if (hasItemSno)
			{
				num ^= this.ItemSno.GetHashCode();
			}
			bool hasCurrencyAmount = this.HasCurrencyAmount;
			if (hasCurrencyAmount)
			{
				num ^= this.CurrencyAmount.GetHashCode();
			}
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

		// Token: 0x060036AA RID: 13994 RVA: 0x000D7DC0 File Offset: 0x000D5FC0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060036AB RID: 13995 RVA: 0x000D7DD8 File Offset: 0x000D5FD8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060036AC RID: 13996 RVA: 0x000D7DE4 File Offset: 0x000D5FE4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasOutputId = this.HasOutputId;
			if (hasOutputId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.OutputId);
			}
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Flags);
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
			this.chanceHistory_.WriteTo(ref output, DebugLootEntryResult._repeated_chanceHistory_codec);
			bool hasNextNodeId = this.HasNextNodeId;
			if (hasNextNodeId)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.NextNodeId);
			}
			bool hasItemSno = this.HasItemSno;
			if (hasItemSno)
			{
				output.WriteRawTag(61);
				output.WriteSFixed32(this.ItemSno);
			}
			bool hasCurrencyAmount = this.HasCurrencyAmount;
			if (hasCurrencyAmount)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.CurrencyAmount);
			}
			bool hasFailedConditionSno = this.HasFailedConditionSno;
			if (hasFailedConditionSno)
			{
				output.WriteRawTag(77);
				output.WriteSFixed32(this.FailedConditionSno);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060036AD RID: 13997 RVA: 0x000D7F3C File Offset: 0x000D613C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasOutputId = this.HasOutputId;
			if (hasOutputId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OutputId);
			}
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Flags);
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
			num += this.chanceHistory_.CalculateSize(DebugLootEntryResult._repeated_chanceHistory_codec);
			bool hasNextNodeId = this.HasNextNodeId;
			if (hasNextNodeId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NextNodeId);
			}
			bool hasItemSno = this.HasItemSno;
			if (hasItemSno)
			{
				num += 5;
			}
			bool hasCurrencyAmount = this.HasCurrencyAmount;
			if (hasCurrencyAmount)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurrencyAmount);
			}
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

		// Token: 0x060036AE RID: 13998 RVA: 0x000D8040 File Offset: 0x000D6240
		[DebuggerNonUserCode]
		public void MergeFrom(DebugLootEntryResult other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasOutputId = other.HasOutputId;
				if (hasOutputId)
				{
					this.OutputId = other.OutputId;
				}
				bool hasFlags = other.HasFlags;
				if (hasFlags)
				{
					this.Flags = other.Flags;
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
				bool hasNextNodeId = other.HasNextNodeId;
				if (hasNextNodeId)
				{
					this.NextNodeId = other.NextNodeId;
				}
				bool hasItemSno = other.HasItemSno;
				if (hasItemSno)
				{
					this.ItemSno = other.ItemSno;
				}
				bool hasCurrencyAmount = other.HasCurrencyAmount;
				if (hasCurrencyAmount)
				{
					this.CurrencyAmount = other.CurrencyAmount;
				}
				bool hasFailedConditionSno = other.HasFailedConditionSno;
				if (hasFailedConditionSno)
				{
					this.FailedConditionSno = other.FailedConditionSno;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060036AF RID: 13999 RVA: 0x000D8157 File Offset: 0x000D6357
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060036B0 RID: 14000 RVA: 0x000D8164 File Offset: 0x000D6364
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 37U)
				{
					if (num3 <= 16U)
					{
						if (num3 != 8U)
						{
							if (num3 != 16U)
							{
								goto IL_006A;
							}
							this.Flags = input.ReadInt32();
						}
						else
						{
							this.OutputId = input.ReadUInt32();
						}
					}
					else if (num3 != 29U)
					{
						if (num3 != 37U)
						{
							goto IL_006A;
						}
						this.FinalChance = input.ReadFloat();
					}
					else
					{
						this.Roll = input.ReadFloat();
					}
				}
				else if (num3 <= 48U)
				{
					if (num3 != 42U)
					{
						if (num3 != 48U)
						{
							goto IL_006A;
						}
						this.NextNodeId = input.ReadUInt32();
					}
					else
					{
						this.chanceHistory_.AddEntriesFrom(ref input, DebugLootEntryResult._repeated_chanceHistory_codec);
					}
				}
				else if (num3 != 61U)
				{
					if (num3 != 64U)
					{
						if (num3 != 77U)
						{
							goto IL_006A;
						}
						this.FailedConditionSno = input.ReadSFixed32();
					}
					else
					{
						this.CurrencyAmount = input.ReadInt32();
					}
				}
				else
				{
					this.ItemSno = input.ReadSFixed32();
				}
				continue;
				IL_006A:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001949 RID: 6473
		private static readonly MessageParser<DebugLootEntryResult> _parser = new MessageParser<DebugLootEntryResult>(() => new DebugLootEntryResult());

		// Token: 0x0400194A RID: 6474
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400194B RID: 6475
		private int _hasBits0;

		// Token: 0x0400194C RID: 6476
		public const int OutputIdFieldNumber = 1;

		// Token: 0x0400194D RID: 6477
		private static readonly uint OutputIdDefaultValue = 0U;

		// Token: 0x0400194E RID: 6478
		private uint outputId_;

		// Token: 0x0400194F RID: 6479
		public const int FlagsFieldNumber = 2;

		// Token: 0x04001950 RID: 6480
		private static readonly int FlagsDefaultValue = 0;

		// Token: 0x04001951 RID: 6481
		private int flags_;

		// Token: 0x04001952 RID: 6482
		public const int RollFieldNumber = 3;

		// Token: 0x04001953 RID: 6483
		private static readonly float RollDefaultValue = 0f;

		// Token: 0x04001954 RID: 6484
		private float roll_;

		// Token: 0x04001955 RID: 6485
		public const int FinalChanceFieldNumber = 4;

		// Token: 0x04001956 RID: 6486
		private static readonly float FinalChanceDefaultValue = 0f;

		// Token: 0x04001957 RID: 6487
		private float finalChance_;

		// Token: 0x04001958 RID: 6488
		public const int ChanceHistoryFieldNumber = 5;

		// Token: 0x04001959 RID: 6489
		private static readonly FieldCodec<DebugLootValueRecord> _repeated_chanceHistory_codec = FieldCodec.ForMessage<DebugLootValueRecord>(42U, DebugLootValueRecord.Parser);

		// Token: 0x0400195A RID: 6490
		private readonly RepeatedField<DebugLootValueRecord> chanceHistory_ = new RepeatedField<DebugLootValueRecord>();

		// Token: 0x0400195B RID: 6491
		public const int NextNodeIdFieldNumber = 6;

		// Token: 0x0400195C RID: 6492
		private static readonly uint NextNodeIdDefaultValue = 0U;

		// Token: 0x0400195D RID: 6493
		private uint nextNodeId_;

		// Token: 0x0400195E RID: 6494
		public const int ItemSnoFieldNumber = 7;

		// Token: 0x0400195F RID: 6495
		private static readonly int ItemSnoDefaultValue = 0;

		// Token: 0x04001960 RID: 6496
		private int itemSno_;

		// Token: 0x04001961 RID: 6497
		public const int CurrencyAmountFieldNumber = 8;

		// Token: 0x04001962 RID: 6498
		private static readonly int CurrencyAmountDefaultValue = 0;

		// Token: 0x04001963 RID: 6499
		private int currencyAmount_;

		// Token: 0x04001964 RID: 6500
		public const int FailedConditionSnoFieldNumber = 9;

		// Token: 0x04001965 RID: 6501
		private static readonly int FailedConditionSnoDefaultValue = 0;

		// Token: 0x04001966 RID: 6502
		private int failedConditionSno_;
	}
}
