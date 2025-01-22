using System;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AAE RID: 2734
	public class DisplayAdC2S : Packet
	{
		// Token: 0x0600BBF6 RID: 48118 RVA: 0x004740DD File Offset: 0x004722DD
		public DisplayAdC2S(uint id)
		{
			this.AdId = id;
		}

		// Token: 0x04009068 RID: 36968
		public byte FF = byte.MaxValue;

		// Token: 0x04009069 RID: 36969
		public BattleNetPacket PacketId;

		// Token: 0x0400906A RID: 36970
		public ushort Length;

		// Token: 0x0400906B RID: 36971
		public uint Platform = Versioning.Platform;

		// Token: 0x0400906C RID: 36972
		public uint Product = Versioning.Product;

		// Token: 0x0400906D RID: 36973
		public uint AdId;

		// Token: 0x0400906E RID: 36974
		public uint Time = (uint)Environment.TickCount;
	}
}
