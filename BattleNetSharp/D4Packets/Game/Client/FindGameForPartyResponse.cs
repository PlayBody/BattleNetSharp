using System;
using Fenris.ClientMessage;

namespace D4Packets.Game.Client
{
	// Token: 0x020008B9 RID: 2233
	[D4Packet.OpcodeAttribute(Opcodes.SMSG_USER_PROXY_FIND_GAME_FOR_PARTY_RESPONSE)]
	public class FindGameForPartyResponse : D4Packet
	{
		// Token: 0x0400650B RID: 25867
		public uint Token;

		// Token: 0x0400650C RID: 25868
		public uint Error;

		// Token: 0x0400650D RID: 25869
		public PartyGameFound message;
	}
}
