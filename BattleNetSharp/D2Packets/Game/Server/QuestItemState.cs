using System;

namespace D2Packets.Game.Server
{
	// Token: 0x020009F3 RID: 2547
	public class QuestItemState : Packet
	{
		// Token: 0x04008BAB RID: 35755
		public GameServerPacket PacketId;

		// Token: 0x04008BAC RID: 35756
		public byte QuestId;

		// Token: 0x04008BAD RID: 35757
		public byte AlertFlags;

		// Token: 0x04008BAE RID: 35758
		public byte FilterStatus;

		// Token: 0x04008BAF RID: 35759
		public ushort Extra;
	}
}
