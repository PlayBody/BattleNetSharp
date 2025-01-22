using System;
using System.Collections.Generic;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007ED RID: 2029
	public class AuctionListOwnedItems : ClientPacket
	{
		// Token: 0x04005A1B RID: 23067
		public ObjectGuid Auctioneer;

		// Token: 0x04005A1C RID: 23068
		public uint Offset;

		// Token: 0x04005A1D RID: 23069
		public Optional<AddOnInfo> TaintedBy;

		// Token: 0x04005A1E RID: 23070
		public List<AuctionSortDef> Sorts = new List<AuctionSortDef>(2);
	}
}
