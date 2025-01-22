using System;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007E6 RID: 2022
	public class AuctionCancelCommoditiesPurchase : ClientPacket
	{
		// Token: 0x040059FF RID: 23039
		public ObjectGuid Auctioneer;

		// Token: 0x04005A00 RID: 23040
		public Optional<AddOnInfo> TaintedBy;
	}
}
