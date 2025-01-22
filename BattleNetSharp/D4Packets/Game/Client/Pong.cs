using System;

namespace D4Packets.Game.Client
{
	// Token: 0x020008AB RID: 2219
	[D4Packet.OpcodeAttribute(Opcodes.SMSG_PONG)]
	public class Pong : D4Packet
	{
		// Token: 0x040064CB RID: 25803
		public uint Value;
	}
}
