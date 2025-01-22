using System;
using Fenris.Router;

namespace D4Packets.Game.Client
{
	// Token: 0x020008B8 RID: 2232
	[D4Packet.OpcodeAttribute(Opcodes.SMSG_USER_PROXY_CONNECTED)]
	public class ProxyConnected : D4Packet
	{
		// Token: 0x0400650A RID: 25866
		public Connected ConnectedMessage;
	}
}
