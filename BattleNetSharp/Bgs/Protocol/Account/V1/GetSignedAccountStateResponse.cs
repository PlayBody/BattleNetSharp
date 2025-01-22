using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000719 RID: 1817
	public sealed class GetSignedAccountStateResponse : IMessage<GetSignedAccountStateResponse>, IMessage, IEquatable<GetSignedAccountStateResponse>, IDeepCloneable<GetSignedAccountStateResponse>, IBufferMessage
	{
		// Token: 0x17003366 RID: 13158
		// (get) Token: 0x0600A681 RID: 42625 RVA: 0x002886DC File Offset: 0x002868DC
		[DebuggerNonUserCode]
		public static MessageParser<GetSignedAccountStateResponse> Parser
		{
			get
			{
				return GetSignedAccountStateResponse._parser;
			}
		}

		// Token: 0x17003367 RID: 13159
		// (get) Token: 0x0600A682 RID: 42626 RVA: 0x002886F4 File Offset: 0x002868F4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x17003368 RID: 13160
		// (get) Token: 0x0600A683 RID: 42627 RVA: 0x00288718 File Offset: 0x00286918
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSignedAccountStateResponse.Descriptor;
			}
		}

		// Token: 0x0600A684 RID: 42628 RVA: 0x0028872F File Offset: 0x0028692F
		[DebuggerNonUserCode]
		public GetSignedAccountStateResponse()
		{
		}

		// Token: 0x0600A685 RID: 42629 RVA: 0x00288739 File Offset: 0x00286939
		[DebuggerNonUserCode]
		public GetSignedAccountStateResponse(GetSignedAccountStateResponse other)
			: this()
		{
			this.token_ = other.token_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A686 RID: 42630 RVA: 0x00288760 File Offset: 0x00286960
		[DebuggerNonUserCode]
		public GetSignedAccountStateResponse Clone()
		{
			return new GetSignedAccountStateResponse(this);
		}

		// Token: 0x17003369 RID: 13161
		// (get) Token: 0x0600A687 RID: 42631 RVA: 0x00288778 File Offset: 0x00286978
		// (set) Token: 0x0600A688 RID: 42632 RVA: 0x00288799 File Offset: 0x00286999
		[DebuggerNonUserCode]
		public string Token
		{
			get
			{
				return this.token_ ?? GetSignedAccountStateResponse.TokenDefaultValue;
			}
			set
			{
				this.token_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700336A RID: 13162
		// (get) Token: 0x0600A689 RID: 42633 RVA: 0x002887B0 File Offset: 0x002869B0
		[DebuggerNonUserCode]
		public bool HasToken
		{
			get
			{
				return this.token_ != null;
			}
		}

		// Token: 0x0600A68A RID: 42634 RVA: 0x002887CB File Offset: 0x002869CB
		[DebuggerNonUserCode]
		public void ClearToken()
		{
			this.token_ = null;
		}

		// Token: 0x0600A68B RID: 42635 RVA: 0x002887D8 File Offset: 0x002869D8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSignedAccountStateResponse);
		}

		// Token: 0x0600A68C RID: 42636 RVA: 0x002887F8 File Offset: 0x002869F8
		[DebuggerNonUserCode]
		public bool Equals(GetSignedAccountStateResponse other)
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
					bool flag4 = this.Token != other.Token;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600A68D RID: 42637 RVA: 0x00288850 File Offset: 0x00286A50
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				num ^= this.Token.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A68E RID: 42638 RVA: 0x0028889C File Offset: 0x00286A9C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A68F RID: 42639 RVA: 0x002888B4 File Offset: 0x00286AB4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A690 RID: 42640 RVA: 0x002888C0 File Offset: 0x00286AC0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Token);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A691 RID: 42641 RVA: 0x0028890C File Offset: 0x00286B0C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Token);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A692 RID: 42642 RVA: 0x0028895C File Offset: 0x00286B5C
		[DebuggerNonUserCode]
		public void MergeFrom(GetSignedAccountStateResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasToken = other.HasToken;
				if (hasToken)
				{
					this.Token = other.Token;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A693 RID: 42643 RVA: 0x002889A5 File Offset: 0x00286BA5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A694 RID: 42644 RVA: 0x002889B0 File Offset: 0x00286BB0
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
					this.Token = input.ReadString();
				}
			}
		}

		// Token: 0x04004ACB RID: 19147
		private static readonly MessageParser<GetSignedAccountStateResponse> _parser = new MessageParser<GetSignedAccountStateResponse>(() => new GetSignedAccountStateResponse());

		// Token: 0x04004ACC RID: 19148
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004ACD RID: 19149
		public const int TokenFieldNumber = 1;

		// Token: 0x04004ACE RID: 19150
		private static readonly string TokenDefaultValue = "";

		// Token: 0x04004ACF RID: 19151
		private string token_;
	}
}
