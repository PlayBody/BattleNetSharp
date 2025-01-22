using System;

namespace D4Packets.Game.Client
{
	// Token: 0x0200087E RID: 2174
	[D4Packet.OpcodeAttribute(Opcodes.CMSG_PING_CONNECT)]
	public class PingConnect : D4Packet
	{
		// Token: 0x0400640C RID: 25612
		public ushort unk1;

		// Token: 0x0400640D RID: 25613
		public uint unk2;

		// Token: 0x0400640E RID: 25614
		public uint Value;
	}
}
