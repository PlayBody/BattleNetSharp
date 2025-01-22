using System;
using System.Collections.Generic;
using System.Linq;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A5B RID: 2651
	public class RunToTarget : Packet
	{
		// Token: 0x04008E64 RID: 36452
		public GameClientPacket PacketId;

		// Token: 0x04008E65 RID: 36453
		public UnitType Type;

		// Token: 0x04008E66 RID: 36454
		public byte unk1 = 0;

		// Token: 0x04008E67 RID: 36455
		public byte unk2 = 0;

		// Token: 0x04008E68 RID: 36456
		public byte unk3 = 0;

		// Token: 0x04008E69 RID: 36457
		public uint Id;

		// Token: 0x04008E6A RID: 36458
		[MinVersion(GameVersion.D2R)]
		public ushort CurrentX;

		// Token: 0x04008E6B RID: 36459
		[MinVersion(GameVersion.D2R)]
		public ushort CurrentY;

		// Token: 0x04008E6C RID: 36460
		[MinVersion(GameVersion.D2R)]
		public byte ExtraPaths;

		// Token: 0x04008E6D RID: 36461
		[MinVersion(GameVersion.D2R)]
		public List<ushort> ExtraPath_100 = (from b in Enumerable.Range(0, 100)
			select 0).ToList<ushort>();
	}
}
