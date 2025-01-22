using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004AA RID: 1194
	public sealed class GetMemberRequest : IMessage<GetMemberRequest>, IMessage, IEquatable<GetMemberRequest>, IDeepCloneable<GetMemberRequest>, IBufferMessage
	{
		// Token: 0x170024FD RID: 9469
		// (get) Token: 0x06007425 RID: 29733 RVA: 0x001C5960 File Offset: 0x001C3B60
		[DebuggerNonUserCode]
		public static MessageParser<GetMemberRequest> Parser
		{
			get
			{
				return GetMemberRequest._parser;
			}
		}

		// Token: 0x170024FE RID: 9470
		// (get) Token: 0x06007426 RID: 29734 RVA: 0x001C5978 File Offset: 0x001C3B78
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[15];
			}
		}

		// Token: 0x170024FF RID: 9471
		// (get) Token: 0x06007427 RID: 29735 RVA: 0x001C599C File Offset: 0x001C3B9C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMemberRequest.Descriptor;
			}
		}

		// Token: 0x06007428 RID: 29736 RVA: 0x001C59B3 File Offset: 0x001C3BB3
		[DebuggerNonUserCode]
		public GetMemberRequest()
		{
		}

		// Token: 0x06007429 RID: 29737 RVA: 0x001C59C0 File Offset: 0x001C3BC0
		[DebuggerNonUserCode]
		public GetMemberRequest(GetMemberRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.memberId_ = ((other.memberId_ != null) ? other.memberId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600742A RID: 29738 RVA: 0x001C5A38 File Offset: 0x001C3C38
		[DebuggerNonUserCode]
		public GetMemberRequest Clone()
		{
			return new GetMemberRequest(this);
		}

		// Token: 0x17002500 RID: 9472
		// (get) Token: 0x0600742B RID: 29739 RVA: 0x001C5A50 File Offset: 0x001C3C50
		// (set) Token: 0x0600742C RID: 29740 RVA: 0x001C5A68 File Offset: 0x001C3C68
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

		// Token: 0x17002501 RID: 9473
		// (get) Token: 0x0600742D RID: 29741 RVA: 0x001C5A74 File Offset: 0x001C3C74
		// (set) Token: 0x0600742E RID: 29742 RVA: 0x001C5AA5 File Offset: 0x001C3CA5
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
					clubIdDefaultValue = GetMemberRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002502 RID: 9474
		// (get) Token: 0x0600742F RID: 29743 RVA: 0x001C5AC0 File Offset: 0x001C3CC0
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007430 RID: 29744 RVA: 0x001C5ADD File Offset: 0x001C3CDD
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002503 RID: 9475
		// (get) Token: 0x06007431 RID: 29745 RVA: 0x001C5AF0 File Offset: 0x001C3CF0
		// (set) Token: 0x06007432 RID: 29746 RVA: 0x001C5B08 File Offset: 0x001C3D08
		[DebuggerNonUserCode]
		public MemberId MemberId
		{
			get
			{
				return this.memberId_;
			}
			set
			{
				this.memberId_ = value;
			}
		}

		// Token: 0x06007433 RID: 29747 RVA: 0x001C5B14 File Offset: 0x001C3D14
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMemberRequest);
		}

		// Token: 0x06007434 RID: 29748 RVA: 0x001C5B34 File Offset: 0x001C3D34
		[DebuggerNonUserCode]
		public bool Equals(GetMemberRequest other)
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
							bool flag6 = !object.Equals(this.MemberId, other.MemberId);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007435 RID: 29749 RVA: 0x001C5BC8 File Offset: 0x001C3DC8
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
			bool flag2 = this.memberId_ != null;
			if (flag2)
			{
				num ^= this.MemberId.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007436 RID: 29750 RVA: 0x001C5C54 File Offset: 0x001C3E54
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007437 RID: 29751 RVA: 0x001C5C6C File Offset: 0x001C3E6C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007438 RID: 29752 RVA: 0x001C5C78 File Offset: 0x001C3E78
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
			bool flag2 = this.memberId_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.MemberId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007439 RID: 29753 RVA: 0x001C5D10 File Offset: 0x001C3F10
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
			bool flag2 = this.memberId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MemberId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600743A RID: 29754 RVA: 0x001C5DA0 File Offset: 0x001C3FA0
		[DebuggerNonUserCode]
		public void MergeFrom(GetMemberRequest other)
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
				bool flag4 = other.memberId_ != null;
				if (flag4)
				{
					bool flag5 = this.memberId_ == null;
					if (flag5)
					{
						this.MemberId = new MemberId();
					}
					this.MemberId.MergeFrom(other.MemberId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600743B RID: 29755 RVA: 0x001C5E68 File Offset: 0x001C4068
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600743C RID: 29756 RVA: 0x001C5E74 File Offset: 0x001C4074
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.memberId_ == null;
							if (flag)
							{
								this.MemberId = new MemberId();
							}
							input.ReadMessage(this.MemberId);
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

		// Token: 0x0400350A RID: 13578
		private static readonly MessageParser<GetMemberRequest> _parser = new MessageParser<GetMemberRequest>(() => new GetMemberRequest());

		// Token: 0x0400350B RID: 13579
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400350C RID: 13580
		private int _hasBits0;

		// Token: 0x0400350D RID: 13581
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400350E RID: 13582
		private MemberId agentId_;

		// Token: 0x0400350F RID: 13583
		public const int ClubIdFieldNumber = 2;

		// Token: 0x04003510 RID: 13584
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003511 RID: 13585
		private ulong clubId_;

		// Token: 0x04003512 RID: 13586
		public const int MemberIdFieldNumber = 3;

		// Token: 0x04003513 RID: 13587
		private MemberId memberId_;
	}
}
