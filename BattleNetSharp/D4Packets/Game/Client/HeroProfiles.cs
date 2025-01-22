using System;
using Fenris.ClientMessage;

namespace D4Packets.Game.Client
{
	// Token: 0x020008BF RID: 2239
	[D4Packet.OpcodeAttribute(Opcodes.SMSG_USER_PROXY_GET_HERO_PROFILES_RESPONSE)]
	public class HeroProfiles : D4Packet
	{
		// Token: 0x0400651A RID: 25882
		public uint Token;

		// Token: 0x0400651B RID: 25883
		public uint Error;

		// Token: 0x0400651C RID: 25884
		public GetHeroProfileResponse Heroes;
	}
}
