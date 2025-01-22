using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004B5 RID: 1205
	public sealed class RevokeInvitationRequest : IMessage<RevokeInvitationRequest>, IMessage, IEquatable<RevokeInvitationRequest>, IDeepCloneable<RevokeInvitationRequest>, IBufferMessage
	{
		// Token: 0x1700254A RID: 9546
		// (get) Token: 0x06007537 RID: 30007 RVA: 0x001C97F8 File Offset: 0x001C79F8
		[DebuggerNonUserCode]
		public static MessageParser<RevokeInvitationRequest> Parser
		{
			get
			{
				return RevokeInvitationRequest._parser;
			}
		}

		// Token: 0x1700254B RID: 9547
		// (get) Token: 0x06007538 RID: 30008 RVA: 0x001C9810 File Offset: 0x001C7A10
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[26];
			}
		}

		// Token: 0x1700254C RID: 9548
		// (get) Token: 0x06007539 RID: 30009 RVA: 0x001C9834 File Offset: 0x001C7A34
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RevokeInvitationRequest.Descriptor;
			}
		}

		// Token: 0x0600753A RID: 30010 RVA: 0x001C984B File Offset: 0x001C7A4B
		[DebuggerNonUserCode]
		public RevokeInvitationRequest()
		{
		}

		// Token: 0x0600753B RID: 30011 RVA: 0x001C9858 File Offset: 0x001C7A58
		[DebuggerNonUserCode]
		public RevokeInvitationRequest(RevokeInvitationRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.invitationId_ = other.invitationId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600753C RID: 30012 RVA: 0x001C98C0 File Offset: 0x001C7AC0
		[DebuggerNonUserCode]
		public RevokeInvitationRequest Clone()
		{
			return new RevokeInvitationRequest(this);
		}

		// Token: 0x1700254D RID: 9549
		// (get) Token: 0x0600753D RID: 30013 RVA: 0x001C98D8 File Offset: 0x001C7AD8
		// (set) Token: 0x0600753E RID: 30014 RVA: 0x001C98F0 File Offset: 0x001C7AF0
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

		// Token: 0x1700254E RID: 9550
		// (get) Token: 0x0600753F RID: 30015 RVA: 0x001C98FC File Offset: 0x001C7AFC
		// (set) Token: 0x06007540 RID: 30016 RVA: 0x001C992D File Offset: 0x001C7B2D
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
					clubIdDefaultValue = RevokeInvitationRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x1700254F RID: 9551
		// (get) Token: 0x06007541 RID: 30017 RVA: 0x001C9948 File Offset: 0x001C7B48
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007542 RID: 30018 RVA: 0x001C9965 File Offset: 0x001C7B65
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002550 RID: 9552
		// (get) Token: 0x06007543 RID: 30019 RVA: 0x001C9978 File Offset: 0x001C7B78
		// (set) Token: 0x06007544 RID: 30020 RVA: 0x001C99A9 File Offset: 0x001C7BA9
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
					invitationIdDefaultValue = RevokeInvitationRequest.InvitationIdDefaultValue;
				}
				return invitationIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.invitationId_ = value;
			}
		}

		// Token: 0x17002551 RID: 9553
		// (get) Token: 0x06007545 RID: 30021 RVA: 0x001C99C4 File Offset: 0x001C7BC4
		[DebuggerNonUserCode]
		public bool HasInvitationId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06007546 RID: 30022 RVA: 0x001C99E1 File Offset: 0x001C7BE1
		[DebuggerNonUserCode]
		public void ClearInvitationId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06007547 RID: 30023 RVA: 0x001C99F4 File Offset: 0x001C7BF4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RevokeInvitationRequest);
		}

		// Token: 0x06007548 RID: 30024 RVA: 0x001C9A14 File Offset: 0x001C7C14
		[DebuggerNonUserCode]
		public bool Equals(RevokeInvitationRequest other)
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
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007549 RID: 30025 RVA: 0x001C9AA4 File Offset: 0x001C7CA4
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
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600754A RID: 30026 RVA: 0x001C9B30 File Offset: 0x001C7D30
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600754B RID: 30027 RVA: 0x001C9B48 File Offset: 0x001C7D48
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600754C RID: 30028 RVA: 0x001C9B54 File Offset: 0x001C7D54
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
				output.WriteRawTag(16);
				output.WriteUInt64(this.ClubId);
			}
			bool hasInvitationId = this.HasInvitationId;
			if (hasInvitationId)
			{
				output.WriteRawTag(25);
				output.WriteFixed64(this.InvitationId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600754D RID: 30029 RVA: 0x001C9BE8 File Offset: 0x001C7DE8
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
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600754E RID: 30030 RVA: 0x001C9C6C File Offset: 0x001C7E6C
		[DebuggerNonUserCode]
		public void MergeFrom(RevokeInvitationRequest other)
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
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600754F RID: 30031 RVA: 0x001C9D0F File Offset: 0x001C7F0F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007550 RID: 30032 RVA: 0x001C9D1C File Offset: 0x001C7F1C
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
					if (num3 != 16U)
					{
						if (num3 != 25U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.InvitationId = input.ReadFixed64();
						}
					}
					else
					{
						this.ClubId = input.ReadUInt64();
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

		// Token: 0x04003576 RID: 13686
		private static readonly MessageParser<RevokeInvitationRequest> _parser = new MessageParser<RevokeInvitationRequest>(() => new RevokeInvitationRequest());

		// Token: 0x04003577 RID: 13687
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003578 RID: 13688
		private int _hasBits0;

		// Token: 0x04003579 RID: 13689
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400357A RID: 13690
		private MemberId agentId_;

		// Token: 0x0400357B RID: 13691
		public const int ClubIdFieldNumber = 2;

		// Token: 0x0400357C RID: 13692
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x0400357D RID: 13693
		private ulong clubId_;

		// Token: 0x0400357E RID: 13694
		public const int InvitationIdFieldNumber = 3;

		// Token: 0x0400357F RID: 13695
		private static readonly ulong InvitationIdDefaultValue = 0UL;

		// Token: 0x04003580 RID: 13696
		private ulong invitationId_;
	}
}
