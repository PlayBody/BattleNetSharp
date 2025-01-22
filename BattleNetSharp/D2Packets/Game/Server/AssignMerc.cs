using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x0200099B RID: 2459
	public class AssignMerc : Packet
	{
		// Token: 0x04008915 RID: 35093
		public GameServerPacket PacketId;

		// Token: 0x04008916 RID: 35094
		public byte Skill;

		// Token: 0x04008917 RID: 35095
		public NPCCode NpcType;

		// Token: 0x04008918 RID: 35096
		public uint OwnerId;

		// Token: 0x04008919 RID: 35097
		public uint Id;

		// Token: 0x0400891A RID: 35098
		[MinVersion(GameVersion.D2R)]
		public uint _40c;

		// Token: 0x0400891B RID: 35099
		public uint Seed2;

		// Token: 0x0400891C RID: 35100
		public uint Seed;
	}
}
