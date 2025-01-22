using System;

namespace D2Data
{
	// Token: 0x02000919 RID: 2329
	public class BaseMiscItem : BaseItem
	{
		// Token: 0x0600B926 RID: 47398 RVA: 0x003280EC File Offset: 0x003262EC
		public BaseMiscItem(int Index, string Name, string Name2, int SzFlavorText, int CompactSave, int Version, int Level, int LevelReq, int Rarity, int Spawnable, int Speed, int NoDurability, int Cost, int GambleCost, int AutoPrefix, string Code, string AlternateGfx, string NameString, int Component, int InvWidth, int InvHeight, int HasInv, int GemSockets, int GemApplyType, string FlippyFile, string InvFile, string UniqueInvFile, string Special, int Transmogrify, string TMogType, int TMogMin, int TMogMax, int Useable, int Throwable, string Type, string Type2, string DropSound, int DropSfxFrame, string UseSound, int Unique, int Transparent, int TransTbl, int LightRadius, int Belt, int AutoBelt, int Stackable, int MinStack, int MaxStack, int SpawnStack, int Quest, int QuestDiffCheck, int MissileType, int SpellIcon, int pSpell, int State, int CState1, int CState2, int Len, int Stat1, int Calc1, int Stat2, int Calc2, int Stat3, int Calc3, int SpellDesc, string SpellDescStr, int SpellDescCalc, int DurabilityWarning, int QuantityWarning, int GemOffset, int BetterGem, int BitField1, int CharsiMin, int CharsiMax, int CharsiMagicMin, int CharsiMagicMax, int CharsiMagicLvl, int GheedMin, int GheedMax, int GheedMagicMin, int GheedMagicMax, int GheedMagicLvl, int AkaraMin, int AkaraMax, int AkaraMagicMin, int AkaraMagicMax, int AkaraMagicLvl, int FaraMin, int FaraMax, int FaraMagicMin, int FaraMagicMax, int FaraMagicLvl, int LysanderMin, int LysanderMax, int LysanderMagicMin, int LysanderMagicMax, int LysanderMagicLvl, int DrognanMin, int DrognanMax, int DrognanMagicMin, int DrognanMagicMax, int DrognanMagicLvl, int HraltiMin, int HraltiMax, int HraltiMagicMin, int HraltiMagicMax, int HraltiMagicLvl, int AlkorMin, int AlkorMax, int AlkorMagicMin, int AlkorMagicMax, int AlkorMagicLvl, int OrmusMin, int OrmusMax, int OrmusMagicMin, int OrmusMagicMax, int OrmusMagicLvl, int ElzixMin, int ElzixMax, int ElzixMagicMin, int ElzixMagicMax, int ElzixMagicLvl, int AshearaMin, int AshearaMax, int AshearaMagicMin, int AshearaMagicMax, int AshearaMagicLvl, int CainMin, int CainMax, int CainMagicMin, int CainMagicMax, int CainMagicLvl, int HalbuMin, int HalbuMax, int HalbuMagicMin, int HalbuMagicMax, int HalbuMagicLvl, int MalahMin, int MalahMax, int MalahMagicMin, int MalahMagicMax, int MalahMagicLvl, int LarzukMin, int LarzukMax, int LarzukMagicMin, int LarzukMagicMax, int LarzukMagicLvl, int DrehyaMin, int DrehyaMax, int DrehyaMagicMin, int DrehyaMagicMax, int DrehyaMagicLvl, int JamellaMin, int JamellaMax, int JamellaMagicMin, int JamellaMagicMax, int JamellaMagicLvl, int SourceArt, int GameArt, int Transform, int InvTrans, int SkipName, string NightmareUpgrade, string HellUpgrade, int MinDamage, int MaxDamage, int PermStoreItem, int MultiBuy, int Nameable)
		{
			this.type = (ItemType)Index;
			this.index = Index;
			this.tableIndex = Index;
			this.baseType = ((Type == "") ? null : BaseItemType.GetByCode(Type));
			this.baseType2 = ((Type2 == "") ? null : BaseItemType.GetByCode(Type2));
			this.code = Code;
			this.id = BaseItem.GetIdFromCode(Code);
			this.nightmareUpgrade = ((NightmareUpgrade == "xxx") ? 0U : BaseItem.GetIdFromCode(NightmareUpgrade));
			this.hellUpgrade = ((HellUpgrade == "xxx") ? 0U : BaseItem.GetIdFromCode(HellUpgrade));
			this.Name2 = Name2;
			this.SzFlavorText = SzFlavorText;
			this.Special = Special;
			this.Transmogrify = Transmogrify == 1;
			this.TMogType = TMogType;
			this.TMogMin = TMogMin;
			this.TMogMax = TMogMax;
			this.Throwable = Throwable == 1;
			this.AutoBelt = AutoBelt == 1;
			this.SpawnStack = SpawnStack;
			this.QuestDiffCheck = QuestDiffCheck == 1;
			this.SpellIcon = SpellIcon;
			this.pSpell = pSpell;
			this.State = (StateType)State;
			this.CState1 = (StateType)CState1;
			this.CState2 = (StateType)CState2;
			this.Len = Len;
			this.Stat1 = (StatType)Stat1;
			this.Calc1 = Calc1;
			this.Stat2 = (StatType)Stat2;
			this.Calc2 = Calc2;
			this.Stat3 = (StatType)Stat3;
			this.Calc3 = Calc3;
			this.SpellDesc = SpellDesc;
			this.SpellDescStr = SpellDescStr;
			this.SpellDescCalc = SpellDescCalc;
			this.BetterGem = (ItemType)BetterGem;
			this.PermStoreItem = PermStoreItem == 1;
			this.MultiBuy = MultiBuy == 1;
			this.name = Name;
			this.version = Version;
			this.compactSave = CompactSave;
			this.rarity = Rarity;
			this.spawnable = Spawnable == 1;
			this.speed = Speed;
			this.noDurability = NoDurability == 1;
			this.level = Level;
			this.levelReq = LevelReq;
			this.cost = Cost;
			this.gambleCost = GambleCost;
			this.nameString = NameString;
			this.autoPrefix = AutoPrefix;
			this.alternateGfx = AlternateGfx;
			this.component = Component;
			this.invWidth = InvWidth;
			this.invHeight = InvHeight;
			this.hasInv = HasInv == 1;
			this.gemSockets = GemSockets;
			this.gemApplyType = GemApplyType;
			this.flippyFile = FlippyFile;
			this.invFile = InvFile;
			this.uniqueInvFile = UniqueInvFile;
			this.useable = Useable == 1;
			this.stackable = Stackable == 1;
			this.minStack = MinStack;
			this.maxStack = MaxStack;
			this.dropSound = DropSound;
			this.dropSfxFrame = DropSfxFrame;
			this.useSound = UseSound;
			this.unique = Unique == 1;
			this.transparent = Transparent == 1;
			this.transTbl = TransTbl;
			this.lightRadius = LightRadius;
			this.belt = Belt == 1;
			this.quest = Quest;
			this.missileType = MissileType;
			this.durabilityWarning = DurabilityWarning;
			this.quantityWarning = QuantityWarning;
			this.minDamage = MinDamage;
			this.maxDamage = MaxDamage;
			this.gemOffset = GemOffset;
			this.bitField1 = BitField1;
			this.charsiMin = CharsiMin;
			this.charsiMax = CharsiMax;
			this.charsiMagicMin = CharsiMagicMin;
			this.charsiMagicMax = CharsiMagicMax;
			this.charsiMagicLvl = CharsiMagicLvl;
			this.gheedMin = GheedMin;
			this.gheedMax = GheedMax;
			this.gheedMagicMin = GheedMagicMin;
			this.gheedMagicMax = GheedMagicMax;
			this.gheedMagicLvl = GheedMagicLvl;
			this.akaraMin = AkaraMin;
			this.akaraMax = AkaraMax;
			this.akaraMagicMin = AkaraMagicMin;
			this.akaraMagicMax = AkaraMagicMax;
			this.akaraMagicLvl = AkaraMagicLvl;
			this.faraMin = FaraMin;
			this.faraMax = FaraMax;
			this.faraMagicMin = FaraMagicMin;
			this.faraMagicMax = FaraMagicMax;
			this.faraMagicLvl = FaraMagicLvl;
			this.lysanderMin = LysanderMin;
			this.lysanderMax = LysanderMax;
			this.lysanderMagicMin = LysanderMagicMin;
			this.lysanderMagicMax = LysanderMagicMax;
			this.lysanderMagicLvl = LysanderMagicLvl;
			this.drognanMin = DrognanMin;
			this.drognanMax = DrognanMax;
			this.drognanMagicMin = DrognanMagicMin;
			this.drognanMagicMax = DrognanMagicMax;
			this.drognanMagicLvl = DrognanMagicLvl;
			this.hraltiMin = HraltiMin;
			this.hraltiMax = HraltiMax;
			this.hraltiMagicMin = HraltiMagicMin;
			this.hraltiMagicMax = HraltiMagicMax;
			this.hraltiMagicLvl = HraltiMagicLvl;
			this.alkorMin = AlkorMin;
			this.alkorMax = AlkorMax;
			this.alkorMagicMin = AlkorMagicMin;
			this.alkorMagicMax = AlkorMagicMax;
			this.alkorMagicLvl = AlkorMagicLvl;
			this.ormusMin = OrmusMin;
			this.ormusMax = OrmusMax;
			this.ormusMagicMin = OrmusMagicMin;
			this.ormusMagicMax = OrmusMagicMax;
			this.ormusMagicLvl = OrmusMagicLvl;
			this.elzixMin = ElzixMin;
			this.elzixMax = ElzixMax;
			this.elzixMagicMin = ElzixMagicMin;
			this.elzixMagicMax = ElzixMagicMax;
			this.elzixMagicLvl = ElzixMagicLvl;
			this.ashearaMin = AshearaMin;
			this.ashearaMax = AshearaMax;
			this.ashearaMagicMin = AshearaMagicMin;
			this.ashearaMagicMax = AshearaMagicMax;
			this.ashearaMagicLvl = AshearaMagicLvl;
			this.cainMin = CainMin;
			this.cainMax = CainMax;
			this.cainMagicMin = CainMagicMin;
			this.cainMagicMax = CainMagicMax;
			this.cainMagicLvl = CainMagicLvl;
			this.halbuMin = HalbuMin;
			this.halbuMax = HalbuMax;
			this.halbuMagicMin = HalbuMagicMin;
			this.halbuMagicMax = HalbuMagicMax;
			this.halbuMagicLvl = HalbuMagicLvl;
			this.jamellaMin = JamellaMin;
			this.jamellaMax = JamellaMax;
			this.jamellaMagicMin = JamellaMagicMin;
			this.jamellaMagicMax = JamellaMagicMax;
			this.jamellaMagicLvl = JamellaMagicLvl;
			this.larzukMin = LarzukMin;
			this.larzukMax = LarzukMax;
			this.larzukMagicMin = LarzukMagicMin;
			this.larzukMagicMax = LarzukMagicMax;
			this.larzukMagicLvl = LarzukMagicLvl;
			this.malahMin = MalahMin;
			this.malahMax = MalahMax;
			this.malahMagicMin = MalahMagicMin;
			this.malahMagicMax = MalahMagicMax;
			this.malahMagicLvl = MalahMagicLvl;
			this.drehyaMin = DrehyaMin;
			this.drehyaMax = DrehyaMax;
			this.drehyaMagicMin = DrehyaMagicMin;
			this.drehyaMagicMax = DrehyaMagicMax;
			this.drehyaMagicLvl = DrehyaMagicLvl;
			this.sourceArt = SourceArt;
			this.gameArt = GameArt;
			this.transform = Transform;
			this.invTrans = InvTrans;
			this.skipName = SkipName;
			this.minDamage = MinDamage;
			this.maxDamage = MaxDamage;
			this.nameable = Nameable == 1;
		}

