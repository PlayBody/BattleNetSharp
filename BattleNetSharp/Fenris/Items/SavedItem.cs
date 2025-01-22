using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Items
{
	// Token: 0x02000167 RID: 359
	public sealed class SavedItem : IMessage<SavedItem>, IMessage, IEquatable<SavedItem>, IDeepCloneable<SavedItem>, IBufferMessage
	{
		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x06002558 RID: 9560 RVA: 0x00091418 File Offset: 0x0008F618
		[DebuggerNonUserCode]
		public static MessageParser<SavedItem> Parser
		{
			get
			{
				return SavedItem._parser;
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x06002559 RID: 9561 RVA: 0x00091430 File Offset: 0x0008F630
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ItemsReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x0600255A RID: 9562 RVA: 0x00091454 File Offset: 0x0008F654
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SavedItem.Descriptor;
			}
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x0009146B File Offset: 0x0008F66B
		[DebuggerNonUserCode]
		public SavedItem()
		{
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x00091478 File Offset: 0x0008F678
		[DebuggerNonUserCode]
		public SavedItem(SavedItem other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.ownerHeroId_ = other.ownerHeroId_;
			this.socketId_ = other.socketId_;
			this.hirelingClass_ = other.hirelingClass_;
			this.itemSlot_ = other.itemSlot_;
			this.squareIndex_ = other.squareIndex_;
			this.usedSocketCount_ = other.usedSocketCount_;
			this.generator_ = ((other.generator_ != null) ? other.generator_.Clone() : null);
			this.dbSlot_ = other.dbSlot_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x00091528 File Offset: 0x0008F728
		[DebuggerNonUserCode]
		public SavedItem Clone()
		{
			return new SavedItem(this);
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x0600255E RID: 9566 RVA: 0x00091540 File Offset: 0x0008F740
		// (set) Token: 0x0600255F RID: 9567 RVA: 0x00091561 File Offset: 0x0008F761
		[DebuggerNonUserCode]
		public ByteString Id
		{
			get
			{
				return this.id_ ?? SavedItem.IdDefaultValue;
			}
			set
			{
				this.id_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x06002560 RID: 9568 RVA: 0x00091578 File Offset: 0x0008F778
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return this.id_ != null;
			}
		}

		// Token: 0x06002561 RID: 9569 RVA: 0x00091596 File Offset: 0x0008F796
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this.id_ = null;
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06002562 RID: 9570 RVA: 0x000915A0 File Offset: 0x0008F7A0
		// (set) Token: 0x06002563 RID: 9571 RVA: 0x000915C1 File Offset: 0x0008F7C1
		[DebuggerNonUserCode]
		public ByteString OwnerHeroId
		{
			get
			{
				return this.ownerHeroId_ ?? SavedItem.OwnerHeroIdDefaultValue;
			}
			set
			{
				this.ownerHeroId_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06002564 RID: 9572 RVA: 0x000915D8 File Offset: 0x0008F7D8
		[DebuggerNonUserCode]
		public bool HasOwnerHeroId
		{
			get
			{
				return this.ownerHeroId_ != null;
			}
		}

		// Token: 0x06002565 RID: 9573 RVA: 0x000915F6 File Offset: 0x0008F7F6
		[DebuggerNonUserCode]
		public void ClearOwnerHeroId()
		{
			this.ownerHeroId_ = null;
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x06002566 RID: 9574 RVA: 0x00091600 File Offset: 0x0008F800
		// (set) Token: 0x06002567 RID: 9575 RVA: 0x00091621 File Offset: 0x0008F821
		[DebuggerNonUserCode]
		public ByteString SocketId
		{
			get
			{
				return this.socketId_ ?? SavedItem.SocketIdDefaultValue;
			}
			set
			{
				this.socketId_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x06002568 RID: 9576 RVA: 0x00091638 File Offset: 0x0008F838
		[DebuggerNonUserCode]
		public bool HasSocketId
		{
			get
			{
				return this.socketId_ != null;
			}
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x00091656 File Offset: 0x0008F856
		[DebuggerNonUserCode]
		public void ClearSocketId()
		{
			this.socketId_ = null;
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x0600256A RID: 9578 RVA: 0x00091660 File Offset: 0x0008F860
		// (set) Token: 0x0600256B RID: 9579 RVA: 0x00091691 File Offset: 0x0008F891
		[DebuggerNonUserCode]
		public int HirelingClass
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int hirelingClassDefaultValue;
				if (flag)
				{
					hirelingClassDefaultValue = this.hirelingClass_;
				}
				else
				{
					hirelingClassDefaultValue = SavedItem.HirelingClassDefaultValue;
				}
				return hirelingClassDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.hirelingClass_ = value;
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x0600256C RID: 9580 RVA: 0x000916AC File Offset: 0x0008F8AC
		[DebuggerNonUserCode]
		public bool HasHirelingClass
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600256D RID: 9581 RVA: 0x000916C9 File Offset: 0x0008F8C9
		[DebuggerNonUserCode]
		public void ClearHirelingClass()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x0600256E RID: 9582 RVA: 0x000916DC File Offset: 0x0008F8DC
		// (set) Token: 0x0600256F RID: 9583 RVA: 0x0009170D File Offset: 0x0008F90D
		[DebuggerNonUserCode]
		public int ItemSlot
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int itemSlotDefaultValue;
				if (flag)
				{
					itemSlotDefaultValue = this.itemSlot_;
				}
				else
				{
					itemSlotDefaultValue = SavedItem.ItemSlotDefaultValue;
				}
				return itemSlotDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.itemSlot_ = value;
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x06002570 RID: 9584 RVA: 0x00091728 File Offset: 0x0008F928
		[DebuggerNonUserCode]
		public bool HasItemSlot
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002571 RID: 9585 RVA: 0x00091745 File Offset: 0x0008F945
		[DebuggerNonUserCode]
		public void ClearItemSlot()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x06002572 RID: 9586 RVA: 0x00091758 File Offset: 0x0008F958
		// (set) Token: 0x06002573 RID: 9587 RVA: 0x00091789 File Offset: 0x0008F989
		[DebuggerNonUserCode]
		public int SquareIndex
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int squareIndexDefaultValue;
				if (flag)
				{
					squareIndexDefaultValue = this.squareIndex_;
				}
				else
				{
					squareIndexDefaultValue = SavedItem.SquareIndexDefaultValue;
				}
				return squareIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.squareIndex_ = value;
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x06002574 RID: 9588 RVA: 0x000917A4 File Offset: 0x0008F9A4
		[DebuggerNonUserCode]
		public bool HasSquareIndex
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06002575 RID: 9589 RVA: 0x000917C1 File Offset: 0x0008F9C1
		[DebuggerNonUserCode]
		public void ClearSquareIndex()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x06002576 RID: 9590 RVA: 0x000917D4 File Offset: 0x0008F9D4
		// (set) Token: 0x06002577 RID: 9591 RVA: 0x00091805 File Offset: 0x0008FA05
		[DebuggerNonUserCode]
		public uint UsedSocketCount
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint usedSocketCountDefaultValue;
				if (flag)
				{
					usedSocketCountDefaultValue = this.usedSocketCount_;
				}
				else
				{
					usedSocketCountDefaultValue = SavedItem.UsedSocketCountDefaultValue;
				}
				return usedSocketCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.usedSocketCount_ = value;
			}
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06002578 RID: 9592 RVA: 0x00091820 File Offset: 0x0008FA20
		[DebuggerNonUserCode]
		public bool HasUsedSocketCount
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x0009183D File Offset: 0x0008FA3D
		[DebuggerNonUserCode]
		public void ClearUsedSocketCount()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x0600257A RID: 9594 RVA: 0x00091850 File Offset: 0x0008FA50
		// (set) Token: 0x0600257B RID: 9595 RVA: 0x00091868 File Offset: 0x0008FA68
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

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x0600257C RID: 9596 RVA: 0x00091874 File Offset: 0x0008FA74
		// (set) Token: 0x0600257D RID: 9597 RVA: 0x000918A6 File Offset: 0x0008FAA6
		[DebuggerNonUserCode]
		public uint DbSlot
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint dbSlotDefaultValue;
				if (flag)
				{
					dbSlotDefaultValue = this.dbSlot_;
				}
				else
				{
					dbSlotDefaultValue = SavedItem.DbSlotDefaultValue;
				}
				return dbSlotDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.dbSlot_ = value;
			}
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x0600257E RID: 9598 RVA: 0x000918C0 File Offset: 0x0008FAC0
		[DebuggerNonUserCode]
		public bool HasDbSlot
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600257F RID: 9599 RVA: 0x000918DE File Offset: 0x0008FADE
		[DebuggerNonUserCode]
		public void ClearDbSlot()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x06002580 RID: 9600 RVA: 0x000918F0 File Offset: 0x0008FAF0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SavedItem);
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x00091910 File Offset: 0x0008FB10
		[DebuggerNonUserCode]
		public bool Equals(SavedItem other)
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
						bool flag5 = this.OwnerHeroId != other.OwnerHeroId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.SocketId != other.SocketId;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.HirelingClass != other.HirelingClass;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.ItemSlot != other.ItemSlot;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.SquareIndex != other.SquareIndex;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.UsedSocketCount != other.UsedSocketCount;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !object.Equals(this.Generator, other.Generator);
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.DbSlot != other.DbSlot;
													flag2 = !flag12 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x06002582 RID: 9602 RVA: 0x00091A58 File Offset: 0x0008FC58
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasOwnerHeroId = this.HasOwnerHeroId;
			if (hasOwnerHeroId)
			{
				num ^= this.OwnerHeroId.GetHashCode();
			}
			bool hasSocketId = this.HasSocketId;
			if (hasSocketId)
			{
				num ^= this.SocketId.GetHashCode();
			}
			bool hasHirelingClass = this.HasHirelingClass;
			if (hasHirelingClass)
			{
				num ^= this.HirelingClass.GetHashCode();
			}
			bool hasItemSlot = this.HasItemSlot;
			if (hasItemSlot)
			{
				num ^= this.ItemSlot.GetHashCode();
			}
			bool hasSquareIndex = this.HasSquareIndex;
			if (hasSquareIndex)
			{
				num ^= this.SquareIndex.GetHashCode();
			}
			bool hasUsedSocketCount = this.HasUsedSocketCount;
			if (hasUsedSocketCount)
			{
				num ^= this.UsedSocketCount.GetHashCode();
			}
			bool flag = this.generator_ != null;
			if (flag)
			{
				num ^= this.Generator.GetHashCode();
			}
			bool hasDbSlot = this.HasDbSlot;
			if (hasDbSlot)
			{
				num ^= this.DbSlot.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x00091B8C File Offset: 0x0008FD8C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002584 RID: 9604 RVA: 0x00091BA4 File Offset: 0x0008FDA4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002585 RID: 9605 RVA: 0x00091BB0 File Offset: 0x0008FDB0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(10);
				output.WriteBytes(this.Id);
			}
			bool hasOwnerHeroId = this.HasOwnerHeroId;
			if (hasOwnerHeroId)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.OwnerHeroId);
			}
			bool hasSocketId = this.HasSocketId;
			if (hasSocketId)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.SocketId);
			}
			bool hasHirelingClass = this.HasHirelingClass;
			if (hasHirelingClass)
			{
				output.WriteRawTag(32);
				output.WriteSInt32(this.HirelingClass);
			}
			bool hasItemSlot = this.HasItemSlot;
			if (hasItemSlot)
			{
				output.WriteRawTag(40);
				output.WriteSInt32(this.ItemSlot);
			}
			bool hasSquareIndex = this.HasSquareIndex;
			if (hasSquareIndex)
			{
				output.WriteRawTag(48);
				output.WriteSInt32(this.SquareIndex);
			}
			bool hasUsedSocketCount = this.HasUsedSocketCount;
			if (hasUsedSocketCount)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.UsedSocketCount);
			}
			bool flag = this.generator_ != null;
			if (flag)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Generator);
			}
			bool hasDbSlot = this.HasDbSlot;
			if (hasDbSlot)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.DbSlot);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002586 RID: 9606 RVA: 0x00091D1C File Offset: 0x0008FF1C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Id);
			}
			bool hasOwnerHeroId = this.HasOwnerHeroId;
			if (hasOwnerHeroId)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.OwnerHeroId);
			}
			bool hasSocketId = this.HasSocketId;
			if (hasSocketId)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.SocketId);
			}
			bool hasHirelingClass = this.HasHirelingClass;
			if (hasHirelingClass)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.HirelingClass);
			}
			bool hasItemSlot = this.HasItemSlot;
			if (hasItemSlot)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.ItemSlot);
			}
			bool hasSquareIndex = this.HasSquareIndex;
			if (hasSquareIndex)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.SquareIndex);
			}
			bool hasUsedSocketCount = this.HasUsedSocketCount;
			if (hasUsedSocketCount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.UsedSocketCount);
			}
			bool flag = this.generator_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Generator);
			}
			bool hasDbSlot = this.HasDbSlot;
			if (hasDbSlot)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DbSlot);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002587 RID: 9607 RVA: 0x00091E60 File Offset: 0x00090060
		[DebuggerNonUserCode]
		public void MergeFrom(SavedItem other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasOwnerHeroId = other.HasOwnerHeroId;
				if (hasOwnerHeroId)
				{
					this.OwnerHeroId = other.OwnerHeroId;
				}
				bool hasSocketId = other.HasSocketId;
				if (hasSocketId)
				{
					this.SocketId = other.SocketId;
				}
				bool hasHirelingClass = other.HasHirelingClass;
				if (hasHirelingClass)
				{
					this.HirelingClass = other.HirelingClass;
				}
				bool hasItemSlot = other.HasItemSlot;
				if (hasItemSlot)
				{
					this.ItemSlot = other.ItemSlot;
				}
				bool hasSquareIndex = other.HasSquareIndex;
				if (hasSquareIndex)
				{
					this.SquareIndex = other.SquareIndex;
				}
				bool hasUsedSocketCount = other.HasUsedSocketCount;
				if (hasUsedSocketCount)
				{
					this.UsedSocketCount = other.UsedSocketCount;
				}
				bool flag2 = other.generator_ != null;
				if (flag2)
				{
					bool flag3 = this.generator_ == null;
					if (flag3)
					{
						this.Generator = new Generator();
					}
					this.Generator.MergeFrom(other.Generator);
				}
				bool hasDbSlot = other.HasDbSlot;
				if (hasDbSlot)
				{
					this.DbSlot = other.DbSlot;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002588 RID: 9608 RVA: 0x00091FA5 File Offset: 0x000901A5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002589 RID: 9609 RVA: 0x00091FB0 File Offset: 0x000901B0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 32U)
				{
					if (num3 <= 18U)
					{
						if (num3 != 10U)
						{
							if (num3 != 18U)
							{
								goto IL_006E;
							}
							this.OwnerHeroId = input.ReadBytes();
						}
						else
						{
							this.Id = input.ReadBytes();
						}
					}
					else if (num3 != 26U)
					{
						if (num3 != 32U)
						{
							goto IL_006E;
						}
						this.HirelingClass = input.ReadSInt32();
					}
					else
					{
						this.SocketId = input.ReadBytes();
					}
				}
				else if (num3 <= 48U)
				{
					if (num3 != 40U)
					{
						if (num3 != 48U)
						{
							goto IL_006E;
						}
						this.SquareIndex = input.ReadSInt32();
					}
					else
					{
						this.ItemSlot = input.ReadSInt32();
					}
				}
				else if (num3 != 56U)
				{
					if (num3 != 66U)
					{
						if (num3 != 72U)
						{
							goto IL_006E;
						}
						this.DbSlot = input.ReadUInt32();
					}
					else
					{
						bool flag = this.generator_ == null;
						if (flag)
						{
							this.Generator = new Generator();
						}
						input.ReadMessage(this.Generator);
					}
				}
				else
				{
					this.UsedSocketCount = input.ReadUInt32();
				}
				continue;
				IL_006E:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400107E RID: 4222
		private static readonly MessageParser<SavedItem> _parser = new MessageParser<SavedItem>(() => new SavedItem());

		// Token: 0x0400107F RID: 4223
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001080 RID: 4224
		private int _hasBits0;

		// Token: 0x04001081 RID: 4225
		public const int IdFieldNumber = 1;

		// Token: 0x04001082 RID: 4226
		private static readonly ByteString IdDefaultValue = ByteString.Empty;

		// Token: 0x04001083 RID: 4227
		private ByteString id_;

		// Token: 0x04001084 RID: 4228
		public const int OwnerHeroIdFieldNumber = 2;

		// Token: 0x04001085 RID: 4229
		private static readonly ByteString OwnerHeroIdDefaultValue = ByteString.Empty;

		// Token: 0x04001086 RID: 4230
		private ByteString ownerHeroId_;

		// Token: 0x04001087 RID: 4231
		public const int SocketIdFieldNumber = 3;

		// Token: 0x04001088 RID: 4232
		private static readonly ByteString SocketIdDefaultValue = ByteString.Empty;

		// Token: 0x04001089 RID: 4233
		private ByteString socketId_;

		// Token: 0x0400108A RID: 4234
		public const int HirelingClassFieldNumber = 4;

		// Token: 0x0400108B RID: 4235
		private static readonly int HirelingClassDefaultValue = -1;

		// Token: 0x0400108C RID: 4236
		private int hirelingClass_;

		// Token: 0x0400108D RID: 4237
		public const int ItemSlotFieldNumber = 5;

		// Token: 0x0400108E RID: 4238
		private static readonly int ItemSlotDefaultValue = 0;

		// Token: 0x0400108F RID: 4239
		private int itemSlot_;

		// Token: 0x04001090 RID: 4240
		public const int SquareIndexFieldNumber = 6;

		// Token: 0x04001091 RID: 4241
		private static readonly int SquareIndexDefaultValue = 0;

		// Token: 0x04001092 RID: 4242
		private int squareIndex_;

		// Token: 0x04001093 RID: 4243
		public const int UsedSocketCountFieldNumber = 7;

		// Token: 0x04001094 RID: 4244
		private static readonly uint UsedSocketCountDefaultValue = 0U;

		// Token: 0x04001095 RID: 4245
		private uint usedSocketCount_;

		// Token: 0x04001096 RID: 4246
		public const int GeneratorFieldNumber = 8;

		// Token: 0x04001097 RID: 4247
		private Generator generator_;

		// Token: 0x04001098 RID: 4248
		public const int DbSlotFieldNumber = 9;

		// Token: 0x04001099 RID: 4249
		private static readonly uint DbSlotDefaultValue = 0U;

		// Token: 0x0400109A RID: 4250
		private uint dbSlot_;
	}
}
