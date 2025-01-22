using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x02000A04 RID: 2564
	public class StateSkillMove : Packet
	{
		// Token: 0x04008BFC RID: 35836
		public GameServerPacket PacketId;

		// Token: 0x04008BFD RID: 35837
		public UnitType Type;

		// Token: 0x04008BFE RID: 35838
		public uint Id;

		// Token: 0x04008BFF RID: 35839
		public SkillType Skill;
	}
}
