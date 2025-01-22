using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006BD RID: 1725
	public sealed class SuggestInvitationRequest : IMessage<SuggestInvitationRequest>, IMessage, IEquatable<SuggestInvitationRequest>, IDeepCloneable<SuggestInvitationRequest>, IBufferMessage
	{
		// Token: 0x1700317A RID: 12666
		// (get) Token: 0x06009F76 RID: 40822 RVA: 0x0026C818 File Offset: 0x0026AA18
		[DebuggerNonUserCode]
		public static MessageParser<SuggestInvitationRequest> Parser
		{
			get
			{
				return SuggestInvitationRequest._parser;
			}
		}

		// Token: 0x1700317B RID: 12667
		// (get) Token: 0x06009F77 RID: 40823 RVA: 0x0026C830 File Offset: 0x0026AA30
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelInvitationServiceReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x1700317C RID: 12668
		// (get) Token: 0x06009F78 RID: 40824 RVA: 0x0026C854 File Offset: 0x0026AA54
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SuggestInvitationRequest.Descriptor;
			}
		}

		// Token: 0x06009F79 RID: 40825 RVA: 0x0026C86B File Offset: 0x0026AA6B
		[DebuggerNonUserCode]
		public SuggestInvitationRequest()
		{
		}

		// Token: 0x06009F7A RID: 40826 RVA: 0x0026C878 File Offset: 0x0026AA78
		[DebuggerNonUserCode]
		public SuggestInvitationRequest(SuggestInvitationRequest other)
			: this()
		{
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.targetId_ = ((other.targetId_ != null) ? other.targetId_.Clone() : null);
			this.approvalId_ = ((other.approvalId_ != null) ? other.approvalId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009F7B RID: 40827 RVA: 0x0026C8F4 File Offset: 0x0026AAF4
		[DebuggerNonUserCode]
		public SuggestInvitationRequest Clone()
		{
			return new SuggestInvitationRequest(this);
		}

		// Token: 0x1700317D RID: 12669
		// (get) Token: 0x06009F7C RID: 40828 RVA: 0x0026C90C File Offset: 0x0026AB0C
		// (set) Token: 0x06009F7D RID: 40829 RVA: 0x0026C924 File Offset: 0x0026AB24
		[DebuggerNonUserCode]
		public EntityId ChannelId
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

		// Token: 0x1700317E RID: 12670
		// (get) Token: 0x06009F7E RID: 40830 RVA: 0x0026C930 File Offset: 0x0026AB30
		// (set) Token: 0x06009F7F RID: 40831 RVA: 0x0026C948 File Offset: 0x0026AB48
		[DebuggerNonUserCode]
		public EntityId TargetId
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

		// Token: 0x1700317F RID: 12671
		// (get) Token: 0x06009F80 RID: 40832 RVA: 0x0026C954 File Offset: 0x0026AB54
		// (set) Token: 0x06009F81 RID: 40833 RVA: 0x0026C96C File Offset: 0x0026AB6C
		[DebuggerNonUserCode]
		public EntityId ApprovalId
		{
			get
			{
				return this.approvalId_;
			}
			set
			{
				this.approvalId_ = value;
			}
		}

		// Token: 0x06009F82 RID: 40834 RVA: 0x0026C978 File Offset: 0x0026AB78
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SuggestInvitationRequest);
		}

		// Token: 0x06009F83 RID: 40835 RVA: 0x0026C998 File Offset: 0x0026AB98
		[DebuggerNonUserCode]
		public bool Equals(SuggestInvitationRequest other)
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
					bool flag4 = !object.Equals(this.ChannelId, other.ChannelId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.TargetId, other.TargetId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.ApprovalId, other.ApprovalId);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009F84 RID: 40836 RVA: 0x0026CA30 File Offset: 0x0026AC30
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.channelId_ != null;
			if (flag)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				num ^= this.TargetId.GetHashCode();
			}
			bool flag3 = this.approvalId_ != null;
			if (flag3)
			{
				num ^= this.ApprovalId.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009F85 RID: 40837 RVA: 0x0026CAB8 File Offset: 0x0026ACB8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009F86 RID: 40838 RVA: 0x0026CAD0 File Offset: 0x0026ACD0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009F87 RID: 40839 RVA: 0x0026CADC File Offset: 0x0026ACDC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.channelId_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ChannelId);
			}
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.TargetId);
			}
			bool flag3 = this.approvalId_ != null;
			if (flag3)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.ApprovalId);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009F88 RID: 40840 RVA: 0x0026CB78 File Offset: 0x0026AD78
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.channelId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
			}
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetId);
			}
			bool flag3 = this.approvalId_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ApprovalId);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009F89 RID: 40841 RVA: 0x0026CC0C File Offset: 0x0026AE0C
		[DebuggerNonUserCode]
		public void MergeFrom(SuggestInvitationRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.channelId_ != null;
				if (flag2)
				{
					bool flag3 = this.channelId_ == null;
					if (flag3)
					{
						this.ChannelId = new EntityId();
					}
					this.ChannelId.MergeFrom(other.ChannelId);
				}
				bool flag4 = other.targetId_ != null;
				if (flag4)
				{
					bool flag5 = this.targetId_ == null;
					if (flag5)
					{
						this.TargetId = new EntityId();
					}
					this.TargetId.MergeFrom(other.TargetId);
				}
				bool flag6 = other.approvalId_ != null;
				if (flag6)
				{
					bool flag7 = this.approvalId_ == null;
					if (flag7)
					{
						this.ApprovalId = new EntityId();
					}
					this.ApprovalId.MergeFrom(other.ApprovalId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009F8A RID: 40842 RVA: 0x0026CCF9 File Offset: 0x0026AEF9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009F8B RID: 40843 RVA: 0x0026CD04 File Offset: 0x0026AF04
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 18U)
				{
					if (num3 != 26U)
					{
						if (num3 != 34U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.approvalId_ == null;
							if (flag)
							{
								this.ApprovalId = new EntityId();
							}
							input.ReadMessage(this.ApprovalId);
						}
					}
					else
					{
						bool flag2 = this.targetId_ == null;
						if (flag2)
						{
							this.TargetId = new EntityId();
						}
						input.ReadMessage(this.TargetId);
					}
				}
				else
				{
					bool flag3 = this.channelId_ == null;
					if (flag3)
					{
						this.ChannelId = new EntityId();
					}
					input.ReadMessage(this.ChannelId);
				}
			}
		}

		// Token: 0x040047E2 RID: 18402
		private static readonly MessageParser<SuggestInvitationRequest> _parser = new MessageParser<SuggestInvitationRequest>(() => new SuggestInvitationRequest());

		// Token: 0x040047E3 RID: 18403
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047E4 RID: 18404
		public const int ChannelIdFieldNumber = 2;

		// Token: 0x040047E5 RID: 18405
		private EntityId channelId_;

		// Token: 0x040047E6 RID: 18406
		public const int TargetIdFieldNumber = 3;

		// Token: 0x040047E7 RID: 18407
		private EntityId targetId_;

		// Token: 0x040047E8 RID: 18408
		public const int ApprovalIdFieldNumber = 4;

		// Token: 0x040047E9 RID: 18409
		private EntityId approvalId_;
	}
}
