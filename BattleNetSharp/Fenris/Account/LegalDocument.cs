using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Account
{
	// Token: 0x020002DC RID: 732
	public sealed class LegalDocument : IMessage<LegalDocument>, IMessage, IEquatable<LegalDocument>, IDeepCloneable<LegalDocument>, IBufferMessage
	{
		// Token: 0x17001891 RID: 6289
		// (get) Token: 0x06004D69 RID: 19817 RVA: 0x00128520 File Offset: 0x00126720
		[DebuggerNonUserCode]
		public static MessageParser<LegalDocument> Parser
		{
			get
			{
				return LegalDocument._parser;
			}
		}

		// Token: 0x17001892 RID: 6290
		// (get) Token: 0x06004D6A RID: 19818 RVA: 0x00128538 File Offset: 0x00126738
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x17001893 RID: 6291
		// (get) Token: 0x06004D6B RID: 19819 RVA: 0x0012855C File Offset: 0x0012675C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LegalDocument.Descriptor;
			}
		}

		// Token: 0x06004D6C RID: 19820 RVA: 0x00128573 File Offset: 0x00126773
		[DebuggerNonUserCode]
		public LegalDocument()
		{
		}

		// Token: 0x06004D6D RID: 19821 RVA: 0x0012857D File Offset: 0x0012677D
		[DebuggerNonUserCode]
		public LegalDocument(LegalDocument other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.documentId_ = other.documentId_;
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004D6E RID: 19822 RVA: 0x001285BC File Offset: 0x001267BC
		[DebuggerNonUserCode]
		public LegalDocument Clone()
		{
			return new LegalDocument(this);
		}

		// Token: 0x17001894 RID: 6292
		// (get) Token: 0x06004D6F RID: 19823 RVA: 0x001285D4 File Offset: 0x001267D4
		// (set) Token: 0x06004D70 RID: 19824 RVA: 0x001285F5 File Offset: 0x001267F5
		[DebuggerNonUserCode]
		public string DocumentId
		{
			get
			{
				return this.documentId_ ?? LegalDocument.DocumentIdDefaultValue;
			}
			set
			{
				this.documentId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001895 RID: 6293
		// (get) Token: 0x06004D71 RID: 19825 RVA: 0x0012860C File Offset: 0x0012680C
		[DebuggerNonUserCode]
		public bool HasDocumentId
		{
			get
			{
				return this.documentId_ != null;
			}
		}

		// Token: 0x06004D72 RID: 19826 RVA: 0x00128627 File Offset: 0x00126827
		[DebuggerNonUserCode]
		public void ClearDocumentId()
		{
			this.documentId_ = null;
		}

		// Token: 0x17001896 RID: 6294
		// (get) Token: 0x06004D73 RID: 19827 RVA: 0x00128634 File Offset: 0x00126834
		// (set) Token: 0x06004D74 RID: 19828 RVA: 0x00128665 File Offset: 0x00126865
		[DebuggerNonUserCode]
		public uint Version
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint versionDefaultValue;
				if (flag)
				{
					versionDefaultValue = this.version_;
				}
				else
				{
					versionDefaultValue = LegalDocument.VersionDefaultValue;
				}
				return versionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.version_ = value;
			}
		}

		// Token: 0x17001897 RID: 6295
		// (get) Token: 0x06004D75 RID: 19829 RVA: 0x00128680 File Offset: 0x00126880
		[DebuggerNonUserCode]
		public bool HasVersion
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004D76 RID: 19830 RVA: 0x0012869D File Offset: 0x0012689D
		[DebuggerNonUserCode]
		public void ClearVersion()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06004D77 RID: 19831 RVA: 0x001286B0 File Offset: 0x001268B0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LegalDocument);
		}

		// Token: 0x06004D78 RID: 19832 RVA: 0x001286D0 File Offset: 0x001268D0
		[DebuggerNonUserCode]
		public bool Equals(LegalDocument other)
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
					bool flag4 = this.DocumentId != other.DocumentId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Version != other.Version;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004D79 RID: 19833 RVA: 0x00128744 File Offset: 0x00126944
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasDocumentId = this.HasDocumentId;
			if (hasDocumentId)
			{
				num ^= this.DocumentId.GetHashCode();
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num ^= this.Version.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004D7A RID: 19834 RVA: 0x001287B0 File Offset: 0x001269B0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004D7B RID: 19835 RVA: 0x001287C8 File Offset: 0x001269C8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004D7C RID: 19836 RVA: 0x001287D4 File Offset: 0x001269D4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasDocumentId = this.HasDocumentId;
			if (hasDocumentId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.DocumentId);
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Version);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004D7D RID: 19837 RVA: 0x00128844 File Offset: 0x00126A44
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasDocumentId = this.HasDocumentId;
			if (hasDocumentId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.DocumentId);
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Version);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004D7E RID: 19838 RVA: 0x001288B0 File Offset: 0x00126AB0
		[DebuggerNonUserCode]
		public void MergeFrom(LegalDocument other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasDocumentId = other.HasDocumentId;
				if (hasDocumentId)
				{
					this.DocumentId = other.DocumentId;
				}
				bool hasVersion = other.HasVersion;
				if (hasVersion)
				{
					this.Version = other.Version;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004D7F RID: 19839 RVA: 0x00128912 File Offset: 0x00126B12
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004D80 RID: 19840 RVA: 0x00128920 File Offset: 0x00126B20
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 10U)
				{
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Version = input.ReadUInt32();
					}
				}
				else
				{
					this.DocumentId = input.ReadString();
				}
			}
		}

		// Token: 0x04002288 RID: 8840
		private static readonly MessageParser<LegalDocument> _parser = new MessageParser<LegalDocument>(() => new LegalDocument());

		// Token: 0x04002289 RID: 8841
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400228A RID: 8842
		private int _hasBits0;

		// Token: 0x0400228B RID: 8843
		public const int DocumentIdFieldNumber = 1;

		// Token: 0x0400228C RID: 8844
		private static readonly string DocumentIdDefaultValue = "";

		// Token: 0x0400228D RID: 8845
		private string documentId_;

		// Token: 0x0400228E RID: 8846
		public const int VersionFieldNumber = 2;

		// Token: 0x0400228F RID: 8847
		private static readonly uint VersionDefaultValue = 0U;

		// Token: 0x04002290 RID: 8848
		private uint version_;
	}
}
