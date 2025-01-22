using System;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007D2 RID: 2002
	public struct GuildCriteriaProgress
	{
		// Token: 0x040059C8 RID: 22984
		public uint CriteriaID;

		// Token: 0x040059C9 RID: 22985
		public long DateCreated;

		// Token: 0x040059CA RID: 22986
		public long DateStarted;

		// Token: 0x040059CB RID: 22987
		public long DateUpdated;

		// Token: 0x040059CC RID: 22988
		public ulong Quantity;

		// Token: 0x040059CD RID: 22989
		public ObjectGuid PlayerGUID;

		// Token: 0x040059CE RID: 22990
		public int Flags;
	}
}
