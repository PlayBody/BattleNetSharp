using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x020001AF RID: 431
	public sealed class TransmogSlot : IMessage<TransmogSlot>, IMessage, IEquatable<TransmogSlot>, IDeepCloneable<TransmogSlot>, IBufferMessage
	{
		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x06002D6F RID: 11631 RVA: 0x000B1EE8 File Offset: 0x000B00E8
		[DebuggerNonUserCode]
		public static MessageParser<TransmogSlot> Parser
		{
			get
			{
				return TransmogSlot._parser;
			}
		}

		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x06002D70 RID: 11632 RVA: 0x000B1F00 File Offset: 0x000B0100
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroCommonReflection.Descriptor.MessageTypes[21];
			}
		}

		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x06002D71 RID: 11633 RVA: 0x000B1F24 File Offset: 0x000B0124
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TransmogSlot.Descriptor;
			}
		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x000B1F3B File Offset: 0x000B013B
		[DebuggerNonUserCode]
		public TransmogSlot()
		{
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x000B1F48 File Offset: 0x000B0148
		[DebuggerNonUserCode]
		public TransmogSlot(TransmogSlot other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.slot_ = other.slot_;
			this.itemSno_ = other.itemSno_;
			this.dyeSno_ = other.dyeSno_;
			this.enabled_ = other.enabled_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002D74 RID: 11636 RVA: 0x000B1FAC File Offset: 0x000B01AC
		[DebuggerNonUserCode]
		public TransmogSlot Clone()
		{
			return new TransmogSlot(this);
		}

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x06002D75 RID: 11637 RVA: 0x000B1FC4 File Offset: 0x000B01C4
		// (set) Token: 0x06002D76 RID: 11638 RVA: 0x000B1FF5 File Offset: 0x000B01F5
		[DebuggerNonUserCode]
		public int Slot
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int slotDefaultValue;
				if (flag)
				{
					slotDefaultValue = this.slot_;
				}
				else
				{
					slotDefaultValue = TransmogSlot.SlotDefaultValue;
				}
				return slotDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.slot_ = value;
			}
		}

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x06002D77 RID: 11639 RVA: 0x000B2010 File Offset: 0x000B0210
		[DebuggerNonUserCode]
		public bool HasSlot
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002D78 RID: 11640 RVA: 0x000B202D File Offset: 0x000B022D
		[DebuggerNonUserCode]
		public void ClearSlot()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x06002D79 RID: 11641 RVA: 0x000B2040 File Offset: 0x000B0240
		// (set) Token: 0x06002D7A RID: 11642 RVA: 0x000B2071 File Offset: 0x000B0271
		[DebuggerNonUserCode]
		public int ItemSno
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int itemSnoDefaultValue;
				if (flag)
				{
					itemSnoDefaultValue = this.itemSno_;
				}
				else
				{
					itemSnoDefaultValue = TransmogSlot.ItemSnoDefaultValue;
				}
				return itemSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.itemSno_ = value;
			}
		}

		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x06002D7B RID: 11643 RVA: 0x000B208C File Offset: 0x000B028C
		[DebuggerNonUserCode]
		public bool HasItemSno
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002D7C RID: 11644 RVA: 0x000B20A9 File Offset: 0x000B02A9
		[DebuggerNonUserCode]
		public void ClearItemSno()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x06002D7D RID: 11645 RVA: 0x000B20BC File Offset: 0x000B02BC
		// (set) Token: 0x06002D7E RID: 11646 RVA: 0x000B20ED File Offset: 0x000B02ED
		[DebuggerNonUserCode]
		public int DyeSno
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int dyeSnoDefaultValue;
				if (flag)
				{
					dyeSnoDefaultValue = this.dyeSno_;
				}
				else
				{
					dyeSnoDefaultValue = TransmogSlot.DyeSnoDefaultValue;
				}
				return dyeSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.dyeSno_ = value;
			}
		}

		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x06002D7F RID: 11647 RVA: 0x000B2108 File Offset: 0x000B0308
		[DebuggerNonUserCode]
		public bool HasDyeSno
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06002D80 RID: 11648 RVA: 0x000B2125 File Offset: 0x000B0325
		[DebuggerNonUserCode]
		public void ClearDyeSno()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x06002D81 RID: 11649 RVA: 0x000B2138 File Offset: 0x000B0338
		// (set) Token: 0x06002D82 RID: 11650 RVA: 0x000B2169 File Offset: 0x000B0369
		[DebuggerNonUserCode]
		public bool Enabled
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool enabledDefaultValue;
				if (flag)
				{
					enabledDefaultValue = this.enabled_;
				}
				else
				{
					enabledDefaultValue = TransmogSlot.EnabledDefaultValue;
				}
				return enabledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.enabled_ = value;
			}
		}

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x06002D83 RID: 11651 RVA: 0x000B2184 File Offset: 0x000B0384
		[DebuggerNonUserCode]
		public bool HasEnabled
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06002D84 RID: 11652 RVA: 0x000B21A1 File Offset: 0x000B03A1
		[DebuggerNonUserCode]
		public void ClearEnabled()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06002D85 RID: 11653 RVA: 0x000B21B4 File Offset: 0x000B03B4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as TransmogSlot);
		}

		// Token: 0x06002D86 RID: 11654 RVA: 0x000B21D4 File Offset: 0x000B03D4
		[DebuggerNonUserCode]
		public bool Equals(TransmogSlot other)
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
					bool flag4 = this.Slot != other.Slot;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ItemSno != other.ItemSno;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.DyeSno != other.DyeSno;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Enabled != other.Enabled;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002D87 RID: 11655 RVA: 0x000B2280 File Offset: 0x000B0480
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSlot = this.HasSlot;
			if (hasSlot)
			{
				num ^= this.Slot.GetHashCode();
			}
			bool hasItemSno = this.HasItemSno;
			if (hasItemSno)
			{
				num ^= this.ItemSno.GetHashCode();
			}
			bool hasDyeSno = this.HasDyeSno;
			if (hasDyeSno)
			{
				num ^= this.DyeSno.GetHashCode();
			}
			bool hasEnabled = this.HasEnabled;
			if (hasEnabled)
			{
				num ^= this.Enabled.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002D88 RID: 11656 RVA: 0x000B2328 File Offset: 0x000B0528
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002D89 RID: 11657 RVA: 0x000B2340 File Offset: 0x000B0540
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002D8A RID: 11658 RVA: 0x000B234C File Offset: 0x000B054C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSlot = this.HasSlot;
			if (hasSlot)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Slot);
			}
			bool hasItemSno = this.HasItemSno;
			if (hasItemSno)
			{
				output.WriteRawTag(21);
				output.WriteSFixed32(this.ItemSno);
			}
			bool hasDyeSno = this.HasDyeSno;
			if (hasDyeSno)
			{
				output.WriteRawTag(29);
				output.WriteSFixed32(this.DyeSno);
			}
			bool hasEnabled = this.HasEnabled;
			if (hasEnabled)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.Enabled);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002D8B RID: 11659 RVA: 0x000B2400 File Offset: 0x000B0600
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSlot = this.HasSlot;
			if (hasSlot)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Slot);
			}
			bool hasItemSno = this.HasItemSno;
			if (hasItemSno)
			{
				num += 5;
			}
			bool hasDyeSno = this.HasDyeSno;
			if (hasDyeSno)
			{
				num += 5;
			}
			bool hasEnabled = this.HasEnabled;
			if (hasEnabled)
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

		// Token: 0x06002D8C RID: 11660 RVA: 0x000B2484 File Offset: 0x000B0684
		[DebuggerNonUserCode]
		public void MergeFrom(TransmogSlot other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSlot = other.HasSlot;
				if (hasSlot)
				{
					this.Slot = other.Slot;
				}
				bool hasItemSno = other.HasItemSno;
				if (hasItemSno)
				{
					this.ItemSno = other.ItemSno;
				}
				bool hasDyeSno = other.HasDyeSno;
				if (hasDyeSno)
				{
					this.DyeSno = other.DyeSno;
				}
				bool hasEnabled = other.HasEnabled;
				if (hasEnabled)
				{
					this.Enabled = other.Enabled;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002D8D RID: 11661 RVA: 0x000B251A File Offset: 0x000B071A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002D8E RID: 11662 RVA: 0x000B2528 File Offset: 0x000B0728
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 21U)
				{
					if (num3 != 8U)
					{
						if (num3 != 21U)
						{
							goto IL_0028;
						}
						this.ItemSno = input.ReadSFixed32();
					}
					else
					{
						this.Slot = input.ReadInt32();
					}
				}
				else if (num3 != 29U)
				{
					if (num3 != 32U)
					{
						goto IL_0028;
					}
					this.Enabled = input.ReadBool();
				}
				else
				{
					this.DyeSno = input.ReadSFixed32();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001480 RID: 5248
		private static readonly MessageParser<TransmogSlot> _parser = new MessageParser<TransmogSlot>(() => new TransmogSlot());

		// Token: 0x04001481 RID: 5249
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001482 RID: 5250
		private int _hasBits0;

		// Token: 0x04001483 RID: 5251
		public const int SlotFieldNumber = 1;

		// Token: 0x04001484 RID: 5252
		private static readonly int SlotDefaultValue = 0;

		// Token: 0x04001485 RID: 5253
		private int slot_;

		// Token: 0x04001486 RID: 5254
		public const int ItemSnoFieldNumber = 2;

		// Token: 0x04001487 RID: 5255
		private static readonly int ItemSnoDefaultValue = -1;

		// Token: 0x04001488 RID: 5256
		private int itemSno_;

		// Token: 0x04001489 RID: 5257
		public const int DyeSnoFieldNumber = 3;

		// Token: 0x0400148A RID: 5258
		private static readonly int DyeSnoDefaultValue = -1;

		// Token: 0x0400148B RID: 5259
		private int dyeSno_;

		// Token: 0x0400148C RID: 5260
		public const int EnabledFieldNumber = 4;

		// Token: 0x0400148D RID: 5261
		private static readonly bool EnabledDefaultValue = true;

		// Token: 0x0400148E RID: 5262
		private bool enabled_;
	}
}
