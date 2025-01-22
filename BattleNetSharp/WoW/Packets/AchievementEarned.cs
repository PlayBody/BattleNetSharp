using System;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007C6 RID: 1990
	public class AchievementEarned : ServerPacket
	{
		// Token: 0x0400599F RID: 22943
		public ObjectGuid Sender;

		// Token: 0x040059A0 RID: 22944
		public ObjectGuid Earner;

		// Token: 0x040059A1 RID: 22945
		public uint AchievementID;

		// Token: 0x040059A2 RID: 22946
		public long Time;

		// Token: 0x040059A3 RID: 22947
		public uint EarnerNativeRealm;

		// Token: 0x040059A4 RID: 22948
		public uint EarnerVirtualRealm;

		// Token: 0x040059A5 RID: 22949
		public bool Initial;
	}
}
