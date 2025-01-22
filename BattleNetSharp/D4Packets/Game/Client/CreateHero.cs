using System;
using Fenris.ClientMessage;

namespace D4Packets.Game.Client
{
	// Token: 0x02000873 RID: 2163
	[D4Packet.OpcodeAttribute(Opcodes.CMSG_USER_PROXY_CREATE_HERO)]
	public class CreateHero : D4Packet
	{
		// Token: 0x040063F8 RID: 25592
		public uint Token;

		// Token: 0x040063F9 RID: 25593
		public CreateHeroRequest Hero;
	}
}
