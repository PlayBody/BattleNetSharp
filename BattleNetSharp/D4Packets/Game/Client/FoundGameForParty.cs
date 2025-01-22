using System;
using Fenris.ClientMessage;

namespace D4Packets.Game.Client
{
	// Token: 0x020008BA RID: 2234
	[D4Packet.OpcodeAttribute(Opcodes.SMSG_FOUND_GAME_FOR_PARTY)]
	public class FoundGameForParty : D4Packet
	{
		// Token: 0x0400650E RID: 25870
		public PartyGameFound Game;
	}
}
