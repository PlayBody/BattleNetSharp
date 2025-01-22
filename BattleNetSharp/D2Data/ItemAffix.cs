using System;

namespace D2Data
{
	// Token: 0x02000940 RID: 2368
	public class ItemAffix
	{
		// Token: 0x17003906 RID: 14598
		// (get) Token: 0x0600B969 RID: 47465 RVA: 0x00362A88 File Offset: 0x00360C88
		public string Name
		{
			get
			{
				bool flag = (this.Type & ItemAffixType.Superior) == ItemAffixType.Superior;
				string text;
				if (flag)
				{
					text = ItemNames.SuperiorPrefix;
				}
				else
				{
					bool flag2 = (this.Type & ItemAffixType.Inferior) == ItemAffixType.Inferior;
					if (flag2)
					{
						text = ItemNames.InferiorPrefix[this.Index];
					}
					else
					{
						bool flag3 = (this.Type & ItemAffixType.Magic) == ItemAffixType.Magic;
						if (flag3)
						{
							bool flag4 = this.Index == 0;
							if (flag4)
							{
								text = null;
							}
							else
							{
								bool flag5 = (this.Type & ItemAffixType.Prefix) == ItemAffixType.Prefix;
								if (flag5)
								{
									text = ((MagicPrefixType)this.Index).ToString();
								}
								else
								{
									text = ((MagicSuffixType)this.Index).ToString();
								}
							}
						}
						else
						{
							bool flag6 = (this.Type & ItemAffixType.Rare) == ItemAffixType.Rare;
							if (flag6)
							{
								text = ItemNames.RareAffix[this.Index];
							}
							else
							{
								text = null;
							}
						}
					}
				}
				return text;
			}
		}

		// Token: 0x0600B96A RID: 47466 RVA: 0x00362B64 File Offset: 0x00360D64
		public ItemAffix(ItemAffixType type, int index)
		{
			this.Index = index;
			this.Type = type;
			bool flag = this.Type < (ItemAffixType)3;
			if (flag)
			{
				throw new ArgumentException();
			}
			bool flag2 = (this.Type & (ItemAffixType)3) == ItemAffixType.NotApplicable;
			if (flag2)
			{
				ItemAffixType type2 = this.Type;
				bool flag3 = type2 <= ItemAffixType.Superior;
				if (flag3)
				{
					bool flag4 = type2 == ItemAffixType.Inferior;
					if (flag4)
					{
						this.Type |= ItemAffixType.Prefix;
						return;
					}
					bool flag5 = type2 == ItemAffixType.Superior;
					if (flag5)
					{
						this.Type |= ItemAffixType.Prefix;
						return;
					}
				}
				else
				{
					bool flag6 = type2 == ItemAffixType.Magic;
					if (flag6)
					{
						throw new ArgumentException();
					}
					bool flag7 = type2 == ItemAffixType.Rare;
					if (flag7)
					{
						bool flag8 = index < ItemNames.RarePrefixOffset;
						if (flag8)
						{
							this.Type |= ItemAffixType.Suffix;
							return;
						}
						this.Type |= ItemAffixType.Prefix;
						return;
					}
				}
				throw new ArgumentException();
			}
		}

		// Token: 0x0600B96B RID: 47467 RVA: 0x00362C50 File Offset: 0x00360E50
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x040071F6 RID: 29174
		public readonly ItemAffixType Type;

		// Token: 0x040071F7 RID: 29175
		public readonly int Index;
	}
}
