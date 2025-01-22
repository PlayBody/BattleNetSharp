using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004B6 RID: 1206
	public sealed class GetInvitationRequest : IMessage<GetInvitationRequest>, IMessage, IEquatable<GetInvitationRequest>, IDeepCloneable<GetInvitationRequest>, IBufferMessage
	{
		// Token: 0x17002552 RID: 9554
		// (get) Token: 0x06007552 RID: 30034 RVA: 0x001C9DE4 File Offset: 0x001C7FE4
		[DebuggerNonUserCode]
		public static MessageParser<GetInvitationRequest> Parser
		{
			get
			{
				return GetInvitationRequest._parser;
			}
		}

		// Token: 0x17002553 RID: 9555
		// (get) Token: 0x06007553 RID: 30035 RVA: 0x001C9DFC File Offset: 0x001C7FFC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[27];
			}
		}

		// Token: 0x17002554 RID: 9556
		// (get) Token: 0x06007554 RID: 30036 RVA: 0x001C9E20 File Offset: 0x001C8020
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetInvitationRequest.Descriptor;
			}
		}

		// Token: 0x06007555 RID: 30037 RVA: 0x001C9E37 File Offset: 0x001C8037
		[DebuggerNonUserCode]
		public GetInvitationRequest()
		{
		}

		// Token: 0x06007556 RID: 30038 RVA: 0x001C9E44 File Offset: 0x001C8044
		[DebuggerNonUserCode]
		public GetInvitationRequest(GetInvitationRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.invitationId_ = other.invitationId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007557 RID: 30039 RVA: 0x001C9EAC File Offset: 0x001C80AC
		[DebuggerNonUserCode]
		public GetInvitationRequest Clone()
		{
			return new GetInvitationRequest(this);
		}

		// Token: 0x17002555 RID: 9557
		// (get) Token: 0x06007558 RID: 30040 RVA: 0x001C9EC4 File Offset: 0x001C80C4
		// (set) Token: 0x06007559 RID: 30041 RVA: 0x001C9EDC File Offset: 0x001C80DC
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

		// Token: 0x17002556 RID: 9558
		// (get) Token: 0x0600755A RID: 30042 RVA: 0x001C9EE8 File Offset: 0x001C80E8
		// (set) Token: 0x0600755B RID: 30043 RVA: 0x001C9F19 File Offset: 0x001C8119
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
					clubIdDefaultValue = GetInvitationRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002557 RID: 9559
		// (get) Token: 0x0600755C RID: 30044 RVA: 0x001C9F34 File Offset: 0x001C8134
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600755D RID: 30045 RVA: 0x001C9F51 File Offset: 0x001C8151
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002558 RID: 9560
		// (get) Token: 0x0600755E RID: 30046 RVA: 0x001C9F64 File Offset: 0x001C8164
		// (set) Token: 0x0600755F RID: 30047 RVA: 0x001C9F95 File Offset: 0x001C8195
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
					invitationIdDefaultValue = GetInvitationRequest.InvitationIdDefaultValue;
				}
				return invitationIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.invitationId_ = value;
			}
		}

		// Token: 0x17002559 RID: 9561
		// (get) Token: 0x06007560 RID: 30048 RVA: 0x001C9FB0 File Offset: 0x001C81B0
		[DebuggerNonUserCode]
		public bool HasInvitationId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06007561 RID: 30049 RVA: 0x001C9FCD File Offset: 0x001C81CD
		[DebuggerNonUserCode]
		public void ClearInvitationId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06007562 RID: 30050 RVA: 0x001C9FE0 File Offset: 0x001C81E0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetInvitationRequest);
		}

		// Token: 0x06007563 RID: 30051 RVA: 0x001CA000 File Offset: 0x001C8200
		[DebuggerNonUserCode]
		public bool Equals(GetInvitationRequest other)
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

		// Token: 0x06007564 RID: 30052 RVA: 0x001CA090 File Offset: 0x001C8290
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

		// Token: 0x06007565 RID: 30053 RVA: 0x001CA11C File Offset: 0x001C831C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007566 RID: 30054 RVA: 0x001CA134 File Offset: 0x001C8334
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007567 RID: 30055 RVA: 0x001CA140 File Offset: 0x001C8340
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

		// Token: 0x06007568 RID: 30056 RVA: 0x001CA1D4 File Offset: 0x001C83D4
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

		// Token: 0x06007569 RID: 30057 RVA: 0x001CA258 File Offset: 0x001C8458
		[DebuggerNonUserCode]
		public void MergeFrom(GetInvitationRequest other)
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

		// Token: 0x0600756A RID: 30058 RVA: 0x001CA2FB File Offset: 0x001C84FB
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600756B RID: 30059 RVA: 0x001CA308 File Offset: 0x001C8508
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

		// Token: 0x04003581 RID: 13697
		private static readonly MessageParser<GetInvitationRequest> _parser = new MessageParser<GetInvitationRequest>(() => new GetInvitationRequest());

		// Token: 0x04003582 RID: 13698
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003583 RID: 13699
		private int _hasBits0;

		// Token: 0x04003584 RID: 13700
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003585 RID: 13701
		private MemberId agentId_;

		// Token: 0x04003586 RID: 13702
		public const int ClubIdFieldNumber = 2;

		// Token: 0x04003587 RID: 13703
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003588 RID: 13704
		private ulong clubId_;

		// Token: 0x04003589 RID: 13705
		public const int InvitationIdFieldNumber = 3;

		// Token: 0x0400358A RID: 13706
		private static readonly ulong InvitationIdDefaultValue = 0UL;

		// Token: 0x0400358B RID: 13707
		private ulong invitationId_;
	}
}
