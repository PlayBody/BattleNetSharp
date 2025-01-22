using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006E1 RID: 1761
	public sealed class SendMessageNotification : IMessage<SendMessageNotification>, IMessage, IEquatable<SendMessageNotification>, IDeepCloneable<SendMessageNotification>, IBufferMessage
	{
		// Token: 0x17003249 RID: 12873
		// (get) Token: 0x0600A265 RID: 41573 RVA: 0x00278AE8 File Offset: 0x00276CE8
		[DebuggerNonUserCode]
		public static MessageParser<SendMessageNotification> Parser
		{
			get
			{
				return SendMessageNotification._parser;
			}
		}

		// Token: 0x1700324A RID: 12874
		// (get) Token: 0x0600A266 RID: 41574 RVA: 0x00278B00 File Offset: 0x00276D00
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x1700324B RID: 12875
		// (get) Token: 0x0600A267 RID: 41575 RVA: 0x00278B24 File Offset: 0x00276D24
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SendMessageNotification.Descriptor;
			}
		}

		// Token: 0x0600A268 RID: 41576 RVA: 0x00278B3B File Offset: 0x00276D3B
		[DebuggerNonUserCode]
		public SendMessageNotification()
		{
		}

		// Token: 0x0600A269 RID: 41577 RVA: 0x00278B48 File Offset: 0x00276D48
		[DebuggerNonUserCode]
		public SendMessageNotification(SendMessageNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.message_ = ((other.message_ != null) ? other.message_.Clone() : null);
			this.requiredPrivileges_ = other.requiredPrivileges_;
			this.battleTag_ = other.battleTag_;
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.subscriber_ = ((other.subscriber_ != null) ? other.subscriber_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A26A RID: 41578 RVA: 0x00278C04 File Offset: 0x00276E04
		[DebuggerNonUserCode]
		public SendMessageNotification Clone()
		{
			return new SendMessageNotification(this);
		}

		// Token: 0x1700324C RID: 12876
		// (get) Token: 0x0600A26B RID: 41579 RVA: 0x00278C1C File Offset: 0x00276E1C
		// (set) Token: 0x0600A26C RID: 41580 RVA: 0x00278C34 File Offset: 0x00276E34
		[DebuggerNonUserCode]
		public EntityId AgentId
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

		// Token: 0x1700324D RID: 12877
		// (get) Token: 0x0600A26D RID: 41581 RVA: 0x00278C40 File Offset: 0x00276E40
		// (set) Token: 0x0600A26E RID: 41582 RVA: 0x00278C58 File Offset: 0x00276E58
		[DebuggerNonUserCode]
		public Message Message
		{
			get
			{
				return this.message_;
			}
			set
			{
				this.message_ = value;
			}
		}

		// Token: 0x1700324E RID: 12878
		// (get) Token: 0x0600A26F RID: 41583 RVA: 0x00278C64 File Offset: 0x00276E64
		// (set) Token: 0x0600A270 RID: 41584 RVA: 0x00278C95 File Offset: 0x00276E95
		[DebuggerNonUserCode]
		public ulong RequiredPrivileges
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong requiredPrivilegesDefaultValue;
				if (flag)
				{
					requiredPrivilegesDefaultValue = this.requiredPrivileges_;
				}
				else
				{
					requiredPrivilegesDefaultValue = SendMessageNotification.RequiredPrivilegesDefaultValue;
				}
				return requiredPrivilegesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.requiredPrivileges_ = value;
			}
		}

		// Token: 0x1700324F RID: 12879
		// (get) Token: 0x0600A271 RID: 41585 RVA: 0x00278CB0 File Offset: 0x00276EB0
		[DebuggerNonUserCode]
		public bool HasRequiredPrivileges
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A272 RID: 41586 RVA: 0x00278CCD File Offset: 0x00276ECD
		[DebuggerNonUserCode]
		public void ClearRequiredPrivileges()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003250 RID: 12880
		// (get) Token: 0x0600A273 RID: 41587 RVA: 0x00278CE0 File Offset: 0x00276EE0
		// (set) Token: 0x0600A274 RID: 41588 RVA: 0x00278D01 File Offset: 0x00276F01
		[DebuggerNonUserCode]
		public string BattleTag
		{
			get
			{
				return this.battleTag_ ?? SendMessageNotification.BattleTagDefaultValue;
			}
			set
			{
				this.battleTag_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003251 RID: 12881
		// (get) Token: 0x0600A275 RID: 41589 RVA: 0x00278D18 File Offset: 0x00276F18
		[DebuggerNonUserCode]
		public bool HasBattleTag
		{
			get
			{
				return this.battleTag_ != null;
			}
		}

		// Token: 0x0600A276 RID: 41590 RVA: 0x00278D33 File Offset: 0x00276F33
		[DebuggerNonUserCode]
		public void ClearBattleTag()
		{
			this.battleTag_ = null;
		}

		// Token: 0x17003252 RID: 12882
		// (get) Token: 0x0600A277 RID: 41591 RVA: 0x00278D40 File Offset: 0x00276F40
		// (set) Token: 0x0600A278 RID: 41592 RVA: 0x00278D58 File Offset: 0x00276F58
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

		// Token: 0x17003253 RID: 12883
		// (get) Token: 0x0600A279 RID: 41593 RVA: 0x00278D64 File Offset: 0x00276F64
		// (set) Token: 0x0600A27A RID: 41594 RVA: 0x00278D7C File Offset: 0x00276F7C
		[DebuggerNonUserCode]
		public Identity Subscriber
		{
			get
			{
				return this.subscriber_;
			}
			set
			{
				this.subscriber_ = value;
			}
		}

		// Token: 0x0600A27B RID: 41595 RVA: 0x00278D88 File Offset: 0x00276F88
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SendMessageNotification);
		}

		// Token: 0x0600A27C RID: 41596 RVA: 0x00278DA8 File Offset: 0x00276FA8
		[DebuggerNonUserCode]
		public bool Equals(SendMessageNotification other)
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
						bool flag5 = !object.Equals(this.Message, other.Message);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.RequiredPrivileges != other.RequiredPrivileges;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.BattleTag != other.BattleTag;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.ChannelId, other.ChannelId);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !object.Equals(this.Subscriber, other.Subscriber);
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

		// Token: 0x0600A27D RID: 41597 RVA: 0x00278EA0 File Offset: 0x002770A0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.message_ != null;
			if (flag2)
			{
				num ^= this.Message.GetHashCode();
			}
			bool hasRequiredPrivileges = this.HasRequiredPrivileges;
			if (hasRequiredPrivileges)
			{
				num ^= this.RequiredPrivileges.GetHashCode();
			}
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				num ^= this.BattleTag.GetHashCode();
			}
			bool flag3 = this.channelId_ != null;
			if (flag3)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			bool flag4 = this.subscriber_ != null;
			if (flag4)
			{
				num ^= this.Subscriber.GetHashCode();
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A27E RID: 41598 RVA: 0x00278F7C File Offset: 0x0027717C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A27F RID: 41599 RVA: 0x00278F94 File Offset: 0x00277194
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A280 RID: 41600 RVA: 0x00278FA0 File Offset: 0x002771A0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.message_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Message);
			}
			bool hasRequiredPrivileges = this.HasRequiredPrivileges;
			if (hasRequiredPrivileges)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.RequiredPrivileges);
			}
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				output.WriteRawTag(34);
				output.WriteString(this.BattleTag);
			}
			bool flag3 = this.channelId_ != null;
			if (flag3)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.ChannelId);
			}
			bool flag4 = this.subscriber_ != null;
			if (flag4)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Subscriber);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A281 RID: 41601 RVA: 0x002790A8 File Offset: 0x002772A8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.message_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Message);
			}
			bool hasRequiredPrivileges = this.HasRequiredPrivileges;
			if (hasRequiredPrivileges)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.RequiredPrivileges);
			}
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.BattleTag);
			}
			bool flag3 = this.channelId_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
			}
			bool flag4 = this.subscriber_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Subscriber);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A282 RID: 41602 RVA: 0x00279198 File Offset: 0x00277398
		[DebuggerNonUserCode]
		public void MergeFrom(SendMessageNotification other)
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
						this.AgentId = new EntityId();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool flag4 = other.message_ != null;
				if (flag4)
				{
					bool flag5 = this.message_ == null;
					if (flag5)
					{
						this.Message = new Message();
					}
					this.Message.MergeFrom(other.Message);
				}
				bool hasRequiredPrivileges = other.HasRequiredPrivileges;
				if (hasRequiredPrivileges)
				{
					this.RequiredPrivileges = other.RequiredPrivileges;
				}
				bool hasBattleTag = other.HasBattleTag;
				if (hasBattleTag)
				{
					this.BattleTag = other.BattleTag;
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
				bool flag8 = other.subscriber_ != null;
				if (flag8)
				{
					bool flag9 = this.subscriber_ == null;
					if (flag9)
					{
						this.Subscriber = new Identity();
					}
					this.Subscriber.MergeFrom(other.Subscriber);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A283 RID: 41603 RVA: 0x002792FB File Offset: 0x002774FB
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A284 RID: 41604 RVA: 0x00279308 File Offset: 0x00277508
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 24U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							if (num3 != 24U)
							{
								goto IL_0046;
							}
							this.RequiredPrivileges = input.ReadUInt64();
						}
						else
						{
							bool flag = this.message_ == null;
							if (flag)
							{
								this.Message = new Message();
							}
							input.ReadMessage(this.Message);
						}
					}
					else
					{
						bool flag2 = this.agentId_ == null;
						if (flag2)
						{
							this.AgentId = new EntityId();
						}
						input.ReadMessage(this.AgentId);
					}
				}
				else if (num3 != 34U)
				{
					if (num3 != 42U)
					{
						if (num3 != 50U)
						{
							goto IL_0046;
						}
						bool flag3 = this.subscriber_ == null;
						if (flag3)
						{
							this.Subscriber = new Identity();
						}
						input.ReadMessage(this.Subscriber);
					}
					else
					{
						bool flag4 = this.channelId_ == null;
						if (flag4)
						{
							this.ChannelId = new ChannelId();
						}
						input.ReadMessage(this.ChannelId);
					}
				}
				else
				{
					this.BattleTag = input.ReadString();
				}
				continue;
				IL_0046:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004925 RID: 18725
		private static readonly MessageParser<SendMessageNotification> _parser = new MessageParser<SendMessageNotification>(() => new SendMessageNotification());

		// Token: 0x04004926 RID: 18726
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004927 RID: 18727
		private int _hasBits0;

		// Token: 0x04004928 RID: 18728
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04004929 RID: 18729
		private EntityId agentId_;

		// Token: 0x0400492A RID: 18730
		public const int MessageFieldNumber = 2;

		// Token: 0x0400492B RID: 18731
		private Message message_;

		// Token: 0x0400492C RID: 18732
		public const int RequiredPrivilegesFieldNumber = 3;

		// Token: 0x0400492D RID: 18733
		private static readonly ulong RequiredPrivilegesDefaultValue = 0UL;

		// Token: 0x0400492E RID: 18734
		private ulong requiredPrivileges_;

		// Token: 0x0400492F RID: 18735
		public const int BattleTagFieldNumber = 4;

		// Token: 0x04004930 RID: 18736
		private static readonly string BattleTagDefaultValue = "";

		// Token: 0x04004931 RID: 18737
		private string battleTag_;

		// Token: 0x04004932 RID: 18738
		public const int ChannelIdFieldNumber = 5;

		// Token: 0x04004933 RID: 18739
		private ChannelId channelId_;

		// Token: 0x04004934 RID: 18740
		public const int SubscriberFieldNumber = 6;

		// Token: 0x04004935 RID: 18741
		private Identity subscriber_;
	}
}
