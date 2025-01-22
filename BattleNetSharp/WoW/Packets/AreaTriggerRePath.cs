using System;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007DD RID: 2013
	public class AreaTriggerRePath : ServerPacket
	{
		// Token: 0x040059E3 RID: 23011
		public ObjectGuid TriggerGUID;

		// Token: 0x040059E4 RID: 23012
		public Optional<AreaTriggerSplineInfo> AreaTriggerSpline;
	}
}
