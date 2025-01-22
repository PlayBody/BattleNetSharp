using System;

namespace D4Packets.Game.Client
{
	// Token: 0x020008B4 RID: 2228
	[D4Packet.OpcodeAttribute(Opcodes.SMSG_VERSIONS)]
	public class Versions : D4Packet
	{
		// Token: 0x04006500 RID: 25856
		public uint Hash = 1458629466U;

		// Token: 0x04006501 RID: 25857
		[DynamicLen(32)]
		public string Version = "Blizzless - Diablo IV";

		// Token: 0x04006502 RID: 25858
		public long field0 = 0L;
	}
}
