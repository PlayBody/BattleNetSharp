using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004E7 RID: 1255
	public sealed class GetStreamMessageRequest : IMessage<GetStreamMessageRequest>, IMessage, IEquatable<GetStreamMessageRequest>, IDeepCloneable<GetStreamMessageRequest>, IBufferMessage
	{
		// Token: 0x170026A7 RID: 9895
		// (get) Token: 0x06007A0D RID: 31245 RVA: 0x001DA64C File Offset: 0x001D884C
		[DebuggerNonUserCode]
		public static MessageParser<GetStreamMessageRequest> Parser
		{
			get
			{
				return GetStreamMessageRequest._parser;
			}
		}

		// Token: 0x170026A8 RID: 9896
		// (get) Token: 0x06007A0E RID: 31246 RVA: 0x001DA664 File Offset: 0x001D8864
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[76];
			}
		}

		// Token: 0x170026A9 RID: 9897
		// (get) Token: 0x06007A0F RID: 31247 RVA: 0x001DA688 File Offset: 0x001D8888
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetStreamMessageRequest.Descriptor;
			}
		}

		// Token: 0x06007A10 RID: 31248 RVA: 0x001DA69F File Offset: 0x001D889F
		[DebuggerNonUserCode]
		public GetStreamMessageRequest()
		{
		}

		// Token: 0x06007A11 RID: 31249 RVA: 0x001DA6AC File Offset: 0x001D88AC
		[DebuggerNonUserCode]
		public GetStreamMessageRequest(GetStreamMessageRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.streamId_ = other.streamId_;
			this.messageId_ = ((other.messageId_ != null) ? other.messageId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007A12 RID: 31250 RVA: 0x001DA730 File Offset: 0x001D8930
		[DebuggerNonUserCode]
		public GetStreamMessageRequest Clone()
		{
			return new GetStreamMessageRequest(this);
		}

		// Token: 0x170026AA RID: 9898
		// (get) Token: 0x06007A13 RID: 31251 RVA: 0x001DA748 File Offset: 0x001D8948
		// (set) Token: 0x06007A14 RID: 31252 RVA: 0x001DA760 File Offset: 0x001D8960
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

		// Token: 0x170026AB RID: 9899
		// (get) Token: 0x06007A15 RID: 31253 RVA: 0x001DA76C File Offset: 0x001D896C
		// (set) Token: 0x06007A16 RID: 31254 RVA: 0x001DA79D File Offset: 0x001D899D
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
					clubIdDefaultValue = GetStreamMessageRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170026AC RID: 9900
		// (get) Token: 0x06007A17 RID: 31255 RVA: 0x001DA7B8 File Offset: 0x001D89B8
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007A18 RID: 31256 RVA: 0x001DA7D5 File Offset: 0x001D89D5
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170026AD RID: 9901
		// (get) Token: 0x06007A19 RID: 31257 RVA: 0x001DA7E8 File Offset: 0x001D89E8
		// (set) Token: 0x06007A1A RID: 31258 RVA: 0x001DA819 File Offset: 0x001D8A19
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
					streamIdDefaultValue = GetStreamMessageRequest.StreamIdDefaultValue;
				}
				return streamIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.streamId_ = value;
			}
		}

		// Token: 0x170026AE RID: 9902
		// (get) Token: 0x06007A1B RID: 31259 RVA: 0x001DA834 File Offset: 0x001D8A34
		[DebuggerNonUserCode]
		public bool HasStreamId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06007A1C RID: 31260 RVA: 0x001DA851 File Offset: 0x001D8A51
		[DebuggerNonUserCode]
		public void ClearStreamId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170026AF RID: 9903
		// (get) Token: 0x06007A1D RID: 31261 RVA: 0x001DA864 File Offset: 0x001D8A64
		// (set) Token: 0x06007A1E RID: 31262 RVA: 0x001DA87C File Offset: 0x001D8A7C
		[DebuggerNonUserCode]
		public MessageId MessageId
		{
			get
			{
				return this.messageId_;
			}
			set
			{
				this.messageId_ = value;
			}
		}

		// Token: 0x06007A1F RID: 31263 RVA: 0x001DA888 File Offset: 0x001D8A88
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetStreamMessageRequest);
		}

		// Token: 0x06007A20 RID: 31264 RVA: 0x001DA8A8 File Offset: 0x001D8AA8
		[DebuggerNonUserCode]
		public bool Equals(GetStreamMessageRequest other)
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
								bool flag7 = !object.Equals(this.MessageId, other.MessageId);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007A21 RID: 31265 RVA: 0x001DA95C File Offset: 0x001D8B5C
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
			bool flag2 = this.messageId_ != null;
			if (flag2)
			{
				num ^= this.MessageId.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007A22 RID: 31266 RVA: 0x001DAA04 File Offset: 0x001D8C04
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007A23 RID: 31267 RVA: 0x001DAA1C File Offset: 0x001D8C1C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007A24 RID: 31268 RVA: 0x001DAA28 File Offset: 0x001D8C28
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
			bool flag2 = this.messageId_ != null;
			if (flag2)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.MessageId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007A25 RID: 31269 RVA: 0x001DAAE4 File Offset: 0x001D8CE4
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
			bool flag2 = this.messageId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MessageId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007A26 RID: 31270 RVA: 0x001DAB94 File Offset: 0x001D8D94
		[DebuggerNonUserCode]
		public void MergeFrom(GetStreamMessageRequest other)
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
				bool flag4 = other.messageId_ != null;
				if (flag4)
				{
					bool flag5 = this.messageId_ == null;
					if (flag5)
					{
						this.MessageId = new MessageId();
					}
					this.MessageId.MergeFrom(other.MessageId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007A27 RID: 31271 RVA: 0x001DAC77 File Offset: 0x001D8E77
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007A28 RID: 31272 RVA: 0x001DAC84 File Offset: 0x001D8E84
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
					bool flag2 = this.messageId_ == null;
					if (flag2)
					{
						this.MessageId = new MessageId();
					}
					input.ReadMessage(this.MessageId);
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

		// Token: 0x04003756 RID: 14166
		private static readonly MessageParser<GetStreamMessageRequest> _parser = new MessageParser<GetStreamMessageRequest>(() => new GetStreamMessageRequest());

		// Token: 0x04003757 RID: 14167
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003758 RID: 14168
		private int _hasBits0;

		// Token: 0x04003759 RID: 14169
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400375A RID: 14170
		private MemberId agentId_;

		// Token: 0x0400375B RID: 14171
		public const int ClubIdFieldNumber = 2;

		// Token: 0x0400375C RID: 14172
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x0400375D RID: 14173
		private ulong clubId_;

		// Token: 0x0400375E RID: 14174
		public const int StreamIdFieldNumber = 3;

		// Token: 0x0400375F RID: 14175
		private static readonly ulong StreamIdDefaultValue = 0UL;

		// Token: 0x04003760 RID: 14176
		private ulong streamId_;

		// Token: 0x04003761 RID: 14177
		public const int MessageIdFieldNumber = 4;

		// Token: 0x04003762 RID: 14178
		private MessageId messageId_;
	}
}
