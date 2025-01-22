using System;

namespace WoW.Packets
{
	// Token: 0x020007F5 RID: 2037
	public class AuctionClosedNotification : ServerPacket
	{
		// Token: 0x04005A3D RID: 23101
		public AuctionOwnerNotification Info;

		// Token: 0x04005A3E RID: 23102
		public float ProceedsMailDelay;

		// Token: 0x04005A3F RID: 23103
		public bool Sold = true;
	}
}
