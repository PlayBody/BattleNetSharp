using System;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x0200080B RID: 2059
	public struct AuctionBidderNotification
	{
		// Token: 0x04005AA0 RID: 23200
		public uint AuctionID;

		// Token: 0x04005AA1 RID: 23201
		public ObjectGuid Bidder;
	}
}
