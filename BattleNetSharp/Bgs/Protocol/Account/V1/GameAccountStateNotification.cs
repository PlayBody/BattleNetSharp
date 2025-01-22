using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000728 RID: 1832
	public sealed class GameAccountStateNotification : IMessage<GameAccountStateNotification>, IMessage, IEquatable<GameAccountStateNotification>, IDeepCloneable<GameAccountStateNotification>, IBufferMessage
	{
		// Token: 0x170033C5 RID: 13253
		// (get) Token: 0x0600A7E1 RID: 42977 RVA: 0x0028D28C File Offset: 0x0028B48C
		[DebuggerNonUserCode]
		public static MessageParser<GameAccountStateNotification> Parser
		{
			get
			{
				return GameAccountStateNotification._parser;
			}
		}

		// Token: 0x170033C6 RID: 13254
		// (get) Token: 0x0600A7E2 RID: 42978 RVA: 0x0028D2A4 File Offset: 0x0028B4A4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[24];
			}
		}

		// Token: 0x170033C7 RID: 13255
		// (get) Token: 0x0600A7E3 RID: 42979 RVA: 0x0028D2C8 File Offset: 0x0028B4C8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameAccountStateNotification.Descriptor;
			}
		}

		// Token: 0x0600A7E4 RID: 42980 RVA: 0x0028D2DF File Offset: 0x0028B4DF
		[DebuggerNonUserCode]
		public GameAccountStateNotification()
		{
		}

		// Token: 0x0600A7E5 RID: 42981 RVA: 0x0028D2EC File Offset: 0x0028B4EC
		[DebuggerNonUserCode]
		public GameAccountStateNotification(GameAccountStateNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameAccountState_ = ((other.gameAccountState_ != null) ? other.gameAccountState_.Clone() : null);
			this.subscriberId_ = other.subscriberId_;
			this.gameAccountTags_ = ((other.gameAccountTags_ != null) ? other.gameAccountTags_.Clone() : null);
			this.subscriptionCompleted_ = other.subscriptionCompleted_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A7E6 RID: 42982 RVA: 0x0028D370 File Offset: 0x0028B570
		[DebuggerNonUserCode]
		public GameAccountStateNotification Clone()
		{
			return new GameAccountStateNotification(this);
		}

		// Token: 0x170033C8 RID: 13256
		// (get) Token: 0x0600A7E7 RID: 42983 RVA: 0x0028D388 File Offset: 0x0028B588
		// (set) Token: 0x0600A7E8 RID: 42984 RVA: 0x0028D3A0 File Offset: 0x0028B5A0
		[DebuggerNonUserCode]
		public GameAccountState GameAccountState
		{
			get
			{
				return this.gameAccountState_;
			}
			set
			{
				this.gameAccountState_ = value;
			}
		}

		// Token: 0x170033C9 RID: 13257
		// (get) Token: 0x0600A7E9 RID: 42985 RVA: 0x0028D3AC File Offset: 0x0028B5AC
		// (set) Token: 0x0600A7EA RID: 42986 RVA: 0x0028D3DD File Offset: 0x0028B5DD
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
					subscriberIdDefaultValue = GameAccountStateNotification.SubscriberIdDefaultValue;
				}
				return subscriberIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.subscriberId_ = value;
			}
		}

		// Token: 0x170033CA RID: 13258
		// (get) Token: 0x0600A7EB RID: 42987 RVA: 0x0028D3F8 File Offset: 0x0028B5F8
		[Obsolete]
		[DebuggerNonUserCode]
		public bool HasSubscriberId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A7EC RID: 42988 RVA: 0x0028D415 File Offset: 0x0028B615
		[Obsolete]
		[DebuggerNonUserCode]
		public void ClearSubscriberId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170033CB RID: 13259
		// (get) Token: 0x0600A7ED RID: 42989 RVA: 0x0028D428 File Offset: 0x0028B628
		// (set) Token: 0x0600A7EE RID: 42990 RVA: 0x0028D440 File Offset: 0x0028B640
		[DebuggerNonUserCode]
		public GameAccountFieldTags GameAccountTags
		{
			get
			{
				return this.gameAccountTags_;
			}
			set
			{
				this.gameAccountTags_ = value;
			}
		}

		// Token: 0x170033CC RID: 13260
		// (get) Token: 0x0600A7EF RID: 42991 RVA: 0x0028D44C File Offset: 0x0028B64C
		// (set) Token: 0x0600A7F0 RID: 42992 RVA: 0x0028D47D File Offset: 0x0028B67D
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
					subscriptionCompletedDefaultValue = GameAccountStateNotification.SubscriptionCompletedDefaultValue;
				}
				return subscriptionCompletedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.subscriptionCompleted_ = value;
			}
		}

		// Token: 0x170033CD RID: 13261
		// (get) Token: 0x0600A7F1 RID: 42993 RVA: 0x0028D498 File Offset: 0x0028B698
		[DebuggerNonUserCode]
		public bool HasSubscriptionCompleted
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600A7F2 RID: 42994 RVA: 0x0028D4B5 File Offset: 0x0028B6B5
		[DebuggerNonUserCode]
		public void ClearSubscriptionCompleted()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600A7F3 RID: 42995 RVA: 0x0028D4C8 File Offset: 0x0028B6C8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameAccountStateNotification);
		}

		// Token: 0x0600A7F4 RID: 42996 RVA: 0x0028D4E8 File Offset: 0x0028B6E8
		[DebuggerNonUserCode]
		public bool Equals(GameAccountStateNotification other)
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
					bool flag4 = !object.Equals(this.GameAccountState, other.GameAccountState);
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
							bool flag6 = !object.Equals(this.GameAccountTags, other.GameAccountTags);
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

		// Token: 0x0600A7F5 RID: 42997 RVA: 0x0028D59C File Offset: 0x0028B79C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.gameAccountState_ != null;
			if (flag)
			{
				num ^= this.GameAccountState.GetHashCode();
			}
			bool hasSubscriberId = this.HasSubscriberId;
			if (hasSubscriberId)
			{
				num ^= this.SubscriberId.GetHashCode();
			}
			bool flag2 = this.gameAccountTags_ != null;
			if (flag2)
			{
				num ^= this.GameAccountTags.GetHashCode();
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

		// Token: 0x0600A7F6 RID: 42998 RVA: 0x0028D644 File Offset: 0x0028B844
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A7F7 RID: 42999 RVA: 0x0028D65C File Offset: 0x0028B85C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A7F8 RID: 43000 RVA: 0x0028D668 File Offset: 0x0028B868
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.gameAccountState_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GameAccountState);
			}
			bool hasSubscriberId = this.HasSubscriberId;
			if (hasSubscriberId)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.SubscriberId);
			}
			bool flag2 = this.gameAccountTags_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.GameAccountTags);
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

		// Token: 0x0600A7F9 RID: 43001 RVA: 0x0028D724 File Offset: 0x0028B924
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.gameAccountState_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountState);
			}
			bool hasSubscriberId = this.HasSubscriberId;
			if (hasSubscriberId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.SubscriberId);
			}
			bool flag2 = this.gameAccountTags_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountTags);
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

		// Token: 0x0600A7FA RID: 43002 RVA: 0x0028D7C8 File Offset: 0x0028B9C8
		[DebuggerNonUserCode]
		public void MergeFrom(GameAccountStateNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.gameAccountState_ != null;
				if (flag2)
				{
					bool flag3 = this.gameAccountState_ == null;
					if (flag3)
					{
						this.GameAccountState = new GameAccountState();
					}
					this.GameAccountState.MergeFrom(other.GameAccountState);
				}
				bool hasSubscriberId = other.HasSubscriberId;
				if (hasSubscriberId)
				{
					this.SubscriberId = other.SubscriberId;
				}
				bool flag4 = other.gameAccountTags_ != null;
				if (flag4)
				{
					bool flag5 = this.gameAccountTags_ == null;
					if (flag5)
					{
						this.GameAccountTags = new GameAccountFieldTags();
					}
					this.GameAccountTags.MergeFrom(other.GameAccountTags);
				}
				bool hasSubscriptionCompleted = other.HasSubscriptionCompleted;
				if (hasSubscriptionCompleted)
				{
					this.SubscriptionCompleted = other.SubscriptionCompleted;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A7FB RID: 43003 RVA: 0x0028D8AB File Offset: 0x0028BAAB
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A7FC RID: 43004 RVA: 0x0028D8B8 File Offset: 0x0028BAB8
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
						bool flag = this.gameAccountState_ == null;
						if (flag)
						{
							this.GameAccountState = new GameAccountState();
						}
						input.ReadMessage(this.GameAccountState);
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
					bool flag2 = this.gameAccountTags_ == null;
					if (flag2)
					{
						this.GameAccountTags = new GameAccountFieldTags();
					}
					input.ReadMessage(this.GameAccountTags);
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004B46 RID: 19270
		private static readonly MessageParser<GameAccountStateNotification> _parser = new MessageParser<GameAccountStateNotification>(() => new GameAccountStateNotification());

		// Token: 0x04004B47 RID: 19271
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B48 RID: 19272
		private int _hasBits0;

		// Token: 0x04004B49 RID: 19273
		public const int GameAccountStateFieldNumber = 1;

		// Token: 0x04004B4A RID: 19274
		private GameAccountState gameAccountState_;

		// Token: 0x04004B4B RID: 19275
		public const int SubscriberIdFieldNumber = 2;

		// Token: 0x04004B4C RID: 19276
		private static readonly ulong SubscriberIdDefaultValue = 0UL;

		// Token: 0x04004B4D RID: 19277
		private ulong subscriberId_;

		// Token: 0x04004B4E RID: 19278
		public const int GameAccountTagsFieldNumber = 3;

		// Token: 0x04004B4F RID: 19279
		private GameAccountFieldTags gameAccountTags_;

		// Token: 0x04004B50 RID: 19280
		public const int SubscriptionCompletedFieldNumber = 4;

		// Token: 0x04004B51 RID: 19281
		private static readonly bool SubscriptionCompletedDefaultValue = false;

		// Token: 0x04004B52 RID: 19282
		private bool subscriptionCompleted_;
	}
}
