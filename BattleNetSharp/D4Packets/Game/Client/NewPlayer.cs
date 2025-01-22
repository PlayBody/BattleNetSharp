using System;
using Fenris.Hero;

namespace D4Packets.Game.Client
{
	// Token: 0x02000893 RID: 2195
	[D4Packet.OpcodeAttribute(Opcodes.SMSG_NEW_PLAYER)]
	public class NewPlayer : D4Packet
	{
		// Token: 0x04006463 RID: 25699
		public NewPlayerMessage Message;
	}
}
