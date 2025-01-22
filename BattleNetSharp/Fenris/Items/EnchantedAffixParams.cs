using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Items
{
	// Token: 0x02000161 RID: 353
	public sealed class EnchantedAffixParams : IMessage<EnchantedAffixParams>, IMessage, IEquatable<EnchantedAffixParams>, IDeepCloneable<EnchantedAffixParams>, IBufferMessage
	{
		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x0600246A RID: 9322 RVA: 0x0008D5AC File Offset: 0x0008B7AC
		[DebuggerNonUserCode]
		public static MessageParser<EnchantedAffixParams> Parser
		{
			get
			{
				return EnchantedAffixParams._parser;
			}
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x0600246B RID: 9323 RVA: 0x0008D5C4 File Offset: 0x0008B7C4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ItemsReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x0600246C RID: 9324 RVA: 0x0008D5E8 File Offset: 0x0008B7E8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnchantedAffixParams.Descriptor;
			}
		}

		// Token: 0x0600246D RID: 9325 RVA: 0x0008D5FF File Offset: 0x0008B7FF
		[DebuggerNonUserCode]
		public EnchantedAffixParams()
		{
		}

		// Token: 0x0600246E RID: 9326 RVA: 0x0008D60C File Offset: 0x0008B80C
		[DebuggerNonUserCode]
		public EnchantedAffixParams(EnchantedAffixParams other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.enchantCount_ = other.enchantCount_;
			this.enchantedReplacedAffix_ = other.enchantedReplacedAffix_;
			this.enchantedAffix_ = other.enchantedAffix_;
			this.enchantedAffixSeed_ = other.enchantedAffixSeed_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600246F RID: 9327 RVA: 0x0008D670 File Offset: 0x0008B870
		[DebuggerNonUserCode]
		public EnchantedAffixParams Clone()
		{
			return new EnchantedAffixParams(this);
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x06002470 RID: 9328 RVA: 0x0008D688 File Offset: 0x0008B888
		// (set) Token: 0x06002471 RID: 9329 RVA: 0x0008D6B9 File Offset: 0x0008B8B9
		[DebuggerNonUserCode]
		public uint EnchantCount
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint enchantCountDefaultValue;
				if (flag)
				{
					enchantCountDefaultValue = this.enchantCount_;
				}
				else
				{
					enchantCountDefaultValue = EnchantedAffixParams.EnchantCountDefaultValue;
				}
				return enchantCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.enchantCount_ = value;
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x06002472 RID: 9330 RVA: 0x0008D6D4 File Offset: 0x0008B8D4
		[DebuggerNonUserCode]
		public bool HasEnchantCount
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002473 RID: 9331 RVA: 0x0008D6F1 File Offset: 0x0008B8F1
		[DebuggerNonUserCode]
		public void ClearEnchantCount()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x06002474 RID: 9332 RVA: 0x0008D704 File Offset: 0x0008B904
		// (set) Token: 0x06002475 RID: 9333 RVA: 0x0008D735 File Offset: 0x0008B935
		[DebuggerNonUserCode]
		public int EnchantedReplacedAffix
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int enchantedReplacedAffixDefaultValue;
				if (flag)
				{
					enchantedReplacedAffixDefaultValue = this.enchantedReplacedAffix_;
				}
				else
				{
					enchantedReplacedAffixDefaultValue = EnchantedAffixParams.EnchantedReplacedAffixDefaultValue;
				}
				return enchantedReplacedAffixDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.enchantedReplacedAffix_ = value;
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x06002476 RID: 9334 RVA: 0x0008D750 File Offset: 0x0008B950
		[DebuggerNonUserCode]
		public bool HasEnchantedReplacedAffix
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002477 RID: 9335 RVA: 0x0008D76D File Offset: 0x0008B96D
		[DebuggerNonUserCode]
		public void ClearEnchantedReplacedAffix()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x06002478 RID: 9336 RVA: 0x0008D780 File Offset: 0x0008B980
		// (set) Token: 0x06002479 RID: 9337 RVA: 0x0008D7B1 File Offset: 0x0008B9B1
		[DebuggerNonUserCode]
		public int EnchantedAffix
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int enchantedAffixDefaultValue;
				if (flag)
				{
					enchantedAffixDefaultValue = this.enchantedAffix_;
				}
				else
				{
					enchantedAffixDefaultValue = EnchantedAffixParams.EnchantedAffixDefaultValue;
				}
				return enchantedAffixDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.enchantedAffix_ = value;
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x0600247A RID: 9338 RVA: 0x0008D7CC File Offset: 0x0008B9CC
		[DebuggerNonUserCode]
		public bool HasEnchantedAffix
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600247B RID: 9339 RVA: 0x0008D7E9 File Offset: 0x0008B9E9
		[DebuggerNonUserCode]
		public void ClearEnchantedAffix()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x0600247C RID: 9340 RVA: 0x0008D7FC File Offset: 0x0008B9FC
		// (set) Token: 0x0600247D RID: 9341 RVA: 0x0008D82D File Offset: 0x0008BA2D
		[DebuggerNonUserCode]
		public uint EnchantedAffixSeed
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint enchantedAffixSeedDefaultValue;
				if (flag)
				{
					enchantedAffixSeedDefaultValue = this.enchantedAffixSeed_;
				}
				else
				{
					enchantedAffixSeedDefaultValue = EnchantedAffixParams.EnchantedAffixSeedDefaultValue;
				}
				return enchantedAffixSeedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.enchantedAffixSeed_ = value;
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x0600247E RID: 9342 RVA: 0x0008D848 File Offset: 0x0008BA48
		[DebuggerNonUserCode]
		public bool HasEnchantedAffixSeed
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600247F RID: 9343 RVA: 0x0008D865 File Offset: 0x0008BA65
		[DebuggerNonUserCode]
		public void ClearEnchantedAffixSeed()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06002480 RID: 9344 RVA: 0x0008D878 File Offset: 0x0008BA78
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnchantedAffixParams);
		}

		// Token: 0x06002481 RID: 9345 RVA: 0x0008D898 File Offset: 0x0008BA98
		[DebuggerNonUserCode]
		public bool Equals(EnchantedAffixParams other)
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
					bool flag4 = this.EnchantCount != other.EnchantCount;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.EnchantedReplacedAffix != other.EnchantedReplacedAffix;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.EnchantedAffix != other.EnchantedAffix;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.EnchantedAffixSeed != other.EnchantedAffixSeed;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002482 RID: 9346 RVA: 0x0008D944 File Offset: 0x0008BB44
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasEnchantCount = this.HasEnchantCount;
			if (hasEnchantCount)
			{
				num ^= this.EnchantCount.GetHashCode();
			}
			bool hasEnchantedReplacedAffix = this.HasEnchantedReplacedAffix;
			if (hasEnchantedReplacedAffix)
			{
				num ^= this.EnchantedReplacedAffix.GetHashCode();
			}
			bool hasEnchantedAffix = this.HasEnchantedAffix;
			if (hasEnchantedAffix)
			{
				num ^= this.EnchantedAffix.GetHashCode();
			}
			bool hasEnchantedAffixSeed = this.HasEnchantedAffixSeed;
			if (hasEnchantedAffixSeed)
			{
				num ^= this.EnchantedAffixSeed.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002483 RID: 9347 RVA: 0x0008D9EC File Offset: 0x0008BBEC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002484 RID: 9348 RVA: 0x0008DA04 File Offset: 0x0008BC04
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002485 RID: 9349 RVA: 0x0008DA10 File Offset: 0x0008BC10
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasEnchantCount = this.HasEnchantCount;
			if (hasEnchantCount)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.EnchantCount);
			}
			bool hasEnchantedReplacedAffix = this.HasEnchantedReplacedAffix;
			if (hasEnchantedReplacedAffix)
			{
				output.WriteRawTag(21);
				output.WriteSFixed32(this.EnchantedReplacedAffix);
			}
			bool hasEnchantedAffix = this.HasEnchantedAffix;
			if (hasEnchantedAffix)
			{
				output.WriteRawTag(29);
				output.WriteSFixed32(this.EnchantedAffix);
			}
			bool hasEnchantedAffixSeed = this.HasEnchantedAffixSeed;
			if (hasEnchantedAffixSeed)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.EnchantedAffixSeed);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002486 RID: 9350 RVA: 0x0008DAC4 File Offset: 0x0008BCC4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasEnchantCount = this.HasEnchantCount;
			if (hasEnchantCount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EnchantCount);
			}
			bool hasEnchantedReplacedAffix = this.HasEnchantedReplacedAffix;
			if (hasEnchantedReplacedAffix)
			{
				num += 5;
			}
			bool hasEnchantedAffix = this.HasEnchantedAffix;
			if (hasEnchantedAffix)
			{
				num += 5;
			}
			bool hasEnchantedAffixSeed = this.HasEnchantedAffixSeed;
			if (hasEnchantedAffixSeed)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EnchantedAffixSeed);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002487 RID: 9351 RVA: 0x0008DB54 File Offset: 0x0008BD54
		[DebuggerNonUserCode]
		public void MergeFrom(EnchantedAffixParams other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasEnchantCount = other.HasEnchantCount;
				if (hasEnchantCount)
				{
					this.EnchantCount = other.EnchantCount;
				}
				bool hasEnchantedReplacedAffix = other.HasEnchantedReplacedAffix;
				if (hasEnchantedReplacedAffix)
				{
					this.EnchantedReplacedAffix = other.EnchantedReplacedAffix;
				}
				bool hasEnchantedAffix = other.HasEnchantedAffix;
				if (hasEnchantedAffix)
				{
					this.EnchantedAffix = other.EnchantedAffix;
				}
				bool hasEnchantedAffixSeed = other.HasEnchantedAffixSeed;
				if (hasEnchantedAffixSeed)
				{
					this.EnchantedAffixSeed = other.EnchantedAffixSeed;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002488 RID: 9352 RVA: 0x0008DBEA File Offset: 0x0008BDEA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002489 RID: 9353 RVA: 0x0008DBF8 File Offset: 0x0008BDF8
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
					if (num3 != 8U)
					{
						if (num3 != 21U)
						{
							goto IL_0028;
						}
						this.EnchantedReplacedAffix = input.ReadSFixed32();
					}
					else
					{
						this.EnchantCount = input.ReadUInt32();
					}
				}
				else if (num3 != 29U)
				{
					if (num3 != 32U)
					{
						goto IL_0028;
					}
					this.EnchantedAffixSeed = input.ReadUInt32();
				}
				else
				{
					this.EnchantedAffix = input.ReadSFixed32();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000FFC RID: 4092
		private static readonly MessageParser<EnchantedAffixParams> _parser = new MessageParser<EnchantedAffixParams>(() => new EnchantedAffixParams());

		// Token: 0x04000FFD RID: 4093
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000FFE RID: 4094
		private int _hasBits0;

		// Token: 0x04000FFF RID: 4095
		public const int EnchantCountFieldNumber = 1;

		// Token: 0x04001000 RID: 4096
		private static readonly uint EnchantCountDefaultValue = 0U;

		// Token: 0x04001001 RID: 4097
		private uint enchantCount_;

		// Token: 0x04001002 RID: 4098
		public const int EnchantedReplacedAffixFieldNumber = 2;

		// Token: 0x04001003 RID: 4099
		private static readonly int EnchantedReplacedAffixDefaultValue = -1;

		// Token: 0x04001004 RID: 4100
		private int enchantedReplacedAffix_;

		// Token: 0x04001005 RID: 4101
		public const int EnchantedAffixFieldNumber = 3;

		// Token: 0x04001006 RID: 4102
		private static readonly int EnchantedAffixDefaultValue = -1;

		// Token: 0x04001007 RID: 4103
		private int enchantedAffix_;

		// Token: 0x04001008 RID: 4104
		public const int EnchantedAffixSeedFieldNumber = 4;

		// Token: 0x04001009 RID: 4105
		private static readonly uint EnchantedAffixSeedDefaultValue = 0U;

		// Token: 0x0400100A RID: 4106
		private uint enchantedAffixSeed_;
	}
}
