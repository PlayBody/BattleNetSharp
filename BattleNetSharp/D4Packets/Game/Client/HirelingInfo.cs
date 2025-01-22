using System;

namespace D4Packets.Game.Client
{
	// Token: 0x020008A1 RID: 2209
	public class HirelingInfo : D4Packet
	{
		// Token: 0x040064B2 RID: 25778
		[FixedLen(2U)]
		public int HirelingIndex = 0;

		// Token: 0x040064B3 RID: 25779
		public int GbidName = -1;

		// Token: 0x040064B4 RID: 25780
		public bool Dead = false;

		// Token: 0x040064B5 RID: 25781
		public int Skill1SNOId = -1;

		// Token: 0x040064B6 RID: 25782
		public int Skill2SNOId = -1;

		// Token: 0x040064B7 RID: 25783
		public int Skill3SNOId = -1;

		// Token: 0x040064B8 RID: 25784
		public int Skill4SNOId = -1;

		// Token: 0x040064B9 RID: 25785
		public int annItems = -1;
	}
}
