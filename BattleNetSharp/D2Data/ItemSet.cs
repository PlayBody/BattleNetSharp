using System;

namespace D2Data
{
	// Token: 0x0200094C RID: 2380
	public class ItemSet
	{
		// Token: 0x0600B96E RID: 47470 RVA: 0x003634C4 File Offset: 0x003616C4
		public ItemSet(int index, string name, string name2, int version, int level, string PCode2a, string PParam2a, int PMin2a, int PMax2a, string PCode2b, string PParam2b, int PMin2b, int PMax2b, string PCode3a, string PParam3a, int PMin3a, int PMax3a, string PCode3b, string PParam3b, int PMin3b, int PMax3b, string PCode4a, string PParam4a, int PMin4a, int PMax4a, string PCode4b, string PParam4b, int PMin4b, int PMax4b, string PCode5a, string PParam5a, int PMin5a, int PMax5a, string PCode5b, string PParam5b, int PMin5b, int PMax5b, string FCode1, string FParam1, int FMin1, int FMax1, string FCode2, string FParam2, int FMin2, int FMax2, string FCode3, string FParam3, int FMin3, int FMax3, string FCode4, string FParam4, int FMin4, int FMax4, string FCode5, string FParam5, int FMin5, int FMax5, string FCode6, string FParam6, int FMin6, int FMax6, string FCode7, string FParam7, int FMin7, int FMax7, string FCode8, string FParam8, int FMin8, int FMax8)
		{
			this.Index = index;
			this.Id = (ItemSetType)index;
			this.Name = name;
			this.Name2 = name2;
			this.Version = version;
			this.Level = level;
			this.PCode2a = PCode2a;
			this.PParam2a = PParam2a;
			this.PMin2a = PMin2a;
			this.PMax2a = PMax2a;
			this.PCode2b = PCode2b;
			this.PParam2b = PParam2b;
			this.PMin2b = PMin2b;
			this.PMax2b = PMax2b;
			this.PCode3a = PCode3a;
			this.PParam3a = PParam3a;
			this.PMin3a = PMin3a;
			this.PMax3a = PMax3a;
			this.PCode3b = PCode3b;
			this.PParam3b = PParam3b;
			this.PMin3b = PMin3b;
			this.PMax3b = PMax3b;
			this.PCode4a = PCode4a;
			this.PParam4a = PParam4a;
			this.PMin4a = PMin4a;
			this.PMax4a = PMax4a;
			this.PCode4b = PCode4b;
			this.PParam4b = PParam4b;
			this.PMin4b = PMin4b;
			this.PMax4b = PMax4b;
			this.PCode5a = PCode5a;
			this.PParam5a = PParam5a;
			this.PMin5a = PMin5a;
			this.PMax5a = PMax5a;
			this.PCode5b = PCode5b;
			this.PParam5b = PParam5b;
			this.PMin5b = PMin5b;
			this.PMax5b = PMax5b;
			this.FCode1 = FCode1;
			this.FParam1 = FParam1;
			this.FMin1 = FMin1;
			this.FMax1 = FMax1;
			this.FCode2 = FCode2;
			this.FParam2 = FParam2;
			this.FMin2 = FMin2;
			this.FMax2 = FMax2;
			this.FCode3 = FCode3;
			this.FParam3 = FParam3;
			this.FMin3 = FMin3;
			this.FMax3 = FMax3;
			this.FCode4 = FCode4;
			this.FParam4 = FParam4;
			this.FMin4 = FMin4;
			this.FMax4 = FMax4;
			this.FCode5 = FCode5;
			this.FParam5 = FParam5;
			this.FMin5 = FMin5;
			this.FMax5 = FMax5;
			this.FCode6 = FCode6;
			this.FParam6 = FParam6;
			this.FMin6 = FMin6;
			this.FMax6 = FMax6;
			this.FCode7 = FCode7;
			this.FParam7 = FParam7;
			this.FMin7 = FMin7;
			this.FMax7 = FMax7;
			this.FCode8 = FCode8;
			this.FParam8 = FParam8;
			this.FMin8 = FMin8;
			this.FMax8 = FMax8;
		}

