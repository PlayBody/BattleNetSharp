using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009B5 RID: 2485
	public class GameLogonReceipt : Packet
	{
		// Token: 0x04008996 RID: 35222
		public GameServerPacket PacketId;

		// Token: 0x04008997 RID: 35223
		public GameDifficulty Difficulty;

		// Token: 0x04008998 RID: 35224
		public byte unk;

		// Token: 0x04008999 RID: 35225
		public byte hardcore;

		// Token: 0x0400899A RID: 35226
		public ushort unk2;

		// Token: 0x0400899B RID: 35227
		public byte Expansion;

		// Token: 0x0400899C RID: 35228
		public byte Ladder;
	}
}
