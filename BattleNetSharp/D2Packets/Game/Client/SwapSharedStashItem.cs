using System;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A6C RID: 2668
	public class SwapSharedStashItem : Packet
	{
		// Token: 0x04008EC2 RID: 36546
		public GameClientPacket PacketId;

		// Token: 0x04008EC3 RID: 36547
		public uint SubjectId;

		// Token: 0x04008EC4 RID: 36548
		public uint ObjectId;

		// Token: 0x04008EC5 RID: 36549
		[MaxVersion(GameVersion.LOD)]
		public uint X;

		// Token: 0x04008EC6 RID: 36550
		[MaxVersion(GameVersion.LOD)]
		public uint Y;

		// Token: 0x04008EC7 RID: 36551
		[MinVersion(GameVersion.D2R)]
		public SwapSharedStashItem.ContainerType Container;

		// Token: 0x04008EC8 RID: 36552
		[MinVersion(GameVersion.D2R)]
		public ushort X1;

		// Token: 0x04008EC9 RID: 36553
		[MinVersion(GameVersion.D2R)]
		public ushort Y1;

		// Token: 0x04008ECA RID: 36554
		[MinVersion(GameVersion.D2R)]
		public ushort X2;

		// Token: 0x04008ECB RID: 36555
		[MinVersion(GameVersion.D2R)]
		public ushort Y2;

		// Token: 0x02001373 RID: 4979
		public enum ContainerType : uint
		{
			// Token: 0x04009EB2 RID: 40626
			Inventory,
			// Token: 0x04009EB3 RID: 40627
			Cursor,
			// Token: 0x04009EB4 RID: 40628
			Trade,
			// Token: 0x04009EB5 RID: 40629
			Cube,
			// Token: 0x04009EB6 RID: 40630
			Stash
		}
	}
}
