using System;

namespace WoW.Packets
{
	// Token: 0x020007C5 RID: 1989
	public class AchievementDeleted : ServerPacket
	{
		// Token: 0x0400599D RID: 22941
		public uint AchievementID;

		// Token: 0x0400599E RID: 22942
		public uint Immunities;
	}
}
