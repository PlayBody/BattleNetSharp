using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x0200067D RID: 1661
	public sealed class SendMessageNotification : IMessage<SendMessageNotification>, IMessage, IEquatable<SendMessageNotification>, IDeepCloneable<SendMessageNotification>, IBufferMessage
	{
		// Token: 0x17002FF6 RID: 12278
		// (get) Token: 0x06009A30 RID: 39472 RVA: 0x00255C7C File Offset: 0x00253E7C
		[DebuggerNonUserCode]
		public static MessageParser<SendMessageNotification> Parser
		{
			get
			{
				return SendMessageNotification._parser;
			}
		}

		// Token: 0x17002FF7 RID: 12279
		// (get) Token: 0x06009A31 RID: 39473 RVA: 0x00255C94 File Offset: 0x00253E94
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[33];
			}
		}

		// Token: 0x17002FF8 RID: 12280
		// (get) Token: 0x06009A32 RID: 39474 RVA: 0x00255CB8 File Offset: 0x00253EB8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SendMessageNotification.Descriptor;
			}
		}

		// Token: 0x06009A33 RID: 39475 RVA: 0x00255CCF File Offset: 0x00253ECF
		[DebuggerNonUserCode]
		public SendMessageNotification()
		{
		}

		// Token: 0x06009A34 RID: 39476 RVA: 0x00255CDC File Offset: 0x00253EDC
		[DebuggerNonUserCode]
		public SendMessageNotification(SendMessageNotification other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.subscriberId_ = ((other.subscriberId_ != null) ? other.subscriberId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.message_ = ((other.message_ != null) ? other.message_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009A35 RID: 39477 RVA: 0x00255D74 File Offset: 0x00253F74
		[DebuggerNonUserCode]
		public SendMessageNotification Clone()
		{
			return new SendMessageNotification(this);
		}

		// Token: 0x17002FF9 RID: 12281
		// (get) Token: 0x06009A36 RID: 39478 RVA: 0x00255D8C File Offset: 0x00253F8C
		// (set) Token: 0x06009A37 RID: 39479 RVA: 0x00255DA4 File Offset: 0x00253FA4
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

		// Token: 0x17002FFA RID: 12282
		// (get) Token: 0x06009A38 RID: 39480 RVA: 0x00255DB0 File Offset: 0x00253FB0
		// (set) Token: 0x06009A39 RID: 39481 RVA: 0x00255DC8 File Offset: 0x00253FC8
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

		// Token: 0x17002FFB RID: 12283
		// (get) Token: 0x06009A3A RID: 39482 RVA: 0x00255DD4 File Offset: 0x00253FD4
		// (set) Token: 0x06009A3B RID: 39483 RVA: 0x00255DEC File Offset: 0x00253FEC
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

		// Token: 0x17002FFC RID: 12284
		// (get) Token: 0x06009A3C RID: 39484 RVA: 0x00255DF8 File Offset: 0x00253FF8
		// (set) Token: 0x06009A3D RID: 39485 RVA: 0x00255E10 File Offset: 0x00254010
		[DebuggerNonUserCode]
		public ChannelMessage Message
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

		// Token: 0x06009A3E RID: 39486 RVA: 0x00255E1C File Offset: 0x0025401C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SendMessageNotification);
		}

		// Token: 0x06009A3F RID: 39487 RVA: 0x00255E3C File Offset: 0x0025403C
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
								bool flag7 = !object.Equals(this.Message, other.Message);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009A40 RID: 39488 RVA: 0x00255EF8 File Offset: 0x002540F8
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
			bool flag4 = this.message_ != null;
			if (flag4)
			{
				num ^= this.Message.GetHashCode();
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009A41 RID: 39489 RVA: 0x00255F9C File Offset: 0x0025419C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009A42 RID: 39490 RVA: 0x00255FB4 File Offset: 0x002541B4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009A43 RID: 39491 RVA: 0x00255FC0 File Offset: 0x002541C0
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
			bool flag4 = this.message_ != null;
			if (flag4)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Message);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009A44 RID: 39492 RVA: 0x00256080 File Offset: 0x00254280
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
			bool flag4 = this.message_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Message);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009A45 RID: 39493 RVA: 0x00256134 File Offset: 0x00254334
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
				bool flag8 = other.message_ != null;
				if (flag8)
				{
					bool flag9 = this.message_ == null;
					if (flag9)
					{
						this.Message = new ChannelMessage();
					}
					this.Message.MergeFrom(other.Message);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009A46 RID: 39494 RVA: 0x00256261 File Offset: 0x00254461
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009A47 RID: 39495 RVA: 0x0025626C File Offset: 0x0025446C
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
					bool flag3 = this.message_ == null;
					if (flag3)
					{
						this.Message = new ChannelMessage();
					}
					input.ReadMessage(this.Message);
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

		// Token: 0x04004551 RID: 17745
		private static readonly MessageParser<SendMessageNotification> _parser = new MessageParser<SendMessageNotification>(() => new SendMessageNotification());

		// Token: 0x04004552 RID: 17746
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004553 RID: 17747
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04004554 RID: 17748
		private GameAccountHandle agentId_;

		// Token: 0x04004555 RID: 17749
		public const int SubscriberIdFieldNumber = 2;

		// Token: 0x04004556 RID: 17750
		private GameAccountHandle subscriberId_;

		// Token: 0x04004557 RID: 17751
		public const int ChannelIdFieldNumber = 3;

		// Token: 0x04004558 RID: 17752
		private ChannelId channelId_;

		// Token: 0x04004559 RID: 17753
		public const int MessageFieldNumber = 4;

		// Token: 0x0400455A RID: 17754
		private ChannelMessage message_;
	}
}
