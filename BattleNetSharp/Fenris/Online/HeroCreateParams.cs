using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Online
{
	// Token: 0x02000148 RID: 328
	public sealed class HeroCreateParams : IMessage<HeroCreateParams>, IMessage, IEquatable<HeroCreateParams>, IDeepCloneable<HeroCreateParams>, IBufferMessage
	{
		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x060021EC RID: 8684 RVA: 0x00084704 File Offset: 0x00082904
		[DebuggerNonUserCode]
		public static MessageParser<HeroCreateParams> Parser
		{
			get
			{
				return HeroCreateParams._parser;
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x060021ED RID: 8685 RVA: 0x0008471C File Offset: 0x0008291C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OnlineReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x060021EE RID: 8686 RVA: 0x00084740 File Offset: 0x00082940
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeroCreateParams.Descriptor;
			}
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x00084757 File Offset: 0x00082957
		[DebuggerNonUserCode]
		public HeroCreateParams()
		{
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x00084764 File Offset: 0x00082964
		[DebuggerNonUserCode]
		public HeroCreateParams(HeroCreateParams other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.name_ = other.name_;
			this.gbidClass_ = other.gbidClass_;
			this.isHardcore_ = other.isHardcore_;
			this.isFemale_ = other.isFemale_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060021F1 RID: 8689 RVA: 0x000847C8 File Offset: 0x000829C8
		[DebuggerNonUserCode]
		public HeroCreateParams Clone()
		{
			return new HeroCreateParams(this);
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x060021F2 RID: 8690 RVA: 0x000847E0 File Offset: 0x000829E0
		// (set) Token: 0x060021F3 RID: 8691 RVA: 0x00084801 File Offset: 0x00082A01
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? HeroCreateParams.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x060021F4 RID: 8692 RVA: 0x00084818 File Offset: 0x00082A18
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x00084833 File Offset: 0x00082A33
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x060021F6 RID: 8694 RVA: 0x00084840 File Offset: 0x00082A40
		// (set) Token: 0x060021F7 RID: 8695 RVA: 0x00084871 File Offset: 0x00082A71
		[DebuggerNonUserCode]
		public int GbidClass
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int gbidClassDefaultValue;
				if (flag)
				{
					gbidClassDefaultValue = this.gbidClass_;
				}
				else
				{
					gbidClassDefaultValue = HeroCreateParams.GbidClassDefaultValue;
				}
				return gbidClassDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gbidClass_ = value;
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x060021F8 RID: 8696 RVA: 0x0008488C File Offset: 0x00082A8C
		[DebuggerNonUserCode]
		public bool HasGbidClass
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060021F9 RID: 8697 RVA: 0x000848A9 File Offset: 0x00082AA9
		[DebuggerNonUserCode]
		public void ClearGbidClass()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x060021FA RID: 8698 RVA: 0x000848BC File Offset: 0x00082ABC
		// (set) Token: 0x060021FB RID: 8699 RVA: 0x000848ED File Offset: 0x00082AED
		[DebuggerNonUserCode]
		public bool IsHardcore
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool isHardcoreDefaultValue;
				if (flag)
				{
					isHardcoreDefaultValue = this.isHardcore_;
				}
				else
				{
					isHardcoreDefaultValue = HeroCreateParams.IsHardcoreDefaultValue;
				}
				return isHardcoreDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.isHardcore_ = value;
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x060021FC RID: 8700 RVA: 0x00084908 File Offset: 0x00082B08
		[DebuggerNonUserCode]
		public bool HasIsHardcore
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060021FD RID: 8701 RVA: 0x00084925 File Offset: 0x00082B25
		[DebuggerNonUserCode]
		public void ClearIsHardcore()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x060021FE RID: 8702 RVA: 0x00084938 File Offset: 0x00082B38
		// (set) Token: 0x060021FF RID: 8703 RVA: 0x00084969 File Offset: 0x00082B69
		[DebuggerNonUserCode]
		public bool IsFemale
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool isFemaleDefaultValue;
				if (flag)
				{
					isFemaleDefaultValue = this.isFemale_;
				}
				else
				{
					isFemaleDefaultValue = HeroCreateParams.IsFemaleDefaultValue;
				}
				return isFemaleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.isFemale_ = value;
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06002200 RID: 8704 RVA: 0x00084984 File Offset: 0x00082B84
		[DebuggerNonUserCode]
		public bool HasIsFemale
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06002201 RID: 8705 RVA: 0x000849A1 File Offset: 0x00082BA1
		[DebuggerNonUserCode]
		public void ClearIsFemale()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06002202 RID: 8706 RVA: 0x000849B4 File Offset: 0x00082BB4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeroCreateParams);
		}

		// Token: 0x06002203 RID: 8707 RVA: 0x000849D4 File Offset: 0x00082BD4
		[DebuggerNonUserCode]
		public bool Equals(HeroCreateParams other)
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
					bool flag4 = this.Name != other.Name;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.GbidClass != other.GbidClass;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.IsHardcore != other.IsHardcore;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.IsFemale != other.IsFemale;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002204 RID: 8708 RVA: 0x00084A80 File Offset: 0x00082C80
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool hasGbidClass = this.HasGbidClass;
			if (hasGbidClass)
			{
				num ^= this.GbidClass.GetHashCode();
			}
			bool hasIsHardcore = this.HasIsHardcore;
			if (hasIsHardcore)
			{
				num ^= this.IsHardcore.GetHashCode();
			}
			bool hasIsFemale = this.HasIsFemale;
			if (hasIsFemale)
			{
				num ^= this.IsFemale.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x00084B28 File Offset: 0x00082D28
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002206 RID: 8710 RVA: 0x00084B40 File Offset: 0x00082D40
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002207 RID: 8711 RVA: 0x00084B4C File Offset: 0x00082D4C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			bool hasGbidClass = this.HasGbidClass;
			if (hasGbidClass)
			{
				output.WriteRawTag(21);
				output.WriteSFixed32(this.GbidClass);
			}
			bool hasIsHardcore = this.HasIsHardcore;
			if (hasIsHardcore)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsHardcore);
			}
			bool hasIsFemale = this.HasIsFemale;
			if (hasIsFemale)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsFemale);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002208 RID: 8712 RVA: 0x00084C00 File Offset: 0x00082E00
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool hasGbidClass = this.HasGbidClass;
			if (hasGbidClass)
			{
				num += 5;
			}
			bool hasIsHardcore = this.HasIsHardcore;
			if (hasIsHardcore)
			{
				num += 2;
			}
			bool hasIsFemale = this.HasIsFemale;
			if (hasIsFemale)
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

		// Token: 0x06002209 RID: 8713 RVA: 0x00084C84 File Offset: 0x00082E84
		[DebuggerNonUserCode]
		public void MergeFrom(HeroCreateParams other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool hasGbidClass = other.HasGbidClass;
				if (hasGbidClass)
				{
					this.GbidClass = other.GbidClass;
				}
				bool hasIsHardcore = other.HasIsHardcore;
				if (hasIsHardcore)
				{
					this.IsHardcore = other.IsHardcore;
				}
				bool hasIsFemale = other.HasIsFemale;
				if (hasIsFemale)
				{
					this.IsFemale = other.IsFemale;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600220A RID: 8714 RVA: 0x00084D1A File Offset: 0x00082F1A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600220B RID: 8715 RVA: 0x00084D28 File Offset: 0x00082F28
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
					if (num3 != 10U)
					{
						if (num3 != 21U)
						{
							goto IL_0029;
						}
						this.GbidClass = input.ReadSFixed32();
					}
					else
					{
						this.Name = input.ReadString();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_0029;
					}
					this.IsFemale = input.ReadBool();
				}
				else
				{
					this.IsHardcore = input.ReadBool();
				}
				continue;
				IL_0029:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000F03 RID: 3843
		private static readonly MessageParser<HeroCreateParams> _parser = new MessageParser<HeroCreateParams>(() => new HeroCreateParams());

		// Token: 0x04000F04 RID: 3844
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F05 RID: 3845
		private int _hasBits0;

		// Token: 0x04000F06 RID: 3846
		public const int NameFieldNumber = 1;

		// Token: 0x04000F07 RID: 3847
		private static readonly string NameDefaultValue = "";

		// Token: 0x04000F08 RID: 3848
		private string name_;

		// Token: 0x04000F09 RID: 3849
		public const int GbidClassFieldNumber = 2;

		// Token: 0x04000F0A RID: 3850
		private static readonly int GbidClassDefaultValue = -1;

		// Token: 0x04000F0B RID: 3851
		private int gbidClass_;

		// Token: 0x04000F0C RID: 3852
		public const int IsHardcoreFieldNumber = 3;

		// Token: 0x04000F0D RID: 3853
		private static readonly bool IsHardcoreDefaultValue = false;

		// Token: 0x04000F0E RID: 3854
		private bool isHardcore_;

		// Token: 0x04000F0F RID: 3855
		public const int IsFemaleFieldNumber = 4;

		// Token: 0x04000F10 RID: 3856
		private static readonly bool IsFemaleDefaultValue = false;

		// Token: 0x04000F11 RID: 3857
		private bool isFemale_;
	}
}
