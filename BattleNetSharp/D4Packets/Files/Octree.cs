using System;
using System.Collections.Generic;

namespace D4Packets.Files
{
	// Token: 0x0200084B RID: 2123
	public class Octree : CASCPacket
	{
		// Token: 0x040062DD RID: 25309
		public uint nMaxNodes;

		// Token: 0x040062DE RID: 25310
		public uint nMaxLeaves;

		// Token: 0x040062DF RID: 25311
		public uint nMaxPrimitives;

		// Token: 0x040062E0 RID: 25312
		public uint nNodeCount;

		// Token: 0x040062E1 RID: 25313
		public uint nLeafCount;

		// Token: 0x040062E2 RID: 25314
		public uint nPrimitiveCount;

		// Token: 0x040062E3 RID: 25315
		public OctreeCube OctreeCube;

		// Token: 0x040062E4 RID: 25316
		public List<uint> ptNodes;

		// Token: 0x040062E5 RID: 25317
		public List<uint> ptLeaves;

		// Token: 0x040062E6 RID: 25318
		public List<uint> ptPrimitives;
	}
}
