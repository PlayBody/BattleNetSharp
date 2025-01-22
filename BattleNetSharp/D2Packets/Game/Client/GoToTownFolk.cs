using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A3D RID: 2621
	public class GoToTownFolk : Packet
	{
		// Token: 0x04008DC4 RID: 36292
		public GameClientPacket PacketId;

		// Token: 0x04008DC5 RID: 36293
		[MaxVersion(GameVersion.LOD)]
		public UnitType Type;

		// Token: 0x04008DC6 RID: 36294
		[MaxVersion(GameVersion.LOD)]
		public byte pad0 = 0;

		// Token: 0x04008DC7 RID: 36295
		[MaxVersion(GameVersion.LOD)]
		public byte pad1 = 0;

		// Token: 0x04008DC8 RID: 36296
		[MaxVersion(GameVersion.LOD)]
		public byte pad2 = 0;

		// Token: 0x04008DC9 RID: 36297
		public uint Id;

		// Token: 0x04008DCA RID: 36298
		[MaxVersion(GameVersion.LOD)]
		public uint X;

		// Token: 0x04008DCB RID: 36299
		[MaxVersion(GameVersion.LOD)]
		public uint Y;
	}
}
