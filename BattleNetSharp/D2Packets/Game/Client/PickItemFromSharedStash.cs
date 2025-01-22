using System;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A4A RID: 2634
	public class PickItemFromSharedStash : Packet
	{
		// Token: 0x04008E0E RID: 36366
		public GameClientPacket PacketId;

		// Token: 0x04008E0F RID: 36367
		public uint ItemId;

		// Token: 0x04008E10 RID: 36368
		public uint SharedStashId;

		// Token: 0x04008E11 RID: 36369
		public ushort X;

		// Token: 0x04008E12 RID: 36370
		public ushort Y;
	}
}
