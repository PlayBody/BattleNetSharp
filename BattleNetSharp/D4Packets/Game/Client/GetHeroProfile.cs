using System;
using Fenris.ClientMessage;

namespace D4Packets.Game.Client
{
	// Token: 0x02000878 RID: 2168
	[D4Packet.OpcodeAttribute(Opcodes.CMSG_USER_PROXY_GET_HERO_PROFILE)]
	public class GetHeroProfile : D4Packet
	{
		// Token: 0x04006401 RID: 25601
		public uint Token;

		// Token: 0x04006402 RID: 25602
		public GetHeroProfileRequest Account;
	}
}
