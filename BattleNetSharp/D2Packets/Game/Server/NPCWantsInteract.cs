using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009D8 RID: 2520
	public class NPCWantsInteract : Packet
	{
		// Token: 0x04008B0D RID: 35597
		public GameServerPacket PacketId;

		// Token: 0x04008B0E RID: 35598
		public UnitType Type;

		// Token: 0x04008B0F RID: 35599
		public uint Id;
	}
}
