using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000668 RID: 1640
	public sealed class SendMessageRequest : IMessage<SendMessageRequest>, IMessage, IEquatable<SendMessageRequest>, IDeepCloneable<SendMessageRequest>, IBufferMessage
	{
		// Token: 0x17002F6D RID: 12141
		// (get) Token: 0x06009839 RID: 38969 RVA: 0x0024DD48 File Offset: 0x0024BF48
		[DebuggerNonUserCode]
		public static MessageParser<SendMessageRequest> Parser
		{
			get
			{
				return SendMessageRequest._parser;
			}
		}

		// Token: 0x17002F6E RID: 12142
		// (get) Token: 0x0600983A RID: 38970 RVA: 0x0024DD60 File Offset: 0x0024BF60
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[12];
			}
		}

		// Token: 0x17002F6F RID: 12143
		// (get) Token: 0x0600983B RID: 38971 RVA: 0x0024DD84 File Offset: 0x0024BF84
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SendMessageRequest.Descriptor;
			}
		}

		// Token: 0x0600983C RID: 38972 RVA: 0x0024DD9B File Offset: 0x0024BF9B
		[DebuggerNonUserCode]
		public SendMessageRequest()
		{
		}

		// Token: 0x0600983D RID: 38973 RVA: 0x0024DDA8 File Offset: 0x0024BFA8
		[DebuggerNonUserCode]
		public SendMessageRequest(SendMessageRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600983E RID: 38974 RVA: 0x0024DE24 File Offset: 0x0024C024
		[DebuggerNonUserCode]
		public SendMessageRequest Clone()
		{
			return new SendMessageRequest(this);
		}

		// Token: 0x17002F70 RID: 12144
		// (get) Token: 0x0600983F RID: 38975 RVA: 0x0024DE3C File Offset: 0x0024C03C
		// (set) Token: 0x06009840 RID: 38976 RVA: 0x0024DE54 File Offset: 0x0024C054
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

		// Token: 0x17002F71 RID: 12145
		// (get) Token: 0x06009841 RID: 38977 RVA: 0x0024DE60 File Offset: 0x0024C060
		// (set) Token: 0x06009842 RID: 38978 RVA: 0x0024DE78 File Offset: 0x0024C078
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

		// Token: 0x17002F72 RID: 12146
		// (get) Token: 0x06009843 RID: 38979 RVA: 0x0024DE84 File Offset: 0x0024C084
		// (set) Token: 0x06009844 RID: 38980 RVA: 0x0024DE9C File Offset: 0x0024C09C
		[DebuggerNonUserCode]
		public SendMessageOptions Options
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

		// Token: 0x06009845 RID: 38981 RVA: 0x0024DEA8 File Offset: 0x0024C0A8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SendMessageRequest);
		}

		// Token: 0x06009846 RID: 38982 RVA: 0x0024DEC8 File Offset: 0x0024C0C8
		[DebuggerNonUserCode]
		public bool Equals(SendMessageRequest other)
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
							bool flag6 = !object.Equals(this.Options, other.Options);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009847 RID: 38983 RVA: 0x0024DF60 File Offset: 0x0024C160
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
			bool flag3 = this.options_ != null;
			if (flag3)
			{
				num ^= this.Options.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009848 RID: 38984 RVA: 0x0024DFE8 File Offset: 0x0024C1E8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009849 RID: 38985 RVA: 0x0024E000 File Offset: 0x0024C200
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600984A RID: 38986 RVA: 0x0024E00C File Offset: 0x0024C20C
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
			bool flag3 = this.options_ != null;
			if (flag3)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Options);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600984B RID: 38987 RVA: 0x0024E0A8 File Offset: 0x0024C2A8
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
			bool flag3 = this.options_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600984C RID: 38988 RVA: 0x0024E13C File Offset: 0x0024C33C
		[DebuggerNonUserCode]
		public void MergeFrom(SendMessageRequest other)
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
				bool flag6 = other.options_ != null;
				if (flag6)
				{
					bool flag7 = this.options_ == null;
					if (flag7)
					{
						this.Options = new SendMessageOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600984D RID: 38989 RVA: 0x0024E229 File Offset: 0x0024C429
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600984E RID: 38990 RVA: 0x0024E234 File Offset: 0x0024C434
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
							bool flag = this.options_ == null;
							if (flag)
							{
								this.Options = new SendMessageOptions();
							}
							input.ReadMessage(this.Options);
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

		// Token: 0x04004492 RID: 17554
		private static readonly MessageParser<SendMessageRequest> _parser = new MessageParser<SendMessageRequest>(() => new SendMessageRequest());

		// Token: 0x04004493 RID: 17555
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004494 RID: 17556
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04004495 RID: 17557
		private GameAccountHandle agentId_;

		// Token: 0x04004496 RID: 17558
		public const int ChannelIdFieldNumber = 2;

		// Token: 0x04004497 RID: 17559
		private ChannelId channelId_;

		// Token: 0x04004498 RID: 17560
		public const int OptionsFieldNumber = 3;

		// Token: 0x04004499 RID: 17561
		private SendMessageOptions options_;
	}
}
