using System;

namespace D2Data
{
	// Token: 0x0200096B RID: 2411
	public class SkillBonusStat : SkillStat
	{
		// Token: 0x0600B98E RID: 47502 RVA: 0x0037C575 File Offset: 0x0037A775
		public SkillBonusStat(BaseStat stat, int skill, int val)
			: base(stat, skill, val)
		{
		}

		// Token: 0x0600B98F RID: 47503 RVA: 0x0037C584 File Offset: 0x0037A784
		public override string ToString()
		{
			return string.Format("+{0} To {1}", this.Value, this.Skill);
		}
	}
}
