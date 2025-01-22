using System;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A3E RID: 2622
	public class HireMercenary : Packet
	{
		// Token: 0x04008DCC RID: 36300
		public GameClientPacket PacketId;

		// Token: 0x04008DCD RID: 36301
		public uint DealerId;

		// Token: 0x04008DCE RID: 36302
		public ushort MercenaryId;

		// Token: 0x04008DCF RID: 36303
		public ushort Pad;

		// Token: 0x04008DD0 RID: 36304
		[MaxVersion(GameVersion.D2R)]
		public uint Cost;

		// Token: 0x04008DD1 RID: 36305
		[MaxVersion(GameVersion.D2R)]
		public uint ExistingMercId;
	}
}
