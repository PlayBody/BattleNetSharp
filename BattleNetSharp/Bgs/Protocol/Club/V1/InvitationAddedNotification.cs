using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000486 RID: 1158
	public sealed class InvitationAddedNotification : IMessage<InvitationAddedNotification>, IMessage, IEquatable<InvitationAddedNotification>, IDeepCloneable<InvitationAddedNotification>, IBufferMessage
	{
		// Token: 0x1700240F RID: 9231
		// (get) Token: 0x060070D7 RID: 28887 RVA: 0x001B7230 File Offset: 0x001B5430
		[DebuggerNonUserCode]
		public static MessageParser<InvitationAddedNotification> Parser
		{
			get
			{
				return InvitationAddedNotification._parser;
			}
		}

		// Token: 0x17002410 RID: 9232
		// (get) Token: 0x060070D8 RID: 28888 RVA: 0x001B7248 File Offset: 0x001B5448
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubNotificationReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x17002411 RID: 9233
		// (get) Token: 0x060070D9 RID: 28889 RVA: 0x001B726C File Offset: 0x001B546C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InvitationAddedNotification.Descriptor;
			}
		}

		// Token: 0x060070DA RID: 28890 RVA: 0x001B7283 File Offset: 0x001B5483
		[DebuggerNonUserCode]
		public InvitationAddedNotification()
		{
		}

		// Token: 0x060070DB RID: 28891 RVA: 0x001B7290 File Offset: 0x001B5490
		[DebuggerNonUserCode]
		public InvitationAddedNotification(InvitationAddedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.invitation_ = ((other.invitation_ != null) ? other.invitation_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060070DC RID: 28892 RVA: 0x001B7308 File Offset: 0x001B5508
		[DebuggerNonUserCode]
		public InvitationAddedNotification Clone()
		{
			return new InvitationAddedNotification(this);
		}

		// Token: 0x17002412 RID: 9234
		// (get) Token: 0x060070DD RID: 28893 RVA: 0x001B7320 File Offset: 0x001B5520
		// (set) Token: 0x060070DE RID: 28894 RVA: 0x001B7338 File Offset: 0x001B5538
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

		// Token: 0x17002413 RID: 9235
		// (get) Token: 0x060070DF RID: 28895 RVA: 0x001B7344 File Offset: 0x001B5544
		// (set) Token: 0x060070E0 RID: 28896 RVA: 0x001B7375 File Offset: 0x001B5575
		[DebuggerNonUserCode]
		public ulong ClubId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong clubIdDefaultValue;
				if (flag)
				{
					clubIdDefaultValue = this.clubId_;
				}
				else
				{
					clubIdDefaultValue = InvitationAddedNotification.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002414 RID: 9236
		// (get) Token: 0x060070E1 RID: 28897 RVA: 0x001B7390 File Offset: 0x001B5590
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060070E2 RID: 28898 RVA: 0x001B73AD File Offset: 0x001B55AD
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002415 RID: 9237
		// (get) Token: 0x060070E3 RID: 28899 RVA: 0x001B73C0 File Offset: 0x001B55C0
		// (set) Token: 0x060070E4 RID: 28900 RVA: 0x001B73D8 File Offset: 0x001B55D8
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

		// Token: 0x060070E5 RID: 28901 RVA: 0x001B73E4 File Offset: 0x001B55E4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as InvitationAddedNotification);
		}

		// Token: 0x060070E6 RID: 28902 RVA: 0x001B7404 File Offset: 0x001B5604
		[DebuggerNonUserCode]
		public bool Equals(InvitationAddedNotification other)
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
						bool flag5 = this.ClubId != other.ClubId;
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

		// Token: 0x060070E7 RID: 28903 RVA: 0x001B7498 File Offset: 0x001B5698
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num ^= this.ClubId.GetHashCode();
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

		// Token: 0x060070E8 RID: 28904 RVA: 0x001B7524 File Offset: 0x001B5724
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060070E9 RID: 28905 RVA: 0x001B753C File Offset: 0x001B573C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060070EA RID: 28906 RVA: 0x001B7548 File Offset: 0x001B5748
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.ClubId);
			}
			bool flag2 = this.invitation_ != null;
			if (flag2)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Invitation);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060070EB RID: 28907 RVA: 0x001B75E0 File Offset: 0x001B57E0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ClubId);
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

		// Token: 0x060070EC RID: 28908 RVA: 0x001B7670 File Offset: 0x001B5870
		[DebuggerNonUserCode]
		public void MergeFrom(InvitationAddedNotification other)
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
				bool hasClubId = other.HasClubId;
				if (hasClubId)
				{
					this.ClubId = other.ClubId;
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

		// Token: 0x060070ED RID: 28909 RVA: 0x001B7738 File Offset: 0x001B5938
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060070EE RID: 28910 RVA: 0x001B7744 File Offset: 0x001B5944
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
					if (num3 != 24U)
					{
						if (num3 != 34U)
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
						this.ClubId = input.ReadUInt64();
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

		// Token: 0x040033BD RID: 13245
		private static readonly MessageParser<InvitationAddedNotification> _parser = new MessageParser<InvitationAddedNotification>(() => new InvitationAddedNotification());

		// Token: 0x040033BE RID: 13246
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033BF RID: 13247
		private int _hasBits0;

		// Token: 0x040033C0 RID: 13248
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040033C1 RID: 13249
		private MemberId agentId_;

		// Token: 0x040033C2 RID: 13250
		public const int ClubIdFieldNumber = 3;

		// Token: 0x040033C3 RID: 13251
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040033C4 RID: 13252
		private ulong clubId_;

		// Token: 0x040033C5 RID: 13253
		public const int InvitationFieldNumber = 4;

		// Token: 0x040033C6 RID: 13254
		private ClubInvitation invitation_;
	}
}
