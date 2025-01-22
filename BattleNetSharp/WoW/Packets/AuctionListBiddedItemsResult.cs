using System;
using System.Collections.Generic;

namespace WoW.Packets
{
	// Token: 0x020007F9 RID: 2041
	public class AuctionListBiddedItemsResult : ServerPacket
	{
		// Token: 0x04005A4F RID: 23119
		public List<AuctionItem> Items = new List<AuctionItem>();

		// Token: 0x04005A50 RID: 23120
		public uint DesiredDelay;

		// Token: 0x04005A51 RID: 23121
		public bool HasMoreResults;
	}
}
