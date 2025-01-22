using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Whisper.V1
{
	// Token: 0x020003AA RID: 938
	public sealed class AdvanceClearTimeRequest : IMessage<AdvanceClearTimeRequest>, IMessage, IEquatable<AdvanceClearTimeRequest>, IDeepCloneable<AdvanceClearTimeRequest>, IBufferMessage
	{
		// Token: 0x17001E9E RID: 7838
		// (get) Token: 0x06005E99 RID: 24217 RVA: 0x0016E38C File Offset: 0x0016C58C
		[DebuggerNonUserCode]
		public static MessageParser<AdvanceClearTimeRequest> Parser
		{
			get
			{
				return AdvanceClearTimeRequest._parser;
			}
		}

		// Token: 0x17001E9F RID: 7839
		// (get) Token: 0x06005E9A RID: 24218 RVA: 0x0016E3A4 File Offset: 0x0016C5A4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WhisperServiceReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x17001EA0 RID: 7840
		// (get) Token: 0x06005E9B RID: 24219 RVA: 0x0016E3C8 File Offset: 0x0016C5C8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdvanceClearTimeRequest.Descriptor;
			}
		}

		// Token: 0x06005E9C RID: 24220 RVA: 0x0016E3DF File Offset: 0x0016C5DF
		[DebuggerNonUserCode]
		public AdvanceClearTimeRequest()
		{
		}

		// Token: 0x06005E9D RID: 24221 RVA: 0x0016E3EC File Offset: 0x0016C5EC
		[DebuggerNonUserCode]
		public AdvanceClearTimeRequest(AdvanceClearTimeRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.targetId_ = ((other.targetId_ != null) ? other.targetId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005E9E RID: 24222 RVA: 0x0016E44C File Offset: 0x0016C64C
		[DebuggerNonUserCode]
		public AdvanceClearTimeRequest Clone()
		{
			return new AdvanceClearTimeRequest(this);
		}

		// Token: 0x17001EA1 RID: 7841
		// (get) Token: 0x06005E9F RID: 24223 RVA: 0x0016E464 File Offset: 0x0016C664
		// (set) Token: 0x06005EA0 RID: 24224 RVA: 0x0016E47C File Offset: 0x0016C67C
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

		// Token: 0x17001EA2 RID: 7842
		// (get) Token: 0x06005EA1 RID: 24225 RVA: 0x0016E488 File Offset: 0x0016C688
		// (set) Token: 0x06005EA2 RID: 24226 RVA: 0x0016E4A0 File Offset: 0x0016C6A0
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

		// Token: 0x06005EA3 RID: 24227 RVA: 0x0016E4AC File Offset: 0x0016C6AC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdvanceClearTimeRequest);
		}

		// Token: 0x06005EA4 RID: 24228 RVA: 0x0016E4CC File Offset: 0x0016C6CC
		[DebuggerNonUserCode]
		public bool Equals(AdvanceClearTimeRequest other)
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

		// Token: 0x06005EA5 RID: 24229 RVA: 0x0016E544 File Offset: 0x0016C744
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

		// Token: 0x06005EA6 RID: 24230 RVA: 0x0016E5B0 File Offset: 0x0016C7B0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005EA7 RID: 24231 RVA: 0x0016E5C8 File Offset: 0x0016C7C8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005EA8 RID: 24232 RVA: 0x0016E5D4 File Offset: 0x0016C7D4
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

		// Token: 0x06005EA9 RID: 24233 RVA: 0x0016E648 File Offset: 0x0016C848
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

		// Token: 0x06005EAA RID: 24234 RVA: 0x0016E6BC File Offset: 0x0016C8BC
		[DebuggerNonUserCode]
		public void MergeFrom(AdvanceClearTimeRequest other)
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

		// Token: 0x06005EAB RID: 24235 RVA: 0x0016E769 File Offset: 0x0016C969
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005EAC RID: 24236 RVA: 0x0016E774 File Offset: 0x0016C974
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

		// Token: 0x04002B3B RID: 11067
		private static readonly MessageParser<AdvanceClearTimeRequest> _parser = new MessageParser<AdvanceClearTimeRequest>(() => new AdvanceClearTimeRequest());

		// Token: 0x04002B3C RID: 11068
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B3D RID: 11069
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04002B3E RID: 11070
		private AccountId agentId_;

		// Token: 0x04002B3F RID: 11071
		public const int TargetIdFieldNumber = 2;

		// Token: 0x04002B40 RID: 11072
		private AccountId targetId_;
	}
}
