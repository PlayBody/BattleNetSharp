using System;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007CC RID: 1996
	public class GuildAchievementEarned : ServerPacket
	{
		// Token: 0x040059B1 RID: 22961
		public uint AchievementID;

		// Token: 0x040059B2 RID: 22962
		public ObjectGuid GuildGUID;

		// Token: 0x040059B3 RID: 22963
		public DateTime TimeEarned;
	}
}
