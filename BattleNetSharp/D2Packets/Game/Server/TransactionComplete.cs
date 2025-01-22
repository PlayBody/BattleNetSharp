using System;

namespace D2Packets.Game.Server
{
	// Token: 0x02000A0B RID: 2571
	public class TransactionComplete : Packet
	{
		// Token: 0x04008C23 RID: 35875
		public GameServerPacket PacketId;

		// Token: 0x04008C24 RID: 35876
		public TransactionComplete.TransactionType Type;

		// Token: 0x04008C25 RID: 35877
		public uint Unk1;

		// Token: 0x04008C26 RID: 35878
		public byte Un2;

		// Token: 0x04008C27 RID: 35879
		public uint Id;

		// Token: 0x04008C28 RID: 35880
		public uint GoldRemaining;

		// Token: 0x0200135C RID: 4956
		public enum TransactionType : byte
		{
			// Token: 0x04009E5C RID: 40540
			Buy = 4,
			// Token: 0x04009E5D RID: 40541
			Hire = 0,
			// Token: 0x04009E5E RID: 40542
			Repair,
			// Token: 0x04009E5F RID: 40543
			Sell = 3,
			// Token: 0x04009E60 RID: 40544
			ToStack = 5
		}
	}
}
