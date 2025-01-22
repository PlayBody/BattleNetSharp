using System;
using System.Collections.Generic;

namespace WoW.Packets
{
	// Token: 0x020007FD RID: 2045
	public class AuctionListOwnedItemsResult : ServerPacket
	{
		// Token: 0x04005A5F RID: 23135
		public List<AuctionItem> Items = new List<AuctionItem>();

		// Token: 0x04005A60 RID: 23136
		public List<AuctionItem> SoldItems = new List<AuctionItem>();

		// Token: 0x04005A61 RID: 23137
		public uint DesiredDelay;

		// Token: 0x04005A62 RID: 23138
		public bool HasMoreResults;
	}
}
