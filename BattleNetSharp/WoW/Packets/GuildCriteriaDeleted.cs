using System;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007C9 RID: 1993
	public class GuildCriteriaDeleted : ServerPacket
	{
		// Token: 0x040059AB RID: 22955
		public ObjectGuid GuildGUID;

		// Token: 0x040059AC RID: 22956
		public uint CriteriaID;
	}
}
