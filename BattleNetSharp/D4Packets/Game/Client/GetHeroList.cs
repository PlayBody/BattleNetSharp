using System;

namespace D4Packets.Game.Client
{
	// Token: 0x02000877 RID: 2167
	[D4Packet.OpcodeAttribute(Opcodes.CMSG_USER_PROXY_GET_HERO_LIST)]
	public class GetHeroList : D4Packet
	{
		// Token: 0x04006400 RID: 25600
		public uint Token;
	}
}