		// Token: 0x04006CCF RID: 27855
		public readonly int SpawnStack;

		// Token: 0x04006CD0 RID: 27856
		public readonly bool AutoBelt;

		// Token: 0x04006CD1 RID: 27857
		public readonly ItemType BetterGem;

		// Token: 0x04006CD2 RID: 27858
		public readonly int Calc1;

		// Token: 0x04006CD3 RID: 27859
		public readonly int Calc2;

		// Token: 0x04006CD4 RID: 27860
		public readonly int Calc3;

		// Token: 0x04006CD5 RID: 27861
		public readonly StateType CState1;

		// Token: 0x04006CD6 RID: 27862
		public readonly StateType CState2;

		// Token: 0x04006CD7 RID: 27863
		public readonly int Len;

		// Token: 0x04006CD8 RID: 27864
		public readonly bool MultiBuy;

		// Token: 0x04006CD9 RID: 27865
		public readonly string Name2;

		// Token: 0x04006CDA RID: 27866
		public readonly bool PermStoreItem;

		// Token: 0x04006CDB RID: 27867
		public readonly int pSpell;

		// Token: 0x04006CDC RID: 27868
		public readonly bool QuestDiffCheck;

		// Token: 0x04006CDD RID: 27869
		public readonly string Special;

		// Token: 0x04006CDE RID: 27870
		public readonly int SpellDesc;

		// Token: 0x04006CDF RID: 27871
		public readonly int SpellDescCalc;

		// Token: 0x04006CE0 RID: 27872
		public readonly string SpellDescStr;

		// Token: 0x04006CE1 RID: 27873
		public readonly int SpellIcon;

		// Token: 0x04006CE2 RID: 27874
		public readonly StatType Stat1;

		// Token: 0x04006CE3 RID: 27875
		public readonly StatType Stat2;

		// Token: 0x04006CE4 RID: 27876
		public readonly StatType Stat3;

		// Token: 0x04006CE5 RID: 27877
		public readonly StateType State;

		// Token: 0x04006CE6 RID: 27878
		public readonly int SzFlavorText;

		// Token: 0x04006CE7 RID: 27879
		public readonly bool Throwable;

		// Token: 0x04006CE8 RID: 27880
		public readonly int TMogMax;

		// Token: 0x04006CE9 RID: 27881
		public readonly int TMogMin;

		// Token: 0x04006CEA RID: 27882
		public readonly string TMogType;

		// Token: 0x04006CEB RID: 27883
		public readonly bool Transmogrify;
	}
}
