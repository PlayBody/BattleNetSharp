using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Search
{
	// Token: 0x02000121 RID: 289
	public sealed class Criteria : IMessage<Criteria>, IMessage, IEquatable<Criteria>, IDeepCloneable<Criteria>, IBufferMessage
	{
		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06001CC7 RID: 7367 RVA: 0x0006E184 File Offset: 0x0006C384
		[DebuggerNonUserCode]
		public static MessageParser<Criteria> Parser
		{
			get
			{
				return Criteria._parser;
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06001CC8 RID: 7368 RVA: 0x0006E19C File Offset: 0x0006C39C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SearchReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06001CC9 RID: 7369 RVA: 0x0006E1C0 File Offset: 0x0006C3C0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Criteria.Descriptor;
			}
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x0006E1D7 File Offset: 0x0006C3D7
		[DebuggerNonUserCode]
		public Criteria()
		{
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x0006E1EC File Offset: 0x0006C3EC
		[DebuggerNonUserCode]
		public Criteria(Criteria other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.documentType_ = other.documentType_;
			this.maxResults_ = other.maxResults_;
			this.text_ = other.text_;
			this.attribute_ = other.attribute_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x0006E254 File Offset: 0x0006C454
		[DebuggerNonUserCode]
		public Criteria Clone()
		{
			return new Criteria(this);
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06001CCD RID: 7373 RVA: 0x0006E26C File Offset: 0x0006C46C
		// (set) Token: 0x06001CCE RID: 7374 RVA: 0x0006E29D File Offset: 0x0006C49D
		[DebuggerNonUserCode]
		public uint DocumentType
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint documentTypeDefaultValue;
				if (flag)
				{
					documentTypeDefaultValue = this.documentType_;
				}
				else
				{
					documentTypeDefaultValue = Criteria.DocumentTypeDefaultValue;
				}
				return documentTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.documentType_ = value;
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06001CCF RID: 7375 RVA: 0x0006E2B8 File Offset: 0x0006C4B8
		[DebuggerNonUserCode]
		public bool HasDocumentType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x0006E2D5 File Offset: 0x0006C4D5
		[DebuggerNonUserCode]
		public void ClearDocumentType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06001CD1 RID: 7377 RVA: 0x0006E2E8 File Offset: 0x0006C4E8
		// (set) Token: 0x06001CD2 RID: 7378 RVA: 0x0006E319 File Offset: 0x0006C519
		[DebuggerNonUserCode]
		public uint MaxResults
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint maxResultsDefaultValue;
				if (flag)
				{
					maxResultsDefaultValue = this.maxResults_;
				}
				else
				{
					maxResultsDefaultValue = Criteria.MaxResultsDefaultValue;
				}
				return maxResultsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.maxResults_ = value;
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06001CD3 RID: 7379 RVA: 0x0006E334 File Offset: 0x0006C534
		[DebuggerNonUserCode]
		public bool HasMaxResults
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x0006E351 File Offset: 0x0006C551
		[DebuggerNonUserCode]
		public void ClearMaxResults()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06001CD5 RID: 7381 RVA: 0x0006E364 File Offset: 0x0006C564
		// (set) Token: 0x06001CD6 RID: 7382 RVA: 0x0006E385 File Offset: 0x0006C585
		[DebuggerNonUserCode]
		public string Text
		{
			get
			{
				return this.text_ ?? Criteria.TextDefaultValue;
			}
			set
			{
				this.text_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06001CD7 RID: 7383 RVA: 0x0006E39C File Offset: 0x0006C59C
		[DebuggerNonUserCode]
		public bool HasText
		{
			get
			{
				return this.text_ != null;
			}
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x0006E3B7 File Offset: 0x0006C5B7
		[DebuggerNonUserCode]
		public void ClearText()
		{
			this.text_ = null;
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06001CD9 RID: 7385 RVA: 0x0006E3C4 File Offset: 0x0006C5C4
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x0006E3DC File Offset: 0x0006C5DC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Criteria);
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x0006E3FC File Offset: 0x0006C5FC
		[DebuggerNonUserCode]
		public bool Equals(Criteria other)
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
					bool flag4 = this.DocumentType != other.DocumentType;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.MaxResults != other.MaxResults;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Text != other.Text;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.attribute_.Equals(other.attribute_);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x0006E4AC File Offset: 0x0006C6AC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasDocumentType = this.HasDocumentType;
			if (hasDocumentType)
			{
				num ^= this.DocumentType.GetHashCode();
			}
			bool hasMaxResults = this.HasMaxResults;
			if (hasMaxResults)
			{
				num ^= this.MaxResults.GetHashCode();
			}
			bool hasText = this.HasText;
			if (hasText)
			{
				num ^= this.Text.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x0006E540 File Offset: 0x0006C740
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x0006E558 File Offset: 0x0006C758
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x0006E564 File Offset: 0x0006C764
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasDocumentType = this.HasDocumentType;
			if (hasDocumentType)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.DocumentType);
			}
			bool hasMaxResults = this.HasMaxResults;
			if (hasMaxResults)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.MaxResults);
			}
			bool hasText = this.HasText;
			if (hasText)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Text);
			}
			this.attribute_.WriteTo(ref output, Criteria._repeated_attribute_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x0006E608 File Offset: 0x0006C808
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasDocumentType = this.HasDocumentType;
			if (hasDocumentType)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DocumentType);
			}
			bool hasMaxResults = this.HasMaxResults;
			if (hasMaxResults)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxResults);
			}
			bool hasText = this.HasText;
			if (hasText)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Text);
			}
			num += this.attribute_.CalculateSize(Criteria._repeated_attribute_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x0006E6A8 File Offset: 0x0006C8A8
		[DebuggerNonUserCode]
		public void MergeFrom(Criteria other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasDocumentType = other.HasDocumentType;
				if (hasDocumentType)
				{
					this.DocumentType = other.DocumentType;
				}
				bool hasMaxResults = other.HasMaxResults;
				if (hasMaxResults)
				{
					this.MaxResults = other.MaxResults;
				}
				bool hasText = other.HasText;
				if (hasText)
				{
					this.Text = other.Text;
				}
				this.attribute_.Add(other.attribute_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x0006E735 File Offset: 0x0006C935
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x0006E740 File Offset: 0x0006C940
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
							goto IL_0028;
						}
						this.MaxResults = input.ReadUInt32();
					}
					else
					{
						this.DocumentType = input.ReadUInt32();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 34U)
					{
						goto IL_0028;
					}
					this.attribute_.AddEntriesFrom(ref input, Criteria._repeated_attribute_codec);
				}
				else
				{
					this.Text = input.ReadString();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000C3E RID: 3134
		private static readonly MessageParser<Criteria> _parser = new MessageParser<Criteria>(() => new Criteria());

		// Token: 0x04000C3F RID: 3135
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C40 RID: 3136
		private int _hasBits0;

		// Token: 0x04000C41 RID: 3137
		public const int DocumentTypeFieldNumber = 1;

		// Token: 0x04000C42 RID: 3138
		private static readonly uint DocumentTypeDefaultValue = 0U;

		// Token: 0x04000C43 RID: 3139
		private uint documentType_;

		// Token: 0x04000C44 RID: 3140
		public const int MaxResultsFieldNumber = 2;

		// Token: 0x04000C45 RID: 3141
		private static readonly uint MaxResultsDefaultValue = 0U;

		// Token: 0x04000C46 RID: 3142
		private uint maxResults_;

		// Token: 0x04000C47 RID: 3143
		public const int TextFieldNumber = 3;

		// Token: 0x04000C48 RID: 3144
		private static readonly string TextDefaultValue = "";

		// Token: 0x04000C49 RID: 3145
		private string text_;

		// Token: 0x04000C4A RID: 3146
		public const int AttributeFieldNumber = 4;

		// Token: 0x04000C4B RID: 3147
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(34U, Fenris.Search.Attribute.Parser);

		// Token: 0x04000C4C RID: 3148
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();
	}
}
