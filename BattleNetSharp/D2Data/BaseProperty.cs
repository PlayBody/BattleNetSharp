using System;

namespace D2Data
{
	// Token: 0x0200091A RID: 2330
	public class BaseProperty
	{
		// Token: 0x0600B927 RID: 47399 RVA: 0x003286FC File Offset: 0x003268FC
		public BaseProperty(int Index, string Code, bool Done, int Set1, int Val1, int Func1, int Stat1, int Set2, int Val2, int Func2, int Stat2, int Set3, int Val3, int Func3, int Stat3, int Set4, int Val4, int Func4, int Stat4, int Set5, int Val5, int Func5, int Stat5, int Set6, int Val6, int Func6, int Stat6, int Set7, int Val7, int Func7, int Stat7, string Desc, string Param, string Min, string Max)
		{
			this.Index = Index;
			this.Code = Code;
			this.Done = Done;
			this.Set1 = Set1;
			this.Val1 = Val1;
			this.Func1 = Func1;
			this.Stat1 = (StatType)Stat1;
			this.Set2 = Set2;
			this.Val2 = Val2;
			this.Func2 = Func2;
			this.Stat2 = (StatType)Stat2;
			this.Set3 = Set3;
			this.Val3 = Val3;
			this.Func3 = Func3;
			this.Stat3 = (StatType)Stat3;
			this.Set4 = Set4;
			this.Val4 = Val4;
			this.Func4 = Func4;
			this.Stat4 = (StatType)Stat4;
			this.Set5 = Set5;
			this.Val5 = Val5;
			this.Func5 = Func5;
			this.Stat5 = (StatType)Stat5;
			this.Set6 = Set6;
			this.Val6 = Val6;
			this.Func6 = Func6;
			this.Stat6 = (StatType)Stat6;
			this.Set7 = Set7;
			this.Val7 = Val7;
			this.Func7 = Func7;
			this.Stat7 = (StatType)Stat7;
			this.Desc = Desc;
			this.Param = Param;
			this.Min = Min;
			this.Max = Max;
		}

		// Token: 0x0600B928 RID: 47400 RVA: 0x00328830 File Offset: 0x00326A30
		public override string ToString()
		{
			return this.Code;
		}

		// Token: 0x0600B929 RID: 47401 RVA: 0x00328848 File Offset: 0x00326A48
		public static BaseProperty Get(int index)
		{
			bool flag = index < 0 || index >= BaseProperty.ItemCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException();
			}
			return BaseProperty.items[index];
		}

