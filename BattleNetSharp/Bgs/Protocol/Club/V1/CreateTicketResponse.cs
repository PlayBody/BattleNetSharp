using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004C2 RID: 1218
	public sealed class CreateTicketResponse : IMessage<CreateTicketResponse>, IMessage, IEquatable<CreateTicketResponse>, IDeepCloneable<CreateTicketResponse>, IBufferMessage
	{
		// Token: 0x170025A4 RID: 9636
		// (get) Token: 0x06007678 RID: 30328 RVA: 0x001CDCD4 File Offset: 0x001CBED4
		[DebuggerNonUserCode]
		public static MessageParser<CreateTicketResponse> Parser
		{
			get
			{
				return CreateTicketResponse._parser;
			}
		}

		// Token: 0x170025A5 RID: 9637
		// (get) Token: 0x06007679 RID: 30329 RVA: 0x001CDCEC File Offset: 0x001CBEEC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[39];
			}
		}

		// Token: 0x170025A6 RID: 9638
		// (get) Token: 0x0600767A RID: 30330 RVA: 0x001CDD10 File Offset: 0x001CBF10
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateTicketResponse.Descriptor;
			}
		}

		// Token: 0x0600767B RID: 30331 RVA: 0x001CDD27 File Offset: 0x001CBF27
		[DebuggerNonUserCode]
		public CreateTicketResponse()
		{
		}

		// Token: 0x0600767C RID: 30332 RVA: 0x001CDD31 File Offset: 0x001CBF31
		[DebuggerNonUserCode]
		public CreateTicketResponse(CreateTicketResponse other)
			: this()
		{
			this.ticket_ = ((other.ticket_ != null) ? other.ticket_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600767D RID: 30333 RVA: 0x001CDD68 File Offset: 0x001CBF68
		[DebuggerNonUserCode]
		public CreateTicketResponse Clone()
		{
			return new CreateTicketResponse(this);
		}

		// Token: 0x170025A7 RID: 9639
		// (get) Token: 0x0600767E RID: 30334 RVA: 0x001CDD80 File Offset: 0x001CBF80
		// (set) Token: 0x0600767F RID: 30335 RVA: 0x001CDD98 File Offset: 0x001CBF98
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

		// Token: 0x06007680 RID: 30336 RVA: 0x001CDDA4 File Offset: 0x001CBFA4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateTicketResponse);
		}

		// Token: 0x06007681 RID: 30337 RVA: 0x001CDDC4 File Offset: 0x001CBFC4
		[DebuggerNonUserCode]
		public bool Equals(CreateTicketResponse other)
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

		// Token: 0x06007682 RID: 30338 RVA: 0x001CDE20 File Offset: 0x001CC020
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

		// Token: 0x06007683 RID: 30339 RVA: 0x001CDE70 File Offset: 0x001CC070
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007684 RID: 30340 RVA: 0x001CDE88 File Offset: 0x001CC088
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007685 RID: 30341 RVA: 0x001CDE94 File Offset: 0x001CC094
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

		// Token: 0x06007686 RID: 30342 RVA: 0x001CDEE4 File Offset: 0x001CC0E4
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

		// Token: 0x06007687 RID: 30343 RVA: 0x001CDF38 File Offset: 0x001CC138
		[DebuggerNonUserCode]
		public void MergeFrom(CreateTicketResponse other)
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

		// Token: 0x06007688 RID: 30344 RVA: 0x001CDFA4 File Offset: 0x001CC1A4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007689 RID: 30345 RVA: 0x001CDFB0 File Offset: 0x001CC1B0
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

		// Token: 0x040035F1 RID: 13809
		private static readonly MessageParser<CreateTicketResponse> _parser = new MessageParser<CreateTicketResponse>(() => new CreateTicketResponse());

		// Token: 0x040035F2 RID: 13810
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035F3 RID: 13811
		public const int TicketFieldNumber = 1;

		// Token: 0x040035F4 RID: 13812
		private ClubTicket ticket_;
	}
}
