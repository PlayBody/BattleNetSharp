using System;
using Fenris.ClientMessage;

namespace D4Packets.Game.Client
{
	// Token: 0x020008BE RID: 2238
	[D4Packet.OpcodeAttribute(Opcodes.SMSG_USER_PROXY_GET_HERO_PROFILE_RESPONSE)]
	public class HeroProfile : D4Packet
	{
		// Token: 0x04006517 RID: 25879
		public uint Token;

		// Token: 0x04006518 RID: 25880
		public uint Error;

		// Token: 0x04006519 RID: 25881
		public GetHeroProfileResponse Heroes;
	}
}
