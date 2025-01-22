using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x0200053D RID: 1341
	public sealed class RefreshSessionKeyRequest : IMessage<RefreshSessionKeyRequest>, IMessage, IEquatable<RefreshSessionKeyRequest>, IDeepCloneable<RefreshSessionKeyRequest>, IBufferMessage
	{
		// Token: 0x17002901 RID: 10497
		// (get) Token: 0x060081C0 RID: 33216 RVA: 0x001F8C18 File Offset: 0x001F6E18
		[DebuggerNonUserCode]
		public static MessageParser<RefreshSessionKeyRequest> Parser
		{
			get
			{
				return RefreshSessionKeyRequest._parser;
			}
		}

		// Token: 0x17002902 RID: 10498
		// (get) Token: 0x060081C1 RID: 33217 RVA: 0x001F8C30 File Offset: 0x001F6E30
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[14];
			}
		}

		// Token: 0x17002903 RID: 10499
		// (get) Token: 0x060081C2 RID: 33218 RVA: 0x001F8C54 File Offset: 0x001F6E54
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RefreshSessionKeyRequest.Descriptor;
			}
		}

		// Token: 0x060081C3 RID: 33219 RVA: 0x001F8C6B File Offset: 0x001F6E6B
		[DebuggerNonUserCode]
		public RefreshSessionKeyRequest()
		{
		}

		// Token: 0x060081C4 RID: 33220 RVA: 0x001F8C75 File Offset: 0x001F6E75
		[DebuggerNonUserCode]
		public RefreshSessionKeyRequest(RefreshSessionKeyRequest other)
			: this()
		{
			this.sessionKey_ = other.sessionKey_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060081C5 RID: 33221 RVA: 0x001F8C9C File Offset: 0x001F6E9C
		[DebuggerNonUserCode]
		public RefreshSessionKeyRequest Clone()
		{
			return new RefreshSessionKeyRequest(this);
		}

		// Token: 0x17002904 RID: 10500
		// (get) Token: 0x060081C6 RID: 33222 RVA: 0x001F8CB4 File Offset: 0x001F6EB4
		// (set) Token: 0x060081C7 RID: 33223 RVA: 0x001F8CD5 File Offset: 0x001F6ED5
		[DebuggerNonUserCode]
		public ByteString SessionKey
		{
			get
			{
				return this.sessionKey_ ?? RefreshSessionKeyRequest.SessionKeyDefaultValue;
			}
			set
			{
				this.sessionKey_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17002905 RID: 10501
		// (get) Token: 0x060081C8 RID: 33224 RVA: 0x001F8CEC File Offset: 0x001F6EEC
		[DebuggerNonUserCode]
		public bool HasSessionKey
		{
			get
			{
				return this.sessionKey_ != null;
			}
		}

		// Token: 0x060081C9 RID: 33225 RVA: 0x001F8D0A File Offset: 0x001F6F0A
		[DebuggerNonUserCode]
		public void ClearSessionKey()
		{
			this.sessionKey_ = null;
		}

		// Token: 0x060081CA RID: 33226 RVA: 0x001F8D14 File Offset: 0x001F6F14
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RefreshSessionKeyRequest);
		}

		// Token: 0x060081CB RID: 33227 RVA: 0x001F8D34 File Offset: 0x001F6F34
		[DebuggerNonUserCode]
		public bool Equals(RefreshSessionKeyRequest other)
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
					bool flag4 = this.SessionKey != other.SessionKey;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060081CC RID: 33228 RVA: 0x001F8D8C File Offset: 0x001F6F8C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x060081CD RID: 33229 RVA: 0x001F8DD8 File Offset: 0x001F6FD8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060081CE RID: 33230 RVA: 0x001F8DF0 File Offset: 0x001F6FF0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060081CF RID: 33231 RVA: 0x001F8DFC File Offset: 0x001F6FFC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				output.WriteRawTag(10);
				output.WriteBytes(this.SessionKey);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060081D0 RID: 33232 RVA: 0x001F8E48 File Offset: 0x001F7048
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x060081D1 RID: 33233 RVA: 0x001F8E98 File Offset: 0x001F7098
		[DebuggerNonUserCode]
		public void MergeFrom(RefreshSessionKeyRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSessionKey = other.HasSessionKey;
				if (hasSessionKey)
				{
					this.SessionKey = other.SessionKey;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060081D2 RID: 33234 RVA: 0x001F8EE1 File Offset: 0x001F70E1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060081D3 RID: 33235 RVA: 0x001F8EEC File Offset: 0x001F70EC
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
					this.SessionKey = input.ReadBytes();
				}
			}
		}

		// Token: 0x04003AC5 RID: 15045
		private static readonly MessageParser<RefreshSessionKeyRequest> _parser = new MessageParser<RefreshSessionKeyRequest>(() => new RefreshSessionKeyRequest());

		// Token: 0x04003AC6 RID: 15046
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AC7 RID: 15047
		public const int SessionKeyFieldNumber = 1;

		// Token: 0x04003AC8 RID: 15048
		private static readonly ByteString SessionKeyDefaultValue = ByteString.Empty;

		// Token: 0x04003AC9 RID: 15049
		private ByteString sessionKey_;
	}
}
