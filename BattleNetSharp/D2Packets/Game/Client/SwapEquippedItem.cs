using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A6B RID: 2667
	public class SwapEquippedItem : Packet
	{
		// Token: 0x04008EBD RID: 36541
		public GameClientPacket PacketId;

		// Token: 0x04008EBE RID: 36542
		public uint Id;

		// Token: 0x04008EBF RID: 36543
		[MinVersion(GameVersion.D2R)]
		public uint EquippedId;

		// Token: 0x04008EC0 RID: 36544
		public EquipmentLocation Location;

		// Token: 0x04008EC1 RID: 36545
		public ushort pad;
	}
}
