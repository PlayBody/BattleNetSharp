using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009E3 RID: 2531
	public class PlayerInSight : Packet
	{
		// Token: 0x04008B4A RID: 35658
		public GameServerPacket PacketId;

		// Token: 0x04008B4B RID: 35659
		public UnitType Type;

		// Token: 0x04008B4C RID: 35660
		public uint Id;
	}
}
