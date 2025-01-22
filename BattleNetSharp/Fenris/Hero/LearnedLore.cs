using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x0200019D RID: 413
	public sealed class LearnedLore : IMessage<LearnedLore>, IMessage, IEquatable<LearnedLore>, IDeepCloneable<LearnedLore>, IBufferMessage
	{
		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x06002B9E RID: 11166 RVA: 0x000ABF54 File Offset: 0x000AA154
		[DebuggerNonUserCode]
		public static MessageParser<LearnedLore> Parser
		{
			get
			{
				return LearnedLore._parser;
			}
		}

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x06002B9F RID: 11167 RVA: 0x000ABF6C File Offset: 0x000AA16C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroCommonReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x06002BA0 RID: 11168 RVA: 0x000ABF90 File Offset: 0x000AA190
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LearnedLore.Descriptor;
			}
		}

		// Token: 0x06002BA1 RID: 11169 RVA: 0x000ABFA7 File Offset: 0x000AA1A7
		[DebuggerNonUserCode]
		public LearnedLore()
		{
		}

		// Token: 0x06002BA2 RID: 11170 RVA: 0x000ABFBC File Offset: 0x000AA1BC
		[DebuggerNonUserCode]
		public LearnedLore(LearnedLore other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoLoreLearned_ = other.snoLoreLearned_.Clone();
			this.snoLoreLearnedBitfield_ = other.snoLoreLearnedBitfield_;
			this.bitfieldLeadingNullBytes_ = other.bitfieldLeadingNullBytes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002BA3 RID: 11171 RVA: 0x000AC018 File Offset: 0x000AA218
		[DebuggerNonUserCode]
		public LearnedLore Clone()
		{
			return new LearnedLore(this);
		}

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x06002BA4 RID: 11172 RVA: 0x000AC030 File Offset: 0x000AA230
		[DebuggerNonUserCode]
		public RepeatedField<int> SnoLoreLearned
		{
			get
			{
				return this.snoLoreLearned_;
			}
		}

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x06002BA5 RID: 11173 RVA: 0x000AC048 File Offset: 0x000AA248
		// (set) Token: 0x06002BA6 RID: 11174 RVA: 0x000AC069 File Offset: 0x000AA269
		[DebuggerNonUserCode]
		public ByteString SnoLoreLearnedBitfield
		{
			get
			{
				return this.snoLoreLearnedBitfield_ ?? LearnedLore.SnoLoreLearnedBitfieldDefaultValue;
			}
			set
			{
				this.snoLoreLearnedBitfield_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x06002BA7 RID: 11175 RVA: 0x000AC080 File Offset: 0x000AA280
		[DebuggerNonUserCode]
		public bool HasSnoLoreLearnedBitfield
		{
			get
			{
				return this.snoLoreLearnedBitfield_ != null;
			}
		}

		// Token: 0x06002BA8 RID: 11176 RVA: 0x000AC09E File Offset: 0x000AA29E
		[DebuggerNonUserCode]
		public void ClearSnoLoreLearnedBitfield()
		{
			this.snoLoreLearnedBitfield_ = null;
		}

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x06002BA9 RID: 11177 RVA: 0x000AC0A8 File Offset: 0x000AA2A8
		// (set) Token: 0x06002BAA RID: 11178 RVA: 0x000AC0D9 File Offset: 0x000AA2D9
		[DebuggerNonUserCode]
		public int BitfieldLeadingNullBytes
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int bitfieldLeadingNullBytesDefaultValue;
				if (flag)
				{
					bitfieldLeadingNullBytesDefaultValue = this.bitfieldLeadingNullBytes_;
				}
				else
				{
					bitfieldLeadingNullBytesDefaultValue = LearnedLore.BitfieldLeadingNullBytesDefaultValue;
				}
				return bitfieldLeadingNullBytesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.bitfieldLeadingNullBytes_ = value;
			}
		}

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x06002BAB RID: 11179 RVA: 0x000AC0F4 File Offset: 0x000AA2F4
		[DebuggerNonUserCode]
		public bool HasBitfieldLeadingNullBytes
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002BAC RID: 11180 RVA: 0x000AC111 File Offset: 0x000AA311
		[DebuggerNonUserCode]
		public void ClearBitfieldLeadingNullBytes()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06002BAD RID: 11181 RVA: 0x000AC124 File Offset: 0x000AA324
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LearnedLore);
		}

		// Token: 0x06002BAE RID: 11182 RVA: 0x000AC144 File Offset: 0x000AA344
		[DebuggerNonUserCode]
		public bool Equals(LearnedLore other)
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
					bool flag4 = !this.snoLoreLearned_.Equals(other.snoLoreLearned_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoLoreLearnedBitfield != other.SnoLoreLearnedBitfield;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.BitfieldLeadingNullBytes != other.BitfieldLeadingNullBytes;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002BAF RID: 11183 RVA: 0x000AC1D4 File Offset: 0x000AA3D4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.snoLoreLearned_.GetHashCode();
			bool hasSnoLoreLearnedBitfield = this.HasSnoLoreLearnedBitfield;
			if (hasSnoLoreLearnedBitfield)
			{
				num ^= this.SnoLoreLearnedBitfield.GetHashCode();
			}
			bool hasBitfieldLeadingNullBytes = this.HasBitfieldLeadingNullBytes;
			if (hasBitfieldLeadingNullBytes)
			{
				num ^= this.BitfieldLeadingNullBytes.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002BB0 RID: 11184 RVA: 0x000AC24C File Offset: 0x000AA44C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002BB1 RID: 11185 RVA: 0x000AC264 File Offset: 0x000AA464
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002BB2 RID: 11186 RVA: 0x000AC270 File Offset: 0x000AA470
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.snoLoreLearned_.WriteTo(ref output, LearnedLore._repeated_snoLoreLearned_codec);
			bool hasSnoLoreLearnedBitfield = this.HasSnoLoreLearnedBitfield;
			if (hasSnoLoreLearnedBitfield)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.SnoLoreLearnedBitfield);
			}
			bool hasBitfieldLeadingNullBytes = this.HasBitfieldLeadingNullBytes;
			if (hasBitfieldLeadingNullBytes)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.BitfieldLeadingNullBytes);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002BB3 RID: 11187 RVA: 0x000AC2F0 File Offset: 0x000AA4F0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.snoLoreLearned_.CalculateSize(LearnedLore._repeated_snoLoreLearned_codec);
			bool hasSnoLoreLearnedBitfield = this.HasSnoLoreLearnedBitfield;
			if (hasSnoLoreLearnedBitfield)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.SnoLoreLearnedBitfield);
			}
			bool hasBitfieldLeadingNullBytes = this.HasBitfieldLeadingNullBytes;
			if (hasBitfieldLeadingNullBytes)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BitfieldLeadingNullBytes);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002BB4 RID: 11188 RVA: 0x000AC370 File Offset: 0x000AA570
		[DebuggerNonUserCode]
		public void MergeFrom(LearnedLore other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.snoLoreLearned_.Add(other.snoLoreLearned_);
				bool hasSnoLoreLearnedBitfield = other.HasSnoLoreLearnedBitfield;
				if (hasSnoLoreLearnedBitfield)
				{
					this.SnoLoreLearnedBitfield = other.SnoLoreLearnedBitfield;
				}
				bool hasBitfieldLeadingNullBytes = other.HasBitfieldLeadingNullBytes;
				if (hasBitfieldLeadingNullBytes)
				{
					this.BitfieldLeadingNullBytes = other.BitfieldLeadingNullBytes;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002BB5 RID: 11189 RVA: 0x000AC3E4 File Offset: 0x000AA5E4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002BB6 RID: 11190 RVA: 0x000AC3F0 File Offset: 0x000AA5F0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 13U)
				{
					if (num3 != 10U && num3 != 13U)
					{
						goto IL_0029;
					}
					this.snoLoreLearned_.AddEntriesFrom(ref input, LearnedLore._repeated_snoLoreLearned_codec);
				}
				else if (num3 != 18U)
				{
					if (num3 != 24U)
					{
						goto IL_0029;
					}
					this.BitfieldLeadingNullBytes = input.ReadInt32();
				}
				else
				{
					this.SnoLoreLearnedBitfield = input.ReadBytes();
				}
				continue;
				IL_0029:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040013C2 RID: 5058
		private static readonly MessageParser<LearnedLore> _parser = new MessageParser<LearnedLore>(() => new LearnedLore());

		// Token: 0x040013C3 RID: 5059
		private UnknownFieldSet _unknownFields;

		// Token: 0x040013C4 RID: 5060
		private int _hasBits0;

		// Token: 0x040013C5 RID: 5061
		public const int SnoLoreLearnedFieldNumber = 1;

		// Token: 0x040013C6 RID: 5062
		private static readonly FieldCodec<int> _repeated_snoLoreLearned_codec = FieldCodec.ForSFixed32(13U);

		// Token: 0x040013C7 RID: 5063
		private readonly RepeatedField<int> snoLoreLearned_ = new RepeatedField<int>();

		// Token: 0x040013C8 RID: 5064
		public const int SnoLoreLearnedBitfieldFieldNumber = 2;

		// Token: 0x040013C9 RID: 5065
		private static readonly ByteString SnoLoreLearnedBitfieldDefaultValue = ByteString.Empty;

		// Token: 0x040013CA RID: 5066
		private ByteString snoLoreLearnedBitfield_;

		// Token: 0x040013CB RID: 5067
		public const int BitfieldLeadingNullBytesFieldNumber = 3;

		// Token: 0x040013CC RID: 5068
		private static readonly int BitfieldLeadingNullBytesDefaultValue = 0;

		// Token: 0x040013CD RID: 5069
		private int bitfieldLeadingNullBytes_;
	}
}
