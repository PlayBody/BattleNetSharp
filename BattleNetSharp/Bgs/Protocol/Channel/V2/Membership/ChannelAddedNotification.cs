using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2.Membership
{
	// Token: 0x020006AF RID: 1711
	public sealed class ChannelAddedNotification : IMessage<ChannelAddedNotification>, IMessage, IEquatable<ChannelAddedNotification>, IDeepCloneable<ChannelAddedNotification>, IBufferMessage
	{
		// Token: 0x17003132 RID: 12594
		// (get) Token: 0x06009E70 RID: 40560 RVA: 0x002684D8 File Offset: 0x002666D8
		[DebuggerNonUserCode]
		public static MessageParser<ChannelAddedNotification> Parser
		{
			get
			{
				return ChannelAddedNotification._parser;
			}
		}

		// Token: 0x17003133 RID: 12595
		// (get) Token: 0x06009E71 RID: 40561 RVA: 0x002684F0 File Offset: 0x002666F0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelMembershipServiceReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17003134 RID: 12596
		// (get) Token: 0x06009E72 RID: 40562 RVA: 0x00268514 File Offset: 0x00266714
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelAddedNotification.Descriptor;
			}
		}

		// Token: 0x06009E73 RID: 40563 RVA: 0x0026852B File Offset: 0x0026672B
		[DebuggerNonUserCode]
		public ChannelAddedNotification()
		{
		}

		// Token: 0x06009E74 RID: 40564 RVA: 0x00268538 File Offset: 0x00266738
		[DebuggerNonUserCode]
		public ChannelAddedNotification(ChannelAddedNotification other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.subscriberId_ = ((other.subscriberId_ != null) ? other.subscriberId_.Clone() : null);
			this.membership_ = ((other.membership_ != null) ? other.membership_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009E75 RID: 40565 RVA: 0x002685B4 File Offset: 0x002667B4
		[DebuggerNonUserCode]
		public ChannelAddedNotification Clone()
		{
			return new ChannelAddedNotification(this);
		}

		// Token: 0x17003135 RID: 12597
		// (get) Token: 0x06009E76 RID: 40566 RVA: 0x002685CC File Offset: 0x002667CC
		// (set) Token: 0x06009E77 RID: 40567 RVA: 0x002685E4 File Offset: 0x002667E4
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

		// Token: 0x17003136 RID: 12598
		// (get) Token: 0x06009E78 RID: 40568 RVA: 0x002685F0 File Offset: 0x002667F0
		// (set) Token: 0x06009E79 RID: 40569 RVA: 0x00268608 File Offset: 0x00266808
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

		// Token: 0x17003137 RID: 12599
		// (get) Token: 0x06009E7A RID: 40570 RVA: 0x00268614 File Offset: 0x00266814
		// (set) Token: 0x06009E7B RID: 40571 RVA: 0x0026862C File Offset: 0x0026682C
		[DebuggerNonUserCode]
		public ChannelDescription Membership
		{
			get
			{
				return this.membership_;
			}
			set
			{
				this.membership_ = value;
			}
		}

		// Token: 0x06009E7C RID: 40572 RVA: 0x00268638 File Offset: 0x00266838
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelAddedNotification);
		}

		// Token: 0x06009E7D RID: 40573 RVA: 0x00268658 File Offset: 0x00266858
		[DebuggerNonUserCode]
		public bool Equals(ChannelAddedNotification other)
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
							bool flag6 = !object.Equals(this.Membership, other.Membership);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009E7E RID: 40574 RVA: 0x002686F0 File Offset: 0x002668F0
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
			bool flag3 = this.membership_ != null;
			if (flag3)
			{
				num ^= this.Membership.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009E7F RID: 40575 RVA: 0x00268778 File Offset: 0x00266978
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009E80 RID: 40576 RVA: 0x00268790 File Offset: 0x00266990
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009E81 RID: 40577 RVA: 0x0026879C File Offset: 0x0026699C
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
			bool flag3 = this.membership_ != null;
			if (flag3)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Membership);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009E82 RID: 40578 RVA: 0x00268838 File Offset: 0x00266A38
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
			bool flag3 = this.membership_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Membership);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009E83 RID: 40579 RVA: 0x002688CC File Offset: 0x00266ACC
		[DebuggerNonUserCode]
		public void MergeFrom(ChannelAddedNotification other)
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
				bool flag6 = other.membership_ != null;
				if (flag6)
				{
					bool flag7 = this.membership_ == null;
					if (flag7)
					{
						this.Membership = new ChannelDescription();
					}
					this.Membership.MergeFrom(other.Membership);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009E84 RID: 40580 RVA: 0x002689B9 File Offset: 0x00266BB9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009E85 RID: 40581 RVA: 0x002689C4 File Offset: 0x00266BC4
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.membership_ == null;
							if (flag)
							{
								this.Membership = new ChannelDescription();
							}
							input.ReadMessage(this.Membership);
						}
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
		}

		// Token: 0x04004770 RID: 18288
		private static readonly MessageParser<ChannelAddedNotification> _parser = new MessageParser<ChannelAddedNotification>(() => new ChannelAddedNotification());

		// Token: 0x04004771 RID: 18289
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004772 RID: 18290
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04004773 RID: 18291
		private GameAccountHandle agentId_;

		// Token: 0x04004774 RID: 18292
		public const int SubscriberIdFieldNumber = 2;

		// Token: 0x04004775 RID: 18293
		private GameAccountHandle subscriberId_;

		// Token: 0x04004776 RID: 18294
		public const int MembershipFieldNumber = 3;

		// Token: 0x04004777 RID: 18295
		private ChannelDescription membership_;
	}
}
