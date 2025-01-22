using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200043F RID: 1087
	public sealed class ClubCreateOptions : IMessage<ClubCreateOptions>, IMessage, IEquatable<ClubCreateOptions>, IDeepCloneable<ClubCreateOptions>, IBufferMessage
	{
		// Token: 0x17002205 RID: 8709
		// (get) Token: 0x06006A95 RID: 27285 RVA: 0x0019CCC8 File Offset: 0x0019AEC8
		[DebuggerNonUserCode]
		public static MessageParser<ClubCreateOptions> Parser
		{
			get
			{
				return ClubCreateOptions._parser;
			}
		}

		// Token: 0x17002206 RID: 8710
		// (get) Token: 0x06006A96 RID: 27286 RVA: 0x0019CCE0 File Offset: 0x0019AEE0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubCoreReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17002207 RID: 8711
		// (get) Token: 0x06006A97 RID: 27287 RVA: 0x0019CD04 File Offset: 0x0019AF04
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubCreateOptions.Descriptor;
			}
		}

		// Token: 0x06006A98 RID: 27288 RVA: 0x0019CD1B File Offset: 0x0019AF1B
		[DebuggerNonUserCode]
		public ClubCreateOptions()
		{
		}

		// Token: 0x06006A99 RID: 27289 RVA: 0x0019CD3C File Offset: 0x0019AF3C
		[DebuggerNonUserCode]
		public ClubCreateOptions(ClubCreateOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.type_ = ((other.type_ != null) ? other.type_.Clone() : null);
			this.attribute_ = other.attribute_.Clone();
			this.name_ = other.name_;
			this.description_ = other.description_;
			this.avatar_ = ((other.avatar_ != null) ? other.avatar_.Clone() : null);
			this.privacyLevel_ = other.privacyLevel_;
			this.shortName_ = other.shortName_;
			this.visibilityLevel_ = other.visibilityLevel_;
			this.member_ = ((other.member_ != null) ? other.member_.Clone() : null);
			this.stream_ = ((other.stream_ != null) ? other.stream_.Clone() : null);
			this.tag_ = ((other.tag_ != null) ? other.tag_.Clone() : null);
			this.searchAttribute_ = other.searchAttribute_.Clone();
			this.locale_ = other.locale_;
			this.timezone_ = other.timezone_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006A9A RID: 27290 RVA: 0x0019CE70 File Offset: 0x0019B070
		[DebuggerNonUserCode]
		public ClubCreateOptions Clone()
		{
			return new ClubCreateOptions(this);
		}

		// Token: 0x17002208 RID: 8712
		// (get) Token: 0x06006A9B RID: 27291 RVA: 0x0019CE88 File Offset: 0x0019B088
		// (set) Token: 0x06006A9C RID: 27292 RVA: 0x0019CEA0 File Offset: 0x0019B0A0
		[DebuggerNonUserCode]
		public UniqueClubType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17002209 RID: 8713
		// (get) Token: 0x06006A9D RID: 27293 RVA: 0x0019CEAC File Offset: 0x0019B0AC
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x1700220A RID: 8714
		// (get) Token: 0x06006A9E RID: 27294 RVA: 0x0019CEC4 File Offset: 0x0019B0C4
		// (set) Token: 0x06006A9F RID: 27295 RVA: 0x0019CEE5 File Offset: 0x0019B0E5
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? ClubCreateOptions.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700220B RID: 8715
		// (get) Token: 0x06006AA0 RID: 27296 RVA: 0x0019CEFC File Offset: 0x0019B0FC
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06006AA1 RID: 27297 RVA: 0x0019CF17 File Offset: 0x0019B117
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x1700220C RID: 8716
		// (get) Token: 0x06006AA2 RID: 27298 RVA: 0x0019CF24 File Offset: 0x0019B124
		// (set) Token: 0x06006AA3 RID: 27299 RVA: 0x0019CF45 File Offset: 0x0019B145
		[DebuggerNonUserCode]
		public string Description
		{
			get
			{
				return this.description_ ?? ClubCreateOptions.DescriptionDefaultValue;
			}
			set
			{
				this.description_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700220D RID: 8717
		// (get) Token: 0x06006AA4 RID: 27300 RVA: 0x0019CF5C File Offset: 0x0019B15C
		[DebuggerNonUserCode]
		public bool HasDescription
		{
			get
			{
				return this.description_ != null;
			}
		}

		// Token: 0x06006AA5 RID: 27301 RVA: 0x0019CF77 File Offset: 0x0019B177
		[DebuggerNonUserCode]
		public void ClearDescription()
		{
			this.description_ = null;
		}

		// Token: 0x1700220E RID: 8718
		// (get) Token: 0x06006AA6 RID: 27302 RVA: 0x0019CF84 File Offset: 0x0019B184
		// (set) Token: 0x06006AA7 RID: 27303 RVA: 0x0019CF9C File Offset: 0x0019B19C
		[DebuggerNonUserCode]
		public AvatarId Avatar
		{
			get
			{
				return this.avatar_;
			}
			set
			{
				this.avatar_ = value;
			}
		}

		// Token: 0x1700220F RID: 8719
		// (get) Token: 0x06006AA8 RID: 27304 RVA: 0x0019CFA8 File Offset: 0x0019B1A8
		// (set) Token: 0x06006AA9 RID: 27305 RVA: 0x0019CFD9 File Offset: 0x0019B1D9
		[DebuggerNonUserCode]
		public PrivacyLevel PrivacyLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				PrivacyLevel privacyLevelDefaultValue;
				if (flag)
				{
					privacyLevelDefaultValue = this.privacyLevel_;
				}
				else
				{
					privacyLevelDefaultValue = ClubCreateOptions.PrivacyLevelDefaultValue;
				}
				return privacyLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.privacyLevel_ = value;
			}
		}

		// Token: 0x17002210 RID: 8720
		// (get) Token: 0x06006AAA RID: 27306 RVA: 0x0019CFF4 File Offset: 0x0019B1F4
		[DebuggerNonUserCode]
		public bool HasPrivacyLevel
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006AAB RID: 27307 RVA: 0x0019D011 File Offset: 0x0019B211
		[DebuggerNonUserCode]
		public void ClearPrivacyLevel()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002211 RID: 8721
		// (get) Token: 0x06006AAC RID: 27308 RVA: 0x0019D024 File Offset: 0x0019B224
		// (set) Token: 0x06006AAD RID: 27309 RVA: 0x0019D045 File Offset: 0x0019B245
		[DebuggerNonUserCode]
		public string ShortName
		{
			get
			{
				return this.shortName_ ?? ClubCreateOptions.ShortNameDefaultValue;
			}
			set
			{
				this.shortName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002212 RID: 8722
		// (get) Token: 0x06006AAE RID: 27310 RVA: 0x0019D05C File Offset: 0x0019B25C
		[DebuggerNonUserCode]
		public bool HasShortName
		{
			get
			{
				return this.shortName_ != null;
			}
		}

		// Token: 0x06006AAF RID: 27311 RVA: 0x0019D077 File Offset: 0x0019B277
		[DebuggerNonUserCode]
		public void ClearShortName()
		{
			this.shortName_ = null;
		}

		// Token: 0x17002213 RID: 8723
		// (get) Token: 0x06006AB0 RID: 27312 RVA: 0x0019D084 File Offset: 0x0019B284
		// (set) Token: 0x06006AB1 RID: 27313 RVA: 0x0019D0B5 File Offset: 0x0019B2B5
		[DebuggerNonUserCode]
		public VisibilityLevel VisibilityLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				VisibilityLevel visibilityLevelDefaultValue;
				if (flag)
				{
					visibilityLevelDefaultValue = this.visibilityLevel_;
				}
				else
				{
					visibilityLevelDefaultValue = ClubCreateOptions.VisibilityLevelDefaultValue;
				}
				return visibilityLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.visibilityLevel_ = value;
			}
		}

		// Token: 0x17002214 RID: 8724
		// (get) Token: 0x06006AB2 RID: 27314 RVA: 0x0019D0D0 File Offset: 0x0019B2D0
		[DebuggerNonUserCode]
		public bool HasVisibilityLevel
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06006AB3 RID: 27315 RVA: 0x0019D0ED File Offset: 0x0019B2ED
		[DebuggerNonUserCode]
		public void ClearVisibilityLevel()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002215 RID: 8725
		// (get) Token: 0x06006AB4 RID: 27316 RVA: 0x0019D100 File Offset: 0x0019B300
		// (set) Token: 0x06006AB5 RID: 27317 RVA: 0x0019D118 File Offset: 0x0019B318
		[DebuggerNonUserCode]
		public CreateMemberOptions Member
		{
			get
			{
				return this.member_;
			}
			set
			{
				this.member_ = value;
			}
		}

		// Token: 0x17002216 RID: 8726
		// (get) Token: 0x06006AB6 RID: 27318 RVA: 0x0019D124 File Offset: 0x0019B324
		// (set) Token: 0x06006AB7 RID: 27319 RVA: 0x0019D13C File Offset: 0x0019B33C
		[DebuggerNonUserCode]
		public CreateStreamOptions Stream
		{
			get
			{
				return this.stream_;
			}
			set
			{
				this.stream_ = value;
			}
		}

		// Token: 0x17002217 RID: 8727
		// (get) Token: 0x06006AB8 RID: 27320 RVA: 0x0019D148 File Offset: 0x0019B348
		// (set) Token: 0x06006AB9 RID: 27321 RVA: 0x0019D160 File Offset: 0x0019B360
		[DebuggerNonUserCode]
		public TagOptions Tag
		{
			get
			{
				return this.tag_;
			}
			set
			{
				this.tag_ = value;
			}
		}

		// Token: 0x17002218 RID: 8728
		// (get) Token: 0x06006ABA RID: 27322 RVA: 0x0019D16C File Offset: 0x0019B36C
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> SearchAttribute
		{
			get
			{
				return this.searchAttribute_;
			}
		}

		// Token: 0x17002219 RID: 8729
		// (get) Token: 0x06006ABB RID: 27323 RVA: 0x0019D184 File Offset: 0x0019B384
		// (set) Token: 0x06006ABC RID: 27324 RVA: 0x0019D1A5 File Offset: 0x0019B3A5
		[DebuggerNonUserCode]
		public string Locale
		{
			get
			{
				return this.locale_ ?? ClubCreateOptions.LocaleDefaultValue;
			}
			set
			{
				this.locale_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700221A RID: 8730
		// (get) Token: 0x06006ABD RID: 27325 RVA: 0x0019D1BC File Offset: 0x0019B3BC
		[DebuggerNonUserCode]
		public bool HasLocale
		{
			get
			{
				return this.locale_ != null;
			}
		}

		// Token: 0x06006ABE RID: 27326 RVA: 0x0019D1D7 File Offset: 0x0019B3D7
		[DebuggerNonUserCode]
		public void ClearLocale()
		{
			this.locale_ = null;
		}

		// Token: 0x1700221B RID: 8731
		// (get) Token: 0x06006ABF RID: 27327 RVA: 0x0019D1E4 File Offset: 0x0019B3E4
		// (set) Token: 0x06006AC0 RID: 27328 RVA: 0x0019D205 File Offset: 0x0019B405
		[DebuggerNonUserCode]
		public string Timezone
		{
			get
			{
				return this.timezone_ ?? ClubCreateOptions.TimezoneDefaultValue;
			}
			set
			{
				this.timezone_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700221C RID: 8732
		// (get) Token: 0x06006AC1 RID: 27329 RVA: 0x0019D21C File Offset: 0x0019B41C
		[DebuggerNonUserCode]
		public bool HasTimezone
		{
			get
			{
				return this.timezone_ != null;
			}
		}

		// Token: 0x06006AC2 RID: 27330 RVA: 0x0019D237 File Offset: 0x0019B437
		[DebuggerNonUserCode]
		public void ClearTimezone()
		{
			this.timezone_ = null;
		}

		// Token: 0x06006AC3 RID: 27331 RVA: 0x0019D244 File Offset: 0x0019B444
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubCreateOptions);
		}

		// Token: 0x06006AC4 RID: 27332 RVA: 0x0019D264 File Offset: 0x0019B464
		[DebuggerNonUserCode]
		public bool Equals(ClubCreateOptions other)
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
					bool flag4 = !object.Equals(this.Type, other.Type);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.attribute_.Equals(other.attribute_);
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
								bool flag7 = this.Description != other.Description;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.Avatar, other.Avatar);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.PrivacyLevel != other.PrivacyLevel;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.ShortName != other.ShortName;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.VisibilityLevel != other.VisibilityLevel;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !object.Equals(this.Member, other.Member);
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = !object.Equals(this.Stream, other.Stream);
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = !object.Equals(this.Tag, other.Tag);
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = !this.searchAttribute_.Equals(other.searchAttribute_);
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = this.Locale != other.Locale;
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = this.Timezone != other.Timezone;
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

		// Token: 0x06006AC5 RID: 27333 RVA: 0x0019D454 File Offset: 0x0019B654
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.type_ != null;
			if (flag)
			{
				num ^= this.Type.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				num ^= this.Description.GetHashCode();
			}
			bool flag2 = this.avatar_ != null;
			if (flag2)
			{
				num ^= this.Avatar.GetHashCode();
			}
			bool hasPrivacyLevel = this.HasPrivacyLevel;
			if (hasPrivacyLevel)
			{
				num ^= this.PrivacyLevel.GetHashCode();
			}
			bool hasShortName = this.HasShortName;
			if (hasShortName)
			{
				num ^= this.ShortName.GetHashCode();
			}
			bool hasVisibilityLevel = this.HasVisibilityLevel;
			if (hasVisibilityLevel)
			{
				num ^= this.VisibilityLevel.GetHashCode();
			}
			bool flag3 = this.member_ != null;
			if (flag3)
			{
				num ^= this.Member.GetHashCode();
			}
			bool flag4 = this.stream_ != null;
			if (flag4)
			{
				num ^= this.Stream.GetHashCode();
			}
			bool flag5 = this.tag_ != null;
			if (flag5)
			{
				num ^= this.Tag.GetHashCode();
			}
			num ^= this.searchAttribute_.GetHashCode();
			bool hasLocale = this.HasLocale;
			if (hasLocale)
			{
				num ^= this.Locale.GetHashCode();
			}
			bool hasTimezone = this.HasTimezone;
			if (hasTimezone)
			{
				num ^= this.Timezone.GetHashCode();
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006AC6 RID: 27334 RVA: 0x0019D5FC File Offset: 0x0019B7FC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006AC7 RID: 27335 RVA: 0x0019D614 File Offset: 0x0019B814
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006AC8 RID: 27336 RVA: 0x0019D620 File Offset: 0x0019B820
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.type_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Type);
			}
			this.attribute_.WriteTo(ref output, ClubCreateOptions._repeated_attribute_codec);
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Name);
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Description);
			}
			bool flag2 = this.avatar_ != null;
			if (flag2)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Avatar);
			}
			bool hasPrivacyLevel = this.HasPrivacyLevel;
			if (hasPrivacyLevel)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.PrivacyLevel);
			}
			bool hasShortName = this.HasShortName;
			if (hasShortName)
			{
				output.WriteRawTag(58);
				output.WriteString(this.ShortName);
			}
			bool hasVisibilityLevel = this.HasVisibilityLevel;
			if (hasVisibilityLevel)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.VisibilityLevel);
			}
			bool flag3 = this.member_ != null;
			if (flag3)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Member);
			}
			bool flag4 = this.stream_ != null;
			if (flag4)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Stream);
			}
			bool flag5 = this.tag_ != null;
			if (flag5)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.Tag);
			}
			this.searchAttribute_.WriteTo(ref output, ClubCreateOptions._repeated_searchAttribute_codec);
			bool hasLocale = this.HasLocale;
			if (hasLocale)
			{
				output.WriteRawTag(114);
				output.WriteString(this.Locale);
			}
			bool hasTimezone = this.HasTimezone;
			if (hasTimezone)
			{
				output.WriteRawTag(122);
				output.WriteString(this.Timezone);
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006AC9 RID: 27337 RVA: 0x0019D828 File Offset: 0x0019BA28
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.type_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Type);
			}
			num += this.attribute_.CalculateSize(ClubCreateOptions._repeated_attribute_codec);
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Description);
			}
			bool flag2 = this.avatar_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Avatar);
			}
			bool hasPrivacyLevel = this.HasPrivacyLevel;
			if (hasPrivacyLevel)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.PrivacyLevel);
			}
			bool hasShortName = this.HasShortName;
			if (hasShortName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ShortName);
			}
			bool hasVisibilityLevel = this.HasVisibilityLevel;
			if (hasVisibilityLevel)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.VisibilityLevel);
			}
			bool flag3 = this.member_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Member);
			}
			bool flag4 = this.stream_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Stream);
			}
			bool flag5 = this.tag_ != null;
			if (flag5)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Tag);
			}
			num += this.searchAttribute_.CalculateSize(ClubCreateOptions._repeated_searchAttribute_codec);
			bool hasLocale = this.HasLocale;
			if (hasLocale)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Locale);
			}
			bool hasTimezone = this.HasTimezone;
			if (hasTimezone)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Timezone);
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006ACA RID: 27338 RVA: 0x0019D9F8 File Offset: 0x0019BBF8
		[DebuggerNonUserCode]
		public void MergeFrom(ClubCreateOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.type_ != null;
				if (flag2)
				{
					bool flag3 = this.type_ == null;
					if (flag3)
					{
						this.Type = new UniqueClubType();
					}
					this.Type.MergeFrom(other.Type);
				}
				this.attribute_.Add(other.attribute_);
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool hasDescription = other.HasDescription;
				if (hasDescription)
				{
					this.Description = other.Description;
				}
				bool flag4 = other.avatar_ != null;
				if (flag4)
				{
					bool flag5 = this.avatar_ == null;
					if (flag5)
					{
						this.Avatar = new AvatarId();
					}
					this.Avatar.MergeFrom(other.Avatar);
				}
				bool hasPrivacyLevel = other.HasPrivacyLevel;
				if (hasPrivacyLevel)
				{
					this.PrivacyLevel = other.PrivacyLevel;
				}
				bool hasShortName = other.HasShortName;
				if (hasShortName)
				{
					this.ShortName = other.ShortName;
				}
				bool hasVisibilityLevel = other.HasVisibilityLevel;
				if (hasVisibilityLevel)
				{
					this.VisibilityLevel = other.VisibilityLevel;
				}
				bool flag6 = other.member_ != null;
				if (flag6)
				{
					bool flag7 = this.member_ == null;
					if (flag7)
					{
						this.Member = new CreateMemberOptions();
					}
					this.Member.MergeFrom(other.Member);
				}
				bool flag8 = other.stream_ != null;
				if (flag8)
				{
					bool flag9 = this.stream_ == null;
					if (flag9)
					{
						this.Stream = new CreateStreamOptions();
					}
					this.Stream.MergeFrom(other.Stream);
				}
				bool flag10 = other.tag_ != null;
				if (flag10)
				{
					bool flag11 = this.tag_ == null;
					if (flag11)
					{
						this.Tag = new TagOptions();
					}
					this.Tag.MergeFrom(other.Tag);
				}
				this.searchAttribute_.Add(other.searchAttribute_);
				bool hasLocale = other.HasLocale;
				if (hasLocale)
				{
					this.Locale = other.Locale;
				}
				bool hasTimezone = other.HasTimezone;
				if (hasTimezone)
				{
					this.Timezone = other.Timezone;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006ACB RID: 27339 RVA: 0x0019DC46 File Offset: 0x0019BE46
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006ACC RID: 27340 RVA: 0x0019DC54 File Offset: 0x0019BE54
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
						if (num3 != 10U)
						{
							if (num3 != 18U)
							{
								if (num3 != 26U)
								{
									goto IL_00B0;
								}
								this.Name = input.ReadString();
							}
							else
							{
								this.attribute_.AddEntriesFrom(ref input, ClubCreateOptions._repeated_attribute_codec);
							}
						}
						else
						{
							bool flag = this.type_ == null;
							if (flag)
							{
								this.Type = new UniqueClubType();
							}
							input.ReadMessage(this.Type);
						}
					}
					else if (num3 <= 42U)
					{
						if (num3 != 34U)
						{
							if (num3 != 42U)
							{
								goto IL_00B0;
							}
							bool flag2 = this.avatar_ == null;
							if (flag2)
							{
								this.Avatar = new AvatarId();
							}
							input.ReadMessage(this.Avatar);
						}
						else
						{
							this.Description = input.ReadString();
						}
					}
					else if (num3 != 48U)
					{
						if (num3 != 58U)
						{
							goto IL_00B0;
						}
						this.ShortName = input.ReadString();
					}
					else
					{
						this.PrivacyLevel = (PrivacyLevel)input.ReadEnum();
					}
				}
				else if (num3 <= 90U)
				{
					if (num3 != 64U)
					{
						if (num3 != 82U)
						{
							if (num3 != 90U)
							{
								goto IL_00B0;
							}
							bool flag3 = this.stream_ == null;
							if (flag3)
							{
								this.Stream = new CreateStreamOptions();
							}
							input.ReadMessage(this.Stream);
						}
						else
						{
							bool flag4 = this.member_ == null;
							if (flag4)
							{
								this.Member = new CreateMemberOptions();
							}
							input.ReadMessage(this.Member);
						}
					}
					else
					{
						this.VisibilityLevel = (VisibilityLevel)input.ReadEnum();
					}
				}
				else if (num3 <= 106U)
				{
					if (num3 != 98U)
					{
						if (num3 != 106U)
						{
							goto IL_00B0;
						}
						this.searchAttribute_.AddEntriesFrom(ref input, ClubCreateOptions._repeated_searchAttribute_codec);
					}
					else
					{
						bool flag5 = this.tag_ == null;
						if (flag5)
						{
							this.Tag = new TagOptions();
						}
						input.ReadMessage(this.Tag);
					}
				}
				else if (num3 != 114U)
				{
					if (num3 != 122U)
					{
						goto IL_00B0;
					}
					this.Timezone = input.ReadString();
				}
				else
				{
					this.Locale = input.ReadString();
				}
				continue;
				IL_00B0:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003082 RID: 12418
		private static readonly MessageParser<ClubCreateOptions> _parser = new MessageParser<ClubCreateOptions>(() => new ClubCreateOptions());

		// Token: 0x04003083 RID: 12419
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003084 RID: 12420
		private int _hasBits0;

		// Token: 0x04003085 RID: 12421
		public const int TypeFieldNumber = 1;

		// Token: 0x04003086 RID: 12422
		private UniqueClubType type_;

		// Token: 0x04003087 RID: 12423
		public const int AttributeFieldNumber = 2;

		// Token: 0x04003088 RID: 12424
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(18U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x04003089 RID: 12425
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		// Token: 0x0400308A RID: 12426
		public const int NameFieldNumber = 3;

		// Token: 0x0400308B RID: 12427
		private static readonly string NameDefaultValue = "";

		// Token: 0x0400308C RID: 12428
		private string name_;

		// Token: 0x0400308D RID: 12429
		public const int DescriptionFieldNumber = 4;

		// Token: 0x0400308E RID: 12430
		private static readonly string DescriptionDefaultValue = "";

		// Token: 0x0400308F RID: 12431
		private string description_;

		// Token: 0x04003090 RID: 12432
		public const int AvatarFieldNumber = 5;

		// Token: 0x04003091 RID: 12433
		private AvatarId avatar_;

		// Token: 0x04003092 RID: 12434
		public const int PrivacyLevelFieldNumber = 6;

		// Token: 0x04003093 RID: 12435
		private static readonly PrivacyLevel PrivacyLevelDefaultValue = PrivacyLevel.Closed;

		// Token: 0x04003094 RID: 12436
		private PrivacyLevel privacyLevel_;

		// Token: 0x04003095 RID: 12437
		public const int ShortNameFieldNumber = 7;

		// Token: 0x04003096 RID: 12438
		private static readonly string ShortNameDefaultValue = "";

		// Token: 0x04003097 RID: 12439
		private string shortName_;

		// Token: 0x04003098 RID: 12440
		public const int VisibilityLevelFieldNumber = 8;

		// Token: 0x04003099 RID: 12441
		private static readonly VisibilityLevel VisibilityLevelDefaultValue = VisibilityLevel.Private;

		// Token: 0x0400309A RID: 12442
		private VisibilityLevel visibilityLevel_;

		// Token: 0x0400309B RID: 12443
		public const int MemberFieldNumber = 10;

		// Token: 0x0400309C RID: 12444
		private CreateMemberOptions member_;

		// Token: 0x0400309D RID: 12445
		public const int StreamFieldNumber = 11;

		// Token: 0x0400309E RID: 12446
		private CreateStreamOptions stream_;

		// Token: 0x0400309F RID: 12447
		public const int TagFieldNumber = 12;

		// Token: 0x040030A0 RID: 12448
		private TagOptions tag_;

		// Token: 0x040030A1 RID: 12449
		public const int SearchAttributeFieldNumber = 13;

		// Token: 0x040030A2 RID: 12450
		private static readonly FieldCodec<Attribute> _repeated_searchAttribute_codec = FieldCodec.ForMessage<Attribute>(106U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x040030A3 RID: 12451
		private readonly RepeatedField<Attribute> searchAttribute_ = new RepeatedField<Attribute>();

		// Token: 0x040030A4 RID: 12452
		public const int LocaleFieldNumber = 14;

		// Token: 0x040030A5 RID: 12453
		private static readonly string LocaleDefaultValue = "";

		// Token: 0x040030A6 RID: 12454
		private string locale_;

		// Token: 0x040030A7 RID: 12455
		public const int TimezoneFieldNumber = 15;

		// Token: 0x040030A8 RID: 12456
		private static readonly string TimezoneDefaultValue = "";

		// Token: 0x040030A9 RID: 12457
		private string timezone_;
	}
}
