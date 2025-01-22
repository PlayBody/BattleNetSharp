using System;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A7B RID: 2683
	public class UpdatePosition : Packet
	{
		// Token: 0x04008F25 RID: 36645
		public GameClientPacket PacketId;

		// Token: 0x04008F26 RID: 36646
		public ushort X;

		// Token: 0x04008F27 RID: 36647
		public ushort Y;
	}
}
