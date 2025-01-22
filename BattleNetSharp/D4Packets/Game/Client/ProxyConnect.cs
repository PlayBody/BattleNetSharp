using System;
using Fenris.Router;

namespace D4Packets.Game.Client
{
	// Token: 0x02000872 RID: 2162
	[D4Packet.OpcodeAttribute(Opcodes.CMSG_USER_PROXY_CONNECT)]
	public class ProxyConnect : D4Packet
	{
		// Token: 0x040063F7 RID: 25591
		public Connect ConnectMessage;
	}
}
