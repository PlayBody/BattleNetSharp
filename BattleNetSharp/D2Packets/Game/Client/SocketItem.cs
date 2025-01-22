using System;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A63 RID: 2659
	public class SocketItem : Packet
	{
		// Token: 0x04008E93 RID: 36499
		public GameClientPacket PacketId;

		// Token: 0x04008E94 RID: 36500
		public uint SubjectId;

		// Token: 0x04008E95 RID: 36501
		public uint ObjectId;

		// Token: 0x04008E96 RID: 36502
		[MinVersion(GameVersion.D2R)]
		public uint EquipmentLocation;

		// Token: 0x04008E97 RID: 36503
		[MinVersion(GameVersion.D2R)]
		public uint ItemLocation;

		// Token: 0x04008E98 RID: 36504
		[MinVersion(GameVersion.D2R)]
		public ushort X;

		// Token: 0x04008E99 RID: 36505
		[MinVersion(GameVersion.D2R)]
		public ushort Y;
	}
}
