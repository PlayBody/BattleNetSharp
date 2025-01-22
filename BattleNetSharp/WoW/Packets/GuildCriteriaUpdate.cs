using System;
using System.Collections.Generic;

namespace WoW.Packets
{
	// Token: 0x020007C8 RID: 1992
	public class GuildCriteriaUpdate : ServerPacket
	{
		// Token: 0x040059AA RID: 22954
		public List<GuildCriteriaProgress> Progress = new List<GuildCriteriaProgress>();
	}
}
