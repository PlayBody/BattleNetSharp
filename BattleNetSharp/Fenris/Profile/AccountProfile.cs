using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Profile
{
	// Token: 0x02000138 RID: 312
	public sealed class AccountProfile : IMessage<AccountProfile>, IMessage, IEquatable<AccountProfile>, IDeepCloneable<AccountProfile>, IBufferMessage
	{
		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06001F99 RID: 8089 RVA: 0x0007A110 File Offset: 0x00078310
		[DebuggerNonUserCode]
		public static MessageParser<AccountProfile> Parser
		{
			get
			{
				return AccountProfile._parser;
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06001F9A RID: 8090 RVA: 0x0007A128 File Offset: 0x00078328
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ProfileReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06001F9B RID: 8091 RVA: 0x0007A14C File Offset: 0x0007834C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccountProfile.Descriptor;
			}
		}

		// Token: 0x06001F9C RID: 8092 RVA: 0x0007A163 File Offset: 0x00078363
		[DebuggerNonUserCode]
		public AccountProfile()
		{
		}

		// Token: 0x06001F9D RID: 8093 RVA: 0x0007A178 File Offset: 0x00078378
		[DebuggerNonUserCode]
		public AccountProfile(AccountProfile other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.monstersKilled_ = other.monstersKilled_;
			this.elitesKilled_ = other.elitesKilled_;
			this.goldCollected_ = other.goldCollected_;
			this.highestHardcoreLevel_ = other.highestHardcoreLevel_;
			this.hardcoreMonstersKilled_ = other.hardcoreMonstersKilled_;
			this.classDruid_ = ((other.classDruid_ != null) ? other.classDruid_.Clone() : null);
			this.classSorcerer_ = ((other.classSorcerer_ != null) ? other.classSorcerer_.Clone() : null);
			this.classBarbarian_ = ((other.classBarbarian_ != null) ? other.classBarbarian_.Clone() : null);
			this.classRogue_ = ((other.classRogue_ != null) ? other.classRogue_.Clone() : null);
			this.classNecromancer_ = ((other.classNecromancer_ != null) ? other.classNecromancer_.Clone() : null);
			this.highestLevel_ = other.highestLevel_;
			this.bloodShardsCollected_ = other.bloodShardsCollected_;
			this.heroes_ = other.heroes_.Clone();
			this.seasonId_ = other.seasonId_;
			this.dungeonsCompleted_ = other.dungeonsCompleted_;
			this.playersKilled_ = other.playersKilled_;
			this.bossesKilled_ = other.bossesKilled_;
			this.privacyFlag_ = other.privacyFlag_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001F9E RID: 8094 RVA: 0x0007A2D8 File Offset: 0x000784D8
		[DebuggerNonUserCode]
		public AccountProfile Clone()
		{
			return new AccountProfile(this);
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06001F9F RID: 8095 RVA: 0x0007A2F0 File Offset: 0x000784F0
		// (set) Token: 0x06001FA0 RID: 8096 RVA: 0x0007A321 File Offset: 0x00078521
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
					monstersKilledDefaultValue = AccountProfile.MonstersKilledDefaultValue;
				}
				return monstersKilledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.monstersKilled_ = value;
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06001FA1 RID: 8097 RVA: 0x0007A33C File Offset: 0x0007853C
		[DebuggerNonUserCode]
		public bool HasMonstersKilled
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001FA2 RID: 8098 RVA: 0x0007A359 File Offset: 0x00078559
		[DebuggerNonUserCode]
		public void ClearMonstersKilled()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06001FA3 RID: 8099 RVA: 0x0007A36C File Offset: 0x0007856C
		// (set) Token: 0x06001FA4 RID: 8100 RVA: 0x0007A39D File Offset: 0x0007859D
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
					elitesKilledDefaultValue = AccountProfile.ElitesKilledDefaultValue;
				}
				return elitesKilledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.elitesKilled_ = value;
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06001FA5 RID: 8101 RVA: 0x0007A3B8 File Offset: 0x000785B8
		[DebuggerNonUserCode]
		public bool HasElitesKilled
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001FA6 RID: 8102 RVA: 0x0007A3D5 File Offset: 0x000785D5
		[DebuggerNonUserCode]
		public void ClearElitesKilled()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06001FA7 RID: 8103 RVA: 0x0007A3E8 File Offset: 0x000785E8
		// (set) Token: 0x06001FA8 RID: 8104 RVA: 0x0007A419 File Offset: 0x00078619
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
					goldCollectedDefaultValue = AccountProfile.GoldCollectedDefaultValue;
				}
				return goldCollectedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.goldCollected_ = value;
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06001FA9 RID: 8105 RVA: 0x0007A434 File Offset: 0x00078634
		[DebuggerNonUserCode]
		public bool HasGoldCollected
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06001FAA RID: 8106 RVA: 0x0007A451 File Offset: 0x00078651
		[DebuggerNonUserCode]
		public void ClearGoldCollected()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06001FAB RID: 8107 RVA: 0x0007A464 File Offset: 0x00078664
		// (set) Token: 0x06001FAC RID: 8108 RVA: 0x0007A495 File Offset: 0x00078695
		[DebuggerNonUserCode]
		public ulong HighestHardcoreLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				ulong highestHardcoreLevelDefaultValue;
				if (flag)
				{
					highestHardcoreLevelDefaultValue = this.highestHardcoreLevel_;
				}
				else
				{
					highestHardcoreLevelDefaultValue = AccountProfile.HighestHardcoreLevelDefaultValue;
				}
				return highestHardcoreLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.highestHardcoreLevel_ = value;
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06001FAD RID: 8109 RVA: 0x0007A4B0 File Offset: 0x000786B0
		[DebuggerNonUserCode]
		public bool HasHighestHardcoreLevel
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06001FAE RID: 8110 RVA: 0x0007A4CD File Offset: 0x000786CD
		[DebuggerNonUserCode]
		public void ClearHighestHardcoreLevel()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06001FAF RID: 8111 RVA: 0x0007A4E0 File Offset: 0x000786E0
		// (set) Token: 0x06001FB0 RID: 8112 RVA: 0x0007A512 File Offset: 0x00078712
		[DebuggerNonUserCode]
		public ulong HardcoreMonstersKilled
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				ulong hardcoreMonstersKilledDefaultValue;
				if (flag)
				{
					hardcoreMonstersKilledDefaultValue = this.hardcoreMonstersKilled_;
				}
				else
				{
					hardcoreMonstersKilledDefaultValue = AccountProfile.HardcoreMonstersKilledDefaultValue;
				}
				return hardcoreMonstersKilledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.hardcoreMonstersKilled_ = value;
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06001FB1 RID: 8113 RVA: 0x0007A52C File Offset: 0x0007872C
		[DebuggerNonUserCode]
		public bool HasHardcoreMonstersKilled
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06001FB2 RID: 8114 RVA: 0x0007A54A File Offset: 0x0007874A
		[DebuggerNonUserCode]
		public void ClearHardcoreMonstersKilled()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06001FB3 RID: 8115 RVA: 0x0007A55C File Offset: 0x0007875C
		// (set) Token: 0x06001FB4 RID: 8116 RVA: 0x0007A574 File Offset: 0x00078774
		[DebuggerNonUserCode]
		public ClassInfo ClassDruid
		{
			get
			{
				return this.classDruid_;
			}
			set
			{
				this.classDruid_ = value;
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06001FB5 RID: 8117 RVA: 0x0007A580 File Offset: 0x00078780
		// (set) Token: 0x06001FB6 RID: 8118 RVA: 0x0007A598 File Offset: 0x00078798
		[DebuggerNonUserCode]
		public ClassInfo ClassSorcerer
		{
			get
			{
				return this.classSorcerer_;
			}
			set
			{
				this.classSorcerer_ = value;
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06001FB7 RID: 8119 RVA: 0x0007A5A4 File Offset: 0x000787A4
		// (set) Token: 0x06001FB8 RID: 8120 RVA: 0x0007A5BC File Offset: 0x000787BC
		[DebuggerNonUserCode]
		public ClassInfo ClassBarbarian
		{
			get
			{
				return this.classBarbarian_;
			}
			set
			{
				this.classBarbarian_ = value;
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06001FB9 RID: 8121 RVA: 0x0007A5C8 File Offset: 0x000787C8
		// (set) Token: 0x06001FBA RID: 8122 RVA: 0x0007A5E0 File Offset: 0x000787E0
		[DebuggerNonUserCode]
		public ClassInfo ClassRogue
		{
			get
			{
				return this.classRogue_;
			}
			set
			{
				this.classRogue_ = value;
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06001FBB RID: 8123 RVA: 0x0007A5EC File Offset: 0x000787EC
		// (set) Token: 0x06001FBC RID: 8124 RVA: 0x0007A604 File Offset: 0x00078804
		[DebuggerNonUserCode]
		public ClassInfo ClassNecromancer
		{
			get
			{
				return this.classNecromancer_;
			}
			set
			{
				this.classNecromancer_ = value;
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06001FBD RID: 8125 RVA: 0x0007A610 File Offset: 0x00078810
		// (set) Token: 0x06001FBE RID: 8126 RVA: 0x0007A642 File Offset: 0x00078842
		[DebuggerNonUserCode]
		public ulong HighestLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				ulong highestLevelDefaultValue;
				if (flag)
				{
					highestLevelDefaultValue = this.highestLevel_;
				}
				else
				{
					highestLevelDefaultValue = AccountProfile.HighestLevelDefaultValue;
				}
				return highestLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.highestLevel_ = value;
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06001FBF RID: 8127 RVA: 0x0007A65C File Offset: 0x0007885C
		[DebuggerNonUserCode]
		public bool HasHighestLevel
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06001FC0 RID: 8128 RVA: 0x0007A67A File Offset: 0x0007887A
		[DebuggerNonUserCode]
		public void ClearHighestLevel()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06001FC1 RID: 8129 RVA: 0x0007A68C File Offset: 0x0007888C
		// (set) Token: 0x06001FC2 RID: 8130 RVA: 0x0007A6BE File Offset: 0x000788BE
		[DebuggerNonUserCode]
		public ulong BloodShardsCollected
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				ulong bloodShardsCollectedDefaultValue;
				if (flag)
				{
					bloodShardsCollectedDefaultValue = this.bloodShardsCollected_;
				}
				else
				{
					bloodShardsCollectedDefaultValue = AccountProfile.BloodShardsCollectedDefaultValue;
				}
				return bloodShardsCollectedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.bloodShardsCollected_ = value;
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06001FC3 RID: 8131 RVA: 0x0007A6D8 File Offset: 0x000788D8
		[DebuggerNonUserCode]
		public bool HasBloodShardsCollected
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x0007A6F6 File Offset: 0x000788F6
		[DebuggerNonUserCode]
		public void ClearBloodShardsCollected()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06001FC5 RID: 8133 RVA: 0x0007A708 File Offset: 0x00078908
		[DebuggerNonUserCode]
		public RepeatedField<HeroMiniProfile> Heroes
		{
			get
			{
				return this.heroes_;
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06001FC6 RID: 8134 RVA: 0x0007A720 File Offset: 0x00078920
		// (set) Token: 0x06001FC7 RID: 8135 RVA: 0x0007A755 File Offset: 0x00078955
		[DebuggerNonUserCode]
		public uint SeasonId
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				uint seasonIdDefaultValue;
				if (flag)
				{
					seasonIdDefaultValue = this.seasonId_;
				}
				else
				{
					seasonIdDefaultValue = AccountProfile.SeasonIdDefaultValue;
				}
				return seasonIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.seasonId_ = value;
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06001FC8 RID: 8136 RVA: 0x0007A774 File Offset: 0x00078974
		[DebuggerNonUserCode]
		public bool HasSeasonId
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x0007A795 File Offset: 0x00078995
		[DebuggerNonUserCode]
		public void ClearSeasonId()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06001FCA RID: 8138 RVA: 0x0007A7AC File Offset: 0x000789AC
		// (set) Token: 0x06001FCB RID: 8139 RVA: 0x0007A7E1 File Offset: 0x000789E1
		[DebuggerNonUserCode]
		public ulong DungeonsCompleted
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				ulong dungeonsCompletedDefaultValue;
				if (flag)
				{
					dungeonsCompletedDefaultValue = this.dungeonsCompleted_;
				}
				else
				{
					dungeonsCompletedDefaultValue = AccountProfile.DungeonsCompletedDefaultValue;
				}
				return dungeonsCompletedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.dungeonsCompleted_ = value;
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06001FCC RID: 8140 RVA: 0x0007A800 File Offset: 0x00078A00
		[DebuggerNonUserCode]
		public bool HasDungeonsCompleted
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x06001FCD RID: 8141 RVA: 0x0007A821 File Offset: 0x00078A21
		[DebuggerNonUserCode]
		public void ClearDungeonsCompleted()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06001FCE RID: 8142 RVA: 0x0007A838 File Offset: 0x00078A38
		// (set) Token: 0x06001FCF RID: 8143 RVA: 0x0007A86D File Offset: 0x00078A6D
		[DebuggerNonUserCode]
		public ulong PlayersKilled
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				ulong playersKilledDefaultValue;
				if (flag)
				{
					playersKilledDefaultValue = this.playersKilled_;
				}
				else
				{
					playersKilledDefaultValue = AccountProfile.PlayersKilledDefaultValue;
				}
				return playersKilledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.playersKilled_ = value;
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06001FD0 RID: 8144 RVA: 0x0007A88C File Offset: 0x00078A8C
		[DebuggerNonUserCode]
		public bool HasPlayersKilled
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x06001FD1 RID: 8145 RVA: 0x0007A8AD File Offset: 0x00078AAD
		[DebuggerNonUserCode]
		public void ClearPlayersKilled()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06001FD2 RID: 8146 RVA: 0x0007A8C4 File Offset: 0x00078AC4
		// (set) Token: 0x06001FD3 RID: 8147 RVA: 0x0007A8F9 File Offset: 0x00078AF9
		[DebuggerNonUserCode]
		public ulong BossesKilled
		{
			get
			{
				bool flag = (this._hasBits0 & 1024) != 0;
				ulong bossesKilledDefaultValue;
				if (flag)
				{
					bossesKilledDefaultValue = this.bossesKilled_;
				}
				else
				{
					bossesKilledDefaultValue = AccountProfile.BossesKilledDefaultValue;
				}
				return bossesKilledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1024;
				this.bossesKilled_ = value;
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06001FD4 RID: 8148 RVA: 0x0007A918 File Offset: 0x00078B18
		[DebuggerNonUserCode]
		public bool HasBossesKilled
		{
			get
			{
				return (this._hasBits0 & 1024) != 0;
			}
		}

		// Token: 0x06001FD5 RID: 8149 RVA: 0x0007A939 File Offset: 0x00078B39
		[DebuggerNonUserCode]
		public void ClearBossesKilled()
		{
			this._hasBits0 &= -1025;
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06001FD6 RID: 8150 RVA: 0x0007A950 File Offset: 0x00078B50
		// (set) Token: 0x06001FD7 RID: 8151 RVA: 0x0007A985 File Offset: 0x00078B85
		[DebuggerNonUserCode]
		public bool PrivacyFlag
		{
			get
			{
				bool flag = (this._hasBits0 & 2048) != 0;
				bool privacyFlagDefaultValue;
				if (flag)
				{
					privacyFlagDefaultValue = this.privacyFlag_;
				}
				else
				{
					privacyFlagDefaultValue = AccountProfile.PrivacyFlagDefaultValue;
				}
				return privacyFlagDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2048;
				this.privacyFlag_ = value;
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06001FD8 RID: 8152 RVA: 0x0007A9A4 File Offset: 0x00078BA4
		[DebuggerNonUserCode]
		public bool HasPrivacyFlag
		{
			get
			{
				return (this._hasBits0 & 2048) != 0;
			}
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x0007A9C5 File Offset: 0x00078BC5
		[DebuggerNonUserCode]
		public void ClearPrivacyFlag()
		{
			this._hasBits0 &= -2049;
		}

		// Token: 0x06001FDA RID: 8154 RVA: 0x0007A9DC File Offset: 0x00078BDC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AccountProfile);
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x0007A9FC File Offset: 0x00078BFC
		[DebuggerNonUserCode]
		public bool Equals(AccountProfile other)
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
								bool flag7 = this.HighestHardcoreLevel != other.HighestHardcoreLevel;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.HardcoreMonstersKilled != other.HardcoreMonstersKilled;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !object.Equals(this.ClassDruid, other.ClassDruid);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !object.Equals(this.ClassSorcerer, other.ClassSorcerer);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !object.Equals(this.ClassBarbarian, other.ClassBarbarian);
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !object.Equals(this.ClassRogue, other.ClassRogue);
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = !object.Equals(this.ClassNecromancer, other.ClassNecromancer);
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.HighestLevel != other.HighestLevel;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.BloodShardsCollected != other.BloodShardsCollected;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = !this.heroes_.Equals(other.heroes_);
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = this.SeasonId != other.SeasonId;
																		if (flag17)
																		{
																			flag2 = false;
																		}
																		else
																		{
																			bool flag18 = this.DungeonsCompleted != other.DungeonsCompleted;
																			if (flag18)
																			{
																				flag2 = false;
																			}
																			else
																			{
																				bool flag19 = this.PlayersKilled != other.PlayersKilled;
																				if (flag19)
																				{
																					flag2 = false;
																				}
																				else
																				{
																					bool flag20 = this.BossesKilled != other.BossesKilled;
																					if (flag20)
																					{
																						flag2 = false;
																					}
																					else
																					{
																						bool flag21 = this.PrivacyFlag != other.PrivacyFlag;
																						flag2 = !flag21 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x06001FDC RID: 8156 RVA: 0x0007AC60 File Offset: 0x00078E60
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
			bool hasHighestHardcoreLevel = this.HasHighestHardcoreLevel;
			if (hasHighestHardcoreLevel)
			{
				num ^= this.HighestHardcoreLevel.GetHashCode();
			}
			bool hasHardcoreMonstersKilled = this.HasHardcoreMonstersKilled;
			if (hasHardcoreMonstersKilled)
			{
				num ^= this.HardcoreMonstersKilled.GetHashCode();
			}
			bool flag = this.classDruid_ != null;
			if (flag)
			{
				num ^= this.ClassDruid.GetHashCode();
			}
			bool flag2 = this.classSorcerer_ != null;
			if (flag2)
			{
				num ^= this.ClassSorcerer.GetHashCode();
			}
			bool flag3 = this.classBarbarian_ != null;
			if (flag3)
			{
				num ^= this.ClassBarbarian.GetHashCode();
			}
			bool flag4 = this.classRogue_ != null;
			if (flag4)
			{
				num ^= this.ClassRogue.GetHashCode();
			}
			bool flag5 = this.classNecromancer_ != null;
			if (flag5)
			{
				num ^= this.ClassNecromancer.GetHashCode();
			}
			bool hasHighestLevel = this.HasHighestLevel;
			if (hasHighestLevel)
			{
				num ^= this.HighestLevel.GetHashCode();
			}
			bool hasBloodShardsCollected = this.HasBloodShardsCollected;
			if (hasBloodShardsCollected)
			{
				num ^= this.BloodShardsCollected.GetHashCode();
			}
			num ^= this.heroes_.GetHashCode();
			bool hasSeasonId = this.HasSeasonId;
			if (hasSeasonId)
			{
				num ^= this.SeasonId.GetHashCode();
			}
			bool hasDungeonsCompleted = this.HasDungeonsCompleted;
			if (hasDungeonsCompleted)
			{
				num ^= this.DungeonsCompleted.GetHashCode();
			}
			bool hasPlayersKilled = this.HasPlayersKilled;
			if (hasPlayersKilled)
			{
				num ^= this.PlayersKilled.GetHashCode();
			}
			bool hasBossesKilled = this.HasBossesKilled;
			if (hasBossesKilled)
			{
				num ^= this.BossesKilled.GetHashCode();
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

		// Token: 0x06001FDD RID: 8157 RVA: 0x0007AE90 File Offset: 0x00079090
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x0007AEA8 File Offset: 0x000790A8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x0007AEB4 File Offset: 0x000790B4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasMonstersKilled = this.HasMonstersKilled;
			if (hasMonstersKilled)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(this.MonstersKilled);
			}
			bool hasElitesKilled = this.HasElitesKilled;
			if (hasElitesKilled)
			{
				output.WriteRawTag(56);
				output.WriteUInt64(this.ElitesKilled);
			}
			bool hasGoldCollected = this.HasGoldCollected;
			if (hasGoldCollected)
			{
				output.WriteRawTag(64);
				output.WriteUInt64(this.GoldCollected);
			}
			bool hasHighestHardcoreLevel = this.HasHighestHardcoreLevel;
			if (hasHighestHardcoreLevel)
			{
				output.WriteRawTag(72);
				output.WriteUInt64(this.HighestHardcoreLevel);
			}
			bool hasHardcoreMonstersKilled = this.HasHardcoreMonstersKilled;
			if (hasHardcoreMonstersKilled)
			{
				output.WriteRawTag(80);
				output.WriteUInt64(this.HardcoreMonstersKilled);
			}
			bool flag = this.classDruid_ != null;
			if (flag)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.ClassDruid);
			}
			bool flag2 = this.classSorcerer_ != null;
			if (flag2)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.ClassSorcerer);
			}
			bool flag3 = this.classBarbarian_ != null;
			if (flag3)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.ClassBarbarian);
			}
			bool flag4 = this.classRogue_ != null;
			if (flag4)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.ClassRogue);
			}
			bool flag5 = this.classNecromancer_ != null;
			if (flag5)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.ClassNecromancer);
			}
			bool hasHighestLevel = this.HasHighestLevel;
			if (hasHighestLevel)
			{
				output.WriteRawTag(248, 1);
				output.WriteUInt64(this.HighestLevel);
			}
			bool hasBloodShardsCollected = this.HasBloodShardsCollected;
			if (hasBloodShardsCollected)
			{
				output.WriteRawTag(128, 2);
				output.WriteUInt64(this.BloodShardsCollected);
			}
			this.heroes_.WriteTo(ref output, AccountProfile._repeated_heroes_codec);
			bool hasSeasonId = this.HasSeasonId;
			if (hasSeasonId)
			{
				output.WriteRawTag(152, 2);
				output.WriteUInt32(this.SeasonId);
			}
			bool hasDungeonsCompleted = this.HasDungeonsCompleted;
			if (hasDungeonsCompleted)
			{
				output.WriteRawTag(160, 2);
				output.WriteUInt64(this.DungeonsCompleted);
			}
			bool hasPlayersKilled = this.HasPlayersKilled;
			if (hasPlayersKilled)
			{
				output.WriteRawTag(168, 2);
				output.WriteUInt64(this.PlayersKilled);
			}
			bool hasBossesKilled = this.HasBossesKilled;
			if (hasBossesKilled)
			{
				output.WriteRawTag(176, 2);
				output.WriteUInt64(this.BossesKilled);
			}
			bool hasPrivacyFlag = this.HasPrivacyFlag;
			if (hasPrivacyFlag)
			{
				output.WriteRawTag(184, 2);
				output.WriteBool(this.PrivacyFlag);
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x0007B17C File Offset: 0x0007937C
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
			bool hasHighestHardcoreLevel = this.HasHighestHardcoreLevel;
			if (hasHighestHardcoreLevel)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.HighestHardcoreLevel);
			}
			bool hasHardcoreMonstersKilled = this.HasHardcoreMonstersKilled;
			if (hasHardcoreMonstersKilled)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.HardcoreMonstersKilled);
			}
			bool flag = this.classDruid_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ClassDruid);
			}
			bool flag2 = this.classSorcerer_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ClassSorcerer);
			}
			bool flag3 = this.classBarbarian_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ClassBarbarian);
			}
			bool flag4 = this.classRogue_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ClassRogue);
			}
			bool flag5 = this.classNecromancer_ != null;
			if (flag5)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ClassNecromancer);
			}
			bool hasHighestLevel = this.HasHighestLevel;
			if (hasHighestLevel)
			{
				num += 2 + CodedOutputStream.ComputeUInt64Size(this.HighestLevel);
			}
			bool hasBloodShardsCollected = this.HasBloodShardsCollected;
			if (hasBloodShardsCollected)
			{
				num += 2 + CodedOutputStream.ComputeUInt64Size(this.BloodShardsCollected);
			}
			num += this.heroes_.CalculateSize(AccountProfile._repeated_heroes_codec);
			bool hasSeasonId = this.HasSeasonId;
			if (hasSeasonId)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.SeasonId);
			}
			bool hasDungeonsCompleted = this.HasDungeonsCompleted;
			if (hasDungeonsCompleted)
			{
				num += 2 + CodedOutputStream.ComputeUInt64Size(this.DungeonsCompleted);
			}
			bool hasPlayersKilled = this.HasPlayersKilled;
			if (hasPlayersKilled)
			{
				num += 2 + CodedOutputStream.ComputeUInt64Size(this.PlayersKilled);
			}
			bool hasBossesKilled = this.HasBossesKilled;
			if (hasBossesKilled)
			{
				num += 2 + CodedOutputStream.ComputeUInt64Size(this.BossesKilled);
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

		// Token: 0x06001FE1 RID: 8161 RVA: 0x0007B3C0 File Offset: 0x000795C0
		[DebuggerNonUserCode]
		public void MergeFrom(AccountProfile other)
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
				bool hasHighestHardcoreLevel = other.HasHighestHardcoreLevel;
				if (hasHighestHardcoreLevel)
				{
					this.HighestHardcoreLevel = other.HighestHardcoreLevel;
				}
				bool hasHardcoreMonstersKilled = other.HasHardcoreMonstersKilled;
				if (hasHardcoreMonstersKilled)
				{
					this.HardcoreMonstersKilled = other.HardcoreMonstersKilled;
				}
				bool flag2 = other.classDruid_ != null;
				if (flag2)
				{
					bool flag3 = this.classDruid_ == null;
					if (flag3)
					{
						this.ClassDruid = new ClassInfo();
					}
					this.ClassDruid.MergeFrom(other.ClassDruid);
				}
				bool flag4 = other.classSorcerer_ != null;
				if (flag4)
				{
					bool flag5 = this.classSorcerer_ == null;
					if (flag5)
					{
						this.ClassSorcerer = new ClassInfo();
					}
					this.ClassSorcerer.MergeFrom(other.ClassSorcerer);
				}
				bool flag6 = other.classBarbarian_ != null;
				if (flag6)
				{
					bool flag7 = this.classBarbarian_ == null;
					if (flag7)
					{
						this.ClassBarbarian = new ClassInfo();
					}
					this.ClassBarbarian.MergeFrom(other.ClassBarbarian);
				}
				bool flag8 = other.classRogue_ != null;
				if (flag8)
				{
					bool flag9 = this.classRogue_ == null;
					if (flag9)
					{
						this.ClassRogue = new ClassInfo();
					}
					this.ClassRogue.MergeFrom(other.ClassRogue);
				}
				bool flag10 = other.classNecromancer_ != null;
				if (flag10)
				{
					bool flag11 = this.classNecromancer_ == null;
					if (flag11)
					{
						this.ClassNecromancer = new ClassInfo();
					}
					this.ClassNecromancer.MergeFrom(other.ClassNecromancer);
				}
				bool hasHighestLevel = other.HasHighestLevel;
				if (hasHighestLevel)
				{
					this.HighestLevel = other.HighestLevel;
				}
				bool hasBloodShardsCollected = other.HasBloodShardsCollected;
				if (hasBloodShardsCollected)
				{
					this.BloodShardsCollected = other.BloodShardsCollected;
				}
				this.heroes_.Add(other.heroes_);
				bool hasSeasonId = other.HasSeasonId;
				if (hasSeasonId)
				{
					this.SeasonId = other.SeasonId;
				}
				bool hasDungeonsCompleted = other.HasDungeonsCompleted;
				if (hasDungeonsCompleted)
				{
					this.DungeonsCompleted = other.DungeonsCompleted;
				}
				bool hasPlayersKilled = other.HasPlayersKilled;
				if (hasPlayersKilled)
				{
					this.PlayersKilled = other.PlayersKilled;
				}
				bool hasBossesKilled = other.HasBossesKilled;
				if (hasBossesKilled)
				{
					this.BossesKilled = other.BossesKilled;
				}
				bool hasPrivacyFlag = other.HasPrivacyFlag;
				if (hasPrivacyFlag)
				{
					this.PrivacyFlag = other.PrivacyFlag;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x0007B683 File Offset: 0x00079883
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x0007B690 File Offset: 0x00079890
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 114U)
				{
					if (num3 <= 72U)
					{
						if (num3 <= 56U)
						{
							if (num3 != 48U)
							{
								if (num3 != 56U)
								{
									goto IL_010F;
								}
								this.ElitesKilled = input.ReadUInt64();
							}
							else
							{
								this.MonstersKilled = input.ReadUInt64();
							}
						}
						else if (num3 != 64U)
						{
							if (num3 != 72U)
							{
								goto IL_010F;
							}
							this.HighestHardcoreLevel = input.ReadUInt64();
						}
						else
						{
							this.GoldCollected = input.ReadUInt64();
						}
					}
					else if (num3 <= 90U)
					{
						if (num3 != 80U)
						{
							if (num3 != 90U)
							{
								goto IL_010F;
							}
							bool flag = this.classDruid_ == null;
							if (flag)
							{
								this.ClassDruid = new ClassInfo();
							}
							input.ReadMessage(this.ClassDruid);
						}
						else
						{
							this.HardcoreMonstersKilled = input.ReadUInt64();
						}
					}
					else if (num3 != 98U)
					{
						if (num3 != 106U)
						{
							if (num3 != 114U)
							{
								goto IL_010F;
							}
							bool flag2 = this.classRogue_ == null;
							if (flag2)
							{
								this.ClassRogue = new ClassInfo();
							}
							input.ReadMessage(this.ClassRogue);
						}
						else
						{
							bool flag3 = this.classBarbarian_ == null;
							if (flag3)
							{
								this.ClassBarbarian = new ClassInfo();
							}
							input.ReadMessage(this.ClassBarbarian);
						}
					}
					else
					{
						bool flag4 = this.classSorcerer_ == null;
						if (flag4)
						{
							this.ClassSorcerer = new ClassInfo();
						}
						input.ReadMessage(this.ClassSorcerer);
					}
				}
				else if (num3 <= 274U)
				{
					if (num3 <= 248U)
					{
						if (num3 != 122U)
						{
							if (num3 != 248U)
							{
								goto IL_010F;
							}
							this.HighestLevel = input.ReadUInt64();
						}
						else
						{
							bool flag5 = this.classNecromancer_ == null;
							if (flag5)
							{
								this.ClassNecromancer = new ClassInfo();
							}
							input.ReadMessage(this.ClassNecromancer);
						}
					}
					else if (num3 != 256U)
					{
						if (num3 != 274U)
						{
							goto IL_010F;
						}
						this.heroes_.AddEntriesFrom(ref input, AccountProfile._repeated_heroes_codec);
					}
					else
					{
						this.BloodShardsCollected = input.ReadUInt64();
					}
				}
				else if (num3 <= 288U)
				{
					if (num3 != 280U)
					{
						if (num3 != 288U)
						{
							goto IL_010F;
						}
						this.DungeonsCompleted = input.ReadUInt64();
					}
					else
					{
						this.SeasonId = input.ReadUInt32();
					}
				}
				else if (num3 != 296U)
				{
					if (num3 != 304U)
					{
						if (num3 != 312U)
						{
							goto IL_010F;
						}
						this.PrivacyFlag = input.ReadBool();
					}
					else
					{
						this.BossesKilled = input.ReadUInt64();
					}
				}
				else
				{
					this.PlayersKilled = input.ReadUInt64();
				}
				continue;
				IL_010F:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000DC1 RID: 3521
		private static readonly MessageParser<AccountProfile> _parser = new MessageParser<AccountProfile>(() => new AccountProfile());

		// Token: 0x04000DC2 RID: 3522
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000DC3 RID: 3523
		private int _hasBits0;

		// Token: 0x04000DC4 RID: 3524
		public const int MonstersKilledFieldNumber = 6;

		// Token: 0x04000DC5 RID: 3525
		private static readonly ulong MonstersKilledDefaultValue = 0UL;

		// Token: 0x04000DC6 RID: 3526
		private ulong monstersKilled_;

		// Token: 0x04000DC7 RID: 3527
		public const int ElitesKilledFieldNumber = 7;

		// Token: 0x04000DC8 RID: 3528
		private static readonly ulong ElitesKilledDefaultValue = 0UL;

		// Token: 0x04000DC9 RID: 3529
		private ulong elitesKilled_;

		// Token: 0x04000DCA RID: 3530
		public const int GoldCollectedFieldNumber = 8;

		// Token: 0x04000DCB RID: 3531
		private static readonly ulong GoldCollectedDefaultValue = 0UL;

		// Token: 0x04000DCC RID: 3532
		private ulong goldCollected_;

		// Token: 0x04000DCD RID: 3533
		public const int HighestHardcoreLevelFieldNumber = 9;

		// Token: 0x04000DCE RID: 3534
		private static readonly ulong HighestHardcoreLevelDefaultValue = 0UL;

		// Token: 0x04000DCF RID: 3535
		private ulong highestHardcoreLevel_;

		// Token: 0x04000DD0 RID: 3536
		public const int HardcoreMonstersKilledFieldNumber = 10;

		// Token: 0x04000DD1 RID: 3537
		private static readonly ulong HardcoreMonstersKilledDefaultValue = 0UL;

		// Token: 0x04000DD2 RID: 3538
		private ulong hardcoreMonstersKilled_;

		// Token: 0x04000DD3 RID: 3539
		public const int ClassDruidFieldNumber = 11;

		// Token: 0x04000DD4 RID: 3540
		private ClassInfo classDruid_;

		// Token: 0x04000DD5 RID: 3541
		public const int ClassSorcererFieldNumber = 12;

		// Token: 0x04000DD6 RID: 3542
		private ClassInfo classSorcerer_;

		// Token: 0x04000DD7 RID: 3543
		public const int ClassBarbarianFieldNumber = 13;

		// Token: 0x04000DD8 RID: 3544
		private ClassInfo classBarbarian_;

		// Token: 0x04000DD9 RID: 3545
		public const int ClassRogueFieldNumber = 14;

		// Token: 0x04000DDA RID: 3546
		private ClassInfo classRogue_;

		// Token: 0x04000DDB RID: 3547
		public const int ClassNecromancerFieldNumber = 15;

		// Token: 0x04000DDC RID: 3548
		private ClassInfo classNecromancer_;

		// Token: 0x04000DDD RID: 3549
		public const int HighestLevelFieldNumber = 31;

		// Token: 0x04000DDE RID: 3550
		private static readonly ulong HighestLevelDefaultValue = 0UL;

		// Token: 0x04000DDF RID: 3551
		private ulong highestLevel_;

		// Token: 0x04000DE0 RID: 3552
		public const int BloodShardsCollectedFieldNumber = 32;

		// Token: 0x04000DE1 RID: 3553
		private static readonly ulong BloodShardsCollectedDefaultValue = 0UL;

		// Token: 0x04000DE2 RID: 3554
		private ulong bloodShardsCollected_;

		// Token: 0x04000DE3 RID: 3555
		public const int HeroesFieldNumber = 34;

		// Token: 0x04000DE4 RID: 3556
		private static readonly FieldCodec<HeroMiniProfile> _repeated_heroes_codec = FieldCodec.ForMessage<HeroMiniProfile>(274U, HeroMiniProfile.Parser);

		// Token: 0x04000DE5 RID: 3557
		private readonly RepeatedField<HeroMiniProfile> heroes_ = new RepeatedField<HeroMiniProfile>();

		// Token: 0x04000DE6 RID: 3558
		public const int SeasonIdFieldNumber = 35;

		// Token: 0x04000DE7 RID: 3559
		private static readonly uint SeasonIdDefaultValue = 0U;

		// Token: 0x04000DE8 RID: 3560
		private uint seasonId_;

		// Token: 0x04000DE9 RID: 3561
		public const int DungeonsCompletedFieldNumber = 36;

		// Token: 0x04000DEA RID: 3562
		private static readonly ulong DungeonsCompletedDefaultValue = 0UL;

		// Token: 0x04000DEB RID: 3563
		private ulong dungeonsCompleted_;

		// Token: 0x04000DEC RID: 3564
		public const int PlayersKilledFieldNumber = 37;

		// Token: 0x04000DED RID: 3565
		private static readonly ulong PlayersKilledDefaultValue = 0UL;

		// Token: 0x04000DEE RID: 3566
		private ulong playersKilled_;

		// Token: 0x04000DEF RID: 3567
		public const int BossesKilledFieldNumber = 38;

		// Token: 0x04000DF0 RID: 3568
		private static readonly ulong BossesKilledDefaultValue = 0UL;

		// Token: 0x04000DF1 RID: 3569
		private ulong bossesKilled_;

		// Token: 0x04000DF2 RID: 3570
		public const int PrivacyFlagFieldNumber = 39;

		// Token: 0x04000DF3 RID: 3571
		private static readonly bool PrivacyFlagDefaultValue = false;

		// Token: 0x04000DF4 RID: 3572
		private bool privacyFlag_;
	}
}
