using System;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A4B RID: 2635
	public class Ping : Packet
	{
		// Token: 0x04008E13 RID: 36371
		public GameClientPacket PacketId;

		// Token: 0x04008E14 RID: 36372
		public uint TickCount;

		// Token: 0x04008E15 RID: 36373
		public ulong PreviousPing;
	}
}
