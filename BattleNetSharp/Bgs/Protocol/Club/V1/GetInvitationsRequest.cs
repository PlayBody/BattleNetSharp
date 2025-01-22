using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004B8 RID: 1208
	public sealed class GetInvitationsRequest : IMessage<GetInvitationsRequest>, IMessage, IEquatable<GetInvitationsRequest>, IDeepCloneable<GetInvitationsRequest>, IBufferMessage
	{
		// Token: 0x1700255E RID: 9566
		// (get) Token: 0x06007580 RID: 30080 RVA: 0x001CA738 File Offset: 0x001C8938
		[DebuggerNonUserCode]
		public static MessageParser<GetInvitationsRequest> Parser
		{
			get
			{
				return GetInvitationsRequest._parser;
			}
		}

		// Token: 0x1700255F RID: 9567
		// (get) Token: 0x06007581 RID: 30081 RVA: 0x001CA750 File Offset: 0x001C8950
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[29];
			}
		}

		// Token: 0x17002560 RID: 9568
		// (get) Token: 0x06007582 RID: 30082 RVA: 0x001CA774 File Offset: 0x001C8974
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetInvitationsRequest.Descriptor;
			}
		}

		// Token: 0x06007583 RID: 30083 RVA: 0x001CA78B File Offset: 0x001C898B
		[DebuggerNonUserCode]
		public GetInvitationsRequest()
		{
		}

		// Token: 0x06007584 RID: 30084 RVA: 0x001CA798 File Offset: 0x001C8998
		[DebuggerNonUserCode]
		public GetInvitationsRequest(GetInvitationsRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.continuation_ = other.continuation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007585 RID: 30085 RVA: 0x001CA800 File Offset: 0x001C8A00
		[DebuggerNonUserCode]
		public GetInvitationsRequest Clone()
		{
			return new GetInvitationsRequest(this);
		}

		// Token: 0x17002561 RID: 9569
		// (get) Token: 0x06007586 RID: 30086 RVA: 0x001CA818 File Offset: 0x001C8A18
		// (set) Token: 0x06007587 RID: 30087 RVA: 0x001CA830 File Offset: 0x001C8A30
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

		// Token: 0x17002562 RID: 9570
		// (get) Token: 0x06007588 RID: 30088 RVA: 0x001CA83C File Offset: 0x001C8A3C
		// (set) Token: 0x06007589 RID: 30089 RVA: 0x001CA86D File Offset: 0x001C8A6D
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
					clubIdDefaultValue = GetInvitationsRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002563 RID: 9571
		// (get) Token: 0x0600758A RID: 30090 RVA: 0x001CA888 File Offset: 0x001C8A88
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600758B RID: 30091 RVA: 0x001CA8A5 File Offset: 0x001C8AA5
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002564 RID: 9572
		// (get) Token: 0x0600758C RID: 30092 RVA: 0x001CA8B8 File Offset: 0x001C8AB8
		// (set) Token: 0x0600758D RID: 30093 RVA: 0x001CA8E9 File Offset: 0x001C8AE9
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
					continuationDefaultValue = GetInvitationsRequest.ContinuationDefaultValue;
				}
				return continuationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.continuation_ = value;
			}
		}

		// Token: 0x17002565 RID: 9573
		// (get) Token: 0x0600758E RID: 30094 RVA: 0x001CA904 File Offset: 0x001C8B04
		[DebuggerNonUserCode]
		public bool HasContinuation
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600758F RID: 30095 RVA: 0x001CA921 File Offset: 0x001C8B21
		[DebuggerNonUserCode]
		public void ClearContinuation()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06007590 RID: 30096 RVA: 0x001CA934 File Offset: 0x001C8B34
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetInvitationsRequest);
		}

		// Token: 0x06007591 RID: 30097 RVA: 0x001CA954 File Offset: 0x001C8B54
		[DebuggerNonUserCode]
		public bool Equals(GetInvitationsRequest other)
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

		// Token: 0x06007592 RID: 30098 RVA: 0x001CA9E4 File Offset: 0x001C8BE4
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

		// Token: 0x06007593 RID: 30099 RVA: 0x001CAA70 File Offset: 0x001C8C70
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007594 RID: 30100 RVA: 0x001CAA88 File Offset: 0x001C8C88
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007595 RID: 30101 RVA: 0x001CAA94 File Offset: 0x001C8C94
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

		// Token: 0x06007596 RID: 30102 RVA: 0x001CAB28 File Offset: 0x001C8D28
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

		// Token: 0x06007597 RID: 30103 RVA: 0x001CABB8 File Offset: 0x001C8DB8
		[DebuggerNonUserCode]
		public void MergeFrom(GetInvitationsRequest other)
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

		// Token: 0x06007598 RID: 30104 RVA: 0x001CAC5B File Offset: 0x001C8E5B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007599 RID: 30105 RVA: 0x001CAC68 File Offset: 0x001C8E68
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

		// Token: 0x04003590 RID: 13712
		private static readonly MessageParser<GetInvitationsRequest> _parser = new MessageParser<GetInvitationsRequest>(() => new GetInvitationsRequest());

		// Token: 0x04003591 RID: 13713
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003592 RID: 13714
		private int _hasBits0;

		// Token: 0x04003593 RID: 13715
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003594 RID: 13716
		private MemberId agentId_;

		// Token: 0x04003595 RID: 13717
		public const int ClubIdFieldNumber = 2;

		// Token: 0x04003596 RID: 13718
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003597 RID: 13719
		private ulong clubId_;

		// Token: 0x04003598 RID: 13720
		public const int ContinuationFieldNumber = 3;

		// Token: 0x04003599 RID: 13721
		private static readonly ulong ContinuationDefaultValue = 0UL;

		// Token: 0x0400359A RID: 13722
		private ulong continuation_;
	}
}
