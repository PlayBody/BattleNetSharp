using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2.Membership
{
	// Token: 0x020006B2 RID: 1714
	public sealed class ReceivedInvitationRemovedNotification : IMessage<ReceivedInvitationRemovedNotification>, IMessage, IEquatable<ReceivedInvitationRemovedNotification>, IDeepCloneable<ReceivedInvitationRemovedNotification>, IBufferMessage
	{
		// Token: 0x17003146 RID: 12614
		// (get) Token: 0x06009EB9 RID: 40633 RVA: 0x002697EC File Offset: 0x002679EC
		[DebuggerNonUserCode]
		public static MessageParser<ReceivedInvitationRemovedNotification> Parser
		{
			get
			{
				return ReceivedInvitationRemovedNotification._parser;
			}
		}

		// Token: 0x17003147 RID: 12615
		// (get) Token: 0x06009EBA RID: 40634 RVA: 0x00269804 File Offset: 0x00267A04
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelMembershipServiceReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x17003148 RID: 12616
		// (get) Token: 0x06009EBB RID: 40635 RVA: 0x00269828 File Offset: 0x00267A28
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReceivedInvitationRemovedNotification.Descriptor;
			}
		}

		// Token: 0x06009EBC RID: 40636 RVA: 0x0026983F File Offset: 0x00267A3F
		[DebuggerNonUserCode]
		public ReceivedInvitationRemovedNotification()
		{
		}

		// Token: 0x06009EBD RID: 40637 RVA: 0x0026984C File Offset: 0x00267A4C
		[DebuggerNonUserCode]
		public ReceivedInvitationRemovedNotification(ReceivedInvitationRemovedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.subscriberId_ = ((other.subscriberId_ != null) ? other.subscriberId_.Clone() : null);
			this.invitationId_ = other.invitationId_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009EBE RID: 40638 RVA: 0x002698D0 File Offset: 0x00267AD0
		[DebuggerNonUserCode]
		public ReceivedInvitationRemovedNotification Clone()
		{
			return new ReceivedInvitationRemovedNotification(this);
		}

		// Token: 0x17003149 RID: 12617
		// (get) Token: 0x06009EBF RID: 40639 RVA: 0x002698E8 File Offset: 0x00267AE8
		// (set) Token: 0x06009EC0 RID: 40640 RVA: 0x00269900 File Offset: 0x00267B00
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

		// Token: 0x1700314A RID: 12618
		// (get) Token: 0x06009EC1 RID: 40641 RVA: 0x0026990C File Offset: 0x00267B0C
		// (set) Token: 0x06009EC2 RID: 40642 RVA: 0x00269924 File Offset: 0x00267B24
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

		// Token: 0x1700314B RID: 12619
		// (get) Token: 0x06009EC3 RID: 40643 RVA: 0x00269930 File Offset: 0x00267B30
		// (set) Token: 0x06009EC4 RID: 40644 RVA: 0x00269961 File Offset: 0x00267B61
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
					invitationIdDefaultValue = ReceivedInvitationRemovedNotification.InvitationIdDefaultValue;
				}
				return invitationIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.invitationId_ = value;
			}
		}

		// Token: 0x1700314C RID: 12620
		// (get) Token: 0x06009EC5 RID: 40645 RVA: 0x0026997C File Offset: 0x00267B7C
		[DebuggerNonUserCode]
		public bool HasInvitationId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009EC6 RID: 40646 RVA: 0x00269999 File Offset: 0x00267B99
		[DebuggerNonUserCode]
		public void ClearInvitationId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700314D RID: 12621
		// (get) Token: 0x06009EC7 RID: 40647 RVA: 0x002699AC File Offset: 0x00267BAC
		// (set) Token: 0x06009EC8 RID: 40648 RVA: 0x002699DD File Offset: 0x00267BDD
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
					reasonDefaultValue = ReceivedInvitationRemovedNotification.ReasonDefaultValue;
				}
				return reasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.reason_ = value;
			}
		}

		// Token: 0x1700314E RID: 12622
		// (get) Token: 0x06009EC9 RID: 40649 RVA: 0x002699F8 File Offset: 0x00267BF8
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06009ECA RID: 40650 RVA: 0x00269A15 File Offset: 0x00267C15
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06009ECB RID: 40651 RVA: 0x00269A28 File Offset: 0x00267C28
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReceivedInvitationRemovedNotification);
		}

		// Token: 0x06009ECC RID: 40652 RVA: 0x00269A48 File Offset: 0x00267C48
		[DebuggerNonUserCode]
		public bool Equals(ReceivedInvitationRemovedNotification other)
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
							bool flag6 = this.InvitationId != other.InvitationId;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Reason != other.Reason;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009ECD RID: 40653 RVA: 0x00269AFC File Offset: 0x00267CFC
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
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009ECE RID: 40654 RVA: 0x00269BA8 File Offset: 0x00267DA8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009ECF RID: 40655 RVA: 0x00269BC0 File Offset: 0x00267DC0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009ED0 RID: 40656 RVA: 0x00269BCC File Offset: 0x00267DCC
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
			bool hasInvitationId = this.HasInvitationId;
			if (hasInvitationId)
			{
				output.WriteRawTag(25);
				output.WriteFixed64(this.InvitationId);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Reason);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009ED1 RID: 40657 RVA: 0x00269C88 File Offset: 0x00267E88
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
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009ED2 RID: 40658 RVA: 0x00269D2C File Offset: 0x00267F2C
		[DebuggerNonUserCode]
		public void MergeFrom(ReceivedInvitationRemovedNotification other)
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

		// Token: 0x06009ED3 RID: 40659 RVA: 0x00269E0F File Offset: 0x0026800F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009ED4 RID: 40660 RVA: 0x00269E1C File Offset: 0x0026801C
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
							goto IL_002C;
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
				else if (num3 != 25U)
				{
					if (num3 != 32U)
					{
						goto IL_002C;
					}
					this.Reason = (InvitationRemovedReason)input.ReadEnum();
				}
				else
				{
					this.InvitationId = input.ReadFixed64();
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400478C RID: 18316
		private static readonly MessageParser<ReceivedInvitationRemovedNotification> _parser = new MessageParser<ReceivedInvitationRemovedNotification>(() => new ReceivedInvitationRemovedNotification());

		// Token: 0x0400478D RID: 18317
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400478E RID: 18318
		private int _hasBits0;

		// Token: 0x0400478F RID: 18319
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04004790 RID: 18320
		private GameAccountHandle agentId_;

		// Token: 0x04004791 RID: 18321
		public const int SubscriberIdFieldNumber = 2;

		// Token: 0x04004792 RID: 18322
		private GameAccountHandle subscriberId_;

		// Token: 0x04004793 RID: 18323
		public const int InvitationIdFieldNumber = 3;

		// Token: 0x04004794 RID: 18324
		private static readonly ulong InvitationIdDefaultValue = 0UL;

		// Token: 0x04004795 RID: 18325
		private ulong invitationId_;

		// Token: 0x04004796 RID: 18326
		public const int ReasonFieldNumber = 4;

		// Token: 0x04004797 RID: 18327
		private static readonly InvitationRemovedReason ReasonDefaultValue = InvitationRemovedReason.Accepted;

		// Token: 0x04004798 RID: 18328
		private InvitationRemovedReason reason_;
	}
}
