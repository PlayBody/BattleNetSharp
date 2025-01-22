using System;

namespace D2Packets.Game.Server
{
	// Token: 0x020009E4 RID: 2532
	public class PlayerKillCount : Packet
	{
		// Token: 0x04008B4D RID: 35661
		public GameServerPacket PacketId;

		// Token: 0x04008B4E RID: 35662
		public uint Id;

		// Token: 0x04008B4F RID: 35663
		public ushort Count;
	}
}
