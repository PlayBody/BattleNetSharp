using System;
using System.Collections.Generic;

namespace D4Packets.Files
{
	// Token: 0x02000844 RID: 2116
	public class GeoSet : CASCPacket
	{
		// Token: 0x040062A2 RID: 25250
		public List<SubObject> ptSubObjects;

		// Token: 0x040062A3 RID: 25251
		public List<uint> uints;

		// Token: 0x040062A4 RID: 25252
		public uint unk1;

		// Token: 0x040062A5 RID: 25253
		public uint unk2;

		// Token: 0x040062A6 RID: 25254
		public float unk3;

		// Token: 0x040062A7 RID: 25255
		public uint pad;
	}
}
