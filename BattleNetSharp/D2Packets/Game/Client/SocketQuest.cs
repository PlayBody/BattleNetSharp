using System;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A64 RID: 2660
	public class SocketQuest : Packet
	{
		// Token: 0x04008E9A RID: 36506
		public GameClientPacket PacketId;

		// Token: 0x04008E9B RID: 36507
		[MinVersion(GameVersion.D2R)]
		public uint Operation = 2U;

		// Token: 0x04008E9C RID: 36508
		[MinVersion(GameVersion.D2R)]
		public uint VendorId;

		// Token: 0x04008E9D RID: 36509
		[MinVersion(GameVersion.D2R)]
		public uint ItemId;

		// Token: 0x04008E9E RID: 36510
		[MinVersion(GameVersion.D2R)]
		public uint _1 = 1U;

		// Token: 0x04008E9F RID: 36511
		[MinVersion(GameVersion.D2R)]
		public ushort x;

		// Token: 0x04008EA0 RID: 36512
		[MinVersion(GameVersion.D2R)]
		public ushort y;
	}
}
