using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V1
{
	// Token: 0x02000608 RID: 1544
	public sealed class LogonRequest : IMessage<LogonRequest>, IMessage, IEquatable<LogonRequest>, IDeepCloneable<LogonRequest>, IBufferMessage
	{
		// Token: 0x17002D1A RID: 11546
		// (get) Token: 0x06009055 RID: 36949 RVA: 0x00230210 File Offset: 0x0022E410
		[DebuggerNonUserCode]
		public static MessageParser<LogonRequest> Parser
		{
			get
			{
				return LogonRequest._parser;
			}
		}

		// Token: 0x17002D1B RID: 11547
		// (get) Token: 0x06009056 RID: 36950 RVA: 0x00230228 File Offset: 0x0022E428
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17002D1C RID: 11548
		// (get) Token: 0x06009057 RID: 36951 RVA: 0x0023024C File Offset: 0x0022E44C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogonRequest.Descriptor;
			}
		}

		// Token: 0x06009058 RID: 36952 RVA: 0x00230263 File Offset: 0x0022E463
		[DebuggerNonUserCode]
		public LogonRequest()
		{
		}

		// Token: 0x06009059 RID: 36953 RVA: 0x00230270 File Offset: 0x0022E470
		[DebuggerNonUserCode]
		public LogonRequest(LogonRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.program_ = other.program_;
			this.platform_ = other.platform_;
			this.locale_ = other.locale_;
			this.email_ = other.email_;
			this.version_ = other.version_;
			this.applicationVersion_ = other.applicationVersion_;
			this.publicComputer_ = other.publicComputer_;
			this.allowLogonQueueNotifications_ = other.allowLogonQueueNotifications_;
			this.webClientVerification_ = other.webClientVerification_;
			this.cachedWebCredentials_ = other.cachedWebCredentials_;
			this.userAgent_ = other.userAgent_;
			this.deviceId_ = other.deviceId_;
			this.phoneNumber_ = other.phoneNumber_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600905A RID: 36954 RVA: 0x00230340 File Offset: 0x0022E540
		[DebuggerNonUserCode]
		public LogonRequest Clone()
		{
			return new LogonRequest(this);
		}

		// Token: 0x17002D1D RID: 11549
		// (get) Token: 0x0600905B RID: 36955 RVA: 0x00230358 File Offset: 0x0022E558
		// (set) Token: 0x0600905C RID: 36956 RVA: 0x00230379 File Offset: 0x0022E579
		[DebuggerNonUserCode]
		public string Program
		{
			get
			{
				return this.program_ ?? LogonRequest.ProgramDefaultValue;
			}
			set
			{
				this.program_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002D1E RID: 11550
		// (get) Token: 0x0600905D RID: 36957 RVA: 0x00230390 File Offset: 0x0022E590
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return this.program_ != null;
			}
		}

		// Token: 0x0600905E RID: 36958 RVA: 0x002303AB File Offset: 0x0022E5AB
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this.program_ = null;
		}

		// Token: 0x17002D1F RID: 11551
		// (get) Token: 0x0600905F RID: 36959 RVA: 0x002303B8 File Offset: 0x0022E5B8
		// (set) Token: 0x06009060 RID: 36960 RVA: 0x002303D9 File Offset: 0x0022E5D9
		[DebuggerNonUserCode]
		public string Platform
		{
			get
			{
				return this.platform_ ?? LogonRequest.PlatformDefaultValue;
			}
			set
			{
				this.platform_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002D20 RID: 11552
		// (get) Token: 0x06009061 RID: 36961 RVA: 0x002303F0 File Offset: 0x0022E5F0
		[DebuggerNonUserCode]
		public bool HasPlatform
		{
			get
			{
				return this.platform_ != null;
			}
		}

		// Token: 0x06009062 RID: 36962 RVA: 0x0023040B File Offset: 0x0022E60B
		[DebuggerNonUserCode]
		public void ClearPlatform()
		{
			this.platform_ = null;
		}

		// Token: 0x17002D21 RID: 11553
		// (get) Token: 0x06009063 RID: 36963 RVA: 0x00230418 File Offset: 0x0022E618
		// (set) Token: 0x06009064 RID: 36964 RVA: 0x00230439 File Offset: 0x0022E639
		[DebuggerNonUserCode]
		public string Locale
		{
			get
			{
				return this.locale_ ?? LogonRequest.LocaleDefaultValue;
			}
			set
			{
				this.locale_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002D22 RID: 11554
		// (get) Token: 0x06009065 RID: 36965 RVA: 0x00230450 File Offset: 0x0022E650
		[DebuggerNonUserCode]
		public bool HasLocale
		{
			get
			{
				return this.locale_ != null;
			}
		}

		// Token: 0x06009066 RID: 36966 RVA: 0x0023046B File Offset: 0x0022E66B
		[DebuggerNonUserCode]
		public void ClearLocale()
		{
			this.locale_ = null;
		}

		// Token: 0x17002D23 RID: 11555
		// (get) Token: 0x06009067 RID: 36967 RVA: 0x00230478 File Offset: 0x0022E678
		// (set) Token: 0x06009068 RID: 36968 RVA: 0x00230499 File Offset: 0x0022E699
		[DebuggerNonUserCode]
		public string Email
		{
			get
			{
				return this.email_ ?? LogonRequest.EmailDefaultValue;
			}
			set
			{
				this.email_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002D24 RID: 11556
		// (get) Token: 0x06009069 RID: 36969 RVA: 0x002304B0 File Offset: 0x0022E6B0
		[DebuggerNonUserCode]
		public bool HasEmail
		{
			get
			{
				return this.email_ != null;
			}
		}

		// Token: 0x0600906A RID: 36970 RVA: 0x002304CB File Offset: 0x0022E6CB
		[DebuggerNonUserCode]
		public void ClearEmail()
		{
			this.email_ = null;
		}

		// Token: 0x17002D25 RID: 11557
		// (get) Token: 0x0600906B RID: 36971 RVA: 0x002304D8 File Offset: 0x0022E6D8
		// (set) Token: 0x0600906C RID: 36972 RVA: 0x002304F9 File Offset: 0x0022E6F9
		[DebuggerNonUserCode]
		public string Version
		{
			get
			{
				return this.version_ ?? LogonRequest.VersionDefaultValue;
			}
			set
			{
				this.version_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002D26 RID: 11558
		// (get) Token: 0x0600906D RID: 36973 RVA: 0x00230510 File Offset: 0x0022E710
		[DebuggerNonUserCode]
		public bool HasVersion
		{
			get
			{
				return this.version_ != null;
			}
		}

		// Token: 0x0600906E RID: 36974 RVA: 0x0023052B File Offset: 0x0022E72B
		[DebuggerNonUserCode]
		public void ClearVersion()
		{
			this.version_ = null;
		}

		// Token: 0x17002D27 RID: 11559
		// (get) Token: 0x0600906F RID: 36975 RVA: 0x00230538 File Offset: 0x0022E738
		// (set) Token: 0x06009070 RID: 36976 RVA: 0x00230569 File Offset: 0x0022E769
		[DebuggerNonUserCode]
		public int ApplicationVersion
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int applicationVersionDefaultValue;
				if (flag)
				{
					applicationVersionDefaultValue = this.applicationVersion_;
				}
				else
				{
					applicationVersionDefaultValue = LogonRequest.ApplicationVersionDefaultValue;
				}
				return applicationVersionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.applicationVersion_ = value;
			}
		}

		// Token: 0x17002D28 RID: 11560
		// (get) Token: 0x06009071 RID: 36977 RVA: 0x00230584 File Offset: 0x0022E784
		[DebuggerNonUserCode]
		public bool HasApplicationVersion
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009072 RID: 36978 RVA: 0x002305A1 File Offset: 0x0022E7A1
		[DebuggerNonUserCode]
		public void ClearApplicationVersion()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002D29 RID: 11561
		// (get) Token: 0x06009073 RID: 36979 RVA: 0x002305B4 File Offset: 0x0022E7B4
		// (set) Token: 0x06009074 RID: 36980 RVA: 0x002305E5 File Offset: 0x0022E7E5
		[DebuggerNonUserCode]
		public bool PublicComputer
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool publicComputerDefaultValue;
				if (flag)
				{
					publicComputerDefaultValue = this.publicComputer_;
				}
				else
				{
					publicComputerDefaultValue = LogonRequest.PublicComputerDefaultValue;
				}
				return publicComputerDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.publicComputer_ = value;
			}
		}

		// Token: 0x17002D2A RID: 11562
		// (get) Token: 0x06009075 RID: 36981 RVA: 0x00230600 File Offset: 0x0022E800
		[DebuggerNonUserCode]
		public bool HasPublicComputer
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06009076 RID: 36982 RVA: 0x0023061D File Offset: 0x0022E81D
		[DebuggerNonUserCode]
		public void ClearPublicComputer()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002D2B RID: 11563
		// (get) Token: 0x06009077 RID: 36983 RVA: 0x00230630 File Offset: 0x0022E830
		// (set) Token: 0x06009078 RID: 36984 RVA: 0x00230661 File Offset: 0x0022E861
		[DebuggerNonUserCode]
		public bool AllowLogonQueueNotifications
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool allowLogonQueueNotificationsDefaultValue;
				if (flag)
				{
					allowLogonQueueNotificationsDefaultValue = this.allowLogonQueueNotifications_;
				}
				else
				{
					allowLogonQueueNotificationsDefaultValue = LogonRequest.AllowLogonQueueNotificationsDefaultValue;
				}
				return allowLogonQueueNotificationsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.allowLogonQueueNotifications_ = value;
			}
		}

		// Token: 0x17002D2C RID: 11564
		// (get) Token: 0x06009079 RID: 36985 RVA: 0x0023067C File Offset: 0x0022E87C
		[DebuggerNonUserCode]
		public bool HasAllowLogonQueueNotifications
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600907A RID: 36986 RVA: 0x00230699 File Offset: 0x0022E899
		[DebuggerNonUserCode]
		public void ClearAllowLogonQueueNotifications()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17002D2D RID: 11565
		// (get) Token: 0x0600907B RID: 36987 RVA: 0x002306AC File Offset: 0x0022E8AC
		// (set) Token: 0x0600907C RID: 36988 RVA: 0x002306DD File Offset: 0x0022E8DD
		[DebuggerNonUserCode]
		public bool WebClientVerification
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool webClientVerificationDefaultValue;
				if (flag)
				{
					webClientVerificationDefaultValue = this.webClientVerification_;
				}
				else
				{
					webClientVerificationDefaultValue = LogonRequest.WebClientVerificationDefaultValue;
				}
				return webClientVerificationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.webClientVerification_ = value;
			}
		}

		// Token: 0x17002D2E RID: 11566
		// (get) Token: 0x0600907D RID: 36989 RVA: 0x002306F8 File Offset: 0x0022E8F8
		[DebuggerNonUserCode]
		public bool HasWebClientVerification
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600907E RID: 36990 RVA: 0x00230715 File Offset: 0x0022E915
		[DebuggerNonUserCode]
		public void ClearWebClientVerification()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17002D2F RID: 11567
		// (get) Token: 0x0600907F RID: 36991 RVA: 0x00230728 File Offset: 0x0022E928
		// (set) Token: 0x06009080 RID: 36992 RVA: 0x00230749 File Offset: 0x0022E949
		[DebuggerNonUserCode]
		public ByteString CachedWebCredentials
		{
			get
			{
				return this.cachedWebCredentials_ ?? LogonRequest.CachedWebCredentialsDefaultValue;
			}
			set
			{
				this.cachedWebCredentials_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17002D30 RID: 11568
		// (get) Token: 0x06009081 RID: 36993 RVA: 0x00230760 File Offset: 0x0022E960
		[DebuggerNonUserCode]
		public bool HasCachedWebCredentials
		{
			get
			{
				return this.cachedWebCredentials_ != null;
			}
		}

		// Token: 0x06009082 RID: 36994 RVA: 0x0023077E File Offset: 0x0022E97E
		[DebuggerNonUserCode]
		public void ClearCachedWebCredentials()
		{
			this.cachedWebCredentials_ = null;
		}

		// Token: 0x17002D31 RID: 11569
		// (get) Token: 0x06009083 RID: 36995 RVA: 0x00230788 File Offset: 0x0022E988
		// (set) Token: 0x06009084 RID: 36996 RVA: 0x002307A9 File Offset: 0x0022E9A9
		[DebuggerNonUserCode]
		public string UserAgent
		{
			get
			{
				return this.userAgent_ ?? LogonRequest.UserAgentDefaultValue;
			}
			set
			{
				this.userAgent_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002D32 RID: 11570
		// (get) Token: 0x06009085 RID: 36997 RVA: 0x002307C0 File Offset: 0x0022E9C0
		[DebuggerNonUserCode]
		public bool HasUserAgent
		{
			get
			{
				return this.userAgent_ != null;
			}
		}

		// Token: 0x06009086 RID: 36998 RVA: 0x002307DB File Offset: 0x0022E9DB
		[DebuggerNonUserCode]
		public void ClearUserAgent()
		{
			this.userAgent_ = null;
		}

		// Token: 0x17002D33 RID: 11571
		// (get) Token: 0x06009087 RID: 36999 RVA: 0x002307E8 File Offset: 0x0022E9E8
		// (set) Token: 0x06009088 RID: 37000 RVA: 0x00230809 File Offset: 0x0022EA09
		[DebuggerNonUserCode]
		public string DeviceId
		{
			get
			{
				return this.deviceId_ ?? LogonRequest.DeviceIdDefaultValue;
			}
			set
			{
				this.deviceId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002D34 RID: 11572
		// (get) Token: 0x06009089 RID: 37001 RVA: 0x00230820 File Offset: 0x0022EA20
		[DebuggerNonUserCode]
		public bool HasDeviceId
		{
			get
			{
				return this.deviceId_ != null;
			}
		}

		// Token: 0x0600908A RID: 37002 RVA: 0x0023083B File Offset: 0x0022EA3B
		[DebuggerNonUserCode]
		public void ClearDeviceId()
		{
			this.deviceId_ = null;
		}

		// Token: 0x17002D35 RID: 11573
		// (get) Token: 0x0600908B RID: 37003 RVA: 0x00230848 File Offset: 0x0022EA48
		// (set) Token: 0x0600908C RID: 37004 RVA: 0x00230869 File Offset: 0x0022EA69
		[DebuggerNonUserCode]
		public string PhoneNumber
		{
			get
			{
				return this.phoneNumber_ ?? LogonRequest.PhoneNumberDefaultValue;
			}
			set
			{
				this.phoneNumber_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002D36 RID: 11574
		// (get) Token: 0x0600908D RID: 37005 RVA: 0x00230880 File Offset: 0x0022EA80
		[DebuggerNonUserCode]
		public bool HasPhoneNumber
		{
			get
			{
				return this.phoneNumber_ != null;
			}
		}

		// Token: 0x0600908E RID: 37006 RVA: 0x0023089B File Offset: 0x0022EA9B
		[DebuggerNonUserCode]
		public void ClearPhoneNumber()
		{
			this.phoneNumber_ = null;
		}

		// Token: 0x0600908F RID: 37007 RVA: 0x002308A8 File Offset: 0x0022EAA8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LogonRequest);
		}

		// Token: 0x06009090 RID: 37008 RVA: 0x002308C8 File Offset: 0x0022EAC8
		[DebuggerNonUserCode]
		public bool Equals(LogonRequest other)
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
					bool flag4 = this.Program != other.Program;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Platform != other.Platform;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Locale != other.Locale;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Email != other.Email;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Version != other.Version;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.ApplicationVersion != other.ApplicationVersion;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.PublicComputer != other.PublicComputer;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.AllowLogonQueueNotifications != other.AllowLogonQueueNotifications;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.WebClientVerification != other.WebClientVerification;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.CachedWebCredentials != other.CachedWebCredentials;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.UserAgent != other.UserAgent;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.DeviceId != other.DeviceId;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = this.PhoneNumber != other.PhoneNumber;
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

		// Token: 0x06009091 RID: 37009 RVA: 0x00230A84 File Offset: 0x0022EC84
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
			}
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				num ^= this.Platform.GetHashCode();
			}
			bool hasLocale = this.HasLocale;
			if (hasLocale)
			{
				num ^= this.Locale.GetHashCode();
			}
			bool hasEmail = this.HasEmail;
			if (hasEmail)
			{
				num ^= this.Email.GetHashCode();
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num ^= this.Version.GetHashCode();
			}
			bool hasApplicationVersion = this.HasApplicationVersion;
			if (hasApplicationVersion)
			{
				num ^= this.ApplicationVersion.GetHashCode();
			}
			bool hasPublicComputer = this.HasPublicComputer;
			if (hasPublicComputer)
			{
				num ^= this.PublicComputer.GetHashCode();
			}
			bool hasAllowLogonQueueNotifications = this.HasAllowLogonQueueNotifications;
			if (hasAllowLogonQueueNotifications)
			{
				num ^= this.AllowLogonQueueNotifications.GetHashCode();
			}
			bool hasWebClientVerification = this.HasWebClientVerification;
			if (hasWebClientVerification)
			{
				num ^= this.WebClientVerification.GetHashCode();
			}
			bool hasCachedWebCredentials = this.HasCachedWebCredentials;
			if (hasCachedWebCredentials)
			{
				num ^= this.CachedWebCredentials.GetHashCode();
			}
			bool hasUserAgent = this.HasUserAgent;
			if (hasUserAgent)
			{
				num ^= this.UserAgent.GetHashCode();
			}
			bool hasDeviceId = this.HasDeviceId;
			if (hasDeviceId)
			{
				num ^= this.DeviceId.GetHashCode();
			}
			bool hasPhoneNumber = this.HasPhoneNumber;
			if (hasPhoneNumber)
			{
				num ^= this.PhoneNumber.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009092 RID: 37010 RVA: 0x00230C18 File Offset: 0x0022EE18
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009093 RID: 37011 RVA: 0x00230C30 File Offset: 0x0022EE30
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009094 RID: 37012 RVA: 0x00230C3C File Offset: 0x0022EE3C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Program);
			}
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Platform);
			}
			bool hasLocale = this.HasLocale;
			if (hasLocale)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Locale);
			}
			bool hasEmail = this.HasEmail;
			if (hasEmail)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Email);
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				output.WriteRawTag(42);
				output.WriteString(this.Version);
			}
			bool hasApplicationVersion = this.HasApplicationVersion;
			if (hasApplicationVersion)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ApplicationVersion);
			}
			bool hasPublicComputer = this.HasPublicComputer;
			if (hasPublicComputer)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.PublicComputer);
			}
			bool hasAllowLogonQueueNotifications = this.HasAllowLogonQueueNotifications;
			if (hasAllowLogonQueueNotifications)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.AllowLogonQueueNotifications);
			}
			bool hasWebClientVerification = this.HasWebClientVerification;
			if (hasWebClientVerification)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.WebClientVerification);
			}
			bool hasCachedWebCredentials = this.HasCachedWebCredentials;
			if (hasCachedWebCredentials)
			{
				output.WriteRawTag(98);
				output.WriteBytes(this.CachedWebCredentials);
			}
			bool hasUserAgent = this.HasUserAgent;
			if (hasUserAgent)
			{
				output.WriteRawTag(114);
				output.WriteString(this.UserAgent);
			}
			bool hasDeviceId = this.HasDeviceId;
			if (hasDeviceId)
			{
				output.WriteRawTag(122);
				output.WriteString(this.DeviceId);
			}
			bool hasPhoneNumber = this.HasPhoneNumber;
			if (hasPhoneNumber)
			{
				output.WriteRawTag(130, 1);
				output.WriteString(this.PhoneNumber);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009095 RID: 37013 RVA: 0x00230E38 File Offset: 0x0022F038
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Program);
			}
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Platform);
			}
			bool hasLocale = this.HasLocale;
			if (hasLocale)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Locale);
			}
			bool hasEmail = this.HasEmail;
			if (hasEmail)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Email);
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Version);
			}
			bool hasApplicationVersion = this.HasApplicationVersion;
			if (hasApplicationVersion)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ApplicationVersion);
			}
			bool hasPublicComputer = this.HasPublicComputer;
			if (hasPublicComputer)
			{
				num += 2;
			}
			bool hasAllowLogonQueueNotifications = this.HasAllowLogonQueueNotifications;
			if (hasAllowLogonQueueNotifications)
			{
				num += 2;
			}
			bool hasWebClientVerification = this.HasWebClientVerification;
			if (hasWebClientVerification)
			{
				num += 2;
			}
			bool hasCachedWebCredentials = this.HasCachedWebCredentials;
			if (hasCachedWebCredentials)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.CachedWebCredentials);
			}
			bool hasUserAgent = this.HasUserAgent;
			if (hasUserAgent)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.UserAgent);
			}
			bool hasDeviceId = this.HasDeviceId;
			if (hasDeviceId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.DeviceId);
			}
			bool hasPhoneNumber = this.HasPhoneNumber;
			if (hasPhoneNumber)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.PhoneNumber);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009096 RID: 37014 RVA: 0x00230FCC File Offset: 0x0022F1CC
		[DebuggerNonUserCode]
		public void MergeFrom(LogonRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				bool hasPlatform = other.HasPlatform;
				if (hasPlatform)
				{
					this.Platform = other.Platform;
				}
				bool hasLocale = other.HasLocale;
				if (hasLocale)
				{
					this.Locale = other.Locale;
				}
				bool hasEmail = other.HasEmail;
				if (hasEmail)
				{
					this.Email = other.Email;
				}
				bool hasVersion = other.HasVersion;
				if (hasVersion)
				{
					this.Version = other.Version;
				}
				bool hasApplicationVersion = other.HasApplicationVersion;
				if (hasApplicationVersion)
				{
					this.ApplicationVersion = other.ApplicationVersion;
				}
				bool hasPublicComputer = other.HasPublicComputer;
				if (hasPublicComputer)
				{
					this.PublicComputer = other.PublicComputer;
				}
				bool hasAllowLogonQueueNotifications = other.HasAllowLogonQueueNotifications;
				if (hasAllowLogonQueueNotifications)
				{
					this.AllowLogonQueueNotifications = other.AllowLogonQueueNotifications;
				}
				bool hasWebClientVerification = other.HasWebClientVerification;
				if (hasWebClientVerification)
				{
					this.WebClientVerification = other.WebClientVerification;
				}
				bool hasCachedWebCredentials = other.HasCachedWebCredentials;
				if (hasCachedWebCredentials)
				{
					this.CachedWebCredentials = other.CachedWebCredentials;
				}
				bool hasUserAgent = other.HasUserAgent;
				if (hasUserAgent)
				{
					this.UserAgent = other.UserAgent;
				}
				bool hasDeviceId = other.HasDeviceId;
				if (hasDeviceId)
				{
					this.DeviceId = other.DeviceId;
				}
				bool hasPhoneNumber = other.HasPhoneNumber;
				if (hasPhoneNumber)
				{
					this.PhoneNumber = other.PhoneNumber;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009097 RID: 37015 RVA: 0x00231158 File Offset: 0x0022F358
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009098 RID: 37016 RVA: 0x00231164 File Offset: 0x0022F364
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
									goto IL_00A4;
								}
								this.Locale = input.ReadString();
							}
							else
							{
								this.Platform = input.ReadString();
							}
						}
						else
						{
							this.Program = input.ReadString();
						}
					}
					else if (num3 != 34U)
					{
						if (num3 != 42U)
						{
							if (num3 != 48U)
							{
								goto IL_00A4;
							}
							this.ApplicationVersion = input.ReadInt32();
						}
						else
						{
							this.Version = input.ReadString();
						}
					}
					else
					{
						this.Email = input.ReadString();
					}
				}
				else if (num3 <= 88U)
				{
					if (num3 != 56U)
					{
						if (num3 != 80U)
						{
							if (num3 != 88U)
							{
								goto IL_00A4;
							}
							this.WebClientVerification = input.ReadBool();
						}
						else
						{
							this.AllowLogonQueueNotifications = input.ReadBool();
						}
					}
					else
					{
						this.PublicComputer = input.ReadBool();
					}
				}
				else if (num3 <= 114U)
				{
					if (num3 != 98U)
					{
						if (num3 != 114U)
						{
							goto IL_00A4;
						}
						this.UserAgent = input.ReadString();
					}
					else
					{
						this.CachedWebCredentials = input.ReadBytes();
					}
				}
				else if (num3 != 122U)
				{
					if (num3 != 130U)
					{
						goto IL_00A4;
					}
					this.PhoneNumber = input.ReadString();
				}
				else
				{
					this.DeviceId = input.ReadString();
				}
				continue;
				IL_00A4:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004122 RID: 16674
		private static readonly MessageParser<LogonRequest> _parser = new MessageParser<LogonRequest>(() => new LogonRequest());

		// Token: 0x04004123 RID: 16675
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004124 RID: 16676
		private int _hasBits0;

		// Token: 0x04004125 RID: 16677
		public const int ProgramFieldNumber = 1;

		// Token: 0x04004126 RID: 16678
		private static readonly string ProgramDefaultValue = "";

		// Token: 0x04004127 RID: 16679
		private string program_;

		// Token: 0x04004128 RID: 16680
		public const int PlatformFieldNumber = 2;

		// Token: 0x04004129 RID: 16681
		private static readonly string PlatformDefaultValue = "";

		// Token: 0x0400412A RID: 16682
		private string platform_;

		// Token: 0x0400412B RID: 16683
		public const int LocaleFieldNumber = 3;

		// Token: 0x0400412C RID: 16684
		private static readonly string LocaleDefaultValue = "";

		// Token: 0x0400412D RID: 16685
		private string locale_;

		// Token: 0x0400412E RID: 16686
		public const int EmailFieldNumber = 4;

		// Token: 0x0400412F RID: 16687
		private static readonly string EmailDefaultValue = "";

		// Token: 0x04004130 RID: 16688
		private string email_;

		// Token: 0x04004131 RID: 16689
		public const int VersionFieldNumber = 5;

		// Token: 0x04004132 RID: 16690
		private static readonly string VersionDefaultValue = "";

		// Token: 0x04004133 RID: 16691
		private string version_;

		// Token: 0x04004134 RID: 16692
		public const int ApplicationVersionFieldNumber = 6;

		// Token: 0x04004135 RID: 16693
		private static readonly int ApplicationVersionDefaultValue = 0;

		// Token: 0x04004136 RID: 16694
		private int applicationVersion_;

		// Token: 0x04004137 RID: 16695
		public const int PublicComputerFieldNumber = 7;

		// Token: 0x04004138 RID: 16696
		private static readonly bool PublicComputerDefaultValue = false;

		// Token: 0x04004139 RID: 16697
		private bool publicComputer_;

		// Token: 0x0400413A RID: 16698
		public const int AllowLogonQueueNotificationsFieldNumber = 10;

		// Token: 0x0400413B RID: 16699
		private static readonly bool AllowLogonQueueNotificationsDefaultValue = false;

		// Token: 0x0400413C RID: 16700
		private bool allowLogonQueueNotifications_;

		// Token: 0x0400413D RID: 16701
		public const int WebClientVerificationFieldNumber = 11;

		// Token: 0x0400413E RID: 16702
		private static readonly bool WebClientVerificationDefaultValue = false;

		// Token: 0x0400413F RID: 16703
		private bool webClientVerification_;

		// Token: 0x04004140 RID: 16704
		public const int CachedWebCredentialsFieldNumber = 12;

		// Token: 0x04004141 RID: 16705
		private static readonly ByteString CachedWebCredentialsDefaultValue = ByteString.Empty;

		// Token: 0x04004142 RID: 16706
		private ByteString cachedWebCredentials_;

		// Token: 0x04004143 RID: 16707
		public const int UserAgentFieldNumber = 14;

		// Token: 0x04004144 RID: 16708
		private static readonly string UserAgentDefaultValue = "";

		// Token: 0x04004145 RID: 16709
		private string userAgent_;

		// Token: 0x04004146 RID: 16710
		public const int DeviceIdFieldNumber = 15;

		// Token: 0x04004147 RID: 16711
		private static readonly string DeviceIdDefaultValue = "";

		// Token: 0x04004148 RID: 16712
		private string deviceId_;

		// Token: 0x04004149 RID: 16713
		public const int PhoneNumberFieldNumber = 16;

		// Token: 0x0400414A RID: 16714
		private static readonly string PhoneNumberDefaultValue = "";

		// Token: 0x0400414B RID: 16715
		private string phoneNumber_;
	}
}
