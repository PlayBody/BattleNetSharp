using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004C7 RID: 1223
	public sealed class GetTicketsRequest : IMessage<GetTicketsRequest>, IMessage, IEquatable<GetTicketsRequest>, IDeepCloneable<GetTicketsRequest>, IBufferMessage
	{
		// Token: 0x170025C0 RID: 9664
		// (get) Token: 0x060076E7 RID: 30439 RVA: 0x001CF298 File Offset: 0x001CD498
		[DebuggerNonUserCode]
		public static MessageParser<GetTicketsRequest> Parser
		{
			get
			{
				return GetTicketsRequest._parser;
			}
		}

		// Token: 0x170025C1 RID: 9665
		// (get) Token: 0x060076E8 RID: 30440 RVA: 0x001CF2B0 File Offset: 0x001CD4B0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[44];
			}
		}

		// Token: 0x170025C2 RID: 9666
		// (get) Token: 0x060076E9 RID: 30441 RVA: 0x001CF2D4 File Offset: 0x001CD4D4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetTicketsRequest.Descriptor;
			}
		}

		// Token: 0x060076EA RID: 30442 RVA: 0x001CF2EB File Offset: 0x001CD4EB
		[DebuggerNonUserCode]
		public GetTicketsRequest()
		{
		}

		// Token: 0x060076EB RID: 30443 RVA: 0x001CF2F8 File Offset: 0x001CD4F8
		[DebuggerNonUserCode]
		public GetTicketsRequest(GetTicketsRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.continuation_ = other.continuation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060076EC RID: 30444 RVA: 0x001CF360 File Offset: 0x001CD560
		[DebuggerNonUserCode]
		public GetTicketsRequest Clone()
		{
			return new GetTicketsRequest(this);
		}

		// Token: 0x170025C3 RID: 9667
		// (get) Token: 0x060076ED RID: 30445 RVA: 0x001CF378 File Offset: 0x001CD578
		// (set) Token: 0x060076EE RID: 30446 RVA: 0x001CF390 File Offset: 0x001CD590
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

		// Token: 0x170025C4 RID: 9668
		// (get) Token: 0x060076EF RID: 30447 RVA: 0x001CF39C File Offset: 0x001CD59C
		// (set) Token: 0x060076F0 RID: 30448 RVA: 0x001CF3CD File Offset: 0x001CD5CD
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
					clubIdDefaultValue = GetTicketsRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170025C5 RID: 9669
		// (get) Token: 0x060076F1 RID: 30449 RVA: 0x001CF3E8 File Offset: 0x001CD5E8
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060076F2 RID: 30450 RVA: 0x001CF405 File Offset: 0x001CD605
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170025C6 RID: 9670
		// (get) Token: 0x060076F3 RID: 30451 RVA: 0x001CF418 File Offset: 0x001CD618
		// (set) Token: 0x060076F4 RID: 30452 RVA: 0x001CF449 File Offset: 0x001CD649
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
					continuationDefaultValue = GetTicketsRequest.ContinuationDefaultValue;
				}
				return continuationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.continuation_ = value;
			}
		}

		// Token: 0x170025C7 RID: 9671
		// (get) Token: 0x060076F5 RID: 30453 RVA: 0x001CF464 File Offset: 0x001CD664
		[DebuggerNonUserCode]
		public bool HasContinuation
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060076F6 RID: 30454 RVA: 0x001CF481 File Offset: 0x001CD681
		[DebuggerNonUserCode]
		public void ClearContinuation()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060076F7 RID: 30455 RVA: 0x001CF494 File Offset: 0x001CD694
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetTicketsRequest);
		}

		// Token: 0x060076F8 RID: 30456 RVA: 0x001CF4B4 File Offset: 0x001CD6B4
		[DebuggerNonUserCode]
		public bool Equals(GetTicketsRequest other)
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

		// Token: 0x060076F9 RID: 30457 RVA: 0x001CF544 File Offset: 0x001CD744
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

		// Token: 0x060076FA RID: 30458 RVA: 0x001CF5D0 File Offset: 0x001CD7D0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060076FB RID: 30459 RVA: 0x001CF5E8 File Offset: 0x001CD7E8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060076FC RID: 30460 RVA: 0x001CF5F4 File Offset: 0x001CD7F4
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

		// Token: 0x060076FD RID: 30461 RVA: 0x001CF688 File Offset: 0x001CD888
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

		// Token: 0x060076FE RID: 30462 RVA: 0x001CF718 File Offset: 0x001CD918
		[DebuggerNonUserCode]
		public void MergeFrom(GetTicketsRequest other)
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

		// Token: 0x060076FF RID: 30463 RVA: 0x001CF7BB File Offset: 0x001CD9BB
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007700 RID: 30464 RVA: 0x001CF7C8 File Offset: 0x001CD9C8
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

		// Token: 0x04003612 RID: 13842
		private static readonly MessageParser<GetTicketsRequest> _parser = new MessageParser<GetTicketsRequest>(() => new GetTicketsRequest());

		// Token: 0x04003613 RID: 13843
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003614 RID: 13844
		private int _hasBits0;

		// Token: 0x04003615 RID: 13845
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003616 RID: 13846
		private MemberId agentId_;

		// Token: 0x04003617 RID: 13847
		public const int ClubIdFieldNumber = 2;

		// Token: 0x04003618 RID: 13848
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003619 RID: 13849
		private ulong clubId_;

		// Token: 0x0400361A RID: 13850
		public const int ContinuationFieldNumber = 3;

		// Token: 0x0400361B RID: 13851
		private static readonly ulong ContinuationDefaultValue = 0UL;

		// Token: 0x0400361C RID: 13852
		private ulong continuation_;
	}
}
