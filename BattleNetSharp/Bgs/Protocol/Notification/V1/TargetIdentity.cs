using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Notification.V1
{
	// Token: 0x020005D3 RID: 1491
	public sealed class TargetIdentity : IMessage<TargetIdentity>, IMessage, IEquatable<TargetIdentity>, IDeepCloneable<TargetIdentity>, IBufferMessage
	{
		// Token: 0x17002C26 RID: 11302
		// (get) Token: 0x06008CC5 RID: 36037 RVA: 0x00222A84 File Offset: 0x00220C84
		[DebuggerNonUserCode]
		public static MessageParser<TargetIdentity> Parser
		{
			get
			{
				return TargetIdentity._parser;
			}
		}

		// Token: 0x17002C27 RID: 11303
		// (get) Token: 0x06008CC6 RID: 36038 RVA: 0x00222A9C File Offset: 0x00220C9C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NotificationTypesReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17002C28 RID: 11304
		// (get) Token: 0x06008CC7 RID: 36039 RVA: 0x00222AC0 File Offset: 0x00220CC0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TargetIdentity.Descriptor;
			}
		}

		// Token: 0x06008CC8 RID: 36040 RVA: 0x00222AD7 File Offset: 0x00220CD7
		[DebuggerNonUserCode]
		public TargetIdentity()
		{
		}

		// Token: 0x06008CC9 RID: 36041 RVA: 0x00222AE4 File Offset: 0x00220CE4
		[DebuggerNonUserCode]
		public TargetIdentity(TargetIdentity other)
			: this()
		{
			this.account_ = ((other.account_ != null) ? other.account_.Clone() : null);
			this.gameAccount_ = ((other.gameAccount_ != null) ? other.gameAccount_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008CCA RID: 36042 RVA: 0x00222B44 File Offset: 0x00220D44
		[DebuggerNonUserCode]
		public TargetIdentity Clone()
		{
			return new TargetIdentity(this);
		}

		// Token: 0x17002C29 RID: 11305
		// (get) Token: 0x06008CCB RID: 36043 RVA: 0x00222B5C File Offset: 0x00220D5C
		// (set) Token: 0x06008CCC RID: 36044 RVA: 0x00222B74 File Offset: 0x00220D74
		[DebuggerNonUserCode]
		public AccountId Account
		{
			get
			{
				return this.account_;
			}
			set
			{
				this.account_ = value;
			}
		}

		// Token: 0x17002C2A RID: 11306
		// (get) Token: 0x06008CCD RID: 36045 RVA: 0x00222B80 File Offset: 0x00220D80
		// (set) Token: 0x06008CCE RID: 36046 RVA: 0x00222B98 File Offset: 0x00220D98
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

		// Token: 0x06008CCF RID: 36047 RVA: 0x00222BA4 File Offset: 0x00220DA4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as TargetIdentity);
		}

		// Token: 0x06008CD0 RID: 36048 RVA: 0x00222BC4 File Offset: 0x00220DC4
		[DebuggerNonUserCode]
		public bool Equals(TargetIdentity other)
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
					bool flag4 = !object.Equals(this.Account, other.Account);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.GameAccount, other.GameAccount);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008CD1 RID: 36049 RVA: 0x00222C3C File Offset: 0x00220E3C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.account_ != null;
			if (flag)
			{
				num ^= this.Account.GetHashCode();
			}
			bool flag2 = this.gameAccount_ != null;
			if (flag2)
			{
				num ^= this.GameAccount.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008CD2 RID: 36050 RVA: 0x00222CA8 File Offset: 0x00220EA8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008CD3 RID: 36051 RVA: 0x00222CC0 File Offset: 0x00220EC0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008CD4 RID: 36052 RVA: 0x00222CCC File Offset: 0x00220ECC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.account_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Account);
			}
			bool flag2 = this.gameAccount_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.GameAccount);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008CD5 RID: 36053 RVA: 0x00222D40 File Offset: 0x00220F40
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.account_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Account);
			}
			bool flag2 = this.gameAccount_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccount);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008CD6 RID: 36054 RVA: 0x00222DB4 File Offset: 0x00220FB4
		[DebuggerNonUserCode]
		public void MergeFrom(TargetIdentity other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.account_ != null;
				if (flag2)
				{
					bool flag3 = this.account_ == null;
					if (flag3)
					{
						this.Account = new AccountId();
					}
					this.Account.MergeFrom(other.Account);
				}
				bool flag4 = other.gameAccount_ != null;
				if (flag4)
				{
					bool flag5 = this.gameAccount_ == null;
					if (flag5)
					{
						this.GameAccount = new GameAccountHandle();
					}
					this.GameAccount.MergeFrom(other.GameAccount);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008CD7 RID: 36055 RVA: 0x00222E61 File Offset: 0x00221061
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008CD8 RID: 36056 RVA: 0x00222E6C File Offset: 0x0022106C
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
					bool flag2 = this.account_ == null;
					if (flag2)
					{
						this.Account = new AccountId();
					}
					input.ReadMessage(this.Account);
				}
			}
		}

		// Token: 0x04003FB1 RID: 16305
		private static readonly MessageParser<TargetIdentity> _parser = new MessageParser<TargetIdentity>(() => new TargetIdentity());

		// Token: 0x04003FB2 RID: 16306
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FB3 RID: 16307
		public const int AccountFieldNumber = 1;

		// Token: 0x04003FB4 RID: 16308
		private AccountId account_;

		// Token: 0x04003FB5 RID: 16309
		public const int GameAccountFieldNumber = 2;

		// Token: 0x04003FB6 RID: 16310
		private GameAccountHandle gameAccount_;
	}
}
