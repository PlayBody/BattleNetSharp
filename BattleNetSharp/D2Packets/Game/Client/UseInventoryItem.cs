using System;
using System.Collections.Generic;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A7D RID: 2685
	public class UseInventoryItem : Packet
	{
		// Token: 0x04008F2C RID: 36652
		public GameClientPacket PacketId;

		// Token: 0x04008F2D RID: 36653
		public uint Id;

		// Token: 0x04008F2E RID: 36654
		[MaxVersion(GameVersion.LOD)]
		public uint X;

		// Token: 0x04008F2F RID: 36655
		[MaxVersion(GameVersion.LOD)]
		public uint Y;

		// Token: 0x04008F30 RID: 36656
		[MinVersion(GameVersion.D2R)]
		public byte CubeLocation;

		// Token: 0x04008F31 RID: 36657
		[MinVersion(GameVersion.D2R)]
		public byte XY;

		// Token: 0x04008F32 RID: 36658
		[MinVersion(GameVersion.D2R)]
		public byte NumItems;

		// Token: 0x04008F33 RID: 36659
		[MinVersion(GameVersion.D2R)]
		public UseInventoryItem.HoradricItem FirstItem;

		// Token: 0x04008F34 RID: 36660
		[MinVersion(GameVersion.D2R)]
		public List<UseInventoryItem.HoradricItem> OtherItems = new List<UseInventoryItem.HoradricItem>();

		// Token: 0x0200137C RID: 4988
		public class HoradricItem : Packet
		{
			// Token: 0x04009EF4 RID: 40692
			public uint ItemId;

			// Token: 0x04009EF5 RID: 40693
			public byte HoradricCubeLocation;
		}
	}
}
