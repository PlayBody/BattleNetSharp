using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000673 RID: 1651
	public sealed class RevokeInvitationRequest : IMessage<RevokeInvitationRequest>, IMessage, IEquatable<RevokeInvitationRequest>, IDeepCloneable<RevokeInvitationRequest>, IBufferMessage
	{
		// Token: 0x17002FB0 RID: 12208
		// (get) Token: 0x06009938 RID: 39224 RVA: 0x00251BE0 File Offset: 0x0024FDE0
		[DebuggerNonUserCode]
		public static MessageParser<RevokeInvitationRequest> Parser
		{
			get
			{
				return RevokeInvitationRequest._parser;
			}
		}

		// Token: 0x17002FB1 RID: 12209
		// (get) Token: 0x06009939 RID: 39225 RVA: 0x00251BF8 File Offset: 0x0024FDF8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[23];
			}
		}

		// Token: 0x17002FB2 RID: 12210
		// (get) Token: 0x0600993A RID: 39226 RVA: 0x00251C1C File Offset: 0x0024FE1C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RevokeInvitationRequest.Descriptor;
			}
		}

		// Token: 0x0600993B RID: 39227 RVA: 0x00251C33 File Offset: 0x0024FE33
		[DebuggerNonUserCode]
		public RevokeInvitationRequest()
		{
		}

		// Token: 0x0600993C RID: 39228 RVA: 0x00251C40 File Offset: 0x0024FE40
		[DebuggerNonUserCode]
		public RevokeInvitationRequest(RevokeInvitationRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.invitationId_ = other.invitationId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600993D RID: 39229 RVA: 0x00251CB8 File Offset: 0x0024FEB8
		[DebuggerNonUserCode]
		public RevokeInvitationRequest Clone()
		{
			return new RevokeInvitationRequest(this);
		}

		// Token: 0x17002FB3 RID: 12211
		// (get) Token: 0x0600993E RID: 39230 RVA: 0x00251CD0 File Offset: 0x0024FED0
		// (set) Token: 0x0600993F RID: 39231 RVA: 0x00251CE8 File Offset: 0x0024FEE8
		[DebuggerNonUserCode]
		public GameAccountHandle AgentId
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

		// Token: 0x17002FB4 RID: 12212
		// (get) Token: 0x06009940 RID: 39232 RVA: 0x00251CF4 File Offset: 0x0024FEF4
		// (set) Token: 0x06009941 RID: 39233 RVA: 0x00251D0C File Offset: 0x0024FF0C
		[DebuggerNonUserCode]
		public ChannelId ChannelId
		{
			get
			{
				return this.channelId_;
			}
			set
			{
				this.channelId_ = value;
			}
		}

		// Token: 0x17002FB5 RID: 12213
		// (get) Token: 0x06009942 RID: 39234 RVA: 0x00251D18 File Offset: 0x0024FF18
		// (set) Token: 0x06009943 RID: 39235 RVA: 0x00251D49 File Offset: 0x0024FF49
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

		// Token: 0x17002FB6 RID: 12214
		// (get) Token: 0x06009944 RID: 39236 RVA: 0x00251D64 File Offset: 0x0024FF64
		[DebuggerNonUserCode]
		public bool HasInvitationId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009945 RID: 39237 RVA: 0x00251D81 File Offset: 0x0024FF81
		[DebuggerNonUserCode]
		public void ClearInvitationId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06009946 RID: 39238 RVA: 0x00251D94 File Offset: 0x0024FF94
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RevokeInvitationRequest);
		}

		// Token: 0x06009947 RID: 39239 RVA: 0x00251DB4 File Offset: 0x0024FFB4
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
						bool flag5 = !object.Equals(this.ChannelId, other.ChannelId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.InvitationId != other.InvitationId;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009948 RID: 39240 RVA: 0x00251E48 File Offset: 0x00250048
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			bool hasInvitationId = this.HasInvitationId;
			if (hasInvitationId)
			{
				num ^= this.InvitationId.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009949 RID: 39241 RVA: 0x00251ED0 File Offset: 0x002500D0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600994A RID: 39242 RVA: 0x00251EE8 File Offset: 0x002500E8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600994B RID: 39243 RVA: 0x00251EF4 File Offset: 0x002500F4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ChannelId);
			}
			bool hasInvitationId = this.HasInvitationId;
			if (hasInvitationId)
			{
				output.WriteRawTag(25);
				output.WriteFixed64(this.InvitationId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600994C RID: 39244 RVA: 0x00251F8C File Offset: 0x0025018C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
			}
			bool hasInvitationId = this.HasInvitationId;
			if (hasInvitationId)
			{
				num += 9;
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600994D RID: 39245 RVA: 0x00252014 File Offset: 0x00250214
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
						this.AgentId = new GameAccountHandle();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool flag4 = other.channelId_ != null;
				if (flag4)
				{
					bool flag5 = this.channelId_ == null;
					if (flag5)
					{
						this.ChannelId = new ChannelId();
					}
					this.ChannelId.MergeFrom(other.ChannelId);
				}
				bool hasInvitationId = other.HasInvitationId;
				if (hasInvitationId)
				{
					this.InvitationId = other.InvitationId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600994E RID: 39246 RVA: 0x002520DC File Offset: 0x002502DC
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600994F RID: 39247 RVA: 0x002520E8 File Offset: 0x002502E8
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
						bool flag = this.channelId_ == null;
						if (flag)
						{
							this.ChannelId = new ChannelId();
						}
						input.ReadMessage(this.ChannelId);
					}
				}
				else
				{
					bool flag2 = this.agentId_ == null;
					if (flag2)
					{
						this.AgentId = new GameAccountHandle();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x040044EC RID: 17644
		private static readonly MessageParser<RevokeInvitationRequest> _parser = new MessageParser<RevokeInvitationRequest>(() => new RevokeInvitationRequest());

		// Token: 0x040044ED RID: 17645
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044EE RID: 17646
		private int _hasBits0;

		// Token: 0x040044EF RID: 17647
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040044F0 RID: 17648
		private GameAccountHandle agentId_;

		// Token: 0x040044F1 RID: 17649
		public const int ChannelIdFieldNumber = 2;

		// Token: 0x040044F2 RID: 17650
		private ChannelId channelId_;

		// Token: 0x040044F3 RID: 17651
		public const int InvitationIdFieldNumber = 3;

		// Token: 0x040044F4 RID: 17652
		private static readonly ulong InvitationIdDefaultValue = 0UL;

		// Token: 0x040044F5 RID: 17653
		private ulong invitationId_;
	}
}
