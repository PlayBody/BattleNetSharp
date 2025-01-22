using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.CS
{
	// Token: 0x02000200 RID: 512
	public sealed class ToolTip : IMessage<ToolTip>, IMessage, IEquatable<ToolTip>, IDeepCloneable<ToolTip>, IBufferMessage
	{
		// Token: 0x1700124A RID: 4682
		// (get) Token: 0x06003807 RID: 14343 RVA: 0x000DDE5C File Offset: 0x000DC05C
		[DebuggerNonUserCode]
		public static MessageParser<ToolTip> Parser
		{
			get
			{
				return ToolTip._parser;
			}
		}

		// Token: 0x1700124B RID: 4683
		// (get) Token: 0x06003808 RID: 14344 RVA: 0x000DDE74 File Offset: 0x000DC074
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CSReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700124C RID: 4684
		// (get) Token: 0x06003809 RID: 14345 RVA: 0x000DDE98 File Offset: 0x000DC098
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ToolTip.Descriptor;
			}
		}

		// Token: 0x0600380A RID: 14346 RVA: 0x000DDEAF File Offset: 0x000DC0AF
		[DebuggerNonUserCode]
		public ToolTip()
		{
		}

		// Token: 0x0600380B RID: 14347 RVA: 0x000DDEBC File Offset: 0x000DC0BC
		[DebuggerNonUserCode]
		public ToolTip(ToolTip other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.itemId_ = other.itemId_;
			this.itemQualityLevel_ = other.itemQualityLevel_;
			this.name_ = other.name_;
			this.type_ = other.type_;
			this.setItem_ = other.setItem_;
			this.flavor_ = other.flavor_;
			this.cost_ = other.cost_;
			this.durabilityDeprecated_ = other.durabilityDeprecated_;
			this.classReqs_ = other.classReqs_;
			this.requirements_ = other.requirements_;
			this.enhancementDeprecated_ = other.enhancementDeprecated_;
			this.stackCount_ = other.stackCount_;
			this.numSockets_ = other.numSockets_;
			this.filledSockets_ = other.filledSockets_;
			this.displayName_ = other.displayName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600380C RID: 14348 RVA: 0x000DDFA4 File Offset: 0x000DC1A4
		[DebuggerNonUserCode]
		public ToolTip Clone()
		{
			return new ToolTip(this);
		}

		// Token: 0x1700124D RID: 4685
		// (get) Token: 0x0600380D RID: 14349 RVA: 0x000DDFBC File Offset: 0x000DC1BC
		// (set) Token: 0x0600380E RID: 14350 RVA: 0x000DDFED File Offset: 0x000DC1ED
		[DebuggerNonUserCode]
		public ulong ItemId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong itemIdDefaultValue;
				if (flag)
				{
					itemIdDefaultValue = this.itemId_;
				}
				else
				{
					itemIdDefaultValue = ToolTip.ItemIdDefaultValue;
				}
				return itemIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.itemId_ = value;
			}
		}

		// Token: 0x1700124E RID: 4686
		// (get) Token: 0x0600380F RID: 14351 RVA: 0x000DE008 File Offset: 0x000DC208
		[DebuggerNonUserCode]
		public bool HasItemId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003810 RID: 14352 RVA: 0x000DE025 File Offset: 0x000DC225
		[DebuggerNonUserCode]
		public void ClearItemId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700124F RID: 4687
		// (get) Token: 0x06003811 RID: 14353 RVA: 0x000DE038 File Offset: 0x000DC238
		// (set) Token: 0x06003812 RID: 14354 RVA: 0x000DE069 File Offset: 0x000DC269
		[DebuggerNonUserCode]
		public uint ItemQualityLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint itemQualityLevelDefaultValue;
				if (flag)
				{
					itemQualityLevelDefaultValue = this.itemQualityLevel_;
				}
				else
				{
					itemQualityLevelDefaultValue = ToolTip.ItemQualityLevelDefaultValue;
				}
				return itemQualityLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.itemQualityLevel_ = value;
			}
		}

		// Token: 0x17001250 RID: 4688
		// (get) Token: 0x06003813 RID: 14355 RVA: 0x000DE084 File Offset: 0x000DC284
		[DebuggerNonUserCode]
		public bool HasItemQualityLevel
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003814 RID: 14356 RVA: 0x000DE0A1 File Offset: 0x000DC2A1
		[DebuggerNonUserCode]
		public void ClearItemQualityLevel()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001251 RID: 4689
		// (get) Token: 0x06003815 RID: 14357 RVA: 0x000DE0B4 File Offset: 0x000DC2B4
		// (set) Token: 0x06003816 RID: 14358 RVA: 0x000DE0D5 File Offset: 0x000DC2D5
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? ToolTip.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001252 RID: 4690
		// (get) Token: 0x06003817 RID: 14359 RVA: 0x000DE0EC File Offset: 0x000DC2EC
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06003818 RID: 14360 RVA: 0x000DE107 File Offset: 0x000DC307
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x17001253 RID: 4691
		// (get) Token: 0x06003819 RID: 14361 RVA: 0x000DE114 File Offset: 0x000DC314
		// (set) Token: 0x0600381A RID: 14362 RVA: 0x000DE135 File Offset: 0x000DC335
		[DebuggerNonUserCode]
		public string Type
		{
			get
			{
				return this.type_ ?? ToolTip.TypeDefaultValue;
			}
			set
			{
				this.type_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001254 RID: 4692
		// (get) Token: 0x0600381B RID: 14363 RVA: 0x000DE14C File Offset: 0x000DC34C
		[DebuggerNonUserCode]
		public bool HasType
		{
			get
			{
				return this.type_ != null;
			}
		}

		// Token: 0x0600381C RID: 14364 RVA: 0x000DE167 File Offset: 0x000DC367
		[DebuggerNonUserCode]
		public void ClearType()
		{
			this.type_ = null;
		}

		// Token: 0x17001255 RID: 4693
		// (get) Token: 0x0600381D RID: 14365 RVA: 0x000DE174 File Offset: 0x000DC374
		// (set) Token: 0x0600381E RID: 14366 RVA: 0x000DE1A5 File Offset: 0x000DC3A5
		[DebuggerNonUserCode]
		public int SetItem
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int setItemDefaultValue;
				if (flag)
				{
					setItemDefaultValue = this.setItem_;
				}
				else
				{
					setItemDefaultValue = ToolTip.SetItemDefaultValue;
				}
				return setItemDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.setItem_ = value;
			}
		}

		// Token: 0x17001256 RID: 4694
		// (get) Token: 0x0600381F RID: 14367 RVA: 0x000DE1C0 File Offset: 0x000DC3C0
		[DebuggerNonUserCode]
		public bool HasSetItem
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06003820 RID: 14368 RVA: 0x000DE1DD File Offset: 0x000DC3DD
		[DebuggerNonUserCode]
		public void ClearSetItem()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001257 RID: 4695
		// (get) Token: 0x06003821 RID: 14369 RVA: 0x000DE1F0 File Offset: 0x000DC3F0
		// (set) Token: 0x06003822 RID: 14370 RVA: 0x000DE211 File Offset: 0x000DC411
		[DebuggerNonUserCode]
		public string Flavor
		{
			get
			{
				return this.flavor_ ?? ToolTip.FlavorDefaultValue;
			}
			set
			{
				this.flavor_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001258 RID: 4696
		// (get) Token: 0x06003823 RID: 14371 RVA: 0x000DE228 File Offset: 0x000DC428
		[DebuggerNonUserCode]
		public bool HasFlavor
		{
			get
			{
				return this.flavor_ != null;
			}
		}

		// Token: 0x06003824 RID: 14372 RVA: 0x000DE243 File Offset: 0x000DC443
		[DebuggerNonUserCode]
		public void ClearFlavor()
		{
			this.flavor_ = null;
		}

		// Token: 0x17001259 RID: 4697
		// (get) Token: 0x06003825 RID: 14373 RVA: 0x000DE250 File Offset: 0x000DC450
		// (set) Token: 0x06003826 RID: 14374 RVA: 0x000DE271 File Offset: 0x000DC471
		[DebuggerNonUserCode]
		public string Cost
		{
			get
			{
				return this.cost_ ?? ToolTip.CostDefaultValue;
			}
			set
			{
				this.cost_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700125A RID: 4698
		// (get) Token: 0x06003827 RID: 14375 RVA: 0x000DE288 File Offset: 0x000DC488
		[DebuggerNonUserCode]
		public bool HasCost
		{
			get
			{
				return this.cost_ != null;
			}
		}

		// Token: 0x06003828 RID: 14376 RVA: 0x000DE2A3 File Offset: 0x000DC4A3
		[DebuggerNonUserCode]
		public void ClearCost()
		{
			this.cost_ = null;
		}

		// Token: 0x1700125B RID: 4699
		// (get) Token: 0x06003829 RID: 14377 RVA: 0x000DE2B0 File Offset: 0x000DC4B0
		// (set) Token: 0x0600382A RID: 14378 RVA: 0x000DE2D1 File Offset: 0x000DC4D1
		[DebuggerNonUserCode]
		public string DurabilityDeprecated
		{
			get
			{
				return this.durabilityDeprecated_ ?? ToolTip.DurabilityDeprecatedDefaultValue;
			}
			set
			{
				this.durabilityDeprecated_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700125C RID: 4700
		// (get) Token: 0x0600382B RID: 14379 RVA: 0x000DE2E8 File Offset: 0x000DC4E8
		[DebuggerNonUserCode]
		public bool HasDurabilityDeprecated
		{
			get
			{
				return this.durabilityDeprecated_ != null;
			}
		}

		// Token: 0x0600382C RID: 14380 RVA: 0x000DE303 File Offset: 0x000DC503
		[DebuggerNonUserCode]
		public void ClearDurabilityDeprecated()
		{
			this.durabilityDeprecated_ = null;
		}

		// Token: 0x1700125D RID: 4701
		// (get) Token: 0x0600382D RID: 14381 RVA: 0x000DE310 File Offset: 0x000DC510
		// (set) Token: 0x0600382E RID: 14382 RVA: 0x000DE331 File Offset: 0x000DC531
		[DebuggerNonUserCode]
		public string ClassReqs
		{
			get
			{
				return this.classReqs_ ?? ToolTip.ClassReqsDefaultValue;
			}
			set
			{
				this.classReqs_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700125E RID: 4702
		// (get) Token: 0x0600382F RID: 14383 RVA: 0x000DE348 File Offset: 0x000DC548
		[DebuggerNonUserCode]
		public bool HasClassReqs
		{
			get
			{
				return this.classReqs_ != null;
			}
		}

		// Token: 0x06003830 RID: 14384 RVA: 0x000DE363 File Offset: 0x000DC563
		[DebuggerNonUserCode]
		public void ClearClassReqs()
		{
			this.classReqs_ = null;
		}

		// Token: 0x1700125F RID: 4703
		// (get) Token: 0x06003831 RID: 14385 RVA: 0x000DE370 File Offset: 0x000DC570
		// (set) Token: 0x06003832 RID: 14386 RVA: 0x000DE391 File Offset: 0x000DC591
		[DebuggerNonUserCode]
		public string Requirements
		{
			get
			{
				return this.requirements_ ?? ToolTip.RequirementsDefaultValue;
			}
			set
			{
				this.requirements_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001260 RID: 4704
		// (get) Token: 0x06003833 RID: 14387 RVA: 0x000DE3A8 File Offset: 0x000DC5A8
		[DebuggerNonUserCode]
		public bool HasRequirements
		{
			get
			{
				return this.requirements_ != null;
			}
		}

		// Token: 0x06003834 RID: 14388 RVA: 0x000DE3C3 File Offset: 0x000DC5C3
		[DebuggerNonUserCode]
		public void ClearRequirements()
		{
			this.requirements_ = null;
		}

		// Token: 0x17001261 RID: 4705
		// (get) Token: 0x06003835 RID: 14389 RVA: 0x000DE3D0 File Offset: 0x000DC5D0
		// (set) Token: 0x06003836 RID: 14390 RVA: 0x000DE3F1 File Offset: 0x000DC5F1
		[DebuggerNonUserCode]
		public string EnhancementDeprecated
		{
			get
			{
				return this.enhancementDeprecated_ ?? ToolTip.EnhancementDeprecatedDefaultValue;
			}
			set
			{
				this.enhancementDeprecated_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001262 RID: 4706
		// (get) Token: 0x06003837 RID: 14391 RVA: 0x000DE408 File Offset: 0x000DC608
		[DebuggerNonUserCode]
		public bool HasEnhancementDeprecated
		{
			get
			{
				return this.enhancementDeprecated_ != null;
			}
		}

		// Token: 0x06003838 RID: 14392 RVA: 0x000DE423 File Offset: 0x000DC623
		[DebuggerNonUserCode]
		public void ClearEnhancementDeprecated()
		{
			this.enhancementDeprecated_ = null;
		}

		// Token: 0x17001263 RID: 4707
		// (get) Token: 0x06003839 RID: 14393 RVA: 0x000DE430 File Offset: 0x000DC630
		// (set) Token: 0x0600383A RID: 14394 RVA: 0x000DE461 File Offset: 0x000DC661
		[DebuggerNonUserCode]
		public ulong StackCount
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				ulong stackCountDefaultValue;
				if (flag)
				{
					stackCountDefaultValue = this.stackCount_;
				}
				else
				{
					stackCountDefaultValue = ToolTip.StackCountDefaultValue;
				}
				return stackCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.stackCount_ = value;
			}
		}

		// Token: 0x17001264 RID: 4708
		// (get) Token: 0x0600383B RID: 14395 RVA: 0x000DE47C File Offset: 0x000DC67C
		[DebuggerNonUserCode]
		public bool HasStackCount
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600383C RID: 14396 RVA: 0x000DE499 File Offset: 0x000DC699
		[DebuggerNonUserCode]
		public void ClearStackCount()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17001265 RID: 4709
		// (get) Token: 0x0600383D RID: 14397 RVA: 0x000DE4AC File Offset: 0x000DC6AC
		// (set) Token: 0x0600383E RID: 14398 RVA: 0x000DE4DE File Offset: 0x000DC6DE
		[DebuggerNonUserCode]
		public uint NumSockets
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint numSocketsDefaultValue;
				if (flag)
				{
					numSocketsDefaultValue = this.numSockets_;
				}
				else
				{
					numSocketsDefaultValue = ToolTip.NumSocketsDefaultValue;
				}
				return numSocketsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.numSockets_ = value;
			}
		}

		// Token: 0x17001266 RID: 4710
		// (get) Token: 0x0600383F RID: 14399 RVA: 0x000DE4F8 File Offset: 0x000DC6F8
		[DebuggerNonUserCode]
		public bool HasNumSockets
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06003840 RID: 14400 RVA: 0x000DE516 File Offset: 0x000DC716
		[DebuggerNonUserCode]
		public void ClearNumSockets()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17001267 RID: 4711
		// (get) Token: 0x06003841 RID: 14401 RVA: 0x000DE528 File Offset: 0x000DC728
		// (set) Token: 0x06003842 RID: 14402 RVA: 0x000DE55A File Offset: 0x000DC75A
		[DebuggerNonUserCode]
		public uint FilledSockets
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				uint filledSocketsDefaultValue;
				if (flag)
				{
					filledSocketsDefaultValue = this.filledSockets_;
				}
				else
				{
					filledSocketsDefaultValue = ToolTip.FilledSocketsDefaultValue;
				}
				return filledSocketsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.filledSockets_ = value;
			}
		}

		// Token: 0x17001268 RID: 4712
		// (get) Token: 0x06003843 RID: 14403 RVA: 0x000DE574 File Offset: 0x000DC774
		[DebuggerNonUserCode]
		public bool HasFilledSockets
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06003844 RID: 14404 RVA: 0x000DE592 File Offset: 0x000DC792
		[DebuggerNonUserCode]
		public void ClearFilledSockets()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17001269 RID: 4713
		// (get) Token: 0x06003845 RID: 14405 RVA: 0x000DE5A4 File Offset: 0x000DC7A4
		// (set) Token: 0x06003846 RID: 14406 RVA: 0x000DE5C5 File Offset: 0x000DC7C5
		[DebuggerNonUserCode]
		public string DisplayName
		{
			get
			{
				return this.displayName_ ?? ToolTip.DisplayNameDefaultValue;
			}
			set
			{
				this.displayName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700126A RID: 4714
		// (get) Token: 0x06003847 RID: 14407 RVA: 0x000DE5DC File Offset: 0x000DC7DC
		[DebuggerNonUserCode]
		public bool HasDisplayName
		{
			get
			{
				return this.displayName_ != null;
			}
		}

		// Token: 0x06003848 RID: 14408 RVA: 0x000DE5F7 File Offset: 0x000DC7F7
		[DebuggerNonUserCode]
		public void ClearDisplayName()
		{
			this.displayName_ = null;
		}

		// Token: 0x06003849 RID: 14409 RVA: 0x000DE604 File Offset: 0x000DC804
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ToolTip);
		}

		// Token: 0x0600384A RID: 14410 RVA: 0x000DE624 File Offset: 0x000DC824
		[DebuggerNonUserCode]
		public bool Equals(ToolTip other)
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
					bool flag4 = this.ItemId != other.ItemId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ItemQualityLevel != other.ItemQualityLevel;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Name != other.Name;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Type != other.Type;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.SetItem != other.SetItem;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.Flavor != other.Flavor;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.Cost != other.Cost;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.DurabilityDeprecated != other.DurabilityDeprecated;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.ClassReqs != other.ClassReqs;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.Requirements != other.Requirements;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.EnhancementDeprecated != other.EnhancementDeprecated;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.StackCount != other.StackCount;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = this.NumSockets != other.NumSockets;
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = this.FilledSockets != other.FilledSockets;
																		if (flag17)
																		{
																			flag2 = false;
																		}
																		else
																		{
																			bool flag18 = this.DisplayName != other.DisplayName;
																			flag2 = !flag18 && object.Equals(this._unknownFields, other._unknownFields);
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
				}
			}
			return flag2;
		}

		// Token: 0x0600384B RID: 14411 RVA: 0x000DE81C File Offset: 0x000DCA1C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasItemId = this.HasItemId;
			if (hasItemId)
			{
				num ^= this.ItemId.GetHashCode();
			}
			bool hasItemQualityLevel = this.HasItemQualityLevel;
			if (hasItemQualityLevel)
			{
				num ^= this.ItemQualityLevel.GetHashCode();
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				num ^= this.Type.GetHashCode();
			}
			bool hasSetItem = this.HasSetItem;
			if (hasSetItem)
			{
				num ^= this.SetItem.GetHashCode();
			}
			bool hasFlavor = this.HasFlavor;
			if (hasFlavor)
			{
				num ^= this.Flavor.GetHashCode();
			}
			bool hasCost = this.HasCost;
			if (hasCost)
			{
				num ^= this.Cost.GetHashCode();
			}
			bool hasDurabilityDeprecated = this.HasDurabilityDeprecated;
			if (hasDurabilityDeprecated)
			{
				num ^= this.DurabilityDeprecated.GetHashCode();
			}
			bool hasClassReqs = this.HasClassReqs;
			if (hasClassReqs)
			{
				num ^= this.ClassReqs.GetHashCode();
			}
			bool hasRequirements = this.HasRequirements;
			if (hasRequirements)
			{
				num ^= this.Requirements.GetHashCode();
			}
			bool hasEnhancementDeprecated = this.HasEnhancementDeprecated;
			if (hasEnhancementDeprecated)
			{
				num ^= this.EnhancementDeprecated.GetHashCode();
			}
			bool hasStackCount = this.HasStackCount;
			if (hasStackCount)
			{
				num ^= this.StackCount.GetHashCode();
			}
			bool hasNumSockets = this.HasNumSockets;
			if (hasNumSockets)
			{
				num ^= this.NumSockets.GetHashCode();
			}
			bool hasFilledSockets = this.HasFilledSockets;
			if (hasFilledSockets)
			{
				num ^= this.FilledSockets.GetHashCode();
			}
			bool hasDisplayName = this.HasDisplayName;
			if (hasDisplayName)
			{
				num ^= this.DisplayName.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600384C RID: 14412 RVA: 0x000DE9EC File Offset: 0x000DCBEC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600384D RID: 14413 RVA: 0x000DEA04 File Offset: 0x000DCC04
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600384E RID: 14414 RVA: 0x000DEA10 File Offset: 0x000DCC10
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasItemId = this.HasItemId;
			if (hasItemId)
			{
				output.WriteRawTag(9);
				output.WriteFixed64(this.ItemId);
			}
			bool hasItemQualityLevel = this.HasItemQualityLevel;
			if (hasItemQualityLevel)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.ItemQualityLevel);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Name);
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Type);
			}
			bool hasSetItem = this.HasSetItem;
			if (hasSetItem)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SetItem);
			}
			bool hasFlavor = this.HasFlavor;
			if (hasFlavor)
			{
				output.WriteRawTag(50);
				output.WriteString(this.Flavor);
			}
			bool hasCost = this.HasCost;
			if (hasCost)
			{
				output.WriteRawTag(58);
				output.WriteString(this.Cost);
			}
			bool hasDurabilityDeprecated = this.HasDurabilityDeprecated;
			if (hasDurabilityDeprecated)
			{
				output.WriteRawTag(66);
				output.WriteString(this.DurabilityDeprecated);
			}
			bool hasClassReqs = this.HasClassReqs;
			if (hasClassReqs)
			{
				output.WriteRawTag(74);
				output.WriteString(this.ClassReqs);
			}
			bool hasRequirements = this.HasRequirements;
			if (hasRequirements)
			{
				output.WriteRawTag(82);
				output.WriteString(this.Requirements);
			}
			bool hasEnhancementDeprecated = this.HasEnhancementDeprecated;
			if (hasEnhancementDeprecated)
			{
				output.WriteRawTag(90);
				output.WriteString(this.EnhancementDeprecated);
			}
			bool hasStackCount = this.HasStackCount;
			if (hasStackCount)
			{
				output.WriteRawTag(96);
				output.WriteUInt64(this.StackCount);
			}
			bool hasNumSockets = this.HasNumSockets;
			if (hasNumSockets)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.NumSockets);
			}
			bool hasFilledSockets = this.HasFilledSockets;
			if (hasFilledSockets)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.FilledSockets);
			}
			bool hasDisplayName = this.HasDisplayName;
			if (hasDisplayName)
			{
				output.WriteRawTag(122);
				output.WriteString(this.DisplayName);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600384F RID: 14415 RVA: 0x000DEC50 File Offset: 0x000DCE50
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasItemId = this.HasItemId;
			if (hasItemId)
			{
				num += 9;
			}
			bool hasItemQualityLevel = this.HasItemQualityLevel;
			if (hasItemQualityLevel)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemQualityLevel);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Type);
			}
			bool hasSetItem = this.HasSetItem;
			if (hasSetItem)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SetItem);
			}
			bool hasFlavor = this.HasFlavor;
			if (hasFlavor)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Flavor);
			}
			bool hasCost = this.HasCost;
			if (hasCost)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Cost);
			}
			bool hasDurabilityDeprecated = this.HasDurabilityDeprecated;
			if (hasDurabilityDeprecated)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.DurabilityDeprecated);
			}
			bool hasClassReqs = this.HasClassReqs;
			if (hasClassReqs)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClassReqs);
			}
			bool hasRequirements = this.HasRequirements;
			if (hasRequirements)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Requirements);
			}
			bool hasEnhancementDeprecated = this.HasEnhancementDeprecated;
			if (hasEnhancementDeprecated)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.EnhancementDeprecated);
			}
			bool hasStackCount = this.HasStackCount;
			if (hasStackCount)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.StackCount);
			}
			bool hasNumSockets = this.HasNumSockets;
			if (hasNumSockets)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NumSockets);
			}
			bool hasFilledSockets = this.HasFilledSockets;
			if (hasFilledSockets)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FilledSockets);
			}
			bool hasDisplayName = this.HasDisplayName;
			if (hasDisplayName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.DisplayName);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003850 RID: 14416 RVA: 0x000DEE38 File Offset: 0x000DD038
		[DebuggerNonUserCode]
		public void MergeFrom(ToolTip other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasItemId = other.HasItemId;
				if (hasItemId)
				{
					this.ItemId = other.ItemId;
				}
				bool hasItemQualityLevel = other.HasItemQualityLevel;
				if (hasItemQualityLevel)
				{
					this.ItemQualityLevel = other.ItemQualityLevel;
				}
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool hasType = other.HasType;
				if (hasType)
				{
					this.Type = other.Type;
				}
				bool hasSetItem = other.HasSetItem;
				if (hasSetItem)
				{
					this.SetItem = other.SetItem;
				}
				bool hasFlavor = other.HasFlavor;
				if (hasFlavor)
				{
					this.Flavor = other.Flavor;
				}
				bool hasCost = other.HasCost;
				if (hasCost)
				{
					this.Cost = other.Cost;
				}
				bool hasDurabilityDeprecated = other.HasDurabilityDeprecated;
				if (hasDurabilityDeprecated)
				{
					this.DurabilityDeprecated = other.DurabilityDeprecated;
				}
				bool hasClassReqs = other.HasClassReqs;
				if (hasClassReqs)
				{
					this.ClassReqs = other.ClassReqs;
				}
				bool hasRequirements = other.HasRequirements;
				if (hasRequirements)
				{
					this.Requirements = other.Requirements;
				}
				bool hasEnhancementDeprecated = other.HasEnhancementDeprecated;
				if (hasEnhancementDeprecated)
				{
					this.EnhancementDeprecated = other.EnhancementDeprecated;
				}
				bool hasStackCount = other.HasStackCount;
				if (hasStackCount)
				{
					this.StackCount = other.StackCount;
				}
				bool hasNumSockets = other.HasNumSockets;
				if (hasNumSockets)
				{
					this.NumSockets = other.NumSockets;
				}
				bool hasFilledSockets = other.HasFilledSockets;
				if (hasFilledSockets)
				{
					this.FilledSockets = other.FilledSockets;
				}
				bool hasDisplayName = other.HasDisplayName;
				if (hasDisplayName)
				{
					this.DisplayName = other.DisplayName;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003851 RID: 14417 RVA: 0x000DEFFA File Offset: 0x000DD1FA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003852 RID: 14418 RVA: 0x000DF008 File Offset: 0x000DD208
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 58U)
				{
					if (num3 <= 26U)
					{
						if (num3 != 9U)
						{
							if (num3 != 16U)
							{
								if (num3 != 26U)
								{
									goto IL_00C2;
								}
								this.Name = input.ReadString();
							}
							else
							{
								this.ItemQualityLevel = input.ReadUInt32();
							}
						}
						else
						{
							this.ItemId = input.ReadFixed64();
						}
					}
					else if (num3 <= 40U)
					{
						if (num3 != 34U)
						{
							if (num3 != 40U)
							{
								goto IL_00C2;
							}
							this.SetItem = input.ReadInt32();
						}
						else
						{
							this.Type = input.ReadString();
						}
					}
					else if (num3 != 50U)
					{
						if (num3 != 58U)
						{
							goto IL_00C2;
						}
						this.Cost = input.ReadString();
					}
					else
					{
						this.Flavor = input.ReadString();
					}
				}
				else if (num3 <= 90U)
				{
					if (num3 <= 74U)
					{
						if (num3 != 66U)
						{
							if (num3 != 74U)
							{
								goto IL_00C2;
							}
							this.ClassReqs = input.ReadString();
						}
						else
						{
							this.DurabilityDeprecated = input.ReadString();
						}
					}
					else if (num3 != 82U)
					{
						if (num3 != 90U)
						{
							goto IL_00C2;
						}
						this.EnhancementDeprecated = input.ReadString();
					}
					else
					{
						this.Requirements = input.ReadString();
					}
				}
				else if (num3 <= 104U)
				{
					if (num3 != 96U)
					{
						if (num3 != 104U)
						{
							goto IL_00C2;
						}
						this.NumSockets = input.ReadUInt32();
					}
					else
					{
						this.StackCount = input.ReadUInt64();
					}
				}
				else if (num3 != 112U)
				{
					if (num3 != 122U)
					{
						goto IL_00C2;
					}
					this.DisplayName = input.ReadString();
				}
				else
				{
					this.FilledSockets = input.ReadUInt32();
				}
				continue;
				IL_00C2:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001A23 RID: 6691
		private static readonly MessageParser<ToolTip> _parser = new MessageParser<ToolTip>(() => new ToolTip());

		// Token: 0x04001A24 RID: 6692
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001A25 RID: 6693
		private int _hasBits0;

		// Token: 0x04001A26 RID: 6694
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04001A27 RID: 6695
		private static readonly ulong ItemIdDefaultValue = 0UL;

		// Token: 0x04001A28 RID: 6696
		private ulong itemId_;

		// Token: 0x04001A29 RID: 6697
		public const int ItemQualityLevelFieldNumber = 2;

		// Token: 0x04001A2A RID: 6698
		private static readonly uint ItemQualityLevelDefaultValue = 0U;

		// Token: 0x04001A2B RID: 6699
		private uint itemQualityLevel_;

		// Token: 0x04001A2C RID: 6700
		public const int NameFieldNumber = 3;

		// Token: 0x04001A2D RID: 6701
		private static readonly string NameDefaultValue = "";

		// Token: 0x04001A2E RID: 6702
		private string name_;

		// Token: 0x04001A2F RID: 6703
		public const int TypeFieldNumber = 4;

		// Token: 0x04001A30 RID: 6704
		private static readonly string TypeDefaultValue = "";

		// Token: 0x04001A31 RID: 6705
		private string type_;

		// Token: 0x04001A32 RID: 6706
		public const int SetItemFieldNumber = 5;

		// Token: 0x04001A33 RID: 6707
		private static readonly int SetItemDefaultValue = 0;

		// Token: 0x04001A34 RID: 6708
		private int setItem_;

		// Token: 0x04001A35 RID: 6709
		public const int FlavorFieldNumber = 6;

		// Token: 0x04001A36 RID: 6710
		private static readonly string FlavorDefaultValue = "";

		// Token: 0x04001A37 RID: 6711
		private string flavor_;

		// Token: 0x04001A38 RID: 6712
		public const int CostFieldNumber = 7;

		// Token: 0x04001A39 RID: 6713
		private static readonly string CostDefaultValue = "";

		// Token: 0x04001A3A RID: 6714
		private string cost_;

		// Token: 0x04001A3B RID: 6715
		public const int DurabilityDeprecatedFieldNumber = 8;

		// Token: 0x04001A3C RID: 6716
		private static readonly string DurabilityDeprecatedDefaultValue = "";

		// Token: 0x04001A3D RID: 6717
		private string durabilityDeprecated_;

		// Token: 0x04001A3E RID: 6718
		public const int ClassReqsFieldNumber = 9;

		// Token: 0x04001A3F RID: 6719
		private static readonly string ClassReqsDefaultValue = "";

		// Token: 0x04001A40 RID: 6720
		private string classReqs_;

		// Token: 0x04001A41 RID: 6721
		public const int RequirementsFieldNumber = 10;

		// Token: 0x04001A42 RID: 6722
		private static readonly string RequirementsDefaultValue = "";

		// Token: 0x04001A43 RID: 6723
		private string requirements_;

		// Token: 0x04001A44 RID: 6724
		public const int EnhancementDeprecatedFieldNumber = 11;

		// Token: 0x04001A45 RID: 6725
		private static readonly string EnhancementDeprecatedDefaultValue = "";

		// Token: 0x04001A46 RID: 6726
		private string enhancementDeprecated_;

		// Token: 0x04001A47 RID: 6727
		public const int StackCountFieldNumber = 12;

		// Token: 0x04001A48 RID: 6728
		private static readonly ulong StackCountDefaultValue = 0UL;

		// Token: 0x04001A49 RID: 6729
		private ulong stackCount_;

		// Token: 0x04001A4A RID: 6730
		public const int NumSocketsFieldNumber = 13;

		// Token: 0x04001A4B RID: 6731
		private static readonly uint NumSocketsDefaultValue = 0U;

		// Token: 0x04001A4C RID: 6732
		private uint numSockets_;

		// Token: 0x04001A4D RID: 6733
		public const int FilledSocketsFieldNumber = 14;

		// Token: 0x04001A4E RID: 6734
		private static readonly uint FilledSocketsDefaultValue = 0U;

		// Token: 0x04001A4F RID: 6735
		private uint filledSockets_;

		// Token: 0x04001A50 RID: 6736
		public const int DisplayNameFieldNumber = 15;

		// Token: 0x04001A51 RID: 6737
		private static readonly string DisplayNameDefaultValue = "";

		// Token: 0x04001A52 RID: 6738
		private string displayName_;
	}
}
