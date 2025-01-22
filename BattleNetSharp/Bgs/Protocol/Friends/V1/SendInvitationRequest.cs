using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Friends.V1
{
	// Token: 0x02000404 RID: 1028
	public sealed class SendInvitationRequest : IMessage<SendInvitationRequest>, IMessage, IEquatable<SendInvitationRequest>, IDeepCloneable<SendInvitationRequest>, IBufferMessage
	{
		// Token: 0x1700209E RID: 8350
		// (get) Token: 0x060065B2 RID: 26034 RVA: 0x00189A14 File Offset: 0x00187C14
		[DebuggerNonUserCode]
		public static MessageParser<SendInvitationRequest> Parser
		{
			get
			{
				return SendInvitationRequest._parser;
			}
		}

		// Token: 0x1700209F RID: 8351
		// (get) Token: 0x060065B3 RID: 26035 RVA: 0x00189A2C File Offset: 0x00187C2C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x170020A0 RID: 8352
		// (get) Token: 0x060065B4 RID: 26036 RVA: 0x00189A50 File Offset: 0x00187C50
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SendInvitationRequest.Descriptor;
			}
		}

		// Token: 0x060065B5 RID: 26037 RVA: 0x00189A67 File Offset: 0x00187C67
		[DebuggerNonUserCode]
		public SendInvitationRequest()
		{
		}

		// Token: 0x060065B6 RID: 26038 RVA: 0x00189A74 File Offset: 0x00187C74
		[DebuggerNonUserCode]
		public SendInvitationRequest(SendInvitationRequest other)
			: this()
		{
			this.agentIdentity_ = ((other.agentIdentity_ != null) ? other.agentIdentity_.Clone() : null);
			this.targetId_ = ((other.targetId_ != null) ? other.targetId_.Clone() : null);
			this.params_ = ((other.params_ != null) ? other.params_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060065B7 RID: 26039 RVA: 0x00189AF0 File Offset: 0x00187CF0
		[DebuggerNonUserCode]
		public SendInvitationRequest Clone()
		{
			return new SendInvitationRequest(this);
		}

		// Token: 0x170020A1 RID: 8353
		// (get) Token: 0x060065B8 RID: 26040 RVA: 0x00189B08 File Offset: 0x00187D08
		// (set) Token: 0x060065B9 RID: 26041 RVA: 0x00189B20 File Offset: 0x00187D20
		[DebuggerNonUserCode]
		public Identity AgentIdentity
		{
			get
			{
				return this.agentIdentity_;
			}
			set
			{
				this.agentIdentity_ = value;
			}
		}

		// Token: 0x170020A2 RID: 8354
		// (get) Token: 0x060065BA RID: 26042 RVA: 0x00189B2C File Offset: 0x00187D2C
		// (set) Token: 0x060065BB RID: 26043 RVA: 0x00189B44 File Offset: 0x00187D44
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

		// Token: 0x170020A3 RID: 8355
		// (get) Token: 0x060065BC RID: 26044 RVA: 0x00189B50 File Offset: 0x00187D50
		// (set) Token: 0x060065BD RID: 26045 RVA: 0x00189B68 File Offset: 0x00187D68
		[DebuggerNonUserCode]
		public InvitationParams Params
		{
			get
			{
				return this.params_;
			}
			set
			{
				this.params_ = value;
			}
		}

		// Token: 0x060065BE RID: 26046 RVA: 0x00189B74 File Offset: 0x00187D74
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SendInvitationRequest);
		}

		// Token: 0x060065BF RID: 26047 RVA: 0x00189B94 File Offset: 0x00187D94
		[DebuggerNonUserCode]
		public bool Equals(SendInvitationRequest other)
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
					bool flag4 = !object.Equals(this.AgentIdentity, other.AgentIdentity);
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
							bool flag6 = !object.Equals(this.Params, other.Params);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060065C0 RID: 26048 RVA: 0x00189C2C File Offset: 0x00187E2C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentIdentity_ != null;
			if (flag)
			{
				num ^= this.AgentIdentity.GetHashCode();
			}
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				num ^= this.TargetId.GetHashCode();
			}
			bool flag3 = this.params_ != null;
			if (flag3)
			{
				num ^= this.Params.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060065C1 RID: 26049 RVA: 0x00189CB4 File Offset: 0x00187EB4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060065C2 RID: 26050 RVA: 0x00189CCC File Offset: 0x00187ECC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060065C3 RID: 26051 RVA: 0x00189CD8 File Offset: 0x00187ED8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentIdentity_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentIdentity);
			}
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.TargetId);
			}
			bool flag3 = this.params_ != null;
			if (flag3)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Params);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060065C4 RID: 26052 RVA: 0x00189D74 File Offset: 0x00187F74
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentIdentity_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentIdentity);
			}
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetId);
			}
			bool flag3 = this.params_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Params);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060065C5 RID: 26053 RVA: 0x00189E08 File Offset: 0x00188008
		[DebuggerNonUserCode]
		public void MergeFrom(SendInvitationRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.agentIdentity_ != null;
				if (flag2)
				{
					bool flag3 = this.agentIdentity_ == null;
					if (flag3)
					{
						this.AgentIdentity = new Identity();
					}
					this.AgentIdentity.MergeFrom(other.AgentIdentity);
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
				bool flag6 = other.params_ != null;
				if (flag6)
				{
					bool flag7 = this.params_ == null;
					if (flag7)
					{
						this.Params = new InvitationParams();
					}
					this.Params.MergeFrom(other.Params);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060065C6 RID: 26054 RVA: 0x00189EF5 File Offset: 0x001880F5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060065C7 RID: 26055 RVA: 0x00189F00 File Offset: 0x00188100
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
							bool flag = this.params_ == null;
							if (flag)
							{
								this.Params = new InvitationParams();
							}
							input.ReadMessage(this.Params);
						}
					}
					else
					{
						bool flag2 = this.targetId_ == null;
						if (flag2)
						{
							this.TargetId = new EntityId();
						}
						input.ReadMessage(this.TargetId);
					}
				}
				else
				{
					bool flag3 = this.agentIdentity_ == null;
					if (flag3)
					{
						this.AgentIdentity = new Identity();
					}
					input.ReadMessage(this.AgentIdentity);
				}
			}
		}

		// Token: 0x04002E46 RID: 11846
		private static readonly MessageParser<SendInvitationRequest> _parser = new MessageParser<SendInvitationRequest>(() => new SendInvitationRequest());

		// Token: 0x04002E47 RID: 11847
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E48 RID: 11848
		public const int AgentIdentityFieldNumber = 1;

		// Token: 0x04002E49 RID: 11849
		private Identity agentIdentity_;

		// Token: 0x04002E4A RID: 11850
		public const int TargetIdFieldNumber = 2;

		// Token: 0x04002E4B RID: 11851
		private EntityId targetId_;

		// Token: 0x04002E4C RID: 11852
		public const int ParamsFieldNumber = 3;

		// Token: 0x04002E4D RID: 11853
		private InvitationParams params_;
	}
}
