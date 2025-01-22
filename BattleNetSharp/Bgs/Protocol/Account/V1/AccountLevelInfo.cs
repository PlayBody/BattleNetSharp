using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x0200073E RID: 1854
	public sealed class AccountLevelInfo : IMessage<AccountLevelInfo>, IMessage, IEquatable<AccountLevelInfo>, IDeepCloneable<AccountLevelInfo>, IBufferMessage
	{
		// Token: 0x17003467 RID: 13415
		// (get) Token: 0x0600A9E2 RID: 43490 RVA: 0x00295EDC File Offset: 0x002940DC
		[DebuggerNonUserCode]
		public static MessageParser<AccountLevelInfo> Parser
		{
			get
			{
				return AccountLevelInfo._parser;
			}
		}

		// Token: 0x17003468 RID: 13416
		// (get) Token: 0x0600A9E3 RID: 43491 RVA: 0x00295EF4 File Offset: 0x002940F4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[14];
			}
		}

		// Token: 0x17003469 RID: 13417
		// (get) Token: 0x0600A9E4 RID: 43492 RVA: 0x00295F18 File Offset: 0x00294118
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccountLevelInfo.Descriptor;
			}
		}

		// Token: 0x0600A9E5 RID: 43493 RVA: 0x00295F2F File Offset: 0x0029412F
		[DebuggerNonUserCode]
		public AccountLevelInfo()
		{
		}

		// Token: 0x0600A9E6 RID: 43494 RVA: 0x00295F50 File Offset: 0x00294150
		[DebuggerNonUserCode]
		public AccountLevelInfo(AccountLevelInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.licenses_ = other.licenses_.Clone();
			this.defaultCurrency_ = other.defaultCurrency_;
			this.country_ = other.country_;
			this.preferredRegion_ = other.preferredRegion_;
			this.fullName_ = other.fullName_;
			this.battleTag_ = other.battleTag_;
			this.muted_ = other.muted_;
			this.manualReview_ = other.manualReview_;
			this.accountPaidAny_ = other.accountPaidAny_;
			this.identityCheckStatus_ = other.identityCheckStatus_;
			this.email_ = other.email_;
			this.headlessAccount_ = other.headlessAccount_;
			this.testAccount_ = other.testAccount_;
			this.restriction_ = other.restriction_.Clone();
			this.isSmsProtected_ = other.isSmsProtected_;
			this.ratingsBoardMinimumAge_ = other.ratingsBoardMinimumAge_;
			this.phoneNumber_ = other.phoneNumber_;
			this.birthdate_ = other.birthdate_;
			this.legalCountryFeatureRestrictionsApplied_ = other.legalCountryFeatureRestrictionsApplied_;
			this.optIns_ = ((other.optIns_ != null) ? other.optIns_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A9E7 RID: 43495 RVA: 0x0029608C File Offset: 0x0029428C
		[DebuggerNonUserCode]
		public AccountLevelInfo Clone()
		{
			return new AccountLevelInfo(this);
		}

		// Token: 0x1700346A RID: 13418
		// (get) Token: 0x0600A9E8 RID: 43496 RVA: 0x002960A4 File Offset: 0x002942A4
		[DebuggerNonUserCode]
		public RepeatedField<AccountLicense> Licenses
		{
			get
			{
				return this.licenses_;
			}
		}

		// Token: 0x1700346B RID: 13419
		// (get) Token: 0x0600A9E9 RID: 43497 RVA: 0x002960BC File Offset: 0x002942BC
		// (set) Token: 0x0600A9EA RID: 43498 RVA: 0x002960ED File Offset: 0x002942ED
		[DebuggerNonUserCode]
		public uint DefaultCurrency
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint defaultCurrencyDefaultValue;
				if (flag)
				{
					defaultCurrencyDefaultValue = this.defaultCurrency_;
				}
				else
				{
					defaultCurrencyDefaultValue = AccountLevelInfo.DefaultCurrencyDefaultValue;
				}
				return defaultCurrencyDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.defaultCurrency_ = value;
			}
		}

		// Token: 0x1700346C RID: 13420
		// (get) Token: 0x0600A9EB RID: 43499 RVA: 0x00296108 File Offset: 0x00294308
		[DebuggerNonUserCode]
		public bool HasDefaultCurrency
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A9EC RID: 43500 RVA: 0x00296125 File Offset: 0x00294325
		[DebuggerNonUserCode]
		public void ClearDefaultCurrency()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700346D RID: 13421
		// (get) Token: 0x0600A9ED RID: 43501 RVA: 0x00296138 File Offset: 0x00294338
		// (set) Token: 0x0600A9EE RID: 43502 RVA: 0x00296159 File Offset: 0x00294359
		[DebuggerNonUserCode]
		public string Country
		{
			get
			{
				return this.country_ ?? AccountLevelInfo.CountryDefaultValue;
			}
			set
			{
				this.country_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700346E RID: 13422
		// (get) Token: 0x0600A9EF RID: 43503 RVA: 0x00296170 File Offset: 0x00294370
		[DebuggerNonUserCode]
		public bool HasCountry
		{
			get
			{
				return this.country_ != null;
			}
		}

		// Token: 0x0600A9F0 RID: 43504 RVA: 0x0029618B File Offset: 0x0029438B
		[DebuggerNonUserCode]
		public void ClearCountry()
		{
			this.country_ = null;
		}

		// Token: 0x1700346F RID: 13423
		// (get) Token: 0x0600A9F1 RID: 43505 RVA: 0x00296198 File Offset: 0x00294398
		// (set) Token: 0x0600A9F2 RID: 43506 RVA: 0x002961C9 File Offset: 0x002943C9
		[DebuggerNonUserCode]
		public uint PreferredRegion
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint preferredRegionDefaultValue;
				if (flag)
				{
					preferredRegionDefaultValue = this.preferredRegion_;
				}
				else
				{
					preferredRegionDefaultValue = AccountLevelInfo.PreferredRegionDefaultValue;
				}
				return preferredRegionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.preferredRegion_ = value;
			}
		}

		// Token: 0x17003470 RID: 13424
		// (get) Token: 0x0600A9F3 RID: 43507 RVA: 0x002961E4 File Offset: 0x002943E4
		[DebuggerNonUserCode]
		public bool HasPreferredRegion
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600A9F4 RID: 43508 RVA: 0x00296201 File Offset: 0x00294401
		[DebuggerNonUserCode]
		public void ClearPreferredRegion()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17003471 RID: 13425
		// (get) Token: 0x0600A9F5 RID: 43509 RVA: 0x00296214 File Offset: 0x00294414
		// (set) Token: 0x0600A9F6 RID: 43510 RVA: 0x00296235 File Offset: 0x00294435
		[DebuggerNonUserCode]
		public string FullName
		{
			get
			{
				return this.fullName_ ?? AccountLevelInfo.FullNameDefaultValue;
			}
			set
			{
				this.fullName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003472 RID: 13426
		// (get) Token: 0x0600A9F7 RID: 43511 RVA: 0x0029624C File Offset: 0x0029444C
		[DebuggerNonUserCode]
		public bool HasFullName
		{
			get
			{
				return this.fullName_ != null;
			}
		}

		// Token: 0x0600A9F8 RID: 43512 RVA: 0x00296267 File Offset: 0x00294467
		[DebuggerNonUserCode]
		public void ClearFullName()
		{
			this.fullName_ = null;
		}

		// Token: 0x17003473 RID: 13427
		// (get) Token: 0x0600A9F9 RID: 43513 RVA: 0x00296274 File Offset: 0x00294474
		// (set) Token: 0x0600A9FA RID: 43514 RVA: 0x00296295 File Offset: 0x00294495
		[DebuggerNonUserCode]
		public string BattleTag
		{
			get
			{
				return this.battleTag_ ?? AccountLevelInfo.BattleTagDefaultValue;
			}
			set
			{
				this.battleTag_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003474 RID: 13428
		// (get) Token: 0x0600A9FB RID: 43515 RVA: 0x002962AC File Offset: 0x002944AC
		[DebuggerNonUserCode]
		public bool HasBattleTag
		{
			get
			{
				return this.battleTag_ != null;
			}
		}

		// Token: 0x0600A9FC RID: 43516 RVA: 0x002962C7 File Offset: 0x002944C7
		[DebuggerNonUserCode]
		public void ClearBattleTag()
		{
			this.battleTag_ = null;
		}

		// Token: 0x17003475 RID: 13429
		// (get) Token: 0x0600A9FD RID: 43517 RVA: 0x002962D4 File Offset: 0x002944D4
		// (set) Token: 0x0600A9FE RID: 43518 RVA: 0x00296305 File Offset: 0x00294505
		[DebuggerNonUserCode]
		public bool Muted
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool mutedDefaultValue;
				if (flag)
				{
					mutedDefaultValue = this.muted_;
				}
				else
				{
					mutedDefaultValue = AccountLevelInfo.MutedDefaultValue;
				}
				return mutedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.muted_ = value;
			}
		}

		// Token: 0x17003476 RID: 13430
		// (get) Token: 0x0600A9FF RID: 43519 RVA: 0x00296320 File Offset: 0x00294520
		[DebuggerNonUserCode]
		public bool HasMuted
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600AA00 RID: 43520 RVA: 0x0029633D File Offset: 0x0029453D
		[DebuggerNonUserCode]
		public void ClearMuted()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17003477 RID: 13431
		// (get) Token: 0x0600AA01 RID: 43521 RVA: 0x00296350 File Offset: 0x00294550
		// (set) Token: 0x0600AA02 RID: 43522 RVA: 0x00296381 File Offset: 0x00294581
		[DebuggerNonUserCode]
		public bool ManualReview
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool manualReviewDefaultValue;
				if (flag)
				{
					manualReviewDefaultValue = this.manualReview_;
				}
				else
				{
					manualReviewDefaultValue = AccountLevelInfo.ManualReviewDefaultValue;
				}
				return manualReviewDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.manualReview_ = value;
			}
		}

		// Token: 0x17003478 RID: 13432
		// (get) Token: 0x0600AA03 RID: 43523 RVA: 0x0029639C File Offset: 0x0029459C
		[DebuggerNonUserCode]
		public bool HasManualReview
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600AA04 RID: 43524 RVA: 0x002963B9 File Offset: 0x002945B9
		[DebuggerNonUserCode]
		public void ClearManualReview()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17003479 RID: 13433
		// (get) Token: 0x0600AA05 RID: 43525 RVA: 0x002963CC File Offset: 0x002945CC
		// (set) Token: 0x0600AA06 RID: 43526 RVA: 0x002963FE File Offset: 0x002945FE
		[DebuggerNonUserCode]
		public bool AccountPaidAny
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool accountPaidAnyDefaultValue;
				if (flag)
				{
					accountPaidAnyDefaultValue = this.accountPaidAny_;
				}
				else
				{
					accountPaidAnyDefaultValue = AccountLevelInfo.AccountPaidAnyDefaultValue;
				}
				return accountPaidAnyDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.accountPaidAny_ = value;
			}
		}

		// Token: 0x1700347A RID: 13434
		// (get) Token: 0x0600AA07 RID: 43527 RVA: 0x00296418 File Offset: 0x00294618
		[DebuggerNonUserCode]
		public bool HasAccountPaidAny
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600AA08 RID: 43528 RVA: 0x00296436 File Offset: 0x00294636
		[DebuggerNonUserCode]
		public void ClearAccountPaidAny()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x1700347B RID: 13435
		// (get) Token: 0x0600AA09 RID: 43529 RVA: 0x00296448 File Offset: 0x00294648
		// (set) Token: 0x0600AA0A RID: 43530 RVA: 0x0029647A File Offset: 0x0029467A
		[DebuggerNonUserCode]
		public IdentityVerificationStatus IdentityCheckStatus
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				IdentityVerificationStatus identityCheckStatusDefaultValue;
				if (flag)
				{
					identityCheckStatusDefaultValue = this.identityCheckStatus_;
				}
				else
				{
					identityCheckStatusDefaultValue = AccountLevelInfo.IdentityCheckStatusDefaultValue;
				}
				return identityCheckStatusDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.identityCheckStatus_ = value;
			}
		}

		// Token: 0x1700347C RID: 13436
		// (get) Token: 0x0600AA0B RID: 43531 RVA: 0x00296494 File Offset: 0x00294694
		[DebuggerNonUserCode]
		public bool HasIdentityCheckStatus
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x0600AA0C RID: 43532 RVA: 0x002964B2 File Offset: 0x002946B2
		[DebuggerNonUserCode]
		public void ClearIdentityCheckStatus()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x1700347D RID: 13437
		// (get) Token: 0x0600AA0D RID: 43533 RVA: 0x002964C4 File Offset: 0x002946C4
		// (set) Token: 0x0600AA0E RID: 43534 RVA: 0x002964E5 File Offset: 0x002946E5
		[DebuggerNonUserCode]
		public string Email
		{
			get
			{
				return this.email_ ?? AccountLevelInfo.EmailDefaultValue;
			}
			set
			{
				this.email_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700347E RID: 13438
		// (get) Token: 0x0600AA0F RID: 43535 RVA: 0x002964FC File Offset: 0x002946FC
		[DebuggerNonUserCode]
		public bool HasEmail
		{
			get
			{
				return this.email_ != null;
			}
		}

		// Token: 0x0600AA10 RID: 43536 RVA: 0x00296517 File Offset: 0x00294717
		[DebuggerNonUserCode]
		public void ClearEmail()
		{
			this.email_ = null;
		}

		// Token: 0x1700347F RID: 13439
		// (get) Token: 0x0600AA11 RID: 43537 RVA: 0x00296524 File Offset: 0x00294724
		// (set) Token: 0x0600AA12 RID: 43538 RVA: 0x00296556 File Offset: 0x00294756
		[DebuggerNonUserCode]
		public bool HeadlessAccount
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				bool headlessAccountDefaultValue;
				if (flag)
				{
					headlessAccountDefaultValue = this.headlessAccount_;
				}
				else
				{
					headlessAccountDefaultValue = AccountLevelInfo.HeadlessAccountDefaultValue;
				}
				return headlessAccountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.headlessAccount_ = value;
			}
		}

		// Token: 0x17003480 RID: 13440
		// (get) Token: 0x0600AA13 RID: 43539 RVA: 0x00296570 File Offset: 0x00294770
		[DebuggerNonUserCode]
		public bool HasHeadlessAccount
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x0600AA14 RID: 43540 RVA: 0x0029658E File Offset: 0x0029478E
		[DebuggerNonUserCode]
		public void ClearHeadlessAccount()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x17003481 RID: 13441
		// (get) Token: 0x0600AA15 RID: 43541 RVA: 0x002965A0 File Offset: 0x002947A0
		// (set) Token: 0x0600AA16 RID: 43542 RVA: 0x002965D5 File Offset: 0x002947D5
		[DebuggerNonUserCode]
		public bool TestAccount
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				bool testAccountDefaultValue;
				if (flag)
				{
					testAccountDefaultValue = this.testAccount_;
				}
				else
				{
					testAccountDefaultValue = AccountLevelInfo.TestAccountDefaultValue;
				}
				return testAccountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.testAccount_ = value;
			}
		}

		// Token: 0x17003482 RID: 13442
		// (get) Token: 0x0600AA17 RID: 43543 RVA: 0x002965F4 File Offset: 0x002947F4
		[DebuggerNonUserCode]
		public bool HasTestAccount
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x0600AA18 RID: 43544 RVA: 0x00296615 File Offset: 0x00294815
		[DebuggerNonUserCode]
		public void ClearTestAccount()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x17003483 RID: 13443
		// (get) Token: 0x0600AA19 RID: 43545 RVA: 0x0029662C File Offset: 0x0029482C
		[DebuggerNonUserCode]
		public RepeatedField<AccountRestriction> Restriction
		{
			get
			{
				return this.restriction_;
			}
		}

		// Token: 0x17003484 RID: 13444
		// (get) Token: 0x0600AA1A RID: 43546 RVA: 0x00296644 File Offset: 0x00294844
		// (set) Token: 0x0600AA1B RID: 43547 RVA: 0x00296679 File Offset: 0x00294879
		[DebuggerNonUserCode]
		public bool IsSmsProtected
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				bool isSmsProtectedDefaultValue;
				if (flag)
				{
					isSmsProtectedDefaultValue = this.isSmsProtected_;
				}
				else
				{
					isSmsProtectedDefaultValue = AccountLevelInfo.IsSmsProtectedDefaultValue;
				}
				return isSmsProtectedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.isSmsProtected_ = value;
			}
		}

		// Token: 0x17003485 RID: 13445
		// (get) Token: 0x0600AA1C RID: 43548 RVA: 0x00296698 File Offset: 0x00294898
		[DebuggerNonUserCode]
		public bool HasIsSmsProtected
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x0600AA1D RID: 43549 RVA: 0x002966B9 File Offset: 0x002948B9
		[DebuggerNonUserCode]
		public void ClearIsSmsProtected()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x17003486 RID: 13446
		// (get) Token: 0x0600AA1E RID: 43550 RVA: 0x002966D0 File Offset: 0x002948D0
		// (set) Token: 0x0600AA1F RID: 43551 RVA: 0x00296705 File Offset: 0x00294905
		[DebuggerNonUserCode]
		public uint RatingsBoardMinimumAge
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				uint ratingsBoardMinimumAgeDefaultValue;
				if (flag)
				{
					ratingsBoardMinimumAgeDefaultValue = this.ratingsBoardMinimumAge_;
				}
				else
				{
					ratingsBoardMinimumAgeDefaultValue = AccountLevelInfo.RatingsBoardMinimumAgeDefaultValue;
				}
				return ratingsBoardMinimumAgeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.ratingsBoardMinimumAge_ = value;
			}
		}

		// Token: 0x17003487 RID: 13447
		// (get) Token: 0x0600AA20 RID: 43552 RVA: 0x00296724 File Offset: 0x00294924
		[DebuggerNonUserCode]
		public bool HasRatingsBoardMinimumAge
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x0600AA21 RID: 43553 RVA: 0x00296745 File Offset: 0x00294945
		[DebuggerNonUserCode]
		public void ClearRatingsBoardMinimumAge()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x17003488 RID: 13448
		// (get) Token: 0x0600AA22 RID: 43554 RVA: 0x0029675C File Offset: 0x0029495C
		// (set) Token: 0x0600AA23 RID: 43555 RVA: 0x0029677D File Offset: 0x0029497D
		[DebuggerNonUserCode]
		public string PhoneNumber
		{
			get
			{
				return this.phoneNumber_ ?? AccountLevelInfo.PhoneNumberDefaultValue;
			}
			set
			{
				this.phoneNumber_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003489 RID: 13449
		// (get) Token: 0x0600AA24 RID: 43556 RVA: 0x00296794 File Offset: 0x00294994
		[DebuggerNonUserCode]
		public bool HasPhoneNumber
		{
			get
			{
				return this.phoneNumber_ != null;
			}
		}

		// Token: 0x0600AA25 RID: 43557 RVA: 0x002967AF File Offset: 0x002949AF
		[DebuggerNonUserCode]
		public void ClearPhoneNumber()
		{
			this.phoneNumber_ = null;
		}

		// Token: 0x1700348A RID: 13450
		// (get) Token: 0x0600AA26 RID: 43558 RVA: 0x002967BC File Offset: 0x002949BC
		// (set) Token: 0x0600AA27 RID: 43559 RVA: 0x002967DD File Offset: 0x002949DD
		[DebuggerNonUserCode]
		public string Birthdate
		{
			get
			{
				return this.birthdate_ ?? AccountLevelInfo.BirthdateDefaultValue;
			}
			set
			{
				this.birthdate_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700348B RID: 13451
		// (get) Token: 0x0600AA28 RID: 43560 RVA: 0x002967F4 File Offset: 0x002949F4
		[DebuggerNonUserCode]
		public bool HasBirthdate
		{
			get
			{
				return this.birthdate_ != null;
			}
		}

		// Token: 0x0600AA29 RID: 43561 RVA: 0x0029680F File Offset: 0x00294A0F
		[DebuggerNonUserCode]
		public void ClearBirthdate()
		{
			this.birthdate_ = null;
		}

		// Token: 0x1700348C RID: 13452
		// (get) Token: 0x0600AA2A RID: 43562 RVA: 0x0029681C File Offset: 0x00294A1C
		// (set) Token: 0x0600AA2B RID: 43563 RVA: 0x00296851 File Offset: 0x00294A51
		[DebuggerNonUserCode]
		public bool LegalCountryFeatureRestrictionsApplied
		{
			get
			{
				bool flag = (this._hasBits0 & 1024) != 0;
				bool legalCountryFeatureRestrictionsAppliedDefaultValue;
				if (flag)
				{
					legalCountryFeatureRestrictionsAppliedDefaultValue = this.legalCountryFeatureRestrictionsApplied_;
				}
				else
				{
					legalCountryFeatureRestrictionsAppliedDefaultValue = AccountLevelInfo.LegalCountryFeatureRestrictionsAppliedDefaultValue;
				}
				return legalCountryFeatureRestrictionsAppliedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1024;
				this.legalCountryFeatureRestrictionsApplied_ = value;
			}
		}

		// Token: 0x1700348D RID: 13453
		// (get) Token: 0x0600AA2C RID: 43564 RVA: 0x00296870 File Offset: 0x00294A70
		[DebuggerNonUserCode]
		public bool HasLegalCountryFeatureRestrictionsApplied
		{
			get
			{
				return (this._hasBits0 & 1024) != 0;
			}
		}

		// Token: 0x0600AA2D RID: 43565 RVA: 0x00296891 File Offset: 0x00294A91
		[DebuggerNonUserCode]
		public void ClearLegalCountryFeatureRestrictionsApplied()
		{
			this._hasBits0 &= -1025;
		}

		// Token: 0x1700348E RID: 13454
		// (get) Token: 0x0600AA2E RID: 43566 RVA: 0x002968A8 File Offset: 0x00294AA8
		// (set) Token: 0x0600AA2F RID: 43567 RVA: 0x002968C0 File Offset: 0x00294AC0
		[DebuggerNonUserCode]
		public OptIns OptIns
		{
			get
			{
				return this.optIns_;
			}
			set
			{
				this.optIns_ = value;
			}
		}

		// Token: 0x0600AA30 RID: 43568 RVA: 0x002968CC File Offset: 0x00294ACC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AccountLevelInfo);
		}

		// Token: 0x0600AA31 RID: 43569 RVA: 0x002968EC File Offset: 0x00294AEC
		[DebuggerNonUserCode]
		public bool Equals(AccountLevelInfo other)
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
					bool flag4 = !this.licenses_.Equals(other.licenses_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.DefaultCurrency != other.DefaultCurrency;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Country != other.Country;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.PreferredRegion != other.PreferredRegion;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.FullName != other.FullName;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.BattleTag != other.BattleTag;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.Muted != other.Muted;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.ManualReview != other.ManualReview;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.AccountPaidAny != other.AccountPaidAny;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.IdentityCheckStatus != other.IdentityCheckStatus;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.Email != other.Email;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.HeadlessAccount != other.HeadlessAccount;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = this.TestAccount != other.TestAccount;
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = !this.restriction_.Equals(other.restriction_);
																		if (flag17)
																		{
																			flag2 = false;
																		}
																		else
																		{
																			bool flag18 = this.IsSmsProtected != other.IsSmsProtected;
																			if (flag18)
																			{
																				flag2 = false;
																			}
																			else
																			{
																				bool flag19 = this.RatingsBoardMinimumAge != other.RatingsBoardMinimumAge;
																				if (flag19)
																				{
																					flag2 = false;
																				}
																				else
																				{
																					bool flag20 = this.PhoneNumber != other.PhoneNumber;
																					if (flag20)
																					{
																						flag2 = false;
																					}
																					else
																					{
																						bool flag21 = this.Birthdate != other.Birthdate;
																						if (flag21)
																						{
																							flag2 = false;
																						}
																						else
																						{
																							bool flag22 = this.LegalCountryFeatureRestrictionsApplied != other.LegalCountryFeatureRestrictionsApplied;
																							if (flag22)
																							{
																								flag2 = false;
																							}
																							else
																							{
																								bool flag23 = !object.Equals(this.OptIns, other.OptIns);
																								flag2 = !flag23 && object.Equals(this._unknownFields, other._unknownFields);
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
				}
			}
			return flag2;
		}

		// Token: 0x0600AA32 RID: 43570 RVA: 0x00296B84 File Offset: 0x00294D84
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.licenses_.GetHashCode();
			bool hasDefaultCurrency = this.HasDefaultCurrency;
			if (hasDefaultCurrency)
			{
				num ^= this.DefaultCurrency.GetHashCode();
			}
			bool hasCountry = this.HasCountry;
			if (hasCountry)
			{
				num ^= this.Country.GetHashCode();
			}
			bool hasPreferredRegion = this.HasPreferredRegion;
			if (hasPreferredRegion)
			{
				num ^= this.PreferredRegion.GetHashCode();
			}
			bool hasFullName = this.HasFullName;
			if (hasFullName)
			{
				num ^= this.FullName.GetHashCode();
			}
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				num ^= this.BattleTag.GetHashCode();
			}
			bool hasMuted = this.HasMuted;
			if (hasMuted)
			{
				num ^= this.Muted.GetHashCode();
			}
			bool hasManualReview = this.HasManualReview;
			if (hasManualReview)
			{
				num ^= this.ManualReview.GetHashCode();
			}
			bool hasAccountPaidAny = this.HasAccountPaidAny;
			if (hasAccountPaidAny)
			{
				num ^= this.AccountPaidAny.GetHashCode();
			}
			bool hasIdentityCheckStatus = this.HasIdentityCheckStatus;
			if (hasIdentityCheckStatus)
			{
				num ^= this.IdentityCheckStatus.GetHashCode();
			}
			bool hasEmail = this.HasEmail;
			if (hasEmail)
			{
				num ^= this.Email.GetHashCode();
			}
			bool hasHeadlessAccount = this.HasHeadlessAccount;
			if (hasHeadlessAccount)
			{
				num ^= this.HeadlessAccount.GetHashCode();
			}
			bool hasTestAccount = this.HasTestAccount;
			if (hasTestAccount)
			{
				num ^= this.TestAccount.GetHashCode();
			}
			num ^= this.restriction_.GetHashCode();
			bool hasIsSmsProtected = this.HasIsSmsProtected;
			if (hasIsSmsProtected)
			{
				num ^= this.IsSmsProtected.GetHashCode();
			}
			bool hasRatingsBoardMinimumAge = this.HasRatingsBoardMinimumAge;
			if (hasRatingsBoardMinimumAge)
			{
				num ^= this.RatingsBoardMinimumAge.GetHashCode();
			}
			bool hasPhoneNumber = this.HasPhoneNumber;
			if (hasPhoneNumber)
			{
				num ^= this.PhoneNumber.GetHashCode();
			}
			bool hasBirthdate = this.HasBirthdate;
			if (hasBirthdate)
			{
				num ^= this.Birthdate.GetHashCode();
			}
			bool hasLegalCountryFeatureRestrictionsApplied = this.HasLegalCountryFeatureRestrictionsApplied;
			if (hasLegalCountryFeatureRestrictionsApplied)
			{
				num ^= this.LegalCountryFeatureRestrictionsApplied.GetHashCode();
			}
			bool flag = this.optIns_ != null;
			if (flag)
			{
				num ^= this.OptIns.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AA33 RID: 43571 RVA: 0x00296DD8 File Offset: 0x00294FD8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AA34 RID: 43572 RVA: 0x00296DF0 File Offset: 0x00294FF0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AA35 RID: 43573 RVA: 0x00296DFC File Offset: 0x00294FFC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.licenses_.WriteTo(ref output, AccountLevelInfo._repeated_licenses_codec);
			bool hasDefaultCurrency = this.HasDefaultCurrency;
			if (hasDefaultCurrency)
			{
				output.WriteRawTag(37);
				output.WriteFixed32(this.DefaultCurrency);
			}
			bool hasCountry = this.HasCountry;
			if (hasCountry)
			{
				output.WriteRawTag(42);
				output.WriteString(this.Country);
			}
			bool hasPreferredRegion = this.HasPreferredRegion;
			if (hasPreferredRegion)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.PreferredRegion);
			}
			bool hasFullName = this.HasFullName;
			if (hasFullName)
			{
				output.WriteRawTag(58);
				output.WriteString(this.FullName);
			}
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				output.WriteRawTag(66);
				output.WriteString(this.BattleTag);
			}
			bool hasMuted = this.HasMuted;
			if (hasMuted)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.Muted);
			}
			bool hasManualReview = this.HasManualReview;
			if (hasManualReview)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.ManualReview);
			}
			bool hasAccountPaidAny = this.HasAccountPaidAny;
			if (hasAccountPaidAny)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.AccountPaidAny);
			}
			bool hasIdentityCheckStatus = this.HasIdentityCheckStatus;
			if (hasIdentityCheckStatus)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.IdentityCheckStatus);
			}
			bool hasEmail = this.HasEmail;
			if (hasEmail)
			{
				output.WriteRawTag(106);
				output.WriteString(this.Email);
			}
			bool hasHeadlessAccount = this.HasHeadlessAccount;
			if (hasHeadlessAccount)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.HeadlessAccount);
			}
			bool hasTestAccount = this.HasTestAccount;
			if (hasTestAccount)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.TestAccount);
			}
			this.restriction_.WriteTo(ref output, AccountLevelInfo._repeated_restriction_codec);
			bool hasIsSmsProtected = this.HasIsSmsProtected;
			if (hasIsSmsProtected)
			{
				output.WriteRawTag(136, 1);
				output.WriteBool(this.IsSmsProtected);
			}
			bool hasRatingsBoardMinimumAge = this.HasRatingsBoardMinimumAge;
			if (hasRatingsBoardMinimumAge)
			{
				output.WriteRawTag(144, 1);
				output.WriteUInt32(this.RatingsBoardMinimumAge);
			}
			bool hasPhoneNumber = this.HasPhoneNumber;
			if (hasPhoneNumber)
			{
				output.WriteRawTag(154, 1);
				output.WriteString(this.PhoneNumber);
			}
			bool hasBirthdate = this.HasBirthdate;
			if (hasBirthdate)
			{
				output.WriteRawTag(162, 1);
				output.WriteString(this.Birthdate);
			}
			bool hasLegalCountryFeatureRestrictionsApplied = this.HasLegalCountryFeatureRestrictionsApplied;
			if (hasLegalCountryFeatureRestrictionsApplied)
			{
				output.WriteRawTag(168, 1);
				output.WriteBool(this.LegalCountryFeatureRestrictionsApplied);
			}
			bool flag = this.optIns_ != null;
			if (flag)
			{
				output.WriteRawTag(178, 1);
				output.WriteMessage(this.OptIns);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AA36 RID: 43574 RVA: 0x002970E8 File Offset: 0x002952E8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.licenses_.CalculateSize(AccountLevelInfo._repeated_licenses_codec);
			bool hasDefaultCurrency = this.HasDefaultCurrency;
			if (hasDefaultCurrency)
			{
				num += 5;
			}
			bool hasCountry = this.HasCountry;
			if (hasCountry)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Country);
			}
			bool hasPreferredRegion = this.HasPreferredRegion;
			if (hasPreferredRegion)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PreferredRegion);
			}
			bool hasFullName = this.HasFullName;
			if (hasFullName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FullName);
			}
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.BattleTag);
			}
			bool hasMuted = this.HasMuted;
			if (hasMuted)
			{
				num += 2;
			}
			bool hasManualReview = this.HasManualReview;
			if (hasManualReview)
			{
				num += 2;
			}
			bool hasAccountPaidAny = this.HasAccountPaidAny;
			if (hasAccountPaidAny)
			{
				num += 2;
			}
			bool hasIdentityCheckStatus = this.HasIdentityCheckStatus;
			if (hasIdentityCheckStatus)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.IdentityCheckStatus);
			}
			bool hasEmail = this.HasEmail;
			if (hasEmail)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Email);
			}
			bool hasHeadlessAccount = this.HasHeadlessAccount;
			if (hasHeadlessAccount)
			{
				num += 2;
			}
			bool hasTestAccount = this.HasTestAccount;
			if (hasTestAccount)
			{
				num += 2;
			}
			num += this.restriction_.CalculateSize(AccountLevelInfo._repeated_restriction_codec);
			bool hasIsSmsProtected = this.HasIsSmsProtected;
			if (hasIsSmsProtected)
			{
				num += 3;
			}
			bool hasRatingsBoardMinimumAge = this.HasRatingsBoardMinimumAge;
			if (hasRatingsBoardMinimumAge)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.RatingsBoardMinimumAge);
			}
			bool hasPhoneNumber = this.HasPhoneNumber;
			if (hasPhoneNumber)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.PhoneNumber);
			}
			bool hasBirthdate = this.HasBirthdate;
			if (hasBirthdate)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.Birthdate);
			}
			bool hasLegalCountryFeatureRestrictionsApplied = this.HasLegalCountryFeatureRestrictionsApplied;
			if (hasLegalCountryFeatureRestrictionsApplied)
			{
				num += 3;
			}
			bool flag = this.optIns_ != null;
			if (flag)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.OptIns);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AA37 RID: 43575 RVA: 0x00297300 File Offset: 0x00295500
		[DebuggerNonUserCode]
		public void MergeFrom(AccountLevelInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.licenses_.Add(other.licenses_);
				bool hasDefaultCurrency = other.HasDefaultCurrency;
				if (hasDefaultCurrency)
				{
					this.DefaultCurrency = other.DefaultCurrency;
				}
				bool hasCountry = other.HasCountry;
				if (hasCountry)
				{
					this.Country = other.Country;
				}
				bool hasPreferredRegion = other.HasPreferredRegion;
				if (hasPreferredRegion)
				{
					this.PreferredRegion = other.PreferredRegion;
				}
				bool hasFullName = other.HasFullName;
				if (hasFullName)
				{
					this.FullName = other.FullName;
				}
				bool hasBattleTag = other.HasBattleTag;
				if (hasBattleTag)
				{
					this.BattleTag = other.BattleTag;
				}
				bool hasMuted = other.HasMuted;
				if (hasMuted)
				{
					this.Muted = other.Muted;
				}
				bool hasManualReview = other.HasManualReview;
				if (hasManualReview)
				{
					this.ManualReview = other.ManualReview;
				}
				bool hasAccountPaidAny = other.HasAccountPaidAny;
				if (hasAccountPaidAny)
				{
					this.AccountPaidAny = other.AccountPaidAny;
				}
				bool hasIdentityCheckStatus = other.HasIdentityCheckStatus;
				if (hasIdentityCheckStatus)
				{
					this.IdentityCheckStatus = other.IdentityCheckStatus;
				}
				bool hasEmail = other.HasEmail;
				if (hasEmail)
				{
					this.Email = other.Email;
				}
				bool hasHeadlessAccount = other.HasHeadlessAccount;
				if (hasHeadlessAccount)
				{
					this.HeadlessAccount = other.HeadlessAccount;
				}
				bool hasTestAccount = other.HasTestAccount;
				if (hasTestAccount)
				{
					this.TestAccount = other.TestAccount;
				}
				this.restriction_.Add(other.restriction_);
				bool hasIsSmsProtected = other.HasIsSmsProtected;
				if (hasIsSmsProtected)
				{
					this.IsSmsProtected = other.IsSmsProtected;
				}
				bool hasRatingsBoardMinimumAge = other.HasRatingsBoardMinimumAge;
				if (hasRatingsBoardMinimumAge)
				{
					this.RatingsBoardMinimumAge = other.RatingsBoardMinimumAge;
				}
				bool hasPhoneNumber = other.HasPhoneNumber;
				if (hasPhoneNumber)
				{
					this.PhoneNumber = other.PhoneNumber;
				}
				bool hasBirthdate = other.HasBirthdate;
				if (hasBirthdate)
				{
					this.Birthdate = other.Birthdate;
				}
				bool hasLegalCountryFeatureRestrictionsApplied = other.HasLegalCountryFeatureRestrictionsApplied;
				if (hasLegalCountryFeatureRestrictionsApplied)
				{
					this.LegalCountryFeatureRestrictionsApplied = other.LegalCountryFeatureRestrictionsApplied;
				}
				bool flag2 = other.optIns_ != null;
				if (flag2)
				{
					bool flag3 = this.optIns_ == null;
					if (flag3)
					{
						this.OptIns = new OptIns();
					}
					this.OptIns.MergeFrom(other.OptIns);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600AA38 RID: 43576 RVA: 0x0029755C File Offset: 0x0029575C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AA39 RID: 43577 RVA: 0x00297568 File Offset: 0x00295768
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 96U)
				{
					if (num3 <= 58U)
					{
						if (num3 <= 37U)
						{
							if (num3 != 26U)
							{
								if (num3 != 37U)
								{
									goto IL_011D;
								}
								this.DefaultCurrency = input.ReadFixed32();
							}
							else
							{
								this.licenses_.AddEntriesFrom(ref input, AccountLevelInfo._repeated_licenses_codec);
							}
						}
						else if (num3 != 42U)
						{
							if (num3 != 48U)
							{
								if (num3 != 58U)
								{
									goto IL_011D;
								}
								this.FullName = input.ReadString();
							}
							else
							{
								this.PreferredRegion = input.ReadUInt32();
							}
						}
						else
						{
							this.Country = input.ReadString();
						}
					}
					else if (num3 <= 72U)
					{
						if (num3 != 66U)
						{
							if (num3 != 72U)
							{
								goto IL_011D;
							}
							this.Muted = input.ReadBool();
						}
						else
						{
							this.BattleTag = input.ReadString();
						}
					}
					else if (num3 != 80U)
					{
						if (num3 != 88U)
						{
							if (num3 != 96U)
							{
								goto IL_011D;
							}
							this.IdentityCheckStatus = (IdentityVerificationStatus)input.ReadEnum();
						}
						else
						{
							this.AccountPaidAny = input.ReadBool();
						}
					}
					else
					{
						this.ManualReview = input.ReadBool();
					}
				}
				else if (num3 <= 136U)
				{
					if (num3 <= 112U)
					{
						if (num3 != 106U)
						{
							if (num3 != 112U)
							{
								goto IL_011D;
							}
							this.HeadlessAccount = input.ReadBool();
						}
						else
						{
							this.Email = input.ReadString();
						}
					}
					else if (num3 != 120U)
					{
						if (num3 != 130U)
						{
							if (num3 != 136U)
							{
								goto IL_011D;
							}
							this.IsSmsProtected = input.ReadBool();
						}
						else
						{
							this.restriction_.AddEntriesFrom(ref input, AccountLevelInfo._repeated_restriction_codec);
						}
					}
					else
					{
						this.TestAccount = input.ReadBool();
					}
				}
				else if (num3 <= 154U)
				{
					if (num3 != 144U)
					{
						if (num3 != 154U)
						{
							goto IL_011D;
						}
						this.PhoneNumber = input.ReadString();
					}
					else
					{
						this.RatingsBoardMinimumAge = input.ReadUInt32();
					}
				}
				else if (num3 != 162U)
				{
					if (num3 != 168U)
					{
						if (num3 != 178U)
						{
							goto IL_011D;
						}
						bool flag = this.optIns_ == null;
						if (flag)
						{
							this.OptIns = new OptIns();
						}
						input.ReadMessage(this.OptIns);
					}
					else
					{
						this.LegalCountryFeatureRestrictionsApplied = input.ReadBool();
					}
				}
				else
				{
					this.Birthdate = input.ReadString();
				}
				continue;
				IL_011D:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004C64 RID: 19556
		private static readonly MessageParser<AccountLevelInfo> _parser = new MessageParser<AccountLevelInfo>(() => new AccountLevelInfo());

		// Token: 0x04004C65 RID: 19557
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C66 RID: 19558
		private int _hasBits0;

		// Token: 0x04004C67 RID: 19559
		public const int LicensesFieldNumber = 3;

		// Token: 0x04004C68 RID: 19560
		private static readonly FieldCodec<AccountLicense> _repeated_licenses_codec = FieldCodec.ForMessage<AccountLicense>(26U, AccountLicense.Parser);

		// Token: 0x04004C69 RID: 19561
		private readonly RepeatedField<AccountLicense> licenses_ = new RepeatedField<AccountLicense>();

		// Token: 0x04004C6A RID: 19562
		public const int DefaultCurrencyFieldNumber = 4;

		// Token: 0x04004C6B RID: 19563
		private static readonly uint DefaultCurrencyDefaultValue = 0U;

		// Token: 0x04004C6C RID: 19564
		private uint defaultCurrency_;

		// Token: 0x04004C6D RID: 19565
		public const int CountryFieldNumber = 5;

		// Token: 0x04004C6E RID: 19566
		private static readonly string CountryDefaultValue = "";

		// Token: 0x04004C6F RID: 19567
		private string country_;

		// Token: 0x04004C70 RID: 19568
		public const int PreferredRegionFieldNumber = 6;

		// Token: 0x04004C71 RID: 19569
		private static readonly uint PreferredRegionDefaultValue = 0U;

		// Token: 0x04004C72 RID: 19570
		private uint preferredRegion_;

		// Token: 0x04004C73 RID: 19571
		public const int FullNameFieldNumber = 7;

		// Token: 0x04004C74 RID: 19572
		private static readonly string FullNameDefaultValue = "";

		// Token: 0x04004C75 RID: 19573
		private string fullName_;

		// Token: 0x04004C76 RID: 19574
		public const int BattleTagFieldNumber = 8;

		// Token: 0x04004C77 RID: 19575
		private static readonly string BattleTagDefaultValue = "";

		// Token: 0x04004C78 RID: 19576
		private string battleTag_;

		// Token: 0x04004C79 RID: 19577
		public const int MutedFieldNumber = 9;

		// Token: 0x04004C7A RID: 19578
		private static readonly bool MutedDefaultValue = false;

		// Token: 0x04004C7B RID: 19579
		private bool muted_;

		// Token: 0x04004C7C RID: 19580
		public const int ManualReviewFieldNumber = 10;

		// Token: 0x04004C7D RID: 19581
		private static readonly bool ManualReviewDefaultValue = false;

		// Token: 0x04004C7E RID: 19582
		private bool manualReview_;

		// Token: 0x04004C7F RID: 19583
		public const int AccountPaidAnyFieldNumber = 11;

		// Token: 0x04004C80 RID: 19584
		private static readonly bool AccountPaidAnyDefaultValue = false;

		// Token: 0x04004C81 RID: 19585
		private bool accountPaidAny_;

		// Token: 0x04004C82 RID: 19586
		public const int IdentityCheckStatusFieldNumber = 12;

		// Token: 0x04004C83 RID: 19587
		private static readonly IdentityVerificationStatus IdentityCheckStatusDefaultValue = IdentityVerificationStatus.IdentNoData;

		// Token: 0x04004C84 RID: 19588
		private IdentityVerificationStatus identityCheckStatus_;

		// Token: 0x04004C85 RID: 19589
		public const int EmailFieldNumber = 13;

		// Token: 0x04004C86 RID: 19590
		private static readonly string EmailDefaultValue = "";

		// Token: 0x04004C87 RID: 19591
		private string email_;

		// Token: 0x04004C88 RID: 19592
		public const int HeadlessAccountFieldNumber = 14;

		// Token: 0x04004C89 RID: 19593
		private static readonly bool HeadlessAccountDefaultValue = false;

		// Token: 0x04004C8A RID: 19594
		private bool headlessAccount_;

		// Token: 0x04004C8B RID: 19595
		public const int TestAccountFieldNumber = 15;

		// Token: 0x04004C8C RID: 19596
		private static readonly bool TestAccountDefaultValue = false;

		// Token: 0x04004C8D RID: 19597
		private bool testAccount_;

		// Token: 0x04004C8E RID: 19598
		public const int RestrictionFieldNumber = 16;

		// Token: 0x04004C8F RID: 19599
		private static readonly FieldCodec<AccountRestriction> _repeated_restriction_codec = FieldCodec.ForMessage<AccountRestriction>(130U, AccountRestriction.Parser);

		// Token: 0x04004C90 RID: 19600
		private readonly RepeatedField<AccountRestriction> restriction_ = new RepeatedField<AccountRestriction>();

		// Token: 0x04004C91 RID: 19601
		public const int IsSmsProtectedFieldNumber = 17;

		// Token: 0x04004C92 RID: 19602
		private static readonly bool IsSmsProtectedDefaultValue = false;

		// Token: 0x04004C93 RID: 19603
		private bool isSmsProtected_;

		// Token: 0x04004C94 RID: 19604
		public const int RatingsBoardMinimumAgeFieldNumber = 18;

		// Token: 0x04004C95 RID: 19605
		private static readonly uint RatingsBoardMinimumAgeDefaultValue = 0U;

		// Token: 0x04004C96 RID: 19606
		private uint ratingsBoardMinimumAge_;

		// Token: 0x04004C97 RID: 19607
		public const int PhoneNumberFieldNumber = 19;

		// Token: 0x04004C98 RID: 19608
		private static readonly string PhoneNumberDefaultValue = "";

		// Token: 0x04004C99 RID: 19609
		private string phoneNumber_;

		// Token: 0x04004C9A RID: 19610
		public const int BirthdateFieldNumber = 20;

		// Token: 0x04004C9B RID: 19611
		private static readonly string BirthdateDefaultValue = "";

		// Token: 0x04004C9C RID: 19612
		private string birthdate_;

		// Token: 0x04004C9D RID: 19613
		public const int LegalCountryFeatureRestrictionsAppliedFieldNumber = 21;

		// Token: 0x04004C9E RID: 19614
		private static readonly bool LegalCountryFeatureRestrictionsAppliedDefaultValue = false;

		// Token: 0x04004C9F RID: 19615
		private bool legalCountryFeatureRestrictionsApplied_;

		// Token: 0x04004CA0 RID: 19616
		public const int OptInsFieldNumber = 22;

		// Token: 0x04004CA1 RID: 19617
		private OptIns optIns_;
	}
}
