using System;

namespace WoW.Packets
{
	// Token: 0x020007DB RID: 2011
	public class AreaTriggerDenied : ServerPacket
	{
		// Token: 0x040059E1 RID: 23009
		public int AreaTriggerID;

		// Token: 0x040059E2 RID: 23010
		public bool Entered;
	}
}
