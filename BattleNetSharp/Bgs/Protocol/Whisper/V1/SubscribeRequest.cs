using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Whisper.V1
{
	// Token: 0x020003A3 RID: 931
	public sealed class SubscribeRequest : IMessage<SubscribeRequest>, IMessage, IEquatable<SubscribeRequest>, IDeepCloneable<SubscribeRequest>, IBufferMessage
	{
		// Token: 0x17001E7D RID: 7805
		// (get) Token: 0x06005E0B RID: 24075 RVA: 0x0016C708 File Offset: 0x0016A908
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeRequest> Parser
		{
			get
			{
				return SubscribeRequest._parser;
			}
		}

		// Token: 0x17001E7E RID: 7806
		// (get) Token: 0x06005E0C RID: 24076 RVA: 0x0016C720 File Offset: 0x0016A920
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WhisperServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001E7F RID: 7807
		// (get) Token: 0x06005E0D RID: 24077 RVA: 0x0016C744 File Offset: 0x0016A944
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeRequest.Descriptor;
			}
		}

		// Token: 0x06005E0E RID: 24078 RVA: 0x0016C75B File Offset: 0x0016A95B
		[DebuggerNonUserCode]
		public SubscribeRequest()
		{
		}

		// Token: 0x06005E0F RID: 24079 RVA: 0x0016C765 File Offset: 0x0016A965
		[DebuggerNonUserCode]
		public SubscribeRequest(SubscribeRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005E10 RID: 24080 RVA: 0x0016C79C File Offset: 0x0016A99C
		[DebuggerNonUserCode]
		public SubscribeRequest Clone()
		{
			return new SubscribeRequest(this);
		}

		// Token: 0x17001E80 RID: 7808
		// (get) Token: 0x06005E11 RID: 24081 RVA: 0x0016C7B4 File Offset: 0x0016A9B4
		// (set) Token: 0x06005E12 RID: 24082 RVA: 0x0016C7CC File Offset: 0x0016A9CC
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

		// Token: 0x06005E13 RID: 24083 RVA: 0x0016C7D8 File Offset: 0x0016A9D8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeRequest);
		}

		// Token: 0x06005E14 RID: 24084 RVA: 0x0016C7F8 File Offset: 0x0016A9F8
		[DebuggerNonUserCode]
		public bool Equals(SubscribeRequest other)
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
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06005E15 RID: 24085 RVA: 0x0016C854 File Offset: 0x0016AA54
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005E16 RID: 24086 RVA: 0x0016C8A4 File Offset: 0x0016AAA4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005E17 RID: 24087 RVA: 0x0016C8BC File Offset: 0x0016AABC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005E18 RID: 24088 RVA: 0x0016C8C8 File Offset: 0x0016AAC8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005E19 RID: 24089 RVA: 0x0016C918 File Offset: 0x0016AB18
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005E1A RID: 24090 RVA: 0x0016C96C File Offset: 0x0016AB6C
		[DebuggerNonUserCode]
		public void MergeFrom(SubscribeRequest other)
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
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005E1B RID: 24091 RVA: 0x0016C9D8 File Offset: 0x0016ABD8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005E1C RID: 24092 RVA: 0x0016C9E4 File Offset: 0x0016ABE4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					bool flag = this.agentId_ == null;
					if (flag)
					{
						this.AgentId = new AccountId();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x04002B14 RID: 11028
		private static readonly MessageParser<SubscribeRequest> _parser = new MessageParser<SubscribeRequest>(() => new SubscribeRequest());

		// Token: 0x04002B15 RID: 11029
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B16 RID: 11030
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04002B17 RID: 11031
		private AccountId agentId_;
	}
}
