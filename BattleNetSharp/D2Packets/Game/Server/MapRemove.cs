using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009C4 RID: 2500
	public class MapRemove : Packet
	{
		// Token: 0x04008A92 RID: 35474
		public GameServerPacket PacketId;

		// Token: 0x04008A93 RID: 35475
		public ushort X;

		// Token: 0x04008A94 RID: 35476
		public ushort Y;

		// Token: 0x04008A95 RID: 35477
		public AreaLevel Area;
	}
}
