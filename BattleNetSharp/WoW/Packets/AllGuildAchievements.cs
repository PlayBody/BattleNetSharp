using System;
using System.Collections.Generic;

namespace WoW.Packets
{
	// Token: 0x020007CD RID: 1997
	public class AllGuildAchievements : ServerPacket
	{
		// Token: 0x040059B4 RID: 22964
		public List<EarnedAchievement> Earned;
	}
}
