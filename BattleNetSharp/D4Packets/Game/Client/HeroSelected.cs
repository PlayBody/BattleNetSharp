using System;
using Fenris.ClientMessage;

namespace D4Packets.Game.Client
{
	// Token: 0x020008C0 RID: 2240
	[D4Packet.OpcodeAttribute(Opcodes.SMSG_USER_PROXY_HERO_SELECTED)]
	public class HeroSelected : D4Packet
	{
		// Token: 0x0400651D RID: 25885
		public uint Token;

		// Token: 0x0400651E RID: 25886
		public uint Error;

		// Token: 0x0400651F RID: 25887
		public SelectHeroResponse Hero;
	}
}
