using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001CE RID: 462
	public sealed class ProgressDiabloEventCurrency : IMessage<ProgressDiabloEventCurrency>, IMessage, IEquatable<ProgressDiabloEventCurrency>, IDeepCloneable<ProgressDiabloEventCurrency>, IBufferMessage
	{
		// Token: 0x17000FDC RID: 4060
		// (get) Token: 0x06003142 RID: 12610 RVA: 0x000C2D74 File Offset: 0x000C0F74
		[DebuggerNonUserCode]
		public static MessageParser<ProgressDiabloEventCurrency> Parser
		{
			get
			{
				return ProgressDiabloEventCurrency._parser;
			}
		}

		// Token: 0x17000FDD RID: 4061
		// (get) Token: 0x06003143 RID: 12611 RVA: 0x000C2D8C File Offset: 0x000C0F8C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[19];
			}
		}

		// Token: 0x17000FDE RID: 4062
		// (get) Token: 0x06003144 RID: 12612 RVA: 0x000C2DB0 File Offset: 0x000C0FB0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ProgressDiabloEventCurrency.Descriptor;
			}
		}

		// Token: 0x06003145 RID: 12613 RVA: 0x000C2DC7 File Offset: 0x000C0FC7
		[DebuggerNonUserCode]
		public ProgressDiabloEventCurrency()
		{
		}

		// Token: 0x06003146 RID: 12614 RVA: 0x000C2DD1 File Offset: 0x000C0FD1
		[DebuggerNonUserCode]
		public ProgressDiabloEventCurrency(ProgressDiabloEventCurrency other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.currencyType_ = other.currencyType_;
			this.currencyAmount_ = other.currencyAmount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003147 RID: 12615 RVA: 0x000C2E10 File Offset: 0x000C1010
		[DebuggerNonUserCode]
		public ProgressDiabloEventCurrency Clone()
		{
			return new ProgressDiabloEventCurrency(this);
		}

		// Token: 0x17000FDF RID: 4063
		// (get) Token: 0x06003148 RID: 12616 RVA: 0x000C2E28 File Offset: 0x000C1028
		// (set) Token: 0x06003149 RID: 12617 RVA: 0x000C2E59 File Offset: 0x000C1059
		[DebuggerNonUserCode]
		public int CurrencyType
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int currencyTypeDefaultValue;
				if (flag)
				{
					currencyTypeDefaultValue = this.currencyType_;
				}
				else
				{
					currencyTypeDefaultValue = ProgressDiabloEventCurrency.CurrencyTypeDefaultValue;
				}
				return currencyTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.currencyType_ = value;
			}
		}

		// Token: 0x17000FE0 RID: 4064
		// (get) Token: 0x0600314A RID: 12618 RVA: 0x000C2E74 File Offset: 0x000C1074
		[DebuggerNonUserCode]
		public bool HasCurrencyType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600314B RID: 12619 RVA: 0x000C2E91 File Offset: 0x000C1091
		[DebuggerNonUserCode]
		public void ClearCurrencyType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000FE1 RID: 4065
		// (get) Token: 0x0600314C RID: 12620 RVA: 0x000C2EA4 File Offset: 0x000C10A4
		// (set) Token: 0x0600314D RID: 12621 RVA: 0x000C2ED5 File Offset: 0x000C10D5
		[DebuggerNonUserCode]
		public ulong CurrencyAmount
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong currencyAmountDefaultValue;
				if (flag)
				{
					currencyAmountDefaultValue = this.currencyAmount_;
				}
				else
				{
					currencyAmountDefaultValue = ProgressDiabloEventCurrency.CurrencyAmountDefaultValue;
				}
				return currencyAmountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.currencyAmount_ = value;
			}
		}

		// Token: 0x17000FE2 RID: 4066
		// (get) Token: 0x0600314E RID: 12622 RVA: 0x000C2EF0 File Offset: 0x000C10F0
		[DebuggerNonUserCode]
		public bool HasCurrencyAmount
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600314F RID: 12623 RVA: 0x000C2F0D File Offset: 0x000C110D
		[DebuggerNonUserCode]
		public void ClearCurrencyAmount()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06003150 RID: 12624 RVA: 0x000C2F20 File Offset: 0x000C1120
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ProgressDiabloEventCurrency);
		}

		// Token: 0x06003151 RID: 12625 RVA: 0x000C2F40 File Offset: 0x000C1140
		[DebuggerNonUserCode]
		public bool Equals(ProgressDiabloEventCurrency other)
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
					bool flag4 = this.CurrencyType != other.CurrencyType;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.CurrencyAmount != other.CurrencyAmount;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003152 RID: 12626 RVA: 0x000C2FB4 File Offset: 0x000C11B4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasCurrencyType = this.HasCurrencyType;
			if (hasCurrencyType)
			{
				num ^= this.CurrencyType.GetHashCode();
			}
			bool hasCurrencyAmount = this.HasCurrencyAmount;
			if (hasCurrencyAmount)
			{
				num ^= this.CurrencyAmount.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003153 RID: 12627 RVA: 0x000C3024 File Offset: 0x000C1224
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003154 RID: 12628 RVA: 0x000C303C File Offset: 0x000C123C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003155 RID: 12629 RVA: 0x000C3048 File Offset: 0x000C1248
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasCurrencyType = this.HasCurrencyType;
			if (hasCurrencyType)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CurrencyType);
			}
			bool hasCurrencyAmount = this.HasCurrencyAmount;
			if (hasCurrencyAmount)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.CurrencyAmount);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003156 RID: 12630 RVA: 0x000C30B8 File Offset: 0x000C12B8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasCurrencyType = this.HasCurrencyType;
			if (hasCurrencyType)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurrencyType);
			}
			bool hasCurrencyAmount = this.HasCurrencyAmount;
			if (hasCurrencyAmount)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CurrencyAmount);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003157 RID: 12631 RVA: 0x000C3124 File Offset: 0x000C1324
		[DebuggerNonUserCode]
		public void MergeFrom(ProgressDiabloEventCurrency other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasCurrencyType = other.HasCurrencyType;
				if (hasCurrencyType)
				{
					this.CurrencyType = other.CurrencyType;
				}
				bool hasCurrencyAmount = other.HasCurrencyAmount;
				if (hasCurrencyAmount)
				{
					this.CurrencyAmount = other.CurrencyAmount;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003158 RID: 12632 RVA: 0x000C3186 File Offset: 0x000C1386
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003159 RID: 12633 RVA: 0x000C3194 File Offset: 0x000C1394
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CurrencyAmount = input.ReadUInt64();
					}
				}
				else
				{
					this.CurrencyType = input.ReadInt32();
				}
			}
		}

		// Token: 0x04001685 RID: 5765
		private static readonly MessageParser<ProgressDiabloEventCurrency> _parser = new MessageParser<ProgressDiabloEventCurrency>(() => new ProgressDiabloEventCurrency());

		// Token: 0x04001686 RID: 5766
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001687 RID: 5767
		private int _hasBits0;

		// Token: 0x04001688 RID: 5768
		public const int CurrencyTypeFieldNumber = 1;

		// Token: 0x04001689 RID: 5769
		private static readonly int CurrencyTypeDefaultValue = 0;

		// Token: 0x0400168A RID: 5770
		private int currencyType_;

		// Token: 0x0400168B RID: 5771
		public const int CurrencyAmountFieldNumber = 2;

		// Token: 0x0400168C RID: 5772
		private static readonly ulong CurrencyAmountDefaultValue = 0UL;

		// Token: 0x0400168D RID: 5773
		private ulong currencyAmount_;
	}
}
