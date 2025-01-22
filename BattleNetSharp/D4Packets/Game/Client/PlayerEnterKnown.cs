using System;

namespace D4Packets.Game.Client
{
	// Token: 0x020008C3 RID: 2243
	[D4Packet.OpcodeAttribute(Opcodes.SMSG_PLAYER_ENTER_KNOWN)]
	public class PlayerEnterKnown : D4Packet
	{
		// Token: 0x04006524 RID: 25892
		public uint PlayerIndex;

		// Token: 0x04006525 RID: 25893
		public long ActorId;
	}
}
