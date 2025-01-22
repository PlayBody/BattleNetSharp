using System;

namespace D4Packets.Game.Client
{
	// Token: 0x020008A9 RID: 2217
	public class PSD_90DE2B1E : D4Packet
	{
		// Token: 0x040064C7 RID: 25799
		public bool field0 = false;

		// Token: 0x040064C8 RID: 25800
		[DynamicLen(4)]
		public PSD_FB1F3D4D[] Massive;
	}
}
