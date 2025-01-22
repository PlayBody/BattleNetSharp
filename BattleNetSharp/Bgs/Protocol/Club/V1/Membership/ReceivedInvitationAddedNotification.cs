using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1.Membership
{
	// Token: 0x02000511 RID: 1297
	public sealed class ReceivedInvitationAddedNotification : IMessage<ReceivedInvitationAddedNotification>, IMessage, IEquatable<ReceivedInvitationAddedNotification>, IDeepCloneable<ReceivedInvitationAddedNotification>, IBufferMessage
	{
		// Token: 0x17002821 RID: 10273
		// (get) Token: 0x06007E69 RID: 32361 RVA: 0x001EC5B0 File Offset: 0x001EA7B0
		[DebuggerNonUserCode]
		public static MessageParser<ReceivedInvitationAddedNotification> Parser
		{
			get
			{
				return ReceivedInvitationAddedNotification._parser;
			}
		}

		// Token: 0x17002822 RID: 10274
		// (get) Token: 0x06007E6A RID: 32362 RVA: 0x001EC5C8 File Offset: 0x001EA7C8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMembershipListenerReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002823 RID: 10275
		// (get) Token: 0x06007E6B RID: 32363 RVA: 0x001EC5EC File Offset: 0x001EA7EC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReceivedInvitationAddedNotification.Descriptor;
			}
		}

		// Token: 0x06007E6C RID: 32364 RVA: 0x001EC603 File Offset: 0x001EA803
		[DebuggerNonUserCode]
		public ReceivedInvitationAddedNotification()
		{
		}

		// Token: 0x06007E6D RID: 32365 RVA: 0x001EC610 File Offset: 0x001EA810
		[DebuggerNonUserCode]
		public ReceivedInvitationAddedNotification(ReceivedInvitationAddedNotification other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.invitation_ = ((other.invitation_ != null) ? other.invitation_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007E6E RID: 32366 RVA: 0x001EC670 File Offset: 0x001EA870
		[DebuggerNonUserCode]
		public ReceivedInvitationAddedNotification Clone()
		{
			return new ReceivedInvitationAddedNotification(this);
		}

		// Token: 0x17002824 RID: 10276
		// (get) Token: 0x06007E6F RID: 32367 RVA: 0x001EC688 File Offset: 0x001EA888
		// (set) Token: 0x06007E70 RID: 32368 RVA: 0x001EC6A0 File Offset: 0x001EA8A0
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

		// Token: 0x17002825 RID: 10277
		// (get) Token: 0x06007E71 RID: 32369 RVA: 0x001EC6AC File Offset: 0x001EA8AC
		// (set) Token: 0x06007E72 RID: 32370 RVA: 0x001EC6C4 File Offset: 0x001EA8C4
		[DebuggerNonUserCode]
		public ClubInvitation Invitation
		{
			get
			{
				return this.invitation_;
			}
			set
			{
				this.invitation_ = value;
			}
		}

		// Token: 0x06007E73 RID: 32371 RVA: 0x001EC6D0 File Offset: 0x001EA8D0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReceivedInvitationAddedNotification);
		}

		// Token: 0x06007E74 RID: 32372 RVA: 0x001EC6F0 File Offset: 0x001EA8F0
		[DebuggerNonUserCode]
		public bool Equals(ReceivedInvitationAddedNotification other)
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
						bool flag5 = !object.Equals(this.Invitation, other.Invitation);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007E75 RID: 32373 RVA: 0x001EC768 File Offset: 0x001EA968
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.invitation_ != null;
			if (flag2)
			{
				num ^= this.Invitation.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007E76 RID: 32374 RVA: 0x001EC7D4 File Offset: 0x001EA9D4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007E77 RID: 32375 RVA: 0x001EC7EC File Offset: 0x001EA9EC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007E78 RID: 32376 RVA: 0x001EC7F8 File Offset: 0x001EA9F8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.invitation_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Invitation);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007E79 RID: 32377 RVA: 0x001EC86C File Offset: 0x001EAA6C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.invitation_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Invitation);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007E7A RID: 32378 RVA: 0x001EC8E0 File Offset: 0x001EAAE0
		[DebuggerNonUserCode]
		public void MergeFrom(ReceivedInvitationAddedNotification other)
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
				bool flag4 = other.invitation_ != null;
				if (flag4)
				{
					bool flag5 = this.invitation_ == null;
					if (flag5)
					{
						this.Invitation = new ClubInvitation();
					}
					this.Invitation.MergeFrom(other.Invitation);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007E7B RID: 32379 RVA: 0x001EC98D File Offset: 0x001EAB8D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007E7C RID: 32380 RVA: 0x001EC998 File Offset: 0x001EAB98
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
					if (num3 != 26U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.invitation_ == null;
						if (flag)
						{
							this.Invitation = new ClubInvitation();
						}
						input.ReadMessage(this.Invitation);
					}
				}
				else
				{
					bool flag2 = this.agentId_ == null;
					if (flag2)
					{
						this.AgentId = new MemberId();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x0400397E RID: 14718
		private static readonly MessageParser<ReceivedInvitationAddedNotification> _parser = new MessageParser<ReceivedInvitationAddedNotification>(() => new ReceivedInvitationAddedNotification());

		// Token: 0x0400397F RID: 14719
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003980 RID: 14720
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003981 RID: 14721
		private MemberId agentId_;

		// Token: 0x04003982 RID: 14722
		public const int InvitationFieldNumber = 3;

		// Token: 0x04003983 RID: 14723
		private ClubInvitation invitation_;
	}
}
