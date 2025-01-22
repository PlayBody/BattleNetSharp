using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Challenge.V1
{
	// Token: 0x02000525 RID: 1317
	public sealed class ChallengeExternalRequest : IMessage<ChallengeExternalRequest>, IMessage, IEquatable<ChallengeExternalRequest>, IDeepCloneable<ChallengeExternalRequest>, IBufferMessage
	{
		// Token: 0x17002878 RID: 10360
		// (get) Token: 0x06007FCD RID: 32717 RVA: 0x001F1C08 File Offset: 0x001EFE08
		[DebuggerNonUserCode]
		public static MessageParser<ChallengeExternalRequest> Parser
		{
			get
			{
				return ChallengeExternalRequest._parser;
			}
		}

		// Token: 0x17002879 RID: 10361
		// (get) Token: 0x06007FCE RID: 32718 RVA: 0x001F1C20 File Offset: 0x001EFE20
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700287A RID: 10362
		// (get) Token: 0x06007FCF RID: 32719 RVA: 0x001F1C44 File Offset: 0x001EFE44
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeExternalRequest.Descriptor;
			}
		}

		// Token: 0x06007FD0 RID: 32720 RVA: 0x001F1C5B File Offset: 0x001EFE5B
		[DebuggerNonUserCode]
		public ChallengeExternalRequest()
		{
		}

		// Token: 0x06007FD1 RID: 32721 RVA: 0x001F1C65 File Offset: 0x001EFE65
		[DebuggerNonUserCode]
		public ChallengeExternalRequest(ChallengeExternalRequest other)
			: this()
		{
			this.requestToken_ = other.requestToken_;
			this.payloadType_ = other.payloadType_;
			this.payload_ = other.payload_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007FD2 RID: 32722 RVA: 0x001F1CA4 File Offset: 0x001EFEA4
		[DebuggerNonUserCode]
		public ChallengeExternalRequest Clone()
		{
			return new ChallengeExternalRequest(this);
		}

		// Token: 0x1700287B RID: 10363
		// (get) Token: 0x06007FD3 RID: 32723 RVA: 0x001F1CBC File Offset: 0x001EFEBC
		// (set) Token: 0x06007FD4 RID: 32724 RVA: 0x001F1CDD File Offset: 0x001EFEDD
		[DebuggerNonUserCode]
		public string RequestToken
		{
			get
			{
				return this.requestToken_ ?? ChallengeExternalRequest.RequestTokenDefaultValue;
			}
			set
			{
				this.requestToken_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700287C RID: 10364
		// (get) Token: 0x06007FD5 RID: 32725 RVA: 0x001F1CF4 File Offset: 0x001EFEF4
		[DebuggerNonUserCode]
		public bool HasRequestToken
		{
			get
			{
				return this.requestToken_ != null;
			}
		}

		// Token: 0x06007FD6 RID: 32726 RVA: 0x001F1D0F File Offset: 0x001EFF0F
		[DebuggerNonUserCode]
		public void ClearRequestToken()
		{
			this.requestToken_ = null;
		}

		// Token: 0x1700287D RID: 10365
		// (get) Token: 0x06007FD7 RID: 32727 RVA: 0x001F1D1C File Offset: 0x001EFF1C
		// (set) Token: 0x06007FD8 RID: 32728 RVA: 0x001F1D3D File Offset: 0x001EFF3D
		[DebuggerNonUserCode]
		public string PayloadType
		{
			get
			{
				return this.payloadType_ ?? ChallengeExternalRequest.PayloadTypeDefaultValue;
			}
			set
			{
				this.payloadType_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700287E RID: 10366
		// (get) Token: 0x06007FD9 RID: 32729 RVA: 0x001F1D54 File Offset: 0x001EFF54
		[DebuggerNonUserCode]
		public bool HasPayloadType
		{
			get
			{
				return this.payloadType_ != null;
			}
		}

		// Token: 0x06007FDA RID: 32730 RVA: 0x001F1D6F File Offset: 0x001EFF6F
		[DebuggerNonUserCode]
		public void ClearPayloadType()
		{
			this.payloadType_ = null;
		}

		// Token: 0x1700287F RID: 10367
		// (get) Token: 0x06007FDB RID: 32731 RVA: 0x001F1D7C File Offset: 0x001EFF7C
		// (set) Token: 0x06007FDC RID: 32732 RVA: 0x001F1D9D File Offset: 0x001EFF9D
		[DebuggerNonUserCode]
		public ByteString Payload
		{
			get
			{
				return this.payload_ ?? ChallengeExternalRequest.PayloadDefaultValue;
			}
			set
			{
				this.payload_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17002880 RID: 10368
		// (get) Token: 0x06007FDD RID: 32733 RVA: 0x001F1DB4 File Offset: 0x001EFFB4
		[DebuggerNonUserCode]
		public bool HasPayload
		{
			get
			{
				return this.payload_ != null;
			}
		}

		// Token: 0x06007FDE RID: 32734 RVA: 0x001F1DD2 File Offset: 0x001EFFD2
		[DebuggerNonUserCode]
		public void ClearPayload()
		{
			this.payload_ = null;
		}

		// Token: 0x06007FDF RID: 32735 RVA: 0x001F1DDC File Offset: 0x001EFFDC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeExternalRequest);
		}

		// Token: 0x06007FE0 RID: 32736 RVA: 0x001F1DFC File Offset: 0x001EFFFC
		[DebuggerNonUserCode]
		public bool Equals(ChallengeExternalRequest other)
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
					bool flag4 = this.RequestToken != other.RequestToken;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.PayloadType != other.PayloadType;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Payload != other.Payload;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007FE1 RID: 32737 RVA: 0x001F1E88 File Offset: 0x001F0088
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasRequestToken = this.HasRequestToken;
			if (hasRequestToken)
			{
				num ^= this.RequestToken.GetHashCode();
			}
			bool hasPayloadType = this.HasPayloadType;
			if (hasPayloadType)
			{
				num ^= this.PayloadType.GetHashCode();
			}
			bool hasPayload = this.HasPayload;
			if (hasPayload)
			{
				num ^= this.Payload.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007FE2 RID: 32738 RVA: 0x001F1F08 File Offset: 0x001F0108
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007FE3 RID: 32739 RVA: 0x001F1F20 File Offset: 0x001F0120
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007FE4 RID: 32740 RVA: 0x001F1F2C File Offset: 0x001F012C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasRequestToken = this.HasRequestToken;
			if (hasRequestToken)
			{
				output.WriteRawTag(10);
				output.WriteString(this.RequestToken);
			}
			bool hasPayloadType = this.HasPayloadType;
			if (hasPayloadType)
			{
				output.WriteRawTag(18);
				output.WriteString(this.PayloadType);
			}
			bool hasPayload = this.HasPayload;
			if (hasPayload)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.Payload);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007FE5 RID: 32741 RVA: 0x001F1FBC File Offset: 0x001F01BC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasRequestToken = this.HasRequestToken;
			if (hasRequestToken)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.RequestToken);
			}
			bool hasPayloadType = this.HasPayloadType;
			if (hasPayloadType)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PayloadType);
			}
			bool hasPayload = this.HasPayload;
			if (hasPayload)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Payload);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007FE6 RID: 32742 RVA: 0x001F2048 File Offset: 0x001F0248
		[DebuggerNonUserCode]
		public void MergeFrom(ChallengeExternalRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasRequestToken = other.HasRequestToken;
				if (hasRequestToken)
				{
					this.RequestToken = other.RequestToken;
				}
				bool hasPayloadType = other.HasPayloadType;
				if (hasPayloadType)
				{
					this.PayloadType = other.PayloadType;
				}
				bool hasPayload = other.HasPayload;
				if (hasPayload)
				{
					this.Payload = other.Payload;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007FE7 RID: 32743 RVA: 0x001F20C3 File Offset: 0x001F02C3
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007FE8 RID: 32744 RVA: 0x001F20D0 File Offset: 0x001F02D0
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Payload = input.ReadBytes();
						}
					}
					else
					{
						this.PayloadType = input.ReadString();
					}
				}
				else
				{
					this.RequestToken = input.ReadString();
				}
			}
		}

		// Token: 0x04003A0C RID: 14860
		private static readonly MessageParser<ChallengeExternalRequest> _parser = new MessageParser<ChallengeExternalRequest>(() => new ChallengeExternalRequest());

		// Token: 0x04003A0D RID: 14861
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A0E RID: 14862
		public const int RequestTokenFieldNumber = 1;

		// Token: 0x04003A0F RID: 14863
		private static readonly string RequestTokenDefaultValue = "";

		// Token: 0x04003A10 RID: 14864
		private string requestToken_;

		// Token: 0x04003A11 RID: 14865
		public const int PayloadTypeFieldNumber = 2;

		// Token: 0x04003A12 RID: 14866
		private static readonly string PayloadTypeDefaultValue = "";

		// Token: 0x04003A13 RID: 14867
		private string payloadType_;

		// Token: 0x04003A14 RID: 14868
		public const int PayloadFieldNumber = 3;

		// Token: 0x04003A15 RID: 14869
		private static readonly ByteString PayloadDefaultValue = ByteString.Empty;

		// Token: 0x04003A16 RID: 14870
		private ByteString payload_;
	}
}
