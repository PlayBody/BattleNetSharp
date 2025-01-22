using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x0200056A RID: 1386
	public sealed class RestoreOptions : IMessage<RestoreOptions>, IMessage, IEquatable<RestoreOptions>, IDeepCloneable<RestoreOptions>, IBufferMessage
	{
		// Token: 0x17002A00 RID: 10752
		// (get) Token: 0x06008539 RID: 34105 RVA: 0x00205FB8 File Offset: 0x002041B8
		[DebuggerNonUserCode]
		public static MessageParser<RestoreOptions> Parser
		{
			get
			{
				return RestoreOptions._parser;
			}
		}

		// Token: 0x17002A01 RID: 10753
		// (get) Token: 0x0600853A RID: 34106 RVA: 0x00205FD0 File Offset: 0x002041D0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002A02 RID: 10754
		// (get) Token: 0x0600853B RID: 34107 RVA: 0x00205FF4 File Offset: 0x002041F4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RestoreOptions.Descriptor;
			}
		}

		// Token: 0x0600853C RID: 34108 RVA: 0x0020600B File Offset: 0x0020420B
		[DebuggerNonUserCode]
		public RestoreOptions()
		{
		}

		// Token: 0x0600853D RID: 34109 RVA: 0x00206018 File Offset: 0x00204218
		[DebuggerNonUserCode]
		public RestoreOptions(RestoreOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clientAddress_ = other.clientAddress_;
			this.macAddress_ = other.macAddress_;
			this.platform_ = other.platform_;
			this.locale_ = other.locale_;
			this.applicationVersion_ = other.applicationVersion_;
			this.userAgent_ = other.userAgent_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600853E RID: 34110 RVA: 0x00206094 File Offset: 0x00204294
		[DebuggerNonUserCode]
		public RestoreOptions Clone()
		{
			return new RestoreOptions(this);
		}

		// Token: 0x17002A03 RID: 10755
		// (get) Token: 0x0600853F RID: 34111 RVA: 0x002060AC File Offset: 0x002042AC
		// (set) Token: 0x06008540 RID: 34112 RVA: 0x002060CD File Offset: 0x002042CD
		[DebuggerNonUserCode]
		public string ClientAddress
		{
			get
			{
				return this.clientAddress_ ?? RestoreOptions.ClientAddressDefaultValue;
			}
			set
			{
				this.clientAddress_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002A04 RID: 10756
		// (get) Token: 0x06008541 RID: 34113 RVA: 0x002060E4 File Offset: 0x002042E4
		[DebuggerNonUserCode]
		public bool HasClientAddress
		{
			get
			{
				return this.clientAddress_ != null;
			}
		}

		// Token: 0x06008542 RID: 34114 RVA: 0x002060FF File Offset: 0x002042FF
		[DebuggerNonUserCode]
		public void ClearClientAddress()
		{
			this.clientAddress_ = null;
		}

		// Token: 0x17002A05 RID: 10757
		// (get) Token: 0x06008543 RID: 34115 RVA: 0x0020610C File Offset: 0x0020430C
		// (set) Token: 0x06008544 RID: 34116 RVA: 0x0020612D File Offset: 0x0020432D
		[DebuggerNonUserCode]
		public string MacAddress
		{
			get
			{
				return this.macAddress_ ?? RestoreOptions.MacAddressDefaultValue;
			}
			set
			{
				this.macAddress_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002A06 RID: 10758
		// (get) Token: 0x06008545 RID: 34117 RVA: 0x00206144 File Offset: 0x00204344
		[DebuggerNonUserCode]
		public bool HasMacAddress
		{
			get
			{
				return this.macAddress_ != null;
			}
		}

		// Token: 0x06008546 RID: 34118 RVA: 0x0020615F File Offset: 0x0020435F
		[DebuggerNonUserCode]
		public void ClearMacAddress()
		{
			this.macAddress_ = null;
		}

		// Token: 0x17002A07 RID: 10759
		// (get) Token: 0x06008547 RID: 34119 RVA: 0x0020616C File Offset: 0x0020436C
		// (set) Token: 0x06008548 RID: 34120 RVA: 0x0020618D File Offset: 0x0020438D
		[DebuggerNonUserCode]
		public string Platform
		{
			get
			{
				return this.platform_ ?? RestoreOptions.PlatformDefaultValue;
			}
			set
			{
				this.platform_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002A08 RID: 10760
		// (get) Token: 0x06008549 RID: 34121 RVA: 0x002061A4 File Offset: 0x002043A4
		[DebuggerNonUserCode]
		public bool HasPlatform
		{
			get
			{
				return this.platform_ != null;
			}
		}

		// Token: 0x0600854A RID: 34122 RVA: 0x002061BF File Offset: 0x002043BF
		[DebuggerNonUserCode]
		public void ClearPlatform()
		{
			this.platform_ = null;
		}

		// Token: 0x17002A09 RID: 10761
		// (get) Token: 0x0600854B RID: 34123 RVA: 0x002061CC File Offset: 0x002043CC
		// (set) Token: 0x0600854C RID: 34124 RVA: 0x002061ED File Offset: 0x002043ED
		[DebuggerNonUserCode]
		public string Locale
		{
			get
			{
				return this.locale_ ?? RestoreOptions.LocaleDefaultValue;
			}
			set
			{
				this.locale_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002A0A RID: 10762
		// (get) Token: 0x0600854D RID: 34125 RVA: 0x00206204 File Offset: 0x00204404
		[DebuggerNonUserCode]
		public bool HasLocale
		{
			get
			{
				return this.locale_ != null;
			}
		}

		// Token: 0x0600854E RID: 34126 RVA: 0x0020621F File Offset: 0x0020441F
		[DebuggerNonUserCode]
		public void ClearLocale()
		{
			this.locale_ = null;
		}

		// Token: 0x17002A0B RID: 10763
		// (get) Token: 0x0600854F RID: 34127 RVA: 0x0020622C File Offset: 0x0020442C
		// (set) Token: 0x06008550 RID: 34128 RVA: 0x0020625D File Offset: 0x0020445D
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
					applicationVersionDefaultValue = RestoreOptions.ApplicationVersionDefaultValue;
				}
				return applicationVersionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.applicationVersion_ = value;
			}
		}

		// Token: 0x17002A0C RID: 10764
		// (get) Token: 0x06008551 RID: 34129 RVA: 0x00206278 File Offset: 0x00204478
		[DebuggerNonUserCode]
		public bool HasApplicationVersion
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008552 RID: 34130 RVA: 0x00206295 File Offset: 0x00204495
		[DebuggerNonUserCode]
		public void ClearApplicationVersion()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002A0D RID: 10765
		// (get) Token: 0x06008553 RID: 34131 RVA: 0x002062A8 File Offset: 0x002044A8
		// (set) Token: 0x06008554 RID: 34132 RVA: 0x002062C9 File Offset: 0x002044C9
		[DebuggerNonUserCode]
		public string UserAgent
		{
			get
			{
				return this.userAgent_ ?? RestoreOptions.UserAgentDefaultValue;
			}
			set
			{
				this.userAgent_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002A0E RID: 10766
		// (get) Token: 0x06008555 RID: 34133 RVA: 0x002062E0 File Offset: 0x002044E0
		[DebuggerNonUserCode]
		public bool HasUserAgent
		{
			get
			{
				return this.userAgent_ != null;
			}
		}

		// Token: 0x06008556 RID: 34134 RVA: 0x002062FB File Offset: 0x002044FB
		[DebuggerNonUserCode]
		public void ClearUserAgent()
		{
			this.userAgent_ = null;
		}

		// Token: 0x06008557 RID: 34135 RVA: 0x00206308 File Offset: 0x00204508
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RestoreOptions);
		}

		// Token: 0x06008558 RID: 34136 RVA: 0x00206328 File Offset: 0x00204528
		[DebuggerNonUserCode]
		public bool Equals(RestoreOptions other)
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
					bool flag4 = this.ClientAddress != other.ClientAddress;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.MacAddress != other.MacAddress;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Platform != other.Platform;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Locale != other.Locale;
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
										flag2 = !flag9 && object.Equals(this._unknownFields, other._unknownFields);
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008559 RID: 34137 RVA: 0x00206414 File Offset: 0x00204614
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClientAddress = this.HasClientAddress;
			if (hasClientAddress)
			{
				num ^= this.ClientAddress.GetHashCode();
			}
			bool hasMacAddress = this.HasMacAddress;
			if (hasMacAddress)
			{
				num ^= this.MacAddress.GetHashCode();
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
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600855A RID: 34138 RVA: 0x002064E4 File Offset: 0x002046E4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600855B RID: 34139 RVA: 0x002064FC File Offset: 0x002046FC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600855C RID: 34140 RVA: 0x00206508 File Offset: 0x00204708
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClientAddress = this.HasClientAddress;
			if (hasClientAddress)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ClientAddress);
			}
			bool hasMacAddress = this.HasMacAddress;
			if (hasMacAddress)
			{
				output.WriteRawTag(18);
				output.WriteString(this.MacAddress);
			}
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Platform);
			}
			bool hasLocale = this.HasLocale;
			if (hasLocale)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Locale);
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
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600855D RID: 34141 RVA: 0x00206604 File Offset: 0x00204804
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClientAddress = this.HasClientAddress;
			if (hasClientAddress)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClientAddress);
			}
			bool hasMacAddress = this.HasMacAddress;
			if (hasMacAddress)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.MacAddress);
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
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600855E RID: 34142 RVA: 0x002066E8 File Offset: 0x002048E8
		[DebuggerNonUserCode]
		public void MergeFrom(RestoreOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClientAddress = other.HasClientAddress;
				if (hasClientAddress)
				{
					this.ClientAddress = other.ClientAddress;
				}
				bool hasMacAddress = other.HasMacAddress;
				if (hasMacAddress)
				{
					this.MacAddress = other.MacAddress;
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
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600855F RID: 34143 RVA: 0x002067B7 File Offset: 0x002049B7
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008560 RID: 34144 RVA: 0x002067C4 File Offset: 0x002049C4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 26U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							if (num3 != 26U)
							{
								goto IL_003A;
							}
							this.Platform = input.ReadString();
						}
						else
						{
							this.MacAddress = input.ReadString();
						}
					}
					else
					{
						this.ClientAddress = input.ReadString();
					}
				}
				else if (num3 != 34U)
				{
					if (num3 != 40U)
					{
						if (num3 != 50U)
						{
							goto IL_003A;
						}
						this.UserAgent = input.ReadString();
					}
					else
					{
						this.ApplicationVersion = input.ReadInt32();
					}
				}
				else
				{
					this.Locale = input.ReadString();
				}
				continue;
				IL_003A:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003C6C RID: 15468
		private static readonly MessageParser<RestoreOptions> _parser = new MessageParser<RestoreOptions>(() => new RestoreOptions());

		// Token: 0x04003C6D RID: 15469
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C6E RID: 15470
		private int _hasBits0;

		// Token: 0x04003C6F RID: 15471
		public const int ClientAddressFieldNumber = 1;

		// Token: 0x04003C70 RID: 15472
		private static readonly string ClientAddressDefaultValue = "";

		// Token: 0x04003C71 RID: 15473
		private string clientAddress_;

		// Token: 0x04003C72 RID: 15474
		public const int MacAddressFieldNumber = 2;

		// Token: 0x04003C73 RID: 15475
		private static readonly string MacAddressDefaultValue = "";

		// Token: 0x04003C74 RID: 15476
		private string macAddress_;

		// Token: 0x04003C75 RID: 15477
		public const int PlatformFieldNumber = 3;

		// Token: 0x04003C76 RID: 15478
		private static readonly string PlatformDefaultValue = "";

		// Token: 0x04003C77 RID: 15479
		private string platform_;

		// Token: 0x04003C78 RID: 15480
		public const int LocaleFieldNumber = 4;

		// Token: 0x04003C79 RID: 15481
		private static readonly string LocaleDefaultValue = "";

		// Token: 0x04003C7A RID: 15482
		private string locale_;

		// Token: 0x04003C7B RID: 15483
		public const int ApplicationVersionFieldNumber = 5;

		// Token: 0x04003C7C RID: 15484
		private static readonly int ApplicationVersionDefaultValue = 0;

		// Token: 0x04003C7D RID: 15485
		private int applicationVersion_;

		// Token: 0x04003C7E RID: 15486
		public const int UserAgentFieldNumber = 6;

		// Token: 0x04003C7F RID: 15487
		private static readonly string UserAgentDefaultValue = "";

		// Token: 0x04003C80 RID: 15488
		private string userAgent_;
	}
}
