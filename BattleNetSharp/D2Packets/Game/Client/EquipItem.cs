using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A37 RID: 2615
	public class EquipItem : Packet
	{
		// Token: 0x04008CE5 RID: 36069
		public GameClientPacket PacketId;

		// Token: 0x04008CE6 RID: 36070
		public uint Id;

		// Token: 0x04008CE7 RID: 36071
		public EquipmentLocation Location;

		// Token: 0x04008CE8 RID: 36072
		public ushort pad;
	}
}
