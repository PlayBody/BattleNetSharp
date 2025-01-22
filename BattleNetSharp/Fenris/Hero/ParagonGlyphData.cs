using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x020001B4 RID: 436
	public sealed class ParagonGlyphData : IMessage<ParagonGlyphData>, IMessage, IEquatable<ParagonGlyphData>, IDeepCloneable<ParagonGlyphData>, IBufferMessage
	{
		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x06002DF9 RID: 11769 RVA: 0x000B3E34 File Offset: 0x000B2034
		[DebuggerNonUserCode]
		public static MessageParser<ParagonGlyphData> Parser
		{
			get
			{
				return ParagonGlyphData._parser;
			}
		}

		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x06002DFA RID: 11770 RVA: 0x000B3E4C File Offset: 0x000B204C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroCommonReflection.Descriptor.MessageTypes[26];
			}
		}

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x06002DFB RID: 11771 RVA: 0x000B3E70 File Offset: 0x000B2070
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParagonGlyphData.Descriptor;
			}
		}

		// Token: 0x06002DFC RID: 11772 RVA: 0x000B3E87 File Offset: 0x000B2087
		[DebuggerNonUserCode]
		public ParagonGlyphData()
		{
		}

		// Token: 0x06002DFD RID: 11773 RVA: 0x000B3E91 File Offset: 0x000B2091
		[DebuggerNonUserCode]
		public ParagonGlyphData(ParagonGlyphData other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoGlyph_ = other.snoGlyph_;
			this.glyphExperience_ = other.glyphExperience_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002DFE RID: 11774 RVA: 0x000B3ED0 File Offset: 0x000B20D0
		[DebuggerNonUserCode]
		public ParagonGlyphData Clone()
		{
			return new ParagonGlyphData(this);
		}

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x06002DFF RID: 11775 RVA: 0x000B3EE8 File Offset: 0x000B20E8
		// (set) Token: 0x06002E00 RID: 11776 RVA: 0x000B3F19 File Offset: 0x000B2119
		[DebuggerNonUserCode]
		public int SnoGlyph
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoGlyphDefaultValue;
				if (flag)
				{
					snoGlyphDefaultValue = this.snoGlyph_;
				}
				else
				{
					snoGlyphDefaultValue = ParagonGlyphData.SnoGlyphDefaultValue;
				}
				return snoGlyphDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoGlyph_ = value;
			}
		}

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x06002E01 RID: 11777 RVA: 0x000B3F34 File Offset: 0x000B2134
		[DebuggerNonUserCode]
		public bool HasSnoGlyph
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002E02 RID: 11778 RVA: 0x000B3F51 File Offset: 0x000B2151
		[DebuggerNonUserCode]
		public void ClearSnoGlyph()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x06002E03 RID: 11779 RVA: 0x000B3F64 File Offset: 0x000B2164
		// (set) Token: 0x06002E04 RID: 11780 RVA: 0x000B3F95 File Offset: 0x000B2195
		[DebuggerNonUserCode]
		public uint GlyphExperience
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint glyphExperienceDefaultValue;
				if (flag)
				{
					glyphExperienceDefaultValue = this.glyphExperience_;
				}
				else
				{
					glyphExperienceDefaultValue = ParagonGlyphData.GlyphExperienceDefaultValue;
				}
				return glyphExperienceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.glyphExperience_ = value;
			}
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x06002E05 RID: 11781 RVA: 0x000B3FB0 File Offset: 0x000B21B0
		[DebuggerNonUserCode]
		public bool HasGlyphExperience
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002E06 RID: 11782 RVA: 0x000B3FCD File Offset: 0x000B21CD
		[DebuggerNonUserCode]
		public void ClearGlyphExperience()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06002E07 RID: 11783 RVA: 0x000B3FE0 File Offset: 0x000B21E0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParagonGlyphData);
		}

		// Token: 0x06002E08 RID: 11784 RVA: 0x000B4000 File Offset: 0x000B2200
		[DebuggerNonUserCode]
		public bool Equals(ParagonGlyphData other)
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
					bool flag4 = this.SnoGlyph != other.SnoGlyph;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.GlyphExperience != other.GlyphExperience;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002E09 RID: 11785 RVA: 0x000B4074 File Offset: 0x000B2274
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoGlyph = this.HasSnoGlyph;
			if (hasSnoGlyph)
			{
				num ^= this.SnoGlyph.GetHashCode();
			}
			bool hasGlyphExperience = this.HasGlyphExperience;
			if (hasGlyphExperience)
			{
				num ^= this.GlyphExperience.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002E0A RID: 11786 RVA: 0x000B40E4 File Offset: 0x000B22E4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002E0B RID: 11787 RVA: 0x000B40FC File Offset: 0x000B22FC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002E0C RID: 11788 RVA: 0x000B4108 File Offset: 0x000B2308
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoGlyph = this.HasSnoGlyph;
			if (hasSnoGlyph)
			{
				output.WriteRawTag(13);
				output.WriteSFixed32(this.SnoGlyph);
			}
			bool hasGlyphExperience = this.HasGlyphExperience;
			if (hasGlyphExperience)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.GlyphExperience);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002E0D RID: 11789 RVA: 0x000B4178 File Offset: 0x000B2378
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoGlyph = this.HasSnoGlyph;
			if (hasSnoGlyph)
			{
				num += 5;
			}
			bool hasGlyphExperience = this.HasGlyphExperience;
			if (hasGlyphExperience)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GlyphExperience);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002E0E RID: 11790 RVA: 0x000B41D8 File Offset: 0x000B23D8
		[DebuggerNonUserCode]
		public void MergeFrom(ParagonGlyphData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoGlyph = other.HasSnoGlyph;
				if (hasSnoGlyph)
				{
					this.SnoGlyph = other.SnoGlyph;
				}
				bool hasGlyphExperience = other.HasGlyphExperience;
				if (hasGlyphExperience)
				{
					this.GlyphExperience = other.GlyphExperience;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002E0F RID: 11791 RVA: 0x000B423A File Offset: 0x000B243A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002E10 RID: 11792 RVA: 0x000B4248 File Offset: 0x000B2448
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GlyphExperience = input.ReadUInt32();
					}
				}
				else
				{
					this.SnoGlyph = input.ReadSFixed32();
				}
			}
		}

		// Token: 0x040014C6 RID: 5318
		private static readonly MessageParser<ParagonGlyphData> _parser = new MessageParser<ParagonGlyphData>(() => new ParagonGlyphData());

		// Token: 0x040014C7 RID: 5319
		private UnknownFieldSet _unknownFields;

		// Token: 0x040014C8 RID: 5320
		private int _hasBits0;

		// Token: 0x040014C9 RID: 5321
		public const int SnoGlyphFieldNumber = 1;

		// Token: 0x040014CA RID: 5322
		private static readonly int SnoGlyphDefaultValue = -1;

		// Token: 0x040014CB RID: 5323
		private int snoGlyph_;

		// Token: 0x040014CC RID: 5324
		public const int GlyphExperienceFieldNumber = 2;

		// Token: 0x040014CD RID: 5325
		private static readonly uint GlyphExperienceDefaultValue = 0U;

		// Token: 0x040014CE RID: 5326
		private uint glyphExperience_;
	}
}
