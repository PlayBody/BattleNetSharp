using System;

namespace D2Data
{
	// Token: 0x0200092C RID: 2348
	public class ChargedSkillStat : SkillStat
	{
		// Token: 0x17003903 RID: 14595
		// (get) Token: 0x0600B958 RID: 47448 RVA: 0x0036250C File Offset: 0x0036070C
		public int Level
		{
			get
			{
				return this.Value;
			}
		}

		// Token: 0x0600B959 RID: 47449 RVA: 0x00362524 File Offset: 0x00360724
		public ChargedSkillStat(BaseStat stat, int level, int skill, int charges, int maxCharges)
			: base(stat, skill, level)
		{
			this.Charges = charges;
			this.MaxCharges = maxCharges;
		}

		// Token: 0x0600B95A RID: 47450 RVA: 0x00362544 File Offset: 0x00360744
		public override string ToString()
		{
			return string.Format("Level {0} {1} ({2}/{3} Charges)", new object[] { this.Value, this.Skill, this.Charges, this.MaxCharges });
		}

		// Token: 0x04006F14 RID: 28436
		public readonly int Charges;

		// Token: 0x04006F15 RID: 28437
		public readonly int MaxCharges;
	}
}
