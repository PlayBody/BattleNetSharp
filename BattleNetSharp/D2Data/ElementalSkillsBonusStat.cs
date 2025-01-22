using System;

namespace D2Data
{
	// Token: 0x02000932 RID: 2354
	public class ElementalSkillsBonusStat : SignedStat
	{
		// Token: 0x0600B963 RID: 47459 RVA: 0x00362819 File Offset: 0x00360A19
		public ElementalSkillsBonusStat(BaseStat stat, int element, int val)
			: base(stat, val)
		{
			this.Element = (DamageType)element;
		}

		// Token: 0x0600B964 RID: 47460 RVA: 0x00362830 File Offset: 0x00360A30
		public override string ToString()
		{
			return string.Format("+{0} To {1} Skills", this.Value, this.Element);
		}

		// Token: 0x04006F2D RID: 28461
		public readonly DamageType Element;
	}
}
