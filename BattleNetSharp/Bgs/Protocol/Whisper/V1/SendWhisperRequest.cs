using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Whisper.V1
{
	// Token: 0x020003A6 RID: 934
	public sealed class SendWhisperRequest : IMessage<SendWhisperRequest>, IMessage, IEquatable<SendWhisperRequest>, IDeepCloneable<SendWhisperRequest>, IBufferMessage
	{
		// Token: 0x17001E89 RID: 7817
		// (get) Token: 0x06005E43 RID: 24131 RVA: 0x0016D0D4 File Offset: 0x0016B2D4
		[DebuggerNonUserCode]
		public static MessageParser<SendWhisperRequest> Parser
		{
			get
			{
				return SendWhisperRequest._parser;
			}
		}

		// Token: 0x17001E8A RID: 7818
		// (get) Token: 0x06005E44 RID: 24132 RVA: 0x0016D0EC File Offset: 0x0016B2EC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WhisperServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17001E8B RID: 7819
		// (get) Token: 0x06005E45 RID: 24133 RVA: 0x0016D110 File Offset: 0x0016B310
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SendWhisperRequest.Descriptor;
			}
		}

		// Token: 0x06005E46 RID: 24134 RVA: 0x0016D127 File Offset: 0x0016B327
		[DebuggerNonUserCode]
		public SendWhisperRequest()
		{
		}

		// Token: 0x06005E47 RID: 24135 RVA: 0x0016D134 File Offset: 0x0016B334
		[DebuggerNonUserCode]
		public SendWhisperRequest(SendWhisperRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.whisper_ = ((other.whisper_ != null) ? other.whisper_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005E48 RID: 24136 RVA: 0x0016D194 File Offset: 0x0016B394
		[DebuggerNonUserCode]
		public SendWhisperRequest Clone()
		{
			return new SendWhisperRequest(this);
		}

		// Token: 0x17001E8C RID: 7820
		// (get) Token: 0x06005E49 RID: 24137 RVA: 0x0016D1AC File Offset: 0x0016B3AC
		// (set) Token: 0x06005E4A RID: 24138 RVA: 0x0016D1C4 File Offset: 0x0016B3C4
		[DebuggerNonUserCode]
		public AccountId AgentId
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

		// Token: 0x17001E8D RID: 7821
		// (get) Token: 0x06005E4B RID: 24139 RVA: 0x0016D1D0 File Offset: 0x0016B3D0
		// (set) Token: 0x06005E4C RID: 24140 RVA: 0x0016D1E8 File Offset: 0x0016B3E8
		[DebuggerNonUserCode]
		public SendOptions Whisper
		{
			get
			{
				return this.whisper_;
			}
			set
			{
				this.whisper_ = value;
			}
		}

		// Token: 0x06005E4D RID: 24141 RVA: 0x0016D1F4 File Offset: 0x0016B3F4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SendWhisperRequest);
		}

		// Token: 0x06005E4E RID: 24142 RVA: 0x0016D214 File Offset: 0x0016B414
		[DebuggerNonUserCode]
		public bool Equals(SendWhisperRequest other)
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
						bool flag5 = !object.Equals(this.Whisper, other.Whisper);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005E4F RID: 24143 RVA: 0x0016D28C File Offset: 0x0016B48C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.whisper_ != null;
			if (flag2)
			{
				num ^= this.Whisper.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005E50 RID: 24144 RVA: 0x0016D2F8 File Offset: 0x0016B4F8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005E51 RID: 24145 RVA: 0x0016D310 File Offset: 0x0016B510
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005E52 RID: 24146 RVA: 0x0016D31C File Offset: 0x0016B51C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.whisper_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Whisper);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005E53 RID: 24147 RVA: 0x0016D390 File Offset: 0x0016B590
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.whisper_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Whisper);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005E54 RID: 24148 RVA: 0x0016D404 File Offset: 0x0016B604
		[DebuggerNonUserCode]
		public void MergeFrom(SendWhisperRequest other)
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
						this.AgentId = new AccountId();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool flag4 = other.whisper_ != null;
				if (flag4)
				{
					bool flag5 = this.whisper_ == null;
					if (flag5)
					{
						this.Whisper = new SendOptions();
					}
					this.Whisper.MergeFrom(other.Whisper);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005E55 RID: 24149 RVA: 0x0016D4B1 File Offset: 0x0016B6B1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005E56 RID: 24150 RVA: 0x0016D4BC File Offset: 0x0016B6BC
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
						bool flag = this.whisper_ == null;
						if (flag)
						{
							this.Whisper = new SendOptions();
						}
						input.ReadMessage(this.Whisper);
					}
				}
				else
				{
					bool flag2 = this.agentId_ == null;
					if (flag2)
					{
						this.AgentId = new AccountId();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x04002B21 RID: 11041
		private static readonly MessageParser<SendWhisperRequest> _parser = new MessageParser<SendWhisperRequest>(() => new SendWhisperRequest());

		// Token: 0x04002B22 RID: 11042
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B23 RID: 11043
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04002B24 RID: 11044
		private AccountId agentId_;

		// Token: 0x04002B25 RID: 11045
		public const int WhisperFieldNumber = 2;

		// Token: 0x04002B26 RID: 11046
		private SendOptions whisper_;
	}
}
