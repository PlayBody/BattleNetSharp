using System;
using System.Collections.Generic;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A38 RID: 2616
	public class EquipSmallBelt : Packet
	{
		// Token: 0x04008CE9 RID: 36073
		public GameClientPacket PacketId;

		// Token: 0x04008CEA RID: 36074
		public uint EquippedBelt;

		// Token: 0x04008CEB RID: 36075
		public uint CursorBelt;

		// Token: 0x04008CEC RID: 36076
		public byte NumPots;

		// Token: 0x04008CED RID: 36077
		public List<EquipSmallBelt.PotLocation> Pots = new List<EquipSmallBelt.PotLocation>();

		// Token: 0x04008CEE RID: 36078
		public EquipSmallBelt.PotLocation LastPot;

		// Token: 0x02001367 RID: 4967
		public class PotLocation : Packet
		{
			// Token: 0x04009E86 RID: 40582
			public uint Id = uint.MaxValue;

			// Token: 0x04009E87 RID: 40583
			public byte BeltPos;

			// Token: 0x04009E88 RID: 40584
			public byte InventoryXY;

			// Token: 0x04009E89 RID: 40585
			public byte Location = 1;
		}
	}
}
