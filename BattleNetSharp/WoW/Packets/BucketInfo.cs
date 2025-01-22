using System;
using System.Collections.Generic;

namespace WoW.Packets
{
	// Token: 0x02000809 RID: 2057
	public class BucketInfo
	{
		// Token: 0x04005A82 RID: 23170
		public AuctionBucketKey Key;

		// Token: 0x04005A83 RID: 23171
		public int TotalQuantity;

		// Token: 0x04005A84 RID: 23172
		public ulong MinPrice;

		// Token: 0x04005A85 RID: 23173
		public int RequiredLevel;

		// Token: 0x04005A86 RID: 23174
		public List<uint> ItemModifiedAppearanceIDs = new List<uint>();

		// Token: 0x04005A87 RID: 23175
		public Optional<byte> MaxBattlePetQuality;

		// Token: 0x04005A88 RID: 23176
		public Optional<byte> MaxBattlePetLevel;

		// Token: 0x04005A89 RID: 23177
		public Optional<byte> BattlePetBreedID;

		// Token: 0x04005A8A RID: 23178
		public Optional<uint> Unk901_1;

		// Token: 0x04005A8B RID: 23179
		public bool ContainsOwnerItem;

		// Token: 0x04005A8C RID: 23180
		public bool ContainsOnlyCollectedAppearances;
	}
}
