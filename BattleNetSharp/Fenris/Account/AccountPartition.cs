using System;
using System.Diagnostics;
using Fenris.AttributeSerializer;
using Fenris.ItemCrafting;
using Fenris.Items;
using Fenris.Quests;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Account
{
	// Token: 0x020002D8 RID: 728
	public sealed class AccountPartition : IMessage<AccountPartition>, IMessage, IEquatable<AccountPartition>, IDeepCloneable<AccountPartition>, IBufferMessage
	{
		// Token: 0x1700186D RID: 6253
		// (get) Token: 0x06004CF8 RID: 19704 RVA: 0x0012635C File Offset: 0x0012455C
		[DebuggerNonUserCode]
		public static MessageParser<AccountPartition> Parser
		{
			get
			{
				return AccountPartition._parser;
			}
		}

		// Token: 0x1700186E RID: 6254
		// (get) Token: 0x06004CF9 RID: 19705 RVA: 0x00126374 File Offset: 0x00124574
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x1700186F RID: 6255
		// (get) Token: 0x06004CFA RID: 19706 RVA: 0x00126398 File Offset: 0x00124598
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccountPartition.Descriptor;
			}
		}

		// Token: 0x06004CFB RID: 19707 RVA: 0x001263AF File Offset: 0x001245AF
		[DebuggerNonUserCode]
		public AccountPartition()
		{
		}

		// Token: 0x06004CFC RID: 19708 RVA: 0x001263BC File Offset: 0x001245BC
		[DebuggerNonUserCode]
		public AccountPartition(AccountPartition other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.partitionId_ = other.partitionId_;
			this.savedAttributes_ = ((other.savedAttributes_ != null) ? other.savedAttributes_.Clone() : null);
			this.items_ = ((other.items_ != null) ? other.items_.Clone() : null);
			this.crafter_ = ((other.crafter_ != null) ? other.crafter_.Clone() : null);
			this.currency_ = ((other.currency_ != null) ? other.currency_.Clone() : null);
			this.reputation_ = ((other.reputation_ != null) ? other.reputation_.Clone() : null);
			this.stashSettings_ = ((other.stashSettings_ != null) ? other.stashSettings_.Clone() : null);
			this.rewards_ = ((other.rewards_ != null) ? other.rewards_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004CFD RID: 19709 RVA: 0x001264C0 File Offset: 0x001246C0
		[DebuggerNonUserCode]
		public AccountPartition Clone()
		{
			return new AccountPartition(this);
		}

		// Token: 0x17001870 RID: 6256
		// (get) Token: 0x06004CFE RID: 19710 RVA: 0x001264D8 File Offset: 0x001246D8
		// (set) Token: 0x06004CFF RID: 19711 RVA: 0x00126509 File Offset: 0x00124709
		[DebuggerNonUserCode]
		public int PartitionId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int partitionIdDefaultValue;
				if (flag)
				{
					partitionIdDefaultValue = this.partitionId_;
				}
				else
				{
					partitionIdDefaultValue = AccountPartition.PartitionIdDefaultValue;
				}
				return partitionIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.partitionId_ = value;
			}
		}

		// Token: 0x17001871 RID: 6257
		// (get) Token: 0x06004D00 RID: 19712 RVA: 0x00126524 File Offset: 0x00124724
		[DebuggerNonUserCode]
		public bool HasPartitionId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004D01 RID: 19713 RVA: 0x00126541 File Offset: 0x00124741
		[DebuggerNonUserCode]
		public void ClearPartitionId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001872 RID: 6258
		// (get) Token: 0x06004D02 RID: 19714 RVA: 0x00126554 File Offset: 0x00124754
		// (set) Token: 0x06004D03 RID: 19715 RVA: 0x0012656C File Offset: 0x0012476C
		[DebuggerNonUserCode]
		public SavedAttributes SavedAttributes
		{
			get
			{
				return this.savedAttributes_;
			}
			set
			{
				this.savedAttributes_ = value;
			}
		}

		// Token: 0x17001873 RID: 6259
		// (get) Token: 0x06004D04 RID: 19716 RVA: 0x00126578 File Offset: 0x00124778
		// (set) Token: 0x06004D05 RID: 19717 RVA: 0x00126590 File Offset: 0x00124790
		[DebuggerNonUserCode]
		public ItemList Items
		{
			get
			{
				return this.items_;
			}
			set
			{
				this.items_ = value;
			}
		}

		// Token: 0x17001874 RID: 6260
		// (get) Token: 0x06004D06 RID: 19718 RVA: 0x0012659C File Offset: 0x0012479C
		// (set) Token: 0x06004D07 RID: 19719 RVA: 0x001265B4 File Offset: 0x001247B4
		[DebuggerNonUserCode]
		public CrafterSavedData Crafter
		{
			get
			{
				return this.crafter_;
			}
			set
			{
				this.crafter_ = value;
			}
		}

		// Token: 0x17001875 RID: 6261
		// (get) Token: 0x06004D08 RID: 19720 RVA: 0x001265C0 File Offset: 0x001247C0
		// (set) Token: 0x06004D09 RID: 19721 RVA: 0x001265D8 File Offset: 0x001247D8
		[DebuggerNonUserCode]
		public CurrencySavedData Currency
		{
			get
			{
				return this.currency_;
			}
			set
			{
				this.currency_ = value;
			}
		}

		// Token: 0x17001876 RID: 6262
		// (get) Token: 0x06004D0A RID: 19722 RVA: 0x001265E4 File Offset: 0x001247E4
		// (set) Token: 0x06004D0B RID: 19723 RVA: 0x001265FC File Offset: 0x001247FC
		[DebuggerNonUserCode]
		public SavedReputation Reputation
		{
			get
			{
				return this.reputation_;
			}
			set
			{
				this.reputation_ = value;
			}
		}

		// Token: 0x17001877 RID: 6263
		// (get) Token: 0x06004D0C RID: 19724 RVA: 0x00126608 File Offset: 0x00124808
		// (set) Token: 0x06004D0D RID: 19725 RVA: 0x00126620 File Offset: 0x00124820
		[DebuggerNonUserCode]
		public StashSettings StashSettings
		{
			get
			{
				return this.stashSettings_;
			}
			set
			{
				this.stashSettings_ = value;
			}
		}

		// Token: 0x17001878 RID: 6264
		// (get) Token: 0x06004D0E RID: 19726 RVA: 0x0012662C File Offset: 0x0012482C
		// (set) Token: 0x06004D0F RID: 19727 RVA: 0x00126644 File Offset: 0x00124844
		[DebuggerNonUserCode]
		public Rewards Rewards
		{
			get
			{
				return this.rewards_;
			}
			set
			{
				this.rewards_ = value;
			}
		}

		// Token: 0x06004D10 RID: 19728 RVA: 0x00126650 File Offset: 0x00124850
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AccountPartition);
		}

		// Token: 0x06004D11 RID: 19729 RVA: 0x00126670 File Offset: 0x00124870
		[DebuggerNonUserCode]
		public bool Equals(AccountPartition other)
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
					bool flag4 = this.PartitionId != other.PartitionId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.SavedAttributes, other.SavedAttributes);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Items, other.Items);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.Crafter, other.Crafter);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.Currency, other.Currency);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !object.Equals(this.Reputation, other.Reputation);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !object.Equals(this.StashSettings, other.StashSettings);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !object.Equals(this.Rewards, other.Rewards);
												flag2 = !flag11 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x06004D12 RID: 19730 RVA: 0x001267AC File Offset: 0x001249AC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPartitionId = this.HasPartitionId;
			if (hasPartitionId)
			{
				num ^= this.PartitionId.GetHashCode();
			}
			bool flag = this.savedAttributes_ != null;
			if (flag)
			{
				num ^= this.SavedAttributes.GetHashCode();
			}
			bool flag2 = this.items_ != null;
			if (flag2)
			{
				num ^= this.Items.GetHashCode();
			}
			bool flag3 = this.crafter_ != null;
			if (flag3)
			{
				num ^= this.Crafter.GetHashCode();
			}
			bool flag4 = this.currency_ != null;
			if (flag4)
			{
				num ^= this.Currency.GetHashCode();
			}
			bool flag5 = this.reputation_ != null;
			if (flag5)
			{
				num ^= this.Reputation.GetHashCode();
			}
			bool flag6 = this.stashSettings_ != null;
			if (flag6)
			{
				num ^= this.StashSettings.GetHashCode();
			}
			bool flag7 = this.rewards_ != null;
			if (flag7)
			{
				num ^= this.Rewards.GetHashCode();
			}
			bool flag8 = this._unknownFields != null;
			if (flag8)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004D13 RID: 19731 RVA: 0x001268C8 File Offset: 0x00124AC8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004D14 RID: 19732 RVA: 0x001268E0 File Offset: 0x00124AE0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004D15 RID: 19733 RVA: 0x001268EC File Offset: 0x00124AEC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPartitionId = this.HasPartitionId;
			if (hasPartitionId)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PartitionId);
			}
			bool flag = this.savedAttributes_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.SavedAttributes);
			}
			bool flag2 = this.items_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Items);
			}
			bool flag3 = this.crafter_ != null;
			if (flag3)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Crafter);
			}
			bool flag4 = this.currency_ != null;
			if (flag4)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Currency);
			}
			bool flag5 = this.reputation_ != null;
			if (flag5)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Reputation);
			}
			bool flag6 = this.stashSettings_ != null;
			if (flag6)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.StashSettings);
			}
			bool flag7 = this.rewards_ != null;
			if (flag7)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Rewards);
			}
			bool flag8 = this._unknownFields != null;
			if (flag8)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004D16 RID: 19734 RVA: 0x00126A44 File Offset: 0x00124C44
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPartitionId = this.HasPartitionId;
			if (hasPartitionId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PartitionId);
			}
			bool flag = this.savedAttributes_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SavedAttributes);
			}
			bool flag2 = this.items_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Items);
			}
			bool flag3 = this.crafter_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Crafter);
			}
			bool flag4 = this.currency_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Currency);
			}
			bool flag5 = this.reputation_ != null;
			if (flag5)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reputation);
			}
			bool flag6 = this.stashSettings_ != null;
			if (flag6)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StashSettings);
			}
			bool flag7 = this.rewards_ != null;
			if (flag7)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rewards);
			}
			bool flag8 = this._unknownFields != null;
			if (flag8)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004D17 RID: 19735 RVA: 0x00126B7C File Offset: 0x00124D7C
		[DebuggerNonUserCode]
		public void MergeFrom(AccountPartition other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPartitionId = other.HasPartitionId;
				if (hasPartitionId)
				{
					this.PartitionId = other.PartitionId;
				}
				bool flag2 = other.savedAttributes_ != null;
				if (flag2)
				{
					bool flag3 = this.savedAttributes_ == null;
					if (flag3)
					{
						this.SavedAttributes = new SavedAttributes();
					}
					this.SavedAttributes.MergeFrom(other.SavedAttributes);
				}
				bool flag4 = other.items_ != null;
				if (flag4)
				{
					bool flag5 = this.items_ == null;
					if (flag5)
					{
						this.Items = new ItemList();
					}
					this.Items.MergeFrom(other.Items);
				}
				bool flag6 = other.crafter_ != null;
				if (flag6)
				{
					bool flag7 = this.crafter_ == null;
					if (flag7)
					{
						this.Crafter = new CrafterSavedData();
					}
					this.Crafter.MergeFrom(other.Crafter);
				}
				bool flag8 = other.currency_ != null;
				if (flag8)
				{
					bool flag9 = this.currency_ == null;
					if (flag9)
					{
						this.Currency = new CurrencySavedData();
					}
					this.Currency.MergeFrom(other.Currency);
				}
				bool flag10 = other.reputation_ != null;
				if (flag10)
				{
					bool flag11 = this.reputation_ == null;
					if (flag11)
					{
						this.Reputation = new SavedReputation();
					}
					this.Reputation.MergeFrom(other.Reputation);
				}
				bool flag12 = other.stashSettings_ != null;
				if (flag12)
				{
					bool flag13 = this.stashSettings_ == null;
					if (flag13)
					{
						this.StashSettings = new StashSettings();
					}
					this.StashSettings.MergeFrom(other.StashSettings);
				}
				bool flag14 = other.rewards_ != null;
				if (flag14)
				{
					bool flag15 = this.rewards_ == null;
					if (flag15)
					{
						this.Rewards = new Rewards();
					}
					this.Rewards.MergeFrom(other.Rewards);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004D18 RID: 19736 RVA: 0x00126D84 File Offset: 0x00124F84
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004D19 RID: 19737 RVA: 0x00126D90 File Offset: 0x00124F90
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
					if (num3 <= 18U)
					{
						if (num3 != 8U)
						{
							if (num3 != 18U)
							{
								goto IL_0063;
							}
							bool flag = this.savedAttributes_ == null;
							if (flag)
							{
								this.SavedAttributes = new SavedAttributes();
							}
							input.ReadMessage(this.SavedAttributes);
						}
						else
						{
							this.PartitionId = input.ReadInt32();
						}
					}
					else if (num3 != 26U)
					{
						if (num3 != 34U)
						{
							goto IL_0063;
						}
						bool flag2 = this.crafter_ == null;
						if (flag2)
						{
							this.Crafter = new CrafterSavedData();
						}
						input.ReadMessage(this.Crafter);
					}
					else
					{
						bool flag3 = this.items_ == null;
						if (flag3)
						{
							this.Items = new ItemList();
						}
						input.ReadMessage(this.Items);
					}
				}
				else if (num3 <= 82U)
				{
					if (num3 != 74U)
					{
						if (num3 != 82U)
						{
							goto IL_0063;
						}
						bool flag4 = this.reputation_ == null;
						if (flag4)
						{
							this.Reputation = new SavedReputation();
						}
						input.ReadMessage(this.Reputation);
					}
					else
					{
						bool flag5 = this.currency_ == null;
						if (flag5)
						{
							this.Currency = new CurrencySavedData();
						}
						input.ReadMessage(this.Currency);
					}
				}
				else if (num3 != 106U)
				{
					if (num3 != 114U)
					{
						goto IL_0063;
					}
					bool flag6 = this.rewards_ == null;
					if (flag6)
					{
						this.Rewards = new Rewards();
					}
					input.ReadMessage(this.Rewards);
				}
				else
				{
					bool flag7 = this.stashSettings_ == null;
					if (flag7)
					{
						this.StashSettings = new StashSettings();
					}
					input.ReadMessage(this.StashSettings);
				}
				continue;
				IL_0063:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400224E RID: 8782
		private static readonly MessageParser<AccountPartition> _parser = new MessageParser<AccountPartition>(() => new AccountPartition());

		// Token: 0x0400224F RID: 8783
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002250 RID: 8784
		private int _hasBits0;

		// Token: 0x04002251 RID: 8785
		public const int PartitionIdFieldNumber = 1;

		// Token: 0x04002252 RID: 8786
		private static readonly int PartitionIdDefaultValue = 0;

		// Token: 0x04002253 RID: 8787
		private int partitionId_;

		// Token: 0x04002254 RID: 8788
		public const int SavedAttributesFieldNumber = 2;

		// Token: 0x04002255 RID: 8789
		private SavedAttributes savedAttributes_;

		// Token: 0x04002256 RID: 8790
		public const int ItemsFieldNumber = 3;

		// Token: 0x04002257 RID: 8791
		private ItemList items_;

		// Token: 0x04002258 RID: 8792
		public const int CrafterFieldNumber = 4;

		// Token: 0x04002259 RID: 8793
		private CrafterSavedData crafter_;

		// Token: 0x0400225A RID: 8794
		public const int CurrencyFieldNumber = 9;

		// Token: 0x0400225B RID: 8795
		private CurrencySavedData currency_;

		// Token: 0x0400225C RID: 8796
		public const int ReputationFieldNumber = 10;

		// Token: 0x0400225D RID: 8797
		private SavedReputation reputation_;

		// Token: 0x0400225E RID: 8798
		public const int StashSettingsFieldNumber = 13;

		// Token: 0x0400225F RID: 8799
		private StashSettings stashSettings_;

		// Token: 0x04002260 RID: 8800
		public const int RewardsFieldNumber = 14;

		// Token: 0x04002261 RID: 8801
		private Rewards rewards_;
	}
}
