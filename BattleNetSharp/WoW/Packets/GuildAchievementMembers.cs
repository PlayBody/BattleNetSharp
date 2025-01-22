using System;
using System.Collections.Generic;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007CF RID: 1999
	public class GuildAchievementMembers : ServerPacket
	{
		// Token: 0x040059B8 RID: 22968
		public ObjectGuid GuildGUID;

		// Token: 0x040059B9 RID: 22969
		public uint AchievementID;

		// Token: 0x040059BA RID: 22970
		public List<ObjectGuid> Member;
	}
}
