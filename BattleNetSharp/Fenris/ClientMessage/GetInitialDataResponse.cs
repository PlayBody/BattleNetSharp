using System;
using System.Diagnostics;
using Fenris.Account;
using Fenris.Client;
using Fenris.GameMessage;
using Fenris.Hero;
using Fenris.License;
using Fenris.Online;
using Fenris.TACTKey;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200021F RID: 543
	public sealed class GetInitialDataResponse : IMessage<GetInitialDataResponse>, IMessage, IEquatable<GetInitialDataResponse>, IDeepCloneable<GetInitialDataResponse>, IBufferMessage
	{
		// Token: 0x17001311 RID: 4881
		// (get) Token: 0x06003AD2 RID: 15058 RVA: 0x000E98A4 File Offset: 0x000E7AA4
		[DebuggerNonUserCode]
		public static MessageParser<GetInitialDataResponse> Parser
		{
			get
			{
				return GetInitialDataResponse._parser;
			}
		}

		// Token: 0x17001312 RID: 4882
		// (get) Token: 0x06003AD3 RID: 15059 RVA: 0x000E98BC File Offset: 0x000E7ABC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[15];
			}
		}

		// Token: 0x17001313 RID: 4883
		// (get) Token: 0x06003AD4 RID: 15060 RVA: 0x000E98E0 File Offset: 0x000E7AE0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetInitialDataResponse.Descriptor;
			}
		}

		// Token: 0x06003AD5 RID: 15061 RVA: 0x000E98F8 File Offset: 0x000E7AF8
		[DebuggerNonUserCode]
		public GetInitialDataResponse()
		{
		}

		// Token: 0x06003AD6 RID: 15062 RVA: 0x000E9944 File Offset: 0x000E7B44
		[DebuggerNonUserCode]
		public GetInitialDataResponse(GetInitialDataResponse other)
			: this()
		{
			this.accountDigest_ = ((other.accountDigest_ != null) ? other.accountDigest_.Clone() : null);
			this.heroes_ = other.heroes_.Clone();
			this.deletedHero_ = ((other.deletedHero_ != null) ? other.deletedHero_.Clone() : null);
			this.syncVarCmdLine_ = other.syncVarCmdLine_;
			this.accountNotification_ = other.accountNotification_.Clone();
			this.playerLicenses_ = ((other.playerLicenses_ != null) ? other.playerLicenses_.Clone() : null);
			this.keys_ = ((other.keys_ != null) ? other.keys_.Clone() : null);
			this.commerceSdkClientId_ = other.commerceSdkClientId_;
			this.settings_ = ((other.settings_ != null) ? other.settings_.Clone() : null);
			this.serviceVersion_ = other.serviceVersion_;
			this.contentStackApiKey_ = other.contentStackApiKey_;
			this.contentStackDevAccessToken_ = other.contentStackDevAccessToken_;
			this.contentStackProdAccessToken_ = other.contentStackProdAccessToken_;
			this.abTestingGroups_ = other.abTestingGroups_.Clone();
			this.commerceSdkClientSecret_ = other.commerceSdkClientSecret_;
			this.commerceSdkPageId_ = other.commerceSdkPageId_.Clone();
			this.zoneProgressData_ = ((other.zoneProgressData_ != null) ? other.zoneProgressData_.Clone() : null);
			this.commerceSdkPlacementId_ = other.commerceSdkPlacementId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003AD7 RID: 15063 RVA: 0x000E9ABC File Offset: 0x000E7CBC
		[DebuggerNonUserCode]
		public GetInitialDataResponse Clone()
		{
			return new GetInitialDataResponse(this);
		}

		// Token: 0x17001314 RID: 4884
		// (get) Token: 0x06003AD8 RID: 15064 RVA: 0x000E9AD4 File Offset: 0x000E7CD4
		// (set) Token: 0x06003AD9 RID: 15065 RVA: 0x000E9AEC File Offset: 0x000E7CEC
		[DebuggerNonUserCode]
		public Fenris.Account.Digest AccountDigest
		{
			get
			{
				return this.accountDigest_;
			}
			set
			{
				this.accountDigest_ = value;
			}
		}

		// Token: 0x17001315 RID: 4885
		// (get) Token: 0x06003ADA RID: 15066 RVA: 0x000E9AF8 File Offset: 0x000E7CF8
		[DebuggerNonUserCode]
		public RepeatedField<Fenris.Hero.Digest> Heroes
		{
			get
			{
				return this.heroes_;
			}
		}

		// Token: 0x17001316 RID: 4886
		// (get) Token: 0x06003ADB RID: 15067 RVA: 0x000E9B10 File Offset: 0x000E7D10
		// (set) Token: 0x06003ADC RID: 15068 RVA: 0x000E9B28 File Offset: 0x000E7D28
		[DebuggerNonUserCode]
		public Fenris.Hero.Digest DeletedHero
		{
			get
			{
				return this.deletedHero_;
			}
			set
			{
				this.deletedHero_ = value;
			}
		}

		// Token: 0x17001317 RID: 4887
		// (get) Token: 0x06003ADD RID: 15069 RVA: 0x000E9B34 File Offset: 0x000E7D34
		// (set) Token: 0x06003ADE RID: 15070 RVA: 0x000E9B55 File Offset: 0x000E7D55
		[DebuggerNonUserCode]
		public string SyncVarCmdLine
		{
			get
			{
				return this.syncVarCmdLine_ ?? GetInitialDataResponse.SyncVarCmdLineDefaultValue;
			}
			set
			{
				this.syncVarCmdLine_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001318 RID: 4888
		// (get) Token: 0x06003ADF RID: 15071 RVA: 0x000E9B6C File Offset: 0x000E7D6C
		[DebuggerNonUserCode]
		public bool HasSyncVarCmdLine
		{
			get
			{
				return this.syncVarCmdLine_ != null;
			}
		}

		// Token: 0x06003AE0 RID: 15072 RVA: 0x000E9B87 File Offset: 0x000E7D87
		[DebuggerNonUserCode]
		public void ClearSyncVarCmdLine()
		{
			this.syncVarCmdLine_ = null;
		}

		// Token: 0x17001319 RID: 4889
		// (get) Token: 0x06003AE1 RID: 15073 RVA: 0x000E9B94 File Offset: 0x000E7D94
		[DebuggerNonUserCode]
		public RepeatedField<PlayerNotification> AccountNotification
		{
			get
			{
				return this.accountNotification_;
			}
		}

		// Token: 0x1700131A RID: 4890
		// (get) Token: 0x06003AE2 RID: 15074 RVA: 0x000E9BAC File Offset: 0x000E7DAC
		// (set) Token: 0x06003AE3 RID: 15075 RVA: 0x000E9BC4 File Offset: 0x000E7DC4
		[DebuggerNonUserCode]
		public PlayerLicenses PlayerLicenses
		{
			get
			{
				return this.playerLicenses_;
			}
			set
			{
				this.playerLicenses_ = value;
			}
		}

		// Token: 0x1700131B RID: 4891
		// (get) Token: 0x06003AE4 RID: 15076 RVA: 0x000E9BD0 File Offset: 0x000E7DD0
		// (set) Token: 0x06003AE5 RID: 15077 RVA: 0x000E9BE8 File Offset: 0x000E7DE8
		[DebuggerNonUserCode]
		public Keys Keys
		{
			get
			{
				return this.keys_;
			}
			set
			{
				this.keys_ = value;
			}
		}

		// Token: 0x1700131C RID: 4892
		// (get) Token: 0x06003AE6 RID: 15078 RVA: 0x000E9BF4 File Offset: 0x000E7DF4
		// (set) Token: 0x06003AE7 RID: 15079 RVA: 0x000E9C15 File Offset: 0x000E7E15
		[DebuggerNonUserCode]
		public ByteString CommerceSdkClientId
		{
			get
			{
				return this.commerceSdkClientId_ ?? GetInitialDataResponse.CommerceSdkClientIdDefaultValue;
			}
			set
			{
				this.commerceSdkClientId_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x1700131D RID: 4893
		// (get) Token: 0x06003AE8 RID: 15080 RVA: 0x000E9C2C File Offset: 0x000E7E2C
		[DebuggerNonUserCode]
		public bool HasCommerceSdkClientId
		{
			get
			{
				return this.commerceSdkClientId_ != null;
			}
		}

		// Token: 0x06003AE9 RID: 15081 RVA: 0x000E9C4A File Offset: 0x000E7E4A
		[DebuggerNonUserCode]
		public void ClearCommerceSdkClientId()
		{
			this.commerceSdkClientId_ = null;
		}

		// Token: 0x1700131E RID: 4894
		// (get) Token: 0x06003AEA RID: 15082 RVA: 0x000E9C54 File Offset: 0x000E7E54
		// (set) Token: 0x06003AEB RID: 15083 RVA: 0x000E9C6C File Offset: 0x000E7E6C
		[DebuggerNonUserCode]
		public GameAccountSettings Settings
		{
			get
			{
				return this.settings_;
			}
			set
			{
				this.settings_ = value;
			}
		}

		// Token: 0x1700131F RID: 4895
		// (get) Token: 0x06003AEC RID: 15084 RVA: 0x000E9C78 File Offset: 0x000E7E78
		// (set) Token: 0x06003AED RID: 15085 RVA: 0x000E9C99 File Offset: 0x000E7E99
		[DebuggerNonUserCode]
		public string ServiceVersion
		{
			get
			{
				return this.serviceVersion_ ?? GetInitialDataResponse.ServiceVersionDefaultValue;
			}
			set
			{
				this.serviceVersion_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001320 RID: 4896
		// (get) Token: 0x06003AEE RID: 15086 RVA: 0x000E9CB0 File Offset: 0x000E7EB0
		[DebuggerNonUserCode]
		public bool HasServiceVersion
		{
			get
			{
				return this.serviceVersion_ != null;
			}
		}

		// Token: 0x06003AEF RID: 15087 RVA: 0x000E9CCB File Offset: 0x000E7ECB
		[DebuggerNonUserCode]
		public void ClearServiceVersion()
		{
			this.serviceVersion_ = null;
		}

		// Token: 0x17001321 RID: 4897
		// (get) Token: 0x06003AF0 RID: 15088 RVA: 0x000E9CD8 File Offset: 0x000E7ED8
		// (set) Token: 0x06003AF1 RID: 15089 RVA: 0x000E9CF9 File Offset: 0x000E7EF9
		[DebuggerNonUserCode]
		public ByteString ContentStackApiKey
		{
			get
			{
				return this.contentStackApiKey_ ?? GetInitialDataResponse.ContentStackApiKeyDefaultValue;
			}
			set
			{
				this.contentStackApiKey_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17001322 RID: 4898
		// (get) Token: 0x06003AF2 RID: 15090 RVA: 0x000E9D10 File Offset: 0x000E7F10
		[DebuggerNonUserCode]
		public bool HasContentStackApiKey
		{
			get
			{
				return this.contentStackApiKey_ != null;
			}
		}

		// Token: 0x06003AF3 RID: 15091 RVA: 0x000E9D2E File Offset: 0x000E7F2E
		[DebuggerNonUserCode]
		public void ClearContentStackApiKey()
		{
			this.contentStackApiKey_ = null;
		}

		// Token: 0x17001323 RID: 4899
		// (get) Token: 0x06003AF4 RID: 15092 RVA: 0x000E9D38 File Offset: 0x000E7F38
		// (set) Token: 0x06003AF5 RID: 15093 RVA: 0x000E9D59 File Offset: 0x000E7F59
		[DebuggerNonUserCode]
		public ByteString ContentStackDevAccessToken
		{
			get
			{
				return this.contentStackDevAccessToken_ ?? GetInitialDataResponse.ContentStackDevAccessTokenDefaultValue;
			}
			set
			{
				this.contentStackDevAccessToken_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17001324 RID: 4900
		// (get) Token: 0x06003AF6 RID: 15094 RVA: 0x000E9D70 File Offset: 0x000E7F70
		[DebuggerNonUserCode]
		public bool HasContentStackDevAccessToken
		{
			get
			{
				return this.contentStackDevAccessToken_ != null;
			}
		}

		// Token: 0x06003AF7 RID: 15095 RVA: 0x000E9D8E File Offset: 0x000E7F8E
		[DebuggerNonUserCode]
		public void ClearContentStackDevAccessToken()
		{
			this.contentStackDevAccessToken_ = null;
		}

		// Token: 0x17001325 RID: 4901
		// (get) Token: 0x06003AF8 RID: 15096 RVA: 0x000E9D98 File Offset: 0x000E7F98
		// (set) Token: 0x06003AF9 RID: 15097 RVA: 0x000E9DB9 File Offset: 0x000E7FB9
		[DebuggerNonUserCode]
		public ByteString ContentStackProdAccessToken
		{
			get
			{
				return this.contentStackProdAccessToken_ ?? GetInitialDataResponse.ContentStackProdAccessTokenDefaultValue;
			}
			set
			{
				this.contentStackProdAccessToken_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17001326 RID: 4902
		// (get) Token: 0x06003AFA RID: 15098 RVA: 0x000E9DD0 File Offset: 0x000E7FD0
		[DebuggerNonUserCode]
		public bool HasContentStackProdAccessToken
		{
			get
			{
				return this.contentStackProdAccessToken_ != null;
			}
		}

		// Token: 0x06003AFB RID: 15099 RVA: 0x000E9DEE File Offset: 0x000E7FEE
		[DebuggerNonUserCode]
		public void ClearContentStackProdAccessToken()
		{
			this.contentStackProdAccessToken_ = null;
		}

		// Token: 0x17001327 RID: 4903
		// (get) Token: 0x06003AFC RID: 15100 RVA: 0x000E9DF8 File Offset: 0x000E7FF8
		[DebuggerNonUserCode]
		public RepeatedField<TestingGroupVariant> AbTestingGroups
		{
			get
			{
				return this.abTestingGroups_;
			}
		}

		// Token: 0x17001328 RID: 4904
		// (get) Token: 0x06003AFD RID: 15101 RVA: 0x000E9E10 File Offset: 0x000E8010
		// (set) Token: 0x06003AFE RID: 15102 RVA: 0x000E9E31 File Offset: 0x000E8031
		[DebuggerNonUserCode]
		public ByteString CommerceSdkClientSecret
		{
			get
			{
				return this.commerceSdkClientSecret_ ?? GetInitialDataResponse.CommerceSdkClientSecretDefaultValue;
			}
			set
			{
				this.commerceSdkClientSecret_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17001329 RID: 4905
		// (get) Token: 0x06003AFF RID: 15103 RVA: 0x000E9E48 File Offset: 0x000E8048
		[DebuggerNonUserCode]
		public bool HasCommerceSdkClientSecret
		{
			get
			{
				return this.commerceSdkClientSecret_ != null;
			}
		}

		// Token: 0x06003B00 RID: 15104 RVA: 0x000E9E66 File Offset: 0x000E8066
		[DebuggerNonUserCode]
		public void ClearCommerceSdkClientSecret()
		{
			this.commerceSdkClientSecret_ = null;
		}

		// Token: 0x1700132A RID: 4906
		// (get) Token: 0x06003B01 RID: 15105 RVA: 0x000E9E70 File Offset: 0x000E8070
		[DebuggerNonUserCode]
		public RepeatedField<ByteString> CommerceSdkPageId
		{
			get
			{
				return this.commerceSdkPageId_;
			}
		}

		// Token: 0x1700132B RID: 4907
		// (get) Token: 0x06003B02 RID: 15106 RVA: 0x000E9E88 File Offset: 0x000E8088
		// (set) Token: 0x06003B03 RID: 15107 RVA: 0x000E9EA0 File Offset: 0x000E80A0
		[DebuggerNonUserCode]
		public ZoneProgressGlobalDataMessage ZoneProgressData
		{
			get
			{
				return this.zoneProgressData_;
			}
			set
			{
				this.zoneProgressData_ = value;
			}
		}

		// Token: 0x1700132C RID: 4908
		// (get) Token: 0x06003B04 RID: 15108 RVA: 0x000E9EAC File Offset: 0x000E80AC
		[DebuggerNonUserCode]
		public RepeatedField<ByteString> CommerceSdkPlacementId
		{
			get
			{
				return this.commerceSdkPlacementId_;
			}
		}

		// Token: 0x06003B05 RID: 15109 RVA: 0x000E9EC4 File Offset: 0x000E80C4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetInitialDataResponse);
		}

		// Token: 0x06003B06 RID: 15110 RVA: 0x000E9EE4 File Offset: 0x000E80E4
		[DebuggerNonUserCode]
		public bool Equals(GetInitialDataResponse other)
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
					bool flag4 = !object.Equals(this.AccountDigest, other.AccountDigest);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.heroes_.Equals(other.heroes_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.DeletedHero, other.DeletedHero);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.SyncVarCmdLine != other.SyncVarCmdLine;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.accountNotification_.Equals(other.accountNotification_);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !object.Equals(this.PlayerLicenses, other.PlayerLicenses);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !object.Equals(this.Keys, other.Keys);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.CommerceSdkClientId != other.CommerceSdkClientId;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !object.Equals(this.Settings, other.Settings);
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.ServiceVersion != other.ServiceVersion;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.ContentStackApiKey != other.ContentStackApiKey;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.ContentStackDevAccessToken != other.ContentStackDevAccessToken;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = this.ContentStackProdAccessToken != other.ContentStackProdAccessToken;
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = !this.abTestingGroups_.Equals(other.abTestingGroups_);
																		if (flag17)
																		{
																			flag2 = false;
																		}
																		else
																		{
																			bool flag18 = this.CommerceSdkClientSecret != other.CommerceSdkClientSecret;
																			if (flag18)
																			{
																				flag2 = false;
																			}
																			else
																			{
																				bool flag19 = !this.commerceSdkPageId_.Equals(other.commerceSdkPageId_);
																				if (flag19)
																				{
																					flag2 = false;
																				}
																				else
																				{
																					bool flag20 = !object.Equals(this.ZoneProgressData, other.ZoneProgressData);
																					if (flag20)
																					{
																						flag2 = false;
																					}
																					else
																					{
																						bool flag21 = !this.commerceSdkPlacementId_.Equals(other.commerceSdkPlacementId_);
																						flag2 = !flag21 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x06003B07 RID: 15111 RVA: 0x000EA158 File Offset: 0x000E8358
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.accountDigest_ != null;
			if (flag)
			{
				num ^= this.AccountDigest.GetHashCode();
			}
			num ^= this.heroes_.GetHashCode();
			bool flag2 = this.deletedHero_ != null;
			if (flag2)
			{
				num ^= this.DeletedHero.GetHashCode();
			}
			bool hasSyncVarCmdLine = this.HasSyncVarCmdLine;
			if (hasSyncVarCmdLine)
			{
				num ^= this.SyncVarCmdLine.GetHashCode();
			}
			num ^= this.accountNotification_.GetHashCode();
			bool flag3 = this.playerLicenses_ != null;
			if (flag3)
			{
				num ^= this.PlayerLicenses.GetHashCode();
			}
			bool flag4 = this.keys_ != null;
			if (flag4)
			{
				num ^= this.Keys.GetHashCode();
			}
			bool hasCommerceSdkClientId = this.HasCommerceSdkClientId;
			if (hasCommerceSdkClientId)
			{
				num ^= this.CommerceSdkClientId.GetHashCode();
			}
			bool flag5 = this.settings_ != null;
			if (flag5)
			{
				num ^= this.Settings.GetHashCode();
			}
			bool hasServiceVersion = this.HasServiceVersion;
			if (hasServiceVersion)
			{
				num ^= this.ServiceVersion.GetHashCode();
			}
			bool hasContentStackApiKey = this.HasContentStackApiKey;
			if (hasContentStackApiKey)
			{
				num ^= this.ContentStackApiKey.GetHashCode();
			}
			bool hasContentStackDevAccessToken = this.HasContentStackDevAccessToken;
			if (hasContentStackDevAccessToken)
			{
				num ^= this.ContentStackDevAccessToken.GetHashCode();
			}
			bool hasContentStackProdAccessToken = this.HasContentStackProdAccessToken;
			if (hasContentStackProdAccessToken)
			{
				num ^= this.ContentStackProdAccessToken.GetHashCode();
			}
			num ^= this.abTestingGroups_.GetHashCode();
			bool hasCommerceSdkClientSecret = this.HasCommerceSdkClientSecret;
			if (hasCommerceSdkClientSecret)
			{
				num ^= this.CommerceSdkClientSecret.GetHashCode();
			}
			num ^= this.commerceSdkPageId_.GetHashCode();
			bool flag6 = this.zoneProgressData_ != null;
			if (flag6)
			{
				num ^= this.ZoneProgressData.GetHashCode();
			}
			num ^= this.commerceSdkPlacementId_.GetHashCode();
			bool flag7 = this._unknownFields != null;
			if (flag7)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003B08 RID: 15112 RVA: 0x000EA334 File Offset: 0x000E8534
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003B09 RID: 15113 RVA: 0x000EA34C File Offset: 0x000E854C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003B0A RID: 15114 RVA: 0x000EA358 File Offset: 0x000E8558
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.accountDigest_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AccountDigest);
			}
			this.heroes_.WriteTo(ref output, GetInitialDataResponse._repeated_heroes_codec);
			bool hasSyncVarCmdLine = this.HasSyncVarCmdLine;
			if (hasSyncVarCmdLine)
			{
				output.WriteRawTag(26);
				output.WriteString(this.SyncVarCmdLine);
			}
			this.accountNotification_.WriteTo(ref output, GetInitialDataResponse._repeated_accountNotification_codec);
			bool flag2 = this.deletedHero_ != null;
			if (flag2)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.DeletedHero);
			}
			bool flag3 = this.playerLicenses_ != null;
			if (flag3)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.PlayerLicenses);
			}
			bool flag4 = this.keys_ != null;
			if (flag4)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Keys);
			}
			bool hasCommerceSdkClientId = this.HasCommerceSdkClientId;
			if (hasCommerceSdkClientId)
			{
				output.WriteRawTag(66);
				output.WriteBytes(this.CommerceSdkClientId);
			}
			bool flag5 = this.settings_ != null;
			if (flag5)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Settings);
			}
			bool hasServiceVersion = this.HasServiceVersion;
			if (hasServiceVersion)
			{
				output.WriteRawTag(82);
				output.WriteString(this.ServiceVersion);
			}
			bool hasContentStackApiKey = this.HasContentStackApiKey;
			if (hasContentStackApiKey)
			{
				output.WriteRawTag(90);
				output.WriteBytes(this.ContentStackApiKey);
			}
			bool hasContentStackDevAccessToken = this.HasContentStackDevAccessToken;
			if (hasContentStackDevAccessToken)
			{
				output.WriteRawTag(98);
				output.WriteBytes(this.ContentStackDevAccessToken);
			}
			bool hasContentStackProdAccessToken = this.HasContentStackProdAccessToken;
			if (hasContentStackProdAccessToken)
			{
				output.WriteRawTag(106);
				output.WriteBytes(this.ContentStackProdAccessToken);
			}
			this.abTestingGroups_.WriteTo(ref output, GetInitialDataResponse._repeated_abTestingGroups_codec);
			bool hasCommerceSdkClientSecret = this.HasCommerceSdkClientSecret;
			if (hasCommerceSdkClientSecret)
			{
				output.WriteRawTag(122);
				output.WriteBytes(this.CommerceSdkClientSecret);
			}
			this.commerceSdkPageId_.WriteTo(ref output, GetInitialDataResponse._repeated_commerceSdkPageId_codec);
			bool flag6 = this.zoneProgressData_ != null;
			if (flag6)
			{
				output.WriteRawTag(138, 1);
				output.WriteMessage(this.ZoneProgressData);
			}
			this.commerceSdkPlacementId_.WriteTo(ref output, GetInitialDataResponse._repeated_commerceSdkPlacementId_codec);
			bool flag7 = this._unknownFields != null;
			if (flag7)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003B0B RID: 15115 RVA: 0x000EA5C0 File Offset: 0x000E87C0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.accountDigest_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountDigest);
			}
			num += this.heroes_.CalculateSize(GetInitialDataResponse._repeated_heroes_codec);
			bool flag2 = this.deletedHero_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DeletedHero);
			}
			bool hasSyncVarCmdLine = this.HasSyncVarCmdLine;
			if (hasSyncVarCmdLine)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SyncVarCmdLine);
			}
			num += this.accountNotification_.CalculateSize(GetInitialDataResponse._repeated_accountNotification_codec);
			bool flag3 = this.playerLicenses_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlayerLicenses);
			}
			bool flag4 = this.keys_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Keys);
			}
			bool hasCommerceSdkClientId = this.HasCommerceSdkClientId;
			if (hasCommerceSdkClientId)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.CommerceSdkClientId);
			}
			bool flag5 = this.settings_ != null;
			if (flag5)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Settings);
			}
			bool hasServiceVersion = this.HasServiceVersion;
			if (hasServiceVersion)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ServiceVersion);
			}
			bool hasContentStackApiKey = this.HasContentStackApiKey;
			if (hasContentStackApiKey)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.ContentStackApiKey);
			}
			bool hasContentStackDevAccessToken = this.HasContentStackDevAccessToken;
			if (hasContentStackDevAccessToken)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.ContentStackDevAccessToken);
			}
			bool hasContentStackProdAccessToken = this.HasContentStackProdAccessToken;
			if (hasContentStackProdAccessToken)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.ContentStackProdAccessToken);
			}
			num += this.abTestingGroups_.CalculateSize(GetInitialDataResponse._repeated_abTestingGroups_codec);
			bool hasCommerceSdkClientSecret = this.HasCommerceSdkClientSecret;
			if (hasCommerceSdkClientSecret)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.CommerceSdkClientSecret);
			}
			num += this.commerceSdkPageId_.CalculateSize(GetInitialDataResponse._repeated_commerceSdkPageId_codec);
			bool flag6 = this.zoneProgressData_ != null;
			if (flag6)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ZoneProgressData);
			}
			num += this.commerceSdkPlacementId_.CalculateSize(GetInitialDataResponse._repeated_commerceSdkPlacementId_codec);
			bool flag7 = this._unknownFields != null;
			if (flag7)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003B0C RID: 15116 RVA: 0x000EA7E8 File Offset: 0x000E89E8
		[DebuggerNonUserCode]
		public void MergeFrom(GetInitialDataResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.accountDigest_ != null;
				if (flag2)
				{
					bool flag3 = this.accountDigest_ == null;
					if (flag3)
					{
						this.AccountDigest = new Fenris.Account.Digest();
					}
					this.AccountDigest.MergeFrom(other.AccountDigest);
				}
				this.heroes_.Add(other.heroes_);
				bool flag4 = other.deletedHero_ != null;
				if (flag4)
				{
					bool flag5 = this.deletedHero_ == null;
					if (flag5)
					{
						this.DeletedHero = new Fenris.Hero.Digest();
					}
					this.DeletedHero.MergeFrom(other.DeletedHero);
				}
				bool hasSyncVarCmdLine = other.HasSyncVarCmdLine;
				if (hasSyncVarCmdLine)
				{
					this.SyncVarCmdLine = other.SyncVarCmdLine;
				}
				this.accountNotification_.Add(other.accountNotification_);
				bool flag6 = other.playerLicenses_ != null;
				if (flag6)
				{
					bool flag7 = this.playerLicenses_ == null;
					if (flag7)
					{
						this.PlayerLicenses = new PlayerLicenses();
					}
					this.PlayerLicenses.MergeFrom(other.PlayerLicenses);
				}
				bool flag8 = other.keys_ != null;
				if (flag8)
				{
					bool flag9 = this.keys_ == null;
					if (flag9)
					{
						this.Keys = new Keys();
					}
					this.Keys.MergeFrom(other.Keys);
				}
				bool hasCommerceSdkClientId = other.HasCommerceSdkClientId;
				if (hasCommerceSdkClientId)
				{
					this.CommerceSdkClientId = other.CommerceSdkClientId;
				}
				bool flag10 = other.settings_ != null;
				if (flag10)
				{
					bool flag11 = this.settings_ == null;
					if (flag11)
					{
						this.Settings = new GameAccountSettings();
					}
					this.Settings.MergeFrom(other.Settings);
				}
				bool hasServiceVersion = other.HasServiceVersion;
				if (hasServiceVersion)
				{
					this.ServiceVersion = other.ServiceVersion;
				}
				bool hasContentStackApiKey = other.HasContentStackApiKey;
				if (hasContentStackApiKey)
				{
					this.ContentStackApiKey = other.ContentStackApiKey;
				}
				bool hasContentStackDevAccessToken = other.HasContentStackDevAccessToken;
				if (hasContentStackDevAccessToken)
				{
					this.ContentStackDevAccessToken = other.ContentStackDevAccessToken;
				}
				bool hasContentStackProdAccessToken = other.HasContentStackProdAccessToken;
				if (hasContentStackProdAccessToken)
				{
					this.ContentStackProdAccessToken = other.ContentStackProdAccessToken;
				}
				this.abTestingGroups_.Add(other.abTestingGroups_);
				bool hasCommerceSdkClientSecret = other.HasCommerceSdkClientSecret;
				if (hasCommerceSdkClientSecret)
				{
					this.CommerceSdkClientSecret = other.CommerceSdkClientSecret;
				}
				this.commerceSdkPageId_.Add(other.commerceSdkPageId_);
				bool flag12 = other.zoneProgressData_ != null;
				if (flag12)
				{
					bool flag13 = this.zoneProgressData_ == null;
					if (flag13)
					{
						this.ZoneProgressData = new ZoneProgressGlobalDataMessage();
					}
					this.ZoneProgressData.MergeFrom(other.ZoneProgressData);
				}
				this.commerceSdkPlacementId_.Add(other.commerceSdkPlacementId_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003B0D RID: 15117 RVA: 0x000EAAAC File Offset: 0x000E8CAC
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003B0E RID: 15118 RVA: 0x000EAAB8 File Offset: 0x000E8CB8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 74U)
				{
					if (num3 <= 34U)
					{
						if (num3 <= 18U)
						{
							if (num3 != 10U)
							{
								if (num3 != 18U)
								{
									goto IL_00F4;
								}
								this.heroes_.AddEntriesFrom(ref input, GetInitialDataResponse._repeated_heroes_codec);
							}
							else
							{
								bool flag = this.accountDigest_ == null;
								if (flag)
								{
									this.AccountDigest = new Fenris.Account.Digest();
								}
								input.ReadMessage(this.AccountDigest);
							}
						}
						else if (num3 != 26U)
						{
							if (num3 != 34U)
							{
								goto IL_00F4;
							}
							this.accountNotification_.AddEntriesFrom(ref input, GetInitialDataResponse._repeated_accountNotification_codec);
						}
						else
						{
							this.SyncVarCmdLine = input.ReadString();
						}
					}
					else if (num3 <= 50U)
					{
						if (num3 != 42U)
						{
							if (num3 != 50U)
							{
								goto IL_00F4;
							}
							bool flag2 = this.playerLicenses_ == null;
							if (flag2)
							{
								this.PlayerLicenses = new PlayerLicenses();
							}
							input.ReadMessage(this.PlayerLicenses);
						}
						else
						{
							bool flag3 = this.deletedHero_ == null;
							if (flag3)
							{
								this.DeletedHero = new Fenris.Hero.Digest();
							}
							input.ReadMessage(this.DeletedHero);
						}
					}
					else if (num3 != 58U)
					{
						if (num3 != 66U)
						{
							if (num3 != 74U)
							{
								goto IL_00F4;
							}
							bool flag4 = this.settings_ == null;
							if (flag4)
							{
								this.Settings = new GameAccountSettings();
							}
							input.ReadMessage(this.Settings);
						}
						else
						{
							this.CommerceSdkClientId = input.ReadBytes();
						}
					}
					else
					{
						bool flag5 = this.keys_ == null;
						if (flag5)
						{
							this.Keys = new Keys();
						}
						input.ReadMessage(this.Keys);
					}
				}
				else if (num3 <= 106U)
				{
					if (num3 <= 90U)
					{
						if (num3 != 82U)
						{
							if (num3 != 90U)
							{
								goto IL_00F4;
							}
							this.ContentStackApiKey = input.ReadBytes();
						}
						else
						{
							this.ServiceVersion = input.ReadString();
						}
					}
					else if (num3 != 98U)
					{
						if (num3 != 106U)
						{
							goto IL_00F4;
						}
						this.ContentStackProdAccessToken = input.ReadBytes();
					}
					else
					{
						this.ContentStackDevAccessToken = input.ReadBytes();
					}
				}
				else if (num3 <= 122U)
				{
					if (num3 != 114U)
					{
						if (num3 != 122U)
						{
							goto IL_00F4;
						}
						this.CommerceSdkClientSecret = input.ReadBytes();
					}
					else
					{
						this.abTestingGroups_.AddEntriesFrom(ref input, GetInitialDataResponse._repeated_abTestingGroups_codec);
					}
				}
				else if (num3 != 130U)
				{
					if (num3 != 138U)
					{
						if (num3 != 146U)
						{
							goto IL_00F4;
						}
						this.commerceSdkPlacementId_.AddEntriesFrom(ref input, GetInitialDataResponse._repeated_commerceSdkPlacementId_codec);
					}
					else
					{
						bool flag6 = this.zoneProgressData_ == null;
						if (flag6)
						{
							this.ZoneProgressData = new ZoneProgressGlobalDataMessage();
						}
						input.ReadMessage(this.ZoneProgressData);
					}
				}
				else
				{
					this.commerceSdkPageId_.AddEntriesFrom(ref input, GetInitialDataResponse._repeated_commerceSdkPageId_codec);
				}
				continue;
				IL_00F4:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001B28 RID: 6952
		private static readonly MessageParser<GetInitialDataResponse> _parser = new MessageParser<GetInitialDataResponse>(() => new GetInitialDataResponse());

		// Token: 0x04001B29 RID: 6953
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001B2A RID: 6954
		public const int AccountDigestFieldNumber = 1;

		// Token: 0x04001B2B RID: 6955
		private Fenris.Account.Digest accountDigest_;

		// Token: 0x04001B2C RID: 6956
		public const int HeroesFieldNumber = 2;

		// Token: 0x04001B2D RID: 6957
		private static readonly FieldCodec<Fenris.Hero.Digest> _repeated_heroes_codec = FieldCodec.ForMessage<Fenris.Hero.Digest>(18U, Fenris.Hero.Digest.Parser);

		// Token: 0x04001B2E RID: 6958
		private readonly RepeatedField<Fenris.Hero.Digest> heroes_ = new RepeatedField<Fenris.Hero.Digest>();

		// Token: 0x04001B2F RID: 6959
		public const int DeletedHeroFieldNumber = 5;

		// Token: 0x04001B30 RID: 6960
		private Fenris.Hero.Digest deletedHero_;

		// Token: 0x04001B31 RID: 6961
		public const int SyncVarCmdLineFieldNumber = 3;

		// Token: 0x04001B32 RID: 6962
		private static readonly string SyncVarCmdLineDefaultValue = "";

		// Token: 0x04001B33 RID: 6963
		private string syncVarCmdLine_;

		// Token: 0x04001B34 RID: 6964
		public const int AccountNotificationFieldNumber = 4;

		// Token: 0x04001B35 RID: 6965
		private static readonly FieldCodec<PlayerNotification> _repeated_accountNotification_codec = FieldCodec.ForMessage<PlayerNotification>(34U, PlayerNotification.Parser);

		// Token: 0x04001B36 RID: 6966
		private readonly RepeatedField<PlayerNotification> accountNotification_ = new RepeatedField<PlayerNotification>();

		// Token: 0x04001B37 RID: 6967
		public const int PlayerLicensesFieldNumber = 6;

		// Token: 0x04001B38 RID: 6968
		private PlayerLicenses playerLicenses_;

		// Token: 0x04001B39 RID: 6969
		public const int KeysFieldNumber = 7;

		// Token: 0x04001B3A RID: 6970
		private Keys keys_;

		// Token: 0x04001B3B RID: 6971
		public const int CommerceSdkClientIdFieldNumber = 8;

		// Token: 0x04001B3C RID: 6972
		private static readonly ByteString CommerceSdkClientIdDefaultValue = ByteString.Empty;

		// Token: 0x04001B3D RID: 6973
		private ByteString commerceSdkClientId_;

		// Token: 0x04001B3E RID: 6974
		public const int SettingsFieldNumber = 9;

		// Token: 0x04001B3F RID: 6975
		private GameAccountSettings settings_;

		// Token: 0x04001B40 RID: 6976
		public const int ServiceVersionFieldNumber = 10;

		// Token: 0x04001B41 RID: 6977
		private static readonly string ServiceVersionDefaultValue = "";

		// Token: 0x04001B42 RID: 6978
		private string serviceVersion_;

		// Token: 0x04001B43 RID: 6979
		public const int ContentStackApiKeyFieldNumber = 11;

		// Token: 0x04001B44 RID: 6980
		private static readonly ByteString ContentStackApiKeyDefaultValue = ByteString.Empty;

		// Token: 0x04001B45 RID: 6981
		private ByteString contentStackApiKey_;

		// Token: 0x04001B46 RID: 6982
		public const int ContentStackDevAccessTokenFieldNumber = 12;

		// Token: 0x04001B47 RID: 6983
		private static readonly ByteString ContentStackDevAccessTokenDefaultValue = ByteString.Empty;

		// Token: 0x04001B48 RID: 6984
		private ByteString contentStackDevAccessToken_;

		// Token: 0x04001B49 RID: 6985
		public const int ContentStackProdAccessTokenFieldNumber = 13;

		// Token: 0x04001B4A RID: 6986
		private static readonly ByteString ContentStackProdAccessTokenDefaultValue = ByteString.Empty;

		// Token: 0x04001B4B RID: 6987
		private ByteString contentStackProdAccessToken_;

		// Token: 0x04001B4C RID: 6988
		public const int AbTestingGroupsFieldNumber = 14;

		// Token: 0x04001B4D RID: 6989
		private static readonly FieldCodec<TestingGroupVariant> _repeated_abTestingGroups_codec = FieldCodec.ForMessage<TestingGroupVariant>(114U, TestingGroupVariant.Parser);

		// Token: 0x04001B4E RID: 6990
		private readonly RepeatedField<TestingGroupVariant> abTestingGroups_ = new RepeatedField<TestingGroupVariant>();

		// Token: 0x04001B4F RID: 6991
		public const int CommerceSdkClientSecretFieldNumber = 15;

		// Token: 0x04001B50 RID: 6992
		private static readonly ByteString CommerceSdkClientSecretDefaultValue = ByteString.Empty;

		// Token: 0x04001B51 RID: 6993
		private ByteString commerceSdkClientSecret_;

		// Token: 0x04001B52 RID: 6994
		public const int CommerceSdkPageIdFieldNumber = 16;

		// Token: 0x04001B53 RID: 6995
		private static readonly FieldCodec<ByteString> _repeated_commerceSdkPageId_codec = FieldCodec.ForBytes(130U);

		// Token: 0x04001B54 RID: 6996
		private readonly RepeatedField<ByteString> commerceSdkPageId_ = new RepeatedField<ByteString>();

		// Token: 0x04001B55 RID: 6997
		public const int ZoneProgressDataFieldNumber = 17;

		// Token: 0x04001B56 RID: 6998
		private ZoneProgressGlobalDataMessage zoneProgressData_;

		// Token: 0x04001B57 RID: 6999
		public const int CommerceSdkPlacementIdFieldNumber = 18;

		// Token: 0x04001B58 RID: 7000
		private static readonly FieldCodec<ByteString> _repeated_commerceSdkPlacementId_codec = FieldCodec.ForBytes(146U);

		// Token: 0x04001B59 RID: 7001
		private readonly RepeatedField<ByteString> commerceSdkPlacementId_ = new RepeatedField<ByteString>();
	}
}
