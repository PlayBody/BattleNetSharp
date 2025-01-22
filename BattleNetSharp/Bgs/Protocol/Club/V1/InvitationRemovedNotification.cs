using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000487 RID: 1159
	public sealed class InvitationRemovedNotification : IMessage<InvitationRemovedNotification>, IMessage, IEquatable<InvitationRemovedNotification>, IDeepCloneable<InvitationRemovedNotification>, IBufferMessage
	{
		// Token: 0x17002416 RID: 9238
		// (get) Token: 0x060070F0 RID: 28912 RVA: 0x001B7828 File Offset: 0x001B5A28
		[DebuggerNonUserCode]
		public static MessageParser<InvitationRemovedNotification> Parser
		{
			get
			{
				return InvitationRemovedNotification._parser;
			}
		}

		// Token: 0x17002417 RID: 9239
		// (get) Token: 0x060070F1 RID: 28913 RVA: 0x001B7840 File Offset: 0x001B5A40
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubNotificationReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x17002418 RID: 9240
		// (get) Token: 0x060070F2 RID: 28914 RVA: 0x001B7864 File Offset: 0x001B5A64
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InvitationRemovedNotification.Descriptor;
			}
		}

		// Token: 0x060070F3 RID: 28915 RVA: 0x001B787B File Offset: 0x001B5A7B
		[DebuggerNonUserCode]
		public InvitationRemovedNotification()
		{
		}

		// Token: 0x060070F4 RID: 28916 RVA: 0x001B7888 File Offset: 0x001B5A88
		[DebuggerNonUserCode]
		public InvitationRemovedNotification(InvitationRemovedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.invitationId_ = other.invitationId_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060070F5 RID: 28917 RVA: 0x001B78FC File Offset: 0x001B5AFC
		[DebuggerNonUserCode]
		public InvitationRemovedNotification Clone()
		{
			return new InvitationRemovedNotification(this);
		}

		// Token: 0x17002419 RID: 9241
		// (get) Token: 0x060070F6 RID: 28918 RVA: 0x001B7914 File Offset: 0x001B5B14
		// (set) Token: 0x060070F7 RID: 28919 RVA: 0x001B792C File Offset: 0x001B5B2C
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

		// Token: 0x1700241A RID: 9242
		// (get) Token: 0x060070F8 RID: 28920 RVA: 0x001B7938 File Offset: 0x001B5B38
		// (set) Token: 0x060070F9 RID: 28921 RVA: 0x001B7969 File Offset: 0x001B5B69
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
					clubIdDefaultValue = InvitationRemovedNotification.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x1700241B RID: 9243
		// (get) Token: 0x060070FA RID: 28922 RVA: 0x001B7984 File Offset: 0x001B5B84
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060070FB RID: 28923 RVA: 0x001B79A1 File Offset: 0x001B5BA1
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700241C RID: 9244
		// (get) Token: 0x060070FC RID: 28924 RVA: 0x001B79B4 File Offset: 0x001B5BB4
		// (set) Token: 0x060070FD RID: 28925 RVA: 0x001B79E5 File Offset: 0x001B5BE5
		[DebuggerNonUserCode]
		public ulong InvitationId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
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
				this._hasBits0 |= 2;
				this.invitationId_ = value;
			}
		}

		// Token: 0x1700241D RID: 9245
		// (get) Token: 0x060070FE RID: 28926 RVA: 0x001B7A00 File Offset: 0x001B5C00
		[DebuggerNonUserCode]
		public bool HasInvitationId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060070FF RID: 28927 RVA: 0x001B7A1D File Offset: 0x001B5C1D
		[DebuggerNonUserCode]
		public void ClearInvitationId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700241E RID: 9246
		// (get) Token: 0x06007100 RID: 28928 RVA: 0x001B7A30 File Offset: 0x001B5C30
		// (set) Token: 0x06007101 RID: 28929 RVA: 0x001B7A61 File Offset: 0x001B5C61
		[DebuggerNonUserCode]
		public InvitationRemovedReason Reason
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
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
				this._hasBits0 |= 4;
				this.reason_ = value;
			}
		}

		// Token: 0x1700241F RID: 9247
		// (get) Token: 0x06007102 RID: 28930 RVA: 0x001B7A7C File Offset: 0x001B5C7C
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06007103 RID: 28931 RVA: 0x001B7A99 File Offset: 0x001B5C99
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06007104 RID: 28932 RVA: 0x001B7AAC File Offset: 0x001B5CAC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as InvitationRemovedNotification);
		}

		// Token: 0x06007105 RID: 28933 RVA: 0x001B7ACC File Offset: 0x001B5CCC
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
						bool flag5 = this.ClubId != other.ClubId;
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

		// Token: 0x06007106 RID: 28934 RVA: 0x001B7B7C File Offset: 0x001B5D7C
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

		// Token: 0x06007107 RID: 28935 RVA: 0x001B7C2C File Offset: 0x001B5E2C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007108 RID: 28936 RVA: 0x001B7C44 File Offset: 0x001B5E44
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007109 RID: 28937 RVA: 0x001B7C50 File Offset: 0x001B5E50
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
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600710A RID: 28938 RVA: 0x001B7D08 File Offset: 0x001B5F08
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

		// Token: 0x0600710B RID: 28939 RVA: 0x001B7DA8 File Offset: 0x001B5FA8
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
						this.AgentId = new MemberId();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool hasClubId = other.HasClubId;
				if (hasClubId)
				{
					this.ClubId = other.ClubId;
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

		// Token: 0x0600710C RID: 28940 RVA: 0x001B7E66 File Offset: 0x001B6066
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600710D RID: 28941 RVA: 0x001B7E74 File Offset: 0x001B6074
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 24U)
				{
					if (num3 != 10U)
					{
						if (num3 != 24U)
						{
							goto IL_002C;
						}
						this.ClubId = input.ReadUInt64();
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
				else if (num3 != 33U)
				{
					if (num3 != 40U)
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

		// Token: 0x040033C7 RID: 13255
		private static readonly MessageParser<InvitationRemovedNotification> _parser = new MessageParser<InvitationRemovedNotification>(() => new InvitationRemovedNotification());

		// Token: 0x040033C8 RID: 13256
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033C9 RID: 13257
		private int _hasBits0;

		// Token: 0x040033CA RID: 13258
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040033CB RID: 13259
		private MemberId agentId_;

		// Token: 0x040033CC RID: 13260
		public const int ClubIdFieldNumber = 3;

		// Token: 0x040033CD RID: 13261
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040033CE RID: 13262
		private ulong clubId_;

		// Token: 0x040033CF RID: 13263
		public const int InvitationIdFieldNumber = 4;

		// Token: 0x040033D0 RID: 13264
		private static readonly ulong InvitationIdDefaultValue = 0UL;

		// Token: 0x040033D1 RID: 13265
		private ulong invitationId_;

		// Token: 0x040033D2 RID: 13266
		public const int ReasonFieldNumber = 5;

		// Token: 0x040033D3 RID: 13267
		private static readonly InvitationRemovedReason ReasonDefaultValue = InvitationRemovedReason.Accepted;

		// Token: 0x040033D4 RID: 13268
		private InvitationRemovedReason reason_;
	}
}
