using System;

namespace D2Packets.Game.Server
{
	// Token: 0x020009CA RID: 2506
	public class MercForHire : Packet
	{
		// Token: 0x04008AAF RID: 35503
		public GameServerPacket PacketId;

		// Token: 0x04008AB0 RID: 35504
		public ushort Id;

		// Token: 0x04008AB1 RID: 35505
		public uint Seed;
	}
}
