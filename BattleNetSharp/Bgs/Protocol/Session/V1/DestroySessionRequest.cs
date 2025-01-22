using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x02000532 RID: 1330
	public sealed class DestroySessionRequest : IMessage<DestroySessionRequest>, IMessage, IEquatable<DestroySessionRequest>, IDeepCloneable<DestroySessionRequest>, IBufferMessage
	{
		// Token: 0x170028C6 RID: 10438
		// (get) Token: 0x060080D4 RID: 32980 RVA: 0x001F5F58 File Offset: 0x001F4158
		[DebuggerNonUserCode]
		public static MessageParser<DestroySessionRequest> Parser
		{
			get
			{
				return DestroySessionRequest._parser;
			}
		}

		// Token: 0x170028C7 RID: 10439
		// (get) Token: 0x060080D5 RID: 32981 RVA: 0x001F5F70 File Offset: 0x001F4170
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x170028C8 RID: 10440
		// (get) Token: 0x060080D6 RID: 32982 RVA: 0x001F5F94 File Offset: 0x001F4194
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DestroySessionRequest.Descriptor;
			}
		}

		// Token: 0x060080D7 RID: 32983 RVA: 0x001F5FAB File Offset: 0x001F41AB
		[DebuggerNonUserCode]
		public DestroySessionRequest()
		{
		}

		// Token: 0x060080D8 RID: 32984 RVA: 0x001F5FB8 File Offset: 0x001F41B8
		[DebuggerNonUserCode]
		public DestroySessionRequest(DestroySessionRequest other)
			: this()
		{
			this.identity_ = ((other.identity_ != null) ? other.identity_.Clone() : null);
			this.sessionId_ = other.sessionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060080D9 RID: 32985 RVA: 0x001F6008 File Offset: 0x001F4208
		[DebuggerNonUserCode]
		public DestroySessionRequest Clone()
		{
			return new DestroySessionRequest(this);
		}

		// Token: 0x170028C9 RID: 10441
		// (get) Token: 0x060080DA RID: 32986 RVA: 0x001F6020 File Offset: 0x001F4220
		// (set) Token: 0x060080DB RID: 32987 RVA: 0x001F6038 File Offset: 0x001F4238
		[DebuggerNonUserCode]
		public Identity Identity
		{
			get
			{
				return this.identity_;
			}
			set
			{
				this.identity_ = value;
			}
		}

		// Token: 0x170028CA RID: 10442
		// (get) Token: 0x060080DC RID: 32988 RVA: 0x001F6044 File Offset: 0x001F4244
		// (set) Token: 0x060080DD RID: 32989 RVA: 0x001F6065 File Offset: 0x001F4265
		[DebuggerNonUserCode]
		public string SessionId
		{
			get
			{
				return this.sessionId_ ?? DestroySessionRequest.SessionIdDefaultValue;
			}
			set
			{
				this.sessionId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170028CB RID: 10443
		// (get) Token: 0x060080DE RID: 32990 RVA: 0x001F607C File Offset: 0x001F427C
		[DebuggerNonUserCode]
		public bool HasSessionId
		{
			get
			{
				return this.sessionId_ != null;
			}
		}

		// Token: 0x060080DF RID: 32991 RVA: 0x001F6097 File Offset: 0x001F4297
		[DebuggerNonUserCode]
		public void ClearSessionId()
		{
			this.sessionId_ = null;
		}

		// Token: 0x060080E0 RID: 32992 RVA: 0x001F60A4 File Offset: 0x001F42A4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DestroySessionRequest);
		}

		// Token: 0x060080E1 RID: 32993 RVA: 0x001F60C4 File Offset: 0x001F42C4
		[DebuggerNonUserCode]
		public bool Equals(DestroySessionRequest other)
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
					bool flag4 = !object.Equals(this.Identity, other.Identity);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SessionId != other.SessionId;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060080E2 RID: 32994 RVA: 0x001F6138 File Offset: 0x001F4338
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.identity_ != null;
			if (flag)
			{
				num ^= this.Identity.GetHashCode();
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				num ^= this.SessionId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060080E3 RID: 32995 RVA: 0x001F61A0 File Offset: 0x001F43A0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060080E4 RID: 32996 RVA: 0x001F61B8 File Offset: 0x001F43B8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060080E5 RID: 32997 RVA: 0x001F61C4 File Offset: 0x001F43C4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.identity_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Identity);
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				output.WriteRawTag(18);
				output.WriteString(this.SessionId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060080E6 RID: 32998 RVA: 0x001F6238 File Offset: 0x001F4438
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.identity_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Identity);
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SessionId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060080E7 RID: 32999 RVA: 0x001F62A8 File Offset: 0x001F44A8
		[DebuggerNonUserCode]
		public void MergeFrom(DestroySessionRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.identity_ != null;
				if (flag2)
				{
					bool flag3 = this.identity_ == null;
					if (flag3)
					{
						this.Identity = new Identity();
					}
					this.Identity.MergeFrom(other.Identity);
				}
				bool hasSessionId = other.HasSessionId;
				if (hasSessionId)
				{
					this.SessionId = other.SessionId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060080E8 RID: 33000 RVA: 0x001F632D File Offset: 0x001F452D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060080E9 RID: 33001 RVA: 0x001F6338 File Offset: 0x001F4538
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SessionId = input.ReadString();
					}
				}
				else
				{
					bool flag = this.identity_ == null;
					if (flag)
					{
						this.Identity = new Identity();
					}
					input.ReadMessage(this.Identity);
				}
			}
		}

		// Token: 0x04003A7C RID: 14972
		private static readonly MessageParser<DestroySessionRequest> _parser = new MessageParser<DestroySessionRequest>(() => new DestroySessionRequest());

		// Token: 0x04003A7D RID: 14973
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A7E RID: 14974
		public const int IdentityFieldNumber = 1;

		// Token: 0x04003A7F RID: 14975
		private Identity identity_;

		// Token: 0x04003A80 RID: 14976
		public const int SessionIdFieldNumber = 2;

		// Token: 0x04003A81 RID: 14977
		private static readonly string SessionIdDefaultValue = "";

		// Token: 0x04003A82 RID: 14978
		private string sessionId_;
	}
}
