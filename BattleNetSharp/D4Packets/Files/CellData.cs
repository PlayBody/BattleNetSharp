using System;
using System.Collections.Generic;

namespace D4Packets.Files
{
	// Token: 0x0200085E RID: 2142
	public class CellData : CASCPacket
	{
		// Token: 0x0400632A RID: 25386
		public ulong m_cellId;

		// Token: 0x0400632B RID: 25387
		public ulong u1;

		// Token: 0x0400632C RID: 25388
		[FixedLen(4608U)]
		public List<ulong> u2;

		// Token: 0x0400632D RID: 25389
		[FixedLen(4608U)]
		public List<ulong> u3;

		// Token: 0x0400632E RID: 25390
		public ulong u4;

		// Token: 0x0400632F RID: 25391
		public uint u5;

		// Token: 0x04006330 RID: 25392
		public AABB aabb1;

		// Token: 0x04006331 RID: 25393
		public AABB aabb2;

		// Token: 0x04006332 RID: 25394
		public uint y6;
	}
}
