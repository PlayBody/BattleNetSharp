using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000C9 RID: 201
	public sealed class NPCLook : IMessage<NPCLook>, IMessage, IEquatable<NPCLook>, IDeepCloneable<NPCLook>, IBufferMessage
	{
		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06001308 RID: 4872 RVA: 0x000457E0 File Offset: 0x000439E0
		[DebuggerNonUserCode]
		public static MessageParser<NPCLook> Parser
		{
			get
			{
				return NPCLook._parser;
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001309 RID: 4873 RVA: 0x000457F8 File Offset: 0x000439F8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[178];
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x0600130A RID: 4874 RVA: 0x00045820 File Offset: 0x00043A20
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NPCLook.Descriptor;
			}
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x00045837 File Offset: 0x00043A37
		[DebuggerNonUserCode]
		public NPCLook()
		{
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x00045844 File Offset: 0x00043A44
		[DebuggerNonUserCode]
		public NPCLook(NPCLook other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.hairColor_ = other.hairColor_;
			this.skinColor_ = other.skinColor_;
			this.headComponent_ = other.headComponent_;
			this.torsoComponent_ = other.torsoComponent_;
			this.legsComponent_ = other.legsComponent_;
			this.helmComponent_ = other.helmComponent_;
			this.headDye_ = other.headDye_;
			this.torsoDye_ = other.torsoDye_;
			this.legsDye_ = other.legsDye_;
			this.helmDye_ = other.helmDye_;
			this.mainHand_ = other.mainHand_;
			this.offHand_ = other.offHand_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x00045908 File Offset: 0x00043B08
		[DebuggerNonUserCode]
		public NPCLook Clone()
		{
			return new NPCLook(this);
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x0600130E RID: 4878 RVA: 0x00045920 File Offset: 0x00043B20
		// (set) Token: 0x0600130F RID: 4879 RVA: 0x00045951 File Offset: 0x00043B51
		[DebuggerNonUserCode]
		public int HairColor
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int hairColorDefaultValue;
				if (flag)
				{
					hairColorDefaultValue = this.hairColor_;
				}
				else
				{
					hairColorDefaultValue = NPCLook.HairColorDefaultValue;
				}
				return hairColorDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.hairColor_ = value;
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001310 RID: 4880 RVA: 0x0004596C File Offset: 0x00043B6C
		[DebuggerNonUserCode]
		public bool HasHairColor
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x00045989 File Offset: 0x00043B89
		[DebuggerNonUserCode]
		public void ClearHairColor()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001312 RID: 4882 RVA: 0x0004599C File Offset: 0x00043B9C
		// (set) Token: 0x06001313 RID: 4883 RVA: 0x000459CD File Offset: 0x00043BCD
		[DebuggerNonUserCode]
		public int SkinColor
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int skinColorDefaultValue;
				if (flag)
				{
					skinColorDefaultValue = this.skinColor_;
				}
				else
				{
					skinColorDefaultValue = NPCLook.SkinColorDefaultValue;
				}
				return skinColorDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.skinColor_ = value;
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001314 RID: 4884 RVA: 0x000459E8 File Offset: 0x00043BE8
		[DebuggerNonUserCode]
		public bool HasSkinColor
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x00045A05 File Offset: 0x00043C05
		[DebuggerNonUserCode]
		public void ClearSkinColor()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06001316 RID: 4886 RVA: 0x00045A18 File Offset: 0x00043C18
		// (set) Token: 0x06001317 RID: 4887 RVA: 0x00045A39 File Offset: 0x00043C39
		[DebuggerNonUserCode]
		public string HeadComponent
		{
			get
			{
				return this.headComponent_ ?? NPCLook.HeadComponentDefaultValue;
			}
			set
			{
				this.headComponent_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06001318 RID: 4888 RVA: 0x00045A50 File Offset: 0x00043C50
		[DebuggerNonUserCode]
		public bool HasHeadComponent
		{
			get
			{
				return this.headComponent_ != null;
			}
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x00045A6B File Offset: 0x00043C6B
		[DebuggerNonUserCode]
		public void ClearHeadComponent()
		{
			this.headComponent_ = null;
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x0600131A RID: 4890 RVA: 0x00045A78 File Offset: 0x00043C78
		// (set) Token: 0x0600131B RID: 4891 RVA: 0x00045A99 File Offset: 0x00043C99
		[DebuggerNonUserCode]
		public string TorsoComponent
		{
			get
			{
				return this.torsoComponent_ ?? NPCLook.TorsoComponentDefaultValue;
			}
			set
			{
				this.torsoComponent_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x0600131C RID: 4892 RVA: 0x00045AB0 File Offset: 0x00043CB0
		[DebuggerNonUserCode]
		public bool HasTorsoComponent
		{
			get
			{
				return this.torsoComponent_ != null;
			}
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x00045ACB File Offset: 0x00043CCB
		[DebuggerNonUserCode]
		public void ClearTorsoComponent()
		{
			this.torsoComponent_ = null;
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x0600131E RID: 4894 RVA: 0x00045AD8 File Offset: 0x00043CD8
		// (set) Token: 0x0600131F RID: 4895 RVA: 0x00045AF9 File Offset: 0x00043CF9
		[DebuggerNonUserCode]
		public string LegsComponent
		{
			get
			{
				return this.legsComponent_ ?? NPCLook.LegsComponentDefaultValue;
			}
			set
			{
				this.legsComponent_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001320 RID: 4896 RVA: 0x00045B10 File Offset: 0x00043D10
		[DebuggerNonUserCode]
		public bool HasLegsComponent
		{
			get
			{
				return this.legsComponent_ != null;
			}
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x00045B2B File Offset: 0x00043D2B
		[DebuggerNonUserCode]
		public void ClearLegsComponent()
		{
			this.legsComponent_ = null;
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06001322 RID: 4898 RVA: 0x00045B38 File Offset: 0x00043D38
		// (set) Token: 0x06001323 RID: 4899 RVA: 0x00045B59 File Offset: 0x00043D59
		[DebuggerNonUserCode]
		public string HelmComponent
		{
			get
			{
				return this.helmComponent_ ?? NPCLook.HelmComponentDefaultValue;
			}
			set
			{
				this.helmComponent_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06001324 RID: 4900 RVA: 0x00045B70 File Offset: 0x00043D70
		[DebuggerNonUserCode]
		public bool HasHelmComponent
		{
			get
			{
				return this.helmComponent_ != null;
			}
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x00045B8B File Offset: 0x00043D8B
		[DebuggerNonUserCode]
		public void ClearHelmComponent()
		{
			this.helmComponent_ = null;
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06001326 RID: 4902 RVA: 0x00045B98 File Offset: 0x00043D98
		// (set) Token: 0x06001327 RID: 4903 RVA: 0x00045BC9 File Offset: 0x00043DC9
		[DebuggerNonUserCode]
		public int HeadDye
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int headDyeDefaultValue;
				if (flag)
				{
					headDyeDefaultValue = this.headDye_;
				}
				else
				{
					headDyeDefaultValue = NPCLook.HeadDyeDefaultValue;
				}
				return headDyeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.headDye_ = value;
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001328 RID: 4904 RVA: 0x00045BE4 File Offset: 0x00043DE4
		[DebuggerNonUserCode]
		public bool HasHeadDye
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x00045C01 File Offset: 0x00043E01
		[DebuggerNonUserCode]
		public void ClearHeadDye()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x0600132A RID: 4906 RVA: 0x00045C14 File Offset: 0x00043E14
		// (set) Token: 0x0600132B RID: 4907 RVA: 0x00045C45 File Offset: 0x00043E45
		[DebuggerNonUserCode]
		public int TorsoDye
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int torsoDyeDefaultValue;
				if (flag)
				{
					torsoDyeDefaultValue = this.torsoDye_;
				}
				else
				{
					torsoDyeDefaultValue = NPCLook.TorsoDyeDefaultValue;
				}
				return torsoDyeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.torsoDye_ = value;
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x0600132C RID: 4908 RVA: 0x00045C60 File Offset: 0x00043E60
		[DebuggerNonUserCode]
		public bool HasTorsoDye
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x00045C7D File Offset: 0x00043E7D
		[DebuggerNonUserCode]
		public void ClearTorsoDye()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x0600132E RID: 4910 RVA: 0x00045C90 File Offset: 0x00043E90
		// (set) Token: 0x0600132F RID: 4911 RVA: 0x00045CC2 File Offset: 0x00043EC2
		[DebuggerNonUserCode]
		public int LegsDye
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				int legsDyeDefaultValue;
				if (flag)
				{
					legsDyeDefaultValue = this.legsDye_;
				}
				else
				{
					legsDyeDefaultValue = NPCLook.LegsDyeDefaultValue;
				}
				return legsDyeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.legsDye_ = value;
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06001330 RID: 4912 RVA: 0x00045CDC File Offset: 0x00043EDC
		[DebuggerNonUserCode]
		public bool HasLegsDye
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x00045CFA File Offset: 0x00043EFA
		[DebuggerNonUserCode]
		public void ClearLegsDye()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001332 RID: 4914 RVA: 0x00045D0C File Offset: 0x00043F0C
		// (set) Token: 0x06001333 RID: 4915 RVA: 0x00045D3E File Offset: 0x00043F3E
		[DebuggerNonUserCode]
		public int HelmDye
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				int helmDyeDefaultValue;
				if (flag)
				{
					helmDyeDefaultValue = this.helmDye_;
				}
				else
				{
					helmDyeDefaultValue = NPCLook.HelmDyeDefaultValue;
				}
				return helmDyeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.helmDye_ = value;
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001334 RID: 4916 RVA: 0x00045D58 File Offset: 0x00043F58
		[DebuggerNonUserCode]
		public bool HasHelmDye
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x00045D76 File Offset: 0x00043F76
		[DebuggerNonUserCode]
		public void ClearHelmDye()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001336 RID: 4918 RVA: 0x00045D88 File Offset: 0x00043F88
		// (set) Token: 0x06001337 RID: 4919 RVA: 0x00045DBA File Offset: 0x00043FBA
		[DebuggerNonUserCode]
		public int MainHand
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				int mainHandDefaultValue;
				if (flag)
				{
					mainHandDefaultValue = this.mainHand_;
				}
				else
				{
					mainHandDefaultValue = NPCLook.MainHandDefaultValue;
				}
				return mainHandDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.mainHand_ = value;
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001338 RID: 4920 RVA: 0x00045DD4 File Offset: 0x00043FD4
		[DebuggerNonUserCode]
		public bool HasMainHand
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x00045DF2 File Offset: 0x00043FF2
		[DebuggerNonUserCode]
		public void ClearMainHand()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x0600133A RID: 4922 RVA: 0x00045E04 File Offset: 0x00044004
		// (set) Token: 0x0600133B RID: 4923 RVA: 0x00045E39 File Offset: 0x00044039
		[DebuggerNonUserCode]
		public int OffHand
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				int offHandDefaultValue;
				if (flag)
				{
					offHandDefaultValue = this.offHand_;
				}
				else
				{
					offHandDefaultValue = NPCLook.OffHandDefaultValue;
				}
				return offHandDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.offHand_ = value;
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x0600133C RID: 4924 RVA: 0x00045E58 File Offset: 0x00044058
		[DebuggerNonUserCode]
		public bool HasOffHand
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x00045E79 File Offset: 0x00044079
		[DebuggerNonUserCode]
		public void ClearOffHand()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x00045E90 File Offset: 0x00044090
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as NPCLook);
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x00045EB0 File Offset: 0x000440B0
		[DebuggerNonUserCode]
		public bool Equals(NPCLook other)
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
					bool flag4 = this.HairColor != other.HairColor;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SkinColor != other.SkinColor;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.HeadComponent != other.HeadComponent;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.TorsoComponent != other.TorsoComponent;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.LegsComponent != other.LegsComponent;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.HelmComponent != other.HelmComponent;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.HeadDye != other.HeadDye;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.TorsoDye != other.TorsoDye;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.LegsDye != other.LegsDye;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.HelmDye != other.HelmDye;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.MainHand != other.MainHand;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.OffHand != other.OffHand;
																flag2 = !flag15 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x06001340 RID: 4928 RVA: 0x00046050 File Offset: 0x00044250
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasHairColor = this.HasHairColor;
			if (hasHairColor)
			{
				num ^= this.HairColor.GetHashCode();
			}
			bool hasSkinColor = this.HasSkinColor;
			if (hasSkinColor)
			{
				num ^= this.SkinColor.GetHashCode();
			}
			bool hasHeadComponent = this.HasHeadComponent;
			if (hasHeadComponent)
			{
				num ^= this.HeadComponent.GetHashCode();
			}
			bool hasTorsoComponent = this.HasTorsoComponent;
			if (hasTorsoComponent)
			{
				num ^= this.TorsoComponent.GetHashCode();
			}
			bool hasLegsComponent = this.HasLegsComponent;
			if (hasLegsComponent)
			{
				num ^= this.LegsComponent.GetHashCode();
			}
			bool hasHelmComponent = this.HasHelmComponent;
			if (hasHelmComponent)
			{
				num ^= this.HelmComponent.GetHashCode();
			}
			bool hasHeadDye = this.HasHeadDye;
			if (hasHeadDye)
			{
				num ^= this.HeadDye.GetHashCode();
			}
			bool hasTorsoDye = this.HasTorsoDye;
			if (hasTorsoDye)
			{
				num ^= this.TorsoDye.GetHashCode();
			}
			bool hasLegsDye = this.HasLegsDye;
			if (hasLegsDye)
			{
				num ^= this.LegsDye.GetHashCode();
			}
			bool hasHelmDye = this.HasHelmDye;
			if (hasHelmDye)
			{
				num ^= this.HelmDye.GetHashCode();
			}
			bool hasMainHand = this.HasMainHand;
			if (hasMainHand)
			{
				num ^= this.MainHand.GetHashCode();
			}
			bool hasOffHand = this.HasOffHand;
			if (hasOffHand)
			{
				num ^= this.OffHand.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x000461D4 File Offset: 0x000443D4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x000461EC File Offset: 0x000443EC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x000461F8 File Offset: 0x000443F8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasHairColor = this.HasHairColor;
			if (hasHairColor)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.HairColor);
			}
			bool hasSkinColor = this.HasSkinColor;
			if (hasSkinColor)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SkinColor);
			}
			bool hasHeadComponent = this.HasHeadComponent;
			if (hasHeadComponent)
			{
				output.WriteRawTag(26);
				output.WriteString(this.HeadComponent);
			}
			bool hasTorsoComponent = this.HasTorsoComponent;
			if (hasTorsoComponent)
			{
				output.WriteRawTag(34);
				output.WriteString(this.TorsoComponent);
			}
			bool hasLegsComponent = this.HasLegsComponent;
			if (hasLegsComponent)
			{
				output.WriteRawTag(42);
				output.WriteString(this.LegsComponent);
			}
			bool hasHelmComponent = this.HasHelmComponent;
			if (hasHelmComponent)
			{
				output.WriteRawTag(50);
				output.WriteString(this.HelmComponent);
			}
			bool hasHeadDye = this.HasHeadDye;
			if (hasHeadDye)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.HeadDye);
			}
			bool hasTorsoDye = this.HasTorsoDye;
			if (hasTorsoDye)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.TorsoDye);
			}
			bool hasLegsDye = this.HasLegsDye;
			if (hasLegsDye)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.LegsDye);
			}
			bool hasHelmDye = this.HasHelmDye;
			if (hasHelmDye)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.HelmDye);
			}
			bool hasMainHand = this.HasMainHand;
			if (hasMainHand)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.MainHand);
			}
			bool hasOffHand = this.HasOffHand;
			if (hasOffHand)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.OffHand);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x000463CC File Offset: 0x000445CC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasHairColor = this.HasHairColor;
			if (hasHairColor)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HairColor);
			}
			bool hasSkinColor = this.HasSkinColor;
			if (hasSkinColor)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinColor);
			}
			bool hasHeadComponent = this.HasHeadComponent;
			if (hasHeadComponent)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.HeadComponent);
			}
			bool hasTorsoComponent = this.HasTorsoComponent;
			if (hasTorsoComponent)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TorsoComponent);
			}
			bool hasLegsComponent = this.HasLegsComponent;
			if (hasLegsComponent)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.LegsComponent);
			}
			bool hasHelmComponent = this.HasHelmComponent;
			if (hasHelmComponent)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.HelmComponent);
			}
			bool hasHeadDye = this.HasHeadDye;
			if (hasHeadDye)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HeadDye);
			}
			bool hasTorsoDye = this.HasTorsoDye;
			if (hasTorsoDye)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TorsoDye);
			}
			bool hasLegsDye = this.HasLegsDye;
			if (hasLegsDye)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LegsDye);
			}
			bool hasHelmDye = this.HasHelmDye;
			if (hasHelmDye)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HelmDye);
			}
			bool hasMainHand = this.HasMainHand;
			if (hasMainHand)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MainHand);
			}
			bool hasOffHand = this.HasOffHand;
			if (hasOffHand)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OffHand);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x00046564 File Offset: 0x00044764
		[DebuggerNonUserCode]
		public void MergeFrom(NPCLook other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasHairColor = other.HasHairColor;
				if (hasHairColor)
				{
					this.HairColor = other.HairColor;
				}
				bool hasSkinColor = other.HasSkinColor;
				if (hasSkinColor)
				{
					this.SkinColor = other.SkinColor;
				}
				bool hasHeadComponent = other.HasHeadComponent;
				if (hasHeadComponent)
				{
					this.HeadComponent = other.HeadComponent;
				}
				bool hasTorsoComponent = other.HasTorsoComponent;
				if (hasTorsoComponent)
				{
					this.TorsoComponent = other.TorsoComponent;
				}
				bool hasLegsComponent = other.HasLegsComponent;
				if (hasLegsComponent)
				{
					this.LegsComponent = other.LegsComponent;
				}
				bool hasHelmComponent = other.HasHelmComponent;
				if (hasHelmComponent)
				{
					this.HelmComponent = other.HelmComponent;
				}
				bool hasHeadDye = other.HasHeadDye;
				if (hasHeadDye)
				{
					this.HeadDye = other.HeadDye;
				}
				bool hasTorsoDye = other.HasTorsoDye;
				if (hasTorsoDye)
				{
					this.TorsoDye = other.TorsoDye;
				}
				bool hasLegsDye = other.HasLegsDye;
				if (hasLegsDye)
				{
					this.LegsDye = other.LegsDye;
				}
				bool hasHelmDye = other.HasHelmDye;
				if (hasHelmDye)
				{
					this.HelmDye = other.HelmDye;
				}
				bool hasMainHand = other.HasMainHand;
				if (hasMainHand)
				{
					this.MainHand = other.MainHand;
				}
				bool hasOffHand = other.HasOffHand;
				if (hasOffHand)
				{
					this.OffHand = other.OffHand;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x000466D5 File Offset: 0x000448D5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x000466E0 File Offset: 0x000448E0
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
					if (num3 <= 26U)
					{
						if (num3 != 8U)
						{
							if (num3 != 16U)
							{
								if (num3 != 26U)
								{
									goto IL_0091;
								}
								this.HeadComponent = input.ReadString();
							}
							else
							{
								this.SkinColor = input.ReadInt32();
							}
						}
						else
						{
							this.HairColor = input.ReadInt32();
						}
					}
					else if (num3 != 34U)
					{
						if (num3 != 42U)
						{
							if (num3 != 50U)
							{
								goto IL_0091;
							}
							this.HelmComponent = input.ReadString();
						}
						else
						{
							this.LegsComponent = input.ReadString();
						}
					}
					else
					{
						this.TorsoComponent = input.ReadString();
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
								goto IL_0091;
							}
							this.LegsDye = input.ReadInt32();
						}
						else
						{
							this.TorsoDye = input.ReadInt32();
						}
					}
					else
					{
						this.HeadDye = input.ReadInt32();
					}
				}
				else if (num3 != 80U)
				{
					if (num3 != 88U)
					{
						if (num3 != 96U)
						{
							goto IL_0091;
						}
						this.OffHand = input.ReadInt32();
					}
					else
					{
						this.MainHand = input.ReadInt32();
					}
				}
				else
				{
					this.HelmDye = input.ReadInt32();
				}
				continue;
				IL_0091:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040007AB RID: 1963
		private static readonly MessageParser<NPCLook> _parser = new MessageParser<NPCLook>(() => new NPCLook());

		// Token: 0x040007AC RID: 1964
		private UnknownFieldSet _unknownFields;

		// Token: 0x040007AD RID: 1965
		private int _hasBits0;

		// Token: 0x040007AE RID: 1966
		public const int HairColorFieldNumber = 1;

		// Token: 0x040007AF RID: 1967
		private static readonly int HairColorDefaultValue = 0;

		// Token: 0x040007B0 RID: 1968
		private int hairColor_;

		// Token: 0x040007B1 RID: 1969
		public const int SkinColorFieldNumber = 2;

		// Token: 0x040007B2 RID: 1970
		private static readonly int SkinColorDefaultValue = 0;

		// Token: 0x040007B3 RID: 1971
		private int skinColor_;

		// Token: 0x040007B4 RID: 1972
		public const int HeadComponentFieldNumber = 3;

		// Token: 0x040007B5 RID: 1973
		private static readonly string HeadComponentDefaultValue = "";

		// Token: 0x040007B6 RID: 1974
		private string headComponent_;

		// Token: 0x040007B7 RID: 1975
		public const int TorsoComponentFieldNumber = 4;

		// Token: 0x040007B8 RID: 1976
		private static readonly string TorsoComponentDefaultValue = "";

		// Token: 0x040007B9 RID: 1977
		private string torsoComponent_;

		// Token: 0x040007BA RID: 1978
		public const int LegsComponentFieldNumber = 5;

		// Token: 0x040007BB RID: 1979
		private static readonly string LegsComponentDefaultValue = "";

		// Token: 0x040007BC RID: 1980
		private string legsComponent_;

		// Token: 0x040007BD RID: 1981
		public const int HelmComponentFieldNumber = 6;

		// Token: 0x040007BE RID: 1982
		private static readonly string HelmComponentDefaultValue = "";

		// Token: 0x040007BF RID: 1983
		private string helmComponent_;

		// Token: 0x040007C0 RID: 1984
		public const int HeadDyeFieldNumber = 7;

		// Token: 0x040007C1 RID: 1985
		private static readonly int HeadDyeDefaultValue = 0;

		// Token: 0x040007C2 RID: 1986
		private int headDye_;

		// Token: 0x040007C3 RID: 1987
		public const int TorsoDyeFieldNumber = 8;

		// Token: 0x040007C4 RID: 1988
		private static readonly int TorsoDyeDefaultValue = 0;

		// Token: 0x040007C5 RID: 1989
		private int torsoDye_;

		// Token: 0x040007C6 RID: 1990
		public const int LegsDyeFieldNumber = 9;

		// Token: 0x040007C7 RID: 1991
		private static readonly int LegsDyeDefaultValue = 0;

		// Token: 0x040007C8 RID: 1992
		private int legsDye_;

		// Token: 0x040007C9 RID: 1993
		public const int HelmDyeFieldNumber = 10;

		// Token: 0x040007CA RID: 1994
		private static readonly int HelmDyeDefaultValue = 0;

		// Token: 0x040007CB RID: 1995
		private int helmDye_;

		// Token: 0x040007CC RID: 1996
		public const int MainHandFieldNumber = 11;

		// Token: 0x040007CD RID: 1997
		private static readonly int MainHandDefaultValue = 0;

		// Token: 0x040007CE RID: 1998
		private int mainHand_;

		// Token: 0x040007CF RID: 1999
		public const int OffHandFieldNumber = 12;

		// Token: 0x040007D0 RID: 2000
		private static readonly int OffHandDefaultValue = 0;

		// Token: 0x040007D1 RID: 2001
		private int offHand_;
	}
}
