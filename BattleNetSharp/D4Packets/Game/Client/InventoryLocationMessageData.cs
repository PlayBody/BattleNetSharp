using System;

namespace D4Packets.Game.Client
{
	// Token: 0x02000884 RID: 2180
	public class InventoryLocationMessageData : D4Packet
	{
		// Token: 0x04006437 RID: 25655
		public long OwnerID;

		// Token: 0x04006438 RID: 25656
		public int EquipmentSlot;

		// Token: 0x04006439 RID: 25657
		public Vector2 InventoryLocation;
	}
}
