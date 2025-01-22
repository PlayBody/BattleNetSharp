using System;

namespace D4Packets.Game.Client
{
	// Token: 0x0200088F RID: 2191
	[D4Packet.OpcodeAttribute(Opcodes.SMSG_GAME_SETUP)]
	public class GameSetup : D4Packet
	{
		// Token: 0x04006454 RID: 25684
		public uint FirstTick;

		// Token: 0x04006455 RID: 25685
		public ulong BnetAccountLow;
	}
}
