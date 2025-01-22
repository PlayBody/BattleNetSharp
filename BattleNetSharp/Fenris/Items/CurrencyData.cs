using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Items
{
	// Token: 0x0200016D RID: 365
	public sealed class CurrencyData : IMessage<CurrencyData>, IMessage, IEquatable<CurrencyData>, IDeepCloneable<CurrencyData>, IBufferMessage
	{
		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x0600261A RID: 9754 RVA: 0x000941D0 File Offset: 0x000923D0
		[DebuggerNonUserCode]
		public static MessageParser<CurrencyData> Parser
		{
			get
			{
				return CurrencyData._parser;
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x0600261B RID: 9755 RVA: 0x000941E8 File Offset: 0x000923E8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ItemsReflection.Descriptor.MessageTypes[14];
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x0600261C RID: 9756 RVA: 0x0009420C File Offset: 0x0009240C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CurrencyData.Descriptor;
			}
		}

		// Token: 0x0600261D RID: 9757 RVA: 0x00094223 File Offset: 0x00092423
		[DebuggerNonUserCode]
		public CurrencyData()
		{
		}

		// Token: 0x0600261E RID: 9758 RVA: 0x0009422D File Offset: 0x0009242D
		[DebuggerNonUserCode]
		public CurrencyData(CurrencyData other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.currencyType_ = other.currencyType_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600261F RID: 9759 RVA: 0x0009426C File Offset: 0x0009246C
		[DebuggerNonUserCode]
		public CurrencyData Clone()
		{
			return new CurrencyData(this);
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x06002620 RID: 9760 RVA: 0x00094284 File Offset: 0x00092484
		// (set) Token: 0x06002621 RID: 9761 RVA: 0x000942B5 File Offset: 0x000924B5
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
					currencyTypeDefaultValue = CurrencyData.CurrencyTypeDefaultValue;
				}
				return currencyTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.currencyType_ = value;
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x06002622 RID: 9762 RVA: 0x000942D0 File Offset: 0x000924D0
		[DebuggerNonUserCode]
		public bool HasCurrencyType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002623 RID: 9763 RVA: 0x000942ED File Offset: 0x000924ED
		[DebuggerNonUserCode]
		public void ClearCurrencyType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06002624 RID: 9764 RVA: 0x00094300 File Offset: 0x00092500
		// (set) Token: 0x06002625 RID: 9765 RVA: 0x00094331 File Offset: 0x00092531
		[DebuggerNonUserCode]
		public ulong Count
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong countDefaultValue;
				if (flag)
				{
					countDefaultValue = this.count_;
				}
				else
				{
					countDefaultValue = CurrencyData.CountDefaultValue;
				}
				return countDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.count_ = value;
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06002626 RID: 9766 RVA: 0x0009434C File Offset: 0x0009254C
		[DebuggerNonUserCode]
		public bool HasCount
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002627 RID: 9767 RVA: 0x00094369 File Offset: 0x00092569
		[DebuggerNonUserCode]
		public void ClearCount()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06002628 RID: 9768 RVA: 0x0009437C File Offset: 0x0009257C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CurrencyData);
		}

		// Token: 0x06002629 RID: 9769 RVA: 0x0009439C File Offset: 0x0009259C
		[DebuggerNonUserCode]
		public bool Equals(CurrencyData other)
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
						bool flag5 = this.Count != other.Count;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600262A RID: 9770 RVA: 0x00094410 File Offset: 0x00092610
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasCurrencyType = this.HasCurrencyType;
			if (hasCurrencyType)
			{
				num ^= this.CurrencyType.GetHashCode();
			}
			bool hasCount = this.HasCount;
			if (hasCount)
			{
				num ^= this.Count.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600262B RID: 9771 RVA: 0x00094480 File Offset: 0x00092680
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600262C RID: 9772 RVA: 0x00094498 File Offset: 0x00092698
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600262D RID: 9773 RVA: 0x000944A4 File Offset: 0x000926A4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasCurrencyType = this.HasCurrencyType;
			if (hasCurrencyType)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CurrencyType);
			}
			bool hasCount = this.HasCount;
			if (hasCount)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.Count);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600262E RID: 9774 RVA: 0x00094514 File Offset: 0x00092714
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasCurrencyType = this.HasCurrencyType;
			if (hasCurrencyType)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurrencyType);
			}
			bool hasCount = this.HasCount;
			if (hasCount)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Count);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x00094580 File Offset: 0x00092780
		[DebuggerNonUserCode]
		public void MergeFrom(CurrencyData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasCurrencyType = other.HasCurrencyType;
				if (hasCurrencyType)
				{
					this.CurrencyType = other.CurrencyType;
				}
				bool hasCount = other.HasCount;
				if (hasCount)
				{
					this.Count = other.Count;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002630 RID: 9776 RVA: 0x000945E2 File Offset: 0x000927E2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002631 RID: 9777 RVA: 0x000945F0 File Offset: 0x000927F0
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
						this.Count = input.ReadUInt64();
					}
				}
				else
				{
					this.CurrencyType = input.ReadInt32();
				}
			}
		}

		// Token: 0x040010D9 RID: 4313
		private static readonly MessageParser<CurrencyData> _parser = new MessageParser<CurrencyData>(() => new CurrencyData());

		// Token: 0x040010DA RID: 4314
		private UnknownFieldSet _unknownFields;

		// Token: 0x040010DB RID: 4315
		private int _hasBits0;

		// Token: 0x040010DC RID: 4316
		public const int CurrencyTypeFieldNumber = 1;

		// Token: 0x040010DD RID: 4317
		private static readonly int CurrencyTypeDefaultValue = 0;

		// Token: 0x040010DE RID: 4318
		private int currencyType_;

		// Token: 0x040010DF RID: 4319
		public const int CountFieldNumber = 2;

		// Token: 0x040010E0 RID: 4320
		private static readonly ulong CountDefaultValue = 0UL;

		// Token: 0x040010E1 RID: 4321
		private ulong count_;
	}
}
