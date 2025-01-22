using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009D1 RID: 2513
	public class NPCHeal : Packet
	{
		// Token: 0x04008AD1 RID: 35537
		public GameServerPacket PacketId;

		// Token: 0x04008AD2 RID: 35538
		public UnitType Type;

		// Token: 0x04008AD3 RID: 35539
		public uint Id;

		// Token: 0x04008AD4 RID: 35540
		public byte Life;
	}
}
