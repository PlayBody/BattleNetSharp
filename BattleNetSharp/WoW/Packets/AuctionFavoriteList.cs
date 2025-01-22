using System;
using System.Collections.Generic;

namespace WoW.Packets
{
	// Token: 0x020007FB RID: 2043
	public class AuctionFavoriteList : ServerPacket
	{
		// Token: 0x04005A57 RID: 23127
		public uint DesiredDelay;

		// Token: 0x04005A58 RID: 23128
		public List<AuctionFavoriteInfo> Items = new List<AuctionFavoriteInfo>();
	}
}
