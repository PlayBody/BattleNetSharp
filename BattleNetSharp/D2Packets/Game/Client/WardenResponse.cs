using System;
using System.Collections.Generic;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A81 RID: 2689
	public class WardenResponse : Packet
	{
		// Token: 0x04008F55 RID: 36693
		public GameClientPacket PacketId;

		// Token: 0x04008F56 RID: 36694
		public uint Length;

		// Token: 0x04008F57 RID: 36695
		public List<byte> Data = new List<byte>();
	}
}
