using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x0200054E RID: 1358
	public sealed class SessionIdentifier : IMessage<SessionIdentifier>, IMessage, IEquatable<SessionIdentifier>, IDeepCloneable<SessionIdentifier>, IBufferMessage
	{
		// Token: 0x17002973 RID: 10611
		// (get) Token: 0x06008330 RID: 33584 RVA: 0x001FE808 File Offset: 0x001FCA08
		[DebuggerNonUserCode]
		public static MessageParser<SessionIdentifier> Parser
		{
			get
			{
				return SessionIdentifier._parser;
			}
		}

		// Token: 0x17002974 RID: 10612
		// (get) Token: 0x06008331 RID: 33585 RVA: 0x001FE820 File Offset: 0x001FCA20
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002975 RID: 10613
		// (get) Token: 0x06008332 RID: 33586 RVA: 0x001FE844 File Offset: 0x001FCA44
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SessionIdentifier.Descriptor;
			}
		}

		// Token: 0x06008333 RID: 33587 RVA: 0x001FE85B File Offset: 0x001FCA5B
		[DebuggerNonUserCode]
		public SessionIdentifier()
		{
		}

		// Token: 0x06008334 RID: 33588 RVA: 0x001FE868 File Offset: 0x001FCA68
		[DebuggerNonUserCode]
		public SessionIdentifier(SessionIdentifier other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameAccount_ = ((other.gameAccount_ != null) ? other.gameAccount_.Clone() : null);
			this.sessionId_ = other.sessionId_;
			this.accountId_ = other.accountId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008335 RID: 33589 RVA: 0x001FE8D0 File Offset: 0x001FCAD0
		[DebuggerNonUserCode]
		public SessionIdentifier Clone()
		{
			return new SessionIdentifier(this);
		}

		// Token: 0x17002976 RID: 10614
		// (get) Token: 0x06008336 RID: 33590 RVA: 0x001FE8E8 File Offset: 0x001FCAE8
		// (set) Token: 0x06008337 RID: 33591 RVA: 0x001FE900 File Offset: 0x001FCB00
		[DebuggerNonUserCode]
		public GameAccountHandle GameAccount
		{
			get
			{
				return this.gameAccount_;
			}
			set
			{
				this.gameAccount_ = value;
			}
		}

		// Token: 0x17002977 RID: 10615
		// (get) Token: 0x06008338 RID: 33592 RVA: 0x001FE90C File Offset: 0x001FCB0C
		// (set) Token: 0x06008339 RID: 33593 RVA: 0x001FE92D File Offset: 0x001FCB2D
		[DebuggerNonUserCode]
		public string SessionId
		{
			get
			{
				return this.sessionId_ ?? SessionIdentifier.SessionIdDefaultValue;
			}
			set
			{
				this.sessionId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002978 RID: 10616
		// (get) Token: 0x0600833A RID: 33594 RVA: 0x001FE944 File Offset: 0x001FCB44
		[DebuggerNonUserCode]
		public bool HasSessionId
		{
			get
			{
				return this.sessionId_ != null;
			}
		}

		// Token: 0x0600833B RID: 33595 RVA: 0x001FE95F File Offset: 0x001FCB5F
		[DebuggerNonUserCode]
		public void ClearSessionId()
		{
			this.sessionId_ = null;
		}

		// Token: 0x17002979 RID: 10617
		// (get) Token: 0x0600833C RID: 33596 RVA: 0x001FE96C File Offset: 0x001FCB6C
		// (set) Token: 0x0600833D RID: 33597 RVA: 0x001FE99D File Offset: 0x001FCB9D
		[DebuggerNonUserCode]
		public ulong AccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong accountIdDefaultValue;
				if (flag)
				{
					accountIdDefaultValue = this.accountId_;
				}
				else
				{
					accountIdDefaultValue = SessionIdentifier.AccountIdDefaultValue;
				}
				return accountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.accountId_ = value;
			}
		}

		// Token: 0x1700297A RID: 10618
		// (get) Token: 0x0600833E RID: 33598 RVA: 0x001FE9B8 File Offset: 0x001FCBB8
		[DebuggerNonUserCode]
		public bool HasAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600833F RID: 33599 RVA: 0x001FE9D5 File Offset: 0x001FCBD5
		[DebuggerNonUserCode]
		public void ClearAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06008340 RID: 33600 RVA: 0x001FE9E8 File Offset: 0x001FCBE8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SessionIdentifier);
		}

		// Token: 0x06008341 RID: 33601 RVA: 0x001FEA08 File Offset: 0x001FCC08
		[DebuggerNonUserCode]
		public bool Equals(SessionIdentifier other)
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
					bool flag4 = !object.Equals(this.GameAccount, other.GameAccount);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SessionId != other.SessionId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.AccountId != other.AccountId;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008342 RID: 33602 RVA: 0x001FEA98 File Offset: 0x001FCC98
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.gameAccount_ != null;
			if (flag)
			{
				num ^= this.GameAccount.GetHashCode();
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				num ^= this.SessionId.GetHashCode();
			}
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				num ^= this.AccountId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008343 RID: 33603 RVA: 0x001FEB20 File Offset: 0x001FCD20
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008344 RID: 33604 RVA: 0x001FEB38 File Offset: 0x001FCD38
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008345 RID: 33605 RVA: 0x001FEB44 File Offset: 0x001FCD44
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.gameAccount_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GameAccount);
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				output.WriteRawTag(18);
				output.WriteString(this.SessionId);
			}
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.AccountId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008346 RID: 33606 RVA: 0x001FEBD8 File Offset: 0x001FCDD8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.gameAccount_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccount);
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SessionId);
			}
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.AccountId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008347 RID: 33607 RVA: 0x001FEC68 File Offset: 0x001FCE68
		[DebuggerNonUserCode]
		public void MergeFrom(SessionIdentifier other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.gameAccount_ != null;
				if (flag2)
				{
					bool flag3 = this.gameAccount_ == null;
					if (flag3)
					{
						this.GameAccount = new GameAccountHandle();
					}
					this.GameAccount.MergeFrom(other.GameAccount);
				}
				bool hasSessionId = other.HasSessionId;
				if (hasSessionId)
				{
					this.SessionId = other.SessionId;
				}
				bool hasAccountId = other.HasAccountId;
				if (hasAccountId)
				{
					this.AccountId = other.AccountId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008348 RID: 33608 RVA: 0x001FED0B File Offset: 0x001FCF0B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008349 RID: 33609 RVA: 0x001FED18 File Offset: 0x001FCF18
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.AccountId = input.ReadUInt64();
						}
					}
					else
					{
						this.SessionId = input.ReadString();
					}
				}
				else
				{
					bool flag = this.gameAccount_ == null;
					if (flag)
					{
						this.GameAccount = new GameAccountHandle();
					}
					input.ReadMessage(this.GameAccount);
				}
			}
		}

		// Token: 0x04003B94 RID: 15252
		private static readonly MessageParser<SessionIdentifier> _parser = new MessageParser<SessionIdentifier>(() => new SessionIdentifier());

		// Token: 0x04003B95 RID: 15253
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B96 RID: 15254
		private int _hasBits0;

		// Token: 0x04003B97 RID: 15255
		public const int GameAccountFieldNumber = 1;

		// Token: 0x04003B98 RID: 15256
		private GameAccountHandle gameAccount_;

		// Token: 0x04003B99 RID: 15257
		public const int SessionIdFieldNumber = 2;

		// Token: 0x04003B9A RID: 15258
		private static readonly string SessionIdDefaultValue = "";

		// Token: 0x04003B9B RID: 15259
		private string sessionId_;

		// Token: 0x04003B9C RID: 15260
		public const int AccountIdFieldNumber = 3;

		// Token: 0x04003B9D RID: 15261
		private static readonly ulong AccountIdDefaultValue = 0UL;

		// Token: 0x04003B9E RID: 15262
		private ulong accountId_;
	}
}
