using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x020002A5 RID: 677
	public sealed class GetLegalDocumentResponse : IMessage<GetLegalDocumentResponse>, IMessage, IEquatable<GetLegalDocumentResponse>, IDeepCloneable<GetLegalDocumentResponse>, IBufferMessage
	{
		// Token: 0x17001695 RID: 5781
		// (get) Token: 0x06004783 RID: 18307 RVA: 0x00110BDC File Offset: 0x0010EDDC
		[DebuggerNonUserCode]
		public static MessageParser<GetLegalDocumentResponse> Parser
		{
			get
			{
				return GetLegalDocumentResponse._parser;
			}
		}

		// Token: 0x17001696 RID: 5782
		// (get) Token: 0x06004784 RID: 18308 RVA: 0x00110BF4 File Offset: 0x0010EDF4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[149];
			}
		}

		// Token: 0x17001697 RID: 5783
		// (get) Token: 0x06004785 RID: 18309 RVA: 0x00110C1C File Offset: 0x0010EE1C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetLegalDocumentResponse.Descriptor;
			}
		}

		// Token: 0x06004786 RID: 18310 RVA: 0x00110C33 File Offset: 0x0010EE33
		[DebuggerNonUserCode]
		public GetLegalDocumentResponse()
		{
		}

		// Token: 0x06004787 RID: 18311 RVA: 0x00110C48 File Offset: 0x0010EE48
		[DebuggerNonUserCode]
		public GetLegalDocumentResponse(GetLegalDocumentResponse other)
			: this()
		{
			this.documentIds_ = other.documentIds_.Clone();
			this.url_ = other.url_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004788 RID: 18312 RVA: 0x00110C80 File Offset: 0x0010EE80
		[DebuggerNonUserCode]
		public GetLegalDocumentResponse Clone()
		{
			return new GetLegalDocumentResponse(this);
		}

		// Token: 0x17001698 RID: 5784
		// (get) Token: 0x06004789 RID: 18313 RVA: 0x00110C98 File Offset: 0x0010EE98
		[DebuggerNonUserCode]
		public RepeatedField<string> DocumentIds
		{
			get
			{
				return this.documentIds_;
			}
		}

		// Token: 0x17001699 RID: 5785
		// (get) Token: 0x0600478A RID: 18314 RVA: 0x00110CB0 File Offset: 0x0010EEB0
		// (set) Token: 0x0600478B RID: 18315 RVA: 0x00110CD1 File Offset: 0x0010EED1
		[DebuggerNonUserCode]
		public string Url
		{
			get
			{
				return this.url_ ?? GetLegalDocumentResponse.UrlDefaultValue;
			}
			set
			{
				this.url_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700169A RID: 5786
		// (get) Token: 0x0600478C RID: 18316 RVA: 0x00110CE8 File Offset: 0x0010EEE8
		[DebuggerNonUserCode]
		public bool HasUrl
		{
			get
			{
				return this.url_ != null;
			}
		}

		// Token: 0x0600478D RID: 18317 RVA: 0x00110D03 File Offset: 0x0010EF03
		[DebuggerNonUserCode]
		public void ClearUrl()
		{
			this.url_ = null;
		}

		// Token: 0x0600478E RID: 18318 RVA: 0x00110D10 File Offset: 0x0010EF10
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetLegalDocumentResponse);
		}

		// Token: 0x0600478F RID: 18319 RVA: 0x00110D30 File Offset: 0x0010EF30
		[DebuggerNonUserCode]
		public bool Equals(GetLegalDocumentResponse other)
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
					bool flag4 = !this.documentIds_.Equals(other.documentIds_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Url != other.Url;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004790 RID: 18320 RVA: 0x00110DA4 File Offset: 0x0010EFA4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.documentIds_.GetHashCode();
			bool hasUrl = this.HasUrl;
			if (hasUrl)
			{
				num ^= this.Url.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004791 RID: 18321 RVA: 0x00110DFC File Offset: 0x0010EFFC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004792 RID: 18322 RVA: 0x00110E14 File Offset: 0x0010F014
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004793 RID: 18323 RVA: 0x00110E20 File Offset: 0x0010F020
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.documentIds_.WriteTo(ref output, GetLegalDocumentResponse._repeated_documentIds_codec);
			bool hasUrl = this.HasUrl;
			if (hasUrl)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Url);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004794 RID: 18324 RVA: 0x00110E80 File Offset: 0x0010F080
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.documentIds_.CalculateSize(GetLegalDocumentResponse._repeated_documentIds_codec);
			bool hasUrl = this.HasUrl;
			if (hasUrl)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Url);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004795 RID: 18325 RVA: 0x00110EE4 File Offset: 0x0010F0E4
		[DebuggerNonUserCode]
		public void MergeFrom(GetLegalDocumentResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.documentIds_.Add(other.documentIds_);
				bool hasUrl = other.HasUrl;
				if (hasUrl)
				{
					this.Url = other.Url;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004796 RID: 18326 RVA: 0x00110F3F File Offset: 0x0010F13F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004797 RID: 18327 RVA: 0x00110F4C File Offset: 0x0010F14C
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
						this.Url = input.ReadString();
					}
				}
				else
				{
					this.documentIds_.AddEntriesFrom(ref input, GetLegalDocumentResponse._repeated_documentIds_codec);
				}
			}
		}

		// Token: 0x04001FA9 RID: 8105
		private static readonly MessageParser<GetLegalDocumentResponse> _parser = new MessageParser<GetLegalDocumentResponse>(() => new GetLegalDocumentResponse());

		// Token: 0x04001FAA RID: 8106
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FAB RID: 8107
		public const int DocumentIdsFieldNumber = 1;

		// Token: 0x04001FAC RID: 8108
		private static readonly FieldCodec<string> _repeated_documentIds_codec = FieldCodec.ForString(10U);

		// Token: 0x04001FAD RID: 8109
		private readonly RepeatedField<string> documentIds_ = new RepeatedField<string>();

		// Token: 0x04001FAE RID: 8110
		public const int UrlFieldNumber = 2;

		// Token: 0x04001FAF RID: 8111
		private static readonly string UrlDefaultValue = "";

		// Token: 0x04001FB0 RID: 8112
		private string url_;
	}
}
