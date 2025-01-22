using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1.Membership
{
	// Token: 0x02000512 RID: 1298
	public sealed class ReceivedInvitationRemovedNotification : IMessage<ReceivedInvitationRemovedNotification>, IMessage, IEquatable<ReceivedInvitationRemovedNotification>, IDeepCloneable<ReceivedInvitationRemovedNotification>, IBufferMessage
	{
		// Token: 0x17002826 RID: 10278
		// (get) Token: 0x06007E7E RID: 32382 RVA: 0x001ECA5C File Offset: 0x001EAC5C
		[DebuggerNonUserCode]
		public static MessageParser<ReceivedInvitationRemovedNotification> Parser
		{
			get
			{
				return ReceivedInvitationRemovedNotification._parser;
			}
		}

		// Token: 0x17002827 RID: 10279
		// (get) Token: 0x06007E7F RID: 32383 RVA: 0x001ECA74 File Offset: 0x001EAC74
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMembershipListenerReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17002828 RID: 10280
		// (get) Token: 0x06007E80 RID: 32384 RVA: 0x001ECA98 File Offset: 0x001EAC98
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReceivedInvitationRemovedNotification.Descriptor;
			}
		}

		// Token: 0x06007E81 RID: 32385 RVA: 0x001ECAAF File Offset: 0x001EACAF
		[DebuggerNonUserCode]
		public ReceivedInvitationRemovedNotification()
		{
		}

		// Token: 0x06007E82 RID: 32386 RVA: 0x001ECABC File Offset: 0x001EACBC
		[DebuggerNonUserCode]
		public ReceivedInvitationRemovedNotification(ReceivedInvitationRemovedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.invitationId_ = other.invitationId_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007E83 RID: 32387 RVA: 0x001ECB24 File Offset: 0x001EAD24
		[DebuggerNonUserCode]
		public ReceivedInvitationRemovedNotification Clone()
		{
			return new ReceivedInvitationRemovedNotification(this);
		}

		// Token: 0x17002829 RID: 10281
		// (get) Token: 0x06007E84 RID: 32388 RVA: 0x001ECB3C File Offset: 0x001EAD3C
		// (set) Token: 0x06007E85 RID: 32389 RVA: 0x001ECB54 File Offset: 0x001EAD54
		[DebuggerNonUserCode]
		public MemberId AgentId
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

		// Token: 0x1700282A RID: 10282
		// (get) Token: 0x06007E86 RID: 32390 RVA: 0x001ECB60 File Offset: 0x001EAD60
		// (set) Token: 0x06007E87 RID: 32391 RVA: 0x001ECB91 File Offset: 0x001EAD91
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

		// Token: 0x1700282B RID: 10283
		// (get) Token: 0x06007E88 RID: 32392 RVA: 0x001ECBAC File Offset: 0x001EADAC
		[DebuggerNonUserCode]
		public bool HasInvitationId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007E89 RID: 32393 RVA: 0x001ECBC9 File Offset: 0x001EADC9
		[DebuggerNonUserCode]
		public void ClearInvitationId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700282C RID: 10284
		// (get) Token: 0x06007E8A RID: 32394 RVA: 0x001ECBDC File Offset: 0x001EADDC
		// (set) Token: 0x06007E8B RID: 32395 RVA: 0x001ECC0D File Offset: 0x001EAE0D
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

		// Token: 0x1700282D RID: 10285
		// (get) Token: 0x06007E8C RID: 32396 RVA: 0x001ECC28 File Offset: 0x001EAE28
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06007E8D RID: 32397 RVA: 0x001ECC45 File Offset: 0x001EAE45
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06007E8E RID: 32398 RVA: 0x001ECC58 File Offset: 0x001EAE58
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReceivedInvitationRemovedNotification);
		}

		// Token: 0x06007E8F RID: 32399 RVA: 0x001ECC78 File Offset: 0x001EAE78
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
						bool flag5 = this.InvitationId != other.InvitationId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Reason != other.Reason;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007E90 RID: 32400 RVA: 0x001ECD08 File Offset: 0x001EAF08
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
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
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007E91 RID: 32401 RVA: 0x001ECD98 File Offset: 0x001EAF98
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007E92 RID: 32402 RVA: 0x001ECDB0 File Offset: 0x001EAFB0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007E93 RID: 32403 RVA: 0x001ECDBC File Offset: 0x001EAFBC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
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
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007E94 RID: 32404 RVA: 0x001ECE50 File Offset: 0x001EB050
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
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
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007E95 RID: 32405 RVA: 0x001ECED4 File Offset: 0x001EB0D4
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
						this.AgentId = new MemberId();
					}
					this.AgentId.MergeFrom(other.AgentId);
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

		// Token: 0x06007E96 RID: 32406 RVA: 0x001ECF77 File Offset: 0x001EB177
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007E97 RID: 32407 RVA: 0x001ECF84 File Offset: 0x001EB184
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
					if (num3 != 25U)
					{
						if (num3 != 32U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Reason = (InvitationRemovedReason)input.ReadEnum();
						}
					}
					else
					{
						this.InvitationId = input.ReadFixed64();
					}
				}
				else
				{
					bool flag = this.agentId_ == null;
					if (flag)
					{
						this.AgentId = new MemberId();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x04003984 RID: 14724
		private static readonly MessageParser<ReceivedInvitationRemovedNotification> _parser = new MessageParser<ReceivedInvitationRemovedNotification>(() => new ReceivedInvitationRemovedNotification());

		// Token: 0x04003985 RID: 14725
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003986 RID: 14726
		private int _hasBits0;

		// Token: 0x04003987 RID: 14727
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003988 RID: 14728
		private MemberId agentId_;

		// Token: 0x04003989 RID: 14729
		public const int InvitationIdFieldNumber = 3;

		// Token: 0x0400398A RID: 14730
		private static readonly ulong InvitationIdDefaultValue = 0UL;

		// Token: 0x0400398B RID: 14731
		private ulong invitationId_;

		// Token: 0x0400398C RID: 14732
		public const int ReasonFieldNumber = 4;

		// Token: 0x0400398D RID: 14733
		private static readonly InvitationRemovedReason ReasonDefaultValue = InvitationRemovedReason.Accepted;

		// Token: 0x0400398E RID: 14734
		private InvitationRemovedReason reason_;
	}
}
