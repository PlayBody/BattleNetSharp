using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000444 RID: 1092
	public sealed class ClubStateAssignment : IMessage<ClubStateAssignment>, IMessage, IEquatable<ClubStateAssignment>, IDeepCloneable<ClubStateAssignment>, IBufferMessage
	{
		// Token: 0x17002273 RID: 8819
		// (get) Token: 0x06006B9E RID: 27550 RVA: 0x001A1EE8 File Offset: 0x001A00E8
		[DebuggerNonUserCode]
		public static MessageParser<ClubStateAssignment> Parser
		{
			get
			{
				return ClubStateAssignment._parser;
			}
		}

		// Token: 0x17002274 RID: 8820
		// (get) Token: 0x06006B9F RID: 27551 RVA: 0x001A1F00 File Offset: 0x001A0100
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubCoreReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x17002275 RID: 8821
		// (get) Token: 0x06006BA0 RID: 27552 RVA: 0x001A1F24 File Offset: 0x001A0124
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubStateAssignment.Descriptor;
			}
		}

		// Token: 0x06006BA1 RID: 27553 RVA: 0x001A1F3B File Offset: 0x001A013B
		[DebuggerNonUserCode]
		public ClubStateAssignment()
		{
		}

		// Token: 0x06006BA2 RID: 27554 RVA: 0x001A1F68 File Offset: 0x001A0168
		[DebuggerNonUserCode]
		public ClubStateAssignment(ClubStateAssignment other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clubId_ = other.clubId_;
			this.attribute_ = other.attribute_.Clone();
			this.name_ = other.name_;
			this.description_ = other.description_;
			this.broadcast_ = ((other.broadcast_ != null) ? other.broadcast_.Clone() : null);
			this.avatar_ = ((other.avatar_ != null) ? other.avatar_.Clone() : null);
			this.privacyLevel_ = other.privacyLevel_;
			this.streamPosition_ = ((other.streamPosition_ != null) ? other.streamPosition_.Clone() : null);
			this.shortName_ = other.shortName_;
			this.visibilityLevel_ = other.visibilityLevel_;
			this.locale_ = other.locale_;
			this.timezone_ = other.timezone_;
			this.tag_ = other.tag_.Clone();
			this.searchAttribute_ = other.searchAttribute_.Clone();
			this.tagCleared_ = other.tagCleared_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006BA3 RID: 27555 RVA: 0x001A2090 File Offset: 0x001A0290
		[DebuggerNonUserCode]
		public ClubStateAssignment Clone()
		{
			return new ClubStateAssignment(this);
		}

		// Token: 0x17002276 RID: 8822
		// (get) Token: 0x06006BA4 RID: 27556 RVA: 0x001A20A8 File Offset: 0x001A02A8
		// (set) Token: 0x06006BA5 RID: 27557 RVA: 0x001A20D9 File Offset: 0x001A02D9
		[DebuggerNonUserCode]
		public ulong ClubId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong clubIdDefaultValue;
				if (flag)
				{
					clubIdDefaultValue = this.clubId_;
				}
				else
				{
					clubIdDefaultValue = ClubStateAssignment.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002277 RID: 8823
		// (get) Token: 0x06006BA6 RID: 27558 RVA: 0x001A20F4 File Offset: 0x001A02F4
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006BA7 RID: 27559 RVA: 0x001A2111 File Offset: 0x001A0311
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002278 RID: 8824
		// (get) Token: 0x06006BA8 RID: 27560 RVA: 0x001A2124 File Offset: 0x001A0324
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x17002279 RID: 8825
		// (get) Token: 0x06006BA9 RID: 27561 RVA: 0x001A213C File Offset: 0x001A033C
		// (set) Token: 0x06006BAA RID: 27562 RVA: 0x001A215D File Offset: 0x001A035D
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? ClubStateAssignment.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700227A RID: 8826
		// (get) Token: 0x06006BAB RID: 27563 RVA: 0x001A2174 File Offset: 0x001A0374
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06006BAC RID: 27564 RVA: 0x001A218F File Offset: 0x001A038F
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x1700227B RID: 8827
		// (get) Token: 0x06006BAD RID: 27565 RVA: 0x001A219C File Offset: 0x001A039C
		// (set) Token: 0x06006BAE RID: 27566 RVA: 0x001A21BD File Offset: 0x001A03BD
		[DebuggerNonUserCode]
		public string Description
		{
			get
			{
				return this.description_ ?? ClubStateAssignment.DescriptionDefaultValue;
			}
			set
			{
				this.description_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700227C RID: 8828
		// (get) Token: 0x06006BAF RID: 27567 RVA: 0x001A21D4 File Offset: 0x001A03D4
		[DebuggerNonUserCode]
		public bool HasDescription
		{
			get
			{
				return this.description_ != null;
			}
		}

		// Token: 0x06006BB0 RID: 27568 RVA: 0x001A21EF File Offset: 0x001A03EF
		[DebuggerNonUserCode]
		public void ClearDescription()
		{
			this.description_ = null;
		}

		// Token: 0x1700227D RID: 8829
		// (get) Token: 0x06006BB1 RID: 27569 RVA: 0x001A21FC File Offset: 0x001A03FC
		// (set) Token: 0x06006BB2 RID: 27570 RVA: 0x001A2214 File Offset: 0x001A0414
		[DebuggerNonUserCode]
		public Broadcast Broadcast
		{
			get
			{
				return this.broadcast_;
			}
			set
			{
				this.broadcast_ = value;
			}
		}

		// Token: 0x1700227E RID: 8830
		// (get) Token: 0x06006BB3 RID: 27571 RVA: 0x001A2220 File Offset: 0x001A0420
		// (set) Token: 0x06006BB4 RID: 27572 RVA: 0x001A2238 File Offset: 0x001A0438
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

		// Token: 0x1700227F RID: 8831
		// (get) Token: 0x06006BB5 RID: 27573 RVA: 0x001A2244 File Offset: 0x001A0444
		// (set) Token: 0x06006BB6 RID: 27574 RVA: 0x001A2275 File Offset: 0x001A0475
		[DebuggerNonUserCode]
		public PrivacyLevel PrivacyLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				PrivacyLevel privacyLevelDefaultValue;
				if (flag)
				{
					privacyLevelDefaultValue = this.privacyLevel_;
				}
				else
				{
					privacyLevelDefaultValue = ClubStateAssignment.PrivacyLevelDefaultValue;
				}
				return privacyLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.privacyLevel_ = value;
			}
		}

		// Token: 0x17002280 RID: 8832
		// (get) Token: 0x06006BB7 RID: 27575 RVA: 0x001A2290 File Offset: 0x001A0490
		[DebuggerNonUserCode]
		public bool HasPrivacyLevel
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06006BB8 RID: 27576 RVA: 0x001A22AD File Offset: 0x001A04AD
		[DebuggerNonUserCode]
		public void ClearPrivacyLevel()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002281 RID: 8833
		// (get) Token: 0x06006BB9 RID: 27577 RVA: 0x001A22C0 File Offset: 0x001A04C0
		// (set) Token: 0x06006BBA RID: 27578 RVA: 0x001A22D8 File Offset: 0x001A04D8
		[DebuggerNonUserCode]
		public StreamPosition StreamPosition
		{
			get
			{
				return this.streamPosition_;
			}
			set
			{
				this.streamPosition_ = value;
			}
		}

		// Token: 0x17002282 RID: 8834
		// (get) Token: 0x06006BBB RID: 27579 RVA: 0x001A22E4 File Offset: 0x001A04E4
		// (set) Token: 0x06006BBC RID: 27580 RVA: 0x001A2305 File Offset: 0x001A0505
		[DebuggerNonUserCode]
		public string ShortName
		{
			get
			{
				return this.shortName_ ?? ClubStateAssignment.ShortNameDefaultValue;
			}
			set
			{
				this.shortName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002283 RID: 8835
		// (get) Token: 0x06006BBD RID: 27581 RVA: 0x001A231C File Offset: 0x001A051C
		[DebuggerNonUserCode]
		public bool HasShortName
		{
			get
			{
				return this.shortName_ != null;
			}
		}

		// Token: 0x06006BBE RID: 27582 RVA: 0x001A2337 File Offset: 0x001A0537
		[DebuggerNonUserCode]
		public void ClearShortName()
		{
			this.shortName_ = null;
		}

		// Token: 0x17002284 RID: 8836
		// (get) Token: 0x06006BBF RID: 27583 RVA: 0x001A2344 File Offset: 0x001A0544
		// (set) Token: 0x06006BC0 RID: 27584 RVA: 0x001A2375 File Offset: 0x001A0575
		[DebuggerNonUserCode]
		public VisibilityLevel VisibilityLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				VisibilityLevel visibilityLevelDefaultValue;
				if (flag)
				{
					visibilityLevelDefaultValue = this.visibilityLevel_;
				}
				else
				{
					visibilityLevelDefaultValue = ClubStateAssignment.VisibilityLevelDefaultValue;
				}
				return visibilityLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.visibilityLevel_ = value;
			}
		}

		// Token: 0x17002285 RID: 8837
		// (get) Token: 0x06006BC1 RID: 27585 RVA: 0x001A2390 File Offset: 0x001A0590
		[DebuggerNonUserCode]
		public bool HasVisibilityLevel
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06006BC2 RID: 27586 RVA: 0x001A23AD File Offset: 0x001A05AD
		[DebuggerNonUserCode]
		public void ClearVisibilityLevel()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17002286 RID: 8838
		// (get) Token: 0x06006BC3 RID: 27587 RVA: 0x001A23C0 File Offset: 0x001A05C0
		// (set) Token: 0x06006BC4 RID: 27588 RVA: 0x001A23E1 File Offset: 0x001A05E1
		[DebuggerNonUserCode]
		public string Locale
		{
			get
			{
				return this.locale_ ?? ClubStateAssignment.LocaleDefaultValue;
			}
			set
			{
				this.locale_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002287 RID: 8839
		// (get) Token: 0x06006BC5 RID: 27589 RVA: 0x001A23F8 File Offset: 0x001A05F8
		[DebuggerNonUserCode]
		public bool HasLocale
		{
			get
			{
				return this.locale_ != null;
			}
		}

		// Token: 0x06006BC6 RID: 27590 RVA: 0x001A2413 File Offset: 0x001A0613
		[DebuggerNonUserCode]
		public void ClearLocale()
		{
			this.locale_ = null;
		}

		// Token: 0x17002288 RID: 8840
		// (get) Token: 0x06006BC7 RID: 27591 RVA: 0x001A2420 File Offset: 0x001A0620
		// (set) Token: 0x06006BC8 RID: 27592 RVA: 0x001A2441 File Offset: 0x001A0641
		[DebuggerNonUserCode]
		public string Timezone
		{
			get
			{
				return this.timezone_ ?? ClubStateAssignment.TimezoneDefaultValue;
			}
			set
			{
				this.timezone_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002289 RID: 8841
		// (get) Token: 0x06006BC9 RID: 27593 RVA: 0x001A2458 File Offset: 0x001A0658
		[DebuggerNonUserCode]
		public bool HasTimezone
		{
			get
			{
				return this.timezone_ != null;
			}
		}

		// Token: 0x06006BCA RID: 27594 RVA: 0x001A2473 File Offset: 0x001A0673
		[DebuggerNonUserCode]
		public void ClearTimezone()
		{
			this.timezone_ = null;
		}

		// Token: 0x1700228A RID: 8842
		// (get) Token: 0x06006BCB RID: 27595 RVA: 0x001A2480 File Offset: 0x001A0680
		[DebuggerNonUserCode]
		public RepeatedField<TagIdentifier> Tag
		{
			get
			{
				return this.tag_;
			}
		}

		// Token: 0x1700228B RID: 8843
		// (get) Token: 0x06006BCC RID: 27596 RVA: 0x001A2498 File Offset: 0x001A0698
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> SearchAttribute
		{
			get
			{
				return this.searchAttribute_;
			}
		}

		// Token: 0x1700228C RID: 8844
		// (get) Token: 0x06006BCD RID: 27597 RVA: 0x001A24B0 File Offset: 0x001A06B0
		// (set) Token: 0x06006BCE RID: 27598 RVA: 0x001A24E1 File Offset: 0x001A06E1
		[DebuggerNonUserCode]
		public bool TagCleared
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool tagClearedDefaultValue;
				if (flag)
				{
					tagClearedDefaultValue = this.tagCleared_;
				}
				else
				{
					tagClearedDefaultValue = ClubStateAssignment.TagClearedDefaultValue;
				}
				return tagClearedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.tagCleared_ = value;
			}
		}

		// Token: 0x1700228D RID: 8845
		// (get) Token: 0x06006BCF RID: 27599 RVA: 0x001A24FC File Offset: 0x001A06FC
		[DebuggerNonUserCode]
		public bool HasTagCleared
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06006BD0 RID: 27600 RVA: 0x001A2519 File Offset: 0x001A0719
		[DebuggerNonUserCode]
		public void ClearTagCleared()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06006BD1 RID: 27601 RVA: 0x001A252C File Offset: 0x001A072C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubStateAssignment);
		}

		// Token: 0x06006BD2 RID: 27602 RVA: 0x001A254C File Offset: 0x001A074C
		[DebuggerNonUserCode]
		public bool Equals(ClubStateAssignment other)
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
					bool flag4 = this.ClubId != other.ClubId;
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
									bool flag8 = !object.Equals(this.Broadcast, other.Broadcast);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !object.Equals(this.Avatar, other.Avatar);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.PrivacyLevel != other.PrivacyLevel;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !object.Equals(this.StreamPosition, other.StreamPosition);
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.ShortName != other.ShortName;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.VisibilityLevel != other.VisibilityLevel;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.Locale != other.Locale;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.Timezone != other.Timezone;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = !this.tag_.Equals(other.tag_);
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = !this.searchAttribute_.Equals(other.searchAttribute_);
																		if (flag17)
																		{
																			flag2 = false;
																		}
																		else
																		{
																			bool flag18 = this.TagCleared != other.TagCleared;
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

		// Token: 0x06006BD3 RID: 27603 RVA: 0x001A2758 File Offset: 0x001A0958
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num ^= this.ClubId.GetHashCode();
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
			bool flag = this.broadcast_ != null;
			if (flag)
			{
				num ^= this.Broadcast.GetHashCode();
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
			bool flag3 = this.streamPosition_ != null;
			if (flag3)
			{
				num ^= this.StreamPosition.GetHashCode();
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
			num ^= this.tag_.GetHashCode();
			num ^= this.searchAttribute_.GetHashCode();
			bool hasTagCleared = this.HasTagCleared;
			if (hasTagCleared)
			{
				num ^= this.TagCleared.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006BD4 RID: 27604 RVA: 0x001A2910 File Offset: 0x001A0B10
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006BD5 RID: 27605 RVA: 0x001A2928 File Offset: 0x001A0B28
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006BD6 RID: 27606 RVA: 0x001A2934 File Offset: 0x001A0B34
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.ClubId);
			}
			this.attribute_.WriteTo(ref output, ClubStateAssignment._repeated_attribute_codec);
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
			bool flag = this.broadcast_ != null;
			if (flag)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Broadcast);
			}
			bool flag2 = this.avatar_ != null;
			if (flag2)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Avatar);
			}
			bool hasPrivacyLevel = this.HasPrivacyLevel;
			if (hasPrivacyLevel)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.PrivacyLevel);
			}
			bool flag3 = this.streamPosition_ != null;
			if (flag3)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.StreamPosition);
			}
			bool hasShortName = this.HasShortName;
			if (hasShortName)
			{
				output.WriteRawTag(74);
				output.WriteString(this.ShortName);
			}
			bool hasVisibilityLevel = this.HasVisibilityLevel;
			if (hasVisibilityLevel)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.VisibilityLevel);
			}
			bool hasLocale = this.HasLocale;
			if (hasLocale)
			{
				output.WriteRawTag(90);
				output.WriteString(this.Locale);
			}
			bool hasTimezone = this.HasTimezone;
			if (hasTimezone)
			{
				output.WriteRawTag(98);
				output.WriteString(this.Timezone);
			}
			this.tag_.WriteTo(ref output, ClubStateAssignment._repeated_tag_codec);
			this.searchAttribute_.WriteTo(ref output, ClubStateAssignment._repeated_searchAttribute_codec);
			bool hasTagCleared = this.HasTagCleared;
			if (hasTagCleared)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.TagCleared);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006BD7 RID: 27607 RVA: 0x001A2B48 File Offset: 0x001A0D48
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ClubId);
			}
			num += this.attribute_.CalculateSize(ClubStateAssignment._repeated_attribute_codec);
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
			bool flag = this.broadcast_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Broadcast);
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
			bool flag3 = this.streamPosition_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StreamPosition);
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
			num += this.tag_.CalculateSize(ClubStateAssignment._repeated_tag_codec);
			num += this.searchAttribute_.CalculateSize(ClubStateAssignment._repeated_searchAttribute_codec);
			bool hasTagCleared = this.HasTagCleared;
			if (hasTagCleared)
			{
				num += 2;
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006BD8 RID: 27608 RVA: 0x001A2D18 File Offset: 0x001A0F18
		[DebuggerNonUserCode]
		public void MergeFrom(ClubStateAssignment other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClubId = other.HasClubId;
				if (hasClubId)
				{
					this.ClubId = other.ClubId;
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
				bool flag2 = other.broadcast_ != null;
				if (flag2)
				{
					bool flag3 = this.broadcast_ == null;
					if (flag3)
					{
						this.Broadcast = new Broadcast();
					}
					this.Broadcast.MergeFrom(other.Broadcast);
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
				bool flag6 = other.streamPosition_ != null;
				if (flag6)
				{
					bool flag7 = this.streamPosition_ == null;
					if (flag7)
					{
						this.StreamPosition = new StreamPosition();
					}
					this.StreamPosition.MergeFrom(other.StreamPosition);
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
				this.tag_.Add(other.tag_);
				this.searchAttribute_.Add(other.searchAttribute_);
				bool hasTagCleared = other.HasTagCleared;
				if (hasTagCleared)
				{
					this.TagCleared = other.TagCleared;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006BD9 RID: 27609 RVA: 0x001A2F2E File Offset: 0x001A112E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006BDA RID: 27610 RVA: 0x001A2F3C File Offset: 0x001A113C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 56U)
				{
					if (num3 <= 26U)
					{
						if (num3 != 8U)
						{
							if (num3 != 18U)
							{
								if (num3 != 26U)
								{
									goto IL_00C1;
								}
								this.Name = input.ReadString();
							}
							else
							{
								this.attribute_.AddEntriesFrom(ref input, ClubStateAssignment._repeated_attribute_codec);
							}
						}
						else
						{
							this.ClubId = input.ReadUInt64();
						}
					}
					else if (num3 <= 42U)
					{
						if (num3 != 34U)
						{
							if (num3 != 42U)
							{
								goto IL_00C1;
							}
							bool flag = this.broadcast_ == null;
							if (flag)
							{
								this.Broadcast = new Broadcast();
							}
							input.ReadMessage(this.Broadcast);
						}
						else
						{
							this.Description = input.ReadString();
						}
					}
					else if (num3 != 50U)
					{
						if (num3 != 56U)
						{
							goto IL_00C1;
						}
						this.PrivacyLevel = (PrivacyLevel)input.ReadEnum();
					}
					else
					{
						bool flag2 = this.avatar_ == null;
						if (flag2)
						{
							this.Avatar = new AvatarId();
						}
						input.ReadMessage(this.Avatar);
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
								goto IL_00C1;
							}
							this.ShortName = input.ReadString();
						}
						else
						{
							bool flag3 = this.streamPosition_ == null;
							if (flag3)
							{
								this.StreamPosition = new StreamPosition();
							}
							input.ReadMessage(this.StreamPosition);
						}
					}
					else if (num3 != 80U)
					{
						if (num3 != 90U)
						{
							goto IL_00C1;
						}
						this.Locale = input.ReadString();
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
							goto IL_00C1;
						}
						this.tag_.AddEntriesFrom(ref input, ClubStateAssignment._repeated_tag_codec);
					}
					else
					{
						this.Timezone = input.ReadString();
					}
				}
				else if (num3 != 114U)
				{
					if (num3 != 120U)
					{
						goto IL_00C1;
					}
					this.TagCleared = input.ReadBool();
				}
				else
				{
					this.searchAttribute_.AddEntriesFrom(ref input, ClubStateAssignment._repeated_searchAttribute_codec);
				}
				continue;
				IL_00C1:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003137 RID: 12599
		private static readonly MessageParser<ClubStateAssignment> _parser = new MessageParser<ClubStateAssignment>(() => new ClubStateAssignment());

		// Token: 0x04003138 RID: 12600
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003139 RID: 12601
		private int _hasBits0;

		// Token: 0x0400313A RID: 12602
		public const int ClubIdFieldNumber = 1;

		// Token: 0x0400313B RID: 12603
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x0400313C RID: 12604
		private ulong clubId_;

		// Token: 0x0400313D RID: 12605
		public const int AttributeFieldNumber = 2;

		// Token: 0x0400313E RID: 12606
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(18U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x0400313F RID: 12607
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		// Token: 0x04003140 RID: 12608
		public const int NameFieldNumber = 3;

		// Token: 0x04003141 RID: 12609
		private static readonly string NameDefaultValue = "";

		// Token: 0x04003142 RID: 12610
		private string name_;

		// Token: 0x04003143 RID: 12611
		public const int DescriptionFieldNumber = 4;

		// Token: 0x04003144 RID: 12612
		private static readonly string DescriptionDefaultValue = "";

		// Token: 0x04003145 RID: 12613
		private string description_;

		// Token: 0x04003146 RID: 12614
		public const int BroadcastFieldNumber = 5;

		// Token: 0x04003147 RID: 12615
		private Broadcast broadcast_;

		// Token: 0x04003148 RID: 12616
		public const int AvatarFieldNumber = 6;

		// Token: 0x04003149 RID: 12617
		private AvatarId avatar_;

		// Token: 0x0400314A RID: 12618
		public const int PrivacyLevelFieldNumber = 7;

		// Token: 0x0400314B RID: 12619
		private static readonly PrivacyLevel PrivacyLevelDefaultValue = PrivacyLevel.Closed;

		// Token: 0x0400314C RID: 12620
		private PrivacyLevel privacyLevel_;

		// Token: 0x0400314D RID: 12621
		public const int StreamPositionFieldNumber = 8;

		// Token: 0x0400314E RID: 12622
		private StreamPosition streamPosition_;

		// Token: 0x0400314F RID: 12623
		public const int ShortNameFieldNumber = 9;

		// Token: 0x04003150 RID: 12624
		private static readonly string ShortNameDefaultValue = "";

		// Token: 0x04003151 RID: 12625
		private string shortName_;

		// Token: 0x04003152 RID: 12626
		public const int VisibilityLevelFieldNumber = 10;

		// Token: 0x04003153 RID: 12627
		private static readonly VisibilityLevel VisibilityLevelDefaultValue = VisibilityLevel.Private;

		// Token: 0x04003154 RID: 12628
		private VisibilityLevel visibilityLevel_;

		// Token: 0x04003155 RID: 12629
		public const int LocaleFieldNumber = 11;

		// Token: 0x04003156 RID: 12630
		private static readonly string LocaleDefaultValue = "";

		// Token: 0x04003157 RID: 12631
		private string locale_;

		// Token: 0x04003158 RID: 12632
		public const int TimezoneFieldNumber = 12;

		// Token: 0x04003159 RID: 12633
		private static readonly string TimezoneDefaultValue = "";

		// Token: 0x0400315A RID: 12634
		private string timezone_;

		// Token: 0x0400315B RID: 12635
		public const int TagFieldNumber = 13;

		// Token: 0x0400315C RID: 12636
		private static readonly FieldCodec<TagIdentifier> _repeated_tag_codec = FieldCodec.ForMessage<TagIdentifier>(106U, TagIdentifier.Parser);

		// Token: 0x0400315D RID: 12637
		private readonly RepeatedField<TagIdentifier> tag_ = new RepeatedField<TagIdentifier>();

		// Token: 0x0400315E RID: 12638
		public const int SearchAttributeFieldNumber = 14;

		// Token: 0x0400315F RID: 12639
		private static readonly FieldCodec<Attribute> _repeated_searchAttribute_codec = FieldCodec.ForMessage<Attribute>(114U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x04003160 RID: 12640
		private readonly RepeatedField<Attribute> searchAttribute_ = new RepeatedField<Attribute>();

		// Token: 0x04003161 RID: 12641
		public const int TagClearedFieldNumber = 15;

		// Token: 0x04003162 RID: 12642
		private static readonly bool TagClearedDefaultValue = false;

		// Token: 0x04003163 RID: 12643
		private bool tagCleared_;
	}
}
