using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x0200065E RID: 1630
	public sealed class GetChannelRequest : IMessage<GetChannelRequest>, IMessage, IEquatable<GetChannelRequest>, IDeepCloneable<GetChannelRequest>, IBufferMessage
	{
		// Token: 0x17002F2F RID: 12079
		// (get) Token: 0x06009751 RID: 38737 RVA: 0x0024A93C File Offset: 0x00248B3C
		[DebuggerNonUserCode]
		public static MessageParser<GetChannelRequest> Parser
		{
			get
			{
				return GetChannelRequest._parser;
			}
		}

		// Token: 0x17002F30 RID: 12080
		// (get) Token: 0x06009752 RID: 38738 RVA: 0x0024A954 File Offset: 0x00248B54
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002F31 RID: 12081
		// (get) Token: 0x06009753 RID: 38739 RVA: 0x0024A978 File Offset: 0x00248B78
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetChannelRequest.Descriptor;
			}
		}

		// Token: 0x06009754 RID: 38740 RVA: 0x0024A98F File Offset: 0x00248B8F
		[DebuggerNonUserCode]
		public GetChannelRequest()
		{
		}

		// Token: 0x06009755 RID: 38741 RVA: 0x0024A99C File Offset: 0x00248B9C
		[DebuggerNonUserCode]
		public GetChannelRequest(GetChannelRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.fetchAttributes_ = other.fetchAttributes_;
			this.fetchMembers_ = other.fetchMembers_;
			this.fetchInvitations_ = other.fetchInvitations_;
			this.fetchRoles_ = other.fetchRoles_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009756 RID: 38742 RVA: 0x0024AA38 File Offset: 0x00248C38
		[DebuggerNonUserCode]
		public GetChannelRequest Clone()
		{
			return new GetChannelRequest(this);
		}

		// Token: 0x17002F32 RID: 12082
		// (get) Token: 0x06009757 RID: 38743 RVA: 0x0024AA50 File Offset: 0x00248C50
		// (set) Token: 0x06009758 RID: 38744 RVA: 0x0024AA68 File Offset: 0x00248C68
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

		// Token: 0x17002F33 RID: 12083
		// (get) Token: 0x06009759 RID: 38745 RVA: 0x0024AA74 File Offset: 0x00248C74
		// (set) Token: 0x0600975A RID: 38746 RVA: 0x0024AA8C File Offset: 0x00248C8C
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

		// Token: 0x17002F34 RID: 12084
		// (get) Token: 0x0600975B RID: 38747 RVA: 0x0024AA98 File Offset: 0x00248C98
		// (set) Token: 0x0600975C RID: 38748 RVA: 0x0024AAC9 File Offset: 0x00248CC9
		[DebuggerNonUserCode]
		public bool FetchAttributes
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool fetchAttributesDefaultValue;
				if (flag)
				{
					fetchAttributesDefaultValue = this.fetchAttributes_;
				}
				else
				{
					fetchAttributesDefaultValue = GetChannelRequest.FetchAttributesDefaultValue;
				}
				return fetchAttributesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.fetchAttributes_ = value;
			}
		}

		// Token: 0x17002F35 RID: 12085
		// (get) Token: 0x0600975D RID: 38749 RVA: 0x0024AAE4 File Offset: 0x00248CE4
		[DebuggerNonUserCode]
		public bool HasFetchAttributes
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600975E RID: 38750 RVA: 0x0024AB01 File Offset: 0x00248D01
		[DebuggerNonUserCode]
		public void ClearFetchAttributes()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002F36 RID: 12086
		// (get) Token: 0x0600975F RID: 38751 RVA: 0x0024AB14 File Offset: 0x00248D14
		// (set) Token: 0x06009760 RID: 38752 RVA: 0x0024AB45 File Offset: 0x00248D45
		[DebuggerNonUserCode]
		public bool FetchMembers
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool fetchMembersDefaultValue;
				if (flag)
				{
					fetchMembersDefaultValue = this.fetchMembers_;
				}
				else
				{
					fetchMembersDefaultValue = GetChannelRequest.FetchMembersDefaultValue;
				}
				return fetchMembersDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.fetchMembers_ = value;
			}
		}

		// Token: 0x17002F37 RID: 12087
		// (get) Token: 0x06009761 RID: 38753 RVA: 0x0024AB60 File Offset: 0x00248D60
		[DebuggerNonUserCode]
		public bool HasFetchMembers
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06009762 RID: 38754 RVA: 0x0024AB7D File Offset: 0x00248D7D
		[DebuggerNonUserCode]
		public void ClearFetchMembers()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002F38 RID: 12088
		// (get) Token: 0x06009763 RID: 38755 RVA: 0x0024AB90 File Offset: 0x00248D90
		// (set) Token: 0x06009764 RID: 38756 RVA: 0x0024ABC1 File Offset: 0x00248DC1
		[DebuggerNonUserCode]
		public bool FetchInvitations
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool fetchInvitationsDefaultValue;
				if (flag)
				{
					fetchInvitationsDefaultValue = this.fetchInvitations_;
				}
				else
				{
					fetchInvitationsDefaultValue = GetChannelRequest.FetchInvitationsDefaultValue;
				}
				return fetchInvitationsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.fetchInvitations_ = value;
			}
		}

		// Token: 0x17002F39 RID: 12089
		// (get) Token: 0x06009765 RID: 38757 RVA: 0x0024ABDC File Offset: 0x00248DDC
		[DebuggerNonUserCode]
		public bool HasFetchInvitations
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06009766 RID: 38758 RVA: 0x0024ABF9 File Offset: 0x00248DF9
		[DebuggerNonUserCode]
		public void ClearFetchInvitations()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17002F3A RID: 12090
		// (get) Token: 0x06009767 RID: 38759 RVA: 0x0024AC0C File Offset: 0x00248E0C
		// (set) Token: 0x06009768 RID: 38760 RVA: 0x0024AC3D File Offset: 0x00248E3D
		[DebuggerNonUserCode]
		public bool FetchRoles
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool fetchRolesDefaultValue;
				if (flag)
				{
					fetchRolesDefaultValue = this.fetchRoles_;
				}
				else
				{
					fetchRolesDefaultValue = GetChannelRequest.FetchRolesDefaultValue;
				}
				return fetchRolesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.fetchRoles_ = value;
			}
		}

		// Token: 0x17002F3B RID: 12091
		// (get) Token: 0x06009769 RID: 38761 RVA: 0x0024AC58 File Offset: 0x00248E58
		[DebuggerNonUserCode]
		public bool HasFetchRoles
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600976A RID: 38762 RVA: 0x0024AC75 File Offset: 0x00248E75
		[DebuggerNonUserCode]
		public void ClearFetchRoles()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x0600976B RID: 38763 RVA: 0x0024AC88 File Offset: 0x00248E88
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetChannelRequest);
		}

		// Token: 0x0600976C RID: 38764 RVA: 0x0024ACA8 File Offset: 0x00248EA8
		[DebuggerNonUserCode]
		public bool Equals(GetChannelRequest other)
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
						bool flag5 = !object.Equals(this.ChannelId, other.ChannelId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.FetchAttributes != other.FetchAttributes;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.FetchMembers != other.FetchMembers;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.FetchInvitations != other.FetchInvitations;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.FetchRoles != other.FetchRoles;
										flag2 = !flag9 && object.Equals(this._unknownFields, other._unknownFields);
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600976D RID: 38765 RVA: 0x0024AD98 File Offset: 0x00248F98
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			bool hasFetchAttributes = this.HasFetchAttributes;
			if (hasFetchAttributes)
			{
				num ^= this.FetchAttributes.GetHashCode();
			}
			bool hasFetchMembers = this.HasFetchMembers;
			if (hasFetchMembers)
			{
				num ^= this.FetchMembers.GetHashCode();
			}
			bool hasFetchInvitations = this.HasFetchInvitations;
			if (hasFetchInvitations)
			{
				num ^= this.FetchInvitations.GetHashCode();
			}
			bool hasFetchRoles = this.HasFetchRoles;
			if (hasFetchRoles)
			{
				num ^= this.FetchRoles.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600976E RID: 38766 RVA: 0x0024AE7C File Offset: 0x0024907C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600976F RID: 38767 RVA: 0x0024AE94 File Offset: 0x00249094
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009770 RID: 38768 RVA: 0x0024AEA0 File Offset: 0x002490A0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ChannelId);
			}
			bool hasFetchAttributes = this.HasFetchAttributes;
			if (hasFetchAttributes)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.FetchAttributes);
			}
			bool hasFetchMembers = this.HasFetchMembers;
			if (hasFetchMembers)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.FetchMembers);
			}
			bool hasFetchInvitations = this.HasFetchInvitations;
			if (hasFetchInvitations)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.FetchInvitations);
			}
			bool hasFetchRoles = this.HasFetchRoles;
			if (hasFetchRoles)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.FetchRoles);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009771 RID: 38769 RVA: 0x0024AFA4 File Offset: 0x002491A4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
			}
			bool hasFetchAttributes = this.HasFetchAttributes;
			if (hasFetchAttributes)
			{
				num += 2;
			}
			bool hasFetchMembers = this.HasFetchMembers;
			if (hasFetchMembers)
			{
				num += 2;
			}
			bool hasFetchInvitations = this.HasFetchInvitations;
			if (hasFetchInvitations)
			{
				num += 2;
			}
			bool hasFetchRoles = this.HasFetchRoles;
			if (hasFetchRoles)
			{
				num += 2;
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009772 RID: 38770 RVA: 0x0024B060 File Offset: 0x00249260
		[DebuggerNonUserCode]
		public void MergeFrom(GetChannelRequest other)
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
				bool flag4 = other.channelId_ != null;
				if (flag4)
				{
					bool flag5 = this.channelId_ == null;
					if (flag5)
					{
						this.ChannelId = new ChannelId();
					}
					this.ChannelId.MergeFrom(other.ChannelId);
				}
				bool hasFetchAttributes = other.HasFetchAttributes;
				if (hasFetchAttributes)
				{
					this.FetchAttributes = other.FetchAttributes;
				}
				bool hasFetchMembers = other.HasFetchMembers;
				if (hasFetchMembers)
				{
					this.FetchMembers = other.FetchMembers;
				}
				bool hasFetchInvitations = other.HasFetchInvitations;
				if (hasFetchInvitations)
				{
					this.FetchInvitations = other.FetchInvitations;
				}
				bool hasFetchRoles = other.HasFetchRoles;
				if (hasFetchRoles)
				{
					this.FetchRoles = other.FetchRoles;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009773 RID: 38771 RVA: 0x0024B179 File Offset: 0x00249379
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009774 RID: 38772 RVA: 0x0024B184 File Offset: 0x00249384
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 40U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							if (num3 != 40U)
							{
								goto IL_0046;
							}
							this.FetchAttributes = input.ReadBool();
						}
						else
						{
							bool flag = this.channelId_ == null;
							if (flag)
							{
								this.ChannelId = new ChannelId();
							}
							input.ReadMessage(this.ChannelId);
						}
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
				else if (num3 != 48U)
				{
					if (num3 != 56U)
					{
						if (num3 != 64U)
						{
							goto IL_0046;
						}
						this.FetchRoles = input.ReadBool();
					}
					else
					{
						this.FetchInvitations = input.ReadBool();
					}
				}
				else
				{
					this.FetchMembers = input.ReadBool();
				}
				continue;
				IL_0046:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400443F RID: 17471
		private static readonly MessageParser<GetChannelRequest> _parser = new MessageParser<GetChannelRequest>(() => new GetChannelRequest());

		// Token: 0x04004440 RID: 17472
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004441 RID: 17473
		private int _hasBits0;

		// Token: 0x04004442 RID: 17474
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04004443 RID: 17475
		private GameAccountHandle agentId_;

		// Token: 0x04004444 RID: 17476
		public const int ChannelIdFieldNumber = 2;

		// Token: 0x04004445 RID: 17477
		private ChannelId channelId_;

		// Token: 0x04004446 RID: 17478
		public const int FetchAttributesFieldNumber = 5;

		// Token: 0x04004447 RID: 17479
		private static readonly bool FetchAttributesDefaultValue = false;

		// Token: 0x04004448 RID: 17480
		private bool fetchAttributes_;

		// Token: 0x04004449 RID: 17481
		public const int FetchMembersFieldNumber = 6;

		// Token: 0x0400444A RID: 17482
		private static readonly bool FetchMembersDefaultValue = false;

		// Token: 0x0400444B RID: 17483
		private bool fetchMembers_;

		// Token: 0x0400444C RID: 17484
		public const int FetchInvitationsFieldNumber = 7;

		// Token: 0x0400444D RID: 17485
		private static readonly bool FetchInvitationsDefaultValue = false;

		// Token: 0x0400444E RID: 17486
		private bool fetchInvitations_;

		// Token: 0x0400444F RID: 17487
		public const int FetchRolesFieldNumber = 8;

		// Token: 0x04004450 RID: 17488
		private static readonly bool FetchRolesDefaultValue = false;

		// Token: 0x04004451 RID: 17489
		private bool fetchRoles_;
	}
}
