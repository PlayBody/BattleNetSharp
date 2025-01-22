using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x0200053E RID: 1342
	public sealed class RefreshSessionKeyResponse : IMessage<RefreshSessionKeyResponse>, IMessage, IEquatable<RefreshSessionKeyResponse>, IDeepCloneable<RefreshSessionKeyResponse>, IBufferMessage
	{
		// Token: 0x17002906 RID: 10502
		// (get) Token: 0x060081D5 RID: 33237 RVA: 0x001F8F64 File Offset: 0x001F7164
		[DebuggerNonUserCode]
		public static MessageParser<RefreshSessionKeyResponse> Parser
		{
			get
			{
				return RefreshSessionKeyResponse._parser;
			}
		}

		// Token: 0x17002907 RID: 10503
		// (get) Token: 0x060081D6 RID: 33238 RVA: 0x001F8F7C File Offset: 0x001F717C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[15];
			}
		}

		// Token: 0x17002908 RID: 10504
		// (get) Token: 0x060081D7 RID: 33239 RVA: 0x001F8FA0 File Offset: 0x001F71A0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RefreshSessionKeyResponse.Descriptor;
			}
		}

		// Token: 0x060081D8 RID: 33240 RVA: 0x001F8FB7 File Offset: 0x001F71B7
		[DebuggerNonUserCode]
		public RefreshSessionKeyResponse()
		{
		}

		// Token: 0x060081D9 RID: 33241 RVA: 0x001F8FC1 File Offset: 0x001F71C1
		[DebuggerNonUserCode]
		public RefreshSessionKeyResponse(RefreshSessionKeyResponse other)
			: this()
		{
			this.sessionKey_ = other.sessionKey_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060081DA RID: 33242 RVA: 0x001F8FE8 File Offset: 0x001F71E8
		[DebuggerNonUserCode]
		public RefreshSessionKeyResponse Clone()
		{
			return new RefreshSessionKeyResponse(this);
		}

		// Token: 0x17002909 RID: 10505
		// (get) Token: 0x060081DB RID: 33243 RVA: 0x001F9000 File Offset: 0x001F7200
		// (set) Token: 0x060081DC RID: 33244 RVA: 0x001F9021 File Offset: 0x001F7221
		[DebuggerNonUserCode]
		public ByteString SessionKey
		{
			get
			{
				return this.sessionKey_ ?? RefreshSessionKeyResponse.SessionKeyDefaultValue;
			}
			set
			{
				this.sessionKey_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x1700290A RID: 10506
		// (get) Token: 0x060081DD RID: 33245 RVA: 0x001F9038 File Offset: 0x001F7238
		[DebuggerNonUserCode]
		public bool HasSessionKey
		{
			get
			{
				return this.sessionKey_ != null;
			}
		}

		// Token: 0x060081DE RID: 33246 RVA: 0x001F9056 File Offset: 0x001F7256
		[DebuggerNonUserCode]
		public void ClearSessionKey()
		{
			this.sessionKey_ = null;
		}

		// Token: 0x060081DF RID: 33247 RVA: 0x001F9060 File Offset: 0x001F7260
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RefreshSessionKeyResponse);
		}

		// Token: 0x060081E0 RID: 33248 RVA: 0x001F9080 File Offset: 0x001F7280
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
					bool flag4 = this.SessionKey != other.SessionKey;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060081E1 RID: 33249 RVA: 0x001F90D8 File Offset: 0x001F72D8
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

		// Token: 0x060081E2 RID: 33250 RVA: 0x001F9124 File Offset: 0x001F7324
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060081E3 RID: 33251 RVA: 0x001F913C File Offset: 0x001F733C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060081E4 RID: 33252 RVA: 0x001F9148 File Offset: 0x001F7348
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

		// Token: 0x060081E5 RID: 33253 RVA: 0x001F9194 File Offset: 0x001F7394
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

		// Token: 0x060081E6 RID: 33254 RVA: 0x001F91E4 File Offset: 0x001F73E4
		[DebuggerNonUserCode]
		public void MergeFrom(RefreshSessionKeyResponse other)
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

		// Token: 0x060081E7 RID: 33255 RVA: 0x001F922D File Offset: 0x001F742D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060081E8 RID: 33256 RVA: 0x001F9238 File Offset: 0x001F7438
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

		// Token: 0x04003ACA RID: 15050
		private static readonly MessageParser<RefreshSessionKeyResponse> _parser = new MessageParser<RefreshSessionKeyResponse>(() => new RefreshSessionKeyResponse());

		// Token: 0x04003ACB RID: 15051
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003ACC RID: 15052
		public const int SessionKeyFieldNumber = 1;

		// Token: 0x04003ACD RID: 15053
		private static readonly ByteString SessionKeyDefaultValue = ByteString.Empty;

		// Token: 0x04003ACE RID: 15054
		private ByteString sessionKey_;
	}
}
