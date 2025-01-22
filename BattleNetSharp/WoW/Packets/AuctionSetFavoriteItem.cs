using System;

namespace WoW.Packets
{
	// Token: 0x020007F3 RID: 2035
	public class AuctionSetFavoriteItem : ClientPacket
	{
		// Token: 0x04005A37 RID: 23095
		public bool IsNotFavorite = true;

		// Token: 0x04005A38 RID: 23096
		public AuctionFavoriteInfo Item;
	}
}
