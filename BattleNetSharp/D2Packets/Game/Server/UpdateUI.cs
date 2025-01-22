using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x02000A1D RID: 2589
	public class UpdateUI : Packet
	{
		// Token: 0x04008C7B RID: 35963
		public GameServerPacket PacketId;

		// Token: 0x04008C7C RID: 35964
		public UIAction Action;
	}
}
