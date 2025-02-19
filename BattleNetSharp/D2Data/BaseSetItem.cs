﻿using System;

namespace D2Data
{
	// Token: 0x0200091C RID: 2332
	public class BaseSetItem
	{
		// Token: 0x0600B934 RID: 47412 RVA: 0x00335554 File Offset: 0x00333754
		public BaseSetItem(int Index, string Name, string Set, string Code, int Rarity, int DropLevel, int RequiredLevel, string CharTransform, string InvTransform, string InvFile, string FlippyFile, string DropSound, int DropSfxFrame, string UseSound, int CostMultiply, int CostAdd, int AddFunc, string Property1, int Param1, int Min1, int Max1, string Property2, int Param2, int Min2, int Max2, string Property3, int Param3, int Min3, int Max3, string Property4, int Param4, int Min4, int Max4, string Property5, int Param5, int Min5, int Max5, string Property6, int Param6, int Min6, int Max6, string Property7, int Param7, int Min7, int Max7, string Property8, int Param8, int Min8, int Max8, string Property9, int Param9, int Min9, int Max9, string AProperty1a, int AParam1a, int AMin1a, int AMax1a, string AProperty1b, int AParam1b, int AMin1b, int AMax1b, string AProperty2a, int AParam2a, int AMin2a, int AMax2a, string AProperty2b, int AParam2b, int AMin2b, int AMax2b, string AProperty3a, int AParam3a, int AMin3a, int AMax3a, string AProperty3b, int AParam3b, int AMin3b, int AMax3b, string AProperty4a, int AParam4a, int AMin4a, int AMax4a, string AProperty4b, int AParam4b, int AMin4b, int AMax4b, string AProperty5a, int AParam5a, int AMin5a, int AMax5a, string AProperty5b, int AParam5b, int AMin5b, int AMax5b)
		{
			this.Index = Index;
			this.Id = (SetItemType)Index;
			this.Name = Name;
			this.Set = ItemSet.GetByName(Set);
			this.BaseItem = BaseItem.GetByCode(Code);
			this.Rarity = Rarity;
			this.DropLevel = DropLevel;
			this.RequiredLevel = RequiredLevel;
			this.CharTransform = CharTransform;
			this.InvTransform = InvTransform;
			this.InvFile = InvFile;
			this.FlippyFile = FlippyFile;
			this.DropSound = DropSound;
			this.DropSfxFrame = DropSfxFrame;
			this.UseSound = UseSound;
			this.CostMultiply = CostMultiply;
			this.CostAdd = CostAdd;
			this.AddFunc = AddFunc;
			bool flag = Property1.Length == 0;
			if (flag)
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
			bool flag2 = Property2.Length == 0;
			if (flag2)
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
			bool flag3 = Property3.Length == 0;
			if (flag3)
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
			bool flag4 = Property4.Length == 0;
			if (flag4)
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
			bool flag5 = Property5.Length == 0;
			if (flag5)
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
			bool flag6 = Property6.Length == 0;
			if (flag6)
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
			bool flag7 = Property7.Length == 0;
			if (flag7)
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
			bool flag8 = Property8.Length == 0;
			if (flag8)
			{
				this.Property8 = null;
			}
			else
			{
				this.Property8 = BaseProperty.GetByCode(Property8);
			}
			this.Param8 = Param8;
			this.Min8 = Min8;
			this.Max8 = Max8;
			bool flag9 = Property9.Length == 0;
			if (flag9)
			{
				this.Property9 = null;
			}
			else
			{
				this.Property9 = BaseProperty.GetByCode(Property9);
			}
			this.Param9 = Param9;
			this.Min9 = Min9;
			this.Max9 = Max9;
			bool flag10 = AProperty1a.Length == 0;
			if (flag10)
			{
				this.AProperty1a = null;
			}
			else
			{
				this.AProperty1a = BaseProperty.GetByCode(AProperty1a);
			}
			this.AParam1a = AParam1a;
			this.AMin1a = AMin1a;
			this.AMax1a = AMax1a;
			bool flag11 = AProperty1b.Length == 0;
			if (flag11)
			{
				this.AProperty1b = null;
			}
			else
			{
				this.AProperty1b = BaseProperty.GetByCode(AProperty1b);
			}
			this.AParam1b = AParam1b;
			this.AMin1b = AMin1b;
			this.AMax1b = AMax1b;
			bool flag12 = AProperty2a.Length == 0;
			if (flag12)
			{
				this.AProperty2a = null;
			}
			else
			{
				this.AProperty2a = BaseProperty.GetByCode(AProperty2a);
			}
			this.AParam2a = AParam2a;
			this.AMin2a = AMin2a;
			this.AMax2a = AMax2a;
			bool flag13 = AProperty2b.Length == 0;
			if (flag13)
			{
				this.AProperty2b = null;
			}
			else
			{
				this.AProperty2b = BaseProperty.GetByCode(AProperty2b);
			}
			this.AParam2b = AParam2b;
			this.AMin2b = AMin2b;
			this.AMax2b = AMax2b;
			bool flag14 = AProperty3a.Length == 0;
			if (flag14)
			{
				this.AProperty3a = null;
			}
			else
			{
				this.AProperty3a = BaseProperty.GetByCode(AProperty3a);
			}
			this.AParam3a = AParam3a;
			this.AMin3a = AMin3a;
			this.AMax3a = AMax3a;
			bool flag15 = AProperty3b.Length == 0;
			if (flag15)
			{
				this.AProperty3b = null;
			}
			else
			{
				this.AProperty3b = BaseProperty.GetByCode(AProperty3b);
			}
			this.AParam3b = AParam3b;
			this.AMin3b = AMin3b;
			this.AMax3b = AMax3b;
			bool flag16 = AProperty4a.Length == 0;
			if (flag16)
			{
				this.AProperty4a = null;
			}
			else
			{
				this.AProperty4a = BaseProperty.GetByCode(AProperty4a);
			}
			this.AParam4a = AParam4a;
			this.AMin4a = AMin4a;
			this.AMax4a = AMax4a;
			bool flag17 = AProperty4b.Length == 0;
			if (flag17)
			{
				this.AProperty4b = null;
			}
			else
			{
				this.AProperty4b = BaseProperty.GetByCode(AProperty4b);
			}
			this.AParam4b = AParam4b;
			this.AMin4b = AMin4b;
			this.AMax4b = AMax4b;
			bool flag18 = AProperty5a.Length == 0;
			if (flag18)
			{
				this.AProperty5a = null;
			}
			else
			{
				this.AProperty5a = BaseProperty.GetByCode(AProperty5a);
			}
			this.AParam5a = AParam5a;
			this.AMin5a = AMin5a;
			this.AMax5a = AMax5a;
			bool flag19 = AProperty5b.Length == 0;
			if (flag19)
			{
				this.AProperty5b = null;
			}
			else
			{
				this.AProperty5b = BaseProperty.GetByCode(AProperty5b);
			}
			this.AParam5b = AParam5b;
			this.AMin5b = AMin5b;
			this.AMax5b = AMax5b;
		}

		// Token: 0x0600B935 RID: 47413 RVA: 0x00335AE0 File Offset: 0x00333CE0
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x0600B936 RID: 47414 RVA: 0x00335AF8 File Offset: 0x00333CF8
		public static BaseSetItem Get(int index)
		{
			bool flag = index < 0 || index >= BaseSetItem.ItemCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException();
			}
			return BaseSetItem.items[index];
		}

