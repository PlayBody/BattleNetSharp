using System;

namespace D2Packets.Game.Server
{
	// Token: 0x020009DC RID: 2524
	public class PartyMemberPulse : Packet
	{
		// Token: 0x04008B1A RID: 35610
		public GameServerPacket PacketId;

		// Token: 0x04008B1B RID: 35611
		public uint Id;

		// Token: 0x04008B1C RID: 35612
		public uint X;

		// Token: 0x04008B1D RID: 35613
		public uint Y;
	}
}
