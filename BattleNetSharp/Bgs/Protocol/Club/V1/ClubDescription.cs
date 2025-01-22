using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000441 RID: 1089
	public sealed class ClubDescription : IMessage<ClubDescription>, IMessage, IEquatable<ClubDescription>, IDeepCloneable<ClubDescription>, IBufferMessage
	{
		// Token: 0x1700223D RID: 8765
		// (get) Token: 0x06006B15 RID: 27413 RVA: 0x0019F788 File Offset: 0x0019D988
		[DebuggerNonUserCode]
		public static MessageParser<ClubDescription> Parser
		{
			get
			{
				return ClubDescription._parser;
			}
		}

		// Token: 0x1700223E RID: 8766
		// (get) Token: 0x06006B16 RID: 27414 RVA: 0x0019F7A0 File Offset: 0x0019D9A0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubCoreReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x1700223F RID: 8767
		// (get) Token: 0x06006B17 RID: 27415 RVA: 0x0019F7C4 File Offset: 0x0019D9C4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubDescription.Descriptor;
			}
		}

		// Token: 0x06006B18 RID: 27416 RVA: 0x0019F7DB File Offset: 0x0019D9DB
		[DebuggerNonUserCode]
		public ClubDescription()
		{
		}

		// Token: 0x06006B19 RID: 27417 RVA: 0x0019F7FC File Offset: 0x0019D9FC
		[DebuggerNonUserCode]
		public ClubDescription(ClubDescription other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.type_ = ((other.type_ != null) ? other.type_.Clone() : null);
			this.name_ = other.name_;
			this.description_ = other.description_;
			this.avatar_ = ((other.avatar_ != null) ? other.avatar_.Clone() : null);
			this.privacyLevel_ = other.privacyLevel_;
			this.visibilityLevel_ = other.visibilityLevel_;
			this.memberCount_ = other.memberCount_;
			this.leader_ = other.leader_.Clone();
			this.creationTime_ = other.creationTime_;
			this.timezone_ = other.timezone_;
			this.locale_ = other.locale_;
			this.tag_ = other.tag_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006B1A RID: 27418 RVA: 0x0019F8F4 File Offset: 0x0019DAF4
		[DebuggerNonUserCode]
		public ClubDescription Clone()
		{
			return new ClubDescription(this);
		}

		// Token: 0x17002240 RID: 8768
		// (get) Token: 0x06006B1B RID: 27419 RVA: 0x0019F90C File Offset: 0x0019DB0C
		// (set) Token: 0x06006B1C RID: 27420 RVA: 0x0019F93D File Offset: 0x0019DB3D
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
					idDefaultValue = ClubDescription.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x17002241 RID: 8769
		// (get) Token: 0x06006B1D RID: 27421 RVA: 0x0019F958 File Offset: 0x0019DB58
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006B1E RID: 27422 RVA: 0x0019F975 File Offset: 0x0019DB75
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002242 RID: 8770
		// (get) Token: 0x06006B1F RID: 27423 RVA: 0x0019F988 File Offset: 0x0019DB88
		// (set) Token: 0x06006B20 RID: 27424 RVA: 0x0019F9A0 File Offset: 0x0019DBA0
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

		// Token: 0x17002243 RID: 8771
		// (get) Token: 0x06006B21 RID: 27425 RVA: 0x0019F9AC File Offset: 0x0019DBAC
		// (set) Token: 0x06006B22 RID: 27426 RVA: 0x0019F9CD File Offset: 0x0019DBCD
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? ClubDescription.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002244 RID: 8772
		// (get) Token: 0x06006B23 RID: 27427 RVA: 0x0019F9E4 File Offset: 0x0019DBE4
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06006B24 RID: 27428 RVA: 0x0019F9FF File Offset: 0x0019DBFF
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x17002245 RID: 8773
		// (get) Token: 0x06006B25 RID: 27429 RVA: 0x0019FA0C File Offset: 0x0019DC0C
		// (set) Token: 0x06006B26 RID: 27430 RVA: 0x0019FA2D File Offset: 0x0019DC2D
		[DebuggerNonUserCode]
		public string Description
		{
			get
			{
				return this.description_ ?? ClubDescription.DescriptionDefaultValue;
			}
			set
			{
				this.description_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002246 RID: 8774
		// (get) Token: 0x06006B27 RID: 27431 RVA: 0x0019FA44 File Offset: 0x0019DC44
		[DebuggerNonUserCode]
		public bool HasDescription
		{
			get
			{
				return this.description_ != null;
			}
		}

		// Token: 0x06006B28 RID: 27432 RVA: 0x0019FA5F File Offset: 0x0019DC5F
		[DebuggerNonUserCode]
		public void ClearDescription()
		{
			this.description_ = null;
		}

		// Token: 0x17002247 RID: 8775
		// (get) Token: 0x06006B29 RID: 27433 RVA: 0x0019FA6C File Offset: 0x0019DC6C
		// (set) Token: 0x06006B2A RID: 27434 RVA: 0x0019FA84 File Offset: 0x0019DC84
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

		// Token: 0x17002248 RID: 8776
		// (get) Token: 0x06006B2B RID: 27435 RVA: 0x0019FA90 File Offset: 0x0019DC90
		// (set) Token: 0x06006B2C RID: 27436 RVA: 0x0019FAC1 File Offset: 0x0019DCC1
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
					privacyLevelDefaultValue = ClubDescription.PrivacyLevelDefaultValue;
				}
				return privacyLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.privacyLevel_ = value;
			}
		}

		// Token: 0x17002249 RID: 8777
		// (get) Token: 0x06006B2D RID: 27437 RVA: 0x0019FADC File Offset: 0x0019DCDC
		[DebuggerNonUserCode]
		public bool HasPrivacyLevel
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06006B2E RID: 27438 RVA: 0x0019FAF9 File Offset: 0x0019DCF9
		[DebuggerNonUserCode]
		public void ClearPrivacyLevel()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700224A RID: 8778
		// (get) Token: 0x06006B2F RID: 27439 RVA: 0x0019FB0C File Offset: 0x0019DD0C
		// (set) Token: 0x06006B30 RID: 27440 RVA: 0x0019FB3D File Offset: 0x0019DD3D
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
					visibilityLevelDefaultValue = ClubDescription.VisibilityLevelDefaultValue;
				}
				return visibilityLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.visibilityLevel_ = value;
			}
		}

		// Token: 0x1700224B RID: 8779
		// (get) Token: 0x06006B31 RID: 27441 RVA: 0x0019FB58 File Offset: 0x0019DD58
		[DebuggerNonUserCode]
		public bool HasVisibilityLevel
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06006B32 RID: 27442 RVA: 0x0019FB75 File Offset: 0x0019DD75
		[DebuggerNonUserCode]
		public void ClearVisibilityLevel()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x1700224C RID: 8780
		// (get) Token: 0x06006B33 RID: 27443 RVA: 0x0019FB88 File Offset: 0x0019DD88
		// (set) Token: 0x06006B34 RID: 27444 RVA: 0x0019FBB9 File Offset: 0x0019DDB9
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
					memberCountDefaultValue = ClubDescription.MemberCountDefaultValue;
				}
				return memberCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.memberCount_ = value;
			}
		}

		// Token: 0x1700224D RID: 8781
		// (get) Token: 0x06006B35 RID: 27445 RVA: 0x0019FBD4 File Offset: 0x0019DDD4
		[DebuggerNonUserCode]
		public bool HasMemberCount
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06006B36 RID: 27446 RVA: 0x0019FBF1 File Offset: 0x0019DDF1
		[DebuggerNonUserCode]
		public void ClearMemberCount()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x1700224E RID: 8782
		// (get) Token: 0x06006B37 RID: 27447 RVA: 0x0019FC04 File Offset: 0x0019DE04
		[DebuggerNonUserCode]
		public RepeatedField<MemberDescription> Leader
		{
			get
			{
				return this.leader_;
			}
		}

		// Token: 0x1700224F RID: 8783
		// (get) Token: 0x06006B38 RID: 27448 RVA: 0x0019FC1C File Offset: 0x0019DE1C
		// (set) Token: 0x06006B39 RID: 27449 RVA: 0x0019FC4E File Offset: 0x0019DE4E
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
					creationTimeDefaultValue = ClubDescription.CreationTimeDefaultValue;
				}
				return creationTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.creationTime_ = value;
			}
		}

		// Token: 0x17002250 RID: 8784
		// (get) Token: 0x06006B3A RID: 27450 RVA: 0x0019FC68 File Offset: 0x0019DE68
		[DebuggerNonUserCode]
		public bool HasCreationTime
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06006B3B RID: 27451 RVA: 0x0019FC86 File Offset: 0x0019DE86
		[DebuggerNonUserCode]
		public void ClearCreationTime()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17002251 RID: 8785
		// (get) Token: 0x06006B3C RID: 27452 RVA: 0x0019FC98 File Offset: 0x0019DE98
		// (set) Token: 0x06006B3D RID: 27453 RVA: 0x0019FCB9 File Offset: 0x0019DEB9
		[DebuggerNonUserCode]
		public string Timezone
		{
			get
			{
				return this.timezone_ ?? ClubDescription.TimezoneDefaultValue;
			}
			set
			{
				this.timezone_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002252 RID: 8786
		// (get) Token: 0x06006B3E RID: 27454 RVA: 0x0019FCD0 File Offset: 0x0019DED0
		[DebuggerNonUserCode]
		public bool HasTimezone
		{
			get
			{
				return this.timezone_ != null;
			}
		}

		// Token: 0x06006B3F RID: 27455 RVA: 0x0019FCEB File Offset: 0x0019DEEB
		[DebuggerNonUserCode]
		public void ClearTimezone()
		{
			this.timezone_ = null;
		}

		// Token: 0x17002253 RID: 8787
		// (get) Token: 0x06006B40 RID: 27456 RVA: 0x0019FCF8 File Offset: 0x0019DEF8
		// (set) Token: 0x06006B41 RID: 27457 RVA: 0x0019FD19 File Offset: 0x0019DF19
		[DebuggerNonUserCode]
		public string Locale
		{
			get
			{
				return this.locale_ ?? ClubDescription.LocaleDefaultValue;
			}
			set
			{
				this.locale_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002254 RID: 8788
		// (get) Token: 0x06006B42 RID: 27458 RVA: 0x0019FD30 File Offset: 0x0019DF30
		[DebuggerNonUserCode]
		public bool HasLocale
		{
			get
			{
				return this.locale_ != null;
			}
		}

		// Token: 0x06006B43 RID: 27459 RVA: 0x0019FD4B File Offset: 0x0019DF4B
		[DebuggerNonUserCode]
		public void ClearLocale()
		{
			this.locale_ = null;
		}

		// Token: 0x17002255 RID: 8789
		// (get) Token: 0x06006B44 RID: 27460 RVA: 0x0019FD58 File Offset: 0x0019DF58
		[DebuggerNonUserCode]
		public RepeatedField<TagIdentifier> Tag
		{
			get
			{
				return this.tag_;
			}
		}

		// Token: 0x06006B45 RID: 27461 RVA: 0x0019FD70 File Offset: 0x0019DF70
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubDescription);
		}

		// Token: 0x06006B46 RID: 27462 RVA: 0x0019FD90 File Offset: 0x0019DF90
		[DebuggerNonUserCode]
		public bool Equals(ClubDescription other)
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
											bool flag10 = this.VisibilityLevel != other.VisibilityLevel;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.MemberCount != other.MemberCount;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !this.leader_.Equals(other.leader_);
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.CreationTime != other.CreationTime;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.Timezone != other.Timezone;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.Locale != other.Locale;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = !this.tag_.Equals(other.tag_);
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

		// Token: 0x06006B47 RID: 27463 RVA: 0x0019FF58 File Offset: 0x0019E158
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
			num ^= this.leader_.GetHashCode();
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				num ^= this.CreationTime.GetHashCode();
			}
			bool hasTimezone = this.HasTimezone;
			if (hasTimezone)
			{
				num ^= this.Timezone.GetHashCode();
			}
			bool hasLocale = this.HasLocale;
			if (hasLocale)
			{
				num ^= this.Locale.GetHashCode();
			}
			num ^= this.tag_.GetHashCode();
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006B48 RID: 27464 RVA: 0x001A00E8 File Offset: 0x0019E2E8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006B49 RID: 27465 RVA: 0x001A0100 File Offset: 0x0019E300
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006B4A RID: 27466 RVA: 0x001A010C File Offset: 0x0019E30C
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
			bool hasVisibilityLevel = this.HasVisibilityLevel;
			if (hasVisibilityLevel)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.VisibilityLevel);
			}
			bool hasMemberCount = this.HasMemberCount;
			if (hasMemberCount)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.MemberCount);
			}
			this.leader_.WriteTo(ref output, ClubDescription._repeated_leader_codec);
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				output.WriteRawTag(80);
				output.WriteUInt64(this.CreationTime);
			}
			bool hasTimezone = this.HasTimezone;
			if (hasTimezone)
			{
				output.WriteRawTag(90);
				output.WriteString(this.Timezone);
			}
			bool hasLocale = this.HasLocale;
			if (hasLocale)
			{
				output.WriteRawTag(98);
				output.WriteString(this.Locale);
			}
			this.tag_.WriteTo(ref output, ClubDescription._repeated_tag_codec);
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006B4B RID: 27467 RVA: 0x001A02E8 File Offset: 0x0019E4E8
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
			num += this.leader_.CalculateSize(ClubDescription._repeated_leader_codec);
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreationTime);
			}
			bool hasTimezone = this.HasTimezone;
			if (hasTimezone)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Timezone);
			}
			bool hasLocale = this.HasLocale;
			if (hasLocale)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Locale);
			}
			num += this.tag_.CalculateSize(ClubDescription._repeated_tag_codec);
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006B4C RID: 27468 RVA: 0x001A0490 File Offset: 0x0019E690
		[DebuggerNonUserCode]
		public void MergeFrom(ClubDescription other)
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
				this.leader_.Add(other.leader_);
				bool hasCreationTime = other.HasCreationTime;
				if (hasCreationTime)
				{
					this.CreationTime = other.CreationTime;
				}
				bool hasTimezone = other.HasTimezone;
				if (hasTimezone)
				{
					this.Timezone = other.Timezone;
				}
				bool hasLocale = other.HasLocale;
				if (hasLocale)
				{
					this.Locale = other.Locale;
				}
				this.tag_.Add(other.tag_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006B4D RID: 27469 RVA: 0x001A0654 File Offset: 0x0019E854
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006B4E RID: 27470 RVA: 0x001A0660 File Offset: 0x0019E860
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
					if (num3 <= 26U)
					{
						if (num3 != 8U)
						{
							if (num3 != 18U)
							{
								if (num3 != 26U)
								{
									goto IL_00A0;
								}
								this.Name = input.ReadString();
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
						else
						{
							this.Id = input.ReadUInt64();
						}
					}
					else if (num3 != 34U)
					{
						if (num3 != 42U)
						{
							if (num3 != 48U)
							{
								goto IL_00A0;
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
					else
					{
						this.Description = input.ReadString();
					}
				}
				else if (num3 <= 74U)
				{
					if (num3 != 56U)
					{
						if (num3 != 64U)
						{
							if (num3 != 74U)
							{
								goto IL_00A0;
							}
							this.leader_.AddEntriesFrom(ref input, ClubDescription._repeated_leader_codec);
						}
						else
						{
							this.MemberCount = input.ReadUInt32();
						}
					}
					else
					{
						this.VisibilityLevel = (VisibilityLevel)input.ReadEnum();
					}
				}
				else if (num3 <= 90U)
				{
					if (num3 != 80U)
					{
						if (num3 != 90U)
						{
							goto IL_00A0;
						}
						this.Timezone = input.ReadString();
					}
					else
					{
						this.CreationTime = input.ReadUInt64();
					}
				}
				else if (num3 != 98U)
				{
					if (num3 != 106U)
					{
						goto IL_00A0;
					}
					this.tag_.AddEntriesFrom(ref input, ClubDescription._repeated_tag_codec);
				}
				else
				{
					this.Locale = input.ReadString();
				}
				continue;
				IL_00A0:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040030E1 RID: 12513
		private static readonly MessageParser<ClubDescription> _parser = new MessageParser<ClubDescription>(() => new ClubDescription());

		// Token: 0x040030E2 RID: 12514
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030E3 RID: 12515
		private int _hasBits0;

		// Token: 0x040030E4 RID: 12516
		public const int IdFieldNumber = 1;

		// Token: 0x040030E5 RID: 12517
		private static readonly ulong IdDefaultValue = 0UL;

		// Token: 0x040030E6 RID: 12518
		private ulong id_;

		// Token: 0x040030E7 RID: 12519
		public const int TypeFieldNumber = 2;

		// Token: 0x040030E8 RID: 12520
		private UniqueClubType type_;

		// Token: 0x040030E9 RID: 12521
		public const int NameFieldNumber = 3;

		// Token: 0x040030EA RID: 12522
		private static readonly string NameDefaultValue = "";

		// Token: 0x040030EB RID: 12523
		private string name_;

		// Token: 0x040030EC RID: 12524
		public const int DescriptionFieldNumber = 4;

		// Token: 0x040030ED RID: 12525
		private static readonly string DescriptionDefaultValue = "";

		// Token: 0x040030EE RID: 12526
		private string description_;

		// Token: 0x040030EF RID: 12527
		public const int AvatarFieldNumber = 5;

		// Token: 0x040030F0 RID: 12528
		private AvatarId avatar_;

		// Token: 0x040030F1 RID: 12529
		public const int PrivacyLevelFieldNumber = 6;

		// Token: 0x040030F2 RID: 12530
		private static readonly PrivacyLevel PrivacyLevelDefaultValue = PrivacyLevel.Closed;

		// Token: 0x040030F3 RID: 12531
		private PrivacyLevel privacyLevel_;

		// Token: 0x040030F4 RID: 12532
		public const int VisibilityLevelFieldNumber = 7;

		// Token: 0x040030F5 RID: 12533
		private static readonly VisibilityLevel VisibilityLevelDefaultValue = VisibilityLevel.Private;

		// Token: 0x040030F6 RID: 12534
		private VisibilityLevel visibilityLevel_;

		// Token: 0x040030F7 RID: 12535
		public const int MemberCountFieldNumber = 8;

		// Token: 0x040030F8 RID: 12536
		private static readonly uint MemberCountDefaultValue = 0U;

		// Token: 0x040030F9 RID: 12537
		private uint memberCount_;

		// Token: 0x040030FA RID: 12538
		public const int LeaderFieldNumber = 9;

		// Token: 0x040030FB RID: 12539
		private static readonly FieldCodec<MemberDescription> _repeated_leader_codec = FieldCodec.ForMessage<MemberDescription>(74U, MemberDescription.Parser);

		// Token: 0x040030FC RID: 12540
		private readonly RepeatedField<MemberDescription> leader_ = new RepeatedField<MemberDescription>();

		// Token: 0x040030FD RID: 12541
		public const int CreationTimeFieldNumber = 10;

		// Token: 0x040030FE RID: 12542
		private static readonly ulong CreationTimeDefaultValue = 0UL;

		// Token: 0x040030FF RID: 12543
		private ulong creationTime_;

		// Token: 0x04003100 RID: 12544
		public const int TimezoneFieldNumber = 11;

		// Token: 0x04003101 RID: 12545
		private static readonly string TimezoneDefaultValue = "";

		// Token: 0x04003102 RID: 12546
		private string timezone_;

		// Token: 0x04003103 RID: 12547
		public const int LocaleFieldNumber = 12;

		// Token: 0x04003104 RID: 12548
		private static readonly string LocaleDefaultValue = "";

		// Token: 0x04003105 RID: 12549
		private string locale_;

		// Token: 0x04003106 RID: 12550
		public const int TagFieldNumber = 13;

		// Token: 0x04003107 RID: 12551
		private static readonly FieldCodec<TagIdentifier> _repeated_tag_codec = FieldCodec.ForMessage<TagIdentifier>(106U, TagIdentifier.Parser);

		// Token: 0x04003108 RID: 12552
		private readonly RepeatedField<TagIdentifier> tag_ = new RepeatedField<TagIdentifier>();
	}
}
