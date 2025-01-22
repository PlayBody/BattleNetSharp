using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A2D RID: 2605
	public class ClickButton : Packet
	{
		// Token: 0x04008CC6 RID: 36038
		public GameClientPacket PacketId;

		// Token: 0x04008CC7 RID: 36039
		public GameButton Button;

		// Token: 0x04008CC8 RID: 36040
		public uint Complement = 0U;
	}
}
