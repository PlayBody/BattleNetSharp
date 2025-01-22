using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000281 RID: 641
	public sealed class PartyInviteConfirmationRequired : IMessage<PartyInviteConfirmationRequired>, IMessage, IEquatable<PartyInviteConfirmationRequired>, IDeepCloneable<PartyInviteConfirmationRequired>, IBufferMessage
	{
		// Token: 0x170015C6 RID: 5574
		// (get) Token: 0x0600445F RID: 17503 RVA: 0x00107C04 File Offset: 0x00105E04
		[DebuggerNonUserCode]
		public static MessageParser<PartyInviteConfirmationRequired> Parser
		{
			get
			{
				return PartyInviteConfirmationRequired._parser;
			}
		}

		// Token: 0x170015C7 RID: 5575
		// (get) Token: 0x06004460 RID: 17504 RVA: 0x00107C1C File Offset: 0x00105E1C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[113];
			}
		}

		// Token: 0x170015C8 RID: 5576
		// (get) Token: 0x06004461 RID: 17505 RVA: 0x00107C40 File Offset: 0x00105E40
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartyInviteConfirmationRequired.Descriptor;
			}
		}

		// Token: 0x06004462 RID: 17506 RVA: 0x00107C57 File Offset: 0x00105E57
		[DebuggerNonUserCode]
		public PartyInviteConfirmationRequired()
		{
		}

		// Token: 0x06004463 RID: 17507 RVA: 0x00107C6C File Offset: 0x00105E6C
		[DebuggerNonUserCode]
		public PartyInviteConfirmationRequired(PartyInviteConfirmationRequired other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.partyId_ = other.partyId_;
			this.inviteId_ = other.inviteId_;
			this.reservationId_ = other.reservationId_.Clone();
			this.confirmationType_ = other.confirmationType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004464 RID: 17508 RVA: 0x00107CD4 File Offset: 0x00105ED4
		[DebuggerNonUserCode]
		public PartyInviteConfirmationRequired Clone()
		{
			return new PartyInviteConfirmationRequired(this);
		}

		// Token: 0x170015C9 RID: 5577
		// (get) Token: 0x06004465 RID: 17509 RVA: 0x00107CEC File Offset: 0x00105EEC
		// (set) Token: 0x06004466 RID: 17510 RVA: 0x00107D0D File Offset: 0x00105F0D
		[DebuggerNonUserCode]
		public string PartyId
		{
			get
			{
				return this.partyId_ ?? PartyInviteConfirmationRequired.PartyIdDefaultValue;
			}
			set
			{
				this.partyId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170015CA RID: 5578
		// (get) Token: 0x06004467 RID: 17511 RVA: 0x00107D24 File Offset: 0x00105F24
		[DebuggerNonUserCode]
		public bool HasPartyId
		{
			get
			{
				return this.partyId_ != null;
			}
		}

		// Token: 0x06004468 RID: 17512 RVA: 0x00107D3F File Offset: 0x00105F3F
		[DebuggerNonUserCode]
		public void ClearPartyId()
		{
			this.partyId_ = null;
		}

		// Token: 0x170015CB RID: 5579
		// (get) Token: 0x06004469 RID: 17513 RVA: 0x00107D4C File Offset: 0x00105F4C
		// (set) Token: 0x0600446A RID: 17514 RVA: 0x00107D7D File Offset: 0x00105F7D
		[DebuggerNonUserCode]
		public ulong InviteId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong inviteIdDefaultValue;
				if (flag)
				{
					inviteIdDefaultValue = this.inviteId_;
				}
				else
				{
					inviteIdDefaultValue = PartyInviteConfirmationRequired.InviteIdDefaultValue;
				}
				return inviteIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.inviteId_ = value;
			}
		}

		// Token: 0x170015CC RID: 5580
		// (get) Token: 0x0600446B RID: 17515 RVA: 0x00107D98 File Offset: 0x00105F98
		[DebuggerNonUserCode]
		public bool HasInviteId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600446C RID: 17516 RVA: 0x00107DB5 File Offset: 0x00105FB5
		[DebuggerNonUserCode]
		public void ClearInviteId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170015CD RID: 5581
		// (get) Token: 0x0600446D RID: 17517 RVA: 0x00107DC8 File Offset: 0x00105FC8
		[DebuggerNonUserCode]
		public RepeatedField<ulong> ReservationId
		{
			get
			{
				return this.reservationId_;
			}
		}

		// Token: 0x170015CE RID: 5582
		// (get) Token: 0x0600446E RID: 17518 RVA: 0x00107DE0 File Offset: 0x00105FE0
		// (set) Token: 0x0600446F RID: 17519 RVA: 0x00107E11 File Offset: 0x00106011
		[DebuggerNonUserCode]
		public uint ConfirmationType
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint confirmationTypeDefaultValue;
				if (flag)
				{
					confirmationTypeDefaultValue = this.confirmationType_;
				}
				else
				{
					confirmationTypeDefaultValue = PartyInviteConfirmationRequired.ConfirmationTypeDefaultValue;
				}
				return confirmationTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.confirmationType_ = value;
			}
		}

		// Token: 0x170015CF RID: 5583
		// (get) Token: 0x06004470 RID: 17520 RVA: 0x00107E2C File Offset: 0x0010602C
		[DebuggerNonUserCode]
		public bool HasConfirmationType
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004471 RID: 17521 RVA: 0x00107E49 File Offset: 0x00106049
		[DebuggerNonUserCode]
		public void ClearConfirmationType()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06004472 RID: 17522 RVA: 0x00107E5C File Offset: 0x0010605C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartyInviteConfirmationRequired);
		}

		// Token: 0x06004473 RID: 17523 RVA: 0x00107E7C File Offset: 0x0010607C
		[DebuggerNonUserCode]
		public bool Equals(PartyInviteConfirmationRequired other)
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
						bool flag5 = this.InviteId != other.InviteId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.reservationId_.Equals(other.reservationId_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.ConfirmationType != other.ConfirmationType;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004474 RID: 17524 RVA: 0x00107F2C File Offset: 0x0010612C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				num ^= this.PartyId.GetHashCode();
			}
			bool hasInviteId = this.HasInviteId;
			if (hasInviteId)
			{
				num ^= this.InviteId.GetHashCode();
			}
			num ^= this.reservationId_.GetHashCode();
			bool hasConfirmationType = this.HasConfirmationType;
			if (hasConfirmationType)
			{
				num ^= this.ConfirmationType.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004475 RID: 17525 RVA: 0x00107FC4 File Offset: 0x001061C4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004476 RID: 17526 RVA: 0x00107FDC File Offset: 0x001061DC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004477 RID: 17527 RVA: 0x00107FE8 File Offset: 0x001061E8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.PartyId);
			}
			bool hasInviteId = this.HasInviteId;
			if (hasInviteId)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.InviteId);
			}
			this.reservationId_.WriteTo(ref output, PartyInviteConfirmationRequired._repeated_reservationId_codec);
			bool hasConfirmationType = this.HasConfirmationType;
			if (hasConfirmationType)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.ConfirmationType);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004478 RID: 17528 RVA: 0x0010808C File Offset: 0x0010628C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PartyId);
			}
			bool hasInviteId = this.HasInviteId;
			if (hasInviteId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.InviteId);
			}
			num += this.reservationId_.CalculateSize(PartyInviteConfirmationRequired._repeated_reservationId_codec);
			bool hasConfirmationType = this.HasConfirmationType;
			if (hasConfirmationType)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ConfirmationType);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004479 RID: 17529 RVA: 0x0010812C File Offset: 0x0010632C
		[DebuggerNonUserCode]
		public void MergeFrom(PartyInviteConfirmationRequired other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPartyId = other.HasPartyId;
				if (hasPartyId)
				{
					this.PartyId = other.PartyId;
				}
				bool hasInviteId = other.HasInviteId;
				if (hasInviteId)
				{
					this.InviteId = other.InviteId;
				}
				this.reservationId_.Add(other.reservationId_);
				bool hasConfirmationType = other.HasConfirmationType;
				if (hasConfirmationType)
				{
					this.ConfirmationType = other.ConfirmationType;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600447A RID: 17530 RVA: 0x001081B9 File Offset: 0x001063B9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600447B RID: 17531 RVA: 0x001081C4 File Offset: 0x001063C4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 16U)
				{
					if (num3 != 10U)
					{
						if (num3 != 16U)
						{
							goto IL_0033;
						}
						this.InviteId = input.ReadUInt64();
					}
					else
					{
						this.PartyId = input.ReadString();
					}
				}
				else if (num3 != 24U && num3 != 26U)
				{
					if (num3 != 32U)
					{
						goto IL_0033;
					}
					this.ConfirmationType = input.ReadUInt32();
				}
				else
				{
					this.reservationId_.AddEntriesFrom(ref input, PartyInviteConfirmationRequired._repeated_reservationId_codec);
				}
				continue;
				IL_0033:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001EAF RID: 7855
		private static readonly MessageParser<PartyInviteConfirmationRequired> _parser = new MessageParser<PartyInviteConfirmationRequired>(() => new PartyInviteConfirmationRequired());

		// Token: 0x04001EB0 RID: 7856
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EB1 RID: 7857
		private int _hasBits0;

		// Token: 0x04001EB2 RID: 7858
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04001EB3 RID: 7859
		private static readonly string PartyIdDefaultValue = "";

		// Token: 0x04001EB4 RID: 7860
		private string partyId_;

		// Token: 0x04001EB5 RID: 7861
		public const int InviteIdFieldNumber = 2;

		// Token: 0x04001EB6 RID: 7862
		private static readonly ulong InviteIdDefaultValue = 0UL;

		// Token: 0x04001EB7 RID: 7863
		private ulong inviteId_;

		// Token: 0x04001EB8 RID: 7864
		public const int ReservationIdFieldNumber = 3;

		// Token: 0x04001EB9 RID: 7865
		private static readonly FieldCodec<ulong> _repeated_reservationId_codec = FieldCodec.ForUInt64(24U);

		// Token: 0x04001EBA RID: 7866
		private readonly RepeatedField<ulong> reservationId_ = new RepeatedField<ulong>();

		// Token: 0x04001EBB RID: 7867
		public const int ConfirmationTypeFieldNumber = 4;

		// Token: 0x04001EBC RID: 7868
		private static readonly uint ConfirmationTypeDefaultValue = 0U;

		// Token: 0x04001EBD RID: 7869
		private uint confirmationType_;
	}
}
