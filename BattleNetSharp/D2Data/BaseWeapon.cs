using System;

namespace D2Data
{
	// Token: 0x02000921 RID: 2337
	public class BaseWeapon : BaseItem
	{
		// Token: 0x0600B952 RID: 47442 RVA: 0x00361BB0 File Offset: 0x0035FDB0
		public BaseWeapon(int Index, string Name, string Type, string Type2, string Code, string AlternateGfx, string NameString, int Version, int CompactSave, int Rarity, int Spawnable, int MinDamage, int MaxDamage, int OneOrTwoHanded, int TwoHanded, int TwoHandMinDamage, int TwoHandMaxDamage, int MinMisDamage, int MaxMisDamage, int Unknown, int RangeAdder, int Speed, int StrBonus, int DexBonus, int ReqStr, int ReqDex, int Durability, int NoDurability, int Level, int LevelReq, int Cost, int GambleCost, int MagicLevel, int AutoPrefix, string OpenBetaGfx, string NormCode, string UberCode, string UltraCode, string WeaponClass, string TwoHandedWeaponClass, int Component, string HitClass, int InvWidth, int InvHeight, int Stackable, int MinStack, int MaxStack, int SpawnStack, string FlippyFile, string InvFile, string UniqueInvFile, string SetInvFile, int HasInv, int GemSockets, int GemApplyType, string Special, int Useable, string DropSound, int DropSfxFrame, string UseSound, int Unique, int Transparent, int TransTbl, int Quivered, int LightRadius, int Belt, int Quest, int QuestDiffCheck, int MissileType, int DurabilityWarning, int QuantityWarning, int GemOffset, int BitField1, int CharsiMin, int CharsiMax, int CharsiMagicMin, int CharsiMagicMax, int CharsiMagicLvl, int GheedMin, int GheedMax, int GheedMagicMin, int GheedMagicMax, int GheedMagicLvl, int AkaraMin, int AkaraMax, int AkaraMagicMin, int AkaraMagicMax, int AkaraMagicLvl, int FaraMin, int FaraMax, int FaraMagicMin, int FaraMagicMax, int FaraMagicLvl, int LysanderMin, int LysanderMax, int LysanderMagicMin, int LysanderMagicMax, int LysanderMagicLvl, int DrognanMin, int DrognanMax, int DrognanMagicMin, int DrognanMagicMax, int DrognanMagicLvl, int HraltiMin, int HraltiMax, int HraltiMagicMin, int HraltiMagicMax, int HraltiMagicLvl, int AlkorMin, int AlkorMax, int AlkorMagicMin, int AlkorMagicMax, int AlkorMagicLvl, int OrmusMin, int OrmusMax, int OrmusMagicMin, int OrmusMagicMax, int OrmusMagicLvl, int ElzixMin, int ElzixMax, int ElzixMagicMin, int ElzixMagicMax, int ElzixMagicLvl, int AshearaMin, int AshearaMax, int AshearaMagicMin, int AshearaMagicMax, int AshearaMagicLvl, int CainMin, int CainMax, int CainMagicMin, int CainMagicMax, int CainMagicLvl, int HalbuMin, int HalbuMax, int HalbuMagicMin, int HalbuMagicMax, int HalbuMagicLvl, int JamellaMin, int JamellaMax, int JamellaMagicMin, int JamellaMagicMax, int JamellaMagicLvl, int LarzukMin, int LarzukMax, int LarzukMagicMin, int LarzukMagicMax, int LarzukMagicLvl, int DrehyaMin, int DrehyaMax, int DrehyaMagicMin, int DrehyaMagicMax, int DrehyaMagicLvl, int MalahMin, int MalahMax, int MalahMagicMin, int MalahMagicMax, int MalahMagicLvl, int SourceArt, int GameArt, int Transform, int InvTrans, int SkipName, string NightmareUpgrade, string HellUpgrade, int Nameable, int PermStoreItem)
		{
			this.type = (ItemType)Index;
			this.index = Index;
			this.tableIndex = Index - BaseItem.BASE_WEAPON_START;
			this.baseType = ((Type == "") ? null : BaseItemType.GetByCode(Type));
			this.baseType2 = ((Type2 == "") ? null : BaseItemType.GetByCode(Type2));
			this.code = Code;
			this.id = BaseItem.GetIdFromCode(Code);
			this.nightmareUpgrade = ((NightmareUpgrade == "xxx") ? 0U : BaseItem.GetIdFromCode(NightmareUpgrade));
			this.hellUpgrade = ((HellUpgrade == "xxx") ? 0U : BaseItem.GetIdFromCode(HellUpgrade));
			this.NormalID = BaseItem.GetIdFromCode(NormCode);
			this.ExceptionalID = BaseItem.GetIdFromCode(UberCode);
			this.EliteID = BaseItem.GetIdFromCode(UltraCode);
			this.OneOrTwoHanded = OneOrTwoHanded == 1;
			this.TwoHanded = TwoHanded == 1;
			this.TwoHandMinDamage = TwoHandMinDamage;
			this.TwoHandMaxDamage = TwoHandMaxDamage;
			this.MinMisDamage = MinMisDamage;
			this.MaxMisDamage = MaxMisDamage;
			this.Unknown = Unknown;
			this.RangeAdder = RangeAdder;
			this.StrBonus = StrBonus;
			this.DexBonus = DexBonus;
			this.ReqStr = ReqStr;
			this.ReqDex = ReqDex;
			this.Durability = Durability;
			this.MagicLevel = MagicLevel;
			this.WeaponClass = WeaponClass;
			this.TwoHandedWeaponClass = TwoHandedWeaponClass;
			this.HitClass = HitClass;
			this.SpawnStack = SpawnStack;
			this.SetInvFile = SetInvFile;
			this.Special = Special;
			this.Quivered = Quivered == 1;
			this.QuestDiffCheck = QuestDiffCheck == 1;
			this.PermStoreItem = PermStoreItem == 1;
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
			this.OpenBetaGfx = OpenBetaGfx;
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

		// Token: 0x04006E77 RID: 28279
		public readonly uint NormalID;

		// Token: 0x04006E78 RID: 28280
		public readonly uint ExceptionalID;

		// Token: 0x04006E79 RID: 28281
		public readonly uint EliteID;

		// Token: 0x04006E7A RID: 28282
		public readonly int DexBonus;

		// Token: 0x04006E7B RID: 28283
		public readonly int Durability;

		// Token: 0x04006E7C RID: 28284
		public readonly string HitClass;

		// Token: 0x04006E7D RID: 28285
		public readonly int MagicLevel;

		// Token: 0x04006E7E RID: 28286
		public readonly int MaxMisDamage;

		// Token: 0x04006E7F RID: 28287
		public readonly int MinMisDamage;

		// Token: 0x04006E80 RID: 28288
		public readonly bool OneOrTwoHanded;

		// Token: 0x04006E81 RID: 28289
		public readonly string OpenBetaGfx;

		// Token: 0x04006E82 RID: 28290
		public readonly bool PermStoreItem;

		// Token: 0x04006E83 RID: 28291
		public readonly bool QuestDiffCheck;

		// Token: 0x04006E84 RID: 28292
		public readonly bool Quivered;

		// Token: 0x04006E85 RID: 28293
		public readonly int RangeAdder;

		// Token: 0x04006E86 RID: 28294
		public readonly int ReqDex;

		// Token: 0x04006E87 RID: 28295
		public readonly int ReqStr;

		// Token: 0x04006E88 RID: 28296
		public readonly int StrBonus;

		// Token: 0x04006E89 RID: 28297
		public readonly bool TwoHanded;

		// Token: 0x04006E8A RID: 28298
		public readonly string TwoHandedWeaponClass;

		// Token: 0x04006E8B RID: 28299
		public readonly int TwoHandMaxDamage;

		// Token: 0x04006E8C RID: 28300
		public readonly int TwoHandMinDamage;

		// Token: 0x04006E8D RID: 28301
		public readonly string WeaponClass;

		// Token: 0x04006E8E RID: 28302
		public readonly string SetInvFile;

		// Token: 0x04006E8F RID: 28303
		public readonly int SpawnStack;

		// Token: 0x04006E90 RID: 28304
		public readonly string Special;

		// Token: 0x04006E91 RID: 28305
		public readonly int Unknown;
	}
}
