using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004AC RID: 1196
	public sealed class GetMembersRequest : IMessage<GetMembersRequest>, IMessage, IEquatable<GetMembersRequest>, IDeepCloneable<GetMembersRequest>, IBufferMessage
	{
		// Token: 0x17002508 RID: 9480
		// (get) Token: 0x06007451 RID: 29777 RVA: 0x001C62C0 File Offset: 0x001C44C0
		[DebuggerNonUserCode]
		public static MessageParser<GetMembersRequest> Parser
		{
			get
			{
				return GetMembersRequest._parser;
			}
		}

		// Token: 0x17002509 RID: 9481
		// (get) Token: 0x06007452 RID: 29778 RVA: 0x001C62D8 File Offset: 0x001C44D8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[17];
			}
		}

		// Token: 0x1700250A RID: 9482
		// (get) Token: 0x06007453 RID: 29779 RVA: 0x001C62FC File Offset: 0x001C44FC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMembersRequest.Descriptor;
			}
		}

		// Token: 0x06007454 RID: 29780 RVA: 0x001C6313 File Offset: 0x001C4513
		[DebuggerNonUserCode]
		public GetMembersRequest()
		{
		}

		// Token: 0x06007455 RID: 29781 RVA: 0x001C6320 File Offset: 0x001C4520
		[DebuggerNonUserCode]
		public GetMembersRequest(GetMembersRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.continuation_ = other.continuation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007456 RID: 29782 RVA: 0x001C6388 File Offset: 0x001C4588
		[DebuggerNonUserCode]
		public GetMembersRequest Clone()
		{
			return new GetMembersRequest(this);
		}

		// Token: 0x1700250B RID: 9483
		// (get) Token: 0x06007457 RID: 29783 RVA: 0x001C63A0 File Offset: 0x001C45A0
		// (set) Token: 0x06007458 RID: 29784 RVA: 0x001C63B8 File Offset: 0x001C45B8
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

		// Token: 0x1700250C RID: 9484
		// (get) Token: 0x06007459 RID: 29785 RVA: 0x001C63C4 File Offset: 0x001C45C4
		// (set) Token: 0x0600745A RID: 29786 RVA: 0x001C63F5 File Offset: 0x001C45F5
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
					clubIdDefaultValue = GetMembersRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x1700250D RID: 9485
		// (get) Token: 0x0600745B RID: 29787 RVA: 0x001C6410 File Offset: 0x001C4610
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600745C RID: 29788 RVA: 0x001C642D File Offset: 0x001C462D
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700250E RID: 9486
		// (get) Token: 0x0600745D RID: 29789 RVA: 0x001C6440 File Offset: 0x001C4640
		// (set) Token: 0x0600745E RID: 29790 RVA: 0x001C6471 File Offset: 0x001C4671
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
					continuationDefaultValue = GetMembersRequest.ContinuationDefaultValue;
				}
				return continuationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.continuation_ = value;
			}
		}

		// Token: 0x1700250F RID: 9487
		// (get) Token: 0x0600745F RID: 29791 RVA: 0x001C648C File Offset: 0x001C468C
		[DebuggerNonUserCode]
		public bool HasContinuation
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06007460 RID: 29792 RVA: 0x001C64A9 File Offset: 0x001C46A9
		[DebuggerNonUserCode]
		public void ClearContinuation()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06007461 RID: 29793 RVA: 0x001C64BC File Offset: 0x001C46BC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMembersRequest);
		}

		// Token: 0x06007462 RID: 29794 RVA: 0x001C64DC File Offset: 0x001C46DC
		[DebuggerNonUserCode]
		public bool Equals(GetMembersRequest other)
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

		// Token: 0x06007463 RID: 29795 RVA: 0x001C656C File Offset: 0x001C476C
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

		// Token: 0x06007464 RID: 29796 RVA: 0x001C65F8 File Offset: 0x001C47F8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007465 RID: 29797 RVA: 0x001C6610 File Offset: 0x001C4810
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007466 RID: 29798 RVA: 0x001C661C File Offset: 0x001C481C
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
				output.WriteRawTag(32);
				output.WriteUInt64(this.Continuation);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007467 RID: 29799 RVA: 0x001C66B0 File Offset: 0x001C48B0
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

		// Token: 0x06007468 RID: 29800 RVA: 0x001C6740 File Offset: 0x001C4940
		[DebuggerNonUserCode]
		public void MergeFrom(GetMembersRequest other)
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

		// Token: 0x06007469 RID: 29801 RVA: 0x001C67E3 File Offset: 0x001C49E3
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600746A RID: 29802 RVA: 0x001C67F0 File Offset: 0x001C49F0
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
						if (num3 != 32U)
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

		// Token: 0x04003518 RID: 13592
		private static readonly MessageParser<GetMembersRequest> _parser = new MessageParser<GetMembersRequest>(() => new GetMembersRequest());

		// Token: 0x04003519 RID: 13593
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400351A RID: 13594
		private int _hasBits0;

		// Token: 0x0400351B RID: 13595
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400351C RID: 13596
		private MemberId agentId_;

		// Token: 0x0400351D RID: 13597
		public const int ClubIdFieldNumber = 2;

		// Token: 0x0400351E RID: 13598
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x0400351F RID: 13599
		private ulong clubId_;

		// Token: 0x04003520 RID: 13600
		public const int ContinuationFieldNumber = 4;

		// Token: 0x04003521 RID: 13601
		private static readonly ulong ContinuationDefaultValue = 0UL;

		// Token: 0x04003522 RID: 13602
		private ulong continuation_;
	}
}
