using System;

namespace D4Packets.Files
{
	// Token: 0x0200083E RID: 2110
	public class Node : CASCPacket
	{
		// Token: 0x0400627B RID: 25211
		public float nLowerX;

		// Token: 0x0400627C RID: 25212
		public float nLowerY;

		// Token: 0x0400627D RID: 25213
		public float nLowerZ;

		// Token: 0x0400627E RID: 25214
		public float nUpperX;

		// Token: 0x0400627F RID: 25215
		public float nUpperY;

		// Token: 0x04006280 RID: 25216
		public float nUpperZ;

		// Token: 0x04006281 RID: 25217
		public uint nIndex;

		// Token: 0x04006282 RID: 25218
		public ushort dwIncludeMask;

		// Token: 0x04006283 RID: 25219
		public byte dwAxis;

		// Token: 0x04006284 RID: 25220
		public byte dwTriangleCount;
	}
}
