using System;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A34 RID: 2612
	public class EmbedItem : Packet
	{
		// Token: 0x04008CE0 RID: 36064
		public GameClientPacket PacketId;

		// Token: 0x04008CE1 RID: 36065
		public uint SubjectId;

		// Token: 0x04008CE2 RID: 36066
		public uint ObjectId;
	}
}
