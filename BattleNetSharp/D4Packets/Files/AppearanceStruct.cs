using System;
using System.Collections.Generic;

namespace D4Packets.Files
{
	// Token: 0x0200084F RID: 2127
	public class AppearanceStruct : CASCPacket
	{
		// Token: 0x040062F8 RID: 25336
		[FieldFlags(131072)]
		public List<CollisionMesh> ptCollisionMeshes;

		// Token: 0x040062F9 RID: 25337
		public List<uint> ptCollisionCapsules;

		// Token: 0x040062FA RID: 25338
		public List<GeoChunk> ptChunks;

		// Token: 0x040062FB RID: 25339
		public List<SceneData> ptSceneData;

		// Token: 0x040062FC RID: 25340
		public List<uint> ptBoneData;

		// Token: 0x040062FD RID: 25341
		public uint dwFlags;

		// Token: 0x040062FE RID: 25342
		public float unk;

		// Token: 0x040062FF RID: 25343
		public Sphere wsBounds;

		// Token: 0x04006300 RID: 25344
		public AABB aabbBounds;

		// Token: 0x04006301 RID: 25345
		public uint unk2;

		// Token: 0x04006302 RID: 25346
		public ulong ptPostprocessed;
	}
}
