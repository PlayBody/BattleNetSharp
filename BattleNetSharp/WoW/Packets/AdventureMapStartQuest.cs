using System;

namespace WoW.Packets
{
	// Token: 0x020007D9 RID: 2009
	internal class AdventureMapStartQuest : ClientPacket
	{
		// Token: 0x0600B509 RID: 46345 RVA: 0x002C2CF7 File Offset: 0x002C0EF7
		private void test()
		{
			this.QuestID = 0U;
		}

		// Token: 0x040059DD RID: 23005
		public uint QuestID;
	}
}
