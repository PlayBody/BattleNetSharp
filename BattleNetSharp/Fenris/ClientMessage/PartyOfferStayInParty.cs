using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000260 RID: 608
	public sealed class PartyOfferStayInParty : IMessage<PartyOfferStayInParty>, IMessage, IEquatable<PartyOfferStayInParty>, IDeepCloneable<PartyOfferStayInParty>, IBufferMessage
	{
		// Token: 0x170014F4 RID: 5364
		// (get) Token: 0x06004157 RID: 16727 RVA: 0x000FECD8 File Offset: 0x000FCED8
		[DebuggerNonUserCode]
		public static MessageParser<PartyOfferStayInParty> Parser
		{
			get
			{
				return PartyOfferStayInParty._parser;
			}
		}

		// Token: 0x170014F5 RID: 5365
		// (get) Token: 0x06004158 RID: 16728 RVA: 0x000FECF0 File Offset: 0x000FCEF0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[80];
			}
		}

		// Token: 0x170014F6 RID: 5366
		// (get) Token: 0x06004159 RID: 16729 RVA: 0x000FED14 File Offset: 0x000FCF14
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartyOfferStayInParty.Descriptor;
			}
		}

		// Token: 0x0600415A RID: 16730 RVA: 0x000FED2B File Offset: 0x000FCF2B
		[DebuggerNonUserCode]
		public PartyOfferStayInParty()
		{
		}

		// Token: 0x0600415B RID: 16731 RVA: 0x000FED35 File Offset: 0x000FCF35
		[DebuggerNonUserCode]
		public PartyOfferStayInParty(PartyOfferStayInParty other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.partyId_ = other.partyId_;
			this.memberCount_ = other.memberCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600415C RID: 16732 RVA: 0x000FED74 File Offset: 0x000FCF74
		[DebuggerNonUserCode]
		public PartyOfferStayInParty Clone()
		{
			return new PartyOfferStayInParty(this);
		}

		// Token: 0x170014F7 RID: 5367
		// (get) Token: 0x0600415D RID: 16733 RVA: 0x000FED8C File Offset: 0x000FCF8C
		// (set) Token: 0x0600415E RID: 16734 RVA: 0x000FEDAD File Offset: 0x000FCFAD
		[DebuggerNonUserCode]
		public string PartyId
		{
			get
			{
				return this.partyId_ ?? PartyOfferStayInParty.PartyIdDefaultValue;
			}
			set
			{
				this.partyId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170014F8 RID: 5368
		// (get) Token: 0x0600415F RID: 16735 RVA: 0x000FEDC4 File Offset: 0x000FCFC4
		[DebuggerNonUserCode]
		public bool HasPartyId
		{
			get
			{
				return this.partyId_ != null;
			}
		}

		// Token: 0x06004160 RID: 16736 RVA: 0x000FEDDF File Offset: 0x000FCFDF
		[DebuggerNonUserCode]
		public void ClearPartyId()
		{
			this.partyId_ = null;
		}

		// Token: 0x170014F9 RID: 5369
		// (get) Token: 0x06004161 RID: 16737 RVA: 0x000FEDEC File Offset: 0x000FCFEC
		// (set) Token: 0x06004162 RID: 16738 RVA: 0x000FEE1D File Offset: 0x000FD01D
		[DebuggerNonUserCode]
		public uint MemberCount
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint memberCountDefaultValue;
				if (flag)
				{
					memberCountDefaultValue = this.memberCount_;
				}
				else
				{
					memberCountDefaultValue = PartyOfferStayInParty.MemberCountDefaultValue;
				}
				return memberCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.memberCount_ = value;
			}
		}

		// Token: 0x170014FA RID: 5370
		// (get) Token: 0x06004163 RID: 16739 RVA: 0x000FEE38 File Offset: 0x000FD038
		[DebuggerNonUserCode]
		public bool HasMemberCount
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004164 RID: 16740 RVA: 0x000FEE55 File Offset: 0x000FD055
		[DebuggerNonUserCode]
		public void ClearMemberCount()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06004165 RID: 16741 RVA: 0x000FEE68 File Offset: 0x000FD068
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartyOfferStayInParty);
		}

		// Token: 0x06004166 RID: 16742 RVA: 0x000FEE88 File Offset: 0x000FD088
		[DebuggerNonUserCode]
		public bool Equals(PartyOfferStayInParty other)
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
					bool flag4 = this.PartyId != other.PartyId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.MemberCount != other.MemberCount;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004167 RID: 16743 RVA: 0x000FEEFC File Offset: 0x000FD0FC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				num ^= this.PartyId.GetHashCode();
			}
			bool hasMemberCount = this.HasMemberCount;
			if (hasMemberCount)
			{
				num ^= this.MemberCount.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004168 RID: 16744 RVA: 0x000FEF68 File Offset: 0x000FD168
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004169 RID: 16745 RVA: 0x000FEF80 File Offset: 0x000FD180
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600416A RID: 16746 RVA: 0x000FEF8C File Offset: 0x000FD18C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.PartyId);
			}
			bool hasMemberCount = this.HasMemberCount;
			if (hasMemberCount)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.MemberCount);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600416B RID: 16747 RVA: 0x000FEFFC File Offset: 0x000FD1FC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PartyId);
			}
			bool hasMemberCount = this.HasMemberCount;
			if (hasMemberCount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MemberCount);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600416C RID: 16748 RVA: 0x000FF068 File Offset: 0x000FD268
		[DebuggerNonUserCode]
		public void MergeFrom(PartyOfferStayInParty other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPartyId = other.HasPartyId;
				if (hasPartyId)
				{
					this.PartyId = other.PartyId;
				}
				bool hasMemberCount = other.HasMemberCount;
				if (hasMemberCount)
				{
					this.MemberCount = other.MemberCount;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600416D RID: 16749 RVA: 0x000FF0CA File Offset: 0x000FD2CA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600416E RID: 16750 RVA: 0x000FF0D8 File Offset: 0x000FD2D8
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
						this.MemberCount = input.ReadUInt32();
					}
				}
				else
				{
					this.PartyId = input.ReadString();
				}
			}
		}

		// Token: 0x04001DA9 RID: 7593
		private static readonly MessageParser<PartyOfferStayInParty> _parser = new MessageParser<PartyOfferStayInParty>(() => new PartyOfferStayInParty());

		// Token: 0x04001DAA RID: 7594
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DAB RID: 7595
		private int _hasBits0;

		// Token: 0x04001DAC RID: 7596
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04001DAD RID: 7597
		private static readonly string PartyIdDefaultValue = "";

		// Token: 0x04001DAE RID: 7598
		private string partyId_;

		// Token: 0x04001DAF RID: 7599
		public const int MemberCountFieldNumber = 2;

		// Token: 0x04001DB0 RID: 7600
		private static readonly uint MemberCountDefaultValue = 0U;

		// Token: 0x04001DB1 RID: 7601
		private uint memberCount_;
	}
}
