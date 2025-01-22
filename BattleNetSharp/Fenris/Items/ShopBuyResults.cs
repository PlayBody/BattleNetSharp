using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Items
{
	// Token: 0x0200016F RID: 367
	public sealed class ShopBuyResults : IMessage<ShopBuyResults>, IMessage, IEquatable<ShopBuyResults>, IDeepCloneable<ShopBuyResults>, IBufferMessage
	{
		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x06002645 RID: 9797 RVA: 0x0009497C File Offset: 0x00092B7C
		[DebuggerNonUserCode]
		public static MessageParser<ShopBuyResults> Parser
		{
			get
			{
				return ShopBuyResults._parser;
			}
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x06002646 RID: 9798 RVA: 0x00094994 File Offset: 0x00092B94
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ItemsReflection.Descriptor.MessageTypes[16];
			}
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x06002647 RID: 9799 RVA: 0x000949B8 File Offset: 0x00092BB8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShopBuyResults.Descriptor;
			}
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x000949CF File Offset: 0x00092BCF
		[DebuggerNonUserCode]
		public ShopBuyResults()
		{
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x000949DC File Offset: 0x00092BDC
		[DebuggerNonUserCode]
		public ShopBuyResults(ShopBuyResults other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.buyback_ = other.buyback_;
			this.gambled_ = other.gambled_;
			this.item_ = ((other.item_ != null) ? other.item_.Clone() : null);
			this.acdNetworkName_ = other.acdNetworkName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600264A RID: 9802 RVA: 0x00094A50 File Offset: 0x00092C50
		[DebuggerNonUserCode]
		public ShopBuyResults Clone()
		{
			return new ShopBuyResults(this);
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x0600264B RID: 9803 RVA: 0x00094A68 File Offset: 0x00092C68
		// (set) Token: 0x0600264C RID: 9804 RVA: 0x00094A99 File Offset: 0x00092C99
		[DebuggerNonUserCode]
		public bool Buyback
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool buybackDefaultValue;
				if (flag)
				{
					buybackDefaultValue = this.buyback_;
				}
				else
				{
					buybackDefaultValue = ShopBuyResults.BuybackDefaultValue;
				}
				return buybackDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.buyback_ = value;
			}
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x0600264D RID: 9805 RVA: 0x00094AB4 File Offset: 0x00092CB4
		[DebuggerNonUserCode]
		public bool HasBuyback
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600264E RID: 9806 RVA: 0x00094AD1 File Offset: 0x00092CD1
		[DebuggerNonUserCode]
		public void ClearBuyback()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x0600264F RID: 9807 RVA: 0x00094AE4 File Offset: 0x00092CE4
		// (set) Token: 0x06002650 RID: 9808 RVA: 0x00094B15 File Offset: 0x00092D15
		[DebuggerNonUserCode]
		public bool Gambled
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool gambledDefaultValue;
				if (flag)
				{
					gambledDefaultValue = this.gambled_;
				}
				else
				{
					gambledDefaultValue = ShopBuyResults.GambledDefaultValue;
				}
				return gambledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.gambled_ = value;
			}
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x06002651 RID: 9809 RVA: 0x00094B30 File Offset: 0x00092D30
		[DebuggerNonUserCode]
		public bool HasGambled
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002652 RID: 9810 RVA: 0x00094B4D File Offset: 0x00092D4D
		[DebuggerNonUserCode]
		public void ClearGambled()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x06002653 RID: 9811 RVA: 0x00094B60 File Offset: 0x00092D60
		// (set) Token: 0x06002654 RID: 9812 RVA: 0x00094B78 File Offset: 0x00092D78
		[DebuggerNonUserCode]
		public Generator Item
		{
			get
			{
				return this.item_;
			}
			set
			{
				this.item_ = value;
			}
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x06002655 RID: 9813 RVA: 0x00094B84 File Offset: 0x00092D84
		// (set) Token: 0x06002656 RID: 9814 RVA: 0x00094BB5 File Offset: 0x00092DB5
		[DebuggerNonUserCode]
		public ulong AcdNetworkName
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong acdNetworkNameDefaultValue;
				if (flag)
				{
					acdNetworkNameDefaultValue = this.acdNetworkName_;
				}
				else
				{
					acdNetworkNameDefaultValue = ShopBuyResults.AcdNetworkNameDefaultValue;
				}
				return acdNetworkNameDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.acdNetworkName_ = value;
			}
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x06002657 RID: 9815 RVA: 0x00094BD0 File Offset: 0x00092DD0
		[DebuggerNonUserCode]
		public bool HasAcdNetworkName
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06002658 RID: 9816 RVA: 0x00094BED File Offset: 0x00092DED
		[DebuggerNonUserCode]
		public void ClearAcdNetworkName()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06002659 RID: 9817 RVA: 0x00094C00 File Offset: 0x00092E00
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShopBuyResults);
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x00094C20 File Offset: 0x00092E20
		[DebuggerNonUserCode]
		public bool Equals(ShopBuyResults other)
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
					bool flag4 = this.Buyback != other.Buyback;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Gambled != other.Gambled;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Item, other.Item);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.AcdNetworkName != other.AcdNetworkName;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x00094CD0 File Offset: 0x00092ED0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasBuyback = this.HasBuyback;
			if (hasBuyback)
			{
				num ^= this.Buyback.GetHashCode();
			}
			bool hasGambled = this.HasGambled;
			if (hasGambled)
			{
				num ^= this.Gambled.GetHashCode();
			}
			bool flag = this.item_ != null;
			if (flag)
			{
				num ^= this.Item.GetHashCode();
			}
			bool hasAcdNetworkName = this.HasAcdNetworkName;
			if (hasAcdNetworkName)
			{
				num ^= this.AcdNetworkName.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600265C RID: 9820 RVA: 0x00094D78 File Offset: 0x00092F78
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600265D RID: 9821 RVA: 0x00094D90 File Offset: 0x00092F90
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600265E RID: 9822 RVA: 0x00094D9C File Offset: 0x00092F9C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasBuyback = this.HasBuyback;
			if (hasBuyback)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Buyback);
			}
			bool hasGambled = this.HasGambled;
			if (hasGambled)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Gambled);
			}
			bool flag = this.item_ != null;
			if (flag)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Item);
			}
			bool hasAcdNetworkName = this.HasAcdNetworkName;
			if (hasAcdNetworkName)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.AcdNetworkName);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600265F RID: 9823 RVA: 0x00094E54 File Offset: 0x00093054
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasBuyback = this.HasBuyback;
			if (hasBuyback)
			{
				num += 2;
			}
			bool hasGambled = this.HasGambled;
			if (hasGambled)
			{
				num += 2;
			}
			bool flag = this.item_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Item);
			}
			bool hasAcdNetworkName = this.HasAcdNetworkName;
			if (hasAcdNetworkName)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.AcdNetworkName);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002660 RID: 9824 RVA: 0x00094EE8 File Offset: 0x000930E8
		[DebuggerNonUserCode]
		public void MergeFrom(ShopBuyResults other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasBuyback = other.HasBuyback;
				if (hasBuyback)
				{
					this.Buyback = other.Buyback;
				}
				bool hasGambled = other.HasGambled;
				if (hasGambled)
				{
					this.Gambled = other.Gambled;
				}
				bool flag2 = other.item_ != null;
				if (flag2)
				{
					bool flag3 = this.item_ == null;
					if (flag3)
					{
						this.Item = new Generator();
					}
					this.Item.MergeFrom(other.Item);
				}
				bool hasAcdNetworkName = other.HasAcdNetworkName;
				if (hasAcdNetworkName)
				{
					this.AcdNetworkName = other.AcdNetworkName;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002661 RID: 9825 RVA: 0x00094FA6 File Offset: 0x000931A6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002662 RID: 9826 RVA: 0x00094FB4 File Offset: 0x000931B4
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
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							goto IL_002B;
						}
						this.Gambled = input.ReadBool();
					}
					else
					{
						this.Buyback = input.ReadBool();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 32U)
					{
						goto IL_002B;
					}
					this.AcdNetworkName = input.ReadUInt64();
				}
				else
				{
					bool flag = this.item_ == null;
					if (flag)
					{
						this.Item = new Generator();
					}
					input.ReadMessage(this.Item);
				}
				continue;
				IL_002B:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040010E7 RID: 4327
		private static readonly MessageParser<ShopBuyResults> _parser = new MessageParser<ShopBuyResults>(() => new ShopBuyResults());

		// Token: 0x040010E8 RID: 4328
		private UnknownFieldSet _unknownFields;

		// Token: 0x040010E9 RID: 4329
		private int _hasBits0;

		// Token: 0x040010EA RID: 4330
		public const int BuybackFieldNumber = 1;

		// Token: 0x040010EB RID: 4331
		private static readonly bool BuybackDefaultValue = false;

		// Token: 0x040010EC RID: 4332
		private bool buyback_;

		// Token: 0x040010ED RID: 4333
		public const int GambledFieldNumber = 2;

		// Token: 0x040010EE RID: 4334
		private static readonly bool GambledDefaultValue = false;

		// Token: 0x040010EF RID: 4335
		private bool gambled_;

		// Token: 0x040010F0 RID: 4336
		public const int ItemFieldNumber = 3;

		// Token: 0x040010F1 RID: 4337
		private Generator item_;

		// Token: 0x040010F2 RID: 4338
		public const int AcdNetworkNameFieldNumber = 4;

		// Token: 0x040010F3 RID: 4339
		private static readonly ulong AcdNetworkNameDefaultValue = 0UL;

		// Token: 0x040010F4 RID: 4340
		private ulong acdNetworkName_;
	}
}
