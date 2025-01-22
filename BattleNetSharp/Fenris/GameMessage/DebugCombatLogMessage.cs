using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001EC RID: 492
	public sealed class DebugCombatLogMessage : IMessage<DebugCombatLogMessage>, IMessage, IEquatable<DebugCombatLogMessage>, IDeepCloneable<DebugCombatLogMessage>, IBufferMessage
	{
		// Token: 0x1700115B RID: 4443
		// (get) Token: 0x06003576 RID: 13686 RVA: 0x000D3070 File Offset: 0x000D1270
		[DebuggerNonUserCode]
		public static MessageParser<DebugCombatLogMessage> Parser
		{
			get
			{
				return DebugCombatLogMessage._parser;
			}
		}

		// Token: 0x1700115C RID: 4444
		// (get) Token: 0x06003577 RID: 13687 RVA: 0x000D3088 File Offset: 0x000D1288
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[49];
			}
		}

		// Token: 0x1700115D RID: 4445
		// (get) Token: 0x06003578 RID: 13688 RVA: 0x000D30AC File Offset: 0x000D12AC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugCombatLogMessage.Descriptor;
			}
		}

		// Token: 0x06003579 RID: 13689 RVA: 0x000D30C3 File Offset: 0x000D12C3
		[DebuggerNonUserCode]
		public DebugCombatLogMessage()
		{
		}

		// Token: 0x0600357A RID: 13690 RVA: 0x000D30D8 File Offset: 0x000D12D8
		[DebuggerNonUserCode]
		public DebugCombatLogMessage(DebugCombatLogMessage other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.source_ = ((other.source_ != null) ? other.source_.Clone() : null);
			this.target_ = ((other.target_ != null) ? other.target_.Clone() : null);
			this.powerSno_ = other.powerSno_;
			this.commandFrame_ = other.commandFrame_;
			this.powerId_ = other.powerId_;
			this.clientViewScalar_ = other.clientViewScalar_;
			this.overpowerChance_ = other.overpowerChance_;
			this.damageEvent_ = ((other.damageEvent_ != null) ? other.damageEvent_.Clone() : null);
			this.vulnerableEvent_ = ((other.vulnerableEvent_ != null) ? other.vulnerableEvent_.Clone() : null);
			this.fortifiedEvent_ = ((other.fortifiedEvent_ != null) ? other.fortifiedEvent_.Clone() : null);
			this.healEvent_ = ((other.healEvent_ != null) ? other.healEvent_.Clone() : null);
			this.stackEvent_ = ((other.stackEvent_ != null) ? other.stackEvent_.Clone() : null);
			this.staggerEvent_ = ((other.staggerEvent_ != null) ? other.staggerEvent_.Clone() : null);
			this.stats_ = other.stats_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600357B RID: 13691 RVA: 0x000D3238 File Offset: 0x000D1438
		[DebuggerNonUserCode]
		public DebugCombatLogMessage Clone()
		{
			return new DebugCombatLogMessage(this);
		}

		// Token: 0x1700115E RID: 4446
		// (get) Token: 0x0600357C RID: 13692 RVA: 0x000D3250 File Offset: 0x000D1450
		// (set) Token: 0x0600357D RID: 13693 RVA: 0x000D3268 File Offset: 0x000D1468
		[DebuggerNonUserCode]
		public DebugCombatActorInfo Source
		{
			get
			{
				return this.source_;
			}
			set
			{
				this.source_ = value;
			}
		}

		// Token: 0x1700115F RID: 4447
		// (get) Token: 0x0600357E RID: 13694 RVA: 0x000D3274 File Offset: 0x000D1474
		// (set) Token: 0x0600357F RID: 13695 RVA: 0x000D328C File Offset: 0x000D148C
		[DebuggerNonUserCode]
		public DebugCombatActorInfo Target
		{
			get
			{
				return this.target_;
			}
			set
			{
				this.target_ = value;
			}
		}

		// Token: 0x17001160 RID: 4448
		// (get) Token: 0x06003580 RID: 13696 RVA: 0x000D3298 File Offset: 0x000D1498
		// (set) Token: 0x06003581 RID: 13697 RVA: 0x000D32C9 File Offset: 0x000D14C9
		[DebuggerNonUserCode]
		public int PowerSno
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int powerSnoDefaultValue;
				if (flag)
				{
					powerSnoDefaultValue = this.powerSno_;
				}
				else
				{
					powerSnoDefaultValue = DebugCombatLogMessage.PowerSnoDefaultValue;
				}
				return powerSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.powerSno_ = value;
			}
		}

		// Token: 0x17001161 RID: 4449
		// (get) Token: 0x06003582 RID: 13698 RVA: 0x000D32E4 File Offset: 0x000D14E4
		[DebuggerNonUserCode]
		public bool HasPowerSno
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003583 RID: 13699 RVA: 0x000D3301 File Offset: 0x000D1501
		[DebuggerNonUserCode]
		public void ClearPowerSno()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001162 RID: 4450
		// (get) Token: 0x06003584 RID: 13700 RVA: 0x000D3314 File Offset: 0x000D1514
		// (set) Token: 0x06003585 RID: 13701 RVA: 0x000D3345 File Offset: 0x000D1545
		[DebuggerNonUserCode]
		public uint CommandFrame
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint commandFrameDefaultValue;
				if (flag)
				{
					commandFrameDefaultValue = this.commandFrame_;
				}
				else
				{
					commandFrameDefaultValue = DebugCombatLogMessage.CommandFrameDefaultValue;
				}
				return commandFrameDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.commandFrame_ = value;
			}
		}

		// Token: 0x17001163 RID: 4451
		// (get) Token: 0x06003586 RID: 13702 RVA: 0x000D3360 File Offset: 0x000D1560
		[DebuggerNonUserCode]
		public bool HasCommandFrame
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003587 RID: 13703 RVA: 0x000D337D File Offset: 0x000D157D
		[DebuggerNonUserCode]
		public void ClearCommandFrame()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001164 RID: 4452
		// (get) Token: 0x06003588 RID: 13704 RVA: 0x000D3390 File Offset: 0x000D1590
		// (set) Token: 0x06003589 RID: 13705 RVA: 0x000D33C1 File Offset: 0x000D15C1
		[DebuggerNonUserCode]
		public int PowerId
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int powerIdDefaultValue;
				if (flag)
				{
					powerIdDefaultValue = this.powerId_;
				}
				else
				{
					powerIdDefaultValue = DebugCombatLogMessage.PowerIdDefaultValue;
				}
				return powerIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.powerId_ = value;
			}
		}

		// Token: 0x17001165 RID: 4453
		// (get) Token: 0x0600358A RID: 13706 RVA: 0x000D33DC File Offset: 0x000D15DC
		[DebuggerNonUserCode]
		public bool HasPowerId
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600358B RID: 13707 RVA: 0x000D33F9 File Offset: 0x000D15F9
		[DebuggerNonUserCode]
		public void ClearPowerId()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001166 RID: 4454
		// (get) Token: 0x0600358C RID: 13708 RVA: 0x000D340C File Offset: 0x000D160C
		// (set) Token: 0x0600358D RID: 13709 RVA: 0x000D343D File Offset: 0x000D163D
		[DebuggerNonUserCode]
		public float ClientViewScalar
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				float clientViewScalarDefaultValue;
				if (flag)
				{
					clientViewScalarDefaultValue = this.clientViewScalar_;
				}
				else
				{
					clientViewScalarDefaultValue = DebugCombatLogMessage.ClientViewScalarDefaultValue;
				}
				return clientViewScalarDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.clientViewScalar_ = value;
			}
		}

		// Token: 0x17001167 RID: 4455
		// (get) Token: 0x0600358E RID: 13710 RVA: 0x000D3458 File Offset: 0x000D1658
		[DebuggerNonUserCode]
		public bool HasClientViewScalar
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600358F RID: 13711 RVA: 0x000D3475 File Offset: 0x000D1675
		[DebuggerNonUserCode]
		public void ClearClientViewScalar()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17001168 RID: 4456
		// (get) Token: 0x06003590 RID: 13712 RVA: 0x000D3488 File Offset: 0x000D1688
		// (set) Token: 0x06003591 RID: 13713 RVA: 0x000D34BA File Offset: 0x000D16BA
		[DebuggerNonUserCode]
		public float OverpowerChance
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				float overpowerChanceDefaultValue;
				if (flag)
				{
					overpowerChanceDefaultValue = this.overpowerChance_;
				}
				else
				{
					overpowerChanceDefaultValue = DebugCombatLogMessage.OverpowerChanceDefaultValue;
				}
				return overpowerChanceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.overpowerChance_ = value;
			}
		}

		// Token: 0x17001169 RID: 4457
		// (get) Token: 0x06003592 RID: 13714 RVA: 0x000D34D4 File Offset: 0x000D16D4
		[DebuggerNonUserCode]
		public bool HasOverpowerChance
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06003593 RID: 13715 RVA: 0x000D34F2 File Offset: 0x000D16F2
		[DebuggerNonUserCode]
		public void ClearOverpowerChance()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x06003594 RID: 13716 RVA: 0x000D3504 File Offset: 0x000D1704
		// (set) Token: 0x06003595 RID: 13717 RVA: 0x000D351C File Offset: 0x000D171C
		[DebuggerNonUserCode]
		public DebugCombatLogDamageEvent DamageEvent
		{
			get
			{
				return this.damageEvent_;
			}
			set
			{
				this.damageEvent_ = value;
			}
		}

		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x06003596 RID: 13718 RVA: 0x000D3528 File Offset: 0x000D1728
		// (set) Token: 0x06003597 RID: 13719 RVA: 0x000D3540 File Offset: 0x000D1740
		[DebuggerNonUserCode]
		public DebugCombatLogVulnerableEvent VulnerableEvent
		{
			get
			{
				return this.vulnerableEvent_;
			}
			set
			{
				this.vulnerableEvent_ = value;
			}
		}

		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x06003598 RID: 13720 RVA: 0x000D354C File Offset: 0x000D174C
		// (set) Token: 0x06003599 RID: 13721 RVA: 0x000D3564 File Offset: 0x000D1764
		[DebuggerNonUserCode]
		public DebugCombatLogFortifiedEvent FortifiedEvent
		{
			get
			{
				return this.fortifiedEvent_;
			}
			set
			{
				this.fortifiedEvent_ = value;
			}
		}

		// Token: 0x1700116D RID: 4461
		// (get) Token: 0x0600359A RID: 13722 RVA: 0x000D3570 File Offset: 0x000D1770
		// (set) Token: 0x0600359B RID: 13723 RVA: 0x000D3588 File Offset: 0x000D1788
		[DebuggerNonUserCode]
		public DebugCombatLogHealEvent HealEvent
		{
			get
			{
				return this.healEvent_;
			}
			set
			{
				this.healEvent_ = value;
			}
		}

		// Token: 0x1700116E RID: 4462
		// (get) Token: 0x0600359C RID: 13724 RVA: 0x000D3594 File Offset: 0x000D1794
		// (set) Token: 0x0600359D RID: 13725 RVA: 0x000D35AC File Offset: 0x000D17AC
		[DebuggerNonUserCode]
		public DebugCombatLogStackEvent StackEvent
		{
			get
			{
				return this.stackEvent_;
			}
			set
			{
				this.stackEvent_ = value;
			}
		}

		// Token: 0x1700116F RID: 4463
		// (get) Token: 0x0600359E RID: 13726 RVA: 0x000D35B8 File Offset: 0x000D17B8
		// (set) Token: 0x0600359F RID: 13727 RVA: 0x000D35D0 File Offset: 0x000D17D0
		[DebuggerNonUserCode]
		public DebugCombatLogStaggerEvent StaggerEvent
		{
			get
			{
				return this.staggerEvent_;
			}
			set
			{
				this.staggerEvent_ = value;
			}
		}

		// Token: 0x17001170 RID: 4464
		// (get) Token: 0x060035A0 RID: 13728 RVA: 0x000D35DC File Offset: 0x000D17DC
		[DebuggerNonUserCode]
		public RepeatedField<DebugCombatStat> Stats
		{
			get
			{
				return this.stats_;
			}
		}

		// Token: 0x060035A1 RID: 13729 RVA: 0x000D35F4 File Offset: 0x000D17F4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugCombatLogMessage);
		}

		// Token: 0x060035A2 RID: 13730 RVA: 0x000D3614 File Offset: 0x000D1814
		[DebuggerNonUserCode]
		public bool Equals(DebugCombatLogMessage other)
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
					bool flag4 = !object.Equals(this.Source, other.Source);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Target, other.Target);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.PowerSno != other.PowerSno;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.CommandFrame != other.CommandFrame;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.PowerId != other.PowerId;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ClientViewScalar, other.ClientViewScalar);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.OverpowerChance, other.OverpowerChance);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !object.Equals(this.DamageEvent, other.DamageEvent);
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !object.Equals(this.VulnerableEvent, other.VulnerableEvent);
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = !object.Equals(this.FortifiedEvent, other.FortifiedEvent);
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = !object.Equals(this.HealEvent, other.HealEvent);
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = !object.Equals(this.StackEvent, other.StackEvent);
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = !object.Equals(this.StaggerEvent, other.StaggerEvent);
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = !this.stats_.Equals(other.stats_);
																		flag2 = !flag17 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x060035A3 RID: 13731 RVA: 0x000D3818 File Offset: 0x000D1A18
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.source_ != null;
			if (flag)
			{
				num ^= this.Source.GetHashCode();
			}
			bool flag2 = this.target_ != null;
			if (flag2)
			{
				num ^= this.Target.GetHashCode();
			}
			bool hasPowerSno = this.HasPowerSno;
			if (hasPowerSno)
			{
				num ^= this.PowerSno.GetHashCode();
			}
			bool hasCommandFrame = this.HasCommandFrame;
			if (hasCommandFrame)
			{
				num ^= this.CommandFrame.GetHashCode();
			}
			bool hasPowerId = this.HasPowerId;
			if (hasPowerId)
			{
				num ^= this.PowerId.GetHashCode();
			}
			bool hasClientViewScalar = this.HasClientViewScalar;
			if (hasClientViewScalar)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.ClientViewScalar);
			}
			bool hasOverpowerChance = this.HasOverpowerChance;
			if (hasOverpowerChance)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.OverpowerChance);
			}
			bool flag3 = this.damageEvent_ != null;
			if (flag3)
			{
				num ^= this.DamageEvent.GetHashCode();
			}
			bool flag4 = this.vulnerableEvent_ != null;
			if (flag4)
			{
				num ^= this.VulnerableEvent.GetHashCode();
			}
			bool flag5 = this.fortifiedEvent_ != null;
			if (flag5)
			{
				num ^= this.FortifiedEvent.GetHashCode();
			}
			bool flag6 = this.healEvent_ != null;
			if (flag6)
			{
				num ^= this.HealEvent.GetHashCode();
			}
			bool flag7 = this.stackEvent_ != null;
			if (flag7)
			{
				num ^= this.StackEvent.GetHashCode();
			}
			bool flag8 = this.staggerEvent_ != null;
			if (flag8)
			{
				num ^= this.StaggerEvent.GetHashCode();
			}
			num ^= this.stats_.GetHashCode();
			bool flag9 = this._unknownFields != null;
			if (flag9)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060035A4 RID: 13732 RVA: 0x000D39D8 File Offset: 0x000D1BD8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060035A5 RID: 13733 RVA: 0x000D39F0 File Offset: 0x000D1BF0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060035A6 RID: 13734 RVA: 0x000D39FC File Offset: 0x000D1BFC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.source_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Source);
			}
			bool flag2 = this.target_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Target);
			}
			bool hasPowerSno = this.HasPowerSno;
			if (hasPowerSno)
			{
				output.WriteRawTag(29);
				output.WriteSFixed32(this.PowerSno);
			}
			bool hasCommandFrame = this.HasCommandFrame;
			if (hasCommandFrame)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.CommandFrame);
			}
			bool hasPowerId = this.HasPowerId;
			if (hasPowerId)
			{
				output.WriteRawTag(40);
				output.WriteSInt32(this.PowerId);
			}
			bool hasClientViewScalar = this.HasClientViewScalar;
			if (hasClientViewScalar)
			{
				output.WriteRawTag(53);
				output.WriteFloat(this.ClientViewScalar);
			}
			bool hasOverpowerChance = this.HasOverpowerChance;
			if (hasOverpowerChance)
			{
				output.WriteRawTag(61);
				output.WriteFloat(this.OverpowerChance);
			}
			bool flag3 = this.damageEvent_ != null;
			if (flag3)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.DamageEvent);
			}
			bool flag4 = this.vulnerableEvent_ != null;
			if (flag4)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.VulnerableEvent);
			}
			bool flag5 = this.fortifiedEvent_ != null;
			if (flag5)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.FortifiedEvent);
			}
			bool flag6 = this.healEvent_ != null;
			if (flag6)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.HealEvent);
			}
			bool flag7 = this.stackEvent_ != null;
			if (flag7)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.StackEvent);
			}
			bool flag8 = this.staggerEvent_ != null;
			if (flag8)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.StaggerEvent);
			}
			this.stats_.WriteTo(ref output, DebugCombatLogMessage._repeated_stats_codec);
			bool flag9 = this._unknownFields != null;
			if (flag9)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060035A7 RID: 13735 RVA: 0x000D3C20 File Offset: 0x000D1E20
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.source_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Source);
			}
			bool flag2 = this.target_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Target);
			}
			bool hasPowerSno = this.HasPowerSno;
			if (hasPowerSno)
			{
				num += 5;
			}
			bool hasCommandFrame = this.HasCommandFrame;
			if (hasCommandFrame)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CommandFrame);
			}
			bool hasPowerId = this.HasPowerId;
			if (hasPowerId)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.PowerId);
			}
			bool hasClientViewScalar = this.HasClientViewScalar;
			if (hasClientViewScalar)
			{
				num += 5;
			}
			bool hasOverpowerChance = this.HasOverpowerChance;
			if (hasOverpowerChance)
			{
				num += 5;
			}
			bool flag3 = this.damageEvent_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DamageEvent);
			}
			bool flag4 = this.vulnerableEvent_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.VulnerableEvent);
			}
			bool flag5 = this.fortifiedEvent_ != null;
			if (flag5)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FortifiedEvent);
			}
			bool flag6 = this.healEvent_ != null;
			if (flag6)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HealEvent);
			}
			bool flag7 = this.stackEvent_ != null;
			if (flag7)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StackEvent);
			}
			bool flag8 = this.staggerEvent_ != null;
			if (flag8)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StaggerEvent);
			}
			num += this.stats_.CalculateSize(DebugCombatLogMessage._repeated_stats_codec);
			bool flag9 = this._unknownFields != null;
			if (flag9)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060035A8 RID: 13736 RVA: 0x000D3DE0 File Offset: 0x000D1FE0
		[DebuggerNonUserCode]
		public void MergeFrom(DebugCombatLogMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.source_ != null;
				if (flag2)
				{
					bool flag3 = this.source_ == null;
					if (flag3)
					{
						this.Source = new DebugCombatActorInfo();
					}
					this.Source.MergeFrom(other.Source);
				}
				bool flag4 = other.target_ != null;
				if (flag4)
				{
					bool flag5 = this.target_ == null;
					if (flag5)
					{
						this.Target = new DebugCombatActorInfo();
					}
					this.Target.MergeFrom(other.Target);
				}
				bool hasPowerSno = other.HasPowerSno;
				if (hasPowerSno)
				{
					this.PowerSno = other.PowerSno;
				}
				bool hasCommandFrame = other.HasCommandFrame;
				if (hasCommandFrame)
				{
					this.CommandFrame = other.CommandFrame;
				}
				bool hasPowerId = other.HasPowerId;
				if (hasPowerId)
				{
					this.PowerId = other.PowerId;
				}
				bool hasClientViewScalar = other.HasClientViewScalar;
				if (hasClientViewScalar)
				{
					this.ClientViewScalar = other.ClientViewScalar;
				}
				bool hasOverpowerChance = other.HasOverpowerChance;
				if (hasOverpowerChance)
				{
					this.OverpowerChance = other.OverpowerChance;
				}
				bool flag6 = other.damageEvent_ != null;
				if (flag6)
				{
					bool flag7 = this.damageEvent_ == null;
					if (flag7)
					{
						this.DamageEvent = new DebugCombatLogDamageEvent();
					}
					this.DamageEvent.MergeFrom(other.DamageEvent);
				}
				bool flag8 = other.vulnerableEvent_ != null;
				if (flag8)
				{
					bool flag9 = this.vulnerableEvent_ == null;
					if (flag9)
					{
						this.VulnerableEvent = new DebugCombatLogVulnerableEvent();
					}
					this.VulnerableEvent.MergeFrom(other.VulnerableEvent);
				}
				bool flag10 = other.fortifiedEvent_ != null;
				if (flag10)
				{
					bool flag11 = this.fortifiedEvent_ == null;
					if (flag11)
					{
						this.FortifiedEvent = new DebugCombatLogFortifiedEvent();
					}
					this.FortifiedEvent.MergeFrom(other.FortifiedEvent);
				}
				bool flag12 = other.healEvent_ != null;
				if (flag12)
				{
					bool flag13 = this.healEvent_ == null;
					if (flag13)
					{
						this.HealEvent = new DebugCombatLogHealEvent();
					}
					this.HealEvent.MergeFrom(other.HealEvent);
				}
				bool flag14 = other.stackEvent_ != null;
				if (flag14)
				{
					bool flag15 = this.stackEvent_ == null;
					if (flag15)
					{
						this.StackEvent = new DebugCombatLogStackEvent();
					}
					this.StackEvent.MergeFrom(other.StackEvent);
				}
				bool flag16 = other.staggerEvent_ != null;
				if (flag16)
				{
					bool flag17 = this.staggerEvent_ == null;
					if (flag17)
					{
						this.StaggerEvent = new DebugCombatLogStaggerEvent();
					}
					this.StaggerEvent.MergeFrom(other.StaggerEvent);
				}
				this.stats_.Add(other.stats_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060035A9 RID: 13737 RVA: 0x000D40A6 File Offset: 0x000D22A6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060035AA RID: 13738 RVA: 0x000D40B4 File Offset: 0x000D22B4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 61U)
				{
					if (num3 <= 29U)
					{
						if (num3 != 10U)
						{
							if (num3 != 18U)
							{
								if (num3 != 29U)
								{
									goto IL_00B0;
								}
								this.PowerSno = input.ReadSFixed32();
							}
							else
							{
								bool flag = this.target_ == null;
								if (flag)
								{
									this.Target = new DebugCombatActorInfo();
								}
								input.ReadMessage(this.Target);
							}
						}
						else
						{
							bool flag2 = this.source_ == null;
							if (flag2)
							{
								this.Source = new DebugCombatActorInfo();
							}
							input.ReadMessage(this.Source);
						}
					}
					else if (num3 <= 40U)
					{
						if (num3 != 32U)
						{
							if (num3 != 40U)
							{
								goto IL_00B0;
							}
							this.PowerId = input.ReadSInt32();
						}
						else
						{
							this.CommandFrame = input.ReadUInt32();
						}
					}
					else if (num3 != 53U)
					{
						if (num3 != 61U)
						{
							goto IL_00B0;
						}
						this.OverpowerChance = input.ReadFloat();
					}
					else
					{
						this.ClientViewScalar = input.ReadFloat();
					}
				}
				else if (num3 <= 82U)
				{
					if (num3 != 66U)
					{
						if (num3 != 74U)
						{
							if (num3 != 82U)
							{
								goto IL_00B0;
							}
							bool flag3 = this.fortifiedEvent_ == null;
							if (flag3)
							{
								this.FortifiedEvent = new DebugCombatLogFortifiedEvent();
							}
							input.ReadMessage(this.FortifiedEvent);
						}
						else
						{
							bool flag4 = this.vulnerableEvent_ == null;
							if (flag4)
							{
								this.VulnerableEvent = new DebugCombatLogVulnerableEvent();
							}
							input.ReadMessage(this.VulnerableEvent);
						}
					}
					else
					{
						bool flag5 = this.damageEvent_ == null;
						if (flag5)
						{
							this.DamageEvent = new DebugCombatLogDamageEvent();
						}
						input.ReadMessage(this.DamageEvent);
					}
				}
				else if (num3 <= 98U)
				{
					if (num3 != 90U)
					{
						if (num3 != 98U)
						{
							goto IL_00B0;
						}
						bool flag6 = this.stackEvent_ == null;
						if (flag6)
						{
							this.StackEvent = new DebugCombatLogStackEvent();
						}
						input.ReadMessage(this.StackEvent);
					}
					else
					{
						bool flag7 = this.healEvent_ == null;
						if (flag7)
						{
							this.HealEvent = new DebugCombatLogHealEvent();
						}
						input.ReadMessage(this.HealEvent);
					}
				}
				else if (num3 != 106U)
				{
					if (num3 != 114U)
					{
						goto IL_00B0;
					}
					this.stats_.AddEntriesFrom(ref input, DebugCombatLogMessage._repeated_stats_codec);
				}
				else
				{
					bool flag8 = this.staggerEvent_ == null;
					if (flag8)
					{
						this.StaggerEvent = new DebugCombatLogStaggerEvent();
					}
					input.ReadMessage(this.StaggerEvent);
				}
				continue;
				IL_00B0:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040018B7 RID: 6327
		private static readonly MessageParser<DebugCombatLogMessage> _parser = new MessageParser<DebugCombatLogMessage>(() => new DebugCombatLogMessage());

		// Token: 0x040018B8 RID: 6328
		private UnknownFieldSet _unknownFields;

		// Token: 0x040018B9 RID: 6329
		private int _hasBits0;

		// Token: 0x040018BA RID: 6330
		public const int SourceFieldNumber = 1;

		// Token: 0x040018BB RID: 6331
		private DebugCombatActorInfo source_;

		// Token: 0x040018BC RID: 6332
		public const int TargetFieldNumber = 2;

		// Token: 0x040018BD RID: 6333
		private DebugCombatActorInfo target_;

		// Token: 0x040018BE RID: 6334
		public const int PowerSnoFieldNumber = 3;

		// Token: 0x040018BF RID: 6335
		private static readonly int PowerSnoDefaultValue = 0;

		// Token: 0x040018C0 RID: 6336
		private int powerSno_;

		// Token: 0x040018C1 RID: 6337
		public const int CommandFrameFieldNumber = 4;

		// Token: 0x040018C2 RID: 6338
		private static readonly uint CommandFrameDefaultValue = 0U;

		// Token: 0x040018C3 RID: 6339
		private uint commandFrame_;

		// Token: 0x040018C4 RID: 6340
		public const int PowerIdFieldNumber = 5;

		// Token: 0x040018C5 RID: 6341
		private static readonly int PowerIdDefaultValue = 0;

		// Token: 0x040018C6 RID: 6342
		private int powerId_;

		// Token: 0x040018C7 RID: 6343
		public const int ClientViewScalarFieldNumber = 6;

		// Token: 0x040018C8 RID: 6344
		private static readonly float ClientViewScalarDefaultValue = 0f;

		// Token: 0x040018C9 RID: 6345
		private float clientViewScalar_;

		// Token: 0x040018CA RID: 6346
		public const int OverpowerChanceFieldNumber = 7;

		// Token: 0x040018CB RID: 6347
		private static readonly float OverpowerChanceDefaultValue = 0f;

		// Token: 0x040018CC RID: 6348
		private float overpowerChance_;

		// Token: 0x040018CD RID: 6349
		public const int DamageEventFieldNumber = 8;

		// Token: 0x040018CE RID: 6350
		private DebugCombatLogDamageEvent damageEvent_;

		// Token: 0x040018CF RID: 6351
		public const int VulnerableEventFieldNumber = 9;

		// Token: 0x040018D0 RID: 6352
		private DebugCombatLogVulnerableEvent vulnerableEvent_;

		// Token: 0x040018D1 RID: 6353
		public const int FortifiedEventFieldNumber = 10;

		// Token: 0x040018D2 RID: 6354
		private DebugCombatLogFortifiedEvent fortifiedEvent_;

		// Token: 0x040018D3 RID: 6355
		public const int HealEventFieldNumber = 11;

		// Token: 0x040018D4 RID: 6356
		private DebugCombatLogHealEvent healEvent_;

		// Token: 0x040018D5 RID: 6357
		public const int StackEventFieldNumber = 12;

		// Token: 0x040018D6 RID: 6358
		private DebugCombatLogStackEvent stackEvent_;

		// Token: 0x040018D7 RID: 6359
		public const int StaggerEventFieldNumber = 13;

		// Token: 0x040018D8 RID: 6360
		private DebugCombatLogStaggerEvent staggerEvent_;

		// Token: 0x040018D9 RID: 6361
		public const int StatsFieldNumber = 14;

		// Token: 0x040018DA RID: 6362
		private static readonly FieldCodec<DebugCombatStat> _repeated_stats_codec = FieldCodec.ForMessage<DebugCombatStat>(114U, DebugCombatStat.Parser);

		// Token: 0x040018DB RID: 6363
		private readonly RepeatedField<DebugCombatStat> stats_ = new RepeatedField<DebugCombatStat>();
	}
}
