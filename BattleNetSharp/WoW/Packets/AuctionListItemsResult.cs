using System;
using System.Collections.Generic;

namespace WoW.Packets
{
	// Token: 0x020007FC RID: 2044
	public class AuctionListItemsResult : ServerPacket
	{
		// Token: 0x04005A59 RID: 23129
		public List<AuctionItem> Items = new List<AuctionItem>();

		// Token: 0x04005A5A RID: 23130
		public uint Unknown830;

		// Token: 0x04005A5B RID: 23131
		public uint TotalCount;

		// Token: 0x04005A5C RID: 23132
		public uint DesiredDelay;

		// Token: 0x04005A5D RID: 23133
		public bool HasMoreResults;

		// Token: 0x04005A5E RID: 23134
		public AuctionBucketKey BucketKey = new AuctionBucketKey();
	}
}
