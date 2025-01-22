using System;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007F4 RID: 2036
	public class AuctionGetCommodityQuote : ClientPacket
	{
		// Token: 0x04005A39 RID: 23097
		public ObjectGuid Auctioneer;

		// Token: 0x04005A3A RID: 23098
		public int ItemID;

		// Token: 0x04005A3B RID: 23099
		public uint Quantity;

		// Token: 0x04005A3C RID: 23100
		public Optional<AddOnInfo> TaintedBy;
	}
}
