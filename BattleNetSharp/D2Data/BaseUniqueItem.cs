﻿using System;

namespace D2Data
{
	// Token: 0x02000920 RID: 2336
	public class BaseUniqueItem
	{
		// Token: 0x0600B94A RID: 47434 RVA: 0x0034E3A4 File Offset: 0x0034C5A4
		private static BaseProperty _getProperty(string code)
		{
			bool flag = code.StartsWith("*");
			BaseProperty baseProperty;
			if (flag)
			{
				baseProperty = BaseProperty.GetByCode(code.Substring(1));
			}
			else
			{
				baseProperty = BaseProperty.GetByCode(code);
			}
			return baseProperty;
		}

		// Token: 0x0600B94B RID: 47435 RVA: 0x0034E3DC File Offset: 0x0034C5DC
		public BaseUniqueItem(int Index, string Name, int Version, int Enabled, int Ladder, int Rarity, int NoLimit, int DropLevel, int RequiredLevel, string Code, string BaseItemName, int Uber, int Carry1, int CostMultiply, int CostAdd, string CharTransform, string InvTransform, string FlippyFile, string InvFile, string DropSound, int DropSfxFrame, string UseSound, string Property1, int Param1, int Min1, int Max1, string Property2, int Param2, int Min2, int Max2, string Property3, int Param3, int Min3, int Max3, string Property4, int Param4, int Min4, int Max4, string Property5, int Param5, int Min5, int Max5, string Property6, int Param6, int Min6, int Max6, string Property7, int Param7, int Min7, int Max7, string Property8, int Param8, int Min8, int Max8, string Property9, int Param9, int Min9, int Max9, string Property10, int Param10, int Min10, int Max10, string Property11, int Param11, int Min11, int Max11, string Property12, int Param12, int Min12, int Max12)
		{
			this.Index = Index;
			this.Id = (UniqueItemType)Index;
			this.Name = Name;
			this.BaseItem = BaseItem.GetByCode(Code);
			this.Name = Name;
			this.Version = Version;
			this.Enabled = Enabled;
			this.Ladder = Ladder;
			this.Rarity = Rarity;
			this.NoLimit = NoLimit;
			this.DropLevel = DropLevel;
			this.RequiredLevel = RequiredLevel;
			this.BaseItemName = BaseItemName;
			this.Uber = Uber;
			this.Carry1 = Carry1;
			this.CostMultiply = CostMultiply;
			this.CostAdd = CostAdd;
			this.CharTransform = CharTransform;
			this.InvTransform = InvTransform;
			this.FlippyFile = FlippyFile;
			this.InvFile = InvFile;
			this.DropSound = DropSound;
			this.DropSfxFrame = DropSfxFrame;
			this.UseSound = UseSound;
			bool flag = Property1.Length == 0;
			if (flag)
			{
				this.Property1 = null;
			}
			else
			{
				this.Property1 = BaseUniqueItem._getProperty(Property1);
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
				this.Property2 = BaseUniqueItem._getProperty(Property2);
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
				this.Property3 = BaseUniqueItem._getProperty(Property3);
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
				this.Property4 = BaseUniqueItem._getProperty(Property4);
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
				this.Property5 = BaseUniqueItem._getProperty(Property5);
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
				this.Property6 = BaseUniqueItem._getProperty(Property6);
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
				this.Property7 = BaseUniqueItem._getProperty(Property7);
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
				this.Property8 = BaseUniqueItem._getProperty(Property8);
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
				this.Property9 = BaseUniqueItem._getProperty(Property9);
			}
			this.Param9 = Param9;
			this.Min9 = Min9;
			this.Max9 = Max9;
			bool flag10 = Property10.Length == 0;
			if (flag10)
			{
				this.Property10 = null;
			}
			else
			{
				this.Property10 = BaseUniqueItem._getProperty(Property10);
			}
			this.Param10 = Param10;
			this.Min10 = Min10;
			this.Max10 = Max10;
			bool flag11 = Property11.Length == 0;
			if (flag11)
			{
				this.Property11 = null;
			}
			else
			{
				this.Property11 = BaseUniqueItem._getProperty(Property11);
			}
			this.Param11 = Param11;
			this.Min11 = Min11;
			this.Max11 = Max11;
			bool flag12 = Property12.Length == 0;
			if (flag12)
			{
				this.Property12 = null;
			}
			else
			{
				this.Property12 = BaseUniqueItem._getProperty(Property12);
			}
			this.Param12 = Param12;
			this.Min12 = Min12;
			this.Max12 = Max12;
		}

		// Token: 0x0600B94C RID: 47436 RVA: 0x0034E7C4 File Offset: 0x0034C9C4
		private static BaseUniqueItem _gimmeAnull()
		{
			BaseUniqueItem.ItemCount++;
			return null;
		}

		// Token: 0x0600B94D RID: 47437 RVA: 0x0034E7E4 File Offset: 0x0034C9E4
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x0600B94E RID: 47438 RVA: 0x0034E7FC File Offset: 0x0034C9FC
		public static BaseUniqueItem Get(int index)
		{
			return BaseUniqueItem.items[index];
		}

		// Token: 0x0600B94F RID: 47439 RVA: 0x0034E818 File Offset: 0x0034CA18
		public static BaseUniqueItem Get(UniqueItemType type)
		{
			return BaseUniqueItem.items[(int)type];
		}

		// Token: 0x0600B950 RID: 47440 RVA: 0x0034E834 File Offset: 0x0034CA34
		public static BaseUniqueItem GetByName(string name)
		{
			for (int i = 0; i < BaseUniqueItem.ItemCount; i++)
			{
				bool flag = BaseUniqueItem.items[i] != null && BaseUniqueItem.items[i].Name == name;
				if (flag)
				{
					return BaseUniqueItem.items[i];
				}
			}
			throw new ArgumentException(string.Format("No  Unique Item named {0} found !", name));
		}

		// Token: 0x04006E2E RID: 28206
		public readonly int Index;

		// Token: 0x04006E2F RID: 28207
		public readonly UniqueItemType Id;

		// Token: 0x04006E30 RID: 28208
		public readonly string Name;

		// Token: 0x04006E31 RID: 28209
		public readonly BaseItem BaseItem;

		// Token: 0x04006E32 RID: 28210
		public readonly int Version;

		// Token: 0x04006E33 RID: 28211
		public readonly int Enabled;

		// Token: 0x04006E34 RID: 28212
		public readonly int Ladder;

		// Token: 0x04006E35 RID: 28213
		public readonly int Rarity;

		// Token: 0x04006E36 RID: 28214
		public readonly int NoLimit;

		// Token: 0x04006E37 RID: 28215
		public readonly int DropLevel;

		// Token: 0x04006E38 RID: 28216
		public readonly int RequiredLevel;

		// Token: 0x04006E39 RID: 28217
		public readonly string BaseItemName;

		// Token: 0x04006E3A RID: 28218
		public readonly int Uber;

		// Token: 0x04006E3B RID: 28219
		public readonly int Carry1;

		// Token: 0x04006E3C RID: 28220
		public readonly int CostMultiply;

		// Token: 0x04006E3D RID: 28221
		public readonly int CostAdd;

		// Token: 0x04006E3E RID: 28222
		public readonly string CharTransform;

		// Token: 0x04006E3F RID: 28223
		public readonly string InvTransform;

		// Token: 0x04006E40 RID: 28224
		public readonly string FlippyFile;

		// Token: 0x04006E41 RID: 28225
		public readonly string InvFile;

		// Token: 0x04006E42 RID: 28226
		public readonly string DropSound;

		// Token: 0x04006E43 RID: 28227
		public readonly int DropSfxFrame;

		// Token: 0x04006E44 RID: 28228
		public readonly string UseSound;

		// Token: 0x04006E45 RID: 28229
		public readonly BaseProperty Property1;

		// Token: 0x04006E46 RID: 28230
		public readonly int Param1;

		// Token: 0x04006E47 RID: 28231
		public readonly int Min1;

		// Token: 0x04006E48 RID: 28232
		public readonly int Max1;

		// Token: 0x04006E49 RID: 28233
		public readonly BaseProperty Property2;

		// Token: 0x04006E4A RID: 28234
		public readonly int Param2;

		// Token: 0x04006E4B RID: 28235
		public readonly int Min2;

		// Token: 0x04006E4C RID: 28236
		public readonly int Max2;

		// Token: 0x04006E4D RID: 28237
		public readonly BaseProperty Property3;

		// Token: 0x04006E4E RID: 28238
		public readonly int Param3;

		// Token: 0x04006E4F RID: 28239
		public readonly int Min3;

		// Token: 0x04006E50 RID: 28240
		public readonly int Max3;

		// Token: 0x04006E51 RID: 28241
		public readonly BaseProperty Property4;

		// Token: 0x04006E52 RID: 28242
		public readonly int Param4;

		// Token: 0x04006E53 RID: 28243
		public readonly int Min4;

		// Token: 0x04006E54 RID: 28244
		public readonly int Max4;

		// Token: 0x04006E55 RID: 28245
		public readonly BaseProperty Property5;

		// Token: 0x04006E56 RID: 28246
		public readonly int Param5;

		// Token: 0x04006E57 RID: 28247
		public readonly int Min5;

		// Token: 0x04006E58 RID: 28248
		public readonly int Max5;

		// Token: 0x04006E59 RID: 28249
		public readonly BaseProperty Property6;

		// Token: 0x04006E5A RID: 28250
		public readonly int Param6;

		// Token: 0x04006E5B RID: 28251
		public readonly int Min6;

		// Token: 0x04006E5C RID: 28252
		public readonly int Max6;

		// Token: 0x04006E5D RID: 28253
		public readonly BaseProperty Property7;

		// Token: 0x04006E5E RID: 28254
		public readonly int Param7;

		// Token: 0x04006E5F RID: 28255
		public readonly int Min7;

		// Token: 0x04006E60 RID: 28256
		public readonly int Max7;

		// Token: 0x04006E61 RID: 28257
		public readonly BaseProperty Property8;

		// Token: 0x04006E62 RID: 28258
		public readonly int Param8;

		// Token: 0x04006E63 RID: 28259
		public readonly int Min8;

		// Token: 0x04006E64 RID: 28260
		public readonly int Max8;

		// Token: 0x04006E65 RID: 28261
		public readonly BaseProperty Property9;

		// Token: 0x04006E66 RID: 28262
		public readonly int Param9;

		// Token: 0x04006E67 RID: 28263
		public readonly int Min9;

		// Token: 0x04006E68 RID: 28264
		public readonly int Max9;

		// Token: 0x04006E69 RID: 28265
		public readonly BaseProperty Property10;

		// Token: 0x04006E6A RID: 28266
		public readonly int Param10;

		// Token: 0x04006E6B RID: 28267
		public readonly int Min10;

		// Token: 0x04006E6C RID: 28268
		public readonly int Max10;

		// Token: 0x04006E6D RID: 28269
		public readonly BaseProperty Property11;

		// Token: 0x04006E6E RID: 28270
		public readonly int Param11;

		// Token: 0x04006E6F RID: 28271
		public readonly int Min11;

		// Token: 0x04006E70 RID: 28272
		public readonly int Max11;

		// Token: 0x04006E71 RID: 28273
		public readonly BaseProperty Property12;

		// Token: 0x04006E72 RID: 28274
		public readonly int Param12;

		// Token: 0x04006E73 RID: 28275
		public readonly int Min12;

		// Token: 0x04006E74 RID: 28276
		public readonly int Max12;

		// Token: 0x04006E75 RID: 28277
		private static int ItemCount = 0;

