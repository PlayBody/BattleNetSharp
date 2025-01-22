using System;

namespace D4Packets.Files
{
	// Token: 0x02000840 RID: 2112
	public class Mesh : CASCPacket
	{
		// Token: 0x0400628F RID: 25231
		public ulong aNodes;

		// Token: 0x04006290 RID: 25232
		public ulong aVertices;

		// Token: 0x04006291 RID: 25233
		public ulong aTriangles;

		// Token: 0x04006292 RID: 25234
		public uint nNodeCount;

		// Token: 0x04006293 RID: 25235
		public uint nVertexCount;

		// Token: 0x04006294 RID: 25236
		public uint nTriangleCount;

		// Token: 0x04006295 RID: 25237
		public uint height;

		// Token: 0x04006296 RID: 25238
		public float unk1;

		// Token: 0x04006297 RID: 25239
		public uint unk2;
	}
}
