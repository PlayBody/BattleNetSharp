using System;
using System.Collections.Generic;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007EA RID: 2026
	public class AuctionListBucketsByBucketKeys : ClientPacket
	{
		// Token: 0x04005A0B RID: 23051
		public ObjectGuid Auctioneer;

		// Token: 0x04005A0C RID: 23052
		public Optional<AddOnInfo> TaintedBy;

		// Token: 0x04005A0D RID: 23053
		public List<AuctionBucketKey> BucketKeys;

		// Token: 0x04005A0E RID: 23054
		public List<AuctionSortDef> Sorts;
	}
}
