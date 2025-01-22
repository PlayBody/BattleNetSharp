using System;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A32 RID: 2610
	public class DropItemFromContainer : Packet
	{
		// Token: 0x04008CD5 RID: 36053
		public GameClientPacket PacketId;

		// Token: 0x04008CD6 RID: 36054
		public uint ItemId;

		// Token: 0x04008CD7 RID: 36055
		public uint SharedStashId;

		// Token: 0x04008CD8 RID: 36056
		public DropItemFromContainer.ContainerType Container;

		// Token: 0x04008CD9 RID: 36057
		public ushort X;

		// Token: 0x04008CDA RID: 36058
		public ushort Y;

		// Token: 0x02001365 RID: 4965
		public enum ContainerType : uint
		{
			// Token: 0x04009E7D RID: 40573
			Inventory,
			// Token: 0x04009E7E RID: 40574
			Trade = 2U,
			// Token: 0x04009E7F RID: 40575
			Cube,
			// Token: 0x04009E80 RID: 40576
			Stash
		}
	}
}
