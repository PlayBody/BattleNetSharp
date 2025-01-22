using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x020002A4 RID: 676
	public sealed class AcknowledgeLegalDocumentRequest : IMessage<AcknowledgeLegalDocumentRequest>, IMessage, IEquatable<AcknowledgeLegalDocumentRequest>, IDeepCloneable<AcknowledgeLegalDocumentRequest>, IBufferMessage
	{
		// Token: 0x1700168E RID: 5774
		// (get) Token: 0x0600476A RID: 18282 RVA: 0x00110770 File Offset: 0x0010E970
		[DebuggerNonUserCode]
		public static MessageParser<AcknowledgeLegalDocumentRequest> Parser
		{
			get
			{
				return AcknowledgeLegalDocumentRequest._parser;
			}
		}

		// Token: 0x1700168F RID: 5775
		// (get) Token: 0x0600476B RID: 18283 RVA: 0x00110788 File Offset: 0x0010E988
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[148];
			}
		}

		// Token: 0x17001690 RID: 5776
		// (get) Token: 0x0600476C RID: 18284 RVA: 0x001107B0 File Offset: 0x0010E9B0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AcknowledgeLegalDocumentRequest.Descriptor;
			}
		}

		// Token: 0x0600476D RID: 18285 RVA: 0x001107C7 File Offset: 0x0010E9C7
		[DebuggerNonUserCode]
		public AcknowledgeLegalDocumentRequest()
		{
		}

		// Token: 0x0600476E RID: 18286 RVA: 0x001107D1 File Offset: 0x0010E9D1
		[DebuggerNonUserCode]
		public AcknowledgeLegalDocumentRequest(AcknowledgeLegalDocumentRequest other)
			: this()
		{
			this.documentId_ = other.documentId_;
			this.sessionKey_ = other.sessionKey_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600476F RID: 18287 RVA: 0x00110804 File Offset: 0x0010EA04
		[DebuggerNonUserCode]
		public AcknowledgeLegalDocumentRequest Clone()
		{
			return new AcknowledgeLegalDocumentRequest(this);
		}

		// Token: 0x17001691 RID: 5777
		// (get) Token: 0x06004770 RID: 18288 RVA: 0x0011081C File Offset: 0x0010EA1C
		// (set) Token: 0x06004771 RID: 18289 RVA: 0x0011083D File Offset: 0x0010EA3D
		[DebuggerNonUserCode]
		public string DocumentId
		{
			get
			{
				return this.documentId_ ?? AcknowledgeLegalDocumentRequest.DocumentIdDefaultValue;
			}
			set
			{
				this.documentId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001692 RID: 5778
		// (get) Token: 0x06004772 RID: 18290 RVA: 0x00110854 File Offset: 0x0010EA54
		[DebuggerNonUserCode]
		public bool HasDocumentId
		{
			get
			{
				return this.documentId_ != null;
			}
		}

		// Token: 0x06004773 RID: 18291 RVA: 0x0011086F File Offset: 0x0010EA6F
		[DebuggerNonUserCode]
		public void ClearDocumentId()
		{
			this.documentId_ = null;
		}

		// Token: 0x17001693 RID: 5779
		// (get) Token: 0x06004774 RID: 18292 RVA: 0x0011087C File Offset: 0x0010EA7C
		// (set) Token: 0x06004775 RID: 18293 RVA: 0x0011089D File Offset: 0x0010EA9D
		[DebuggerNonUserCode]
		public ByteString SessionKey
		{
			get
			{
				return this.sessionKey_ ?? AcknowledgeLegalDocumentRequest.SessionKeyDefaultValue;
			}
			set
			{
				this.sessionKey_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17001694 RID: 5780
		// (get) Token: 0x06004776 RID: 18294 RVA: 0x001108B4 File Offset: 0x0010EAB4
		[DebuggerNonUserCode]
		public bool HasSessionKey
		{
			get
			{
				return this.sessionKey_ != null;
			}
		}

		// Token: 0x06004777 RID: 18295 RVA: 0x001108D2 File Offset: 0x0010EAD2
		[DebuggerNonUserCode]
		public void ClearSessionKey()
		{
			this.sessionKey_ = null;
		}

		// Token: 0x06004778 RID: 18296 RVA: 0x001108DC File Offset: 0x0010EADC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AcknowledgeLegalDocumentRequest);
		}

		// Token: 0x06004779 RID: 18297 RVA: 0x001108FC File Offset: 0x0010EAFC
		[DebuggerNonUserCode]
		public bool Equals(AcknowledgeLegalDocumentRequest other)
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
						bool flag5 = this.SessionKey != other.SessionKey;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600477A RID: 18298 RVA: 0x00110970 File Offset: 0x0010EB70
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasDocumentId = this.HasDocumentId;
			if (hasDocumentId)
			{
				num ^= this.DocumentId.GetHashCode();
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				num ^= this.SessionKey.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600477B RID: 18299 RVA: 0x001109D4 File Offset: 0x0010EBD4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600477C RID: 18300 RVA: 0x001109EC File Offset: 0x0010EBEC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600477D RID: 18301 RVA: 0x001109F8 File Offset: 0x0010EBF8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasDocumentId = this.HasDocumentId;
			if (hasDocumentId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.DocumentId);
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.SessionKey);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600477E RID: 18302 RVA: 0x00110A68 File Offset: 0x0010EC68
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasDocumentId = this.HasDocumentId;
			if (hasDocumentId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.DocumentId);
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.SessionKey);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600477F RID: 18303 RVA: 0x00110AD4 File Offset: 0x0010ECD4
		[DebuggerNonUserCode]
		public void MergeFrom(AcknowledgeLegalDocumentRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasDocumentId = other.HasDocumentId;
				if (hasDocumentId)
				{
					this.DocumentId = other.DocumentId;
				}
				bool hasSessionKey = other.HasSessionKey;
				if (hasSessionKey)
				{
					this.SessionKey = other.SessionKey;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004780 RID: 18304 RVA: 0x00110B36 File Offset: 0x0010ED36
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004781 RID: 18305 RVA: 0x00110B44 File Offset: 0x0010ED44
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SessionKey = input.ReadBytes();
					}
				}
				else
				{
					this.DocumentId = input.ReadString();
				}
			}
		}

		// Token: 0x04001FA1 RID: 8097
		private static readonly MessageParser<AcknowledgeLegalDocumentRequest> _parser = new MessageParser<AcknowledgeLegalDocumentRequest>(() => new AcknowledgeLegalDocumentRequest());

		// Token: 0x04001FA2 RID: 8098
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FA3 RID: 8099
		public const int DocumentIdFieldNumber = 1;

		// Token: 0x04001FA4 RID: 8100
		private static readonly string DocumentIdDefaultValue = "";

		// Token: 0x04001FA5 RID: 8101
		private string documentId_;

		// Token: 0x04001FA6 RID: 8102
		public const int SessionKeyFieldNumber = 2;

		// Token: 0x04001FA7 RID: 8103
		private static readonly ByteString SessionKeyDefaultValue = ByteString.Empty;

		// Token: 0x04001FA8 RID: 8104
		private ByteString sessionKey_;
	}
}
