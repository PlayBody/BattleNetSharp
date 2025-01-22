using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x02000179 RID: 377
	public sealed class AppearanceCustomization : IMessage<AppearanceCustomization>, IMessage, IEquatable<AppearanceCustomization>, IDeepCloneable<AppearanceCustomization>, IBufferMessage
	{
		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x0600270B RID: 9995 RVA: 0x00098888 File Offset: 0x00096A88
		[DebuggerNonUserCode]
		public static MessageParser<AppearanceCustomization> Parser
		{
			get
			{
				return AppearanceCustomization._parser;
			}
		}

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x0600270C RID: 9996 RVA: 0x000988A0 File Offset: 0x00096AA0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x0600270D RID: 9997 RVA: 0x000988C4 File Offset: 0x00096AC4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AppearanceCustomization.Descriptor;
			}
		}

		// Token: 0x0600270E RID: 9998 RVA: 0x000988DB File Offset: 0x00096ADB
		[DebuggerNonUserCode]
		public AppearanceCustomization()
		{
		}

		// Token: 0x0600270F RID: 9999 RVA: 0x000988E8 File Offset: 0x00096AE8
		[DebuggerNonUserCode]
		public AppearanceCustomization(AppearanceCustomization other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoFace_ = other.snoFace_;
			this.snoHairColor_ = other.snoHairColor_;
			this.snoHairStyle_ = other.snoHairStyle_;
			this.snoFacialHair_ = other.snoFacialHair_;
			this.snoEyeColor_ = other.snoEyeColor_;
			this.skinColorIndex_ = other.skinColorIndex_;
			this.snoMarkingShape_ = other.snoMarkingShape_;
			this.snoMarkingColor_ = other.snoMarkingColor_;
			this.snoJewelry_ = other.snoJewelry_;
			this.snoMakeup_ = other.snoMakeup_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002710 RID: 10000 RVA: 0x00098994 File Offset: 0x00096B94
		[DebuggerNonUserCode]
		public AppearanceCustomization Clone()
		{
			return new AppearanceCustomization(this);
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x06002711 RID: 10001 RVA: 0x000989AC File Offset: 0x00096BAC
		// (set) Token: 0x06002712 RID: 10002 RVA: 0x000989E1 File Offset: 0x00096BE1
		[DebuggerNonUserCode]
		public int SnoFace
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				int snoFaceDefaultValue;
				if (flag)
				{
					snoFaceDefaultValue = this.snoFace_;
				}
				else
				{
					snoFaceDefaultValue = AppearanceCustomization.SnoFaceDefaultValue;
				}
				return snoFaceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.snoFace_ = value;
			}
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x06002713 RID: 10003 RVA: 0x00098A00 File Offset: 0x00096C00
		[DebuggerNonUserCode]
		public bool HasSnoFace
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x00098A21 File Offset: 0x00096C21
		[DebuggerNonUserCode]
		public void ClearSnoFace()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x06002715 RID: 10005 RVA: 0x00098A38 File Offset: 0x00096C38
		// (set) Token: 0x06002716 RID: 10006 RVA: 0x00098A6A File Offset: 0x00096C6A
		[DebuggerNonUserCode]
		public int SnoHairColor
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				int snoHairColorDefaultValue;
				if (flag)
				{
					snoHairColorDefaultValue = this.snoHairColor_;
				}
				else
				{
					snoHairColorDefaultValue = AppearanceCustomization.SnoHairColorDefaultValue;
				}
				return snoHairColorDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.snoHairColor_ = value;
			}
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x06002717 RID: 10007 RVA: 0x00098A84 File Offset: 0x00096C84
		[DebuggerNonUserCode]
		public bool HasSnoHairColor
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x00098AA2 File Offset: 0x00096CA2
		[DebuggerNonUserCode]
		public void ClearSnoHairColor()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x06002719 RID: 10009 RVA: 0x00098AB4 File Offset: 0x00096CB4
		// (set) Token: 0x0600271A RID: 10010 RVA: 0x00098AE9 File Offset: 0x00096CE9
		[DebuggerNonUserCode]
		public int SnoHairStyle
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				int snoHairStyleDefaultValue;
				if (flag)
				{
					snoHairStyleDefaultValue = this.snoHairStyle_;
				}
				else
				{
					snoHairStyleDefaultValue = AppearanceCustomization.SnoHairStyleDefaultValue;
				}
				return snoHairStyleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.snoHairStyle_ = value;
			}
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x0600271B RID: 10011 RVA: 0x00098B08 File Offset: 0x00096D08
		[DebuggerNonUserCode]
		public bool HasSnoHairStyle
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x00098B29 File Offset: 0x00096D29
		[DebuggerNonUserCode]
		public void ClearSnoHairStyle()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x0600271D RID: 10013 RVA: 0x00098B40 File Offset: 0x00096D40
		// (set) Token: 0x0600271E RID: 10014 RVA: 0x00098B75 File Offset: 0x00096D75
		[DebuggerNonUserCode]
		public int SnoFacialHair
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				int snoFacialHairDefaultValue;
				if (flag)
				{
					snoFacialHairDefaultValue = this.snoFacialHair_;
				}
				else
				{
					snoFacialHairDefaultValue = AppearanceCustomization.SnoFacialHairDefaultValue;
				}
				return snoFacialHairDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.snoFacialHair_ = value;
			}
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x0600271F RID: 10015 RVA: 0x00098B94 File Offset: 0x00096D94
		[DebuggerNonUserCode]
		public bool HasSnoFacialHair
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x00098BB5 File Offset: 0x00096DB5
		[DebuggerNonUserCode]
		public void ClearSnoFacialHair()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x06002721 RID: 10017 RVA: 0x00098BCC File Offset: 0x00096DCC
		// (set) Token: 0x06002722 RID: 10018 RVA: 0x00098BFD File Offset: 0x00096DFD
		[DebuggerNonUserCode]
		public int SnoEyeColor
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoEyeColorDefaultValue;
				if (flag)
				{
					snoEyeColorDefaultValue = this.snoEyeColor_;
				}
				else
				{
					snoEyeColorDefaultValue = AppearanceCustomization.SnoEyeColorDefaultValue;
				}
				return snoEyeColorDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoEyeColor_ = value;
			}
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x06002723 RID: 10019 RVA: 0x00098C18 File Offset: 0x00096E18
		[DebuggerNonUserCode]
		public bool HasSnoEyeColor
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002724 RID: 10020 RVA: 0x00098C35 File Offset: 0x00096E35
		[DebuggerNonUserCode]
		public void ClearSnoEyeColor()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x06002725 RID: 10021 RVA: 0x00098C48 File Offset: 0x00096E48
		// (set) Token: 0x06002726 RID: 10022 RVA: 0x00098C79 File Offset: 0x00096E79
		[DebuggerNonUserCode]
		public int SkinColorIndex
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int skinColorIndexDefaultValue;
				if (flag)
				{
					skinColorIndexDefaultValue = this.skinColorIndex_;
				}
				else
				{
					skinColorIndexDefaultValue = AppearanceCustomization.SkinColorIndexDefaultValue;
				}
				return skinColorIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.skinColorIndex_ = value;
			}
		}

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x06002727 RID: 10023 RVA: 0x00098C94 File Offset: 0x00096E94
		[DebuggerNonUserCode]
		public bool HasSkinColorIndex
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002728 RID: 10024 RVA: 0x00098CB1 File Offset: 0x00096EB1
		[DebuggerNonUserCode]
		public void ClearSkinColorIndex()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x06002729 RID: 10025 RVA: 0x00098CC4 File Offset: 0x00096EC4
		// (set) Token: 0x0600272A RID: 10026 RVA: 0x00098CF5 File Offset: 0x00096EF5
		[DebuggerNonUserCode]
		public int SnoMarkingShape
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int snoMarkingShapeDefaultValue;
				if (flag)
				{
					snoMarkingShapeDefaultValue = this.snoMarkingShape_;
				}
				else
				{
					snoMarkingShapeDefaultValue = AppearanceCustomization.SnoMarkingShapeDefaultValue;
				}
				return snoMarkingShapeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.snoMarkingShape_ = value;
			}
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x0600272B RID: 10027 RVA: 0x00098D10 File Offset: 0x00096F10
		[DebuggerNonUserCode]
		public bool HasSnoMarkingShape
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x00098D2D File Offset: 0x00096F2D
		[DebuggerNonUserCode]
		public void ClearSnoMarkingShape()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x0600272D RID: 10029 RVA: 0x00098D40 File Offset: 0x00096F40
		// (set) Token: 0x0600272E RID: 10030 RVA: 0x00098D72 File Offset: 0x00096F72
		[DebuggerNonUserCode]
		public int SnoMarkingColor
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				int snoMarkingColorDefaultValue;
				if (flag)
				{
					snoMarkingColorDefaultValue = this.snoMarkingColor_;
				}
				else
				{
					snoMarkingColorDefaultValue = AppearanceCustomization.SnoMarkingColorDefaultValue;
				}
				return snoMarkingColorDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.snoMarkingColor_ = value;
			}
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x0600272F RID: 10031 RVA: 0x00098D8C File Offset: 0x00096F8C
		[DebuggerNonUserCode]
		public bool HasSnoMarkingColor
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x00098DAA File Offset: 0x00096FAA
		[DebuggerNonUserCode]
		public void ClearSnoMarkingColor()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x06002731 RID: 10033 RVA: 0x00098DBC File Offset: 0x00096FBC
		// (set) Token: 0x06002732 RID: 10034 RVA: 0x00098DED File Offset: 0x00096FED
		[DebuggerNonUserCode]
		public int SnoJewelry
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int snoJewelryDefaultValue;
				if (flag)
				{
					snoJewelryDefaultValue = this.snoJewelry_;
				}
				else
				{
					snoJewelryDefaultValue = AppearanceCustomization.SnoJewelryDefaultValue;
				}
				return snoJewelryDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.snoJewelry_ = value;
			}
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x06002733 RID: 10035 RVA: 0x00098E08 File Offset: 0x00097008
		[DebuggerNonUserCode]
		public bool HasSnoJewelry
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x00098E25 File Offset: 0x00097025
		[DebuggerNonUserCode]
		public void ClearSnoJewelry()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x06002735 RID: 10037 RVA: 0x00098E38 File Offset: 0x00097038
		// (set) Token: 0x06002736 RID: 10038 RVA: 0x00098E6A File Offset: 0x0009706A
		[DebuggerNonUserCode]
		public int SnoMakeup
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				int snoMakeupDefaultValue;
				if (flag)
				{
					snoMakeupDefaultValue = this.snoMakeup_;
				}
				else
				{
					snoMakeupDefaultValue = AppearanceCustomization.SnoMakeupDefaultValue;
				}
				return snoMakeupDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.snoMakeup_ = value;
			}
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x06002737 RID: 10039 RVA: 0x00098E84 File Offset: 0x00097084
		[DebuggerNonUserCode]
		public bool HasSnoMakeup
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06002738 RID: 10040 RVA: 0x00098EA2 File Offset: 0x000970A2
		[DebuggerNonUserCode]
		public void ClearSnoMakeup()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x06002739 RID: 10041 RVA: 0x00098EB4 File Offset: 0x000970B4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AppearanceCustomization);
		}

		// Token: 0x0600273A RID: 10042 RVA: 0x00098ED4 File Offset: 0x000970D4
		[DebuggerNonUserCode]
		public bool Equals(AppearanceCustomization other)
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
					bool flag4 = this.SnoFace != other.SnoFace;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoHairColor != other.SnoHairColor;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.SnoHairStyle != other.SnoHairStyle;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.SnoFacialHair != other.SnoFacialHair;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.SnoEyeColor != other.SnoEyeColor;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.SkinColorIndex != other.SkinColorIndex;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.SnoMarkingShape != other.SnoMarkingShape;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.SnoMarkingColor != other.SnoMarkingColor;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.SnoJewelry != other.SnoJewelry;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.SnoMakeup != other.SnoMakeup;
														flag2 = !flag13 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x0600273B RID: 10043 RVA: 0x00099038 File Offset: 0x00097238
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoFace = this.HasSnoFace;
			if (hasSnoFace)
			{
				num ^= this.SnoFace.GetHashCode();
			}
			bool hasSnoHairColor = this.HasSnoHairColor;
			if (hasSnoHairColor)
			{
				num ^= this.SnoHairColor.GetHashCode();
			}
			bool hasSnoHairStyle = this.HasSnoHairStyle;
			if (hasSnoHairStyle)
			{
				num ^= this.SnoHairStyle.GetHashCode();
			}
			bool hasSnoFacialHair = this.HasSnoFacialHair;
			if (hasSnoFacialHair)
			{
				num ^= this.SnoFacialHair.GetHashCode();
			}
			bool hasSnoEyeColor = this.HasSnoEyeColor;
			if (hasSnoEyeColor)
			{
				num ^= this.SnoEyeColor.GetHashCode();
			}
			bool hasSkinColorIndex = this.HasSkinColorIndex;
			if (hasSkinColorIndex)
			{
				num ^= this.SkinColorIndex.GetHashCode();
			}
			bool hasSnoMarkingShape = this.HasSnoMarkingShape;
			if (hasSnoMarkingShape)
			{
				num ^= this.SnoMarkingShape.GetHashCode();
			}
			bool hasSnoMarkingColor = this.HasSnoMarkingColor;
			if (hasSnoMarkingColor)
			{
				num ^= this.SnoMarkingColor.GetHashCode();
			}
			bool hasSnoJewelry = this.HasSnoJewelry;
			if (hasSnoJewelry)
			{
				num ^= this.SnoJewelry.GetHashCode();
			}
			bool hasSnoMakeup = this.HasSnoMakeup;
			if (hasSnoMakeup)
			{
				num ^= this.SnoMakeup.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600273C RID: 10044 RVA: 0x0009918C File Offset: 0x0009738C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600273D RID: 10045 RVA: 0x000991A4 File Offset: 0x000973A4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600273E RID: 10046 RVA: 0x000991B0 File Offset: 0x000973B0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoEyeColor = this.HasSnoEyeColor;
			if (hasSnoEyeColor)
			{
				output.WriteRawTag(45);
				output.WriteSFixed32(this.SnoEyeColor);
			}
			bool hasSkinColorIndex = this.HasSkinColorIndex;
			if (hasSkinColorIndex)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.SkinColorIndex);
			}
			bool hasSnoMarkingShape = this.HasSnoMarkingShape;
			if (hasSnoMarkingShape)
			{
				output.WriteRawTag(61);
				output.WriteSFixed32(this.SnoMarkingShape);
			}
			bool hasSnoJewelry = this.HasSnoJewelry;
			if (hasSnoJewelry)
			{
				output.WriteRawTag(77);
				output.WriteSFixed32(this.SnoJewelry);
			}
			bool hasSnoMakeup = this.HasSnoMakeup;
			if (hasSnoMakeup)
			{
				output.WriteRawTag(93);
				output.WriteSFixed32(this.SnoMakeup);
			}
			bool hasSnoMarkingColor = this.HasSnoMarkingColor;
			if (hasSnoMarkingColor)
			{
				output.WriteRawTag(101);
				output.WriteSFixed32(this.SnoMarkingColor);
			}
			bool hasSnoHairColor = this.HasSnoHairColor;
			if (hasSnoHairColor)
			{
				output.WriteRawTag(109);
				output.WriteSFixed32(this.SnoHairColor);
			}
			bool hasSnoFace = this.HasSnoFace;
			if (hasSnoFace)
			{
				output.WriteRawTag(117);
				output.WriteSFixed32(this.SnoFace);
			}
			bool hasSnoHairStyle = this.HasSnoHairStyle;
			if (hasSnoHairStyle)
			{
				output.WriteRawTag(125);
				output.WriteSFixed32(this.SnoHairStyle);
			}
			bool hasSnoFacialHair = this.HasSnoFacialHair;
			if (hasSnoFacialHair)
			{
				output.WriteRawTag(133, 1);
				output.WriteSFixed32(this.SnoFacialHair);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x00099340 File Offset: 0x00097540
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoFace = this.HasSnoFace;
			if (hasSnoFace)
			{
				num += 5;
			}
			bool hasSnoHairColor = this.HasSnoHairColor;
			if (hasSnoHairColor)
			{
				num += 5;
			}
			bool hasSnoHairStyle = this.HasSnoHairStyle;
			if (hasSnoHairStyle)
			{
				num += 5;
			}
			bool hasSnoFacialHair = this.HasSnoFacialHair;
			if (hasSnoFacialHair)
			{
				num += 6;
			}
			bool hasSnoEyeColor = this.HasSnoEyeColor;
			if (hasSnoEyeColor)
			{
				num += 5;
			}
			bool hasSkinColorIndex = this.HasSkinColorIndex;
			if (hasSkinColorIndex)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinColorIndex);
			}
			bool hasSnoMarkingShape = this.HasSnoMarkingShape;
			if (hasSnoMarkingShape)
			{
				num += 5;
			}
			bool hasSnoMarkingColor = this.HasSnoMarkingColor;
			if (hasSnoMarkingColor)
			{
				num += 5;
			}
			bool hasSnoJewelry = this.HasSnoJewelry;
			if (hasSnoJewelry)
			{
				num += 5;
			}
			bool hasSnoMakeup = this.HasSnoMakeup;
			if (hasSnoMakeup)
			{
				num += 5;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002740 RID: 10048 RVA: 0x00099430 File Offset: 0x00097630
		[DebuggerNonUserCode]
		public void MergeFrom(AppearanceCustomization other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoFace = other.HasSnoFace;
				if (hasSnoFace)
				{
					this.SnoFace = other.SnoFace;
				}
				bool hasSnoHairColor = other.HasSnoHairColor;
				if (hasSnoHairColor)
				{
					this.SnoHairColor = other.SnoHairColor;
				}
				bool hasSnoHairStyle = other.HasSnoHairStyle;
				if (hasSnoHairStyle)
				{
					this.SnoHairStyle = other.SnoHairStyle;
				}
				bool hasSnoFacialHair = other.HasSnoFacialHair;
				if (hasSnoFacialHair)
				{
					this.SnoFacialHair = other.SnoFacialHair;
				}
				bool hasSnoEyeColor = other.HasSnoEyeColor;
				if (hasSnoEyeColor)
				{
					this.SnoEyeColor = other.SnoEyeColor;
				}
				bool hasSkinColorIndex = other.HasSkinColorIndex;
				if (hasSkinColorIndex)
				{
					this.SkinColorIndex = other.SkinColorIndex;
				}
				bool hasSnoMarkingShape = other.HasSnoMarkingShape;
				if (hasSnoMarkingShape)
				{
					this.SnoMarkingShape = other.SnoMarkingShape;
				}
				bool hasSnoMarkingColor = other.HasSnoMarkingColor;
				if (hasSnoMarkingColor)
				{
					this.SnoMarkingColor = other.SnoMarkingColor;
				}
				bool hasSnoJewelry = other.HasSnoJewelry;
				if (hasSnoJewelry)
				{
					this.SnoJewelry = other.SnoJewelry;
				}
				bool hasSnoMakeup = other.HasSnoMakeup;
				if (hasSnoMakeup)
				{
					this.SnoMakeup = other.SnoMakeup;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x0009956B File Offset: 0x0009776B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002742 RID: 10050 RVA: 0x00099578 File Offset: 0x00097778
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 93U)
				{
					if (num3 <= 48U)
					{
						if (num3 != 45U)
						{
							if (num3 != 48U)
							{
								goto IL_007E;
							}
							this.SkinColorIndex = input.ReadInt32();
						}
						else
						{
							this.SnoEyeColor = input.ReadSFixed32();
						}
					}
					else if (num3 != 61U)
					{
						if (num3 != 77U)
						{
							if (num3 != 93U)
							{
								goto IL_007E;
							}
							this.SnoMakeup = input.ReadSFixed32();
						}
						else
						{
							this.SnoJewelry = input.ReadSFixed32();
						}
					}
					else
					{
						this.SnoMarkingShape = input.ReadSFixed32();
					}
				}
				else if (num3 <= 109U)
				{
					if (num3 != 101U)
					{
						if (num3 != 109U)
						{
							goto IL_007E;
						}
						this.SnoHairColor = input.ReadSFixed32();
					}
					else
					{
						this.SnoMarkingColor = input.ReadSFixed32();
					}
				}
				else if (num3 != 117U)
				{
					if (num3 != 125U)
					{
						if (num3 != 133U)
						{
							goto IL_007E;
						}
						this.SnoFacialHair = input.ReadSFixed32();
					}
					else
					{
						this.SnoHairStyle = input.ReadSFixed32();
					}
				}
				else
				{
					this.SnoFace = input.ReadSFixed32();
				}
				continue;
				IL_007E:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001145 RID: 4421
		private static readonly MessageParser<AppearanceCustomization> _parser = new MessageParser<AppearanceCustomization>(() => new AppearanceCustomization());

		// Token: 0x04001146 RID: 4422
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001147 RID: 4423
		private int _hasBits0;

		// Token: 0x04001148 RID: 4424
		public const int SnoFaceFieldNumber = 14;

		// Token: 0x04001149 RID: 4425
		private static readonly int SnoFaceDefaultValue = -1;

		// Token: 0x0400114A RID: 4426
		private int snoFace_;

		// Token: 0x0400114B RID: 4427
		public const int SnoHairColorFieldNumber = 13;

		// Token: 0x0400114C RID: 4428
		private static readonly int SnoHairColorDefaultValue = -1;

		// Token: 0x0400114D RID: 4429
		private int snoHairColor_;

		// Token: 0x0400114E RID: 4430
		public const int SnoHairStyleFieldNumber = 15;

		// Token: 0x0400114F RID: 4431
		private static readonly int SnoHairStyleDefaultValue = -1;

		// Token: 0x04001150 RID: 4432
		private int snoHairStyle_;

		// Token: 0x04001151 RID: 4433
		public const int SnoFacialHairFieldNumber = 16;

		// Token: 0x04001152 RID: 4434
		private static readonly int SnoFacialHairDefaultValue = -1;

		// Token: 0x04001153 RID: 4435
		private int snoFacialHair_;

		// Token: 0x04001154 RID: 4436
		public const int SnoEyeColorFieldNumber = 5;

		// Token: 0x04001155 RID: 4437
		private static readonly int SnoEyeColorDefaultValue = -1;

		// Token: 0x04001156 RID: 4438
		private int snoEyeColor_;

		// Token: 0x04001157 RID: 4439
		public const int SkinColorIndexFieldNumber = 6;

		// Token: 0x04001158 RID: 4440
		private static readonly int SkinColorIndexDefaultValue = 0;

		// Token: 0x04001159 RID: 4441
		private int skinColorIndex_;

		// Token: 0x0400115A RID: 4442
		public const int SnoMarkingShapeFieldNumber = 7;

		// Token: 0x0400115B RID: 4443
		private static readonly int SnoMarkingShapeDefaultValue = -1;

		// Token: 0x0400115C RID: 4444
		private int snoMarkingShape_;

		// Token: 0x0400115D RID: 4445
		public const int SnoMarkingColorFieldNumber = 12;

		// Token: 0x0400115E RID: 4446
		private static readonly int SnoMarkingColorDefaultValue = -1;

		// Token: 0x0400115F RID: 4447
		private int snoMarkingColor_;

		// Token: 0x04001160 RID: 4448
		public const int SnoJewelryFieldNumber = 9;

		// Token: 0x04001161 RID: 4449
		private static readonly int SnoJewelryDefaultValue = -1;

		// Token: 0x04001162 RID: 4450
		private int snoJewelry_;

		// Token: 0x04001163 RID: 4451
		public const int SnoMakeupFieldNumber = 11;

		// Token: 0x04001164 RID: 4452
		private static readonly int SnoMakeupDefaultValue = -1;

		// Token: 0x04001165 RID: 4453
		private int snoMakeup_;
	}
}
