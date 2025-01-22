using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A72 RID: 2674
	public class TownFolkCancelInteraction : Packet
	{
		// Token: 0x04008EF3 RID: 36595
		public GameClientPacket PacketId;

		// Token: 0x04008EF4 RID: 36596
		[MaxVersion(GameVersion.LOD)]
		public UnitType Type;

		// Token: 0x04008EF5 RID: 36597
		[MaxVersion(GameVersion.LOD)]
		public byte pad0 = 0;

		// Token: 0x04008EF6 RID: 36598
		[MaxVersion(GameVersion.LOD)]
		public byte pad1 = 0;

		// Token: 0x04008EF7 RID: 36599
		[MaxVersion(GameVersion.LOD)]
		public byte pad2 = 0;

		// Token: 0x04008EF8 RID: 36600
		public uint Id;
	}
}
