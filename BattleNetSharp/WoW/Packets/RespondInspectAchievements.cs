using System;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007C1 RID: 1985
	public class RespondInspectAchievements : ServerPacket
	{
		// Token: 0x04005991 RID: 22929
		public ObjectGuid Player;

		// Token: 0x04005992 RID: 22930
		public AllAchievements Data = new AllAchievements();
	}
}
