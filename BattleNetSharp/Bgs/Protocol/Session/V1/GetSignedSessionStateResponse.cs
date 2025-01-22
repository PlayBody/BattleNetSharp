using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x0200053C RID: 1340
	public sealed class GetSignedSessionStateResponse : IMessage<GetSignedSessionStateResponse>, IMessage, IEquatable<GetSignedSessionStateResponse>, IDeepCloneable<GetSignedSessionStateResponse>, IBufferMessage
	{
		// Token: 0x170028FC RID: 10492
		// (get) Token: 0x060081AB RID: 33195 RVA: 0x001F88CC File Offset: 0x001F6ACC
		[DebuggerNonUserCode]
		public static MessageParser<GetSignedSessionStateResponse> Parser
		{
			get
			{
				return GetSignedSessionStateResponse._parser;
			}
		}

		// Token: 0x170028FD RID: 10493
		// (get) Token: 0x060081AC RID: 33196 RVA: 0x001F88E4 File Offset: 0x001F6AE4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[13];
			}
		}

		// Token: 0x170028FE RID: 10494
		// (get) Token: 0x060081AD RID: 33197 RVA: 0x001F8908 File Offset: 0x001F6B08
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSignedSessionStateResponse.Descriptor;
			}
		}

		// Token: 0x060081AE RID: 33198 RVA: 0x001F891F File Offset: 0x001F6B1F
		[DebuggerNonUserCode]
		public GetSignedSessionStateResponse()
		{
		}

		// Token: 0x060081AF RID: 33199 RVA: 0x001F8929 File Offset: 0x001F6B29
		[DebuggerNonUserCode]
		public GetSignedSessionStateResponse(GetSignedSessionStateResponse other)
			: this()
		{
			this.token_ = other.token_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060081B0 RID: 33200 RVA: 0x001F8950 File Offset: 0x001F6B50
		[DebuggerNonUserCode]
		public GetSignedSessionStateResponse Clone()
		{
			return new GetSignedSessionStateResponse(this);
		}

		// Token: 0x170028FF RID: 10495
		// (get) Token: 0x060081B1 RID: 33201 RVA: 0x001F8968 File Offset: 0x001F6B68
		// (set) Token: 0x060081B2 RID: 33202 RVA: 0x001F8989 File Offset: 0x001F6B89
		[DebuggerNonUserCode]
		public string Token
		{
			get
			{
				return this.token_ ?? GetSignedSessionStateResponse.TokenDefaultValue;
			}
			set
			{
				this.token_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002900 RID: 10496
		// (get) Token: 0x060081B3 RID: 33203 RVA: 0x001F89A0 File Offset: 0x001F6BA0
		[DebuggerNonUserCode]
		public bool HasToken
		{
			get
			{
				return this.token_ != null;
			}
		}

		// Token: 0x060081B4 RID: 33204 RVA: 0x001F89BB File Offset: 0x001F6BBB
		[DebuggerNonUserCode]
		public void ClearToken()
		{
			this.token_ = null;
		}

		// Token: 0x060081B5 RID: 33205 RVA: 0x001F89C8 File Offset: 0x001F6BC8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSignedSessionStateResponse);
		}

		// Token: 0x060081B6 RID: 33206 RVA: 0x001F89E8 File Offset: 0x001F6BE8
		[DebuggerNonUserCode]
		public bool Equals(GetSignedSessionStateResponse other)
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

		// Token: 0x060081B7 RID: 33207 RVA: 0x001F8A40 File Offset: 0x001F6C40
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

		// Token: 0x060081B8 RID: 33208 RVA: 0x001F8A8C File Offset: 0x001F6C8C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060081B9 RID: 33209 RVA: 0x001F8AA4 File Offset: 0x001F6CA4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060081BA RID: 33210 RVA: 0x001F8AB0 File Offset: 0x001F6CB0
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

		// Token: 0x060081BB RID: 33211 RVA: 0x001F8AFC File Offset: 0x001F6CFC
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

		// Token: 0x060081BC RID: 33212 RVA: 0x001F8B4C File Offset: 0x001F6D4C
		[DebuggerNonUserCode]
		public void MergeFrom(GetSignedSessionStateResponse other)
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

		// Token: 0x060081BD RID: 33213 RVA: 0x001F8B95 File Offset: 0x001F6D95
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060081BE RID: 33214 RVA: 0x001F8BA0 File Offset: 0x001F6DA0
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

		// Token: 0x04003AC0 RID: 15040
		private static readonly MessageParser<GetSignedSessionStateResponse> _parser = new MessageParser<GetSignedSessionStateResponse>(() => new GetSignedSessionStateResponse());

		// Token: 0x04003AC1 RID: 15041
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AC2 RID: 15042
		public const int TokenFieldNumber = 1;

		// Token: 0x04003AC3 RID: 15043
		private static readonly string TokenDefaultValue = "";

		// Token: 0x04003AC4 RID: 15044
		private string token_;
	}
}
