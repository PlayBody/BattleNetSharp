using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000680 RID: 1664
	public sealed class InvitationRemovedNotification : IMessage<InvitationRemovedNotification>, IMessage, IEquatable<InvitationRemovedNotification>, IDeepCloneable<InvitationRemovedNotification>, IBufferMessage
	{
		// Token: 0x1700300F RID: 12303
		// (get) Token: 0x06009A83 RID: 39555 RVA: 0x0025749C File Offset: 0x0025569C
		[DebuggerNonUserCode]
		public static MessageParser<InvitationRemovedNotification> Parser
		{
			get
			{
				return InvitationRemovedNotification._parser;
			}
		}

		// Token: 0x17003010 RID: 12304
		// (get) Token: 0x06009A84 RID: 39556 RVA: 0x002574B4 File Offset: 0x002556B4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[36];
			}
		}

		// Token: 0x17003011 RID: 12305
		// (get) Token: 0x06009A85 RID: 39557 RVA: 0x002574D8 File Offset: 0x002556D8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InvitationRemovedNotification.Descriptor;
			}
		}

		// Token: 0x06009A86 RID: 39558 RVA: 0x002574EF File Offset: 0x002556EF
		[DebuggerNonUserCode]
		public InvitationRemovedNotification()
		{
		}

		// Token: 0x06009A87 RID: 39559 RVA: 0x002574FC File Offset: 0x002556FC
		[DebuggerNonUserCode]
		public InvitationRemovedNotification(InvitationRemovedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.subscriberId_ = ((other.subscriberId_ != null) ? other.subscriberId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.invitationId_ = other.invitationId_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009A88 RID: 39560 RVA: 0x0025759C File Offset: 0x0025579C
		[DebuggerNonUserCode]
		public InvitationRemovedNotification Clone()
		{
			return new InvitationRemovedNotification(this);
		}

		// Token: 0x17003012 RID: 12306
		// (get) Token: 0x06009A89 RID: 39561 RVA: 0x002575B4 File Offset: 0x002557B4
		// (set) Token: 0x06009A8A RID: 39562 RVA: 0x002575CC File Offset: 0x002557CC
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

		// Token: 0x17003013 RID: 12307
		// (get) Token: 0x06009A8B RID: 39563 RVA: 0x002575D8 File Offset: 0x002557D8
		// (set) Token: 0x06009A8C RID: 39564 RVA: 0x002575F0 File Offset: 0x002557F0
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

		// Token: 0x17003014 RID: 12308
		// (get) Token: 0x06009A8D RID: 39565 RVA: 0x002575FC File Offset: 0x002557FC
		// (set) Token: 0x06009A8E RID: 39566 RVA: 0x00257614 File Offset: 0x00255814
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

		// Token: 0x17003015 RID: 12309
		// (get) Token: 0x06009A8F RID: 39567 RVA: 0x00257620 File Offset: 0x00255820
		// (set) Token: 0x06009A90 RID: 39568 RVA: 0x00257651 File Offset: 0x00255851
		[DebuggerNonUserCode]
		public ulong InvitationId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong invitationIdDefaultValue;
				if (flag)
				{
					invitationIdDefaultValue = this.invitationId_;
				}
				else
				{
					invitationIdDefaultValue = InvitationRemovedNotification.InvitationIdDefaultValue;
				}
				return invitationIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.invitationId_ = value;
			}
		}

		// Token: 0x17003016 RID: 12310
		// (get) Token: 0x06009A91 RID: 39569 RVA: 0x0025766C File Offset: 0x0025586C
		[DebuggerNonUserCode]
		public bool HasInvitationId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009A92 RID: 39570 RVA: 0x00257689 File Offset: 0x00255889
		[DebuggerNonUserCode]
		public void ClearInvitationId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003017 RID: 12311
		// (get) Token: 0x06009A93 RID: 39571 RVA: 0x0025769C File Offset: 0x0025589C
		// (set) Token: 0x06009A94 RID: 39572 RVA: 0x002576CD File Offset: 0x002558CD
		[DebuggerNonUserCode]
		public InvitationRemovedReason Reason
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				InvitationRemovedReason reasonDefaultValue;
				if (flag)
				{
					reasonDefaultValue = this.reason_;
				}
				else
				{
					reasonDefaultValue = InvitationRemovedNotification.ReasonDefaultValue;
				}
				return reasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.reason_ = value;
			}
		}

		// Token: 0x17003018 RID: 12312
		// (get) Token: 0x06009A95 RID: 39573 RVA: 0x002576E8 File Offset: 0x002558E8
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06009A96 RID: 39574 RVA: 0x00257705 File Offset: 0x00255905
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06009A97 RID: 39575 RVA: 0x00257718 File Offset: 0x00255918
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as InvitationRemovedNotification);
		}

		// Token: 0x06009A98 RID: 39576 RVA: 0x00257738 File Offset: 0x00255938
		[DebuggerNonUserCode]
		public bool Equals(InvitationRemovedNotification other)
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
								bool flag7 = this.InvitationId != other.InvitationId;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Reason != other.Reason;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009A99 RID: 39577 RVA: 0x0025780C File Offset: 0x00255A0C
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
			bool hasInvitationId = this.HasInvitationId;
			if (hasInvitationId)
			{
				num ^= this.InvitationId.GetHashCode();
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num ^= this.Reason.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009A9A RID: 39578 RVA: 0x002578D8 File Offset: 0x00255AD8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009A9B RID: 39579 RVA: 0x002578F0 File Offset: 0x00255AF0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009A9C RID: 39580 RVA: 0x002578FC File Offset: 0x00255AFC
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
			bool hasInvitationId = this.HasInvitationId;
			if (hasInvitationId)
			{
				output.WriteRawTag(33);
				output.WriteFixed64(this.InvitationId);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Reason);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009A9D RID: 39581 RVA: 0x002579E0 File Offset: 0x00255BE0
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
			bool hasInvitationId = this.HasInvitationId;
			if (hasInvitationId)
			{
				num += 9;
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009A9E RID: 39582 RVA: 0x00257AA4 File Offset: 0x00255CA4
		[DebuggerNonUserCode]
		public void MergeFrom(InvitationRemovedNotification other)
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
				bool hasInvitationId = other.HasInvitationId;
				if (hasInvitationId)
				{
					this.InvitationId = other.InvitationId;
				}
				bool hasReason = other.HasReason;
				if (hasReason)
				{
					this.Reason = other.Reason;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009A9F RID: 39583 RVA: 0x00257BC7 File Offset: 0x00255DC7
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009AA0 RID: 39584 RVA: 0x00257BD4 File Offset: 0x00255DD4
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
					if (num3 != 33U)
					{
						if (num3 != 40U)
						{
							goto IL_003C;
						}
						this.Reason = (InvitationRemovedReason)input.ReadEnum();
					}
					else
					{
						this.InvitationId = input.ReadFixed64();
					}
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
				IL_003C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004576 RID: 17782
		private static readonly MessageParser<InvitationRemovedNotification> _parser = new MessageParser<InvitationRemovedNotification>(() => new InvitationRemovedNotification());

		// Token: 0x04004577 RID: 17783
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004578 RID: 17784
		private int _hasBits0;

		// Token: 0x04004579 RID: 17785
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400457A RID: 17786
		private GameAccountHandle agentId_;

		// Token: 0x0400457B RID: 17787
		public const int SubscriberIdFieldNumber = 2;

		// Token: 0x0400457C RID: 17788
		private GameAccountHandle subscriberId_;

		// Token: 0x0400457D RID: 17789
		public const int ChannelIdFieldNumber = 3;

		// Token: 0x0400457E RID: 17790
		private ChannelId channelId_;

		// Token: 0x0400457F RID: 17791
		public const int InvitationIdFieldNumber = 4;

		// Token: 0x04004580 RID: 17792
		private static readonly ulong InvitationIdDefaultValue = 0UL;

		// Token: 0x04004581 RID: 17793
		private ulong invitationId_;

		// Token: 0x04004582 RID: 17794
		public const int ReasonFieldNumber = 5;

		// Token: 0x04004583 RID: 17795
		private static readonly InvitationRemovedReason ReasonDefaultValue = InvitationRemovedReason.Accepted;

		// Token: 0x04004584 RID: 17796
		private InvitationRemovedReason reason_;
	}
}
