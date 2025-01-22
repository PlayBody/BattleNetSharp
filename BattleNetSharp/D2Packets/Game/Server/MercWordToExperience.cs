using System;

namespace D2Packets.Game.Server
{
	// Token: 0x020009CC RID: 2508
	public class MercWordToExperience : Packet
	{
		// Token: 0x04008AB3 RID: 35507
		public GameServerPacket PacketId;

		// Token: 0x04008AB4 RID: 35508
		[MinVersion(GameVersion.D2R)]
		public ushort ExperienceD2R;

		// Token: 0x04008AB5 RID: 35509
		public byte Attribute;

		// Token: 0x04008AB6 RID: 35510
		[MinVersion(GameVersion.D2R)]
		public byte pad;

		// Token: 0x04008AB7 RID: 35511
		public uint Id;

		// Token: 0x04008AB8 RID: 35512
		[MaxVersion(GameVersion.LOD)]
		public ushort ExperienceLOD;
	}
}
