using System;

namespace D4Packets.Game.Client
{
	// Token: 0x02000890 RID: 2192
	[D4Packet.OpcodeAttribute(Opcodes.SMSG_HEARTBEAT)]
	public class Heartbeat : D4Packet
	{
		// Token: 0x04006456 RID: 25686
		public int dwData;
	}
}
