using System;
using System.Collections.Generic;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007EC RID: 2028
	public class AuctionListItemsByItemID : ClientPacket
	{
		// Token: 0x04005A15 RID: 23061
		public ObjectGuid Auctioneer;

		// Token: 0x04005A16 RID: 23062
		public uint ItemID;

		// Token: 0x04005A17 RID: 23063
		public int SuffixItemNameDescriptionID;

		// Token: 0x04005A18 RID: 23064
		public uint Offset;

		// Token: 0x04005A19 RID: 23065
		public Optional<AddOnInfo> TaintedBy;

		// Token: 0x04005A1A RID: 23066
		public List<AuctionSortDef> Sorts = new List<AuctionSortDef>(2);
	}
}
