using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Items
{
	// Token: 0x02000160 RID: 352
	public sealed class ImbuedAffixParams : IMessage<ImbuedAffixParams>, IMessage, IEquatable<ImbuedAffixParams>, IDeepCloneable<ImbuedAffixParams>, IBufferMessage
	{
		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x06002441 RID: 9281 RVA: 0x0008CC14 File Offset: 0x0008AE14
		[DebuggerNonUserCode]
		public static MessageParser<ImbuedAffixParams> Parser
		{
			get
			{
				return ImbuedAffixParams._parser;
			}
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x06002442 RID: 9282 RVA: 0x0008CC2C File Offset: 0x0008AE2C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ItemsReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x06002443 RID: 9283 RVA: 0x0008CC50 File Offset: 0x0008AE50
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ImbuedAffixParams.Descriptor;
			}
		}

		// Token: 0x06002444 RID: 9284 RVA: 0x0008CC67 File Offset: 0x0008AE67
		[DebuggerNonUserCode]
		public ImbuedAffixParams()
		{
		}

		// Token: 0x06002445 RID: 9285 RVA: 0x0008CC74 File Offset: 0x0008AE74
		[DebuggerNonUserCode]
		public ImbuedAffixParams(ImbuedAffixParams other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.affix_ = other.affix_;
			this.seed_ = other.seed_;
			this.carry_ = other.carry_;
			this.replacedAffix_ = other.replacedAffix_;
			this.essenceItemPower_ = other.essenceItemPower_;
			this.fromDefinition_ = other.fromDefinition_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002446 RID: 9286 RVA: 0x0008CCF0 File Offset: 0x0008AEF0
		[DebuggerNonUserCode]
		public ImbuedAffixParams Clone()
		{
			return new ImbuedAffixParams(this);
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x06002447 RID: 9287 RVA: 0x0008CD08 File Offset: 0x0008AF08
		// (set) Token: 0x06002448 RID: 9288 RVA: 0x0008CD39 File Offset: 0x0008AF39
		[DebuggerNonUserCode]
		public int Affix
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int affixDefaultValue;
				if (flag)
				{
					affixDefaultValue = this.affix_;
				}
				else
				{
					affixDefaultValue = ImbuedAffixParams.AffixDefaultValue;
				}
				return affixDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.affix_ = value;
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06002449 RID: 9289 RVA: 0x0008CD54 File Offset: 0x0008AF54
		[DebuggerNonUserCode]
		public bool HasAffix
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600244A RID: 9290 RVA: 0x0008CD71 File Offset: 0x0008AF71
		[DebuggerNonUserCode]
		public void ClearAffix()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x0600244B RID: 9291 RVA: 0x0008CD84 File Offset: 0x0008AF84
		// (set) Token: 0x0600244C RID: 9292 RVA: 0x0008CDB5 File Offset: 0x0008AFB5
		[DebuggerNonUserCode]
		public uint Seed
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint seedDefaultValue;
				if (flag)
				{
					seedDefaultValue = this.seed_;
				}
				else
				{
					seedDefaultValue = ImbuedAffixParams.SeedDefaultValue;
				}
				return seedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.seed_ = value;
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x0600244D RID: 9293 RVA: 0x0008CDD0 File Offset: 0x0008AFD0
		[DebuggerNonUserCode]
		public bool HasSeed
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600244E RID: 9294 RVA: 0x0008CDED File Offset: 0x0008AFED
		[DebuggerNonUserCode]
		public void ClearSeed()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x0600244F RID: 9295 RVA: 0x0008CE00 File Offset: 0x0008B000
		// (set) Token: 0x06002450 RID: 9296 RVA: 0x0008CE31 File Offset: 0x0008B031
		[DebuggerNonUserCode]
		public uint Carry
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint carryDefaultValue;
				if (flag)
				{
					carryDefaultValue = this.carry_;
				}
				else
				{
					carryDefaultValue = ImbuedAffixParams.CarryDefaultValue;
				}
				return carryDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.carry_ = value;
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06002451 RID: 9297 RVA: 0x0008CE4C File Offset: 0x0008B04C
		[DebuggerNonUserCode]
		public bool HasCarry
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06002452 RID: 9298 RVA: 0x0008CE69 File Offset: 0x0008B069
		[DebuggerNonUserCode]
		public void ClearCarry()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06002453 RID: 9299 RVA: 0x0008CE7C File Offset: 0x0008B07C
		// (set) Token: 0x06002454 RID: 9300 RVA: 0x0008CEAD File Offset: 0x0008B0AD
		[DebuggerNonUserCode]
		public int ReplacedAffix
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int replacedAffixDefaultValue;
				if (flag)
				{
					replacedAffixDefaultValue = this.replacedAffix_;
				}
				else
				{
					replacedAffixDefaultValue = ImbuedAffixParams.ReplacedAffixDefaultValue;
				}
				return replacedAffixDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.replacedAffix_ = value;
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06002455 RID: 9301 RVA: 0x0008CEC8 File Offset: 0x0008B0C8
		[DebuggerNonUserCode]
		public bool HasReplacedAffix
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06002456 RID: 9302 RVA: 0x0008CEE5 File Offset: 0x0008B0E5
		[DebuggerNonUserCode]
		public void ClearReplacedAffix()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06002457 RID: 9303 RVA: 0x0008CEF8 File Offset: 0x0008B0F8
		// (set) Token: 0x06002458 RID: 9304 RVA: 0x0008CF2A File Offset: 0x0008B12A
		[DebuggerNonUserCode]
		public int EssenceItemPower
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				int essenceItemPowerDefaultValue;
				if (flag)
				{
					essenceItemPowerDefaultValue = this.essenceItemPower_;
				}
				else
				{
					essenceItemPowerDefaultValue = ImbuedAffixParams.EssenceItemPowerDefaultValue;
				}
				return essenceItemPowerDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.essenceItemPower_ = value;
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06002459 RID: 9305 RVA: 0x0008CF44 File Offset: 0x0008B144
		[DebuggerNonUserCode]
		public bool HasEssenceItemPower
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600245A RID: 9306 RVA: 0x0008CF62 File Offset: 0x0008B162
		[DebuggerNonUserCode]
		public void ClearEssenceItemPower()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x0600245B RID: 9307 RVA: 0x0008CF74 File Offset: 0x0008B174
		// (set) Token: 0x0600245C RID: 9308 RVA: 0x0008CFA6 File Offset: 0x0008B1A6
		[DebuggerNonUserCode]
		public bool FromDefinition
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				bool fromDefinitionDefaultValue;
				if (flag)
				{
					fromDefinitionDefaultValue = this.fromDefinition_;
				}
				else
				{
					fromDefinitionDefaultValue = ImbuedAffixParams.FromDefinitionDefaultValue;
				}
				return fromDefinitionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.fromDefinition_ = value;
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x0600245D RID: 9309 RVA: 0x0008CFC0 File Offset: 0x0008B1C0
		[DebuggerNonUserCode]
		public bool HasFromDefinition
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x0600245E RID: 9310 RVA: 0x0008CFDE File Offset: 0x0008B1DE
		[DebuggerNonUserCode]
		public void ClearFromDefinition()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x0600245F RID: 9311 RVA: 0x0008CFF0 File Offset: 0x0008B1F0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ImbuedAffixParams);
		}

		// Token: 0x06002460 RID: 9312 RVA: 0x0008D010 File Offset: 0x0008B210
		[DebuggerNonUserCode]
		public bool Equals(ImbuedAffixParams other)
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
					bool flag4 = this.Affix != other.Affix;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Seed != other.Seed;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Carry != other.Carry;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.ReplacedAffix != other.ReplacedAffix;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.EssenceItemPower != other.EssenceItemPower;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.FromDefinition != other.FromDefinition;
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

		// Token: 0x06002461 RID: 9313 RVA: 0x0008D0FC File Offset: 0x0008B2FC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAffix = this.HasAffix;
			if (hasAffix)
			{
				num ^= this.Affix.GetHashCode();
			}
			bool hasSeed = this.HasSeed;
			if (hasSeed)
			{
				num ^= this.Seed.GetHashCode();
			}
			bool hasCarry = this.HasCarry;
			if (hasCarry)
			{
				num ^= this.Carry.GetHashCode();
			}
			bool hasReplacedAffix = this.HasReplacedAffix;
			if (hasReplacedAffix)
			{
				num ^= this.ReplacedAffix.GetHashCode();
			}
			bool hasEssenceItemPower = this.HasEssenceItemPower;
			if (hasEssenceItemPower)
			{
				num ^= this.EssenceItemPower.GetHashCode();
			}
			bool hasFromDefinition = this.HasFromDefinition;
			if (hasFromDefinition)
			{
				num ^= this.FromDefinition.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002462 RID: 9314 RVA: 0x0008D1E0 File Offset: 0x0008B3E0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002463 RID: 9315 RVA: 0x0008D1F8 File Offset: 0x0008B3F8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002464 RID: 9316 RVA: 0x0008D204 File Offset: 0x0008B404
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAffix = this.HasAffix;
			if (hasAffix)
			{
				output.WriteRawTag(13);
				output.WriteSFixed32(this.Affix);
			}
			bool hasSeed = this.HasSeed;
			if (hasSeed)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Seed);
			}
			bool hasCarry = this.HasCarry;
			if (hasCarry)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Carry);
			}
			bool hasReplacedAffix = this.HasReplacedAffix;
			if (hasReplacedAffix)
			{
				output.WriteRawTag(37);
				output.WriteSFixed32(this.ReplacedAffix);
			}
			bool hasEssenceItemPower = this.HasEssenceItemPower;
			if (hasEssenceItemPower)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.EssenceItemPower);
			}
			bool hasFromDefinition = this.HasFromDefinition;
			if (hasFromDefinition)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.FromDefinition);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002465 RID: 9317 RVA: 0x0008D300 File Offset: 0x0008B500
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAffix = this.HasAffix;
			if (hasAffix)
			{
				num += 5;
			}
			bool hasSeed = this.HasSeed;
			if (hasSeed)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Seed);
			}
			bool hasCarry = this.HasCarry;
			if (hasCarry)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Carry);
			}
			bool hasReplacedAffix = this.HasReplacedAffix;
			if (hasReplacedAffix)
			{
				num += 5;
			}
			bool hasEssenceItemPower = this.HasEssenceItemPower;
			if (hasEssenceItemPower)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EssenceItemPower);
			}
			bool hasFromDefinition = this.HasFromDefinition;
			if (hasFromDefinition)
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

		// Token: 0x06002466 RID: 9318 RVA: 0x0008D3C0 File Offset: 0x0008B5C0
		[DebuggerNonUserCode]
		public void MergeFrom(ImbuedAffixParams other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAffix = other.HasAffix;
				if (hasAffix)
				{
					this.Affix = other.Affix;
				}
				bool hasSeed = other.HasSeed;
				if (hasSeed)
				{
					this.Seed = other.Seed;
				}
				bool hasCarry = other.HasCarry;
				if (hasCarry)
				{
					this.Carry = other.Carry;
				}
				bool hasReplacedAffix = other.HasReplacedAffix;
				if (hasReplacedAffix)
				{
					this.ReplacedAffix = other.ReplacedAffix;
				}
				bool hasEssenceItemPower = other.HasEssenceItemPower;
				if (hasEssenceItemPower)
				{
					this.EssenceItemPower = other.EssenceItemPower;
				}
				bool hasFromDefinition = other.HasFromDefinition;
				if (hasFromDefinition)
				{
					this.FromDefinition = other.FromDefinition;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002467 RID: 9319 RVA: 0x0008D48F File Offset: 0x0008B68F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x0008D49C File Offset: 0x0008B69C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 24U)
				{
					if (num3 != 13U)
					{
						if (num3 != 16U)
						{
							if (num3 != 24U)
							{
								goto IL_003A;
							}
							this.Carry = input.ReadUInt32();
						}
						else
						{
							this.Seed = input.ReadUInt32();
						}
					}
					else
					{
						this.Affix = input.ReadSFixed32();
					}
				}
				else if (num3 != 37U)
				{
					if (num3 != 40U)
					{
						if (num3 != 48U)
						{
							goto IL_003A;
						}
						this.FromDefinition = input.ReadBool();
					}
					else
					{
						this.EssenceItemPower = input.ReadInt32();
					}
				}
				else
				{
					this.ReplacedAffix = input.ReadSFixed32();
				}
				continue;
				IL_003A:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000FE7 RID: 4071
		private static readonly MessageParser<ImbuedAffixParams> _parser = new MessageParser<ImbuedAffixParams>(() => new ImbuedAffixParams());

		// Token: 0x04000FE8 RID: 4072
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000FE9 RID: 4073
		private int _hasBits0;

		// Token: 0x04000FEA RID: 4074
		public const int AffixFieldNumber = 1;

		// Token: 0x04000FEB RID: 4075
		private static readonly int AffixDefaultValue = 0;

		// Token: 0x04000FEC RID: 4076
		private int affix_;

		// Token: 0x04000FED RID: 4077
		public const int SeedFieldNumber = 2;

		// Token: 0x04000FEE RID: 4078
		private static readonly uint SeedDefaultValue = 0U;

		// Token: 0x04000FEF RID: 4079
		private uint seed_;

		// Token: 0x04000FF0 RID: 4080
		public const int CarryFieldNumber = 3;

		// Token: 0x04000FF1 RID: 4081
		private static readonly uint CarryDefaultValue = 0U;

		// Token: 0x04000FF2 RID: 4082
		private uint carry_;

		// Token: 0x04000FF3 RID: 4083
		public const int ReplacedAffixFieldNumber = 4;

		// Token: 0x04000FF4 RID: 4084
		private static readonly int ReplacedAffixDefaultValue = -1;

		// Token: 0x04000FF5 RID: 4085
		private int replacedAffix_;

		// Token: 0x04000FF6 RID: 4086
		public const int EssenceItemPowerFieldNumber = 5;

		// Token: 0x04000FF7 RID: 4087
		private static readonly int EssenceItemPowerDefaultValue = 0;

		// Token: 0x04000FF8 RID: 4088
		private int essenceItemPower_;

		// Token: 0x04000FF9 RID: 4089
		public const int FromDefinitionFieldNumber = 6;

		// Token: 0x04000FFA RID: 4090
		private static readonly bool FromDefinitionDefaultValue = false;

		// Token: 0x04000FFB RID: 4091
		private bool fromDefinition_;
	}
}
