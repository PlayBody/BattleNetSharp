using System;

namespace D4Packets.Game.Client
{
	// Token: 0x020008A5 RID: 2213
	public class NewSkillSavedData : D4Packet
	{
		// Token: 0x040064BE RID: 25790
		[FixedLen(5U)]
		public AnotherSkillSavedData[] Skills;
	}
}
