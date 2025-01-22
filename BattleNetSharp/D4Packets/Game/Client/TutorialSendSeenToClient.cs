using System;

namespace D4Packets.Game.Client
{
	// Token: 0x020008B3 RID: 2227
	public class TutorialSendSeenToClient : D4Packet
	{
		// Token: 0x040064FE RID: 25854
		public int ENUM;

		// Token: 0x040064FF RID: 25855
		[DynamicLen(8)]
		public int[] Array;
	}
}
