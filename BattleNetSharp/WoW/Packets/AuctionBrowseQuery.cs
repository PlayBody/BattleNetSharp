using System;
using System.Collections.Generic;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007E5 RID: 2021
	public class AuctionBrowseQuery : ClientPacket
	{
		// Token: 0x040059F5 RID: 23029
		public ObjectGuid Auctioneer;

		// Token: 0x040059F6 RID: 23030
		public uint Offset;

		// Token: 0x040059F7 RID: 23031
		public byte MinLevel;

		// Token: 0x040059F8 RID: 23032
		public byte MaxLevel;

		// Token: 0x040059F9 RID: 23033
		public List<byte> KnownPets;

		// Token: 0x040059FA RID: 23034
		public sbyte MaxPetLevel;

		// Token: 0x040059FB RID: 23035
		public Optional<AddOnInfo> TaintedBy;

		// Token: 0x040059FC RID: 23036
		public string Name;

		// Token: 0x040059FD RID: 23037
		public List<AuctionListFilterClass> ItemClassFilters = new List<AuctionListFilterClass>(7);

		// Token: 0x040059FE RID: 23038
		public List<AuctionSortDef> Sorts = new List<AuctionSortDef>(2);
	}
}
