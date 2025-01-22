using System;
using Fenris.ClientMessage;

namespace D4Packets.Game.Client
{
	// Token: 0x02000874 RID: 2164
	[D4Packet.OpcodeAttribute(Opcodes.CMSG_USER_PROXY_FIND_GAME_FOR_PARTY)]
	public class FindGameForParty : D4Packet
	{
		// Token: 0x040063FA RID: 25594
		public uint Token;

		// Token: 0x040063FB RID: 25595
		public PartyFindGameRequest Find;
	}
}
