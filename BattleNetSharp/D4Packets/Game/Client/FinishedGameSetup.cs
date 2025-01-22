using System;

namespace D4Packets.Game.Client
{
	// Token: 0x0200086D RID: 2157
	[D4Packet.OpcodeAttribute(Opcodes.CMSG_FINISHED_GAME_SETUP)]
	public class FinishedGameSetup : D4Packet
	{
		// Token: 0x040063ED RID: 25581
		public uint field0;

		// Token: 0x040063EE RID: 25582
		public uint field1;

		// Token: 0x040063EF RID: 25583
		[FixedLen(18U)]
		public uint field2;
	}
}
