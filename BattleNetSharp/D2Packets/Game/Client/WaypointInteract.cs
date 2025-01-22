using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A83 RID: 2691
	public class WaypointInteract : Packet
	{
		// Token: 0x04008F5A RID: 36698
		public GameClientPacket PacketId;

		// Token: 0x04008F5B RID: 36699
		public AreaLevel Destination;

		// Token: 0x04008F5C RID: 36700
		public ushort pad0;

		// Token: 0x04008F5D RID: 36701
		public byte pad1;
	}
}
