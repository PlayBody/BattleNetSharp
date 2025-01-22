using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004CB RID: 1227
	public sealed class GetBanRequest : IMessage<GetBanRequest>, IMessage, IEquatable<GetBanRequest>, IDeepCloneable<GetBanRequest>, IBufferMessage
	{
		// Token: 0x170025DC RID: 9692
		// (get) Token: 0x0600774A RID: 30538 RVA: 0x001D08C8 File Offset: 0x001CEAC8
		[DebuggerNonUserCode]
		public static MessageParser<GetBanRequest> Parser
		{
			get
			{
				return GetBanRequest._parser;
			}
		}

		// Token: 0x170025DD RID: 9693
		// (get) Token: 0x0600774B RID: 30539 RVA: 0x001D08E0 File Offset: 0x001CEAE0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[48];
			}
		}

		// Token: 0x170025DE RID: 9694
		// (get) Token: 0x0600774C RID: 30540 RVA: 0x001D0904 File Offset: 0x001CEB04
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetBanRequest.Descriptor;
			}
		}

		// Token: 0x0600774D RID: 30541 RVA: 0x001D091B File Offset: 0x001CEB1B
		[DebuggerNonUserCode]
		public GetBanRequest()
		{
		}

		// Token: 0x0600774E RID: 30542 RVA: 0x001D0928 File Offset: 0x001CEB28
		[DebuggerNonUserCode]
		public GetBanRequest(GetBanRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.targetId_ = ((other.targetId_ != null) ? other.targetId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600774F RID: 30543 RVA: 0x001D09A0 File Offset: 0x001CEBA0
		[DebuggerNonUserCode]
		public GetBanRequest Clone()
		{
			return new GetBanRequest(this);
		}

		// Token: 0x170025DF RID: 9695
		// (get) Token: 0x06007750 RID: 30544 RVA: 0x001D09B8 File Offset: 0x001CEBB8
		// (set) Token: 0x06007751 RID: 30545 RVA: 0x001D09D0 File Offset: 0x001CEBD0
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

		// Token: 0x170025E0 RID: 9696
		// (get) Token: 0x06007752 RID: 30546 RVA: 0x001D09DC File Offset: 0x001CEBDC
		// (set) Token: 0x06007753 RID: 30547 RVA: 0x001D0A0D File Offset: 0x001CEC0D
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
					clubIdDefaultValue = GetBanRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170025E1 RID: 9697
		// (get) Token: 0x06007754 RID: 30548 RVA: 0x001D0A28 File Offset: 0x001CEC28
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007755 RID: 30549 RVA: 0x001D0A45 File Offset: 0x001CEC45
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170025E2 RID: 9698
		// (get) Token: 0x06007756 RID: 30550 RVA: 0x001D0A58 File Offset: 0x001CEC58
		// (set) Token: 0x06007757 RID: 30551 RVA: 0x001D0A70 File Offset: 0x001CEC70
		[DebuggerNonUserCode]
		public MemberId TargetId
		{
			get
			{
				return this.targetId_;
			}
			set
			{
				this.targetId_ = value;
			}
		}

		// Token: 0x06007758 RID: 30552 RVA: 0x001D0A7C File Offset: 0x001CEC7C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetBanRequest);
		}

		// Token: 0x06007759 RID: 30553 RVA: 0x001D0A9C File Offset: 0x001CEC9C
		[DebuggerNonUserCode]
		public bool Equals(GetBanRequest other)
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
							bool flag6 = !object.Equals(this.TargetId, other.TargetId);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600775A RID: 30554 RVA: 0x001D0B30 File Offset: 0x001CED30
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
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				num ^= this.TargetId.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600775B RID: 30555 RVA: 0x001D0BBC File Offset: 0x001CEDBC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600775C RID: 30556 RVA: 0x001D0BD4 File Offset: 0x001CEDD4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600775D RID: 30557 RVA: 0x001D0BE0 File Offset: 0x001CEDE0
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
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.TargetId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600775E RID: 30558 RVA: 0x001D0C78 File Offset: 0x001CEE78
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
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600775F RID: 30559 RVA: 0x001D0D08 File Offset: 0x001CEF08
		[DebuggerNonUserCode]
		public void MergeFrom(GetBanRequest other)
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
				bool flag4 = other.targetId_ != null;
				if (flag4)
				{
					bool flag5 = this.targetId_ == null;
					if (flag5)
					{
						this.TargetId = new MemberId();
					}
					this.TargetId.MergeFrom(other.TargetId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007760 RID: 30560 RVA: 0x001D0DD0 File Offset: 0x001CEFD0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007761 RID: 30561 RVA: 0x001D0DDC File Offset: 0x001CEFDC
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
							bool flag = this.targetId_ == null;
							if (flag)
							{
								this.TargetId = new MemberId();
							}
							input.ReadMessage(this.TargetId);
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

		// Token: 0x0400363A RID: 13882
		private static readonly MessageParser<GetBanRequest> _parser = new MessageParser<GetBanRequest>(() => new GetBanRequest());

		// Token: 0x0400363B RID: 13883
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400363C RID: 13884
		private int _hasBits0;

		// Token: 0x0400363D RID: 13885
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400363E RID: 13886
		private MemberId agentId_;

		// Token: 0x0400363F RID: 13887
		public const int ClubIdFieldNumber = 2;

		// Token: 0x04003640 RID: 13888
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003641 RID: 13889
		private ulong clubId_;

		// Token: 0x04003642 RID: 13890
		public const int TargetIdFieldNumber = 3;

		// Token: 0x04003643 RID: 13891
		private MemberId targetId_;
	}
}
