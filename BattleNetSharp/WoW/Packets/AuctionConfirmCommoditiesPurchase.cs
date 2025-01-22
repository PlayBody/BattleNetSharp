using System;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007E7 RID: 2023
	public class AuctionConfirmCommoditiesPurchase : ClientPacket
	{
		// Token: 0x04005A01 RID: 23041
		public ObjectGuid Auctioneer;

		// Token: 0x04005A02 RID: 23042
		public int ItemID;

		// Token: 0x04005A03 RID: 23043
		public uint Quantity;

		// Token: 0x04005A04 RID: 23044
		public Optional<AddOnInfo> TaintedBy;
	}
}
