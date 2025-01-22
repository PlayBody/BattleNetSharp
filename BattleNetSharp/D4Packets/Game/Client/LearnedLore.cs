using System;

namespace D4Packets.Game.Client
{
	// Token: 0x020008A2 RID: 2210
	public class LearnedLore : D4Packet
	{
		// Token: 0x040064BA RID: 25786
		public int Count;

		// Token: 0x040064BB RID: 25787
		[FixedLen(512U)]
		public int[] m_snoLoreLearned;
	}
}
