using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V2
{
	// Token: 0x0200070C RID: 1804
	public sealed class Identity : IMessage<Identity>, IMessage, IEquatable<Identity>, IDeepCloneable<Identity>, IBufferMessage
	{
		// Token: 0x17003321 RID: 13089
		// (get) Token: 0x0600A580 RID: 42368 RVA: 0x002847C8 File Offset: 0x002829C8
		[DebuggerNonUserCode]
		public static MessageParser<Identity> Parser
		{
			get
			{
				return Identity._parser;
			}
		}

		// Token: 0x17003322 RID: 13090
		// (get) Token: 0x0600A581 RID: 42369 RVA: 0x002847E0 File Offset: 0x002829E0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003323 RID: 13091
		// (get) Token: 0x0600A582 RID: 42370 RVA: 0x00284804 File Offset: 0x00282A04
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Identity.Descriptor;
			}
		}

		// Token: 0x0600A583 RID: 42371 RVA: 0x0028481B File Offset: 0x00282A1B
		[DebuggerNonUserCode]
		public Identity()
		{
		}

		// Token: 0x0600A584 RID: 42372 RVA: 0x00284828 File Offset: 0x00282A28
		[DebuggerNonUserCode]
		public Identity(Identity other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.account_ = other.account_;
			this.gameAccount_ = ((other.gameAccount_ != null) ? other.gameAccount_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A585 RID: 42373 RVA: 0x00284884 File Offset: 0x00282A84
		[DebuggerNonUserCode]
		public Identity Clone()
		{
			return new Identity(this);
		}

		// Token: 0x17003324 RID: 13092
		// (get) Token: 0x0600A586 RID: 42374 RVA: 0x0028489C File Offset: 0x00282A9C
		// (set) Token: 0x0600A587 RID: 42375 RVA: 0x002848CD File Offset: 0x00282ACD
		[DebuggerNonUserCode]
		public ulong Account
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong accountDefaultValue;
				if (flag)
				{
					accountDefaultValue = this.account_;
				}
				else
				{
					accountDefaultValue = Identity.AccountDefaultValue;
				}
				return accountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.account_ = value;
			}
		}

		// Token: 0x17003325 RID: 13093
		// (get) Token: 0x0600A588 RID: 42376 RVA: 0x002848E8 File Offset: 0x00282AE8
		[DebuggerNonUserCode]
		public bool HasAccount
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A589 RID: 42377 RVA: 0x00284905 File Offset: 0x00282B05
		[DebuggerNonUserCode]
		public void ClearAccount()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003326 RID: 13094
		// (get) Token: 0x0600A58A RID: 42378 RVA: 0x00284918 File Offset: 0x00282B18
		// (set) Token: 0x0600A58B RID: 42379 RVA: 0x00284930 File Offset: 0x00282B30
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

		// Token: 0x0600A58C RID: 42380 RVA: 0x0028493C File Offset: 0x00282B3C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Identity);
		}

		// Token: 0x0600A58D RID: 42381 RVA: 0x0028495C File Offset: 0x00282B5C
		[DebuggerNonUserCode]
		public bool Equals(Identity other)
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
					bool flag4 = this.Account != other.Account;
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

		// Token: 0x0600A58E RID: 42382 RVA: 0x002849D0 File Offset: 0x00282BD0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAccount = this.HasAccount;
			if (hasAccount)
			{
				num ^= this.Account.GetHashCode();
			}
			bool flag = this.gameAccount_ != null;
			if (flag)
			{
				num ^= this.GameAccount.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A58F RID: 42383 RVA: 0x00284A3C File Offset: 0x00282C3C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A590 RID: 42384 RVA: 0x00284A54 File Offset: 0x00282C54
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A591 RID: 42385 RVA: 0x00284A60 File Offset: 0x00282C60
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAccount = this.HasAccount;
			if (hasAccount)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.Account);
			}
			bool flag = this.gameAccount_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.GameAccount);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A592 RID: 42386 RVA: 0x00284AD0 File Offset: 0x00282CD0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAccount = this.HasAccount;
			if (hasAccount)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Account);
			}
			bool flag = this.gameAccount_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccount);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A593 RID: 42387 RVA: 0x00284B40 File Offset: 0x00282D40
		[DebuggerNonUserCode]
		public void MergeFrom(Identity other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAccount = other.HasAccount;
				if (hasAccount)
				{
					this.Account = other.Account;
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
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A594 RID: 42388 RVA: 0x00284BC5 File Offset: 0x00282DC5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A595 RID: 42389 RVA: 0x00284BD0 File Offset: 0x00282DD0
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
					this.Account = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04004A72 RID: 19058
		private static readonly MessageParser<Identity> _parser = new MessageParser<Identity>(() => new Identity());

		// Token: 0x04004A73 RID: 19059
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A74 RID: 19060
		private int _hasBits0;

		// Token: 0x04004A75 RID: 19061
		public const int AccountFieldNumber = 1;

		// Token: 0x04004A76 RID: 19062
		private static readonly ulong AccountDefaultValue = 0UL;

		// Token: 0x04004A77 RID: 19063
		private ulong account_;

		// Token: 0x04004A78 RID: 19064
		public const int GameAccountFieldNumber = 2;

		// Token: 0x04004A79 RID: 19065
		private GameAccountHandle gameAccount_;
	}
}
