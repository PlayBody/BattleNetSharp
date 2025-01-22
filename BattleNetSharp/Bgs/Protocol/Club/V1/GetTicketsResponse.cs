using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004C8 RID: 1224
	public sealed class GetTicketsResponse : IMessage<GetTicketsResponse>, IMessage, IEquatable<GetTicketsResponse>, IDeepCloneable<GetTicketsResponse>, IBufferMessage
	{
		// Token: 0x170025C8 RID: 9672
		// (get) Token: 0x06007702 RID: 30466 RVA: 0x001CF890 File Offset: 0x001CDA90
		[DebuggerNonUserCode]
		public static MessageParser<GetTicketsResponse> Parser
		{
			get
			{
				return GetTicketsResponse._parser;
			}
		}

		// Token: 0x170025C9 RID: 9673
		// (get) Token: 0x06007703 RID: 30467 RVA: 0x001CF8A8 File Offset: 0x001CDAA8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[45];
			}
		}

		// Token: 0x170025CA RID: 9674
		// (get) Token: 0x06007704 RID: 30468 RVA: 0x001CF8CC File Offset: 0x001CDACC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetTicketsResponse.Descriptor;
			}
		}

		// Token: 0x06007705 RID: 30469 RVA: 0x001CF8E3 File Offset: 0x001CDAE3
		[DebuggerNonUserCode]
		public GetTicketsResponse()
		{
		}

		// Token: 0x06007706 RID: 30470 RVA: 0x001CF8F8 File Offset: 0x001CDAF8
		[DebuggerNonUserCode]
		public GetTicketsResponse(GetTicketsResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.ticket_ = other.ticket_.Clone();
			this.continuation_ = other.continuation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007707 RID: 30471 RVA: 0x001CF948 File Offset: 0x001CDB48
		[DebuggerNonUserCode]
		public GetTicketsResponse Clone()
		{
			return new GetTicketsResponse(this);
		}

		// Token: 0x170025CB RID: 9675
		// (get) Token: 0x06007708 RID: 30472 RVA: 0x001CF960 File Offset: 0x001CDB60
		[DebuggerNonUserCode]
		public RepeatedField<ClubTicket> Ticket
		{
			get
			{
				return this.ticket_;
			}
		}

		// Token: 0x170025CC RID: 9676
		// (get) Token: 0x06007709 RID: 30473 RVA: 0x001CF978 File Offset: 0x001CDB78
		// (set) Token: 0x0600770A RID: 30474 RVA: 0x001CF9A9 File Offset: 0x001CDBA9
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
					continuationDefaultValue = GetTicketsResponse.ContinuationDefaultValue;
				}
				return continuationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.continuation_ = value;
			}
		}

		// Token: 0x170025CD RID: 9677
		// (get) Token: 0x0600770B RID: 30475 RVA: 0x001CF9C4 File Offset: 0x001CDBC4
		[DebuggerNonUserCode]
		public bool HasContinuation
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600770C RID: 30476 RVA: 0x001CF9E1 File Offset: 0x001CDBE1
		[DebuggerNonUserCode]
		public void ClearContinuation()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600770D RID: 30477 RVA: 0x001CF9F4 File Offset: 0x001CDBF4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetTicketsResponse);
		}

		// Token: 0x0600770E RID: 30478 RVA: 0x001CFA14 File Offset: 0x001CDC14
		[DebuggerNonUserCode]
		public bool Equals(GetTicketsResponse other)
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
					bool flag4 = !this.ticket_.Equals(other.ticket_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Continuation != other.Continuation;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600770F RID: 30479 RVA: 0x001CFA88 File Offset: 0x001CDC88
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ticket_.GetHashCode();
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				num ^= this.Continuation.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007710 RID: 30480 RVA: 0x001CFAE8 File Offset: 0x001CDCE8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007711 RID: 30481 RVA: 0x001CFB00 File Offset: 0x001CDD00
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007712 RID: 30482 RVA: 0x001CFB0C File Offset: 0x001CDD0C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ticket_.WriteTo(ref output, GetTicketsResponse._repeated_ticket_codec);
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.Continuation);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007713 RID: 30483 RVA: 0x001CFB6C File Offset: 0x001CDD6C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ticket_.CalculateSize(GetTicketsResponse._repeated_ticket_codec);
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Continuation);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007714 RID: 30484 RVA: 0x001CFBD0 File Offset: 0x001CDDD0
		[DebuggerNonUserCode]
		public void MergeFrom(GetTicketsResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.ticket_.Add(other.ticket_);
				bool hasContinuation = other.HasContinuation;
				if (hasContinuation)
				{
					this.Continuation = other.Continuation;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007715 RID: 30485 RVA: 0x001CFC2B File Offset: 0x001CDE2B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007716 RID: 30486 RVA: 0x001CFC38 File Offset: 0x001CDE38
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
					if (num3 != 16U)
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
					this.ticket_.AddEntriesFrom(ref input, GetTicketsResponse._repeated_ticket_codec);
				}
			}
		}

		// Token: 0x0400361D RID: 13853
		private static readonly MessageParser<GetTicketsResponse> _parser = new MessageParser<GetTicketsResponse>(() => new GetTicketsResponse());

		// Token: 0x0400361E RID: 13854
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400361F RID: 13855
		private int _hasBits0;

		// Token: 0x04003620 RID: 13856
		public const int TicketFieldNumber = 1;

		// Token: 0x04003621 RID: 13857
		private static readonly FieldCodec<ClubTicket> _repeated_ticket_codec = FieldCodec.ForMessage<ClubTicket>(10U, ClubTicket.Parser);

		// Token: 0x04003622 RID: 13858
		private readonly RepeatedField<ClubTicket> ticket_ = new RepeatedField<ClubTicket>();

		// Token: 0x04003623 RID: 13859
		public const int ContinuationFieldNumber = 2;

		// Token: 0x04003624 RID: 13860
		private static readonly ulong ContinuationDefaultValue = 0UL;

		// Token: 0x04003625 RID: 13861
		private ulong continuation_;
	}
}
