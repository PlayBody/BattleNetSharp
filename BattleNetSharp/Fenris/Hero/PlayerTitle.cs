using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x020001B6 RID: 438
	public sealed class PlayerTitle : IMessage<PlayerTitle>, IMessage, IEquatable<PlayerTitle>, IDeepCloneable<PlayerTitle>, IBufferMessage
	{
		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x06002E24 RID: 11812 RVA: 0x000B45D4 File Offset: 0x000B27D4
		[DebuggerNonUserCode]
		public static MessageParser<PlayerTitle> Parser
		{
			get
			{
				return PlayerTitle._parser;
			}
		}

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x06002E25 RID: 11813 RVA: 0x000B45EC File Offset: 0x000B27EC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroCommonReflection.Descriptor.MessageTypes[28];
			}
		}

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x06002E26 RID: 11814 RVA: 0x000B4610 File Offset: 0x000B2810
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerTitle.Descriptor;
			}
		}

		// Token: 0x06002E27 RID: 11815 RVA: 0x000B4627 File Offset: 0x000B2827
		[DebuggerNonUserCode]
		public PlayerTitle()
		{
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x000B4631 File Offset: 0x000B2831
		[DebuggerNonUserCode]
		public PlayerTitle(PlayerTitle other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoPrefix_ = other.snoPrefix_;
			this.snoSuffix_ = other.snoSuffix_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x000B4670 File Offset: 0x000B2870
		[DebuggerNonUserCode]
		public PlayerTitle Clone()
		{
			return new PlayerTitle(this);
		}

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x06002E2A RID: 11818 RVA: 0x000B4688 File Offset: 0x000B2888
		// (set) Token: 0x06002E2B RID: 11819 RVA: 0x000B46B9 File Offset: 0x000B28B9
		[DebuggerNonUserCode]
		public int SnoPrefix
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoPrefixDefaultValue;
				if (flag)
				{
					snoPrefixDefaultValue = this.snoPrefix_;
				}
				else
				{
					snoPrefixDefaultValue = PlayerTitle.SnoPrefixDefaultValue;
				}
				return snoPrefixDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoPrefix_ = value;
			}
		}

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x06002E2C RID: 11820 RVA: 0x000B46D4 File Offset: 0x000B28D4
		[DebuggerNonUserCode]
		public bool HasSnoPrefix
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002E2D RID: 11821 RVA: 0x000B46F1 File Offset: 0x000B28F1
		[DebuggerNonUserCode]
		public void ClearSnoPrefix()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x06002E2E RID: 11822 RVA: 0x000B4704 File Offset: 0x000B2904
		// (set) Token: 0x06002E2F RID: 11823 RVA: 0x000B4735 File Offset: 0x000B2935
		[DebuggerNonUserCode]
		public int SnoSuffix
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int snoSuffixDefaultValue;
				if (flag)
				{
					snoSuffixDefaultValue = this.snoSuffix_;
				}
				else
				{
					snoSuffixDefaultValue = PlayerTitle.SnoSuffixDefaultValue;
				}
				return snoSuffixDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoSuffix_ = value;
			}
		}

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x06002E30 RID: 11824 RVA: 0x000B4750 File Offset: 0x000B2950
		[DebuggerNonUserCode]
		public bool HasSnoSuffix
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002E31 RID: 11825 RVA: 0x000B476D File Offset: 0x000B296D
		[DebuggerNonUserCode]
		public void ClearSnoSuffix()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06002E32 RID: 11826 RVA: 0x000B4780 File Offset: 0x000B2980
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerTitle);
		}

		// Token: 0x06002E33 RID: 11827 RVA: 0x000B47A0 File Offset: 0x000B29A0
		[DebuggerNonUserCode]
		public bool Equals(PlayerTitle other)
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
					bool flag4 = this.SnoPrefix != other.SnoPrefix;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoSuffix != other.SnoSuffix;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002E34 RID: 11828 RVA: 0x000B4814 File Offset: 0x000B2A14
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoPrefix = this.HasSnoPrefix;
			if (hasSnoPrefix)
			{
				num ^= this.SnoPrefix.GetHashCode();
			}
			bool hasSnoSuffix = this.HasSnoSuffix;
			if (hasSnoSuffix)
			{
				num ^= this.SnoSuffix.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002E35 RID: 11829 RVA: 0x000B4880 File Offset: 0x000B2A80
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002E36 RID: 11830 RVA: 0x000B4898 File Offset: 0x000B2A98
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002E37 RID: 11831 RVA: 0x000B48A4 File Offset: 0x000B2AA4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoPrefix = this.HasSnoPrefix;
			if (hasSnoPrefix)
			{
				output.WriteRawTag(13);
				output.WriteSFixed32(this.SnoPrefix);
			}
			bool hasSnoSuffix = this.HasSnoSuffix;
			if (hasSnoSuffix)
			{
				output.WriteRawTag(21);
				output.WriteSFixed32(this.SnoSuffix);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002E38 RID: 11832 RVA: 0x000B4914 File Offset: 0x000B2B14
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoPrefix = this.HasSnoPrefix;
			if (hasSnoPrefix)
			{
				num += 5;
			}
			bool hasSnoSuffix = this.HasSnoSuffix;
			if (hasSnoSuffix)
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

		// Token: 0x06002E39 RID: 11833 RVA: 0x000B4968 File Offset: 0x000B2B68
		[DebuggerNonUserCode]
		public void MergeFrom(PlayerTitle other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoPrefix = other.HasSnoPrefix;
				if (hasSnoPrefix)
				{
					this.SnoPrefix = other.SnoPrefix;
				}
				bool hasSnoSuffix = other.HasSnoSuffix;
				if (hasSnoSuffix)
				{
					this.SnoSuffix = other.SnoSuffix;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002E3A RID: 11834 RVA: 0x000B49CA File Offset: 0x000B2BCA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002E3B RID: 11835 RVA: 0x000B49D8 File Offset: 0x000B2BD8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 13U)
				{
					if (num3 != 21U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SnoSuffix = input.ReadSFixed32();
					}
				}
				else
				{
					this.SnoPrefix = input.ReadSFixed32();
				}
			}
		}

		// Token: 0x040014D4 RID: 5332
		private static readonly MessageParser<PlayerTitle> _parser = new MessageParser<PlayerTitle>(() => new PlayerTitle());

		// Token: 0x040014D5 RID: 5333
		private UnknownFieldSet _unknownFields;

		// Token: 0x040014D6 RID: 5334
		private int _hasBits0;

		// Token: 0x040014D7 RID: 5335
		public const int SnoPrefixFieldNumber = 1;

		// Token: 0x040014D8 RID: 5336
		private static readonly int SnoPrefixDefaultValue = -1;

		// Token: 0x040014D9 RID: 5337
		private int snoPrefix_;

		// Token: 0x040014DA RID: 5338
		public const int SnoSuffixFieldNumber = 2;

		// Token: 0x040014DB RID: 5339
		private static readonly int SnoSuffixDefaultValue = -1;

		// Token: 0x040014DC RID: 5340
		private int snoSuffix_;
	}
}
