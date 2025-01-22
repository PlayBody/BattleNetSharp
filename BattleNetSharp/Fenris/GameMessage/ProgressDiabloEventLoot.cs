using System;
using System.Diagnostics;
using Fenris.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001CD RID: 461
	public sealed class ProgressDiabloEventLoot : IMessage<ProgressDiabloEventLoot>, IMessage, IEquatable<ProgressDiabloEventLoot>, IDeepCloneable<ProgressDiabloEventLoot>, IBufferMessage
	{
		// Token: 0x17000FD4 RID: 4052
		// (get) Token: 0x06003127 RID: 12583 RVA: 0x000C2794 File Offset: 0x000C0994
		[DebuggerNonUserCode]
		public static MessageParser<ProgressDiabloEventLoot> Parser
		{
			get
			{
				return ProgressDiabloEventLoot._parser;
			}
		}

		// Token: 0x17000FD5 RID: 4053
		// (get) Token: 0x06003128 RID: 12584 RVA: 0x000C27AC File Offset: 0x000C09AC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[18];
			}
		}

		// Token: 0x17000FD6 RID: 4054
		// (get) Token: 0x06003129 RID: 12585 RVA: 0x000C27D0 File Offset: 0x000C09D0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ProgressDiabloEventLoot.Descriptor;
			}
		}

		// Token: 0x0600312A RID: 12586 RVA: 0x000C27E7 File Offset: 0x000C09E7
		[DebuggerNonUserCode]
		public ProgressDiabloEventLoot()
		{
		}

		// Token: 0x0600312B RID: 12587 RVA: 0x000C27F4 File Offset: 0x000C09F4
		[DebuggerNonUserCode]
		public ProgressDiabloEventLoot(ProgressDiabloEventLoot other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.item_ = ((other.item_ != null) ? other.item_.Clone() : null);
			this.equipped_ = other.equipped_;
			this.treasureClassSno_ = other.treasureClassSno_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600312C RID: 12588 RVA: 0x000C285C File Offset: 0x000C0A5C
		[DebuggerNonUserCode]
		public ProgressDiabloEventLoot Clone()
		{
			return new ProgressDiabloEventLoot(this);
		}

		// Token: 0x17000FD7 RID: 4055
		// (get) Token: 0x0600312D RID: 12589 RVA: 0x000C2874 File Offset: 0x000C0A74
		// (set) Token: 0x0600312E RID: 12590 RVA: 0x000C288C File Offset: 0x000C0A8C
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

		// Token: 0x17000FD8 RID: 4056
		// (get) Token: 0x0600312F RID: 12591 RVA: 0x000C2898 File Offset: 0x000C0A98
		// (set) Token: 0x06003130 RID: 12592 RVA: 0x000C28C9 File Offset: 0x000C0AC9
		[DebuggerNonUserCode]
		public bool Equipped
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool equippedDefaultValue;
				if (flag)
				{
					equippedDefaultValue = this.equipped_;
				}
				else
				{
					equippedDefaultValue = ProgressDiabloEventLoot.EquippedDefaultValue;
				}
				return equippedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.equipped_ = value;
			}
		}

		// Token: 0x17000FD9 RID: 4057
		// (get) Token: 0x06003131 RID: 12593 RVA: 0x000C28E4 File Offset: 0x000C0AE4
		[DebuggerNonUserCode]
		public bool HasEquipped
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003132 RID: 12594 RVA: 0x000C2901 File Offset: 0x000C0B01
		[DebuggerNonUserCode]
		public void ClearEquipped()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000FDA RID: 4058
		// (get) Token: 0x06003133 RID: 12595 RVA: 0x000C2914 File Offset: 0x000C0B14
		// (set) Token: 0x06003134 RID: 12596 RVA: 0x000C2945 File Offset: 0x000C0B45
		[DebuggerNonUserCode]
		public int TreasureClassSno
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int treasureClassSnoDefaultValue;
				if (flag)
				{
					treasureClassSnoDefaultValue = this.treasureClassSno_;
				}
				else
				{
					treasureClassSnoDefaultValue = ProgressDiabloEventLoot.TreasureClassSnoDefaultValue;
				}
				return treasureClassSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.treasureClassSno_ = value;
			}
		}

		// Token: 0x17000FDB RID: 4059
		// (get) Token: 0x06003135 RID: 12597 RVA: 0x000C2960 File Offset: 0x000C0B60
		[DebuggerNonUserCode]
		public bool HasTreasureClassSno
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003136 RID: 12598 RVA: 0x000C297D File Offset: 0x000C0B7D
		[DebuggerNonUserCode]
		public void ClearTreasureClassSno()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06003137 RID: 12599 RVA: 0x000C2990 File Offset: 0x000C0B90
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ProgressDiabloEventLoot);
		}

		// Token: 0x06003138 RID: 12600 RVA: 0x000C29B0 File Offset: 0x000C0BB0
		[DebuggerNonUserCode]
		public bool Equals(ProgressDiabloEventLoot other)
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
					bool flag4 = !object.Equals(this.Item, other.Item);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Equipped != other.Equipped;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.TreasureClassSno != other.TreasureClassSno;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003139 RID: 12601 RVA: 0x000C2A40 File Offset: 0x000C0C40
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.item_ != null;
			if (flag)
			{
				num ^= this.Item.GetHashCode();
			}
			bool hasEquipped = this.HasEquipped;
			if (hasEquipped)
			{
				num ^= this.Equipped.GetHashCode();
			}
			bool hasTreasureClassSno = this.HasTreasureClassSno;
			if (hasTreasureClassSno)
			{
				num ^= this.TreasureClassSno.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600313A RID: 12602 RVA: 0x000C2ACC File Offset: 0x000C0CCC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600313B RID: 12603 RVA: 0x000C2AE4 File Offset: 0x000C0CE4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600313C RID: 12604 RVA: 0x000C2AF0 File Offset: 0x000C0CF0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.item_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Item);
			}
			bool hasEquipped = this.HasEquipped;
			if (hasEquipped)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Equipped);
			}
			bool hasTreasureClassSno = this.HasTreasureClassSno;
			if (hasTreasureClassSno)
			{
				output.WriteRawTag(29);
				output.WriteSFixed32(this.TreasureClassSno);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600313D RID: 12605 RVA: 0x000C2B84 File Offset: 0x000C0D84
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.item_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Item);
			}
			bool hasEquipped = this.HasEquipped;
			if (hasEquipped)
			{
				num += 2;
			}
			bool hasTreasureClassSno = this.HasTreasureClassSno;
			if (hasTreasureClassSno)
			{
				num += 5;
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600313E RID: 12606 RVA: 0x000C2BFC File Offset: 0x000C0DFC
		[DebuggerNonUserCode]
		public void MergeFrom(ProgressDiabloEventLoot other)
		{
			bool flag = other == null;
			if (!flag)
			{
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
				bool hasEquipped = other.HasEquipped;
				if (hasEquipped)
				{
					this.Equipped = other.Equipped;
				}
				bool hasTreasureClassSno = other.HasTreasureClassSno;
				if (hasTreasureClassSno)
				{
					this.TreasureClassSno = other.TreasureClassSno;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600313F RID: 12607 RVA: 0x000C2C9F File Offset: 0x000C0E9F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003140 RID: 12608 RVA: 0x000C2CAC File Offset: 0x000C0EAC
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
						if (num3 != 29U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TreasureClassSno = input.ReadSFixed32();
						}
					}
					else
					{
						this.Equipped = input.ReadBool();
					}
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
			}
		}

		// Token: 0x0400167A RID: 5754
		private static readonly MessageParser<ProgressDiabloEventLoot> _parser = new MessageParser<ProgressDiabloEventLoot>(() => new ProgressDiabloEventLoot());

		// Token: 0x0400167B RID: 5755
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400167C RID: 5756
		private int _hasBits0;

		// Token: 0x0400167D RID: 5757
		public const int ItemFieldNumber = 1;

		// Token: 0x0400167E RID: 5758
		private Generator item_;

		// Token: 0x0400167F RID: 5759
		public const int EquippedFieldNumber = 2;

		// Token: 0x04001680 RID: 5760
		private static readonly bool EquippedDefaultValue = false;

		// Token: 0x04001681 RID: 5761
		private bool equipped_;

		// Token: 0x04001682 RID: 5762
		public const int TreasureClassSnoFieldNumber = 3;

		// Token: 0x04001683 RID: 5763
		private static readonly int TreasureClassSnoDefaultValue = 0;

		// Token: 0x04001684 RID: 5764
		private int treasureClassSno_;
	}
}
