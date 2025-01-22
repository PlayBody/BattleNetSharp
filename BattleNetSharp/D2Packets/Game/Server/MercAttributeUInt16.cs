using System;

namespace D2Packets.Game.Server
{
	// Token: 0x020009C6 RID: 2502
	public class MercAttributeUInt16 : Packet
	{
		// Token: 0x04008A9C RID: 35484
		public GameServerPacket PacketId;

		// Token: 0x04008A9D RID: 35485
		public byte Attribute;

		// Token: 0x04008A9E RID: 35486
		[MinVersion(GameVersion.D2R)]
		public byte pad;

		// Token: 0x04008A9F RID: 35487
		public uint Id;

		// Token: 0x04008AA0 RID: 35488
		public ushort Amount;
	}
}
