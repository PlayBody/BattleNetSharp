using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Friends.V1
{
	// Token: 0x02000408 RID: 1032
	public sealed class IgnoreInvitationRequest : IMessage<IgnoreInvitationRequest>, IMessage, IEquatable<IgnoreInvitationRequest>, IDeepCloneable<IgnoreInvitationRequest>, IBufferMessage
	{
		// Token: 0x170020B7 RID: 8375
		// (get) Token: 0x06006610 RID: 26128 RVA: 0x0018AF3C File Offset: 0x0018913C
		[DebuggerNonUserCode]
		public static MessageParser<IgnoreInvitationRequest> Parser
		{
			get
			{
				return IgnoreInvitationRequest._parser;
			}
		}

		// Token: 0x170020B8 RID: 8376
		// (get) Token: 0x06006611 RID: 26129 RVA: 0x0018AF54 File Offset: 0x00189154
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x170020B9 RID: 8377
		// (get) Token: 0x06006612 RID: 26130 RVA: 0x0018AF78 File Offset: 0x00189178
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IgnoreInvitationRequest.Descriptor;
			}
		}

		// Token: 0x06006613 RID: 26131 RVA: 0x0018AF8F File Offset: 0x0018918F
		[DebuggerNonUserCode]
		public IgnoreInvitationRequest()
		{
		}

		// Token: 0x06006614 RID: 26132 RVA: 0x0018AF9C File Offset: 0x0018919C
		[DebuggerNonUserCode]
		public IgnoreInvitationRequest(IgnoreInvitationRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.invitationId_ = other.invitationId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006615 RID: 26133 RVA: 0x0018AFF8 File Offset: 0x001891F8
		[DebuggerNonUserCode]
		public IgnoreInvitationRequest Clone()
		{
			return new IgnoreInvitationRequest(this);
		}

		// Token: 0x170020BA RID: 8378
		// (get) Token: 0x06006616 RID: 26134 RVA: 0x0018B010 File Offset: 0x00189210
		// (set) Token: 0x06006617 RID: 26135 RVA: 0x0018B028 File Offset: 0x00189228
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

		// Token: 0x170020BB RID: 8379
		// (get) Token: 0x06006618 RID: 26136 RVA: 0x0018B034 File Offset: 0x00189234
		// (set) Token: 0x06006619 RID: 26137 RVA: 0x0018B065 File Offset: 0x00189265
		[DebuggerNonUserCode]
		public ulong InvitationId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong invitationIdDefaultValue;
				if (flag)
				{
					invitationIdDefaultValue = this.invitationId_;
				}
				else
				{
					invitationIdDefaultValue = IgnoreInvitationRequest.InvitationIdDefaultValue;
				}
				return invitationIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.invitationId_ = value;
			}
		}

		// Token: 0x170020BC RID: 8380
		// (get) Token: 0x0600661A RID: 26138 RVA: 0x0018B080 File Offset: 0x00189280
		[DebuggerNonUserCode]
		public bool HasInvitationId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600661B RID: 26139 RVA: 0x0018B09D File Offset: 0x0018929D
		[DebuggerNonUserCode]
		public void ClearInvitationId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600661C RID: 26140 RVA: 0x0018B0B0 File Offset: 0x001892B0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as IgnoreInvitationRequest);
		}

		// Token: 0x0600661D RID: 26141 RVA: 0x0018B0D0 File Offset: 0x001892D0
		[DebuggerNonUserCode]
		public bool Equals(IgnoreInvitationRequest other)
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
						bool flag5 = this.InvitationId != other.InvitationId;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600661E RID: 26142 RVA: 0x0018B144 File Offset: 0x00189344
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool hasInvitationId = this.HasInvitationId;
			if (hasInvitationId)
			{
				num ^= this.InvitationId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600661F RID: 26143 RVA: 0x0018B1B0 File Offset: 0x001893B0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006620 RID: 26144 RVA: 0x0018B1C8 File Offset: 0x001893C8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006621 RID: 26145 RVA: 0x0018B1D4 File Offset: 0x001893D4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool hasInvitationId = this.HasInvitationId;
			if (hasInvitationId)
			{
				output.WriteRawTag(25);
				output.WriteFixed64(this.InvitationId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006622 RID: 26146 RVA: 0x0018B248 File Offset: 0x00189448
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool hasInvitationId = this.HasInvitationId;
			if (hasInvitationId)
			{
				num += 9;
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006623 RID: 26147 RVA: 0x0018B2AC File Offset: 0x001894AC
		[DebuggerNonUserCode]
		public void MergeFrom(IgnoreInvitationRequest other)
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
				bool hasInvitationId = other.HasInvitationId;
				if (hasInvitationId)
				{
					this.InvitationId = other.InvitationId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006624 RID: 26148 RVA: 0x0018B331 File Offset: 0x00189531
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006625 RID: 26149 RVA: 0x0018B33C File Offset: 0x0018953C
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
					if (num3 != 25U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.InvitationId = input.ReadFixed64();
					}
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

		// Token: 0x04002E68 RID: 11880
		private static readonly MessageParser<IgnoreInvitationRequest> _parser = new MessageParser<IgnoreInvitationRequest>(() => new IgnoreInvitationRequest());

		// Token: 0x04002E69 RID: 11881
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E6A RID: 11882
		private int _hasBits0;

		// Token: 0x04002E6B RID: 11883
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04002E6C RID: 11884
		private EntityId agentId_;

		// Token: 0x04002E6D RID: 11885
		public const int InvitationIdFieldNumber = 3;

		// Token: 0x04002E6E RID: 11886
		private static readonly ulong InvitationIdDefaultValue = 0UL;

		// Token: 0x04002E6F RID: 11887
		private ulong invitationId_;
	}
}
