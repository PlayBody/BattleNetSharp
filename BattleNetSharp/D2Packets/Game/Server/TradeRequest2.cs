using System;

namespace D2Packets.Game.Server
{
	// Token: 0x02000A0A RID: 2570
	public class TradeRequest2 : Packet
	{
		// Token: 0x04008C19 RID: 35865
		public GameServerPacket PacketId;

		// Token: 0x04008C1A RID: 35866
		public byte One;

		// Token: 0x04008C1B RID: 35867
		public uint Guid;

		// Token: 0x04008C1C RID: 35868
		public ulong unkzero;

		// Token: 0x04008C1D RID: 35869
		public uint myId;

		// Token: 0x04008C1E RID: 35870
		public byte singlezero;

		// Token: 0x04008C1F RID: 35871
		public ulong unkzero2;

		// Token: 0x04008C20 RID: 35872
		public uint traderId;

		// Token: 0x04008C21 RID: 35873
		public byte singlezero2;

		// Token: 0x04008C22 RID: 35874
		public uint unkzero3;
	}
}
