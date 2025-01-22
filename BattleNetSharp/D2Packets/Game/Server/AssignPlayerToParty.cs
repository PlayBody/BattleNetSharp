using System;

namespace D2Packets.Game.Server
{
	// Token: 0x0200099F RID: 2463
	public class AssignPlayerToParty : Packet
	{
		// Token: 0x04008940 RID: 35136
		public GameServerPacket PacketId;

		// Token: 0x04008941 RID: 35137
		public uint Id;

		// Token: 0x04008942 RID: 35138
		public ushort PartyNumber;
	}
}
