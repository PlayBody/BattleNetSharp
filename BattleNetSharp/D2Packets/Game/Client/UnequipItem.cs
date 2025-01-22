using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A79 RID: 2681
	public class UnequipItem : Packet
	{
		// Token: 0x04008F1B RID: 36635
		public GameClientPacket PacketId;

		// Token: 0x04008F1C RID: 36636
		[MinVersion(GameVersion.D2R)]
		public uint Id;

		// Token: 0x04008F1D RID: 36637
		public EquipmentLocation Location;

		// Token: 0x04008F1E RID: 36638
		[MinVersion(GameVersion.D2R)]
		public ushort Zero;
	}
}
