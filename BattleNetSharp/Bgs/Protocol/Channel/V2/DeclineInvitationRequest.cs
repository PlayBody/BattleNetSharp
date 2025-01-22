using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000672 RID: 1650
	public sealed class DeclineInvitationRequest : IMessage<DeclineInvitationRequest>, IMessage, IEquatable<DeclineInvitationRequest>, IDeepCloneable<DeclineInvitationRequest>, IBufferMessage
	{
		// Token: 0x17002FA9 RID: 12201
		// (get) Token: 0x0600991F RID: 39199 RVA: 0x002515F4 File Offset: 0x0024F7F4
		[DebuggerNonUserCode]
		public static MessageParser<DeclineInvitationRequest> Parser
		{
			get
			{
				return DeclineInvitationRequest._parser;
			}
		}

		// Token: 0x17002FAA RID: 12202
		// (get) Token: 0x06009920 RID: 39200 RVA: 0x0025160C File Offset: 0x0024F80C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[22];
			}
		}

		// Token: 0x17002FAB RID: 12203
		// (get) Token: 0x06009921 RID: 39201 RVA: 0x00251630 File Offset: 0x0024F830
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeclineInvitationRequest.Descriptor;
			}
		}

		// Token: 0x06009922 RID: 39202 RVA: 0x00251647 File Offset: 0x0024F847
		[DebuggerNonUserCode]
		public DeclineInvitationRequest()
		{
		}

		// Token: 0x06009923 RID: 39203 RVA: 0x00251654 File Offset: 0x0024F854
		[DebuggerNonUserCode]
		public DeclineInvitationRequest(DeclineInvitationRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.invitationId_ = other.invitationId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009924 RID: 39204 RVA: 0x002516CC File Offset: 0x0024F8CC
		[DebuggerNonUserCode]
		public DeclineInvitationRequest Clone()
		{
			return new DeclineInvitationRequest(this);
		}

		// Token: 0x17002FAC RID: 12204
		// (get) Token: 0x06009925 RID: 39205 RVA: 0x002516E4 File Offset: 0x0024F8E4
		// (set) Token: 0x06009926 RID: 39206 RVA: 0x002516FC File Offset: 0x0024F8FC
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

		// Token: 0x17002FAD RID: 12205
		// (get) Token: 0x06009927 RID: 39207 RVA: 0x00251708 File Offset: 0x0024F908
		// (set) Token: 0x06009928 RID: 39208 RVA: 0x00251720 File Offset: 0x0024F920
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

		// Token: 0x17002FAE RID: 12206
		// (get) Token: 0x06009929 RID: 39209 RVA: 0x0025172C File Offset: 0x0024F92C
		// (set) Token: 0x0600992A RID: 39210 RVA: 0x0025175D File Offset: 0x0024F95D
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

		// Token: 0x17002FAF RID: 12207
		// (get) Token: 0x0600992B RID: 39211 RVA: 0x00251778 File Offset: 0x0024F978
		[DebuggerNonUserCode]
		public bool HasInvitationId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600992C RID: 39212 RVA: 0x00251795 File Offset: 0x0024F995
		[DebuggerNonUserCode]
		public void ClearInvitationId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600992D RID: 39213 RVA: 0x002517A8 File Offset: 0x0024F9A8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeclineInvitationRequest);
		}

		// Token: 0x0600992E RID: 39214 RVA: 0x002517C8 File Offset: 0x0024F9C8
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

		// Token: 0x0600992F RID: 39215 RVA: 0x0025185C File Offset: 0x0024FA5C
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

		// Token: 0x06009930 RID: 39216 RVA: 0x002518E4 File Offset: 0x0024FAE4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009931 RID: 39217 RVA: 0x002518FC File Offset: 0x0024FAFC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009932 RID: 39218 RVA: 0x00251908 File Offset: 0x0024FB08
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

		// Token: 0x06009933 RID: 39219 RVA: 0x002519A0 File Offset: 0x0024FBA0
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

		// Token: 0x06009934 RID: 39220 RVA: 0x00251A28 File Offset: 0x0024FC28
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

		// Token: 0x06009935 RID: 39221 RVA: 0x00251AF0 File Offset: 0x0024FCF0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009936 RID: 39222 RVA: 0x00251AFC File Offset: 0x0024FCFC
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

		// Token: 0x040044E2 RID: 17634
		private static readonly MessageParser<DeclineInvitationRequest> _parser = new MessageParser<DeclineInvitationRequest>(() => new DeclineInvitationRequest());

		// Token: 0x040044E3 RID: 17635
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044E4 RID: 17636
		private int _hasBits0;

		// Token: 0x040044E5 RID: 17637
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040044E6 RID: 17638
		private GameAccountHandle agentId_;

		// Token: 0x040044E7 RID: 17639
		public const int ChannelIdFieldNumber = 2;

		// Token: 0x040044E8 RID: 17640
		private ChannelId channelId_;

		// Token: 0x040044E9 RID: 17641
		public const int InvitationIdFieldNumber = 3;

		// Token: 0x040044EA RID: 17642
		private static readonly ulong InvitationIdDefaultValue = 0UL;

		// Token: 0x040044EB RID: 17643
		private ulong invitationId_;
	}
}
