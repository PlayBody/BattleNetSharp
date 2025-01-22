using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000727 RID: 1831
	public sealed class AccountStateNotification : IMessage<AccountStateNotification>, IMessage, IEquatable<AccountStateNotification>, IDeepCloneable<AccountStateNotification>, IBufferMessage
	{
		// Token: 0x170033BC RID: 13244
		// (get) Token: 0x0600A7C4 RID: 42948 RVA: 0x0028CB5C File Offset: 0x0028AD5C
		[DebuggerNonUserCode]
		public static MessageParser<AccountStateNotification> Parser
		{
			get
			{
				return AccountStateNotification._parser;
			}
		}

		// Token: 0x170033BD RID: 13245
		// (get) Token: 0x0600A7C5 RID: 42949 RVA: 0x0028CB74 File Offset: 0x0028AD74
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[23];
			}
		}

		// Token: 0x170033BE RID: 13246
		// (get) Token: 0x0600A7C6 RID: 42950 RVA: 0x0028CB98 File Offset: 0x0028AD98
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccountStateNotification.Descriptor;
			}
		}

		// Token: 0x0600A7C7 RID: 42951 RVA: 0x0028CBAF File Offset: 0x0028ADAF
		[DebuggerNonUserCode]
		public AccountStateNotification()
		{
		}

		// Token: 0x0600A7C8 RID: 42952 RVA: 0x0028CBBC File Offset: 0x0028ADBC
		[DebuggerNonUserCode]
		public AccountStateNotification(AccountStateNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.accountState_ = ((other.accountState_ != null) ? other.accountState_.Clone() : null);
			this.subscriberId_ = other.subscriberId_;
			this.accountTags_ = ((other.accountTags_ != null) ? other.accountTags_.Clone() : null);
			this.subscriptionCompleted_ = other.subscriptionCompleted_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A7C9 RID: 42953 RVA: 0x0028CC40 File Offset: 0x0028AE40
		[DebuggerNonUserCode]
		public AccountStateNotification Clone()
		{
			return new AccountStateNotification(this);
		}

		// Token: 0x170033BF RID: 13247
		// (get) Token: 0x0600A7CA RID: 42954 RVA: 0x0028CC58 File Offset: 0x0028AE58
		// (set) Token: 0x0600A7CB RID: 42955 RVA: 0x0028CC70 File Offset: 0x0028AE70
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

		// Token: 0x170033C0 RID: 13248
		// (get) Token: 0x0600A7CC RID: 42956 RVA: 0x0028CC7C File Offset: 0x0028AE7C
		// (set) Token: 0x0600A7CD RID: 42957 RVA: 0x0028CCAD File Offset: 0x0028AEAD
		[Obsolete]
		[DebuggerNonUserCode]
		public ulong SubscriberId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong subscriberIdDefaultValue;
				if (flag)
				{
					subscriberIdDefaultValue = this.subscriberId_;
				}
				else
				{
					subscriberIdDefaultValue = AccountStateNotification.SubscriberIdDefaultValue;
				}
				return subscriberIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.subscriberId_ = value;
			}
		}

		// Token: 0x170033C1 RID: 13249
		// (get) Token: 0x0600A7CE RID: 42958 RVA: 0x0028CCC8 File Offset: 0x0028AEC8
		[Obsolete]
		[DebuggerNonUserCode]
		public bool HasSubscriberId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A7CF RID: 42959 RVA: 0x0028CCE5 File Offset: 0x0028AEE5
		[Obsolete]
		[DebuggerNonUserCode]
		public void ClearSubscriberId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170033C2 RID: 13250
		// (get) Token: 0x0600A7D0 RID: 42960 RVA: 0x0028CCF8 File Offset: 0x0028AEF8
		// (set) Token: 0x0600A7D1 RID: 42961 RVA: 0x0028CD10 File Offset: 0x0028AF10
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

		// Token: 0x170033C3 RID: 13251
		// (get) Token: 0x0600A7D2 RID: 42962 RVA: 0x0028CD1C File Offset: 0x0028AF1C
		// (set) Token: 0x0600A7D3 RID: 42963 RVA: 0x0028CD4D File Offset: 0x0028AF4D
		[DebuggerNonUserCode]
		public bool SubscriptionCompleted
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool subscriptionCompletedDefaultValue;
				if (flag)
				{
					subscriptionCompletedDefaultValue = this.subscriptionCompleted_;
				}
				else
				{
					subscriptionCompletedDefaultValue = AccountStateNotification.SubscriptionCompletedDefaultValue;
				}
				return subscriptionCompletedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.subscriptionCompleted_ = value;
			}
		}

		// Token: 0x170033C4 RID: 13252
		// (get) Token: 0x0600A7D4 RID: 42964 RVA: 0x0028CD68 File Offset: 0x0028AF68
		[DebuggerNonUserCode]
		public bool HasSubscriptionCompleted
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600A7D5 RID: 42965 RVA: 0x0028CD85 File Offset: 0x0028AF85
		[DebuggerNonUserCode]
		public void ClearSubscriptionCompleted()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600A7D6 RID: 42966 RVA: 0x0028CD98 File Offset: 0x0028AF98
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AccountStateNotification);
		}

		// Token: 0x0600A7D7 RID: 42967 RVA: 0x0028CDB8 File Offset: 0x0028AFB8
		[DebuggerNonUserCode]
		public bool Equals(AccountStateNotification other)
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
						bool flag5 = this.SubscriberId != other.SubscriberId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.AccountTags, other.AccountTags);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.SubscriptionCompleted != other.SubscriptionCompleted;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A7D8 RID: 42968 RVA: 0x0028CE6C File Offset: 0x0028B06C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.accountState_ != null;
			if (flag)
			{
				num ^= this.AccountState.GetHashCode();
			}
			bool hasSubscriberId = this.HasSubscriberId;
			if (hasSubscriberId)
			{
				num ^= this.SubscriberId.GetHashCode();
			}
			bool flag2 = this.accountTags_ != null;
			if (flag2)
			{
				num ^= this.AccountTags.GetHashCode();
			}
			bool hasSubscriptionCompleted = this.HasSubscriptionCompleted;
			if (hasSubscriptionCompleted)
			{
				num ^= this.SubscriptionCompleted.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A7D9 RID: 42969 RVA: 0x0028CF14 File Offset: 0x0028B114
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A7DA RID: 42970 RVA: 0x0028CF2C File Offset: 0x0028B12C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A7DB RID: 42971 RVA: 0x0028CF38 File Offset: 0x0028B138
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.accountState_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AccountState);
			}
			bool hasSubscriberId = this.HasSubscriberId;
			if (hasSubscriberId)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.SubscriberId);
			}
			bool flag2 = this.accountTags_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.AccountTags);
			}
			bool hasSubscriptionCompleted = this.HasSubscriptionCompleted;
			if (hasSubscriptionCompleted)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.SubscriptionCompleted);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A7DC RID: 42972 RVA: 0x0028CFF4 File Offset: 0x0028B1F4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.accountState_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountState);
			}
			bool hasSubscriberId = this.HasSubscriberId;
			if (hasSubscriberId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.SubscriberId);
			}
			bool flag2 = this.accountTags_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountTags);
			}
			bool hasSubscriptionCompleted = this.HasSubscriptionCompleted;
			if (hasSubscriptionCompleted)
			{
				num += 2;
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A7DD RID: 42973 RVA: 0x0028D098 File Offset: 0x0028B298
		[DebuggerNonUserCode]
		public void MergeFrom(AccountStateNotification other)
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
				bool hasSubscriberId = other.HasSubscriberId;
				if (hasSubscriberId)
				{
					this.SubscriberId = other.SubscriberId;
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
				bool hasSubscriptionCompleted = other.HasSubscriptionCompleted;
				if (hasSubscriptionCompleted)
				{
					this.SubscriptionCompleted = other.SubscriptionCompleted;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A7DE RID: 42974 RVA: 0x0028D17B File Offset: 0x0028B37B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A7DF RID: 42975 RVA: 0x0028D188 File Offset: 0x0028B388
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 16U)
				{
					if (num3 != 10U)
					{
						if (num3 != 16U)
						{
							goto IL_002C;
						}
						this.SubscriberId = input.ReadUInt64();
					}
					else
					{
						bool flag = this.accountState_ == null;
						if (flag)
						{
							this.AccountState = new AccountState();
						}
						input.ReadMessage(this.AccountState);
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 32U)
					{
						goto IL_002C;
					}
					this.SubscriptionCompleted = input.ReadBool();
				}
				else
				{
					bool flag2 = this.accountTags_ == null;
					if (flag2)
					{
						this.AccountTags = new AccountFieldTags();
					}
					input.ReadMessage(this.AccountTags);
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004B39 RID: 19257
		private static readonly MessageParser<AccountStateNotification> _parser = new MessageParser<AccountStateNotification>(() => new AccountStateNotification());

		// Token: 0x04004B3A RID: 19258
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B3B RID: 19259
		private int _hasBits0;

		// Token: 0x04004B3C RID: 19260
		public const int AccountStateFieldNumber = 1;

		// Token: 0x04004B3D RID: 19261
		private AccountState accountState_;

		// Token: 0x04004B3E RID: 19262
		public const int SubscriberIdFieldNumber = 2;

		// Token: 0x04004B3F RID: 19263
		private static readonly ulong SubscriberIdDefaultValue = 0UL;

		// Token: 0x04004B40 RID: 19264
		private ulong subscriberId_;

		// Token: 0x04004B41 RID: 19265
		public const int AccountTagsFieldNumber = 3;

		// Token: 0x04004B42 RID: 19266
		private AccountFieldTags accountTags_;

		// Token: 0x04004B43 RID: 19267
		public const int SubscriptionCompletedFieldNumber = 4;

		// Token: 0x04004B44 RID: 19268
		private static readonly bool SubscriptionCompletedDefaultValue = false;

		// Token: 0x04004B45 RID: 19269
		private bool subscriptionCompleted_;
	}
}
