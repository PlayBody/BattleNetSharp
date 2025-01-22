using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x0200067C RID: 1660
	public sealed class PrivacyLevelChangedNotification : IMessage<PrivacyLevelChangedNotification>, IMessage, IEquatable<PrivacyLevelChangedNotification>, IDeepCloneable<PrivacyLevelChangedNotification>, IBufferMessage
	{
		// Token: 0x17002FEE RID: 12270
		// (get) Token: 0x06009A15 RID: 39445 RVA: 0x00255538 File Offset: 0x00253738
		[DebuggerNonUserCode]
		public static MessageParser<PrivacyLevelChangedNotification> Parser
		{
			get
			{
				return PrivacyLevelChangedNotification._parser;
			}
		}

		// Token: 0x17002FEF RID: 12271
		// (get) Token: 0x06009A16 RID: 39446 RVA: 0x00255550 File Offset: 0x00253750
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[32];
			}
		}

		// Token: 0x17002FF0 RID: 12272
		// (get) Token: 0x06009A17 RID: 39447 RVA: 0x00255574 File Offset: 0x00253774
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrivacyLevelChangedNotification.Descriptor;
			}
		}

		// Token: 0x06009A18 RID: 39448 RVA: 0x0025558B File Offset: 0x0025378B
		[DebuggerNonUserCode]
		public PrivacyLevelChangedNotification()
		{
		}

		// Token: 0x06009A19 RID: 39449 RVA: 0x00255598 File Offset: 0x00253798
		[DebuggerNonUserCode]
		public PrivacyLevelChangedNotification(PrivacyLevelChangedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.subscriberId_ = ((other.subscriberId_ != null) ? other.subscriberId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.privacyLevel_ = other.privacyLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009A1A RID: 39450 RVA: 0x0025562C File Offset: 0x0025382C
		[DebuggerNonUserCode]
		public PrivacyLevelChangedNotification Clone()
		{
			return new PrivacyLevelChangedNotification(this);
		}

		// Token: 0x17002FF1 RID: 12273
		// (get) Token: 0x06009A1B RID: 39451 RVA: 0x00255644 File Offset: 0x00253844
		// (set) Token: 0x06009A1C RID: 39452 RVA: 0x0025565C File Offset: 0x0025385C
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

		// Token: 0x17002FF2 RID: 12274
		// (get) Token: 0x06009A1D RID: 39453 RVA: 0x00255668 File Offset: 0x00253868
		// (set) Token: 0x06009A1E RID: 39454 RVA: 0x00255680 File Offset: 0x00253880
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

		// Token: 0x17002FF3 RID: 12275
		// (get) Token: 0x06009A1F RID: 39455 RVA: 0x0025568C File Offset: 0x0025388C
		// (set) Token: 0x06009A20 RID: 39456 RVA: 0x002556A4 File Offset: 0x002538A4
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

		// Token: 0x17002FF4 RID: 12276
		// (get) Token: 0x06009A21 RID: 39457 RVA: 0x002556B0 File Offset: 0x002538B0
		// (set) Token: 0x06009A22 RID: 39458 RVA: 0x002556E1 File Offset: 0x002538E1
		[DebuggerNonUserCode]
		public PrivacyLevel PrivacyLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				PrivacyLevel privacyLevelDefaultValue;
				if (flag)
				{
					privacyLevelDefaultValue = this.privacyLevel_;
				}
				else
				{
					privacyLevelDefaultValue = PrivacyLevelChangedNotification.PrivacyLevelDefaultValue;
				}
				return privacyLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.privacyLevel_ = value;
			}
		}

		// Token: 0x17002FF5 RID: 12277
		// (get) Token: 0x06009A23 RID: 39459 RVA: 0x002556FC File Offset: 0x002538FC
		[DebuggerNonUserCode]
		public bool HasPrivacyLevel
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009A24 RID: 39460 RVA: 0x00255719 File Offset: 0x00253919
		[DebuggerNonUserCode]
		public void ClearPrivacyLevel()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06009A25 RID: 39461 RVA: 0x0025572C File Offset: 0x0025392C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrivacyLevelChangedNotification);
		}

		// Token: 0x06009A26 RID: 39462 RVA: 0x0025574C File Offset: 0x0025394C
		[DebuggerNonUserCode]
		public bool Equals(PrivacyLevelChangedNotification other)
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
								bool flag7 = this.PrivacyLevel != other.PrivacyLevel;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009A27 RID: 39463 RVA: 0x00255804 File Offset: 0x00253A04
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
			bool hasPrivacyLevel = this.HasPrivacyLevel;
			if (hasPrivacyLevel)
			{
				num ^= this.PrivacyLevel.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009A28 RID: 39464 RVA: 0x002558B0 File Offset: 0x00253AB0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009A29 RID: 39465 RVA: 0x002558C8 File Offset: 0x00253AC8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009A2A RID: 39466 RVA: 0x002558D4 File Offset: 0x00253AD4
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
			bool hasPrivacyLevel = this.HasPrivacyLevel;
			if (hasPrivacyLevel)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.PrivacyLevel);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009A2B RID: 39467 RVA: 0x00255994 File Offset: 0x00253B94
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
			bool hasPrivacyLevel = this.HasPrivacyLevel;
			if (hasPrivacyLevel)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.PrivacyLevel);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009A2C RID: 39468 RVA: 0x00255A48 File Offset: 0x00253C48
		[DebuggerNonUserCode]
		public void MergeFrom(PrivacyLevelChangedNotification other)
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
				bool hasPrivacyLevel = other.HasPrivacyLevel;
				if (hasPrivacyLevel)
				{
					this.PrivacyLevel = other.PrivacyLevel;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009A2D RID: 39469 RVA: 0x00255B50 File Offset: 0x00253D50
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009A2E RID: 39470 RVA: 0x00255B5C File Offset: 0x00253D5C
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
					if (num3 != 32U)
					{
						goto IL_002F;
					}
					this.PrivacyLevel = (PrivacyLevel)input.ReadEnum();
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

		// Token: 0x04004545 RID: 17733
		private static readonly MessageParser<PrivacyLevelChangedNotification> _parser = new MessageParser<PrivacyLevelChangedNotification>(() => new PrivacyLevelChangedNotification());

		// Token: 0x04004546 RID: 17734
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004547 RID: 17735
		private int _hasBits0;

		// Token: 0x04004548 RID: 17736
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04004549 RID: 17737
		private GameAccountHandle agentId_;

		// Token: 0x0400454A RID: 17738
		public const int SubscriberIdFieldNumber = 2;

		// Token: 0x0400454B RID: 17739
		private GameAccountHandle subscriberId_;

		// Token: 0x0400454C RID: 17740
		public const int ChannelIdFieldNumber = 3;

		// Token: 0x0400454D RID: 17741
		private ChannelId channelId_;

		// Token: 0x0400454E RID: 17742
		public const int PrivacyLevelFieldNumber = 4;

		// Token: 0x0400454F RID: 17743
		private static readonly PrivacyLevel PrivacyLevelDefaultValue = PrivacyLevel.Open;

		// Token: 0x04004550 RID: 17744
		private PrivacyLevel privacyLevel_;
	}
}
