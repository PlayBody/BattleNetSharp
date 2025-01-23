using System;
using System.Collections.Generic;
using System.Linq;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A80 RID: 2688
	public class WalkToTarget : Packet
	{
		// Token: 0x04008F4B RID: 36683
		public GameClientPacket PacketId;

		// Token: 0x04008F4C RID: 36684
		public UnitType Type;

		// Token: 0x04008F4D RID: 36685
		public byte unk1;

		// Token: 0x04008F4E RID: 36686
		public byte unk2;

		// Token: 0x04008F4F RID: 36687
		public byte unk3;

		// Token: 0x04008F50 RID: 36688
		public uint Id;

		// Token: 0x04008F51 RID: 36689
		[MinVersion(GameVersion.D2R)]
		public ushort X;

		// Token: 0x04008F52 RID: 36690
		[MinVersion(GameVersion.D2R)]
		public ushort Y;

		// Token: 0x04008F53 RID: 36691
		[MinVersion(GameVersion.D2R)]
		public byte ExtraPaths;

		// Token: 0x04008F54 RID: 36692
		[MinVersion(GameVersion.D2R)]
		public List<ushort> ExtraPath_100 = (from b in Enumerable.Range(0, 100)
			select (ushort)0).ToList<ushort>();
	}
}
