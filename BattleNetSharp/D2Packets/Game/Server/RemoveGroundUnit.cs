using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009FA RID: 2554
	public class RemoveGroundUnit : Packet
	{
		// Token: 0x04008BCA RID: 35786
		public GameServerPacket PacketId;

		// Token: 0x04008BCB RID: 35787
		public UnitType Type;

		// Token: 0x04008BCC RID: 35788
		public uint Id;
	}
}
