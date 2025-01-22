using System;

namespace D2Packets.Game.Server
{
	// Token: 0x02000A1F RID: 2591
	public class UseStackableItem : Packet
	{
		// Token: 0x04008C80 RID: 35968
		public GameServerPacket PacketId;

		// Token: 0x04008C81 RID: 35969
		[MaxVersion(GameVersion.LOD)]
		public UseStackableItem.StackableItemClickType1 Type1 = UseStackableItem.StackableItemClickType1.NormalClick;

		// Token: 0x04008C82 RID: 35970
		[MaxVersion(GameVersion.LOD)]
		public uint Id;

		// Token: 0x04008C83 RID: 35971
		public UseStackableItem.StackableItemClickType2 Type2;

		// Token: 0x02001362 RID: 4962
		public enum StackableItemClickType1 : byte
		{
			// Token: 0x04009E74 RID: 40564
			NormalClick,
			// Token: 0x04009E75 RID: 40565
			ActionClick = 255
		}

		// Token: 0x02001363 RID: 4963
		public enum StackableItemClickType2 : ushort
		{
			// Token: 0x04009E77 RID: 40567
			NormalClick = 218,
			// Token: 0x04009E78 RID: 40568
			ActionClick = 65535
		}
	}
}
