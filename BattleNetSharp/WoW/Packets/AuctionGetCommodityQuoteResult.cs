using System;

namespace WoW.Packets
{
	// Token: 0x020007F7 RID: 2039
	public class AuctionGetCommodityQuoteResult : ServerPacket
	{
		// Token: 0x04005A48 RID: 23112
		public Optional<ulong> TotalPrice;

		// Token: 0x04005A49 RID: 23113
		public Optional<uint> Quantity;

		// Token: 0x04005A4A RID: 23114
		public Optional<int> QuoteDuration;

		// Token: 0x04005A4B RID: 23115
		public int ItemID;

		// Token: 0x04005A4C RID: 23116
		public uint DesiredDelay;
	}
}
