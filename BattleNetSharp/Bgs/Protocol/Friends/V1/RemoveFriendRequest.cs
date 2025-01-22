using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Friends.V1
{
	// Token: 0x02000409 RID: 1033
	public sealed class RemoveFriendRequest : IMessage<RemoveFriendRequest>, IMessage, IEquatable<RemoveFriendRequest>, IDeepCloneable<RemoveFriendRequest>, IBufferMessage
	{
		// Token: 0x170020BD RID: 8381
		// (get) Token: 0x06006627 RID: 26151 RVA: 0x0018B3E4 File Offset: 0x001895E4
		[DebuggerNonUserCode]
		public static MessageParser<RemoveFriendRequest> Parser
		{
			get
			{
				return RemoveFriendRequest._parser;
			}
		}

		// Token: 0x170020BE RID: 8382
		// (get) Token: 0x06006628 RID: 26152 RVA: 0x0018B3FC File Offset: 0x001895FC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x170020BF RID: 8383
		// (get) Token: 0x06006629 RID: 26153 RVA: 0x0018B420 File Offset: 0x00189620
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveFriendRequest.Descriptor;
			}
		}

		// Token: 0x0600662A RID: 26154 RVA: 0x0018B437 File Offset: 0x00189637
		[DebuggerNonUserCode]
		public RemoveFriendRequest()
		{
		}

		// Token: 0x0600662B RID: 26155 RVA: 0x0018B444 File Offset: 0x00189644
		[DebuggerNonUserCode]
		public RemoveFriendRequest(RemoveFriendRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.targetId_ = ((other.targetId_ != null) ? other.targetId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600662C RID: 26156 RVA: 0x0018B4A4 File Offset: 0x001896A4
		[DebuggerNonUserCode]
		public RemoveFriendRequest Clone()
		{
			return new RemoveFriendRequest(this);
		}

		// Token: 0x170020C0 RID: 8384
		// (get) Token: 0x0600662D RID: 26157 RVA: 0x0018B4BC File Offset: 0x001896BC
		// (set) Token: 0x0600662E RID: 26158 RVA: 0x0018B4D4 File Offset: 0x001896D4
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

		// Token: 0x170020C1 RID: 8385
		// (get) Token: 0x0600662F RID: 26159 RVA: 0x0018B4E0 File Offset: 0x001896E0
		// (set) Token: 0x06006630 RID: 26160 RVA: 0x0018B4F8 File Offset: 0x001896F8
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

		// Token: 0x06006631 RID: 26161 RVA: 0x0018B504 File Offset: 0x00189704
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveFriendRequest);
		}

		// Token: 0x06006632 RID: 26162 RVA: 0x0018B524 File Offset: 0x00189724
		[DebuggerNonUserCode]
		public bool Equals(RemoveFriendRequest other)
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

		// Token: 0x06006633 RID: 26163 RVA: 0x0018B59C File Offset: 0x0018979C
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

		// Token: 0x06006634 RID: 26164 RVA: 0x0018B608 File Offset: 0x00189808
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006635 RID: 26165 RVA: 0x0018B620 File Offset: 0x00189820
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006636 RID: 26166 RVA: 0x0018B62C File Offset: 0x0018982C
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

		// Token: 0x06006637 RID: 26167 RVA: 0x0018B6A0 File Offset: 0x001898A0
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

		// Token: 0x06006638 RID: 26168 RVA: 0x0018B714 File Offset: 0x00189914
		[DebuggerNonUserCode]
		public void MergeFrom(RemoveFriendRequest other)
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

		// Token: 0x06006639 RID: 26169 RVA: 0x0018B7C1 File Offset: 0x001899C1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600663A RID: 26170 RVA: 0x0018B7CC File Offset: 0x001899CC
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

		// Token: 0x04002E70 RID: 11888
		private static readonly MessageParser<RemoveFriendRequest> _parser = new MessageParser<RemoveFriendRequest>(() => new RemoveFriendRequest());

		// Token: 0x04002E71 RID: 11889
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E72 RID: 11890
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04002E73 RID: 11891
		private EntityId agentId_;

		// Token: 0x04002E74 RID: 11892
		public const int TargetIdFieldNumber = 2;

		// Token: 0x04002E75 RID: 11893
		private EntityId targetId_;
	}
}
