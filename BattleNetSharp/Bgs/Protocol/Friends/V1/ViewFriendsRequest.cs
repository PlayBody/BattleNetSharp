using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Friends.V1
{
	// Token: 0x0200040B RID: 1035
	public sealed class ViewFriendsRequest : IMessage<ViewFriendsRequest>, IMessage, IEquatable<ViewFriendsRequest>, IDeepCloneable<ViewFriendsRequest>, IBufferMessage
	{
		// Token: 0x170020C6 RID: 8390
		// (get) Token: 0x0600664F RID: 26191 RVA: 0x0018BBF8 File Offset: 0x00189DF8
		[DebuggerNonUserCode]
		public static MessageParser<ViewFriendsRequest> Parser
		{
			get
			{
				return ViewFriendsRequest._parser;
			}
		}

		// Token: 0x170020C7 RID: 8391
		// (get) Token: 0x06006650 RID: 26192 RVA: 0x0018BC10 File Offset: 0x00189E10
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x170020C8 RID: 8392
		// (get) Token: 0x06006651 RID: 26193 RVA: 0x0018BC34 File Offset: 0x00189E34
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ViewFriendsRequest.Descriptor;
			}
		}

		// Token: 0x06006652 RID: 26194 RVA: 0x0018BC4B File Offset: 0x00189E4B
		[DebuggerNonUserCode]
		public ViewFriendsRequest()
		{
		}

		// Token: 0x06006653 RID: 26195 RVA: 0x0018BC58 File Offset: 0x00189E58
		[DebuggerNonUserCode]
		public ViewFriendsRequest(ViewFriendsRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.targetId_ = ((other.targetId_ != null) ? other.targetId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006654 RID: 26196 RVA: 0x0018BCB8 File Offset: 0x00189EB8
		[DebuggerNonUserCode]
		public ViewFriendsRequest Clone()
		{
			return new ViewFriendsRequest(this);
		}

		// Token: 0x170020C9 RID: 8393
		// (get) Token: 0x06006655 RID: 26197 RVA: 0x0018BCD0 File Offset: 0x00189ED0
		// (set) Token: 0x06006656 RID: 26198 RVA: 0x0018BCE8 File Offset: 0x00189EE8
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

		// Token: 0x170020CA RID: 8394
		// (get) Token: 0x06006657 RID: 26199 RVA: 0x0018BCF4 File Offset: 0x00189EF4
		// (set) Token: 0x06006658 RID: 26200 RVA: 0x0018BD0C File Offset: 0x00189F0C
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

		// Token: 0x06006659 RID: 26201 RVA: 0x0018BD18 File Offset: 0x00189F18
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ViewFriendsRequest);
		}

		// Token: 0x0600665A RID: 26202 RVA: 0x0018BD38 File Offset: 0x00189F38
		[DebuggerNonUserCode]
		public bool Equals(ViewFriendsRequest other)
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

		// Token: 0x0600665B RID: 26203 RVA: 0x0018BDB0 File Offset: 0x00189FB0
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

		// Token: 0x0600665C RID: 26204 RVA: 0x0018BE1C File Offset: 0x0018A01C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600665D RID: 26205 RVA: 0x0018BE34 File Offset: 0x0018A034
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600665E RID: 26206 RVA: 0x0018BE40 File Offset: 0x0018A040
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

		// Token: 0x0600665F RID: 26207 RVA: 0x0018BEB4 File Offset: 0x0018A0B4
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

		// Token: 0x06006660 RID: 26208 RVA: 0x0018BF28 File Offset: 0x0018A128
		[DebuggerNonUserCode]
		public void MergeFrom(ViewFriendsRequest other)
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

		// Token: 0x06006661 RID: 26209 RVA: 0x0018BFD5 File Offset: 0x0018A1D5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006662 RID: 26210 RVA: 0x0018BFE0 File Offset: 0x0018A1E0
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

		// Token: 0x04002E7A RID: 11898
		private static readonly MessageParser<ViewFriendsRequest> _parser = new MessageParser<ViewFriendsRequest>(() => new ViewFriendsRequest());

		// Token: 0x04002E7B RID: 11899
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E7C RID: 11900
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04002E7D RID: 11901
		private EntityId agentId_;

		// Token: 0x04002E7E RID: 11902
		public const int TargetIdFieldNumber = 2;

		// Token: 0x04002E7F RID: 11903
		private EntityId targetId_;
	}
}
