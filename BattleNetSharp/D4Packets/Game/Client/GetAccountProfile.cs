using System;
using Fenris.ClientMessage;

namespace D4Packets.Game.Client
{
	// Token: 0x02000875 RID: 2165
	[D4Packet.OpcodeAttribute(Opcodes.CMSG_USER_PROXY_GET_ACCOUNT_PROFILE)]
	public class GetAccountProfile : D4Packet
	{
		// Token: 0x040063FC RID: 25596
		public uint Token;

		// Token: 0x040063FD RID: 25597
		public GetAccountProfileRequest Account;
	}
}
