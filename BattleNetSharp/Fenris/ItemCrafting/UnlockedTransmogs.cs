using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.ItemCrafting
{
	// Token: 0x02000172 RID: 370
	public sealed class UnlockedTransmogs : IMessage<UnlockedTransmogs>, IMessage, IEquatable<UnlockedTransmogs>, IDeepCloneable<UnlockedTransmogs>, IBufferMessage
	{
		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x06002686 RID: 9862 RVA: 0x00095A98 File Offset: 0x00093C98
		[DebuggerNonUserCode]
		public static MessageParser<UnlockedTransmogs> Parser
		{
			get
			{
				return UnlockedTransmogs._parser;
			}
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x06002687 RID: 9863 RVA: 0x00095AB0 File Offset: 0x00093CB0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ItemCraftingReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x06002688 RID: 9864 RVA: 0x00095AD4 File Offset: 0x00093CD4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockedTransmogs.Descriptor;
			}
		}

		// Token: 0x06002689 RID: 9865 RVA: 0x00095AEB File Offset: 0x00093CEB
		[DebuggerNonUserCode]
		public UnlockedTransmogs()
		{
		}

		// Token: 0x0600268A RID: 9866 RVA: 0x00095B00 File Offset: 0x00093D00
		[DebuggerNonUserCode]
		public UnlockedTransmogs(UnlockedTransmogs other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.unlockedTransmogs_ = other.unlockedTransmogs_.Clone();
			this.unlockedTransmogsBitfield_ = other.unlockedTransmogsBitfield_;
			this.bitfieldLeadingNullBytes_ = other.bitfieldLeadingNullBytes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600268B RID: 9867 RVA: 0x00095B5C File Offset: 0x00093D5C
		[DebuggerNonUserCode]
		public UnlockedTransmogs Clone()
		{
			return new UnlockedTransmogs(this);
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x0600268C RID: 9868 RVA: 0x00095B74 File Offset: 0x00093D74
		[DebuggerNonUserCode]
		public RepeatedField<int> UnlockedTransmogs_
		{
			get
			{
				return this.unlockedTransmogs_;
			}
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x0600268D RID: 9869 RVA: 0x00095B8C File Offset: 0x00093D8C
		// (set) Token: 0x0600268E RID: 9870 RVA: 0x00095BAD File Offset: 0x00093DAD
		[DebuggerNonUserCode]
		public ByteString UnlockedTransmogsBitfield
		{
			get
			{
				return this.unlockedTransmogsBitfield_ ?? UnlockedTransmogs.UnlockedTransmogsBitfieldDefaultValue;
			}
			set
			{
				this.unlockedTransmogsBitfield_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x0600268F RID: 9871 RVA: 0x00095BC4 File Offset: 0x00093DC4
		[DebuggerNonUserCode]
		public bool HasUnlockedTransmogsBitfield
		{
			get
			{
				return this.unlockedTransmogsBitfield_ != null;
			}
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x00095BE2 File Offset: 0x00093DE2
		[DebuggerNonUserCode]
		public void ClearUnlockedTransmogsBitfield()
		{
			this.unlockedTransmogsBitfield_ = null;
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x06002691 RID: 9873 RVA: 0x00095BEC File Offset: 0x00093DEC
		// (set) Token: 0x06002692 RID: 9874 RVA: 0x00095C1D File Offset: 0x00093E1D
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
					bitfieldLeadingNullBytesDefaultValue = UnlockedTransmogs.BitfieldLeadingNullBytesDefaultValue;
				}
				return bitfieldLeadingNullBytesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.bitfieldLeadingNullBytes_ = value;
			}
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x06002693 RID: 9875 RVA: 0x00095C38 File Offset: 0x00093E38
		[DebuggerNonUserCode]
		public bool HasBitfieldLeadingNullBytes
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002694 RID: 9876 RVA: 0x00095C55 File Offset: 0x00093E55
		[DebuggerNonUserCode]
		public void ClearBitfieldLeadingNullBytes()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x00095C68 File Offset: 0x00093E68
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockedTransmogs);
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x00095C88 File Offset: 0x00093E88
		[DebuggerNonUserCode]
		public bool Equals(UnlockedTransmogs other)
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
					bool flag4 = !this.unlockedTransmogs_.Equals(other.unlockedTransmogs_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.UnlockedTransmogsBitfield != other.UnlockedTransmogsBitfield;
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

		// Token: 0x06002697 RID: 9879 RVA: 0x00095D18 File Offset: 0x00093F18
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockedTransmogs_.GetHashCode();
			bool hasUnlockedTransmogsBitfield = this.HasUnlockedTransmogsBitfield;
			if (hasUnlockedTransmogsBitfield)
			{
				num ^= this.UnlockedTransmogsBitfield.GetHashCode();
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

		// Token: 0x06002698 RID: 9880 RVA: 0x00095D90 File Offset: 0x00093F90
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002699 RID: 9881 RVA: 0x00095DA8 File Offset: 0x00093FA8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600269A RID: 9882 RVA: 0x00095DB4 File Offset: 0x00093FB4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockedTransmogs_.WriteTo(ref output, UnlockedTransmogs._repeated_unlockedTransmogs_codec);
			bool hasUnlockedTransmogsBitfield = this.HasUnlockedTransmogsBitfield;
			if (hasUnlockedTransmogsBitfield)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.UnlockedTransmogsBitfield);
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

		// Token: 0x0600269B RID: 9883 RVA: 0x00095E34 File Offset: 0x00094034
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockedTransmogs_.CalculateSize(UnlockedTransmogs._repeated_unlockedTransmogs_codec);
			bool hasUnlockedTransmogsBitfield = this.HasUnlockedTransmogsBitfield;
			if (hasUnlockedTransmogsBitfield)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.UnlockedTransmogsBitfield);
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

		// Token: 0x0600269C RID: 9884 RVA: 0x00095EB4 File Offset: 0x000940B4
		[DebuggerNonUserCode]
		public void MergeFrom(UnlockedTransmogs other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.unlockedTransmogs_.Add(other.unlockedTransmogs_);
				bool hasUnlockedTransmogsBitfield = other.HasUnlockedTransmogsBitfield;
				if (hasUnlockedTransmogsBitfield)
				{
					this.UnlockedTransmogsBitfield = other.UnlockedTransmogsBitfield;
				}
				bool hasBitfieldLeadingNullBytes = other.HasBitfieldLeadingNullBytes;
				if (hasBitfieldLeadingNullBytes)
				{
					this.BitfieldLeadingNullBytes = other.BitfieldLeadingNullBytes;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600269D RID: 9885 RVA: 0x00095F28 File Offset: 0x00094128
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x00095F34 File Offset: 0x00094134
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
					this.unlockedTransmogs_.AddEntriesFrom(ref input, UnlockedTransmogs._repeated_unlockedTransmogs_codec);
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
					this.UnlockedTransmogsBitfield = input.ReadBytes();
				}
				continue;
				IL_0029:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400110B RID: 4363
		private static readonly MessageParser<UnlockedTransmogs> _parser = new MessageParser<UnlockedTransmogs>(() => new UnlockedTransmogs());

		// Token: 0x0400110C RID: 4364
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400110D RID: 4365
		private int _hasBits0;

		// Token: 0x0400110E RID: 4366
		public const int UnlockedTransmogs_FieldNumber = 1;

		// Token: 0x0400110F RID: 4367
		private static readonly FieldCodec<int> _repeated_unlockedTransmogs_codec = FieldCodec.ForSFixed32(13U);

		// Token: 0x04001110 RID: 4368
		private readonly RepeatedField<int> unlockedTransmogs_ = new RepeatedField<int>();

		// Token: 0x04001111 RID: 4369
		public const int UnlockedTransmogsBitfieldFieldNumber = 2;

		// Token: 0x04001112 RID: 4370
		private static readonly ByteString UnlockedTransmogsBitfieldDefaultValue = ByteString.Empty;

		// Token: 0x04001113 RID: 4371
		private ByteString unlockedTransmogsBitfield_;

		// Token: 0x04001114 RID: 4372
		public const int BitfieldLeadingNullBytesFieldNumber = 3;

		// Token: 0x04001115 RID: 4373
		private static readonly int BitfieldLeadingNullBytesDefaultValue = 0;

		// Token: 0x04001116 RID: 4374
		private int bitfieldLeadingNullBytes_;
	}
}
