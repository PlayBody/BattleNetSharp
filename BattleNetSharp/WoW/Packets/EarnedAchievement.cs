using System;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007D0 RID: 2000
	public struct EarnedAchievement
	{
		// Token: 0x040059BB RID: 22971
		public uint Id;

		// Token: 0x040059BC RID: 22972
		public DateTime Date;

		// Token: 0x040059BD RID: 22973
		public ObjectGuid Owner;

		// Token: 0x040059BE RID: 22974
		public uint VirtualRealmAddress;

		// Token: 0x040059BF RID: 22975
		public uint NativeRealmAddress;
	}
}
