using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x020001B0 RID: 432
	public sealed class AssetListDataStore : IMessage<AssetListDataStore>, IMessage, IEquatable<AssetListDataStore>, IDeepCloneable<AssetListDataStore>, IBufferMessage
	{
		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x06002D90 RID: 11664 RVA: 0x000B25F8 File Offset: 0x000B07F8
		[DebuggerNonUserCode]
		public static MessageParser<AssetListDataStore> Parser
		{
			get
			{
				return AssetListDataStore._parser;
			}
		}

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x06002D91 RID: 11665 RVA: 0x000B2610 File Offset: 0x000B0810
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroCommonReflection.Descriptor.MessageTypes[22];
			}
		}

		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x06002D92 RID: 11666 RVA: 0x000B2634 File Offset: 0x000B0834
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AssetListDataStore.Descriptor;
			}
		}

		// Token: 0x06002D93 RID: 11667 RVA: 0x000B264B File Offset: 0x000B084B
		[DebuggerNonUserCode]
		public AssetListDataStore()
		{
		}

		// Token: 0x06002D94 RID: 11668 RVA: 0x000B2660 File Offset: 0x000B0860
		[DebuggerNonUserCode]
		public AssetListDataStore(AssetListDataStore other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.assetIds_ = other.assetIds_.Clone();
			this.bitfield_ = other.bitfield_;
			this.leadingNullBytes_ = other.leadingNullBytes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002D95 RID: 11669 RVA: 0x000B26BC File Offset: 0x000B08BC
		[DebuggerNonUserCode]
		public AssetListDataStore Clone()
		{
			return new AssetListDataStore(this);
		}

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x06002D96 RID: 11670 RVA: 0x000B26D4 File Offset: 0x000B08D4
		[DebuggerNonUserCode]
		public RepeatedField<int> AssetIds
		{
			get
			{
				return this.assetIds_;
			}
		}

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x06002D97 RID: 11671 RVA: 0x000B26EC File Offset: 0x000B08EC
		// (set) Token: 0x06002D98 RID: 11672 RVA: 0x000B270D File Offset: 0x000B090D
		[DebuggerNonUserCode]
		public ByteString Bitfield
		{
			get
			{
				return this.bitfield_ ?? AssetListDataStore.BitfieldDefaultValue;
			}
			set
			{
				this.bitfield_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x06002D99 RID: 11673 RVA: 0x000B2724 File Offset: 0x000B0924
		[DebuggerNonUserCode]
		public bool HasBitfield
		{
			get
			{
				return this.bitfield_ != null;
			}
		}

		// Token: 0x06002D9A RID: 11674 RVA: 0x000B2742 File Offset: 0x000B0942
		[DebuggerNonUserCode]
		public void ClearBitfield()
		{
			this.bitfield_ = null;
		}

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x06002D9B RID: 11675 RVA: 0x000B274C File Offset: 0x000B094C
		// (set) Token: 0x06002D9C RID: 11676 RVA: 0x000B277D File Offset: 0x000B097D
		[DebuggerNonUserCode]
		public int LeadingNullBytes
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int leadingNullBytesDefaultValue;
				if (flag)
				{
					leadingNullBytesDefaultValue = this.leadingNullBytes_;
				}
				else
				{
					leadingNullBytesDefaultValue = AssetListDataStore.LeadingNullBytesDefaultValue;
				}
				return leadingNullBytesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.leadingNullBytes_ = value;
			}
		}

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x06002D9D RID: 11677 RVA: 0x000B2798 File Offset: 0x000B0998
		[DebuggerNonUserCode]
		public bool HasLeadingNullBytes
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002D9E RID: 11678 RVA: 0x000B27B5 File Offset: 0x000B09B5
		[DebuggerNonUserCode]
		public void ClearLeadingNullBytes()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06002D9F RID: 11679 RVA: 0x000B27C8 File Offset: 0x000B09C8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AssetListDataStore);
		}

		// Token: 0x06002DA0 RID: 11680 RVA: 0x000B27E8 File Offset: 0x000B09E8
		[DebuggerNonUserCode]
		public bool Equals(AssetListDataStore other)
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
					bool flag4 = !this.assetIds_.Equals(other.assetIds_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Bitfield != other.Bitfield;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.LeadingNullBytes != other.LeadingNullBytes;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002DA1 RID: 11681 RVA: 0x000B2878 File Offset: 0x000B0A78
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.assetIds_.GetHashCode();
			bool hasBitfield = this.HasBitfield;
			if (hasBitfield)
			{
				num ^= this.Bitfield.GetHashCode();
			}
			bool hasLeadingNullBytes = this.HasLeadingNullBytes;
			if (hasLeadingNullBytes)
			{
				num ^= this.LeadingNullBytes.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002DA2 RID: 11682 RVA: 0x000B28F0 File Offset: 0x000B0AF0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002DA3 RID: 11683 RVA: 0x000B2908 File Offset: 0x000B0B08
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x000B2914 File Offset: 0x000B0B14
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.assetIds_.WriteTo(ref output, AssetListDataStore._repeated_assetIds_codec);
			bool hasBitfield = this.HasBitfield;
			if (hasBitfield)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.Bitfield);
			}
			bool hasLeadingNullBytes = this.HasLeadingNullBytes;
			if (hasLeadingNullBytes)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.LeadingNullBytes);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x000B2994 File Offset: 0x000B0B94
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.assetIds_.CalculateSize(AssetListDataStore._repeated_assetIds_codec);
			bool hasBitfield = this.HasBitfield;
			if (hasBitfield)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Bitfield);
			}
			bool hasLeadingNullBytes = this.HasLeadingNullBytes;
			if (hasLeadingNullBytes)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LeadingNullBytes);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002DA6 RID: 11686 RVA: 0x000B2A14 File Offset: 0x000B0C14
		[DebuggerNonUserCode]
		public void MergeFrom(AssetListDataStore other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.assetIds_.Add(other.assetIds_);
				bool hasBitfield = other.HasBitfield;
				if (hasBitfield)
				{
					this.Bitfield = other.Bitfield;
				}
				bool hasLeadingNullBytes = other.HasLeadingNullBytes;
				if (hasLeadingNullBytes)
				{
					this.LeadingNullBytes = other.LeadingNullBytes;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002DA7 RID: 11687 RVA: 0x000B2A88 File Offset: 0x000B0C88
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002DA8 RID: 11688 RVA: 0x000B2A94 File Offset: 0x000B0C94
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
					this.assetIds_.AddEntriesFrom(ref input, AssetListDataStore._repeated_assetIds_codec);
				}
				else if (num3 != 18U)
				{
					if (num3 != 24U)
					{
						goto IL_0029;
					}
					this.LeadingNullBytes = input.ReadInt32();
				}
				else
				{
					this.Bitfield = input.ReadBytes();
				}
				continue;
				IL_0029:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400148F RID: 5263
		private static readonly MessageParser<AssetListDataStore> _parser = new MessageParser<AssetListDataStore>(() => new AssetListDataStore());

		// Token: 0x04001490 RID: 5264
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001491 RID: 5265
		private int _hasBits0;

		// Token: 0x04001492 RID: 5266
		public const int AssetIdsFieldNumber = 1;

		// Token: 0x04001493 RID: 5267
		private static readonly FieldCodec<int> _repeated_assetIds_codec = FieldCodec.ForSFixed32(13U);

		// Token: 0x04001494 RID: 5268
		private readonly RepeatedField<int> assetIds_ = new RepeatedField<int>();

		// Token: 0x04001495 RID: 5269
		public const int BitfieldFieldNumber = 2;

		// Token: 0x04001496 RID: 5270
		private static readonly ByteString BitfieldDefaultValue = ByteString.Empty;

		// Token: 0x04001497 RID: 5271
		private ByteString bitfield_;

		// Token: 0x04001498 RID: 5272
		public const int LeadingNullBytesFieldNumber = 3;

		// Token: 0x04001499 RID: 5273
		private static readonly int LeadingNullBytesDefaultValue = 0;

		// Token: 0x0400149A RID: 5274
		private int leadingNullBytes_;
	}
}
