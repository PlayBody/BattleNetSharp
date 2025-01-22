using System;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AC6 RID: 2758
	public class SetEmailS2C : Packet
	{
		// Token: 0x040090E4 RID: 37092
		public byte FF = byte.MaxValue;

		// Token: 0x040090E5 RID: 37093
		public BattleNetPacket PacketId;

		// Token: 0x040090E6 RID: 37094
		public ushort Length;
	}
}