		// Token: 0x04006E76 RID: 28278
		private static BaseUniqueItem[] items = new BaseUniqueItem[]
		{
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Gnasher", 0, 1, -1, 1, -1, 7, 5, "hax", "Hand Axe", -1, -1, 5, 5000, "dyel", "", "", "invhaxu", "", -1, "", "str", -1, 8, 8, "openwounds", -1, 50, 50, "crush", -1, 20, 20, "dmg%", -1, 60, 70, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Deathspade", 0, 1, -1, 1, -1, 12, 9, "axe", "Axe", -1, -1, 5, 5000, "dgld", "", "", "invaxeu", "", -1, "", "stupidity", -1, 1, 1, "dmg-min", -1, 8, 8, "att%", -1, 15, 15, "mana-kill", -1, 4, 4, "dmg%", -1, 60, 70, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Bladebone", 0, 1, -1, 1, -1, 20, 15, "2ax", "Double Axe", -1, -1, 5, 5000, "lgry", "lgry", "", "", "", -1, "", "dmg-undead", -1, 100, 100, "att-undead", -1, 40, 40, "swing2", -1, 20, 20, "ac", -1, 20, 20, "fire-min", -1, 8, 8, "fire-max", -1, 12, 12, "dmg%", -1, 30, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Mindrend", 0, 1, -1, 1, -1, 28, 21, "mpi", "Military Pick", -1, -1, 5, 5000, "lgrn", "", "", "invmpiu", "", -1, "", "stupidity", -1, 2, 2, "regen-mana", -1, 20, 20, "ltng-min", -1, 1, 1, "ltng-max", -1, 12, 15, "att", -1, 50, 100, "dmg%", -1, 60, 100, "openwounds", -1, 15, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Rakescar", 0, 1, -1, 1, -1, 36, 27, "wax", "War Axe", -1, -1, 5, 5000, "dgry", "dgry", "", "", "", -1, "", "pois-min", -1, 128, 128, "pois-max", -1, 128, 128, "pois-len", -1, 75, 75, "att", -1, 50, 50, "res-pois", -1, 50, 50, "dmg%", -1, 75, 150, "swing2", -1, 30, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Fechmars Axe", 0, 1, -1, 1, -1, 11, 8, "lax", "Large Axe", -1, -1, 5, 5000, "lpur", "lpur", "", "", "", -1, "", "dmg%", -1, 70, 90, "freeze", -1, 3, 3, "res-cold", -1, 50, 50, "light", -1, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Goreshovel", 0, 1, -1, 1, -1, 19, 14, "bax", "Broad Axe", -1, -1, 5, 5000, "dpur", "dpur", "", "", "", -1, "", "swing3", -1, 30, 30, "str", -1, 25, 25, "openwounds", -1, 60, 60, "dmg%", -1, 40, 50, "dmg-max", -1, 9, 9, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Chieftan", 0, 1, -1, 1, -1, 26, 19, "btx", "Battle Axe", -1, -1, 5, 5000, "oran", "", "", "invbtxu", "", -1, "", "dmg%", -1, 100, 100, "res-all", -1, 10, 20, "mana-kill", -1, 6, 6, "swing2", -1, 20, 20, "dmg-ltng", -1, 1, 40, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Brainhew", 0, 1, -1, 1, -1, 34, 25, "gax", "Great Axe", -1, -1, 5, 5000, "whit", "", "", "invgaxu", "", -1, "", "dmg-min", -1, 14, 14, "mana", -1, 25, 25, "light", -1, 4, 4, "manasteal", -1, 10, 13, "dmg%", -1, 50, 80, "dmg-fire", -1, 15, 35, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Humongous", 0, 1, -1, 1, -1, 39, 29, "gix", "Giant Axe", -1, -1, 5, 5000, "blac", "blac", "", "", "", -1, "", "str", -1, 20, 30, "dmg-min", -1, 8, 8, "dmg-max", -1, 15, 25, "crush", -1, 33, 33, "ease", -1, 20, 20, "dmg%", -1, 80, 120, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Iros Torch", 0, 1, -1, 1, -1, 7, 5, "wnd", "Wand", -1, -1, 5, 5000, "cred", "", "", "invwndu", "", -1, "", "nec", -1, 1, 1, "lifesteal", -1, 6, 6, "dmg-fire", -1, 5, 9, "light", -1, 3, 3, "enr", -1, 10, 10, "regen-mana", -1, 5, 5, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Maelstrom", 0, 1, -1, 1, -1, 19, 14, "ywn", "Yew Wand", -1, -1, 5, 5000, "dblu", "dblu", "", "", "", -1, "", "ltng-min", -1, 1, 1, "ltng-max", -1, 9, 9, "res-ltng", -1, 40, 40, "mana", -1, 13, 13, "cast2", -1, 30, 30, "skill", 74, 1, 3, "skill", 77, 1, 3, "skill", 66, 1, 3, "skill", 76, 1, 3, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Gravenspine", 0, 1, -1, 1, -1, 27, 20, "bwn", "Bone Wand", -1, -1, 5, 5000, "cgrn", "", "", "invbwnu", "", -1, "", "str", -1, 10, 10, "dex", -1, 10, 10, "cold-min", -1, 4, 4, "cold-max", -1, 8, 8, "cold-len", -1, 75, 75, "manasteal", -1, 5, 5, "nec", -1, 2, 2, "mana", -1, 25, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Umes Lament", 0, 1, -1, 1, -1, 38, 28, "gwn", "Grim Wand", -1, -1, 5, 5000, "lblu", "lblu", "", "", "", -1, "", "nec", -1, 2, 2, "mana", -1, 40, 40, "cast2", -1, 20, 20, "howl", -1, 64, 64, "skill", 77, 3, 3, "skill", 87, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Felloak", 0, 1, -1, 1, -1, 4, 3, "clb", "Club", -1, -1, 5, 5000, "lgry", "", "", "invclbu", "", -1, "", "res-ltng", -1, 60, 60, "res-fire", -1, 20, 20, "knock", -1, 1, 1, "fire-min", -1, 6, 6, "fire-max", -1, 8, 8, "dmg%", -1, 70, 80, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Knell Striker", 0, 1, -1, 1, -1, 7, 5, "scp", "Scepter", -1, -1, 5, 5000, "dred", "dred", "", "", "", -1, "", "crush", -1, 25, 25, "res-fire", -1, 20, 20, "res-pois", -1, 20, 20, "mana", -1, 15, 15, "att", -1, 35, 35, "dmg%", -1, 70, 80, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Rusthandle", 0, 1, -1, 1, -1, 23, 17, "gsc", "Grand Scepter", -1, -1, 5, 5000, "lgld", "lgld", "", "", "", -1, "", "pal", -1, 1, 1, "dmg-norm", -1, 3, 7, "red-mag", -1, 1, 1, "lifesteal", -1, 8, 8, "dmg%", -1, 50, 60, "dmg-undead", -1, 50, 60, "skill", 111, 1, 3, "skill", 103, 3, 3, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Stormeye", 0, 1, -1, 1, -1, 31, 23, "wsp", "War Scepter", -1, -1, 5, 5000, "cred", "cred", "", "", "", -1, "", "dmg-ltng", -1, 1, 6, "dmg-cold", 75, 3, 5, "regen", -1, 10, 10, "dmg%", -1, 80, 120, "skill", 110, 3, 5, "skill", 118, 3, 3, "skill", 121, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Stoutnail", 0, 1, -1, 1, -1, 7, 5, "spc", "Spiked Club", -1, -1, 5, 5000, "dgry", "", "", "invspcu", "", -1, "", "thorns", -1, 3, 10, "dmg%", -1, 100, 100, "vit", -1, 7, 7, "red-mag", -1, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Crushflange", 0, 1, -1, 1, -1, 12, 9, "mac", "Mace", -1, -1, 5, 5000, "blac", "blac", "", "", "", -1, "", "str", -1, 15, 15, "knock", -1, 1, 1, "light", -1, 2, 2, "res-fire", -1, 50, 50, "dmg%", -1, 50, 60, "crush", -1, 33, 33, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Bloodrise", 0, 1, -1, 1, -1, 20, 15, "mst", "Morning Star", -1, -1, 5, 5000, "lblu", "", "", "invmstu", "", -1, "", "dmg%", -1, 120, 120, "att%", -1, 50, 50, "openwounds", -1, 25, 25, "light", -1, 2, 2, "swing1", -1, 10, 10, "skill", 96, 3, 3, "lifesteal", -1, 5, 5, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Generals Tan Do Li Ga", 0, 1, -1, 1, -1, 28, 21, "fla", "Flail", -1, -1, 5, 5000, "dblu", "dblu", "", "", "", -1, "", "dmg-min", -1, 1, 1, "dmg-max", -1, 20, 20, "slow", -1, 50, 50, "ac", -1, 25, 25, "manasteal", -1, 5, 5, "dmg%", -1, 50, 60, "swing2", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Ironstone", 0, 1, -1, 1, -1, 36, 27, "whm", "War Hammer", -1, -1, 5, 5000, "cblu", "cblu", "", "", "", -1, "", "att", -1, 100, 150, "dmg%", -1, 100, 150, "ltng-min", -1, 1, 1, "ltng-max", -1, 10, 10, "str", -1, 10, 10, "*enr", -1, -5, -5, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Bonesob", 0, 1, -1, 1, -1, 32, 24, "mau", "Maul", -1, -1, 5, 5000, "lred", "", "", "invmauu", "", -1, "", "dmg%", -1, 200, 300, "crush", -1, 40, 40, "res-fire", -1, 30, 30, "res-cold", -1, 30, 30, "dmg-undead", -1, 50, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Steeldriver", 0, 1, -1, 1, -1, 39, 29, "gma", "Great Maul", -1, -1, 5, 5000, "cgrn", "cgrn", "", "invgma", "", -1, "", "ease", -1, -50, -50, "swing3", -1, 40, 40, "regen-stam", -1, 25, 25, "dmg%", -1, 150, 250, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Rixots Keen", 0, 1, -1, 1, -1, 3, 2, "ssd", "Short Sword", -1, -1, 5, 5000, "blac", "blac", "", "", "", -1, "", "dmg-min", -1, 5, 5, "att%", -1, 20, 20, "light", -1, 2, 2, "crush", -1, 25, 25, "ac", -1, 25, 25, "dmg%", -1, 100, 100, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Blood Crescent", 0, 1, -1, 1, -1, 10, 7, "scm", "Scimitar", -1, -1, 5, 5000, "lblu", "", "", "invscmu", "", -1, "", "res-all", -1, 15, 15, "dmg%", -1, 60, 80, "hp", -1, 15, 15, "light", -1, 4, 4, "openwounds", -1, 33, 33, "swing2", -1, 15, 15, "lifesteal", -1, 15, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Krintizs Skewer", 0, 1, -1, 1, -1, 14, 10, "sbr", "Saber", -1, -1, 5, 5000, "cblu", "", "", "inv9sbu", "", -1, "", "ignore-ac", -1, 1, 1, "str", -1, 10, 10, "dex", -1, 10, 10, "manasteal", -1, 7, 7, "dmg%", -1, 50, 50, "dmg-norm", -1, 3, 7, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Gleamscythe", 0, 1, -1, 1, -1, 18, 13, "flc", "Falchion", -1, -1, 5, 5000, "lred", "", "", "invflcu", "", -1, "", "light", -1, 3, 3, "mana", -1, 30, 30, "ac", -1, 20, 20, "swing2", -1, 20, 20, "dmg%", -1, 60, 100, "dmg-cold", 50, 3, 5, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "azurewrath 1", 0, 1, -1, 1, -1, 18, 13, "crs", "Crystal Sword", -1, -1, 5, 5000, "lgry", "", "", "invcrsu", "", -1, "", "deadly", -1, 50, 50, "mag%", -1, 10, 10, "dmg-cold", 100, 3, 6, "dmg%", -1, 100, 100, "dur", -1, 25, 25, "dmg-mag", -1, 5, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Griswolds Edge", 0, 1, -1, 1, -1, 23, 17, "bsd", "Broad Sword", -1, -1, 5, 5000, "cred", "", "", "invbsdu", "", -1, "", "fire-min", -1, 10, 12, "fire-max", -1, 15, 25, "att", -1, 100, 100, "swing1", -1, 10, 10, "knock", -1, 1, 1, "dmg%", -1, 80, 120, "str", -1, 12, 12, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Hellplague", 0, 1, -1, 1, -1, 30, 22, "lsd", "Long Sword", -1, -1, 5, 5000, "dred", "", "", "invlsdu", "", -1, "", "manasteal", -1, 5, 5, "lifesteal", -1, 5, 5, "pois-min", -1, 48, 48, "pois-max", -1, 96, 96, "pois-len", -1, 150, 150, "dmg%", -1, 70, 80, "dmg-fire", -1, 25, 75, "fireskill", -1, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Culwens Point", 0, 1, -1, 1, -1, 39, 29, "wsd", "War Sword", -1, -1, 5, 5000, "whit", "whit", "", "", "", -1, "", "allskills", -1, 1, 1, "res-pois-len", -1, 50, 50, "balance2", -1, 20, 20, "swing2", -1, 20, 20, "att", -1, 60, 60, "dmg%", -1, 70, 80, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Shadowfang", 0, 1, -1, 1, -1, 16, 12, "2hs", "2-Handed Sword", -1, -1, 5, 5000, "cgrn", "", "", "inv2hsu", "", -1, "", "manasteal", -1, 9, 9, "res-cold", -1, 20, 20, "light", -1, -2, -2, "dmg-cold", 150, 10, 30, "dmg%", -1, 100, 100, "lifesteal", -1, 9, 9, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Soulflay", 0, 1, -1, 1, -1, 26, 19, "clm", "Claymore", -1, -1, 5, 5000, "dgrn", "dgrn", "", "", "", -1, "", "manasteal", -1, 4, 10, "lifesteal", -1, 4, 4, "dmg%", -1, 70, 100, "res-all", -1, 5, 5, "swing2", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Kinemils Awl", 0, 1, -1, 1, -1, 31, 23, "gis", "Giant Sword", -1, -1, 5, 5000, "dblu", "", "", "invgisu", "", -1, "", "att", -1, 100, 150, "mana", -1, 20, 20, "fire-min", -1, 6, 6, "fire-max", -1, 20, 40, "dmg%", -1, 80, 100, "skill", 102, 6, 6, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Blacktongue", 0, 1, -1, 1, -1, 35, 26, "bsw", "Bastard Sword", -1, -1, 5, 5000, "lgrn", "", "", "invbswu", "", -1, "", "dmg-pois", 150, 192, 192, "noheal", -1, 1, 1, "att", -1, 50, 50, "res-pois", -1, 50, 50, "dmg%", -1, 50, 60, "*hp", -1, -10, -10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Ripsaw", 0, 1, -1, 1, -1, 35, 26, "flb", "Flamberge", -1, -1, 5, 5000, "cblu", "cblu", "", "", "", -1, "", "openwounds", -1, 80, 80, "dmg-max", -1, 15, 15, "manasteal", -1, 6, 6, "dmg%", -1, 80, 100, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Patriarch", 0, 1, -1, 1, -1, 39, 29, "gsd", "Great Sword", -1, -1, 5, 5000, "cred", "", "", "invgsdu", "", -1, "", "red-dmg", -1, 3, 3, "red-mag", -1, 3, 3, "stupidity", -1, 1, 1, "gold%", -1, 100, 100, "dmg%", -1, 100, 120, "str", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Gull", 0, 1, -1, 1, -1, 6, 4, "dgr", "Dagger", -1, -1, 5, 5000, "lgry", "lgry", "", "", "", -1, "", "dmg-min", -1, 1, 1, "dmg-max", -1, 15, 15, "mag%", -1, 100, 100, "mana", -1, -5, -5, "", -1, -1, -1, "", -1, 0, 0, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Diggler", 0, 1, -1, 1, -1, 15, 11, "dir", "Dirk", -1, -1, 5, 5000, "dgry", "dgry", "", "", "", -1, "", "dex", -1, 10, 10, "dmg%", -1, 50, 50, "swing3", -1, 30, 30, "res-cold", -1, 25, 25, "res-fire", -1, 25, 25, "ignore-ac", -1, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Jade Tan Do", 0, 1, -1, 1, -1, 26, 19, "kri", "Kris", -1, -1, 5, 5000, "oran", "", "", "invkrsu", "", -1, "", "att", -1, 100, 150, "nofreeze", -1, 1, 1, "dmg-pois", 100, 460, 460, "res-pois", -1, 95, 95, "res-pois-max", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Irices Shard", 0, 1, -1, 1, -1, 34, 25, "bld", "Blade", -1, -1, 5, 5000, "dblu", "dblu", "", "", "", -1, "", "cast3", -1, 50, 50, "mana", -1, 50, 50, "att", -1, 55, 55, "res-all", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Dragon Chang", 0, 1, -1, 1, -1, 11, 8, "spr", "Spear", -1, -1, 5, 5000, "dpur", "dpur", "", "", "", -1, "", "att", -1, 35, 35, "dmg-min", -1, 10, 10, "light", -1, 2, 2, "dmg-undead", -1, 100, 100, "dmg-fire", -1, 3, 6, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Razortine", 0, 1, -1, 1, -1, 16, 12, "tri", "Trident", -1, -1, 5, 5000, "oran", "", "", "invtriu", "", -1, "", "slow", -1, 25, 25, "reduce-ac", -1, 50, 50, "str", -1, 15, 15, "dex", -1, 8, 8, "swing2", -1, 30, 30, "dmg%", -1, 30, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Bloodthief", 0, 1, -1, 1, -1, 23, 17, "brn", "Brandistock", -1, -1, 5, 5000, "whit", "whit", "", "", "", -1, "", "openwounds", -1, 35, 35, "str", -1, 10, 10, "lifesteal", -1, 8, 12, "hp", -1, 26, 26, "dmg%", -1, 50, 70, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Lance of Yaggai", 0, 1, -1, 1, -1, 30, 22, "spt", "Spetum", -1, -1, 5, 5000, "lred", "lred", "", "", "", -1, "", "thorns", -1, 8, 8, "ltng-min", -1, 1, 1, "ltng-max", -1, 60, 60, "res-all", -1, 15, 15, "swing2", -1, 40, 40, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Tannr Gorerod", 0, 1, -1, 1, -1, 36, 27, "pik", "Pike", -1, -1, 5, 5000, "lgry", "lgry", "", "", "", -1, "", "fire-min", -1, 23, 23, "fire-max", -1, 54, 54, "res-fire-max", -1, 15, 15, "hp", -1, 30, 30, "att", -1, 60, 60, "light", -1, 3, 3, "res-fire", -1, 15, 15, "dmg%", -1, 80, 100, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Dimoaks Hew", 0, 1, -1, 1, -1, 11, 8, "bar", "Bardiche", -1, -1, 5, 5000, "blac", "blac", "", "", "", -1, "", "dex", -1, 15, 15, "dmg%", -1, 100, 100, "swing2", -1, 20, 20, "ac", -1, -8, -8, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Steelgoad", 0, 1, -1, 1, -1, 19, 14, "vou", "Voulge", -1, -1, 5, 5000, "cgrn", "cgrn", "", "", "", -1, "", "howl", -1, 96, 96, "deadly", -1, 30, 30, "att", -1, 30, 30, "res-all", -1, 5, 5, "dmg%", -1, 60, 80, "dur", -1, 20, 40, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Soul Harvest", 0, 1, -1, 1, -1, 26, 19, "scy", "Scythe", -1, -1, 5, 5000, "dgry", "", "", "invscyu", "", -1, "", "openwounds", -1, 30, 30, "att", -1, 45, 45, "res-all", -1, 20, 20, "dmg%", -1, 50, 90, "manasteal", -1, 10, 10, "enr", -1, 5, 5, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Battlebranch", 0, 1, -1, 1, -1, 34, 25, "pax", "Poleaxe", -1, -1, 5, 5000, "lblu", "lblu", "", "", "", -1, "", "swing3", -1, 30, 30, "dex", -1, 10, 10, "dmg%", -1, 50, 70, "att", -1, 50, 100, "lifesteal", -1, 7, 7, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Woestave", 0, 1, -1, 1, -1, 38, 28, "hal", "Halberd", -1, -1, 5, 5000, "dblu", "dblu", "", "", "", -1, "", "slow", -1, 50, 50, "openwounds", -1, 50, 50, "stupidity", -1, 3, 3, "dmg-ac", -1, -50, -50, "freeze", -1, 1, 1, "light", -1, -3, -3, "noheal", -1, 1, 1, "dmg%", -1, 20, 40, "*enr", -1, -30, -30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Grim Reaper", 0, 1, -1, 1, -1, 39, 29, "wsc", "War Scythe", -1, -1, 5, 5000, "lpur", "lpur", "", "", "", -1, "", "deadly", -1, 100, 100, "noheal", -1, 1, 1, "manasteal", -1, 5, 5, "dmg%", -1, 20, 20, "dmg-min", -1, 15, 15, "*hp", -1, -20, -20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Bane Ash", 0, 1, -1, 1, -1, 7, 5, "sst", "Short Staff", -1, -1, 5, 5000, "lgrn", "lgrn", "", "", "", -1, "", "fire-min", -1, 4, 4, "fire-max", -1, 6, 6, "res-fire", -1, 50, 50, "mana", -1, 30, 30, "swing2", -1, 20, 20, "dmg%", -1, 50, 60, "skill", 36, 5, 5, "skill", 37, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Serpent Lord", 0, 1, -1, 1, -1, 12, 9, "lst", "Long Staff", -1, -1, 5, 5000, "cgrn", "cgrn", "", "", "", -1, "", "dmg-pois", 75, 40, 40, "res-pois", -1, 50, 50, "light", -1, -1, -1, "mana", -1, 10, 10, "dmg%", -1, 30, 40, "manasteal", -1, 100, 100, "reduce-ac", -1, 50, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Lazarus Spire", 0, 1, -1, 1, -1, 24, 18, "cst", "Gnarled Staff", -1, -1, 5, 5000, "lgry", "", "", "invcstu", "", -1, "", "res-ltng", -1, 75, 75, "red-dmg", -1, 5, 5, "enr", -1, 15, 15, "skill", 53, 1, 1, "skill", 49, 2, 2, "skill", 42, 3, 3, "regen-mana", -1, 43, 43, "dmg-ltng", -1, 1, 28, "sor", -1, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Salamander", 0, 1, -1, 1, -1, 28, 21, "bst", "Battle Staff", -1, -1, 5, 5000, "dred", "dred", "", "", "", -1, "", "dmg-fire", -1, 15, 32, "res-fire", -1, 30, 30, "skill", 51, 1, 1, "skill", 47, 2, 2, "skill", 37, 3, 3, "fireskill", -1, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Iron Jang Bong", 0, 1, -1, 1, -1, 38, 28, "wst", "War Staff", -1, -1, 5, 5000, "dyel", "dyel", "", "", "", -1, "", "ac", -1, 30, 30, "cast3", -1, 20, 20, "dmg%", -1, 100, 100, "att%", -1, 50, 50, "skill", 48, 2, 2, "skill", 46, 2, 2, "skill", 44, 3, 3, "sor", -1, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Pluckeye", 0, 1, -1, 1, -1, 10, 7, "sbw", "Short Bow", -1, -1, 5, 5000, "cblu", "cblu", "", "", "", -1, "", "att", -1, 28, 28, "dmg%", -1, 100, 100, "hp", -1, 10, 10, "light", -1, 2, 2, "manasteal", -1, 3, 3, "mana-kill", -1, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Witherstring", 0, 1, -1, 1, -1, 18, 13, "hbw", "Hunter’s Bow", -1, -1, 5, 5000, "lred", "lred", "", "", "", -1, "", "swing3", -1, 30, 30, "dmg-min", -1, 1, 1, "dmg-max", -1, 3, 3, "att", -1, 50, 50, "magicarrow", -1, 3, 3, "dmg%", -1, 40, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Rimeraven", 0, 1, -1, 1, -1, 20, 15, "lbw", "Long Bow", -1, -1, 5, 5000, "dred", "dred", "", "", "", -1, "", "att%", -1, 50, 50, "dex", -1, 3, 3, "explosivearrow", -1, 3, 3, "str", -1, 3, 3, "dmg%", -1, 60, 70, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Piercerib", 0, 1, -1, 1, -1, 27, 20, "cbw", "Composite Bow", -1, -1, 5, 5000, "cred", "", "", "invcbwu", "", -1, "", "res-all", -1, 10, 10, "deadly", -1, 30, 30, "att", -1, 60, 60, "dmg-undead", -1, 100, 100, "dmg%", -1, 40, 60, "swing2", -1, 50, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Pullspite", 0, 1, -1, 1, -1, 34, 25, "sbb", "Short Battle Bow", -1, -1, 5, 5000, "lgrn", "", "", "invsbbu", "", -1, "", "dmg-ltng", -1, 1, 30, "str", -1, 8, 8, "att", -1, 28, 28, "pierce", -1, 25, 25, "res-ltng", -1, 25, 25, "dmg%", -1, 70, 90, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Wizendraw", 0, 1, -1, 1, -1, 35, 26, "lbb", "Long Battle Bow", -1, -1, 5, 5000, "dgrn", "dgrn", "", "", "", -1, "", "magicarrow", -1, 5, 5, "mana", -1, 30, 30, "swing2", -1, 20, 20, "res-cold", -1, 26, 26, "att", -1, 50, 100, "dmg%", -1, 70, 80, "enr", -1, 15, 15, "pierce-cold", -1, 20, 35, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Hellclap", 0, 1, -1, 1, -1, 36, 27, "swb", "Short War Bow", -1, -1, 5, 5000, "cgrn", "", "", "invswbu", "", -1, "", "swing1", -1, 10, 10, "fire-min", -1, 15, 15, "fire-max", -1, 30, 50, "att", -1, 50, 75, "res-fire", -1, 40, 40, "dex", -1, 12, 12, "dmg%", -1, 70, 90, "fireskill", -1, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Blastbark", 0, 1, -1, 1, -1, 38, 28, "lwb", "Long War Bow", -1, -1, 5, 5000, "lyel", "lyel", "", "", "", -1, "", "dmg%", -1, 70, 130, "str", -1, 5, 5, "ama", -1, 1, 1, "manasteal", -1, 3, 3, "skill", 16, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Leadcrow", 0, 1, -1, 1, -1, 12, 9, "lxb", "Light Crossbow", -1, -1, 5, 5000, "dyel", "", "", "invlxbu", "", -1, "", "dex", -1, 10, 10, "hp", -1, 10, 10, "dmg%", -1, 70, 70, "res-pois", -1, 30, 30, "deadly", -1, 25, 25, "att", -1, 40, 40, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Ichorsting", 0, 1, -1, 1, -1, 24, 18, "mxb", "Crossbow", -1, -1, 5, 5000, "lgld", "", "", "invmxbu", "", -1, "", "dmg-pois", 75, 102, 102, "dex", -1, 20, 20, "pierce", -1, 50, 50, "att", -1, 50, 50, "dmg%", -1, 50, 50, "swing2", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Hellcast", 0, 1, -1, 1, -1, 36, 27, "hxb", "Heavy Crossbow", -1, -1, 5, 5000, "dgld", "", "", "invhxbu", "", -1, "", "explosivearrow", -1, 5, 5, "res-fire-max", -1, 15, 15, "res-fire", -1, 15, 15, "att", -1, 70, 70, "swing2", -1, 20, 20, "dmg%", -1, 70, 80, "dmg-fire", -1, 15, 35, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Doomspittle", 0, 1, -1, 1, -1, 38, 28, "rxb", "Repeating Crossbow", -1, -1, 5, 5000, "lpur", "", "", "invrxbu", "", -1, "", "ama", -1, 1, 1, "pierce", -1, 35, 35, "swing3", -1, 30, 30, "hp", -1, 15, 15, "dmg%", -1, 60, 100, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "War Bonnet", 0, 1, -1, 1, -1, 4, 3, "cap", "Cap", -1, -1, 5, 5000, "dpur", "", "", "invcapu", "", -1, "", "hp", -1, 15, 15, "att", -1, 30, 30, "dmg%", -1, 30, 30, "mana", -1, 15, 15, "ac", -1, 14, 14, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Tarnhelm", 0, 1, -1, 1, -1, 20, 15, "skp", "Skull Cap", -1, -1, 5, 5000, "oran", "oran", "", "", "", -1, "", "gold%", -1, 75, 75, "mag%", -1, 25, 50, "allskills", -1, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Coif of Glory", 0, 1, -1, 1, -1, 19, 14, "hlm", "Helm", -1, -1, 5, 5000, "whit", "", "", "invhlmu", "", -1, "", "light-thorns", -1, 7, 7, "stupidity", -1, 1, 1, "res-ltng", -1, 15, 15, "ac-miss", -1, 100, 100, "ac", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Duskdeep", 0, 1, -1, 1, -1, 23, 17, "fhl", "Full Helm", -1, -1, 5, 5000, "lgry", "", "", "invfhlu", "", -1, "", "light", -1, -2, -2, "res-all", -1, 15, 15, "red-dmg", -1, 7, 7, "dmg-max", -1, 8, 8, "ac", -1, 10, 20, "ac%", -1, 30, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Wormskull", 0, 1, -1, 1, -1, 28, 21, "bhm", "Bone Helm", -1, -1, 5, 5000, "lgrn", "", "", "invbhmu", "", -1, "", "nec", -1, 1, 1, "lifesteal", -1, 5, 5, "mana", -1, 10, 10, "res-pois", -1, 25, 25, "dmg-pois", 200, 102, 102, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Howltusk", 0, 1, -1, 1, -1, 34, 25, "ghm", "Great Helm", -1, -1, 5, 5000, "dgry", "dgry", "", "", "", -1, "", "red-mag", -1, 2, 2, "thorns", -1, 3, 3, "ac%", -1, 80, 80, "dmg-to-mana", -1, 35, 35, "knock", -1, 1, 1, "howl", -1, 33, 33, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Undead Crown", 0, 1, -1, 1, -1, 39, 29, "crn", "Crown", -1, -1, 5, 5000, "blac", "blac", "", "", "", -1, "", "lifesteal", -1, 5, 5, "ac", -1, 40, 40, "res-pois", -1, 50, 50, "half-freeze", -1, 1, 1, "ac%", -1, 30, 60, "dmg-undead", -1, 50, 50, "att-undead", -1, 50, 100, "skill", 69, 3, 3, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Face of Horror", 0, 1, -1, 1, -1, 27, 20, "msk", "Mask", -1, -1, 5, 5000, "lblu", "lblu", "", "", "", -1, "", "howl", -1, 64, 64, "str", -1, 20, 20, "res-all", -1, 10, 10, "dmg-undead", -1, 50, 50, "ac", -1, 25, 25, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Greyform", 0, 1, -1, 1, -1, 10, 7, "qui", "Quilted Armor", -1, -1, 5, 5000, "lgry", "lgry", "", "", "", -1, "", "red-mag", -1, 3, 3, "res-cold", -1, 20, 20, "res-fire", -1, 20, 20, "dex", -1, 10, 10, "lifesteal", -1, 5, 5, "ac", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Blinkbats Form", 0, 1, -1, 1, -1, 16, 12, "lea", "Leather Armor", -1, -1, 5, 5000, "dred", "dred", "", "", "", -1, "", "ac-miss", -1, 50, 50, "move2", -1, 10, 10, "ac", -1, 25, 25, "fire-min", -1, 3, 3, "fire-max", -1, 6, 6, "balance2", -1, 40, 40, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Centurion", 0, 1, -1, 1, -1, 19, 14, "hla", "Hard Leather", -1, -1, 5, 5000, "cred", "cred", "", "", "", -1, "", "ac", -1, 30, 30, "att", -1, 50, 50, "red-dmg", -1, 2, 2, "hp", -1, 15, 15, "mana", -1, 15, 15, "stam", -1, 15, 15, "regen", -1, 5, 5, "stamdrain", -1, 25, 25, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Twitchthroe", 0, 1, -1, 1, -1, 22, 16, "stu", "Studded Leather", -1, -1, 5, 5000, "lgrn", "lgrn", "", "", "", -1, "", "swing2", -1, 20, 20, "dex", -1, 10, 10, "block", -1, 25, 25, "ac", -1, 25, 25, "str", -1, 10, 10, "balance2", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Darkglow", 0, 1, -1, 1, -1, 19, 14, "rng", "Ring Mail", -1, -1, 5, 5000, "dgrn", "dgrn", "", "", "", -1, "", "att", -1, 20, 20, "res-all-max", -1, 5, 5, "light", -1, 3, 3, "ac-hth", -1, 50, 50, "res-all", -1, 10, 10, "ac%", -1, 70, 100, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Hawkmail", 0, 1, -1, 1, -1, 20, 15, "scl", "Scale Mail", -1, -1, 5, 5000, "cgrn", "cgrn", "", "", "", -1, "", "ac%", -1, 80, 100, "res-cold-max", -1, 15, 15, "res-cold", -1, 15, 15, "nofreeze", -1, 1, 1, "move2", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Sparking Mail", 0, 1, -1, 1, -1, 23, 17, "chn", "Chain Mail", -1, -1, 5, 5000, "lyel", "lyel", "", "", "", -1, "", "ac%", -1, 75, 85, "dmg-ltng", -1, 1, 20, "light-thorns", -1, 10, 14, "res-ltng", -1, 30, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Venomsward", 0, 1, -1, 1, -1, 27, 20, "brs", "Breast Plate", -1, -1, 5, 5000, "dyel", "dyel", "", "", "", -1, "", "res-pois-max", -1, 15, 15, "res-pois-len", -1, 50, 50, "res-pois", -1, 90, 90, "light", -1, 2, 2, "ac%", -1, 60, 100, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Iceblink", 0, 1, -1, 1, -1, 30, 22, "spl", "Splint Mail", -1, -1, 5, 5000, "lgld", "lgld", "", "", "", -1, "", "freeze", -1, 1, 1, "res-cold", -1, 30, 30, "light", -1, 4, 4, "red-mag", -1, 1, 1, "ac%", -1, 70, 80, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Boneflesh", 0, 1, -1, 1, -1, 35, 26, "plt", "Plate Mail", -1, -1, 5, 5000, "dgld", "dgld", "", "", "", -1, "", "lifesteal", -1, 5, 5, "ac%", -1, 100, 120, "att", -1, 35, 35, "openwounds", -1, 25, 25, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Rockfleece", 0, 1, -1, 1, -1, 38, 28, "fld", "Field Plate", -1, -1, 5, 5000, "dgry", "dgry", "", "", "", -1, "", "ease", -1, -10, -10, "ac%", -1, 100, 130, "red-dmg%", -1, 10, 10, "red-dmg", -1, 5, 5, "str", -1, 5, 5, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Rattlecage", 0, 1, -1, 1, -1, 39, 29, "gth", "Gothic Plate", -1, -1, 5, 5000, "dpur", "dpur", "", "", "", -1, "", "howl", -1, 52, 52, "att", -1, 45, 45, "crush", -1, 25, 25, "ac", -1, 200, 200, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Goldskin", 0, 1, -1, 1, -1, 38, 28, "ful", "Full Plate Mail", -1, -1, 5, 5000, "oran", "", "", "invfulu", "", -1, "", "ac%", -1, 120, 150, "res-all", -1, 35, 35, "thorns", -1, 10, 10, "light", -1, 2, 2, "gold%", -1, 100, 100, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Victors Silk", 0, 1, -1, 1, -1, 38, 28, "aar", "AncientArmor", -1, -1, 5, 5000, "dblu", "", "", "invaaru", "", -1, "", "manasteal", -1, 5, 5, "allskills", -1, 1, 1, "light", -1, 2, 2, "ac%", -1, 100, 120, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Heavenly Garb", 0, 1, -1, 1, -1, 39, 29, "ltp", "Light Plate", -1, -1, 5, 5000, "cblu", "cblu", "", "", "", -1, "", "ac%", -1, 100, 100, "res-all", -1, 10, 10, "regen-mana", -1, 25, 25, "enr", -1, 15, 15, "dmg-undead", -1, 50, 50, "att-undead", -1, 100, 100, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Pelta Lunata", 0, 1, -1, 1, -1, 3, 2, "buc", "Buckler", -1, -1, 5, 5000, "whit", "", "", "invbucu", "", -1, "", "ac", -1, 30, 30, "vit", -1, 10, 10, "str", -1, 2, 2, "enr", -1, 10, 10, "ac%", -1, 30, 40, "block", -1, 20, 20, "block2", -1, 40, 40, "dur", -1, 8, 12, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Umbral Disk", 0, 1, -1, 1, -1, 12, 9, "sml", "Small Shield", -1, -1, 5, 5000, "lgry", "", "", "invsmlu", "", -1, "", "stupidity", -1, 1, 1, "dex", -1, 10, 10, "ac", -1, 30, 30, "hp", -1, 20, 20, "light", -1, -2, -2, "ac%", -1, 40, 50, "block", -1, 30, 30, "dur", -1, 10, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Stormguild", 0, 1, -1, 1, -1, 18, 13, "lrg", "Large Shield", -1, -1, 5, 5000, "dgry", "", "", "invlrgu", "", -1, "", "red-mag", -1, 1, 1, "res-ltng", -1, 25, 25, "ac", -1, 30, 30, "dmg-ltng", -1, 1, 6, "ac%", -1, 50, 60, "block", -1, 30, 30, "light-thorns", -1, 3, 3, "dur", -1, 10, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Wall of the Eyeless", 0, 1, -1, 1, -1, 27, 20, "bsh", "Bone Shield", -1, -1, 5, 5000, "lgld", "", "", "invbshu", "", -1, "", "mana-kill", -1, 5, 5, "manasteal", -1, 3, 3, "cast2", -1, 20, 20, "res-pois", -1, 20, 20, "ac%", -1, 30, 40, "ac", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Swordback Hold", 0, 1, -1, 1, -1, 20, 15, "spk", "Spiked Shield", -1, -1, 5, 5000, "lred", "", "", "invspku", "", -1, "", "thorns", -1, 5, 5, "block", -1, 20, 20, "openwounds", -1, 50, 50, "bloody", -1, 3, 5, "ac%", -1, 30, 60, "thorns", -1, 5, 5, "ac", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Steelclash", 0, 1, -1, 1, -1, 23, 17, "kit", "Kite Shield", -1, -1, 5, 5000, "blac", "", "", "invkitu", "", -1, "", "block", -1, 25, 25, "pal", -1, 1, 1, "red-dmg", -1, 3, 3, "light", -1, 3, 3, "ac%", -1, 60, 100, "block2", -1, 20, 20, "res-all", -1, 15, 15, "ac", -1, 20, 20, "dur", -1, 15, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Bverrit Keep", 0, 1, -1, 1, -1, 26, 19, "tow", "Tower Shield", -1, -1, 5, 5000, "lblu", "", "", "invtowu", "", -1, "", "ac", -1, 30, 30, "res-fire", -1, 75, 75, "str", -1, 5, 5, "red-mag", -1, 5, 5, "ac%", -1, 80, 120, "block", -1, 10, 10, "dur", -1, 80, 100, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Ward", 0, 1, -1, 1, -1, 35, 26, "gts", "Gothic Shield", -1, -1, 5, 5000, "dblu", "", "", "invgtsu", "", -1, "", "ac", -1, 40, 40, "red-mag", -1, 2, 2, "str", -1, 10, 10, "block", -1, 10, 10, "ac%", -1, 100, 100, "res-all", -1, 30, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Hand of Broc", 0, 1, -1, 1, -1, 7, 5, "lgl", "Gloves", -1, -1, 5, 5000, "cblu", "cblu", "", "", "", -1, "", "manasteal", -1, 3, 3, "lifesteal", -1, 3, 3, "res-pois", -1, 10, 10, "mana", -1, 20, 20, "ac", -1, 10, 10, "ac%", -1, 10, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Bloodfist", 0, 1, -1, 1, -1, 12, 9, "vgl", "Heavy Gloves", -1, -1, 5, 5000, "oran", "oran", "", "", "", -1, "", "dmg-min", -1, 5, 5, "hp", -1, 40, 40, "balance2", -1, 30, 30, "ac", -1, 10, 10, "ac%", -1, 10, 20, "swing2", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Chance Guards", 0, 1, -1, 1, -1, 20, 15, "mgl", "Bracers", -1, -1, 5, 5000, "lred", "lred", "", "", "", -1, "", "gold%", -1, 200, 200, "mag%", -1, 25, 40, "att", -1, 25, 25, "ac", -1, 15, 15, "light", -1, 2, 2, "ac%", -1, 20, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Magefist", 0, 1, -1, 1, -1, 31, 23, "tgl", "Light Gauntlets", -1, -1, 5, 5000, "lgry", "lgry", "", "", "", -1, "", "cast3", -1, 20, 20, "regen-mana", -1, 25, 25, "fireskill", -1, 1, 1, "dmg-fire", -1, 1, 6, "ac", -1, 10, 10, "ac%", -1, 20, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Frostburn", 0, 1, -1, 1, -1, 39, 29, "hgl", "Gauntlets", -1, -1, 5, 5000, "dred", "dred", "", "", "", -1, "", "ac", -1, 30, 30, "dmg%", -1, 5, 5, "mana%", -1, 40, 40, "dmg-cold", 50, 1, 6, "ac%", -1, 10, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Hotspur", 0, 1, -1, 1, -1, 7, 5, "lbt", "Leather Boots", -1, -1, 5, 5000, "cred", "cred", "", "", "", -1, "", "res-fire-max", -1, 15, 15, "hp", -1, 15, 15, "dmg-fire", -1, 3, 6, "ac", -1, 6, 6, "res-fire", -1, 45, 45, "ac%", -1, 10, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Gorefoot", 0, 1, -1, 1, -1, 12, 9, "vbt", "Heavy Boots", -1, -1, 5, 5000, "dblu", "dblu", "", "", "", -1, "", "bloody", -1, 3, 5, "move2", -1, 20, 20, "manasteal", -1, 2, 2, "thorns", -1, 2, 2, "ac", -1, 12, 12, "ac%", -1, 20, 30, "skill", 132, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Treads of Cthon", 0, 1, -1, 1, -1, 20, 15, "mbt", "Chain Boots", -1, -1, 5, 5000, "lgrn", "lgrn", "", "", "", -1, "", "move2", -1, 30, 30, "ac-miss", -1, 50, 50, "stamdrain", -1, 50, 50, "hp", -1, 10, 10, "ac", -1, 12, 12, "ac%", -1, 30, 40, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Goblin Toe", 0, 1, -1, 1, -1, 30, 22, "tbt", "Light Plate Boots", -1, -1, 5, 5000, "dgry", "dgry", "", "", "", -1, "", "crush", -1, 25, 25, "red-dmg", -1, 1, 1, "red-mag", -1, 1, 1, "ac", -1, 15, 15, "light", -1, -1, -1, "ac%", -1, 50, 60, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Tearhaunch", 0, 1, -1, 1, -1, 39, 29, "hbt", "Plate Boots", -1, -1, 5, 5000, "dgrn", "dgrn", "", "", "", -1, "", "ac", -1, 35, 35, "str", -1, 5, 5, "dex", -1, 5, 5, "move2", -1, 20, 20, "res-all", -1, 10, 10, "ac%", -1, 60, 80, "skill", 115, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Lenyms Cord", 0, 1, -1, 1, -1, 10, 7, "lbl", "Sash", -1, -1, 5, 5000, "cgrn", "cgrn", "", "", "", -1, "", "mana", -1, 15, 15, "regen-mana", -1, 30, 30, "res-all", -1, 5, 5, "light", -1, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Snakecord", 0, 1, -1, 1, -1, 16, 12, "vbl", "Light Belt", -1, -1, 5, 5000, "blac", "blac", "", "", "", -1, "", "dmg-pois", 75, 40, 40, "res-pois", -1, 25, 25, "ac", -1, 10, 10, "ac%", -1, 20, 30, "regen", -1, 5, 5, "res-pois-len", -1, 50, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Nightsmoke", 0, 1, -1, 1, -1, 27, 20, "mbl", "Belt", -1, -1, 5, 5000, "lyel", "lyel", "", "", "", -1, "", "res-all", -1, 10, 10, "dmg-to-mana", -1, 50, 50, "mana", -1, 20, 20, "red-dmg", -1, 2, 2, "ac", -1, 15, 15, "ac%", -1, 30, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Goldwrap", 0, 1, -1, 1, -1, 36, 27, "tbl", "Heavy Belt", -1, -1, 5, 5000, "lblu", "lblu", "", "", "", -1, "", "mag%", -1, 30, 30, "light", -1, 2, 2, "ac", -1, 25, 25, "swing2", -1, 10, 10, "ac%", -1, 40, 60, "gold%", -1, 50, 80, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Bladebuckle", 0, 1, -1, 1, -1, 39, 29, "hbl", "Girdle", -1, -1, 5, 5000, "dyel", "dyel", "", "", "", -1, "", "thorns", -1, 8, 8, "ac", -1, 30, 30, "red-dmg", -1, 3, 3, "str", -1, 5, 5, "dex", -1, 10, 10, "ac%", -1, 80, 100, "balance2", -1, 30, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Nokozan Relic", 0, 1, -1, 20, -1, 14, 10, "amu", "Amulet", -1, -1, 5, 5000, "lgld", "", "", "", "", -1, "", "dmg-fire", -1, 3, 6, "res-fire-max", -1, 10, 10, "res-fire", -1, 50, 50, "light", -1, 3, 3, "balance2", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Eye of Etlich", 0, 1, -1, 5, -1, 20, 15, "amu", "Amulet", -1, -1, 5, 5000, "dgld", "", "", "", "", -1, "", "ac-miss", -1, 10, 40, "light", -1, 1, 5, "allskills", -1, 1, 1, "lifesteal", -1, 3, 7, "cold-min", -1, 1, 2, "cold-max", -1, 3, 5, "cold-len", -1, 50, 250, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Mahim-Oak Curio", 0, 1, -1, 10, -1, 34, 25, "amu", "Amulet", -1, -1, 5, 5000, "lpur", "", "", "", "", -1, "", "dex", -1, 10, 10, "str", -1, 10, 10, "enr", -1, 10, 10, "vit", -1, 10, 10, "ac", -1, 10, 10, "att%", -1, 10, 10, "res-all", -1, 10, 10, "ac%", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Nagelring", 0, 1, -1, 15, -1, 10, 7, "rin", "Ring", -1, -1, 5, 5000, "dpur", "", "", "", "", -1, "", "red-mag", -1, 3, 3, "thorns", -1, 3, 3, "att", -1, 50, 75, "mag%", -1, 15, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Manald Heal", 0, 1, -1, 15, -1, 20, 15, "rin", "Ring", -1, -1, 5, 5000, "oran", "", "", "", "", -1, "", "manasteal", -1, 4, 7, "regen", -1, 5, 8, "hp", -1, 20, 20, "regen-mana", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Stone of Jordan", 0, 1, -1, 1, -1, 39, 29, "rin", "Ring", -1, -1, 5, 5000, "whit", "", "", "", "", -1, "", "mana", -1, 20, 20, "mana%", -1, 25, 25, "ltng-min", -1, 1, 1, "allskills", -1, 1, 1, "ltng-max", -1, 12, 12, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Amulet of the Viper", 0, 1, -1, 1, -1, 0, 0, "vip", "Amulet", -1, -1, 5, 5000, "lgry", "", "", "", "", -1, "", "mana", -1, 10, 10, "res-pois", -1, 25, 25, "hp", -1, 10, 10, "", -1, 0, 0, "", -1, 0, 0, "", -1, 0, 0, "", -1, 0, 0, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Staff of Kings", 0, 1, -1, 1, -1, 0, 0, "msf", "Staff", -1, -1, 5, 5000, "dgry", "", "", "", "", -1, "", "res-all", -1, 10, 10, "swing3", -1, 50, 50, "", -1, 0, 0, "", -1, 0, 0, "", -1, 0, 0, "", -1, 0, 0, "", -1, 0, 0, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Horadric Staff", 0, 1, -1, 1, -1, 0, 0, "hst", "Staff", -1, -1, 5, 5000, "blac", "", "", "", "", -1, "", "mana", -1, 10, 10, "res-pois", -1, 25, 25, "hp", -1, 10, 10, "res-all", -1, 10, 10, "swing3", -1, 50, 50, "", -1, 0, 0, "", -1, 0, 0, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Hell Forge Hammer", 0, 1, -1, 1, -1, 0, 0, "hfh", "Hammer", -1, -1, 5, 5000, "cred", "", "", "", "", -1, "", "fire-min", -1, 5, 5, "fire-max", -1, 20, 20, "res-fire", -1, 40, 40, "ac", -1, 35, 35, "", -1, 0, 0, "", -1, 0, 0, "", -1, 0, 0, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "KhalimFlail", 0, 1, -1, 1, -1, 0, 0, "qf1", "Flail", -1, -1, 5, 5000, "dblu", "", "", "", "", -1, "", "ltng-min", -1, 1, 1, "ltng-max", -1, 20, 20, "swing3", -1, 50, 50, "att", -1, 40, 40, "", -1, 0, 0, "", -1, 0, 0, "", -1, 0, 0, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "SuperKhalimFlail", 0, 1, -1, 1, -1, 0, 0, "qf2", "Flail", -1, -1, 5, 5000, "dblu", "", "", "", "", -1, "", "ltng-min", -1, 1, 1, "ltng-max", -1, 40, 40, "swing3", -1, 50, 50, "att", -1, 40, 40, "manasteal", -1, 6, 6, "lifesteal", -1, 6, 6, "", -1, 0, 0, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Coldkill", 100, 1, -1, 1, -1, 44, 36, "9ha", "Hatchet", -1, -1, 5, 5000, "cblu", "cblu", "", "invhaxu", "", -1, "", "dmg-cold", 50, 40, 40, "res-cold", -1, 15, 15, "res-cold-max", -1, 15, 15, "swing3", -1, 30, 30, "hit-skill", 45, 10, 10, "gethit-skill", 44, 10, 5, "dmg%", -1, 150, 190, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Butcher's Pupil", 100, 1, -1, 1, -1, 47, 39, "9ax", "Cleaver", -1, -1, 5, 5000, "cblu", "cblu", "", "invaxeu", "", -1, "", "deadly", -1, 35, 35, "openwounds", -1, 25, 25, "dmg%", -1, 150, 200, "indestruct", -1, 1, 1, "swing3", -1, 30, 30, "dmg-norm", -1, 30, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Islestrike", 100, 1, -1, 1, -1, 51, 43, "92a", "Twin Axe", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "dru", -1, 2, 2, "str", -1, 10, 10, "dex", -1, 10, 10, "vit", -1, 10, 10, "enr", -1, 10, 10, "ac-miss", -1, 50, 50, "crush", -1, 25, 25, "dmg%", -1, 170, 190, "skill", 233, 1, 1, "skill", 248, 1, 1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Pompe's Wrath", 100, 1, -1, 1, -1, 53, 45, "9mp", "Crowbill", -1, -1, 5, 5000, "cred", "cred", "", "invmpiu", "", -1, "", "hit-skill", 244, 4, 8, "slow", -1, 50, 50, "dmg-fire", -1, 35, 150, "knock", -1, 1, 1, "dmg%", -1, 140, 170, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Guardian Naga", 100, 1, -1, 1, -1, 56, 48, "9wa", "Naga", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "hit-skill", 92, 5, 8, "thorns", -1, 15, 15, "res-pois", -1, 30, 30, "dmg%", -1, 150, 180, "dmg-pois", 250, 256, 256, "dmg-max", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Warlord's Trust", 100, 1, -1, 1, -1, 43, 35, "9la", "Military Axe", -1, -1, 5, 5000, "whit", "whit", "", "", "", -1, "", "ac", -1, 75, 75, "regen", -1, 20, 20, "vit/lvl", 4, -1, -1, "res-all", -1, 10, 10, "rep-dur", 25, -1, -1, "dmg%", -1, 175, 175, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Spellsteel", 100, 1, -1, 1, -1, 47, 39, "9ba", "Bearded Axe", -1, -1, 5, 5000, "whit", "whit", "", "", "", -1, "", "ease", -1, -60, -60, "mana", -1, 100, 100, "red-mag", -1, 12, 15, "cast1", -1, 10, 10, "dmg%", -1, 165, 165, "regen-mana", -1, 25, 25, "charged", 54, 20, 1, "charged", 87, 30, 3, "charged", 101, 100, 10, "charged", 225, 60, 12, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Stormrider", 100, 1, -1, 1, -1, 49, 41, "9bt", "Tabar", -1, -1, 5, 5000, "lred", "lred", "", "inv9btu", "", -1, "", "hit-skill", 53, 5, 10, "hit-skill", 38, 10, 0, "dmg-ltng", -1, 1, 200, "dmg-norm", -1, 35, 75, "dmg%", -1, 100, 100, "dur", -1, 50, 50, "light-thorns", -1, 15, 15, "gethit-skill", 38, 15, 5, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Boneslayer Blade", 100, 1, -1, 1, -1, 50, 42, "9ga", "Gothic Axe", -1, -1, 5, 5000, "", "", "", "invgaxu", "", -1, "", "att-und/lvl", 10, -1, -1, "dmg-und/lvl", 20, -1, -1, "str", -1, 8, 8, "swing2", -1, 20, 20, "att%", -1, 35, 35, "dmg%", -1, 180, 220, "charged", 101, 200, 20, "gethit-skill", 101, 50, 0, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Minataur", 100, 1, -1, 1, -1, 53, 45, "9gi", "Ancient Axe", -1, -1, 5, 5000, "", "", "", "inv9giu", "", -1, "", "stupidity", -1, 2, 2, "half-freeze", -1, 1, 1, "str", -1, 15, 20, "slow", -1, 50, 50, "crush", -1, 30, 30, "dmg-norm", -1, 20, 30, "dmg%", -1, 140, 200, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Suicide Branch", 100, 1, -1, 1, -1, 41, 33, "9wn", "Burnt Wand", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "thorns", -1, 25, 25, "cast2", -1, 50, 50, "res-all", -1, 10, 10, "mana%", -1, 10, 10, "hp", -1, 40, 40, "allskills", -1, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Carin Shard", 100, 1, -1, 1, -1, 43, 35, "9yw", "Petrified Wand", -1, -1, 5, 5000, "cblu", "cblu", "", "", "", -1, "", "hp/lvl", 10, -1, -1, "cast2", -1, 10, 10, "mana/lvl", 10, -1, -1, "balance2", -1, 30, 30, "regen", -1, 5, 5, "nec", -1, 1, 1, "skilltab", 8, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Arm of King Leoric", 100, 1, -1, 1, -1, 44, 36, "9bw", "Tomb Wand", -1, -1, 5, 5000, "", "", "", "invbwnu", "", -1, "", "skilltab", 8, 2, 2, "gethit-skill", 93, 5, 10, "mana/lvl", 10, -1, -1, "gethit-skill", 88, 10, 2, "cast1", -1, 10, 10, "skilltab", 7, 2, 2, "skill", 77, 2, 2, "skill", 80, 2, 2, "skill", 69, 3, 3, "skill", 70, 3, 3, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Blackhand Key", 100, 1, -1, 1, -1, 49, 41, "9gw", "Grave Wand", -1, -1, 5, 5000, "blac", "blac", "", "inv9gwu", "", -1, "", "skilltab", 6, 1, 1, "dmg-to-mana", -1, 20, 20, "hp", -1, 50, 50, "light", -1, -2, -2, "cast3", -1, 30, 30, "res-fire", -1, 37, 37, "nec", -1, 2, 2, "charged", 150, 30, 13, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Dark Clan Crusher", 100, 1, -1, 1, -1, 42, 34, "9cl", "Cudgel", -1, -1, 5, 5000, "dgld", "dgld", "", "invclbu", "", -1, "", "dru", -1, 2, 2, "dmg-demon", -1, 200, 200, "att-demon", -1, 200, 200, "dmg%", -1, 195, 195, "att%", -1, 20, 25, "demon-heal", -1, 15, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Zakarum's Hand", 100, 1, -1, 1, -1, 45, 37, "9sc", "Rune Scepter", -1, -1, 5, 5000, "lpur", "lpur", "", "", "", -1, "", "manasteal", -1, 8, 8, "ignore-ac", -1, 1, 1, "regen-mana", -1, 10, 10, "regen-stam", -1, 15, 15, "hit-skill", 59, 6, 5, "dmg%", -1, 180, 220, "swing2", -1, 30, 30, "skill", 114, 2, 2, "skill", 118, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Fetid Sprinkler", 100, 1, -1, 1, -1, 46, 38, "9qs", "Holy Water Sprinkler", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "pal", -1, 2, 2, "hit-skill", 87, 5, 1, "hit-skill", 81, 10, 1, "dmg-pois", 100, 409, 409, "dmg%", -1, 160, 190, "att", -1, 150, 200, "dmg-norm", -1, 15, 25, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Hand of Blessed Light", 100, 1, -1, 1, -1, 50, 42, "9ws", "Divine Scepter", -1, -1, 5, 5000, "lyel", "", "", "", "", -1, "", "pal", -1, 2, 2, "dmg%", -1, 130, 160, "att%", -1, 100, 100, "ac", -1, 50, 50, "regen-mana", -1, 15, 15, "light", -1, 4, 4, "dmg-norm", -1, 20, 45, "skill", 101, 4, 4, "skill", 121, 2, 2, "hit-skill", 121, 5, 4, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Fleshrender", 100, 1, -1, 1, -1, 46, 38, "9sp", "Barbed Club", -1, -1, 5, 5000, "blac", "", "", "invspcu", "", -1, "", "openwounds", -1, 25, 25, "noheal", -1, 1, 1, "crush", -1, 20, 20, "deadly", -1, 20, 20, "dmg-norm", -1, 35, 50, "dmg%", -1, 130, 200, "dru", -1, 1, 1, "skilltab", 16, 2, 2, "dur", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Sureshrill Frost", 100, 1, -1, 1, -1, 47, 39, "9ma", "Flanged Mace", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "dmg-cold", 125, 63, 112, "nofreeze", -1, 1, 1, "dmg%", -1, 150, 180, "dmg-norm", -1, 5, 10, "freeze", -1, 3, 3, "charged", 64, 50, 9, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Moonfall", 100, 1, -1, 1, -1, 50, 42, "9mt", "Jagged Star", -1, -1, 5, 5000, "", "", "", "invmstu", "", -1, "", "hit-skill", 56, 5, 6, "dmg-fire", -1, 55, 115, "red-mag", -1, 9, 12, "dmg%", -1, 120, 150, "light", -1, 2, 2, "charged", 56, 60, 11, "dmg-norm", -1, 10, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Baezil's Vortex", 100, 1, -1, 1, -1, 53, 45, "9fl", "Knout", -1, -1, 5, 5000, "dblu", "dblu", "", "", "", -1, "", "hit-skill", 48, 5, 8, "dmg-ltng", -1, 1, 150, "mana", -1, 100, 100, "res-ltng", -1, 25, 25, "dmg%", -1, 160, 200, "swing2", -1, 20, 20, "charged", 48, 80, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Earthshaker", 100, 1, -1, 1, -1, 51, 43, "9wh", "Battle Hammer", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "hit-skill", 234, 5, 7, "knock", -1, 1, 1, "swing3", -1, 30, 30, "dmg%", -1, 180, 180, "stupidity", -1, 1, 1, "skilltab", 17, 3, 3, "dur", -1, 50, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Bloodtree Stump", 100, 1, -1, 1, -1, 56, 48, "9m9", "War Club", -1, -1, 5, 5000, "dred", "", "", "", "", -1, "", "crush", -1, 50, 50, "dmg%", -1, 180, 220, "res-all", -1, 20, 20, "str", -1, 25, 25, "skilltab", 13, 2, 2, "skill", 129, 3, 3, "dur", -1, 40, 40, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Gavel of Pain", 100, 1, -1, 1, -1, 53, 45, "9gm", "Martel de Fer", -1, -1, 5, 5000, "", "", "", "inv9gmu", "", -1, "", "hit-skill", 66, 5, 1, "gethit-skill", 76, 5, 1, "thorns", -1, 26, 26, "indestruct", -1, 1, 1, "dmg-norm", -1, 12, 30, "dmg%", -1, 130, 160, "charged", 66, 3, 8, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Bloodletter", 100, 1, -1, 1, -1, 38, 30, "9ss", "Gladius", -1, -1, 5, 5000, "cred", "cred", "", "", "", -1, "", "dmg-norm", -1, 12, 45, "att", -1, 90, 90, "lifesteal", -1, 8, 8, "stamdrain", -1, 10, 10, "swing2", -1, 20, 20, "dmg%", -1, 140, 140, "skill", 127, 2, 4, "skill", 151, 1, 3, "dur", -1, 30, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Coldsteel Eye", 100, 1, -1, 1, -1, 39, 31, "9sm", "Cutlass", -1, -1, 5, 5000, "dgry", "", "", "invscmu", "", -1, "", "stupidity", -1, 1, 1, "slow", -1, 30, 30, "deadly", -1, 50, 50, "dur", -1, 50, 50, "dmg%", -1, 200, 250, "swing2", -1, 20, 20, "manasteal", -1, 6, 6, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Hexfire", 100, 1, -1, 1, -1, 41, 33, "9sb", "Shamshir", -1, -1, 5, 5000, "", "", "", "invsbru", "", -1, "", "charged", 62, 36, 6, "ignore-ac", -1, 1, 1, "res-fire", -1, 25, 25, "res-fire-max", -1, 10, 10, "dmg-norm", -1, 35, 40, "dmg%", -1, 140, 160, "fireskill", -1, 3, 3, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Blade of Ali Baba", 100, 1, -1, 1, -1, 43, 35, "9fc", "Tulwar", -1, -1, 5, 5000, "cred", "cred", "", "", "", -1, "", "sock", 3, -1, -1, "gold%/lvl", 20, -1, -1, "mag%/lvl", 8, -1, -1, "mana", -1, 15, 15, "dmg%", -1, 60, 120, "dex", -1, 5, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Ginther's Rift", 100, 1, -1, 1, -1, 45, 37, "9cr", "Dimensional Blade", -1, -1, 5, 5000, "cblu", "", "", "inv9cru", "", -1, "", "red-mag", -1, 7, 12, "swing2", -1, 30, 30, "rep-dur", 20, -1, -1, "dur", -1, 40, 40, "dmg-mag", -1, 50, 120, "dmg%", -1, 100, 150, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Headstriker", 100, 1, -1, 1, -1, 47, 39, "9bs", "Battle Sword", -1, -1, 5, 5000, "bwht", "bwht", "", "", "", -1, "", "noheal", -1, 1, 1, "str", -1, 15, 15, "deadly/lvl", 12, -1, -1, "dmg/lvl", 8, -1, -1, "dmg%", -1, 150, 150, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Plague Bearer", 100, 1, -1, 1, -1, 49, 41, "9ls", "Rune Sword", -1, -1, 5, 5000, "", "", "", "inv9lsu", "", -1, "", "hit-skill", 92, 5, 4, "dmg-pois", 200, 384, 384, "dmg-norm", -1, 10, 45, "dmg%", -1, 150, 150, "res-pois", -1, 45, 45, "skill", 238, 5, 5, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Atlantian", 100, 1, -1, 1, -1, 50, 42, "9wd", "Ancient Sword", -1, -1, 5, 5000, "lblu", "lblu", "", "", "", -1, "", "dur", -1, 100, 100, "ac", -1, 75, 75, "str", -1, 16, 16, "dex", -1, 12, 12, "vit", -1, 8, 8, "dmg%", -1, 200, 250, "pal", -1, 2, 2, "att%", -1, 50, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Crainte Vomir", 100, 1, -1, 1, -1, 50, 42, "92h", "Espadon", -1, -1, 5, 5000, "lgld", "", "", "inv2hsu", "", -1, "", "slow", -1, 35, 35, "dmg-ac", -1, -70, -70, "move2", -1, 20, 20, "red-dmg%", -1, 10, 10, "dmg%", -1, 160, 200, "swing3", -1, 50, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Bing Sz Wang", 100, 1, -1, 1, -1, 51, 43, "9cm", "Dacian Falx", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "ease", -1, -30, -30, "dmg-cold", 75, 50, 140, "str", -1, 20, 20, "freeze", -1, 2, 2, "hit-skill", 64, 5, 3, "dmg%", -1, 130, 160, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Vile Husk", 100, 1, -1, 1, -1, 52, 44, "9gs", "Tusk Sword", -1, -1, 5, 5000, "dgry", "dgry", "", "invgisu", "", -1, "", "hit-skill", 66, 6, 1, "dmg-und/lvl", 60, -1, -1, "res-pois", -1, 50, 50, "dmg-pois", 150, 426, 426, "dmg%", -1, 150, 200, "att-und/lvl", 20, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Cloudcrack", 100, 1, -1, 1, -1, 53, 45, "9b9", "Gothic Sword", -1, -1, 5, 5000, "", "", "", "invbswu", "", -1, "", "hit-skill", 121, 6, 7, "dmg-ltng", -1, 1, 240, "ac", -1, 30, 30, "light", -1, 2, 2, "res-ltng-max", -1, 10, 10, "dmg%", -1, 150, 200, "light-thorns", -1, 15, 15, "skilltab", 10, 2, 2, "skilltab", 11, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Todesfaelle Flamme", 100, 1, -1, 1, -1, 54, 46, "9fb", "Zweihander", -1, -1, 5, 5000, "", "", "", "inv9fbu", "", -1, "", "dmg-fire", -1, 50, 200, "res-fire", -1, 40, 40, "abs-fire", -1, 10, 10, "att-skill", 47, 10, 6, "dmg%", -1, 120, 160, "charged", 52, 45, 10, "charged", 51, 20, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Swordguard", 100, 1, -1, 1, -1, 55, 48, "9gd", "Executioner Sword", -1, -1, 5, 5000, "bwht", "bwht", "", "invgsdu", "", -1, "", "ease", -1, -50, -50, "ac/lvl", 40, -1, -1, "res-all", -1, 10, 20, "ac-miss", -1, 100, 100, "dmg-to-mana", -1, 30, 30, "dmg%", -1, 170, 180, "ac-hth", -1, 200, 200, "balance2", -1, 20, 20, "block", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Spineripper", 100, 1, -1, 1, -1, 40, 32, "9dg", "Poignard", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "ignore-ac", -1, 1, 1, "lifesteal", -1, 8, 8, "noheal", -1, 1, 1, "swing3", -1, 15, 15, "dex", -1, 10, 10, "dmg%", -1, 200, 240, "dmg-norm", -1, 15, 27, "nec", -1, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Heart Carver", 100, 1, -1, 1, -1, 44, 36, "9di", "Rondel", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "deadly", -1, 35, 35, "ignore-ac", -1, 1, 1, "dmg-norm", -1, 15, 35, "dmg%", -1, 190, 240, "skill", 131, 4, 4, "skill", 142, 4, 4, "skill", 150, 4, 4, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Blackbog's Sharp", 100, 1, -1, 1, -1, 46, 38, "9kr", "Cinquedeas", -1, -1, 5, 5000, "", "", "", "invkrsu", "", -1, "", "slow", -1, 50, 50, "ac", -1, 50, 50, "dmg-norm", -1, 15, 45, "swing3", -1, 30, 30, "dmg-pois", 250, 500, 500, "skill", 73, 5, 5, "skill", 83, 4, 4, "skill", 92, 4, 4, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Stormspike", 100, 1, -1, 1, -1, 49, 41, "9bl", "Stilleto", -1, -1, 5, 5000, "cblu", "cblu", "", "inv9blu", "", -1, "", "dmg-ltng", -1, 1, 120, "light-thorns", -1, 20, 20, "gethit-skill", 38, 25, 3, "dmg%", -1, 150, 150, "res-ltng/lvl", 8, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Impaler", 100, 1, -1, 1, -1, 39, 31, "9sr", "War Spear", -1, -1, 5, 5000, "lred", "lred", "", "", "", -1, "", "ignore-ac", -1, 1, 1, "att", -1, 150, 150, "swing2", -1, 20, 20, "openwounds", -1, 40, 40, "noheal", -1, 1, 1, "dmg%", -1, 140, 170, "skill", 19, 5, 5, "skill", 14, 3, 3, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Kelpie Snare", 100, 1, -1, 1, -1, 41, 33, "9tr", "Fuscina", -1, -1, 5, 5000, "", "", "", "invtriu", "", -1, "", "slow", -1, 75, 75, "res-fire", -1, 50, 50, "hp/lvl", 10, -1, -1, "dmg-norm", -1, 30, 50, "str", -1, 10, 10, "dmg%", -1, 140, 180, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Soulfeast Tine", 100, 1, -1, 1, -1, 43, 35, "9br", "War Fork", -1, -1, 5, 5000, "lyel", "lyel", "", "inv9bru", "", -1, "", "ease", -1, -20, -20, "lifesteal", -1, 7, 7, "manasteal", -1, 7, 7, "stamdrain", -1, 20, 20, "dmg%", -1, 150, 190, "att", -1, 150, 250, "dur", -1, 15, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Hone Sundan", 100, 1, -1, 1, -1, 45, 37, "9st", "Yari", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "sock", 3, -1, -1, "dmg-norm", -1, 20, 40, "crush", -1, 45, 45, "rep-dur", 10, -1, -1, "dmg%", -1, 160, 200, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Spire of Honor", 100, 1, -1, 1, -1, 47, 39, "9p9", "Lance", -1, -1, 5, 5000, "lgry", "lgry", "", "", "", -1, "", "att%", -1, 25, 25, "light", -1, 3, 3, "regen", -1, 20, 20, "balance2", -1, 20, 20, "dmg-norm", -1, 20, 40, "dmg-dem/lvl", 12, -1, -1, "dmg%", -1, 150, 200, "skilltab", 9, 3, 3, "ac%", -1, 25, 25, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Meat Scraper", 100, 1, -1, 1, -1, 49, 41, "9b7", "Lochaber Axe", -1, -1, 5, 5000, "dred", "dred", "", "", "", -1, "", "dmg%", -1, 150, 200, "swing2", -1, 30, 30, "lifesteal", -1, 10, 10, "openwounds", -1, 50, 50, "mag%", -1, 25, 25, "skilltab", 13, 3, 3, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Blackleach Blade", 100, 1, -1, 1, -1, 50, 42, "9vo", "Bill", -1, -1, 5, 5000, "blac", "blac", "", "", "", -1, "", "ease", -1, -25, -25, "hit-skill", 72, 5, 5, "light", -1, -2, -2, "lifesteal", -1, 8, 8, "dmg/lvl", 10, -1, -1, "dmg%", -1, 100, 140, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Athena's Wrath", 100, 1, -1, 1, -1, 50, 42, "9s8", "Battle Scythe", -1, -1, 5, 5000, "", "", "", "inv9s8u", "", -1, "", "dru", -1, 1, 3, "dex", -1, 15, 15, "swing2", -1, 30, 30, "hp/lvl", 8, -1, -1, "dmg/lvl", 8, -1, -1, "dmg%", -1, 150, 180, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Pierre Tombale Couant", 100, 1, -1, 1, -1, 51, 43, "9pa", "Partizan", -1, -1, 5, 5000, "lgld", "lgld", "", "", "", -1, "", "deadly", -1, 55, 55, "bar", -1, 3, 3, "balance2", -1, 30, 30, "manasteal", -1, 6, 6, "dmg-norm", -1, 12, 20, "dmg%", -1, 160, 220, "att", -1, 100, 200, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Husoldal Evo", 100, 1, -1, 1, -1, 52, 44, "9h9", "Bec-de-Corbin", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "regen", -1, 20, 20, "att", -1, 200, 250, "noheal", -1, 1, 1, "dmg-norm", -1, 20, 32, "dmg%", -1, 160, 200, "swing2", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Grim's Burning Dead", 100, 1, -1, 1, -1, 52, 45, "9wc", "Grim Scythe", -1, -1, 5, 5000, "cred", "cred", "", "", "", -1, "", "dmg-fire", -1, 131, 232, "res-fire", -1, 45, 45, "dmg%", -1, 140, 180, "thorns", -1, 8, 8, "ease", -1, -50, -50, "nec", -1, 3, 3, "reduce-ac", -1, 50, 50, "ac%", -1, 20, 20, "att", -1, 200, 250, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Razorswitch", 100, 1, -1, 1, -1, 36, 28, "8ss", "Jo Stalf", -1, -1, 5, 5000, "lpur", "", "", "", "", -1, "", "cast3", -1, 30, 30, "thorns", -1, 15, 15, "mana", -1, 175, 175, "hp", -1, 80, 80, "red-mag", -1, 15, 15, "res-all", -1, 50, 50, "allskills", -1, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Ribcracker", 100, 1, -1, 1, -1, 39, 31, "8ls", "Quarterstaff", -1, -1, 5, 5000, "lblu", "lblu", "", "", "", -1, "", "dmg-norm", -1, 30, 65, "dmg%", -1, 200, 300, "crush", -1, 50, 50, "dex", -1, 15, 15, "ac", -1, 100, 100, "ac%", -1, 100, 100, "balance2", -1, 50, 50, "swing2", -1, 50, 50, "dur", -1, 100, 100, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Chromatic Ire", 100, 1, -1, 1, -1, 43, 35, "8cs", "Cedar Staff", -1, -1, 5, 5000, "", "", "", "invcstu", "", -1, "", "sor", -1, 3, 3, "res-all", -1, 20, 40, "cast1", -1, 20, 20, "light-thorns", -1, 20, 20, "hp%", -1, 20, 25, "skill", 61, 1, 1, "skill", 63, 1, 1, "skill", 65, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Warpspear", 100, 1, -1, 1, -1, 47, 39, "8bs", "Gothic Staff", -1, -1, 5, 5000, "cblu", "cblu", "", "", "", -1, "", "sor", -1, 3, 3, "ignore-ac", -1, 1, 1, "skill", 54, 3, 3, "skill", 43, 3, 3, "skill", 58, 3, 3, "ac-miss", -1, 250, 250, "*hit-skill", 54, 50, 1, "*gethit-skill", 54, 25, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Skullcollector", 100, 1, -1, 1, -1, 49, 41, "8ws", "Rune Staff", -1, -1, 5, 5000, "blac", "blac", "", "inv8wsu", "", -1, "", "mana%", -1, 20, 20, "mana-kill", -1, 20, 20, "allskills", -1, 2, 2, "mag%/lvl", 8, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Skystrike", 100, 1, -1, 1, -1, 36, 28, "8sb", "Edge Bow", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "dmg-ltng", -1, 1, 250, "att", -1, 100, 100, "enr", -1, 10, 10, "swing3", -1, 30, 30, "dmg%", -1, 150, 200, "hit-skill", 56, 2, 6, "ama", -1, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Riphook", 100, 1, -1, 1, -1, 39, 31, "8hb", "Razor Bow", -1, -1, 5, 5000, "cred", "cred", "", "", "", -1, "", "openwounds", -1, 30, 30, "dmg%", -1, 180, 220, "slow", -1, 30, 30, "mana", -1, 35, 35, "swing2", -1, 30, 30, "lifesteal", -1, 7, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Kuko Shakaku", 100, 1, -1, 1, -1, 41, 33, "8lb", "CedarBow", -1, -1, 5, 5000, "lpur", "lpur", "", "inv8lbu", "", -1, "", "skill", 27, 3, 3, "explosivearrow", -1, 7, 7, "dmg%", -1, 150, 180, "pierce", -1, 50, 50, "dmg-fire", -1, 40, 180, "skilltab", 0, 3, 3, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Endlesshail", 100, 1, -1, 1, -1, 44, 36, "8cb", "Double Bow", -1, -1, 5, 5000, "", "", "", "invcbwu", "", -1, "", "res-cold", -1, 35, 35, "mana", -1, 40, 40, "ac-miss", -1, 50, 50, "skill", 26, 3, 5, "dmg%", -1, 180, 220, "dmg-cold", 75, 15, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Whichwild String", 100, 1, -1, 1, -1, 47, 39, "8s8", "Short Siege Bow", -1, -1, 5, 5000, "lblu", "lblu", "", "inv8s8u", "", -1, "", "hit-skill", 66, 2, 5, "res-all", -1, 40, 40, "deadly/lvl", 8, -1, -1, "dmg%", -1, 150, 170, "magicarrow", -1, 20, 20, "sock", 2, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Cliffkiller", 100, 1, -1, 1, -1, 49, 41, "8l8", "Long Siege Bow", -1, -1, 5, 5000, "dgld", "", "", "", "", -1, "", "ama", -1, 2, 2, "dmg%", -1, 190, 230, "ac-miss", -1, 80, 80, "knock", -1, 1, 1, "hp", -1, 50, 50, "dmg-min", -1, 5, 10, "dmg-max", -1, 20, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Magewrath", 100, 1, -1, 1, -1, 51, 43, "8sw", "Rune Bow", -1, -1, 5, 5000, "oran", "", "", "invswbu", "", -1, "", "manasteal", -1, 15, 15, "red-mag", -1, 9, 13, "skill", 22, 3, 3, "att", -1, 200, 250, "dex", -1, 10, 10, "stupidity", -1, 1, 1, "dmg-norm", -1, 25, 50, "dmg%", -1, 120, 150, "ama", -1, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Godstrike Arch", 100, 1, -1, 1, -1, 54, 46, "8lw", "Gothic Bow", -1, -1, 5, 5000, "lgry", "lgry", "", "", "", -1, "", "dmg%", -1, 200, 250, "att%", -1, 100, 150, "dmg-undead", -1, 100, 200, "dmg-demon", -1, 100, 200, "hit-skill", 121, 5, 7, "swing2", -1, 50, 50, "regen", -1, 12, 12, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Langer Briser", 100, 1, -1, 1, -1, 40, 32, "8lx", "Arbalest", -1, -1, 5, 5000, "", "", "", "inv8lxu", "", -1, "", "knock", -1, 1, 1, "dmg%", -1, 170, 200, "mag%", -1, 30, 60, "hp", -1, 30, 30, "dmg-max", -1, 10, 30, "openwounds", -1, 33, 33, "dmg-ltng", -1, 1, 212, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Pus Spiter", 100, 1, -1, 1, -1, 44, 36, "8mx", "Siege Crossbow", -1, -1, 5, 5000, "cgrn", "cgrn", "", "inv8mxu", "", -1, "", "dmg-pois", 200, 192, 192, "hit-skill", 91, 4, 1, "nec", -1, 2, 2, "ease", -1, -60, -60, "gethit-skill", 92, 9, 6, "swing2", -1, 10, 10, "dmg%", -1, 150, 220, "att/lvl", 10, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Buriza-Do Kyanon", 100, 1, -1, 1, -1, 59, 41, "8hx", "Balista", -1, -1, 5, 5000, "", "", "", "invhxbu", "", -1, "", "pierce", -1, 100, 100, "dex", -1, 35, 35, "ac", -1, 75, 150, "dmg/lvl", 20, -1, -1, "swing2", -1, 80, 80, "dmg%", -1, 150, 200, "freeze", -1, 3, 3, "dmg-cold", 200, 32, 196, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Demon Machine", 100, 1, -1, 1, -1, 57, 49, "8rx", "Chu-Ko-Nu", -1, -1, 5, 5000, "blac", "blac", "", "invrxbu", "", -1, "", "ac", -1, 321, 321, "mana", -1, 36, 36, "pierce", -1, 66, 66, "explosivearrow", -1, 6, 6, "dmg-max", -1, 66, 66, "dmg%", -1, 123, 123, "att", -1, 632, 632, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			BaseUniqueItem._gimmeAnull(),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Peasent Crown", 100, 1, -1, 1, -1, 36, 28, "xap", "War Hat", -1, -1, 3, 5000, "lgry", "", "", "", "", -1, "", "enr", -1, 20, 20, "vit", -1, 20, 20, "allskills", -1, 1, 1, "move2", -1, 15, 15, "regen", -1, 6, 12, "ac%", -1, 100, 100, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Rockstopper", 100, 1, -1, 1, -1, 39, 31, "xkp", "Sallet", -1, -1, 3, 5000, "", "", "", "invxkpu", "", -1, "", "res-ltng", -1, 20, 40, "red-dmg%", -1, 10, 10, "balance2", -1, 30, 30, "ac%", -1, 160, 220, "res-fire", -1, 20, 50, "res-cold", -1, 20, 40, "vit", -1, 15, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Stealskull", 100, 1, -1, 1, -1, 43, 35, "xlm", "Casque", -1, -1, 3, 5000, "", "", "", "invhlmu", "", -1, "", "manasteal", -1, 5, 5, "lifesteal", -1, 5, 5, "balance2", -1, 10, 10, "swing2", -1, 10, 10, "ac%", -1, 200, 240, "mag%", -1, 30, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Darksight Helm", 100, 1, -1, 1, -1, 46, 38, "xhl", "Basinet", -1, -1, 3, 5000, "blac", "blac", "", "invfhlu", "", -1, "", "light", -1, -4, -4, "ac/lvl", 16, -1, -1, "nofreeze", -1, 1, 1, "manasteal", -1, 5, 5, "gethit-skill", 71, 6, 3, "charged", 264, 30, 5, "res-fire", -1, 20, 40, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Valkiry Wing", 100, 1, -1, 1, -1, 52, 44, "xhm", "Winged Helm", -1, -1, 3, 5000, "lgld", "", "", "", "", -1, "", "ac%", -1, 150, 200, "move2", -1, 20, 20, "balance2", -1, 20, 20, "ama", -1, 1, 2, "mana-kill", -1, 2, 4, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Crown of Thieves", 100, 1, -1, 1, -1, 57, 49, "xrn", "Grand Crown", -1, -1, 3, 5000, "dgld", "dgld", "", "invxrnu", "", -1, "", "dex", -1, 25, 25, "lifesteal", -1, 9, 12, "hp", -1, 50, 50, "mana", -1, 35, 35, "res-fire", -1, 33, 33, "ac%", -1, 160, 200, "gold%", -1, 80, 100, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Blackhorn's Face", 100, 1, -1, 1, -1, 49, 41, "xsk", "Death Mask", -1, -1, 3, 5000, "blac", "blac", "", "", "", -1, "", "light-thorns", -1, 25, 25, "slow", -1, 20, 20, "noheal", -1, 1, 1, "abs-ltng", -1, 20, 20, "res-ltng", -1, 15, 15, "ac%", -1, 180, 220, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Vampiregaze", 100, 1, -1, 1, -1, 49, 41, "xh9", "Grim Helm", -1, -1, 3, 5000, "cgrn", "cgrn", "", "invbhmu", "", -1, "", "manasteal", -1, 6, 8, "lifesteal", -1, 6, 8, "stamdrain", -1, 15, 15, "red-dmg%", -1, 15, 20, "red-mag", -1, 10, 15, "ac%", -1, 100, 100, "dmg-cold", 100, 6, 22, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Spirit Shroud", 100, 1, -1, 1, -1, 36, 28, "xui", "Ghost Armor", -1, -1, 3, 5000, "", "", "", "", "", -1, "", "nofreeze", -1, 1, 1, "allskills", -1, 1, 1, "red-mag", -1, 7, 11, "regen", -1, 10, 10, "ac%", -1, 150, 150, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Skin of the Vipermagi", 100, 1, -1, 1, -1, 37, 29, "xea", "SerpentSkin Armor", -1, -1, 3, 5000, "dblu", "dblu", "", "", "", -1, "", "ac%", -1, 120, 120, "res-all", -1, 20, 35, "cast3", -1, 30, 30, "red-mag", -1, 9, 13, "allskills", -1, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Skin of the Flayerd One", 100, 1, -1, 1, -1, 39, 31, "xla", "Demonhide Armor", -1, -1, 3, 5000, "lred", "lred", "", "", "", -1, "", "rep-dur", 10, -1, -1, "regen", -1, 15, 25, "dur", -1, 30, 30, "lifesteal", -1, 5, 7, "ac%", -1, 150, 190, "thorns", -1, 15, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Ironpelt", 100, 1, -1, 1, -1, 41, 33, "xtu", "Tresllised Armor", -1, -1, 3, 5000, "dgry", "dgry", "", "invxtuu", "", -1, "", "dur", -1, 125, 125, "hp", -1, 25, 25, "red-mag", -1, 10, 16, "red-dmg", -1, 15, 20, "ac/lvl", 24, -1, -1, "ac%", -1, 50, 100, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Spiritforge", 100, 1, -1, 1, -1, 43, 35, "xng", "Linked Mail", -1, -1, 3, 5000, "", "", "", "", "", -1, "", "light", -1, 4, 4, "hp/lvl", 10, -1, -1, "dmg-fire", -1, 20, 65, "res-fire", -1, 5, 5, "ac%", -1, 120, 160, "str", -1, 15, 15, "sock", 2, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Crow Caw", 100, 1, -1, 1, -1, 45, 37, "xcl", "Tigulated Mail", -1, -1, 3, 5000, "", "", "", "", "", -1, "", "openwounds", -1, 35, 35, "ac%", -1, 150, 180, "dex", -1, 15, 15, "balance2", -1, 15, 15, "swing2", -1, 15, 15, "*charged", 221, 3, 5, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Shaftstop", 100, 1, -1, 1, -1, 46, 38, "xhn", "Mesh Armor", -1, -1, 3, 5000, "dgry", "", "", "", "", -1, "", "ac-miss", -1, 250, 250, "red-dmg%", -1, 30, 30, "hp", -1, 60, 60, "ac%", -1, 180, 220, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Duriel's Shell", 100, 1, -1, 1, -1, 49, 41, "xrs", "Cuirass", -1, -1, 3, 5000, "oran", "oran", "", "", "", -1, "", "str", -1, 15, 15, "ac/lvl", 10, -1, -1, "hp/lvl", 8, -1, -1, "ac%", -1, 160, 200, "res-fire", -1, 20, 20, "res-ltng", -1, 20, 20, "res-pois", -1, 20, 20, "res-cold", -1, 50, 50, "nofreeze", -1, 1, 1, "dur", -1, 100, 100, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Skullder's Ire", 100, 1, -1, 1, -1, 50, 42, "xpl", "Russet Armor", -1, -1, 3, 5000, "", "", "", "", "", -1, "", "allskills", -1, 1, 1, "mag%/lvl", 10, -1, -1, "ac%", -1, 160, 200, "dur", -1, 60, 60, "red-mag", -1, 10, 10, "rep-dur", 20, -1, -1, "*vit", -1, -10, -10, "*enr", -1, -10, -10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Guardian Angel", 100, 1, -1, 1, -1, 53, 45, "xlt", "Templar Coat", -1, -1, 3, 5000, "lgry", "lgry", "", "", "", -1, "", "light", -1, 4, 4, "pal", -1, 1, 1, "ac%", -1, 180, 200, "block2", -1, 30, 30, "res-all-max", -1, 15, 15, "att-dem/lvl", 5, -1, -1, "block", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Toothrow", 100, 1, -1, 1, -1, 56, 48, "xld", "Sharktooth Armor", -1, -1, 3, 5000, "whit", "whit", "", "", "", -1, "", "thorns", -1, 20, 40, "ac", -1, 40, 60, "str", -1, 10, 10, "openwounds", -1, 40, 40, "res-fire", -1, 15, 15, "ac%", -1, 160, 220, "dur", -1, 15, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Atma's Wail", 100, 1, -1, 1, -1, 59, 51, "xth", "Embossed Plate", -1, -1, 3, 5000, "", "", "", "", "", -1, "", "dex", -1, 15, 15, "regen", -1, 10, 10, "mana%", -1, 15, 15, "balance2", -1, 30, 30, "ac/lvl", 16, -1, -1, "dur", -1, 50, 50, "ac%", -1, 120, 160, "mag%", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Black Hades", 100, 1, -1, 1, -1, 61, 53, "xul", "Chaos Armor", -1, -1, 3, 5000, "", "", "", "", "", -1, "", "light", -1, -2, -2, "att-demon", -1, 200, 250, "half-freeze", -1, 1, 1, "sock", 3, -1, -1, "ac%", -1, 140, 200, "dmg-demon", -1, 30, 60, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Corpsemourn", 100, 1, -1, 1, -1, 63, 55, "xar", "Ornate Armor", -1, -1, 3, 5000, "blac", "blac", "", "invxaru", "", -1, "", "str", -1, 8, 8, "vit", -1, 10, 10, "res-cold", -1, 35, 35, "gethit-skill", 76, 6, 2, "ac%", -1, 150, 180, "dmg-fire", -1, 12, 36, "charged", 74, 40, 5, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Que-Hegan's Wisdon", 100, 1, -1, 1, -1, 59, 51, "xtp", "Mage Plate", -1, -1, 3, 5000, "", "", "", "", "", -1, "", "cast2", -1, 20, 20, "mana-kill", -1, 3, 3, "red-mag", -1, 6, 10, "enr", -1, 15, 15, "balance2", -1, 20, 20, "ac%", -1, 140, 160, "allskills", -1, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Visceratuant", 100, 1, -1, 1, -1, 36, 28, "xuc", "Defender", -1, -1, 3, 5000, "dred", "", "", "invbucu", "", -1, "", "sor", -1, 1, 1, "block2", -1, 30, 30, "block", -1, 30, 30, "ac%", -1, 100, 150, "light-thorns", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Mosers Blessed Circle", 100, 1, -1, 1, -1, 39, 31, "xml", "Round Shield", -1, -1, 3, 5000, "", "", "", "invxmlu", "", -1, "", "res-all", -1, 25, 25, "block", -1, 25, 25, "sock", 2, -1, -1, "ac%", -1, 180, 220, "block2", -1, 30, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Stormchaser", 100, 1, -1, 1, -1, 43, 35, "xrg", "Scutum", -1, -1, 3, 5000, "cblu", "cblu", "", "invxrgu", "", -1, "", "dmg-ltng", -1, 1, 60, "block", -1, 20, 20, "half-freeze", -1, 1, 1, "res-ltng", -1, 50, 50, "att", -1, 150, 150, "ac%", -1, 160, 220, "block2", -1, 10, 10, "gethit-skill", 59, 4, 6, "gethit-skill", 245, 4, 5, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Tiamat's Rebuke", 100, 1, -1, 1, -1, 46, 38, "xit", "Dragon Shield", -1, -1, 3, 5000, "lgry", "lgry", "", "invkitu", "", -1, "", "dmg-cold", 150, 27, 53, "dmg-fire", -1, 35, 95, "dmg-ltng", -1, 1, 120, "res-all", -1, 25, 35, "ac%", -1, 140, 200, "gethit-skill", 44, 5, 9, "gethit-skill", 48, 5, 7, "gethit-skill", 62, 3, 6, "dur", -1, 40, 40, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Kerke's Sanctuary", 100, 1, -1, 1, -1, 52, 44, "xow", "Pavise", -1, -1, 3, 5000, "lgrn", "lgrn", "", "invtowu", "", -1, "", "red-dmg", -1, 11, 16, "red-mag", -1, 14, 18, "regen", -1, 15, 15, "ac%", -1, 180, 240, "dur", -1, 100, 100, "block", -1, 30, 30, "res-all", -1, 20, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Radimant's Sphere", 100, 1, -1, 1, -1, 58, 50, "xts", "Ancient Shield", -1, -1, 3, 5000, "", "", "", "invgtsu", "", -1, "", "dmg-pois", 100, 204, 204, "gethit-skill", 92, 5, 5, "res-pois", -1, 75, 75, "ac%", -1, 160, 200, "block", -1, 20, 20, "block2", -1, 20, 20, "charged", 83, 40, 6, "dur", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Lidless Wall", 100, 1, -1, 1, -1, 49, 41, "xsh", "Grim Shield", -1, -1, 3, 5000, "dgld", "dgld", "", "invxshu", "", -1, "", "light", -1, 1, 1, "allskills", -1, 1, 1, "cast2", -1, 20, 20, "mana-kill", -1, 3, 5, "ac%", -1, 80, 130, "enr", -1, 10, 10, "mana%", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Lance Guard", 100, 1, -1, 1, -1, 43, 35, "xpk", "Barbed Shield", -1, -1, 3, 5000, "", "", "", "invxpku", "", -1, "", "hp", -1, 50, 50, "balance2", -1, 30, 30, "dmg-to-mana", -1, 15, 15, "thorns", -1, 47, 47, "ac%", -1, 70, 120, "deadly", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Venom Grip", 100, 1, -1, 1, -1, 37, 29, "xlg", "Demonhide Gloves", -1, -1, 5, 5000, "dgrn", "", "", "", "", -1, "", "res-pois", -1, 30, 30, "res-pois-max", -1, 5, 5, "dmg-pois", 100, 153, 153, "crush", -1, 5, 5, "lifesteal", -1, 5, 5, "ac", -1, 15, 25, "ac%", -1, 130, 160, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Gravepalm", 100, 1, -1, 1, -1, 39, 32, "xvg", "Sharkskin Gloves", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "enr", -1, 10, 10, "str", -1, 10, 10, "dmg-undead", -1, 100, 200, "att-undead", -1, 100, 200, "ac%", -1, 140, 180, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Ghoulhide", 100, 1, -1, 1, -1, 44, 36, "xmg", "Heavy Bracers", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "att-und/lvl", 16, -1, -1, "dmg-und/lvl", 16, -1, -1, "manasteal", -1, 4, 5, "hp", -1, 20, 20, "ac%", -1, 150, 190, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Lavagout", 100, 1, -1, 1, -1, 50, 42, "xtg", "Battle Guantlets", -1, -1, 5, 5000, "lyel", "", "", "", "", -1, "", "res-fire", -1, 24, 24, "half-freeze", -1, 1, 1, "hit-skill", 52, 2, 10, "swing2", -1, 20, 20, "ac%", -1, 150, 200, "dmg-fire", -1, 13, 46, "dur", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Hellmouth", 100, 1, -1, 1, -1, 55, 47, "xhg", "War Gauntlets", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "dmg-fire", -1, 15, 72, "abs-fire", -1, 15, 15, "ac%", -1, 150, 200, "dur", -1, 15, 15, "hit-skill", 56, 2, 4, "hit-skill", 225, 4, 12, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Infernostride", 100, 1, -1, 1, -1, 37, 29, "xlb", "Demonhide Boots", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "dmg-fire", -1, 12, 33, "move2", -1, 20, 20, "res-fire-max", -1, 10, 10, "res-fire", -1, 30, 30, "light", -1, 2, 2, "ac%", -1, 120, 150, "gold%", -1, 40, 70, "ac", -1, 15, 15, "gethit-skill", 46, 5, 8, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Waterwalk", 100, 1, -1, 1, -1, 40, 32, "xvb", "Sharkskin Boots", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "ac-miss", -1, 100, 100, "move2", -1, 20, 20, "dex", -1, 15, 15, "ac%", -1, 180, 210, "hp", -1, 45, 65, "stam", -1, 40, 40, "res-fire-max", -1, 5, 5, "regen-stam", -1, 50, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Silkweave", 100, 1, -1, 1, -1, 44, 36, "xmb", "Mesh Boots", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "ac%", -1, 150, 190, "mana-kill", -1, 5, 5, "ac-miss", -1, 200, 200, "mana%", -1, 10, 10, "move2", -1, 30, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Wartraveler", 100, 1, -1, 1, -1, 50, 42, "xtb", "Battle Boots", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "vit", -1, 10, 10, "str", -1, 10, 10, "mag%", -1, 30, 50, "dur", -1, 30, 30, "move2", -1, 25, 25, "ac%", -1, 150, 190, "dmg-norm", -1, 15, 25, "thorns", -1, 5, 10, "stamdrain", -1, 40, 40, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Gorerider", 100, 1, -1, 1, -1, 55, 47, "xhb", "War Boots", -1, -1, 5, 5000, "dred", "", "", "", "", -1, "", "ease", -1, -25, -25, "deadly", -1, 15, 15, "move2", -1, 30, 30, "crush", -1, 15, 15, "openwounds", -1, 10, 10, "ac%", -1, 160, 200, "dur", -1, 10, 10, "stam", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "String of Ears", 100, 1, -1, 1, -1, 37, 29, "zlb", "Demonhide Sash", -1, -1, 5, 5000, "lred", "", "", "", "", -1, "", "red-mag", -1, 10, 15, "red-dmg%", -1, 10, 15, "lifesteal", -1, 6, 8, "ac%", -1, 150, 180, "ac", -1, 15, 15, "dur", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Razortail", 100, 1, -1, 1, -1, 39, 32, "zvb", "Sharkskin Belt", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "thorns/lvl", 8, -1, -1, "dex", -1, 15, 15, "pierce", -1, 33, 33, "ac", -1, 15, 15, "ac%", -1, 120, 150, "dmg-max", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Gloomstrap", 100, 1, -1, 1, -1, 45, 36, "zmb", "Mesh Belt", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "light", -1, -3, -3, "mana%", -1, 15, 15, "manasteal", -1, 5, 5, "ac%", -1, 120, 150, "vit", -1, 15, 15, "regen-mana", -1, 15, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Snowclash", 100, 1, -1, 1, -1, 49, 42, "ztb", "Battle Belt", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "gethit-skill", 59, 5, 0, "abs-cold", -1, 15, 15, "res-cold-max", -1, 15, 15, "dmg-cold", 75, 13, 21, "ac%", -1, 130, 170, "skill", 59, 2, 2, "skill", 55, 3, 3, "skill", 60, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Thudergod's Vigor", 100, 1, -1, 1, -1, 55, 47, "zhb", "War Belt", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "gethit-skill", 121, 5, 7, "dmg-ltng", -1, 1, 50, "res-ltng-max", -1, 10, 10, "abs-ltng", -1, 20, 20, "ac%", -1, 160, 200, "vit", -1, 20, 20, "str", -1, 20, 20, "skill", 34, 3, 3, "skill", 35, 3, 3, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			BaseUniqueItem._gimmeAnull(),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Harlequin Crest", 100, 1, -1, 1, -1, 69, 62, "uap", "Shako", -1, -1, 3, 5000, "cgrn", "cgrn", "", "", "", -1, "", "allskills", -1, 2, 2, "hp/lvl", 12, -1, -1, "mana/lvl", 12, -1, -1, "mag%", -1, 50, 50, "red-dmg%", -1, 10, 10, "str", -1, 2, 2, "dex", -1, 2, 2, "vit", -1, 2, 2, "enr", -1, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Veil of Steel", 100, 1, -1, 1, -1, 77, 73, "uhm", "Spired Helm", -1, -1, 3, 5000, "lgry", "lgry", "", "", "", -1, "", "res-all", -1, 50, 50, "ac%", -1, 60, 60, "str", -1, 15, 15, "vit", -1, 15, 15, "light", -1, -4, -4, "dur", -1, 20, 20, "ac", -1, 140, 140, "*mana", -1, -30, -30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Gladiator's Bane", 100, 1, -1, 1, -1, 85, 85, "utu", "Wire Fleece", -1, -1, 3, 5000, "lgry", "lgry", "", "", "", -1, "", "ac%", -1, 150, 200, "red-mag", -1, 15, 20, "red-dmg", -1, 15, 20, "thorns", -1, 20, 20, "res-pois-len", -1, 50, 50, "dur", -1, 103, 103, "balance2", -1, 30, 30, "ac", -1, 50, 50, "nofreeze", -1, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Arkaine's Valor", 100, 1, -1, 1, -1, 85, 85, "upl", "Balrog Skin", -1, -1, 3, 5000, "lred", "lred", "", "", "", -1, "", "ac%", -1, 150, 180, "balance2", -1, 30, 30, "allskills", -1, 1, 2, "red-dmg", -1, 10, 15, "vit/lvl", 4, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Blackoak Shield", 100, 1, -1, 1, -1, 67, 61, "uml", "Luna", -1, -1, 3, 5000, "", "", "", "invsmlu", "", -1, "", "dex/lvl", 4, -1, -1, "ac%", -1, 160, 200, "abs-cold/lvl", 5, -1, -1, "gethit-skill", 72, 4, 5, "dur", -1, 45, 45, "hp/lvl", 10, -1, -1, "block2", -1, 50, 50, "half-freeze", -1, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Stormshield", 100, 1, -1, 1, -1, 77, 73, "uit", "Monarch", -1, -1, 3, 5000, "", "", "", "invkitu", "", -1, "", "ac/lvl", 30, -1, -1, "red-dmg%", -1, 35, 35, "str", -1, 30, 30, "indestruct", -1, 1, 1, "block2", -1, 35, 35, "res-ltng", -1, 25, 25, "block", -1, 25, 25, "res-cold", -1, 60, 60, "light-thorns", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Hellslayer", 100, 1, -1, 1, -1, 71, 66, "7bt", "Decapitator", -1, -1, 5, 5000, "dred", "dred", "", "invbtxu", "", -1, "", "str/lvl", 4, -1, -1, "vit/lvl", 4, -1, -1, "dmg%/lvl", 24, -1, -1, "dmg-fire", -1, 150, 250, "hp", -1, 25, 25, "dmg%", -1, 100, 100, "att-skill", 47, 10, 0, "*mana", -1, -25, -25, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Messerschmidt's Reaver", 100, 1, -1, 1, -1, 75, 70, "7ga", "Champion Axe", -1, -1, 5, 5000, "blac", "blac", "", "invgaxu", "", -1, "", "dmg%/lvl", 20, -1, -1, "dmg%", -1, 200, 200, "str", -1, 15, 15, "dex", -1, 15, 15, "vit", -1, 15, 15, "enr", -1, 15, 15, "dmg-fire", -1, 20, 240, "dur", -1, 25, 25, "att%", -1, 100, 100, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Baranar's Star", 100, 1, -1, 1, -1, 70, 65, "7mt", "Devil Star", -1, -1, 5, 5000, "lred", "lred", "", "invmstu", "", -1, "", "att%", -1, 200, 200, "dmg%", -1, 200, 200, "dex", -1, 15, 15, "str", -1, 15, 15, "swing2", -1, 50, 50, "dur", -1, 100, 100, "dmg-ltng", -1, 1, 200, "dmg-fire", -1, 1, 200, "dmg-cold", -1, 1, 200, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Schaefer's Hammer", 100, 1, -1, 1, -1, 83, 79, "7wh", "Legendary Mallet", -1, -1, 5, 5000, "lblu", "lblu", "", "", "", -1, "", "hit-skill", 42, 20, 10, "hp", -1, 50, 50, "att/lvl", 16, -1, -1, "res-ltng", -1, 75, 75, "swing2", -1, 20, 20, "dmg/lvl", 16, -1, -1, "indestruct", -1, 1, 1, "dmg%", -1, 100, 130, "light", -1, 1, 1, "dmg-ltng", -1, 50, 200, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Cranium Basher", 100, 1, -1, 1, -1, 85, 87, "7gm", "Thunder Maul", -1, -1, 5, 5000, "blac", "blac", "", "", "", -1, "", "swing2", -1, 20, 20, "indestruct", -1, 1, 1, "str", -1, 25, 25, "res-all", -1, 25, 25, "crush", -1, 75, 75, "dmg-norm", -1, 20, 20, "dmg%", -1, 200, 240, "hit-skill", 66, 4, 1, "*mana", -1, -30, -30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Lightsabre", 100, 1, -1, 5, -1, 66, 58, "7cr", "Phase Blade", -1, -1, 5, 5000, "lblu", "", "", "invcrsu", "", -1, "", "light", -1, 7, 7, "att-skill", 53, 5, 0, "ignore-ac", 1, 1, 1, "abs-ltng%", -1, 25, 25, "swing2", -1, 20, 20, "dmg-mag", -1, 60, 120, "dmg-ltng", -1, 1, 200, "manasteal", -1, 5, 7, "dmg%", -1, 150, 200, "dmg-norm", -1, 10, 30, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Doombringer", 100, 1, -1, 1, -1, 75, 69, "7b7", "Champion Sword", -1, -1, 5, 5000, "dred", "dred", "", "invbswu", "", -1, "", "hp%", -1, 20, 20, "dmg%", -1, 180, 250, "att%", -1, 40, 40, "indestruct", -1, 1, 1, "dmg-norm", -1, 30, 100, "hit-skill", 72, 8, 3, "lifesteal", -1, 5, 7, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Grandfather", 100, 1, -1, 1, -1, 85, 81, "7gd", "Colossus Blade", -1, -1, 5, 5000, "lyel", "lyel", "", "invgsdu", "", -1, "", "str", -1, 20, 20, "dex", -1, 20, 20, "vit", -1, 20, 20, "enr", -1, 20, 20, "att%", -1, 50, 50, "hp", -1, 80, 80, "dmg/lvl", 20, -1, -1, "indestruct", -1, 1, 1, "dmg%", -1, 150, 250, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Wizardspike", 100, 1, -1, 1, -1, 69, 61, "7dg", "Bone Knife", -1, -1, 5, 5000, "lgry", "lgry", "", "", "", -1, "", "mana/lvl", 16, -1, -1, "regen-mana", -1, 15, 15, "mana%", -1, 15, 15, "res-all", -1, 75, 75, "indestruct", -1, 1, 1, "cast3", -1, 50, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Constricting Ring", 100, 1, -1, 1, -1, 95, 95, "rin", "Ring", -1, -1, 5, 5000, "cblu", "cblu", "", "", "", -1, "", "res-all", -1, 100, 100, "regen", -1, -30, -30, "mag%", -1, 100, 100, "res-all-max", -1, 15, 15, "", -1, -1, -1, "", -1, -1, -1, "", 0, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Stormspire", 100, 1, -1, 1, -1, 78, 70, "7wc", "Giant Thresher", -1, -1, 5, 5000, "dblu", "dblu", "", "", "", -1, "", "res-ltng", -1, 50, 50, "gethit-skill", 53, 5, 5, "dmg%", -1, 150, 250, "str", -1, 10, 10, "gethit-skill", 38, 2, 0, "swing2", -1, 30, 30, "indestruct", -1, 1, 1, "dmg-ltng", -1, 1, 237, "light-thorns", -1, 27, 27, "*enr", -1, -10, -10, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Eaglehorn", 100, 1, -1, 1, -1, 77, 69, "6l7", "Crusader Bow", -1, -1, 5, 5000, "dgld", "dgld", "", "", "", -1, "", "ignore-ac", -1, 1, 1, "att/lvl", 12, -1, -1, "dmg%/lvl", 16, -1, -1, "dmg%", -1, 200, 200, "ama", -1, 1, 1, "dex", -1, 25, 25, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Windforce", 100, 1, -1, 1, -1, 80, 73, "6lw", "Hydra Bow", -1, -1, 5, 5000, "dyel", "dyel", "", "", "", -1, "", "dex", -1, 5, 5, "dmg/lvl", 25, -1, -1, "regen-stam", -1, 30, 30, "manasteal", -1, 6, 8, "knock", -1, 1, 1, "dmg%", -1, 250, 250, "swing2", -1, 20, 20, "str", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			BaseUniqueItem._gimmeAnull(),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Bul Katho's Wedding Band", 100, 1, -1, 1, -1, 66, 58, "rin", "Ring", -1, -1, 5, 5000, "dpur", "dpur", "", "", "", -1, "", "hp/lvl", 4, -1, -1, "allskills", -1, 1, 1, "lifesteal", -1, 3, 5, "stam", -1, 50, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Cat's Eye", 100, 1, -1, 5, -1, 58, 50, "amu", "Amulet", -1, -1, 5, 5000, "oran", "oran", "", "", "", -1, "", "move2", -1, 30, 30, "swing2", -1, 20, 20, "ac", -1, 100, 100, "ac-miss", -1, 100, 100, "dex", -1, 25, 25, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Rising Sun", 100, 1, -1, 5, -1, 73, 65, "amu", "Amulet", -1, -1, 5, 5000, "lgld", "lgld", "", "", "", -1, "", "abs-fire/lvl", 6, -1, -1, "light", -1, 4, 4, "gethit-skill", 56, 2, 0, "dmg-fire", -1, 24, 48, "fireskill", -1, 2, 2, "regen", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Crescent Moon", 100, 1, -1, 5, -1, 58, 50, "amu", "Amulet", -1, -1, 5, 5000, "lblu", "lblu", "", "", "", -1, "", "manasteal", -1, 11, 15, "red-mag", -1, 10, 10, "dmg-to-mana", -1, 10, 10, "light", -1, -2, -2, "mana", -1, 45, 45, "lifesteal", -1, 3, 6, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Mara's Kaleidoscope", 100, 1, -1, 5, -1, 80, 67, "amu", "Amulet", -1, -1, 5, 5000, "oran", "oran", "", "", "", -1, "", "allskills", -1, 2, 2, "res-all", -1, 20, 30, "str", -1, 5, 5, "dex", -1, 5, 5, "vit", -1, 5, 5, "enr", -1, 5, 5, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Atma's Scarab", 100, 1, -1, 5, -1, 60, 60, "amu", "Amulet", -1, -1, 5, 5000, "cgrn", "cgrn", "", "", "", -1, "", "dmg-pois", 100, 102, 102, "res-pois", -1, 75, 75, "light", -1, 3, 3, "thorns", -1, 5, 5, "hit-skill", 66, 5, 2, "att%", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Dwarf Star", 100, 1, -1, 10, -1, 53, 45, "rin", "Ring", -1, -1, 5, 5000, "dgry", "dgry", "", "", "", -1, "", "gold%", -1, 100, 100, "stam", -1, 40, 40, "regen-stam", -1, 15, 15, "hp", -1, 40, 40, "red-mag", -1, 12, 15, "abs-fire%", -1, 15, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Raven Frost", 100, 1, -1, 10, -1, 53, 45, "rin", "Ring", -1, -1, 5, 5000, "cblu", "cblu", "", "", "", -1, "", "nofreeze", -1, 1, 1, "dmg-cold", 100, 15, 45, "abs-cold%", -1, 20, 20, "mana", -1, 40, 40, "dex", -1, 15, 20, "att", -1, 150, 250, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Highlord's Wrath", 100, 1, -1, 5, -1, 73, 65, "amu", "Amulet", -1, -1, 5, 5000, "bwht", "bwht", "", "", "", -1, "", "res-ltng", -1, 35, 35, "dmg-ltng", -1, 1, 30, "swing2", -1, 20, 20, "allskills", -1, 1, 1, "deadly/lvl", 3, -1, -1, "light-thorns", -1, 15, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Saracen's Chance", 100, 1, -1, 5, -1, 55, 47, "amu", "Amulet", -1, -1, 5, 5000, "dpur", "dpur", "", "", "", -1, "", "res-all", -1, 15, 25, "gethit-skill", 76, 10, 2, "str", -1, 12, 12, "dex", -1, 12, 12, "enr", -1, 12, 12, "vit", -1, 12, 12, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			BaseUniqueItem._gimmeAnull(),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Arreat's Face", 100, 1, -1, 1, -1, 50, 42, "baa", "Slayer Guard", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "bar", -1, 2, 2, "skilltab", 12, 2, 2, "ac%", -1, 150, 200, "balance2", -1, 30, 30, "att%", -1, 20, 20, "str", -1, 20, 20, "dex", -1, 20, 20, "lifesteal", -1, 3, 6, "res-all", -1, 30, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Homunculus", 100, 1, -1, 1, -1, 50, 42, "nea", "Heirophant Trophy", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "nec", -1, 2, 2, "skilltab", 6, 2, 2, "ac%", -1, 150, 200, "block2", -1, 30, 30, "block", -1, 40, 40, "enr", -1, 20, 20, "regen-mana", -1, 33, 33, "mana-kill", -1, 5, 5, "res-all", -1, 40, 40, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Titan's Revenge", 100, 1, -1, 1, -1, 50, 42, "ama", "Ceremonial Javelin", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "ama", -1, 2, 2, "skilltab", 2, 2, 2, "dmg%", -1, 150, 200, "move2", -1, 30, 30, "rep-quant", 30, -1, -1, "str", -1, 20, 20, "dex", -1, 20, 20, "lifesteal", -1, 5, 9, "dmg-norm", -1, 25, 50, "stack", -1, 60, 60, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Lycander's Aim", 100, 1, -1, 1, -1, 50, 42, "am7", "Ceremonial Bow", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "ama", -1, 2, 2, "skilltab", 0, 2, 2, "dmg%", -1, 150, 200, "swing2", -1, 20, 20, "ac%", -1, 20, 20, "dex", -1, 20, 20, "enr", -1, 20, 20, "manasteal", -1, 5, 8, "dmg-norm", -1, 25, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Lycander's Flank", 100, 1, -1, 1, -1, 50, 42, "am9", "Ceremonial Pike", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "ama", -1, 2, 2, "skilltab", 2, 2, 2, "dmg%", -1, 150, 200, "swing2", -1, 30, 30, "ac%", -1, 20, 20, "str", -1, 20, 20, "vit", -1, 20, 20, "lifesteal", -1, 5, 9, "dmg-norm", -1, 25, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Oculus", 100, 1, -1, 1, -1, 50, 42, "oba", "Swirling Crystal", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "sor", -1, 3, 3, "gethit-skill", 54, 25, 1, "res-all", -1, 20, 20, "cast2", -1, 30, 30, "ac%", -1, 20, 20, "vit", -1, 20, 20, "enr", -1, 20, 20, "mana-kill", -1, 5, 5, "mag%", -1, 50, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Herald of Zakarum", 100, 1, -1, 1, -1, 50, 42, "pa9", "Aerin Shield", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "pal", -1, 2, 2, "skilltab", 9, 2, 2, "ac%", -1, 150, 200, "block2", -1, 30, 30, "block", -1, 30, 30, "str", -1, 20, 20, "vit", -1, 20, 20, "att%", -1, 20, 20, "res-all", -1, 50, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Cutthroat1", 100, 1, -1, 1, -1, 50, 42, "9tw", "Runic Talons", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "ass", -1, 2, 2, "skilltab", 20, 1, 1, "dmg%", -1, 150, 200, "balance2", -1, 30, 30, "att%", -1, 20, 20, "str", -1, 20, 20, "dex", -1, 20, 20, "lifesteal", -1, 5, 9, "dmg-norm", -1, 25, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Jalal's Mane", 100, 1, -1, 1, -1, 50, 42, "dra", "Dream Spirit", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "dru", -1, 2, 2, "skilltab", 16, 2, 2, "ac%", -1, 150, 200, "balance2", -1, 30, 30, "att%", -1, 20, 20, "str", -1, 20, 20, "enr", -1, 20, 20, "mana-kill", -1, 5, 5, "res-all", -1, 30, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Scalper", 100, 1, -1, 1, -1, 65, 57, "9ta", "Francisca", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "rep-quant", 30, -1, -1, "dmg%", -1, 150, 200, "att%", -1, 25, 25, "swing2", -1, 20, 20, "openwounds", -1, 33, 33, "lifesteal", -1, 4, 6, "mana-kill", -1, 4, 4, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Bloodmoon", 100, 1, -1, 1, -1, 69, 61, "7sb", "elegant blade", -1, -1, 5, 5000, "cred", "cred", "", "invsbru", "", -1, "", "dmg%", -1, 210, 260, "lifesteal", -1, 10, 15, "charged", 85, 9, 15, "heal-kill", -1, 7, 13, "openwounds", -1, 50, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Djinnslayer", 100, 1, -1, 1, -1, 73, 65, "7sm", "ataghan", -1, -1, 5, 5000, "dpur", "dpur", "", "invscmu", "", -1, "", "dmg%", -1, 190, 240, "dmg-fire", -1, 250, 500, "dmg-demon", -1, 100, 150, "att-demon", -1, 200, 300, "abs-ltng", -1, 3, 7, "manasteal", -1, 3, 6, "sock", -1, 1, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Deathbit", 100, 1, -1, 1, -1, 52, 44, "9tk", "battle dart", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "deadly", -1, 40, 40, "dmg%", -1, 130, 180, "att", -1, 200, 450, "lifesteal", -1, 7, 9, "manasteal", -1, 4, 6, "rep-quant", 25, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Warshrike", 100, 1, -1, 1, -1, 83, 75, "7bk", "winged knife", -1, -1, 5, 5000, "bwht", "bwht", "", "invtk3", "", -1, "", "dmg%", -1, 200, 250, "pierce", -1, 50, 50, "swing2", -1, 30, 30, "deadly", -1, 50, 50, "rep-quant", 30, -1, -1, "hit-skill", 48, 25, 9, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Gutsiphon", 100, 1, -1, 1, -1, 79, 71, "6rx", "demon crossbow", -1, -1, 5, 5000, "lgrn", "lgrn", "", "invrxbu", "", -1, "", "dmg%", -1, 160, 220, "pierce", -1, 33, 33, "lifesteal", -1, 12, 18, "slow", -1, 25, 25, "openwounds", -1, 33, 33, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Razoredge", 100, 1, -1, 1, -1, 75, 67, "7ha", "tomahawk", -1, -1, 5, 5000, "lblu", "", "", "invhaxu", "", -1, "", "dmg%", -1, 175, 225, "swing2", -1, 40, 40, "reduce-ac", -1, 33, 33, "deadly", -1, 50, 50, "openwounds", -1, 50, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Gore Ripper", 100, -1, -1, 1, -1, -1, -1, "7gi", "Glorious Axe", -1, -1, 5, 5000, "dred", "dred", "", "", "", -1, "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Demonlimb", 100, 1, -1, 1, -1, 71, 63, "7sp", "tyrant club", -1, -1, 5, 5000, "dgrn", "dgrn", "", "invspcu", "", -1, "", "dmg%", -1, 180, 230, "dmg-fire", -1, 222, 333, "lifesteal", -1, 7, 13, "charged", 52, 20, 23, "rep-dur", 5, -1, -1, "dmg-demon", -1, 123, 123, "res-fire", -1, 15, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Steelshade", 100, 1, -1, 1, -1, 70, 62, "ulm", "armet", -1, -1, 5, 5000, "blac", "blac", "", "invhlmu", "", -1, "", "ac%", -1, 100, 130, "abs-fire", -1, 5, 11, "manasteal", -1, 4, 8, "regen", -1, 10, 18, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Tomb Reaver", 100, 1, -1, 1, -1, 86, 84, "7pa", "cryptic axe", 1, -1, 5, 5000, "lyel", "lyel", "", "", "", -1, "", "swing2", -1, 60, 60, "light", -1, 4, 4, "dmg%", -1, 200, 280, "dmg-undead", -1, 150, 230, "mag%", -1, 50, 80, "res-all", -1, 30, 50, "att-undead", -1, 250, 350, "reanimate", 1, 10, 10, "heal-kill", -1, 10, 14, "sock", -1, 1, 3, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Deaths's Web", 100, 1, -1, 1, -1, 74, 66, "7gw", "unearthed wand", -1, -1, 5, 5000, "bwht", "bwht", "", "", "", -1, "", "allskills", -1, 2, 2, "pierce-pois", -1, 40, 50, "heal-kill", -1, 7, 12, "mana-kill", -1, 7, 12, "skilltab", 7, 1, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Nature's Peace", 100, 1, -1, 3, -1, 77, 69, "rin", "ring", -1, -1, 5, 5000, "dgrn", "dgrn", "", "", "", -1, "", "noheal", -1, 1, 1, "rip", -1, 1, 1, "red-dmg", -1, 7, 11, "res-pois", -1, 20, 30, "charged", 226, 27, 5, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Azurewrath", 100, 1, -1, 1, -1, 87, 85, "7cr", "phase blade", 1, -1, 5, 5000, "lgry", "", "", "invcrs", "", -1, "", "dmg-mag", -1, 250, 500, "dmg%", -1, 230, 270, "aura", 119, 10, 13, "dmg-cold", 250, 250, 500, "swing2", -1, 30, 30, "all-stats", -1, 5, 10, "light", -1, 3, 3, "allskills", -1, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Seraph's Hymn", 100, 1, -1, 3, -1, 73, 65, "amu", "amulet", -1, -1, 5, 5000, "bwht", "bwht", "", "invamu2", "", -1, "", "allskills", -1, 2, 2, "skilltab", 11, 1, 2, "dmg-demon", -1, 25, 50, "dmg-undead", -1, 25, 50, "att-demon", -1, 150, 250, "att-undead", -1, 150, 250, "light", -1, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Zakarum's Salvation", 100, -1, -1, 1, -1, -1, -1, "7ws", "Caduceus", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Fleshripper", 100, 1, -1, 1, -1, 76, 68, "7kr", "fanged knife", -1, -1, 5, 5000, "dred", "dred", "", "invkrsu", "", -1, "", "dmg%", -1, 200, 300, "reduce-ac", -1, 50, 50, "noheal", -1, 1, 1, "crush", -1, 25, 25, "openwounds", -1, 50, 50, "deadly", -1, 33, 33, "slow", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Odium", 100, -1, -1, 1, -1, -1, -1, "7ma", "Reinforced Mace", -1, -1, 5, 5000, "blac", "", "", "", "", -1, "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Horizon's Tornado", 100, 1, -1, 5, -1, 72, 64, "7fl", "scourge", -1, -1, 5, 5000, "dpur", "dpur", "", "", "", -1, "", "dmg%", -1, 230, 280, "swing2", -1, 50, 50, "slow", -1, 20, 20, "hit-skill", 245, 20, 15, "ease", -1, -20, -20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Stone Crusher", 100, 1, -1, 4, -1, 76, 68, "7wh", "legendary mallet", -1, -1, 5, 5000, "whit", "", "", "", "", -1, "", "dmg%", -1, 280, 320, "str", -1, 20, 30, "crush", -1, 40, 40, "reduce-ac", -1, 25, 25, "dmg-ac", -1, -100, -100, "dmg", -1, 10, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Jadetalon", 100, 1, -1, 1, -1, 74, 66, "7wb", "wrist sword", -1, -1, 5, 5000, "cgrn", "cgrn", "", "", "", -1, "", "dmg%", -1, 190, 240, "manasteal", -1, 10, 15, "res-all", -1, 40, 50, "balance2", -1, 30, 30, "skilltab", 19, 1, 2, "skilltab", 20, 1, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Shadowdancer", 100, 1, -1, 1, -1, 79, 71, "uhb", "myrmidon greaves", -1, -1, 5, 5000, "blac", "blac", "", "", "", -1, "", "ac%", -1, 70, 100, "move2", -1, 30, 30, "balance2", -1, 30, 30, "dex", -1, 15, 25, "skilltab", 19, 1, 2, "ease", -1, -20, -20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Cerebus", 100, 1, -1, 1, -1, 71, 63, "drb", "blood spirit", -1, -1, 5, 5000, "bwht", "bwht", "", "", "", -1, "", "ac%", -1, 130, 140, "skilltab", 16, 2, 4, "lifesteal", -1, 7, 10, "att%", -1, 60, 120, "openwounds", -1, 33, 33, "skill", 232, 1, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Tyrael's Might", 100, 1, -1, 1, -1, 87, 84, "uar", "sacred armor", 1, -1, 5, 5000, "dblu", "dblu", "", "invaaru", "", -1, "", "ease", -1, -100, -100, "indestruct", -1, 1, 1, "ac%", -1, 120, 150, "rip", -1, 1, 1, "dmg-demon", -1, 50, 100, "nofreeze", -1, 1, 1, "move2", -1, 20, 20, "res-all", -1, 20, 30, "str", -1, 20, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Souldrain", 100, 1, -1, 1, -1, 82, 74, "umg", "vambraces", -1, -1, 5, 5000, "dred", "dred", "", "", "", -1, "", "ac%", -1, 90, 120, "manasteal", -1, 4, 7, "lifesteal", -1, 4, 7, "hit-skill", 72, 8, 3, "dmg-ac", -1, -50, -50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Runemaster", 100, 1, -1, 1, -1, 80, 72, "72a", "ettin axe", -1, -1, 5, 5000, "lblu", "lblu", "", "", "", -1, "", "dmg%", -1, 220, 270, "sock", -1, 3, 5, "res-cold-max", -1, 5, 5, "nofreeze", -1, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Deathcleaver", 100, 1, -1, 1, -1, 78, 70, "7wa", "berserker axe", -1, -1, 5, 5000, "dred", "", "", "", "", -1, "", "dmg%", -1, 230, 280, "deadly", -1, 66, 66, "reduce-ac", -1, 33, 33, "swing2", -1, 40, 40, "heal-kill", -1, 6, 9, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Executioner's Justice", 100, 1, -1, 1, -1, 83, 75, "7gi", "glorious axe", -1, -1, 5, 5000, "blac", "blac", "", "", "", -1, "", "dmg%", -1, 240, 290, "crush", -1, 25, 25, "reduce-ac", -1, 33, 33, "kill-skill", 87, 50, 6, "swing2", -1, 30, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Stoneraven", 100, 1, -1, 1, -1, 72, 64, "amd", "matriarchal spear", -1, -1, 5, 5000, "dgry", "", "", "", "", -1, "", "dmg%", -1, 230, 280, "dmg-mag", -1, 101, 187, "res-all", -1, 30, 50, "ac", -1, 400, 600, "skilltab", 2, 1, 3, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Leviathan", 100, 1, -1, 1, -1, 73, 65, "uld", "kraken shell", -1, -1, 5, 5000, "cgrn", "cgrn", "", "", "", -1, "", "ac%", -1, 170, 200, "ac", -1, 100, 150, "red-dmg%", -1, 15, 25, "str", -1, 40, 50, "indestruct", -1, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Larzuk's Champion", 100, -1, -1, 1, -1, -1, -1, "7fb", "Colossal Sword", -1, -1, 5, 5000, "lgry", "", "flphmr", "invhfh", "", -1, "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Wisp", 100, 1, -1, 1, -1, 84, 76, "rin", "ring", -1, -1, 5, 5000, "bwht", "bwht", "", "", "", -1, "", "abs-ltng%", -1, 10, 20, "hit-skill", 49, 10, 16, "mag%", -1, 10, 20, "charged", 226, 15, 2, "charged", 236, 13, 5, "charged", 246, 11, 7, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Gargoyle's Bite", 100, 1, -1, 1, -1, 78, 70, "7ts", "winged harpoon", -1, -1, 5, 5000, "cgrn", "cgrn", "", "", "", -1, "", "dmg%", -1, 180, 230, "rep-quant", 30, -1, -1, "dmg-pois", 250, 300, 300, "lifesteal", -1, 9, 15, "charged", 25, 60, 11, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Lacerator", 100, 1, -1, 1, -1, 76, 68, "7b8", "winged axe", -1, -1, 5, 5000, "blac", "blac", "", "", "", -1, "", "dmg%", -1, 150, 210, "rep-quant", 25, -1, -1, "swing2", -1, 30, 30, "noheal", -1, 1, 1, "openwounds", -1, 33, 33, "howl", -1, 64, 64, "hit-skill", 66, 33, 3, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Mang Song's Lesson", 100, 1, -1, 1, -1, 86, 82, "6ws", "archon staff", -1, -1, 5, 5000, "dgld", "dgld", "", "inv8wsu", "", -1, "", "allskills", -1, 5, 5, "pierce-fire", -1, 7, 15, "pierce-ltng", -1, 7, 15, "pierce-cold", -1, 7, 15, "regen-mana", -1, 10, 10, "cast2", -1, 30, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Viperfork", 100, 1, -1, 1, -1, 79, 71, "7br", "war fork", -1, -1, 5, 5000, "dgrn", "dgrn", "", "", "", -1, "", "dmg%", -1, 190, 240, "dmg-pois", 250, 333, 333, "swing2", -1, 50, 50, "att", -1, 200, 250, "hit-skill", 83, 15, 9, "res-pois", -1, 30, 50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Ethereal Edge", 100, 1, -1, 1, -1, 82, 74, "7ba", "silver-edged axe", -1, -1, 5, 5000, "whit", "whit", "", "", "", -1, "", "dmg%", -1, 150, 180, "swing2", -1, 25, 25, "abs-fire", -1, 10, 12, "dmg-demon", -1, 150, 200, "demon-heal", -1, 5, 10, "att", -1, 270, 350, "ethereal", -1, 1, 1, "indestruct", -1, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Demonhorn's Edge", 100, 1, -1, 1, -1, 69, 61, "bad", "destroyer helm", -1, -1, 5, 5000, "dgry", "dgry", "", "", "", -1, "", "ac%", -1, 120, 160, "swing2", -1, 10, 10, "lifesteal", -1, 3, 6, "thorns", -1, 55, 77, "skilltab", 12, 1, 3, "skilltab", 13, 1, 3, "skilltab", 14, 1, 3, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Reaper's Toll", 100, 1, -1, 1, -1, 83, 75, "7s8", "thresher", -1, -1, 5, 5000, "", "", "", "invscy", "", -1, "", "dmg%", -1, 190, 240, "hit-skill", 87, 33, 1, "ignore-ac", -1, 1, 1, "lifesteal", -1, 11, 15, "ease", -1, -25, -25, "deadly", -1, 33, 33, "dmg-cold", -1, 4, 44, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Spiritkeeper", 100, 1, -1, 1, -1, 75, 67, "drd", "earth spirit", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "ac%", -1, 170, 190, "balance2", -1, 20, 20, "abs-ltng", -1, 9, 14, "res-fire", -1, 30, 40, "abs-cold%", -1, 15, 25, "res-pois-max", -1, 10, 10, "dru", -1, 1, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Hellrack", 100, 1, -1, 1, -1, 84, 76, "6hx", "colossus crossbow", -1, -1, 5, 5000, "cred", "", "", "invhxbu", "", -1, "", "dmg%", -1, 180, 230, "dmg-elem", 33, 63, 324, "swing2", -1, 20, 20, "att%", -1, 100, 150, "sock", -1, 2, 2, "charged", 27, 150, 18, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Alma Negra", 100, 1, -1, 1, -1, 85, 77, "pac", "sacred rondache", -1, -1, 5, 5000, "blac", "blac", "", "", "", -1, "", "ac%", -1, 180, 210, "block2", -1, 30, 30, "pal", -1, 1, 2, "block", -1, 20, 20, "red-mag", -1, 5, 9, "att%", -1, 40, 75, "dmg%", -1, 40, 75, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Darkforge Spawn", 100, 1, -1, 1, -1, 72, 64, "nef", "bloodlord skull", -1, -1, 5, 5000, "cred", "cred", "", "", "", -1, "", "ac%", -1, 140, 180, "cast2", -1, 30, 30, "mana%", -1, 10, 10, "skilltab", 6, 1, 3, "skilltab", 7, 1, 3, "skilltab", 8, 1, 3, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Widowmaker", 100, 1, -1, 1, -1, 73, 65, "6sw", "ward bow", -1, -1, 5, 5000, "dred", "dred", "", "invswbu", "", -1, "", "dmg%", -1, 150, 200, "deadly", -1, 33, 33, "ignore-ac", -1, 1, 1, "magicarrow", -1, 11, 11, "oskill", 22, 3, 5, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Bloodraven's Charge", 100, 1, -1, 1, -1, 79, 71, "amb", "matriarchal bow", -1, -1, 5, 5000, "dgld", "dgld", "", "invswbu", "", -1, "", "dmg%", -1, 180, 230, "att%", -1, 200, 300, "explosivearrow", -1, 13, 13, "skilltab", 0, 2, 4, "charged", 95, 30, 5, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Ghostflame", 100, 1, -1, 1, -1, 70, 62, "7bl", "legend spike", -1, -1, 5, 5000, "cblu", "cblu", "", "", "", -1, "", "dmg%", -1, 190, 240, "ignore-ac", -1, 1, 1, "dmg-mag", -1, 108, 108, "manasteal", -1, 10, 15, "ethereal", -1, 1, 1, "indestruct", -1, 1, 1, "light", -1, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Shadowkiller", 100, 1, -1, 1, -1, 85, 78, "7cs", "battle cestus", -1, -1, 5, 5000, "", "", "", "invaxfu", "", -1, "", "dmg%", -1, 170, 220, "reduce-ac", -1, 25, 25, "freeze", -1, 2, 2, "mana-kill", -1, 10, 15, "hit-skill", 44, 33, 8, "ethereal", -1, 1, 1, "indestruct", -1, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Gimmershred", 100, 1, -1, 1, -1, 78, 70, "7ta", "flying axe", -1, -1, 5, 5000, "lgrn", "", "", "", "", -1, "", "dmg%", -1, 160, 210, "dmg-fire", -1, 218, 483, "dmg-cold", 100, 176, 397, "dmg-ltng", -1, 29, 501, "stack", -1, 60, 60, "swing2", -1, 30, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Griffon's Eye", 100, 1, -1, 1, -1, 84, 76, "ci3", "diadem", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "ac", -1, 100, 200, "cast2", -1, 25, 25, "allskills", -1, 1, 1, "extra-ltng", -1, 10, 15, "pierce-ltng", -1, 15, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Windhammer", 100, 1, -1, 1, -1, 76, 68, "7m7", "ogre maul", -1, -1, 5, 5000, "cblu", "cblu", "", "invmau", "", -1, "", "dmg%", -1, 180, 230, "crush", -1, 50, 50, "swing2", -1, 60, 60, "hit-skill", 240, 33, 22, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Thunderstroke", 100, 1, -1, 1, -1, 77, 69, "amf", "matriarchal javelin", -1, -1, 5, 5000, "dblu", "dblu", "", "", "", -1, "", "dmg%", -1, 150, 200, "dmg-ltng", -1, 1, 511, "hit-skill", 49, 20, 14, "swing2", -1, 15, 15, "pierce-ltng", -1, 15, 15, "skill", 20, 3, 3, "skilltab", 2, 2, 4, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Giantmaimer", 100, -1, -1, 1, -1, -1, -1, "6hx", "Colossus Crossbow", -1, -1, 5, 5000, "cred", "cred", "", "", "", -1, "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Demon's Arch", 100, 1, -1, 1, -1, 76, 68, "7s7", "balrog spear", -1, -1, 5, 5000, "cred", "cred", "", "", "", -1, "", "dmg%", -1, 160, 210, "dmg-fire", -1, 232, 323, "lifesteal", -1, 6, 12, "rep-quant", 30, -1, -1, "swing2", -1, 30, 30, "dmg-ltng", -1, 23, 333, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Boneflame", 100, 1, -1, 1, -1, 80, 72, "nee", "succubae skull", -1, -1, 3, 5000, "dred", "dred", "", "", "", -1, "", "ac%", -1, 120, 150, "move2", -1, 20, 20, "gethit-skill", 77, 15, 3, "nec", -1, 2, 3, "res-all", -1, 20, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Steelpillar", 100, 1, -1, 1, -1, 77, 69, "7p7", "war pike", -1, -1, 3, 5000, "", "", "", "", "", -1, "", "dmg%", -1, 210, 260, "swing2", -1, 25, 25, "reduce-ac", -1, 20, 20, "ac%", -1, 50, 80, "indestruct", -1, 1, 1, "crush", -1, 25, 25, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Nightwing's Veil", 100, 1, -1, 1, -1, 75, 67, "uhm", "spired helm", -1, -1, 3, 5000, "cblu", "cblu", "", "", "", -1, "", "ac%", -1, 90, 120, "allskills", -1, 2, 2, "dex", -1, 10, 20, "abs-cold", -1, 5, 9, "half-freeze", -1, 1, 1, "extra-cold", -1, 8, 15, "ease", -1, -50, -50, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Crown of Ages", 100, 1, -1, 1, -1, 86, 82, "urn", "corona", 1, -1, 3, 5000, "dgld", "dgld", "", "", "", -1, "", "balance2", -1, 30, 30, "res-all", -1, 20, 30, "allskills", -1, 1, 1, "ac", -1, 100, 150, "indestruct", -1, 1, 1, "red-dmg%", -1, 10, 15, "ac%", -1, 50, 50, "sock", -1, 1, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Andariel's Visage", 100, 1, -1, 1, -1, 85, 83, "usk", "demonhead", 1, -1, 3, 5000, "dred", "dred", "", "", "", -1, "", "ac%", -1, 100, 150, "res-pois", -1, 70, 70, "allskills", -1, 2, 2, "res-pois-max", -1, 10, 10, "swing2", -1, 20, 20, "str", -1, 25, 30, "gethit-skill", 92, 15, 15, "charged", 278, 20, 3, "lifesteal", -1, 8, 10, "res-fire", -1, -30, -30, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Darkfear", 100, -1, -1, 1, -1, -1, -1, "ulm", "armet", -1, -1, 5, 5000, "blac", "", "", "invhlmu", "", -1, "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Dragonscale", 100, 1, -1, 1, -1, 84, 80, "pae", "zakarum shield", -1, -1, 3, 5000, "dgrn", "dgrn", "", "", "", -1, "", "ac%", -1, 170, 200, "abs-fire%", -1, 10, 20, "res-fire-max", -1, 5, 5, "str", -1, 15, 25, "dmg-fire", -1, 211, 371, "oskill", 62, 10, 10, "extra-fire", -1, 15, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Steel Carapice", 100, 1, -1, 1, -1, 74, 66, "uul", "shadow plate", -1, -1, 3, 5000, "dgry", "dgry", "", "", "", -1, "", "ac%", -1, 190, 220, "balance2", -1, 20, 20, "red-dmg", -1, 9, 14, "res-cold", -1, 40, 60, "regen-mana", -1, 10, 15, "rep-dur", 5, -1, -1, "gethit-skill", 76, 8, 6, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Medusa's Gaze", 100, 1, -1, 1, -1, 84, 76, "uow", "aegis", -1, -1, 3, 5000, "lred", "lred", "", "invtowu", "", -1, "", "ac%", -1, 150, 180, "slow", -1, 20, 20, "gethit-skill", 91, 10, 7, "lifesteal", -1, 5, 9, "death-skill", 48, 100, 44, "res-cold", -1, 40, 80, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Ravenlore", 100, 1, -1, 1, -1, 82, 74, "dre", "sky spirit", -1, -1, 3, 5000, "dgld", "dgld", "", "", "", -1, "", "ac%", -1, 120, 150, "res-all", -1, 15, 25, "skilltab", 17, 3, 3, "enr", -1, 20, 30, "pierce-fire", -1, 10, 20, "skill", 221, 7, 7, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Boneshade", 100, 1, -1, 1, -1, 84, 79, "7bw", "lich wand", -1, -1, 3, 5000, "dgry", "dgry", "", "invbwnu", "", -1, "", "nec", -1, 2, 2, "cast2", -1, 25, 25, "skill", 67, 4, 5, "skill", 68, 4, 5, "skill", 84, 2, 3, "skill", 93, 1, 2, "skill", 78, 2, 3, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Nethercrow", 100, -1, -1, 1, -1, -1, -1, "urs", "Great Hauberk", -1, -1, 3, 5000, "cblu", "cblu", "", "", "", -1, "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Flamebellow", 100, 1, -1, 1, -1, 79, 71, "7gs", "balrog blade", -1, -1, 3, 5000, "cred", "cred", "", "invgisu", "", -1, "", "dmg%", -1, 170, 240, "dmg-fire", -1, 233, 482, "fireskill", -1, 3, 3, "abs-fire%", -1, 20, 30, "hit-skill", 225, 12, 16, "str", -1, 10, 20, "vit", -1, 5, 10, "oskill", 41, 12, 18, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Fathom", 100, 1, -1, 1, -1, 81, 73, "obf", "dimensional shard", -1, -1, 3, 5000, "lblu", "", "", "", "", -1, "", "sor", -1, 3, 3, "extra-cold", -1, 15, 30, "cast2", -1, 20, 20, "res-fire", -1, 25, 40, "res-ltng", -1, 25, 40, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Wolfhowl", 100, 1, -1, 1, -1, 85, 79, "bac", "fury visor", -1, -1, 3, 5000, "cred", "cred", "", "", "", -1, "", "ac%", -1, 120, 150, "skilltab", 14, 2, 3, "str", -1, 8, 15, "dex", -1, 8, 15, "vit", -1, 8, 15, "oskill", 223, 3, 6, "charged", 237, 18, 15, "oskill", 224, 3, 6, "oskill", 232, 3, 6, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Spirit Ward", 100, 1, -1, 1, -1, 76, 68, "uts", "ward", -1, -1, 3, 5000, "dblu", "dblu", "", "invgtsu", "", -1, "", "ac%", -1, 130, 180, "abs-cold", -1, 6, 11, "res-all", -1, 30, 40, "block", -1, 20, 30, "block2", -1, 25, 25, "gethit-skill", 267, 5, 8, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Kira's Guardian", 100, 1, -1, 1, -1, 85, 77, "ci2", "tiara", -1, -1, 3, 5000, "blac", "blac", "", "", "", -1, "", "ac", -1, 50, 120, "res-all", -1, 50, 70, "nofreeze", -1, 1, 1, "balance2", -1, 20, 20, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Ormus' Robes", 100, 1, -1, 1, -1, 83, 75, "uui", "dusk shroud", -1, -1, 3, 5000, "blac", "blac", "", "", "", -1, "", "ac", -1, 10, 20, "cast2", -1, 20, 20, "extra-fire", -1, 10, 15, "extra-cold", -1, 10, 15, "extra-ltng", -1, 10, 15, "regen-mana", -1, 10, 15, "skill-rand", 3, 36, 60, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Gheed's Fortune", 100, 1, -1, 1, -1, 70, 62, "cm3", "charm", -1, 1, 3, 5000, "lgld", "", "", "", "", -1, "", "mag%", -1, 20, 40, "gold%", -1, 80, 160, "cheap", -1, 10, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Stormlash", 100, 1, -1, 1, -1, 86, 82, "7fl", "scourge", 1, -1, 3, 5000, "dgry", "dgry", "", "", "", -1, "", "dmg%", -1, 240, 300, "swing2", -1, 30, 30, "hit-skill", 42, 15, 10, "hit-skill", 245, 20, 18, "dmg-ltng", -1, 1, 473, "light-thorns", -1, 30, 30, "crush", -1, 33, 33, "abs-ltng", -1, 3, 9, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Halaberd's Reign", 100, 1, -1, 1, -1, 85, 77, "bae", "conqueror crown", -1, -1, 3, 5000, "", "", "", "", "", -1, "", "ac%", -1, 140, 170, "skilltab", 13, 1, 1, "bar", -1, 2, 2, "balance2", -1, 20, 20, "regen", -1, 15, 23, "skill", 149, 1, 2, "skill", 155, 1, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Warriv's Warder", 100, -1, -1, 1, -1, -1, -1, "uts", "Ward", -1, -1, 3, 5000, "", "", "", "", "", -1, "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Spike Thorn", 100, 1, -1, 1, -1, 78, 70, "upk", "blade barrier", -1, -1, 5, 5000, "dyel", "dyel", "", "invspku", "", -1, "", "ac%", -1, 120, 150, "thorns/lvl", 11, -1, -1, "dur", -1, 250, 250, "balance2", -1, 30, 30, "red-dmg%", -1, 15, 20, "sock", -1, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Dracul's Grasp", 100, 1, -1, 1, -1, 84, 76, "uvg", "vampirebone gloves", -1, -1, 5, 5000, "dred", "dred", "", "", "", -1, "", "ac%", -1, 90, 120, "lifesteal", -1, 7, 10, "openwounds", -1, 25, 25, "hit-skill", 82, 5, 10, "heal-kill", -1, 5, 10, "str", -1, 10, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Frostwind", 100, 1, -1, 1, -1, 78, 70, "7ls", "cryptic sword", -1, -1, 5, 5000, "cblu", "cblu", "", "invlsdu", "", -1, "", "dmg%", -1, 180, 230, "freeze", -1, 4, 4, "half-freeze", -1, 1, 1, "dmg-cold", 150, 237, 486, "swing2", -1, 25, 25, "abs-cold%", -1, 7, 15, "oskill", 230, 7, 14, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Templar's Might", 100, 1, -1, 8, -1, 82, 74, "uar", "sacred armor", -1, -1, 5, 5000, "cgrn", "cgrn", "", "invaaru", "", -1, "", "ac%", -1, 170, 220, "balance2", -1, 20, 20, "ac-miss", -1, 250, 300, "stam", -1, 40, 50, "str", -1, 10, 15, "vit", -1, 10, 15, "skilltab", 10, 1, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Eschuta's temper", 100, 1, -1, 1, -1, 80, 72, "obc", "eldritch orb", -1, -1, 5, 5000, "cred", "", "", "", "", -1, "", "sor", -1, 1, 3, "cast2", -1, 40, 40, "extra-fire", -1, 10, 20, "extra-ltng", -1, 10, 20, "enr", -1, 20, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Firelizard's Talons", 100, 1, -1, 1, -1, 75, 67, "7lw", "feral claws", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "dmg%", -1, 200, 270, "swing2", -1, 15, 15, "skilltab", 20, 1, 3, "dmg-fire", -1, 236, 480, "res-fire", -1, 40, 70, "skill", 262, 1, 2, "skill", 272, 1, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Sandstorm Trek", 100, 1, -1, 1, -1, 72, 64, "uvb", "scarabshell boots", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "ac%", -1, 140, 170, "move2", -1, 20, 20, "balance2", -1, 20, 20, "stam/lvl", 8, -1, -1, "stamdrain", -1, 50, 50, "res-pois", -1, 40, 70, "rep-dur", 5, -1, -1, "str", -1, 10, 15, "vit", -1, 10, 15, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Marrowwalk", 100, 1, -1, 1, -1, 74, 66, "umb", "boneweave boots", -1, -1, 5, 5000, "dgry", "", "", "", "", -1, "", "ac%", -1, 170, 200, "move2", -1, 20, 20, "charged", 88, 13, 33, "charged", 82, 10, 12, "regen-stam", -1, 10, 10, "regen-mana", -1, 10, 10, "half-freeze", -1, 1, 1, "str", -1, 10, 20, "dex", -1, 17, 17, "skill", 69, 1, 2, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Heaven's Light", 100, 1, -1, 1, -1, 69, 61, "7sc", "mighty scepter", -1, -1, 5, 5000, "cblu", "cblu", "", "", "", -1, "", "dmg%", -1, 250, 300, "swing2", -1, 20, 20, "reduce-ac", -1, 33, 33, "light", -1, 3, 3, "demon-heal", -1, 15, 20, "crush", -1, 33, 33, "sock", -1, 1, 3, "pal", -1, 2, 3, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Merman's Speed", 100, -1, -1, -1, -1, -1, -1, "uhb", "Myrmidon Greaves", -1, -1, -1, -1, "", "", "", "", "", -1, "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Arachnid Mesh", 100, 1, -1, 1, -1, 87, 80, "ulc", "spiderweb sash", -1, -1, 5, 5000, "blac", "blac", "", "", "", -1, "", "ac%", -1, 90, 120, "cast2", -1, 20, 20, "charged", 278, 11, 3, "allskills", -1, 1, 1, "slow", -1, 10, 10, "mana%", -1, 5, 5, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Nosferatu's Coil", 100, 1, -1, 1, -1, 68, 51, "uvc", "vampirefang belt", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "str", -1, 15, 15, "mana-kill", -1, 2, 2, "slow", -1, 10, 10, "lifesteal", -1, 5, 7, "swing2", -1, 10, 10, "light", -1, -3, -3, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Metalgrid", 100, 1, -1, 2, -1, 85, 81, "amu", "amulet", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "ac", -1, 300, 350, "res-all", -1, 25, 35, "att", -1, 400, 450, "charged", 90, 11, 22, "charged", 76, 20, 12, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Verdugo's Hearty Cord", 100, 1, -1, 1, -1, 71, 63, "umc", "mithril coil", -1, -1, 5, 5000, "blac", "blac", "", "", "", -1, "", "ac%", -1, 90, 140, "vit", -1, 30, 40, "stam", -1, 100, 120, "balance2", -1, 10, 10, "red-dmg%", -1, 10, 15, "regen", -1, 10, 13, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Sigurd's Staunch", 100, -1, -1, 1, -1, -1, -1, "uhc", "Colossus Girdle", -1, -1, 5, 5000, "", "", "", "", "", -1, "", "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Carrion Wind", 100, 1, -1, 3, -1, 68, 60, "rin", "ring", -1, -1, 3, 5000, "", "", "", "", "", -1, "", "ac-miss", -1, 100, 160, "lifesteal", -1, 6, 9, "res-pois", -1, 55, 55, "gethit-skill", 92, 10, 10, "charged", 222, 15, 21, "hit-skill", 240, 8, 13, "dmg-to-mana", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Giantskull", 100, 1, -1, 1, -1, 73, 65, "uh9", "bone visage", -1, -1, 3, 5000, "lgry", "lgry", "", "invbhm", "", -1, "", "ac", -1, 250, 320, "str", -1, 25, 35, "crush", -1, 10, 10, "sock", -1, 1, 2, "knock", -1, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Ironward", 100, 1, -1, 1, -1, 68, 60, "7ws", "caduceus", -1, -1, 3, 5000, "blac", "blac", "", "", "", -1, "", "dmg%", -1, 240, 290, "slow", -1, 25, 25, "att%", -1, 150, 200, "swing2", -1, 10, 10, "dmg-mag", -1, 80, 240, "red-dmg", -1, 4, 7, "dmg", -1, 40, 85, "skilltab", 9, 2, 4, "crush", -1, 33, 33, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Annihilus", 100, 1, -1, 1, -1, 99, 70, "cm1", "charm", -1, 1, 3, 5000, "", "", "flpmss", "invmss", "item_gem", 12, "item_gem", "allskills", -1, 1, 1, "all-stats", -1, 10, 20, "res-all", -1, 10, 20, "addxp", -1, 5, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Arioc's Needle", 100, 1, -1, 1, -1, 85, 81, "7sr", "hyperion spear", -1, -1, 3, 5000, "", "", "", "", "", -1, "", "dmg%", -1, 180, 230, "dmg-pois", 250, 403, 403, "deadly", -1, 50, 50, "ignore-ac", -1, 1, 1, "allskills", -1, 2, 4, "swing2", -1, 30, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Cranebeak", 100, 1, -1, 1, -1, 71, 63, "7mp", "war spike", -1, -1, 3, 5000, "dgry", "", "", "invmpiu", "", -1, "", "dmg%", -1, 240, 300, "dmg-ltng", -1, 1, 305, "swing2", -1, 40, 40, "reduce-ac", -1, 25, 25, "mag%", -1, 20, 50, "charged", 221, 15, 8, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Nord's Tenderizer", 100, 1, -1, 1, -1, 76, 68, "7cl", "truncheon", -1, -1, 3, 5000, "", "", "", "invclbu", "", -1, "", "dmg%", -1, 270, 330, "freeze", -1, 2, 4, "swing2", -1, 25, 25, "charged", 59, 12, 16, "att%", -1, 150, 180, "abs-cold%", -1, 5, 15, "dmg-cold", 125, 205, 455, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Earthshifter", 100, 1, -1, 1, -1, 77, 69, "7gm", "thunder maul", -1, -1, 3, 5000, "", "", "", "", "", -1, "", "dmg%", -1, 250, 300, "hit-skill", 234, 25, 14, "crush", -1, 33, 33, "swing2", -1, 10, 10, "charged", 244, 30, 14, "skilltab", 17, 7, 7, "cast2", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Wraithflight", 100, 1, -1, 1, -1, 84, 76, "7gl", "ghost glaive", -1, -1, 3, 5000, "dblu", "dblu", "", "", "", -1, "", "dmg%", -1, 150, 190, "rep-quant", 40, -1, -1, "lifesteal", -1, 9, 13, "mana-kill", -1, 15, 15, "ethereal", -1, 1, 1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Bonehew", 100, 1, -1, 1, -1, 72, 64, "7o7", "ogre axe", -1, -1, 3, 5000, "bwht", "bwht", "", "", "", -1, "", "dmg%", -1, 270, 320, "swing2", -1, 30, 30, "charged", 74, 30, 14, "hit-skill", 84, 50, 16, "noheal", -1, 1, 1, "sock", -1, 2, 2, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Ondal's Wisdom", 100, 1, -1, 1, -1, 74, 66, "6cs", "elder staff", -1, -1, 3, 5000, "", "", "", "invcstu", "", -1, "", "cast2", -1, 45, 45, "enr", -1, 40, 50, "allskills", -1, 2, 4, "ac", -1, 450, 550, "addxp", -1, 5, 5, "red-mag", -1, 5, 8, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "The Reedeemer", 100, 1, -1, 1, -1, 80, 72, "7sc", "mighty scepter", -1, -1, 3, 5000, "", "", "", "", "", -1, "", "dmg%", -1, 250, 300, "dmg-demon", -1, 200, 250, "pal", -1, 2, 2, "ease", -1, -60, -60, "skill", 124, 2, 4, "skill", 101, 2, 4, "light", -1, 3, 3, "reduce-ac", -1, 33, 33, "dmg", -1, 60, 120, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Headhunter's Glory", 100, 1, -1, 1, -1, 83, 75, "ush", "troll nest", -1, -1, 3, 5000, "", "", "", "invbshu", "", -1, "", "ac", -1, 320, 420, "ac-miss", -1, 300, 350, "res-pois", -1, 30, 40, "sock", -1, 1, 3, "res-fire", -1, 20, 30, "heal-kill", -1, 5, 7, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Steelrend", 100, 1, -1, 1, -1, 78, 70, "uhg", "ogre gauntlets", -1, -1, 3, 5000, "", "", "", "", "", -1, "", "ac", -1, 170, 210, "str", -1, 15, 20, "dmg%", -1, 30, 60, "crush", -1, 10, 10, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Lightning Rainbow Facet - Die", 100, 1, -1, 1, -1, 85, 49, "jew", "jewel", -1, -1, 3, 5000, "", "", "", "", "", -1, "", "dmg-ltng", -1, 1, 74, "pierce-ltng", -1, 3, 5, "extra-ltng", -1, 3, 5, "death-skill", 53, 100, 47, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Cold Rainbow Facet - Die", 100, 1, -1, 1, -1, 85, 49, "jew", "jewel", -1, -1, 3, 5000, "", "", "", "", "", -1, "", "dmg-cold", 3, 24, 38, "pierce-cold", -1, 3, 5, "extra-cold", -1, 3, 5, "death-skill", 59, 100, 37, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Fire Rainbow Facet - Die", 100, 1, -1, 1, -1, 85, 49, "jew", "jewel", -1, -1, 3, 5000, "", "", "", "", "", -1, "", "dmg-fire", -1, 17, 45, "pierce-fire", -1, 3, 5, "extra-fire", -1, 3, 5, "death-skill", 56, 100, 31, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Poison Rainbow Facet - Die", 100, 1, -1, 1, -1, 85, 49, "jew", "jewel", -1, -1, 3, 5000, "", "", "", "", "", -1, "", "dmg-pois", 50, 187, 187, "pierce-pois", -1, 3, 5, "extra-pois", -1, 3, 5, "death-skill", 92, 100, 51, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Lightning Rainbow Facet - Lvl", 100, 1, -1, 1, -1, 85, 49, "jew", "jewel", -1, -1, 3, 5000, "", "", "", "", "", -1, "", "dmg-ltng", -1, 1, 74, "pierce-ltng", -1, 3, 5, "extra-ltng", -1, 3, 5, "levelup-skill", 48, 100, 41, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Cold Rainbow Facet - Lvl", 100, 1, -1, 1, -1, 85, 49, "jew", "jewel", -1, -1, 3, 5000, "", "", "", "", "", -1, "", "dmg-cold", 3, 24, 38, "pierce-cold", -1, 3, 5, "extra-cold", -1, 3, 5, "levelup-skill", 44, 100, 43, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Fire Rainbow Facet - Lvl", 100, 1, -1, 1, -1, 85, 49, "jew", "jewel", -1, -1, 3, 5000, "", "", "", "", "", -1, "", "dmg-fire", -1, 17, 45, "pierce-fire", -1, 3, 5, "extra-fire", -1, 3, 5, "levelup-skill", 46, 100, 29, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Poison Rainbow Facet - Lvl", 100, 1, -1, 1, -1, 85, 49, "jew", "jewel", -1, -1, 3, 5000, "", "", "", "", "", -1, "", "dmg-pois", 50, 187, 187, "pierce-pois", -1, 3, 5, "extra-pois", -1, 3, 5, "levelup-skill", 278, 100, 23, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1),
			new BaseUniqueItem(BaseUniqueItem.ItemCount++, "Hellfire Torch", 100, 1, -1, 1, -1, 99, 75, "cm2", "charm", -1, 1, 3, 5000, "", "", "flptrch", "invtrch", "item_gem", 12, "item_gem", "randclassskill", -1, 0, 6, "all-stats", -1, 10, 20, "res-all", -1, 10, 20, "light", -1, 8, 8, "hit-skill", 197, 25, 10, "charged", 62, 10, 30, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1, "", -1, -1, -1)
		};
	}
}
