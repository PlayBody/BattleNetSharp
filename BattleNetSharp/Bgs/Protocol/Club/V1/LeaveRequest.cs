using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004A8 RID: 1192
	public sealed class LeaveRequest : IMessage<LeaveRequest>, IMessage, IEquatable<LeaveRequest>, IDeepCloneable<LeaveRequest>, IBufferMessage
	{
		// Token: 0x170024F0 RID: 9456
		// (get) Token: 0x060073F5 RID: 29685 RVA: 0x001C4EB4 File Offset: 0x001C30B4
		[DebuggerNonUserCode]
		public static MessageParser<LeaveRequest> Parser
		{
			get
			{
				return LeaveRequest._parser;
			}
		}

		// Token: 0x170024F1 RID: 9457
		// (get) Token: 0x060073F6 RID: 29686 RVA: 0x001C4ECC File Offset: 0x001C30CC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[13];
			}
		}

		// Token: 0x170024F2 RID: 9458
		// (get) Token: 0x060073F7 RID: 29687 RVA: 0x001C4EF0 File Offset: 0x001C30F0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveRequest.Descriptor;
			}
		}

		// Token: 0x060073F8 RID: 29688 RVA: 0x001C4F07 File Offset: 0x001C3107
		[DebuggerNonUserCode]
		public LeaveRequest()
		{
		}

		// Token: 0x060073F9 RID: 29689 RVA: 0x001C4F14 File Offset: 0x001C3114
		[DebuggerNonUserCode]
		public LeaveRequest(LeaveRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060073FA RID: 29690 RVA: 0x001C4F70 File Offset: 0x001C3170
		[DebuggerNonUserCode]
		public LeaveRequest Clone()
		{
			return new LeaveRequest(this);
		}

		// Token: 0x170024F3 RID: 9459
		// (get) Token: 0x060073FB RID: 29691 RVA: 0x001C4F88 File Offset: 0x001C3188
		// (set) Token: 0x060073FC RID: 29692 RVA: 0x001C4FA0 File Offset: 0x001C31A0
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

		// Token: 0x170024F4 RID: 9460
		// (get) Token: 0x060073FD RID: 29693 RVA: 0x001C4FAC File Offset: 0x001C31AC
		// (set) Token: 0x060073FE RID: 29694 RVA: 0x001C4FDD File Offset: 0x001C31DD
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
					clubIdDefaultValue = LeaveRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170024F5 RID: 9461
		// (get) Token: 0x060073FF RID: 29695 RVA: 0x001C4FF8 File Offset: 0x001C31F8
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007400 RID: 29696 RVA: 0x001C5015 File Offset: 0x001C3215
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06007401 RID: 29697 RVA: 0x001C5028 File Offset: 0x001C3228
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveRequest);
		}

		// Token: 0x06007402 RID: 29698 RVA: 0x001C5048 File Offset: 0x001C3248
		[DebuggerNonUserCode]
		public bool Equals(LeaveRequest other)
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

		// Token: 0x06007403 RID: 29699 RVA: 0x001C50BC File Offset: 0x001C32BC
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

		// Token: 0x06007404 RID: 29700 RVA: 0x001C5128 File Offset: 0x001C3328
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007405 RID: 29701 RVA: 0x001C5140 File Offset: 0x001C3340
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007406 RID: 29702 RVA: 0x001C514C File Offset: 0x001C334C
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

		// Token: 0x06007407 RID: 29703 RVA: 0x001C51C0 File Offset: 0x001C33C0
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

		// Token: 0x06007408 RID: 29704 RVA: 0x001C5230 File Offset: 0x001C3430
		[DebuggerNonUserCode]
		public void MergeFrom(LeaveRequest other)
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

		// Token: 0x06007409 RID: 29705 RVA: 0x001C52B5 File Offset: 0x001C34B5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600740A RID: 29706 RVA: 0x001C52C0 File Offset: 0x001C34C0
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

		// Token: 0x040034F8 RID: 13560
		private static readonly MessageParser<LeaveRequest> _parser = new MessageParser<LeaveRequest>(() => new LeaveRequest());

		// Token: 0x040034F9 RID: 13561
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034FA RID: 13562
		private int _hasBits0;

		// Token: 0x040034FB RID: 13563
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040034FC RID: 13564
		private MemberId agentId_;

		// Token: 0x040034FD RID: 13565
		public const int ClubIdFieldNumber = 2;

		// Token: 0x040034FE RID: 13566
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040034FF RID: 13567
		private ulong clubId_;
	}
}
