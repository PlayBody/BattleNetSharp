using System;

namespace D2Packets.Game.Server
{
	// Token: 0x020009BC RID: 2492
	public class GoldTrade : Packet
	{
		// Token: 0x04008A32 RID: 35378
		public GameServerPacket PacketId;

		// Token: 0x04008A33 RID: 35379
		public byte MyGold;

		// Token: 0x04008A34 RID: 35380
		public uint Amount;
	}
}
