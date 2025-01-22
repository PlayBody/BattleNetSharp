using System;

namespace D2Packets.Game.Server
{
	// Token: 0x020009D6 RID: 2518
	public class NPCStop : Packet
	{
		// Token: 0x04008B02 RID: 35586
		public GameServerPacket PacketId;

		// Token: 0x04008B03 RID: 35587
		public uint Id;

		// Token: 0x04008B04 RID: 35588
		public ushort X;

		// Token: 0x04008B05 RID: 35589
		public ushort Y;

		// Token: 0x04008B06 RID: 35590
		public byte Life;
	}
}
