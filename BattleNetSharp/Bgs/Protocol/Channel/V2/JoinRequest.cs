using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x0200066A RID: 1642
	public sealed class JoinRequest : IMessage<JoinRequest>, IMessage, IEquatable<JoinRequest>, IDeepCloneable<JoinRequest>, IBufferMessage
	{
		// Token: 0x17002F7A RID: 12154
		// (get) Token: 0x06009869 RID: 39017 RVA: 0x0024E928 File Offset: 0x0024CB28
		[DebuggerNonUserCode]
		public static MessageParser<JoinRequest> Parser
		{
			get
			{
				return JoinRequest._parser;
			}
		}

		// Token: 0x17002F7B RID: 12155
		// (get) Token: 0x0600986A RID: 39018 RVA: 0x0024E940 File Offset: 0x0024CB40
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[14];
			}
		}

		// Token: 0x17002F7C RID: 12156
		// (get) Token: 0x0600986B RID: 39019 RVA: 0x0024E964 File Offset: 0x0024CB64
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JoinRequest.Descriptor;
			}
		}

		// Token: 0x0600986C RID: 39020 RVA: 0x0024E97B File Offset: 0x0024CB7B
		[DebuggerNonUserCode]
		public JoinRequest()
		{
		}

		// Token: 0x0600986D RID: 39021 RVA: 0x0024E988 File Offset: 0x0024CB88
		[DebuggerNonUserCode]
		public JoinRequest(JoinRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.member_ = ((other.member_ != null) ? other.member_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600986E RID: 39022 RVA: 0x0024EA04 File Offset: 0x0024CC04
		[DebuggerNonUserCode]
		public JoinRequest Clone()
		{
			return new JoinRequest(this);
		}

		// Token: 0x17002F7D RID: 12157
		// (get) Token: 0x0600986F RID: 39023 RVA: 0x0024EA1C File Offset: 0x0024CC1C
		// (set) Token: 0x06009870 RID: 39024 RVA: 0x0024EA34 File Offset: 0x0024CC34
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

		// Token: 0x17002F7E RID: 12158
		// (get) Token: 0x06009871 RID: 39025 RVA: 0x0024EA40 File Offset: 0x0024CC40
		// (set) Token: 0x06009872 RID: 39026 RVA: 0x0024EA58 File Offset: 0x0024CC58
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

		// Token: 0x17002F7F RID: 12159
		// (get) Token: 0x06009873 RID: 39027 RVA: 0x0024EA64 File Offset: 0x0024CC64
		// (set) Token: 0x06009874 RID: 39028 RVA: 0x0024EA7C File Offset: 0x0024CC7C
		[DebuggerNonUserCode]
		public CreateMemberOptions Member
		{
			get
			{
				return this.member_;
			}
			set
			{
				this.member_ = value;
			}
		}

		// Token: 0x06009875 RID: 39029 RVA: 0x0024EA88 File Offset: 0x0024CC88
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as JoinRequest);
		}

		// Token: 0x06009876 RID: 39030 RVA: 0x0024EAA8 File Offset: 0x0024CCA8
		[DebuggerNonUserCode]
		public bool Equals(JoinRequest other)
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
							bool flag6 = !object.Equals(this.Member, other.Member);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009877 RID: 39031 RVA: 0x0024EB40 File Offset: 0x0024CD40
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
			bool flag3 = this.member_ != null;
			if (flag3)
			{
				num ^= this.Member.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009878 RID: 39032 RVA: 0x0024EBC8 File Offset: 0x0024CDC8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009879 RID: 39033 RVA: 0x0024EBE0 File Offset: 0x0024CDE0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600987A RID: 39034 RVA: 0x0024EBEC File Offset: 0x0024CDEC
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
			bool flag3 = this.member_ != null;
			if (flag3)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Member);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600987B RID: 39035 RVA: 0x0024EC88 File Offset: 0x0024CE88
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
			bool flag3 = this.member_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Member);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600987C RID: 39036 RVA: 0x0024ED1C File Offset: 0x0024CF1C
		[DebuggerNonUserCode]
		public void MergeFrom(JoinRequest other)
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
				bool flag6 = other.member_ != null;
				if (flag6)
				{
					bool flag7 = this.member_ == null;
					if (flag7)
					{
						this.Member = new CreateMemberOptions();
					}
					this.Member.MergeFrom(other.Member);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600987D RID: 39037 RVA: 0x0024EE09 File Offset: 0x0024D009
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600987E RID: 39038 RVA: 0x0024EE14 File Offset: 0x0024D014
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
							bool flag = this.member_ == null;
							if (flag)
							{
								this.Member = new CreateMemberOptions();
							}
							input.ReadMessage(this.Member);
						}
					}
					else
					{
						bool flag2 = this.channelId_ == null;
						if (flag2)
						{
							this.ChannelId = new ChannelId();
						}
						input.ReadMessage(this.ChannelId);
					}
				}
				else
				{
					bool flag3 = this.agentId_ == null;
					if (flag3)
					{
						this.AgentId = new GameAccountHandle();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x040044A4 RID: 17572
		private static readonly MessageParser<JoinRequest> _parser = new MessageParser<JoinRequest>(() => new JoinRequest());

		// Token: 0x040044A5 RID: 17573
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044A6 RID: 17574
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040044A7 RID: 17575
		private GameAccountHandle agentId_;

		// Token: 0x040044A8 RID: 17576
		public const int ChannelIdFieldNumber = 2;

		// Token: 0x040044A9 RID: 17577
		private ChannelId channelId_;

		// Token: 0x040044AA RID: 17578
		public const int MemberFieldNumber = 3;

		// Token: 0x040044AB RID: 17579
		private CreateMemberOptions member_;
	}
}
