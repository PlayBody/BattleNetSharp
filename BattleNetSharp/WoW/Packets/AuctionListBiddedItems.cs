using System;
using System.Collections.Generic;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007E9 RID: 2025
	public class AuctionListBiddedItems : ClientPacket
	{
		// Token: 0x04005A06 RID: 23046
		public ObjectGuid Auctioneer;

		// Token: 0x04005A07 RID: 23047
		public uint Offset;

		// Token: 0x04005A08 RID: 23048
		public List<uint> AuctionItemIDs = new List<uint>();

		// Token: 0x04005A09 RID: 23049
		public List<AuctionSortDef> Sorts = new List<AuctionSortDef>(2);

		// Token: 0x04005A0A RID: 23050
		public Optional<AddOnInfo> TaintedBy;
	}
}
