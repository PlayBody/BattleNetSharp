using System;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007CB RID: 1995
	public class GuildAchievementDeleted : ServerPacket
	{
		// Token: 0x040059AE RID: 22958
		public ObjectGuid GuildGUID;

		// Token: 0x040059AF RID: 22959
		public uint AchievementID;

		// Token: 0x040059B0 RID: 22960
		public DateTime TimeDeleted;
	}
}
