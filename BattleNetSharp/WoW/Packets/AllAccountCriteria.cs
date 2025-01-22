using System;
using System.Collections.Generic;

namespace WoW.Packets
{
	// Token: 0x020007C0 RID: 1984
	public class AllAccountCriteria : ServerPacket
	{
		// Token: 0x04005990 RID: 22928
		public List<CriteriaProgressPkt> Progress = new List<CriteriaProgressPkt>();
	}
}
