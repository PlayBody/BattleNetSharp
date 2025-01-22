using System;

namespace D2Packets.Game.Server
{
	// Token: 0x020009C8 RID: 2504
	public class MercByteToExperience : Packet
	{
		// Token: 0x04008AA6 RID: 35494
		public GameServerPacket PacketId;

		// Token: 0x04008AA7 RID: 35495
		[MinVersion(GameVersion.D2R)]
		public byte ExperienceD2R;

		// Token: 0x04008AA8 RID: 35496
		public byte Attribute;

		// Token: 0x04008AA9 RID: 35497
		[MinVersion(GameVersion.D2R)]
		public byte pad;

		// Token: 0x04008AAA RID: 35498
		public uint Id;

		// Token: 0x04008AAB RID: 35499
		[MaxVersion(GameVersion.LOD)]
		public byte ExperienceLOD;
	}
}
