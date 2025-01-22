using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000739 RID: 1849
	public sealed class AccountFieldOptions : IMessage<AccountFieldOptions>, IMessage, IEquatable<AccountFieldOptions>, IDeepCloneable<AccountFieldOptions>, IBufferMessage
	{
		// Token: 0x1700342F RID: 13359
		// (get) Token: 0x0600A93D RID: 43325 RVA: 0x00293750 File Offset: 0x00291950
		[DebuggerNonUserCode]
		public static MessageParser<AccountFieldOptions> Parser
		{
			get
			{
				return AccountFieldOptions._parser;
			}
		}

		// Token: 0x17003430 RID: 13360
		// (get) Token: 0x0600A93E RID: 43326 RVA: 0x00293768 File Offset: 0x00291968
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x17003431 RID: 13361
		// (get) Token: 0x0600A93F RID: 43327 RVA: 0x0029378C File Offset: 0x0029198C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccountFieldOptions.Descriptor;
			}
		}

		// Token: 0x0600A940 RID: 43328 RVA: 0x002937A3 File Offset: 0x002919A3
		[DebuggerNonUserCode]
		public AccountFieldOptions()
		{
		}

		// Token: 0x0600A941 RID: 43329 RVA: 0x002937B0 File Offset: 0x002919B0
		[DebuggerNonUserCode]
		public AccountFieldOptions(AccountFieldOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.allFields_ = other.allFields_;
			this.fieldAccountLevelInfo_ = other.fieldAccountLevelInfo_;
			this.fieldPrivacyInfo_ = other.fieldPrivacyInfo_;
			this.fieldParentalControlInfo_ = other.fieldParentalControlInfo_;
			this.fieldGameLevelInfo_ = other.fieldGameLevelInfo_;
			this.fieldGameStatus_ = other.fieldGameStatus_;
			this.fieldGameAccounts_ = other.fieldGameAccounts_;
			this.fieldSecurityStatus_ = other.fieldSecurityStatus_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A942 RID: 43330 RVA: 0x00293844 File Offset: 0x00291A44
		[DebuggerNonUserCode]
		public AccountFieldOptions Clone()
		{
			return new AccountFieldOptions(this);
		}

		// Token: 0x17003432 RID: 13362
		// (get) Token: 0x0600A943 RID: 43331 RVA: 0x0029385C File Offset: 0x00291A5C
		// (set) Token: 0x0600A944 RID: 43332 RVA: 0x0029388D File Offset: 0x00291A8D
		[DebuggerNonUserCode]
		public bool AllFields
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool allFieldsDefaultValue;
				if (flag)
				{
					allFieldsDefaultValue = this.allFields_;
				}
				else
				{
					allFieldsDefaultValue = AccountFieldOptions.AllFieldsDefaultValue;
				}
				return allFieldsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.allFields_ = value;
			}
		}

		// Token: 0x17003433 RID: 13363
		// (get) Token: 0x0600A945 RID: 43333 RVA: 0x002938A8 File Offset: 0x00291AA8
		[DebuggerNonUserCode]
		public bool HasAllFields
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A946 RID: 43334 RVA: 0x002938C5 File Offset: 0x00291AC5
		[DebuggerNonUserCode]
		public void ClearAllFields()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003434 RID: 13364
		// (get) Token: 0x0600A947 RID: 43335 RVA: 0x002938D8 File Offset: 0x00291AD8
		// (set) Token: 0x0600A948 RID: 43336 RVA: 0x00293909 File Offset: 0x00291B09
		[DebuggerNonUserCode]
		public bool FieldAccountLevelInfo
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool fieldAccountLevelInfoDefaultValue;
				if (flag)
				{
					fieldAccountLevelInfoDefaultValue = this.fieldAccountLevelInfo_;
				}
				else
				{
					fieldAccountLevelInfoDefaultValue = AccountFieldOptions.FieldAccountLevelInfoDefaultValue;
				}
				return fieldAccountLevelInfoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.fieldAccountLevelInfo_ = value;
			}
		}

		// Token: 0x17003435 RID: 13365
		// (get) Token: 0x0600A949 RID: 43337 RVA: 0x00293924 File Offset: 0x00291B24
		[DebuggerNonUserCode]
		public bool HasFieldAccountLevelInfo
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600A94A RID: 43338 RVA: 0x00293941 File Offset: 0x00291B41
		[DebuggerNonUserCode]
		public void ClearFieldAccountLevelInfo()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17003436 RID: 13366
		// (get) Token: 0x0600A94B RID: 43339 RVA: 0x00293954 File Offset: 0x00291B54
		// (set) Token: 0x0600A94C RID: 43340 RVA: 0x00293985 File Offset: 0x00291B85
		[DebuggerNonUserCode]
		public bool FieldPrivacyInfo
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool fieldPrivacyInfoDefaultValue;
				if (flag)
				{
					fieldPrivacyInfoDefaultValue = this.fieldPrivacyInfo_;
				}
				else
				{
					fieldPrivacyInfoDefaultValue = AccountFieldOptions.FieldPrivacyInfoDefaultValue;
				}
				return fieldPrivacyInfoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.fieldPrivacyInfo_ = value;
			}
		}

		// Token: 0x17003437 RID: 13367
		// (get) Token: 0x0600A94D RID: 43341 RVA: 0x002939A0 File Offset: 0x00291BA0
		[DebuggerNonUserCode]
		public bool HasFieldPrivacyInfo
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600A94E RID: 43342 RVA: 0x002939BD File Offset: 0x00291BBD
		[DebuggerNonUserCode]
		public void ClearFieldPrivacyInfo()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17003438 RID: 13368
		// (get) Token: 0x0600A94F RID: 43343 RVA: 0x002939D0 File Offset: 0x00291BD0
		// (set) Token: 0x0600A950 RID: 43344 RVA: 0x00293A01 File Offset: 0x00291C01
		[DebuggerNonUserCode]
		public bool FieldParentalControlInfo
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool fieldParentalControlInfoDefaultValue;
				if (flag)
				{
					fieldParentalControlInfoDefaultValue = this.fieldParentalControlInfo_;
				}
				else
				{
					fieldParentalControlInfoDefaultValue = AccountFieldOptions.FieldParentalControlInfoDefaultValue;
				}
				return fieldParentalControlInfoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.fieldParentalControlInfo_ = value;
			}
		}

		// Token: 0x17003439 RID: 13369
		// (get) Token: 0x0600A951 RID: 43345 RVA: 0x00293A1C File Offset: 0x00291C1C
		[DebuggerNonUserCode]
		public bool HasFieldParentalControlInfo
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600A952 RID: 43346 RVA: 0x00293A39 File Offset: 0x00291C39
		[DebuggerNonUserCode]
		public void ClearFieldParentalControlInfo()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x1700343A RID: 13370
		// (get) Token: 0x0600A953 RID: 43347 RVA: 0x00293A4C File Offset: 0x00291C4C
		// (set) Token: 0x0600A954 RID: 43348 RVA: 0x00293A7E File Offset: 0x00291C7E
		[DebuggerNonUserCode]
		public bool FieldGameLevelInfo
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool fieldGameLevelInfoDefaultValue;
				if (flag)
				{
					fieldGameLevelInfoDefaultValue = this.fieldGameLevelInfo_;
				}
				else
				{
					fieldGameLevelInfoDefaultValue = AccountFieldOptions.FieldGameLevelInfoDefaultValue;
				}
				return fieldGameLevelInfoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.fieldGameLevelInfo_ = value;
			}
		}

		// Token: 0x1700343B RID: 13371
		// (get) Token: 0x0600A955 RID: 43349 RVA: 0x00293A98 File Offset: 0x00291C98
		[DebuggerNonUserCode]
		public bool HasFieldGameLevelInfo
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600A956 RID: 43350 RVA: 0x00293AB6 File Offset: 0x00291CB6
		[DebuggerNonUserCode]
		public void ClearFieldGameLevelInfo()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x1700343C RID: 13372
		// (get) Token: 0x0600A957 RID: 43351 RVA: 0x00293AC8 File Offset: 0x00291CC8
		// (set) Token: 0x0600A958 RID: 43352 RVA: 0x00293AFA File Offset: 0x00291CFA
		[DebuggerNonUserCode]
		public bool FieldGameStatus
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				bool fieldGameStatusDefaultValue;
				if (flag)
				{
					fieldGameStatusDefaultValue = this.fieldGameStatus_;
				}
				else
				{
					fieldGameStatusDefaultValue = AccountFieldOptions.FieldGameStatusDefaultValue;
				}
				return fieldGameStatusDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.fieldGameStatus_ = value;
			}
		}

		// Token: 0x1700343D RID: 13373
		// (get) Token: 0x0600A959 RID: 43353 RVA: 0x00293B14 File Offset: 0x00291D14
		[DebuggerNonUserCode]
		public bool HasFieldGameStatus
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x0600A95A RID: 43354 RVA: 0x00293B32 File Offset: 0x00291D32
		[DebuggerNonUserCode]
		public void ClearFieldGameStatus()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x1700343E RID: 13374
		// (get) Token: 0x0600A95B RID: 43355 RVA: 0x00293B44 File Offset: 0x00291D44
		// (set) Token: 0x0600A95C RID: 43356 RVA: 0x00293B76 File Offset: 0x00291D76
		[DebuggerNonUserCode]
		public bool FieldGameAccounts
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				bool fieldGameAccountsDefaultValue;
				if (flag)
				{
					fieldGameAccountsDefaultValue = this.fieldGameAccounts_;
				}
				else
				{
					fieldGameAccountsDefaultValue = AccountFieldOptions.FieldGameAccountsDefaultValue;
				}
				return fieldGameAccountsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.fieldGameAccounts_ = value;
			}
		}

		// Token: 0x1700343F RID: 13375
		// (get) Token: 0x0600A95D RID: 43357 RVA: 0x00293B90 File Offset: 0x00291D90
		[DebuggerNonUserCode]
		public bool HasFieldGameAccounts
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x0600A95E RID: 43358 RVA: 0x00293BAE File Offset: 0x00291DAE
		[DebuggerNonUserCode]
		public void ClearFieldGameAccounts()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x17003440 RID: 13376
		// (get) Token: 0x0600A95F RID: 43359 RVA: 0x00293BC0 File Offset: 0x00291DC0
		// (set) Token: 0x0600A960 RID: 43360 RVA: 0x00293BF5 File Offset: 0x00291DF5
		[DebuggerNonUserCode]
		public bool FieldSecurityStatus
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				bool fieldSecurityStatusDefaultValue;
				if (flag)
				{
					fieldSecurityStatusDefaultValue = this.fieldSecurityStatus_;
				}
				else
				{
					fieldSecurityStatusDefaultValue = AccountFieldOptions.FieldSecurityStatusDefaultValue;
				}
				return fieldSecurityStatusDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.fieldSecurityStatus_ = value;
			}
		}

		// Token: 0x17003441 RID: 13377
		// (get) Token: 0x0600A961 RID: 43361 RVA: 0x00293C14 File Offset: 0x00291E14
		[DebuggerNonUserCode]
		public bool HasFieldSecurityStatus
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x0600A962 RID: 43362 RVA: 0x00293C35 File Offset: 0x00291E35
		[DebuggerNonUserCode]
		public void ClearFieldSecurityStatus()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x0600A963 RID: 43363 RVA: 0x00293C4C File Offset: 0x00291E4C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AccountFieldOptions);
		}

		// Token: 0x0600A964 RID: 43364 RVA: 0x00293C6C File Offset: 0x00291E6C
		[DebuggerNonUserCode]
		public bool Equals(AccountFieldOptions other)
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
					bool flag4 = this.AllFields != other.AllFields;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.FieldAccountLevelInfo != other.FieldAccountLevelInfo;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.FieldPrivacyInfo != other.FieldPrivacyInfo;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.FieldParentalControlInfo != other.FieldParentalControlInfo;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.FieldGameLevelInfo != other.FieldGameLevelInfo;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.FieldGameStatus != other.FieldGameStatus;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.FieldGameAccounts != other.FieldGameAccounts;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.FieldSecurityStatus != other.FieldSecurityStatus;
												flag2 = !flag11 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x0600A965 RID: 43365 RVA: 0x00293D94 File Offset: 0x00291F94
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAllFields = this.HasAllFields;
			if (hasAllFields)
			{
				num ^= this.AllFields.GetHashCode();
			}
			bool hasFieldAccountLevelInfo = this.HasFieldAccountLevelInfo;
			if (hasFieldAccountLevelInfo)
			{
				num ^= this.FieldAccountLevelInfo.GetHashCode();
			}
			bool hasFieldPrivacyInfo = this.HasFieldPrivacyInfo;
			if (hasFieldPrivacyInfo)
			{
				num ^= this.FieldPrivacyInfo.GetHashCode();
			}
			bool hasFieldParentalControlInfo = this.HasFieldParentalControlInfo;
			if (hasFieldParentalControlInfo)
			{
				num ^= this.FieldParentalControlInfo.GetHashCode();
			}
			bool hasFieldGameLevelInfo = this.HasFieldGameLevelInfo;
			if (hasFieldGameLevelInfo)
			{
				num ^= this.FieldGameLevelInfo.GetHashCode();
			}
			bool hasFieldGameStatus = this.HasFieldGameStatus;
			if (hasFieldGameStatus)
			{
				num ^= this.FieldGameStatus.GetHashCode();
			}
			bool hasFieldGameAccounts = this.HasFieldGameAccounts;
			if (hasFieldGameAccounts)
			{
				num ^= this.FieldGameAccounts.GetHashCode();
			}
			bool hasFieldSecurityStatus = this.HasFieldSecurityStatus;
			if (hasFieldSecurityStatus)
			{
				num ^= this.FieldSecurityStatus.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A966 RID: 43366 RVA: 0x00293EB0 File Offset: 0x002920B0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A967 RID: 43367 RVA: 0x00293EC8 File Offset: 0x002920C8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A968 RID: 43368 RVA: 0x00293ED4 File Offset: 0x002920D4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAllFields = this.HasAllFields;
			if (hasAllFields)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.AllFields);
			}
			bool hasFieldAccountLevelInfo = this.HasFieldAccountLevelInfo;
			if (hasFieldAccountLevelInfo)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.FieldAccountLevelInfo);
			}
			bool hasFieldPrivacyInfo = this.HasFieldPrivacyInfo;
			if (hasFieldPrivacyInfo)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.FieldPrivacyInfo);
			}
			bool hasFieldParentalControlInfo = this.HasFieldParentalControlInfo;
			if (hasFieldParentalControlInfo)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.FieldParentalControlInfo);
			}
			bool hasFieldGameLevelInfo = this.HasFieldGameLevelInfo;
			if (hasFieldGameLevelInfo)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.FieldGameLevelInfo);
			}
			bool hasFieldGameStatus = this.HasFieldGameStatus;
			if (hasFieldGameStatus)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.FieldGameStatus);
			}
			bool hasFieldGameAccounts = this.HasFieldGameAccounts;
			if (hasFieldGameAccounts)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.FieldGameAccounts);
			}
			bool hasFieldSecurityStatus = this.HasFieldSecurityStatus;
			if (hasFieldSecurityStatus)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.FieldSecurityStatus);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A969 RID: 43369 RVA: 0x00294018 File Offset: 0x00292218
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAllFields = this.HasAllFields;
			if (hasAllFields)
			{
				num += 2;
			}
			bool hasFieldAccountLevelInfo = this.HasFieldAccountLevelInfo;
			if (hasFieldAccountLevelInfo)
			{
				num += 2;
			}
			bool hasFieldPrivacyInfo = this.HasFieldPrivacyInfo;
			if (hasFieldPrivacyInfo)
			{
				num += 2;
			}
			bool hasFieldParentalControlInfo = this.HasFieldParentalControlInfo;
			if (hasFieldParentalControlInfo)
			{
				num += 2;
			}
			bool hasFieldGameLevelInfo = this.HasFieldGameLevelInfo;
			if (hasFieldGameLevelInfo)
			{
				num += 2;
			}
			bool hasFieldGameStatus = this.HasFieldGameStatus;
			if (hasFieldGameStatus)
			{
				num += 2;
			}
			bool hasFieldGameAccounts = this.HasFieldGameAccounts;
			if (hasFieldGameAccounts)
			{
				num += 2;
			}
			bool hasFieldSecurityStatus = this.HasFieldSecurityStatus;
			if (hasFieldSecurityStatus)
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

		// Token: 0x0600A96A RID: 43370 RVA: 0x002940D8 File Offset: 0x002922D8
		[DebuggerNonUserCode]
		public void MergeFrom(AccountFieldOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAllFields = other.HasAllFields;
				if (hasAllFields)
				{
					this.AllFields = other.AllFields;
				}
				bool hasFieldAccountLevelInfo = other.HasFieldAccountLevelInfo;
				if (hasFieldAccountLevelInfo)
				{
					this.FieldAccountLevelInfo = other.FieldAccountLevelInfo;
				}
				bool hasFieldPrivacyInfo = other.HasFieldPrivacyInfo;
				if (hasFieldPrivacyInfo)
				{
					this.FieldPrivacyInfo = other.FieldPrivacyInfo;
				}
				bool hasFieldParentalControlInfo = other.HasFieldParentalControlInfo;
				if (hasFieldParentalControlInfo)
				{
					this.FieldParentalControlInfo = other.FieldParentalControlInfo;
				}
				bool hasFieldGameLevelInfo = other.HasFieldGameLevelInfo;
				if (hasFieldGameLevelInfo)
				{
					this.FieldGameLevelInfo = other.FieldGameLevelInfo;
				}
				bool hasFieldGameStatus = other.HasFieldGameStatus;
				if (hasFieldGameStatus)
				{
					this.FieldGameStatus = other.FieldGameStatus;
				}
				bool hasFieldGameAccounts = other.HasFieldGameAccounts;
				if (hasFieldGameAccounts)
				{
					this.FieldGameAccounts = other.FieldGameAccounts;
				}
				bool hasFieldSecurityStatus = other.HasFieldSecurityStatus;
				if (hasFieldSecurityStatus)
				{
					this.FieldSecurityStatus = other.FieldSecurityStatus;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A96B RID: 43371 RVA: 0x002941DD File Offset: 0x002923DD
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A96C RID: 43372 RVA: 0x002941E8 File Offset: 0x002923E8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 32U)
				{
					if (num3 <= 16U)
					{
						if (num3 != 8U)
						{
							if (num3 != 16U)
							{
								goto IL_0057;
							}
							this.FieldAccountLevelInfo = input.ReadBool();
						}
						else
						{
							this.AllFields = input.ReadBool();
						}
					}
					else if (num3 != 24U)
					{
						if (num3 != 32U)
						{
							goto IL_0057;
						}
						this.FieldParentalControlInfo = input.ReadBool();
					}
					else
					{
						this.FieldPrivacyInfo = input.ReadBool();
					}
				}
				else if (num3 <= 56U)
				{
					if (num3 != 48U)
					{
						if (num3 != 56U)
						{
							goto IL_0057;
						}
						this.FieldGameStatus = input.ReadBool();
					}
					else
					{
						this.FieldGameLevelInfo = input.ReadBool();
					}
				}
				else if (num3 != 64U)
				{
					if (num3 != 72U)
					{
						goto IL_0057;
					}
					this.FieldSecurityStatus = input.ReadBool();
				}
				else
				{
					this.FieldGameAccounts = input.ReadBool();
				}
				continue;
				IL_0057:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004C14 RID: 19476
		private static readonly MessageParser<AccountFieldOptions> _parser = new MessageParser<AccountFieldOptions>(() => new AccountFieldOptions());

		// Token: 0x04004C15 RID: 19477
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C16 RID: 19478
		private int _hasBits0;

		// Token: 0x04004C17 RID: 19479
		public const int AllFieldsFieldNumber = 1;

		// Token: 0x04004C18 RID: 19480
		private static readonly bool AllFieldsDefaultValue = false;

		// Token: 0x04004C19 RID: 19481
		private bool allFields_;

		// Token: 0x04004C1A RID: 19482
		public const int FieldAccountLevelInfoFieldNumber = 2;

		// Token: 0x04004C1B RID: 19483
		private static readonly bool FieldAccountLevelInfoDefaultValue = false;

		// Token: 0x04004C1C RID: 19484
		private bool fieldAccountLevelInfo_;

		// Token: 0x04004C1D RID: 19485
		public const int FieldPrivacyInfoFieldNumber = 3;

		// Token: 0x04004C1E RID: 19486
		private static readonly bool FieldPrivacyInfoDefaultValue = false;

		// Token: 0x04004C1F RID: 19487
		private bool fieldPrivacyInfo_;

		// Token: 0x04004C20 RID: 19488
		public const int FieldParentalControlInfoFieldNumber = 4;

		// Token: 0x04004C21 RID: 19489
		private static readonly bool FieldParentalControlInfoDefaultValue = false;

		// Token: 0x04004C22 RID: 19490
		private bool fieldParentalControlInfo_;

		// Token: 0x04004C23 RID: 19491
		public const int FieldGameLevelInfoFieldNumber = 6;

		// Token: 0x04004C24 RID: 19492
		private static readonly bool FieldGameLevelInfoDefaultValue = false;

		// Token: 0x04004C25 RID: 19493
		private bool fieldGameLevelInfo_;

		// Token: 0x04004C26 RID: 19494
		public const int FieldGameStatusFieldNumber = 7;

		// Token: 0x04004C27 RID: 19495
		private static readonly bool FieldGameStatusDefaultValue = false;

		// Token: 0x04004C28 RID: 19496
		private bool fieldGameStatus_;

		// Token: 0x04004C29 RID: 19497
		public const int FieldGameAccountsFieldNumber = 8;

		// Token: 0x04004C2A RID: 19498
		private static readonly bool FieldGameAccountsDefaultValue = false;

		// Token: 0x04004C2B RID: 19499
		private bool fieldGameAccounts_;

		// Token: 0x04004C2C RID: 19500
		public const int FieldSecurityStatusFieldNumber = 9;

		// Token: 0x04004C2D RID: 19501
		private static readonly bool FieldSecurityStatusDefaultValue = false;

		// Token: 0x04004C2E RID: 19502
		private bool fieldSecurityStatus_;
	}
}
