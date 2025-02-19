﻿using System;

namespace D2Data
{
	// Token: 0x0200091E RID: 2334
	public class BaseStat
	{
		// Token: 0x0600B93D RID: 47421 RVA: 0x0033D414 File Offset: 0x0033B614
		public BaseStat(string Name, string Stat, int ID, int SendOther, int Signed, int SendBits, int SendParamBits, int UpdateAnimRate, int Saved, int CSvSigned, int CSvBits, int CSvParam, int fCallback, int fMin, int MinAccr, int Encode, int Add, int Multiply, int Divide, int ValShift, int SaveBits_1_09, int SaveAdd_1_09, int SaveBits, int SaveAdd, int SaveParamBits, int KeepZero, int Op, int OpParam, int OpBase, int OpStat1, int OpStat2, int OpStat3, int Direct, int MaxStat, int ItemSpecific, int DamageRelated, int ItemEvent1, int ItemEventFunc1, int ItemEvent2, int ItemEventFunc2, int DescPriority, int DescFunc, int DescVal, string DescStrPos, string DescStrNeg, string DescStr2, int DGrp, int DGrpFunc, int DGrpval, string DGrpStrPos, string DGrpStrNeg, int DGrpStr2, int Stuff, int SaveBits_2_5 = 0, int SaveAdd_2_5 = 0, int SendParamBits_2_6 = 0)
		{
			this.TableIndex = ID;
			this.Index = ID;
			this.Type = (StatType)ID;
			this.Name = Name;
			this.Stat = Stat;
			this.SendOther = SendOther == 1;
			this.Signed = Signed == 1;
			this.SendBits = SendBits;
			this.SendParamBits_2_6 = SendParamBits;
			this.SendParamBits = SendParamBits;
			bool flag = SendParamBits_2_6 != 0;
			if (flag)
			{
				this.SendParamBits_2_6 = SendParamBits_2_6;
			}
			this.UpdateAnimRate = UpdateAnimRate;
			this.Saved = Saved;
			this.CSvSigned = CSvSigned;
			this.CSvBits = CSvBits;
			this.CSvParam = CSvParam;
			this.fCallback = fCallback;
			this.fMin = fMin;
			this.MinAccr = MinAccr;
			this.Encode = Encode;
			this.Add = Add;
			this.Multiply = Multiply;
			this.Divide = Divide;
			this.ValShift = ValShift;
			this.SaveBits_1_09 = SaveBits_1_09;
			this.SaveAdd_1_09 = SaveAdd_1_09;
			this.SaveBits = SaveBits;
			this.SaveBits_2_5 = SaveBits;
			this.SaveAdd = SaveAdd;
			this.SaveAdd_2_5 = SaveAdd;
			bool flag2 = SaveBits_2_5 != 0;
			if (flag2)
			{
				this.SaveBits_2_5 = SaveBits_2_5;
			}
			bool flag3 = SaveAdd_2_5 != 0;
			if (flag3)
			{
				this.SaveAdd_2_5 = SaveAdd_2_5;
			}
			this.SaveParamBits = SaveParamBits;
			this.KeepZero = KeepZero == 1;
			this.Op = Op;
			this.OpParam = OpParam;
			this.OpBase = (StatType)OpBase;
			this.OpStat1 = (StatType)OpStat1;
			this.OpStat2 = (StatType)OpStat2;
			this.OpStat3 = (StatType)OpStat3;
			this.Direct = Direct == 1;
			this.MaxStat = (StatType)MaxStat;
			this.ItemSpecific = ItemSpecific == 1;
			this.DamageRelated = DamageRelated == 1;
			this.ItemEvent1 = (ItemEventType)ItemEvent1;
			this.ItemEventFunc1 = ItemEventFunc1;
			this.ItemEvent2 = (ItemEventType)ItemEvent2;
			this.ItemEventFunc2 = ItemEventFunc2;
			this.DescPriority = DescPriority;
			this.DescFunc = DescFunc;
			this.DescVal = DescVal;
			this.DescStrPos = DescStrPos;
			this.DescStrNeg = DescStrNeg;
			this.DescStr2 = DescStr2;
			this.DGrp = DGrp;
			this.DGrpFunc = DGrpFunc;
			this.DGrpval = DGrpval;
			this.DGrpStrPos = DGrpStrPos;
			this.DGrpStrNeg = DGrpStrNeg;
			this.DGrpStr2 = DGrpStr2;
			this.Stuff = Stuff;
		}

		// Token: 0x0600B93E RID: 47422 RVA: 0x0033D644 File Offset: 0x0033B844
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x0600B93F RID: 47423 RVA: 0x0033D65C File Offset: 0x0033B85C
		public static BaseStat Get(int index)
		{
			bool flag = index < 0 || BaseStat.ItemCount < index;
			if (flag)
			{
				throw new ArgumentOutOfRangeException();
			}
			return BaseStat.items[index];
		}

		// Token: 0x0600B940 RID: 47424 RVA: 0x0033D690 File Offset: 0x0033B890
		public static BaseStat Get(StatType type)
		{
			bool flag = type < StatType.Strength || BaseStat.ItemCount < (int)type;
			if (flag)
			{
				throw new ArgumentOutOfRangeException();
			}
			return BaseStat.items[(int)type];
		}

		// Token: 0x0600B941 RID: 47425 RVA: 0x0033D6C4 File Offset: 0x0033B8C4
		public static BaseStat GetByStat(string stat)
		{
			stat = stat.ToLower();
			for (int i = 0; i < BaseStat.ItemCount; i++)
			{
				bool flag = BaseStat.items[i].Stat == stat;
				if (flag)
				{
					return BaseStat.items[i];
				}
			}
			throw new ArgumentException(string.Format("No BaseStat with stat code {0} found !", stat));
		}

		// Token: 0x0600B942 RID: 47426 RVA: 0x0033D724 File Offset: 0x0033B924
		public static BaseStat GetByName(string name)
		{
			for (int i = 0; i < BaseStat.ItemCount; i++)
			{
				bool flag = BaseStat.items[i].Name == name;
				if (flag)
				{
					return BaseStat.items[i];
				}
			}
			throw new ArgumentException(string.Format("No BaseStat with name {0} found !", name));
		}

		// Token: 0x04006DA6 RID: 28070
		public readonly StatType Type;

		// Token: 0x04006DA7 RID: 28071
		public readonly int Index;

		// Token: 0x04006DA8 RID: 28072
		protected int TableIndex;

		// Token: 0x04006DA9 RID: 28073
		public readonly string Name;

		// Token: 0x04006DAA RID: 28074
		public readonly string Stat;

		// Token: 0x04006DAB RID: 28075
		public readonly bool SendOther;

		// Token: 0x04006DAC RID: 28076
		public readonly bool Signed;

		// Token: 0x04006DAD RID: 28077
		public readonly int SendBits;

		// Token: 0x04006DAE RID: 28078
		public readonly int SendParamBits;

		// Token: 0x04006DAF RID: 28079
		public readonly int SendParamBits_2_6;

		// Token: 0x04006DB0 RID: 28080
		public readonly int UpdateAnimRate;

		// Token: 0x04006DB1 RID: 28081
		public readonly int Saved;

		// Token: 0x04006DB2 RID: 28082
		public readonly int CSvSigned;

		// Token: 0x04006DB3 RID: 28083
		public readonly int CSvBits;

		// Token: 0x04006DB4 RID: 28084
		public readonly int CSvParam;

		// Token: 0x04006DB5 RID: 28085
		public readonly int fCallback;

		// Token: 0x04006DB6 RID: 28086
		public readonly int fMin;

		// Token: 0x04006DB7 RID: 28087
		public readonly int MinAccr;

		// Token: 0x04006DB8 RID: 28088
		public readonly int Encode;

		// Token: 0x04006DB9 RID: 28089
		public readonly int Add;

		// Token: 0x04006DBA RID: 28090
		public readonly int Multiply;

		// Token: 0x04006DBB RID: 28091
		public readonly int Divide;

		// Token: 0x04006DBC RID: 28092
		public readonly int ValShift;

		// Token: 0x04006DBD RID: 28093
		public readonly int SaveBits_1_09;

		// Token: 0x04006DBE RID: 28094
		public readonly int SaveAdd_1_09;

		// Token: 0x04006DBF RID: 28095
		public readonly int SaveBits_2_5;

		// Token: 0x04006DC0 RID: 28096
		public readonly int SaveAdd_2_5;

		// Token: 0x04006DC1 RID: 28097
		public readonly int SaveBits;

		// Token: 0x04006DC2 RID: 28098
		public readonly int SaveAdd;

