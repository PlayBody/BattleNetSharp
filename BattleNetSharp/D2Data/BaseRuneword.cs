using System;

namespace D2Data
{
	// Token: 0x0200091B RID: 2331
	public class BaseRuneword
	{
		// Token: 0x0600B92D RID: 47405 RVA: 0x0032DD54 File Offset: 0x0032BF54
		public BaseRuneword(int Index, string Name, bool Complete, bool Server, string IType1, string IType2, string IType3, string IType4, string IType5, string IType6, string EType1, string EType2, string EType3, string Runes, string Rune1, string Rune2, string Rune3, string Rune4, string Rune5, string Rune6, string Property1, int Param1, int Min1, int Max1, string Property2, int Param2, int Min2, int Max2, string Property3, int Param3, int Min3, int Max3, string Property4, int Param4, int Min4, int Max4, string Property5, int Param5, int Min5, int Max5, string Property6, int Param6, int Min6, int Max6, string Property7, int Param7, int Min7, int Max7)
		{
			this.Index = Index;
			this.Id = (RunewordType)Index;
			this.Name = Name;
			this.Complete = Complete;
			this.Server = Server;
			bool flag = IType1.Length == 0;
			if (flag)
			{
				this.IType1 = null;
			}
			else
			{
				this.IType1 = BaseItemType.GetByCode(IType1);
			}
			bool flag2 = IType2.Length == 0;
			if (flag2)
			{
				this.IType2 = null;
			}
			else
			{
				this.IType2 = BaseItemType.GetByCode(IType2);
			}
			bool flag3 = IType3.Length == 0;
			if (flag3)
			{
				this.IType3 = null;
			}
			else
			{
				this.IType3 = BaseItemType.GetByCode(IType3);
			}
			bool flag4 = IType4.Length == 0;
			if (flag4)
			{
				this.IType4 = null;
			}
			else
			{
				this.IType4 = BaseItemType.GetByCode(IType4);
			}
			bool flag5 = IType5.Length == 0;
			if (flag5)
			{
				this.IType5 = null;
			}
			else
			{
				this.IType5 = BaseItemType.GetByCode(IType5);
			}
			bool flag6 = IType6.Length == 0;
			if (flag6)
			{
				this.IType6 = null;
			}
			else
			{
				this.IType6 = BaseItemType.GetByCode(IType6);
			}
			bool flag7 = EType1.Length == 0;
			if (flag7)
			{
				this.EType1 = null;
			}
			else
			{
				this.EType1 = BaseItemType.GetByCode(EType1);
			}
			bool flag8 = EType2.Length == 0;
			if (flag8)
			{
				this.EType2 = null;
			}
			else
			{
				this.EType2 = BaseItemType.GetByCode(EType2);
			}
			bool flag9 = EType3.Length == 0;
			if (flag9)
			{
				this.EType3 = null;
			}
			else
			{
				this.EType3 = BaseItemType.GetByCode(EType3);
			}
			this.Runes = Runes;
			this.Rune1 = Rune1;
			this.Rune2 = Rune2;
			this.Rune3 = Rune3;
			this.Rune4 = Rune4;
			this.Rune5 = Rune5;
			this.Rune6 = Rune6;
			bool flag10 = Property1.Length == 0;
			if (flag10)
			{
				this.Property1 = null;
			}
			else
			{
				this.Property1 = BaseProperty.GetByCode(Property1);
			}
			this.Param1 = Param1;
			this.Min1 = Min1;
			this.Max1 = Max1;
			bool flag11 = Property2.Length == 0;
			if (flag11)
			{
				this.Property2 = null;
			}
			else
			{
				this.Property2 = BaseProperty.GetByCode(Property2);
			}
			this.Param2 = Param2;
			this.Min2 = Min2;
			this.Max2 = Max2;
			bool flag12 = Property3.Length == 0;
			if (flag12)
			{
				this.Property3 = null;
			}
			else
			{
				this.Property3 = BaseProperty.GetByCode(Property3);
			}
			this.Param3 = Param3;
			this.Min3 = Min3;
			this.Max3 = Max3;
			bool flag13 = Property4.Length == 0;
			if (flag13)
			{
				this.Property4 = null;
			}
			else
			{
				this.Property4 = BaseProperty.GetByCode(Property4);
			}
			this.Param4 = Param4;
			this.Min4 = Min4;
			this.Max4 = Max4;
			bool flag14 = Property5.Length == 0;
			if (flag14)
			{
				this.Property5 = null;
			}
			else
			{
				this.Property5 = BaseProperty.GetByCode(Property5);
			}
			this.Param5 = Param5;
			this.Min5 = Min5;
			this.Max5 = Max5;
			bool flag15 = Property6.Length == 0;
			if (flag15)
			{
				this.Property6 = null;
			}
			else
			{
				this.Property6 = BaseProperty.GetByCode(Property6);
			}
			this.Param6 = Param6;
			this.Min6 = Min6;
			this.Max6 = Max6;
			bool flag16 = Property7.Length == 0;
			if (flag16)
			{
				this.Property7 = null;
			}
			else
			{
				this.Property7 = BaseProperty.GetByCode(Property7);
			}
			this.Param7 = Param7;
			this.Min7 = Min7;
			this.Max7 = Max7;
		}

		// Token: 0x0600B92E RID: 47406 RVA: 0x0032E108 File Offset: 0x0032C308
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x0600B92F RID: 47407 RVA: 0x0032E120 File Offset: 0x0032C320
		public static BaseRuneword Get(RunewordType type)
		{
			bool flag = type < RunewordType.AncientsPledge || type > (RunewordType)BaseRuneword.ItemCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException();
			}
			return BaseRuneword.items[type - RunewordType.AncientsPledge];
		}

