using System;
using System.Collections.Generic;

namespace D2Packets.Game.Server
{
	// Token: 0x02000A21 RID: 2593
	public class WardenCheck : Packet
	{
		// Token: 0x04008C8A RID: 35978
		public GameServerPacket PacketId;

		// Token: 0x04008C8B RID: 35979
		public ushort DataLength;

		// Token: 0x04008C8C RID: 35980
		public List<byte> WardenData;
	}
}
