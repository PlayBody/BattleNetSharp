using System;
using System.Collections.Generic;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x02000A16 RID: 2582
	public class UpdateGameQuestLog : Packet
	{
		// Token: 0x04008C56 RID: 35926
		public GameServerPacket PacketId;

		// Token: 0x04008C57 RID: 35927
		public List<UpdateGameQuestLog.QuestState> Quests_41;

		// Token: 0x04008C58 RID: 35928
		public ulong unk1;

		// Token: 0x04008C59 RID: 35929
		public uint unk2;

		// Token: 0x04008C5A RID: 35930
		public ushort unk3;

		// Token: 0x0200135E RID: 4958
		public class QuestState : Packet
		{
			// Token: 0x04009E6B RID: 40555
			public GameQuestState State;
		}
	}
}
