using System;

namespace D2Data
{
	// Token: 0x02000971 RID: 2417
	public class SkillTabBonusStat : SignedStat
	{
		// Token: 0x0600B999 RID: 47513 RVA: 0x0037C748 File Offset: 0x0037A948
		public SkillTabBonusStat(BaseStat stat, int tab, int charClass, int val)
			: base(stat, val)
		{
			this.Class = (CharacterClass)charClass;
			this.Tab = (SkillTab)((charClass << 3) | tab);
			this.TabNumber = tab;
		}

		// Token: 0x0600B99A RID: 47514 RVA: 0x0037C776 File Offset: 0x0037A976
		public SkillTabBonusStat(BaseStat stat, int tab, int charClass, int unknown, int val)
			: base(stat, val)
		{
			this.Class = (CharacterClass)charClass;
			this.Tab = (SkillTab)((charClass << 3) | tab);
			this.TabNumber = tab;
			this.Unknown = unknown;
		}

		// Token: 0x0600B99B RID: 47515 RVA: 0x0037C7AC File Offset: 0x0037A9AC
		public override string ToString()
		{
			bool flag = this.Unknown > 0;
			string text;
			if (flag)
			{
				text = string.Format("+{0} to {1} {2} Skills ({3})", new object[] { this.Value, this.Class, this.Tab, this.Unknown });
			}
			else
			{
				text = string.Format("+{0} to {1} {2} Skills", this.Value, this.Class, this.Tab);
			}
			return text;
		}

		// Token: 0x0400806F RID: 32879
		public readonly CharacterClass Class;

		// Token: 0x04008070 RID: 32880
		public readonly SkillTab Tab;

		// Token: 0x04008071 RID: 32881
		public readonly int TabNumber;

		// Token: 0x04008072 RID: 32882
		public readonly int Unknown = -1;
	}
}
