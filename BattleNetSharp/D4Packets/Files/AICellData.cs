using System;

namespace D4Packets.Files
{
	// Token: 0x0200085C RID: 2140
	public class AICellData : CASCPacket
	{
		// Token: 0x04006323 RID: 25379
		public AABB aabb1;

		// Token: 0x04006324 RID: 25380
		public AABB aabb2;

		// Token: 0x04006325 RID: 25381
		public uint m_cellIdx;

		// Token: 0x04006326 RID: 25382
		public uint pad1;

		// Token: 0x04006327 RID: 25383
		public ulong m_cellId;

		// Token: 0x04006328 RID: 25384
		public ulong u3;
	}
}
