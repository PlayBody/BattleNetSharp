using System;
using System.Collections.Generic;

namespace WoW.Packets
{
	// Token: 0x020007D7 RID: 2007
	public class AdventureJournalDataResponse : ServerPacket
	{
		// Token: 0x040059D9 RID: 23001
		public bool OnLevelUp;

		// Token: 0x040059DA RID: 23002
		public List<AdventureJournalEntry> AdventureJournalDatas;
	}
}
