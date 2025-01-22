using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x0200032B RID: 811
	public sealed class Item : IMessage<Item>, IMessage, IEquatable<Item>, IDeepCloneable<Item>, IBufferMessage
	{
		// Token: 0x17001B56 RID: 6998
		// (get) Token: 0x060054BB RID: 21691 RVA: 0x00147984 File Offset: 0x00145B84
		[DebuggerNonUserCode]
		public static MessageParser<Item> Parser
		{
			get
			{
				return Item._parser;
			}
		}

		// Token: 0x17001B57 RID: 6999
		// (get) Token: 0x060054BC RID: 21692 RVA: 0x0014799C File Offset: 0x00145B9C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CommonInventoryStateReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001B58 RID: 7000
		// (get) Token: 0x060054BD RID: 21693 RVA: 0x001479C0 File Offset: 0x00145BC0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Item.Descriptor;
			}
		}

		// Token: 0x060054BE RID: 21694 RVA: 0x001479D7 File Offset: 0x00145BD7
		[DebuggerNonUserCode]
		public Item()
		{
		}

		// Token: 0x060054BF RID: 21695 RVA: 0x001479E4 File Offset: 0x00145BE4
		[DebuggerNonUserCode]
		public Item(Item other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.itemCode_ = other.itemCode_;
			this.quality_ = other.quality_;
			this.container_ = other.container_;
			this.equippedSlot_ = other.equippedSlot_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060054C0 RID: 21696 RVA: 0x00147A54 File Offset: 0x00145C54
		[DebuggerNonUserCode]
		public Item Clone()
		{
			return new Item(this);
		}

		// Token: 0x17001B59 RID: 7001
		// (get) Token: 0x060054C1 RID: 21697 RVA: 0x00147A6C File Offset: 0x00145C6C
		// (set) Token: 0x060054C2 RID: 21698 RVA: 0x00147A9D File Offset: 0x00145C9D
		[DebuggerNonUserCode]
		public uint Id
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = Item.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x17001B5A RID: 7002
		// (get) Token: 0x060054C3 RID: 21699 RVA: 0x00147AB8 File Offset: 0x00145CB8
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060054C4 RID: 21700 RVA: 0x00147AD5 File Offset: 0x00145CD5
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001B5B RID: 7003
		// (get) Token: 0x060054C5 RID: 21701 RVA: 0x00147AE8 File Offset: 0x00145CE8
		// (set) Token: 0x060054C6 RID: 21702 RVA: 0x00147B09 File Offset: 0x00145D09
		[DebuggerNonUserCode]
		public string ItemCode
		{
			get
			{
				return this.itemCode_ ?? Item.ItemCodeDefaultValue;
			}
			set
			{
				this.itemCode_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001B5C RID: 7004
		// (get) Token: 0x060054C7 RID: 21703 RVA: 0x00147B20 File Offset: 0x00145D20
		[DebuggerNonUserCode]
		public bool HasItemCode
		{
			get
			{
				return this.itemCode_ != null;
			}
		}

		// Token: 0x060054C8 RID: 21704 RVA: 0x00147B3B File Offset: 0x00145D3B
		[DebuggerNonUserCode]
		public void ClearItemCode()
		{
			this.itemCode_ = null;
		}

		// Token: 0x17001B5D RID: 7005
		// (get) Token: 0x060054C9 RID: 21705 RVA: 0x00147B48 File Offset: 0x00145D48
		// (set) Token: 0x060054CA RID: 21706 RVA: 0x00147B79 File Offset: 0x00145D79
		[DebuggerNonUserCode]
		public Item.Types.Quality Quality
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				Item.Types.Quality qualityDefaultValue;
				if (flag)
				{
					qualityDefaultValue = this.quality_;
				}
				else
				{
					qualityDefaultValue = Item.QualityDefaultValue;
				}
				return qualityDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.quality_ = value;
			}
		}

		// Token: 0x17001B5E RID: 7006
		// (get) Token: 0x060054CB RID: 21707 RVA: 0x00147B94 File Offset: 0x00145D94
		[DebuggerNonUserCode]
		public bool HasQuality
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060054CC RID: 21708 RVA: 0x00147BB1 File Offset: 0x00145DB1
		[DebuggerNonUserCode]
		public void ClearQuality()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001B5F RID: 7007
		// (get) Token: 0x060054CD RID: 21709 RVA: 0x00147BC4 File Offset: 0x00145DC4
		// (set) Token: 0x060054CE RID: 21710 RVA: 0x00147BF5 File Offset: 0x00145DF5
		[DebuggerNonUserCode]
		public Item.Types.Container Container
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				Item.Types.Container containerDefaultValue;
				if (flag)
				{
					containerDefaultValue = this.container_;
				}
				else
				{
					containerDefaultValue = Item.ContainerDefaultValue;
				}
				return containerDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.container_ = value;
			}
		}

		// Token: 0x17001B60 RID: 7008
		// (get) Token: 0x060054CF RID: 21711 RVA: 0x00147C10 File Offset: 0x00145E10
		[DebuggerNonUserCode]
		public bool HasContainer
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060054D0 RID: 21712 RVA: 0x00147C2D File Offset: 0x00145E2D
		[DebuggerNonUserCode]
		public void ClearContainer()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001B61 RID: 7009
		// (get) Token: 0x060054D1 RID: 21713 RVA: 0x00147C40 File Offset: 0x00145E40
		// (set) Token: 0x060054D2 RID: 21714 RVA: 0x00147C71 File Offset: 0x00145E71
		[DebuggerNonUserCode]
		public Item.Types.EquippedSlot EquippedSlot
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				Item.Types.EquippedSlot equippedSlotDefaultValue;
				if (flag)
				{
					equippedSlotDefaultValue = this.equippedSlot_;
				}
				else
				{
					equippedSlotDefaultValue = Item.EquippedSlotDefaultValue;
				}
				return equippedSlotDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.equippedSlot_ = value;
			}
		}

		// Token: 0x17001B62 RID: 7010
		// (get) Token: 0x060054D3 RID: 21715 RVA: 0x00147C8C File Offset: 0x00145E8C
		[DebuggerNonUserCode]
		public bool HasEquippedSlot
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060054D4 RID: 21716 RVA: 0x00147CA9 File Offset: 0x00145EA9
		[DebuggerNonUserCode]
		public void ClearEquippedSlot()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x060054D5 RID: 21717 RVA: 0x00147CBC File Offset: 0x00145EBC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Item);
		}

		// Token: 0x060054D6 RID: 21718 RVA: 0x00147CDC File Offset: 0x00145EDC
		[DebuggerNonUserCode]
		public bool Equals(Item other)
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
					bool flag4 = this.Id != other.Id;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ItemCode != other.ItemCode;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Quality != other.Quality;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Container != other.Container;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.EquippedSlot != other.EquippedSlot;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060054D7 RID: 21719 RVA: 0x00147DA8 File Offset: 0x00145FA8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasItemCode = this.HasItemCode;
			if (hasItemCode)
			{
				num ^= this.ItemCode.GetHashCode();
			}
			bool hasQuality = this.HasQuality;
			if (hasQuality)
			{
				num ^= this.Quality.GetHashCode();
			}
			bool hasContainer = this.HasContainer;
			if (hasContainer)
			{
				num ^= this.Container.GetHashCode();
			}
			bool hasEquippedSlot = this.HasEquippedSlot;
			if (hasEquippedSlot)
			{
				num ^= this.EquippedSlot.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060054D8 RID: 21720 RVA: 0x00147E80 File Offset: 0x00146080
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060054D9 RID: 21721 RVA: 0x00147E98 File Offset: 0x00146098
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060054DA RID: 21722 RVA: 0x00147EA4 File Offset: 0x001460A4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Id);
			}
			bool hasItemCode = this.HasItemCode;
			if (hasItemCode)
			{
				output.WriteRawTag(18);
				output.WriteString(this.ItemCode);
			}
			bool hasQuality = this.HasQuality;
			if (hasQuality)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Quality);
			}
			bool hasContainer = this.HasContainer;
			if (hasContainer)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Container);
			}
			bool hasEquippedSlot = this.HasEquippedSlot;
			if (hasEquippedSlot)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.EquippedSlot);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060054DB RID: 21723 RVA: 0x00147F7C File Offset: 0x0014617C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			bool hasItemCode = this.HasItemCode;
			if (hasItemCode)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ItemCode);
			}
			bool hasQuality = this.HasQuality;
			if (hasQuality)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Quality);
			}
			bool hasContainer = this.HasContainer;
			if (hasContainer)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Container);
			}
			bool hasEquippedSlot = this.HasEquippedSlot;
			if (hasEquippedSlot)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.EquippedSlot);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060054DC RID: 21724 RVA: 0x00148044 File Offset: 0x00146244
		[DebuggerNonUserCode]
		public void MergeFrom(Item other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasItemCode = other.HasItemCode;
				if (hasItemCode)
				{
					this.ItemCode = other.ItemCode;
				}
				bool hasQuality = other.HasQuality;
				if (hasQuality)
				{
					this.Quality = other.Quality;
				}
				bool hasContainer = other.HasContainer;
				if (hasContainer)
				{
					this.Container = other.Container;
				}
				bool hasEquippedSlot = other.HasEquippedSlot;
				if (hasEquippedSlot)
				{
					this.EquippedSlot = other.EquippedSlot;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060054DD RID: 21725 RVA: 0x001480F8 File Offset: 0x001462F8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060054DE RID: 21726 RVA: 0x00148104 File Offset: 0x00146304
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
							goto IL_0032;
						}
						this.ItemCode = input.ReadString();
					}
					else
					{
						this.Id = input.ReadUInt32();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						if (num3 != 40U)
						{
							goto IL_0032;
						}
						this.EquippedSlot = (Item.Types.EquippedSlot)input.ReadEnum();
					}
					else
					{
						this.Container = (Item.Types.Container)input.ReadEnum();
					}
				}
				else
				{
					this.Quality = (Item.Types.Quality)input.ReadEnum();
				}
				continue;
				IL_0032:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002681 RID: 9857
		private static readonly MessageParser<Item> _parser = new MessageParser<Item>(() => new Item());

		// Token: 0x04002682 RID: 9858
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002683 RID: 9859
		private int _hasBits0;

		// Token: 0x04002684 RID: 9860
		public const int IdFieldNumber = 1;

		// Token: 0x04002685 RID: 9861
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x04002686 RID: 9862
		private uint id_;

		// Token: 0x04002687 RID: 9863
		public const int ItemCodeFieldNumber = 2;

		// Token: 0x04002688 RID: 9864
		private static readonly string ItemCodeDefaultValue = "";

		// Token: 0x04002689 RID: 9865
		private string itemCode_;

		// Token: 0x0400268A RID: 9866
		public const int QualityFieldNumber = 3;

		// Token: 0x0400268B RID: 9867
		private static readonly Item.Types.Quality QualityDefaultValue = Item.Types.Quality.Any;

		// Token: 0x0400268C RID: 9868
		private Item.Types.Quality quality_;

		// Token: 0x0400268D RID: 9869
		public const int ContainerFieldNumber = 4;

		// Token: 0x0400268E RID: 9870
		private static readonly Item.Types.Container ContainerDefaultValue = Item.Types.Container.None;

		// Token: 0x0400268F RID: 9871
		private Item.Types.Container container_;

		// Token: 0x04002690 RID: 9872
		public const int EquippedSlotFieldNumber = 5;

		// Token: 0x04002691 RID: 9873
		private static readonly Item.Types.EquippedSlot EquippedSlotDefaultValue = Item.Types.EquippedSlot.Empty;

		// Token: 0x04002692 RID: 9874
		private Item.Types.EquippedSlot equippedSlot_;

		// Token: 0x02000E1E RID: 3614
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x0200148F RID: 5263
			public enum Quality
			{
				// Token: 0x0400A4BC RID: 42172
				[OriginalName("Any")]
				Any,
				// Token: 0x0400A4BD RID: 42173
				[OriginalName("Low")]
				Low,
				// Token: 0x0400A4BE RID: 42174
				[OriginalName("Normal")]
				Normal,
				// Token: 0x0400A4BF RID: 42175
				[OriginalName("High")]
				High,
				// Token: 0x0400A4C0 RID: 42176
				[OriginalName("Magic")]
				Magic,
				// Token: 0x0400A4C1 RID: 42177
				[OriginalName("Set")]
				Set,
				// Token: 0x0400A4C2 RID: 42178
				[OriginalName("Rare")]
				Rare,
				// Token: 0x0400A4C3 RID: 42179
				[OriginalName("Unique")]
				Unique,
				// Token: 0x0400A4C4 RID: 42180
				[OriginalName("Crafted")]
				Crafted,
				// Token: 0x0400A4C5 RID: 42181
				[OriginalName("Tempered")]
				Tempered
			}

			// Token: 0x02001490 RID: 5264
			public enum Container
			{
				// Token: 0x0400A4C7 RID: 42183
				[OriginalName("None")]
				None,
				// Token: 0x0400A4C8 RID: 42184
				[OriginalName("BackPack")]
				BackPack,
				// Token: 0x0400A4C9 RID: 42185
				[OriginalName("Belt")]
				Belt,
				// Token: 0x0400A4CA RID: 42186
				[OriginalName("Body")]
				Body,
				// Token: 0x0400A4CB RID: 42187
				[OriginalName("Hireling")]
				Hireling,
				// Token: 0x0400A4CC RID: 42188
				[OriginalName("PrivateStash")]
				PrivateStash,
				// Token: 0x0400A4CD RID: 42189
				[OriginalName("SharedStash")]
				SharedStash,
				// Token: 0x0400A4CE RID: 42190
				[OriginalName("TransmogrifyBox")]
				TransmogrifyBox,
				// Token: 0x0400A4CF RID: 42191
				[OriginalName("TradeInteraction")]
				TradeInteraction
			}

			// Token: 0x02001491 RID: 5265
			public enum EquippedSlot
			{
				// Token: 0x0400A4D1 RID: 42193
				[OriginalName("Empty")]
				Empty,
				// Token: 0x0400A4D2 RID: 42194
				[OriginalName("Head")]
				Head,
				// Token: 0x0400A4D3 RID: 42195
				[OriginalName("Neck")]
				Neck,
				// Token: 0x0400A4D4 RID: 42196
				[OriginalName("Torso")]
				Torso,
				// Token: 0x0400A4D5 RID: 42197
				[OriginalName("RightArm")]
				RightArm,
				// Token: 0x0400A4D6 RID: 42198
				[OriginalName("LeftArm")]
				LeftArm,
				// Token: 0x0400A4D7 RID: 42199
				[OriginalName("RightHand")]
				RightHand,
				// Token: 0x0400A4D8 RID: 42200
				[OriginalName("LeftHand")]
				LeftHand,
				// Token: 0x0400A4D9 RID: 42201
				[OriginalName("Waist")]
				Waist,
				// Token: 0x0400A4DA RID: 42202
				[OriginalName("Feet")]
				Feet,
				// Token: 0x0400A4DB RID: 42203
				[OriginalName("Gloves")]
				Gloves,
				// Token: 0x0400A4DC RID: 42204
				[OriginalName("RightArmAlternative")]
				RightArmAlternative,
				// Token: 0x0400A4DD RID: 42205
				[OriginalName("LeftArmAlternative")]
				LeftArmAlternative
			}
		}
	}
}
