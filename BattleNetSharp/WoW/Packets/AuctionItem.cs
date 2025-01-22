using System;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x0200080A RID: 2058
	public class AuctionItem
	{
		// Token: 0x04005A8D RID: 23181
		public int Count;

		// Token: 0x04005A8E RID: 23182
		public int Charges;

		// Token: 0x04005A8F RID: 23183
		public uint Flags;

		// Token: 0x04005A90 RID: 23184
		public uint AuctionID;

		// Token: 0x04005A91 RID: 23185
		public ObjectGuid Owner;

		// Token: 0x04005A92 RID: 23186
		public Optional<ulong> MinBid;

		// Token: 0x04005A93 RID: 23187
		public Optional<ulong> MinIncrement;

		// Token: 0x04005A94 RID: 23188
		public Optional<ulong> BuyoutPrice;

		// Token: 0x04005A95 RID: 23189
		public Optional<ulong> UnitPrice;

		// Token: 0x04005A96 RID: 23190
		public int DurationLeft;

		// Token: 0x04005A97 RID: 23191
		public byte DeleteReason;

		// Token: 0x04005A98 RID: 23192
		public bool CensorServerSideInfo;

		// Token: 0x04005A99 RID: 23193
		public bool CensorBidInfo;

		// Token: 0x04005A9A RID: 23194
		public ObjectGuid ItemGuid;

		// Token: 0x04005A9B RID: 23195
		public ObjectGuid OwnerAccountID;

		// Token: 0x04005A9C RID: 23196
		public uint EndTime;

		// Token: 0x04005A9D RID: 23197
		public Optional<ObjectGuid> Bidder;

		// Token: 0x04005A9E RID: 23198
		public Optional<ulong> BidAmount;

		// Token: 0x04005A9F RID: 23199
		public Optional<AuctionBucketKey> AuctionBucketKey;
	}
}
