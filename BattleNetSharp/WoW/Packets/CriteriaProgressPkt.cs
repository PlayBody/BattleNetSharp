using System;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007D1 RID: 2001
	public struct CriteriaProgressPkt
	{
		// Token: 0x040059C0 RID: 22976
		public uint Id;

		// Token: 0x040059C1 RID: 22977
		public ulong Quantity;

		// Token: 0x040059C2 RID: 22978
		public ObjectGuid Player;

		// Token: 0x040059C3 RID: 22979
		public DateTime Date;

		// Token: 0x040059C4 RID: 22980
		public uint TimeFromStart;

		// Token: 0x040059C5 RID: 22981
		public uint TimeFromCreate;

		// Token: 0x040059C6 RID: 22982
		public uint Flags;

		// Token: 0x040059C7 RID: 22983
		public Optional<ulong> RafAcceptanceID;
	}
}
