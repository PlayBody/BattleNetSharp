using System;
using System.Collections.Generic;

namespace D2Packets.Game.Server
{
	// Token: 0x02000A1B RID: 2587
	public class UpdateQuestStatus : Packet
	{
		// Token: 0x04008C71 RID: 35953
		public GameServerPacket PacketId;

		// Token: 0x04008C72 RID: 35954
		public List<byte> Quests_37;
	}
}
