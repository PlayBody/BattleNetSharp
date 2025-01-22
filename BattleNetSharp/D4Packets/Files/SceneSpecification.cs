using System;
using System.Collections.Generic;

namespace D4Packets.Files
{
	// Token: 0x02000864 RID: 2148
	public class SceneSpecification : CASCPacket
	{
		// Token: 0x0400638C RID: 25484
		public uint dwFlags;

		// Token: 0x0400638D RID: 25485
		public uint snoLevelArea;

		// Token: 0x0400638E RID: 25486
		public uint field1;

		// Token: 0x0400638F RID: 25487
		public uint snoPrevWorld;

		// Token: 0x04006390 RID: 25488
		public uint uPrevEntranceGUID;

		// Token: 0x04006391 RID: 25489
		public uint snoPrevLevelArea;

		// Token: 0x04006392 RID: 25490
		public uint snoAudioContext;

		// Token: 0x04006393 RID: 25491
		public uint snoWeather;

		// Token: 0x04006394 RID: 25492
		public uint snoPresetWorld;

		// Token: 0x04006395 RID: 25493
		public uint nSceneChunk;

		// Token: 0x04006396 RID: 25494
		public List<S_Subzone> Subzones;
	}
}
