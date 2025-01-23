using System;
using System.Collections.Generic;
using System.Linq;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A4D RID: 2637
	public class RecastLeftSkill : Packet
	{
		// Token: 0x04008E1B RID: 36379
		public GameClientPacket PacketId;

		// Token: 0x04008E1C RID: 36380
		public ushort X;

		// Token: 0x04008E1D RID: 36381
		public ushort Y;

		// Token: 0x04008E1E RID: 36382
		[MinVersion(GameVersion.D2R)]
		public ushort CurrentX;

		// Token: 0x04008E1F RID: 36383
		[MinVersion(GameVersion.D2R)]
		public ushort CurrentY;

		// Token: 0x04008E20 RID: 36384
		[MinVersion(GameVersion.D2R)]
		public byte ExtraPaths;

		// Token: 0x04008E21 RID: 36385
		[MinVersion(GameVersion.D2R)]
		public List<ushort> ExtraPath_100 = (from b in Enumerable.Range(0, 100)
			select (ushort)0).ToList<ushort>();
	}
}
