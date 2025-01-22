using System;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A6E RID: 2670
	public class SwitchItemShared : Packet
	{
		// Token: 0x04008ED4 RID: 36564
		public GameClientPacket PacketId;

		// Token: 0x04008ED5 RID: 36565
		public uint ItemId;

		// Token: 0x04008ED6 RID: 36566
		public uint SharedStashId;

		// Token: 0x04008ED7 RID: 36567
		public uint Unk1 = 4U;

		// Token: 0x04008ED8 RID: 36568
		public ushort X;

		// Token: 0x04008ED9 RID: 36569
		public ushort Y;

		// Token: 0x04008EDA RID: 36570
		public uint Unk;

		// Token: 0x04008EDB RID: 36571
		public ushort TargetX;

		// Token: 0x04008EDC RID: 36572
		public ushort TargetY;

		// Token: 0x04008EDD RID: 36573
		public uint Unk2 = 1U;
	}
}
