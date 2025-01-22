using System;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007F8 RID: 2040
	public class AuctionHelloResponse : ServerPacket
	{
		// Token: 0x04005A4D RID: 23117
		public ObjectGuid Guid;

		// Token: 0x04005A4E RID: 23118
		public bool OpenForBusiness = true;
	}
}
