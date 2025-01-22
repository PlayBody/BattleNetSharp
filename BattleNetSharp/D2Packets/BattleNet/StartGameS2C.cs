using System;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AC9 RID: 2761
	public class StartGameS2C : Packet
	{
		// Token: 0x040090F7 RID: 37111
		public byte FF = byte.MaxValue;

		// Token: 0x040090F8 RID: 37112
		public BattleNetPacket PacketId;

		// Token: 0x040090F9 RID: 37113
		public uint Status;
	}
}
