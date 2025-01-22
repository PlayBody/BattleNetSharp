using System;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AAA RID: 2730
	public class ChatEventC2S : Packet
	{
		// Token: 0x0400904B RID: 36939
		public byte FF = byte.MaxValue;

		// Token: 0x0400904C RID: 36940
		public BattleNetPacket PacketId;

		// Token: 0x0400904D RID: 36941
		public ushort Length;

		// Token: 0x0400904E RID: 36942
		public uint Platform = Versioning.Platform;

		// Token: 0x0400904F RID: 36943
		public uint Product = Versioning.Product;

		// Token: 0x04009050 RID: 36944
		public uint AdId = 0U;

		// Token: 0x04009051 RID: 36945
		public uint Time = (uint)Environment.TickCount;
	}
}
