using System;

namespace WoW.Packets
{
	// Token: 0x02000802 RID: 2050
	public class AuctionBucketKey
	{
		// Token: 0x04005A70 RID: 23152
		public uint ItemID;

		// Token: 0x04005A71 RID: 23153
		public ushort ItemLevel;

		// Token: 0x04005A72 RID: 23154
		public Optional<ushort> BattlePetSpeciesID = default(Optional<ushort>);

		// Token: 0x04005A73 RID: 23155
		public Optional<ushort> SuffixItemNameDescriptionID = default(Optional<ushort>);
	}
}
