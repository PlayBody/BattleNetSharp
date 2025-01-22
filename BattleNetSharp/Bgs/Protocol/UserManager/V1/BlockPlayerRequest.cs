using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.UserManager.V1
{
	// Token: 0x020003B8 RID: 952
	public sealed class BlockPlayerRequest : IMessage<BlockPlayerRequest>, IMessage, IEquatable<BlockPlayerRequest>, IDeepCloneable<BlockPlayerRequest>, IBufferMessage
	{
		// Token: 0x17001EEB RID: 7915
		// (get) Token: 0x06005FAA RID: 24490 RVA: 0x00172B1C File Offset: 0x00170D1C
		[DebuggerNonUserCode]
		public static MessageParser<BlockPlayerRequest> Parser
		{
			get
			{
				return BlockPlayerRequest._parser;
			}
		}

		// Token: 0x17001EEC RID: 7916
		// (get) Token: 0x06005FAB RID: 24491 RVA: 0x00172B34 File Offset: 0x00170D34
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UserManagerServiceReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17001EED RID: 7917
		// (get) Token: 0x06005FAC RID: 24492 RVA: 0x00172B58 File Offset: 0x00170D58
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlockPlayerRequest.Descriptor;
			}
		}

		// Token: 0x06005FAD RID: 24493 RVA: 0x00172B6F File Offset: 0x00170D6F
		[DebuggerNonUserCode]
		public BlockPlayerRequest()
		{
		}

		// Token: 0x06005FAE RID: 24494 RVA: 0x00172B7C File Offset: 0x00170D7C
		[DebuggerNonUserCode]
		public BlockPlayerRequest(BlockPlayerRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.targetId_ = ((other.targetId_ != null) ? other.targetId_.Clone() : null);
			this.role_ = other.role_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005FAF RID: 24495 RVA: 0x00172BF4 File Offset: 0x00170DF4
		[DebuggerNonUserCode]
		public BlockPlayerRequest Clone()
		{
			return new BlockPlayerRequest(this);
		}

		// Token: 0x17001EEE RID: 7918
		// (get) Token: 0x06005FB0 RID: 24496 RVA: 0x00172C0C File Offset: 0x00170E0C
		// (set) Token: 0x06005FB1 RID: 24497 RVA: 0x00172C24 File Offset: 0x00170E24
		[DebuggerNonUserCode]
		public EntityId AgentId
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

		// Token: 0x17001EEF RID: 7919
		// (get) Token: 0x06005FB2 RID: 24498 RVA: 0x00172C30 File Offset: 0x00170E30
		// (set) Token: 0x06005FB3 RID: 24499 RVA: 0x00172C48 File Offset: 0x00170E48
		[DebuggerNonUserCode]
		public EntityId TargetId
		{
			get
			{
				return this.targetId_;
			}
			set
			{
				this.targetId_ = value;
			}
		}

		// Token: 0x17001EF0 RID: 7920
		// (get) Token: 0x06005FB4 RID: 24500 RVA: 0x00172C54 File Offset: 0x00170E54
		// (set) Token: 0x06005FB5 RID: 24501 RVA: 0x00172C85 File Offset: 0x00170E85
		[DebuggerNonUserCode]
		public uint Role
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint roleDefaultValue;
				if (flag)
				{
					roleDefaultValue = this.role_;
				}
				else
				{
					roleDefaultValue = BlockPlayerRequest.RoleDefaultValue;
				}
				return roleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.role_ = value;
			}
		}

		// Token: 0x17001EF1 RID: 7921
		// (get) Token: 0x06005FB6 RID: 24502 RVA: 0x00172CA0 File Offset: 0x00170EA0
		[DebuggerNonUserCode]
		public bool HasRole
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005FB7 RID: 24503 RVA: 0x00172CBD File Offset: 0x00170EBD
		[DebuggerNonUserCode]
		public void ClearRole()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06005FB8 RID: 24504 RVA: 0x00172CD0 File Offset: 0x00170ED0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlockPlayerRequest);
		}

		// Token: 0x06005FB9 RID: 24505 RVA: 0x00172CF0 File Offset: 0x00170EF0
		[DebuggerNonUserCode]
		public bool Equals(BlockPlayerRequest other)
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
						bool flag5 = !object.Equals(this.TargetId, other.TargetId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Role != other.Role;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005FBA RID: 24506 RVA: 0x00172D84 File Offset: 0x00170F84
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				num ^= this.TargetId.GetHashCode();
			}
			bool hasRole = this.HasRole;
			if (hasRole)
			{
				num ^= this.Role.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005FBB RID: 24507 RVA: 0x00172E0C File Offset: 0x0017100C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005FBC RID: 24508 RVA: 0x00172E24 File Offset: 0x00171024
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005FBD RID: 24509 RVA: 0x00172E30 File Offset: 0x00171030
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.TargetId);
			}
			bool hasRole = this.HasRole;
			if (hasRole)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Role);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005FBE RID: 24510 RVA: 0x00172EC8 File Offset: 0x001710C8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetId);
			}
			bool hasRole = this.HasRole;
			if (hasRole)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Role);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005FBF RID: 24511 RVA: 0x00172F58 File Offset: 0x00171158
		[DebuggerNonUserCode]
		public void MergeFrom(BlockPlayerRequest other)
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
						this.AgentId = new EntityId();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool flag4 = other.targetId_ != null;
				if (flag4)
				{
					bool flag5 = this.targetId_ == null;
					if (flag5)
					{
						this.TargetId = new EntityId();
					}
					this.TargetId.MergeFrom(other.TargetId);
				}
				bool hasRole = other.HasRole;
				if (hasRole)
				{
					this.Role = other.Role;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005FC0 RID: 24512 RVA: 0x00173020 File Offset: 0x00171220
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005FC1 RID: 24513 RVA: 0x0017302C File Offset: 0x0017122C
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Role = input.ReadUInt32();
						}
					}
					else
					{
						bool flag = this.targetId_ == null;
						if (flag)
						{
							this.TargetId = new EntityId();
						}
						input.ReadMessage(this.TargetId);
					}
				}
				else
				{
					bool flag2 = this.agentId_ == null;
					if (flag2)
					{
						this.AgentId = new EntityId();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x04002BBA RID: 11194
		private static readonly MessageParser<BlockPlayerRequest> _parser = new MessageParser<BlockPlayerRequest>(() => new BlockPlayerRequest());

		// Token: 0x04002BBB RID: 11195
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BBC RID: 11196
		private int _hasBits0;

		// Token: 0x04002BBD RID: 11197
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04002BBE RID: 11198
		private EntityId agentId_;

		// Token: 0x04002BBF RID: 11199
		public const int TargetIdFieldNumber = 2;

		// Token: 0x04002BC0 RID: 11200
		private EntityId targetId_;

		// Token: 0x04002BC1 RID: 11201
		public const int RoleFieldNumber = 3;

		// Token: 0x04002BC2 RID: 11202
		private static readonly uint RoleDefaultValue = 0U;

		// Token: 0x04002BC3 RID: 11203
		private uint role_;
	}
}
