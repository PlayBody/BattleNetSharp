using System;
using System.Collections.Generic;
using System.Linq;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A50 RID: 2640
	public class RecastRightSkill : Packet
	{
		// Token: 0x04008E2E RID: 36398
		public GameClientPacket PacketId;

		// Token: 0x04008E2F RID: 36399
		public ushort X;

		// Token: 0x04008E30 RID: 36400
		public ushort Y;

		// Token: 0x04008E31 RID: 36401
		[MinVersion(GameVersion.D2R)]
		public ushort CurrentX;

		// Token: 0x04008E32 RID: 36402
		[MinVersion(GameVersion.D2R)]
		public ushort CurrentY;

		// Token: 0x04008E33 RID: 36403
		[MinVersion(GameVersion.D2R)]
		public byte ExtraPaths;

		// Token: 0x04008E34 RID: 36404
		[MinVersion(GameVersion.D2R)]
		public List<ushort> ExtraPath_100 = (from b in Enumerable.Range(0, 100)
			select 0).ToList<ushort>();
	}
}
