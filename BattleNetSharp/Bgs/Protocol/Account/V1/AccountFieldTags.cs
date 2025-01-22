using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000737 RID: 1847
	public sealed class AccountFieldTags : IMessage<AccountFieldTags>, IMessage, IEquatable<AccountFieldTags>, IDeepCloneable<AccountFieldTags>, IBufferMessage
	{
		// Token: 0x17003416 RID: 13334
		// (get) Token: 0x0600A8F8 RID: 43256 RVA: 0x002926D0 File Offset: 0x002908D0
		[DebuggerNonUserCode]
		public static MessageParser<AccountFieldTags> Parser
		{
			get
			{
				return AccountFieldTags._parser;
			}
		}

		// Token: 0x17003417 RID: 13335
		// (get) Token: 0x0600A8F9 RID: 43257 RVA: 0x002926E8 File Offset: 0x002908E8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x17003418 RID: 13336
		// (get) Token: 0x0600A8FA RID: 43258 RVA: 0x0029270C File Offset: 0x0029090C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccountFieldTags.Descriptor;
			}
		}

		// Token: 0x0600A8FB RID: 43259 RVA: 0x00292723 File Offset: 0x00290923
		[DebuggerNonUserCode]
		public AccountFieldTags()
		{
		}

		// Token: 0x0600A8FC RID: 43260 RVA: 0x00292750 File Offset: 0x00290950
		[DebuggerNonUserCode]
		public AccountFieldTags(AccountFieldTags other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.accountLevelInfoTag_ = other.accountLevelInfoTag_;
			this.privacyInfoTag_ = other.privacyInfoTag_;
			this.parentalControlInfoTag_ = other.parentalControlInfoTag_;
			this.gameLevelInfoTags_ = other.gameLevelInfoTags_.Clone();
			this.gameStatusTags_ = other.gameStatusTags_.Clone();
			this.gameAccountTags_ = other.gameAccountTags_.Clone();
			this.securityStatusTag_ = other.securityStatusTag_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A8FD RID: 43261 RVA: 0x002927E8 File Offset: 0x002909E8
		[DebuggerNonUserCode]
		public AccountFieldTags Clone()
		{
			return new AccountFieldTags(this);
		}

		// Token: 0x17003419 RID: 13337
		// (get) Token: 0x0600A8FE RID: 43262 RVA: 0x00292800 File Offset: 0x00290A00
		// (set) Token: 0x0600A8FF RID: 43263 RVA: 0x00292831 File Offset: 0x00290A31
		[DebuggerNonUserCode]
		public uint AccountLevelInfoTag
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint accountLevelInfoTagDefaultValue;
				if (flag)
				{
					accountLevelInfoTagDefaultValue = this.accountLevelInfoTag_;
				}
				else
				{
					accountLevelInfoTagDefaultValue = AccountFieldTags.AccountLevelInfoTagDefaultValue;
				}
				return accountLevelInfoTagDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.accountLevelInfoTag_ = value;
			}
		}

		// Token: 0x1700341A RID: 13338
		// (get) Token: 0x0600A900 RID: 43264 RVA: 0x0029284C File Offset: 0x00290A4C
		[DebuggerNonUserCode]
		public bool HasAccountLevelInfoTag
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A901 RID: 43265 RVA: 0x00292869 File Offset: 0x00290A69
		[DebuggerNonUserCode]
		public void ClearAccountLevelInfoTag()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700341B RID: 13339
		// (get) Token: 0x0600A902 RID: 43266 RVA: 0x0029287C File Offset: 0x00290A7C
		// (set) Token: 0x0600A903 RID: 43267 RVA: 0x002928AD File Offset: 0x00290AAD
		[DebuggerNonUserCode]
		public uint PrivacyInfoTag
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint privacyInfoTagDefaultValue;
				if (flag)
				{
					privacyInfoTagDefaultValue = this.privacyInfoTag_;
				}
				else
				{
					privacyInfoTagDefaultValue = AccountFieldTags.PrivacyInfoTagDefaultValue;
				}
				return privacyInfoTagDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.privacyInfoTag_ = value;
			}
		}

		// Token: 0x1700341C RID: 13340
		// (get) Token: 0x0600A904 RID: 43268 RVA: 0x002928C8 File Offset: 0x00290AC8
		[DebuggerNonUserCode]
		public bool HasPrivacyInfoTag
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600A905 RID: 43269 RVA: 0x002928E5 File Offset: 0x00290AE5
		[DebuggerNonUserCode]
		public void ClearPrivacyInfoTag()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700341D RID: 13341
		// (get) Token: 0x0600A906 RID: 43270 RVA: 0x002928F8 File Offset: 0x00290AF8
		// (set) Token: 0x0600A907 RID: 43271 RVA: 0x00292929 File Offset: 0x00290B29
		[DebuggerNonUserCode]
		public uint ParentalControlInfoTag
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint parentalControlInfoTagDefaultValue;
				if (flag)
				{
					parentalControlInfoTagDefaultValue = this.parentalControlInfoTag_;
				}
				else
				{
					parentalControlInfoTagDefaultValue = AccountFieldTags.ParentalControlInfoTagDefaultValue;
				}
				return parentalControlInfoTagDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.parentalControlInfoTag_ = value;
			}
		}

		// Token: 0x1700341E RID: 13342
		// (get) Token: 0x0600A908 RID: 43272 RVA: 0x00292944 File Offset: 0x00290B44
		[DebuggerNonUserCode]
		public bool HasParentalControlInfoTag
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600A909 RID: 43273 RVA: 0x00292961 File Offset: 0x00290B61
		[DebuggerNonUserCode]
		public void ClearParentalControlInfoTag()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x1700341F RID: 13343
		// (get) Token: 0x0600A90A RID: 43274 RVA: 0x00292974 File Offset: 0x00290B74
		[DebuggerNonUserCode]
		public RepeatedField<ProgramTag> GameLevelInfoTags
		{
			get
			{
				return this.gameLevelInfoTags_;
			}
		}

		// Token: 0x17003420 RID: 13344
		// (get) Token: 0x0600A90B RID: 43275 RVA: 0x0029298C File Offset: 0x00290B8C
		[DebuggerNonUserCode]
		public RepeatedField<ProgramTag> GameStatusTags
		{
			get
			{
				return this.gameStatusTags_;
			}
		}

		// Token: 0x17003421 RID: 13345
		// (get) Token: 0x0600A90C RID: 43276 RVA: 0x002929A4 File Offset: 0x00290BA4
		[DebuggerNonUserCode]
		public RepeatedField<RegionTag> GameAccountTags
		{
			get
			{
				return this.gameAccountTags_;
			}
		}

		// Token: 0x17003422 RID: 13346
		// (get) Token: 0x0600A90D RID: 43277 RVA: 0x002929BC File Offset: 0x00290BBC
		// (set) Token: 0x0600A90E RID: 43278 RVA: 0x002929ED File Offset: 0x00290BED
		[DebuggerNonUserCode]
		public uint SecurityStatusTag
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint securityStatusTagDefaultValue;
				if (flag)
				{
					securityStatusTagDefaultValue = this.securityStatusTag_;
				}
				else
				{
					securityStatusTagDefaultValue = AccountFieldTags.SecurityStatusTagDefaultValue;
				}
				return securityStatusTagDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.securityStatusTag_ = value;
			}
		}

		// Token: 0x17003423 RID: 13347
		// (get) Token: 0x0600A90F RID: 43279 RVA: 0x00292A08 File Offset: 0x00290C08
		[DebuggerNonUserCode]
		public bool HasSecurityStatusTag
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600A910 RID: 43280 RVA: 0x00292A25 File Offset: 0x00290C25
		[DebuggerNonUserCode]
		public void ClearSecurityStatusTag()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x0600A911 RID: 43281 RVA: 0x00292A38 File Offset: 0x00290C38
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AccountFieldTags);
		}

		// Token: 0x0600A912 RID: 43282 RVA: 0x00292A58 File Offset: 0x00290C58
		[DebuggerNonUserCode]
		public bool Equals(AccountFieldTags other)
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
					bool flag4 = this.AccountLevelInfoTag != other.AccountLevelInfoTag;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.PrivacyInfoTag != other.PrivacyInfoTag;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ParentalControlInfoTag != other.ParentalControlInfoTag;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.gameLevelInfoTags_.Equals(other.gameLevelInfoTags_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.gameStatusTags_.Equals(other.gameStatusTags_);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !this.gameAccountTags_.Equals(other.gameAccountTags_);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.SecurityStatusTag != other.SecurityStatusTag;
											flag2 = !flag10 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x0600A913 RID: 43283 RVA: 0x00292B68 File Offset: 0x00290D68
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAccountLevelInfoTag = this.HasAccountLevelInfoTag;
			if (hasAccountLevelInfoTag)
			{
				num ^= this.AccountLevelInfoTag.GetHashCode();
			}
			bool hasPrivacyInfoTag = this.HasPrivacyInfoTag;
			if (hasPrivacyInfoTag)
			{
				num ^= this.PrivacyInfoTag.GetHashCode();
			}
			bool hasParentalControlInfoTag = this.HasParentalControlInfoTag;
			if (hasParentalControlInfoTag)
			{
				num ^= this.ParentalControlInfoTag.GetHashCode();
			}
			num ^= this.gameLevelInfoTags_.GetHashCode();
			num ^= this.gameStatusTags_.GetHashCode();
			num ^= this.gameAccountTags_.GetHashCode();
			bool hasSecurityStatusTag = this.HasSecurityStatusTag;
			if (hasSecurityStatusTag)
			{
				num ^= this.SecurityStatusTag.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A914 RID: 43284 RVA: 0x00292C38 File Offset: 0x00290E38
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A915 RID: 43285 RVA: 0x00292C50 File Offset: 0x00290E50
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A916 RID: 43286 RVA: 0x00292C5C File Offset: 0x00290E5C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAccountLevelInfoTag = this.HasAccountLevelInfoTag;
			if (hasAccountLevelInfoTag)
			{
				output.WriteRawTag(21);
				output.WriteFixed32(this.AccountLevelInfoTag);
			}
			bool hasPrivacyInfoTag = this.HasPrivacyInfoTag;
			if (hasPrivacyInfoTag)
			{
				output.WriteRawTag(29);
				output.WriteFixed32(this.PrivacyInfoTag);
			}
			bool hasParentalControlInfoTag = this.HasParentalControlInfoTag;
			if (hasParentalControlInfoTag)
			{
				output.WriteRawTag(37);
				output.WriteFixed32(this.ParentalControlInfoTag);
			}
			this.gameLevelInfoTags_.WriteTo(ref output, AccountFieldTags._repeated_gameLevelInfoTags_codec);
			this.gameStatusTags_.WriteTo(ref output, AccountFieldTags._repeated_gameStatusTags_codec);
			this.gameAccountTags_.WriteTo(ref output, AccountFieldTags._repeated_gameAccountTags_codec);
			bool hasSecurityStatusTag = this.HasSecurityStatusTag;
			if (hasSecurityStatusTag)
			{
				output.WriteRawTag(101);
				output.WriteFixed32(this.SecurityStatusTag);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A917 RID: 43287 RVA: 0x00292D48 File Offset: 0x00290F48
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAccountLevelInfoTag = this.HasAccountLevelInfoTag;
			if (hasAccountLevelInfoTag)
			{
				num += 5;
			}
			bool hasPrivacyInfoTag = this.HasPrivacyInfoTag;
			if (hasPrivacyInfoTag)
			{
				num += 5;
			}
			bool hasParentalControlInfoTag = this.HasParentalControlInfoTag;
			if (hasParentalControlInfoTag)
			{
				num += 5;
			}
			num += this.gameLevelInfoTags_.CalculateSize(AccountFieldTags._repeated_gameLevelInfoTags_codec);
			num += this.gameStatusTags_.CalculateSize(AccountFieldTags._repeated_gameStatusTags_codec);
			num += this.gameAccountTags_.CalculateSize(AccountFieldTags._repeated_gameAccountTags_codec);
			bool hasSecurityStatusTag = this.HasSecurityStatusTag;
			if (hasSecurityStatusTag)
			{
				num += 5;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A918 RID: 43288 RVA: 0x00292DFC File Offset: 0x00290FFC
		[DebuggerNonUserCode]
		public void MergeFrom(AccountFieldTags other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAccountLevelInfoTag = other.HasAccountLevelInfoTag;
				if (hasAccountLevelInfoTag)
				{
					this.AccountLevelInfoTag = other.AccountLevelInfoTag;
				}
				bool hasPrivacyInfoTag = other.HasPrivacyInfoTag;
				if (hasPrivacyInfoTag)
				{
					this.PrivacyInfoTag = other.PrivacyInfoTag;
				}
				bool hasParentalControlInfoTag = other.HasParentalControlInfoTag;
				if (hasParentalControlInfoTag)
				{
					this.ParentalControlInfoTag = other.ParentalControlInfoTag;
				}
				this.gameLevelInfoTags_.Add(other.gameLevelInfoTags_);
				this.gameStatusTags_.Add(other.gameStatusTags_);
				this.gameAccountTags_.Add(other.gameAccountTags_);
				bool hasSecurityStatusTag = other.HasSecurityStatusTag;
				if (hasSecurityStatusTag)
				{
					this.SecurityStatusTag = other.SecurityStatusTag;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A919 RID: 43289 RVA: 0x00292ECB File Offset: 0x002910CB
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A91A RID: 43290 RVA: 0x00292ED8 File Offset: 0x002910D8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 37U)
				{
					if (num3 != 21U)
					{
						if (num3 != 29U)
						{
							if (num3 != 37U)
							{
								goto IL_0049;
							}
							this.ParentalControlInfoTag = input.ReadFixed32();
						}
						else
						{
							this.PrivacyInfoTag = input.ReadFixed32();
						}
					}
					else
					{
						this.AccountLevelInfoTag = input.ReadFixed32();
					}
				}
				else if (num3 <= 74U)
				{
					if (num3 != 58U)
					{
						if (num3 != 74U)
						{
							goto IL_0049;
						}
						this.gameStatusTags_.AddEntriesFrom(ref input, AccountFieldTags._repeated_gameStatusTags_codec);
					}
					else
					{
						this.gameLevelInfoTags_.AddEntriesFrom(ref input, AccountFieldTags._repeated_gameLevelInfoTags_codec);
					}
				}
				else if (num3 != 90U)
				{
					if (num3 != 101U)
					{
						goto IL_0049;
					}
					this.SecurityStatusTag = input.ReadFixed32();
				}
				else
				{
					this.gameAccountTags_.AddEntriesFrom(ref input, AccountFieldTags._repeated_gameAccountTags_codec);
				}
				continue;
				IL_0049:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004BED RID: 19437
		private static readonly MessageParser<AccountFieldTags> _parser = new MessageParser<AccountFieldTags>(() => new AccountFieldTags());

		// Token: 0x04004BEE RID: 19438
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BEF RID: 19439
		private int _hasBits0;

		// Token: 0x04004BF0 RID: 19440
		public const int AccountLevelInfoTagFieldNumber = 2;

		// Token: 0x04004BF1 RID: 19441
		private static readonly uint AccountLevelInfoTagDefaultValue = 0U;

		// Token: 0x04004BF2 RID: 19442
		private uint accountLevelInfoTag_;

		// Token: 0x04004BF3 RID: 19443
		public const int PrivacyInfoTagFieldNumber = 3;

		// Token: 0x04004BF4 RID: 19444
		private static readonly uint PrivacyInfoTagDefaultValue = 0U;

		// Token: 0x04004BF5 RID: 19445
		private uint privacyInfoTag_;

		// Token: 0x04004BF6 RID: 19446
		public const int ParentalControlInfoTagFieldNumber = 4;

		// Token: 0x04004BF7 RID: 19447
		private static readonly uint ParentalControlInfoTagDefaultValue = 0U;

		// Token: 0x04004BF8 RID: 19448
		private uint parentalControlInfoTag_;

		// Token: 0x04004BF9 RID: 19449
		public const int GameLevelInfoTagsFieldNumber = 7;

		// Token: 0x04004BFA RID: 19450
		private static readonly FieldCodec<ProgramTag> _repeated_gameLevelInfoTags_codec = FieldCodec.ForMessage<ProgramTag>(58U, ProgramTag.Parser);

		// Token: 0x04004BFB RID: 19451
		private readonly RepeatedField<ProgramTag> gameLevelInfoTags_ = new RepeatedField<ProgramTag>();

		// Token: 0x04004BFC RID: 19452
		public const int GameStatusTagsFieldNumber = 9;

		// Token: 0x04004BFD RID: 19453
		private static readonly FieldCodec<ProgramTag> _repeated_gameStatusTags_codec = FieldCodec.ForMessage<ProgramTag>(74U, ProgramTag.Parser);

		// Token: 0x04004BFE RID: 19454
		private readonly RepeatedField<ProgramTag> gameStatusTags_ = new RepeatedField<ProgramTag>();

		// Token: 0x04004BFF RID: 19455
		public const int GameAccountTagsFieldNumber = 11;

		// Token: 0x04004C00 RID: 19456
		private static readonly FieldCodec<RegionTag> _repeated_gameAccountTags_codec = FieldCodec.ForMessage<RegionTag>(90U, RegionTag.Parser);

		// Token: 0x04004C01 RID: 19457
		private readonly RepeatedField<RegionTag> gameAccountTags_ = new RepeatedField<RegionTag>();

		// Token: 0x04004C02 RID: 19458
		public const int SecurityStatusTagFieldNumber = 12;

		// Token: 0x04004C03 RID: 19459
		private static readonly uint SecurityStatusTagDefaultValue = 0U;

		// Token: 0x04004C04 RID: 19460
		private uint securityStatusTag_;
	}
}
