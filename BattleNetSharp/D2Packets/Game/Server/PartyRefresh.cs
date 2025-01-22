using System;

namespace D2Packets.Game.Server
{
	// Token: 0x020009DE RID: 2526
	public class PartyRefresh : Packet
	{
		// Token: 0x04008B24 RID: 35620
		public GameServerPacket PacketId;

		// Token: 0x04008B25 RID: 35621
		public uint Slot;

		// Token: 0x04008B26 RID: 35622
		public byte Alternator;

		// Token: 0x04008B27 RID: 35623
		public uint Count;
	}
}
