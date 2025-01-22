using System;
using System.Collections.Generic;

namespace D4Packets.Files
{
	// Token: 0x0200084C RID: 2124
	public class SurfaceGrid : CASCPacket
	{
		// Token: 0x040062E7 RID: 25319
		public List<ushort> grid;

		// Token: 0x040062E8 RID: 25320
		public List<uint> arPrimitives;

		// Token: 0x040062E9 RID: 25321
		public AABB aabbBounds;

		// Token: 0x040062EA RID: 25322
		public uint dwRows;

		// Token: 0x040062EB RID: 25323
		public uint dwColumns;
	}
}
