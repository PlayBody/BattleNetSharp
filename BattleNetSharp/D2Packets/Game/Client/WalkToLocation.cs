using System;
using System.Collections.Generic;
using System.Linq;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A7F RID: 2687
	public class WalkToLocation : Packet
	{
		// Token: 0x04008F44 RID: 36676
		public GameClientPacket PacketId;

		// Token: 0x04008F45 RID: 36677
		public ushort X;

		// Token: 0x04008F46 RID: 36678
		public ushort Y;

		// Token: 0x04008F47 RID: 36679
		[MinVersion(GameVersion.D2R)]
		public ushort CurrentX;

		// Token: 0x04008F48 RID: 36680
		[MinVersion(GameVersion.D2R)]
		public ushort CurrentY;

		// Token: 0x04008F49 RID: 36681
		[MinVersion(GameVersion.D2R)]
		public byte ExtraPaths;

		// Token: 0x04008F4A RID: 36682
		[MinVersion(GameVersion.D2R)]
		public List<ushort> ExtraPath_100 = (from b in Enumerable.Range(0, 100)
			select 0).ToList<ushort>();
	}
}
