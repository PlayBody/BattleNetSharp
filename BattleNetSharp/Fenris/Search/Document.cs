using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Search
{
	// Token: 0x02000120 RID: 288
	public sealed class Document : IMessage<Document>, IMessage, IEquatable<Document>, IDeepCloneable<Document>, IBufferMessage
	{
		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06001CA0 RID: 7328 RVA: 0x0006D7A4 File Offset: 0x0006B9A4
		[DebuggerNonUserCode]
		public static MessageParser<Document> Parser
		{
			get
			{
				return Document._parser;
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06001CA1 RID: 7329 RVA: 0x0006D7BC File Offset: 0x0006B9BC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SearchReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06001CA2 RID: 7330 RVA: 0x0006D7E0 File Offset: 0x0006B9E0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Document.Descriptor;
			}
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x0006D7F7 File Offset: 0x0006B9F7
		[DebuggerNonUserCode]
		public Document()
		{
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x0006D818 File Offset: 0x0006BA18
		[DebuggerNonUserCode]
		public Document(Document other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.type_ = other.type_;
			this.data_ = other.data_;
			this.indexingText_ = other.indexingText_.Clone();
			this.attribute_ = other.attribute_.Clone();
			this.sortScore_ = other.sortScore_;
			this.lastActivityTime_ = other.lastActivityTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x0006D8A8 File Offset: 0x0006BAA8
		[DebuggerNonUserCode]
		public Document Clone()
		{
			return new Document(this);
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06001CA6 RID: 7334 RVA: 0x0006D8C0 File Offset: 0x0006BAC0
		// (set) Token: 0x06001CA7 RID: 7335 RVA: 0x0006D8E1 File Offset: 0x0006BAE1
		[DebuggerNonUserCode]
		public string Id
		{
			get
			{
				return this.id_ ?? Document.IdDefaultValue;
			}
			set
			{
				this.id_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06001CA8 RID: 7336 RVA: 0x0006D8F8 File Offset: 0x0006BAF8
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return this.id_ != null;
			}
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x0006D913 File Offset: 0x0006BB13
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this.id_ = null;
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06001CAA RID: 7338 RVA: 0x0006D920 File Offset: 0x0006BB20
		// (set) Token: 0x06001CAB RID: 7339 RVA: 0x0006D951 File Offset: 0x0006BB51
		[DebuggerNonUserCode]
		public uint Type
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint typeDefaultValue;
				if (flag)
				{
					typeDefaultValue = this.type_;
				}
				else
				{
					typeDefaultValue = Document.TypeDefaultValue;
				}
				return typeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.type_ = value;
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06001CAC RID: 7340 RVA: 0x0006D96C File Offset: 0x0006BB6C
		[DebuggerNonUserCode]
		public bool HasType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x0006D989 File Offset: 0x0006BB89
		[DebuggerNonUserCode]
		public void ClearType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06001CAE RID: 7342 RVA: 0x0006D99C File Offset: 0x0006BB9C
		// (set) Token: 0x06001CAF RID: 7343 RVA: 0x0006D9BD File Offset: 0x0006BBBD
		[DebuggerNonUserCode]
		public ByteString Data
		{
			get
			{
				return this.data_ ?? Document.DataDefaultValue;
			}
			set
			{
				this.data_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x0006D9D4 File Offset: 0x0006BBD4
		[DebuggerNonUserCode]
		public bool HasData
		{
			get
			{
				return this.data_ != null;
			}
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x0006D9F2 File Offset: 0x0006BBF2
		[DebuggerNonUserCode]
		public void ClearData()
		{
			this.data_ = null;
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x0006D9FC File Offset: 0x0006BBFC
		[DebuggerNonUserCode]
		public RepeatedField<string> IndexingText
		{
			get
			{
				return this.indexingText_;
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06001CB3 RID: 7347 RVA: 0x0006DA14 File Offset: 0x0006BC14
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06001CB4 RID: 7348 RVA: 0x0006DA2C File Offset: 0x0006BC2C
		// (set) Token: 0x06001CB5 RID: 7349 RVA: 0x0006DA5D File Offset: 0x0006BC5D
		[DebuggerNonUserCode]
		public ulong SortScore
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong sortScoreDefaultValue;
				if (flag)
				{
					sortScoreDefaultValue = this.sortScore_;
				}
				else
				{
					sortScoreDefaultValue = Document.SortScoreDefaultValue;
				}
				return sortScoreDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.sortScore_ = value;
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06001CB6 RID: 7350 RVA: 0x0006DA78 File Offset: 0x0006BC78
		[DebuggerNonUserCode]
		public bool HasSortScore
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x0006DA95 File Offset: 0x0006BC95
		[DebuggerNonUserCode]
		public void ClearSortScore()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06001CB8 RID: 7352 RVA: 0x0006DAA8 File Offset: 0x0006BCA8
		// (set) Token: 0x06001CB9 RID: 7353 RVA: 0x0006DAD9 File Offset: 0x0006BCD9
		[DebuggerNonUserCode]
		public ulong LastActivityTime
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong lastActivityTimeDefaultValue;
				if (flag)
				{
					lastActivityTimeDefaultValue = this.lastActivityTime_;
				}
				else
				{
					lastActivityTimeDefaultValue = Document.LastActivityTimeDefaultValue;
				}
				return lastActivityTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.lastActivityTime_ = value;
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06001CBA RID: 7354 RVA: 0x0006DAF4 File Offset: 0x0006BCF4
		[DebuggerNonUserCode]
		public bool HasLastActivityTime
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x0006DB11 File Offset: 0x0006BD11
		[DebuggerNonUserCode]
		public void ClearLastActivityTime()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x0006DB24 File Offset: 0x0006BD24
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Document);
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x0006DB44 File Offset: 0x0006BD44
		[DebuggerNonUserCode]
		public bool Equals(Document other)
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
					bool flag4 = this.Id != other.Id;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Type != other.Type;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Data != other.Data;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.indexingText_.Equals(other.indexingText_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.attribute_.Equals(other.attribute_);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.SortScore != other.SortScore;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.LastActivityTime != other.LastActivityTime;
											flag2 = !flag10 && object.Equals(this._unknownFields, other._unknownFields);
										}
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x0006DC54 File Offset: 0x0006BE54
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				num ^= this.Type.GetHashCode();
			}
			bool hasData = this.HasData;
			if (hasData)
			{
				num ^= this.Data.GetHashCode();
			}
			num ^= this.indexingText_.GetHashCode();
			num ^= this.attribute_.GetHashCode();
			bool hasSortScore = this.HasSortScore;
			if (hasSortScore)
			{
				num ^= this.SortScore.GetHashCode();
			}
			bool hasLastActivityTime = this.HasLastActivityTime;
			if (hasLastActivityTime)
			{
				num ^= this.LastActivityTime.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x0006DD30 File Offset: 0x0006BF30
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x0006DD48 File Offset: 0x0006BF48
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x0006DD54 File Offset: 0x0006BF54
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Id);
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Type);
			}
			bool hasData = this.HasData;
			if (hasData)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.Data);
			}
			this.indexingText_.WriteTo(ref output, Document._repeated_indexingText_codec);
			this.attribute_.WriteTo(ref output, Document._repeated_attribute_codec);
			bool hasSortScore = this.HasSortScore;
			if (hasSortScore)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(this.SortScore);
			}
			bool hasLastActivityTime = this.HasLastActivityTime;
			if (hasLastActivityTime)
			{
				output.WriteRawTag(56);
				output.WriteUInt64(this.LastActivityTime);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x0006DE50 File Offset: 0x0006C050
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Id);
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Type);
			}
			bool hasData = this.HasData;
			if (hasData)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Data);
			}
			num += this.indexingText_.CalculateSize(Document._repeated_indexingText_codec);
			num += this.attribute_.CalculateSize(Document._repeated_attribute_codec);
			bool hasSortScore = this.HasSortScore;
			if (hasSortScore)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.SortScore);
			}
			bool hasLastActivityTime = this.HasLastActivityTime;
			if (hasLastActivityTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.LastActivityTime);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x0006DF3C File Offset: 0x0006C13C
		[DebuggerNonUserCode]
		public void MergeFrom(Document other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasType = other.HasType;
				if (hasType)
				{
					this.Type = other.Type;
				}
				bool hasData = other.HasData;
				if (hasData)
				{
					this.Data = other.Data;
				}
				this.indexingText_.Add(other.indexingText_);
				this.attribute_.Add(other.attribute_);
				bool hasSortScore = other.HasSortScore;
				if (hasSortScore)
				{
					this.SortScore = other.SortScore;
				}
				bool hasLastActivityTime = other.HasLastActivityTime;
				if (hasLastActivityTime)
				{
					this.LastActivityTime = other.LastActivityTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x0006E014 File Offset: 0x0006C214
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001CC5 RID: 7365 RVA: 0x0006E020 File Offset: 0x0006C220
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 26U)
				{
					if (num3 != 10U)
					{
						if (num3 != 16U)
						{
							if (num3 != 26U)
							{
								goto IL_0049;
							}
							this.Data = input.ReadBytes();
						}
						else
						{
							this.Type = input.ReadUInt32();
						}
					}
					else
					{
						this.Id = input.ReadString();
					}
				}
				else if (num3 <= 42U)
				{
					if (num3 != 34U)
					{
						if (num3 != 42U)
						{
							goto IL_0049;
						}
						this.attribute_.AddEntriesFrom(ref input, Document._repeated_attribute_codec);
					}
					else
					{
						this.indexingText_.AddEntriesFrom(ref input, Document._repeated_indexingText_codec);
					}
				}
				else if (num3 != 48U)
				{
					if (num3 != 56U)
					{
						goto IL_0049;
					}
					this.LastActivityTime = input.ReadUInt64();
				}
				else
				{
					this.SortScore = input.ReadUInt64();
				}
				continue;
				IL_0049:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000C26 RID: 3110
		private static readonly MessageParser<Document> _parser = new MessageParser<Document>(() => new Document());

		// Token: 0x04000C27 RID: 3111
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C28 RID: 3112
		private int _hasBits0;

		// Token: 0x04000C29 RID: 3113
		public const int IdFieldNumber = 1;

		// Token: 0x04000C2A RID: 3114
		private static readonly string IdDefaultValue = "";

		// Token: 0x04000C2B RID: 3115
		private string id_;

		// Token: 0x04000C2C RID: 3116
		public const int TypeFieldNumber = 2;

		// Token: 0x04000C2D RID: 3117
		private static readonly uint TypeDefaultValue = 0U;

		// Token: 0x04000C2E RID: 3118
		private uint type_;

		// Token: 0x04000C2F RID: 3119
		public const int DataFieldNumber = 3;

		// Token: 0x04000C30 RID: 3120
		private static readonly ByteString DataDefaultValue = ByteString.Empty;

		// Token: 0x04000C31 RID: 3121
		private ByteString data_;

		// Token: 0x04000C32 RID: 3122
		public const int IndexingTextFieldNumber = 4;

		// Token: 0x04000C33 RID: 3123
		private static readonly FieldCodec<string> _repeated_indexingText_codec = FieldCodec.ForString(34U);

		// Token: 0x04000C34 RID: 3124
		private readonly RepeatedField<string> indexingText_ = new RepeatedField<string>();

		// Token: 0x04000C35 RID: 3125
		public const int AttributeFieldNumber = 5;

		// Token: 0x04000C36 RID: 3126
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(42U, Fenris.Search.Attribute.Parser);

		// Token: 0x04000C37 RID: 3127
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		// Token: 0x04000C38 RID: 3128
		public const int SortScoreFieldNumber = 6;

		// Token: 0x04000C39 RID: 3129
		private static readonly ulong SortScoreDefaultValue = 0UL;

		// Token: 0x04000C3A RID: 3130
		private ulong sortScore_;

		// Token: 0x04000C3B RID: 3131
		public const int LastActivityTimeFieldNumber = 7;

		// Token: 0x04000C3C RID: 3132
		private static readonly ulong LastActivityTimeDefaultValue = 0UL;

		// Token: 0x04000C3D RID: 3133
		private ulong lastActivityTime_;
	}
}
