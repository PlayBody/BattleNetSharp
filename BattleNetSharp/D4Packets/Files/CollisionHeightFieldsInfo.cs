using System;

namespace D4Packets.Files
{
	// Token: 0x02000847 RID: 2119
	public class CollisionHeightFieldsInfo : CASCPacket
	{
		// Token: 0x040062CB RID: 25291
		public uint countX;

		// Token: 0x040062CC RID: 25292
		public uint countY;

		// Token: 0x040062CD RID: 25293
		public float cellWidth;

		// Token: 0x040062CE RID: 25294
		public uint pad;

		// Token: 0x040062CF RID: 25295
		public ulong aSamples;

		// Token: 0x040062D0 RID: 25296
		public float center;

		// Token: 0x040062D1 RID: 25297
		public float scale;
	}
}
