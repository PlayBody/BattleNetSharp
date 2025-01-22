using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000725 RID: 1829
	public sealed class GetAuthorizedDataResponse : IMessage<GetAuthorizedDataResponse>, IMessage, IEquatable<GetAuthorizedDataResponse>, IDeepCloneable<GetAuthorizedDataResponse>, IBufferMessage
	{
		// Token: 0x170033AB RID: 13227
		// (get) Token: 0x0600A78D RID: 42893 RVA: 0x0028BEB4 File Offset: 0x0028A0B4
		[DebuggerNonUserCode]
		public static MessageParser<GetAuthorizedDataResponse> Parser
		{
			get
			{
				return GetAuthorizedDataResponse._parser;
			}
		}

		// Token: 0x170033AC RID: 13228
		// (get) Token: 0x0600A78E RID: 42894 RVA: 0x0028BECC File Offset: 0x0028A0CC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[21];
			}
		}

		// Token: 0x170033AD RID: 13229
		// (get) Token: 0x0600A78F RID: 42895 RVA: 0x0028BEF0 File Offset: 0x0028A0F0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAuthorizedDataResponse.Descriptor;
			}
		}

		// Token: 0x0600A790 RID: 42896 RVA: 0x0028BF07 File Offset: 0x0028A107
		[DebuggerNonUserCode]
		public GetAuthorizedDataResponse()
		{
		}

		// Token: 0x0600A791 RID: 42897 RVA: 0x0028BF1C File Offset: 0x0028A11C
		[DebuggerNonUserCode]
		public GetAuthorizedDataResponse(GetAuthorizedDataResponse other)
			: this()
		{
			this.data_ = other.data_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A792 RID: 42898 RVA: 0x0028BF48 File Offset: 0x0028A148
		[DebuggerNonUserCode]
		public GetAuthorizedDataResponse Clone()
		{
			return new GetAuthorizedDataResponse(this);
		}

		// Token: 0x170033AE RID: 13230
		// (get) Token: 0x0600A793 RID: 42899 RVA: 0x0028BF60 File Offset: 0x0028A160
		[DebuggerNonUserCode]
		public RepeatedField<AuthorizedData> Data
		{
			get
			{
				return this.data_;
			}
		}

		// Token: 0x0600A794 RID: 42900 RVA: 0x0028BF78 File Offset: 0x0028A178
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAuthorizedDataResponse);
		}

		// Token: 0x0600A795 RID: 42901 RVA: 0x0028BF98 File Offset: 0x0028A198
		[DebuggerNonUserCode]
		public bool Equals(GetAuthorizedDataResponse other)
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
					bool flag4 = !this.data_.Equals(other.data_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600A796 RID: 42902 RVA: 0x0028BFF4 File Offset: 0x0028A1F4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.data_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A797 RID: 42903 RVA: 0x0028C034 File Offset: 0x0028A234
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A798 RID: 42904 RVA: 0x0028C04C File Offset: 0x0028A24C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A799 RID: 42905 RVA: 0x0028C058 File Offset: 0x0028A258
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.data_.WriteTo(ref output, GetAuthorizedDataResponse._repeated_data_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A79A RID: 42906 RVA: 0x0028C094 File Offset: 0x0028A294
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.data_.CalculateSize(GetAuthorizedDataResponse._repeated_data_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A79B RID: 42907 RVA: 0x0028C0DC File Offset: 0x0028A2DC
		[DebuggerNonUserCode]
		public void MergeFrom(GetAuthorizedDataResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.data_.Add(other.data_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A79C RID: 42908 RVA: 0x0028C11E File Offset: 0x0028A31E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A79D RID: 42909 RVA: 0x0028C12C File Offset: 0x0028A32C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.data_.AddEntriesFrom(ref input, GetAuthorizedDataResponse._repeated_data_codec);
				}
			}
		}

		// Token: 0x04004B21 RID: 19233
		private static readonly MessageParser<GetAuthorizedDataResponse> _parser = new MessageParser<GetAuthorizedDataResponse>(() => new GetAuthorizedDataResponse());

		// Token: 0x04004B22 RID: 19234
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B23 RID: 19235
		public const int DataFieldNumber = 1;

		// Token: 0x04004B24 RID: 19236
		private static readonly FieldCodec<AuthorizedData> _repeated_data_codec = FieldCodec.ForMessage<AuthorizedData>(10U, AuthorizedData.Parser);

		// Token: 0x04004B25 RID: 19237
		private readonly RepeatedField<AuthorizedData> data_ = new RepeatedField<AuthorizedData>();
	}
}
