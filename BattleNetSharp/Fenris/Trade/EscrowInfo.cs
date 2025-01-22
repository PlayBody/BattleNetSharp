using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Trade
{
	// Token: 0x02000108 RID: 264
	public sealed class EscrowInfo : IMessage<EscrowInfo>, IMessage, IEquatable<EscrowInfo>, IDeepCloneable<EscrowInfo>, IBufferMessage
	{
		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06001919 RID: 6425 RVA: 0x000593AC File Offset: 0x000575AC
		[DebuggerNonUserCode]
		public static MessageParser<EscrowInfo> Parser
		{
			get
			{
				return EscrowInfo._parser;
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x0600191A RID: 6426 RVA: 0x000593C4 File Offset: 0x000575C4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TradeReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x0600191B RID: 6427 RVA: 0x000593E8 File Offset: 0x000575E8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EscrowInfo.Descriptor;
			}
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x000593FF File Offset: 0x000575FF
		[DebuggerNonUserCode]
		public EscrowInfo()
		{
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x00059414 File Offset: 0x00057614
		[DebuggerNonUserCode]
		public EscrowInfo(EscrowInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.startedAt_ = other.startedAt_;
			this.state_ = other.state_;
			this.itemIdsToEscrow_ = other.itemIdsToEscrow_.Clone();
			this.bankTabToReserve_ = other.bankTabToReserve_;
			this.bankSlotsToReserve_ = other.bankSlotsToReserve_;
			this.reserveBankTabToPurchaseAtPrice_ = other.reserveBankTabToPurchaseAtPrice_;
			this.traderSide_ = other.traderSide_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x000594A0 File Offset: 0x000576A0
		[DebuggerNonUserCode]
		public EscrowInfo Clone()
		{
			return new EscrowInfo(this);
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x0600191F RID: 6431 RVA: 0x000594B8 File Offset: 0x000576B8
		// (set) Token: 0x06001920 RID: 6432 RVA: 0x000594E9 File Offset: 0x000576E9
		[DebuggerNonUserCode]
		public ulong StartedAt
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong startedAtDefaultValue;
				if (flag)
				{
					startedAtDefaultValue = this.startedAt_;
				}
				else
				{
					startedAtDefaultValue = EscrowInfo.StartedAtDefaultValue;
				}
				return startedAtDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.startedAt_ = value;
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06001921 RID: 6433 RVA: 0x00059504 File Offset: 0x00057704
		[DebuggerNonUserCode]
		public bool HasStartedAt
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x00059521 File Offset: 0x00057721
		[DebuggerNonUserCode]
		public void ClearStartedAt()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06001923 RID: 6435 RVA: 0x00059534 File Offset: 0x00057734
		// (set) Token: 0x06001924 RID: 6436 RVA: 0x00059565 File Offset: 0x00057765
		[DebuggerNonUserCode]
		public uint State
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint stateDefaultValue;
				if (flag)
				{
					stateDefaultValue = this.state_;
				}
				else
				{
					stateDefaultValue = EscrowInfo.StateDefaultValue;
				}
				return stateDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.state_ = value;
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06001925 RID: 6437 RVA: 0x00059580 File Offset: 0x00057780
		[DebuggerNonUserCode]
		public bool HasState
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x0005959D File Offset: 0x0005779D
		[DebuggerNonUserCode]
		public void ClearState()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06001927 RID: 6439 RVA: 0x000595B0 File Offset: 0x000577B0
		[DebuggerNonUserCode]
		public RepeatedField<string> ItemIdsToEscrow
		{
			get
			{
				return this.itemIdsToEscrow_;
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06001928 RID: 6440 RVA: 0x000595C8 File Offset: 0x000577C8
		// (set) Token: 0x06001929 RID: 6441 RVA: 0x000595F9 File Offset: 0x000577F9
		[DebuggerNonUserCode]
		public int BankTabToReserve
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int bankTabToReserveDefaultValue;
				if (flag)
				{
					bankTabToReserveDefaultValue = this.bankTabToReserve_;
				}
				else
				{
					bankTabToReserveDefaultValue = EscrowInfo.BankTabToReserveDefaultValue;
				}
				return bankTabToReserveDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.bankTabToReserve_ = value;
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x00059614 File Offset: 0x00057814
		[DebuggerNonUserCode]
		public bool HasBankTabToReserve
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x00059631 File Offset: 0x00057831
		[DebuggerNonUserCode]
		public void ClearBankTabToReserve()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x0600192C RID: 6444 RVA: 0x00059644 File Offset: 0x00057844
		// (set) Token: 0x0600192D RID: 6445 RVA: 0x00059675 File Offset: 0x00057875
		[DebuggerNonUserCode]
		public uint BankSlotsToReserve
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint bankSlotsToReserveDefaultValue;
				if (flag)
				{
					bankSlotsToReserveDefaultValue = this.bankSlotsToReserve_;
				}
				else
				{
					bankSlotsToReserveDefaultValue = EscrowInfo.BankSlotsToReserveDefaultValue;
				}
				return bankSlotsToReserveDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.bankSlotsToReserve_ = value;
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x0600192E RID: 6446 RVA: 0x00059690 File Offset: 0x00057890
		[DebuggerNonUserCode]
		public bool HasBankSlotsToReserve
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x000596AD File Offset: 0x000578AD
		[DebuggerNonUserCode]
		public void ClearBankSlotsToReserve()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06001930 RID: 6448 RVA: 0x000596C0 File Offset: 0x000578C0
		// (set) Token: 0x06001931 RID: 6449 RVA: 0x000596F2 File Offset: 0x000578F2
		[DebuggerNonUserCode]
		public ulong ReserveBankTabToPurchaseAtPrice
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				ulong reserveBankTabToPurchaseAtPriceDefaultValue;
				if (flag)
				{
					reserveBankTabToPurchaseAtPriceDefaultValue = this.reserveBankTabToPurchaseAtPrice_;
				}
				else
				{
					reserveBankTabToPurchaseAtPriceDefaultValue = EscrowInfo.ReserveBankTabToPurchaseAtPriceDefaultValue;
				}
				return reserveBankTabToPurchaseAtPriceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.reserveBankTabToPurchaseAtPrice_ = value;
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06001932 RID: 6450 RVA: 0x0005970C File Offset: 0x0005790C
		[DebuggerNonUserCode]
		public bool HasReserveBankTabToPurchaseAtPrice
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x0005972A File Offset: 0x0005792A
		[DebuggerNonUserCode]
		public void ClearReserveBankTabToPurchaseAtPrice()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06001934 RID: 6452 RVA: 0x0005973C File Offset: 0x0005793C
		// (set) Token: 0x06001935 RID: 6453 RVA: 0x0005976E File Offset: 0x0005796E
		[DebuggerNonUserCode]
		public uint TraderSide
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint traderSideDefaultValue;
				if (flag)
				{
					traderSideDefaultValue = this.traderSide_;
				}
				else
				{
					traderSideDefaultValue = EscrowInfo.TraderSideDefaultValue;
				}
				return traderSideDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.traderSide_ = value;
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x00059788 File Offset: 0x00057988
		[DebuggerNonUserCode]
		public bool HasTraderSide
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x000597A6 File Offset: 0x000579A6
		[DebuggerNonUserCode]
		public void ClearTraderSide()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x000597B8 File Offset: 0x000579B8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EscrowInfo);
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x000597D8 File Offset: 0x000579D8
		[DebuggerNonUserCode]
		public bool Equals(EscrowInfo other)
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
					bool flag4 = this.StartedAt != other.StartedAt;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.State != other.State;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.itemIdsToEscrow_.Equals(other.itemIdsToEscrow_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.BankTabToReserve != other.BankTabToReserve;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.BankSlotsToReserve != other.BankSlotsToReserve;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.ReserveBankTabToPurchaseAtPrice != other.ReserveBankTabToPurchaseAtPrice;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.TraderSide != other.TraderSide;
											flag2 = !flag10 && object.Equals(this._unknownFields, other._unknownFields);
										}
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x000598E4 File Offset: 0x00057AE4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasStartedAt = this.HasStartedAt;
			if (hasStartedAt)
			{
				num ^= this.StartedAt.GetHashCode();
			}
			bool hasState = this.HasState;
			if (hasState)
			{
				num ^= this.State.GetHashCode();
			}
			num ^= this.itemIdsToEscrow_.GetHashCode();
			bool hasBankTabToReserve = this.HasBankTabToReserve;
			if (hasBankTabToReserve)
			{
				num ^= this.BankTabToReserve.GetHashCode();
			}
			bool hasBankSlotsToReserve = this.HasBankSlotsToReserve;
			if (hasBankSlotsToReserve)
			{
				num ^= this.BankSlotsToReserve.GetHashCode();
			}
			bool hasReserveBankTabToPurchaseAtPrice = this.HasReserveBankTabToPurchaseAtPrice;
			if (hasReserveBankTabToPurchaseAtPrice)
			{
				num ^= this.ReserveBankTabToPurchaseAtPrice.GetHashCode();
			}
			bool hasTraderSide = this.HasTraderSide;
			if (hasTraderSide)
			{
				num ^= this.TraderSide.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x000599D8 File Offset: 0x00057BD8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x000599F0 File Offset: 0x00057BF0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x000599FC File Offset: 0x00057BFC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasStartedAt = this.HasStartedAt;
			if (hasStartedAt)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.StartedAt);
			}
			bool hasState = this.HasState;
			if (hasState)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.State);
			}
			this.itemIdsToEscrow_.WriteTo(ref output, EscrowInfo._repeated_itemIdsToEscrow_codec);
			bool hasBankTabToReserve = this.HasBankTabToReserve;
			if (hasBankTabToReserve)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.BankTabToReserve);
			}
			bool hasBankSlotsToReserve = this.HasBankSlotsToReserve;
			if (hasBankSlotsToReserve)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.BankSlotsToReserve);
			}
			bool hasTraderSide = this.HasTraderSide;
			if (hasTraderSide)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.TraderSide);
			}
			bool hasReserveBankTabToPurchaseAtPrice = this.HasReserveBankTabToPurchaseAtPrice;
			if (hasReserveBankTabToPurchaseAtPrice)
			{
				output.WriteRawTag(64);
				output.WriteUInt64(this.ReserveBankTabToPurchaseAtPrice);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x00059B0C File Offset: 0x00057D0C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasStartedAt = this.HasStartedAt;
			if (hasStartedAt)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.StartedAt);
			}
			bool hasState = this.HasState;
			if (hasState)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.State);
			}
			num += this.itemIdsToEscrow_.CalculateSize(EscrowInfo._repeated_itemIdsToEscrow_codec);
			bool hasBankTabToReserve = this.HasBankTabToReserve;
			if (hasBankTabToReserve)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BankTabToReserve);
			}
			bool hasBankSlotsToReserve = this.HasBankSlotsToReserve;
			if (hasBankSlotsToReserve)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BankSlotsToReserve);
			}
			bool hasReserveBankTabToPurchaseAtPrice = this.HasReserveBankTabToPurchaseAtPrice;
			if (hasReserveBankTabToPurchaseAtPrice)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ReserveBankTabToPurchaseAtPrice);
			}
			bool hasTraderSide = this.HasTraderSide;
			if (hasTraderSide)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TraderSide);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x00059C04 File Offset: 0x00057E04
		[DebuggerNonUserCode]
		public void MergeFrom(EscrowInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasStartedAt = other.HasStartedAt;
				if (hasStartedAt)
				{
					this.StartedAt = other.StartedAt;
				}
				bool hasState = other.HasState;
				if (hasState)
				{
					this.State = other.State;
				}
				this.itemIdsToEscrow_.Add(other.itemIdsToEscrow_);
				bool hasBankTabToReserve = other.HasBankTabToReserve;
				if (hasBankTabToReserve)
				{
					this.BankTabToReserve = other.BankTabToReserve;
				}
				bool hasBankSlotsToReserve = other.HasBankSlotsToReserve;
				if (hasBankSlotsToReserve)
				{
					this.BankSlotsToReserve = other.BankSlotsToReserve;
				}
				bool hasReserveBankTabToPurchaseAtPrice = other.HasReserveBankTabToPurchaseAtPrice;
				if (hasReserveBankTabToPurchaseAtPrice)
				{
					this.ReserveBankTabToPurchaseAtPrice = other.ReserveBankTabToPurchaseAtPrice;
				}
				bool hasTraderSide = other.HasTraderSide;
				if (hasTraderSide)
				{
					this.TraderSide = other.TraderSide;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x00059CE5 File Offset: 0x00057EE5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x00059CF0 File Offset: 0x00057EF0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 26U)
				{
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							if (num3 != 26U)
							{
								goto IL_0045;
							}
							this.itemIdsToEscrow_.AddEntriesFrom(ref input, EscrowInfo._repeated_itemIdsToEscrow_codec);
						}
						else
						{
							this.State = input.ReadUInt32();
						}
					}
					else
					{
						this.StartedAt = input.ReadUInt64();
					}
				}
				else if (num3 <= 40U)
				{
					if (num3 != 32U)
					{
						if (num3 != 40U)
						{
							goto IL_0045;
						}
						this.BankSlotsToReserve = input.ReadUInt32();
					}
					else
					{
						this.BankTabToReserve = input.ReadInt32();
					}
				}
				else if (num3 != 48U)
				{
					if (num3 != 64U)
					{
						goto IL_0045;
					}
					this.ReserveBankTabToPurchaseAtPrice = input.ReadUInt64();
				}
				else
				{
					this.TraderSide = input.ReadUInt32();
				}
				continue;
				IL_0045:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040009F2 RID: 2546
		private static readonly MessageParser<EscrowInfo> _parser = new MessageParser<EscrowInfo>(() => new EscrowInfo());

		// Token: 0x040009F3 RID: 2547
		private UnknownFieldSet _unknownFields;

		// Token: 0x040009F4 RID: 2548
		private int _hasBits0;

		// Token: 0x040009F5 RID: 2549
		public const int StartedAtFieldNumber = 1;

		// Token: 0x040009F6 RID: 2550
		private static readonly ulong StartedAtDefaultValue = 0UL;

		// Token: 0x040009F7 RID: 2551
		private ulong startedAt_;

		// Token: 0x040009F8 RID: 2552
		public const int StateFieldNumber = 2;

		// Token: 0x040009F9 RID: 2553
		private static readonly uint StateDefaultValue = 0U;

		// Token: 0x040009FA RID: 2554
		private uint state_;

		// Token: 0x040009FB RID: 2555
		public const int ItemIdsToEscrowFieldNumber = 3;

		// Token: 0x040009FC RID: 2556
		private static readonly FieldCodec<string> _repeated_itemIdsToEscrow_codec = FieldCodec.ForString(26U);

		// Token: 0x040009FD RID: 2557
		private readonly RepeatedField<string> itemIdsToEscrow_ = new RepeatedField<string>();

		// Token: 0x040009FE RID: 2558
		public const int BankTabToReserveFieldNumber = 4;

		// Token: 0x040009FF RID: 2559
		private static readonly int BankTabToReserveDefaultValue = 0;

		// Token: 0x04000A00 RID: 2560
		private int bankTabToReserve_;

		// Token: 0x04000A01 RID: 2561
		public const int BankSlotsToReserveFieldNumber = 5;

		// Token: 0x04000A02 RID: 2562
		private static readonly uint BankSlotsToReserveDefaultValue = 0U;

		// Token: 0x04000A03 RID: 2563
		private uint bankSlotsToReserve_;

		// Token: 0x04000A04 RID: 2564
		public const int ReserveBankTabToPurchaseAtPriceFieldNumber = 8;

		// Token: 0x04000A05 RID: 2565
		private static readonly ulong ReserveBankTabToPurchaseAtPriceDefaultValue = 0UL;

		// Token: 0x04000A06 RID: 2566
		private ulong reserveBankTabToPurchaseAtPrice_;

		// Token: 0x04000A07 RID: 2567
		public const int TraderSideFieldNumber = 6;

		// Token: 0x04000A08 RID: 2568
		private static readonly uint TraderSideDefaultValue = 0U;

		// Token: 0x04000A09 RID: 2569
		private uint traderSide_;
	}
}
