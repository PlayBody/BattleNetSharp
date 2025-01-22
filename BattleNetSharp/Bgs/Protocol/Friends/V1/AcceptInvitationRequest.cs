using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Friends.V1
{
	// Token: 0x02000406 RID: 1030
	public sealed class AcceptInvitationRequest : IMessage<AcceptInvitationRequest>, IMessage, IEquatable<AcceptInvitationRequest>, IDeepCloneable<AcceptInvitationRequest>, IBufferMessage
	{
		// Token: 0x170020AA RID: 8362
		// (get) Token: 0x060065E0 RID: 26080 RVA: 0x0018A4A4 File Offset: 0x001886A4
		[DebuggerNonUserCode]
		public static MessageParser<AcceptInvitationRequest> Parser
		{
			get
			{
				return AcceptInvitationRequest._parser;
			}
		}

		// Token: 0x170020AB RID: 8363
		// (get) Token: 0x060065E1 RID: 26081 RVA: 0x0018A4BC File Offset: 0x001886BC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x170020AC RID: 8364
		// (get) Token: 0x060065E2 RID: 26082 RVA: 0x0018A4E0 File Offset: 0x001886E0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AcceptInvitationRequest.Descriptor;
			}
		}

		// Token: 0x060065E3 RID: 26083 RVA: 0x0018A4F7 File Offset: 0x001886F7
		[DebuggerNonUserCode]
		public AcceptInvitationRequest()
		{
		}

		// Token: 0x060065E4 RID: 26084 RVA: 0x0018A504 File Offset: 0x00188704
		[DebuggerNonUserCode]
		public AcceptInvitationRequest(AcceptInvitationRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.invitationId_ = other.invitationId_;
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060065E5 RID: 26085 RVA: 0x0018A57C File Offset: 0x0018877C
		[DebuggerNonUserCode]
		public AcceptInvitationRequest Clone()
		{
			return new AcceptInvitationRequest(this);
		}

		// Token: 0x170020AD RID: 8365
		// (get) Token: 0x060065E6 RID: 26086 RVA: 0x0018A594 File Offset: 0x00188794
		// (set) Token: 0x060065E7 RID: 26087 RVA: 0x0018A5AC File Offset: 0x001887AC
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

		// Token: 0x170020AE RID: 8366
		// (get) Token: 0x060065E8 RID: 26088 RVA: 0x0018A5B8 File Offset: 0x001887B8
		// (set) Token: 0x060065E9 RID: 26089 RVA: 0x0018A5E9 File Offset: 0x001887E9
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
					invitationIdDefaultValue = AcceptInvitationRequest.InvitationIdDefaultValue;
				}
				return invitationIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.invitationId_ = value;
			}
		}

		// Token: 0x170020AF RID: 8367
		// (get) Token: 0x060065EA RID: 26090 RVA: 0x0018A604 File Offset: 0x00188804
		[DebuggerNonUserCode]
		public bool HasInvitationId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060065EB RID: 26091 RVA: 0x0018A621 File Offset: 0x00188821
		[DebuggerNonUserCode]
		public void ClearInvitationId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170020B0 RID: 8368
		// (get) Token: 0x060065EC RID: 26092 RVA: 0x0018A634 File Offset: 0x00188834
		// (set) Token: 0x060065ED RID: 26093 RVA: 0x0018A64C File Offset: 0x0018884C
		[DebuggerNonUserCode]
		public AcceptInvitationOptions Options
		{
			get
			{
				return this.options_;
			}
			set
			{
				this.options_ = value;
			}
		}

		// Token: 0x060065EE RID: 26094 RVA: 0x0018A658 File Offset: 0x00188858
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AcceptInvitationRequest);
		}

		// Token: 0x060065EF RID: 26095 RVA: 0x0018A678 File Offset: 0x00188878
		[DebuggerNonUserCode]
		public bool Equals(AcceptInvitationRequest other)
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
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Options, other.Options);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060065F0 RID: 26096 RVA: 0x0018A70C File Offset: 0x0018890C
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
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				num ^= this.Options.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060065F1 RID: 26097 RVA: 0x0018A798 File Offset: 0x00188998
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060065F2 RID: 26098 RVA: 0x0018A7B0 File Offset: 0x001889B0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060065F3 RID: 26099 RVA: 0x0018A7BC File Offset: 0x001889BC
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
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Options);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060065F4 RID: 26100 RVA: 0x0018A854 File Offset: 0x00188A54
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
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060065F5 RID: 26101 RVA: 0x0018A8DC File Offset: 0x00188ADC
		[DebuggerNonUserCode]
		public void MergeFrom(AcceptInvitationRequest other)
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
				bool flag4 = other.options_ != null;
				if (flag4)
				{
					bool flag5 = this.options_ == null;
					if (flag5)
					{
						this.Options = new AcceptInvitationOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060065F6 RID: 26102 RVA: 0x0018A9A4 File Offset: 0x00188BA4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060065F7 RID: 26103 RVA: 0x0018A9B0 File Offset: 0x00188BB0
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
						if (num3 != 34U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.options_ == null;
							if (flag)
							{
								this.Options = new AcceptInvitationOptions();
							}
							input.ReadMessage(this.Options);
						}
					}
					else
					{
						this.InvitationId = input.ReadFixed64();
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

		// Token: 0x04002E56 RID: 11862
		private static readonly MessageParser<AcceptInvitationRequest> _parser = new MessageParser<AcceptInvitationRequest>(() => new AcceptInvitationRequest());

		// Token: 0x04002E57 RID: 11863
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E58 RID: 11864
		private int _hasBits0;

		// Token: 0x04002E59 RID: 11865
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04002E5A RID: 11866
		private EntityId agentId_;

		// Token: 0x04002E5B RID: 11867
		public const int InvitationIdFieldNumber = 3;

		// Token: 0x04002E5C RID: 11868
		private static readonly ulong InvitationIdDefaultValue = 0UL;

		// Token: 0x04002E5D RID: 11869
		private ulong invitationId_;

		// Token: 0x04002E5E RID: 11870
		public const int OptionsFieldNumber = 4;

		// Token: 0x04002E5F RID: 11871
		private AcceptInvitationOptions options_;
	}
}
