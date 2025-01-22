using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004B1 RID: 1201
	public sealed class UnassignRoleRequest : IMessage<UnassignRoleRequest>, IMessage, IEquatable<UnassignRoleRequest>, IDeepCloneable<UnassignRoleRequest>, IBufferMessage
	{
		// Token: 0x1700252C RID: 9516
		// (get) Token: 0x060074CF RID: 29903 RVA: 0x001C8030 File Offset: 0x001C6230
		[DebuggerNonUserCode]
		public static MessageParser<UnassignRoleRequest> Parser
		{
			get
			{
				return UnassignRoleRequest._parser;
			}
		}

		// Token: 0x1700252D RID: 9517
		// (get) Token: 0x060074D0 RID: 29904 RVA: 0x001C8048 File Offset: 0x001C6248
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[22];
			}
		}

		// Token: 0x1700252E RID: 9518
		// (get) Token: 0x060074D1 RID: 29905 RVA: 0x001C806C File Offset: 0x001C626C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnassignRoleRequest.Descriptor;
			}
		}

		// Token: 0x060074D2 RID: 29906 RVA: 0x001C8083 File Offset: 0x001C6283
		[DebuggerNonUserCode]
		public UnassignRoleRequest()
		{
		}

		// Token: 0x060074D3 RID: 29907 RVA: 0x001C8090 File Offset: 0x001C6290
		[DebuggerNonUserCode]
		public UnassignRoleRequest(UnassignRoleRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060074D4 RID: 29908 RVA: 0x001C8108 File Offset: 0x001C6308
		[DebuggerNonUserCode]
		public UnassignRoleRequest Clone()
		{
			return new UnassignRoleRequest(this);
		}

		// Token: 0x1700252F RID: 9519
		// (get) Token: 0x060074D5 RID: 29909 RVA: 0x001C8120 File Offset: 0x001C6320
		// (set) Token: 0x060074D6 RID: 29910 RVA: 0x001C8138 File Offset: 0x001C6338
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

		// Token: 0x17002530 RID: 9520
		// (get) Token: 0x060074D7 RID: 29911 RVA: 0x001C8144 File Offset: 0x001C6344
		// (set) Token: 0x060074D8 RID: 29912 RVA: 0x001C8175 File Offset: 0x001C6375
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
					clubIdDefaultValue = UnassignRoleRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002531 RID: 9521
		// (get) Token: 0x060074D9 RID: 29913 RVA: 0x001C8190 File Offset: 0x001C6390
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060074DA RID: 29914 RVA: 0x001C81AD File Offset: 0x001C63AD
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002532 RID: 9522
		// (get) Token: 0x060074DB RID: 29915 RVA: 0x001C81C0 File Offset: 0x001C63C0
		// (set) Token: 0x060074DC RID: 29916 RVA: 0x001C81D8 File Offset: 0x001C63D8
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

		// Token: 0x060074DD RID: 29917 RVA: 0x001C81E4 File Offset: 0x001C63E4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnassignRoleRequest);
		}

		// Token: 0x060074DE RID: 29918 RVA: 0x001C8204 File Offset: 0x001C6404
		[DebuggerNonUserCode]
		public bool Equals(UnassignRoleRequest other)
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

		// Token: 0x060074DF RID: 29919 RVA: 0x001C8298 File Offset: 0x001C6498
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

		// Token: 0x060074E0 RID: 29920 RVA: 0x001C8324 File Offset: 0x001C6524
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060074E1 RID: 29921 RVA: 0x001C833C File Offset: 0x001C653C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060074E2 RID: 29922 RVA: 0x001C8348 File Offset: 0x001C6548
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

		// Token: 0x060074E3 RID: 29923 RVA: 0x001C83E0 File Offset: 0x001C65E0
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

		// Token: 0x060074E4 RID: 29924 RVA: 0x001C8470 File Offset: 0x001C6670
		[DebuggerNonUserCode]
		public void MergeFrom(UnassignRoleRequest other)
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

		// Token: 0x060074E5 RID: 29925 RVA: 0x001C8538 File Offset: 0x001C6738
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060074E6 RID: 29926 RVA: 0x001C8544 File Offset: 0x001C6744
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

		// Token: 0x0400354C RID: 13644
		private static readonly MessageParser<UnassignRoleRequest> _parser = new MessageParser<UnassignRoleRequest>(() => new UnassignRoleRequest());

		// Token: 0x0400354D RID: 13645
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400354E RID: 13646
		private int _hasBits0;

		// Token: 0x0400354F RID: 13647
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003550 RID: 13648
		private MemberId agentId_;

		// Token: 0x04003551 RID: 13649
		public const int ClubIdFieldNumber = 2;

		// Token: 0x04003552 RID: 13650
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003553 RID: 13651
		private ulong clubId_;

		// Token: 0x04003554 RID: 13652
		public const int OptionsFieldNumber = 3;

		// Token: 0x04003555 RID: 13653
		private RoleOptions options_;
	}
}
