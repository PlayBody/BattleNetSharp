using System;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007F6 RID: 2038
	public class AuctionCommandResult : ServerPacket
	{
		// Token: 0x04005A40 RID: 23104
		public uint AuctionID;

		// Token: 0x04005A41 RID: 23105
		public int Command;

		// Token: 0x04005A42 RID: 23106
		public int ErrorCode;

		// Token: 0x04005A43 RID: 23107
		public int BagResult;

		// Token: 0x04005A44 RID: 23108
		public ObjectGuid Guid;

		// Token: 0x04005A45 RID: 23109
		public ulong MinIncrement;

		// Token: 0x04005A46 RID: 23110
		public ulong Money;

		// Token: 0x04005A47 RID: 23111
		public uint DesiredDelay;
	}
}
