using System;

namespace D4Packets.Game.Client
{
	// Token: 0x02000870 RID: 2160
	[D4Packet.OpcodeAttribute(Opcodes.CMSG_PING)]
	public class Ping : D4Packet
	{
		// Token: 0x040063F5 RID: 25589
		public uint Value;
	}
}
