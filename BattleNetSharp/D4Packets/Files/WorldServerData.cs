using System;
using System.Collections.Generic;

namespace D4Packets.Files
{
	// Token: 0x02000866 RID: 2150
	public class WorldServerData : CASCPacket
	{
		// Token: 0x0400639A RID: 25498
		public List<SceneChunk> ptSceneChunks;

		// Token: 0x0400639B RID: 25499
		public uint snoScript;

		// Token: 0x0400639C RID: 25500
		public uint nSeed;

		// Token: 0x0400639D RID: 25501
		public uint pad;

		// Token: 0x0400639E RID: 25502
		public float flMinX;

		// Token: 0x0400639F RID: 25503
		public float flMinY;

		// Token: 0x040063A0 RID: 25504
		public float flMaxX;

		// Token: 0x040063A1 RID: 25505
		public float flMaxY;

		// Token: 0x040063A2 RID: 25506
		public List<uint> arWeatherSNOs;

		// Token: 0x040063A3 RID: 25507
		public List<uint> arSubzones;
	}
}
