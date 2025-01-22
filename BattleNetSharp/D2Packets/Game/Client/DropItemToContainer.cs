using System;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A33 RID: 2611
	public class DropItemToContainer : Packet
	{
		// Token: 0x04008CDB RID: 36059
		public GameClientPacket PacketId;

		// Token: 0x04008CDC RID: 36060
		public uint Id;

		// Token: 0x04008CDD RID: 36061
		public uint X;

		// Token: 0x04008CDE RID: 36062
		public uint Y;

		// Token: 0x04008CDF RID: 36063
		public DropItemToContainer.ContainerType Container;

		// Token: 0x02001366 RID: 4966
		public enum ContainerType : uint
		{
			// Token: 0x04009E82 RID: 40578
			Inventory,
			// Token: 0x04009E83 RID: 40579
			Trade = 2U,
			// Token: 0x04009E84 RID: 40580
			Cube,
			// Token: 0x04009E85 RID: 40581
			Stash
		}
	}
}
