using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Search
{
	// Token: 0x0200011D RID: 285
	public sealed class Results : IMessage<Results>, IMessage, IEquatable<Results>, IDeepCloneable<Results>, IBufferMessage
	{
		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06001BFD RID: 7165 RVA: 0x0006ABA8 File Offset: 0x00068DA8
		[DebuggerNonUserCode]
		public static MessageParser<Results> Parser
		{
			get
			{
				return Results._parser;
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06001BFE RID: 7166 RVA: 0x0006ABC0 File Offset: 0x00068DC0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SearchReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06001BFF RID: 7167 RVA: 0x0006ABE4 File Offset: 0x00068DE4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Results.Descriptor;
			}
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x0006ABFB File Offset: 0x00068DFB
		[DebuggerNonUserCode]
		public Results()
		{
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x0006AC10 File Offset: 0x00068E10
		[DebuggerNonUserCode]
		public Results(Results other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clientSearchToken_ = other.clientSearchToken_;
			this.documentType_ = other.documentType_;
			this.document_ = other.document_.Clone();
			this.offset_ = other.offset_;
			this.more_ = other.more_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x0006AC84 File Offset: 0x00068E84
		[DebuggerNonUserCode]
		public Results Clone()
		{
			return new Results(this);
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06001C03 RID: 7171 RVA: 0x0006AC9C File Offset: 0x00068E9C
		// (set) Token: 0x06001C04 RID: 7172 RVA: 0x0006ACCD File Offset: 0x00068ECD
		[DebuggerNonUserCode]
		public ulong ClientSearchToken
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong clientSearchTokenDefaultValue;
				if (flag)
				{
					clientSearchTokenDefaultValue = this.clientSearchToken_;
				}
				else
				{
					clientSearchTokenDefaultValue = Results.ClientSearchTokenDefaultValue;
				}
				return clientSearchTokenDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clientSearchToken_ = value;
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06001C05 RID: 7173 RVA: 0x0006ACE8 File Offset: 0x00068EE8
		[DebuggerNonUserCode]
		public bool HasClientSearchToken
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x0006AD05 File Offset: 0x00068F05
		[DebuggerNonUserCode]
		public void ClearClientSearchToken()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06001C07 RID: 7175 RVA: 0x0006AD18 File Offset: 0x00068F18
		// (set) Token: 0x06001C08 RID: 7176 RVA: 0x0006AD49 File Offset: 0x00068F49
		[DebuggerNonUserCode]
		public uint DocumentType
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint documentTypeDefaultValue;
				if (flag)
				{
					documentTypeDefaultValue = this.documentType_;
				}
				else
				{
					documentTypeDefaultValue = Results.DocumentTypeDefaultValue;
				}
				return documentTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.documentType_ = value;
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06001C09 RID: 7177 RVA: 0x0006AD64 File Offset: 0x00068F64
		[DebuggerNonUserCode]
		public bool HasDocumentType
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x0006AD81 File Offset: 0x00068F81
		[DebuggerNonUserCode]
		public void ClearDocumentType()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06001C0B RID: 7179 RVA: 0x0006AD94 File Offset: 0x00068F94
		[DebuggerNonUserCode]
		public RepeatedField<ByteString> Document
		{
			get
			{
				return this.document_;
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06001C0C RID: 7180 RVA: 0x0006ADAC File Offset: 0x00068FAC
		// (set) Token: 0x06001C0D RID: 7181 RVA: 0x0006ADDD File Offset: 0x00068FDD
		[DebuggerNonUserCode]
		public uint Offset
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint offsetDefaultValue;
				if (flag)
				{
					offsetDefaultValue = this.offset_;
				}
				else
				{
					offsetDefaultValue = Results.OffsetDefaultValue;
				}
				return offsetDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.offset_ = value;
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06001C0E RID: 7182 RVA: 0x0006ADF8 File Offset: 0x00068FF8
		[DebuggerNonUserCode]
		public bool HasOffset
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x0006AE15 File Offset: 0x00069015
		[DebuggerNonUserCode]
		public void ClearOffset()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06001C10 RID: 7184 RVA: 0x0006AE28 File Offset: 0x00069028
		// (set) Token: 0x06001C11 RID: 7185 RVA: 0x0006AE59 File Offset: 0x00069059
		[DebuggerNonUserCode]
		public bool More
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool moreDefaultValue;
				if (flag)
				{
					moreDefaultValue = this.more_;
				}
				else
				{
					moreDefaultValue = Results.MoreDefaultValue;
				}
				return moreDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.more_ = value;
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06001C12 RID: 7186 RVA: 0x0006AE74 File Offset: 0x00069074
		[DebuggerNonUserCode]
		public bool HasMore
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x0006AE91 File Offset: 0x00069091
		[DebuggerNonUserCode]
		public void ClearMore()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x0006AEA4 File Offset: 0x000690A4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Results);
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x0006AEC4 File Offset: 0x000690C4
		[DebuggerNonUserCode]
		public bool Equals(Results other)
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
					bool flag4 = this.ClientSearchToken != other.ClientSearchToken;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.DocumentType != other.DocumentType;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.document_.Equals(other.document_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Offset != other.Offset;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.More != other.More;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x0006AF94 File Offset: 0x00069194
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClientSearchToken = this.HasClientSearchToken;
			if (hasClientSearchToken)
			{
				num ^= this.ClientSearchToken.GetHashCode();
			}
			bool hasDocumentType = this.HasDocumentType;
			if (hasDocumentType)
			{
				num ^= this.DocumentType.GetHashCode();
			}
			num ^= this.document_.GetHashCode();
			bool hasOffset = this.HasOffset;
			if (hasOffset)
			{
				num ^= this.Offset.GetHashCode();
			}
			bool hasMore = this.HasMore;
			if (hasMore)
			{
				num ^= this.More.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x0006B04C File Offset: 0x0006924C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x0006B064 File Offset: 0x00069264
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x0006B070 File Offset: 0x00069270
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClientSearchToken = this.HasClientSearchToken;
			if (hasClientSearchToken)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.ClientSearchToken);
			}
			bool hasDocumentType = this.HasDocumentType;
			if (hasDocumentType)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.DocumentType);
			}
			this.document_.WriteTo(ref output, Results._repeated_document_codec);
			bool hasOffset = this.HasOffset;
			if (hasOffset)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Offset);
			}
			bool hasMore = this.HasMore;
			if (hasMore)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.More);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x0006B138 File Offset: 0x00069338
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClientSearchToken = this.HasClientSearchToken;
			if (hasClientSearchToken)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ClientSearchToken);
			}
			bool hasDocumentType = this.HasDocumentType;
			if (hasDocumentType)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DocumentType);
			}
			num += this.document_.CalculateSize(Results._repeated_document_codec);
			bool hasOffset = this.HasOffset;
			if (hasOffset)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Offset);
			}
			bool hasMore = this.HasMore;
			if (hasMore)
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

		// Token: 0x06001C1B RID: 7195 RVA: 0x0006B1E8 File Offset: 0x000693E8
		[DebuggerNonUserCode]
		public void MergeFrom(Results other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClientSearchToken = other.HasClientSearchToken;
				if (hasClientSearchToken)
				{
					this.ClientSearchToken = other.ClientSearchToken;
				}
				bool hasDocumentType = other.HasDocumentType;
				if (hasDocumentType)
				{
					this.DocumentType = other.DocumentType;
				}
				this.document_.Add(other.document_);
				bool hasOffset = other.HasOffset;
				if (hasOffset)
				{
					this.Offset = other.Offset;
				}
				bool hasMore = other.HasMore;
				if (hasMore)
				{
					this.More = other.More;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x0006B293 File Offset: 0x00069493
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x0006B2A0 File Offset: 0x000694A0
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
							goto IL_0032;
						}
						this.DocumentType = input.ReadUInt32();
					}
					else
					{
						this.ClientSearchToken = input.ReadUInt64();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 32U)
					{
						if (num3 != 40U)
						{
							goto IL_0032;
						}
						this.More = input.ReadBool();
					}
					else
					{
						this.Offset = input.ReadUInt32();
					}
				}
				else
				{
					this.document_.AddEntriesFrom(ref input, Results._repeated_document_codec);
				}
				continue;
				IL_0032:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000BCF RID: 3023
		private static readonly MessageParser<Results> _parser = new MessageParser<Results>(() => new Results());

		// Token: 0x04000BD0 RID: 3024
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000BD1 RID: 3025
		private int _hasBits0;

		// Token: 0x04000BD2 RID: 3026
		public const int ClientSearchTokenFieldNumber = 1;

		// Token: 0x04000BD3 RID: 3027
		private static readonly ulong ClientSearchTokenDefaultValue = 0UL;

		// Token: 0x04000BD4 RID: 3028
		private ulong clientSearchToken_;

		// Token: 0x04000BD5 RID: 3029
		public const int DocumentTypeFieldNumber = 2;

		// Token: 0x04000BD6 RID: 3030
		private static readonly uint DocumentTypeDefaultValue = 0U;

		// Token: 0x04000BD7 RID: 3031
		private uint documentType_;

		// Token: 0x04000BD8 RID: 3032
		public const int DocumentFieldNumber = 3;

		// Token: 0x04000BD9 RID: 3033
		private static readonly FieldCodec<ByteString> _repeated_document_codec = FieldCodec.ForBytes(26U);

		// Token: 0x04000BDA RID: 3034
		private readonly RepeatedField<ByteString> document_ = new RepeatedField<ByteString>();

		// Token: 0x04000BDB RID: 3035
		public const int OffsetFieldNumber = 4;

		// Token: 0x04000BDC RID: 3036
		private static readonly uint OffsetDefaultValue = 0U;

		// Token: 0x04000BDD RID: 3037
		private uint offset_;

		// Token: 0x04000BDE RID: 3038
		public const int MoreFieldNumber = 5;

		// Token: 0x04000BDF RID: 3039
		private static readonly bool MoreDefaultValue = false;

		// Token: 0x04000BE0 RID: 3040
		private bool more_;
	}
}
