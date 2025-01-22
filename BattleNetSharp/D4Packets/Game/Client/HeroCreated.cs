using System;
using Fenris.ClientMessage;

namespace D4Packets.Game.Client
{
	// Token: 0x020008BB RID: 2235
	[D4Packet.OpcodeAttribute(Opcodes.SMSG_USER_PROXY_HERO_CREATED)]
	public class HeroCreated : D4Packet
	{
		// Token: 0x0400650F RID: 25871
		public uint Token;

		// Token: 0x04006510 RID: 25872
		public uint Error;

		// Token: 0x04006511 RID: 25873
		public CreateHeroResponse Hero;
	}
}
