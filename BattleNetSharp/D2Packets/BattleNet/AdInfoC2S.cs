using System;

namespace D2Packets.BattleNet
{
	// Token: 0x02000A9F RID: 2719
	public class AdInfoC2S : Packet
	{
		// Token: 0x04008FE8 RID: 36840
		public byte FF = byte.MaxValue;

		// Token: 0x04008FE9 RID: 36841
		public BattleNetPacket PacketId;

		// Token: 0x04008FEA RID: 36842
		public ushort Length;

		// Token: 0x04008FEB RID: 36843
		public uint Platform = Versioning.Platform;

		// Token: 0x04008FEC RID: 36844
		public uint Product = Versioning.Product;

		// Token: 0x04008FED RID: 36845
		public uint AdId = 0U;

		// Token: 0x04008FEE RID: 36846
		public uint Time = (uint)Environment.TickCount;
	}
}
