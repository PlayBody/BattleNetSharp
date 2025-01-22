using System;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A46 RID: 2630
	public class ItemToCube : Packet
	{
		// Token: 0x04008DF6 RID: 36342
		public GameClientPacket PacketId;

		// Token: 0x04008DF7 RID: 36343
		public uint ItemId;

		// Token: 0x04008DF8 RID: 36344
		public uint CubeId;

		// Token: 0x04008DF9 RID: 36345
		[MinVersion(GameVersion.D2R)]
		public uint CubeLocation = 0U;

		// Token: 0x04008DFA RID: 36346
		[MinVersion(GameVersion.D2R)]
		public ushort CubeX = 0;

		// Token: 0x04008DFB RID: 36347
		[MinVersion(GameVersion.D2R)]
		public ushort CubeY = 0;

		// Token: 0x04008DFC RID: 36348
		[MinVersion(GameVersion.D2R)]
		public ushort X = 0;

		// Token: 0x04008DFD RID: 36349
		[MinVersion(GameVersion.D2R)]
		public ushort Y = 0;
	}
}
