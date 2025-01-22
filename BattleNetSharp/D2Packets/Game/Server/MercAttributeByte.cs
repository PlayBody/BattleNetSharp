using System;

namespace D2Packets.Game.Server
{
	// Token: 0x020009C5 RID: 2501
	public class MercAttributeByte : Packet
	{
		// Token: 0x04008A96 RID: 35478
		public GameServerPacket PacketId;

		// Token: 0x04008A97 RID: 35479
		[MinVersion(GameVersion.D2R)]
		public byte AmountD2R;

		// Token: 0x04008A98 RID: 35480
		public byte Attribute;

		// Token: 0x04008A99 RID: 35481
		[MinVersion(GameVersion.D2R)]
		public byte pad;

		// Token: 0x04008A9A RID: 35482
		public uint Id;

		// Token: 0x04008A9B RID: 35483
		[MaxVersion(GameVersion.LOD)]
		public byte AmountLOD;
	}
}
