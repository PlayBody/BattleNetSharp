using System;
using System.Collections.Generic;

namespace D4Packets.Files
{
	// Token: 0x02000842 RID: 2114
	public class CollisionMesh : CASCPacket
	{
		// Token: 0x04006299 RID: 25241
		public Mesh Mesh;

		// Token: 0x0400629A RID: 25242
		public List<Vertice> ptDominoVertices;

		// Token: 0x0400629B RID: 25243
		public List<Triangle> ptDominoTriangles;

		// Token: 0x0400629C RID: 25244
		public List<Node> ptDominoNodes;

		// Token: 0x0400629D RID: 25245
		public uint unk1;

		// Token: 0x0400629E RID: 25246
		public uint uFlags;

		// Token: 0x0400629F RID: 25247
		public uint uMaterial;

		// Token: 0x040062A0 RID: 25248
		public uint uGroupIndex;

		// Token: 0x040062A1 RID: 25249
		public List<int> ints;
	}
}
