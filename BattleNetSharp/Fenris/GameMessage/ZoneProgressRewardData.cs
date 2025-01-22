using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001C6 RID: 454
	public sealed class ZoneProgressRewardData : IMessage<ZoneProgressRewardData>, IMessage, IEquatable<ZoneProgressRewardData>, IDeepCloneable<ZoneProgressRewardData>, IBufferMessage
	{
		// Token: 0x17000F91 RID: 3985
		// (get) Token: 0x06003063 RID: 12387 RVA: 0x000BF800 File Offset: 0x000BDA00
		[DebuggerNonUserCode]
		public static MessageParser<ZoneProgressRewardData> Parser
		{
			get
			{
				return ZoneProgressRewardData._parser;
			}
		}

		// Token: 0x17000F92 RID: 3986
		// (get) Token: 0x06003064 RID: 12388 RVA: 0x000BF818 File Offset: 0x000BDA18
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[11];
			}
		}

		// Token: 0x17000F93 RID: 3987
		// (get) Token: 0x06003065 RID: 12389 RVA: 0x000BF83C File Offset: 0x000BDA3C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ZoneProgressRewardData.Descriptor;
			}
		}

		// Token: 0x06003066 RID: 12390 RVA: 0x000BF853 File Offset: 0x000BDA53
		[DebuggerNonUserCode]
		public ZoneProgressRewardData()
		{
		}

		// Token: 0x06003067 RID: 12391 RVA: 0x000BF860 File Offset: 0x000BDA60
		[DebuggerNonUserCode]
		public ZoneProgressRewardData(ZoneProgressRewardData other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.rewardType_ = other.rewardType_;
			this.snoItemReward_ = other.snoItemReward_;
			this.snoTrackedReward_ = other.snoTrackedReward_;
			this.goldTier_ = other.goldTier_;
			this.staticGoldAmount_ = other.staticGoldAmount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003068 RID: 12392 RVA: 0x000BF8D0 File Offset: 0x000BDAD0
		[DebuggerNonUserCode]
		public ZoneProgressRewardData Clone()
		{
			return new ZoneProgressRewardData(this);
		}

		// Token: 0x17000F94 RID: 3988
		// (get) Token: 0x06003069 RID: 12393 RVA: 0x000BF8E8 File Offset: 0x000BDAE8
		// (set) Token: 0x0600306A RID: 12394 RVA: 0x000BF919 File Offset: 0x000BDB19
		[DebuggerNonUserCode]
		public int RewardType
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int rewardTypeDefaultValue;
				if (flag)
				{
					rewardTypeDefaultValue = this.rewardType_;
				}
				else
				{
					rewardTypeDefaultValue = ZoneProgressRewardData.RewardTypeDefaultValue;
				}
				return rewardTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.rewardType_ = value;
			}
		}

		// Token: 0x17000F95 RID: 3989
		// (get) Token: 0x0600306B RID: 12395 RVA: 0x000BF934 File Offset: 0x000BDB34
		[DebuggerNonUserCode]
		public bool HasRewardType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600306C RID: 12396 RVA: 0x000BF951 File Offset: 0x000BDB51
		[DebuggerNonUserCode]
		public void ClearRewardType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x0600306D RID: 12397 RVA: 0x000BF964 File Offset: 0x000BDB64
		// (set) Token: 0x0600306E RID: 12398 RVA: 0x000BF995 File Offset: 0x000BDB95
		[DebuggerNonUserCode]
		public int SnoItemReward
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int snoItemRewardDefaultValue;
				if (flag)
				{
					snoItemRewardDefaultValue = this.snoItemReward_;
				}
				else
				{
					snoItemRewardDefaultValue = ZoneProgressRewardData.SnoItemRewardDefaultValue;
				}
				return snoItemRewardDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoItemReward_ = value;
			}
		}

		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x0600306F RID: 12399 RVA: 0x000BF9B0 File Offset: 0x000BDBB0
		[DebuggerNonUserCode]
		public bool HasSnoItemReward
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003070 RID: 12400 RVA: 0x000BF9CD File Offset: 0x000BDBCD
		[DebuggerNonUserCode]
		public void ClearSnoItemReward()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x06003071 RID: 12401 RVA: 0x000BF9E0 File Offset: 0x000BDBE0
		// (set) Token: 0x06003072 RID: 12402 RVA: 0x000BFA11 File Offset: 0x000BDC11
		[DebuggerNonUserCode]
		public int SnoTrackedReward
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int snoTrackedRewardDefaultValue;
				if (flag)
				{
					snoTrackedRewardDefaultValue = this.snoTrackedReward_;
				}
				else
				{
					snoTrackedRewardDefaultValue = ZoneProgressRewardData.SnoTrackedRewardDefaultValue;
				}
				return snoTrackedRewardDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.snoTrackedReward_ = value;
			}
		}

		// Token: 0x17000F99 RID: 3993
		// (get) Token: 0x06003073 RID: 12403 RVA: 0x000BFA2C File Offset: 0x000BDC2C
		[DebuggerNonUserCode]
		public bool HasSnoTrackedReward
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06003074 RID: 12404 RVA: 0x000BFA49 File Offset: 0x000BDC49
		[DebuggerNonUserCode]
		public void ClearSnoTrackedReward()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x06003075 RID: 12405 RVA: 0x000BFA5C File Offset: 0x000BDC5C
		// (set) Token: 0x06003076 RID: 12406 RVA: 0x000BFA8D File Offset: 0x000BDC8D
		[DebuggerNonUserCode]
		public int GoldTier
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int goldTierDefaultValue;
				if (flag)
				{
					goldTierDefaultValue = this.goldTier_;
				}
				else
				{
					goldTierDefaultValue = ZoneProgressRewardData.GoldTierDefaultValue;
				}
				return goldTierDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.goldTier_ = value;
			}
		}

		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x06003077 RID: 12407 RVA: 0x000BFAA8 File Offset: 0x000BDCA8
		[DebuggerNonUserCode]
		public bool HasGoldTier
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06003078 RID: 12408 RVA: 0x000BFAC5 File Offset: 0x000BDCC5
		[DebuggerNonUserCode]
		public void ClearGoldTier()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x06003079 RID: 12409 RVA: 0x000BFAD8 File Offset: 0x000BDCD8
		// (set) Token: 0x0600307A RID: 12410 RVA: 0x000BFB0A File Offset: 0x000BDD0A
		[DebuggerNonUserCode]
		public int StaticGoldAmount
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				int staticGoldAmountDefaultValue;
				if (flag)
				{
					staticGoldAmountDefaultValue = this.staticGoldAmount_;
				}
				else
				{
					staticGoldAmountDefaultValue = ZoneProgressRewardData.StaticGoldAmountDefaultValue;
				}
				return staticGoldAmountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.staticGoldAmount_ = value;
			}
		}

		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x0600307B RID: 12411 RVA: 0x000BFB24 File Offset: 0x000BDD24
		[DebuggerNonUserCode]
		public bool HasStaticGoldAmount
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600307C RID: 12412 RVA: 0x000BFB42 File Offset: 0x000BDD42
		[DebuggerNonUserCode]
		public void ClearStaticGoldAmount()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x0600307D RID: 12413 RVA: 0x000BFB54 File Offset: 0x000BDD54
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ZoneProgressRewardData);
		}

		// Token: 0x0600307E RID: 12414 RVA: 0x000BFB74 File Offset: 0x000BDD74
		[DebuggerNonUserCode]
		public bool Equals(ZoneProgressRewardData other)
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
					bool flag4 = this.RewardType != other.RewardType;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoItemReward != other.SnoItemReward;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.SnoTrackedReward != other.SnoTrackedReward;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.GoldTier != other.GoldTier;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.StaticGoldAmount != other.StaticGoldAmount;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600307F RID: 12415 RVA: 0x000BFC40 File Offset: 0x000BDE40
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasRewardType = this.HasRewardType;
			if (hasRewardType)
			{
				num ^= this.RewardType.GetHashCode();
			}
			bool hasSnoItemReward = this.HasSnoItemReward;
			if (hasSnoItemReward)
			{
				num ^= this.SnoItemReward.GetHashCode();
			}
			bool hasSnoTrackedReward = this.HasSnoTrackedReward;
			if (hasSnoTrackedReward)
			{
				num ^= this.SnoTrackedReward.GetHashCode();
			}
			bool hasGoldTier = this.HasGoldTier;
			if (hasGoldTier)
			{
				num ^= this.GoldTier.GetHashCode();
			}
			bool hasStaticGoldAmount = this.HasStaticGoldAmount;
			if (hasStaticGoldAmount)
			{
				num ^= this.StaticGoldAmount.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003080 RID: 12416 RVA: 0x000BFD04 File Offset: 0x000BDF04
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003081 RID: 12417 RVA: 0x000BFD1C File Offset: 0x000BDF1C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003082 RID: 12418 RVA: 0x000BFD28 File Offset: 0x000BDF28
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasRewardType = this.HasRewardType;
			if (hasRewardType)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RewardType);
			}
			bool hasSnoItemReward = this.HasSnoItemReward;
			if (hasSnoItemReward)
			{
				output.WriteRawTag(21);
				output.WriteSFixed32(this.SnoItemReward);
			}
			bool hasSnoTrackedReward = this.HasSnoTrackedReward;
			if (hasSnoTrackedReward)
			{
				output.WriteRawTag(29);
				output.WriteSFixed32(this.SnoTrackedReward);
			}
			bool hasGoldTier = this.HasGoldTier;
			if (hasGoldTier)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.GoldTier);
			}
			bool hasStaticGoldAmount = this.HasStaticGoldAmount;
			if (hasStaticGoldAmount)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.StaticGoldAmount);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003083 RID: 12419 RVA: 0x000BFE00 File Offset: 0x000BE000
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasRewardType = this.HasRewardType;
			if (hasRewardType)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardType);
			}
			bool hasSnoItemReward = this.HasSnoItemReward;
			if (hasSnoItemReward)
			{
				num += 5;
			}
			bool hasSnoTrackedReward = this.HasSnoTrackedReward;
			if (hasSnoTrackedReward)
			{
				num += 5;
			}
			bool hasGoldTier = this.HasGoldTier;
			if (hasGoldTier)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GoldTier);
			}
			bool hasStaticGoldAmount = this.HasStaticGoldAmount;
			if (hasStaticGoldAmount)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StaticGoldAmount);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003084 RID: 12420 RVA: 0x000BFEB0 File Offset: 0x000BE0B0
		[DebuggerNonUserCode]
		public void MergeFrom(ZoneProgressRewardData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasRewardType = other.HasRewardType;
				if (hasRewardType)
				{
					this.RewardType = other.RewardType;
				}
				bool hasSnoItemReward = other.HasSnoItemReward;
				if (hasSnoItemReward)
				{
					this.SnoItemReward = other.SnoItemReward;
				}
				bool hasSnoTrackedReward = other.HasSnoTrackedReward;
				if (hasSnoTrackedReward)
				{
					this.SnoTrackedReward = other.SnoTrackedReward;
				}
				bool hasGoldTier = other.HasGoldTier;
				if (hasGoldTier)
				{
					this.GoldTier = other.GoldTier;
				}
				bool hasStaticGoldAmount = other.HasStaticGoldAmount;
				if (hasStaticGoldAmount)
				{
					this.StaticGoldAmount = other.StaticGoldAmount;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003085 RID: 12421 RVA: 0x000BFF64 File Offset: 0x000BE164
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003086 RID: 12422 RVA: 0x000BFF70 File Offset: 0x000BE170
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
							goto IL_0032;
						}
						this.SnoItemReward = input.ReadSFixed32();
					}
					else
					{
						this.RewardType = input.ReadInt32();
					}
				}
				else if (num3 != 29U)
				{
					if (num3 != 32U)
					{
						if (num3 != 40U)
						{
							goto IL_0032;
						}
						this.StaticGoldAmount = input.ReadInt32();
					}
					else
					{
						this.GoldTier = input.ReadInt32();
					}
				}
				else
				{
					this.SnoTrackedReward = input.ReadSFixed32();
				}
				continue;
				IL_0032:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400160B RID: 5643
		private static readonly MessageParser<ZoneProgressRewardData> _parser = new MessageParser<ZoneProgressRewardData>(() => new ZoneProgressRewardData());

		// Token: 0x0400160C RID: 5644
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400160D RID: 5645
		private int _hasBits0;

		// Token: 0x0400160E RID: 5646
		public const int RewardTypeFieldNumber = 1;

		// Token: 0x0400160F RID: 5647
		private static readonly int RewardTypeDefaultValue = 0;

		// Token: 0x04001610 RID: 5648
		private int rewardType_;

		// Token: 0x04001611 RID: 5649
		public const int SnoItemRewardFieldNumber = 2;

		// Token: 0x04001612 RID: 5650
		private static readonly int SnoItemRewardDefaultValue = 0;

		// Token: 0x04001613 RID: 5651
		private int snoItemReward_;

		// Token: 0x04001614 RID: 5652
		public const int SnoTrackedRewardFieldNumber = 3;

		// Token: 0x04001615 RID: 5653
		private static readonly int SnoTrackedRewardDefaultValue = 0;

		// Token: 0x04001616 RID: 5654
		private int snoTrackedReward_;

		// Token: 0x04001617 RID: 5655
		public const int GoldTierFieldNumber = 4;

		// Token: 0x04001618 RID: 5656
		private static readonly int GoldTierDefaultValue = 0;

		// Token: 0x04001619 RID: 5657
		private int goldTier_;

		// Token: 0x0400161A RID: 5658
		public const int StaticGoldAmountFieldNumber = 5;

		// Token: 0x0400161B RID: 5659
		private static readonly int StaticGoldAmountDefaultValue = 0;

		// Token: 0x0400161C RID: 5660
		private int staticGoldAmount_;
	}
}
