using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004B3 RID: 1203
	public sealed class AcceptInvitationRequest : IMessage<AcceptInvitationRequest>, IMessage, IEquatable<AcceptInvitationRequest>, IDeepCloneable<AcceptInvitationRequest>, IBufferMessage
	{
		// Token: 0x1700253A RID: 9530
		// (get) Token: 0x06007501 RID: 29953 RVA: 0x001C8C20 File Offset: 0x001C6E20
		[DebuggerNonUserCode]
		public static MessageParser<AcceptInvitationRequest> Parser
		{
			get
			{
				return AcceptInvitationRequest._parser;
			}
		}

		// Token: 0x1700253B RID: 9531
		// (get) Token: 0x06007502 RID: 29954 RVA: 0x001C8C38 File Offset: 0x001C6E38
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[24];
			}
		}

		// Token: 0x1700253C RID: 9532
		// (get) Token: 0x06007503 RID: 29955 RVA: 0x001C8C5C File Offset: 0x001C6E5C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AcceptInvitationRequest.Descriptor;
			}
		}

		// Token: 0x06007504 RID: 29956 RVA: 0x001C8C73 File Offset: 0x001C6E73
		[DebuggerNonUserCode]
		public AcceptInvitationRequest()
		{
		}

		// Token: 0x06007505 RID: 29957 RVA: 0x001C8C80 File Offset: 0x001C6E80
		[DebuggerNonUserCode]
		public AcceptInvitationRequest(AcceptInvitationRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.invitationId_ = other.invitationId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007506 RID: 29958 RVA: 0x001C8CE8 File Offset: 0x001C6EE8
		[DebuggerNonUserCode]
		public AcceptInvitationRequest Clone()
		{
			return new AcceptInvitationRequest(this);
		}

		// Token: 0x1700253D RID: 9533
		// (get) Token: 0x06007507 RID: 29959 RVA: 0x001C8D00 File Offset: 0x001C6F00
		// (set) Token: 0x06007508 RID: 29960 RVA: 0x001C8D18 File Offset: 0x001C6F18
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

		// Token: 0x1700253E RID: 9534
		// (get) Token: 0x06007509 RID: 29961 RVA: 0x001C8D24 File Offset: 0x001C6F24
		// (set) Token: 0x0600750A RID: 29962 RVA: 0x001C8D55 File Offset: 0x001C6F55
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
					clubIdDefaultValue = AcceptInvitationRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x1700253F RID: 9535
		// (get) Token: 0x0600750B RID: 29963 RVA: 0x001C8D70 File Offset: 0x001C6F70
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600750C RID: 29964 RVA: 0x001C8D8D File Offset: 0x001C6F8D
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002540 RID: 9536
		// (get) Token: 0x0600750D RID: 29965 RVA: 0x001C8DA0 File Offset: 0x001C6FA0
		// (set) Token: 0x0600750E RID: 29966 RVA: 0x001C8DD1 File Offset: 0x001C6FD1
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
					invitationIdDefaultValue = AcceptInvitationRequest.InvitationIdDefaultValue;
				}
				return invitationIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.invitationId_ = value;
			}
		}

		// Token: 0x17002541 RID: 9537
		// (get) Token: 0x0600750F RID: 29967 RVA: 0x001C8DEC File Offset: 0x001C6FEC
		[DebuggerNonUserCode]
		public bool HasInvitationId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06007510 RID: 29968 RVA: 0x001C8E09 File Offset: 0x001C7009
		[DebuggerNonUserCode]
		public void ClearInvitationId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06007511 RID: 29969 RVA: 0x001C8E1C File Offset: 0x001C701C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AcceptInvitationRequest);
		}

		// Token: 0x06007512 RID: 29970 RVA: 0x001C8E3C File Offset: 0x001C703C
		[DebuggerNonUserCode]
		public bool Equals(AcceptInvitationRequest other)
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

		// Token: 0x06007513 RID: 29971 RVA: 0x001C8ECC File Offset: 0x001C70CC
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

		// Token: 0x06007514 RID: 29972 RVA: 0x001C8F58 File Offset: 0x001C7158
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007515 RID: 29973 RVA: 0x001C8F70 File Offset: 0x001C7170
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007516 RID: 29974 RVA: 0x001C8F7C File Offset: 0x001C717C
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

		// Token: 0x06007517 RID: 29975 RVA: 0x001C9010 File Offset: 0x001C7210
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

		// Token: 0x06007518 RID: 29976 RVA: 0x001C9094 File Offset: 0x001C7294
		[DebuggerNonUserCode]
		public void MergeFrom(AcceptInvitationRequest other)
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

		// Token: 0x06007519 RID: 29977 RVA: 0x001C9137 File Offset: 0x001C7337
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600751A RID: 29978 RVA: 0x001C9144 File Offset: 0x001C7344
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

		// Token: 0x04003560 RID: 13664
		private static readonly MessageParser<AcceptInvitationRequest> _parser = new MessageParser<AcceptInvitationRequest>(() => new AcceptInvitationRequest());

		// Token: 0x04003561 RID: 13665
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003562 RID: 13666
		private int _hasBits0;

		// Token: 0x04003563 RID: 13667
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003564 RID: 13668
		private MemberId agentId_;

		// Token: 0x04003565 RID: 13669
		public const int ClubIdFieldNumber = 2;

		// Token: 0x04003566 RID: 13670
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003567 RID: 13671
		private ulong clubId_;

		// Token: 0x04003568 RID: 13672
		public const int InvitationIdFieldNumber = 3;

		// Token: 0x04003569 RID: 13673
		private static readonly ulong InvitationIdDefaultValue = 0UL;

		// Token: 0x0400356A RID: 13674
		private ulong invitationId_;
	}
}
