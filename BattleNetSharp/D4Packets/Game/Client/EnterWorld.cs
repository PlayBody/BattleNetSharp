using System;

namespace D4Packets.Game.Client
{
	// Token: 0x0200088B RID: 2187
	[D4Packet.OpcodeAttribute(Opcodes.SMSG_ENTER_WORLD)]
	public class EnterWorld : D4Packet
	{
		// Token: 0x0400644A RID: 25674
		public long WorldID;

		// Token: 0x0400644B RID: 25675
		public int snoWorld;

		// Token: 0x0400644C RID: 25676
		[DynamicLen(2)]
		public Player[] atPlayers;
	}
}
