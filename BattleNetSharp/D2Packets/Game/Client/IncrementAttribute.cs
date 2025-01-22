using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A42 RID: 2626
	public class IncrementAttribute : Packet
	{
		// Token: 0x04008DE0 RID: 36320
		public GameClientPacket PacketId;

		// Token: 0x04008DE1 RID: 36321
		[MaxVersion(GameVersion.LOD)]
		public byte Stat;

		// Token: 0x04008DE2 RID: 36322
		[MaxVersion(GameVersion.LOD)]
		public byte Amount;

		// Token: 0x04008DE3 RID: 36323
		[MinVersion(GameVersion.D2R)]
		public StatType StatD2R;

		// Token: 0x04008DE4 RID: 36324
		[MinVersion(GameVersion.D2R)]
		public ushort AmountD2R;
	}
}
