using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Items
{
	// Token: 0x02000162 RID: 354
	public sealed class RareItemName : IMessage<RareItemName>, IMessage, IEquatable<RareItemName>, IDeepCloneable<RareItemName>, IBufferMessage
	{
		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x0600248B RID: 9355 RVA: 0x0008DCC8 File Offset: 0x0008BEC8
		[DebuggerNonUserCode]
		public static MessageParser<RareItemName> Parser
		{
			get
			{
				return RareItemName._parser;
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x0600248C RID: 9356 RVA: 0x0008DCE0 File Offset: 0x0008BEE0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ItemsReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x0600248D RID: 9357 RVA: 0x0008DD04 File Offset: 0x0008BF04
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RareItemName.Descriptor;
			}
		}

		// Token: 0x0600248E RID: 9358 RVA: 0x0008DD1B File Offset: 0x0008BF1B
		[DebuggerNonUserCode]
		public RareItemName()
		{
		}

		// Token: 0x0600248F RID: 9359 RVA: 0x0008DD28 File Offset: 0x0008BF28
		[DebuggerNonUserCode]
		public RareItemName(RareItemName other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.itemNameIsPrefix_ = other.itemNameIsPrefix_;
			this.snoAffixStringList_ = other.snoAffixStringList_;
			this.affixStringListLabel_ = other.affixStringListLabel_;
			this.itemStringListLabel_ = other.itemStringListLabel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x0008DD8C File Offset: 0x0008BF8C
		[DebuggerNonUserCode]
		public RareItemName Clone()
		{
			return new RareItemName(this);
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x06002491 RID: 9361 RVA: 0x0008DDA4 File Offset: 0x0008BFA4
		// (set) Token: 0x06002492 RID: 9362 RVA: 0x0008DDD5 File Offset: 0x0008BFD5
		[DebuggerNonUserCode]
		public bool ItemNameIsPrefix
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool itemNameIsPrefixDefaultValue;
				if (flag)
				{
					itemNameIsPrefixDefaultValue = this.itemNameIsPrefix_;
				}
				else
				{
					itemNameIsPrefixDefaultValue = RareItemName.ItemNameIsPrefixDefaultValue;
				}
				return itemNameIsPrefixDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.itemNameIsPrefix_ = value;
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x06002493 RID: 9363 RVA: 0x0008DDF0 File Offset: 0x0008BFF0
		[DebuggerNonUserCode]
		public bool HasItemNameIsPrefix
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002494 RID: 9364 RVA: 0x0008DE0D File Offset: 0x0008C00D
		[DebuggerNonUserCode]
		public void ClearItemNameIsPrefix()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x06002495 RID: 9365 RVA: 0x0008DE20 File Offset: 0x0008C020
		// (set) Token: 0x06002496 RID: 9366 RVA: 0x0008DE51 File Offset: 0x0008C051
		[DebuggerNonUserCode]
		public int SnoAffixStringList
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int snoAffixStringListDefaultValue;
				if (flag)
				{
					snoAffixStringListDefaultValue = this.snoAffixStringList_;
				}
				else
				{
					snoAffixStringListDefaultValue = RareItemName.SnoAffixStringListDefaultValue;
				}
				return snoAffixStringListDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoAffixStringList_ = value;
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x06002497 RID: 9367 RVA: 0x0008DE6C File Offset: 0x0008C06C
		[DebuggerNonUserCode]
		public bool HasSnoAffixStringList
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002498 RID: 9368 RVA: 0x0008DE89 File Offset: 0x0008C089
		[DebuggerNonUserCode]
		public void ClearSnoAffixStringList()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x06002499 RID: 9369 RVA: 0x0008DE9C File Offset: 0x0008C09C
		// (set) Token: 0x0600249A RID: 9370 RVA: 0x0008DECD File Offset: 0x0008C0CD
		[DebuggerNonUserCode]
		public uint AffixStringListLabel
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint affixStringListLabelDefaultValue;
				if (flag)
				{
					affixStringListLabelDefaultValue = this.affixStringListLabel_;
				}
				else
				{
					affixStringListLabelDefaultValue = RareItemName.AffixStringListLabelDefaultValue;
				}
				return affixStringListLabelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.affixStringListLabel_ = value;
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x0600249B RID: 9371 RVA: 0x0008DEE8 File Offset: 0x0008C0E8
		[DebuggerNonUserCode]
		public bool HasAffixStringListLabel
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600249C RID: 9372 RVA: 0x0008DF05 File Offset: 0x0008C105
		[DebuggerNonUserCode]
		public void ClearAffixStringListLabel()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x0600249D RID: 9373 RVA: 0x0008DF18 File Offset: 0x0008C118
		// (set) Token: 0x0600249E RID: 9374 RVA: 0x0008DF49 File Offset: 0x0008C149
		[DebuggerNonUserCode]
		public uint ItemStringListLabel
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint itemStringListLabelDefaultValue;
				if (flag)
				{
					itemStringListLabelDefaultValue = this.itemStringListLabel_;
				}
				else
				{
					itemStringListLabelDefaultValue = RareItemName.ItemStringListLabelDefaultValue;
				}
				return itemStringListLabelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.itemStringListLabel_ = value;
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x0600249F RID: 9375 RVA: 0x0008DF64 File Offset: 0x0008C164
		[DebuggerNonUserCode]
		public bool HasItemStringListLabel
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060024A0 RID: 9376 RVA: 0x0008DF81 File Offset: 0x0008C181
		[DebuggerNonUserCode]
		public void ClearItemStringListLabel()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x060024A1 RID: 9377 RVA: 0x0008DF94 File Offset: 0x0008C194
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RareItemName);
		}

		// Token: 0x060024A2 RID: 9378 RVA: 0x0008DFB4 File Offset: 0x0008C1B4
		[DebuggerNonUserCode]
		public bool Equals(RareItemName other)
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
					bool flag4 = this.ItemNameIsPrefix != other.ItemNameIsPrefix;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoAffixStringList != other.SnoAffixStringList;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.AffixStringListLabel != other.AffixStringListLabel;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.ItemStringListLabel != other.ItemStringListLabel;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060024A3 RID: 9379 RVA: 0x0008E060 File Offset: 0x0008C260
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasItemNameIsPrefix = this.HasItemNameIsPrefix;
			if (hasItemNameIsPrefix)
			{
				num ^= this.ItemNameIsPrefix.GetHashCode();
			}
			bool hasSnoAffixStringList = this.HasSnoAffixStringList;
			if (hasSnoAffixStringList)
			{
				num ^= this.SnoAffixStringList.GetHashCode();
			}
			bool hasAffixStringListLabel = this.HasAffixStringListLabel;
			if (hasAffixStringListLabel)
			{
				num ^= this.AffixStringListLabel.GetHashCode();
			}
			bool hasItemStringListLabel = this.HasItemStringListLabel;
			if (hasItemStringListLabel)
			{
				num ^= this.ItemStringListLabel.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060024A4 RID: 9380 RVA: 0x0008E10C File Offset: 0x0008C30C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x0008E124 File Offset: 0x0008C324
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060024A6 RID: 9382 RVA: 0x0008E130 File Offset: 0x0008C330
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasItemNameIsPrefix = this.HasItemNameIsPrefix;
			if (hasItemNameIsPrefix)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.ItemNameIsPrefix);
			}
			bool hasSnoAffixStringList = this.HasSnoAffixStringList;
			if (hasSnoAffixStringList)
			{
				output.WriteRawTag(21);
				output.WriteSFixed32(this.SnoAffixStringList);
			}
			bool hasAffixStringListLabel = this.HasAffixStringListLabel;
			if (hasAffixStringListLabel)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.AffixStringListLabel);
			}
			bool hasItemStringListLabel = this.HasItemStringListLabel;
			if (hasItemStringListLabel)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.ItemStringListLabel);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x0008E1E4 File Offset: 0x0008C3E4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasItemNameIsPrefix = this.HasItemNameIsPrefix;
			if (hasItemNameIsPrefix)
			{
				num += 2;
			}
			bool hasSnoAffixStringList = this.HasSnoAffixStringList;
			if (hasSnoAffixStringList)
			{
				num += 5;
			}
			bool hasAffixStringListLabel = this.HasAffixStringListLabel;
			if (hasAffixStringListLabel)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AffixStringListLabel);
			}
			bool hasItemStringListLabel = this.HasItemStringListLabel;
			if (hasItemStringListLabel)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemStringListLabel);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x0008E274 File Offset: 0x0008C474
		[DebuggerNonUserCode]
		public void MergeFrom(RareItemName other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasItemNameIsPrefix = other.HasItemNameIsPrefix;
				if (hasItemNameIsPrefix)
				{
					this.ItemNameIsPrefix = other.ItemNameIsPrefix;
				}
				bool hasSnoAffixStringList = other.HasSnoAffixStringList;
				if (hasSnoAffixStringList)
				{
					this.SnoAffixStringList = other.SnoAffixStringList;
				}
				bool hasAffixStringListLabel = other.HasAffixStringListLabel;
				if (hasAffixStringListLabel)
				{
					this.AffixStringListLabel = other.AffixStringListLabel;
				}
				bool hasItemStringListLabel = other.HasItemStringListLabel;
				if (hasItemStringListLabel)
				{
					this.ItemStringListLabel = other.ItemStringListLabel;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x0008E30A File Offset: 0x0008C50A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x0008E318 File Offset: 0x0008C518
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
						this.SnoAffixStringList = input.ReadSFixed32();
					}
					else
					{
						this.ItemNameIsPrefix = input.ReadBool();
					}
				}
				else if (num3 != 40U)
				{
					if (num3 != 48U)
					{
						goto IL_0028;
					}
					this.ItemStringListLabel = input.ReadUInt32();
				}
				else
				{
					this.AffixStringListLabel = input.ReadUInt32();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400100B RID: 4107
		private static readonly MessageParser<RareItemName> _parser = new MessageParser<RareItemName>(() => new RareItemName());

		// Token: 0x0400100C RID: 4108
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400100D RID: 4109
		private int _hasBits0;

		// Token: 0x0400100E RID: 4110
		public const int ItemNameIsPrefixFieldNumber = 1;

		// Token: 0x0400100F RID: 4111
		private static readonly bool ItemNameIsPrefixDefaultValue = false;

		// Token: 0x04001010 RID: 4112
		private bool itemNameIsPrefix_;

		// Token: 0x04001011 RID: 4113
		public const int SnoAffixStringListFieldNumber = 2;

		// Token: 0x04001012 RID: 4114
		private static readonly int SnoAffixStringListDefaultValue = -1;

		// Token: 0x04001013 RID: 4115
		private int snoAffixStringList_;

		// Token: 0x04001014 RID: 4116
		public const int AffixStringListLabelFieldNumber = 5;

		// Token: 0x04001015 RID: 4117
		private static readonly uint AffixStringListLabelDefaultValue = 0U;

		// Token: 0x04001016 RID: 4118
		private uint affixStringListLabel_;

		// Token: 0x04001017 RID: 4119
		public const int ItemStringListLabelFieldNumber = 6;

		// Token: 0x04001018 RID: 4120
		private static readonly uint ItemStringListLabelDefaultValue = 0U;

		// Token: 0x04001019 RID: 4121
		private uint itemStringListLabel_;
	}
}
