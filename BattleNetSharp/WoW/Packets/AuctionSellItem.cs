using System;
using System.Collections.Generic;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007F2 RID: 2034
	public class AuctionSellItem : ClientPacket
	{
		// Token: 0x04005A31 RID: 23089
		public ulong BuyoutPrice;

		// Token: 0x04005A32 RID: 23090
		public ObjectGuid Auctioneer;

		// Token: 0x04005A33 RID: 23091
		public ulong MinBid;

		// Token: 0x04005A34 RID: 23092
		public uint RunTime;

		// Token: 0x04005A35 RID: 23093
		public Optional<AddOnInfo> TaintedBy;

		// Token: 0x04005A36 RID: 23094
		public List<AuctionItemForSale> Items = new List<AuctionItemForSale>(1);
	}
}
