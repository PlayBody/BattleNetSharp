using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x0200065D RID: 1629
	public sealed class DissolveChannelRequest : IMessage<DissolveChannelRequest>, IMessage, IEquatable<DissolveChannelRequest>, IDeepCloneable<DissolveChannelRequest>, IBufferMessage
	{
		// Token: 0x17002F2A RID: 12074
		// (get) Token: 0x0600973C RID: 38716 RVA: 0x0024A490 File Offset: 0x00248690
		[DebuggerNonUserCode]
		public static MessageParser<DissolveChannelRequest> Parser
		{
			get
			{
				return DissolveChannelRequest._parser;
			}
		}

		// Token: 0x17002F2B RID: 12075
		// (get) Token: 0x0600973D RID: 38717 RVA: 0x0024A4A8 File Offset: 0x002486A8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002F2C RID: 12076
		// (get) Token: 0x0600973E RID: 38718 RVA: 0x0024A4CC File Offset: 0x002486CC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DissolveChannelRequest.Descriptor;
			}
		}

		// Token: 0x0600973F RID: 38719 RVA: 0x0024A4E3 File Offset: 0x002486E3
		[DebuggerNonUserCode]
		public DissolveChannelRequest()
		{
		}

		// Token: 0x06009740 RID: 38720 RVA: 0x0024A4F0 File Offset: 0x002486F0
		[DebuggerNonUserCode]
		public DissolveChannelRequest(DissolveChannelRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009741 RID: 38721 RVA: 0x0024A550 File Offset: 0x00248750
		[DebuggerNonUserCode]
		public DissolveChannelRequest Clone()
		{
			return new DissolveChannelRequest(this);
		}

		// Token: 0x17002F2D RID: 12077
		// (get) Token: 0x06009742 RID: 38722 RVA: 0x0024A568 File Offset: 0x00248768
		// (set) Token: 0x06009743 RID: 38723 RVA: 0x0024A580 File Offset: 0x00248780
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

		// Token: 0x17002F2E RID: 12078
		// (get) Token: 0x06009744 RID: 38724 RVA: 0x0024A58C File Offset: 0x0024878C
		// (set) Token: 0x06009745 RID: 38725 RVA: 0x0024A5A4 File Offset: 0x002487A4
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

		// Token: 0x06009746 RID: 38726 RVA: 0x0024A5B0 File Offset: 0x002487B0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DissolveChannelRequest);
		}

		// Token: 0x06009747 RID: 38727 RVA: 0x0024A5D0 File Offset: 0x002487D0
		[DebuggerNonUserCode]
		public bool Equals(DissolveChannelRequest other)
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
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009748 RID: 38728 RVA: 0x0024A648 File Offset: 0x00248848
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
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009749 RID: 38729 RVA: 0x0024A6B4 File Offset: 0x002488B4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600974A RID: 38730 RVA: 0x0024A6CC File Offset: 0x002488CC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600974B RID: 38731 RVA: 0x0024A6D8 File Offset: 0x002488D8
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
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600974C RID: 38732 RVA: 0x0024A74C File Offset: 0x0024894C
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
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600974D RID: 38733 RVA: 0x0024A7C0 File Offset: 0x002489C0
		[DebuggerNonUserCode]
		public void MergeFrom(DissolveChannelRequest other)
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
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600974E RID: 38734 RVA: 0x0024A86D File Offset: 0x00248A6D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600974F RID: 38735 RVA: 0x0024A878 File Offset: 0x00248A78
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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

		// Token: 0x04004439 RID: 17465
		private static readonly MessageParser<DissolveChannelRequest> _parser = new MessageParser<DissolveChannelRequest>(() => new DissolveChannelRequest());

		// Token: 0x0400443A RID: 17466
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400443B RID: 17467
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400443C RID: 17468
		private GameAccountHandle agentId_;

		// Token: 0x0400443D RID: 17469
		public const int ChannelIdFieldNumber = 2;

		// Token: 0x0400443E RID: 17470
		private ChannelId channelId_;
	}
}
