using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000282 RID: 642
	public sealed class ConfirmPartyJoin : IMessage<ConfirmPartyJoin>, IMessage, IEquatable<ConfirmPartyJoin>, IDeepCloneable<ConfirmPartyJoin>, IBufferMessage
	{
		// Token: 0x170015D0 RID: 5584
		// (get) Token: 0x0600447D RID: 17533 RVA: 0x001082B0 File Offset: 0x001064B0
		[DebuggerNonUserCode]
		public static MessageParser<ConfirmPartyJoin> Parser
		{
			get
			{
				return ConfirmPartyJoin._parser;
			}
		}

		// Token: 0x170015D1 RID: 5585
		// (get) Token: 0x0600447E RID: 17534 RVA: 0x001082C8 File Offset: 0x001064C8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[114];
			}
		}

		// Token: 0x170015D2 RID: 5586
		// (get) Token: 0x0600447F RID: 17535 RVA: 0x001082EC File Offset: 0x001064EC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConfirmPartyJoin.Descriptor;
			}
		}

		// Token: 0x06004480 RID: 17536 RVA: 0x00108303 File Offset: 0x00106503
		[DebuggerNonUserCode]
		public ConfirmPartyJoin()
		{
		}

		// Token: 0x06004481 RID: 17537 RVA: 0x00108318 File Offset: 0x00106518
		[DebuggerNonUserCode]
		public ConfirmPartyJoin(ConfirmPartyJoin other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.inviterPartyId_ = other.inviterPartyId_;
			this.inviteId_ = other.inviteId_;
			this.reservationTokens_ = other.reservationTokens_.Clone();
			this.confirmed_ = other.confirmed_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004482 RID: 17538 RVA: 0x00108380 File Offset: 0x00106580
		[DebuggerNonUserCode]
		public ConfirmPartyJoin Clone()
		{
			return new ConfirmPartyJoin(this);
		}

		// Token: 0x170015D3 RID: 5587
		// (get) Token: 0x06004483 RID: 17539 RVA: 0x00108398 File Offset: 0x00106598
		// (set) Token: 0x06004484 RID: 17540 RVA: 0x001083B9 File Offset: 0x001065B9
		[DebuggerNonUserCode]
		public string InviterPartyId
		{
			get
			{
				return this.inviterPartyId_ ?? ConfirmPartyJoin.InviterPartyIdDefaultValue;
			}
			set
			{
				this.inviterPartyId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170015D4 RID: 5588
		// (get) Token: 0x06004485 RID: 17541 RVA: 0x001083D0 File Offset: 0x001065D0
		[DebuggerNonUserCode]
		public bool HasInviterPartyId
		{
			get
			{
				return this.inviterPartyId_ != null;
			}
		}

		// Token: 0x06004486 RID: 17542 RVA: 0x001083EB File Offset: 0x001065EB
		[DebuggerNonUserCode]
		public void ClearInviterPartyId()
		{
			this.inviterPartyId_ = null;
		}

		// Token: 0x170015D5 RID: 5589
		// (get) Token: 0x06004487 RID: 17543 RVA: 0x001083F8 File Offset: 0x001065F8
		// (set) Token: 0x06004488 RID: 17544 RVA: 0x00108429 File Offset: 0x00106629
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
					inviteIdDefaultValue = ConfirmPartyJoin.InviteIdDefaultValue;
				}
				return inviteIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.inviteId_ = value;
			}
		}

		// Token: 0x170015D6 RID: 5590
		// (get) Token: 0x06004489 RID: 17545 RVA: 0x00108444 File Offset: 0x00106644
		[DebuggerNonUserCode]
		public bool HasInviteId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600448A RID: 17546 RVA: 0x00108461 File Offset: 0x00106661
		[DebuggerNonUserCode]
		public void ClearInviteId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170015D7 RID: 5591
		// (get) Token: 0x0600448B RID: 17547 RVA: 0x00108474 File Offset: 0x00106674
		[DebuggerNonUserCode]
		public RepeatedField<ulong> ReservationTokens
		{
			get
			{
				return this.reservationTokens_;
			}
		}

		// Token: 0x170015D8 RID: 5592
		// (get) Token: 0x0600448C RID: 17548 RVA: 0x0010848C File Offset: 0x0010668C
		// (set) Token: 0x0600448D RID: 17549 RVA: 0x001084BD File Offset: 0x001066BD
		[DebuggerNonUserCode]
		public bool Confirmed
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool confirmedDefaultValue;
				if (flag)
				{
					confirmedDefaultValue = this.confirmed_;
				}
				else
				{
					confirmedDefaultValue = ConfirmPartyJoin.ConfirmedDefaultValue;
				}
				return confirmedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.confirmed_ = value;
			}
		}

		// Token: 0x170015D9 RID: 5593
		// (get) Token: 0x0600448E RID: 17550 RVA: 0x001084D8 File Offset: 0x001066D8
		[DebuggerNonUserCode]
		public bool HasConfirmed
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600448F RID: 17551 RVA: 0x001084F5 File Offset: 0x001066F5
		[DebuggerNonUserCode]
		public void ClearConfirmed()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06004490 RID: 17552 RVA: 0x00108508 File Offset: 0x00106708
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConfirmPartyJoin);
		}

		// Token: 0x06004491 RID: 17553 RVA: 0x00108528 File Offset: 0x00106728
		[DebuggerNonUserCode]
		public bool Equals(ConfirmPartyJoin other)
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
					bool flag4 = this.InviterPartyId != other.InviterPartyId;
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
							bool flag6 = !this.reservationTokens_.Equals(other.reservationTokens_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Confirmed != other.Confirmed;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004492 RID: 17554 RVA: 0x001085D8 File Offset: 0x001067D8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasInviterPartyId = this.HasInviterPartyId;
			if (hasInviterPartyId)
			{
				num ^= this.InviterPartyId.GetHashCode();
			}
			bool hasInviteId = this.HasInviteId;
			if (hasInviteId)
			{
				num ^= this.InviteId.GetHashCode();
			}
			num ^= this.reservationTokens_.GetHashCode();
			bool hasConfirmed = this.HasConfirmed;
			if (hasConfirmed)
			{
				num ^= this.Confirmed.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004493 RID: 17555 RVA: 0x00108670 File Offset: 0x00106870
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004494 RID: 17556 RVA: 0x00108688 File Offset: 0x00106888
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004495 RID: 17557 RVA: 0x00108694 File Offset: 0x00106894
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasInviterPartyId = this.HasInviterPartyId;
			if (hasInviterPartyId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.InviterPartyId);
			}
			bool hasInviteId = this.HasInviteId;
			if (hasInviteId)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.InviteId);
			}
			this.reservationTokens_.WriteTo(ref output, ConfirmPartyJoin._repeated_reservationTokens_codec);
			bool hasConfirmed = this.HasConfirmed;
			if (hasConfirmed)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.Confirmed);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004496 RID: 17558 RVA: 0x00108738 File Offset: 0x00106938
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasInviterPartyId = this.HasInviterPartyId;
			if (hasInviterPartyId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.InviterPartyId);
			}
			bool hasInviteId = this.HasInviteId;
			if (hasInviteId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.InviteId);
			}
			num += this.reservationTokens_.CalculateSize(ConfirmPartyJoin._repeated_reservationTokens_codec);
			bool hasConfirmed = this.HasConfirmed;
			if (hasConfirmed)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004497 RID: 17559 RVA: 0x001087CC File Offset: 0x001069CC
		[DebuggerNonUserCode]
		public void MergeFrom(ConfirmPartyJoin other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasInviterPartyId = other.HasInviterPartyId;
				if (hasInviterPartyId)
				{
					this.InviterPartyId = other.InviterPartyId;
				}
				bool hasInviteId = other.HasInviteId;
				if (hasInviteId)
				{
					this.InviteId = other.InviteId;
				}
				this.reservationTokens_.Add(other.reservationTokens_);
				bool hasConfirmed = other.HasConfirmed;
				if (hasConfirmed)
				{
					this.Confirmed = other.Confirmed;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004498 RID: 17560 RVA: 0x00108859 File Offset: 0x00106A59
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004499 RID: 17561 RVA: 0x00108864 File Offset: 0x00106A64
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
						this.InviterPartyId = input.ReadString();
					}
				}
				else if (num3 != 24U && num3 != 26U)
				{
					if (num3 != 32U)
					{
						goto IL_0033;
					}
					this.Confirmed = input.ReadBool();
				}
				else
				{
					this.reservationTokens_.AddEntriesFrom(ref input, ConfirmPartyJoin._repeated_reservationTokens_codec);
				}
				continue;
				IL_0033:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001EBE RID: 7870
		private static readonly MessageParser<ConfirmPartyJoin> _parser = new MessageParser<ConfirmPartyJoin>(() => new ConfirmPartyJoin());

		// Token: 0x04001EBF RID: 7871
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EC0 RID: 7872
		private int _hasBits0;

		// Token: 0x04001EC1 RID: 7873
		public const int InviterPartyIdFieldNumber = 1;

		// Token: 0x04001EC2 RID: 7874
		private static readonly string InviterPartyIdDefaultValue = "";

		// Token: 0x04001EC3 RID: 7875
		private string inviterPartyId_;

		// Token: 0x04001EC4 RID: 7876
		public const int InviteIdFieldNumber = 2;

		// Token: 0x04001EC5 RID: 7877
		private static readonly ulong InviteIdDefaultValue = 0UL;

		// Token: 0x04001EC6 RID: 7878
		private ulong inviteId_;

		// Token: 0x04001EC7 RID: 7879
		public const int ReservationTokensFieldNumber = 3;

		// Token: 0x04001EC8 RID: 7880
		private static readonly FieldCodec<ulong> _repeated_reservationTokens_codec = FieldCodec.ForUInt64(24U);

		// Token: 0x04001EC9 RID: 7881
		private readonly RepeatedField<ulong> reservationTokens_ = new RepeatedField<ulong>();

		// Token: 0x04001ECA RID: 7882
		public const int ConfirmedFieldNumber = 4;

		// Token: 0x04001ECB RID: 7883
		private static readonly bool ConfirmedDefaultValue = false;

		// Token: 0x04001ECC RID: 7884
		private bool confirmed_;
	}
}
