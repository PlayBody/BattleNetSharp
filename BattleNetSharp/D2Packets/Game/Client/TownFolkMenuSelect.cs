using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A74 RID: 2676
	public class TownFolkMenuSelect : Packet
	{
		// Token: 0x04008EFF RID: 36607
		public GameClientPacket PacketId;

		// Token: 0x04008F00 RID: 36608
		public TownFolkMenuItem Type;

		// Token: 0x04008F01 RID: 36609
		public uint Id;

		// Token: 0x04008F02 RID: 36610
		[MaxVersion(GameVersion.LOD)]
		public uint Data = 0U;
	}
}
