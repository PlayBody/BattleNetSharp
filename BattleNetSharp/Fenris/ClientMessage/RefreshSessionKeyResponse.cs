using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200028E RID: 654
	public sealed class RefreshSessionKeyResponse : IMessage<RefreshSessionKeyResponse>, IMessage, IEquatable<RefreshSessionKeyResponse>, IDeepCloneable<RefreshSessionKeyResponse>, IBufferMessage
	{
		// Token: 0x17001617 RID: 5655
		// (get) Token: 0x0600458D RID: 17805 RVA: 0x0010B43C File Offset: 0x0010963C
		[DebuggerNonUserCode]
		public static MessageParser<RefreshSessionKeyResponse> Parser
		{
			get
			{
				return RefreshSessionKeyResponse._parser;
			}
		}

		// Token: 0x17001618 RID: 5656
		// (get) Token: 0x0600458E RID: 17806 RVA: 0x0010B454 File Offset: 0x00109654
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[126];
			}
		}

		// Token: 0x17001619 RID: 5657
		// (get) Token: 0x0600458F RID: 17807 RVA: 0x0010B478 File Offset: 0x00109678
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RefreshSessionKeyResponse.Descriptor;
			}
		}

		// Token: 0x06004590 RID: 17808 RVA: 0x0010B48F File Offset: 0x0010968F
		[DebuggerNonUserCode]
		public RefreshSessionKeyResponse()
		{
		}

		// Token: 0x06004591 RID: 17809 RVA: 0x0010B499 File Offset: 0x00109699
		[DebuggerNonUserCode]
		public RefreshSessionKeyResponse(RefreshSessionKeyResponse other)
			: this()
		{
			this.newSessionKey_ = other.newSessionKey_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004592 RID: 17810 RVA: 0x0010B4C0 File Offset: 0x001096C0
		[DebuggerNonUserCode]
		public RefreshSessionKeyResponse Clone()
		{
			return new RefreshSessionKeyResponse(this);
		}

		// Token: 0x1700161A RID: 5658
		// (get) Token: 0x06004593 RID: 17811 RVA: 0x0010B4D8 File Offset: 0x001096D8
		// (set) Token: 0x06004594 RID: 17812 RVA: 0x0010B4F9 File Offset: 0x001096F9
		[DebuggerNonUserCode]
		public ByteString NewSessionKey
		{
			get
			{
				return this.newSessionKey_ ?? RefreshSessionKeyResponse.NewSessionKeyDefaultValue;
			}
			set
			{
				this.newSessionKey_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x1700161B RID: 5659
		// (get) Token: 0x06004595 RID: 17813 RVA: 0x0010B510 File Offset: 0x00109710
		[DebuggerNonUserCode]
		public bool HasNewSessionKey
		{
			get
			{
				return this.newSessionKey_ != null;
			}
		}

		// Token: 0x06004596 RID: 17814 RVA: 0x0010B52E File Offset: 0x0010972E
		[DebuggerNonUserCode]
		public void ClearNewSessionKey()
		{
			this.newSessionKey_ = null;
		}

		// Token: 0x06004597 RID: 17815 RVA: 0x0010B538 File Offset: 0x00109738
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RefreshSessionKeyResponse);
		}

		// Token: 0x06004598 RID: 17816 RVA: 0x0010B558 File Offset: 0x00109758
		[DebuggerNonUserCode]
		public bool Equals(RefreshSessionKeyResponse other)
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
					bool flag4 = this.NewSessionKey != other.NewSessionKey;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06004599 RID: 17817 RVA: 0x0010B5B0 File Offset: 0x001097B0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasNewSessionKey = this.HasNewSessionKey;
			if (hasNewSessionKey)
			{
				num ^= this.NewSessionKey.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600459A RID: 17818 RVA: 0x0010B5FC File Offset: 0x001097FC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600459B RID: 17819 RVA: 0x0010B614 File Offset: 0x00109814
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600459C RID: 17820 RVA: 0x0010B620 File Offset: 0x00109820
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasNewSessionKey = this.HasNewSessionKey;
			if (hasNewSessionKey)
			{
				output.WriteRawTag(10);
				output.WriteBytes(this.NewSessionKey);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600459D RID: 17821 RVA: 0x0010B66C File Offset: 0x0010986C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasNewSessionKey = this.HasNewSessionKey;
			if (hasNewSessionKey)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.NewSessionKey);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600459E RID: 17822 RVA: 0x0010B6BC File Offset: 0x001098BC
		[DebuggerNonUserCode]
		public void MergeFrom(RefreshSessionKeyResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasNewSessionKey = other.HasNewSessionKey;
				if (hasNewSessionKey)
				{
					this.NewSessionKey = other.NewSessionKey;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600459F RID: 17823 RVA: 0x0010B705 File Offset: 0x00109905
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060045A0 RID: 17824 RVA: 0x0010B710 File Offset: 0x00109910
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
					this.NewSessionKey = input.ReadBytes();
				}
			}
		}

		// Token: 0x04001F17 RID: 7959
		private static readonly MessageParser<RefreshSessionKeyResponse> _parser = new MessageParser<RefreshSessionKeyResponse>(() => new RefreshSessionKeyResponse());

		// Token: 0x04001F18 RID: 7960
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F19 RID: 7961
		public const int NewSessionKeyFieldNumber = 1;

		// Token: 0x04001F1A RID: 7962
		private static readonly ByteString NewSessionKeyDefaultValue = ByteString.Empty;

		// Token: 0x04001F1B RID: 7963
		private ByteString newSessionKey_;
	}
}
