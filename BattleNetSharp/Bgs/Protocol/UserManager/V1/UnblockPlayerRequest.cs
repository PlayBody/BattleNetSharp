using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.UserManager.V1
{
	// Token: 0x020003B9 RID: 953
	public sealed class UnblockPlayerRequest : IMessage<UnblockPlayerRequest>, IMessage, IEquatable<UnblockPlayerRequest>, IDeepCloneable<UnblockPlayerRequest>, IBufferMessage
	{
		// Token: 0x17001EF2 RID: 7922
		// (get) Token: 0x06005FC3 RID: 24515 RVA: 0x0017310C File Offset: 0x0017130C
		[DebuggerNonUserCode]
		public static MessageParser<UnblockPlayerRequest> Parser
		{
			get
			{
				return UnblockPlayerRequest._parser;
			}
		}

		// Token: 0x17001EF3 RID: 7923
		// (get) Token: 0x06005FC4 RID: 24516 RVA: 0x00173124 File Offset: 0x00171324
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UserManagerServiceReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17001EF4 RID: 7924
		// (get) Token: 0x06005FC5 RID: 24517 RVA: 0x00173148 File Offset: 0x00171348
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnblockPlayerRequest.Descriptor;
			}
		}

		// Token: 0x06005FC6 RID: 24518 RVA: 0x0017315F File Offset: 0x0017135F
		[DebuggerNonUserCode]
		public UnblockPlayerRequest()
		{
		}

		// Token: 0x06005FC7 RID: 24519 RVA: 0x0017316C File Offset: 0x0017136C
		[DebuggerNonUserCode]
		public UnblockPlayerRequest(UnblockPlayerRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.targetId_ = ((other.targetId_ != null) ? other.targetId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005FC8 RID: 24520 RVA: 0x001731CC File Offset: 0x001713CC
		[DebuggerNonUserCode]
		public UnblockPlayerRequest Clone()
		{
			return new UnblockPlayerRequest(this);
		}

		// Token: 0x17001EF5 RID: 7925
		// (get) Token: 0x06005FC9 RID: 24521 RVA: 0x001731E4 File Offset: 0x001713E4
		// (set) Token: 0x06005FCA RID: 24522 RVA: 0x001731FC File Offset: 0x001713FC
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

		// Token: 0x17001EF6 RID: 7926
		// (get) Token: 0x06005FCB RID: 24523 RVA: 0x00173208 File Offset: 0x00171408
		// (set) Token: 0x06005FCC RID: 24524 RVA: 0x00173220 File Offset: 0x00171420
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

		// Token: 0x06005FCD RID: 24525 RVA: 0x0017322C File Offset: 0x0017142C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnblockPlayerRequest);
		}

		// Token: 0x06005FCE RID: 24526 RVA: 0x0017324C File Offset: 0x0017144C
		[DebuggerNonUserCode]
		public bool Equals(UnblockPlayerRequest other)
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
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005FCF RID: 24527 RVA: 0x001732C4 File Offset: 0x001714C4
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
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005FD0 RID: 24528 RVA: 0x00173330 File Offset: 0x00171530
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005FD1 RID: 24529 RVA: 0x00173348 File Offset: 0x00171548
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005FD2 RID: 24530 RVA: 0x00173354 File Offset: 0x00171554
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
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005FD3 RID: 24531 RVA: 0x001733C8 File Offset: 0x001715C8
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
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005FD4 RID: 24532 RVA: 0x0017343C File Offset: 0x0017163C
		[DebuggerNonUserCode]
		public void MergeFrom(UnblockPlayerRequest other)
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
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005FD5 RID: 24533 RVA: 0x001734E9 File Offset: 0x001716E9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005FD6 RID: 24534 RVA: 0x001734F4 File Offset: 0x001716F4
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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

		// Token: 0x04002BC4 RID: 11204
		private static readonly MessageParser<UnblockPlayerRequest> _parser = new MessageParser<UnblockPlayerRequest>(() => new UnblockPlayerRequest());

		// Token: 0x04002BC5 RID: 11205
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BC6 RID: 11206
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04002BC7 RID: 11207
		private EntityId agentId_;

		// Token: 0x04002BC8 RID: 11208
		public const int TargetIdFieldNumber = 2;

		// Token: 0x04002BC9 RID: 11209
		private EntityId targetId_;
	}
}
