using System;

namespace D2Packets.Game.Server
{
	// Token: 0x02000A08 RID: 2568
	public class TimestampResponse : Packet
	{
		// Token: 0x04008C0B RID: 35851
		public GameServerPacket PacketId;

		// Token: 0x04008C0C RID: 35852
		public uint TickCount;
	}
}
