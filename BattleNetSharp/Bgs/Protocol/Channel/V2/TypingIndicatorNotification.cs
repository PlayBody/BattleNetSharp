using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x0200067E RID: 1662
	public sealed class TypingIndicatorNotification : IMessage<TypingIndicatorNotification>, IMessage, IEquatable<TypingIndicatorNotification>, IDeepCloneable<TypingIndicatorNotification>, IBufferMessage
	{
		// Token: 0x17002FFD RID: 12285
		// (get) Token: 0x06009A49 RID: 39497 RVA: 0x002563A8 File Offset: 0x002545A8
		[DebuggerNonUserCode]
		public static MessageParser<TypingIndicatorNotification> Parser
		{
			get
			{
				return TypingIndicatorNotification._parser;
			}
		}

		// Token: 0x17002FFE RID: 12286
		// (get) Token: 0x06009A4A RID: 39498 RVA: 0x002563C0 File Offset: 0x002545C0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[34];
			}
		}

		// Token: 0x17002FFF RID: 12287
		// (get) Token: 0x06009A4B RID: 39499 RVA: 0x002563E4 File Offset: 0x002545E4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TypingIndicatorNotification.Descriptor;
			}
		}

		// Token: 0x06009A4C RID: 39500 RVA: 0x002563FB File Offset: 0x002545FB
		[DebuggerNonUserCode]
		public TypingIndicatorNotification()
		{
		}

		// Token: 0x06009A4D RID: 39501 RVA: 0x00256408 File Offset: 0x00254608
		[DebuggerNonUserCode]
		public TypingIndicatorNotification(TypingIndicatorNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.subscriberId_ = ((other.subscriberId_ != null) ? other.subscriberId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.authorId_ = ((other.authorId_ != null) ? other.authorId_.Clone() : null);
			this.epoch_ = other.epoch_;
			this.action_ = other.action_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009A4E RID: 39502 RVA: 0x002564C4 File Offset: 0x002546C4
		[DebuggerNonUserCode]
		public TypingIndicatorNotification Clone()
		{
			return new TypingIndicatorNotification(this);
		}

		// Token: 0x17003000 RID: 12288
		// (get) Token: 0x06009A4F RID: 39503 RVA: 0x002564DC File Offset: 0x002546DC
		// (set) Token: 0x06009A50 RID: 39504 RVA: 0x002564F4 File Offset: 0x002546F4
		[DebuggerNonUserCode]
		public GameAccountHandle AgentId
		{
			get
			{
				return this.agentId_;
			}
			set
			{
				this.agentId_ = value;
			}
		}

		// Token: 0x17003001 RID: 12289
		// (get) Token: 0x06009A51 RID: 39505 RVA: 0x00256500 File Offset: 0x00254700
		// (set) Token: 0x06009A52 RID: 39506 RVA: 0x00256518 File Offset: 0x00254718
		[DebuggerNonUserCode]
		public GameAccountHandle SubscriberId
		{
			get
			{
				return this.subscriberId_;
			}
			set
			{
				this.subscriberId_ = value;
			}
		}

		// Token: 0x17003002 RID: 12290
		// (get) Token: 0x06009A53 RID: 39507 RVA: 0x00256524 File Offset: 0x00254724
		// (set) Token: 0x06009A54 RID: 39508 RVA: 0x0025653C File Offset: 0x0025473C
		[DebuggerNonUserCode]
		public ChannelId ChannelId
		{
			get
			{
				return this.channelId_;
			}
			set
			{
				this.channelId_ = value;
			}
		}

		// Token: 0x17003003 RID: 12291
		// (get) Token: 0x06009A55 RID: 39509 RVA: 0x00256548 File Offset: 0x00254748
		// (set) Token: 0x06009A56 RID: 39510 RVA: 0x00256560 File Offset: 0x00254760
		[DebuggerNonUserCode]
		public GameAccountHandle AuthorId
		{
			get
			{
				return this.authorId_;
			}
			set
			{
				this.authorId_ = value;
			}
		}

		// Token: 0x17003004 RID: 12292
		// (get) Token: 0x06009A57 RID: 39511 RVA: 0x0025656C File Offset: 0x0025476C
		// (set) Token: 0x06009A58 RID: 39512 RVA: 0x0025659D File Offset: 0x0025479D
		[DebuggerNonUserCode]
		public ulong Epoch
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong epochDefaultValue;
				if (flag)
				{
					epochDefaultValue = this.epoch_;
				}
				else
				{
					epochDefaultValue = TypingIndicatorNotification.EpochDefaultValue;
				}
				return epochDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.epoch_ = value;
			}
		}

		// Token: 0x17003005 RID: 12293
		// (get) Token: 0x06009A59 RID: 39513 RVA: 0x002565B8 File Offset: 0x002547B8
		[DebuggerNonUserCode]
		public bool HasEpoch
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009A5A RID: 39514 RVA: 0x002565D5 File Offset: 0x002547D5
		[DebuggerNonUserCode]
		public void ClearEpoch()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003006 RID: 12294
		// (get) Token: 0x06009A5B RID: 39515 RVA: 0x002565E8 File Offset: 0x002547E8
		// (set) Token: 0x06009A5C RID: 39516 RVA: 0x00256619 File Offset: 0x00254819
		[DebuggerNonUserCode]
		public TypingIndicator Action
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				TypingIndicator actionDefaultValue;
				if (flag)
				{
					actionDefaultValue = this.action_;
				}
				else
				{
					actionDefaultValue = TypingIndicatorNotification.ActionDefaultValue;
				}
				return actionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.action_ = value;
			}
		}

		// Token: 0x17003007 RID: 12295
		// (get) Token: 0x06009A5D RID: 39517 RVA: 0x00256634 File Offset: 0x00254834
		[DebuggerNonUserCode]
		public bool HasAction
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06009A5E RID: 39518 RVA: 0x00256651 File Offset: 0x00254851
		[DebuggerNonUserCode]
		public void ClearAction()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06009A5F RID: 39519 RVA: 0x00256664 File Offset: 0x00254864
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as TypingIndicatorNotification);
		}

		// Token: 0x06009A60 RID: 39520 RVA: 0x00256684 File Offset: 0x00254884
		[DebuggerNonUserCode]
		public bool Equals(TypingIndicatorNotification other)
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
					bool flag4 = !object.Equals(this.AgentId, other.AgentId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.SubscriberId, other.SubscriberId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.ChannelId, other.ChannelId);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.AuthorId, other.AuthorId);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Epoch != other.Epoch;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.Action != other.Action;
										flag2 = !flag9 && object.Equals(this._unknownFields, other._unknownFields);
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009A61 RID: 39521 RVA: 0x0025677C File Offset: 0x0025497C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.subscriberId_ != null;
			if (flag2)
			{
				num ^= this.SubscriberId.GetHashCode();
			}
			bool flag3 = this.channelId_ != null;
			if (flag3)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			bool flag4 = this.authorId_ != null;
			if (flag4)
			{
				num ^= this.AuthorId.GetHashCode();
			}
			bool hasEpoch = this.HasEpoch;
			if (hasEpoch)
			{
				num ^= this.Epoch.GetHashCode();
			}
			bool hasAction = this.HasAction;
			if (hasAction)
			{
				num ^= this.Action.GetHashCode();
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009A62 RID: 39522 RVA: 0x00256864 File Offset: 0x00254A64
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009A63 RID: 39523 RVA: 0x0025687C File Offset: 0x00254A7C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009A64 RID: 39524 RVA: 0x00256888 File Offset: 0x00254A88
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.subscriberId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.SubscriberId);
			}
			bool flag3 = this.channelId_ != null;
			if (flag3)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.ChannelId);
			}
			bool flag4 = this.authorId_ != null;
			if (flag4)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.AuthorId);
			}
			bool hasEpoch = this.HasEpoch;
			if (hasEpoch)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.Epoch);
			}
			bool hasAction = this.HasAction;
			if (hasAction)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Action);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009A65 RID: 39525 RVA: 0x00256990 File Offset: 0x00254B90
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.subscriberId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SubscriberId);
			}
			bool flag3 = this.channelId_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
			}
			bool flag4 = this.authorId_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AuthorId);
			}
			bool hasEpoch = this.HasEpoch;
			if (hasEpoch)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Epoch);
			}
			bool hasAction = this.HasAction;
			if (hasAction)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Action);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009A66 RID: 39526 RVA: 0x00256A80 File Offset: 0x00254C80
		[DebuggerNonUserCode]
		public void MergeFrom(TypingIndicatorNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.agentId_ != null;
				if (flag2)
				{
					bool flag3 = this.agentId_ == null;
					if (flag3)
					{
						this.AgentId = new GameAccountHandle();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool flag4 = other.subscriberId_ != null;
				if (flag4)
				{
					bool flag5 = this.subscriberId_ == null;
					if (flag5)
					{
						this.SubscriberId = new GameAccountHandle();
					}
					this.SubscriberId.MergeFrom(other.SubscriberId);
				}
				bool flag6 = other.channelId_ != null;
				if (flag6)
				{
					bool flag7 = this.channelId_ == null;
					if (flag7)
					{
						this.ChannelId = new ChannelId();
					}
					this.ChannelId.MergeFrom(other.ChannelId);
				}
				bool flag8 = other.authorId_ != null;
				if (flag8)
				{
					bool flag9 = this.authorId_ == null;
					if (flag9)
					{
						this.AuthorId = new GameAccountHandle();
					}
					this.AuthorId.MergeFrom(other.AuthorId);
				}
				bool hasEpoch = other.HasEpoch;
				if (hasEpoch)
				{
					this.Epoch = other.Epoch;
				}
				bool hasAction = other.HasAction;
				if (hasAction)
				{
					this.Action = other.Action;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009A67 RID: 39527 RVA: 0x00256BE3 File Offset: 0x00254DE3
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009A68 RID: 39528 RVA: 0x00256BF0 File Offset: 0x00254DF0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 26U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							if (num3 != 26U)
							{
								goto IL_0046;
							}
							bool flag = this.channelId_ == null;
							if (flag)
							{
								this.ChannelId = new ChannelId();
							}
							input.ReadMessage(this.ChannelId);
						}
						else
						{
							bool flag2 = this.subscriberId_ == null;
							if (flag2)
							{
								this.SubscriberId = new GameAccountHandle();
							}
							input.ReadMessage(this.SubscriberId);
						}
					}
					else
					{
						bool flag3 = this.agentId_ == null;
						if (flag3)
						{
							this.AgentId = new GameAccountHandle();
						}
						input.ReadMessage(this.AgentId);
					}
				}
				else if (num3 != 34U)
				{
					if (num3 != 40U)
					{
						if (num3 != 48U)
						{
							goto IL_0046;
						}
						this.Action = (TypingIndicator)input.ReadEnum();
					}
					else
					{
						this.Epoch = input.ReadUInt64();
					}
				}
				else
				{
					bool flag4 = this.authorId_ == null;
					if (flag4)
					{
						this.AuthorId = new GameAccountHandle();
					}
					input.ReadMessage(this.AuthorId);
				}
				continue;
				IL_0046:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400455B RID: 17755
		private static readonly MessageParser<TypingIndicatorNotification> _parser = new MessageParser<TypingIndicatorNotification>(() => new TypingIndicatorNotification());

		// Token: 0x0400455C RID: 17756
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400455D RID: 17757
		private int _hasBits0;

		// Token: 0x0400455E RID: 17758
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400455F RID: 17759
		private GameAccountHandle agentId_;

		// Token: 0x04004560 RID: 17760
		public const int SubscriberIdFieldNumber = 2;

		// Token: 0x04004561 RID: 17761
		private GameAccountHandle subscriberId_;

		// Token: 0x04004562 RID: 17762
		public const int ChannelIdFieldNumber = 3;

		// Token: 0x04004563 RID: 17763
		private ChannelId channelId_;

		// Token: 0x04004564 RID: 17764
		public const int AuthorIdFieldNumber = 4;

		// Token: 0x04004565 RID: 17765
		private GameAccountHandle authorId_;

		// Token: 0x04004566 RID: 17766
		public const int EpochFieldNumber = 5;

		// Token: 0x04004567 RID: 17767
		private static readonly ulong EpochDefaultValue = 0UL;

		// Token: 0x04004568 RID: 17768
		private ulong epoch_;

		// Token: 0x04004569 RID: 17769
		public const int ActionFieldNumber = 6;

		// Token: 0x0400456A RID: 17770
		private static readonly TypingIndicator ActionDefaultValue = TypingIndicator.TypingStart;

		// Token: 0x0400456B RID: 17771
		private TypingIndicator action_;
	}
}
