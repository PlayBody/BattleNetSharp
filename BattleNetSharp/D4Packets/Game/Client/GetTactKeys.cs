using System;
using Fenris.ClientMessage;

namespace D4Packets.Game.Client
{
	// Token: 0x0200087A RID: 2170
	[D4Packet.OpcodeAttribute(Opcodes.CMSG_USER_PROXY_GET_TACT_KEYS_REQUEST)]
	public class GetTactKeys : D4Packet
	{
		// Token: 0x04006405 RID: 25605
		public uint Token;

		// Token: 0x04006406 RID: 25606
		public GenericRequest req;
	}
}
