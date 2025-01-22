using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V2.Client
{
	// Token: 0x02000621 RID: 1569
	public sealed class LogonRequest : IMessage<LogonRequest>, IMessage, IEquatable<LogonRequest>, IDeepCloneable<LogonRequest>, IBufferMessage
	{
		// Token: 0x17002DC7 RID: 11719
		// (get) Token: 0x06009294 RID: 37524 RVA: 0x00238544 File Offset: 0x00236744
		[DebuggerNonUserCode]
		public static MessageParser<LogonRequest> Parser
		{
			get
			{
				return LogonRequest._parser;
			}
		}

		// Token: 0x17002DC8 RID: 11720
		// (get) Token: 0x06009295 RID: 37525 RVA: 0x0023855C File Offset: 0x0023675C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002DC9 RID: 11721
		// (get) Token: 0x06009296 RID: 37526 RVA: 0x00238580 File Offset: 0x00236780
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogonRequest.Descriptor;
			}
		}

		// Token: 0x06009297 RID: 37527 RVA: 0x00238597 File Offset: 0x00236797
		[DebuggerNonUserCode]
		public LogonRequest()
		{
		}

		// Token: 0x06009298 RID: 37528 RVA: 0x002385A4 File Offset: 0x002367A4
		[DebuggerNonUserCode]
		public LogonRequest(LogonRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.titleId_ = other.titleId_;
			this.platform_ = other.platform_;
			this.locale_ = other.locale_;
			this.applicationVersion_ = other.applicationVersion_;
			this.logonOptions_ = ((other.logonOptions_ != null) ? other.logonOptions_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009299 RID: 37529 RVA: 0x00238624 File Offset: 0x00236824
		[DebuggerNonUserCode]
		public LogonRequest Clone()
		{
			return new LogonRequest(this);
		}

		// Token: 0x17002DCA RID: 11722
		// (get) Token: 0x0600929A RID: 37530 RVA: 0x0023863C File Offset: 0x0023683C
		// (set) Token: 0x0600929B RID: 37531 RVA: 0x0023866D File Offset: 0x0023686D
		[DebuggerNonUserCode]
		public uint TitleId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint titleIdDefaultValue;
				if (flag)
				{
					titleIdDefaultValue = this.titleId_;
				}
				else
				{
					titleIdDefaultValue = LogonRequest.TitleIdDefaultValue;
				}
				return titleIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.titleId_ = value;
			}
		}

		// Token: 0x17002DCB RID: 11723
		// (get) Token: 0x0600929C RID: 37532 RVA: 0x00238688 File Offset: 0x00236888
		[DebuggerNonUserCode]
		public bool HasTitleId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600929D RID: 37533 RVA: 0x002386A5 File Offset: 0x002368A5
		[DebuggerNonUserCode]
		public void ClearTitleId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002DCC RID: 11724
		// (get) Token: 0x0600929E RID: 37534 RVA: 0x002386B8 File Offset: 0x002368B8
		// (set) Token: 0x0600929F RID: 37535 RVA: 0x002386D9 File Offset: 0x002368D9
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

		// Token: 0x17002DCD RID: 11725
		// (get) Token: 0x060092A0 RID: 37536 RVA: 0x002386F0 File Offset: 0x002368F0
		[DebuggerNonUserCode]
		public bool HasPlatform
		{
			get
			{
				return this.platform_ != null;
			}
		}

		// Token: 0x060092A1 RID: 37537 RVA: 0x0023870B File Offset: 0x0023690B
		[DebuggerNonUserCode]
		public void ClearPlatform()
		{
			this.platform_ = null;
		}

		// Token: 0x17002DCE RID: 11726
		// (get) Token: 0x060092A2 RID: 37538 RVA: 0x00238718 File Offset: 0x00236918
		// (set) Token: 0x060092A3 RID: 37539 RVA: 0x00238739 File Offset: 0x00236939
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

		// Token: 0x17002DCF RID: 11727
		// (get) Token: 0x060092A4 RID: 37540 RVA: 0x00238750 File Offset: 0x00236950
		[DebuggerNonUserCode]
		public bool HasLocale
		{
			get
			{
				return this.locale_ != null;
			}
		}

		// Token: 0x060092A5 RID: 37541 RVA: 0x0023876B File Offset: 0x0023696B
		[DebuggerNonUserCode]
		public void ClearLocale()
		{
			this.locale_ = null;
		}

		// Token: 0x17002DD0 RID: 11728
		// (get) Token: 0x060092A6 RID: 37542 RVA: 0x00238778 File Offset: 0x00236978
		// (set) Token: 0x060092A7 RID: 37543 RVA: 0x002387A9 File Offset: 0x002369A9
		[DebuggerNonUserCode]
		public uint ApplicationVersion
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint applicationVersionDefaultValue;
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
				this._hasBits0 |= 2;
				this.applicationVersion_ = value;
			}
		}

		// Token: 0x17002DD1 RID: 11729
		// (get) Token: 0x060092A8 RID: 37544 RVA: 0x002387C4 File Offset: 0x002369C4
		[DebuggerNonUserCode]
		public bool HasApplicationVersion
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060092A9 RID: 37545 RVA: 0x002387E1 File Offset: 0x002369E1
		[DebuggerNonUserCode]
		public void ClearApplicationVersion()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002DD2 RID: 11730
		// (get) Token: 0x060092AA RID: 37546 RVA: 0x002387F4 File Offset: 0x002369F4
		// (set) Token: 0x060092AB RID: 37547 RVA: 0x0023880C File Offset: 0x00236A0C
		[DebuggerNonUserCode]
		public LogonOptions LogonOptions
		{
			get
			{
				return this.logonOptions_;
			}
			set
			{
				this.logonOptions_ = value;
			}
		}

		// Token: 0x060092AC RID: 37548 RVA: 0x00238818 File Offset: 0x00236A18
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LogonRequest);
		}

		// Token: 0x060092AD RID: 37549 RVA: 0x00238838 File Offset: 0x00236A38
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
					bool flag4 = this.TitleId != other.TitleId;
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
								bool flag7 = this.ApplicationVersion != other.ApplicationVersion;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.LogonOptions, other.LogonOptions);
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060092AE RID: 37550 RVA: 0x00238908 File Offset: 0x00236B08
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTitleId = this.HasTitleId;
			if (hasTitleId)
			{
				num ^= this.TitleId.GetHashCode();
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
			bool flag = this.logonOptions_ != null;
			if (flag)
			{
				num ^= this.LogonOptions.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060092AF RID: 37551 RVA: 0x002389C8 File Offset: 0x00236BC8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060092B0 RID: 37552 RVA: 0x002389E0 File Offset: 0x00236BE0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060092B1 RID: 37553 RVA: 0x002389EC File Offset: 0x00236BEC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTitleId = this.HasTitleId;
			if (hasTitleId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.TitleId);
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
			bool hasApplicationVersion = this.HasApplicationVersion;
			if (hasApplicationVersion)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.ApplicationVersion);
			}
			bool flag = this.logonOptions_ != null;
			if (flag)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.LogonOptions);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060092B2 RID: 37554 RVA: 0x00238AC8 File Offset: 0x00236CC8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTitleId = this.HasTitleId;
			if (hasTitleId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TitleId);
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
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ApplicationVersion);
			}
			bool flag = this.logonOptions_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LogonOptions);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060092B3 RID: 37555 RVA: 0x00238B94 File Offset: 0x00236D94
		[DebuggerNonUserCode]
		public void MergeFrom(LogonRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTitleId = other.HasTitleId;
				if (hasTitleId)
				{
					this.TitleId = other.TitleId;
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
				bool flag2 = other.logonOptions_ != null;
				if (flag2)
				{
					bool flag3 = this.logonOptions_ == null;
					if (flag3)
					{
						this.LogonOptions = new LogonOptions();
					}
					this.LogonOptions.MergeFrom(other.LogonOptions);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060092B4 RID: 37556 RVA: 0x00238C6D File Offset: 0x00236E6D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060092B5 RID: 37557 RVA: 0x00238C78 File Offset: 0x00236E78
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 8U)
					{
						if (num3 != 18U)
						{
							goto IL_0032;
						}
						this.Platform = input.ReadString();
					}
					else
					{
						this.TitleId = input.ReadUInt32();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 32U)
					{
						if (num3 != 82U)
						{
							goto IL_0032;
						}
						bool flag = this.logonOptions_ == null;
						if (flag)
						{
							this.LogonOptions = new LogonOptions();
						}
						input.ReadMessage(this.LogonOptions);
					}
					else
					{
						this.ApplicationVersion = input.ReadUInt32();
					}
				}
				else
				{
					this.Locale = input.ReadString();
				}
				continue;
				IL_0032:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004236 RID: 16950
		private static readonly MessageParser<LogonRequest> _parser = new MessageParser<LogonRequest>(() => new LogonRequest());

		// Token: 0x04004237 RID: 16951
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004238 RID: 16952
		private int _hasBits0;

		// Token: 0x04004239 RID: 16953
		public const int TitleIdFieldNumber = 1;

		// Token: 0x0400423A RID: 16954
		private static readonly uint TitleIdDefaultValue = 0U;

		// Token: 0x0400423B RID: 16955
		private uint titleId_;

		// Token: 0x0400423C RID: 16956
		public const int PlatformFieldNumber = 2;

		// Token: 0x0400423D RID: 16957
		private static readonly string PlatformDefaultValue = "";

		// Token: 0x0400423E RID: 16958
		private string platform_;

		// Token: 0x0400423F RID: 16959
		public const int LocaleFieldNumber = 3;

		// Token: 0x04004240 RID: 16960
		private static readonly string LocaleDefaultValue = "";

		// Token: 0x04004241 RID: 16961
		private string locale_;

		// Token: 0x04004242 RID: 16962
		public const int ApplicationVersionFieldNumber = 4;

		// Token: 0x04004243 RID: 16963
		private static readonly uint ApplicationVersionDefaultValue = 0U;

		// Token: 0x04004244 RID: 16964
		private uint applicationVersion_;

		// Token: 0x04004245 RID: 16965
		public const int LogonOptionsFieldNumber = 10;

		// Token: 0x04004246 RID: 16966
		private LogonOptions logonOptions_;
	}
}
