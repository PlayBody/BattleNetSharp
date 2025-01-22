using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x0200066B RID: 1643
	public sealed class LeaveRequest : IMessage<LeaveRequest>, IMessage, IEquatable<LeaveRequest>, IDeepCloneable<LeaveRequest>, IBufferMessage
	{
		// Token: 0x17002F80 RID: 12160
		// (get) Token: 0x06009880 RID: 39040 RVA: 0x0024EF10 File Offset: 0x0024D110
		[DebuggerNonUserCode]
		public static MessageParser<LeaveRequest> Parser
		{
			get
			{
				return LeaveRequest._parser;
			}
		}

		// Token: 0x17002F81 RID: 12161
		// (get) Token: 0x06009881 RID: 39041 RVA: 0x0024EF28 File Offset: 0x0024D128
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[15];
			}
		}

		// Token: 0x17002F82 RID: 12162
		// (get) Token: 0x06009882 RID: 39042 RVA: 0x0024EF4C File Offset: 0x0024D14C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveRequest.Descriptor;
			}
		}

		// Token: 0x06009883 RID: 39043 RVA: 0x0024EF63 File Offset: 0x0024D163
		[DebuggerNonUserCode]
		public LeaveRequest()
		{
		}

		// Token: 0x06009884 RID: 39044 RVA: 0x0024EF70 File Offset: 0x0024D170
		[DebuggerNonUserCode]
		public LeaveRequest(LeaveRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009885 RID: 39045 RVA: 0x0024EFD0 File Offset: 0x0024D1D0
		[DebuggerNonUserCode]
		public LeaveRequest Clone()
		{
			return new LeaveRequest(this);
		}

		// Token: 0x17002F83 RID: 12163
		// (get) Token: 0x06009886 RID: 39046 RVA: 0x0024EFE8 File Offset: 0x0024D1E8
		// (set) Token: 0x06009887 RID: 39047 RVA: 0x0024F000 File Offset: 0x0024D200
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

		// Token: 0x17002F84 RID: 12164
		// (get) Token: 0x06009888 RID: 39048 RVA: 0x0024F00C File Offset: 0x0024D20C
		// (set) Token: 0x06009889 RID: 39049 RVA: 0x0024F024 File Offset: 0x0024D224
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

		// Token: 0x0600988A RID: 39050 RVA: 0x0024F030 File Offset: 0x0024D230
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveRequest);
		}

		// Token: 0x0600988B RID: 39051 RVA: 0x0024F050 File Offset: 0x0024D250
		[DebuggerNonUserCode]
		public bool Equals(LeaveRequest other)
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

		// Token: 0x0600988C RID: 39052 RVA: 0x0024F0C8 File Offset: 0x0024D2C8
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

		// Token: 0x0600988D RID: 39053 RVA: 0x0024F134 File Offset: 0x0024D334
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600988E RID: 39054 RVA: 0x0024F14C File Offset: 0x0024D34C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600988F RID: 39055 RVA: 0x0024F158 File Offset: 0x0024D358
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

		// Token: 0x06009890 RID: 39056 RVA: 0x0024F1CC File Offset: 0x0024D3CC
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

		// Token: 0x06009891 RID: 39057 RVA: 0x0024F240 File Offset: 0x0024D440
		[DebuggerNonUserCode]
		public void MergeFrom(LeaveRequest other)
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

		// Token: 0x06009892 RID: 39058 RVA: 0x0024F2ED File Offset: 0x0024D4ED
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009893 RID: 39059 RVA: 0x0024F2F8 File Offset: 0x0024D4F8
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

		// Token: 0x040044AC RID: 17580
		private static readonly MessageParser<LeaveRequest> _parser = new MessageParser<LeaveRequest>(() => new LeaveRequest());

		// Token: 0x040044AD RID: 17581
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044AE RID: 17582
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040044AF RID: 17583
		private GameAccountHandle agentId_;

		// Token: 0x040044B0 RID: 17584
		public const int ChannelIdFieldNumber = 2;

		// Token: 0x040044B1 RID: 17585
		private ChannelId channelId_;
	}
}
