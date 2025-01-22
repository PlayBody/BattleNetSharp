using System;
using System.Diagnostics;
using Fenris.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Quests
{
	// Token: 0x0200012F RID: 303
	public sealed class QuestReward : IMessage<QuestReward>, IMessage, IEquatable<QuestReward>, IDeepCloneable<QuestReward>, IBufferMessage
	{
		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06001E5F RID: 7775 RVA: 0x00074A74 File Offset: 0x00072C74
		[DebuggerNonUserCode]
		public static MessageParser<QuestReward> Parser
		{
			get
			{
				return QuestReward._parser;
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06001E60 RID: 7776 RVA: 0x00074A8C File Offset: 0x00072C8C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return QuestReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06001E61 RID: 7777 RVA: 0x00074AB0 File Offset: 0x00072CB0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestReward.Descriptor;
			}
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x00074AC7 File Offset: 0x00072CC7
		[DebuggerNonUserCode]
		public QuestReward()
		{
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x00074AF4 File Offset: 0x00072CF4
		[DebuggerNonUserCode]
		public QuestReward(QuestReward other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.ownerGameAccountId_ = other.ownerGameAccountId_;
			this.snoQuest_ = other.snoQuest_;
			this.xpGranted_ = other.xpGranted_;
			this.goldGranted_ = other.goldGranted_;
			this.items_ = other.items_.Clone();
			this.bonusXpGranted_ = other.bonusXpGranted_;
			this.currencyGranted_ = other.currencyGranted_.Clone();
			this.repGranted_ = other.repGranted_.Clone();
			this.snoTrackedRewardGranted_ = other.snoTrackedRewardGranted_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x00074BA4 File Offset: 0x00072DA4
		[DebuggerNonUserCode]
		public QuestReward Clone()
		{
			return new QuestReward(this);
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06001E65 RID: 7781 RVA: 0x00074BBC File Offset: 0x00072DBC
		// (set) Token: 0x06001E66 RID: 7782 RVA: 0x00074BED File Offset: 0x00072DED
		[DebuggerNonUserCode]
		public uint OwnerGameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint ownerGameAccountIdDefaultValue;
				if (flag)
				{
					ownerGameAccountIdDefaultValue = this.ownerGameAccountId_;
				}
				else
				{
					ownerGameAccountIdDefaultValue = QuestReward.OwnerGameAccountIdDefaultValue;
				}
				return ownerGameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.ownerGameAccountId_ = value;
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06001E67 RID: 7783 RVA: 0x00074C08 File Offset: 0x00072E08
		[DebuggerNonUserCode]
		public bool HasOwnerGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001E68 RID: 7784 RVA: 0x00074C25 File Offset: 0x00072E25
		[DebuggerNonUserCode]
		public void ClearOwnerGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06001E69 RID: 7785 RVA: 0x00074C38 File Offset: 0x00072E38
		// (set) Token: 0x06001E6A RID: 7786 RVA: 0x00074C69 File Offset: 0x00072E69
		[DebuggerNonUserCode]
		public int SnoQuest
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int snoQuestDefaultValue;
				if (flag)
				{
					snoQuestDefaultValue = this.snoQuest_;
				}
				else
				{
					snoQuestDefaultValue = QuestReward.SnoQuestDefaultValue;
				}
				return snoQuestDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoQuest_ = value;
			}
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06001E6B RID: 7787 RVA: 0x00074C84 File Offset: 0x00072E84
		[DebuggerNonUserCode]
		public bool HasSnoQuest
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x00074CA1 File Offset: 0x00072EA1
		[DebuggerNonUserCode]
		public void ClearSnoQuest()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06001E6D RID: 7789 RVA: 0x00074CB4 File Offset: 0x00072EB4
		// (set) Token: 0x06001E6E RID: 7790 RVA: 0x00074CE5 File Offset: 0x00072EE5
		[DebuggerNonUserCode]
		public ulong XpGranted
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong xpGrantedDefaultValue;
				if (flag)
				{
					xpGrantedDefaultValue = this.xpGranted_;
				}
				else
				{
					xpGrantedDefaultValue = QuestReward.XpGrantedDefaultValue;
				}
				return xpGrantedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.xpGranted_ = value;
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06001E6F RID: 7791 RVA: 0x00074D00 File Offset: 0x00072F00
		[DebuggerNonUserCode]
		public bool HasXpGranted
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x00074D1D File Offset: 0x00072F1D
		[DebuggerNonUserCode]
		public void ClearXpGranted()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06001E71 RID: 7793 RVA: 0x00074D30 File Offset: 0x00072F30
		// (set) Token: 0x06001E72 RID: 7794 RVA: 0x00074D61 File Offset: 0x00072F61
		[DebuggerNonUserCode]
		public int GoldGranted
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int goldGrantedDefaultValue;
				if (flag)
				{
					goldGrantedDefaultValue = this.goldGranted_;
				}
				else
				{
					goldGrantedDefaultValue = QuestReward.GoldGrantedDefaultValue;
				}
				return goldGrantedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.goldGranted_ = value;
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06001E73 RID: 7795 RVA: 0x00074D7C File Offset: 0x00072F7C
		[DebuggerNonUserCode]
		public bool HasGoldGranted
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x00074D99 File Offset: 0x00072F99
		[DebuggerNonUserCode]
		public void ClearGoldGranted()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06001E75 RID: 7797 RVA: 0x00074DAC File Offset: 0x00072FAC
		[DebuggerNonUserCode]
		public RepeatedField<Generator> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06001E76 RID: 7798 RVA: 0x00074DC4 File Offset: 0x00072FC4
		// (set) Token: 0x06001E77 RID: 7799 RVA: 0x00074DF6 File Offset: 0x00072FF6
		[DebuggerNonUserCode]
		public ulong BonusXpGranted
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				ulong bonusXpGrantedDefaultValue;
				if (flag)
				{
					bonusXpGrantedDefaultValue = this.bonusXpGranted_;
				}
				else
				{
					bonusXpGrantedDefaultValue = QuestReward.BonusXpGrantedDefaultValue;
				}
				return bonusXpGrantedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.bonusXpGranted_ = value;
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06001E78 RID: 7800 RVA: 0x00074E10 File Offset: 0x00073010
		[DebuggerNonUserCode]
		public bool HasBonusXpGranted
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x00074E2E File Offset: 0x0007302E
		[DebuggerNonUserCode]
		public void ClearBonusXpGranted()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06001E7A RID: 7802 RVA: 0x00074E40 File Offset: 0x00073040
		[DebuggerNonUserCode]
		public RepeatedField<QuestReward.Types.CurrencyReward> CurrencyGranted
		{
			get
			{
				return this.currencyGranted_;
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06001E7B RID: 7803 RVA: 0x00074E58 File Offset: 0x00073058
		[DebuggerNonUserCode]
		public RepeatedField<ReputationReward> RepGranted
		{
			get
			{
				return this.repGranted_;
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06001E7C RID: 7804 RVA: 0x00074E70 File Offset: 0x00073070
		// (set) Token: 0x06001E7D RID: 7805 RVA: 0x00074EA2 File Offset: 0x000730A2
		[DebuggerNonUserCode]
		public int SnoTrackedRewardGranted
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				int snoTrackedRewardGrantedDefaultValue;
				if (flag)
				{
					snoTrackedRewardGrantedDefaultValue = this.snoTrackedRewardGranted_;
				}
				else
				{
					snoTrackedRewardGrantedDefaultValue = QuestReward.SnoTrackedRewardGrantedDefaultValue;
				}
				return snoTrackedRewardGrantedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.snoTrackedRewardGranted_ = value;
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06001E7E RID: 7806 RVA: 0x00074EBC File Offset: 0x000730BC
		[DebuggerNonUserCode]
		public bool HasSnoTrackedRewardGranted
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x00074EDA File Offset: 0x000730DA
		[DebuggerNonUserCode]
		public void ClearSnoTrackedRewardGranted()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x00074EEC File Offset: 0x000730EC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestReward);
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x00074F0C File Offset: 0x0007310C
		[DebuggerNonUserCode]
		public bool Equals(QuestReward other)
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
					bool flag4 = this.OwnerGameAccountId != other.OwnerGameAccountId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoQuest != other.SnoQuest;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.XpGranted != other.XpGranted;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.GoldGranted != other.GoldGranted;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.items_.Equals(other.items_);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.BonusXpGranted != other.BonusXpGranted;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !this.currencyGranted_.Equals(other.currencyGranted_);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !this.repGranted_.Equals(other.repGranted_);
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.SnoTrackedRewardGranted != other.SnoTrackedRewardGranted;
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

		// Token: 0x06001E82 RID: 7810 RVA: 0x00075058 File Offset: 0x00073258
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasOwnerGameAccountId = this.HasOwnerGameAccountId;
			if (hasOwnerGameAccountId)
			{
				num ^= this.OwnerGameAccountId.GetHashCode();
			}
			bool hasSnoQuest = this.HasSnoQuest;
			if (hasSnoQuest)
			{
				num ^= this.SnoQuest.GetHashCode();
			}
			bool hasXpGranted = this.HasXpGranted;
			if (hasXpGranted)
			{
				num ^= this.XpGranted.GetHashCode();
			}
			bool hasGoldGranted = this.HasGoldGranted;
			if (hasGoldGranted)
			{
				num ^= this.GoldGranted.GetHashCode();
			}
			num ^= this.items_.GetHashCode();
			bool hasBonusXpGranted = this.HasBonusXpGranted;
			if (hasBonusXpGranted)
			{
				num ^= this.BonusXpGranted.GetHashCode();
			}
			num ^= this.currencyGranted_.GetHashCode();
			num ^= this.repGranted_.GetHashCode();
			bool hasSnoTrackedRewardGranted = this.HasSnoTrackedRewardGranted;
			if (hasSnoTrackedRewardGranted)
			{
				num ^= this.SnoTrackedRewardGranted.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x00075168 File Offset: 0x00073368
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x00075180 File Offset: 0x00073380
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x0007518C File Offset: 0x0007338C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasOwnerGameAccountId = this.HasOwnerGameAccountId;
			if (hasOwnerGameAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.OwnerGameAccountId);
			}
			bool hasSnoQuest = this.HasSnoQuest;
			if (hasSnoQuest)
			{
				output.WriteRawTag(21);
				output.WriteSFixed32(this.SnoQuest);
			}
			bool hasXpGranted = this.HasXpGranted;
			if (hasXpGranted)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.XpGranted);
			}
			bool hasGoldGranted = this.HasGoldGranted;
			if (hasGoldGranted)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.GoldGranted);
			}
			this.items_.WriteTo(ref output, QuestReward._repeated_items_codec);
			bool hasBonusXpGranted = this.HasBonusXpGranted;
			if (hasBonusXpGranted)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(this.BonusXpGranted);
			}
			this.currencyGranted_.WriteTo(ref output, QuestReward._repeated_currencyGranted_codec);
			this.repGranted_.WriteTo(ref output, QuestReward._repeated_repGranted_codec);
			bool hasSnoTrackedRewardGranted = this.HasSnoTrackedRewardGranted;
			if (hasSnoTrackedRewardGranted)
			{
				output.WriteRawTag(77);
				output.WriteSFixed32(this.SnoTrackedRewardGranted);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x000752C0 File Offset: 0x000734C0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasOwnerGameAccountId = this.HasOwnerGameAccountId;
			if (hasOwnerGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OwnerGameAccountId);
			}
			bool hasSnoQuest = this.HasSnoQuest;
			if (hasSnoQuest)
			{
				num += 5;
			}
			bool hasXpGranted = this.HasXpGranted;
			if (hasXpGranted)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.XpGranted);
			}
			bool hasGoldGranted = this.HasGoldGranted;
			if (hasGoldGranted)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GoldGranted);
			}
			num += this.items_.CalculateSize(QuestReward._repeated_items_codec);
			bool hasBonusXpGranted = this.HasBonusXpGranted;
			if (hasBonusXpGranted)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.BonusXpGranted);
			}
			num += this.currencyGranted_.CalculateSize(QuestReward._repeated_currencyGranted_codec);
			num += this.repGranted_.CalculateSize(QuestReward._repeated_repGranted_codec);
			bool hasSnoTrackedRewardGranted = this.HasSnoTrackedRewardGranted;
			if (hasSnoTrackedRewardGranted)
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

		// Token: 0x06001E87 RID: 7815 RVA: 0x000753C8 File Offset: 0x000735C8
		[DebuggerNonUserCode]
		public void MergeFrom(QuestReward other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasOwnerGameAccountId = other.HasOwnerGameAccountId;
				if (hasOwnerGameAccountId)
				{
					this.OwnerGameAccountId = other.OwnerGameAccountId;
				}
				bool hasSnoQuest = other.HasSnoQuest;
				if (hasSnoQuest)
				{
					this.SnoQuest = other.SnoQuest;
				}
				bool hasXpGranted = other.HasXpGranted;
				if (hasXpGranted)
				{
					this.XpGranted = other.XpGranted;
				}
				bool hasGoldGranted = other.HasGoldGranted;
				if (hasGoldGranted)
				{
					this.GoldGranted = other.GoldGranted;
				}
				this.items_.Add(other.items_);
				bool hasBonusXpGranted = other.HasBonusXpGranted;
				if (hasBonusXpGranted)
				{
					this.BonusXpGranted = other.BonusXpGranted;
				}
				this.currencyGranted_.Add(other.currencyGranted_);
				this.repGranted_.Add(other.repGranted_);
				bool hasSnoTrackedRewardGranted = other.HasSnoTrackedRewardGranted;
				if (hasSnoTrackedRewardGranted)
				{
					this.SnoTrackedRewardGranted = other.SnoTrackedRewardGranted;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x000754CD File Offset: 0x000736CD
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x000754D8 File Offset: 0x000736D8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 32U)
				{
					if (num3 <= 21U)
					{
						if (num3 != 8U)
						{
							if (num3 != 21U)
							{
								goto IL_006A;
							}
							this.SnoQuest = input.ReadSFixed32();
						}
						else
						{
							this.OwnerGameAccountId = input.ReadUInt32();
						}
					}
					else if (num3 != 24U)
					{
						if (num3 != 32U)
						{
							goto IL_006A;
						}
						this.GoldGranted = input.ReadInt32();
					}
					else
					{
						this.XpGranted = input.ReadUInt64();
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
						this.BonusXpGranted = input.ReadUInt64();
					}
					else
					{
						this.items_.AddEntriesFrom(ref input, QuestReward._repeated_items_codec);
					}
				}
				else if (num3 != 58U)
				{
					if (num3 != 66U)
					{
						if (num3 != 77U)
						{
							goto IL_006A;
						}
						this.SnoTrackedRewardGranted = input.ReadSFixed32();
					}
					else
					{
						this.repGranted_.AddEntriesFrom(ref input, QuestReward._repeated_repGranted_codec);
					}
				}
				else
				{
					this.currencyGranted_.AddEntriesFrom(ref input, QuestReward._repeated_currencyGranted_codec);
				}
				continue;
				IL_006A:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000D11 RID: 3345
		private static readonly MessageParser<QuestReward> _parser = new MessageParser<QuestReward>(() => new QuestReward());

		// Token: 0x04000D12 RID: 3346
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D13 RID: 3347
		private int _hasBits0;

		// Token: 0x04000D14 RID: 3348
		public const int OwnerGameAccountIdFieldNumber = 1;

		// Token: 0x04000D15 RID: 3349
		private static readonly uint OwnerGameAccountIdDefaultValue = 0U;

		// Token: 0x04000D16 RID: 3350
		private uint ownerGameAccountId_;

		// Token: 0x04000D17 RID: 3351
		public const int SnoQuestFieldNumber = 2;

		// Token: 0x04000D18 RID: 3352
		private static readonly int SnoQuestDefaultValue = -1;

		// Token: 0x04000D19 RID: 3353
		private int snoQuest_;

		// Token: 0x04000D1A RID: 3354
		public const int XpGrantedFieldNumber = 3;

		// Token: 0x04000D1B RID: 3355
		private static readonly ulong XpGrantedDefaultValue = 0UL;

		// Token: 0x04000D1C RID: 3356
		private ulong xpGranted_;

		// Token: 0x04000D1D RID: 3357
		public const int GoldGrantedFieldNumber = 4;

		// Token: 0x04000D1E RID: 3358
		private static readonly int GoldGrantedDefaultValue = 0;

		// Token: 0x04000D1F RID: 3359
		private int goldGranted_;

		// Token: 0x04000D20 RID: 3360
		public const int ItemsFieldNumber = 5;

		// Token: 0x04000D21 RID: 3361
		private static readonly FieldCodec<Generator> _repeated_items_codec = FieldCodec.ForMessage<Generator>(42U, Generator.Parser);

		// Token: 0x04000D22 RID: 3362
		private readonly RepeatedField<Generator> items_ = new RepeatedField<Generator>();

		// Token: 0x04000D23 RID: 3363
		public const int BonusXpGrantedFieldNumber = 6;

		// Token: 0x04000D24 RID: 3364
		private static readonly ulong BonusXpGrantedDefaultValue = 0UL;

		// Token: 0x04000D25 RID: 3365
		private ulong bonusXpGranted_;

		// Token: 0x04000D26 RID: 3366
		public const int CurrencyGrantedFieldNumber = 7;

		// Token: 0x04000D27 RID: 3367
		private static readonly FieldCodec<QuestReward.Types.CurrencyReward> _repeated_currencyGranted_codec = FieldCodec.ForMessage<QuestReward.Types.CurrencyReward>(58U, QuestReward.Types.CurrencyReward.Parser);

		// Token: 0x04000D28 RID: 3368
		private readonly RepeatedField<QuestReward.Types.CurrencyReward> currencyGranted_ = new RepeatedField<QuestReward.Types.CurrencyReward>();

		// Token: 0x04000D29 RID: 3369
		public const int RepGrantedFieldNumber = 8;

		// Token: 0x04000D2A RID: 3370
		private static readonly FieldCodec<ReputationReward> _repeated_repGranted_codec = FieldCodec.ForMessage<ReputationReward>(66U, ReputationReward.Parser);

		// Token: 0x04000D2B RID: 3371
		private readonly RepeatedField<ReputationReward> repGranted_ = new RepeatedField<ReputationReward>();

		// Token: 0x04000D2C RID: 3372
		public const int SnoTrackedRewardGrantedFieldNumber = 9;

		// Token: 0x04000D2D RID: 3373
		private static readonly int SnoTrackedRewardGrantedDefaultValue = -1;

		// Token: 0x04000D2E RID: 3374
		private int snoTrackedRewardGranted_;

		// Token: 0x02000C4D RID: 3149
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x0200147E RID: 5246
			public sealed class CurrencyReward : IMessage<QuestReward.Types.CurrencyReward>, IMessage, IEquatable<QuestReward.Types.CurrencyReward>, IDeepCloneable<QuestReward.Types.CurrencyReward>, IBufferMessage
			{
				// Token: 0x17003AAF RID: 15023
				// (get) Token: 0x0600E667 RID: 58983 RVA: 0x004D7EB0 File Offset: 0x004D60B0
				[DebuggerNonUserCode]
				public static MessageParser<QuestReward.Types.CurrencyReward> Parser
				{
					get
					{
						return QuestReward.Types.CurrencyReward._parser;
					}
				}

				// Token: 0x17003AB0 RID: 15024
				// (get) Token: 0x0600E668 RID: 58984 RVA: 0x004D7EC8 File Offset: 0x004D60C8
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return QuestReward.Descriptor.NestedTypes[0];
					}
				}

				// Token: 0x17003AB1 RID: 15025
				// (get) Token: 0x0600E669 RID: 58985 RVA: 0x004D7EEC File Offset: 0x004D60EC
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return QuestReward.Types.CurrencyReward.Descriptor;
					}
				}

				// Token: 0x0600E66A RID: 58986 RVA: 0x004D7F03 File Offset: 0x004D6103
				[DebuggerNonUserCode]
				public CurrencyReward()
				{
				}

				// Token: 0x0600E66B RID: 58987 RVA: 0x004D7F0D File Offset: 0x004D610D
				[DebuggerNonUserCode]
				public CurrencyReward(QuestReward.Types.CurrencyReward other)
					: this()
				{
					this._hasBits0 = other._hasBits0;
					this.type_ = other.type_;
					this.amount_ = other.amount_;
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E66C RID: 58988 RVA: 0x004D7F4C File Offset: 0x004D614C
				[DebuggerNonUserCode]
				public QuestReward.Types.CurrencyReward Clone()
				{
					return new QuestReward.Types.CurrencyReward(this);
				}

				// Token: 0x17003AB2 RID: 15026
				// (get) Token: 0x0600E66D RID: 58989 RVA: 0x004D7F64 File Offset: 0x004D6164
				// (set) Token: 0x0600E66E RID: 58990 RVA: 0x004D7F95 File Offset: 0x004D6195
				[DebuggerNonUserCode]
				public int Type
				{
					get
					{
						bool flag = (this._hasBits0 & 1) != 0;
						int typeDefaultValue;
						if (flag)
						{
							typeDefaultValue = this.type_;
						}
						else
						{
							typeDefaultValue = QuestReward.Types.CurrencyReward.TypeDefaultValue;
						}
						return typeDefaultValue;
					}
					set
					{
						this._hasBits0 |= 1;
						this.type_ = value;
					}
				}

				// Token: 0x17003AB3 RID: 15027
				// (get) Token: 0x0600E66F RID: 58991 RVA: 0x004D7FB0 File Offset: 0x004D61B0
				[DebuggerNonUserCode]
				public bool HasType
				{
					get
					{
						return (this._hasBits0 & 1) != 0;
					}
				}

				// Token: 0x0600E670 RID: 58992 RVA: 0x004D7FCD File Offset: 0x004D61CD
				[DebuggerNonUserCode]
				public void ClearType()
				{
					this._hasBits0 &= -2;
				}

				// Token: 0x17003AB4 RID: 15028
				// (get) Token: 0x0600E671 RID: 58993 RVA: 0x004D7FE0 File Offset: 0x004D61E0
				// (set) Token: 0x0600E672 RID: 58994 RVA: 0x004D8011 File Offset: 0x004D6211
				[DebuggerNonUserCode]
				public int Amount
				{
					get
					{
						bool flag = (this._hasBits0 & 2) != 0;
						int amountDefaultValue;
						if (flag)
						{
							amountDefaultValue = this.amount_;
						}
						else
						{
							amountDefaultValue = QuestReward.Types.CurrencyReward.AmountDefaultValue;
						}
						return amountDefaultValue;
					}
					set
					{
						this._hasBits0 |= 2;
						this.amount_ = value;
					}
				}

				// Token: 0x17003AB5 RID: 15029
				// (get) Token: 0x0600E673 RID: 58995 RVA: 0x004D802C File Offset: 0x004D622C
				[DebuggerNonUserCode]
				public bool HasAmount
				{
					get
					{
						return (this._hasBits0 & 2) != 0;
					}
				}

				// Token: 0x0600E674 RID: 58996 RVA: 0x004D8049 File Offset: 0x004D6249
				[DebuggerNonUserCode]
				public void ClearAmount()
				{
					this._hasBits0 &= -3;
				}

				// Token: 0x0600E675 RID: 58997 RVA: 0x004D805C File Offset: 0x004D625C
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as QuestReward.Types.CurrencyReward);
				}

				// Token: 0x0600E676 RID: 58998 RVA: 0x004D807C File Offset: 0x004D627C
				[DebuggerNonUserCode]
				public bool Equals(QuestReward.Types.CurrencyReward other)
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
							bool flag4 = this.Type != other.Type;
							if (flag4)
							{
								flag2 = false;
							}
							else
							{
								bool flag5 = this.Amount != other.Amount;
								flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
					return flag2;
				}

				// Token: 0x0600E677 RID: 58999 RVA: 0x004D80F0 File Offset: 0x004D62F0
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					bool hasType = this.HasType;
					if (hasType)
					{
						num ^= this.Type.GetHashCode();
					}
					bool hasAmount = this.HasAmount;
					if (hasAmount)
					{
						num ^= this.Amount.GetHashCode();
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E678 RID: 59000 RVA: 0x004D815C File Offset: 0x004D635C
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E679 RID: 59001 RVA: 0x004D8174 File Offset: 0x004D6374
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E67A RID: 59002 RVA: 0x004D8180 File Offset: 0x004D6380
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					bool hasType = this.HasType;
					if (hasType)
					{
						output.WriteRawTag(8);
						output.WriteInt32(this.Type);
					}
					bool hasAmount = this.HasAmount;
					if (hasAmount)
					{
						output.WriteRawTag(16);
						output.WriteInt32(this.Amount);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E67B RID: 59003 RVA: 0x004D81F0 File Offset: 0x004D63F0
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					bool hasType = this.HasType;
					if (hasType)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
					}
					bool hasAmount = this.HasAmount;
					if (hasAmount)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(this.Amount);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E67C RID: 59004 RVA: 0x004D825C File Offset: 0x004D645C
				[DebuggerNonUserCode]
				public void MergeFrom(QuestReward.Types.CurrencyReward other)
				{
					bool flag = other == null;
					if (!flag)
					{
						bool hasType = other.HasType;
						if (hasType)
						{
							this.Type = other.Type;
						}
						bool hasAmount = other.HasAmount;
						if (hasAmount)
						{
							this.Amount = other.Amount;
						}
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E67D RID: 59005 RVA: 0x004D82BE File Offset: 0x004D64BE
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E67E RID: 59006 RVA: 0x004D82CC File Offset: 0x004D64CC
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
								this.Amount = input.ReadInt32();
							}
						}
						else
						{
							this.Type = input.ReadInt32();
						}
					}
				}

				// Token: 0x0400A3F0 RID: 41968
				private static readonly MessageParser<QuestReward.Types.CurrencyReward> _parser = new MessageParser<QuestReward.Types.CurrencyReward>(() => new QuestReward.Types.CurrencyReward());

				// Token: 0x0400A3F1 RID: 41969
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A3F2 RID: 41970
				private int _hasBits0;

				// Token: 0x0400A3F3 RID: 41971
				public const int TypeFieldNumber = 1;

				// Token: 0x0400A3F4 RID: 41972
				private static readonly int TypeDefaultValue = 0;

				// Token: 0x0400A3F5 RID: 41973
				private int type_;

				// Token: 0x0400A3F6 RID: 41974
				public const int AmountFieldNumber = 2;

				// Token: 0x0400A3F7 RID: 41975
				private static readonly int AmountDefaultValue = 0;

				// Token: 0x0400A3F8 RID: 41976
				private int amount_;
			}
		}
	}
}
