using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004C6 RID: 1222
	public sealed class GetTicketResponse : IMessage<GetTicketResponse>, IMessage, IEquatable<GetTicketResponse>, IDeepCloneable<GetTicketResponse>, IBufferMessage
	{
		// Token: 0x170025BC RID: 9660
		// (get) Token: 0x060076D4 RID: 30420 RVA: 0x001CEF30 File Offset: 0x001CD130
		[DebuggerNonUserCode]
		public static MessageParser<GetTicketResponse> Parser
		{
			get
			{
				return GetTicketResponse._parser;
			}
		}

		// Token: 0x170025BD RID: 9661
		// (get) Token: 0x060076D5 RID: 30421 RVA: 0x001CEF48 File Offset: 0x001CD148
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[43];
			}
		}

		// Token: 0x170025BE RID: 9662
		// (get) Token: 0x060076D6 RID: 30422 RVA: 0x001CEF6C File Offset: 0x001CD16C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetTicketResponse.Descriptor;
			}
		}

		// Token: 0x060076D7 RID: 30423 RVA: 0x001CEF83 File Offset: 0x001CD183
		[DebuggerNonUserCode]
		public GetTicketResponse()
		{
		}

		// Token: 0x060076D8 RID: 30424 RVA: 0x001CEF8D File Offset: 0x001CD18D
		[DebuggerNonUserCode]
		public GetTicketResponse(GetTicketResponse other)
			: this()
		{
			this.ticket_ = ((other.ticket_ != null) ? other.ticket_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060076D9 RID: 30425 RVA: 0x001CEFC4 File Offset: 0x001CD1C4
		[DebuggerNonUserCode]
		public GetTicketResponse Clone()
		{
			return new GetTicketResponse(this);
		}

		// Token: 0x170025BF RID: 9663
		// (get) Token: 0x060076DA RID: 30426 RVA: 0x001CEFDC File Offset: 0x001CD1DC
		// (set) Token: 0x060076DB RID: 30427 RVA: 0x001CEFF4 File Offset: 0x001CD1F4
		[DebuggerNonUserCode]
		public ClubTicket Ticket
		{
			get
			{
				return this.ticket_;
			}
			set
			{
				this.ticket_ = value;
			}
		}

		// Token: 0x060076DC RID: 30428 RVA: 0x001CF000 File Offset: 0x001CD200
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetTicketResponse);
		}

		// Token: 0x060076DD RID: 30429 RVA: 0x001CF020 File Offset: 0x001CD220
		[DebuggerNonUserCode]
		public bool Equals(GetTicketResponse other)
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
					bool flag4 = !object.Equals(this.Ticket, other.Ticket);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060076DE RID: 30430 RVA: 0x001CF07C File Offset: 0x001CD27C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.ticket_ != null;
			if (flag)
			{
				num ^= this.Ticket.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060076DF RID: 30431 RVA: 0x001CF0CC File Offset: 0x001CD2CC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060076E0 RID: 30432 RVA: 0x001CF0E4 File Offset: 0x001CD2E4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060076E1 RID: 30433 RVA: 0x001CF0F0 File Offset: 0x001CD2F0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.ticket_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Ticket);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060076E2 RID: 30434 RVA: 0x001CF140 File Offset: 0x001CD340
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.ticket_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Ticket);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060076E3 RID: 30435 RVA: 0x001CF194 File Offset: 0x001CD394
		[DebuggerNonUserCode]
		public void MergeFrom(GetTicketResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.ticket_ != null;
				if (flag2)
				{
					bool flag3 = this.ticket_ == null;
					if (flag3)
					{
						this.Ticket = new ClubTicket();
					}
					this.Ticket.MergeFrom(other.Ticket);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060076E4 RID: 30436 RVA: 0x001CF200 File Offset: 0x001CD400
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060076E5 RID: 30437 RVA: 0x001CF20C File Offset: 0x001CD40C
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
					bool flag = this.ticket_ == null;
					if (flag)
					{
						this.Ticket = new ClubTicket();
					}
					input.ReadMessage(this.Ticket);
				}
			}
		}

		// Token: 0x0400360E RID: 13838
		private static readonly MessageParser<GetTicketResponse> _parser = new MessageParser<GetTicketResponse>(() => new GetTicketResponse());

		// Token: 0x0400360F RID: 13839
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003610 RID: 13840
		public const int TicketFieldNumber = 1;

		// Token: 0x04003611 RID: 13841
		private ClubTicket ticket_;
	}
}
