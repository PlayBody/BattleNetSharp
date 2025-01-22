using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x0200066E RID: 1646
	public sealed class AssignRoleRequest : IMessage<AssignRoleRequest>, IMessage, IEquatable<AssignRoleRequest>, IDeepCloneable<AssignRoleRequest>, IBufferMessage
	{
		// Token: 0x17002F91 RID: 12177
		// (get) Token: 0x060098C3 RID: 39107 RVA: 0x0024FF8C File Offset: 0x0024E18C
		[DebuggerNonUserCode]
		public static MessageParser<AssignRoleRequest> Parser
		{
			get
			{
				return AssignRoleRequest._parser;
			}
		}

		// Token: 0x17002F92 RID: 12178
		// (get) Token: 0x060098C4 RID: 39108 RVA: 0x0024FFA4 File Offset: 0x0024E1A4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[18];
			}
		}

		// Token: 0x17002F93 RID: 12179
		// (get) Token: 0x060098C5 RID: 39109 RVA: 0x0024FFC8 File Offset: 0x0024E1C8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AssignRoleRequest.Descriptor;
			}
		}

		// Token: 0x060098C6 RID: 39110 RVA: 0x0024FFDF File Offset: 0x0024E1DF
		[DebuggerNonUserCode]
		public AssignRoleRequest()
		{
		}

		// Token: 0x060098C7 RID: 39111 RVA: 0x0024FFEC File Offset: 0x0024E1EC
		[DebuggerNonUserCode]
		public AssignRoleRequest(AssignRoleRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.assignment_ = ((other.assignment_ != null) ? other.assignment_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060098C8 RID: 39112 RVA: 0x00250068 File Offset: 0x0024E268
		[DebuggerNonUserCode]
		public AssignRoleRequest Clone()
		{
			return new AssignRoleRequest(this);
		}

		// Token: 0x17002F94 RID: 12180
		// (get) Token: 0x060098C9 RID: 39113 RVA: 0x00250080 File Offset: 0x0024E280
		// (set) Token: 0x060098CA RID: 39114 RVA: 0x00250098 File Offset: 0x0024E298
		[DebuggerNonUserCode]
		public GameAccountHandle AgentId
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

		// Token: 0x17002F95 RID: 12181
		// (get) Token: 0x060098CB RID: 39115 RVA: 0x002500A4 File Offset: 0x0024E2A4
		// (set) Token: 0x060098CC RID: 39116 RVA: 0x002500BC File Offset: 0x0024E2BC
		[DebuggerNonUserCode]
		public ChannelId ChannelId
		{
			get
			{
				return this.channelId_;
			}
			set
			{
				this.channelId_ = value;
			}
		}

		// Token: 0x17002F96 RID: 12182
		// (get) Token: 0x060098CD RID: 39117 RVA: 0x002500C8 File Offset: 0x0024E2C8
		// (set) Token: 0x060098CE RID: 39118 RVA: 0x002500E0 File Offset: 0x0024E2E0
		[DebuggerNonUserCode]
		public RoleAssignment Assignment
		{
			get
			{
				return this.assignment_;
			}
			set
			{
				this.assignment_ = value;
			}
		}

		// Token: 0x060098CF RID: 39119 RVA: 0x002500EC File Offset: 0x0024E2EC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AssignRoleRequest);
		}

		// Token: 0x060098D0 RID: 39120 RVA: 0x0025010C File Offset: 0x0024E30C
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
						bool flag5 = !object.Equals(this.ChannelId, other.ChannelId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Assignment, other.Assignment);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060098D1 RID: 39121 RVA: 0x002501A4 File Offset: 0x0024E3A4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			bool flag3 = this.assignment_ != null;
			if (flag3)
			{
				num ^= this.Assignment.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060098D2 RID: 39122 RVA: 0x0025022C File Offset: 0x0024E42C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060098D3 RID: 39123 RVA: 0x00250244 File Offset: 0x0024E444
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060098D4 RID: 39124 RVA: 0x00250250 File Offset: 0x0024E450
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ChannelId);
			}
			bool flag3 = this.assignment_ != null;
			if (flag3)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Assignment);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060098D5 RID: 39125 RVA: 0x002502EC File Offset: 0x0024E4EC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
			}
			bool flag3 = this.assignment_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Assignment);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060098D6 RID: 39126 RVA: 0x00250380 File Offset: 0x0024E580
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
						this.AgentId = new GameAccountHandle();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool flag4 = other.channelId_ != null;
				if (flag4)
				{
					bool flag5 = this.channelId_ == null;
					if (flag5)
					{
						this.ChannelId = new ChannelId();
					}
					this.ChannelId.MergeFrom(other.ChannelId);
				}
				bool flag6 = other.assignment_ != null;
				if (flag6)
				{
					bool flag7 = this.assignment_ == null;
					if (flag7)
					{
						this.Assignment = new RoleAssignment();
					}
					this.Assignment.MergeFrom(other.Assignment);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060098D7 RID: 39127 RVA: 0x0025046D File Offset: 0x0024E66D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060098D8 RID: 39128 RVA: 0x00250478 File Offset: 0x0024E678
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
					if (num3 != 18U)
					{
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.assignment_ == null;
							if (flag)
							{
								this.Assignment = new RoleAssignment();
							}
							input.ReadMessage(this.Assignment);
						}
					}
					else
					{
						bool flag2 = this.channelId_ == null;
						if (flag2)
						{
							this.ChannelId = new ChannelId();
						}
						input.ReadMessage(this.ChannelId);
					}
				}
				else
				{
					bool flag3 = this.agentId_ == null;
					if (flag3)
					{
						this.AgentId = new GameAccountHandle();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x040044C2 RID: 17602
		private static readonly MessageParser<AssignRoleRequest> _parser = new MessageParser<AssignRoleRequest>(() => new AssignRoleRequest());

		// Token: 0x040044C3 RID: 17603
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044C4 RID: 17604
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040044C5 RID: 17605
		private GameAccountHandle agentId_;

		// Token: 0x040044C6 RID: 17606
		public const int ChannelIdFieldNumber = 2;

		// Token: 0x040044C7 RID: 17607
		private ChannelId channelId_;

		// Token: 0x040044C8 RID: 17608
		public const int AssignmentFieldNumber = 3;

		// Token: 0x040044C9 RID: 17609
		private RoleAssignment assignment_;
	}
}
