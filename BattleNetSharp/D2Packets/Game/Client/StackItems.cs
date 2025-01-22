using System;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A66 RID: 2662
	public class StackItems : Packet
	{
		// Token: 0x04008EA6 RID: 36518
		public GameClientPacket PacketId;

		// Token: 0x04008EA7 RID: 36519
		public uint SubjectId;

		// Token: 0x04008EA8 RID: 36520
		public uint ObjectId;

		// Token: 0x04008EA9 RID: 36521
		[MinVersion(GameVersion.D2R)]
		public uint Consumed;

		// Token: 0x04008EAA RID: 36522
		[MinVersion(GameVersion.D2R)]
		public uint ItemLocation;

		// Token: 0x04008EAB RID: 36523
		[MinVersion(GameVersion.D2R)]
		public ushort X;

		// Token: 0x04008EAC RID: 36524
		[MinVersion(GameVersion.D2R)]
		public ushort Y;
	}
}
