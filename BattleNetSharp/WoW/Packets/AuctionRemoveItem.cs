using System;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007EF RID: 2031
	public class AuctionRemoveItem : ClientPacket
	{
		// Token: 0x04005A23 RID: 23075
		public ObjectGuid Auctioneer;

		// Token: 0x04005A24 RID: 23076
		public uint AuctionID;

		// Token: 0x04005A25 RID: 23077
		public Optional<AddOnInfo> TaintedBy;
	}
}
