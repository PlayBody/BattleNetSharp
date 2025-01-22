using System;
using System.Collections.Generic;

namespace D4Packets.Files
{
	// Token: 0x02000860 RID: 2144
	public class Scene : CASCPacket
	{
		// Token: 0x0400633B RID: 25403
		public Header Header;

		// Token: 0x0400633C RID: 25404
		public uint dwFlags;

		// Token: 0x0400633D RID: 25405
		public AABB aabbBounds;

		// Token: 0x0400633E RID: 25406
		public AABB markerSetBounds;

		// Token: 0x0400633F RID: 25407
		public float flGridSize;

		// Token: 0x04006340 RID: 25408
		public List<uint> arLayers;

		// Token: 0x04006341 RID: 25409
		public ulong tLookLink;

		// Token: 0x04006342 RID: 25410
		public List<unk> unk;

		// Token: 0x04006343 RID: 25411
		public uint snoAppearance;

		// Token: 0x04006344 RID: 25412
		public uint snoAudioContext;

		// Token: 0x04006345 RID: 25413
		public float flTileX;

		// Token: 0x04006346 RID: 25414
		public float flTileY;

		// Token: 0x04006347 RID: 25415
		[FieldFlags(131072)]
		public List<AIPathData> ptAIPathData;

		// Token: 0x04006348 RID: 25416
		public LevelAreaGrid tLevelAreaGrid;

		// Token: 0x04006349 RID: 25417
		public ulong eDRLGTileType;

		// Token: 0x0400634A RID: 25418
		public LevelAreaGrid tLevelAreaGrid2;

		// Token: 0x0400634B RID: 25419
		[FieldFlags(131072)]
		public FogMask tFogMask;
	}
}
