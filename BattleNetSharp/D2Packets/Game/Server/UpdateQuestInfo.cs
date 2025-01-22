using System;
using System.Collections.Generic;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x02000A19 RID: 2585
	public class UpdateQuestInfo : Packet
	{
		// Token: 0x04008C66 RID: 35942
		public GameServerPacket PacketId;

		// Token: 0x04008C67 RID: 35943
		public UpdateQuestInfo.QuestInfoUpdateType Type;

		// Token: 0x04008C68 RID: 35944
		public uint Id;

		// Token: 0x04008C69 RID: 35945
		public List<UpdateQuestInfo.QuestInfo> Quests_42;

		// Token: 0x04008C6A RID: 35946
		public uint unk1a;

		// Token: 0x04008C6B RID: 35947
		public ushort unk1b;

		// Token: 0x04008C6C RID: 35948
		public uint unk2;

		// Token: 0x04008C6D RID: 35949
		public ushort unk3;

		// Token: 0x04008C6E RID: 35950
		public byte unk4;

		// Token: 0x0200135F RID: 4959
		public enum QuestInfoUpdateType : byte
		{
			// Token: 0x04009E6D RID: 40557
			NPCInteract = 1,
			// Token: 0x04009E6E RID: 40558
			QuestLog = 6
		}

		// Token: 0x02001360 RID: 4960
		public class QuestInfo : Packet
		{
			// Token: 0x04009E6F RID: 40559
			public QuestState State;

			// Token: 0x04009E70 RID: 40560
			public QuestStanding Standing;
		}
	}
}
