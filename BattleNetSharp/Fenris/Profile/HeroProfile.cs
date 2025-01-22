using System;
using System.Diagnostics;
using Fenris.Hero;
using Fenris.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Profile
{
	// Token: 0x02000135 RID: 309
	public sealed class HeroProfile : IMessage<HeroProfile>, IMessage, IEquatable<HeroProfile>, IDeepCloneable<HeroProfile>, IBufferMessage
	{
		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06001EF0 RID: 7920 RVA: 0x00076F24 File Offset: 0x00075124
		[DebuggerNonUserCode]
		public static MessageParser<HeroProfile> Parser
		{
			get
			{
				return HeroProfile._parser;
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06001EF1 RID: 7921 RVA: 0x00076F3C File Offset: 0x0007513C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ProfileReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06001EF2 RID: 7922 RVA: 0x00076F60 File Offset: 0x00075160
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeroProfile.Descriptor;
			}
		}

		// Token: 0x06001EF3 RID: 7923 RVA: 0x00076F77 File Offset: 0x00075177
		[DebuggerNonUserCode]
		public HeroProfile()
		{
		}

		// Token: 0x06001EF4 RID: 7924 RVA: 0x00076F8C File Offset: 0x0007518C
		[DebuggerNonUserCode]
		public HeroProfile(HeroProfile other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.monstersKilled_ = other.monstersKilled_;
			this.elitesKilled_ = other.elitesKilled_;
			this.goldCollected_ = other.goldCollected_;
			this.highestLevel_ = other.highestLevel_;
			this.createTime_ = other.createTime_;
			this.itemPower_ = other.itemPower_;
			this.resistShadow_ = other.resistShadow_;
			this.resistFire_ = other.resistFire_;
			this.resistLightning_ = other.resistLightning_;
			this.resistPoison_ = other.resistPoison_;
			this.resistCold_ = other.resistCold_;
			this.equipment_ = ((other.equipment_ != null) ? other.equipment_.Clone() : null);
			this.snoActiveSkills_ = ((other.snoActiveSkills_ != null) ? other.snoActiveSkills_.Clone() : null);
			this.deathTime_ = other.deathTime_;
			this.killerInfo_ = ((other.killerInfo_ != null) ? other.killerInfo_.Clone() : null);
			this.snoKillLocation_ = other.snoKillLocation_;
			this.heroId_ = other.heroId_;
			this.toughness_ = other.toughness_;
			this.healing_ = other.healing_;
			this.seasonCreated_ = other.seasonCreated_;
			this.playerTitle_ = ((other.playerTitle_ != null) ? other.playerTitle_.Clone() : null);
			this.playerFlags_ = other.playerFlags_;
			this.snoClass_ = other.snoClass_;
			this.transmogSlot_ = other.transmogSlot_.Clone();
			this.visualEquipment_ = ((other.visualEquipment_ != null) ? other.visualEquipment_.Clone() : null);
			this.campaignProgress_ = other.campaignProgress_;
			this.privacyFlag_ = other.privacyFlag_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001EF5 RID: 7925 RVA: 0x00077158 File Offset: 0x00075358
		[DebuggerNonUserCode]
		public HeroProfile Clone()
		{
			return new HeroProfile(this);
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06001EF6 RID: 7926 RVA: 0x00077170 File Offset: 0x00075370
		// (set) Token: 0x06001EF7 RID: 7927 RVA: 0x000771A1 File Offset: 0x000753A1
		[DebuggerNonUserCode]
		public ulong MonstersKilled
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong monstersKilledDefaultValue;
				if (flag)
				{
					monstersKilledDefaultValue = this.monstersKilled_;
				}
				else
				{
					monstersKilledDefaultValue = HeroProfile.MonstersKilledDefaultValue;
				}
				return monstersKilledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.monstersKilled_ = value;
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06001EF8 RID: 7928 RVA: 0x000771BC File Offset: 0x000753BC
		[DebuggerNonUserCode]
		public bool HasMonstersKilled
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x000771D9 File Offset: 0x000753D9
		[DebuggerNonUserCode]
		public void ClearMonstersKilled()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06001EFA RID: 7930 RVA: 0x000771EC File Offset: 0x000753EC
		// (set) Token: 0x06001EFB RID: 7931 RVA: 0x0007721D File Offset: 0x0007541D
		[DebuggerNonUserCode]
		public ulong ElitesKilled
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong elitesKilledDefaultValue;
				if (flag)
				{
					elitesKilledDefaultValue = this.elitesKilled_;
				}
				else
				{
					elitesKilledDefaultValue = HeroProfile.ElitesKilledDefaultValue;
				}
				return elitesKilledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.elitesKilled_ = value;
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06001EFC RID: 7932 RVA: 0x00077238 File Offset: 0x00075438
		[DebuggerNonUserCode]
		public bool HasElitesKilled
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x00077255 File Offset: 0x00075455
		[DebuggerNonUserCode]
		public void ClearElitesKilled()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06001EFE RID: 7934 RVA: 0x00077268 File Offset: 0x00075468
		// (set) Token: 0x06001EFF RID: 7935 RVA: 0x00077299 File Offset: 0x00075499
		[DebuggerNonUserCode]
		public ulong GoldCollected
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong goldCollectedDefaultValue;
				if (flag)
				{
					goldCollectedDefaultValue = this.goldCollected_;
				}
				else
				{
					goldCollectedDefaultValue = HeroProfile.GoldCollectedDefaultValue;
				}
				return goldCollectedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.goldCollected_ = value;
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06001F00 RID: 7936 RVA: 0x000772B4 File Offset: 0x000754B4
		[DebuggerNonUserCode]
		public bool HasGoldCollected
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x000772D1 File Offset: 0x000754D1
		[DebuggerNonUserCode]
		public void ClearGoldCollected()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06001F02 RID: 7938 RVA: 0x000772E4 File Offset: 0x000754E4
		// (set) Token: 0x06001F03 RID: 7939 RVA: 0x00077315 File Offset: 0x00075515
		[DebuggerNonUserCode]
		public uint HighestLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint highestLevelDefaultValue;
				if (flag)
				{
					highestLevelDefaultValue = this.highestLevel_;
				}
				else
				{
					highestLevelDefaultValue = HeroProfile.HighestLevelDefaultValue;
				}
				return highestLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.highestLevel_ = value;
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06001F04 RID: 7940 RVA: 0x00077330 File Offset: 0x00075530
		[DebuggerNonUserCode]
		public bool HasHighestLevel
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06001F05 RID: 7941 RVA: 0x0007734D File Offset: 0x0007554D
		[DebuggerNonUserCode]
		public void ClearHighestLevel()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06001F06 RID: 7942 RVA: 0x00077360 File Offset: 0x00075560
		// (set) Token: 0x06001F07 RID: 7943 RVA: 0x00077392 File Offset: 0x00075592
		[DebuggerNonUserCode]
		public uint CreateTime
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint createTimeDefaultValue;
				if (flag)
				{
					createTimeDefaultValue = this.createTime_;
				}
				else
				{
					createTimeDefaultValue = HeroProfile.CreateTimeDefaultValue;
				}
				return createTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.createTime_ = value;
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06001F08 RID: 7944 RVA: 0x000773AC File Offset: 0x000755AC
		[DebuggerNonUserCode]
		public bool HasCreateTime
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06001F09 RID: 7945 RVA: 0x000773CA File Offset: 0x000755CA
		[DebuggerNonUserCode]
		public void ClearCreateTime()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06001F0A RID: 7946 RVA: 0x000773DC File Offset: 0x000755DC
		// (set) Token: 0x06001F0B RID: 7947 RVA: 0x0007740E File Offset: 0x0007560E
		[DebuggerNonUserCode]
		public uint ItemPower
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				uint itemPowerDefaultValue;
				if (flag)
				{
					itemPowerDefaultValue = this.itemPower_;
				}
				else
				{
					itemPowerDefaultValue = HeroProfile.ItemPowerDefaultValue;
				}
				return itemPowerDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.itemPower_ = value;
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06001F0C RID: 7948 RVA: 0x00077428 File Offset: 0x00075628
		[DebuggerNonUserCode]
		public bool HasItemPower
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06001F0D RID: 7949 RVA: 0x00077446 File Offset: 0x00075646
		[DebuggerNonUserCode]
		public void ClearItemPower()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06001F0E RID: 7950 RVA: 0x00077458 File Offset: 0x00075658
		// (set) Token: 0x06001F0F RID: 7951 RVA: 0x0007748A File Offset: 0x0007568A
		[DebuggerNonUserCode]
		public uint ResistShadow
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				uint resistShadowDefaultValue;
				if (flag)
				{
					resistShadowDefaultValue = this.resistShadow_;
				}
				else
				{
					resistShadowDefaultValue = HeroProfile.ResistShadowDefaultValue;
				}
				return resistShadowDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.resistShadow_ = value;
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06001F10 RID: 7952 RVA: 0x000774A4 File Offset: 0x000756A4
		[DebuggerNonUserCode]
		public bool HasResistShadow
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x000774C2 File Offset: 0x000756C2
		[DebuggerNonUserCode]
		public void ClearResistShadow()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06001F12 RID: 7954 RVA: 0x000774D4 File Offset: 0x000756D4
		// (set) Token: 0x06001F13 RID: 7955 RVA: 0x00077509 File Offset: 0x00075709
		[DebuggerNonUserCode]
		public uint ResistFire
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				uint resistFireDefaultValue;
				if (flag)
				{
					resistFireDefaultValue = this.resistFire_;
				}
				else
				{
					resistFireDefaultValue = HeroProfile.ResistFireDefaultValue;
				}
				return resistFireDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.resistFire_ = value;
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06001F14 RID: 7956 RVA: 0x00077528 File Offset: 0x00075728
		[DebuggerNonUserCode]
		public bool HasResistFire
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x00077549 File Offset: 0x00075749
		[DebuggerNonUserCode]
		public void ClearResistFire()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06001F16 RID: 7958 RVA: 0x00077560 File Offset: 0x00075760
		// (set) Token: 0x06001F17 RID: 7959 RVA: 0x00077595 File Offset: 0x00075795
		[DebuggerNonUserCode]
		public uint ResistLightning
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				uint resistLightningDefaultValue;
				if (flag)
				{
					resistLightningDefaultValue = this.resistLightning_;
				}
				else
				{
					resistLightningDefaultValue = HeroProfile.ResistLightningDefaultValue;
				}
				return resistLightningDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.resistLightning_ = value;
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06001F18 RID: 7960 RVA: 0x000775B4 File Offset: 0x000757B4
		[DebuggerNonUserCode]
		public bool HasResistLightning
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x000775D5 File Offset: 0x000757D5
		[DebuggerNonUserCode]
		public void ClearResistLightning()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06001F1A RID: 7962 RVA: 0x000775EC File Offset: 0x000757EC
		// (set) Token: 0x06001F1B RID: 7963 RVA: 0x00077621 File Offset: 0x00075821
		[DebuggerNonUserCode]
		public uint ResistPoison
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				uint resistPoisonDefaultValue;
				if (flag)
				{
					resistPoisonDefaultValue = this.resistPoison_;
				}
				else
				{
					resistPoisonDefaultValue = HeroProfile.ResistPoisonDefaultValue;
				}
				return resistPoisonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.resistPoison_ = value;
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06001F1C RID: 7964 RVA: 0x00077640 File Offset: 0x00075840
		[DebuggerNonUserCode]
		public bool HasResistPoison
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x06001F1D RID: 7965 RVA: 0x00077661 File Offset: 0x00075861
		[DebuggerNonUserCode]
		public void ClearResistPoison()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06001F1E RID: 7966 RVA: 0x00077678 File Offset: 0x00075878
		// (set) Token: 0x06001F1F RID: 7967 RVA: 0x000776AD File Offset: 0x000758AD
		[DebuggerNonUserCode]
		public uint ResistCold
		{
			get
			{
				bool flag = (this._hasBits0 & 1024) != 0;
				uint resistColdDefaultValue;
				if (flag)
				{
					resistColdDefaultValue = this.resistCold_;
				}
				else
				{
					resistColdDefaultValue = HeroProfile.ResistColdDefaultValue;
				}
				return resistColdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1024;
				this.resistCold_ = value;
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06001F20 RID: 7968 RVA: 0x000776CC File Offset: 0x000758CC
		[DebuggerNonUserCode]
		public bool HasResistCold
		{
			get
			{
				return (this._hasBits0 & 1024) != 0;
			}
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x000776ED File Offset: 0x000758ED
		[DebuggerNonUserCode]
		public void ClearResistCold()
		{
			this._hasBits0 &= -1025;
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06001F22 RID: 7970 RVA: 0x00077704 File Offset: 0x00075904
		// (set) Token: 0x06001F23 RID: 7971 RVA: 0x0007771C File Offset: 0x0007591C
		[DebuggerNonUserCode]
		public ItemList Equipment
		{
			get
			{
				return this.equipment_;
			}
			set
			{
				this.equipment_ = value;
			}
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06001F24 RID: 7972 RVA: 0x00077728 File Offset: 0x00075928
		// (set) Token: 0x06001F25 RID: 7973 RVA: 0x00077740 File Offset: 0x00075940
		[DebuggerNonUserCode]
		public ActiveSkills SnoActiveSkills
		{
			get
			{
				return this.snoActiveSkills_;
			}
			set
			{
				this.snoActiveSkills_ = value;
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06001F26 RID: 7974 RVA: 0x0007774C File Offset: 0x0007594C
		// (set) Token: 0x06001F27 RID: 7975 RVA: 0x00077781 File Offset: 0x00075981
		[DebuggerNonUserCode]
		public uint DeathTime
		{
			get
			{
				bool flag = (this._hasBits0 & 2048) != 0;
				uint deathTimeDefaultValue;
				if (flag)
				{
					deathTimeDefaultValue = this.deathTime_;
				}
				else
				{
					deathTimeDefaultValue = HeroProfile.DeathTimeDefaultValue;
				}
				return deathTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2048;
				this.deathTime_ = value;
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06001F28 RID: 7976 RVA: 0x000777A0 File Offset: 0x000759A0
		[DebuggerNonUserCode]
		public bool HasDeathTime
		{
			get
			{
				return (this._hasBits0 & 2048) != 0;
			}
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x000777C1 File Offset: 0x000759C1
		[DebuggerNonUserCode]
		public void ClearDeathTime()
		{
			this._hasBits0 &= -2049;
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06001F2A RID: 7978 RVA: 0x000777D8 File Offset: 0x000759D8
		// (set) Token: 0x06001F2B RID: 7979 RVA: 0x000777F0 File Offset: 0x000759F0
		[DebuggerNonUserCode]
		public KillerInfo KillerInfo
		{
			get
			{
				return this.killerInfo_;
			}
			set
			{
				this.killerInfo_ = value;
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06001F2C RID: 7980 RVA: 0x000777FC File Offset: 0x000759FC
		// (set) Token: 0x06001F2D RID: 7981 RVA: 0x00077831 File Offset: 0x00075A31
		[DebuggerNonUserCode]
		public uint SnoKillLocation
		{
			get
			{
				bool flag = (this._hasBits0 & 4096) != 0;
				uint snoKillLocationDefaultValue;
				if (flag)
				{
					snoKillLocationDefaultValue = this.snoKillLocation_;
				}
				else
				{
					snoKillLocationDefaultValue = HeroProfile.SnoKillLocationDefaultValue;
				}
				return snoKillLocationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4096;
				this.snoKillLocation_ = value;
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06001F2E RID: 7982 RVA: 0x00077850 File Offset: 0x00075A50
		[DebuggerNonUserCode]
		public bool HasSnoKillLocation
		{
			get
			{
				return (this._hasBits0 & 4096) != 0;
			}
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x00077871 File Offset: 0x00075A71
		[DebuggerNonUserCode]
		public void ClearSnoKillLocation()
		{
			this._hasBits0 &= -4097;
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06001F30 RID: 7984 RVA: 0x00077888 File Offset: 0x00075A88
		// (set) Token: 0x06001F31 RID: 7985 RVA: 0x000778A9 File Offset: 0x00075AA9
		[DebuggerNonUserCode]
		public ByteString HeroId
		{
			get
			{
				return this.heroId_ ?? HeroProfile.HeroIdDefaultValue;
			}
			set
			{
				this.heroId_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06001F32 RID: 7986 RVA: 0x000778C0 File Offset: 0x00075AC0
		[DebuggerNonUserCode]
		public bool HasHeroId
		{
			get
			{
				return this.heroId_ != null;
			}
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x000778DE File Offset: 0x00075ADE
		[DebuggerNonUserCode]
		public void ClearHeroId()
		{
			this.heroId_ = null;
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06001F34 RID: 7988 RVA: 0x000778E8 File Offset: 0x00075AE8
		// (set) Token: 0x06001F35 RID: 7989 RVA: 0x0007791D File Offset: 0x00075B1D
		[DebuggerNonUserCode]
		public float Toughness
		{
			get
			{
				bool flag = (this._hasBits0 & 8192) != 0;
				float toughnessDefaultValue;
				if (flag)
				{
					toughnessDefaultValue = this.toughness_;
				}
				else
				{
					toughnessDefaultValue = HeroProfile.ToughnessDefaultValue;
				}
				return toughnessDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8192;
				this.toughness_ = value;
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06001F36 RID: 7990 RVA: 0x0007793C File Offset: 0x00075B3C
		[DebuggerNonUserCode]
		public bool HasToughness
		{
			get
			{
				return (this._hasBits0 & 8192) != 0;
			}
		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x0007795D File Offset: 0x00075B5D
		[DebuggerNonUserCode]
		public void ClearToughness()
		{
			this._hasBits0 &= -8193;
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06001F38 RID: 7992 RVA: 0x00077974 File Offset: 0x00075B74
		// (set) Token: 0x06001F39 RID: 7993 RVA: 0x000779A9 File Offset: 0x00075BA9
		[DebuggerNonUserCode]
		public float Healing
		{
			get
			{
				bool flag = (this._hasBits0 & 16384) != 0;
				float healingDefaultValue;
				if (flag)
				{
					healingDefaultValue = this.healing_;
				}
				else
				{
					healingDefaultValue = HeroProfile.HealingDefaultValue;
				}
				return healingDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16384;
				this.healing_ = value;
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06001F3A RID: 7994 RVA: 0x000779C8 File Offset: 0x00075BC8
		[DebuggerNonUserCode]
		public bool HasHealing
		{
			get
			{
				return (this._hasBits0 & 16384) != 0;
			}
		}

		// Token: 0x06001F3B RID: 7995 RVA: 0x000779E9 File Offset: 0x00075BE9
		[DebuggerNonUserCode]
		public void ClearHealing()
		{
			this._hasBits0 &= -16385;
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06001F3C RID: 7996 RVA: 0x00077A00 File Offset: 0x00075C00
		// (set) Token: 0x06001F3D RID: 7997 RVA: 0x00077A35 File Offset: 0x00075C35
		[DebuggerNonUserCode]
		public uint SeasonCreated
		{
			get
			{
				bool flag = (this._hasBits0 & 32768) != 0;
				uint seasonCreatedDefaultValue;
				if (flag)
				{
					seasonCreatedDefaultValue = this.seasonCreated_;
				}
				else
				{
					seasonCreatedDefaultValue = HeroProfile.SeasonCreatedDefaultValue;
				}
				return seasonCreatedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32768;
				this.seasonCreated_ = value;
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06001F3E RID: 7998 RVA: 0x00077A54 File Offset: 0x00075C54
		[DebuggerNonUserCode]
		public bool HasSeasonCreated
		{
			get
			{
				return (this._hasBits0 & 32768) != 0;
			}
		}

		// Token: 0x06001F3F RID: 7999 RVA: 0x00077A75 File Offset: 0x00075C75
		[DebuggerNonUserCode]
		public void ClearSeasonCreated()
		{
			this._hasBits0 &= -32769;
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06001F40 RID: 8000 RVA: 0x00077A8C File Offset: 0x00075C8C
		// (set) Token: 0x06001F41 RID: 8001 RVA: 0x00077AA4 File Offset: 0x00075CA4
		[DebuggerNonUserCode]
		public PlayerTitle PlayerTitle
		{
			get
			{
				return this.playerTitle_;
			}
			set
			{
				this.playerTitle_ = value;
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06001F42 RID: 8002 RVA: 0x00077AB0 File Offset: 0x00075CB0
		// (set) Token: 0x06001F43 RID: 8003 RVA: 0x00077AE5 File Offset: 0x00075CE5
		[DebuggerNonUserCode]
		public uint PlayerFlags
		{
			get
			{
				bool flag = (this._hasBits0 & 65536) != 0;
				uint playerFlagsDefaultValue;
				if (flag)
				{
					playerFlagsDefaultValue = this.playerFlags_;
				}
				else
				{
					playerFlagsDefaultValue = HeroProfile.PlayerFlagsDefaultValue;
				}
				return playerFlagsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 65536;
				this.playerFlags_ = value;
			}
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06001F44 RID: 8004 RVA: 0x00077B04 File Offset: 0x00075D04
		[DebuggerNonUserCode]
		public bool HasPlayerFlags
		{
			get
			{
				return (this._hasBits0 & 65536) != 0;
			}
		}

		// Token: 0x06001F45 RID: 8005 RVA: 0x00077B25 File Offset: 0x00075D25
		[DebuggerNonUserCode]
		public void ClearPlayerFlags()
		{
			this._hasBits0 &= -65537;
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06001F46 RID: 8006 RVA: 0x00077B3C File Offset: 0x00075D3C
		// (set) Token: 0x06001F47 RID: 8007 RVA: 0x00077B71 File Offset: 0x00075D71
		[DebuggerNonUserCode]
		public uint SnoClass
		{
			get
			{
				bool flag = (this._hasBits0 & 131072) != 0;
				uint snoClassDefaultValue;
				if (flag)
				{
					snoClassDefaultValue = this.snoClass_;
				}
				else
				{
					snoClassDefaultValue = HeroProfile.SnoClassDefaultValue;
				}
				return snoClassDefaultValue;
			}
			set
			{
				this._hasBits0 |= 131072;
				this.snoClass_ = value;
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06001F48 RID: 8008 RVA: 0x00077B90 File Offset: 0x00075D90
		[DebuggerNonUserCode]
		public bool HasSnoClass
		{
			get
			{
				return (this._hasBits0 & 131072) != 0;
			}
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x00077BB1 File Offset: 0x00075DB1
		[DebuggerNonUserCode]
		public void ClearSnoClass()
		{
			this._hasBits0 &= -131073;
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06001F4A RID: 8010 RVA: 0x00077BC8 File Offset: 0x00075DC8
		[DebuggerNonUserCode]
		public RepeatedField<TransmogSlot> TransmogSlot
		{
			get
			{
				return this.transmogSlot_;
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06001F4B RID: 8011 RVA: 0x00077BE0 File Offset: 0x00075DE0
		// (set) Token: 0x06001F4C RID: 8012 RVA: 0x00077BF8 File Offset: 0x00075DF8
		[DebuggerNonUserCode]
		public VisualEquipment VisualEquipment
		{
			get
			{
				return this.visualEquipment_;
			}
			set
			{
				this.visualEquipment_ = value;
			}
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06001F4D RID: 8013 RVA: 0x00077C04 File Offset: 0x00075E04
		// (set) Token: 0x06001F4E RID: 8014 RVA: 0x00077C39 File Offset: 0x00075E39
		[DebuggerNonUserCode]
		public float CampaignProgress
		{
			get
			{
				bool flag = (this._hasBits0 & 262144) != 0;
				float campaignProgressDefaultValue;
				if (flag)
				{
					campaignProgressDefaultValue = this.campaignProgress_;
				}
				else
				{
					campaignProgressDefaultValue = HeroProfile.CampaignProgressDefaultValue;
				}
				return campaignProgressDefaultValue;
			}
			set
			{
				this._hasBits0 |= 262144;
				this.campaignProgress_ = value;
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06001F4F RID: 8015 RVA: 0x00077C58 File Offset: 0x00075E58
		[DebuggerNonUserCode]
		public bool HasCampaignProgress
		{
			get
			{
				return (this._hasBits0 & 262144) != 0;
			}
		}

		// Token: 0x06001F50 RID: 8016 RVA: 0x00077C79 File Offset: 0x00075E79
		[DebuggerNonUserCode]
		public void ClearCampaignProgress()
		{
			this._hasBits0 &= -262145;
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06001F51 RID: 8017 RVA: 0x00077C90 File Offset: 0x00075E90
		// (set) Token: 0x06001F52 RID: 8018 RVA: 0x00077CC5 File Offset: 0x00075EC5
		[DebuggerNonUserCode]
		public bool PrivacyFlag
		{
			get
			{
				bool flag = (this._hasBits0 & 524288) != 0;
				bool privacyFlagDefaultValue;
				if (flag)
				{
					privacyFlagDefaultValue = this.privacyFlag_;
				}
				else
				{
					privacyFlagDefaultValue = HeroProfile.PrivacyFlagDefaultValue;
				}
				return privacyFlagDefaultValue;
			}
			set
			{
				this._hasBits0 |= 524288;
				this.privacyFlag_ = value;
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06001F53 RID: 8019 RVA: 0x00077CE4 File Offset: 0x00075EE4
		[DebuggerNonUserCode]
		public bool HasPrivacyFlag
		{
			get
			{
				return (this._hasBits0 & 524288) != 0;
			}
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x00077D05 File Offset: 0x00075F05
		[DebuggerNonUserCode]
		public void ClearPrivacyFlag()
		{
			this._hasBits0 &= -524289;
		}

		// Token: 0x06001F55 RID: 8021 RVA: 0x00077D1C File Offset: 0x00075F1C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeroProfile);
		}

		// Token: 0x06001F56 RID: 8022 RVA: 0x00077D3C File Offset: 0x00075F3C
		[DebuggerNonUserCode]
		public bool Equals(HeroProfile other)
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
					bool flag4 = this.MonstersKilled != other.MonstersKilled;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ElitesKilled != other.ElitesKilled;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.GoldCollected != other.GoldCollected;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.HighestLevel != other.HighestLevel;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.CreateTime != other.CreateTime;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.ItemPower != other.ItemPower;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.ResistShadow != other.ResistShadow;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.ResistFire != other.ResistFire;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.ResistLightning != other.ResistLightning;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.ResistPoison != other.ResistPoison;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.ResistCold != other.ResistCold;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = !object.Equals(this.Equipment, other.Equipment);
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = !object.Equals(this.SnoActiveSkills, other.SnoActiveSkills);
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = this.DeathTime != other.DeathTime;
																		if (flag17)
																		{
																			flag2 = false;
																		}
																		else
																		{
																			bool flag18 = !object.Equals(this.KillerInfo, other.KillerInfo);
																			if (flag18)
																			{
																				flag2 = false;
																			}
																			else
																			{
																				bool flag19 = this.SnoKillLocation != other.SnoKillLocation;
																				if (flag19)
																				{
																					flag2 = false;
																				}
																				else
																				{
																					bool flag20 = this.HeroId != other.HeroId;
																					if (flag20)
																					{
																						flag2 = false;
																					}
																					else
																					{
																						bool flag21 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Toughness, other.Toughness);
																						if (flag21)
																						{
																							flag2 = false;
																						}
																						else
																						{
																							bool flag22 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Healing, other.Healing);
																							if (flag22)
																							{
																								flag2 = false;
																							}
																							else
																							{
																								bool flag23 = this.SeasonCreated != other.SeasonCreated;
																								if (flag23)
																								{
																									flag2 = false;
																								}
																								else
																								{
																									bool flag24 = !object.Equals(this.PlayerTitle, other.PlayerTitle);
																									if (flag24)
																									{
																										flag2 = false;
																									}
																									else
																									{
																										bool flag25 = this.PlayerFlags != other.PlayerFlags;
																										if (flag25)
																										{
																											flag2 = false;
																										}
																										else
																										{
																											bool flag26 = this.SnoClass != other.SnoClass;
																											if (flag26)
																											{
																												flag2 = false;
																											}
																											else
																											{
																												bool flag27 = !this.transmogSlot_.Equals(other.transmogSlot_);
																												if (flag27)
																												{
																													flag2 = false;
																												}
																												else
																												{
																													bool flag28 = !object.Equals(this.VisualEquipment, other.VisualEquipment);
																													if (flag28)
																													{
																														flag2 = false;
																													}
																													else
																													{
																														bool flag29 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.CampaignProgress, other.CampaignProgress);
																														if (flag29)
																														{
																															flag2 = false;
																														}
																														else
																														{
																															bool flag30 = this.PrivacyFlag != other.PrivacyFlag;
																															flag2 = !flag30 && object.Equals(this._unknownFields, other._unknownFields);
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
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001F57 RID: 8023 RVA: 0x000780C8 File Offset: 0x000762C8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasMonstersKilled = this.HasMonstersKilled;
			if (hasMonstersKilled)
			{
				num ^= this.MonstersKilled.GetHashCode();
			}
			bool hasElitesKilled = this.HasElitesKilled;
			if (hasElitesKilled)
			{
				num ^= this.ElitesKilled.GetHashCode();
			}
			bool hasGoldCollected = this.HasGoldCollected;
			if (hasGoldCollected)
			{
				num ^= this.GoldCollected.GetHashCode();
			}
			bool hasHighestLevel = this.HasHighestLevel;
			if (hasHighestLevel)
			{
				num ^= this.HighestLevel.GetHashCode();
			}
			bool hasCreateTime = this.HasCreateTime;
			if (hasCreateTime)
			{
				num ^= this.CreateTime.GetHashCode();
			}
			bool hasItemPower = this.HasItemPower;
			if (hasItemPower)
			{
				num ^= this.ItemPower.GetHashCode();
			}
			bool hasResistShadow = this.HasResistShadow;
			if (hasResistShadow)
			{
				num ^= this.ResistShadow.GetHashCode();
			}
			bool hasResistFire = this.HasResistFire;
			if (hasResistFire)
			{
				num ^= this.ResistFire.GetHashCode();
			}
			bool hasResistLightning = this.HasResistLightning;
			if (hasResistLightning)
			{
				num ^= this.ResistLightning.GetHashCode();
			}
			bool hasResistPoison = this.HasResistPoison;
			if (hasResistPoison)
			{
				num ^= this.ResistPoison.GetHashCode();
			}
			bool hasResistCold = this.HasResistCold;
			if (hasResistCold)
			{
				num ^= this.ResistCold.GetHashCode();
			}
			bool flag = this.equipment_ != null;
			if (flag)
			{
				num ^= this.Equipment.GetHashCode();
			}
			bool flag2 = this.snoActiveSkills_ != null;
			if (flag2)
			{
				num ^= this.SnoActiveSkills.GetHashCode();
			}
			bool hasDeathTime = this.HasDeathTime;
			if (hasDeathTime)
			{
				num ^= this.DeathTime.GetHashCode();
			}
			bool flag3 = this.killerInfo_ != null;
			if (flag3)
			{
				num ^= this.KillerInfo.GetHashCode();
			}
			bool hasSnoKillLocation = this.HasSnoKillLocation;
			if (hasSnoKillLocation)
			{
				num ^= this.SnoKillLocation.GetHashCode();
			}
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				num ^= this.HeroId.GetHashCode();
			}
			bool hasToughness = this.HasToughness;
			if (hasToughness)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Toughness);
			}
			bool hasHealing = this.HasHealing;
			if (hasHealing)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Healing);
			}
			bool hasSeasonCreated = this.HasSeasonCreated;
			if (hasSeasonCreated)
			{
				num ^= this.SeasonCreated.GetHashCode();
			}
			bool flag4 = this.playerTitle_ != null;
			if (flag4)
			{
				num ^= this.PlayerTitle.GetHashCode();
			}
			bool hasPlayerFlags = this.HasPlayerFlags;
			if (hasPlayerFlags)
			{
				num ^= this.PlayerFlags.GetHashCode();
			}
			bool hasSnoClass = this.HasSnoClass;
			if (hasSnoClass)
			{
				num ^= this.SnoClass.GetHashCode();
			}
			num ^= this.transmogSlot_.GetHashCode();
			bool flag5 = this.visualEquipment_ != null;
			if (flag5)
			{
				num ^= this.VisualEquipment.GetHashCode();
			}
			bool hasCampaignProgress = this.HasCampaignProgress;
			if (hasCampaignProgress)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.CampaignProgress);
			}
			bool hasPrivacyFlag = this.HasPrivacyFlag;
			if (hasPrivacyFlag)
			{
				num ^= this.PrivacyFlag.GetHashCode();
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x0007840C File Offset: 0x0007660C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001F59 RID: 8025 RVA: 0x00078424 File Offset: 0x00076624
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001F5A RID: 8026 RVA: 0x00078430 File Offset: 0x00076630
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasMonstersKilled = this.HasMonstersKilled;
			if (hasMonstersKilled)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.MonstersKilled);
			}
			bool hasElitesKilled = this.HasElitesKilled;
			if (hasElitesKilled)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.ElitesKilled);
			}
			bool hasGoldCollected = this.HasGoldCollected;
			if (hasGoldCollected)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.GoldCollected);
			}
			bool hasHighestLevel = this.HasHighestLevel;
			if (hasHighestLevel)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.HighestLevel);
			}
			bool hasCreateTime = this.HasCreateTime;
			if (hasCreateTime)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.CreateTime);
			}
			bool hasItemPower = this.HasItemPower;
			if (hasItemPower)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.ItemPower);
			}
			bool hasResistShadow = this.HasResistShadow;
			if (hasResistShadow)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.ResistShadow);
			}
			bool hasResistFire = this.HasResistFire;
			if (hasResistFire)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.ResistFire);
			}
			bool hasResistLightning = this.HasResistLightning;
			if (hasResistLightning)
			{
				output.WriteRawTag(128, 1);
				output.WriteUInt32(this.ResistLightning);
			}
			bool hasResistPoison = this.HasResistPoison;
			if (hasResistPoison)
			{
				output.WriteRawTag(136, 1);
				output.WriteUInt32(this.ResistPoison);
			}
			bool hasResistCold = this.HasResistCold;
			if (hasResistCold)
			{
				output.WriteRawTag(144, 1);
				output.WriteUInt32(this.ResistCold);
			}
			bool flag = this.equipment_ != null;
			if (flag)
			{
				output.WriteRawTag(154, 1);
				output.WriteMessage(this.Equipment);
			}
			bool flag2 = this.snoActiveSkills_ != null;
			if (flag2)
			{
				output.WriteRawTag(162, 1);
				output.WriteMessage(this.SnoActiveSkills);
			}
			bool hasDeathTime = this.HasDeathTime;
			if (hasDeathTime)
			{
				output.WriteRawTag(176, 1);
				output.WriteUInt32(this.DeathTime);
			}
			bool flag3 = this.killerInfo_ != null;
			if (flag3)
			{
				output.WriteRawTag(186, 1);
				output.WriteMessage(this.KillerInfo);
			}
			bool hasSnoKillLocation = this.HasSnoKillLocation;
			if (hasSnoKillLocation)
			{
				output.WriteRawTag(192, 1);
				output.WriteUInt32(this.SnoKillLocation);
			}
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				output.WriteRawTag(218, 1);
				output.WriteBytes(this.HeroId);
			}
			bool hasToughness = this.HasToughness;
			if (hasToughness)
			{
				output.WriteRawTag(189, 2);
				output.WriteFloat(this.Toughness);
			}
			bool hasHealing = this.HasHealing;
			if (hasHealing)
			{
				output.WriteRawTag(197, 2);
				output.WriteFloat(this.Healing);
			}
			bool hasSeasonCreated = this.HasSeasonCreated;
			if (hasSeasonCreated)
			{
				output.WriteRawTag(200, 2);
				output.WriteUInt32(this.SeasonCreated);
			}
			bool flag4 = this.playerTitle_ != null;
			if (flag4)
			{
				output.WriteRawTag(210, 2);
				output.WriteMessage(this.PlayerTitle);
			}
			bool hasPlayerFlags = this.HasPlayerFlags;
			if (hasPlayerFlags)
			{
				output.WriteRawTag(216, 2);
				output.WriteUInt32(this.PlayerFlags);
			}
			bool hasSnoClass = this.HasSnoClass;
			if (hasSnoClass)
			{
				output.WriteRawTag(224, 2);
				output.WriteUInt32(this.SnoClass);
			}
			this.transmogSlot_.WriteTo(ref output, HeroProfile._repeated_transmogSlot_codec);
			bool flag5 = this.visualEquipment_ != null;
			if (flag5)
			{
				output.WriteRawTag(242, 2);
				output.WriteMessage(this.VisualEquipment);
			}
			bool hasCampaignProgress = this.HasCampaignProgress;
			if (hasCampaignProgress)
			{
				output.WriteRawTag(253, 2);
				output.WriteFloat(this.CampaignProgress);
			}
			bool hasPrivacyFlag = this.HasPrivacyFlag;
			if (hasPrivacyFlag)
			{
				output.WriteRawTag(128, 3);
				output.WriteBool(this.PrivacyFlag);
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001F5B RID: 8027 RVA: 0x00078864 File Offset: 0x00076A64
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasMonstersKilled = this.HasMonstersKilled;
			if (hasMonstersKilled)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.MonstersKilled);
			}
			bool hasElitesKilled = this.HasElitesKilled;
			if (hasElitesKilled)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ElitesKilled);
			}
			bool hasGoldCollected = this.HasGoldCollected;
			if (hasGoldCollected)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.GoldCollected);
			}
			bool hasHighestLevel = this.HasHighestLevel;
			if (hasHighestLevel)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HighestLevel);
			}
			bool hasCreateTime = this.HasCreateTime;
			if (hasCreateTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CreateTime);
			}
			bool hasItemPower = this.HasItemPower;
			if (hasItemPower)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemPower);
			}
			bool hasResistShadow = this.HasResistShadow;
			if (hasResistShadow)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ResistShadow);
			}
			bool hasResistFire = this.HasResistFire;
			if (hasResistFire)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ResistFire);
			}
			bool hasResistLightning = this.HasResistLightning;
			if (hasResistLightning)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.ResistLightning);
			}
			bool hasResistPoison = this.HasResistPoison;
			if (hasResistPoison)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.ResistPoison);
			}
			bool hasResistCold = this.HasResistCold;
			if (hasResistCold)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.ResistCold);
			}
			bool flag = this.equipment_ != null;
			if (flag)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.Equipment);
			}
			bool flag2 = this.snoActiveSkills_ != null;
			if (flag2)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SnoActiveSkills);
			}
			bool hasDeathTime = this.HasDeathTime;
			if (hasDeathTime)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.DeathTime);
			}
			bool flag3 = this.killerInfo_ != null;
			if (flag3)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.KillerInfo);
			}
			bool hasSnoKillLocation = this.HasSnoKillLocation;
			if (hasSnoKillLocation)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.SnoKillLocation);
			}
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.HeroId);
			}
			bool hasToughness = this.HasToughness;
			if (hasToughness)
			{
				num += 6;
			}
			bool hasHealing = this.HasHealing;
			if (hasHealing)
			{
				num += 6;
			}
			bool hasSeasonCreated = this.HasSeasonCreated;
			if (hasSeasonCreated)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.SeasonCreated);
			}
			bool flag4 = this.playerTitle_ != null;
			if (flag4)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PlayerTitle);
			}
			bool hasPlayerFlags = this.HasPlayerFlags;
			if (hasPlayerFlags)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.PlayerFlags);
			}
			bool hasSnoClass = this.HasSnoClass;
			if (hasSnoClass)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.SnoClass);
			}
			num += this.transmogSlot_.CalculateSize(HeroProfile._repeated_transmogSlot_codec);
			bool flag5 = this.visualEquipment_ != null;
			if (flag5)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.VisualEquipment);
			}
			bool hasCampaignProgress = this.HasCampaignProgress;
			if (hasCampaignProgress)
			{
				num += 6;
			}
			bool hasPrivacyFlag = this.HasPrivacyFlag;
			if (hasPrivacyFlag)
			{
				num += 3;
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x00078B94 File Offset: 0x00076D94
		[DebuggerNonUserCode]
		public void MergeFrom(HeroProfile other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasMonstersKilled = other.HasMonstersKilled;
				if (hasMonstersKilled)
				{
					this.MonstersKilled = other.MonstersKilled;
				}
				bool hasElitesKilled = other.HasElitesKilled;
				if (hasElitesKilled)
				{
					this.ElitesKilled = other.ElitesKilled;
				}
				bool hasGoldCollected = other.HasGoldCollected;
				if (hasGoldCollected)
				{
					this.GoldCollected = other.GoldCollected;
				}
				bool hasHighestLevel = other.HasHighestLevel;
				if (hasHighestLevel)
				{
					this.HighestLevel = other.HighestLevel;
				}
				bool hasCreateTime = other.HasCreateTime;
				if (hasCreateTime)
				{
					this.CreateTime = other.CreateTime;
				}
				bool hasItemPower = other.HasItemPower;
				if (hasItemPower)
				{
					this.ItemPower = other.ItemPower;
				}
				bool hasResistShadow = other.HasResistShadow;
				if (hasResistShadow)
				{
					this.ResistShadow = other.ResistShadow;
				}
				bool hasResistFire = other.HasResistFire;
				if (hasResistFire)
				{
					this.ResistFire = other.ResistFire;
				}
				bool hasResistLightning = other.HasResistLightning;
				if (hasResistLightning)
				{
					this.ResistLightning = other.ResistLightning;
				}
				bool hasResistPoison = other.HasResistPoison;
				if (hasResistPoison)
				{
					this.ResistPoison = other.ResistPoison;
				}
				bool hasResistCold = other.HasResistCold;
				if (hasResistCold)
				{
					this.ResistCold = other.ResistCold;
				}
				bool flag2 = other.equipment_ != null;
				if (flag2)
				{
					bool flag3 = this.equipment_ == null;
					if (flag3)
					{
						this.Equipment = new ItemList();
					}
					this.Equipment.MergeFrom(other.Equipment);
				}
				bool flag4 = other.snoActiveSkills_ != null;
				if (flag4)
				{
					bool flag5 = this.snoActiveSkills_ == null;
					if (flag5)
					{
						this.SnoActiveSkills = new ActiveSkills();
					}
					this.SnoActiveSkills.MergeFrom(other.SnoActiveSkills);
				}
				bool hasDeathTime = other.HasDeathTime;
				if (hasDeathTime)
				{
					this.DeathTime = other.DeathTime;
				}
				bool flag6 = other.killerInfo_ != null;
				if (flag6)
				{
					bool flag7 = this.killerInfo_ == null;
					if (flag7)
					{
						this.KillerInfo = new KillerInfo();
					}
					this.KillerInfo.MergeFrom(other.KillerInfo);
				}
				bool hasSnoKillLocation = other.HasSnoKillLocation;
				if (hasSnoKillLocation)
				{
					this.SnoKillLocation = other.SnoKillLocation;
				}
				bool hasHeroId = other.HasHeroId;
				if (hasHeroId)
				{
					this.HeroId = other.HeroId;
				}
				bool hasToughness = other.HasToughness;
				if (hasToughness)
				{
					this.Toughness = other.Toughness;
				}
				bool hasHealing = other.HasHealing;
				if (hasHealing)
				{
					this.Healing = other.Healing;
				}
				bool hasSeasonCreated = other.HasSeasonCreated;
				if (hasSeasonCreated)
				{
					this.SeasonCreated = other.SeasonCreated;
				}
				bool flag8 = other.playerTitle_ != null;
				if (flag8)
				{
					bool flag9 = this.playerTitle_ == null;
					if (flag9)
					{
						this.PlayerTitle = new PlayerTitle();
					}
					this.PlayerTitle.MergeFrom(other.PlayerTitle);
				}
				bool hasPlayerFlags = other.HasPlayerFlags;
				if (hasPlayerFlags)
				{
					this.PlayerFlags = other.PlayerFlags;
				}
				bool hasSnoClass = other.HasSnoClass;
				if (hasSnoClass)
				{
					this.SnoClass = other.SnoClass;
				}
				this.transmogSlot_.Add(other.transmogSlot_);
				bool flag10 = other.visualEquipment_ != null;
				if (flag10)
				{
					bool flag11 = this.visualEquipment_ == null;
					if (flag11)
					{
						this.VisualEquipment = new VisualEquipment();
					}
					this.VisualEquipment.MergeFrom(other.VisualEquipment);
				}
				bool hasCampaignProgress = other.HasCampaignProgress;
				if (hasCampaignProgress)
				{
					this.CampaignProgress = other.CampaignProgress;
				}
				bool hasPrivacyFlag = other.HasPrivacyFlag;
				if (hasPrivacyFlag)
				{
					this.PrivacyFlag = other.PrivacyFlag;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x00078F4A File Offset: 0x0007714A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x00078F58 File Offset: 0x00077158
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 162U)
				{
					if (num3 <= 104U)
					{
						if (num3 <= 24U)
						{
							if (num3 != 8U)
							{
								if (num3 != 16U)
								{
									if (num3 != 24U)
									{
										goto IL_01B3;
									}
									this.GoldCollected = input.ReadUInt64();
								}
								else
								{
									this.ElitesKilled = input.ReadUInt64();
								}
							}
							else
							{
								this.MonstersKilled = input.ReadUInt64();
							}
						}
						else if (num3 != 32U)
						{
							if (num3 != 48U)
							{
								if (num3 != 104U)
								{
									goto IL_01B3;
								}
								this.ItemPower = input.ReadUInt32();
							}
							else
							{
								this.CreateTime = input.ReadUInt32();
							}
						}
						else
						{
							this.HighestLevel = input.ReadUInt32();
						}
					}
					else if (num3 <= 128U)
					{
						if (num3 != 112U)
						{
							if (num3 != 120U)
							{
								if (num3 != 128U)
								{
									goto IL_01B3;
								}
								this.ResistLightning = input.ReadUInt32();
							}
							else
							{
								this.ResistFire = input.ReadUInt32();
							}
						}
						else
						{
							this.ResistShadow = input.ReadUInt32();
						}
					}
					else if (num3 <= 144U)
					{
						if (num3 != 136U)
						{
							if (num3 != 144U)
							{
								goto IL_01B3;
							}
							this.ResistCold = input.ReadUInt32();
						}
						else
						{
							this.ResistPoison = input.ReadUInt32();
						}
					}
					else if (num3 != 154U)
					{
						if (num3 != 162U)
						{
							goto IL_01B3;
						}
						bool flag = this.snoActiveSkills_ == null;
						if (flag)
						{
							this.SnoActiveSkills = new ActiveSkills();
						}
						input.ReadMessage(this.SnoActiveSkills);
					}
					else
					{
						bool flag2 = this.equipment_ == null;
						if (flag2)
						{
							this.Equipment = new ItemList();
						}
						input.ReadMessage(this.Equipment);
					}
				}
				else if (num3 <= 328U)
				{
					if (num3 <= 192U)
					{
						if (num3 != 176U)
						{
							if (num3 != 186U)
							{
								if (num3 != 192U)
								{
									goto IL_01B3;
								}
								this.SnoKillLocation = input.ReadUInt32();
							}
							else
							{
								bool flag3 = this.killerInfo_ == null;
								if (flag3)
								{
									this.KillerInfo = new KillerInfo();
								}
								input.ReadMessage(this.KillerInfo);
							}
						}
						else
						{
							this.DeathTime = input.ReadUInt32();
						}
					}
					else if (num3 <= 317U)
					{
						if (num3 != 218U)
						{
							if (num3 != 317U)
							{
								goto IL_01B3;
							}
							this.Toughness = input.ReadFloat();
						}
						else
						{
							this.HeroId = input.ReadBytes();
						}
					}
					else if (num3 != 325U)
					{
						if (num3 != 328U)
						{
							goto IL_01B3;
						}
						this.SeasonCreated = input.ReadUInt32();
					}
					else
					{
						this.Healing = input.ReadFloat();
					}
				}
				else if (num3 <= 352U)
				{
					if (num3 != 338U)
					{
						if (num3 != 344U)
						{
							if (num3 != 352U)
							{
								goto IL_01B3;
							}
							this.SnoClass = input.ReadUInt32();
						}
						else
						{
							this.PlayerFlags = input.ReadUInt32();
						}
					}
					else
					{
						bool flag4 = this.playerTitle_ == null;
						if (flag4)
						{
							this.PlayerTitle = new PlayerTitle();
						}
						input.ReadMessage(this.PlayerTitle);
					}
				}
				else if (num3 <= 370U)
				{
					if (num3 != 362U)
					{
						if (num3 != 370U)
						{
							goto IL_01B3;
						}
						bool flag5 = this.visualEquipment_ == null;
						if (flag5)
						{
							this.VisualEquipment = new VisualEquipment();
						}
						input.ReadMessage(this.VisualEquipment);
					}
					else
					{
						this.transmogSlot_.AddEntriesFrom(ref input, HeroProfile._repeated_transmogSlot_codec);
					}
				}
				else if (num3 != 381U)
				{
					if (num3 != 384U)
					{
						goto IL_01B3;
					}
					this.PrivacyFlag = input.ReadBool();
				}
				else
				{
					this.CampaignProgress = input.ReadFloat();
				}
				continue;
				IL_01B3:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000D59 RID: 3417
		private static readonly MessageParser<HeroProfile> _parser = new MessageParser<HeroProfile>(() => new HeroProfile());

		// Token: 0x04000D5A RID: 3418
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D5B RID: 3419
		private int _hasBits0;

		// Token: 0x04000D5C RID: 3420
		public const int MonstersKilledFieldNumber = 1;

		// Token: 0x04000D5D RID: 3421
		private static readonly ulong MonstersKilledDefaultValue = 0UL;

		// Token: 0x04000D5E RID: 3422
		private ulong monstersKilled_;

		// Token: 0x04000D5F RID: 3423
		public const int ElitesKilledFieldNumber = 2;

		// Token: 0x04000D60 RID: 3424
		private static readonly ulong ElitesKilledDefaultValue = 0UL;

		// Token: 0x04000D61 RID: 3425
		private ulong elitesKilled_;

		// Token: 0x04000D62 RID: 3426
		public const int GoldCollectedFieldNumber = 3;

		// Token: 0x04000D63 RID: 3427
		private static readonly ulong GoldCollectedDefaultValue = 0UL;

		// Token: 0x04000D64 RID: 3428
		private ulong goldCollected_;

		// Token: 0x04000D65 RID: 3429
		public const int HighestLevelFieldNumber = 4;

		// Token: 0x04000D66 RID: 3430
		private static readonly uint HighestLevelDefaultValue = 0U;

		// Token: 0x04000D67 RID: 3431
		private uint highestLevel_;

		// Token: 0x04000D68 RID: 3432
		public const int CreateTimeFieldNumber = 6;

		// Token: 0x04000D69 RID: 3433
		private static readonly uint CreateTimeDefaultValue = 0U;

		// Token: 0x04000D6A RID: 3434
		private uint createTime_;

		// Token: 0x04000D6B RID: 3435
		public const int ItemPowerFieldNumber = 13;

		// Token: 0x04000D6C RID: 3436
		private static readonly uint ItemPowerDefaultValue = 0U;

		// Token: 0x04000D6D RID: 3437
		private uint itemPower_;

		// Token: 0x04000D6E RID: 3438
		public const int ResistShadowFieldNumber = 14;

		// Token: 0x04000D6F RID: 3439
		private static readonly uint ResistShadowDefaultValue = 0U;

		// Token: 0x04000D70 RID: 3440
		private uint resistShadow_;

		// Token: 0x04000D71 RID: 3441
		public const int ResistFireFieldNumber = 15;

		// Token: 0x04000D72 RID: 3442
		private static readonly uint ResistFireDefaultValue = 0U;

		// Token: 0x04000D73 RID: 3443
		private uint resistFire_;

		// Token: 0x04000D74 RID: 3444
		public const int ResistLightningFieldNumber = 16;

		// Token: 0x04000D75 RID: 3445
		private static readonly uint ResistLightningDefaultValue = 0U;

		// Token: 0x04000D76 RID: 3446
		private uint resistLightning_;

		// Token: 0x04000D77 RID: 3447
		public const int ResistPoisonFieldNumber = 17;

		// Token: 0x04000D78 RID: 3448
		private static readonly uint ResistPoisonDefaultValue = 0U;

		// Token: 0x04000D79 RID: 3449
		private uint resistPoison_;

		// Token: 0x04000D7A RID: 3450
		public const int ResistColdFieldNumber = 18;

		// Token: 0x04000D7B RID: 3451
		private static readonly uint ResistColdDefaultValue = 0U;

		// Token: 0x04000D7C RID: 3452
		private uint resistCold_;

		// Token: 0x04000D7D RID: 3453
		public const int EquipmentFieldNumber = 19;

		// Token: 0x04000D7E RID: 3454
		private ItemList equipment_;

		// Token: 0x04000D7F RID: 3455
		public const int SnoActiveSkillsFieldNumber = 20;

		// Token: 0x04000D80 RID: 3456
		private ActiveSkills snoActiveSkills_;

		// Token: 0x04000D81 RID: 3457
		public const int DeathTimeFieldNumber = 22;

		// Token: 0x04000D82 RID: 3458
		private static readonly uint DeathTimeDefaultValue = 0U;

		// Token: 0x04000D83 RID: 3459
		private uint deathTime_;

		// Token: 0x04000D84 RID: 3460
		public const int KillerInfoFieldNumber = 23;

		// Token: 0x04000D85 RID: 3461
		private KillerInfo killerInfo_;

		// Token: 0x04000D86 RID: 3462
		public const int SnoKillLocationFieldNumber = 24;

		// Token: 0x04000D87 RID: 3463
		private static readonly uint SnoKillLocationDefaultValue = 0U;

		// Token: 0x04000D88 RID: 3464
		private uint snoKillLocation_;

		// Token: 0x04000D89 RID: 3465
		public const int HeroIdFieldNumber = 27;

		// Token: 0x04000D8A RID: 3466
		private static readonly ByteString HeroIdDefaultValue = ByteString.Empty;

		// Token: 0x04000D8B RID: 3467
		private ByteString heroId_;

		// Token: 0x04000D8C RID: 3468
		public const int ToughnessFieldNumber = 39;

		// Token: 0x04000D8D RID: 3469
		private static readonly float ToughnessDefaultValue = 0f;

		// Token: 0x04000D8E RID: 3470
		private float toughness_;

		// Token: 0x04000D8F RID: 3471
		public const int HealingFieldNumber = 40;

		// Token: 0x04000D90 RID: 3472
		private static readonly float HealingDefaultValue = 0f;

		// Token: 0x04000D91 RID: 3473
		private float healing_;

		// Token: 0x04000D92 RID: 3474
		public const int SeasonCreatedFieldNumber = 41;

		// Token: 0x04000D93 RID: 3475
		private static readonly uint SeasonCreatedDefaultValue = 0U;

		// Token: 0x04000D94 RID: 3476
		private uint seasonCreated_;

		// Token: 0x04000D95 RID: 3477
		public const int PlayerTitleFieldNumber = 42;

		// Token: 0x04000D96 RID: 3478
		private PlayerTitle playerTitle_;

		// Token: 0x04000D97 RID: 3479
		public const int PlayerFlagsFieldNumber = 43;

		// Token: 0x04000D98 RID: 3480
		private static readonly uint PlayerFlagsDefaultValue = 0U;

		// Token: 0x04000D99 RID: 3481
		private uint playerFlags_;

		// Token: 0x04000D9A RID: 3482
		public const int SnoClassFieldNumber = 44;

		// Token: 0x04000D9B RID: 3483
		private static readonly uint SnoClassDefaultValue = 0U;

		// Token: 0x04000D9C RID: 3484
		private uint snoClass_;

		// Token: 0x04000D9D RID: 3485
		public const int TransmogSlotFieldNumber = 45;

		// Token: 0x04000D9E RID: 3486
		private static readonly FieldCodec<TransmogSlot> _repeated_transmogSlot_codec = FieldCodec.ForMessage<TransmogSlot>(362U, Fenris.Hero.TransmogSlot.Parser);

		// Token: 0x04000D9F RID: 3487
		private readonly RepeatedField<TransmogSlot> transmogSlot_ = new RepeatedField<TransmogSlot>();

		// Token: 0x04000DA0 RID: 3488
		public const int VisualEquipmentFieldNumber = 46;

		// Token: 0x04000DA1 RID: 3489
		private VisualEquipment visualEquipment_;

		// Token: 0x04000DA2 RID: 3490
		public const int CampaignProgressFieldNumber = 47;

		// Token: 0x04000DA3 RID: 3491
		private static readonly float CampaignProgressDefaultValue = 0f;

		// Token: 0x04000DA4 RID: 3492
		private float campaignProgress_;

		// Token: 0x04000DA5 RID: 3493
		public const int PrivacyFlagFieldNumber = 48;

		// Token: 0x04000DA6 RID: 3494
		private static readonly bool PrivacyFlagDefaultValue = false;

		// Token: 0x04000DA7 RID: 3495
		private bool privacyFlag_;
	}
}
