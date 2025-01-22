using System;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AC0 RID: 2752
	public class PingS2C : Packet
	{
		// Token: 0x040090C4 RID: 37060
		public byte FF = byte.MaxValue;

		// Token: 0x040090C5 RID: 37061
		public BattleNetPacket PacketId;

		// Token: 0x040090C6 RID: 37062
		public ushort Length;

		// Token: 0x040090C7 RID: 37063
		public uint Ping;
	}
}
