using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000677 RID: 1655
	public sealed class MemberAddedNotification : IMessage<MemberAddedNotification>, IMessage, IEquatable<MemberAddedNotification>, IDeepCloneable<MemberAddedNotification>, IBufferMessage
	{
		// Token: 0x17002FC9 RID: 12233
		// (get) Token: 0x06009996 RID: 39318 RVA: 0x002530F4 File Offset: 0x002512F4
		[DebuggerNonUserCode]
		public static MessageParser<MemberAddedNotification> Parser
		{
			get
			{
				return MemberAddedNotification._parser;
			}
		}

		// Token: 0x17002FCA RID: 12234
		// (get) Token: 0x06009997 RID: 39319 RVA: 0x0025310C File Offset: 0x0025130C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[27];
			}
		}

		// Token: 0x17002FCB RID: 12235
		// (get) Token: 0x06009998 RID: 39320 RVA: 0x00253130 File Offset: 0x00251330
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemberAddedNotification.Descriptor;
			}
		}

		// Token: 0x06009999 RID: 39321 RVA: 0x00253147 File Offset: 0x00251347
		[DebuggerNonUserCode]
		public MemberAddedNotification()
		{
		}

		// Token: 0x0600999A RID: 39322 RVA: 0x00253154 File Offset: 0x00251354
		[DebuggerNonUserCode]
		public MemberAddedNotification(MemberAddedNotification other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.subscriberId_ = ((other.subscriberId_ != null) ? other.subscriberId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.member_ = ((other.member_ != null) ? other.member_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600999B RID: 39323 RVA: 0x002531EC File Offset: 0x002513EC
		[DebuggerNonUserCode]
		public MemberAddedNotification Clone()
		{
			return new MemberAddedNotification(this);
		}

		// Token: 0x17002FCC RID: 12236
		// (get) Token: 0x0600999C RID: 39324 RVA: 0x00253204 File Offset: 0x00251404
		// (set) Token: 0x0600999D RID: 39325 RVA: 0x0025321C File Offset: 0x0025141C
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

		// Token: 0x17002FCD RID: 12237
		// (get) Token: 0x0600999E RID: 39326 RVA: 0x00253228 File Offset: 0x00251428
		// (set) Token: 0x0600999F RID: 39327 RVA: 0x00253240 File Offset: 0x00251440
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

		// Token: 0x17002FCE RID: 12238
		// (get) Token: 0x060099A0 RID: 39328 RVA: 0x0025324C File Offset: 0x0025144C
		// (set) Token: 0x060099A1 RID: 39329 RVA: 0x00253264 File Offset: 0x00251464
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

		// Token: 0x17002FCF RID: 12239
		// (get) Token: 0x060099A2 RID: 39330 RVA: 0x00253270 File Offset: 0x00251470
		// (set) Token: 0x060099A3 RID: 39331 RVA: 0x00253288 File Offset: 0x00251488
		[DebuggerNonUserCode]
		public Member Member
		{
			get
			{
				return this.member_;
			}
			set
			{
				this.member_ = value;
			}
		}

		// Token: 0x060099A4 RID: 39332 RVA: 0x00253294 File Offset: 0x00251494
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MemberAddedNotification);
		}

		// Token: 0x060099A5 RID: 39333 RVA: 0x002532B4 File Offset: 0x002514B4
		[DebuggerNonUserCode]
		public bool Equals(MemberAddedNotification other)
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
								bool flag7 = !object.Equals(this.Member, other.Member);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060099A6 RID: 39334 RVA: 0x00253370 File Offset: 0x00251570
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
			bool flag4 = this.member_ != null;
			if (flag4)
			{
				num ^= this.Member.GetHashCode();
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060099A7 RID: 39335 RVA: 0x00253414 File Offset: 0x00251614
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060099A8 RID: 39336 RVA: 0x0025342C File Offset: 0x0025162C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060099A9 RID: 39337 RVA: 0x00253438 File Offset: 0x00251638
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
			bool flag4 = this.member_ != null;
			if (flag4)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Member);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060099AA RID: 39338 RVA: 0x002534F8 File Offset: 0x002516F8
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
			bool flag4 = this.member_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Member);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060099AB RID: 39339 RVA: 0x002535AC File Offset: 0x002517AC
		[DebuggerNonUserCode]
		public void MergeFrom(MemberAddedNotification other)
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
				bool flag8 = other.member_ != null;
				if (flag8)
				{
					bool flag9 = this.member_ == null;
					if (flag9)
					{
						this.Member = new Member();
					}
					this.Member.MergeFrom(other.Member);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060099AC RID: 39340 RVA: 0x002536D9 File Offset: 0x002518D9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060099AD RID: 39341 RVA: 0x002536E4 File Offset: 0x002518E4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							goto IL_002F;
						}
						bool flag = this.subscriberId_ == null;
						if (flag)
						{
							this.SubscriberId = new GameAccountHandle();
						}
						input.ReadMessage(this.SubscriberId);
					}
					else
					{
						bool flag2 = this.agentId_ == null;
						if (flag2)
						{
							this.AgentId = new GameAccountHandle();
						}
						input.ReadMessage(this.AgentId);
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 34U)
					{
						goto IL_002F;
					}
					bool flag3 = this.member_ == null;
					if (flag3)
					{
						this.Member = new Member();
					}
					input.ReadMessage(this.Member);
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
				continue;
				IL_002F:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400450D RID: 17677
		private static readonly MessageParser<MemberAddedNotification> _parser = new MessageParser<MemberAddedNotification>(() => new MemberAddedNotification());

		// Token: 0x0400450E RID: 17678
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400450F RID: 17679
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04004510 RID: 17680
		private GameAccountHandle agentId_;

		// Token: 0x04004511 RID: 17681
		public const int SubscriberIdFieldNumber = 2;

		// Token: 0x04004512 RID: 17682
		private GameAccountHandle subscriberId_;

		// Token: 0x04004513 RID: 17683
		public const int ChannelIdFieldNumber = 3;

		// Token: 0x04004514 RID: 17684
		private ChannelId channelId_;

		// Token: 0x04004515 RID: 17685
		public const int MemberFieldNumber = 4;

		// Token: 0x04004516 RID: 17686
		private Member member_;
	}
}
