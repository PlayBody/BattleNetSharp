using System;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A45 RID: 2629
	public class InventoryItemToBelt : Packet
	{
		// Token: 0x04008DEF RID: 36335
		public GameClientPacket PacketId;

		// Token: 0x04008DF0 RID: 36336
		public uint Id;

		// Token: 0x04008DF1 RID: 36337
		[MinVersion(GameVersion.D2R)]
		public uint invenmaybe = uint.MaxValue;

		// Token: 0x04008DF2 RID: 36338
		[MinVersion(GameVersion.D2R)]
		public uint beltmatbe;

		// Token: 0x04008DF3 RID: 36339
		[MinVersion(GameVersion.D2R)]
		public ushort InventoryX;

		// Token: 0x04008DF4 RID: 36340
		[MinVersion(GameVersion.D2R)]
		public ushort InventoryY;

		// Token: 0x04008DF5 RID: 36341
		[MinVersion(GameVersion.D2R)]
		public uint BeltPos;
	}
}
