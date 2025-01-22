using System;
using D2Packets;

namespace WoW.Packets
{
	// Token: 0x020007DE RID: 2014
	public class AreaTriggerSplineInfo : Packet
	{
		// Token: 0x040059E5 RID: 23013
		public uint TimeToTarget;

		// Token: 0x040059E6 RID: 23014
		public uint ElapsedTimeForMovement;
	}
}
