using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Items
{
	// Token: 0x02000169 RID: 361
	public sealed class TradeItem : IMessage<TradeItem>, IMessage, IEquatable<TradeItem>, IDeepCloneable<TradeItem>, IBufferMessage
	{
		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x0600259D RID: 9629 RVA: 0x00092468 File Offset: 0x00090668
		[DebuggerNonUserCode]
		public static MessageParser<TradeItem> Parser
		{
			get
			{
				return TradeItem._parser;
			}
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x0600259E RID: 9630 RVA: 0x00092480 File Offset: 0x00090680
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ItemsReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x0600259F RID: 9631 RVA: 0x000924A4 File Offset: 0x000906A4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TradeItem.Descriptor;
			}
		}

		// Token: 0x060025A0 RID: 9632 RVA: 0x000924BB File Offset: 0x000906BB
		[DebuggerNonUserCode]
		public TradeItem()
		{
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x000924C8 File Offset: 0x000906C8
		[DebuggerNonUserCode]
		public TradeItem(TradeItem other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.acdNetworkName_ = other.acdNetworkName_;
			this.savedItem_ = ((other.savedItem_ != null) ? other.savedItem_.Clone() : null);
			this.generator_ = ((other.generator_ != null) ? other.generator_.Clone() : null);
			this.quantity_ = other.quantity_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060025A2 RID: 9634 RVA: 0x0009254C File Offset: 0x0009074C
		[DebuggerNonUserCode]
		public TradeItem Clone()
		{
			return new TradeItem(this);
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x060025A3 RID: 9635 RVA: 0x00092564 File Offset: 0x00090764
		// (set) Token: 0x060025A4 RID: 9636 RVA: 0x00092595 File Offset: 0x00090795
		[DebuggerNonUserCode]
		public ulong AcdNetworkName
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong acdNetworkNameDefaultValue;
				if (flag)
				{
					acdNetworkNameDefaultValue = this.acdNetworkName_;
				}
				else
				{
					acdNetworkNameDefaultValue = TradeItem.AcdNetworkNameDefaultValue;
				}
				return acdNetworkNameDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.acdNetworkName_ = value;
			}
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x060025A5 RID: 9637 RVA: 0x000925B0 File Offset: 0x000907B0
		[DebuggerNonUserCode]
		public bool HasAcdNetworkName
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x000925CD File Offset: 0x000907CD
		[DebuggerNonUserCode]
		public void ClearAcdNetworkName()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x060025A7 RID: 9639 RVA: 0x000925E0 File Offset: 0x000907E0
		// (set) Token: 0x060025A8 RID: 9640 RVA: 0x000925F8 File Offset: 0x000907F8
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

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x060025A9 RID: 9641 RVA: 0x00092604 File Offset: 0x00090804
		// (set) Token: 0x060025AA RID: 9642 RVA: 0x0009261C File Offset: 0x0009081C
		[DebuggerNonUserCode]
		public Generator Generator
		{
			get
			{
				return this.generator_;
			}
			set
			{
				this.generator_ = value;
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x060025AB RID: 9643 RVA: 0x00092628 File Offset: 0x00090828
		// (set) Token: 0x060025AC RID: 9644 RVA: 0x00092659 File Offset: 0x00090859
		[DebuggerNonUserCode]
		public ulong Quantity
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
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
				this._hasBits0 |= 2;
				this.quantity_ = value;
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x060025AD RID: 9645 RVA: 0x00092674 File Offset: 0x00090874
		[DebuggerNonUserCode]
		public bool HasQuantity
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060025AE RID: 9646 RVA: 0x00092691 File Offset: 0x00090891
		[DebuggerNonUserCode]
		public void ClearQuantity()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060025AF RID: 9647 RVA: 0x000926A4 File Offset: 0x000908A4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as TradeItem);
		}

		// Token: 0x060025B0 RID: 9648 RVA: 0x000926C4 File Offset: 0x000908C4
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
					bool flag4 = this.AcdNetworkName != other.AcdNetworkName;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.SavedItem, other.SavedItem);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Generator, other.Generator);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Quantity != other.Quantity;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060025B1 RID: 9649 RVA: 0x00092778 File Offset: 0x00090978
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAcdNetworkName = this.HasAcdNetworkName;
			if (hasAcdNetworkName)
			{
				num ^= this.AcdNetworkName.GetHashCode();
			}
			bool flag = this.savedItem_ != null;
			if (flag)
			{
				num ^= this.SavedItem.GetHashCode();
			}
			bool flag2 = this.generator_ != null;
			if (flag2)
			{
				num ^= this.Generator.GetHashCode();
			}
			bool hasQuantity = this.HasQuantity;
			if (hasQuantity)
			{
				num ^= this.Quantity.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060025B2 RID: 9650 RVA: 0x00092820 File Offset: 0x00090A20
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060025B3 RID: 9651 RVA: 0x00092838 File Offset: 0x00090A38
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060025B4 RID: 9652 RVA: 0x00092844 File Offset: 0x00090A44
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAcdNetworkName = this.HasAcdNetworkName;
			if (hasAcdNetworkName)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.AcdNetworkName);
			}
			bool flag = this.savedItem_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.SavedItem);
			}
			bool flag2 = this.generator_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Generator);
			}
			bool hasQuantity = this.HasQuantity;
			if (hasQuantity)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.Quantity);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060025B5 RID: 9653 RVA: 0x00092900 File Offset: 0x00090B00
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAcdNetworkName = this.HasAcdNetworkName;
			if (hasAcdNetworkName)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.AcdNetworkName);
			}
			bool flag = this.savedItem_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SavedItem);
			}
			bool flag2 = this.generator_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Generator);
			}
			bool hasQuantity = this.HasQuantity;
			if (hasQuantity)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Quantity);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060025B6 RID: 9654 RVA: 0x000929B0 File Offset: 0x00090BB0
		[DebuggerNonUserCode]
		public void MergeFrom(TradeItem other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAcdNetworkName = other.HasAcdNetworkName;
				if (hasAcdNetworkName)
				{
					this.AcdNetworkName = other.AcdNetworkName;
				}
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
				bool flag4 = other.generator_ != null;
				if (flag4)
				{
					bool flag5 = this.generator_ == null;
					if (flag5)
					{
						this.Generator = new Generator();
					}
					this.Generator.MergeFrom(other.Generator);
				}
				bool hasQuantity = other.HasQuantity;
				if (hasQuantity)
				{
					this.Quantity = other.Quantity;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060025B7 RID: 9655 RVA: 0x00092A93 File Offset: 0x00090C93
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060025B8 RID: 9656 RVA: 0x00092AA0 File Offset: 0x00090CA0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 8U)
					{
						if (num3 != 18U)
						{
							goto IL_002B;
						}
						bool flag = this.savedItem_ == null;
						if (flag)
						{
							this.SavedItem = new SavedItem();
						}
						input.ReadMessage(this.SavedItem);
					}
					else
					{
						this.AcdNetworkName = input.ReadUInt64();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 32U)
					{
						goto IL_002B;
					}
					this.Quantity = input.ReadUInt64();
				}
				else
				{
					bool flag2 = this.generator_ == null;
					if (flag2)
					{
						this.Generator = new Generator();
					}
					input.ReadMessage(this.Generator);
				}
				continue;
				IL_002B:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040010A0 RID: 4256
		private static readonly MessageParser<TradeItem> _parser = new MessageParser<TradeItem>(() => new TradeItem());

		// Token: 0x040010A1 RID: 4257
		private UnknownFieldSet _unknownFields;

		// Token: 0x040010A2 RID: 4258
		private int _hasBits0;

		// Token: 0x040010A3 RID: 4259
		public const int AcdNetworkNameFieldNumber = 1;

		// Token: 0x040010A4 RID: 4260
		private static readonly ulong AcdNetworkNameDefaultValue = 0UL;

		// Token: 0x040010A5 RID: 4261
		private ulong acdNetworkName_;

		// Token: 0x040010A6 RID: 4262
		public const int SavedItemFieldNumber = 2;

		// Token: 0x040010A7 RID: 4263
		private SavedItem savedItem_;

		// Token: 0x040010A8 RID: 4264
		public const int GeneratorFieldNumber = 3;

		// Token: 0x040010A9 RID: 4265
		private Generator generator_;

		// Token: 0x040010AA RID: 4266
		public const int QuantityFieldNumber = 4;

		// Token: 0x040010AB RID: 4267
		private static readonly ulong QuantityDefaultValue = 0UL;

		// Token: 0x040010AC RID: 4268
		private ulong quantity_;
	}
}
