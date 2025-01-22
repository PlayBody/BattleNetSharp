using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A73 RID: 2675
	public class TownFolkInteract : Packet
	{
		// Token: 0x04008EF9 RID: 36601
		public GameClientPacket PacketId;

		// Token: 0x04008EFA RID: 36602
		[MaxVersion(GameVersion.LOD)]
		public UnitType Type;

		// Token: 0x04008EFB RID: 36603
		[MaxVersion(GameVersion.LOD)]
		public byte pad0 = 0;

		// Token: 0x04008EFC RID: 36604
		[MaxVersion(GameVersion.LOD)]
		public byte pad1 = 0;

		// Token: 0x04008EFD RID: 36605
		[MaxVersion(GameVersion.LOD)]
		public byte pad2 = 0;

		// Token: 0x04008EFE RID: 36606
		public uint Id;
	}
}
