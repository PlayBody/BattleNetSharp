using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V2.Client
{
	// Token: 0x02000627 RID: 1575
	public sealed class LogonOptions : IMessage<LogonOptions>, IMessage, IEquatable<LogonOptions>, IDeepCloneable<LogonOptions>, IBufferMessage
	{
		// Token: 0x17002DE4 RID: 11748
		// (get) Token: 0x060092FE RID: 37630 RVA: 0x00239C04 File Offset: 0x00237E04
		[DebuggerNonUserCode]
		public static MessageParser<LogonOptions> Parser
		{
			get
			{
				return LogonOptions._parser;
			}
		}

		// Token: 0x17002DE5 RID: 11749
		// (get) Token: 0x060092FF RID: 37631 RVA: 0x00239C1C File Offset: 0x00237E1C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002DE6 RID: 11750
		// (get) Token: 0x06009300 RID: 37632 RVA: 0x00239C40 File Offset: 0x00237E40
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogonOptions.Descriptor;
			}
		}

		// Token: 0x06009301 RID: 37633 RVA: 0x00239C57 File Offset: 0x00237E57
		[DebuggerNonUserCode]
		public LogonOptions()
		{
		}

		// Token: 0x06009302 RID: 37634 RVA: 0x00239C68 File Offset: 0x00237E68
		[DebuggerNonUserCode]
		public LogonOptions(LogonOptions other)
			: this()
		{
			this.authToken_ = other.authToken_;
			this.userAgent_ = other.userAgent_;
			this.deviceId_ = other.deviceId_;
			LogonOptions.AdditionalIdOneofCase additionalIdCase = other.AdditionalIdCase;
			LogonOptions.AdditionalIdOneofCase additionalIdOneofCase = additionalIdCase;
			if (additionalIdOneofCase != LogonOptions.AdditionalIdOneofCase.Email)
			{
				if (additionalIdOneofCase == LogonOptions.AdditionalIdOneofCase.PhoneNumber)
				{
					this.PhoneNumber = other.PhoneNumber;
				}
			}
			else
			{
				this.Email = other.Email;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009303 RID: 37635 RVA: 0x00239CE8 File Offset: 0x00237EE8
		[DebuggerNonUserCode]
		public LogonOptions Clone()
		{
			return new LogonOptions(this);
		}

		// Token: 0x17002DE7 RID: 11751
		// (get) Token: 0x06009304 RID: 37636 RVA: 0x00239D00 File Offset: 0x00237F00
		// (set) Token: 0x06009305 RID: 37637 RVA: 0x00239D21 File Offset: 0x00237F21
		[DebuggerNonUserCode]
		public ByteString AuthToken
		{
			get
			{
				return this.authToken_ ?? LogonOptions.AuthTokenDefaultValue;
			}
			set
			{
				this.authToken_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17002DE8 RID: 11752
		// (get) Token: 0x06009306 RID: 37638 RVA: 0x00239D38 File Offset: 0x00237F38
		[DebuggerNonUserCode]
		public bool HasAuthToken
		{
			get
			{
				return this.authToken_ != null;
			}
		}

		// Token: 0x06009307 RID: 37639 RVA: 0x00239D56 File Offset: 0x00237F56
		[DebuggerNonUserCode]
		public void ClearAuthToken()
		{
			this.authToken_ = null;
		}

		// Token: 0x17002DE9 RID: 11753
		// (get) Token: 0x06009308 RID: 37640 RVA: 0x00239D60 File Offset: 0x00237F60
		// (set) Token: 0x06009309 RID: 37641 RVA: 0x00239D81 File Offset: 0x00237F81
		[DebuggerNonUserCode]
		public string UserAgent
		{
			get
			{
				return this.userAgent_ ?? LogonOptions.UserAgentDefaultValue;
			}
			set
			{
				this.userAgent_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002DEA RID: 11754
		// (get) Token: 0x0600930A RID: 37642 RVA: 0x00239D98 File Offset: 0x00237F98
		[DebuggerNonUserCode]
		public bool HasUserAgent
		{
			get
			{
				return this.userAgent_ != null;
			}
		}

		// Token: 0x0600930B RID: 37643 RVA: 0x00239DB3 File Offset: 0x00237FB3
		[DebuggerNonUserCode]
		public void ClearUserAgent()
		{
			this.userAgent_ = null;
		}

		// Token: 0x17002DEB RID: 11755
		// (get) Token: 0x0600930C RID: 37644 RVA: 0x00239DC0 File Offset: 0x00237FC0
		// (set) Token: 0x0600930D RID: 37645 RVA: 0x00239DE1 File Offset: 0x00237FE1
		[DebuggerNonUserCode]
		public string DeviceId
		{
			get
			{
				return this.deviceId_ ?? LogonOptions.DeviceIdDefaultValue;
			}
			set
			{
				this.deviceId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002DEC RID: 11756
		// (get) Token: 0x0600930E RID: 37646 RVA: 0x00239DF8 File Offset: 0x00237FF8
		[DebuggerNonUserCode]
		public bool HasDeviceId
		{
			get
			{
				return this.deviceId_ != null;
			}
		}

		// Token: 0x0600930F RID: 37647 RVA: 0x00239E13 File Offset: 0x00238013
		[DebuggerNonUserCode]
		public void ClearDeviceId()
		{
			this.deviceId_ = null;
		}

		// Token: 0x17002DED RID: 11757
		// (get) Token: 0x06009310 RID: 37648 RVA: 0x00239E20 File Offset: 0x00238020
		// (set) Token: 0x06009311 RID: 37649 RVA: 0x00239E4C File Offset: 0x0023804C
		[DebuggerNonUserCode]
		public string Email
		{
			get
			{
				return this.HasEmail ? ((string)this.additionalId_) : "";
			}
			set
			{
				this.additionalId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
				this.additionalIdCase_ = LogonOptions.AdditionalIdOneofCase.Email;
			}
		}

		// Token: 0x17002DEE RID: 11758
		// (get) Token: 0x06009312 RID: 37650 RVA: 0x00239E68 File Offset: 0x00238068
		[DebuggerNonUserCode]
		public bool HasEmail
		{
			get
			{
				return this.additionalIdCase_ == LogonOptions.AdditionalIdOneofCase.Email;
			}
		}

		// Token: 0x06009313 RID: 37651 RVA: 0x00239E84 File Offset: 0x00238084
		[DebuggerNonUserCode]
		public void ClearEmail()
		{
			bool hasEmail = this.HasEmail;
			if (hasEmail)
			{
				this.ClearAdditionalId();
			}
		}

		// Token: 0x17002DEF RID: 11759
		// (get) Token: 0x06009314 RID: 37652 RVA: 0x00239EA8 File Offset: 0x002380A8
		// (set) Token: 0x06009315 RID: 37653 RVA: 0x00239ED4 File Offset: 0x002380D4
		[DebuggerNonUserCode]
		public string PhoneNumber
		{
			get
			{
				return this.HasPhoneNumber ? ((string)this.additionalId_) : "";
			}
			set
			{
				this.additionalId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
				this.additionalIdCase_ = LogonOptions.AdditionalIdOneofCase.PhoneNumber;
			}
		}

		// Token: 0x17002DF0 RID: 11760
		// (get) Token: 0x06009316 RID: 37654 RVA: 0x00239EF0 File Offset: 0x002380F0
		[DebuggerNonUserCode]
		public bool HasPhoneNumber
		{
			get
			{
				return this.additionalIdCase_ == LogonOptions.AdditionalIdOneofCase.PhoneNumber;
			}
		}

		// Token: 0x06009317 RID: 37655 RVA: 0x00239F0C File Offset: 0x0023810C
		[DebuggerNonUserCode]
		public void ClearPhoneNumber()
		{
			bool hasPhoneNumber = this.HasPhoneNumber;
			if (hasPhoneNumber)
			{
				this.ClearAdditionalId();
			}
		}

		// Token: 0x17002DF1 RID: 11761
		// (get) Token: 0x06009318 RID: 37656 RVA: 0x00239F30 File Offset: 0x00238130
		[DebuggerNonUserCode]
		public LogonOptions.AdditionalIdOneofCase AdditionalIdCase
		{
			get
			{
				return this.additionalIdCase_;
			}
		}

		// Token: 0x06009319 RID: 37657 RVA: 0x00239F48 File Offset: 0x00238148
		[DebuggerNonUserCode]
		public void ClearAdditionalId()
		{
			this.additionalIdCase_ = LogonOptions.AdditionalIdOneofCase.None;
			this.additionalId_ = null;
		}

		// Token: 0x0600931A RID: 37658 RVA: 0x00239F5C File Offset: 0x0023815C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LogonOptions);
		}

		// Token: 0x0600931B RID: 37659 RVA: 0x00239F7C File Offset: 0x0023817C
		[DebuggerNonUserCode]
		public bool Equals(LogonOptions other)
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
					bool flag4 = this.AuthToken != other.AuthToken;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.UserAgent != other.UserAgent;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.DeviceId != other.DeviceId;
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
									bool flag8 = this.PhoneNumber != other.PhoneNumber;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.AdditionalIdCase != other.AdditionalIdCase;
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

		// Token: 0x0600931C RID: 37660 RVA: 0x0023A068 File Offset: 0x00238268
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAuthToken = this.HasAuthToken;
			if (hasAuthToken)
			{
				num ^= this.AuthToken.GetHashCode();
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
			bool hasEmail = this.HasEmail;
			if (hasEmail)
			{
				num ^= this.Email.GetHashCode();
			}
			bool hasPhoneNumber = this.HasPhoneNumber;
			if (hasPhoneNumber)
			{
				num ^= this.PhoneNumber.GetHashCode();
			}
			num ^= (int)this.additionalIdCase_;
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600931D RID: 37661 RVA: 0x0023A124 File Offset: 0x00238324
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600931E RID: 37662 RVA: 0x0023A13C File Offset: 0x0023833C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600931F RID: 37663 RVA: 0x0023A148 File Offset: 0x00238348
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAuthToken = this.HasAuthToken;
			if (hasAuthToken)
			{
				output.WriteRawTag(10);
				output.WriteBytes(this.AuthToken);
			}
			bool hasUserAgent = this.HasUserAgent;
			if (hasUserAgent)
			{
				output.WriteRawTag(18);
				output.WriteString(this.UserAgent);
			}
			bool hasDeviceId = this.HasDeviceId;
			if (hasDeviceId)
			{
				output.WriteRawTag(26);
				output.WriteString(this.DeviceId);
			}
			bool hasEmail = this.HasEmail;
			if (hasEmail)
			{
				output.WriteRawTag(82);
				output.WriteString(this.Email);
			}
			bool hasPhoneNumber = this.HasPhoneNumber;
			if (hasPhoneNumber)
			{
				output.WriteRawTag(90);
				output.WriteString(this.PhoneNumber);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009320 RID: 37664 RVA: 0x0023A220 File Offset: 0x00238420
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAuthToken = this.HasAuthToken;
			if (hasAuthToken)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.AuthToken);
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
			bool hasEmail = this.HasEmail;
			if (hasEmail)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Email);
			}
			bool hasPhoneNumber = this.HasPhoneNumber;
			if (hasPhoneNumber)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PhoneNumber);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009321 RID: 37665 RVA: 0x0023A2E8 File Offset: 0x002384E8
		[DebuggerNonUserCode]
		public void MergeFrom(LogonOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAuthToken = other.HasAuthToken;
				if (hasAuthToken)
				{
					this.AuthToken = other.AuthToken;
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
				LogonOptions.AdditionalIdOneofCase additionalIdCase = other.AdditionalIdCase;
				LogonOptions.AdditionalIdOneofCase additionalIdOneofCase = additionalIdCase;
				if (additionalIdOneofCase != LogonOptions.AdditionalIdOneofCase.Email)
				{
					if (additionalIdOneofCase == LogonOptions.AdditionalIdOneofCase.PhoneNumber)
					{
						this.PhoneNumber = other.PhoneNumber;
					}
				}
				else
				{
					this.Email = other.Email;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009322 RID: 37666 RVA: 0x0023A3A0 File Offset: 0x002385A0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009323 RID: 37667 RVA: 0x0023A3AC File Offset: 0x002385AC
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
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							goto IL_0033;
						}
						this.UserAgent = input.ReadString();
					}
					else
					{
						this.AuthToken = input.ReadBytes();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 82U)
					{
						if (num3 != 90U)
						{
							goto IL_0033;
						}
						this.PhoneNumber = input.ReadString();
					}
					else
					{
						this.Email = input.ReadString();
					}
				}
				else
				{
					this.DeviceId = input.ReadString();
				}
				continue;
				IL_0033:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004261 RID: 16993
		private static readonly MessageParser<LogonOptions> _parser = new MessageParser<LogonOptions>(() => new LogonOptions());

		// Token: 0x04004262 RID: 16994
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004263 RID: 16995
		public const int AuthTokenFieldNumber = 1;

		// Token: 0x04004264 RID: 16996
		private static readonly ByteString AuthTokenDefaultValue = ByteString.Empty;

		// Token: 0x04004265 RID: 16997
		private ByteString authToken_;

		// Token: 0x04004266 RID: 16998
		public const int UserAgentFieldNumber = 2;

		// Token: 0x04004267 RID: 16999
		private static readonly string UserAgentDefaultValue = "";

		// Token: 0x04004268 RID: 17000
		private string userAgent_;

		// Token: 0x04004269 RID: 17001
		public const int DeviceIdFieldNumber = 3;

		// Token: 0x0400426A RID: 17002
		private static readonly string DeviceIdDefaultValue = "";

		// Token: 0x0400426B RID: 17003
		private string deviceId_;

		// Token: 0x0400426C RID: 17004
		public const int EmailFieldNumber = 10;

		// Token: 0x0400426D RID: 17005
		public const int PhoneNumberFieldNumber = 11;

		// Token: 0x0400426E RID: 17006
		private object additionalId_;

		// Token: 0x0400426F RID: 17007
		private LogonOptions.AdditionalIdOneofCase additionalIdCase_ = LogonOptions.AdditionalIdOneofCase.None;

		// Token: 0x0200111B RID: 4379
		public enum AdditionalIdOneofCase
		{
			// Token: 0x04009853 RID: 38995
			None,
			// Token: 0x04009854 RID: 38996
			Email = 10,
			// Token: 0x04009855 RID: 38997
			PhoneNumber
		}
	}
}
