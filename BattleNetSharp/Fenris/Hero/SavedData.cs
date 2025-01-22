using System;
using System.Diagnostics;
using Fenris.Hireling;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x0200018F RID: 399
	public sealed class SavedData : IMessage<SavedData>, IMessage, IEquatable<SavedData>, IDeepCloneable<SavedData>, IBufferMessage
	{
		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x060029E8 RID: 10728 RVA: 0x000A3F68 File Offset: 0x000A2168
		[DebuggerNonUserCode]
		public static MessageParser<SavedData> Parser
		{
			get
			{
				return SavedData._parser;
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x060029E9 RID: 10729 RVA: 0x000A3F80 File Offset: 0x000A2180
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroReflection.Descriptor.MessageTypes[22];
			}
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x060029EA RID: 10730 RVA: 0x000A3FA4 File Offset: 0x000A21A4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SavedData.Descriptor;
			}
		}

		// Token: 0x060029EB RID: 10731 RVA: 0x000A3FBB File Offset: 0x000A21BB
		[DebuggerNonUserCode]
		public SavedData()
		{
		}

		// Token: 0x060029EC RID: 10732 RVA: 0x000A3FD0 File Offset: 0x000A21D0
		[DebuggerNonUserCode]
		public SavedData(SavedData other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.timePlayed_ = other.timePlayed_;
			this.hirelingSavedData_ = ((other.hirelingSavedData_ != null) ? other.hirelingSavedData_.Clone() : null);
			this.lastLevelTime_ = other.lastLevelTime_;
			this.lastWorldPlace_ = ((other.lastWorldPlace_ != null) ? other.lastWorldPlace_.Clone() : null);
			this.heroDeathWorldSno_ = other.heroDeathWorldSno_;
			this.heroDeathLocation_ = ((other.heroDeathLocation_ != null) ? other.heroDeathLocation_.Clone() : null);
			this.designerVariables_ = ((other.designerVariables_ != null) ? other.designerVariables_.Clone() : null);
			this.maxWorldTier_ = other.maxWorldTier_;
			this.bountyPoints_ = other.bountyPoints_.Clone();
			this.necroSkeletonWarriorCount_ = other.necroSkeletonWarriorCount_;
			this.necroSkeletonMageCount_ = other.necroSkeletonMageCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060029ED RID: 10733 RVA: 0x000A40CC File Offset: 0x000A22CC
		[DebuggerNonUserCode]
		public SavedData Clone()
		{
			return new SavedData(this);
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x060029EE RID: 10734 RVA: 0x000A40E4 File Offset: 0x000A22E4
		// (set) Token: 0x060029EF RID: 10735 RVA: 0x000A4115 File Offset: 0x000A2315
		[DebuggerNonUserCode]
		public uint TimePlayed
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint timePlayedDefaultValue;
				if (flag)
				{
					timePlayedDefaultValue = this.timePlayed_;
				}
				else
				{
					timePlayedDefaultValue = SavedData.TimePlayedDefaultValue;
				}
				return timePlayedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.timePlayed_ = value;
			}
		}

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x060029F0 RID: 10736 RVA: 0x000A4130 File Offset: 0x000A2330
		[DebuggerNonUserCode]
		public bool HasTimePlayed
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060029F1 RID: 10737 RVA: 0x000A414D File Offset: 0x000A234D
		[DebuggerNonUserCode]
		public void ClearTimePlayed()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x060029F2 RID: 10738 RVA: 0x000A4160 File Offset: 0x000A2360
		// (set) Token: 0x060029F3 RID: 10739 RVA: 0x000A4178 File Offset: 0x000A2378
		[DebuggerNonUserCode]
		public SavedData HirelingSavedData
		{
			get
			{
				return this.hirelingSavedData_;
			}
			set
			{
				this.hirelingSavedData_ = value;
			}
		}

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x060029F4 RID: 10740 RVA: 0x000A4184 File Offset: 0x000A2384
		// (set) Token: 0x060029F5 RID: 10741 RVA: 0x000A41B5 File Offset: 0x000A23B5
		[DebuggerNonUserCode]
		public uint LastLevelTime
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint lastLevelTimeDefaultValue;
				if (flag)
				{
					lastLevelTimeDefaultValue = this.lastLevelTime_;
				}
				else
				{
					lastLevelTimeDefaultValue = SavedData.LastLevelTimeDefaultValue;
				}
				return lastLevelTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.lastLevelTime_ = value;
			}
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x060029F6 RID: 10742 RVA: 0x000A41D0 File Offset: 0x000A23D0
		[DebuggerNonUserCode]
		public bool HasLastLevelTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060029F7 RID: 10743 RVA: 0x000A41ED File Offset: 0x000A23ED
		[DebuggerNonUserCode]
		public void ClearLastLevelTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x060029F8 RID: 10744 RVA: 0x000A4200 File Offset: 0x000A2400
		// (set) Token: 0x060029F9 RID: 10745 RVA: 0x000A4218 File Offset: 0x000A2418
		[DebuggerNonUserCode]
		public SavedWorldPlace LastWorldPlace
		{
			get
			{
				return this.lastWorldPlace_;
			}
			set
			{
				this.lastWorldPlace_ = value;
			}
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x060029FA RID: 10746 RVA: 0x000A4224 File Offset: 0x000A2424
		// (set) Token: 0x060029FB RID: 10747 RVA: 0x000A4255 File Offset: 0x000A2455
		[DebuggerNonUserCode]
		public int HeroDeathWorldSno
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int heroDeathWorldSnoDefaultValue;
				if (flag)
				{
					heroDeathWorldSnoDefaultValue = this.heroDeathWorldSno_;
				}
				else
				{
					heroDeathWorldSnoDefaultValue = SavedData.HeroDeathWorldSnoDefaultValue;
				}
				return heroDeathWorldSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.heroDeathWorldSno_ = value;
			}
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x060029FC RID: 10748 RVA: 0x000A4270 File Offset: 0x000A2470
		[DebuggerNonUserCode]
		public bool HasHeroDeathWorldSno
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060029FD RID: 10749 RVA: 0x000A428D File Offset: 0x000A248D
		[DebuggerNonUserCode]
		public void ClearHeroDeathWorldSno()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x060029FE RID: 10750 RVA: 0x000A42A0 File Offset: 0x000A24A0
		// (set) Token: 0x060029FF RID: 10751 RVA: 0x000A42B8 File Offset: 0x000A24B8
		[DebuggerNonUserCode]
		public Vector HeroDeathLocation
		{
			get
			{
				return this.heroDeathLocation_;
			}
			set
			{
				this.heroDeathLocation_ = value;
			}
		}

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x06002A00 RID: 10752 RVA: 0x000A42C4 File Offset: 0x000A24C4
		// (set) Token: 0x06002A01 RID: 10753 RVA: 0x000A42DC File Offset: 0x000A24DC
		[DebuggerNonUserCode]
		public AssetListExDesignerVariableDataStore DesignerVariables
		{
			get
			{
				return this.designerVariables_;
			}
			set
			{
				this.designerVariables_ = value;
			}
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x06002A02 RID: 10754 RVA: 0x000A42E8 File Offset: 0x000A24E8
		// (set) Token: 0x06002A03 RID: 10755 RVA: 0x000A4319 File Offset: 0x000A2519
		[DebuggerNonUserCode]
		public int MaxWorldTier
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int maxWorldTierDefaultValue;
				if (flag)
				{
					maxWorldTierDefaultValue = this.maxWorldTier_;
				}
				else
				{
					maxWorldTierDefaultValue = SavedData.MaxWorldTierDefaultValue;
				}
				return maxWorldTierDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.maxWorldTier_ = value;
			}
		}

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x06002A04 RID: 10756 RVA: 0x000A4334 File Offset: 0x000A2534
		[DebuggerNonUserCode]
		public bool HasMaxWorldTier
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06002A05 RID: 10757 RVA: 0x000A4351 File Offset: 0x000A2551
		[DebuggerNonUserCode]
		public void ClearMaxWorldTier()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x06002A06 RID: 10758 RVA: 0x000A4364 File Offset: 0x000A2564
		[DebuggerNonUserCode]
		public RepeatedField<uint> BountyPoints
		{
			get
			{
				return this.bountyPoints_;
			}
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x06002A07 RID: 10759 RVA: 0x000A437C File Offset: 0x000A257C
		// (set) Token: 0x06002A08 RID: 10760 RVA: 0x000A43AE File Offset: 0x000A25AE
		[DebuggerNonUserCode]
		public int NecroSkeletonWarriorCount
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				int necroSkeletonWarriorCountDefaultValue;
				if (flag)
				{
					necroSkeletonWarriorCountDefaultValue = this.necroSkeletonWarriorCount_;
				}
				else
				{
					necroSkeletonWarriorCountDefaultValue = SavedData.NecroSkeletonWarriorCountDefaultValue;
				}
				return necroSkeletonWarriorCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.necroSkeletonWarriorCount_ = value;
			}
		}

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x06002A09 RID: 10761 RVA: 0x000A43C8 File Offset: 0x000A25C8
		[DebuggerNonUserCode]
		public bool HasNecroSkeletonWarriorCount
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06002A0A RID: 10762 RVA: 0x000A43E6 File Offset: 0x000A25E6
		[DebuggerNonUserCode]
		public void ClearNecroSkeletonWarriorCount()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x06002A0B RID: 10763 RVA: 0x000A43F8 File Offset: 0x000A25F8
		// (set) Token: 0x06002A0C RID: 10764 RVA: 0x000A442A File Offset: 0x000A262A
		[DebuggerNonUserCode]
		public int NecroSkeletonMageCount
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				int necroSkeletonMageCountDefaultValue;
				if (flag)
				{
					necroSkeletonMageCountDefaultValue = this.necroSkeletonMageCount_;
				}
				else
				{
					necroSkeletonMageCountDefaultValue = SavedData.NecroSkeletonMageCountDefaultValue;
				}
				return necroSkeletonMageCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.necroSkeletonMageCount_ = value;
			}
		}

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x06002A0D RID: 10765 RVA: 0x000A4444 File Offset: 0x000A2644
		[DebuggerNonUserCode]
		public bool HasNecroSkeletonMageCount
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06002A0E RID: 10766 RVA: 0x000A4462 File Offset: 0x000A2662
		[DebuggerNonUserCode]
		public void ClearNecroSkeletonMageCount()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x06002A0F RID: 10767 RVA: 0x000A4474 File Offset: 0x000A2674
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SavedData);
		}

		// Token: 0x06002A10 RID: 10768 RVA: 0x000A4494 File Offset: 0x000A2694
		[DebuggerNonUserCode]
		public bool Equals(SavedData other)
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
					bool flag4 = this.TimePlayed != other.TimePlayed;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.HirelingSavedData, other.HirelingSavedData);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.LastLevelTime != other.LastLevelTime;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.LastWorldPlace, other.LastWorldPlace);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.HeroDeathWorldSno != other.HeroDeathWorldSno;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !object.Equals(this.HeroDeathLocation, other.HeroDeathLocation);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !object.Equals(this.DesignerVariables, other.DesignerVariables);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.MaxWorldTier != other.MaxWorldTier;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !this.bountyPoints_.Equals(other.bountyPoints_);
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.NecroSkeletonWarriorCount != other.NecroSkeletonWarriorCount;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.NecroSkeletonMageCount != other.NecroSkeletonMageCount;
															flag2 = !flag14 && object.Equals(this._unknownFields, other._unknownFields);
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
				}
			}
			return flag2;
		}

		// Token: 0x06002A11 RID: 10769 RVA: 0x000A4624 File Offset: 0x000A2824
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTimePlayed = this.HasTimePlayed;
			if (hasTimePlayed)
			{
				num ^= this.TimePlayed.GetHashCode();
			}
			bool flag = this.hirelingSavedData_ != null;
			if (flag)
			{
				num ^= this.HirelingSavedData.GetHashCode();
			}
			bool hasLastLevelTime = this.HasLastLevelTime;
			if (hasLastLevelTime)
			{
				num ^= this.LastLevelTime.GetHashCode();
			}
			bool flag2 = this.lastWorldPlace_ != null;
			if (flag2)
			{
				num ^= this.LastWorldPlace.GetHashCode();
			}
			bool hasHeroDeathWorldSno = this.HasHeroDeathWorldSno;
			if (hasHeroDeathWorldSno)
			{
				num ^= this.HeroDeathWorldSno.GetHashCode();
			}
			bool flag3 = this.heroDeathLocation_ != null;
			if (flag3)
			{
				num ^= this.HeroDeathLocation.GetHashCode();
			}
			bool flag4 = this.designerVariables_ != null;
			if (flag4)
			{
				num ^= this.DesignerVariables.GetHashCode();
			}
			bool hasMaxWorldTier = this.HasMaxWorldTier;
			if (hasMaxWorldTier)
			{
				num ^= this.MaxWorldTier.GetHashCode();
			}
			num ^= this.bountyPoints_.GetHashCode();
			bool hasNecroSkeletonWarriorCount = this.HasNecroSkeletonWarriorCount;
			if (hasNecroSkeletonWarriorCount)
			{
				num ^= this.NecroSkeletonWarriorCount.GetHashCode();
			}
			bool hasNecroSkeletonMageCount = this.HasNecroSkeletonMageCount;
			if (hasNecroSkeletonMageCount)
			{
				num ^= this.NecroSkeletonMageCount.GetHashCode();
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002A12 RID: 10770 RVA: 0x000A478C File Offset: 0x000A298C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002A13 RID: 10771 RVA: 0x000A47A4 File Offset: 0x000A29A4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002A14 RID: 10772 RVA: 0x000A47B0 File Offset: 0x000A29B0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTimePlayed = this.HasTimePlayed;
			if (hasTimePlayed)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.TimePlayed);
			}
			bool flag = this.hirelingSavedData_ != null;
			if (flag)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.HirelingSavedData);
			}
			bool hasLastLevelTime = this.HasLastLevelTime;
			if (hasLastLevelTime)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.LastLevelTime);
			}
			bool flag2 = this.lastWorldPlace_ != null;
			if (flag2)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.LastWorldPlace);
			}
			bool hasHeroDeathWorldSno = this.HasHeroDeathWorldSno;
			if (hasHeroDeathWorldSno)
			{
				output.WriteRawTag(109);
				output.WriteSFixed32(this.HeroDeathWorldSno);
			}
			bool flag3 = this.heroDeathLocation_ != null;
			if (flag3)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.HeroDeathLocation);
			}
			bool flag4 = this.designerVariables_ != null;
			if (flag4)
			{
				output.WriteRawTag(130, 1);
				output.WriteMessage(this.DesignerVariables);
			}
			bool hasMaxWorldTier = this.HasMaxWorldTier;
			if (hasMaxWorldTier)
			{
				output.WriteRawTag(136, 1);
				output.WriteInt32(this.MaxWorldTier);
			}
			this.bountyPoints_.WriteTo(ref output, SavedData._repeated_bountyPoints_codec);
			bool hasNecroSkeletonWarriorCount = this.HasNecroSkeletonWarriorCount;
			if (hasNecroSkeletonWarriorCount)
			{
				output.WriteRawTag(152, 1);
				output.WriteInt32(this.NecroSkeletonWarriorCount);
			}
			bool hasNecroSkeletonMageCount = this.HasNecroSkeletonMageCount;
			if (hasNecroSkeletonMageCount)
			{
				output.WriteRawTag(160, 1);
				output.WriteInt32(this.NecroSkeletonMageCount);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002A15 RID: 10773 RVA: 0x000A496C File Offset: 0x000A2B6C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTimePlayed = this.HasTimePlayed;
			if (hasTimePlayed)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TimePlayed);
			}
			bool flag = this.hirelingSavedData_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HirelingSavedData);
			}
			bool hasLastLevelTime = this.HasLastLevelTime;
			if (hasLastLevelTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LastLevelTime);
			}
			bool flag2 = this.lastWorldPlace_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LastWorldPlace);
			}
			bool hasHeroDeathWorldSno = this.HasHeroDeathWorldSno;
			if (hasHeroDeathWorldSno)
			{
				num += 5;
			}
			bool flag3 = this.heroDeathLocation_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HeroDeathLocation);
			}
			bool flag4 = this.designerVariables_ != null;
			if (flag4)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DesignerVariables);
			}
			bool hasMaxWorldTier = this.HasMaxWorldTier;
			if (hasMaxWorldTier)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.MaxWorldTier);
			}
			num += this.bountyPoints_.CalculateSize(SavedData._repeated_bountyPoints_codec);
			bool hasNecroSkeletonWarriorCount = this.HasNecroSkeletonWarriorCount;
			if (hasNecroSkeletonWarriorCount)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.NecroSkeletonWarriorCount);
			}
			bool hasNecroSkeletonMageCount = this.HasNecroSkeletonMageCount;
			if (hasNecroSkeletonMageCount)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.NecroSkeletonMageCount);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002A16 RID: 10774 RVA: 0x000A4ADC File Offset: 0x000A2CDC
		[DebuggerNonUserCode]
		public void MergeFrom(SavedData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTimePlayed = other.HasTimePlayed;
				if (hasTimePlayed)
				{
					this.TimePlayed = other.TimePlayed;
				}
				bool flag2 = other.hirelingSavedData_ != null;
				if (flag2)
				{
					bool flag3 = this.hirelingSavedData_ == null;
					if (flag3)
					{
						this.HirelingSavedData = new SavedData();
					}
					this.HirelingSavedData.MergeFrom(other.HirelingSavedData);
				}
				bool hasLastLevelTime = other.HasLastLevelTime;
				if (hasLastLevelTime)
				{
					this.LastLevelTime = other.LastLevelTime;
				}
				bool flag4 = other.lastWorldPlace_ != null;
				if (flag4)
				{
					bool flag5 = this.lastWorldPlace_ == null;
					if (flag5)
					{
						this.LastWorldPlace = new SavedWorldPlace();
					}
					this.LastWorldPlace.MergeFrom(other.LastWorldPlace);
				}
				bool hasHeroDeathWorldSno = other.HasHeroDeathWorldSno;
				if (hasHeroDeathWorldSno)
				{
					this.HeroDeathWorldSno = other.HeroDeathWorldSno;
				}
				bool flag6 = other.heroDeathLocation_ != null;
				if (flag6)
				{
					bool flag7 = this.heroDeathLocation_ == null;
					if (flag7)
					{
						this.HeroDeathLocation = new Vector();
					}
					this.HeroDeathLocation.MergeFrom(other.HeroDeathLocation);
				}
				bool flag8 = other.designerVariables_ != null;
				if (flag8)
				{
					bool flag9 = this.designerVariables_ == null;
					if (flag9)
					{
						this.DesignerVariables = new AssetListExDesignerVariableDataStore();
					}
					this.DesignerVariables.MergeFrom(other.DesignerVariables);
				}
				bool hasMaxWorldTier = other.HasMaxWorldTier;
				if (hasMaxWorldTier)
				{
					this.MaxWorldTier = other.MaxWorldTier;
				}
				this.bountyPoints_.Add(other.bountyPoints_);
				bool hasNecroSkeletonWarriorCount = other.HasNecroSkeletonWarriorCount;
				if (hasNecroSkeletonWarriorCount)
				{
					this.NecroSkeletonWarriorCount = other.NecroSkeletonWarriorCount;
				}
				bool hasNecroSkeletonMageCount = other.HasNecroSkeletonMageCount;
				if (hasNecroSkeletonMageCount)
				{
					this.NecroSkeletonMageCount = other.NecroSkeletonMageCount;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002A17 RID: 10775 RVA: 0x000A4CBD File Offset: 0x000A2EBD
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002A18 RID: 10776 RVA: 0x000A4CC8 File Offset: 0x000A2EC8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 114U)
				{
					if (num3 <= 32U)
					{
						if (num3 != 8U)
						{
							if (num3 != 26U)
							{
								if (num3 != 32U)
								{
									goto IL_00A6;
								}
								this.LastLevelTime = input.ReadUInt32();
							}
							else
							{
								bool flag = this.hirelingSavedData_ == null;
								if (flag)
								{
									this.HirelingSavedData = new SavedData();
								}
								input.ReadMessage(this.HirelingSavedData);
							}
						}
						else
						{
							this.TimePlayed = input.ReadUInt32();
						}
					}
					else if (num3 != 42U)
					{
						if (num3 != 109U)
						{
							if (num3 != 114U)
							{
								goto IL_00A6;
							}
							bool flag2 = this.heroDeathLocation_ == null;
							if (flag2)
							{
								this.HeroDeathLocation = new Vector();
							}
							input.ReadMessage(this.HeroDeathLocation);
						}
						else
						{
							this.HeroDeathWorldSno = input.ReadSFixed32();
						}
					}
					else
					{
						bool flag3 = this.lastWorldPlace_ == null;
						if (flag3)
						{
							this.LastWorldPlace = new SavedWorldPlace();
						}
						input.ReadMessage(this.LastWorldPlace);
					}
				}
				else
				{
					if (num3 <= 144U)
					{
						if (num3 == 130U)
						{
							bool flag4 = this.designerVariables_ == null;
							if (flag4)
							{
								this.DesignerVariables = new AssetListExDesignerVariableDataStore();
							}
							input.ReadMessage(this.DesignerVariables);
							continue;
						}
						if (num3 == 136U)
						{
							this.MaxWorldTier = input.ReadInt32();
							continue;
						}
						if (num3 != 144U)
						{
							goto IL_00A6;
						}
					}
					else if (num3 != 146U)
					{
						if (num3 == 152U)
						{
							this.NecroSkeletonWarriorCount = input.ReadInt32();
							continue;
						}
						if (num3 != 160U)
						{
							goto IL_00A6;
						}
						this.NecroSkeletonMageCount = input.ReadInt32();
						continue;
					}
					this.bountyPoints_.AddEntriesFrom(ref input, SavedData._repeated_bountyPoints_codec);
				}
				continue;
				IL_00A6:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040012CC RID: 4812
		private static readonly MessageParser<SavedData> _parser = new MessageParser<SavedData>(() => new SavedData());

		// Token: 0x040012CD RID: 4813
		private UnknownFieldSet _unknownFields;

		// Token: 0x040012CE RID: 4814
		private int _hasBits0;

		// Token: 0x040012CF RID: 4815
		public const int TimePlayedFieldNumber = 1;

		// Token: 0x040012D0 RID: 4816
		private static readonly uint TimePlayedDefaultValue = 0U;

		// Token: 0x040012D1 RID: 4817
		private uint timePlayed_;

		// Token: 0x040012D2 RID: 4818
		public const int HirelingSavedDataFieldNumber = 3;

		// Token: 0x040012D3 RID: 4819
		private SavedData hirelingSavedData_;

		// Token: 0x040012D4 RID: 4820
		public const int LastLevelTimeFieldNumber = 4;

		// Token: 0x040012D5 RID: 4821
		private static readonly uint LastLevelTimeDefaultValue = 0U;

		// Token: 0x040012D6 RID: 4822
		private uint lastLevelTime_;

		// Token: 0x040012D7 RID: 4823
		public const int LastWorldPlaceFieldNumber = 5;

		// Token: 0x040012D8 RID: 4824
		private SavedWorldPlace lastWorldPlace_;

		// Token: 0x040012D9 RID: 4825
		public const int HeroDeathWorldSnoFieldNumber = 13;

		// Token: 0x040012DA RID: 4826
		private static readonly int HeroDeathWorldSnoDefaultValue = -1;

		// Token: 0x040012DB RID: 4827
		private int heroDeathWorldSno_;

		// Token: 0x040012DC RID: 4828
		public const int HeroDeathLocationFieldNumber = 14;

		// Token: 0x040012DD RID: 4829
		private Vector heroDeathLocation_;

		// Token: 0x040012DE RID: 4830
		public const int DesignerVariablesFieldNumber = 16;

		// Token: 0x040012DF RID: 4831
		private AssetListExDesignerVariableDataStore designerVariables_;

		// Token: 0x040012E0 RID: 4832
		public const int MaxWorldTierFieldNumber = 17;

		// Token: 0x040012E1 RID: 4833
		private static readonly int MaxWorldTierDefaultValue = 0;

		// Token: 0x040012E2 RID: 4834
		private int maxWorldTier_;

		// Token: 0x040012E3 RID: 4835
		public const int BountyPointsFieldNumber = 18;

		// Token: 0x040012E4 RID: 4836
		private static readonly FieldCodec<uint> _repeated_bountyPoints_codec = FieldCodec.ForUInt32(144U);

		// Token: 0x040012E5 RID: 4837
		private readonly RepeatedField<uint> bountyPoints_ = new RepeatedField<uint>();

		// Token: 0x040012E6 RID: 4838
		public const int NecroSkeletonWarriorCountFieldNumber = 19;

		// Token: 0x040012E7 RID: 4839
		private static readonly int NecroSkeletonWarriorCountDefaultValue = 0;

		// Token: 0x040012E8 RID: 4840
		private int necroSkeletonWarriorCount_;

		// Token: 0x040012E9 RID: 4841
		public const int NecroSkeletonMageCountFieldNumber = 20;

		// Token: 0x040012EA RID: 4842
		private static readonly int NecroSkeletonMageCountDefaultValue = 0;

		// Token: 0x040012EB RID: 4843
		private int necroSkeletonMageCount_;
	}
}
