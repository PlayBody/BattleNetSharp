using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x0200066F RID: 1647
	public sealed class UnassignRoleRequest : IMessage<UnassignRoleRequest>, IMessage, IEquatable<UnassignRoleRequest>, IDeepCloneable<UnassignRoleRequest>, IBufferMessage
	{
		// Token: 0x17002F97 RID: 12183
		// (get) Token: 0x060098DA RID: 39130 RVA: 0x00250574 File Offset: 0x0024E774
		[DebuggerNonUserCode]
		public static MessageParser<UnassignRoleRequest> Parser
		{
			get
			{
				return UnassignRoleRequest._parser;
			}
		}

		// Token: 0x17002F98 RID: 12184
		// (get) Token: 0x060098DB RID: 39131 RVA: 0x0025058C File Offset: 0x0024E78C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[19];
			}
		}

		// Token: 0x17002F99 RID: 12185
		// (get) Token: 0x060098DC RID: 39132 RVA: 0x002505B0 File Offset: 0x0024E7B0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnassignRoleRequest.Descriptor;
			}
		}

		// Token: 0x060098DD RID: 39133 RVA: 0x002505C7 File Offset: 0x0024E7C7
		[DebuggerNonUserCode]
		public UnassignRoleRequest()
		{
		}

		// Token: 0x060098DE RID: 39134 RVA: 0x002505D4 File Offset: 0x0024E7D4
		[DebuggerNonUserCode]
		public UnassignRoleRequest(UnassignRoleRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.assignment_ = ((other.assignment_ != null) ? other.assignment_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060098DF RID: 39135 RVA: 0x00250650 File Offset: 0x0024E850
		[DebuggerNonUserCode]
		public UnassignRoleRequest Clone()
		{
			return new UnassignRoleRequest(this);
		}

		// Token: 0x17002F9A RID: 12186
		// (get) Token: 0x060098E0 RID: 39136 RVA: 0x00250668 File Offset: 0x0024E868
		// (set) Token: 0x060098E1 RID: 39137 RVA: 0x00250680 File Offset: 0x0024E880
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

		// Token: 0x17002F9B RID: 12187
		// (get) Token: 0x060098E2 RID: 39138 RVA: 0x0025068C File Offset: 0x0024E88C
		// (set) Token: 0x060098E3 RID: 39139 RVA: 0x002506A4 File Offset: 0x0024E8A4
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

		// Token: 0x17002F9C RID: 12188
		// (get) Token: 0x060098E4 RID: 39140 RVA: 0x002506B0 File Offset: 0x0024E8B0
		// (set) Token: 0x060098E5 RID: 39141 RVA: 0x002506C8 File Offset: 0x0024E8C8
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

		// Token: 0x060098E6 RID: 39142 RVA: 0x002506D4 File Offset: 0x0024E8D4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnassignRoleRequest);
		}

		// Token: 0x060098E7 RID: 39143 RVA: 0x002506F4 File Offset: 0x0024E8F4
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

		// Token: 0x060098E8 RID: 39144 RVA: 0x0025078C File Offset: 0x0024E98C
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

		// Token: 0x060098E9 RID: 39145 RVA: 0x00250814 File Offset: 0x0024EA14
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060098EA RID: 39146 RVA: 0x0025082C File Offset: 0x0024EA2C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060098EB RID: 39147 RVA: 0x00250838 File Offset: 0x0024EA38
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

		// Token: 0x060098EC RID: 39148 RVA: 0x002508D4 File Offset: 0x0024EAD4
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

		// Token: 0x060098ED RID: 39149 RVA: 0x00250968 File Offset: 0x0024EB68
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

		// Token: 0x060098EE RID: 39150 RVA: 0x00250A55 File Offset: 0x0024EC55
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060098EF RID: 39151 RVA: 0x00250A60 File Offset: 0x0024EC60
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

		// Token: 0x040044CA RID: 17610
		private static readonly MessageParser<UnassignRoleRequest> _parser = new MessageParser<UnassignRoleRequest>(() => new UnassignRoleRequest());

		// Token: 0x040044CB RID: 17611
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044CC RID: 17612
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040044CD RID: 17613
		private GameAccountHandle agentId_;

		// Token: 0x040044CE RID: 17614
		public const int ChannelIdFieldNumber = 2;

		// Token: 0x040044CF RID: 17615
		private ChannelId channelId_;

		// Token: 0x040044D0 RID: 17616
		public const int AssignmentFieldNumber = 3;

		// Token: 0x040044D1 RID: 17617
		private RoleAssignment assignment_;
	}
}
