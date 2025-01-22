using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Game.V1
{
	// Token: 0x020002F2 RID: 754
	public sealed class Item : IMessage<Item>, IMessage, IEquatable<Item>, IDeepCloneable<Item>, IBufferMessage
	{
		// Token: 0x17001955 RID: 6485
		// (get) Token: 0x06004F76 RID: 20342 RVA: 0x00131268 File Offset: 0x0012F468
		[DebuggerNonUserCode]
		public static MessageParser<Item> Parser
		{
			get
			{
				return Item._parser;
			}
		}

		// Token: 0x17001956 RID: 6486
		// (get) Token: 0x06004F77 RID: 20343 RVA: 0x00131280 File Offset: 0x0012F480
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ItemReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001957 RID: 6487
		// (get) Token: 0x06004F78 RID: 20344 RVA: 0x001312A4 File Offset: 0x0012F4A4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Item.Descriptor;
			}
		}

		// Token: 0x06004F79 RID: 20345 RVA: 0x001312BB File Offset: 0x0012F4BB
		[DebuggerNonUserCode]
		public Item()
		{
		}

		// Token: 0x06004F7A RID: 20346 RVA: 0x001312C8 File Offset: 0x0012F4C8
		[DebuggerNonUserCode]
		public Item(Item other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoHandle_ = other.snoHandle_;
			this.itemPower_ = other.itemPower_;
			this.qualityLevel_ = other.qualityLevel_;
			this.attackDefenseBonusRoll_ = other.attackDefenseBonusRoll_;
			this.bodySlot_ = other.bodySlot_;
			this.itemId_ = other.itemId_;
			this.generator_ = other.generator_;
			this.itemQualityModifier_ = other.itemQualityModifier_;
			this.snoLegendaryAffix_ = other.snoLegendaryAffix_;
			this.snoImbuedAffix_ = other.snoImbuedAffix_;
			this.snoReplacedAffix_ = other.snoReplacedAffix_;
			this.nightmareDungeonInfo_ = ((other.nightmareDungeonInfo_ != null) ? other.nightmareDungeonInfo_.Clone() : null);
			this.itemPowerBonus_ = other.itemPowerBonus_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004F7B RID: 20347 RVA: 0x001313A8 File Offset: 0x0012F5A8
		[DebuggerNonUserCode]
		public Item Clone()
		{
			return new Item(this);
		}

		// Token: 0x17001958 RID: 6488
		// (get) Token: 0x06004F7C RID: 20348 RVA: 0x001313C0 File Offset: 0x0012F5C0
		// (set) Token: 0x06004F7D RID: 20349 RVA: 0x001313F1 File Offset: 0x0012F5F1
		[DebuggerNonUserCode]
		public int SnoHandle
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoHandleDefaultValue;
				if (flag)
				{
					snoHandleDefaultValue = this.snoHandle_;
				}
				else
				{
					snoHandleDefaultValue = Item.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x17001959 RID: 6489
		// (get) Token: 0x06004F7E RID: 20350 RVA: 0x0013140C File Offset: 0x0012F60C
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004F7F RID: 20351 RVA: 0x00131429 File Offset: 0x0012F629
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700195A RID: 6490
		// (get) Token: 0x06004F80 RID: 20352 RVA: 0x0013143C File Offset: 0x0012F63C
		// (set) Token: 0x06004F81 RID: 20353 RVA: 0x0013146D File Offset: 0x0012F66D
		[DebuggerNonUserCode]
		public int ItemPower
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int itemPowerDefaultValue;
				if (flag)
				{
					itemPowerDefaultValue = this.itemPower_;
				}
				else
				{
					itemPowerDefaultValue = Item.ItemPowerDefaultValue;
				}
				return itemPowerDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.itemPower_ = value;
			}
		}

		// Token: 0x1700195B RID: 6491
		// (get) Token: 0x06004F82 RID: 20354 RVA: 0x00131488 File Offset: 0x0012F688
		[DebuggerNonUserCode]
		public bool HasItemPower
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004F83 RID: 20355 RVA: 0x001314A5 File Offset: 0x0012F6A5
		[DebuggerNonUserCode]
		public void ClearItemPower()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700195C RID: 6492
		// (get) Token: 0x06004F84 RID: 20356 RVA: 0x001314B8 File Offset: 0x0012F6B8
		// (set) Token: 0x06004F85 RID: 20357 RVA: 0x001314E9 File Offset: 0x0012F6E9
		[DebuggerNonUserCode]
		public int QualityLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int qualityLevelDefaultValue;
				if (flag)
				{
					qualityLevelDefaultValue = this.qualityLevel_;
				}
				else
				{
					qualityLevelDefaultValue = Item.QualityLevelDefaultValue;
				}
				return qualityLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.qualityLevel_ = value;
			}
		}

		// Token: 0x1700195D RID: 6493
		// (get) Token: 0x06004F86 RID: 20358 RVA: 0x00131504 File Offset: 0x0012F704
		[DebuggerNonUserCode]
		public bool HasQualityLevel
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06004F87 RID: 20359 RVA: 0x00131521 File Offset: 0x0012F721
		[DebuggerNonUserCode]
		public void ClearQualityLevel()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x1700195E RID: 6494
		// (get) Token: 0x06004F88 RID: 20360 RVA: 0x00131534 File Offset: 0x0012F734
		// (set) Token: 0x06004F89 RID: 20361 RVA: 0x00131565 File Offset: 0x0012F765
		[DebuggerNonUserCode]
		public float AttackDefenseBonusRoll
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				float attackDefenseBonusRollDefaultValue;
				if (flag)
				{
					attackDefenseBonusRollDefaultValue = this.attackDefenseBonusRoll_;
				}
				else
				{
					attackDefenseBonusRollDefaultValue = Item.AttackDefenseBonusRollDefaultValue;
				}
				return attackDefenseBonusRollDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.attackDefenseBonusRoll_ = value;
			}
		}

		// Token: 0x1700195F RID: 6495
		// (get) Token: 0x06004F8A RID: 20362 RVA: 0x00131580 File Offset: 0x0012F780
		[DebuggerNonUserCode]
		public bool HasAttackDefenseBonusRoll
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06004F8B RID: 20363 RVA: 0x0013159D File Offset: 0x0012F79D
		[DebuggerNonUserCode]
		public void ClearAttackDefenseBonusRoll()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17001960 RID: 6496
		// (get) Token: 0x06004F8C RID: 20364 RVA: 0x001315B0 File Offset: 0x0012F7B0
		// (set) Token: 0x06004F8D RID: 20365 RVA: 0x001315E2 File Offset: 0x0012F7E2
		[DebuggerNonUserCode]
		public int BodySlot
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				int bodySlotDefaultValue;
				if (flag)
				{
					bodySlotDefaultValue = this.bodySlot_;
				}
				else
				{
					bodySlotDefaultValue = Item.BodySlotDefaultValue;
				}
				return bodySlotDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.bodySlot_ = value;
			}
		}

		// Token: 0x17001961 RID: 6497
		// (get) Token: 0x06004F8E RID: 20366 RVA: 0x001315FC File Offset: 0x0012F7FC
		[DebuggerNonUserCode]
		public bool HasBodySlot
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06004F8F RID: 20367 RVA: 0x0013161A File Offset: 0x0012F81A
		[DebuggerNonUserCode]
		public void ClearBodySlot()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17001962 RID: 6498
		// (get) Token: 0x06004F90 RID: 20368 RVA: 0x0013162C File Offset: 0x0012F82C
		// (set) Token: 0x06004F91 RID: 20369 RVA: 0x0013164D File Offset: 0x0012F84D
		[DebuggerNonUserCode]
		public string ItemId
		{
			get
			{
				return this.itemId_ ?? Item.ItemIdDefaultValue;
			}
			set
			{
				this.itemId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001963 RID: 6499
		// (get) Token: 0x06004F92 RID: 20370 RVA: 0x00131664 File Offset: 0x0012F864
		[DebuggerNonUserCode]
		public bool HasItemId
		{
			get
			{
				return this.itemId_ != null;
			}
		}

		// Token: 0x06004F93 RID: 20371 RVA: 0x0013167F File Offset: 0x0012F87F
		[DebuggerNonUserCode]
		public void ClearItemId()
		{
			this.itemId_ = null;
		}

		// Token: 0x17001964 RID: 6500
		// (get) Token: 0x06004F94 RID: 20372 RVA: 0x0013168C File Offset: 0x0012F88C
		// (set) Token: 0x06004F95 RID: 20373 RVA: 0x001316AD File Offset: 0x0012F8AD
		[DebuggerNonUserCode]
		public ByteString Generator
		{
			get
			{
				return this.generator_ ?? Item.GeneratorDefaultValue;
			}
			set
			{
				this.generator_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17001965 RID: 6501
		// (get) Token: 0x06004F96 RID: 20374 RVA: 0x001316C4 File Offset: 0x0012F8C4
		[DebuggerNonUserCode]
		public bool HasGenerator
		{
			get
			{
				return this.generator_ != null;
			}
		}

		// Token: 0x06004F97 RID: 20375 RVA: 0x001316E2 File Offset: 0x0012F8E2
		[DebuggerNonUserCode]
		public void ClearGenerator()
		{
			this.generator_ = null;
		}

		// Token: 0x17001966 RID: 6502
		// (get) Token: 0x06004F98 RID: 20376 RVA: 0x001316EC File Offset: 0x0012F8EC
		// (set) Token: 0x06004F99 RID: 20377 RVA: 0x0013171E File Offset: 0x0012F91E
		[DebuggerNonUserCode]
		public int ItemQualityModifier
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				int itemQualityModifierDefaultValue;
				if (flag)
				{
					itemQualityModifierDefaultValue = this.itemQualityModifier_;
				}
				else
				{
					itemQualityModifierDefaultValue = Item.ItemQualityModifierDefaultValue;
				}
				return itemQualityModifierDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.itemQualityModifier_ = value;
			}
		}

		// Token: 0x17001967 RID: 6503
		// (get) Token: 0x06004F9A RID: 20378 RVA: 0x00131738 File Offset: 0x0012F938
		[DebuggerNonUserCode]
		public bool HasItemQualityModifier
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06004F9B RID: 20379 RVA: 0x00131756 File Offset: 0x0012F956
		[DebuggerNonUserCode]
		public void ClearItemQualityModifier()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17001968 RID: 6504
		// (get) Token: 0x06004F9C RID: 20380 RVA: 0x00131768 File Offset: 0x0012F968
		// (set) Token: 0x06004F9D RID: 20381 RVA: 0x0013179A File Offset: 0x0012F99A
		[DebuggerNonUserCode]
		public int SnoLegendaryAffix
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				int snoLegendaryAffixDefaultValue;
				if (flag)
				{
					snoLegendaryAffixDefaultValue = this.snoLegendaryAffix_;
				}
				else
				{
					snoLegendaryAffixDefaultValue = Item.SnoLegendaryAffixDefaultValue;
				}
				return snoLegendaryAffixDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.snoLegendaryAffix_ = value;
			}
		}

		// Token: 0x17001969 RID: 6505
		// (get) Token: 0x06004F9E RID: 20382 RVA: 0x001317B4 File Offset: 0x0012F9B4
		[DebuggerNonUserCode]
		public bool HasSnoLegendaryAffix
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06004F9F RID: 20383 RVA: 0x001317D2 File Offset: 0x0012F9D2
		[DebuggerNonUserCode]
		public void ClearSnoLegendaryAffix()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x1700196A RID: 6506
		// (get) Token: 0x06004FA0 RID: 20384 RVA: 0x001317E4 File Offset: 0x0012F9E4
		// (set) Token: 0x06004FA1 RID: 20385 RVA: 0x00131819 File Offset: 0x0012FA19
		[DebuggerNonUserCode]
		public int SnoImbuedAffix
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				int snoImbuedAffixDefaultValue;
				if (flag)
				{
					snoImbuedAffixDefaultValue = this.snoImbuedAffix_;
				}
				else
				{
					snoImbuedAffixDefaultValue = Item.SnoImbuedAffixDefaultValue;
				}
				return snoImbuedAffixDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.snoImbuedAffix_ = value;
			}
		}

		// Token: 0x1700196B RID: 6507
		// (get) Token: 0x06004FA2 RID: 20386 RVA: 0x00131838 File Offset: 0x0012FA38
		[DebuggerNonUserCode]
		public bool HasSnoImbuedAffix
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x06004FA3 RID: 20387 RVA: 0x00131859 File Offset: 0x0012FA59
		[DebuggerNonUserCode]
		public void ClearSnoImbuedAffix()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x1700196C RID: 6508
		// (get) Token: 0x06004FA4 RID: 20388 RVA: 0x00131870 File Offset: 0x0012FA70
		// (set) Token: 0x06004FA5 RID: 20389 RVA: 0x001318A5 File Offset: 0x0012FAA5
		[DebuggerNonUserCode]
		public int SnoReplacedAffix
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				int snoReplacedAffixDefaultValue;
				if (flag)
				{
					snoReplacedAffixDefaultValue = this.snoReplacedAffix_;
				}
				else
				{
					snoReplacedAffixDefaultValue = Item.SnoReplacedAffixDefaultValue;
				}
				return snoReplacedAffixDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.snoReplacedAffix_ = value;
			}
		}

		// Token: 0x1700196D RID: 6509
		// (get) Token: 0x06004FA6 RID: 20390 RVA: 0x001318C4 File Offset: 0x0012FAC4
		[DebuggerNonUserCode]
		public bool HasSnoReplacedAffix
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x06004FA7 RID: 20391 RVA: 0x001318E5 File Offset: 0x0012FAE5
		[DebuggerNonUserCode]
		public void ClearSnoReplacedAffix()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x1700196E RID: 6510
		// (get) Token: 0x06004FA8 RID: 20392 RVA: 0x001318FC File Offset: 0x0012FAFC
		// (set) Token: 0x06004FA9 RID: 20393 RVA: 0x00131914 File Offset: 0x0012FB14
		[DebuggerNonUserCode]
		public NightmareDungeonInfo NightmareDungeonInfo
		{
			get
			{
				return this.nightmareDungeonInfo_;
			}
			set
			{
				this.nightmareDungeonInfo_ = value;
			}
		}

		// Token: 0x1700196F RID: 6511
		// (get) Token: 0x06004FAA RID: 20394 RVA: 0x00131920 File Offset: 0x0012FB20
		// (set) Token: 0x06004FAB RID: 20395 RVA: 0x00131955 File Offset: 0x0012FB55
		[DebuggerNonUserCode]
		public int ItemPowerBonus
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				int itemPowerBonusDefaultValue;
				if (flag)
				{
					itemPowerBonusDefaultValue = this.itemPowerBonus_;
				}
				else
				{
					itemPowerBonusDefaultValue = Item.ItemPowerBonusDefaultValue;
				}
				return itemPowerBonusDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.itemPowerBonus_ = value;
			}
		}

		// Token: 0x17001970 RID: 6512
		// (get) Token: 0x06004FAC RID: 20396 RVA: 0x00131974 File Offset: 0x0012FB74
		[DebuggerNonUserCode]
		public bool HasItemPowerBonus
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x06004FAD RID: 20397 RVA: 0x00131995 File Offset: 0x0012FB95
		[DebuggerNonUserCode]
		public void ClearItemPowerBonus()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x06004FAE RID: 20398 RVA: 0x001319AC File Offset: 0x0012FBAC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Item);
		}

		// Token: 0x06004FAF RID: 20399 RVA: 0x001319CC File Offset: 0x0012FBCC
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
					bool flag4 = this.SnoHandle != other.SnoHandle;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ItemPower != other.ItemPower;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.QualityLevel != other.QualityLevel;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.AttackDefenseBonusRoll, other.AttackDefenseBonusRoll);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.BodySlot != other.BodySlot;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.ItemId != other.ItemId;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.Generator != other.Generator;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.ItemQualityModifier != other.ItemQualityModifier;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.SnoLegendaryAffix != other.SnoLegendaryAffix;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.SnoImbuedAffix != other.SnoImbuedAffix;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.SnoReplacedAffix != other.SnoReplacedAffix;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = !object.Equals(this.NightmareDungeonInfo, other.NightmareDungeonInfo);
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = this.ItemPowerBonus != other.ItemPowerBonus;
																	flag2 = !flag16 && object.Equals(this._unknownFields, other._unknownFields);
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
				}
			}
			return flag2;
		}

		// Token: 0x06004FB0 RID: 20400 RVA: 0x00131B94 File Offset: 0x0012FD94
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num ^= this.SnoHandle.GetHashCode();
			}
			bool hasItemPower = this.HasItemPower;
			if (hasItemPower)
			{
				num ^= this.ItemPower.GetHashCode();
			}
			bool hasQualityLevel = this.HasQualityLevel;
			if (hasQualityLevel)
			{
				num ^= this.QualityLevel.GetHashCode();
			}
			bool hasAttackDefenseBonusRoll = this.HasAttackDefenseBonusRoll;
			if (hasAttackDefenseBonusRoll)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.AttackDefenseBonusRoll);
			}
			bool hasBodySlot = this.HasBodySlot;
			if (hasBodySlot)
			{
				num ^= this.BodySlot.GetHashCode();
			}
			bool hasItemId = this.HasItemId;
			if (hasItemId)
			{
				num ^= this.ItemId.GetHashCode();
			}
			bool hasGenerator = this.HasGenerator;
			if (hasGenerator)
			{
				num ^= this.Generator.GetHashCode();
			}
			bool hasItemQualityModifier = this.HasItemQualityModifier;
			if (hasItemQualityModifier)
			{
				num ^= this.ItemQualityModifier.GetHashCode();
			}
			bool hasSnoLegendaryAffix = this.HasSnoLegendaryAffix;
			if (hasSnoLegendaryAffix)
			{
				num ^= this.SnoLegendaryAffix.GetHashCode();
			}
			bool hasSnoImbuedAffix = this.HasSnoImbuedAffix;
			if (hasSnoImbuedAffix)
			{
				num ^= this.SnoImbuedAffix.GetHashCode();
			}
			bool hasSnoReplacedAffix = this.HasSnoReplacedAffix;
			if (hasSnoReplacedAffix)
			{
				num ^= this.SnoReplacedAffix.GetHashCode();
			}
			bool flag = this.nightmareDungeonInfo_ != null;
			if (flag)
			{
				num ^= this.NightmareDungeonInfo.GetHashCode();
			}
			bool hasItemPowerBonus = this.HasItemPowerBonus;
			if (hasItemPowerBonus)
			{
				num ^= this.ItemPowerBonus.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004FB1 RID: 20401 RVA: 0x00131D3C File Offset: 0x0012FF3C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004FB2 RID: 20402 RVA: 0x00131D54 File Offset: 0x0012FF54
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004FB3 RID: 20403 RVA: 0x00131D60 File Offset: 0x0012FF60
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				output.WriteRawTag(8);
				output.WriteSInt32(this.SnoHandle);
			}
			bool hasItemPower = this.HasItemPower;
			if (hasItemPower)
			{
				output.WriteRawTag(16);
				output.WriteSInt32(this.ItemPower);
			}
			bool hasQualityLevel = this.HasQualityLevel;
			if (hasQualityLevel)
			{
				output.WriteRawTag(24);
				output.WriteSInt32(this.QualityLevel);
			}
			bool hasAttackDefenseBonusRoll = this.HasAttackDefenseBonusRoll;
			if (hasAttackDefenseBonusRoll)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.AttackDefenseBonusRoll);
			}
			bool hasBodySlot = this.HasBodySlot;
			if (hasBodySlot)
			{
				output.WriteRawTag(40);
				output.WriteSInt32(this.BodySlot);
			}
			bool hasItemId = this.HasItemId;
			if (hasItemId)
			{
				output.WriteRawTag(50);
				output.WriteString(this.ItemId);
			}
			bool hasGenerator = this.HasGenerator;
			if (hasGenerator)
			{
				output.WriteRawTag(58);
				output.WriteBytes(this.Generator);
			}
			bool hasItemQualityModifier = this.HasItemQualityModifier;
			if (hasItemQualityModifier)
			{
				output.WriteRawTag(64);
				output.WriteSInt32(this.ItemQualityModifier);
			}
			bool hasSnoLegendaryAffix = this.HasSnoLegendaryAffix;
			if (hasSnoLegendaryAffix)
			{
				output.WriteRawTag(72);
				output.WriteSInt32(this.SnoLegendaryAffix);
			}
			bool hasSnoImbuedAffix = this.HasSnoImbuedAffix;
			if (hasSnoImbuedAffix)
			{
				output.WriteRawTag(80);
				output.WriteSInt32(this.SnoImbuedAffix);
			}
			bool hasSnoReplacedAffix = this.HasSnoReplacedAffix;
			if (hasSnoReplacedAffix)
			{
				output.WriteRawTag(88);
				output.WriteSInt32(this.SnoReplacedAffix);
			}
			bool flag = this.nightmareDungeonInfo_ != null;
			if (flag)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.NightmareDungeonInfo);
			}
			bool hasItemPowerBonus = this.HasItemPowerBonus;
			if (hasItemPowerBonus)
			{
				output.WriteRawTag(104);
				output.WriteSInt32(this.ItemPowerBonus);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004FB4 RID: 20404 RVA: 0x00131F5C File Offset: 0x0013015C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.SnoHandle);
			}
			bool hasItemPower = this.HasItemPower;
			if (hasItemPower)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.ItemPower);
			}
			bool hasQualityLevel = this.HasQualityLevel;
			if (hasQualityLevel)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.QualityLevel);
			}
			bool hasAttackDefenseBonusRoll = this.HasAttackDefenseBonusRoll;
			if (hasAttackDefenseBonusRoll)
			{
				num += 5;
			}
			bool hasBodySlot = this.HasBodySlot;
			if (hasBodySlot)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.BodySlot);
			}
			bool hasItemId = this.HasItemId;
			if (hasItemId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ItemId);
			}
			bool hasGenerator = this.HasGenerator;
			if (hasGenerator)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Generator);
			}
			bool hasItemQualityModifier = this.HasItemQualityModifier;
			if (hasItemQualityModifier)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.ItemQualityModifier);
			}
			bool hasSnoLegendaryAffix = this.HasSnoLegendaryAffix;
			if (hasSnoLegendaryAffix)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.SnoLegendaryAffix);
			}
			bool hasSnoImbuedAffix = this.HasSnoImbuedAffix;
			if (hasSnoImbuedAffix)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.SnoImbuedAffix);
			}
			bool hasSnoReplacedAffix = this.HasSnoReplacedAffix;
			if (hasSnoReplacedAffix)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.SnoReplacedAffix);
			}
			bool flag = this.nightmareDungeonInfo_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NightmareDungeonInfo);
			}
			bool hasItemPowerBonus = this.HasItemPowerBonus;
			if (hasItemPowerBonus)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.ItemPowerBonus);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004FB5 RID: 20405 RVA: 0x0013210C File Offset: 0x0013030C
		[DebuggerNonUserCode]
		public void MergeFrom(Item other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoHandle = other.HasSnoHandle;
				if (hasSnoHandle)
				{
					this.SnoHandle = other.SnoHandle;
				}
				bool hasItemPower = other.HasItemPower;
				if (hasItemPower)
				{
					this.ItemPower = other.ItemPower;
				}
				bool hasQualityLevel = other.HasQualityLevel;
				if (hasQualityLevel)
				{
					this.QualityLevel = other.QualityLevel;
				}
				bool hasAttackDefenseBonusRoll = other.HasAttackDefenseBonusRoll;
				if (hasAttackDefenseBonusRoll)
				{
					this.AttackDefenseBonusRoll = other.AttackDefenseBonusRoll;
				}
				bool hasBodySlot = other.HasBodySlot;
				if (hasBodySlot)
				{
					this.BodySlot = other.BodySlot;
				}
				bool hasItemId = other.HasItemId;
				if (hasItemId)
				{
					this.ItemId = other.ItemId;
				}
				bool hasGenerator = other.HasGenerator;
				if (hasGenerator)
				{
					this.Generator = other.Generator;
				}
				bool hasItemQualityModifier = other.HasItemQualityModifier;
				if (hasItemQualityModifier)
				{
					this.ItemQualityModifier = other.ItemQualityModifier;
				}
				bool hasSnoLegendaryAffix = other.HasSnoLegendaryAffix;
				if (hasSnoLegendaryAffix)
				{
					this.SnoLegendaryAffix = other.SnoLegendaryAffix;
				}
				bool hasSnoImbuedAffix = other.HasSnoImbuedAffix;
				if (hasSnoImbuedAffix)
				{
					this.SnoImbuedAffix = other.SnoImbuedAffix;
				}
				bool hasSnoReplacedAffix = other.HasSnoReplacedAffix;
				if (hasSnoReplacedAffix)
				{
					this.SnoReplacedAffix = other.SnoReplacedAffix;
				}
				bool flag2 = other.nightmareDungeonInfo_ != null;
				if (flag2)
				{
					bool flag3 = this.nightmareDungeonInfo_ == null;
					if (flag3)
					{
						this.NightmareDungeonInfo = new NightmareDungeonInfo();
					}
					this.NightmareDungeonInfo.MergeFrom(other.NightmareDungeonInfo);
				}
				bool hasItemPowerBonus = other.HasItemPowerBonus;
				if (hasItemPowerBonus)
				{
					this.ItemPowerBonus = other.ItemPowerBonus;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004FB6 RID: 20406 RVA: 0x001322BD File Offset: 0x001304BD
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004FB7 RID: 20407 RVA: 0x001322C8 File Offset: 0x001304C8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 50U)
				{
					if (num3 <= 24U)
					{
						if (num3 != 8U)
						{
							if (num3 != 16U)
							{
								if (num3 != 24U)
								{
									goto IL_00A0;
								}
								this.QualityLevel = input.ReadSInt32();
							}
							else
							{
								this.ItemPower = input.ReadSInt32();
							}
						}
						else
						{
							this.SnoHandle = input.ReadSInt32();
						}
					}
					else if (num3 != 37U)
					{
						if (num3 != 40U)
						{
							if (num3 != 50U)
							{
								goto IL_00A0;
							}
							this.ItemId = input.ReadString();
						}
						else
						{
							this.BodySlot = input.ReadSInt32();
						}
					}
					else
					{
						this.AttackDefenseBonusRoll = input.ReadFloat();
					}
				}
				else if (num3 <= 72U)
				{
					if (num3 != 58U)
					{
						if (num3 != 64U)
						{
							if (num3 != 72U)
							{
								goto IL_00A0;
							}
							this.SnoLegendaryAffix = input.ReadSInt32();
						}
						else
						{
							this.ItemQualityModifier = input.ReadSInt32();
						}
					}
					else
					{
						this.Generator = input.ReadBytes();
					}
				}
				else if (num3 <= 88U)
				{
					if (num3 != 80U)
					{
						if (num3 != 88U)
						{
							goto IL_00A0;
						}
						this.SnoReplacedAffix = input.ReadSInt32();
					}
					else
					{
						this.SnoImbuedAffix = input.ReadSInt32();
					}
				}
				else if (num3 != 98U)
				{
					if (num3 != 104U)
					{
						goto IL_00A0;
					}
					this.ItemPowerBonus = input.ReadSInt32();
				}
				else
				{
					bool flag = this.nightmareDungeonInfo_ == null;
					if (flag)
					{
						this.NightmareDungeonInfo = new NightmareDungeonInfo();
					}
					input.ReadMessage(this.NightmareDungeonInfo);
				}
				continue;
				IL_00A0:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040023AB RID: 9131
		private static readonly MessageParser<Item> _parser = new MessageParser<Item>(() => new Item());

		// Token: 0x040023AC RID: 9132
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023AD RID: 9133
		private int _hasBits0;

		// Token: 0x040023AE RID: 9134
		public const int SnoHandleFieldNumber = 1;

		// Token: 0x040023AF RID: 9135
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x040023B0 RID: 9136
		private int snoHandle_;

		// Token: 0x040023B1 RID: 9137
		public const int ItemPowerFieldNumber = 2;

		// Token: 0x040023B2 RID: 9138
		private static readonly int ItemPowerDefaultValue = 0;

		// Token: 0x040023B3 RID: 9139
		private int itemPower_;

		// Token: 0x040023B4 RID: 9140
		public const int QualityLevelFieldNumber = 3;

		// Token: 0x040023B5 RID: 9141
		private static readonly int QualityLevelDefaultValue = 0;

		// Token: 0x040023B6 RID: 9142
		private int qualityLevel_;

		// Token: 0x040023B7 RID: 9143
		public const int AttackDefenseBonusRollFieldNumber = 4;

		// Token: 0x040023B8 RID: 9144
		private static readonly float AttackDefenseBonusRollDefaultValue = 0f;

		// Token: 0x040023B9 RID: 9145
		private float attackDefenseBonusRoll_;

		// Token: 0x040023BA RID: 9146
		public const int BodySlotFieldNumber = 5;

		// Token: 0x040023BB RID: 9147
		private static readonly int BodySlotDefaultValue = 0;

		// Token: 0x040023BC RID: 9148
		private int bodySlot_;

		// Token: 0x040023BD RID: 9149
		public const int ItemIdFieldNumber = 6;

		// Token: 0x040023BE RID: 9150
		private static readonly string ItemIdDefaultValue = "";

		// Token: 0x040023BF RID: 9151
		private string itemId_;

		// Token: 0x040023C0 RID: 9152
		public const int GeneratorFieldNumber = 7;

		// Token: 0x040023C1 RID: 9153
		private static readonly ByteString GeneratorDefaultValue = ByteString.Empty;

		// Token: 0x040023C2 RID: 9154
		private ByteString generator_;

		// Token: 0x040023C3 RID: 9155
		public const int ItemQualityModifierFieldNumber = 8;

		// Token: 0x040023C4 RID: 9156
		private static readonly int ItemQualityModifierDefaultValue = 0;

		// Token: 0x040023C5 RID: 9157
		private int itemQualityModifier_;

		// Token: 0x040023C6 RID: 9158
		public const int SnoLegendaryAffixFieldNumber = 9;

		// Token: 0x040023C7 RID: 9159
		private static readonly int SnoLegendaryAffixDefaultValue = 0;

		// Token: 0x040023C8 RID: 9160
		private int snoLegendaryAffix_;

		// Token: 0x040023C9 RID: 9161
		public const int SnoImbuedAffixFieldNumber = 10;

		// Token: 0x040023CA RID: 9162
		private static readonly int SnoImbuedAffixDefaultValue = 0;

		// Token: 0x040023CB RID: 9163
		private int snoImbuedAffix_;

		// Token: 0x040023CC RID: 9164
		public const int SnoReplacedAffixFieldNumber = 11;

		// Token: 0x040023CD RID: 9165
		private static readonly int SnoReplacedAffixDefaultValue = 0;

		// Token: 0x040023CE RID: 9166
		private int snoReplacedAffix_;

		// Token: 0x040023CF RID: 9167
		public const int NightmareDungeonInfoFieldNumber = 12;

		// Token: 0x040023D0 RID: 9168
		private NightmareDungeonInfo nightmareDungeonInfo_;

		// Token: 0x040023D1 RID: 9169
		public const int ItemPowerBonusFieldNumber = 13;

		// Token: 0x040023D2 RID: 9170
		private static readonly int ItemPowerBonusDefaultValue = 0;

		// Token: 0x040023D3 RID: 9171
		private int itemPowerBonus_;
	}
}
