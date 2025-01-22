using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V2;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x0200056B RID: 1387
	public sealed class SessionId : IMessage<SessionId>, IMessage, IEquatable<SessionId>, IDeepCloneable<SessionId>, IBufferMessage
	{
		// Token: 0x17002A0F RID: 10767
		// (get) Token: 0x06008562 RID: 34146 RVA: 0x002068F4 File Offset: 0x00204AF4
		[DebuggerNonUserCode]
		public static MessageParser<SessionId> Parser
		{
			get
			{
				return SessionId._parser;
			}
		}

		// Token: 0x17002A10 RID: 10768
		// (get) Token: 0x06008563 RID: 34147 RVA: 0x0020690C File Offset: 0x00204B0C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionTypesReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17002A11 RID: 10769
		// (get) Token: 0x06008564 RID: 34148 RVA: 0x00206930 File Offset: 0x00204B30
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SessionId.Descriptor;
			}
		}

		// Token: 0x06008565 RID: 34149 RVA: 0x00206947 File Offset: 0x00204B47
		[DebuggerNonUserCode]
		public SessionId()
		{
		}

		// Token: 0x06008566 RID: 34150 RVA: 0x00206954 File Offset: 0x00204B54
		[DebuggerNonUserCode]
		public SessionId(SessionId other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.accountId_ = other.accountId_;
			this.gameAccount_ = ((other.gameAccount_ != null) ? other.gameAccount_.Clone() : null);
			this.instanceId_ = other.instanceId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008567 RID: 34151 RVA: 0x002069BC File Offset: 0x00204BBC
		[DebuggerNonUserCode]
		public SessionId Clone()
		{
			return new SessionId(this);
		}

		// Token: 0x17002A12 RID: 10770
		// (get) Token: 0x06008568 RID: 34152 RVA: 0x002069D4 File Offset: 0x00204BD4
		// (set) Token: 0x06008569 RID: 34153 RVA: 0x00206A05 File Offset: 0x00204C05
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
					accountIdDefaultValue = SessionId.AccountIdDefaultValue;
				}
				return accountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.accountId_ = value;
			}
		}

		// Token: 0x17002A13 RID: 10771
		// (get) Token: 0x0600856A RID: 34154 RVA: 0x00206A20 File Offset: 0x00204C20
		[DebuggerNonUserCode]
		public bool HasAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600856B RID: 34155 RVA: 0x00206A3D File Offset: 0x00204C3D
		[DebuggerNonUserCode]
		public void ClearAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002A14 RID: 10772
		// (get) Token: 0x0600856C RID: 34156 RVA: 0x00206A50 File Offset: 0x00204C50
		// (set) Token: 0x0600856D RID: 34157 RVA: 0x00206A68 File Offset: 0x00204C68
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

		// Token: 0x17002A15 RID: 10773
		// (get) Token: 0x0600856E RID: 34158 RVA: 0x00206A74 File Offset: 0x00204C74
		// (set) Token: 0x0600856F RID: 34159 RVA: 0x00206A95 File Offset: 0x00204C95
		[DebuggerNonUserCode]
		public string InstanceId
		{
			get
			{
				return this.instanceId_ ?? SessionId.InstanceIdDefaultValue;
			}
			set
			{
				this.instanceId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002A16 RID: 10774
		// (get) Token: 0x06008570 RID: 34160 RVA: 0x00206AAC File Offset: 0x00204CAC
		[DebuggerNonUserCode]
		public bool HasInstanceId
		{
			get
			{
				return this.instanceId_ != null;
			}
		}

		// Token: 0x06008571 RID: 34161 RVA: 0x00206AC7 File Offset: 0x00204CC7
		[DebuggerNonUserCode]
		public void ClearInstanceId()
		{
			this.instanceId_ = null;
		}

		// Token: 0x06008572 RID: 34162 RVA: 0x00206AD4 File Offset: 0x00204CD4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SessionId);
		}

		// Token: 0x06008573 RID: 34163 RVA: 0x00206AF4 File Offset: 0x00204CF4
		[DebuggerNonUserCode]
		public bool Equals(SessionId other)
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
					bool flag4 = this.AccountId != other.AccountId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.GameAccount, other.GameAccount);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.InstanceId != other.InstanceId;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008574 RID: 34164 RVA: 0x00206B84 File Offset: 0x00204D84
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				num ^= this.AccountId.GetHashCode();
			}
			bool flag = this.gameAccount_ != null;
			if (flag)
			{
				num ^= this.GameAccount.GetHashCode();
			}
			bool hasInstanceId = this.HasInstanceId;
			if (hasInstanceId)
			{
				num ^= this.InstanceId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008575 RID: 34165 RVA: 0x00206C0C File Offset: 0x00204E0C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008576 RID: 34166 RVA: 0x00206C24 File Offset: 0x00204E24
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008577 RID: 34167 RVA: 0x00206C30 File Offset: 0x00204E30
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.AccountId);
			}
			bool flag = this.gameAccount_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.GameAccount);
			}
			bool hasInstanceId = this.HasInstanceId;
			if (hasInstanceId)
			{
				output.WriteRawTag(26);
				output.WriteString(this.InstanceId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008578 RID: 34168 RVA: 0x00206CC4 File Offset: 0x00204EC4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.AccountId);
			}
			bool flag = this.gameAccount_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccount);
			}
			bool hasInstanceId = this.HasInstanceId;
			if (hasInstanceId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.InstanceId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008579 RID: 34169 RVA: 0x00206D54 File Offset: 0x00204F54
		[DebuggerNonUserCode]
		public void MergeFrom(SessionId other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAccountId = other.HasAccountId;
				if (hasAccountId)
				{
					this.AccountId = other.AccountId;
				}
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
				bool hasInstanceId = other.HasInstanceId;
				if (hasInstanceId)
				{
					this.InstanceId = other.InstanceId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600857A RID: 34170 RVA: 0x00206DF7 File Offset: 0x00204FF7
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600857B RID: 34171 RVA: 0x00206E04 File Offset: 0x00205004
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 18U)
					{
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.InstanceId = input.ReadString();
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
				else
				{
					this.AccountId = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04003C81 RID: 15489
		private static readonly MessageParser<SessionId> _parser = new MessageParser<SessionId>(() => new SessionId());

		// Token: 0x04003C82 RID: 15490
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C83 RID: 15491
		private int _hasBits0;

		// Token: 0x04003C84 RID: 15492
		public const int AccountIdFieldNumber = 1;

		// Token: 0x04003C85 RID: 15493
		private static readonly ulong AccountIdDefaultValue = 0UL;

		// Token: 0x04003C86 RID: 15494
		private ulong accountId_;

		// Token: 0x04003C87 RID: 15495
		public const int GameAccountFieldNumber = 2;

		// Token: 0x04003C88 RID: 15496
		private GameAccountHandle gameAccount_;

		// Token: 0x04003C89 RID: 15497
		public const int InstanceIdFieldNumber = 3;

		// Token: 0x04003C8A RID: 15498
		private static readonly string InstanceIdDefaultValue = "";

		// Token: 0x04003C8B RID: 15499
		private string instanceId_;
	}
}
