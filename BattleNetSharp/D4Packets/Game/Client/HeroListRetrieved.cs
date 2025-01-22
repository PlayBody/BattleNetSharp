using System;
using Fenris.ClientMessage;

namespace D4Packets.Game.Client
{
	// Token: 0x020008BD RID: 2237
	[D4Packet.OpcodeAttribute(Opcodes.SMSG_USER_PROXY_HERO_LIST_RETRIEVED)]
	public class HeroListRetrieved : D4Packet
	{
		// Token: 0x04006515 RID: 25877
		public ListHeroesResponse message;

		// Token: 0x04006516 RID: 25878
		public GetHeroDigestsResponse alt;
	}
}
