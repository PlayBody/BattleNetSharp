using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009B3 RID: 2483
	public class GameHandshake : Packet
	{
		// Token: 0x04008992 RID: 35218
		public GameServerPacket PacketId;

		// Token: 0x04008993 RID: 35219
		public UnitType Type;

		// Token: 0x04008994 RID: 35220
		public uint Id;
	}
}
