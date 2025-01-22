using System;
using System.Collections.Generic;

namespace D4Packets.Files
{
	// Token: 0x0200084D RID: 2125
	public class SceneData : CASCPacket
	{
		// Token: 0x040062EC RID: 25324
		[FieldFlags(131072)]
		public List<CollisionHeightFields> ptCollisionHeightFields;

		// Token: 0x040062ED RID: 25325
		public ulong unk1;

		// Token: 0x040062EE RID: 25326
		[FieldFlags(131072)]
		public List<Octree> octree;

		// Token: 0x040062EF RID: 25327
		[FieldFlags(131072)]
		public List<SurfaceGrid> ptSurfaceGrid;

		// Token: 0x040062F0 RID: 25328
		[FieldFlags(131072)]
		public List<uint> ptFoliageGrid;
	}
}
