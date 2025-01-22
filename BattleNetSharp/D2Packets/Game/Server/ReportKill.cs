using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009FC RID: 2556
	public class ReportKill : Packet
	{
		// Token: 0x04008BD0 RID: 35792
		public GameServerPacket PacketId;

		// Token: 0x04008BD1 RID: 35793
		public UnitType Type;

		// Token: 0x04008BD2 RID: 35794
		public uint Id;

		// Token: 0x04008BD3 RID: 35795
		public ushort unk;
	}
}
