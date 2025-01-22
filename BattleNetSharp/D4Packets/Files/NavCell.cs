using System;

namespace D4Packets.Files
{
	// Token: 0x02000861 RID: 2145
	public class NavCell : CASCPacket
	{
		// Token: 0x0400634C RID: 25420
		public AABB grid;

		// Token: 0x0400634D RID: 25421
		public ushort flags;

		// Token: 0x0400634E RID: 25422
		public ushort count;

		// Token: 0x0400634F RID: 25423
		public uint idx;
	}
}
