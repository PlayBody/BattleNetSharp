using System;

namespace D2Packets.Game.Server
{
	// Token: 0x020009FB RID: 2555
	public class RemoveItemsDisplay : Packet
	{
		// Token: 0x04008BCD RID: 35789
		public GameServerPacket PacketId;

		// Token: 0x04008BCE RID: 35790
		public byte one;

		// Token: 0x04008BCF RID: 35791
		public uint Id;
	}
}
