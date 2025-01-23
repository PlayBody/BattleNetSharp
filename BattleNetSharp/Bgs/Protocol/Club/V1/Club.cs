using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000440 RID: 1088
	public sealed class Club : IMessage<Club>, IMessage, IEquatable<Club>, IDeepCloneable<Club>, IBufferMessage
	{
		// Token: 0x1700221D RID: 8733
		// (get) Token: 0x06006ACE RID: 27342 RVA: 0x0019DF5C File Offset: 0x0019C15C
		[DebuggerNonUserCode]
		public static MessageParser<Club> Parser
		{
			get
			{
				return Club._parser;
			}
		}

		// Token: 0x1700221E RID: 8734
		// (get) Token: 0x06006ACF RID: 27343 RVA: 0x0019DF74 File Offset: 0x0019C174
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubCoreReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x1700221F RID: 8735
		// (get) Token: 0x06006AD0 RID: 27344 RVA: 0x0019DF98 File Offset: 0x0019C198
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Club.Descriptor;
			}
		}

		// Token: 0x06006AD1 RID: 27345 RVA: 0x0019DFAF File Offset: 0x0019C1AF
		[DebuggerNonUserCode]
		public Club()
		{
		}

		// Token: 0x06006AD2 RID: 27346 RVA: 0x0019DFE8 File Offset: 0x0019C1E8
		[DebuggerNonUserCode]
		public Club(Club other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.type_ = ((other.type_ != null) ? other.type_.Clone() : null);
			this.attribute_ = other.attribute_.Clone();
			this.name_ = other.name_;
			this.description_ = other.description_;
			this.broadcast_ = ((other.broadcast_ != null) ? other.broadcast_.Clone() : null);
			this.avatar_ = ((other.avatar_ != null) ? other.avatar_.Clone() : null);
			this.privacyLevel_ = other.privacyLevel_;
			this.visibilityLevel_ = other.visibilityLevel_;
			this.memberCount_ = other.memberCount_;
			this.creationTime_ = other.creationTime_;
			this.streamPosition_ = ((other.streamPosition_ != null) ? other.streamPosition_.Clone() : null);
			this.roleSet_ = ((other.roleSet_ != null) ? other.roleSet_.Clone() : null);
			this.leader_ = other.leader_.Clone();
			this.shortName_ = other.shortName_;
			this.searchAttribute_ = other.searchAttribute_.Clone();
			this.tag_ = other.tag_.Clone();
			this.locale_ = other.locale_;
			this.timezone_ = other.timezone_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006AD3 RID: 27347 RVA: 0x0019E164 File Offset: 0x0019C364
		[DebuggerNonUserCode]
		public Club Clone()
		{
			return new Club(this);
		}

		// Token: 0x17002220 RID: 8736
		// (get) Token: 0x06006AD4 RID: 27348 RVA: 0x0019E17C File Offset: 0x0019C37C
		// (set) Token: 0x06006AD5 RID: 27349 RVA: 0x0019E1AD File Offset: 0x0019C3AD
		[DebuggerNonUserCode]
		public ulong Id
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = Club.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x17002221 RID: 8737
		// (get) Token: 0x06006AD6 RID: 27350 RVA: 0x0019E1C8 File Offset: 0x0019C3C8
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006AD7 RID: 27351 RVA: 0x0019E1E5 File Offset: 0x0019C3E5
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002222 RID: 8738
		// (get) Token: 0x06006AD8 RID: 27352 RVA: 0x0019E1F8 File Offset: 0x0019C3F8
		// (set) Token: 0x06006AD9 RID: 27353 RVA: 0x0019E210 File Offset: 0x0019C410
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

		// Token: 0x17002223 RID: 8739
		// (get) Token: 0x06006ADA RID: 27354 RVA: 0x0019E21C File Offset: 0x0019C41C
		[DebuggerNonUserCode]
		public RepeatedField<Bgs.Protocol.V2.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x17002224 RID: 8740
		// (get) Token: 0x06006ADB RID: 27355 RVA: 0x0019E234 File Offset: 0x0019C434
		// (set) Token: 0x06006ADC RID: 27356 RVA: 0x0019E255 File Offset: 0x0019C455
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? Club.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002225 RID: 8741
		// (get) Token: 0x06006ADD RID: 27357 RVA: 0x0019E26C File Offset: 0x0019C46C
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06006ADE RID: 27358 RVA: 0x0019E287 File Offset: 0x0019C487
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x17002226 RID: 8742
		// (get) Token: 0x06006ADF RID: 27359 RVA: 0x0019E294 File Offset: 0x0019C494
		// (set) Token: 0x06006AE0 RID: 27360 RVA: 0x0019E2B5 File Offset: 0x0019C4B5
		[DebuggerNonUserCode]
		public string Description
		{
			get
			{
				return this.description_ ?? Club.DescriptionDefaultValue;
			}
			set
			{
				this.description_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002227 RID: 8743
		// (get) Token: 0x06006AE1 RID: 27361 RVA: 0x0019E2CC File Offset: 0x0019C4CC
		[DebuggerNonUserCode]
		public bool HasDescription
		{
			get
			{
				return this.description_ != null;
			}
		}

		// Token: 0x06006AE2 RID: 27362 RVA: 0x0019E2E7 File Offset: 0x0019C4E7
		[DebuggerNonUserCode]
		public void ClearDescription()
		{
			this.description_ = null;
		}

		// Token: 0x17002228 RID: 8744
		// (get) Token: 0x06006AE3 RID: 27363 RVA: 0x0019E2F4 File Offset: 0x0019C4F4
		// (set) Token: 0x06006AE4 RID: 27364 RVA: 0x0019E30C File Offset: 0x0019C50C
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

		// Token: 0x17002229 RID: 8745
		// (get) Token: 0x06006AE5 RID: 27365 RVA: 0x0019E318 File Offset: 0x0019C518
		// (set) Token: 0x06006AE6 RID: 27366 RVA: 0x0019E330 File Offset: 0x0019C530
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

		// Token: 0x1700222A RID: 8746
		// (get) Token: 0x06006AE7 RID: 27367 RVA: 0x0019E33C File Offset: 0x0019C53C
		// (set) Token: 0x06006AE8 RID: 27368 RVA: 0x0019E36D File Offset: 0x0019C56D
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
					privacyLevelDefaultValue = Club.PrivacyLevelDefaultValue;
				}
				return privacyLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.privacyLevel_ = value;
			}
		}

		// Token: 0x1700222B RID: 8747
		// (get) Token: 0x06006AE9 RID: 27369 RVA: 0x0019E388 File Offset: 0x0019C588
		[DebuggerNonUserCode]
		public bool HasPrivacyLevel
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06006AEA RID: 27370 RVA: 0x0019E3A5 File Offset: 0x0019C5A5
		[DebuggerNonUserCode]
		public void ClearPrivacyLevel()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700222C RID: 8748
		// (get) Token: 0x06006AEB RID: 27371 RVA: 0x0019E3B8 File Offset: 0x0019C5B8
		// (set) Token: 0x06006AEC RID: 27372 RVA: 0x0019E3E9 File Offset: 0x0019C5E9
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
					visibilityLevelDefaultValue = Club.VisibilityLevelDefaultValue;
				}
				return visibilityLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.visibilityLevel_ = value;
			}
		}

		// Token: 0x1700222D RID: 8749
		// (get) Token: 0x06006AED RID: 27373 RVA: 0x0019E404 File Offset: 0x0019C604
		[DebuggerNonUserCode]
		public bool HasVisibilityLevel
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06006AEE RID: 27374 RVA: 0x0019E421 File Offset: 0x0019C621
		[DebuggerNonUserCode]
		public void ClearVisibilityLevel()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x1700222E RID: 8750
		// (get) Token: 0x06006AEF RID: 27375 RVA: 0x0019E434 File Offset: 0x0019C634
		// (set) Token: 0x06006AF0 RID: 27376 RVA: 0x0019E465 File Offset: 0x0019C665
		[DebuggerNonUserCode]
		public uint MemberCount
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint memberCountDefaultValue;
				if (flag)
				{
					memberCountDefaultValue = this.memberCount_;
				}
				else
				{
					memberCountDefaultValue = Club.MemberCountDefaultValue;
				}
				return memberCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.memberCount_ = value;
			}
		}

		// Token: 0x1700222F RID: 8751
		// (get) Token: 0x06006AF1 RID: 27377 RVA: 0x0019E480 File Offset: 0x0019C680
		[DebuggerNonUserCode]
		public bool HasMemberCount
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06006AF2 RID: 27378 RVA: 0x0019E49D File Offset: 0x0019C69D
		[DebuggerNonUserCode]
		public void ClearMemberCount()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17002230 RID: 8752
		// (get) Token: 0x06006AF3 RID: 27379 RVA: 0x0019E4B0 File Offset: 0x0019C6B0
		// (set) Token: 0x06006AF4 RID: 27380 RVA: 0x0019E4E2 File Offset: 0x0019C6E2
		[DebuggerNonUserCode]
		public ulong CreationTime
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				ulong creationTimeDefaultValue;
				if (flag)
				{
					creationTimeDefaultValue = this.creationTime_;
				}
				else
				{
					creationTimeDefaultValue = Club.CreationTimeDefaultValue;
				}
				return creationTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.creationTime_ = value;
			}
		}

		// Token: 0x17002231 RID: 8753
		// (get) Token: 0x06006AF5 RID: 27381 RVA: 0x0019E4FC File Offset: 0x0019C6FC
		[DebuggerNonUserCode]
		public bool HasCreationTime
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06006AF6 RID: 27382 RVA: 0x0019E51A File Offset: 0x0019C71A
		[DebuggerNonUserCode]
		public void ClearCreationTime()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17002232 RID: 8754
		// (get) Token: 0x06006AF7 RID: 27383 RVA: 0x0019E52C File Offset: 0x0019C72C
		// (set) Token: 0x06006AF8 RID: 27384 RVA: 0x0019E544 File Offset: 0x0019C744
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

		// Token: 0x17002233 RID: 8755
		// (get) Token: 0x06006AF9 RID: 27385 RVA: 0x0019E550 File Offset: 0x0019C750
		// (set) Token: 0x06006AFA RID: 27386 RVA: 0x0019E568 File Offset: 0x0019C768
		[DebuggerNonUserCode]
		public ClubRoleSet RoleSet
		{
			get
			{
				return this.roleSet_;
			}
			set
			{
				this.roleSet_ = value;
			}
		}

		// Token: 0x17002234 RID: 8756
		// (get) Token: 0x06006AFB RID: 27387 RVA: 0x0019E574 File Offset: 0x0019C774
		[DebuggerNonUserCode]
		public RepeatedField<MemberDescription> Leader
		{
			get
			{
				return this.leader_;
			}
		}

		// Token: 0x17002235 RID: 8757
		// (get) Token: 0x06006AFC RID: 27388 RVA: 0x0019E58C File Offset: 0x0019C78C
		// (set) Token: 0x06006AFD RID: 27389 RVA: 0x0019E5AD File Offset: 0x0019C7AD
		[DebuggerNonUserCode]
		public string ShortName
		{
			get
			{
				return this.shortName_ ?? Club.ShortNameDefaultValue;
			}
			set
			{
				this.shortName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002236 RID: 8758
		// (get) Token: 0x06006AFE RID: 27390 RVA: 0x0019E5C4 File Offset: 0x0019C7C4
		[DebuggerNonUserCode]
		public bool HasShortName
		{
			get
			{
				return this.shortName_ != null;
			}
		}

		// Token: 0x06006AFF RID: 27391 RVA: 0x0019E5DF File Offset: 0x0019C7DF
		[DebuggerNonUserCode]
		public void ClearShortName()
		{
			this.shortName_ = null;
		}

		// Token: 0x17002237 RID: 8759
		// (get) Token: 0x06006B00 RID: 27392 RVA: 0x0019E5EC File Offset: 0x0019C7EC
		[DebuggerNonUserCode]
		public RepeatedField<Bgs.Protocol.V2.Attribute> SearchAttribute
		{
			get
			{
				return this.searchAttribute_;
			}
		}

		// Token: 0x17002238 RID: 8760
		// (get) Token: 0x06006B01 RID: 27393 RVA: 0x0019E604 File Offset: 0x0019C804
		[DebuggerNonUserCode]
		public RepeatedField<TagIdentifier> Tag
		{
			get
			{
				return this.tag_;
			}
		}

		// Token: 0x17002239 RID: 8761
		// (get) Token: 0x06006B02 RID: 27394 RVA: 0x0019E61C File Offset: 0x0019C81C
		// (set) Token: 0x06006B03 RID: 27395 RVA: 0x0019E63D File Offset: 0x0019C83D
		[DebuggerNonUserCode]
		public string Locale
		{
			get
			{
				return this.locale_ ?? Club.LocaleDefaultValue;
			}
			set
			{
				this.locale_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700223A RID: 8762
		// (get) Token: 0x06006B04 RID: 27396 RVA: 0x0019E654 File Offset: 0x0019C854
		[DebuggerNonUserCode]
		public bool HasLocale
		{
			get
			{
				return this.locale_ != null;
			}
		}

		// Token: 0x06006B05 RID: 27397 RVA: 0x0019E66F File Offset: 0x0019C86F
		[DebuggerNonUserCode]
		public void ClearLocale()
		{
			this.locale_ = null;
		}

		// Token: 0x1700223B RID: 8763
		// (get) Token: 0x06006B06 RID: 27398 RVA: 0x0019E67C File Offset: 0x0019C87C
		// (set) Token: 0x06006B07 RID: 27399 RVA: 0x0019E69D File Offset: 0x0019C89D
		[DebuggerNonUserCode]
		public string Timezone
		{
			get
			{
				return this.timezone_ ?? Club.TimezoneDefaultValue;
			}
			set
			{
				this.timezone_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700223C RID: 8764
		// (get) Token: 0x06006B08 RID: 27400 RVA: 0x0019E6B4 File Offset: 0x0019C8B4
		[DebuggerNonUserCode]
		public bool HasTimezone
		{
			get
			{
				return this.timezone_ != null;
			}
		}

		// Token: 0x06006B09 RID: 27401 RVA: 0x0019E6CF File Offset: 0x0019C8CF
		[DebuggerNonUserCode]
		public void ClearTimezone()
		{
			this.timezone_ = null;
		}

		// Token: 0x06006B0A RID: 27402 RVA: 0x0019E6DC File Offset: 0x0019C8DC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Club);
		}

		// Token: 0x06006B0B RID: 27403 RVA: 0x0019E6FC File Offset: 0x0019C8FC
		[DebuggerNonUserCode]
		public bool Equals(Club other)
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
					bool flag4 = this.Id != other.Id;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Type, other.Type);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.attribute_.Equals(other.attribute_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Name != other.Name;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Description != other.Description;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !object.Equals(this.Broadcast, other.Broadcast);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !object.Equals(this.Avatar, other.Avatar);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.PrivacyLevel != other.PrivacyLevel;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.VisibilityLevel != other.VisibilityLevel;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.MemberCount != other.MemberCount;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.CreationTime != other.CreationTime;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = !object.Equals(this.StreamPosition, other.StreamPosition);
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = !object.Equals(this.RoleSet, other.RoleSet);
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = !this.leader_.Equals(other.leader_);
																		if (flag17)
																		{
																			flag2 = false;
																		}
																		else
																		{
																			bool flag18 = this.ShortName != other.ShortName;
																			if (flag18)
																			{
																				flag2 = false;
																			}
																			else
																			{
																				bool flag19 = !this.searchAttribute_.Equals(other.searchAttribute_);
																				if (flag19)
																				{
																					flag2 = false;
																				}
																				else
																				{
																					bool flag20 = !this.tag_.Equals(other.tag_);
																					if (flag20)
																					{
																						flag2 = false;
																					}
																					else
																					{
																						bool flag21 = this.Locale != other.Locale;
																						if (flag21)
																						{
																							flag2 = false;
																						}
																						else
																						{
																							bool flag22 = this.Timezone != other.Timezone;
																							flag2 = !flag22 && object.Equals(this._unknownFields, other._unknownFields);
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
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006B0C RID: 27404 RVA: 0x0019E988 File Offset: 0x0019CB88
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
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
			bool flag2 = this.broadcast_ != null;
			if (flag2)
			{
				num ^= this.Broadcast.GetHashCode();
			}
			bool flag3 = this.avatar_ != null;
			if (flag3)
			{
				num ^= this.Avatar.GetHashCode();
			}
			bool hasPrivacyLevel = this.HasPrivacyLevel;
			if (hasPrivacyLevel)
			{
				num ^= this.PrivacyLevel.GetHashCode();
			}
			bool hasVisibilityLevel = this.HasVisibilityLevel;
			if (hasVisibilityLevel)
			{
				num ^= this.VisibilityLevel.GetHashCode();
			}
			bool hasMemberCount = this.HasMemberCount;
			if (hasMemberCount)
			{
				num ^= this.MemberCount.GetHashCode();
			}
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				num ^= this.CreationTime.GetHashCode();
			}
			bool flag4 = this.streamPosition_ != null;
			if (flag4)
			{
				num ^= this.StreamPosition.GetHashCode();
			}
			bool flag5 = this.roleSet_ != null;
			if (flag5)
			{
				num ^= this.RoleSet.GetHashCode();
			}
			num ^= this.leader_.GetHashCode();
			bool hasShortName = this.HasShortName;
			if (hasShortName)
			{
				num ^= this.ShortName.GetHashCode();
			}
			num ^= this.searchAttribute_.GetHashCode();
			num ^= this.tag_.GetHashCode();
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

		// Token: 0x06006B0D RID: 27405 RVA: 0x0019EBA8 File Offset: 0x0019CDA8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006B0E RID: 27406 RVA: 0x0019EBC0 File Offset: 0x0019CDC0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006B0F RID: 27407 RVA: 0x0019EBCC File Offset: 0x0019CDCC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.Id);
			}
			bool flag = this.type_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Type);
			}
			this.attribute_.WriteTo(ref output, Club._repeated_attribute_codec);
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Name);
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				output.WriteRawTag(42);
				output.WriteString(this.Description);
			}
			bool flag2 = this.broadcast_ != null;
			if (flag2)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Broadcast);
			}
			bool flag3 = this.avatar_ != null;
			if (flag3)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Avatar);
			}
			bool hasPrivacyLevel = this.HasPrivacyLevel;
			if (hasPrivacyLevel)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.PrivacyLevel);
			}
			bool hasVisibilityLevel = this.HasVisibilityLevel;
			if (hasVisibilityLevel)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.VisibilityLevel);
			}
			bool hasMemberCount = this.HasMemberCount;
			if (hasMemberCount)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.MemberCount);
			}
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				output.WriteRawTag(88);
				output.WriteUInt64(this.CreationTime);
			}
			bool flag4 = this.streamPosition_ != null;
			if (flag4)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.StreamPosition);
			}
			bool flag5 = this.roleSet_ != null;
			if (flag5)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.RoleSet);
			}
			this.leader_.WriteTo(ref output, Club._repeated_leader_codec);
			bool hasShortName = this.HasShortName;
			if (hasShortName)
			{
				output.WriteRawTag(122);
				output.WriteString(this.ShortName);
			}
			this.searchAttribute_.WriteTo(ref output, Club._repeated_searchAttribute_codec);
			this.tag_.WriteTo(ref output, Club._repeated_tag_codec);
			bool hasLocale = this.HasLocale;
			if (hasLocale)
			{
				output.WriteRawTag(146, 1);
				output.WriteString(this.Locale);
			}
			bool hasTimezone = this.HasTimezone;
			if (hasTimezone)
			{
				output.WriteRawTag(154, 1);
				output.WriteString(this.Timezone);
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006B10 RID: 27408 RVA: 0x0019EE6C File Offset: 0x0019D06C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Id);
			}
			bool flag = this.type_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Type);
			}
			num += this.attribute_.CalculateSize(Club._repeated_attribute_codec);
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
			bool flag2 = this.broadcast_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Broadcast);
			}
			bool flag3 = this.avatar_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Avatar);
			}
			bool hasPrivacyLevel = this.HasPrivacyLevel;
			if (hasPrivacyLevel)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.PrivacyLevel);
			}
			bool hasVisibilityLevel = this.HasVisibilityLevel;
			if (hasVisibilityLevel)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.VisibilityLevel);
			}
			bool hasMemberCount = this.HasMemberCount;
			if (hasMemberCount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MemberCount);
			}
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreationTime);
			}
			bool flag4 = this.streamPosition_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StreamPosition);
			}
			bool flag5 = this.roleSet_ != null;
			if (flag5)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoleSet);
			}
			num += this.leader_.CalculateSize(Club._repeated_leader_codec);
			bool hasShortName = this.HasShortName;
			if (hasShortName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ShortName);
			}
			num += this.searchAttribute_.CalculateSize(Club._repeated_searchAttribute_codec);
			num += this.tag_.CalculateSize(Club._repeated_tag_codec);
			bool hasLocale = this.HasLocale;
			if (hasLocale)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.Locale);
			}
			bool hasTimezone = this.HasTimezone;
			if (hasTimezone)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.Timezone);
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006B11 RID: 27409 RVA: 0x0019F0BC File Offset: 0x0019D2BC
		[DebuggerNonUserCode]
		public void MergeFrom(Club other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
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
				bool flag4 = other.broadcast_ != null;
				if (flag4)
				{
					bool flag5 = this.broadcast_ == null;
					if (flag5)
					{
						this.Broadcast = new Broadcast();
					}
					this.Broadcast.MergeFrom(other.Broadcast);
				}
				bool flag6 = other.avatar_ != null;
				if (flag6)
				{
					bool flag7 = this.avatar_ == null;
					if (flag7)
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
				bool hasVisibilityLevel = other.HasVisibilityLevel;
				if (hasVisibilityLevel)
				{
					this.VisibilityLevel = other.VisibilityLevel;
				}
				bool hasMemberCount = other.HasMemberCount;
				if (hasMemberCount)
				{
					this.MemberCount = other.MemberCount;
				}
				bool hasCreationTime = other.HasCreationTime;
				if (hasCreationTime)
				{
					this.CreationTime = other.CreationTime;
				}
				bool flag8 = other.streamPosition_ != null;
				if (flag8)
				{
					bool flag9 = this.streamPosition_ == null;
					if (flag9)
					{
						this.StreamPosition = new StreamPosition();
					}
					this.StreamPosition.MergeFrom(other.StreamPosition);
				}
				bool flag10 = other.roleSet_ != null;
				if (flag10)
				{
					bool flag11 = this.roleSet_ == null;
					if (flag11)
					{
						this.RoleSet = new ClubRoleSet();
					}
					this.RoleSet.MergeFrom(other.RoleSet);
				}
				this.leader_.Add(other.leader_);
				bool hasShortName = other.HasShortName;
				if (hasShortName)
				{
					this.ShortName = other.ShortName;
				}
				this.searchAttribute_.Add(other.searchAttribute_);
				this.tag_.Add(other.tag_);
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

		// Token: 0x06006B12 RID: 27410 RVA: 0x0019F37F File Offset: 0x0019D57F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006B13 RID: 27411 RVA: 0x0019F38C File Offset: 0x0019D58C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 72U)
				{
					if (num3 <= 34U)
					{
						if (num3 <= 18U)
						{
							if (num3 != 8U)
							{
								if (num3 != 18U)
								{
									goto IL_0106;
								}
								bool flag = this.type_ == null;
								if (flag)
								{
									this.Type = new UniqueClubType();
								}
								input.ReadMessage(this.Type);
							}
							else
							{
								this.Id = input.ReadUInt64();
							}
						}
						else if (num3 != 26U)
						{
							if (num3 != 34U)
							{
								goto IL_0106;
							}
							this.Name = input.ReadString();
						}
						else
						{
							this.attribute_.AddEntriesFrom(ref input, Club._repeated_attribute_codec);
						}
					}
					else if (num3 <= 50U)
					{
						if (num3 != 42U)
						{
							if (num3 != 50U)
							{
								goto IL_0106;
							}
							bool flag2 = this.broadcast_ == null;
							if (flag2)
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
					else if (num3 != 58U)
					{
						if (num3 != 64U)
						{
							if (num3 != 72U)
							{
								goto IL_0106;
							}
							this.VisibilityLevel = (VisibilityLevel)input.ReadEnum();
						}
						else
						{
							this.PrivacyLevel = (PrivacyLevel)input.ReadEnum();
						}
					}
					else
					{
						bool flag3 = this.avatar_ == null;
						if (flag3)
						{
							this.Avatar = new AvatarId();
						}
						input.ReadMessage(this.Avatar);
					}
				}
				else if (num3 <= 114U)
				{
					if (num3 <= 88U)
					{
						if (num3 != 80U)
						{
							if (num3 != 88U)
							{
								goto IL_0106;
							}
							this.CreationTime = input.ReadUInt64();
						}
						else
						{
							this.MemberCount = input.ReadUInt32();
						}
					}
					else if (num3 != 98U)
					{
						if (num3 != 106U)
						{
							if (num3 != 114U)
							{
								goto IL_0106;
							}
							this.leader_.AddEntriesFrom(ref input, Club._repeated_leader_codec);
						}
						else
						{
							bool flag4 = this.roleSet_ == null;
							if (flag4)
							{
								this.RoleSet = new ClubRoleSet();
							}
							input.ReadMessage(this.RoleSet);
						}
					}
					else
					{
						bool flag5 = this.streamPosition_ == null;
						if (flag5)
						{
							this.StreamPosition = new StreamPosition();
						}
						input.ReadMessage(this.StreamPosition);
					}
				}
				else if (num3 <= 130U)
				{
					if (num3 != 122U)
					{
						if (num3 != 130U)
						{
							goto IL_0106;
						}
						this.searchAttribute_.AddEntriesFrom(ref input, Club._repeated_searchAttribute_codec);
					}
					else
					{
						this.ShortName = input.ReadString();
					}
				}
				else if (num3 != 138U)
				{
					if (num3 != 146U)
					{
						if (num3 != 154U)
						{
							goto IL_0106;
						}
						this.Timezone = input.ReadString();
					}
					else
					{
						this.Locale = input.ReadString();
					}
				}
				else
				{
					this.tag_.AddEntriesFrom(ref input, Club._repeated_tag_codec);
				}
				continue;
				IL_0106:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040030AA RID: 12458
		private static readonly MessageParser<Club> _parser = new MessageParser<Club>(() => new Club());

		// Token: 0x040030AB RID: 12459
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030AC RID: 12460
		private int _hasBits0;

		// Token: 0x040030AD RID: 12461
		public const int IdFieldNumber = 1;

		// Token: 0x040030AE RID: 12462
		private static readonly ulong IdDefaultValue = 0UL;

		// Token: 0x040030AF RID: 12463
		private ulong id_;

		// Token: 0x040030B0 RID: 12464
		public const int TypeFieldNumber = 2;

		// Token: 0x040030B1 RID: 12465
		private UniqueClubType type_;

		// Token: 0x040030B2 RID: 12466
		public const int AttributeFieldNumber = 3;

		// Token: 0x040030B3 RID: 12467
		private static readonly FieldCodec<Bgs.Protocol.V2.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.V2.Attribute>(26U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x040030B4 RID: 12468
		private readonly RepeatedField<Bgs.Protocol.V2.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.V2.Attribute>();

		// Token: 0x040030B5 RID: 12469
		public const int NameFieldNumber = 4;

		// Token: 0x040030B6 RID: 12470
		private static readonly string NameDefaultValue = "";

		// Token: 0x040030B7 RID: 12471
		private string name_;

		// Token: 0x040030B8 RID: 12472
		public const int DescriptionFieldNumber = 5;

		// Token: 0x040030B9 RID: 12473
		private static readonly string DescriptionDefaultValue = "";

		// Token: 0x040030BA RID: 12474
		private string description_;

		// Token: 0x040030BB RID: 12475
		public const int BroadcastFieldNumber = 6;

		// Token: 0x040030BC RID: 12476
		private Broadcast broadcast_;

		// Token: 0x040030BD RID: 12477
		public const int AvatarFieldNumber = 7;

		// Token: 0x040030BE RID: 12478
		private AvatarId avatar_;

		// Token: 0x040030BF RID: 12479
		public const int PrivacyLevelFieldNumber = 8;

		// Token: 0x040030C0 RID: 12480
		private static readonly PrivacyLevel PrivacyLevelDefaultValue = PrivacyLevel.Closed;

		// Token: 0x040030C1 RID: 12481
		private PrivacyLevel privacyLevel_;

		// Token: 0x040030C2 RID: 12482
		public const int VisibilityLevelFieldNumber = 9;

		// Token: 0x040030C3 RID: 12483
		private static readonly VisibilityLevel VisibilityLevelDefaultValue = VisibilityLevel.Private;

		// Token: 0x040030C4 RID: 12484
		private VisibilityLevel visibilityLevel_;

		// Token: 0x040030C5 RID: 12485
		public const int MemberCountFieldNumber = 10;

		// Token: 0x040030C6 RID: 12486
		private static readonly uint MemberCountDefaultValue = 0U;

		// Token: 0x040030C7 RID: 12487
		private uint memberCount_;

		// Token: 0x040030C8 RID: 12488
		public const int CreationTimeFieldNumber = 11;

		// Token: 0x040030C9 RID: 12489
		private static readonly ulong CreationTimeDefaultValue = 0UL;

		// Token: 0x040030CA RID: 12490
		private ulong creationTime_;

		// Token: 0x040030CB RID: 12491
		public const int StreamPositionFieldNumber = 12;

		// Token: 0x040030CC RID: 12492
		private StreamPosition streamPosition_;

		// Token: 0x040030CD RID: 12493
		public const int RoleSetFieldNumber = 13;

		// Token: 0x040030CE RID: 12494
		private ClubRoleSet roleSet_;

		// Token: 0x040030CF RID: 12495
		public const int LeaderFieldNumber = 14;

		// Token: 0x040030D0 RID: 12496
		private static readonly FieldCodec<MemberDescription> _repeated_leader_codec = FieldCodec.ForMessage<MemberDescription>(114U, MemberDescription.Parser);

		// Token: 0x040030D1 RID: 12497
		private readonly RepeatedField<MemberDescription> leader_ = new RepeatedField<MemberDescription>();

		// Token: 0x040030D2 RID: 12498
		public const int ShortNameFieldNumber = 15;

		// Token: 0x040030D3 RID: 12499
		private static readonly string ShortNameDefaultValue = "";

		// Token: 0x040030D4 RID: 12500
		private string shortName_;

		// Token: 0x040030D5 RID: 12501
		public const int SearchAttributeFieldNumber = 16;

		// Token: 0x040030D6 RID: 12502
		private static readonly FieldCodec<Bgs.Protocol.V2.Attribute> _repeated_searchAttribute_codec = FieldCodec.ForMessage<Bgs.Protocol.V2.Attribute>(130U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x040030D7 RID: 12503
		private readonly RepeatedField<Bgs.Protocol.V2.Attribute> searchAttribute_ = new RepeatedField<Bgs.Protocol.V2.Attribute>();

		// Token: 0x040030D8 RID: 12504
		public const int TagFieldNumber = 17;

		// Token: 0x040030D9 RID: 12505
		private static readonly FieldCodec<TagIdentifier> _repeated_tag_codec = FieldCodec.ForMessage<TagIdentifier>(138U, TagIdentifier.Parser);

		// Token: 0x040030DA RID: 12506
		private readonly RepeatedField<TagIdentifier> tag_ = new RepeatedField<TagIdentifier>();

		// Token: 0x040030DB RID: 12507
		public const int LocaleFieldNumber = 18;

		// Token: 0x040030DC RID: 12508
		private static readonly string LocaleDefaultValue = "";

		// Token: 0x040030DD RID: 12509
		private string locale_;

		// Token: 0x040030DE RID: 12510
		public const int TimezoneFieldNumber = 19;

		// Token: 0x040030DF RID: 12511
		private static readonly string TimezoneDefaultValue = "";

		// Token: 0x040030E0 RID: 12512
		private string timezone_;
	}
}
