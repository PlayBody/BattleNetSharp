using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.D2RConnection
{
	// Token: 0x02000772 RID: 1906
	public sealed class AuthResponse : IMessage<AuthResponse>, IMessage, IEquatable<AuthResponse>, IDeepCloneable<AuthResponse>, IBufferMessage
	{
		// Token: 0x17003620 RID: 13856
		// (get) Token: 0x0600AF1F RID: 44831 RVA: 0x002AA0C8 File Offset: 0x002A82C8
		[DebuggerNonUserCode]
		public static MessageParser<AuthResponse> Parser
		{
			get
			{
				return AuthResponse._parser;
			}
		}

		// Token: 0x17003621 RID: 13857
		// (get) Token: 0x0600AF20 RID: 44832 RVA: 0x002AA0E0 File Offset: 0x002A82E0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return D2RConnectionReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17003622 RID: 13858
		// (get) Token: 0x0600AF21 RID: 44833 RVA: 0x002AA104 File Offset: 0x002A8304
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AuthResponse.Descriptor;
			}
		}

		// Token: 0x0600AF22 RID: 44834 RVA: 0x002AA11B File Offset: 0x002A831B
		[DebuggerNonUserCode]
		public AuthResponse()
		{
		}

		// Token: 0x0600AF23 RID: 44835 RVA: 0x002AA125 File Offset: 0x002A8325
		[DebuggerNonUserCode]
		public AuthResponse(AuthResponse other)
			: this()
		{
			this.sessionKey_ = other.sessionKey_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AF24 RID: 44836 RVA: 0x002AA14C File Offset: 0x002A834C
		[DebuggerNonUserCode]
		public AuthResponse Clone()
		{
			return new AuthResponse(this);
		}

		// Token: 0x17003623 RID: 13859
		// (get) Token: 0x0600AF25 RID: 44837 RVA: 0x002AA164 File Offset: 0x002A8364
		// (set) Token: 0x0600AF26 RID: 44838 RVA: 0x002AA185 File Offset: 0x002A8385
		[DebuggerNonUserCode]
		public ByteString SessionKey
		{
			get
			{
				return this.sessionKey_ ?? AuthResponse.SessionKeyDefaultValue;
			}
			set
			{
				this.sessionKey_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17003624 RID: 13860
		// (get) Token: 0x0600AF27 RID: 44839 RVA: 0x002AA19C File Offset: 0x002A839C
		[DebuggerNonUserCode]
		public bool HasSessionKey
		{
			get
			{
				return this.sessionKey_ != null;
			}
		}

		// Token: 0x0600AF28 RID: 44840 RVA: 0x002AA1BA File Offset: 0x002A83BA
		[DebuggerNonUserCode]
		public void ClearSessionKey()
		{
			this.sessionKey_ = null;
		}

		// Token: 0x0600AF29 RID: 44841 RVA: 0x002AA1C4 File Offset: 0x002A83C4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AuthResponse);
		}

		// Token: 0x0600AF2A RID: 44842 RVA: 0x002AA1E4 File Offset: 0x002A83E4
		[DebuggerNonUserCode]
		public bool Equals(AuthResponse other)
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

		// Token: 0x0600AF2B RID: 44843 RVA: 0x002AA23C File Offset: 0x002A843C
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

		// Token: 0x0600AF2C RID: 44844 RVA: 0x002AA288 File Offset: 0x002A8488
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AF2D RID: 44845 RVA: 0x002AA2A0 File Offset: 0x002A84A0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AF2E RID: 44846 RVA: 0x002AA2AC File Offset: 0x002A84AC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.SessionKey);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AF2F RID: 44847 RVA: 0x002AA2F8 File Offset: 0x002A84F8
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

		// Token: 0x0600AF30 RID: 44848 RVA: 0x002AA348 File Offset: 0x002A8548
		[DebuggerNonUserCode]
		public void MergeFrom(AuthResponse other)
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

		// Token: 0x0600AF31 RID: 44849 RVA: 0x002AA391 File Offset: 0x002A8591
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AF32 RID: 44850 RVA: 0x002AA39C File Offset: 0x002A859C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SessionKey = input.ReadBytes();
				}
			}
		}

		// Token: 0x04004EE9 RID: 20201
		private static readonly MessageParser<AuthResponse> _parser = new MessageParser<AuthResponse>(() => new AuthResponse());

		// Token: 0x04004EEA RID: 20202
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EEB RID: 20203
		public const int SessionKeyFieldNumber = 3;

		// Token: 0x04004EEC RID: 20204
		private static readonly ByteString SessionKeyDefaultValue = ByteString.Empty;

		// Token: 0x04004EED RID: 20205
		private ByteString sessionKey_;
	}
}
