using System;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A69 RID: 2665
	public class SwapBeltItem : Packet
	{
		// Token: 0x04008EAF RID: 36527
		public GameClientPacket PacketId;

		// Token: 0x04008EB0 RID: 36528
		public uint OldId;

		// Token: 0x04008EB1 RID: 36529
		public uint NewId;

		// Token: 0x04008EB2 RID: 36530
		[MinVersion(GameVersion.D2R)]
		public uint BeltPos;
	}
}
