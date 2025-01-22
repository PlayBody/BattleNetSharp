using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000660 RID: 1632
	public sealed class GetPublicChannelTypesRequest : IMessage<GetPublicChannelTypesRequest>, IMessage, IEquatable<GetPublicChannelTypesRequest>, IDeepCloneable<GetPublicChannelTypesRequest>, IBufferMessage
	{
		// Token: 0x17002F40 RID: 12096
		// (get) Token: 0x06009789 RID: 38793 RVA: 0x0024B638 File Offset: 0x00249838
		[DebuggerNonUserCode]
		public static MessageParser<GetPublicChannelTypesRequest> Parser
		{
			get
			{
				return GetPublicChannelTypesRequest._parser;
			}
		}

		// Token: 0x17002F41 RID: 12097
		// (get) Token: 0x0600978A RID: 38794 RVA: 0x0024B650 File Offset: 0x00249850
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17002F42 RID: 12098
		// (get) Token: 0x0600978B RID: 38795 RVA: 0x0024B674 File Offset: 0x00249874
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetPublicChannelTypesRequest.Descriptor;
			}
		}

		// Token: 0x0600978C RID: 38796 RVA: 0x0024B68B File Offset: 0x0024988B
		[DebuggerNonUserCode]
		public GetPublicChannelTypesRequest()
		{
		}

		// Token: 0x0600978D RID: 38797 RVA: 0x0024B698 File Offset: 0x00249898
		[DebuggerNonUserCode]
		public GetPublicChannelTypesRequest(GetPublicChannelTypesRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this.continuation_ = other.continuation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600978E RID: 38798 RVA: 0x0024B710 File Offset: 0x00249910
		[DebuggerNonUserCode]
		public GetPublicChannelTypesRequest Clone()
		{
			return new GetPublicChannelTypesRequest(this);
		}

		// Token: 0x17002F43 RID: 12099
		// (get) Token: 0x0600978F RID: 38799 RVA: 0x0024B728 File Offset: 0x00249928
		// (set) Token: 0x06009790 RID: 38800 RVA: 0x0024B740 File Offset: 0x00249940
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

		// Token: 0x17002F44 RID: 12100
		// (get) Token: 0x06009791 RID: 38801 RVA: 0x0024B74C File Offset: 0x0024994C
		// (set) Token: 0x06009792 RID: 38802 RVA: 0x0024B764 File Offset: 0x00249964
		[DebuggerNonUserCode]
		public GetPublicChannelTypesOptions Options
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

		// Token: 0x17002F45 RID: 12101
		// (get) Token: 0x06009793 RID: 38803 RVA: 0x0024B770 File Offset: 0x00249970
		// (set) Token: 0x06009794 RID: 38804 RVA: 0x0024B7A1 File Offset: 0x002499A1
		[DebuggerNonUserCode]
		public ulong Continuation
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong continuationDefaultValue;
				if (flag)
				{
					continuationDefaultValue = this.continuation_;
				}
				else
				{
					continuationDefaultValue = GetPublicChannelTypesRequest.ContinuationDefaultValue;
				}
				return continuationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.continuation_ = value;
			}
		}

		// Token: 0x17002F46 RID: 12102
		// (get) Token: 0x06009795 RID: 38805 RVA: 0x0024B7BC File Offset: 0x002499BC
		[DebuggerNonUserCode]
		public bool HasContinuation
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009796 RID: 38806 RVA: 0x0024B7D9 File Offset: 0x002499D9
		[DebuggerNonUserCode]
		public void ClearContinuation()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06009797 RID: 38807 RVA: 0x0024B7EC File Offset: 0x002499EC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetPublicChannelTypesRequest);
		}

		// Token: 0x06009798 RID: 38808 RVA: 0x0024B80C File Offset: 0x00249A0C
		[DebuggerNonUserCode]
		public bool Equals(GetPublicChannelTypesRequest other)
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
						bool flag5 = !object.Equals(this.Options, other.Options);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Continuation != other.Continuation;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009799 RID: 38809 RVA: 0x0024B8A0 File Offset: 0x00249AA0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				num ^= this.Options.GetHashCode();
			}
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				num ^= this.Continuation.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600979A RID: 38810 RVA: 0x0024B928 File Offset: 0x00249B28
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600979B RID: 38811 RVA: 0x0024B940 File Offset: 0x00249B40
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600979C RID: 38812 RVA: 0x0024B94C File Offset: 0x00249B4C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Options);
			}
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.Continuation);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600979D RID: 38813 RVA: 0x0024B9E4 File Offset: 0x00249BE4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
			}
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Continuation);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600979E RID: 38814 RVA: 0x0024BA74 File Offset: 0x00249C74
		[DebuggerNonUserCode]
		public void MergeFrom(GetPublicChannelTypesRequest other)
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
				bool flag4 = other.options_ != null;
				if (flag4)
				{
					bool flag5 = this.options_ == null;
					if (flag5)
					{
						this.Options = new GetPublicChannelTypesOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				bool hasContinuation = other.HasContinuation;
				if (hasContinuation)
				{
					this.Continuation = other.Continuation;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600979F RID: 38815 RVA: 0x0024BB3C File Offset: 0x00249D3C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060097A0 RID: 38816 RVA: 0x0024BB48 File Offset: 0x00249D48
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Continuation = input.ReadUInt64();
						}
					}
					else
					{
						bool flag = this.options_ == null;
						if (flag)
						{
							this.Options = new GetPublicChannelTypesOptions();
						}
						input.ReadMessage(this.Options);
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

		// Token: 0x04004456 RID: 17494
		private static readonly MessageParser<GetPublicChannelTypesRequest> _parser = new MessageParser<GetPublicChannelTypesRequest>(() => new GetPublicChannelTypesRequest());

		// Token: 0x04004457 RID: 17495
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004458 RID: 17496
		private int _hasBits0;

		// Token: 0x04004459 RID: 17497
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400445A RID: 17498
		private GameAccountHandle agentId_;

		// Token: 0x0400445B RID: 17499
		public const int OptionsFieldNumber = 2;

		// Token: 0x0400445C RID: 17500
		private GetPublicChannelTypesOptions options_;

		// Token: 0x0400445D RID: 17501
		public const int ContinuationFieldNumber = 3;

		// Token: 0x0400445E RID: 17502
		private static readonly ulong ContinuationDefaultValue = 0UL;

		// Token: 0x0400445F RID: 17503
		private ulong continuation_;
	}
}