		// Token: 0x04006DC3 RID: 28099
		public readonly int SaveParamBits;

		// Token: 0x04006DC4 RID: 28100
		public readonly bool KeepZero;

		// Token: 0x04006DC5 RID: 28101
		public readonly int Op;

		// Token: 0x04006DC6 RID: 28102
		public readonly int OpParam;

		// Token: 0x04006DC7 RID: 28103
		public readonly StatType OpBase;

		// Token: 0x04006DC8 RID: 28104
		public readonly StatType OpStat1;

		// Token: 0x04006DC9 RID: 28105
		public readonly StatType OpStat2;

		// Token: 0x04006DCA RID: 28106
		public readonly StatType OpStat3;

		// Token: 0x04006DCB RID: 28107
		public readonly bool Direct;

		// Token: 0x04006DCC RID: 28108
		public readonly StatType MaxStat;

		// Token: 0x04006DCD RID: 28109
		public readonly bool ItemSpecific;

		// Token: 0x04006DCE RID: 28110
		public readonly bool DamageRelated;

		// Token: 0x04006DCF RID: 28111
		public readonly ItemEventType ItemEvent1;

		// Token: 0x04006DD0 RID: 28112
		public readonly int ItemEventFunc1;

		// Token: 0x04006DD1 RID: 28113
		public readonly ItemEventType ItemEvent2;

		// Token: 0x04006DD2 RID: 28114
		public readonly int ItemEventFunc2;

		// Token: 0x04006DD3 RID: 28115
		public readonly int DescPriority;

		// Token: 0x04006DD4 RID: 28116
		public readonly int DescFunc;

		// Token: 0x04006DD5 RID: 28117
		public readonly int DescVal;

		// Token: 0x04006DD6 RID: 28118
		public readonly string DescStrPos;

		// Token: 0x04006DD7 RID: 28119
		public readonly string DescStrNeg;

		// Token: 0x04006DD8 RID: 28120
		public readonly string DescStr2;

		// Token: 0x04006DD9 RID: 28121
		public readonly int DGrp;

		// Token: 0x04006DDA RID: 28122
		public readonly int DGrpFunc;

		// Token: 0x04006DDB RID: 28123
		public readonly int DGrpval;

		// Token: 0x04006DDC RID: 28124
		public readonly string DGrpStrPos;

		// Token: 0x04006DDD RID: 28125
		public readonly string DGrpStrNeg;

		// Token: 0x04006DDE RID: 28126
		public readonly int DGrpStr2;

		// Token: 0x04006DDF RID: 28127
		public readonly int Stuff;

