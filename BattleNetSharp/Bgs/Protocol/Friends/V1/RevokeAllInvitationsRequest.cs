using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Friends.V1
{
	// Token: 0x0200040A RID: 1034
	public sealed class RevokeAllInvitationsRequest : IMessage<RevokeAllInvitationsRequest>, IMessage, IEquatable<RevokeAllInvitationsRequest>, IDeepCloneable<RevokeAllInvitationsRequest>, IBufferMessage
	{
		// Token: 0x170020C2 RID: 8386
		// (get) Token: 0x0600663C RID: 26172 RVA: 0x0018B890 File Offset: 0x00189A90
		[DebuggerNonUserCode]
		public static MessageParser<RevokeAllInvitationsRequest> Parser
		{
			get
			{
				return RevokeAllInvitationsRequest._parser;
			}
		}

		// Token: 0x170020C3 RID: 8387
		// (get) Token: 0x0600663D RID: 26173 RVA: 0x0018B8A8 File Offset: 0x00189AA8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x170020C4 RID: 8388
		// (get) Token: 0x0600663E RID: 26174 RVA: 0x0018B8CC File Offset: 0x00189ACC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RevokeAllInvitationsRequest.Descriptor;
			}
		}

		// Token: 0x0600663F RID: 26175 RVA: 0x0018B8E3 File Offset: 0x00189AE3
		[DebuggerNonUserCode]
		public RevokeAllInvitationsRequest()
		{
		}

		// Token: 0x06006640 RID: 26176 RVA: 0x0018B8ED File Offset: 0x00189AED
		[DebuggerNonUserCode]
		public RevokeAllInvitationsRequest(RevokeAllInvitationsRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006641 RID: 26177 RVA: 0x0018B924 File Offset: 0x00189B24
		[DebuggerNonUserCode]
		public RevokeAllInvitationsRequest Clone()
		{
			return new RevokeAllInvitationsRequest(this);
		}

		// Token: 0x170020C5 RID: 8389
		// (get) Token: 0x06006642 RID: 26178 RVA: 0x0018B93C File Offset: 0x00189B3C
		// (set) Token: 0x06006643 RID: 26179 RVA: 0x0018B954 File Offset: 0x00189B54
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

		// Token: 0x06006644 RID: 26180 RVA: 0x0018B960 File Offset: 0x00189B60
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RevokeAllInvitationsRequest);
		}

		// Token: 0x06006645 RID: 26181 RVA: 0x0018B980 File Offset: 0x00189B80
		[DebuggerNonUserCode]
		public bool Equals(RevokeAllInvitationsRequest other)
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
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06006646 RID: 26182 RVA: 0x0018B9DC File Offset: 0x00189BDC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006647 RID: 26183 RVA: 0x0018BA2C File Offset: 0x00189C2C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006648 RID: 26184 RVA: 0x0018BA44 File Offset: 0x00189C44
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006649 RID: 26185 RVA: 0x0018BA50 File Offset: 0x00189C50
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600664A RID: 26186 RVA: 0x0018BAA0 File Offset: 0x00189CA0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600664B RID: 26187 RVA: 0x0018BAF4 File Offset: 0x00189CF4
		[DebuggerNonUserCode]
		public void MergeFrom(RevokeAllInvitationsRequest other)
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
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600664C RID: 26188 RVA: 0x0018BB60 File Offset: 0x00189D60
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600664D RID: 26189 RVA: 0x0018BB6C File Offset: 0x00189D6C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					bool flag = this.agentId_ == null;
					if (flag)
					{
						this.AgentId = new EntityId();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x04002E76 RID: 11894
		private static readonly MessageParser<RevokeAllInvitationsRequest> _parser = new MessageParser<RevokeAllInvitationsRequest>(() => new RevokeAllInvitationsRequest());

		// Token: 0x04002E77 RID: 11895
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E78 RID: 11896
		public const int AgentIdFieldNumber = 2;

		// Token: 0x04002E79 RID: 11897
		private EntityId agentId_;
	}
}
