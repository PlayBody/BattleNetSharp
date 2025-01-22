using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x0200052F RID: 1327
	public sealed class CreateSessionRequest : IMessage<CreateSessionRequest>, IMessage, IEquatable<CreateSessionRequest>, IDeepCloneable<CreateSessionRequest>, IBufferMessage
	{
		// Token: 0x170028A3 RID: 10403
		// (get) Token: 0x0600806D RID: 32877 RVA: 0x001F46A4 File Offset: 0x001F28A4
		[DebuggerNonUserCode]
		public static MessageParser<CreateSessionRequest> Parser
		{
			get
			{
				return CreateSessionRequest._parser;
			}
		}

		// Token: 0x170028A4 RID: 10404
		// (get) Token: 0x0600806E RID: 32878 RVA: 0x001F46BC File Offset: 0x001F28BC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170028A5 RID: 10405
		// (get) Token: 0x0600806F RID: 32879 RVA: 0x001F46E0 File Offset: 0x001F28E0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateSessionRequest.Descriptor;
			}
		}

		// Token: 0x06008070 RID: 32880 RVA: 0x001F46F7 File Offset: 0x001F28F7
		[DebuggerNonUserCode]
		public CreateSessionRequest()
		{
		}

		// Token: 0x06008071 RID: 32881 RVA: 0x001F4704 File Offset: 0x001F2904
		[DebuggerNonUserCode]
		public CreateSessionRequest(CreateSessionRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.identity_ = ((other.identity_ != null) ? other.identity_.Clone() : null);
			this.platform_ = other.platform_;
			this.locale_ = other.locale_;
			this.clientAddress_ = other.clientAddress_;
			this.applicationVersion_ = other.applicationVersion_;
			this.userAgent_ = other.userAgent_;
			this.sessionKey_ = other.sessionKey_;
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this.requiresMarkAlive_ = other.requiresMarkAlive_;
			this.macAddress_ = other.macAddress_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008072 RID: 32882 RVA: 0x001F47D0 File Offset: 0x001F29D0
		[DebuggerNonUserCode]
		public CreateSessionRequest Clone()
		{
			return new CreateSessionRequest(this);
		}

		// Token: 0x170028A6 RID: 10406
		// (get) Token: 0x06008073 RID: 32883 RVA: 0x001F47E8 File Offset: 0x001F29E8
		// (set) Token: 0x06008074 RID: 32884 RVA: 0x001F4800 File Offset: 0x001F2A00
		[DebuggerNonUserCode]
		public Identity Identity
		{
			get
			{
				return this.identity_;
			}
			set
			{
				this.identity_ = value;
			}
		}

		// Token: 0x170028A7 RID: 10407
		// (get) Token: 0x06008075 RID: 32885 RVA: 0x001F480C File Offset: 0x001F2A0C
		// (set) Token: 0x06008076 RID: 32886 RVA: 0x001F483D File Offset: 0x001F2A3D
		[DebuggerNonUserCode]
		public uint Platform
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint platformDefaultValue;
				if (flag)
				{
					platformDefaultValue = this.platform_;
				}
				else
				{
					platformDefaultValue = CreateSessionRequest.PlatformDefaultValue;
				}
				return platformDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.platform_ = value;
			}
		}

		// Token: 0x170028A8 RID: 10408
		// (get) Token: 0x06008077 RID: 32887 RVA: 0x001F4858 File Offset: 0x001F2A58
		[DebuggerNonUserCode]
		public bool HasPlatform
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008078 RID: 32888 RVA: 0x001F4875 File Offset: 0x001F2A75
		[DebuggerNonUserCode]
		public void ClearPlatform()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170028A9 RID: 10409
		// (get) Token: 0x06008079 RID: 32889 RVA: 0x001F4888 File Offset: 0x001F2A88
		// (set) Token: 0x0600807A RID: 32890 RVA: 0x001F48B9 File Offset: 0x001F2AB9
		[DebuggerNonUserCode]
		public uint Locale
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint localeDefaultValue;
				if (flag)
				{
					localeDefaultValue = this.locale_;
				}
				else
				{
					localeDefaultValue = CreateSessionRequest.LocaleDefaultValue;
				}
				return localeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.locale_ = value;
			}
		}

		// Token: 0x170028AA RID: 10410
		// (get) Token: 0x0600807B RID: 32891 RVA: 0x001F48D4 File Offset: 0x001F2AD4
		[DebuggerNonUserCode]
		public bool HasLocale
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600807C RID: 32892 RVA: 0x001F48F1 File Offset: 0x001F2AF1
		[DebuggerNonUserCode]
		public void ClearLocale()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170028AB RID: 10411
		// (get) Token: 0x0600807D RID: 32893 RVA: 0x001F4904 File Offset: 0x001F2B04
		// (set) Token: 0x0600807E RID: 32894 RVA: 0x001F4925 File Offset: 0x001F2B25
		[DebuggerNonUserCode]
		public string ClientAddress
		{
			get
			{
				return this.clientAddress_ ?? CreateSessionRequest.ClientAddressDefaultValue;
			}
			set
			{
				this.clientAddress_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170028AC RID: 10412
		// (get) Token: 0x0600807F RID: 32895 RVA: 0x001F493C File Offset: 0x001F2B3C
		[DebuggerNonUserCode]
		public bool HasClientAddress
		{
			get
			{
				return this.clientAddress_ != null;
			}
		}

		// Token: 0x06008080 RID: 32896 RVA: 0x001F4957 File Offset: 0x001F2B57
		[DebuggerNonUserCode]
		public void ClearClientAddress()
		{
			this.clientAddress_ = null;
		}

		// Token: 0x170028AD RID: 10413
		// (get) Token: 0x06008081 RID: 32897 RVA: 0x001F4964 File Offset: 0x001F2B64
		// (set) Token: 0x06008082 RID: 32898 RVA: 0x001F4995 File Offset: 0x001F2B95
		[DebuggerNonUserCode]
		public int ApplicationVersion
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int applicationVersionDefaultValue;
				if (flag)
				{
					applicationVersionDefaultValue = this.applicationVersion_;
				}
				else
				{
					applicationVersionDefaultValue = CreateSessionRequest.ApplicationVersionDefaultValue;
				}
				return applicationVersionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.applicationVersion_ = value;
			}
		}

		// Token: 0x170028AE RID: 10414
		// (get) Token: 0x06008083 RID: 32899 RVA: 0x001F49B0 File Offset: 0x001F2BB0
		[DebuggerNonUserCode]
		public bool HasApplicationVersion
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06008084 RID: 32900 RVA: 0x001F49CD File Offset: 0x001F2BCD
		[DebuggerNonUserCode]
		public void ClearApplicationVersion()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170028AF RID: 10415
		// (get) Token: 0x06008085 RID: 32901 RVA: 0x001F49E0 File Offset: 0x001F2BE0
		// (set) Token: 0x06008086 RID: 32902 RVA: 0x001F4A01 File Offset: 0x001F2C01
		[DebuggerNonUserCode]
		public string UserAgent
		{
			get
			{
				return this.userAgent_ ?? CreateSessionRequest.UserAgentDefaultValue;
			}
			set
			{
				this.userAgent_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170028B0 RID: 10416
		// (get) Token: 0x06008087 RID: 32903 RVA: 0x001F4A18 File Offset: 0x001F2C18
		[DebuggerNonUserCode]
		public bool HasUserAgent
		{
			get
			{
				return this.userAgent_ != null;
			}
		}

		// Token: 0x06008088 RID: 32904 RVA: 0x001F4A33 File Offset: 0x001F2C33
		[DebuggerNonUserCode]
		public void ClearUserAgent()
		{
			this.userAgent_ = null;
		}

		// Token: 0x170028B1 RID: 10417
		// (get) Token: 0x06008089 RID: 32905 RVA: 0x001F4A40 File Offset: 0x001F2C40
		// (set) Token: 0x0600808A RID: 32906 RVA: 0x001F4A61 File Offset: 0x001F2C61
		[DebuggerNonUserCode]
		public ByteString SessionKey
		{
			get
			{
				return this.sessionKey_ ?? CreateSessionRequest.SessionKeyDefaultValue;
			}
			set
			{
				this.sessionKey_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x170028B2 RID: 10418
		// (get) Token: 0x0600808B RID: 32907 RVA: 0x001F4A78 File Offset: 0x001F2C78
		[DebuggerNonUserCode]
		public bool HasSessionKey
		{
			get
			{
				return this.sessionKey_ != null;
			}
		}

		// Token: 0x0600808C RID: 32908 RVA: 0x001F4A96 File Offset: 0x001F2C96
		[DebuggerNonUserCode]
		public void ClearSessionKey()
		{
			this.sessionKey_ = null;
		}

		// Token: 0x170028B3 RID: 10419
		// (get) Token: 0x0600808D RID: 32909 RVA: 0x001F4AA0 File Offset: 0x001F2CA0
		// (set) Token: 0x0600808E RID: 32910 RVA: 0x001F4AB8 File Offset: 0x001F2CB8
		[DebuggerNonUserCode]
		public SessionOptions Options
		{
			get
			{
				return this.options_;
			}
			set
			{
				this.options_ = value;
			}
		}

		// Token: 0x170028B4 RID: 10420
		// (get) Token: 0x0600808F RID: 32911 RVA: 0x001F4AC4 File Offset: 0x001F2CC4
		// (set) Token: 0x06008090 RID: 32912 RVA: 0x001F4AF5 File Offset: 0x001F2CF5
		[DebuggerNonUserCode]
		public bool RequiresMarkAlive
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool requiresMarkAliveDefaultValue;
				if (flag)
				{
					requiresMarkAliveDefaultValue = this.requiresMarkAlive_;
				}
				else
				{
					requiresMarkAliveDefaultValue = CreateSessionRequest.RequiresMarkAliveDefaultValue;
				}
				return requiresMarkAliveDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.requiresMarkAlive_ = value;
			}
		}

		// Token: 0x170028B5 RID: 10421
		// (get) Token: 0x06008091 RID: 32913 RVA: 0x001F4B10 File Offset: 0x001F2D10
		[DebuggerNonUserCode]
		public bool HasRequiresMarkAlive
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06008092 RID: 32914 RVA: 0x001F4B2D File Offset: 0x001F2D2D
		[DebuggerNonUserCode]
		public void ClearRequiresMarkAlive()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x170028B6 RID: 10422
		// (get) Token: 0x06008093 RID: 32915 RVA: 0x001F4B40 File Offset: 0x001F2D40
		// (set) Token: 0x06008094 RID: 32916 RVA: 0x001F4B61 File Offset: 0x001F2D61
		[DebuggerNonUserCode]
		public string MacAddress
		{
			get
			{
				return this.macAddress_ ?? CreateSessionRequest.MacAddressDefaultValue;
			}
			set
			{
				this.macAddress_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170028B7 RID: 10423
		// (get) Token: 0x06008095 RID: 32917 RVA: 0x001F4B78 File Offset: 0x001F2D78
		[DebuggerNonUserCode]
		public bool HasMacAddress
		{
			get
			{
				return this.macAddress_ != null;
			}
		}

		// Token: 0x06008096 RID: 32918 RVA: 0x001F4B93 File Offset: 0x001F2D93
		[DebuggerNonUserCode]
		public void ClearMacAddress()
		{
			this.macAddress_ = null;
		}

		// Token: 0x06008097 RID: 32919 RVA: 0x001F4BA0 File Offset: 0x001F2DA0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateSessionRequest);
		}

		// Token: 0x06008098 RID: 32920 RVA: 0x001F4BC0 File Offset: 0x001F2DC0
		[DebuggerNonUserCode]
		public bool Equals(CreateSessionRequest other)
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
					bool flag4 = !object.Equals(this.Identity, other.Identity);
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
								bool flag7 = this.ClientAddress != other.ClientAddress;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.ApplicationVersion != other.ApplicationVersion;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.UserAgent != other.UserAgent;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.SessionKey != other.SessionKey;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !object.Equals(this.Options, other.Options);
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.RequiresMarkAlive != other.RequiresMarkAlive;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.MacAddress != other.MacAddress;
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

		// Token: 0x06008099 RID: 32921 RVA: 0x001F4D28 File Offset: 0x001F2F28
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.identity_ != null;
			if (flag)
			{
				num ^= this.Identity.GetHashCode();
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
			bool hasClientAddress = this.HasClientAddress;
			if (hasClientAddress)
			{
				num ^= this.ClientAddress.GetHashCode();
			}
			bool hasApplicationVersion = this.HasApplicationVersion;
			if (hasApplicationVersion)
			{
				num ^= this.ApplicationVersion.GetHashCode();
			}
			bool hasUserAgent = this.HasUserAgent;
			if (hasUserAgent)
			{
				num ^= this.UserAgent.GetHashCode();
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				num ^= this.SessionKey.GetHashCode();
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				num ^= this.Options.GetHashCode();
			}
			bool hasRequiresMarkAlive = this.HasRequiresMarkAlive;
			if (hasRequiresMarkAlive)
			{
				num ^= this.RequiresMarkAlive.GetHashCode();
			}
			bool hasMacAddress = this.HasMacAddress;
			if (hasMacAddress)
			{
				num ^= this.MacAddress.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600809A RID: 32922 RVA: 0x001F4E74 File Offset: 0x001F3074
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600809B RID: 32923 RVA: 0x001F4E8C File Offset: 0x001F308C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600809C RID: 32924 RVA: 0x001F4E98 File Offset: 0x001F3098
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.identity_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Identity);
			}
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				output.WriteRawTag(21);
				output.WriteFixed32(this.Platform);
			}
			bool hasLocale = this.HasLocale;
			if (hasLocale)
			{
				output.WriteRawTag(29);
				output.WriteFixed32(this.Locale);
			}
			bool hasClientAddress = this.HasClientAddress;
			if (hasClientAddress)
			{
				output.WriteRawTag(34);
				output.WriteString(this.ClientAddress);
			}
			bool hasApplicationVersion = this.HasApplicationVersion;
			if (hasApplicationVersion)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ApplicationVersion);
			}
			bool hasUserAgent = this.HasUserAgent;
			if (hasUserAgent)
			{
				output.WriteRawTag(50);
				output.WriteString(this.UserAgent);
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				output.WriteRawTag(58);
				output.WriteBytes(this.SessionKey);
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Options);
			}
			bool hasRequiresMarkAlive = this.HasRequiresMarkAlive;
			if (hasRequiresMarkAlive)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.RequiresMarkAlive);
			}
			bool hasMacAddress = this.HasMacAddress;
			if (hasMacAddress)
			{
				output.WriteRawTag(82);
				output.WriteString(this.MacAddress);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600809D RID: 32925 RVA: 0x001F502C File Offset: 0x001F322C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.identity_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Identity);
			}
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				num += 5;
			}
			bool hasLocale = this.HasLocale;
			if (hasLocale)
			{
				num += 5;
			}
			bool hasClientAddress = this.HasClientAddress;
			if (hasClientAddress)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClientAddress);
			}
			bool hasApplicationVersion = this.HasApplicationVersion;
			if (hasApplicationVersion)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ApplicationVersion);
			}
			bool hasUserAgent = this.HasUserAgent;
			if (hasUserAgent)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.UserAgent);
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.SessionKey);
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
			}
			bool hasRequiresMarkAlive = this.HasRequiresMarkAlive;
			if (hasRequiresMarkAlive)
			{
				num += 2;
			}
			bool hasMacAddress = this.HasMacAddress;
			if (hasMacAddress)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.MacAddress);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600809E RID: 32926 RVA: 0x001F516C File Offset: 0x001F336C
		[DebuggerNonUserCode]
		public void MergeFrom(CreateSessionRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.identity_ != null;
				if (flag2)
				{
					bool flag3 = this.identity_ == null;
					if (flag3)
					{
						this.Identity = new Identity();
					}
					this.Identity.MergeFrom(other.Identity);
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
				bool hasClientAddress = other.HasClientAddress;
				if (hasClientAddress)
				{
					this.ClientAddress = other.ClientAddress;
				}
				bool hasApplicationVersion = other.HasApplicationVersion;
				if (hasApplicationVersion)
				{
					this.ApplicationVersion = other.ApplicationVersion;
				}
				bool hasUserAgent = other.HasUserAgent;
				if (hasUserAgent)
				{
					this.UserAgent = other.UserAgent;
				}
				bool hasSessionKey = other.HasSessionKey;
				if (hasSessionKey)
				{
					this.SessionKey = other.SessionKey;
				}
				bool flag4 = other.options_ != null;
				if (flag4)
				{
					bool flag5 = this.options_ == null;
					if (flag5)
					{
						this.Options = new SessionOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				bool hasRequiresMarkAlive = other.HasRequiresMarkAlive;
				if (hasRequiresMarkAlive)
				{
					this.RequiresMarkAlive = other.RequiresMarkAlive;
				}
				bool hasMacAddress = other.HasMacAddress;
				if (hasMacAddress)
				{
					this.MacAddress = other.MacAddress;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600809F RID: 32927 RVA: 0x001F52F1 File Offset: 0x001F34F1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060080A0 RID: 32928 RVA: 0x001F52FC File Offset: 0x001F34FC
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
							this.Platform = input.ReadFixed32();
						}
						else
						{
							bool flag = this.identity_ == null;
							if (flag)
							{
								this.Identity = new Identity();
							}
							input.ReadMessage(this.Identity);
						}
					}
					else if (num3 != 29U)
					{
						if (num3 != 34U)
						{
							if (num3 != 40U)
							{
								goto IL_007B;
							}
							this.ApplicationVersion = input.ReadInt32();
						}
						else
						{
							this.ClientAddress = input.ReadString();
						}
					}
					else
					{
						this.Locale = input.ReadFixed32();
					}
				}
				else if (num3 <= 58U)
				{
					if (num3 != 50U)
					{
						if (num3 != 58U)
						{
							goto IL_007B;
						}
						this.SessionKey = input.ReadBytes();
					}
					else
					{
						this.UserAgent = input.ReadString();
					}
				}
				else if (num3 != 66U)
				{
					if (num3 != 72U)
					{
						if (num3 != 82U)
						{
							goto IL_007B;
						}
						this.MacAddress = input.ReadString();
					}
					else
					{
						this.RequiresMarkAlive = input.ReadBool();
					}
				}
				else
				{
					bool flag2 = this.options_ == null;
					if (flag2)
					{
						this.Options = new SessionOptions();
					}
					input.ReadMessage(this.Options);
				}
				continue;
				IL_007B:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003A4B RID: 14923
		private static readonly MessageParser<CreateSessionRequest> _parser = new MessageParser<CreateSessionRequest>(() => new CreateSessionRequest());

		// Token: 0x04003A4C RID: 14924
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A4D RID: 14925
		private int _hasBits0;

		// Token: 0x04003A4E RID: 14926
		public const int IdentityFieldNumber = 1;

		// Token: 0x04003A4F RID: 14927
		private Identity identity_;

		// Token: 0x04003A50 RID: 14928
		public const int PlatformFieldNumber = 2;

		// Token: 0x04003A51 RID: 14929
		private static readonly uint PlatformDefaultValue = 0U;

		// Token: 0x04003A52 RID: 14930
		private uint platform_;

		// Token: 0x04003A53 RID: 14931
		public const int LocaleFieldNumber = 3;

		// Token: 0x04003A54 RID: 14932
		private static readonly uint LocaleDefaultValue = 0U;

		// Token: 0x04003A55 RID: 14933
		private uint locale_;

		// Token: 0x04003A56 RID: 14934
		public const int ClientAddressFieldNumber = 4;

		// Token: 0x04003A57 RID: 14935
		private static readonly string ClientAddressDefaultValue = "";

		// Token: 0x04003A58 RID: 14936
		private string clientAddress_;

		// Token: 0x04003A59 RID: 14937
		public const int ApplicationVersionFieldNumber = 5;

		// Token: 0x04003A5A RID: 14938
		private static readonly int ApplicationVersionDefaultValue = 0;

		// Token: 0x04003A5B RID: 14939
		private int applicationVersion_;

		// Token: 0x04003A5C RID: 14940
		public const int UserAgentFieldNumber = 6;

		// Token: 0x04003A5D RID: 14941
		private static readonly string UserAgentDefaultValue = "";

		// Token: 0x04003A5E RID: 14942
		private string userAgent_;

		// Token: 0x04003A5F RID: 14943
		public const int SessionKeyFieldNumber = 7;

		// Token: 0x04003A60 RID: 14944
		private static readonly ByteString SessionKeyDefaultValue = ByteString.Empty;

		// Token: 0x04003A61 RID: 14945
		private ByteString sessionKey_;

		// Token: 0x04003A62 RID: 14946
		public const int OptionsFieldNumber = 8;

		// Token: 0x04003A63 RID: 14947
		private SessionOptions options_;

		// Token: 0x04003A64 RID: 14948
		public const int RequiresMarkAliveFieldNumber = 9;

		// Token: 0x04003A65 RID: 14949
		private static readonly bool RequiresMarkAliveDefaultValue = false;

		// Token: 0x04003A66 RID: 14950
		private bool requiresMarkAlive_;

		// Token: 0x04003A67 RID: 14951
		public const int MacAddressFieldNumber = 10;

		// Token: 0x04003A68 RID: 14952
		private static readonly string MacAddressDefaultValue = "";

		// Token: 0x04003A69 RID: 14953
		private string macAddress_;
	}
}
