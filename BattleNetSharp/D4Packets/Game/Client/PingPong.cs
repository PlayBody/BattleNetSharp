using System;

namespace D4Packets.Game.Client
{
	// Token: 0x020008C2 RID: 2242
	[D4Packet.OpcodeAttribute(Opcodes.SMSG_PING_PONG)]
	public class PingPong : D4Packet
	{
		// Token: 0x04006523 RID: 25891
		public uint Value;
	}
}
