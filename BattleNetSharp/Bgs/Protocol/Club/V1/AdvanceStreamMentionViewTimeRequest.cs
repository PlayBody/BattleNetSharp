using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004E3 RID: 1251
	public sealed class AdvanceStreamMentionViewTimeRequest : IMessage<AdvanceStreamMentionViewTimeRequest>, IMessage, IEquatable<AdvanceStreamMentionViewTimeRequest>, IDeepCloneable<AdvanceStreamMentionViewTimeRequest>, IBufferMessage
	{
		// Token: 0x1700268A RID: 9866
		// (get) Token: 0x060079A8 RID: 31144 RVA: 0x001D901C File Offset: 0x001D721C
		[DebuggerNonUserCode]
		public static MessageParser<AdvanceStreamMentionViewTimeRequest> Parser
		{
			get
			{
				return AdvanceStreamMentionViewTimeRequest._parser;
			}
		}

		// Token: 0x1700268B RID: 9867
		// (get) Token: 0x060079A9 RID: 31145 RVA: 0x001D9034 File Offset: 0x001D7234
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[72];
			}
		}

		// Token: 0x1700268C RID: 9868
		// (get) Token: 0x060079AA RID: 31146 RVA: 0x001D9058 File Offset: 0x001D7258
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdvanceStreamMentionViewTimeRequest.Descriptor;
			}
		}

		// Token: 0x060079AB RID: 31147 RVA: 0x001D906F File Offset: 0x001D726F
		[DebuggerNonUserCode]
		public AdvanceStreamMentionViewTimeRequest()
		{
		}

		// Token: 0x060079AC RID: 31148 RVA: 0x001D907C File Offset: 0x001D727C
		[DebuggerNonUserCode]
		public AdvanceStreamMentionViewTimeRequest(AdvanceStreamMentionViewTimeRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.streamId_ = other.streamId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060079AD RID: 31149 RVA: 0x001D90E4 File Offset: 0x001D72E4
		[DebuggerNonUserCode]
		public AdvanceStreamMentionViewTimeRequest Clone()
		{
			return new AdvanceStreamMentionViewTimeRequest(this);
		}

		// Token: 0x1700268D RID: 9869
		// (get) Token: 0x060079AE RID: 31150 RVA: 0x001D90FC File Offset: 0x001D72FC
		// (set) Token: 0x060079AF RID: 31151 RVA: 0x001D9114 File Offset: 0x001D7314
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

		// Token: 0x1700268E RID: 9870
		// (get) Token: 0x060079B0 RID: 31152 RVA: 0x001D9120 File Offset: 0x001D7320
		// (set) Token: 0x060079B1 RID: 31153 RVA: 0x001D9151 File Offset: 0x001D7351
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
					clubIdDefaultValue = AdvanceStreamMentionViewTimeRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x1700268F RID: 9871
		// (get) Token: 0x060079B2 RID: 31154 RVA: 0x001D916C File Offset: 0x001D736C
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060079B3 RID: 31155 RVA: 0x001D9189 File Offset: 0x001D7389
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002690 RID: 9872
		// (get) Token: 0x060079B4 RID: 31156 RVA: 0x001D919C File Offset: 0x001D739C
		// (set) Token: 0x060079B5 RID: 31157 RVA: 0x001D91CD File Offset: 0x001D73CD
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
					streamIdDefaultValue = AdvanceStreamMentionViewTimeRequest.StreamIdDefaultValue;
				}
				return streamIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.streamId_ = value;
			}
		}

		// Token: 0x17002691 RID: 9873
		// (get) Token: 0x060079B6 RID: 31158 RVA: 0x001D91E8 File Offset: 0x001D73E8
		[DebuggerNonUserCode]
		public bool HasStreamId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060079B7 RID: 31159 RVA: 0x001D9205 File Offset: 0x001D7405
		[DebuggerNonUserCode]
		public void ClearStreamId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060079B8 RID: 31160 RVA: 0x001D9218 File Offset: 0x001D7418
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdvanceStreamMentionViewTimeRequest);
		}

		// Token: 0x060079B9 RID: 31161 RVA: 0x001D9238 File Offset: 0x001D7438
		[DebuggerNonUserCode]
		public bool Equals(AdvanceStreamMentionViewTimeRequest other)
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
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060079BA RID: 31162 RVA: 0x001D92C8 File Offset: 0x001D74C8
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
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060079BB RID: 31163 RVA: 0x001D9354 File Offset: 0x001D7554
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060079BC RID: 31164 RVA: 0x001D936C File Offset: 0x001D756C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060079BD RID: 31165 RVA: 0x001D9378 File Offset: 0x001D7578
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
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060079BE RID: 31166 RVA: 0x001D940C File Offset: 0x001D760C
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
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060079BF RID: 31167 RVA: 0x001D949C File Offset: 0x001D769C
		[DebuggerNonUserCode]
		public void MergeFrom(AdvanceStreamMentionViewTimeRequest other)
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
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060079C0 RID: 31168 RVA: 0x001D953F File Offset: 0x001D773F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060079C1 RID: 31169 RVA: 0x001D954C File Offset: 0x001D774C
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.StreamId = input.ReadUInt64();
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

		// Token: 0x0400372D RID: 14125
		private static readonly MessageParser<AdvanceStreamMentionViewTimeRequest> _parser = new MessageParser<AdvanceStreamMentionViewTimeRequest>(() => new AdvanceStreamMentionViewTimeRequest());

		// Token: 0x0400372E RID: 14126
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400372F RID: 14127
		private int _hasBits0;

		// Token: 0x04003730 RID: 14128
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003731 RID: 14129
		private MemberId agentId_;

		// Token: 0x04003732 RID: 14130
		public const int ClubIdFieldNumber = 2;

		// Token: 0x04003733 RID: 14131
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003734 RID: 14132
		private ulong clubId_;

		// Token: 0x04003735 RID: 14133
		public const int StreamIdFieldNumber = 3;

		// Token: 0x04003736 RID: 14134
		private static readonly ulong StreamIdDefaultValue = 0UL;

		// Token: 0x04003737 RID: 14135
		private ulong streamId_;
	}
}
