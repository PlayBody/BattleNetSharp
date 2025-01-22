using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Clan
{
	// Token: 0x020002B7 RID: 695
	public sealed class ClanHeraldry : IMessage<ClanHeraldry>, IMessage, IEquatable<ClanHeraldry>, IDeepCloneable<ClanHeraldry>, IBufferMessage
	{
		// Token: 0x1700177D RID: 6013
		// (get) Token: 0x060049EF RID: 18927 RVA: 0x0011B514 File Offset: 0x00119714
		[DebuggerNonUserCode]
		public static MessageParser<ClanHeraldry> Parser
		{
			get
			{
				return ClanHeraldry._parser;
			}
		}

		// Token: 0x1700177E RID: 6014
		// (get) Token: 0x060049F0 RID: 18928 RVA: 0x0011B52C File Offset: 0x0011972C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClanReflection.Descriptor.MessageTypes[12];
			}
		}

		// Token: 0x1700177F RID: 6015
		// (get) Token: 0x060049F1 RID: 18929 RVA: 0x0011B550 File Offset: 0x00119750
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClanHeraldry.Descriptor;
			}
		}

		// Token: 0x060049F2 RID: 18930 RVA: 0x0011B567 File Offset: 0x00119767
		[DebuggerNonUserCode]
		public ClanHeraldry()
		{
		}

		// Token: 0x060049F3 RID: 18931 RVA: 0x0011B57C File Offset: 0x0011977C
		[DebuggerNonUserCode]
		public ClanHeraldry(ClanHeraldry other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.baseBannerShapeName_ = other.baseBannerShapeName_;
			this.baseTextilePatternName_ = other.baseTextilePatternName_;
			this.baseTextileTextureName_ = other.baseTextileTextureName_;
			this.baseEmbroideryName_ = other.baseEmbroideryName_;
			this.baseTrimName_ = other.baseTrimName_;
			this.dyeTextilePrimaryName_ = other.dyeTextilePrimaryName_;
			this.dyeTextileSecondaryName_ = other.dyeTextileSecondaryName_;
			this.dyeTextileTertiaryName_ = other.dyeTextileTertiaryName_;
			this.dyeTrimName_ = other.dyeTrimName_;
			this.dyeIconographyName_ = other.dyeIconographyName_;
			this.dyeEmbroideryName_ = other.dyeEmbroideryName_;
			this.iconLayoutIndex_ = other.iconLayoutIndex_;
			this.heraldryIcons_ = other.heraldryIcons_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060049F4 RID: 18932 RVA: 0x0011B650 File Offset: 0x00119850
		[DebuggerNonUserCode]
		public ClanHeraldry Clone()
		{
			return new ClanHeraldry(this);
		}

		// Token: 0x17001780 RID: 6016
		// (get) Token: 0x060049F5 RID: 18933 RVA: 0x0011B668 File Offset: 0x00119868
		// (set) Token: 0x060049F6 RID: 18934 RVA: 0x0011B699 File Offset: 0x00119899
		[DebuggerNonUserCode]
		public uint BaseBannerShapeName
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint baseBannerShapeNameDefaultValue;
				if (flag)
				{
					baseBannerShapeNameDefaultValue = this.baseBannerShapeName_;
				}
				else
				{
					baseBannerShapeNameDefaultValue = ClanHeraldry.BaseBannerShapeNameDefaultValue;
				}
				return baseBannerShapeNameDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.baseBannerShapeName_ = value;
			}
		}

		// Token: 0x17001781 RID: 6017
		// (get) Token: 0x060049F7 RID: 18935 RVA: 0x0011B6B4 File Offset: 0x001198B4
		[DebuggerNonUserCode]
		public bool HasBaseBannerShapeName
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060049F8 RID: 18936 RVA: 0x0011B6D1 File Offset: 0x001198D1
		[DebuggerNonUserCode]
		public void ClearBaseBannerShapeName()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001782 RID: 6018
		// (get) Token: 0x060049F9 RID: 18937 RVA: 0x0011B6E4 File Offset: 0x001198E4
		// (set) Token: 0x060049FA RID: 18938 RVA: 0x0011B715 File Offset: 0x00119915
		[DebuggerNonUserCode]
		public uint BaseTextilePatternName
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint baseTextilePatternNameDefaultValue;
				if (flag)
				{
					baseTextilePatternNameDefaultValue = this.baseTextilePatternName_;
				}
				else
				{
					baseTextilePatternNameDefaultValue = ClanHeraldry.BaseTextilePatternNameDefaultValue;
				}
				return baseTextilePatternNameDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.baseTextilePatternName_ = value;
			}
		}

		// Token: 0x17001783 RID: 6019
		// (get) Token: 0x060049FB RID: 18939 RVA: 0x0011B730 File Offset: 0x00119930
		[DebuggerNonUserCode]
		public bool HasBaseTextilePatternName
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060049FC RID: 18940 RVA: 0x0011B74D File Offset: 0x0011994D
		[DebuggerNonUserCode]
		public void ClearBaseTextilePatternName()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001784 RID: 6020
		// (get) Token: 0x060049FD RID: 18941 RVA: 0x0011B760 File Offset: 0x00119960
		// (set) Token: 0x060049FE RID: 18942 RVA: 0x0011B791 File Offset: 0x00119991
		[DebuggerNonUserCode]
		public uint BaseTextileTextureName
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint baseTextileTextureNameDefaultValue;
				if (flag)
				{
					baseTextileTextureNameDefaultValue = this.baseTextileTextureName_;
				}
				else
				{
					baseTextileTextureNameDefaultValue = ClanHeraldry.BaseTextileTextureNameDefaultValue;
				}
				return baseTextileTextureNameDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.baseTextileTextureName_ = value;
			}
		}

		// Token: 0x17001785 RID: 6021
		// (get) Token: 0x060049FF RID: 18943 RVA: 0x0011B7AC File Offset: 0x001199AC
		[DebuggerNonUserCode]
		public bool HasBaseTextileTextureName
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06004A00 RID: 18944 RVA: 0x0011B7C9 File Offset: 0x001199C9
		[DebuggerNonUserCode]
		public void ClearBaseTextileTextureName()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001786 RID: 6022
		// (get) Token: 0x06004A01 RID: 18945 RVA: 0x0011B7DC File Offset: 0x001199DC
		// (set) Token: 0x06004A02 RID: 18946 RVA: 0x0011B80D File Offset: 0x00119A0D
		[DebuggerNonUserCode]
		public uint BaseEmbroideryName
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint baseEmbroideryNameDefaultValue;
				if (flag)
				{
					baseEmbroideryNameDefaultValue = this.baseEmbroideryName_;
				}
				else
				{
					baseEmbroideryNameDefaultValue = ClanHeraldry.BaseEmbroideryNameDefaultValue;
				}
				return baseEmbroideryNameDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.baseEmbroideryName_ = value;
			}
		}

		// Token: 0x17001787 RID: 6023
		// (get) Token: 0x06004A03 RID: 18947 RVA: 0x0011B828 File Offset: 0x00119A28
		[DebuggerNonUserCode]
		public bool HasBaseEmbroideryName
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06004A04 RID: 18948 RVA: 0x0011B845 File Offset: 0x00119A45
		[DebuggerNonUserCode]
		public void ClearBaseEmbroideryName()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17001788 RID: 6024
		// (get) Token: 0x06004A05 RID: 18949 RVA: 0x0011B858 File Offset: 0x00119A58
		// (set) Token: 0x06004A06 RID: 18950 RVA: 0x0011B88A File Offset: 0x00119A8A
		[DebuggerNonUserCode]
		public uint BaseTrimName
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint baseTrimNameDefaultValue;
				if (flag)
				{
					baseTrimNameDefaultValue = this.baseTrimName_;
				}
				else
				{
					baseTrimNameDefaultValue = ClanHeraldry.BaseTrimNameDefaultValue;
				}
				return baseTrimNameDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.baseTrimName_ = value;
			}
		}

		// Token: 0x17001789 RID: 6025
		// (get) Token: 0x06004A07 RID: 18951 RVA: 0x0011B8A4 File Offset: 0x00119AA4
		[DebuggerNonUserCode]
		public bool HasBaseTrimName
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06004A08 RID: 18952 RVA: 0x0011B8C2 File Offset: 0x00119AC2
		[DebuggerNonUserCode]
		public void ClearBaseTrimName()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x1700178A RID: 6026
		// (get) Token: 0x06004A09 RID: 18953 RVA: 0x0011B8D4 File Offset: 0x00119AD4
		// (set) Token: 0x06004A0A RID: 18954 RVA: 0x0011B906 File Offset: 0x00119B06
		[DebuggerNonUserCode]
		public uint DyeTextilePrimaryName
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				uint dyeTextilePrimaryNameDefaultValue;
				if (flag)
				{
					dyeTextilePrimaryNameDefaultValue = this.dyeTextilePrimaryName_;
				}
				else
				{
					dyeTextilePrimaryNameDefaultValue = ClanHeraldry.DyeTextilePrimaryNameDefaultValue;
				}
				return dyeTextilePrimaryNameDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.dyeTextilePrimaryName_ = value;
			}
		}

		// Token: 0x1700178B RID: 6027
		// (get) Token: 0x06004A0B RID: 18955 RVA: 0x0011B920 File Offset: 0x00119B20
		[DebuggerNonUserCode]
		public bool HasDyeTextilePrimaryName
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06004A0C RID: 18956 RVA: 0x0011B93E File Offset: 0x00119B3E
		[DebuggerNonUserCode]
		public void ClearDyeTextilePrimaryName()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x1700178C RID: 6028
		// (get) Token: 0x06004A0D RID: 18957 RVA: 0x0011B950 File Offset: 0x00119B50
		// (set) Token: 0x06004A0E RID: 18958 RVA: 0x0011B982 File Offset: 0x00119B82
		[DebuggerNonUserCode]
		public uint DyeTextileSecondaryName
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				uint dyeTextileSecondaryNameDefaultValue;
				if (flag)
				{
					dyeTextileSecondaryNameDefaultValue = this.dyeTextileSecondaryName_;
				}
				else
				{
					dyeTextileSecondaryNameDefaultValue = ClanHeraldry.DyeTextileSecondaryNameDefaultValue;
				}
				return dyeTextileSecondaryNameDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.dyeTextileSecondaryName_ = value;
			}
		}

		// Token: 0x1700178D RID: 6029
		// (get) Token: 0x06004A0F RID: 18959 RVA: 0x0011B99C File Offset: 0x00119B9C
		[DebuggerNonUserCode]
		public bool HasDyeTextileSecondaryName
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06004A10 RID: 18960 RVA: 0x0011B9BA File Offset: 0x00119BBA
		[DebuggerNonUserCode]
		public void ClearDyeTextileSecondaryName()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x1700178E RID: 6030
		// (get) Token: 0x06004A11 RID: 18961 RVA: 0x0011B9CC File Offset: 0x00119BCC
		// (set) Token: 0x06004A12 RID: 18962 RVA: 0x0011BA01 File Offset: 0x00119C01
		[DebuggerNonUserCode]
		public uint DyeTextileTertiaryName
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				uint dyeTextileTertiaryNameDefaultValue;
				if (flag)
				{
					dyeTextileTertiaryNameDefaultValue = this.dyeTextileTertiaryName_;
				}
				else
				{
					dyeTextileTertiaryNameDefaultValue = ClanHeraldry.DyeTextileTertiaryNameDefaultValue;
				}
				return dyeTextileTertiaryNameDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.dyeTextileTertiaryName_ = value;
			}
		}

		// Token: 0x1700178F RID: 6031
		// (get) Token: 0x06004A13 RID: 18963 RVA: 0x0011BA20 File Offset: 0x00119C20
		[DebuggerNonUserCode]
		public bool HasDyeTextileTertiaryName
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x06004A14 RID: 18964 RVA: 0x0011BA41 File Offset: 0x00119C41
		[DebuggerNonUserCode]
		public void ClearDyeTextileTertiaryName()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x17001790 RID: 6032
		// (get) Token: 0x06004A15 RID: 18965 RVA: 0x0011BA58 File Offset: 0x00119C58
		// (set) Token: 0x06004A16 RID: 18966 RVA: 0x0011BA8D File Offset: 0x00119C8D
		[DebuggerNonUserCode]
		public uint DyeTrimName
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				uint dyeTrimNameDefaultValue;
				if (flag)
				{
					dyeTrimNameDefaultValue = this.dyeTrimName_;
				}
				else
				{
					dyeTrimNameDefaultValue = ClanHeraldry.DyeTrimNameDefaultValue;
				}
				return dyeTrimNameDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.dyeTrimName_ = value;
			}
		}

		// Token: 0x17001791 RID: 6033
		// (get) Token: 0x06004A17 RID: 18967 RVA: 0x0011BAAC File Offset: 0x00119CAC
		[DebuggerNonUserCode]
		public bool HasDyeTrimName
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x06004A18 RID: 18968 RVA: 0x0011BACD File Offset: 0x00119CCD
		[DebuggerNonUserCode]
		public void ClearDyeTrimName()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x17001792 RID: 6034
		// (get) Token: 0x06004A19 RID: 18969 RVA: 0x0011BAE4 File Offset: 0x00119CE4
		// (set) Token: 0x06004A1A RID: 18970 RVA: 0x0011BB19 File Offset: 0x00119D19
		[DebuggerNonUserCode]
		public uint DyeIconographyName
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				uint dyeIconographyNameDefaultValue;
				if (flag)
				{
					dyeIconographyNameDefaultValue = this.dyeIconographyName_;
				}
				else
				{
					dyeIconographyNameDefaultValue = ClanHeraldry.DyeIconographyNameDefaultValue;
				}
				return dyeIconographyNameDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.dyeIconographyName_ = value;
			}
		}

		// Token: 0x17001793 RID: 6035
		// (get) Token: 0x06004A1B RID: 18971 RVA: 0x0011BB38 File Offset: 0x00119D38
		[DebuggerNonUserCode]
		public bool HasDyeIconographyName
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x06004A1C RID: 18972 RVA: 0x0011BB59 File Offset: 0x00119D59
		[DebuggerNonUserCode]
		public void ClearDyeIconographyName()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x17001794 RID: 6036
		// (get) Token: 0x06004A1D RID: 18973 RVA: 0x0011BB70 File Offset: 0x00119D70
		// (set) Token: 0x06004A1E RID: 18974 RVA: 0x0011BBA5 File Offset: 0x00119DA5
		[DebuggerNonUserCode]
		public uint DyeEmbroideryName
		{
			get
			{
				bool flag = (this._hasBits0 & 1024) != 0;
				uint dyeEmbroideryNameDefaultValue;
				if (flag)
				{
					dyeEmbroideryNameDefaultValue = this.dyeEmbroideryName_;
				}
				else
				{
					dyeEmbroideryNameDefaultValue = ClanHeraldry.DyeEmbroideryNameDefaultValue;
				}
				return dyeEmbroideryNameDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1024;
				this.dyeEmbroideryName_ = value;
			}
		}

		// Token: 0x17001795 RID: 6037
		// (get) Token: 0x06004A1F RID: 18975 RVA: 0x0011BBC4 File Offset: 0x00119DC4
		[DebuggerNonUserCode]
		public bool HasDyeEmbroideryName
		{
			get
			{
				return (this._hasBits0 & 1024) != 0;
			}
		}

		// Token: 0x06004A20 RID: 18976 RVA: 0x0011BBE5 File Offset: 0x00119DE5
		[DebuggerNonUserCode]
		public void ClearDyeEmbroideryName()
		{
			this._hasBits0 &= -1025;
		}

		// Token: 0x17001796 RID: 6038
		// (get) Token: 0x06004A21 RID: 18977 RVA: 0x0011BBFC File Offset: 0x00119DFC
		// (set) Token: 0x06004A22 RID: 18978 RVA: 0x0011BC31 File Offset: 0x00119E31
		[DebuggerNonUserCode]
		public uint IconLayoutIndex
		{
			get
			{
				bool flag = (this._hasBits0 & 2048) != 0;
				uint iconLayoutIndexDefaultValue;
				if (flag)
				{
					iconLayoutIndexDefaultValue = this.iconLayoutIndex_;
				}
				else
				{
					iconLayoutIndexDefaultValue = ClanHeraldry.IconLayoutIndexDefaultValue;
				}
				return iconLayoutIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2048;
				this.iconLayoutIndex_ = value;
			}
		}

		// Token: 0x17001797 RID: 6039
		// (get) Token: 0x06004A23 RID: 18979 RVA: 0x0011BC50 File Offset: 0x00119E50
		[DebuggerNonUserCode]
		public bool HasIconLayoutIndex
		{
			get
			{
				return (this._hasBits0 & 2048) != 0;
			}
		}

		// Token: 0x06004A24 RID: 18980 RVA: 0x0011BC71 File Offset: 0x00119E71
		[DebuggerNonUserCode]
		public void ClearIconLayoutIndex()
		{
			this._hasBits0 &= -2049;
		}

		// Token: 0x17001798 RID: 6040
		// (get) Token: 0x06004A25 RID: 18981 RVA: 0x0011BC88 File Offset: 0x00119E88
		[DebuggerNonUserCode]
		public RepeatedField<HeraldryIcon> HeraldryIcons
		{
			get
			{
				return this.heraldryIcons_;
			}
		}

		// Token: 0x06004A26 RID: 18982 RVA: 0x0011BCA0 File Offset: 0x00119EA0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClanHeraldry);
		}

		// Token: 0x06004A27 RID: 18983 RVA: 0x0011BCC0 File Offset: 0x00119EC0
		[DebuggerNonUserCode]
		public bool Equals(ClanHeraldry other)
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
					bool flag4 = this.BaseBannerShapeName != other.BaseBannerShapeName;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.BaseTextilePatternName != other.BaseTextilePatternName;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.BaseTextileTextureName != other.BaseTextileTextureName;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.BaseEmbroideryName != other.BaseEmbroideryName;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.BaseTrimName != other.BaseTrimName;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.DyeTextilePrimaryName != other.DyeTextilePrimaryName;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.DyeTextileSecondaryName != other.DyeTextileSecondaryName;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.DyeTextileTertiaryName != other.DyeTextileTertiaryName;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.DyeTrimName != other.DyeTrimName;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.DyeIconographyName != other.DyeIconographyName;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.DyeEmbroideryName != other.DyeEmbroideryName;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.IconLayoutIndex != other.IconLayoutIndex;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = !this.heraldryIcons_.Equals(other.heraldryIcons_);
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

		// Token: 0x06004A28 RID: 18984 RVA: 0x0011BE80 File Offset: 0x0011A080
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasBaseBannerShapeName = this.HasBaseBannerShapeName;
			if (hasBaseBannerShapeName)
			{
				num ^= this.BaseBannerShapeName.GetHashCode();
			}
			bool hasBaseTextilePatternName = this.HasBaseTextilePatternName;
			if (hasBaseTextilePatternName)
			{
				num ^= this.BaseTextilePatternName.GetHashCode();
			}
			bool hasBaseTextileTextureName = this.HasBaseTextileTextureName;
			if (hasBaseTextileTextureName)
			{
				num ^= this.BaseTextileTextureName.GetHashCode();
			}
			bool hasBaseEmbroideryName = this.HasBaseEmbroideryName;
			if (hasBaseEmbroideryName)
			{
				num ^= this.BaseEmbroideryName.GetHashCode();
			}
			bool hasBaseTrimName = this.HasBaseTrimName;
			if (hasBaseTrimName)
			{
				num ^= this.BaseTrimName.GetHashCode();
			}
			bool hasDyeTextilePrimaryName = this.HasDyeTextilePrimaryName;
			if (hasDyeTextilePrimaryName)
			{
				num ^= this.DyeTextilePrimaryName.GetHashCode();
			}
			bool hasDyeTextileSecondaryName = this.HasDyeTextileSecondaryName;
			if (hasDyeTextileSecondaryName)
			{
				num ^= this.DyeTextileSecondaryName.GetHashCode();
			}
			bool hasDyeTextileTertiaryName = this.HasDyeTextileTertiaryName;
			if (hasDyeTextileTertiaryName)
			{
				num ^= this.DyeTextileTertiaryName.GetHashCode();
			}
			bool hasDyeTrimName = this.HasDyeTrimName;
			if (hasDyeTrimName)
			{
				num ^= this.DyeTrimName.GetHashCode();
			}
			bool hasDyeIconographyName = this.HasDyeIconographyName;
			if (hasDyeIconographyName)
			{
				num ^= this.DyeIconographyName.GetHashCode();
			}
			bool hasDyeEmbroideryName = this.HasDyeEmbroideryName;
			if (hasDyeEmbroideryName)
			{
				num ^= this.DyeEmbroideryName.GetHashCode();
			}
			bool hasIconLayoutIndex = this.HasIconLayoutIndex;
			if (hasIconLayoutIndex)
			{
				num ^= this.IconLayoutIndex.GetHashCode();
			}
			num ^= this.heraldryIcons_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004A29 RID: 18985 RVA: 0x0011C01C File Offset: 0x0011A21C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004A2A RID: 18986 RVA: 0x0011C034 File Offset: 0x0011A234
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004A2B RID: 18987 RVA: 0x0011C040 File Offset: 0x0011A240
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasBaseBannerShapeName = this.HasBaseBannerShapeName;
			if (hasBaseBannerShapeName)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.BaseBannerShapeName);
			}
			bool hasBaseTextilePatternName = this.HasBaseTextilePatternName;
			if (hasBaseTextilePatternName)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.BaseTextilePatternName);
			}
			bool hasBaseTextileTextureName = this.HasBaseTextileTextureName;
			if (hasBaseTextileTextureName)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.BaseTextileTextureName);
			}
			bool hasBaseEmbroideryName = this.HasBaseEmbroideryName;
			if (hasBaseEmbroideryName)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.BaseEmbroideryName);
			}
			bool hasBaseTrimName = this.HasBaseTrimName;
			if (hasBaseTrimName)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.BaseTrimName);
			}
			bool hasDyeTextilePrimaryName = this.HasDyeTextilePrimaryName;
			if (hasDyeTextilePrimaryName)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.DyeTextilePrimaryName);
			}
			bool hasDyeTextileSecondaryName = this.HasDyeTextileSecondaryName;
			if (hasDyeTextileSecondaryName)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.DyeTextileSecondaryName);
			}
			bool hasDyeTextileTertiaryName = this.HasDyeTextileTertiaryName;
			if (hasDyeTextileTertiaryName)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.DyeTextileTertiaryName);
			}
			bool hasDyeTrimName = this.HasDyeTrimName;
			if (hasDyeTrimName)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.DyeTrimName);
			}
			bool hasDyeIconographyName = this.HasDyeIconographyName;
			if (hasDyeIconographyName)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.DyeIconographyName);
			}
			bool hasDyeEmbroideryName = this.HasDyeEmbroideryName;
			if (hasDyeEmbroideryName)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.DyeEmbroideryName);
			}
			bool hasIconLayoutIndex = this.HasIconLayoutIndex;
			if (hasIconLayoutIndex)
			{
				output.WriteRawTag(160, 1);
				output.WriteUInt32(this.IconLayoutIndex);
			}
			this.heraldryIcons_.WriteTo(ref output, ClanHeraldry._repeated_heraldryIcons_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004A2C RID: 18988 RVA: 0x0011C22C File Offset: 0x0011A42C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasBaseBannerShapeName = this.HasBaseBannerShapeName;
			if (hasBaseBannerShapeName)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BaseBannerShapeName);
			}
			bool hasBaseTextilePatternName = this.HasBaseTextilePatternName;
			if (hasBaseTextilePatternName)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BaseTextilePatternName);
			}
			bool hasBaseTextileTextureName = this.HasBaseTextileTextureName;
			if (hasBaseTextileTextureName)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BaseTextileTextureName);
			}
			bool hasBaseEmbroideryName = this.HasBaseEmbroideryName;
			if (hasBaseEmbroideryName)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BaseEmbroideryName);
			}
			bool hasBaseTrimName = this.HasBaseTrimName;
			if (hasBaseTrimName)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BaseTrimName);
			}
			bool hasDyeTextilePrimaryName = this.HasDyeTextilePrimaryName;
			if (hasDyeTextilePrimaryName)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DyeTextilePrimaryName);
			}
			bool hasDyeTextileSecondaryName = this.HasDyeTextileSecondaryName;
			if (hasDyeTextileSecondaryName)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DyeTextileSecondaryName);
			}
			bool hasDyeTextileTertiaryName = this.HasDyeTextileTertiaryName;
			if (hasDyeTextileTertiaryName)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DyeTextileTertiaryName);
			}
			bool hasDyeTrimName = this.HasDyeTrimName;
			if (hasDyeTrimName)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DyeTrimName);
			}
			bool hasDyeIconographyName = this.HasDyeIconographyName;
			if (hasDyeIconographyName)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DyeIconographyName);
			}
			bool hasDyeEmbroideryName = this.HasDyeEmbroideryName;
			if (hasDyeEmbroideryName)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DyeEmbroideryName);
			}
			bool hasIconLayoutIndex = this.HasIconLayoutIndex;
			if (hasIconLayoutIndex)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.IconLayoutIndex);
			}
			num += this.heraldryIcons_.CalculateSize(ClanHeraldry._repeated_heraldryIcons_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004A2D RID: 18989 RVA: 0x0011C3D8 File Offset: 0x0011A5D8
		[DebuggerNonUserCode]
		public void MergeFrom(ClanHeraldry other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasBaseBannerShapeName = other.HasBaseBannerShapeName;
				if (hasBaseBannerShapeName)
				{
					this.BaseBannerShapeName = other.BaseBannerShapeName;
				}
				bool hasBaseTextilePatternName = other.HasBaseTextilePatternName;
				if (hasBaseTextilePatternName)
				{
					this.BaseTextilePatternName = other.BaseTextilePatternName;
				}
				bool hasBaseTextileTextureName = other.HasBaseTextileTextureName;
				if (hasBaseTextileTextureName)
				{
					this.BaseTextileTextureName = other.BaseTextileTextureName;
				}
				bool hasBaseEmbroideryName = other.HasBaseEmbroideryName;
				if (hasBaseEmbroideryName)
				{
					this.BaseEmbroideryName = other.BaseEmbroideryName;
				}
				bool hasBaseTrimName = other.HasBaseTrimName;
				if (hasBaseTrimName)
				{
					this.BaseTrimName = other.BaseTrimName;
				}
				bool hasDyeTextilePrimaryName = other.HasDyeTextilePrimaryName;
				if (hasDyeTextilePrimaryName)
				{
					this.DyeTextilePrimaryName = other.DyeTextilePrimaryName;
				}
				bool hasDyeTextileSecondaryName = other.HasDyeTextileSecondaryName;
				if (hasDyeTextileSecondaryName)
				{
					this.DyeTextileSecondaryName = other.DyeTextileSecondaryName;
				}
				bool hasDyeTextileTertiaryName = other.HasDyeTextileTertiaryName;
				if (hasDyeTextileTertiaryName)
				{
					this.DyeTextileTertiaryName = other.DyeTextileTertiaryName;
				}
				bool hasDyeTrimName = other.HasDyeTrimName;
				if (hasDyeTrimName)
				{
					this.DyeTrimName = other.DyeTrimName;
				}
				bool hasDyeIconographyName = other.HasDyeIconographyName;
				if (hasDyeIconographyName)
				{
					this.DyeIconographyName = other.DyeIconographyName;
				}
				bool hasDyeEmbroideryName = other.HasDyeEmbroideryName;
				if (hasDyeEmbroideryName)
				{
					this.DyeEmbroideryName = other.DyeEmbroideryName;
				}
				bool hasIconLayoutIndex = other.HasIconLayoutIndex;
				if (hasIconLayoutIndex)
				{
					this.IconLayoutIndex = other.IconLayoutIndex;
				}
				this.heraldryIcons_.Add(other.heraldryIcons_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004A2E RID: 18990 RVA: 0x0011C55B File Offset: 0x0011A75B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004A2F RID: 18991 RVA: 0x0011C568 File Offset: 0x0011A768
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
									goto IL_00A6;
								}
								this.BaseTextileTextureName = input.ReadUInt32();
							}
							else
							{
								this.BaseTextilePatternName = input.ReadUInt32();
							}
						}
						else
						{
							this.BaseBannerShapeName = input.ReadUInt32();
						}
					}
					else if (num3 != 32U)
					{
						if (num3 != 40U)
						{
							if (num3 != 48U)
							{
								goto IL_00A6;
							}
							this.DyeTextilePrimaryName = input.ReadUInt32();
						}
						else
						{
							this.BaseTrimName = input.ReadUInt32();
						}
					}
					else
					{
						this.BaseEmbroideryName = input.ReadUInt32();
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
								goto IL_00A6;
							}
							this.DyeTrimName = input.ReadUInt32();
						}
						else
						{
							this.DyeTextileTertiaryName = input.ReadUInt32();
						}
					}
					else
					{
						this.DyeTextileSecondaryName = input.ReadUInt32();
					}
				}
				else if (num3 <= 88U)
				{
					if (num3 != 80U)
					{
						if (num3 != 88U)
						{
							goto IL_00A6;
						}
						this.DyeEmbroideryName = input.ReadUInt32();
					}
					else
					{
						this.DyeIconographyName = input.ReadUInt32();
					}
				}
				else if (num3 != 160U)
				{
					if (num3 != 170U)
					{
						goto IL_00A6;
					}
					this.heraldryIcons_.AddEntriesFrom(ref input, ClanHeraldry._repeated_heraldryIcons_codec);
				}
				else
				{
					this.IconLayoutIndex = input.ReadUInt32();
				}
				continue;
				IL_00A6:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002105 RID: 8453
		private static readonly MessageParser<ClanHeraldry> _parser = new MessageParser<ClanHeraldry>(() => new ClanHeraldry());

		// Token: 0x04002106 RID: 8454
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002107 RID: 8455
		private int _hasBits0;

		// Token: 0x04002108 RID: 8456
		public const int BaseBannerShapeNameFieldNumber = 1;

		// Token: 0x04002109 RID: 8457
		private static readonly uint BaseBannerShapeNameDefaultValue = 0U;

		// Token: 0x0400210A RID: 8458
		private uint baseBannerShapeName_;

		// Token: 0x0400210B RID: 8459
		public const int BaseTextilePatternNameFieldNumber = 2;

		// Token: 0x0400210C RID: 8460
		private static readonly uint BaseTextilePatternNameDefaultValue = 0U;

		// Token: 0x0400210D RID: 8461
		private uint baseTextilePatternName_;

		// Token: 0x0400210E RID: 8462
		public const int BaseTextileTextureNameFieldNumber = 3;

		// Token: 0x0400210F RID: 8463
		private static readonly uint BaseTextileTextureNameDefaultValue = 0U;

		// Token: 0x04002110 RID: 8464
		private uint baseTextileTextureName_;

		// Token: 0x04002111 RID: 8465
		public const int BaseEmbroideryNameFieldNumber = 4;

		// Token: 0x04002112 RID: 8466
		private static readonly uint BaseEmbroideryNameDefaultValue = 0U;

		// Token: 0x04002113 RID: 8467
		private uint baseEmbroideryName_;

		// Token: 0x04002114 RID: 8468
		public const int BaseTrimNameFieldNumber = 5;

		// Token: 0x04002115 RID: 8469
		private static readonly uint BaseTrimNameDefaultValue = 0U;

		// Token: 0x04002116 RID: 8470
		private uint baseTrimName_;

		// Token: 0x04002117 RID: 8471
		public const int DyeTextilePrimaryNameFieldNumber = 6;

		// Token: 0x04002118 RID: 8472
		private static readonly uint DyeTextilePrimaryNameDefaultValue = 0U;

		// Token: 0x04002119 RID: 8473
		private uint dyeTextilePrimaryName_;

		// Token: 0x0400211A RID: 8474
		public const int DyeTextileSecondaryNameFieldNumber = 7;

		// Token: 0x0400211B RID: 8475
		private static readonly uint DyeTextileSecondaryNameDefaultValue = 0U;

		// Token: 0x0400211C RID: 8476
		private uint dyeTextileSecondaryName_;

		// Token: 0x0400211D RID: 8477
		public const int DyeTextileTertiaryNameFieldNumber = 8;

		// Token: 0x0400211E RID: 8478
		private static readonly uint DyeTextileTertiaryNameDefaultValue = 0U;

		// Token: 0x0400211F RID: 8479
		private uint dyeTextileTertiaryName_;

		// Token: 0x04002120 RID: 8480
		public const int DyeTrimNameFieldNumber = 9;

		// Token: 0x04002121 RID: 8481
		private static readonly uint DyeTrimNameDefaultValue = 0U;

		// Token: 0x04002122 RID: 8482
		private uint dyeTrimName_;

		// Token: 0x04002123 RID: 8483
		public const int DyeIconographyNameFieldNumber = 10;

		// Token: 0x04002124 RID: 8484
		private static readonly uint DyeIconographyNameDefaultValue = 0U;

		// Token: 0x04002125 RID: 8485
		private uint dyeIconographyName_;

		// Token: 0x04002126 RID: 8486
		public const int DyeEmbroideryNameFieldNumber = 11;

		// Token: 0x04002127 RID: 8487
		private static readonly uint DyeEmbroideryNameDefaultValue = 0U;

		// Token: 0x04002128 RID: 8488
		private uint dyeEmbroideryName_;

		// Token: 0x04002129 RID: 8489
		public const int IconLayoutIndexFieldNumber = 20;

		// Token: 0x0400212A RID: 8490
		private static readonly uint IconLayoutIndexDefaultValue = 0U;

		// Token: 0x0400212B RID: 8491
		private uint iconLayoutIndex_;

		// Token: 0x0400212C RID: 8492
		public const int HeraldryIconsFieldNumber = 21;

		// Token: 0x0400212D RID: 8493
		private static readonly FieldCodec<HeraldryIcon> _repeated_heraldryIcons_codec = FieldCodec.ForMessage<HeraldryIcon>(170U, HeraldryIcon.Parser);

		// Token: 0x0400212E RID: 8494
		private readonly RepeatedField<HeraldryIcon> heraldryIcons_ = new RepeatedField<HeraldryIcon>();
	}
}
