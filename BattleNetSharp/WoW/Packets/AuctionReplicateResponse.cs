using System;
using System.Collections.Generic;

namespace WoW.Packets
{
	// Token: 0x02000800 RID: 2048
	public class AuctionReplicateResponse : ServerPacket
	{
		// Token: 0x04005A69 RID: 23145
		public uint Result;

		// Token: 0x04005A6A RID: 23146
		public uint DesiredDelay;

		// Token: 0x04005A6B RID: 23147
		public uint ChangeNumberGlobal;

		// Token: 0x04005A6C RID: 23148
		public uint ChangeNumberCursor;

		// Token: 0x04005A6D RID: 23149
		public uint ChangeNumberTombstone;

		// Token: 0x04005A6E RID: 23150
		public List<AuctionItem> Items;
	}
}
