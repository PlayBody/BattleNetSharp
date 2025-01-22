using System;
using System.Diagnostics;
using Fenris.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Trade
{
	// Token: 0x02000109 RID: 265
	public sealed class TradeItem : IMessage<TradeItem>, IMessage, IEquatable<TradeItem>, IDeepCloneable<TradeItem>, IBufferMessage
	{
		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06001943 RID: 6467 RVA: 0x00059E3C File Offset: 0x0005803C
		[DebuggerNonUserCode]
		public static MessageParser<TradeItem> Parser
		{
			get
			{
				return TradeItem._parser;
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06001944 RID: 6468 RVA: 0x00059E54 File Offset: 0x00058054
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TradeReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06001945 RID: 6469 RVA: 0x00059E78 File Offset: 0x00058078
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TradeItem.Descriptor;
			}
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x00059E8F File Offset: 0x0005808F
		[DebuggerNonUserCode]
		public TradeItem()
		{
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x00059E9C File Offset: 0x0005809C
		[DebuggerNonUserCode]
		public TradeItem(TradeItem other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.savedItem_ = ((other.savedItem_ != null) ? other.savedItem_.Clone() : null);
			this.quantity_ = other.quantity_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x00059EF8 File Offset: 0x000580F8
		[DebuggerNonUserCode]
		public TradeItem Clone()
		{
			return new TradeItem(this);
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06001949 RID: 6473 RVA: 0x00059F10 File Offset: 0x00058110
		// (set) Token: 0x0600194A RID: 6474 RVA: 0x00059F28 File Offset: 0x00058128
		[DebuggerNonUserCode]
		public SavedItem SavedItem
		{
			get
			{
				return this.savedItem_;
			}
			set
			{
				this.savedItem_ = value;
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x0600194B RID: 6475 RVA: 0x00059F34 File Offset: 0x00058134
		// (set) Token: 0x0600194C RID: 6476 RVA: 0x00059F65 File Offset: 0x00058165
		[DebuggerNonUserCode]
		public ulong Quantity
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong quantityDefaultValue;
				if (flag)
				{
					quantityDefaultValue = this.quantity_;
				}
				else
				{
					quantityDefaultValue = TradeItem.QuantityDefaultValue;
				}
				return quantityDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.quantity_ = value;
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x0600194D RID: 6477 RVA: 0x00059F80 File Offset: 0x00058180
		[DebuggerNonUserCode]
		public bool HasQuantity
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x00059F9D File Offset: 0x0005819D
		[DebuggerNonUserCode]
		public void ClearQuantity()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x00059FB0 File Offset: 0x000581B0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as TradeItem);
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x00059FD0 File Offset: 0x000581D0
		[DebuggerNonUserCode]
		public bool Equals(TradeItem other)
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
					bool flag4 = !object.Equals(this.SavedItem, other.SavedItem);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Quantity != other.Quantity;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x0005A044 File Offset: 0x00058244
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.savedItem_ != null;
			if (flag)
			{
				num ^= this.SavedItem.GetHashCode();
			}
			bool hasQuantity = this.HasQuantity;
			if (hasQuantity)
			{
				num ^= this.Quantity.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x0005A0B0 File Offset: 0x000582B0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x0005A0C8 File Offset: 0x000582C8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x0005A0D4 File Offset: 0x000582D4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.savedItem_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SavedItem);
			}
			bool hasQuantity = this.HasQuantity;
			if (hasQuantity)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.Quantity);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x0005A148 File Offset: 0x00058348
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.savedItem_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SavedItem);
			}
			bool hasQuantity = this.HasQuantity;
			if (hasQuantity)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Quantity);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x0005A1B8 File Offset: 0x000583B8
		[DebuggerNonUserCode]
		public void MergeFrom(TradeItem other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.savedItem_ != null;
				if (flag2)
				{
					bool flag3 = this.savedItem_ == null;
					if (flag3)
					{
						this.SavedItem = new SavedItem();
					}
					this.SavedItem.MergeFrom(other.SavedItem);
				}
				bool hasQuantity = other.HasQuantity;
				if (hasQuantity)
				{
					this.Quantity = other.Quantity;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x0005A23D File Offset: 0x0005843D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x0005A248 File Offset: 0x00058448
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
						this.Quantity = input.ReadUInt64();
					}
				}
				else
				{
					bool flag = this.savedItem_ == null;
					if (flag)
					{
						this.SavedItem = new SavedItem();
					}
					input.ReadMessage(this.SavedItem);
				}
			}
		}

		// Token: 0x04000A0A RID: 2570
		private static readonly MessageParser<TradeItem> _parser = new MessageParser<TradeItem>(() => new TradeItem());

		// Token: 0x04000A0B RID: 2571
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A0C RID: 2572
		private int _hasBits0;

		// Token: 0x04000A0D RID: 2573
		public const int SavedItemFieldNumber = 1;

		// Token: 0x04000A0E RID: 2574
		private SavedItem savedItem_;

		// Token: 0x04000A0F RID: 2575
		public const int QuantityFieldNumber = 2;

		// Token: 0x04000A10 RID: 2576
		private static readonly ulong QuantityDefaultValue = 0UL;

		// Token: 0x04000A11 RID: 2577
		private ulong quantity_;
	}
}
