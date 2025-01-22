using System;
using Fenris.ClientMessage;

namespace D4Packets.Game.Client
{
	// Token: 0x020008BC RID: 2236
	[D4Packet.OpcodeAttribute(Opcodes.SMSG_USER_PROXY_GET_HERO_DIGESTS_RESPONSE)]
	public class HeroDigests : D4Packet
	{
		// Token: 0x04006512 RID: 25874
		public uint Token;

		// Token: 0x04006513 RID: 25875
		public uint Error;

		// Token: 0x04006514 RID: 25876
		public GetHeroDigestsResponse Heroes;
	}
}
