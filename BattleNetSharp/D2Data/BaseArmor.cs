using System;

namespace D2Data
{
	// Token: 0x02000915 RID: 2325
	public class BaseArmor : BaseItem
	{
		// Token: 0x0600B874 RID: 47220 RVA: 0x002DE4F8 File Offset: 0x002DC6F8
		public BaseArmor(int Index, string Name, int Version, int CompactSave, int Rarity, int Spawnable, int MinAc, int MaxAc, int Absorbs, int Speed, int ReqStr, int Block, int Durability, int NoDurability, int Level, int LevelReq, int Cost, int GambleCost, string Code, string NameString, int MagicLevel, int AutoPrefix, string AlternateGfx, string OpenBetaGfx, string NormCode, string UberCode, string UltraCode, int SpellOffset, int Component, int InvWidth, int InvHeight, int HasInv, int GemSockets, int GemApplyType, string FlippyFile, string InvFile, string UniqueInvFile, string SetInvFile, int lArm, int rArm, int Torso, int Legs, int rSPad, int lSPad, int Useable, int Throwable, int Stackable, int MinStack, int MaxStack, string Type, string Type2, string DropSound, int DropSfxFrame, string UseSound, int Unique, int Transparent, int TransTbl, int Quivered, int LightRadius, int Belt, int Quest, int MissileType, int DurabilityWarning, int QuantityWarning, int MinDamage, int MaxDamage, int StrBonus, int DexBonus, int GemOffset, int BitField1, int CharsiMin, int CharsiMax, int CharsiMagicMin, int CharsiMagicMax, int CharsiMagicLvl, int GheedMin, int GheedMax, int GheedMagicMin, int GheedMagicMax, int GheedMagicLvl, int AkaraMin, int AkaraMax, int AkaraMagicMin, int AkaraMagicMax, int AkaraMagicLvl, int FaraMin, int FaraMax, int FaraMagicMin, int FaraMagicMax, int FaraMagicLvl, int LysanderMin, int LysanderMax, int LysanderMagicMin, int LysanderMagicMax, int LysanderMagicLvl, int DrognanMin, int DrognanMax, int DrognanMagicMin, int DrognanMagicMax, int DrognanMagicLvl, int HraltiMin, int HraltiMax, int HraltiMagicMin, int HraltiMagicMax, int HraltiMagicLvl, int AlkorMin, int AlkorMax, int AlkorMagicMin, int AlkorMagicMax, int AlkorMagicLvl, int OrmusMin, int OrmusMax, int OrmusMagicMin, int OrmusMagicMax, int OrmusMagicLvl, int ElzixMin, int ElzixMax, int ElzixMagicMin, int ElzixMagicMax, int ElzixMagicLvl, int AshearaMin, int AshearaMax, int AshearaMagicMin, int AshearaMagicMax, int AshearaMagicLvl, int CainMin, int CainMax, int CainMagicMin, int CainMagicMax, int CainMagicLvl, int HalbuMin, int HalbuMax, int HalbuMagicMin, int HalbuMagicMax, int HalbuMagicLvl, int JamellaMin, int JamellaMax, int JamellaMagicMin, int JamellaMagicMax, int JamellaMagicLvl, int LarzukMin, int LarzukMax, int LarzukMagicMin, int LarzukMagicMax, int LarzukMagicLvl, int MalahMin, int MalahMax, int MalahMagicMin, int MalahMagicMax, int MalahMagicLvl, int DrehyaMin, int DrehyaMax, int DrehyaMagicMin, int DrehyaMagicMax, int DrehyaMagicLvl, int SourceArt, int GameArt, int Transform, int InvTrans, int SkipName, string NightmareUpgrade, string HellUpgrade, int MinDamage2, int MaxDamage2, int Nameable)
		{
			this.type = (ItemType)Index;
			this.index = Index;
			this.tableIndex = Index - BaseItem.BASE_ARMOR_START;
			this.baseType = ((Type == "") ? null : BaseItemType.GetByCode(Type));
			this.baseType2 = ((Type2 == "") ? null : BaseItemType.GetByCode(Type2));
			this.code = Code;
			this.id = BaseItem.GetIdFromCode(Code);
			this.nightmareUpgrade = ((NightmareUpgrade == "xxx") ? 0U : BaseItem.GetIdFromCode(NightmareUpgrade));
			this.hellUpgrade = ((HellUpgrade == "xxx") ? 0U : BaseItem.GetIdFromCode(HellUpgrade));
			this.NormalID = BaseItem.GetIdFromCode(NormCode);
			this.ExceptionalID = BaseItem.GetIdFromCode(UberCode);
			this.EliteID = BaseItem.GetIdFromCode(UltraCode);
			this.MinAc = MinAc;
			this.MaxAc = MaxAc;
			this.Absorbs = Absorbs;
			this.ReqStr = ReqStr;
			this.Block = Block;
			this.Durability = Durability;
			this.MagicLevel = MagicLevel;
			this.SpellOffset = SpellOffset;
			this.SetInvFile = SetInvFile;
			this.lArm = lArm;
			this.rArm = rArm;
			this.Torso = Torso;
			this.Legs = Legs;
			this.rSPad = rSPad;
			this.lSPad = lSPad;
			this.Throwable = Throwable == 1;
			this.Quivered = Quivered == 1;
			this.StrBonus = StrBonus;
			this.DexBonus = DexBonus;
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

		// Token: 0x04006B6F RID: 27503
		public readonly uint NormalID;

		// Token: 0x04006B70 RID: 27504
		public readonly uint ExceptionalID;

		// Token: 0x04006B71 RID: 27505
		public readonly uint EliteID;

		// Token: 0x04006B72 RID: 27506
		public readonly int Absorbs;

		// Token: 0x04006B73 RID: 27507
		public readonly int Block;

		// Token: 0x04006B74 RID: 27508
		public readonly int DexBonus;

		// Token: 0x04006B75 RID: 27509
		public readonly int Durability;

		// Token: 0x04006B76 RID: 27510
		public readonly int lArm;

		// Token: 0x04006B77 RID: 27511
		public readonly int Legs;

		// Token: 0x04006B78 RID: 27512
		public readonly int lSPad;

		// Token: 0x04006B79 RID: 27513
		public readonly int MagicLevel;

		// Token: 0x04006B7A RID: 27514
		public readonly int MaxAc;

		// Token: 0x04006B7B RID: 27515
		public readonly int MaxDamage2;

		// Token: 0x04006B7C RID: 27516
		public readonly int MinAc;

		// Token: 0x04006B7D RID: 27517
		public readonly int MinDamage2;

		// Token: 0x04006B7E RID: 27518
		public readonly string OpenBetaGfx;

		// Token: 0x04006B7F RID: 27519
		public readonly bool Quivered;

		// Token: 0x04006B80 RID: 27520
		public readonly int rArm;

		// Token: 0x04006B81 RID: 27521
		public readonly int ReqStr;

		// Token: 0x04006B82 RID: 27522
		public readonly int rSPad;

		// Token: 0x04006B83 RID: 27523
		public readonly string SetInvFile;

		// Token: 0x04006B84 RID: 27524
		public readonly int SpellOffset;

		// Token: 0x04006B85 RID: 27525
		public readonly int StrBonus;

		// Token: 0x04006B86 RID: 27526
		public readonly bool Throwable;

		// Token: 0x04006B87 RID: 27527
		public readonly int Torso;
	}
}
