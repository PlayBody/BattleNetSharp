using System;
using System.Collections.Generic;

namespace D4Packets.Files
{
	// Token: 0x0200084E RID: 2126
	public class GeoChunk : CASCPacket
	{
		// Token: 0x040062F1 RID: 25329
		public AABB Bounds;

		// Token: 0x040062F2 RID: 25330
		public List<GeoSet> ptLODs;

		// Token: 0x040062F3 RID: 25331
		public List<uint> unk1;

		// Token: 0x040062F4 RID: 25332
		[FieldFlags(131072)]
		public List<ushort> unk2;

		// Token: 0x040062F5 RID: 25333
		public List<float> unk3;

		// Token: 0x040062F6 RID: 25334
		public uint ibid;

		// Token: 0x040062F7 RID: 25335
		public uint pad;
	}
}
