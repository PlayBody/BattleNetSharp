using System;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A30 RID: 2608
	public class DropGold : Packet
	{
		// Token: 0x04008CD0 RID: 36048
		public GameClientPacket PacketId;

		// Token: 0x04008CD1 RID: 36049
		public uint Id;

		// Token: 0x04008CD2 RID: 36050
		public uint Amount;
	}
}
