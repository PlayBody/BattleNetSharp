using System;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AC7 RID: 2759
	public class SetEmailC2S : Packet
	{
		// Token: 0x040090E7 RID: 37095
		public byte FF = byte.MaxValue;

		// Token: 0x040090E8 RID: 37096
		public BattleNetPacket PacketId;

		// Token: 0x040090E9 RID: 37097
		public ushort Length;

		// Token: 0x040090EA RID: 37098
		public byte Zero = 0;
	}
}
