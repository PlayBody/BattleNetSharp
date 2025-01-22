using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2.Membership
{
	// Token: 0x020006B1 RID: 1713
	public sealed class ReceivedInvitationAddedNotification : IMessage<ReceivedInvitationAddedNotification>, IMessage, IEquatable<ReceivedInvitationAddedNotification>, IDeepCloneable<ReceivedInvitationAddedNotification>, IBufferMessage
	{
		// Token: 0x17003140 RID: 12608
		// (get) Token: 0x06009EA2 RID: 40610 RVA: 0x00269204 File Offset: 0x00267404
		[DebuggerNonUserCode]
		public static MessageParser<ReceivedInvitationAddedNotification> Parser
		{
			get
			{
				return ReceivedInvitationAddedNotification._parser;
			}
		}

		// Token: 0x17003141 RID: 12609
		// (get) Token: 0x06009EA3 RID: 40611 RVA: 0x0026921C File Offset: 0x0026741C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelMembershipServiceReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x17003142 RID: 12610
		// (get) Token: 0x06009EA4 RID: 40612 RVA: 0x00269240 File Offset: 0x00267440
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReceivedInvitationAddedNotification.Descriptor;
			}
		}

		// Token: 0x06009EA5 RID: 40613 RVA: 0x00269257 File Offset: 0x00267457
		[DebuggerNonUserCode]
		public ReceivedInvitationAddedNotification()
		{
		}

		// Token: 0x06009EA6 RID: 40614 RVA: 0x00269264 File Offset: 0x00267464
		[DebuggerNonUserCode]
		public ReceivedInvitationAddedNotification(ReceivedInvitationAddedNotification other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.subscriberId_ = ((other.subscriberId_ != null) ? other.subscriberId_.Clone() : null);
			this.invitation_ = ((other.invitation_ != null) ? other.invitation_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009EA7 RID: 40615 RVA: 0x002692E0 File Offset: 0x002674E0
		[DebuggerNonUserCode]
		public ReceivedInvitationAddedNotification Clone()
		{
			return new ReceivedInvitationAddedNotification(this);
		}

		// Token: 0x17003143 RID: 12611
		// (get) Token: 0x06009EA8 RID: 40616 RVA: 0x002692F8 File Offset: 0x002674F8
		// (set) Token: 0x06009EA9 RID: 40617 RVA: 0x00269310 File Offset: 0x00267510
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

		// Token: 0x17003144 RID: 12612
		// (get) Token: 0x06009EAA RID: 40618 RVA: 0x0026931C File Offset: 0x0026751C
		// (set) Token: 0x06009EAB RID: 40619 RVA: 0x00269334 File Offset: 0x00267534
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

		// Token: 0x17003145 RID: 12613
		// (get) Token: 0x06009EAC RID: 40620 RVA: 0x00269340 File Offset: 0x00267540
		// (set) Token: 0x06009EAD RID: 40621 RVA: 0x00269358 File Offset: 0x00267558
		[DebuggerNonUserCode]
		public ChannelInvitation Invitation
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

		// Token: 0x06009EAE RID: 40622 RVA: 0x00269364 File Offset: 0x00267564
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReceivedInvitationAddedNotification);
		}

		// Token: 0x06009EAF RID: 40623 RVA: 0x00269384 File Offset: 0x00267584
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
						bool flag5 = !object.Equals(this.SubscriberId, other.SubscriberId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Invitation, other.Invitation);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009EB0 RID: 40624 RVA: 0x0026941C File Offset: 0x0026761C
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
			bool flag3 = this.invitation_ != null;
			if (flag3)
			{
				num ^= this.Invitation.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009EB1 RID: 40625 RVA: 0x002694A4 File Offset: 0x002676A4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009EB2 RID: 40626 RVA: 0x002694BC File Offset: 0x002676BC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009EB3 RID: 40627 RVA: 0x002694C8 File Offset: 0x002676C8
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
			bool flag3 = this.invitation_ != null;
			if (flag3)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Invitation);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009EB4 RID: 40628 RVA: 0x00269564 File Offset: 0x00267764
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
			bool flag3 = this.invitation_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Invitation);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009EB5 RID: 40629 RVA: 0x002695F8 File Offset: 0x002677F8
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
				bool flag6 = other.invitation_ != null;
				if (flag6)
				{
					bool flag7 = this.invitation_ == null;
					if (flag7)
					{
						this.Invitation = new ChannelInvitation();
					}
					this.Invitation.MergeFrom(other.Invitation);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009EB6 RID: 40630 RVA: 0x002696E5 File Offset: 0x002678E5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009EB7 RID: 40631 RVA: 0x002696F0 File Offset: 0x002678F0
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
							bool flag = this.invitation_ == null;
							if (flag)
							{
								this.Invitation = new ChannelInvitation();
							}
							input.ReadMessage(this.Invitation);
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

		// Token: 0x04004784 RID: 18308
		private static readonly MessageParser<ReceivedInvitationAddedNotification> _parser = new MessageParser<ReceivedInvitationAddedNotification>(() => new ReceivedInvitationAddedNotification());

		// Token: 0x04004785 RID: 18309
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004786 RID: 18310
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04004787 RID: 18311
		private GameAccountHandle agentId_;

		// Token: 0x04004788 RID: 18312
		public const int SubscriberIdFieldNumber = 2;

		// Token: 0x04004789 RID: 18313
		private GameAccountHandle subscriberId_;

		// Token: 0x0400478A RID: 18314
		public const int InvitationFieldNumber = 3;

		// Token: 0x0400478B RID: 18315
		private ChannelInvitation invitation_;
	}
}
