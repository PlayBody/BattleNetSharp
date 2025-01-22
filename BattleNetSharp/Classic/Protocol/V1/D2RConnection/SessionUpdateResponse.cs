using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.D2RConnection
{
	// Token: 0x02000777 RID: 1911
	public sealed class SessionUpdateResponse : IMessage<SessionUpdateResponse>, IMessage, IEquatable<SessionUpdateResponse>, IDeepCloneable<SessionUpdateResponse>, IBufferMessage
	{
		// Token: 0x1700365F RID: 13919
		// (get) Token: 0x0600AFD2 RID: 45010 RVA: 0x002ACA78 File Offset: 0x002AAC78
		[DebuggerNonUserCode]
		public static MessageParser<SessionUpdateResponse> Parser
		{
			get
			{
				return SessionUpdateResponse._parser;
			}
		}

		// Token: 0x17003660 RID: 13920
		// (get) Token: 0x0600AFD3 RID: 45011 RVA: 0x002ACA90 File Offset: 0x002AAC90
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return D2RConnectionReflection.Descriptor.MessageTypes[11];
			}
		}

		// Token: 0x17003661 RID: 13921
		// (get) Token: 0x0600AFD4 RID: 45012 RVA: 0x002ACAB4 File Offset: 0x002AACB4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SessionUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0600AFD5 RID: 45013 RVA: 0x002ACACB File Offset: 0x002AACCB
		[DebuggerNonUserCode]
		public SessionUpdateResponse()
		{
		}

		// Token: 0x0600AFD6 RID: 45014 RVA: 0x002ACAD5 File Offset: 0x002AACD5
		[DebuggerNonUserCode]
		public SessionUpdateResponse(SessionUpdateResponse other)
			: this()
		{
			this.sessionKey_ = ((other.sessionKey_ != null) ? other.sessionKey_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AFD7 RID: 45015 RVA: 0x002ACB0C File Offset: 0x002AAD0C
		[DebuggerNonUserCode]
		public SessionUpdateResponse Clone()
		{
			return new SessionUpdateResponse(this);
		}

		// Token: 0x17003662 RID: 13922
		// (get) Token: 0x0600AFD8 RID: 45016 RVA: 0x002ACB24 File Offset: 0x002AAD24
		// (set) Token: 0x0600AFD9 RID: 45017 RVA: 0x002ACB3C File Offset: 0x002AAD3C
		[DebuggerNonUserCode]
		public AuthSessionResponse SessionKey
		{
			get
			{
				return this.sessionKey_;
			}
			set
			{
				this.sessionKey_ = value;
			}
		}

		// Token: 0x0600AFDA RID: 45018 RVA: 0x002ACB48 File Offset: 0x002AAD48
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SessionUpdateResponse);
		}

		// Token: 0x0600AFDB RID: 45019 RVA: 0x002ACB68 File Offset: 0x002AAD68
		[DebuggerNonUserCode]
		public bool Equals(SessionUpdateResponse other)
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
					bool flag4 = !object.Equals(this.SessionKey, other.SessionKey);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600AFDC RID: 45020 RVA: 0x002ACBC4 File Offset: 0x002AADC4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.sessionKey_ != null;
			if (flag)
			{
				num ^= this.SessionKey.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AFDD RID: 45021 RVA: 0x002ACC14 File Offset: 0x002AAE14
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AFDE RID: 45022 RVA: 0x002ACC2C File Offset: 0x002AAE2C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AFDF RID: 45023 RVA: 0x002ACC38 File Offset: 0x002AAE38
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.sessionKey_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.SessionKey);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AFE0 RID: 45024 RVA: 0x002ACC88 File Offset: 0x002AAE88
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.sessionKey_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SessionKey);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AFE1 RID: 45025 RVA: 0x002ACCDC File Offset: 0x002AAEDC
		[DebuggerNonUserCode]
		public void MergeFrom(SessionUpdateResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.sessionKey_ != null;
				if (flag2)
				{
					bool flag3 = this.sessionKey_ == null;
					if (flag3)
					{
						this.SessionKey = new AuthSessionResponse();
					}
					this.SessionKey.MergeFrom(other.SessionKey);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600AFE2 RID: 45026 RVA: 0x002ACD48 File Offset: 0x002AAF48
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AFE3 RID: 45027 RVA: 0x002ACD54 File Offset: 0x002AAF54
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					bool flag = this.sessionKey_ == null;
					if (flag)
					{
						this.SessionKey = new AuthSessionResponse();
					}
					input.ReadMessage(this.SessionKey);
				}
			}
		}

		// Token: 0x04004F42 RID: 20290
		private static readonly MessageParser<SessionUpdateResponse> _parser = new MessageParser<SessionUpdateResponse>(() => new SessionUpdateResponse());

		// Token: 0x04004F43 RID: 20291
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F44 RID: 20292
		public const int SessionKeyFieldNumber = 2;

		// Token: 0x04004F45 RID: 20293
		private AuthSessionResponse sessionKey_;
	}
}
