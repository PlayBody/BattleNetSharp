using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004B4 RID: 1204
	public sealed class DeclineInvitationRequest : IMessage<DeclineInvitationRequest>, IMessage, IEquatable<DeclineInvitationRequest>, IDeepCloneable<DeclineInvitationRequest>, IBufferMessage
	{
		// Token: 0x17002542 RID: 9538
		// (get) Token: 0x0600751C RID: 29980 RVA: 0x001C920C File Offset: 0x001C740C
		[DebuggerNonUserCode]
		public static MessageParser<DeclineInvitationRequest> Parser
		{
			get
			{
				return DeclineInvitationRequest._parser;
			}
		}

		// Token: 0x17002543 RID: 9539
		// (get) Token: 0x0600751D RID: 29981 RVA: 0x001C9224 File Offset: 0x001C7424
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[25];
			}
		}

		// Token: 0x17002544 RID: 9540
		// (get) Token: 0x0600751E RID: 29982 RVA: 0x001C9248 File Offset: 0x001C7448
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeclineInvitationRequest.Descriptor;
			}
		}

		// Token: 0x0600751F RID: 29983 RVA: 0x001C925F File Offset: 0x001C745F
		[DebuggerNonUserCode]
		public DeclineInvitationRequest()
		{
		}

		// Token: 0x06007520 RID: 29984 RVA: 0x001C926C File Offset: 0x001C746C
		[DebuggerNonUserCode]
		public DeclineInvitationRequest(DeclineInvitationRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.invitationId_ = other.invitationId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007521 RID: 29985 RVA: 0x001C92D4 File Offset: 0x001C74D4
		[DebuggerNonUserCode]
		public DeclineInvitationRequest Clone()
		{
			return new DeclineInvitationRequest(this);
		}

		// Token: 0x17002545 RID: 9541
		// (get) Token: 0x06007522 RID: 29986 RVA: 0x001C92EC File Offset: 0x001C74EC
		// (set) Token: 0x06007523 RID: 29987 RVA: 0x001C9304 File Offset: 0x001C7504
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

		// Token: 0x17002546 RID: 9542
		// (get) Token: 0x06007524 RID: 29988 RVA: 0x001C9310 File Offset: 0x001C7510
		// (set) Token: 0x06007525 RID: 29989 RVA: 0x001C9341 File Offset: 0x001C7541
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
					clubIdDefaultValue = DeclineInvitationRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002547 RID: 9543
		// (get) Token: 0x06007526 RID: 29990 RVA: 0x001C935C File Offset: 0x001C755C
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007527 RID: 29991 RVA: 0x001C9379 File Offset: 0x001C7579
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002548 RID: 9544
		// (get) Token: 0x06007528 RID: 29992 RVA: 0x001C938C File Offset: 0x001C758C
		// (set) Token: 0x06007529 RID: 29993 RVA: 0x001C93BD File Offset: 0x001C75BD
		[DebuggerNonUserCode]
		public ulong InvitationId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong invitationIdDefaultValue;
				if (flag)
				{
					invitationIdDefaultValue = this.invitationId_;
				}
				else
				{
					invitationIdDefaultValue = DeclineInvitationRequest.InvitationIdDefaultValue;
				}
				return invitationIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.invitationId_ = value;
			}
		}

		// Token: 0x17002549 RID: 9545
		// (get) Token: 0x0600752A RID: 29994 RVA: 0x001C93D8 File Offset: 0x001C75D8
		[DebuggerNonUserCode]
		public bool HasInvitationId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600752B RID: 29995 RVA: 0x001C93F5 File Offset: 0x001C75F5
		[DebuggerNonUserCode]
		public void ClearInvitationId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600752C RID: 29996 RVA: 0x001C9408 File Offset: 0x001C7608
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeclineInvitationRequest);
		}

		// Token: 0x0600752D RID: 29997 RVA: 0x001C9428 File Offset: 0x001C7628
		[DebuggerNonUserCode]
		public bool Equals(DeclineInvitationRequest other)
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
							bool flag6 = this.InvitationId != other.InvitationId;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600752E RID: 29998 RVA: 0x001C94B8 File Offset: 0x001C76B8
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
			bool hasInvitationId = this.HasInvitationId;
			if (hasInvitationId)
			{
				num ^= this.InvitationId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600752F RID: 29999 RVA: 0x001C9544 File Offset: 0x001C7744
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007530 RID: 30000 RVA: 0x001C955C File Offset: 0x001C775C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007531 RID: 30001 RVA: 0x001C9568 File Offset: 0x001C7768
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
			bool hasInvitationId = this.HasInvitationId;
			if (hasInvitationId)
			{
				output.WriteRawTag(25);
				output.WriteFixed64(this.InvitationId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007532 RID: 30002 RVA: 0x001C95FC File Offset: 0x001C77FC
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
			bool hasInvitationId = this.HasInvitationId;
			if (hasInvitationId)
			{
				num += 9;
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007533 RID: 30003 RVA: 0x001C9680 File Offset: 0x001C7880
		[DebuggerNonUserCode]
		public void MergeFrom(DeclineInvitationRequest other)
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
				bool hasInvitationId = other.HasInvitationId;
				if (hasInvitationId)
				{
					this.InvitationId = other.InvitationId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007534 RID: 30004 RVA: 0x001C9723 File Offset: 0x001C7923
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007535 RID: 30005 RVA: 0x001C9730 File Offset: 0x001C7930
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
						if (num3 != 25U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.InvitationId = input.ReadFixed64();
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

		// Token: 0x0400356B RID: 13675
		private static readonly MessageParser<DeclineInvitationRequest> _parser = new MessageParser<DeclineInvitationRequest>(() => new DeclineInvitationRequest());

		// Token: 0x0400356C RID: 13676
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400356D RID: 13677
		private int _hasBits0;

		// Token: 0x0400356E RID: 13678
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400356F RID: 13679
		private MemberId agentId_;

		// Token: 0x04003570 RID: 13680
		public const int ClubIdFieldNumber = 2;

		// Token: 0x04003571 RID: 13681
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003572 RID: 13682
		private ulong clubId_;

		// Token: 0x04003573 RID: 13683
		public const int InvitationIdFieldNumber = 3;

		// Token: 0x04003574 RID: 13684
		private static readonly ulong InvitationIdDefaultValue = 0UL;

		// Token: 0x04003575 RID: 13685
		private ulong invitationId_;
	}
}
