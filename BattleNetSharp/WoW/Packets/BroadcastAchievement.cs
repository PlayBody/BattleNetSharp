using System;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007C7 RID: 1991
	public class BroadcastAchievement : ServerPacket
	{
		// Token: 0x040059A6 RID: 22950
		public bool GuildAchievement;

		// Token: 0x040059A7 RID: 22951
		public ObjectGuid PlayerGUID;

		// Token: 0x040059A8 RID: 22952
		public uint AchievementID;

		// Token: 0x040059A9 RID: 22953
		public string Name;
	}
}
