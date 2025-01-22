using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004AE RID: 1198
	public sealed class UpdateMemberStateRequest : IMessage<UpdateMemberStateRequest>, IMessage, IEquatable<UpdateMemberStateRequest>, IDeepCloneable<UpdateMemberStateRequest>, IBufferMessage
	{
		// Token: 0x17002516 RID: 9494
		// (get) Token: 0x06007482 RID: 29826 RVA: 0x001C6D00 File Offset: 0x001C4F00
		[DebuggerNonUserCode]
		public static MessageParser<UpdateMemberStateRequest> Parser
		{
			get
			{
				return UpdateMemberStateRequest._parser;
			}
		}

		// Token: 0x17002517 RID: 9495
		// (get) Token: 0x06007483 RID: 29827 RVA: 0x001C6D18 File Offset: 0x001C4F18
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[19];
			}
		}

		// Token: 0x17002518 RID: 9496
		// (get) Token: 0x06007484 RID: 29828 RVA: 0x001C6D3C File Offset: 0x001C4F3C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateMemberStateRequest.Descriptor;
			}
		}

		// Token: 0x06007485 RID: 29829 RVA: 0x001C6D53 File Offset: 0x001C4F53
		[DebuggerNonUserCode]
		public UpdateMemberStateRequest()
		{
		}

		// Token: 0x06007486 RID: 29830 RVA: 0x001C6D60 File Offset: 0x001C4F60
		[DebuggerNonUserCode]
		public UpdateMemberStateRequest(UpdateMemberStateRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.memberId_ = ((other.memberId_ != null) ? other.memberId_.Clone() : null);
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007487 RID: 29831 RVA: 0x001C6DF4 File Offset: 0x001C4FF4
		[DebuggerNonUserCode]
		public UpdateMemberStateRequest Clone()
		{
			return new UpdateMemberStateRequest(this);
		}

		// Token: 0x17002519 RID: 9497
		// (get) Token: 0x06007488 RID: 29832 RVA: 0x001C6E0C File Offset: 0x001C500C
		// (set) Token: 0x06007489 RID: 29833 RVA: 0x001C6E24 File Offset: 0x001C5024
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

		// Token: 0x1700251A RID: 9498
		// (get) Token: 0x0600748A RID: 29834 RVA: 0x001C6E30 File Offset: 0x001C5030
		// (set) Token: 0x0600748B RID: 29835 RVA: 0x001C6E61 File Offset: 0x001C5061
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
					clubIdDefaultValue = UpdateMemberStateRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x1700251B RID: 9499
		// (get) Token: 0x0600748C RID: 29836 RVA: 0x001C6E7C File Offset: 0x001C507C
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600748D RID: 29837 RVA: 0x001C6E99 File Offset: 0x001C5099
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700251C RID: 9500
		// (get) Token: 0x0600748E RID: 29838 RVA: 0x001C6EAC File Offset: 0x001C50AC
		// (set) Token: 0x0600748F RID: 29839 RVA: 0x001C6EC4 File Offset: 0x001C50C4
		[DebuggerNonUserCode]
		public MemberId MemberId
		{
			get
			{
				return this.memberId_;
			}
			set
			{
				this.memberId_ = value;
			}
		}

		// Token: 0x1700251D RID: 9501
		// (get) Token: 0x06007490 RID: 29840 RVA: 0x001C6ED0 File Offset: 0x001C50D0
		// (set) Token: 0x06007491 RID: 29841 RVA: 0x001C6EE8 File Offset: 0x001C50E8
		[DebuggerNonUserCode]
		public MemberStateOptions Options
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

		// Token: 0x06007492 RID: 29842 RVA: 0x001C6EF4 File Offset: 0x001C50F4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateMemberStateRequest);
		}

		// Token: 0x06007493 RID: 29843 RVA: 0x001C6F14 File Offset: 0x001C5114
		[DebuggerNonUserCode]
		public bool Equals(UpdateMemberStateRequest other)
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
							bool flag6 = !object.Equals(this.MemberId, other.MemberId);
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

		// Token: 0x06007494 RID: 29844 RVA: 0x001C6FCC File Offset: 0x001C51CC
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
			bool flag2 = this.memberId_ != null;
			if (flag2)
			{
				num ^= this.MemberId.GetHashCode();
			}
			bool flag3 = this.options_ != null;
			if (flag3)
			{
				num ^= this.Options.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007495 RID: 29845 RVA: 0x001C7074 File Offset: 0x001C5274
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007496 RID: 29846 RVA: 0x001C708C File Offset: 0x001C528C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007497 RID: 29847 RVA: 0x001C7098 File Offset: 0x001C5298
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
			bool flag2 = this.memberId_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.MemberId);
			}
			bool flag3 = this.options_ != null;
			if (flag3)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Options);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007498 RID: 29848 RVA: 0x001C7158 File Offset: 0x001C5358
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
			bool flag2 = this.memberId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MemberId);
			}
			bool flag3 = this.options_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007499 RID: 29849 RVA: 0x001C720C File Offset: 0x001C540C
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateMemberStateRequest other)
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
				bool flag4 = other.memberId_ != null;
				if (flag4)
				{
					bool flag5 = this.memberId_ == null;
					if (flag5)
					{
						this.MemberId = new MemberId();
					}
					this.MemberId.MergeFrom(other.MemberId);
				}
				bool flag6 = other.options_ != null;
				if (flag6)
				{
					bool flag7 = this.options_ == null;
					if (flag7)
					{
						this.Options = new MemberStateOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600749A RID: 29850 RVA: 0x001C7314 File Offset: 0x001C5514
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600749B RID: 29851 RVA: 0x001C7320 File Offset: 0x001C5520
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
							goto IL_002F;
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
				else if (num3 != 26U)
				{
					if (num3 != 42U)
					{
						goto IL_002F;
					}
					bool flag2 = this.options_ == null;
					if (flag2)
					{
						this.Options = new MemberStateOptions();
					}
					input.ReadMessage(this.Options);
				}
				else
				{
					bool flag3 = this.memberId_ == null;
					if (flag3)
					{
						this.MemberId = new MemberId();
					}
					input.ReadMessage(this.MemberId);
				}
				continue;
				IL_002F:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400352C RID: 13612
		private static readonly MessageParser<UpdateMemberStateRequest> _parser = new MessageParser<UpdateMemberStateRequest>(() => new UpdateMemberStateRequest());

		// Token: 0x0400352D RID: 13613
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400352E RID: 13614
		private int _hasBits0;

		// Token: 0x0400352F RID: 13615
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003530 RID: 13616
		private MemberId agentId_;

		// Token: 0x04003531 RID: 13617
		public const int ClubIdFieldNumber = 2;

		// Token: 0x04003532 RID: 13618
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003533 RID: 13619
		private ulong clubId_;

		// Token: 0x04003534 RID: 13620
		public const int MemberIdFieldNumber = 3;

		// Token: 0x04003535 RID: 13621
		private MemberId memberId_;

		// Token: 0x04003536 RID: 13622
		public const int OptionsFieldNumber = 5;

		// Token: 0x04003537 RID: 13623
		private MemberStateOptions options_;
	}
}
