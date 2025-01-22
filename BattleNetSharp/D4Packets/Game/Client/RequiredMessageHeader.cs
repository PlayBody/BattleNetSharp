using System;

namespace D4Packets.Game.Client
{
	// Token: 0x02000881 RID: 2177
	public class RequiredMessageHeader : D4Packet
	{
		// Token: 0x04006412 RID: 25618
		[FixedLen(11U)]
		public int Opcode;

		// Token: 0x04006413 RID: 25619
		[FixedLen(2U)]
		public int Field1;

		// Token: 0x04006414 RID: 25620
		public ushort? Field2;
	}
}
