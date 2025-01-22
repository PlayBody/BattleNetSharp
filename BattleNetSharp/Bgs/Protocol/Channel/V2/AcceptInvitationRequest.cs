using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000671 RID: 1649
	public sealed class AcceptInvitationRequest : IMessage<AcceptInvitationRequest>, IMessage, IEquatable<AcceptInvitationRequest>, IDeepCloneable<AcceptInvitationRequest>, IBufferMessage
	{
		// Token: 0x17002FA2 RID: 12194
		// (get) Token: 0x06009906 RID: 39174 RVA: 0x00251008 File Offset: 0x0024F208
		[DebuggerNonUserCode]
		public static MessageParser<AcceptInvitationRequest> Parser
		{
			get
			{
				return AcceptInvitationRequest._parser;
			}
		}

		// Token: 0x17002FA3 RID: 12195
		// (get) Token: 0x06009907 RID: 39175 RVA: 0x00251020 File Offset: 0x0024F220
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[21];
			}
		}

		// Token: 0x17002FA4 RID: 12196
		// (get) Token: 0x06009908 RID: 39176 RVA: 0x00251044 File Offset: 0x0024F244
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AcceptInvitationRequest.Descriptor;
			}
		}

		// Token: 0x06009909 RID: 39177 RVA: 0x0025105B File Offset: 0x0024F25B
		[DebuggerNonUserCode]
		public AcceptInvitationRequest()
		{
		}

		// Token: 0x0600990A RID: 39178 RVA: 0x00251068 File Offset: 0x0024F268
		[DebuggerNonUserCode]
		public AcceptInvitationRequest(AcceptInvitationRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.invitationId_ = other.invitationId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600990B RID: 39179 RVA: 0x002510E0 File Offset: 0x0024F2E0
		[DebuggerNonUserCode]
		public AcceptInvitationRequest Clone()
		{
			return new AcceptInvitationRequest(this);
		}

		// Token: 0x17002FA5 RID: 12197
		// (get) Token: 0x0600990C RID: 39180 RVA: 0x002510F8 File Offset: 0x0024F2F8
		// (set) Token: 0x0600990D RID: 39181 RVA: 0x00251110 File Offset: 0x0024F310
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

		// Token: 0x17002FA6 RID: 12198
		// (get) Token: 0x0600990E RID: 39182 RVA: 0x0025111C File Offset: 0x0024F31C
		// (set) Token: 0x0600990F RID: 39183 RVA: 0x00251134 File Offset: 0x0024F334
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

		// Token: 0x17002FA7 RID: 12199
		// (get) Token: 0x06009910 RID: 39184 RVA: 0x00251140 File Offset: 0x0024F340
		// (set) Token: 0x06009911 RID: 39185 RVA: 0x00251171 File Offset: 0x0024F371
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

		// Token: 0x17002FA8 RID: 12200
		// (get) Token: 0x06009912 RID: 39186 RVA: 0x0025118C File Offset: 0x0024F38C
		[DebuggerNonUserCode]
		public bool HasInvitationId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009913 RID: 39187 RVA: 0x002511A9 File Offset: 0x0024F3A9
		[DebuggerNonUserCode]
		public void ClearInvitationId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06009914 RID: 39188 RVA: 0x002511BC File Offset: 0x0024F3BC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AcceptInvitationRequest);
		}

		// Token: 0x06009915 RID: 39189 RVA: 0x002511DC File Offset: 0x0024F3DC
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

		// Token: 0x06009916 RID: 39190 RVA: 0x00251270 File Offset: 0x0024F470
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

		// Token: 0x06009917 RID: 39191 RVA: 0x002512F8 File Offset: 0x0024F4F8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009918 RID: 39192 RVA: 0x00251310 File Offset: 0x0024F510
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009919 RID: 39193 RVA: 0x0025131C File Offset: 0x0024F51C
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

		// Token: 0x0600991A RID: 39194 RVA: 0x002513B4 File Offset: 0x0024F5B4
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

		// Token: 0x0600991B RID: 39195 RVA: 0x0025143C File Offset: 0x0024F63C
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

		// Token: 0x0600991C RID: 39196 RVA: 0x00251504 File Offset: 0x0024F704
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600991D RID: 39197 RVA: 0x00251510 File Offset: 0x0024F710
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

		// Token: 0x040044D8 RID: 17624
		private static readonly MessageParser<AcceptInvitationRequest> _parser = new MessageParser<AcceptInvitationRequest>(() => new AcceptInvitationRequest());

		// Token: 0x040044D9 RID: 17625
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044DA RID: 17626
		private int _hasBits0;

		// Token: 0x040044DB RID: 17627
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040044DC RID: 17628
		private GameAccountHandle agentId_;

		// Token: 0x040044DD RID: 17629
		public const int ChannelIdFieldNumber = 2;

		// Token: 0x040044DE RID: 17630
		private ChannelId channelId_;

		// Token: 0x040044DF RID: 17631
		public const int InvitationIdFieldNumber = 3;

		// Token: 0x040044E0 RID: 17632
		private static readonly ulong InvitationIdDefaultValue = 0UL;

		// Token: 0x040044E1 RID: 17633
		private ulong invitationId_;
	}
}
