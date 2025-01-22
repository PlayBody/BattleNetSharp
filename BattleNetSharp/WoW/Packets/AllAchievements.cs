using System;
using System.Collections.Generic;

namespace WoW.Packets
{
	// Token: 0x020007D3 RID: 2003
	public class AllAchievements
	{
		// Token: 0x040059CF RID: 22991
		public int EarnedNum;

		// Token: 0x040059D0 RID: 22992
		public int ProgressNum;

		// Token: 0x040059D1 RID: 22993
		public List<EarnedAchievement> Earned;

		// Token: 0x040059D2 RID: 22994
		public List<CriteriaProgressPkt> Progress;
	}
}
