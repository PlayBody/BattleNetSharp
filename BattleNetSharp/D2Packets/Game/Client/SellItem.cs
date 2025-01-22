using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A5D RID: 2653
	public class SellItem : Packet
	{
		// Token: 0x04008E72 RID: 36466
		public GameClientPacket PacketId;

		// Token: 0x04008E73 RID: 36467
		[MinVersion(GameVersion.D2R)]
		public uint CostD2R;

		// Token: 0x04008E74 RID: 36468
		[MaxVersion(GameVersion.LOD)]
		public uint DealerId;

		// Token: 0x04008E75 RID: 36469
		public uint ItemId;

		// Token: 0x04008E76 RID: 36470
		[MinVersion(GameVersion.D2R)]
		public uint DealerIdD2R;

		// Token: 0x04008E77 RID: 36471
		[MinVersion(GameVersion.D2R)]
		public ushort VendorX;

		// Token: 0x04008E78 RID: 36472
		[MinVersion(GameVersion.D2R)]
		public ushort VendorY;

		// Token: 0x04008E79 RID: 36473
		[MinVersion(GameVersion.D2R)]
		public ushort X;

		// Token: 0x04008E7A RID: 36474
		[MinVersion(GameVersion.D2R)]
		public ushort Y;

		// Token: 0x04008E7B RID: 36475
		[MinVersion(GameVersion.D2R)]
		public byte VendorPage = 0;

		// Token: 0x04008E7C RID: 36476
		public ItemDestination Type;

		// Token: 0x04008E7D RID: 36477
		[MaxVersion(GameVersion.LOD)]
		public ushort Flags;

		// Token: 0x04008E7E RID: 36478
		[MaxVersion(GameVersion.LOD)]
		public uint Cost;
	}
}
