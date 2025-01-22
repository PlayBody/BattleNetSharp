using System;

namespace D2Packets.Game.Server
{
	// Token: 0x020009C9 RID: 2505
	public class MercCost : Packet
	{
		// Token: 0x04008AAC RID: 35500
		public GameServerPacket PacketId;

		// Token: 0x04008AAD RID: 35501
		public ushort NameId;

		// Token: 0x04008AAE RID: 35502
		public uint ReviveCost;
	}
}
