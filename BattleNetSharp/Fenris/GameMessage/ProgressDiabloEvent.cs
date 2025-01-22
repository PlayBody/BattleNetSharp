using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001CF RID: 463
	public sealed class ProgressDiabloEvent : IMessage<ProgressDiabloEvent>, IMessage, IEquatable<ProgressDiabloEvent>, IDeepCloneable<ProgressDiabloEvent>, IBufferMessage
	{
		// Token: 0x17000FE3 RID: 4067
		// (get) Token: 0x0600315B RID: 12635 RVA: 0x000C3224 File Offset: 0x000C1424
		[DebuggerNonUserCode]
		public static MessageParser<ProgressDiabloEvent> Parser
		{
			get
			{
				return ProgressDiabloEvent._parser;
			}
		}

		// Token: 0x17000FE4 RID: 4068
		// (get) Token: 0x0600315C RID: 12636 RVA: 0x000C323C File Offset: 0x000C143C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[20];
			}
		}

		// Token: 0x17000FE5 RID: 4069
		// (get) Token: 0x0600315D RID: 12637 RVA: 0x000C3260 File Offset: 0x000C1460
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ProgressDiabloEvent.Descriptor;
			}
		}

		// Token: 0x0600315E RID: 12638 RVA: 0x000C3277 File Offset: 0x000C1477
		[DebuggerNonUserCode]
		public ProgressDiabloEvent()
		{
		}

		// Token: 0x0600315F RID: 12639 RVA: 0x000C32A4 File Offset: 0x000C14A4
		[DebuggerNonUserCode]
		public ProgressDiabloEvent(ProgressDiabloEvent other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.actorSno_ = other.actorSno_;
			this.levelAreaSno_ = other.levelAreaSno_;
			this.monsterCombatItemPower_ = other.monsterCombatItemPower_;
			this.playerCombatItemPower_ = other.playerCombatItemPower_;
			this.loot_ = other.loot_.Clone();
			this.experienceGained_ = other.experienceGained_;
			this.monsterRarity_ = other.monsterRarity_;
			this.playerLevel_ = other.playerLevel_;
			this.monsterLevel_ = other.monsterLevel_;
			this.playerLevelProgress_ = other.playerLevelProgress_;
			this.itemQualityCounts_ = other.itemQualityCounts_.Clone();
			this.playerLootItemPower_ = other.playerLootItemPower_;
			this.playerAttackRatingFromItems_ = other.playerAttackRatingFromItems_;
			this.playerDefenseRatingFromItems_ = other.playerDefenseRatingFromItems_;
			this.playerAttackDefenseLevelBonus_ = other.playerAttackDefenseLevelBonus_;
			this.playerAttackRatingTotal_ = other.playerAttackRatingTotal_;
			this.playerDefenseRatingTotal_ = other.playerDefenseRatingTotal_;
			this.experienceTotal_ = other.experienceTotal_;
			this.goldFromVendoredItemsTotal_ = other.goldFromVendoredItemsTotal_;
			this.goldFromLootTotal_ = other.goldFromLootTotal_;
			this.currency_ = other.currency_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003160 RID: 12640 RVA: 0x000C33E4 File Offset: 0x000C15E4
		[DebuggerNonUserCode]
		public ProgressDiabloEvent Clone()
		{
			return new ProgressDiabloEvent(this);
		}

		// Token: 0x17000FE6 RID: 4070
		// (get) Token: 0x06003161 RID: 12641 RVA: 0x000C33FC File Offset: 0x000C15FC
		// (set) Token: 0x06003162 RID: 12642 RVA: 0x000C342D File Offset: 0x000C162D
		[DebuggerNonUserCode]
		public int ActorSno
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int actorSnoDefaultValue;
				if (flag)
				{
					actorSnoDefaultValue = this.actorSno_;
				}
				else
				{
					actorSnoDefaultValue = ProgressDiabloEvent.ActorSnoDefaultValue;
				}
				return actorSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.actorSno_ = value;
			}
		}

		// Token: 0x17000FE7 RID: 4071
		// (get) Token: 0x06003163 RID: 12643 RVA: 0x000C3448 File Offset: 0x000C1648
		[DebuggerNonUserCode]
		public bool HasActorSno
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003164 RID: 12644 RVA: 0x000C3465 File Offset: 0x000C1665
		[DebuggerNonUserCode]
		public void ClearActorSno()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000FE8 RID: 4072
		// (get) Token: 0x06003165 RID: 12645 RVA: 0x000C3478 File Offset: 0x000C1678
		// (set) Token: 0x06003166 RID: 12646 RVA: 0x000C34A9 File Offset: 0x000C16A9
		[DebuggerNonUserCode]
		public int LevelAreaSno
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int levelAreaSnoDefaultValue;
				if (flag)
				{
					levelAreaSnoDefaultValue = this.levelAreaSno_;
				}
				else
				{
					levelAreaSnoDefaultValue = ProgressDiabloEvent.LevelAreaSnoDefaultValue;
				}
				return levelAreaSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.levelAreaSno_ = value;
			}
		}

		// Token: 0x17000FE9 RID: 4073
		// (get) Token: 0x06003167 RID: 12647 RVA: 0x000C34C4 File Offset: 0x000C16C4
		[DebuggerNonUserCode]
		public bool HasLevelAreaSno
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003168 RID: 12648 RVA: 0x000C34E1 File Offset: 0x000C16E1
		[DebuggerNonUserCode]
		public void ClearLevelAreaSno()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000FEA RID: 4074
		// (get) Token: 0x06003169 RID: 12649 RVA: 0x000C34F4 File Offset: 0x000C16F4
		// (set) Token: 0x0600316A RID: 12650 RVA: 0x000C3525 File Offset: 0x000C1725
		[DebuggerNonUserCode]
		public int MonsterCombatItemPower
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int monsterCombatItemPowerDefaultValue;
				if (flag)
				{
					monsterCombatItemPowerDefaultValue = this.monsterCombatItemPower_;
				}
				else
				{
					monsterCombatItemPowerDefaultValue = ProgressDiabloEvent.MonsterCombatItemPowerDefaultValue;
				}
				return monsterCombatItemPowerDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.monsterCombatItemPower_ = value;
			}
		}

		// Token: 0x17000FEB RID: 4075
		// (get) Token: 0x0600316B RID: 12651 RVA: 0x000C3540 File Offset: 0x000C1740
		[DebuggerNonUserCode]
		public bool HasMonsterCombatItemPower
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600316C RID: 12652 RVA: 0x000C355D File Offset: 0x000C175D
		[DebuggerNonUserCode]
		public void ClearMonsterCombatItemPower()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000FEC RID: 4076
		// (get) Token: 0x0600316D RID: 12653 RVA: 0x000C3570 File Offset: 0x000C1770
		// (set) Token: 0x0600316E RID: 12654 RVA: 0x000C35A1 File Offset: 0x000C17A1
		[DebuggerNonUserCode]
		public int PlayerCombatItemPower
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int playerCombatItemPowerDefaultValue;
				if (flag)
				{
					playerCombatItemPowerDefaultValue = this.playerCombatItemPower_;
				}
				else
				{
					playerCombatItemPowerDefaultValue = ProgressDiabloEvent.PlayerCombatItemPowerDefaultValue;
				}
				return playerCombatItemPowerDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.playerCombatItemPower_ = value;
			}
		}

		// Token: 0x17000FED RID: 4077
		// (get) Token: 0x0600316F RID: 12655 RVA: 0x000C35BC File Offset: 0x000C17BC
		[DebuggerNonUserCode]
		public bool HasPlayerCombatItemPower
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06003170 RID: 12656 RVA: 0x000C35D9 File Offset: 0x000C17D9
		[DebuggerNonUserCode]
		public void ClearPlayerCombatItemPower()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000FEE RID: 4078
		// (get) Token: 0x06003171 RID: 12657 RVA: 0x000C35EC File Offset: 0x000C17EC
		[DebuggerNonUserCode]
		public RepeatedField<ProgressDiabloEventLoot> Loot
		{
			get
			{
				return this.loot_;
			}
		}

		// Token: 0x17000FEF RID: 4079
		// (get) Token: 0x06003172 RID: 12658 RVA: 0x000C3604 File Offset: 0x000C1804
		// (set) Token: 0x06003173 RID: 12659 RVA: 0x000C3636 File Offset: 0x000C1836
		[DebuggerNonUserCode]
		public uint ExperienceGained
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint experienceGainedDefaultValue;
				if (flag)
				{
					experienceGainedDefaultValue = this.experienceGained_;
				}
				else
				{
					experienceGainedDefaultValue = ProgressDiabloEvent.ExperienceGainedDefaultValue;
				}
				return experienceGainedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.experienceGained_ = value;
			}
		}

		// Token: 0x17000FF0 RID: 4080
		// (get) Token: 0x06003174 RID: 12660 RVA: 0x000C3650 File Offset: 0x000C1850
		[DebuggerNonUserCode]
		public bool HasExperienceGained
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06003175 RID: 12661 RVA: 0x000C366E File Offset: 0x000C186E
		[DebuggerNonUserCode]
		public void ClearExperienceGained()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17000FF1 RID: 4081
		// (get) Token: 0x06003176 RID: 12662 RVA: 0x000C3680 File Offset: 0x000C1880
		// (set) Token: 0x06003177 RID: 12663 RVA: 0x000C36B2 File Offset: 0x000C18B2
		[DebuggerNonUserCode]
		public int MonsterRarity
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				int monsterRarityDefaultValue;
				if (flag)
				{
					monsterRarityDefaultValue = this.monsterRarity_;
				}
				else
				{
					monsterRarityDefaultValue = ProgressDiabloEvent.MonsterRarityDefaultValue;
				}
				return monsterRarityDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.monsterRarity_ = value;
			}
		}

		// Token: 0x17000FF2 RID: 4082
		// (get) Token: 0x06003178 RID: 12664 RVA: 0x000C36CC File Offset: 0x000C18CC
		[DebuggerNonUserCode]
		public bool HasMonsterRarity
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06003179 RID: 12665 RVA: 0x000C36EA File Offset: 0x000C18EA
		[DebuggerNonUserCode]
		public void ClearMonsterRarity()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17000FF3 RID: 4083
		// (get) Token: 0x0600317A RID: 12666 RVA: 0x000C36FC File Offset: 0x000C18FC
		// (set) Token: 0x0600317B RID: 12667 RVA: 0x000C372E File Offset: 0x000C192E
		[DebuggerNonUserCode]
		public int PlayerLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				int playerLevelDefaultValue;
				if (flag)
				{
					playerLevelDefaultValue = this.playerLevel_;
				}
				else
				{
					playerLevelDefaultValue = ProgressDiabloEvent.PlayerLevelDefaultValue;
				}
				return playerLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.playerLevel_ = value;
			}
		}

		// Token: 0x17000FF4 RID: 4084
		// (get) Token: 0x0600317C RID: 12668 RVA: 0x000C3748 File Offset: 0x000C1948
		[DebuggerNonUserCode]
		public bool HasPlayerLevel
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x0600317D RID: 12669 RVA: 0x000C3766 File Offset: 0x000C1966
		[DebuggerNonUserCode]
		public void ClearPlayerLevel()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x0600317E RID: 12670 RVA: 0x000C3778 File Offset: 0x000C1978
		// (set) Token: 0x0600317F RID: 12671 RVA: 0x000C37AD File Offset: 0x000C19AD
		[DebuggerNonUserCode]
		public int MonsterLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				int monsterLevelDefaultValue;
				if (flag)
				{
					monsterLevelDefaultValue = this.monsterLevel_;
				}
				else
				{
					monsterLevelDefaultValue = ProgressDiabloEvent.MonsterLevelDefaultValue;
				}
				return monsterLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.monsterLevel_ = value;
			}
		}

		// Token: 0x17000FF6 RID: 4086
		// (get) Token: 0x06003180 RID: 12672 RVA: 0x000C37CC File Offset: 0x000C19CC
		[DebuggerNonUserCode]
		public bool HasMonsterLevel
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x06003181 RID: 12673 RVA: 0x000C37ED File Offset: 0x000C19ED
		[DebuggerNonUserCode]
		public void ClearMonsterLevel()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x06003182 RID: 12674 RVA: 0x000C3804 File Offset: 0x000C1A04
		// (set) Token: 0x06003183 RID: 12675 RVA: 0x000C3839 File Offset: 0x000C1A39
		[DebuggerNonUserCode]
		public float PlayerLevelProgress
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				float playerLevelProgressDefaultValue;
				if (flag)
				{
					playerLevelProgressDefaultValue = this.playerLevelProgress_;
				}
				else
				{
					playerLevelProgressDefaultValue = ProgressDiabloEvent.PlayerLevelProgressDefaultValue;
				}
				return playerLevelProgressDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.playerLevelProgress_ = value;
			}
		}

		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x06003184 RID: 12676 RVA: 0x000C3858 File Offset: 0x000C1A58
		[DebuggerNonUserCode]
		public bool HasPlayerLevelProgress
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x06003185 RID: 12677 RVA: 0x000C3879 File Offset: 0x000C1A79
		[DebuggerNonUserCode]
		public void ClearPlayerLevelProgress()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x06003186 RID: 12678 RVA: 0x000C3890 File Offset: 0x000C1A90
		[DebuggerNonUserCode]
		public RepeatedField<int> ItemQualityCounts
		{
			get
			{
				return this.itemQualityCounts_;
			}
		}

		// Token: 0x17000FFA RID: 4090
		// (get) Token: 0x06003187 RID: 12679 RVA: 0x000C38A8 File Offset: 0x000C1AA8
		// (set) Token: 0x06003188 RID: 12680 RVA: 0x000C38DD File Offset: 0x000C1ADD
		[DebuggerNonUserCode]
		public int PlayerLootItemPower
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				int playerLootItemPowerDefaultValue;
				if (flag)
				{
					playerLootItemPowerDefaultValue = this.playerLootItemPower_;
				}
				else
				{
					playerLootItemPowerDefaultValue = ProgressDiabloEvent.PlayerLootItemPowerDefaultValue;
				}
				return playerLootItemPowerDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.playerLootItemPower_ = value;
			}
		}

		// Token: 0x17000FFB RID: 4091
		// (get) Token: 0x06003189 RID: 12681 RVA: 0x000C38FC File Offset: 0x000C1AFC
		[DebuggerNonUserCode]
		public bool HasPlayerLootItemPower
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x0600318A RID: 12682 RVA: 0x000C391D File Offset: 0x000C1B1D
		[DebuggerNonUserCode]
		public void ClearPlayerLootItemPower()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x17000FFC RID: 4092
		// (get) Token: 0x0600318B RID: 12683 RVA: 0x000C3934 File Offset: 0x000C1B34
		// (set) Token: 0x0600318C RID: 12684 RVA: 0x000C3969 File Offset: 0x000C1B69
		[DebuggerNonUserCode]
		public int PlayerAttackRatingFromItems
		{
			get
			{
				bool flag = (this._hasBits0 & 1024) != 0;
				int playerAttackRatingFromItemsDefaultValue;
				if (flag)
				{
					playerAttackRatingFromItemsDefaultValue = this.playerAttackRatingFromItems_;
				}
				else
				{
					playerAttackRatingFromItemsDefaultValue = ProgressDiabloEvent.PlayerAttackRatingFromItemsDefaultValue;
				}
				return playerAttackRatingFromItemsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1024;
				this.playerAttackRatingFromItems_ = value;
			}
		}

		// Token: 0x17000FFD RID: 4093
		// (get) Token: 0x0600318D RID: 12685 RVA: 0x000C3988 File Offset: 0x000C1B88
		[DebuggerNonUserCode]
		public bool HasPlayerAttackRatingFromItems
		{
			get
			{
				return (this._hasBits0 & 1024) != 0;
			}
		}

		// Token: 0x0600318E RID: 12686 RVA: 0x000C39A9 File Offset: 0x000C1BA9
		[DebuggerNonUserCode]
		public void ClearPlayerAttackRatingFromItems()
		{
			this._hasBits0 &= -1025;
		}

		// Token: 0x17000FFE RID: 4094
		// (get) Token: 0x0600318F RID: 12687 RVA: 0x000C39C0 File Offset: 0x000C1BC0
		// (set) Token: 0x06003190 RID: 12688 RVA: 0x000C39F5 File Offset: 0x000C1BF5
		[DebuggerNonUserCode]
		public int PlayerDefenseRatingFromItems
		{
			get
			{
				bool flag = (this._hasBits0 & 2048) != 0;
				int playerDefenseRatingFromItemsDefaultValue;
				if (flag)
				{
					playerDefenseRatingFromItemsDefaultValue = this.playerDefenseRatingFromItems_;
				}
				else
				{
					playerDefenseRatingFromItemsDefaultValue = ProgressDiabloEvent.PlayerDefenseRatingFromItemsDefaultValue;
				}
				return playerDefenseRatingFromItemsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2048;
				this.playerDefenseRatingFromItems_ = value;
			}
		}

		// Token: 0x17000FFF RID: 4095
		// (get) Token: 0x06003191 RID: 12689 RVA: 0x000C3A14 File Offset: 0x000C1C14
		[DebuggerNonUserCode]
		public bool HasPlayerDefenseRatingFromItems
		{
			get
			{
				return (this._hasBits0 & 2048) != 0;
			}
		}

		// Token: 0x06003192 RID: 12690 RVA: 0x000C3A35 File Offset: 0x000C1C35
		[DebuggerNonUserCode]
		public void ClearPlayerDefenseRatingFromItems()
		{
			this._hasBits0 &= -2049;
		}

		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x06003193 RID: 12691 RVA: 0x000C3A4C File Offset: 0x000C1C4C
		// (set) Token: 0x06003194 RID: 12692 RVA: 0x000C3A81 File Offset: 0x000C1C81
		[DebuggerNonUserCode]
		public int PlayerAttackDefenseLevelBonus
		{
			get
			{
				bool flag = (this._hasBits0 & 4096) != 0;
				int playerAttackDefenseLevelBonusDefaultValue;
				if (flag)
				{
					playerAttackDefenseLevelBonusDefaultValue = this.playerAttackDefenseLevelBonus_;
				}
				else
				{
					playerAttackDefenseLevelBonusDefaultValue = ProgressDiabloEvent.PlayerAttackDefenseLevelBonusDefaultValue;
				}
				return playerAttackDefenseLevelBonusDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4096;
				this.playerAttackDefenseLevelBonus_ = value;
			}
		}

		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x06003195 RID: 12693 RVA: 0x000C3AA0 File Offset: 0x000C1CA0
		[DebuggerNonUserCode]
		public bool HasPlayerAttackDefenseLevelBonus
		{
			get
			{
				return (this._hasBits0 & 4096) != 0;
			}
		}

		// Token: 0x06003196 RID: 12694 RVA: 0x000C3AC1 File Offset: 0x000C1CC1
		[DebuggerNonUserCode]
		public void ClearPlayerAttackDefenseLevelBonus()
		{
			this._hasBits0 &= -4097;
		}

		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x06003197 RID: 12695 RVA: 0x000C3AD8 File Offset: 0x000C1CD8
		// (set) Token: 0x06003198 RID: 12696 RVA: 0x000C3B0D File Offset: 0x000C1D0D
		[DebuggerNonUserCode]
		public int PlayerAttackRatingTotal
		{
			get
			{
				bool flag = (this._hasBits0 & 8192) != 0;
				int playerAttackRatingTotalDefaultValue;
				if (flag)
				{
					playerAttackRatingTotalDefaultValue = this.playerAttackRatingTotal_;
				}
				else
				{
					playerAttackRatingTotalDefaultValue = ProgressDiabloEvent.PlayerAttackRatingTotalDefaultValue;
				}
				return playerAttackRatingTotalDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8192;
				this.playerAttackRatingTotal_ = value;
			}
		}

		// Token: 0x17001003 RID: 4099
		// (get) Token: 0x06003199 RID: 12697 RVA: 0x000C3B2C File Offset: 0x000C1D2C
		[DebuggerNonUserCode]
		public bool HasPlayerAttackRatingTotal
		{
			get
			{
				return (this._hasBits0 & 8192) != 0;
			}
		}

		// Token: 0x0600319A RID: 12698 RVA: 0x000C3B4D File Offset: 0x000C1D4D
		[DebuggerNonUserCode]
		public void ClearPlayerAttackRatingTotal()
		{
			this._hasBits0 &= -8193;
		}

		// Token: 0x17001004 RID: 4100
		// (get) Token: 0x0600319B RID: 12699 RVA: 0x000C3B64 File Offset: 0x000C1D64
		// (set) Token: 0x0600319C RID: 12700 RVA: 0x000C3B99 File Offset: 0x000C1D99
		[DebuggerNonUserCode]
		public int PlayerDefenseRatingTotal
		{
			get
			{
				bool flag = (this._hasBits0 & 16384) != 0;
				int playerDefenseRatingTotalDefaultValue;
				if (flag)
				{
					playerDefenseRatingTotalDefaultValue = this.playerDefenseRatingTotal_;
				}
				else
				{
					playerDefenseRatingTotalDefaultValue = ProgressDiabloEvent.PlayerDefenseRatingTotalDefaultValue;
				}
				return playerDefenseRatingTotalDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16384;
				this.playerDefenseRatingTotal_ = value;
			}
		}

		// Token: 0x17001005 RID: 4101
		// (get) Token: 0x0600319D RID: 12701 RVA: 0x000C3BB8 File Offset: 0x000C1DB8
		[DebuggerNonUserCode]
		public bool HasPlayerDefenseRatingTotal
		{
			get
			{
				return (this._hasBits0 & 16384) != 0;
			}
		}

		// Token: 0x0600319E RID: 12702 RVA: 0x000C3BD9 File Offset: 0x000C1DD9
		[DebuggerNonUserCode]
		public void ClearPlayerDefenseRatingTotal()
		{
			this._hasBits0 &= -16385;
		}

		// Token: 0x17001006 RID: 4102
		// (get) Token: 0x0600319F RID: 12703 RVA: 0x000C3BF0 File Offset: 0x000C1DF0
		// (set) Token: 0x060031A0 RID: 12704 RVA: 0x000C3C25 File Offset: 0x000C1E25
		[DebuggerNonUserCode]
		public ulong ExperienceTotal
		{
			get
			{
				bool flag = (this._hasBits0 & 32768) != 0;
				ulong experienceTotalDefaultValue;
				if (flag)
				{
					experienceTotalDefaultValue = this.experienceTotal_;
				}
				else
				{
					experienceTotalDefaultValue = ProgressDiabloEvent.ExperienceTotalDefaultValue;
				}
				return experienceTotalDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32768;
				this.experienceTotal_ = value;
			}
		}

		// Token: 0x17001007 RID: 4103
		// (get) Token: 0x060031A1 RID: 12705 RVA: 0x000C3C44 File Offset: 0x000C1E44
		[DebuggerNonUserCode]
		public bool HasExperienceTotal
		{
			get
			{
				return (this._hasBits0 & 32768) != 0;
			}
		}

		// Token: 0x060031A2 RID: 12706 RVA: 0x000C3C65 File Offset: 0x000C1E65
		[DebuggerNonUserCode]
		public void ClearExperienceTotal()
		{
			this._hasBits0 &= -32769;
		}

		// Token: 0x17001008 RID: 4104
		// (get) Token: 0x060031A3 RID: 12707 RVA: 0x000C3C7C File Offset: 0x000C1E7C
		// (set) Token: 0x060031A4 RID: 12708 RVA: 0x000C3CB1 File Offset: 0x000C1EB1
		[DebuggerNonUserCode]
		public ulong GoldFromVendoredItemsTotal
		{
			get
			{
				bool flag = (this._hasBits0 & 65536) != 0;
				ulong goldFromVendoredItemsTotalDefaultValue;
				if (flag)
				{
					goldFromVendoredItemsTotalDefaultValue = this.goldFromVendoredItemsTotal_;
				}
				else
				{
					goldFromVendoredItemsTotalDefaultValue = ProgressDiabloEvent.GoldFromVendoredItemsTotalDefaultValue;
				}
				return goldFromVendoredItemsTotalDefaultValue;
			}
			set
			{
				this._hasBits0 |= 65536;
				this.goldFromVendoredItemsTotal_ = value;
			}
		}

		// Token: 0x17001009 RID: 4105
		// (get) Token: 0x060031A5 RID: 12709 RVA: 0x000C3CD0 File Offset: 0x000C1ED0
		[DebuggerNonUserCode]
		public bool HasGoldFromVendoredItemsTotal
		{
			get
			{
				return (this._hasBits0 & 65536) != 0;
			}
		}

		// Token: 0x060031A6 RID: 12710 RVA: 0x000C3CF1 File Offset: 0x000C1EF1
		[DebuggerNonUserCode]
		public void ClearGoldFromVendoredItemsTotal()
		{
			this._hasBits0 &= -65537;
		}

		// Token: 0x1700100A RID: 4106
		// (get) Token: 0x060031A7 RID: 12711 RVA: 0x000C3D08 File Offset: 0x000C1F08
		// (set) Token: 0x060031A8 RID: 12712 RVA: 0x000C3D3D File Offset: 0x000C1F3D
		[DebuggerNonUserCode]
		public ulong GoldFromLootTotal
		{
			get
			{
				bool flag = (this._hasBits0 & 131072) != 0;
				ulong goldFromLootTotalDefaultValue;
				if (flag)
				{
					goldFromLootTotalDefaultValue = this.goldFromLootTotal_;
				}
				else
				{
					goldFromLootTotalDefaultValue = ProgressDiabloEvent.GoldFromLootTotalDefaultValue;
				}
				return goldFromLootTotalDefaultValue;
			}
			set
			{
				this._hasBits0 |= 131072;
				this.goldFromLootTotal_ = value;
			}
		}

		// Token: 0x1700100B RID: 4107
		// (get) Token: 0x060031A9 RID: 12713 RVA: 0x000C3D5C File Offset: 0x000C1F5C
		[DebuggerNonUserCode]
		public bool HasGoldFromLootTotal
		{
			get
			{
				return (this._hasBits0 & 131072) != 0;
			}
		}

		// Token: 0x060031AA RID: 12714 RVA: 0x000C3D7D File Offset: 0x000C1F7D
		[DebuggerNonUserCode]
		public void ClearGoldFromLootTotal()
		{
			this._hasBits0 &= -131073;
		}

		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x060031AB RID: 12715 RVA: 0x000C3D94 File Offset: 0x000C1F94
		[DebuggerNonUserCode]
		public RepeatedField<ProgressDiabloEventCurrency> Currency
		{
			get
			{
				return this.currency_;
			}
		}

		// Token: 0x060031AC RID: 12716 RVA: 0x000C3DAC File Offset: 0x000C1FAC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ProgressDiabloEvent);
		}

		// Token: 0x060031AD RID: 12717 RVA: 0x000C3DCC File Offset: 0x000C1FCC
		[DebuggerNonUserCode]
		public bool Equals(ProgressDiabloEvent other)
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
					bool flag4 = this.ActorSno != other.ActorSno;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.LevelAreaSno != other.LevelAreaSno;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.MonsterCombatItemPower != other.MonsterCombatItemPower;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.PlayerCombatItemPower != other.PlayerCombatItemPower;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.loot_.Equals(other.loot_);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.ExperienceGained != other.ExperienceGained;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.MonsterRarity != other.MonsterRarity;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.PlayerLevel != other.PlayerLevel;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.MonsterLevel != other.MonsterLevel;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PlayerLevelProgress, other.PlayerLevelProgress);
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = !this.itemQualityCounts_.Equals(other.itemQualityCounts_);
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.PlayerLootItemPower != other.PlayerLootItemPower;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = this.PlayerAttackRatingFromItems != other.PlayerAttackRatingFromItems;
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = this.PlayerDefenseRatingFromItems != other.PlayerDefenseRatingFromItems;
																		if (flag17)
																		{
																			flag2 = false;
																		}
																		else
																		{
																			bool flag18 = this.PlayerAttackDefenseLevelBonus != other.PlayerAttackDefenseLevelBonus;
																			if (flag18)
																			{
																				flag2 = false;
																			}
																			else
																			{
																				bool flag19 = this.PlayerAttackRatingTotal != other.PlayerAttackRatingTotal;
																				if (flag19)
																				{
																					flag2 = false;
																				}
																				else
																				{
																					bool flag20 = this.PlayerDefenseRatingTotal != other.PlayerDefenseRatingTotal;
																					if (flag20)
																					{
																						flag2 = false;
																					}
																					else
																					{
																						bool flag21 = this.ExperienceTotal != other.ExperienceTotal;
																						if (flag21)
																						{
																							flag2 = false;
																						}
																						else
																						{
																							bool flag22 = this.GoldFromVendoredItemsTotal != other.GoldFromVendoredItemsTotal;
																							if (flag22)
																							{
																								flag2 = false;
																							}
																							else
																							{
																								bool flag23 = this.GoldFromLootTotal != other.GoldFromLootTotal;
																								if (flag23)
																								{
																									flag2 = false;
																								}
																								else
																								{
																									bool flag24 = !this.currency_.Equals(other.currency_);
																									flag2 = !flag24 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x060031AE RID: 12718 RVA: 0x000C4088 File Offset: 0x000C2288
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasActorSno = this.HasActorSno;
			if (hasActorSno)
			{
				num ^= this.ActorSno.GetHashCode();
			}
			bool hasLevelAreaSno = this.HasLevelAreaSno;
			if (hasLevelAreaSno)
			{
				num ^= this.LevelAreaSno.GetHashCode();
			}
			bool hasMonsterCombatItemPower = this.HasMonsterCombatItemPower;
			if (hasMonsterCombatItemPower)
			{
				num ^= this.MonsterCombatItemPower.GetHashCode();
			}
			bool hasPlayerCombatItemPower = this.HasPlayerCombatItemPower;
			if (hasPlayerCombatItemPower)
			{
				num ^= this.PlayerCombatItemPower.GetHashCode();
			}
			num ^= this.loot_.GetHashCode();
			bool hasExperienceGained = this.HasExperienceGained;
			if (hasExperienceGained)
			{
				num ^= this.ExperienceGained.GetHashCode();
			}
			bool hasMonsterRarity = this.HasMonsterRarity;
			if (hasMonsterRarity)
			{
				num ^= this.MonsterRarity.GetHashCode();
			}
			bool hasPlayerLevel = this.HasPlayerLevel;
			if (hasPlayerLevel)
			{
				num ^= this.PlayerLevel.GetHashCode();
			}
			bool hasMonsterLevel = this.HasMonsterLevel;
			if (hasMonsterLevel)
			{
				num ^= this.MonsterLevel.GetHashCode();
			}
			bool hasPlayerLevelProgress = this.HasPlayerLevelProgress;
			if (hasPlayerLevelProgress)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.PlayerLevelProgress);
			}
			num ^= this.itemQualityCounts_.GetHashCode();
			bool hasPlayerLootItemPower = this.HasPlayerLootItemPower;
			if (hasPlayerLootItemPower)
			{
				num ^= this.PlayerLootItemPower.GetHashCode();
			}
			bool hasPlayerAttackRatingFromItems = this.HasPlayerAttackRatingFromItems;
			if (hasPlayerAttackRatingFromItems)
			{
				num ^= this.PlayerAttackRatingFromItems.GetHashCode();
			}
			bool hasPlayerDefenseRatingFromItems = this.HasPlayerDefenseRatingFromItems;
			if (hasPlayerDefenseRatingFromItems)
			{
				num ^= this.PlayerDefenseRatingFromItems.GetHashCode();
			}
			bool hasPlayerAttackDefenseLevelBonus = this.HasPlayerAttackDefenseLevelBonus;
			if (hasPlayerAttackDefenseLevelBonus)
			{
				num ^= this.PlayerAttackDefenseLevelBonus.GetHashCode();
			}
			bool hasPlayerAttackRatingTotal = this.HasPlayerAttackRatingTotal;
			if (hasPlayerAttackRatingTotal)
			{
				num ^= this.PlayerAttackRatingTotal.GetHashCode();
			}
			bool hasPlayerDefenseRatingTotal = this.HasPlayerDefenseRatingTotal;
			if (hasPlayerDefenseRatingTotal)
			{
				num ^= this.PlayerDefenseRatingTotal.GetHashCode();
			}
			bool hasExperienceTotal = this.HasExperienceTotal;
			if (hasExperienceTotal)
			{
				num ^= this.ExperienceTotal.GetHashCode();
			}
			bool hasGoldFromVendoredItemsTotal = this.HasGoldFromVendoredItemsTotal;
			if (hasGoldFromVendoredItemsTotal)
			{
				num ^= this.GoldFromVendoredItemsTotal.GetHashCode();
			}
			bool hasGoldFromLootTotal = this.HasGoldFromLootTotal;
			if (hasGoldFromLootTotal)
			{
				num ^= this.GoldFromLootTotal.GetHashCode();
			}
			num ^= this.currency_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060031AF RID: 12719 RVA: 0x000C42F4 File Offset: 0x000C24F4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060031B0 RID: 12720 RVA: 0x000C430C File Offset: 0x000C250C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060031B1 RID: 12721 RVA: 0x000C4318 File Offset: 0x000C2518
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasActorSno = this.HasActorSno;
			if (hasActorSno)
			{
				output.WriteRawTag(21);
				output.WriteSFixed32(this.ActorSno);
			}
			bool hasLevelAreaSno = this.HasLevelAreaSno;
			if (hasLevelAreaSno)
			{
				output.WriteRawTag(29);
				output.WriteSFixed32(this.LevelAreaSno);
			}
			bool hasMonsterCombatItemPower = this.HasMonsterCombatItemPower;
			if (hasMonsterCombatItemPower)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.MonsterCombatItemPower);
			}
			bool hasPlayerCombatItemPower = this.HasPlayerCombatItemPower;
			if (hasPlayerCombatItemPower)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.PlayerCombatItemPower);
			}
			this.loot_.WriteTo(ref output, ProgressDiabloEvent._repeated_loot_codec);
			bool hasExperienceGained = this.HasExperienceGained;
			if (hasExperienceGained)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.ExperienceGained);
			}
			bool hasMonsterRarity = this.HasMonsterRarity;
			if (hasMonsterRarity)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.MonsterRarity);
			}
			bool hasPlayerLevel = this.HasPlayerLevel;
			if (hasPlayerLevel)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.PlayerLevel);
			}
			bool hasMonsterLevel = this.HasMonsterLevel;
			if (hasMonsterLevel)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.MonsterLevel);
			}
			bool hasPlayerLevelProgress = this.HasPlayerLevelProgress;
			if (hasPlayerLevelProgress)
			{
				output.WriteRawTag(93);
				output.WriteFloat(this.PlayerLevelProgress);
			}
			this.itemQualityCounts_.WriteTo(ref output, ProgressDiabloEvent._repeated_itemQualityCounts_codec);
			bool hasPlayerLootItemPower = this.HasPlayerLootItemPower;
			if (hasPlayerLootItemPower)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.PlayerLootItemPower);
			}
			bool hasPlayerAttackRatingFromItems = this.HasPlayerAttackRatingFromItems;
			if (hasPlayerAttackRatingFromItems)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.PlayerAttackRatingFromItems);
			}
			bool hasPlayerDefenseRatingFromItems = this.HasPlayerDefenseRatingFromItems;
			if (hasPlayerDefenseRatingFromItems)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.PlayerDefenseRatingFromItems);
			}
			bool hasPlayerAttackDefenseLevelBonus = this.HasPlayerAttackDefenseLevelBonus;
			if (hasPlayerAttackDefenseLevelBonus)
			{
				output.WriteRawTag(128, 1);
				output.WriteInt32(this.PlayerAttackDefenseLevelBonus);
			}
			bool hasPlayerAttackRatingTotal = this.HasPlayerAttackRatingTotal;
			if (hasPlayerAttackRatingTotal)
			{
				output.WriteRawTag(136, 1);
				output.WriteInt32(this.PlayerAttackRatingTotal);
			}
			bool hasPlayerDefenseRatingTotal = this.HasPlayerDefenseRatingTotal;
			if (hasPlayerDefenseRatingTotal)
			{
				output.WriteRawTag(144, 1);
				output.WriteInt32(this.PlayerDefenseRatingTotal);
			}
			bool hasExperienceTotal = this.HasExperienceTotal;
			if (hasExperienceTotal)
			{
				output.WriteRawTag(152, 1);
				output.WriteUInt64(this.ExperienceTotal);
			}
			bool hasGoldFromVendoredItemsTotal = this.HasGoldFromVendoredItemsTotal;
			if (hasGoldFromVendoredItemsTotal)
			{
				output.WriteRawTag(160, 1);
				output.WriteUInt64(this.GoldFromVendoredItemsTotal);
			}
			bool hasGoldFromLootTotal = this.HasGoldFromLootTotal;
			if (hasGoldFromLootTotal)
			{
				output.WriteRawTag(168, 1);
				output.WriteUInt64(this.GoldFromLootTotal);
			}
			this.currency_.WriteTo(ref output, ProgressDiabloEvent._repeated_currency_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060031B2 RID: 12722 RVA: 0x000C4614 File Offset: 0x000C2814
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasActorSno = this.HasActorSno;
			if (hasActorSno)
			{
				num += 5;
			}
			bool hasLevelAreaSno = this.HasLevelAreaSno;
			if (hasLevelAreaSno)
			{
				num += 5;
			}
			bool hasMonsterCombatItemPower = this.HasMonsterCombatItemPower;
			if (hasMonsterCombatItemPower)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MonsterCombatItemPower);
			}
			bool hasPlayerCombatItemPower = this.HasPlayerCombatItemPower;
			if (hasPlayerCombatItemPower)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerCombatItemPower);
			}
			num += this.loot_.CalculateSize(ProgressDiabloEvent._repeated_loot_codec);
			bool hasExperienceGained = this.HasExperienceGained;
			if (hasExperienceGained)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ExperienceGained);
			}
			bool hasMonsterRarity = this.HasMonsterRarity;
			if (hasMonsterRarity)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MonsterRarity);
			}
			bool hasPlayerLevel = this.HasPlayerLevel;
			if (hasPlayerLevel)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerLevel);
			}
			bool hasMonsterLevel = this.HasMonsterLevel;
			if (hasMonsterLevel)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MonsterLevel);
			}
			bool hasPlayerLevelProgress = this.HasPlayerLevelProgress;
			if (hasPlayerLevelProgress)
			{
				num += 5;
			}
			num += this.itemQualityCounts_.CalculateSize(ProgressDiabloEvent._repeated_itemQualityCounts_codec);
			bool hasPlayerLootItemPower = this.HasPlayerLootItemPower;
			if (hasPlayerLootItemPower)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerLootItemPower);
			}
			bool hasPlayerAttackRatingFromItems = this.HasPlayerAttackRatingFromItems;
			if (hasPlayerAttackRatingFromItems)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerAttackRatingFromItems);
			}
			bool hasPlayerDefenseRatingFromItems = this.HasPlayerDefenseRatingFromItems;
			if (hasPlayerDefenseRatingFromItems)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerDefenseRatingFromItems);
			}
			bool hasPlayerAttackDefenseLevelBonus = this.HasPlayerAttackDefenseLevelBonus;
			if (hasPlayerAttackDefenseLevelBonus)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.PlayerAttackDefenseLevelBonus);
			}
			bool hasPlayerAttackRatingTotal = this.HasPlayerAttackRatingTotal;
			if (hasPlayerAttackRatingTotal)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.PlayerAttackRatingTotal);
			}
			bool hasPlayerDefenseRatingTotal = this.HasPlayerDefenseRatingTotal;
			if (hasPlayerDefenseRatingTotal)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.PlayerDefenseRatingTotal);
			}
			bool hasExperienceTotal = this.HasExperienceTotal;
			if (hasExperienceTotal)
			{
				num += 2 + CodedOutputStream.ComputeUInt64Size(this.ExperienceTotal);
			}
			bool hasGoldFromVendoredItemsTotal = this.HasGoldFromVendoredItemsTotal;
			if (hasGoldFromVendoredItemsTotal)
			{
				num += 2 + CodedOutputStream.ComputeUInt64Size(this.GoldFromVendoredItemsTotal);
			}
			bool hasGoldFromLootTotal = this.HasGoldFromLootTotal;
			if (hasGoldFromLootTotal)
			{
				num += 2 + CodedOutputStream.ComputeUInt64Size(this.GoldFromLootTotal);
			}
			num += this.currency_.CalculateSize(ProgressDiabloEvent._repeated_currency_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060031B3 RID: 12723 RVA: 0x000C4878 File Offset: 0x000C2A78
		[DebuggerNonUserCode]
		public void MergeFrom(ProgressDiabloEvent other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasActorSno = other.HasActorSno;
				if (hasActorSno)
				{
					this.ActorSno = other.ActorSno;
				}
				bool hasLevelAreaSno = other.HasLevelAreaSno;
				if (hasLevelAreaSno)
				{
					this.LevelAreaSno = other.LevelAreaSno;
				}
				bool hasMonsterCombatItemPower = other.HasMonsterCombatItemPower;
				if (hasMonsterCombatItemPower)
				{
					this.MonsterCombatItemPower = other.MonsterCombatItemPower;
				}
				bool hasPlayerCombatItemPower = other.HasPlayerCombatItemPower;
				if (hasPlayerCombatItemPower)
				{
					this.PlayerCombatItemPower = other.PlayerCombatItemPower;
				}
				this.loot_.Add(other.loot_);
				bool hasExperienceGained = other.HasExperienceGained;
				if (hasExperienceGained)
				{
					this.ExperienceGained = other.ExperienceGained;
				}
				bool hasMonsterRarity = other.HasMonsterRarity;
				if (hasMonsterRarity)
				{
					this.MonsterRarity = other.MonsterRarity;
				}
				bool hasPlayerLevel = other.HasPlayerLevel;
				if (hasPlayerLevel)
				{
					this.PlayerLevel = other.PlayerLevel;
				}
				bool hasMonsterLevel = other.HasMonsterLevel;
				if (hasMonsterLevel)
				{
					this.MonsterLevel = other.MonsterLevel;
				}
				bool hasPlayerLevelProgress = other.HasPlayerLevelProgress;
				if (hasPlayerLevelProgress)
				{
					this.PlayerLevelProgress = other.PlayerLevelProgress;
				}
				this.itemQualityCounts_.Add(other.itemQualityCounts_);
				bool hasPlayerLootItemPower = other.HasPlayerLootItemPower;
				if (hasPlayerLootItemPower)
				{
					this.PlayerLootItemPower = other.PlayerLootItemPower;
				}
				bool hasPlayerAttackRatingFromItems = other.HasPlayerAttackRatingFromItems;
				if (hasPlayerAttackRatingFromItems)
				{
					this.PlayerAttackRatingFromItems = other.PlayerAttackRatingFromItems;
				}
				bool hasPlayerDefenseRatingFromItems = other.HasPlayerDefenseRatingFromItems;
				if (hasPlayerDefenseRatingFromItems)
				{
					this.PlayerDefenseRatingFromItems = other.PlayerDefenseRatingFromItems;
				}
				bool hasPlayerAttackDefenseLevelBonus = other.HasPlayerAttackDefenseLevelBonus;
				if (hasPlayerAttackDefenseLevelBonus)
				{
					this.PlayerAttackDefenseLevelBonus = other.PlayerAttackDefenseLevelBonus;
				}
				bool hasPlayerAttackRatingTotal = other.HasPlayerAttackRatingTotal;
				if (hasPlayerAttackRatingTotal)
				{
					this.PlayerAttackRatingTotal = other.PlayerAttackRatingTotal;
				}
				bool hasPlayerDefenseRatingTotal = other.HasPlayerDefenseRatingTotal;
				if (hasPlayerDefenseRatingTotal)
				{
					this.PlayerDefenseRatingTotal = other.PlayerDefenseRatingTotal;
				}
				bool hasExperienceTotal = other.HasExperienceTotal;
				if (hasExperienceTotal)
				{
					this.ExperienceTotal = other.ExperienceTotal;
				}
				bool hasGoldFromVendoredItemsTotal = other.HasGoldFromVendoredItemsTotal;
				if (hasGoldFromVendoredItemsTotal)
				{
					this.GoldFromVendoredItemsTotal = other.GoldFromVendoredItemsTotal;
				}
				bool hasGoldFromLootTotal = other.HasGoldFromLootTotal;
				if (hasGoldFromLootTotal)
				{
					this.GoldFromLootTotal = other.GoldFromLootTotal;
				}
				this.currency_.Add(other.currency_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060031B4 RID: 12724 RVA: 0x000C4AC1 File Offset: 0x000C2CC1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060031B5 RID: 12725 RVA: 0x000C4ACC File Offset: 0x000C2CCC
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
					if (num3 <= 50U)
					{
						if (num3 <= 29U)
						{
							if (num3 != 21U)
							{
								if (num3 != 29U)
								{
									goto IL_0134;
								}
								this.LevelAreaSno = input.ReadSFixed32();
							}
							else
							{
								this.ActorSno = input.ReadSFixed32();
							}
						}
						else if (num3 != 32U)
						{
							if (num3 != 40U)
							{
								if (num3 != 50U)
								{
									goto IL_0134;
								}
								this.loot_.AddEntriesFrom(ref input, ProgressDiabloEvent._repeated_loot_codec);
							}
							else
							{
								this.PlayerCombatItemPower = input.ReadInt32();
							}
						}
						else
						{
							this.MonsterCombatItemPower = input.ReadInt32();
						}
					}
					else if (num3 <= 72U)
					{
						if (num3 != 56U)
						{
							if (num3 != 64U)
							{
								if (num3 != 72U)
								{
									goto IL_0134;
								}
								this.PlayerLevel = input.ReadInt32();
							}
							else
							{
								this.MonsterRarity = input.ReadInt32();
							}
						}
						else
						{
							this.ExperienceGained = input.ReadUInt32();
						}
					}
					else if (num3 != 80U)
					{
						if (num3 != 93U)
						{
							if (num3 != 96U)
							{
								goto IL_0134;
							}
							goto IL_020E;
						}
						else
						{
							this.PlayerLevelProgress = input.ReadFloat();
						}
					}
					else
					{
						this.MonsterLevel = input.ReadInt32();
					}
				}
				else if (num3 <= 128U)
				{
					if (num3 <= 104U)
					{
						if (num3 == 98U)
						{
							goto IL_020E;
						}
						if (num3 != 104U)
						{
							goto IL_0134;
						}
						this.PlayerLootItemPower = input.ReadInt32();
					}
					else if (num3 != 112U)
					{
						if (num3 != 120U)
						{
							if (num3 != 128U)
							{
								goto IL_0134;
							}
							this.PlayerAttackDefenseLevelBonus = input.ReadInt32();
						}
						else
						{
							this.PlayerDefenseRatingFromItems = input.ReadInt32();
						}
					}
					else
					{
						this.PlayerAttackRatingFromItems = input.ReadInt32();
					}
				}
				else if (num3 <= 152U)
				{
					if (num3 != 136U)
					{
						if (num3 != 144U)
						{
							if (num3 != 152U)
							{
								goto IL_0134;
							}
							this.ExperienceTotal = input.ReadUInt64();
						}
						else
						{
							this.PlayerDefenseRatingTotal = input.ReadInt32();
						}
					}
					else
					{
						this.PlayerAttackRatingTotal = input.ReadInt32();
					}
				}
				else if (num3 != 160U)
				{
					if (num3 != 168U)
					{
						if (num3 != 178U)
						{
							goto IL_0134;
						}
						this.currency_.AddEntriesFrom(ref input, ProgressDiabloEvent._repeated_currency_codec);
					}
					else
					{
						this.GoldFromLootTotal = input.ReadUInt64();
					}
				}
				else
				{
					this.GoldFromVendoredItemsTotal = input.ReadUInt64();
				}
				continue;
				IL_0134:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_020E:
				this.itemQualityCounts_.AddEntriesFrom(ref input, ProgressDiabloEvent._repeated_itemQualityCounts_codec);
			}
		}

		// Token: 0x0400168E RID: 5774
		private static readonly MessageParser<ProgressDiabloEvent> _parser = new MessageParser<ProgressDiabloEvent>(() => new ProgressDiabloEvent());

		// Token: 0x0400168F RID: 5775
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001690 RID: 5776
		private int _hasBits0;

		// Token: 0x04001691 RID: 5777
		public const int ActorSnoFieldNumber = 2;

		// Token: 0x04001692 RID: 5778
		private static readonly int ActorSnoDefaultValue = 0;

		// Token: 0x04001693 RID: 5779
		private int actorSno_;

		// Token: 0x04001694 RID: 5780
		public const int LevelAreaSnoFieldNumber = 3;

		// Token: 0x04001695 RID: 5781
		private static readonly int LevelAreaSnoDefaultValue = 0;

		// Token: 0x04001696 RID: 5782
		private int levelAreaSno_;

		// Token: 0x04001697 RID: 5783
		public const int MonsterCombatItemPowerFieldNumber = 4;

		// Token: 0x04001698 RID: 5784
		private static readonly int MonsterCombatItemPowerDefaultValue = 0;

		// Token: 0x04001699 RID: 5785
		private int monsterCombatItemPower_;

		// Token: 0x0400169A RID: 5786
		public const int PlayerCombatItemPowerFieldNumber = 5;

		// Token: 0x0400169B RID: 5787
		private static readonly int PlayerCombatItemPowerDefaultValue = 0;

		// Token: 0x0400169C RID: 5788
		private int playerCombatItemPower_;

		// Token: 0x0400169D RID: 5789
		public const int LootFieldNumber = 6;

		// Token: 0x0400169E RID: 5790
		private static readonly FieldCodec<ProgressDiabloEventLoot> _repeated_loot_codec = FieldCodec.ForMessage<ProgressDiabloEventLoot>(50U, ProgressDiabloEventLoot.Parser);

		// Token: 0x0400169F RID: 5791
		private readonly RepeatedField<ProgressDiabloEventLoot> loot_ = new RepeatedField<ProgressDiabloEventLoot>();

		// Token: 0x040016A0 RID: 5792
		public const int ExperienceGainedFieldNumber = 7;

		// Token: 0x040016A1 RID: 5793
		private static readonly uint ExperienceGainedDefaultValue = 0U;

		// Token: 0x040016A2 RID: 5794
		private uint experienceGained_;

		// Token: 0x040016A3 RID: 5795
		public const int MonsterRarityFieldNumber = 8;

		// Token: 0x040016A4 RID: 5796
		private static readonly int MonsterRarityDefaultValue = 0;

		// Token: 0x040016A5 RID: 5797
		private int monsterRarity_;

		// Token: 0x040016A6 RID: 5798
		public const int PlayerLevelFieldNumber = 9;

		// Token: 0x040016A7 RID: 5799
		private static readonly int PlayerLevelDefaultValue = 0;

		// Token: 0x040016A8 RID: 5800
		private int playerLevel_;

		// Token: 0x040016A9 RID: 5801
		public const int MonsterLevelFieldNumber = 10;

		// Token: 0x040016AA RID: 5802
		private static readonly int MonsterLevelDefaultValue = 0;

		// Token: 0x040016AB RID: 5803
		private int monsterLevel_;

		// Token: 0x040016AC RID: 5804
		public const int PlayerLevelProgressFieldNumber = 11;

		// Token: 0x040016AD RID: 5805
		private static readonly float PlayerLevelProgressDefaultValue = 0f;

		// Token: 0x040016AE RID: 5806
		private float playerLevelProgress_;

		// Token: 0x040016AF RID: 5807
		public const int ItemQualityCountsFieldNumber = 12;

		// Token: 0x040016B0 RID: 5808
		private static readonly FieldCodec<int> _repeated_itemQualityCounts_codec = FieldCodec.ForInt32(96U);

		// Token: 0x040016B1 RID: 5809
		private readonly RepeatedField<int> itemQualityCounts_ = new RepeatedField<int>();

		// Token: 0x040016B2 RID: 5810
		public const int PlayerLootItemPowerFieldNumber = 13;

		// Token: 0x040016B3 RID: 5811
		private static readonly int PlayerLootItemPowerDefaultValue = 0;

		// Token: 0x040016B4 RID: 5812
		private int playerLootItemPower_;

		// Token: 0x040016B5 RID: 5813
		public const int PlayerAttackRatingFromItemsFieldNumber = 14;

		// Token: 0x040016B6 RID: 5814
		private static readonly int PlayerAttackRatingFromItemsDefaultValue = 0;

		// Token: 0x040016B7 RID: 5815
		private int playerAttackRatingFromItems_;

		// Token: 0x040016B8 RID: 5816
		public const int PlayerDefenseRatingFromItemsFieldNumber = 15;

		// Token: 0x040016B9 RID: 5817
		private static readonly int PlayerDefenseRatingFromItemsDefaultValue = 0;

		// Token: 0x040016BA RID: 5818
		private int playerDefenseRatingFromItems_;

		// Token: 0x040016BB RID: 5819
		public const int PlayerAttackDefenseLevelBonusFieldNumber = 16;

		// Token: 0x040016BC RID: 5820
		private static readonly int PlayerAttackDefenseLevelBonusDefaultValue = 0;

		// Token: 0x040016BD RID: 5821
		private int playerAttackDefenseLevelBonus_;

		// Token: 0x040016BE RID: 5822
		public const int PlayerAttackRatingTotalFieldNumber = 17;

		// Token: 0x040016BF RID: 5823
		private static readonly int PlayerAttackRatingTotalDefaultValue = 0;

		// Token: 0x040016C0 RID: 5824
		private int playerAttackRatingTotal_;

		// Token: 0x040016C1 RID: 5825
		public const int PlayerDefenseRatingTotalFieldNumber = 18;

		// Token: 0x040016C2 RID: 5826
		private static readonly int PlayerDefenseRatingTotalDefaultValue = 0;

		// Token: 0x040016C3 RID: 5827
		private int playerDefenseRatingTotal_;

		// Token: 0x040016C4 RID: 5828
		public const int ExperienceTotalFieldNumber = 19;

		// Token: 0x040016C5 RID: 5829
		private static readonly ulong ExperienceTotalDefaultValue = 0UL;

		// Token: 0x040016C6 RID: 5830
		private ulong experienceTotal_;

		// Token: 0x040016C7 RID: 5831
		public const int GoldFromVendoredItemsTotalFieldNumber = 20;

		// Token: 0x040016C8 RID: 5832
		private static readonly ulong GoldFromVendoredItemsTotalDefaultValue = 0UL;

		// Token: 0x040016C9 RID: 5833
		private ulong goldFromVendoredItemsTotal_;

		// Token: 0x040016CA RID: 5834
		public const int GoldFromLootTotalFieldNumber = 21;

		// Token: 0x040016CB RID: 5835
		private static readonly ulong GoldFromLootTotalDefaultValue = 0UL;

		// Token: 0x040016CC RID: 5836
		private ulong goldFromLootTotal_;

		// Token: 0x040016CD RID: 5837
		public const int CurrencyFieldNumber = 22;

		// Token: 0x040016CE RID: 5838
		private static readonly FieldCodec<ProgressDiabloEventCurrency> _repeated_currency_codec = FieldCodec.ForMessage<ProgressDiabloEventCurrency>(178U, ProgressDiabloEventCurrency.Parser);

		// Token: 0x040016CF RID: 5839
		private readonly RepeatedField<ProgressDiabloEventCurrency> currency_ = new RepeatedField<ProgressDiabloEventCurrency>();
	}
}
