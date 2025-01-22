using System;

namespace D2Data
{
	// Token: 0x0200096F RID: 2415
	public class SkillStat : SignedStat
	{
		// Token: 0x0600B998 RID: 47512 RVA: 0x0037C734 File Offset: 0x0037A934
		public SkillStat(BaseStat stat, int skill, int val)
			: base(stat, val)
		{
			this.Skill = (SkillType)skill;
		}

		// Token: 0x04008058 RID: 32856
		public readonly SkillType Skill;
	}
}
