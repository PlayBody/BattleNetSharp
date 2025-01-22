using System;

namespace D2Packets.Game.Server
{
	// Token: 0x02000A0C RID: 2572
	public class UniqueEvents : Packet
	{
		// Token: 0x04008C29 RID: 35881
		public GameServerPacket PacketId;

		// Token: 0x04008C2A RID: 35882
		public UniqueEvents.UniqueEvent Event;

		// Token: 0x0200135D RID: 4957
		public enum UniqueEvent : byte
		{
			// Token: 0x04009E62 RID: 40546
			DenClear,
			// Token: 0x04009E63 RID: 40547
			TristramPortal,
			// Token: 0x04009E64 RID: 40548
			DurielStaff = 3,
			// Token: 0x04009E65 RID: 40549
			ClawViperAmmy = 6,
			// Token: 0x04009E66 RID: 40550
			SummonerDied,
			// Token: 0x04009E67 RID: 40551
			DurielDied,
			// Token: 0x04009E68 RID: 40552
			MephistoDied = 11,
			// Token: 0x04009E69 RID: 40553
			DiabloReleased,
			// Token: 0x04009E6A RID: 40554
			DiableDied
		}
	}
}
