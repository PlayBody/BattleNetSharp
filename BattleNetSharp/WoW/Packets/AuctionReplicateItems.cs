using System;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007F0 RID: 2032
	public class AuctionReplicateItems : ClientPacket
	{
		// Token: 0x04005A26 RID: 23078
		public ObjectGuid Auctioneer;

		// Token: 0x04005A27 RID: 23079
		public uint ChangeNumberGlobal;

		// Token: 0x04005A28 RID: 23080
		public uint ChangeNumberCursor;

		// Token: 0x04005A29 RID: 23081
		public uint ChangeNumberTombstone;

		// Token: 0x04005A2A RID: 23082
		public uint Count;

		// Token: 0x04005A2B RID: 23083
		public Optional<AddOnInfo> TaintedBy;
	}
}
