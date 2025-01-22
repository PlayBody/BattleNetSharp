using System;

namespace D2Data
{
	// Token: 0x02000917 RID: 2327
	public class BaseItemType
	{
		// Token: 0x0600B91F RID: 47391 RVA: 0x0031873C File Offset: 0x0031693C
		public BaseItemType(int Index, string Name, string Code, string Equiv1, string Equiv2, int Repair, int Body, string BodyLoc1, string BodyLoc2, string Shoots, string Quiver, int Throwable, int Reload, int ReEquip, int AutoStack, int Magic, int Rare, int Normal, int Charm, int Gem, int Beltable, int MaxSock1, int MaxSock25, int MaxSock40, int TreasureClass, int Rarity, int StaffMods, int CostFormula, int Class, int VarInvGfx, string InvGfx1, string InvGfx2, string InvGfx3, string InvGfx4, string InvGfx5, string InvGfx6, int StorePage)
		{
			this.Index = Index;
			this.Type = (ItemKind)Index;
			this.Name = Name;
			this.Code = Code;
			this.Equiv1 = Equiv1;
			this.Equiv2 = Equiv2;
			this.Repair = Repair == 1;
			this.Body = Body == 1;
			this.BodyLoc1 = BodyLoc1;
			this.BodyLoc2 = BodyLoc2;
			this.Shoots = Shoots;
			this.Quiver = Quiver;
			this.Throwable = Throwable == 1;
			this.Reload = Reload == 1;
			this.ReEquip = ReEquip == 1;
			this.AutoStack = AutoStack == 1;
			this.Magic = Magic == 1;
			this.Rare = Rare == 1;
			this.Normal = Normal == 1;
			this.Charm = Charm == 1;
			this.Gem = Gem == 1;
			this.Beltable = Beltable == 1;
			this.MaxSock1 = MaxSock1;
			this.MaxSock25 = MaxSock25;
			this.MaxSock40 = MaxSock40;
			this.TreasureClass = TreasureClass;
			this.Rarity = Rarity;
			this.StaffMods = (CharacterClass)StaffMods;
			this.CostFormula = CostFormula;
			this.Class = (CharacterClass)Class;
			this.VarInvGfx = VarInvGfx;
			this.InvGfx1 = InvGfx1;
			this.InvGfx2 = InvGfx2;
			this.InvGfx3 = InvGfx3;
			this.InvGfx4 = InvGfx4;
			this.InvGfx5 = InvGfx5;
			this.InvGfx6 = InvGfx6;
			this.StorePage = (StorePage)StorePage;
		}

		// Token: 0x0600B920 RID: 47392 RVA: 0x003188A4 File Offset: 0x00316AA4
		public static BaseItemType Get(int index)
		{
			bool flag = index < 0 || index >= BaseItemType.ItemCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException();
			}
			return BaseItemType.items[index];
		}

