using System;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A49 RID: 2633
	public class PickItemFromContainer : Packet
	{
		// Token: 0x04008E09 RID: 36361
		public GameClientPacket PacketId;

		// Token: 0x04008E0A RID: 36362
		public uint Id;

		// Token: 0x04008E0B RID: 36363
		[MinVersion(GameVersion.D2R)]
		public uint X;

		// Token: 0x04008E0C RID: 36364
		[MinVersion(GameVersion.D2R)]
		public uint Y;

		// Token: 0x04008E0D RID: 36365
		[MinVersion(GameVersion.D2R)]
		public PickItemFromContainer.ContainerType Container;

		// Token: 0x0200136A RID: 4970
		public enum ContainerType : uint
		{
			// Token: 0x04009E94 RID: 40596
			Inventory,
			// Token: 0x04009E95 RID: 40597
			Cursor,
			// Token: 0x04009E96 RID: 40598
			Trade,
			// Token: 0x04009E97 RID: 40599
			Cube,
			// Token: 0x04009E98 RID: 40600
			Stash
		}
	}
}
