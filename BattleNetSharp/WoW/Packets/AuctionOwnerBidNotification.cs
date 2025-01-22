using System;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007FF RID: 2047
	public class AuctionOwnerBidNotification : ServerPacket
	{
		// Token: 0x04005A66 RID: 23142
		public AuctionOwnerNotification Info;

		// Token: 0x04005A67 RID: 23143
		public ObjectGuid Bidder;

		// Token: 0x04005A68 RID: 23144
		public ulong MinIncrement;
	}
}
