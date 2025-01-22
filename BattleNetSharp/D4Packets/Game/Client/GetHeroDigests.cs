using System;
using Fenris.ClientMessage;

namespace D4Packets.Game.Client
{
	// Token: 0x02000876 RID: 2166
	[D4Packet.OpcodeAttribute(Opcodes.CMSG_USER_PROXY_GET_HERO_DIGESTS)]
	public class GetHeroDigests : D4Packet
	{
		// Token: 0x040063FE RID: 25598
		public uint Token;

		// Token: 0x040063FF RID: 25599
		public GetHeroDigestsRequest Account;
	}
}
