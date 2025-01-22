using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000723 RID: 1827
	public sealed class GetCAISInfoResponse : IMessage<GetCAISInfoResponse>, IMessage, IEquatable<GetCAISInfoResponse>, IDeepCloneable<GetCAISInfoResponse>, IBufferMessage
	{
		// Token: 0x170033A0 RID: 13216
		// (get) Token: 0x0600A762 RID: 42850 RVA: 0x0028B5E0 File Offset: 0x002897E0
		[DebuggerNonUserCode]
		public static MessageParser<GetCAISInfoResponse> Parser
		{
			get
			{
				return GetCAISInfoResponse._parser;
			}
		}

		// Token: 0x170033A1 RID: 13217
		// (get) Token: 0x0600A763 RID: 42851 RVA: 0x0028B5F8 File Offset: 0x002897F8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[19];
			}
		}

		// Token: 0x170033A2 RID: 13218
		// (get) Token: 0x0600A764 RID: 42852 RVA: 0x0028B61C File Offset: 0x0028981C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetCAISInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600A765 RID: 42853 RVA: 0x0028B633 File Offset: 0x00289833
		[DebuggerNonUserCode]
		public GetCAISInfoResponse()
		{
		}

		// Token: 0x0600A766 RID: 42854 RVA: 0x0028B63D File Offset: 0x0028983D
		[DebuggerNonUserCode]
		public GetCAISInfoResponse(GetCAISInfoResponse other)
			: this()
		{
			this.caisInfo_ = ((other.caisInfo_ != null) ? other.caisInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A767 RID: 42855 RVA: 0x0028B674 File Offset: 0x00289874
		[DebuggerNonUserCode]
		public GetCAISInfoResponse Clone()
		{
			return new GetCAISInfoResponse(this);
		}

		// Token: 0x170033A3 RID: 13219
		// (get) Token: 0x0600A768 RID: 42856 RVA: 0x0028B68C File Offset: 0x0028988C
		// (set) Token: 0x0600A769 RID: 42857 RVA: 0x0028B6A4 File Offset: 0x002898A4
		[DebuggerNonUserCode]
		public CAIS CaisInfo
		{
			get
			{
				return this.caisInfo_;
			}
			set
			{
				this.caisInfo_ = value;
			}
		}

		// Token: 0x0600A76A RID: 42858 RVA: 0x0028B6B0 File Offset: 0x002898B0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetCAISInfoResponse);
		}

		// Token: 0x0600A76B RID: 42859 RVA: 0x0028B6D0 File Offset: 0x002898D0
		[DebuggerNonUserCode]
		public bool Equals(GetCAISInfoResponse other)
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
					bool flag4 = !object.Equals(this.CaisInfo, other.CaisInfo);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600A76C RID: 42860 RVA: 0x0028B72C File Offset: 0x0028992C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.caisInfo_ != null;
			if (flag)
			{
				num ^= this.CaisInfo.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A76D RID: 42861 RVA: 0x0028B77C File Offset: 0x0028997C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A76E RID: 42862 RVA: 0x0028B794 File Offset: 0x00289994
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A76F RID: 42863 RVA: 0x0028B7A0 File Offset: 0x002899A0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.caisInfo_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.CaisInfo);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A770 RID: 42864 RVA: 0x0028B7F0 File Offset: 0x002899F0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.caisInfo_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CaisInfo);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A771 RID: 42865 RVA: 0x0028B844 File Offset: 0x00289A44
		[DebuggerNonUserCode]
		public void MergeFrom(GetCAISInfoResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.caisInfo_ != null;
				if (flag2)
				{
					bool flag3 = this.caisInfo_ == null;
					if (flag3)
					{
						this.CaisInfo = new CAIS();
					}
					this.CaisInfo.MergeFrom(other.CaisInfo);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A772 RID: 42866 RVA: 0x0028B8B0 File Offset: 0x00289AB0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A773 RID: 42867 RVA: 0x0028B8BC File Offset: 0x00289ABC
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
					bool flag = this.caisInfo_ == null;
					if (flag)
					{
						this.CaisInfo = new CAIS();
					}
					input.ReadMessage(this.CaisInfo);
				}
			}
		}

		// Token: 0x04004B12 RID: 19218
		private static readonly MessageParser<GetCAISInfoResponse> _parser = new MessageParser<GetCAISInfoResponse>(() => new GetCAISInfoResponse());

		// Token: 0x04004B13 RID: 19219
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B14 RID: 19220
		public const int CaisInfoFieldNumber = 1;

		// Token: 0x04004B15 RID: 19221
		private CAIS caisInfo_;
	}
}
