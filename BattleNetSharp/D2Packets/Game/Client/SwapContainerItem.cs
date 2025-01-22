using System;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A6A RID: 2666
	public class SwapContainerItem : Packet
	{
		// Token: 0x04008EB3 RID: 36531
		public GameClientPacket PacketId;

		// Token: 0x04008EB4 RID: 36532
		public uint SubjectId;

		// Token: 0x04008EB5 RID: 36533
		public uint ObjectId;

		// Token: 0x04008EB6 RID: 36534
		[MaxVersion(GameVersion.LOD)]
		public uint X;

		// Token: 0x04008EB7 RID: 36535
		[MaxVersion(GameVersion.LOD)]
		public uint Y;

		// Token: 0x04008EB8 RID: 36536
		[MinVersion(GameVersion.D2R)]
		public SwapContainerItem.ContainerType Container;

		// Token: 0x04008EB9 RID: 36537
		[MinVersion(GameVersion.D2R)]
		public ushort X1;

		// Token: 0x04008EBA RID: 36538
		[MinVersion(GameVersion.D2R)]
		public ushort Y1;

		// Token: 0x04008EBB RID: 36539
		[MinVersion(GameVersion.D2R)]
		public ushort X2;

		// Token: 0x04008EBC RID: 36540
		[MinVersion(GameVersion.D2R)]
		public ushort Y2;

		// Token: 0x02001372 RID: 4978
		public enum ContainerType : uint
		{
			// Token: 0x04009EAC RID: 40620
			Inventory,
			// Token: 0x04009EAD RID: 40621
			Cursor,
			// Token: 0x04009EAE RID: 40622
			Trade,
			// Token: 0x04009EAF RID: 40623
			Cube,
			// Token: 0x04009EB0 RID: 40624
			Stash
		}
	}
}
