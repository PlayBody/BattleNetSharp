using System;

namespace D4Packets.Game.Client
{
	// Token: 0x0200088A RID: 2186
	[D4Packet.OpcodeAttribute(Opcodes.SMSG_DESTROY_SCENE)]
	public class DestroyScene : D4Packet
	{
		// Token: 0x04006449 RID: 25673
		public long SceneID;
	}
}
