using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000729 RID: 1833
	public sealed class GameAccountNotification : IMessage<GameAccountNotification>, IMessage, IEquatable<GameAccountNotification>, IDeepCloneable<GameAccountNotification>, IBufferMessage
	{
		// Token: 0x170033CE RID: 13262
		// (get) Token: 0x0600A7FE RID: 43006 RVA: 0x0028D9BC File Offset: 0x0028BBBC
		[DebuggerNonUserCode]
		public static MessageParser<GameAccountNotification> Parser
		{
			get
			{
				return GameAccountNotification._parser;
			}
		}

		// Token: 0x170033CF RID: 13263
		// (get) Token: 0x0600A7FF RID: 43007 RVA: 0x0028D9D4 File Offset: 0x0028BBD4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[25];
			}
		}

		// Token: 0x170033D0 RID: 13264
		// (get) Token: 0x0600A800 RID: 43008 RVA: 0x0028D9F8 File Offset: 0x0028BBF8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameAccountNotification.Descriptor;
			}
		}

		// Token: 0x0600A801 RID: 43009 RVA: 0x0028DA0F File Offset: 0x0028BC0F
		[DebuggerNonUserCode]
		public GameAccountNotification()
		{
		}

		// Token: 0x0600A802 RID: 43010 RVA: 0x0028DA24 File Offset: 0x0028BC24
		[DebuggerNonUserCode]
		public GameAccountNotification(GameAccountNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameAccounts_ = other.gameAccounts_.Clone();
			this.subscriberId_ = other.subscriberId_;
			this.accountTags_ = ((other.accountTags_ != null) ? other.accountTags_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A803 RID: 43011 RVA: 0x0028DA90 File Offset: 0x0028BC90
		[DebuggerNonUserCode]
		public GameAccountNotification Clone()
		{
			return new GameAccountNotification(this);
		}

		// Token: 0x170033D1 RID: 13265
		// (get) Token: 0x0600A804 RID: 43012 RVA: 0x0028DAA8 File Offset: 0x0028BCA8
		[DebuggerNonUserCode]
		public RepeatedField<GameAccountList> GameAccounts
		{
			get
			{
				return this.gameAccounts_;
			}
		}

		// Token: 0x170033D2 RID: 13266
		// (get) Token: 0x0600A805 RID: 43013 RVA: 0x0028DAC0 File Offset: 0x0028BCC0
		// (set) Token: 0x0600A806 RID: 43014 RVA: 0x0028DAF1 File Offset: 0x0028BCF1
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
					subscriberIdDefaultValue = GameAccountNotification.SubscriberIdDefaultValue;
				}
				return subscriberIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.subscriberId_ = value;
			}
		}

		// Token: 0x170033D3 RID: 13267
		// (get) Token: 0x0600A807 RID: 43015 RVA: 0x0028DB0C File Offset: 0x0028BD0C
		[DebuggerNonUserCode]
		public bool HasSubscriberId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A808 RID: 43016 RVA: 0x0028DB29 File Offset: 0x0028BD29
		[DebuggerNonUserCode]
		public void ClearSubscriberId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170033D4 RID: 13268
		// (get) Token: 0x0600A809 RID: 43017 RVA: 0x0028DB3C File Offset: 0x0028BD3C
		// (set) Token: 0x0600A80A RID: 43018 RVA: 0x0028DB54 File Offset: 0x0028BD54
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

		// Token: 0x0600A80B RID: 43019 RVA: 0x0028DB60 File Offset: 0x0028BD60
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameAccountNotification);
		}

		// Token: 0x0600A80C RID: 43020 RVA: 0x0028DB80 File Offset: 0x0028BD80
		[DebuggerNonUserCode]
		public bool Equals(GameAccountNotification other)
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
					bool flag4 = !this.gameAccounts_.Equals(other.gameAccounts_);
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
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A80D RID: 43021 RVA: 0x0028DC14 File Offset: 0x0028BE14
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.gameAccounts_.GetHashCode();
			bool hasSubscriberId = this.HasSubscriberId;
			if (hasSubscriberId)
			{
				num ^= this.SubscriberId.GetHashCode();
			}
			bool flag = this.accountTags_ != null;
			if (flag)
			{
				num ^= this.AccountTags.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A80E RID: 43022 RVA: 0x0028DC90 File Offset: 0x0028BE90
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A80F RID: 43023 RVA: 0x0028DCA8 File Offset: 0x0028BEA8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A810 RID: 43024 RVA: 0x0028DCB4 File Offset: 0x0028BEB4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.gameAccounts_.WriteTo(ref output, GameAccountNotification._repeated_gameAccounts_codec);
			bool hasSubscriberId = this.HasSubscriberId;
			if (hasSubscriberId)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.SubscriberId);
			}
			bool flag = this.accountTags_ != null;
			if (flag)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.AccountTags);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A811 RID: 43025 RVA: 0x0028DD38 File Offset: 0x0028BF38
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.gameAccounts_.CalculateSize(GameAccountNotification._repeated_gameAccounts_codec);
			bool hasSubscriberId = this.HasSubscriberId;
			if (hasSubscriberId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.SubscriberId);
			}
			bool flag = this.accountTags_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountTags);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A812 RID: 43026 RVA: 0x0028DDBC File Offset: 0x0028BFBC
		[DebuggerNonUserCode]
		public void MergeFrom(GameAccountNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.gameAccounts_.Add(other.gameAccounts_);
				bool hasSubscriberId = other.HasSubscriberId;
				if (hasSubscriberId)
				{
					this.SubscriberId = other.SubscriberId;
				}
				bool flag2 = other.accountTags_ != null;
				if (flag2)
				{
					bool flag3 = this.accountTags_ == null;
					if (flag3)
					{
						this.AccountTags = new AccountFieldTags();
					}
					this.AccountTags.MergeFrom(other.AccountTags);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A813 RID: 43027 RVA: 0x0028DE53 File Offset: 0x0028C053
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A814 RID: 43028 RVA: 0x0028DE60 File Offset: 0x0028C060
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
					if (num3 != 16U)
					{
						if (num3 != 26U)
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
						this.SubscriberId = input.ReadUInt64();
					}
				}
				else
				{
					this.gameAccounts_.AddEntriesFrom(ref input, GameAccountNotification._repeated_gameAccounts_codec);
				}
			}
		}

		// Token: 0x04004B53 RID: 19283
		private static readonly MessageParser<GameAccountNotification> _parser = new MessageParser<GameAccountNotification>(() => new GameAccountNotification());

		// Token: 0x04004B54 RID: 19284
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B55 RID: 19285
		private int _hasBits0;

		// Token: 0x04004B56 RID: 19286
		public const int GameAccountsFieldNumber = 1;

		// Token: 0x04004B57 RID: 19287
		private static readonly FieldCodec<GameAccountList> _repeated_gameAccounts_codec = FieldCodec.ForMessage<GameAccountList>(10U, GameAccountList.Parser);

		// Token: 0x04004B58 RID: 19288
		private readonly RepeatedField<GameAccountList> gameAccounts_ = new RepeatedField<GameAccountList>();

		// Token: 0x04004B59 RID: 19289
		public const int SubscriberIdFieldNumber = 2;

		// Token: 0x04004B5A RID: 19290
		private static readonly ulong SubscriberIdDefaultValue = 0UL;

		// Token: 0x04004B5B RID: 19291
		private ulong subscriberId_;

		// Token: 0x04004B5C RID: 19292
		public const int AccountTagsFieldNumber = 3;

		// Token: 0x04004B5D RID: 19293
		private AccountFieldTags accountTags_;
	}
}
