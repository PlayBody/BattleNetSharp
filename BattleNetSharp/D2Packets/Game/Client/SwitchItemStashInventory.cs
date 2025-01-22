using System;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A6F RID: 2671
	public class SwitchItemStashInventory : Packet
	{
		// Token: 0x04008EDE RID: 36574
		public GameClientPacket PacketId;

		// Token: 0x04008EDF RID: 36575
		public uint ItemId;

		// Token: 0x04008EE0 RID: 36576
		public uint SrcContainer;

		// Token: 0x04008EE1 RID: 36577
		public ushort SrcX;

		// Token: 0x04008EE2 RID: 36578
		public ushort SrcY;

		// Token: 0x04008EE3 RID: 36579
		public uint DestContainer;

		// Token: 0x04008EE4 RID: 36580
		public ushort DestX;

		// Token: 0x04008EE5 RID: 36581
		public ushort DestY;
	}
}
