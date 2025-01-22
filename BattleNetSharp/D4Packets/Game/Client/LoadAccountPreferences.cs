using System;

namespace D4Packets.Game.Client
{
	// Token: 0x0200087C RID: 2172
	[D4Packet.OpcodeAttribute(Opcodes.CMSG_USER_PROXY_LOAD_ACCOUNT_PREFERENCES)]
	public class LoadAccountPreferences : D4Packet
	{
		// Token: 0x04006409 RID: 25609
		public uint Token;
	}
}
