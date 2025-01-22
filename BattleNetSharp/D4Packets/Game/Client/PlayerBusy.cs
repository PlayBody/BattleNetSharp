using System;

namespace D4Packets.Game.Client
{
	// Token: 0x02000871 RID: 2161
	[D4Packet.OpcodeAttribute(Opcodes.CMSG_PLAYER_BUSY)]
	public class PlayerBusy : D4Packet
	{
		// Token: 0x040063F6 RID: 25590
		public bool busy;
	}
}
