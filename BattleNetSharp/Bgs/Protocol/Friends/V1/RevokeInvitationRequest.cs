using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Friends.V1
{
	// Token: 0x02000405 RID: 1029
	public sealed class RevokeInvitationRequest : IMessage<RevokeInvitationRequest>, IMessage, IEquatable<RevokeInvitationRequest>, IDeepCloneable<RevokeInvitationRequest>, IBufferMessage
	{
		// Token: 0x170020A4 RID: 8356
		// (get) Token: 0x060065C9 RID: 26057 RVA: 0x00189FFC File Offset: 0x001881FC
		[DebuggerNonUserCode]
		public static MessageParser<RevokeInvitationRequest> Parser
		{
			get
			{
				return RevokeInvitationRequest._parser;
			}
		}

		// Token: 0x170020A5 RID: 8357
		// (get) Token: 0x060065CA RID: 26058 RVA: 0x0018A014 File Offset: 0x00188214
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x170020A6 RID: 8358
		// (get) Token: 0x060065CB RID: 26059 RVA: 0x0018A038 File Offset: 0x00188238
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RevokeInvitationRequest.Descriptor;
			}
		}

		// Token: 0x060065CC RID: 26060 RVA: 0x0018A04F File Offset: 0x0018824F
		[DebuggerNonUserCode]
		public RevokeInvitationRequest()
		{
		}

		// Token: 0x060065CD RID: 26061 RVA: 0x0018A05C File Offset: 0x0018825C
		[DebuggerNonUserCode]
		public RevokeInvitationRequest(RevokeInvitationRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.invitationId_ = other.invitationId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060065CE RID: 26062 RVA: 0x0018A0B8 File Offset: 0x001882B8
		[DebuggerNonUserCode]
		public RevokeInvitationRequest Clone()
		{
			return new RevokeInvitationRequest(this);
		}

		// Token: 0x170020A7 RID: 8359
		// (get) Token: 0x060065CF RID: 26063 RVA: 0x0018A0D0 File Offset: 0x001882D0
		// (set) Token: 0x060065D0 RID: 26064 RVA: 0x0018A0E8 File Offset: 0x001882E8
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

		// Token: 0x170020A8 RID: 8360
		// (get) Token: 0x060065D1 RID: 26065 RVA: 0x0018A0F4 File Offset: 0x001882F4
		// (set) Token: 0x060065D2 RID: 26066 RVA: 0x0018A125 File Offset: 0x00188325
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
					invitationIdDefaultValue = RevokeInvitationRequest.InvitationIdDefaultValue;
				}
				return invitationIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.invitationId_ = value;
			}
		}

		// Token: 0x170020A9 RID: 8361
		// (get) Token: 0x060065D3 RID: 26067 RVA: 0x0018A140 File Offset: 0x00188340
		[DebuggerNonUserCode]
		public bool HasInvitationId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060065D4 RID: 26068 RVA: 0x0018A15D File Offset: 0x0018835D
		[DebuggerNonUserCode]
		public void ClearInvitationId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060065D5 RID: 26069 RVA: 0x0018A170 File Offset: 0x00188370
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RevokeInvitationRequest);
		}

		// Token: 0x060065D6 RID: 26070 RVA: 0x0018A190 File Offset: 0x00188390
		[DebuggerNonUserCode]
		public bool Equals(RevokeInvitationRequest other)
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

		// Token: 0x060065D7 RID: 26071 RVA: 0x0018A204 File Offset: 0x00188404
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

		// Token: 0x060065D8 RID: 26072 RVA: 0x0018A270 File Offset: 0x00188470
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060065D9 RID: 26073 RVA: 0x0018A288 File Offset: 0x00188488
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060065DA RID: 26074 RVA: 0x0018A294 File Offset: 0x00188494
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
				output.WriteRawTag(17);
				output.WriteFixed64(this.InvitationId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060065DB RID: 26075 RVA: 0x0018A308 File Offset: 0x00188508
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

		// Token: 0x060065DC RID: 26076 RVA: 0x0018A36C File Offset: 0x0018856C
		[DebuggerNonUserCode]
		public void MergeFrom(RevokeInvitationRequest other)
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

		// Token: 0x060065DD RID: 26077 RVA: 0x0018A3F1 File Offset: 0x001885F1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060065DE RID: 26078 RVA: 0x0018A3FC File Offset: 0x001885FC
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
					if (num3 != 17U)
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

		// Token: 0x04002E4E RID: 11854
		private static readonly MessageParser<RevokeInvitationRequest> _parser = new MessageParser<RevokeInvitationRequest>(() => new RevokeInvitationRequest());

		// Token: 0x04002E4F RID: 11855
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E50 RID: 11856
		private int _hasBits0;

		// Token: 0x04002E51 RID: 11857
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04002E52 RID: 11858
		private EntityId agentId_;

		// Token: 0x04002E53 RID: 11859
		public const int InvitationIdFieldNumber = 2;

		// Token: 0x04002E54 RID: 11860
		private static readonly ulong InvitationIdDefaultValue = 0UL;

		// Token: 0x04002E55 RID: 11861
		private ulong invitationId_;
	}
}
