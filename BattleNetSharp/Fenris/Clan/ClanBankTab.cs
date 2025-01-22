using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Clan
{
	// Token: 0x020002B3 RID: 691
	public sealed class ClanBankTab : IMessage<ClanBankTab>, IMessage, IEquatable<ClanBankTab>, IDeepCloneable<ClanBankTab>, IBufferMessage
	{
		// Token: 0x1700175C RID: 5980
		// (get) Token: 0x06004983 RID: 18819 RVA: 0x00119E44 File Offset: 0x00118044
		[DebuggerNonUserCode]
		public static MessageParser<ClanBankTab> Parser
		{
			get
			{
				return ClanBankTab._parser;
			}
		}

		// Token: 0x1700175D RID: 5981
		// (get) Token: 0x06004984 RID: 18820 RVA: 0x00119E5C File Offset: 0x0011805C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClanReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x1700175E RID: 5982
		// (get) Token: 0x06004985 RID: 18821 RVA: 0x00119E80 File Offset: 0x00118080
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClanBankTab.Descriptor;
			}
		}

		// Token: 0x06004986 RID: 18822 RVA: 0x00119E97 File Offset: 0x00118097
		[DebuggerNonUserCode]
		public ClanBankTab()
		{
		}

		// Token: 0x06004987 RID: 18823 RVA: 0x00119EA4 File Offset: 0x001180A4
		[DebuggerNonUserCode]
		public ClanBankTab(ClanBankTab other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.index_ = other.index_;
			this.requiredRank_ = other.requiredRank_;
			this.iconIndex_ = other.iconIndex_;
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004988 RID: 18824 RVA: 0x00119F08 File Offset: 0x00118108
		[DebuggerNonUserCode]
		public ClanBankTab Clone()
		{
			return new ClanBankTab(this);
		}

		// Token: 0x1700175F RID: 5983
		// (get) Token: 0x06004989 RID: 18825 RVA: 0x00119F20 File Offset: 0x00118120
		// (set) Token: 0x0600498A RID: 18826 RVA: 0x00119F51 File Offset: 0x00118151
		[DebuggerNonUserCode]
		public uint Index
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint indexDefaultValue;
				if (flag)
				{
					indexDefaultValue = this.index_;
				}
				else
				{
					indexDefaultValue = ClanBankTab.IndexDefaultValue;
				}
				return indexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.index_ = value;
			}
		}

		// Token: 0x17001760 RID: 5984
		// (get) Token: 0x0600498B RID: 18827 RVA: 0x00119F6C File Offset: 0x0011816C
		[DebuggerNonUserCode]
		public bool HasIndex
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600498C RID: 18828 RVA: 0x00119F89 File Offset: 0x00118189
		[DebuggerNonUserCode]
		public void ClearIndex()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001761 RID: 5985
		// (get) Token: 0x0600498D RID: 18829 RVA: 0x00119F9C File Offset: 0x0011819C
		// (set) Token: 0x0600498E RID: 18830 RVA: 0x00119FCD File Offset: 0x001181CD
		[DebuggerNonUserCode]
		public ClanRank RequiredRank
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ClanRank requiredRankDefaultValue;
				if (flag)
				{
					requiredRankDefaultValue = this.requiredRank_;
				}
				else
				{
					requiredRankDefaultValue = ClanBankTab.RequiredRankDefaultValue;
				}
				return requiredRankDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.requiredRank_ = value;
			}
		}

		// Token: 0x17001762 RID: 5986
		// (get) Token: 0x0600498F RID: 18831 RVA: 0x00119FE8 File Offset: 0x001181E8
		[DebuggerNonUserCode]
		public bool HasRequiredRank
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004990 RID: 18832 RVA: 0x0011A005 File Offset: 0x00118205
		[DebuggerNonUserCode]
		public void ClearRequiredRank()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001763 RID: 5987
		// (get) Token: 0x06004991 RID: 18833 RVA: 0x0011A018 File Offset: 0x00118218
		// (set) Token: 0x06004992 RID: 18834 RVA: 0x0011A049 File Offset: 0x00118249
		[DebuggerNonUserCode]
		public uint IconIndex
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint iconIndexDefaultValue;
				if (flag)
				{
					iconIndexDefaultValue = this.iconIndex_;
				}
				else
				{
					iconIndexDefaultValue = ClanBankTab.IconIndexDefaultValue;
				}
				return iconIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.iconIndex_ = value;
			}
		}

		// Token: 0x17001764 RID: 5988
		// (get) Token: 0x06004993 RID: 18835 RVA: 0x0011A064 File Offset: 0x00118264
		[DebuggerNonUserCode]
		public bool HasIconIndex
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06004994 RID: 18836 RVA: 0x0011A081 File Offset: 0x00118281
		[DebuggerNonUserCode]
		public void ClearIconIndex()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001765 RID: 5989
		// (get) Token: 0x06004995 RID: 18837 RVA: 0x0011A094 File Offset: 0x00118294
		// (set) Token: 0x06004996 RID: 18838 RVA: 0x0011A0B5 File Offset: 0x001182B5
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? ClanBankTab.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001766 RID: 5990
		// (get) Token: 0x06004997 RID: 18839 RVA: 0x0011A0CC File Offset: 0x001182CC
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06004998 RID: 18840 RVA: 0x0011A0E7 File Offset: 0x001182E7
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x06004999 RID: 18841 RVA: 0x0011A0F4 File Offset: 0x001182F4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClanBankTab);
		}

		// Token: 0x0600499A RID: 18842 RVA: 0x0011A114 File Offset: 0x00118314
		[DebuggerNonUserCode]
		public bool Equals(ClanBankTab other)
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
					bool flag4 = this.Index != other.Index;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.RequiredRank != other.RequiredRank;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.IconIndex != other.IconIndex;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Name != other.Name;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600499B RID: 18843 RVA: 0x0011A1C0 File Offset: 0x001183C0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasIndex = this.HasIndex;
			if (hasIndex)
			{
				num ^= this.Index.GetHashCode();
			}
			bool hasRequiredRank = this.HasRequiredRank;
			if (hasRequiredRank)
			{
				num ^= this.RequiredRank.GetHashCode();
			}
			bool hasIconIndex = this.HasIconIndex;
			if (hasIconIndex)
			{
				num ^= this.IconIndex.GetHashCode();
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600499C RID: 18844 RVA: 0x0011A26C File Offset: 0x0011846C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600499D RID: 18845 RVA: 0x0011A284 File Offset: 0x00118484
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600499E RID: 18846 RVA: 0x0011A290 File Offset: 0x00118490
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasIndex = this.HasIndex;
			if (hasIndex)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Index);
			}
			bool hasRequiredRank = this.HasRequiredRank;
			if (hasRequiredRank)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.RequiredRank);
			}
			bool hasIconIndex = this.HasIconIndex;
			if (hasIconIndex)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.IconIndex);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Name);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600499F RID: 18847 RVA: 0x0011A344 File Offset: 0x00118544
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasIndex = this.HasIndex;
			if (hasIndex)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Index);
			}
			bool hasRequiredRank = this.HasRequiredRank;
			if (hasRequiredRank)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.RequiredRank);
			}
			bool hasIconIndex = this.HasIconIndex;
			if (hasIconIndex)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IconIndex);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060049A0 RID: 18848 RVA: 0x0011A3EC File Offset: 0x001185EC
		[DebuggerNonUserCode]
		public void MergeFrom(ClanBankTab other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasIndex = other.HasIndex;
				if (hasIndex)
				{
					this.Index = other.Index;
				}
				bool hasRequiredRank = other.HasRequiredRank;
				if (hasRequiredRank)
				{
					this.RequiredRank = other.RequiredRank;
				}
				bool hasIconIndex = other.HasIconIndex;
				if (hasIconIndex)
				{
					this.IconIndex = other.IconIndex;
				}
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060049A1 RID: 18849 RVA: 0x0011A482 File Offset: 0x00118682
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060049A2 RID: 18850 RVA: 0x0011A490 File Offset: 0x00118690
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
						this.RequiredRank = (ClanRank)input.ReadEnum();
					}
					else
					{
						this.Index = input.ReadUInt32();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 34U)
					{
						goto IL_0028;
					}
					this.Name = input.ReadString();
				}
				else
				{
					this.IconIndex = input.ReadUInt32();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040020D8 RID: 8408
		private static readonly MessageParser<ClanBankTab> _parser = new MessageParser<ClanBankTab>(() => new ClanBankTab());

		// Token: 0x040020D9 RID: 8409
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020DA RID: 8410
		private int _hasBits0;

		// Token: 0x040020DB RID: 8411
		public const int IndexFieldNumber = 1;

		// Token: 0x040020DC RID: 8412
		private static readonly uint IndexDefaultValue = 0U;

		// Token: 0x040020DD RID: 8413
		private uint index_;

		// Token: 0x040020DE RID: 8414
		public const int RequiredRankFieldNumber = 2;

		// Token: 0x040020DF RID: 8415
		private static readonly ClanRank RequiredRankDefaultValue = ClanRank.Member;

		// Token: 0x040020E0 RID: 8416
		private ClanRank requiredRank_;

		// Token: 0x040020E1 RID: 8417
		public const int IconIndexFieldNumber = 3;

		// Token: 0x040020E2 RID: 8418
		private static readonly uint IconIndexDefaultValue = 0U;

		// Token: 0x040020E3 RID: 8419
		private uint iconIndex_;

		// Token: 0x040020E4 RID: 8420
		public const int NameFieldNumber = 4;

		// Token: 0x040020E5 RID: 8421
		private static readonly string NameDefaultValue = "";

		// Token: 0x040020E6 RID: 8422
		private string name_;
	}
}
