using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004C5 RID: 1221
	public sealed class GetTicketRequest : IMessage<GetTicketRequest>, IMessage, IEquatable<GetTicketRequest>, IDeepCloneable<GetTicketRequest>, IBufferMessage
	{
		// Token: 0x170025B6 RID: 9654
		// (get) Token: 0x060076BD RID: 30397 RVA: 0x001CEAA4 File Offset: 0x001CCCA4
		[DebuggerNonUserCode]
		public static MessageParser<GetTicketRequest> Parser
		{
			get
			{
				return GetTicketRequest._parser;
			}
		}

		// Token: 0x170025B7 RID: 9655
		// (get) Token: 0x060076BE RID: 30398 RVA: 0x001CEABC File Offset: 0x001CCCBC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[42];
			}
		}

		// Token: 0x170025B8 RID: 9656
		// (get) Token: 0x060076BF RID: 30399 RVA: 0x001CEAE0 File Offset: 0x001CCCE0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetTicketRequest.Descriptor;
			}
		}

		// Token: 0x060076C0 RID: 30400 RVA: 0x001CEAF7 File Offset: 0x001CCCF7
		[DebuggerNonUserCode]
		public GetTicketRequest()
		{
		}

		// Token: 0x060076C1 RID: 30401 RVA: 0x001CEB04 File Offset: 0x001CCD04
		[DebuggerNonUserCode]
		public GetTicketRequest(GetTicketRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.ticketId_ = other.ticketId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060076C2 RID: 30402 RVA: 0x001CEB54 File Offset: 0x001CCD54
		[DebuggerNonUserCode]
		public GetTicketRequest Clone()
		{
			return new GetTicketRequest(this);
		}

		// Token: 0x170025B9 RID: 9657
		// (get) Token: 0x060076C3 RID: 30403 RVA: 0x001CEB6C File Offset: 0x001CCD6C
		// (set) Token: 0x060076C4 RID: 30404 RVA: 0x001CEB84 File Offset: 0x001CCD84
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

		// Token: 0x170025BA RID: 9658
		// (get) Token: 0x060076C5 RID: 30405 RVA: 0x001CEB90 File Offset: 0x001CCD90
		// (set) Token: 0x060076C6 RID: 30406 RVA: 0x001CEBB1 File Offset: 0x001CCDB1
		[DebuggerNonUserCode]
		public string TicketId
		{
			get
			{
				return this.ticketId_ ?? GetTicketRequest.TicketIdDefaultValue;
			}
			set
			{
				this.ticketId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170025BB RID: 9659
		// (get) Token: 0x060076C7 RID: 30407 RVA: 0x001CEBC8 File Offset: 0x001CCDC8
		[DebuggerNonUserCode]
		public bool HasTicketId
		{
			get
			{
				return this.ticketId_ != null;
			}
		}

		// Token: 0x060076C8 RID: 30408 RVA: 0x001CEBE3 File Offset: 0x001CCDE3
		[DebuggerNonUserCode]
		public void ClearTicketId()
		{
			this.ticketId_ = null;
		}

		// Token: 0x060076C9 RID: 30409 RVA: 0x001CEBF0 File Offset: 0x001CCDF0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetTicketRequest);
		}

		// Token: 0x060076CA RID: 30410 RVA: 0x001CEC10 File Offset: 0x001CCE10
		[DebuggerNonUserCode]
		public bool Equals(GetTicketRequest other)
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

		// Token: 0x060076CB RID: 30411 RVA: 0x001CEC84 File Offset: 0x001CCE84
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

		// Token: 0x060076CC RID: 30412 RVA: 0x001CECEC File Offset: 0x001CCEEC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060076CD RID: 30413 RVA: 0x001CED04 File Offset: 0x001CCF04
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060076CE RID: 30414 RVA: 0x001CED10 File Offset: 0x001CCF10
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

		// Token: 0x060076CF RID: 30415 RVA: 0x001CED84 File Offset: 0x001CCF84
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

		// Token: 0x060076D0 RID: 30416 RVA: 0x001CEDF4 File Offset: 0x001CCFF4
		[DebuggerNonUserCode]
		public void MergeFrom(GetTicketRequest other)
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

		// Token: 0x060076D1 RID: 30417 RVA: 0x001CEE79 File Offset: 0x001CD079
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060076D2 RID: 30418 RVA: 0x001CEE84 File Offset: 0x001CD084
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

		// Token: 0x04003607 RID: 13831
		private static readonly MessageParser<GetTicketRequest> _parser = new MessageParser<GetTicketRequest>(() => new GetTicketRequest());

		// Token: 0x04003608 RID: 13832
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003609 RID: 13833
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400360A RID: 13834
		private MemberId agentId_;

		// Token: 0x0400360B RID: 13835
		public const int TicketIdFieldNumber = 3;

		// Token: 0x0400360C RID: 13836
		private static readonly string TicketIdDefaultValue = "";

		// Token: 0x0400360D RID: 13837
		private string ticketId_;
	}
}
