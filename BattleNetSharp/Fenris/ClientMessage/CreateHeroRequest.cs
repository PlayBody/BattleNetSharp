using System;
using System.Diagnostics;
using Fenris.Hero;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000222 RID: 546
	public sealed class CreateHeroRequest : IMessage<CreateHeroRequest>, IMessage, IEquatable<CreateHeroRequest>, IDeepCloneable<CreateHeroRequest>, IBufferMessage
	{
		// Token: 0x17001349 RID: 4937
		// (get) Token: 0x06003B5D RID: 15197 RVA: 0x000EC3E0 File Offset: 0x000EA5E0
		[DebuggerNonUserCode]
		public static MessageParser<CreateHeroRequest> Parser
		{
			get
			{
				return CreateHeroRequest._parser;
			}
		}

		// Token: 0x1700134A RID: 4938
		// (get) Token: 0x06003B5E RID: 15198 RVA: 0x000EC3F8 File Offset: 0x000EA5F8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[18];
			}
		}

		// Token: 0x1700134B RID: 4939
		// (get) Token: 0x06003B5F RID: 15199 RVA: 0x000EC41C File Offset: 0x000EA61C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateHeroRequest.Descriptor;
			}
		}

		// Token: 0x06003B60 RID: 15200 RVA: 0x000EC433 File Offset: 0x000EA633
		[DebuggerNonUserCode]
		public CreateHeroRequest()
		{
		}

		// Token: 0x06003B61 RID: 15201 RVA: 0x000EC440 File Offset: 0x000EA640
		[DebuggerNonUserCode]
		public CreateHeroRequest(CreateHeroRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.heroName_ = other.heroName_;
			this.snoClass_ = other.snoClass_;
			this.isFemale_ = other.isFemale_;
			this.appearanceCustomization_ = ((other.appearanceCustomization_ != null) ? other.appearanceCustomization_.Clone() : null);
			this.isHardcore_ = other.isHardcore_;
			this.isSeasonal_ = other.isSeasonal_;
			this.allowAllCosmetics_ = other.allowAllCosmetics_;
			this.applyCampaignSkip_ = other.applyCampaignSkip_;
			this.clientLocale_ = other.clientLocale_;
			this.sessionKey_ = other.sessionKey_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003B62 RID: 15202 RVA: 0x000EC4FC File Offset: 0x000EA6FC
		[DebuggerNonUserCode]
		public CreateHeroRequest Clone()
		{
			return new CreateHeroRequest(this);
		}

		// Token: 0x1700134C RID: 4940
		// (get) Token: 0x06003B63 RID: 15203 RVA: 0x000EC514 File Offset: 0x000EA714
		// (set) Token: 0x06003B64 RID: 15204 RVA: 0x000EC535 File Offset: 0x000EA735
		[DebuggerNonUserCode]
		public string HeroName
		{
			get
			{
				return this.heroName_ ?? CreateHeroRequest.HeroNameDefaultValue;
			}
			set
			{
				this.heroName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700134D RID: 4941
		// (get) Token: 0x06003B65 RID: 15205 RVA: 0x000EC54C File Offset: 0x000EA74C
		[DebuggerNonUserCode]
		public bool HasHeroName
		{
			get
			{
				return this.heroName_ != null;
			}
		}

		// Token: 0x06003B66 RID: 15206 RVA: 0x000EC567 File Offset: 0x000EA767
		[DebuggerNonUserCode]
		public void ClearHeroName()
		{
			this.heroName_ = null;
		}

		// Token: 0x1700134E RID: 4942
		// (get) Token: 0x06003B67 RID: 15207 RVA: 0x000EC574 File Offset: 0x000EA774
		// (set) Token: 0x06003B68 RID: 15208 RVA: 0x000EC5A5 File Offset: 0x000EA7A5
		[DebuggerNonUserCode]
		public int SnoClass
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoClassDefaultValue;
				if (flag)
				{
					snoClassDefaultValue = this.snoClass_;
				}
				else
				{
					snoClassDefaultValue = CreateHeroRequest.SnoClassDefaultValue;
				}
				return snoClassDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoClass_ = value;
			}
		}

		// Token: 0x1700134F RID: 4943
		// (get) Token: 0x06003B69 RID: 15209 RVA: 0x000EC5C0 File Offset: 0x000EA7C0
		[DebuggerNonUserCode]
		public bool HasSnoClass
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003B6A RID: 15210 RVA: 0x000EC5DD File Offset: 0x000EA7DD
		[DebuggerNonUserCode]
		public void ClearSnoClass()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001350 RID: 4944
		// (get) Token: 0x06003B6B RID: 15211 RVA: 0x000EC5F0 File Offset: 0x000EA7F0
		// (set) Token: 0x06003B6C RID: 15212 RVA: 0x000EC621 File Offset: 0x000EA821
		[DebuggerNonUserCode]
		public bool IsFemale
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool isFemaleDefaultValue;
				if (flag)
				{
					isFemaleDefaultValue = this.isFemale_;
				}
				else
				{
					isFemaleDefaultValue = CreateHeroRequest.IsFemaleDefaultValue;
				}
				return isFemaleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.isFemale_ = value;
			}
		}

		// Token: 0x17001351 RID: 4945
		// (get) Token: 0x06003B6D RID: 15213 RVA: 0x000EC63C File Offset: 0x000EA83C
		[DebuggerNonUserCode]
		public bool HasIsFemale
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003B6E RID: 15214 RVA: 0x000EC659 File Offset: 0x000EA859
		[DebuggerNonUserCode]
		public void ClearIsFemale()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001352 RID: 4946
		// (get) Token: 0x06003B6F RID: 15215 RVA: 0x000EC66C File Offset: 0x000EA86C
		// (set) Token: 0x06003B70 RID: 15216 RVA: 0x000EC684 File Offset: 0x000EA884
		[DebuggerNonUserCode]
		public AppearanceCustomization AppearanceCustomization
		{
			get
			{
				return this.appearanceCustomization_;
			}
			set
			{
				this.appearanceCustomization_ = value;
			}
		}

		// Token: 0x17001353 RID: 4947
		// (get) Token: 0x06003B71 RID: 15217 RVA: 0x000EC690 File Offset: 0x000EA890
		// (set) Token: 0x06003B72 RID: 15218 RVA: 0x000EC6C1 File Offset: 0x000EA8C1
		[DebuggerNonUserCode]
		public bool IsHardcore
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool isHardcoreDefaultValue;
				if (flag)
				{
					isHardcoreDefaultValue = this.isHardcore_;
				}
				else
				{
					isHardcoreDefaultValue = CreateHeroRequest.IsHardcoreDefaultValue;
				}
				return isHardcoreDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.isHardcore_ = value;
			}
		}

		// Token: 0x17001354 RID: 4948
		// (get) Token: 0x06003B73 RID: 15219 RVA: 0x000EC6DC File Offset: 0x000EA8DC
		[DebuggerNonUserCode]
		public bool HasIsHardcore
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06003B74 RID: 15220 RVA: 0x000EC6F9 File Offset: 0x000EA8F9
		[DebuggerNonUserCode]
		public void ClearIsHardcore()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001355 RID: 4949
		// (get) Token: 0x06003B75 RID: 15221 RVA: 0x000EC70C File Offset: 0x000EA90C
		// (set) Token: 0x06003B76 RID: 15222 RVA: 0x000EC73D File Offset: 0x000EA93D
		[DebuggerNonUserCode]
		public bool IsSeasonal
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool isSeasonalDefaultValue;
				if (flag)
				{
					isSeasonalDefaultValue = this.isSeasonal_;
				}
				else
				{
					isSeasonalDefaultValue = CreateHeroRequest.IsSeasonalDefaultValue;
				}
				return isSeasonalDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.isSeasonal_ = value;
			}
		}

		// Token: 0x17001356 RID: 4950
		// (get) Token: 0x06003B77 RID: 15223 RVA: 0x000EC758 File Offset: 0x000EA958
		[DebuggerNonUserCode]
		public bool HasIsSeasonal
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06003B78 RID: 15224 RVA: 0x000EC775 File Offset: 0x000EA975
		[DebuggerNonUserCode]
		public void ClearIsSeasonal()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17001357 RID: 4951
		// (get) Token: 0x06003B79 RID: 15225 RVA: 0x000EC788 File Offset: 0x000EA988
		// (set) Token: 0x06003B7A RID: 15226 RVA: 0x000EC7BA File Offset: 0x000EA9BA
		[DebuggerNonUserCode]
		public bool AllowAllCosmetics
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool allowAllCosmeticsDefaultValue;
				if (flag)
				{
					allowAllCosmeticsDefaultValue = this.allowAllCosmetics_;
				}
				else
				{
					allowAllCosmeticsDefaultValue = CreateHeroRequest.AllowAllCosmeticsDefaultValue;
				}
				return allowAllCosmeticsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.allowAllCosmetics_ = value;
			}
		}

		// Token: 0x17001358 RID: 4952
		// (get) Token: 0x06003B7B RID: 15227 RVA: 0x000EC7D4 File Offset: 0x000EA9D4
		[DebuggerNonUserCode]
		public bool HasAllowAllCosmetics
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06003B7C RID: 15228 RVA: 0x000EC7F2 File Offset: 0x000EA9F2
		[DebuggerNonUserCode]
		public void ClearAllowAllCosmetics()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17001359 RID: 4953
		// (get) Token: 0x06003B7D RID: 15229 RVA: 0x000EC804 File Offset: 0x000EAA04
		// (set) Token: 0x06003B7E RID: 15230 RVA: 0x000EC836 File Offset: 0x000EAA36
		[DebuggerNonUserCode]
		public bool ApplyCampaignSkip
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				bool applyCampaignSkipDefaultValue;
				if (flag)
				{
					applyCampaignSkipDefaultValue = this.applyCampaignSkip_;
				}
				else
				{
					applyCampaignSkipDefaultValue = CreateHeroRequest.ApplyCampaignSkipDefaultValue;
				}
				return applyCampaignSkipDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.applyCampaignSkip_ = value;
			}
		}

		// Token: 0x1700135A RID: 4954
		// (get) Token: 0x06003B7F RID: 15231 RVA: 0x000EC850 File Offset: 0x000EAA50
		[DebuggerNonUserCode]
		public bool HasApplyCampaignSkip
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06003B80 RID: 15232 RVA: 0x000EC86E File Offset: 0x000EAA6E
		[DebuggerNonUserCode]
		public void ClearApplyCampaignSkip()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x1700135B RID: 4955
		// (get) Token: 0x06003B81 RID: 15233 RVA: 0x000EC880 File Offset: 0x000EAA80
		// (set) Token: 0x06003B82 RID: 15234 RVA: 0x000EC8B2 File Offset: 0x000EAAB2
		[DebuggerNonUserCode]
		public int ClientLocale
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				int clientLocaleDefaultValue;
				if (flag)
				{
					clientLocaleDefaultValue = this.clientLocale_;
				}
				else
				{
					clientLocaleDefaultValue = CreateHeroRequest.ClientLocaleDefaultValue;
				}
				return clientLocaleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.clientLocale_ = value;
			}
		}

		// Token: 0x1700135C RID: 4956
		// (get) Token: 0x06003B83 RID: 15235 RVA: 0x000EC8CC File Offset: 0x000EAACC
		[DebuggerNonUserCode]
		public bool HasClientLocale
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06003B84 RID: 15236 RVA: 0x000EC8EA File Offset: 0x000EAAEA
		[DebuggerNonUserCode]
		public void ClearClientLocale()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x1700135D RID: 4957
		// (get) Token: 0x06003B85 RID: 15237 RVA: 0x000EC8FC File Offset: 0x000EAAFC
		// (set) Token: 0x06003B86 RID: 15238 RVA: 0x000EC91D File Offset: 0x000EAB1D
		[DebuggerNonUserCode]
		public ByteString SessionKey
		{
			get
			{
				return this.sessionKey_ ?? CreateHeroRequest.SessionKeyDefaultValue;
			}
			set
			{
				this.sessionKey_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x1700135E RID: 4958
		// (get) Token: 0x06003B87 RID: 15239 RVA: 0x000EC934 File Offset: 0x000EAB34
		[DebuggerNonUserCode]
		public bool HasSessionKey
		{
			get
			{
				return this.sessionKey_ != null;
			}
		}

		// Token: 0x06003B88 RID: 15240 RVA: 0x000EC952 File Offset: 0x000EAB52
		[DebuggerNonUserCode]
		public void ClearSessionKey()
		{
			this.sessionKey_ = null;
		}

		// Token: 0x06003B89 RID: 15241 RVA: 0x000EC95C File Offset: 0x000EAB5C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateHeroRequest);
		}

		// Token: 0x06003B8A RID: 15242 RVA: 0x000EC97C File Offset: 0x000EAB7C
		[DebuggerNonUserCode]
		public bool Equals(CreateHeroRequest other)
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
					bool flag4 = this.HeroName != other.HeroName;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoClass != other.SnoClass;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.IsFemale != other.IsFemale;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.AppearanceCustomization, other.AppearanceCustomization);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.IsHardcore != other.IsHardcore;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.IsSeasonal != other.IsSeasonal;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.AllowAllCosmetics != other.AllowAllCosmetics;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.ApplyCampaignSkip != other.ApplyCampaignSkip;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.ClientLocale != other.ClientLocale;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.SessionKey != other.SessionKey;
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

		// Token: 0x06003B8B RID: 15243 RVA: 0x000ECAE0 File Offset: 0x000EACE0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasHeroName = this.HasHeroName;
			if (hasHeroName)
			{
				num ^= this.HeroName.GetHashCode();
			}
			bool hasSnoClass = this.HasSnoClass;
			if (hasSnoClass)
			{
				num ^= this.SnoClass.GetHashCode();
			}
			bool hasIsFemale = this.HasIsFemale;
			if (hasIsFemale)
			{
				num ^= this.IsFemale.GetHashCode();
			}
			bool flag = this.appearanceCustomization_ != null;
			if (flag)
			{
				num ^= this.AppearanceCustomization.GetHashCode();
			}
			bool hasIsHardcore = this.HasIsHardcore;
			if (hasIsHardcore)
			{
				num ^= this.IsHardcore.GetHashCode();
			}
			bool hasIsSeasonal = this.HasIsSeasonal;
			if (hasIsSeasonal)
			{
				num ^= this.IsSeasonal.GetHashCode();
			}
			bool hasAllowAllCosmetics = this.HasAllowAllCosmetics;
			if (hasAllowAllCosmetics)
			{
				num ^= this.AllowAllCosmetics.GetHashCode();
			}
			bool hasApplyCampaignSkip = this.HasApplyCampaignSkip;
			if (hasApplyCampaignSkip)
			{
				num ^= this.ApplyCampaignSkip.GetHashCode();
			}
			bool hasClientLocale = this.HasClientLocale;
			if (hasClientLocale)
			{
				num ^= this.ClientLocale.GetHashCode();
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				num ^= this.SessionKey.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003B8C RID: 15244 RVA: 0x000ECC34 File Offset: 0x000EAE34
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003B8D RID: 15245 RVA: 0x000ECC4C File Offset: 0x000EAE4C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003B8E RID: 15246 RVA: 0x000ECC58 File Offset: 0x000EAE58
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasHeroName = this.HasHeroName;
			if (hasHeroName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.HeroName);
			}
			bool hasSnoClass = this.HasSnoClass;
			if (hasSnoClass)
			{
				output.WriteRawTag(21);
				output.WriteSFixed32(this.SnoClass);
			}
			bool hasIsFemale = this.HasIsFemale;
			if (hasIsFemale)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsFemale);
			}
			bool flag = this.appearanceCustomization_ != null;
			if (flag)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.AppearanceCustomization);
			}
			bool hasIsHardcore = this.HasIsHardcore;
			if (hasIsHardcore)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsHardcore);
			}
			bool hasIsSeasonal = this.HasIsSeasonal;
			if (hasIsSeasonal)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsSeasonal);
			}
			bool hasAllowAllCosmetics = this.HasAllowAllCosmetics;
			if (hasAllowAllCosmetics)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.AllowAllCosmetics);
			}
			bool hasApplyCampaignSkip = this.HasApplyCampaignSkip;
			if (hasApplyCampaignSkip)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.ApplyCampaignSkip);
			}
			bool hasClientLocale = this.HasClientLocale;
			if (hasClientLocale)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ClientLocale);
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				output.WriteRawTag(82);
				output.WriteBytes(this.SessionKey);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003B8F RID: 15247 RVA: 0x000ECDE8 File Offset: 0x000EAFE8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasHeroName = this.HasHeroName;
			if (hasHeroName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.HeroName);
			}
			bool hasSnoClass = this.HasSnoClass;
			if (hasSnoClass)
			{
				num += 5;
			}
			bool hasIsFemale = this.HasIsFemale;
			if (hasIsFemale)
			{
				num += 2;
			}
			bool flag = this.appearanceCustomization_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AppearanceCustomization);
			}
			bool hasIsHardcore = this.HasIsHardcore;
			if (hasIsHardcore)
			{
				num += 2;
			}
			bool hasIsSeasonal = this.HasIsSeasonal;
			if (hasIsSeasonal)
			{
				num += 2;
			}
			bool hasAllowAllCosmetics = this.HasAllowAllCosmetics;
			if (hasAllowAllCosmetics)
			{
				num += 2;
			}
			bool hasApplyCampaignSkip = this.HasApplyCampaignSkip;
			if (hasApplyCampaignSkip)
			{
				num += 2;
			}
			bool hasClientLocale = this.HasClientLocale;
			if (hasClientLocale)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ClientLocale);
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.SessionKey);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003B90 RID: 15248 RVA: 0x000ECF00 File Offset: 0x000EB100
		[DebuggerNonUserCode]
		public void MergeFrom(CreateHeroRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasHeroName = other.HasHeroName;
				if (hasHeroName)
				{
					this.HeroName = other.HeroName;
				}
				bool hasSnoClass = other.HasSnoClass;
				if (hasSnoClass)
				{
					this.SnoClass = other.SnoClass;
				}
				bool hasIsFemale = other.HasIsFemale;
				if (hasIsFemale)
				{
					this.IsFemale = other.IsFemale;
				}
				bool flag2 = other.appearanceCustomization_ != null;
				if (flag2)
				{
					bool flag3 = this.appearanceCustomization_ == null;
					if (flag3)
					{
						this.AppearanceCustomization = new AppearanceCustomization();
					}
					this.AppearanceCustomization.MergeFrom(other.AppearanceCustomization);
				}
				bool hasIsHardcore = other.HasIsHardcore;
				if (hasIsHardcore)
				{
					this.IsHardcore = other.IsHardcore;
				}
				bool hasIsSeasonal = other.HasIsSeasonal;
				if (hasIsSeasonal)
				{
					this.IsSeasonal = other.IsSeasonal;
				}
				bool hasAllowAllCosmetics = other.HasAllowAllCosmetics;
				if (hasAllowAllCosmetics)
				{
					this.AllowAllCosmetics = other.AllowAllCosmetics;
				}
				bool hasApplyCampaignSkip = other.HasApplyCampaignSkip;
				if (hasApplyCampaignSkip)
				{
					this.ApplyCampaignSkip = other.ApplyCampaignSkip;
				}
				bool hasClientLocale = other.HasClientLocale;
				if (hasClientLocale)
				{
					this.ClientLocale = other.ClientLocale;
				}
				bool hasSessionKey = other.HasSessionKey;
				if (hasSessionKey)
				{
					this.SessionKey = other.SessionKey;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003B91 RID: 15249 RVA: 0x000ED060 File Offset: 0x000EB260
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003B92 RID: 15250 RVA: 0x000ED06C File Offset: 0x000EB26C
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
					if (num3 <= 21U)
					{
						if (num3 != 10U)
						{
							if (num3 != 21U)
							{
								goto IL_007B;
							}
							this.SnoClass = input.ReadSFixed32();
						}
						else
						{
							this.HeroName = input.ReadString();
						}
					}
					else if (num3 != 24U)
					{
						if (num3 != 34U)
						{
							if (num3 != 40U)
							{
								goto IL_007B;
							}
							this.IsHardcore = input.ReadBool();
						}
						else
						{
							bool flag = this.appearanceCustomization_ == null;
							if (flag)
							{
								this.AppearanceCustomization = new AppearanceCustomization();
							}
							input.ReadMessage(this.AppearanceCustomization);
						}
					}
					else
					{
						this.IsFemale = input.ReadBool();
					}
				}
				else if (num3 <= 56U)
				{
					if (num3 != 48U)
					{
						if (num3 != 56U)
						{
							goto IL_007B;
						}
						this.AllowAllCosmetics = input.ReadBool();
					}
					else
					{
						this.IsSeasonal = input.ReadBool();
					}
				}
				else if (num3 != 64U)
				{
					if (num3 != 72U)
					{
						if (num3 != 82U)
						{
							goto IL_007B;
						}
						this.SessionKey = input.ReadBytes();
					}
					else
					{
						this.ClientLocale = input.ReadInt32();
					}
				}
				else
				{
					this.ApplyCampaignSkip = input.ReadBool();
				}
				continue;
				IL_007B:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001B85 RID: 7045
		private static readonly MessageParser<CreateHeroRequest> _parser = new MessageParser<CreateHeroRequest>(() => new CreateHeroRequest());

		// Token: 0x04001B86 RID: 7046
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001B87 RID: 7047
		private int _hasBits0;

		// Token: 0x04001B88 RID: 7048
		public const int HeroNameFieldNumber = 1;

		// Token: 0x04001B89 RID: 7049
		private static readonly string HeroNameDefaultValue = "";

		// Token: 0x04001B8A RID: 7050
		private string heroName_;

		// Token: 0x04001B8B RID: 7051
		public const int SnoClassFieldNumber = 2;

		// Token: 0x04001B8C RID: 7052
		private static readonly int SnoClassDefaultValue = 0;

		// Token: 0x04001B8D RID: 7053
		private int snoClass_;

		// Token: 0x04001B8E RID: 7054
		public const int IsFemaleFieldNumber = 3;

		// Token: 0x04001B8F RID: 7055
		private static readonly bool IsFemaleDefaultValue = false;

		// Token: 0x04001B90 RID: 7056
		private bool isFemale_;

		// Token: 0x04001B91 RID: 7057
		public const int AppearanceCustomizationFieldNumber = 4;

		// Token: 0x04001B92 RID: 7058
		private AppearanceCustomization appearanceCustomization_;

		// Token: 0x04001B93 RID: 7059
		public const int IsHardcoreFieldNumber = 5;

		// Token: 0x04001B94 RID: 7060
		private static readonly bool IsHardcoreDefaultValue = false;

		// Token: 0x04001B95 RID: 7061
		private bool isHardcore_;

		// Token: 0x04001B96 RID: 7062
		public const int IsSeasonalFieldNumber = 6;

		// Token: 0x04001B97 RID: 7063
		private static readonly bool IsSeasonalDefaultValue = false;

		// Token: 0x04001B98 RID: 7064
		private bool isSeasonal_;

		// Token: 0x04001B99 RID: 7065
		public const int AllowAllCosmeticsFieldNumber = 7;

		// Token: 0x04001B9A RID: 7066
		private static readonly bool AllowAllCosmeticsDefaultValue = false;

		// Token: 0x04001B9B RID: 7067
		private bool allowAllCosmetics_;

		// Token: 0x04001B9C RID: 7068
		public const int ApplyCampaignSkipFieldNumber = 8;

		// Token: 0x04001B9D RID: 7069
		private static readonly bool ApplyCampaignSkipDefaultValue = false;

		// Token: 0x04001B9E RID: 7070
		private bool applyCampaignSkip_;

		// Token: 0x04001B9F RID: 7071
		public const int ClientLocaleFieldNumber = 9;

		// Token: 0x04001BA0 RID: 7072
		private static readonly int ClientLocaleDefaultValue = 0;

		// Token: 0x04001BA1 RID: 7073
		private int clientLocale_;

		// Token: 0x04001BA2 RID: 7074
		public const int SessionKeyFieldNumber = 10;

		// Token: 0x04001BA3 RID: 7075
		private static readonly ByteString SessionKeyDefaultValue = ByteString.Empty;

		// Token: 0x04001BA4 RID: 7076
		private ByteString sessionKey_;
	}
}
