using System;
using System.Diagnostics;
using Fenris.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Trade
{
	// Token: 0x0200010A RID: 266
	public sealed class TradeInfo : IMessage<TradeInfo>, IMessage, IEquatable<TradeInfo>, IDeepCloneable<TradeInfo>, IBufferMessage
	{
		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x0600195A RID: 6490 RVA: 0x0005A2F0 File Offset: 0x000584F0
		[DebuggerNonUserCode]
		public static MessageParser<TradeInfo> Parser
		{
			get
			{
				return TradeInfo._parser;
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x0600195B RID: 6491 RVA: 0x0005A308 File Offset: 0x00058508
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TradeReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x0600195C RID: 6492 RVA: 0x0005A32C File Offset: 0x0005852C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TradeInfo.Descriptor;
			}
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x0005A343 File Offset: 0x00058543
		[DebuggerNonUserCode]
		public TradeInfo()
		{
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x0005A37C File Offset: 0x0005857C
		[DebuggerNonUserCode]
		public TradeInfo(TradeInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.startedAt_ = other.startedAt_;
			this.trader1_ = ((other.trader1_ != null) ? other.trader1_.Clone() : null);
			this.trader2_ = ((other.trader2_ != null) ? other.trader2_.Clone() : null);
			this.itemsToTrade1_ = other.itemsToTrade1_.Clone();
			this.itemsToTrade2_ = other.itemsToTrade2_.Clone();
			this.currenciesToTrade1_ = other.currenciesToTrade1_.Clone();
			this.currenciesToTrade2_ = other.currenciesToTrade2_.Clone();
			this.bankTabToAddItemsInto_ = other.bankTabToAddItemsInto_;
			this.purchaseBankTabAtPrice_ = other.purchaseBankTabAtPrice_;
			this.tradeState1_ = other.tradeState1_;
			this.tradeState2_ = other.tradeState2_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x0005A468 File Offset: 0x00058668
		[DebuggerNonUserCode]
		public TradeInfo Clone()
		{
			return new TradeInfo(this);
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06001960 RID: 6496 RVA: 0x0005A480 File Offset: 0x00058680
		// (set) Token: 0x06001961 RID: 6497 RVA: 0x0005A4B1 File Offset: 0x000586B1
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
					startedAtDefaultValue = TradeInfo.StartedAtDefaultValue;
				}
				return startedAtDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.startedAt_ = value;
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06001962 RID: 6498 RVA: 0x0005A4CC File Offset: 0x000586CC
		[DebuggerNonUserCode]
		public bool HasStartedAt
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x0005A4E9 File Offset: 0x000586E9
		[DebuggerNonUserCode]
		public void ClearStartedAt()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x0005A4FC File Offset: 0x000586FC
		// (set) Token: 0x06001965 RID: 6501 RVA: 0x0005A514 File Offset: 0x00058714
		[DebuggerNonUserCode]
		public Trader Trader1
		{
			get
			{
				return this.trader1_;
			}
			set
			{
				this.trader1_ = value;
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x0005A520 File Offset: 0x00058720
		// (set) Token: 0x06001967 RID: 6503 RVA: 0x0005A538 File Offset: 0x00058738
		[DebuggerNonUserCode]
		public Trader Trader2
		{
			get
			{
				return this.trader2_;
			}
			set
			{
				this.trader2_ = value;
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x0005A544 File Offset: 0x00058744
		[DebuggerNonUserCode]
		public RepeatedField<TradeItem> ItemsToTrade1
		{
			get
			{
				return this.itemsToTrade1_;
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06001969 RID: 6505 RVA: 0x0005A55C File Offset: 0x0005875C
		[DebuggerNonUserCode]
		public RepeatedField<TradeItem> ItemsToTrade2
		{
			get
			{
				return this.itemsToTrade2_;
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x0600196A RID: 6506 RVA: 0x0005A574 File Offset: 0x00058774
		[DebuggerNonUserCode]
		public RepeatedField<CurrencyData> CurrenciesToTrade1
		{
			get
			{
				return this.currenciesToTrade1_;
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x0600196B RID: 6507 RVA: 0x0005A58C File Offset: 0x0005878C
		[DebuggerNonUserCode]
		public RepeatedField<CurrencyData> CurrenciesToTrade2
		{
			get
			{
				return this.currenciesToTrade2_;
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x0600196C RID: 6508 RVA: 0x0005A5A4 File Offset: 0x000587A4
		// (set) Token: 0x0600196D RID: 6509 RVA: 0x0005A5D5 File Offset: 0x000587D5
		[DebuggerNonUserCode]
		public int BankTabToAddItemsInto
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int bankTabToAddItemsIntoDefaultValue;
				if (flag)
				{
					bankTabToAddItemsIntoDefaultValue = this.bankTabToAddItemsInto_;
				}
				else
				{
					bankTabToAddItemsIntoDefaultValue = TradeInfo.BankTabToAddItemsIntoDefaultValue;
				}
				return bankTabToAddItemsIntoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.bankTabToAddItemsInto_ = value;
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x0600196E RID: 6510 RVA: 0x0005A5F0 File Offset: 0x000587F0
		[DebuggerNonUserCode]
		public bool HasBankTabToAddItemsInto
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x0005A60D File Offset: 0x0005880D
		[DebuggerNonUserCode]
		public void ClearBankTabToAddItemsInto()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06001970 RID: 6512 RVA: 0x0005A620 File Offset: 0x00058820
		// (set) Token: 0x06001971 RID: 6513 RVA: 0x0005A652 File Offset: 0x00058852
		[DebuggerNonUserCode]
		public ulong PurchaseBankTabAtPrice
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				ulong purchaseBankTabAtPriceDefaultValue;
				if (flag)
				{
					purchaseBankTabAtPriceDefaultValue = this.purchaseBankTabAtPrice_;
				}
				else
				{
					purchaseBankTabAtPriceDefaultValue = TradeInfo.PurchaseBankTabAtPriceDefaultValue;
				}
				return purchaseBankTabAtPriceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.purchaseBankTabAtPrice_ = value;
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06001972 RID: 6514 RVA: 0x0005A66C File Offset: 0x0005886C
		[DebuggerNonUserCode]
		public bool HasPurchaseBankTabAtPrice
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x0005A68A File Offset: 0x0005888A
		[DebuggerNonUserCode]
		public void ClearPurchaseBankTabAtPrice()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06001974 RID: 6516 RVA: 0x0005A69C File Offset: 0x0005889C
		// (set) Token: 0x06001975 RID: 6517 RVA: 0x0005A6CD File Offset: 0x000588CD
		[DebuggerNonUserCode]
		public uint TradeState1
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint tradeState1DefaultValue;
				if (flag)
				{
					tradeState1DefaultValue = this.tradeState1_;
				}
				else
				{
					tradeState1DefaultValue = TradeInfo.TradeState1DefaultValue;
				}
				return tradeState1DefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.tradeState1_ = value;
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06001976 RID: 6518 RVA: 0x0005A6E8 File Offset: 0x000588E8
		[DebuggerNonUserCode]
		public bool HasTradeState1
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x0005A705 File Offset: 0x00058905
		[DebuggerNonUserCode]
		public void ClearTradeState1()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06001978 RID: 6520 RVA: 0x0005A718 File Offset: 0x00058918
		// (set) Token: 0x06001979 RID: 6521 RVA: 0x0005A749 File Offset: 0x00058949
		[DebuggerNonUserCode]
		public uint TradeState2
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint tradeState2DefaultValue;
				if (flag)
				{
					tradeState2DefaultValue = this.tradeState2_;
				}
				else
				{
					tradeState2DefaultValue = TradeInfo.TradeState2DefaultValue;
				}
				return tradeState2DefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.tradeState2_ = value;
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x0600197A RID: 6522 RVA: 0x0005A764 File Offset: 0x00058964
		[DebuggerNonUserCode]
		public bool HasTradeState2
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x0005A781 File Offset: 0x00058981
		[DebuggerNonUserCode]
		public void ClearTradeState2()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x0005A794 File Offset: 0x00058994
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as TradeInfo);
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x0005A7B4 File Offset: 0x000589B4
		[DebuggerNonUserCode]
		public bool Equals(TradeInfo other)
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
						bool flag5 = !object.Equals(this.Trader1, other.Trader1);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Trader2, other.Trader2);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.itemsToTrade1_.Equals(other.itemsToTrade1_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.itemsToTrade2_.Equals(other.itemsToTrade2_);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !this.currenciesToTrade1_.Equals(other.currenciesToTrade1_);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !this.currenciesToTrade2_.Equals(other.currenciesToTrade2_);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.BankTabToAddItemsInto != other.BankTabToAddItemsInto;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.PurchaseBankTabAtPrice != other.PurchaseBankTabAtPrice;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.TradeState1 != other.TradeState1;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.TradeState2 != other.TradeState2;
															flag2 = !flag14 && object.Equals(this._unknownFields, other._unknownFields);
														}
													}
												}
											}
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

		// Token: 0x0600197E RID: 6526 RVA: 0x0005A948 File Offset: 0x00058B48
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasStartedAt = this.HasStartedAt;
			if (hasStartedAt)
			{
				num ^= this.StartedAt.GetHashCode();
			}
			bool flag = this.trader1_ != null;
			if (flag)
			{
				num ^= this.Trader1.GetHashCode();
			}
			bool flag2 = this.trader2_ != null;
			if (flag2)
			{
				num ^= this.Trader2.GetHashCode();
			}
			num ^= this.itemsToTrade1_.GetHashCode();
			num ^= this.itemsToTrade2_.GetHashCode();
			num ^= this.currenciesToTrade1_.GetHashCode();
			num ^= this.currenciesToTrade2_.GetHashCode();
			bool hasBankTabToAddItemsInto = this.HasBankTabToAddItemsInto;
			if (hasBankTabToAddItemsInto)
			{
				num ^= this.BankTabToAddItemsInto.GetHashCode();
			}
			bool hasPurchaseBankTabAtPrice = this.HasPurchaseBankTabAtPrice;
			if (hasPurchaseBankTabAtPrice)
			{
				num ^= this.PurchaseBankTabAtPrice.GetHashCode();
			}
			bool hasTradeState = this.HasTradeState1;
			if (hasTradeState)
			{
				num ^= this.TradeState1.GetHashCode();
			}
			bool hasTradeState2 = this.HasTradeState2;
			if (hasTradeState2)
			{
				num ^= this.TradeState2.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x0005AA80 File Offset: 0x00058C80
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x0005AA98 File Offset: 0x00058C98
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x0005AAA4 File Offset: 0x00058CA4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasStartedAt = this.HasStartedAt;
			if (hasStartedAt)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.StartedAt);
			}
			bool flag = this.trader1_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Trader1);
			}
			bool flag2 = this.trader2_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Trader2);
			}
			this.itemsToTrade1_.WriteTo(ref output, TradeInfo._repeated_itemsToTrade1_codec);
			this.itemsToTrade2_.WriteTo(ref output, TradeInfo._repeated_itemsToTrade2_codec);
			this.currenciesToTrade1_.WriteTo(ref output, TradeInfo._repeated_currenciesToTrade1_codec);
			this.currenciesToTrade2_.WriteTo(ref output, TradeInfo._repeated_currenciesToTrade2_codec);
			bool hasBankTabToAddItemsInto = this.HasBankTabToAddItemsInto;
			if (hasBankTabToAddItemsInto)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.BankTabToAddItemsInto);
			}
			bool hasTradeState = this.HasTradeState1;
			if (hasTradeState)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.TradeState1);
			}
			bool hasTradeState2 = this.HasTradeState2;
			if (hasTradeState2)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.TradeState2);
			}
			bool hasPurchaseBankTabAtPrice = this.HasPurchaseBankTabAtPrice;
			if (hasPurchaseBankTabAtPrice)
			{
				output.WriteRawTag(96);
				output.WriteUInt64(this.PurchaseBankTabAtPrice);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x0005AC14 File Offset: 0x00058E14
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasStartedAt = this.HasStartedAt;
			if (hasStartedAt)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.StartedAt);
			}
			bool flag = this.trader1_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Trader1);
			}
			bool flag2 = this.trader2_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Trader2);
			}
			num += this.itemsToTrade1_.CalculateSize(TradeInfo._repeated_itemsToTrade1_codec);
			num += this.itemsToTrade2_.CalculateSize(TradeInfo._repeated_itemsToTrade2_codec);
			num += this.currenciesToTrade1_.CalculateSize(TradeInfo._repeated_currenciesToTrade1_codec);
			num += this.currenciesToTrade2_.CalculateSize(TradeInfo._repeated_currenciesToTrade2_codec);
			bool hasBankTabToAddItemsInto = this.HasBankTabToAddItemsInto;
			if (hasBankTabToAddItemsInto)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BankTabToAddItemsInto);
			}
			bool hasPurchaseBankTabAtPrice = this.HasPurchaseBankTabAtPrice;
			if (hasPurchaseBankTabAtPrice)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.PurchaseBankTabAtPrice);
			}
			bool hasTradeState = this.HasTradeState1;
			if (hasTradeState)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TradeState1);
			}
			bool hasTradeState2 = this.HasTradeState2;
			if (hasTradeState2)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TradeState2);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x0005AD68 File Offset: 0x00058F68
		[DebuggerNonUserCode]
		public void MergeFrom(TradeInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasStartedAt = other.HasStartedAt;
				if (hasStartedAt)
				{
					this.StartedAt = other.StartedAt;
				}
				bool flag2 = other.trader1_ != null;
				if (flag2)
				{
					bool flag3 = this.trader1_ == null;
					if (flag3)
					{
						this.Trader1 = new Trader();
					}
					this.Trader1.MergeFrom(other.Trader1);
				}
				bool flag4 = other.trader2_ != null;
				if (flag4)
				{
					bool flag5 = this.trader2_ == null;
					if (flag5)
					{
						this.Trader2 = new Trader();
					}
					this.Trader2.MergeFrom(other.Trader2);
				}
				this.itemsToTrade1_.Add(other.itemsToTrade1_);
				this.itemsToTrade2_.Add(other.itemsToTrade2_);
				this.currenciesToTrade1_.Add(other.currenciesToTrade1_);
				this.currenciesToTrade2_.Add(other.currenciesToTrade2_);
				bool hasBankTabToAddItemsInto = other.HasBankTabToAddItemsInto;
				if (hasBankTabToAddItemsInto)
				{
					this.BankTabToAddItemsInto = other.BankTabToAddItemsInto;
				}
				bool hasPurchaseBankTabAtPrice = other.HasPurchaseBankTabAtPrice;
				if (hasPurchaseBankTabAtPrice)
				{
					this.PurchaseBankTabAtPrice = other.PurchaseBankTabAtPrice;
				}
				bool hasTradeState = other.HasTradeState1;
				if (hasTradeState)
				{
					this.TradeState1 = other.TradeState1;
				}
				bool hasTradeState2 = other.HasTradeState2;
				if (hasTradeState2)
				{
					this.TradeState2 = other.TradeState2;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x0005AEE4 File Offset: 0x000590E4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x0005AEF0 File Offset: 0x000590F0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 42U)
				{
					if (num3 <= 18U)
					{
						if (num3 != 8U)
						{
							if (num3 != 18U)
							{
								goto IL_0087;
							}
							bool flag = this.trader1_ == null;
							if (flag)
							{
								this.Trader1 = new Trader();
							}
							input.ReadMessage(this.Trader1);
						}
						else
						{
							this.StartedAt = input.ReadUInt64();
						}
					}
					else if (num3 != 26U)
					{
						if (num3 != 34U)
						{
							if (num3 != 42U)
							{
								goto IL_0087;
							}
							this.itemsToTrade2_.AddEntriesFrom(ref input, TradeInfo._repeated_itemsToTrade2_codec);
						}
						else
						{
							this.itemsToTrade1_.AddEntriesFrom(ref input, TradeInfo._repeated_itemsToTrade1_codec);
						}
					}
					else
					{
						bool flag2 = this.trader2_ == null;
						if (flag2)
						{
							this.Trader2 = new Trader();
						}
						input.ReadMessage(this.Trader2);
					}
				}
				else if (num3 <= 72U)
				{
					if (num3 != 50U)
					{
						if (num3 != 58U)
						{
							if (num3 != 72U)
							{
								goto IL_0087;
							}
							this.BankTabToAddItemsInto = input.ReadInt32();
						}
						else
						{
							this.currenciesToTrade2_.AddEntriesFrom(ref input, TradeInfo._repeated_currenciesToTrade2_codec);
						}
					}
					else
					{
						this.currenciesToTrade1_.AddEntriesFrom(ref input, TradeInfo._repeated_currenciesToTrade1_codec);
					}
				}
				else if (num3 != 80U)
				{
					if (num3 != 88U)
					{
						if (num3 != 96U)
						{
							goto IL_0087;
						}
						this.PurchaseBankTabAtPrice = input.ReadUInt64();
					}
					else
					{
						this.TradeState2 = input.ReadUInt32();
					}
				}
				else
				{
					this.TradeState1 = input.ReadUInt32();
				}
				continue;
				IL_0087:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000A12 RID: 2578
		private static readonly MessageParser<TradeInfo> _parser = new MessageParser<TradeInfo>(() => new TradeInfo());

		// Token: 0x04000A13 RID: 2579
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A14 RID: 2580
		private int _hasBits0;

		// Token: 0x04000A15 RID: 2581
		public const int StartedAtFieldNumber = 1;

		// Token: 0x04000A16 RID: 2582
		private static readonly ulong StartedAtDefaultValue = 0UL;

		// Token: 0x04000A17 RID: 2583
		private ulong startedAt_;

		// Token: 0x04000A18 RID: 2584
		public const int Trader1FieldNumber = 2;

		// Token: 0x04000A19 RID: 2585
		private Trader trader1_;

		// Token: 0x04000A1A RID: 2586
		public const int Trader2FieldNumber = 3;

		// Token: 0x04000A1B RID: 2587
		private Trader trader2_;

		// Token: 0x04000A1C RID: 2588
		public const int ItemsToTrade1FieldNumber = 4;

		// Token: 0x04000A1D RID: 2589
		private static readonly FieldCodec<TradeItem> _repeated_itemsToTrade1_codec = FieldCodec.ForMessage<TradeItem>(34U, TradeItem.Parser);

		// Token: 0x04000A1E RID: 2590
		private readonly RepeatedField<TradeItem> itemsToTrade1_ = new RepeatedField<TradeItem>();

		// Token: 0x04000A1F RID: 2591
		public const int ItemsToTrade2FieldNumber = 5;

		// Token: 0x04000A20 RID: 2592
		private static readonly FieldCodec<TradeItem> _repeated_itemsToTrade2_codec = FieldCodec.ForMessage<TradeItem>(42U, TradeItem.Parser);

		// Token: 0x04000A21 RID: 2593
		private readonly RepeatedField<TradeItem> itemsToTrade2_ = new RepeatedField<TradeItem>();

		// Token: 0x04000A22 RID: 2594
		public const int CurrenciesToTrade1FieldNumber = 6;

		// Token: 0x04000A23 RID: 2595
		private static readonly FieldCodec<CurrencyData> _repeated_currenciesToTrade1_codec = FieldCodec.ForMessage<CurrencyData>(50U, CurrencyData.Parser);

		// Token: 0x04000A24 RID: 2596
		private readonly RepeatedField<CurrencyData> currenciesToTrade1_ = new RepeatedField<CurrencyData>();

		// Token: 0x04000A25 RID: 2597
		public const int CurrenciesToTrade2FieldNumber = 7;

		// Token: 0x04000A26 RID: 2598
		private static readonly FieldCodec<CurrencyData> _repeated_currenciesToTrade2_codec = FieldCodec.ForMessage<CurrencyData>(58U, CurrencyData.Parser);

		// Token: 0x04000A27 RID: 2599
		private readonly RepeatedField<CurrencyData> currenciesToTrade2_ = new RepeatedField<CurrencyData>();

		// Token: 0x04000A28 RID: 2600
		public const int BankTabToAddItemsIntoFieldNumber = 9;

		// Token: 0x04000A29 RID: 2601
		private static readonly int BankTabToAddItemsIntoDefaultValue = 0;

		// Token: 0x04000A2A RID: 2602
		private int bankTabToAddItemsInto_;

		// Token: 0x04000A2B RID: 2603
		public const int PurchaseBankTabAtPriceFieldNumber = 12;

		// Token: 0x04000A2C RID: 2604
		private static readonly ulong PurchaseBankTabAtPriceDefaultValue = 0UL;

		// Token: 0x04000A2D RID: 2605
		private ulong purchaseBankTabAtPrice_;

		// Token: 0x04000A2E RID: 2606
		public const int TradeState1FieldNumber = 10;

		// Token: 0x04000A2F RID: 2607
		private static readonly uint TradeState1DefaultValue = 0U;

		// Token: 0x04000A30 RID: 2608
		private uint tradeState1_;

		// Token: 0x04000A31 RID: 2609
		public const int TradeState2FieldNumber = 11;

		// Token: 0x04000A32 RID: 2610
		private static readonly uint TradeState2DefaultValue = 0U;

		// Token: 0x04000A33 RID: 2611
		private uint tradeState2_;
	}
}
