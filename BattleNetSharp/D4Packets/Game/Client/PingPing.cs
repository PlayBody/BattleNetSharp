using System;

namespace D4Packets.Game.Client
{
	// Token: 0x0200087F RID: 2175
	[D4Packet.OpcodeAttribute(Opcodes.CMSG_PING_PING)]
	public class PingPing : D4Packet
	{
		// Token: 0x0400640F RID: 25615
		public uint Value;
	}
}
