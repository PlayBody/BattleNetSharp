using System;

namespace D4Packets.Game.Client
{
	// Token: 0x02000891 RID: 2193
	[D4Packet.OpcodeAttribute(Opcodes.SMSG_LIMBO_WARP_PREFETCH_BEGIN)]
	public class LimboWarpPrefetchBegin : D4Packet
	{
		// Token: 0x04006457 RID: 25687
		public int WorldSNO;

		// Token: 0x04006458 RID: 25688
		public Vector3D Position;

		// Token: 0x04006459 RID: 25689
		public int dwPortalType;

		// Token: 0x0400645A RID: 25690
		public bool som;
	}
}
