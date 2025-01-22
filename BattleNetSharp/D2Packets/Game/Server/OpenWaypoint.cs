using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009DA RID: 2522
	public class OpenWaypoint : Packet
	{
		// Token: 0x04008B14 RID: 35604
		public GameServerPacket PacketId;

		// Token: 0x04008B15 RID: 35605
		[MaxVersion(GameVersion.LOD)]
		public uint WaypointId;

		// Token: 0x04008B16 RID: 35606
		public ushort OneOhTwo;

		// Token: 0x04008B17 RID: 35607
		public WaypointsAvailable WaypointsUnlocked;

		// Token: 0x04008B18 RID: 35608
		public uint unk1;

		// Token: 0x04008B19 RID: 35609
		public ushort unk2;
	}
}