		// Token: 0x0600B921 RID: 47393 RVA: 0x003188DC File Offset: 0x00316ADC
		public static BaseItemType Get(ItemKind type)
		{
			bool flag = type < ItemKind.NotUsed1 || type >= (ItemKind)BaseItemType.ItemCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException();
			}
			return BaseItemType.items[(int)type];
		}

		// Token: 0x0600B922 RID: 47394 RVA: 0x00318914 File Offset: 0x00316B14
		public static BaseItemType GetByCode(string code)
		{
			code = code.ToLower();
			for (int i = 0; i < BaseItemType.ItemCount; i++)
			{
				bool flag = BaseItemType.items[i].Code == code;
				if (flag)
				{
					return BaseItemType.items[i];
				}
			}
			throw new ArgumentException(string.Format("No BaseItemType with code {0} found !", code));
		}

		// Token: 0x04006C1B RID: 27675
		public readonly int Index;

		// Token: 0x04006C1C RID: 27676
		public readonly ItemKind Type;

		// Token: 0x04006C1D RID: 27677
		public readonly string Name;

		// Token: 0x04006C1E RID: 27678
		public readonly string Code;

		// Token: 0x04006C1F RID: 27679
		public readonly string Equiv1;

		// Token: 0x04006C20 RID: 27680
		public readonly string Equiv2;

		// Token: 0x04006C21 RID: 27681
		public readonly bool Repair;

		// Token: 0x04006C22 RID: 27682
		public readonly bool Body;

		// Token: 0x04006C23 RID: 27683
		public readonly string BodyLoc1;

		// Token: 0x04006C24 RID: 27684
		public readonly string BodyLoc2;

		// Token: 0x04006C25 RID: 27685
		public readonly string Shoots;

		// Token: 0x04006C26 RID: 27686
		public readonly string Quiver;

		// Token: 0x04006C27 RID: 27687
		public readonly bool Throwable;

		// Token: 0x04006C28 RID: 27688
		public readonly bool Reload;

		// Token: 0x04006C29 RID: 27689
		public readonly bool ReEquip;

		// Token: 0x04006C2A RID: 27690
		public readonly bool AutoStack;

		// Token: 0x04006C2B RID: 27691
		public readonly bool Magic;

		// Token: 0x04006C2C RID: 27692
		public readonly bool Rare;

		// Token: 0x04006C2D RID: 27693
		public readonly bool Normal;

		// Token: 0x04006C2E RID: 27694
		public readonly bool Charm;

		// Token: 0x04006C2F RID: 27695
		public readonly bool Gem;

		// Token: 0x04006C30 RID: 27696
		public readonly bool Beltable;

		// Token: 0x04006C31 RID: 27697
		public readonly int MaxSock1;

		// Token: 0x04006C32 RID: 27698
		public readonly int MaxSock25;

		// Token: 0x04006C33 RID: 27699
		public readonly int MaxSock40;

		// Token: 0x04006C34 RID: 27700
		public readonly int TreasureClass;

		// Token: 0x04006C35 RID: 27701
		public readonly int Rarity;

		// Token: 0x04006C36 RID: 27702
		public readonly CharacterClass StaffMods;

		// Token: 0x04006C37 RID: 27703
		public readonly int CostFormula;

		// Token: 0x04006C38 RID: 27704
		public readonly CharacterClass Class;

		// Token: 0x04006C39 RID: 27705
		public readonly int VarInvGfx;

		// Token: 0x04006C3A RID: 27706
		public readonly string InvGfx1;

		// Token: 0x04006C3B RID: 27707
		public readonly string InvGfx2;

		// Token: 0x04006C3C RID: 27708
		public readonly string InvGfx3;

		// Token: 0x04006C3D RID: 27709
		public readonly string InvGfx4;

		// Token: 0x04006C3E RID: 27710
		public readonly string InvGfx5;

		// Token: 0x04006C3F RID: 27711
		public readonly string InvGfx6;

		// Token: 0x04006C40 RID: 27712
		public readonly StorePage StorePage;

		// Token: 0x04006C41 RID: 27713
		private static int ItemCount = 0;

		// Token: 0x04006C42 RID: 27714
		protected static BaseItemType[] items = new BaseItemType[]
		{
			new BaseItemType(BaseItemType.ItemCount++, "None", "", "", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", -1),
			new BaseItemType(BaseItemType.ItemCount++, "None", "", "", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", -1),
			new BaseItemType(BaseItemType.ItemCount++, "Shield", "shie", "shld", "", 1, 1, "rarm", "larm", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 3, 3, 4, 0, 3, -1, 1, -1, 0, "", "", "", "", "", "", 1),
			new BaseItemType(BaseItemType.ItemCount++, "Armor", "tors", "armo", "", 1, 1, "tors", "tors", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 3, 4, 6, 0, 3, -1, 1, -1, 0, "", "", "", "", "", "", 1),
			new BaseItemType(BaseItemType.ItemCount++, "Gold", "gold", "misc", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 1, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", -1),
			new BaseItemType(BaseItemType.ItemCount++, "Bow Quiver", "bowq", "misl", "", 0, 1, "rarm", "larm", "", "bow", 0, 1, 0, 1, -1, -1, 1, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Crossbow Quiver", "xboq", "misl", "", 0, 1, "rarm", "larm", "", "xbow", 0, 1, 0, 1, -1, -1, 1, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Player Body Part", "play", "misc", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 1, 1, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Herb", "herb", "misc", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Potion", "poti", "misc", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 1, 0, 0, 1, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Ring", "ring", "misc", "", 0, 1, "rrin", "lrin", "", "", 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 5, "invrin1", "invrin2", "invrin3", "invrin4", "invrin5", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Elixir", "elix", "misc", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 0, 0, 0, 1, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Amulet", "amul", "misc", "", 0, 1, "neck", "neck", "", "", 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 3, "invamu1", "invamu2", "invamu3", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Charm", "char", "misc", "", 0, 0, "", "", "", "", 0, 0, 0, 0, 1, -1, 0, 1, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 3, "invch1", "invch4", "invch7", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Not Used", "", "", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", -1),
			new BaseItemType(BaseItemType.ItemCount++, "Boots", "boot", "armo", "", 1, 1, "feet", "feet", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 3, -1, 1, -1, 0, "", "", "", "", "", "", 1),
			new BaseItemType(BaseItemType.ItemCount++, "Gloves", "glov", "armo", "", 1, 1, "glov", "glov", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 3, -1, 1, -1, 0, "", "", "", "", "", "", 1),
			new BaseItemType(BaseItemType.ItemCount++, "Not Used", "", "", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", -1),
			new BaseItemType(BaseItemType.ItemCount++, "Book", "book", "misc", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 1, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Belt", "belt", "armo", "", 1, 1, "belt", "belt", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 3, -1, 1, -1, 0, "", "", "", "", "", "", 1),
			new BaseItemType(BaseItemType.ItemCount++, "Gem", "gem", "sock", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 1, 0, 1, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Torch", "torc", "misc", "", 0, 1, "", "", "", "", 0, 0, 0, 0, -1, -1, 1, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Scroll", "scro", "misc", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 1, 0, 0, 1, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Not Used", "", "", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", -1),
			new BaseItemType(BaseItemType.ItemCount++, "Scepter", "scep", "rod", "", 1, 1, "rarm", "larm", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 3, 5, 6, 0, 1, 3, 0, -1, 0, "", "", "", "", "", "", 2),
			new BaseItemType(BaseItemType.ItemCount++, "Wand", "wand", "rod", "", 1, 1, "rarm", "larm", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 2, 2, 2, 0, 1, 2, 0, -1, 0, "", "", "", "", "", "", 2),
			new BaseItemType(BaseItemType.ItemCount++, "Staff", "staf", "rod", "", 1, 1, "rarm", "larm", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 5, 6, 6, 0, 1, 1, 0, -1, 0, "", "", "", "", "", "", 2),
			new BaseItemType(BaseItemType.ItemCount++, "Bow", "bow", "miss", "", 0, 1, "rarm", "larm", "bowq", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 3, 4, 6, 1, 3, -1, 0, -1, 0, "", "", "", "", "", "", 2),
			new BaseItemType(BaseItemType.ItemCount++, "Axe", "axe", "mele", "", 1, 1, "rarm", "larm", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 4, 5, 6, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 2),
			new BaseItemType(BaseItemType.ItemCount++, "Club", "club", "blun", "", 1, 1, "rarm", "larm", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 3, 4, 6, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 2),
			new BaseItemType(BaseItemType.ItemCount++, "Sword", "swor", "mele", "", 1, 1, "rarm", "larm", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 3, 4, 6, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 2),
			new BaseItemType(BaseItemType.ItemCount++, "Hammer", "hamm", "blun", "", 1, 1, "rarm", "larm", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 3, 4, 6, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 2),
			new BaseItemType(BaseItemType.ItemCount++, "Knife", "knif", "mele", "", 1, 1, "rarm", "larm", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 2, 3, 3, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 2),
			new BaseItemType(BaseItemType.ItemCount++, "Spear", "spea", "mele", "", 1, 1, "rarm", "larm", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 3, 4, 6, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 2),
			new BaseItemType(BaseItemType.ItemCount++, "Polearm", "pole", "mele", "", 1, 1, "rarm", "larm", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 3, 4, 6, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 2),
			new BaseItemType(BaseItemType.ItemCount++, "Crossbow", "xbow", "miss", "", 1, 1, "rarm", "larm", "xboq", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 3, 4, 6, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 2),
			new BaseItemType(BaseItemType.ItemCount++, "Mace", "mace", "blun", "", 1, 1, "rarm", "larm", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 3, 4, 6, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 2),
			new BaseItemType(BaseItemType.ItemCount++, "Helm", "helm", "armo", "", 1, 1, "head", "head", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 2, 2, 3, 0, 3, -1, 1, -1, 0, "", "", "", "", "", "", 1),
			new BaseItemType(BaseItemType.ItemCount++, "Missile Potion", "tpot", "thro", "", 0, 1, "rarm", "larm", "", "", 1, 1, 1, 1, -1, -1, 1, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Quest", "ques", "", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", -1),
			new BaseItemType(BaseItemType.ItemCount++, "Body Part", "body", "misc", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 1, 0, 0, 0, 0, 0, 0, 0, 3, -1, 2, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Key", "key", "misc", "", 0, 0, "", "", "", "", 0, 0, 0, 1, -1, -1, 1, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Throwing Knife", "tkni", "comb", "knif", 1, 1, "rarm", "larm", "", "", 1, 1, 1, 1, -1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Throwing Axe", "taxe", "comb", "axe", 1, 1, "rarm", "larm", "", "", 1, 1, 1, 1, -1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Javelin", "jave", "comb", "spea", 1, 1, "rarm", "larm", "", "", 1, 1, 1, 1, -1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Weapon", "weap", "", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 3, -1, 0, -1, 0, "", "", "", "", "", "", -1),
			new BaseItemType(BaseItemType.ItemCount++, "Melee Weapon", "mele", "weap", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 3, -1, 0, -1, 0, "", "", "", "", "", "", -1),
			new BaseItemType(BaseItemType.ItemCount++, "Missile Weapon", "miss", "weap", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", -1),
			new BaseItemType(BaseItemType.ItemCount++, "Thrown Weapon", "thro", "weap", "", 0, 0, "", "", "", "", 1, 0, 0, 0, -1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", -1),
			new BaseItemType(BaseItemType.ItemCount++, "Combo Weapon", "comb", "mele", "thro", 0, 0, "", "", "", "", 1, 0, 0, 0, -1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", -1),
			new BaseItemType(BaseItemType.ItemCount++, "Any Armor", "armo", "", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 3, -1, 0, -1, 0, "", "", "", "", "", "", -1),
			new BaseItemType(BaseItemType.ItemCount++, "Any Shield", "shld", "armo", "seco", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", -1),
			new BaseItemType(BaseItemType.ItemCount++, "Miscellaneous", "misc", "", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", -1),
			new BaseItemType(BaseItemType.ItemCount++, "Socket Filler", "sock", "misc", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", -1),
			new BaseItemType(BaseItemType.ItemCount++, "Second Hand", "seco", "", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", -1),
			new BaseItemType(BaseItemType.ItemCount++, "Staves And Rods", "rod", "blun", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", -1),
			new BaseItemType(BaseItemType.ItemCount++, "Missile", "misl", "misc", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", -1),
			new BaseItemType(BaseItemType.ItemCount++, "Blunt", "blun", "mele", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", -1),
			new BaseItemType(BaseItemType.ItemCount++, "Jewel", "jewl", "sock", "", 0, 0, "", "", "", "", 0, 0, 0, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 3, -1, 0, -1, 6, "invjw1", "invjw2", "invjw3", "invjw4", "invjw5", "invjw6", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Class Specific", "clas", "", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", -1),
			new BaseItemType(BaseItemType.ItemCount++, "Amazon Item", "amaz", "clas", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, -1, 0, 0, 0, "", "", "", "", "", "", -1),
			new BaseItemType(BaseItemType.ItemCount++, "Barbarian Item", "barb", "clas", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, -1, 0, 4, 0, "", "", "", "", "", "", -1),
			new BaseItemType(BaseItemType.ItemCount++, "Necromancer Item", "necr", "clas", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, -1, 0, 2, 0, "", "", "", "", "", "", -1),
			new BaseItemType(BaseItemType.ItemCount++, "Paladin Item", "pala", "clas", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, -1, 0, 3, 0, "", "", "", "", "", "", -1),
			new BaseItemType(BaseItemType.ItemCount++, "Sorceress Item", "sorc", "clas", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, -1, 0, 1, 0, "", "", "", "", "", "", -1),
			new BaseItemType(BaseItemType.ItemCount++, "Assassin Item", "assn", "clas", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 2, -1, 0, 6, 0, "", "", "", "", "", "", -1),
			new BaseItemType(BaseItemType.ItemCount++, "Druid Item", "drui", "clas", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, -1, 0, 5, 0, "", "", "", "", "", "", -1),
			new BaseItemType(BaseItemType.ItemCount++, "Hand to Hand", "h2h", "mele", "assn", 1, 1, "rarm", "larm", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 2, 3, 3, 0, 2, -1, 0, 6, 0, "", "", "", "", "", "", 2),
			new BaseItemType(BaseItemType.ItemCount++, "Orb", "orb", "weap", "sorc", 1, 1, "rarm", "larm", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 2, 3, 3, 0, 1, 1, 0, 1, 0, "", "", "", "", "", "", 2),
			new BaseItemType(BaseItemType.ItemCount++, "Voodoo Heads", "head", "shld", "necr", 1, 1, "rarm", "larm", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 2, 3, 3, 0, 1, 2, 0, 2, 0, "", "", "", "", "", "", 1),
			new BaseItemType(BaseItemType.ItemCount++, "Auric Shields", "ashd", "shld", "pala", 1, 1, "rarm", "larm", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 3, 4, 4, 0, 1, -1, 0, 3, 0, "", "", "", "", "", "", 1),
			new BaseItemType(BaseItemType.ItemCount++, "Primal Helm", "phlm", "helm", "barb", 1, 1, "head", "head", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 2, 3, 3, 0, 1, 4, 0, 4, 0, "", "", "", "", "", "", 1),
			new BaseItemType(BaseItemType.ItemCount++, "Pelt", "pelt", "helm", "drui", 1, 1, "head", "head", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 2, 3, 3, 0, 1, 5, 0, 5, 0, "", "", "", "", "", "", 1),
			new BaseItemType(BaseItemType.ItemCount++, "Cloak", "cloa", "tors", "assn", 1, 1, "tors", "tors", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 6, 0, 6, 0, "", "", "", "", "", "", 1),
			new BaseItemType(BaseItemType.ItemCount++, "Rune", "rune", "sock", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 1, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Circlet", "circ", "helm", "", 1, 1, "head", "head", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 1, 2, 3, 0, 3, -1, 1, -1, 0, "", "", "", "", "", "", 1),
			new BaseItemType(BaseItemType.ItemCount++, "Healing Potion", "hpot", "poti", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 1, 0, 0, 1, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Mana Potion", "mpot", "poti", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 1, 0, 0, 1, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Rejuvenation Potion", "rpot", "hpot", "mpot", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 1, 0, 0, 1, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Stamina Potion", "spot", "poti", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 1, 0, 0, 1, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Antidote Potion", "apot", "poti", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 1, 0, 0, 1, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Thawing Potion", "wpot", "poti", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 1, 0, 0, 1, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Small Charm", "scha", "char", "", 0, 0, "", "", "", "", 0, 0, 0, 0, 1, -1, 0, 1, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 3, "invch1", "invch4", "invch7", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Medium Charm", "mcha", "char", "", 0, 0, "", "", "", "", 0, 0, 0, 0, 1, -1, 0, 1, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 3, "invch2", "invch5", "invch8", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Large Charm", "lcha", "char", "", 0, 0, "", "", "", "", 0, 0, 0, 0, 1, -1, 0, 1, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 3, "invch3", "invch6", "invch9", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Amazon Bow", "abow", "bow", "amaz", 0, 1, "rarm", "larm", "bowq", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 3, 4, 5, 1, 1, -1, 0, 0, 0, "", "", "", "", "", "", 2),
			new BaseItemType(BaseItemType.ItemCount++, "Amazon Spear", "aspe", "spea", "amaz", 1, 1, "rarm", "larm", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 3, 4, 6, 0, 1, -1, 0, 0, 0, "", "", "", "", "", "", 2),
			new BaseItemType(BaseItemType.ItemCount++, "Amazon Javelin", "ajav", "jave", "amaz", 1, 1, "rarm", "larm", "", "", 1, 1, 1, 1, -1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, -1, 0, 0, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Hand to Hand 2", "h2h2", "h2h", "", 1, 1, "rarm", "larm", "", "", 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, 2, 3, 3, 0, 2, 6, 0, 6, 0, "", "", "", "", "", "", 2),
			new BaseItemType(BaseItemType.ItemCount++, "Magic Bow Quiver", "mboq", "bowq", "", 0, 1, "rarm", "larm", "", "bow", 0, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Magic Xbow Quiver", "mxbq", "xboq", "", 0, 1, "rarm", "larm", "", "xbow", 0, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Chipped Gem", "gem0", "gem", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 1, 0, 1, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Flawed Gem", "gem1", "gem", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 1, 0, 1, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Standard Gem", "gem2", "gem", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 1, 0, 1, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Flawless Gem", "gem3", "gem", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 1, 0, 1, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Perfect Gem", "gem4", "gem", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 1, 0, 1, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Amethyst", "gema", "gem", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 1, 0, 1, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Diamond", "gemd", "gem", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 1, 0, 1, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Emerald", "geme", "gem", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 1, 0, 1, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Ruby", "gemr", "gem", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 1, 0, 1, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Sapphire", "gems", "gem", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 1, 0, 1, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Topaz", "gemt", "gem", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 1, 0, 1, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3),
			new BaseItemType(BaseItemType.ItemCount++, "Skull", "gemz", "gem", "", 0, 0, "", "", "", "", 0, 0, 0, 0, -1, -1, 1, 0, 1, 0, 0, 0, 0, 0, 3, -1, 0, -1, 0, "", "", "", "", "", "", 3)
		};
	}
}
