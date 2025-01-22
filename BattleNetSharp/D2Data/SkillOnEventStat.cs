using System;

namespace D2Data
{
	// Token: 0x0200096E RID: 2414
	public class SkillOnEventStat : SkillStat
	{
		// Token: 0x1700390B RID: 14603
		// (get) Token: 0x0600B995 RID: 47509 RVA: 0x0037C694 File Offset: 0x0037A894
		public int Level
		{
			get
			{
				return this.Value;
			}
		}

		// Token: 0x0600B996 RID: 47510 RVA: 0x0037C6AC File Offset: 0x0037A8AC
		public SkillOnEventStat(BaseStat stat, int level, int skill, int chance)
			: base(stat, skill, level)
		{
			this.Chance = chance;
			this.Event = stat.ItemEvent1 | stat.ItemEvent2;
		}

		// Token: 0x0600B997 RID: 47511 RVA: 0x0037C6D4 File Offset: 0x0037A8D4
		public override string ToString()
		{
			return string.Format("{0}% Chance To Cast Level {1} {2} {3}", new object[]
			{
				this.Chance,
				this.Value,
				this.Skill,
				this.BaseStat.ToString().Substring(6)
			});
		}

		// Token: 0x04008056 RID: 32854
		public readonly int Chance;

		// Token: 0x04008057 RID: 32855
		public readonly ItemEventType Event;
	}
}
