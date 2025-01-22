using System;
using System.Collections.Generic;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007EB RID: 2027
	public class AuctionListItemsByBucketKey : ClientPacket
	{
		// Token: 0x04005A0F RID: 23055
		public ObjectGuid Auctioneer;

		// Token: 0x04005A10 RID: 23056
		public uint Offset;

		// Token: 0x04005A11 RID: 23057
		public sbyte Unknown830;

		// Token: 0x04005A12 RID: 23058
		public Optional<AddOnInfo> TaintedBy;

		// Token: 0x04005A13 RID: 23059
		public List<AuctionSortDef> Sorts;

		// Token: 0x04005A14 RID: 23060
		public AuctionBucketKey BucketKey;
	}
}
