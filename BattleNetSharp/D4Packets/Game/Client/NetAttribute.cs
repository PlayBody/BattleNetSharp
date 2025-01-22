using System;
using D4Data;

namespace D4Packets.Game.Client
{
	// Token: 0x02000888 RID: 2184
	public class NetAttribute : D4Packet
	{
		// Token: 0x04006443 RID: 25667
		public int? KeyParam;

		// Token: 0x04006444 RID: 25668
		public GameAttribute Attribute;

		// Token: 0x04006445 RID: 25669
		public float Float;

		// Token: 0x04006446 RID: 25670
		public int Int;
	}
}
