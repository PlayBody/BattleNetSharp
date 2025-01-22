using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004E4 RID: 1252
	public sealed class AdvanceActivityViewTimeRequest : IMessage<AdvanceActivityViewTimeRequest>, IMessage, IEquatable<AdvanceActivityViewTimeRequest>, IDeepCloneable<AdvanceActivityViewTimeRequest>, IBufferMessage
	{
		// Token: 0x17002692 RID: 9874
		// (get) Token: 0x060079C3 RID: 31171 RVA: 0x001D9614 File Offset: 0x001D7814
		[DebuggerNonUserCode]
		public static MessageParser<AdvanceActivityViewTimeRequest> Parser
		{
			get
			{
				return AdvanceActivityViewTimeRequest._parser;
			}
		}

		// Token: 0x17002693 RID: 9875
		// (get) Token: 0x060079C4 RID: 31172 RVA: 0x001D962C File Offset: 0x001D782C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[73];
			}
		}

		// Token: 0x17002694 RID: 9876
		// (get) Token: 0x060079C5 RID: 31173 RVA: 0x001D9650 File Offset: 0x001D7850
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdvanceActivityViewTimeRequest.Descriptor;
			}
		}

		// Token: 0x060079C6 RID: 31174 RVA: 0x001D9667 File Offset: 0x001D7867
		[DebuggerNonUserCode]
		public AdvanceActivityViewTimeRequest()
		{
		}

		// Token: 0x060079C7 RID: 31175 RVA: 0x001D9674 File Offset: 0x001D7874
		[DebuggerNonUserCode]
		public AdvanceActivityViewTimeRequest(AdvanceActivityViewTimeRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060079C8 RID: 31176 RVA: 0x001D96D0 File Offset: 0x001D78D0
		[DebuggerNonUserCode]
		public AdvanceActivityViewTimeRequest Clone()
		{
			return new AdvanceActivityViewTimeRequest(this);
		}

		// Token: 0x17002695 RID: 9877
		// (get) Token: 0x060079C9 RID: 31177 RVA: 0x001D96E8 File Offset: 0x001D78E8
		// (set) Token: 0x060079CA RID: 31178 RVA: 0x001D9700 File Offset: 0x001D7900
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

		// Token: 0x17002696 RID: 9878
		// (get) Token: 0x060079CB RID: 31179 RVA: 0x001D970C File Offset: 0x001D790C
		// (set) Token: 0x060079CC RID: 31180 RVA: 0x001D973D File Offset: 0x001D793D
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
					clubIdDefaultValue = AdvanceActivityViewTimeRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002697 RID: 9879
		// (get) Token: 0x060079CD RID: 31181 RVA: 0x001D9758 File Offset: 0x001D7958
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060079CE RID: 31182 RVA: 0x001D9775 File Offset: 0x001D7975
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060079CF RID: 31183 RVA: 0x001D9788 File Offset: 0x001D7988
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdvanceActivityViewTimeRequest);
		}

		// Token: 0x060079D0 RID: 31184 RVA: 0x001D97A8 File Offset: 0x001D79A8
		[DebuggerNonUserCode]
		public bool Equals(AdvanceActivityViewTimeRequest other)
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
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060079D1 RID: 31185 RVA: 0x001D981C File Offset: 0x001D7A1C
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
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060079D2 RID: 31186 RVA: 0x001D9888 File Offset: 0x001D7A88
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060079D3 RID: 31187 RVA: 0x001D98A0 File Offset: 0x001D7AA0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060079D4 RID: 31188 RVA: 0x001D98AC File Offset: 0x001D7AAC
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
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060079D5 RID: 31189 RVA: 0x001D9920 File Offset: 0x001D7B20
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
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060079D6 RID: 31190 RVA: 0x001D9990 File Offset: 0x001D7B90
		[DebuggerNonUserCode]
		public void MergeFrom(AdvanceActivityViewTimeRequest other)
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
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060079D7 RID: 31191 RVA: 0x001D9A15 File Offset: 0x001D7C15
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060079D8 RID: 31192 RVA: 0x001D9A20 File Offset: 0x001D7C20
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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

		// Token: 0x04003738 RID: 14136
		private static readonly MessageParser<AdvanceActivityViewTimeRequest> _parser = new MessageParser<AdvanceActivityViewTimeRequest>(() => new AdvanceActivityViewTimeRequest());

		// Token: 0x04003739 RID: 14137
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400373A RID: 14138
		private int _hasBits0;

		// Token: 0x0400373B RID: 14139
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400373C RID: 14140
		private MemberId agentId_;

		// Token: 0x0400373D RID: 14141
		public const int ClubIdFieldNumber = 2;

		// Token: 0x0400373E RID: 14142
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x0400373F RID: 14143
		private ulong clubId_;
	}
}
