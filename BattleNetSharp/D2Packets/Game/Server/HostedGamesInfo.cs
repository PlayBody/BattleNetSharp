using System;

namespace D2Packets.Game.Server
{
	// Token: 0x020009BD RID: 2493
	public class HostedGamesInfo : Packet
	{
		// Token: 0x04008A35 RID: 35381
		public GameServerPacket PacketId;

		// Token: 0x04008A36 RID: 35382
		public byte u0a;

		// Token: 0x04008A37 RID: 35383
		public ushort u0v;

		// Token: 0x04008A38 RID: 35384
		public uint u0x;

		// Token: 0x04008A39 RID: 35385
		public ulong u1;

		// Token: 0x04008A3A RID: 35386
		public ulong u2;

		// Token: 0x04008A3B RID: 35387
		public ulong P1;

		// Token: 0x04008A3C RID: 35388
		public ulong P2;

		// Token: 0x04008A3D RID: 35389
		public ulong P3;

		// Token: 0x04008A3E RID: 35390
		public byte u0b;

		// Token: 0x04008A3F RID: 35391
		public ushort ClientsCount;

		// Token: 0x04008A40 RID: 35392
		public ushort GameToken;
	}
}
