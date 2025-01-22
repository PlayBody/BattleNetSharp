using System;

namespace D4Packets.Game.Client
{
	// Token: 0x020008B5 RID: 2229
	[D4Packet.OpcodeAttribute(Opcodes.SMSG_WORLD_DELETED)]
	public class WorldDeleted : D4Packet
	{
		// Token: 0x04006503 RID: 25859
		public long WorldID;
	}
}
