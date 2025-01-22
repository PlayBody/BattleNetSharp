using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A48 RID: 2632
	public class PickItem : Packet
	{
		// Token: 0x04008E01 RID: 36353
		public GameClientPacket PacketId;

		// Token: 0x04008E02 RID: 36354
		[MaxVersion(GameVersion.LOD)]
		public UnitType UnitType;

		// Token: 0x04008E03 RID: 36355
		[MaxVersion(GameVersion.LOD)]
		public ushort UnitTypePad0 = 0;

		// Token: 0x04008E04 RID: 36356
		[MaxVersion(GameVersion.LOD)]
		public byte UnitTypePad1 = 0;

		// Token: 0x04008E05 RID: 36357
		public uint Id;

		// Token: 0x04008E06 RID: 36358
		[MinVersion(GameVersion.D2R)]
		public uint X;

		// Token: 0x04008E07 RID: 36359
		[MinVersion(GameVersion.D2R)]
		public uint Y;

		// Token: 0x04008E08 RID: 36360
		public PickItem.PickLocation ToLocation;

		// Token: 0x02001369 RID: 4969
		public enum PickLocation : uint
		{
			// Token: 0x04009E91 RID: 40593
			Cursor,
			// Token: 0x04009E92 RID: 40594
			Inventory
		}
	}
}
