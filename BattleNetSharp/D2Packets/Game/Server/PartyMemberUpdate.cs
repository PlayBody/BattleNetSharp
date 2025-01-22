using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009DD RID: 2525
	public class PartyMemberUpdate : Packet
	{
		// Token: 0x04008B1E RID: 35614
		public GameServerPacket PacketId;

		// Token: 0x04008B1F RID: 35615
		public byte IsPlayer;

		// Token: 0x04008B20 RID: 35616
		public ushort Life;

		// Token: 0x04008B21 RID: 35617
		public uint Id;

		// Token: 0x04008B22 RID: 35618
		public AreaLevel Area;

		// Token: 0x04008B23 RID: 35619
		public byte unk;
	}
}
