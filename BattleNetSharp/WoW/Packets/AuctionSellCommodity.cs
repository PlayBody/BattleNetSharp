using System;
using System.Collections.Generic;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007F1 RID: 2033
	public class AuctionSellCommodity : ClientPacket
	{
		// Token: 0x04005A2C RID: 23084
		public ObjectGuid Auctioneer;

		// Token: 0x04005A2D RID: 23085
		public ulong UnitPrice;

		// Token: 0x04005A2E RID: 23086
		public uint RunTime;

		// Token: 0x04005A2F RID: 23087
		public Optional<AddOnInfo> TaintedBy;

		// Token: 0x04005A30 RID: 23088
		public List<AuctionItemForSale> Items = new List<AuctionItemForSale>(64);
	}
}
