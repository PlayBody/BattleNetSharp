using System;
using Fenris.ClientMessage;

namespace D4Packets.Game.Client
{
	// Token: 0x02000879 RID: 2169
	[D4Packet.OpcodeAttribute(Opcodes.CMSG_USER_PROXY_GET_HERO_PROFILES)]
	public class GetHeroProfiles : D4Packet
	{
		// Token: 0x04006403 RID: 25603
		public uint Token;

		// Token: 0x04006404 RID: 25604
		public GetHeroProfilesRequest Account;
	}
}
