using System;

namespace D2Packets.Game.Server
{
	// Token: 0x020009C7 RID: 2503
	public class MercAttributeUInt32 : Packet
	{
		// Token: 0x04008AA1 RID: 35489
		public GameServerPacket PacketId;

		// Token: 0x04008AA2 RID: 35490
		public byte Attribute;

		// Token: 0x04008AA3 RID: 35491
		[MinVersion(GameVersion.D2R)]
		public byte pad;

		// Token: 0x04008AA4 RID: 35492
		public uint Id;

		// Token: 0x04008AA5 RID: 35493
		public uint Amount;
	}
}