		// Token: 0x0600B930 RID: 47408 RVA: 0x0032E158 File Offset: 0x0032C358
		public static BaseRuneword Get(int index)
		{
			bool flag = index < 1 || index > BaseRuneword.ItemCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException();
			}
			return BaseRuneword.items[index - 1];
		}

		// Token: 0x0600B931 RID: 47409 RVA: 0x0032E190 File Offset: 0x0032C390
		public static BaseRuneword Get(string name)
		{
			return BaseRuneword.GetByName(name);
		}

		// Token: 0x0600B932 RID: 47410 RVA: 0x0032E1A8 File Offset: 0x0032C3A8
		public static BaseRuneword GetByName(string name)
		{
			for (int i = 0; i <= BaseRuneword.ItemCount; i++)
			{
				bool flag = BaseRuneword.items[i] != null && BaseRuneword.items[i].Name == name;
				if (flag)
				{
					return BaseRuneword.items[i];
				}
			}
			throw new ArgumentException(string.Format("No Runeword named {0} found !", name));
		}

		// Token: 0x0600B933 RID: 47411 RVA: 0x0032E210 File Offset: 0x0032C410
		static BaseRuneword()
		{
			BaseRuneword[] array = new BaseRuneword[170];
			array[0] = new BaseRuneword(++BaseRuneword.ItemCount, "Ancient's Pledge", true, false, "shld", "", "", "", "", "", "", "", "", "", "r08", "r09", "r07", "", "", "", "res-cold", -1, 30, 30, "res-all", -1, 13, 13, "ac%", -1, 50, 50, "dmg-to-mana", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[1] = new BaseRuneword(++BaseRuneword.ItemCount, "Armageddon", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[2] = new BaseRuneword(++BaseRuneword.ItemCount, "Authority", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[3] = new BaseRuneword(++BaseRuneword.ItemCount, "Beast", true, false, "axe", "scep", "hamm", "", "", "", "", "", "", "", "r30", "r03", "r22", "r23", "r17", "", "swing2", -1, 40, 40, "aura", 122, 9, 9, "dmg%", -1, 240, 270, "str", -1, 25, 40, "charged", 247, 5, 13, "oskill", 228, 3, 3, "oskill", 224, 3, 3);
			array[4] = new BaseRuneword(++BaseRuneword.ItemCount, "Beauty", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[5] = new BaseRuneword(++BaseRuneword.ItemCount, "Black", true, false, "club", "hamm", "mace", "", "", "", "", "", "", "", "r10", "r16", "r04", "", "", "", "crush", -1, 40, 40, "dmg%", -1, 120, 120, "swing2", -1, 15, 15, "red-mag", -1, 2, 2, "att", -1, 200, 200, "charged", 74, 12, 4, "", -1, -1, -1);
			array[6] = new BaseRuneword(++BaseRuneword.ItemCount, "Blood", false, false, "helm", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[7] = new BaseRuneword(++BaseRuneword.ItemCount, "Bone", true, false, "tors", "", "", "", "", "", "", "", "", "SolUmUm", "r12", "r22", "r22", "", "", "", "hit-skill", 84, 15, 10, "gethit-skill", 68, 15, 10, "nec", -1, 2, 2, "mana", -1, 100, 150, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[8] = new BaseRuneword(++BaseRuneword.ItemCount, "Bramble", true, false, "tors", "", "", "", "", "", "", "", "", "RalOhmSurEth", "r08", "r27", "r29", "r05", "", "", "balance2", -1, 50, 50, "ac", -1, 300, 300, "aura", 103, 15, 21, "heal-kill", -1, 13, 13, "extra-pois", -1, 25, 50, "res-pois", -1, 100, 100, "charged", 246, 33, 13);
			array[9] = new BaseRuneword(++BaseRuneword.ItemCount, "Brand", true, false, "miss", "", "", "", "", "", "", "", "", "JahLoMalGul", "r31", "r28", "r23", "r25", "", "", "dmg%", -1, 260, 340, "dmg-demon", -1, 280, 330, "hit-skill", 84, 100, 18, "gethit-skill", 66, 35, 14, "knock", -1, 1, 1, "noheal", -1, 1, 1, "explosivearrow", -1, 15, 15);
			array[10] = new BaseRuneword(++BaseRuneword.ItemCount, "Breath of the Dying", true, false, "weap", "", "", "", "", "", "", "", "", "VexHelElEldZodEth", "r26", "r15", "r01", "r02", "r33", "r05", "swing2", -1, 60, 60, "dmg-undead", -1, 125, 125, "lifesteal", -1, 12, 15, "noheal", -1, 1, 1, "kill-skill", 92, 50, 20, "dmg%", -1, 350, 400, "all-stats", -1, 30, 30);
			array[11] = new BaseRuneword(++BaseRuneword.ItemCount, "Broken Promise", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[12] = new BaseRuneword(++BaseRuneword.ItemCount, "Call to Arms", true, false, "weap", "", "", "", "", "", "", "", "", "AmnRalMalIstOhm", "r11", "r08", "r23", "r24", "r27", "", "swing2", -1, 40, 40, "dmg%", -1, 200, 240, "allskills", -1, 1, 1, "oskill", 155, 2, 6, "oskill", 149, 1, 6, "oskill", 146, 1, 4, "regen", -1, 12, 12);
			array[13] = new BaseRuneword(++BaseRuneword.ItemCount, "Chains of Honor", true, false, "tors", "", "", "", "", "", "", "", "", "DolUmBerIst", "r14", "r22", "r30", "r24", "", "", "res-all", -1, 50, 50, "ac%", -1, 70, 70, "dmg-demon", -1, 200, 200, "dmg-undead", -1, 100, 100, "lifesteal", -1, 8, 8, "allskills", -1, 2, 2, "str", -1, 20, 20);
			array[14] = new BaseRuneword(++BaseRuneword.ItemCount, "Chance", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[15] = new BaseRuneword(++BaseRuneword.ItemCount, "Chaos", true, false, "h2h", "", "", "", "", "", "", "", "", "FalOhmUm", "r19", "r27", "r22", "", "", "", "demon-heal", -1, 15, 15, "dmg%", -1, 240, 290, "dmg-mag", -1, 216, 471, "oskill", 151, 1, 1, "swing2", -1, 35, 35, "hit-skill", 64, 9, 11, "hit-skill", 38, 11, 9);
			array[16] = new BaseRuneword(++BaseRuneword.ItemCount, "Crescent Moon", true, false, "axe", "swor", "pole", "", "", "", "", "", "", "ShaelUmTir", "r13", "r22", "r03", "", "", "", "pierce-ltng", -1, 35, 35, "ignore-ac", -1, 1, 1, "dmg%", -1, 180, 220, "abs-mag", -1, 9, 11, "charged", 227, 30, 18, "hit-skill", 42, 7, 13, "hit-skill", 53, 10, 17);
			array[17] = new BaseRuneword(++BaseRuneword.ItemCount, "Darkness", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[18] = new BaseRuneword(++BaseRuneword.ItemCount, "Daylight", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[19] = new BaseRuneword(++BaseRuneword.ItemCount, "Death", true, false, "swor", "axe", "", "", "", "", "", "", "", "HelElVexOrtGul", "r15", "r01", "r26", "r09", "r25", "", "dmg%", -1, 300, 385, "deadly/lvl", 4, -1, -1, "charged", 85, 15, 22, "att-skill", 55, 25, 18, "death-skill", 53, 100, 44, "crush", -1, 50, 50, "indestruct", -1, 1, 1);
			array[20] = new BaseRuneword(++BaseRuneword.ItemCount, "Deception", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[21] = new BaseRuneword(++BaseRuneword.ItemCount, "Delirium", true, false, "helm", "", "", "", "", "", "", "", "", "LemIstIo", "r20", "r24", "r16", "", "", "", "hit-skill", 81, 11, 18, "charged", 86, 60, 17, "gethit-skill", 77, 14, 13, "ac", -1, 261, 261, "gethit-skill", 273, 6, 14, "gethit-skill", 350, 1, 50, "allskills", -1, 2, 2);
			array[22] = new BaseRuneword(++BaseRuneword.ItemCount, "Desire", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[23] = new BaseRuneword(++BaseRuneword.ItemCount, "Despair", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[24] = new BaseRuneword(++BaseRuneword.ItemCount, "Destruction", true, false, "pole", "swor", "", "", "", "", "", "", "", "VexLoBerJahKo", "r26", "r28", "r30", "r31", "r18", "", "dmg%", -1, 350, 350, "dmg-mag", -1, 100, 180, "hit-skill", 229, 5, 23, "death-skill", 56, 100, 45, "att-skill", 48, 15, 22, "hit-skill", 244, 23, 12, "noheal", -1, 1, 1);
			array[25] = new BaseRuneword(++BaseRuneword.ItemCount, "Doom", true, false, "axe", "pole", "hamm", "", "", "", "", "", "", "HelOhmUmLoCham", "r15", "r27", "r22", "r28", "r32", "", "dmg%", -1, 280, 320, "aura", 114, 12, 12, "swing2", -1, 45, 45, "noheal", -1, 1, 1, "pierce-cold", -1, 40, 60, "allskills", -1, 2, 2, "hit-skill", 244, 5, 18);
			array[26] = new BaseRuneword(++BaseRuneword.ItemCount, "Dragon", true, false, "tors", "shld", "", "", "", "", "", "", "", "SurLoSol", "r29", "r28", "r12", "", "", "", "ac", -1, 360, 360, "ac-miss", -1, 230, 230, "str/lvl", 3, -1, -1, "hit-skill", 62, 12, 15, "gethit-skill", 278, 20, 18, "aura", 102, 14, 14, "all-stats", -1, 3, 5);
			array[27] = new BaseRuneword(++BaseRuneword.ItemCount, "Dread", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[28] = new BaseRuneword(++BaseRuneword.ItemCount, "Dream", true, false, "helm", "shld", "", "", "", "", "", "", "", "IoJahPul", "r16", "r31", "r21", "", "", "", "ac", -1, 150, 220, "gethit-skill", 81, 10, 15, "mana/lvl", 5, -1, -1, "res-all", -1, 5, 20, "balance3", -1, 20, 30, "aura", 118, 15, 15, "mag%", -1, 12, 25);
			array[29] = new BaseRuneword(++BaseRuneword.ItemCount, "Duress", true, false, "tors", "", "", "", "", "", "", "", "", "ShaelUmThul", "r13", "r22", "r10", "", "", "", "dmg-cold", 50, 37, 133, "dmg%", -1, 10, 20, "ac%", -1, 150, 200, "balance2", -1, 20, 20, "openwounds", -1, 33, 33, "crush", -1, 15, 15, "stamdrain", -1, -20, -20);
			array[30] = new BaseRuneword(++BaseRuneword.ItemCount, "Edge", true, false, "miss", "", "", "", "", "", "", "", "", "TirTalAmn", "r03", "r07", "r11", "", "", "", "dmg-demon", -1, 320, 380, "dmg-undead", -1, 280, 280, "swing2", -1, 35, 35, "noheal", -1, 1, 1, "aura", 103, 15, 15, "all-stats", -1, 5, 10, "cheap", -1, 15, 15);
			array[31] = new BaseRuneword(++BaseRuneword.ItemCount, "Elation", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[32] = new BaseRuneword(++BaseRuneword.ItemCount, "Enigma", true, false, "tors", "", "", "", "", "", "", "", "", "JahIthBer", "r31", "r06", "r30", "", "", "", "ac", -1, 750, 775, "heal-kill", -1, 14, 14, "move2", -1, 45, 45, "str/lvl", 6, -1, -1, "allskills", -1, 2, 2, "mag%/lvl", 8, -1, -1, "oskill", 54, 1, 1);
			array[33] = new BaseRuneword(++BaseRuneword.ItemCount, "Enlightenment", true, false, "tors", "", "", "", "", "", "", "", "", "PulRalSur", "r21", "r08", "r12", "", "", "", "hit-skill", 47, 5, 15, "gethit-skill", 46, 5, 15, "sor", -1, 2, 2, "oskill", 37, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[34] = new BaseRuneword(++BaseRuneword.ItemCount, "Envy", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[35] = new BaseRuneword(++BaseRuneword.ItemCount, "Eternity", true, false, "mele", "", "", "", "", "", "", "", "", "AmnBerIstSolSur", "r11", "r30", "r24", "r12", "r29", "", "dmg%", -1, 260, 310, "indestruct", -1, 1, 1, "slow", -1, 33, 33, "charged", 95, 88, 8, "regen", -1, 16, 16, "regen-mana", -1, 16, 16, "nofreeze", -1, 1, 1);
			array[36] = new BaseRuneword(++BaseRuneword.ItemCount, "Exile", true, false, "pala", "", "", "", "", "", "", "", "", "VexOhmIstDol", "r26", "r27", "r24", "r14", "", "", "block2", -1, 30, 30, "freeze", -1, 1, 1, "ac%", -1, 220, 260, "aura", 104, 13, 16, "skilltab", 10, 2, 2, "hit-skill", 82, 15, 5, "rep-dur", 25, -1, -1);
			array[37] = new BaseRuneword(++BaseRuneword.ItemCount, "Faith", true, false, "miss", "", "", "", "", "", "", "", "", "OhmJahLemEld", "r27", "r31", "r20", "r02", "", "", "dmg%", -1, 280, 280, "att%", -1, 300, 300, "dmg-fire", -1, 120, 120, "res-all", -1, 15, 15, "aura", 122, 12, 15, "reanimate", 1, 10, 10, "allskills", -1, 1, 2);
			array[38] = new BaseRuneword(++BaseRuneword.ItemCount, "Famine", true, false, "axe", "hamm", "", "", "", "", "", "", "", "FalOhmOrtJah", "r19", "r27", "r09", "r31", "", "", "dmg%", -1, 270, 320, "lifesteal", -1, 12, 12, "swing2", -1, 30, 30, "noheal", -1, 1, 1, "dmg-mag", -1, 180, 200, "dmg-elem", 100, 50, 200, "ethereal", -1, 1, 1);
			array[39] = new BaseRuneword(++BaseRuneword.ItemCount, "Flame", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[40] = new BaseRuneword(++BaseRuneword.ItemCount, "Fortitude", true, false, "weap", "tors", "", "", "", "", "", "", "", "ElSolDolLo", "r01", "r12", "r14", "r28", "", "", "ac%", -1, 200, 200, "dmg%", -1, 300, 300, "cast3", -1, 25, 25, "gethit-skill", 60, 20, 15, "dmg-to-mana", -1, 12, 12, "hp/lvl", -1, 8, 12, "res-all", -1, 25, 30);
			array[41] = new BaseRuneword(++BaseRuneword.ItemCount, "Fortune", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[42] = new BaseRuneword(++BaseRuneword.ItemCount, "Friendship", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[43] = new BaseRuneword(++BaseRuneword.ItemCount, "Fury", true, false, "mele", "", "", "", "", "", "", "", "", "", "r31", "r25", "r05", "", "", "", "dmg%", -1, 209, 209, "swing2", -1, 40, 40, "noheal", -1, 1, 1, "openwounds", -1, 66, 66, "lifesteal", -1, 6, 6, "deadly", -1, 33, 33, "skill", 147, 5, 5);
			array[44] = new BaseRuneword(++BaseRuneword.ItemCount, "Gloom", true, false, "tors", "", "", "", "", "", "", "", "", "FalUmPul", "r19", "r22", "r21", "", "", "", "ac%", -1, 170, 230, "res-all", -1, 30, 30, "gethit-skill", 71, 15, 3, "balance2", -1, 10, 10, "dmg-to-mana", -1, 5, 5, "light", -1, -3, -3, "half-freeze", -1, 1, 1);
			array[45] = new BaseRuneword(++BaseRuneword.ItemCount, "Glory", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[46] = new BaseRuneword(++BaseRuneword.ItemCount, "Grief", true, false, "swor", "axe", "", "", "", "", "", "", "", "EthTirLoMalRal", "r05", "r03", "r28", "r23", "r08", "", "dmg-dem/lvl", 15, -1, -1, "dmg", -1, 340, 400, "swing3", -1, 30, 40, "hit-skill", 278, 35, 15, "pierce-pois", -1, 20, 25, "ignore-ac", -1, 1, 1, "heal-kill", -1, 10, 15);
			array[47] = new BaseRuneword(++BaseRuneword.ItemCount, "Hand of Justice", true, false, "weap", "", "", "", "", "", "", "", "", "SurChamAmnLo", "r29", "r32", "r11", "r28", "", "", "swing2", -1, 33, 33, "dmg%", -1, 280, 330, "aura", 102, 16, 16, "levelup-skill", 46, 100, 36, "death-skill", 56, 100, 48, "ignore-ac", -1, 1, 1, "pierce-fire", -1, 20, 20);
			array[48] = new BaseRuneword(++BaseRuneword.ItemCount, "Harmony", true, false, "miss", "", "", "", "", "", "", "", "", "TirIthSolKo", "r03", "r06", "r12", "r18", "", "", "dmg%", -1, 200, 275, "dmg-elem", -1, 55, 160, "charged", 95, 25, 20, "aura", 115, 10, 10, "oskill", 32, 2, 6, "regen-mana", -1, 20, 20, "light", -1, 2, 2);
			array[49] = new BaseRuneword(++BaseRuneword.ItemCount, "Hatred", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[50] = new BaseRuneword(++BaseRuneword.ItemCount, "Heart of the Oak", true, false, "staf", "mace", "", "", "", "", "", "", "", "KoVexPulThul", "r18", "r26", "r21", "r10", "", "", "cast2", -1, 40, 40, "charged", 226, 25, 4, "mana%", -1, 15, 15, "allskills", -1, 3, 3, "regen", -1, 20, 20, "res-all", -1, 30, 40, "charged", 221, 60, 14);
			array[51] = new BaseRuneword(++BaseRuneword.ItemCount, "Heaven's Will", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[52] = new BaseRuneword(++BaseRuneword.ItemCount, "Holy Tears", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[53] = new BaseRuneword(++BaseRuneword.ItemCount, "Holy Thunder", true, false, "scep", "", "", "", "", "", "", "", "", "", "r05", "r08", "r09", "r07", "", "", "dmg%", -1, 60, 60, "dmg-ltng", -1, 20, 60, "dmg-max", -1, 10, 10, "res-ltng", -1, 60, 60, "res-ltng-max", -1, 5, 5, "skill", 118, 3, 3, "charged", 53, 60, 7);
			array[54] = new BaseRuneword(++BaseRuneword.ItemCount, "Honor", true, false, "mele", "", "", "", "", "", "", "", "", "", "r11", "r01", "r06", "r03", "r12", "", "dmg%", -1, 160, 160, "regen", -1, 10, 10, "allskills", -1, 1, 1, "att", -1, 200, 200, "deadly", -1, 25, 25, "str", -1, 10, 10, "", -1, -1, -1);
			array[55] = new BaseRuneword(++BaseRuneword.ItemCount, "Revenge", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[56] = new BaseRuneword(++BaseRuneword.ItemCount, "Humility", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[57] = new BaseRuneword(++BaseRuneword.ItemCount, "Hunger", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[58] = new BaseRuneword(++BaseRuneword.ItemCount, "Ice", true, false, "miss", "", "", "", "", "", "", "", "", "AmnShaelJahLo", "r11", "r13", "r31", "r28", "", "", "dmg%", -1, 140, 210, "aura", 114, 18, 18, "extra-cold", -1, 25, 30, "hit-skill", 44, 25, 22, "levelup-skill", 59, 100, 40, "pierce-cold", -1, 20, 20, "gold%/lvl", 25, -1, -1);
			array[59] = new BaseRuneword(++BaseRuneword.ItemCount, "Infinity", true, false, "pole", "", "", "", "", "", "", "", "", "BerMalBerIst", "r30", "r23", "r30", "r24", "", "", "dmg%", -1, 255, 325, "move3", -1, 35, 35, "vit/lvl", 4, -1, -1, "aura", 123, 12, 12, "kill-skill", 53, 50, 20, "pierce-ltng", -1, 45, 55, "charged", 235, 30, 21);
			array[60] = new BaseRuneword(++BaseRuneword.ItemCount, "Innocence", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[61] = new BaseRuneword(++BaseRuneword.ItemCount, "Insight", true, false, "pole", "staf", "", "", "", "", "", "", "", "RalTirTalSol", "r08", "r03", "r07", "r12", "", "", "dmg%", -1, 200, 260, "att%", -1, 180, 250, "mag%", -1, 23, 23, "oskill", 9, 1, 6, "cast2", -1, 35, 35, "aura", 120, 12, 17, "all-stats", -1, 5, 5);
			array[62] = new BaseRuneword(++BaseRuneword.ItemCount, "Jealousy", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[63] = new BaseRuneword(++BaseRuneword.ItemCount, "Judgement", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[64] = new BaseRuneword(++BaseRuneword.ItemCount, "King's Grace", true, false, "swor", "scep", "", "", "", "", "", "", "", "", "r11", "r08", "r10", "", "", "", "dmg%", -1, 100, 100, "att", -1, 150, 150, "dmg-demon", -1, 100, 100, "dmg-undead", -1, 50, 50, "att-demon", -1, 100, 100, "att-undead", -1, 100, 100, "", -1, -1, -1);
			array[65] = new BaseRuneword(++BaseRuneword.ItemCount, "Kingslayer", true, false, "swor", "axe", "", "", "", "", "", "", "", "MalUmGulFal", "r23", "r22", "r25", "r19", "", "", "swing2", -1, 30, 30, "dmg%", -1, 230, 270, "reduce-ac", -1, 25, 25, "crush", -1, 33, 33, "openwounds", -1, 25, 25, "oskill", 111, 1, 1, "gold%", -1, 40, 40);
			array[66] = new BaseRuneword(++BaseRuneword.ItemCount, "Knight's Vigil", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[67] = new BaseRuneword(++BaseRuneword.ItemCount, "Knowledge", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[68] = new BaseRuneword(++BaseRuneword.ItemCount, "Last Wish", true, false, "swor", "hamm", "axe", "", "", "", "", "", "", "JahMalJahSurJahBer", "r31", "r23", "r31", "r29", "r31", "r30", "dmg%", -1, 330, 375, "att-skill", 38, 20, 20, "hit-skill", 82, 10, 18, "gethit-skill", 267, 6, 11, "crush", -1, 40, 50, "mag%/lvl", 4, -1, -1, "aura", 98, 17, 17);
			array[69] = new BaseRuneword(++BaseRuneword.ItemCount, "Law", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[70] = new BaseRuneword(++BaseRuneword.ItemCount, "Lawbringer", true, false, "swor", "hamm", "scep", "", "", "", "", "", "", "AmnLemKo", "r11", "r20", "r18", "", "", "", "dmg-cold", -1, 130, 180, "dmg-fire", -1, 150, 210, "aura", 119, 16, 18, "hit-skill", 87, 20, 15, "ac-miss", -1, 200, 250, "rip", -1, 1, 1, "reduce-ac", -1, 50, 50);
			array[71] = new BaseRuneword(++BaseRuneword.ItemCount, "Leaf", true, false, "staf", "", "", "", "", "", "", "", "", "", "r03", "r08", "", "", "", "", "fireskill", -1, 3, 3, "ac/lvl", -1, 16, 16, "res-cold", -1, 33, 33, "skill", 41, 3, 3, "skill", 36, 3, 3, "skill", 37, 3, 3, "", -1, -1, -1);
			array[72] = new BaseRuneword(++BaseRuneword.ItemCount, "Lightning", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[73] = new BaseRuneword(++BaseRuneword.ItemCount, "Lionheart", true, false, "tors", "", "", "", "", "", "", "", "", "", "r15", "r17", "r19", "", "", "", "str", -1, 15, 15, "vit", -1, 20, 20, "dex", -1, 15, 15, "dmg%", -1, 20, 20, "hp", -1, 50, 50, "res-all", -1, 30, 30, "", -1, -1, -1);
			array[74] = new BaseRuneword(++BaseRuneword.ItemCount, "Lore", true, false, "helm", "", "", "", "", "", "", "", "", "", "r09", "r12", "", "", "", "", "enr", -1, 10, 10, "allskills", -1, 1, 1, "light", -1, 2, 2, "mana-kill", -1, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[75] = new BaseRuneword(++BaseRuneword.ItemCount, "Love", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[76] = new BaseRuneword(++BaseRuneword.ItemCount, "Loyalty", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[77] = new BaseRuneword(++BaseRuneword.ItemCount, "Lust", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[78] = new BaseRuneword(++BaseRuneword.ItemCount, "Madness", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			BaseRuneword.ItemCount++;
			array[80] = new BaseRuneword(++BaseRuneword.ItemCount, "Malice", true, false, "mele", "", "", "", "", "", "", "", "", "", "r06", "r01", "r05", "", "", "", "openwounds", -1, 100, 100, "dmg-ac", -1, -100, -100, "noheal", -1, 1, 1, "dmg%", -1, 33, 33, "light", -1, -1, -1, "regen", -1, -5, -5, "", -1, -1, -1);
			array[81] = new BaseRuneword(++BaseRuneword.ItemCount, "Melody", true, false, "miss", "", "", "", "", "", "", "", "", "", "r13", "r18", "r04", "", "", "", "dmg%", -1, 50, 50, "skilltab", 0, 3, 3, "skill", 9, 3, 3, "skill", 13, 3, 3, "skill", 17, 3, 3, "dmg-undead", -1, 300, 300, "", -1, -1, -1);
			array[82] = new BaseRuneword(++BaseRuneword.ItemCount, "Memory", true, false, "staf", "", "", "", "", "", "", "", "", "", "r17", "r16", "r12", "r05", "", "", "mana%", -1, 20, 20, "red-mag", -1, 7, 7, "ac%", -1, 50, 50, "cast2", -1, 33, 33, "sor", -1, 3, 3, "skill", 58, 3, 3, "skill", 42, 2, 2);
			array[83] = new BaseRuneword(++BaseRuneword.ItemCount, "Mist", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[84] = new BaseRuneword(++BaseRuneword.ItemCount, "Morning", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[85] = new BaseRuneword(++BaseRuneword.ItemCount, "Mystery", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[86] = new BaseRuneword(++BaseRuneword.ItemCount, "Myth", true, false, "tors", "", "", "", "", "", "", "", "", "HelAmnNef", "r15", "r11", "r04", "", "", "", "hit-skill", 137, 10, 1, "gethit-skill", 130, 3, 1, "bar", -1, 2, 2, "regen", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[87] = new BaseRuneword(++BaseRuneword.ItemCount, "Nadir", true, false, "helm", "", "", "", "", "", "", "", "", "", "r04", "r03", "", "", "", "", "ac%", -1, 50, 50, "ac", -1, 10, 10, "light", -1, -3, -3, "charged", 264, 9, 13, "gold%", -1, -33, -33, "str", -1, 5, 5, "", -1, -1, -1);
			array[88] = new BaseRuneword(++BaseRuneword.ItemCount, "Nature's Kingdom", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[89] = new BaseRuneword(++BaseRuneword.ItemCount, "Night", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[90] = new BaseRuneword(++BaseRuneword.ItemCount, "Oath", true, false, "swor", "axe", "mace", "", "", "", "", "", "", "ShaelPulMalLum", "r13", "r21", "r23", "r17", "", "", "dmg%", -1, 210, 340, "swing1", -1, 30, 30, "hit-skill", 93, 30, 20, "charged", 90, 14, 17, "charged", 236, 20, 16, "abs-mag", -1, 10, 15, "indestruct", -1, 1, 1);
			array[91] = new BaseRuneword(++BaseRuneword.ItemCount, "Obedience", true, false, "pole", "", "", "", "", "", "", "", "", "HelKoThulEthFal", "r15", "r18", "r10", "r05", "r19", "", "dmg%", -1, 370, 370, "crush", -1, 40, 40, "kill-skill", 52, 30, 21, "pierce-fire", -1, 25, 25, "ac", -1, 200, 300, "balance3", -1, 40, 40, "res-all", -1, 20, 30);
			array[92] = new BaseRuneword(++BaseRuneword.ItemCount, "Oblivion", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[93] = new BaseRuneword(++BaseRuneword.ItemCount, "Obsession", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[94] = new BaseRuneword(++BaseRuneword.ItemCount, "Passion", true, false, "weap", "", "", "", "", "", "", "", "", "DolOrtEldLem", "r14", "r09", "r02", "r20", "", "", "dmg%", -1, 160, 210, "oskill", 106, 1, 1, "att%", -1, 50, 80, "oskill", 152, 1, 1, "swing2", -1, 25, 25, "charged", 236, 12, 3, "stupidity", -1, 10, 10);
			array[95] = new BaseRuneword(++BaseRuneword.ItemCount, "Patience", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[96] = new BaseRuneword(++BaseRuneword.ItemCount, "Pattern", true, false, "h2h", "", "", "", "", "", "", "", "", "", "r07", "r09", "r03", "", "", "", "att%", -1, 10, 10, "dmg%", -1, 40, 80, "dmg-fire", -1, 12, 32, "res-all", -1, 15, 15, "str", -1, 6, 6, "dex", -1, 6, 6, "block2", -1, 30, 30);
			array[97] = new BaseRuneword(++BaseRuneword.ItemCount, "Peace", true, false, "tors", "", "", "", "", "", "", "", "", "ShaelThulAmn", "r13", "r10", "r11", "", "", "", "hit-skill", 32, 2, 15, "gethit-skill", 17, 4, 5, "ama", -1, 2, 2, "oskill", 9, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[98] = new BaseRuneword(++BaseRuneword.ItemCount, "Voice of Reason", true, false, "swor", "mace", "", "", "", "", "", "", "", "LemKoElEld", "r20", "r18", "r01", "r02", "", "", "dmg-demon", -1, 220, 350, "dmg-undead", -1, 280, 300, "dmg-cold", -1, 100, 220, "pierce-cold", -1, 24, 24, "hit-skill", 45, 18, 20, "hit-skill", 64, 15, 13, "nofreeze", -1, 1, 1);
			array[99] = new BaseRuneword(++BaseRuneword.ItemCount, "Penitence", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[100] = new BaseRuneword(++BaseRuneword.ItemCount, "Peril", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[101] = new BaseRuneword(++BaseRuneword.ItemCount, "Pestilence", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[102] = new BaseRuneword(++BaseRuneword.ItemCount, "Phoenix", true, false, "weap", "shld", "", "", "", "", "", "", "", "VexVexLoJah", "r26", "r26", "r28", "r31", "", "", "dmg%", -1, 350, 400, "ac-miss", -1, 350, 400, "hit-skill", 225, 40, 22, "levelup-skill", 46, 100, 40, "pierce-fire", -1, 28, 28, "aura", 124, 10, 15, "abs-fire", -1, 15, 21);
			array[103] = new BaseRuneword(++BaseRuneword.ItemCount, "Piety", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[104] = new BaseRuneword(++BaseRuneword.ItemCount, "Pillar of Faith", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[105] = new BaseRuneword(++BaseRuneword.ItemCount, "Plague", true, false, "weap", "", "", "", "", "", "", "", "", "ChamFalUm", "r32", "r19", "r22", "", "", "", "dmg-demon", -1, 260, 380, "gethit-skill", 91, 20, 12, "hit-skill", 92, 25, 15, "pierce-pois", -1, 23, 23, "deadly/lvl", 3, -1, -1, "aura", 109, 13, 17, "allskills", -1, 1, 2);
			array[106] = new BaseRuneword(++BaseRuneword.ItemCount, "Praise", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[107] = new BaseRuneword(++BaseRuneword.ItemCount, "Prayer", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[108] = new BaseRuneword(++BaseRuneword.ItemCount, "Pride", true, false, "pole", "", "", "", "", "", "", "", "", "ChamSurIoLo", "r32", "r29", "r16", "r28", "", "", "dmg-dem/lvl", 8, -1, -1, "dmg-ltng", -1, 50, 280, "att%", -1, 260, 300, "aura", 113, 16, 20, "gethit-skill", 51, 25, 17, "regen", -1, 8, 8, "gold%/lvl", 15, -1, -1);
			array[109] = new BaseRuneword(++BaseRuneword.ItemCount, "Principle", true, false, "tors", "", "", "", "", "", "", "", "", "RalGulEld", "r08", "r25", "r02", "", "", "", "hit-skill", 101, 100, 5, "pal", -1, 2, 2, "hp", -1, 100, 150, "dmg-undead", -1, 50, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[110] = new BaseRuneword(++BaseRuneword.ItemCount, "Prowess in Battle", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[111] = new BaseRuneword(++BaseRuneword.ItemCount, "Prudence", true, false, "tors", "", "", "", "", "", "", "", "", "", "r23", "r03", "", "", "", "", "ac%", -1, 140, 170, "red-mag", -1, 10, 10, "red-dmg", -1, 3, 3, "res-all", -1, 25, 35, "balance2", -1, 25, 25, "rep-dur", 25, -1, -1, "light", -1, 1, 1);
			array[112] = new BaseRuneword(++BaseRuneword.ItemCount, "Punishment", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[113] = new BaseRuneword(++BaseRuneword.ItemCount, "Purity", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[114] = new BaseRuneword(++BaseRuneword.ItemCount, "Question", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[115] = new BaseRuneword(++BaseRuneword.ItemCount, "Radiance", true, false, "helm", "", "", "", "", "", "", "", "", "", "r04", "r12", "r06", "", "", "", "light", -1, 5, 5, "enr", -1, 10, 10, "vit", -1, 10, 10, "red-mag", -1, 3, 3, "mana", -1, 33, 33, "ac%", -1, 75, 75, "", -1, -1, -1);
			array[116] = new BaseRuneword(++BaseRuneword.ItemCount, "Rain", true, false, "tors", "", "", "", "", "", "", "", "", "OrtMalIth", "r09", "r23", "r06", "", "", "", "hit-skill", 240, 5, 15, "gethit-skill", 235, 5, 15, "dru", -1, 2, 2, "mana", -1, 100, 150, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[117] = new BaseRuneword(++BaseRuneword.ItemCount, "Reason", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[118] = new BaseRuneword(++BaseRuneword.ItemCount, "Red", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[119] = new BaseRuneword(++BaseRuneword.ItemCount, "Rhyme", true, false, "shld", "", "", "", "", "", "", "", "", "", "r13", "r05", "", "", "", "", "block2", -1, 20, 20, "block", -1, 20, 20, "res-all", -1, 25, 25, "nofreeze", -1, 1, 1, "gold%", -1, 50, 50, "mag%", -1, 25, 25, "", -1, -1, -1);
			array[120] = new BaseRuneword(++BaseRuneword.ItemCount, "Rift", true, false, "pole", "scep", "", "", "", "", "", "", "", "HelKoLemGul", "r15", "r18", "r20", "r25", "", "", "dmg-mag", -1, 160, 250, "dmg-fire", -1, 60, 180, "dmg-to-mana", -1, 38, 38, "hit-skill", 245, 20, 16, "att-skill", 64, 16, 21, "charged", 76, 40, 15, "all-stats", -1, 5, 10);
			array[121] = new BaseRuneword(++BaseRuneword.ItemCount, "Sanctuary", true, false, "shld", "", "", "", "", "", "", "", "", "KoKoMal", "r18", "r18", "r23", "", "", "", "block", -1, 20, 20, "block2", -1, 20, 20, "ac%", -1, 130, 160, "ac-miss", -1, 250, 250, "res-all", -1, 50, 70, "balance2", -1, 20, 20, "charged", 17, 60, 12);
			array[122] = new BaseRuneword(++BaseRuneword.ItemCount, "Serendipity", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[123] = new BaseRuneword(++BaseRuneword.ItemCount, "Shadow", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[124] = new BaseRuneword(++BaseRuneword.ItemCount, "Shadow of Doubt", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[125] = new BaseRuneword(++BaseRuneword.ItemCount, "Silence", true, false, "weap", "", "", "", "", "", "", "", "", "", "r14", "r02", "r15", "r24", "r03", "r26", "manasteal", -1, 4, 4, "stupidity", -1, 33, 33, "dmg%", -1, 200, 200, "swing2", -1, 20, 20, "res-all", -1, 75, 75, "allskills", -1, 2, 2, "balance2", -1, 20, 20);
			array[126] = new BaseRuneword(++BaseRuneword.ItemCount, "Siren's Song", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[127] = new BaseRuneword(++BaseRuneword.ItemCount, "Smoke", true, false, "tors", "", "", "", "", "", "", "", "", "", "r04", "r17", "", "", "", "", "ac-miss", -1, 250, 250, "ac%", -1, 75, 75, "res-all", -1, 50, 50, "balance2", -1, 20, 20, "light", -1, -1, -1, "charged", 72, 18, 6, "", -1, -1, -1);
			array[128] = new BaseRuneword(++BaseRuneword.ItemCount, "Sorrow", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[129] = new BaseRuneword(++BaseRuneword.ItemCount, "Spirit", true, false, "swor", "shld", "", "", "", "", "", "", "", "TalThulOrtAmn", "r07", "r10", "r09", "r11", "", "", "balance3", -1, 55, 55, "mana", -1, 89, 112, "ac-miss", -1, 250, 250, "vit", -1, 22, 22, "cast3", -1, 25, 35, "abs-mag", -1, 3, 8, "allskills", -1, 2, 2);
			array[130] = new BaseRuneword(++BaseRuneword.ItemCount, "Splendor", true, false, "shld", "", "", "", "", "", "", "", "", "", "r05", "r17", "", "", "", "", "light", -1, 3, 3, "gold%", -1, 50, 50, "mag%", -1, 20, 20, "ac%", -1, 60, 100, "block2", -1, 20, 20, "cast2", -1, 10, 10, "allskills", -1, 1, 1);
			array[131] = new BaseRuneword(++BaseRuneword.ItemCount, "Starlight", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[132] = new BaseRuneword(++BaseRuneword.ItemCount, "Stealth", true, false, "tors", "", "", "", "", "", "", "", "", "", "r07", "r05", "", "", "", "", "red-mag", -1, 3, 3, "dex", -1, 6, 6, "stam", -1, 15, 15, "move2", -1, 25, 25, "cast2", -1, 25, 25, "balance2", -1, 25, 25, "", -1, -1, -1);
			array[133] = new BaseRuneword(++BaseRuneword.ItemCount, "Steel", true, false, "swor", "axe", "mace", "", "", "", "", "", "", "", "r03", "r01", "", "", "", "", "swing2", -1, 25, 25, "dmg-min", -1, 3, 3, "dmg-max", -1, 3, 3, "openwounds", -1, 50, 50, "dmg%", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1);
			array[134] = new BaseRuneword(++BaseRuneword.ItemCount, "Still Water", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[135] = new BaseRuneword(++BaseRuneword.ItemCount, "Sting", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[136] = new BaseRuneword(++BaseRuneword.ItemCount, "Stone", true, false, "tors", "", "", "", "", "", "", "", "", "ShaelUmPulLum", "r13", "r22", "r21", "r17", "", "", "ac%", -1, 220, 260, "charged", 75, 16, 16, "ac-miss", -1, 300, 300, "charged", 229, 80, 16, "str", -1, 16, 16, "vit", -1, 16, 16, "balance2", -1, 40, 40);
			array[137] = new BaseRuneword(++BaseRuneword.ItemCount, "Storm", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[138] = new BaseRuneword(++BaseRuneword.ItemCount, "Strength", true, false, "mele", "", "", "", "", "", "", "", "", "", "r11", "r03", "", "", "", "", "str", -1, 20, 20, "dmg%", -1, 35, 35, "vit", -1, 10, 10, "crush", -1, 25, 25, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[139] = new BaseRuneword(++BaseRuneword.ItemCount, "Tempest", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[140] = new BaseRuneword(++BaseRuneword.ItemCount, "Temptation", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[141] = new BaseRuneword(++BaseRuneword.ItemCount, "Terror", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[142] = new BaseRuneword(++BaseRuneword.ItemCount, "Thirst", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[143] = new BaseRuneword(++BaseRuneword.ItemCount, "Thought", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[144] = new BaseRuneword(++BaseRuneword.ItemCount, "Thunder", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[145] = new BaseRuneword(++BaseRuneword.ItemCount, "Time", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[146] = new BaseRuneword(++BaseRuneword.ItemCount, "Tradition", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[147] = new BaseRuneword(++BaseRuneword.ItemCount, "Treachery", true, false, "tors", "", "", "", "", "", "", "", "", "ShaelThulLem", "r13", "r10", "r20", "", "", "", "hit-skill", 278, 25, 15, "gethit-skill", 267, 5, 15, "ass", -1, 2, 2, "swing2", -1, 45, 45, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[148] = new BaseRuneword(++BaseRuneword.ItemCount, "Trust", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[149] = new BaseRuneword(++BaseRuneword.ItemCount, "Truth", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[150] = new BaseRuneword(++BaseRuneword.ItemCount, "Unbending Will", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[151] = new BaseRuneword(++BaseRuneword.ItemCount, "Valor", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[152] = new BaseRuneword(++BaseRuneword.ItemCount, "Vengeance", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[153] = new BaseRuneword(++BaseRuneword.ItemCount, "Venom", true, false, "weap", "", "", "", "", "", "", "", "", "", "r07", "r14", "r23", "", "", "", "dmg-pois", 175, 312, 312, "ignore-ac", -1, 1, 1, "charged", 83, 27, 15, "charged", 92, 11, 13, "manasteal", -1, 7, 7, "", -1, -1, -1, "", -1, -1, -1);
			array[154] = new BaseRuneword(++BaseRuneword.ItemCount, "Victory", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[155] = new BaseRuneword(++BaseRuneword.ItemCount, "Voice", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[156] = new BaseRuneword(++BaseRuneword.ItemCount, "Void", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[157] = new BaseRuneword(++BaseRuneword.ItemCount, "War", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[158] = new BaseRuneword(++BaseRuneword.ItemCount, "Water", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[159] = new BaseRuneword(++BaseRuneword.ItemCount, "Wealth", true, false, "tors", "", "", "", "", "", "", "", "", "", "r20", "r18", "r03", "", "", "", "gold%", -1, 250, 250, "mag%", -1, 100, 100, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[160] = new BaseRuneword(++BaseRuneword.ItemCount, "Whisper", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[161] = new BaseRuneword(++BaseRuneword.ItemCount, "White", true, false, "wand", "", "", "", "", "", "", "", "", "", "r14", "r16", "", "", "", "", "skilltab", 7, 3, 3, "red-mag", -1, 4, 4, "cast2", -1, 20, 20, "mana", -1, 13, 13, "skill", 68, 3, 3, "skill", 84, 2, 2, "skill", 69, 4, 4);
			array[162] = new BaseRuneword(++BaseRuneword.ItemCount, "Wind", true, false, "mele", "", "", "", "", "", "", "", "", "", "r29", "r01", "", "", "", "", "dmg%", -1, 120, 160, "swing2", -1, 40, 40, "move2", -1, 20, 20, "reduce-ac", -1, 50, 50, "hit-skill", 245, 10, 9, "charged", 240, 127, 13, "balance2", -1, 15, 15);
			array[163] = new BaseRuneword(++BaseRuneword.ItemCount, "Wings of Hope", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[164] = new BaseRuneword(++BaseRuneword.ItemCount, "Wisdom", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[165] = new BaseRuneword(++BaseRuneword.ItemCount, "Woe", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[166] = new BaseRuneword(++BaseRuneword.ItemCount, "Wonder", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[167] = new BaseRuneword(++BaseRuneword.ItemCount, "Wrath", true, false, "miss", "", "", "", "", "", "", "", "", "PulLumBerMal", "r21", "r17", "r30", "r23", "", "", "dmg-demon", -1, 300, 300, "dmg-undead", -1, 250, 300, "dmg-ltng", -1, 41, 240, "dmg-mag", -1, 85, 120, "hit-skill", 82, 5, 10, "hit-skill", 87, 30, 1, "nofreeze", -1, 1, 1);
			array[168] = new BaseRuneword(++BaseRuneword.ItemCount, "Youth", false, false, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1);
			array[169] = new BaseRuneword(++BaseRuneword.ItemCount, "Zephyr", true, false, "miss", "", "", "", "", "", "", "", "", "", "r09", "r05", "", "", "", "", "move2", -1, 25, 25, "swing2", -1, 25, 25, "dmg%", -1, 33, 33, "att", -1, 66, 66, "gethit-skill", 240, 7, 1, "ac", -1, 25, 25, "", -1, -1, -1);
			BaseRuneword.items = array;
		}

		// Token: 0x04006D11 RID: 27921
		public readonly int Index;

		// Token: 0x04006D12 RID: 27922
		public readonly RunewordType Id;

		// Token: 0x04006D13 RID: 27923
		public readonly string Name;

		// Token: 0x04006D14 RID: 27924
		public readonly bool Complete;

		// Token: 0x04006D15 RID: 27925
		public readonly bool Server;

		// Token: 0x04006D16 RID: 27926
		public readonly BaseItemType IType1;

		// Token: 0x04006D17 RID: 27927
		public readonly BaseItemType IType2;

		// Token: 0x04006D18 RID: 27928
		public readonly BaseItemType IType3;

		// Token: 0x04006D19 RID: 27929
		public readonly BaseItemType IType4;

		// Token: 0x04006D1A RID: 27930
		public readonly BaseItemType IType5;

		// Token: 0x04006D1B RID: 27931
		public readonly BaseItemType IType6;

		// Token: 0x04006D1C RID: 27932
		public readonly BaseItemType EType1;

		// Token: 0x04006D1D RID: 27933
		public readonly BaseItemType EType2;

		// Token: 0x04006D1E RID: 27934
		public readonly BaseItemType EType3;

		// Token: 0x04006D1F RID: 27935
		public readonly string Runes;

		// Token: 0x04006D20 RID: 27936
		public readonly string Rune1;

		// Token: 0x04006D21 RID: 27937
		public readonly string Rune2;

		// Token: 0x04006D22 RID: 27938
		public readonly string Rune3;

		// Token: 0x04006D23 RID: 27939
		public readonly string Rune4;

		// Token: 0x04006D24 RID: 27940
		public readonly string Rune5;

		// Token: 0x04006D25 RID: 27941
		public readonly string Rune6;

		// Token: 0x04006D26 RID: 27942
		public readonly BaseProperty Property1;

		// Token: 0x04006D27 RID: 27943
		public readonly int Param1;

		// Token: 0x04006D28 RID: 27944
		public readonly int Min1;

		// Token: 0x04006D29 RID: 27945
		public readonly int Max1;

		// Token: 0x04006D2A RID: 27946
		public readonly BaseProperty Property2;

		// Token: 0x04006D2B RID: 27947
		public readonly int Param2;

		// Token: 0x04006D2C RID: 27948
		public readonly int Min2;

		// Token: 0x04006D2D RID: 27949
		public readonly int Max2;

		// Token: 0x04006D2E RID: 27950
		public readonly BaseProperty Property3;

		// Token: 0x04006D2F RID: 27951
		public readonly int Param3;

		// Token: 0x04006D30 RID: 27952
		public readonly int Min3;

		// Token: 0x04006D31 RID: 27953
		public readonly int Max3;

		// Token: 0x04006D32 RID: 27954
		public readonly BaseProperty Property4;

		// Token: 0x04006D33 RID: 27955
		public readonly int Param4;

		// Token: 0x04006D34 RID: 27956
		public readonly int Min4;

		// Token: 0x04006D35 RID: 27957
		public readonly int Max4;

		// Token: 0x04006D36 RID: 27958
		public readonly BaseProperty Property5;

		// Token: 0x04006D37 RID: 27959
		public readonly int Param5;

		// Token: 0x04006D38 RID: 27960
		public readonly int Min5;

		// Token: 0x04006D39 RID: 27961
		public readonly int Max5;

		// Token: 0x04006D3A RID: 27962
		public readonly BaseProperty Property6;

		// Token: 0x04006D3B RID: 27963
		public readonly int Param6;

		// Token: 0x04006D3C RID: 27964
		public readonly int Min6;

		// Token: 0x04006D3D RID: 27965
		public readonly int Max6;

		// Token: 0x04006D3E RID: 27966
		public readonly BaseProperty Property7;

		// Token: 0x04006D3F RID: 27967
		public readonly int Param7;

		// Token: 0x04006D40 RID: 27968
		public readonly int Min7;

		// Token: 0x04006D41 RID: 27969
		public readonly int Max7;

		// Token: 0x04006D42 RID: 27970
		private static int ItemCount = 0;

		// Token: 0x04006D43 RID: 27971
		private static BaseRuneword[] items;
	}
}