		// Token: 0x04006DE0 RID: 28128
		protected static BaseStat[] items = new BaseStat[]
		{
			new BaseStat("Strength", "strength", 0, 1, -1, 11, -1, -1, 1, 0, 10, -1, -1, 1, 1, -1, 125, 55, 1024, -1, 7, 32, 8, 32, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 67, 1, 1, "ModStr1a", "ModStr1a", "", 1, 1, 1, "Moditem2allattrib", "Moditem2allattrib", -1, 6, 0, 0, 0),
			new BaseStat("Energy", "energy", 1, -1, -1, 11, -1, -1, 1, 0, 10, -1, -1, 1, 1, -1, 100, 55, 1024, -1, 7, 32, 7, 32, -1, -1, 8, -1, -1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 61, 1, 1, "ModStr1d", "ModStr1d", "", 1, 1, 1, "Moditem2allattrib", "Moditem2allattrib", -1, -1, 0, 0, 0),
			new BaseStat("Dexterity", "dexterity", 2, 1, -1, 11, -1, -1, 1, 0, 10, -1, -1, 1, 1, -1, 125, 55, 1024, -1, 7, 32, 7, 32, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 65, 1, 1, "ModStr1b", "ModStr1b", "", 1, 1, 1, "Moditem2allattrib", "Moditem2allattrib", -1, -1, 0, 0, 0),
			new BaseStat("Vitality", "vitality", 3, -1, -1, 11, -1, -1, 1, 0, 10, -1, -1, 1, 1, -1, 100, 55, 1024, -1, 7, 32, 7, 32, -1, -1, 9, -1, -1, 7, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, 63, 1, 1, "ModStr1c", "ModStr1c", "", 1, 1, 1, "Moditem2allattrib", "Moditem2allattrib", -1, -1, 0, 0, 0),
			new BaseStat("Stat Points", "statpts", 4, -1, -1, 9, -1, -1, 1, 0, 10, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Skill Points", "newskills", 5, -1, -1, 9, -1, -1, 1, 0, 8, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Life", "hitpoints", 6, -1, -1, 32, -1, -1, 1, 0, 21, -1, -1, -1, -1, -1, -1, -1, 1024, 8, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Max Life", "maxhp", 7, -1, -1, 32, -1, -1, 1, 0, 21, -1, 1, 1, 1, -1, 56, 20, 1024, 8, 8, 32, 9, 32, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 59, 1, 1, "ModStr1u", "ModStr1u", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Mana", "mana", 8, -1, -1, 32, -1, -1, 1, 0, 21, -1, -1, -1, -1, -1, -1, -1, 1024, 8, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("MaxMana", "maxmana", 9, -1, -1, 32, -1, -1, 1, 0, 21, -1, 1, 1, 0, -1, 81, 20, 1024, 8, 8, 32, 8, 32, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 55, 1, 1, "ModStr1e", "ModStr1e", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Stamina", "stamina", 10, -1, -1, 32, -1, -1, 1, 0, 21, -1, -1, -1, -1, -1, -1, -1, 1024, 8, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Max Stamina", "maxstamina", 11, -1, -1, 32, -1, -1, 1, 0, 21, -1, 1, 1, 0, -1, 75, 20, 1024, 8, 8, 32, 8, 32, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 51, 1, 1, "ModStr5d", "ModStr5d", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Level", "level", 12, -1, -1, 9, -1, -1, 1, 0, 7, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Experience", "experience", 13, -1, -1, 32, -1, -1, 1, 0, 32, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Gold", "gold", 14, -1, -1, 32, -1, -1, 1, 0, 25, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Gold Bank", "goldbank", 15, -1, -1, 32, -1, -1, 1, 0, 25, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Defense Percent", "item_armor_percent", 16, -1, 1, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 47, 20, 1024, -1, 9, 0, 9, 0, -1, -1, 13, -1, -1, 31, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 74, 4, 1, "Modstr2v", "Modstr2v", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Max Damage Percent", "item_maxdamage_percent", 17, -1, 1, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 45, 20, 1024, -1, 9, 0, 9, 0, -1, -1, 13, -1, -1, 22, 24, 160, -1, -1, -1, 1, -1, -1, -1, -1, 129, 3, 0, "ModStr2j", "ModStr2j", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Min Damage Percent", "item_mindamage_percent", 18, -1, 1, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 45, 20, 1024, -1, 9, 0, 9, 0, -1, -1, 13, -1, -1, 21, 23, 159, -1, -1, -1, 1, -1, -1, -1, -1, 130, 3, 0, "ModStr2k", "ModStr2k", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("To Hit", "tohit", 19, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 15, 10, 1024, -1, 10, -1, 10, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 115, 1, 1, "ModStr1h", "ModStr1h", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("To Block", "toblock", 20, -1, 1, 10, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 89, 204, 1024, -1, 6, 0, 6, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 134, 2, 1, "ModStr3g", "ModStr3g", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Min Damage", "mindamage", 21, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 122, 25, 1024, -1, 6, 0, 6, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 127, 1, 1, "ModStr1g", "ModStr1g", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Max Damage", "maxdamage", 22, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 94, 16, 1024, -1, 7, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 126, 1, 1, "ModStr1f", "ModStr1f", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Secondary Min Damage", "secondary_mindamage", 23, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 97, 15, 1024, -1, 6, 0, 6, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 124, 1, 1, "ModStr1g", "ModStr1g", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Secondary Max Damage", "secondary_maxdamage", 24, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 85, 11, 1024, -1, 7, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 123, 1, 1, "ModStr1f", "ModStr1f", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Damage Percent", "damagepercent", 25, -1, 1, 12, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 45, 40, 1024, -1, 8, 0, 8, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Mana Recovery", "manarecovery", 26, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 8, 0, 8, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Mana Recovery Bonus", "manarecoverybonus", 27, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 8, 0, 8, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 52, 2, 2, "ModStr4g", "ModStr4g", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Stamina Recovery Bonus", "staminarecoverybonus", 28, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 8, 0, 8, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 48, 2, 2, "ModStr3v", "ModStr3v", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Last Experience", "lastexp", 29, -1, -1, 32, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Next Experience", "nextexp", 30, -1, -1, 32, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Armor Class", "armorclass", 31, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 17, 10, 1024, -1, 10, 10, 11, 10, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 71, 1, 1, "ModStr1i", "ModStr1i", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Armor Class Vs Missile", "armorclass_vs_missile", 32, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 11, 5, 1024, -1, 8, 0, 9, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 69, 1, 1, "ModStr6a", "ModStr6a", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Armor Class Vs Melee", "armorclass_vs_hth", 33, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 13, 7, 1024, -1, 8, 0, 8, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 70, 1, 1, "ModStr6b", "ModStr6b", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Damage Reduction", "normal_damage_reduction", 34, -1, 1, 10, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 188, 200, 1024, -1, 6, 0, 6, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 22, 3, 2, "ModStr2u", "ModStr2u", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Magic Damage Reduction", "magic_damage_reduction", 35, -1, 1, 10, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 397, 340, 1024, -1, 6, 0, 6, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 21, 3, 2, "ModStr2t", "ModStr2t", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Damage Resist", "damageresist", 36, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 152, 68, 1024, -1, 8, 0, 8, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 22, 2, 2, "ModStr2u", "ModStr2u", "", -1, -1, -1, "", "", -1, -1, 9, 200, 0),
			new BaseStat("Magic Resist", "magicresist", 37, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 164, 68, 1024, -1, 8, 0, 8, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 41, 4, 2, "ModStr1m", "ModStr1m", "", -1, -1, -1, "", "", -1, -1, 9, 200, 0),
			new BaseStat("Max Magic Resist", "maxmagicresist", 38, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1091, 409, 1024, -1, 5, 0, 5, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 46, 4, 1, "ModStr5x", "ModStr5x", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Fire Resist", "fireresist", 39, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 43, 20, 1024, -1, 8, 0, 8, 50, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 36, 4, 2, "ModStr1j", "ModStr1j", "", 2, 19, -1, "strModAllResistances", "strModAllResistances", -1, -1, 9, 200, 0),
			new BaseStat("Max Fire Resist", "maxfireresist", 40, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 584, 256, 1024, -1, 5, 0, 5, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 42, 4, 1, "ModStr5u", "ModStr5u", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Light Resist", "lightresist", 41, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 43, 20, 1024, -1, 8, 0, 8, 50, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 38, 4, 2, "ModStr1l", "ModStr1l", "", 2, 19, -1, "strModAllResistances", "strModAllResistances", -1, -1, 9, 200, 0),
			new BaseStat("Max Light Resist", "maxlightresist", 42, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 584, 256, 1024, -1, 5, 0, 5, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 43, 4, 1, "ModStr5w", "ModStr5w", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Cold Resist", "coldresist", 43, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 43, 20, 1024, -1, 8, 0, 8, 50, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 40, 4, 2, "ModStr1k", "ModStr1k", "", 2, 19, -1, "strModAllResistances", "strModAllResistances", -1, -1, 9, 200, 0),
			new BaseStat("Max Cold Resist", "maxcoldresist", 44, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 584, 256, 1024, -1, 5, 0, 5, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 44, 4, 1, "ModStr5v", "ModStr5v", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Poison Resist", "poisonresist", 45, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 43, 20, 1024, -1, 8, 0, 8, 50, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 34, 4, 2, "ModStr1n", "ModStr1n", "", 2, 19, -1, "strModAllResistances", "strModAllResistances", -1, -1, 9, 200, 0),
			new BaseStat("Max Poison Resist", "maxpoisonresist", 46, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 526, 256, 1024, -1, 5, 0, 5, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 45, 4, 1, "ModStr5y", "ModStr5y", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Damage Aura", "damageaura", 47, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Fire Min Damage", "firemindam", 48, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 11, 10, 1024, -1, 8, 0, 8, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 102, 1, 1, "ModStr1p", "ModStr1p", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Fire Max Damage", "firemaxdam", 49, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 19, 10, 1024, -1, 8, 0, 9, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 101, 1, 1, "ModStr1o", "ModStr1o", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Light Min Damage", "lightmindam", 50, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, 10, 1024, -1, 6, 0, 6, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 99, 1, 1, "ModStr1r", "ModStr1r", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Light Max Damage", "lightmaxdam", 51, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 17, 10, 1024, -1, 9, 0, 10, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 98, 1, 1, "ModStr1q", "ModStr1q", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Magic Min Damage", "magicmindam", 52, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 196, 20, 1024, -1, 6, 0, 8, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 104, 1, 1, "strModMagicDamage", "strModMagicDamage", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Magic Max Damage", "magicmaxdam", 53, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 183, 20, 1024, -1, 7, 0, 9, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 103, 1, 1, "strModMagicDamage", "strModMagicDamage", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Cold Min Damage", "coldmindam", 54, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 451, 512, 1024, -1, 6, 0, 8, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 96, 1, 1, "ModStr1t", "ModStr1t", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Cold Max Damage", "coldmaxdam", 55, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 128, 340, 1024, -1, 8, 0, 9, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 95, 1, 1, "ModStr1s", "ModStr1s", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Cold Length", "coldlength", 56, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 77, 4, 1024, -1, 8, 0, 8, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Poison Min Damage", "poisonmindam", 57, -1, 1, 19, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, 28, 1024, -1, 9, 0, 10, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 92, 1, 1, "ModStr4i", "ModStr4i", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Poison Max Damage", "poisonmaxdam", 58, -1, 1, 19, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 11, 34, 1024, -1, 9, 0, 10, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 91, 1, 1, "ModStr4h", "ModStr4h", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Poison Length", "poisonlength", 59, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 4, 1024, -1, 8, 0, 9, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Life Drain Min Damage", "lifedrainmindam", 60, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1044, 341, 1024, -1, 7, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 88, 2, 1, "ModStr2z", "ModStr2z", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Life Drain Max Damage", "lifedrainmaxdam", 61, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Mana Drain Min Damage", "manadrainmindam", 62, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1179, 341, 1024, -1, 7, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 89, 2, 1, "ModStr2y", "ModStr2y", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Mana Drain Max Damage", "manadrainmaxdam", 63, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Stam Drain Min Damage", "stamdrainmindam", 64, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Stam Drain Max Damage", "stamdrainmaxdam", 65, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Stun Length", "stunlength", 66, -1, -1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Velocity Percent", "velocitypercent", 67, 1, 1, 10, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 7, 30, 7, 30, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Attack Rate", "attackrate", 68, 1, 1, 10, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 7, 30, 7, 30, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Other Anim Rate", "other_animrate", 69, 1, 1, 10, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Quantity", "quantity", 70, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Value", "value", 71, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 8, 100, 8, 100, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Durability", "durability", 72, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 8, 0, 9, 0, -1, -1, -1, -1, -1, -1, -1, -1, 1, 73, 1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Max Durability", "maxdurability", 73, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 9, 4, 1024, -1, 8, 0, 8, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Life Regen", "hpregen", 74, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 451, 410, 1024, -1, 6, 30, 6, 30, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 56, 1, 2, "ModStr2l", "ModStr2w", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Max Durability Percent", "item_maxdurability_percent", 75, -1, 1, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 117, 10, 1024, -1, 7, 20, 7, 20, -1, -1, 13, -1, -1, 73, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 3, 2, 2, "ModStr2i", "ModStr2i", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Max Life Percent", "item_maxhp_percent", 76, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 32093, 204, 1024, -1, 6, 10, 6, 10, -1, -1, 11, -1, -1, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 58, 2, 2, "ModStr2g", "ModStr2g", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Max Mana Percent", "item_maxmana_percent", 77, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 56452, 204, 1024, -1, 6, 10, 6, 10, -1, -1, 11, -1, -1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 54, 2, 2, "ModStr2h", "ModStr2h", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Attacker Takes Damage", "item_attackertakesdamage", 78, -1, 1, 16, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, 112, 128, 1024, -1, 7, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 32, 6, -1, -1, 13, 3, 2, "ModStr1v", "ModStr1v", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Gold Find", "item_goldbonus", 79, -1, 1, 10, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 187, 34, 1024, -1, 9, 100, 9, 100, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 10, 2, 1, "ModStr1w", "ModStr1w", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Magic Find", "item_magicbonus", 80, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 577, 102, 1024, -1, 8, 100, 8, 100, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 8, 2, 1, "ModStr1x", "ModStr1x", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Knockback", "item_knockback", 81, -1, 1, 8, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, 105, 0, 1024, -1, 7, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 4, 7, 8, 7, 76, 3, 0, "ModStr1y", "ModStr1y", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Time Duration", "item_timeduration", 82, -1, 1, 10, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 9, 20, 9, 20, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Class Skills Bonus", "item_addclassskills", 83, -1, 1, 4, 3, -1, -1, -1, -1, -1, 1, -1, -1, -1, 49523, 1560, 1024, -1, 3, 0, 3, 0, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 150, 13, 1, "ModStr3a", "ModStr3a", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Unsent Param1", "unsentparam1", 84, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 3, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Add Experience", "item_addexperience", 85, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 36015, 519, 1024, -1, 3, 0, 9, 50, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 11, 4, 1, "Moditem2ExpG", "Moditem2ExpG", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Heal After Kill", "item_healafterkill", 86, -1, 1, 7, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, 30, 101, 1024, -1, 3, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 16, 28, -1, -1, 16, 1, 1, "ModitemHPaK", "ModitemHPaK", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Reduced Prices", "item_reducedprices", 87, -1, -1, 8, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 18957, 203, 1024, -1, 3, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 8, 2, 2, "ModitemRedVendP", "ModitemRedVendP", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Double Herb Duration", "item_doubleherbduration", 88, -1, 1, 2, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 1, 0, 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Light Radius", "item_lightradius", 89, -1, 1, 5, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, 15, 51, 1024, -1, 4, 4, 4, 4, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 6, 1, 1, "ModStr3f", "ModStr3f", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Light Color", "item_lightcolor", 90, -1, 1, 24, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, 155, 0, 1024, -1, 5, 0, 24, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Lower Requirements Percent", "item_req_percent", 91, -1, 1, 8, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 26, -34, 1024, -1, 8, 100, 8, 100, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 4, 2, "ModStr3h", "ModStr3h", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Lower Level Requirement", "item_levelreq", 92, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 6, 20, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Faster Attack Rate", "item_fasterattackrate", 93, 1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1042, 156, 1024, -1, 7, 20, 7, 20, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 145, 4, 1, "ModStr4m", "ModStr4m", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Lower Level Requirement Percent", "item_levelreqpct", 94, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 7, 20, 7, 64, -1, -1, 13, -1, -1, 92, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Last Block Frame", "lastblockframe", 95, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 6, 20, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Faster Move Velocity", "item_fastermovevelocity", 96, 1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4083, 156, 1024, -1, 7, 20, 7, 20, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 148, 4, 1, "ModStr4s", "ModStr4s", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Non Class Skill", "item_nonclassskill", 97, -1, 1, 15, 9, -1, -1, -1, -1, -1, 1, -1, -1, 1, 181, 327, 1024, -1, 7, 20, 6, 0, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 81, 28, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("State", "state", 98, 1, -1, 1, 8, -1, -1, -1, -1, -1, 1, -1, -1, -1, 415, 64, 1024, -1, 6, 20, 1, -1, 8, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Faster Hit Recovery", "item_fastergethitrate", 99, 1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1065, 72, 1024, -1, 7, 20, 7, 20, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 139, 4, 1, "ModStr4p", "ModStr4p", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Monster Player Count", "monster_playercount", 100, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 7, 20, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Skill Poison Override Length", "skill_poison_override_length", 101, -1, -1, 8, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 6, 20, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Faster Block Rate", "item_fasterblockrate", 102, 1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1484, 72, 1024, -1, 7, 20, 7, 20, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 136, 4, 1, "ModStr4y", "ModStr4y", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Skill Bypass Undead", "skill_bypass_undead", 103, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 7, 20, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Skill Bypass Demons", "skill_bypass_demons", 104, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 6, 20, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Faster Cast Rate", "item_fastercastrate", 105, 1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 3876, 156, 1024, -1, 7, 20, 7, 20, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 142, 4, 1, "ModStr4v", "ModStr4v", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Skill Bypass Beasts", "skill_bypass_beasts", 106, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 7, 20, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Single Skill", "item_singleskill", 107, -1, 1, 15, 9, -1, -1, -1, -1, -1, 1, -1, -1, 1, 181, 256, 1024, -1, 14, 0, 3, 0, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 81, 27, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Rest In Peace", "item_restinpeace", 108, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, 1987, 0, 1024, -1, 14, 0, 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 16, 29, -1, -1, 81, 3, 0, "ModitemSMRIP", "ModitemSMRIP", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Curse Resistance", "curse_resistance", 109, -1, -1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 159, 33, 1024, -1, 14, 0, 9, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Poison Length Reduction", "item_poisonlengthresist", 110, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 27, 10, 1024, -1, 8, 20, 8, 20, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 18, 2, 2, "ModStr3r", "ModStr3r", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Normal Damage", "item_normaldamage", 111, -1, 1, 8, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 94, 100, 1024, -1, 7, 20, 9, 20, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 122, 1, 2, "ModStr5b", "ModStr5b", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Howl", "item_howl", 112, -1, 1, 8, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, 55, 10, 1024, -1, 7, -1, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 4, 8, 8, 8, 79, 5, 2, "ModStr3u", "ModStr3u", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Hit Blinds Target", "item_stupidity", 113, -1, 1, 8, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, 332, 1024, 1024, -1, 7, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 4, 9, 8, 9, 80, 12, 2, "ModStr6d", "ModStr6d", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Damage To Mana", "item_damagetomana", 114, -1, 1, 7, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, 43, 20, 1024, -1, 6, 0, 6, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 32, 13, 64, 13, 11, 2, 1, "ModStr3w", "ModStr3w", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Ignore Target Defense", "item_ignoretargetac", 115, -1, 1, 2, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1088, 1024, 1024, -1, 1, 0, 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 119, 3, 0, "ModStr3y", "ModStr3y", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Fractional Target AC", "item_fractionaltargetac", 116, -1, 1, 8, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 67, 20, 1024, -1, 7, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 118, 20, 1, "ModStr5o", "ModStr5o", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Prevent Heal", "item_preventheal", 117, -1, 1, 8, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 48, 50, 1024, -1, 7, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 81, 3, 0, "ModStr4a", "ModStr4a", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Half Freeze Duration", "item_halffreezeduration", 118, -1, 1, 2, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 5096, 988, 1024, -1, 1, 0, 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 19, 3, 0, "ModStr4b", "ModStr4b", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("To Hit Percent", "item_tohit_percent", 119, -1, 1, 12, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 981, 40, 1024, -1, 9, 20, 9, 20, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 117, 2, 1, "ModStr4c", "ModStr4c", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Damage Target AC", "item_damagetargetac", 120, -1, 1, 8, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 24, -20, 1024, -1, 7, 128, 7, 128, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 75, 1, 1, "ModStr4d", "ModStr4d", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Demon Damage Percent", "item_demondamage_percent", 121, -1, 1, 12, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 19, 12, 1024, -1, 9, 20, 9, 20, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 112, 4, 1, "ModStr4e", "ModStr4e", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Undead Damage percent", "item_undeaddamage_percent", 122, -1, 1, 12, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 13, 12, 1024, -1, 9, 20, 9, 20, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 108, 4, 1, "ModStr4f", "ModStr4f", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Demon To Hit", "item_demon_tohit", 123, -1, 1, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 15, 7, 1024, -1, 10, 128, 10, 128, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 110, 1, 1, "ModStr4j", "ModStr4j", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Undead To Hit", "item_undead_tohit", 124, -1, 1, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 11, 7, 1024, -1, 10, 128, 10, 128, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 106, 1, 1, "ModStr4k", "ModStr4k", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Throwable", "item_throwable", 125, -1, 1, 2, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 82, 1024, 1024, -1, 1, 0, 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 5, 3, 0, "ModStr5a", "ModStr5a", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Elemental Skill Bonus", "item_elemskill", 126, -1, 1, 3, 3, -1, -1, -1, -1, -1, 1, -1, -1, -1, 76, 1024, 1024, -1, 4, 0, 3, 0, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 157, 1, 1, "ModStr3i", "ModStr3i", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("All Skills Bonus", "item_allskills", 127, -1, 1, 8, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, 15123, 4096, 1024, -1, 3, 0, 3, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 158, 1, 1, "ModStr3k", "ModStr3k", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Attacker Takes Lighting Damage", "item_attackertakeslightdamage", 128, -1, 1, 6, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, 4, 102, 1024, -1, 5, 0, 5, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 32, 10, -1, -1, 14, 3, 2, "ModStr3j", "ModStr3j", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Iron Maiden Level", "ironmaiden_level", 129, -1, 1, 10, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Life Tap Level", "lifetap_level", 130, -1, 1, 10, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Thorns Percent", "thorns_percent", 131, -1, -1, 12, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Bone Armor", "bonearmor", 132, -1, 1, 32, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Bone Armor Max", "bonearmormax", 133, -1, 1, 32, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Freeze", "item_freeze", 134, -1, 1, 5, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, 666, 12, 1024, -1, 5, 0, 5, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 4, 14, 8, 14, 78, 12, 2, "ModStr3l", "ModStr3l", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Open Wounds", "item_openwounds", 135, -1, 1, 7, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, 23, 10, 1024, -1, 7, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 4, 15, 8, 15, 83, 2, 1, "ModStr3m", "ModStr3m", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Crushing Blow", "item_crushingblow", 136, -1, 1, 7, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, 98, 40, 1024, -1, 7, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 4, 16, 8, 16, 87, 2, 1, "ModStr5c", "ModStr5c", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Kick Damage", "item_kickdamage", 137, -1, 1, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 77, 51, 1024, -1, 7, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 121, 1, 1, "ModStr5e", "ModStr5e", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Mana After Kill", "item_manaafterkill", 138, -1, 1, 7, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, 17, 102, 1024, -1, 7, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 16, 17, -1, -1, 16, 1, 1, "ModStr5f", "ModStr5f", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Heal After Demon Kill", "item_healafterdemonkill", 139, -1, 1, 7, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, 18, 102, 1024, -1, 7, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 16, 18, -1, -1, 15, 1, 1, "ModStr6c", "ModStr6c", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Extra Blood", "item_extrablood", 140, -1, 1, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 15, 10, 1024, -1, 7, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Deadly Strike", "item_deadlystrike", 141, -1, 1, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 31, 25, 1024, -1, 7, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 85, 2, 1, "ModStr5q", "ModStr5q", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Absorb Fire Percent", "item_absorbfire_percent", 142, -1, 1, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 5486, 102, 1024, -1, 7, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 23, 2, 2, "ModStr5g", "ModStr5g", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Absorb Fire", "item_absorbfire", 143, -1, 1, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1739, 204, 1024, -1, 7, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 27, 1, 1, "ModStr5h", "ModStr5h", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Absorb Lighting Percent", "item_absorblight_percent", 144, -1, 1, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 5486, 102, 1024, -1, 7, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 24, 2, 2, "ModStr5i", "ModStr5i", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Absorb Light", "item_absorblight", 145, -1, 1, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1739, 204, 1024, -1, 7, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 29, 1, 1, "ModStr5j", "ModStr5j", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Absorb Magic Percent", "item_absorbmagic_percent", 146, -1, 1, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 5486, 102, 1024, -1, 7, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 26, 2, 2, "ModStr5k", "ModStr5k", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Absorb Magic", "item_absorbmagic", 147, -1, 1, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1739, 204, 1024, -1, 7, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 33, 1, 1, "ModStr5l", "ModStr5l", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Absorb Cold Percent", "item_absorbcold_percent", 148, -1, 1, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 5486, 102, 1024, -1, 7, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 25, 2, 2, "ModStr5m", "ModStr5m", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Absorb Cold", "item_absorbcold", 149, -1, 1, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1739, 204, 1024, -1, 7, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 31, 1, 1, "ModStr5n", "ModStr5n", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Slow", "item_slow", 150, -1, 1, 7, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, 101, 40, 1024, -1, 7, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 4, 19, 8, 19, 77, 2, 2, "ModStr5r", "ModStr5r", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Aura", "item_aura", 151, -1, 1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, 1024, -1, 7, 0, 5, 0, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 159, 16, 0, "ModitemAura", "ModitemAura", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Indesctructible", "item_indesctructible", 152, -1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 7, 0, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 160, 3, 0, "ModStre9s", "ModStre9s", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Cannot Be Frozen", "item_cannotbefrozen", 153, -1, 1, 2, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 15011, 2048, 1024, -1, 1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 20, 3, 0, "ModStr5z", "ModStr5z", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Stamina Drain Percent", "item_staminadrainpct", 154, -1, 1, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 102, 20, 1024, -1, 7, 20, 7, 20, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 49, 2, 1, "ModStr6e", "ModStr6e", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Reanimate", "item_reanimate", 155, -1, -1, 7, 10, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, 1024, -1, 7, 0, 7, 0, 10, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 16, 31, -1, -1, 17, 23, 1, "Moditemreanimas", "Moditemreanimas", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Pierce", "item_pierce", 156, -1, 1, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1924, 2048, 1024, -1, 7, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 132, 3, 0, "ModStr6g", "ModStr6g", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Magic Arrow", "item_magicarrow", 157, -1, 1, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 511, 1024, 1024, -1, 7, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 131, 3, 0, "ModStr6h", "ModStr6h", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Explosive Arrow", "item_explosivearrow", 158, -1, 1, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 492, 1536, 1024, -1, 7, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 133, 3, 0, "ModStr6i", "ModStr6i", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Throw Min Damage", "item_throw_mindamage", 159, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 76, 128, 1024, -1, 6, 0, 6, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Throw Max Damage", "item_throw_maxdamage", 160, -1, 1, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 88, 128, 1024, -1, 7, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Skill Hand Of Athena", "skill_handofathena", 161, -1, 1, 12, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Skill Stamina Percent", "skill_staminapercent", 162, -1, 1, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Skill Passive Stamina Percent", "skill_passive_staminapercent", 163, -1, 1, 12, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Skill Concentration", "skill_concentration", 164, -1, 1, 12, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Skill Enchant", "skill_enchant", 165, -1, 1, 12, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Skill Pierce", "skill_pierce", 166, -1, 1, 12, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Skill Conviction", "skill_conviction", 167, -1, 1, 12, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Skill Chilling Armor", "skill_chillingarmor", 168, -1, 1, 12, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Skill Frenzy", "skill_frenzy", 169, -1, 1, 12, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Skill Decrepify", "skill_decrepify", 170, -1, 1, 12, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Skill Armor Percent", "skill_armor_percent", 171, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Alignment", "alignment", 172, 1, -1, 2, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Target 0", "target0", 173, -1, -1, 32, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Target 1", "target1", 174, -1, -1, 32, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Gold Lost", "goldlost", 175, -1, -1, 24, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Conversion Level", "conversion_level", 176, -1, -1, 8, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Conversion MaxHP", "conversion_maxhp", 177, -1, -1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Unit Do Overlay", "unit_dooverlay", 178, -1, -1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Attack Vs Monster Type", "attack_vs_montype", 179, -1, -1, 9, 10, -1, -1, -1, -1, -1, -1, -1, -1, -1, 19, 14, 1024, -1, 3, 0, 9, -1, 10, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 108, 22, 1, "ModitemAttratvsM", "ModitemAttratvsM", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Damage Vs Monster Type", "damage_vs_montype", 180, -1, -1, 9, 10, -1, -1, -1, -1, -1, -1, -1, -1, -1, 27, 17, 1024, -1, 3, 0, 9, -1, 10, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 106, 22, 1, "Moditemdamvsm", "Moditemdamvsm", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Fade", "fade", 181, 1, -1, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 14, 0, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Armor Override Percent", "armor_override_percent", 182, 1, 1, 8, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 14, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Unused 183", "unused183", 183, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 14, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Unused 184", "unused184", 184, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 14, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Unused 185", "unused185", 185, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 14, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Unused 186", "unused186", 186, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 14, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Unused 187", "unused187", 187, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 14, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Skill Tab Bonus", "item_addskill_tab", 188, -1, 1, 3, 6, -1, -1, -1, -1, -1, 1, -1, -1, -1, 11042, 768, 1024, -1, 10, 0, 3, 0, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 151, 14, -1, "StrSklTabItem1", "StrSklTabItem1", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Unused 189", "unused189", 189, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 10, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Unused 190", "unused190", 190, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 10, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Unused 191", "unused191", 191, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 10, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Unused 192", "unused192", 192, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 10, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Unused 193", "unused193", 193, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 10, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Sockets", "item_numsockets", 194, -1, 1, 4, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 38, 170, 1024, -1, 4, 0, 4, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Skill on Attack", "item_skillonattack", 195, -1, 1, 7, 16, -1, -1, -1, -1, -1, 1, -1, -1, 2, 190, 256, 1024, -1, 21, 0, 7, 0, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 1, 20, 2, 20, 160, 15, -1, "ItemExpansiveChancX", "ItemExpansiveChancX", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Skill on Kill", "item_skillonkill", 196, -1, 1, 7, 16, -1, -1, -1, -1, -1, 1, -1, -1, 2, 85, 19, 1024, -1, 21, 0, 7, 0, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 16, 20, -1, -1, 160, 15, -1, "ModitemskonKill", "ModitemskonKill", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Skill on Death", "item_skillondeath", 197, -1, 1, 7, 16, -1, -1, -1, -1, -1, 1, -1, -1, 2, 11, 9, 1024, -1, 21, 0, 7, 0, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 128, 30, -1, -1, 160, 15, -1, "Moditemskondeath", "Moditemskondeath", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Skill on Striking", "item_skillonhit", 198, -1, 1, 7, 16, -1, -1, -1, -1, -1, 1, -1, -1, 2, 190, 256, 1024, -1, 21, 0, 7, 0, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 4, 20, 8, 20, 160, 15, -1, "ItemExpansiveChanc1", "ItemExpansiveChanc1", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Skill on Level Up", "item_skillonlevelup", 199, -1, 1, 7, 16, -1, -1, -1, -1, -1, 1, -1, -1, 2, 7, 6, 1024, -1, 21, 0, 7, 0, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 256, 30, -1, -1, 160, 15, -1, "ModitemskonLevel", "ModitemskonLevel", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Unused 200", "unused200", 200, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 21, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Skill on Get Hit", "item_skillongethit", 201, -1, 1, 7, 16, -1, -1, -1, -1, -1, 1, -1, -1, 2, 190, 256, 1024, -1, 21, 0, 7, 0, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 32, 21, 64, 21, 160, 15, -1, "ItemExpansiveChanc2", "ItemExpansiveChanc2", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Unused 202", "unused202", 202, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 21, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Unused 203", "unused203", 203, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 21, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Charged Skill", "item_charged_skill", 204, -1, 1, 30, -1, -1, -1, -1, -1, -1, 1, -1, -1, 3, 401, 256, 1024, -1, 30, 0, 16, 0, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 24, -1, "ModStre10d", "ModStre10d", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Unused 204", "unused204", 205, -1, 1, 30, -1, -1, -1, -1, -1, -1, -1, -1, -1, 3, 401, 256, 1024, -1, 30, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Unused 205", "unused205", 206, -1, 1, 30, -1, -1, -1, -1, -1, -1, -1, -1, -1, 3, 401, 256, 1024, -1, 30, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Unused 206", "unused206", 207, -1, 1, 30, -1, -1, -1, -1, -1, -1, -1, -1, -1, 3, 401, 256, 1024, -1, 30, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Unused 207", "unused207", 208, -1, 1, 30, -1, -1, -1, -1, -1, -1, -1, -1, -1, 3, 401, 256, 1024, -1, 30, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Unused 208", "unused208", 209, -1, 1, 30, -1, -1, -1, -1, -1, -1, -1, -1, -1, 3, 401, 256, 1024, -1, 30, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Unused 209", "unused209", 210, -1, 1, 30, -1, -1, -1, -1, -1, -1, -1, -1, -1, 3, 401, 256, 1024, -1, 30, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Unused 210", "unused210", 211, -1, 1, 30, -1, -1, -1, -1, -1, -1, -1, -1, -1, 3, 401, 256, 1024, -1, 30, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Unused 211", "unused211", 212, -1, 1, 30, -1, -1, -1, -1, -1, -1, -1, -1, -1, 3, 401, 256, 1024, -1, 30, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Unused 212", "unused212", 213, -1, 1, 30, -1, -1, -1, -1, -1, -1, -1, -1, -1, 3, 401, 256, 1024, -1, 30, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Armor Per Level", "item_armor_perlevel", 214, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 43, 42, 1024, -1, 6, 0, 6, 0, -1, -1, 4, 3, 12, 31, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 72, 6, 1, "ModStr1i", "ModStr1i", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Armor Percent Per Level", "item_armorpercent_perlevel", 215, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 87, 100, 1024, -1, 6, 0, 6, 0, -1, -1, 5, 3, 12, 31, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 73, 8, 1, "Modstr2v", "Modstr2v", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Life Per Level", "item_hp_perlevel", 216, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 92, 64, 1024, 8, 6, 0, 6, 0, -1, -1, 2, 3, 12, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 57, 6, 1, "ModStr1u", "ModStr1u", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Mana Per Level", "item_mana_perlevel", 217, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 90, 128, 1024, 8, 6, 0, 6, 0, -1, -1, 2, 3, 12, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 53, 6, 1, "ModStr1e", "ModStr1e", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Max Damage Per Level", "item_maxdamage_perlevel", 218, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 54, 204, 1024, -1, 6, 0, 6, 0, -1, -1, 4, 3, 12, 22, 24, 160, -1, -1, -1, 1, -1, -1, -1, -1, 125, 6, 1, "ModStr1f", "ModStr1f", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Max Damage Percent Per Level", "item_maxdamage_percent_perlevel", 219, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 86, 100, 1024, -1, 6, 0, 6, 0, -1, -1, 5, 3, 12, 22, 24, 160, -1, -1, -1, 1, -1, -1, -1, -1, 128, 8, 1, "ModStr2j", "ModStr2j", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Strength Per Level", "item_strength_perlevel", 220, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 132, 128, 1024, -1, 6, 0, 6, 0, -1, -1, 2, 3, 12, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 66, 6, 1, "ModStr1a", "ModStr1a", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Dexterity Per Level", "item_dexterity_perlevel", 221, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 132, 128, 1024, -1, 6, 0, 6, 0, -1, -1, 2, 3, 12, 2, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 64, 6, 1, "ModStr1b", "ModStr1b", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Energy Per Level", "item_energy_perlevel", 222, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 105, 128, 1024, -1, 6, 0, 6, 0, -1, -1, 2, 3, 12, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 60, 6, 1, "ModStr1d", "ModStr1d", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Vitality Per Level", "item_vitality_perlevel", 223, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 105, 128, 1024, -1, 6, 0, 6, 0, -1, -1, 2, 3, 12, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 62, 6, 1, "ModStr1c", "ModStr1c", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("To Hit Per Level", "item_tohit_perlevel", 224, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 53, 20, 1024, -1, 6, 0, 6, 0, -1, -1, 2, 1, 12, 19, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 114, 6, 1, "ModStr1h", "ModStr1h", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("To Hit Percent Per Level", "item_tohitpercent_perlevel", 225, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 10, 256, 1024, -1, 6, 0, 6, 0, -1, -1, 2, 1, 12, 119, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 116, 7, 1, "ModStr4c", "ModStr4c", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Cold Damage Max Per Level", "item_cold_damagemax_perlevel", 226, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1058, 340, 1024, -1, 6, 0, 6, 0, -1, -1, 2, 3, 12, 55, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 94, 6, 1, "ModStr1s", "ModStr1s", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Fire Damage Max Per Level", "item_fire_damagemax_perlevel", 227, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 49, 128, 1024, -1, 6, 0, 6, 0, -1, -1, 2, 3, 12, 49, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 100, 6, 1, "ModStr1o", "ModStr1o", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Lightning Damage Max Per Level", "item_ltng_damagemax_perlevel", 228, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 49, 128, 1024, -1, 6, 0, 6, 0, -1, -1, 2, 3, 12, 51, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 97, 6, 1, "ModStr1q", "ModStr1q", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Poison Damage Max Per Level", "item_pois_damagemax_perlevel", 229, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 49, 128, 1024, -1, 6, 0, 6, 0, -1, -1, 2, 3, 12, 58, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 90, 6, 1, "ModStr4h", "ModStr4h", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Resist Cold Per Level", "item_resist_cold_perlevel", 230, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 101, 128, 1024, -1, 6, 0, 6, 0, -1, -1, 2, 3, 12, 43, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 39, 7, 2, "ModStr1k", "ModStr1k", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Resist Fire Per Level", "item_resist_fire_perlevel", 231, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 101, 128, 1024, -1, 6, 0, 6, 0, -1, -1, 2, 3, 12, 39, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 35, 7, 2, "ModStr1j", "ModStr1j", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Resist Lightning Per Level", "item_resist_ltng_perlevel", 232, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 101, 128, 1024, -1, 6, 0, 6, 0, -1, -1, 2, 3, 12, 41, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 37, 7, 2, "ModStr1l", "ModStr1l", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Resist Poison Per Level", "item_resist_pois_perlevel", 233, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 101, 128, 1024, -1, 6, 0, 6, 0, -1, -1, 2, 3, 12, 45, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 33, 7, 2, "ModStr1n", "ModStr1n", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Absorb Cold Per Level", "item_absorb_cold_perlevel", 234, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 207, 340, 1024, -1, 6, 0, 6, 0, -1, -1, 2, 3, 12, 149, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 32, 6, 1, "ModStre9p", "ModStre9p", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Absorb Fire Per Level", "item_absorb_fire_perlevel", 235, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 207, 340, 1024, -1, 6, 0, 6, 0, -1, -1, 2, 3, 12, 143, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 28, 6, 1, "ModStre9o", "ModStre9o", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Absorb Lightning Per Level", "item_absorb_ltng_perlevel", 236, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 207, 340, 1024, -1, 6, 0, 6, 0, -1, -1, 2, 3, 12, 145, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 30, 6, 1, "ModStre9q", "ModStre9q", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Absorb Poison Per Level", "item_absorb_pois_perlevel", 237, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 207, 340, 1024, -1, 6, 0, 6, 0, -1, -1, 2, 3, 12, 147, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Thorns Per Level", "item_thorns_perlevel", 238, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 55, 256, 1024, -1, 6, 0, 5, 0, -1, -1, 2, 3, 12, 78, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, 9, 2, "ModStr1v", "ModStr1v", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Gold Find Per Level", "item_find_gold_perlevel", 239, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 42, 256, 1024, -1, 6, 0, 6, 0, -1, -1, 2, 3, 12, 79, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 9, 7, 1, "ModStr1w", "ModStr1w", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Magic Find Per Level", "item_find_magic_perlevel", 240, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 814, 1024, 1024, -1, 6, 0, 6, 0, -1, -1, 2, 3, 12, 80, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 7, 7, 1, "ModStr1x", "ModStr1x", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Regen Stamina Per Level", "item_regenstamina_perlevel", 241, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 79, 256, 1024, -1, 6, 0, 6, 0, -1, -1, 2, 3, 12, 28, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 47, 8, 2, "ModStr3v", "ModStr3v", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Stamina Per Level", "item_stamina_perlevel", 242, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 104, 64, 1024, -1, 6, 0, 6, 0, -1, -1, 2, 3, 12, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 50, 6, 1, "ModStr5d", "ModStr5d", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Damage Demon Per Level", "item_damage_demon_perlevel", 243, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 56, 10, 1024, -1, 6, 0, 6, 0, -1, -1, 2, 3, 12, 121, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 111, 8, 1, "ModStr4e", "ModStr4e", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Damage Undead Per Level", "item_damage_undead_perlevel", 244, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 91, 10, 1024, -1, 6, 0, 6, 0, -1, -1, 2, 3, 12, 122, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 107, 8, 1, "ModStr4f", "ModStr4f", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("To Hit Demon Per Level", "item_tohit_demon_perlevel", 245, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 55, 10, 1024, -1, 6, 0, 6, 0, -1, -1, 2, 1, 12, 123, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 109, 6, 1, "ModStr4j", "ModStr4j", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("To Hit Undead Per Level", "item_tohit_undead_perlevel", 246, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, 10, 1024, -1, 6, 0, 6, 0, -1, -1, 2, 1, 12, 124, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 105, 6, 1, "ModStr4k", "ModStr4k", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Crushing Blow Per Level", "item_crushingblow_perlevel", 247, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 213, 1024, 1024, -1, 6, 0, 6, 0, -1, -1, 2, 3, 12, 136, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 86, 7, 1, "ModStr5c", "ModStr5c", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Open Wounds Per Level", "item_openwounds_perlevel", 248, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 181, 128, 1024, -1, 6, 0, 6, 0, -1, -1, 2, 3, 12, 135, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 82, 7, 1, "ModStr3m", "ModStr3m", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Kick Damage Per Level", "item_kick_damage_perlevel", 249, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 104, 128, 1024, -1, 6, 0, 6, 0, -1, -1, 2, 3, 12, 127, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 120, 6, 1, "ModStr5e", "ModStr5e", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Deadly Strike Per Level", "item_deadlystrike_perlevel", 250, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 118, 512, 1024, -1, 6, 0, 6, 0, -1, -1, 2, 3, 12, 141, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 84, 7, 1, "ModStr5q", "ModStr5q", "increaseswithplaylevelX", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Find Gems Per Level", "item_find_gems_perlevel", 251, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Replenish Durability", "item_replenish_durability", 252, -1, 1, 5, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 106, 256, 1024, -1, 5, 0, 6, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 11, 0, "ModStre9t", "ModStre9t", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Replenish Quantity", "item_replenish_quantity", 253, -1, 1, 5, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 106, 256, 1024, -1, 5, 0, 6, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 3, 0, "ModStre9v", "ModStre9v", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Extra Stack", "item_extra_stack", 254, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 99, 10, 1024, -1, 8, 0, 8, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 3, 0, "ModStre9i", "ModStre9i", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Find Item", "item_find_item", 255, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Slash Damage", "item_slash_damage", 256, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Slash Damage Percent", "item_slash_damage_percent", 257, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Crush Damage", "item_crush_damage", 258, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Crush Damage Percent", "item_crush_damage_percent", 259, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Thrust Damage", "item_thrust_damage", 260, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Thrust Damage Percent", "item_thrust_damage_percent", 261, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Absorb Slash", "item_absorb_slash", 262, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Absorb Crush", "item_absorb_crush", 263, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Absorb Thrust", "item_absorb_thrust", 264, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Absorb Slash Percent", "item_absorb_slash_percent", 265, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Absorb Crush Percent", "item_absorb_crush_percent", 266, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Absorb Thrust Percent", "item_absorb_thrust_percent", 267, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Armor By Time", "item_armor_bytime", 268, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 31, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 180, 17, 1, "ModStr1i", "ModStr1i", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Armor Percent By Time", "item_armorpercent_bytime", 269, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 7, -1, -1, 31, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 180, 18, 1, "Modstr2v", "Modstr2v", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Life By Time", "item_hp_bytime", 270, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 180, 17, 1, "ModStr1u", "ModStr1u", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Mana By Time", "item_mana_bytime", 271, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 180, 17, 1, "ModStr1e", "ModStr1e", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Max Damage By Time", "item_maxdamage_bytime", 272, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 22, 24, 160, -1, -1, -1, 1, -1, -1, -1, -1, 180, 17, 1, "ModStr1f", "ModStr1f", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Max Damage Percent By Time", "item_maxdamage_percent_bytime", 273, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 7, -1, -1, 22, 23, 159, -1, -1, -1, 1, -1, -1, -1, -1, 180, 18, 1, "ModStr2j", "ModStr2j", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Strength By Time", "item_strength_bytime", 274, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 180, 17, 1, "ModStr1a", "ModStr1a", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Dexterity By Time", "item_dexterity_bytime", 275, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 2, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 180, 17, 1, "ModStr1b", "ModStr1b", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Energy By Time", "item_energy_bytime", 276, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 180, 17, 1, "ModStr1d", "ModStr1d", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Vitality By Time", "item_vitality_bytime", 277, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 180, 17, 1, "ModStr1c", "ModStr1c", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("To Hit By Time", "item_tohit_bytime", 278, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 19, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 180, 17, 1, "ModStr1h", "ModStr1h", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("To Hit Percent By Time", "item_tohitpercent_bytime", 279, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 119, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 180, 18, 1, "ModStr4c", "ModStr4c", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Cold Max Damage By Time", "item_cold_damagemax_bytime", 280, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 55, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 180, 17, 1, "ModStr1s", "ModStr1s", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Fire Max Damage By Time", "item_fire_damagemax_bytime", 281, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 49, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 180, 17, 1, "ModStr1o", "ModStr1o", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Lightning Max Damage By Time", "item_ltng_damagemax_bytime", 282, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 51, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 180, 17, 1, "ModStr1q", "ModStr1q", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Poison Max Damage By Time", "item_pois_damagemax_bytime", 283, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 58, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 180, 17, 1, "ModStr4h", "ModStr4h", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Resist Cold By Time", "item_resist_cold_bytime", 284, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 43, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 180, 18, 2, "ModStr1k", "ModStr1k", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Resist Fire By Time", "item_resist_fire_bytime", 285, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 39, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 180, 18, 2, "ModStr1j", "ModStr1j", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Resist Lightning By Time", "item_resist_ltng_bytime", 286, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 41, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 180, 18, 2, "ModStr1l", "ModStr1l", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Resist Poison By Time", "item_resist_pois_bytime", 287, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 45, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 180, 18, 2, "ModStr1n", "ModStr1n", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Absorb Cold By Time", "item_absorb_cold_bytime", 288, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 149, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 180, 18, 1, "ModStre9p", "ModStre9p", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Absorb Fire By Time", "item_absorb_fire_bytime", 289, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 143, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 180, 18, 1, "ModStre9o", "ModStre9o", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Absorb Lightning By Time", "item_absorb_ltng_bytime", 290, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 145, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 180, 18, 1, "ModStre9q", "ModStre9q", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Absorb Poison By Time", "item_absorb_pois_bytime", 291, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 147, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Find Gold By Time", "item_find_gold_bytime", 292, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 79, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 180, 18, 2, "ModStr1w", "ModStr1w", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Find Magic By Time", "item_find_magic_bytime", 293, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 80, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 180, 18, 1, "ModStr1x", "ModStr1x", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Regen Stamina By Time", "item_regenstamina_bytime", 294, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 28, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 180, 18, 2, "ModStr3v", "ModStr3v", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Stamina By Time", "item_stamina_bytime", 295, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 180, 17, 1, "ModStr5d", "ModStr5d", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Damage Demon By Time", "item_damage_demon_bytime", 296, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 121, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 180, 18, 1, "ModStr4e", "ModStr4e", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Damage Undead By Time", "item_damage_undead_bytime", 297, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 122, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 180, 18, 1, "ModStr4f", "ModStr4f", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("To Hit Demon By Time", "item_tohit_demon_bytime", 298, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 123, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 180, 17, 1, "ModStr4j", "ModStr4j", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("To Hit Undead By Time", "item_tohit_undead_bytime", 299, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 124, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 180, 17, 1, "ModStr4k", "ModStr4k", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Crushing Blow By Time", "item_crushingblow_bytime", 300, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 136, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 180, 18, 1, "ModStr5c", "ModStr5c", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Open Wounds By Time", "item_openwounds_bytime", 301, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 135, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 180, 18, 1, "ModStr3m", "ModStr3m", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Kick Damage By Time", "item_kick_damage_bytime", 302, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 137, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 180, 17, 1, "ModStr5e", "ModStr5e", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Deadly Strike By Time", "item_deadlystrike_bytime", 303, -1, 1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, 22, 0, 22, 0, -1, -1, 6, -1, -1, 141, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 180, 18, 1, "ModStr5q", "ModStr5q", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Find Gems By Time", "item_find_gems_bytime", 304, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, -1, 0, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Pierce Cold", "item_pierce_cold", 305, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1432, 513, 1024, -1, -1, -1, 8, 50, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 88, 20, 1, "Moditemenrescoldsk", "Moditemenrescoldsk", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Pierce Fire", "item_pierce_fire", 306, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1240, 497, 1024, -1, -1, -1, 8, 50, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 88, 20, 1, "Moditemenresfiresk", "Moditemenresfiresk", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Pierce Lightning", "item_pierce_ltng", 307, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1187, 481, 1024, -1, -1, -1, 8, 50, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 88, 20, 1, "Moditemenresltngsk", "Moditemenresltngsk", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Pierce Poison", "item_pierce_pois", 308, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1322, 506, 1024, -1, -1, -1, 8, 50, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 88, 20, 1, "Moditemenrespoissk", "Moditemenrespoissk", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Damage Vs Monster", "item_damage_vs_monster", 309, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Damage Percent Vs Monster", "item_damage_percent_vs_monster", 310, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("To Hit Vs Monster", "item_tohit_vs_monster", 311, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("To Hit Percent Vs Monster", "item_tohit_percent_vs_monster", 312, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Defense Vs Monster", "item_ac_vs_monster", 313, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Defense Percent Vs Monster", "item_ac_percent_vs_monster", 314, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Fire Length", "firelength", 315, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Burning Min", "burningmin", 316, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Burning Max", "burningmax", 317, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Progressive Damage", "progressive_damage", 318, -1, 1, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Progressive Steal", "progressive_steal", 319, -1, 1, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Progressive Other", "progressive_other", 320, -1, 1, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Progressive Fire", "progressive_fire", 321, -1, 1, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Progressive Cold", "progressive_cold", 322, -1, 1, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Progressive Lightning", "progressive_lightning", 323, -1, 1, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Extra Charges", "item_extra_charges", 324, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 6, 0, 6, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Progressive To Hit", "progressive_tohit", 325, -1, 1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Poison Count", "poison_count", 326, -1, 1, 5, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Damage Framerate", "damage_framerate", 327, -1, 1, 8, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Pierce Idx", "pierce_idx", 328, -1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Passive Fire Mastery", "passive_fire_mastery", 329, -1, 1, 12, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1117, 415, 1024, -1, 8, 0, 9, 50, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 88, 4, 1, "ModitemdamFiresk", "ModitemdamFiresk", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Passive Lightning Mastery", "passive_ltng_mastery", 330, -1, 1, 12, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1054, 408, 1024, -1, 8, 0, 9, 50, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 88, 4, 1, "ModitemdamLtngsk", "ModitemdamLtngsk", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Passive Cold Mastery", "passive_cold_mastery", 331, -1, 1, 12, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1295, 379, 1024, -1, 8, 0, 9, 50, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 88, 4, 1, "ModitemdamColdsk", "ModitemdamColdsk", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Passive Poison Mastery", "passive_pois_mastery", 332, -1, 1, 12, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 978, 394, 1024, -1, 8, 0, 9, 50, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 88, 4, 1, "ModitemdamPoissk", "ModitemdamPoissk", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Passive Fire Pierce", "passive_fire_pierce", 333, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2578, 1024, -1, 8, 0, 8, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 88, 20, 1, "Moditemenresfiresk", "Moditemenresfiresk", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Passive Lightning Pierce", "passive_ltng_pierce", 334, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2493, 1024, -1, 8, 0, 8, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 88, 20, 1, "Moditemenresltngsk", "Moditemenresltngsk", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Passive Cold Pierce", "passive_cold_pierce", 335, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1984, 1024, -1, 8, 0, 8, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 88, 20, 1, "Moditemenrescoldsk", "Moditemenrescoldsk", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Passive Poison Pierce", "passive_pois_pierce", 336, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2345, 1024, -1, 8, 0, 8, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 88, 20, 1, "Moditemenrespoissk", "Moditemenrespoissk", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Passive Critical Strike", "passive_critical_strike", 337, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 8, 0, 8, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Passive Dodge", "passive_dodge", 338, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 7, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Passive Avoid", "passive_avoid", 339, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 7, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Passive Evade", "passive_evade", 340, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 7, 0, 7, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Passive Warmth", "passive_warmth", 341, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 8, 0, 8, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Passive Mastery Melee To Hit", "passive_mastery_melee_th", 342, -1, 1, 11, 8, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 8, 0, 8, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 8, 0, 16),
			new BaseStat("Passive Mastery Melee Damage", "passive_mastery_melee_dmg", 343, -1, 1, 11, 8, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 8, 0, 8, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 8, 0, 16),
			new BaseStat("Passive Mastery Melee Critical", "passive_mastery_melee_crit", 344, -1, 1, 9, 8, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 8, 0, 8, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 8, 0, 16),
			new BaseStat("Passive Mastery Throw To Hit", "passive_mastery_throw_th", 345, -1, 1, 11, 8, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 8, 0, 8, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 8, 0, 16),
			new BaseStat("Passive Mastery Throw Damage", "passive_mastery_throw_dmg", 346, -1, 1, 11, 8, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 8, 0, 8, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 8, 0, 16),
			new BaseStat("Passive Mastery Throw Critical", "passive_mastery_throw_crit", 347, -1, 1, 9, 8, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 8, 0, 8, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 8, 0, 16),
			new BaseStat("Passive Weapon Block", "passive_weaponblock", 348, -1, 1, 9, 8, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 8, 0, 8, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 8, 0, 16),
			new BaseStat("Passive Summon_resist", "passive_summon_resist", 349, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, 8, 0, 8, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Modifier List Skill", "modifierlist_skill", 350, -1, -1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Modifier List Level", "modifierlist_level", 351, -1, -1, 8, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Last Sent Life Percent", "last_sent_hp_pct", 352, -1, 1, 8, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Source Unit Type", "source_unit_type", 353, -1, -1, 5, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Source Unit ID", "source_unit_id", 354, -1, -1, 32, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Short Param 1", "shortparam1", 355, -1, -1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Quest Item Difficulty", "questitemdifficulty", 356, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1024, -1, -1, -1, 2, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Passive Magic Mastery", "passive_mag_mastery", 357, -1, 1, 12, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1211, 431, 1024, -1, 8, 0, 9, 50, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Passive Magic Pierce", "passive_mag_pierce", 358, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2812, 1024, -1, 8, 0, 8, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Skill Cooldown", "skill_cooldown", 359, -1, -1, 32, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0),
			new BaseStat("Skill Missile Damage Scale", "skill_missile_damage_scale", 360, -1, -1, 32, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", -1, -1, -1, "", "", -1, -1, 0, 0, 0)
		};

		// Token: 0x04006DE1 RID: 28129
		public static readonly int ItemCount = BaseStat.items.Length;
	}
}
