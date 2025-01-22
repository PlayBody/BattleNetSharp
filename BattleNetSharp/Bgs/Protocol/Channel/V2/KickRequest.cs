using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x0200066C RID: 1644
	public sealed class KickRequest : IMessage<KickRequest>, IMessage, IEquatable<KickRequest>, IDeepCloneable<KickRequest>, IBufferMessage
	{
		// Token: 0x17002F85 RID: 12165
		// (get) Token: 0x06009895 RID: 39061 RVA: 0x0024F3BC File Offset: 0x0024D5BC
		[DebuggerNonUserCode]
		public static MessageParser<KickRequest> Parser
		{
			get
			{
				return KickRequest._parser;
			}
		}

		// Token: 0x17002F86 RID: 12166
		// (get) Token: 0x06009896 RID: 39062 RVA: 0x0024F3D4 File Offset: 0x0024D5D4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[16];
			}
		}

		// Token: 0x17002F87 RID: 12167
		// (get) Token: 0x06009897 RID: 39063 RVA: 0x0024F3F8 File Offset: 0x0024D5F8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KickRequest.Descriptor;
			}
		}

		// Token: 0x06009898 RID: 39064 RVA: 0x0024F40F File Offset: 0x0024D60F
		[DebuggerNonUserCode]
		public KickRequest()
		{
		}

		// Token: 0x06009899 RID: 39065 RVA: 0x0024F41C File Offset: 0x0024D61C
		[DebuggerNonUserCode]
		public KickRequest(KickRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.targetId_ = ((other.targetId_ != null) ? other.targetId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600989A RID: 39066 RVA: 0x0024F498 File Offset: 0x0024D698
		[DebuggerNonUserCode]
		public KickRequest Clone()
		{
			return new KickRequest(this);
		}

		// Token: 0x17002F88 RID: 12168
		// (get) Token: 0x0600989B RID: 39067 RVA: 0x0024F4B0 File Offset: 0x0024D6B0
		// (set) Token: 0x0600989C RID: 39068 RVA: 0x0024F4C8 File Offset: 0x0024D6C8
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

		// Token: 0x17002F89 RID: 12169
		// (get) Token: 0x0600989D RID: 39069 RVA: 0x0024F4D4 File Offset: 0x0024D6D4
		// (set) Token: 0x0600989E RID: 39070 RVA: 0x0024F4EC File Offset: 0x0024D6EC
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

		// Token: 0x17002F8A RID: 12170
		// (get) Token: 0x0600989F RID: 39071 RVA: 0x0024F4F8 File Offset: 0x0024D6F8
		// (set) Token: 0x060098A0 RID: 39072 RVA: 0x0024F510 File Offset: 0x0024D710
		[DebuggerNonUserCode]
		public GameAccountHandle TargetId
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

		// Token: 0x060098A1 RID: 39073 RVA: 0x0024F51C File Offset: 0x0024D71C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as KickRequest);
		}

		// Token: 0x060098A2 RID: 39074 RVA: 0x0024F53C File Offset: 0x0024D73C
		[DebuggerNonUserCode]
		public bool Equals(KickRequest other)
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
							bool flag6 = !object.Equals(this.TargetId, other.TargetId);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060098A3 RID: 39075 RVA: 0x0024F5D4 File Offset: 0x0024D7D4
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
			bool flag3 = this.targetId_ != null;
			if (flag3)
			{
				num ^= this.TargetId.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060098A4 RID: 39076 RVA: 0x0024F65C File Offset: 0x0024D85C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060098A5 RID: 39077 RVA: 0x0024F674 File Offset: 0x0024D874
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060098A6 RID: 39078 RVA: 0x0024F680 File Offset: 0x0024D880
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
			bool flag3 = this.targetId_ != null;
			if (flag3)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.TargetId);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060098A7 RID: 39079 RVA: 0x0024F71C File Offset: 0x0024D91C
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
			bool flag3 = this.targetId_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetId);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060098A8 RID: 39080 RVA: 0x0024F7B0 File Offset: 0x0024D9B0
		[DebuggerNonUserCode]
		public void MergeFrom(KickRequest other)
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
				bool flag6 = other.targetId_ != null;
				if (flag6)
				{
					bool flag7 = this.targetId_ == null;
					if (flag7)
					{
						this.TargetId = new GameAccountHandle();
					}
					this.TargetId.MergeFrom(other.TargetId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060098A9 RID: 39081 RVA: 0x0024F89D File Offset: 0x0024DA9D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060098AA RID: 39082 RVA: 0x0024F8A8 File Offset: 0x0024DAA8
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
							bool flag = this.targetId_ == null;
							if (flag)
							{
								this.TargetId = new GameAccountHandle();
							}
							input.ReadMessage(this.TargetId);
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

		// Token: 0x040044B2 RID: 17586
		private static readonly MessageParser<KickRequest> _parser = new MessageParser<KickRequest>(() => new KickRequest());

		// Token: 0x040044B3 RID: 17587
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044B4 RID: 17588
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040044B5 RID: 17589
		private GameAccountHandle agentId_;

		// Token: 0x040044B6 RID: 17590
		public const int ChannelIdFieldNumber = 2;

		// Token: 0x040044B7 RID: 17591
		private ChannelId channelId_;

		// Token: 0x040044B8 RID: 17592
		public const int TargetIdFieldNumber = 3;

		// Token: 0x040044B9 RID: 17593
		private GameAccountHandle targetId_;
	}
}
