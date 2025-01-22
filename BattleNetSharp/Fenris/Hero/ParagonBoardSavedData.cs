using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x020001B3 RID: 435
	public sealed class ParagonBoardSavedData : IMessage<ParagonBoardSavedData>, IMessage, IEquatable<ParagonBoardSavedData>, IDeepCloneable<ParagonBoardSavedData>, IBufferMessage
	{
		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x06002DD8 RID: 11736 RVA: 0x000B3508 File Offset: 0x000B1708
		[DebuggerNonUserCode]
		public static MessageParser<ParagonBoardSavedData> Parser
		{
			get
			{
				return ParagonBoardSavedData._parser;
			}
		}

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x06002DD9 RID: 11737 RVA: 0x000B3520 File Offset: 0x000B1720
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroCommonReflection.Descriptor.MessageTypes[25];
			}
		}

		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x06002DDA RID: 11738 RVA: 0x000B3544 File Offset: 0x000B1744
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParagonBoardSavedData.Descriptor;
			}
		}

		// Token: 0x06002DDB RID: 11739 RVA: 0x000B355B File Offset: 0x000B175B
		[DebuggerNonUserCode]
		public ParagonBoardSavedData()
		{
		}

		// Token: 0x06002DDC RID: 11740 RVA: 0x000B3594 File Offset: 0x000B1794
		[DebuggerNonUserCode]
		public ParagonBoardSavedData(ParagonBoardSavedData other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.purchasedNodesBitfield_ = other.purchasedNodesBitfield_;
			this.lastPurchasedNodeIndex_ = other.lastPurchasedNodeIndex_;
			this.socketedGlyphSnos_ = other.socketedGlyphSnos_.Clone();
			this.equippedBoardSnos_ = other.equippedBoardSnos_.Clone();
			this.equippedBoardRotationBitfield_ = other.equippedBoardRotationBitfield_;
			this.equippedBoardGateNodeIndexes_ = other.equippedBoardGateNodeIndexes_.Clone();
			this.boardEquipIndexes_ = other.boardEquipIndexes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002DDD RID: 11741 RVA: 0x000B3630 File Offset: 0x000B1830
		[DebuggerNonUserCode]
		public ParagonBoardSavedData Clone()
		{
			return new ParagonBoardSavedData(this);
		}

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x06002DDE RID: 11742 RVA: 0x000B3648 File Offset: 0x000B1848
		// (set) Token: 0x06002DDF RID: 11743 RVA: 0x000B3669 File Offset: 0x000B1869
		[DebuggerNonUserCode]
		public ByteString PurchasedNodesBitfield
		{
			get
			{
				return this.purchasedNodesBitfield_ ?? ParagonBoardSavedData.PurchasedNodesBitfieldDefaultValue;
			}
			set
			{
				this.purchasedNodesBitfield_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x06002DE0 RID: 11744 RVA: 0x000B3680 File Offset: 0x000B1880
		[DebuggerNonUserCode]
		public bool HasPurchasedNodesBitfield
		{
			get
			{
				return this.purchasedNodesBitfield_ != null;
			}
		}

		// Token: 0x06002DE1 RID: 11745 RVA: 0x000B369E File Offset: 0x000B189E
		[DebuggerNonUserCode]
		public void ClearPurchasedNodesBitfield()
		{
			this.purchasedNodesBitfield_ = null;
		}

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x06002DE2 RID: 11746 RVA: 0x000B36A8 File Offset: 0x000B18A8
		// (set) Token: 0x06002DE3 RID: 11747 RVA: 0x000B36D9 File Offset: 0x000B18D9
		[DebuggerNonUserCode]
		public uint LastPurchasedNodeIndex
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint lastPurchasedNodeIndexDefaultValue;
				if (flag)
				{
					lastPurchasedNodeIndexDefaultValue = this.lastPurchasedNodeIndex_;
				}
				else
				{
					lastPurchasedNodeIndexDefaultValue = ParagonBoardSavedData.LastPurchasedNodeIndexDefaultValue;
				}
				return lastPurchasedNodeIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.lastPurchasedNodeIndex_ = value;
			}
		}

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x06002DE4 RID: 11748 RVA: 0x000B36F4 File Offset: 0x000B18F4
		[DebuggerNonUserCode]
		public bool HasLastPurchasedNodeIndex
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002DE5 RID: 11749 RVA: 0x000B3711 File Offset: 0x000B1911
		[DebuggerNonUserCode]
		public void ClearLastPurchasedNodeIndex()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x06002DE6 RID: 11750 RVA: 0x000B3724 File Offset: 0x000B1924
		[DebuggerNonUserCode]
		public RepeatedField<int> SocketedGlyphSnos
		{
			get
			{
				return this.socketedGlyphSnos_;
			}
		}

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x06002DE7 RID: 11751 RVA: 0x000B373C File Offset: 0x000B193C
		[DebuggerNonUserCode]
		public RepeatedField<int> EquippedBoardSnos
		{
			get
			{
				return this.equippedBoardSnos_;
			}
		}

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x06002DE8 RID: 11752 RVA: 0x000B3754 File Offset: 0x000B1954
		// (set) Token: 0x06002DE9 RID: 11753 RVA: 0x000B3775 File Offset: 0x000B1975
		[DebuggerNonUserCode]
		public ByteString EquippedBoardRotationBitfield
		{
			get
			{
				return this.equippedBoardRotationBitfield_ ?? ParagonBoardSavedData.EquippedBoardRotationBitfieldDefaultValue;
			}
			set
			{
				this.equippedBoardRotationBitfield_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x06002DEA RID: 11754 RVA: 0x000B378C File Offset: 0x000B198C
		[DebuggerNonUserCode]
		public bool HasEquippedBoardRotationBitfield
		{
			get
			{
				return this.equippedBoardRotationBitfield_ != null;
			}
		}

		// Token: 0x06002DEB RID: 11755 RVA: 0x000B37AA File Offset: 0x000B19AA
		[DebuggerNonUserCode]
		public void ClearEquippedBoardRotationBitfield()
		{
			this.equippedBoardRotationBitfield_ = null;
		}

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x06002DEC RID: 11756 RVA: 0x000B37B4 File Offset: 0x000B19B4
		[DebuggerNonUserCode]
		public RepeatedField<uint> EquippedBoardGateNodeIndexes
		{
			get
			{
				return this.equippedBoardGateNodeIndexes_;
			}
		}

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x06002DED RID: 11757 RVA: 0x000B37CC File Offset: 0x000B19CC
		[DebuggerNonUserCode]
		public RepeatedField<uint> BoardEquipIndexes
		{
			get
			{
				return this.boardEquipIndexes_;
			}
		}

		// Token: 0x06002DEE RID: 11758 RVA: 0x000B37E4 File Offset: 0x000B19E4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParagonBoardSavedData);
		}

		// Token: 0x06002DEF RID: 11759 RVA: 0x000B3804 File Offset: 0x000B1A04
		[DebuggerNonUserCode]
		public bool Equals(ParagonBoardSavedData other)
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
					bool flag4 = this.PurchasedNodesBitfield != other.PurchasedNodesBitfield;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.LastPurchasedNodeIndex != other.LastPurchasedNodeIndex;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.socketedGlyphSnos_.Equals(other.socketedGlyphSnos_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.equippedBoardSnos_.Equals(other.equippedBoardSnos_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.EquippedBoardRotationBitfield != other.EquippedBoardRotationBitfield;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !this.equippedBoardGateNodeIndexes_.Equals(other.equippedBoardGateNodeIndexes_);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !this.boardEquipIndexes_.Equals(other.boardEquipIndexes_);
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

		// Token: 0x06002DF0 RID: 11760 RVA: 0x000B3918 File Offset: 0x000B1B18
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPurchasedNodesBitfield = this.HasPurchasedNodesBitfield;
			if (hasPurchasedNodesBitfield)
			{
				num ^= this.PurchasedNodesBitfield.GetHashCode();
			}
			bool hasLastPurchasedNodeIndex = this.HasLastPurchasedNodeIndex;
			if (hasLastPurchasedNodeIndex)
			{
				num ^= this.LastPurchasedNodeIndex.GetHashCode();
			}
			num ^= this.socketedGlyphSnos_.GetHashCode();
			num ^= this.equippedBoardSnos_.GetHashCode();
			bool hasEquippedBoardRotationBitfield = this.HasEquippedBoardRotationBitfield;
			if (hasEquippedBoardRotationBitfield)
			{
				num ^= this.EquippedBoardRotationBitfield.GetHashCode();
			}
			num ^= this.equippedBoardGateNodeIndexes_.GetHashCode();
			num ^= this.boardEquipIndexes_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002DF1 RID: 11761 RVA: 0x000B39D4 File Offset: 0x000B1BD4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002DF2 RID: 11762 RVA: 0x000B39EC File Offset: 0x000B1BEC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002DF3 RID: 11763 RVA: 0x000B39F8 File Offset: 0x000B1BF8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPurchasedNodesBitfield = this.HasPurchasedNodesBitfield;
			if (hasPurchasedNodesBitfield)
			{
				output.WriteRawTag(10);
				output.WriteBytes(this.PurchasedNodesBitfield);
			}
			bool hasLastPurchasedNodeIndex = this.HasLastPurchasedNodeIndex;
			if (hasLastPurchasedNodeIndex)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.LastPurchasedNodeIndex);
			}
			this.socketedGlyphSnos_.WriteTo(ref output, ParagonBoardSavedData._repeated_socketedGlyphSnos_codec);
			this.equippedBoardSnos_.WriteTo(ref output, ParagonBoardSavedData._repeated_equippedBoardSnos_codec);
			bool hasEquippedBoardRotationBitfield = this.HasEquippedBoardRotationBitfield;
			if (hasEquippedBoardRotationBitfield)
			{
				output.WriteRawTag(42);
				output.WriteBytes(this.EquippedBoardRotationBitfield);
			}
			this.equippedBoardGateNodeIndexes_.WriteTo(ref output, ParagonBoardSavedData._repeated_equippedBoardGateNodeIndexes_codec);
			this.boardEquipIndexes_.WriteTo(ref output, ParagonBoardSavedData._repeated_boardEquipIndexes_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002DF4 RID: 11764 RVA: 0x000B3AD0 File Offset: 0x000B1CD0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPurchasedNodesBitfield = this.HasPurchasedNodesBitfield;
			if (hasPurchasedNodesBitfield)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.PurchasedNodesBitfield);
			}
			bool hasLastPurchasedNodeIndex = this.HasLastPurchasedNodeIndex;
			if (hasLastPurchasedNodeIndex)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LastPurchasedNodeIndex);
			}
			num += this.socketedGlyphSnos_.CalculateSize(ParagonBoardSavedData._repeated_socketedGlyphSnos_codec);
			num += this.equippedBoardSnos_.CalculateSize(ParagonBoardSavedData._repeated_equippedBoardSnos_codec);
			bool hasEquippedBoardRotationBitfield = this.HasEquippedBoardRotationBitfield;
			if (hasEquippedBoardRotationBitfield)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.EquippedBoardRotationBitfield);
			}
			num += this.equippedBoardGateNodeIndexes_.CalculateSize(ParagonBoardSavedData._repeated_equippedBoardGateNodeIndexes_codec);
			num += this.boardEquipIndexes_.CalculateSize(ParagonBoardSavedData._repeated_boardEquipIndexes_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002DF5 RID: 11765 RVA: 0x000B3BA8 File Offset: 0x000B1DA8
		[DebuggerNonUserCode]
		public void MergeFrom(ParagonBoardSavedData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPurchasedNodesBitfield = other.HasPurchasedNodesBitfield;
				if (hasPurchasedNodesBitfield)
				{
					this.PurchasedNodesBitfield = other.PurchasedNodesBitfield;
				}
				bool hasLastPurchasedNodeIndex = other.HasLastPurchasedNodeIndex;
				if (hasLastPurchasedNodeIndex)
				{
					this.LastPurchasedNodeIndex = other.LastPurchasedNodeIndex;
				}
				this.socketedGlyphSnos_.Add(other.socketedGlyphSnos_);
				this.equippedBoardSnos_.Add(other.equippedBoardSnos_);
				bool hasEquippedBoardRotationBitfield = other.HasEquippedBoardRotationBitfield;
				if (hasEquippedBoardRotationBitfield)
				{
					this.EquippedBoardRotationBitfield = other.EquippedBoardRotationBitfield;
				}
				this.equippedBoardGateNodeIndexes_.Add(other.equippedBoardGateNodeIndexes_);
				this.boardEquipIndexes_.Add(other.boardEquipIndexes_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002DF6 RID: 11766 RVA: 0x000B3C6E File Offset: 0x000B1E6E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002DF7 RID: 11767 RVA: 0x000B3C7C File Offset: 0x000B1E7C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 34U)
				{
					if (num3 <= 16U)
					{
						if (num3 != 10U)
						{
							if (num3 != 16U)
							{
								goto IL_0088;
							}
							this.LastPurchasedNodeIndex = input.ReadUInt32();
						}
						else
						{
							this.PurchasedNodesBitfield = input.ReadBytes();
						}
					}
					else if (num3 != 26U && num3 != 29U)
					{
						if (num3 != 34U)
						{
							goto IL_0088;
						}
						goto IL_00D4;
					}
					else
					{
						this.socketedGlyphSnos_.AddEntriesFrom(ref input, ParagonBoardSavedData._repeated_socketedGlyphSnos_codec);
					}
				}
				else
				{
					if (num3 <= 48U)
					{
						if (num3 == 37U)
						{
							goto IL_00D4;
						}
						if (num3 == 42U)
						{
							this.EquippedBoardRotationBitfield = input.ReadBytes();
							continue;
						}
						if (num3 != 48U)
						{
							goto IL_0088;
						}
					}
					else if (num3 != 50U)
					{
						if (num3 != 56U && num3 != 58U)
						{
							goto IL_0088;
						}
						this.boardEquipIndexes_.AddEntriesFrom(ref input, ParagonBoardSavedData._repeated_boardEquipIndexes_codec);
						continue;
					}
					this.equippedBoardGateNodeIndexes_.AddEntriesFrom(ref input, ParagonBoardSavedData._repeated_equippedBoardGateNodeIndexes_codec);
				}
				continue;
				IL_0088:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_00D4:
				this.equippedBoardSnos_.AddEntriesFrom(ref input, ParagonBoardSavedData._repeated_equippedBoardSnos_codec);
			}
		}

		// Token: 0x040014AE RID: 5294
		private static readonly MessageParser<ParagonBoardSavedData> _parser = new MessageParser<ParagonBoardSavedData>(() => new ParagonBoardSavedData());

		// Token: 0x040014AF RID: 5295
		private UnknownFieldSet _unknownFields;

		// Token: 0x040014B0 RID: 5296
		private int _hasBits0;

		// Token: 0x040014B1 RID: 5297
		public const int PurchasedNodesBitfieldFieldNumber = 1;

		// Token: 0x040014B2 RID: 5298
		private static readonly ByteString PurchasedNodesBitfieldDefaultValue = ByteString.Empty;

		// Token: 0x040014B3 RID: 5299
		private ByteString purchasedNodesBitfield_;

		// Token: 0x040014B4 RID: 5300
		public const int LastPurchasedNodeIndexFieldNumber = 2;

		// Token: 0x040014B5 RID: 5301
		private static readonly uint LastPurchasedNodeIndexDefaultValue = 0U;

		// Token: 0x040014B6 RID: 5302
		private uint lastPurchasedNodeIndex_;

		// Token: 0x040014B7 RID: 5303
		public const int SocketedGlyphSnosFieldNumber = 3;

		// Token: 0x040014B8 RID: 5304
		private static readonly FieldCodec<int> _repeated_socketedGlyphSnos_codec = FieldCodec.ForSFixed32(29U);

		// Token: 0x040014B9 RID: 5305
		private readonly RepeatedField<int> socketedGlyphSnos_ = new RepeatedField<int>();

		// Token: 0x040014BA RID: 5306
		public const int EquippedBoardSnosFieldNumber = 4;

		// Token: 0x040014BB RID: 5307
		private static readonly FieldCodec<int> _repeated_equippedBoardSnos_codec = FieldCodec.ForSFixed32(37U);

		// Token: 0x040014BC RID: 5308
		private readonly RepeatedField<int> equippedBoardSnos_ = new RepeatedField<int>();

		// Token: 0x040014BD RID: 5309
		public const int EquippedBoardRotationBitfieldFieldNumber = 5;

		// Token: 0x040014BE RID: 5310
		private static readonly ByteString EquippedBoardRotationBitfieldDefaultValue = ByteString.Empty;

		// Token: 0x040014BF RID: 5311
		private ByteString equippedBoardRotationBitfield_;

		// Token: 0x040014C0 RID: 5312
		public const int EquippedBoardGateNodeIndexesFieldNumber = 6;

		// Token: 0x040014C1 RID: 5313
		private static readonly FieldCodec<uint> _repeated_equippedBoardGateNodeIndexes_codec = FieldCodec.ForUInt32(48U);

		// Token: 0x040014C2 RID: 5314
		private readonly RepeatedField<uint> equippedBoardGateNodeIndexes_ = new RepeatedField<uint>();

		// Token: 0x040014C3 RID: 5315
		public const int BoardEquipIndexesFieldNumber = 7;

		// Token: 0x040014C4 RID: 5316
		private static readonly FieldCodec<uint> _repeated_boardEquipIndexes_codec = FieldCodec.ForUInt32(56U);

		// Token: 0x040014C5 RID: 5317
		private readonly RepeatedField<uint> boardEquipIndexes_ = new RepeatedField<uint>();
	}
}
