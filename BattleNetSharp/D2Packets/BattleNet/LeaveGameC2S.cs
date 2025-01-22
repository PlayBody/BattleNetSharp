using System;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AB9 RID: 2745
	public class LeaveGameC2S : Packet
	{
		// Token: 0x0400909F RID: 37023
		public byte FF = byte.MaxValue;

		// Token: 0x040090A0 RID: 37024
		public BattleNetPacket PacketId;

		// Token: 0x040090A1 RID: 37025
		public ushort four = 4;
	}
}
