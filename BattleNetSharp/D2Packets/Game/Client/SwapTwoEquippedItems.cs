using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A6D RID: 2669
	public class SwapTwoEquippedItems : Packet
	{
		// Token: 0x04008ECC RID: 36556
		public GameClientPacket PacketId;

		// Token: 0x04008ECD RID: 36557
		public uint Id;

		// Token: 0x04008ECE RID: 36558
		[MinVersion(GameVersion.D2R)]
		public uint EquippedId;

		// Token: 0x04008ECF RID: 36559
		[MinVersion(GameVersion.D2R)]
		public uint PlaceToInventoryId;

		// Token: 0x04008ED0 RID: 36560
		public EquipmentLocation Location;

		// Token: 0x04008ED1 RID: 36561
		public ushort pad0;

		// Token: 0x04008ED2 RID: 36562
		[MinVersion(GameVersion.D2R)]
		public ushort X;

		// Token: 0x04008ED3 RID: 36563
		[MinVersion(GameVersion.D2R)]
		public ushort Y;
	}
}
