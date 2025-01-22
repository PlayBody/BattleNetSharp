using System;
using Fenris.ClientMessage;

namespace D4Packets.Game.Client
{
	// Token: 0x0200087B RID: 2171
	[D4Packet.OpcodeAttribute(Opcodes.CMSG_USER_PROXY_ACTIVATE_TACT_KEYS_DEBUG_REQUEST)]
	public class ActivateTactKeys : D4Packet
	{
		// Token: 0x04006407 RID: 25607
		public uint Token;

		// Token: 0x04006408 RID: 25608
		public ActivateTACTKeysRequest req;
	}
}
