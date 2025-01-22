using System;
using Fenris.ClientMessage;

namespace D4Packets.Game.Client
{
	// Token: 0x0200087D RID: 2173
	[D4Packet.OpcodeAttribute(Opcodes.CMSG_USER_PROXY_LOGIN)]
	public class ProxyLogin : D4Packet
	{
		// Token: 0x0400640A RID: 25610
		public uint Token;

		// Token: 0x0400640B RID: 25611
		public GetInitialDataRequest DataRequest;
	}
}
