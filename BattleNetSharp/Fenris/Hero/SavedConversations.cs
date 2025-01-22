using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x0200019F RID: 415
	public sealed class SavedConversations : IMessage<SavedConversations>, IMessage, IEquatable<SavedConversations>, IDeepCloneable<SavedConversations>, IBufferMessage
	{
		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x06002BD1 RID: 11217 RVA: 0x000AC95C File Offset: 0x000AAB5C
		[DebuggerNonUserCode]
		public static MessageParser<SavedConversations> Parser
		{
			get
			{
				return SavedConversations._parser;
			}
		}

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x06002BD2 RID: 11218 RVA: 0x000AC974 File Offset: 0x000AAB74
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroCommonReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x06002BD3 RID: 11219 RVA: 0x000AC998 File Offset: 0x000AAB98
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SavedConversations.Descriptor;
			}
		}

		// Token: 0x06002BD4 RID: 11220 RVA: 0x000AC9AF File Offset: 0x000AABAF
		[DebuggerNonUserCode]
		public SavedConversations()
		{
		}

		// Token: 0x06002BD5 RID: 11221 RVA: 0x000AC9D0 File Offset: 0x000AABD0
		[DebuggerNonUserCode]
		public SavedConversations(SavedConversations other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoSavedConversations_ = other.snoSavedConversations_.Clone();
			this.snoSavedConversationsBitfield_ = other.snoSavedConversationsBitfield_;
			this.bitfieldLeadingNullBytes_ = other.bitfieldLeadingNullBytes_;
			this.conversationCooldowns_ = other.conversationCooldowns_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002BD6 RID: 11222 RVA: 0x000ACA3C File Offset: 0x000AAC3C
		[DebuggerNonUserCode]
		public SavedConversations Clone()
		{
			return new SavedConversations(this);
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x06002BD7 RID: 11223 RVA: 0x000ACA54 File Offset: 0x000AAC54
		[DebuggerNonUserCode]
		public RepeatedField<int> SnoSavedConversations
		{
			get
			{
				return this.snoSavedConversations_;
			}
		}

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x06002BD8 RID: 11224 RVA: 0x000ACA6C File Offset: 0x000AAC6C
		// (set) Token: 0x06002BD9 RID: 11225 RVA: 0x000ACA8D File Offset: 0x000AAC8D
		[DebuggerNonUserCode]
		public ByteString SnoSavedConversationsBitfield
		{
			get
			{
				return this.snoSavedConversationsBitfield_ ?? SavedConversations.SnoSavedConversationsBitfieldDefaultValue;
			}
			set
			{
				this.snoSavedConversationsBitfield_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x06002BDA RID: 11226 RVA: 0x000ACAA4 File Offset: 0x000AACA4
		[DebuggerNonUserCode]
		public bool HasSnoSavedConversationsBitfield
		{
			get
			{
				return this.snoSavedConversationsBitfield_ != null;
			}
		}

		// Token: 0x06002BDB RID: 11227 RVA: 0x000ACAC2 File Offset: 0x000AACC2
		[DebuggerNonUserCode]
		public void ClearSnoSavedConversationsBitfield()
		{
			this.snoSavedConversationsBitfield_ = null;
		}

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x06002BDC RID: 11228 RVA: 0x000ACACC File Offset: 0x000AACCC
		// (set) Token: 0x06002BDD RID: 11229 RVA: 0x000ACAFD File Offset: 0x000AACFD
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
					bitfieldLeadingNullBytesDefaultValue = SavedConversations.BitfieldLeadingNullBytesDefaultValue;
				}
				return bitfieldLeadingNullBytesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.bitfieldLeadingNullBytes_ = value;
			}
		}

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x06002BDE RID: 11230 RVA: 0x000ACB18 File Offset: 0x000AAD18
		[DebuggerNonUserCode]
		public bool HasBitfieldLeadingNullBytes
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002BDF RID: 11231 RVA: 0x000ACB35 File Offset: 0x000AAD35
		[DebuggerNonUserCode]
		public void ClearBitfieldLeadingNullBytes()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x06002BE0 RID: 11232 RVA: 0x000ACB48 File Offset: 0x000AAD48
		[DebuggerNonUserCode]
		public RepeatedField<ConversationCooldown> ConversationCooldowns
		{
			get
			{
				return this.conversationCooldowns_;
			}
		}

		// Token: 0x06002BE1 RID: 11233 RVA: 0x000ACB60 File Offset: 0x000AAD60
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SavedConversations);
		}

		// Token: 0x06002BE2 RID: 11234 RVA: 0x000ACB80 File Offset: 0x000AAD80
		[DebuggerNonUserCode]
		public bool Equals(SavedConversations other)
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
					bool flag4 = !this.snoSavedConversations_.Equals(other.snoSavedConversations_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoSavedConversationsBitfield != other.SnoSavedConversationsBitfield;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.BitfieldLeadingNullBytes != other.BitfieldLeadingNullBytes;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.conversationCooldowns_.Equals(other.conversationCooldowns_);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002BE3 RID: 11235 RVA: 0x000ACC34 File Offset: 0x000AAE34
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.snoSavedConversations_.GetHashCode();
			bool hasSnoSavedConversationsBitfield = this.HasSnoSavedConversationsBitfield;
			if (hasSnoSavedConversationsBitfield)
			{
				num ^= this.SnoSavedConversationsBitfield.GetHashCode();
			}
			bool hasBitfieldLeadingNullBytes = this.HasBitfieldLeadingNullBytes;
			if (hasBitfieldLeadingNullBytes)
			{
				num ^= this.BitfieldLeadingNullBytes.GetHashCode();
			}
			num ^= this.conversationCooldowns_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002BE4 RID: 11236 RVA: 0x000ACCBC File Offset: 0x000AAEBC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x000ACCD4 File Offset: 0x000AAED4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x000ACCE0 File Offset: 0x000AAEE0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.snoSavedConversations_.WriteTo(ref output, SavedConversations._repeated_snoSavedConversations_codec);
			bool hasSnoSavedConversationsBitfield = this.HasSnoSavedConversationsBitfield;
			if (hasSnoSavedConversationsBitfield)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.SnoSavedConversationsBitfield);
			}
			bool hasBitfieldLeadingNullBytes = this.HasBitfieldLeadingNullBytes;
			if (hasBitfieldLeadingNullBytes)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.BitfieldLeadingNullBytes);
			}
			this.conversationCooldowns_.WriteTo(ref output, SavedConversations._repeated_conversationCooldowns_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x000ACD74 File Offset: 0x000AAF74
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.snoSavedConversations_.CalculateSize(SavedConversations._repeated_snoSavedConversations_codec);
			bool hasSnoSavedConversationsBitfield = this.HasSnoSavedConversationsBitfield;
			if (hasSnoSavedConversationsBitfield)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.SnoSavedConversationsBitfield);
			}
			bool hasBitfieldLeadingNullBytes = this.HasBitfieldLeadingNullBytes;
			if (hasBitfieldLeadingNullBytes)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BitfieldLeadingNullBytes);
			}
			num += this.conversationCooldowns_.CalculateSize(SavedConversations._repeated_conversationCooldowns_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x000ACE08 File Offset: 0x000AB008
		[DebuggerNonUserCode]
		public void MergeFrom(SavedConversations other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.snoSavedConversations_.Add(other.snoSavedConversations_);
				bool hasSnoSavedConversationsBitfield = other.HasSnoSavedConversationsBitfield;
				if (hasSnoSavedConversationsBitfield)
				{
					this.SnoSavedConversationsBitfield = other.SnoSavedConversationsBitfield;
				}
				bool hasBitfieldLeadingNullBytes = other.HasBitfieldLeadingNullBytes;
				if (hasBitfieldLeadingNullBytes)
				{
					this.BitfieldLeadingNullBytes = other.BitfieldLeadingNullBytes;
				}
				this.conversationCooldowns_.Add(other.conversationCooldowns_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x000ACE8E File Offset: 0x000AB08E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002BEA RID: 11242 RVA: 0x000ACE9C File Offset: 0x000AB09C
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
					if (num3 != 18U && num3 != 21U)
					{
						goto IL_0033;
					}
					this.snoSavedConversations_.AddEntriesFrom(ref input, SavedConversations._repeated_snoSavedConversations_codec);
				}
				else if (num3 != 26U)
				{
					if (num3 != 32U)
					{
						if (num3 != 42U)
						{
							goto IL_0033;
						}
						this.conversationCooldowns_.AddEntriesFrom(ref input, SavedConversations._repeated_conversationCooldowns_codec);
					}
					else
					{
						this.BitfieldLeadingNullBytes = input.ReadInt32();
					}
				}
				else
				{
					this.SnoSavedConversationsBitfield = input.ReadBytes();
				}
				continue;
				IL_0033:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040013D7 RID: 5079
		private static readonly MessageParser<SavedConversations> _parser = new MessageParser<SavedConversations>(() => new SavedConversations());

		// Token: 0x040013D8 RID: 5080
		private UnknownFieldSet _unknownFields;

		// Token: 0x040013D9 RID: 5081
		private int _hasBits0;

		// Token: 0x040013DA RID: 5082
		public const int SnoSavedConversationsFieldNumber = 2;

		// Token: 0x040013DB RID: 5083
		private static readonly FieldCodec<int> _repeated_snoSavedConversations_codec = FieldCodec.ForSFixed32(21U);

		// Token: 0x040013DC RID: 5084
		private readonly RepeatedField<int> snoSavedConversations_ = new RepeatedField<int>();

		// Token: 0x040013DD RID: 5085
		public const int SnoSavedConversationsBitfieldFieldNumber = 3;

		// Token: 0x040013DE RID: 5086
		private static readonly ByteString SnoSavedConversationsBitfieldDefaultValue = ByteString.Empty;

		// Token: 0x040013DF RID: 5087
		private ByteString snoSavedConversationsBitfield_;

		// Token: 0x040013E0 RID: 5088
		public const int BitfieldLeadingNullBytesFieldNumber = 4;

		// Token: 0x040013E1 RID: 5089
		private static readonly int BitfieldLeadingNullBytesDefaultValue = 0;

		// Token: 0x040013E2 RID: 5090
		private int bitfieldLeadingNullBytes_;

		// Token: 0x040013E3 RID: 5091
		public const int ConversationCooldownsFieldNumber = 5;

		// Token: 0x040013E4 RID: 5092
		private static readonly FieldCodec<ConversationCooldown> _repeated_conversationCooldowns_codec = FieldCodec.ForMessage<ConversationCooldown>(42U, ConversationCooldown.Parser);

		// Token: 0x040013E5 RID: 5093
		private readonly RepeatedField<ConversationCooldown> conversationCooldowns_ = new RepeatedField<ConversationCooldown>();
	}
}
