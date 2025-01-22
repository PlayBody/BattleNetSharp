using System;
using Fenris.ClientMessage;

namespace D4Packets.Game.Client
{
	// Token: 0x02000880 RID: 2176
	[D4Packet.OpcodeAttribute(Opcodes.CMSG_USER_PROXY_SELECT_HERO)]
	public class SelectHero : D4Packet
	{
		// Token: 0x04006410 RID: 25616
		public uint Token;

		// Token: 0x04006411 RID: 25617
		public SelectHeroRequest Hero;
	}
}
