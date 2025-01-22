using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x0200032C RID: 812
	public sealed class InventoryState : IMessage<InventoryState>, IMessage, IEquatable<InventoryState>, IDeepCloneable<InventoryState>, IBufferMessage
	{
		// Token: 0x17001B63 RID: 7011
		// (get) Token: 0x060054E0 RID: 21728 RVA: 0x001481F8 File Offset: 0x001463F8
		[DebuggerNonUserCode]
		public static MessageParser<InventoryState> Parser
		{
			get
			{
				return InventoryState._parser;
			}
		}

		// Token: 0x17001B64 RID: 7012
		// (get) Token: 0x060054E1 RID: 21729 RVA: 0x00148210 File Offset: 0x00146410
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CommonInventoryStateReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17001B65 RID: 7013
		// (get) Token: 0x060054E2 RID: 21730 RVA: 0x00148234 File Offset: 0x00146434
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InventoryState.Descriptor;
			}
		}

		// Token: 0x060054E3 RID: 21731 RVA: 0x0014824B File Offset: 0x0014644B
		[DebuggerNonUserCode]
		public InventoryState()
		{
		}

		// Token: 0x060054E4 RID: 21732 RVA: 0x00148260 File Offset: 0x00146460
		[DebuggerNonUserCode]
		public InventoryState(InventoryState other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.items_ = other.items_.Clone();
			this.goldCarried_ = other.goldCarried_;
			this.goldBank_ = other.goldBank_;
			this.charmCount_ = other.charmCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060054E5 RID: 21733 RVA: 0x001482C8 File Offset: 0x001464C8
		[DebuggerNonUserCode]
		public InventoryState Clone()
		{
			return new InventoryState(this);
		}

		// Token: 0x17001B66 RID: 7014
		// (get) Token: 0x060054E6 RID: 21734 RVA: 0x001482E0 File Offset: 0x001464E0
		[DebuggerNonUserCode]
		public RepeatedField<Item> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x17001B67 RID: 7015
		// (get) Token: 0x060054E7 RID: 21735 RVA: 0x001482F8 File Offset: 0x001464F8
		// (set) Token: 0x060054E8 RID: 21736 RVA: 0x00148329 File Offset: 0x00146529
		[DebuggerNonUserCode]
		public ulong GoldCarried
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong goldCarriedDefaultValue;
				if (flag)
				{
					goldCarriedDefaultValue = this.goldCarried_;
				}
				else
				{
					goldCarriedDefaultValue = InventoryState.GoldCarriedDefaultValue;
				}
				return goldCarriedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.goldCarried_ = value;
			}
		}

		// Token: 0x17001B68 RID: 7016
		// (get) Token: 0x060054E9 RID: 21737 RVA: 0x00148344 File Offset: 0x00146544
		[DebuggerNonUserCode]
		public bool HasGoldCarried
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060054EA RID: 21738 RVA: 0x00148361 File Offset: 0x00146561
		[DebuggerNonUserCode]
		public void ClearGoldCarried()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001B69 RID: 7017
		// (get) Token: 0x060054EB RID: 21739 RVA: 0x00148374 File Offset: 0x00146574
		// (set) Token: 0x060054EC RID: 21740 RVA: 0x001483A5 File Offset: 0x001465A5
		[DebuggerNonUserCode]
		public ulong GoldBank
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong goldBankDefaultValue;
				if (flag)
				{
					goldBankDefaultValue = this.goldBank_;
				}
				else
				{
					goldBankDefaultValue = InventoryState.GoldBankDefaultValue;
				}
				return goldBankDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.goldBank_ = value;
			}
		}

		// Token: 0x17001B6A RID: 7018
		// (get) Token: 0x060054ED RID: 21741 RVA: 0x001483C0 File Offset: 0x001465C0
		[DebuggerNonUserCode]
		public bool HasGoldBank
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060054EE RID: 21742 RVA: 0x001483DD File Offset: 0x001465DD
		[DebuggerNonUserCode]
		public void ClearGoldBank()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001B6B RID: 7019
		// (get) Token: 0x060054EF RID: 21743 RVA: 0x001483F0 File Offset: 0x001465F0
		// (set) Token: 0x060054F0 RID: 21744 RVA: 0x00148421 File Offset: 0x00146621
		[DebuggerNonUserCode]
		public uint CharmCount
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint charmCountDefaultValue;
				if (flag)
				{
					charmCountDefaultValue = this.charmCount_;
				}
				else
				{
					charmCountDefaultValue = InventoryState.CharmCountDefaultValue;
				}
				return charmCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.charmCount_ = value;
			}
		}

		// Token: 0x17001B6C RID: 7020
		// (get) Token: 0x060054F1 RID: 21745 RVA: 0x0014843C File Offset: 0x0014663C
		[DebuggerNonUserCode]
		public bool HasCharmCount
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060054F2 RID: 21746 RVA: 0x00148459 File Offset: 0x00146659
		[DebuggerNonUserCode]
		public void ClearCharmCount()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x060054F3 RID: 21747 RVA: 0x0014846C File Offset: 0x0014666C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as InventoryState);
		}

		// Token: 0x060054F4 RID: 21748 RVA: 0x0014848C File Offset: 0x0014668C
		[DebuggerNonUserCode]
		public bool Equals(InventoryState other)
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
					bool flag4 = !this.items_.Equals(other.items_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.GoldCarried != other.GoldCarried;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.GoldBank != other.GoldBank;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.CharmCount != other.CharmCount;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060054F5 RID: 21749 RVA: 0x0014853C File Offset: 0x0014673C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.items_.GetHashCode();
			bool hasGoldCarried = this.HasGoldCarried;
			if (hasGoldCarried)
			{
				num ^= this.GoldCarried.GetHashCode();
			}
			bool hasGoldBank = this.HasGoldBank;
			if (hasGoldBank)
			{
				num ^= this.GoldBank.GetHashCode();
			}
			bool hasCharmCount = this.HasCharmCount;
			if (hasCharmCount)
			{
				num ^= this.CharmCount.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060054F6 RID: 21750 RVA: 0x001485D4 File Offset: 0x001467D4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060054F7 RID: 21751 RVA: 0x001485EC File Offset: 0x001467EC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060054F8 RID: 21752 RVA: 0x001485F8 File Offset: 0x001467F8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.items_.WriteTo(ref output, InventoryState._repeated_items_codec);
			bool hasGoldCarried = this.HasGoldCarried;
			if (hasGoldCarried)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.GoldCarried);
			}
			bool hasGoldBank = this.HasGoldBank;
			if (hasGoldBank)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.GoldBank);
			}
			bool hasCharmCount = this.HasCharmCount;
			if (hasCharmCount)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.CharmCount);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060054F9 RID: 21753 RVA: 0x0014869C File Offset: 0x0014689C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.items_.CalculateSize(InventoryState._repeated_items_codec);
			bool hasGoldCarried = this.HasGoldCarried;
			if (hasGoldCarried)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.GoldCarried);
			}
			bool hasGoldBank = this.HasGoldBank;
			if (hasGoldBank)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.GoldBank);
			}
			bool hasCharmCount = this.HasCharmCount;
			if (hasCharmCount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CharmCount);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060054FA RID: 21754 RVA: 0x0014873C File Offset: 0x0014693C
		[DebuggerNonUserCode]
		public void MergeFrom(InventoryState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.items_.Add(other.items_);
				bool hasGoldCarried = other.HasGoldCarried;
				if (hasGoldCarried)
				{
					this.GoldCarried = other.GoldCarried;
				}
				bool hasGoldBank = other.HasGoldBank;
				if (hasGoldBank)
				{
					this.GoldBank = other.GoldBank;
				}
				bool hasCharmCount = other.HasCharmCount;
				if (hasCharmCount)
				{
					this.CharmCount = other.CharmCount;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060054FB RID: 21755 RVA: 0x001487C9 File Offset: 0x001469C9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060054FC RID: 21756 RVA: 0x001487D4 File Offset: 0x001469D4
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
					if (num3 != 10U)
					{
						if (num3 != 16U)
						{
							goto IL_002C;
						}
						this.GoldCarried = input.ReadUInt64();
					}
					else
					{
						this.items_.AddEntriesFrom(ref input, InventoryState._repeated_items_codec);
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_002C;
					}
					this.CharmCount = input.ReadUInt32();
				}
				else
				{
					this.GoldBank = input.ReadUInt64();
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002693 RID: 9875
		private static readonly MessageParser<InventoryState> _parser = new MessageParser<InventoryState>(() => new InventoryState());

		// Token: 0x04002694 RID: 9876
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002695 RID: 9877
		private int _hasBits0;

		// Token: 0x04002696 RID: 9878
		public const int ItemsFieldNumber = 1;

		// Token: 0x04002697 RID: 9879
		private static readonly FieldCodec<Item> _repeated_items_codec = FieldCodec.ForMessage<Item>(10U, Item.Parser);

		// Token: 0x04002698 RID: 9880
		private readonly RepeatedField<Item> items_ = new RepeatedField<Item>();

		// Token: 0x04002699 RID: 9881
		public const int GoldCarriedFieldNumber = 2;

		// Token: 0x0400269A RID: 9882
		private static readonly ulong GoldCarriedDefaultValue = 0UL;

		// Token: 0x0400269B RID: 9883
		private ulong goldCarried_;

		// Token: 0x0400269C RID: 9884
		public const int GoldBankFieldNumber = 3;

		// Token: 0x0400269D RID: 9885
		private static readonly ulong GoldBankDefaultValue = 0UL;

		// Token: 0x0400269E RID: 9886
		private ulong goldBank_;

		// Token: 0x0400269F RID: 9887
		public const int CharmCountFieldNumber = 4;

		// Token: 0x040026A0 RID: 9888
		private static readonly uint CharmCountDefaultValue = 0U;

		// Token: 0x040026A1 RID: 9889
		private uint charmCount_;
	}
}
