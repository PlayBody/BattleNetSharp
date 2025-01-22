using System;
using System.Collections.Generic;

namespace WoW.Packets
{
	// Token: 0x020007FA RID: 2042
	public class AuctionListBucketsResult : ServerPacket
	{
		// Token: 0x04005A52 RID: 23122
		public List<BucketInfo> Buckets = new List<BucketInfo>();

		// Token: 0x04005A53 RID: 23123
		public uint DesiredDelay;

		// Token: 0x04005A54 RID: 23124
		public int Unknown830_0;

		// Token: 0x04005A55 RID: 23125
		public int Unknown830_1;

		// Token: 0x04005A56 RID: 23126
		public bool HasMoreResults;
	}
}
