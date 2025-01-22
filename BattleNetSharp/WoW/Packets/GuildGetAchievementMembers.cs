using System;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007CE RID: 1998
	public class GuildGetAchievementMembers : ClientPacket
	{
		// Token: 0x040059B5 RID: 22965
		public ObjectGuid PlayerGUID;

		// Token: 0x040059B6 RID: 22966
		public ObjectGuid GuildGUID;

		// Token: 0x040059B7 RID: 22967
		public uint AchievementID;
	}
}
