using System;

namespace D2Packets.Game.Server
{
	// Token: 0x020009D3 RID: 2515
	public class NPCIntro : Packet
	{
		// Token: 0x04008ADD RID: 35549
		public GameServerPacket PacketId;

		// Token: 0x04008ADE RID: 35550
		public byte Act;

		// Token: 0x04008ADF RID: 35551
		public ushort StringIndex;

		// Token: 0x04008AE0 RID: 35552
		public ushort unk1a;

		// Token: 0x04008AE1 RID: 35553
		public uint unk1b;

		// Token: 0x04008AE2 RID: 35554
		public ulong unk2;

		// Token: 0x04008AE3 RID: 35555
		public ulong unk3;
	}
}
