using System;

namespace D4Packets.Game.Client
{
	// Token: 0x0200089F RID: 2207
	public class HotbarButtonData : D4Packet
	{
		// Token: 0x040064AC RID: 25772
		public int SNOSkill = -1;

		// Token: 0x040064AD RID: 25773
		public int ItemGBId = -1;

		// Token: 0x040064AE RID: 25774
		public ulong DynamicID = ulong.MaxValue;
	}
}
