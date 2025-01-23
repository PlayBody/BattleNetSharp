using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x0200067B RID: 1659
	public sealed class AttributeChangedNotification : IMessage<AttributeChangedNotification>, IMessage, IEquatable<AttributeChangedNotification>, IDeepCloneable<AttributeChangedNotification>, IBufferMessage
	{
		// Token: 0x17002FE7 RID: 12263
		// (get) Token: 0x060099FD RID: 39421 RVA: 0x00254E80 File Offset: 0x00253080
		[DebuggerNonUserCode]
		public static MessageParser<AttributeChangedNotification> Parser
		{
			get
			{
				return AttributeChangedNotification._parser;
			}
		}

		// Token: 0x17002FE8 RID: 12264
		// (get) Token: 0x060099FE RID: 39422 RVA: 0x00254E98 File Offset: 0x00253098
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[31];
			}
		}

		// Token: 0x17002FE9 RID: 12265
		// (get) Token: 0x060099FF RID: 39423 RVA: 0x00254EBC File Offset: 0x002530BC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttributeChangedNotification.Descriptor;
			}
		}

		// Token: 0x06009A00 RID: 39424 RVA: 0x00254ED3 File Offset: 0x002530D3
		[DebuggerNonUserCode]
		public AttributeChangedNotification()
		{
		}

		// Token: 0x06009A01 RID: 39425 RVA: 0x00254EE8 File Offset: 0x002530E8
		[DebuggerNonUserCode]
		public AttributeChangedNotification(AttributeChangedNotification other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.subscriberId_ = ((other.subscriberId_ != null) ? other.subscriberId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.attribute_ = other.attribute_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009A02 RID: 39426 RVA: 0x00254F74 File Offset: 0x00253174
		[DebuggerNonUserCode]
		public AttributeChangedNotification Clone()
		{
			return new AttributeChangedNotification(this);
		}

		// Token: 0x17002FEA RID: 12266
		// (get) Token: 0x06009A03 RID: 39427 RVA: 0x00254F8C File Offset: 0x0025318C
		// (set) Token: 0x06009A04 RID: 39428 RVA: 0x00254FA4 File Offset: 0x002531A4
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

		// Token: 0x17002FEB RID: 12267
		// (get) Token: 0x06009A05 RID: 39429 RVA: 0x00254FB0 File Offset: 0x002531B0
		// (set) Token: 0x06009A06 RID: 39430 RVA: 0x00254FC8 File Offset: 0x002531C8
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

		// Token: 0x17002FEC RID: 12268
		// (get) Token: 0x06009A07 RID: 39431 RVA: 0x00254FD4 File Offset: 0x002531D4
		// (set) Token: 0x06009A08 RID: 39432 RVA: 0x00254FEC File Offset: 0x002531EC
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

		// Token: 0x17002FED RID: 12269
		// (get) Token: 0x06009A09 RID: 39433 RVA: 0x00254FF8 File Offset: 0x002531F8
		[DebuggerNonUserCode]
		public RepeatedField<Bgs.Protocol.V2.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x06009A0A RID: 39434 RVA: 0x00255010 File Offset: 0x00253210
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AttributeChangedNotification);
		}

		// Token: 0x06009A0B RID: 39435 RVA: 0x00255030 File Offset: 0x00253230
		[DebuggerNonUserCode]
		public bool Equals(AttributeChangedNotification other)
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
								bool flag7 = !this.attribute_.Equals(other.attribute_);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009A0C RID: 39436 RVA: 0x002550EC File Offset: 0x002532EC
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
			num ^= this.attribute_.GetHashCode();
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009A0D RID: 39437 RVA: 0x00255184 File Offset: 0x00253384
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009A0E RID: 39438 RVA: 0x0025519C File Offset: 0x0025339C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009A0F RID: 39439 RVA: 0x002551A8 File Offset: 0x002533A8
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
			this.attribute_.WriteTo(ref output, AttributeChangedNotification._repeated_attribute_codec);
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009A10 RID: 39440 RVA: 0x00255254 File Offset: 0x00253454
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
			num += this.attribute_.CalculateSize(AttributeChangedNotification._repeated_attribute_codec);
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009A11 RID: 39441 RVA: 0x002552FC File Offset: 0x002534FC
		[DebuggerNonUserCode]
		public void MergeFrom(AttributeChangedNotification other)
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
				this.attribute_.Add(other.attribute_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009A12 RID: 39442 RVA: 0x002553FB File Offset: 0x002535FB
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009A13 RID: 39443 RVA: 0x00255408 File Offset: 0x00253608
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
					this.attribute_.AddEntriesFrom(ref input, AttributeChangedNotification._repeated_attribute_codec);
				}
				else
				{
					bool flag3 = this.channelId_ == null;
					if (flag3)
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

		// Token: 0x0400453A RID: 17722
		private static readonly MessageParser<AttributeChangedNotification> _parser = new MessageParser<AttributeChangedNotification>(() => new AttributeChangedNotification());

		// Token: 0x0400453B RID: 17723
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400453C RID: 17724
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400453D RID: 17725
		private GameAccountHandle agentId_;

		// Token: 0x0400453E RID: 17726
		public const int SubscriberIdFieldNumber = 2;

		// Token: 0x0400453F RID: 17727
		private GameAccountHandle subscriberId_;

		// Token: 0x04004540 RID: 17728
		public const int ChannelIdFieldNumber = 3;

		// Token: 0x04004541 RID: 17729
		private ChannelId channelId_;

		// Token: 0x04004542 RID: 17730
		public const int AttributeFieldNumber = 4;

		// Token: 0x04004543 RID: 17731
		private static readonly FieldCodec<Bgs.Protocol.V2.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.V2.Attribute>(34U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x04004544 RID: 17732
		private readonly RepeatedField<Bgs.Protocol.V2.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.V2.Attribute>();
	}
}
