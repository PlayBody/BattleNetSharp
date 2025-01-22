using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006E2 RID: 1762
	public sealed class UpdateChannelStateNotification : IMessage<UpdateChannelStateNotification>, IMessage, IEquatable<UpdateChannelStateNotification>, IDeepCloneable<UpdateChannelStateNotification>, IBufferMessage
	{
		// Token: 0x17003254 RID: 12884
		// (get) Token: 0x0600A286 RID: 41606 RVA: 0x0027948C File Offset: 0x0027768C
		[DebuggerNonUserCode]
		public static MessageParser<UpdateChannelStateNotification> Parser
		{
			get
			{
				return UpdateChannelStateNotification._parser;
			}
		}

		// Token: 0x17003255 RID: 12885
		// (get) Token: 0x0600A287 RID: 41607 RVA: 0x002794A4 File Offset: 0x002776A4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x17003256 RID: 12886
		// (get) Token: 0x0600A288 RID: 41608 RVA: 0x002794C8 File Offset: 0x002776C8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateChannelStateNotification.Descriptor;
			}
		}

		// Token: 0x0600A289 RID: 41609 RVA: 0x002794DF File Offset: 0x002776DF
		[DebuggerNonUserCode]
		public UpdateChannelStateNotification()
		{
		}

		// Token: 0x0600A28A RID: 41610 RVA: 0x002794EC File Offset: 0x002776EC
		[DebuggerNonUserCode]
		public UpdateChannelStateNotification(UpdateChannelStateNotification other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.stateChange_ = ((other.stateChange_ != null) ? other.stateChange_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.subscriber_ = ((other.subscriber_ != null) ? other.subscriber_.Clone() : null);
			this.subscriberId_ = ((other.subscriberId_ != null) ? other.subscriberId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A28B RID: 41611 RVA: 0x002795A0 File Offset: 0x002777A0
		[DebuggerNonUserCode]
		public UpdateChannelStateNotification Clone()
		{
			return new UpdateChannelStateNotification(this);
		}

		// Token: 0x17003257 RID: 12887
		// (get) Token: 0x0600A28C RID: 41612 RVA: 0x002795B8 File Offset: 0x002777B8
		// (set) Token: 0x0600A28D RID: 41613 RVA: 0x002795D0 File Offset: 0x002777D0
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

		// Token: 0x17003258 RID: 12888
		// (get) Token: 0x0600A28E RID: 41614 RVA: 0x002795DC File Offset: 0x002777DC
		// (set) Token: 0x0600A28F RID: 41615 RVA: 0x002795F4 File Offset: 0x002777F4
		[DebuggerNonUserCode]
		public ChannelState StateChange
		{
			get
			{
				return this.stateChange_;
			}
			set
			{
				this.stateChange_ = value;
			}
		}

		// Token: 0x17003259 RID: 12889
		// (get) Token: 0x0600A290 RID: 41616 RVA: 0x00279600 File Offset: 0x00277800
		// (set) Token: 0x0600A291 RID: 41617 RVA: 0x00279618 File Offset: 0x00277818
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

		// Token: 0x1700325A RID: 12890
		// (get) Token: 0x0600A292 RID: 41618 RVA: 0x00279624 File Offset: 0x00277824
		// (set) Token: 0x0600A293 RID: 41619 RVA: 0x0027963C File Offset: 0x0027783C
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

		// Token: 0x1700325B RID: 12891
		// (get) Token: 0x0600A294 RID: 41620 RVA: 0x00279648 File Offset: 0x00277848
		// (set) Token: 0x0600A295 RID: 41621 RVA: 0x00279660 File Offset: 0x00277860
		[DebuggerNonUserCode]
		public AccountId SubscriberId
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

		// Token: 0x0600A296 RID: 41622 RVA: 0x0027966C File Offset: 0x0027786C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateChannelStateNotification);
		}

		// Token: 0x0600A297 RID: 41623 RVA: 0x0027968C File Offset: 0x0027788C
		[DebuggerNonUserCode]
		public bool Equals(UpdateChannelStateNotification other)
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
						bool flag5 = !object.Equals(this.StateChange, other.StateChange);
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
								bool flag7 = !object.Equals(this.Subscriber, other.Subscriber);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.SubscriberId, other.SubscriberId);
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A298 RID: 41624 RVA: 0x00279768 File Offset: 0x00277968
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.stateChange_ != null;
			if (flag2)
			{
				num ^= this.StateChange.GetHashCode();
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
			bool flag5 = this.subscriberId_ != null;
			if (flag5)
			{
				num ^= this.SubscriberId.GetHashCode();
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A299 RID: 41625 RVA: 0x0027982C File Offset: 0x00277A2C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A29A RID: 41626 RVA: 0x00279844 File Offset: 0x00277A44
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A29B RID: 41627 RVA: 0x00279850 File Offset: 0x00277A50
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.stateChange_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.StateChange);
			}
			bool flag3 = this.channelId_ != null;
			if (flag3)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.ChannelId);
			}
			bool flag4 = this.subscriber_ != null;
			if (flag4)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Subscriber);
			}
			bool flag5 = this.subscriberId_ != null;
			if (flag5)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.SubscriberId);
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A29C RID: 41628 RVA: 0x00279938 File Offset: 0x00277B38
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.stateChange_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StateChange);
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
			bool flag5 = this.subscriberId_ != null;
			if (flag5)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SubscriberId);
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A29D RID: 41629 RVA: 0x00279A10 File Offset: 0x00277C10
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateChannelStateNotification other)
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
				bool flag4 = other.stateChange_ != null;
				if (flag4)
				{
					bool flag5 = this.stateChange_ == null;
					if (flag5)
					{
						this.StateChange = new ChannelState();
					}
					this.StateChange.MergeFrom(other.StateChange);
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
				bool flag10 = other.subscriberId_ != null;
				if (flag10)
				{
					bool flag11 = this.subscriberId_ == null;
					if (flag11)
					{
						this.SubscriberId = new AccountId();
					}
					this.SubscriberId.MergeFrom(other.SubscriberId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A29E RID: 41630 RVA: 0x00279B7D File Offset: 0x00277D7D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A29F RID: 41631 RVA: 0x00279B88 File Offset: 0x00277D88
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
							goto IL_003C;
						}
						bool flag = this.stateChange_ == null;
						if (flag)
						{
							this.StateChange = new ChannelState();
						}
						input.ReadMessage(this.StateChange);
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
				else if (num3 != 26U)
				{
					if (num3 != 34U)
					{
						if (num3 != 42U)
						{
							goto IL_003C;
						}
						bool flag3 = this.subscriberId_ == null;
						if (flag3)
						{
							this.SubscriberId = new AccountId();
						}
						input.ReadMessage(this.SubscriberId);
					}
					else
					{
						bool flag4 = this.subscriber_ == null;
						if (flag4)
						{
							this.Subscriber = new Identity();
						}
						input.ReadMessage(this.Subscriber);
					}
				}
				else
				{
					bool flag5 = this.channelId_ == null;
					if (flag5)
					{
						this.ChannelId = new ChannelId();
					}
					input.ReadMessage(this.ChannelId);
				}
				continue;
				IL_003C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004936 RID: 18742
		private static readonly MessageParser<UpdateChannelStateNotification> _parser = new MessageParser<UpdateChannelStateNotification>(() => new UpdateChannelStateNotification());

		// Token: 0x04004937 RID: 18743
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004938 RID: 18744
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04004939 RID: 18745
		private EntityId agentId_;

		// Token: 0x0400493A RID: 18746
		public const int StateChangeFieldNumber = 2;

		// Token: 0x0400493B RID: 18747
		private ChannelState stateChange_;

		// Token: 0x0400493C RID: 18748
		public const int ChannelIdFieldNumber = 3;

		// Token: 0x0400493D RID: 18749
		private ChannelId channelId_;

		// Token: 0x0400493E RID: 18750
		public const int SubscriberFieldNumber = 4;

		// Token: 0x0400493F RID: 18751
		private Identity subscriber_;

		// Token: 0x04004940 RID: 18752
		public const int SubscriberIdFieldNumber = 5;

		// Token: 0x04004941 RID: 18753
		private AccountId subscriberId_;
	}
}
