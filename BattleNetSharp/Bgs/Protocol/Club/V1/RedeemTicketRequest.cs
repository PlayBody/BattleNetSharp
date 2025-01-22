using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004C4 RID: 1220
	public sealed class RedeemTicketRequest : IMessage<RedeemTicketRequest>, IMessage, IEquatable<RedeemTicketRequest>, IDeepCloneable<RedeemTicketRequest>, IBufferMessage
	{
		// Token: 0x170025B0 RID: 9648
		// (get) Token: 0x060076A6 RID: 30374 RVA: 0x001CE618 File Offset: 0x001CC818
		[DebuggerNonUserCode]
		public static MessageParser<RedeemTicketRequest> Parser
		{
			get
			{
				return RedeemTicketRequest._parser;
			}
		}

		// Token: 0x170025B1 RID: 9649
		// (get) Token: 0x060076A7 RID: 30375 RVA: 0x001CE630 File Offset: 0x001CC830
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[41];
			}
		}

		// Token: 0x170025B2 RID: 9650
		// (get) Token: 0x060076A8 RID: 30376 RVA: 0x001CE654 File Offset: 0x001CC854
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RedeemTicketRequest.Descriptor;
			}
		}

		// Token: 0x060076A9 RID: 30377 RVA: 0x001CE66B File Offset: 0x001CC86B
		[DebuggerNonUserCode]
		public RedeemTicketRequest()
		{
		}

		// Token: 0x060076AA RID: 30378 RVA: 0x001CE678 File Offset: 0x001CC878
		[DebuggerNonUserCode]
		public RedeemTicketRequest(RedeemTicketRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.ticketId_ = other.ticketId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060076AB RID: 30379 RVA: 0x001CE6C8 File Offset: 0x001CC8C8
		[DebuggerNonUserCode]
		public RedeemTicketRequest Clone()
		{
			return new RedeemTicketRequest(this);
		}

		// Token: 0x170025B3 RID: 9651
		// (get) Token: 0x060076AC RID: 30380 RVA: 0x001CE6E0 File Offset: 0x001CC8E0
		// (set) Token: 0x060076AD RID: 30381 RVA: 0x001CE6F8 File Offset: 0x001CC8F8
		[DebuggerNonUserCode]
		public MemberId AgentId
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

		// Token: 0x170025B4 RID: 9652
		// (get) Token: 0x060076AE RID: 30382 RVA: 0x001CE704 File Offset: 0x001CC904
		// (set) Token: 0x060076AF RID: 30383 RVA: 0x001CE725 File Offset: 0x001CC925
		[DebuggerNonUserCode]
		public string TicketId
		{
			get
			{
				return this.ticketId_ ?? RedeemTicketRequest.TicketIdDefaultValue;
			}
			set
			{
				this.ticketId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170025B5 RID: 9653
		// (get) Token: 0x060076B0 RID: 30384 RVA: 0x001CE73C File Offset: 0x001CC93C
		[DebuggerNonUserCode]
		public bool HasTicketId
		{
			get
			{
				return this.ticketId_ != null;
			}
		}

		// Token: 0x060076B1 RID: 30385 RVA: 0x001CE757 File Offset: 0x001CC957
		[DebuggerNonUserCode]
		public void ClearTicketId()
		{
			this.ticketId_ = null;
		}

		// Token: 0x060076B2 RID: 30386 RVA: 0x001CE764 File Offset: 0x001CC964
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RedeemTicketRequest);
		}

		// Token: 0x060076B3 RID: 30387 RVA: 0x001CE784 File Offset: 0x001CC984
		[DebuggerNonUserCode]
		public bool Equals(RedeemTicketRequest other)
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
						bool flag5 = this.TicketId != other.TicketId;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060076B4 RID: 30388 RVA: 0x001CE7F8 File Offset: 0x001CC9F8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool hasTicketId = this.HasTicketId;
			if (hasTicketId)
			{
				num ^= this.TicketId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060076B5 RID: 30389 RVA: 0x001CE860 File Offset: 0x001CCA60
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060076B6 RID: 30390 RVA: 0x001CE878 File Offset: 0x001CCA78
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060076B7 RID: 30391 RVA: 0x001CE884 File Offset: 0x001CCA84
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool hasTicketId = this.HasTicketId;
			if (hasTicketId)
			{
				output.WriteRawTag(26);
				output.WriteString(this.TicketId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060076B8 RID: 30392 RVA: 0x001CE8F8 File Offset: 0x001CCAF8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool hasTicketId = this.HasTicketId;
			if (hasTicketId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TicketId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060076B9 RID: 30393 RVA: 0x001CE968 File Offset: 0x001CCB68
		[DebuggerNonUserCode]
		public void MergeFrom(RedeemTicketRequest other)
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
						this.AgentId = new MemberId();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool hasTicketId = other.HasTicketId;
				if (hasTicketId)
				{
					this.TicketId = other.TicketId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060076BA RID: 30394 RVA: 0x001CE9ED File Offset: 0x001CCBED
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060076BB RID: 30395 RVA: 0x001CE9F8 File Offset: 0x001CCBF8
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
					if (num3 != 26U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TicketId = input.ReadString();
					}
				}
				else
				{
					bool flag = this.agentId_ == null;
					if (flag)
					{
						this.AgentId = new MemberId();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x04003600 RID: 13824
		private static readonly MessageParser<RedeemTicketRequest> _parser = new MessageParser<RedeemTicketRequest>(() => new RedeemTicketRequest());

		// Token: 0x04003601 RID: 13825
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003602 RID: 13826
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003603 RID: 13827
		private MemberId agentId_;

		// Token: 0x04003604 RID: 13828
		public const int TicketIdFieldNumber = 3;

		// Token: 0x04003605 RID: 13829
		private static readonly string TicketIdDefaultValue = "";

		// Token: 0x04003606 RID: 13830
		private string ticketId_;
	}
}