		// Token: 0x0600B92A RID: 47402 RVA: 0x00328880 File Offset: 0x00326A80
		public static BaseProperty Get(SetItemType type)
		{
			bool flag = type < SetItemType.CiverbsWard || type >= (SetItemType)BaseProperty.ItemCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException();
			}
			return BaseProperty.items[(int)type];
		}

		// Token: 0x0600B92B RID: 47403 RVA: 0x003288B8 File Offset: 0x00326AB8
		public static BaseProperty GetByCode(string code)
		{
			for (int i = 0; i < BaseProperty.ItemCount; i++)
			{
				bool flag = BaseProperty.items[i].Code == code;
				if (flag)
				{
					return BaseProperty.items[i];
				}
			}
			throw new ArgumentException(string.Format("No Property with code {0} found !", code));
		}

		// Token: 0x04006CEC RID: 27884
		public readonly int Index;

		// Token: 0x04006CED RID: 27885
		public readonly string Code;

		// Token: 0x04006CEE RID: 27886
		public readonly bool Done;

		// Token: 0x04006CEF RID: 27887
		public readonly int Set1;

		// Token: 0x04006CF0 RID: 27888
		public readonly int Val1;

		// Token: 0x04006CF1 RID: 27889
		public readonly int Func1;

		// Token: 0x04006CF2 RID: 27890
		public readonly StatType Stat1;

		// Token: 0x04006CF3 RID: 27891
		public readonly int Set2;

		// Token: 0x04006CF4 RID: 27892
		public readonly int Val2;

		// Token: 0x04006CF5 RID: 27893
		public readonly int Func2;

		// Token: 0x04006CF6 RID: 27894
		public readonly StatType Stat2;

		// Token: 0x04006CF7 RID: 27895
		public readonly int Set3;

		// Token: 0x04006CF8 RID: 27896
		public readonly int Val3;

		// Token: 0x04006CF9 RID: 27897
		public readonly int Func3;

		// Token: 0x04006CFA RID: 27898
		public readonly StatType Stat3;

		// Token: 0x04006CFB RID: 27899
		public readonly int Set4;

		// Token: 0x04006CFC RID: 27900
		public readonly int Val4;

		// Token: 0x04006CFD RID: 27901
		public readonly int Func4;

		// Token: 0x04006CFE RID: 27902
		public readonly StatType Stat4;

		// Token: 0x04006CFF RID: 27903
		public readonly int Set5;

		// Token: 0x04006D00 RID: 27904
		public readonly int Val5;

		// Token: 0x04006D01 RID: 27905
		public readonly int Func5;

		// Token: 0x04006D02 RID: 27906
		public readonly StatType Stat5;

		// Token: 0x04006D03 RID: 27907
		public readonly int Set6;

		// Token: 0x04006D04 RID: 27908
		public readonly int Val6;

		// Token: 0x04006D05 RID: 27909
		public readonly int Func6;

		// Token: 0x04006D06 RID: 27910
		public readonly StatType Stat6;

		// Token: 0x04006D07 RID: 27911
		public readonly int Set7;

		// Token: 0x04006D08 RID: 27912
		public readonly int Val7;

		// Token: 0x04006D09 RID: 27913
		public readonly int Func7;

		// Token: 0x04006D0A RID: 27914
		public readonly StatType Stat7;

		// Token: 0x04006D0B RID: 27915
		public readonly string Desc;

		// Token: 0x04006D0C RID: 27916
		public readonly string Param;

		// Token: 0x04006D0D RID: 27917
		public readonly string Min;

		// Token: 0x04006D0E RID: 27918
		public readonly string Max;

		// Token: 0x04006D0F RID: 27919
		private static int ItemCount = 0;

		// Token: 0x04006D10 RID: 27920
		private static BaseProperty[] items = new BaseProperty[]
		{
			new BaseProperty(BaseProperty.ItemCount++, "ac", true, -1, -1, 1, 31, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "ac-miss", true, -1, -1, 1, 32, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "ac-hth", true, -1, -1, 1, 33, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "red-dmg", true, -1, -1, 1, 34, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "red-dmg%", true, -1, -1, 1, 36, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "ac%", true, -1, -1, 2, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "red-mag", true, -1, -1, 1, 35, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "str", true, -1, -1, 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "dex", true, -1, -1, 1, 2, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "vit", true, -1, -1, 1, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "enr", true, -1, -1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "mana", true, -1, -1, 1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "mana%", true, -1, -1, 1, 77, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "hp", true, -1, -1, 1, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "hp%", true, -1, -1, 1, 76, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "att", true, -1, -1, 1, 19, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "block", true, -1, -1, 1, 20, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "cold-min", true, -1, -1, 1, 54, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "cold-max", true, -1, -1, 1, 55, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "cold-len", true, -1, -1, 1, 56, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "fire-min", true, -1, -1, 1, 48, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "fire-max", true, -1, -1, 1, 49, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "ltng-min", true, -1, -1, 1, 50, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "ltng-max", true, -1, -1, 1, 51, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "pois-min", true, -1, -1, 1, 57, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "pois-max", true, -1, -1, 1, 58, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "pois-len", true, -1, -1, 1, 59, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-min", true, -1, -1, 5, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-max", true, -1, -1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "dmg%", true, -1, -1, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-to-mana", true, -1, -1, 1, 114, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "res-fire", true, -1, -1, 1, 39, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "res-fire-max", true, -1, -1, 1, 40, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "res-ltng", true, -1, -1, 1, 41, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "res-ltng-max", true, -1, -1, 1, 42, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "res-cold", true, -1, -1, 1, 43, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "res-cold-max", true, -1, -1, 1, 44, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "res-mag", true, -1, -1, 1, 37, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "res-mag-max", true, -1, -1, 1, 38, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "res-pois", true, -1, -1, 1, 45, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "res-pois-max", true, -1, -1, 1, 46, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "res-all", true, -1, -1, 1, 39, -1, -1, 3, 41, -1, -1, 3, 43, -1, -1, 3, 45, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "res-all-max", true, -1, -1, 1, 40, -1, -1, 3, 42, -1, -1, 3, 44, -1, -1, 3, 46, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "abs-fire%", true, -1, -1, 1, 142, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "abs-fire", true, -1, -1, 1, 143, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "abs-ltng%", true, -1, -1, 1, 144, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "abs-ltng", true, -1, -1, 1, 145, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "abs-mag%", true, -1, -1, 1, 146, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "abs-mag", true, -1, -1, 1, 147, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "abs-cold%", true, -1, -1, 1, 148, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "abs-cold", true, -1, -1, 1, 149, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "dur", true, -1, -1, 1, 73, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "dur%", true, -1, -1, 13, 75, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "regen", true, -1, -1, 1, 74, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "thorns", true, -1, -1, 1, 78, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "swing1", true, -1, -1, 8, 93, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "swing2", true, -1, -1, 8, 93, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "swing3", true, -1, -1, 8, 93, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "gold%", true, -1, -1, 1, 79, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "mag%", true, -1, -1, 1, 80, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "knock", true, -1, -1, 1, 81, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "regen-stam", true, -1, -1, 1, 28, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "regen-mana", true, -1, -1, 1, 27, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "stam", true, -1, -1, 1, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "time", true, -1, -1, 1, 82, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "manasteal", true, -1, -1, 1, 62, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "lifesteal", true, -1, -1, 1, 60, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "ama", true, -1, 0, 21, 83, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "pal", true, -1, 3, 21, 83, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "nec", true, -1, 2, 21, 83, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "sor", true, -1, 1, 21, 83, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "bar", true, -1, 4, 21, 83, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "herb", true, -1, -1, 1, 88, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "light", true, -1, -1, 1, 89, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "color", true, 1, -1, 1, 90, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "ease", true, -1, -1, 1, 91, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "move1", true, -1, -1, 8, 96, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "move2", true, -1, -1, 8, 96, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "move3", true, -1, -1, 8, 96, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "balance1", true, -1, -1, 8, 99, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "balance2", true, -1, -1, 8, 99, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "balance3", true, -1, -1, 8, 99, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "block1", true, -1, -1, 8, 102, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "block2", true, -1, -1, 8, 102, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "block3", true, -1, -1, 8, 102, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "cast1", true, -1, -1, 8, 105, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "cast2", true, -1, -1, 8, 105, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "cast3", true, -1, -1, 8, 105, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "res-pois-len", true, -1, -1, 1, 110, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "dmg", true, -1, -1, 1, 111, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "howl", true, -1, -1, 1, 112, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "stupidity", true, -1, -1, 1, 113, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "ignore-ac", true, -1, -1, 1, 115, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "reduce-ac", true, -1, -1, 1, 116, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "noheal", true, -1, -1, 1, 117, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "half-freeze", true, -1, -1, 1, 118, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "att%", true, -1, -1, 1, 119, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-ac", true, -1, -1, 1, 120, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-demon", true, -1, -1, 1, 121, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-undead", true, -1, -1, 1, 122, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "att-demon", true, -1, -1, 1, 123, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "att-undead", true, -1, -1, 1, 124, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "throw", true, -1, -1, 1, 125, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "fireskill", true, -1, 1, 21, 126, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "allskills", true, -1, -1, 1, 127, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "light-thorns", true, -1, -1, 1, 128, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "freeze", true, -1, -1, 1, 134, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "chance in 128", "length in frames", ""),
			new BaseProperty(BaseProperty.ItemCount++, "openwounds", true, -1, -1, 1, 135, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "crush", true, -1, -1, 1, 136, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "kick", true, -1, -1, 1, 137, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "mana-kill", true, -1, -1, 1, 138, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "demon-heal", true, -1, -1, 1, 139, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "bloody", true, -1, -1, 1, 140, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "deadly", true, -1, -1, 1, 141, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "slow", true, -1, -1, 1, 150, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "nofreeze", true, -1, -1, 1, 153, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "stamdrain", true, -1, -1, 1, 154, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "reanimate", true, -1, -1, 24, 155, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "pierce", true, -1, -1, 1, 156, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "magicarrow", true, -1, -1, 1, 157, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "explosivearrow", true, -1, -1, 1, 158, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "dru", true, -1, 5, 21, 83, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "All Druid Skills", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "ass", true, -1, 6, 21, 83, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "All Assassin Skills", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "skill", true, -1, -1, 22, 107, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "skilltab", true, -1, -1, 10, 188, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "aura", true, -1, -1, 22, 151, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "att-skill", true, -1, -1, 11, 195, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Proc Skill on Swing", "Skill", "% Chance", "Level"),
			new BaseProperty(BaseProperty.ItemCount++, "hit-skill", true, -1, -1, 11, 198, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Proc Skill on Hit", "Skill", "% Chance", "Level"),
			new BaseProperty(BaseProperty.ItemCount++, "gethit-skill", true, -1, -1, 11, 201, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Proc Skill on Get Hit", "Skill", "% Chance", "Level"),
			new BaseProperty(BaseProperty.ItemCount++, "gembonus", false, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Increase chance of finding Gems", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "regen-dur", false, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "fire-fx", false, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "ltng-fx", false, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "sock", true, -1, -1, 14, 194, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-fire", true, -1, -1, 15, 48, -1, -1, 16, 49, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Fire Damage", "", "Min", "Max"),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-ltng", true, -1, -1, 15, 50, -1, -1, 16, 51, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Lightning Damage", "", "Min", "Max"),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-mag", true, -1, -1, 15, 52, -1, -1, 16, 53, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Magic Damge", "", "Min", "Max"),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-cold", true, -1, -1, 15, 54, -1, -1, 16, 55, -1, -1, 17, 56, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Cold Damage", "Length (Frames)", "Min", "Max"),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-pois", true, -1, -1, 15, 57, -1, -1, 16, 58, -1, -1, 17, 59, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Poison Damage", "Length (Frames)", "Min", "Max"),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-throw", true, -1, -1, 15, 159, -1, -1, 16, 160, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Throwing Damage", "", "Min", "Max"),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-norm", true, -1, -1, 15, 21, -1, -1, 16, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Normal Damage Modifier", "", "Min", "Max"),
			new BaseProperty(BaseProperty.ItemCount++, "ac/lvl", true, -1, -1, 17, 214, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "AC per Player Level", "ac/lvl (8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "ac%/lvl", true, -1, -1, 17, 215, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "AC% per Player Level", "ac%/lvl (8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "hp/lvl", true, -1, -1, 17, 216, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "HP per Player Level", "hp/lvl (8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "mana/lvl", true, -1, -1, 17, 217, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Mana per Player Level", "(8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "dmg/lvl", true, -1, -1, 17, 218, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Max Damage per Player Level", "(8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "dmg%/lvl", true, -1, -1, 17, 219, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Max Damage % per Player Level", "(8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "str/lvl", true, -1, -1, 17, 220, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Strength per Player Level", "(8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "dex/lvl", true, -1, -1, 17, 221, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Dexterity per Player Level", "(8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "enr/lvl", true, -1, -1, 17, 222, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Energy per Player Level", "(8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "vit/lvl", true, -1, -1, 17, 223, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Vitality per Player Level", "(8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "att/lvl", true, -1, -1, 17, 224, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Attack per Player Level", "att/lvl (1)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "att%/lvl", true, -1, -1, 17, 225, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Attack% per Player Level", "att%/lvl (8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-cold/lvl", true, -1, -1, 17, 226, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Max Cold Damage per Player Level", "(8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-fire/lvl", true, -1, -1, 17, 227, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Max Fire Damage per Player Level", "(8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-ltng/lvl", true, -1, -1, 17, 228, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Max Lightning Dmg per Player Level", "(8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-pois/lvl", true, -1, -1, 17, 229, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Max Poison Dmg per Player Level", "(8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "res-cold/lvl", true, -1, -1, 17, 230, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Resist Cold% per Player Level", "(8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "res-fire/lvl", true, -1, -1, 17, 231, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Resist Fire% per Player Level", "(8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "res-ltng/lvl", true, -1, -1, 17, 232, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Resist Lightning% per Player Level", "(8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "res-pois/lvl", true, -1, -1, 17, 233, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Resist Poison% per Player Level", "(8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "abs-cold/lvl", true, -1, -1, 17, 234, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Absorb Cold Dmg per Player Level", "(8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "abs-fire/lvl", true, -1, -1, 17, 235, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Absorb Fire Dmg per Player Level", "(8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "abs-ltng/lvl", true, -1, -1, 17, 236, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Absorb Lightning Dmg per Player Lvl", "(8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "abs-pois/lvl", true, -1, -1, 17, 237, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Absorb Poison Dmg per Player Lvl", "(8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "thorns/lvl", true, -1, -1, 17, 238, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Damage to Attacker per Player Lvl", "(8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "gold%/lvl", true, -1, -1, 17, 239, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "+% Gold Dropped per Player Lvl", "(8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "mag%/lvl", true, -1, -1, 17, 240, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "+% Magical per Player Lvl", "(8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "regen-stam/lvl", true, -1, -1, 17, 241, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "+% Stamina Regeneration per Player Lvl", "(8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "stam/lvl", true, -1, -1, 17, 242, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Stamina per Player Level", "(8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-dem/lvl", true, -1, -1, 17, 243, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Damage to Demons % per Player Level", "(8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-und/lvl", true, -1, -1, 17, 244, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Damage to Undead % per Player Level", "(8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "att-dem/lvl", true, -1, -1, 17, 245, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Attack Demons + per Player Level", "att/lvl (1)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "att-und/lvl", true, -1, -1, 17, 246, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Attack Undead + per Player Level", "att/lvl (1)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "crush/lvl", true, -1, -1, 17, 247, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "+% Chance of Crushing Blow per Player Level", "(8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "wounds/lvl", true, -1, -1, 17, 248, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "+% Chance of Open Wounds per Player Level", "(8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "kick/lvl", true, -1, -1, 17, 249, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Kick Damage per Player Level", "(8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "deadly/lvl", true, -1, -1, 17, 250, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "+% Chance of Deadly Strike per Player Level", "(8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "gems%/lvl", false, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "+% Chance of finding Gems per Player Level", "(8ths)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "rep-dur", true, -1, -1, 17, 252, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "regenerates durability", "speed (see note)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "rep-quant", true, -1, -1, 17, 253, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "regenerates quantity", "speed (see note)", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "stack", true, -1, -1, 1, 254, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Increased stack size", "", "min count", "max count"),
			new BaseProperty(BaseProperty.ItemCount++, "item%", false, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "+% Chance of finding item", "item type", "min chance", "max chance"),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-slash", false, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Slashing Damage", "", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-slash%", false, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Slashing Damage %", "", "min %", "max %"),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-crush", false, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Crush Damage", "", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-crush%", false, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Crush Damage %", "", "min %", "max %"),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-thrust", false, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Thrust Damage", "", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-thrust%", false, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Thrust Damage %", "", "min %", "max %"),
			new BaseProperty(BaseProperty.ItemCount++, "abs-slash", false, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Absorb Slashing Damage", "", "min amt", "max amt"),
			new BaseProperty(BaseProperty.ItemCount++, "abs-crush", false, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Absorb Crushing Damage", "", "min amt", "max amt"),
			new BaseProperty(BaseProperty.ItemCount++, "abs-thrust", false, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Absorb Thrusting Damage", "", "min amt", "max amt"),
			new BaseProperty(BaseProperty.ItemCount++, "abs-slash%", false, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Absorb Slashing Damage %", "", "min %", "max %"),
			new BaseProperty(BaseProperty.ItemCount++, "abs-crush%", false, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Absorb Crushing Damage %", "", "min %", "max %"),
			new BaseProperty(BaseProperty.ItemCount++, "abs-thrust%", false, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Absorb Thrusting Damage %", "", "min %", "max %"),
			new BaseProperty(BaseProperty.ItemCount++, "ac/time", true, -1, -1, 18, 268, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "AC / time increment (0=day, 1=dusk, 2=night, 3=dawn)", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "ac%/time", true, -1, -1, 18, 269, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "AC% / time increment (8 periods)", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "hp/time", true, -1, -1, 18, 270, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "HP / time increment", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "mana/time", true, -1, -1, 18, 271, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Mana / time increment", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "dmg/time", true, -1, -1, 18, 272, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Max Damage / time increment", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "dmg%/time", true, -1, -1, 18, 273, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Max Damage % / time increment", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "str/time", true, -1, -1, 18, 274, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Strength / time increment", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "dex/time", true, -1, -1, 18, 275, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Dexterity / time increment", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "enr/time", true, -1, -1, 18, 276, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Energy / time increment", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "vit/time", true, -1, -1, 18, 277, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Vitality / time increment", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "att/time", true, -1, -1, 18, 278, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "To hit / time increment", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "att%/time", true, -1, -1, 18, 279, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "To Hit % / time increment", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-cold/time", true, -1, -1, 18, 280, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Cold Damage Max / time inc.", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-fire/time", true, -1, -1, 18, 281, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Fire Damage Max / time inc.", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-ltng/time", true, -1, -1, 18, 282, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Lightning Damage Max / time inc.", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-pois/time", true, -1, -1, 18, 283, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Poison Damage Max / time inc.", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "res-cold/time", true, -1, -1, 18, 284, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Resist Cold / time inc.", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "res-fire/time", true, -1, -1, 18, 285, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Resist Fire / time inc.", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "res-ltng/time", true, -1, -1, 18, 286, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Resist Lightning / time inc", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "res-pois/time", true, -1, -1, 18, 287, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Resist Poison / time inc", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "abs-cold/time", true, -1, -1, 18, 288, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Absorb Cold / time inc.", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "abs-fire/time", true, -1, -1, 18, 289, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Absorb Fire / time inc.", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "abs-ltng/time", true, -1, -1, 18, 290, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Absorb Lightning / time inc.", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "abs-pois/time", true, -1, -1, 18, 291, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Absorb Poison / time inc.", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "gold%/time", true, -1, -1, 18, 292, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Find Gold Amt % / time inc.", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "mag%/time", true, -1, -1, 18, 293, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Find Magic % / time inc.", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "regen-stam/time", true, -1, -1, 18, 294, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "% / time inc.", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "stam/time", true, -1, -1, 18, 295, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Stamina / time inc.", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-dem/time", true, -1, -1, 18, 296, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Damage to Demons % / time inc.", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-und/time", true, -1, -1, 18, 297, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Damage to Undead % / time inc.", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "att-dem/time", true, -1, -1, 18, 298, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "To Hit Demons % / time inc.", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "att-und/time", true, -1, -1, 18, 299, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "To Hit Undead % / time inc.", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "crush/time", true, -1, -1, 18, 300, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "% chance of Crushing Blow / time inc.", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "wounds/time", true, -1, -1, 18, 301, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "+% chance of Open Wounds / time inc.", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "kick/time", true, -1, -1, 18, 302, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Kick Damage / time inc.", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "deadly/time", true, -1, -1, 18, 303, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "+% chance of Deadly Strike / time inc.", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "gems%/time", false, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "+% chance of finding Gems / time inc.", "center period", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "pierce-fire", true, -1, -1, 1, 333, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Negates % of Enemy Cold Resistance", "", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "pierce-ltng", true, -1, -1, 1, 334, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Negates % of Enemy Fire Resistance", "", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "pierce-cold", true, -1, -1, 1, 335, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Negates % of Enemy Lightning Resistance", "", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "pierce-pois", true, -1, -1, 1, 336, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Negates % of Enemy Poison Resistance", "", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-mon", false, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Damage vs. specific Monster Type", "monster", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "dmg%-mon", false, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Damage % vs. specific Monster Type", "monster", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "att-mon", false, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "To Hit vs. specific Monster Type", "monster", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "att%-mon", false, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "To Hit % vs. specific Monster Type", "monster", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "ac-mon", false, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "AC vs. specific Monster Type", "monster", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "ac%-mon", false, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "AC% vs. specific Monster Type", "monster", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "indestruct", true, -1, -1, 20, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Indestructible", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "charged", true, -1, -1, 19, 204, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Charged Skill", "Skill", "charges", "level"),
			new BaseProperty(BaseProperty.ItemCount++, "extra-fire", true, -1, -1, 1, 329, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "extra-ltng", true, -1, -1, 1, 330, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "extra-cold", true, -1, -1, 1, 331, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "extra-pois", true, -1, -1, 1, 332, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-elem", true, -1, -1, 15, 48, -1, -1, 16, 49, -1, -1, 15, 50, -1, -1, 16, 51, -1, -1, 15, 54, -1, -1, 16, 55, -1, -1, 17, 56, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-elem-min", true, -1, -1, 1, 48, -1, -1, 3, 50, -1, -1, 3, 54, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-elem-max", true, -1, -1, 1, 49, -1, -1, 3, 51, -1, -1, 3, 55, -1, -1, 17, 56, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "all-stats", true, -1, -1, 1, 0, -1, -1, 3, 1, -1, -1, 3, 2, -1, -1, 3, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "addxp", true, -1, -1, 1, 85, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "additional xp gain", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "heal-kill", true, -1, -1, 1, 86, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "life gained after each kill", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "cheap", true, -1, -1, 1, 87, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "reduces vendor prices", "", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "rip", true, -1, -1, 1, 108, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "slain monsters' corpses can't be used", "", "1", "1"),
			new BaseProperty(BaseProperty.ItemCount++, "att-mon%", true, -1, -1, 24, 179, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "attack% vs. monster type", "mon type", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "dmg-mon%", true, -1, -1, 24, 180, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "damage% vs. monster type", "mon type", "min", "max"),
			new BaseProperty(BaseProperty.ItemCount++, "kill-skill", true, -1, -1, 11, 196, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Proc Skill on killing something", "Skill", "% Chance", "Level"),
			new BaseProperty(BaseProperty.ItemCount++, "death-skill", true, -1, -1, 11, 197, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Proc Skill on getting killed", "Skill", "% Chance", "Level"),
			new BaseProperty(BaseProperty.ItemCount++, "levelup-skill", true, -1, -1, 11, 199, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Proc Skill on level up", "Skill", "% Chance", "Level"),
			new BaseProperty(BaseProperty.ItemCount++, "skill-rand", true, -1, -1, 12, 107, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Bonus to random skill", "Level", "min Skill #", "max Skill #"),
			new BaseProperty(BaseProperty.ItemCount++, "fade", true, -1, -1, 17, 181, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "only use on monprop", "fade type", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "levelreq", true, -1, -1, 1, 92, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "ethereal", true, -1, -1, 23, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", ""),
			new BaseProperty(BaseProperty.ItemCount++, "oskill", true, -1, -1, 22, 97, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "Skill", "min level", "max level"),
			new BaseProperty(BaseProperty.ItemCount++, "state", true, -1, -1, 24, 98, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "state", "1", "1"),
			new BaseProperty(BaseProperty.ItemCount++, "randclassskill", true, -1, 3, 36, 83, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "")
		};
	}
}
