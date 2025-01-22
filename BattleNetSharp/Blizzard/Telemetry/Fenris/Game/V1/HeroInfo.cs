using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Game.V1
{
	// Token: 0x020002EC RID: 748
	public sealed class HeroInfo : IMessage<HeroInfo>, IMessage, IEquatable<HeroInfo>, IDeepCloneable<HeroInfo>, IBufferMessage
	{
		// Token: 0x1700190C RID: 6412
		// (get) Token: 0x06004EC4 RID: 20164 RVA: 0x0012DF3C File Offset: 0x0012C13C
		[DebuggerNonUserCode]
		public static MessageParser<HeroInfo> Parser
		{
			get
			{
				return HeroInfo._parser;
			}
		}

		// Token: 0x1700190D RID: 6413
		// (get) Token: 0x06004EC5 RID: 20165 RVA: 0x0012DF54 File Offset: 0x0012C154
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700190E RID: 6414
		// (get) Token: 0x06004EC6 RID: 20166 RVA: 0x0012DF78 File Offset: 0x0012C178
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeroInfo.Descriptor;
			}
		}

		// Token: 0x06004EC7 RID: 20167 RVA: 0x0012DF8F File Offset: 0x0012C18F
		[DebuggerNonUserCode]
		public HeroInfo()
		{
		}

		// Token: 0x06004EC8 RID: 20168 RVA: 0x0012DFA4 File Offset: 0x0012C1A4
		[DebuggerNonUserCode]
		public HeroInfo(HeroInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.heroId_ = other.heroId_;
			this.accountId_ = other.accountId_;
			this.gameAccountId_ = other.gameAccountId_;
			this.partyId_ = other.partyId_;
			this.heroClass_ = other.heroClass_;
			this.timePlayed_ = other.timePlayed_;
			this.heroLevel_ = other.heroLevel_;
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this.combatInfo_ = ((other.combatInfo_ != null) ? other.combatInfo_.Clone() : null);
			this.sessionId_ = other.sessionId_;
			this.personaIndex_ = other.personaIndex_;
			this.hairDyeIndex_ = other.hairDyeIndex_;
			this.snoFace_ = other.snoFace_;
			this.clanId_ = other.clanId_;
			this.gameHandle_ = ((other.gameHandle_ != null) ? other.gameHandle_.Clone() : null);
			this.paragonLevel_ = other.paragonLevel_;
			this.v2ClanId_ = other.v2ClanId_;
			this.equippedItems_ = other.equippedItems_.Clone();
			this.worldTier_ = other.worldTier_;
			this.platform_ = other.platform_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004EC9 RID: 20169 RVA: 0x0012E0FC File Offset: 0x0012C2FC
		[DebuggerNonUserCode]
		public HeroInfo Clone()
		{
			return new HeroInfo(this);
		}

		// Token: 0x1700190F RID: 6415
		// (get) Token: 0x06004ECA RID: 20170 RVA: 0x0012E114 File Offset: 0x0012C314
		// (set) Token: 0x06004ECB RID: 20171 RVA: 0x0012E135 File Offset: 0x0012C335
		[DebuggerNonUserCode]
		public string HeroId
		{
			get
			{
				return this.heroId_ ?? HeroInfo.HeroIdDefaultValue;
			}
			set
			{
				this.heroId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001910 RID: 6416
		// (get) Token: 0x06004ECC RID: 20172 RVA: 0x0012E14C File Offset: 0x0012C34C
		[DebuggerNonUserCode]
		public bool HasHeroId
		{
			get
			{
				return this.heroId_ != null;
			}
		}

		// Token: 0x06004ECD RID: 20173 RVA: 0x0012E167 File Offset: 0x0012C367
		[DebuggerNonUserCode]
		public void ClearHeroId()
		{
			this.heroId_ = null;
		}

		// Token: 0x17001911 RID: 6417
		// (get) Token: 0x06004ECE RID: 20174 RVA: 0x0012E174 File Offset: 0x0012C374
		// (set) Token: 0x06004ECF RID: 20175 RVA: 0x0012E1A5 File Offset: 0x0012C3A5
		[DebuggerNonUserCode]
		public uint AccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint accountIdDefaultValue;
				if (flag)
				{
					accountIdDefaultValue = this.accountId_;
				}
				else
				{
					accountIdDefaultValue = HeroInfo.AccountIdDefaultValue;
				}
				return accountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.accountId_ = value;
			}
		}

		// Token: 0x17001912 RID: 6418
		// (get) Token: 0x06004ED0 RID: 20176 RVA: 0x0012E1C0 File Offset: 0x0012C3C0
		[DebuggerNonUserCode]
		public bool HasAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004ED1 RID: 20177 RVA: 0x0012E1DD File Offset: 0x0012C3DD
		[DebuggerNonUserCode]
		public void ClearAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001913 RID: 6419
		// (get) Token: 0x06004ED2 RID: 20178 RVA: 0x0012E1F0 File Offset: 0x0012C3F0
		// (set) Token: 0x06004ED3 RID: 20179 RVA: 0x0012E225 File Offset: 0x0012C425
		[DebuggerNonUserCode]
		public uint GameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				uint gameAccountIdDefaultValue;
				if (flag)
				{
					gameAccountIdDefaultValue = this.gameAccountId_;
				}
				else
				{
					gameAccountIdDefaultValue = HeroInfo.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x17001914 RID: 6420
		// (get) Token: 0x06004ED4 RID: 20180 RVA: 0x0012E244 File Offset: 0x0012C444
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x06004ED5 RID: 20181 RVA: 0x0012E265 File Offset: 0x0012C465
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x17001915 RID: 6421
		// (get) Token: 0x06004ED6 RID: 20182 RVA: 0x0012E27C File Offset: 0x0012C47C
		// (set) Token: 0x06004ED7 RID: 20183 RVA: 0x0012E29D File Offset: 0x0012C49D
		[DebuggerNonUserCode]
		public string PartyId
		{
			get
			{
				return this.partyId_ ?? HeroInfo.PartyIdDefaultValue;
			}
			set
			{
				this.partyId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001916 RID: 6422
		// (get) Token: 0x06004ED8 RID: 20184 RVA: 0x0012E2B4 File Offset: 0x0012C4B4
		[DebuggerNonUserCode]
		public bool HasPartyId
		{
			get
			{
				return this.partyId_ != null;
			}
		}

		// Token: 0x06004ED9 RID: 20185 RVA: 0x0012E2CF File Offset: 0x0012C4CF
		[DebuggerNonUserCode]
		public void ClearPartyId()
		{
			this.partyId_ = null;
		}

		// Token: 0x17001917 RID: 6423
		// (get) Token: 0x06004EDA RID: 20186 RVA: 0x0012E2DC File Offset: 0x0012C4DC
		// (set) Token: 0x06004EDB RID: 20187 RVA: 0x0012E30D File Offset: 0x0012C50D
		[DebuggerNonUserCode]
		public int HeroClass
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int heroClassDefaultValue;
				if (flag)
				{
					heroClassDefaultValue = this.heroClass_;
				}
				else
				{
					heroClassDefaultValue = HeroInfo.HeroClassDefaultValue;
				}
				return heroClassDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.heroClass_ = value;
			}
		}

		// Token: 0x17001918 RID: 6424
		// (get) Token: 0x06004EDC RID: 20188 RVA: 0x0012E328 File Offset: 0x0012C528
		[DebuggerNonUserCode]
		public bool HasHeroClass
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004EDD RID: 20189 RVA: 0x0012E345 File Offset: 0x0012C545
		[DebuggerNonUserCode]
		public void ClearHeroClass()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001919 RID: 6425
		// (get) Token: 0x06004EDE RID: 20190 RVA: 0x0012E358 File Offset: 0x0012C558
		// (set) Token: 0x06004EDF RID: 20191 RVA: 0x0012E389 File Offset: 0x0012C589
		[DebuggerNonUserCode]
		public uint TimePlayed
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint timePlayedDefaultValue;
				if (flag)
				{
					timePlayedDefaultValue = this.timePlayed_;
				}
				else
				{
					timePlayedDefaultValue = HeroInfo.TimePlayedDefaultValue;
				}
				return timePlayedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.timePlayed_ = value;
			}
		}

		// Token: 0x1700191A RID: 6426
		// (get) Token: 0x06004EE0 RID: 20192 RVA: 0x0012E3A4 File Offset: 0x0012C5A4
		[DebuggerNonUserCode]
		public bool HasTimePlayed
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06004EE1 RID: 20193 RVA: 0x0012E3C1 File Offset: 0x0012C5C1
		[DebuggerNonUserCode]
		public void ClearTimePlayed()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x1700191B RID: 6427
		// (get) Token: 0x06004EE2 RID: 20194 RVA: 0x0012E3D4 File Offset: 0x0012C5D4
		// (set) Token: 0x06004EE3 RID: 20195 RVA: 0x0012E405 File Offset: 0x0012C605
		[DebuggerNonUserCode]
		public int HeroLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int heroLevelDefaultValue;
				if (flag)
				{
					heroLevelDefaultValue = this.heroLevel_;
				}
				else
				{
					heroLevelDefaultValue = HeroInfo.HeroLevelDefaultValue;
				}
				return heroLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.heroLevel_ = value;
			}
		}

		// Token: 0x1700191C RID: 6428
		// (get) Token: 0x06004EE4 RID: 20196 RVA: 0x0012E420 File Offset: 0x0012C620
		[DebuggerNonUserCode]
		public bool HasHeroLevel
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06004EE5 RID: 20197 RVA: 0x0012E43D File Offset: 0x0012C63D
		[DebuggerNonUserCode]
		public void ClearHeroLevel()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x1700191D RID: 6429
		// (get) Token: 0x06004EE6 RID: 20198 RVA: 0x0012E450 File Offset: 0x0012C650
		// (set) Token: 0x06004EE7 RID: 20199 RVA: 0x0012E468 File Offset: 0x0012C668
		[DebuggerNonUserCode]
		public HeroLocation Location
		{
			get
			{
				return this.location_;
			}
			set
			{
				this.location_ = value;
			}
		}

		// Token: 0x1700191E RID: 6430
		// (get) Token: 0x06004EE8 RID: 20200 RVA: 0x0012E474 File Offset: 0x0012C674
		// (set) Token: 0x06004EE9 RID: 20201 RVA: 0x0012E48C File Offset: 0x0012C68C
		[DebuggerNonUserCode]
		public HeroCombatInfo CombatInfo
		{
			get
			{
				return this.combatInfo_;
			}
			set
			{
				this.combatInfo_ = value;
			}
		}

		// Token: 0x1700191F RID: 6431
		// (get) Token: 0x06004EEA RID: 20202 RVA: 0x0012E498 File Offset: 0x0012C698
		// (set) Token: 0x06004EEB RID: 20203 RVA: 0x0012E4B9 File Offset: 0x0012C6B9
		[DebuggerNonUserCode]
		public string SessionId
		{
			get
			{
				return this.sessionId_ ?? HeroInfo.SessionIdDefaultValue;
			}
			set
			{
				this.sessionId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001920 RID: 6432
		// (get) Token: 0x06004EEC RID: 20204 RVA: 0x0012E4D0 File Offset: 0x0012C6D0
		[DebuggerNonUserCode]
		public bool HasSessionId
		{
			get
			{
				return this.sessionId_ != null;
			}
		}

		// Token: 0x06004EED RID: 20205 RVA: 0x0012E4EB File Offset: 0x0012C6EB
		[DebuggerNonUserCode]
		public void ClearSessionId()
		{
			this.sessionId_ = null;
		}

		// Token: 0x17001921 RID: 6433
		// (get) Token: 0x06004EEE RID: 20206 RVA: 0x0012E4F8 File Offset: 0x0012C6F8
		// (set) Token: 0x06004EEF RID: 20207 RVA: 0x0012E52A File Offset: 0x0012C72A
		[DebuggerNonUserCode]
		public int PersonaIndex
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				int personaIndexDefaultValue;
				if (flag)
				{
					personaIndexDefaultValue = this.personaIndex_;
				}
				else
				{
					personaIndexDefaultValue = HeroInfo.PersonaIndexDefaultValue;
				}
				return personaIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.personaIndex_ = value;
			}
		}

		// Token: 0x17001922 RID: 6434
		// (get) Token: 0x06004EF0 RID: 20208 RVA: 0x0012E544 File Offset: 0x0012C744
		[DebuggerNonUserCode]
		public bool HasPersonaIndex
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06004EF1 RID: 20209 RVA: 0x0012E562 File Offset: 0x0012C762
		[DebuggerNonUserCode]
		public void ClearPersonaIndex()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17001923 RID: 6435
		// (get) Token: 0x06004EF2 RID: 20210 RVA: 0x0012E574 File Offset: 0x0012C774
		// (set) Token: 0x06004EF3 RID: 20211 RVA: 0x0012E5A6 File Offset: 0x0012C7A6
		[DebuggerNonUserCode]
		public int HairDyeIndex
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				int hairDyeIndexDefaultValue;
				if (flag)
				{
					hairDyeIndexDefaultValue = this.hairDyeIndex_;
				}
				else
				{
					hairDyeIndexDefaultValue = HeroInfo.HairDyeIndexDefaultValue;
				}
				return hairDyeIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.hairDyeIndex_ = value;
			}
		}

		// Token: 0x17001924 RID: 6436
		// (get) Token: 0x06004EF4 RID: 20212 RVA: 0x0012E5C0 File Offset: 0x0012C7C0
		[DebuggerNonUserCode]
		public bool HasHairDyeIndex
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06004EF5 RID: 20213 RVA: 0x0012E5DE File Offset: 0x0012C7DE
		[DebuggerNonUserCode]
		public void ClearHairDyeIndex()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17001925 RID: 6437
		// (get) Token: 0x06004EF6 RID: 20214 RVA: 0x0012E5F0 File Offset: 0x0012C7F0
		// (set) Token: 0x06004EF7 RID: 20215 RVA: 0x0012E625 File Offset: 0x0012C825
		[DebuggerNonUserCode]
		public int SnoFace
		{
			get
			{
				bool flag = (this._hasBits0 & 2048) != 0;
				int snoFaceDefaultValue;
				if (flag)
				{
					snoFaceDefaultValue = this.snoFace_;
				}
				else
				{
					snoFaceDefaultValue = HeroInfo.SnoFaceDefaultValue;
				}
				return snoFaceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2048;
				this.snoFace_ = value;
			}
		}

		// Token: 0x17001926 RID: 6438
		// (get) Token: 0x06004EF8 RID: 20216 RVA: 0x0012E644 File Offset: 0x0012C844
		[DebuggerNonUserCode]
		public bool HasSnoFace
		{
			get
			{
				return (this._hasBits0 & 2048) != 0;
			}
		}

		// Token: 0x06004EF9 RID: 20217 RVA: 0x0012E665 File Offset: 0x0012C865
		[DebuggerNonUserCode]
		public void ClearSnoFace()
		{
			this._hasBits0 &= -2049;
		}

		// Token: 0x17001927 RID: 6439
		// (get) Token: 0x06004EFA RID: 20218 RVA: 0x0012E67C File Offset: 0x0012C87C
		// (set) Token: 0x06004EFB RID: 20219 RVA: 0x0012E6AE File Offset: 0x0012C8AE
		[DebuggerNonUserCode]
		public ulong ClanId
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				ulong clanIdDefaultValue;
				if (flag)
				{
					clanIdDefaultValue = this.clanId_;
				}
				else
				{
					clanIdDefaultValue = HeroInfo.ClanIdDefaultValue;
				}
				return clanIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.clanId_ = value;
			}
		}

		// Token: 0x17001928 RID: 6440
		// (get) Token: 0x06004EFC RID: 20220 RVA: 0x0012E6C8 File Offset: 0x0012C8C8
		[DebuggerNonUserCode]
		public bool HasClanId
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06004EFD RID: 20221 RVA: 0x0012E6E6 File Offset: 0x0012C8E6
		[DebuggerNonUserCode]
		public void ClearClanId()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x17001929 RID: 6441
		// (get) Token: 0x06004EFE RID: 20222 RVA: 0x0012E6F8 File Offset: 0x0012C8F8
		// (set) Token: 0x06004EFF RID: 20223 RVA: 0x0012E710 File Offset: 0x0012C910
		[DebuggerNonUserCode]
		public HeroInfo.Types.GameHandle GameHandle
		{
			get
			{
				return this.gameHandle_;
			}
			set
			{
				this.gameHandle_ = value;
			}
		}

		// Token: 0x1700192A RID: 6442
		// (get) Token: 0x06004F00 RID: 20224 RVA: 0x0012E71C File Offset: 0x0012C91C
		// (set) Token: 0x06004F01 RID: 20225 RVA: 0x0012E751 File Offset: 0x0012C951
		[DebuggerNonUserCode]
		public int ParagonLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				int paragonLevelDefaultValue;
				if (flag)
				{
					paragonLevelDefaultValue = this.paragonLevel_;
				}
				else
				{
					paragonLevelDefaultValue = HeroInfo.ParagonLevelDefaultValue;
				}
				return paragonLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.paragonLevel_ = value;
			}
		}

		// Token: 0x1700192B RID: 6443
		// (get) Token: 0x06004F02 RID: 20226 RVA: 0x0012E770 File Offset: 0x0012C970
		[DebuggerNonUserCode]
		public bool HasParagonLevel
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x06004F03 RID: 20227 RVA: 0x0012E791 File Offset: 0x0012C991
		[DebuggerNonUserCode]
		public void ClearParagonLevel()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x1700192C RID: 6444
		// (get) Token: 0x06004F04 RID: 20228 RVA: 0x0012E7A8 File Offset: 0x0012C9A8
		// (set) Token: 0x06004F05 RID: 20229 RVA: 0x0012E7C9 File Offset: 0x0012C9C9
		[DebuggerNonUserCode]
		public string V2ClanId
		{
			get
			{
				return this.v2ClanId_ ?? HeroInfo.V2ClanIdDefaultValue;
			}
			set
			{
				this.v2ClanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700192D RID: 6445
		// (get) Token: 0x06004F06 RID: 20230 RVA: 0x0012E7E0 File Offset: 0x0012C9E0
		[DebuggerNonUserCode]
		public bool HasV2ClanId
		{
			get
			{
				return this.v2ClanId_ != null;
			}
		}

		// Token: 0x06004F07 RID: 20231 RVA: 0x0012E7FB File Offset: 0x0012C9FB
		[DebuggerNonUserCode]
		public void ClearV2ClanId()
		{
			this.v2ClanId_ = null;
		}

		// Token: 0x1700192E RID: 6446
		// (get) Token: 0x06004F08 RID: 20232 RVA: 0x0012E808 File Offset: 0x0012CA08
		[DebuggerNonUserCode]
		public RepeatedField<Item> EquippedItems
		{
			get
			{
				return this.equippedItems_;
			}
		}

		// Token: 0x1700192F RID: 6447
		// (get) Token: 0x06004F09 RID: 20233 RVA: 0x0012E820 File Offset: 0x0012CA20
		// (set) Token: 0x06004F0A RID: 20234 RVA: 0x0012E855 File Offset: 0x0012CA55
		[DebuggerNonUserCode]
		public int WorldTier
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				int worldTierDefaultValue;
				if (flag)
				{
					worldTierDefaultValue = this.worldTier_;
				}
				else
				{
					worldTierDefaultValue = HeroInfo.WorldTierDefaultValue;
				}
				return worldTierDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.worldTier_ = value;
			}
		}

		// Token: 0x17001930 RID: 6448
		// (get) Token: 0x06004F0B RID: 20235 RVA: 0x0012E874 File Offset: 0x0012CA74
		[DebuggerNonUserCode]
		public bool HasWorldTier
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x06004F0C RID: 20236 RVA: 0x0012E895 File Offset: 0x0012CA95
		[DebuggerNonUserCode]
		public void ClearWorldTier()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x17001931 RID: 6449
		// (get) Token: 0x06004F0D RID: 20237 RVA: 0x0012E8AC File Offset: 0x0012CAAC
		// (set) Token: 0x06004F0E RID: 20238 RVA: 0x0012E8E1 File Offset: 0x0012CAE1
		[DebuggerNonUserCode]
		public int Platform
		{
			get
			{
				bool flag = (this._hasBits0 & 1024) != 0;
				int platformDefaultValue;
				if (flag)
				{
					platformDefaultValue = this.platform_;
				}
				else
				{
					platformDefaultValue = HeroInfo.PlatformDefaultValue;
				}
				return platformDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1024;
				this.platform_ = value;
			}
		}

		// Token: 0x17001932 RID: 6450
		// (get) Token: 0x06004F0F RID: 20239 RVA: 0x0012E900 File Offset: 0x0012CB00
		[DebuggerNonUserCode]
		public bool HasPlatform
		{
			get
			{
				return (this._hasBits0 & 1024) != 0;
			}
		}

		// Token: 0x06004F10 RID: 20240 RVA: 0x0012E921 File Offset: 0x0012CB21
		[DebuggerNonUserCode]
		public void ClearPlatform()
		{
			this._hasBits0 &= -1025;
		}

		// Token: 0x06004F11 RID: 20241 RVA: 0x0012E938 File Offset: 0x0012CB38
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeroInfo);
		}

		// Token: 0x06004F12 RID: 20242 RVA: 0x0012E958 File Offset: 0x0012CB58
		[DebuggerNonUserCode]
		public bool Equals(HeroInfo other)
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
					bool flag4 = this.HeroId != other.HeroId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.AccountId != other.AccountId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.GameAccountId != other.GameAccountId;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.PartyId != other.PartyId;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.HeroClass != other.HeroClass;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.TimePlayed != other.TimePlayed;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.HeroLevel != other.HeroLevel;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !object.Equals(this.Location, other.Location);
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !object.Equals(this.CombatInfo, other.CombatInfo);
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.SessionId != other.SessionId;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.PersonaIndex != other.PersonaIndex;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.HairDyeIndex != other.HairDyeIndex;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = this.SnoFace != other.SnoFace;
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = this.ClanId != other.ClanId;
																		if (flag17)
																		{
																			flag2 = false;
																		}
																		else
																		{
																			bool flag18 = !object.Equals(this.GameHandle, other.GameHandle);
																			if (flag18)
																			{
																				flag2 = false;
																			}
																			else
																			{
																				bool flag19 = this.ParagonLevel != other.ParagonLevel;
																				if (flag19)
																				{
																					flag2 = false;
																				}
																				else
																				{
																					bool flag20 = this.V2ClanId != other.V2ClanId;
																					if (flag20)
																					{
																						flag2 = false;
																					}
																					else
																					{
																						bool flag21 = !this.equippedItems_.Equals(other.equippedItems_);
																						if (flag21)
																						{
																							flag2 = false;
																						}
																						else
																						{
																							bool flag22 = this.WorldTier != other.WorldTier;
																							if (flag22)
																							{
																								flag2 = false;
																							}
																							else
																							{
																								bool flag23 = this.Platform != other.Platform;
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

		// Token: 0x06004F13 RID: 20243 RVA: 0x0012EBF4 File Offset: 0x0012CDF4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				num ^= this.HeroId.GetHashCode();
			}
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				num ^= this.AccountId.GetHashCode();
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				num ^= this.PartyId.GetHashCode();
			}
			bool hasHeroClass = this.HasHeroClass;
			if (hasHeroClass)
			{
				num ^= this.HeroClass.GetHashCode();
			}
			bool hasTimePlayed = this.HasTimePlayed;
			if (hasTimePlayed)
			{
				num ^= this.TimePlayed.GetHashCode();
			}
			bool hasHeroLevel = this.HasHeroLevel;
			if (hasHeroLevel)
			{
				num ^= this.HeroLevel.GetHashCode();
			}
			bool flag = this.location_ != null;
			if (flag)
			{
				num ^= this.Location.GetHashCode();
			}
			bool flag2 = this.combatInfo_ != null;
			if (flag2)
			{
				num ^= this.CombatInfo.GetHashCode();
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				num ^= this.SessionId.GetHashCode();
			}
			bool hasPersonaIndex = this.HasPersonaIndex;
			if (hasPersonaIndex)
			{
				num ^= this.PersonaIndex.GetHashCode();
			}
			bool hasHairDyeIndex = this.HasHairDyeIndex;
			if (hasHairDyeIndex)
			{
				num ^= this.HairDyeIndex.GetHashCode();
			}
			bool hasSnoFace = this.HasSnoFace;
			if (hasSnoFace)
			{
				num ^= this.SnoFace.GetHashCode();
			}
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num ^= this.ClanId.GetHashCode();
			}
			bool flag3 = this.gameHandle_ != null;
			if (flag3)
			{
				num ^= this.GameHandle.GetHashCode();
			}
			bool hasParagonLevel = this.HasParagonLevel;
			if (hasParagonLevel)
			{
				num ^= this.ParagonLevel.GetHashCode();
			}
			bool hasV2ClanId = this.HasV2ClanId;
			if (hasV2ClanId)
			{
				num ^= this.V2ClanId.GetHashCode();
			}
			num ^= this.equippedItems_.GetHashCode();
			bool hasWorldTier = this.HasWorldTier;
			if (hasWorldTier)
			{
				num ^= this.WorldTier.GetHashCode();
			}
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				num ^= this.Platform.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004F14 RID: 20244 RVA: 0x0012EE58 File Offset: 0x0012D058
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004F15 RID: 20245 RVA: 0x0012EE70 File Offset: 0x0012D070
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004F16 RID: 20246 RVA: 0x0012EE7C File Offset: 0x0012D07C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.HeroId);
			}
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.AccountId);
			}
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				output.WriteRawTag(26);
				output.WriteString(this.PartyId);
			}
			bool hasHeroClass = this.HasHeroClass;
			if (hasHeroClass)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.HeroClass);
			}
			bool hasTimePlayed = this.HasTimePlayed;
			if (hasTimePlayed)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.TimePlayed);
			}
			bool hasHeroLevel = this.HasHeroLevel;
			if (hasHeroLevel)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.HeroLevel);
			}
			bool flag = this.location_ != null;
			if (flag)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Location);
			}
			bool flag2 = this.combatInfo_ != null;
			if (flag2)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.CombatInfo);
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				output.WriteRawTag(74);
				output.WriteString(this.SessionId);
			}
			bool hasPersonaIndex = this.HasPersonaIndex;
			if (hasPersonaIndex)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.PersonaIndex);
			}
			bool hasHairDyeIndex = this.HasHairDyeIndex;
			if (hasHairDyeIndex)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.HairDyeIndex);
			}
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				output.WriteRawTag(96);
				output.WriteUInt64(this.ClanId);
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.GameAccountId);
			}
			bool flag3 = this.gameHandle_ != null;
			if (flag3)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.GameHandle);
			}
			bool hasParagonLevel = this.HasParagonLevel;
			if (hasParagonLevel)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ParagonLevel);
			}
			bool hasV2ClanId = this.HasV2ClanId;
			if (hasV2ClanId)
			{
				output.WriteRawTag(130, 1);
				output.WriteString(this.V2ClanId);
			}
			this.equippedItems_.WriteTo(ref output, HeroInfo._repeated_equippedItems_codec);
			bool hasWorldTier = this.HasWorldTier;
			if (hasWorldTier)
			{
				output.WriteRawTag(144, 1);
				output.WriteInt32(this.WorldTier);
			}
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				output.WriteRawTag(152, 1);
				output.WriteInt32(this.Platform);
			}
			bool hasSnoFace = this.HasSnoFace;
			if (hasSnoFace)
			{
				output.WriteRawTag(165, 1);
				output.WriteSFixed32(this.SnoFace);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004F17 RID: 20247 RVA: 0x0012F178 File Offset: 0x0012D378
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.HeroId);
			}
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AccountId);
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PartyId);
			}
			bool hasHeroClass = this.HasHeroClass;
			if (hasHeroClass)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HeroClass);
			}
			bool hasTimePlayed = this.HasTimePlayed;
			if (hasTimePlayed)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TimePlayed);
			}
			bool hasHeroLevel = this.HasHeroLevel;
			if (hasHeroLevel)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HeroLevel);
			}
			bool flag = this.location_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Location);
			}
			bool flag2 = this.combatInfo_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatInfo);
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SessionId);
			}
			bool hasPersonaIndex = this.HasPersonaIndex;
			if (hasPersonaIndex)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PersonaIndex);
			}
			bool hasHairDyeIndex = this.HasHairDyeIndex;
			if (hasHairDyeIndex)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HairDyeIndex);
			}
			bool hasSnoFace = this.HasSnoFace;
			if (hasSnoFace)
			{
				num += 6;
			}
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ClanId);
			}
			bool flag3 = this.gameHandle_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameHandle);
			}
			bool hasParagonLevel = this.HasParagonLevel;
			if (hasParagonLevel)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ParagonLevel);
			}
			bool hasV2ClanId = this.HasV2ClanId;
			if (hasV2ClanId)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.V2ClanId);
			}
			num += this.equippedItems_.CalculateSize(HeroInfo._repeated_equippedItems_codec);
			bool hasWorldTier = this.HasWorldTier;
			if (hasWorldTier)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.WorldTier);
			}
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.Platform);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004F18 RID: 20248 RVA: 0x0012F3F4 File Offset: 0x0012D5F4
		[DebuggerNonUserCode]
		public void MergeFrom(HeroInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasHeroId = other.HasHeroId;
				if (hasHeroId)
				{
					this.HeroId = other.HeroId;
				}
				bool hasAccountId = other.HasAccountId;
				if (hasAccountId)
				{
					this.AccountId = other.AccountId;
				}
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				bool hasPartyId = other.HasPartyId;
				if (hasPartyId)
				{
					this.PartyId = other.PartyId;
				}
				bool hasHeroClass = other.HasHeroClass;
				if (hasHeroClass)
				{
					this.HeroClass = other.HeroClass;
				}
				bool hasTimePlayed = other.HasTimePlayed;
				if (hasTimePlayed)
				{
					this.TimePlayed = other.TimePlayed;
				}
				bool hasHeroLevel = other.HasHeroLevel;
				if (hasHeroLevel)
				{
					this.HeroLevel = other.HeroLevel;
				}
				bool flag2 = other.location_ != null;
				if (flag2)
				{
					bool flag3 = this.location_ == null;
					if (flag3)
					{
						this.Location = new HeroLocation();
					}
					this.Location.MergeFrom(other.Location);
				}
				bool flag4 = other.combatInfo_ != null;
				if (flag4)
				{
					bool flag5 = this.combatInfo_ == null;
					if (flag5)
					{
						this.CombatInfo = new HeroCombatInfo();
					}
					this.CombatInfo.MergeFrom(other.CombatInfo);
				}
				bool hasSessionId = other.HasSessionId;
				if (hasSessionId)
				{
					this.SessionId = other.SessionId;
				}
				bool hasPersonaIndex = other.HasPersonaIndex;
				if (hasPersonaIndex)
				{
					this.PersonaIndex = other.PersonaIndex;
				}
				bool hasHairDyeIndex = other.HasHairDyeIndex;
				if (hasHairDyeIndex)
				{
					this.HairDyeIndex = other.HairDyeIndex;
				}
				bool hasSnoFace = other.HasSnoFace;
				if (hasSnoFace)
				{
					this.SnoFace = other.SnoFace;
				}
				bool hasClanId = other.HasClanId;
				if (hasClanId)
				{
					this.ClanId = other.ClanId;
				}
				bool flag6 = other.gameHandle_ != null;
				if (flag6)
				{
					bool flag7 = this.gameHandle_ == null;
					if (flag7)
					{
						this.GameHandle = new HeroInfo.Types.GameHandle();
					}
					this.GameHandle.MergeFrom(other.GameHandle);
				}
				bool hasParagonLevel = other.HasParagonLevel;
				if (hasParagonLevel)
				{
					this.ParagonLevel = other.ParagonLevel;
				}
				bool hasV2ClanId = other.HasV2ClanId;
				if (hasV2ClanId)
				{
					this.V2ClanId = other.V2ClanId;
				}
				this.equippedItems_.Add(other.equippedItems_);
				bool hasWorldTier = other.HasWorldTier;
				if (hasWorldTier)
				{
					this.WorldTier = other.WorldTier;
				}
				bool hasPlatform = other.HasPlatform;
				if (hasPlatform)
				{
					this.Platform = other.Platform;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004F19 RID: 20249 RVA: 0x0012F6A3 File Offset: 0x0012D8A3
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004F1A RID: 20250 RVA: 0x0012F6B0 File Offset: 0x0012D8B0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 80U)
				{
					if (num3 <= 40U)
					{
						if (num3 <= 16U)
						{
							if (num3 != 10U)
							{
								if (num3 != 16U)
								{
									goto IL_0114;
								}
								this.AccountId = input.ReadUInt32();
							}
							else
							{
								this.HeroId = input.ReadString();
							}
						}
						else if (num3 != 26U)
						{
							if (num3 != 32U)
							{
								if (num3 != 40U)
								{
									goto IL_0114;
								}
								this.TimePlayed = input.ReadUInt32();
							}
							else
							{
								this.HeroClass = input.ReadInt32();
							}
						}
						else
						{
							this.PartyId = input.ReadString();
						}
					}
					else if (num3 <= 58U)
					{
						if (num3 != 48U)
						{
							if (num3 != 58U)
							{
								goto IL_0114;
							}
							bool flag = this.location_ == null;
							if (flag)
							{
								this.Location = new HeroLocation();
							}
							input.ReadMessage(this.Location);
						}
						else
						{
							this.HeroLevel = input.ReadInt32();
						}
					}
					else if (num3 != 66U)
					{
						if (num3 != 74U)
						{
							if (num3 != 80U)
							{
								goto IL_0114;
							}
							this.PersonaIndex = input.ReadInt32();
						}
						else
						{
							this.SessionId = input.ReadString();
						}
					}
					else
					{
						bool flag2 = this.combatInfo_ == null;
						if (flag2)
						{
							this.CombatInfo = new HeroCombatInfo();
						}
						input.ReadMessage(this.CombatInfo);
					}
				}
				else if (num3 <= 120U)
				{
					if (num3 <= 96U)
					{
						if (num3 != 88U)
						{
							if (num3 != 96U)
							{
								goto IL_0114;
							}
							this.ClanId = input.ReadUInt64();
						}
						else
						{
							this.HairDyeIndex = input.ReadInt32();
						}
					}
					else if (num3 != 104U)
					{
						if (num3 != 114U)
						{
							if (num3 != 120U)
							{
								goto IL_0114;
							}
							this.ParagonLevel = input.ReadInt32();
						}
						else
						{
							bool flag3 = this.gameHandle_ == null;
							if (flag3)
							{
								this.GameHandle = new HeroInfo.Types.GameHandle();
							}
							input.ReadMessage(this.GameHandle);
						}
					}
					else
					{
						this.GameAccountId = input.ReadUInt32();
					}
				}
				else if (num3 <= 138U)
				{
					if (num3 != 130U)
					{
						if (num3 != 138U)
						{
							goto IL_0114;
						}
						this.equippedItems_.AddEntriesFrom(ref input, HeroInfo._repeated_equippedItems_codec);
					}
					else
					{
						this.V2ClanId = input.ReadString();
					}
				}
				else if (num3 != 144U)
				{
					if (num3 != 152U)
					{
						if (num3 != 165U)
						{
							goto IL_0114;
						}
						this.SnoFace = input.ReadSFixed32();
					}
					else
					{
						this.Platform = input.ReadInt32();
					}
				}
				else
				{
					this.WorldTier = input.ReadInt32();
				}
				continue;
				IL_0114:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002340 RID: 9024
		private static readonly MessageParser<HeroInfo> _parser = new MessageParser<HeroInfo>(() => new HeroInfo());

		// Token: 0x04002341 RID: 9025
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002342 RID: 9026
		private int _hasBits0;

		// Token: 0x04002343 RID: 9027
		public const int HeroIdFieldNumber = 1;

		// Token: 0x04002344 RID: 9028
		private static readonly string HeroIdDefaultValue = "";

		// Token: 0x04002345 RID: 9029
		private string heroId_;

		// Token: 0x04002346 RID: 9030
		public const int AccountIdFieldNumber = 2;

		// Token: 0x04002347 RID: 9031
		private static readonly uint AccountIdDefaultValue = 0U;

		// Token: 0x04002348 RID: 9032
		private uint accountId_;

		// Token: 0x04002349 RID: 9033
		public const int GameAccountIdFieldNumber = 13;

		// Token: 0x0400234A RID: 9034
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x0400234B RID: 9035
		private uint gameAccountId_;

		// Token: 0x0400234C RID: 9036
		public const int PartyIdFieldNumber = 3;

		// Token: 0x0400234D RID: 9037
		private static readonly string PartyIdDefaultValue = "";

		// Token: 0x0400234E RID: 9038
		private string partyId_;

		// Token: 0x0400234F RID: 9039
		public const int HeroClassFieldNumber = 4;

		// Token: 0x04002350 RID: 9040
		private static readonly int HeroClassDefaultValue = 0;

		// Token: 0x04002351 RID: 9041
		private int heroClass_;

		// Token: 0x04002352 RID: 9042
		public const int TimePlayedFieldNumber = 5;

		// Token: 0x04002353 RID: 9043
		private static readonly uint TimePlayedDefaultValue = 0U;

		// Token: 0x04002354 RID: 9044
		private uint timePlayed_;

		// Token: 0x04002355 RID: 9045
		public const int HeroLevelFieldNumber = 6;

		// Token: 0x04002356 RID: 9046
		private static readonly int HeroLevelDefaultValue = 0;

		// Token: 0x04002357 RID: 9047
		private int heroLevel_;

		// Token: 0x04002358 RID: 9048
		public const int LocationFieldNumber = 7;

		// Token: 0x04002359 RID: 9049
		private HeroLocation location_;

		// Token: 0x0400235A RID: 9050
		public const int CombatInfoFieldNumber = 8;

		// Token: 0x0400235B RID: 9051
		private HeroCombatInfo combatInfo_;

		// Token: 0x0400235C RID: 9052
		public const int SessionIdFieldNumber = 9;

		// Token: 0x0400235D RID: 9053
		private static readonly string SessionIdDefaultValue = "";

		// Token: 0x0400235E RID: 9054
		private string sessionId_;

		// Token: 0x0400235F RID: 9055
		public const int PersonaIndexFieldNumber = 10;

		// Token: 0x04002360 RID: 9056
		private static readonly int PersonaIndexDefaultValue = 0;

		// Token: 0x04002361 RID: 9057
		private int personaIndex_;

		// Token: 0x04002362 RID: 9058
		public const int HairDyeIndexFieldNumber = 11;

		// Token: 0x04002363 RID: 9059
		private static readonly int HairDyeIndexDefaultValue = 0;

		// Token: 0x04002364 RID: 9060
		private int hairDyeIndex_;

		// Token: 0x04002365 RID: 9061
		public const int SnoFaceFieldNumber = 20;

		// Token: 0x04002366 RID: 9062
		private static readonly int SnoFaceDefaultValue = 0;

		// Token: 0x04002367 RID: 9063
		private int snoFace_;

		// Token: 0x04002368 RID: 9064
		public const int ClanIdFieldNumber = 12;

		// Token: 0x04002369 RID: 9065
		private static readonly ulong ClanIdDefaultValue = 0UL;

		// Token: 0x0400236A RID: 9066
		private ulong clanId_;

		// Token: 0x0400236B RID: 9067
		public const int GameHandleFieldNumber = 14;

		// Token: 0x0400236C RID: 9068
		private HeroInfo.Types.GameHandle gameHandle_;

		// Token: 0x0400236D RID: 9069
		public const int ParagonLevelFieldNumber = 15;

		// Token: 0x0400236E RID: 9070
		private static readonly int ParagonLevelDefaultValue = 0;

		// Token: 0x0400236F RID: 9071
		private int paragonLevel_;

		// Token: 0x04002370 RID: 9072
		public const int V2ClanIdFieldNumber = 16;

		// Token: 0x04002371 RID: 9073
		private static readonly string V2ClanIdDefaultValue = "";

		// Token: 0x04002372 RID: 9074
		private string v2ClanId_;

		// Token: 0x04002373 RID: 9075
		public const int EquippedItemsFieldNumber = 17;

		// Token: 0x04002374 RID: 9076
		private static readonly FieldCodec<Item> _repeated_equippedItems_codec = FieldCodec.ForMessage<Item>(138U, Item.Parser);

		// Token: 0x04002375 RID: 9077
		private readonly RepeatedField<Item> equippedItems_ = new RepeatedField<Item>();

		// Token: 0x04002376 RID: 9078
		public const int WorldTierFieldNumber = 18;

		// Token: 0x04002377 RID: 9079
		private static readonly int WorldTierDefaultValue = 0;

		// Token: 0x04002378 RID: 9080
		private int worldTier_;

		// Token: 0x04002379 RID: 9081
		public const int PlatformFieldNumber = 19;

		// Token: 0x0400237A RID: 9082
		private static readonly int PlatformDefaultValue = 0;

		// Token: 0x0400237B RID: 9083
		private int platform_;

		// Token: 0x02000DFA RID: 3578
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x0200148B RID: 5259
			public sealed class GameHandle : IMessage<HeroInfo.Types.GameHandle>, IMessage, IEquatable<HeroInfo.Types.GameHandle>, IDeepCloneable<HeroInfo.Types.GameHandle>, IBufferMessage
			{
				// Token: 0x17003B01 RID: 15105
				// (get) Token: 0x0600E76B RID: 59243 RVA: 0x004DB6A8 File Offset: 0x004D98A8
				[DebuggerNonUserCode]
				public static MessageParser<HeroInfo.Types.GameHandle> Parser
				{
					get
					{
						return HeroInfo.Types.GameHandle._parser;
					}
				}

				// Token: 0x17003B02 RID: 15106
				// (get) Token: 0x0600E76C RID: 59244 RVA: 0x004DB6C0 File Offset: 0x004D98C0
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return HeroInfo.Descriptor.NestedTypes[0];
					}
				}

				// Token: 0x17003B03 RID: 15107
				// (get) Token: 0x0600E76D RID: 59245 RVA: 0x004DB6E4 File Offset: 0x004D98E4
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return HeroInfo.Types.GameHandle.Descriptor;
					}
				}

				// Token: 0x0600E76E RID: 59246 RVA: 0x004DB6FB File Offset: 0x004D98FB
				[DebuggerNonUserCode]
				public GameHandle()
				{
				}

				// Token: 0x0600E76F RID: 59247 RVA: 0x004DB708 File Offset: 0x004D9908
				[DebuggerNonUserCode]
				public GameHandle(HeroInfo.Types.GameHandle other)
					: this()
				{
					this._hasBits0 = other._hasBits0;
					this.matchmakerId_ = other.matchmakerId_;
					this.gameServerGuid_ = other.gameServerGuid_;
					this.gameInstanceId_ = other.gameInstanceId_;
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E770 RID: 59248 RVA: 0x004DB760 File Offset: 0x004D9960
				[DebuggerNonUserCode]
				public HeroInfo.Types.GameHandle Clone()
				{
					return new HeroInfo.Types.GameHandle(this);
				}

				// Token: 0x17003B04 RID: 15108
				// (get) Token: 0x0600E771 RID: 59249 RVA: 0x004DB778 File Offset: 0x004D9978
				// (set) Token: 0x0600E772 RID: 59250 RVA: 0x004DB7A9 File Offset: 0x004D99A9
				[DebuggerNonUserCode]
				public ulong MatchmakerId
				{
					get
					{
						bool flag = (this._hasBits0 & 1) != 0;
						ulong matchmakerIdDefaultValue;
						if (flag)
						{
							matchmakerIdDefaultValue = this.matchmakerId_;
						}
						else
						{
							matchmakerIdDefaultValue = HeroInfo.Types.GameHandle.MatchmakerIdDefaultValue;
						}
						return matchmakerIdDefaultValue;
					}
					set
					{
						this._hasBits0 |= 1;
						this.matchmakerId_ = value;
					}
				}

				// Token: 0x17003B05 RID: 15109
				// (get) Token: 0x0600E773 RID: 59251 RVA: 0x004DB7C4 File Offset: 0x004D99C4
				[DebuggerNonUserCode]
				public bool HasMatchmakerId
				{
					get
					{
						return (this._hasBits0 & 1) != 0;
					}
				}

				// Token: 0x0600E774 RID: 59252 RVA: 0x004DB7E1 File Offset: 0x004D99E1
				[DebuggerNonUserCode]
				public void ClearMatchmakerId()
				{
					this._hasBits0 &= -2;
				}

				// Token: 0x17003B06 RID: 15110
				// (get) Token: 0x0600E775 RID: 59253 RVA: 0x004DB7F4 File Offset: 0x004D99F4
				// (set) Token: 0x0600E776 RID: 59254 RVA: 0x004DB825 File Offset: 0x004D9A25
				[DebuggerNonUserCode]
				public ulong GameServerGuid
				{
					get
					{
						bool flag = (this._hasBits0 & 2) != 0;
						ulong gameServerGuidDefaultValue;
						if (flag)
						{
							gameServerGuidDefaultValue = this.gameServerGuid_;
						}
						else
						{
							gameServerGuidDefaultValue = HeroInfo.Types.GameHandle.GameServerGuidDefaultValue;
						}
						return gameServerGuidDefaultValue;
					}
					set
					{
						this._hasBits0 |= 2;
						this.gameServerGuid_ = value;
					}
				}

				// Token: 0x17003B07 RID: 15111
				// (get) Token: 0x0600E777 RID: 59255 RVA: 0x004DB840 File Offset: 0x004D9A40
				[DebuggerNonUserCode]
				public bool HasGameServerGuid
				{
					get
					{
						return (this._hasBits0 & 2) != 0;
					}
				}

				// Token: 0x0600E778 RID: 59256 RVA: 0x004DB85D File Offset: 0x004D9A5D
				[DebuggerNonUserCode]
				public void ClearGameServerGuid()
				{
					this._hasBits0 &= -3;
				}

				// Token: 0x17003B08 RID: 15112
				// (get) Token: 0x0600E779 RID: 59257 RVA: 0x004DB870 File Offset: 0x004D9A70
				// (set) Token: 0x0600E77A RID: 59258 RVA: 0x004DB8A1 File Offset: 0x004D9AA1
				[DebuggerNonUserCode]
				public uint GameInstanceId
				{
					get
					{
						bool flag = (this._hasBits0 & 4) != 0;
						uint gameInstanceIdDefaultValue;
						if (flag)
						{
							gameInstanceIdDefaultValue = this.gameInstanceId_;
						}
						else
						{
							gameInstanceIdDefaultValue = HeroInfo.Types.GameHandle.GameInstanceIdDefaultValue;
						}
						return gameInstanceIdDefaultValue;
					}
					set
					{
						this._hasBits0 |= 4;
						this.gameInstanceId_ = value;
					}
				}

				// Token: 0x17003B09 RID: 15113
				// (get) Token: 0x0600E77B RID: 59259 RVA: 0x004DB8BC File Offset: 0x004D9ABC
				[DebuggerNonUserCode]
				public bool HasGameInstanceId
				{
					get
					{
						return (this._hasBits0 & 4) != 0;
					}
				}

				// Token: 0x0600E77C RID: 59260 RVA: 0x004DB8D9 File Offset: 0x004D9AD9
				[DebuggerNonUserCode]
				public void ClearGameInstanceId()
				{
					this._hasBits0 &= -5;
				}

				// Token: 0x0600E77D RID: 59261 RVA: 0x004DB8EC File Offset: 0x004D9AEC
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as HeroInfo.Types.GameHandle);
				}

				// Token: 0x0600E77E RID: 59262 RVA: 0x004DB90C File Offset: 0x004D9B0C
				[DebuggerNonUserCode]
				public bool Equals(HeroInfo.Types.GameHandle other)
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
							bool flag4 = this.MatchmakerId != other.MatchmakerId;
							if (flag4)
							{
								flag2 = false;
							}
							else
							{
								bool flag5 = this.GameServerGuid != other.GameServerGuid;
								if (flag5)
								{
									flag2 = false;
								}
								else
								{
									bool flag6 = this.GameInstanceId != other.GameInstanceId;
									flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
					return flag2;
				}

				// Token: 0x0600E77F RID: 59263 RVA: 0x004DB998 File Offset: 0x004D9B98
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					bool hasMatchmakerId = this.HasMatchmakerId;
					if (hasMatchmakerId)
					{
						num ^= this.MatchmakerId.GetHashCode();
					}
					bool hasGameServerGuid = this.HasGameServerGuid;
					if (hasGameServerGuid)
					{
						num ^= this.GameServerGuid.GetHashCode();
					}
					bool hasGameInstanceId = this.HasGameInstanceId;
					if (hasGameInstanceId)
					{
						num ^= this.GameInstanceId.GetHashCode();
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E780 RID: 59264 RVA: 0x004DBA24 File Offset: 0x004D9C24
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E781 RID: 59265 RVA: 0x004DBA3C File Offset: 0x004D9C3C
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E782 RID: 59266 RVA: 0x004DBA48 File Offset: 0x004D9C48
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					bool hasMatchmakerId = this.HasMatchmakerId;
					if (hasMatchmakerId)
					{
						output.WriteRawTag(8);
						output.WriteUInt64(this.MatchmakerId);
					}
					bool hasGameServerGuid = this.HasGameServerGuid;
					if (hasGameServerGuid)
					{
						output.WriteRawTag(16);
						output.WriteUInt64(this.GameServerGuid);
					}
					bool hasGameInstanceId = this.HasGameInstanceId;
					if (hasGameInstanceId)
					{
						output.WriteRawTag(24);
						output.WriteUInt32(this.GameInstanceId);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E783 RID: 59267 RVA: 0x004DBAD8 File Offset: 0x004D9CD8
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					bool hasMatchmakerId = this.HasMatchmakerId;
					if (hasMatchmakerId)
					{
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.MatchmakerId);
					}
					bool hasGameServerGuid = this.HasGameServerGuid;
					if (hasGameServerGuid)
					{
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.GameServerGuid);
					}
					bool hasGameInstanceId = this.HasGameInstanceId;
					if (hasGameInstanceId)
					{
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameInstanceId);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E784 RID: 59268 RVA: 0x004DBB64 File Offset: 0x004D9D64
				[DebuggerNonUserCode]
				public void MergeFrom(HeroInfo.Types.GameHandle other)
				{
					bool flag = other == null;
					if (!flag)
					{
						bool hasMatchmakerId = other.HasMatchmakerId;
						if (hasMatchmakerId)
						{
							this.MatchmakerId = other.MatchmakerId;
						}
						bool hasGameServerGuid = other.HasGameServerGuid;
						if (hasGameServerGuid)
						{
							this.GameServerGuid = other.GameServerGuid;
						}
						bool hasGameInstanceId = other.HasGameInstanceId;
						if (hasGameInstanceId)
						{
							this.GameInstanceId = other.GameInstanceId;
						}
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E785 RID: 59269 RVA: 0x004DBBDF File Offset: 0x004D9DDF
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E786 RID: 59270 RVA: 0x004DBBEC File Offset: 0x004D9DEC
				[DebuggerNonUserCode]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
					uint num;
					while ((num = input.ReadTag()) > 0U)
					{
						uint num2 = num;
						uint num3 = num2;
						if (num3 != 8U)
						{
							if (num3 != 16U)
							{
								if (num3 != 24U)
								{
									this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
								}
								else
								{
									this.GameInstanceId = input.ReadUInt32();
								}
							}
							else
							{
								this.GameServerGuid = input.ReadUInt64();
							}
						}
						else
						{
							this.MatchmakerId = input.ReadUInt64();
						}
					}
				}

				// Token: 0x0400A486 RID: 42118
				private static readonly MessageParser<HeroInfo.Types.GameHandle> _parser = new MessageParser<HeroInfo.Types.GameHandle>(() => new HeroInfo.Types.GameHandle());

				// Token: 0x0400A487 RID: 42119
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A488 RID: 42120
				private int _hasBits0;

				// Token: 0x0400A489 RID: 42121
				public const int MatchmakerIdFieldNumber = 1;

				// Token: 0x0400A48A RID: 42122
				private static readonly ulong MatchmakerIdDefaultValue = 0UL;

				// Token: 0x0400A48B RID: 42123
				private ulong matchmakerId_;

				// Token: 0x0400A48C RID: 42124
				public const int GameServerGuidFieldNumber = 2;

				// Token: 0x0400A48D RID: 42125
				private static readonly ulong GameServerGuidDefaultValue = 0UL;

				// Token: 0x0400A48E RID: 42126
				private ulong gameServerGuid_;

				// Token: 0x0400A48F RID: 42127
				public const int GameInstanceIdFieldNumber = 3;

				// Token: 0x0400A490 RID: 42128
				private static readonly uint GameInstanceIdDefaultValue = 0U;

				// Token: 0x0400A491 RID: 42129
				private uint gameInstanceId_;
			}
		}
	}
}
