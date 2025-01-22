using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004E5 RID: 1253
	public sealed class GetStreamHistoryRequest : IMessage<GetStreamHistoryRequest>, IMessage, IEquatable<GetStreamHistoryRequest>, IDeepCloneable<GetStreamHistoryRequest>, IBufferMessage
	{
		// Token: 0x17002698 RID: 9880
		// (get) Token: 0x060079DA RID: 31194 RVA: 0x001D9AC8 File Offset: 0x001D7CC8
		[DebuggerNonUserCode]
		public static MessageParser<GetStreamHistoryRequest> Parser
		{
			get
			{
				return GetStreamHistoryRequest._parser;
			}
		}

		// Token: 0x17002699 RID: 9881
		// (get) Token: 0x060079DB RID: 31195 RVA: 0x001D9AE0 File Offset: 0x001D7CE0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[74];
			}
		}

		// Token: 0x1700269A RID: 9882
		// (get) Token: 0x060079DC RID: 31196 RVA: 0x001D9B04 File Offset: 0x001D7D04
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetStreamHistoryRequest.Descriptor;
			}
		}

		// Token: 0x060079DD RID: 31197 RVA: 0x001D9B1B File Offset: 0x001D7D1B
		[DebuggerNonUserCode]
		public GetStreamHistoryRequest()
		{
		}

		// Token: 0x060079DE RID: 31198 RVA: 0x001D9B28 File Offset: 0x001D7D28
		[DebuggerNonUserCode]
		public GetStreamHistoryRequest(GetStreamHistoryRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.streamId_ = other.streamId_;
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060079DF RID: 31199 RVA: 0x001D9BAC File Offset: 0x001D7DAC
		[DebuggerNonUserCode]
		public GetStreamHistoryRequest Clone()
		{
			return new GetStreamHistoryRequest(this);
		}

		// Token: 0x1700269B RID: 9883
		// (get) Token: 0x060079E0 RID: 31200 RVA: 0x001D9BC4 File Offset: 0x001D7DC4
		// (set) Token: 0x060079E1 RID: 31201 RVA: 0x001D9BDC File Offset: 0x001D7DDC
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

		// Token: 0x1700269C RID: 9884
		// (get) Token: 0x060079E2 RID: 31202 RVA: 0x001D9BE8 File Offset: 0x001D7DE8
		// (set) Token: 0x060079E3 RID: 31203 RVA: 0x001D9C19 File Offset: 0x001D7E19
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
					clubIdDefaultValue = GetStreamHistoryRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x1700269D RID: 9885
		// (get) Token: 0x060079E4 RID: 31204 RVA: 0x001D9C34 File Offset: 0x001D7E34
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060079E5 RID: 31205 RVA: 0x001D9C51 File Offset: 0x001D7E51
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700269E RID: 9886
		// (get) Token: 0x060079E6 RID: 31206 RVA: 0x001D9C64 File Offset: 0x001D7E64
		// (set) Token: 0x060079E7 RID: 31207 RVA: 0x001D9C95 File Offset: 0x001D7E95
		[DebuggerNonUserCode]
		public ulong StreamId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong streamIdDefaultValue;
				if (flag)
				{
					streamIdDefaultValue = this.streamId_;
				}
				else
				{
					streamIdDefaultValue = GetStreamHistoryRequest.StreamIdDefaultValue;
				}
				return streamIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.streamId_ = value;
			}
		}

		// Token: 0x1700269F RID: 9887
		// (get) Token: 0x060079E8 RID: 31208 RVA: 0x001D9CB0 File Offset: 0x001D7EB0
		[DebuggerNonUserCode]
		public bool HasStreamId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060079E9 RID: 31209 RVA: 0x001D9CCD File Offset: 0x001D7ECD
		[DebuggerNonUserCode]
		public void ClearStreamId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170026A0 RID: 9888
		// (get) Token: 0x060079EA RID: 31210 RVA: 0x001D9CE0 File Offset: 0x001D7EE0
		// (set) Token: 0x060079EB RID: 31211 RVA: 0x001D9CF8 File Offset: 0x001D7EF8
		[DebuggerNonUserCode]
		public GetEventOptions Options
		{
			get
			{
				return this.options_;
			}
			set
			{
				this.options_ = value;
			}
		}

		// Token: 0x060079EC RID: 31212 RVA: 0x001D9D04 File Offset: 0x001D7F04
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetStreamHistoryRequest);
		}

		// Token: 0x060079ED RID: 31213 RVA: 0x001D9D24 File Offset: 0x001D7F24
		[DebuggerNonUserCode]
		public bool Equals(GetStreamHistoryRequest other)
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
							bool flag6 = this.StreamId != other.StreamId;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.Options, other.Options);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060079EE RID: 31214 RVA: 0x001D9DD8 File Offset: 0x001D7FD8
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
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				num ^= this.StreamId.GetHashCode();
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				num ^= this.Options.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060079EF RID: 31215 RVA: 0x001D9E80 File Offset: 0x001D8080
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060079F0 RID: 31216 RVA: 0x001D9E98 File Offset: 0x001D8098
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060079F1 RID: 31217 RVA: 0x001D9EA4 File Offset: 0x001D80A4
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
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.StreamId);
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Options);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060079F2 RID: 31218 RVA: 0x001D9F60 File Offset: 0x001D8160
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
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.StreamId);
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060079F3 RID: 31219 RVA: 0x001DA010 File Offset: 0x001D8210
		[DebuggerNonUserCode]
		public void MergeFrom(GetStreamHistoryRequest other)
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
				bool hasStreamId = other.HasStreamId;
				if (hasStreamId)
				{
					this.StreamId = other.StreamId;
				}
				bool flag4 = other.options_ != null;
				if (flag4)
				{
					bool flag5 = this.options_ == null;
					if (flag5)
					{
						this.Options = new GetEventOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060079F4 RID: 31220 RVA: 0x001DA0F3 File Offset: 0x001D82F3
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060079F5 RID: 31221 RVA: 0x001DA100 File Offset: 0x001D8300
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 16U)
				{
					if (num3 != 10U)
					{
						if (num3 != 16U)
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
				else if (num3 != 24U)
				{
					if (num3 != 34U)
					{
						goto IL_002C;
					}
					bool flag2 = this.options_ == null;
					if (flag2)
					{
						this.Options = new GetEventOptions();
					}
					input.ReadMessage(this.Options);
				}
				else
				{
					this.StreamId = input.ReadUInt64();
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003740 RID: 14144
		private static readonly MessageParser<GetStreamHistoryRequest> _parser = new MessageParser<GetStreamHistoryRequest>(() => new GetStreamHistoryRequest());

		// Token: 0x04003741 RID: 14145
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003742 RID: 14146
		private int _hasBits0;

		// Token: 0x04003743 RID: 14147
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003744 RID: 14148
		private MemberId agentId_;

		// Token: 0x04003745 RID: 14149
		public const int ClubIdFieldNumber = 2;

		// Token: 0x04003746 RID: 14150
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003747 RID: 14151
		private ulong clubId_;

		// Token: 0x04003748 RID: 14152
		public const int StreamIdFieldNumber = 3;

		// Token: 0x04003749 RID: 14153
		private static readonly ulong StreamIdDefaultValue = 0UL;

		// Token: 0x0400374A RID: 14154
		private ulong streamId_;

		// Token: 0x0400374B RID: 14155
		public const int OptionsFieldNumber = 4;

		// Token: 0x0400374C RID: 14156
		private GetEventOptions options_;
	}
}
