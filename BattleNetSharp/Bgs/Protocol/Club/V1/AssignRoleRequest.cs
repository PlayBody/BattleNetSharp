using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004B0 RID: 1200
	public sealed class AssignRoleRequest : IMessage<AssignRoleRequest>, IMessage, IEquatable<AssignRoleRequest>, IDeepCloneable<AssignRoleRequest>, IBufferMessage
	{
		// Token: 0x17002525 RID: 9509
		// (get) Token: 0x060074B6 RID: 29878 RVA: 0x001C7A38 File Offset: 0x001C5C38
		[DebuggerNonUserCode]
		public static MessageParser<AssignRoleRequest> Parser
		{
			get
			{
				return AssignRoleRequest._parser;
			}
		}

		// Token: 0x17002526 RID: 9510
		// (get) Token: 0x060074B7 RID: 29879 RVA: 0x001C7A50 File Offset: 0x001C5C50
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[21];
			}
		}

		// Token: 0x17002527 RID: 9511
		// (get) Token: 0x060074B8 RID: 29880 RVA: 0x001C7A74 File Offset: 0x001C5C74
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AssignRoleRequest.Descriptor;
			}
		}

		// Token: 0x060074B9 RID: 29881 RVA: 0x001C7A8B File Offset: 0x001C5C8B
		[DebuggerNonUserCode]
		public AssignRoleRequest()
		{
		}

		// Token: 0x060074BA RID: 29882 RVA: 0x001C7A98 File Offset: 0x001C5C98
		[DebuggerNonUserCode]
		public AssignRoleRequest(AssignRoleRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060074BB RID: 29883 RVA: 0x001C7B10 File Offset: 0x001C5D10
		[DebuggerNonUserCode]
		public AssignRoleRequest Clone()
		{
			return new AssignRoleRequest(this);
		}

		// Token: 0x17002528 RID: 9512
		// (get) Token: 0x060074BC RID: 29884 RVA: 0x001C7B28 File Offset: 0x001C5D28
		// (set) Token: 0x060074BD RID: 29885 RVA: 0x001C7B40 File Offset: 0x001C5D40
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

		// Token: 0x17002529 RID: 9513
		// (get) Token: 0x060074BE RID: 29886 RVA: 0x001C7B4C File Offset: 0x001C5D4C
		// (set) Token: 0x060074BF RID: 29887 RVA: 0x001C7B7D File Offset: 0x001C5D7D
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
					clubIdDefaultValue = AssignRoleRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x1700252A RID: 9514
		// (get) Token: 0x060074C0 RID: 29888 RVA: 0x001C7B98 File Offset: 0x001C5D98
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060074C1 RID: 29889 RVA: 0x001C7BB5 File Offset: 0x001C5DB5
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700252B RID: 9515
		// (get) Token: 0x060074C2 RID: 29890 RVA: 0x001C7BC8 File Offset: 0x001C5DC8
		// (set) Token: 0x060074C3 RID: 29891 RVA: 0x001C7BE0 File Offset: 0x001C5DE0
		[DebuggerNonUserCode]
		public RoleOptions Options
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

		// Token: 0x060074C4 RID: 29892 RVA: 0x001C7BEC File Offset: 0x001C5DEC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AssignRoleRequest);
		}

		// Token: 0x060074C5 RID: 29893 RVA: 0x001C7C0C File Offset: 0x001C5E0C
		[DebuggerNonUserCode]
		public bool Equals(AssignRoleRequest other)
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
							bool flag6 = !object.Equals(this.Options, other.Options);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060074C6 RID: 29894 RVA: 0x001C7CA0 File Offset: 0x001C5EA0
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
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				num ^= this.Options.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060074C7 RID: 29895 RVA: 0x001C7D2C File Offset: 0x001C5F2C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060074C8 RID: 29896 RVA: 0x001C7D44 File Offset: 0x001C5F44
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060074C9 RID: 29897 RVA: 0x001C7D50 File Offset: 0x001C5F50
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
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Options);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060074CA RID: 29898 RVA: 0x001C7DE8 File Offset: 0x001C5FE8
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
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060074CB RID: 29899 RVA: 0x001C7E78 File Offset: 0x001C6078
		[DebuggerNonUserCode]
		public void MergeFrom(AssignRoleRequest other)
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
				bool flag4 = other.options_ != null;
				if (flag4)
				{
					bool flag5 = this.options_ == null;
					if (flag5)
					{
						this.Options = new RoleOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060074CC RID: 29900 RVA: 0x001C7F40 File Offset: 0x001C6140
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060074CD RID: 29901 RVA: 0x001C7F4C File Offset: 0x001C614C
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.options_ == null;
							if (flag)
							{
								this.Options = new RoleOptions();
							}
							input.ReadMessage(this.Options);
						}
					}
					else
					{
						this.ClubId = input.ReadUInt64();
					}
				}
				else
				{
					bool flag2 = this.agentId_ == null;
					if (flag2)
					{
						this.AgentId = new MemberId();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x04003542 RID: 13634
		private static readonly MessageParser<AssignRoleRequest> _parser = new MessageParser<AssignRoleRequest>(() => new AssignRoleRequest());

		// Token: 0x04003543 RID: 13635
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003544 RID: 13636
		private int _hasBits0;

		// Token: 0x04003545 RID: 13637
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003546 RID: 13638
		private MemberId agentId_;

		// Token: 0x04003547 RID: 13639
		public const int ClubIdFieldNumber = 2;

		// Token: 0x04003548 RID: 13640
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003549 RID: 13641
		private ulong clubId_;

		// Token: 0x0400354A RID: 13642
		public const int OptionsFieldNumber = 3;

		// Token: 0x0400354B RID: 13643
		private RoleOptions options_;
	}
}
