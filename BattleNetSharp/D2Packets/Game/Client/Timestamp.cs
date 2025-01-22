using System;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A71 RID: 2673
	public class Timestamp : Packet
	{
		// Token: 0x04008EF0 RID: 36592
		public GameClientPacket PacketId;

		// Token: 0x04008EF1 RID: 36593
		public uint TickCount;

		// Token: 0x04008EF2 RID: 36594
		[MaxVersion(GameVersion.LOD)]
		public ulong PreviousPing;
	}
}
