using System;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A23 RID: 2595
	public class AddBeltItem : Packet
	{
		// Token: 0x04008C8D RID: 35981
		public GameClientPacket PacketId;

		// Token: 0x04008C8E RID: 35982
		public uint Id;

		// Token: 0x04008C8F RID: 35983
		public ushort X;

		// Token: 0x04008C90 RID: 35984
		public ushort Y;
	}
}
