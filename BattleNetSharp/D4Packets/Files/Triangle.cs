using System;

namespace D4Packets.Files
{
	// Token: 0x0200083F RID: 2111
	public class Triangle : CASCPacket
	{
		// Token: 0x04006285 RID: 25221
		public int i1;

		// Token: 0x04006286 RID: 25222
		public int i2;

		// Token: 0x04006287 RID: 25223
		public int i3;

		// Token: 0x04006288 RID: 25224
		public int w1;

		// Token: 0x04006289 RID: 25225
		public int w2;

		// Token: 0x0400628A RID: 25226
		public int w3;

		// Token: 0x0400628B RID: 25227
		public ushort dwMaterialId;

		// Token: 0x0400628C RID: 25228
		public ushort dwGameFlags;

		// Token: 0x0400628D RID: 25229
		public ushort dwIncludeMask;

		// Token: 0x0400628E RID: 25230
		public ushort pad;
	}
}
