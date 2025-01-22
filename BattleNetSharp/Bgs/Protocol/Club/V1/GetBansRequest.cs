using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004CD RID: 1229
	public sealed class GetBansRequest : IMessage<GetBansRequest>, IMessage, IEquatable<GetBansRequest>, IDeepCloneable<GetBansRequest>, IBufferMessage
	{
		// Token: 0x170025E7 RID: 9703
		// (get) Token: 0x06007776 RID: 30582 RVA: 0x001D1228 File Offset: 0x001CF428
		[DebuggerNonUserCode]
		public static MessageParser<GetBansRequest> Parser
		{
			get
			{
				return GetBansRequest._parser;
			}
		}

		// Token: 0x170025E8 RID: 9704
		// (get) Token: 0x06007777 RID: 30583 RVA: 0x001D1240 File Offset: 0x001CF440
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[50];
			}
		}

		// Token: 0x170025E9 RID: 9705
		// (get) Token: 0x06007778 RID: 30584 RVA: 0x001D1264 File Offset: 0x001CF464
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetBansRequest.Descriptor;
			}
		}

		// Token: 0x06007779 RID: 30585 RVA: 0x001D127B File Offset: 0x001CF47B
		[DebuggerNonUserCode]
		public GetBansRequest()
		{
		}

		// Token: 0x0600777A RID: 30586 RVA: 0x001D1288 File Offset: 0x001CF488
		[DebuggerNonUserCode]
		public GetBansRequest(GetBansRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.continuation_ = other.continuation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600777B RID: 30587 RVA: 0x001D12F0 File Offset: 0x001CF4F0
		[DebuggerNonUserCode]
		public GetBansRequest Clone()
		{
			return new GetBansRequest(this);
		}

		// Token: 0x170025EA RID: 9706
		// (get) Token: 0x0600777C RID: 30588 RVA: 0x001D1308 File Offset: 0x001CF508
		// (set) Token: 0x0600777D RID: 30589 RVA: 0x001D1320 File Offset: 0x001CF520
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

		// Token: 0x170025EB RID: 9707
		// (get) Token: 0x0600777E RID: 30590 RVA: 0x001D132C File Offset: 0x001CF52C
		// (set) Token: 0x0600777F RID: 30591 RVA: 0x001D135D File Offset: 0x001CF55D
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
					clubIdDefaultValue = GetBansRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170025EC RID: 9708
		// (get) Token: 0x06007780 RID: 30592 RVA: 0x001D1378 File Offset: 0x001CF578
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007781 RID: 30593 RVA: 0x001D1395 File Offset: 0x001CF595
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170025ED RID: 9709
		// (get) Token: 0x06007782 RID: 30594 RVA: 0x001D13A8 File Offset: 0x001CF5A8
		// (set) Token: 0x06007783 RID: 30595 RVA: 0x001D13D9 File Offset: 0x001CF5D9
		[DebuggerNonUserCode]
		public ulong Continuation
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong continuationDefaultValue;
				if (flag)
				{
					continuationDefaultValue = this.continuation_;
				}
				else
				{
					continuationDefaultValue = GetBansRequest.ContinuationDefaultValue;
				}
				return continuationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.continuation_ = value;
			}
		}

		// Token: 0x170025EE RID: 9710
		// (get) Token: 0x06007784 RID: 30596 RVA: 0x001D13F4 File Offset: 0x001CF5F4
		[DebuggerNonUserCode]
		public bool HasContinuation
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06007785 RID: 30597 RVA: 0x001D1411 File Offset: 0x001CF611
		[DebuggerNonUserCode]
		public void ClearContinuation()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06007786 RID: 30598 RVA: 0x001D1424 File Offset: 0x001CF624
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetBansRequest);
		}

		// Token: 0x06007787 RID: 30599 RVA: 0x001D1444 File Offset: 0x001CF644
		[DebuggerNonUserCode]
		public bool Equals(GetBansRequest other)
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
							bool flag6 = this.Continuation != other.Continuation;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007788 RID: 30600 RVA: 0x001D14D4 File Offset: 0x001CF6D4
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
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				num ^= this.Continuation.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007789 RID: 30601 RVA: 0x001D1560 File Offset: 0x001CF760
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600778A RID: 30602 RVA: 0x001D1578 File Offset: 0x001CF778
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600778B RID: 30603 RVA: 0x001D1584 File Offset: 0x001CF784
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
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.Continuation);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600778C RID: 30604 RVA: 0x001D1618 File Offset: 0x001CF818
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
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Continuation);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600778D RID: 30605 RVA: 0x001D16A8 File Offset: 0x001CF8A8
		[DebuggerNonUserCode]
		public void MergeFrom(GetBansRequest other)
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
				bool hasContinuation = other.HasContinuation;
				if (hasContinuation)
				{
					this.Continuation = other.Continuation;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600778E RID: 30606 RVA: 0x001D174B File Offset: 0x001CF94B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600778F RID: 30607 RVA: 0x001D1758 File Offset: 0x001CF958
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
							this.Continuation = input.ReadUInt64();
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

		// Token: 0x04003648 RID: 13896
		private static readonly MessageParser<GetBansRequest> _parser = new MessageParser<GetBansRequest>(() => new GetBansRequest());

		// Token: 0x04003649 RID: 13897
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400364A RID: 13898
		private int _hasBits0;

		// Token: 0x0400364B RID: 13899
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400364C RID: 13900
		private MemberId agentId_;

		// Token: 0x0400364D RID: 13901
		public const int ClubIdFieldNumber = 2;

		// Token: 0x0400364E RID: 13902
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x0400364F RID: 13903
		private ulong clubId_;

		// Token: 0x04003650 RID: 13904
		public const int ContinuationFieldNumber = 3;

		// Token: 0x04003651 RID: 13905
		private static readonly ulong ContinuationDefaultValue = 0UL;

		// Token: 0x04003652 RID: 13906
		private ulong continuation_;
	}
}
