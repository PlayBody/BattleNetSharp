using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Game.V1
{
	// Token: 0x020002EA RID: 746
	public sealed class HeroCombatInfo : IMessage<HeroCombatInfo>, IMessage, IEquatable<HeroCombatInfo>, IDeepCloneable<HeroCombatInfo>, IBufferMessage
	{
		// Token: 0x170018F2 RID: 6386
		// (get) Token: 0x06004E89 RID: 20105 RVA: 0x0012CC2C File Offset: 0x0012AE2C
		[DebuggerNonUserCode]
		public static MessageParser<HeroCombatInfo> Parser
		{
			get
			{
				return HeroCombatInfo._parser;
			}
		}

		// Token: 0x170018F3 RID: 6387
		// (get) Token: 0x06004E8A RID: 20106 RVA: 0x0012CC44 File Offset: 0x0012AE44
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroCombatInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170018F4 RID: 6388
		// (get) Token: 0x06004E8B RID: 20107 RVA: 0x0012CC68 File Offset: 0x0012AE68
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeroCombatInfo.Descriptor;
			}
		}

		// Token: 0x06004E8C RID: 20108 RVA: 0x0012CC7F File Offset: 0x0012AE7F
		[DebuggerNonUserCode]
		public HeroCombatInfo()
		{
		}

		// Token: 0x06004E8D RID: 20109 RVA: 0x0012CCB8 File Offset: 0x0012AEB8
		[DebuggerNonUserCode]
		public HeroCombatInfo(HeroCombatInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.attackRating_ = other.attackRating_;
			this.defenseRating_ = other.defenseRating_;
			this.effectiveItemPower_ = other.effectiveItemPower_;
			this.totalItemPower_ = other.totalItemPower_;
			this.talent_ = other.talent_.Clone();
			this.skill_ = other.skill_.Clone();
			this.potionIsOnCooldown_ = other.potionIsOnCooldown_;
			this.enchant_ = other.enchant_.Clone();
			this.classPassiveSkill_ = other.classPassiveSkill_.Clone();
			this.potionCount_ = other.potionCount_;
			this.maxPotionCount_ = other.maxPotionCount_;
			this.potionTier_ = other.potionTier_;
			this.druidSpiritBond_ = other.druidSpiritBond_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004E8E RID: 20110 RVA: 0x0012CD9C File Offset: 0x0012AF9C
		[DebuggerNonUserCode]
		public HeroCombatInfo Clone()
		{
			return new HeroCombatInfo(this);
		}

		// Token: 0x170018F5 RID: 6389
		// (get) Token: 0x06004E8F RID: 20111 RVA: 0x0012CDB4 File Offset: 0x0012AFB4
		// (set) Token: 0x06004E90 RID: 20112 RVA: 0x0012CDE5 File Offset: 0x0012AFE5
		[DebuggerNonUserCode]
		public int AttackRating
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int attackRatingDefaultValue;
				if (flag)
				{
					attackRatingDefaultValue = this.attackRating_;
				}
				else
				{
					attackRatingDefaultValue = HeroCombatInfo.AttackRatingDefaultValue;
				}
				return attackRatingDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.attackRating_ = value;
			}
		}

		// Token: 0x170018F6 RID: 6390
		// (get) Token: 0x06004E91 RID: 20113 RVA: 0x0012CE00 File Offset: 0x0012B000
		[DebuggerNonUserCode]
		public bool HasAttackRating
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004E92 RID: 20114 RVA: 0x0012CE1D File Offset: 0x0012B01D
		[DebuggerNonUserCode]
		public void ClearAttackRating()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170018F7 RID: 6391
		// (get) Token: 0x06004E93 RID: 20115 RVA: 0x0012CE30 File Offset: 0x0012B030
		// (set) Token: 0x06004E94 RID: 20116 RVA: 0x0012CE61 File Offset: 0x0012B061
		[DebuggerNonUserCode]
		public int DefenseRating
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int defenseRatingDefaultValue;
				if (flag)
				{
					defenseRatingDefaultValue = this.defenseRating_;
				}
				else
				{
					defenseRatingDefaultValue = HeroCombatInfo.DefenseRatingDefaultValue;
				}
				return defenseRatingDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.defenseRating_ = value;
			}
		}

		// Token: 0x170018F8 RID: 6392
		// (get) Token: 0x06004E95 RID: 20117 RVA: 0x0012CE7C File Offset: 0x0012B07C
		[DebuggerNonUserCode]
		public bool HasDefenseRating
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004E96 RID: 20118 RVA: 0x0012CE99 File Offset: 0x0012B099
		[DebuggerNonUserCode]
		public void ClearDefenseRating()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170018F9 RID: 6393
		// (get) Token: 0x06004E97 RID: 20119 RVA: 0x0012CEAC File Offset: 0x0012B0AC
		// (set) Token: 0x06004E98 RID: 20120 RVA: 0x0012CEDD File Offset: 0x0012B0DD
		[DebuggerNonUserCode]
		public int EffectiveItemPower
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int effectiveItemPowerDefaultValue;
				if (flag)
				{
					effectiveItemPowerDefaultValue = this.effectiveItemPower_;
				}
				else
				{
					effectiveItemPowerDefaultValue = HeroCombatInfo.EffectiveItemPowerDefaultValue;
				}
				return effectiveItemPowerDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.effectiveItemPower_ = value;
			}
		}

		// Token: 0x170018FA RID: 6394
		// (get) Token: 0x06004E99 RID: 20121 RVA: 0x0012CEF8 File Offset: 0x0012B0F8
		[DebuggerNonUserCode]
		public bool HasEffectiveItemPower
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06004E9A RID: 20122 RVA: 0x0012CF15 File Offset: 0x0012B115
		[DebuggerNonUserCode]
		public void ClearEffectiveItemPower()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170018FB RID: 6395
		// (get) Token: 0x06004E9B RID: 20123 RVA: 0x0012CF28 File Offset: 0x0012B128
		// (set) Token: 0x06004E9C RID: 20124 RVA: 0x0012CF59 File Offset: 0x0012B159
		[DebuggerNonUserCode]
		public int TotalItemPower
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int totalItemPowerDefaultValue;
				if (flag)
				{
					totalItemPowerDefaultValue = this.totalItemPower_;
				}
				else
				{
					totalItemPowerDefaultValue = HeroCombatInfo.TotalItemPowerDefaultValue;
				}
				return totalItemPowerDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.totalItemPower_ = value;
			}
		}

		// Token: 0x170018FC RID: 6396
		// (get) Token: 0x06004E9D RID: 20125 RVA: 0x0012CF74 File Offset: 0x0012B174
		[DebuggerNonUserCode]
		public bool HasTotalItemPower
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06004E9E RID: 20126 RVA: 0x0012CF91 File Offset: 0x0012B191
		[DebuggerNonUserCode]
		public void ClearTotalItemPower()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x170018FD RID: 6397
		// (get) Token: 0x06004E9F RID: 20127 RVA: 0x0012CFA4 File Offset: 0x0012B1A4
		[DebuggerNonUserCode]
		public RepeatedField<HeroCombatInfo.Types.Power> Talent
		{
			get
			{
				return this.talent_;
			}
		}

		// Token: 0x170018FE RID: 6398
		// (get) Token: 0x06004EA0 RID: 20128 RVA: 0x0012CFBC File Offset: 0x0012B1BC
		[DebuggerNonUserCode]
		public RepeatedField<HeroCombatInfo.Types.Power> Skill
		{
			get
			{
				return this.skill_;
			}
		}

		// Token: 0x170018FF RID: 6399
		// (get) Token: 0x06004EA1 RID: 20129 RVA: 0x0012CFD4 File Offset: 0x0012B1D4
		// (set) Token: 0x06004EA2 RID: 20130 RVA: 0x0012D006 File Offset: 0x0012B206
		[DebuggerNonUserCode]
		public bool PotionIsOnCooldown
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool potionIsOnCooldownDefaultValue;
				if (flag)
				{
					potionIsOnCooldownDefaultValue = this.potionIsOnCooldown_;
				}
				else
				{
					potionIsOnCooldownDefaultValue = HeroCombatInfo.PotionIsOnCooldownDefaultValue;
				}
				return potionIsOnCooldownDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.potionIsOnCooldown_ = value;
			}
		}

		// Token: 0x17001900 RID: 6400
		// (get) Token: 0x06004EA3 RID: 20131 RVA: 0x0012D020 File Offset: 0x0012B220
		[DebuggerNonUserCode]
		public bool HasPotionIsOnCooldown
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06004EA4 RID: 20132 RVA: 0x0012D03E File Offset: 0x0012B23E
		[DebuggerNonUserCode]
		public void ClearPotionIsOnCooldown()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17001901 RID: 6401
		// (get) Token: 0x06004EA5 RID: 20133 RVA: 0x0012D050 File Offset: 0x0012B250
		[DebuggerNonUserCode]
		public RepeatedField<HeroCombatInfo.Types.Power> Enchant
		{
			get
			{
				return this.enchant_;
			}
		}

		// Token: 0x17001902 RID: 6402
		// (get) Token: 0x06004EA6 RID: 20134 RVA: 0x0012D068 File Offset: 0x0012B268
		[DebuggerNonUserCode]
		public RepeatedField<HeroCombatInfo.Types.Power> ClassPassiveSkill
		{
			get
			{
				return this.classPassiveSkill_;
			}
		}

		// Token: 0x17001903 RID: 6403
		// (get) Token: 0x06004EA7 RID: 20135 RVA: 0x0012D080 File Offset: 0x0012B280
		// (set) Token: 0x06004EA8 RID: 20136 RVA: 0x0012D0B2 File Offset: 0x0012B2B2
		[DebuggerNonUserCode]
		public int PotionCount
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				int potionCountDefaultValue;
				if (flag)
				{
					potionCountDefaultValue = this.potionCount_;
				}
				else
				{
					potionCountDefaultValue = HeroCombatInfo.PotionCountDefaultValue;
				}
				return potionCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.potionCount_ = value;
			}
		}

		// Token: 0x17001904 RID: 6404
		// (get) Token: 0x06004EA9 RID: 20137 RVA: 0x0012D0CC File Offset: 0x0012B2CC
		[DebuggerNonUserCode]
		public bool HasPotionCount
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06004EAA RID: 20138 RVA: 0x0012D0EA File Offset: 0x0012B2EA
		[DebuggerNonUserCode]
		public void ClearPotionCount()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17001905 RID: 6405
		// (get) Token: 0x06004EAB RID: 20139 RVA: 0x0012D0FC File Offset: 0x0012B2FC
		// (set) Token: 0x06004EAC RID: 20140 RVA: 0x0012D12E File Offset: 0x0012B32E
		[DebuggerNonUserCode]
		public int MaxPotionCount
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				int maxPotionCountDefaultValue;
				if (flag)
				{
					maxPotionCountDefaultValue = this.maxPotionCount_;
				}
				else
				{
					maxPotionCountDefaultValue = HeroCombatInfo.MaxPotionCountDefaultValue;
				}
				return maxPotionCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.maxPotionCount_ = value;
			}
		}

		// Token: 0x17001906 RID: 6406
		// (get) Token: 0x06004EAD RID: 20141 RVA: 0x0012D148 File Offset: 0x0012B348
		[DebuggerNonUserCode]
		public bool HasMaxPotionCount
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06004EAE RID: 20142 RVA: 0x0012D166 File Offset: 0x0012B366
		[DebuggerNonUserCode]
		public void ClearMaxPotionCount()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x17001907 RID: 6407
		// (get) Token: 0x06004EAF RID: 20143 RVA: 0x0012D178 File Offset: 0x0012B378
		// (set) Token: 0x06004EB0 RID: 20144 RVA: 0x0012D1AD File Offset: 0x0012B3AD
		[DebuggerNonUserCode]
		public int PotionTier
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				int potionTierDefaultValue;
				if (flag)
				{
					potionTierDefaultValue = this.potionTier_;
				}
				else
				{
					potionTierDefaultValue = HeroCombatInfo.PotionTierDefaultValue;
				}
				return potionTierDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.potionTier_ = value;
			}
		}

		// Token: 0x17001908 RID: 6408
		// (get) Token: 0x06004EB1 RID: 20145 RVA: 0x0012D1CC File Offset: 0x0012B3CC
		[DebuggerNonUserCode]
		public bool HasPotionTier
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x06004EB2 RID: 20146 RVA: 0x0012D1ED File Offset: 0x0012B3ED
		[DebuggerNonUserCode]
		public void ClearPotionTier()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x17001909 RID: 6409
		// (get) Token: 0x06004EB3 RID: 20147 RVA: 0x0012D204 File Offset: 0x0012B404
		// (set) Token: 0x06004EB4 RID: 20148 RVA: 0x0012D239 File Offset: 0x0012B439
		[DebuggerNonUserCode]
		public int DruidSpiritBond
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				int druidSpiritBondDefaultValue;
				if (flag)
				{
					druidSpiritBondDefaultValue = this.druidSpiritBond_;
				}
				else
				{
					druidSpiritBondDefaultValue = HeroCombatInfo.DruidSpiritBondDefaultValue;
				}
				return druidSpiritBondDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.druidSpiritBond_ = value;
			}
		}

		// Token: 0x1700190A RID: 6410
		// (get) Token: 0x06004EB5 RID: 20149 RVA: 0x0012D258 File Offset: 0x0012B458
		[DebuggerNonUserCode]
		public bool HasDruidSpiritBond
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x06004EB6 RID: 20150 RVA: 0x0012D279 File Offset: 0x0012B479
		[DebuggerNonUserCode]
		public void ClearDruidSpiritBond()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x06004EB7 RID: 20151 RVA: 0x0012D290 File Offset: 0x0012B490
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeroCombatInfo);
		}

		// Token: 0x06004EB8 RID: 20152 RVA: 0x0012D2B0 File Offset: 0x0012B4B0
		[DebuggerNonUserCode]
		public bool Equals(HeroCombatInfo other)
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
					bool flag4 = this.AttackRating != other.AttackRating;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.DefenseRating != other.DefenseRating;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.EffectiveItemPower != other.EffectiveItemPower;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.TotalItemPower != other.TotalItemPower;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.talent_.Equals(other.talent_);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !this.skill_.Equals(other.skill_);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.PotionIsOnCooldown != other.PotionIsOnCooldown;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !this.enchant_.Equals(other.enchant_);
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !this.classPassiveSkill_.Equals(other.classPassiveSkill_);
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.PotionCount != other.PotionCount;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.MaxPotionCount != other.MaxPotionCount;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.PotionTier != other.PotionTier;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = this.DruidSpiritBond != other.DruidSpiritBond;
																	flag2 = !flag16 && object.Equals(this._unknownFields, other._unknownFields);
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
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004EB9 RID: 20153 RVA: 0x0012D478 File Offset: 0x0012B678
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAttackRating = this.HasAttackRating;
			if (hasAttackRating)
			{
				num ^= this.AttackRating.GetHashCode();
			}
			bool hasDefenseRating = this.HasDefenseRating;
			if (hasDefenseRating)
			{
				num ^= this.DefenseRating.GetHashCode();
			}
			bool hasEffectiveItemPower = this.HasEffectiveItemPower;
			if (hasEffectiveItemPower)
			{
				num ^= this.EffectiveItemPower.GetHashCode();
			}
			bool hasTotalItemPower = this.HasTotalItemPower;
			if (hasTotalItemPower)
			{
				num ^= this.TotalItemPower.GetHashCode();
			}
			num ^= this.talent_.GetHashCode();
			num ^= this.skill_.GetHashCode();
			bool hasPotionIsOnCooldown = this.HasPotionIsOnCooldown;
			if (hasPotionIsOnCooldown)
			{
				num ^= this.PotionIsOnCooldown.GetHashCode();
			}
			num ^= this.enchant_.GetHashCode();
			num ^= this.classPassiveSkill_.GetHashCode();
			bool hasPotionCount = this.HasPotionCount;
			if (hasPotionCount)
			{
				num ^= this.PotionCount.GetHashCode();
			}
			bool hasMaxPotionCount = this.HasMaxPotionCount;
			if (hasMaxPotionCount)
			{
				num ^= this.MaxPotionCount.GetHashCode();
			}
			bool hasPotionTier = this.HasPotionTier;
			if (hasPotionTier)
			{
				num ^= this.PotionTier.GetHashCode();
			}
			bool hasDruidSpiritBond = this.HasDruidSpiritBond;
			if (hasDruidSpiritBond)
			{
				num ^= this.DruidSpiritBond.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004EBA RID: 20154 RVA: 0x0012D5E8 File Offset: 0x0012B7E8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004EBB RID: 20155 RVA: 0x0012D600 File Offset: 0x0012B800
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004EBC RID: 20156 RVA: 0x0012D60C File Offset: 0x0012B80C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAttackRating = this.HasAttackRating;
			if (hasAttackRating)
			{
				output.WriteRawTag(8);
				output.WriteSInt32(this.AttackRating);
			}
			bool hasDefenseRating = this.HasDefenseRating;
			if (hasDefenseRating)
			{
				output.WriteRawTag(16);
				output.WriteSInt32(this.DefenseRating);
			}
			bool hasEffectiveItemPower = this.HasEffectiveItemPower;
			if (hasEffectiveItemPower)
			{
				output.WriteRawTag(24);
				output.WriteSInt32(this.EffectiveItemPower);
			}
			bool hasTotalItemPower = this.HasTotalItemPower;
			if (hasTotalItemPower)
			{
				output.WriteRawTag(32);
				output.WriteSInt32(this.TotalItemPower);
			}
			this.talent_.WriteTo(ref output, HeroCombatInfo._repeated_talent_codec);
			this.skill_.WriteTo(ref output, HeroCombatInfo._repeated_skill_codec);
			bool hasPotionIsOnCooldown = this.HasPotionIsOnCooldown;
			if (hasPotionIsOnCooldown)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.PotionIsOnCooldown);
			}
			this.enchant_.WriteTo(ref output, HeroCombatInfo._repeated_enchant_codec);
			this.classPassiveSkill_.WriteTo(ref output, HeroCombatInfo._repeated_classPassiveSkill_codec);
			bool hasPotionCount = this.HasPotionCount;
			if (hasPotionCount)
			{
				output.WriteRawTag(80);
				output.WriteSInt32(this.PotionCount);
			}
			bool hasMaxPotionCount = this.HasMaxPotionCount;
			if (hasMaxPotionCount)
			{
				output.WriteRawTag(88);
				output.WriteSInt32(this.MaxPotionCount);
			}
			bool hasPotionTier = this.HasPotionTier;
			if (hasPotionTier)
			{
				output.WriteRawTag(96);
				output.WriteSInt32(this.PotionTier);
			}
			bool hasDruidSpiritBond = this.HasDruidSpiritBond;
			if (hasDruidSpiritBond)
			{
				output.WriteRawTag(104);
				output.WriteSInt32(this.DruidSpiritBond);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004EBD RID: 20157 RVA: 0x0012D7BC File Offset: 0x0012B9BC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAttackRating = this.HasAttackRating;
			if (hasAttackRating)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.AttackRating);
			}
			bool hasDefenseRating = this.HasDefenseRating;
			if (hasDefenseRating)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.DefenseRating);
			}
			bool hasEffectiveItemPower = this.HasEffectiveItemPower;
			if (hasEffectiveItemPower)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.EffectiveItemPower);
			}
			bool hasTotalItemPower = this.HasTotalItemPower;
			if (hasTotalItemPower)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.TotalItemPower);
			}
			num += this.talent_.CalculateSize(HeroCombatInfo._repeated_talent_codec);
			num += this.skill_.CalculateSize(HeroCombatInfo._repeated_skill_codec);
			bool hasPotionIsOnCooldown = this.HasPotionIsOnCooldown;
			if (hasPotionIsOnCooldown)
			{
				num += 2;
			}
			num += this.enchant_.CalculateSize(HeroCombatInfo._repeated_enchant_codec);
			num += this.classPassiveSkill_.CalculateSize(HeroCombatInfo._repeated_classPassiveSkill_codec);
			bool hasPotionCount = this.HasPotionCount;
			if (hasPotionCount)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.PotionCount);
			}
			bool hasMaxPotionCount = this.HasMaxPotionCount;
			if (hasMaxPotionCount)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.MaxPotionCount);
			}
			bool hasPotionTier = this.HasPotionTier;
			if (hasPotionTier)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.PotionTier);
			}
			bool hasDruidSpiritBond = this.HasDruidSpiritBond;
			if (hasDruidSpiritBond)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.DruidSpiritBond);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004EBE RID: 20158 RVA: 0x0012D93C File Offset: 0x0012BB3C
		[DebuggerNonUserCode]
		public void MergeFrom(HeroCombatInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAttackRating = other.HasAttackRating;
				if (hasAttackRating)
				{
					this.AttackRating = other.AttackRating;
				}
				bool hasDefenseRating = other.HasDefenseRating;
				if (hasDefenseRating)
				{
					this.DefenseRating = other.DefenseRating;
				}
				bool hasEffectiveItemPower = other.HasEffectiveItemPower;
				if (hasEffectiveItemPower)
				{
					this.EffectiveItemPower = other.EffectiveItemPower;
				}
				bool hasTotalItemPower = other.HasTotalItemPower;
				if (hasTotalItemPower)
				{
					this.TotalItemPower = other.TotalItemPower;
				}
				this.talent_.Add(other.talent_);
				this.skill_.Add(other.skill_);
				bool hasPotionIsOnCooldown = other.HasPotionIsOnCooldown;
				if (hasPotionIsOnCooldown)
				{
					this.PotionIsOnCooldown = other.PotionIsOnCooldown;
				}
				this.enchant_.Add(other.enchant_);
				this.classPassiveSkill_.Add(other.classPassiveSkill_);
				bool hasPotionCount = other.HasPotionCount;
				if (hasPotionCount)
				{
					this.PotionCount = other.PotionCount;
				}
				bool hasMaxPotionCount = other.HasMaxPotionCount;
				if (hasMaxPotionCount)
				{
					this.MaxPotionCount = other.MaxPotionCount;
				}
				bool hasPotionTier = other.HasPotionTier;
				if (hasPotionTier)
				{
					this.PotionTier = other.PotionTier;
				}
				bool hasDruidSpiritBond = other.HasDruidSpiritBond;
				if (hasDruidSpiritBond)
				{
					this.DruidSpiritBond = other.DruidSpiritBond;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004EBF RID: 20159 RVA: 0x0012DAA4 File Offset: 0x0012BCA4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004EC0 RID: 20160 RVA: 0x0012DAB0 File Offset: 0x0012BCB0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 50U)
				{
					if (num3 <= 24U)
					{
						if (num3 != 8U)
						{
							if (num3 != 16U)
							{
								if (num3 != 24U)
								{
									goto IL_00A0;
								}
								this.EffectiveItemPower = input.ReadSInt32();
							}
							else
							{
								this.DefenseRating = input.ReadSInt32();
							}
						}
						else
						{
							this.AttackRating = input.ReadSInt32();
						}
					}
					else if (num3 != 32U)
					{
						if (num3 != 42U)
						{
							if (num3 != 50U)
							{
								goto IL_00A0;
							}
							this.skill_.AddEntriesFrom(ref input, HeroCombatInfo._repeated_skill_codec);
						}
						else
						{
							this.talent_.AddEntriesFrom(ref input, HeroCombatInfo._repeated_talent_codec);
						}
					}
					else
					{
						this.TotalItemPower = input.ReadSInt32();
					}
				}
				else if (num3 <= 74U)
				{
					if (num3 != 56U)
					{
						if (num3 != 66U)
						{
							if (num3 != 74U)
							{
								goto IL_00A0;
							}
							this.classPassiveSkill_.AddEntriesFrom(ref input, HeroCombatInfo._repeated_classPassiveSkill_codec);
						}
						else
						{
							this.enchant_.AddEntriesFrom(ref input, HeroCombatInfo._repeated_enchant_codec);
						}
					}
					else
					{
						this.PotionIsOnCooldown = input.ReadBool();
					}
				}
				else if (num3 <= 88U)
				{
					if (num3 != 80U)
					{
						if (num3 != 88U)
						{
							goto IL_00A0;
						}
						this.MaxPotionCount = input.ReadSInt32();
					}
					else
					{
						this.PotionCount = input.ReadSInt32();
					}
				}
				else if (num3 != 96U)
				{
					if (num3 != 104U)
					{
						goto IL_00A0;
					}
					this.DruidSpiritBond = input.ReadSInt32();
				}
				else
				{
					this.PotionTier = input.ReadSInt32();
				}
				continue;
				IL_00A0:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002315 RID: 8981
		private static readonly MessageParser<HeroCombatInfo> _parser = new MessageParser<HeroCombatInfo>(() => new HeroCombatInfo());

		// Token: 0x04002316 RID: 8982
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002317 RID: 8983
		private int _hasBits0;

		// Token: 0x04002318 RID: 8984
		public const int AttackRatingFieldNumber = 1;

		// Token: 0x04002319 RID: 8985
		private static readonly int AttackRatingDefaultValue = 0;

		// Token: 0x0400231A RID: 8986
		private int attackRating_;

		// Token: 0x0400231B RID: 8987
		public const int DefenseRatingFieldNumber = 2;

		// Token: 0x0400231C RID: 8988
		private static readonly int DefenseRatingDefaultValue = 0;

		// Token: 0x0400231D RID: 8989
		private int defenseRating_;

		// Token: 0x0400231E RID: 8990
		public const int EffectiveItemPowerFieldNumber = 3;

		// Token: 0x0400231F RID: 8991
		private static readonly int EffectiveItemPowerDefaultValue = 0;

		// Token: 0x04002320 RID: 8992
		private int effectiveItemPower_;

		// Token: 0x04002321 RID: 8993
		public const int TotalItemPowerFieldNumber = 4;

		// Token: 0x04002322 RID: 8994
		private static readonly int TotalItemPowerDefaultValue = 0;

		// Token: 0x04002323 RID: 8995
		private int totalItemPower_;

		// Token: 0x04002324 RID: 8996
		public const int TalentFieldNumber = 5;

		// Token: 0x04002325 RID: 8997
		private static readonly FieldCodec<HeroCombatInfo.Types.Power> _repeated_talent_codec = FieldCodec.ForMessage<HeroCombatInfo.Types.Power>(42U, HeroCombatInfo.Types.Power.Parser);

		// Token: 0x04002326 RID: 8998
		private readonly RepeatedField<HeroCombatInfo.Types.Power> talent_ = new RepeatedField<HeroCombatInfo.Types.Power>();

		// Token: 0x04002327 RID: 8999
		public const int SkillFieldNumber = 6;

		// Token: 0x04002328 RID: 9000
		private static readonly FieldCodec<HeroCombatInfo.Types.Power> _repeated_skill_codec = FieldCodec.ForMessage<HeroCombatInfo.Types.Power>(50U, HeroCombatInfo.Types.Power.Parser);

		// Token: 0x04002329 RID: 9001
		private readonly RepeatedField<HeroCombatInfo.Types.Power> skill_ = new RepeatedField<HeroCombatInfo.Types.Power>();

		// Token: 0x0400232A RID: 9002
		public const int PotionIsOnCooldownFieldNumber = 7;

		// Token: 0x0400232B RID: 9003
		private static readonly bool PotionIsOnCooldownDefaultValue = false;

		// Token: 0x0400232C RID: 9004
		private bool potionIsOnCooldown_;

		// Token: 0x0400232D RID: 9005
		public const int EnchantFieldNumber = 8;

		// Token: 0x0400232E RID: 9006
		private static readonly FieldCodec<HeroCombatInfo.Types.Power> _repeated_enchant_codec = FieldCodec.ForMessage<HeroCombatInfo.Types.Power>(66U, HeroCombatInfo.Types.Power.Parser);

		// Token: 0x0400232F RID: 9007
		private readonly RepeatedField<HeroCombatInfo.Types.Power> enchant_ = new RepeatedField<HeroCombatInfo.Types.Power>();

		// Token: 0x04002330 RID: 9008
		public const int ClassPassiveSkillFieldNumber = 9;

		// Token: 0x04002331 RID: 9009
		private static readonly FieldCodec<HeroCombatInfo.Types.Power> _repeated_classPassiveSkill_codec = FieldCodec.ForMessage<HeroCombatInfo.Types.Power>(74U, HeroCombatInfo.Types.Power.Parser);

		// Token: 0x04002332 RID: 9010
		private readonly RepeatedField<HeroCombatInfo.Types.Power> classPassiveSkill_ = new RepeatedField<HeroCombatInfo.Types.Power>();

		// Token: 0x04002333 RID: 9011
		public const int PotionCountFieldNumber = 10;

		// Token: 0x04002334 RID: 9012
		private static readonly int PotionCountDefaultValue = 0;

		// Token: 0x04002335 RID: 9013
		private int potionCount_;

		// Token: 0x04002336 RID: 9014
		public const int MaxPotionCountFieldNumber = 11;

		// Token: 0x04002337 RID: 9015
		private static readonly int MaxPotionCountDefaultValue = 0;

		// Token: 0x04002338 RID: 9016
		private int maxPotionCount_;

		// Token: 0x04002339 RID: 9017
		public const int PotionTierFieldNumber = 12;

		// Token: 0x0400233A RID: 9018
		private static readonly int PotionTierDefaultValue = 0;

		// Token: 0x0400233B RID: 9019
		private int potionTier_;

		// Token: 0x0400233C RID: 9020
		public const int DruidSpiritBondFieldNumber = 13;

		// Token: 0x0400233D RID: 9021
		private static readonly int DruidSpiritBondDefaultValue = 0;

		// Token: 0x0400233E RID: 9022
		private int druidSpiritBond_;

		// Token: 0x02000DF8 RID: 3576
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02001489 RID: 5257
			public enum PowerType
			{
				// Token: 0x0400A471 RID: 42097
				[OriginalName("POWER_TYPE_SKILL")]
				Skill,
				// Token: 0x0400A472 RID: 42098
				[OriginalName("POWER_TYPE_TALENT")]
				Talent,
				// Token: 0x0400A473 RID: 42099
				[OriginalName("POWER_TYPE_ENCHANT")]
				Enchant,
				// Token: 0x0400A474 RID: 42100
				[OriginalName("POWER_TYPE_CLASS_PASSIVE_SKILL_MINOR")]
				ClassPassiveSkillMinor,
				// Token: 0x0400A475 RID: 42101
				[OriginalName("POWER_TYPE_CLASS_PASSIVE_SKILL_MAJOR")]
				ClassPassiveSkillMajor,
				// Token: 0x0400A476 RID: 42102
				[OriginalName("POWER_TYPE_CLASS_PASSIVE_SKILL")]
				ClassPassiveSkill,
				// Token: 0x0400A477 RID: 42103
				[OriginalName("POWER_TYPE_ROGUE_SPECIALIZATION")]
				RogueSpecialization,
				// Token: 0x0400A478 RID: 42104
				[OriginalName("POWER_TYPE_WEAPON_EXPERTISE")]
				WeaponExpertise,
				// Token: 0x0400A479 RID: 42105
				[OriginalName("POWER_TYPE_NECROMANCER_SPECIALIZATION")]
				NecromancerSpecialization
			}

			// Token: 0x0200148A RID: 5258
			public sealed class Power : IMessage<HeroCombatInfo.Types.Power>, IMessage, IEquatable<HeroCombatInfo.Types.Power>, IDeepCloneable<HeroCombatInfo.Types.Power>, IBufferMessage
			{
				// Token: 0x17003AF8 RID: 15096
				// (get) Token: 0x0600E74E RID: 59214 RVA: 0x004DB0B0 File Offset: 0x004D92B0
				[DebuggerNonUserCode]
				public static MessageParser<HeroCombatInfo.Types.Power> Parser
				{
					get
					{
						return HeroCombatInfo.Types.Power._parser;
					}
				}

				// Token: 0x17003AF9 RID: 15097
				// (get) Token: 0x0600E74F RID: 59215 RVA: 0x004DB0C8 File Offset: 0x004D92C8
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return HeroCombatInfo.Descriptor.NestedTypes[0];
					}
				}

				// Token: 0x17003AFA RID: 15098
				// (get) Token: 0x0600E750 RID: 59216 RVA: 0x004DB0EC File Offset: 0x004D92EC
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return HeroCombatInfo.Types.Power.Descriptor;
					}
				}

				// Token: 0x0600E751 RID: 59217 RVA: 0x004DB103 File Offset: 0x004D9303
				[DebuggerNonUserCode]
				public Power()
				{
				}

				// Token: 0x0600E752 RID: 59218 RVA: 0x004DB110 File Offset: 0x004D9310
				[DebuggerNonUserCode]
				public Power(HeroCombatInfo.Types.Power other)
					: this()
				{
					this._hasBits0 = other._hasBits0;
					this.powerSno_ = other.powerSno_;
					this.powerRanks_ = other.powerRanks_;
					this.type_ = other.type_;
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E753 RID: 59219 RVA: 0x004DB168 File Offset: 0x004D9368
				[DebuggerNonUserCode]
				public HeroCombatInfo.Types.Power Clone()
				{
					return new HeroCombatInfo.Types.Power(this);
				}

				// Token: 0x17003AFB RID: 15099
				// (get) Token: 0x0600E754 RID: 59220 RVA: 0x004DB180 File Offset: 0x004D9380
				// (set) Token: 0x0600E755 RID: 59221 RVA: 0x004DB1B1 File Offset: 0x004D93B1
				[DebuggerNonUserCode]
				public int PowerSno
				{
					get
					{
						bool flag = (this._hasBits0 & 1) != 0;
						int powerSnoDefaultValue;
						if (flag)
						{
							powerSnoDefaultValue = this.powerSno_;
						}
						else
						{
							powerSnoDefaultValue = HeroCombatInfo.Types.Power.PowerSnoDefaultValue;
						}
						return powerSnoDefaultValue;
					}
					set
					{
						this._hasBits0 |= 1;
						this.powerSno_ = value;
					}
				}

				// Token: 0x17003AFC RID: 15100
				// (get) Token: 0x0600E756 RID: 59222 RVA: 0x004DB1CC File Offset: 0x004D93CC
				[DebuggerNonUserCode]
				public bool HasPowerSno
				{
					get
					{
						return (this._hasBits0 & 1) != 0;
					}
				}

				// Token: 0x0600E757 RID: 59223 RVA: 0x004DB1E9 File Offset: 0x004D93E9
				[DebuggerNonUserCode]
				public void ClearPowerSno()
				{
					this._hasBits0 &= -2;
				}

				// Token: 0x17003AFD RID: 15101
				// (get) Token: 0x0600E758 RID: 59224 RVA: 0x004DB1FC File Offset: 0x004D93FC
				// (set) Token: 0x0600E759 RID: 59225 RVA: 0x004DB22D File Offset: 0x004D942D
				[DebuggerNonUserCode]
				public uint PowerRanks
				{
					get
					{
						bool flag = (this._hasBits0 & 2) != 0;
						uint powerRanksDefaultValue;
						if (flag)
						{
							powerRanksDefaultValue = this.powerRanks_;
						}
						else
						{
							powerRanksDefaultValue = HeroCombatInfo.Types.Power.PowerRanksDefaultValue;
						}
						return powerRanksDefaultValue;
					}
					set
					{
						this._hasBits0 |= 2;
						this.powerRanks_ = value;
					}
				}

				// Token: 0x17003AFE RID: 15102
				// (get) Token: 0x0600E75A RID: 59226 RVA: 0x004DB248 File Offset: 0x004D9448
				[DebuggerNonUserCode]
				public bool HasPowerRanks
				{
					get
					{
						return (this._hasBits0 & 2) != 0;
					}
				}

				// Token: 0x0600E75B RID: 59227 RVA: 0x004DB265 File Offset: 0x004D9465
				[DebuggerNonUserCode]
				public void ClearPowerRanks()
				{
					this._hasBits0 &= -3;
				}

				// Token: 0x17003AFF RID: 15103
				// (get) Token: 0x0600E75C RID: 59228 RVA: 0x004DB278 File Offset: 0x004D9478
				// (set) Token: 0x0600E75D RID: 59229 RVA: 0x004DB2A9 File Offset: 0x004D94A9
				[DebuggerNonUserCode]
				public HeroCombatInfo.Types.PowerType Type
				{
					get
					{
						bool flag = (this._hasBits0 & 4) != 0;
						HeroCombatInfo.Types.PowerType typeDefaultValue;
						if (flag)
						{
							typeDefaultValue = this.type_;
						}
						else
						{
							typeDefaultValue = HeroCombatInfo.Types.Power.TypeDefaultValue;
						}
						return typeDefaultValue;
					}
					set
					{
						this._hasBits0 |= 4;
						this.type_ = value;
					}
				}

				// Token: 0x17003B00 RID: 15104
				// (get) Token: 0x0600E75E RID: 59230 RVA: 0x004DB2C4 File Offset: 0x004D94C4
				[DebuggerNonUserCode]
				public bool HasType
				{
					get
					{
						return (this._hasBits0 & 4) != 0;
					}
				}

				// Token: 0x0600E75F RID: 59231 RVA: 0x004DB2E1 File Offset: 0x004D94E1
				[DebuggerNonUserCode]
				public void ClearType()
				{
					this._hasBits0 &= -5;
				}

				// Token: 0x0600E760 RID: 59232 RVA: 0x004DB2F4 File Offset: 0x004D94F4
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as HeroCombatInfo.Types.Power);
				}

				// Token: 0x0600E761 RID: 59233 RVA: 0x004DB314 File Offset: 0x004D9514
				[DebuggerNonUserCode]
				public bool Equals(HeroCombatInfo.Types.Power other)
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
							bool flag4 = this.PowerSno != other.PowerSno;
							if (flag4)
							{
								flag2 = false;
							}
							else
							{
								bool flag5 = this.PowerRanks != other.PowerRanks;
								if (flag5)
								{
									flag2 = false;
								}
								else
								{
									bool flag6 = this.Type != other.Type;
									flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
					return flag2;
				}

				// Token: 0x0600E762 RID: 59234 RVA: 0x004DB3A0 File Offset: 0x004D95A0
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					bool hasPowerSno = this.HasPowerSno;
					if (hasPowerSno)
					{
						num ^= this.PowerSno.GetHashCode();
					}
					bool hasPowerRanks = this.HasPowerRanks;
					if (hasPowerRanks)
					{
						num ^= this.PowerRanks.GetHashCode();
					}
					bool hasType = this.HasType;
					if (hasType)
					{
						num ^= this.Type.GetHashCode();
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E763 RID: 59235 RVA: 0x004DB434 File Offset: 0x004D9634
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E764 RID: 59236 RVA: 0x004DB44C File Offset: 0x004D964C
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E765 RID: 59237 RVA: 0x004DB458 File Offset: 0x004D9658
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					bool hasPowerSno = this.HasPowerSno;
					if (hasPowerSno)
					{
						output.WriteRawTag(8);
						output.WriteSInt32(this.PowerSno);
					}
					bool hasPowerRanks = this.HasPowerRanks;
					if (hasPowerRanks)
					{
						output.WriteRawTag(24);
						output.WriteUInt32(this.PowerRanks);
					}
					bool hasType = this.HasType;
					if (hasType)
					{
						output.WriteRawTag(32);
						output.WriteEnum((int)this.Type);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E766 RID: 59238 RVA: 0x004DB4E8 File Offset: 0x004D96E8
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					bool hasPowerSno = this.HasPowerSno;
					if (hasPowerSno)
					{
						num += 1 + CodedOutputStream.ComputeSInt32Size(this.PowerSno);
					}
					bool hasPowerRanks = this.HasPowerRanks;
					if (hasPowerRanks)
					{
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.PowerRanks);
					}
					bool hasType = this.HasType;
					if (hasType)
					{
						num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E767 RID: 59239 RVA: 0x004DB574 File Offset: 0x004D9774
				[DebuggerNonUserCode]
				public void MergeFrom(HeroCombatInfo.Types.Power other)
				{
					bool flag = other == null;
					if (!flag)
					{
						bool hasPowerSno = other.HasPowerSno;
						if (hasPowerSno)
						{
							this.PowerSno = other.PowerSno;
						}
						bool hasPowerRanks = other.HasPowerRanks;
						if (hasPowerRanks)
						{
							this.PowerRanks = other.PowerRanks;
						}
						bool hasType = other.HasType;
						if (hasType)
						{
							this.Type = other.Type;
						}
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E768 RID: 59240 RVA: 0x004DB5EF File Offset: 0x004D97EF
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E769 RID: 59241 RVA: 0x004DB5FC File Offset: 0x004D97FC
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
							if (num3 != 24U)
							{
								if (num3 != 32U)
								{
									this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
								}
								else
								{
									this.Type = (HeroCombatInfo.Types.PowerType)input.ReadEnum();
								}
							}
							else
							{
								this.PowerRanks = input.ReadUInt32();
							}
						}
						else
						{
							this.PowerSno = input.ReadSInt32();
						}
					}
				}

				// Token: 0x0400A47A RID: 42106
				private static readonly MessageParser<HeroCombatInfo.Types.Power> _parser = new MessageParser<HeroCombatInfo.Types.Power>(() => new HeroCombatInfo.Types.Power());

				// Token: 0x0400A47B RID: 42107
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A47C RID: 42108
				private int _hasBits0;

				// Token: 0x0400A47D RID: 42109
				public const int PowerSnoFieldNumber = 1;

				// Token: 0x0400A47E RID: 42110
				private static readonly int PowerSnoDefaultValue = 0;

				// Token: 0x0400A47F RID: 42111
				private int powerSno_;

				// Token: 0x0400A480 RID: 42112
				public const int PowerRanksFieldNumber = 3;

				// Token: 0x0400A481 RID: 42113
				private static readonly uint PowerRanksDefaultValue = 0U;

				// Token: 0x0400A482 RID: 42114
				private uint powerRanks_;

				// Token: 0x0400A483 RID: 42115
				public const int TypeFieldNumber = 4;

				// Token: 0x0400A484 RID: 42116
				private static readonly HeroCombatInfo.Types.PowerType TypeDefaultValue = HeroCombatInfo.Types.PowerType.Skill;

				// Token: 0x0400A485 RID: 42117
				private HeroCombatInfo.Types.PowerType type_;
			}
		}
	}
}
