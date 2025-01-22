using System;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AC1 RID: 2753
	public class QueryRealmsC2S : Packet
	{
		// Token: 0x040090C8 RID: 37064
		public byte FF = byte.MaxValue;

		// Token: 0x040090C9 RID: 37065
		public BattleNetPacket PacketId;

		// Token: 0x040090CA RID: 37066
		public ushort Length;
	}
}
