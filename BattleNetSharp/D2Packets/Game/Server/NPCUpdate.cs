using System;

namespace D2Packets.Game.Server
{
	// Token: 0x020009D7 RID: 2519
	public class NPCUpdate : Packet
	{
		// Token: 0x04008B07 RID: 35591
		public GameServerPacket PacketId;

		// Token: 0x04008B08 RID: 35592
		public uint Id;

		// Token: 0x04008B09 RID: 35593
		public uint Id2;

		// Token: 0x04008B0A RID: 35594
		public byte Life1;

		// Token: 0x04008B0B RID: 35595
		public byte Life2;

		// Token: 0x04008B0C RID: 35596
		public byte Life3;
	}
}
