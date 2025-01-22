using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009E0 RID: 2528
	public class PlayerClearCursor : Packet
	{
		// Token: 0x04008B2D RID: 35629
		public GameServerPacket PacketId;

		// Token: 0x04008B2E RID: 35630
		public UnitType Type;

		// Token: 0x04008B2F RID: 35631
		public uint Id;
	}
}
