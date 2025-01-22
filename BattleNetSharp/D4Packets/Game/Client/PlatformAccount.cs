using System;

namespace D4Packets.Game.Client
{
	// Token: 0x02000896 RID: 2198
	public class PlatformAccount : D4Packet
	{
		// Token: 0x04006477 RID: 25719
		public ulong ID;

		// Token: 0x04006478 RID: 25720
		[FixedLen(3U)]
		public int unk;
	}
}
