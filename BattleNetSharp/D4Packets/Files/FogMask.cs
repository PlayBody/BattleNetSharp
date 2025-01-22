using System;
using System.Collections.Generic;

namespace D4Packets.Files
{
	// Token: 0x0200085B RID: 2139
	public class FogMask : CASCPacket
	{
		// Token: 0x04006320 RID: 25376
		public uint dwWidth;

		// Token: 0x04006321 RID: 25377
		public uint dwHeight;

		// Token: 0x04006322 RID: 25378
		public List<byte> arMask;
	}
}
