using System;

namespace D2Packets.Game.Server
{
	// Token: 0x020009E1 RID: 2529
	public class PlayerCorpseVisible : Packet
	{
		// Token: 0x04008B30 RID: 35632
		public GameServerPacket PacketId;

		// Token: 0x04008B31 RID: 35633
		public byte Assign;

		// Token: 0x04008B32 RID: 35634
		public uint PlayerId;

		// Token: 0x04008B33 RID: 35635
		public uint CorpseId;
	}
}
