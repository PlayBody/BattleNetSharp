using System;

namespace D4Packets.Game.Client
{
	// Token: 0x02000887 RID: 2183
	[D4Packet.OpcodeAttribute(Opcodes.SMSG_ATTRIBUTES_SET_VALUES)]
	public class AttributesSetValues : D4Packet
	{
		// Token: 0x04006441 RID: 25665
		public uint FirstTick = 6U;

		// Token: 0x04006442 RID: 25666
		public ulong Field1 = 270UL;
	}
}