		// Token: 0x0600B96F RID: 47471 RVA: 0x00363708 File Offset: 0x00361908
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x0600B970 RID: 47472 RVA: 0x00363720 File Offset: 0x00361920
		public static ItemSet Get(int index)
		{
			bool flag = index < 0 || index >= ItemSet.ItemCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException();
			}
			return ItemSet.items[index];
		}

		// Token: 0x0600B971 RID: 47473 RVA: 0x00363758 File Offset: 0x00361958
		public static ItemSet Get(ItemSetType type)
		{
			bool flag = type < ItemSetType.CiverbsVestments || type >= (ItemSetType)ItemSet.ItemCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException();
			}
			return ItemSet.items[(int)type];
		}

		// Token: 0x0600B972 RID: 47474 RVA: 0x00363790 File Offset: 0x00361990
		public static ItemSet GetByName(string name)
		{
			for (int i = 0; i < ItemSet.ItemCount; i++)
			{
				bool flag = ItemSet.items[i].Name == name;
				if (flag)
				{
					return ItemSet.items[i];
				}
			}
			throw new ArgumentException(string.Format("No BaseItem named {0} found !", name));
		}

		// Token: 0x040072D0 RID: 29392
		public readonly int Index;

		// Token: 0x040072D1 RID: 29393
		public readonly ItemSetType Id;

		// Token: 0x040072D2 RID: 29394
		public readonly string Name;

		// Token: 0x040072D3 RID: 29395
		public readonly string Name2;

		// Token: 0x040072D4 RID: 29396
		public readonly int Version;

		// Token: 0x040072D5 RID: 29397
		public readonly int Level;

		// Token: 0x040072D6 RID: 29398
		public readonly string PCode2a;

		// Token: 0x040072D7 RID: 29399
		public readonly string PParam2a;

		// Token: 0x040072D8 RID: 29400
		public readonly int PMin2a;

		// Token: 0x040072D9 RID: 29401
		public readonly int PMax2a;

		// Token: 0x040072DA RID: 29402
		public readonly string PCode2b;

		// Token: 0x040072DB RID: 29403
		public readonly string PParam2b;

		// Token: 0x040072DC RID: 29404
		public readonly int PMin2b;

		// Token: 0x040072DD RID: 29405
		public readonly int PMax2b;

		// Token: 0x040072DE RID: 29406
		public readonly string PCode3a;

		// Token: 0x040072DF RID: 29407
		public readonly string PParam3a;

		// Token: 0x040072E0 RID: 29408
		public readonly int PMin3a;

		// Token: 0x040072E1 RID: 29409
		public readonly int PMax3a;

		// Token: 0x040072E2 RID: 29410
		public readonly string PCode3b;

		// Token: 0x040072E3 RID: 29411
		public readonly string PParam3b;

		// Token: 0x040072E4 RID: 29412
		public readonly int PMin3b;

		// Token: 0x040072E5 RID: 29413
		public readonly int PMax3b;

		// Token: 0x040072E6 RID: 29414
		public readonly string PCode4a;

		// Token: 0x040072E7 RID: 29415
		public readonly string PParam4a;

		// Token: 0x040072E8 RID: 29416
		public readonly int PMin4a;

		// Token: 0x040072E9 RID: 29417
		public readonly int PMax4a;

		// Token: 0x040072EA RID: 29418
		public readonly string PCode4b;

		// Token: 0x040072EB RID: 29419
		public readonly string PParam4b;

		// Token: 0x040072EC RID: 29420
		public readonly int PMin4b;

		// Token: 0x040072ED RID: 29421
		public readonly int PMax4b;

		// Token: 0x040072EE RID: 29422
		public readonly string PCode5a;

		// Token: 0x040072EF RID: 29423
		public readonly string PParam5a;

		// Token: 0x040072F0 RID: 29424
		public readonly int PMin5a;

		// Token: 0x040072F1 RID: 29425
		public readonly int PMax5a;

		// Token: 0x040072F2 RID: 29426
		public readonly string PCode5b;

		// Token: 0x040072F3 RID: 29427
		public readonly string PParam5b;

		// Token: 0x040072F4 RID: 29428
		public readonly int PMin5b;

		// Token: 0x040072F5 RID: 29429
		public readonly int PMax5b;

		// Token: 0x040072F6 RID: 29430
		public readonly string FCode1;

		// Token: 0x040072F7 RID: 29431
		public readonly string FParam1;

		// Token: 0x040072F8 RID: 29432
		public readonly int FMin1;

		// Token: 0x040072F9 RID: 29433
		public readonly int FMax1;

		// Token: 0x040072FA RID: 29434
		public readonly string FCode2;

		// Token: 0x040072FB RID: 29435
		public readonly string FParam2;

		// Token: 0x040072FC RID: 29436
		public readonly int FMin2;

		// Token: 0x040072FD RID: 29437
		public readonly int FMax2;

		// Token: 0x040072FE RID: 29438
		public readonly string FCode3;

		// Token: 0x040072FF RID: 29439
		public readonly string FParam3;

		// Token: 0x04007300 RID: 29440
		public readonly int FMin3;

		// Token: 0x04007301 RID: 29441
		public readonly int FMax3;

		// Token: 0x04007302 RID: 29442
		public readonly string FCode4;

		// Token: 0x04007303 RID: 29443
		public readonly string FParam4;

		// Token: 0x04007304 RID: 29444
		public readonly int FMin4;

		// Token: 0x04007305 RID: 29445
		public readonly int FMax4;

		// Token: 0x04007306 RID: 29446
		public readonly string FCode5;

		// Token: 0x04007307 RID: 29447
		public readonly string FParam5;

		// Token: 0x04007308 RID: 29448
		public readonly int FMin5;

		// Token: 0x04007309 RID: 29449
		public readonly int FMax5;

		// Token: 0x0400730A RID: 29450
		public readonly string FCode6;

		// Token: 0x0400730B RID: 29451
		public readonly string FParam6;

		// Token: 0x0400730C RID: 29452
		public readonly int FMin6;

		// Token: 0x0400730D RID: 29453
		public readonly int FMax6;

		// Token: 0x0400730E RID: 29454
		public readonly string FCode7;

		// Token: 0x0400730F RID: 29455
		public readonly string FParam7;

		// Token: 0x04007310 RID: 29456
		public readonly int FMin7;

		// Token: 0x04007311 RID: 29457
		public readonly int FMax7;

		// Token: 0x04007312 RID: 29458
		public readonly string FCode8;

		// Token: 0x04007313 RID: 29459
		public readonly string FParam8;

		// Token: 0x04007314 RID: 29460
		public readonly int FMin8;

		// Token: 0x04007315 RID: 29461
		public readonly int FMax8;

		// Token: 0x04007316 RID: 29462
		private static int ItemCount = 0;

		// Token: 0x04007317 RID: 29463
		private static ItemSet[] items = new ItemSet[]
		{
			new ItemSet(ItemSet.ItemCount++, "Civerb's Vestments", "Civerb's Vestments", 0, 13, "res-fire", "", 15, 15, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "str", "0", 15, 15, "dmg-undead", "0", 200, 200, "res-ltng", "0", 25, 25, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1),
			new ItemSet(ItemSet.ItemCount++, "Hsarus' Defense", "Hsarus' Defense", 0, 4, "thorns", "", 5, 5, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "dmg-max", "0", 5, 5, "nofreeze", "0", 1, 1, "res-ltng", "0", 25, 25, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1),
			new ItemSet(ItemSet.ItemCount++, "Cleglaw's Brace", "Cleglaw's Brace", 0, 6, "ac", "", 50, 50, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "ac", "0", 50, 50, "manasteal", "0", 6, 6, "crush", "0", 35, 35, "swing2", "", 20, 20, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1),
			new ItemSet(ItemSet.ItemCount++, "Iratha's Finery", "Iratha's Finery", 0, 21, "ac", "", 50, 50, "", "", -1, -1, "move2", "", 20, 20, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "res-all", "0", 20, 20, "res-fire-max", "0", 10, 10, "res-cold-max", "0", 10, 10, "res-ltng-max", "0", 10, 10, "res-pois-max", "0", 10, 10, "dex", "0", 15, 15, "", "", -1, -1, "", "", -1, -1),
			new ItemSet(ItemSet.ItemCount++, "Isenhart's Armory", "Isenhart's Armory", 0, 11, "str", "", 10, 10, "", "", -1, -1, "dex", "", 10, 10, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "lifesteal", "0", 5, 5, "res-all", "0", 10, 10, "att%", "0", 35, 35, "block", "", 30, 30, "move2", "", 20, 20, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1),
			new ItemSet(ItemSet.ItemCount++, "Vidala's Rig", "Vidala's Rig", 0, 19, "att", "", 75, 75, "", "", -1, -1, "dex", "", 15, 15, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "dmg-cold", "50", 15, 20, "freeze", "0", 1, 1, "pierce", "0", 50, 50, "str", "", 10, 10, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1),
			new ItemSet(ItemSet.ItemCount++, "Milabrega's Regalia", "Milabrega's Regalia", 0, 23, "att", "", 75, 75, "", "", -1, -1, "att", "", 125, 125, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "lifesteal", "0", 8, 8, "pal", "0", 2, 2, "manasteal", "0", 10, 10, "res-pois", "0", 15, 15, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1),
			new ItemSet(ItemSet.ItemCount++, "Cathan's Traps", "Cathan's Traps", 0, 15, "dmg-fire", "", 15, 20, "", "", -1, -1, "res-ltng", "", 25, 25, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "att", "0", 60, 60, "red-mag", "0", 3, 3, "res-all", "0", 25, 25, "cast1", "0", 10, 10, "mana", "0", 20, 20, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1),
			new ItemSet(ItemSet.ItemCount++, "Tancred's Battlegear", "Tancred's Battlegear", 0, 27, "dmg-ltng", "", 15, 15, "", "", -1, -1, "lifesteal", "", 5, 5, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "gold%", "0", 75, 75, "res-all", "0", 10, 10, "slow", "0", 35, 35, "manasteal", "0", 5, 5, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1),
			new ItemSet(ItemSet.ItemCount++, "Sigon's Complete Steel", "Sigon's Complete Steel", 0, 9, "lifesteal", "", 10, 10, "", "", -1, -1, "ac", "", 100, 100, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "res-fire", "0", 12, 12, "thorns", "0", 12, 12, "red-dmg", "0", 7, 7, "fire-max", "0", 24, 24, "mana", "", 20, 20, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1),
			new ItemSet(ItemSet.ItemCount++, "Infernal Tools", "Infernal Tools", 0, 7, "dmg-pois", "80", 25, 25, "", "", -1, -1, "mana", "", 10, 10, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "att%", "0", 20, 20, "nec", "0", 1, 1, "openwounds", "0", 20, 20, "manasteal", "", 6, 6, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1),
			new ItemSet(ItemSet.ItemCount++, "Berserker's Garb", "Berserker's Garb", 0, 5, "hp", "", 50, 50, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "res-pois-len", "0", 75, 75, "pois-min", "0", 16, 16, "pois-max", "0", 32, 32, "pois-len", "0", 75, 75, "ac", "", 75, 75, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1),
			new ItemSet(ItemSet.ItemCount++, "Death's Disguise", "Death's Disguise", 0, 8, "lifesteal", "", 8, 8, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "att%", "0", 40, 40, "dmg-min", "0", 10, 10, "res-all", "0", 25, 25, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1),
			new ItemSet(ItemSet.ItemCount++, "Angelical Raiment", "Angelical Raiment", 0, 17, "dex", "", 10, 10, "", "", -1, -1, "mana", "", 50, 50, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "res-all", "0", 25, 25, "half-freeze", "0", 1, 1, "mag%", "0", 40, 40, "regen-mana", "", 8, 8, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1),
			new ItemSet(ItemSet.ItemCount++, "Arctic Gear", "Arctic Gear", 0, 3, "str", "", 5, 5, "", "", -1, -1, "hp", "", 50, 50, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "cold-min", "0", 6, 6, "cold-max", "0", 14, 14, "cold-len", "0", 100, 100, "nofreeze", "0", 1, 1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1),
			new ItemSet(ItemSet.ItemCount++, "Arcanna's Tricks", "Arcanna's Tricks", 0, 20, "mana", "", 25, 25, "", "", -1, -1, "hp", "", 50, 50, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "cast3", "0", 20, 20, "manasteal", "0", 5, 5, "mana", "0", 25, 25, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1),
			new ItemSet(ItemSet.ItemCount++, "Natalya's Odium", "Natalya's Odium", 100, 22, "red-mag", "", 15, 15, "", "", -1, -1, "ac", "", 200, 200, "", "", -1, -1, "res-pois", "", 20, 20, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "res-all", "", 50, 50, "ass", "", 3, 3, "ac", "", 150, 150, "lifesteal", "", 14, 14, "manasteal", "", 14, 14, "red-dmg%", "", 30, 30, "fade", "", 1, 1, "", "", -1, -1),
			new ItemSet(ItemSet.ItemCount++, "Aldur's Watchtower", "Aldur's Watchtower", 100, 29, "att%", "", 150, 150, "", "", -1, -1, "mag%", "", 50, 50, "", "", -1, -1, "lifesteal", "", 10, 10, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "res-all", "", 50, 50, "dru", "", 3, 3, "ac", "", 150, 150, "manasteal", "", 10, 10, "mana", "", 150, 150, "dmg%", "", 350, 350, "state", "fullsetgeneric", 1, 1, "", "", -1, -1),
			new ItemSet(ItemSet.ItemCount++, "Immortal King", "Immortal King", 100, 37, "att", "", 50, 50, "", "", -1, -1, "att", "", 75, 75, "", "", -1, -1, "att", "", 125, 125, "", "", -1, -1, "att", "", 200, 200, "", "", -1, -1, "res-all", "", 50, 50, "bar", "", 3, 3, "hp", "", 150, 150, "red-mag", "", 10, 10, "state", "fullsetgeneric", 1, 1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1),
			new ItemSet(ItemSet.ItemCount++, "Tal Rasha's Wrappings", "Tal Rasha's Wrappings", 100, 26, "regen", "", 10, 10, "", "", -1, -1, "mag%", "", 65, 65, "", "", -1, -1, "balance2", "", 25, 25, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "res-all", "", 50, 50, "sor", "", 3, 3, "ac", "", 150, 150, "hp", "", 150, 150, "ac-miss", "", 50, 50, "state", "fullsetgeneric", 1, 1, "", "", -1, -1, "", "", -1, -1),
			new ItemSet(ItemSet.ItemCount++, "Griswold's Legacy", "Griswold's Legacy", 100, 44, "str", "", 20, 20, "", "", -1, -1, "dex", "", 30, 30, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "res-all", "", 50, 50, "pal", "", 3, 3, "att", "", 200, 200, "hp", "", 150, 150, "state", "fullsetgeneric", 1, 1, "balance2", "", 30, 30, "", "", -1, -1, "", "", -1, -1),
			new ItemSet(ItemSet.ItemCount++, "Trang-Oul's Avatar", "Trang-Oul's Avatar", 100, 32, "regen-mana", "", 15, 15, "oskill", "Fire Ball", 18, 18, "regen-mana", "", 15, 15, "oskill", "Fire Wall", 13, 13, "regen-mana", "", 15, 15, "oskill", "Meteor", 10, 10, "", "", -1, -1, "", "", -1, -1, "res-all", "", 50, 50, "nec", "", 3, 3, "mana", "", 100, 100, "ac", "", 200, 200, "state", "monsterset", 1, 1, "regen-mana", "", 15, 15, "oskill", "Fire Mastery", 3, 3, "lifesteal", "", 20, 20),
			new ItemSet(ItemSet.ItemCount++, "M'avina's Battle Hymn", "M'avina's Battle Hymn", 100, 21, "str", "", 20, 20, "", "", -1, -1, "dex", "", 30, 30, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "res-all", "", 50, 50, "ama", "", 3, 3, "ac", "", 100, 100, "att", "", 100, 100, "mag%", "", 100, 100, "state", "fullsetgeneric", 1, 1, "", "", -1, -1, "", "", -1, -1),
			new ItemSet(ItemSet.ItemCount++, "The Disciple", "The Disciple", 100, 39, "ac", "", 150, 150, "", "", -1, -1, "dmg-pois", "75", 75, 75, "", "", -1, -1, "str", "", 10, 10, "", "", -1, -1, "dex", "", 10, 10, "", "", -1, -1, "res-all", "", 50, 50, "allskills", "", 2, 2, "mana", "", 100, 100, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1),
			new ItemSet(ItemSet.ItemCount++, "Heaven's Brethren", "Heaven's Brethren", 100, 55, "regen-stam", "", 50, 50, "", "", -1, -1, "regen", "", 20, 20, "", "", -1, -1, "dmg-fire", "", 30, 30, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "res-all", "", 50, 50, "allskills", "", 2, 2, "nofreeze", "", 1, 1, "light", "", 5, 5, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1),
			new ItemSet(ItemSet.ItemCount++, "Orphan's Call", "Orphan's Call", 100, 41, "hp", "", 35, 35, "", "", -1, -1, "thorns", "", 5, 5, "", "", -1, -1, "ac", "", 100, 100, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "hp", "", 50, 50, "dex", "", 10, 10, "str", "", 20, 20, "ac", "", 100, 100, "res-all", "", 15, 15, "mag%", "0", 80, 80, "", "", -1, -1, "", "", -1, -1),
			new ItemSet(ItemSet.ItemCount++, "Hwanin's Majesty", "Hwanin's Majesty", 100, 28, "ac", "", 100, 100, "", "", -1, -1, "ac", "", 200, 200, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "allskills", "", 2, 2, "lifesteal", "", 20, 20, "move3", "", 30, 30, "res-all", "", 30, 30, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1),
			new ItemSet(ItemSet.ItemCount++, "Sazabi's Grand Tribute", "Sazabi's Grand Tribute", 100, 34, "move3", "", 40, 40, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "res-all", "", 30, 30, "lifesteal", "", 15, 15, "hp%", "", 27, 27, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1),
			new ItemSet(ItemSet.ItemCount++, "Bul-Kathos' Children", "Bul-Kathos' Children", 100, 50, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "dmg-fire", "", 20, 20, "allskills", "", 2, 2, "att", "", 200, 200, "ac", "", 25, 25, "dmg-undead", "", 200, 200, "dmg-demon", "", 200, 200, "", "", -1, -1, "", "", -1, -1),
			new ItemSet(ItemSet.ItemCount++, "Cow King's Leathers", "Cow King's Leathers", 100, 20, "res-pois", "", 25, 25, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "stam", "", 100, 100, "str", "", 20, 20, "gold%", "", 100, 100, "mag%", "", 100, 100, "gethit-skill", "42", 25, 5, "swing3", "", 30, 30, "", "", -1, -1, "", "", -1, -1),
			new ItemSet(ItemSet.ItemCount++, "Naj's Ancient Set", "Naj's Ancient Set", 100, 43, "ac", "", 175, 175, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "allskills", "", 1, 1, "regen", "", 10, 10, "dex", "", 15, 15, "res-all", "", 50, 50, "str", "", 20, 20, "mana", "", 100, 100, "", "", -1, -1, "", "", -1, -1),
			new ItemSet(ItemSet.ItemCount++, "McAuley's Folly", "McAuley's Folly", 100, 20, "ac", "", 50, 50, "", "", -1, -1, "att", "", 75, 75, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "allskills", "", 1, 1, "mag%", "", 50, 50, "mana", "", 50, 50, "lifesteal", "", 4, 4, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1, "", "", -1, -1)
		};
	}
}
