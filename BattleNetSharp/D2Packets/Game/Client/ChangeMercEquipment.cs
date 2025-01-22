using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A2C RID: 2604
	public class ChangeMercEquipment : Packet
	{
		// Token: 0x04008CC0 RID: 36032
		public GameClientPacket PacketId;

		// Token: 0x04008CC1 RID: 36033
		[MinVersion(GameVersion.D2R)]
		public uint ItemId;

		// Token: 0x04008CC2 RID: 36034
		[MinVersion(GameVersion.D2R)]
		public uint MercId;

		// Token: 0x04008CC3 RID: 36035
		[MinVersion(GameVersion.D2R)]
		public uint MouseId = uint.MaxValue;

		// Token: 0x04008CC4 RID: 36036
		public EquipmentLocation Location;

		// Token: 0x04008CC5 RID: 36037
		[MinVersion(GameVersion.D2R)]
		public ushort LocPad;
	}
}
