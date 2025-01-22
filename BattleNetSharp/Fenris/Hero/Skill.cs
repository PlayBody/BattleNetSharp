using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x020001A1 RID: 417
	public sealed class Skill : IMessage<Skill>, IMessage, IEquatable<Skill>, IDeepCloneable<Skill>, IBufferMessage
	{
		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x06002C09 RID: 11273 RVA: 0x000AD588 File Offset: 0x000AB788
		[DebuggerNonUserCode]
		public static MessageParser<Skill> Parser
		{
			get
			{
				return Skill._parser;
			}
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x06002C0A RID: 11274 RVA: 0x000AD5A0 File Offset: 0x000AB7A0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroCommonReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x06002C0B RID: 11275 RVA: 0x000AD5C4 File Offset: 0x000AB7C4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Skill.Descriptor;
			}
		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x000AD5DB File Offset: 0x000AB7DB
		[DebuggerNonUserCode]
		public Skill()
		{
		}

		// Token: 0x06002C0D RID: 11277 RVA: 0x000AD5E5 File Offset: 0x000AB7E5
		[DebuggerNonUserCode]
		public Skill(Skill other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoSkill_ = other.snoSkill_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002C0E RID: 11278 RVA: 0x000AD618 File Offset: 0x000AB818
		[DebuggerNonUserCode]
		public Skill Clone()
		{
			return new Skill(this);
		}

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x06002C0F RID: 11279 RVA: 0x000AD630 File Offset: 0x000AB830
		// (set) Token: 0x06002C10 RID: 11280 RVA: 0x000AD661 File Offset: 0x000AB861
		[DebuggerNonUserCode]
		public int SnoSkill
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoSkillDefaultValue;
				if (flag)
				{
					snoSkillDefaultValue = this.snoSkill_;
				}
				else
				{
					snoSkillDefaultValue = Skill.SnoSkillDefaultValue;
				}
				return snoSkillDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoSkill_ = value;
			}
		}

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x06002C11 RID: 11281 RVA: 0x000AD67C File Offset: 0x000AB87C
		[DebuggerNonUserCode]
		public bool HasSnoSkill
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002C12 RID: 11282 RVA: 0x000AD699 File Offset: 0x000AB899
		[DebuggerNonUserCode]
		public void ClearSnoSkill()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06002C13 RID: 11283 RVA: 0x000AD6AC File Offset: 0x000AB8AC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Skill);
		}

		// Token: 0x06002C14 RID: 11284 RVA: 0x000AD6CC File Offset: 0x000AB8CC
		[DebuggerNonUserCode]
		public bool Equals(Skill other)
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
					bool flag4 = this.SnoSkill != other.SnoSkill;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06002C15 RID: 11285 RVA: 0x000AD724 File Offset: 0x000AB924
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoSkill = this.HasSnoSkill;
			if (hasSnoSkill)
			{
				num ^= this.SnoSkill.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002C16 RID: 11286 RVA: 0x000AD774 File Offset: 0x000AB974
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002C17 RID: 11287 RVA: 0x000AD78C File Offset: 0x000AB98C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002C18 RID: 11288 RVA: 0x000AD798 File Offset: 0x000AB998
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoSkill = this.HasSnoSkill;
			if (hasSnoSkill)
			{
				output.WriteRawTag(13);
				output.WriteSFixed32(this.SnoSkill);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002C19 RID: 11289 RVA: 0x000AD7E4 File Offset: 0x000AB9E4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoSkill = this.HasSnoSkill;
			if (hasSnoSkill)
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

		// Token: 0x06002C1A RID: 11290 RVA: 0x000AD828 File Offset: 0x000ABA28
		[DebuggerNonUserCode]
		public void MergeFrom(Skill other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoSkill = other.HasSnoSkill;
				if (hasSnoSkill)
				{
					this.SnoSkill = other.SnoSkill;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002C1B RID: 11291 RVA: 0x000AD871 File Offset: 0x000ABA71
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002C1C RID: 11292 RVA: 0x000AD87C File Offset: 0x000ABA7C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SnoSkill = input.ReadSFixed32();
				}
			}
		}

		// Token: 0x040013F2 RID: 5106
		private static readonly MessageParser<Skill> _parser = new MessageParser<Skill>(() => new Skill());

		// Token: 0x040013F3 RID: 5107
		private UnknownFieldSet _unknownFields;

		// Token: 0x040013F4 RID: 5108
		private int _hasBits0;

		// Token: 0x040013F5 RID: 5109
		public const int SnoSkillFieldNumber = 1;

		// Token: 0x040013F6 RID: 5110
		private static readonly int SnoSkillDefaultValue = -1;

		// Token: 0x040013F7 RID: 5111
		private int snoSkill_;
	}
}
