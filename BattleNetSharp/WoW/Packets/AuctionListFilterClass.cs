using System;
using System.Collections.Generic;

namespace WoW.Packets
{
	// Token: 0x02000804 RID: 2052
	public class AuctionListFilterClass
	{
		// Token: 0x04005A76 RID: 23158
		public int ItemClass;

		// Token: 0x04005A77 RID: 23159
		public List<AuctionListFilterSubClass> SubClassFilters;
	}
}
