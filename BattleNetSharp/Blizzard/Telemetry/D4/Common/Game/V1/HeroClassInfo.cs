using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.D4.Common.Game.V1
{
	// Token: 0x020002E6 RID: 742
	public sealed class HeroClassInfo : IMessage<HeroClassInfo>, IMessage, IEquatable<HeroClassInfo>, IDeepCloneable<HeroClassInfo>, IBufferMessage
	{
		// Token: 0x170018CF RID: 6351
		// (get) Token: 0x06004E32 RID: 20018 RVA: 0x0012B224 File Offset: 0x00129424
		[DebuggerNonUserCode]
		public static MessageParser<HeroClassInfo> Parser
		{
			get
			{
				return HeroClassInfo._parser;
			}
		}

		// Token: 0x170018D0 RID: 6352
		// (get) Token: 0x06004E33 RID: 20019 RVA: 0x0012B23C File Offset: 0x0012943C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroClassInfoV1Reflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170018D1 RID: 6353
		// (get) Token: 0x06004E34 RID: 20020 RVA: 0x0012B260 File Offset: 0x00129460
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeroClassInfo.Descriptor;
			}
		}

		// Token: 0x06004E35 RID: 20021 RVA: 0x0012B277 File Offset: 0x00129477
		[DebuggerNonUserCode]
		public HeroClassInfo()
		{
		}

		// Token: 0x06004E36 RID: 20022 RVA: 0x0012B2B0 File Offset: 0x001294B0
		[DebuggerNonUserCode]
		public HeroClassInfo(HeroClassInfo other)
			: this()
		{
			this.equippedSkill_ = other.equippedSkill_.Clone();
			this.skillTreeTalent_ = other.skillTreeTalent_.Clone();
			this.skillTreeSkillMod_ = other.skillTreeSkillMod_.Clone();
			this.classPassive_ = other.classPassive_.Clone();
			this.stats_ = ((other.stats_ != null) ? other.stats_.Clone() : null);
			this.paragon_ = ((other.paragon_ != null) ? other.paragon_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004E37 RID: 20023 RVA: 0x0012B354 File Offset: 0x00129554
		[DebuggerNonUserCode]
		public HeroClassInfo Clone()
		{
			return new HeroClassInfo(this);
		}

		// Token: 0x170018D2 RID: 6354
		// (get) Token: 0x06004E38 RID: 20024 RVA: 0x0012B36C File Offset: 0x0012956C
		[DebuggerNonUserCode]
		public RepeatedField<HeroClassInfo.Types.Power> EquippedSkill
		{
			get
			{
				return this.equippedSkill_;
			}
		}

		// Token: 0x170018D3 RID: 6355
		// (get) Token: 0x06004E39 RID: 20025 RVA: 0x0012B384 File Offset: 0x00129584
		[DebuggerNonUserCode]
		public RepeatedField<HeroClassInfo.Types.Power> SkillTreeTalent
		{
			get
			{
				return this.skillTreeTalent_;
			}
		}

		// Token: 0x170018D4 RID: 6356
		// (get) Token: 0x06004E3A RID: 20026 RVA: 0x0012B39C File Offset: 0x0012959C
		[DebuggerNonUserCode]
		public RepeatedField<HeroClassInfo.Types.Power> SkillTreeSkillMod
		{
			get
			{
				return this.skillTreeSkillMod_;
			}
		}

		// Token: 0x170018D5 RID: 6357
		// (get) Token: 0x06004E3B RID: 20027 RVA: 0x0012B3B4 File Offset: 0x001295B4
		[DebuggerNonUserCode]
		public RepeatedField<HeroClassInfo.Types.Power> ClassPassive
		{
			get
			{
				return this.classPassive_;
			}
		}

		// Token: 0x170018D6 RID: 6358
		// (get) Token: 0x06004E3C RID: 20028 RVA: 0x0012B3CC File Offset: 0x001295CC
		// (set) Token: 0x06004E3D RID: 20029 RVA: 0x0012B3E4 File Offset: 0x001295E4
		[DebuggerNonUserCode]
		public HeroClassInfo.Types.Stats Stats
		{
			get
			{
				return this.stats_;
			}
			set
			{
				this.stats_ = value;
			}
		}

		// Token: 0x170018D7 RID: 6359
		// (get) Token: 0x06004E3E RID: 20030 RVA: 0x0012B3F0 File Offset: 0x001295F0
		// (set) Token: 0x06004E3F RID: 20031 RVA: 0x0012B408 File Offset: 0x00129608
		[DebuggerNonUserCode]
		public HeroClassInfo.Types.Paragon Paragon
		{
			get
			{
				return this.paragon_;
			}
			set
			{
				this.paragon_ = value;
			}
		}

		// Token: 0x06004E40 RID: 20032 RVA: 0x0012B414 File Offset: 0x00129614
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeroClassInfo);
		}

		// Token: 0x06004E41 RID: 20033 RVA: 0x0012B434 File Offset: 0x00129634
		[DebuggerNonUserCode]
		public bool Equals(HeroClassInfo other)
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
					bool flag4 = !this.equippedSkill_.Equals(other.equippedSkill_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.skillTreeTalent_.Equals(other.skillTreeTalent_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.skillTreeSkillMod_.Equals(other.skillTreeSkillMod_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.classPassive_.Equals(other.classPassive_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.Stats, other.Stats);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !object.Equals(this.Paragon, other.Paragon);
										flag2 = !flag9 && object.Equals(this._unknownFields, other._unknownFields);
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004E42 RID: 20034 RVA: 0x0012B530 File Offset: 0x00129730
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.equippedSkill_.GetHashCode();
			num ^= this.skillTreeTalent_.GetHashCode();
			num ^= this.skillTreeSkillMod_.GetHashCode();
			num ^= this.classPassive_.GetHashCode();
			bool flag = this.stats_ != null;
			if (flag)
			{
				num ^= this.Stats.GetHashCode();
			}
			bool flag2 = this.paragon_ != null;
			if (flag2)
			{
				num ^= this.Paragon.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004E43 RID: 20035 RVA: 0x0012B5D4 File Offset: 0x001297D4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004E44 RID: 20036 RVA: 0x0012B5EC File Offset: 0x001297EC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004E45 RID: 20037 RVA: 0x0012B5F8 File Offset: 0x001297F8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.equippedSkill_.WriteTo(ref output, HeroClassInfo._repeated_equippedSkill_codec);
			this.skillTreeTalent_.WriteTo(ref output, HeroClassInfo._repeated_skillTreeTalent_codec);
			this.skillTreeSkillMod_.WriteTo(ref output, HeroClassInfo._repeated_skillTreeSkillMod_codec);
			this.classPassive_.WriteTo(ref output, HeroClassInfo._repeated_classPassive_codec);
			bool flag = this.stats_ != null;
			if (flag)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Stats);
			}
			bool flag2 = this.paragon_ != null;
			if (flag2)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Paragon);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004E46 RID: 20038 RVA: 0x0012B6B4 File Offset: 0x001298B4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.equippedSkill_.CalculateSize(HeroClassInfo._repeated_equippedSkill_codec);
			num += this.skillTreeTalent_.CalculateSize(HeroClassInfo._repeated_skillTreeTalent_codec);
			num += this.skillTreeSkillMod_.CalculateSize(HeroClassInfo._repeated_skillTreeSkillMod_codec);
			num += this.classPassive_.CalculateSize(HeroClassInfo._repeated_classPassive_codec);
			bool flag = this.stats_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Stats);
			}
			bool flag2 = this.paragon_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Paragon);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004E47 RID: 20039 RVA: 0x0012B774 File Offset: 0x00129974
		[DebuggerNonUserCode]
		public void MergeFrom(HeroClassInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.equippedSkill_.Add(other.equippedSkill_);
				this.skillTreeTalent_.Add(other.skillTreeTalent_);
				this.skillTreeSkillMod_.Add(other.skillTreeSkillMod_);
				this.classPassive_.Add(other.classPassive_);
				bool flag2 = other.stats_ != null;
				if (flag2)
				{
					bool flag3 = this.stats_ == null;
					if (flag3)
					{
						this.Stats = new HeroClassInfo.Types.Stats();
					}
					this.Stats.MergeFrom(other.Stats);
				}
				bool flag4 = other.paragon_ != null;
				if (flag4)
				{
					bool flag5 = this.paragon_ == null;
					if (flag5)
					{
						this.Paragon = new HeroClassInfo.Types.Paragon();
					}
					this.Paragon.MergeFrom(other.Paragon);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004E48 RID: 20040 RVA: 0x0012B869 File Offset: 0x00129A69
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004E49 RID: 20041 RVA: 0x0012B874 File Offset: 0x00129A74
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 26U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							if (num3 != 26U)
							{
								goto IL_003D;
							}
							this.skillTreeSkillMod_.AddEntriesFrom(ref input, HeroClassInfo._repeated_skillTreeSkillMod_codec);
						}
						else
						{
							this.skillTreeTalent_.AddEntriesFrom(ref input, HeroClassInfo._repeated_skillTreeTalent_codec);
						}
					}
					else
					{
						this.equippedSkill_.AddEntriesFrom(ref input, HeroClassInfo._repeated_equippedSkill_codec);
					}
				}
				else if (num3 != 34U)
				{
					if (num3 != 42U)
					{
						if (num3 != 50U)
						{
							goto IL_003D;
						}
						bool flag = this.paragon_ == null;
						if (flag)
						{
							this.Paragon = new HeroClassInfo.Types.Paragon();
						}
						input.ReadMessage(this.Paragon);
					}
					else
					{
						bool flag2 = this.stats_ == null;
						if (flag2)
						{
							this.Stats = new HeroClassInfo.Types.Stats();
						}
						input.ReadMessage(this.Stats);
					}
				}
				else
				{
					this.classPassive_.AddEntriesFrom(ref input, HeroClassInfo._repeated_classPassive_codec);
				}
				continue;
				IL_003D:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040022DD RID: 8925
		private static readonly MessageParser<HeroClassInfo> _parser = new MessageParser<HeroClassInfo>(() => new HeroClassInfo());

		// Token: 0x040022DE RID: 8926
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022DF RID: 8927
		public const int EquippedSkillFieldNumber = 1;

		// Token: 0x040022E0 RID: 8928
		private static readonly FieldCodec<HeroClassInfo.Types.Power> _repeated_equippedSkill_codec = FieldCodec.ForMessage<HeroClassInfo.Types.Power>(10U, HeroClassInfo.Types.Power.Parser);

		// Token: 0x040022E1 RID: 8929
		private readonly RepeatedField<HeroClassInfo.Types.Power> equippedSkill_ = new RepeatedField<HeroClassInfo.Types.Power>();

		// Token: 0x040022E2 RID: 8930
		public const int SkillTreeTalentFieldNumber = 2;

		// Token: 0x040022E3 RID: 8931
		private static readonly FieldCodec<HeroClassInfo.Types.Power> _repeated_skillTreeTalent_codec = FieldCodec.ForMessage<HeroClassInfo.Types.Power>(18U, HeroClassInfo.Types.Power.Parser);

		// Token: 0x040022E4 RID: 8932
		private readonly RepeatedField<HeroClassInfo.Types.Power> skillTreeTalent_ = new RepeatedField<HeroClassInfo.Types.Power>();

		// Token: 0x040022E5 RID: 8933
		public const int SkillTreeSkillModFieldNumber = 3;

		// Token: 0x040022E6 RID: 8934
		private static readonly FieldCodec<HeroClassInfo.Types.Power> _repeated_skillTreeSkillMod_codec = FieldCodec.ForMessage<HeroClassInfo.Types.Power>(26U, HeroClassInfo.Types.Power.Parser);

		// Token: 0x040022E7 RID: 8935
		private readonly RepeatedField<HeroClassInfo.Types.Power> skillTreeSkillMod_ = new RepeatedField<HeroClassInfo.Types.Power>();

		// Token: 0x040022E8 RID: 8936
		public const int ClassPassiveFieldNumber = 4;

		// Token: 0x040022E9 RID: 8937
		private static readonly FieldCodec<HeroClassInfo.Types.Power> _repeated_classPassive_codec = FieldCodec.ForMessage<HeroClassInfo.Types.Power>(34U, HeroClassInfo.Types.Power.Parser);

		// Token: 0x040022EA RID: 8938
		private readonly RepeatedField<HeroClassInfo.Types.Power> classPassive_ = new RepeatedField<HeroClassInfo.Types.Power>();

		// Token: 0x040022EB RID: 8939
		public const int StatsFieldNumber = 5;

		// Token: 0x040022EC RID: 8940
		private HeroClassInfo.Types.Stats stats_;

		// Token: 0x040022ED RID: 8941
		public const int ParagonFieldNumber = 6;

		// Token: 0x040022EE RID: 8942
		private HeroClassInfo.Types.Paragon paragon_;

		// Token: 0x02000DF5 RID: 3573
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02001484 RID: 5252
			public enum PowerType
			{
				// Token: 0x0400A42C RID: 42028
				[OriginalName("POWER_TYPE_SKILL")]
				Skill,
				// Token: 0x0400A42D RID: 42029
				[OriginalName("POWER_TYPE_TALENT")]
				Talent,
				// Token: 0x0400A42E RID: 42030
				[OriginalName("POWER_TYPE_SKILL_MOD")]
				SkillMod,
				// Token: 0x0400A42F RID: 42031
				[OriginalName("POWER_TYPE_ENCHANT")]
				Enchant,
				// Token: 0x0400A430 RID: 42032
				[OriginalName("POWER_TYPE_CLASS_PASSIVE_SKILL")]
				ClassPassiveSkill,
				// Token: 0x0400A431 RID: 42033
				[OriginalName("POWER_TYPE_ROGUE_SPECIALIZATION")]
				RogueSpecialization,
				// Token: 0x0400A432 RID: 42034
				[OriginalName("POWER_TYPE_WEAPON_EXPERTISE")]
				WeaponExpertise,
				// Token: 0x0400A433 RID: 42035
				[OriginalName("POWER_TYPE_NECROMANCER_SPECIALIZATION")]
				NecromancerSpecialization
			}

			// Token: 0x02001485 RID: 5253
			public sealed class Power : IMessage<HeroClassInfo.Types.Power>, IMessage, IEquatable<HeroClassInfo.Types.Power>, IDeepCloneable<HeroClassInfo.Types.Power>, IBufferMessage
			{
				// Token: 0x17003ACF RID: 15055
				// (get) Token: 0x0600E6D3 RID: 59091 RVA: 0x004D9534 File Offset: 0x004D7734
				[DebuggerNonUserCode]
				public static MessageParser<HeroClassInfo.Types.Power> Parser
				{
					get
					{
						return HeroClassInfo.Types.Power._parser;
					}
				}

				// Token: 0x17003AD0 RID: 15056
				// (get) Token: 0x0600E6D4 RID: 59092 RVA: 0x004D954C File Offset: 0x004D774C
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return HeroClassInfo.Descriptor.NestedTypes[0];
					}
				}

				// Token: 0x17003AD1 RID: 15057
				// (get) Token: 0x0600E6D5 RID: 59093 RVA: 0x004D9570 File Offset: 0x004D7770
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return HeroClassInfo.Types.Power.Descriptor;
					}
				}

				// Token: 0x0600E6D6 RID: 59094 RVA: 0x004D9587 File Offset: 0x004D7787
				[DebuggerNonUserCode]
				public Power()
				{
				}

				// Token: 0x0600E6D7 RID: 59095 RVA: 0x004D9594 File Offset: 0x004D7794
				[DebuggerNonUserCode]
				public Power(HeroClassInfo.Types.Power other)
					: this()
				{
					this._hasBits0 = other._hasBits0;
					this.powerSno_ = other.powerSno_;
					this.powerRanks_ = other.powerRanks_;
					this.type_ = other.type_;
					this.powerMod_ = other.powerMod_;
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E6D8 RID: 59096 RVA: 0x004D95F8 File Offset: 0x004D77F8
				[DebuggerNonUserCode]
				public HeroClassInfo.Types.Power Clone()
				{
					return new HeroClassInfo.Types.Power(this);
				}

				// Token: 0x17003AD2 RID: 15058
				// (get) Token: 0x0600E6D9 RID: 59097 RVA: 0x004D9610 File Offset: 0x004D7810
				// (set) Token: 0x0600E6DA RID: 59098 RVA: 0x004D9641 File Offset: 0x004D7841
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
							powerSnoDefaultValue = HeroClassInfo.Types.Power.PowerSnoDefaultValue;
						}
						return powerSnoDefaultValue;
					}
					set
					{
						this._hasBits0 |= 1;
						this.powerSno_ = value;
					}
				}

				// Token: 0x17003AD3 RID: 15059
				// (get) Token: 0x0600E6DB RID: 59099 RVA: 0x004D965C File Offset: 0x004D785C
				[DebuggerNonUserCode]
				public bool HasPowerSno
				{
					get
					{
						return (this._hasBits0 & 1) != 0;
					}
				}

				// Token: 0x0600E6DC RID: 59100 RVA: 0x004D9679 File Offset: 0x004D7879
				[DebuggerNonUserCode]
				public void ClearPowerSno()
				{
					this._hasBits0 &= -2;
				}

				// Token: 0x17003AD4 RID: 15060
				// (get) Token: 0x0600E6DD RID: 59101 RVA: 0x004D968C File Offset: 0x004D788C
				// (set) Token: 0x0600E6DE RID: 59102 RVA: 0x004D96BD File Offset: 0x004D78BD
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
							powerRanksDefaultValue = HeroClassInfo.Types.Power.PowerRanksDefaultValue;
						}
						return powerRanksDefaultValue;
					}
					set
					{
						this._hasBits0 |= 2;
						this.powerRanks_ = value;
					}
				}

				// Token: 0x17003AD5 RID: 15061
				// (get) Token: 0x0600E6DF RID: 59103 RVA: 0x004D96D8 File Offset: 0x004D78D8
				[DebuggerNonUserCode]
				public bool HasPowerRanks
				{
					get
					{
						return (this._hasBits0 & 2) != 0;
					}
				}

				// Token: 0x0600E6E0 RID: 59104 RVA: 0x004D96F5 File Offset: 0x004D78F5
				[DebuggerNonUserCode]
				public void ClearPowerRanks()
				{
					this._hasBits0 &= -3;
				}

				// Token: 0x17003AD6 RID: 15062
				// (get) Token: 0x0600E6E1 RID: 59105 RVA: 0x004D9708 File Offset: 0x004D7908
				// (set) Token: 0x0600E6E2 RID: 59106 RVA: 0x004D9739 File Offset: 0x004D7939
				[DebuggerNonUserCode]
				public HeroClassInfo.Types.PowerType Type
				{
					get
					{
						bool flag = (this._hasBits0 & 4) != 0;
						HeroClassInfo.Types.PowerType typeDefaultValue;
						if (flag)
						{
							typeDefaultValue = this.type_;
						}
						else
						{
							typeDefaultValue = HeroClassInfo.Types.Power.TypeDefaultValue;
						}
						return typeDefaultValue;
					}
					set
					{
						this._hasBits0 |= 4;
						this.type_ = value;
					}
				}

				// Token: 0x17003AD7 RID: 15063
				// (get) Token: 0x0600E6E3 RID: 59107 RVA: 0x004D9754 File Offset: 0x004D7954
				[DebuggerNonUserCode]
				public bool HasType
				{
					get
					{
						return (this._hasBits0 & 4) != 0;
					}
				}

				// Token: 0x0600E6E4 RID: 59108 RVA: 0x004D9771 File Offset: 0x004D7971
				[DebuggerNonUserCode]
				public void ClearType()
				{
					this._hasBits0 &= -5;
				}

				// Token: 0x17003AD8 RID: 15064
				// (get) Token: 0x0600E6E5 RID: 59109 RVA: 0x004D9784 File Offset: 0x004D7984
				// (set) Token: 0x0600E6E6 RID: 59110 RVA: 0x004D97A5 File Offset: 0x004D79A5
				[DebuggerNonUserCode]
				public string PowerMod
				{
					get
					{
						return this.powerMod_ ?? HeroClassInfo.Types.Power.PowerModDefaultValue;
					}
					set
					{
						this.powerMod_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
					}
				}

				// Token: 0x17003AD9 RID: 15065
				// (get) Token: 0x0600E6E7 RID: 59111 RVA: 0x004D97BC File Offset: 0x004D79BC
				[DebuggerNonUserCode]
				public bool HasPowerMod
				{
					get
					{
						return this.powerMod_ != null;
					}
				}

				// Token: 0x0600E6E8 RID: 59112 RVA: 0x004D97D7 File Offset: 0x004D79D7
				[DebuggerNonUserCode]
				public void ClearPowerMod()
				{
					this.powerMod_ = null;
				}

				// Token: 0x0600E6E9 RID: 59113 RVA: 0x004D97E4 File Offset: 0x004D79E4
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as HeroClassInfo.Types.Power);
				}

				// Token: 0x0600E6EA RID: 59114 RVA: 0x004D9804 File Offset: 0x004D7A04
				[DebuggerNonUserCode]
				public bool Equals(HeroClassInfo.Types.Power other)
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
									if (flag6)
									{
										flag2 = false;
									}
									else
									{
										bool flag7 = this.PowerMod != other.PowerMod;
										flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
									}
								}
							}
						}
					}
					return flag2;
				}

				// Token: 0x0600E6EB RID: 59115 RVA: 0x004D98B0 File Offset: 0x004D7AB0
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
					bool hasPowerMod = this.HasPowerMod;
					if (hasPowerMod)
					{
						num ^= this.PowerMod.GetHashCode();
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E6EC RID: 59116 RVA: 0x004D995C File Offset: 0x004D7B5C
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E6ED RID: 59117 RVA: 0x004D9974 File Offset: 0x004D7B74
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E6EE RID: 59118 RVA: 0x004D9980 File Offset: 0x004D7B80
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
						output.WriteRawTag(16);
						output.WriteUInt32(this.PowerRanks);
					}
					bool hasType = this.HasType;
					if (hasType)
					{
						output.WriteRawTag(24);
						output.WriteEnum((int)this.Type);
					}
					bool hasPowerMod = this.HasPowerMod;
					if (hasPowerMod)
					{
						output.WriteRawTag(34);
						output.WriteString(this.PowerMod);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E6EF RID: 59119 RVA: 0x004D9A34 File Offset: 0x004D7C34
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
					bool hasPowerMod = this.HasPowerMod;
					if (hasPowerMod)
					{
						num += 1 + CodedOutputStream.ComputeStringSize(this.PowerMod);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E6F0 RID: 59120 RVA: 0x004D9ADC File Offset: 0x004D7CDC
				[DebuggerNonUserCode]
				public void MergeFrom(HeroClassInfo.Types.Power other)
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
						bool hasPowerMod = other.HasPowerMod;
						if (hasPowerMod)
						{
							this.PowerMod = other.PowerMod;
						}
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E6F1 RID: 59121 RVA: 0x004D9B72 File Offset: 0x004D7D72
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E6F2 RID: 59122 RVA: 0x004D9B80 File Offset: 0x004D7D80
				[DebuggerNonUserCode]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
					uint num;
					while ((num = input.ReadTag()) > 0U)
					{
						uint num2 = num;
						uint num3 = num2;
						if (num3 <= 16U)
						{
							if (num3 != 8U)
							{
								if (num3 != 16U)
								{
									goto IL_0028;
								}
								this.PowerRanks = input.ReadUInt32();
							}
							else
							{
								this.PowerSno = input.ReadSInt32();
							}
						}
						else if (num3 != 24U)
						{
							if (num3 != 34U)
							{
								goto IL_0028;
							}
							this.PowerMod = input.ReadString();
						}
						else
						{
							this.Type = (HeroClassInfo.Types.PowerType)input.ReadEnum();
						}
						continue;
						IL_0028:
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
				}

				// Token: 0x0400A434 RID: 42036
				private static readonly MessageParser<HeroClassInfo.Types.Power> _parser = new MessageParser<HeroClassInfo.Types.Power>(() => new HeroClassInfo.Types.Power());

				// Token: 0x0400A435 RID: 42037
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A436 RID: 42038
				private int _hasBits0;

				// Token: 0x0400A437 RID: 42039
				public const int PowerSnoFieldNumber = 1;

				// Token: 0x0400A438 RID: 42040
				private static readonly int PowerSnoDefaultValue = 0;

				// Token: 0x0400A439 RID: 42041
				private int powerSno_;

				// Token: 0x0400A43A RID: 42042
				public const int PowerRanksFieldNumber = 2;

				// Token: 0x0400A43B RID: 42043
				private static readonly uint PowerRanksDefaultValue = 0U;

				// Token: 0x0400A43C RID: 42044
				private uint powerRanks_;

				// Token: 0x0400A43D RID: 42045
				public const int TypeFieldNumber = 3;

				// Token: 0x0400A43E RID: 42046
				private static readonly HeroClassInfo.Types.PowerType TypeDefaultValue = HeroClassInfo.Types.PowerType.Skill;

				// Token: 0x0400A43F RID: 42047
				private HeroClassInfo.Types.PowerType type_;

				// Token: 0x0400A440 RID: 42048
				public const int PowerModFieldNumber = 4;

				// Token: 0x0400A441 RID: 42049
				private static readonly string PowerModDefaultValue = "";

				// Token: 0x0400A442 RID: 42050
				private string powerMod_;
			}

			// Token: 0x02001486 RID: 5254
			public sealed class Stats : IMessage<HeroClassInfo.Types.Stats>, IMessage, IEquatable<HeroClassInfo.Types.Stats>, IDeepCloneable<HeroClassInfo.Types.Stats>, IBufferMessage
			{
				// Token: 0x17003ADA RID: 15066
				// (get) Token: 0x0600E6F4 RID: 59124 RVA: 0x004D9C54 File Offset: 0x004D7E54
				[DebuggerNonUserCode]
				public static MessageParser<HeroClassInfo.Types.Stats> Parser
				{
					get
					{
						return HeroClassInfo.Types.Stats._parser;
					}
				}

				// Token: 0x17003ADB RID: 15067
				// (get) Token: 0x0600E6F5 RID: 59125 RVA: 0x004D9C6C File Offset: 0x004D7E6C
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return HeroClassInfo.Descriptor.NestedTypes[1];
					}
				}

				// Token: 0x17003ADC RID: 15068
				// (get) Token: 0x0600E6F6 RID: 59126 RVA: 0x004D9C90 File Offset: 0x004D7E90
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return HeroClassInfo.Types.Stats.Descriptor;
					}
				}

				// Token: 0x0600E6F7 RID: 59127 RVA: 0x004D9CA7 File Offset: 0x004D7EA7
				[DebuggerNonUserCode]
				public Stats()
				{
				}

				// Token: 0x0600E6F8 RID: 59128 RVA: 0x004D9CB4 File Offset: 0x004D7EB4
				[DebuggerNonUserCode]
				public Stats(HeroClassInfo.Types.Stats other)
					: this()
				{
					this._hasBits0 = other._hasBits0;
					this.dexterity_ = other.dexterity_;
					this.intelligence_ = other.intelligence_;
					this.stength_ = other.stength_;
					this.willpower_ = other.willpower_;
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E6F9 RID: 59129 RVA: 0x004D9D18 File Offset: 0x004D7F18
				[DebuggerNonUserCode]
				public HeroClassInfo.Types.Stats Clone()
				{
					return new HeroClassInfo.Types.Stats(this);
				}

				// Token: 0x17003ADD RID: 15069
				// (get) Token: 0x0600E6FA RID: 59130 RVA: 0x004D9D30 File Offset: 0x004D7F30
				// (set) Token: 0x0600E6FB RID: 59131 RVA: 0x004D9D61 File Offset: 0x004D7F61
				[DebuggerNonUserCode]
				public float Dexterity
				{
					get
					{
						bool flag = (this._hasBits0 & 1) != 0;
						float dexterityDefaultValue;
						if (flag)
						{
							dexterityDefaultValue = this.dexterity_;
						}
						else
						{
							dexterityDefaultValue = HeroClassInfo.Types.Stats.DexterityDefaultValue;
						}
						return dexterityDefaultValue;
					}
					set
					{
						this._hasBits0 |= 1;
						this.dexterity_ = value;
					}
				}

				// Token: 0x17003ADE RID: 15070
				// (get) Token: 0x0600E6FC RID: 59132 RVA: 0x004D9D7C File Offset: 0x004D7F7C
				[DebuggerNonUserCode]
				public bool HasDexterity
				{
					get
					{
						return (this._hasBits0 & 1) != 0;
					}
				}

				// Token: 0x0600E6FD RID: 59133 RVA: 0x004D9D99 File Offset: 0x004D7F99
				[DebuggerNonUserCode]
				public void ClearDexterity()
				{
					this._hasBits0 &= -2;
				}

				// Token: 0x17003ADF RID: 15071
				// (get) Token: 0x0600E6FE RID: 59134 RVA: 0x004D9DAC File Offset: 0x004D7FAC
				// (set) Token: 0x0600E6FF RID: 59135 RVA: 0x004D9DDD File Offset: 0x004D7FDD
				[DebuggerNonUserCode]
				public float Intelligence
				{
					get
					{
						bool flag = (this._hasBits0 & 2) != 0;
						float intelligenceDefaultValue;
						if (flag)
						{
							intelligenceDefaultValue = this.intelligence_;
						}
						else
						{
							intelligenceDefaultValue = HeroClassInfo.Types.Stats.IntelligenceDefaultValue;
						}
						return intelligenceDefaultValue;
					}
					set
					{
						this._hasBits0 |= 2;
						this.intelligence_ = value;
					}
				}

				// Token: 0x17003AE0 RID: 15072
				// (get) Token: 0x0600E700 RID: 59136 RVA: 0x004D9DF8 File Offset: 0x004D7FF8
				[DebuggerNonUserCode]
				public bool HasIntelligence
				{
					get
					{
						return (this._hasBits0 & 2) != 0;
					}
				}

				// Token: 0x0600E701 RID: 59137 RVA: 0x004D9E15 File Offset: 0x004D8015
				[DebuggerNonUserCode]
				public void ClearIntelligence()
				{
					this._hasBits0 &= -3;
				}

				// Token: 0x17003AE1 RID: 15073
				// (get) Token: 0x0600E702 RID: 59138 RVA: 0x004D9E28 File Offset: 0x004D8028
				// (set) Token: 0x0600E703 RID: 59139 RVA: 0x004D9E59 File Offset: 0x004D8059
				[DebuggerNonUserCode]
				public float Stength
				{
					get
					{
						bool flag = (this._hasBits0 & 4) != 0;
						float stengthDefaultValue;
						if (flag)
						{
							stengthDefaultValue = this.stength_;
						}
						else
						{
							stengthDefaultValue = HeroClassInfo.Types.Stats.StengthDefaultValue;
						}
						return stengthDefaultValue;
					}
					set
					{
						this._hasBits0 |= 4;
						this.stength_ = value;
					}
				}

				// Token: 0x17003AE2 RID: 15074
				// (get) Token: 0x0600E704 RID: 59140 RVA: 0x004D9E74 File Offset: 0x004D8074
				[DebuggerNonUserCode]
				public bool HasStength
				{
					get
					{
						return (this._hasBits0 & 4) != 0;
					}
				}

				// Token: 0x0600E705 RID: 59141 RVA: 0x004D9E91 File Offset: 0x004D8091
				[DebuggerNonUserCode]
				public void ClearStength()
				{
					this._hasBits0 &= -5;
				}

				// Token: 0x17003AE3 RID: 15075
				// (get) Token: 0x0600E706 RID: 59142 RVA: 0x004D9EA4 File Offset: 0x004D80A4
				// (set) Token: 0x0600E707 RID: 59143 RVA: 0x004D9ED5 File Offset: 0x004D80D5
				[DebuggerNonUserCode]
				public float Willpower
				{
					get
					{
						bool flag = (this._hasBits0 & 8) != 0;
						float willpowerDefaultValue;
						if (flag)
						{
							willpowerDefaultValue = this.willpower_;
						}
						else
						{
							willpowerDefaultValue = HeroClassInfo.Types.Stats.WillpowerDefaultValue;
						}
						return willpowerDefaultValue;
					}
					set
					{
						this._hasBits0 |= 8;
						this.willpower_ = value;
					}
				}

				// Token: 0x17003AE4 RID: 15076
				// (get) Token: 0x0600E708 RID: 59144 RVA: 0x004D9EF0 File Offset: 0x004D80F0
				[DebuggerNonUserCode]
				public bool HasWillpower
				{
					get
					{
						return (this._hasBits0 & 8) != 0;
					}
				}

				// Token: 0x0600E709 RID: 59145 RVA: 0x004D9F0D File Offset: 0x004D810D
				[DebuggerNonUserCode]
				public void ClearWillpower()
				{
					this._hasBits0 &= -9;
				}

				// Token: 0x0600E70A RID: 59146 RVA: 0x004D9F20 File Offset: 0x004D8120
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as HeroClassInfo.Types.Stats);
				}

				// Token: 0x0600E70B RID: 59147 RVA: 0x004D9F40 File Offset: 0x004D8140
				[DebuggerNonUserCode]
				public bool Equals(HeroClassInfo.Types.Stats other)
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
							bool flag4 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Dexterity, other.Dexterity);
							if (flag4)
							{
								flag2 = false;
							}
							else
							{
								bool flag5 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Intelligence, other.Intelligence);
								if (flag5)
								{
									flag2 = false;
								}
								else
								{
									bool flag6 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Stength, other.Stength);
									if (flag6)
									{
										flag2 = false;
									}
									else
									{
										bool flag7 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Willpower, other.Willpower);
										flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
									}
								}
							}
						}
					}
					return flag2;
				}

				// Token: 0x0600E70C RID: 59148 RVA: 0x004DA010 File Offset: 0x004D8210
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					bool hasDexterity = this.HasDexterity;
					if (hasDexterity)
					{
						num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Dexterity);
					}
					bool hasIntelligence = this.HasIntelligence;
					if (hasIntelligence)
					{
						num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Intelligence);
					}
					bool hasStength = this.HasStength;
					if (hasStength)
					{
						num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Stength);
					}
					bool hasWillpower = this.HasWillpower;
					if (hasWillpower)
					{
						num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Willpower);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E70D RID: 59149 RVA: 0x004DA0BC File Offset: 0x004D82BC
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E70E RID: 59150 RVA: 0x004DA0D4 File Offset: 0x004D82D4
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E70F RID: 59151 RVA: 0x004DA0E0 File Offset: 0x004D82E0
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					bool hasDexterity = this.HasDexterity;
					if (hasDexterity)
					{
						output.WriteRawTag(13);
						output.WriteFloat(this.Dexterity);
					}
					bool hasIntelligence = this.HasIntelligence;
					if (hasIntelligence)
					{
						output.WriteRawTag(21);
						output.WriteFloat(this.Intelligence);
					}
					bool hasStength = this.HasStength;
					if (hasStength)
					{
						output.WriteRawTag(29);
						output.WriteFloat(this.Stength);
					}
					bool hasWillpower = this.HasWillpower;
					if (hasWillpower)
					{
						output.WriteRawTag(37);
						output.WriteFloat(this.Willpower);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E710 RID: 59152 RVA: 0x004DA194 File Offset: 0x004D8394
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					bool hasDexterity = this.HasDexterity;
					if (hasDexterity)
					{
						num += 5;
					}
					bool hasIntelligence = this.HasIntelligence;
					if (hasIntelligence)
					{
						num += 5;
					}
					bool hasStength = this.HasStength;
					if (hasStength)
					{
						num += 5;
					}
					bool hasWillpower = this.HasWillpower;
					if (hasWillpower)
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

				// Token: 0x0600E711 RID: 59153 RVA: 0x004DA20C File Offset: 0x004D840C
				[DebuggerNonUserCode]
				public void MergeFrom(HeroClassInfo.Types.Stats other)
				{
					bool flag = other == null;
					if (!flag)
					{
						bool hasDexterity = other.HasDexterity;
						if (hasDexterity)
						{
							this.Dexterity = other.Dexterity;
						}
						bool hasIntelligence = other.HasIntelligence;
						if (hasIntelligence)
						{
							this.Intelligence = other.Intelligence;
						}
						bool hasStength = other.HasStength;
						if (hasStength)
						{
							this.Stength = other.Stength;
						}
						bool hasWillpower = other.HasWillpower;
						if (hasWillpower)
						{
							this.Willpower = other.Willpower;
						}
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E712 RID: 59154 RVA: 0x004DA2A2 File Offset: 0x004D84A2
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E713 RID: 59155 RVA: 0x004DA2B0 File Offset: 0x004D84B0
				[DebuggerNonUserCode]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
					uint num;
					while ((num = input.ReadTag()) > 0U)
					{
						uint num2 = num;
						uint num3 = num2;
						if (num3 <= 21U)
						{
							if (num3 != 13U)
							{
								if (num3 != 21U)
								{
									goto IL_0029;
								}
								this.Intelligence = input.ReadFloat();
							}
							else
							{
								this.Dexterity = input.ReadFloat();
							}
						}
						else if (num3 != 29U)
						{
							if (num3 != 37U)
							{
								goto IL_0029;
							}
							this.Willpower = input.ReadFloat();
						}
						else
						{
							this.Stength = input.ReadFloat();
						}
						continue;
						IL_0029:
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
				}

				// Token: 0x0400A443 RID: 42051
				private static readonly MessageParser<HeroClassInfo.Types.Stats> _parser = new MessageParser<HeroClassInfo.Types.Stats>(() => new HeroClassInfo.Types.Stats());

				// Token: 0x0400A444 RID: 42052
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A445 RID: 42053
				private int _hasBits0;

				// Token: 0x0400A446 RID: 42054
				public const int DexterityFieldNumber = 1;

				// Token: 0x0400A447 RID: 42055
				private static readonly float DexterityDefaultValue = 0f;

				// Token: 0x0400A448 RID: 42056
				private float dexterity_;

				// Token: 0x0400A449 RID: 42057
				public const int IntelligenceFieldNumber = 2;

				// Token: 0x0400A44A RID: 42058
				private static readonly float IntelligenceDefaultValue = 0f;

				// Token: 0x0400A44B RID: 42059
				private float intelligence_;

				// Token: 0x0400A44C RID: 42060
				public const int StengthFieldNumber = 3;

				// Token: 0x0400A44D RID: 42061
				private static readonly float StengthDefaultValue = 0f;

				// Token: 0x0400A44E RID: 42062
				private float stength_;

				// Token: 0x0400A44F RID: 42063
				public const int WillpowerFieldNumber = 4;

				// Token: 0x0400A450 RID: 42064
				private static readonly float WillpowerDefaultValue = 0f;

				// Token: 0x0400A451 RID: 42065
				private float willpower_;
			}

			// Token: 0x02001487 RID: 5255
			public sealed class Glyph : IMessage<HeroClassInfo.Types.Glyph>, IMessage, IEquatable<HeroClassInfo.Types.Glyph>, IDeepCloneable<HeroClassInfo.Types.Glyph>, IBufferMessage
			{
				// Token: 0x17003AE5 RID: 15077
				// (get) Token: 0x0600E715 RID: 59157 RVA: 0x004DA3A0 File Offset: 0x004D85A0
				[DebuggerNonUserCode]
				public static MessageParser<HeroClassInfo.Types.Glyph> Parser
				{
					get
					{
						return HeroClassInfo.Types.Glyph._parser;
					}
				}

				// Token: 0x17003AE6 RID: 15078
				// (get) Token: 0x0600E716 RID: 59158 RVA: 0x004DA3B8 File Offset: 0x004D85B8
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return HeroClassInfo.Descriptor.NestedTypes[2];
					}
				}

				// Token: 0x17003AE7 RID: 15079
				// (get) Token: 0x0600E717 RID: 59159 RVA: 0x004DA3DC File Offset: 0x004D85DC
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return HeroClassInfo.Types.Glyph.Descriptor;
					}
				}

				// Token: 0x0600E718 RID: 59160 RVA: 0x004DA3F3 File Offset: 0x004D85F3
				[DebuggerNonUserCode]
				public Glyph()
				{
				}

				// Token: 0x0600E719 RID: 59161 RVA: 0x004DA400 File Offset: 0x004D8600
				[DebuggerNonUserCode]
				public Glyph(HeroClassInfo.Types.Glyph other)
					: this()
				{
					this._hasBits0 = other._hasBits0;
					this.glyphSno_ = other.glyphSno_;
					this.glyphLevel_ = other.glyphLevel_;
					this.glyphThresholdReached_ = other.glyphThresholdReached_;
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E71A RID: 59162 RVA: 0x004DA458 File Offset: 0x004D8658
				[DebuggerNonUserCode]
				public HeroClassInfo.Types.Glyph Clone()
				{
					return new HeroClassInfo.Types.Glyph(this);
				}

				// Token: 0x17003AE8 RID: 15080
				// (get) Token: 0x0600E71B RID: 59163 RVA: 0x004DA470 File Offset: 0x004D8670
				// (set) Token: 0x0600E71C RID: 59164 RVA: 0x004DA4A1 File Offset: 0x004D86A1
				[DebuggerNonUserCode]
				public int GlyphSno
				{
					get
					{
						bool flag = (this._hasBits0 & 1) != 0;
						int glyphSnoDefaultValue;
						if (flag)
						{
							glyphSnoDefaultValue = this.glyphSno_;
						}
						else
						{
							glyphSnoDefaultValue = HeroClassInfo.Types.Glyph.GlyphSnoDefaultValue;
						}
						return glyphSnoDefaultValue;
					}
					set
					{
						this._hasBits0 |= 1;
						this.glyphSno_ = value;
					}
				}

				// Token: 0x17003AE9 RID: 15081
				// (get) Token: 0x0600E71D RID: 59165 RVA: 0x004DA4BC File Offset: 0x004D86BC
				[DebuggerNonUserCode]
				public bool HasGlyphSno
				{
					get
					{
						return (this._hasBits0 & 1) != 0;
					}
				}

				// Token: 0x0600E71E RID: 59166 RVA: 0x004DA4D9 File Offset: 0x004D86D9
				[DebuggerNonUserCode]
				public void ClearGlyphSno()
				{
					this._hasBits0 &= -2;
				}

				// Token: 0x17003AEA RID: 15082
				// (get) Token: 0x0600E71F RID: 59167 RVA: 0x004DA4EC File Offset: 0x004D86EC
				// (set) Token: 0x0600E720 RID: 59168 RVA: 0x004DA51D File Offset: 0x004D871D
				[DebuggerNonUserCode]
				public int GlyphLevel
				{
					get
					{
						bool flag = (this._hasBits0 & 2) != 0;
						int glyphLevelDefaultValue;
						if (flag)
						{
							glyphLevelDefaultValue = this.glyphLevel_;
						}
						else
						{
							glyphLevelDefaultValue = HeroClassInfo.Types.Glyph.GlyphLevelDefaultValue;
						}
						return glyphLevelDefaultValue;
					}
					set
					{
						this._hasBits0 |= 2;
						this.glyphLevel_ = value;
					}
				}

				// Token: 0x17003AEB RID: 15083
				// (get) Token: 0x0600E721 RID: 59169 RVA: 0x004DA538 File Offset: 0x004D8738
				[DebuggerNonUserCode]
				public bool HasGlyphLevel
				{
					get
					{
						return (this._hasBits0 & 2) != 0;
					}
				}

				// Token: 0x0600E722 RID: 59170 RVA: 0x004DA555 File Offset: 0x004D8755
				[DebuggerNonUserCode]
				public void ClearGlyphLevel()
				{
					this._hasBits0 &= -3;
				}

				// Token: 0x17003AEC RID: 15084
				// (get) Token: 0x0600E723 RID: 59171 RVA: 0x004DA568 File Offset: 0x004D8768
				// (set) Token: 0x0600E724 RID: 59172 RVA: 0x004DA599 File Offset: 0x004D8799
				[DebuggerNonUserCode]
				public bool GlyphThresholdReached
				{
					get
					{
						bool flag = (this._hasBits0 & 4) != 0;
						bool glyphThresholdReachedDefaultValue;
						if (flag)
						{
							glyphThresholdReachedDefaultValue = this.glyphThresholdReached_;
						}
						else
						{
							glyphThresholdReachedDefaultValue = HeroClassInfo.Types.Glyph.GlyphThresholdReachedDefaultValue;
						}
						return glyphThresholdReachedDefaultValue;
					}
					set
					{
						this._hasBits0 |= 4;
						this.glyphThresholdReached_ = value;
					}
				}

				// Token: 0x17003AED RID: 15085
				// (get) Token: 0x0600E725 RID: 59173 RVA: 0x004DA5B4 File Offset: 0x004D87B4
				[DebuggerNonUserCode]
				public bool HasGlyphThresholdReached
				{
					get
					{
						return (this._hasBits0 & 4) != 0;
					}
				}

				// Token: 0x0600E726 RID: 59174 RVA: 0x004DA5D1 File Offset: 0x004D87D1
				[DebuggerNonUserCode]
				public void ClearGlyphThresholdReached()
				{
					this._hasBits0 &= -5;
				}

				// Token: 0x0600E727 RID: 59175 RVA: 0x004DA5E4 File Offset: 0x004D87E4
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as HeroClassInfo.Types.Glyph);
				}

				// Token: 0x0600E728 RID: 59176 RVA: 0x004DA604 File Offset: 0x004D8804
				[DebuggerNonUserCode]
				public bool Equals(HeroClassInfo.Types.Glyph other)
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
							bool flag4 = this.GlyphSno != other.GlyphSno;
							if (flag4)
							{
								flag2 = false;
							}
							else
							{
								bool flag5 = this.GlyphLevel != other.GlyphLevel;
								if (flag5)
								{
									flag2 = false;
								}
								else
								{
									bool flag6 = this.GlyphThresholdReached != other.GlyphThresholdReached;
									flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
					return flag2;
				}

				// Token: 0x0600E729 RID: 59177 RVA: 0x004DA690 File Offset: 0x004D8890
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					bool hasGlyphSno = this.HasGlyphSno;
					if (hasGlyphSno)
					{
						num ^= this.GlyphSno.GetHashCode();
					}
					bool hasGlyphLevel = this.HasGlyphLevel;
					if (hasGlyphLevel)
					{
						num ^= this.GlyphLevel.GetHashCode();
					}
					bool hasGlyphThresholdReached = this.HasGlyphThresholdReached;
					if (hasGlyphThresholdReached)
					{
						num ^= this.GlyphThresholdReached.GetHashCode();
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E72A RID: 59178 RVA: 0x004DA71C File Offset: 0x004D891C
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E72B RID: 59179 RVA: 0x004DA734 File Offset: 0x004D8934
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E72C RID: 59180 RVA: 0x004DA740 File Offset: 0x004D8940
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					bool hasGlyphSno = this.HasGlyphSno;
					if (hasGlyphSno)
					{
						output.WriteRawTag(8);
						output.WriteSInt32(this.GlyphSno);
					}
					bool hasGlyphLevel = this.HasGlyphLevel;
					if (hasGlyphLevel)
					{
						output.WriteRawTag(16);
						output.WriteSInt32(this.GlyphLevel);
					}
					bool hasGlyphThresholdReached = this.HasGlyphThresholdReached;
					if (hasGlyphThresholdReached)
					{
						output.WriteRawTag(24);
						output.WriteBool(this.GlyphThresholdReached);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E72D RID: 59181 RVA: 0x004DA7D0 File Offset: 0x004D89D0
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					bool hasGlyphSno = this.HasGlyphSno;
					if (hasGlyphSno)
					{
						num += 1 + CodedOutputStream.ComputeSInt32Size(this.GlyphSno);
					}
					bool hasGlyphLevel = this.HasGlyphLevel;
					if (hasGlyphLevel)
					{
						num += 1 + CodedOutputStream.ComputeSInt32Size(this.GlyphLevel);
					}
					bool hasGlyphThresholdReached = this.HasGlyphThresholdReached;
					if (hasGlyphThresholdReached)
					{
						num += 2;
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E72E RID: 59182 RVA: 0x004DA850 File Offset: 0x004D8A50
				[DebuggerNonUserCode]
				public void MergeFrom(HeroClassInfo.Types.Glyph other)
				{
					bool flag = other == null;
					if (!flag)
					{
						bool hasGlyphSno = other.HasGlyphSno;
						if (hasGlyphSno)
						{
							this.GlyphSno = other.GlyphSno;
						}
						bool hasGlyphLevel = other.HasGlyphLevel;
						if (hasGlyphLevel)
						{
							this.GlyphLevel = other.GlyphLevel;
						}
						bool hasGlyphThresholdReached = other.HasGlyphThresholdReached;
						if (hasGlyphThresholdReached)
						{
							this.GlyphThresholdReached = other.GlyphThresholdReached;
						}
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E72F RID: 59183 RVA: 0x004DA8CB File Offset: 0x004D8ACB
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E730 RID: 59184 RVA: 0x004DA8D8 File Offset: 0x004D8AD8
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
								if (num3 != 24U)
								{
									this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
								}
								else
								{
									this.GlyphThresholdReached = input.ReadBool();
								}
							}
							else
							{
								this.GlyphLevel = input.ReadSInt32();
							}
						}
						else
						{
							this.GlyphSno = input.ReadSInt32();
						}
					}
				}

				// Token: 0x0400A452 RID: 42066
				private static readonly MessageParser<HeroClassInfo.Types.Glyph> _parser = new MessageParser<HeroClassInfo.Types.Glyph>(() => new HeroClassInfo.Types.Glyph());

				// Token: 0x0400A453 RID: 42067
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A454 RID: 42068
				private int _hasBits0;

				// Token: 0x0400A455 RID: 42069
				public const int GlyphSnoFieldNumber = 1;

				// Token: 0x0400A456 RID: 42070
				private static readonly int GlyphSnoDefaultValue = 0;

				// Token: 0x0400A457 RID: 42071
				private int glyphSno_;

				// Token: 0x0400A458 RID: 42072
				public const int GlyphLevelFieldNumber = 2;

				// Token: 0x0400A459 RID: 42073
				private static readonly int GlyphLevelDefaultValue = 0;

				// Token: 0x0400A45A RID: 42074
				private int glyphLevel_;

				// Token: 0x0400A45B RID: 42075
				public const int GlyphThresholdReachedFieldNumber = 3;

				// Token: 0x0400A45C RID: 42076
				private static readonly bool GlyphThresholdReachedDefaultValue = false;

				// Token: 0x0400A45D RID: 42077
				private bool glyphThresholdReached_;
			}

			// Token: 0x02001488 RID: 5256
			public sealed class Paragon : IMessage<HeroClassInfo.Types.Paragon>, IMessage, IEquatable<HeroClassInfo.Types.Paragon>, IDeepCloneable<HeroClassInfo.Types.Paragon>, IBufferMessage
			{
				// Token: 0x17003AEE RID: 15086
				// (get) Token: 0x0600E732 RID: 59186 RVA: 0x004DA984 File Offset: 0x004D8B84
				[DebuggerNonUserCode]
				public static MessageParser<HeroClassInfo.Types.Paragon> Parser
				{
					get
					{
						return HeroClassInfo.Types.Paragon._parser;
					}
				}

				// Token: 0x17003AEF RID: 15087
				// (get) Token: 0x0600E733 RID: 59187 RVA: 0x004DA99C File Offset: 0x004D8B9C
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return HeroClassInfo.Descriptor.NestedTypes[3];
					}
				}

				// Token: 0x17003AF0 RID: 15088
				// (get) Token: 0x0600E734 RID: 59188 RVA: 0x004DA9C0 File Offset: 0x004D8BC0
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return HeroClassInfo.Types.Paragon.Descriptor;
					}
				}

				// Token: 0x0600E735 RID: 59189 RVA: 0x004DA9D7 File Offset: 0x004D8BD7
				[DebuggerNonUserCode]
				public Paragon()
				{
				}

				// Token: 0x0600E736 RID: 59190 RVA: 0x004DAA04 File Offset: 0x004D8C04
				[DebuggerNonUserCode]
				public Paragon(HeroClassInfo.Types.Paragon other)
					: this()
				{
					this._hasBits0 = other._hasBits0;
					this.equippedBoardSno_ = other.equippedBoardSno_.Clone();
					this.equippedGlyph_ = other.equippedGlyph_.Clone();
					this.legendaryNodeSno_ = other.legendaryNodeSno_.Clone();
					this.pointsEarned_ = other.pointsEarned_;
					this.pointsAvailable_ = other.pointsAvailable_;
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E737 RID: 59191 RVA: 0x004DAA84 File Offset: 0x004D8C84
				[DebuggerNonUserCode]
				public HeroClassInfo.Types.Paragon Clone()
				{
					return new HeroClassInfo.Types.Paragon(this);
				}

				// Token: 0x17003AF1 RID: 15089
				// (get) Token: 0x0600E738 RID: 59192 RVA: 0x004DAA9C File Offset: 0x004D8C9C
				[DebuggerNonUserCode]
				public RepeatedField<int> EquippedBoardSno
				{
					get
					{
						return this.equippedBoardSno_;
					}
				}

				// Token: 0x17003AF2 RID: 15090
				// (get) Token: 0x0600E739 RID: 59193 RVA: 0x004DAAB4 File Offset: 0x004D8CB4
				[DebuggerNonUserCode]
				public RepeatedField<HeroClassInfo.Types.Glyph> EquippedGlyph
				{
					get
					{
						return this.equippedGlyph_;
					}
				}

				// Token: 0x17003AF3 RID: 15091
				// (get) Token: 0x0600E73A RID: 59194 RVA: 0x004DAACC File Offset: 0x004D8CCC
				[DebuggerNonUserCode]
				public RepeatedField<int> LegendaryNodeSno
				{
					get
					{
						return this.legendaryNodeSno_;
					}
				}

				// Token: 0x17003AF4 RID: 15092
				// (get) Token: 0x0600E73B RID: 59195 RVA: 0x004DAAE4 File Offset: 0x004D8CE4
				// (set) Token: 0x0600E73C RID: 59196 RVA: 0x004DAB15 File Offset: 0x004D8D15
				[DebuggerNonUserCode]
				public int PointsEarned
				{
					get
					{
						bool flag = (this._hasBits0 & 1) != 0;
						int pointsEarnedDefaultValue;
						if (flag)
						{
							pointsEarnedDefaultValue = this.pointsEarned_;
						}
						else
						{
							pointsEarnedDefaultValue = HeroClassInfo.Types.Paragon.PointsEarnedDefaultValue;
						}
						return pointsEarnedDefaultValue;
					}
					set
					{
						this._hasBits0 |= 1;
						this.pointsEarned_ = value;
					}
				}

				// Token: 0x17003AF5 RID: 15093
				// (get) Token: 0x0600E73D RID: 59197 RVA: 0x004DAB30 File Offset: 0x004D8D30
				[DebuggerNonUserCode]
				public bool HasPointsEarned
				{
					get
					{
						return (this._hasBits0 & 1) != 0;
					}
				}

				// Token: 0x0600E73E RID: 59198 RVA: 0x004DAB4D File Offset: 0x004D8D4D
				[DebuggerNonUserCode]
				public void ClearPointsEarned()
				{
					this._hasBits0 &= -2;
				}

				// Token: 0x17003AF6 RID: 15094
				// (get) Token: 0x0600E73F RID: 59199 RVA: 0x004DAB60 File Offset: 0x004D8D60
				// (set) Token: 0x0600E740 RID: 59200 RVA: 0x004DAB91 File Offset: 0x004D8D91
				[DebuggerNonUserCode]
				public int PointsAvailable
				{
					get
					{
						bool flag = (this._hasBits0 & 2) != 0;
						int pointsAvailableDefaultValue;
						if (flag)
						{
							pointsAvailableDefaultValue = this.pointsAvailable_;
						}
						else
						{
							pointsAvailableDefaultValue = HeroClassInfo.Types.Paragon.PointsAvailableDefaultValue;
						}
						return pointsAvailableDefaultValue;
					}
					set
					{
						this._hasBits0 |= 2;
						this.pointsAvailable_ = value;
					}
				}

				// Token: 0x17003AF7 RID: 15095
				// (get) Token: 0x0600E741 RID: 59201 RVA: 0x004DABAC File Offset: 0x004D8DAC
				[DebuggerNonUserCode]
				public bool HasPointsAvailable
				{
					get
					{
						return (this._hasBits0 & 2) != 0;
					}
				}

				// Token: 0x0600E742 RID: 59202 RVA: 0x004DABC9 File Offset: 0x004D8DC9
				[DebuggerNonUserCode]
				public void ClearPointsAvailable()
				{
					this._hasBits0 &= -3;
				}

				// Token: 0x0600E743 RID: 59203 RVA: 0x004DABDC File Offset: 0x004D8DDC
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as HeroClassInfo.Types.Paragon);
				}

				// Token: 0x0600E744 RID: 59204 RVA: 0x004DABFC File Offset: 0x004D8DFC
				[DebuggerNonUserCode]
				public bool Equals(HeroClassInfo.Types.Paragon other)
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
							bool flag4 = !this.equippedBoardSno_.Equals(other.equippedBoardSno_);
							if (flag4)
							{
								flag2 = false;
							}
							else
							{
								bool flag5 = !this.equippedGlyph_.Equals(other.equippedGlyph_);
								if (flag5)
								{
									flag2 = false;
								}
								else
								{
									bool flag6 = !this.legendaryNodeSno_.Equals(other.legendaryNodeSno_);
									if (flag6)
									{
										flag2 = false;
									}
									else
									{
										bool flag7 = this.PointsEarned != other.PointsEarned;
										if (flag7)
										{
											flag2 = false;
										}
										else
										{
											bool flag8 = this.PointsAvailable != other.PointsAvailable;
											flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
										}
									}
								}
							}
						}
					}
					return flag2;
				}

				// Token: 0x0600E745 RID: 59205 RVA: 0x004DACD0 File Offset: 0x004D8ED0
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					num ^= this.equippedBoardSno_.GetHashCode();
					num ^= this.equippedGlyph_.GetHashCode();
					num ^= this.legendaryNodeSno_.GetHashCode();
					bool hasPointsEarned = this.HasPointsEarned;
					if (hasPointsEarned)
					{
						num ^= this.PointsEarned.GetHashCode();
					}
					bool hasPointsAvailable = this.HasPointsAvailable;
					if (hasPointsAvailable)
					{
						num ^= this.PointsAvailable.GetHashCode();
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E746 RID: 59206 RVA: 0x004DAD68 File Offset: 0x004D8F68
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E747 RID: 59207 RVA: 0x004DAD80 File Offset: 0x004D8F80
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E748 RID: 59208 RVA: 0x004DAD8C File Offset: 0x004D8F8C
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					this.equippedBoardSno_.WriteTo(ref output, HeroClassInfo.Types.Paragon._repeated_equippedBoardSno_codec);
					this.equippedGlyph_.WriteTo(ref output, HeroClassInfo.Types.Paragon._repeated_equippedGlyph_codec);
					this.legendaryNodeSno_.WriteTo(ref output, HeroClassInfo.Types.Paragon._repeated_legendaryNodeSno_codec);
					bool hasPointsEarned = this.HasPointsEarned;
					if (hasPointsEarned)
					{
						output.WriteRawTag(32);
						output.WriteSInt32(this.PointsEarned);
					}
					bool hasPointsAvailable = this.HasPointsAvailable;
					if (hasPointsAvailable)
					{
						output.WriteRawTag(40);
						output.WriteSInt32(this.PointsAvailable);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E749 RID: 59209 RVA: 0x004DAE30 File Offset: 0x004D9030
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					num += this.equippedBoardSno_.CalculateSize(HeroClassInfo.Types.Paragon._repeated_equippedBoardSno_codec);
					num += this.equippedGlyph_.CalculateSize(HeroClassInfo.Types.Paragon._repeated_equippedGlyph_codec);
					num += this.legendaryNodeSno_.CalculateSize(HeroClassInfo.Types.Paragon._repeated_legendaryNodeSno_codec);
					bool hasPointsEarned = this.HasPointsEarned;
					if (hasPointsEarned)
					{
						num += 1 + CodedOutputStream.ComputeSInt32Size(this.PointsEarned);
					}
					bool hasPointsAvailable = this.HasPointsAvailable;
					if (hasPointsAvailable)
					{
						num += 1 + CodedOutputStream.ComputeSInt32Size(this.PointsAvailable);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E74A RID: 59210 RVA: 0x004DAED8 File Offset: 0x004D90D8
				[DebuggerNonUserCode]
				public void MergeFrom(HeroClassInfo.Types.Paragon other)
				{
					bool flag = other == null;
					if (!flag)
					{
						this.equippedBoardSno_.Add(other.equippedBoardSno_);
						this.equippedGlyph_.Add(other.equippedGlyph_);
						this.legendaryNodeSno_.Add(other.legendaryNodeSno_);
						bool hasPointsEarned = other.HasPointsEarned;
						if (hasPointsEarned)
						{
							this.PointsEarned = other.PointsEarned;
						}
						bool hasPointsAvailable = other.HasPointsAvailable;
						if (hasPointsAvailable)
						{
							this.PointsAvailable = other.PointsAvailable;
						}
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E74B RID: 59211 RVA: 0x004DAF70 File Offset: 0x004D9170
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E74C RID: 59212 RVA: 0x004DAF7C File Offset: 0x004D917C
				[DebuggerNonUserCode]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
					uint num;
					while ((num = input.ReadTag()) > 0U)
					{
						uint num2 = num;
						uint num3 = num2;
						if (num3 <= 18U)
						{
							if (num3 != 8U && num3 != 10U)
							{
								if (num3 != 18U)
								{
									goto IL_0045;
								}
								this.equippedGlyph_.AddEntriesFrom(ref input, HeroClassInfo.Types.Paragon._repeated_equippedGlyph_codec);
							}
							else
							{
								this.equippedBoardSno_.AddEntriesFrom(ref input, HeroClassInfo.Types.Paragon._repeated_equippedBoardSno_codec);
							}
						}
						else if (num3 <= 26U)
						{
							if (num3 != 24U && num3 != 26U)
							{
								goto IL_0045;
							}
							this.legendaryNodeSno_.AddEntriesFrom(ref input, HeroClassInfo.Types.Paragon._repeated_legendaryNodeSno_codec);
						}
						else if (num3 != 32U)
						{
							if (num3 != 40U)
							{
								goto IL_0045;
							}
							this.PointsAvailable = input.ReadSInt32();
						}
						else
						{
							this.PointsEarned = input.ReadSInt32();
						}
						continue;
						IL_0045:
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
				}

				// Token: 0x0400A45E RID: 42078
				private static readonly MessageParser<HeroClassInfo.Types.Paragon> _parser = new MessageParser<HeroClassInfo.Types.Paragon>(() => new HeroClassInfo.Types.Paragon());

				// Token: 0x0400A45F RID: 42079
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A460 RID: 42080
				private int _hasBits0;

				// Token: 0x0400A461 RID: 42081
				public const int EquippedBoardSnoFieldNumber = 1;

				// Token: 0x0400A462 RID: 42082
				private static readonly FieldCodec<int> _repeated_equippedBoardSno_codec = FieldCodec.ForSInt32(8U);

				// Token: 0x0400A463 RID: 42083
				private readonly RepeatedField<int> equippedBoardSno_ = new RepeatedField<int>();

				// Token: 0x0400A464 RID: 42084
				public const int EquippedGlyphFieldNumber = 2;

				// Token: 0x0400A465 RID: 42085
				private static readonly FieldCodec<HeroClassInfo.Types.Glyph> _repeated_equippedGlyph_codec = FieldCodec.ForMessage<HeroClassInfo.Types.Glyph>(18U, HeroClassInfo.Types.Glyph.Parser);

				// Token: 0x0400A466 RID: 42086
				private readonly RepeatedField<HeroClassInfo.Types.Glyph> equippedGlyph_ = new RepeatedField<HeroClassInfo.Types.Glyph>();

				// Token: 0x0400A467 RID: 42087
				public const int LegendaryNodeSnoFieldNumber = 3;

				// Token: 0x0400A468 RID: 42088
				private static readonly FieldCodec<int> _repeated_legendaryNodeSno_codec = FieldCodec.ForSInt32(24U);

				// Token: 0x0400A469 RID: 42089
				private readonly RepeatedField<int> legendaryNodeSno_ = new RepeatedField<int>();

				// Token: 0x0400A46A RID: 42090
				public const int PointsEarnedFieldNumber = 4;

				// Token: 0x0400A46B RID: 42091
				private static readonly int PointsEarnedDefaultValue = 0;

				// Token: 0x0400A46C RID: 42092
				private int pointsEarned_;

				// Token: 0x0400A46D RID: 42093
				public const int PointsAvailableFieldNumber = 5;

				// Token: 0x0400A46E RID: 42094
				private static readonly int PointsAvailableDefaultValue = 0;

				// Token: 0x0400A46F RID: 42095
				private int pointsAvailable_;
			}
		}
	}
}
