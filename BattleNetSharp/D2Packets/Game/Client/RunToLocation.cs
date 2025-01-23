using System;
using System.Collections.Generic;
using System.Linq;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A5A RID: 2650
	public class RunToLocation : Packet
	{
		// Token: 0x04008E5D RID: 36445
		public GameClientPacket PacketId;

		// Token: 0x04008E5E RID: 36446
		public ushort X;

		// Token: 0x04008E5F RID: 36447
		public ushort Y;

		// Token: 0x04008E60 RID: 36448
		[MinVersion(GameVersion.D2R)]
		public ushort CurrentX;

		// Token: 0x04008E61 RID: 36449
		[MinVersion(GameVersion.D2R)]
		public ushort CurrentY;

		// Token: 0x04008E62 RID: 36450
		[MinVersion(GameVersion.D2R)]
		public byte ExtraPaths;

		// Token: 0x04008E63 RID: 36451
		[MinVersion(GameVersion.D2R)]
		public List<ushort> ExtraPath_100 = (from b in Enumerable.Range(0, 100)
			select (ushort)0).ToList<ushort>();
	}
}
