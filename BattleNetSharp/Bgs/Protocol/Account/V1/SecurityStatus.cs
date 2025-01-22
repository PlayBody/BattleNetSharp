using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x0200074B RID: 1867
	public sealed class SecurityStatus : IMessage<SecurityStatus>, IMessage, IEquatable<SecurityStatus>, IDeepCloneable<SecurityStatus>, IBufferMessage
	{
		// Token: 0x1700351B RID: 13595
		// (get) Token: 0x0600ABD4 RID: 43988 RVA: 0x0029D5BC File Offset: 0x0029B7BC
		[DebuggerNonUserCode]
		public static MessageParser<SecurityStatus> Parser
		{
			get
			{
				return SecurityStatus._parser;
			}
		}

		// Token: 0x1700351C RID: 13596
		// (get) Token: 0x0600ABD5 RID: 43989 RVA: 0x0029D5D4 File Offset: 0x0029B7D4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[27];
			}
		}

		// Token: 0x1700351D RID: 13597
		// (get) Token: 0x0600ABD6 RID: 43990 RVA: 0x0029D5F8 File Offset: 0x0029B7F8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecurityStatus.Descriptor;
			}
		}

		// Token: 0x0600ABD7 RID: 43991 RVA: 0x0029D60F File Offset: 0x0029B80F
		[DebuggerNonUserCode]
		public SecurityStatus()
		{
		}

		// Token: 0x0600ABD8 RID: 43992 RVA: 0x0029D61C File Offset: 0x0029B81C
		[DebuggerNonUserCode]
		public SecurityStatus(SecurityStatus other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.smsProtectEnabled_ = other.smsProtectEnabled_;
			this.emailVerified_ = other.emailVerified_;
			this.authenticatorEnabled_ = other.authenticatorEnabled_;
			this.sqaEnabled_ = other.sqaEnabled_;
			this.authenticatorRequired_ = other.authenticatorRequired_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ABD9 RID: 43993 RVA: 0x0029D68C File Offset: 0x0029B88C
		[DebuggerNonUserCode]
		public SecurityStatus Clone()
		{
			return new SecurityStatus(this);
		}

		// Token: 0x1700351E RID: 13598
		// (get) Token: 0x0600ABDA RID: 43994 RVA: 0x0029D6A4 File Offset: 0x0029B8A4
		// (set) Token: 0x0600ABDB RID: 43995 RVA: 0x0029D6D5 File Offset: 0x0029B8D5
		[DebuggerNonUserCode]
		public bool SmsProtectEnabled
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool smsProtectEnabledDefaultValue;
				if (flag)
				{
					smsProtectEnabledDefaultValue = this.smsProtectEnabled_;
				}
				else
				{
					smsProtectEnabledDefaultValue = SecurityStatus.SmsProtectEnabledDefaultValue;
				}
				return smsProtectEnabledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.smsProtectEnabled_ = value;
			}
		}

		// Token: 0x1700351F RID: 13599
		// (get) Token: 0x0600ABDC RID: 43996 RVA: 0x0029D6F0 File Offset: 0x0029B8F0
		[DebuggerNonUserCode]
		public bool HasSmsProtectEnabled
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600ABDD RID: 43997 RVA: 0x0029D70D File Offset: 0x0029B90D
		[DebuggerNonUserCode]
		public void ClearSmsProtectEnabled()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003520 RID: 13600
		// (get) Token: 0x0600ABDE RID: 43998 RVA: 0x0029D720 File Offset: 0x0029B920
		// (set) Token: 0x0600ABDF RID: 43999 RVA: 0x0029D751 File Offset: 0x0029B951
		[DebuggerNonUserCode]
		public bool EmailVerified
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool emailVerifiedDefaultValue;
				if (flag)
				{
					emailVerifiedDefaultValue = this.emailVerified_;
				}
				else
				{
					emailVerifiedDefaultValue = SecurityStatus.EmailVerifiedDefaultValue;
				}
				return emailVerifiedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.emailVerified_ = value;
			}
		}

		// Token: 0x17003521 RID: 13601
		// (get) Token: 0x0600ABE0 RID: 44000 RVA: 0x0029D76C File Offset: 0x0029B96C
		[DebuggerNonUserCode]
		public bool HasEmailVerified
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600ABE1 RID: 44001 RVA: 0x0029D789 File Offset: 0x0029B989
		[DebuggerNonUserCode]
		public void ClearEmailVerified()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17003522 RID: 13602
		// (get) Token: 0x0600ABE2 RID: 44002 RVA: 0x0029D79C File Offset: 0x0029B99C
		// (set) Token: 0x0600ABE3 RID: 44003 RVA: 0x0029D7CD File Offset: 0x0029B9CD
		[DebuggerNonUserCode]
		public bool AuthenticatorEnabled
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool authenticatorEnabledDefaultValue;
				if (flag)
				{
					authenticatorEnabledDefaultValue = this.authenticatorEnabled_;
				}
				else
				{
					authenticatorEnabledDefaultValue = SecurityStatus.AuthenticatorEnabledDefaultValue;
				}
				return authenticatorEnabledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.authenticatorEnabled_ = value;
			}
		}

		// Token: 0x17003523 RID: 13603
		// (get) Token: 0x0600ABE4 RID: 44004 RVA: 0x0029D7E8 File Offset: 0x0029B9E8
		[DebuggerNonUserCode]
		public bool HasAuthenticatorEnabled
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600ABE5 RID: 44005 RVA: 0x0029D805 File Offset: 0x0029BA05
		[DebuggerNonUserCode]
		public void ClearAuthenticatorEnabled()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17003524 RID: 13604
		// (get) Token: 0x0600ABE6 RID: 44006 RVA: 0x0029D818 File Offset: 0x0029BA18
		// (set) Token: 0x0600ABE7 RID: 44007 RVA: 0x0029D849 File Offset: 0x0029BA49
		[DebuggerNonUserCode]
		public bool SqaEnabled
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool sqaEnabledDefaultValue;
				if (flag)
				{
					sqaEnabledDefaultValue = this.sqaEnabled_;
				}
				else
				{
					sqaEnabledDefaultValue = SecurityStatus.SqaEnabledDefaultValue;
				}
				return sqaEnabledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.sqaEnabled_ = value;
			}
		}

		// Token: 0x17003525 RID: 13605
		// (get) Token: 0x0600ABE8 RID: 44008 RVA: 0x0029D864 File Offset: 0x0029BA64
		[DebuggerNonUserCode]
		public bool HasSqaEnabled
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600ABE9 RID: 44009 RVA: 0x0029D881 File Offset: 0x0029BA81
		[DebuggerNonUserCode]
		public void ClearSqaEnabled()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17003526 RID: 13606
		// (get) Token: 0x0600ABEA RID: 44010 RVA: 0x0029D894 File Offset: 0x0029BA94
		// (set) Token: 0x0600ABEB RID: 44011 RVA: 0x0029D8C6 File Offset: 0x0029BAC6
		[DebuggerNonUserCode]
		public bool AuthenticatorRequired
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool authenticatorRequiredDefaultValue;
				if (flag)
				{
					authenticatorRequiredDefaultValue = this.authenticatorRequired_;
				}
				else
				{
					authenticatorRequiredDefaultValue = SecurityStatus.AuthenticatorRequiredDefaultValue;
				}
				return authenticatorRequiredDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.authenticatorRequired_ = value;
			}
		}

		// Token: 0x17003527 RID: 13607
		// (get) Token: 0x0600ABEC RID: 44012 RVA: 0x0029D8E0 File Offset: 0x0029BAE0
		[DebuggerNonUserCode]
		public bool HasAuthenticatorRequired
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600ABED RID: 44013 RVA: 0x0029D8FE File Offset: 0x0029BAFE
		[DebuggerNonUserCode]
		public void ClearAuthenticatorRequired()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x0600ABEE RID: 44014 RVA: 0x0029D910 File Offset: 0x0029BB10
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecurityStatus);
		}

		// Token: 0x0600ABEF RID: 44015 RVA: 0x0029D930 File Offset: 0x0029BB30
		[DebuggerNonUserCode]
		public bool Equals(SecurityStatus other)
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
					bool flag4 = this.SmsProtectEnabled != other.SmsProtectEnabled;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.EmailVerified != other.EmailVerified;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.AuthenticatorEnabled != other.AuthenticatorEnabled;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.SqaEnabled != other.SqaEnabled;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.AuthenticatorRequired != other.AuthenticatorRequired;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600ABF0 RID: 44016 RVA: 0x0029D9FC File Offset: 0x0029BBFC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSmsProtectEnabled = this.HasSmsProtectEnabled;
			if (hasSmsProtectEnabled)
			{
				num ^= this.SmsProtectEnabled.GetHashCode();
			}
			bool hasEmailVerified = this.HasEmailVerified;
			if (hasEmailVerified)
			{
				num ^= this.EmailVerified.GetHashCode();
			}
			bool hasAuthenticatorEnabled = this.HasAuthenticatorEnabled;
			if (hasAuthenticatorEnabled)
			{
				num ^= this.AuthenticatorEnabled.GetHashCode();
			}
			bool hasSqaEnabled = this.HasSqaEnabled;
			if (hasSqaEnabled)
			{
				num ^= this.SqaEnabled.GetHashCode();
			}
			bool hasAuthenticatorRequired = this.HasAuthenticatorRequired;
			if (hasAuthenticatorRequired)
			{
				num ^= this.AuthenticatorRequired.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ABF1 RID: 44017 RVA: 0x0029DAC0 File Offset: 0x0029BCC0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600ABF2 RID: 44018 RVA: 0x0029DAD8 File Offset: 0x0029BCD8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ABF3 RID: 44019 RVA: 0x0029DAE4 File Offset: 0x0029BCE4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSmsProtectEnabled = this.HasSmsProtectEnabled;
			if (hasSmsProtectEnabled)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.SmsProtectEnabled);
			}
			bool hasEmailVerified = this.HasEmailVerified;
			if (hasEmailVerified)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.EmailVerified);
			}
			bool hasAuthenticatorEnabled = this.HasAuthenticatorEnabled;
			if (hasAuthenticatorEnabled)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.AuthenticatorEnabled);
			}
			bool hasSqaEnabled = this.HasSqaEnabled;
			if (hasSqaEnabled)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.SqaEnabled);
			}
			bool hasAuthenticatorRequired = this.HasAuthenticatorRequired;
			if (hasAuthenticatorRequired)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.AuthenticatorRequired);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ABF4 RID: 44020 RVA: 0x0029DBBC File Offset: 0x0029BDBC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSmsProtectEnabled = this.HasSmsProtectEnabled;
			if (hasSmsProtectEnabled)
			{
				num += 2;
			}
			bool hasEmailVerified = this.HasEmailVerified;
			if (hasEmailVerified)
			{
				num += 2;
			}
			bool hasAuthenticatorEnabled = this.HasAuthenticatorEnabled;
			if (hasAuthenticatorEnabled)
			{
				num += 2;
			}
			bool hasSqaEnabled = this.HasSqaEnabled;
			if (hasSqaEnabled)
			{
				num += 2;
			}
			bool hasAuthenticatorRequired = this.HasAuthenticatorRequired;
			if (hasAuthenticatorRequired)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ABF5 RID: 44021 RVA: 0x0029DC48 File Offset: 0x0029BE48
		[DebuggerNonUserCode]
		public void MergeFrom(SecurityStatus other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSmsProtectEnabled = other.HasSmsProtectEnabled;
				if (hasSmsProtectEnabled)
				{
					this.SmsProtectEnabled = other.SmsProtectEnabled;
				}
				bool hasEmailVerified = other.HasEmailVerified;
				if (hasEmailVerified)
				{
					this.EmailVerified = other.EmailVerified;
				}
				bool hasAuthenticatorEnabled = other.HasAuthenticatorEnabled;
				if (hasAuthenticatorEnabled)
				{
					this.AuthenticatorEnabled = other.AuthenticatorEnabled;
				}
				bool hasSqaEnabled = other.HasSqaEnabled;
				if (hasSqaEnabled)
				{
					this.SqaEnabled = other.SqaEnabled;
				}
				bool hasAuthenticatorRequired = other.HasAuthenticatorRequired;
				if (hasAuthenticatorRequired)
				{
					this.AuthenticatorRequired = other.AuthenticatorRequired;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600ABF6 RID: 44022 RVA: 0x0029DCFC File Offset: 0x0029BEFC
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ABF7 RID: 44023 RVA: 0x0029DD08 File Offset: 0x0029BF08
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 16U)
				{
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							goto IL_0032;
						}
						this.EmailVerified = input.ReadBool();
					}
					else
					{
						this.SmsProtectEnabled = input.ReadBool();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						if (num3 != 40U)
						{
							goto IL_0032;
						}
						this.AuthenticatorRequired = input.ReadBool();
					}
					else
					{
						this.SqaEnabled = input.ReadBool();
					}
				}
				else
				{
					this.AuthenticatorEnabled = input.ReadBool();
				}
				continue;
				IL_0032:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004D66 RID: 19814
		private static readonly MessageParser<SecurityStatus> _parser = new MessageParser<SecurityStatus>(() => new SecurityStatus());

		// Token: 0x04004D67 RID: 19815
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D68 RID: 19816
		private int _hasBits0;

		// Token: 0x04004D69 RID: 19817
		public const int SmsProtectEnabledFieldNumber = 1;

		// Token: 0x04004D6A RID: 19818
		private static readonly bool SmsProtectEnabledDefaultValue = false;

		// Token: 0x04004D6B RID: 19819
		private bool smsProtectEnabled_;

		// Token: 0x04004D6C RID: 19820
		public const int EmailVerifiedFieldNumber = 2;

		// Token: 0x04004D6D RID: 19821
		private static readonly bool EmailVerifiedDefaultValue = false;

		// Token: 0x04004D6E RID: 19822
		private bool emailVerified_;

		// Token: 0x04004D6F RID: 19823
		public const int AuthenticatorEnabledFieldNumber = 3;

		// Token: 0x04004D70 RID: 19824
		private static readonly bool AuthenticatorEnabledDefaultValue = false;

		// Token: 0x04004D71 RID: 19825
		private bool authenticatorEnabled_;

		// Token: 0x04004D72 RID: 19826
		public const int SqaEnabledFieldNumber = 4;

		// Token: 0x04004D73 RID: 19827
		private static readonly bool SqaEnabledDefaultValue = false;

		// Token: 0x04004D74 RID: 19828
		private bool sqaEnabled_;

		// Token: 0x04004D75 RID: 19829
		public const int AuthenticatorRequiredFieldNumber = 5;

		// Token: 0x04004D76 RID: 19830
		private static readonly bool AuthenticatorRequiredDefaultValue = false;

		// Token: 0x04004D77 RID: 19831
		private bool authenticatorRequired_;
	}
}
