using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Friends.V1
{
	// Token: 0x02000407 RID: 1031
	public sealed class DeclineInvitationRequest : IMessage<DeclineInvitationRequest>, IMessage, IEquatable<DeclineInvitationRequest>, IDeepCloneable<DeclineInvitationRequest>, IBufferMessage
	{
		// Token: 0x170020B1 RID: 8369
		// (get) Token: 0x060065F9 RID: 26105 RVA: 0x0018AA94 File Offset: 0x00188C94
		[DebuggerNonUserCode]
		public static MessageParser<DeclineInvitationRequest> Parser
		{
			get
			{
				return DeclineInvitationRequest._parser;
			}
		}

		// Token: 0x170020B2 RID: 8370
		// (get) Token: 0x060065FA RID: 26106 RVA: 0x0018AAAC File Offset: 0x00188CAC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x170020B3 RID: 8371
		// (get) Token: 0x060065FB RID: 26107 RVA: 0x0018AAD0 File Offset: 0x00188CD0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeclineInvitationRequest.Descriptor;
			}
		}

		// Token: 0x060065FC RID: 26108 RVA: 0x0018AAE7 File Offset: 0x00188CE7
		[DebuggerNonUserCode]
		public DeclineInvitationRequest()
		{
		}

		// Token: 0x060065FD RID: 26109 RVA: 0x0018AAF4 File Offset: 0x00188CF4
		[DebuggerNonUserCode]
		public DeclineInvitationRequest(DeclineInvitationRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.invitationId_ = other.invitationId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060065FE RID: 26110 RVA: 0x0018AB50 File Offset: 0x00188D50
		[DebuggerNonUserCode]
		public DeclineInvitationRequest Clone()
		{
			return new DeclineInvitationRequest(this);
		}

		// Token: 0x170020B4 RID: 8372
		// (get) Token: 0x060065FF RID: 26111 RVA: 0x0018AB68 File Offset: 0x00188D68
		// (set) Token: 0x06006600 RID: 26112 RVA: 0x0018AB80 File Offset: 0x00188D80
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

		// Token: 0x170020B5 RID: 8373
		// (get) Token: 0x06006601 RID: 26113 RVA: 0x0018AB8C File Offset: 0x00188D8C
		// (set) Token: 0x06006602 RID: 26114 RVA: 0x0018ABBD File Offset: 0x00188DBD
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
					invitationIdDefaultValue = DeclineInvitationRequest.InvitationIdDefaultValue;
				}
				return invitationIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.invitationId_ = value;
			}
		}

		// Token: 0x170020B6 RID: 8374
		// (get) Token: 0x06006603 RID: 26115 RVA: 0x0018ABD8 File Offset: 0x00188DD8
		[DebuggerNonUserCode]
		public bool HasInvitationId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006604 RID: 26116 RVA: 0x0018ABF5 File Offset: 0x00188DF5
		[DebuggerNonUserCode]
		public void ClearInvitationId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06006605 RID: 26117 RVA: 0x0018AC08 File Offset: 0x00188E08
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeclineInvitationRequest);
		}

		// Token: 0x06006606 RID: 26118 RVA: 0x0018AC28 File Offset: 0x00188E28
		[DebuggerNonUserCode]
		public bool Equals(DeclineInvitationRequest other)
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

		// Token: 0x06006607 RID: 26119 RVA: 0x0018AC9C File Offset: 0x00188E9C
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

		// Token: 0x06006608 RID: 26120 RVA: 0x0018AD08 File Offset: 0x00188F08
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006609 RID: 26121 RVA: 0x0018AD20 File Offset: 0x00188F20
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600660A RID: 26122 RVA: 0x0018AD2C File Offset: 0x00188F2C
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

		// Token: 0x0600660B RID: 26123 RVA: 0x0018ADA0 File Offset: 0x00188FA0
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

		// Token: 0x0600660C RID: 26124 RVA: 0x0018AE04 File Offset: 0x00189004
		[DebuggerNonUserCode]
		public void MergeFrom(DeclineInvitationRequest other)
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

		// Token: 0x0600660D RID: 26125 RVA: 0x0018AE89 File Offset: 0x00189089
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600660E RID: 26126 RVA: 0x0018AE94 File Offset: 0x00189094
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

		// Token: 0x04002E60 RID: 11872
		private static readonly MessageParser<DeclineInvitationRequest> _parser = new MessageParser<DeclineInvitationRequest>(() => new DeclineInvitationRequest());

		// Token: 0x04002E61 RID: 11873
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E62 RID: 11874
		private int _hasBits0;

		// Token: 0x04002E63 RID: 11875
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04002E64 RID: 11876
		private EntityId agentId_;

		// Token: 0x04002E65 RID: 11877
		public const int InvitationIdFieldNumber = 3;

		// Token: 0x04002E66 RID: 11878
		private static readonly ulong InvitationIdDefaultValue = 0UL;

		// Token: 0x04002E67 RID: 11879
		private ulong invitationId_;
	}
}
