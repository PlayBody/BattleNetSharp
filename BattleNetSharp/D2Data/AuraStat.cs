using System;

namespace D2Data
{
	// Token: 0x02000914 RID: 2324
	public class AuraStat : SkillStat
	{
		// Token: 0x0600B872 RID: 47218 RVA: 0x002DE4B6 File Offset: 0x002DC6B6
		public AuraStat(BaseStat stat, int skill, int val)
			: base(stat, skill, val)
		{
		}

		// Token: 0x0600B873 RID: 47219 RVA: 0x002DE4C4 File Offset: 0x002DC6C4
		public override string ToString()
		{
			return string.Format("Level {0} {1} Aura", this.Value, this.Skill);
		}
	}
}
