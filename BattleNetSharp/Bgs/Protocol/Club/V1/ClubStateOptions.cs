using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000443 RID: 1091
	public sealed class ClubStateOptions : IMessage<ClubStateOptions>, IMessage, IEquatable<ClubStateOptions>, IDeepCloneable<ClubStateOptions>, IBufferMessage
	{
		// Token: 0x1700225C RID: 8796
		// (get) Token: 0x06006B67 RID: 27495 RVA: 0x001A0DA0 File Offset: 0x0019EFA0
		[DebuggerNonUserCode]
		public static MessageParser<ClubStateOptions> Parser
		{
			get
			{
				return ClubStateOptions._parser;
			}
		}

		// Token: 0x1700225D RID: 8797
		// (get) Token: 0x06006B68 RID: 27496 RVA: 0x001A0DB8 File Offset: 0x0019EFB8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubCoreReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x1700225E RID: 8798
		// (get) Token: 0x06006B69 RID: 27497 RVA: 0x001A0DDC File Offset: 0x0019EFDC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubStateOptions.Descriptor;
			}
		}

		// Token: 0x06006B6A RID: 27498 RVA: 0x001A0DF3 File Offset: 0x0019EFF3
		[DebuggerNonUserCode]
		public ClubStateOptions()
		{
		}

		// Token: 0x06006B6B RID: 27499 RVA: 0x001A0E14 File Offset: 0x0019F014
		[DebuggerNonUserCode]
		public ClubStateOptions(ClubStateOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
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
			this.tagOptions_ = ((other.tagOptions_ != null) ? other.tagOptions_.Clone() : null);
			this.searchAttribute_ = other.searchAttribute_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006B6C RID: 27500 RVA: 0x001A0F2C File Offset: 0x0019F12C
		[DebuggerNonUserCode]
		public ClubStateOptions Clone()
		{
			return new ClubStateOptions(this);
		}

		// Token: 0x1700225F RID: 8799
		// (get) Token: 0x06006B6D RID: 27501 RVA: 0x001A0F44 File Offset: 0x0019F144
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x17002260 RID: 8800
		// (get) Token: 0x06006B6E RID: 27502 RVA: 0x001A0F5C File Offset: 0x0019F15C
		// (set) Token: 0x06006B6F RID: 27503 RVA: 0x001A0F7D File Offset: 0x0019F17D
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? ClubStateOptions.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002261 RID: 8801
		// (get) Token: 0x06006B70 RID: 27504 RVA: 0x001A0F94 File Offset: 0x0019F194
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06006B71 RID: 27505 RVA: 0x001A0FAF File Offset: 0x0019F1AF
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x17002262 RID: 8802
		// (get) Token: 0x06006B72 RID: 27506 RVA: 0x001A0FBC File Offset: 0x0019F1BC
		// (set) Token: 0x06006B73 RID: 27507 RVA: 0x001A0FDD File Offset: 0x0019F1DD
		[DebuggerNonUserCode]
		public string Description
		{
			get
			{
				return this.description_ ?? ClubStateOptions.DescriptionDefaultValue;
			}
			set
			{
				this.description_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002263 RID: 8803
		// (get) Token: 0x06006B74 RID: 27508 RVA: 0x001A0FF4 File Offset: 0x0019F1F4
		[DebuggerNonUserCode]
		public bool HasDescription
		{
			get
			{
				return this.description_ != null;
			}
		}

		// Token: 0x06006B75 RID: 27509 RVA: 0x001A100F File Offset: 0x0019F20F
		[DebuggerNonUserCode]
		public void ClearDescription()
		{
			this.description_ = null;
		}

		// Token: 0x17002264 RID: 8804
		// (get) Token: 0x06006B76 RID: 27510 RVA: 0x001A101C File Offset: 0x0019F21C
		// (set) Token: 0x06006B77 RID: 27511 RVA: 0x001A1034 File Offset: 0x0019F234
		[DebuggerNonUserCode]
		public SetBroadcastOptions Broadcast
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

		// Token: 0x17002265 RID: 8805
		// (get) Token: 0x06006B78 RID: 27512 RVA: 0x001A1040 File Offset: 0x0019F240
		// (set) Token: 0x06006B79 RID: 27513 RVA: 0x001A1058 File Offset: 0x0019F258
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

		// Token: 0x17002266 RID: 8806
		// (get) Token: 0x06006B7A RID: 27514 RVA: 0x001A1064 File Offset: 0x0019F264
		// (set) Token: 0x06006B7B RID: 27515 RVA: 0x001A1095 File Offset: 0x0019F295
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
					privacyLevelDefaultValue = ClubStateOptions.PrivacyLevelDefaultValue;
				}
				return privacyLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.privacyLevel_ = value;
			}
		}

		// Token: 0x17002267 RID: 8807
		// (get) Token: 0x06006B7C RID: 27516 RVA: 0x001A10B0 File Offset: 0x0019F2B0
		[DebuggerNonUserCode]
		public bool HasPrivacyLevel
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006B7D RID: 27517 RVA: 0x001A10CD File Offset: 0x0019F2CD
		[DebuggerNonUserCode]
		public void ClearPrivacyLevel()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002268 RID: 8808
		// (get) Token: 0x06006B7E RID: 27518 RVA: 0x001A10E0 File Offset: 0x0019F2E0
		// (set) Token: 0x06006B7F RID: 27519 RVA: 0x001A10F8 File Offset: 0x0019F2F8
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

		// Token: 0x17002269 RID: 8809
		// (get) Token: 0x06006B80 RID: 27520 RVA: 0x001A1104 File Offset: 0x0019F304
		// (set) Token: 0x06006B81 RID: 27521 RVA: 0x001A1125 File Offset: 0x0019F325
		[DebuggerNonUserCode]
		public string ShortName
		{
			get
			{
				return this.shortName_ ?? ClubStateOptions.ShortNameDefaultValue;
			}
			set
			{
				this.shortName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700226A RID: 8810
		// (get) Token: 0x06006B82 RID: 27522 RVA: 0x001A113C File Offset: 0x0019F33C
		[DebuggerNonUserCode]
		public bool HasShortName
		{
			get
			{
				return this.shortName_ != null;
			}
		}

		// Token: 0x06006B83 RID: 27523 RVA: 0x001A1157 File Offset: 0x0019F357
		[DebuggerNonUserCode]
		public void ClearShortName()
		{
			this.shortName_ = null;
		}

		// Token: 0x1700226B RID: 8811
		// (get) Token: 0x06006B84 RID: 27524 RVA: 0x001A1164 File Offset: 0x0019F364
		// (set) Token: 0x06006B85 RID: 27525 RVA: 0x001A1195 File Offset: 0x0019F395
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
					visibilityLevelDefaultValue = ClubStateOptions.VisibilityLevelDefaultValue;
				}
				return visibilityLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.visibilityLevel_ = value;
			}
		}

		// Token: 0x1700226C RID: 8812
		// (get) Token: 0x06006B86 RID: 27526 RVA: 0x001A11B0 File Offset: 0x0019F3B0
		[DebuggerNonUserCode]
		public bool HasVisibilityLevel
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06006B87 RID: 27527 RVA: 0x001A11CD File Offset: 0x0019F3CD
		[DebuggerNonUserCode]
		public void ClearVisibilityLevel()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700226D RID: 8813
		// (get) Token: 0x06006B88 RID: 27528 RVA: 0x001A11E0 File Offset: 0x0019F3E0
		// (set) Token: 0x06006B89 RID: 27529 RVA: 0x001A1201 File Offset: 0x0019F401
		[DebuggerNonUserCode]
		public string Locale
		{
			get
			{
				return this.locale_ ?? ClubStateOptions.LocaleDefaultValue;
			}
			set
			{
				this.locale_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700226E RID: 8814
		// (get) Token: 0x06006B8A RID: 27530 RVA: 0x001A1218 File Offset: 0x0019F418
		[DebuggerNonUserCode]
		public bool HasLocale
		{
			get
			{
				return this.locale_ != null;
			}
		}

		// Token: 0x06006B8B RID: 27531 RVA: 0x001A1233 File Offset: 0x0019F433
		[DebuggerNonUserCode]
		public void ClearLocale()
		{
			this.locale_ = null;
		}

		// Token: 0x1700226F RID: 8815
		// (get) Token: 0x06006B8C RID: 27532 RVA: 0x001A1240 File Offset: 0x0019F440
		// (set) Token: 0x06006B8D RID: 27533 RVA: 0x001A1261 File Offset: 0x0019F461
		[DebuggerNonUserCode]
		public string Timezone
		{
			get
			{
				return this.timezone_ ?? ClubStateOptions.TimezoneDefaultValue;
			}
			set
			{
				this.timezone_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002270 RID: 8816
		// (get) Token: 0x06006B8E RID: 27534 RVA: 0x001A1278 File Offset: 0x0019F478
		[DebuggerNonUserCode]
		public bool HasTimezone
		{
			get
			{
				return this.timezone_ != null;
			}
		}

		// Token: 0x06006B8F RID: 27535 RVA: 0x001A1293 File Offset: 0x0019F493
		[DebuggerNonUserCode]
		public void ClearTimezone()
		{
			this.timezone_ = null;
		}

		// Token: 0x17002271 RID: 8817
		// (get) Token: 0x06006B90 RID: 27536 RVA: 0x001A12A0 File Offset: 0x0019F4A0
		// (set) Token: 0x06006B91 RID: 27537 RVA: 0x001A12B8 File Offset: 0x0019F4B8
		[DebuggerNonUserCode]
		public TagOptions TagOptions
		{
			get
			{
				return this.tagOptions_;
			}
			set
			{
				this.tagOptions_ = value;
			}
		}

		// Token: 0x17002272 RID: 8818
		// (get) Token: 0x06006B92 RID: 27538 RVA: 0x001A12C4 File Offset: 0x0019F4C4
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> SearchAttribute
		{
			get
			{
				return this.searchAttribute_;
			}
		}

		// Token: 0x06006B93 RID: 27539 RVA: 0x001A12DC File Offset: 0x0019F4DC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubStateOptions);
		}

		// Token: 0x06006B94 RID: 27540 RVA: 0x001A12FC File Offset: 0x0019F4FC
		[DebuggerNonUserCode]
		public bool Equals(ClubStateOptions other)
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
					bool flag4 = !this.attribute_.Equals(other.attribute_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Name != other.Name;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Description != other.Description;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.Broadcast, other.Broadcast);
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
											bool flag10 = !object.Equals(this.StreamPosition, other.StreamPosition);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.ShortName != other.ShortName;
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
														bool flag13 = this.Locale != other.Locale;
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
																bool flag15 = !object.Equals(this.TagOptions, other.TagOptions);
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = !this.searchAttribute_.Equals(other.searchAttribute_);
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

		// Token: 0x06006B95 RID: 27541 RVA: 0x001A14CC File Offset: 0x0019F6CC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
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
			bool flag4 = this.tagOptions_ != null;
			if (flag4)
			{
				num ^= this.TagOptions.GetHashCode();
			}
			num ^= this.searchAttribute_.GetHashCode();
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006B96 RID: 27542 RVA: 0x001A1658 File Offset: 0x0019F858
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006B97 RID: 27543 RVA: 0x001A1670 File Offset: 0x0019F870
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006B98 RID: 27544 RVA: 0x001A167C File Offset: 0x0019F87C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attribute_.WriteTo(ref output, ClubStateOptions._repeated_attribute_codec);
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Name);
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Description);
			}
			bool flag = this.broadcast_ != null;
			if (flag)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Broadcast);
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
			bool flag3 = this.streamPosition_ != null;
			if (flag3)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.StreamPosition);
			}
			bool hasShortName = this.HasShortName;
			if (hasShortName)
			{
				output.WriteRawTag(66);
				output.WriteString(this.ShortName);
			}
			bool hasVisibilityLevel = this.HasVisibilityLevel;
			if (hasVisibilityLevel)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.VisibilityLevel);
			}
			bool hasLocale = this.HasLocale;
			if (hasLocale)
			{
				output.WriteRawTag(82);
				output.WriteString(this.Locale);
			}
			bool hasTimezone = this.HasTimezone;
			if (hasTimezone)
			{
				output.WriteRawTag(90);
				output.WriteString(this.Timezone);
			}
			bool flag4 = this.tagOptions_ != null;
			if (flag4)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.TagOptions);
			}
			this.searchAttribute_.WriteTo(ref output, ClubStateOptions._repeated_searchAttribute_codec);
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006B99 RID: 27545 RVA: 0x001A185C File Offset: 0x0019FA5C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.attribute_.CalculateSize(ClubStateOptions._repeated_attribute_codec);
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
			bool flag4 = this.tagOptions_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TagOptions);
			}
			num += this.searchAttribute_.CalculateSize(ClubStateOptions._repeated_searchAttribute_codec);
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006B9A RID: 27546 RVA: 0x001A1A08 File Offset: 0x0019FC08
		[DebuggerNonUserCode]
		public void MergeFrom(ClubStateOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
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
						this.Broadcast = new SetBroadcastOptions();
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
				bool flag8 = other.tagOptions_ != null;
				if (flag8)
				{
					bool flag9 = this.tagOptions_ == null;
					if (flag9)
					{
						this.TagOptions = new TagOptions();
					}
					this.TagOptions.MergeFrom(other.TagOptions);
				}
				this.searchAttribute_.Add(other.searchAttribute_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006B9B RID: 27547 RVA: 0x001A1C16 File Offset: 0x0019FE16
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006B9C RID: 27548 RVA: 0x001A1C24 File Offset: 0x0019FE24
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
						if (num3 != 10U)
						{
							if (num3 != 18U)
							{
								if (num3 != 26U)
								{
									goto IL_00A1;
								}
								this.Description = input.ReadString();
							}
							else
							{
								this.Name = input.ReadString();
							}
						}
						else
						{
							this.attribute_.AddEntriesFrom(ref input, ClubStateOptions._repeated_attribute_codec);
						}
					}
					else if (num3 != 34U)
					{
						if (num3 != 42U)
						{
							if (num3 != 48U)
							{
								goto IL_00A1;
							}
							this.PrivacyLevel = (PrivacyLevel)input.ReadEnum();
						}
						else
						{
							bool flag = this.avatar_ == null;
							if (flag)
							{
								this.Avatar = new AvatarId();
							}
							input.ReadMessage(this.Avatar);
						}
					}
					else
					{
						bool flag2 = this.broadcast_ == null;
						if (flag2)
						{
							this.Broadcast = new SetBroadcastOptions();
						}
						input.ReadMessage(this.Broadcast);
					}
				}
				else if (num3 <= 72U)
				{
					if (num3 != 58U)
					{
						if (num3 != 66U)
						{
							if (num3 != 72U)
							{
								goto IL_00A1;
							}
							this.VisibilityLevel = (VisibilityLevel)input.ReadEnum();
						}
						else
						{
							this.ShortName = input.ReadString();
						}
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
				else if (num3 <= 90U)
				{
					if (num3 != 82U)
					{
						if (num3 != 90U)
						{
							goto IL_00A1;
						}
						this.Timezone = input.ReadString();
					}
					else
					{
						this.Locale = input.ReadString();
					}
				}
				else if (num3 != 98U)
				{
					if (num3 != 106U)
					{
						goto IL_00A1;
					}
					this.searchAttribute_.AddEntriesFrom(ref input, ClubStateOptions._repeated_searchAttribute_codec);
				}
				else
				{
					bool flag4 = this.tagOptions_ == null;
					if (flag4)
					{
						this.TagOptions = new TagOptions();
					}
					input.ReadMessage(this.TagOptions);
				}
				continue;
				IL_00A1:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003111 RID: 12561
		private static readonly MessageParser<ClubStateOptions> _parser = new MessageParser<ClubStateOptions>(() => new ClubStateOptions());

		// Token: 0x04003112 RID: 12562
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003113 RID: 12563
		private int _hasBits0;

		// Token: 0x04003114 RID: 12564
		public const int AttributeFieldNumber = 1;

		// Token: 0x04003115 RID: 12565
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(10U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x04003116 RID: 12566
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		// Token: 0x04003117 RID: 12567
		public const int NameFieldNumber = 2;

		// Token: 0x04003118 RID: 12568
		private static readonly string NameDefaultValue = "";

		// Token: 0x04003119 RID: 12569
		private string name_;

		// Token: 0x0400311A RID: 12570
		public const int DescriptionFieldNumber = 3;

		// Token: 0x0400311B RID: 12571
		private static readonly string DescriptionDefaultValue = "";

		// Token: 0x0400311C RID: 12572
		private string description_;

		// Token: 0x0400311D RID: 12573
		public const int BroadcastFieldNumber = 4;

		// Token: 0x0400311E RID: 12574
		private SetBroadcastOptions broadcast_;

		// Token: 0x0400311F RID: 12575
		public const int AvatarFieldNumber = 5;

		// Token: 0x04003120 RID: 12576
		private AvatarId avatar_;

		// Token: 0x04003121 RID: 12577
		public const int PrivacyLevelFieldNumber = 6;

		// Token: 0x04003122 RID: 12578
		private static readonly PrivacyLevel PrivacyLevelDefaultValue = PrivacyLevel.Closed;

		// Token: 0x04003123 RID: 12579
		private PrivacyLevel privacyLevel_;

		// Token: 0x04003124 RID: 12580
		public const int StreamPositionFieldNumber = 7;

		// Token: 0x04003125 RID: 12581
		private StreamPosition streamPosition_;

		// Token: 0x04003126 RID: 12582
		public const int ShortNameFieldNumber = 8;

		// Token: 0x04003127 RID: 12583
		private static readonly string ShortNameDefaultValue = "";

		// Token: 0x04003128 RID: 12584
		private string shortName_;

		// Token: 0x04003129 RID: 12585
		public const int VisibilityLevelFieldNumber = 9;

		// Token: 0x0400312A RID: 12586
		private static readonly VisibilityLevel VisibilityLevelDefaultValue = VisibilityLevel.Private;

		// Token: 0x0400312B RID: 12587
		private VisibilityLevel visibilityLevel_;

		// Token: 0x0400312C RID: 12588
		public const int LocaleFieldNumber = 10;

		// Token: 0x0400312D RID: 12589
		private static readonly string LocaleDefaultValue = "";

		// Token: 0x0400312E RID: 12590
		private string locale_;

		// Token: 0x0400312F RID: 12591
		public const int TimezoneFieldNumber = 11;

		// Token: 0x04003130 RID: 12592
		private static readonly string TimezoneDefaultValue = "";

		// Token: 0x04003131 RID: 12593
		private string timezone_;

		// Token: 0x04003132 RID: 12594
		public const int TagOptionsFieldNumber = 12;

		// Token: 0x04003133 RID: 12595
		private TagOptions tagOptions_;

		// Token: 0x04003134 RID: 12596
		public const int SearchAttributeFieldNumber = 13;

		// Token: 0x04003135 RID: 12597
		private static readonly FieldCodec<Attribute> _repeated_searchAttribute_codec = FieldCodec.ForMessage<Attribute>(106U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x04003136 RID: 12598
		private readonly RepeatedField<Attribute> searchAttribute_ = new RepeatedField<Attribute>();
	}
}
