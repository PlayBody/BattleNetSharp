using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Whisper.V1
{
	// Token: 0x020003A9 RID: 937
	public sealed class AdvanceViewTimeRequest : IMessage<AdvanceViewTimeRequest>, IMessage, IEquatable<AdvanceViewTimeRequest>, IDeepCloneable<AdvanceViewTimeRequest>, IBufferMessage
	{
		// Token: 0x17001E99 RID: 7833
		// (get) Token: 0x06005E84 RID: 24196 RVA: 0x0016DEE0 File Offset: 0x0016C0E0
		[DebuggerNonUserCode]
		public static MessageParser<AdvanceViewTimeRequest> Parser
		{
			get
			{
				return AdvanceViewTimeRequest._parser;
			}
		}

		// Token: 0x17001E9A RID: 7834
		// (get) Token: 0x06005E85 RID: 24197 RVA: 0x0016DEF8 File Offset: 0x0016C0F8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WhisperServiceReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17001E9B RID: 7835
		// (get) Token: 0x06005E86 RID: 24198 RVA: 0x0016DF1C File Offset: 0x0016C11C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdvanceViewTimeRequest.Descriptor;
			}
		}

		// Token: 0x06005E87 RID: 24199 RVA: 0x0016DF33 File Offset: 0x0016C133
		[DebuggerNonUserCode]
		public AdvanceViewTimeRequest()
		{
		}

		// Token: 0x06005E88 RID: 24200 RVA: 0x0016DF40 File Offset: 0x0016C140
		[DebuggerNonUserCode]
		public AdvanceViewTimeRequest(AdvanceViewTimeRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.targetId_ = ((other.targetId_ != null) ? other.targetId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005E89 RID: 24201 RVA: 0x0016DFA0 File Offset: 0x0016C1A0
		[DebuggerNonUserCode]
		public AdvanceViewTimeRequest Clone()
		{
			return new AdvanceViewTimeRequest(this);
		}

		// Token: 0x17001E9C RID: 7836
		// (get) Token: 0x06005E8A RID: 24202 RVA: 0x0016DFB8 File Offset: 0x0016C1B8
		// (set) Token: 0x06005E8B RID: 24203 RVA: 0x0016DFD0 File Offset: 0x0016C1D0
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

		// Token: 0x17001E9D RID: 7837
		// (get) Token: 0x06005E8C RID: 24204 RVA: 0x0016DFDC File Offset: 0x0016C1DC
		// (set) Token: 0x06005E8D RID: 24205 RVA: 0x0016DFF4 File Offset: 0x0016C1F4
		[DebuggerNonUserCode]
		public AccountId TargetId
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

		// Token: 0x06005E8E RID: 24206 RVA: 0x0016E000 File Offset: 0x0016C200
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdvanceViewTimeRequest);
		}

		// Token: 0x06005E8F RID: 24207 RVA: 0x0016E020 File Offset: 0x0016C220
		[DebuggerNonUserCode]
		public bool Equals(AdvanceViewTimeRequest other)
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
						bool flag5 = !object.Equals(this.TargetId, other.TargetId);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005E90 RID: 24208 RVA: 0x0016E098 File Offset: 0x0016C298
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				num ^= this.TargetId.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005E91 RID: 24209 RVA: 0x0016E104 File Offset: 0x0016C304
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005E92 RID: 24210 RVA: 0x0016E11C File Offset: 0x0016C31C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005E93 RID: 24211 RVA: 0x0016E128 File Offset: 0x0016C328
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.TargetId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005E94 RID: 24212 RVA: 0x0016E19C File Offset: 0x0016C39C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005E95 RID: 24213 RVA: 0x0016E210 File Offset: 0x0016C410
		[DebuggerNonUserCode]
		public void MergeFrom(AdvanceViewTimeRequest other)
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
				bool flag4 = other.targetId_ != null;
				if (flag4)
				{
					bool flag5 = this.targetId_ == null;
					if (flag5)
					{
						this.TargetId = new AccountId();
					}
					this.TargetId.MergeFrom(other.TargetId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005E96 RID: 24214 RVA: 0x0016E2BD File Offset: 0x0016C4BD
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005E97 RID: 24215 RVA: 0x0016E2C8 File Offset: 0x0016C4C8
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
						bool flag = this.targetId_ == null;
						if (flag)
						{
							this.TargetId = new AccountId();
						}
						input.ReadMessage(this.TargetId);
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

		// Token: 0x04002B35 RID: 11061
		private static readonly MessageParser<AdvanceViewTimeRequest> _parser = new MessageParser<AdvanceViewTimeRequest>(() => new AdvanceViewTimeRequest());

		// Token: 0x04002B36 RID: 11062
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B37 RID: 11063
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04002B38 RID: 11064
		private AccountId agentId_;

		// Token: 0x04002B39 RID: 11065
		public const int TargetIdFieldNumber = 2;

		// Token: 0x04002B3A RID: 11066
		private AccountId targetId_;
	}
}
