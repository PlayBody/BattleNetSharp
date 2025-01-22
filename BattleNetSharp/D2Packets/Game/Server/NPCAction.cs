using System;

namespace D2Packets.Game.Server
{
	// Token: 0x020009CF RID: 2511
	public class NPCAction : Packet
	{
		// Token: 0x04008AC5 RID: 35525
		public GameServerPacket PacketId;

		// Token: 0x04008AC6 RID: 35526
		public uint Id;

		// Token: 0x04008AC7 RID: 35527
		public byte ActionType;

		// Token: 0x04008AC8 RID: 35528
		public uint unk;

		// Token: 0x04008AC9 RID: 35529
		public ushort unk2;

		// Token: 0x04008ACA RID: 35530
		public ushort X;

		// Token: 0x04008ACB RID: 35531
		public ushort Y;
	}
}
