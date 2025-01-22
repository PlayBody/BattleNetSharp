using System;

namespace WoW.Packets
{
	// Token: 0x020007FE RID: 2046
	public class AuctionOutbidNotification : ServerPacket
	{
		// Token: 0x04005A63 RID: 23139
		public AuctionBidderNotification Info;

		// Token: 0x04005A64 RID: 23140
		public ulong BidAmount;

		// Token: 0x04005A65 RID: 23141
		public ulong MinIncrement;
	}
}
