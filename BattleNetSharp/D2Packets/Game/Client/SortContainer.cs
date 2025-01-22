using System;
using System.Collections.Generic;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A65 RID: 2661
	public class SortContainer : Packet
	{
		// Token: 0x04008EA1 RID: 36513
		public GameClientPacket PacketId;

		// Token: 0x04008EA2 RID: 36514
		public SortContainer.ContainerType Container;

		// Token: 0x04008EA3 RID: 36515
		public uint ContainerId;

		// Token: 0x04008EA4 RID: 36516
		public byte NumExtra;

		// Token: 0x04008EA5 RID: 36517
		public List<SortContainer.ItemSort> Items;

		// Token: 0x02001370 RID: 4976
		public enum ContainerType : byte
		{
			// Token: 0x04009EA5 RID: 40613
			Inventory,
			// Token: 0x04009EA6 RID: 40614
			Trade = 2,
			// Token: 0x04009EA7 RID: 40615
			Cube,
			// Token: 0x04009EA8 RID: 40616
			Stash
		}

		// Token: 0x02001371 RID: 4977
		public class ItemSort : Packet
		{
			// Token: 0x04009EA9 RID: 40617
			public byte XY;

			// Token: 0x04009EAA RID: 40618
			public uint ItemId;
		}
	}
}
