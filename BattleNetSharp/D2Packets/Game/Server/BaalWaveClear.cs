using System;

namespace D2Packets.Game.Server
{
	// Token: 0x020009A8 RID: 2472
	public class BaalWaveClear : Packet
	{
		// Token: 0x04008968 RID: 35176
		public GameServerPacket PacketId;

		// Token: 0x04008969 RID: 35177
		public BaalWaveClear.WaveType Wave;

		// Token: 0x0200134D RID: 4941
		public enum WaveType : ushort
		{
			// Token: 0x04009E28 RID: 40488
			Shaman = 62,
			// Token: 0x04009E29 RID: 40489
			Fallen = 23,
			// Token: 0x04009E2A RID: 40490
			Mummies = 105,
			// Token: 0x04009E2B RID: 40491
			Skellies = 125,
			// Token: 0x04009E2C RID: 40492
			Council = 45,
			// Token: 0x04009E2D RID: 40493
			Pitlords,
			// Token: 0x04009E2E RID: 40494
			Minions = 59
		}
	}
}
