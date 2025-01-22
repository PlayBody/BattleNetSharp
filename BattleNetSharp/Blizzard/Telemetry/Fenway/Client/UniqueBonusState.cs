using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x02000321 RID: 801
	public sealed class UniqueBonusState : IMessage<UniqueBonusState>, IMessage, IEquatable<UniqueBonusState>, IDeepCloneable<UniqueBonusState>, IBufferMessage
	{
		// Token: 0x17001AF4 RID: 6900
		// (get) Token: 0x060053B7 RID: 21431 RVA: 0x0014349C File Offset: 0x0014169C
		[DebuggerNonUserCode]
		public static MessageParser<UniqueBonusState> Parser
		{
			get
			{
				return UniqueBonusState._parser;
			}
		}

		// Token: 0x17001AF5 RID: 6901
		// (get) Token: 0x060053B8 RID: 21432 RVA: 0x001434B4 File Offset: 0x001416B4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CommonAttackerStateReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001AF6 RID: 6902
		// (get) Token: 0x060053B9 RID: 21433 RVA: 0x001434D8 File Offset: 0x001416D8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UniqueBonusState.Descriptor;
			}
		}

		// Token: 0x060053BA RID: 21434 RVA: 0x001434EF File Offset: 0x001416EF
		[DebuggerNonUserCode]
		public UniqueBonusState()
		{
		}

		// Token: 0x060053BB RID: 21435 RVA: 0x001434FC File Offset: 0x001416FC
		[DebuggerNonUserCode]
		public UniqueBonusState(UniqueBonusState other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.auraEnchanted_ = other.auraEnchanted_;
			this.cursed_ = other.cursed_;
			this.coldEnchanted_ = other.coldEnchanted_;
			this.extraFast_ = other.extraFast_;
			this.fireEnchanted_ = other.fireEnchanted_;
			this.lightningEnchanted_ = other.lightningEnchanted_;
			this.magicResistant_ = other.magicResistant_;
			this.manaBurn_ = other.manaBurn_;
			this.multiShot_ = other.multiShot_;
			this.spectralHit_ = other.spectralHit_;
			this.stoneSkin_ = other.stoneSkin_;
			this.extraStrong_ = other.extraStrong_;
			this.teleport_ = other.teleport_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060053BC RID: 21436 RVA: 0x001435CC File Offset: 0x001417CC
		[DebuggerNonUserCode]
		public UniqueBonusState Clone()
		{
			return new UniqueBonusState(this);
		}

		// Token: 0x17001AF7 RID: 6903
		// (get) Token: 0x060053BD RID: 21437 RVA: 0x001435E4 File Offset: 0x001417E4
		// (set) Token: 0x060053BE RID: 21438 RVA: 0x00143615 File Offset: 0x00141815
		[DebuggerNonUserCode]
		public bool AuraEnchanted
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool auraEnchantedDefaultValue;
				if (flag)
				{
					auraEnchantedDefaultValue = this.auraEnchanted_;
				}
				else
				{
					auraEnchantedDefaultValue = UniqueBonusState.AuraEnchantedDefaultValue;
				}
				return auraEnchantedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.auraEnchanted_ = value;
			}
		}

		// Token: 0x17001AF8 RID: 6904
		// (get) Token: 0x060053BF RID: 21439 RVA: 0x00143630 File Offset: 0x00141830
		[DebuggerNonUserCode]
		public bool HasAuraEnchanted
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060053C0 RID: 21440 RVA: 0x0014364D File Offset: 0x0014184D
		[DebuggerNonUserCode]
		public void ClearAuraEnchanted()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001AF9 RID: 6905
		// (get) Token: 0x060053C1 RID: 21441 RVA: 0x00143660 File Offset: 0x00141860
		// (set) Token: 0x060053C2 RID: 21442 RVA: 0x00143691 File Offset: 0x00141891
		[DebuggerNonUserCode]
		public bool Cursed
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool cursedDefaultValue;
				if (flag)
				{
					cursedDefaultValue = this.cursed_;
				}
				else
				{
					cursedDefaultValue = UniqueBonusState.CursedDefaultValue;
				}
				return cursedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.cursed_ = value;
			}
		}

		// Token: 0x17001AFA RID: 6906
		// (get) Token: 0x060053C3 RID: 21443 RVA: 0x001436AC File Offset: 0x001418AC
		[DebuggerNonUserCode]
		public bool HasCursed
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060053C4 RID: 21444 RVA: 0x001436C9 File Offset: 0x001418C9
		[DebuggerNonUserCode]
		public void ClearCursed()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001AFB RID: 6907
		// (get) Token: 0x060053C5 RID: 21445 RVA: 0x001436DC File Offset: 0x001418DC
		// (set) Token: 0x060053C6 RID: 21446 RVA: 0x0014370D File Offset: 0x0014190D
		[DebuggerNonUserCode]
		public bool ColdEnchanted
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool coldEnchantedDefaultValue;
				if (flag)
				{
					coldEnchantedDefaultValue = this.coldEnchanted_;
				}
				else
				{
					coldEnchantedDefaultValue = UniqueBonusState.ColdEnchantedDefaultValue;
				}
				return coldEnchantedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.coldEnchanted_ = value;
			}
		}

		// Token: 0x17001AFC RID: 6908
		// (get) Token: 0x060053C7 RID: 21447 RVA: 0x00143728 File Offset: 0x00141928
		[DebuggerNonUserCode]
		public bool HasColdEnchanted
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060053C8 RID: 21448 RVA: 0x00143745 File Offset: 0x00141945
		[DebuggerNonUserCode]
		public void ClearColdEnchanted()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001AFD RID: 6909
		// (get) Token: 0x060053C9 RID: 21449 RVA: 0x00143758 File Offset: 0x00141958
		// (set) Token: 0x060053CA RID: 21450 RVA: 0x00143789 File Offset: 0x00141989
		[DebuggerNonUserCode]
		public bool ExtraFast
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool extraFastDefaultValue;
				if (flag)
				{
					extraFastDefaultValue = this.extraFast_;
				}
				else
				{
					extraFastDefaultValue = UniqueBonusState.ExtraFastDefaultValue;
				}
				return extraFastDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.extraFast_ = value;
			}
		}

		// Token: 0x17001AFE RID: 6910
		// (get) Token: 0x060053CB RID: 21451 RVA: 0x001437A4 File Offset: 0x001419A4
		[DebuggerNonUserCode]
		public bool HasExtraFast
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060053CC RID: 21452 RVA: 0x001437C1 File Offset: 0x001419C1
		[DebuggerNonUserCode]
		public void ClearExtraFast()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17001AFF RID: 6911
		// (get) Token: 0x060053CD RID: 21453 RVA: 0x001437D4 File Offset: 0x001419D4
		// (set) Token: 0x060053CE RID: 21454 RVA: 0x00143806 File Offset: 0x00141A06
		[DebuggerNonUserCode]
		public bool FireEnchanted
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool fireEnchantedDefaultValue;
				if (flag)
				{
					fireEnchantedDefaultValue = this.fireEnchanted_;
				}
				else
				{
					fireEnchantedDefaultValue = UniqueBonusState.FireEnchantedDefaultValue;
				}
				return fireEnchantedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.fireEnchanted_ = value;
			}
		}

		// Token: 0x17001B00 RID: 6912
		// (get) Token: 0x060053CF RID: 21455 RVA: 0x00143820 File Offset: 0x00141A20
		[DebuggerNonUserCode]
		public bool HasFireEnchanted
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x060053D0 RID: 21456 RVA: 0x0014383E File Offset: 0x00141A3E
		[DebuggerNonUserCode]
		public void ClearFireEnchanted()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17001B01 RID: 6913
		// (get) Token: 0x060053D1 RID: 21457 RVA: 0x00143850 File Offset: 0x00141A50
		// (set) Token: 0x060053D2 RID: 21458 RVA: 0x00143882 File Offset: 0x00141A82
		[DebuggerNonUserCode]
		public bool LightningEnchanted
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				bool lightningEnchantedDefaultValue;
				if (flag)
				{
					lightningEnchantedDefaultValue = this.lightningEnchanted_;
				}
				else
				{
					lightningEnchantedDefaultValue = UniqueBonusState.LightningEnchantedDefaultValue;
				}
				return lightningEnchantedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.lightningEnchanted_ = value;
			}
		}

		// Token: 0x17001B02 RID: 6914
		// (get) Token: 0x060053D3 RID: 21459 RVA: 0x0014389C File Offset: 0x00141A9C
		[DebuggerNonUserCode]
		public bool HasLightningEnchanted
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x060053D4 RID: 21460 RVA: 0x001438BA File Offset: 0x00141ABA
		[DebuggerNonUserCode]
		public void ClearLightningEnchanted()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17001B03 RID: 6915
		// (get) Token: 0x060053D5 RID: 21461 RVA: 0x001438CC File Offset: 0x00141ACC
		// (set) Token: 0x060053D6 RID: 21462 RVA: 0x001438FE File Offset: 0x00141AFE
		[DebuggerNonUserCode]
		public bool MagicResistant
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				bool magicResistantDefaultValue;
				if (flag)
				{
					magicResistantDefaultValue = this.magicResistant_;
				}
				else
				{
					magicResistantDefaultValue = UniqueBonusState.MagicResistantDefaultValue;
				}
				return magicResistantDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.magicResistant_ = value;
			}
		}

		// Token: 0x17001B04 RID: 6916
		// (get) Token: 0x060053D7 RID: 21463 RVA: 0x00143918 File Offset: 0x00141B18
		[DebuggerNonUserCode]
		public bool HasMagicResistant
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x060053D8 RID: 21464 RVA: 0x00143936 File Offset: 0x00141B36
		[DebuggerNonUserCode]
		public void ClearMagicResistant()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x17001B05 RID: 6917
		// (get) Token: 0x060053D9 RID: 21465 RVA: 0x00143948 File Offset: 0x00141B48
		// (set) Token: 0x060053DA RID: 21466 RVA: 0x0014397D File Offset: 0x00141B7D
		[DebuggerNonUserCode]
		public bool ManaBurn
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				bool manaBurnDefaultValue;
				if (flag)
				{
					manaBurnDefaultValue = this.manaBurn_;
				}
				else
				{
					manaBurnDefaultValue = UniqueBonusState.ManaBurnDefaultValue;
				}
				return manaBurnDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.manaBurn_ = value;
			}
		}

		// Token: 0x17001B06 RID: 6918
		// (get) Token: 0x060053DB RID: 21467 RVA: 0x0014399C File Offset: 0x00141B9C
		[DebuggerNonUserCode]
		public bool HasManaBurn
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x060053DC RID: 21468 RVA: 0x001439BD File Offset: 0x00141BBD
		[DebuggerNonUserCode]
		public void ClearManaBurn()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x17001B07 RID: 6919
		// (get) Token: 0x060053DD RID: 21469 RVA: 0x001439D4 File Offset: 0x00141BD4
		// (set) Token: 0x060053DE RID: 21470 RVA: 0x00143A09 File Offset: 0x00141C09
		[DebuggerNonUserCode]
		public bool MultiShot
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				bool multiShotDefaultValue;
				if (flag)
				{
					multiShotDefaultValue = this.multiShot_;
				}
				else
				{
					multiShotDefaultValue = UniqueBonusState.MultiShotDefaultValue;
				}
				return multiShotDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.multiShot_ = value;
			}
		}

		// Token: 0x17001B08 RID: 6920
		// (get) Token: 0x060053DF RID: 21471 RVA: 0x00143A28 File Offset: 0x00141C28
		[DebuggerNonUserCode]
		public bool HasMultiShot
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x060053E0 RID: 21472 RVA: 0x00143A49 File Offset: 0x00141C49
		[DebuggerNonUserCode]
		public void ClearMultiShot()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x17001B09 RID: 6921
		// (get) Token: 0x060053E1 RID: 21473 RVA: 0x00143A60 File Offset: 0x00141C60
		// (set) Token: 0x060053E2 RID: 21474 RVA: 0x00143A95 File Offset: 0x00141C95
		[DebuggerNonUserCode]
		public bool SpectralHit
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				bool spectralHitDefaultValue;
				if (flag)
				{
					spectralHitDefaultValue = this.spectralHit_;
				}
				else
				{
					spectralHitDefaultValue = UniqueBonusState.SpectralHitDefaultValue;
				}
				return spectralHitDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.spectralHit_ = value;
			}
		}

		// Token: 0x17001B0A RID: 6922
		// (get) Token: 0x060053E3 RID: 21475 RVA: 0x00143AB4 File Offset: 0x00141CB4
		[DebuggerNonUserCode]
		public bool HasSpectralHit
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x060053E4 RID: 21476 RVA: 0x00143AD5 File Offset: 0x00141CD5
		[DebuggerNonUserCode]
		public void ClearSpectralHit()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x17001B0B RID: 6923
		// (get) Token: 0x060053E5 RID: 21477 RVA: 0x00143AEC File Offset: 0x00141CEC
		// (set) Token: 0x060053E6 RID: 21478 RVA: 0x00143B21 File Offset: 0x00141D21
		[DebuggerNonUserCode]
		public bool StoneSkin
		{
			get
			{
				bool flag = (this._hasBits0 & 1024) != 0;
				bool stoneSkinDefaultValue;
				if (flag)
				{
					stoneSkinDefaultValue = this.stoneSkin_;
				}
				else
				{
					stoneSkinDefaultValue = UniqueBonusState.StoneSkinDefaultValue;
				}
				return stoneSkinDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1024;
				this.stoneSkin_ = value;
			}
		}

		// Token: 0x17001B0C RID: 6924
		// (get) Token: 0x060053E7 RID: 21479 RVA: 0x00143B40 File Offset: 0x00141D40
		[DebuggerNonUserCode]
		public bool HasStoneSkin
		{
			get
			{
				return (this._hasBits0 & 1024) != 0;
			}
		}

		// Token: 0x060053E8 RID: 21480 RVA: 0x00143B61 File Offset: 0x00141D61
		[DebuggerNonUserCode]
		public void ClearStoneSkin()
		{
			this._hasBits0 &= -1025;
		}

		// Token: 0x17001B0D RID: 6925
		// (get) Token: 0x060053E9 RID: 21481 RVA: 0x00143B78 File Offset: 0x00141D78
		// (set) Token: 0x060053EA RID: 21482 RVA: 0x00143BAD File Offset: 0x00141DAD
		[DebuggerNonUserCode]
		public bool ExtraStrong
		{
			get
			{
				bool flag = (this._hasBits0 & 2048) != 0;
				bool extraStrongDefaultValue;
				if (flag)
				{
					extraStrongDefaultValue = this.extraStrong_;
				}
				else
				{
					extraStrongDefaultValue = UniqueBonusState.ExtraStrongDefaultValue;
				}
				return extraStrongDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2048;
				this.extraStrong_ = value;
			}
		}

		// Token: 0x17001B0E RID: 6926
		// (get) Token: 0x060053EB RID: 21483 RVA: 0x00143BCC File Offset: 0x00141DCC
		[DebuggerNonUserCode]
		public bool HasExtraStrong
		{
			get
			{
				return (this._hasBits0 & 2048) != 0;
			}
		}

		// Token: 0x060053EC RID: 21484 RVA: 0x00143BED File Offset: 0x00141DED
		[DebuggerNonUserCode]
		public void ClearExtraStrong()
		{
			this._hasBits0 &= -2049;
		}

		// Token: 0x17001B0F RID: 6927
		// (get) Token: 0x060053ED RID: 21485 RVA: 0x00143C04 File Offset: 0x00141E04
		// (set) Token: 0x060053EE RID: 21486 RVA: 0x00143C39 File Offset: 0x00141E39
		[DebuggerNonUserCode]
		public bool Teleport
		{
			get
			{
				bool flag = (this._hasBits0 & 4096) != 0;
				bool teleportDefaultValue;
				if (flag)
				{
					teleportDefaultValue = this.teleport_;
				}
				else
				{
					teleportDefaultValue = UniqueBonusState.TeleportDefaultValue;
				}
				return teleportDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4096;
				this.teleport_ = value;
			}
		}

		// Token: 0x17001B10 RID: 6928
		// (get) Token: 0x060053EF RID: 21487 RVA: 0x00143C58 File Offset: 0x00141E58
		[DebuggerNonUserCode]
		public bool HasTeleport
		{
			get
			{
				return (this._hasBits0 & 4096) != 0;
			}
		}

		// Token: 0x060053F0 RID: 21488 RVA: 0x00143C79 File Offset: 0x00141E79
		[DebuggerNonUserCode]
		public void ClearTeleport()
		{
			this._hasBits0 &= -4097;
		}

		// Token: 0x060053F1 RID: 21489 RVA: 0x00143C90 File Offset: 0x00141E90
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UniqueBonusState);
		}

		// Token: 0x060053F2 RID: 21490 RVA: 0x00143CB0 File Offset: 0x00141EB0
		[DebuggerNonUserCode]
		public bool Equals(UniqueBonusState other)
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
					bool flag4 = this.AuraEnchanted != other.AuraEnchanted;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Cursed != other.Cursed;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ColdEnchanted != other.ColdEnchanted;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.ExtraFast != other.ExtraFast;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.FireEnchanted != other.FireEnchanted;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.LightningEnchanted != other.LightningEnchanted;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.MagicResistant != other.MagicResistant;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.ManaBurn != other.ManaBurn;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.MultiShot != other.MultiShot;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.SpectralHit != other.SpectralHit;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.StoneSkin != other.StoneSkin;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.ExtraStrong != other.ExtraStrong;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = this.Teleport != other.Teleport;
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

		// Token: 0x060053F3 RID: 21491 RVA: 0x00143E6C File Offset: 0x0014206C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAuraEnchanted = this.HasAuraEnchanted;
			if (hasAuraEnchanted)
			{
				num ^= this.AuraEnchanted.GetHashCode();
			}
			bool hasCursed = this.HasCursed;
			if (hasCursed)
			{
				num ^= this.Cursed.GetHashCode();
			}
			bool hasColdEnchanted = this.HasColdEnchanted;
			if (hasColdEnchanted)
			{
				num ^= this.ColdEnchanted.GetHashCode();
			}
			bool hasExtraFast = this.HasExtraFast;
			if (hasExtraFast)
			{
				num ^= this.ExtraFast.GetHashCode();
			}
			bool hasFireEnchanted = this.HasFireEnchanted;
			if (hasFireEnchanted)
			{
				num ^= this.FireEnchanted.GetHashCode();
			}
			bool hasLightningEnchanted = this.HasLightningEnchanted;
			if (hasLightningEnchanted)
			{
				num ^= this.LightningEnchanted.GetHashCode();
			}
			bool hasMagicResistant = this.HasMagicResistant;
			if (hasMagicResistant)
			{
				num ^= this.MagicResistant.GetHashCode();
			}
			bool hasManaBurn = this.HasManaBurn;
			if (hasManaBurn)
			{
				num ^= this.ManaBurn.GetHashCode();
			}
			bool hasMultiShot = this.HasMultiShot;
			if (hasMultiShot)
			{
				num ^= this.MultiShot.GetHashCode();
			}
			bool hasSpectralHit = this.HasSpectralHit;
			if (hasSpectralHit)
			{
				num ^= this.SpectralHit.GetHashCode();
			}
			bool hasStoneSkin = this.HasStoneSkin;
			if (hasStoneSkin)
			{
				num ^= this.StoneSkin.GetHashCode();
			}
			bool hasExtraStrong = this.HasExtraStrong;
			if (hasExtraStrong)
			{
				num ^= this.ExtraStrong.GetHashCode();
			}
			bool hasTeleport = this.HasTeleport;
			if (hasTeleport)
			{
				num ^= this.Teleport.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060053F4 RID: 21492 RVA: 0x00144018 File Offset: 0x00142218
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060053F5 RID: 21493 RVA: 0x00144030 File Offset: 0x00142230
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060053F6 RID: 21494 RVA: 0x0014403C File Offset: 0x0014223C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAuraEnchanted = this.HasAuraEnchanted;
			if (hasAuraEnchanted)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.AuraEnchanted);
			}
			bool hasCursed = this.HasCursed;
			if (hasCursed)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Cursed);
			}
			bool hasColdEnchanted = this.HasColdEnchanted;
			if (hasColdEnchanted)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.ColdEnchanted);
			}
			bool hasExtraFast = this.HasExtraFast;
			if (hasExtraFast)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.ExtraFast);
			}
			bool hasFireEnchanted = this.HasFireEnchanted;
			if (hasFireEnchanted)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.FireEnchanted);
			}
			bool hasLightningEnchanted = this.HasLightningEnchanted;
			if (hasLightningEnchanted)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.LightningEnchanted);
			}
			bool hasMagicResistant = this.HasMagicResistant;
			if (hasMagicResistant)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.MagicResistant);
			}
			bool hasManaBurn = this.HasManaBurn;
			if (hasManaBurn)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.ManaBurn);
			}
			bool hasMultiShot = this.HasMultiShot;
			if (hasMultiShot)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.MultiShot);
			}
			bool hasSpectralHit = this.HasSpectralHit;
			if (hasSpectralHit)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.SpectralHit);
			}
			bool hasStoneSkin = this.HasStoneSkin;
			if (hasStoneSkin)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.StoneSkin);
			}
			bool hasExtraStrong = this.HasExtraStrong;
			if (hasExtraStrong)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.ExtraStrong);
			}
			bool hasTeleport = this.HasTeleport;
			if (hasTeleport)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.Teleport);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060053F7 RID: 21495 RVA: 0x00144234 File Offset: 0x00142434
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAuraEnchanted = this.HasAuraEnchanted;
			if (hasAuraEnchanted)
			{
				num += 2;
			}
			bool hasCursed = this.HasCursed;
			if (hasCursed)
			{
				num += 2;
			}
			bool hasColdEnchanted = this.HasColdEnchanted;
			if (hasColdEnchanted)
			{
				num += 2;
			}
			bool hasExtraFast = this.HasExtraFast;
			if (hasExtraFast)
			{
				num += 2;
			}
			bool hasFireEnchanted = this.HasFireEnchanted;
			if (hasFireEnchanted)
			{
				num += 2;
			}
			bool hasLightningEnchanted = this.HasLightningEnchanted;
			if (hasLightningEnchanted)
			{
				num += 2;
			}
			bool hasMagicResistant = this.HasMagicResistant;
			if (hasMagicResistant)
			{
				num += 2;
			}
			bool hasManaBurn = this.HasManaBurn;
			if (hasManaBurn)
			{
				num += 2;
			}
			bool hasMultiShot = this.HasMultiShot;
			if (hasMultiShot)
			{
				num += 2;
			}
			bool hasSpectralHit = this.HasSpectralHit;
			if (hasSpectralHit)
			{
				num += 2;
			}
			bool hasStoneSkin = this.HasStoneSkin;
			if (hasStoneSkin)
			{
				num += 2;
			}
			bool hasExtraStrong = this.HasExtraStrong;
			if (hasExtraStrong)
			{
				num += 2;
			}
			bool hasTeleport = this.HasTeleport;
			if (hasTeleport)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060053F8 RID: 21496 RVA: 0x00144350 File Offset: 0x00142550
		[DebuggerNonUserCode]
		public void MergeFrom(UniqueBonusState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAuraEnchanted = other.HasAuraEnchanted;
				if (hasAuraEnchanted)
				{
					this.AuraEnchanted = other.AuraEnchanted;
				}
				bool hasCursed = other.HasCursed;
				if (hasCursed)
				{
					this.Cursed = other.Cursed;
				}
				bool hasColdEnchanted = other.HasColdEnchanted;
				if (hasColdEnchanted)
				{
					this.ColdEnchanted = other.ColdEnchanted;
				}
				bool hasExtraFast = other.HasExtraFast;
				if (hasExtraFast)
				{
					this.ExtraFast = other.ExtraFast;
				}
				bool hasFireEnchanted = other.HasFireEnchanted;
				if (hasFireEnchanted)
				{
					this.FireEnchanted = other.FireEnchanted;
				}
				bool hasLightningEnchanted = other.HasLightningEnchanted;
				if (hasLightningEnchanted)
				{
					this.LightningEnchanted = other.LightningEnchanted;
				}
				bool hasMagicResistant = other.HasMagicResistant;
				if (hasMagicResistant)
				{
					this.MagicResistant = other.MagicResistant;
				}
				bool hasManaBurn = other.HasManaBurn;
				if (hasManaBurn)
				{
					this.ManaBurn = other.ManaBurn;
				}
				bool hasMultiShot = other.HasMultiShot;
				if (hasMultiShot)
				{
					this.MultiShot = other.MultiShot;
				}
				bool hasSpectralHit = other.HasSpectralHit;
				if (hasSpectralHit)
				{
					this.SpectralHit = other.SpectralHit;
				}
				bool hasStoneSkin = other.HasStoneSkin;
				if (hasStoneSkin)
				{
					this.StoneSkin = other.StoneSkin;
				}
				bool hasExtraStrong = other.HasExtraStrong;
				if (hasExtraStrong)
				{
					this.ExtraStrong = other.ExtraStrong;
				}
				bool hasTeleport = other.HasTeleport;
				if (hasTeleport)
				{
					this.Teleport = other.Teleport;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060053F9 RID: 21497 RVA: 0x001444DC File Offset: 0x001426DC
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060053FA RID: 21498 RVA: 0x001444E8 File Offset: 0x001426E8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 48U)
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
								this.ColdEnchanted = input.ReadBool();
							}
							else
							{
								this.Cursed = input.ReadBool();
							}
						}
						else
						{
							this.AuraEnchanted = input.ReadBool();
						}
					}
					else if (num3 != 32U)
					{
						if (num3 != 40U)
						{
							if (num3 != 48U)
							{
								goto IL_00A0;
							}
							this.LightningEnchanted = input.ReadBool();
						}
						else
						{
							this.FireEnchanted = input.ReadBool();
						}
					}
					else
					{
						this.ExtraFast = input.ReadBool();
					}
				}
				else if (num3 <= 72U)
				{
					if (num3 != 56U)
					{
						if (num3 != 64U)
						{
							if (num3 != 72U)
							{
								goto IL_00A0;
							}
							this.MultiShot = input.ReadBool();
						}
						else
						{
							this.ManaBurn = input.ReadBool();
						}
					}
					else
					{
						this.MagicResistant = input.ReadBool();
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
						this.StoneSkin = input.ReadBool();
					}
					else
					{
						this.SpectralHit = input.ReadBool();
					}
				}
				else if (num3 != 96U)
				{
					if (num3 != 104U)
					{
						goto IL_00A0;
					}
					this.Teleport = input.ReadBool();
				}
				else
				{
					this.ExtraStrong = input.ReadBool();
				}
				continue;
				IL_00A0:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040025F4 RID: 9716
		private static readonly MessageParser<UniqueBonusState> _parser = new MessageParser<UniqueBonusState>(() => new UniqueBonusState());

		// Token: 0x040025F5 RID: 9717
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025F6 RID: 9718
		private int _hasBits0;

		// Token: 0x040025F7 RID: 9719
		public const int AuraEnchantedFieldNumber = 1;

		// Token: 0x040025F8 RID: 9720
		private static readonly bool AuraEnchantedDefaultValue = false;

		// Token: 0x040025F9 RID: 9721
		private bool auraEnchanted_;

		// Token: 0x040025FA RID: 9722
		public const int CursedFieldNumber = 2;

		// Token: 0x040025FB RID: 9723
		private static readonly bool CursedDefaultValue = false;

		// Token: 0x040025FC RID: 9724
		private bool cursed_;

		// Token: 0x040025FD RID: 9725
		public const int ColdEnchantedFieldNumber = 3;

		// Token: 0x040025FE RID: 9726
		private static readonly bool ColdEnchantedDefaultValue = false;

		// Token: 0x040025FF RID: 9727
		private bool coldEnchanted_;

		// Token: 0x04002600 RID: 9728
		public const int ExtraFastFieldNumber = 4;

		// Token: 0x04002601 RID: 9729
		private static readonly bool ExtraFastDefaultValue = false;

		// Token: 0x04002602 RID: 9730
		private bool extraFast_;

		// Token: 0x04002603 RID: 9731
		public const int FireEnchantedFieldNumber = 5;

		// Token: 0x04002604 RID: 9732
		private static readonly bool FireEnchantedDefaultValue = false;

		// Token: 0x04002605 RID: 9733
		private bool fireEnchanted_;

		// Token: 0x04002606 RID: 9734
		public const int LightningEnchantedFieldNumber = 6;

		// Token: 0x04002607 RID: 9735
		private static readonly bool LightningEnchantedDefaultValue = false;

		// Token: 0x04002608 RID: 9736
		private bool lightningEnchanted_;

		// Token: 0x04002609 RID: 9737
		public const int MagicResistantFieldNumber = 7;

		// Token: 0x0400260A RID: 9738
		private static readonly bool MagicResistantDefaultValue = false;

		// Token: 0x0400260B RID: 9739
		private bool magicResistant_;

		// Token: 0x0400260C RID: 9740
		public const int ManaBurnFieldNumber = 8;

		// Token: 0x0400260D RID: 9741
		private static readonly bool ManaBurnDefaultValue = false;

		// Token: 0x0400260E RID: 9742
		private bool manaBurn_;

		// Token: 0x0400260F RID: 9743
		public const int MultiShotFieldNumber = 9;

		// Token: 0x04002610 RID: 9744
		private static readonly bool MultiShotDefaultValue = false;

		// Token: 0x04002611 RID: 9745
		private bool multiShot_;

		// Token: 0x04002612 RID: 9746
		public const int SpectralHitFieldNumber = 10;

		// Token: 0x04002613 RID: 9747
		private static readonly bool SpectralHitDefaultValue = false;

		// Token: 0x04002614 RID: 9748
		private bool spectralHit_;

		// Token: 0x04002615 RID: 9749
		public const int StoneSkinFieldNumber = 11;

		// Token: 0x04002616 RID: 9750
		private static readonly bool StoneSkinDefaultValue = false;

		// Token: 0x04002617 RID: 9751
		private bool stoneSkin_;

		// Token: 0x04002618 RID: 9752
		public const int ExtraStrongFieldNumber = 12;

		// Token: 0x04002619 RID: 9753
		private static readonly bool ExtraStrongDefaultValue = false;

		// Token: 0x0400261A RID: 9754
		private bool extraStrong_;

		// Token: 0x0400261B RID: 9755
		public const int TeleportFieldNumber = 13;

		// Token: 0x0400261C RID: 9756
		private static readonly bool TeleportDefaultValue = false;

		// Token: 0x0400261D RID: 9757
		private bool teleport_;
	}
}
