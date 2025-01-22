using System;
using System.Collections.Generic;

namespace D4Packets.Files
{
	// Token: 0x02000846 RID: 2118
	public class SubObject : CASCPacket
	{
		// Token: 0x040062B2 RID: 25266
		public uint dwFlags;

		// Token: 0x040062B3 RID: 25267
		public uint unk1;

		// Token: 0x040062B4 RID: 25268
		public List<uint> ptClothData;

		// Token: 0x040062B5 RID: 25269
		public List<uint> unkints;

		// Token: 0x040062B6 RID: 25270
		public uint dwBAOffset;

		// Token: 0x040062B7 RID: 25271
		public uint dwBAOffsetu1;

		// Token: 0x040062B8 RID: 25272
		public uint dwBAOffsetu2;

		// Token: 0x040062B9 RID: 25273
		public uint dwBASize;

		// Token: 0x040062BA RID: 25274
		public NameInfo tNameInfo;

		// Token: 0x040062BB RID: 25275
		public uint nMaterialIndex;

		// Token: 0x040062BC RID: 25276
		public uint dwSubObjectHash;

		// Token: 0x040062BD RID: 25277
		public uint unk2;

		// Token: 0x040062BE RID: 25278
		public uint unk3;

		// Token: 0x040062BF RID: 25279
		public uint unk4;

		// Token: 0x040062C0 RID: 25280
		public uint unk5;

		// Token: 0x040062C1 RID: 25281
		public uint unk6;

		// Token: 0x040062C2 RID: 25282
		public uint unk7;

		// Token: 0x040062C3 RID: 25283
		public uint unksno51;

		// Token: 0x040062C4 RID: 25284
		public AABB aabbBounds;

		// Token: 0x040062C5 RID: 25285
		public List<uint> ptShapes;

		// Token: 0x040062C6 RID: 25286
		public List<uint> unkbytes;

		// Token: 0x040062C7 RID: 25287
		public ulong ptPostprocessed;

		// Token: 0x040062C8 RID: 25288
		public List<uint> ptSegments;

		// Token: 0x040062C9 RID: 25289
		public Vector3D wpFixedPointPosOffset;

		// Token: 0x040062CA RID: 25290
		public Vector3D wpFixedPointPosScale;
	}
}
