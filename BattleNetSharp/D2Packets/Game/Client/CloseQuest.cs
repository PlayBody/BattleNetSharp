using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A2E RID: 2606
	public class CloseQuest : Packet
	{
		// Token: 0x04008CC9 RID: 36041
		public GameClientPacket PacketId;

		// Token: 0x04008CCA RID: 36042
		public QuestType Quest;
	}
}
