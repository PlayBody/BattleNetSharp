using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.ItemCrafting
{
	// Token: 0x02000171 RID: 369
	public sealed class CrafterData : IMessage<CrafterData>, IMessage, IEquatable<CrafterData>, IDeepCloneable<CrafterData>, IBufferMessage
	{
		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x06002666 RID: 9830 RVA: 0x00095248 File Offset: 0x00093448
		[DebuggerNonUserCode]
		public static MessageParser<CrafterData> Parser
		{
			get
			{
				return CrafterData._parser;
			}
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x06002667 RID: 9831 RVA: 0x00095260 File Offset: 0x00093460
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ItemCraftingReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x06002668 RID: 9832 RVA: 0x00095284 File Offset: 0x00093484
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CrafterData.Descriptor;
			}
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x0009529B File Offset: 0x0009349B
		[DebuggerNonUserCode]
		public CrafterData()
		{
		}

		// Token: 0x0600266A RID: 9834 RVA: 0x000952C8 File Offset: 0x000934C8
		[DebuggerNonUserCode]
		public CrafterData(CrafterData other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.recipes_ = other.recipes_.Clone();
			this.deprecatedAvailableEnchants_ = other.deprecatedAvailableEnchants_.Clone();
			this.cooldownEnd_ = other.cooldownEnd_;
			this.recipesBitfield_ = other.recipesBitfield_;
			this.bitfieldLeadingNullBytes_ = other.bitfieldLeadingNullBytes_;
			this.talents_ = other.talents_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600266B RID: 9835 RVA: 0x00095354 File Offset: 0x00093554
		[DebuggerNonUserCode]
		public CrafterData Clone()
		{
			return new CrafterData(this);
		}

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x0600266C RID: 9836 RVA: 0x0009536C File Offset: 0x0009356C
		[DebuggerNonUserCode]
		public RepeatedField<int> Recipes
		{
			get
			{
				return this.recipes_;
			}
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x0600266D RID: 9837 RVA: 0x00095384 File Offset: 0x00093584
		[DebuggerNonUserCode]
		public RepeatedField<int> DeprecatedAvailableEnchants
		{
			get
			{
				return this.deprecatedAvailableEnchants_;
			}
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x0600266E RID: 9838 RVA: 0x0009539C File Offset: 0x0009359C
		// (set) Token: 0x0600266F RID: 9839 RVA: 0x000953CD File Offset: 0x000935CD
		[DebuggerNonUserCode]
		public long CooldownEnd
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				long cooldownEndDefaultValue;
				if (flag)
				{
					cooldownEndDefaultValue = this.cooldownEnd_;
				}
				else
				{
					cooldownEndDefaultValue = CrafterData.CooldownEndDefaultValue;
				}
				return cooldownEndDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.cooldownEnd_ = value;
			}
		}

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x06002670 RID: 9840 RVA: 0x000953E8 File Offset: 0x000935E8
		[DebuggerNonUserCode]
		public bool HasCooldownEnd
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x00095405 File Offset: 0x00093605
		[DebuggerNonUserCode]
		public void ClearCooldownEnd()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x06002672 RID: 9842 RVA: 0x00095418 File Offset: 0x00093618
		// (set) Token: 0x06002673 RID: 9843 RVA: 0x00095439 File Offset: 0x00093639
		[DebuggerNonUserCode]
		public ByteString RecipesBitfield
		{
			get
			{
				return this.recipesBitfield_ ?? CrafterData.RecipesBitfieldDefaultValue;
			}
			set
			{
				this.recipesBitfield_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x06002674 RID: 9844 RVA: 0x00095450 File Offset: 0x00093650
		[DebuggerNonUserCode]
		public bool HasRecipesBitfield
		{
			get
			{
				return this.recipesBitfield_ != null;
			}
		}

		// Token: 0x06002675 RID: 9845 RVA: 0x0009546E File Offset: 0x0009366E
		[DebuggerNonUserCode]
		public void ClearRecipesBitfield()
		{
			this.recipesBitfield_ = null;
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x06002676 RID: 9846 RVA: 0x00095478 File Offset: 0x00093678
		// (set) Token: 0x06002677 RID: 9847 RVA: 0x000954A9 File Offset: 0x000936A9
		[DebuggerNonUserCode]
		public int BitfieldLeadingNullBytes
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int bitfieldLeadingNullBytesDefaultValue;
				if (flag)
				{
					bitfieldLeadingNullBytesDefaultValue = this.bitfieldLeadingNullBytes_;
				}
				else
				{
					bitfieldLeadingNullBytesDefaultValue = CrafterData.BitfieldLeadingNullBytesDefaultValue;
				}
				return bitfieldLeadingNullBytesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.bitfieldLeadingNullBytes_ = value;
			}
		}

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x06002678 RID: 9848 RVA: 0x000954C4 File Offset: 0x000936C4
		[DebuggerNonUserCode]
		public bool HasBitfieldLeadingNullBytes
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002679 RID: 9849 RVA: 0x000954E1 File Offset: 0x000936E1
		[DebuggerNonUserCode]
		public void ClearBitfieldLeadingNullBytes()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x0600267A RID: 9850 RVA: 0x000954F4 File Offset: 0x000936F4
		[DebuggerNonUserCode]
		public RepeatedField<uint> Talents
		{
			get
			{
				return this.talents_;
			}
		}

		// Token: 0x0600267B RID: 9851 RVA: 0x0009550C File Offset: 0x0009370C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CrafterData);
		}

		// Token: 0x0600267C RID: 9852 RVA: 0x0009552C File Offset: 0x0009372C
		[DebuggerNonUserCode]
		public bool Equals(CrafterData other)
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
					bool flag4 = !this.recipes_.Equals(other.recipes_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.deprecatedAvailableEnchants_.Equals(other.deprecatedAvailableEnchants_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.CooldownEnd != other.CooldownEnd;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.RecipesBitfield != other.RecipesBitfield;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.BitfieldLeadingNullBytes != other.BitfieldLeadingNullBytes;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !this.talents_.Equals(other.talents_);
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

		// Token: 0x0600267D RID: 9853 RVA: 0x00095620 File Offset: 0x00093820
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.recipes_.GetHashCode();
			num ^= this.deprecatedAvailableEnchants_.GetHashCode();
			bool hasCooldownEnd = this.HasCooldownEnd;
			if (hasCooldownEnd)
			{
				num ^= this.CooldownEnd.GetHashCode();
			}
			bool hasRecipesBitfield = this.HasRecipesBitfield;
			if (hasRecipesBitfield)
			{
				num ^= this.RecipesBitfield.GetHashCode();
			}
			bool hasBitfieldLeadingNullBytes = this.HasBitfieldLeadingNullBytes;
			if (hasBitfieldLeadingNullBytes)
			{
				num ^= this.BitfieldLeadingNullBytes.GetHashCode();
			}
			num ^= this.talents_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600267E RID: 9854 RVA: 0x000956D4 File Offset: 0x000938D4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600267F RID: 9855 RVA: 0x000956EC File Offset: 0x000938EC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002680 RID: 9856 RVA: 0x000956F8 File Offset: 0x000938F8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.recipes_.WriteTo(ref output, CrafterData._repeated_recipes_codec);
			this.deprecatedAvailableEnchants_.WriteTo(ref output, CrafterData._repeated_deprecatedAvailableEnchants_codec);
			bool hasCooldownEnd = this.HasCooldownEnd;
			if (hasCooldownEnd)
			{
				output.WriteRawTag(33);
				output.WriteSFixed64(this.CooldownEnd);
			}
			bool hasRecipesBitfield = this.HasRecipesBitfield;
			if (hasRecipesBitfield)
			{
				output.WriteRawTag(42);
				output.WriteBytes(this.RecipesBitfield);
			}
			bool hasBitfieldLeadingNullBytes = this.HasBitfieldLeadingNullBytes;
			if (hasBitfieldLeadingNullBytes)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.BitfieldLeadingNullBytes);
			}
			this.talents_.WriteTo(ref output, CrafterData._repeated_talents_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002681 RID: 9857 RVA: 0x000957C0 File Offset: 0x000939C0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.recipes_.CalculateSize(CrafterData._repeated_recipes_codec);
			num += this.deprecatedAvailableEnchants_.CalculateSize(CrafterData._repeated_deprecatedAvailableEnchants_codec);
			bool hasCooldownEnd = this.HasCooldownEnd;
			if (hasCooldownEnd)
			{
				num += 9;
			}
			bool hasRecipesBitfield = this.HasRecipesBitfield;
			if (hasRecipesBitfield)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.RecipesBitfield);
			}
			bool hasBitfieldLeadingNullBytes = this.HasBitfieldLeadingNullBytes;
			if (hasBitfieldLeadingNullBytes)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BitfieldLeadingNullBytes);
			}
			num += this.talents_.CalculateSize(CrafterData._repeated_talents_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002682 RID: 9858 RVA: 0x00095878 File Offset: 0x00093A78
		[DebuggerNonUserCode]
		public void MergeFrom(CrafterData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.recipes_.Add(other.recipes_);
				this.deprecatedAvailableEnchants_.Add(other.deprecatedAvailableEnchants_);
				bool hasCooldownEnd = other.HasCooldownEnd;
				if (hasCooldownEnd)
				{
					this.CooldownEnd = other.CooldownEnd;
				}
				bool hasRecipesBitfield = other.HasRecipesBitfield;
				if (hasRecipesBitfield)
				{
					this.RecipesBitfield = other.RecipesBitfield;
				}
				bool hasBitfieldLeadingNullBytes = other.HasBitfieldLeadingNullBytes;
				if (hasBitfieldLeadingNullBytes)
				{
					this.BitfieldLeadingNullBytes = other.BitfieldLeadingNullBytes;
				}
				this.talents_.Add(other.talents_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002683 RID: 9859 RVA: 0x0009592C File Offset: 0x00093B2C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002684 RID: 9860 RVA: 0x00095938 File Offset: 0x00093B38
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
					if (num3 <= 13U)
					{
						if (num3 != 10U && num3 != 13U)
						{
							goto IL_0059;
						}
						this.recipes_.AddEntriesFrom(ref input, CrafterData._repeated_recipes_codec);
					}
					else
					{
						if (num3 != 18U && num3 != 21U)
						{
							goto IL_0059;
						}
						this.deprecatedAvailableEnchants_.AddEntriesFrom(ref input, CrafterData._repeated_deprecatedAvailableEnchants_codec);
					}
				}
				else if (num3 <= 42U)
				{
					if (num3 != 33U)
					{
						if (num3 != 42U)
						{
							goto IL_0059;
						}
						this.RecipesBitfield = input.ReadBytes();
					}
					else
					{
						this.CooldownEnd = input.ReadSFixed64();
					}
				}
				else if (num3 != 48U)
				{
					if (num3 != 56U && num3 != 58U)
					{
						goto IL_0059;
					}
					this.talents_.AddEntriesFrom(ref input, CrafterData._repeated_talents_codec);
				}
				else
				{
					this.BitfieldLeadingNullBytes = input.ReadInt32();
				}
				continue;
				IL_0059:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040010F6 RID: 4342
		private static readonly MessageParser<CrafterData> _parser = new MessageParser<CrafterData>(() => new CrafterData());

		// Token: 0x040010F7 RID: 4343
		private UnknownFieldSet _unknownFields;

		// Token: 0x040010F8 RID: 4344
		private int _hasBits0;

		// Token: 0x040010F9 RID: 4345
		public const int RecipesFieldNumber = 1;

		// Token: 0x040010FA RID: 4346
		private static readonly FieldCodec<int> _repeated_recipes_codec = FieldCodec.ForSFixed32(13U);

		// Token: 0x040010FB RID: 4347
		private readonly RepeatedField<int> recipes_ = new RepeatedField<int>();

		// Token: 0x040010FC RID: 4348
		public const int DeprecatedAvailableEnchantsFieldNumber = 2;

		// Token: 0x040010FD RID: 4349
		private static readonly FieldCodec<int> _repeated_deprecatedAvailableEnchants_codec = FieldCodec.ForSFixed32(21U);

		// Token: 0x040010FE RID: 4350
		private readonly RepeatedField<int> deprecatedAvailableEnchants_ = new RepeatedField<int>();

		// Token: 0x040010FF RID: 4351
		public const int CooldownEndFieldNumber = 4;

		// Token: 0x04001100 RID: 4352
		private static readonly long CooldownEndDefaultValue = 0L;

		// Token: 0x04001101 RID: 4353
		private long cooldownEnd_;

		// Token: 0x04001102 RID: 4354
		public const int RecipesBitfieldFieldNumber = 5;

		// Token: 0x04001103 RID: 4355
		private static readonly ByteString RecipesBitfieldDefaultValue = ByteString.Empty;

		// Token: 0x04001104 RID: 4356
		private ByteString recipesBitfield_;

		// Token: 0x04001105 RID: 4357
		public const int BitfieldLeadingNullBytesFieldNumber = 6;

		// Token: 0x04001106 RID: 4358
		private static readonly int BitfieldLeadingNullBytesDefaultValue = 0;

		// Token: 0x04001107 RID: 4359
		private int bitfieldLeadingNullBytes_;

		// Token: 0x04001108 RID: 4360
		public const int TalentsFieldNumber = 7;

		// Token: 0x04001109 RID: 4361
		private static readonly FieldCodec<uint> _repeated_talents_codec = FieldCodec.ForUInt32(56U);

		// Token: 0x0400110A RID: 4362
		private readonly RepeatedField<uint> talents_ = new RepeatedField<uint>();
	}
}
