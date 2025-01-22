using System;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007EE RID: 2030
	public class AuctionPlaceBid : ClientPacket
	{
		// Token: 0x04005A1F RID: 23071
		public ObjectGuid Auctioneer;

		// Token: 0x04005A20 RID: 23072
		public ulong BidAmount;

		// Token: 0x04005A21 RID: 23073
		public uint AuctionID;

		// Token: 0x04005A22 RID: 23074
		public Optional<AddOnInfo> TaintedBy;
	}
}