		// Token: 0x0600B937 RID: 47415 RVA: 0x00335B30 File Offset: 0x00333D30
		public static BaseSetItem Get(SetItemType type)
		{
			bool flag = type < SetItemType.CiverbsWard || type >= (SetItemType)BaseSetItem.ItemCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException();
			}
			return BaseSetItem.items[(int)type];
		}

		// Token: 0x0600B938 RID: 47416 RVA: 0x00335B68 File Offset: 0x00333D68
		public static BaseSetItem GetByName(string name)
		{
			for (int i = 0; i < BaseSetItem.ItemCount; i++)
			{
				bool flag = BaseSetItem.items[i].Name == name;
				if (flag)
				{
					return BaseSetItem.items[i];
				}
			}
			throw new ArgumentException(string.Format("No Set Item named {0} found !", name));
		}

		// Token: 0x04006D44 RID: 27972
		public readonly int Index;

		// Token: 0x04006D45 RID: 27973
		public readonly SetItemType Id;

		// Token: 0x04006D46 RID: 27974
		public readonly string Name;

		// Token: 0x04006D47 RID: 27975
		public readonly ItemSet Set;

		// Token: 0x04006D48 RID: 27976
		public readonly BaseItem BaseItem;

		// Token: 0x04006D49 RID: 27977
		public readonly int Rarity;

		// Token: 0x04006D4A RID: 27978
		public readonly int DropLevel;

		// Token: 0x04006D4B RID: 27979
		public readonly int RequiredLevel;

		// Token: 0x04006D4C RID: 27980
		public readonly string CharTransform;

		// Token: 0x04006D4D RID: 27981
		public readonly string InvTransform;

		// Token: 0x04006D4E RID: 27982
		public readonly string InvFile;

		// Token: 0x04006D4F RID: 27983
		public readonly string FlippyFile;

		// Token: 0x04006D50 RID: 27984
		public readonly string DropSound;

		// Token: 0x04006D51 RID: 27985
		public readonly int DropSfxFrame;

		// Token: 0x04006D52 RID: 27986
		public readonly string UseSound;

		// Token: 0x04006D53 RID: 27987
		public readonly int CostMultiply;

		// Token: 0x04006D54 RID: 27988
		public readonly int CostAdd;

		// Token: 0x04006D55 RID: 27989
		public readonly int AddFunc;

		// Token: 0x04006D56 RID: 27990
		public readonly BaseProperty Property1;

		// Token: 0x04006D57 RID: 27991
		public readonly int Param1;

		// Token: 0x04006D58 RID: 27992
		public readonly int Min1;

		// Token: 0x04006D59 RID: 27993
		public readonly int Max1;

		// Token: 0x04006D5A RID: 27994
		public readonly BaseProperty Property2;

		// Token: 0x04006D5B RID: 27995
		public readonly int Param2;

		// Token: 0x04006D5C RID: 27996
		public readonly int Min2;

		// Token: 0x04006D5D RID: 27997
		public readonly int Max2;

		// Token: 0x04006D5E RID: 27998
		public readonly BaseProperty Property3;

		// Token: 0x04006D5F RID: 27999
		public readonly int Param3;

		// Token: 0x04006D60 RID: 28000
		public readonly int Min3;

		// Token: 0x04006D61 RID: 28001
		public readonly int Max3;

		// Token: 0x04006D62 RID: 28002
		public readonly BaseProperty Property4;

		// Token: 0x04006D63 RID: 28003
		public readonly int Param4;

		// Token: 0x04006D64 RID: 28004
		public readonly int Min4;

		// Token: 0x04006D65 RID: 28005
		public readonly int Max4;

		// Token: 0x04006D66 RID: 28006
		public readonly BaseProperty Property5;

		// Token: 0x04006D67 RID: 28007
		public readonly int Param5;

		// Token: 0x04006D68 RID: 28008
		public readonly int Min5;

		// Token: 0x04006D69 RID: 28009
		public readonly int Max5;

		// Token: 0x04006D6A RID: 28010
		public readonly BaseProperty Property6;

		// Token: 0x04006D6B RID: 28011
		public readonly int Param6;

		// Token: 0x04006D6C RID: 28012
		public readonly int Min6;

		// Token: 0x04006D6D RID: 28013
		public readonly int Max6;

		// Token: 0x04006D6E RID: 28014
		public readonly BaseProperty Property7;

		// Token: 0x04006D6F RID: 28015
		public readonly int Param7;

		// Token: 0x04006D70 RID: 28016
		public readonly int Min7;

		// Token: 0x04006D71 RID: 28017
		public readonly int Max7;

		// Token: 0x04006D72 RID: 28018
		public readonly BaseProperty Property8;

		// Token: 0x04006D73 RID: 28019
		public readonly int Param8;

		// Token: 0x04006D74 RID: 28020
		public readonly int Min8;

		// Token: 0x04006D75 RID: 28021
		public readonly int Max8;

		// Token: 0x04006D76 RID: 28022
		public readonly BaseProperty Property9;

		// Token: 0x04006D77 RID: 28023
		public readonly int Param9;

		// Token: 0x04006D78 RID: 28024
		public readonly int Min9;

		// Token: 0x04006D79 RID: 28025
		public readonly int Max9;

		// Token: 0x04006D7A RID: 28026
		public readonly BaseProperty AProperty1a;

		// Token: 0x04006D7B RID: 28027
		public readonly int AParam1a;

		// Token: 0x04006D7C RID: 28028
		public readonly int AMin1a;

		// Token: 0x04006D7D RID: 28029
		public readonly int AMax1a;

		// Token: 0x04006D7E RID: 28030
		public readonly BaseProperty AProperty1b;

		// Token: 0x04006D7F RID: 28031
		public readonly int AParam1b;

		// Token: 0x04006D80 RID: 28032
		public readonly int AMin1b;

		// Token: 0x04006D81 RID: 28033
		public readonly int AMax1b;

		// Token: 0x04006D82 RID: 28034
		public readonly BaseProperty AProperty2a;

		// Token: 0x04006D83 RID: 28035
		public readonly int AParam2a;

		// Token: 0x04006D84 RID: 28036
		public readonly int AMin2a;

		// Token: 0x04006D85 RID: 28037
		public readonly int AMax2a;

		// Token: 0x04006D86 RID: 28038
		public readonly BaseProperty AProperty2b;

		// Token: 0x04006D87 RID: 28039
		public readonly int AParam2b;

		// Token: 0x04006D88 RID: 28040
		public readonly int AMin2b;

		// Token: 0x04006D89 RID: 28041
		public readonly int AMax2b;

		// Token: 0x04006D8A RID: 28042
		public readonly BaseProperty AProperty3a;

		// Token: 0x04006D8B RID: 28043
		public readonly int AParam3a;

		// Token: 0x04006D8C RID: 28044
		public readonly int AMin3a;

		// Token: 0x04006D8D RID: 28045
		public readonly int AMax3a;

		// Token: 0x04006D8E RID: 28046
		public readonly BaseProperty AProperty3b;

		// Token: 0x04006D8F RID: 28047
		public readonly int AParam3b;

		// Token: 0x04006D90 RID: 28048
		public readonly int AMin3b;

		// Token: 0x04006D91 RID: 28049
		public readonly int AMax3b;

		// Token: 0x04006D92 RID: 28050
		public readonly BaseProperty AProperty4a;

		// Token: 0x04006D93 RID: 28051
		public readonly int AParam4a;

		// Token: 0x04006D94 RID: 28052
		public readonly int AMin4a;

		// Token: 0x04006D95 RID: 28053
		public readonly int AMax4a;

		// Token: 0x04006D96 RID: 28054
		public readonly BaseProperty AProperty4b;

		// Token: 0x04006D97 RID: 28055
		public readonly int AParam4b;

		// Token: 0x04006D98 RID: 28056
		public readonly int AMin4b;

		// Token: 0x04006D99 RID: 28057
		public readonly int AMax4b;

		// Token: 0x04006D9A RID: 28058
		public readonly BaseProperty AProperty5a;

		// Token: 0x04006D9B RID: 28059
		public readonly int AParam5a;

		// Token: 0x04006D9C RID: 28060
		public readonly int AMin5a;

		// Token: 0x04006D9D RID: 28061
		public readonly int AMax5a;

		// Token: 0x04006D9E RID: 28062
		public readonly BaseProperty AProperty5b;

		// Token: 0x04006D9F RID: 28063
		public readonly int AParam5b;

		// Token: 0x04006DA0 RID: 28064
		public readonly int AMin5b;

		// Token: 0x04006DA1 RID: 28065
		public readonly int AMax5b;

		// Token: 0x04006DA2 RID: 28066
		private static int ItemCount = 0;

		// Token: 0x04006DA3 RID: 28067
		private static BaseSetItem[] items = new BaseSetItem[]
		{
			new BaseSetItem(BaseSetItem.ItemCount++, "Civerb's Ward", "Civerb's Vestments", "lrg", 7, 13, 9, "lyel", "lyel", "", "", "", -1, "", 5, 2500, 1, "ac", -1, 15, 15, "block", -1, 15, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "mana", -1, 21, 22, "", -1, -1, -1, "res-pois", -1, 25, 26, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Civerb's Icon", "Civerb's Vestments", "amu", 7, 13, 9, "lyel", "lyel", "", "", "", -1, "", 5, 2500, 2, "regen-mana", -1, 40, 40, "regen", -1, 4, 4, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "res-cold", -1, 25, 25, "", -1, -1, -1, "ac", -1, 25, 25, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Civerb's Cudgel", "Civerb's Vestments", "gsc", 7, 13, 9, "lyel", "lyel", "", "", "", -1, "", 5, 2500, -1, "att", -1, 75, 75, "dmg-max", -1, 17, 23, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "dmg/lvl", 8, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Hsarus' Iron Heel", "Hsarus' Defense", "mbt", 7, 4, 3, "dred", "dred", "", "", "", -1, "", 5, 2500, 2, "res-fire", -1, 25, 25, "move2", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "att/lvl", 20, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Hsarus' Iron Fist", "Hsarus' Defense", "buc", 7, 4, 3, "dred", "dred", "", "", "", -1, "", 5, 2500, 2, "red-dmg", -1, 2, 2, "str", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "ac/lvl", 20, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Hsarus' Iron Stay", "Hsarus' Defense", "mbl", 7, 4, 3, "dred", "dred", "", "", "", -1, "", 5, 2500, 2, "res-cold", -1, 20, 20, "hp", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "ac/lvl", 20, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Cleglaw's Tooth", "Cleglaw's Brace", "lsd", 7, 6, 4, "lred", "lred", "", "", "", -1, "", 5, 2500, 2, "att%", -1, 30, 30, "deadly", -1, 50, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "dmg/lvl", 10, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Cleglaw's Claw", "Cleglaw's Brace", "sml", 7, 6, 4, "lred", "lred", "", "", "", -1, "", 5, 2500, 2, "ac", -1, 17, 17, "res-pois-len", -1, 75, 75, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "res-all", -1, 15, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Cleglaw's Pincers", "Cleglaw's Brace", "mgl", 7, 6, 4, "lred", "lred", "", "", "", -1, "", 5, 2500, 2, "knock", -1, 1, 1, "slow", -1, 25, 25, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "att/lvl", 20, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Iratha's Collar", "Iratha's Finery", "amu", 7, 21, 15, "lgry", "lgry", "", "", "", -1, "", 5, 2500, 2, "res-pois", -1, 30, 30, "res-pois-len", -1, 75, 75, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "res-all", -1, 15, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Iratha's Cuff", "Iratha's Finery", "tgl", 7, 21, 15, "lgry", "lgry", "", "", "", -1, "", 5, 2500, 2, "res-cold", -1, 30, 30, "half-freeze", -1, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "swing2", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Iratha's Coil", "Iratha's Finery", "crn", 7, 21, 15, "lgry", "lgry", "", "", "", -1, "", 5, 2500, 2, "res-fire", -1, 30, 30, "res-ltng", -1, 30, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "ac/lvl", 16, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Iratha's Cord", "Iratha's Finery", "tbl", 7, 21, 15, "lgry", "lgry", "", "", "", -1, "", 5, 2500, 2, "ac", -1, 25, 25, "dmg-min", -1, 5, 5, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "dex", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Isenhart's Lightbrand", "Isenhart's Armory", "bsd", 7, 11, 8, "lgld", "lgld", "", "", "", -1, "", 5, 2500, 2, "dmg-min", -1, 10, 10, "swing2", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "att/lvl", 10, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Isenhart's Parry", "Isenhart's Armory", "gts", 7, 11, 8, "lgld", "lgld", "", "", "", -1, "", 5, 2500, 2, "ac", -1, 40, 40, "light-thorns", -1, 4, 4, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "res-all", -1, 8, 8, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Isenhart's Case", "Isenhart's Armory", "brs", 7, 11, 8, "lgld", "lgld", "", "", "", -1, "", 5, 2500, 2, "ac", -1, 40, 40, "red-mag", -1, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "ac/lvl", 16, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Isenhart's Horns", "Isenhart's Armory", "fhl", 7, 11, 8, "lgld", "lgld", "", "", "", -1, "", 5, 2500, 2, "dex", -1, 6, 6, "red-dmg", -1, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "res-all", -1, 8, 8, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Vidala's Barb", "Vidala's Rig", "lbb", 7, 19, 14, "blac", "blac", "", "", "", -1, "", 5, 2500, 2, "ltng-min", -1, 1, 1, "ltng-max", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "att/lvl", 16, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Vidala's Fetlock", "Vidala's Rig", "tbt", 7, 19, 14, "blac", "blac", "", "", "", -1, "", 5, 2500, 2, "stam", -1, 150, 150, "move3", -1, 30, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "res-all", -1, 8, 8, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Vidala's Ambush", "Vidala's Rig", "lea", 7, 19, 14, "blac", "blac", "", "", "", -1, "", 5, 2500, 2, "ac", -1, 50, 50, "dex", -1, 11, 11, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "res-fire", -1, 24, 24, "", -1, -1, -1, "ac/lvl", 20, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Vidala's Snare", "Vidala's Rig", "amu", 7, 19, 14, "blac", "blac", "", "", "", -1, "", 5, 2500, 2, "hp", -1, 15, 15, "res-cold", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "mag%", -1, 50, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Milabrega's Orb", "Milabrega's Regalia", "kit", 7, 23, 17, "dblu", "dblu", "", "", "", -1, "", 5, 2500, 2, "mag%", -1, 20, 20, "ac", -1, 25, 25, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "hp", -1, 50, 50, "", -1, -1, -1, "ac%", -1, 50, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Milabrega's Rod", "Milabrega's Regalia", "wsp", 7, 23, 17, "dblu", "dblu", "", "", "", -1, "", 5, 2500, -1, "pal", -1, 1, 1, "dmg%", -1, 50, 50, "light", -1, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Milabrega's Diadem", "Milabrega's Regalia", "crn", 7, 23, 17, "dblu", "dblu", "", "", "", -1, "", 5, 2500, 2, "hp", -1, 15, 15, "mana", -1, 15, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "res-cold", -1, 40, 40, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Milabrega's Robe", "Milabrega's Regalia", "aar", 7, 23, 17, "dblu", "dblu", "", "", "", -1, "", 5, 2500, 2, "thorns", -1, 3, 3, "red-dmg", -1, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "ac%", -1, 100, 100, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Cathan's Rule", "Cathan's Traps", "bst", 7, 15, 11, "dgrn", "dgrn", "", "", "", -1, "", 5, 2500, 2, "fireskill", -1, 1, 1, "fire-max", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "mana", -1, 50, 50, "", -1, -1, -1, "res-all", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Cathan's Mesh", "Cathan's Traps", "chn", 7, 15, 11, "dgrn", "dgrn", "", "", "", -1, "", 5, 2500, 2, "ac", -1, 15, 15, "ease", -1, -50, -50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "thorns", -1, 5, 5, "", -1, -1, -1, "res-fire", -1, 30, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Cathan's Visage", "Cathan's Traps", "msk", 7, 15, 11, "dgrn", "dgrn", "", "", "", -1, "", 5, 2500, 2, "mana", -1, 20, 20, "res-cold", -1, 25, 25, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "ac/lvl", 16, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Cathan's Sigil", "Cathan's Traps", "amu", 7, 15, 11, "dgrn", "dgrn", "", "", "", -1, "", 5, 2500, 2, "balance1", -1, 10, 10, "light-thorns", -1, 5, 5, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "att", -1, 50, 50, "", -1, -1, -1, "mag%", -1, 25, 25, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Cathan's Seal", "Cathan's Traps", "rin", 7, 15, 11, "dgrn", "dgrn", "", "", "", -1, "", 5, 2500, 2, "lifesteal", -1, 6, 6, "red-dmg", -1, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "str", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Tancred's Crowbill", "Tancred's Battlegear", "mpi", 7, 27, 20, "dgld", "dgld", "", "", "", -1, "", 5, 2500, 2, "att", -1, 75, 75, "dmg%", -1, 80, 80, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "mana", -1, 20, 20, "", -1, -1, -1, "swing2", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Tancred's Spine", "Tancred's Battlegear", "ful", 7, 27, 20, "dgld", "dgld", "", "", "", -1, "", 5, 2500, 2, "hp", -1, 40, 40, "str", -1, 15, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "ac/lvl", 16, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Tancred's Hobnails", "Tancred's Battlegear", "lbt", 7, 27, 20, "dgld", "dgld", "", "", "", -1, "", 5, 2500, 2, "regen-stam", -1, 25, 25, "dex", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "move3", -1, 30, 30, "", -1, -1, -1, "str", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Tancred's Weird", "Tancred's Battlegear", "amu", 7, 27, 20, "dgld", "dgld", "", "", "", -1, "", 5, 2500, 2, "red-dmg", -1, 2, 2, "red-mag", -1, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "mag%", -1, 78, 78, "", -1, -1, -1, "att", -1, 60, 60, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Tancred's Skull", "Tancred's Battlegear", "bhm", 7, 27, 20, "dgld", "dgld", "", "", "", -1, "", 5, 2500, 2, "dmg%", -1, 10, 10, "att", -1, 40, 40, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "res-all", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Sigon's Gage", "Sigon's Complete Steel", "hgl", 7, 9, 6, "whit", "whit", "", "", "", -1, "", 5, 2500, 2, "str", -1, 10, 10, "att", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "swing3", -1, 30, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Sigon's Visor", "Sigon's Complete Steel", "ghm", 7, 9, 6, "whit", "whit", "", "", "", -1, "", 5, 2500, 2, "mana", -1, 30, 30, "ac", -1, 25, 25, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "att/lvl", 16, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Sigon's Shelter", "Sigon's Complete Steel", "gth", 7, 9, 6, "whit", "whit", "", "", "", -1, "", 5, 2500, 2, "ac%", -1, 25, 25, "res-ltng", -1, 30, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "thorns", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Sigon's Sabot", "Sigon's Complete Steel", "hbt", 7, 9, 6, "whit", "whit", "", "", "", -1, "", 5, 2500, 2, "move2", -1, 20, 20, "res-cold", -1, 40, 40, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "att", -1, 50, 50, "", -1, -1, -1, "mag%", -1, 50, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Sigon's Wrap", "Sigon's Complete Steel", "hbl", 7, 9, 6, "whit", "whit", "", "", "", -1, "", 5, 2500, 2, "res-fire", -1, 20, 20, "hp", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "ac/lvl", 16, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Sigon's Guard", "Sigon's Complete Steel", "tow", 7, 9, 6, "whit", "whit", "", "", "", -1, "", 5, 2500, 2, "allskills", -1, 1, 1, "block", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Infernal Cranium", "Infernal Tools", "cap", 7, 7, 5, "lyel", "lyel", "", "", "", -1, "", 5, 2500, 2, "res-all", -1, 10, 10, "dmg-to-mana", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "ac/lvl", 16, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Infernal Torch", "Infernal Tools", "gwn", 7, 7, 5, "lyel", "lyel", "", "", "", -1, "", 5, 2500, 2, "dmg-min", -1, 8, 8, "nec", -1, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "att/lvl", 20, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Infernal Sign", "Infernal Tools", "tbl", 7, 7, 5, "lyel", "lyel", "", "", "", -1, "", 5, 2500, 2, "ac", -1, 25, 25, "hp", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "res-pois", -1, 25, 25, "", -1, -1, -1, "half-freeze", -1, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Berserker's Headgear", "Berserker's Garb", "hlm", 7, 5, 3, "dred", "dred", "", "", "", -1, "", 5, 2500, 2, "ac", -1, 15, 15, "res-fire", -1, 25, 25, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "att/lvl", 16, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Berserker's Hauberk", "Berserker's Garb", "spl", 7, 5, 3, "dred", "dred", "", "", "", -1, "", 5, 2500, 2, "red-mag", -1, 2, 2, "bar", -1, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "ac/lvl", 24, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Berserker's Hatchet", "Berserker's Garb", "2ax", 7, 5, 3, "dred", "dred", "", "", "", -1, "", 5, 2500, 2, "att%", -1, 30, 30, "manasteal", -1, 5, 5, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "dmg%", -1, 50, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Death's Hand", "Death's Disguise", "lgl", 7, 8, 6, "lred", "lred", "", "", "", -1, "", 5, 2500, 2, "res-pois", -1, 50, 50, "res-pois-len", -1, 75, 75, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "swing3", -1, 30, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Death's Guard", "Death's Disguise", "lbl", 7, 8, 6, "lred", "lred", "", "", "", -1, "", 5, 2500, 2, "ac", -1, 20, 20, "nofreeze", -1, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "res-all", -1, 15, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Death's Touch", "Death's Disguise", "wsd", 7, 8, 6, "lred", "lred", "", "", "", -1, "", 5, 2500, 2, "dmg%", -1, 25, 25, "lifesteal", -1, 4, 4, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "dmg-cold", 75, 25, 75, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Angelic Sickle", "Angelical Raiment", "sbr", 7, 17, 12, "lgry", "lgry", "", "", "", -1, "", 5, 2500, 2, "att", -1, 75, 75, "dmg-undead", -1, 250, 250, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "dmg%", -1, 75, 75, "", -1, -1, -1, "swing3", -1, 30, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Angelic Mantle", "Angelical Raiment", "rng", 7, 17, 12, "lgry", "lgry", "", "", "", -1, "", 5, 2500, 2, "red-dmg", -1, 3, 3, "ac%", -1, 40, 40, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "ac", -1, 150, 150, "", -1, -1, -1, "res-fire", -1, 50, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Angelic Halo", "Angelical Raiment", "rin", 3, 17, 12, "lgry", "lgry", "", "", "", -1, "", 5, 2500, 2, "regen", -1, 6, 6, "hp", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "att/lvl", 24, -1, -1, "", -1, -1, -1, "mag%", -1, 50, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Angelic Wings", "Angelical Raiment", "amu", 7, 17, 12, "lgry", "lgry", "", "", "", -1, "", 5, 2500, 2, "light", -1, 3, 3, "dmg-to-mana", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "hp", -1, 75, 75, "", -1, -1, -1, "allskills", -1, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Arctic Horn", "Arctic Gear", "swb", 7, 3, 2, "lgld", "lgld", "", "", "", -1, "", 5, 2500, 2, "att%", -1, 20, 20, "dmg%", -1, 50, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "att/lvl", 16, -1, -1, "", -1, -1, -1, "dmg-cold", 75, 20, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Arctic Furs", "Arctic Gear", "qui", 7, 3, 2, "lgld", "lgld", "", "", "", -1, "", 5, 2500, 2, "ac%", -1, 275, 325, "res-all", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "ac/lvl", 24, -1, -1, "", -1, -1, -1, "res-cold", -1, 15, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Arctic Binding", "Arctic Gear", "vbl", 7, 3, 2, "lgld", "lgld", "", "", "", -1, "", 5, 2500, 2, "res-cold", -1, 40, 40, "ac", -1, 30, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "mag%", -1, 40, 40, "", -1, -1, -1, "res-cold", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Arctic Mitts", "Arctic Gear", "tgl", 7, 3, 2, "lgld", "lgld", "", "", "", -1, "", 5, 2500, 2, "hp", -1, 20, 20, "swing1", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "att", -1, 50, 50, "", -1, -1, -1, "dex", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Arcanna's Sign", "Arcanna's Tricks", "amu", 1, 20, 15, "blac", "blac", "", "", "", -1, "", 5, 2500, 2, "mana", -1, 15, 15, "regen-mana", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "mag%", -1, 50, 50, "", -1, -1, -1, "res-fire", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Arcanna's Deathwand", "Arcanna's Tricks", "wst", 7, 20, 15, "blac", "blac", "", "", "", -1, "", 5, 2500, 2, "sor", -1, 1, 1, "deadly", -1, 25, 25, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "mana", -1, 50, 50, "", -1, -1, -1, "regen-mana", -1, 5, 5, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Arcanna's Head", "Arcanna's Tricks", "skp", 7, 20, 15, "blac", "blac", "", "", "", -1, "", 5, 2500, 2, "regen", -1, 4, 4, "thorns", -1, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "ac/lvl", 24, -1, -1, "", -1, -1, -1, "res-ltng", -1, 15, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Arcanna's Flesh", "Arcanna's Tricks", "ltp", 7, 20, 15, "blac", "blac", "", "", "", -1, "", 5, 2500, 2, "light", -1, 2, 2, "red-dmg", -1, 3, 3, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "ac", -1, 100, 100, "", -1, -1, -1, "enr", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Natalya's Totem", "Natalya's Odium", "xh9", 7, 22, 59, "dgry", "dgry", "", "", "", -1, "", 5, 5000, -1, "ac", -1, 135, 175, "dex", -1, 20, 30, "str", -1, 10, 20, "res-all", -1, 10, 20, "red-mag", -1, 3, 3, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Natalya's Mark", "Natalya's Odium", "7qr", 7, 22, 79, "dgry", "dgry", "", "", "", -1, "", 5, 5000, -1, "swing3", -1, 40, 40, "dmg%", -1, 200, 200, "ignore-ac", -1, 1, 1, "dmg-cold", 100, 50, 50, "dmg-fire", -1, 12, 17, "dmg-undead", -1, 200, 200, "dmg-demon", -1, 200, 200, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Natalya's Shadow", "Natalya's Odium", "ucl", 7, 22, 73, "dgry", "dgry", "", "", "", -1, "", 5, 5000, -1, "ac", -1, 150, 225, "hp/lvl", 8, -1, -1, "skilltab", 19, 2, 2, "res-pois-len", -1, 75, 75, "res-pois", -1, 25, 25, "sock", -1, 1, 3, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Natalya's Soul", "Natalya's Odium", "xmb", 7, 22, 25, "dgry", "dgry", "", "", "", -1, "", 5, 5000, -1, "ac", -1, 75, 125, "move3", -1, 40, 40, "regen-stam/lvl", 2, -1, -1, "dur", -1, 50, 50, "res-cold", -1, 15, 25, "res-ltng", -1, 15, 25, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Aldur's Stony Gaze", "Aldur's Watchtower", "dr8", 7, 29, 36, "oran", "oran", "", "", "", -1, "", 5, 5000, 2, "ac", -1, 90, 90, "regen-mana", -1, 17, 17, "light", -1, 5, 5, "balance3", -1, 25, 25, "res-cold", -1, 40, 50, "sock", -1, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "enr", -1, 15, 15, "", -1, -1, -1, "enr", -1, 15, 15, "", -1, -1, -1, "enr", -1, 15, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Aldur's Deception", "Aldur's Watchtower", "uul", 7, 29, 76, "oran", "oran", "", "", "", -1, "", 5, 5000, 2, "ac", -1, 300, 300, "skilltab", 16, 1, 1, "str", -1, 20, 20, "dex", -1, 15, 15, "res-ltng", -1, 40, 50, "ease", -1, -50, -50, "skilltab", 17, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "vit", -1, 15, 15, "", -1, -1, -1, "vit", -1, 15, 15, "", -1, -1, -1, "vit", -1, 15, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Aldur's Gauntlet", "Aldur's Watchtower", "9mt", 7, 29, 42, "oran", "oran", "", "", "", -1, "", 5, 5000, 2, "dmg-norm", -1, 40, 62, "dmg-ltng", -1, 50, 75, "lifesteal", -1, 10, 10, "swing3", -1, 30, 30, "dmg-demon", -1, 200, 200, "manasteal", -1, 5, 5, "sock", -1, 2, 5, "", -1, -1, -1, "", -1, -1, -1, "str", -1, 15, 15, "", -1, -1, -1, "str", -1, 15, 15, "", -1, -1, -1, "str", -1, 15, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Aldur's Advance", "Aldur's Watchtower", "xtb", 7, 29, 45, "oran", "oran", "", "", "", -1, "", 5, 5000, 2, "indestruct", -1, 1, 1, "regen-stam", -1, 32, 32, "hp", -1, 50, 50, "dmg-to-mana", -1, 10, 10, "move3", -1, 40, 40, "stam", -1, 180, 180, "res-fire", -1, 40, 50, "", -1, -1, -1, "", -1, -1, -1, "dex", -1, 15, 15, "", -1, -1, -1, "dex", -1, 15, 15, "", -1, -1, -1, "dex", -1, 15, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Immortal King's Will", "Immortal King", "ba5", 7, 37, 47, "lgry", "lgry", "", "", "", -1, "", 5, 5000, -1, "ac", -1, 125, 125, "gold%", -1, 37, 37, "skilltab", 14, 2, 2, "light", -1, 4, 4, "mag%", -1, 25, 40, "sock", -1, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Immortal King's Soul Cage ", "Immortal King", "uar", 7, 37, 76, "lgry", "lgry", "", "", "", -1, "", 5, 5000, 2, "ac", -1, 400, 400, "gethit-skill", 52, 5, 5, "skilltab", 12, 2, 2, "res-pois", -1, 50, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "balance2", -1, 25, 25, "", -1, -1, -1, "res-cold", -1, 40, 40, "", -1, -1, -1, "res-fire", -1, 40, 40, "", -1, -1, -1, "res-ltng", -1, 40, 40, "", -1, -1, -1, "ac%", -1, 50, 50, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Immortal King's Detail", "Immortal King", "zhb", 7, 37, 29, "lgry", "lgry", "", "", "", -1, "", 5, 5000, 2, "ac", -1, 36, 36, "res-fire", -1, 28, 28, "res-ltng", -1, 31, 31, "str", -1, 25, 25, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "ac", -1, 105, 105, "", -1, -1, -1, "balance2", -1, 25, 25, "", -1, -1, -1, "ac%", -1, 100, 100, "", -1, -1, -1, "red-dmg%", -1, 20, 20, "", -1, -1, -1, "skilltab", 13, 2, 2, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Immortal King's Forge", "Immortal King", "xhg", 7, 37, 30, "lgry", "lgry", "", "", "", -1, "", 5, 5000, 2, "ac", -1, 65, 65, "str", -1, 20, 20, "dex", -1, 20, 20, "gethit-skill", 38, 12, 4, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "swing2", -1, 25, 25, "", -1, -1, -1, "ac", -1, 120, 120, "", -1, -1, -1, "lifesteal", -1, 10, 10, "", -1, -1, -1, "manasteal", -1, 10, 10, "", -1, -1, -1, "freeze", -1, 2, 2, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Immortal King's Pillar", "Immortal King", "xhb", 7, 37, 31, "lgry", "lgry", "", "", "", -1, "", 5, 5000, 2, "ac", -1, 75, 75, "move3", -1, 40, 40, "att", -1, 110, 110, "hp", -1, 44, 44, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "mag%", -1, 25, 25, "", -1, -1, -1, "skilltab", 12, 2, 2, "", -1, -1, -1, "ac", -1, 160, 160, "", -1, -1, -1, "half-freeze", -1, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Immortal King's Stone Crusher", "Immortal King", "7m7", 7, 37, 76, "lgry", "lgry", "", "", "", -1, "", 5, 5000, 2, "indestruct", -1, 1, 1, "swing3", -1, 40, 40, "dmg-demon", -1, 200, 200, "dmg-undead", -1, 200, 200, "crush", -1, 35, 40, "dmg%", -1, 200, 200, "sock", -1, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "dmg-fire", -1, 211, 397, "", -1, -1, -1, "dmg-ltng", -1, 7, 477, "", -1, -1, -1, "dmg-cold", 150, 127, 364, "", -1, -1, -1, "dmg-pois", 150, 349, 349, "", -1, -1, -1, "dmg-mag", -1, 250, 361, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Tal Rasha's Fire-Spun Cloth", "Tal Rasha's Wrappings", "zmb", 7, 26, 53, "dpur", "dpur", "", "", "", -1, "", 5, 5000, 2, "ease", -1, -20, -20, "mana", -1, 30, 30, "dex", -1, 20, 20, "dmg-to-mana", -1, 37, 37, "mag%", -1, 10, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "ac", -1, 60, 60, "", -1, -1, -1, "cast2", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Tal Rasha's Adjudication", "Tal Rasha's Wrappings", "amu", 1, 26, 67, "dpur", "dpur", "", "", "", -1, "", 5, 5000, 2, "res-ltng", -1, 33, 33, "sor", -1, 2, 2, "hp", -1, 50, 50, "dmg-ltng", -1, 3, 32, "mana", -1, 42, 42, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "cast2", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Tal Rasha's Lidless Eye", "Tal Rasha's Wrappings", "oba", 7, 26, 65, "dpur", "dpur", "", "", "", -1, "", 5, 5000, 2, "hp", -1, 57, 57, "mana", -1, 77, 77, "enr", -1, 10, 10, "cast3", -1, 20, 20, "skill", 61, 1, 2, "skill", 63, 1, 2, "skill", 65, 1, 2, "", -1, -1, -1, "", -1, -1, -1, "sor", -1, 1, 1, "", -1, -1, -1, "pierce-fire", -1, 15, 15, "", -1, -1, -1, "pierce-ltng", -1, 15, 15, "", -1, -1, -1, "extra-cold", -1, 15, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Tal Rasha's Howling Wind", "Tal Rasha's Wrappings", "uth", 7, 26, 71, "dpur", "dpur", "", "", "", -1, "", 5, 5000, 2, "ease", -1, -60, -60, "red-mag", -1, 15, 15, "mag%", -1, 88, 88, "res-cold", -1, 40, 40, "res-fire", -1, 40, 40, "res-ltng", -1, 40, 40, "ac", -1, 400, 400, "", -1, -1, -1, "", -1, -1, -1, "cast2", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Tal Rasha's Horadric Crest", "Tal Rasha's Wrappings", "xsk", 7, 26, 66, "dpur", "dpur", "", "", "", -1, "", 5, 5000, -1, "mana", -1, 30, 30, "hp", -1, 60, 60, "ac", -1, 45, 45, "res-all", -1, 15, 15, "lifesteal", -1, 10, 10, "manasteal", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Griswold's Valor", "Griswold's Legacy", "urn", 7, 44, 69, "dgld", "dgld", "", "", "", -1, "", 5, 5000, 2, "ac%", -1, 50, 75, "abs-cold/lvl", -1, 2, 2, "sock", -1, 2, 2, "ease", -1, -40, -40, "mag%", -1, 20, 30, "res-all", -1, 5, 5, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "skilltab", 10, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Griswold's Heart", "Griswold's Legacy", "xar", 7, 44, 45, "dgld", "dgld", "", "", "", -1, "", 5, 5000, -1, "ac", -1, 500, 500, "skilltab", 11, 2, 2, "sock", -1, 3, 3, "str", -1, 20, 20, "ease", -1, -40, -40, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Griswolds's Redemption", "Griswold's Legacy", "7ws", 7, 44, 53, "dgld", "dgld", "", "", "", -1, "", 5, 5000, 2, "dmg%", -1, 200, 240, "swing2", -1, 40, 40, "dmg-undead", -1, 200, 200, "ease", -1, -20, -20, "sock", -1, 3, 4, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "skilltab", 9, 2, 2, "", -1, -1, -1, "dmg-norm", -1, 10, 20, "", -1, -1, -1, "dmg-norm", -1, 10, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Griswold's Honor", "Griswold's Legacy", "paf", 7, 44, 68, "dgld", "dgld", "", "", "", -1, "", 5, 5000, -1, "ac", -1, 108, 108, "sock", 3, -1, -1, "block2", -1, 65, 65, "block", -1, 20, 20, "res-all", -1, 45, 45, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Trang-Oul's Guise", "Trang-Oul's Avatar", "uh9", 7, 32, 65, "dgld", "dgld", "", "", "", -1, "", 5, 5000, -1, "ac", -1, 80, 100, "balance2", -1, 25, 25, "thorns", -1, 20, 20, "mana", -1, 150, 150, "regen", -1, 5, 5, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Trang-Oul's Scales", "Trang-Oul's Avatar", "xul", 7, 32, 49, "dyel", "dyel", "", "", "", -1, "", 5, 5000, 2, "ease", -1, -40, -40, "ac-miss", -1, 100, 100, "res-pois", -1, 40, 40, "skilltab", 8, 2, 2, "move3", -1, 40, 40, "ac%", -1, 150, 150, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "res-ltng", -1, 50, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "red-dmg%", -1, 25, 25, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Trang-Oul's Wing", "Trang-Oul's Avatar", "ne9", 7, 32, 54, "dyel", "dyel", "", "", "", -1, "", 5, 5000, 2, "ac", -1, 125, 125, "str", -1, 25, 25, "dex", -1, 15, 15, "res-fire", -1, 38, 45, "block", -1, 30, 30, "res-pois", -1, 40, 40, "skilltab", 7, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "pierce-pois", -1, 25, 25, "", -1, -1, -1, "regen", -1, 15, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Trang-Oul's Claws", "Trang-Oul's Avatar", "xmg", 7, 32, 45, "dyel", "dyel", "", "", "", -1, "", 5, 5000, -1, "ac", -1, 30, 30, "cast3", -1, 20, 20, "res-cold", -1, 30, 30, "skilltab", 6, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "extra-pois", -1, 25, 25, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Trang-Oul's Girth", "Trang-Oul's Avatar", "utc", 7, 32, 47, "dyel", "dyel", "", "", "", -1, "", 5, 5000, 2, "ac", -1, 75, 100, "stam", -1, 30, 30, "regen", -1, 5, 5, "hp", -1, 66, 66, "nofreeze", -1, 1, 1, "ease", -1, -40, -40, "mana", -1, 25, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "res-cold", -1, 40, 40, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "M'avina's True Sight", "M'avina's Battle Hymn", "ci3", 7, 21, 59, "whit", "whit", "", "", "", -1, "", 5, 5000, 2, "ac", -1, 150, 150, "regen", -1, 10, 10, "swing2", -1, 30, 30, "mana", -1, 25, 25, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "allskills", -1, 1, 1, "", -1, -1, -1, "att%", -1, 50, 50, "", -1, -1, -1, "res-all", -1, 25, 25, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "M'avina's Embrace", "M'avina's Battle Hymn", "uld", 7, 21, 70, "whit", "whit", "", "", "", -1, "", 5, 5000, 2, "gethit-skill", 55, 10, 3, "ease", -1, -30, -30, "red-mag", -1, 5, 12, "skilltab", 1, 2, 2, "ac/lvl", 32, -1, -1, "ac", -1, 350, 350, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "balance2", -1, 30, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "M'avina's Icy Clutch", "M'avina's Battle Hymn", "xtg", 7, 21, 32, "whit", "whit", "", "", "", -1, "", 5, 5000, 2, "ac", -1, 45, 50, "dmg-cold", 150, 6, 18, "half-freeze", -1, 1, 1, "gold%", -1, 56, 56, "str", -1, 10, 10, "dex", -1, 15, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "dmg-cold", 100, 131, 252, "", -1, -1, -1, "extra-cold", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "M'avina's Tenet", "M'avina's Battle Hymn", "zvb", 7, 21, 45, "whit", "whit", "", "", "", -1, "", 5, 5000, 2, "ac", -1, 50, 50, "move2", -1, 20, 20, "manasteal", -1, 5, 5, "light", -1, 5, 5, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "res-all", -1, 25, 25, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "M'avina's Caster", "M'avina's Battle Hymn", "amc", 7, 21, 70, "whit", "whit", "", "", "", -1, "", 5, 5000, 2, "dmg%", -1, 188, 188, "swing3", -1, 40, 40, "magicarrow", -1, 1, 1, "att", -1, 50, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "dmg-mag", -1, 114, 377, "", -1, -1, -1, "hit-skill", 48, 10, 15, "", -1, -1, -1, "skilltab", 0, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Telling of Beads", "The Disciple", "amu", 1, 39, 30, "lblu", "lblu", "", "", "", -1, "", 5, 5000, -1, "res-pois", -1, 35, 50, "allskills", -1, 1, 1, "res-cold", -1, 18, 18, "thorns", -1, 8, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Laying of Hands", "The Disciple", "ulg", 7, 39, 63, "lblu", "lblu", "", "", "", -1, "", 5, 5000, -1, "ac", -1, 25, 25, "swing2", -1, 20, 20, "res-fire", -1, 50, 50, "dmg-demon", -1, 350, 350, "hit-skill", 101, 10, 3, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Rite of Passage", "The Disciple", "xlb", 7, 39, 29, "lblu", "lblu", "", "", "", -1, "", 5, 5000, -1, "ac", -1, 25, 25, "move3", -1, 30, 30, "half-freeze", -1, 1, 1, "stam", -1, 15, 25, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Spiritual Custodian", "The Disciple", "uui", 7, 39, 43, "lblu", "lblu", "", "", "", -1, "", 5, 5000, -1, "ac", -1, 305, 415, "res-fire", -1, 24, 24, "gethit-skill", 48, 25, 3, "dmg-pois", 50, 125, 175, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Credendum", "The Disciple", "umc", 7, 39, 65, "lblu", "lblu", "", "", "", -1, "", 5, 5000, -1, "ac", -1, 50, 50, "str", -1, 10, 10, "dex", -1, 10, 10, "res-all", -1, 15, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Dangoon's Teaching", "Heaven's Brethren", "7ma", 7, 55, 68, "", "", "", "", "", -1, "", 5, 5000, -1, "dmg/lvl", 12, -1, -1, "swing3", -1, 40, 40, "hit-skill", 44, 10, 3, "dmg-fire", -1, 20, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Heaven's Taebaek", "Heaven's Brethren", "uts", 7, 55, 81, "", "", "", "", "", -1, "", 5, 5000, -1, "ac", -1, 50, 50, "mana", -1, 100, 100, "res-ltng", -1, 30, 30, "thorns", -1, 30, 30, "indestruct", -1, 1, 1, "block", -1, 25, 25, "block3", -1, 30, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Haemosu's Adament", "Heaven's Brethren", "xrs", 7, 55, 44, "", "", "", "", "", -1, "", 5, 5000, -1, "ac", -1, 500, 500, "ac-miss", -1, 35, 35, "hp", -1, 75, 75, "ac-hth", -1, 40, 40, "ease", -1, -20, -20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Ondal's Almighty", "Heaven's Brethren", "uhm", 7, 55, 69, "", "", "", "", "", -1, "", 5, 5000, -1, "ac", -1, 50, 50, "ease", -1, -40, -40, "hit-skill", 72, 10, 3, "str", -1, 10, 10, "dex", -1, 15, 15, "balance3", -1, 24, 24, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Guillaume's Face", "Orphan's Call", "xhm", 7, 41, 34, "lgry", "lgry", "", "", "", -1, "", 5, 5000, -1, "ac%", -1, 120, 120, "balance3", -1, 30, 30, "crush", -1, 35, 35, "deadly", -1, 15, 15, "str", -1, 15, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Wilhelm's Pride", "Orphan's Call", "ztb", 7, 41, 42, "lgry", "lgry", "", "", "", -1, "", 5, 5000, -1, "ac%", -1, 75, 75, "manasteal", -1, 5, 5, "res-cold", -1, 10, 10, "lifesteal", -1, 5, 5, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Magnus' Skin", "Orphan's Call", "xvg", 7, 41, 37, "lgry", "lgry", "", "", "", -1, "", 5, 5000, -1, "ac%", -1, 50, 50, "res-fire", -1, 15, 15, "swing2", -1, 20, 20, "light", -1, 3, 3, "att", -1, 100, 100, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Wihtstan's Guard", "Orphan's Call", "xml", 7, 41, 29, "lgry", "lgry", "", "", "", -1, "", 5, 5000, -1, "ac%", -1, 175, 175, "block3", -1, 40, 40, "block", -1, 55, 55, "half-freeze", -1, 1, 1, "light", -1, 5, 5, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Hwanin's Splendor", "Hwanin's Majesty", "xrn", 7, 28, 45, "", "", "", "", "", -1, "", 5, 5000, -1, "regen", -1, 20, 20, "red-mag", -1, 10, 10, "res-cold", -1, 37, 37, "ac%", -1, 100, 100, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Hwanin's Refuge", "Hwanin's Majesty", "xcl", 7, 28, 30, "", "", "", "", "", -1, "", 5, 5000, -1, "ac", -1, 200, 200, "res-pois", -1, 27, 27, "hp", -1, 100, 100, "gethit-skill", 42, 10, 3, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Hwanin's Seal", "Hwanin's Majesty", "mbl", 7, 28, 35, "", "", "", "", "", -1, "", 5, 5000, -1, "dmg-ltng", -1, 3, 33, "noheal", -1, 1, 1, "ac/lvl", 12, -1, -1, "dmg-to-mana", -1, 12, 12, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Hwanin's Justice", "Hwanin's Majesty", "9vo", 7, 28, 28, "", "", "", "", "", -1, "", 5, 5000, -1, "att", -1, 330, 330, "indestruct", -1, 1, 1, "hit-skill", 45, 10, 3, "swing3", -1, 40, 40, "dmg%", -1, 200, 200, "dmg-ltng", -1, 5, 25, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Sazabi's Cobalt Redeemer", "Sazabi's Grand Tribute", "7ls", 7, 34, 73, "dblu", "dblu", "", "", "", -1, "", 5, 5000, -1, "dmg%", -1, 150, 150, "dmg-cold", 50, 25, 35, "swing3", -1, 40, 40, "dmg-demon", -1, 318, 318, "indestruct", -1, 1, 1, "dex", -1, 15, 15, "str", -1, 5, 5, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Sazabi's Ghost Liberator", "Sazabi's Grand Tribute", "upl", 7, 34, 67, "dblu", "dblu", "", "", "", -1, "", 5, 5000, -1, "ac", -1, 400, 400, "balance3", -1, 30, 30, "str", -1, 25, 25, "att-demon", -1, 300, 300, "hp", -1, 50, 75, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Sazabi's Mental Sheath", "Sazabi's Grand Tribute", "xhl", 7, 34, 43, "dblu", "dblu", "", "", "", -1, "", 5, 5000, -1, "ac", -1, 100, 100, "allskills", -1, 1, 1, "res-fire", -1, 15, 20, "res-ltng", -1, 15, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Bul-Kathos' Sacred Charge", "Bul-Kathos' Children", "7gd", 7, 50, 61, "dgrn", "dgrn", "", "", "", -1, "", 5, 5000, -1, "crush", -1, 35, 35, "res-all", -1, 20, 20, "swing2", -1, 20, 20, "knock", -1, 1, 1, "dmg%", -1, 200, 200, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Bul-Kathos' Tribal Guardian", "Bul-Kathos' Children", "7wd", 7, 50, 54, "dgrn", "dgrn", "", "", "", -1, "", 5, 5000, -1, "res-fire", -1, 50, 50, "dmg-pois", 50, 255, 255, "swing2", -1, 20, 20, "str", -1, 20, 20, "dmg%", -1, 200, 200, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Cow King's Horns", "Cow King's Leathers", "xap", 7, 20, 25, "", "", "", "", "", -1, "", 5, 5000, -1, "ac", -1, 75, 75, "half-freeze", -1, 1, 1, "dmg-to-mana", -1, 35, 35, "thorns", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Cow King's Hide", "Cow King's Leathers", "stu", 7, 20, 18, "", "", "", "", "", -1, "", 5, 5000, -1, "res-all", -1, 18, 18, "ac%", -1, 60, 60, "hp", -1, 30, 30, "gethit-skill", 53, 18, 5, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Cow King's Hoofs", "Cow King's Leathers", "vbt", 7, 20, 13, "", "", "", "", "", -1, "", 5, 5000, -1, "ac", -1, 25, 35, "move3", -1, 30, 30, "mag%", -1, 25, 25, "dex", -1, 20, 20, "dmg-fire", -1, 25, 35, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Naj's Puzzler", "Naj's Ancient Set", "6cs", 7, 43, 78, "", "", "", "", "", -1, "", 5, 5000, -1, "enr", -1, 35, 35, "dmg%", -1, 150, 150, "charged", 54, 69, 11, "cast3", -1, 30, 30, "dmg-ltng", -1, 6, 45, "mana", -1, 70, 70, "allskills", -1, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Naj's Light Plate", "Naj's Ancient Set", "ult", 7, 43, 71, "", "", "", "", "", -1, "", 5, 5000, -1, "ease", -1, -60, -60, "hp", -1, 65, 65, "res-all", -1, 25, 25, "dmg-to-mana", -1, 45, 45, "allskills", -1, 1, 1, "ac", -1, 300, 300, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "Naj's Circlet", "Naj's Ancient Set", "ci0", 7, 43, 28, "", "", "", "", "", -1, "", 5, 5000, -1, "ac", -1, 75, 75, "dmg-fire", -1, 25, 35, "light", -1, 5, 5, "str", -1, 15, 15, "gethit-skill", 53, 12, 5, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "McAuley's Paragon", "McAuley's Folly", "cap", 3, 20, 25, "lpur", "lpur", "", "", "", -1, "", 5, 5000, -1, "mag%", -1, 35, 35, "thorns", -1, 8, 8, "ac/lvl", 8, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "McAuley's Riprap", "McAuley's Folly", "vbt", 7, 20, 20, "lpur", "lpur", "", "", "", -1, "", 5, 5000, -1, "move3", -1, 40, 40, "att", -1, 100, 100, "str", -1, 5, 5, "dex", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "McAuley's Taboo", "McAuley's Folly", "vgl", 7, 20, 28, "lpur", "lpur", "", "", "", -1, "", 5, 5000, -1, "ac", -1, 20, 25, "swing2", -1, 20, 20, "hp", -1, 40, 40, "dmg-pois", 75, 30, 36, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseSetItem(BaseSetItem.ItemCount++, "McAuley's Superstition", "McAuley's Folly", "bwn", 7, 20, 25, "lpur", "lpur", "", "", "", -1, "", 5, 5000, -1, "dmg%", 2, 75, 75, "mana", -1, 25, 25, "manasteal", -1, 8, 8, "cast3", -1, 20, 20, "dmg-cold", 50, 25, 75, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1)
		};
	}
}
