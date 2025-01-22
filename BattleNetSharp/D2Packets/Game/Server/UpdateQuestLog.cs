using System;
using System.Collections.Generic;

namespace D2Packets.Game.Server
{
	// Token: 0x02000A1A RID: 2586
	public class UpdateQuestLog : Packet
	{
		// Token: 0x04008C6F RID: 35951
		public GameServerPacket PacketId;

		// Token: 0x04008C70 RID: 35952
		public List<byte> Quests_41;
	}
}
