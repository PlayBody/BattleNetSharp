using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1.Membership
{
	// Token: 0x02000522 RID: 1314
	public sealed class AdvanceStreamMentionViewTimeRequest : IMessage<AdvanceStreamMentionViewTimeRequest>, IMessage, IEquatable<AdvanceStreamMentionViewTimeRequest>, IDeepCloneable<AdvanceStreamMentionViewTimeRequest>, IBufferMessage
	{
		// Token: 0x17002872 RID: 10354
		// (get) Token: 0x06007FB2 RID: 32690 RVA: 0x001F1288 File Offset: 0x001EF488
		[DebuggerNonUserCode]
		public static MessageParser<AdvanceStreamMentionViewTimeRequest> Parser
		{
			get
			{
				return AdvanceStreamMentionViewTimeRequest._parser;
			}
		}

		// Token: 0x17002873 RID: 10355
		// (get) Token: 0x06007FB3 RID: 32691 RVA: 0x001F12A0 File Offset: 0x001EF4A0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMembershipServiceReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x17002874 RID: 10356
		// (get) Token: 0x06007FB4 RID: 32692 RVA: 0x001F12C4 File Offset: 0x001EF4C4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdvanceStreamMentionViewTimeRequest.Descriptor;
			}
		}

		// Token: 0x06007FB5 RID: 32693 RVA: 0x001F12DB File Offset: 0x001EF4DB
		[DebuggerNonUserCode]
		public AdvanceStreamMentionViewTimeRequest()
		{
		}

		// Token: 0x06007FB6 RID: 32694 RVA: 0x001F12E5 File Offset: 0x001EF4E5
		[DebuggerNonUserCode]
		public AdvanceStreamMentionViewTimeRequest(AdvanceStreamMentionViewTimeRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007FB7 RID: 32695 RVA: 0x001F131C File Offset: 0x001EF51C
		[DebuggerNonUserCode]
		public AdvanceStreamMentionViewTimeRequest Clone()
		{
			return new AdvanceStreamMentionViewTimeRequest(this);
		}

		// Token: 0x17002875 RID: 10357
		// (get) Token: 0x06007FB8 RID: 32696 RVA: 0x001F1334 File Offset: 0x001EF534
		// (set) Token: 0x06007FB9 RID: 32697 RVA: 0x001F134C File Offset: 0x001EF54C
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

		// Token: 0x06007FBA RID: 32698 RVA: 0x001F1358 File Offset: 0x001EF558
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdvanceStreamMentionViewTimeRequest);
		}

		// Token: 0x06007FBB RID: 32699 RVA: 0x001F1378 File Offset: 0x001EF578
		[DebuggerNonUserCode]
		public bool Equals(AdvanceStreamMentionViewTimeRequest other)
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

		// Token: 0x06007FBC RID: 32700 RVA: 0x001F13D4 File Offset: 0x001EF5D4
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

		// Token: 0x06007FBD RID: 32701 RVA: 0x001F1424 File Offset: 0x001EF624
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007FBE RID: 32702 RVA: 0x001F143C File Offset: 0x001EF63C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007FBF RID: 32703 RVA: 0x001F1448 File Offset: 0x001EF648
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

		// Token: 0x06007FC0 RID: 32704 RVA: 0x001F1498 File Offset: 0x001EF698
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

		// Token: 0x06007FC1 RID: 32705 RVA: 0x001F14EC File Offset: 0x001EF6EC
		[DebuggerNonUserCode]
		public void MergeFrom(AdvanceStreamMentionViewTimeRequest other)
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

		// Token: 0x06007FC2 RID: 32706 RVA: 0x001F1558 File Offset: 0x001EF758
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007FC3 RID: 32707 RVA: 0x001F1564 File Offset: 0x001EF764
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

		// Token: 0x040039F4 RID: 14836
		private static readonly MessageParser<AdvanceStreamMentionViewTimeRequest> _parser = new MessageParser<AdvanceStreamMentionViewTimeRequest>(() => new AdvanceStreamMentionViewTimeRequest());

		// Token: 0x040039F5 RID: 14837
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039F6 RID: 14838
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040039F7 RID: 14839
		private AccountId agentId_;
	}
}
