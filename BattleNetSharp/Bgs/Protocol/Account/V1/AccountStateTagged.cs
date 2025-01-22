using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x0200074D RID: 1869
	public sealed class AccountStateTagged : IMessage<AccountStateTagged>, IMessage, IEquatable<AccountStateTagged>, IDeepCloneable<AccountStateTagged>, IBufferMessage
	{
		// Token: 0x17003533 RID: 13619
		// (get) Token: 0x0600AC17 RID: 44055 RVA: 0x0029E8EC File Offset: 0x0029CAEC
		[DebuggerNonUserCode]
		public static MessageParser<AccountStateTagged> Parser
		{
			get
			{
				return AccountStateTagged._parser;
			}
		}

		// Token: 0x17003534 RID: 13620
		// (get) Token: 0x0600AC18 RID: 44056 RVA: 0x0029E904 File Offset: 0x0029CB04
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[29];
			}
		}

		// Token: 0x17003535 RID: 13621
		// (get) Token: 0x0600AC19 RID: 44057 RVA: 0x0029E928 File Offset: 0x0029CB28
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccountStateTagged.Descriptor;
			}
		}

		// Token: 0x0600AC1A RID: 44058 RVA: 0x0029E93F File Offset: 0x0029CB3F
		[DebuggerNonUserCode]
		public AccountStateTagged()
		{
		}

		// Token: 0x0600AC1B RID: 44059 RVA: 0x0029E94C File Offset: 0x0029CB4C
		[DebuggerNonUserCode]
		public AccountStateTagged(AccountStateTagged other)
			: this()
		{
			this.accountState_ = ((other.accountState_ != null) ? other.accountState_.Clone() : null);
			this.accountTags_ = ((other.accountTags_ != null) ? other.accountTags_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AC1C RID: 44060 RVA: 0x0029E9AC File Offset: 0x0029CBAC
		[DebuggerNonUserCode]
		public AccountStateTagged Clone()
		{
			return new AccountStateTagged(this);
		}

		// Token: 0x17003536 RID: 13622
		// (get) Token: 0x0600AC1D RID: 44061 RVA: 0x0029E9C4 File Offset: 0x0029CBC4
		// (set) Token: 0x0600AC1E RID: 44062 RVA: 0x0029E9DC File Offset: 0x0029CBDC
		[DebuggerNonUserCode]
		public AccountState AccountState
		{
			get
			{
				return this.accountState_;
			}
			set
			{
				this.accountState_ = value;
			}
		}

		// Token: 0x17003537 RID: 13623
		// (get) Token: 0x0600AC1F RID: 44063 RVA: 0x0029E9E8 File Offset: 0x0029CBE8
		// (set) Token: 0x0600AC20 RID: 44064 RVA: 0x0029EA00 File Offset: 0x0029CC00
		[DebuggerNonUserCode]
		public AccountFieldTags AccountTags
		{
			get
			{
				return this.accountTags_;
			}
			set
			{
				this.accountTags_ = value;
			}
		}

		// Token: 0x0600AC21 RID: 44065 RVA: 0x0029EA0C File Offset: 0x0029CC0C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AccountStateTagged);
		}

		// Token: 0x0600AC22 RID: 44066 RVA: 0x0029EA2C File Offset: 0x0029CC2C
		[DebuggerNonUserCode]
		public bool Equals(AccountStateTagged other)
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
					bool flag4 = !object.Equals(this.AccountState, other.AccountState);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.AccountTags, other.AccountTags);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600AC23 RID: 44067 RVA: 0x0029EAA4 File Offset: 0x0029CCA4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.accountState_ != null;
			if (flag)
			{
				num ^= this.AccountState.GetHashCode();
			}
			bool flag2 = this.accountTags_ != null;
			if (flag2)
			{
				num ^= this.AccountTags.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AC24 RID: 44068 RVA: 0x0029EB10 File Offset: 0x0029CD10
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AC25 RID: 44069 RVA: 0x0029EB28 File Offset: 0x0029CD28
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AC26 RID: 44070 RVA: 0x0029EB34 File Offset: 0x0029CD34
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.accountState_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AccountState);
			}
			bool flag2 = this.accountTags_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.AccountTags);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AC27 RID: 44071 RVA: 0x0029EBA8 File Offset: 0x0029CDA8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.accountState_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountState);
			}
			bool flag2 = this.accountTags_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountTags);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AC28 RID: 44072 RVA: 0x0029EC1C File Offset: 0x0029CE1C
		[DebuggerNonUserCode]
		public void MergeFrom(AccountStateTagged other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.accountState_ != null;
				if (flag2)
				{
					bool flag3 = this.accountState_ == null;
					if (flag3)
					{
						this.AccountState = new AccountState();
					}
					this.AccountState.MergeFrom(other.AccountState);
				}
				bool flag4 = other.accountTags_ != null;
				if (flag4)
				{
					bool flag5 = this.accountTags_ == null;
					if (flag5)
					{
						this.AccountTags = new AccountFieldTags();
					}
					this.AccountTags.MergeFrom(other.AccountTags);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600AC29 RID: 44073 RVA: 0x0029ECC9 File Offset: 0x0029CEC9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AC2A RID: 44074 RVA: 0x0029ECD4 File Offset: 0x0029CED4
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
						bool flag = this.accountTags_ == null;
						if (flag)
						{
							this.AccountTags = new AccountFieldTags();
						}
						input.ReadMessage(this.AccountTags);
					}
				}
				else
				{
					bool flag2 = this.accountState_ == null;
					if (flag2)
					{
						this.AccountState = new AccountState();
					}
					input.ReadMessage(this.AccountState);
				}
			}
		}

		// Token: 0x04004D8D RID: 19853
		private static readonly MessageParser<AccountStateTagged> _parser = new MessageParser<AccountStateTagged>(() => new AccountStateTagged());

		// Token: 0x04004D8E RID: 19854
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D8F RID: 19855
		public const int AccountStateFieldNumber = 1;

		// Token: 0x04004D90 RID: 19856
		private AccountState accountState_;

		// Token: 0x04004D91 RID: 19857
		public const int AccountTagsFieldNumber = 2;

		// Token: 0x04004D92 RID: 19858
		private AccountFieldTags accountTags_;
	}
}
