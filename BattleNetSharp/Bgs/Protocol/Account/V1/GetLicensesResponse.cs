using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x0200071D RID: 1821
	public sealed class GetLicensesResponse : IMessage<GetLicensesResponse>, IMessage, IEquatable<GetLicensesResponse>, IDeepCloneable<GetLicensesResponse>, IBufferMessage
	{
		// Token: 0x17003385 RID: 13189
		// (get) Token: 0x0600A6EB RID: 42731 RVA: 0x00289F7C File Offset: 0x0028817C
		[DebuggerNonUserCode]
		public static MessageParser<GetLicensesResponse> Parser
		{
			get
			{
				return GetLicensesResponse._parser;
			}
		}

		// Token: 0x17003386 RID: 13190
		// (get) Token: 0x0600A6EC RID: 42732 RVA: 0x00289F94 File Offset: 0x00288194
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[13];
			}
		}

		// Token: 0x17003387 RID: 13191
		// (get) Token: 0x0600A6ED RID: 42733 RVA: 0x00289FB8 File Offset: 0x002881B8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetLicensesResponse.Descriptor;
			}
		}

		// Token: 0x0600A6EE RID: 42734 RVA: 0x00289FCF File Offset: 0x002881CF
		[DebuggerNonUserCode]
		public GetLicensesResponse()
		{
		}

		// Token: 0x0600A6EF RID: 42735 RVA: 0x00289FE4 File Offset: 0x002881E4
		[DebuggerNonUserCode]
		public GetLicensesResponse(GetLicensesResponse other)
			: this()
		{
			this.licenses_ = other.licenses_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A6F0 RID: 42736 RVA: 0x0028A010 File Offset: 0x00288210
		[DebuggerNonUserCode]
		public GetLicensesResponse Clone()
		{
			return new GetLicensesResponse(this);
		}

		// Token: 0x17003388 RID: 13192
		// (get) Token: 0x0600A6F1 RID: 42737 RVA: 0x0028A028 File Offset: 0x00288228
		[DebuggerNonUserCode]
		public RepeatedField<AccountLicense> Licenses
		{
			get
			{
				return this.licenses_;
			}
		}

		// Token: 0x0600A6F2 RID: 42738 RVA: 0x0028A040 File Offset: 0x00288240
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetLicensesResponse);
		}

		// Token: 0x0600A6F3 RID: 42739 RVA: 0x0028A060 File Offset: 0x00288260
		[DebuggerNonUserCode]
		public bool Equals(GetLicensesResponse other)
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
					bool flag4 = !this.licenses_.Equals(other.licenses_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600A6F4 RID: 42740 RVA: 0x0028A0BC File Offset: 0x002882BC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.licenses_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A6F5 RID: 42741 RVA: 0x0028A0FC File Offset: 0x002882FC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A6F6 RID: 42742 RVA: 0x0028A114 File Offset: 0x00288314
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A6F7 RID: 42743 RVA: 0x0028A120 File Offset: 0x00288320
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.licenses_.WriteTo(ref output, GetLicensesResponse._repeated_licenses_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A6F8 RID: 42744 RVA: 0x0028A15C File Offset: 0x0028835C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.licenses_.CalculateSize(GetLicensesResponse._repeated_licenses_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A6F9 RID: 42745 RVA: 0x0028A1A4 File Offset: 0x002883A4
		[DebuggerNonUserCode]
		public void MergeFrom(GetLicensesResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.licenses_.Add(other.licenses_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A6FA RID: 42746 RVA: 0x0028A1E6 File Offset: 0x002883E6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A6FB RID: 42747 RVA: 0x0028A1F4 File Offset: 0x002883F4
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
					this.licenses_.AddEntriesFrom(ref input, GetLicensesResponse._repeated_licenses_codec);
				}
			}
		}

		// Token: 0x04004AF4 RID: 19188
		private static readonly MessageParser<GetLicensesResponse> _parser = new MessageParser<GetLicensesResponse>(() => new GetLicensesResponse());

		// Token: 0x04004AF5 RID: 19189
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AF6 RID: 19190
		public const int LicensesFieldNumber = 1;

		// Token: 0x04004AF7 RID: 19191
		private static readonly FieldCodec<AccountLicense> _repeated_licenses_codec = FieldCodec.ForMessage<AccountLicense>(10U, AccountLicense.Parser);

		// Token: 0x04004AF8 RID: 19192
		private readonly RepeatedField<AccountLicense> licenses_ = new RepeatedField<AccountLicense>();
	}
}
