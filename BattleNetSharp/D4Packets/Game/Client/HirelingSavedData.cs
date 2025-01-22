using System;

namespace D4Packets.Game.Client
{
	// Token: 0x020008A0 RID: 2208
	public class HirelingSavedData : D4Packet
	{
		// Token: 0x040064AF RID: 25775
		[FixedLen(3U)]
		public HirelingInfo[] HirelingInfos;

		// Token: 0x040064B0 RID: 25776
		[FixedLen(2U)]
		public int ActiveHireling = 0;

		// Token: 0x040064B1 RID: 25777
		public int AvailableHirelings = 2;
	}
}
