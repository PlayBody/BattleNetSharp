using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Hireling
{
	// Token: 0x02000176 RID: 374
	public sealed class Info : IMessage<Info>, IMessage, IEquatable<Info>, IDeepCloneable<Info>, IBufferMessage
	{
		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x060026C9 RID: 9929 RVA: 0x000968C4 File Offset: 0x00094AC4
		[DebuggerNonUserCode]
		public static MessageParser<Info> Parser
		{
			get
			{
				return Info._parser;
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x060026CA RID: 9930 RVA: 0x000968DC File Offset: 0x00094ADC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HirelingReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x060026CB RID: 9931 RVA: 0x00096900 File Offset: 0x00094B00
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Info.Descriptor;
			}
		}

		// Token: 0x060026CC RID: 9932 RVA: 0x00096917 File Offset: 0x00094B17
		[DebuggerNonUserCode]
		public Info()
		{
		}

		// Token: 0x060026CD RID: 9933 RVA: 0x0009692C File Offset: 0x00094B2C
		[DebuggerNonUserCode]
		public Info(Info other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.hirelingClass_ = other.hirelingClass_;
			this.gbidName_ = other.gbidName_;
			this.levelDeprecated_ = other.levelDeprecated_;
			this.attributeExperienceNextDeprecated_ = other.attributeExperienceNextDeprecated_;
			this.powerKeyParams_ = other.powerKeyParams_.Clone();
			this.dead_ = other.dead_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060026CE RID: 9934 RVA: 0x000969AC File Offset: 0x00094BAC
		[DebuggerNonUserCode]
		public Info Clone()
		{
			return new Info(this);
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x060026CF RID: 9935 RVA: 0x000969C4 File Offset: 0x00094BC4
		// (set) Token: 0x060026D0 RID: 9936 RVA: 0x000969F5 File Offset: 0x00094BF5
		[DebuggerNonUserCode]
		public int HirelingClass
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int hirelingClassDefaultValue;
				if (flag)
				{
					hirelingClassDefaultValue = this.hirelingClass_;
				}
				else
				{
					hirelingClassDefaultValue = Info.HirelingClassDefaultValue;
				}
				return hirelingClassDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.hirelingClass_ = value;
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x060026D1 RID: 9937 RVA: 0x00096A10 File Offset: 0x00094C10
		[DebuggerNonUserCode]
		public bool HasHirelingClass
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x00096A2D File Offset: 0x00094C2D
		[DebuggerNonUserCode]
		public void ClearHirelingClass()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x060026D3 RID: 9939 RVA: 0x00096A40 File Offset: 0x00094C40
		// (set) Token: 0x060026D4 RID: 9940 RVA: 0x00096A71 File Offset: 0x00094C71
		[DebuggerNonUserCode]
		public int GbidName
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int gbidNameDefaultValue;
				if (flag)
				{
					gbidNameDefaultValue = this.gbidName_;
				}
				else
				{
					gbidNameDefaultValue = Info.GbidNameDefaultValue;
				}
				return gbidNameDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.gbidName_ = value;
			}
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x060026D5 RID: 9941 RVA: 0x00096A8C File Offset: 0x00094C8C
		[DebuggerNonUserCode]
		public bool HasGbidName
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060026D6 RID: 9942 RVA: 0x00096AA9 File Offset: 0x00094CA9
		[DebuggerNonUserCode]
		public void ClearGbidName()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x060026D7 RID: 9943 RVA: 0x00096ABC File Offset: 0x00094CBC
		// (set) Token: 0x060026D8 RID: 9944 RVA: 0x00096AED File Offset: 0x00094CED
		[DebuggerNonUserCode]
		public int LevelDeprecated
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int levelDeprecatedDefaultValue;
				if (flag)
				{
					levelDeprecatedDefaultValue = this.levelDeprecated_;
				}
				else
				{
					levelDeprecatedDefaultValue = Info.LevelDeprecatedDefaultValue;
				}
				return levelDeprecatedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.levelDeprecated_ = value;
			}
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x060026D9 RID: 9945 RVA: 0x00096B08 File Offset: 0x00094D08
		[DebuggerNonUserCode]
		public bool HasLevelDeprecated
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060026DA RID: 9946 RVA: 0x00096B25 File Offset: 0x00094D25
		[DebuggerNonUserCode]
		public void ClearLevelDeprecated()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x060026DB RID: 9947 RVA: 0x00096B38 File Offset: 0x00094D38
		// (set) Token: 0x060026DC RID: 9948 RVA: 0x00096B69 File Offset: 0x00094D69
		[DebuggerNonUserCode]
		public uint AttributeExperienceNextDeprecated
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint attributeExperienceNextDeprecatedDefaultValue;
				if (flag)
				{
					attributeExperienceNextDeprecatedDefaultValue = this.attributeExperienceNextDeprecated_;
				}
				else
				{
					attributeExperienceNextDeprecatedDefaultValue = Info.AttributeExperienceNextDeprecatedDefaultValue;
				}
				return attributeExperienceNextDeprecatedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.attributeExperienceNextDeprecated_ = value;
			}
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x060026DD RID: 9949 RVA: 0x00096B84 File Offset: 0x00094D84
		[DebuggerNonUserCode]
		public bool HasAttributeExperienceNextDeprecated
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060026DE RID: 9950 RVA: 0x00096BA1 File Offset: 0x00094DA1
		[DebuggerNonUserCode]
		public void ClearAttributeExperienceNextDeprecated()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x060026DF RID: 9951 RVA: 0x00096BB4 File Offset: 0x00094DB4
		[DebuggerNonUserCode]
		public RepeatedField<int> PowerKeyParams
		{
			get
			{
				return this.powerKeyParams_;
			}
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x060026E0 RID: 9952 RVA: 0x00096BCC File Offset: 0x00094DCC
		// (set) Token: 0x060026E1 RID: 9953 RVA: 0x00096BFE File Offset: 0x00094DFE
		[DebuggerNonUserCode]
		public bool Dead
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool deadDefaultValue;
				if (flag)
				{
					deadDefaultValue = this.dead_;
				}
				else
				{
					deadDefaultValue = Info.DeadDefaultValue;
				}
				return deadDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.dead_ = value;
			}
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x060026E2 RID: 9954 RVA: 0x00096C18 File Offset: 0x00094E18
		[DebuggerNonUserCode]
		public bool HasDead
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x060026E3 RID: 9955 RVA: 0x00096C36 File Offset: 0x00094E36
		[DebuggerNonUserCode]
		public void ClearDead()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x00096C48 File Offset: 0x00094E48
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Info);
		}

		// Token: 0x060026E5 RID: 9957 RVA: 0x00096C68 File Offset: 0x00094E68
		[DebuggerNonUserCode]
		public bool Equals(Info other)
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
					bool flag4 = this.HirelingClass != other.HirelingClass;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.GbidName != other.GbidName;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.LevelDeprecated != other.LevelDeprecated;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.AttributeExperienceNextDeprecated != other.AttributeExperienceNextDeprecated;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.powerKeyParams_.Equals(other.powerKeyParams_);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.Dead != other.Dead;
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

		// Token: 0x060026E6 RID: 9958 RVA: 0x00096D54 File Offset: 0x00094F54
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasHirelingClass = this.HasHirelingClass;
			if (hasHirelingClass)
			{
				num ^= this.HirelingClass.GetHashCode();
			}
			bool hasGbidName = this.HasGbidName;
			if (hasGbidName)
			{
				num ^= this.GbidName.GetHashCode();
			}
			bool hasLevelDeprecated = this.HasLevelDeprecated;
			if (hasLevelDeprecated)
			{
				num ^= this.LevelDeprecated.GetHashCode();
			}
			bool hasAttributeExperienceNextDeprecated = this.HasAttributeExperienceNextDeprecated;
			if (hasAttributeExperienceNextDeprecated)
			{
				num ^= this.AttributeExperienceNextDeprecated.GetHashCode();
			}
			num ^= this.powerKeyParams_.GetHashCode();
			bool hasDead = this.HasDead;
			if (hasDead)
			{
				num ^= this.Dead.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060026E7 RID: 9959 RVA: 0x00096E28 File Offset: 0x00095028
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060026E8 RID: 9960 RVA: 0x00096E40 File Offset: 0x00095040
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x00096E4C File Offset: 0x0009504C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasHirelingClass = this.HasHirelingClass;
			if (hasHirelingClass)
			{
				output.WriteRawTag(8);
				output.WriteSInt32(this.HirelingClass);
			}
			bool hasGbidName = this.HasGbidName;
			if (hasGbidName)
			{
				output.WriteRawTag(21);
				output.WriteSFixed32(this.GbidName);
			}
			bool hasLevelDeprecated = this.HasLevelDeprecated;
			if (hasLevelDeprecated)
			{
				output.WriteRawTag(24);
				output.WriteSInt32(this.LevelDeprecated);
			}
			bool hasAttributeExperienceNextDeprecated = this.HasAttributeExperienceNextDeprecated;
			if (hasAttributeExperienceNextDeprecated)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.AttributeExperienceNextDeprecated);
			}
			this.powerKeyParams_.WriteTo(ref output, Info._repeated_powerKeyParams_codec);
			bool hasDead = this.HasDead;
			if (hasDead)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.Dead);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x00096F38 File Offset: 0x00095138
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasHirelingClass = this.HasHirelingClass;
			if (hasHirelingClass)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.HirelingClass);
			}
			bool hasGbidName = this.HasGbidName;
			if (hasGbidName)
			{
				num += 5;
			}
			bool hasLevelDeprecated = this.HasLevelDeprecated;
			if (hasLevelDeprecated)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.LevelDeprecated);
			}
			bool hasAttributeExperienceNextDeprecated = this.HasAttributeExperienceNextDeprecated;
			if (hasAttributeExperienceNextDeprecated)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AttributeExperienceNextDeprecated);
			}
			num += this.powerKeyParams_.CalculateSize(Info._repeated_powerKeyParams_codec);
			bool hasDead = this.HasDead;
			if (hasDead)
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

		// Token: 0x060026EB RID: 9963 RVA: 0x00096FFC File Offset: 0x000951FC
		[DebuggerNonUserCode]
		public void MergeFrom(Info other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasHirelingClass = other.HasHirelingClass;
				if (hasHirelingClass)
				{
					this.HirelingClass = other.HirelingClass;
				}
				bool hasGbidName = other.HasGbidName;
				if (hasGbidName)
				{
					this.GbidName = other.GbidName;
				}
				bool hasLevelDeprecated = other.HasLevelDeprecated;
				if (hasLevelDeprecated)
				{
					this.LevelDeprecated = other.LevelDeprecated;
				}
				bool hasAttributeExperienceNextDeprecated = other.HasAttributeExperienceNextDeprecated;
				if (hasAttributeExperienceNextDeprecated)
				{
					this.AttributeExperienceNextDeprecated = other.AttributeExperienceNextDeprecated;
				}
				this.powerKeyParams_.Add(other.powerKeyParams_);
				bool hasDead = other.HasDead;
				if (hasDead)
				{
					this.Dead = other.Dead;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x000970C2 File Offset: 0x000952C2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x000970D0 File Offset: 0x000952D0
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
					if (num3 != 8U)
					{
						if (num3 != 21U)
						{
							if (num3 != 24U)
							{
								goto IL_0045;
							}
							this.LevelDeprecated = input.ReadSInt32();
						}
						else
						{
							this.GbidName = input.ReadSFixed32();
						}
					}
					else
					{
						this.HirelingClass = input.ReadSInt32();
					}
				}
				else
				{
					if (num3 <= 40U)
					{
						if (num3 == 32U)
						{
							this.AttributeExperienceNextDeprecated = input.ReadUInt32();
							continue;
						}
						if (num3 != 40U)
						{
							goto IL_0045;
						}
					}
					else if (num3 != 42U)
					{
						if (num3 != 48U)
						{
							goto IL_0045;
						}
						this.Dead = input.ReadBool();
						continue;
					}
					this.powerKeyParams_.AddEntriesFrom(ref input, Info._repeated_powerKeyParams_codec);
				}
				continue;
				IL_0045:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001123 RID: 4387
		private static readonly MessageParser<Info> _parser = new MessageParser<Info>(() => new Info());

		// Token: 0x04001124 RID: 4388
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001125 RID: 4389
		private int _hasBits0;

		// Token: 0x04001126 RID: 4390
		public const int HirelingClassFieldNumber = 1;

		// Token: 0x04001127 RID: 4391
		private static readonly int HirelingClassDefaultValue = 0;

		// Token: 0x04001128 RID: 4392
		private int hirelingClass_;

		// Token: 0x04001129 RID: 4393
		public const int GbidNameFieldNumber = 2;

		// Token: 0x0400112A RID: 4394
		private static readonly int GbidNameDefaultValue = -1;

		// Token: 0x0400112B RID: 4395
		private int gbidName_;

		// Token: 0x0400112C RID: 4396
		public const int LevelDeprecatedFieldNumber = 3;

		// Token: 0x0400112D RID: 4397
		private static readonly int LevelDeprecatedDefaultValue = 0;

		// Token: 0x0400112E RID: 4398
		private int levelDeprecated_;

		// Token: 0x0400112F RID: 4399
		public const int AttributeExperienceNextDeprecatedFieldNumber = 4;

		// Token: 0x04001130 RID: 4400
		private static readonly uint AttributeExperienceNextDeprecatedDefaultValue = 0U;

		// Token: 0x04001131 RID: 4401
		private uint attributeExperienceNextDeprecated_;

		// Token: 0x04001132 RID: 4402
		public const int PowerKeyParamsFieldNumber = 5;

		// Token: 0x04001133 RID: 4403
		private static readonly FieldCodec<int> _repeated_powerKeyParams_codec = FieldCodec.ForSInt32(40U);

		// Token: 0x04001134 RID: 4404
		private readonly RepeatedField<int> powerKeyParams_ = new RepeatedField<int>();

		// Token: 0x04001135 RID: 4405
		public const int DeadFieldNumber = 6;

		// Token: 0x04001136 RID: 4406
		private static readonly bool DeadDefaultValue = false;

		// Token: 0x04001137 RID: 4407
		private bool dead_;
	}
}
