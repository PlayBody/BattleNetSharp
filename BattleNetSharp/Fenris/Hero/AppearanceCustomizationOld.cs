using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x0200017A RID: 378
	public sealed class AppearanceCustomizationOld : IMessage<AppearanceCustomizationOld>, IMessage, IEquatable<AppearanceCustomizationOld>, IDeepCloneable<AppearanceCustomizationOld>, IBufferMessage
	{
		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x06002744 RID: 10052 RVA: 0x00099738 File Offset: 0x00097938
		[DebuggerNonUserCode]
		public static MessageParser<AppearanceCustomizationOld> Parser
		{
			get
			{
				return AppearanceCustomizationOld._parser;
			}
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x06002745 RID: 10053 RVA: 0x00099750 File Offset: 0x00097950
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x06002746 RID: 10054 RVA: 0x00099774 File Offset: 0x00097974
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AppearanceCustomizationOld.Descriptor;
			}
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x0009978B File Offset: 0x0009798B
		[DebuggerNonUserCode]
		public AppearanceCustomizationOld()
		{
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x00099798 File Offset: 0x00097998
		[DebuggerNonUserCode]
		public AppearanceCustomizationOld(AppearanceCustomizationOld other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.personaIndex_ = other.personaIndex_;
			this.hairColorIndex_ = other.hairColorIndex_;
			this.hairStyleIndex_ = other.hairStyleIndex_;
			this.facialHairIndex_ = other.facialHairIndex_;
			this.eyeColorIndex_ = other.eyeColorIndex_;
			this.skinColorIndex_ = other.skinColorIndex_;
			this.snoMarkingShape_ = other.snoMarkingShape_;
			this.markingColorIndex_ = other.markingColorIndex_;
			this.snoJewelry_ = other.snoJewelry_;
			this.makeupIndex_ = other.makeupIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x00099844 File Offset: 0x00097A44
		[DebuggerNonUserCode]
		public AppearanceCustomizationOld Clone()
		{
			return new AppearanceCustomizationOld(this);
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x0600274A RID: 10058 RVA: 0x0009985C File Offset: 0x00097A5C
		// (set) Token: 0x0600274B RID: 10059 RVA: 0x0009988D File Offset: 0x00097A8D
		[DebuggerNonUserCode]
		public int PersonaIndex
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int personaIndexDefaultValue;
				if (flag)
				{
					personaIndexDefaultValue = this.personaIndex_;
				}
				else
				{
					personaIndexDefaultValue = AppearanceCustomizationOld.PersonaIndexDefaultValue;
				}
				return personaIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.personaIndex_ = value;
			}
		}

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x0600274C RID: 10060 RVA: 0x000998A8 File Offset: 0x00097AA8
		[DebuggerNonUserCode]
		public bool HasPersonaIndex
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600274D RID: 10061 RVA: 0x000998C5 File Offset: 0x00097AC5
		[DebuggerNonUserCode]
		public void ClearPersonaIndex()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x0600274E RID: 10062 RVA: 0x000998D8 File Offset: 0x00097AD8
		// (set) Token: 0x0600274F RID: 10063 RVA: 0x00099909 File Offset: 0x00097B09
		[DebuggerNonUserCode]
		public int HairColorIndex
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int hairColorIndexDefaultValue;
				if (flag)
				{
					hairColorIndexDefaultValue = this.hairColorIndex_;
				}
				else
				{
					hairColorIndexDefaultValue = AppearanceCustomizationOld.HairColorIndexDefaultValue;
				}
				return hairColorIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.hairColorIndex_ = value;
			}
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x06002750 RID: 10064 RVA: 0x00099924 File Offset: 0x00097B24
		[DebuggerNonUserCode]
		public bool HasHairColorIndex
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002751 RID: 10065 RVA: 0x00099941 File Offset: 0x00097B41
		[DebuggerNonUserCode]
		public void ClearHairColorIndex()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x06002752 RID: 10066 RVA: 0x00099954 File Offset: 0x00097B54
		// (set) Token: 0x06002753 RID: 10067 RVA: 0x00099985 File Offset: 0x00097B85
		[DebuggerNonUserCode]
		public int HairStyleIndex
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int hairStyleIndexDefaultValue;
				if (flag)
				{
					hairStyleIndexDefaultValue = this.hairStyleIndex_;
				}
				else
				{
					hairStyleIndexDefaultValue = AppearanceCustomizationOld.HairStyleIndexDefaultValue;
				}
				return hairStyleIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.hairStyleIndex_ = value;
			}
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x06002754 RID: 10068 RVA: 0x000999A0 File Offset: 0x00097BA0
		[DebuggerNonUserCode]
		public bool HasHairStyleIndex
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x000999BD File Offset: 0x00097BBD
		[DebuggerNonUserCode]
		public void ClearHairStyleIndex()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x06002756 RID: 10070 RVA: 0x000999D0 File Offset: 0x00097BD0
		// (set) Token: 0x06002757 RID: 10071 RVA: 0x00099A01 File Offset: 0x00097C01
		[DebuggerNonUserCode]
		public int FacialHairIndex
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int facialHairIndexDefaultValue;
				if (flag)
				{
					facialHairIndexDefaultValue = this.facialHairIndex_;
				}
				else
				{
					facialHairIndexDefaultValue = AppearanceCustomizationOld.FacialHairIndexDefaultValue;
				}
				return facialHairIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.facialHairIndex_ = value;
			}
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x06002758 RID: 10072 RVA: 0x00099A1C File Offset: 0x00097C1C
		[DebuggerNonUserCode]
		public bool HasFacialHairIndex
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x00099A39 File Offset: 0x00097C39
		[DebuggerNonUserCode]
		public void ClearFacialHairIndex()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x0600275A RID: 10074 RVA: 0x00099A4C File Offset: 0x00097C4C
		// (set) Token: 0x0600275B RID: 10075 RVA: 0x00099A7E File Offset: 0x00097C7E
		[DebuggerNonUserCode]
		public int EyeColorIndex
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				int eyeColorIndexDefaultValue;
				if (flag)
				{
					eyeColorIndexDefaultValue = this.eyeColorIndex_;
				}
				else
				{
					eyeColorIndexDefaultValue = AppearanceCustomizationOld.EyeColorIndexDefaultValue;
				}
				return eyeColorIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.eyeColorIndex_ = value;
			}
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x0600275C RID: 10076 RVA: 0x00099A98 File Offset: 0x00097C98
		[DebuggerNonUserCode]
		public bool HasEyeColorIndex
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600275D RID: 10077 RVA: 0x00099AB6 File Offset: 0x00097CB6
		[DebuggerNonUserCode]
		public void ClearEyeColorIndex()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x0600275E RID: 10078 RVA: 0x00099AC8 File Offset: 0x00097CC8
		// (set) Token: 0x0600275F RID: 10079 RVA: 0x00099AFA File Offset: 0x00097CFA
		[DebuggerNonUserCode]
		public int SkinColorIndex
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				int skinColorIndexDefaultValue;
				if (flag)
				{
					skinColorIndexDefaultValue = this.skinColorIndex_;
				}
				else
				{
					skinColorIndexDefaultValue = AppearanceCustomizationOld.SkinColorIndexDefaultValue;
				}
				return skinColorIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.skinColorIndex_ = value;
			}
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x06002760 RID: 10080 RVA: 0x00099B14 File Offset: 0x00097D14
		[DebuggerNonUserCode]
		public bool HasSkinColorIndex
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x00099B32 File Offset: 0x00097D32
		[DebuggerNonUserCode]
		public void ClearSkinColorIndex()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x06002762 RID: 10082 RVA: 0x00099B44 File Offset: 0x00097D44
		// (set) Token: 0x06002763 RID: 10083 RVA: 0x00099B76 File Offset: 0x00097D76
		[DebuggerNonUserCode]
		public int SnoMarkingShape
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				int snoMarkingShapeDefaultValue;
				if (flag)
				{
					snoMarkingShapeDefaultValue = this.snoMarkingShape_;
				}
				else
				{
					snoMarkingShapeDefaultValue = AppearanceCustomizationOld.SnoMarkingShapeDefaultValue;
				}
				return snoMarkingShapeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.snoMarkingShape_ = value;
			}
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x06002764 RID: 10084 RVA: 0x00099B90 File Offset: 0x00097D90
		[DebuggerNonUserCode]
		public bool HasSnoMarkingShape
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x00099BAE File Offset: 0x00097DAE
		[DebuggerNonUserCode]
		public void ClearSnoMarkingShape()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x06002766 RID: 10086 RVA: 0x00099BC0 File Offset: 0x00097DC0
		// (set) Token: 0x06002767 RID: 10087 RVA: 0x00099BF5 File Offset: 0x00097DF5
		[DebuggerNonUserCode]
		public int MarkingColorIndex
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				int markingColorIndexDefaultValue;
				if (flag)
				{
					markingColorIndexDefaultValue = this.markingColorIndex_;
				}
				else
				{
					markingColorIndexDefaultValue = AppearanceCustomizationOld.MarkingColorIndexDefaultValue;
				}
				return markingColorIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.markingColorIndex_ = value;
			}
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x06002768 RID: 10088 RVA: 0x00099C14 File Offset: 0x00097E14
		[DebuggerNonUserCode]
		public bool HasMarkingColorIndex
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x06002769 RID: 10089 RVA: 0x00099C35 File Offset: 0x00097E35
		[DebuggerNonUserCode]
		public void ClearMarkingColorIndex()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x0600276A RID: 10090 RVA: 0x00099C4C File Offset: 0x00097E4C
		// (set) Token: 0x0600276B RID: 10091 RVA: 0x00099C81 File Offset: 0x00097E81
		[DebuggerNonUserCode]
		public int SnoJewelry
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				int snoJewelryDefaultValue;
				if (flag)
				{
					snoJewelryDefaultValue = this.snoJewelry_;
				}
				else
				{
					snoJewelryDefaultValue = AppearanceCustomizationOld.SnoJewelryDefaultValue;
				}
				return snoJewelryDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.snoJewelry_ = value;
			}
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x0600276C RID: 10092 RVA: 0x00099CA0 File Offset: 0x00097EA0
		[DebuggerNonUserCode]
		public bool HasSnoJewelry
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x00099CC1 File Offset: 0x00097EC1
		[DebuggerNonUserCode]
		public void ClearSnoJewelry()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x0600276E RID: 10094 RVA: 0x00099CD8 File Offset: 0x00097ED8
		// (set) Token: 0x0600276F RID: 10095 RVA: 0x00099D0D File Offset: 0x00097F0D
		[DebuggerNonUserCode]
		public int MakeupIndex
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				int makeupIndexDefaultValue;
				if (flag)
				{
					makeupIndexDefaultValue = this.makeupIndex_;
				}
				else
				{
					makeupIndexDefaultValue = AppearanceCustomizationOld.MakeupIndexDefaultValue;
				}
				return makeupIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.makeupIndex_ = value;
			}
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x06002770 RID: 10096 RVA: 0x00099D2C File Offset: 0x00097F2C
		[DebuggerNonUserCode]
		public bool HasMakeupIndex
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x00099D4D File Offset: 0x00097F4D
		[DebuggerNonUserCode]
		public void ClearMakeupIndex()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x00099D64 File Offset: 0x00097F64
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AppearanceCustomizationOld);
		}

		// Token: 0x06002773 RID: 10099 RVA: 0x00099D84 File Offset: 0x00097F84
		[DebuggerNonUserCode]
		public bool Equals(AppearanceCustomizationOld other)
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
					bool flag4 = this.PersonaIndex != other.PersonaIndex;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.HairColorIndex != other.HairColorIndex;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.HairStyleIndex != other.HairStyleIndex;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.FacialHairIndex != other.FacialHairIndex;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.EyeColorIndex != other.EyeColorIndex;
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
												bool flag11 = this.MarkingColorIndex != other.MarkingColorIndex;
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
														bool flag13 = this.MakeupIndex != other.MakeupIndex;
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

		// Token: 0x06002774 RID: 10100 RVA: 0x00099EE8 File Offset: 0x000980E8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPersonaIndex = this.HasPersonaIndex;
			if (hasPersonaIndex)
			{
				num ^= this.PersonaIndex.GetHashCode();
			}
			bool hasHairColorIndex = this.HasHairColorIndex;
			if (hasHairColorIndex)
			{
				num ^= this.HairColorIndex.GetHashCode();
			}
			bool hasHairStyleIndex = this.HasHairStyleIndex;
			if (hasHairStyleIndex)
			{
				num ^= this.HairStyleIndex.GetHashCode();
			}
			bool hasFacialHairIndex = this.HasFacialHairIndex;
			if (hasFacialHairIndex)
			{
				num ^= this.FacialHairIndex.GetHashCode();
			}
			bool hasEyeColorIndex = this.HasEyeColorIndex;
			if (hasEyeColorIndex)
			{
				num ^= this.EyeColorIndex.GetHashCode();
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
			bool hasMarkingColorIndex = this.HasMarkingColorIndex;
			if (hasMarkingColorIndex)
			{
				num ^= this.MarkingColorIndex.GetHashCode();
			}
			bool hasSnoJewelry = this.HasSnoJewelry;
			if (hasSnoJewelry)
			{
				num ^= this.SnoJewelry.GetHashCode();
			}
			bool hasMakeupIndex = this.HasMakeupIndex;
			if (hasMakeupIndex)
			{
				num ^= this.MakeupIndex.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002775 RID: 10101 RVA: 0x0009A03C File Offset: 0x0009823C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002776 RID: 10102 RVA: 0x0009A054 File Offset: 0x00098254
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002777 RID: 10103 RVA: 0x0009A060 File Offset: 0x00098260
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPersonaIndex = this.HasPersonaIndex;
			if (hasPersonaIndex)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PersonaIndex);
			}
			bool hasHairColorIndex = this.HasHairColorIndex;
			if (hasHairColorIndex)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HairColorIndex);
			}
			bool hasHairStyleIndex = this.HasHairStyleIndex;
			if (hasHairStyleIndex)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.HairStyleIndex);
			}
			bool hasFacialHairIndex = this.HasFacialHairIndex;
			if (hasFacialHairIndex)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.FacialHairIndex);
			}
			bool hasEyeColorIndex = this.HasEyeColorIndex;
			if (hasEyeColorIndex)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.EyeColorIndex);
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
			bool hasMarkingColorIndex = this.HasMarkingColorIndex;
			if (hasMarkingColorIndex)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.MarkingColorIndex);
			}
			bool hasSnoJewelry = this.HasSnoJewelry;
			if (hasSnoJewelry)
			{
				output.WriteRawTag(77);
				output.WriteSFixed32(this.SnoJewelry);
			}
			bool hasMakeupIndex = this.HasMakeupIndex;
			if (hasMakeupIndex)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.MakeupIndex);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002778 RID: 10104 RVA: 0x0009A1EC File Offset: 0x000983EC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPersonaIndex = this.HasPersonaIndex;
			if (hasPersonaIndex)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PersonaIndex);
			}
			bool hasHairColorIndex = this.HasHairColorIndex;
			if (hasHairColorIndex)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HairColorIndex);
			}
			bool hasHairStyleIndex = this.HasHairStyleIndex;
			if (hasHairStyleIndex)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HairStyleIndex);
			}
			bool hasFacialHairIndex = this.HasFacialHairIndex;
			if (hasFacialHairIndex)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FacialHairIndex);
			}
			bool hasEyeColorIndex = this.HasEyeColorIndex;
			if (hasEyeColorIndex)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EyeColorIndex);
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
			bool hasMarkingColorIndex = this.HasMarkingColorIndex;
			if (hasMarkingColorIndex)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MarkingColorIndex);
			}
			bool hasSnoJewelry = this.HasSnoJewelry;
			if (hasSnoJewelry)
			{
				num += 5;
			}
			bool hasMakeupIndex = this.HasMakeupIndex;
			if (hasMakeupIndex)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MakeupIndex);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002779 RID: 10105 RVA: 0x0009A330 File Offset: 0x00098530
		[DebuggerNonUserCode]
		public void MergeFrom(AppearanceCustomizationOld other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPersonaIndex = other.HasPersonaIndex;
				if (hasPersonaIndex)
				{
					this.PersonaIndex = other.PersonaIndex;
				}
				bool hasHairColorIndex = other.HasHairColorIndex;
				if (hasHairColorIndex)
				{
					this.HairColorIndex = other.HairColorIndex;
				}
				bool hasHairStyleIndex = other.HasHairStyleIndex;
				if (hasHairStyleIndex)
				{
					this.HairStyleIndex = other.HairStyleIndex;
				}
				bool hasFacialHairIndex = other.HasFacialHairIndex;
				if (hasFacialHairIndex)
				{
					this.FacialHairIndex = other.FacialHairIndex;
				}
				bool hasEyeColorIndex = other.HasEyeColorIndex;
				if (hasEyeColorIndex)
				{
					this.EyeColorIndex = other.EyeColorIndex;
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
				bool hasMarkingColorIndex = other.HasMarkingColorIndex;
				if (hasMarkingColorIndex)
				{
					this.MarkingColorIndex = other.MarkingColorIndex;
				}
				bool hasSnoJewelry = other.HasSnoJewelry;
				if (hasSnoJewelry)
				{
					this.SnoJewelry = other.SnoJewelry;
				}
				bool hasMakeupIndex = other.HasMakeupIndex;
				if (hasMakeupIndex)
				{
					this.MakeupIndex = other.MakeupIndex;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600277A RID: 10106 RVA: 0x0009A46B File Offset: 0x0009866B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600277B RID: 10107 RVA: 0x0009A478 File Offset: 0x00098678
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 40U)
				{
					if (num3 <= 16U)
					{
						if (num3 != 8U)
						{
							if (num3 != 16U)
							{
								goto IL_007A;
							}
							this.HairColorIndex = input.ReadInt32();
						}
						else
						{
							this.PersonaIndex = input.ReadInt32();
						}
					}
					else if (num3 != 24U)
					{
						if (num3 != 32U)
						{
							if (num3 != 40U)
							{
								goto IL_007A;
							}
							this.EyeColorIndex = input.ReadInt32();
						}
						else
						{
							this.FacialHairIndex = input.ReadInt32();
						}
					}
					else
					{
						this.HairStyleIndex = input.ReadInt32();
					}
				}
				else if (num3 <= 61U)
				{
					if (num3 != 48U)
					{
						if (num3 != 61U)
						{
							goto IL_007A;
						}
						this.SnoMarkingShape = input.ReadSFixed32();
					}
					else
					{
						this.SkinColorIndex = input.ReadInt32();
					}
				}
				else if (num3 != 64U)
				{
					if (num3 != 77U)
					{
						if (num3 != 80U)
						{
							goto IL_007A;
						}
						this.MakeupIndex = input.ReadInt32();
					}
					else
					{
						this.SnoJewelry = input.ReadSFixed32();
					}
				}
				else
				{
					this.MarkingColorIndex = input.ReadInt32();
				}
				continue;
				IL_007A:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001166 RID: 4454
		private static readonly MessageParser<AppearanceCustomizationOld> _parser = new MessageParser<AppearanceCustomizationOld>(() => new AppearanceCustomizationOld());

		// Token: 0x04001167 RID: 4455
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001168 RID: 4456
		private int _hasBits0;

		// Token: 0x04001169 RID: 4457
		public const int PersonaIndexFieldNumber = 1;

		// Token: 0x0400116A RID: 4458
		private static readonly int PersonaIndexDefaultValue = 0;

		// Token: 0x0400116B RID: 4459
		private int personaIndex_;

		// Token: 0x0400116C RID: 4460
		public const int HairColorIndexFieldNumber = 2;

		// Token: 0x0400116D RID: 4461
		private static readonly int HairColorIndexDefaultValue = 0;

		// Token: 0x0400116E RID: 4462
		private int hairColorIndex_;

		// Token: 0x0400116F RID: 4463
		public const int HairStyleIndexFieldNumber = 3;

		// Token: 0x04001170 RID: 4464
		private static readonly int HairStyleIndexDefaultValue = 0;

		// Token: 0x04001171 RID: 4465
		private int hairStyleIndex_;

		// Token: 0x04001172 RID: 4466
		public const int FacialHairIndexFieldNumber = 4;

		// Token: 0x04001173 RID: 4467
		private static readonly int FacialHairIndexDefaultValue = 0;

		// Token: 0x04001174 RID: 4468
		private int facialHairIndex_;

		// Token: 0x04001175 RID: 4469
		public const int EyeColorIndexFieldNumber = 5;

		// Token: 0x04001176 RID: 4470
		private static readonly int EyeColorIndexDefaultValue = 0;

		// Token: 0x04001177 RID: 4471
		private int eyeColorIndex_;

		// Token: 0x04001178 RID: 4472
		public const int SkinColorIndexFieldNumber = 6;

		// Token: 0x04001179 RID: 4473
		private static readonly int SkinColorIndexDefaultValue = 0;

		// Token: 0x0400117A RID: 4474
		private int skinColorIndex_;

		// Token: 0x0400117B RID: 4475
		public const int SnoMarkingShapeFieldNumber = 7;

		// Token: 0x0400117C RID: 4476
		private static readonly int SnoMarkingShapeDefaultValue = -1;

		// Token: 0x0400117D RID: 4477
		private int snoMarkingShape_;

		// Token: 0x0400117E RID: 4478
		public const int MarkingColorIndexFieldNumber = 8;

		// Token: 0x0400117F RID: 4479
		private static readonly int MarkingColorIndexDefaultValue = 0;

		// Token: 0x04001180 RID: 4480
		private int markingColorIndex_;

		// Token: 0x04001181 RID: 4481
		public const int SnoJewelryFieldNumber = 9;

		// Token: 0x04001182 RID: 4482
		private static readonly int SnoJewelryDefaultValue = -1;

		// Token: 0x04001183 RID: 4483
		private int snoJewelry_;

		// Token: 0x04001184 RID: 4484
		public const int MakeupIndexFieldNumber = 10;

		// Token: 0x04001185 RID: 4485
		private static readonly int MakeupIndexDefaultValue = 0;

		// Token: 0x04001186 RID: 4486
		private int makeupIndex_;
	}
}
