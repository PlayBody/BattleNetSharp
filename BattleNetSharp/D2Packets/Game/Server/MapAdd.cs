using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009C3 RID: 2499
	public class MapAdd : Packet
	{
		// Token: 0x04008A8E RID: 35470
		public GameServerPacket PacketId;

		// Token: 0x04008A8F RID: 35471
		public ushort X;

		// Token: 0x04008A90 RID: 35472
		public ushort Y;

		// Token: 0x04008A91 RID: 35473
		public AreaLevel Area;
	}
}
